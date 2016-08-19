Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSivCategoriasEditar

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intCategoriaID As Integer
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

    Property CategoriaID() As Integer
        Get
            Return intCategoriaID
        End Get
        Set(ByVal value As Integer)
            intCategoriaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Categoria"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False
                Case 1
                    Me.Text = "Editar Categoria"
                    CargarDatosCategoria()
                    chkActivo.Enabled = True
                Case 2
                    Me.Text = "Consultar Categoria"
                    CargarDatosCategoria()
                    txtNombre.Enabled = False
                    txtDescripcion.Enabled = False
                    chkActivo.Enabled = False
                    cmdGuardar.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una marca
    Public Sub CargarDatosCategoria()
        Dim objCategorias As SivCategorias
        Try
            objCategorias = New SivCategorias
            objCategorias.Retrieve(CategoriaID)
            txtNombre.Text = objCategorias.Nombre
            txtDescripcion.Text = objCategorias.Descripcion
            chkActivo.Checked = objCategorias.Activa
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objCategorias = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de marca
    Public Sub GuardarCategorisa()
        Dim objCategorias As SivCategorias
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objCategorias = New SivCategorias
            objCategorias.Nombre = txtNombre.Text.Trim
            objCategorias.Descripcion = txtDescripcion.Text.Trim
            objCategorias.Activa = chkActivo.Checked
            objCategorias.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objCategorias.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objCategorias.Insert()
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objCategorias = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de editar la informacion de una marca
    Public Sub EditarCategoria()
        Dim objCategorias As SivCategorias
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objCategorias = New SivCategorias
            objCategorias.CategoriaID = CategoriaID
            objCategorias.Nombre = txtNombre.Text.Trim
            objCategorias.Descripcion = txtDescripcion.Text.Trim
            objCategorias.Activa = chkActivo.Checked
            objCategorias.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objCategorias.UsuarioModificacion = clsProyecto.Conexion.Servidor
            objCategorias.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objCategorias.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objCategorias.Update()
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objCategorias = Nothing
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
        If txtDescripcion.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtDescripcion, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

#Region "Eventos del formulario"

    Private Sub frmSivCategoriasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        ConfigurarGUI()
        Me.boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub frmSivCategoriasEditar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub txtNombreMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtNombre.Text.Trim.Length <> 0 Then
                Me.chkActivo.Focus()
            End If
        End If
      
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ErrorProv.SetError(txtNombre, "")
        boolEditado = True
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtDescripcion.Text.Trim.Length <> 0 Then
                Me.cmdGuardar.Focus()
            End If
        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 0
                    GuardarCategorisa()
                Case 1
                    EditarCategoria()
            End Select

        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        ErrorProv.SetError(txtDescripcion, "")
        boolEditado = True
    End Sub

    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtDescripcion.Focus()
        End If
    End Sub
#End Region

    
  
  
End Class