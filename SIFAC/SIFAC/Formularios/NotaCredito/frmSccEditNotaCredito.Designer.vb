<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccEditNotaCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccEditNotaCredito))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New C1.Win.C1List.C1Combo()
        Me.numMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.cmbConcepto = New C1.Win.C1List.C1Combo()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrpExpediente = New System.Windows.Forms.GroupBox()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmdExpediente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbCajas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.C1Combo1 = New C1.Win.C1List.C1Combo()
        Me.C1NumericEdit1 = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1Combo2 = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.C1DateEdit1 = New C1.Win.C1Input.C1DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpExpediente.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.numMonto)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.cmbConcepto)
        Me.GroupBox1.Controls.Add(Me.lblConcepto)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.lblEstado)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 245)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nota de Crédito"
        '
        'cmbEstado
        '
        Me.cmbEstado.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEstado.Caption = ""
        Me.cmbEstado.CaptionHeight = 17
        Me.cmbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEstado.ColumnCaptionHeight = 17
        Me.cmbEstado.ColumnFooterHeight = 17
        Me.cmbEstado.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbEstado.ContentHeight = 15
        Me.cmbEstado.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEstado.DropDownWidth = 250
        Me.cmbEstado.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEstado.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstado.EditorHeight = 15
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.Images.Add(CType(resources.GetObject("cmbEstado.Images"), System.Drawing.Image))
        Me.cmbEstado.ItemHeight = 15
        Me.cmbEstado.LimitToList = True
        Me.cmbEstado.Location = New System.Drawing.Point(77, 210)
        Me.cmbEstado.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEstado.MaxDropDownItems = CType(5, Short)
        Me.cmbEstado.MaxLength = 32767
        Me.cmbEstado.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEstado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEstado.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEstado.Size = New System.Drawing.Size(281, 21)
        Me.cmbEstado.TabIndex = 8
        Me.cmbEstado.Tag = "BLOQUEADO"
        Me.cmbEstado.PropBag = resources.GetString("cmbEstado.PropBag")
        '
        'numMonto
        '
        Me.numMonto.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMonto.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numMonto.ErrorInfo.ShowErrorMessage = False
        Me.numMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMonto.Location = New System.Drawing.Point(77, 184)
        Me.numMonto.Name = "numMonto"
        Me.numMonto.Size = New System.Drawing.Size(281, 20)
        Me.numMonto.TabIndex = 7
        Me.numMonto.Tag = Nothing
        Me.numMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(11, 187)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(46, 13)
        Me.lblMonto.TabIndex = 76
        Me.lblMonto.Tag = "OBLIGATORIO"
        Me.lblMonto.Text = "Monto:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(77, 98)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(281, 80)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.Tag = ""
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(10, 130)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(78, 13)
        Me.lblDescripcion.TabIndex = 74
        Me.lblDescripcion.Tag = "OBLIGATORIO"
        Me.lblDescripcion.Text = "Descripción:"
        '
        'cmbConcepto
        '
        Me.cmbConcepto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbConcepto.Caption = ""
        Me.cmbConcepto.CaptionHeight = 17
        Me.cmbConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbConcepto.ColumnCaptionHeight = 17
        Me.cmbConcepto.ColumnFooterHeight = 17
        Me.cmbConcepto.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbConcepto.ContentHeight = 15
        Me.cmbConcepto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbConcepto.DropDownWidth = 250
        Me.cmbConcepto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbConcepto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConcepto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConcepto.EditorHeight = 15
        Me.cmbConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConcepto.Images.Add(CType(resources.GetObject("cmbConcepto.Images"), System.Drawing.Image))
        Me.cmbConcepto.ItemHeight = 15
        Me.cmbConcepto.LimitToList = True
        Me.cmbConcepto.Location = New System.Drawing.Point(77, 71)
        Me.cmbConcepto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbConcepto.MaxDropDownItems = CType(5, Short)
        Me.cmbConcepto.MaxLength = 32767
        Me.cmbConcepto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbConcepto.Name = "cmbConcepto"
        Me.cmbConcepto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbConcepto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbConcepto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbConcepto.Size = New System.Drawing.Size(281, 21)
        Me.cmbConcepto.TabIndex = 5
        Me.cmbConcepto.PropBag = resources.GetString("cmbConcepto.PropBag")
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Location = New System.Drawing.Point(10, 79)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(65, 13)
        Me.lblConcepto.TabIndex = 72
        Me.lblConcepto.Tag = "OBLIGATORIO"
        Me.lblConcepto.Text = "Concepto:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(77, 19)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(279, 20)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.Tag = "BLOQUEADO"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(11, 26)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(54, 13)
        Me.lblNumero.TabIndex = 70
        Me.lblNumero.Tag = "OBLIGATORIO"
        Me.lblNumero.Text = "Número:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(11, 218)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(50, 13)
        Me.lblEstado.TabIndex = 68
        Me.lblEstado.Tag = ""
        Me.lblEstado.Text = "Estado:"
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
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 12, 1, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.Location = New System.Drawing.Point(77, 45)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(281, 20)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(11, 52)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 13)
        Me.lblFecha.TabIndex = 64
        Me.lblFecha.Tag = "OBLIGATORIO"
        Me.lblFecha.Text = "Fecha:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'GrpExpediente
        '
        Me.GrpExpediente.Controls.Add(Me.cmbEmpleado)
        Me.GrpExpediente.Controls.Add(Me.cmdConsultar)
        Me.GrpExpediente.Controls.Add(Me.cmdExpediente)
        Me.GrpExpediente.Controls.Add(Me.txtCliente)
        Me.GrpExpediente.Controls.Add(Me.lblCliente)
        Me.GrpExpediente.Controls.Add(Me.txtNumCuenta)
        Me.GrpExpediente.Controls.Add(Me.Label12)
        Me.GrpExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpExpediente.Location = New System.Drawing.Point(20, 40)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Size = New System.Drawing.Size(380, 75)
        Me.GrpExpediente.TabIndex = 20
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos "
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(86, 44)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(279, 21)
        Me.cmbEmpleado.TabIndex = 132
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.Location = New System.Drawing.Point(355, 14)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(24, 23)
        Me.cmdConsultar.TabIndex = 19
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'cmdExpediente
        '
        Me.cmdExpediente.Image = CType(resources.GetObject("cmdExpediente.Image"), System.Drawing.Image)
        Me.cmdExpediente.Location = New System.Drawing.Point(330, 14)
        Me.cmdExpediente.Name = "cmdExpediente"
        Me.cmdExpediente.Size = New System.Drawing.Size(24, 23)
        Me.cmdExpediente.TabIndex = 6
        Me.cmdExpediente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(86, 44)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(275, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(16, 47)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 13)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Tag = "OBLIGATORIO"
        Me.lblCliente.Text = "Cliente:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuenta.Location = New System.Drawing.Point(86, 17)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(240, 20)
        Me.txtNumCuenta.TabIndex = 3
        Me.txtNumCuenta.Tag = "BLOQUEADO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Tag = "OBLIGATORIO"
        Me.Label12.Text = "No. Exp:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmbCajas)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GrpExpediente)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.Panel2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(411, 429)
        Me.PanelControl1.TabIndex = 102
        '
        'cmbCajas
        '
        Me.cmbCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCajas.FormattingEnabled = True
        Me.cmbCajas.Location = New System.Drawing.Point(106, 11)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(240, 21)
        Me.cmbCajas.TabIndex = 134
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(26, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 133
        Me.Label7.Tag = "OBLIGATORIO"
        Me.Label7.Text = "Caja:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(325, 372)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 103
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(237, 372)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 102
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 406)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 21)
        Me.Panel2.TabIndex = 101
        '
        'C1Combo1
        '
        Me.C1Combo1.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CaptionHeight = 17
        Me.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo1.ContentHeight = 15
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.DropDownWidth = 250
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo1.EditorHeight = 15
        Me.C1Combo1.Enabled = False
        Me.C1Combo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo1.Images.Add(CType(resources.GetObject("C1Combo1.Images"), System.Drawing.Image))
        Me.C1Combo1.ItemHeight = 15
        Me.C1Combo1.LimitToList = True
        Me.C1Combo1.Location = New System.Drawing.Point(77, 210)
        Me.C1Combo1.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.Size = New System.Drawing.Size(188, 21)
        Me.C1Combo1.TabIndex = 8
        Me.C1Combo1.Tag = "BLOQUEADO"
        Me.C1Combo1.PropBag = resources.GetString("C1Combo1.PropBag")
        '
        'C1NumericEdit1
        '
        Me.C1NumericEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.C1NumericEdit1.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1NumericEdit1.ErrorInfo.ShowErrorMessage = False
        Me.C1NumericEdit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NumericEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.C1NumericEdit1.Location = New System.Drawing.Point(77, 184)
        Me.C1NumericEdit1.Name = "C1NumericEdit1"
        Me.C1NumericEdit1.Size = New System.Drawing.Size(188, 20)
        Me.C1NumericEdit1.TabIndex = 7
        Me.C1NumericEdit1.Tag = Nothing
        Me.C1NumericEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.C1NumericEdit1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NumericEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Tag = "OBLIGATORIO"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(77, 98)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 80)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Tag = ""
        '
        'C1Combo2
        '
        Me.C1Combo2.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo2.Caption = ""
        Me.C1Combo2.CaptionHeight = 17
        Me.C1Combo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo2.ColumnCaptionHeight = 17
        Me.C1Combo2.ColumnFooterHeight = 17
        Me.C1Combo2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo2.ContentHeight = 15
        Me.C1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo2.DropDownWidth = 250
        Me.C1Combo2.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo2.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo2.EditorHeight = 15
        Me.C1Combo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo2.Images.Add(CType(resources.GetObject("C1Combo2.Images"), System.Drawing.Image))
        Me.C1Combo2.ItemHeight = 15
        Me.C1Combo2.LimitToList = True
        Me.C1Combo2.Location = New System.Drawing.Point(77, 71)
        Me.C1Combo2.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo2.MaxDropDownItems = CType(5, Short)
        Me.C1Combo2.MaxLength = 32767
        Me.C1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo2.Name = "C1Combo2"
        Me.C1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo2.Size = New System.Drawing.Size(188, 21)
        Me.C1Combo2.TabIndex = 5
        Me.C1Combo2.PropBag = resources.GetString("C1Combo2.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Tag = "OBLIGATORIO"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(77, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Tag = "BLOQUEADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Tag = "OBLIGATORIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Tag = ""
        '
        'C1DateEdit1
        '
        '
        '
        '
        Me.C1DateEdit1.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.C1DateEdit1.Calendar.BoldedDates = New Date(-1) {}
        Me.C1DateEdit1.Calendar.ClearText = "&Clear"
        Me.C1DateEdit1.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.C1DateEdit1.Calendar.SelectedDate = New Date(2016, 12, 1, 0, 0, 0, 0)
        Me.C1DateEdit1.Calendar.TodayText = "&Today"
        Me.C1DateEdit1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.C1DateEdit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1DateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.C1DateEdit1.Location = New System.Drawing.Point(77, 45)
        Me.C1DateEdit1.Name = "C1DateEdit1"
        Me.C1DateEdit1.Size = New System.Drawing.Size(188, 20)
        Me.C1DateEdit1.TabIndex = 1
        Me.C1DateEdit1.Tag = Nothing
        Me.C1DateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Tag = "OBLIGATORIO"
        '
        'frmSccEditNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 429)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccEditNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Nota de Crédito"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents cmbConcepto As C1.Win.C1List.C1Combo
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents numMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As C1.Win.C1List.C1Combo
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GrpExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExpediente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtNumCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    Friend WithEvents C1NumericEdit1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C1Combo2 As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents C1DateEdit1 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCajas As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleado As System.Windows.Forms.ComboBox
End Class
