<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidos))
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDesactivar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        Me.grdPedidosDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdPedidosDetalleTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdPedidosMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdPedidosMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.grdDetallesPedidos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoriaD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCostoD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OfficeNavigationBar1 = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
        Me.NavigationBarItem1 = New DevExpress.XtraBars.Navigation.NavigationBarItem()
        Me.NavigationBarItem2 = New DevExpress.XtraBars.Navigation.NavigationBarItem()
        Me.tbProductos.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.grdPedidosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPedidosDetalleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPedidosMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPedidosMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetallesPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeNavigationBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdDesactivar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdImprimir, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(865, 39)
        Me.tbProductos.TabIndex = 10
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Nuevo Pedido"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Pedido"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Pedido"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdDesactivar
        '
        Me.cmdDesactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDesactivar.Image = CType(resources.GetObject("cmdDesactivar.Image"), System.Drawing.Image)
        Me.cmdDesactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDesactivar.Name = "cmdDesactivar"
        Me.cmdDesactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdDesactivar.ToolTipText = "Inactivar Pedido"
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
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.ToolTipText = "Imprimir Datos de Pedidos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(36, 36)
        Me.cmdCerrar.ToolTipText = "Salir de Catálogo de Productos"
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.OfficeNavigationBar1)
        Me.Contenedor.Controls.Add(Me.grdPedidosDetalle)
        Me.Contenedor.Controls.Add(Me.grdPedidosMaster)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "49.2831541218638:False:False;48.5663082437276:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0751445086705:False" & _
    ":False;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(0, 39)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(865, 558)
        Me.Contenedor.TabIndex = 11
        Me.Contenedor.TabStop = False
        '
        'grdPedidosDetalle
        '
        Me.grdPedidosDetalle.Location = New System.Drawing.Point(4, 283)
        Me.grdPedidosDetalle.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdPedidosDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdPedidosDetalle.MainView = Me.grdPedidosDetalleTable
        Me.grdPedidosDetalle.Name = "grdPedidosDetalle"
        Me.grdPedidosDetalle.Size = New System.Drawing.Size(857, 271)
        Me.grdPedidosDetalle.TabIndex = 3
        Me.grdPedidosDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdPedidosDetalleTable})
        '
        'grdPedidosDetalleTable
        '
        Me.grdPedidosDetalleTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.ColCategoria, Me.colDescripcion, Me.colCantidad, Me.colTotal})
        Me.grdPedidosDetalleTable.GridControl = Me.grdPedidosDetalle
        Me.grdPedidosDetalleTable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdPedidosDetalleTable.Name = "grdPedidosDetalleTable"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Numero"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.OptionsColumn.AllowFocus = False
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        '
        'ColCategoria
        '
        Me.ColCategoria.Caption = "Categoria"
        Me.ColCategoria.FieldName = "Categoria"
        Me.ColCategoria.Name = "ColCategoria"
        Me.ColCategoria.OptionsColumn.AllowFocus = False
        Me.ColCategoria.Visible = True
        Me.ColCategoria.VisibleIndex = 1
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Producto"
        Me.colDescripcion.FieldName = "NombreProducto"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad Pedida"
        Me.colCantidad.FieldName = "CantidadOrdenada"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total Costo"
        Me.colTotal.FieldName = "TotalCosto"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowEdit = False
        Me.colTotal.OptionsColumn.AllowFocus = False
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 4
        '
        'grdPedidosMaster
        '
        Me.grdPedidosMaster.Location = New System.Drawing.Point(4, 4)
        Me.grdPedidosMaster.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdPedidosMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdPedidosMaster.MainView = Me.grdPedidosMasterTabla
        Me.grdPedidosMaster.Name = "grdPedidosMaster"
        Me.grdPedidosMaster.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdPedidosMaster.Size = New System.Drawing.Size(857, 275)
        Me.grdPedidosMaster.TabIndex = 2
        Me.grdPedidosMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdPedidosMasterTabla, Me.CardView1, Me.grdDetallesPedidos})
        '
        'grdPedidosMasterTabla
        '
        Me.grdPedidosMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colProveedor, Me.colEstado, Me.colTotalCosto})
        Me.grdPedidosMasterTabla.GridControl = Me.grdPedidosMaster
        Me.grdPedidosMasterTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdPedidosMasterTabla.Name = "grdPedidosMasterTabla"
        Me.grdPedidosMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdPedidosMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdPedidosMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdPedidosMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdPedidosMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdPedidosMasterTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdPedidosMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
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
        Me.colNumero.Width = 76
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha Registro"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 78
        '
        'colProveedor
        '
        Me.colProveedor.Caption = "Proveedor"
        Me.colProveedor.FieldName = "Proveedor"
        Me.colProveedor.Name = "colProveedor"
        Me.colProveedor.OptionsColumn.AllowFocus = False
        Me.colProveedor.OptionsColumn.ReadOnly = True
        Me.colProveedor.Visible = True
        Me.colProveedor.VisibleIndex = 2
        Me.colProveedor.Width = 109
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowFocus = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 3
        Me.colEstado.Width = 86
        '
        'colTotalCosto
        '
        Me.colTotalCosto.Caption = "Total Costo"
        Me.colTotalCosto.FieldName = "TotalCosto"
        Me.colTotalCosto.Name = "colTotalCosto"
        Me.colTotalCosto.Visible = True
        Me.colTotalCosto.VisibleIndex = 4
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'CardView1
        '
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.grdPedidosMaster
        Me.CardView1.Name = "CardView1"
        '
        'grdDetallesPedidos
        '
        Me.grdDetallesPedidos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoD, Me.colCategoriaD, Me.colProducto, Me.colCantidadD, Me.colTotalCostoD})
        Me.grdDetallesPedidos.GridControl = Me.grdPedidosMaster
        Me.grdDetallesPedidos.Name = "grdDetallesPedidos"
        '
        'colCodigoD
        '
        Me.colCodigoD.Caption = "Código"
        Me.colCodigoD.FieldName = "Numero"
        Me.colCodigoD.Name = "colCodigoD"
        Me.colCodigoD.Visible = True
        Me.colCodigoD.VisibleIndex = 0
        '
        'colCategoriaD
        '
        Me.colCategoriaD.Caption = "Categoria"
        Me.colCategoriaD.Name = "colCategoriaD"
        Me.colCategoriaD.Visible = True
        Me.colCategoriaD.VisibleIndex = 1
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "NombreProducto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 2
        '
        'colCantidadD
        '
        Me.colCantidadD.Caption = "Cantidad pedida"
        Me.colCantidadD.FieldName = "CantidadOrdenada"
        Me.colCantidadD.Name = "colCantidadD"
        Me.colCantidadD.Visible = True
        Me.colCantidadD.VisibleIndex = 3
        '
        'colTotalCostoD
        '
        Me.colTotalCostoD.Caption = "Total Costo"
        Me.colTotalCostoD.FieldName = "TotalCosto"
        Me.colTotalCostoD.Name = "colTotalCostoD"
        Me.colTotalCostoD.Visible = True
        Me.colTotalCostoD.VisibleIndex = 4
        '
        'OfficeNavigationBar1
        '
        Me.OfficeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OfficeNavigationBar1.Items.AddRange(New DevExpress.XtraBars.Navigation.NavigationBarItem() {Me.NavigationBarItem1, Me.NavigationBarItem2})
        Me.OfficeNavigationBar1.Location = New System.Drawing.Point(4, 283)
        Me.OfficeNavigationBar1.Name = "OfficeNavigationBar1"
        Me.OfficeNavigationBar1.Size = New System.Drawing.Size(857, 45)
        Me.OfficeNavigationBar1.TabIndex = 4
        Me.OfficeNavigationBar1.Text = "OfficeNavigationBar1"
        '
        'NavigationBarItem1
        '
        Me.NavigationBarItem1.Name = "NavigationBarItem1"
        Me.NavigationBarItem1.Text = "Item1"
        '
        'NavigationBarItem2
        '
        Me.NavigationBarItem2.Name = "NavigationBarItem2"
        Me.NavigationBarItem2.Text = "Item2"
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 597)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedidos"
        Me.Text = "Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        Me.Contenedor.PerformLayout()
        CType(Me.grdPedidosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPedidosDetalleTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPedidosMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPedidosMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetallesPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeNavigationBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDesactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdPedidosMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdPedidosMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colTotalCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdPedidosDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdPedidosDetalleTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdDetallesPedidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoriaD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCostoD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents OfficeNavigationBar1 As DevExpress.XtraBars.Navigation.OfficeNavigationBar
    Friend WithEvents NavigationBarItem1 As DevExpress.XtraBars.Navigation.NavigationBarItem
    Friend WithEvents NavigationBarItem2 As DevExpress.XtraBars.Navigation.NavigationBarItem
End Class
