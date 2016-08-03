<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaBusquedaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaBusquedaCliente))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grdCliente = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdNuevaPersona = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grdCliente)
        Me.Panel1.Location = New System.Drawing.Point(12, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 245)
        Me.Panel1.TabIndex = 0
        '
        'grdCliente
        '
        Me.grdCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCliente.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdCliente.Images.Add(CType(resources.GetObject("grdCliente.Images"), System.Drawing.Image))
        Me.grdCliente.Location = New System.Drawing.Point(0, 0)
        Me.grdCliente.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCliente.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCliente.PreviewInfo.ZoomFactor = 75
        Me.grdCliente.PrintInfo.PageSettings = CType(resources.GetObject("grdCliente.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCliente.Size = New System.Drawing.Size(551, 245)
        Me.grdCliente.TabIndex = 1
        Me.grdCliente.PropBag = resources.GetString("grdCliente.PropBag")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(575, 32)
        Me.Panel2.TabIndex = 6
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(504, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 334)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(575, 22)
        Me.Panel3.TabIndex = 7
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(488, 300)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 32
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(407, 300)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 31
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdNuevaPersona
        '
        Me.cmdNuevaPersona.Image = CType(resources.GetObject("cmdNuevaPersona.Image"), System.Drawing.Image)
        Me.cmdNuevaPersona.Location = New System.Drawing.Point(361, 297)
        Me.cmdNuevaPersona.Name = "cmdNuevaPersona"
        Me.cmdNuevaPersona.Size = New System.Drawing.Size(40, 35)
        Me.cmdNuevaPersona.TabIndex = 33
        Me.cmdNuevaPersona.UseVisualStyleBackColor = True
        '
        'frmSfaBusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 356)
        Me.Controls.Add(Me.cmdNuevaPersona)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaBusquedaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Cliente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdCliente As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevaPersona As System.Windows.Forms.Button
End Class
