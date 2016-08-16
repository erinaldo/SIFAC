<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivCategorias))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.grdCategorias = New DevExpress.XtraGrid.GridControl()
        Me.grdCategoriasTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCategoriasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(712, 39)
        Me.toolTramitesLegales.TabIndex = 7
        Me.toolTramitesLegales.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.Text = "Agregar Bodega"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar Bodega"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar Bodega"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir Bodegas"
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
        'grdCategorias
        '
        Me.grdCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCategorias.Location = New System.Drawing.Point(0, 39)
        Me.grdCategorias.MainView = Me.grdCategoriasTabla
        Me.grdCategorias.Name = "grdCategorias"
        Me.grdCategorias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdCategorias.Size = New System.Drawing.Size(712, 387)
        Me.grdCategorias.TabIndex = 8
        Me.grdCategorias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdCategoriasTabla})
        '
        'grdCategoriasTabla
        '
        Me.grdCategoriasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colNombre, Me.colDescripcion, Me.colActiva})
        Me.grdCategoriasTabla.GridControl = Me.grdCategorias
        Me.grdCategoriasTabla.Name = "grdCategoriasTabla"
        Me.grdCategoriasTabla.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdCategoriasTabla.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdCategoriasTabla.OptionsBehavior.Editable = False
        Me.grdCategoriasTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdCategoriasTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdCategoriasTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdCategoriasTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdCategoriasTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdCategoriasTabla.OptionsView.ShowFooter = True
        Me.grdCategoriasTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "StbBodegaID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 218
        '
        'colActiva
        '
        Me.colActiva.Caption = "Activa"
        Me.colActiva.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActiva.FieldName = "Activa"
        Me.colActiva.Name = "colActiva"
        Me.colActiva.OptionsColumn.AllowEdit = False
        Me.colActiva.OptionsColumn.ReadOnly = True
        Me.colActiva.Visible = True
        Me.colActiva.VisibleIndex = 2
        Me.colActiva.Width = 150
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSivCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 426)
        Me.Controls.Add(Me.grdCategorias)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Name = "frmSivCategorias"
        Me.Text = "Consulta Categorias"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCategoriasTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdCategorias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdCategoriasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
