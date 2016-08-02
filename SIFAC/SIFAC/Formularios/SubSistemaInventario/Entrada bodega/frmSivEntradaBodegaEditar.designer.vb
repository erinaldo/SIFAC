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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
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
        CType(Me.grdDetalleEntradasBodegasDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleEntradasBodegasDETabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidadEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCostoDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOtrosDatos.SuspendLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDetalleEntradasBodegasDE
        '
        Me.grdDetalleEntradasBodegasDE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalleEntradasBodegasDE.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalleEntradasBodegasDE.Location = New System.Drawing.Point(4, 19)
        Me.grdDetalleEntradasBodegasDE.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.grdDetalleEntradasBodegasDE.MainView = Me.grdDetalleEntradasBodegasDETabla
        Me.grdDetalleEntradasBodegasDE.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalleEntradasBodegasDE.Name = "grdDetalleEntradasBodegasDE"
        Me.grdDetalleEntradasBodegasDE.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grdcmbDescripcion, Me.grdspnCantidad, Me.grdspnCantidadEntrada, Me.grdspnCostoDolares, Me.grdspnTotal, Me.grdspnCodigoRepuesto})
        Me.grdDetalleEntradasBodegasDE.Size = New System.Drawing.Size(1083, 267)
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
        Me.colCostoDolares.Caption = "Costo U$"
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
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(1016, 694)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(99, 37)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(909, 694)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(99, 37)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1136, 39)
        Me.Panel2.TabIndex = 75
        Me.Panel2.Tag = "LAYOUT"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNumeroEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoEntrada)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(23, 48)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(1091, 145)
        Me.gbxDatosGenerales.TabIndex = 73
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
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
        Me.lblTipoEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoEntrada.Location = New System.Drawing.Point(721, 71)
        Me.lblTipoEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoEntrada.Name = "lblTipoEntrada"
        Me.lblTipoEntrada.Size = New System.Drawing.Size(94, 17)
        Me.lblTipoEntrada.TabIndex = 92
        Me.lblTipoEntrada.Tag = ""
        Me.lblTipoEntrada.Text = "Tipo Entrada:"
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaEntrada.Location = New System.Drawing.Point(721, 30)
        Me.lblFechaEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(51, 17)
        Me.lblFechaEntrada.TabIndex = 88
        Me.lblFechaEntrada.Tag = ""
        Me.lblFechaEntrada.Text = "Fecha:"
        '
        'lblBodega
        '
        Me.lblBodega.BackColor = System.Drawing.SystemColors.Control
        Me.lblBodega.Location = New System.Drawing.Point(37, 65)
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
        Me.dtpFechaEntrada.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEntrada.Location = New System.Drawing.Point(843, 30)
        Me.dtpFechaEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
        Me.dtpFechaEntrada.Size = New System.Drawing.Size(232, 20)
        Me.dtpFechaEntrada.TabIndex = 0
        Me.dtpFechaEntrada.Tag = Nothing
        Me.dtpFechaEntrada.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtNumeroEntrada
        '
        Me.txtNumeroEntrada.Location = New System.Drawing.Point(177, 25)
        Me.txtNumeroEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroEntrada.Name = "txtNumeroEntrada"
        Me.txtNumeroEntrada.Size = New System.Drawing.Size(231, 22)
        Me.txtNumeroEntrada.TabIndex = 0
        Me.txtNumeroEntrada.TabStop = False
        Me.txtNumeroEntrada.Tag = "BLOQUEADO"
        Me.txtNumeroEntrada.Text = "(Automático)"
        '
        'lblNoEntrada
        '
        Me.lblNoEntrada.AutoSize = True
        Me.lblNoEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoEntrada.Location = New System.Drawing.Point(37, 30)
        Me.lblNoEntrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoEntrada.Name = "lblNoEntrada"
        Me.lblNoEntrada.Size = New System.Drawing.Size(116, 17)
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
        Me.gbxOtrosDatos.Location = New System.Drawing.Point(23, 201)
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
        Me.dtpFechaFactura.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFactura.Location = New System.Drawing.Point(899, 26)
        Me.dtpFechaFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(173, 22)
        Me.dtpFechaFactura.TabIndex = 24
        Me.dtpFechaFactura.Tag = Nothing
        Me.dtpFechaFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.AutoSize = True
        Me.lblFechaFactura.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaFactura.Location = New System.Drawing.Point(781, 30)
        Me.lblFechaFactura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(103, 17)
        Me.lblFechaFactura.TabIndex = 23
        Me.lblFechaFactura.Tag = ""
        Me.lblFechaFactura.Text = "Fecha Factura:"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(175, 26)
        Me.txtNumeroFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(152, 22)
        Me.txtNumeroFactura.TabIndex = 0
        Me.txtNumeroFactura.TabStop = False
        Me.txtNumeroFactura.Tag = ""
        '
        'lblNumeroFactura
        '
        Me.lblNumeroFactura.AutoSize = True
        Me.lblNumeroFactura.BackColor = System.Drawing.SystemColors.Control
        Me.lblNumeroFactura.Location = New System.Drawing.Point(37, 30)
        Me.lblNumeroFactura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroFactura.Name = "lblNumeroFactura"
        Me.lblNumeroFactura.Size = New System.Drawing.Size(114, 17)
        Me.lblNumeroFactura.TabIndex = 19
        Me.lblNumeroFactura.Tag = ""
        Me.lblNumeroFactura.Text = "Número Factura:"
        '
        'txtComentarios
        '
        Me.txtComentarios.AcceptsTab = True
        Me.txtComentarios.Location = New System.Drawing.Point(24, 619)
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
        Me.lblObservaciones.BackColor = System.Drawing.SystemColors.Control
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 583)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(107, 17)
        Me.lblObservaciones.TabIndex = 94
        Me.lblObservaciones.Tag = ""
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblCostoTotal.Location = New System.Drawing.Point(863, 583)
        Me.lblCostoTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(106, 17)
        Me.lblCostoTotal.TabIndex = 96
        Me.lblCostoTotal.Tag = ""
        Me.lblCostoTotal.Text = "Costo Total U$:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.lblUsuario.Location = New System.Drawing.Point(20, 715)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lblUsuario.TabIndex = 97
        Me.lblUsuario.Tag = ""
        Me.lblUsuario.Text = "Usuario"
        '
        'NumCostoTotal
        '
        Me.NumCostoTotal.DisplayFormat.CustomFormat = "$ #,##0.#0"
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
        Me.NumCostoTotal.Location = New System.Drawing.Point(972, 578)
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
        Me.gbxDetalle.Location = New System.Drawing.Point(24, 282)
        Me.gbxDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDetalle.Size = New System.Drawing.Size(1091, 290)
        Me.gbxDetalle.TabIndex = 103
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Detalle de Entrada"
        '
        'frmSivEntradaBodegaEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 740)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.NumCostoTotal)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblCostoTotal)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.gbxOtrosDatos)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbxDatosGenerales)
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
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOtrosDatos.ResumeLayout(False)
        Me.gbxOtrosDatos.PerformLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
End Class
