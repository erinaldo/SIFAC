<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonaSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonaSelector))
        Me.pnlBotones = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdNuevaPersona = New System.Windows.Forms.Button
        Me.grdPersonas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlBotones.SuspendLayout()
        CType(Me.grdPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.cmdCancelar)
        Me.pnlBotones.Controls.Add(Me.cmdAceptar)
        Me.pnlBotones.Controls.Add(Me.cmdNuevaPersona)
        Me.pnlBotones.Location = New System.Drawing.Point(0, 310)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(502, 49)
        Me.pnlBotones.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(415, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 35)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(334, 9)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 35)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdNuevaPersona
        '
        Me.cmdNuevaPersona.Image = CType(resources.GetObject("cmdNuevaPersona.Image"), System.Drawing.Image)
        Me.cmdNuevaPersona.Location = New System.Drawing.Point(288, 9)
        Me.cmdNuevaPersona.Name = "cmdNuevaPersona"
        Me.cmdNuevaPersona.Size = New System.Drawing.Size(40, 35)
        Me.cmdNuevaPersona.TabIndex = 0
        Me.cmdNuevaPersona.UseVisualStyleBackColor = True
        '
        'grdPersonas
        '
        Me.grdPersonas.ExtendRightColumn = True
        Me.grdPersonas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdPersonas.Images.Add(CType(resources.GetObject("grdPersonas.Images"), System.Drawing.Image))
        Me.grdPersonas.Location = New System.Drawing.Point(3, 34)
        Me.grdPersonas.Name = "grdPersonas"
        Me.grdPersonas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPersonas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPersonas.PreviewInfo.ZoomFactor = 75
        Me.grdPersonas.PrintInfo.PageSettings = CType(resources.GetObject("grdPersonas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPersonas.Size = New System.Drawing.Size(498, 274)
        Me.grdPersonas.TabIndex = 1
        Me.grdPersonas.Text = "grdSeleccionPersona"
        Me.grdPersonas.PropBag = resources.GetString("grdPersonas.PropBag")
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
        Me.Panel2.Size = New System.Drawing.Size(502, 32)
        Me.Panel2.TabIndex = 27
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(430, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 28)
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
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 359)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 16)
        Me.Panel1.TabIndex = 26
        '
        'frmPersonaSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 375)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdPersonas)
        Me.Controls.Add(Me.pnlBotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonaSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de Personas"
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.grdPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents grdPersonas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevaPersona As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
