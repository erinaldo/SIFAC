<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbMantTasaCambioOficial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbMantTasaCambioOficial))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbRegistrarTCO = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbConfirmarTCO = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.grdTCO = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdTCO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRegistrarTCO, Me.ToolStripSeparator1, Me.tsbConfirmarTCO, Me.ToolStripSeparator2, Me.tsbImprimir, Me.tsbRefrescar, Me.ToolStripSeparator3, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(682, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbRegistrarTCO
        '
        Me.tsbRegistrarTCO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRegistrarTCO.Enabled = False
        Me.tsbRegistrarTCO.Image = CType(resources.GetObject("tsbRegistrarTCO.Image"), System.Drawing.Image)
        Me.tsbRegistrarTCO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRegistrarTCO.Name = "tsbRegistrarTCO"
        Me.tsbRegistrarTCO.Size = New System.Drawing.Size(23, 22)
        Me.tsbRegistrarTCO.Text = "Registrar Tasa de Cambio Oficial"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbConfirmarTCO
        '
        Me.tsbConfirmarTCO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbConfirmarTCO.Enabled = False
        Me.tsbConfirmarTCO.Image = CType(resources.GetObject("tsbConfirmarTCO.Image"), System.Drawing.Image)
        Me.tsbConfirmarTCO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConfirmarTCO.Name = "tsbConfirmarTCO"
        Me.tsbConfirmarTCO.Size = New System.Drawing.Size(23, 22)
        Me.tsbConfirmarTCO.Text = "Confirmar Tasa de Cambio Oficial"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbImprimir
        '
        Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbImprimir.Text = "Imprimir"
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(23, 22)
        Me.tsbRefrescar.Text = "Refrescar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir"
        '
        'grdTCO
        '
        Me.grdTCO.AllowUpdate = False
        Me.grdTCO.Caption = "Tasa de Cambio Oficial"
        Me.grdTCO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTCO.EmptyRows = True
        Me.grdTCO.ExtendRightColumn = True
        Me.grdTCO.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdTCO.Images.Add(CType(resources.GetObject("grdTCO.Images"), System.Drawing.Image))
        Me.grdTCO.Location = New System.Drawing.Point(0, 25)
        Me.grdTCO.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdTCO.Name = "grdTCO"
        Me.grdTCO.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTCO.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTCO.PreviewInfo.ZoomFactor = 75
        Me.grdTCO.PrintInfo.PageSettings = CType(resources.GetObject("grdTCO.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTCO.Size = New System.Drawing.Size(682, 368)
        Me.grdTCO.TabIndex = 2
        Me.grdTCO.Tag = "AGRUPAR"
        Me.grdTCO.Text = "Tasa de Cambio Oficial"
        Me.grdTCO.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdTCO.PropBag = resources.GetString("grdTCO.PropBag")
        '
        'frmStbMantTasaCambioOficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 393)
        Me.Controls.Add(Me.grdTCO)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmStbMantTasaCambioOficial"
        Me.Tag = "CATALOGOS"
        Me.Text = "Mantenimiento de Tasas de Cambio Oficial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdTCO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbRegistrarTCO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbConfirmarTCO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdTCO As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
