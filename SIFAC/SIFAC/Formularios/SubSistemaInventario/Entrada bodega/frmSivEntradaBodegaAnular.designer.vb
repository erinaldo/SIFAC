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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivEntradaBodegaAnular))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmbTipoEntrada = New C1.Win.C1List.C1Combo()
        Me.cmbBodega = New C1.Win.C1List.C1Combo()
        Me.lblTipoEntrada = New System.Windows.Forms.Label()
        Me.lblFechaEntrada = New System.Windows.Forms.Label()
        Me.lblBodega = New System.Windows.Forms.Label()
        Me.dtpFechaEntrada = New C1.Win.C1Input.C1DateEdit()
        Me.txtNumeroEntrada = New System.Windows.Forms.TextBox()
        Me.lblNoEntrada = New System.Windows.Forms.Label()
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbxOtrosDatos = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFactura = New C1.Win.C1Input.C1DateEdit()
        Me.lblFechaFactura = New System.Windows.Forms.Label()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.lblNumeroFactura = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblCostoTotal = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.grdDetalleEntradasBodegas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.NumCostoTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.gbxDatosAnulacion = New System.Windows.Forms.GroupBox()
        Me.lblComentariosAnular = New System.Windows.Forms.Label()
        Me.chkAnulado = New System.Windows.Forms.CheckBox()
        Me.txtComentariosAnular = New System.Windows.Forms.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOtrosDatos.SuspendLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdDetalleEntradasBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosAnulacion.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(756, 708)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(79, 30)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(676, 708)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(74, 30)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNumeroEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoEntrada)
        Me.gbxDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(17, 16)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(818, 97)
        Me.gbxDatosGenerales.TabIndex = 73
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
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
        Me.cmbTipoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cmbBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblTipoEntrada.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEntrada.Location = New System.Drawing.Point(541, 58)
        Me.lblTipoEntrada.Name = "lblTipoEntrada"
        Me.lblTipoEntrada.Size = New System.Drawing.Size(84, 13)
        Me.lblTipoEntrada.TabIndex = 92
        Me.lblTipoEntrada.Tag = ""
        Me.lblTipoEntrada.Text = "Tipo Entrada:"
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrada.Location = New System.Drawing.Point(541, 24)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(46, 13)
        Me.lblFechaEntrada.TabIndex = 88
        Me.lblFechaEntrada.Tag = ""
        Me.lblFechaEntrada.Text = "Fecha:"
        '
        'lblBodega
        '
        Me.lblBodega.BackColor = System.Drawing.Color.Transparent
        Me.lblBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        '
        '
        '
        Me.dtpFechaEntrada.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaEntrada.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaEntrada.Calendar.ClearText = "&Clear"
        Me.dtpFechaEntrada.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaEntrada.Calendar.SelectedDate = New Date(2016, 8, 2, 0, 0, 0, 0)
        Me.dtpFechaEntrada.Calendar.TodayText = "&Today"
        Me.dtpFechaEntrada.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaEntrada.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaEntrada.EditMask = "##/##/####"
        Me.dtpFechaEntrada.Enabled = False
        Me.dtpFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtNumeroEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblNoEntrada.BackColor = System.Drawing.Color.Transparent
        Me.lblNoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoEntrada.Location = New System.Drawing.Point(28, 24)
        Me.lblNoEntrada.Name = "lblNoEntrada"
        Me.lblNoEntrada.Size = New System.Drawing.Size(102, 13)
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
        Me.gbxOtrosDatos.Controls.Add(Me.txtNumeroFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.lblNumeroFactura)
        Me.gbxOtrosDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOtrosDatos.Location = New System.Drawing.Point(18, 122)
        Me.gbxOtrosDatos.Name = "gbxOtrosDatos"
        Me.gbxOtrosDatos.Size = New System.Drawing.Size(818, 60)
        Me.gbxOtrosDatos.TabIndex = 82
        Me.gbxOtrosDatos.TabStop = False
        Me.gbxOtrosDatos.Text = "Otros Datos"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaFactura.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaFactura.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaFactura.Calendar.ClearText = "&Clear"
        Me.dtpFechaFactura.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaFactura.Calendar.SelectedDate = New Date(2016, 8, 2, 0, 0, 0, 0)
        Me.dtpFechaFactura.Calendar.TodayText = "&Today"
        Me.dtpFechaFactura.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaFactura.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaFactura.EditMask = "##/##/####"
        Me.dtpFechaFactura.Enabled = False
        Me.dtpFechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblFechaFactura.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFactura.Location = New System.Drawing.Point(577, 23)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(93, 13)
        Me.lblFechaFactura.TabIndex = 23
        Me.lblFechaFactura.Tag = ""
        Me.lblFechaFactura.Text = "Fecha Factura:"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblNumeroFactura.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroFactura.Location = New System.Drawing.Point(28, 24)
        Me.lblNumeroFactura.Name = "lblNumeroFactura"
        Me.lblNumeroFactura.Size = New System.Drawing.Size(101, 13)
        Me.lblNumeroFactura.TabIndex = 19
        Me.lblNumeroFactura.Tag = ""
        Me.lblNumeroFactura.Text = "Número Factura:"
        '
        'txtComentarios
        '
        Me.txtComentarios.AcceptsTab = True
        Me.txtComentarios.Location = New System.Drawing.Point(17, 640)
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
        Me.lblObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(17, 622)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(95, 13)
        Me.lblObservaciones.TabIndex = 94
        Me.lblObservaciones.Tag = ""
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoTotal.Location = New System.Drawing.Point(617, 601)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(96, 13)
        Me.lblCostoTotal.TabIndex = 96
        Me.lblCostoTotal.Tag = ""
        Me.lblCostoTotal.Text = "Costo Total U$:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(21, 709)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(50, 13)
        Me.lblUsuario.TabIndex = 97
        Me.lblUsuario.Tag = ""
        Me.lblUsuario.Text = "Usuario"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.grdDetalleEntradasBodegas)
        Me.gbxDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetalle.Location = New System.Drawing.Point(12, 297)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(818, 286)
        Me.gbxDetalle.TabIndex = 101
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Otros Datos"
        '
        'grdDetalleEntradasBodegas
        '
        Me.grdDetalleEntradasBodegas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDetalleEntradasBodegas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleEntradasBodegas.Images.Add(CType(resources.GetObject("grdDetalleEntradasBodegas.Images"), System.Drawing.Image))
        Me.grdDetalleEntradasBodegas.Location = New System.Drawing.Point(3, 19)
        Me.grdDetalleEntradasBodegas.Name = "grdDetalleEntradasBodegas"
        Me.grdDetalleEntradasBodegas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleEntradasBodegas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleEntradasBodegas.PreviewInfo.ZoomFactor = 75.0R
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
        Me.NumCostoTotal.Location = New System.Drawing.Point(723, 598)
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
        Me.gbxDatosAnulacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosAnulacion.Location = New System.Drawing.Point(18, 194)
        Me.gbxDatosAnulacion.Name = "gbxDatosAnulacion"
        Me.gbxDatosAnulacion.Size = New System.Drawing.Size(818, 94)
        Me.gbxDatosAnulacion.TabIndex = 103
        Me.gbxDatosAnulacion.TabStop = False
        Me.gbxDatosAnulacion.Text = "Datos de Anulación"
        '
        'lblComentariosAnular
        '
        Me.lblComentariosAnular.AutoSize = True
        Me.lblComentariosAnular.BackColor = System.Drawing.Color.Transparent
        Me.lblComentariosAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentariosAnular.Location = New System.Drawing.Point(3, 39)
        Me.lblComentariosAnular.Name = "lblComentariosAnular"
        Me.lblComentariosAnular.Size = New System.Drawing.Size(76, 13)
        Me.lblComentariosAnular.TabIndex = 97
        Me.lblComentariosAnular.Tag = ""
        Me.lblComentariosAnular.Text = "Comentarios"
        '
        'chkAnulado
        '
        Me.chkAnulado.AutoSize = True
        Me.chkAnulado.Enabled = False
        Me.chkAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnulado.Location = New System.Drawing.Point(6, 19)
        Me.chkAnulado.Name = "chkAnulado"
        Me.chkAnulado.Size = New System.Drawing.Size(72, 17)
        Me.chkAnulado.TabIndex = 96
        Me.chkAnulado.Text = "Anulado"
        Me.chkAnulado.UseVisualStyleBackColor = True
        '
        'txtComentariosAnular
        '
        Me.txtComentariosAnular.AcceptsTab = True
        Me.txtComentariosAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentariosAnular.Location = New System.Drawing.Point(2, 53)
        Me.txtComentariosAnular.MaxLength = 250
        Me.txtComentariosAnular.Multiline = True
        Me.txtComentariosAnular.Name = "txtComentariosAnular"
        Me.txtComentariosAnular.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentariosAnular.Size = New System.Drawing.Size(814, 36)
        Me.txtComentariosAnular.TabIndex = 95
        Me.txtComentariosAnular.Tag = ""
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblUsuario)
        Me.PanelControl1.Controls.Add(Me.NumCostoTotal)
        Me.PanelControl1.Controls.Add(Me.gbxDatosAnulacion)
        Me.PanelControl1.Controls.Add(Me.lblCostoTotal)
        Me.PanelControl1.Controls.Add(Me.gbxDetalle)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Controls.Add(Me.gbxOtrosDatos)
        Me.PanelControl1.Controls.Add(Me.lblObservaciones)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(852, 754)
        Me.PanelControl1.TabIndex = 104
        '
        'frmSivEntradaBodegaAnular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 754)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivEntradaBodegaAnular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anular/Consultar Entrada de Productos"
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEntrada As System.Windows.Forms.Label
    Friend WithEvents lblFechaEntrada As System.Windows.Forms.Label
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEntrada As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtNumeroEntrada As System.Windows.Forms.TextBox
    Friend WithEvents lblNoEntrada As System.Windows.Forms.Label
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoEntrada As C1.Win.C1List.C1Combo
    Friend WithEvents gbxOtrosDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroFactura As System.Windows.Forms.Label
    Friend WithEvents lblFechaFactura As System.Windows.Forms.Label
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
