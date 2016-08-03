<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaDescuentoPromociones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaDescuentoPromociones))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gridDescuentos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 32)
        Me.Panel2.TabIndex = 94
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(571, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 11)
        Me.Panel1.TabIndex = 95
        '
        'gridDescuentos
        '
        Me.gridDescuentos.AllowUpdate = False
        Me.gridDescuentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDescuentos.GroupByCaption = "Drag a column header here to group by that column"
        Me.gridDescuentos.Images.Add(CType(resources.GetObject("gridDescuentos.Images"), System.Drawing.Image))
        Me.gridDescuentos.Location = New System.Drawing.Point(0, 32)
        Me.gridDescuentos.Name = "gridDescuentos"
        Me.gridDescuentos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gridDescuentos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gridDescuentos.PreviewInfo.ZoomFactor = 75
        Me.gridDescuentos.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gridDescuentos.Size = New System.Drawing.Size(636, 227)
        Me.gridDescuentos.TabIndex = 96
        Me.gridDescuentos.Text = "C1TrueDBGrid1"
        Me.gridDescuentos.PropBag = resources.GetString("gridDescuentos.PropBag")
        '
        'frmConsultaDescuentoPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 270)
        Me.Controls.Add(Me.gridDescuentos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaDescuentoPromociones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta de Descuentos"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gridDescuentos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
