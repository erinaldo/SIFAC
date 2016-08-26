<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaFacturaRepuestosEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaFacturaRepuestosEditar))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.tabFacturas = New System.Windows.Forms.TabControl()
        Me.TabPageGenerales = New System.Windows.Forms.TabPage()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.cmbMotivoAnular = New C1.Win.C1List.C1Combo()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.cmdAgregarCliente = New System.Windows.Forms.Button()
        Me.cmdCliente = New System.Windows.Forms.Button()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.cmbTPago = New C1.Win.C1List.C1Combo()
        Me.cmbBodega = New C1.Win.C1List.C1Combo()
        Me.cmbVendedor = New C1.Win.C1List.C1Combo()
        Me.cmbCliente = New C1.Win.C1List.C1Combo()
        Me.txtAtencionA = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageCliente = New System.Windows.Forms.TabPage()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdExpedienteCliente = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpDetalle = New System.Windows.Forms.GroupBox()
        Me.grdDetalleFactura = New DevExpress.XtraGrid.GridControl()
        Me.grdDetalleFacturaTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoRepuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnCodigoRepuesto = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdcmbDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colPrecioUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdSpnPrecioUnitario = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colSubtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnSubTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdSpnDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colImpuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdspnTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdtxtBarCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grdspnPorcentajeDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.numSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.numPrima = New C1.Win.C1Input.C1NumericEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkSolicitudDescuento = New System.Windows.Forms.CheckBox()
        Me.numExistencia = New C1.Win.C1Input.C1NumericEdit()
        Me.numTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.txtObervaciones = New System.Windows.Forms.TextBox()
        Me.txtSolicitudDescuento = New System.Windows.Forms.TextBox()
        Me.TabDescuento = New System.Windows.Forms.TabControl()
        Me.TabPageDescuento = New System.Windows.Forms.TabPage()
        Me.NumDescuento = New DevExpress.XtraEditors.SpinEdit()
        Me.chkAutorizar = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdProcesar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.numSubTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.numTotalDescuento = New C1.Win.C1Input.C1NumericEdit()
        Me.numIVA = New C1.Win.C1Input.C1NumericEdit()
        Me.numTotalC = New C1.Win.C1Input.C1NumericEdit()
        Me.numTotalD = New C1.Win.C1Input.C1NumericEdit()
        Me.ErrorFactura = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblCantidadMaxItems = New System.Windows.Forms.Label()
        Me.tabFacturas.SuspendLayout()
        Me.TabPageGenerales.SuspendLayout()
        CType(Me.cmbMotivoAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdExpedienteCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetalle.SuspendLayout()
        CType(Me.grdDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleFacturaTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnPrecioUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdtxtBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnPorcentajeDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDescuento.SuspendLayout()
        Me.TabPageDescuento.SuspendLayout()
        CType(Me.NumDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabFacturas
        '
        Me.tabFacturas.Controls.Add(Me.TabPageGenerales)
        Me.tabFacturas.Controls.Add(Me.TabPageCliente)
        Me.tabFacturas.Location = New System.Drawing.Point(5, 47)
        Me.tabFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFacturas.Name = "tabFacturas"
        Me.tabFacturas.SelectedIndex = 0
        Me.tabFacturas.Size = New System.Drawing.Size(1089, 198)
        Me.tabFacturas.TabIndex = 0
        '
        'TabPageGenerales
        '
        Me.TabPageGenerales.Controls.Add(Me.txtCodigoCliente)
        Me.TabPageGenerales.Controls.Add(Me.cmbMotivoAnular)
        Me.TabPageGenerales.Controls.Add(Me.lblMotivo)
        Me.TabPageGenerales.Controls.Add(Me.cmdAgregarCliente)
        Me.TabPageGenerales.Controls.Add(Me.cmdCliente)
        Me.TabPageGenerales.Controls.Add(Me.dtpFecha)
        Me.TabPageGenerales.Controls.Add(Me.cmbTPago)
        Me.TabPageGenerales.Controls.Add(Me.cmbBodega)
        Me.TabPageGenerales.Controls.Add(Me.cmbVendedor)
        Me.TabPageGenerales.Controls.Add(Me.cmbCliente)
        Me.TabPageGenerales.Controls.Add(Me.txtAtencionA)
        Me.TabPageGenerales.Controls.Add(Me.txtNumero)
        Me.TabPageGenerales.Controls.Add(Me.Label7)
        Me.TabPageGenerales.Controls.Add(Me.Label6)
        Me.TabPageGenerales.Controls.Add(Me.Label5)
        Me.TabPageGenerales.Controls.Add(Me.Label4)
        Me.TabPageGenerales.Controls.Add(Me.Label3)
        Me.TabPageGenerales.Controls.Add(Me.Label2)
        Me.TabPageGenerales.Controls.Add(Me.Label1)
        Me.TabPageGenerales.Location = New System.Drawing.Point(4, 25)
        Me.TabPageGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageGenerales.Name = "TabPageGenerales"
        Me.TabPageGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageGenerales.Size = New System.Drawing.Size(1081, 169)
        Me.TabPageGenerales.TabIndex = 0
        Me.TabPageGenerales.Text = "Datos Generales"
        Me.TabPageGenerales.UseVisualStyleBackColor = True
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(103, 59)
        Me.txtCodigoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(136, 22)
        Me.txtCodigoCliente.TabIndex = 20
        '
        'cmbMotivoAnular
        '
        Me.cmbMotivoAnular.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMotivoAnular.Caption = ""
        Me.cmbMotivoAnular.CaptionHeight = 17
        Me.cmbMotivoAnular.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMotivoAnular.ColumnCaptionHeight = 17
        Me.cmbMotivoAnular.ColumnFooterHeight = 17
        Me.cmbMotivoAnular.ColumnHeaders = False
        Me.cmbMotivoAnular.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMotivoAnular.ContentHeight = 18
        Me.cmbMotivoAnular.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMotivoAnular.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMotivoAnular.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMotivoAnular.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMotivoAnular.EditorHeight = 18
        Me.cmbMotivoAnular.Enabled = False
        Me.cmbMotivoAnular.Images.Add(CType(resources.GetObject("cmbMotivoAnular.Images"), System.Drawing.Image))
        Me.cmbMotivoAnular.ItemHeight = 15
        Me.cmbMotivoAnular.Location = New System.Drawing.Point(696, 97)
        Me.cmbMotivoAnular.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMotivoAnular.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMotivoAnular.MaxDropDownItems = CType(5, Short)
        Me.cmbMotivoAnular.MaxLength = 32767
        Me.cmbMotivoAnular.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMotivoAnular.Name = "cmbMotivoAnular"
        Me.cmbMotivoAnular.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMotivoAnular.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMotivoAnular.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMotivoAnular.Size = New System.Drawing.Size(229, 24)
        Me.cmbMotivoAnular.TabIndex = 19
        Me.cmbMotivoAnular.Visible = False
        Me.cmbMotivoAnular.PropBag = resources.GetString("cmbMotivoAnular.PropBag")
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(584, 106)
        Me.lblMotivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(98, 17)
        Me.lblMotivo.TabIndex = 18
        Me.lblMotivo.Text = "Motivo Anular:"
        Me.lblMotivo.Visible = False
        '
        'cmdAgregarCliente
        '
        Me.cmdAgregarCliente.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdAgregarCliente.Location = New System.Drawing.Point(541, 57)
        Me.cmdAgregarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregarCliente.Name = "cmdAgregarCliente"
        Me.cmdAgregarCliente.Size = New System.Drawing.Size(32, 27)
        Me.cmdAgregarCliente.TabIndex = 16
        Me.cmdAgregarCliente.Text = "..."
        Me.cmdAgregarCliente.UseVisualStyleBackColor = True
        '
        'cmdCliente
        '
        Me.cmdCliente.Location = New System.Drawing.Point(508, 57)
        Me.cmdCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCliente.Name = "cmdCliente"
        Me.cmdCliente.Size = New System.Drawing.Size(32, 27)
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
        Me.dtpFecha.Location = New System.Drawing.Point(663, 16)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(161, 22)
        Me.dtpFecha.TabIndex = 14
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cmbTPago
        '
        Me.cmbTPago.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTPago.Caption = ""
        Me.cmbTPago.CaptionHeight = 17
        Me.cmbTPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTPago.ColumnCaptionHeight = 17
        Me.cmbTPago.ColumnFooterHeight = 17
        Me.cmbTPago.ColumnHeaders = False
        Me.cmbTPago.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTPago.ContentHeight = 18
        Me.cmbTPago.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTPago.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTPago.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTPago.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTPago.EditorHeight = 18
        Me.cmbTPago.Images.Add(CType(resources.GetObject("cmbTPago.Images"), System.Drawing.Image))
        Me.cmbTPago.ItemHeight = 15
        Me.cmbTPago.Location = New System.Drawing.Point(900, 15)
        Me.cmbTPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTPago.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTPago.MaxDropDownItems = CType(5, Short)
        Me.cmbTPago.MaxLength = 32767
        Me.cmbTPago.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTPago.Name = "cmbTPago"
        Me.cmbTPago.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTPago.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTPago.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTPago.Size = New System.Drawing.Size(153, 24)
        Me.cmbTPago.TabIndex = 13
        Me.cmbTPago.PropBag = resources.GetString("cmbTPago.PropBag")
        '
        'cmbBodega
        '
        Me.cmbBodega.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodega.Caption = ""
        Me.cmbBodega.CaptionHeight = 17
        Me.cmbBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodega.ColumnCaptionHeight = 17
        Me.cmbBodega.ColumnFooterHeight = 17
        Me.cmbBodega.ColumnHeaders = False
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
        Me.cmbBodega.Location = New System.Drawing.Point(329, 16)
        Me.cmbBodega.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(173, 24)
        Me.cmbBodega.TabIndex = 12
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
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
        Me.cmbVendedor.ContentHeight = 18
        Me.cmbVendedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbVendedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbVendedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbVendedor.EditorHeight = 18
        Me.cmbVendedor.Enabled = False
        Me.cmbVendedor.Images.Add(CType(resources.GetObject("cmbVendedor.Images"), System.Drawing.Image))
        Me.cmbVendedor.ItemHeight = 15
        Me.cmbVendedor.Location = New System.Drawing.Point(696, 57)
        Me.cmbVendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbVendedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbVendedor.MaxDropDownItems = CType(5, Short)
        Me.cmbVendedor.MaxLength = 32767
        Me.cmbVendedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbVendedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbVendedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbVendedor.Size = New System.Drawing.Size(229, 24)
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
        Me.cmbCliente.ContentHeight = 18
        Me.cmbCliente.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCliente.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCliente.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCliente.EditorHeight = 18
        Me.cmbCliente.Images.Add(CType(resources.GetObject("cmbCliente.Images"), System.Drawing.Image))
        Me.cmbCliente.ItemHeight = 15
        Me.cmbCliente.Location = New System.Drawing.Point(248, 59)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCliente.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCliente.MaxDropDownItems = CType(5, Short)
        Me.cmbCliente.MaxLength = 32767
        Me.cmbCliente.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCliente.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCliente.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCliente.Size = New System.Drawing.Size(255, 24)
        Me.cmbCliente.TabIndex = 10
        Me.cmbCliente.PropBag = resources.GetString("cmbCliente.PropBag")
        '
        'txtAtencionA
        '
        Me.txtAtencionA.Location = New System.Drawing.Point(103, 97)
        Me.txtAtencionA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAtencionA.Name = "txtAtencionA"
        Me.txtAtencionA.Size = New System.Drawing.Size(399, 22)
        Me.txtAtencionA.TabIndex = 9
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(103, 16)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(107, 22)
        Me.txtNumero.TabIndex = 7
        Me.txtNumero.Tag = "BLOQUEADO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(829, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "T/Pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(584, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vendedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(584, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bodega:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Atención A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        '
        'TabPageCliente
        '
        Me.TabPageCliente.Controls.Add(Me.txtDireccion)
        Me.TabPageCliente.Controls.Add(Me.txtEmail)
        Me.TabPageCliente.Controls.Add(Me.txtTelefono)
        Me.TabPageCliente.Controls.Add(Me.GroupBox1)
        Me.TabPageCliente.Controls.Add(Me.Label10)
        Me.TabPageCliente.Controls.Add(Me.Label9)
        Me.TabPageCliente.Controls.Add(Me.Label8)
        Me.TabPageCliente.Location = New System.Drawing.Point(4, 25)
        Me.TabPageCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageCliente.Name = "TabPageCliente"
        Me.TabPageCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageCliente.Size = New System.Drawing.Size(1081, 169)
        Me.TabPageCliente.TabIndex = 1
        Me.TabPageCliente.Text = "Datos del Cliente"
        Me.TabPageCliente.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(125, 86)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(376, 53)
        Me.txtDireccion.TabIndex = 6
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(125, 54)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(307, 22)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.Tag = "BLOQUEADO"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(125, 21)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(307, 22)
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.Tag = "BLOQUEADO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdExpedienteCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(572, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(492, 151)
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
        Me.grdExpedienteCliente.Location = New System.Drawing.Point(4, 19)
        Me.grdExpedienteCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.grdExpedienteCliente.Name = "grdExpedienteCliente"
        Me.grdExpedienteCliente.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdExpedienteCliente.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdExpedienteCliente.PreviewInfo.ZoomFactor = 75.0R
        Me.grdExpedienteCliente.PrintInfo.PageSettings = CType(resources.GetObject("grdExpedienteCliente.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdExpedienteCliente.Size = New System.Drawing.Size(484, 128)
        Me.grdExpedienteCliente.TabIndex = 0
        Me.grdExpedienteCliente.Text = "C1TrueDBGrid1"
        Me.grdExpedienteCliente.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdExpedienteCliente.PropBag = resources.GetString("grdExpedienteCliente.PropBag")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 85)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 52)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Teléfonos:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1108, 39)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Tag = "LAYOUT"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 814)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1108, 27)
        Me.Panel1.TabIndex = 6
        '
        'grpDetalle
        '
        Me.grpDetalle.Controls.Add(Me.grdDetalleFactura)
        Me.grpDetalle.Location = New System.Drawing.Point(11, 297)
        Me.grpDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDetalle.Name = "grpDetalle"
        Me.grpDetalle.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDetalle.Size = New System.Drawing.Size(1084, 292)
        Me.grpDetalle.TabIndex = 7
        Me.grpDetalle.TabStop = False
        Me.grpDetalle.Text = "Detalle"
        '
        'grdDetalleFactura
        '
        Me.grdDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalleFactura.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalleFactura.Location = New System.Drawing.Point(4, 19)
        Me.grdDetalleFactura.LookAndFeel.SkinName = "Glass Oceans"
        Me.grdDetalleFactura.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.grdDetalleFactura.MainView = Me.grdDetalleFacturaTabla
        Me.grdDetalleFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalleFactura.Name = "grdDetalleFactura"
        Me.grdDetalleFactura.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grdtxtBarCode, Me.grdcmbDescripcion, Me.grdspnCantidad, Me.grdSpnPrecioUnitario, Me.grdspnSubTotal, Me.grdSpnDescuento, Me.grdspnPorcentajeDescuento, Me.grdspnTotal, Me.grdspnCodigoRepuesto})
        Me.grdDetalleFactura.Size = New System.Drawing.Size(1076, 269)
        Me.grdDetalleFactura.TabIndex = 0
        Me.grdDetalleFactura.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleFacturaTabla})
        '
        'grdDetalleFacturaTabla
        '
        Me.grdDetalleFacturaTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoRepuesto, Me.colDescripcion, Me.colCantidad, Me.colPrecioUnitario, Me.colSubtotal, Me.colDescuento, Me.colImpuesto, Me.colTotal})
        Me.grdDetalleFacturaTabla.GridControl = Me.grdDetalleFactura
        Me.grdDetalleFacturaTabla.Name = "grdDetalleFacturaTabla"
        Me.grdDetalleFacturaTabla.OptionsView.ShowGroupPanel = False
        '
        'colCodigoRepuesto
        '
        Me.colCodigoRepuesto.Caption = "Código"
        Me.colCodigoRepuesto.ColumnEdit = Me.grdspnCodigoRepuesto
        Me.colCodigoRepuesto.FieldName = "Codigo"
        Me.colCodigoRepuesto.Name = "colCodigoRepuesto"
        Me.colCodigoRepuesto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoRepuesto.OptionsFilter.AllowAutoFilter = False
        Me.colCodigoRepuesto.OptionsFilter.AllowFilter = False
        Me.colCodigoRepuesto.Visible = True
        Me.colCodigoRepuesto.VisibleIndex = 0
        Me.colCodigoRepuesto.Width = 66
        '
        'grdspnCodigoRepuesto
        '
        Me.grdspnCodigoRepuesto.AutoHeight = False
        Me.grdspnCodigoRepuesto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.grdspnCodigoRepuesto.Name = "grdspnCodigoRepuesto"
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
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 213
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
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 76
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
        'colPrecioUnitario
        '
        Me.colPrecioUnitario.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colPrecioUnitario.AppearanceCell.Options.UseBackColor = True
        Me.colPrecioUnitario.Caption = "Precio U."
        Me.colPrecioUnitario.ColumnEdit = Me.grdSpnPrecioUnitario
        Me.colPrecioUnitario.FieldName = "Precio"
        Me.colPrecioUnitario.Name = "colPrecioUnitario"
        Me.colPrecioUnitario.OptionsColumn.AllowFocus = False
        Me.colPrecioUnitario.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPrecioUnitario.OptionsColumn.ReadOnly = True
        Me.colPrecioUnitario.OptionsFilter.AllowAutoFilter = False
        Me.colPrecioUnitario.OptionsFilter.AllowFilter = False
        Me.colPrecioUnitario.Visible = True
        Me.colPrecioUnitario.VisibleIndex = 3
        Me.colPrecioUnitario.Width = 61
        '
        'grdSpnPrecioUnitario
        '
        Me.grdSpnPrecioUnitario.AutoHeight = False
        Me.grdSpnPrecioUnitario.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.grdSpnPrecioUnitario.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdSpnPrecioUnitario.Name = "grdSpnPrecioUnitario"
        '
        'colSubtotal
        '
        Me.colSubtotal.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colSubtotal.AppearanceCell.Options.UseBackColor = True
        Me.colSubtotal.Caption = "Subtotal"
        Me.colSubtotal.ColumnEdit = Me.grdspnSubTotal
        Me.colSubtotal.FieldName = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.OptionsColumn.AllowFocus = False
        Me.colSubtotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSubtotal.OptionsColumn.ReadOnly = True
        Me.colSubtotal.OptionsFilter.AllowAutoFilter = False
        Me.colSubtotal.OptionsFilter.AllowFilter = False
        Me.colSubtotal.Visible = True
        Me.colSubtotal.VisibleIndex = 4
        Me.colSubtotal.Width = 61
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
        'colDescuento
        '
        Me.colDescuento.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colDescuento.AppearanceCell.Options.UseBackColor = True
        Me.colDescuento.Caption = "Descuento"
        Me.colDescuento.ColumnEdit = Me.grdSpnDescuento
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.OptionsColumn.AllowFocus = False
        Me.colDescuento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescuento.OptionsColumn.ReadOnly = True
        Me.colDescuento.OptionsFilter.AllowAutoFilter = False
        Me.colDescuento.OptionsFilter.AllowFilter = False
        Me.colDescuento.Visible = True
        Me.colDescuento.VisibleIndex = 5
        Me.colDescuento.Width = 61
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
        'colImpuesto
        '
        Me.colImpuesto.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colImpuesto.AppearanceCell.Options.UseBackColor = True
        Me.colImpuesto.Caption = "IVA"
        Me.colImpuesto.ColumnEdit = Me.grdspnTotal
        Me.colImpuesto.FieldName = "Impuesto"
        Me.colImpuesto.Name = "colImpuesto"
        Me.colImpuesto.OptionsColumn.AllowFocus = False
        Me.colImpuesto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colImpuesto.OptionsColumn.ReadOnly = True
        Me.colImpuesto.OptionsFilter.AllowAutoFilter = False
        Me.colImpuesto.OptionsFilter.AllowFilter = False
        Me.colImpuesto.Visible = True
        Me.colImpuesto.VisibleIndex = 6
        Me.colImpuesto.Width = 46
        '
        'grdspnTotal
        '
        Me.grdspnTotal.AutoHeight = False
        Me.grdspnTotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, False)})
        Me.grdspnTotal.DisplayFormat.FormatString = "#0.#0"
        Me.grdspnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnTotal.EditFormat.FormatString = "#0.#0"
        Me.grdspnTotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnTotal.Name = "grdspnTotal"
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
        Me.colTotal.VisibleIndex = 7
        Me.colTotal.Width = 68
        '
        'grdtxtBarCode
        '
        Me.grdtxtBarCode.AutoHeight = False
        Me.grdtxtBarCode.Name = "grdtxtBarCode"
        '
        'grdspnPorcentajeDescuento
        '
        Me.grdspnPorcentajeDescuento.AutoHeight = False
        Me.grdspnPorcentajeDescuento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinRight, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.grdspnPorcentajeDescuento.DisplayFormat.FormatString = "#0.#0"
        Me.grdspnPorcentajeDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnPorcentajeDescuento.EditFormat.FormatString = "#0.#0"
        Me.grdspnPorcentajeDescuento.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnPorcentajeDescuento.Name = "grdspnPorcentajeDescuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(332, 271)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Prima:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(563, 271)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Saldo:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdBuscar.Location = New System.Drawing.Point(1037, 271)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(53, 28)
        Me.cmdBuscar.TabIndex = 11
        Me.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'numSaldo
        '
        Me.numSaldo.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numSaldo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numSaldo.EditFormat.CustomFormat = "#,##0.00"
        Me.numSaldo.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSaldo.Location = New System.Drawing.Point(620, 265)
        Me.numSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.numSaldo.Name = "numSaldo"
        Me.numSaldo.Size = New System.Drawing.Size(144, 22)
        Me.numSaldo.TabIndex = 12
        Me.numSaldo.Tag = Nothing
        Me.numSaldo.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numPrima
        '
        Me.numPrima.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numPrima.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numPrima.EditFormat.CustomFormat = "#,##0.00"
        Me.numPrima.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numPrima.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numPrima.Location = New System.Drawing.Point(389, 265)
        Me.numPrima.Margin = New System.Windows.Forms.Padding(4)
        Me.numPrima.Name = "numPrima"
        Me.numPrima.Size = New System.Drawing.Size(139, 22)
        Me.numPrima.TabIndex = 13
        Me.numPrima.Tag = Nothing
        Me.numPrima.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numPrima.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 601)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Existencia:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(265, 601)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "T/C:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 645)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(249, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Observaciones Condiciones de Venta:"
        '
        'chkSolicitudDescuento
        '
        Me.chkSolicitudDescuento.AutoSize = True
        Me.chkSolicitudDescuento.Location = New System.Drawing.Point(553, 596)
        Me.chkSolicitudDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSolicitudDescuento.Name = "chkSolicitudDescuento"
        Me.chkSolicitudDescuento.Size = New System.Drawing.Size(197, 21)
        Me.chkSolicitudDescuento.TabIndex = 17
        Me.chkSolicitudDescuento.Text = "Solicitud Autor. Descuento"
        Me.chkSolicitudDescuento.UseVisualStyleBackColor = True
        '
        'numExistencia
        '
        Me.numExistencia.DisplayFormat.CustomFormat = "#0"
        Me.numExistencia.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.numExistencia.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numExistencia.EditFormat.CustomFormat = "#0"
        Me.numExistencia.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.numExistencia.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numExistencia.Enabled = False
        Me.numExistencia.Location = New System.Drawing.Point(111, 597)
        Me.numExistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.numExistencia.Name = "numExistencia"
        Me.numExistencia.Size = New System.Drawing.Size(133, 22)
        Me.numExistencia.TabIndex = 18
        Me.numExistencia.Tag = "BLOQUEADO"
        Me.numExistencia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numTasa
        '
        Me.numTasa.DisplayFormat.CustomFormat = "#0.#0"
        Me.numTasa.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.numTasa.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTasa.EditFormat.CustomFormat = "#0.#0"
        Me.numTasa.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.numTasa.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTasa.Enabled = False
        Me.numTasa.Location = New System.Drawing.Point(312, 597)
        Me.numTasa.Margin = New System.Windows.Forms.Padding(4)
        Me.numTasa.Name = "numTasa"
        Me.numTasa.Size = New System.Drawing.Size(143, 22)
        Me.numTasa.TabIndex = 19
        Me.numTasa.Tag = "BLOQUEADO"
        Me.numTasa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtObervaciones
        '
        Me.txtObervaciones.Location = New System.Drawing.Point(35, 665)
        Me.txtObervaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObervaciones.Multiline = True
        Me.txtObervaciones.Name = "txtObervaciones"
        Me.txtObervaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObervaciones.Size = New System.Drawing.Size(419, 68)
        Me.txtObervaciones.TabIndex = 20
        '
        'txtSolicitudDescuento
        '
        Me.txtSolicitudDescuento.Enabled = False
        Me.txtSolicitudDescuento.Location = New System.Drawing.Point(528, 624)
        Me.txtSolicitudDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSolicitudDescuento.Multiline = True
        Me.txtSolicitudDescuento.Name = "txtSolicitudDescuento"
        Me.txtSolicitudDescuento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSolicitudDescuento.Size = New System.Drawing.Size(256, 51)
        Me.txtSolicitudDescuento.TabIndex = 21
        '
        'TabDescuento
        '
        Me.TabDescuento.Controls.Add(Me.TabPageDescuento)
        Me.TabDescuento.Location = New System.Drawing.Point(528, 683)
        Me.TabDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.TabDescuento.Name = "TabDescuento"
        Me.TabDescuento.SelectedIndex = 0
        Me.TabDescuento.Size = New System.Drawing.Size(188, 106)
        Me.TabDescuento.TabIndex = 22
        '
        'TabPageDescuento
        '
        Me.TabPageDescuento.Controls.Add(Me.NumDescuento)
        Me.TabPageDescuento.Controls.Add(Me.chkAutorizar)
        Me.TabPageDescuento.Location = New System.Drawing.Point(4, 25)
        Me.TabPageDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageDescuento.Name = "TabPageDescuento"
        Me.TabPageDescuento.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageDescuento.Size = New System.Drawing.Size(180, 77)
        Me.TabPageDescuento.TabIndex = 0
        Me.TabPageDescuento.Text = "Descuento"
        Me.TabPageDescuento.UseVisualStyleBackColor = True
        '
        'NumDescuento
        '
        Me.NumDescuento.AllowDrop = True
        Me.NumDescuento.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumDescuento.Location = New System.Drawing.Point(9, 25)
        Me.NumDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.NumDescuento.Name = "NumDescuento"
        Me.NumDescuento.Properties.DisplayFormat.FormatString = "$#,##0.00"
        Me.NumDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.NumDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NumDescuento.Properties.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumDescuento.Size = New System.Drawing.Size(135, 22)
        Me.NumDescuento.TabIndex = 71
        '
        'chkAutorizar
        '
        Me.chkAutorizar.AutoSize = True
        Me.chkAutorizar.Enabled = False
        Me.chkAutorizar.Location = New System.Drawing.Point(9, 49)
        Me.chkAutorizar.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAutorizar.Name = "chkAutorizar"
        Me.chkAutorizar.Size = New System.Drawing.Size(87, 21)
        Me.chkAutorizar.TabIndex = 21
        Me.chkAutorizar.Text = "Autorizar"
        Me.chkAutorizar.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(884, 601)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 17)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Sub Total:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(884, 633)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Descuento:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(884, 665)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 17)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "IVA:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(884, 694)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 17)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Total C$:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(881, 725)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 17)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Total US$:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(769, 770)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(100, 34)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdProcesar
        '
        Me.cmdProcesar.BackgroundImage = Global.SIFAC.My.Resources.Resources.Aprobar
        Me.cmdProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdProcesar.Enabled = False
        Me.cmdProcesar.Location = New System.Drawing.Point(877, 770)
        Me.cmdProcesar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(100, 34)
        Me.cmdProcesar.TabIndex = 29
        Me.cmdProcesar.Text = "Procesar"
        Me.cmdProcesar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(985, 770)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 30
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'numSubTotal
        '
        Me.numSubTotal.BackColor = System.Drawing.SystemColors.Info
        Me.numSubTotal.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numSubTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSubTotal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numSubTotal.Enabled = False
        Me.numSubTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSubTotal.Location = New System.Drawing.Point(973, 597)
        Me.numSubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.numSubTotal.Name = "numSubTotal"
        Me.numSubTotal.Size = New System.Drawing.Size(111, 22)
        Me.numSubTotal.TabIndex = 31
        Me.numSubTotal.Tag = "BLOQUEADO"
        Me.numSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSubTotal.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numSubTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numTotalDescuento
        '
        Me.numTotalDescuento.BackColor = System.Drawing.SystemColors.Info
        Me.numTotalDescuento.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numTotalDescuento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalDescuento.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotalDescuento.Enabled = False
        Me.numTotalDescuento.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalDescuento.Location = New System.Drawing.Point(973, 629)
        Me.numTotalDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.numTotalDescuento.Name = "numTotalDescuento"
        Me.numTotalDescuento.Size = New System.Drawing.Size(111, 22)
        Me.numTotalDescuento.TabIndex = 32
        Me.numTotalDescuento.Tag = "BLOQUEADO"
        Me.numTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotalDescuento.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTotalDescuento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numIVA
        '
        Me.numIVA.BackColor = System.Drawing.SystemColors.Info
        Me.numIVA.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numIVA.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numIVA.Enabled = False
        Me.numIVA.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numIVA.Location = New System.Drawing.Point(973, 661)
        Me.numIVA.Margin = New System.Windows.Forms.Padding(4)
        Me.numIVA.Name = "numIVA"
        Me.numIVA.Size = New System.Drawing.Size(111, 22)
        Me.numIVA.TabIndex = 33
        Me.numIVA.Tag = "BLOQUEADO"
        Me.numIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numIVA.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numIVA.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numTotalC
        '
        Me.numTotalC.BackColor = System.Drawing.SystemColors.Info
        Me.numTotalC.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numTotalC.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalC.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotalC.Enabled = False
        Me.numTotalC.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalC.Location = New System.Drawing.Point(973, 690)
        Me.numTotalC.Margin = New System.Windows.Forms.Padding(4)
        Me.numTotalC.Name = "numTotalC"
        Me.numTotalC.Size = New System.Drawing.Size(111, 22)
        Me.numTotalC.TabIndex = 34
        Me.numTotalC.Tag = "BLOQUEADO"
        Me.numTotalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotalC.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTotalC.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numTotalD
        '
        Me.numTotalD.BackColor = System.Drawing.SystemColors.Info
        Me.numTotalD.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numTotalD.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalD.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotalD.Enabled = False
        Me.numTotalD.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalD.Location = New System.Drawing.Point(973, 721)
        Me.numTotalD.Margin = New System.Windows.Forms.Padding(4)
        Me.numTotalD.Name = "numTotalD"
        Me.numTotalD.Size = New System.Drawing.Size(111, 22)
        Me.numTotalD.TabIndex = 35
        Me.numTotalD.Tag = "BLOQUEADO"
        Me.numTotalD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotalD.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTotalD.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'ErrorFactura
        '
        Me.ErrorFactura.ContainerControl = Me
        '
        'lblCantidadMaxItems
        '
        Me.lblCantidadMaxItems.AutoSize = True
        Me.lblCantidadMaxItems.BackColor = System.Drawing.SystemColors.Control
        Me.lblCantidadMaxItems.ForeColor = System.Drawing.Color.Gray
        Me.lblCantidadMaxItems.Location = New System.Drawing.Point(11, 785)
        Me.lblCantidadMaxItems.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidadMaxItems.Name = "lblCantidadMaxItems"
        Me.lblCantidadMaxItems.Size = New System.Drawing.Size(272, 17)
        Me.lblCantidadMaxItems.TabIndex = 121
        Me.lblCantidadMaxItems.Tag = ""
        Me.lblCantidadMaxItems.Text = "Cantidad Máxima de repuestos en detalle:"
        '
        'frmSfaFacturaRepuestosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 841)
        Me.Controls.Add(Me.lblCantidadMaxItems)
        Me.Controls.Add(Me.numTotalD)
        Me.Controls.Add(Me.numTotalC)
        Me.Controls.Add(Me.numIVA)
        Me.Controls.Add(Me.numTotalDescuento)
        Me.Controls.Add(Me.numSubTotal)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdProcesar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TabDescuento)
        Me.Controls.Add(Me.txtSolicitudDescuento)
        Me.Controls.Add(Me.txtObervaciones)
        Me.Controls.Add(Me.numTasa)
        Me.Controls.Add(Me.numExistencia)
        Me.Controls.Add(Me.chkSolicitudDescuento)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.numPrima)
        Me.Controls.Add(Me.numSaldo)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.grpDetalle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabFacturas)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaFacturaRepuestosEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Factura"
        Me.tabFacturas.ResumeLayout(False)
        Me.TabPageGenerales.ResumeLayout(False)
        Me.TabPageGenerales.PerformLayout()
        CType(Me.cmbMotivoAnular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCliente.ResumeLayout(False)
        Me.TabPageCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdExpedienteCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetalle.ResumeLayout(False)
        CType(Me.grdDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleFacturaTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnPrecioUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdtxtBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnPorcentajeDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDescuento.ResumeLayout(False)
        Me.TabPageDescuento.ResumeLayout(False)
        Me.TabPageDescuento.PerformLayout()
        CType(Me.NumDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabFacturas As System.Windows.Forms.TabControl
    Friend WithEvents TabPageGenerales As System.Windows.Forms.TabPage
    Friend WithEvents TabPageCliente As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbTPago As C1.Win.C1List.C1Combo
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents cmbVendedor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCliente As C1.Win.C1List.C1Combo
    Friend WithEvents txtAtencionA As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdCliente As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grdExpedienteCliente As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grpDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents numSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numPrima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkSolicitudDescuento As System.Windows.Forms.CheckBox
    Friend WithEvents numExistencia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtObervaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtSolicitudDescuento As System.Windows.Forms.TextBox
    Friend WithEvents TabDescuento As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDescuento As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdProcesar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents numSubTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numTotalDescuento As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numIVA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numTotalC As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numTotalD As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkAutorizar As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents ErrorFactura As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbMotivoAnular As C1.Win.C1List.C1Combo
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents grdDetalleFactura As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleFacturaTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoRepuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImpuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdtxtBarCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grdcmbDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grdspnCantidad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdSpnPrecioUnitario As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnSubTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdSpnDescuento As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnPorcentajeDescuento As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents lblCantidadMaxItems As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents NumDescuento As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents grdspnCodigoRepuesto As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
