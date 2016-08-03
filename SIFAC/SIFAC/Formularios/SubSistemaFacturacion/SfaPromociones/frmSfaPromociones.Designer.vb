<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaPromociones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaPromociones))
        Me.toolPromociones = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdImprimirSeleccion = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdImprimirFiltro = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.SzrPromociones = New C1.Win.C1Sizer.C1Sizer
        Me.grdPromocionesDetalle = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.grdPromociones = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.toolPromociones.SuspendLayout()
        CType(Me.SzrPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SzrPromociones.SuspendLayout()
        CType(Me.grdPromocionesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolPromociones
        '
        Me.toolPromociones.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolPromociones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdInactivar, Me.cmdConsultar, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolPromociones.Location = New System.Drawing.Point(0, 0)
        Me.toolPromociones.Name = "toolPromociones"
        Me.toolPromociones.Size = New System.Drawing.Size(820, 39)
        Me.toolPromociones.TabIndex = 5
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.Text = "Agregar "
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar"
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Inactivar"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdImprimirSeleccion, Me.cmdImprimirFiltro})
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(45, 36)
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdImprimirSeleccion
        '
        Me.cmdImprimirSeleccion.Name = "cmdImprimirSeleccion"
        Me.cmdImprimirSeleccion.Size = New System.Drawing.Size(147, 22)
        Me.cmdImprimirSeleccion.Text = "Seleccionada"
        '
        'cmdImprimirFiltro
        '
        Me.cmdImprimirFiltro.Name = "cmdImprimirFiltro"
        Me.cmdImprimirFiltro.Size = New System.Drawing.Size(147, 22)
        Me.cmdImprimirFiltro.Text = "Por Filtro"
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
        'SzrPromociones
        '
        Me.SzrPromociones.Controls.Add(Me.grdPromocionesDetalle)
        Me.SzrPromociones.Controls.Add(Me.grdPromociones)
        Me.SzrPromociones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SzrPromociones.GridDefinition = "61.8279569892473:True:False;36.0215053763441:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0243902439024:False:" & _
            "False;"
        Me.SzrPromociones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SzrPromociones.Location = New System.Drawing.Point(0, 39)
        Me.SzrPromociones.Name = "SzrPromociones"
        Me.SzrPromociones.Size = New System.Drawing.Size(820, 558)
        Me.SzrPromociones.TabIndex = 7
        Me.SzrPromociones.TabStop = False
        '
        'grdPromocionesDetalle
        '
        Me.grdPromocionesDetalle.AllowUpdate = False
        Me.grdPromocionesDetalle.Caption = "Detalle de promoción"
        Me.grdPromocionesDetalle.FilterBar = True
        Me.grdPromocionesDetalle.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdPromocionesDetalle.Images.Add(CType(resources.GetObject("grdPromocionesDetalle.Images"), System.Drawing.Image))
        Me.grdPromocionesDetalle.Location = New System.Drawing.Point(4, 353)
        Me.grdPromocionesDetalle.Name = "grdPromocionesDetalle"
        Me.grdPromocionesDetalle.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPromocionesDetalle.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPromocionesDetalle.PreviewInfo.ZoomFactor = 75
        Me.grdPromocionesDetalle.PrintInfo.PageSettings = CType(resources.GetObject("grdPromocionesDetalle.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPromocionesDetalle.Size = New System.Drawing.Size(812, 201)
        Me.grdPromocionesDetalle.TabIndex = 10
        Me.grdPromocionesDetalle.Text = "C1TrueDBGrid1"
        Me.grdPromocionesDetalle.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdPromocionesDetalle.PropBag = resources.GetString("grdPromocionesDetalle.PropBag")
        '
        'grdPromociones
        '
        Me.grdPromociones.AllowUpdate = False
        Me.grdPromociones.Caption = "Promociones"
        Me.grdPromociones.FilterBar = True
        Me.grdPromociones.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdPromociones.Images.Add(CType(resources.GetObject("grdPromociones.Images"), System.Drawing.Image))
        Me.grdPromociones.Location = New System.Drawing.Point(4, 4)
        Me.grdPromociones.Name = "grdPromociones"
        Me.grdPromociones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPromociones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPromociones.PreviewInfo.ZoomFactor = 75
        Me.grdPromociones.PrintInfo.PageSettings = CType(resources.GetObject("grdPromociones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPromociones.Size = New System.Drawing.Size(812, 345)
        Me.grdPromociones.TabIndex = 9
        Me.grdPromociones.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdPromociones.PropBag = resources.GetString("grdPromociones.PropBag")
        '
        'frmSfaPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 597)
        Me.Controls.Add(Me.SzrPromociones)
        Me.Controls.Add(Me.toolPromociones)
        Me.Name = "frmSfaPromociones"
        Me.Text = "Promociones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolPromociones.ResumeLayout(False)
        Me.toolPromociones.PerformLayout()
        CType(Me.SzrPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SzrPromociones.ResumeLayout(False)
        CType(Me.grdPromocionesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolPromociones As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdInactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdImprimirSeleccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdImprimirFiltro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents SzrPromociones As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdPromociones As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdPromocionesDetalle As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
