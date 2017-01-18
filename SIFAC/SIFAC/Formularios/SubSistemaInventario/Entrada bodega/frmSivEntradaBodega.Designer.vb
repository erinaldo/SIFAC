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
        Me.grdEntradaMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdEntradaMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalMaestro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAnulada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colFechaFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.grdEntradaDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdEntradaDetalleTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbCuentas.SuspendLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        CType(Me.grdEntradaMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEntradaMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEntradaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEntradaDetalleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCuentas
        '
        Me.tbCuentas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdAnular, Me.cmdConsultar, Me.cmdBuscar, Me.cmdImprimir, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdSalir})
        Me.tbCuentas.Location = New System.Drawing.Point(0, 0)
        Me.tbCuentas.Name = "tbCuentas"
        Me.tbCuentas.Size = New System.Drawing.Size(1104, 39)
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
        Me.cmdImprimir.Visible = False
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
        Me.C1Sizer1.Controls.Add(Me.grdEntradaMaster)
        Me.C1Sizer1.Controls.Add(Me.grdEntradaDetalle)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "72.8155339805825:False:False;24.2718446601942:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.2753623188406:False" & _
    ":False;"
        Me.C1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 39)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(1104, 412)
        Me.C1Sizer1.TabIndex = 1
        Me.C1Sizer1.TabStop = False
        '
        'grdEntradaMaster
        '
        Me.grdEntradaMaster.Location = New System.Drawing.Point(4, 4)
        Me.grdEntradaMaster.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdEntradaMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEntradaMaster.MainView = Me.grdEntradaMasterTabla
        Me.grdEntradaMaster.Name = "grdEntradaMaster"
        Me.grdEntradaMaster.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemCheckEdit1})
        Me.grdEntradaMaster.Size = New System.Drawing.Size(1096, 300)
        Me.grdEntradaMaster.TabIndex = 6
        Me.grdEntradaMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEntradaMasterTabla})
        '
        'grdEntradaMasterTabla
        '
        Me.grdEntradaMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colTipoEntrada, Me.colFactura, Me.colTotalMaestro, Me.ColAnulada, Me.colFechaFactura})
        Me.grdEntradaMasterTabla.GridControl = Me.grdEntradaMaster
        Me.grdEntradaMasterTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdEntradaMasterTabla.Name = "grdEntradaMasterTabla"
        Me.grdEntradaMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdEntradaMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdEntradaMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdEntradaMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdEntradaMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdEntradaMasterTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdEntradaMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "NumeroEntrada"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 0
        Me.colNumero.Width = 118
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 121
        '
        'colTipoEntrada
        '
        Me.colTipoEntrada.Caption = "Tipo Entrada"
        Me.colTipoEntrada.FieldName = "TipoEntrada"
        Me.colTipoEntrada.Name = "colTipoEntrada"
        Me.colTipoEntrada.OptionsColumn.AllowFocus = False
        Me.colTipoEntrada.OptionsColumn.ReadOnly = True
        Me.colTipoEntrada.Visible = True
        Me.colTipoEntrada.VisibleIndex = 2
        Me.colTipoEntrada.Width = 190
        '
        'colFactura
        '
        Me.colFactura.Caption = "Factura"
        Me.colFactura.FieldName = "NumeroFactura"
        Me.colFactura.Name = "colFactura"
        Me.colFactura.OptionsColumn.AllowFocus = False
        Me.colFactura.OptionsColumn.ReadOnly = True
        Me.colFactura.Visible = True
        Me.colFactura.VisibleIndex = 3
        Me.colFactura.Width = 172
        '
        'colTotalMaestro
        '
        Me.colTotalMaestro.Caption = "Total"
        Me.colTotalMaestro.FieldName = "CostoTotal"
        Me.colTotalMaestro.Name = "colTotalMaestro"
        Me.colTotalMaestro.OptionsColumn.AllowFocus = False
        Me.colTotalMaestro.OptionsColumn.ReadOnly = True
        Me.colTotalMaestro.Visible = True
        Me.colTotalMaestro.VisibleIndex = 5
        Me.colTotalMaestro.Width = 172
        '
        'ColAnulada
        '
        Me.ColAnulada.Caption = "Anulada"
        Me.ColAnulada.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.ColAnulada.FieldName = "Anulada"
        Me.ColAnulada.Name = "ColAnulada"
        Me.ColAnulada.OptionsColumn.AllowEdit = False
        Me.ColAnulada.OptionsColumn.ReadOnly = True
        Me.ColAnulada.Visible = True
        Me.ColAnulada.VisibleIndex = 6
        Me.ColAnulada.Width = 150
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colFechaFactura
        '
        Me.colFechaFactura.Caption = "Fecha Factura"
        Me.colFechaFactura.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFechaFactura.FieldName = "FechaFactura"
        Me.colFechaFactura.Name = "colFechaFactura"
        Me.colFechaFactura.OptionsColumn.AllowEdit = False
        Me.colFechaFactura.OptionsColumn.ReadOnly = True
        Me.colFechaFactura.Visible = True
        Me.colFechaFactura.VisibleIndex = 4
        Me.colFechaFactura.Width = 155
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'grdEntradaDetalle
        '
        Me.grdEntradaDetalle.Location = New System.Drawing.Point(4, 308)
        Me.grdEntradaDetalle.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdEntradaDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEntradaDetalle.MainView = Me.grdEntradaDetalleTable
        Me.grdEntradaDetalle.Name = "grdEntradaDetalle"
        Me.grdEntradaDetalle.Size = New System.Drawing.Size(1096, 100)
        Me.grdEntradaDetalle.TabIndex = 5
        Me.grdEntradaDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEntradaDetalleTable})
        '
        'grdEntradaDetalleTable
        '
        Me.grdEntradaDetalleTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colTotal, Me.colCosto})
        Me.grdEntradaDetalleTable.GridControl = Me.grdEntradaDetalle
        Me.grdEntradaDetalleTable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdEntradaDetalleTable.Name = "grdEntradaDetalleTable"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "CodigoProducto"
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
        Me.colCantidad.FieldName = "CantidaEntrada"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total Costo"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowEdit = False
        Me.colTotal.OptionsColumn.AllowFocus = False
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 4
        '
        'colCosto
        '
        Me.colCosto.Caption = "Costo C$"
        Me.colCosto.FieldName = "Costo"
        Me.colCosto.Name = "colCosto"
        Me.colCosto.Visible = True
        Me.colCosto.VisibleIndex = 3
        '
        'frmSivEntradaBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 451)
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
        CType(Me.grdEntradaMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEntradaMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEntradaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEntradaDetalleTable, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdEntradaMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEntradaMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalMaestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAnulada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colFechaFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents grdEntradaDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEntradaDetalleTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCosto As DevExpress.XtraGrid.Columns.GridColumn
End Class
