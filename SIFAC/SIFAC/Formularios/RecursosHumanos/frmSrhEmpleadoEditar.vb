Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Catalogos.Datos.ClsCatalogos
Imports Proyecto.Catalogos.Datos

Public Class frmSrhEmpleadoEditar

#Region "Variables del formualario"
    Public DtPersona, DtCargo As DataTable
    Public boolEditado As Boolean
    Public intEmpleadoID, intTypeGUI As Integer
    Public strPersonaID As String
    Public Shared dtContactos As DataTable
    Public boolPersonaExistente As Boolean
#End Region

#Region "Propiedades"
    Public Property EmpleadoID() As Integer
        Get
            Return intEmpleadoID
        End Get
        Set(ByVal value As Integer)
            intEmpleadoID = value
        End Set
    End Property

    Public Property PersonaID() As String
        Get
            Return strPersonaID
        End Get
        Set(ByVal value As String)
            strPersonaID = value
        End Set
    End Property

    Public Property TypeGUI() As Integer
        Get
            Return intTypeGUI
        End Get
        Set(ByVal value As Integer)
            intTypeGUI = value
        End Set
    End Property

#End Region

#Region "Procedimientos"
    '' Descripción:        Procedimiento encargado de cargar la informacion de personas con clasificacion empleado que aun no han sido ingresadas en empleado
    Public Sub CargarPersona(intTipo As Integer)
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & PersonaID & "'"
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero, Direccion,objGeneroID,objCiudadID,FechaNacimiento", "vwPersonaClasificacionEmpleado", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de los cargos disponibles
    Public Sub CargarCargo()
        Try
            DtCargo = ObtenerValCat("CARGOS")
            With cmbCargo
                .DataSource = DtCargo
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarGenero()
        Try
            'Género
            frmClientesEdit.dtGenero = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='GENERO')"))
            Me.cmbGenero.DataSource = frmClientesEdit.dtGenero
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

            frmClientesEdit.dtCiudad = StbCiudad.RetrieveDT("objPaisID=" & objPais.StbPaisID, "", "StbCiudadID,Nombre")
            Me.cmbCiudad.DataSource = frmClientesEdit.dtCiudad
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

    '' Descripción:        Procedimiento encargado de vincular los controles al origen de datos
    Public Sub VincularControles()
        Try
            Me.txtPersonaID.DataBindings.Clear()
            Me.txtNombre1.DataBindings.Clear()
            Me.txtNombre2.DataBindings.Clear()
            Me.txtCedula.DataBindings.Clear()
            Me.txtApellido1.DataBindings.Clear()
            Me.txtApellido2.DataBindings.Clear()
            Me.cmbGenero.DataBindings.Clear()
            Me.dtpFechaNacimiento.DataBindings.Clear()
            Me.cmbCiudad.DataBindings.Clear()
            Me.txtDireccion.DataBindings.Clear()

            If DtPersona.Rows.Count > 0 Then
                boolPersonaExistente = True
                Me.PersonaID = DtPersona.Rows(0)("StbPersonaID")
                txtDireccion.Text = DtPersona.Rows(0)("Direccion")

                Me.txtPersonaID.DataBindings.Add("text", DtPersona, "NombreCompleto", False, DataSourceUpdateMode.OnPropertyChanged)
                Me.txtNombre1.DataBindings.Add("text", DtPersona, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
                Me.txtNombre2.DataBindings.Add("text", DtPersona, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)
                Me.txtCedula.DataBindings.Add("text", DtPersona, "Cedula", False, DataSourceUpdateMode.OnPropertyChanged)
                Me.txtApellido1.DataBindings.Add("text", DtPersona, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
                Me.txtApellido2.DataBindings.Add("text", DtPersona, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
                Me.cmbGenero.SelectedValue = DtPersona.Rows(0)("objGeneroID")
                Me.cmbCiudad.SelectedValue = DtPersona.Rows(0)("objCiudadID")

                If Not IsDBNull(DtPersona.Rows(0)("FechaNacimiento")) Then
                    Me.dtpFechaNacimiento.DateTime = DtPersona.Rows(0)("FechaNacimiento")
                Else
                    Me.dtpFechaNacimiento.Text = String.Empty
                End If

                'Cargar Contactos
                frmSrhEmpleadoEditar.dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", "objPersonaID=" & Me.PersonaID))
                Me.tdbContactos.SetDataBinding(frmSrhEmpleadoEditar.dtContactos, "", True)
                Me.tdbContactos.Caption = "Contactos (" & frmSrhEmpleadoEditar.dtContactos.Rows.Count & ")"

                If frmSrhEmpleadoEditar.dtContactos.Rows.Count = 0 Then
                    Me.cmdEliminarContacto.Enabled = False
                Else
                    Me.cmdEliminarContacto.Enabled = True
                End If
            Else
                boolPersonaExistente = False
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub DeshabilitarControles()
        Me.chkActivo.Enabled = False
        Me.cmdBuscar.Enabled = False
        Me.cmbCargo.Enabled = False
        Me.dtpFechaIngreso.Enabled = False
        Me.dtpFechaEgresoE.Enabled = False
        Me.cmdGuardar.Enabled = False
        Me.txtNombre1.Enabled = False
        Me.txtNombre2.Enabled = False
        Me.txtApellido1.Enabled = False
        Me.txtApellido2.Enabled = False
        Me.txtPersonaID.Enabled = False
        Me.cmbCargo.Enabled = False
        Me.cmbCiudad.Enabled = False
        Me.cmbGenero.Enabled = False
        Me.txtDireccion.Enabled = False
        Me.txtCodigoIME.Enabled = False
        Me.txtCedula.Enabled = False
        Me.dtpFechaNacimiento.Enabled = False
        Me.cmdAgregarContacto.Enabled = False
        Me.cmdEliminarContacto.Enabled = False
    End Sub
    '' Descripción:        Procedimiento encargado de configurar los controles segun el modo del formulario
    Public Sub ConfigurarGUI()
        Try
            Select Case TypeGUI
                Case 0
                    Me.chkActivo.Checked = True
                    Me.chkActivo.Enabled = False
                    Me.dtpFechaEgresoE.Enabled = False
                    Me.DtPersona.DefaultView.RowFilter = "1=0"
                Case 1
                    Me.chkActivo.Enabled = True
                    Me.cmdBuscar.Enabled = False
                    Me.dtpFechaEgresoE.Enabled = True
                    CargarDatosEdicion()
                Case 2
                    DeshabilitarControles()
                    CargarDatosEdicion()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un empleado
    Public Sub AgregarEmpleado()
        Dim objPersonas, objPCompara As StbPersona
        Dim T As New DAL.TransactionManager
        Dim objEmpleado As SrhEmpleado
        objEmpleado = New SrhEmpleado
        Try
            Try
                T.BeginTran()
                objPersonas = New StbPersona
                objPCompara = New StbPersona

                '1.2 Validar que no exista  una persona con la misma cédula
                objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedula.Text + "'")
                If objPCompara.Cedula <> Nothing Then
                    Me.ErrPrv.SetError(Me.txtCedula, "Ya existe una persona con la misma cédula.")
                    Me.txtCedula.Focus()
                    Exit Sub
                End If

                'PROCEDER A INGRESAR
                objPersonas.Nombre1 = txtNombre1.Text
                objPersonas.Nombre2 = txtNombre2.Text
                objPersonas.Apellido1 = txtApellido1.Text
                objPersonas.Apellido2 = txtApellido2.Text
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
                objPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objPersonas.Direccion = txtDireccion.Text.Trim

                objPersonas.Insert(T)
                Me.PersonaID = objPersonas.StbPersonaID

                objEmpleado.objPersonaID = PersonaID
                objEmpleado.objCargoID = cmbCargo.SelectedValue
                objEmpleado.FechaIngreso = dtpFechaIngreso.DateTime
                objEmpleado.Activo = chkActivo.Checked
                objEmpleado.Imei = txtCodigoIME.Text

                objEmpleado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEmpleado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEmpleado.Insert(T)
                EmpleadoID = objEmpleado.SrhEmpleadoID
                Me.InsertarDetalleEmpleado(Me.PersonaID, T)
                T.CommitTran()

                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.boolEditado = False
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objEmpleado = Nothing
        End Try
    End Sub

    Public Sub AsociarPersonaEmpleado()
        Dim objPersonas As StbPersona
        Dim T As New DAL.TransactionManager
        Dim objEmpleado As SrhEmpleado
        Dim objCuenta As New SsgCuenta
        objEmpleado = New SrhEmpleado
        Try
            Try
                T.BeginTran()
                objPersonas = New StbPersona
                objPersonas.Retrieve(Me.PersonaID)

                objPersonas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objPersonas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objPersonas.Nombre1 = Me.txtNombre1.Text.Trim
                objPersonas.Nombre2 = Me.txtNombre2.Text.Trim
                objPersonas.Apellido1 = Me.txtApellido1.Text.Trim
                objPersonas.Apellido2 = Me.txtApellido2.Text.Trim
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

                objPersonas.Update(T)
                Me.ModificarDetalle(T)


                Me.PersonaID = objPersonas.StbPersonaID

                objEmpleado.objPersonaID = PersonaID
                objEmpleado.objCargoID = cmbCargo.SelectedValue
                objEmpleado.FechaIngreso = dtpFechaIngreso.DateTime
                objEmpleado.Activo = chkActivo.Checked
                objEmpleado.Imei = txtCodigoIME.Text

                objEmpleado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEmpleado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEmpleado.Insert(T)
                EmpleadoID = objEmpleado.SrhEmpleadoID
                Me.InsertarDetalleEmpleado(Me.PersonaID, T)

                T.CommitTran()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Me.boolEditado = False
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objEmpleado = Nothing
            objCuenta = Nothing
        End Try
    End Sub

    Private Sub InsertarDetalleEmpleado(ByVal IDGenerado As String, T As DAL.TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            'Guardar Contactos
            For Each dr As DataRow In frmSrhEmpleadoEditar.dtContactos.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objContactos.Insert(T)
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Empleado'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objClasifica.Insert(T)


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try

    End Sub

    '' Descripción:        Procedimiento encargado de editar la informacion de un empleado
    Public Sub EditarEmpleado()
        Dim objPersonas As StbPersona
        Dim T As New DAL.TransactionManager
        Dim objEmpleado As SrhEmpleado
        Dim objCuenta As New SsgCuenta
        objEmpleado = New SrhEmpleado
        Try
            Try
                T.BeginTran()
                objPersonas = New StbPersona
                objPersonas.Retrieve(Me.PersonaID)

                objPersonas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objPersonas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objPersonas.Nombre1 = Me.txtNombre1.Text.Trim
                objPersonas.Nombre2 = Me.txtNombre2.Text.Trim
                objPersonas.Apellido1 = Me.txtApellido1.Text.Trim
                objPersonas.Apellido2 = Me.txtApellido2.Text.Trim
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

                objPersonas.Update(T)
                Me.ModificarDetalle(T)
                Me.InsertarDetalleEmpleado(Me.PersonaID, T)

                objEmpleado.SrhEmpleadoID = EmpleadoID
                objEmpleado.objPersonaID = PersonaID
                objEmpleado.objCargoID = cmbCargo.SelectedValue
                objEmpleado.Imei = txtCodigoIME.Text

                If chkActivo.Checked = False Then
                    objEmpleado.FechaEgreso = dtpFechaEgresoE.DateTime
                    If objCuenta.RetrieveByFilter("objEmpleadoID = " & EmpleadoID) Then
                        objCuenta.Activo = False
                        objCuenta.Update(T)
                    End If
                Else
                    chkActivo.Checked = True
                    objEmpleado.FechaEgreso = Nothing
                    If objCuenta.RetrieveByFilter("objEmpleadoID = " & EmpleadoID) Then
                        objCuenta.Activo = True
                        objCuenta.Update(T)
                    End If
                End If
                objEmpleado.FechaIngreso = dtpFechaIngreso.DateTime
                objEmpleado.Activo = chkActivo.Checked

                objEmpleado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEmpleado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEmpleado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objEmpleado.Update(T)
                T.CommitTran()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Me.boolEditado = False
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objEmpleado = Nothing
            objCuenta = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de un empleado existente
    Public Sub CargarDatosEdicion()
        Try
            Dim objEmpleado As SrhEmpleado
            objEmpleado = New SrhEmpleado
            objEmpleado.Retrieve(EmpleadoID)
            Me.cmbCargo.SelectedValue = objEmpleado.objCargoID
            Me.chkActivo.Checked = objEmpleado.Activo
            Me.dtpFechaIngreso.DateTime = objEmpleado.FechaIngreso
            Me.txtCodigoIME.Text = objEmpleado.Imei
            If objEmpleado.FechaEgreso.HasValue Then

                If Not IsDBNull(objEmpleado.FechaEgreso) Then
                    Me.dtpFechaEgresoE.DateTime = objEmpleado.FechaEgreso
                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



#End Region

#Region "Modificar Detalle de Personas"
    Private Sub ModificarDetalle(T As DAL.TransactionManager)

        Try
            StbPersonaClasificacion.DeleteByFilter("objTipoPersonaID = (SELECT StbTipoPersonaID FROM StbTipoPersona WHERE Descripcion='Empleado') AND objPersonaID=" + Me.PersonaID)
            StbContactos.DeleteByFilter("objPersonaID='" + Me.PersonaID + "'", T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Insertar Detalle de Personas"

    Private Sub InsertarDetalle(ByVal IDGenerado As String)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            'Guardar Contactos
            For Each dr As DataRow In frmSrhEmpleadoEditar.dtContactos.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objContactos.Insert()
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Cliente'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objClasifica.Insert()


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try

    End Sub

#End Region

#Region "Cargar Grid Contactos"
    Private Sub CargarGridContactos()
        Try

            Dim strFiltro As String = "1=1"
            Select Case Me.TypeGUI
                Case 0
                    strFiltro = "1=0"
                Case 1, 2
                    strFiltro = "objPersonaID=" & Me.PersonaID
            End Select

            frmSrhEmpleadoEditar.dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", strFiltro))
            Me.tdbContactos.SetDataBinding(frmSrhEmpleadoEditar.dtContactos, "", True)
            Me.tdbContactos.Caption = "Contactos (" & frmSrhEmpleadoEditar.dtContactos.Rows.Count & ")"

            If frmSrhEmpleadoEditar.dtContactos.Rows.Count = 0 Then
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
                frmSrhEmpleadoEditar.dtContactos.Rows.RemoveAt(Me.tdbContactos.Row)
            Else
                Exit Sub
            End If
            If frmSrhEmpleadoEditar.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            End If
            Me.tdbContactos.Caption = "Contactos (" & frmSrhEmpleadoEditar.dtContactos.Rows.Count & ")"
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
            objContactos.frmLLamado = 1
            If objContactos.ShowDialog() = DialogResult.OK Then
                If frmSrhEmpleadoEditar.dtContactos.Rows.Count > 0 Then
                    Me.cmdEliminarContacto.Enabled = True
                End If
                Me.tdbContactos.Caption = "Contactos (" & frmSrhEmpleadoEditar.dtContactos.Rows.Count & ")"
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Longitudes Máximas"
    Private Sub CargarLongitudesMaximas()
        Try
            Me.txtNombre1.MaxLength = StbPersona.GetMaxLength("Nombre1")
            Me.txtNombre2.MaxLength = StbPersona.GetMaxLength("Nombre2")
            Me.txtApellido1.MaxLength = StbPersona.GetMaxLength("Apellido1")
            Me.txtApellido2.MaxLength = StbPersona.GetMaxLength("Apellido2")
            Me.txtDireccion.MaxLength = StbPersona.GetMaxLength("Direccion")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub
#End Region

#Region "Funciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Try
            Select Case TypeGUI
                Case 0
                    If txtNombre1.Text.Trim.Length = 0 Then
                        ErrorProv.SetError(txtNombre1, My.Resources.MsgObligatorio)
                        Return False
                        Exit Function
                    End If
                    If txtApellido1.Text.Trim.Length = 0 Then
                        ErrorProv.SetError(txtApellido1, My.Resources.MsgObligatorio)
                        Return False
                        Exit Function
                    End If
                    If txtCedula.Text = "   -      -" Then
                        ErrorProv.SetError(txtCedula, My.Resources.MsgObligatorio)
                        Return False
                        Exit Function
                    End If

                    If txtCedula.Text.Trim.Length = 0 Then
                        ErrorProv.SetError(txtCedula, My.Resources.MsgObligatorio)
                        Return False
                        Exit Function
                    End If
                    If cmbCargo.Text.Trim.Length = 0 Then
                        ErrorProv.SetError(cmbCargo, My.Resources.MsgObligatorio)
                        Return False
                        Exit Function
                    End If
                    If dtpFechaIngreso.Text.Trim.Length = 0 Then
                        ErrorProv.SetError(dtpFechaIngreso, My.Resources.MsgObligatorio)
                        Return False
                        Exit Function
                    End If
                    If dtpFechaIngreso.DateTime > clsProyecto.Conexion.FechaServidor Then
                        ErrorProv.SetError(dtpFechaIngreso, "La fecha de ingreso no puede ser mayor que la fecha actual")
                        Return False
                        Exit Function
                    End If

                Case 1
                    If cmbCargo.Text.Trim.Length = 0 Then
                        ErrorProv.SetError(cmbCargo, My.Resources.MsgObligatorio)
                        Return False
                        Exit Function
                    End If

                    If dtpFechaEgresoE.Text.Trim.Length = 0 Then
                        Return True
                        Exit Function
                    End If
                    If dtpFechaEgresoE.DateTime > clsProyecto.Conexion.FechaServidor And Me.dtpFechaEgresoE.Text <> "01/01/0001" Then
                        ErrorProv.SetError(dtpFechaEgresoE, "La fecha de egreso no puede ser mayor que la fecha actual")
                        Return False
                        Exit Function
                    End If
                    If dtpFechaEgresoE.DateTime < dtpFechaIngreso.DateTime And Me.dtpFechaEgresoE.Text <> "01/01/0001" Then
                        ErrorProv.SetError(dtpFechaEgresoE, "La fecha de egreso debe ser mayor a la fecha de ingreso")
                        Return False
                        Exit Function
                    End If
            End Select
            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Eventos del formualario"

    Private Sub cmdAgregarContacto_Click(sender As Object, e As EventArgs) Handles cmdAgregarContacto.Click
        Try
            Me.GuardarContactosTemp()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarContacto_Click(sender As Object, e As EventArgs) Handles cmdEliminarContacto.Click
        Try
            Me.EliminarContactos()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSrhEmpleadoEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            boolPersonaExistente = False
            Me.CargarLongitudesMaximas()
            CargarGenero()
            CargarCiudad()
            CargarCargo()
            CargarPersona(1)
            CargarGridContactos()
            VincularControles()
            ConfigurarGUI()
            boolEditado = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Filtro = "  StbPersonaID NOT IN (SELECT objPersonaID FROM SrhEmpleado)"
            objSeleccion.Opcion = 3
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.PersonaID = objSeleccion.Seleccion
                CargarPersona(1)
                VincularControles()
                Me.DtPersona.DefaultView.RowFilter = "StbPersonaID = '" & PersonaID & "'"
                ErrorProv.SetError(cmdBuscar, "")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbCargo_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCargo.Change
        Me.boolEditado = True
        Me.ErrorProv.SetError(cmbCargo, "")
        'Dim dtCargo As New DataTable
        'dtCargo = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("StbValorCatalogoID", "Nombre = 'CARGOS' AND Codigo ='09'"))
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            If ValidarEntrada() Then
                Select Case TypeGUI
                    Case 0
                        If Not boolPersonaExistente Then
                            AgregarEmpleado()
                        Else
                            AsociarPersonaEmpleado()
                        End If

                    Case 1
                        EditarEmpleado()
                End Select
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub dtpFechaIngreso_EditValueChanged(sender As Object, e As EventArgs) Handles dtpFechaIngreso.EditValueChanged
        Me.boolEditado = True
        Me.ErrorProv.SetError(dtpFechaIngreso, "")
    End Sub
    Private Sub dtpFechaIngreso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.boolEditado = True
        Me.ErrorProv.SetError(dtpFechaIngreso, "")
    End Sub

    Private Sub dtpFechaEgreso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.boolEditado = True
        Me.ErrorProv.SetError(dtpFechaEgresoE, "")
    End Sub

    Private Sub frmSrhEmpleadoEditar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado And Me.TypeGUI <> 2 Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub chkActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivo.CheckedChanged
        Try
            Select Case Me.chkActivo.Checked
                Case False
                    If Me.TypeGUI = 1 Then
                        Me.dtpFechaEgresoE.DateTime = Nothing
                        Me.dtpFechaEgresoE.Enabled = True
                    End If
                Case True
                    If Me.TypeGUI = 1 Then
                        Me.dtpFechaEgresoE.DateTime = Nothing
                        Me.dtpFechaEgresoE.Enabled = False
                    End If
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtNombre1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre1.TextChanged
        Me.boolEditado = True
        Me.ErrorProv.SetError(txtNombre1, "")
    End Sub

    Private Sub txtApellido1_TextChanged(sender As Object, e As EventArgs) Handles txtApellido1.TextChanged
        Me.boolEditado = True
        Me.ErrorProv.SetError(txtApellido1, "")
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        Me.boolEditado = True
        Me.ErrorProv.SetError(txtCedula, "")
    End Sub
#End Region
   
   
End Class