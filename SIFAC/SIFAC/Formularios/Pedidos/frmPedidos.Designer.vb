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
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        Me.grdEncargosDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdEncargosDetalleTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoPromedio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalEncargoDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdEncargosMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdEncargosMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRuta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colTotalCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbProductos.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.grdEncargosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEncargosDetalleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEncargosMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEncargosMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdDesactivar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdImprimir, Me.cmbExportar, Me.ToolStripSeparator3, Me.cmdCerrar})
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
        Me.cmdAgregar.ToolTipText = "Nuevo Producto"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Producto"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Producto"
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
        Me.cmdDesactivar.ToolTipText = "Inactivar Producto"
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
        Me.cmdImprimir.ToolTipText = "Imprimir Datos de Productos"
        '
        'cmbExportar
        '
        Me.cmbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbExportar.Image = CType(resources.GetObject("cmbExportar.Image"), System.Drawing.Image)
        Me.cmbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExportar.Name = "cmbExportar"
        Me.cmbExportar.Size = New System.Drawing.Size(36, 36)
        Me.cmbExportar.Text = "ToolStripButton1"
        Me.cmbExportar.ToolTipText = "Exportar a excel"
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
        Me.Contenedor.Controls.Add(Me.grdEncargosDetalle)
        Me.Contenedor.Controls.Add(Me.grdEncargosMaster)
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
        'grdEncargosDetalle
        '
        Me.grdEncargosDetalle.Location = New System.Drawing.Point(4, 283)
        Me.grdEncargosDetalle.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.grdEncargosDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEncargosDetalle.MainView = Me.grdEncargosDetalleTable
        Me.grdEncargosDetalle.Name = "grdEncargosDetalle"
        Me.grdEncargosDetalle.Size = New System.Drawing.Size(857, 271)
        Me.grdEncargosDetalle.TabIndex = 3
        Me.grdEncargosDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEncargosDetalleTable})
        '
        'grdEncargosDetalleTable
        '
        Me.grdEncargosDetalleTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.ColCategoria, Me.colDescripcion, Me.colCantidad, Me.colCostoPromedio, Me.colTotalEncargoDetalle})
        Me.grdEncargosDetalleTable.GridControl = Me.grdEncargosDetalle
        Me.grdEncargosDetalleTable.Name = "grdEncargosDetalleTable"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Numero"
        Me.colCodigo.Name = "colCodigo"
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
        Me.ColCategoria.Visible = True
        Me.ColCategoria.VisibleIndex = 1
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Producto"
        Me.colDescripcion.FieldName = "NombreProducto"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        '
        'colCostoPromedio
        '
        Me.colCostoPromedio.Caption = "Costo Promedio"
        Me.colCostoPromedio.FieldName = "CostoPromedio"
        Me.colCostoPromedio.Name = "colCostoPromedio"
        Me.colCostoPromedio.Visible = True
        Me.colCostoPromedio.VisibleIndex = 4
        '
        'colTotalEncargoDetalle
        '
        Me.colTotalEncargoDetalle.Caption = "Total Costo"
        Me.colTotalEncargoDetalle.FieldName = "Total"
        Me.colTotalEncargoDetalle.Name = "colTotalEncargoDetalle"
        Me.colTotalEncargoDetalle.OptionsColumn.AllowFocus = False
        Me.colTotalEncargoDetalle.OptionsColumn.ReadOnly = True
        Me.colTotalEncargoDetalle.Visible = True
        Me.colTotalEncargoDetalle.VisibleIndex = 5
        '
        'grdEncargosMaster
        '
        Me.grdEncargosMaster.Location = New System.Drawing.Point(4, 4)
        Me.grdEncargosMaster.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.grdEncargosMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEncargosMaster.MainView = Me.grdEncargosMasterTabla
        Me.grdEncargosMaster.Name = "grdEncargosMaster"
        Me.grdEncargosMaster.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdEncargosMaster.Size = New System.Drawing.Size(857, 275)
        Me.grdEncargosMaster.TabIndex = 2
        Me.grdEncargosMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEncargosMasterTabla})
        '
        'grdEncargosMasterTabla
        '
        Me.grdEncargosMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colRuta, Me.colCliente, Me.colVendedor, Me.colActivo, Me.colTotalCosto})
        Me.grdEncargosMasterTabla.GridControl = Me.grdEncargosMaster
        Me.grdEncargosMasterTabla.Name = "grdEncargosMasterTabla"
        Me.grdEncargosMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdEncargosMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdEncargosMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdEncargosMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdEncargosMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
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
        'colRuta
        '
        Me.colRuta.Caption = "Ruta"
        Me.colRuta.FieldName = "Ruta"
        Me.colRuta.Name = "colRuta"
        Me.colRuta.OptionsColumn.AllowFocus = False
        Me.colRuta.OptionsColumn.ReadOnly = True
        Me.colRuta.Visible = True
        Me.colRuta.VisibleIndex = 4
        Me.colRuta.Width = 86
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowFocus = False
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 2
        Me.colCliente.Width = 218
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
        Me.colVendedor.Width = 109
        '
        'colActivo
        '
        Me.colActivo.Caption = "Activo"
        Me.colActivo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActivo.FieldName = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.OptionsColumn.AllowFocus = False
        Me.colActivo.OptionsColumn.ReadOnly = True
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 5
        Me.colActivo.Width = 86
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colTotalCosto
        '
        Me.colTotalCosto.Caption = "Total Costo"
        Me.colTotalCosto.FieldName = "TotalCosto"
        Me.colTotalCosto.Name = "colTotalCosto"
        Me.colTotalCosto.Visible = True
        Me.colTotalCosto.VisibleIndex = 6
        '
        'frmSivOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 597)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivOrdenCompra"
        Me.Text = "Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.grdEncargosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEncargosDetalleTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEncargosMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEncargosMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdEncargosMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEncargosMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colTotalCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdEncargosDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEncargosDetalleTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoPromedio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalEncargoDetalle As DevExpress.XtraGrid.Columns.GridColumn
End Class
