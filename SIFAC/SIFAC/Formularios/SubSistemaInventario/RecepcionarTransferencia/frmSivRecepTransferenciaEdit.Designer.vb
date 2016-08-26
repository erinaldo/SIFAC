<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivRecepTransferenciaEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivRecepTransferenciaEdit))
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblGuion2 = New System.Windows.Forms.Label()
        Me.lblGuion1 = New System.Windows.Forms.Label()
        Me.cmbSitioDestino = New C1.Win.C1List.C1Combo()
        Me.cmbSitioOrigen = New C1.Win.C1List.C1Combo()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblSolicitadoPor = New System.Windows.Forms.Label()
        Me.lblRecibidoPor = New System.Windows.Forms.Label()
        Me.lblDespachadopor = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblSitioDestino = New System.Windows.Forms.Label()
        Me.lblSitioOrigen = New System.Windows.Forms.Label()
        Me.txtSolicitadoPor = New System.Windows.Forms.TextBox()
        Me.dtpFechaRecibido = New C1.Win.C1Input.C1DateEdit()
        Me.dtpFechaDespacho = New C1.Win.C1Input.C1DateEdit()
        Me.dtpFechaSolicitud = New C1.Win.C1Input.C1DateEdit()
        Me.txtRecibidoPor = New System.Windows.Forms.TextBox()
        Me.txtDespachadoPor = New System.Windows.Forms.TextBox()
        Me.txtNoTransferencia = New System.Windows.Forms.TextBox()
        Me.lblNoTransferencia = New System.Windows.Forms.Label()
        Me.grdDetalleTransferencia = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbSitioDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecibido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.LblGuion2)
        Me.gbxDatosGenerales.Controls.Add(Me.lblGuion1)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbSitioDestino)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbSitioOrigen)
        Me.gbxDatosGenerales.Controls.Add(Me.txtObservaciones)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSolicitadoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblRecibidoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblDespachadopor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblObservaciones)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSitioDestino)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSitioOrigen)
        Me.gbxDatosGenerales.Controls.Add(Me.txtSolicitadoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaRecibido)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaDespacho)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaSolicitud)
        Me.gbxDatosGenerales.Controls.Add(Me.txtRecibidoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.txtDespachadoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNoTransferencia)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoTransferencia)
        Me.gbxDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(9, 22)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(776, 196)
        Me.gbxDatosGenerales.TabIndex = 83
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(589, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "-"
        '
        'LblGuion2
        '
        Me.LblGuion2.AutoSize = True
        Me.LblGuion2.Location = New System.Drawing.Point(589, 56)
        Me.LblGuion2.Name = "LblGuion2"
        Me.LblGuion2.Size = New System.Drawing.Size(11, 13)
        Me.LblGuion2.TabIndex = 93
        Me.LblGuion2.Text = "-"
        '
        'lblGuion1
        '
        Me.lblGuion1.AutoSize = True
        Me.lblGuion1.Location = New System.Drawing.Point(589, 24)
        Me.lblGuion1.Name = "lblGuion1"
        Me.lblGuion1.Size = New System.Drawing.Size(11, 13)
        Me.lblGuion1.TabIndex = 93
        Me.lblGuion1.Text = "-"
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
        Me.cmbSitioDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSitioDestino.Images.Add(CType(resources.GetObject("cmbSitioDestino.Images"), System.Drawing.Image))
        Me.cmbSitioDestino.ItemHeight = 15
        Me.cmbSitioDestino.Location = New System.Drawing.Point(120, 87)
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
        Me.cmbSitioOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSitioOrigen.Images.Add(CType(resources.GetObject("cmbSitioOrigen.Images"), System.Drawing.Image))
        Me.cmbSitioOrigen.ItemHeight = 15
        Me.cmbSitioOrigen.Location = New System.Drawing.Point(120, 52)
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
        Me.cmbSitioOrigen.Tag = ""
        Me.cmbSitioOrigen.PropBag = resources.GetString("cmbSitioOrigen.PropBag")
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsTab = True
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(122, 125)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(636, 55)
        Me.txtObservaciones.TabIndex = 1
        Me.txtObservaciones.TabStop = False
        Me.txtObservaciones.Tag = ""
        '
        'lblSolicitadoPor
        '
        Me.lblSolicitadoPor.AutoSize = True
        Me.lblSolicitadoPor.BackColor = System.Drawing.Color.Transparent
        Me.lblSolicitadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitadoPor.Location = New System.Drawing.Point(323, 22)
        Me.lblSolicitadoPor.Name = "lblSolicitadoPor"
        Me.lblSolicitadoPor.Size = New System.Drawing.Size(89, 13)
        Me.lblSolicitadoPor.TabIndex = 92
        Me.lblSolicitadoPor.Tag = ""
        Me.lblSolicitadoPor.Text = "Solicitado por:"
        '
        'lblRecibidoPor
        '
        Me.lblRecibidoPor.AutoSize = True
        Me.lblRecibidoPor.BackColor = System.Drawing.Color.Transparent
        Me.lblRecibidoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecibidoPor.Location = New System.Drawing.Point(323, 89)
        Me.lblRecibidoPor.Name = "lblRecibidoPor"
        Me.lblRecibidoPor.Size = New System.Drawing.Size(83, 13)
        Me.lblRecibidoPor.TabIndex = 92
        Me.lblRecibidoPor.Tag = ""
        Me.lblRecibidoPor.Text = "Recibido por:"
        '
        'lblDespachadopor
        '
        Me.lblDespachadopor.AutoSize = True
        Me.lblDespachadopor.BackColor = System.Drawing.Color.Transparent
        Me.lblDespachadopor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDespachadopor.Location = New System.Drawing.Point(323, 54)
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
        Me.lblObservaciones.Location = New System.Drawing.Point(9, 123)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(95, 13)
        Me.lblObservaciones.TabIndex = 92
        Me.lblObservaciones.Tag = ""
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblSitioDestino
        '
        Me.lblSitioDestino.BackColor = System.Drawing.Color.Transparent
        Me.lblSitioDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSitioDestino.Location = New System.Drawing.Point(9, 86)
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
        Me.lblSitioOrigen.Location = New System.Drawing.Point(9, 51)
        Me.lblSitioOrigen.Name = "lblSitioOrigen"
        Me.lblSitioOrigen.Size = New System.Drawing.Size(83, 18)
        Me.lblSitioOrigen.TabIndex = 86
        Me.lblSitioOrigen.Tag = ""
        Me.lblSitioOrigen.Text = "Sitio Origen:"
        '
        'txtSolicitadoPor
        '
        Me.txtSolicitadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicitadoPor.Location = New System.Drawing.Point(429, 20)
        Me.txtSolicitadoPor.Name = "txtSolicitadoPor"
        Me.txtSolicitadoPor.Size = New System.Drawing.Size(156, 20)
        Me.txtSolicitadoPor.TabIndex = 0
        Me.txtSolicitadoPor.TabStop = False
        Me.txtSolicitadoPor.Tag = ""
        '
        'dtpFechaRecibido
        '
        Me.dtpFechaRecibido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaRecibido.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaRecibido.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaRecibido.Calendar.ClearText = "&Clear"
        Me.dtpFechaRecibido.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaRecibido.Calendar.SelectedDate = New Date(2016, 8, 16, 0, 0, 0, 0)
        Me.dtpFechaRecibido.Calendar.TodayText = "&Today"
        Me.dtpFechaRecibido.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaRecibido.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaRecibido.EditMask = "##/##/####"
        Me.dtpFechaRecibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRecibido.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaRecibido.Location = New System.Drawing.Point(603, 86)
        Me.dtpFechaRecibido.Name = "dtpFechaRecibido"
        Me.dtpFechaRecibido.Size = New System.Drawing.Size(155, 18)
        Me.dtpFechaRecibido.TabIndex = 0
        Me.dtpFechaRecibido.Tag = Nothing
        Me.dtpFechaRecibido.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFechaDespacho
        '
        Me.dtpFechaDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaDespacho.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaDespacho.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaDespacho.Calendar.ClearText = "&Clear"
        Me.dtpFechaDespacho.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaDespacho.Calendar.SelectedDate = New Date(2016, 8, 16, 0, 0, 0, 0)
        Me.dtpFechaDespacho.Calendar.TodayText = "&Today"
        Me.dtpFechaDespacho.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaDespacho.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDespacho.EditMask = "##/##/####"
        Me.dtpFechaDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDespacho.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDespacho.Location = New System.Drawing.Point(603, 51)
        Me.dtpFechaDespacho.Name = "dtpFechaDespacho"
        Me.dtpFechaDespacho.Size = New System.Drawing.Size(155, 18)
        Me.dtpFechaDespacho.TabIndex = 0
        Me.dtpFechaDespacho.Tag = Nothing
        Me.dtpFechaDespacho.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFechaSolicitud
        '
        Me.dtpFechaSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaSolicitud.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaSolicitud.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaSolicitud.Calendar.ClearText = "&Clear"
        Me.dtpFechaSolicitud.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaSolicitud.Calendar.SelectedDate = New Date(2016, 8, 16, 0, 0, 0, 0)
        Me.dtpFechaSolicitud.Calendar.TodayText = "&Today"
        Me.dtpFechaSolicitud.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaSolicitud.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaSolicitud.EditMask = "##/##/####"
        Me.dtpFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSolicitud.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaSolicitud.Location = New System.Drawing.Point(603, 19)
        Me.dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        Me.dtpFechaSolicitud.Size = New System.Drawing.Size(155, 18)
        Me.dtpFechaSolicitud.TabIndex = 0
        Me.dtpFechaSolicitud.Tag = Nothing
        Me.dtpFechaSolicitud.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtRecibidoPor
        '
        Me.txtRecibidoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibidoPor.Location = New System.Drawing.Point(429, 87)
        Me.txtRecibidoPor.Name = "txtRecibidoPor"
        Me.txtRecibidoPor.Size = New System.Drawing.Size(156, 20)
        Me.txtRecibidoPor.TabIndex = 0
        Me.txtRecibidoPor.TabStop = False
        Me.txtRecibidoPor.Tag = ""
        '
        'txtDespachadoPor
        '
        Me.txtDespachadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDespachadoPor.Location = New System.Drawing.Point(429, 52)
        Me.txtDespachadoPor.Name = "txtDespachadoPor"
        Me.txtDespachadoPor.Size = New System.Drawing.Size(156, 20)
        Me.txtDespachadoPor.TabIndex = 0
        Me.txtDespachadoPor.TabStop = False
        Me.txtDespachadoPor.Tag = ""
        '
        'txtNoTransferencia
        '
        Me.txtNoTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTransferencia.Location = New System.Drawing.Point(120, 20)
        Me.txtNoTransferencia.Name = "txtNoTransferencia"
        Me.txtNoTransferencia.Size = New System.Drawing.Size(174, 20)
        Me.txtNoTransferencia.TabIndex = 0
        Me.txtNoTransferencia.TabStop = False
        Me.txtNoTransferencia.Tag = ""
        Me.txtNoTransferencia.Text = "(Automático)"
        '
        'lblNoTransferencia
        '
        Me.lblNoTransferencia.AutoSize = True
        Me.lblNoTransferencia.BackColor = System.Drawing.Color.Transparent
        Me.lblNoTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoTransferencia.Location = New System.Drawing.Point(9, 24)
        Me.lblNoTransferencia.Name = "lblNoTransferencia"
        Me.lblNoTransferencia.Size = New System.Drawing.Size(113, 13)
        Me.lblNoTransferencia.TabIndex = 19
        Me.lblNoTransferencia.Tag = ""
        Me.lblNoTransferencia.Text = "No. Transferencia:"
        '
        'grdDetalleTransferencia
        '
        Me.grdDetalleTransferencia.AllowAddNew = True
        Me.grdDetalleTransferencia.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.grdDetalleTransferencia.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
        Me.grdDetalleTransferencia.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleTransferencia.Images.Add(CType(resources.GetObject("grdDetalleTransferencia.Images"), System.Drawing.Image))
        Me.grdDetalleTransferencia.Location = New System.Drawing.Point(12, 227)
        Me.grdDetalleTransferencia.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.grdDetalleTransferencia.Name = "grdDetalleTransferencia"
        Me.grdDetalleTransferencia.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleTransferencia.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleTransferencia.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDetalleTransferencia.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalleTransferencia.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalleTransferencia.Size = New System.Drawing.Size(773, 233)
        Me.grdDetalleTransferencia.TabIndex = 0
        Me.grdDetalleTransferencia.PropBag = resources.GetString("grdDetalleTransferencia.PropBag")
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 503)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 21)
        Me.Panel1.TabIndex = 95
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(801, 524)
        Me.PanelControl1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(705, 469)
        Me.cmdCancelar.LookAndFeel.SkinName = "Caramel"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 85
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(614, 469)
        Me.cmdGuardar.LookAndFeel.SkinName = "Caramel"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 84
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmSivRecepTransferenciaEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdDetalleTransferencia)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivRecepTransferenciaEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recibir traslado"
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbSitioDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecibido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents LblGuion2 As System.Windows.Forms.Label
    Friend WithEvents lblGuion1 As System.Windows.Forms.Label
    Friend WithEvents cmbSitioDestino As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSitioOrigen As C1.Win.C1List.C1Combo
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblSolicitadoPor As System.Windows.Forms.Label
    Friend WithEvents lblDespachadopor As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblSitioDestino As System.Windows.Forms.Label
    Friend WithEvents lblSitioOrigen As System.Windows.Forms.Label
    Friend WithEvents txtSolicitadoPor As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaDespacho As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaSolicitud As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDespachadoPor As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblNoTransferencia As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRecibidoPor As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRecibido As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtRecibidoPor As System.Windows.Forms.TextBox
    Friend WithEvents grdDetalleTransferencia As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
End Class
