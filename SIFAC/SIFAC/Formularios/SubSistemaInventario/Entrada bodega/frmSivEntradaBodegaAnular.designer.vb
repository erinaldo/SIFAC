<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivEntradaBodegaAnular
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivEntradaBodegaAnular))
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox
        Me.cmbTipoAjuste = New C1.Win.C1List.C1Combo
        Me.lblTipoAjuste = New System.Windows.Forms.Label
        Me.cmbTipoEntrada = New C1.Win.C1List.C1Combo
        Me.cmbProveedor = New C1.Win.C1List.C1Combo
        Me.cmbBodega = New C1.Win.C1List.C1Combo
        Me.lblTipoEntrada = New System.Windows.Forms.Label
        Me.lblFechaEntrada = New System.Windows.Forms.Label
        Me.lblProveedor = New System.Windows.Forms.Label
        Me.lblBodega = New System.Windows.Forms.Label
        Me.dtpFechaEntrada = New C1.Win.C1Input.C1DateEdit
        Me.txtNumeroEntrada = New System.Windows.Forms.TextBox
        Me.lblNoEntrada = New System.Windows.Forms.Label
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbxOtrosDatos = New System.Windows.Forms.GroupBox
        Me.dtpFechaFactura = New C1.Win.C1Input.C1DateEdit
        Me.lblFechaFactura = New System.Windows.Forms.Label
        Me.txtNumeroPoliza = New System.Windows.Forms.TextBox
        Me.lblNumeroPoliza = New System.Windows.Forms.Label
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox
        Me.lblNumeroFactura = New System.Windows.Forms.Label
        Me.txtComentarios = New System.Windows.Forms.TextBox
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.lblCostoTotal = New System.Windows.Forms.Label
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.gbxDetalle = New System.Windows.Forms.GroupBox
        Me.grdDetalleEntradasBodegas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.NumCostoTotal = New C1.Win.C1Input.C1NumericEdit
        Me.gbxDatosAnulacion = New System.Windows.Forms.GroupBox
        Me.lblComentariosAnular = New System.Windows.Forms.Label
        Me.chkAnulado = New System.Windows.Forms.CheckBox
        Me.txtComentariosAnular = New System.Windows.Forms.TextBox
        Me.lblRecordatorio = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbTipoAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOtrosDatos.SuspendLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdDetalleEntradasBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosAnulacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(761, 716)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(681, 716)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(74, 30)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(852, 32)
        Me.Panel2.TabIndex = 75
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(787, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTipoAjuste)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTipoAjuste)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbProveedor)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblProveedor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNumeroEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoEntrada)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(17, 39)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(818, 118)
        Me.gbxDatosGenerales.TabIndex = 73
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
        '
        'cmbTipoAjuste
        '
        Me.cmbTipoAjuste.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoAjuste.Caption = ""
        Me.cmbTipoAjuste.CaptionHeight = 17
        Me.cmbTipoAjuste.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoAjuste.ColumnCaptionHeight = 17
        Me.cmbTipoAjuste.ColumnFooterHeight = 17
        Me.cmbTipoAjuste.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoAjuste.ContentHeight = 15
        Me.cmbTipoAjuste.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoAjuste.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoAjuste.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoAjuste.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoAjuste.EditorHeight = 15
        Me.cmbTipoAjuste.Enabled = False
        Me.cmbTipoAjuste.Images.Add(CType(resources.GetObject("cmbTipoAjuste.Images"), System.Drawing.Image))
        Me.cmbTipoAjuste.ItemHeight = 15
        Me.cmbTipoAjuste.Location = New System.Drawing.Point(632, 84)
        Me.cmbTipoAjuste.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoAjuste.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoAjuste.MaxLength = 32767
        Me.cmbTipoAjuste.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoAjuste.Name = "cmbTipoAjuste"
        Me.cmbTipoAjuste.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoAjuste.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoAjuste.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoAjuste.Size = New System.Drawing.Size(174, 21)
        Me.cmbTipoAjuste.TabIndex = 97
        Me.cmbTipoAjuste.PropBag = resources.GetString("cmbTipoAjuste.PropBag")
        '
        'lblTipoAjuste
        '
        Me.lblTipoAjuste.AutoSize = True
        Me.lblTipoAjuste.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoAjuste.Location = New System.Drawing.Point(541, 90)
        Me.lblTipoAjuste.Name = "lblTipoAjuste"
        Me.lblTipoAjuste.Size = New System.Drawing.Size(71, 13)
        Me.lblTipoAjuste.TabIndex = 96
        Me.lblTipoAjuste.Tag = ""
        Me.lblTipoAjuste.Text = "Tipo Entrada:"
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoEntrada.Caption = ""
        Me.cmbTipoEntrada.CaptionHeight = 17
        Me.cmbTipoEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoEntrada.ColumnCaptionHeight = 17
        Me.cmbTipoEntrada.ColumnFooterHeight = 17
        Me.cmbTipoEntrada.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoEntrada.ContentHeight = 15
        Me.cmbTipoEntrada.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoEntrada.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoEntrada.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoEntrada.EditorHeight = 15
        Me.cmbTipoEntrada.Images.Add(CType(resources.GetObject("cmbTipoEntrada.Images"), System.Drawing.Image))
        Me.cmbTipoEntrada.ItemHeight = 15
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(632, 53)
        Me.cmbTipoEntrada.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoEntrada.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoEntrada.MaxLength = 32767
        Me.cmbTipoEntrada.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoEntrada.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoEntrada.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(174, 21)
        Me.cmbTipoEntrada.TabIndex = 95
        Me.cmbTipoEntrada.PropBag = resources.GetString("cmbTipoEntrada.PropBag")
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProveedor.Caption = ""
        Me.cmbProveedor.CaptionHeight = 17
        Me.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProveedor.ColumnCaptionHeight = 17
        Me.cmbProveedor.ColumnFooterHeight = 17
        Me.cmbProveedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbProveedor.ContentHeight = 15
        Me.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProveedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProveedor.EditorHeight = 15
        Me.cmbProveedor.Enabled = False
        Me.cmbProveedor.Images.Add(CType(resources.GetObject("cmbProveedor.Images"), System.Drawing.Image))
        Me.cmbProveedor.ItemHeight = 15
        Me.cmbProveedor.Location = New System.Drawing.Point(133, 84)
        Me.cmbProveedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProveedor.MaxDropDownItems = CType(5, Short)
        Me.cmbProveedor.MaxLength = 32767
        Me.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedor.Size = New System.Drawing.Size(174, 21)
        Me.cmbProveedor.TabIndex = 94
        Me.cmbProveedor.TabStop = False
        Me.cmbProveedor.Tag = ""
        Me.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag")
        '
        'cmbBodega
        '
        Me.cmbBodega.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodega.Caption = ""
        Me.cmbBodega.CaptionHeight = 17
        Me.cmbBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodega.ColumnCaptionHeight = 17
        Me.cmbBodega.ColumnFooterHeight = 17
        Me.cmbBodega.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbBodega.ContentHeight = 15
        Me.cmbBodega.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBodega.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBodega.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodega.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodega.EditorHeight = 15
        Me.cmbBodega.Enabled = False
        Me.cmbBodega.Images.Add(CType(resources.GetObject("cmbBodega.Images"), System.Drawing.Image))
        Me.cmbBodega.ItemHeight = 15
        Me.cmbBodega.Location = New System.Drawing.Point(133, 53)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(174, 21)
        Me.cmbBodega.TabIndex = 0
        Me.cmbBodega.Tag = "BLOQUEADO"
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
        '
        'lblTipoEntrada
        '
        Me.lblTipoEntrada.AutoSize = True
        Me.lblTipoEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoEntrada.Location = New System.Drawing.Point(541, 58)
        Me.lblTipoEntrada.Name = "lblTipoEntrada"
        Me.lblTipoEntrada.Size = New System.Drawing.Size(71, 13)
        Me.lblTipoEntrada.TabIndex = 92
        Me.lblTipoEntrada.Tag = ""
        Me.lblTipoEntrada.Text = "Tipo Entrada:"
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaEntrada.Location = New System.Drawing.Point(541, 24)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaEntrada.TabIndex = 88
        Me.lblFechaEntrada.Tag = ""
        Me.lblFechaEntrada.Text = "Fecha:"
        '
        'lblProveedor
        '
        Me.lblProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lblProveedor.Location = New System.Drawing.Point(28, 85)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(83, 18)
        Me.lblProveedor.TabIndex = 86
        Me.lblProveedor.Tag = ""
        Me.lblProveedor.Text = "Proveedor:"
        '
        'lblBodega
        '
        Me.lblBodega.BackColor = System.Drawing.SystemColors.Control
        Me.lblBodega.Location = New System.Drawing.Point(28, 53)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(83, 18)
        Me.lblBodega.TabIndex = 86
        Me.lblBodega.Tag = ""
        Me.lblBodega.Text = "Bodega:"
        '
        'dtpFechaEntrada
        '
        Me.dtpFechaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaEntrada.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaEntrada.EditMask = "##/##/####"
        Me.dtpFechaEntrada.Enabled = False
        Me.dtpFechaEntrada.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEntrada.Location = New System.Drawing.Point(632, 24)
        Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
        Me.dtpFechaEntrada.Size = New System.Drawing.Size(174, 18)
        Me.dtpFechaEntrada.TabIndex = 0
        Me.dtpFechaEntrada.Tag = Nothing
        Me.dtpFechaEntrada.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtNumeroEntrada
        '
        Me.txtNumeroEntrada.Location = New System.Drawing.Point(133, 20)
        Me.txtNumeroEntrada.Name = "txtNumeroEntrada"
        Me.txtNumeroEntrada.Size = New System.Drawing.Size(174, 20)
        Me.txtNumeroEntrada.TabIndex = 0
        Me.txtNumeroEntrada.TabStop = False
        Me.txtNumeroEntrada.Tag = "BLOQUEADO"
        Me.txtNumeroEntrada.Text = "(Automático)"
        '
        'lblNoEntrada
        '
        Me.lblNoEntrada.AutoSize = True
        Me.lblNoEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoEntrada.Location = New System.Drawing.Point(28, 24)
        Me.lblNoEntrada.Name = "lblNoEntrada"
        Me.lblNoEntrada.Size = New System.Drawing.Size(87, 13)
        Me.lblNoEntrada.TabIndex = 19
        Me.lblNoEntrada.Tag = ""
        Me.lblNoEntrada.Text = "Número Entrada:"
        '
        'imgIconos
        '
        Me.imgIconos.ImageStream = CType(resources.GetObject("imgIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIconos.Images.SetKeyName(0, "Usuario.gif")
        Me.imgIconos.Images.SetKeyName(1, "Buscar.png")
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'gbxOtrosDatos
        '
        Me.gbxOtrosDatos.Controls.Add(Me.dtpFechaFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.lblFechaFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.txtNumeroPoliza)
        Me.gbxOtrosDatos.Controls.Add(Me.lblNumeroPoliza)
        Me.gbxOtrosDatos.Controls.Add(Me.txtNumeroFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.lblNumeroFactura)
        Me.gbxOtrosDatos.Location = New System.Drawing.Point(17, 163)
        Me.gbxOtrosDatos.Name = "gbxOtrosDatos"
        Me.gbxOtrosDatos.Size = New System.Drawing.Size(818, 60)
        Me.gbxOtrosDatos.TabIndex = 82
        Me.gbxOtrosDatos.TabStop = False
        Me.gbxOtrosDatos.Text = "Otros Datos"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaFactura.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaFactura.EditMask = "##/##/####"
        Me.dtpFechaFactura.Enabled = False
        Me.dtpFechaFactura.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFactura.Location = New System.Drawing.Point(674, 21)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(130, 18)
        Me.dtpFechaFactura.TabIndex = 24
        Me.dtpFechaFactura.Tag = Nothing
        Me.dtpFechaFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.AutoSize = True
        Me.lblFechaFactura.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaFactura.Location = New System.Drawing.Point(586, 24)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(79, 13)
        Me.lblFechaFactura.TabIndex = 23
        Me.lblFechaFactura.Tag = ""
        Me.lblFechaFactura.Text = "Fecha Factura:"
        '
        'txtNumeroPoliza
        '
        Me.txtNumeroPoliza.Location = New System.Drawing.Point(416, 20)
        Me.txtNumeroPoliza.Name = "txtNumeroPoliza"
        Me.txtNumeroPoliza.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroPoliza.TabIndex = 20
        Me.txtNumeroPoliza.TabStop = False
        Me.txtNumeroPoliza.Tag = ""
        '
        'lblNumeroPoliza
        '
        Me.lblNumeroPoliza.AutoSize = True
        Me.lblNumeroPoliza.BackColor = System.Drawing.SystemColors.Control
        Me.lblNumeroPoliza.Location = New System.Drawing.Point(313, 23)
        Me.lblNumeroPoliza.Name = "lblNumeroPoliza"
        Me.lblNumeroPoliza.Size = New System.Drawing.Size(78, 13)
        Me.lblNumeroPoliza.TabIndex = 21
        Me.lblNumeroPoliza.Tag = ""
        Me.lblNumeroPoliza.Text = "Número Poliza:"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(131, 21)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroFactura.TabIndex = 0
        Me.txtNumeroFactura.TabStop = False
        Me.txtNumeroFactura.Tag = ""
        '
        'lblNumeroFactura
        '
        Me.lblNumeroFactura.AutoSize = True
        Me.lblNumeroFactura.BackColor = System.Drawing.SystemColors.Control
        Me.lblNumeroFactura.Location = New System.Drawing.Point(28, 24)
        Me.lblNumeroFactura.Name = "lblNumeroFactura"
        Me.lblNumeroFactura.Size = New System.Drawing.Size(86, 13)
        Me.lblNumeroFactura.TabIndex = 19
        Me.lblNumeroFactura.Tag = ""
        Me.lblNumeroFactura.Text = "Número Factura:"
        '
        'txtComentarios
        '
        Me.txtComentarios.AcceptsTab = True
        Me.txtComentarios.Location = New System.Drawing.Point(17, 655)
        Me.txtComentarios.MaxLength = 250
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarios.Size = New System.Drawing.Size(819, 55)
        Me.txtComentarios.TabIndex = 93
        Me.txtComentarios.Tag = ""
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.SystemColors.Control
        Me.lblObservaciones.Location = New System.Drawing.Point(14, 626)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 94
        Me.lblObservaciones.Tag = ""
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblCostoTotal.Location = New System.Drawing.Point(646, 626)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(81, 13)
        Me.lblCostoTotal.TabIndex = 96
        Me.lblCostoTotal.Tag = ""
        Me.lblCostoTotal.Text = "Costo Total U$:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.lblUsuario.Location = New System.Drawing.Point(14, 733)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 97
        Me.lblUsuario.Tag = ""
        Me.lblUsuario.Text = "Usuario"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.grdDetalleEntradasBodegas)
        Me.gbxDetalle.Location = New System.Drawing.Point(17, 329)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(818, 286)
        Me.gbxDetalle.TabIndex = 101
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Otros Datos"
        '
        'grdDetalleEntradasBodegas
        '
        Me.grdDetalleEntradasBodegas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleEntradasBodegas.Images.Add(CType(resources.GetObject("grdDetalleEntradasBodegas.Images"), System.Drawing.Image))
        Me.grdDetalleEntradasBodegas.Location = New System.Drawing.Point(3, 19)
        Me.grdDetalleEntradasBodegas.Name = "grdDetalleEntradasBodegas"
        Me.grdDetalleEntradasBodegas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleEntradasBodegas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleEntradasBodegas.PreviewInfo.ZoomFactor = 75
        Me.grdDetalleEntradasBodegas.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalleEntradasBodegas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalleEntradasBodegas.Size = New System.Drawing.Size(815, 267)
        Me.grdDetalleEntradasBodegas.TabIndex = 0
        Me.grdDetalleEntradasBodegas.Text = "C1TrueDBGrid1"
        Me.grdDetalleEntradasBodegas.PropBag = resources.GetString("grdDetalleEntradasBodegas.PropBag")
        '
        'NumCostoTotal
        '
        Me.NumCostoTotal.DisplayFormat.CustomFormat = "#,##0.00"
        Me.NumCostoTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.NumCostoTotal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumCostoTotal.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.NumCostoTotal.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumCostoTotal.Enabled = False
        Me.NumCostoTotal.Location = New System.Drawing.Point(728, 622)
        Me.NumCostoTotal.Name = "NumCostoTotal"
        Me.NumCostoTotal.Size = New System.Drawing.Size(107, 20)
        Me.NumCostoTotal.TabIndex = 102
        Me.NumCostoTotal.Tag = "BLOQUEADO"
        Me.NumCostoTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'gbxDatosAnulacion
        '
        Me.gbxDatosAnulacion.Controls.Add(Me.lblComentariosAnular)
        Me.gbxDatosAnulacion.Controls.Add(Me.chkAnulado)
        Me.gbxDatosAnulacion.Controls.Add(Me.txtComentariosAnular)
        Me.gbxDatosAnulacion.Location = New System.Drawing.Point(20, 229)
        Me.gbxDatosAnulacion.Name = "gbxDatosAnulacion"
        Me.gbxDatosAnulacion.Size = New System.Drawing.Size(818, 94)
        Me.gbxDatosAnulacion.TabIndex = 103
        Me.gbxDatosAnulacion.TabStop = False
        Me.gbxDatosAnulacion.Text = "Datos de Anulación"
        '
        'lblComentariosAnular
        '
        Me.lblComentariosAnular.AutoSize = True
        Me.lblComentariosAnular.BackColor = System.Drawing.SystemColors.Control
        Me.lblComentariosAnular.Location = New System.Drawing.Point(3, 39)
        Me.lblComentariosAnular.Name = "lblComentariosAnular"
        Me.lblComentariosAnular.Size = New System.Drawing.Size(65, 13)
        Me.lblComentariosAnular.TabIndex = 97
        Me.lblComentariosAnular.Tag = ""
        Me.lblComentariosAnular.Text = "Comentarios"
        '
        'chkAnulado
        '
        Me.chkAnulado.AutoSize = True
        Me.chkAnulado.Enabled = False
        Me.chkAnulado.Location = New System.Drawing.Point(6, 19)
        Me.chkAnulado.Name = "chkAnulado"
        Me.chkAnulado.Size = New System.Drawing.Size(65, 17)
        Me.chkAnulado.TabIndex = 96
        Me.chkAnulado.Text = "Anulado"
        Me.chkAnulado.UseVisualStyleBackColor = True
        '
        'txtComentariosAnular
        '
        Me.txtComentariosAnular.AcceptsTab = True
        Me.txtComentariosAnular.Location = New System.Drawing.Point(2, 52)
        Me.txtComentariosAnular.MaxLength = 250
        Me.txtComentariosAnular.Multiline = True
        Me.txtComentariosAnular.Name = "txtComentariosAnular"
        Me.txtComentariosAnular.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentariosAnular.Size = New System.Drawing.Size(814, 36)
        Me.txtComentariosAnular.TabIndex = 95
        Me.txtComentariosAnular.Tag = ""
        '
        'lblRecordatorio
        '
        Me.lblRecordatorio.AutoSize = True
        Me.lblRecordatorio.BackColor = System.Drawing.SystemColors.Control
        Me.lblRecordatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordatorio.ForeColor = System.Drawing.Color.Red
        Me.lblRecordatorio.Location = New System.Drawing.Point(89, 733)
        Me.lblRecordatorio.Name = "lblRecordatorio"
        Me.lblRecordatorio.Size = New System.Drawing.Size(483, 17)
        Me.lblRecordatorio.TabIndex = 104
        Me.lblRecordatorio.Tag = ""
        Me.lblRecordatorio.Text = "Recuerde: Si ya está generada la factura, ésta se deberá anular."
        '
        'frmSivEntradaBodegaAnular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 772)
        Me.Controls.Add(Me.lblRecordatorio)
        Me.Controls.Add(Me.gbxDatosAnulacion)
        Me.Controls.Add(Me.NumCostoTotal)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblCostoTotal)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.gbxOtrosDatos)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbxDatosGenerales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivEntradaBodegaAnular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anular/Consultar Entrada de Productos"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbTipoAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOtrosDatos.ResumeLayout(False)
        Me.gbxOtrosDatos.PerformLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        CType(Me.grdDetalleEntradasBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosAnulacion.ResumeLayout(False)
        Me.gbxDatosAnulacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEntrada As System.Windows.Forms.Label
    Friend WithEvents lblFechaEntrada As System.Windows.Forms.Label
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEntrada As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtNumeroEntrada As System.Windows.Forms.TextBox
    Friend WithEvents lblNoEntrada As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbProveedor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoEntrada As C1.Win.C1List.C1Combo
    Friend WithEvents lblTipoAjuste As System.Windows.Forms.Label
    Friend WithEvents cmbTipoAjuste As C1.Win.C1List.C1Combo
    Friend WithEvents gbxOtrosDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroFactura As System.Windows.Forms.Label
    Friend WithEvents lblFechaFactura As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPoliza As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroPoliza As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFactura As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblCostoTotal As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalleEntradasBodegas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents NumCostoTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents gbxDatosAnulacion As System.Windows.Forms.GroupBox
    Friend WithEvents txtComentariosAnular As System.Windows.Forms.TextBox
    Friend WithEvents chkAnulado As System.Windows.Forms.CheckBox
    Friend WithEvents lblComentariosAnular As System.Windows.Forms.Label
    Friend WithEvents lblRecordatorio As System.Windows.Forms.Label
End Class
