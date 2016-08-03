Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO


Public Class frmStbPersonasEditar

    '******************************************
#Region "Declaraci�n de Variables propias del formulario"
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
            'G�nero
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

    Private Sub CargarOcupacion()
        dtOcupacion = Proyecto.Catalogos.Datos.ClsCatalogos.ObtenerValCat("OCUPACION")
        With cmbOcupacion
            .DataSource = dtOcupacion
            .DisplayMember = "Descripcion"
            .ValueMember = "StbValorCatalogoID"
        End With
    End Sub

#End Region

#Region "Manejar Persona Jur�dica"
    Private Sub ManejarPersonaJuridica()
        Select Case Me.chkPersonaJuridica.Checked
            Case True
                Me.ErrPrv.SetError(Me.txtPrimerNombre, "")
                Me.ErrPrv.SetError(Me.txtSegundoNombre, "")
                Me.ErrPrv.SetError(Me.cmbGenero, "")
                Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
                Me.ErrPrv.SetError(Me.txtCedula, "")
                Me.txtPrefijoTrato.Text = ""
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
                Me.chkCedulaNacionalidad.Enabled = False
            Case False
                Me.ErrPrv.SetError(Me.txtSiglasEmpresa, "")
                Me.ErrPrv.SetError(Me.txtRazonSocial, "")
                Me.ErrPrv.SetError(Me.dtpFechaConstitucion, "")
                Me.ErrPrv.SetError(Me.txtRUC, "")
                Me.txtSiglasEmpresa.Text = ""
                Me.txtRazonSocial.Text = ""
                Me.txtRUC.Text = ""
                Me.dtpFechaConstitucion.Value = Nothing
                Me.grpPersonaJuridica.Enabled = False
                Me.grpPersonaNatural.Enabled = True
                Me.txtPrefijoTrato.Focus()
                Me.chkCedulaNacionalidad.Enabled = True
        End Select
    End Sub
#End Region

#Region "Cargar Longitudes M�ximas"
    Private Sub CargarLongitudesMaximas()
        Try
            Me.txtPrefijoTrato.MaxLength = StbPersona.GetMaxLength("PrefijoTrato")
            Me.txtPrimerNombre.MaxLength = StbPersona.GetMaxLength("Nombre1")
            Me.txtSegundoNombre.MaxLength = StbPersona.GetMaxLength("Nombre2")
            Me.txtPrimerApellido.MaxLength = StbPersona.GetMaxLength("Apellido1")
            Me.txtSegundoApellido.MaxLength = StbPersona.GetMaxLength("Apellido2")
            Me.txtSiglasEmpresa.MaxLength = StbPersona.GetMaxLength("SiglasEmpresa")
            Me.txtRazonSocial.MaxLength = StbPersona.GetMaxLength("RazonSocial")
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
    Public Function ValidarIngresos()
        Me.intResultado = 6
        Me.intTelefonoCliente = 0

        'Validar que se haya ingresado al menos la direcci�n de la persona
        For Each dr As DataRow In frmStbPersonasEditar.dtContactos.Rows
            If dr("TipoEntrada") = "Direcci�n" Then
                Me.intResultado = 0
                Exit For
            End If
        Next

        If frmStbPersonasEditar.dtContactos.Rows.Count = 0 Then
            Return 1
            Exit Function
        End If

        If Me.intResultado = 6 Then
            Return 1
            Exit Function
        End If

        frmStbPersonasEditar.dtPIM.DefaultView.RowFilter = "TipoPersona = 'Nacional' OR TipoPersona = 'Extranjero'"
        If frmStbPersonasEditar.dtPIM.DefaultView.Count = 0 Then
            frmStbPersonasEditar.dtPIM.DefaultView.RowFilter = "1 = 1"
            Return 3
            Exit Function
        End If
        'Validar que se haya ingresado al menos un tel�fono de la persona natural
        'con clasificaci�n PIM Cliente

        '1. Se valida que la persona sea Natural
        If Me.chkPersonaJuridica.Checked = False Then Me.intTelefonoCliente = 1
        '2. Se valida que haya un PIM Cliente
        If Me.intTelefonoCliente = 1 Then
            For Each dr As DataRow In frmStbPersonasEditar.dtPIM.Rows
                If dr("TipoPersona") = "Cliente" Then
                    Me.intTelefonoCliente = 2
                End If
            Next
        End If


        '3. Se valida que haya al menos un tel�fono si es cliente
        If Me.intTelefonoCliente = 2 Then
            If frmStbPersonasEditar.dtContactos.Rows.Count = 0 Then
                Me.intResultado = 2
            End If

            For Each dr As DataRow In frmStbPersonasEditar.dtContactos.Rows
                If dr("TipoEntrada").ToString.Trim.Length >= 8 Then
                    If dr("TipoEntrada").ToString.Substring(0, 8) = "Tel�fono" Then
                        Return 0
                        Exit Function
                    Else
                        Me.intResultado = 2
                    End If
                Else
                    Me.intResultado = 2
                End If
            Next
        End If
        '4. Mandar Return = 2 y salir si hay PIM=Cliente y no se ha ingresado el Tel�fono
        If Me.intResultado = 2 Then
            Return Me.intResultado
            Exit Function
        End If

        Return intResultado
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
        Me.txtPrefijoTrato.Enabled = False
        Me.txtPrimerNombre.Enabled = False
        Me.txtSegundoNombre.Enabled = False
        Me.txtPrimerApellido.Enabled = False
        Me.txtSegundoApellido.Enabled = False
        Me.cmbGenero.Enabled = False
        Me.dtpFechaNacimiento.Enabled = False
        Me.txtCedula.Enabled = False
    End Sub
    Private Sub BloquearControlesPersonaJuridica()
        Me.txtSiglasEmpresa.Enabled = False
        Me.txtRazonSocial.Enabled = False
        Me.dtpFechaConstitucion.Enabled = False
        Me.txtRUC.Enabled = False
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
                Select Case Me.ValidarIngresos
                    Case 0
                        Me.InsertarPersonas()
                    Case 1
                        MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir al menos una direcci�n en Contacto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Me.GuardarContactosTemp()
                    Case 2
                        MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir al menos un tel�fono como Contacto del Cliente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Me.GuardarContactosTemp()
                    Case 3
                        MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir la clasificaci�n de persona nacional o extranjero", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        GuardarPIMTemp()
                End Select
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
                        Me.ErrPrv.SetError(Me.txtRUC, "Ya existe una empresa con el mismo n�mero RUC.")
                        Me.txtRUC.Focus()
                        Exit Sub
                    End If
                    'PROCEDER A INGRESAR
                    p_Empresas(0) = New SqlParameter("@nombre1", SqlDbType.VarChar, 20)
                    p_Empresas(0).Value = ""
                    p_Empresas(1) = New SqlParameter("@apellido1", SqlDbType.VarChar, 20)
                    p_Empresas(1).Value = ""

                    p_Empresas(2) = New SqlParameter("@FechaNacimiento", SqlDbType.DateTime)
                    If Me.dtpFechaConstitucion.Text.Trim.Length <> 0 Then
                        p_Empresas(2).Value = Me.dtpFechaConstitucion.Value
                    Else
                        p_Empresas(2).Value = DBNull.Value
                    End If

                    p_Empresas(3) = New SqlParameter("@PersonaJuridica", SqlDbType.Bit)
                    p_Empresas(3).Value = Me.chkPersonaJuridica.Checked
                    p_Personas(4) = New SqlParameter("@Exonerado", SqlDbType.Bit)
                    p_Personas(4).Value = Me.chkExonerado.Checked
                    p_Empresas(5) = New SqlParameter("@RazonSocial", SqlDbType.VarChar, 256)
                    p_Empresas(5).Value = Me.txtRazonSocial.Text.Trim
                    p_Empresas(6) = New SqlParameter("@SiglasEmpresa", SqlDbType.VarChar, 20)
                    p_Empresas(6).Value = Me.txtSiglasEmpresa.Text.Trim

                    p_Empresas(7) = New SqlParameter("@RUC", SqlDbType.VarChar, 11)
                    If Me.txtRUC.Text.Trim = "-" Then
                        p_Empresas(7).Value = DBNull.Value
                    Else
                        p_Empresas(7).Value = Me.txtRUC.Text.Trim
                    End If

                    p_Empresas(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar, 30)
                    p_Empresas(8).Value = clsProyecto.Conexion.Usuario
                    p_Empresas(9) = New SqlParameter("@IDGenerado", SqlDbType.VarChar, 16)
                    p_Empresas(9).Direction = ParameterDirection.InputOutput
                    p_Empresas(9).Value = ""

                    DAL.SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "usp_InsertarPersonas", p_Empresas)
                    Me.idpersona = p_Empresas(8).Value.ToString

                Case False
                    '1.2 Validar que no exista  una persona con la misma c�dula
                    objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedula.Text + "'")
                    If objPCompara.Cedula <> Nothing Then
                        Me.ErrPrv.SetError(Me.txtCedula, "Ya existe una persona con la misma c�dula.")
                        Me.txtCedula.Focus()
                        Exit Sub
                    End If
                    'PROCEDER A INGRESAR
                    p_Personas(0) = New SqlParameter("@prefijotrato", SqlDbType.VarChar, 5)
                    p_Personas(0).Value = Me.txtPrefijoTrato.Text.Trim
                    p_Personas(1) = New SqlParameter("@nombre1", SqlDbType.VarChar, 20)
                    p_Personas(1).Value = Me.txtPrimerNombre.Text.Trim
                    p_Personas(2) = New SqlParameter("@nombre2", SqlDbType.VarChar, 20)
                    p_Personas(2).Value = Me.txtSegundoNombre.Text.Trim
                    p_Personas(3) = New SqlParameter("@apellido1", SqlDbType.VarChar, 20)
                    p_Personas(3).Value = Me.txtPrimerApellido.Text.Trim
                    p_Personas(4) = New SqlParameter("@apellido2", SqlDbType.VarChar, 20)
                    p_Personas(4).Value = Me.txtSegundoApellido.Text.Trim
                    p_Personas(5) = New SqlParameter("@objGeneroID", SqlDbType.Int)
                    p_Personas(5).Value = Me.cmbGenero.SelectedValue

                    p_Personas(6) = New SqlParameter("@cedula", SqlDbType.VarChar, 16)
                    If Me.txtCedula.Text.Trim = "-      -" Then
                        p_Personas(6).Value = DBNull.Value
                    Else
                        p_Personas(6).Value = Me.txtCedula.Text.Trim
                    End If

                    p_Personas(7) = New SqlParameter("@CedulaAnverso", SqlDbType.Image)
                    If Me.txtCedulaAnverso.Text.Trim.Length = 0 Then
                        p_Personas(7).Value = DBNull.Value
                    Else
                        p_Personas(7).Value = Me.CedulaAnverso
                    End If

                    p_Personas(8) = New SqlParameter("@CedulaReverso", SqlDbType.Image)

                    If Me.txtCedulaAnverso.Text.Trim.Length = 0 Then
                        p_Personas(8).Value = DBNull.Value
                    Else
                        p_Personas(8).Value = Me.CedulaReverso
                    End If

                    p_Personas(9) = New SqlParameter("@FechaNacimiento", SqlDbType.DateTime)
                    If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                        p_Personas(9).Value = Me.dtpFechaNacimiento.Value
                    Else
                        p_Personas(9).Value = DBNull.Value
                    End If

                    p_Personas(10) = New SqlParameter("@objOcupacionID", SqlDbType.Int)
                    p_Personas(10).Value = cmbOcupacion.SelectedValue
                    p_Personas(11) = New SqlParameter("@PersonaJuridica", SqlDbType.Bit)
                    p_Personas(11).Value = Me.chkPersonaJuridica.Checked
                    p_Personas(12) = New SqlParameter("@Exonerado", SqlDbType.Bit)
                    p_Personas(12).Value = Me.chkExonerado.Checked
                    p_Personas(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar, 30)
                    p_Personas(13).Value = clsProyecto.Conexion.Usuario
                    p_Personas(14) = New SqlParameter("@IDGenerado", SqlDbType.VarChar, 16)
                    p_Personas(14).Direction = ParameterDirection.InputOutput
                    p_Personas(14).Value = ""

                    DAL.SqlHelper.ExecuteScalar(CommandType.StoredProcedure, "usp_InsertarPersonas", p_Personas)
                    Me.idpersona = p_Personas(14).Value.ToString
            End Select
            ValidarLlamados()
            Me.InsertarDetalle(Me.idpersona)
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

    Private Sub InsertarDetalle(ByVal IDGenerado As String)

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
                objContactos.Insert()
            Next
            'Guardar PIM
            For Each dr As DataRow In frmStbPersonasEditar.dtPIM.Rows
                objClasifica.objPersonaID = IDGenerado
                objClasifica.objTipoPersonaID = CInt(dr("objTipoPersonaID").ToString)
                objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objClasifica.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objClasifica.Insert()
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
            Me.chkExonerado.Checked = objPersonas.Exonerado
            Me.chkPersonaJuridica.Enabled = False
            Me.ManejarPersonaJuridica()

            Select Case Me.chkPersonaJuridica.Checked
                Case True
                    Me.txtSiglasEmpresa.Text = objPersonas.SiglasEmpresa
                    Me.txtRazonSocial.Text = objPersonas.RazonSocial
                    If objPersonas.FechaNacimiento.ToString.Length <> 0 Then
                        Me.dtpFechaConstitucion.Value = objPersonas.FechaNacimiento
                    End If
                    Me.txtRUC.Text = objPersonas.RUC
                Case False
                    Me.txtPrefijoTrato.Text = objPersonas.PrefijoTrato
                    Me.txtPrimerNombre.Text = objPersonas.Nombre1
                    Me.txtSegundoNombre.Text = objPersonas.Nombre2
                    Me.txtPrimerApellido.Text = objPersonas.Apellido1
                    Me.txtSegundoApellido.Text = objPersonas.Apellido2
                    Me.cmbGenero.SelectedValue = objPersonas.objGeneroID
                    If objPersonas.Cedula.Trim.Length = 16 Then
                        Me.chkCedulaNacionalidad.Checked = True
                    Else
                        Me.chkCedulaNacionalidad.Checked = False
                    End If

                    Me.txtCedula.Text = objPersonas.Cedula

                    If objPersonas.FechaNacimiento.ToString.Length <> 0 Then
                        Me.dtpFechaNacimiento.Value = objPersonas.FechaNacimiento
                    End If
                    If objPersonas.objOcupacionID.HasValue Then
                        cmbOcupacion.SelectedValue = objPersonas.objOcupacionID
                    End If

                    If Not IsDBNull(objPersonas.CedulaAnverso) And Not IsDBNull(objPersonas.CedulaReverso) Then
                        Me.CedulaAnverso = objPersonas.CedulaAnverso
                        Me.CedulaReverso = objPersonas.CedulaReverso
                        cmdConsultarCedula.Enabled = True
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

                Select Case Me.ValidarIngresos
                    Case 0
                        Me.ModificarPersonas()
                    Case 1
                        MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir al menos una direcci�n en Contacto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Me.GuardarContactosTemp()
                    Case 2
                        MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir al menos un tel�fono como Contacto del Cliente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Me.GuardarContactosTemp()
                    Case 3
                        MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir Nacionalidad", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                End Select
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
                    objPersonas.Exonerado = Me.chkExonerado.Checked
                    If Me.txtRUC.Text.Trim <> "-" Then
                        objPersonas.RUC = Me.txtRUC.Text.Trim
                    Else
                        objPersonas.RUC = Nothing
                    End If
                    If Me.dtpFechaConstitucion.Text.Trim.Length <> 0 Then
                        objPersonas.FechaNacimiento = Me.dtpFechaConstitucion.Text
                    Else
                        objPersonas.FechaNacimiento = Nothing
                    End If
                Case False
                    objPersonas.PrefijoTrato = Me.txtPrefijoTrato.Text.Trim
                    objPersonas.Nombre1 = Me.txtPrimerNombre.Text.Trim
                    objPersonas.Nombre2 = Me.txtSegundoNombre.Text.Trim
                    objPersonas.Apellido1 = Me.txtPrimerApellido.Text.Trim
                    objPersonas.Apellido2 = Me.txtSegundoApellido.Text.Trim
                    objPersonas.objGeneroID = Me.cmbGenero.SelectedValue
                    objPersonas.Exonerado = Me.chkExonerado.Checked
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
                    If Me.cmbOcupacion.Text.Trim.Length = 0 Then
                        objPersonas.objOcupacionID = Nothing
                    Else
                        objPersonas.objOcupacionID = cmbOcupacion.SelectedValue
                    End If
                    If txtCedulaAnverso.Text.Trim.Length <> 0 Then
                        objPersonas.CedulaAnverso = Me.CedulaAnverso
                    End If
                    If txtCedulaReverso.Text.Trim.Length <> 0 Then
                        objPersonas.CedulaReverso = Me.CedulaReverso
                    End If
            End Select

            objPersonas.Update()
            Me.ModificarDetalle()
            Me.InsertarDetalle(Me.idpersona)
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
    Private Sub ModificarDetalle()

        Try

            StbPersonaClasificacion.DeleteByFilter("objPersonaID='" + Me.idpersona + "'")
            StbContactos.DeleteByFilter("objPersonaID='" + Me.idpersona + "'")

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
    ' Nombre del Autor    		:	R�ger Alberto Guti�rrez Mej�a
    ' Fecha de Elaboraci�n 		:	16 de Febrero de 2009
    ' Descripci�n			   	:	Funci�n para verificar la validez de una fecha
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

#Region "Validar C�dulas en General"
    ' -----------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	R�ger Alberto Guti�rrez Mej�a
    ' Fecha de Elaboraci�n 		:	16 de Febrero de 2009
    ' Descripci�n			   	:	Funci�n para verificar la validez de una c�dula
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
                Me.ErrPrv.SetError(Me.txtRUC, "N�mero RUC no v�lido")
                Me.txtRUC.Focus()
                Return False
                Exit Function
            End If
        Next
        'Validar que el n�mero RUC sea v�lido
        If Me.txtRUC.Text.Trim.Length = 11 Then
            If Me.FechaValida(Me.txtRUC.Text.Substring(0, 2), Me.txtRUC.Text.Substring(2, 2), Me.txtRUC.Text.Substring(4, 2)) = False Then
                Me.ErrPrv.SetError(Me.txtRUC, "N�mero RUC no v�lido")
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

#Region "Validar C�dulas"
    Private Function ValidarCedula()
        'Validar que haya algo en la c�dula
        If Me.txtCedula.Text.Trim.Replace(" ", "").Replace("-", "").Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtCedula, My.Resources.MsgObligatorio)
            Me.txtCedula.Focus()
            Return False
            Exit Function
        End If
        'Validar que no haya espacios intermedios
        For intCaracter As Integer = 0 To Me.txtCedula.Text.Trim.Length - 1
            If Me.txtCedula.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                Me.ErrPrv.SetError(Me.txtCedula, "N�mero de C�dula no v�lido")
                Me.txtCedula.Focus()
                Return False
                Exit Function
            End If
        Next
        'Validar que la fecha de la c�dula sea v�lida
        If Me.txtCedula.Text.Trim.Length = 16 Then
            If Me.CedulaValida(Me.txtCedula.Text) = False Then
                Me.ErrPrv.SetError(Me.txtCedula, "N�mero de C�dula no v�lido")
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
        'Validar el G�nero
        If Me.cmbGenero.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbGenero, "Debe especificar el g�nero de la persona")
            Me.cmbGenero.Focus()
            Return False
            Exit Function
        End If

        'Validar la c�dula
        Select Case Me.chkCedulaNacionalidad.Checked
            Case True
                If Me.ValidarCedula = False Then
                    Me.txtCedula.Focus()
                    Return False
                    Exit Function
                End If
                'Validar que la fecha de nacimiento sea igual al n�mero de c�dula
                If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 And Me.txtCedula.Text.Trim.Length = 16 Then
                    If Me.dtpFechaNacimiento.Text.Substring(0, 6) & Me.dtpFechaNacimiento.Text.Substring(8, 2) <> (Me.txtCedula.Text.Substring(4, 2) & "/" & Me.txtCedula.Text.Substring(6, 2) & "/" & Me.txtCedula.Text.Substring(8, 2)) Then
                        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "La fecha de nacimiento debe coincidir con los d�gitos centrales de la c�dula")
                        Me.dtpFechaNacimiento.Focus()
                        Return False
                        Exit Function
                    End If
                End If

            Case False 'NO OBLIGAR EL CAMPO CEDULA QUE LO GENERE EL SISTEMA.
                'If Me.txtCedula.Text.Trim.Length = 0 Then
                '    Me.ErrPrv.SetError(Me.txtCedula, "Campo Obligatorio")
                '    Me.txtCedula.Focus()
                '    Return False
                '    Exit Function
                'End If

        End Select
        

        Return True
    End Function
#End Region

#Region "Validar Personas Jur�dicas"
    Private Function ValidarPersonasJuridicas()

        'Validar las siglas de la empresa
        If Me.txtSiglasEmpresa.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtSiglasEmpresa, "Debe especificar las siglas de la empresa")
            Me.txtSiglasEmpresa.Focus()
            Return False
            Exit Function
        End If
        'Validar la raz�n social
        If Me.txtRazonSocial.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtRazonSocial, "Debe especificar la raz�n social de la empresa")
            Me.txtRazonSocial.Focus()
            Return False
            Exit Function
        End If
        'Validar N�mero RUC
        If Me.ValidarRUC = False Then
            Me.ErrPrv.SetError(Me.txtRUC, "N�mero RUC no v�lido")
            Me.txtRUC.Focus()
            Return False
            Exit Function
        End If
        'Validar que la fecha de constituci�n sea igual al n�mero RUC
        If Me.dtpFechaConstitucion.Text.Trim.Length <> 0 And Me.txtRUC.Text.Trim.Length = 11 Then
            If Me.dtpFechaConstitucion.Text.Substring(0, 6) & Me.dtpFechaConstitucion.Text.Substring(8, 2) <> (Me.txtRUC.Text.Substring(0, 2) & "/" & Me.txtRUC.Text.Substring(2, 2) & "/" & Me.txtRUC.Text.Substring(4, 2)) Then
                Me.ErrPrv.SetError(Me.dtpFechaConstitucion, "La fecha de constituci�n debe coincidir con el RUC")
                Me.dtpFechaConstitucion.Focus()
                Return False
                Exit Function
            End If
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
        objContactos.frmLLamado = 0
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
        strMensaje = "Esta clasificaci�n no puede eliminarse"

        If Me.tdbPIM.RowCount > 0 Then
            Select Case Me.frmLlamado
                Case 3
                    If Me.tdbPIM.Columns("Clasificaci�n").Value = "Empleado" Then
                        MsgBox(strMensaje, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                Case 4
                    If Me.tdbPIM.Columns("Clasificaci�n").Value = "Cliente" Then
                        MsgBox(strMensaje, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                Case 5
                    If Me.tdbPIM.Columns("Clasificaci�n").Value = "Fiador" Then
                        MsgBox(strMensaje, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                Case 6
                    If Me.tdbPIM.Columns("Clasificaci�n").Value = "Proveedor" Then
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

#Region "Poner en may�scula la primer letra"
    Private Sub txtPrefijoTrato_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrefijoTrato.Leave
        Me.txtPrefijoTrato.Text = Me.txtPrefijoTrato.Text.Trim
        If Me.txtPrefijoTrato.Text.Trim.Length > 0 Then
            Me.txtPrefijoTrato.Text = Me.txtPrefijoTrato.Text.Substring(0, 1).ToUpper & Me.txtPrefijoTrato.Text.Substring(1, Me.txtPrefijoTrato.Text.Length - 1)
        End If
    End Sub


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
    Private Sub txtPrefijoTrato_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrefijoTrato.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtPrefijoTrato.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtPrimerNombre.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtPrefijoTrato, "")
        End If
    End Sub

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
            Me.cmdAceptar.Focus()
        End If
        Me.ErrPrv.SetError(Me.txtCedula, "")
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.txtCedula.Text = Me.txtCedula.Text.ToUpper
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
        If Asc(e.KeyChar) = 13 Then
            Me.dtpFechaConstitucion.Focus()
        End If
    End Sub

    Private Sub dtpFechaConstitucion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaConstitucion, "")
        Me.ErrPrv.SetError(Me.txtRUC, "")
        If Asc(e.KeyChar) = 13 Then
            Me.txtRUC.Focus()
        End If
    End Sub

    Private Sub dtpFechaConstitucion_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaConstitucion, "")
        Me.ErrPrv.SetError(Me.txtRUC, "")
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

    Private Sub dtpFechaConstitucion_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaConstitucion, "")
        Me.ErrPrv.SetError(Me.txtRUC, "")
        If Asc(e.KeyChar) = 13 Then
            Me.txtRUC.Focus()
        End If
    End Sub

    Private Sub dtpFechaConstitucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaConstitucion, "")
        Me.ErrPrv.SetError(Me.txtRUC, "")
    End Sub

    Private Sub txtRUC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdAceptar.Focus()
        End If
        Me.ErrPrv.SetError(Me.txtRUC, "")
        Me.ErrPrv.SetError(Me.dtpFechaConstitucion, "")
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

    Private Sub dtpFechaConstitucion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dtpFechaConstitucion.Text.Trim.Length = 0 Then
            Me.dtpFechaConstitucion.Value = Nothing
        End If
    End Sub

#End Region

#End Region

#Region "Eventos de los botones"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
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

    Private Sub cmdCedulaAnverso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCedulaAnverso.Click
        Me.ArchivoDialogo.FileName = "C�dula Anverso"
        If Me.ArchivoDialogo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            txtCedulaAnverso.Text = Me.ArchivoDialogo.FileName
            Me.CedulaAnverso = Me.Ficheros(txtCedulaAnverso.Text)
            cmdConsultarCedula.Enabled = True
        End If
    End Sub

    Private Sub cmdCedulaReverso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCedulaReverso.Click
        Me.ArchivoDialogo.FileName = "C�dula Reverso"
        If Me.ArchivoDialogo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            txtCedulaReverso.Text = Me.ArchivoDialogo.FileName
            Me.CedulaReverso = Me.Ficheros(txtCedulaReverso.Text)
            cmdConsultarCedula.Enabled = True
        End If
    End Sub

#End Region

#Region "Cargar el Formulario"

    Private Sub frmStbPersonasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarLongitudesMaximas()
        Me.CargarCombos()
        Me.CargarOcupacion()
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
                Me.txtPrefijoTrato.Focus()
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
                Me.txtPrefijoTrato.Focus()
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
                Me.cmdAceptar.Enabled = False
                Me.cmbGenero.Enabled = False
                Me.dtpFechaNacimiento.Enabled = False
                Me.txtCedula.Enabled = False
                Me.dtpFechaConstitucion.Enabled = False
                Me.txtRUC.Enabled = False
                Me.cmbOcupacion.Enabled = False
                Me.cmdCedulaAnverso.Enabled = False
                Me.cmdCedulaReverso.Enabled = False
                Me.txtSiglasEmpresa.Enabled = False
                Me.txtRazonSocial.Enabled = False
                Me.chkCedulaNacionalidad.Enabled = False

                Me.txtPrefijoTrato.Enabled = False
                Me.txtPrimerNombre.Enabled = False
                Me.txtSegundoNombre.Enabled = False
                Me.txtPrimerApellido.Enabled = False
                Me.txtSegundoApellido.Enabled = False

                Me.chkPersonaJuridica.Tag = "BLOQUEADO"
                Me.txtPrefijoTrato.Tag = "BLOQUEADO"
                Me.txtPrimerNombre.Tag = "BLOQUEADO"
                Me.txtSegundoNombre.Tag = "BLOQUEADO"
                Me.txtPrimerApellido.Tag = "BLOQUEADO"
                Me.txtSegundoApellido.Tag = "BLOQUEADO"
                Me.txtRazonSocial.Tag = "BLOQUEADO"
                Me.txtSiglasEmpresa.Tag = "BLOQUEADO"

                '' clsProyecto.CargarTemaDefinido(Me)
        End Select
        Me.tabAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        Me.tdbContactos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        Me.tdbPIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

#End Region

    Private Sub cmdConsultarCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarCedula.Click
        Dim objVisor As frmVisorCedula
        objVisor = New frmVisorCedula
        objVisor.CedulaAnverso = Me.CedulaAnverso
        objVisor.CedulaReverso = Me.CedulaReverso
        objVisor.ShowDialog(Me)
    End Sub

    Private Sub chkCedulaNacionalidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCedulaNacionalidad.CheckedChanged
        Select Case Me.chkCedulaNacionalidad.Checked
            Case True
                Me.txtCedula.Clear()
                Me.txtCedula.Mask = "000-000000-0000L"
            Case False
                Me.txtCedula.Clear()
                Me.txtCedula.Mask = ""
        End Select
    End Sub
End Class