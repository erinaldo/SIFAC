<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccTramiteLegal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccTramiteLegal))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip
        Me.cmdAgregarTramite = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultarTramite = New System.Windows.Forms.ToolStripButton
        Me.cmdAnularTramite = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.grdTramitesLegales = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdTramitesLegales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarTramite, Me.cmdConsultarTramite, Me.cmdAnularTramite, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(731, 39)
        Me.toolTramitesLegales.TabIndex = 2
        Me.toolTramitesLegales.Text = "ToolStrip1"
        '
        'cmdAgregarTramite
        '
        Me.cmdAgregarTramite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarTramite.Image = CType(resources.GetObject("cmdAgregarTramite.Image"), System.Drawing.Image)
        Me.cmdAgregarTramite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarTramite.Name = "cmdAgregarTramite"
        Me.cmdAgregarTramite.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregarTramite.Text = "Agregar trámite legal"
        '
        'cmdConsultarTramite
        '
        Me.cmdConsultarTramite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultarTramite.Image = CType(resources.GetObject("cmdConsultarTramite.Image"), System.Drawing.Image)
        Me.cmdConsultarTramite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultarTramite.Name = "cmdConsultarTramite"
        Me.cmdConsultarTramite.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultarTramite.Text = "Consultar trámite legal"
        '
        'cmdAnularTramite
        '
        Me.cmdAnularTramite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnularTramite.Image = CType(resources.GetObject("cmdAnularTramite.Image"), System.Drawing.Image)
        Me.cmdAnularTramite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnularTramite.Name = "cmdAnularTramite"
        Me.cmdAnularTramite.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnularTramite.Text = "Anular trámite legal"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = Global.SIFAC.My.Resources.Resources.Reporte_de_Facturas
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir Trámite"
        '
        'ToolSeparador1
        '
        Me.ToolSeparador1.Name = "ToolSeparador1"
        Me.ToolSeparador1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.tsbRefrescar.Text = "Refrescar Datos"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(36, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'grdTramitesLegales
        '
        Me.grdTramitesLegales.Caption = "Trámites Legales"
        Me.grdTramitesLegales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTramitesLegales.EmptyRows = True
        Me.grdTramitesLegales.ExtendRightColumn = True
        Me.grdTramitesLegales.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdTramitesLegales.Images.Add(CType(resources.GetObject("grdTramitesLegales.Images"), System.Drawing.Image))
        Me.grdTramitesLegales.Location = New System.Drawing.Point(0, 39)
        Me.grdTramitesLegales.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdTramitesLegales.Name = "grdTramitesLegales"
        Me.grdTramitesLegales.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTramitesLegales.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTramitesLegales.PreviewInfo.ZoomFactor = 75
        Me.grdTramitesLegales.PrintInfo.PageSettings = CType(resources.GetObject("grdTramitesLegales.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTramitesLegales.Size = New System.Drawing.Size(731, 513)
        Me.grdTramitesLegales.TabIndex = 3
        Me.grdTramitesLegales.Tag = "AGRUPAR"
        Me.grdTramitesLegales.Text = "Devoluciones"
        Me.grdTramitesLegales.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdTramitesLegales.PropBag = resources.GetString("grdTramitesLegales.PropBag")
        '
        'frmSccTramiteLegal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 552)
        Me.Controls.Add(Me.grdTramitesLegales)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Name = "frmSccTramiteLegal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Expedientes en Trámite Legal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdTramitesLegales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarTramite As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarTramite As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdTramitesLegales As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAnularTramite As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
End Class
