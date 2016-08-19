<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivEntradaBodega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivEntradaBodega))
        Me.tbCuentas = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAnular = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer()
        Me.grdDetalleEntradaBodega = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.grdEntradaBodega = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbCuentas.SuspendLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        CType(Me.grdDetalleEntradaBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEntradaBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCuentas
        '
        Me.tbCuentas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdAnular, Me.cmdConsultar, Me.cmdBuscar, Me.cmdImprimir, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdSalir})
        Me.tbCuentas.Location = New System.Drawing.Point(0, 0)
        Me.tbCuentas.Name = "tbCuentas"
        Me.tbCuentas.Size = New System.Drawing.Size(863, 39)
        Me.tbCuentas.TabIndex = 0
        Me.tbCuentas.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Agregar Entrada Bodega"
        '
        'cmdAnular
        '
        Me.cmdAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnular.Image = CType(resources.GetObject("cmdAnular.Image"), System.Drawing.Image)
        Me.cmdAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnular.ToolTipText = "Anular Entrada Bodega"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Entrada Bodega"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.ToolTipText = "Buscar Entrada Bodega"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.ToolTipText = "Imprimir Entrada Bodega"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir de Formulario"
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.grdDetalleEntradaBodega)
        Me.C1Sizer1.Controls.Add(Me.grdEntradaBodega)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "72.8155339805825:False:False;24.2718446601942:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0730011587486:False" & _
    ":False;"
        Me.C1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 39)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(863, 412)
        Me.C1Sizer1.TabIndex = 1
        Me.C1Sizer1.TabStop = False
        '
        'grdDetalleEntradaBodega
        '
        Me.grdDetalleEntradaBodega.Caption = "Detalle Entradas"
        Me.grdDetalleEntradaBodega.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleEntradaBodega.Images.Add(CType(resources.GetObject("grdDetalleEntradaBodega.Images"), System.Drawing.Image))
        Me.grdDetalleEntradaBodega.Location = New System.Drawing.Point(4, 308)
        Me.grdDetalleEntradaBodega.Name = "grdDetalleEntradaBodega"
        Me.grdDetalleEntradaBodega.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleEntradaBodega.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleEntradaBodega.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDetalleEntradaBodega.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalleEntradaBodega.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalleEntradaBodega.Size = New System.Drawing.Size(855, 100)
        Me.grdDetalleEntradaBodega.TabIndex = 10
        Me.grdDetalleEntradaBodega.Text = "Expedientes-Facturas"
        Me.grdDetalleEntradaBodega.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdDetalleEntradaBodega.PropBag = resources.GetString("grdDetalleEntradaBodega.PropBag")
        '
        'grdEntradaBodega
        '
        Me.grdEntradaBodega.AllowUpdate = False
        Me.grdEntradaBodega.Caption = "Entradas Bodega"
        Me.grdEntradaBodega.ExtendRightColumn = True
        Me.grdEntradaBodega.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdEntradaBodega.Images.Add(CType(resources.GetObject("grdEntradaBodega.Images"), System.Drawing.Image))
        Me.grdEntradaBodega.Location = New System.Drawing.Point(4, 4)
        Me.grdEntradaBodega.Name = "grdEntradaBodega"
        Me.grdEntradaBodega.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdEntradaBodega.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdEntradaBodega.PreviewInfo.ZoomFactor = 75.0R
        Me.grdEntradaBodega.PrintInfo.PageSettings = CType(resources.GetObject("grdEntradaBodega.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdEntradaBodega.Size = New System.Drawing.Size(855, 300)
        Me.grdEntradaBodega.TabIndex = 9
        Me.grdEntradaBodega.Tag = "AGRUPAR"
        Me.grdEntradaBodega.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdEntradaBodega.PropBag = resources.GetString("grdEntradaBodega.PropBag")
        '
        'frmSivEntradaBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 451)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Controls.Add(Me.tbCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivEntradaBodega"
        Me.Text = "Entradas a Bodega Central"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbCuentas.ResumeLayout(False)
        Me.tbCuentas.PerformLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer1.ResumeLayout(False)
        CType(Me.grdDetalleEntradaBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEntradaBodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCuentas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1Sizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdEntradaBodega As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdDetalleEntradaBodega As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
End Class
