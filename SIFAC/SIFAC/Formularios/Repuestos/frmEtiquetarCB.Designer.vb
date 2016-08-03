<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiquetarCB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiquetarCB))
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.txtSivRepuestoCodigoBarras = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lblBarCode = New System.Windows.Forms.Label
        Me.chkPrefijo = New System.Windows.Forms.CheckBox
        Me.txtPrefijo = New System.Windows.Forms.TextBox
        Me.txtPostFijo = New System.Windows.Forms.TextBox
        Me.chkSuFijo = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(12, 39)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(249, 13)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "Se imprimirá el código de barras correspondiente al:"
        '
        'txtSivRepuestoCodigoBarras
        '
        Me.txtSivRepuestoCodigoBarras.Location = New System.Drawing.Point(72, 63)
        Me.txtSivRepuestoCodigoBarras.MaxLength = 20
        Me.txtSivRepuestoCodigoBarras.Name = "txtSivRepuestoCodigoBarras"
        Me.txtSivRepuestoCodigoBarras.Size = New System.Drawing.Size(299, 20)
        Me.txtSivRepuestoCodigoBarras.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 66)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "Código:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(349, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 32)
        Me.Panel2.TabIndex = 26
        Me.Panel2.Tag = "LAYOUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(663, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 251)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 21)
        Me.Panel1.TabIndex = 48
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(296, 218)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 30)
        Me.cmdCancelar.TabIndex = 50
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(215, 218)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 30)
        Me.cmdAceptar.TabIndex = 49
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'lblBarCode
        '
        Me.lblBarCode.AutoSize = True
        Me.lblBarCode.Location = New System.Drawing.Point(12, 100)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(31, 13)
        Me.lblBarCode.TabIndex = 2
        Me.lblBarCode.Text = "||||||||||||"
        '
        'chkPrefijo
        '
        Me.chkPrefijo.AutoSize = True
        Me.chkPrefijo.Location = New System.Drawing.Point(15, 149)
        Me.chkPrefijo.Name = "chkPrefijo"
        Me.chkPrefijo.Size = New System.Drawing.Size(86, 17)
        Me.chkPrefijo.TabIndex = 51
        Me.chkPrefijo.Text = "Incluir Prefijo"
        Me.chkPrefijo.UseVisualStyleBackColor = True
        '
        'txtPrefijo
        '
        Me.txtPrefijo.BackColor = System.Drawing.Color.White
        Me.txtPrefijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefijo.Location = New System.Drawing.Point(15, 172)
        Me.txtPrefijo.MaxLength = 10
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Size = New System.Drawing.Size(129, 21)
        Me.txtPrefijo.TabIndex = 1
        Me.txtPrefijo.Text = "*"
        '
        'txtPostFijo
        '
        Me.txtPostFijo.BackColor = System.Drawing.Color.White
        Me.txtPostFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostFijo.Location = New System.Drawing.Point(15, 218)
        Me.txtPostFijo.MaxLength = 10
        Me.txtPostFijo.Name = "txtPostFijo"
        Me.txtPostFijo.Size = New System.Drawing.Size(129, 21)
        Me.txtPostFijo.TabIndex = 1
        Me.txtPostFijo.Text = "*"
        '
        'chkSuFijo
        '
        Me.chkSuFijo.AutoSize = True
        Me.chkSuFijo.Location = New System.Drawing.Point(15, 195)
        Me.chkSuFijo.Name = "chkSuFijo"
        Me.chkSuFijo.Size = New System.Drawing.Size(86, 17)
        Me.chkSuFijo.TabIndex = 51
        Me.chkSuFijo.Text = "Incluir SuFijo"
        Me.chkSuFijo.UseVisualStyleBackColor = True
        '
        'frmEtiquetarCB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 272)
        Me.Controls.Add(Me.chkSuFijo)
        Me.Controls.Add(Me.chkPrefijo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblBarCode)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtPostFijo)
        Me.Controls.Add(Me.txtPrefijo)
        Me.Controls.Add(Me.txtSivRepuestoCodigoBarras)
        Me.Controls.Add(Me.lblMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEtiquetarCB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generar código de barras"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents txtSivRepuestoCodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblBarCode As System.Windows.Forms.Label
    Friend WithEvents chkPrefijo As System.Windows.Forms.CheckBox
    Friend WithEvents txtPrefijo As System.Windows.Forms.TextBox
    Friend WithEvents txtPostFijo As System.Windows.Forms.TextBox
    Friend WithEvents chkSuFijo As System.Windows.Forms.CheckBox
End Class
