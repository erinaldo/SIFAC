<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaDescuentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaDescuentos))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grdDescuentos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.grdDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grdDescuentos)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 141)
        Me.Panel1.TabIndex = 0
        '
        'grdDescuentos
        '
        Me.grdDescuentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDescuentos.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDescuentos.Images.Add(CType(resources.GetObject("grdDescuentos.Images"), System.Drawing.Image))
        Me.grdDescuentos.Location = New System.Drawing.Point(0, 0)
        Me.grdDescuentos.Name = "grdDescuentos"
        Me.grdDescuentos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDescuentos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDescuentos.PreviewInfo.ZoomFactor = 75
        Me.grdDescuentos.PrintInfo.PageSettings = CType(resources.GetObject("grdDescuentos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDescuentos.Size = New System.Drawing.Size(430, 141)
        Me.grdDescuentos.TabIndex = 0
        Me.grdDescuentos.Text = "C1TrueDBGrid1"
        Me.grdDescuentos.PropBag = resources.GetString("grdDescuentos.PropBag")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(383, -1)
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
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 32)
        Me.Panel2.TabIndex = 7
        Me.Panel2.Tag = "LAYOUT"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 213)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(455, 22)
        Me.Panel3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Doble clic sobre el descuento a seleccionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Esc = Salir"
        '
        'frmSfaDescuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 235)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaDescuentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Descuentos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdDescuentos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
