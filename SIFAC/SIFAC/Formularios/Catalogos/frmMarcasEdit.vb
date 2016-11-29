Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO


Public Class frmMarcasEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intMarcaID As Integer
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

    Property MarcaID() As Integer
        Get
            Return intMarcaID
        End Get
        Set(ByVal value As Integer)
            intMarcaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try

            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Marca"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False

                Case 1
                    Me.Text = "Editar Marca"
                    CargarDatosMarca()
                    chkActivo.Enabled = True

                Case 2
                    Me.Text = "Consultar Marca"
                    CargarDatosMarca()
                    txtNombreMarca.Enabled = False
                    txtDescripcion.Enabled = False
                    chkActivo.Enabled = False
                    cmdGuardar.Enabled = False

            End Select
            txtNombreMarca.Focus()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una marca
    Public Sub CargarDatosMarca()
        Dim objMarcas As SivMarcas
        Try
            objMarcas = New SivMarcas
            objMarcas.Retrieve(MarcaID)
            txtNombreMarca.Text = objMarcas.Nombre
            txtDescripcion.Text = objMarcas.Descripcion
            chkActivo.Checked = objMarcas.Activa
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objMarcas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de marca
    Public Sub GuardarMarcas()
        Dim objMarcas As SivMarcas
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objMarcas = New SivMarcas
            objMarcas.Nombre = txtNombreMarca.Text.Trim
            objMarcas.Descripcion = txtDescripcion.Text.Trim
            objMarcas.Activa = chkActivo.Checked
            objMarcas.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objMarcas.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objMarcas.Insert()
            MarcaID = objMarcas.MarcaID
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objMarcas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de editar la informacion de una marca
    Public Sub EditarMarca()
        Dim objMarcas As SivMarcas
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objMarcas = New SivMarcas
            objMarcas.MarcaID = MarcaID
            objMarcas.Nombre = txtNombreMarca.Text.Trim
            objMarcas.Descripcion = txtDescripcion.Text.Trim
            objMarcas.Activa = chkActivo.Checked
            objMarcas.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objMarcas.UsuarioModificacion = clsProyecto.Conexion.Servidor
            objMarcas.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objMarcas.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objMarcas.Update()
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objMarcas = Nothing
        End Try
    End Sub

#End Region

#Region "Funciones"

    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        If txtNombreMarca.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtNombreMarca, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        'If txtDescripcion.Text.Trim.Length = 0 Then
        '    ErrorProv.SetError(txtDescripcion, My.Resources.MsgObligatorio)
        '    Return False
        '    Exit Function
        'End If

        Return True
    End Function
#End Region

#Region "Eventos del formulario"


    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 0
                    GuardarMarcas()
                Case 1
                    EditarMarca()
            End Select

        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub frmMarcasEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
        Me.boolEditado = False
    End Sub

    Private Sub frmMarcasEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub txtNombreMarca_TextChanged(sender As Object, e As EventArgs) Handles txtNombreMarca.TextChanged
        ErrorProv.SetError(txtNombreMarca, "")
        boolEditado = True
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        ErrorProv.SetError(txtDescripcion, "")
        boolEditado = True
    End Sub
    Private Sub txtNombreMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreMarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtNombreMarca.Text.Trim.Length <> 0 Then
                Me.txtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtDescripcion.Text.Trim.Length <> 0 Then
                Me.cmdGuardar.Focus()
            End If

        End If

    End Sub

#End Region

   
   
End Class