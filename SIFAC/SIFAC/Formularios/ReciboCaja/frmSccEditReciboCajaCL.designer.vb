<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccEditReciboCajaCL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccEditReciboCajaCL))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Me.grpEncabezado = New System.Windows.Forms.GroupBox
        Me.cmdBuscarCliente = New System.Windows.Forms.Button
        Me.txtSucursal = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.lblCliente = New System.Windows.Forms.Label
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.lblFecha = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.LblNumero = New System.Windows.Forms.Label
        Me.tbControl = New System.Windows.Forms.TabControl
        Me.tbpDetFact = New System.Windows.Forms.TabPage
        Me.grdNotaDebito = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpFormasPago = New System.Windows.Forms.TabPage
        Me.txtRestante = New C1.Win.C1Input.C1NumericEdit
        Me.lblMontoRestante = New System.Windows.Forms.Label
        Me.txtMontAbonado = New C1.Win.C1Input.C1NumericEdit
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.lblMontoAbonado = New System.Windows.Forms.Label
        Me.CTdbEntidadBanc = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.CTdbFormaPago = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.grdOtraFormaPago = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
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
        Me.grpEncabezado.SuspendLayout()
        Me.tbControl.SuspendLayout()
        Me.tbpDetFact.SuspendLayout()
        CType(Me.grdNotaDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpFormasPago.SuspendLayout()
        CType(Me.txtRestante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontAbonado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTdbEntidadBanc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTdbFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOtraFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEncabezado
        '
        Me.grpEncabezado.Controls.Add(Me.cmdBuscarCliente)
        Me.grpEncabezado.Controls.Add(Me.txtSucursal)
        Me.grpEncabezado.Controls.Add(Me.txtCliente)
        Me.grpEncabezado.Controls.Add(Me.lblSucursal)
        Me.grpEncabezado.Controls.Add(Me.lblCliente)
        Me.grpEncabezado.Controls.Add(Me.DtpFecha)
        Me.grpEncabezado.Controls.Add(Me.lblFecha)
        Me.grpEncabezado.Controls.Add(Me.txtNumero)
        Me.grpEncabezado.Controls.Add(Me.LblNumero)
        Me.grpEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.grpEncabezado.Name = "grpEncabezado"
        Me.grpEncabezado.Size = New System.Drawing.Size(767, 85)
        Me.grpEncabezado.TabIndex = 1
        Me.grpEncabezado.TabStop = False
        Me.grpEncabezado.Text = "Datos Generales"
        '
        'cmdBuscarCliente
        '
        Me.cmdBuscarCliente.Image = CType(resources.GetObject("cmdBuscarCliente.Image"), System.Drawing.Image)
        Me.cmdBuscarCliente.Location = New System.Drawing.Point(450, 19)
        Me.cmdBuscarCliente.Name = "cmdBuscarCliente"
        Me.cmdBuscarCliente.Size = New System.Drawing.Size(30, 23)
        Me.cmdBuscarCliente.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.cmdBuscarCliente, "Seleccionar cliente")
        Me.cmdBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(536, 21)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(178, 20)
        Me.txtSucursal.TabIndex = 11
        Me.txtSucursal.Tag = "BLOQUEADO"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(249, 19)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(190, 20)
        Me.txtCliente.TabIndex = 10
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(479, 23)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 5
        Me.lblSucursal.Text = "Sucursal:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(201, 21)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(60, 54)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(124, 20)
        Me.DtpFecha.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(13, 55)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(60, 20)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(124, 20)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.Tag = "BLOQUEADO"
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(13, 23)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(47, 13)
        Me.LblNumero.TabIndex = 0
        Me.LblNumero.Text = "Número:"
        '
        'tbControl
        '
        Me.tbControl.Controls.Add(Me.tbpDetFact)
        Me.tbControl.Controls.Add(Me.tbpFormasPago)
        Me.tbControl.Location = New System.Drawing.Point(0, 91)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.SelectedIndex = 0
        Me.tbControl.Size = New System.Drawing.Size(747, 386)
        Me.tbControl.TabIndex = 2
        '
        'tbpDetFact
        '
        Me.tbpDetFact.Controls.Add(Me.grdNotaDebito)
        Me.tbpDetFact.Controls.Add(Me.grdFacturas)
        Me.tbpDetFact.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetFact.Name = "tbpDetFact"
        Me.tbpDetFact.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetFact.Size = New System.Drawing.Size(739, 360)
        Me.tbpDetFact.TabIndex = 0
        Me.tbpDetFact.Text = "Detalle de Facturas"
        Me.tbpDetFact.UseVisualStyleBackColor = True
        '
        'grdNotaDebito
        '
        Me.grdNotaDebito.AllowColMove = False
        Me.grdNotaDebito.Caption = "Notas de Débito"
        Me.grdNotaDebito.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdNotaDebito.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdNotaDebito.Images.Add(CType(resources.GetObject("grdNotaDebito.Images"), System.Drawing.Image))
        Me.grdNotaDebito.Location = New System.Drawing.Point(3, 197)
        Me.grdNotaDebito.Name = "grdNotaDebito"
        Me.grdNotaDebito.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdNotaDebito.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdNotaDebito.PreviewInfo.ZoomFactor = 75
        Me.grdNotaDebito.PrintInfo.PageSettings = CType(resources.GetObject("grdNotaDebito.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdNotaDebito.Size = New System.Drawing.Size(733, 157)
        Me.grdNotaDebito.TabIndex = 8
        Me.grdNotaDebito.PropBag = resources.GetString("grdNotaDebito.PropBag")
        '
        'grdFacturas
        '
        Me.grdFacturas.AllowColMove = False
        Me.grdFacturas.Caption = "Facturas"
        Me.grdFacturas.CausesValidation = False
        Me.grdFacturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdFacturas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(3, 3)
        Me.grdFacturas.MaintainRowCurrency = True
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(733, 194)
        Me.grdFacturas.TabIndex = 7
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'tbpFormasPago
        '
        Me.tbpFormasPago.Controls.Add(Me.txtRestante)
        Me.tbpFormasPago.Controls.Add(Me.lblMontoRestante)
        Me.tbpFormasPago.Controls.Add(Me.txtMontAbonado)
        Me.tbpFormasPago.Controls.Add(Me.cmdEliminar)
        Me.tbpFormasPago.Controls.Add(Me.lblMontoAbonado)
        Me.tbpFormasPago.Controls.Add(Me.CTdbEntidadBanc)
        Me.tbpFormasPago.Controls.Add(Me.CTdbFormaPago)
        Me.tbpFormasPago.Controls.Add(Me.grdOtraFormaPago)
        Me.tbpFormasPago.Controls.Add(Me.grdNotasCredito)
        Me.tbpFormasPago.Location = New System.Drawing.Point(4, 22)
        Me.tbpFormasPago.Name = "tbpFormasPago"
        Me.tbpFormasPago.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFormasPago.Size = New System.Drawing.Size(739, 360)
        Me.tbpFormasPago.TabIndex = 1
        Me.tbpFormasPago.Text = "Formas de Pago"
        Me.tbpFormasPago.UseVisualStyleBackColor = True
        '
        'txtRestante
        '
        Me.txtRestante.BackColor = System.Drawing.SystemColors.Info
        Me.txtRestante.Enabled = False
        Me.txtRestante.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtRestante.Location = New System.Drawing.Point(611, 335)
        Me.txtRestante.Name = "txtRestante"
        Me.txtRestante.Size = New System.Drawing.Size(123, 20)
        Me.txtRestante.TabIndex = 20
        Me.txtRestante.Tag = "BLOQUEADO"
        Me.txtRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRestante.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtRestante.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblMontoRestante
        '
        Me.lblMontoRestante.AutoSize = True
        Me.lblMontoRestante.Location = New System.Drawing.Point(521, 338)
        Me.lblMontoRestante.Name = "lblMontoRestante"
        Me.lblMontoRestante.Size = New System.Drawing.Size(86, 13)
        Me.lblMontoRestante.TabIndex = 19
        Me.lblMontoRestante.Text = "Monto Restante:"
        '
        'txtMontAbonado
        '
        Me.txtMontAbonado.BackColor = System.Drawing.SystemColors.Info
        Me.txtMontAbonado.Enabled = False
        Me.txtMontAbonado.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtMontAbonado.Location = New System.Drawing.Point(373, 335)
        Me.txtMontAbonado.Name = "txtMontAbonado"
        Me.txtMontAbonado.Size = New System.Drawing.Size(123, 20)
        Me.txtMontAbonado.TabIndex = 18
        Me.txtMontAbonado.Tag = "BLOQUEADO"
        Me.txtMontAbonado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMontAbonado.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtMontAbonado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmdEliminar
        '
        Me.cmdEliminar.ImageIndex = 0
        Me.cmdEliminar.ImageList = Me.ListaImagenes
        Me.cmdEliminar.Location = New System.Drawing.Point(6, 331)
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
        'lblMontoAbonado
        '
        Me.lblMontoAbonado.AutoSize = True
        Me.lblMontoAbonado.Location = New System.Drawing.Point(281, 338)
        Me.lblMontoAbonado.Name = "lblMontoAbonado"
        Me.lblMontoAbonado.Size = New System.Drawing.Size(86, 13)
        Me.lblMontoAbonado.TabIndex = 9
        Me.lblMontoAbonado.Text = "Monto Abonado:"
        '
        'CTdbEntidadBanc
        '
        Me.CTdbEntidadBanc.AllowColMove = True
        Me.CTdbEntidadBanc.AllowColSelect = True
        Me.CTdbEntidadBanc.AllowDrop = True
        Me.CTdbEntidadBanc.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.CTdbEntidadBanc.AlternatingRows = False
        Me.CTdbEntidadBanc.CaptionStyle = Style1
        Me.CTdbEntidadBanc.ColumnCaptionHeight = 17
        Me.CTdbEntidadBanc.ColumnFooterHeight = 17
        Me.CTdbEntidadBanc.ColumnHeaders = False
        Me.CTdbEntidadBanc.EvenRowStyle = Style2
        Me.CTdbEntidadBanc.FetchRowStyles = False
        Me.CTdbEntidadBanc.FooterStyle = Style3
        Me.CTdbEntidadBanc.HeadingStyle = Style4
        Me.CTdbEntidadBanc.HighLightRowStyle = Style5
        Me.CTdbEntidadBanc.Images.Add(CType(resources.GetObject("CTdbEntidadBanc.Images"), System.Drawing.Image))
        Me.CTdbEntidadBanc.Location = New System.Drawing.Point(398, 225)
        Me.CTdbEntidadBanc.Name = "CTdbEntidadBanc"
        Me.CTdbEntidadBanc.OddRowStyle = Style6
        Me.CTdbEntidadBanc.RecordSelectorStyle = Style7
        Me.CTdbEntidadBanc.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CTdbEntidadBanc.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.CTdbEntidadBanc.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CTdbEntidadBanc.ScrollTips = False
        Me.CTdbEntidadBanc.Size = New System.Drawing.Size(128, 85)
        Me.CTdbEntidadBanc.Style = Style8
        Me.CTdbEntidadBanc.TabIndex = 8
        Me.CTdbEntidadBanc.TabStop = False
        Me.CTdbEntidadBanc.Visible = False
        Me.CTdbEntidadBanc.PropBag = resources.GetString("CTdbEntidadBanc.PropBag")
        '
        'CTdbFormaPago
        '
        Me.CTdbFormaPago.AllowColMove = True
        Me.CTdbFormaPago.AllowColSelect = True
        Me.CTdbFormaPago.AllowDrop = True
        Me.CTdbFormaPago.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.CTdbFormaPago.AlternatingRows = False
        Me.CTdbFormaPago.CaptionStyle = Style9
        Me.CTdbFormaPago.ColumnCaptionHeight = 17
        Me.CTdbFormaPago.ColumnFooterHeight = 17
        Me.CTdbFormaPago.ColumnHeaders = False
        Me.CTdbFormaPago.EvenRowStyle = Style10
        Me.CTdbFormaPago.FetchRowStyles = False
        Me.CTdbFormaPago.FooterStyle = Style11
        Me.CTdbFormaPago.HeadingStyle = Style12
        Me.CTdbFormaPago.HighLightRowStyle = Style13
        Me.CTdbFormaPago.Images.Add(CType(resources.GetObject("CTdbFormaPago.Images"), System.Drawing.Image))
        Me.CTdbFormaPago.Location = New System.Drawing.Point(17, 233)
        Me.CTdbFormaPago.Name = "CTdbFormaPago"
        Me.CTdbFormaPago.OddRowStyle = Style14
        Me.CTdbFormaPago.RecordSelectorStyle = Style15
        Me.CTdbFormaPago.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CTdbFormaPago.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.CTdbFormaPago.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CTdbFormaPago.ScrollTips = False
        Me.CTdbFormaPago.Size = New System.Drawing.Size(163, 77)
        Me.CTdbFormaPago.Style = Style16
        Me.CTdbFormaPago.TabIndex = 7
        Me.CTdbFormaPago.TabStop = False
        Me.CTdbFormaPago.Text = "C1TrueDBDropdown1"
        Me.CTdbFormaPago.Visible = False
        Me.CTdbFormaPago.PropBag = resources.GetString("CTdbFormaPago.PropBag")
        '
        'grdOtraFormaPago
        '
        Me.grdOtraFormaPago.AllowAddNew = True
        Me.grdOtraFormaPago.AllowColMove = False
        Me.grdOtraFormaPago.Caption = "Otras Formas de Pago"
        Me.grdOtraFormaPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdOtraFormaPago.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdOtraFormaPago.Images.Add(CType(resources.GetObject("grdOtraFormaPago.Images"), System.Drawing.Image))
        Me.grdOtraFormaPago.Location = New System.Drawing.Point(3, 200)
        Me.grdOtraFormaPago.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor
        Me.grdOtraFormaPago.Name = "grdOtraFormaPago"
        Me.grdOtraFormaPago.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdOtraFormaPago.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdOtraFormaPago.PreviewInfo.ZoomFactor = 75
        Me.grdOtraFormaPago.PrintInfo.PageSettings = CType(resources.GetObject("grdOtraFormaPago.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdOtraFormaPago.Size = New System.Drawing.Size(733, 131)
        Me.grdOtraFormaPago.TabIndex = 1
        Me.grdOtraFormaPago.PropBag = resources.GetString("grdOtraFormaPago.PropBag")
        '
        'grdNotasCredito
        '
        Me.grdNotasCredito.AllowColMove = False
        Me.grdNotasCredito.Caption = "Notas de Crédito"
        Me.grdNotasCredito.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdNotasCredito.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdNotasCredito.Images.Add(CType(resources.GetObject("grdNotasCredito.Images"), System.Drawing.Image))
        Me.grdNotasCredito.Location = New System.Drawing.Point(3, 3)
        Me.grdNotasCredito.Name = "grdNotasCredito"
        Me.grdNotasCredito.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdNotasCredito.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdNotasCredito.PreviewInfo.ZoomFactor = 75
        Me.grdNotasCredito.PrintInfo.PageSettings = CType(resources.GetObject("grdNotasCredito.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdNotasCredito.Size = New System.Drawing.Size(733, 197)
        Me.grdNotasCredito.TabIndex = 0
        Me.grdNotasCredito.PropBag = resources.GetString("grdNotasCredito.PropBag")
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(496, 577)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 31)
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
        Me.cmdProcesar.Location = New System.Drawing.Point(577, 577)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(75, 31)
        Me.cmdProcesar.TabIndex = 4
        Me.cmdProcesar.Text = "&Procesar"
        Me.cmdProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdProcesar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(658, 577)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 31)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(548, 533)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Pagar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(548, 511)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total ND:"
        '
        'lblTotalFact
        '
        Me.lblTotalFact.AutoSize = True
        Me.lblTotalFact.Location = New System.Drawing.Point(549, 486)
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
        Me.txtTotalFact.Enabled = False
        Me.txtTotalFact.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalFact.Location = New System.Drawing.Point(615, 483)
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
        Me.txtTotalDB.Enabled = False
        Me.txtTotalDB.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalDB.Location = New System.Drawing.Point(615, 507)
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
        Me.txtTotalPagar.Enabled = False
        Me.txtTotalPagar.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalPagar.Location = New System.Drawing.Point(615, 532)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(123, 20)
        Me.txtTotalPagar.TabIndex = 17
        Me.txtTotalPagar.Tag = "BLOQUEADO"
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalPagar.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalPagar.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'frmSccEditReciboCajaCL
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(767, 611)
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
        Me.Controls.Add(Me.grpEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccEditReciboCajaCL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Modificar Recibo Caja"
        Me.grpEncabezado.ResumeLayout(False)
        Me.grpEncabezado.PerformLayout()
        Me.tbControl.ResumeLayout(False)
        Me.tbpDetFact.ResumeLayout(False)
        CType(Me.grdNotaDebito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpFormasPago.ResumeLayout(False)
        Me.tbpFormasPago.PerformLayout()
        CType(Me.txtRestante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontAbonado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTdbEntidadBanc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTdbFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOtraFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEncabezado As System.Windows.Forms.GroupBox
    Friend WithEvents tbControl As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetFact As System.Windows.Forms.TabPage
    Friend WithEvents tbpFormasPago As System.Windows.Forms.TabPage
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents LblNumero As System.Windows.Forms.Label
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdNotaDebito As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdProcesar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents grdNotasCredito As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdOtraFormaPago As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CTdbEntidadBanc As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents CTdbFormaPago As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFact As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblMontoAbonado As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtTotalFact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtMontAbonado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtTotalPagar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtTotalDB As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtRestante As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMontoRestante As System.Windows.Forms.Label
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
