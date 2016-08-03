<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivProveedor))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip
        Me.cmdAgregarProveedor = New System.Windows.Forms.ToolStripButton
        Me.cmdEditarProveedor = New System.Windows.Forms.ToolStripButton
        Me.cmdAnularProveedor = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultarProveedor = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.grdProveedores = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarProveedor, Me.cmdEditarProveedor, Me.cmdAnularProveedor, Me.cmdConsultarProveedor, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(731, 39)
        Me.toolTramitesLegales.TabIndex = 2
        Me.toolTramitesLegales.Text = "ToolStrip1"
        '
        'cmdAgregarProveedor
        '
        Me.cmdAgregarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarProveedor.Image = CType(resources.GetObject("cmdAgregarProveedor.Image"), System.Drawing.Image)
        Me.cmdAgregarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarProveedor.Name = "cmdAgregarProveedor"
        Me.cmdAgregarProveedor.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregarProveedor.Text = "Agregar Proveedor"
        '
        'cmdEditarProveedor
        '
        Me.cmdEditarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditarProveedor.Image = CType(resources.GetObject("cmdEditarProveedor.Image"), System.Drawing.Image)
        Me.cmdEditarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditarProveedor.Name = "cmdEditarProveedor"
        Me.cmdEditarProveedor.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditarProveedor.Text = "Editar Proveedor"
        '
        'cmdAnularProveedor
        '
        Me.cmdAnularProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnularProveedor.Image = CType(resources.GetObject("cmdAnularProveedor.Image"), System.Drawing.Image)
        Me.cmdAnularProveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnularProveedor.Name = "cmdAnularProveedor"
        Me.cmdAnularProveedor.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnularProveedor.Text = "Anular Proveedor"
        Me.cmdAnularProveedor.Visible = False
        '
        'cmdConsultarProveedor
        '
        Me.cmdConsultarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultarProveedor.Image = CType(resources.GetObject("cmdConsultarProveedor.Image"), System.Drawing.Image)
        Me.cmdConsultarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultarProveedor.Name = "cmdConsultarProveedor"
        Me.cmdConsultarProveedor.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultarProveedor.Text = "Consultar Proveedor"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir Proveedor"
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
        'grdProveedores
        '
        Me.grdProveedores.Caption = "Proveedores"
        Me.grdProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProveedores.EmptyRows = True
        Me.grdProveedores.ExtendRightColumn = True
        Me.grdProveedores.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdProveedores.Images.Add(CType(resources.GetObject("grdProveedores.Images"), System.Drawing.Image))
        Me.grdProveedores.Location = New System.Drawing.Point(0, 39)
        Me.grdProveedores.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdProveedores.Name = "grdProveedores"
        Me.grdProveedores.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdProveedores.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdProveedores.PreviewInfo.ZoomFactor = 75
        Me.grdProveedores.PrintInfo.PageSettings = CType(resources.GetObject("grdProveedores.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdProveedores.Size = New System.Drawing.Size(731, 513)
        Me.grdProveedores.TabIndex = 3
        Me.grdProveedores.Tag = "AGRUPAR"
        Me.grdProveedores.Text = "Devoluciones"
        Me.grdProveedores.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdProveedores.PropBag = resources.GetString("grdProveedores.PropBag")
        '
        'frmSivProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 552)
        Me.Controls.Add(Me.grdProveedores)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Name = "frmSivProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarProveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarProveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdProveedores As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAnularProveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditarProveedor As System.Windows.Forms.ToolStripButton
End Class
