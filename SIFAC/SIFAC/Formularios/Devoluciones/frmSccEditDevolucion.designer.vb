<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccEditDevolucion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccEditDevolucion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpExpediente = New System.Windows.Forms.GroupBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdExpediente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.txtCodTienda = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.lblFechaPedido = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbFacturas = New System.Windows.Forms.TabControl()
        Me.PGFacturas = New System.Windows.Forms.TabPage()
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmbSucursal = New C1.Win.C1List.C1Combo()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cmdAutorizar = New System.Windows.Forms.Button()
        Me.ToolTip = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GrpExpediente.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tbFacturas.SuspendLayout()
        Me.PGFacturas.SuspendLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GrpExpediente)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.lblFechaPedido)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.lblNumeroPedido)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Devolución"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(62, 43)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(200, 20)
        Me.txtEstado.TabIndex = 44
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Tag = ""
        Me.Label1.Text = "Estado:"
        '
        'GrpExpediente
        '
        Me.GrpExpediente.Controls.Add(Me.cmdConsultar)
        Me.GrpExpediente.Controls.Add(Me.Label10)
        Me.GrpExpediente.Controls.Add(Me.cmdExpediente)
        Me.GrpExpediente.Controls.Add(Me.txtCliente)
        Me.GrpExpediente.Controls.Add(Me.Label11)
        Me.GrpExpediente.Controls.Add(Me.txtNumCuenta)
        Me.GrpExpediente.Controls.Add(Me.txtCodTienda)
        Me.GrpExpediente.Controls.Add(Me.Label12)
        Me.GrpExpediente.Location = New System.Drawing.Point(287, 12)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Size = New System.Drawing.Size(372, 74)
        Me.GrpExpediente.TabIndex = 43
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos Expediente"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdConsultar.Location = New System.Drawing.Point(342, 14)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(24, 23)
        Me.cmdConsultar.TabIndex = 18
        Me.cmdConsultar.Text = "..."
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(153, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "--"
        '
        'cmdExpediente
        '
        Me.cmdExpediente.Location = New System.Drawing.Point(316, 14)
        Me.cmdExpediente.Name = "cmdExpediente"
        Me.cmdExpediente.Size = New System.Drawing.Size(24, 23)
        Me.cmdExpediente.TabIndex = 0
        Me.cmdExpediente.Text = "..."
        Me.cmdExpediente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(86, 44)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(254, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Tag = "OBLIGATORIO"
        Me.Label11.Text = "Cliente:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Location = New System.Drawing.Point(168, 17)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(142, 20)
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Tag = "OBLIGATORIO"
        Me.Label12.Text = "No. Exp:"
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
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 7, 12, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.Location = New System.Drawing.Point(62, 68)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaPedido
        '
        Me.lblFechaPedido.AutoSize = True
        Me.lblFechaPedido.Location = New System.Drawing.Point(12, 71)
        Me.lblFechaPedido.Name = "lblFechaPedido"
        Me.lblFechaPedido.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaPedido.TabIndex = 42
        Me.lblFechaPedido.Tag = "OBLIGATORIO"
        Me.lblFechaPedido.Text = "Fecha:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(62, 19)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(200, 20)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.Tag = "BLOQUEADO"
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Location = New System.Drawing.Point(12, 23)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(47, 13)
        Me.lblNumeroPedido.TabIndex = 19
        Me.lblNumeroPedido.Tag = ""
        Me.lblNumeroPedido.Text = "Número:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numTotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 50)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'numTotal
        '
        Me.numTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotal.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotal.Enabled = False
        Me.numTotal.ErrorInfo.ShowErrorMessage = False
        Me.numTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotal.Location = New System.Drawing.Point(65, 19)
        Me.numTotal.Name = "numTotal"
        Me.numTotal.Size = New System.Drawing.Size(147, 20)
        Me.numTotal.TabIndex = 2
        Me.numTotal.Tag = "BLOQUEADO"
        Me.numTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Tag = ""
        Me.Label2.Text = "Total:"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(615, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 32)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Tag = "LAYOUT"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(585, 349)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(425, 349)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(74, 30)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 385)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 22)
        Me.Panel1.TabIndex = 11
        '
        'tbFacturas
        '
        Me.tbFacturas.Controls.Add(Me.PGFacturas)
        Me.tbFacturas.Location = New System.Drawing.Point(10, 140)
        Me.tbFacturas.Name = "tbFacturas"
        Me.tbFacturas.SelectedIndex = 0
        Me.tbFacturas.Size = New System.Drawing.Size(665, 147)
        Me.tbFacturas.TabIndex = 12
        '
        'PGFacturas
        '
        Me.PGFacturas.Controls.Add(Me.grdFacturas)
        Me.PGFacturas.Location = New System.Drawing.Point(4, 22)
        Me.PGFacturas.Name = "PGFacturas"
        Me.PGFacturas.Padding = New System.Windows.Forms.Padding(3)
        Me.PGFacturas.Size = New System.Drawing.Size(657, 121)
        Me.PGFacturas.TabIndex = 0
        Me.PGFacturas.Text = "Facturas Asociadas"
        Me.PGFacturas.UseVisualStyleBackColor = True
        '
        'grdFacturas
        '
        Me.grdFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFacturas.ExtendRightColumn = True
        Me.grdFacturas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(3, 3)
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(651, 115)
        Me.grdFacturas.TabIndex = 0
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
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
        Me.cmbSucursal.DropDownWidth = 250
        Me.cmbSucursal.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursal.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursal.EditorHeight = 15
        Me.cmbSucursal.Images.Add(CType(resources.GetObject("cmbSucursal.Images"), System.Drawing.Image))
        Me.cmbSucursal.ItemHeight = 15
        Me.cmbSucursal.LimitToList = True
        Me.cmbSucursal.Location = New System.Drawing.Point(128, 305)
        Me.cmbSucursal.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursal.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursal.MaxLength = 32767
        Me.cmbSucursal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursal.Size = New System.Drawing.Size(200, 21)
        Me.cmbSucursal.TabIndex = 69
        Me.cmbSucursal.Tag = ""
        Me.cmbSucursal.PropBag = resources.GetString("cmbSucursal.PropBag")
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(14, 308)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(108, 13)
        Me.lblEstado.TabIndex = 70
        Me.lblEstado.Tag = ""
        Me.lblEstado.Text = "Sucursal Devolución:"
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(14, 358)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(108, 13)
        Me.lblInfo.TabIndex = 71
        Me.lblInfo.Tag = ""
        '
        'cmdAutorizar
        '
        Me.cmdAutorizar.Enabled = False
        Me.cmdAutorizar.Image = CType(resources.GetObject("cmdAutorizar.Image"), System.Drawing.Image)
        Me.cmdAutorizar.Location = New System.Drawing.Point(505, 349)
        Me.cmdAutorizar.Name = "cmdAutorizar"
        Me.cmdAutorizar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAutorizar.TabIndex = 72
        Me.cmdAutorizar.Tag = ""
        Me.cmdAutorizar.Text = "A&utorizar"
        Me.cmdAutorizar.UseVisualStyleBackColor = True
        '
        'ToolTip
        '
        Me.ToolTip.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.Shadow = False
        Me.ToolTip.StripAmpersands = True
        '
        'frmSccEditDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 407)
        Me.Controls.Add(Me.cmdAutorizar)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.tbFacturas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccEditDevolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Devolución"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.tbFacturas.ResumeLayout(False)
        Me.PGFacturas.ResumeLayout(False)
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFechaPedido As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents numTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GrpExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdExpediente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNumCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTienda As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbFacturas As System.Windows.Forms.TabControl
    Friend WithEvents PGFacturas As System.Windows.Forms.TabPage
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As C1.Win.C1List.C1Combo
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents cmdAutorizar As System.Windows.Forms.Button
    Friend WithEvents ToolTip As C1.Win.C1SuperTooltip.C1SuperTooltip
End Class
