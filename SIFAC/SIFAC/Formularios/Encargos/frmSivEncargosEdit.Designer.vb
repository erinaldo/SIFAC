<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivEncargosEdit
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivEncargosEdit))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grpDetalle = New System.Windows.Forms.GroupBox()
        Me.grdDetalleEncargos = New DevExpress.XtraGrid.GridControl()
        Me.grdDetalleEncargosTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdcmbDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.grdtxtBarCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grdSpnPrecioUnitario = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.grdspnSubTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.grdSpnDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.grdspnPorcentajeDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.grdspnTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.grdspnCodigoRepuesto = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.tabFacturas = New System.Windows.Forms.TabControl()
        Me.TabPageGenerales = New System.Windows.Forms.TabPage()
        Me.C1Combo1 = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.cmdAgregarCliente = New System.Windows.Forms.Button()
        Me.cmdCliente = New System.Windows.Forms.Button()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.cmbVendedor = New C1.Win.C1List.C1Combo()
        Me.cmbCliente = New C1.Win.C1List.C1Combo()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageCliente = New System.Windows.Forms.TabPage()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdExpedienteCliente = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.grpDetalle.SuspendLayout()
        CType(Me.grdDetalleEncargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleEncargosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdtxtBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnPrecioUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnPorcentajeDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFacturas.SuspendLayout()
        Me.TabPageGenerales.SuspendLayout()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdExpedienteCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grpDetalle)
        Me.PanelControl1.Controls.Add(Me.tabFacturas)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(871, 529)
        Me.PanelControl1.TabIndex = 0
        '
        'grpDetalle
        '
        Me.grpDetalle.Controls.Add(Me.grdDetalleEncargos)
        Me.grpDetalle.Location = New System.Drawing.Point(25, 210)
        Me.grpDetalle.Name = "grpDetalle"
        Me.grpDetalle.Size = New System.Drawing.Size(813, 237)
        Me.grpDetalle.TabIndex = 8
        Me.grpDetalle.TabStop = False
        Me.grpDetalle.Text = "Detalle"
        '
        'grdDetalleEncargos
        '
        Me.grdDetalleEncargos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalleEncargos.Location = New System.Drawing.Point(3, 16)
        Me.grdDetalleEncargos.LookAndFeel.SkinName = "Glass Oceans"
        Me.grdDetalleEncargos.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.grdDetalleEncargos.MainView = Me.grdDetalleEncargosTabla
        Me.grdDetalleEncargos.Name = "grdDetalleEncargos"
        Me.grdDetalleEncargos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grdtxtBarCode, Me.grdcmbDescripcion, Me.grdspnCantidad, Me.grdSpnPrecioUnitario, Me.grdspnSubTotal, Me.grdSpnDescuento, Me.grdspnPorcentajeDescuento, Me.grdspnTotal, Me.grdspnCodigoRepuesto, Me.RepositoryItemMemoEdit1, Me.RepositoryItemComboBox1})
        Me.grdDetalleEncargos.Size = New System.Drawing.Size(807, 218)
        Me.grdDetalleEncargos.TabIndex = 0
        Me.grdDetalleEncargos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleEncargosTabla})
        '
        'grdDetalleEncargosTabla
        '
        Me.grdDetalleEncargosTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductoID, Me.colCategoria, Me.colDescripcion, Me.colCantidad, Me.colObservaciones})
        Me.grdDetalleEncargosTabla.GridControl = Me.grdDetalleEncargos
        Me.grdDetalleEncargosTabla.Name = "grdDetalleEncargosTabla"
        Me.grdDetalleEncargosTabla.OptionsView.ShowGroupPanel = False
        '
        'colProductoID
        '
        Me.colProductoID.Caption = "ProductoID"
        Me.colProductoID.FieldName = "objProductoID"
        Me.colProductoID.Name = "colProductoID"
        Me.colProductoID.Visible = True
        Me.colProductoID.VisibleIndex = 0
        '
        'colCategoria
        '
        Me.colCategoria.Caption = "Categoria"
        Me.colCategoria.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colCategoria.FieldName = "Categoria"
        Me.colCategoria.Name = "colCategoria"
        Me.colCategoria.Visible = True
        Me.colCategoria.VisibleIndex = 1
        Me.colCategoria.Width = 132
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.ColumnEdit = Me.grdcmbDescripcion
        Me.colDescripcion.FieldName = "Codigo"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescripcion.OptionsFilter.AllowAutoFilter = False
        Me.colDescripcion.OptionsFilter.AllowFilter = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 248
        '
        'grdcmbDescripcion
        '
        Me.grdcmbDescripcion.AutoHeight = False
        Me.grdcmbDescripcion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grdcmbDescripcion.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SivProductoID", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Descripción")})
        Me.grdcmbDescripcion.DisplayMember = "Nombre"
        Me.grdcmbDescripcion.Name = "grdcmbDescripcion"
        Me.grdcmbDescripcion.NullText = ""
        Me.grdcmbDescripcion.ValueMember = "SivProductoID"
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.ColumnEdit = Me.grdspnCantidad
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidad.OptionsFilter.AllowAutoFilter = False
        Me.colCantidad.OptionsFilter.AllowFilter = False
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 65
        '
        'grdspnCantidad
        '
        Me.grdspnCantidad.AutoHeight = False
        Me.grdspnCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdspnCantidad.EditFormat.FormatString = "#"
        Me.grdspnCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdspnCantidad.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCantidad.IsFloatValue = False
        Me.grdspnCantidad.Name = "grdspnCantidad"
        '
        'colObservaciones
        '
        Me.colObservaciones.Caption = "Observaciones"
        Me.colObservaciones.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Visible = True
        Me.colObservaciones.VisibleIndex = 4
        Me.colObservaciones.Width = 274
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'grdtxtBarCode
        '
        Me.grdtxtBarCode.AutoHeight = False
        Me.grdtxtBarCode.Name = "grdtxtBarCode"
        '
        'grdSpnPrecioUnitario
        '
        Me.grdSpnPrecioUnitario.AutoHeight = False
        Me.grdSpnPrecioUnitario.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.grdSpnPrecioUnitario.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdSpnPrecioUnitario.Name = "grdSpnPrecioUnitario"
        '
        'grdspnSubTotal
        '
        Me.grdspnSubTotal.AutoHeight = False
        Me.grdspnSubTotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, False)})
        Me.grdspnSubTotal.DisplayFormat.FormatString = "#0.#0"
        Me.grdspnSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnSubTotal.EditFormat.FormatString = "#0.#0"
        Me.grdspnSubTotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnSubTotal.Name = "grdspnSubTotal"
        '
        'grdSpnDescuento
        '
        Me.grdSpnDescuento.AutoHeight = False
        Me.grdSpnDescuento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, False)})
        Me.grdSpnDescuento.DisplayFormat.FormatString = "#0.#0"
        Me.grdSpnDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdSpnDescuento.EditFormat.FormatString = "#0.#0"
        Me.grdSpnDescuento.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdSpnDescuento.Name = "grdSpnDescuento"
        '
        'grdspnPorcentajeDescuento
        '
        Me.grdspnPorcentajeDescuento.AutoHeight = False
        Me.grdspnPorcentajeDescuento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinRight, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.grdspnPorcentajeDescuento.DisplayFormat.FormatString = "#0.#0"
        Me.grdspnPorcentajeDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnPorcentajeDescuento.EditFormat.FormatString = "#0.#0"
        Me.grdspnPorcentajeDescuento.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnPorcentajeDescuento.Name = "grdspnPorcentajeDescuento"
        '
        'grdspnTotal
        '
        Me.grdspnTotal.AutoHeight = False
        Me.grdspnTotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, False)})
        Me.grdspnTotal.DisplayFormat.FormatString = "#0.#0"
        Me.grdspnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnTotal.EditFormat.FormatString = "#0.#0"
        Me.grdspnTotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnTotal.Name = "grdspnTotal"
        '
        'grdspnCodigoRepuesto
        '
        Me.grdspnCodigoRepuesto.AutoHeight = False
        Me.grdspnCodigoRepuesto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.grdspnCodigoRepuesto.Name = "grdspnCodigoRepuesto"
        '
        'tabFacturas
        '
        Me.tabFacturas.Controls.Add(Me.TabPageGenerales)
        Me.tabFacturas.Controls.Add(Me.TabPageCliente)
        Me.tabFacturas.Location = New System.Drawing.Point(25, 21)
        Me.tabFacturas.Name = "tabFacturas"
        Me.tabFacturas.SelectedIndex = 0
        Me.tabFacturas.Size = New System.Drawing.Size(817, 158)
        Me.tabFacturas.TabIndex = 1
        '
        'TabPageGenerales
        '
        Me.TabPageGenerales.Controls.Add(Me.C1Combo1)
        Me.TabPageGenerales.Controls.Add(Me.Label3)
        Me.TabPageGenerales.Controls.Add(Me.txtCodigoCliente)
        Me.TabPageGenerales.Controls.Add(Me.cmdAgregarCliente)
        Me.TabPageGenerales.Controls.Add(Me.cmdCliente)
        Me.TabPageGenerales.Controls.Add(Me.dtpFecha)
        Me.TabPageGenerales.Controls.Add(Me.cmbVendedor)
        Me.TabPageGenerales.Controls.Add(Me.cmbCliente)
        Me.TabPageGenerales.Controls.Add(Me.txtNumero)
        Me.TabPageGenerales.Controls.Add(Me.Label6)
        Me.TabPageGenerales.Controls.Add(Me.Label5)
        Me.TabPageGenerales.Controls.Add(Me.Label2)
        Me.TabPageGenerales.Controls.Add(Me.Label1)
        Me.TabPageGenerales.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGenerales.Name = "TabPageGenerales"
        Me.TabPageGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGenerales.Size = New System.Drawing.Size(809, 132)
        Me.TabPageGenerales.TabIndex = 0
        Me.TabPageGenerales.Text = "Datos Generales"
        Me.TabPageGenerales.UseVisualStyleBackColor = True
        '
        'C1Combo1
        '
        Me.C1Combo1.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CaptionHeight = 17
        Me.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ColumnHeaders = False
        Me.C1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo1.ContentHeight = 15
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo1.EditorHeight = 15
        Me.C1Combo1.Enabled = False
        Me.C1Combo1.Images.Add(CType(resources.GetObject("C1Combo1.Images"), System.Drawing.Image))
        Me.C1Combo1.ItemHeight = 15
        Me.C1Combo1.Location = New System.Drawing.Point(559, 67)
        Me.C1Combo1.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.Size = New System.Drawing.Size(172, 21)
        Me.C1Combo1.TabIndex = 22
        Me.C1Combo1.PropBag = resources.GetString("C1Combo1.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(479, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ruta:"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(77, 43)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(103, 20)
        Me.txtCodigoCliente.TabIndex = 20
        '
        'cmdAgregarCliente
        '
        Me.cmdAgregarCliente.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdAgregarCliente.Location = New System.Drawing.Point(406, 41)
        Me.cmdAgregarCliente.Name = "cmdAgregarCliente"
        Me.cmdAgregarCliente.Size = New System.Drawing.Size(24, 22)
        Me.cmdAgregarCliente.TabIndex = 16
        Me.cmdAgregarCliente.Text = "..."
        Me.cmdAgregarCliente.UseVisualStyleBackColor = True
        '
        'cmdCliente
        '
        Me.cmdCliente.Location = New System.Drawing.Point(381, 41)
        Me.cmdCliente.Name = "cmdCliente"
        Me.cmdCliente.Size = New System.Drawing.Size(24, 22)
        Me.cmdCliente.TabIndex = 15
        Me.cmdCliente.Text = "..."
        Me.cmdCliente.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        '
        '
        '
        Me.dtpFecha.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.ClearText = "&Clear"
        Me.dtpFecha.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 8, 18, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(559, 13)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 14
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cmbVendedor
        '
        Me.cmbVendedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbVendedor.Caption = ""
        Me.cmbVendedor.CaptionHeight = 17
        Me.cmbVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbVendedor.ColumnCaptionHeight = 17
        Me.cmbVendedor.ColumnFooterHeight = 17
        Me.cmbVendedor.ColumnHeaders = False
        Me.cmbVendedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbVendedor.ContentHeight = 15
        Me.cmbVendedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbVendedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbVendedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbVendedor.EditorHeight = 15
        Me.cmbVendedor.Enabled = False
        Me.cmbVendedor.Images.Add(CType(resources.GetObject("cmbVendedor.Images"), System.Drawing.Image))
        Me.cmbVendedor.ItemHeight = 15
        Me.cmbVendedor.Location = New System.Drawing.Point(559, 40)
        Me.cmbVendedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbVendedor.MaxDropDownItems = CType(5, Short)
        Me.cmbVendedor.MaxLength = 32767
        Me.cmbVendedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbVendedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbVendedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbVendedor.Size = New System.Drawing.Size(172, 21)
        Me.cmbVendedor.TabIndex = 11
        Me.cmbVendedor.PropBag = resources.GetString("cmbVendedor.PropBag")
        '
        'cmbCliente
        '
        Me.cmbCliente.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCliente.Caption = ""
        Me.cmbCliente.CaptionHeight = 17
        Me.cmbCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCliente.ColumnCaptionHeight = 17
        Me.cmbCliente.ColumnFooterHeight = 17
        Me.cmbCliente.ColumnHeaders = False
        Me.cmbCliente.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCliente.ContentHeight = 15
        Me.cmbCliente.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCliente.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCliente.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCliente.EditorHeight = 15
        Me.cmbCliente.Images.Add(CType(resources.GetObject("cmbCliente.Images"), System.Drawing.Image))
        Me.cmbCliente.ItemHeight = 15
        Me.cmbCliente.Location = New System.Drawing.Point(186, 43)
        Me.cmbCliente.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCliente.MaxDropDownItems = CType(5, Short)
        Me.cmbCliente.MaxLength = 32767
        Me.cmbCliente.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCliente.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCliente.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCliente.Size = New System.Drawing.Size(191, 21)
        Me.cmbCliente.TabIndex = 10
        Me.cmbCliente.PropBag = resources.GetString("cmbCliente.PropBag")
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(77, 13)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(81, 20)
        Me.txtNumero.TabIndex = 7
        Me.txtNumero.Tag = "BLOQUEADO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(475, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vendedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(475, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        '
        'TabPageCliente
        '
        Me.TabPageCliente.Controls.Add(Me.txtDireccion)
        Me.TabPageCliente.Controls.Add(Me.txtTelefono)
        Me.TabPageCliente.Controls.Add(Me.GroupBox1)
        Me.TabPageCliente.Controls.Add(Me.Label10)
        Me.TabPageCliente.Controls.Add(Me.Label8)
        Me.TabPageCliente.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCliente.Name = "TabPageCliente"
        Me.TabPageCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCliente.Size = New System.Drawing.Size(809, 132)
        Me.TabPageCliente.TabIndex = 1
        Me.TabPageCliente.Text = "Datos del Cliente"
        Me.TabPageCliente.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(94, 56)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(283, 44)
        Me.txtDireccion.TabIndex = 6
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(94, 30)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(231, 20)
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.Tag = "BLOQUEADO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdExpedienteCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(429, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 123)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Expediente CxC"
        '
        'grdExpedienteCliente
        '
        Me.grdExpedienteCliente.AllowColMove = False
        Me.grdExpedienteCliente.AllowUpdate = False
        Me.grdExpedienteCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdExpedienteCliente.Enabled = False
        Me.grdExpedienteCliente.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdExpedienteCliente.Images.Add(CType(resources.GetObject("grdExpedienteCliente.Images"), System.Drawing.Image))
        Me.grdExpedienteCliente.Location = New System.Drawing.Point(3, 16)
        Me.grdExpedienteCliente.Name = "grdExpedienteCliente"
        Me.grdExpedienteCliente.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdExpedienteCliente.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdExpedienteCliente.PreviewInfo.ZoomFactor = 75.0R
        Me.grdExpedienteCliente.PrintInfo.PageSettings = CType(resources.GetObject("grdExpedienteCliente.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdExpedienteCliente.Size = New System.Drawing.Size(363, 104)
        Me.grdExpedienteCliente.TabIndex = 0
        Me.grdExpedienteCliente.Text = "C1TrueDBGrid1"
        Me.grdExpedienteCliente.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdExpedienteCliente.PropBag = resources.GetString("grdExpedienteCliente.PropBag")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Teléfonos:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 507)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(871, 22)
        Me.Panel1.TabIndex = 7
        '
        'frmSivEncargosEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivEncargosEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Encargos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.grpDetalle.ResumeLayout(False)
        CType(Me.grdDetalleEncargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleEncargosTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdtxtBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnPrecioUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnPorcentajeDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFacturas.ResumeLayout(False)
        Me.TabPageGenerales.ResumeLayout(False)
        Me.TabPageGenerales.PerformLayout()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCliente.ResumeLayout(False)
        Me.TabPageCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdExpedienteCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tabFacturas As System.Windows.Forms.TabControl
    Friend WithEvents TabPageGenerales As System.Windows.Forms.TabPage
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents cmdAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents cmdCliente As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbVendedor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCliente As C1.Win.C1List.C1Combo
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPageCliente As System.Windows.Forms.TabPage
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdExpedienteCliente As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grpDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalleEncargos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleEncargosTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdspnCodigoRepuesto As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdcmbDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdspnCantidad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdSpnPrecioUnitario As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnSubTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdSpnDescuento As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdtxtBarCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grdspnPorcentajeDescuento As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colProductoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
