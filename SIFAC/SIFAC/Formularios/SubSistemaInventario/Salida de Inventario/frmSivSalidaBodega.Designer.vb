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
        Me.brSalida = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAutorizar = New System.Windows.Forms.ToolStripButton()
        Me.cmdCancelar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.cmdImprimirHojaSalida = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdListadoSalidaFiltrado = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdActualizar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        Me.grdSalidaMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdSalidaMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBodega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoSalida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalMaestro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.grdSalidaDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdSalidaDetalleTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIDEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.brSalida.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.grdSalidaMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSalidaMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSalidaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSalidaDetalleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brSalida
        '
        Me.brSalida.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.brSalida.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdAutorizar, Me.cmdCancelar, Me.cmdConsultar, Me.cmdBuscar, Me.cmdImprimir, Me.cmdActualizar, Me.cmdSalir})
        Me.brSalida.Location = New System.Drawing.Point(0, 0)
        Me.brSalida.Name = "brSalida"
        Me.brSalida.Size = New System.Drawing.Size(963, 39)
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
        Me.cmdImprimirHojaSalida.Size = New System.Drawing.Size(155, 22)
        Me.cmdImprimirHojaSalida.Text = "Hoja Salida"
        '
        'cmdListadoSalidaFiltrado
        '
        Me.cmdListadoSalidaFiltrado.Name = "cmdListadoSalidaFiltrado"
        Me.cmdListadoSalidaFiltrado.Size = New System.Drawing.Size(155, 22)
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
        Me.Contenedor.Controls.Add(Me.grdSalidaMaster)
        Me.Contenedor.Controls.Add(Me.grdSalidaDetalle)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "48.8069414316703:True:False;48.590021691974:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.1692627206646:False:F" & _
    "alse;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(0, 39)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(963, 461)
        Me.Contenedor.TabIndex = 11
        Me.Contenedor.TabStop = False
        '
        'grdSalidaMaster
        '
        Me.grdSalidaMaster.Location = New System.Drawing.Point(4, 4)
        Me.grdSalidaMaster.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdSalidaMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdSalidaMaster.MainView = Me.grdSalidaMasterTabla
        Me.grdSalidaMaster.Name = "grdSalidaMaster"
        Me.grdSalidaMaster.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemCheckEdit1})
        Me.grdSalidaMaster.Size = New System.Drawing.Size(955, 225)
        Me.grdSalidaMaster.TabIndex = 8
        Me.grdSalidaMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdSalidaMasterTabla})
        '
        'grdSalidaMasterTabla
        '
        Me.grdSalidaMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colBodega, Me.colTipoSalida, Me.colTotalMaestro, Me.ColIDEstado})
        Me.grdSalidaMasterTabla.GridControl = Me.grdSalidaMaster
        Me.grdSalidaMasterTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdSalidaMasterTabla.Name = "grdSalidaMasterTabla"
        Me.grdSalidaMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdSalidaMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdSalidaMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdSalidaMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdSalidaMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdSalidaMasterTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdSalidaMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 0
        Me.colNumero.Width = 130
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "FechaSalida"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 133
        '
        'colBodega
        '
        Me.colBodega.Caption = "Bodega"
        Me.colBodega.FieldName = "Bodega"
        Me.colBodega.Name = "colBodega"
        Me.colBodega.OptionsColumn.AllowFocus = False
        Me.colBodega.OptionsColumn.ReadOnly = True
        Me.colBodega.Visible = True
        Me.colBodega.VisibleIndex = 2
        Me.colBodega.Width = 209
        '
        'colTipoSalida
        '
        Me.colTipoSalida.Caption = "Tipo Salida"
        Me.colTipoSalida.FieldName = "TipoSalida"
        Me.colTipoSalida.Name = "colTipoSalida"
        Me.colTipoSalida.OptionsColumn.AllowFocus = False
        Me.colTipoSalida.OptionsColumn.ReadOnly = True
        Me.colTipoSalida.Visible = True
        Me.colTipoSalida.VisibleIndex = 3
        Me.colTipoSalida.Width = 190
        '
        'colTotalMaestro
        '
        Me.colTotalMaestro.Caption = "Total"
        Me.colTotalMaestro.FieldName = "Total"
        Me.colTotalMaestro.Name = "colTotalMaestro"
        Me.colTotalMaestro.OptionsColumn.AllowFocus = False
        Me.colTotalMaestro.OptionsColumn.ReadOnly = True
        Me.colTotalMaestro.Visible = True
        Me.colTotalMaestro.VisibleIndex = 4
        Me.colTotalMaestro.Width = 146
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'grdSalidaDetalle
        '
        Me.grdSalidaDetalle.Location = New System.Drawing.Point(4, 233)
        Me.grdSalidaDetalle.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdSalidaDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdSalidaDetalle.MainView = Me.grdSalidaDetalleTable
        Me.grdSalidaDetalle.Name = "grdSalidaDetalle"
        Me.grdSalidaDetalle.Size = New System.Drawing.Size(955, 224)
        Me.grdSalidaDetalle.TabIndex = 7
        Me.grdSalidaDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdSalidaDetalleTable})
        '
        'grdSalidaDetalleTable
        '
        Me.grdSalidaDetalleTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colCosto, Me.colSubTotal})
        Me.grdSalidaDetalleTable.GridControl = Me.grdSalidaDetalle
        Me.grdSalidaDetalleTable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdSalidaDetalleTable.Name = "grdSalidaDetalleTable"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.OptionsColumn.AllowFocus = False
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Producto"
        Me.colDescripcion.FieldName = "Producto"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        '
        'colCosto
        '
        Me.colCosto.Caption = "Costo"
        Me.colCosto.FieldName = "costo"
        Me.colCosto.Name = "colCosto"
        Me.colCosto.OptionsColumn.AllowEdit = False
        Me.colCosto.OptionsColumn.AllowFocus = False
        Me.colCosto.OptionsColumn.ReadOnly = True
        Me.colCosto.Visible = True
        Me.colCosto.VisibleIndex = 3
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "Sub Total"
        Me.colSubTotal.FieldName = "subtotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 4
        '
        'ColIDEstado
        '
        Me.ColIDEstado.Caption = "Estado"
        Me.ColIDEstado.FieldName = "Estado"
        Me.ColIDEstado.Name = "ColIDEstado"
        Me.ColIDEstado.Visible = True
        Me.ColIDEstado.VisibleIndex = 5
        Me.ColIDEstado.Width = 129
        '
        'frmSivSalidaBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 500)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.brSalida)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivSalidaBodega"
        Me.Text = "Salida de Bodega"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.brSalida.ResumeLayout(False)
        Me.brSalida.PerformLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.grdSalidaMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSalidaMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSalidaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSalidaDetalleTable, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdImprimirHojaSalida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdListadoSalidaFiltrado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdSalidaMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdSalidaMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoSalida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalMaestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIDEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents grdSalidaDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdSalidaDetalleTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
End Class
