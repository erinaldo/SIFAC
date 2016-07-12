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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccEditReciboCaja))
        Me.tbControl = New System.Windows.Forms.TabControl
        Me.tbpDetFact = New System.Windows.Forms.TabPage
        Me.grdNotaDebito = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpFormasPago = New System.Windows.Forms.TabPage
        Me.grpFormaPago = New System.Windows.Forms.GroupBox
        Me.grpPago = New System.Windows.Forms.GroupBox
        Me.NumMontoDolares = New C1.Win.C1Input.C1NumericEdit
        Me.numMontoCordobas = New C1.Win.C1Input.C1NumericEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.grpCambios = New System.Windows.Forms.GroupBox
        Me.numTasaCambio = New C1.Win.C1Input.C1NumericEdit
        Me.lblTasaCambio = New System.Windows.Forms.Label
        Me.cmbMoneda = New C1.Win.C1List.C1Combo
        Me.lblMoneda = New System.Windows.Forms.Label
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.grdNotasCredito = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdProcesar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotalFact = New System.Windows.Forms.Label
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblError = New System.Windows.Forms.Label
        Me.txtTotalFact = New C1.Win.C1Input.C1NumericEdit
        Me.txtTotalDB = New C1.Win.C1Input.C1NumericEdit
        Me.txtTotalPagar = New C1.Win.C1Input.C1NumericEdit
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpDatosRecibos = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtEstado = New System.Windows.Forms.TextBox
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNumRecibo = New System.Windows.Forms.TextBox
        Me.lblRecibo = New System.Windows.Forms.Label
        Me.GrpExpediente = New System.Windows.Forms.GroupBox
        Me.chkPrima = New System.Windows.Forms.CheckBox
        Me.cmdExpediente = New System.Windows.Forms.Button
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumCuenta = New System.Windows.Forms.TextBox
        Me.txtCodTienda = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblMontRest = New System.Windows.Forms.Label
        Me.lblMontAbon = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblMontoRestante = New System.Windows.Forms.Label
        Me.lblMontoAbonado = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbSucursal = New C1.Win.C1List.C1Combo
        Me.lblEstado = New System.Windows.Forms.Label
        Me.numTotalPagarCor = New C1.Win.C1Input.C1NumericEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbControl.SuspendLayout()
        Me.tbpDetFact.SuspendLayout()
        CType(Me.grdNotaDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpFormasPago.SuspendLayout()
        Me.grpFormaPago.SuspendLayout()
        Me.grpPago.SuspendLayout()
        CType(Me.NumMontoDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMontoCordobas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCambios.SuspendLayout()
        CType(Me.numTasaCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosRecibos.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpExpediente.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalPagarCor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbControl
        '
        Me.tbControl.Controls.Add(Me.tbpDetFact)
        Me.tbControl.Controls.Add(Me.tbpFormasPago)
        Me.tbControl.Location = New System.Drawing.Point(0, 148)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.SelectedIndex = 0
        Me.tbControl.Size = New System.Drawing.Size(642, 248)
        Me.tbControl.TabIndex = 2
        '
        'tbpDetFact
        '
        Me.tbpDetFact.Controls.Add(Me.grdNotaDebito)
        Me.tbpDetFact.Controls.Add(Me.grdFacturas)
        Me.tbpDetFact.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetFact.Name = "tbpDetFact"
        Me.tbpDetFact.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetFact.Size = New System.Drawing.Size(634, 222)
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
        Me.grdNotaDebito.Location = New System.Drawing.Point(3, 120)
        Me.grdNotaDebito.Name = "grdNotaDebito"
        Me.grdNotaDebito.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdNotaDebito.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdNotaDebito.PreviewInfo.ZoomFactor = 75
        Me.grdNotaDebito.PrintInfo.PageSettings = CType(resources.GetObject("grdNotaDebito.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdNotaDebito.Size = New System.Drawing.Size(628, 101)
        Me.grdNotaDebito.TabIndex = 9
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
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(628, 117)
        Me.grdFacturas.TabIndex = 7
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'tbpFormasPago
        '
        Me.tbpFormasPago.Controls.Add(Me.grpFormaPago)
        Me.tbpFormasPago.Controls.Add(Me.cmdEliminar)
        Me.tbpFormasPago.Controls.Add(Me.grdNotasCredito)
        Me.tbpFormasPago.Location = New System.Drawing.Point(4, 22)
        Me.tbpFormasPago.Name = "tbpFormasPago"
        Me.tbpFormasPago.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFormasPago.Size = New System.Drawing.Size(634, 222)
        Me.tbpFormasPago.TabIndex = 1
        Me.tbpFormasPago.Text = "Formas de Pago"
        Me.tbpFormasPago.UseVisualStyleBackColor = True
        '
        'grpFormaPago
        '
        Me.grpFormaPago.Controls.Add(Me.grpPago)
        Me.grpFormaPago.Controls.Add(Me.grpCambios)
        Me.grpFormaPago.Location = New System.Drawing.Point(8, 130)
        Me.grpFormaPago.Name = "grpFormaPago"
        Me.grpFormaPago.Size = New System.Drawing.Size(620, 86)
        Me.grpFormaPago.TabIndex = 14
        Me.grpFormaPago.TabStop = False
        Me.grpFormaPago.Text = "Pago en efectivo o Débito Automático"
        '
        'grpPago
        '
        Me.grpPago.Controls.Add(Me.NumMontoDolares)
        Me.grpPago.Controls.Add(Me.numMontoCordobas)
        Me.grpPago.Controls.Add(Me.Label7)
        Me.grpPago.Controls.Add(Me.Label6)
        Me.grpPago.Location = New System.Drawing.Point(315, 13)
        Me.grpPago.Name = "grpPago"
        Me.grpPago.Size = New System.Drawing.Size(299, 66)
        Me.grpPago.TabIndex = 10
        Me.grpPago.TabStop = False
        '
        'NumMontoDolares
        '
        Me.NumMontoDolares.BackColor = System.Drawing.SystemColors.Desktop
        Me.NumMontoDolares.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumMontoDolares.Location = New System.Drawing.Point(138, 39)
        Me.NumMontoDolares.Name = "NumMontoDolares"
        Me.NumMontoDolares.Size = New System.Drawing.Size(147, 20)
        Me.NumMontoDolares.TabIndex = 17
        Me.NumMontoDolares.Tag = Nothing
        Me.NumMontoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumMontoDolares.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.NumMontoDolares.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numMontoCordobas
        '
        Me.numMontoCordobas.BackColor = System.Drawing.SystemColors.Desktop
        Me.numMontoCordobas.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMontoCordobas.Location = New System.Drawing.Point(138, 13)
        Me.numMontoCordobas.Name = "numMontoCordobas"
        Me.numMontoCordobas.Size = New System.Drawing.Size(147, 20)
        Me.numMontoCordobas.TabIndex = 16
        Me.numMontoCordobas.Tag = Nothing
        Me.numMontoCordobas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMontoCordobas.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numMontoCordobas.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Monto Dolares:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Monto Córdobas:"
        '
        'grpCambios
        '
        Me.grpCambios.Controls.Add(Me.numTasaCambio)
        Me.grpCambios.Controls.Add(Me.lblTasaCambio)
        Me.grpCambios.Controls.Add(Me.cmbMoneda)
        Me.grpCambios.Controls.Add(Me.lblMoneda)
        Me.grpCambios.Location = New System.Drawing.Point(12, 13)
        Me.grpCambios.Name = "grpCambios"
        Me.grpCambios.Size = New System.Drawing.Size(297, 67)
        Me.grpCambios.TabIndex = 9
        Me.grpCambios.TabStop = False
        '
        'numTasaCambio
        '
        Me.numTasaCambio.BackColor = System.Drawing.SystemColors.Info
        Me.numTasaCambio.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTasaCambio.Location = New System.Drawing.Point(120, 39)
        Me.numTasaCambio.Name = "numTasaCambio"
        Me.numTasaCambio.Size = New System.Drawing.Size(153, 20)
        Me.numTasaCambio.TabIndex = 18
        Me.numTasaCambio.Tag = "BLOQUEADO"
        Me.numTasaCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTasaCambio.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTasaCambio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblTasaCambio
        '
        Me.lblTasaCambio.AutoSize = True
        Me.lblTasaCambio.Location = New System.Drawing.Point(22, 43)
        Me.lblTasaCambio.Name = "lblTasaCambio"
        Me.lblTasaCambio.Size = New System.Drawing.Size(87, 13)
        Me.lblTasaCambio.TabIndex = 11
        Me.lblTasaCambio.Text = "Tasa de Cambio:"
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
        Me.cmbMoneda.Location = New System.Drawing.Point(120, 13)
        Me.cmbMoneda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoneda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoneda.MaxLength = 32767
        Me.cmbMoneda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoneda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoneda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoneda.Size = New System.Drawing.Size(156, 21)
        Me.cmbMoneda.TabIndex = 10
        Me.cmbMoneda.PropBag = resources.GetString("cmbMoneda.PropBag")
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(22, 16)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(92, 13)
        Me.lblMoneda.TabIndex = 9
        Me.lblMoneda.Text = "Moneda de Pago:"
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
        Me.grdNotasCredito.PreviewInfo.ZoomFactor = 75
        Me.grdNotasCredito.PrintInfo.PageSettings = CType(resources.GetObject("grdNotasCredito.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdNotasCredito.Size = New System.Drawing.Size(628, 119)
        Me.grdNotasCredito.TabIndex = 0
        Me.grdNotasCredito.PropBag = resources.GetString("grdNotasCredito.PropBag")
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(391, 501)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(76, 31)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdProcesar
        '
        Me.cmdProcesar.Enabled = False
        Me.cmdProcesar.Image = CType(resources.GetObject("cmdProcesar.Image"), System.Drawing.Image)
        Me.cmdProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProcesar.Location = New System.Drawing.Point(472, 501)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(76, 31)
        Me.cmdProcesar.TabIndex = 4
        Me.cmdProcesar.Text = "&Procesar"
        Me.cmdProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdProcesar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(552, 501)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(76, 31)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 453)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Pagar $:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(402, 428)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total ND:"
        '
        'lblTotalFact
        '
        Me.lblTotalFact.AutoSize = True
        Me.lblTotalFact.Location = New System.Drawing.Point(402, 404)
        Me.lblTotalFact.Name = "lblTotalFact"
        Me.lblTotalFact.Size = New System.Drawing.Size(58, 13)
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
        Me.lblError.Location = New System.Drawing.Point(12, 486)
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
        Me.txtTotalFact.Location = New System.Drawing.Point(489, 401)
        Me.txtTotalFact.Name = "txtTotalFact"
        Me.txtTotalFact.Size = New System.Drawing.Size(123, 20)
        Me.txtTotalFact.TabIndex = 15
        Me.txtTotalFact.Tag = "BLOQUEADO"
        Me.txtTotalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalFact.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalFact.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtTotalDB
        '
        Me.txtTotalDB.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalDB.DisplayFormat.CustomFormat = "$ #,##0.00"
        Me.txtTotalDB.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalDB.Enabled = False
        Me.txtTotalDB.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalDB.Location = New System.Drawing.Point(489, 425)
        Me.txtTotalDB.Name = "txtTotalDB"
        Me.txtTotalDB.Size = New System.Drawing.Size(123, 20)
        Me.txtTotalDB.TabIndex = 16
        Me.txtTotalDB.Tag = "BLOQUEADO"
        Me.txtTotalDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalDB.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalDB.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.txtTotalPagar.Location = New System.Drawing.Point(489, 450)
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
        Me.grpDatosRecibos.Location = New System.Drawing.Point(15, 44)
        Me.grpDatosRecibos.Name = "grpDatosRecibos"
        Me.grpDatosRecibos.Size = New System.Drawing.Size(241, 98)
        Me.grpDatosRecibos.TabIndex = 19
        Me.grpDatosRecibos.TabStop = False
        Me.grpDatosRecibos.Text = "&DatosRecibos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(73, 43)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(159, 20)
        Me.txtEstado.TabIndex = 5
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'dtpFecha
        '
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
        Me.Label1.Location = New System.Drawing.Point(6, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Fecha:"
        '
        'txtNumRecibo
        '
        Me.txtNumRecibo.Location = New System.Drawing.Point(73, 17)
        Me.txtNumRecibo.Name = "txtNumRecibo"
        Me.txtNumRecibo.Size = New System.Drawing.Size(159, 20)
        Me.txtNumRecibo.TabIndex = 1
        Me.txtNumRecibo.Tag = ""
        '
        'lblRecibo
        '
        Me.lblRecibo.AutoSize = True
        Me.lblRecibo.Location = New System.Drawing.Point(6, 20)
        Me.lblRecibo.Name = "lblRecibo"
        Me.lblRecibo.Size = New System.Drawing.Size(61, 13)
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
        Me.GrpExpediente.Controls.Add(Me.txtCodTienda)
        Me.GrpExpediente.Controls.Add(Me.Label5)
        Me.GrpExpediente.Location = New System.Drawing.Point(263, 44)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Size = New System.Drawing.Size(379, 98)
        Me.GrpExpediente.TabIndex = 18
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos Expediente"
        '
        'chkPrima
        '
        Me.chkPrima.AutoSize = True
        Me.chkPrima.Location = New System.Drawing.Point(19, 75)
        Me.chkPrima.Name = "chkPrima"
        Me.chkPrima.Size = New System.Drawing.Size(104, 17)
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
        Me.txtCliente.Location = New System.Drawing.Point(86, 44)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(263, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Tag = "OBLIGATORIO"
        Me.Label4.Text = "Cliente:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Location = New System.Drawing.Point(155, 17)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(163, 20)
        Me.txtNumCuenta.TabIndex = 3
        Me.txtNumCuenta.Tag = "BLOQUEADO"
        '
        'txtCodTienda
        '
        Me.txtCodTienda.Location = New System.Drawing.Point(86, 17)
        Me.txtCodTienda.Name = "txtCodTienda"
        Me.txtCodTienda.Size = New System.Drawing.Size(63, 20)
        Me.txtCodTienda.TabIndex = 2
        Me.txtCodTienda.Tag = "BLOQUEADO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Tag = "OBLIGATORIO"
        Me.Label5.Text = "No. Exp:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 32)
        Me.Panel2.TabIndex = 20
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(577, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMontRest)
        Me.GroupBox1.Controls.Add(Me.lblMontAbon)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblMontoRestante)
        Me.GroupBox1.Controls.Add(Me.lblMontoAbonado)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 398)
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
        Me.Label9.Location = New System.Drawing.Point(9, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Monto Abarcado:"
        '
        'lblMontoRestante
        '
        Me.lblMontoRestante.AutoSize = True
        Me.lblMontoRestante.Location = New System.Drawing.Point(9, 40)
        Me.lblMontoRestante.Name = "lblMontoRestante"
        Me.lblMontoRestante.Size = New System.Drawing.Size(86, 13)
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
        Me.Panel1.BackgroundImage = Global.SCCUM.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 536)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 18)
        Me.Panel1.TabIndex = 22
        '
        'cmbSucursal
        '
        Me.cmbSucursal.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursal.Caption = ""
        Me.cmbSucursal.CaptionHeight = 17
        Me.cmbSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursal.ColumnCaptionHeight = 17
        Me.cmbSucursal.ColumnFooterHeight = 17
        Me.cmbSucursal.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSucursal.ContentHeight = 15
        Me.cmbSucursal.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursal.DropDownWidth = 224
        Me.cmbSucursal.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursal.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursal.EditorHeight = 15
        Me.cmbSucursal.Images.Add(CType(resources.GetObject("cmbSucursal.Images"), System.Drawing.Image))
        Me.cmbSucursal.ItemHeight = 15
        Me.cmbSucursal.LimitToList = True
        Me.cmbSucursal.Location = New System.Drawing.Point(21, 479)
        Me.cmbSucursal.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursal.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursal.MaxLength = 32767
        Me.cmbSucursal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursal.Size = New System.Drawing.Size(215, 21)
        Me.cmbSucursal.TabIndex = 71
        Me.cmbSucursal.Tag = ""
        Me.cmbSucursal.PropBag = resources.GetString("cmbSucursal.PropBag")
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(18, 463)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(79, 13)
        Me.lblEstado.TabIndex = 72
        Me.lblEstado.Tag = ""
        Me.lblEstado.Text = "Sucursal Pago:"
        '
        'numTotalPagarCor
        '
        Me.numTotalPagarCor.BackColor = System.Drawing.SystemColors.Info
        Me.numTotalPagarCor.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalPagarCor.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotalPagarCor.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotalPagarCor.Enabled = False
        Me.numTotalPagarCor.FormatType = C1.Win.C1Input.FormatTypeEnum.Percent
        Me.numTotalPagarCor.Location = New System.Drawing.Point(489, 475)
        Me.numTotalPagarCor.Name = "numTotalPagarCor"
        Me.numTotalPagarCor.Size = New System.Drawing.Size(123, 20)
        Me.numTotalPagarCor.TabIndex = 74
        Me.numTotalPagarCor.Tag = "BLOQUEADO"
        Me.numTotalPagarCor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotalPagarCor.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTotalPagarCor.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(402, 479)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Total Pagar C$:"
        '
        'frmSccEditReciboCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(648, 554)
        Me.Controls.Add(Me.numTotalPagarCor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grpDatosRecibos)
        Me.Controls.Add(Me.GrpExpediente)
        Me.Controls.Add(Me.txtTotalPagar)
        Me.Controls.Add(Me.txtTotalDB)
        Me.Controls.Add(Me.txtTotalFact)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalFact)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdProcesar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.tbControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
        Me.grpFormaPago.ResumeLayout(False)
        Me.grpPago.ResumeLayout(False)
        Me.grpPago.PerformLayout()
        CType(Me.NumMontoDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMontoCordobas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCambios.ResumeLayout(False)
        Me.grpCambios.PerformLayout()
        CType(Me.numTasaCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosRecibos.ResumeLayout(False)
        Me.grpDatosRecibos.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalPagarCor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbControl As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetFact As System.Windows.Forms.TabPage
    Friend WithEvents tbpFormasPago As System.Windows.Forms.TabPage
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdProcesar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents grdNotasCredito As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFact As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtTotalFact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtTotalPagar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtTotalDB As C1.Win.C1Input.C1NumericEdit
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
    Friend WithEvents txtCodTienda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents grpFormaPago As System.Windows.Forms.GroupBox
    Friend WithEvents grpCambios As System.Windows.Forms.GroupBox
    Friend WithEvents lblTasaCambio As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As C1.Win.C1List.C1Combo
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents grpPago As System.Windows.Forms.GroupBox
    Friend WithEvents NumMontoDolares As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numMontoCordobas As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numTasaCambio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkPrima As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblMontoRestante As System.Windows.Forms.Label
    Friend WithEvents lblMontoAbonado As System.Windows.Forms.Label
    Friend WithEvents lblMontRest As System.Windows.Forms.Label
    Friend WithEvents lblMontAbon As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grdNotaDebito As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmbSucursal As C1.Win.C1List.C1Combo
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents numTotalPagarCor As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
