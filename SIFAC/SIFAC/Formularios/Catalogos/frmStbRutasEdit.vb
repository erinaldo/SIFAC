Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos

Public Class frmStbRutasEdit

#Region "Declaracion de Variables"
    Public DtMarca, DtCilindraje, DtSegmento As DataTable
    Public DtCobrador, DtSupervisor As DataTable
    Public intTypeGui As Integer
    Public intRutaID As Integer
    Public boolEditado As Boolean
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property RutaID() As Integer
        Get
            Return intRutaID
        End Get
        Set(ByVal value As Integer)
            intRutaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripción:        Procedimiento encargado de cargar el combo de Cobrador
    Public Sub CargarCobrador()
        Try
            DtCobrador = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))
            With cbxCobrador
                .DataSource = DtCobrador
                .DisplayMember = "NombreCompleto"
                .ValueMember = "SrhEmpleadoID"
                .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
                .Splits(0).DisplayColumns("objPersonaID").Visible = False
                .ColumnHeaders = False
                .ExtendRightColumn = True
                .SelectedValue = -1
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarSupervisor()
        Try
            DtSupervisor = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))
            With cmbSupervisor
                .DataSource = DtSupervisor
                .DisplayMember = "NombreCompleto"
                .ValueMember = "SrhEmpleadoID"
                .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
                .Splits(0).DisplayColumns("objPersonaID").Visible = False
                .ColumnHeaders = False
                .ExtendRightColumn = True
                .SelectedValue = -1
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            txtNombre.Focus()
            CargarSupervisor()
            CargarCobrador()
            CargarCiudad()
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Ruta"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False
                Case 1
                    Me.Text = "Editar Ruta"
                    CargarDatosRuta()
                    chkActivo.Enabled = True
                Case 2
                    Me.Text = "Consultar Ruta"
                    CargarDatosRuta()
                    txtNombre.Enabled = False
                    cmbCiudad.Enabled = False
                    txtDescripcion.Enabled = False
                    cmbDiaCrobro.Enabled = False
                    cmbSupervisor.Enabled = False
                    cbxCobrador.Enabled = False
                    chkActivo.Enabled = False
                    ckdCargaDiferenciada.Enabled = False
                    cmdGuardar.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una marca
    Public Sub CargarDatosRuta()
        Dim objRutas As StbRutas
        Try
            objRutas = New StbRutas
            objRutas.Retrieve(RutaID)
            txtCodigo.Text = objRutas.Codigo
            txtNombre.Text = objRutas.Nombre
            cbxCobrador.SelectedValue = objRutas.objCobradorID
            cmbSupervisor.SelectedValue = objRutas.objSupervisor
            cmbDiaCrobro.Text = objRutas.DiaCobro
            cmbCiudad.SelectedValue = objRutas.objCiudadID
            chkActivo.Checked = objRutas.Activa
            ckdCargaDiferenciada.Checked = objRutas.CargarDiferenciada
            txtDescripcion.Text = objRutas.Descripcion
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRutas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de marca
    Public Sub GuardarRuta()
        Dim objRutas As StbRutas
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objRutas = New StbRutas
            objRutas.Nombre = txtNombre.Text.Trim
            objRutas.Descripcion = txtDescripcion.Text.Trim
            objRutas.Activa = chkActivo.Checked
            objRutas.objCobradorID = cbxCobrador.SelectedValue
            objRutas.objSupervisor = cmbSupervisor.SelectedValue
            objRutas.objCiudadID = cmbCiudad.SelectedValue
            objRutas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
            objRutas.DiaCobro = cmbDiaCrobro.Text
            objRutas.CargarDiferenciada = ckdCargaDiferenciada.Checked
            objRutas.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objRutas.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objRutas.Insert()
            T.CommitTran()

            objRutas.Codigo = "RUT" + cmbCiudad.Text.Substring(0, 3) + objRutas.StbRutaID
            txtCodigo.Text = objRutas.Codigo
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objRutas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de editar la informacion de una marca
    Public Sub EditarRuta()
        Dim objRutas As StbRutas
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objRutas = New StbRutas
            objRutas.StbRutaID = RutaID
            objRutas.Nombre = txtNombre.Text.Trim
            objRutas.Descripcion = txtDescripcion.Text.Trim
            objRutas.Activa = chkActivo.Checked
            objRutas.Codigo = txtCodigo.Text
            objRutas.objCobradorID = cbxCobrador.SelectedValue
            objRutas.objSupervisor = cmbSupervisor.SelectedValue
            objRutas.objCiudadID = cmbCiudad.SelectedValue
            objRutas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
            objRutas.DiaCobro = cmbDiaCrobro.Text
            objRutas.CargarDiferenciada = ckdCargaDiferenciada.Checked
            objRutas.UsuarioModificacion = clsProyecto.Conexion.Servidor
            objRutas.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objRutas.Update()
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objRutas = Nothing
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

        End Try
    End Sub

#End Region

#Region "Funciones"


    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Try
            If txtNombre.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtNombre, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbDiaCrobro.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbDiaCrobro, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbCiudad.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbCiudad, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cbxCobrador.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtNombre, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

        Return True
    End Function
#End Region

#Region "Eventos del Formulario"

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            If ValidarEntrada() Then
                Select Case TypeGui
                    Case 0
                        GuardarRuta()
                    Case 1
                        EditarRuta()
                End Select

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub frmStbRutasEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            ConfigurarGUI()
            Me.boolEditado = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmStbRutasEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub
#End Region

End Class