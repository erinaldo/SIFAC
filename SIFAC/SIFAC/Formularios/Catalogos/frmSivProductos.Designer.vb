<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivProductos))
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
        Me.mnuProducto = New System.Windows.Forms.MenuStrip()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDesactivar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRefrescar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.grdProductos = New DevExpress.XtraGrid.GridControl()
        Me.grdProductosTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tbProductos.SuspendLayout()
        Me.mnuProducto.SuspendLayout()
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProductosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdDesactivar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdImprimir, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(805, 39)
        Me.tbProductos.TabIndex = 0
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
        'mnuProducto
        '
        Me.mnuProducto.AllowMerge = False
        Me.mnuProducto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuEditar, Me.mnuConsultar, Me.mnuDesactivar, Me.mnuRefrescar, Me.mnuImprimir, Me.mnuCerrar})
        Me.mnuProducto.Location = New System.Drawing.Point(0, 0)
        Me.mnuProducto.Name = "mnuProducto"
        Me.mnuProducto.Size = New System.Drawing.Size(621, 24)
        Me.mnuProducto.TabIndex = 2
        Me.mnuProducto.Visible = False
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(61, 20)
        Me.mnuAgregar.Text = "Agregar"
        '
        'mnuEditar
        '
        Me.mnuEditar.Name = "mnuEditar"
        Me.mnuEditar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEditar.Size = New System.Drawing.Size(49, 20)
        Me.mnuEditar.Text = "Editar"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(70, 20)
        Me.mnuConsultar.Text = "Consultar"
        '
        'mnuDesactivar
        '
        Me.mnuDesactivar.Name = "mnuDesactivar"
        Me.mnuDesactivar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuDesactivar.Size = New System.Drawing.Size(73, 20)
        Me.mnuDesactivar.Text = "Desactivar"
        '
        'mnuRefrescar
        '
        Me.mnuRefrescar.Name = "mnuRefrescar"
        Me.mnuRefrescar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRefrescar.Size = New System.Drawing.Size(67, 20)
        Me.mnuRefrescar.Text = "Refrescar"
        '
        'mnuImprimir
        '
        Me.mnuImprimir.Name = "mnuImprimir"
        Me.mnuImprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuImprimir.Size = New System.Drawing.Size(65, 20)
        Me.mnuImprimir.Text = "Imprimir"
        '
        'mnuCerrar
        '
        Me.mnuCerrar.Name = "mnuCerrar"
        Me.mnuCerrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCerrar.Size = New System.Drawing.Size(51, 20)
        Me.mnuCerrar.Text = "Cerrar"
        '
        'grdProductos
        '
        Me.grdProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProductos.Location = New System.Drawing.Point(0, 39)
        Me.grdProductos.MainView = Me.grdProductosTabla
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdProductos.Size = New System.Drawing.Size(805, 388)
        Me.grdProductos.TabIndex = 7
        Me.grdProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdProductosTabla})
        '
        'grdProductosTabla
        '
        Me.grdProductosTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colCodigo, Me.colNombre, Me.colCategoria, Me.colMarca, Me.colActiva})
        Me.grdProductosTabla.GridControl = Me.grdProductos
        Me.grdProductosTabla.Name = "grdProductosTabla"
        Me.grdProductosTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdProductosTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdProductosTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdProductosTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdProductosTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdProductosTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "SivProductoID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowFocus = False
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 148
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowFocus = False
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 219
        '
        'colCategoria
        '
        Me.colCategoria.Caption = "Categoria"
        Me.colCategoria.FieldName = "Categoria"
        Me.colCategoria.Name = "colCategoria"
        Me.colCategoria.Visible = True
        Me.colCategoria.VisibleIndex = 2
        Me.colCategoria.Width = 150
        '
        'colMarca
        '
        Me.colMarca.Caption = "Marca"
        Me.colMarca.FieldName = "Marca"
        Me.colMarca.Name = "colMarca"
        Me.colMarca.Visible = True
        Me.colMarca.VisibleIndex = 3
        Me.colMarca.Width = 169
        '
        'colActiva
        '
        Me.colActiva.Caption = "Activa"
        Me.colActiva.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActiva.FieldName = "Activo"
        Me.colActiva.Name = "colActiva"
        Me.colActiva.OptionsColumn.AllowFocus = False
        Me.colActiva.OptionsColumn.ReadOnly = True
        Me.colActiva.Visible = True
        Me.colActiva.VisibleIndex = 4
        Me.colActiva.Width = 101
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSivProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 427)
        Me.Controls.Add(Me.grdProductos)
        Me.Controls.Add(Me.tbProductos)
        Me.Controls.Add(Me.mnuProducto)
        Me.MainMenuStrip = Me.mnuProducto
        Me.Name = "frmSivProductos"
        Me.Text = "Catálogo de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        Me.mnuProducto.ResumeLayout(False)
        Me.mnuProducto.PerformLayout()
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProductosTabla, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuProducto As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDesactivar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefrescar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdProductosTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
