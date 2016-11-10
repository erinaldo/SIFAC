Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmBodegasEditar

#Region "Declaracion de Variables"
    Public DtCiudad, DtJefe As DataTable
    Public intTypeGui As Integer
    Public intBodegaID As Integer
    Public boolEditado As Boolean
    Dim fechaServidor As Date
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

    Property BodegaID() As Integer
        Get
            Return intBodegaID
        End Get
        Set(ByVal value As Integer)
            intBodegaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Carga de Datos"

    '' Descripción:        Procedimiento encargado de cargar los valores de ciudad
    Public Sub CargarCiudad()
        Try
            DtCiudad = StbCiudad.RetrieveDT("", "", "StbCiudadID,Nombre")

            cmbCiudad.ValueMember = "StbCiudadID"
            cmbCiudad.DisplayMember = "Nombre"
            cmbCiudad.DataSource = DtCiudad
            cmbCiudad.Text = ""

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarJefe()
        Try
            DtJefe = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))

            cmbJefe.ValueMember = "SrhEmpleadoID"
            cmbJefe.DisplayMember = "NombreCompleto"
            cmbJefe.DataSource = DtJefe
            cmbJefe.Text = ""
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de mostrar los datos de una bodega en modo de edición
    Public Sub CargarDatosBodega()
        Dim objBodega As StbBodegas
        Try
            objBodega = New StbBodegas
            objBodega.Retrieve(BodegaID)

            txtNombre.Text = objBodega.Nombre
            If Not String.IsNullOrEmpty(objBodega.Codigo) Then
                txtCodigo.Text = objBodega.Codigo
            End If
            cmbCiudad.SelectedValue = objBodega.objCiudadID
            cmbJefe.SelectedValue = objBodega.objJefeBodegaID

            If objBodega.Activo.HasValue Then
                chkActivo.Checked = objBodega.Activo
            End If
           
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objBodega = Nothing
        End Try
    End Sub


#End Region

#Region "Nuevo Jefe"
    Public Sub NuevoJefe()
        Dim editEmpleado As frmSrhEmpleadoEditar
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 0
            If editEmpleado.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarJefe()
                cmbJefe.SelectedValue = editEmpleado.intEmpleadoID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#Region "Consutar jefe"
    Public Sub ConsultarJefe()
        Dim editEmpleado As frmSrhEmpleadoEditar
        Dim objEmpleado As New SrhEmpleado
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 2
            editEmpleado.EmpleadoID = Me.cmbJefe.SelectedValue
            objEmpleado.Retrieve(Me.cmbJefe.SelectedValue)
            editEmpleado.PersonaID = objEmpleado.objPersonaID
            editEmpleado.Text = "Consultar Empleado"
            editEmpleado.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Select Case TypeGUI
            Case 1
                Me.Text = "Nueva Bodega"
                Me.chkActivo.Enabled = False
                Me.chkActivo.Checked = True
            Case 2
                Me.Text = "Editar Bodega"
                Me.chkActivo.Enabled = True
                Me.CargarDatosBodega()
            Case 3
                Me.Text = "Consultar Bodega"
                Me.CargarDatosBodega()
                Me.txtNombre.Enabled = False
                Me.txtCodigo.Enabled = False
                Me.cmbCiudad.Enabled = False
                Me.cmbJefe.Enabled = False
                Me.cmdJefe.Enabled = False
                Me.chkActivo.Enabled = False
                Me.cmdGuardar.Enabled = False
        End Select
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la longitud maxima de los controles de entrada de texto
    Public Sub EstablecerPropiedades()
        Try
            txtNombre.MaxLength = StbTienda.GetMaxLength("Nombre")
            txtCodigo.MaxLength = StbTienda.GetMaxLength("Codigo")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar Bodega"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub GuardarTienda()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearBodega(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de guardar los datos de una tienda
    Public Sub CrearBodega(ByVal T As DAL.TransactionManager)
        Dim objBodega As StbBodegas
        Try
            objBodega = New StbBodegas
            BodegaID = StbBodegas.RetrieveDT(, , "ISNULL(MAX(StbBodegaID),0)+1 AS ID").DefaultView.Item(0)("ID")
            objBodega.StbBodegaID = BodegaID
            objBodega.Nombre = txtNombre.Text.Trim
            objBodega.Codigo = txtCodigo.Text.Trim
            objBodega.objCiudadID = cmbCiudad.SelectedValue
            objBodega.objJefeBodegaID = cmbJefe.SelectedValue
            objBodega.Activo = chkActivo.Checked

            objBodega.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objBodega.FechaCreacion = fechaServidor
            objBodega.Insert(T)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Bodega"

    '' Descripción:        Procedimiento encargado de actualizar tienda
    Public Sub ActualizarTienda()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosBodega(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de modificar los datos de una tienda
    Public Sub ModificarDatosBodega(ByVal T As DAL.TransactionManager)
        Dim objBodega As StbBodegas
        Try
            objBodega = New StbBodegas
            objBodega.StbBodegaID = BodegaID
            objBodega.Nombre = txtNombre.Text.Trim
            objBodega.Codigo = txtCodigo.Text.Trim
            objBodega.objCiudadID = cmbCiudad.SelectedValue
            objBodega.objJefeBodegaID = cmbJefe.SelectedValue
            objBodega.Activo = chkActivo.Checked

            objBodega.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objBodega.FechaCreacion = fechaServidor
            objBodega.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objBodega.FechaModificacion = fechaServidor
            objBodega.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objBodega = Nothing
        End Try
    End Sub

#End Region

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        If txtNombre.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtNombre, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If txtCodigo.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtCodigo, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If cmbCiudad.Text.Trim.Length = 0 Then
            ErrorProv.SetError(cmbCiudad, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If cmbJefe.Text.Trim = "" Then
            ErrorProv.SetError(cmbJefe, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        Return True
    End Function
#End Region

#End Region

#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCiudad()
        CargarJefe()
        EstablecerPropiedades()
        ConfigurarGUI()
        txtNombre.Focus()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarTienda()
                Case 2
                    ActualizarTienda()
            End Select
        End If
    End Sub

#End Region

#Region "KeyPress controles"

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ErrorProv.Clear()
        boolEditado = True
    End Sub

    Private Sub cmdJefe_Click(sender As Object, e As EventArgs) Handles cmdJefe.Click
        Try
            If cmbJefe.SelectedText = "" Then
                Me.NuevoJefe()
            Else
                Me.ConsultarJefe()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbCiudad_Change(sender As Object, e As EventArgs)
        ErrorProv.SetError(cmbCiudad, "")
        boolEditado = True
    End Sub

    Private Sub cmbJefe_Change(sender As Object, e As EventArgs)
        ErrorProv.SetError(cmbJefe, "")
        boolEditado = True
    End Sub

    Private Sub frmBodegasEditar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtNombre.Text.Trim.Length <> 0 Then
                Me.txtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtCodigo.Text.Trim.Length <> 0 Then
                Me.cmbCiudad.Focus()
            End If
        End If
    End Sub

    Private Sub cmbCiudad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbCiudad.Text.Trim.Length <> 0 Then
                Me.cmbJefe.Focus()
            End If
        End If
    End Sub

    Private Sub cmbJefe_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbJefe.Text.Trim.Length <> 0 Then
                Me.chkActivo.Focus()
            End If
        End If
    End Sub

    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
    End Sub


#End Region

End Class