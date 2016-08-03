<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbVisor
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbVisor))
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.pagEstadoCrediticio = New System.Windows.Forms.TabPage
        Me.cmbConcepto = New C1.Win.C1List.C1Combo
        Me.cmbClientesEstCredt = New C1.Win.C1List.C1Combo
        Me.cmbSucursalEstCredit = New C1.Win.C1List.C1Combo
        Me.chkClienteFiador = New System.Windows.Forms.CheckBox
        Me.txtCedula = New System.Windows.Forms.MaskedTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdBuscarEstadoCredi = New System.Windows.Forms.Button
        Me.txtNoFactEstCredt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtExpedienteEstCredt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblEstado = New System.Windows.Forms.Label
        Me.pagCuotasVencidas = New System.Windows.Forms.TabPage
        Me.cmbClientesCuotasV = New C1.Win.C1List.C1Combo
        Me.cmbSucursalCuotasV = New C1.Win.C1List.C1Combo
        Me.txtCedCuotasV = New System.Windows.Forms.MaskedTextBox
        Me.txtCantVenc = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdBCuotasV = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtExpCuotasVenc = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tabDevoluciones = New System.Windows.Forms.TabPage
        Me.cmbSucursalDev = New C1.Win.C1List.C1Combo
        Me.dtpFechaFinDev = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaInicioDev = New C1.Win.C1Input.C1DateEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtNoDevolucion = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.tabSeguimiento = New System.Windows.Forms.TabPage
        Me.cmbUsuario = New C1.Win.C1List.C1Combo
        Me.cmbClientesSeg = New C1.Win.C1List.C1Combo
        Me.txtCedClientes = New System.Windows.Forms.MaskedTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmdBuscarSeguimientos = New System.Windows.Forms.Button
        Me.dtpFechFinSeg = New C1.Win.C1Input.C1DateEdit
        Me.dtpFecIniSeg = New C1.Win.C1Input.C1DateEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.tbEstadoCuentas = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbSucursalEstadoCuenta = New C1.Win.C1List.C1Combo
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtNoExpEstadoCuenta = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbNoExpediente = New C1.Win.C1List.C1Combo
        Me.txtNoExpedienteCedula = New System.Windows.Forms.MaskedTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rbtOpcion1 = New System.Windows.Forms.RadioButton
        Me.cmdBuscarEstadoCuenta = New System.Windows.Forms.Button
        Me.tbMorosidad = New System.Windows.Forms.TabPage
        Me.cmbSucursalMor = New C1.Win.C1List.C1Combo
        Me.cmdBuscarSucMor = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.TabPorcentaje = New System.Windows.Forms.TabPage
        Me.cmbSucursal = New C1.Win.C1List.C1Combo
        Me.cmdReporte = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.TabSaldo = New System.Windows.Forms.TabPage
        Me.cmbSucursalSaldo = New C1.Win.C1List.C1Combo
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.tagpCarteraRangos = New System.Windows.Forms.TabPage
        Me.cmbTiendaCartera = New C1.Win.C1List.C1Combo
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.TabHistorialClientes = New System.Windows.Forms.TabPage
        Me.cmdCargarRptHistorialCliente = New System.Windows.Forms.Button
        Me.cmbClientesHistorial = New C1.Win.C1List.C1Combo
        Me.cmbSucursalHistorial = New C1.Win.C1List.C1Combo
        Me.txtExpedienteHistorial = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TabRecuperacionComp = New System.Windows.Forms.TabPage
        Me.cmdCargaComparativoRecuperacion = New System.Windows.Forms.Button
        Me.dtpFechaDesde2 = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaHasta2 = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaHasta1 = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaDesde1 = New C1.Win.C1Input.C1DateEdit
        Me.cmbSucursalesRecuperacionCmp = New C1.Win.C1List.C1Combo
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer
        Me.tstNotaCredito = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.VisorReporte = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.pagEstadoCrediticio.SuspendLayout()
        CType(Me.cmbConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbClientesEstCredt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursalEstCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCuotasVencidas.SuspendLayout()
        CType(Me.cmbClientesCuotasV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursalCuotasV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDevoluciones.SuspendLayout()
        CType(Me.cmbSucursalDev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFinDev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioDev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSeguimiento.SuspendLayout()
        CType(Me.cmbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbClientesSeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechFinSeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecIniSeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbEstadoCuentas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.cmbSucursalEstadoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbNoExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tbMorosidad.SuspendLayout()
        CType(Me.cmbSucursalMor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPorcentaje.SuspendLayout()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSaldo.SuspendLayout()
        CType(Me.cmbSucursalSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tagpCarteraRangos.SuspendLayout()
        CType(Me.cmbTiendaCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabHistorialClientes.SuspendLayout()
        CType(Me.cmbClientesHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursalHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRecuperacionComp.SuspendLayout()
        CType(Me.dtpFechaDesde2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaHasta2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaHasta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursalesRecuperacionCmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        Me.tstNotaCredito.SuspendLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pagEstadoCrediticio)
        Me.TabControl1.Controls.Add(Me.pagCuotasVencidas)
        Me.TabControl1.Controls.Add(Me.tabDevoluciones)
        Me.TabControl1.Controls.Add(Me.tabSeguimiento)
        Me.TabControl1.Controls.Add(Me.tbEstadoCuentas)
        Me.TabControl1.Controls.Add(Me.tbMorosidad)
        Me.TabControl1.Controls.Add(Me.TabPorcentaje)
        Me.TabControl1.Controls.Add(Me.TabSaldo)
        Me.TabControl1.Controls.Add(Me.tagpCarteraRangos)
        Me.TabControl1.Controls.Add(Me.TabHistorialClientes)
        Me.TabControl1.Controls.Add(Me.TabRecuperacionComp)
        Me.TabControl1.Location = New System.Drawing.Point(4, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(845, 91)
        Me.TabControl1.TabIndex = 0
        '
        'pagEstadoCrediticio
        '
        Me.pagEstadoCrediticio.Controls.Add(Me.cmbConcepto)
        Me.pagEstadoCrediticio.Controls.Add(Me.cmbClientesEstCredt)
        Me.pagEstadoCrediticio.Controls.Add(Me.cmbSucursalEstCredit)
        Me.pagEstadoCrediticio.Controls.Add(Me.chkClienteFiador)
        Me.pagEstadoCrediticio.Controls.Add(Me.txtCedula)
        Me.pagEstadoCrediticio.Controls.Add(Me.Label18)
        Me.pagEstadoCrediticio.Controls.Add(Me.Label4)
        Me.pagEstadoCrediticio.Controls.Add(Me.cmdBuscarEstadoCredi)
        Me.pagEstadoCrediticio.Controls.Add(Me.txtNoFactEstCredt)
        Me.pagEstadoCrediticio.Controls.Add(Me.Label3)
        Me.pagEstadoCrediticio.Controls.Add(Me.txtExpedienteEstCredt)
        Me.pagEstadoCrediticio.Controls.Add(Me.Label2)
        Me.pagEstadoCrediticio.Controls.Add(Me.Label1)
        Me.pagEstadoCrediticio.Controls.Add(Me.lblEstado)
        Me.pagEstadoCrediticio.Location = New System.Drawing.Point(4, 22)
        Me.pagEstadoCrediticio.Name = "pagEstadoCrediticio"
        Me.pagEstadoCrediticio.Padding = New System.Windows.Forms.Padding(3)
        Me.pagEstadoCrediticio.Size = New System.Drawing.Size(837, 65)
        Me.pagEstadoCrediticio.TabIndex = 0
        Me.pagEstadoCrediticio.Text = "Estado Crediticio"
        Me.pagEstadoCrediticio.UseVisualStyleBackColor = True
        '
        'cmbConcepto
        '
        Me.cmbConcepto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbConcepto.AutoCompletion = True
        Me.cmbConcepto.Caption = ""
        Me.cmbConcepto.CaptionHeight = 17
        Me.cmbConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbConcepto.ColumnCaptionHeight = 17
        Me.cmbConcepto.ColumnFooterHeight = 17
        Me.cmbConcepto.ContentHeight = 15
        Me.cmbConcepto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbConcepto.DropDownWidth = 250
        Me.cmbConcepto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbConcepto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConcepto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConcepto.EditorHeight = 15
        Me.cmbConcepto.Images.Add(CType(resources.GetObject("cmbConcepto.Images"), System.Drawing.Image))
        Me.cmbConcepto.ItemHeight = 15
        Me.cmbConcepto.LimitToList = True
        Me.cmbConcepto.Location = New System.Drawing.Point(564, 35)
        Me.cmbConcepto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbConcepto.MaxDropDownItems = CType(5, Short)
        Me.cmbConcepto.MaxLength = 32767
        Me.cmbConcepto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbConcepto.Name = "cmbConcepto"
        Me.cmbConcepto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbConcepto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbConcepto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbConcepto.Size = New System.Drawing.Size(157, 21)
        Me.cmbConcepto.TabIndex = 86
        Me.cmbConcepto.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbConcepto.PropBag = resources.GetString("cmbConcepto.PropBag")
        '
        'cmbClientesEstCredt
        '
        Me.cmbClientesEstCredt.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbClientesEstCredt.AutoCompletion = True
        Me.cmbClientesEstCredt.Caption = ""
        Me.cmbClientesEstCredt.CaptionHeight = 17
        Me.cmbClientesEstCredt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbClientesEstCredt.ColumnCaptionHeight = 17
        Me.cmbClientesEstCredt.ColumnFooterHeight = 17
        Me.cmbClientesEstCredt.ContentHeight = 15
        Me.cmbClientesEstCredt.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbClientesEstCredt.DropDownWidth = 250
        Me.cmbClientesEstCredt.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbClientesEstCredt.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientesEstCredt.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbClientesEstCredt.EditorHeight = 15
        Me.cmbClientesEstCredt.Images.Add(CType(resources.GetObject("cmbClientesEstCredt.Images"), System.Drawing.Image))
        Me.cmbClientesEstCredt.ItemHeight = 15
        Me.cmbClientesEstCredt.LimitToList = True
        Me.cmbClientesEstCredt.Location = New System.Drawing.Point(78, 35)
        Me.cmbClientesEstCredt.MatchEntryTimeout = CType(2000, Long)
        Me.cmbClientesEstCredt.MaxDropDownItems = CType(5, Short)
        Me.cmbClientesEstCredt.MaxLength = 32767
        Me.cmbClientesEstCredt.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbClientesEstCredt.Name = "cmbClientesEstCredt"
        Me.cmbClientesEstCredt.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbClientesEstCredt.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbClientesEstCredt.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbClientesEstCredt.Size = New System.Drawing.Size(211, 21)
        Me.cmbClientesEstCredt.TabIndex = 85
        Me.cmbClientesEstCredt.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbClientesEstCredt.PropBag = resources.GetString("cmbClientesEstCredt.PropBag")
        '
        'cmbSucursalEstCredit
        '
        Me.cmbSucursalEstCredit.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursalEstCredit.AutoCompletion = True
        Me.cmbSucursalEstCredit.Caption = ""
        Me.cmbSucursalEstCredit.CaptionHeight = 17
        Me.cmbSucursalEstCredit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursalEstCredit.ColumnCaptionHeight = 17
        Me.cmbSucursalEstCredit.ColumnFooterHeight = 17
        Me.cmbSucursalEstCredit.ContentHeight = 15
        Me.cmbSucursalEstCredit.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursalEstCredit.DropDownWidth = 250
        Me.cmbSucursalEstCredit.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursalEstCredit.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursalEstCredit.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursalEstCredit.EditorHeight = 15
        Me.cmbSucursalEstCredit.Images.Add(CType(resources.GetObject("cmbSucursalEstCredit.Images"), System.Drawing.Image))
        Me.cmbSucursalEstCredit.ItemHeight = 15
        Me.cmbSucursalEstCredit.LimitToList = True
        Me.cmbSucursalEstCredit.Location = New System.Drawing.Point(78, 8)
        Me.cmbSucursalEstCredit.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursalEstCredit.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursalEstCredit.MaxLength = 32767
        Me.cmbSucursalEstCredit.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursalEstCredit.Name = "cmbSucursalEstCredit"
        Me.cmbSucursalEstCredit.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursalEstCredit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursalEstCredit.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursalEstCredit.Size = New System.Drawing.Size(211, 21)
        Me.cmbSucursalEstCredit.TabIndex = 84
        Me.cmbSucursalEstCredit.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursalEstCredit.PropBag = resources.GetString("cmbSucursalEstCredit.PropBag")
        '
        'chkClienteFiador
        '
        Me.chkClienteFiador.AutoSize = True
        Me.chkClienteFiador.Location = New System.Drawing.Point(735, 37)
        Me.chkClienteFiador.Name = "chkClienteFiador"
        Me.chkClienteFiador.Size = New System.Drawing.Size(44, 17)
        Me.chkClienteFiador.TabIndex = 83
        Me.chkClienteFiador.Text = "CyF"
        Me.chkClienteFiador.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(564, 7)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(129, 20)
        Me.txtCedula.TabIndex = 82
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(508, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 81
        Me.Label18.Tag = ""
        Me.Label18.Text = "Concepto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Tag = ""
        Me.Label4.Text = "Cédula:"
        '
        'cmdBuscarEstadoCredi
        '
        Me.cmdBuscarEstadoCredi.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdBuscarEstadoCredi.Location = New System.Drawing.Point(697, 6)
        Me.cmdBuscarEstadoCredi.Name = "cmdBuscarEstadoCredi"
        Me.cmdBuscarEstadoCredi.Size = New System.Drawing.Size(24, 23)
        Me.cmdBuscarEstadoCredi.TabIndex = 77
        Me.cmdBuscarEstadoCredi.Text = "..."
        Me.cmdBuscarEstadoCredi.UseVisualStyleBackColor = True
        '
        'txtNoFactEstCredt
        '
        Me.txtNoFactEstCredt.Location = New System.Drawing.Point(378, 35)
        Me.txtNoFactEstCredt.Name = "txtNoFactEstCredt"
        Me.txtNoFactEstCredt.Size = New System.Drawing.Size(126, 20)
        Me.txtNoFactEstCredt.TabIndex = 76
        Me.txtNoFactEstCredt.Tag = "BLOQUEADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Tag = ""
        Me.Label3.Text = "No Factura:"
        '
        'txtExpedienteEstCredt
        '
        Me.txtExpedienteEstCredt.Location = New System.Drawing.Point(378, 6)
        Me.txtExpedienteEstCredt.Name = "txtExpedienteEstCredt"
        Me.txtExpedienteEstCredt.Size = New System.Drawing.Size(126, 20)
        Me.txtExpedienteEstCredt.TabIndex = 74
        Me.txtExpedienteEstCredt.Tag = "BLOQUEADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Tag = ""
        Me.Label2.Text = "No Expediente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Tag = ""
        Me.Label1.Text = "Cliente:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(15, 9)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 13)
        Me.lblEstado.TabIndex = 70
        Me.lblEstado.Tag = ""
        Me.lblEstado.Text = "Sucursal:"
        '
        'pagCuotasVencidas
        '
        Me.pagCuotasVencidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pagCuotasVencidas.Controls.Add(Me.cmbClientesCuotasV)
        Me.pagCuotasVencidas.Controls.Add(Me.cmbSucursalCuotasV)
        Me.pagCuotasVencidas.Controls.Add(Me.txtCedCuotasV)
        Me.pagCuotasVencidas.Controls.Add(Me.txtCantVenc)
        Me.pagCuotasVencidas.Controls.Add(Me.Label9)
        Me.pagCuotasVencidas.Controls.Add(Me.cmdBCuotasV)
        Me.pagCuotasVencidas.Controls.Add(Me.Label5)
        Me.pagCuotasVencidas.Controls.Add(Me.txtExpCuotasVenc)
        Me.pagCuotasVencidas.Controls.Add(Me.Label6)
        Me.pagCuotasVencidas.Controls.Add(Me.Label7)
        Me.pagCuotasVencidas.Controls.Add(Me.Label8)
        Me.pagCuotasVencidas.Location = New System.Drawing.Point(4, 22)
        Me.pagCuotasVencidas.Name = "pagCuotasVencidas"
        Me.pagCuotasVencidas.Padding = New System.Windows.Forms.Padding(3)
        Me.pagCuotasVencidas.Size = New System.Drawing.Size(837, 65)
        Me.pagCuotasVencidas.TabIndex = 1
        Me.pagCuotasVencidas.Text = "Cuotas Vencidas"
        Me.pagCuotasVencidas.UseVisualStyleBackColor = True
        '
        'cmbClientesCuotasV
        '
        Me.cmbClientesCuotasV.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbClientesCuotasV.AutoCompletion = True
        Me.cmbClientesCuotasV.Caption = ""
        Me.cmbClientesCuotasV.CaptionHeight = 17
        Me.cmbClientesCuotasV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbClientesCuotasV.ColumnCaptionHeight = 17
        Me.cmbClientesCuotasV.ColumnFooterHeight = 17
        Me.cmbClientesCuotasV.ContentHeight = 15
        Me.cmbClientesCuotasV.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbClientesCuotasV.DropDownWidth = 250
        Me.cmbClientesCuotasV.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbClientesCuotasV.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientesCuotasV.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbClientesCuotasV.EditorHeight = 15
        Me.cmbClientesCuotasV.Images.Add(CType(resources.GetObject("cmbClientesCuotasV.Images"), System.Drawing.Image))
        Me.cmbClientesCuotasV.ItemHeight = 15
        Me.cmbClientesCuotasV.LimitToList = True
        Me.cmbClientesCuotasV.Location = New System.Drawing.Point(75, 36)
        Me.cmbClientesCuotasV.MatchEntryTimeout = CType(2000, Long)
        Me.cmbClientesCuotasV.MaxDropDownItems = CType(5, Short)
        Me.cmbClientesCuotasV.MaxLength = 32767
        Me.cmbClientesCuotasV.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbClientesCuotasV.Name = "cmbClientesCuotasV"
        Me.cmbClientesCuotasV.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbClientesCuotasV.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbClientesCuotasV.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbClientesCuotasV.Size = New System.Drawing.Size(211, 21)
        Me.cmbClientesCuotasV.TabIndex = 94
        Me.cmbClientesCuotasV.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbClientesCuotasV.PropBag = resources.GetString("cmbClientesCuotasV.PropBag")
        '
        'cmbSucursalCuotasV
        '
        Me.cmbSucursalCuotasV.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursalCuotasV.AutoCompletion = True
        Me.cmbSucursalCuotasV.Caption = ""
        Me.cmbSucursalCuotasV.CaptionHeight = 17
        Me.cmbSucursalCuotasV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursalCuotasV.ColumnCaptionHeight = 17
        Me.cmbSucursalCuotasV.ColumnFooterHeight = 17
        Me.cmbSucursalCuotasV.ContentHeight = 15
        Me.cmbSucursalCuotasV.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursalCuotasV.DropDownWidth = 250
        Me.cmbSucursalCuotasV.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursalCuotasV.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursalCuotasV.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursalCuotasV.EditorHeight = 15
        Me.cmbSucursalCuotasV.Images.Add(CType(resources.GetObject("cmbSucursalCuotasV.Images"), System.Drawing.Image))
        Me.cmbSucursalCuotasV.ItemHeight = 15
        Me.cmbSucursalCuotasV.LimitToList = True
        Me.cmbSucursalCuotasV.Location = New System.Drawing.Point(75, 10)
        Me.cmbSucursalCuotasV.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursalCuotasV.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursalCuotasV.MaxLength = 32767
        Me.cmbSucursalCuotasV.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursalCuotasV.Name = "cmbSucursalCuotasV"
        Me.cmbSucursalCuotasV.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursalCuotasV.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursalCuotasV.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursalCuotasV.Size = New System.Drawing.Size(211, 21)
        Me.cmbSucursalCuotasV.TabIndex = 93
        Me.cmbSucursalCuotasV.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursalCuotasV.PropBag = resources.GetString("cmbSucursalCuotasV.PropBag")
        '
        'txtCedCuotasV
        '
        Me.txtCedCuotasV.Location = New System.Drawing.Point(557, 10)
        Me.txtCedCuotasV.Name = "txtCedCuotasV"
        Me.txtCedCuotasV.Size = New System.Drawing.Size(129, 20)
        Me.txtCedCuotasV.TabIndex = 92
        '
        'txtCantVenc
        '
        Me.txtCantVenc.Location = New System.Drawing.Point(378, 36)
        Me.txtCantVenc.Name = "txtCantVenc"
        Me.txtCantVenc.Size = New System.Drawing.Size(126, 20)
        Me.txtCantVenc.TabIndex = 91
        Me.txtCantVenc.Tag = "BLOQUEADO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(510, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Tag = ""
        Me.Label9.Text = "Cédula:"
        '
        'cmdBCuotasV
        '
        Me.cmdBCuotasV.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdBCuotasV.Location = New System.Drawing.Point(692, 8)
        Me.cmdBCuotasV.Name = "cmdBCuotasV"
        Me.cmdBCuotasV.Size = New System.Drawing.Size(24, 23)
        Me.cmdBCuotasV.TabIndex = 88
        Me.cmdBCuotasV.Text = "..."
        Me.cmdBCuotasV.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Tag = ""
        Me.Label5.Text = "Cantidad Venc:"
        '
        'txtExpCuotasVenc
        '
        Me.txtExpCuotasVenc.Location = New System.Drawing.Point(378, 10)
        Me.txtExpCuotasVenc.Name = "txtExpCuotasVenc"
        Me.txtExpCuotasVenc.Size = New System.Drawing.Size(126, 20)
        Me.txtExpCuotasVenc.TabIndex = 85
        Me.txtExpCuotasVenc.Tag = "BLOQUEADO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(292, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Tag = ""
        Me.Label6.Text = "No Expediente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Tag = ""
        Me.Label7.Text = "Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Tag = ""
        Me.Label8.Text = "Sucursal:"
        '
        'tabDevoluciones
        '
        Me.tabDevoluciones.Controls.Add(Me.cmbSucursalDev)
        Me.tabDevoluciones.Controls.Add(Me.dtpFechaFinDev)
        Me.tabDevoluciones.Controls.Add(Me.dtpFechaInicioDev)
        Me.tabDevoluciones.Controls.Add(Me.Label13)
        Me.tabDevoluciones.Controls.Add(Me.Label10)
        Me.tabDevoluciones.Controls.Add(Me.Button1)
        Me.tabDevoluciones.Controls.Add(Me.txtNoDevolucion)
        Me.tabDevoluciones.Controls.Add(Me.Label11)
        Me.tabDevoluciones.Controls.Add(Me.Label12)
        Me.tabDevoluciones.Location = New System.Drawing.Point(4, 22)
        Me.tabDevoluciones.Name = "tabDevoluciones"
        Me.tabDevoluciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDevoluciones.Size = New System.Drawing.Size(837, 65)
        Me.tabDevoluciones.TabIndex = 2
        Me.tabDevoluciones.Text = "Devoluciones"
        Me.tabDevoluciones.UseVisualStyleBackColor = True
        '
        'cmbSucursalDev
        '
        Me.cmbSucursalDev.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursalDev.AutoCompletion = True
        Me.cmbSucursalDev.Caption = ""
        Me.cmbSucursalDev.CaptionHeight = 17
        Me.cmbSucursalDev.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursalDev.ColumnCaptionHeight = 17
        Me.cmbSucursalDev.ColumnFooterHeight = 17
        Me.cmbSucursalDev.ContentHeight = 15
        Me.cmbSucursalDev.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursalDev.DropDownWidth = 250
        Me.cmbSucursalDev.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursalDev.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursalDev.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursalDev.EditorHeight = 15
        Me.cmbSucursalDev.Images.Add(CType(resources.GetObject("cmbSucursalDev.Images"), System.Drawing.Image))
        Me.cmbSucursalDev.ItemHeight = 15
        Me.cmbSucursalDev.LimitToList = True
        Me.cmbSucursalDev.Location = New System.Drawing.Point(94, 10)
        Me.cmbSucursalDev.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursalDev.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursalDev.MaxLength = 32767
        Me.cmbSucursalDev.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursalDev.Name = "cmbSucursalDev"
        Me.cmbSucursalDev.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursalDev.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursalDev.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursalDev.Size = New System.Drawing.Size(212, 21)
        Me.cmbSucursalDev.TabIndex = 100
        Me.cmbSucursalDev.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursalDev.PropBag = resources.GetString("cmbSucursalDev.PropBag")
        '
        'dtpFechaFinDev
        '
        Me.dtpFechaFinDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaFinDev.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFinDev.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaFinDev.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFinDev.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaFinDev.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFinDev.Location = New System.Drawing.Point(450, 35)
        Me.dtpFechaFinDev.Name = "dtpFechaFinDev"
        Me.dtpFechaFinDev.Size = New System.Drawing.Size(184, 18)
        Me.dtpFechaFinDev.TabIndex = 99
        Me.dtpFechaFinDev.Tag = "BLOQUEADO"
        Me.dtpFechaFinDev.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaFinDev.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.dtpFechaFinDev.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'dtpFechaInicioDev
        '
        Me.dtpFechaInicioDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaInicioDev.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaInicioDev.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaInicioDev.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaInicioDev.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaInicioDev.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaInicioDev.Location = New System.Drawing.Point(450, 11)
        Me.dtpFechaInicioDev.Name = "dtpFechaInicioDev"
        Me.dtpFechaInicioDev.Size = New System.Drawing.Size(184, 18)
        Me.dtpFechaInicioDev.TabIndex = 98
        Me.dtpFechaInicioDev.Tag = Nothing
        Me.dtpFechaInicioDev.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaInicioDev.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.dtpFechaInicioDev.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(376, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 97
        Me.Label13.Tag = ""
        Me.Label13.Text = "Fecha Fin:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(376, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 96
        Me.Label10.Tag = ""
        Me.Label10.Text = "Fecha Inicio:"
        '
        'Button1
        '
        Me.Button1.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.Button1.Location = New System.Drawing.Point(650, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNoDevolucion
        '
        Me.txtNoDevolucion.Location = New System.Drawing.Point(94, 35)
        Me.txtNoDevolucion.Name = "txtNoDevolucion"
        Me.txtNoDevolucion.Size = New System.Drawing.Size(212, 20)
        Me.txtNoDevolucion.TabIndex = 94
        Me.txtNoDevolucion.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 93
        Me.Label11.Tag = ""
        Me.Label11.Text = "No Devolución:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 92
        Me.Label12.Tag = ""
        Me.Label12.Text = "Sucursal:"
        '
        'tabSeguimiento
        '
        Me.tabSeguimiento.Controls.Add(Me.cmbUsuario)
        Me.tabSeguimiento.Controls.Add(Me.cmbClientesSeg)
        Me.tabSeguimiento.Controls.Add(Me.txtCedClientes)
        Me.tabSeguimiento.Controls.Add(Me.Label19)
        Me.tabSeguimiento.Controls.Add(Me.cmdBuscarSeguimientos)
        Me.tabSeguimiento.Controls.Add(Me.dtpFechFinSeg)
        Me.tabSeguimiento.Controls.Add(Me.dtpFecIniSeg)
        Me.tabSeguimiento.Controls.Add(Me.Label16)
        Me.tabSeguimiento.Controls.Add(Me.Label17)
        Me.tabSeguimiento.Controls.Add(Me.Label14)
        Me.tabSeguimiento.Controls.Add(Me.Label15)
        Me.tabSeguimiento.Location = New System.Drawing.Point(4, 22)
        Me.tabSeguimiento.Name = "tabSeguimiento"
        Me.tabSeguimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSeguimiento.Size = New System.Drawing.Size(837, 65)
        Me.tabSeguimiento.TabIndex = 3
        Me.tabSeguimiento.Text = "Seguimientos"
        Me.tabSeguimiento.UseVisualStyleBackColor = True
        '
        'cmbUsuario
        '
        Me.cmbUsuario.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUsuario.AutoCompletion = True
        Me.cmbUsuario.Caption = ""
        Me.cmbUsuario.CaptionHeight = 17
        Me.cmbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUsuario.ColumnCaptionHeight = 17
        Me.cmbUsuario.ColumnFooterHeight = 17
        Me.cmbUsuario.ContentHeight = 15
        Me.cmbUsuario.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUsuario.DropDownWidth = 250
        Me.cmbUsuario.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUsuario.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsuario.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUsuario.EditorHeight = 15
        Me.cmbUsuario.Images.Add(CType(resources.GetObject("cmbUsuario.Images"), System.Drawing.Image))
        Me.cmbUsuario.ItemHeight = 15
        Me.cmbUsuario.LimitToList = True
        Me.cmbUsuario.Location = New System.Drawing.Point(540, 6)
        Me.cmbUsuario.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUsuario.MaxDropDownItems = CType(5, Short)
        Me.cmbUsuario.MaxLength = 32767
        Me.cmbUsuario.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUsuario.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUsuario.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUsuario.Size = New System.Drawing.Size(151, 21)
        Me.cmbUsuario.TabIndex = 109
        Me.cmbUsuario.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbUsuario.PropBag = resources.GetString("cmbUsuario.PropBag")
        '
        'cmbClientesSeg
        '
        Me.cmbClientesSeg.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbClientesSeg.AutoCompletion = True
        Me.cmbClientesSeg.Caption = ""
        Me.cmbClientesSeg.CaptionHeight = 17
        Me.cmbClientesSeg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbClientesSeg.ColumnCaptionHeight = 17
        Me.cmbClientesSeg.ColumnFooterHeight = 17
        Me.cmbClientesSeg.ContentHeight = 15
        Me.cmbClientesSeg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbClientesSeg.DropDownWidth = 250
        Me.cmbClientesSeg.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbClientesSeg.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientesSeg.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbClientesSeg.EditorHeight = 15
        Me.cmbClientesSeg.Images.Add(CType(resources.GetObject("cmbClientesSeg.Images"), System.Drawing.Image))
        Me.cmbClientesSeg.ItemHeight = 15
        Me.cmbClientesSeg.LimitToList = True
        Me.cmbClientesSeg.Location = New System.Drawing.Point(79, 7)
        Me.cmbClientesSeg.MatchEntryTimeout = CType(2000, Long)
        Me.cmbClientesSeg.MaxDropDownItems = CType(5, Short)
        Me.cmbClientesSeg.MaxLength = 32767
        Me.cmbClientesSeg.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbClientesSeg.Name = "cmbClientesSeg"
        Me.cmbClientesSeg.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbClientesSeg.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbClientesSeg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbClientesSeg.Size = New System.Drawing.Size(189, 21)
        Me.cmbClientesSeg.TabIndex = 108
        Me.cmbClientesSeg.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbClientesSeg.PropBag = resources.GetString("cmbClientesSeg.PropBag")
        '
        'txtCedClientes
        '
        Me.txtCedClientes.Location = New System.Drawing.Point(79, 34)
        Me.txtCedClientes.Name = "txtCedClientes"
        Me.txtCedClientes.Size = New System.Drawing.Size(189, 20)
        Me.txtCedClientes.TabIndex = 107
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(488, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 106
        Me.Label19.Tag = ""
        Me.Label19.Text = "Usuario:"
        '
        'cmdBuscarSeguimientos
        '
        Me.cmdBuscarSeguimientos.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdBuscarSeguimientos.Location = New System.Drawing.Point(697, 5)
        Me.cmdBuscarSeguimientos.Name = "cmdBuscarSeguimientos"
        Me.cmdBuscarSeguimientos.Size = New System.Drawing.Size(24, 23)
        Me.cmdBuscarSeguimientos.TabIndex = 104
        Me.cmdBuscarSeguimientos.Text = "..."
        Me.cmdBuscarSeguimientos.UseVisualStyleBackColor = True
        '
        'dtpFechFinSeg
        '
        Me.dtpFechFinSeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechFinSeg.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechFinSeg.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechFinSeg.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechFinSeg.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechFinSeg.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechFinSeg.Location = New System.Drawing.Point(348, 31)
        Me.dtpFechFinSeg.Name = "dtpFechFinSeg"
        Me.dtpFechFinSeg.Size = New System.Drawing.Size(134, 18)
        Me.dtpFechFinSeg.TabIndex = 103
        Me.dtpFechFinSeg.Tag = "BLOQUEADO"
        Me.dtpFechFinSeg.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechFinSeg.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.dtpFechFinSeg.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'dtpFecIniSeg
        '
        Me.dtpFecIniSeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFecIniSeg.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecIniSeg.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecIniSeg.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecIniSeg.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecIniSeg.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecIniSeg.Location = New System.Drawing.Point(348, 7)
        Me.dtpFecIniSeg.Name = "dtpFecIniSeg"
        Me.dtpFecIniSeg.Size = New System.Drawing.Size(134, 18)
        Me.dtpFecIniSeg.TabIndex = 102
        Me.dtpFecIniSeg.Tag = Nothing
        Me.dtpFecIniSeg.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFecIniSeg.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.dtpFecIniSeg.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(274, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 101
        Me.Label16.Tag = ""
        Me.Label16.Text = "Fecha Fin:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(274, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 100
        Me.Label17.Tag = ""
        Me.Label17.Text = "Fecha Inicio:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Tag = ""
        Me.Label14.Text = "Cédula:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Tag = ""
        Me.Label15.Text = "Cliente:"
        '
        'tbEstadoCuentas
        '
        Me.tbEstadoCuentas.Controls.Add(Me.GroupBox3)
        Me.tbEstadoCuentas.Controls.Add(Me.GroupBox2)
        Me.tbEstadoCuentas.Controls.Add(Me.GroupBox1)
        Me.tbEstadoCuentas.Controls.Add(Me.cmdBuscarEstadoCuenta)
        Me.tbEstadoCuentas.Location = New System.Drawing.Point(4, 22)
        Me.tbEstadoCuentas.Name = "tbEstadoCuentas"
        Me.tbEstadoCuentas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEstadoCuentas.Size = New System.Drawing.Size(837, 65)
        Me.tbEstadoCuentas.TabIndex = 4
        Me.tbEstadoCuentas.Text = "Estado de Cuentas"
        Me.tbEstadoCuentas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbSucursalEstadoCuenta)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtNoExpEstadoCuenta)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Location = New System.Drawing.Point(478, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 60)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "No Expediente"
        '
        'cmbSucursalEstadoCuenta
        '
        Me.cmbSucursalEstadoCuenta.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursalEstadoCuenta.AutoCompletion = True
        Me.cmbSucursalEstadoCuenta.Caption = ""
        Me.cmbSucursalEstadoCuenta.CaptionHeight = 17
        Me.cmbSucursalEstadoCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursalEstadoCuenta.ColumnCaptionHeight = 17
        Me.cmbSucursalEstadoCuenta.ColumnFooterHeight = 17
        Me.cmbSucursalEstadoCuenta.ContentHeight = 15
        Me.cmbSucursalEstadoCuenta.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursalEstadoCuenta.DropDownWidth = 250
        Me.cmbSucursalEstadoCuenta.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursalEstadoCuenta.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursalEstadoCuenta.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursalEstadoCuenta.EditorHeight = 15
        Me.cmbSucursalEstadoCuenta.Images.Add(CType(resources.GetObject("cmbSucursalEstadoCuenta.Images"), System.Drawing.Image))
        Me.cmbSucursalEstadoCuenta.ItemHeight = 15
        Me.cmbSucursalEstadoCuenta.LimitToList = True
        Me.cmbSucursalEstadoCuenta.Location = New System.Drawing.Point(67, 11)
        Me.cmbSucursalEstadoCuenta.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursalEstadoCuenta.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursalEstadoCuenta.MaxLength = 32767
        Me.cmbSucursalEstadoCuenta.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursalEstadoCuenta.Name = "cmbSucursalEstadoCuenta"
        Me.cmbSucursalEstadoCuenta.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursalEstadoCuenta.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursalEstadoCuenta.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursalEstadoCuenta.Size = New System.Drawing.Size(140, 21)
        Me.cmbSucursalEstadoCuenta.TabIndex = 118
        Me.cmbSucursalEstadoCuenta.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursalEstadoCuenta.PropBag = resources.GetString("cmbSucursalEstadoCuenta.PropBag")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 98
        Me.Label22.Tag = ""
        Me.Label22.Text = "Sucursal:"
        '
        'txtNoExpEstadoCuenta
        '
        Me.txtNoExpEstadoCuenta.Location = New System.Drawing.Point(67, 35)
        Me.txtNoExpEstadoCuenta.Name = "txtNoExpEstadoCuenta"
        Me.txtNoExpEstadoCuenta.Size = New System.Drawing.Size(140, 20)
        Me.txtNoExpEstadoCuenta.TabIndex = 96
        Me.txtNoExpEstadoCuenta.Tag = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 95
        Me.Label21.Tag = ""
        Me.Label21.Text = "No Exp:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbNoExpediente)
        Me.GroupBox2.Controls.Add(Me.txtNoExpedienteCedula)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Location = New System.Drawing.Point(242, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 58)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cédula y Expediente"
        '
        'cmbNoExpediente
        '
        Me.cmbNoExpediente.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbNoExpediente.AutoCompletion = True
        Me.cmbNoExpediente.Caption = ""
        Me.cmbNoExpediente.CaptionHeight = 17
        Me.cmbNoExpediente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbNoExpediente.ColumnCaptionHeight = 17
        Me.cmbNoExpediente.ColumnFooterHeight = 17
        Me.cmbNoExpediente.ContentHeight = 15
        Me.cmbNoExpediente.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbNoExpediente.DropDownWidth = 250
        Me.cmbNoExpediente.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbNoExpediente.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNoExpediente.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNoExpediente.EditorHeight = 15
        Me.cmbNoExpediente.Images.Add(CType(resources.GetObject("cmbNoExpediente.Images"), System.Drawing.Image))
        Me.cmbNoExpediente.ItemHeight = 15
        Me.cmbNoExpediente.LimitToList = True
        Me.cmbNoExpediente.Location = New System.Drawing.Point(95, 35)
        Me.cmbNoExpediente.MatchEntryTimeout = CType(2000, Long)
        Me.cmbNoExpediente.MaxDropDownItems = CType(5, Short)
        Me.cmbNoExpediente.MaxLength = 32767
        Me.cmbNoExpediente.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbNoExpediente.Name = "cmbNoExpediente"
        Me.cmbNoExpediente.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbNoExpediente.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbNoExpediente.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbNoExpediente.Size = New System.Drawing.Size(126, 21)
        Me.cmbNoExpediente.TabIndex = 119
        Me.cmbNoExpediente.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbNoExpediente.PropBag = resources.GetString("cmbNoExpediente.PropBag")
        '
        'txtNoExpedienteCedula
        '
        Me.txtNoExpedienteCedula.Location = New System.Drawing.Point(95, 13)
        Me.txtNoExpedienteCedula.Name = "txtNoExpedienteCedula"
        Me.txtNoExpedienteCedula.Size = New System.Drawing.Size(126, 20)
        Me.txtNoExpedienteCedula.TabIndex = 117
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 116
        Me.Label24.Tag = ""
        Me.Label24.Text = "Cédula:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 38)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 13)
        Me.Label25.TabIndex = 115
        Me.Label25.Tag = ""
        Me.Label25.Text = "No Expediente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbtOpcion1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 46)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de búsqueda"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(116, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "No Expediente"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbtOpcion1
        '
        Me.rbtOpcion1.AutoSize = True
        Me.rbtOpcion1.Location = New System.Drawing.Point(9, 20)
        Me.rbtOpcion1.Name = "rbtOpcion1"
        Me.rbtOpcion1.Size = New System.Drawing.Size(90, 17)
        Me.rbtOpcion1.TabIndex = 0
        Me.rbtOpcion1.TabStop = True
        Me.rbtOpcion1.Text = "Cédula y Exp."
        Me.rbtOpcion1.UseVisualStyleBackColor = True
        '
        'cmdBuscarEstadoCuenta
        '
        Me.cmdBuscarEstadoCuenta.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdBuscarEstadoCuenta.Location = New System.Drawing.Point(697, 10)
        Me.cmdBuscarEstadoCuenta.Name = "cmdBuscarEstadoCuenta"
        Me.cmdBuscarEstadoCuenta.Size = New System.Drawing.Size(24, 23)
        Me.cmdBuscarEstadoCuenta.TabIndex = 112
        Me.cmdBuscarEstadoCuenta.Text = "..."
        Me.cmdBuscarEstadoCuenta.UseVisualStyleBackColor = True
        '
        'tbMorosidad
        '
        Me.tbMorosidad.Controls.Add(Me.cmbSucursalMor)
        Me.tbMorosidad.Controls.Add(Me.cmdBuscarSucMor)
        Me.tbMorosidad.Controls.Add(Me.Label20)
        Me.tbMorosidad.Location = New System.Drawing.Point(4, 22)
        Me.tbMorosidad.Name = "tbMorosidad"
        Me.tbMorosidad.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMorosidad.Size = New System.Drawing.Size(837, 65)
        Me.tbMorosidad.TabIndex = 5
        Me.tbMorosidad.Text = "Analisis de Morosidad"
        Me.tbMorosidad.UseVisualStyleBackColor = True
        '
        'cmbSucursalMor
        '
        Me.cmbSucursalMor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursalMor.AutoCompletion = True
        Me.cmbSucursalMor.Caption = ""
        Me.cmbSucursalMor.CaptionHeight = 17
        Me.cmbSucursalMor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursalMor.ColumnCaptionHeight = 17
        Me.cmbSucursalMor.ColumnFooterHeight = 17
        Me.cmbSucursalMor.ContentHeight = 15
        Me.cmbSucursalMor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursalMor.DropDownWidth = 250
        Me.cmbSucursalMor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursalMor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursalMor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursalMor.EditorHeight = 15
        Me.cmbSucursalMor.Images.Add(CType(resources.GetObject("cmbSucursalMor.Images"), System.Drawing.Image))
        Me.cmbSucursalMor.ItemHeight = 15
        Me.cmbSucursalMor.LimitToList = True
        Me.cmbSucursalMor.Location = New System.Drawing.Point(63, 11)
        Me.cmbSucursalMor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursalMor.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursalMor.MaxLength = 32767
        Me.cmbSucursalMor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursalMor.Name = "cmbSucursalMor"
        Me.cmbSucursalMor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursalMor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursalMor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursalMor.Size = New System.Drawing.Size(216, 21)
        Me.cmbSucursalMor.TabIndex = 109
        Me.cmbSucursalMor.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursalMor.PropBag = resources.GetString("cmbSucursalMor.PropBag")
        '
        'cmdBuscarSucMor
        '
        Me.cmdBuscarSucMor.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdBuscarSucMor.Location = New System.Drawing.Point(284, 9)
        Me.cmdBuscarSucMor.Name = "cmdBuscarSucMor"
        Me.cmdBuscarSucMor.Size = New System.Drawing.Size(24, 23)
        Me.cmdBuscarSucMor.TabIndex = 78
        Me.cmdBuscarSucMor.Text = "..."
        Me.cmdBuscarSucMor.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 72
        Me.Label20.Tag = ""
        Me.Label20.Text = "Sucursal:"
        '
        'TabPorcentaje
        '
        Me.TabPorcentaje.Controls.Add(Me.cmbSucursal)
        Me.TabPorcentaje.Controls.Add(Me.cmdReporte)
        Me.TabPorcentaje.Controls.Add(Me.Label23)
        Me.TabPorcentaje.Location = New System.Drawing.Point(4, 22)
        Me.TabPorcentaje.Name = "TabPorcentaje"
        Me.TabPorcentaje.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPorcentaje.Size = New System.Drawing.Size(837, 65)
        Me.TabPorcentaje.TabIndex = 6
        Me.TabPorcentaje.Text = "Clientes en Mora"
        Me.TabPorcentaje.UseVisualStyleBackColor = True
        '
        'cmbSucursal
        '
        Me.cmbSucursal.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursal.AutoCompletion = True
        Me.cmbSucursal.Caption = ""
        Me.cmbSucursal.CaptionHeight = 17
        Me.cmbSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursal.ColumnCaptionHeight = 17
        Me.cmbSucursal.ColumnFooterHeight = 17
        Me.cmbSucursal.ContentHeight = 15
        Me.cmbSucursal.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursal.DropDownWidth = 250
        Me.cmbSucursal.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursal.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursal.EditorHeight = 15
        Me.cmbSucursal.Images.Add(CType(resources.GetObject("cmbSucursal.Images"), System.Drawing.Image))
        Me.cmbSucursal.ItemHeight = 15
        Me.cmbSucursal.LimitToList = True
        Me.cmbSucursal.Location = New System.Drawing.Point(67, 16)
        Me.cmbSucursal.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursal.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursal.MaxLength = 32767
        Me.cmbSucursal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursal.Size = New System.Drawing.Size(216, 21)
        Me.cmbSucursal.TabIndex = 112
        Me.cmbSucursal.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursal.PropBag = resources.GetString("cmbSucursal.PropBag")
        '
        'cmdReporte
        '
        Me.cmdReporte.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdReporte.Location = New System.Drawing.Point(288, 14)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.Size = New System.Drawing.Size(24, 23)
        Me.cmdReporte.TabIndex = 111
        Me.cmdReporte.Text = "..."
        Me.cmdReporte.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 13)
        Me.Label23.TabIndex = 110
        Me.Label23.Tag = ""
        Me.Label23.Text = "Sucursal:"
        '
        'TabSaldo
        '
        Me.TabSaldo.Controls.Add(Me.cmbSucursalSaldo)
        Me.TabSaldo.Controls.Add(Me.Button2)
        Me.TabSaldo.Controls.Add(Me.Label26)
        Me.TabSaldo.Location = New System.Drawing.Point(4, 22)
        Me.TabSaldo.Name = "TabSaldo"
        Me.TabSaldo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSaldo.Size = New System.Drawing.Size(837, 65)
        Me.TabSaldo.TabIndex = 7
        Me.TabSaldo.Text = "Saldo Consolidado"
        Me.TabSaldo.UseVisualStyleBackColor = True
        '
        'cmbSucursalSaldo
        '
        Me.cmbSucursalSaldo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursalSaldo.AutoCompletion = True
        Me.cmbSucursalSaldo.Caption = ""
        Me.cmbSucursalSaldo.CaptionHeight = 17
        Me.cmbSucursalSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursalSaldo.ColumnCaptionHeight = 17
        Me.cmbSucursalSaldo.ColumnFooterHeight = 17
        Me.cmbSucursalSaldo.ContentHeight = 15
        Me.cmbSucursalSaldo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursalSaldo.DropDownWidth = 250
        Me.cmbSucursalSaldo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursalSaldo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursalSaldo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursalSaldo.EditorHeight = 15
        Me.cmbSucursalSaldo.Images.Add(CType(resources.GetObject("cmbSucursalSaldo.Images"), System.Drawing.Image))
        Me.cmbSucursalSaldo.ItemHeight = 15
        Me.cmbSucursalSaldo.LimitToList = True
        Me.cmbSucursalSaldo.Location = New System.Drawing.Point(67, 16)
        Me.cmbSucursalSaldo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursalSaldo.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursalSaldo.MaxLength = 32767
        Me.cmbSucursalSaldo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursalSaldo.Name = "cmbSucursalSaldo"
        Me.cmbSucursalSaldo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursalSaldo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursalSaldo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursalSaldo.Size = New System.Drawing.Size(216, 21)
        Me.cmbSucursalSaldo.TabIndex = 112
        Me.cmbSucursalSaldo.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursalSaldo.PropBag = resources.GetString("cmbSucursalSaldo.PropBag")
        '
        'Button2
        '
        Me.Button2.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.Button2.Location = New System.Drawing.Point(288, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(10, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 13)
        Me.Label26.TabIndex = 110
        Me.Label26.Tag = ""
        Me.Label26.Text = "Sucursal:"
        '
        'tagpCarteraRangos
        '
        Me.tagpCarteraRangos.Controls.Add(Me.cmbTiendaCartera)
        Me.tagpCarteraRangos.Controls.Add(Me.Button3)
        Me.tagpCarteraRangos.Controls.Add(Me.Label27)
        Me.tagpCarteraRangos.Location = New System.Drawing.Point(4, 22)
        Me.tagpCarteraRangos.Name = "tagpCarteraRangos"
        Me.tagpCarteraRangos.Padding = New System.Windows.Forms.Padding(3)
        Me.tagpCarteraRangos.Size = New System.Drawing.Size(837, 65)
        Me.tagpCarteraRangos.TabIndex = 8
        Me.tagpCarteraRangos.Text = "Cartera por Rangos"
        Me.tagpCarteraRangos.UseVisualStyleBackColor = True
        '
        'cmbTiendaCartera
        '
        Me.cmbTiendaCartera.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTiendaCartera.AutoCompletion = True
        Me.cmbTiendaCartera.Caption = ""
        Me.cmbTiendaCartera.CaptionHeight = 17
        Me.cmbTiendaCartera.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTiendaCartera.ColumnCaptionHeight = 17
        Me.cmbTiendaCartera.ColumnFooterHeight = 17
        Me.cmbTiendaCartera.ContentHeight = 15
        Me.cmbTiendaCartera.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTiendaCartera.DropDownWidth = 250
        Me.cmbTiendaCartera.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTiendaCartera.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTiendaCartera.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTiendaCartera.EditorHeight = 15
        Me.cmbTiendaCartera.Images.Add(CType(resources.GetObject("cmbTiendaCartera.Images"), System.Drawing.Image))
        Me.cmbTiendaCartera.ItemHeight = 15
        Me.cmbTiendaCartera.LimitToList = True
        Me.cmbTiendaCartera.Location = New System.Drawing.Point(67, 20)
        Me.cmbTiendaCartera.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTiendaCartera.MaxDropDownItems = CType(5, Short)
        Me.cmbTiendaCartera.MaxLength = 32767
        Me.cmbTiendaCartera.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTiendaCartera.Name = "cmbTiendaCartera"
        Me.cmbTiendaCartera.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTiendaCartera.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTiendaCartera.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTiendaCartera.Size = New System.Drawing.Size(216, 21)
        Me.cmbTiendaCartera.TabIndex = 115
        Me.cmbTiendaCartera.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbTiendaCartera.PropBag = resources.GetString("cmbTiendaCartera.PropBag")
        '
        'Button3
        '
        Me.Button3.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.Button3.Location = New System.Drawing.Point(288, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 23)
        Me.Button3.TabIndex = 114
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(10, 23)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 13)
        Me.Label27.TabIndex = 113
        Me.Label27.Tag = ""
        Me.Label27.Text = "Sucursal:"
        '
        'TabHistorialClientes
        '
        Me.TabHistorialClientes.Controls.Add(Me.cmdCargarRptHistorialCliente)
        Me.TabHistorialClientes.Controls.Add(Me.cmbClientesHistorial)
        Me.TabHistorialClientes.Controls.Add(Me.cmbSucursalHistorial)
        Me.TabHistorialClientes.Controls.Add(Me.txtExpedienteHistorial)
        Me.TabHistorialClientes.Controls.Add(Me.Label28)
        Me.TabHistorialClientes.Controls.Add(Me.Label29)
        Me.TabHistorialClientes.Controls.Add(Me.Label30)
        Me.TabHistorialClientes.Location = New System.Drawing.Point(4, 22)
        Me.TabHistorialClientes.Name = "TabHistorialClientes"
        Me.TabHistorialClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHistorialClientes.Size = New System.Drawing.Size(837, 65)
        Me.TabHistorialClientes.TabIndex = 9
        Me.TabHistorialClientes.Text = "Historial Clientes"
        Me.TabHistorialClientes.UseVisualStyleBackColor = True
        '
        'cmdCargarRptHistorialCliente
        '
        Me.cmdCargarRptHistorialCliente.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdCargarRptHistorialCliente.Location = New System.Drawing.Point(516, 6)
        Me.cmdCargarRptHistorialCliente.Name = "cmdCargarRptHistorialCliente"
        Me.cmdCargarRptHistorialCliente.Size = New System.Drawing.Size(24, 23)
        Me.cmdCargarRptHistorialCliente.TabIndex = 99
        Me.cmdCargarRptHistorialCliente.Text = "..."
        Me.cmdCargarRptHistorialCliente.UseVisualStyleBackColor = True
        '
        'cmbClientesHistorial
        '
        Me.cmbClientesHistorial.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbClientesHistorial.AutoCompletion = True
        Me.cmbClientesHistorial.Caption = ""
        Me.cmbClientesHistorial.CaptionHeight = 17
        Me.cmbClientesHistorial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbClientesHistorial.ColumnCaptionHeight = 17
        Me.cmbClientesHistorial.ColumnFooterHeight = 17
        Me.cmbClientesHistorial.ContentHeight = 15
        Me.cmbClientesHistorial.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbClientesHistorial.DropDownWidth = 250
        Me.cmbClientesHistorial.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbClientesHistorial.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientesHistorial.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbClientesHistorial.EditorHeight = 15
        Me.cmbClientesHistorial.Images.Add(CType(resources.GetObject("cmbClientesHistorial.Images"), System.Drawing.Image))
        Me.cmbClientesHistorial.ItemHeight = 15
        Me.cmbClientesHistorial.LimitToList = True
        Me.cmbClientesHistorial.Location = New System.Drawing.Point(79, 37)
        Me.cmbClientesHistorial.MatchEntryTimeout = CType(2000, Long)
        Me.cmbClientesHistorial.MaxDropDownItems = CType(5, Short)
        Me.cmbClientesHistorial.MaxLength = 32767
        Me.cmbClientesHistorial.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbClientesHistorial.Name = "cmbClientesHistorial"
        Me.cmbClientesHistorial.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbClientesHistorial.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbClientesHistorial.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbClientesHistorial.Size = New System.Drawing.Size(211, 21)
        Me.cmbClientesHistorial.TabIndex = 98
        Me.cmbClientesHistorial.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbClientesHistorial.PropBag = resources.GetString("cmbClientesHistorial.PropBag")
        '
        'cmbSucursalHistorial
        '
        Me.cmbSucursalHistorial.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursalHistorial.AutoCompletion = True
        Me.cmbSucursalHistorial.Caption = ""
        Me.cmbSucursalHistorial.CaptionHeight = 17
        Me.cmbSucursalHistorial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursalHistorial.ColumnCaptionHeight = 17
        Me.cmbSucursalHistorial.ColumnFooterHeight = 17
        Me.cmbSucursalHistorial.ContentHeight = 15
        Me.cmbSucursalHistorial.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursalHistorial.DropDownWidth = 250
        Me.cmbSucursalHistorial.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursalHistorial.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursalHistorial.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursalHistorial.EditorHeight = 15
        Me.cmbSucursalHistorial.Images.Add(CType(resources.GetObject("cmbSucursalHistorial.Images"), System.Drawing.Image))
        Me.cmbSucursalHistorial.ItemHeight = 15
        Me.cmbSucursalHistorial.LimitToList = True
        Me.cmbSucursalHistorial.Location = New System.Drawing.Point(79, 10)
        Me.cmbSucursalHistorial.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursalHistorial.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursalHistorial.MaxLength = 32767
        Me.cmbSucursalHistorial.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursalHistorial.Name = "cmbSucursalHistorial"
        Me.cmbSucursalHistorial.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursalHistorial.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursalHistorial.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursalHistorial.Size = New System.Drawing.Size(211, 21)
        Me.cmbSucursalHistorial.TabIndex = 97
        Me.cmbSucursalHistorial.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursalHistorial.PropBag = resources.GetString("cmbSucursalHistorial.PropBag")
        '
        'txtExpedienteHistorial
        '
        Me.txtExpedienteHistorial.Location = New System.Drawing.Point(379, 8)
        Me.txtExpedienteHistorial.Name = "txtExpedienteHistorial"
        Me.txtExpedienteHistorial.Size = New System.Drawing.Size(126, 20)
        Me.txtExpedienteHistorial.TabIndex = 96
        Me.txtExpedienteHistorial.Tag = "BLOQUEADO"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(297, 11)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 13)
        Me.Label28.TabIndex = 95
        Me.Label28.Tag = ""
        Me.Label28.Text = "No Expediente:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 13)
        Me.Label29.TabIndex = 94
        Me.Label29.Tag = ""
        Me.Label29.Text = "Cliente:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 11)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(51, 13)
        Me.Label30.TabIndex = 93
        Me.Label30.Tag = ""
        Me.Label30.Text = "Sucursal:"
        '
        'TabRecuperacionComp
        '
        Me.TabRecuperacionComp.Controls.Add(Me.cmdCargaComparativoRecuperacion)
        Me.TabRecuperacionComp.Controls.Add(Me.dtpFechaDesde2)
        Me.TabRecuperacionComp.Controls.Add(Me.dtpFechaHasta2)
        Me.TabRecuperacionComp.Controls.Add(Me.dtpFechaHasta1)
        Me.TabRecuperacionComp.Controls.Add(Me.dtpFechaDesde1)
        Me.TabRecuperacionComp.Controls.Add(Me.cmbSucursalesRecuperacionCmp)
        Me.TabRecuperacionComp.Controls.Add(Me.Label34)
        Me.TabRecuperacionComp.Controls.Add(Me.Label32)
        Me.TabRecuperacionComp.Controls.Add(Me.Label33)
        Me.TabRecuperacionComp.Controls.Add(Me.Label31)
        Me.TabRecuperacionComp.Controls.Add(Me.Label35)
        Me.TabRecuperacionComp.Location = New System.Drawing.Point(4, 22)
        Me.TabRecuperacionComp.Name = "TabRecuperacionComp"
        Me.TabRecuperacionComp.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRecuperacionComp.Size = New System.Drawing.Size(837, 65)
        Me.TabRecuperacionComp.TabIndex = 10
        Me.TabRecuperacionComp.Text = "Recuperación Comparativo"
        Me.TabRecuperacionComp.UseVisualStyleBackColor = True
        '
        'cmdCargaComparativoRecuperacion
        '
        Me.cmdCargaComparativoRecuperacion.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdCargaComparativoRecuperacion.Location = New System.Drawing.Point(744, 10)
        Me.cmdCargaComparativoRecuperacion.Name = "cmdCargaComparativoRecuperacion"
        Me.cmdCargaComparativoRecuperacion.Size = New System.Drawing.Size(24, 23)
        Me.cmdCargaComparativoRecuperacion.TabIndex = 116
        Me.cmdCargaComparativoRecuperacion.Text = "..."
        Me.cmdCargaComparativoRecuperacion.UseVisualStyleBackColor = True
        '
        'dtpFechaDesde2
        '
        Me.dtpFechaDesde2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDesde2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde2.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaDesde2.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde2.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaDesde2.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde2.Location = New System.Drawing.Point(330, 36)
        Me.dtpFechaDesde2.Name = "dtpFechaDesde2"
        Me.dtpFechaDesde2.Size = New System.Drawing.Size(160, 18)
        Me.dtpFechaDesde2.TabIndex = 113
        Me.dtpFechaDesde2.Tag = Nothing
        Me.dtpFechaDesde2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaDesde2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.dtpFechaDesde2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'dtpFechaHasta2
        '
        Me.dtpFechaHasta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaHasta2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta2.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaHasta2.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta2.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaHasta2.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta2.Location = New System.Drawing.Point(569, 36)
        Me.dtpFechaHasta2.Name = "dtpFechaHasta2"
        Me.dtpFechaHasta2.Size = New System.Drawing.Size(158, 18)
        Me.dtpFechaHasta2.TabIndex = 112
        Me.dtpFechaHasta2.Tag = Nothing
        Me.dtpFechaHasta2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaHasta2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.dtpFechaHasta2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'dtpFechaHasta1
        '
        Me.dtpFechaHasta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaHasta1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta1.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaHasta1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta1.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaHasta1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta1.Location = New System.Drawing.Point(569, 10)
        Me.dtpFechaHasta1.Name = "dtpFechaHasta1"
        Me.dtpFechaHasta1.Size = New System.Drawing.Size(158, 18)
        Me.dtpFechaHasta1.TabIndex = 115
        Me.dtpFechaHasta1.Tag = Nothing
        Me.dtpFechaHasta1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaHasta1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.dtpFechaHasta1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'dtpFechaDesde1
        '
        Me.dtpFechaDesde1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDesde1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde1.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaDesde1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde1.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaDesde1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde1.Location = New System.Drawing.Point(330, 10)
        Me.dtpFechaDesde1.Name = "dtpFechaDesde1"
        Me.dtpFechaDesde1.Size = New System.Drawing.Size(160, 18)
        Me.dtpFechaDesde1.TabIndex = 114
        Me.dtpFechaDesde1.Tag = Nothing
        Me.dtpFechaDesde1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaDesde1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.dtpFechaDesde1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'cmbSucursalesRecuperacionCmp
        '
        Me.cmbSucursalesRecuperacionCmp.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursalesRecuperacionCmp.AutoCompletion = True
        Me.cmbSucursalesRecuperacionCmp.Caption = ""
        Me.cmbSucursalesRecuperacionCmp.CaptionHeight = 17
        Me.cmbSucursalesRecuperacionCmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursalesRecuperacionCmp.ColumnCaptionHeight = 17
        Me.cmbSucursalesRecuperacionCmp.ColumnFooterHeight = 17
        Me.cmbSucursalesRecuperacionCmp.ContentHeight = 15
        Me.cmbSucursalesRecuperacionCmp.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursalesRecuperacionCmp.DropDownWidth = 186
        Me.cmbSucursalesRecuperacionCmp.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursalesRecuperacionCmp.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursalesRecuperacionCmp.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursalesRecuperacionCmp.EditorHeight = 15
        Me.cmbSucursalesRecuperacionCmp.Images.Add(CType(resources.GetObject("cmbSucursalesRecuperacionCmp.Images"), System.Drawing.Image))
        Me.cmbSucursalesRecuperacionCmp.ItemHeight = 15
        Me.cmbSucursalesRecuperacionCmp.LimitToList = True
        Me.cmbSucursalesRecuperacionCmp.Location = New System.Drawing.Point(73, 10)
        Me.cmbSucursalesRecuperacionCmp.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursalesRecuperacionCmp.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursalesRecuperacionCmp.MaxLength = 32767
        Me.cmbSucursalesRecuperacionCmp.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursalesRecuperacionCmp.Name = "cmbSucursalesRecuperacionCmp"
        Me.cmbSucursalesRecuperacionCmp.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursalesRecuperacionCmp.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursalesRecuperacionCmp.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursalesRecuperacionCmp.Size = New System.Drawing.Size(186, 21)
        Me.cmbSucursalesRecuperacionCmp.TabIndex = 111
        Me.cmbSucursalesRecuperacionCmp.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
        Me.cmbSucursalesRecuperacionCmp.PropBag = resources.GetString("cmbSucursalesRecuperacionCmp.PropBag")
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(527, 36)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(38, 13)
        Me.Label34.TabIndex = 107
        Me.Label34.Tag = ""
        Me.Label34.Text = "Hasta:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(525, 10)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(38, 13)
        Me.Label32.TabIndex = 106
        Me.Label32.Tag = ""
        Me.Label32.Text = "Hasta:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(286, 36)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(41, 13)
        Me.Label33.TabIndex = 108
        Me.Label33.Tag = ""
        Me.Label33.Text = "Desde:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(287, 10)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 13)
        Me.Label31.TabIndex = 110
        Me.Label31.Tag = ""
        Me.Label31.Text = "Desde:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 11)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(51, 13)
        Me.Label35.TabIndex = 109
        Me.Label35.Tag = ""
        Me.Label35.Text = "Sucursal:"
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.tstNotaCredito)
        Me.Contenedor.Controls.Add(Me.VisorReporte)
        Me.Contenedor.Controls.Add(Me.TabControl1)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "4.17391304347826:False:True;15.8260869565217:False:True;74.7826086956522:False:Fa" & _
            "lse;1.73913043478261:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0621336459555:False:False;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(0, 0)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(853, 575)
        Me.Contenedor.TabIndex = 0
        Me.Contenedor.TabStop = False
        '
        'tstNotaCredito
        '
        Me.tstNotaCredito.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstNotaCredito.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cmdSalir})
        Me.tstNotaCredito.Location = New System.Drawing.Point(4, 4)
        Me.tstNotaCredito.Name = "tstNotaCredito"
        Me.tstNotaCredito.Size = New System.Drawing.Size(845, 24)
        Me.tstNotaCredito.TabIndex = 4
        Me.tstNotaCredito.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 24)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(23, 21)
        Me.cmdSalir.ToolTipText = "Cerrar Formulario de Reportes"
        '
        'VisorReporte
        '
        ReportDataSource2.Name = "DtDatosCuotas_vwRptCuotasVencidas"
        ReportDataSource2.Value = Nothing
        Me.VisorReporte.LocalReport.DataSources.Add(ReportDataSource2)
        Me.VisorReporte.LocalReport.ReportEmbeddedResource = ""
        Me.VisorReporte.Location = New System.Drawing.Point(4, 127)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ShowStopButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(845, 430)
        Me.VisorReporte.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 559)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(853, 16)
        Me.Panel1.TabIndex = 26
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'ToolTip
        '
        Me.ToolTip.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ToolTip.IsBalloon = True
        '
        'frmStbVisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Contenedor)
        Me.Name = "frmStbVisor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.pagEstadoCrediticio.ResumeLayout(False)
        Me.pagEstadoCrediticio.PerformLayout()
        CType(Me.cmbConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbClientesEstCredt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursalEstCredit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCuotasVencidas.ResumeLayout(False)
        Me.pagCuotasVencidas.PerformLayout()
        CType(Me.cmbClientesCuotasV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursalCuotasV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDevoluciones.ResumeLayout(False)
        Me.tabDevoluciones.PerformLayout()
        CType(Me.cmbSucursalDev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFinDev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioDev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSeguimiento.ResumeLayout(False)
        Me.tabSeguimiento.PerformLayout()
        CType(Me.cmbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbClientesSeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechFinSeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecIniSeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbEstadoCuentas.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cmbSucursalEstadoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbNoExpediente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbMorosidad.ResumeLayout(False)
        Me.tbMorosidad.PerformLayout()
        CType(Me.cmbSucursalMor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPorcentaje.ResumeLayout(False)
        Me.TabPorcentaje.PerformLayout()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSaldo.ResumeLayout(False)
        Me.TabSaldo.PerformLayout()
        CType(Me.cmbSucursalSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tagpCarteraRangos.ResumeLayout(False)
        Me.tagpCarteraRangos.PerformLayout()
        CType(Me.cmbTiendaCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabHistorialClientes.ResumeLayout(False)
        Me.TabHistorialClientes.PerformLayout()
        CType(Me.cmbClientesHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursalHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRecuperacionComp.ResumeLayout(False)
        Me.TabRecuperacionComp.PerformLayout()
        CType(Me.dtpFechaDesde2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaHasta2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaHasta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursalesRecuperacionCmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        Me.Contenedor.PerformLayout()
        Me.tstNotaCredito.ResumeLayout(False)
        Me.tstNotaCredito.PerformLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents pagEstadoCrediticio As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarEstadoCredi As System.Windows.Forms.Button
    Friend WithEvents txtNoFactEstCredt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExpedienteEstCredt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents pagCuotasVencidas As System.Windows.Forms.TabPage
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents tstNotaCredito As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdBCuotasV As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtExpCuotasVenc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCantVenc As System.Windows.Forms.TextBox
    Friend WithEvents tabDevoluciones As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNoDevolucion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFinDev As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaInicioDev As C1.Win.C1Input.C1DateEdit
    Friend WithEvents tabSeguimiento As System.Windows.Forms.TabPage
    Friend WithEvents cmdBuscarSeguimientos As System.Windows.Forms.Button
    Friend WithEvents dtpFechFinSeg As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFecIniSeg As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents VisorReporte As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbEstadoCuentas As System.Windows.Forms.TabPage
    Friend WithEvents tbMorosidad As System.Windows.Forms.TabPage
    Friend WithEvents cmdBuscarEstadoCuenta As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarSucMor As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCedCuotasV As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCedClientes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoExpEstadoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoExpedienteCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOpcion1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents chkClienteFiador As System.Windows.Forms.CheckBox
    Friend WithEvents cmbConcepto As C1.Win.C1List.C1Combo
    Friend WithEvents cmbClientesEstCredt As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSucursalEstCredit As C1.Win.C1List.C1Combo
    Friend WithEvents cmbClientesCuotasV As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSucursalCuotasV As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSucursalDev As C1.Win.C1List.C1Combo
    Friend WithEvents cmbUsuario As C1.Win.C1List.C1Combo
    Friend WithEvents cmbClientesSeg As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSucursalMor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSucursalEstadoCuenta As C1.Win.C1List.C1Combo
    Friend WithEvents cmbNoExpediente As C1.Win.C1List.C1Combo
    Friend WithEvents TabPorcentaje As System.Windows.Forms.TabPage
    Friend WithEvents cmbSucursal As C1.Win.C1List.C1Combo
    Friend WithEvents cmdReporte As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TabSaldo As System.Windows.Forms.TabPage
    Friend WithEvents cmbSucursalSaldo As C1.Win.C1List.C1Combo
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tagpCarteraRangos As System.Windows.Forms.TabPage
    Friend WithEvents cmbTiendaCartera As C1.Win.C1List.C1Combo
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TabHistorialClientes As System.Windows.Forms.TabPage
    Friend WithEvents cmdCargarRptHistorialCliente As System.Windows.Forms.Button
    Friend WithEvents cmbClientesHistorial As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSucursalHistorial As C1.Win.C1List.C1Combo
    Friend WithEvents txtExpedienteHistorial As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TabRecuperacionComp As System.Windows.Forms.TabPage
    Friend WithEvents cmdCargaComparativoRecuperacion As System.Windows.Forms.Button
    Friend WithEvents dtpFechaDesde2 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaHasta2 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaHasta1 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaDesde1 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbSucursalesRecuperacionCmp As C1.Win.C1List.C1Combo
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
End Class
