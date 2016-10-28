<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccCuentasEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccCuentasEditar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaCredito = New C1.Win.C1Input.C1DateEdit()
        Me.lblFechaCredito = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numSaldoInicial = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.objUbicacionHojaContrato = New System.Windows.Forms.OpenFileDialog()
        Me.tbcCuentas = New System.Windows.Forms.TabControl()
        Me.pgClientes = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmdConsultarCliente = New System.Windows.Forms.Button()
        Me.txtTipoPersona = New System.Windows.Forms.TextBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.lblTipoPersona = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.cmdBuscarCliente = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tbFacturas = New System.Windows.Forms.TabControl()
        Me.PGFacturas = New System.Windows.Forms.TabPage()
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdBuscarFacturas = New System.Windows.Forms.Button()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdConsultarFacturas = New System.Windows.Forms.Button()
        Me.cmdProcesarFacturas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFechaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.numSaldoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcCuentas.SuspendLayout()
        Me.pgClientes.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.tbFacturas.SuspendLayout()
        Me.PGFacturas.SuspendLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.lblCuenta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(427, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Expediente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(145, 54)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(245, 23)
        Me.txtEstado.TabIndex = 15
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpFechaCredito)
        Me.GroupBox2.Controls.Add(Me.lblFechaCredito)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 86)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(405, 42)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo"
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
        Me.dtpFechaCredito.Calendar.SelectedDate = New Date(2016, 9, 1, 0, 0, 0, 0)
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
        Me.dtpFechaCredito.Location = New System.Drawing.Point(136, 14)
        Me.dtpFechaCredito.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaCredito.Name = "dtpFechaCredito"
        Me.dtpFechaCredito.Size = New System.Drawing.Size(245, 23)
        Me.dtpFechaCredito.TabIndex = 2
        Me.dtpFechaCredito.Tag = Nothing
        Me.dtpFechaCredito.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaCredito
        '
        Me.lblFechaCredito.AutoSize = True
        Me.lblFechaCredito.Location = New System.Drawing.Point(8, 20)
        Me.lblFechaCredito.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaCredito.Name = "lblFechaCredito"
        Me.lblFechaCredito.Size = New System.Drawing.Size(114, 17)
        Me.lblFechaCredito.TabIndex = 1
        Me.lblFechaCredito.Text = "Fecha Credito:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(145, 23)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(161, 23)
        Me.txtCuenta.TabIndex = 1
        Me.txtCuenta.Tag = "BLOQUEADO"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(24, 26)
        Me.lblCuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(123, 17)
        Me.lblCuenta.TabIndex = 0
        Me.lblCuenta.Text = "No. Expediente:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtUsuario)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.numSaldoInicial)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.numSaldo)
        Me.GroupBox4.Controls.Add(Me.lblSaldo)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(444, 26)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(372, 142)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Información Financiera del Expediente"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(144, 98)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(195, 23)
        Me.txtUsuario.TabIndex = 19
        Me.txtUsuario.Tag = "BLOQUEADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Usuario:"
        '
        'numSaldoInicial
        '
        Me.numSaldoInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numSaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numSaldoInicial.EmptyAsNull = True
        Me.numSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSaldoInicial.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSaldoInicial.Location = New System.Drawing.Point(145, 23)
        Me.numSaldoInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.numSaldoInicial.Name = "numSaldoInicial"
        Me.numSaldoInicial.ReadOnly = True
        Me.numSaldoInicial.Size = New System.Drawing.Size(196, 21)
        Me.numSaldoInicial.TabIndex = 17
        Me.numSaldoInicial.Tag = "BLOQUEADO"
        Me.numSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSaldoInicial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numSaldoInicial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numSaldoInicial.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Saldo Inicial:"
        '
        'numSaldo
        '
        Me.numSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numSaldo.EmptyAsNull = True
        Me.numSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSaldo.Location = New System.Drawing.Point(144, 57)
        Me.numSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.numSaldo.Name = "numSaldo"
        Me.numSaldo.ReadOnly = True
        Me.numSaldo.Size = New System.Drawing.Size(196, 21)
        Me.numSaldo.TabIndex = 15
        Me.numSaldo.Tag = "BLOQUEADO"
        Me.numSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numSaldo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(13, 57)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(54, 17)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Saldo:"
        '
        'objUbicacionHojaContrato
        '
        Me.objUbicacionHojaContrato.FileName = "Hoja de Contrato"
        Me.objUbicacionHojaContrato.Filter = "JPEG Files | *.jpg"
        '
        'tbcCuentas
        '
        Me.tbcCuentas.Controls.Add(Me.pgClientes)
        Me.tbcCuentas.Location = New System.Drawing.Point(9, 176)
        Me.tbcCuentas.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcCuentas.Name = "tbcCuentas"
        Me.tbcCuentas.SelectedIndex = 0
        Me.tbcCuentas.Size = New System.Drawing.Size(805, 215)
        Me.tbcCuentas.TabIndex = 8
        '
        'pgClientes
        '
        Me.pgClientes.Controls.Add(Me.GroupBox6)
        Me.pgClientes.Location = New System.Drawing.Point(4, 25)
        Me.pgClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.pgClientes.Name = "pgClientes"
        Me.pgClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.pgClientes.Size = New System.Drawing.Size(797, 186)
        Me.pgClientes.TabIndex = 0
        Me.pgClientes.Text = "Cliente"
        Me.pgClientes.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdConsultarCliente)
        Me.GroupBox6.Controls.Add(Me.txtTipoPersona)
        Me.GroupBox6.Controls.Add(Me.txtNacionalidad)
        Me.GroupBox6.Controls.Add(Me.lblTipoPersona)
        Me.GroupBox6.Controls.Add(Me.lblNacionalidad)
        Me.GroupBox6.Controls.Add(Me.txtGenero)
        Me.GroupBox6.Controls.Add(Me.lblGenero)
        Me.GroupBox6.Controls.Add(Me.cmdBuscarCliente)
        Me.GroupBox6.Controls.Add(Me.txtCedula)
        Me.GroupBox6.Controls.Add(Me.txtDireccion)
        Me.GroupBox6.Controls.Add(Me.lblCedula)
        Me.GroupBox6.Controls.Add(Me.lblDireccion)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Controls.Add(Me.lblNombre)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(789, 178)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Tag = "BLOQUEADO"
        Me.GroupBox6.Text = "Datos de cliente"
        '
        'cmdConsultarCliente
        '
        Me.cmdConsultarCliente.Image = CType(resources.GetObject("cmdConsultarCliente.Image"), System.Drawing.Image)
        Me.cmdConsultarCliente.Location = New System.Drawing.Point(749, 27)
        Me.cmdConsultarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConsultarCliente.Name = "cmdConsultarCliente"
        Me.cmdConsultarCliente.Size = New System.Drawing.Size(31, 28)
        Me.cmdConsultarCliente.TabIndex = 15
        Me.cmdConsultarCliente.Text = "..."
        Me.cmdConsultarCliente.UseVisualStyleBackColor = True
        '
        'txtTipoPersona
        '
        Me.txtTipoPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoPersona.Location = New System.Drawing.Point(587, 130)
        Me.txtTipoPersona.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoPersona.Name = "txtTipoPersona"
        Me.txtTipoPersona.Size = New System.Drawing.Size(179, 23)
        Me.txtTipoPersona.TabIndex = 14
        Me.txtTipoPersona.Tag = "BLOQUEADO"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacionalidad.Location = New System.Drawing.Point(256, 127)
        Me.txtNacionalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(197, 23)
        Me.txtNacionalidad.TabIndex = 13
        Me.txtNacionalidad.Tag = "BLOQUEADO"
        '
        'lblTipoPersona
        '
        Me.lblTipoPersona.AutoSize = True
        Me.lblTipoPersona.Location = New System.Drawing.Point(464, 134)
        Me.lblTipoPersona.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoPersona.Name = "lblTipoPersona"
        Me.lblTipoPersona.Size = New System.Drawing.Size(110, 17)
        Me.lblTipoPersona.TabIndex = 12
        Me.lblTipoPersona.Text = "Tipo Persona:"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(3, 130)
        Me.lblNacionalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(107, 17)
        Me.lblNacionalidad.TabIndex = 11
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'txtGenero
        '
        Me.txtGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenero.Location = New System.Drawing.Point(587, 96)
        Me.txtGenero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(179, 23)
        Me.txtGenero.TabIndex = 10
        Me.txtGenero.Tag = "BLOQUEADO"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(508, 100)
        Me.lblGenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(67, 17)
        Me.lblGenero.TabIndex = 9
        Me.lblGenero.Text = "Genero:"
        '
        'cmdBuscarCliente
        '
        Me.cmdBuscarCliente.Location = New System.Drawing.Point(708, 27)
        Me.cmdBuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscarCliente.Name = "cmdBuscarCliente"
        Me.cmdBuscarCliente.Size = New System.Drawing.Size(37, 28)
        Me.cmdBuscarCliente.TabIndex = 7
        Me.cmdBuscarCliente.Text = "..."
        Me.cmdBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(256, 96)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(197, 23)
        Me.txtCedula.TabIndex = 5
        Me.txtCedula.Tag = "BLOQUEADO"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(256, 64)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(509, 23)
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(4, 100)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(63, 17)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Cedula:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(4, 69)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(81, 17)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(256, 30)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(445, 23)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Tag = "BLOQUEADO"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(0, 33)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(246, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre Completo/Razon Social: "
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.C1TrueDBGrid1)
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(600, 149)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Fiadores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowColMove = False
        Me.C1TrueDBGrid1.AllowUpdate = False
        Me.C1TrueDBGrid1.Caption = "Fiadores"
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(3, 30)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(594, 116)
        Me.C1TrueDBGrid1.TabIndex = 4
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(594, 27)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton1.ToolTipText = "AGREGAR"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton2.ToolTipText = "ELIMINAR"
        '
        'tbFacturas
        '
        Me.tbFacturas.Controls.Add(Me.PGFacturas)
        Me.tbFacturas.Location = New System.Drawing.Point(9, 420)
        Me.tbFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFacturas.Name = "tbFacturas"
        Me.tbFacturas.SelectedIndex = 0
        Me.tbFacturas.Size = New System.Drawing.Size(805, 203)
        Me.tbFacturas.TabIndex = 10
        '
        'PGFacturas
        '
        Me.PGFacturas.Controls.Add(Me.grdFacturas)
        Me.PGFacturas.Location = New System.Drawing.Point(4, 25)
        Me.PGFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.PGFacturas.Name = "PGFacturas"
        Me.PGFacturas.Padding = New System.Windows.Forms.Padding(4)
        Me.PGFacturas.Size = New System.Drawing.Size(797, 174)
        Me.PGFacturas.TabIndex = 0
        Me.PGFacturas.Text = "Facturas"
        Me.PGFacturas.UseVisualStyleBackColor = True
        '
        'grdFacturas
        '
        Me.grdFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFacturas.ExtendRightColumn = True
        Me.grdFacturas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(4, 4)
        Me.grdFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(789, 166)
        Me.grdFacturas.TabIndex = 0
        Me.grdFacturas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 683)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 25)
        Me.Panel1.TabIndex = 12
        '
        'ToolTip
        '
        Me.ToolTip.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ToolTip.IsBalloon = True
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Location = New System.Drawing.Point(11, 640)
        Me.lblinfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(0, 17)
        Me.lblinfo.TabIndex = 16
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdProcesarFacturas)
        Me.PanelControl1.Controls.Add(Me.cmdConsultarFacturas)
        Me.PanelControl1.Controls.Add(Me.cmdBuscarFacturas)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.tbcCuentas)
        Me.PanelControl1.Controls.Add(Me.tbFacturas)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(829, 708)
        Me.PanelControl1.TabIndex = 17
        '
        'cmdBuscarFacturas
        '
        Me.cmdBuscarFacturas.Image = CType(resources.GetObject("cmdBuscarFacturas.Image"), System.Drawing.Image)
        Me.cmdBuscarFacturas.Location = New System.Drawing.Point(705, 412)
        Me.cmdBuscarFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscarFacturas.Name = "cmdBuscarFacturas"
        Me.cmdBuscarFacturas.Size = New System.Drawing.Size(31, 28)
        Me.cmdBuscarFacturas.TabIndex = 16
        Me.cmdBuscarFacturas.Text = "..."
        Me.cmdBuscarFacturas.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(703, 640)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(587, 640)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 11
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'cmdConsultarFacturas
        '
        Me.cmdConsultarFacturas.Image = CType(resources.GetObject("cmdConsultarFacturas.Image"), System.Drawing.Image)
        Me.cmdConsultarFacturas.Location = New System.Drawing.Point(783, 412)
        Me.cmdConsultarFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConsultarFacturas.Name = "cmdConsultarFacturas"
        Me.cmdConsultarFacturas.Size = New System.Drawing.Size(31, 28)
        Me.cmdConsultarFacturas.TabIndex = 17
        Me.cmdConsultarFacturas.Text = "..."
        Me.cmdConsultarFacturas.UseVisualStyleBackColor = True
        '
        'cmdProcesarFacturas
        '
        Me.cmdProcesarFacturas.Image = CType(resources.GetObject("cmdProcesarFacturas.Image"), System.Drawing.Image)
        Me.cmdProcesarFacturas.Location = New System.Drawing.Point(744, 412)
        Me.cmdProcesarFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdProcesarFacturas.Name = "cmdProcesarFacturas"
        Me.cmdProcesarFacturas.Size = New System.Drawing.Size(31, 28)
        Me.cmdProcesarFacturas.TabIndex = 18
        Me.cmdProcesarFacturas.Text = "..."
        Me.cmdProcesarFacturas.UseVisualStyleBackColor = True
        '
        'frmSccCuentasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 708)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccCuentasEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expedientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpFechaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.numSaldoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcCuentas.ResumeLayout(False)
        Me.pgClientes.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tbFacturas.ResumeLayout(False)
        Me.PGFacturas.ResumeLayout(False)
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents objUbicacionHojaContrato As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbcCuentas As System.Windows.Forms.TabControl
    Friend WithEvents pgClientes As System.Windows.Forms.TabPage
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents txtTipoPersona As System.Windows.Forms.TextBox
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoPersona As System.Windows.Forms.Label
    Friend WithEvents numSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaCredito As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFechaCredito As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbFacturas As System.Windows.Forms.TabControl
    Friend WithEvents PGFacturas As System.Windows.Forms.TabPage
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents numSaldoInicial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdConsultarCliente As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents ToolTip As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBuscarFacturas As System.Windows.Forms.Button
    Friend WithEvents cmdConsultarFacturas As System.Windows.Forms.Button
    Friend WithEvents cmdProcesarFacturas As System.Windows.Forms.Button
End Class
