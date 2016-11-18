<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivEntradaBodegaEditar
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
        Me.components = New System.ComponentModel.Container()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivEntradaBodegaEditar))
        Me.grdDetalleEntradasBodegasDE = New DevExpress.XtraGrid.GridControl()
        Me.grdDetalleEntradasBodegasDETabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnCodigoRepuesto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdcmbDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCantidadFacturada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCantidadEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnCantidadEntrada = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCostoDolares = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnCostoDolares = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmbProveedor = New C1.Win.C1List.C1Combo()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.cmbTipoEntrada = New C1.Win.C1List.C1Combo()
        Me.cmbBodega = New C1.Win.C1List.C1Combo()
        Me.lblTipoEntrada = New System.Windows.Forms.Label()
        Me.lblFechaEntrada = New System.Windows.Forms.Label()
        Me.lblBodega = New System.Windows.Forms.Label()
        Me.dtpFechaEntrada = New C1.Win.C1Input.C1DateEdit()
        Me.txtNumeroEntrada = New System.Windows.Forms.TextBox()
        Me.lblNoEntrada = New System.Windows.Forms.Label()
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbxOtrosDatos = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFactura = New C1.Win.C1Input.C1DateEdit()
        Me.lblFechaFactura = New System.Windows.Forms.Label()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.lblNumeroFactura = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblCostoTotal = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.NumCostoTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grdDetalleEntradasBodegasDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleEntradasBodegasDETabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidadEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCostoDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOtrosDatos.SuspendLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDetalleEntradasBodegasDE
        '
        Me.grdDetalleEntradasBodegasDE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalleEntradasBodegasDE.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalleEntradasBodegasDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDetalleEntradasBodegasDE.Location = New System.Drawing.Point(4, 20)
        Me.grdDetalleEntradasBodegasDE.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdDetalleEntradasBodegasDE.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdDetalleEntradasBodegasDE.MainView = Me.grdDetalleEntradasBodegasDETabla
        Me.grdDetalleEntradasBodegasDE.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalleEntradasBodegasDE.Name = "grdDetalleEntradasBodegasDE"
        Me.grdDetalleEntradasBodegasDE.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grdcmbDescripcion, Me.grdspnCantidad, Me.grdspnCantidadEntrada, Me.grdspnCostoDolares, Me.grdspnTotal, Me.grdspnCodigoRepuesto})
        Me.grdDetalleEntradasBodegasDE.Size = New System.Drawing.Size(1083, 266)
        Me.grdDetalleEntradasBodegasDE.TabIndex = 0
        Me.grdDetalleEntradasBodegasDE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleEntradasBodegasDETabla})
        '
        'grdDetalleEntradasBodegasDETabla
        '
        Me.grdDetalleEntradasBodegasDETabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoProducto, Me.colDescripcion, Me.colCantidadFacturada, Me.colCantidadEntrada, Me.colCostoDolares, Me.colTotal})
        Me.grdDetalleEntradasBodegasDETabla.GridControl = Me.grdDetalleEntradasBodegasDE
        Me.grdDetalleEntradasBodegasDETabla.Name = "grdDetalleEntradasBodegasDETabla"
        Me.grdDetalleEntradasBodegasDETabla.OptionsView.ShowGroupPanel = False
        '
        'colCodigoProducto
        '
        Me.colCodigoProducto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoProducto.AppearanceHeader.Options.UseFont = True
        Me.colCodigoProducto.Caption = "Código"
        Me.colCodigoProducto.ColumnEdit = Me.grdspnCodigoRepuesto
        Me.colCodigoProducto.FieldName = "SivProductoID"
        Me.colCodigoProducto.Name = "colCodigoProducto"
        Me.colCodigoProducto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoProducto.OptionsFilter.AllowAutoFilter = False
        Me.colCodigoProducto.OptionsFilter.AllowFilter = False
        Me.colCodigoProducto.Visible = True
        Me.colCodigoProducto.VisibleIndex = 0
        Me.colCodigoProducto.Width = 96
        '
        'grdspnCodigoRepuesto
        '
        Me.grdspnCodigoRepuesto.AutoHeight = False
        Me.grdspnCodigoRepuesto.Name = "grdspnCodigoRepuesto"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción Corta"
        Me.colDescripcion.ColumnEdit = Me.grdcmbDescripcion
        Me.colDescripcion.FieldName = "SivProductoID"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescripcion.OptionsFilter.AllowAutoFilter = False
        Me.colDescripcion.OptionsFilter.AllowFilter = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 140
        '
        'grdcmbDescripcion
        '
        Me.grdcmbDescripcion.AutoHeight = False
        Me.grdcmbDescripcion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grdcmbDescripcion.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SivProductoID", "Código", 10, DevExpress.Utils.FormatType.Custom, "", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Descripción", 30, DevExpress.Utils.FormatType.Custom, "", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.grdcmbDescripcion.DisplayMember = "Nombre"
        Me.grdcmbDescripcion.Name = "grdcmbDescripcion"
        Me.grdcmbDescripcion.NullText = ""
        Me.grdcmbDescripcion.ValueMember = "SivProductoID"
        '
        'colCantidadFacturada
        '
        Me.colCantidadFacturada.Caption = "Cant. Fact."
        Me.colCantidadFacturada.ColumnEdit = Me.grdspnCantidad
        Me.colCantidadFacturada.FieldName = "Cantidad"
        Me.colCantidadFacturada.Name = "colCantidadFacturada"
        Me.colCantidadFacturada.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidadFacturada.OptionsFilter.AllowAutoFilter = False
        Me.colCantidadFacturada.OptionsFilter.AllowFilter = False
        Me.colCantidadFacturada.Visible = True
        Me.colCantidadFacturada.VisibleIndex = 2
        Me.colCantidadFacturada.Width = 64
        '
        'grdspnCantidad
        '
        Me.grdspnCantidad.AutoHeight = False
        Me.grdspnCantidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.grdspnCantidad.EditFormat.FormatString = "#"
        Me.grdspnCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdspnCantidad.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCantidad.Name = "grdspnCantidad"
        '
        'colCantidadEntrada
        '
        Me.colCantidadEntrada.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colCantidadEntrada.AppearanceCell.Options.UseBackColor = True
        Me.colCantidadEntrada.Caption = "Cant. Ent."
        Me.colCantidadEntrada.ColumnEdit = Me.grdspnCantidadEntrada
        Me.colCantidadEntrada.FieldName = "CantidaEntrada"
        Me.colCantidadEntrada.Name = "colCantidadEntrada"
        Me.colCantidadEntrada.OptionsColumn.AllowFocus = False
        Me.colCantidadEntrada.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidadEntrada.OptionsColumn.ReadOnly = True
        Me.colCantidadEntrada.OptionsFilter.AllowAutoFilter = False
        Me.colCantidadEntrada.OptionsFilter.AllowFilter = False
        Me.colCantidadEntrada.Visible = True
        Me.colCantidadEntrada.VisibleIndex = 3
        Me.colCantidadEntrada.Width = 60
        '
        'grdspnCantidadEntrada
        '
        Me.grdspnCantidadEntrada.AutoHeight = False
        Me.grdspnCantidadEntrada.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, False)})
        Me.grdspnCantidadEntrada.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCantidadEntrada.Name = "grdspnCantidadEntrada"
        '
        'colCostoDolares
        '
        Me.colCostoDolares.Caption = "Costo C$"
        Me.colCostoDolares.ColumnEdit = Me.grdspnCostoDolares
        Me.colCostoDolares.FieldName = "Costo"
        Me.colCostoDolares.Name = "colCostoDolares"
        Me.colCostoDolares.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCostoDolares.OptionsFilter.AllowAutoFilter = False
        Me.colCostoDolares.OptionsFilter.AllowFilter = False
        Me.colCostoDolares.Visible = True
        Me.colCostoDolares.VisibleIndex = 4
        Me.colCostoDolares.Width = 54
        '
        'grdspnCostoDolares
        '
        Me.grdspnCostoDolares.AutoHeight = False
        Me.grdspnCostoDolares.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, False)})
        Me.grdspnCostoDolares.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCostoDolares.Name = "grdspnCostoDolares"
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colTotal.AppearanceCell.Options.UseBackColor = True
        Me.colTotal.Caption = "Total"
        Me.colTotal.ColumnEdit = Me.grdspnTotal
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowFocus = False
        Me.colTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.OptionsFilter.AllowAutoFilter = False
        Me.colTotal.OptionsFilter.AllowFilter = False
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 5
        Me.colTotal.Width = 39
        '
        'grdspnTotal
        '
        Me.grdspnTotal.AutoHeight = False
        Me.grdspnTotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, False)})
        Me.grdspnTotal.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnTotal.Name = "grdspnTotal"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbProveedor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblProveedor)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNumeroEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoEntrada)
        Me.gbxDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(28, 20)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(1091, 145)
        Me.gbxDatosGenerales.TabIndex = 73
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProveedor.Caption = ""
        Me.cmbProveedor.CaptionHeight = 17
        Me.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProveedor.ColumnCaptionHeight = 17
        Me.cmbProveedor.ColumnFooterHeight = 17
        Me.cmbProveedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbProveedor.ContentHeight = 18
        Me.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProveedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProveedor.EditorHeight = 18
        Me.cmbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.Images.Add(CType(resources.GetObject("cmbProveedor.Images"), System.Drawing.Image))
        Me.cmbProveedor.ItemHeight = 15
        Me.cmbProveedor.Location = New System.Drawing.Point(176, 102)
        Me.cmbProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProveedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProveedor.MaxDropDownItems = CType(5, Short)
        Me.cmbProveedor.MaxLength = 32767
        Me.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedor.Size = New System.Drawing.Size(232, 24)
        Me.cmbProveedor.TabIndex = 97
        Me.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag")
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(37, 106)
        Me.lblProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(83, 17)
        Me.lblProveedor.TabIndex = 96
        Me.lblProveedor.Tag = ""
        Me.lblProveedor.Text = "Proveedor"
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoEntrada.Caption = ""
        Me.cmbTipoEntrada.CaptionHeight = 17
        Me.cmbTipoEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoEntrada.ColumnCaptionHeight = 17
        Me.cmbTipoEntrada.ColumnFooterHeight = 17
        Me.cmbTipoEntrada.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoEntrada.ContentHeight = 18
        Me.cmbTipoEntrada.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoEntrada.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoEntrada.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoEntrada.EditorHeight = 18
        Me.cmbTipoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.Images.Add(CType(resources.GetObject("cmbTipoEntrada.Images"), System.Drawing.Image))
        Me.cmbTipoEntrada.ItemHeight = 15
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(843, 65)
        Me.cmbTipoEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoEntrada.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoEntrada.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoEntrada.MaxLength = 32767
        Me.cmbTipoEntrada.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoEntrada.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoEntrada.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(232, 24)
        Me.cmbTipoEntrada.TabIndex = 95
        Me.cmbTipoEntrada.PropBag = resources.GetString("cmbTipoEntrada.PropBag")
        '
        'cmbBodega
        '
        Me.cmbBodega.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodega.Caption = ""
        Me.cmbBodega.CaptionHeight = 17
        Me.cmbBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodega.ColumnCaptionHeight = 17
        Me.cmbBodega.ColumnFooterHeight = 17
        Me.cmbBodega.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbBodega.ContentHeight = 18
        Me.cmbBodega.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBodega.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBodega.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodega.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodega.EditorHeight = 18
        Me.cmbBodega.Enabled = False
        Me.cmbBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodega.Images.Add(CType(resources.GetObject("cmbBodega.Images"), System.Drawing.Image))
        Me.cmbBodega.ItemHeight = 15
        Me.cmbBodega.Location = New System.Drawing.Point(177, 65)
        Me.cmbBodega.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(232, 24)
        Me.cmbBodega.TabIndex = 0
        Me.cmbBodega.Tag = "BLOQUEADO"
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
        '
        'lblTipoEntrada
        '
        Me.lblTipoEntrada.AutoSize = True
        Me.lblTipoEntrada.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEntrada.Location = New System.Drawing.Point(723, 71)
        Me.lblTipoEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoEntrada.Name = "lblTipoEntrada"
        Me.lblTipoEntrada.Size = New System.Drawing.Size(107, 17)
        Me.lblTipoEntrada.TabIndex = 92
        Me.lblTipoEntrada.Tag = ""
        Me.lblTipoEntrada.Text = "Tipo Entrada:"
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrada.Location = New System.Drawing.Point(723, 30)
        Me.lblFechaEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(57, 17)
        Me.lblFechaEntrada.TabIndex = 88
        Me.lblFechaEntrada.Tag = ""
        Me.lblFechaEntrada.Text = "Fecha:"
        '
        'lblBodega
        '
        Me.lblBodega.BackColor = System.Drawing.Color.Transparent
        Me.lblBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodega.Location = New System.Drawing.Point(33, 65)
        Me.lblBodega.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(111, 22)
        Me.lblBodega.TabIndex = 86
        Me.lblBodega.Tag = ""
        Me.lblBodega.Text = "Bodega:"
        '
        'dtpFechaEntrada
        '
        Me.dtpFechaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaEntrada.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaEntrada.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaEntrada.Calendar.ClearText = "&Clear"
        Me.dtpFechaEntrada.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaEntrada.Calendar.SelectedDate = New Date(2016, 7, 29, 0, 0, 0, 0)
        Me.dtpFechaEntrada.Calendar.TodayText = "&Today"
        Me.dtpFechaEntrada.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaEntrada.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaEntrada.EditMask = "##/##/####"
        Me.dtpFechaEntrada.Enabled = False
        Me.dtpFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEntrada.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEntrada.Location = New System.Drawing.Point(843, 30)
        Me.dtpFechaEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
        Me.dtpFechaEntrada.Size = New System.Drawing.Size(232, 21)
        Me.dtpFechaEntrada.TabIndex = 0
        Me.dtpFechaEntrada.Tag = Nothing
        Me.dtpFechaEntrada.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtNumeroEntrada
        '
        Me.txtNumeroEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroEntrada.Location = New System.Drawing.Point(177, 25)
        Me.txtNumeroEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroEntrada.Name = "txtNumeroEntrada"
        Me.txtNumeroEntrada.Size = New System.Drawing.Size(231, 23)
        Me.txtNumeroEntrada.TabIndex = 0
        Me.txtNumeroEntrada.TabStop = False
        Me.txtNumeroEntrada.Tag = "BLOQUEADO"
        Me.txtNumeroEntrada.Text = "(Automático)"
        '
        'lblNoEntrada
        '
        Me.lblNoEntrada.AutoSize = True
        Me.lblNoEntrada.BackColor = System.Drawing.Color.Transparent
        Me.lblNoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoEntrada.Location = New System.Drawing.Point(33, 30)
        Me.lblNoEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoEntrada.Name = "lblNoEntrada"
        Me.lblNoEntrada.Size = New System.Drawing.Size(131, 17)
        Me.lblNoEntrada.TabIndex = 19
        Me.lblNoEntrada.Tag = ""
        Me.lblNoEntrada.Text = "Número Entrada:"
        '
        'imgIconos
        '
        Me.imgIconos.ImageStream = CType(resources.GetObject("imgIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIconos.Images.SetKeyName(0, "Usuario.gif")
        Me.imgIconos.Images.SetKeyName(1, "Buscar.png")
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'gbxOtrosDatos
        '
        Me.gbxOtrosDatos.Controls.Add(Me.dtpFechaFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.lblFechaFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.txtNumeroFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.lblNumeroFactura)
        Me.gbxOtrosDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOtrosDatos.Location = New System.Drawing.Point(24, 178)
        Me.gbxOtrosDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxOtrosDatos.Name = "gbxOtrosDatos"
        Me.gbxOtrosDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxOtrosDatos.Size = New System.Drawing.Size(1091, 74)
        Me.gbxOtrosDatos.TabIndex = 82
        Me.gbxOtrosDatos.TabStop = False
        Me.gbxOtrosDatos.Text = "Otros Datos"
        '
        'dtpFechaFactura
        '
        '
        '
        '
        Me.dtpFechaFactura.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaFactura.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaFactura.Calendar.ClearText = "&Clear"
        Me.dtpFechaFactura.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaFactura.Calendar.SelectedDate = New Date(2016, 7, 29, 0, 0, 0, 0)
        Me.dtpFechaFactura.Calendar.TodayText = "&Today"
        Me.dtpFechaFactura.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaFactura.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaFactura.EditMask = "##/##/####"
        Me.dtpFechaFactura.Enabled = False
        Me.dtpFechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFactura.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFactura.Location = New System.Drawing.Point(899, 26)
        Me.dtpFechaFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(173, 23)
        Me.dtpFechaFactura.TabIndex = 24
        Me.dtpFechaFactura.Tag = Nothing
        Me.dtpFechaFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.AutoSize = True
        Me.lblFechaFactura.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFactura.Location = New System.Drawing.Point(773, 28)
        Me.lblFechaFactura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(117, 17)
        Me.lblFechaFactura.TabIndex = 23
        Me.lblFechaFactura.Tag = ""
        Me.lblFechaFactura.Text = "Fecha Factura:"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroFactura.Location = New System.Drawing.Point(175, 26)
        Me.txtNumeroFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(152, 23)
        Me.txtNumeroFactura.TabIndex = 0
        Me.txtNumeroFactura.TabStop = False
        Me.txtNumeroFactura.Tag = ""
        '
        'lblNumeroFactura
        '
        Me.lblNumeroFactura.AutoSize = True
        Me.lblNumeroFactura.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroFactura.Location = New System.Drawing.Point(37, 30)
        Me.lblNumeroFactura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroFactura.Name = "lblNumeroFactura"
        Me.lblNumeroFactura.Size = New System.Drawing.Size(129, 17)
        Me.lblNumeroFactura.TabIndex = 19
        Me.lblNumeroFactura.Tag = ""
        Me.lblNumeroFactura.Text = "Número Factura:"
        '
        'txtComentarios
        '
        Me.txtComentarios.AcceptsTab = True
        Me.txtComentarios.Location = New System.Drawing.Point(24, 608)
        Me.txtComentarios.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentarios.MaxLength = 250
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarios.Size = New System.Drawing.Size(1091, 67)
        Me.txtComentarios.TabIndex = 93
        Me.txtComentarios.Tag = ""
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(24, 578)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(121, 17)
        Me.lblObservaciones.TabIndex = 94
        Me.lblObservaciones.Tag = ""
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoTotal.Location = New System.Drawing.Point(833, 565)
        Me.lblCostoTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(120, 17)
        Me.lblCostoTotal.TabIndex = 96
        Me.lblCostoTotal.Tag = ""
        Me.lblCostoTotal.Text = "Costo Total C$:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(24, 705)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 17)
        Me.lblUsuario.TabIndex = 97
        Me.lblUsuario.Tag = ""
        Me.lblUsuario.Text = "Usuario"
        '
        'NumCostoTotal
        '
        Me.NumCostoTotal.DisplayFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumCostoTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumCostoTotal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumCostoTotal.EditFormat.CustomFormat = "$ #,##0.#0"
        Me.NumCostoTotal.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumCostoTotal.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumCostoTotal.Enabled = False
        Me.NumCostoTotal.Location = New System.Drawing.Point(968, 562)
        Me.NumCostoTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.NumCostoTotal.Name = "NumCostoTotal"
        Me.NumCostoTotal.Size = New System.Drawing.Size(143, 22)
        Me.NumCostoTotal.TabIndex = 102
        Me.NumCostoTotal.Tag = "BLOQUEADO"
        Me.NumCostoTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.grdDetalleEntradasBodegasDE)
        Me.gbxDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetalle.Location = New System.Drawing.Point(24, 265)
        Me.gbxDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDetalle.Size = New System.Drawing.Size(1091, 290)
        Me.gbxDetalle.TabIndex = 103
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Detalle de Entrada"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.lblUsuario)
        Me.PanelControl1.Controls.Add(Me.NumCostoTotal)
        Me.PanelControl1.Controls.Add(Me.gbxDetalle)
        Me.PanelControl1.Controls.Add(Me.lblCostoTotal)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Controls.Add(Me.gbxOtrosDatos)
        Me.PanelControl1.Controls.Add(Me.lblObservaciones)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1136, 740)
        Me.PanelControl1.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(1016, 690)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 105
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(901, 690)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 104
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmSivEntradaBodegaEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 740)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivEntradaBodegaEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Entrada de Productos"
        CType(Me.grdDetalleEntradasBodegasDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleEntradasBodegasDETabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidadEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCostoDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOtrosDatos.ResumeLayout(False)
        Me.gbxOtrosDatos.PerformLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEntrada As System.Windows.Forms.Label
    Friend WithEvents lblFechaEntrada As System.Windows.Forms.Label
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEntrada As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtNumeroEntrada As System.Windows.Forms.TextBox
    Friend WithEvents lblNoEntrada As System.Windows.Forms.Label
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoEntrada As C1.Win.C1List.C1Combo
    Friend WithEvents gbxOtrosDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroFactura As System.Windows.Forms.Label
    Friend WithEvents lblFechaFactura As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFactura As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblCostoTotal As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents NumCostoTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalleEntradasBodegasDE As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleEntradasBodegasDETabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadFacturada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoDolares As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdcmbDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grdspnCantidad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnCantidadEntrada As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnCostoDolares As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnCodigoRepuesto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmbProveedor As C1.Win.C1List.C1Combo
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
End Class
