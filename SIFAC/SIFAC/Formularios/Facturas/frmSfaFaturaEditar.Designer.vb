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
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.lblfact = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GrpExpediente = New System.Windows.Forms.GroupBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmdExpediente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.numDescuentoPorc = New C1.Win.C1Input.C1NumericEdit()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdProcesar = New System.Windows.Forms.Button()
        Me.ToolTip = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numFinancimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMontoCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpExpediente.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numDescuentoPorc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtpUltimoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaProximoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.lblfact)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 165)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(488, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Principales"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 149)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Tag = "OBLIGATORIO"
        Me.Label14.Text = "Financiamiento:"
        '
        'numFinancimiento
        '
        Me.numFinancimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numFinancimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numFinancimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numFinancimiento.Location = New System.Drawing.Point(121, 146)
        Me.numFinancimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.numFinancimiento.Name = "numFinancimiento"
        Me.numFinancimiento.Size = New System.Drawing.Size(332, 20)
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
        Me.Label5.Location = New System.Drawing.Point(11, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Tag = "OBLIGATORIO"
        Me.Label5.Text = "Prima:"
        '
        'numPrima
        '
        Me.numPrima.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numPrima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numPrima.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numPrima.Location = New System.Drawing.Point(121, 117)
        Me.numPrima.Margin = New System.Windows.Forms.Padding(4)
        Me.numPrima.Name = "numPrima"
        Me.numPrima.Size = New System.Drawing.Size(332, 20)
        Me.numPrima.TabIndex = 4
        Me.numPrima.Tag = Nothing
        Me.numPrima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPrima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numPrima.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numPrima.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'numCuotas
        '
        Me.numCuotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numCuotas.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numCuotas.Location = New System.Drawing.Point(121, 174)
        Me.numCuotas.Margin = New System.Windows.Forms.Padding(4)
        Me.numCuotas.Name = "numCuotas"
        Me.numCuotas.Size = New System.Drawing.Size(332, 20)
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
        Me.Label1.Location = New System.Drawing.Point(11, 176)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "No Cuotas:"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(11, 234)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(48, 17)
        Me.lblSaldo.TabIndex = 21
        Me.lblSaldo.Tag = "OBLIGATORIO"
        Me.lblSaldo.Text = "Saldo:"
        '
        'numSaldo
        '
        Me.numSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSaldo.Location = New System.Drawing.Point(121, 231)
        Me.numSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.numSaldo.Name = "numSaldo"
        Me.numSaldo.Size = New System.Drawing.Size(332, 20)
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
        Me.lblMonto.Location = New System.Drawing.Point(11, 92)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(87, 17)
        Me.lblMonto.TabIndex = 19
        Me.lblMonto.Tag = "OBLIGATORIO"
        Me.lblMonto.Text = "Monto Total:"
        '
        'NumMonto
        '
        Me.NumMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NumMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumMonto.Location = New System.Drawing.Point(121, 90)
        Me.NumMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.NumMonto.Name = "NumMonto"
        Me.NumMonto.Size = New System.Drawing.Size(332, 20)
        Me.NumMonto.TabIndex = 3
        Me.NumMonto.Tag = "5"
        Me.NumMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.NumMonto.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'numMontoCuotas
        '
        Me.numMontoCuotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numMontoCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numMontoCuotas.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMontoCuotas.Location = New System.Drawing.Point(121, 202)
        Me.numMontoCuotas.Margin = New System.Windows.Forms.Padding(4)
        Me.numMontoCuotas.Name = "numMontoCuotas"
        Me.numMontoCuotas.Size = New System.Drawing.Size(332, 20)
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
        Me.Label2.Location = New System.Drawing.Point(11, 204)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Monto Cuotas:"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(121, 57)
        Me.txtFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(331, 22)
        Me.txtFactura.TabIndex = 2
        Me.txtFactura.Tag = "OBLIGATORIO"
        '
        'lblfact
        '
        Me.lblfact.AutoSize = True
        Me.lblfact.Location = New System.Drawing.Point(11, 60)
        Me.lblfact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfact.Name = "lblfact"
        Me.lblfact.Size = New System.Drawing.Size(86, 17)
        Me.lblfact.TabIndex = 1
        Me.lblfact.Tag = "OBLIGATORIO"
        Me.lblfact.Text = "No. Factura:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 579)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 27)
        Me.Panel1.TabIndex = 3
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(915, 39)
        Me.Panel2.TabIndex = 4
        Me.Panel2.Tag = "LAYOUT"
        '
        'GrpExpediente
        '
        Me.GrpExpediente.Controls.Add(Me.cmdConsultar)
        Me.GrpExpediente.Controls.Add(Me.cmdExpediente)
        Me.GrpExpediente.Controls.Add(Me.txtCliente)
        Me.GrpExpediente.Controls.Add(Me.Label11)
        Me.GrpExpediente.Controls.Add(Me.txtNumCuenta)
        Me.GrpExpediente.Controls.Add(Me.Label12)
        Me.GrpExpediente.Location = New System.Drawing.Point(16, 49)
        Me.GrpExpediente.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpExpediente.Size = New System.Drawing.Size(496, 112)
        Me.GrpExpediente.TabIndex = 19
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos Expediente"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdConsultar.Location = New System.Drawing.Point(425, 18)
        Me.cmdConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(32, 28)
        Me.cmdConsultar.TabIndex = 18
        Me.cmdConsultar.Text = "..."
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmdExpediente
        '
        Me.cmdExpediente.Location = New System.Drawing.Point(390, 18)
        Me.cmdExpediente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExpediente.Name = "cmdExpediente"
        Me.cmdExpediente.Size = New System.Drawing.Size(32, 28)
        Me.cmdExpediente.TabIndex = 0
        Me.cmdExpediente.Text = "..."
        Me.cmdExpediente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(121, 50)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(336, 22)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 54)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Tag = "OBLIGATORIO"
        Me.Label11.Text = "Cliente:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Location = New System.Drawing.Point(121, 21)
        Me.txtNumCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(188, 22)
        Me.txtNumCuenta.TabIndex = 3
        Me.txtNumCuenta.Tag = "BLOQUEADO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Tag = "OBLIGATORIO"
        Me.Label12.Text = "No. Exp:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtEstado)
        Me.GroupBox5.Controls.Add(Me.lblEstado)
        Me.GroupBox5.Location = New System.Drawing.Point(525, 265)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(380, 80)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Estado y Calificación"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(115, 47)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(240, 22)
        Me.txtEstado.TabIndex = 4
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(13, 50)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(56, 17)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "Estado:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.numDescuentoPorc)
        Me.GroupBox3.Controls.Add(Me.lblDescuento)
        Me.GroupBox3.Location = New System.Drawing.Point(525, 347)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(376, 80)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modalidad de pago"
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
        Me.numDescuentoPorc.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numDescuentoPorc.Location = New System.Drawing.Point(150, 26)
        Me.numDescuentoPorc.Margin = New System.Windows.Forms.Padding(4)
        Me.numDescuentoPorc.Name = "numDescuentoPorc"
        Me.numDescuentoPorc.Size = New System.Drawing.Size(196, 20)
        Me.numDescuentoPorc.TabIndex = 12
        Me.numDescuentoPorc.Tag = "-"
        Me.numDescuentoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDescuentoPorc.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numDescuentoPorc.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        Me.numDescuentoPorc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(10, 28)
        Me.lblDescuento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(106, 17)
        Me.lblDescuento.TabIndex = 3
        Me.lblDescuento.Text = "Descuento (%):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox2.Controls.Add(Me.dtpFechaCredito)
        Me.GroupBox2.Controls.Add(Me.cmbPlazo)
        Me.GroupBox2.Controls.Add(Me.lblFechaVencimiento)
        Me.GroupBox2.Controls.Add(Me.lblFechaCredito)
        Me.GroupBox2.Controls.Add(Me.lblTerminoPlazo)
        Me.GroupBox2.Location = New System.Drawing.Point(523, 48)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(383, 212)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Período"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpUltimoPago)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.dtpFechaProximoPago)
        Me.GroupBox4.Controls.Add(Me.lblFechaPago)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 111)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(368, 90)
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
        Me.dtpUltimoPago.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpUltimoPago.Location = New System.Drawing.Point(153, 55)
        Me.dtpUltimoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpUltimoPago.Name = "dtpUltimoPago"
        Me.dtpUltimoPago.Size = New System.Drawing.Size(196, 22)
        Me.dtpUltimoPago.TabIndex = 15
        Me.dtpUltimoPago.Tag = "BLOQUEADO"
        Me.dtpUltimoPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 58)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
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
        Me.dtpFechaProximoPago.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaProximoPago.Location = New System.Drawing.Point(153, 23)
        Me.dtpFechaProximoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaProximoPago.Name = "dtpFechaProximoPago"
        Me.dtpFechaProximoPago.Size = New System.Drawing.Size(196, 22)
        Me.dtpFechaProximoPago.TabIndex = 13
        Me.dtpFechaProximoPago.Tag = "BLOQUEADO"
        Me.dtpFechaProximoPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaPago
        '
        Me.lblFechaPago.AutoSize = True
        Me.lblFechaPago.Location = New System.Drawing.Point(27, 27)
        Me.lblFechaPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(99, 17)
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
        Me.dtpFechaVencimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(159, 82)
        Me.dtpFechaVencimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(196, 22)
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
        Me.dtpFechaCredito.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaCredito.Location = New System.Drawing.Point(159, 50)
        Me.dtpFechaCredito.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaCredito.Name = "dtpFechaCredito"
        Me.dtpFechaCredito.Size = New System.Drawing.Size(196, 22)
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
        Me.cmbPlazo.ContentHeight = 18
        Me.cmbPlazo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPlazo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPlazo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlazo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPlazo.EditorHeight = 18
        Me.cmbPlazo.Images.Add(CType(resources.GetObject("cmbPlazo.Images"), System.Drawing.Image))
        Me.cmbPlazo.ItemHeight = 15
        Me.cmbPlazo.Location = New System.Drawing.Point(159, 17)
        Me.cmbPlazo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPlazo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPlazo.MaxDropDownItems = CType(5, Short)
        Me.cmbPlazo.MaxLength = 32767
        Me.cmbPlazo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPlazo.Name = "cmbPlazo"
        Me.cmbPlazo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPlazo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPlazo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPlazo.Size = New System.Drawing.Size(196, 24)
        Me.cmbPlazo.TabIndex = 5
        Me.cmbPlazo.PropBag = resources.GetString("cmbPlazo.PropBag")
        '
        'lblFechaVencimiento
        '
        Me.lblFechaVencimiento.AutoSize = True
        Me.lblFechaVencimiento.Location = New System.Drawing.Point(13, 85)
        Me.lblFechaVencimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaVencimiento.Name = "lblFechaVencimiento"
        Me.lblFechaVencimiento.Size = New System.Drawing.Size(132, 17)
        Me.lblFechaVencimiento.TabIndex = 2
        Me.lblFechaVencimiento.Text = "Fecha Vencimiento:"
        '
        'lblFechaCredito
        '
        Me.lblFechaCredito.AutoSize = True
        Me.lblFechaCredito.Location = New System.Drawing.Point(13, 54)
        Me.lblFechaCredito.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaCredito.Name = "lblFechaCredito"
        Me.lblFechaCredito.Size = New System.Drawing.Size(100, 17)
        Me.lblFechaCredito.TabIndex = 1
        Me.lblFechaCredito.Text = "Fecha Crédito:"
        '
        'lblTerminoPlazo
        '
        Me.lblTerminoPlazo.AutoSize = True
        Me.lblTerminoPlazo.Location = New System.Drawing.Point(13, 22)
        Me.lblTerminoPlazo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTerminoPlazo.Name = "lblTerminoPlazo"
        Me.lblTerminoPlazo.Size = New System.Drawing.Size(103, 17)
        Me.lblTerminoPlazo.TabIndex = 0
        Me.lblTerminoPlazo.Text = "Término Plazo:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(805, 529)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 24
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(592, 529)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(100, 34)
        Me.cmdAceptar.TabIndex = 23
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdProcesar
        '
        Me.cmdProcesar.BackgroundImage = Global.SIFAC.My.Resources.Resources.Aprobar
        Me.cmdProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdProcesar.Enabled = False
        Me.cmdProcesar.Location = New System.Drawing.Point(700, 529)
        Me.cmdProcesar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(100, 34)
        Me.cmdProcesar.TabIndex = 26
        Me.cmdProcesar.Tag = ""
        Me.cmdProcesar.Text = "&Procesar"
        Me.cmdProcesar.UseVisualStyleBackColor = True
        '
        'ToolTip
        '
        Me.ToolTip.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ToolTip.IsBalloon = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(19, 553)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 17)
        Me.lblInfo.TabIndex = 27
        '
        'frmSfaFaturaEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 606)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.cmdProcesar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrpExpediente)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaFaturaEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura-Expediente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numFinancimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMontoCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numDescuentoPorc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtpUltimoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaProximoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfact As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GrpExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExpediente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNumCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents numMontoCuotas As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents numDescuentoPorc As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
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
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpUltimoPago As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaProximoPago As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents cmdProcesar As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents ToolTip As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numPrima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents numFinancimiento As C1.Win.C1Input.C1NumericEdit
End Class
