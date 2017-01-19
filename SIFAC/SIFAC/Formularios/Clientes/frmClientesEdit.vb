Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmClientesEdit

#Region "Declaración de Variables propias del formulario"
    Public dtGenero, dtCiudad, dtRutas As DataTable
    Public Shared dtContactos As DataTable
    Public dtOcupacion As DataTable
    Public DtPersona As DataTable
    Dim intTelefonoCliente, intResultado As Integer
    Dim imgCedulaAnverso, imgCedulaReverso As Byte()
#End Region
   
#Region "Busqueda"
    '' Descripción:        Procedimiento encargado de cargar la informacion de personas con clasificacion empleado que aun no han sido ingresadas en empleado
    Public Sub CargarPersona()
        Try
            Dim strFiltro As String = ""
            strFiltro = " Descripcion = 'Cliente' AND StbPersonaID NOT IN (SELECT objPersonaID FROM SccClientes)"
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero", "vwPersonaClasificacion", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de vincular los controles al origen de datos
    Public Sub VincularControles()
        Try

            Me.txtPrimerNombre.DataBindings.Clear()
            Me.txtSegundoNombre.DataBindings.Clear()
            Me.txtCedula.DataBindings.Clear()
            Me.txtPrimerApellido.DataBindings.Clear()
            Me.txtSegundoApellido.DataBindings.Clear()
            Me.cmbGenero.DataBindings.Clear()
            Me.dtpFechaNacimiento.DataBindings.Clear()
            Me.cmbCiudad.DataBindings.Clear()
            Me.txtDireccion.DataBindings.Clear()
            Me.cmbRuta.DataBindings.Clear()
            Me.spnOrdenCobro.DataBindings.Clear()

            Me.idpersona = DtPersona.Rows(0)("StbPersonaID")
            Me.txtPrimerNombre.DataBindings.Add("text", DtPersona, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtSegundoNombre.DataBindings.Add("text", DtPersona, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtCedula.DataBindings.Add("text", DtPersona, "Cedula", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtPrimerApellido.DataBindings.Add("text", DtPersona, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtSegundoApellido.DataBindings.Add("text", DtPersona, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtDireccion.DataBindings.Add("text", DtPersona, "Direccion", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.cmbGenero.SelectedValue = DtPersona.Rows(0)("objGeneroID")
            Me.cmbCiudad.SelectedValue = DtPersona.Rows(0)("objCiudadID")
            Me.dtpFechaNacimiento.Value = DtPersona.Rows(0)("FechaNacimiento")

            'Cargar Contactos
            frmClientesEdit.dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", "objPersonaID=" & Me.idpersona))
            Me.tdbContactos.SetDataBinding(frmClientesEdit.dtContactos, "", True)
            Me.tdbContactos.Caption = "Contactos (" & frmClientesEdit.dtContactos.Rows.Count & ")"

            If frmClientesEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If

            Me.tdbContactos.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar Combos"
    Private Sub CargarGenero()
        Try
            'Género
            dtGenero = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='GENERO')"))
            Me.cmbGenero.DataSource = dtGenero
            Me.cmbGenero.DisplayMember = "Descripcion"
            Me.cmbGenero.ValueMember = "StbValorCatalogoID"
            Me.cmbGenero.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbGenero.ExtendRightColumn = True
            Me.cmbGenero.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarCiudad()
        Dim objparametro As StbParametro
        Dim objPais As StbPais
        Try
            objparametro = New StbParametro
            objPais = New StbPais

            'Ciudad
            objparametro.RetrieveByFilter("Nombre='Pais'")
            objPais.RetrieveByFilter("Nombre='" & objparametro.Valor & "'")

            dtCiudad = StbCiudad.RetrieveDT("objPaisID=" & objPais.StbPaisID, "", "StbCiudadID,Nombre")
            Me.cmbCiudad.DataSource = dtCiudad
            Me.cmbCiudad.DisplayMember = "Nombre"
            Me.cmbCiudad.ValueMember = "StbCiudadID"
            Me.cmbCiudad.Splits(0).DisplayColumns("StbCiudadID").Visible = False
            Me.cmbCiudad.ExtendRightColumn = True
            Me.cmbCiudad.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPais = Nothing
            objparametro = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarRuta()
        Dim objRuta As StbRutas
        Try
            objRuta = New StbRutas
            'Rutas
            dtRutas = StbRutas.RetrieveDT("1=1", "", "StbRutaID,Nombre")
            Me.cmbRuta.DataSource = dtRutas
            Me.cmbRuta.DisplayMember = "Nombre"
            Me.cmbRuta.ValueMember = "StbRutaID"
            Me.cmbRuta.Splits(0).DisplayColumns("StbRutaID").Visible = False
            Me.cmbRuta.ExtendRightColumn = True
            Me.cmbRuta.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRuta = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#Region "Cargar Longitudes Máximas"
    Private Sub CargarLongitudesMaximas()
        Try
            Me.txtPrimerNombre.MaxLength = StbPersona.GetMaxLength("Nombre1")
            Me.txtSegundoNombre.MaxLength = StbPersona.GetMaxLength("Nombre2")
            Me.txtPrimerApellido.MaxLength = StbPersona.GetMaxLength("Apellido1")
            Me.txtSegundoApellido.MaxLength = StbPersona.GetMaxLength("Apellido2")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub
#End Region

#Region "Validar Ingresos"
    Public Function ValidarNumeroTelefono()
        Try
            Me.intResultado = 0

            'Se valida que haya al menos un teléfono si es cliente
            If frmClientesEdit.dtContactos.Rows.Count = 0 Then
                Me.intResultado = 1
            End If


            'For Each dr As DataRow In frmClientesEdit.dtContactos.Rows
            '    Dim s As String = dr("TipoEntrada").ToString.Substring(0, 8)
            '    If dr("TipoEntrada").ToString.Trim.Length >= 8 Then
            '        If dr("TipoEntrada").ToString.Substring(0, 8) = "Teléfono" Then
            '            Return 0
            '            Exit Function
            '        Else
            '            Me.intResultado = 1
            '        End If
            '    Else
            '        Me.intResultado = 1
            '    End If
            'Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return intResultado
    End Function
#End Region

#Region "Bloquear Controles"
    Private Sub BloquearControlesPersonaNatural()
        Me.txtPrimerNombre.Enabled = False
        Me.txtSegundoNombre.Enabled = False
        Me.txtPrimerApellido.Enabled = False
        Me.txtSegundoApellido.Enabled = False
        Me.cmbGenero.Enabled = False
        Me.dtpFechaNacimiento.Enabled = False
        Me.txtCedula.Enabled = False
    End Sub
    Private Sub BloquearAdicional()
        Me.tdbContactos.Enabled = False
        Me.cmdAgregarContacto.Enabled = False
        Me.cmdEliminarContacto.Enabled = False
    End Sub
#End Region

#Region "Habilitar/Deshabilitar"
    Private Sub tdbContactos_AfterFilter(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles tdbContactos.AfterFilter
        Try
            Me.tdbContactos.Caption = "Contactos (" & frmClientesEdit.dtContactos.DefaultView.Count & ")"
            If frmClientesEdit.dtContactos.DefaultView.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Agregar Personas"
    Private Sub AgregarPersonas()
        Try
            Select Case Me.ValidarNumeroTelefono
                Case 0
                    Me.ValidarPersonasNaturales()
                    Me.InsertarPersonas()
                Case 1
                    MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir al menos un teléfono como Contacto del Cliente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.GuardarContactosTemp()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Insertar Personas"
    Private Sub InsertarPersonas()

        Dim objPersonas, objPCompara As StbPersona
        Dim objClientes, objComparaClientes As SccClientes
        Dim T As New DAL.TransactionManager

        Try
            T.BeginTran()
            objPersonas = New StbPersona
            objPCompara = New StbPersona
            objClientes = New SccClientes
            objComparaClientes = New SccClientes

            '1.2 Validar que no exista  una persona con la misma cédula
            objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedula.Text + "'")
            If objPCompara.Cedula <> Nothing Then
                Me.ErrPrv.SetError(Me.txtCedula, "Ya existe una persona con la misma cédula.")
                Me.txtCedula.Focus()
                Exit Sub
            End If

            ''Validar orden de cobro no coincida con otro en la misma ruta
            objComparaClientes.RetrieveByFilter("OrdenCobro=" + Me.spnOrdenCobro.Text + " AND objRutaID=" & cmbRuta.SelectedValue)
            If objComparaClientes.OrdenCobro IsNot Nothing Then
                Me.ErrPrv.SetError(Me.spnOrdenCobro, "Ya existe un cliente con el mismo orden de compra.")
                Me.spnOrdenCobro.Focus()
                Exit Sub
            End If


            'PROCEDER A INGRESAR
            objPersonas.Nombre1 = txtPrimerNombre.Text
            objPersonas.Nombre2 = txtSegundoNombre.Text
            objPersonas.Apellido1 = txtPrimerApellido.Text
            objPersonas.Apellido2 = txtSegundoApellido.Text
            objPersonas.objGeneroID = cmbGenero.SelectedValue

            If Me.txtCedula.Text.Trim <> "-      -" Then
                objPersonas.Cedula = Me.txtCedula.Text
            Else
                objPersonas.Cedula = Nothing
            End If
            If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                objPersonas.FechaNacimiento = Me.dtpFechaNacimiento.Text
            Else
                objPersonas.FechaNacimiento = Nothing
            End If

            objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
            objPersonas.objCiudadID = cmbCiudad.SelectedValue
            objPersonas.Direccion = txtDireccion.Text
            objPersonas.Referencia = txtReferencia.Text
            objPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objPersonas.Insert(T)

            ''Insertar Clientes
            objClientes.objPersonaID = objPersonas.StbPersonaID
            objClientes.OrdenCobro = Convert.ToInt32(spnOrdenCobro.Value)

            If cmbRuta.Text <> String.Empty Then
                objClientes.objRutaID = cmbRuta.SelectedValue
            End If

            objClientes.Activo = True
            objClientes.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClientes.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objClientes.Insert(T)

            Me.idpersona = objPersonas.StbPersonaID
            Me.InsertarDetalle(Me.idpersona, T)
            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPersonas = Nothing
            objPCompara = Nothing
        End Try


    End Sub
#End Region

#Region "Insertar Detalle de Personas"

    Private Sub InsertarDetalle(ByVal IDGenerado As String, t As TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            'Guardar Contactos
            For Each dr As DataRow In frmClientesEdit.dtContactos.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objContactos.Insert(t)
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Cliente'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objClasifica.Insert(t)


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try

    End Sub

#End Region

#Region "Cargar Datos a Editar"

    Private Sub CargarDatosEditar()
        Dim objPersonas As StbPersona
        Dim objClientes As SccClientes
        Try

            objPersonas = New StbPersona
            objClientes = New SccClientes

            objPersonas.RetrieveByFilter("StbPersonaID=" + Me.idpersona)

            Me.txtPrimerNombre.Text = objPersonas.Nombre1
            Me.txtSegundoNombre.Text = objPersonas.Nombre2
            Me.txtPrimerApellido.Text = objPersonas.Apellido1
            Me.txtSegundoApellido.Text = objPersonas.Apellido2
            'Me.cmbGenero.SelectedValue = objPersonas.objGeneroID
            Me.txtCedula.Text = objPersonas.Cedula

            If objPersonas.FechaNacimiento.ToString.Length <> 0 Then
                Me.dtpFechaNacimiento.Value = objPersonas.FechaNacimiento
            End If

            If Not IsNothing(objPersonas.objGeneroID) Then
                Me.cmbGenero.SelectedValue = objPersonas.objGeneroID
            End If

            If Not IsNothing(objPersonas.objCiudadID) Then
                Me.cmbCiudad.SelectedValue = objPersonas.objCiudadID
            End If

            Me.txtDireccion.Text = objPersonas.Direccion
            Me.txtReferencia.Text = objPersonas.Referencia

            objClientes.RetrieveByFilter("objPersonaID=" + Me.idpersona)
            cmbRuta.SelectedValue = objClientes.objRutaID

            If Not IsNothing(objClientes.OrdenCobro) Then
                spnOrdenCobro.Value = objClientes.OrdenCobro
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
        End Try

    End Sub

#End Region

#Region "Editar Personas"

    Private Sub EditarPersonas()
        Try
            Select Case Me.ValidarNumeroTelefono
                Case 0
                    Me.ModificarPersonas()
                Case 1
                    MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir al menos un teléfono como Contacto del Cliente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.GuardarContactosTemp()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Modificar Personas"
    Private Sub ModificarPersonas()
        Dim objPersonas, objPCompara As StbPersona
        Dim objClientes, objComparaClientes As SccClientes
        Dim T As New DAL.TransactionManager
        Try
            objPersonas = New StbPersona
            objPCompara = New StbPersona
            objClientes = New SccClientes
            objComparaClientes = New SccClientes

            '1.2 Validar que no exista  una persona con la misma cédula
            objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersona & " AND Cedula='" + Me.txtCedula.Text + "'")
            If objPCompara.Cedula <> Nothing Then
                Me.ErrPrv.SetError(Me.txtCedula, "Ya existe una persona con la misma cédula.")
                Me.txtCedula.Focus()
                Exit Sub
            End If

            ''Validar orden de cobro no coincida con otro en la misma ruta
            objComparaClientes.RetrieveByFilter("objPersonaID <> " & idpersona & " AND OrdenCobro=" + Me.spnOrdenCobro.Text + " AND objRutaID=" & cmbRuta.SelectedValue)
            If objComparaClientes.OrdenCobro IsNot Nothing Then
                Me.ErrPrv.SetError(Me.spnOrdenCobro, "Ya existe un cliente con el mismo orden de compra.")
                Me.spnOrdenCobro.Focus()
                Exit Sub
            End If


            T.BeginTran()
            objPersonas = New StbPersona
            objPersonas.Retrieve(Me.idpersona)
            objPersonas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPersonas.FechaModificacion = clsProyecto.Conexion.FechaServidor

            objPersonas.Nombre1 = Me.txtPrimerNombre.Text.Trim
            objPersonas.Nombre2 = Me.txtSegundoNombre.Text.Trim
            objPersonas.Apellido1 = Me.txtPrimerApellido.Text.Trim
            objPersonas.Apellido2 = Me.txtSegundoApellido.Text.Trim
            objPersonas.objGeneroID = Me.cmbGenero.SelectedValue

            If Me.txtCedula.Text.Trim <> "-      -" Then
                objPersonas.Cedula = Me.txtCedula.Text
            Else
                objPersonas.Cedula = Nothing
            End If
            If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                objPersonas.FechaNacimiento = Me.dtpFechaNacimiento.Text
            Else
                objPersonas.FechaNacimiento = Nothing
            End If

            objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
            objPersonas.objCiudadID = cmbCiudad.SelectedValue
            objPersonas.Direccion = txtDireccion.Text
            objPersonas.Referencia = txtReferencia.Text
            objPersonas.Update(T)

            ''Actualizar Clientes
            objClientes.RetrieveByFilter("objPersonaID=" & idpersona)
            objClientes.OrdenCobro = Convert.ToInt32(spnOrdenCobro.Value)

            If cmbRuta.Text <> String.Empty Then
                objClientes.objRutaID = cmbRuta.SelectedValue
            End If

            objClientes.Activo = True
            objClientes.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objClientes.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objClientes.Update(T)

            Me.ModificarDetalle()
            Me.InsertarDetalle(Me.idpersona, T)
            T.CommitTran()

            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK



        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPersonas = Nothing
        End Try

    End Sub
#End Region

#Region "Modificar Detalle de Personas"
    Private Sub ModificarDetalle()

        Try
            StbPersonaClasificacion.DeleteByFilter("objTipoPersonaID = (SELECT StbTipoPersonaID FROM StbTipoPersona WHERE Descripcion='Cliente') AND objPersonaID=" + Me.idpersona)
            StbContactos.DeleteByFilter("objPersonaID='" + Me.idpersona + "'")

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Validar Fechas en General"
    ' Descripción			   	:	Función para verificar la validez de una fecha
    ' -----------------------------------------------------------------------------------------
    Private Function FechaValida(ByVal day As Integer, ByVal month As Integer, ByVal year As Integer)
        Try
            If month > 12 Or month = 0 Or day > 31 Or day = 0 Then
                Return False
                Exit Function
            Else
                Select Case month
                    Case 2
                        If year Mod 4 = 0 Then
                            If day > 29 Then
                                Return False
                                Exit Function
                            Else
                                Return True
                                Exit Function
                            End If
                        Else
                            If day > 28 Then
                                Return False
                                Exit Function
                            Else
                                Return True
                                Exit Function
                            End If
                        End If
                    Case 4, 6, 9, 11
                        If day > 30 Then
                            Return False
                            Exit Function
                        Else
                            Return True
                            Exit Function
                        End If
                    Case 1, 3, 5, 7, 8, 10, 12
                        Return True
                        Exit Function
                End Select
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True

    End Function
#End Region

#Region "Validar Cédulas en General"
    ' Descripción			   	:	Función para verificar la validez de una cédula
    ' -----------------------------------------------------------------------------------------
    Private Function CedulaValida(ByVal cedula As String)
        If Me.FechaValida(CInt(cedula.Substring(4, 2)), CInt(cedula.Substring(6, 2)), CInt(cedula.Substring(8, 2))) = True Then
            Return True
            Exit Function
        Else
            Return False
            Exit Function
        End If
        Return True

    End Function
#End Region

#Region "Validar Cédulas"
    Private Function ValidarCedula()
        Try
            'Validar que haya algo en la cédula
            If Me.txtCedula.Text.Trim.Replace(" ", "").Replace("-", "").Trim.Length = 0 Then
                Me.ErrPrv.SetError(Me.txtCedula, My.Resources.MsgObligatorio)
                Me.txtCedula.Focus()
                Return False
                Exit Function
            End If
            'Validar que no haya espacios intermedios
            For intCaracter As Integer = 0 To Me.txtCedula.Text.Trim.Length - 1
                If Me.txtCedula.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                    Me.ErrPrv.SetError(Me.txtCedula, "Número de Cédula no válido")
                    Me.txtCedula.Focus()
                    Return False
                    Exit Function
                End If
            Next
            'Validar que la fecha de la cédula sea válida
            If Me.txtCedula.Text.Trim.Length = 16 Then
                If Me.CedulaValida(Me.txtCedula.Text) = False Then
                    Me.ErrPrv.SetError(Me.txtCedula, "Número de Cédula no válido")
                    Me.txtCedula.Focus()
                    Return False
                    Exit Function
                End If
            Else
                Return False
                Exit Function
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#Region "Validar Clientes "
    Private Function ValidarPersonasNaturales()
        'Validar el nombre
        If Me.txtPrimerNombre.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtPrimerNombre, "Debe ingresar el nombre de la persona")
            Me.txtPrimerNombre.Focus()
            Return False
            Exit Function
        End If
        'Validar el apellido
        If Me.txtPrimerApellido.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtPrimerApellido, "Debe ingresar el apellido de la persona")
            Me.txtPrimerApellido.Focus()
            Return False
            Exit Function
        End If
        'Validar el Género
        If Me.cmbGenero.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbGenero, "Debe especificar el género del cliente")
            Me.cmbGenero.Focus()
            Return False
            Exit Function
        End If

        'Validar Ciudad
        If Me.cmbCiudad.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbGenero, "Debe especificar la ciudad del cliente")
            Me.cmbCiudad.Focus()
            Return False
            Exit Function
        End If

        'Validar Direccion
        If Me.txtDireccion.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbGenero, "Debe especificar la direccion")
            Me.txtDireccion.Focus()
            Return False
            Exit Function
        End If

        'Validar la cédula
        If Me.ValidarCedula = False Then
            Me.txtCedula.Focus()
            Return False
            Exit Function
        End If
        'Validar que la fecha de nacimiento sea igual al número de cédula
        If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 And Me.txtCedula.Text.Trim.Length = 16 Then
            If Me.dtpFechaNacimiento.Text.Substring(0, 6) & Me.dtpFechaNacimiento.Text.Substring(8, 2) <> (Me.txtCedula.Text.Substring(4, 2) & "/" & Me.txtCedula.Text.Substring(6, 2) & "/" & Me.txtCedula.Text.Substring(8, 2)) Then
                Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "La fecha de nacimiento debe coincidir con los dígitos centrales de la cédula")
                Me.dtpFechaNacimiento.Focus()
                Return False
                Exit Function
            End If
        End If

        Return True
    End Function
#End Region

#Region "Cargar Grid Contactos"
    Private Sub CargarGridContactos()
        Try

            Dim strFiltro As String = "1=1"
            Select Case Me.TyGui
                Case 1
                    strFiltro = "1=0"
                Case 2, 3
                    strFiltro = "objPersonaID=" & Me.idpersona
            End Select

            frmClientesEdit.dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", strFiltro))
            Me.tdbContactos.SetDataBinding(frmClientesEdit.dtContactos, "", True)
            Me.tdbContactos.Caption = "Contactos (" & frmClientesEdit.dtContactos.Rows.Count & ")"

            If frmClientesEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If

            Me.tdbContactos.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub
#End Region

#Region "Eliminar Contactos"
    Private Sub EliminarContactos()
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                frmClientesEdit.dtContactos.Rows.RemoveAt(Me.tdbContactos.Row)
            Else
                Exit Sub
            End If
            If frmClientesEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            End If
            Me.tdbContactos.Caption = "Contactos (" & frmClientesEdit.dtContactos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Guardar Contactos Temporalmente"
    Private Sub GuardarContactosTemp()
        Try
            Dim objContactos As frmStbPersonasContactos
            objContactos = New frmStbPersonasContactos
            objContactos.frmLLamado = 0
            objContactos.ShowDialog()
            If frmClientesEdit.dtContactos.Rows.Count > 0 Then
                Me.cmdEliminarContacto.Enabled = True
            End If
            Me.tdbContactos.Caption = "Contactos (" & frmClientesEdit.dtContactos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

 #Region "Propertys"
    Dim id_perLec As String
    Dim TyGui_Lec, TyGuiEsc, Llamado_Lec As Integer

    Property idpersona() As String
        Get
            Return id_perLec
        End Get
        Set(ByVal value As String)
            id_perLec = value
        End Set
    End Property

    Property TyGui() As Integer
        Get
            Return TyGui_Lec
        End Get
        Set(ByVal value As Integer)
            TyGui_Lec = value
        End Set
    End Property

#End Region

#Region "Eventos de los Controles"

#Region "Poner en mayúscula la primer letra"

    Private Sub txtPrimerNombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrimerNombre.Leave
        Me.txtPrimerNombre.Text = Me.txtPrimerNombre.Text.Trim
        If Me.txtPrimerNombre.Text.Trim.Length > 0 Then
            Me.txtPrimerNombre.Text = Me.txtPrimerNombre.Text.Substring(0, 1).ToUpper & Me.txtPrimerNombre.Text.Substring(1, Me.txtPrimerNombre.Text.Length - 1)
        End If
    End Sub

    Private Sub txtSegundoNombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSegundoNombre.Leave
        Me.txtSegundoNombre.Text = Me.txtSegundoNombre.Text.Trim
        If Me.txtSegundoNombre.Text.Trim.Length > 0 Then
            Me.txtSegundoNombre.Text = Me.txtSegundoNombre.Text.Substring(0, 1).ToUpper & Me.txtSegundoNombre.Text.Substring(1, Me.txtSegundoNombre.Text.Length - 1)
        End If
    End Sub

    Private Sub txtPrimerApellido_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrimerApellido.Leave
        Me.txtPrimerApellido.Text = Me.txtPrimerApellido.Text.Trim
        If Me.txtPrimerApellido.Text.Trim.Length > 0 Then
            Me.txtPrimerApellido.Text = Me.txtPrimerApellido.Text.Substring(0, 1).ToUpper & Me.txtPrimerApellido.Text.Substring(1, Me.txtPrimerApellido.Text.Length - 1)
        End If
    End Sub

    Private Sub txtSegundoApellido_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSegundoApellido.Leave
        Me.txtSegundoApellido.Text = Me.txtSegundoApellido.Text.Trim
        If Me.txtSegundoApellido.Text.Trim.Length > 0 Then
            Me.txtSegundoApellido.Text = Me.txtSegundoApellido.Text.Substring(0, 1).ToUpper & Me.txtSegundoApellido.Text.Substring(1, Me.txtSegundoApellido.Text.Length - 1)
        End If
    End Sub
#End Region

#Region "Pasar enfoques y quitar errores"

    Private Sub txtPrimerNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerNombre.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtPrimerNombre.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtSegundoNombre.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtPrimerNombre, "")
        End If
    End Sub

    Private Sub txtSegundoNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegundoNombre.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtSegundoNombre.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtPrimerApellido.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtSegundoNombre, "")
        End If
    End Sub

    Private Sub txtPrimerApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerApellido.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtPrimerApellido.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtSegundoApellido.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtPrimerApellido, "")
        End If
    End Sub

    Private Sub txtSegundoApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegundoApellido.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtSegundoApellido.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.cmbGenero.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtSegundoApellido, "")
        End If
    End Sub

    Private Sub cmbGenero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.dtpFechaNacimiento.Focus()
        End If
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

    Private Sub cmbGenero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

    Private Sub dtpFechaNacimiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.ErrPrv.SetError(Me.txtCedula, "")
        If Asc(e.KeyChar) = 13 Then
            Me.txtCedula.Focus()
        End If
    End Sub

    Private Sub dtpFechaNacimiento_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.ErrPrv.SetError(Me.txtCedula, "")
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
        Me.ErrPrv.SetError(Me.txtCedula, "")
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.txtCedula.Text = Me.txtCedula.Text.ToUpper
    End Sub

    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCedula.KeyUp
        Me.txtCedula.Text = Me.txtCedula.Text.ToUpper
    End Sub

    Private Sub dtpFechaNacimiento_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.ErrPrv.SetError(Me.txtCedula, "")
        If Asc(e.KeyChar) = 13 Then
            Me.txtCedula.Focus()
        End If
    End Sub
    Private Sub dtpFechaNacimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.ErrPrv.SetError(Me.txtCedula, "")
    End Sub

    Private Sub cmbGenero_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenero.Click
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

    Private Sub cmbGenero_ValueMemberChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenero.ValueMemberChanged
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

#End Region

#Region "Varios"

    Private Sub cmbGenero_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGenero.KeyPress
        Me.ErrPrv.SetError(Me.cmbGenero, "")
        If Asc(e.KeyChar) = 13 Then
            Me.dtpFechaNacimiento.Focus()
        End If
    End Sub

    Private Sub dtpFechaNacimiento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dtpFechaNacimiento.Text.Trim.Length = 0 Then
            Me.dtpFechaNacimiento.Value = Nothing
        End If
    End Sub

#End Region

#End Region

#Region "Eventos de los botones"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Select Case Me.TyGui
                Case 1
                    Me.AgregarPersonas()
                Case 2
                    Me.EditarPersonas()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdEliminarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminarContacto.Click
        try
            Me.EliminarContactos()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarContacto.Click
        Try
            Me.GuardarContactosTemp()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub spnOrdenCobro_ValueChanged(sender As Object, e As EventArgs) Handles spnOrdenCobro.ValueChanged

        Me.ErrPrv.SetError(spnOrdenCobro, "")

    End Sub

    Private Sub txtPrimerNombre_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerNombre.TextChanged
        Me.ErrPrv.SetError(txtPrimerNombre, "")
    End Sub

    Private Sub txtPrimerApellido_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.TextChanged
        Me.ErrPrv.SetError(txtPrimerApellido, "")
    End Sub

    Private Sub cmbCiudad_TextChanged(sender As Object, e As EventArgs) Handles cmbCiudad.TextChanged
        Me.ErrPrv.SetError(cmbCiudad, "")
    End Sub

    Private Sub cmbGenero_TextChanged(sender As Object, e As EventArgs) Handles cmbGenero.TextChanged
        Me.ErrPrv.SetError(cmbGenero, "")
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        Me.ErrPrv.SetError(txtDireccion, "")
    End Sub

#End Region

#Region "Cargar el Formulario"

    Private Sub frmStbPersonasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CargarLongitudesMaximas()
            CargarGenero()
            CargarCiudad()
            CargarRuta()
            Me.CargarGridContactos()

            Select Case Me.TyGui
                Case 1
                    Me.Text = "Agregar Nuevo Cliente"
                Case 2
                    Me.Text = "Editanto datos de Cliente: " & Me.idpersona
                    Me.CargarDatosEditar()
                    Me.txtPrimerNombre.Focus()
                Case 3
                    Me.Text = "Consultando datos de Cliente: " & Me.idpersona

                    Me.CargarDatosEditar()

                    Me.barContactos.Enabled = False
                    Me.cmdGuardar.Enabled = False
                    Me.cmbGenero.Enabled = False
                    Me.dtpFechaNacimiento.Enabled = False
                    Me.txtCedula.Enabled = False
                    Me.txtPrimerNombre.Enabled = False
                    Me.txtSegundoNombre.Enabled = False
                    Me.txtPrimerApellido.Enabled = False
                    Me.txtSegundoApellido.Enabled = False
                    Me.cmbGenero.Enabled = False
                    Me.cmbCiudad.Enabled = False
                    Me.txtDireccion.Enabled = False
                    Me.spnOrdenCobro.Enabled = False
                    Me.cmbRuta.Enabled = False
                    Me.cmdBuscar.Enabled = False

                    Me.txtPrimerNombre.Tag = "BLOQUEADO"
                    Me.txtSegundoNombre.Tag = "BLOQUEADO"
                    Me.txtPrimerApellido.Tag = "BLOQUEADO"
                    Me.txtSegundoApellido.Tag = "BLOQUEADO"
                    Me.txtCedula.Tag = "BLOQUEADO"
                    Me.cmbGenero.Tag = "BLOQUEADO"
                    Me.cmbCiudad.Tag = "BLOQUEADO"
                    Me.txtDireccion.Tag = "BLOQUEADO"
                    Me.spnOrdenCobro.Tag = "BLOQUEADO"
                    Me.cmbRuta.Tag = "BLOQUEADO"

                    clsProyecto.CargarTemaDefinido(Me)
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Filtro = " Descripcion = 'Cliente' AND StbPersonaID NOT IN (SELECT objPersonaID FROM SccClientes)"
            objSeleccion.Opcion = 1
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.idpersona = objSeleccion.Seleccion
                CargarPersona()
                VincularControles()
                ErrPrv.SetError(cmdBuscar, "")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

    
  
End Class