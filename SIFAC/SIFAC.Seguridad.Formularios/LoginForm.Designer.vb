<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.UsernameTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdOK = New C1.Win.C1Input.C1Button
        Me.cmdCancel = New C1.Win.C1Input.C1Button
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.PanelSuperior = New System.Windows.Forms.Panel
        Me.txtNombreSistema = New System.Windows.Forms.Label
        Me.PanelInferior = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuAppConfig = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 35)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(145, 133)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(182, 35)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(160, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(185, 59)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(141, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(185, 107)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(142, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(185, 145)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(65, 23)
        Me.cmdOK.TabIndex = 6
        Me.cmdOK.Text = "&Aceptar"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(258, 145)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(68, 23)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(182, 84)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(160, 23)
        Me.PasswordLabel.TabIndex = 8
        Me.PasswordLabel.Text = "&Clave"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelSuperior.Controls.Add(Me.txtNombreSistema)
        Me.PanelSuperior.Location = New System.Drawing.Point(185, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(155, 19)
        Me.PanelSuperior.TabIndex = 9
        '
        'txtNombreSistema
        '
        Me.txtNombreSistema.AutoSize = True
        Me.txtNombreSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreSistema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreSistema.Location = New System.Drawing.Point(53, 3)
        Me.txtNombreSistema.Name = "txtNombreSistema"
        Me.txtNombreSistema.Size = New System.Drawing.Size(42, 13)
        Me.txtNombreSistema.TabIndex = 0
        Me.txtNombreSistema.Text = "SIFAC"
        '
        'PanelInferior
        '
        Me.PanelInferior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelInferior.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelInferior.Controls.Add(Me.Label1)
        Me.PanelInferior.Location = New System.Drawing.Point(0, 187)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(185, 18)
        Me.PanelInferior.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comercializadora Meza"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Location = New System.Drawing.Point(-1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 187)
        Me.Panel3.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel4.Location = New System.Drawing.Point(339, 19)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 183)
        Me.Panel4.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Location = New System.Drawing.Point(185, 188)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(155, 1)
        Me.Panel5.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel6.Location = New System.Drawing.Point(1, 18)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(186, 1)
        Me.Panel6.TabIndex = 16
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAppConfig})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(340, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'mnuAppConfig
        '
        Me.mnuAppConfig.Name = "mnuAppConfig"
        Me.mnuAppConfig.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuAppConfig.Size = New System.Drawing.Size(77, 20)
        Me.mnuAppConfig.Text = "AppConfig"
        Me.mnuAppConfig.Visible = False
        '
        'LoginForm
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(340, 203)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Iniciar Sesi�n"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.PanelInferior.ResumeLayout(False)
        Me.PanelInferior.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PanelInferior As System.Windows.Forms.Panel
    Friend WithEvents PanelSuperior As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreSistema As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAppConfig As System.Windows.Forms.ToolStripMenuItem

End Class
