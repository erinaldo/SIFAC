Imports Seguridad.Datos
Imports Proyecto.Configuracion
Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

#Region "Declaracion de variables y  objetos globales al formulario"
    Dim objSeg As Seguridad.Datos.SsgSeguridad
    Dim Oportunidades As Short = 3
    Private m_EstaVigente As Boolean
    Private m_Activa As Boolean

    Public Property EstaVigente() As Boolean
        Get
            Return m_EstaVigente
        End Get
        Set(ByVal value As Boolean)
            m_EstaVigente = value
        End Set
    End Property
    Public Property Activa() As Boolean
        Get
            Return m_Activa
        End Get
        Set(ByVal value As Boolean)
            m_Activa = value
        End Set
    End Property

#End Region

#Region "Eventos del formulario"

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.txtNombreSistema.Text = clsProyecto.SiglasSistema
    End Sub
#End Region

#Region "Comandos ok/Cancel"

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim blnOk As Boolean = True
        Try
            '--- Validar que exista datos para el login y la clave
            If String.IsNullOrEmpty(Me.UsernameTextBox.Text.Trim) Then
                Me.ErrorProvider1.SetError(Me.UsernameTextBox, "Debe introducir el usuario.")
                blnOk = False
            End If
            If String.IsNullOrEmpty(Me.PasswordTextBox.Text.Trim) Then
                Me.ErrorProvider1.SetError(Me.PasswordTextBox, "Debe introducir la clave.")
                blnOk = False
            End If

            If blnOk And Oportunidades > 0 Then
                Autenticar()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "Metodos de Autenticación"

    '--------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementación:    11 de Septiembre del 2007
    '-- Descripcion:                Invoca la función autenticar de la clase
    '--                             seguridad, esta se encargar de verificar 
    '--                             que los datos del usuario son correctos
    '--------------------------------------------------------------------------
    Private Sub Autenticar()
        Dim objCuenta As SsgCuenta
        Try
            objSeg = New SsgSeguridad
            objCuenta = New SsgCuenta

            If objSeg.Autenticar(Me.UsernameTextBox.Text.Trim, Me.PasswordTextBox.Text.Trim) Then
                objCuenta.RetrieveByFilter("upper(Login) = '" & UCase(Me.UsernameTextBox.Text.Trim) & "'")
                clsProyecto.Conexion.Usuario = UCase(Me.UsernameTextBox.Text)
                Me.EstaVigente = objSeg.EstaVigente
                Me.Activa = objCuenta.Activo
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Oportunidades -= 1
                If Oportunidades = 0 Then
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
        End Try
    End Sub

    Private Function validarVigencia() As Boolean
        Try

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Eventos de los controles de captura de datos"

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged
        Try
            If (String.IsNullOrEmpty(PasswordTextBox.Text.Trim)) Then
                Me.ErrorProvider1.SetError(PasswordTextBox, "Debe introducir la clave.")
                Me.cmdOK.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdOK.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        Try
            If (String.IsNullOrEmpty(UsernameTextBox.Text.Trim)) Then
                Me.ErrorProvider1.SetError(UsernameTextBox, "Debe introducir el usuario.")
                Me.cmdOK.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdOK.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub mnuAppConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAppConfig.Click
        Dim objConfig As New FrmConfig
        objConfig.ShowDialog()
        If objConfig.BoolReinit Then
            Me.Close()
            System.Windows.Forms.Application.Restart()
        End If
    End Sub


    Private Sub UsernameTextBox_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.UsernameTextBox.Text.Trim.Length <> 0 Then
                Me.PasswordTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.PasswordTextBox.Text.Trim.Length <> 0 Then
                Me.cmdOK.Focus()
            End If
        End If
    End Sub
End Class
