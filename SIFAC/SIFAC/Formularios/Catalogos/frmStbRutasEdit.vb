Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmStbRutasEdit

#Region "Declaracion de Variables"
    Public DtMarca, DtCilindraje, DtSegmento As DataTable
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

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            txtNombre.Focus()
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
                    cbxCiudad.Enabled = False
                    cmbDiaCrobro.Enabled = False
                    cmbSupervisor.Enabled = False
                    cbxCobrador.Enabled = False
                    chkActivo.Enabled = False
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
            cbxCiudad.SelectedValue = objRutas.objCiudadID
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
            objRutas.Codigo = txtCodigo.Text
            objRutas.objCobradorID = cbxCobrador.SelectedValue
            objRutas.objSupervisor = cmbSupervisor.SelectedValue
            objRutas.objCiudadID = cbxCiudad.SelectedValue
            objRutas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cbxCiudad.SelectedValue).DefaultView(0)("objPaisID")
            objRutas.DiaCobro = cmbDiaCrobro.Text
            objRutas.CargarDiferenciada = ckdCargaDiferenciada.Checked
            objRutas.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objRutas.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objRutas.Insert()
            T.CommitTran()
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
            objRutas.objCiudadID = cbxCiudad.SelectedValue
            objRutas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cbxCiudad.SelectedValue).DefaultView(0)("objPaisID")
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

#End Region

#Region "Funciones"

    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
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

        If cbxCiudad.Text.Trim.Length = 0 Then
            ErrorProv.SetError(cbxCiudad, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If cbxCobrador.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtNombre, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

  

        Return True
    End Function
#End Region

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 0
                    GuardarRuta()
                Case 1
                    EditarRuta()
            End Select

        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub frmStbRutasEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        ConfigurarGUI()
        Me.boolEditado = False
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
End Class