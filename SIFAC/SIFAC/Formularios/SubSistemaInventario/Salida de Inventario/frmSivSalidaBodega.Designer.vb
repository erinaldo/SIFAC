<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivSalidaBodega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivSalidaBodega))
        Me.brSalida = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmdAutorizar = New System.Windows.Forms.ToolStripButton
        Me.cmdCancelar = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdImprimirHojaSalida = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdListadoSalidaFiltrado = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdActualizar = New System.Windows.Forms.ToolStripButton
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer
        Me.grdSalidaDetalle = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.grdSalida = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.brSalida.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.grdSalidaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brSalida
        '
        Me.brSalida.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.brSalida.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdAutorizar, Me.cmdCancelar, Me.cmdConsultar, Me.cmdBuscar, Me.cmdImprimir, Me.cmdActualizar, Me.cmdSalir})
        Me.brSalida.Location = New System.Drawing.Point(0, 0)
        Me.brSalida.Name = "brSalida"
        Me.brSalida.Size = New System.Drawing.Size(719, 39)
        Me.brSalida.TabIndex = 10
        Me.brSalida.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Registro de Saldias"
        '
        'cmdAutorizar
        '
        Me.cmdAutorizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAutorizar.Image = CType(resources.GetObject("cmdAutorizar.Image"), System.Drawing.Image)
        Me.cmdAutorizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAutorizar.Name = "cmdAutorizar"
        Me.cmdAutorizar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAutorizar.ToolTipText = "Autorizar Salida"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(36, 36)
        Me.cmdCancelar.ToolTipText = "Anular Salida"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Salida"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.ToolTipText = "Buscar Salida"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdImprimirHojaSalida, Me.cmdListadoSalidaFiltrado})
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(45, 36)
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdImprimirHojaSalida
        '
        Me.cmdImprimirHojaSalida.Name = "cmdImprimirHojaSalida"
        Me.cmdImprimirHojaSalida.Size = New System.Drawing.Size(158, 22)
        Me.cmdImprimirHojaSalida.Text = "Hoja Salida"
        '
        'cmdListadoSalidaFiltrado
        '
        Me.cmdListadoSalidaFiltrado.Name = "cmdListadoSalidaFiltrado"
        Me.cmdListadoSalidaFiltrado.Size = New System.Drawing.Size(158, 22)
        Me.cmdListadoSalidaFiltrado.Text = "Listado Filtrado"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(36, 36)
        Me.cmdActualizar.ToolTipText = "Actualizar"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir"
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.grdSalidaDetalle)
        Me.Contenedor.Controls.Add(Me.grdSalida)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "48.8069414316703:True:False;48.590021691974:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "98.8873435326843:False:F" & _
            "alse;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(0, 39)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(719, 461)
        Me.Contenedor.TabIndex = 11
        Me.Contenedor.TabStop = False
        '
        'grdSalidaDetalle
        '
        Me.grdSalidaDetalle.AllowUpdate = False
        Me.grdSalidaDetalle.Caption = "Repuestos"
        Me.grdSalidaDetalle.ExtendRightColumn = True
        Me.grdSalidaDetalle.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdSalidaDetalle.Images.Add(CType(resources.GetObject("grdSalidaDetalle.Images"), System.Drawing.Image))
        Me.grdSalidaDetalle.Location = New System.Drawing.Point(4, 233)
        Me.grdSalidaDetalle.Name = "grdSalidaDetalle"
        Me.grdSalidaDetalle.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdSalidaDetalle.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdSalidaDetalle.PreviewInfo.ZoomFactor = 75
        Me.grdSalidaDetalle.PrintInfo.PageSettings = CType(resources.GetObject("grdSalidaDetalle.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdSalidaDetalle.Size = New System.Drawing.Size(711, 224)
        Me.grdSalidaDetalle.TabIndex = 1
        Me.grdSalidaDetalle.Text = "C1TrueDBGrid2"
        Me.grdSalidaDetalle.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdSalidaDetalle.PropBag = resources.GetString("grdSalidaDetalle.PropBag")
        '
        'grdSalida
        '
        Me.grdSalida.AllowUpdate = False
        Me.grdSalida.Caption = "Salidas"
        Me.grdSalida.ExtendRightColumn = True
        Me.grdSalida.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdSalida.Images.Add(CType(resources.GetObject("grdSalida.Images"), System.Drawing.Image))
        Me.grdSalida.Location = New System.Drawing.Point(4, 4)
        Me.grdSalida.Name = "grdSalida"
        Me.grdSalida.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdSalida.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdSalida.PreviewInfo.ZoomFactor = 75
        Me.grdSalida.PrintInfo.PageSettings = CType(resources.GetObject("grdSalida.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdSalida.Size = New System.Drawing.Size(711, 225)
        Me.grdSalida.TabIndex = 0
        Me.grdSalida.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdSalida.PropBag = resources.GetString("grdSalida.PropBag")
        '
        'frmSivSalidaBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 500)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.brSalida)
        Me.Name = "frmSivSalidaBodega"
        Me.Text = "Salida de Bodega"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.brSalida.ResumeLayout(False)
        Me.brSalida.PerformLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.grdSalidaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents brSalida As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAutorizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdSalidaDetalle As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdSalida As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdImprimirHojaSalida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdListadoSalidaFiltrado As System.Windows.Forms.ToolStripMenuItem
End Class
