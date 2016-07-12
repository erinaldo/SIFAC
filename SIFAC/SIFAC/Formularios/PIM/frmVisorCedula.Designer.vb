<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorCedula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisorCedula))
        Me.grbCedulaAnverso = New System.Windows.Forms.GroupBox
        Me.imgCedulaAnverso = New System.Windows.Forms.PictureBox
        Me.grbCedulaReverso = New System.Windows.Forms.GroupBox
        Me.imgCedulaReverso = New System.Windows.Forms.PictureBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grbCedulaAnverso.SuspendLayout()
        CType(Me.imgCedulaAnverso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCedulaReverso.SuspendLayout()
        CType(Me.imgCedulaReverso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbCedulaAnverso
        '
        Me.grbCedulaAnverso.Controls.Add(Me.imgCedulaAnverso)
        Me.grbCedulaAnverso.Location = New System.Drawing.Point(8, 33)
        Me.grbCedulaAnverso.Name = "grbCedulaAnverso"
        Me.grbCedulaAnverso.Size = New System.Drawing.Size(301, 184)
        Me.grbCedulaAnverso.TabIndex = 0
        Me.grbCedulaAnverso.TabStop = False
        Me.grbCedulaAnverso.Text = "Cédula Anverso"
        '
        'imgCedulaAnverso
        '
        Me.imgCedulaAnverso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgCedulaAnverso.Location = New System.Drawing.Point(3, 16)
        Me.imgCedulaAnverso.Name = "imgCedulaAnverso"
        Me.imgCedulaAnverso.Size = New System.Drawing.Size(295, 165)
        Me.imgCedulaAnverso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCedulaAnverso.TabIndex = 0
        Me.imgCedulaAnverso.TabStop = False
        '
        'grbCedulaReverso
        '
        Me.grbCedulaReverso.Controls.Add(Me.imgCedulaReverso)
        Me.grbCedulaReverso.Location = New System.Drawing.Point(8, 222)
        Me.grbCedulaReverso.Name = "grbCedulaReverso"
        Me.grbCedulaReverso.Size = New System.Drawing.Size(301, 184)
        Me.grbCedulaReverso.TabIndex = 1
        Me.grbCedulaReverso.TabStop = False
        Me.grbCedulaReverso.Text = "Cédula Reverso"
        '
        'imgCedulaReverso
        '
        Me.imgCedulaReverso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgCedulaReverso.Location = New System.Drawing.Point(3, 16)
        Me.imgCedulaReverso.Name = "imgCedulaReverso"
        Me.imgCedulaReverso.Size = New System.Drawing.Size(295, 165)
        Me.imgCedulaReverso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCedulaReverso.TabIndex = 0
        Me.imgCedulaReverso.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(238, 410)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 32)
        Me.Panel2.TabIndex = 27
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(242, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(663, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UM"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SCCUM.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 441)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 16)
        Me.Panel1.TabIndex = 26
        '
        'frmVisorCedula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 457)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grbCedulaReverso)
        Me.Controls.Add(Me.grbCedulaAnverso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVisorCedula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor Cédula"
        Me.grbCedulaAnverso.ResumeLayout(False)
        CType(Me.imgCedulaAnverso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCedulaReverso.ResumeLayout(False)
        CType(Me.imgCedulaReverso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbCedulaAnverso As System.Windows.Forms.GroupBox
    Friend WithEvents grbCedulaReverso As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents imgCedulaAnverso As System.Windows.Forms.PictureBox
    Friend WithEvents imgCedulaReverso As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
