<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertaSolicitudDescuento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertaSolicitudDescuento))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.grdSolicitudes = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.toolServicios = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolServicios.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(694, 32)
        Me.Panel2.TabIndex = 95
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(629, -1)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 460)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 21)
        Me.Panel1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(614, 424)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(76, 30)
        Me.cmdCancelar.TabIndex = 98
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'grdSolicitudes
        '
        Me.grdSolicitudes.AllowUpdate = False
        Me.grdSolicitudes.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdSolicitudes.Images.Add(CType(resources.GetObject("grdSolicitudes.Images"), System.Drawing.Image))
        Me.grdSolicitudes.Location = New System.Drawing.Point(0, 66)
        Me.grdSolicitudes.Name = "grdSolicitudes"
        Me.grdSolicitudes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdSolicitudes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdSolicitudes.PreviewInfo.ZoomFactor = 75
        Me.grdSolicitudes.PrintInfo.PageSettings = CType(resources.GetObject("grdSolicitudes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdSolicitudes.Size = New System.Drawing.Size(690, 352)
        Me.grdSolicitudes.TabIndex = 99
        Me.grdSolicitudes.Text = "C1TrueDBGrid1"
        Me.grdSolicitudes.PropBag = resources.GetString("grdSolicitudes.PropBag")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 441)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Doble click para entrar a la factura / Orden Compra"
        '
        'toolServicios
        '
        Me.toolServicios.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolServicios.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolServicios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbRefrescar, Me.ToolStripSeparator2, Me.tsbSalir})
        Me.toolServicios.Location = New System.Drawing.Point(0, 32)
        Me.toolServicios.Name = "toolServicios"
        Me.toolServicios.Size = New System.Drawing.Size(694, 31)
        Me.toolServicios.TabIndex = 108
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(28, 28)
        Me.tsbRefrescar.Text = "Refrescar Datos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(28, 28)
        Me.tsbSalir.Text = "Salir"
        '
        'frmAlertaSolicitudDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 481)
        Me.Controls.Add(Me.toolServicios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdSolicitudes)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAlertaSolicitudDescuento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alertas a Gerencia"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolServicios.ResumeLayout(False)
        Me.toolServicios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents grdSolicitudes As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toolServicios As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
End Class
