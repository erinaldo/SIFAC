<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivEncargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivEncargos))
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDesactivar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.btnAutorizar = New System.Windows.Forms.ToolStripButton()
        Me.btnPedido = New System.Windows.Forms.ToolStripButton()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        Me.grdEncargosMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdEncargosMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRuta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCantidadProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalCostoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoriaProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colNumeroDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdEncargosExcel = New DevExpress.XtraGrid.GridControl()
        Me.grdvwEncargosExcel = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Ruta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Categoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Producto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CostoPromedio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.tbProductos.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.grdEncargosMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEncargosMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEncargosExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwEncargosExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Nuevo Encargo"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Encargo"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Encargo"
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
        Me.cmdDesactivar.ToolTipText = "Inactivar Encargo"
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
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdDesactivar, Me.btnAutorizar, Me.btnPedido, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmbExportar, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(1039, 39)
        Me.tbProductos.TabIndex = 9
        '
        'btnAutorizar
        '
        Me.btnAutorizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAutorizar.Image = CType(resources.GetObject("btnAutorizar.Image"), System.Drawing.Image)
        Me.btnAutorizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(36, 36)
        Me.btnAutorizar.Text = "Autorizar"
        '
        'btnPedido
        '
        Me.btnPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPedido.Image = CType(resources.GetObject("btnPedido.Image"), System.Drawing.Image)
        Me.btnPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(36, 36)
        Me.btnPedido.Text = "Generar Pedido"
        '
        'cmbExportar
        '
        Me.cmbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbExportar.Image = CType(resources.GetObject("cmbExportar.Image"), System.Drawing.Image)
        Me.cmbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExportar.Name = "cmbExportar"
        Me.cmbExportar.Size = New System.Drawing.Size(36, 36)
        Me.cmbExportar.Text = "ToolStripButton1"
        Me.cmbExportar.ToolTipText = "Imprimir"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Contenedor)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 39)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1039, 527)
        Me.PanelControl1.TabIndex = 10
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.grdEncargosMaster)
        Me.Contenedor.Controls.Add(Me.grdEncargosExcel)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "49.1395793499044:False:False;48.565965583174:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.2270531400966:False:" & _
    "False;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(2, 2)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(1035, 523)
        Me.Contenedor.TabIndex = 2
        Me.Contenedor.TabStop = False
        '
        'grdEncargosMaster
        '
        Me.grdEncargosMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEncargosMaster.Location = New System.Drawing.Point(4, 4)
        Me.grdEncargosMaster.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdEncargosMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEncargosMaster.MainView = Me.grdEncargosMasterTabla
        Me.grdEncargosMaster.Name = "grdEncargosMaster"
        Me.grdEncargosMaster.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdEncargosMaster.Size = New System.Drawing.Size(1027, 515)
        Me.grdEncargosMaster.TabIndex = 2
        Me.grdEncargosMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEncargosMasterTabla})
        '
        'grdEncargosMasterTabla
        '
        Me.grdEncargosMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colRuta, Me.colVendedor, Me.colEstado, Me.colCodigoProducto, Me.ColProducto, Me.ColCantidadProducto, Me.colCostoProducto, Me.ColTotalCostoProducto, Me.colCategoriaProducto, Me.ColSeleccionar, Me.colNumeroDetalle})
        Me.grdEncargosMasterTabla.GridControl = Me.grdEncargosMaster
        Me.grdEncargosMasterTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdEncargosMasterTabla.Name = "grdEncargosMasterTabla"
        Me.grdEncargosMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdEncargosMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdEncargosMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdEncargosMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdEncargosMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdEncargosMasterTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdEncargosMasterTabla.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.grdEncargosMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 1
        Me.colNumero.Width = 81
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha Registro"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 2
        Me.colFecha.Width = 89
        '
        'colRuta
        '
        Me.colRuta.Caption = "Ruta"
        Me.colRuta.FieldName = "Ruta"
        Me.colRuta.Name = "colRuta"
        Me.colRuta.OptionsColumn.AllowFocus = False
        Me.colRuta.OptionsColumn.ReadOnly = True
        Me.colRuta.Visible = True
        Me.colRuta.VisibleIndex = 4
        Me.colRuta.Width = 93
        '
        'colVendedor
        '
        Me.colVendedor.Caption = "Vendedor"
        Me.colVendedor.FieldName = "Vendedor"
        Me.colVendedor.Name = "colVendedor"
        Me.colVendedor.OptionsColumn.AllowFocus = False
        Me.colVendedor.OptionsColumn.ReadOnly = True
        Me.colVendedor.Visible = True
        Me.colVendedor.VisibleIndex = 3
        Me.colVendedor.Width = 158
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowFocus = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 10
        Me.colEstado.Width = 99
        '
        'colCodigoProducto
        '
        Me.colCodigoProducto.Caption = "Codigo producto"
        Me.colCodigoProducto.FieldName = "CodigoProducto"
        Me.colCodigoProducto.Name = "colCodigoProducto"
        '
        'ColProducto
        '
        Me.ColProducto.Caption = "Producto"
        Me.ColProducto.FieldName = "NombreProducto"
        Me.ColProducto.Name = "ColProducto"
        Me.ColProducto.Visible = True
        Me.ColProducto.VisibleIndex = 6
        Me.ColProducto.Width = 132
        '
        'ColCantidadProducto
        '
        Me.ColCantidadProducto.Caption = "Cantidad"
        Me.ColCantidadProducto.FieldName = "Cantidad"
        Me.ColCantidadProducto.Name = "ColCantidadProducto"
        Me.ColCantidadProducto.Visible = True
        Me.ColCantidadProducto.VisibleIndex = 7
        Me.ColCantidadProducto.Width = 62
        '
        'colCostoProducto
        '
        Me.colCostoProducto.Caption = "Costo"
        Me.colCostoProducto.FieldName = "CostoPromedio"
        Me.colCostoProducto.Name = "colCostoProducto"
        Me.colCostoProducto.Visible = True
        Me.colCostoProducto.VisibleIndex = 8
        Me.colCostoProducto.Width = 66
        '
        'ColTotalCostoProducto
        '
        Me.ColTotalCostoProducto.Caption = "Total costo"
        Me.ColTotalCostoProducto.FieldName = "TotalCosto"
        Me.ColTotalCostoProducto.Name = "ColTotalCostoProducto"
        Me.ColTotalCostoProducto.Visible = True
        Me.ColTotalCostoProducto.VisibleIndex = 9
        Me.ColTotalCostoProducto.Width = 71
        '
        'colCategoriaProducto
        '
        Me.colCategoriaProducto.Caption = "Categoria"
        Me.colCategoriaProducto.FieldName = "Categoria"
        Me.colCategoriaProducto.Name = "colCategoriaProducto"
        Me.colCategoriaProducto.Visible = True
        Me.colCategoriaProducto.VisibleIndex = 5
        Me.colCategoriaProducto.Width = 94
        '
        'ColSeleccionar
        '
        Me.ColSeleccionar.Caption = "Seleccionar"
        Me.ColSeleccionar.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.ColSeleccionar.FieldName = "Seleccionar"
        Me.ColSeleccionar.Name = "ColSeleccionar"
        Me.ColSeleccionar.Visible = True
        Me.ColSeleccionar.VisibleIndex = 0
        Me.ColSeleccionar.Width = 72
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colNumeroDetalle
        '
        Me.colNumeroDetalle.Caption = "NumeroDetalle"
        Me.colNumeroDetalle.FieldName = "NumeroDetalle"
        Me.colNumeroDetalle.Name = "colNumeroDetalle"
        '
        'grdEncargosExcel
        '
        Me.grdEncargosExcel.Location = New System.Drawing.Point(4, 265)
        Me.grdEncargosExcel.MainView = Me.grdvwEncargosExcel
        Me.grdEncargosExcel.Name = "grdEncargosExcel"
        Me.grdEncargosExcel.Size = New System.Drawing.Size(1027, 254)
        Me.grdEncargosExcel.TabIndex = 4
        Me.grdEncargosExcel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwEncargosExcel})
        Me.grdEncargosExcel.Visible = False
        '
        'grdvwEncargosExcel
        '
        Me.grdvwEncargosExcel.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ruta, Me.Empleado, Me.Categoria, Me.Producto, Me.Cantidad, Me.CostoPromedio, Me.TotalCosto})
        Me.grdvwEncargosExcel.GridControl = Me.grdEncargosExcel
        Me.grdvwEncargosExcel.Name = "grdvwEncargosExcel"
        '
        'Ruta
        '
        Me.Ruta.Caption = "Ruta"
        Me.Ruta.FieldName = "Ruta"
        Me.Ruta.Name = "Ruta"
        Me.Ruta.OptionsColumn.AllowFocus = False
        Me.Ruta.OptionsColumn.ReadOnly = True
        Me.Ruta.Visible = True
        Me.Ruta.VisibleIndex = 0
        '
        'Empleado
        '
        Me.Empleado.Caption = "Empleado"
        Me.Empleado.FieldName = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Visible = True
        Me.Empleado.VisibleIndex = 1
        '
        'Categoria
        '
        Me.Categoria.Caption = "Categoria"
        Me.Categoria.FieldName = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.OptionsColumn.AllowFocus = False
        Me.Categoria.OptionsColumn.ReadOnly = True
        Me.Categoria.Visible = True
        Me.Categoria.VisibleIndex = 2
        '
        'Producto
        '
        Me.Producto.Caption = "Producto"
        Me.Producto.FieldName = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.OptionsColumn.AllowFocus = False
        Me.Producto.OptionsColumn.ReadOnly = True
        Me.Producto.Visible = True
        Me.Producto.VisibleIndex = 3
        '
        'Cantidad
        '
        Me.Cantidad.Caption = "Cantidad"
        Me.Cantidad.FieldName = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Visible = True
        Me.Cantidad.VisibleIndex = 4
        '
        'CostoPromedio
        '
        Me.CostoPromedio.Caption = "Costo Promedio"
        Me.CostoPromedio.FieldName = "CostoPromedio"
        Me.CostoPromedio.Name = "CostoPromedio"
        Me.CostoPromedio.OptionsColumn.AllowFocus = False
        Me.CostoPromedio.OptionsColumn.ReadOnly = True
        Me.CostoPromedio.Visible = True
        Me.CostoPromedio.VisibleIndex = 5
        '
        'TotalCosto
        '
        Me.TotalCosto.Caption = "Total Costo"
        Me.TotalCosto.FieldName = "TotalCosto"
        Me.TotalCosto.Name = "TotalCosto"
        Me.TotalCosto.Visible = True
        Me.TotalCosto.VisibleIndex = 6
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'frmSivEncargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 566)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivEncargos"
        Me.Text = "Encargos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.grdEncargosMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEncargosMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEncargosExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwEncargosExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDesactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdEncargosMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEncargosMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdEncargosExcel As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwEncargosExcel As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Ruta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Categoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Producto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CostoPromedio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnPedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAutorizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents colCodigoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCantidadProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalCostoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoriaProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDetalle As DevExpress.XtraGrid.Columns.GridColumn
End Class
