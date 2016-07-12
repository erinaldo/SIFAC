<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaCotizacionDescuentoConsultar
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaCotizacionDescuentoConsultar))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.grdDescuentoCotizacion = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblAviso = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDescuentoCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(439, 32)
        Me.Panel2.TabIndex = 75
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(374, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'imgIconos
        '
        Me.imgIconos.ImageStream = CType(resources.GetObject("imgIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIconos.Images.SetKeyName(0, "Usuario.gif")
        Me.imgIconos.Images.SetKeyName(1, "Buscar.png")
        '
        'grdDescuentoCotizacion
        '
        Me.grdDescuentoCotizacion.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDescuentoCotizacion.Images.Add(CType(resources.GetObject("grdDescuentoCotizacion.Images"), System.Drawing.Image))
        Me.grdDescuentoCotizacion.Location = New System.Drawing.Point(0, 32)
        Me.grdDescuentoCotizacion.Name = "grdDescuentoCotizacion"
        Me.grdDescuentoCotizacion.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDescuentoCotizacion.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDescuentoCotizacion.PreviewInfo.ZoomFactor = 75
        Me.grdDescuentoCotizacion.PrintInfo.PageSettings = CType(resources.GetObject("grdDescuentoCotizacion.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDescuentoCotizacion.Size = New System.Drawing.Size(439, 225)
        Me.grdDescuentoCotizacion.TabIndex = 104
        Me.grdDescuentoCotizacion.PropBag = resources.GetString("grdDescuentoCotizacion.PropBag")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SCCUM.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 276)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 21)
        Me.Panel1.TabIndex = 105
        '
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.Location = New System.Drawing.Point(12, 260)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(243, 13)
        Me.lblAviso.TabIndex = 106
        Me.lblAviso.Text = "Doble click o ENTER para seleccionar descuento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "ESC = Salir"
        '
        'frmSfaCotizacionDescuentoConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 297)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdDescuentoCotizacion)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaCotizacionDescuentoConsultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Descuentos"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDescuentoCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents grdDescuentoCotizacion As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAviso As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
