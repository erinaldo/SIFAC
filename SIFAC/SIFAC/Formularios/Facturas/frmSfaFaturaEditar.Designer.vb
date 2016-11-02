<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaFaturaEditar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaFaturaEditar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numDescuentoPorc = New C1.Win.C1Input.C1NumericEdit()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.cmbFactura = New C1.Win.C1List.C1Combo()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.numFinancimiento = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numPrima = New C1.Win.C1Input.C1NumericEdit()
        Me.numCuotas = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.numSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.NumMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.numMontoCuotas = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblfact = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbModalidadPago = New C1.Win.C1List.C1Combo()
        Me.lblModalidadPago = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpUltimoPago = New C1.Win.C1Input.C1DateEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaProximoPago = New C1.Win.C1Input.C1DateEdit()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.dtpFechaVencimiento = New C1.Win.C1Input.C1DateEdit()
        Me.dtpFechaCredito = New C1.Win.C1Input.C1DateEdit()
        Me.cmbPlazo = New C1.Win.C1List.C1Combo()
        Me.lblFechaVencimiento = New System.Windows.Forms.Label()
        Me.lblFechaCredito = New System.Windows.Forms.Label()
        Me.lblTerminoPlazo = New System.Windows.Forms.Label()
        Me.ToolTip = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdProcesar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPedido = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.TabPageGenerales = New System.Windows.Forms.TabPage()
        Me.cmbVendedor = New C1.Win.C1List.C1Combo()
        Me.cmbCliente = New C1.Win.C1List.C1Combo()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPageCliente = New System.Windows.Forms.TabPage()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.grdvwExpediente = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numDescuentoPorc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFinancimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMontoCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbModalidadPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtpUltimoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaProximoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.TabPageGenerales.SuspendLayout()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCliente.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.grdvwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numDescuentoPorc)
        Me.GroupBox1.Controls.Add(Me.lblDescuento)
        Me.GroupBox1.Controls.Add(Me.cmbFactura)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.numFinancimiento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.numPrima)
        Me.GroupBox1.Controls.Add(Me.numCuotas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblSaldo)
        Me.GroupBox1.Controls.Add(Me.numSaldo)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.NumMonto)
        Me.GroupBox1.Controls.Add(Me.numMontoCuotas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblfact)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Principales"
        '
        'numDescuentoPorc
        '
        Me.numDescuentoPorc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numDescuentoPorc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numDescuentoPorc.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numDescuentoPorc.Enabled = False
        Me.numDescuentoPorc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDescuentoPorc.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numDescuentoPorc.Location = New System.Drawing.Point(105, 99)
        Me.numDescuentoPorc.Name = "numDescuentoPorc"
        Me.numDescuentoPorc.Size = New System.Drawing.Size(249, 18)
        Me.numDescuentoPorc.TabIndex = 30
        Me.numDescuentoPorc.Tag = "-"
        Me.numDescuentoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDescuentoPorc.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numDescuentoPorc.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        Me.numDescuentoPorc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.ForeColor = System.Drawing.Color.Black
        Me.lblDescuento.Location = New System.Drawing.Point(8, 101)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(72, 13)
        Me.lblDescuento.TabIndex = 29
        Me.lblDescuento.Text = "Descuento:"
        '
        'cmbFactura
        '
        Me.cmbFactura.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbFactura.Caption = ""
        Me.cmbFactura.CaptionHeight = 17
        Me.cmbFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbFactura.ColumnCaptionHeight = 17
        Me.cmbFactura.ColumnFooterHeight = 17
        Me.cmbFactura.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbFactura.ContentHeight = 15
        Me.cmbFactura.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbFactura.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbFactura.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFactura.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbFactura.EditorHeight = 15
        Me.cmbFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFactura.Images.Add(CType(resources.GetObject("cmbFactura.Images"), System.Drawing.Image))
        Me.cmbFactura.ItemHeight = 15
        Me.cmbFactura.Location = New System.Drawing.Point(105, 24)
        Me.cmbFactura.MatchEntryTimeout = CType(2000, Long)
        Me.cmbFactura.MaxDropDownItems = CType(5, Short)
        Me.cmbFactura.MaxLength = 32767
        Me.cmbFactura.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbFactura.Name = "cmbFactura"
        Me.cmbFactura.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbFactura.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbFactura.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbFactura.Size = New System.Drawing.Size(249, 21)
        Me.cmbFactura.TabIndex = 28
        Me.cmbFactura.PropBag = resources.GetString("cmbFactura.PropBag")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(8, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Tag = "OBLIGATORIO"
        Me.Label14.Text = "Financiamiento:"
        '
        'numFinancimiento
        '
        Me.numFinancimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numFinancimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numFinancimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFinancimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numFinancimiento.Location = New System.Drawing.Point(105, 127)
        Me.numFinancimiento.Name = "numFinancimiento"
        Me.numFinancimiento.ReadOnly = True
        Me.numFinancimiento.Size = New System.Drawing.Size(249, 18)
        Me.numFinancimiento.TabIndex = 26
        Me.numFinancimiento.Tag = "BLOQUEADO"
        Me.numFinancimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numFinancimiento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numFinancimiento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numFinancimiento.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Tag = "OBLIGATORIO"
        Me.Label5.Text = "Prima:"
        '
        'numPrima
        '
        Me.numPrima.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numPrima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numPrima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrima.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numPrima.Location = New System.Drawing.Point(105, 73)
        Me.numPrima.Name = "numPrima"
        Me.numPrima.ReadOnly = True
        Me.numPrima.Size = New System.Drawing.Size(249, 18)
        Me.numPrima.TabIndex = 4
        Me.numPrima.Tag = "BLOQUEADO"
        Me.numPrima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPrima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numPrima.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numPrima.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'numCuotas
        '
        Me.numCuotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuotas.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numCuotas.Location = New System.Drawing.Point(105, 150)
        Me.numCuotas.Name = "numCuotas"
        Me.numCuotas.ReadOnly = True
        Me.numCuotas.Size = New System.Drawing.Size(249, 18)
        Me.numCuotas.TabIndex = 23
        Me.numCuotas.Tag = "BLOQUEADO"
        Me.numCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCuotas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numCuotas.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numCuotas.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "No Cuotas:"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.ForeColor = System.Drawing.Color.Black
        Me.lblSaldo.Location = New System.Drawing.Point(8, 198)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(43, 13)
        Me.lblSaldo.TabIndex = 21
        Me.lblSaldo.Tag = "OBLIGATORIO"
        Me.lblSaldo.Text = "Saldo:"
        '
        'numSaldo
        '
        Me.numSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSaldo.Location = New System.Drawing.Point(105, 196)
        Me.numSaldo.Name = "numSaldo"
        Me.numSaldo.ReadOnly = True
        Me.numSaldo.Size = New System.Drawing.Size(249, 18)
        Me.numSaldo.TabIndex = 20
        Me.numSaldo.Tag = "BLOQUEADO"
        Me.numSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numSaldo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.ForeColor = System.Drawing.Color.Black
        Me.lblMonto.Location = New System.Drawing.Point(8, 53)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(79, 13)
        Me.lblMonto.TabIndex = 19
        Me.lblMonto.Tag = "OBLIGATORIO"
        Me.lblMonto.Text = "Monto Total:"
        '
        'NumMonto
        '
        Me.NumMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NumMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumMonto.Location = New System.Drawing.Point(105, 51)
        Me.NumMonto.Name = "NumMonto"
        Me.NumMonto.ReadOnly = True
        Me.NumMonto.Size = New System.Drawing.Size(249, 18)
        Me.NumMonto.TabIndex = 3
        Me.NumMonto.Tag = "BLOQUEADO"
        Me.NumMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.NumMonto.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'numMontoCuotas
        '
        Me.numMontoCuotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numMontoCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numMontoCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMontoCuotas.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMontoCuotas.Location = New System.Drawing.Point(105, 172)
        Me.numMontoCuotas.Name = "numMontoCuotas"
        Me.numMontoCuotas.ReadOnly = True
        Me.numMontoCuotas.Size = New System.Drawing.Size(249, 18)
        Me.numMontoCuotas.TabIndex = 17
        Me.numMontoCuotas.Tag = "BLOQUEADO"
        Me.numMontoCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMontoCuotas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numMontoCuotas.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numMontoCuotas.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Monto Cuotas:"
        '
        'lblfact
        '
        Me.lblfact.AutoSize = True
        Me.lblfact.ForeColor = System.Drawing.Color.Black
        Me.lblfact.Location = New System.Drawing.Point(8, 26)
        Me.lblfact.Name = "lblfact"
        Me.lblfact.Size = New System.Drawing.Size(78, 13)
        Me.lblfact.TabIndex = 1
        Me.lblfact.Tag = "OBLIGATORIO"
        Me.lblfact.Text = "No. Factura:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 321)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 22)
        Me.Panel1.TabIndex = 3
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbModalidadPago)
        Me.GroupBox2.Controls.Add(Me.lblModalidadPago)
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.lblEstado)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox2.Controls.Add(Me.dtpFechaCredito)
        Me.GroupBox2.Controls.Add(Me.cmbPlazo)
        Me.GroupBox2.Controls.Add(Me.lblFechaVencimiento)
        Me.GroupBox2.Controls.Add(Me.lblFechaCredito)
        Me.GroupBox2.Controls.Add(Me.lblTerminoPlazo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(393, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 228)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Período"
        '
        'cmbModalidadPago
        '
        Me.cmbModalidadPago.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbModalidadPago.Caption = ""
        Me.cmbModalidadPago.CaptionHeight = 17
        Me.cmbModalidadPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbModalidadPago.ColumnCaptionHeight = 17
        Me.cmbModalidadPago.ColumnFooterHeight = 17
        Me.cmbModalidadPago.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbModalidadPago.ContentHeight = 15
        Me.cmbModalidadPago.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbModalidadPago.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbModalidadPago.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModalidadPago.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbModalidadPago.EditorHeight = 15
        Me.cmbModalidadPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModalidadPago.Images.Add(CType(resources.GetObject("cmbModalidadPago.Images"), System.Drawing.Image))
        Me.cmbModalidadPago.ItemHeight = 15
        Me.cmbModalidadPago.Location = New System.Drawing.Point(128, 72)
        Me.cmbModalidadPago.MatchEntryTimeout = CType(2000, Long)
        Me.cmbModalidadPago.MaxDropDownItems = CType(5, Short)
        Me.cmbModalidadPago.MaxLength = 32767
        Me.cmbModalidadPago.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbModalidadPago.Name = "cmbModalidadPago"
        Me.cmbModalidadPago.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbModalidadPago.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbModalidadPago.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbModalidadPago.Size = New System.Drawing.Size(147, 21)
        Me.cmbModalidadPago.TabIndex = 16
        Me.cmbModalidadPago.PropBag = resources.GetString("cmbModalidadPago.PropBag")
        '
        'lblModalidadPago
        '
        Me.lblModalidadPago.AutoSize = True
        Me.lblModalidadPago.ForeColor = System.Drawing.Color.Black
        Me.lblModalidadPago.Location = New System.Drawing.Point(10, 75)
        Me.lblModalidadPago.Name = "lblModalidadPago"
        Me.lblModalidadPago.Size = New System.Drawing.Size(98, 13)
        Me.lblModalidadPago.TabIndex = 15
        Me.lblModalidadPago.Text = "Modalidad Pago"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(128, 21)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(146, 20)
        Me.txtEstado.TabIndex = 14
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.Location = New System.Drawing.Point(10, 24)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(50, 13)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "Estado:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpUltimoPago)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.dtpFechaProximoPago)
        Me.GroupBox4.Controls.Add(Me.lblFechaPago)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 148)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(276, 73)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fechas de Pago"
        '
        'dtpUltimoPago
        '
        '
        '
        '
        Me.dtpUltimoPago.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpUltimoPago.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpUltimoPago.Calendar.ClearText = "&Clear"
        Me.dtpUltimoPago.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpUltimoPago.Calendar.SelectedDate = New Date(2016, 9, 16, 0, 0, 0, 0)
        Me.dtpUltimoPago.Calendar.TodayText = "&Today"
        Me.dtpUltimoPago.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpUltimoPago.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpUltimoPago.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpUltimoPago.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpUltimoPago.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpUltimoPago.Enabled = False
        Me.dtpUltimoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpUltimoPago.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpUltimoPago.Location = New System.Drawing.Point(124, 45)
        Me.dtpUltimoPago.Name = "dtpUltimoPago"
        Me.dtpUltimoPago.Size = New System.Drawing.Size(147, 20)
        Me.dtpUltimoPago.TabIndex = 15
        Me.dtpUltimoPago.Tag = "BLOQUEADO"
        Me.dtpUltimoPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(20, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Ultimo Pago:"
        '
        'dtpFechaProximoPago
        '
        '
        '
        '
        Me.dtpFechaProximoPago.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaProximoPago.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaProximoPago.Calendar.ClearText = "&Clear"
        Me.dtpFechaProximoPago.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaProximoPago.Calendar.SelectedDate = New Date(2016, 9, 16, 0, 0, 0, 0)
        Me.dtpFechaProximoPago.Calendar.TodayText = "&Today"
        Me.dtpFechaProximoPago.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaProximoPago.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaProximoPago.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaProximoPago.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaProximoPago.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaProximoPago.Enabled = False
        Me.dtpFechaProximoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaProximoPago.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaProximoPago.Location = New System.Drawing.Point(124, 19)
        Me.dtpFechaProximoPago.Name = "dtpFechaProximoPago"
        Me.dtpFechaProximoPago.Size = New System.Drawing.Size(147, 20)
        Me.dtpFechaProximoPago.TabIndex = 13
        Me.dtpFechaProximoPago.Tag = "BLOQUEADO"
        Me.dtpFechaProximoPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaPago
        '
        Me.lblFechaPago.AutoSize = True
        Me.lblFechaPago.ForeColor = System.Drawing.Color.Black
        Me.lblFechaPago.Location = New System.Drawing.Point(20, 22)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaPago.TabIndex = 12
        Me.lblFechaPago.Text = "Próximo Pago:"
        '
        'dtpFechaVencimiento
        '
        '
        '
        '
        Me.dtpFechaVencimiento.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaVencimiento.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaVencimiento.Calendar.ClearText = "&Clear"
        Me.dtpFechaVencimiento.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaVencimiento.Calendar.SelectedDate = New Date(2016, 9, 16, 0, 0, 0, 0)
        Me.dtpFechaVencimiento.Calendar.TodayText = "&Today"
        Me.dtpFechaVencimiento.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaVencimiento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaVencimiento.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaVencimiento.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaVencimiento.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVencimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(128, 124)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(147, 20)
        Me.dtpFechaVencimiento.TabIndex = 7
        Me.dtpFechaVencimiento.Tag = "BLOQUEADO"
        Me.dtpFechaVencimiento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFechaCredito
        '
        '
        '
        '
        Me.dtpFechaCredito.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaCredito.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaCredito.Calendar.ClearText = "&Clear"
        Me.dtpFechaCredito.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaCredito.Calendar.SelectedDate = New Date(2016, 9, 16, 0, 0, 0, 0)
        Me.dtpFechaCredito.Calendar.TodayText = "&Today"
        Me.dtpFechaCredito.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaCredito.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaCredito.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaCredito.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaCredito.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCredito.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaCredito.Location = New System.Drawing.Point(128, 98)
        Me.dtpFechaCredito.Name = "dtpFechaCredito"
        Me.dtpFechaCredito.Size = New System.Drawing.Size(147, 20)
        Me.dtpFechaCredito.TabIndex = 6
        Me.dtpFechaCredito.Tag = "BLOQUEADO"
        Me.dtpFechaCredito.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cmbPlazo
        '
        Me.cmbPlazo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbPlazo.Caption = ""
        Me.cmbPlazo.CaptionHeight = 17
        Me.cmbPlazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbPlazo.ColumnCaptionHeight = 17
        Me.cmbPlazo.ColumnFooterHeight = 17
        Me.cmbPlazo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbPlazo.ContentHeight = 15
        Me.cmbPlazo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPlazo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPlazo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlazo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPlazo.EditorHeight = 15
        Me.cmbPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlazo.Images.Add(CType(resources.GetObject("cmbPlazo.Images"), System.Drawing.Image))
        Me.cmbPlazo.ItemHeight = 15
        Me.cmbPlazo.Location = New System.Drawing.Point(128, 46)
        Me.cmbPlazo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPlazo.MaxDropDownItems = CType(5, Short)
        Me.cmbPlazo.MaxLength = 32767
        Me.cmbPlazo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPlazo.Name = "cmbPlazo"
        Me.cmbPlazo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPlazo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPlazo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPlazo.Size = New System.Drawing.Size(147, 21)
        Me.cmbPlazo.TabIndex = 5
        Me.cmbPlazo.PropBag = resources.GetString("cmbPlazo.PropBag")
        '
        'lblFechaVencimiento
        '
        Me.lblFechaVencimiento.AutoSize = True
        Me.lblFechaVencimiento.ForeColor = System.Drawing.Color.Black
        Me.lblFechaVencimiento.Location = New System.Drawing.Point(10, 126)
        Me.lblFechaVencimiento.Name = "lblFechaVencimiento"
        Me.lblFechaVencimiento.Size = New System.Drawing.Size(119, 13)
        Me.lblFechaVencimiento.TabIndex = 2
        Me.lblFechaVencimiento.Text = "Fecha Vencimiento:"
        '
        'lblFechaCredito
        '
        Me.lblFechaCredito.AutoSize = True
        Me.lblFechaCredito.ForeColor = System.Drawing.Color.Black
        Me.lblFechaCredito.Location = New System.Drawing.Point(10, 101)
        Me.lblFechaCredito.Name = "lblFechaCredito"
        Me.lblFechaCredito.Size = New System.Drawing.Size(90, 13)
        Me.lblFechaCredito.TabIndex = 1
        Me.lblFechaCredito.Text = "Fecha Crédito:"
        '
        'lblTerminoPlazo
        '
        Me.lblTerminoPlazo.AutoSize = True
        Me.lblTerminoPlazo.ForeColor = System.Drawing.Color.Black
        Me.lblTerminoPlazo.Location = New System.Drawing.Point(10, 50)
        Me.lblTerminoPlazo.Name = "lblTerminoPlazo"
        Me.lblTerminoPlazo.Size = New System.Drawing.Size(91, 13)
        Me.lblTerminoPlazo.TabIndex = 0
        Me.lblTerminoPlazo.Text = "Término Plazo:"
        '
        'ToolTip
        '
        Me.ToolTip.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ToolTip.IsBalloon = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(14, 449)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblInfo.TabIndex = 27
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdProcesar)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.cmdPedido)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(686, 343)
        Me.PanelControl1.TabIndex = 28
        '
        'cmdProcesar
        '
        Me.cmdProcesar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProcesar.Appearance.Options.UseFont = True
        Me.cmdProcesar.Image = CType(resources.GetObject("cmdProcesar.Image"), System.Drawing.Image)
        Me.cmdProcesar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdProcesar.Location = New System.Drawing.Point(519, 274)
        Me.cmdProcesar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdProcesar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(80, 28)
        Me.cmdProcesar.TabIndex = 120
        Me.cmdProcesar.Tag = "PROCESAR"
        Me.cmdProcesar.Text = "&Procesar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(605, 274)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 119
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(434, 274)
        Me.cmdAceptar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 28)
        Me.cmdAceptar.TabIndex = 118
        Me.cmdAceptar.Tag = "GUARDAR"
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmdPedido
        '
        Me.cmdPedido.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPedido.Appearance.Options.UseFont = True
        Me.cmdPedido.Image = CType(resources.GetObject("cmdPedido.Image"), System.Drawing.Image)
        Me.cmdPedido.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPedido.Location = New System.Drawing.Point(29, 575)
        Me.cmdPedido.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdPedido.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPedido.Name = "cmdPedido"
        Me.cmdPedido.Size = New System.Drawing.Size(121, 28)
        Me.cmdPedido.TabIndex = 117
        Me.cmdPedido.Tag = "PEDIDO"
        Me.cmdPedido.Text = "&Generar Pedido"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(759, 572)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(673, 572)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'TabPageGenerales
        '
        Me.TabPageGenerales.Controls.Add(Me.cmbVendedor)
        Me.TabPageGenerales.Controls.Add(Me.cmbCliente)
        Me.TabPageGenerales.Controls.Add(Me.txtNumero)
        Me.TabPageGenerales.Controls.Add(Me.Label8)
        Me.TabPageGenerales.Controls.Add(Me.Label10)
        Me.TabPageGenerales.Controls.Add(Me.Label13)
        Me.TabPageGenerales.Controls.Add(Me.Label15)
        Me.TabPageGenerales.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGenerales.Name = "TabPageGenerales"
        Me.TabPageGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGenerales.Size = New System.Drawing.Size(809, 132)
        Me.TabPageGenerales.TabIndex = 0
        Me.TabPageGenerales.Text = "Datos Generales"
        Me.TabPageGenerales.UseVisualStyleBackColor = True
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(475, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(475, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 13)
        Me.Label15.TabIndex = 0
        '
        'TabPageCliente
        '
        Me.TabPageCliente.Controls.Add(Me.txtDireccion)
        Me.TabPageCliente.Controls.Add(Me.txtTelefono)
        Me.TabPageCliente.Controls.Add(Me.GroupBox8)
        Me.TabPageCliente.Controls.Add(Me.Label16)
        Me.TabPageCliente.Controls.Add(Me.Label17)
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
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.grdvwExpediente)
        Me.GroupBox8.Location = New System.Drawing.Point(429, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(369, 123)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        '
        'grdvwExpediente
        '
        Me.grdvwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdvwExpediente.Location = New System.Drawing.Point(3, 16)
        Me.grdvwExpediente.LookAndFeel.SkinName = "Glass Oceans"
        Me.grdvwExpediente.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.grdvwExpediente.MainView = Me.GridView1
        Me.grdvwExpediente.Name = "grdvwExpediente"
        Me.grdvwExpediente.Size = New System.Drawing.Size(363, 104)
        Me.grdvwExpediente.TabIndex = 3
        Me.grdvwExpediente.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colProducto, Me.colSaldo})
        Me.GridView1.GridControl = Me.grdvwExpediente
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "SccCuentaID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 0
        Me.colNumero.Width = 81
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        Me.colProducto.Width = 162
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 2
        Me.colSaldo.Width = 102
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 0
        '
        'frmSfaFaturaEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 343)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaFaturaEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura-Expediente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numDescuentoPorc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFinancimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMontoCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbModalidadPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtpUltimoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaProximoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.TabPageGenerales.ResumeLayout(False)
        Me.TabPageGenerales.PerformLayout()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCliente.ResumeLayout(False)
        Me.TabPageCliente.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.grdvwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfact As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents numMontoCuotas As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaVencimiento As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaCredito As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbPlazo As C1.Win.C1List.C1Combo
    Friend WithEvents lblFechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents lblFechaCredito As System.Windows.Forms.Label
    Friend WithEvents lblTerminoPlazo As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents numSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents NumMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numCuotas As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpUltimoPago As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaProximoPago As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents ToolTip As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numPrima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents numFinancimiento As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdPedido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabPageGenerales As System.Windows.Forms.TabPage
    Friend WithEvents cmbVendedor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCliente As C1.Win.C1List.C1Combo
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPageCliente As System.Windows.Forms.TabPage
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents grdvwExpediente As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdProcesar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbFactura As C1.Win.C1List.C1Combo
    Friend WithEvents numDescuentoPorc As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents cmbModalidadPago As C1.Win.C1List.C1Combo
    Friend WithEvents lblModalidadPago As System.Windows.Forms.Label
End Class
