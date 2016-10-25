<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivDespTransferenciaEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivDespTransferenciaEdit))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.grdDetalleTransferencia = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmbSitioDestino = New C1.Win.C1List.C1Combo()
        Me.cmbSitioOrigen = New C1.Win.C1List.C1Combo()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblDespachadopor = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.lblSitioDestino = New System.Windows.Forms.Label()
        Me.lblSitioOrigen = New System.Windows.Forms.Label()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.txtDespachadoPor = New System.Windows.Forms.TextBox()
        Me.txtNoTransferencia = New System.Windows.Forms.TextBox()
        Me.lblNoTransferencia = New System.Windows.Forms.Label()
        Me.cmdBuscarRepuesto = New System.Windows.Forms.Button()
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbDesplegableCodigo = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cmbDescripcionRepuesto = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grdDetalleTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbSitioDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDesplegableCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDescripcionRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDetalleTransferencia
        '
        Me.grdDetalleTransferencia.AllowAddNew = True
        Me.grdDetalleTransferencia.AllowDelete = True
        Me.grdDetalleTransferencia.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.grdDetalleTransferencia.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleTransferencia.Images.Add(CType(resources.GetObject("grdDetalleTransferencia.Images"), System.Drawing.Image))
        Me.grdDetalleTransferencia.Location = New System.Drawing.Point(10, 243)
        Me.grdDetalleTransferencia.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.grdDetalleTransferencia.Name = "grdDetalleTransferencia"
        Me.grdDetalleTransferencia.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleTransferencia.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleTransferencia.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDetalleTransferencia.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalleTransferencia.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalleTransferencia.Size = New System.Drawing.Size(801, 197)
        Me.grdDetalleTransferencia.TabIndex = 76
        Me.grdDetalleTransferencia.PropBag = resources.GetString("grdDetalleTransferencia.PropBag")
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbSitioDestino)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbSitioOrigen)
        Me.gbxDatosGenerales.Controls.Add(Me.txtObservaciones)
        Me.gbxDatosGenerales.Controls.Add(Me.lblDespachadopor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblObservaciones)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaIngreso)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSitioDestino)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSitioOrigen)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFecha)
        Me.gbxDatosGenerales.Controls.Add(Me.txtDespachadoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNoTransferencia)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoTransferencia)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(10, 13)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(818, 186)
        Me.gbxDatosGenerales.TabIndex = 79
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
        '
        'cmbSitioDestino
        '
        Me.cmbSitioDestino.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSitioDestino.Caption = ""
        Me.cmbSitioDestino.CaptionHeight = 17
        Me.cmbSitioDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSitioDestino.ColumnCaptionHeight = 17
        Me.cmbSitioDestino.ColumnFooterHeight = 17
        Me.cmbSitioDestino.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSitioDestino.ContentHeight = 15
        Me.cmbSitioDestino.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSitioDestino.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSitioDestino.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSitioDestino.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSitioDestino.EditorHeight = 15
        Me.cmbSitioDestino.Images.Add(CType(resources.GetObject("cmbSitioDestino.Images"), System.Drawing.Image))
        Me.cmbSitioDestino.ItemHeight = 15
        Me.cmbSitioDestino.Location = New System.Drawing.Point(120, 84)
        Me.cmbSitioDestino.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSitioDestino.MaxDropDownItems = CType(5, Short)
        Me.cmbSitioDestino.MaxLength = 32767
        Me.cmbSitioDestino.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSitioDestino.Name = "cmbSitioDestino"
        Me.cmbSitioDestino.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSitioDestino.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSitioDestino.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSitioDestino.Size = New System.Drawing.Size(174, 21)
        Me.cmbSitioDestino.TabIndex = 0
        Me.cmbSitioDestino.Tag = ""
        Me.cmbSitioDestino.PropBag = resources.GetString("cmbSitioDestino.PropBag")
        '
        'cmbSitioOrigen
        '
        Me.cmbSitioOrigen.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSitioOrigen.Caption = ""
        Me.cmbSitioOrigen.CaptionHeight = 17
        Me.cmbSitioOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSitioOrigen.ColumnCaptionHeight = 17
        Me.cmbSitioOrigen.ColumnFooterHeight = 17
        Me.cmbSitioOrigen.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSitioOrigen.ContentHeight = 15
        Me.cmbSitioOrigen.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSitioOrigen.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSitioOrigen.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSitioOrigen.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSitioOrigen.EditorHeight = 15
        Me.cmbSitioOrigen.Enabled = False
        Me.cmbSitioOrigen.Images.Add(CType(resources.GetObject("cmbSitioOrigen.Images"), System.Drawing.Image))
        Me.cmbSitioOrigen.ItemHeight = 15
        Me.cmbSitioOrigen.Location = New System.Drawing.Point(120, 53)
        Me.cmbSitioOrigen.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSitioOrigen.MaxDropDownItems = CType(5, Short)
        Me.cmbSitioOrigen.MaxLength = 32767
        Me.cmbSitioOrigen.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSitioOrigen.Name = "cmbSitioOrigen"
        Me.cmbSitioOrigen.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSitioOrigen.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSitioOrigen.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSitioOrigen.Size = New System.Drawing.Size(174, 21)
        Me.cmbSitioOrigen.TabIndex = 0
        Me.cmbSitioOrigen.TabStop = False
        Me.cmbSitioOrigen.Tag = "BLOQUEADO"
        Me.cmbSitioOrigen.PropBag = resources.GetString("cmbSitioOrigen.PropBag")
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsTab = True
        Me.txtObservaciones.Location = New System.Drawing.Point(120, 116)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(673, 55)
        Me.txtObservaciones.TabIndex = 1
        Me.txtObservaciones.Tag = ""
        '
        'lblDespachadopor
        '
        Me.lblDespachadopor.AutoSize = True
        Me.lblDespachadopor.BackColor = System.Drawing.Color.Transparent
        Me.lblDespachadopor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDespachadopor.Location = New System.Drawing.Point(535, 54)
        Me.lblDespachadopor.Name = "lblDespachadopor"
        Me.lblDespachadopor.Size = New System.Drawing.Size(104, 13)
        Me.lblDespachadopor.TabIndex = 92
        Me.lblDespachadopor.Tag = ""
        Me.lblDespachadopor.Text = "Despachado por:"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(10, 115)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(95, 13)
        Me.lblObservaciones.TabIndex = 92
        Me.lblObservaciones.Tag = ""
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.Location = New System.Drawing.Point(535, 22)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(46, 13)
        Me.lblFechaIngreso.TabIndex = 88
        Me.lblFechaIngreso.Tag = ""
        Me.lblFechaIngreso.Text = "Fecha:"
        '
        'lblSitioDestino
        '
        Me.lblSitioDestino.BackColor = System.Drawing.Color.Transparent
        Me.lblSitioDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSitioDestino.Location = New System.Drawing.Point(10, 83)
        Me.lblSitioDestino.Name = "lblSitioDestino"
        Me.lblSitioDestino.Size = New System.Drawing.Size(83, 18)
        Me.lblSitioDestino.TabIndex = 86
        Me.lblSitioDestino.Tag = ""
        Me.lblSitioDestino.Text = "Sitio Destino:"
        '
        'lblSitioOrigen
        '
        Me.lblSitioOrigen.BackColor = System.Drawing.Color.Transparent
        Me.lblSitioOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSitioOrigen.Location = New System.Drawing.Point(10, 51)
        Me.lblSitioOrigen.Name = "lblSitioOrigen"
        Me.lblSitioOrigen.Size = New System.Drawing.Size(83, 18)
        Me.lblSitioOrigen.TabIndex = 86
        Me.lblSitioOrigen.Tag = ""
        Me.lblSitioOrigen.Text = "Sitio Origen:"
        '
        'dtpFecha
        '
        Me.dtpFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFecha.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.ClearText = "&Clear"
        Me.dtpFecha.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 8, 10, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.CustomFormat = "dd/mm/yyyy"
        Me.dtpFecha.EditMask = "##/##/####"
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.Location = New System.Drawing.Point(640, 21)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(155, 18)
        Me.dtpFecha.TabIndex = 0
        Me.dtpFecha.Tag = "BLOQUEADO"
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDespachadoPor
        '
        Me.txtDespachadoPor.Location = New System.Drawing.Point(640, 52)
        Me.txtDespachadoPor.Name = "txtDespachadoPor"
        Me.txtDespachadoPor.Size = New System.Drawing.Size(156, 20)
        Me.txtDespachadoPor.TabIndex = 0
        Me.txtDespachadoPor.TabStop = False
        Me.txtDespachadoPor.Tag = "BLOQUEADO"
        '
        'txtNoTransferencia
        '
        Me.txtNoTransferencia.Location = New System.Drawing.Point(120, 20)
        Me.txtNoTransferencia.Name = "txtNoTransferencia"
        Me.txtNoTransferencia.Size = New System.Drawing.Size(174, 20)
        Me.txtNoTransferencia.TabIndex = 0
        Me.txtNoTransferencia.TabStop = False
        Me.txtNoTransferencia.Tag = "BLOQUEADO"
        Me.txtNoTransferencia.Text = "(Automático)"
        '
        'lblNoTransferencia
        '
        Me.lblNoTransferencia.AutoSize = True
        Me.lblNoTransferencia.BackColor = System.Drawing.Color.Transparent
        Me.lblNoTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoTransferencia.Location = New System.Drawing.Point(10, 22)
        Me.lblNoTransferencia.Name = "lblNoTransferencia"
        Me.lblNoTransferencia.Size = New System.Drawing.Size(113, 13)
        Me.lblNoTransferencia.TabIndex = 19
        Me.lblNoTransferencia.Tag = ""
        Me.lblNoTransferencia.Text = "No. Transferencia:"
        '
        'cmdBuscarRepuesto
        '
        Me.cmdBuscarRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBuscarRepuesto.Image = CType(resources.GetObject("cmdBuscarRepuesto.Image"), System.Drawing.Image)
        Me.cmdBuscarRepuesto.Location = New System.Drawing.Point(781, 211)
        Me.cmdBuscarRepuesto.Name = "cmdBuscarRepuesto"
        Me.cmdBuscarRepuesto.Size = New System.Drawing.Size(29, 25)
        Me.cmdBuscarRepuesto.TabIndex = 81
        Me.cmdBuscarRepuesto.UseVisualStyleBackColor = True
        Me.cmdBuscarRepuesto.Visible = False
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
        'cmbDesplegableCodigo
        '
        Me.cmbDesplegableCodigo.AllowColMove = True
        Me.cmbDesplegableCodigo.AllowColSelect = True
        Me.cmbDesplegableCodigo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cmbDesplegableCodigo.AllowSort = False
        Me.cmbDesplegableCodigo.AlternatingRows = False
        Me.cmbDesplegableCodigo.CaptionStyle = Style1
        Me.cmbDesplegableCodigo.ColumnCaptionHeight = 17
        Me.cmbDesplegableCodigo.ColumnFooterHeight = 17
        Me.cmbDesplegableCodigo.DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Column
        Me.cmbDesplegableCodigo.EvenRowStyle = Style2
        Me.cmbDesplegableCodigo.FetchRowStyles = False
        Me.cmbDesplegableCodigo.FooterStyle = Style3
        Me.cmbDesplegableCodigo.HeadingStyle = Style4
        Me.cmbDesplegableCodigo.HighLightRowStyle = Style5
        Me.cmbDesplegableCodigo.Images.Add(CType(resources.GetObject("cmbDesplegableCodigo.Images"), System.Drawing.Image))
        Me.cmbDesplegableCodigo.Location = New System.Drawing.Point(34, 287)
        Me.cmbDesplegableCodigo.Name = "cmbDesplegableCodigo"
        Me.cmbDesplegableCodigo.OddRowStyle = Style6
        Me.cmbDesplegableCodigo.RecordSelectorStyle = Style7
        Me.cmbDesplegableCodigo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbDesplegableCodigo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cmbDesplegableCodigo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbDesplegableCodigo.ScrollTips = False
        Me.cmbDesplegableCodigo.Size = New System.Drawing.Size(296, 142)
        Me.cmbDesplegableCodigo.Style = Style8
        Me.cmbDesplegableCodigo.TabIndex = 83
        Me.cmbDesplegableCodigo.TabStop = False
        Me.cmbDesplegableCodigo.ValueTranslate = True
        Me.cmbDesplegableCodigo.Visible = False
        Me.cmbDesplegableCodigo.PropBag = resources.GetString("cmbDesplegableCodigo.PropBag")
        '
        'cmbDescripcionRepuesto
        '
        Me.cmbDescripcionRepuesto.AllowColMove = True
        Me.cmbDescripcionRepuesto.AllowColSelect = True
        Me.cmbDescripcionRepuesto.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cmbDescripcionRepuesto.AlternatingRows = False
        Me.cmbDescripcionRepuesto.CaptionStyle = Style9
        Me.cmbDescripcionRepuesto.ColumnCaptionHeight = 17
        Me.cmbDescripcionRepuesto.ColumnFooterHeight = 17
        Me.cmbDescripcionRepuesto.DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Column
        Me.cmbDescripcionRepuesto.EvenRowStyle = Style10
        Me.cmbDescripcionRepuesto.FetchRowStyles = False
        Me.cmbDescripcionRepuesto.FooterStyle = Style11
        Me.cmbDescripcionRepuesto.HeadingStyle = Style12
        Me.cmbDescripcionRepuesto.HighLightRowStyle = Style13
        Me.cmbDescripcionRepuesto.Images.Add(CType(resources.GetObject("cmbDescripcionRepuesto.Images"), System.Drawing.Image))
        Me.cmbDescripcionRepuesto.Location = New System.Drawing.Point(134, 276)
        Me.cmbDescripcionRepuesto.Name = "cmbDescripcionRepuesto"
        Me.cmbDescripcionRepuesto.OddRowStyle = Style14
        Me.cmbDescripcionRepuesto.RecordSelectorStyle = Style15
        Me.cmbDescripcionRepuesto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbDescripcionRepuesto.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cmbDescripcionRepuesto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbDescripcionRepuesto.ScrollTips = False
        Me.cmbDescripcionRepuesto.Size = New System.Drawing.Size(296, 142)
        Me.cmbDescripcionRepuesto.Style = Style16
        Me.cmbDescripcionRepuesto.TabIndex = 82
        Me.cmbDescripcionRepuesto.TabStop = False
        Me.cmbDescripcionRepuesto.Visible = False
        Me.cmbDescripcionRepuesto.PropBag = resources.GetString("cmbDescripcionRepuesto.PropBag")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 21)
        Me.Panel1.TabIndex = 95
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(833, 513)
        Me.PanelControl1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(725, 455)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 87
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(634, 455)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 86
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'frmSivDespTransferenciaEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbDesplegableCodigo)
        Me.Controls.Add(Me.cmbDescripcionRepuesto)
        Me.Controls.Add(Me.cmdBuscarRepuesto)
        Me.Controls.Add(Me.grdDetalleTransferencia)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivDespTransferenciaEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transferir"
        CType(Me.grdDetalleTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbSitioDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDesplegableCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDescripcionRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdDetalleTransferencia As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSitioDestino As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSitioOrigen As C1.Win.C1List.C1Combo
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblDespachadopor As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblSitioDestino As System.Windows.Forms.Label
    Friend WithEvents lblSitioOrigen As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDespachadoPor As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblNoTransferencia As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarRepuesto As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents cmbDesplegableCodigo As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmbDescripcionRepuesto As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
End Class
