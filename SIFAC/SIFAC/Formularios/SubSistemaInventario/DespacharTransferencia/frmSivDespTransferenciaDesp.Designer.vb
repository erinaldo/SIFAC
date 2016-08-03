<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivDespTransferenciaDesp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivDespTransferenciaDesp))
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox
        Me.lblGuion3 = New System.Windows.Forms.Label
        Me.LblGuion2 = New System.Windows.Forms.Label
        Me.lblGuion1 = New System.Windows.Forms.Label
        Me.cmbSitioDestino = New C1.Win.C1List.C1Combo
        Me.cmbSitioOrigen = New C1.Win.C1List.C1Combo
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.lblSolicitadoPor = New System.Windows.Forms.Label
        Me.lblRecibidoPor = New System.Windows.Forms.Label
        Me.lblDespachadopor = New System.Windows.Forms.Label
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.lblSitioDestino = New System.Windows.Forms.Label
        Me.lblSitioOrigen = New System.Windows.Forms.Label
        Me.dtpFechaRecepcion = New C1.Win.C1Input.C1DateEdit
        Me.txtSolicitadoPor = New System.Windows.Forms.TextBox
        Me.dtpFechaDespacho = New C1.Win.C1Input.C1DateEdit
        Me.txtRecibidoPor = New System.Windows.Forms.TextBox
        Me.dtpFechaSolicitud = New C1.Win.C1Input.C1DateEdit
        Me.txtDespachadoPor = New System.Windows.Forms.TextBox
        Me.txtNoTransferencia = New System.Windows.Forms.TextBox
        Me.lblNoTransferencia = New System.Windows.Forms.Label
        Me.cmbDesplegableCodigo = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cmbDescripcionRepuesto = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.cmdBuscarRepuesto = New System.Windows.Forms.Button
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.grdDetalleTransferencia = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbSitioDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDesplegableCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDescripcionRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(839, 32)
        Me.Panel2.TabIndex = 81
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(768, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.lblGuion3)
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
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaRecepcion)
        Me.gbxDatosGenerales.Controls.Add(Me.txtSolicitadoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaDespacho)
        Me.gbxDatosGenerales.Controls.Add(Me.txtRecibidoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaSolicitud)
        Me.gbxDatosGenerales.Controls.Add(Me.txtDespachadoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNoTransferencia)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoTransferencia)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(9, 38)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(818, 186)
        Me.gbxDatosGenerales.TabIndex = 82
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
        '
        'lblGuion3
        '
        Me.lblGuion3.AutoSize = True
        Me.lblGuion3.Location = New System.Drawing.Point(626, 93)
        Me.lblGuion3.Name = "lblGuion3"
        Me.lblGuion3.Size = New System.Drawing.Size(10, 13)
        Me.lblGuion3.TabIndex = 93
        Me.lblGuion3.Text = "-"
        Me.lblGuion3.Visible = False
        '
        'LblGuion2
        '
        Me.LblGuion2.AutoSize = True
        Me.LblGuion2.Location = New System.Drawing.Point(626, 59)
        Me.LblGuion2.Name = "LblGuion2"
        Me.LblGuion2.Size = New System.Drawing.Size(10, 13)
        Me.LblGuion2.TabIndex = 93
        Me.LblGuion2.Text = "-"
        '
        'lblGuion1
        '
        Me.lblGuion1.AutoSize = True
        Me.lblGuion1.Location = New System.Drawing.Point(626, 21)
        Me.lblGuion1.Name = "lblGuion1"
        Me.lblGuion1.Size = New System.Drawing.Size(10, 13)
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
        Me.cmbSitioDestino.Enabled = False
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
        'lblSolicitadoPor
        '
        Me.lblSolicitadoPor.AutoSize = True
        Me.lblSolicitadoPor.BackColor = System.Drawing.SystemColors.Control
        Me.lblSolicitadoPor.Location = New System.Drawing.Point(373, 23)
        Me.lblSolicitadoPor.Name = "lblSolicitadoPor"
        Me.lblSolicitadoPor.Size = New System.Drawing.Size(74, 13)
        Me.lblSolicitadoPor.TabIndex = 92
        Me.lblSolicitadoPor.Tag = ""
        Me.lblSolicitadoPor.Text = "Solicitado por:"
        '
        'lblRecibidoPor
        '
        Me.lblRecibidoPor.AutoSize = True
        Me.lblRecibidoPor.BackColor = System.Drawing.SystemColors.Control
        Me.lblRecibidoPor.Location = New System.Drawing.Point(373, 92)
        Me.lblRecibidoPor.Name = "lblRecibidoPor"
        Me.lblRecibidoPor.Size = New System.Drawing.Size(70, 13)
        Me.lblRecibidoPor.TabIndex = 92
        Me.lblRecibidoPor.Tag = ""
        Me.lblRecibidoPor.Text = "Recibido por:"
        Me.lblRecibidoPor.Visible = False
        '
        'lblDespachadopor
        '
        Me.lblDespachadopor.AutoSize = True
        Me.lblDespachadopor.BackColor = System.Drawing.SystemColors.Control
        Me.lblDespachadopor.Location = New System.Drawing.Point(373, 58)
        Me.lblDespachadopor.Name = "lblDespachadopor"
        Me.lblDespachadopor.Size = New System.Drawing.Size(89, 13)
        Me.lblDespachadopor.TabIndex = 92
        Me.lblDespachadopor.Tag = ""
        Me.lblDespachadopor.Text = "Despachado por:"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.SystemColors.Control
        Me.lblObservaciones.Location = New System.Drawing.Point(15, 117)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 92
        Me.lblObservaciones.Tag = ""
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblSitioDestino
        '
        Me.lblSitioDestino.BackColor = System.Drawing.SystemColors.Control
        Me.lblSitioDestino.Location = New System.Drawing.Point(15, 85)
        Me.lblSitioDestino.Name = "lblSitioDestino"
        Me.lblSitioDestino.Size = New System.Drawing.Size(83, 18)
        Me.lblSitioDestino.TabIndex = 86
        Me.lblSitioDestino.Tag = ""
        Me.lblSitioDestino.Text = "Sitio Destino:"
        '
        'lblSitioOrigen
        '
        Me.lblSitioOrigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblSitioOrigen.Location = New System.Drawing.Point(15, 53)
        Me.lblSitioOrigen.Name = "lblSitioOrigen"
        Me.lblSitioOrigen.Size = New System.Drawing.Size(83, 18)
        Me.lblSitioOrigen.TabIndex = 86
        Me.lblSitioOrigen.Tag = ""
        Me.lblSitioOrigen.Text = "Sitio Origen:"
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaRecepcion.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaRecepcion.EditMask = "##/##/####"
        Me.dtpFechaRecepcion.Enabled = False
        Me.dtpFechaRecepcion.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(640, 88)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(155, 18)
        Me.dtpFechaRecepcion.TabIndex = 0
        Me.dtpFechaRecepcion.Tag = "BLOQUEADO"
        Me.dtpFechaRecepcion.Visible = False
        Me.dtpFechaRecepcion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtSolicitadoPor
        '
        Me.txtSolicitadoPor.Location = New System.Drawing.Point(466, 18)
        Me.txtSolicitadoPor.Name = "txtSolicitadoPor"
        Me.txtSolicitadoPor.Size = New System.Drawing.Size(156, 20)
        Me.txtSolicitadoPor.TabIndex = 0
        Me.txtSolicitadoPor.TabStop = False
        Me.txtSolicitadoPor.Tag = "BLOQUEADO"
        '
        'dtpFechaDespacho
        '
        Me.dtpFechaDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDespacho.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDespacho.EditMask = "##/##/####"
        Me.dtpFechaDespacho.Enabled = False
        Me.dtpFechaDespacho.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDespacho.Location = New System.Drawing.Point(640, 54)
        Me.dtpFechaDespacho.Name = "dtpFechaDespacho"
        Me.dtpFechaDespacho.Size = New System.Drawing.Size(155, 18)
        Me.dtpFechaDespacho.TabIndex = 0
        Me.dtpFechaDespacho.Tag = "BLOQUEADO"
        Me.dtpFechaDespacho.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtRecibidoPor
        '
        Me.txtRecibidoPor.Location = New System.Drawing.Point(466, 88)
        Me.txtRecibidoPor.Name = "txtRecibidoPor"
        Me.txtRecibidoPor.Size = New System.Drawing.Size(156, 20)
        Me.txtRecibidoPor.TabIndex = 0
        Me.txtRecibidoPor.TabStop = False
        Me.txtRecibidoPor.Tag = "BLOQUEADO"
        Me.txtRecibidoPor.Visible = False
        '
        'dtpFechaSolicitud
        '
        Me.dtpFechaSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaSolicitud.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaSolicitud.EditMask = "##/##/####"
        Me.dtpFechaSolicitud.Enabled = False
        Me.dtpFechaSolicitud.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaSolicitud.Location = New System.Drawing.Point(640, 17)
        Me.dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        Me.dtpFechaSolicitud.Size = New System.Drawing.Size(155, 18)
        Me.dtpFechaSolicitud.TabIndex = 0
        Me.dtpFechaSolicitud.Tag = "BLOQUEADO"
        Me.dtpFechaSolicitud.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDespachadoPor
        '
        Me.txtDespachadoPor.Location = New System.Drawing.Point(466, 54)
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
        Me.lblNoTransferencia.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoTransferencia.Location = New System.Drawing.Point(15, 24)
        Me.lblNoTransferencia.Name = "lblNoTransferencia"
        Me.lblNoTransferencia.Size = New System.Drawing.Size(95, 13)
        Me.lblNoTransferencia.TabIndex = 19
        Me.lblNoTransferencia.Tag = ""
        Me.lblNoTransferencia.Text = "No. Transferencia:"
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
        Me.cmbDesplegableCodigo.Location = New System.Drawing.Point(44, 310)
        Me.cmbDesplegableCodigo.Name = "cmbDesplegableCodigo"
        Me.cmbDesplegableCodigo.OddRowStyle = Style6
        Me.cmbDesplegableCodigo.RecordSelectorStyle = Style7
        Me.cmbDesplegableCodigo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbDesplegableCodigo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cmbDesplegableCodigo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbDesplegableCodigo.ScrollTips = False
        Me.cmbDesplegableCodigo.Size = New System.Drawing.Size(296, 142)
        Me.cmbDesplegableCodigo.Style = Style8
        Me.cmbDesplegableCodigo.TabIndex = 87
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
        Me.cmbDescripcionRepuesto.Location = New System.Drawing.Point(144, 299)
        Me.cmbDescripcionRepuesto.Name = "cmbDescripcionRepuesto"
        Me.cmbDescripcionRepuesto.OddRowStyle = Style14
        Me.cmbDescripcionRepuesto.RecordSelectorStyle = Style15
        Me.cmbDescripcionRepuesto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbDescripcionRepuesto.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cmbDescripcionRepuesto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbDescripcionRepuesto.ScrollTips = False
        Me.cmbDescripcionRepuesto.Size = New System.Drawing.Size(296, 142)
        Me.cmbDescripcionRepuesto.Style = Style16
        Me.cmbDescripcionRepuesto.TabIndex = 86
        Me.cmbDescripcionRepuesto.TabStop = False
        Me.cmbDescripcionRepuesto.Visible = False
        Me.cmbDescripcionRepuesto.PropBag = resources.GetString("cmbDescripcionRepuesto.PropBag")
        '
        'cmdBuscarRepuesto
        '
        Me.cmdBuscarRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBuscarRepuesto.ImageIndex = 1
        Me.cmdBuscarRepuesto.ImageList = Me.imgIconos
        Me.cmdBuscarRepuesto.Location = New System.Drawing.Point(791, 234)
        Me.cmdBuscarRepuesto.Name = "cmdBuscarRepuesto"
        Me.cmdBuscarRepuesto.Size = New System.Drawing.Size(29, 25)
        Me.cmdBuscarRepuesto.TabIndex = 85
        Me.cmdBuscarRepuesto.UseVisualStyleBackColor = True
        '
        'imgIconos
        '
        Me.imgIconos.ImageStream = CType(resources.GetObject("imgIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIconos.Images.SetKeyName(0, "Usuario.gif")
        Me.imgIconos.Images.SetKeyName(1, "Buscar.png")
        '
        'grdDetalleTransferencia
        '
        Me.grdDetalleTransferencia.AllowAddNew = True
        Me.grdDetalleTransferencia.AllowDelete = True
        Me.grdDetalleTransferencia.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.grdDetalleTransferencia.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleTransferencia.Images.Add(CType(resources.GetObject("grdDetalleTransferencia.Images"), System.Drawing.Image))
        Me.grdDetalleTransferencia.Location = New System.Drawing.Point(12, 266)
        Me.grdDetalleTransferencia.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.grdDetalleTransferencia.Name = "grdDetalleTransferencia"
        Me.grdDetalleTransferencia.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleTransferencia.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleTransferencia.PreviewInfo.ZoomFactor = 75
        Me.grdDetalleTransferencia.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalleTransferencia.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalleTransferencia.Size = New System.Drawing.Size(809, 233)
        Me.grdDetalleTransferencia.TabIndex = 84
        Me.grdDetalleTransferencia.PropBag = resources.GetString("grdDetalleTransferencia.PropBag")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(747, 505)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 89
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(667, 505)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(74, 30)
        Me.cmdGuardar.TabIndex = 88
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 543)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 21)
        Me.Panel1.TabIndex = 95
        '
        'frmSivDespTransferenciaDesp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 564)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmbDesplegableCodigo)
        Me.Controls.Add(Me.cmbDescripcionRepuesto)
        Me.Controls.Add(Me.cmdBuscarRepuesto)
        Me.Controls.Add(Me.grdDetalleTransferencia)
        Me.Controls.Add(Me.gbxDatosGenerales)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivDespTransferenciaDesp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Despachar Transferencia"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbSitioDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDesplegableCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDescripcionRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSitioDestino As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSitioOrigen As C1.Win.C1List.C1Combo
    Friend WithEvents lblDespachadopor As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblSitioDestino As System.Windows.Forms.Label
    Friend WithEvents lblSitioOrigen As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSolicitud As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDespachadoPor As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblNoTransferencia As System.Windows.Forms.Label
    Friend WithEvents cmbDesplegableCodigo As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmbDescripcionRepuesto As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmdBuscarRepuesto As System.Windows.Forms.Button
    Friend WithEvents grdDetalleTransferencia As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblGuion1 As System.Windows.Forms.Label
    Friend WithEvents lblSolicitadoPor As System.Windows.Forms.Label
    Friend WithEvents txtSolicitadoPor As System.Windows.Forms.TextBox
    Friend WithEvents LblGuion2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDespacho As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblGuion3 As System.Windows.Forms.Label
    Friend WithEvents lblRecibidoPor As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRecepcion As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtRecibidoPor As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
