Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmStbPersonasEditar

    '******************************************
#Region "Declaración de Variables propias del formulario"
    Public Shared dtContactos, dtPIM, dtGenero As DataTable
    Public dtOcupacion As DataTable
    Dim intTelefonoCliente, intResultado As Integer
    Dim imgCedulaAnverso, imgCedulaReverso As Byte()
#End Region
    '******************************************

    'GENERALES
    '*****************************************

#Region "Cargar Combos"
    Private Sub CargarCombos()
        Try
            'Género
            frmStbPersonasEditar.dtGenero = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='GENERO')"))
            Me.cmbGenero.DataSource = frmStbPersonasEditar.dtGenero
            Me.cmbGenero.DisplayMember = "Descripcion"
            Me.cmbGenero.ValueMember = "StbValorCatalogoID"
            Me.cmbGenero.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbGenero.ExtendRightColumn = True
            Me.cmbGenero.SelectedIndex = 0
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

#End Region

#Region "Manejar Persona Jurídica"
    Private Sub ManejarPersonaJuridica()
        Select Case Me.chkPersonaJuridica.Checked
            Case True
                Me.ErrPrv.SetError(Me.txtPrimerNombre, "")
                Me.ErrPrv.SetError(Me.txtSegundoNombre, "")
                Me.ErrPrv.SetError(Me.cmbGenero, "")
                Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
                Me.ErrPrv.SetError(Me.txtCedula, "")
                cmbCiudad.SelectedValue = 0
                Me.txtPrimerNombre.Text = ""
                Me.txtSegundoNombre.Text = ""
                Me.txtPrimerApellido.Text = ""
                Me.txtSegundoApellido.Text = ""
                Me.cmbGenero.SelectedValue = 0
                Me.dtpFechaNacimiento.Value = Nothing
                Me.txtCedula.Text = ""
                Me.grpPersonaJuridica.Enabled = True
                Me.grpPersonaNatural.Enabled = False
                Me.txtSiglasEmpresa.Focus()
                Me.txtDireccion.Text = ""
            Case False
                Me.ErrPrv.SetError(Me.txtSiglasEmpresa, "")
                Me.ErrPrv.SetError(Me.txtRazonSocial, "")
                Me.ErrPrv.SetError(Me.txtRUC, "")
                Me.ErrPrv.SetError(Me.txtDireccion, "")
                Me.txtSiglasEmpresa.Text = ""
                Me.txtRazonSocial.Text = ""
                Me.txtRUC.Text = ""
                Me.txtDireccion.Text = ""
                cmbCiudad.SelectedValue = 0
                Me.grpPersonaJuridica.Enabled = False
                Me.grpPersonaNatural.Enabled = True
                Me.txtSiglasEmpresa.Focus()
        End Select
    End Sub
#End Region

#Region "Cargar Longitudes Máximas"
    Private Sub CargarLongitudesMaximas()
        Try
            Me.txtPrimerNombre.MaxLength = StbPersona.GetMaxLength("Nombre1")
            Me.txtSegundoNombre.MaxLength = StbPersona.GetMaxLength("Nombre2")
            Me.txtPrimerApellido.MaxLength = StbPersona.GetMaxLength("Apellido1")
            Me.txtSegundoApellido.MaxLength = StbPersona.GetMaxLength("Apellido2")
            Me.txtSiglasEmpresa.MaxLength = StbPersona.GetMaxLength("SiglasEmpresa")
            Me.txtRazonSocial.MaxLength = StbPersona.GetMaxLength("RazonSocial")
            Me.txtDireccion.MaxLength = StbPersona.GetMaxLength("Direccion")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub
#End Region

#Region "Seguridad"
    Private Sub Seguridad()

    End Sub
#End Region

#Region "Validar Ingresos"
    Public Function ValidarIngresos() As Boolean

        If frmStbPersonasEditar.dtContactos.Rows.Count = 0 Then
            MsgBox("No se puede ingresar el registro del proveedor." + vbCrLf + "Debe definir al menos un tipo de Contacto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

#Region "Validar Llamados"
    Public Sub ValidarLlamados()
        Select Case Me.frmLlamado
            Case 3
                IngresarDatosPredefinidos(3, "Empleado")
            Case 4
                IngresarDatosPredefinidos(4, "Cliente")
            Case 5
                IngresarDatosPredefinidos(5, "Fiador")
            Case 6
                IngresarDatosPredefinidos(6, "Proveedor")
            Case 7
                IngresarDatosPredefinidos(1, "Nacional")
        End Select
    End Sub
#End Region

#Region "IngresarDatosPredefinidos"
    Public Sub IngresarDatosPredefinidos(ByVal objTipoPersonaID As Integer, ByVal TipoPersona As String)
        For Each dr As DataRow In frmStbPersonasEditar.dtPIM.Rows
            If (dr("TipoPersona") = TipoPersona) Then
                Exit Sub
            End If
        Next
        frmStbPersonasEditar.dtPIM.Rows.Add(0, objTipoPersonaID, TipoPersona, clsProyecto.Conexion.FechaServidor)
        Me.tdbPIM.Caption = "Clasificaciones (" & frmStbPersonasEditar.dtPIM.Rows.Count & ")"
    End Sub
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
        Me.cmbCiudad.Enabled = False
        Me.txtDireccion.Enabled = False
    End Sub
    Private Sub BloquearControlesPersonaJuridica()
        Me.txtSiglasEmpresa.Enabled = False
        Me.txtRazonSocial.Enabled = False
        Me.txtRUC.Enabled = False
        Me.cmbCiudad.Enabled = False
        Me.txtDireccion.Enabled = False
    End Sub
    Private Sub BloquearAdicional()
        Me.tdbContactos.Enabled = False
        Me.tdbPIM.Enabled = False
        Me.cmdAgregarContacto.Enabled = False
        Me.cmdAgregarPIM.Enabled = False
        Me.cmdEliminarPIM.Enabled = False
        Me.cmdEliminarContacto.Enabled = False
    End Sub
#End Region

#Region "Habilitar/Deshabilitar"
    Private Sub tdbContactos_AfterFilter(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles tdbContactos.AfterFilter
        Try
            Me.tdbContactos.Caption = "Contactos (" & frmStbPersonasEditar.dtContactos.DefaultView.Count & ")"
            If frmStbPersonasEditar.dtContactos.DefaultView.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub tdbPIM_AfterFilter(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles tdbPIM.AfterFilter
        Try
            Me.tdbPIM.Caption = "Clasificaciones (" & frmStbPersonasEditar.dtPIM.DefaultView.Count & ")"
            If frmStbPersonasEditar.dtPIM.DefaultView.Count = 0 Then
                Me.cmdEliminarPIM.Enabled = False
            Else
                Me.cmdEliminarPIM.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region


#Region "ImagenCedula"

    Private Function Ficheros(ByVal SRuta As String) As Byte()
        Dim fs As System.IO.FileStream
        fs = New FileStream(SRuta, FileMode.Open, FileAccess.Read, FileShare.Read)
        Dim Datos(fs.Length) As Byte
        fs.Read(Datos, 0, Convert.ToInt32(fs.Length))
        Return Datos
    End Function
#End Region


    'AGREGAR
    '*****************************************

#Region "Agregar Personas"
    Private Sub AgregarPersonas()

        Select Case Me.ValidarDatos
            Case True
                If ValidarIngresos() Then
                    Me.InsertarPersonas()
                End If
                
            Case False
                Exit Sub
        End Select

    End Sub
#End Region

#Region "Insertar Personas"
    Private Sub InsertarPersonas()

        Dim objPersonas, objPCompara As StbPersona
        Dim T As New DAL.TransactionManager
        Dim p_Personas(14), p_Empresas(9) As SqlParameter
        Try
            T.BeginTran()

            objPersonas = New StbPersona
            objPCompara = New StbPersona

            '1. Validar que tipo de persona es
            Select Case Me.chkPersonaJuridica.Checked
                Case True
                    If Me.txtRUC.Text.Trim = "      -" Then
                        Me.ErrPrv.SetError(Me.txtRUC, "Campo Obligatorio")
                        Exit Sub
                    End If

                    '1.1 Validar que no exista una empresa con el mismo RUC
                    objPCompara.RetrieveByFilter("RUC='" + Me.txtRUC.Text + "'")
                    If objPCompara.RUC <> Nothing Then
                        Me.ErrPrv.SetError(Me.txtRUC, "Ya existe una empresa con el mismo número RUC.")
                        Me.txtRUC.Focus()
                        Exit Sub
                    End If
                    objPersonas.Nombre1 = ""
                    objPersonas.Apellido1 = ""
                    objPersonas.PersonaJuridica = Me.chkPersonaJuridica.Checked
                    objPersonas.RazonSocial = Me.txtRazonSocial.Text.Trim
                    objPersonas.SiglasEmpresa = Me.txtSiglasEmpresa.Text.Trim

                    If Me.txtRUC.Text.Trim = "-" Then
                        objPersonas.RUC = ""
                    Else
                        objPersonas.RUC = Me.txtRUC.Text.Trim
                    End If

                    objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
                    objPersonas.objCiudadID = cmbCiudad.SelectedValue
                    objPersonas.Direccion = txtDireccion.Text
                    objPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objPersonas.Insert()
                    Me.idpersona = objPersonas.StbPersonaID

                Case False
                    '1.2 Validar que no exista  una persona con la misma cédula
                    objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedula.Text + "'")
                    If objPCompara.Cedula <> Nothing Then
                        Me.ErrPrv.SetError(Me.txtCedula, "Ya existe una persona con la misma cédula.")
                        Me.txtCedula.Focus()
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
                    objPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objPersonas.Insert()
                    Me.idpersona = objPersonas.StbPersonaID
                    'Me.InsertarDetalle(Me.idpersona, T)

            End Select
            ValidarLlamados()
            Me.InsertarDetalle(Me.idpersona, T)
            T.CommitTran()

            'If Me.frmLlamado = 5 Then
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            'End If
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

    Private Sub InsertarDetalle(ByVal IDGenerado As String, T As TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try

            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            'Guardar Contactos
            For Each dr As DataRow In frmStbPersonasEditar.dtContactos.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objContactos.Insert(T)
            Next
            'Guardar PIM
            For Each dr As DataRow In frmStbPersonasEditar.dtPIM.Rows
                objClasifica.objPersonaID = IDGenerado
                objClasifica.objTipoPersonaID = CInt(dr("objTipoPersonaID").ToString)
                objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objClasifica.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objClasifica.Insert(T)
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try

    End Sub

#End Region

    'EDITAR
    '*****************************************

#Region "Cargar Datos a Editar"

    Private Sub CargarDatosEditar()

        Dim objPersonas As StbPersona
        Try

            objPersonas = New StbPersona
            objPersonas.RetrieveByFilter("StbPersonaID='" + Me.idpersona + "'")
            Me.chkPersonaJuridica.Checked = objPersonas.PersonaJuridica
            Me.chkPersonaJuridica.Enabled = False
            Me.ManejarPersonaJuridica()

            Select Case Me.chkPersonaJuridica.Checked
                Case True
                    Me.txtSiglasEmpresa.Text = objPersonas.SiglasEmpresa
                    Me.txtRazonSocial.Text = objPersonas.RazonSocial
                    Me.txtRUC.Text = objPersonas.RUC
                Case False
                    Me.txtPrimerNombre.Text = objPersonas.Nombre1
                    Me.txtSegundoNombre.Text = objPersonas.Nombre2
                    Me.txtPrimerApellido.Text = objPersonas.Apellido1
                    Me.txtSegundoApellido.Text = objPersonas.Apellido2

                    If objPersonas.objGeneroID IsNot Nothing Then
                        Me.cmbGenero.SelectedValue = objPersonas.objGeneroID
                    End If
                    If objPersonas.objCiudadID IsNot Nothing Then
                        Me.cmbCiudad.SelectedValue = objPersonas.objCiudadID
                    End If
                    If objPersonas.Direccion IsNot Nothing Then
                        Me.txtDireccion.Text = objPersonas.Direccion
                    End If

                    If objPersonas.Cedula IsNot Nothing Then
                        Me.txtCedula.Text = objPersonas.Cedula
                    End If

                    If objPersonas.FechaNacimiento.ToString.Length <> 0 Then
                        Me.dtpFechaNacimiento.Value = objPersonas.FechaNacimiento
                    End If
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
        End Try

    End Sub

#End Region

#Region "Editar Personas"

    Private Sub EditarPersonas()

        Select Case Me.ValidarDatos
            Case True
                If ValidarIngresos() Then
                    Me.ModificarPersonas()
                End If

            Case False
                Exit Sub
        End Select
    End Sub

#End Region

#Region "Modificar Personas"
    Private Sub ModificarPersonas()
        Dim objPersonas As StbPersona
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objPersonas = New StbPersona
            objPersonas.Retrieve(Me.idpersona)
            objPersonas.PersonaJuridica = Me.chkPersonaJuridica.Checked
            objPersonas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPersonas.FechaModificacion = clsProyecto.Conexion.FechaServidor

            Select Case Me.chkPersonaJuridica.Checked
                Case True
                    objPersonas.RazonSocial = Me.txtRazonSocial.Text.Trim
                    objPersonas.SiglasEmpresa = Me.txtSiglasEmpresa.Text.Trim
                    If Me.txtRUC.Text.Trim <> "-" Then
                        objPersonas.RUC = Me.txtRUC.Text.Trim
                    Else
                        objPersonas.RUC = Nothing
                    End If

                Case False
                    objPersonas.Nombre1 = Me.txtPrimerNombre.Text.Trim
                    objPersonas.Nombre2 = Me.txtSegundoNombre.Text.Trim
                    objPersonas.Apellido1 = Me.txtPrimerApellido.Text.Trim
                    objPersonas.Apellido2 = Me.txtSegundoApellido.Text.Trim
                    objPersonas.objGeneroID = Me.cmbGenero.SelectedValue
                    objPersonas.objCiudadID = cmbCiudad.SelectedValue
                    objPersonas.Direccion = txtDireccion.Text

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

            End Select

            objPersonas.Update(T)
            Me.ModificarDetalle(T)
            Me.InsertarDetalle(Me.idpersona, T)
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

            T.CommitTran()

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPersonas = Nothing
        End Try

    End Sub
#End Region

#Region "Modificar Detalle de Personas"
    Private Sub ModificarDetalle(T As TransactionManager)
        Try

            StbPersonaClasificacion.DeleteByFilter("objPersonaID='" + Me.idpersona + "'", T)
            StbContactos.DeleteByFilter("objPersonaID='" + Me.idpersona + "'", T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

    'Validaciones
    '*****************************************

#Region "Validar Fechas en General"
    ' -----------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Róger Alberto Gutiérrez Mejía
    ' Fecha de Elaboración 		:	16 de Febrero de 2009
    ' Descripción			   	:	Función para verificar la validez de una fecha
    ' -----------------------------------------------------------------------------------------
    Private Function FechaValida(ByVal day As Integer, ByVal month As Integer, ByVal year As Integer)

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

        Return True

    End Function
#End Region

#Region "Validar Cédulas en General"
    ' -----------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Róger Alberto Gutiérrez Mejía
    ' Fecha de Elaboración 		:	16 de Febrero de 2009
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

#Region "Validar RUC"
    Private Function ValidarRUC()
        'Validar que haya algo en el RUC
        If Me.txtRUC.Text.Trim = "-" Then
            Return True
            Exit Function
        End If
        'Validar espacios intermedios
        For intCaracter As Integer = 0 To 10
            If Me.txtRUC.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                Me.ErrPrv.SetError(Me.txtRUC, "Número RUC no válido")
                Me.txtRUC.Focus()
                Return False
                Exit Function
            End If
        Next
        'Validar que el número RUC sea válido
        If Me.txtRUC.Text.Trim.Length = 11 Then
            If Me.FechaValida(Me.txtRUC.Text.Substring(0, 2), Me.txtRUC.Text.Substring(2, 2), Me.txtRUC.Text.Substring(4, 2)) = False Then
                Me.ErrPrv.SetError(Me.txtRUC, "Número RUC no válido")
                Me.txtRUC.Focus()
                Return False
                Exit Function
            End If
        Else
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

#Region "Validar Cédulas"
    Private Function ValidarCedula()
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
        Return True
    End Function
#End Region

#Region "Validar Datos"
    Private Function ValidarDatos()

        Select Case Me.chkPersonaJuridica.Checked
            Case True
                Select Case Me.ValidarPersonasJuridicas
                    Case True
                        Return True
                        Exit Function
                    Case False
                        Return False
                        Exit Function
                End Select
            Case False
                Select Case Me.ValidarPersonasNaturales
                    Case True
                        Return True
                        Exit Function
                    Case False
                        Return False
                        Exit Function
                End Select
        End Select
        Return 0
    End Function
#End Region

#Region "Validar Personas Naturales"
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
            Me.ErrPrv.SetError(Me.cmbGenero, "Debe especificar el género de la persona")
            Me.cmbGenero.Focus()
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

#Region "Validar Personas Jurídicas"
    Private Function ValidarPersonasJuridicas()

        'Validar las siglas de la empresa
        If Me.txtSiglasEmpresa.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtSiglasEmpresa, "Debe especificar las siglas de la empresa")
            Me.txtSiglasEmpresa.Focus()
            Return False
            Exit Function
        End If
        'Validar la razón social
        If Me.txtRazonSocial.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtRazonSocial, "Debe especificar la razón social de la empresa")
            Me.txtRazonSocial.Focus()
            Return False
            Exit Function
        End If
        'Validar Número RUC
        If Me.ValidarRUC = False Then
            Me.ErrPrv.SetError(Me.txtRUC, "Número RUC no válido")
            Me.txtRUC.Focus()
            Return False
            Exit Function
        End If
       
        Return True

    End Function
#End Region


    'Contactos
    '*****************************************

#Region "Cargar Grid Contactos"
    Private Sub CargarGridContactos()
        Try

            Dim strFiltro As String = "1=1"
            Select Case Me.TyGui
                Case 1
                    strFiltro = "1=0"
                Case 2, 3
                    strFiltro = "objPersonaID='" & Me.idpersona & "'"
            End Select

            frmStbPersonasEditar.dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", strFiltro))
            Me.tdbContactos.SetDataBinding(frmStbPersonasEditar.dtContactos, "", True)
            Me.tdbContactos.Caption = "Contactos (" & frmStbPersonasEditar.dtContactos.Rows.Count & ")"

            If frmStbPersonasEditar.dtContactos.Rows.Count = 0 Then
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
        If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
            frmStbPersonasEditar.dtContactos.Rows.RemoveAt(Me.tdbContactos.Row)
        Else
            Exit Sub
        End If
        If frmStbPersonasEditar.dtContactos.Rows.Count = 0 Then
            Me.cmdEliminarContacto.Enabled = False
        End If
        Me.tdbContactos.Caption = "Contactos (" & frmStbPersonasEditar.dtContactos.Rows.Count & ")"
    End Sub
#End Region

#Region "Guardar Contactos Temporalmente"
    Private Sub GuardarContactosTemp()
        Dim objContactos As frmStbPersonasContactos
        objContactos = New frmStbPersonasContactos
        objContactos.frmLLamado = 3
        objContactos.ShowDialog()
        If frmStbPersonasEditar.dtContactos.Rows.Count > 0 Then
            Me.cmdEliminarContacto.Enabled = True
        End If
        Me.tdbContactos.Caption = "Contactos (" & frmStbPersonasEditar.dtContactos.Rows.Count & ")"
    End Sub
#End Region

    'PIM
    '*****************************************

#Region "Cargar Grid PIM"
    Private Sub CargarGridPIM()
        Try

            Dim strFiltro As String = "1=1"
            Select Case Me.TyGui
                Case 1
                    strFiltro = "1=0"
                Case 2, 3
                    strFiltro = "objPersonaID='" & Me.idpersona & "'"
            End Select

            frmStbPersonasEditar.dtPIM = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,objTipoPersonaID,TipoPersona,FechaCreacion", "vwPersonaPIM", strFiltro))
            Me.tdbPIM.SetDataBinding(frmStbPersonasEditar.dtPIM, "", True)
            Me.tdbPIM.Caption = "Clasificaciones (" & frmStbPersonasEditar.dtPIM.Rows.Count & ")"

            If frmStbPersonasEditar.dtPIM.Rows.Count = 0 Then
                Me.cmdEliminarPIM.Enabled = False
            Else
                Me.cmdEliminarPIM.Enabled = True
            End If

            Me.tdbPIM.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Eliminar PIM"
    Private Sub EliminarPIM()
        Dim strMensaje As String
        strMensaje = "Esta clasificación no puede eliminarse"

        If Me.tdbPIM.RowCount > 0 Then
            Select Case Me.frmLlamado
                Case 3
                    If Me.tdbPIM.Columns("Clasificación").Value = "Empleado" Then
                        MsgBox(strMensaje, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                Case 4
                    If Me.tdbPIM.Columns("Clasificación").Value = "Cliente" Then
                        MsgBox(strMensaje, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                Case 5
                    If Me.tdbPIM.Columns("Clasificación").Value = "Fiador" Then
                        MsgBox(strMensaje, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                Case 6
                    If Me.tdbPIM.Columns("Clasificación").Value = "Proveedor" Then
                        MsgBox(strMensaje, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If

            End Select
        End If
        If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
            frmStbPersonasEditar.dtPIM.Rows.RemoveAt(Me.tdbPIM.Row)
        Else
            Exit Sub
        End If
        If frmStbPersonasEditar.dtPIM.Rows.Count = 0 Then
            Me.cmdEliminarPIM.Enabled = False
        End If
        Me.tdbPIM.Caption = "Clasificaciones (" & frmStbPersonasEditar.dtPIM.Rows.Count & ")"
    End Sub
#End Region

#Region "Guardar PIM Temporalmente"
    Private Sub GuardarPIMTemp()
        Dim objPIM As frmStbPersonasTipoPersonas
        objPIM = New frmStbPersonasTipoPersonas
        objPIM.frmLlamado = frmLlamado
        objPIM.ShowDialog()
        If frmStbPersonasEditar.dtPIM.Rows.Count > 0 Then
            Me.cmdEliminarPIM.Enabled = True
        End If
        Me.tdbPIM.Caption = "Clasificaciones (" & frmStbPersonasEditar.dtPIM.Rows.Count & ")"
    End Sub
#End Region
    'OTROS
    '*****************************************
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

    Property frmLlamado() As Integer
        Get
            Return Llamado_Lec
        End Get
        Set(ByVal value As Integer)
            Llamado_Lec = value
        End Set
    End Property

    Public Property CedulaAnverso() As Byte()
        Get
            Return imgCedulaAnverso
        End Get
        Set(ByVal value As Byte())
            imgCedulaAnverso = value
        End Set
    End Property

    Public Property CedulaReverso() As Byte()
        Get
            Return imgCedulaReverso
        End Get
        Set(ByVal value As Byte())
            imgCedulaReverso = value
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

    Private Sub txtSiglasEmpresa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSiglasEmpresa.Leave
        Me.txtSiglasEmpresa.Text = Me.txtSiglasEmpresa.Text.Trim
        If Me.txtSiglasEmpresa.Text.Trim.Length > 0 Then
            Me.txtSiglasEmpresa.Text = Me.txtSiglasEmpresa.Text.Substring(0, 1).ToUpper & Me.txtSiglasEmpresa.Text.Substring(1, Me.txtSiglasEmpresa.Text.Length - 1)
        End If
    End Sub

    Private Sub txtRazonSocial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazonSocial.Leave
        Me.txtRazonSocial.Text = Me.txtRazonSocial.Text.Trim
        If Me.txtRazonSocial.Text.Trim.Length > 0 Then
            Me.txtRazonSocial.Text = Me.txtRazonSocial.Text.Substring(0, 1).ToUpper & Me.txtRazonSocial.Text.Substring(1, Me.txtRazonSocial.Text.Length - 1)
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

    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCedula.KeyUp
        Me.txtCedula.Text = Me.txtCedula.Text.ToUpper
    End Sub
    Private Sub txtSiglasEmpresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSiglasEmpresa.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtSiglasEmpresa.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtRazonSocial.Focus()
        End If
    End Sub

    Private Sub txtRazonSocial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtRazonSocial.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        
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

    Private Sub txtRUC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
        Me.ErrPrv.SetError(Me.txtRUC, "")
    End Sub

    Private Sub cmbGenero_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenero.Click
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

    Private Sub cmbGenero_ValueMemberChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenero.ValueMemberChanged
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

#End Region

#Region "Varios"

    Private Sub chkPersonaJuridica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonaJuridica.CheckedChanged
        Me.ManejarPersonaJuridica()
    End Sub

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
        Select Case Me.TyGui
            Case 1
                Me.AgregarPersonas()
            Case 2
                Me.EditarPersonas()
        End Select
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdEliminarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminarContacto.Click
        Me.EliminarContactos()
    End Sub
    Private Sub cmdEliminarPIM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminarPIM.Click
        Me.EliminarPIM()
    End Sub
    Private Sub cmdAgregarPIM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarPIM.Click
        Me.GuardarPIMTemp()
    End Sub

    Private Sub cmdAgregarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarContacto.Click
        Me.GuardarContactosTemp()
    End Sub

#End Region

#Region "Cargar el Formulario"

    Private Sub frmStbPersonasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.CargarLongitudesMaximas()
            Me.CargarCombos()
            CargarCiudad()
            Me.CargarGridContactos()
            Me.CargarGridPIM()
            Me.ManejarPersonaJuridica()

            Select Case Me.TyGui
                Case 1
                    Select Case frmLlamado
                        Case 3
                            Me.Text = "Agregar Nuevo Empleado"
                        Case 4
                            Me.Text = "Agregar Nuevo Cliente"
                        Case 5
                            Me.Text = "Agregar Nuevo Fiador"
                        Case 6
                            Me.Text = "Agregar Nuevo Proveedor"
                        Case 7
                            Me.Text = "Agregar Nuevo Contacto de Proveedor"
                    End Select
                    Me.ValidarLlamados()
                    Me.txtPrimerNombre.Focus()
                Case 2
                    Select Case frmLlamado
                        Case 3
                            Me.Text = "Editanto datos de Empleado: " & Me.idpersona
                        Case 4
                            Me.Text = "Editanto datos de Cliente: " & Me.idpersona
                        Case 5
                            Me.Text = "Editanto datos de Fiador: " & Me.idpersona
                        Case 6
                            Me.Text = "Editanto datos de Proveedor: " & Me.idpersona
                        Case 7
                            Me.Text = "Editanto datos de Contacto de Proveedor"
                    End Select
                    Me.CargarDatosEditar()
                    Me.txtPrimerNombre.Focus()
                Case 3
                    Select Case frmLlamado
                        Case 3
                            Me.Text = "Consultando datos de Empleado: " & Me.idpersona
                        Case 4
                            Me.Text = "Consultando datos de Cliente: " & Me.idpersona
                        Case 5
                            Me.Text = "Consultando datos de Fiador: " & Me.idpersona
                        Case 6
                            Me.Text = "Consultando datos de Proveedor: " & Me.idpersona
                        Case 7
                            Me.Text = "Consultando datos de Contacto de Proveedor"
                    End Select

                    Me.CargarDatosEditar()

                    Me.tdbPIM.Enabled = False
                    Me.barContactos.Enabled = False
                    Me.barPIM.Enabled = False
                    Me.cmdGuardar.Enabled = False
                    Me.cmbGenero.Enabled = False
                    Me.dtpFechaNacimiento.Enabled = False
                    Me.txtCedula.Enabled = False
                    Me.txtRUC.Enabled = False
                    Me.cmbCiudad.Enabled = False
                    Me.txtDireccion.Enabled = False
                    Me.txtSiglasEmpresa.Enabled = False
                    Me.txtRazonSocial.Enabled = False

                    Me.txtPrimerNombre.Enabled = False
                    Me.txtSegundoNombre.Enabled = False
                    Me.txtPrimerApellido.Enabled = False
                    Me.txtSegundoApellido.Enabled = False

                    Me.txtDireccion.Tag = "BLOQUEADO"
                    Me.cmbCiudad.Tag = "BLOQUEADO"
                    Me.chkPersonaJuridica.Tag = "BLOQUEADO"
                    Me.txtPrimerNombre.Tag = "BLOQUEADO"
                    Me.txtSegundoNombre.Tag = "BLOQUEADO"
                    Me.txtPrimerApellido.Tag = "BLOQUEADO"
                    Me.txtSegundoApellido.Tag = "BLOQUEADO"
                    Me.txtRazonSocial.Tag = "BLOQUEADO"
                    Me.txtSiglasEmpresa.Tag = "BLOQUEADO"
            End Select
            Me.tabAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
            Me.tdbContactos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
            Me.tdbPIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        Me.ErrPrv.SetError(Me.txtCedula, "")
    End Sub

    Private Sub cmdConsultarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objVisor As frmVisorCedula
        objVisor = New frmVisorCedula
        objVisor.CedulaAnverso = Me.CedulaAnverso
        objVisor.CedulaReverso = Me.CedulaReverso
        objVisor.ShowDialog(Me)
    End Sub
#End Region

   

    'Private Sub chkCedulaNacionalidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '            Me.txtCedula.Clear()
    '            Me.txtCedula.Mask = "000-000000-0000L"
    '        Case False
    '            Me.txtCedula.Clear()
    '            Me.txtCedula.Mask = ""
    '    End Select
    'End Sub

  
    
End Class