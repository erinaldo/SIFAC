<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccEditReciboCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccEditReciboCaja))
        Me.tbControl = New System.Windows.Forms.TabControl()
        Me.tbpDetFact = New System.Windows.Forms.TabPage()
        Me.grdNotaDebito = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbpFormasPago = New System.Windows.Forms.TabPage()
        Me.grdNotasCredito = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.grpFormaPago = New System.Windows.Forms.GroupBox()
        Me.NumMontoDolares = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cmbMoneda = New C1.Win.C1List.C1Combo()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalFact = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtTotalFact = New C1.Win.C1Input.C1NumericEdit()
        Me.txtTotalPagar = New C1.Win.C1Input.C1NumericEdit()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpDatosRecibos = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumRecibo = New System.Windows.Forms.TextBox()
        Me.lblRecibo = New System.Windows.Forms.Label()
        Me.GrpExpediente = New System.Windows.Forms.GroupBox()
        Me.chkPrima = New System.Windows.Forms.CheckBox()
        Me.cmdExpediente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMontRest = New System.Windows.Forms.Label()
        Me.lblMontAbon = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMontoRestante = New System.Windows.Forms.Label()
        Me.lblMontoAbonado = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbRuta = New C1.Win.C1List.C1Combo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxCobrador = New C1.Win.C1List.C1Combo()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cmProcesar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.tbControl.SuspendLayout()
        Me.tbpDetFact.SuspendLayout()
        CType(Me.grdNotaDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpFormasPago.SuspendLayout()
        CType(Me.grdNotasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFormaPago.SuspendLayout()
        CType(Me.NumMontoDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosRecibos.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpExpediente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCobrador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbControl
        '
        Me.tbControl.Controls.Add(Me.tbpDetFact)
        Me.tbControl.Controls.Add(Me.tbpFormasPago)
        Me.tbControl.Location = New System.Drawing.Point(0, 158)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.SelectedIndex = 0
        Me.tbControl.Size = New System.Drawing.Size(642, 249)
        Me.tbControl.TabIndex = 2
        '
        'tbpDetFact
        '
        Me.tbpDetFact.Controls.Add(Me.grdNotaDebito)
        Me.tbpDetFact.Controls.Add(Me.grdFacturas)
        Me.tbpDetFact.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetFact.Name = "tbpDetFact"
        Me.tbpDetFact.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetFact.Size = New System.Drawing.Size(634, 223)
        Me.tbpDetFact.TabIndex = 0
        Me.tbpDetFact.Text = "Detalle de Facturas"
        Me.tbpDetFact.UseVisualStyleBackColor = True
        '
        'grdNotaDebito
        '
        Me.grdNotaDebito.AllowColMove = False
        Me.grdNotaDebito.Caption = "Notas de Débito"
        Me.grdNotaDebito.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdNotaDebito.ExtendRightColumn = True
        Me.grdNotaDebito.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdNotaDebito.Images.Add(CType(resources.GetObject("grdNotaDebito.Images"), System.Drawing.Image))
        Me.grdNotaDebito.Location = New System.Drawing.Point(3, 125)
        Me.grdNotaDebito.Name = "grdNotaDebito"
        Me.grdNotaDebito.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdNotaDebito.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdNotaDebito.PreviewInfo.ZoomFactor = 75.0R
        Me.grdNotaDebito.PrintInfo.PageSettings = CType(resources.GetObject("grdNotaDebito.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdNotaDebito.Size = New System.Drawing.Size(628, 101)
        Me.grdNotaDebito.TabIndex = 11
        Me.grdNotaDebito.PropBag = resources.GetString("grdNotaDebito.PropBag")
        '
        'grdFacturas
        '
        Me.grdFacturas.AllowColMove = False
        Me.grdFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdFacturas.Caption = "Facturas"
        Me.grdFacturas.CausesValidation = False
        Me.grdFacturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdFacturas.ExtendRightColumn = True
        Me.grdFacturas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(3, 3)
        Me.grdFacturas.MaintainRowCurrency = True
        Me.grdFacturas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(628, 122)
        Me.grdFacturas.TabIndex = 7
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'tbpFormasPago
        '
        Me.tbpFormasPago.Controls.Add(Me.grdNotasCredito)
        Me.tbpFormasPago.Controls.Add(Me.grpFormaPago)
        Me.tbpFormasPago.Controls.Add(Me.cmdEliminar)
        Me.tbpFormasPago.Location = New System.Drawing.Point(4, 22)
        Me.tbpFormasPago.Name = "tbpFormasPago"
        Me.tbpFormasPago.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFormasPago.Size = New System.Drawing.Size(634, 223)
        Me.tbpFormasPago.TabIndex = 2
        Me.tbpFormasPago.Text = "Pago"
        Me.tbpFormasPago.UseVisualStyleBackColor = True
        '
        'grdNotasCredito
        '
        Me.grdNotasCredito.AllowColMove = False
        Me.grdNotasCredito.Caption = "Notas de Crédito"
        Me.grdNotasCredito.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdNotasCredito.ExtendRightColumn = True
        Me.grdNotasCredito.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdNotasCredito.Images.Add(CType(resources.GetObject("grdNotasCredito.Images"), System.Drawing.Image))
        Me.grdNotasCredito.Location = New System.Drawing.Point(3, 3)
        Me.grdNotasCredito.Name = "grdNotasCredito"
        Me.grdNotasCredito.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdNotasCredito.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdNotasCredito.PreviewInfo.ZoomFactor = 75.0R
        Me.grdNotasCredito.PrintInfo.PageSettings = CType(resources.GetObject("grdNotasCredito.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdNotasCredito.Size = New System.Drawing.Size(628, 119)
        Me.grdNotasCredito.TabIndex = 15
        Me.grdNotasCredito.PropBag = resources.GetString("grdNotasCredito.PropBag")
        '
        'grpFormaPago
        '
        Me.grpFormaPago.Controls.Add(Me.NumMontoDolares)
        Me.grpFormaPago.Controls.Add(Me.Label7)
        Me.grpFormaPago.Location = New System.Drawing.Point(8, 135)
        Me.grpFormaPago.Name = "grpFormaPago"
        Me.grpFormaPago.Size = New System.Drawing.Size(620, 61)
        Me.grpFormaPago.TabIndex = 14
        Me.grpFormaPago.TabStop = False
        Me.grpFormaPago.Text = "Pago en Efectivo"
        '
        'NumMontoDolares
        '
        Me.NumMontoDolares.BackColor = System.Drawing.Color.Transparent
        Me.NumMontoDolares.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumMontoDolares.Location = New System.Drawing.Point(56, 28)
        Me.NumMontoDolares.Name = "NumMontoDolares"
        Me.NumMontoDolares.Size = New System.Drawing.Size(147, 20)
        Me.NumMontoDolares.TabIndex = 17
        Me.NumMontoDolares.Tag = Nothing
        Me.NumMontoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumMontoDolares.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.NumMontoDolares.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Monto:"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.ImageIndex = 0
        Me.cmdEliminar.ImageList = Me.ListaImagenes
        Me.cmdEliminar.Location = New System.Drawing.Point(6, 304)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(31, 26)
        Me.cmdEliminar.TabIndex = 13
        Me.cmdEliminar.Tag = ""
        Me.cmdEliminar.Text = "&D"
        Me.ToolTip1.SetToolTip(Me.cmdEliminar, "Eliminar formas de pago")
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'ListaImagenes
        '
        Me.ListaImagenes.ImageStream = CType(resources.GetObject("ListaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenes.Images.SetKeyName(0, "Eliminar.ico")
        '
        'cmbMoneda
        '
        Me.cmbMoneda.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMoneda.Caption = ""
        Me.cmbMoneda.CaptionHeight = 17
        Me.cmbMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMoneda.ColumnCaptionHeight = 17
        Me.cmbMoneda.ColumnFooterHeight = 17
        Me.cmbMoneda.ColumnHeaders = False
        Me.cmbMoneda.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMoneda.ContentHeight = 15
        Me.cmbMoneda.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMoneda.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMoneda.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMoneda.EditorHeight = 15
        Me.cmbMoneda.Images.Add(CType(resources.GetObject("cmbMoneda.Images"), System.Drawing.Image))
        Me.cmbMoneda.ItemHeight = 15
        Me.cmbMoneda.Location = New System.Drawing.Point(160, 16)
        Me.cmbMoneda.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMoneda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoneda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoneda.MaxLength = 32767
        Me.cmbMoneda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoneda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoneda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoneda.Size = New System.Drawing.Size(208, 21)
        Me.cmbMoneda.TabIndex = 10
        Me.cmbMoneda.PropBag = resources.GetString("cmbMoneda.PropBag")
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(29, 20)
        Me.lblMoneda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(120, 17)
        Me.lblMoneda.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Pagar:"
        '
        'lblTotalFact
        '
        Me.lblTotalFact.AutoSize = True
        Me.lblTotalFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFact.Location = New System.Drawing.Point(402, 419)
        Me.lblTotalFact.Name = "lblTotalFact"
        Me.lblTotalFact.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalFact.TabIndex = 7
        Me.lblTotalFact.Text = "Total Fact:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblError.Location = New System.Drawing.Point(12, 448)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(18, 18)
        Me.lblError.TabIndex = 14
        '
        'txtTotalFact
        '
        Me.txtTotalFact.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalFact.DisplayFormat.CustomFormat = "$ #,##0.00"
        Me.txtTotalFact.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalFact.Enabled = False
        Me.txtTotalFact.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalFact.Location = New System.Drawing.Point(489, 417)
        Me.txtTotalFact.Name = "txtTotalFact"
        Me.txtTotalFact.Size = New System.Drawing.Size(123, 20)
        Me.txtTotalFact.TabIndex = 15
        Me.txtTotalFact.Tag = "BLOQUEADO"
        Me.txtTotalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalFact.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalFact.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalPagar.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalPagar.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalPagar.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalPagar.Enabled = False
        Me.txtTotalPagar.FormatType = C1.Win.C1Input.FormatTypeEnum.Percent
        Me.txtTotalPagar.Location = New System.Drawing.Point(489, 441)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(123, 20)
        Me.txtTotalPagar.TabIndex = 17
        Me.txtTotalPagar.Tag = "BLOQUEADO"
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalPagar.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalPagar.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'grpDatosRecibos
        '
        Me.grpDatosRecibos.Controls.Add(Me.Label8)
        Me.grpDatosRecibos.Controls.Add(Me.txtEstado)
        Me.grpDatosRecibos.Controls.Add(Me.dtpFecha)
        Me.grpDatosRecibos.Controls.Add(Me.Label1)
        Me.grpDatosRecibos.Controls.Add(Me.txtNumRecibo)
        Me.grpDatosRecibos.Controls.Add(Me.lblRecibo)
        Me.grpDatosRecibos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosRecibos.Location = New System.Drawing.Point(7, 12)
        Me.grpDatosRecibos.Name = "grpDatosRecibos"
        Me.grpDatosRecibos.Size = New System.Drawing.Size(241, 98)
        Me.grpDatosRecibos.TabIndex = 19
        Me.grpDatosRecibos.TabStop = False
        Me.grpDatosRecibos.Text = "&DatosRecibos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(73, 43)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(159, 20)
        Me.txtEstado.TabIndex = 5
        Me.txtEstado.Tag = "BLOQUEADO"
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
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 10, 3, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.Location = New System.Drawing.Point(73, 69)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(160, 20)
        Me.dtpFecha.TabIndex = 4
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Fecha:"
        '
        'txtNumRecibo
        '
        Me.txtNumRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRecibo.Location = New System.Drawing.Point(73, 17)
        Me.txtNumRecibo.Name = "txtNumRecibo"
        Me.txtNumRecibo.Size = New System.Drawing.Size(159, 20)
        Me.txtNumRecibo.TabIndex = 1
        Me.txtNumRecibo.Tag = ""
        '
        'lblRecibo
        '
        Me.lblRecibo.AutoSize = True
        Me.lblRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecibo.ForeColor = System.Drawing.Color.Black
        Me.lblRecibo.Location = New System.Drawing.Point(6, 20)
        Me.lblRecibo.Name = "lblRecibo"
        Me.lblRecibo.Size = New System.Drawing.Size(71, 13)
        Me.lblRecibo.TabIndex = 0
        Me.lblRecibo.Tag = "OBLIGATORIO"
        Me.lblRecibo.Text = "No.Recibo:"
        '
        'GrpExpediente
        '
        Me.GrpExpediente.Controls.Add(Me.chkPrima)
        Me.GrpExpediente.Controls.Add(Me.cmdExpediente)
        Me.GrpExpediente.Controls.Add(Me.txtCliente)
        Me.GrpExpediente.Controls.Add(Me.Label4)
        Me.GrpExpediente.Controls.Add(Me.txtNumCuenta)
        Me.GrpExpediente.Controls.Add(Me.Label5)
        Me.GrpExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpExpediente.Location = New System.Drawing.Point(273, 12)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Size = New System.Drawing.Size(367, 98)
        Me.GrpExpediente.TabIndex = 18
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos Expediente"
        '
        'chkPrima
        '
        Me.chkPrima.AutoSize = True
        Me.chkPrima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrima.ForeColor = System.Drawing.Color.Black
        Me.chkPrima.Location = New System.Drawing.Point(19, 75)
        Me.chkPrima.Name = "chkPrima"
        Me.chkPrima.Size = New System.Drawing.Size(119, 17)
        Me.chkPrima.TabIndex = 22
        Me.chkPrima.Text = "Recibo de Prima"
        Me.chkPrima.UseVisualStyleBackColor = True
        '
        'cmdExpediente
        '
        Me.cmdExpediente.Location = New System.Drawing.Point(325, 14)
        Me.cmdExpediente.Name = "cmdExpediente"
        Me.cmdExpediente.Size = New System.Drawing.Size(24, 23)
        Me.cmdExpediente.TabIndex = 6
        Me.cmdExpediente.Text = "..."
        Me.cmdExpediente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(86, 44)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(263, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Tag = "OBLIGATORIO"
        Me.Label4.Text = "Cliente:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuenta.Location = New System.Drawing.Point(155, 17)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(163, 20)
        Me.txtNumCuenta.TabIndex = 3
        Me.txtNumCuenta.Tag = "BLOQUEADO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Tag = "OBLIGATORIO"
        Me.Label5.Text = "No. Exp:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMontRest)
        Me.GroupBox1.Controls.Add(Me.lblMontAbon)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblMontoRestante)
        Me.GroupBox1.Controls.Add(Me.lblMontoAbonado)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 437)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 59)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculadora"
        '
        'lblMontRest
        '
        Me.lblMontRest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontRest.Location = New System.Drawing.Point(110, 37)
        Me.lblMontRest.Name = "lblMontRest"
        Me.lblMontRest.Size = New System.Drawing.Size(109, 16)
        Me.lblMontRest.TabIndex = 27
        Me.lblMontRest.Tag = "LAYOUT"
        '
        'lblMontAbon
        '
        Me.lblMontAbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontAbon.Location = New System.Drawing.Point(110, 17)
        Me.lblMontAbon.Name = "lblMontAbon"
        Me.lblMontAbon.Size = New System.Drawing.Size(109, 16)
        Me.lblMontAbon.TabIndex = 26
        Me.lblMontAbon.Tag = "LAYOUT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Monto Abarcado:"
        '
        'lblMontoRestante
        '
        Me.lblMontoRestante.AutoSize = True
        Me.lblMontoRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoRestante.ForeColor = System.Drawing.Color.Black
        Me.lblMontoRestante.Location = New System.Drawing.Point(9, 40)
        Me.lblMontoRestante.Name = "lblMontoRestante"
        Me.lblMontoRestante.Size = New System.Drawing.Size(101, 13)
        Me.lblMontoRestante.TabIndex = 23
        Me.lblMontoRestante.Text = "Monto Restante:"
        '
        'lblMontoAbonado
        '
        Me.lblMontoAbonado.AutoSize = True
        Me.lblMontoAbonado.Location = New System.Drawing.Point(-96, 24)
        Me.lblMontoAbonado.Name = "lblMontoAbonado"
        Me.lblMontoAbonado.Size = New System.Drawing.Size(86, 13)
        Me.lblMontoAbonado.TabIndex = 21
        Me.lblMontoAbonado.Text = "Monto Abonado:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 513)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 18)
        Me.Panel1.TabIndex = 22
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmbRuta)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.cbxCobrador)
        Me.PanelControl1.Controls.Add(Me.lblMarca)
        Me.PanelControl1.Controls.Add(Me.cmProcesar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.tbControl)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.grpDatosRecibos)
        Me.PanelControl1.Controls.Add(Me.GrpExpediente)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(648, 531)
        Me.PanelControl1.TabIndex = 99
        '
        'cmbRuta
        '
        Me.cmbRuta.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbRuta.AllowColMove = False
        Me.cmbRuta.AllowSort = False
        Me.cmbRuta.Caption = ""
        Me.cmbRuta.CaptionHeight = 17
        Me.cmbRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbRuta.ColumnCaptionHeight = 17
        Me.cmbRuta.ColumnFooterHeight = 17
        Me.cmbRuta.ColumnHeaders = False
        Me.cmbRuta.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbRuta.ContentHeight = 15
        Me.cmbRuta.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbRuta.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbRuta.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRuta.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRuta.EditorHeight = 15
        Me.cmbRuta.Enabled = False
        Me.cmbRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRuta.Images.Add(CType(resources.GetObject("cmbRuta.Images"), System.Drawing.Image))
        Me.cmbRuta.ItemHeight = 15
        Me.cmbRuta.Location = New System.Drawing.Point(333, 124)
        Me.cmbRuta.MatchEntryTimeout = CType(2000, Long)
        Me.cmbRuta.MaxDropDownItems = CType(5, Short)
        Me.cmbRuta.MaxLength = 32767
        Me.cmbRuta.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbRuta.Name = "cmbRuta"
        Me.cmbRuta.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbRuta.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbRuta.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbRuta.Size = New System.Drawing.Size(302, 21)
        Me.cmbRuta.TabIndex = 127
        Me.cmbRuta.Tag = "OBLIGATORIO"
        Me.cmbRuta.PropBag = resources.GetString("cmbRuta.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(289, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Ruta:"
        '
        'cbxCobrador
        '
        Me.cbxCobrador.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cbxCobrador.Caption = ""
        Me.cbxCobrador.CaptionHeight = 17
        Me.cbxCobrador.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbxCobrador.ColumnCaptionHeight = 17
        Me.cbxCobrador.ColumnFooterHeight = 17
        Me.cbxCobrador.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cbxCobrador.ContentHeight = 15
        Me.cbxCobrador.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cbxCobrador.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cbxCobrador.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCobrador.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cbxCobrador.EditorHeight = 15
        Me.cbxCobrador.Images.Add(CType(resources.GetObject("cbxCobrador.Images"), System.Drawing.Image))
        Me.cbxCobrador.ItemHeight = 15
        Me.cbxCobrador.Location = New System.Drawing.Point(80, 124)
        Me.cbxCobrador.MatchEntryTimeout = CType(2000, Long)
        Me.cbxCobrador.MaxDropDownItems = CType(5, Short)
        Me.cbxCobrador.MaxLength = 32767
        Me.cbxCobrador.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cbxCobrador.Name = "cbxCobrador"
        Me.cbxCobrador.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cbxCobrador.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cbxCobrador.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cbxCobrador.Size = New System.Drawing.Size(184, 21)
        Me.cbxCobrador.TabIndex = 23
        Me.cbxCobrador.Tag = "OBLIGATORIO"
        Me.cbxCobrador.PropBag = resources.GetString("cbxCobrador.PropBag")
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.Black
        Me.lblMarca.Location = New System.Drawing.Point(13, 128)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(62, 13)
        Me.lblMarca.TabIndex = 24
        Me.lblMarca.Tag = "OBLIGATORIO"
        Me.lblMarca.Text = "Cobrador:"
        '
        'cmProcesar
        '
        Me.cmProcesar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmProcesar.Appearance.Options.UseFont = True
        Me.cmProcesar.Image = CType(resources.GetObject("cmProcesar.Image"), System.Drawing.Image)
        Me.cmProcesar.Location = New System.Drawing.Point(463, 477)
        Me.cmProcesar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmProcesar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmProcesar.Name = "cmProcesar"
        Me.cmProcesar.Size = New System.Drawing.Size(75, 28)
        Me.cmProcesar.TabIndex = 22
        Me.cmProcesar.Tag = "PROCESAR"
        Me.cmProcesar.Text = "&Procesar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(542, 477)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 21
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(380, 477)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 20
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmSccEditReciboCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 531)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtTotalPagar)
        Me.Controls.Add(Me.txtTotalFact)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalFact)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccEditReciboCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Modificar Recibo Caja"
        Me.tbControl.ResumeLayout(False)
        Me.tbpDetFact.ResumeLayout(False)
        CType(Me.grdNotaDebito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpFormasPago.ResumeLayout(False)
        CType(Me.grdNotasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFormaPago.ResumeLayout(False)
        Me.grpFormaPago.PerformLayout()
        CType(Me.NumMontoDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosRecibos.ResumeLayout(False)
        Me.grpDatosRecibos.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cmbRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCobrador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbControl As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetFact As System.Windows.Forms.TabPage
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFact As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtTotalFact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtTotalPagar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpDatosRecibos As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumRecibo As System.Windows.Forms.TextBox
    Friend WithEvents lblRecibo As System.Windows.Forms.Label
    Friend WithEvents GrpExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExpediente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As C1.Win.C1List.C1Combo
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents chkPrima As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblMontoRestante As System.Windows.Forms.Label
    Friend WithEvents lblMontoAbonado As System.Windows.Forms.Label
    Friend WithEvents lblMontRest As System.Windows.Forms.Label
    Friend WithEvents lblMontAbon As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmProcesar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbxCobrador As C1.Win.C1List.C1Combo
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents tbpFormasPago As System.Windows.Forms.TabPage
    Friend WithEvents grpFormaPago As System.Windows.Forms.GroupBox
    Friend WithEvents NumMontoDolares As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmbRuta As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdNotasCredito As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdNotaDebito As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
