<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaCotizacionAnular
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaCotizacionAnular))
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtComentarios = New System.Windows.Forms.TextBox
        Me.lblComentarios = New System.Windows.Forms.Label
        Me.lblSubtotal = New System.Windows.Forms.Label
        Me.gbxDetalle = New System.Windows.Forms.GroupBox
        Me.grdDetalleCotizacion = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.NumSubTotal = New C1.Win.C1Input.C1NumericEdit
        Me.tbCotizacion = New System.Windows.Forms.TabControl
        Me.TPDatosGenerales = New System.Windows.Forms.TabPage
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox
        Me.txtComentariosAnulacion = New System.Windows.Forms.TextBox
        Me.lblComentariosAnulacion = New System.Windows.Forms.Label
        Me.cmbVendedor = New C1.Win.C1List.C1Combo
        Me.cmdAgregarCliente = New System.Windows.Forms.Button
        Me.cmdConsultarCliente = New System.Windows.Forms.Button
        Me.NumValido = New C1.Win.C1Input.C1NumericEdit
        Me.txtNumCliente = New System.Windows.Forms.TextBox
        Me.lblVendedor = New System.Windows.Forms.Label
        Me.txtAtencionA = New System.Windows.Forms.TextBox
        Me.lblAtencionA = New System.Windows.Forms.Label
        Me.lblValido = New System.Windows.Forms.Label
        Me.cmbTerminoPago = New C1.Win.C1List.C1Combo
        Me.lblTerminoPago = New System.Windows.Forms.Label
        Me.cmbTiempoEntrega = New C1.Win.C1List.C1Combo
        Me.cmbCliente = New C1.Win.C1List.C1Combo
        Me.cmbSucursal = New C1.Win.C1List.C1Combo
        Me.lblTiempoEntrega = New System.Windows.Forms.Label
        Me.lblFechaCotizacion = New System.Windows.Forms.Label
        Me.lblCliente = New System.Windows.Forms.Label
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.dtpFechaCotizacion = New C1.Win.C1Input.C1DateEdit
        Me.txtNumeroCotizacion = New System.Windows.Forms.TextBox
        Me.lblNoCotizacion = New System.Windows.Forms.Label
        Me.TPDatosCliente = New System.Windows.Forms.TabPage
        Me.gbxDatosCliente = New System.Windows.Forms.GroupBox
        Me.gbxDatosExpCxC = New System.Windows.Forms.GroupBox
        Me.grdDatosExpediente = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.chkExonerado = New System.Windows.Forms.CheckBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.txtEmails = New System.Windows.Forms.TextBox
        Me.lblEmails = New System.Windows.Forms.Label
        Me.txtTelefonos = New System.Windows.Forms.TextBox
        Me.lblTelefonos = New System.Windows.Forms.Label
        Me.lblExistencia = New System.Windows.Forms.Label
        Me.lblTasaCambio = New System.Windows.Forms.Label
        Me.lblDescuento = New System.Windows.Forms.Label
        Me.NumDescuento = New C1.Win.C1Input.C1NumericEdit
        Me.lblIVA = New System.Windows.Forms.Label
        Me.NumIVA = New C1.Win.C1Input.C1NumericEdit
        Me.lblTotalCordobas = New System.Windows.Forms.Label
        Me.NumTotalCordobas = New C1.Win.C1Input.C1NumericEdit
        Me.lblTotalDolares = New System.Windows.Forms.Label
        Me.NumTotalDolares = New C1.Win.C1Input.C1NumericEdit
        Me.NumExistencia = New C1.Win.C1Input.C1NumericEdit
        Me.NumTasaCambio = New C1.Win.C1Input.C1NumericEdit
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdDetalleCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCotizacion.SuspendLayout()
        Me.TPDatosGenerales.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumValido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTerminoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTiempoEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDatosCliente.SuspendLayout()
        Me.gbxDatosCliente.SuspendLayout()
        Me.gbxDatosExpCxC.SuspendLayout()
        CType(Me.grdDatosExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTotalCordobas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTotalDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTasaCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(766, 656)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(686, 656)
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
        'txtComentarios
        '
        Me.txtComentarios.AcceptsTab = True
        Me.txtComentarios.Location = New System.Drawing.Point(17, 546)
        Me.txtComentarios.MaxLength = 250
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarios.Size = New System.Drawing.Size(533, 86)
        Me.txtComentarios.TabIndex = 93
        Me.txtComentarios.Tag = ""
        '
        'lblComentarios
        '
        Me.lblComentarios.AutoSize = True
        Me.lblComentarios.BackColor = System.Drawing.SystemColors.Control
        Me.lblComentarios.Location = New System.Drawing.Point(14, 530)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Size = New System.Drawing.Size(68, 13)
        Me.lblComentarios.TabIndex = 94
        Me.lblComentarios.Tag = ""
        Me.lblComentarios.Text = "Comentarios:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblSubtotal.Location = New System.Drawing.Point(674, 501)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(56, 13)
        Me.lblSubtotal.TabIndex = 96
        Me.lblSubtotal.Tag = ""
        Me.lblSubtotal.Text = "Sub Total:"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.grdDetalleCotizacion)
        Me.gbxDetalle.Location = New System.Drawing.Point(12, 222)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(831, 264)
        Me.gbxDetalle.TabIndex = 101
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Otros Datos"
        '
        'grdDetalleCotizacion
        '
        Me.grdDetalleCotizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalleCotizacion.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleCotizacion.Images.Add(CType(resources.GetObject("grdDetalleCotizacion.Images"), System.Drawing.Image))
        Me.grdDetalleCotizacion.Images.Add(CType(resources.GetObject("grdDetalleCotizacion.Images1"), System.Drawing.Image))
        Me.grdDetalleCotizacion.Location = New System.Drawing.Point(3, 16)
        Me.grdDetalleCotizacion.Name = "grdDetalleCotizacion"
        Me.grdDetalleCotizacion.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleCotizacion.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleCotizacion.PreviewInfo.ZoomFactor = 75
        Me.grdDetalleCotizacion.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalleCotizacion.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalleCotizacion.Size = New System.Drawing.Size(825, 245)
        Me.grdDetalleCotizacion.TabIndex = 0
        Me.grdDetalleCotizacion.Text = "C1TrueDBGrid1"
        Me.grdDetalleCotizacion.PropBag = resources.GetString("grdDetalleCotizacion.PropBag")
        '
        'NumSubTotal
        '
        Me.NumSubTotal.DisplayFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumSubTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumSubTotal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumSubTotal.EditFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumSubTotal.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumSubTotal.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumSubTotal.Enabled = False
        Me.NumSubTotal.Location = New System.Drawing.Point(736, 498)
        Me.NumSubTotal.Name = "NumSubTotal"
        Me.NumSubTotal.Size = New System.Drawing.Size(107, 20)
        Me.NumSubTotal.TabIndex = 102
        Me.NumSubTotal.Tag = "BLOQUEADO"
        Me.NumSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumSubTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumSubTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'tbCotizacion
        '
        Me.tbCotizacion.Controls.Add(Me.TPDatosGenerales)
        Me.tbCotizacion.Controls.Add(Me.TPDatosCliente)
        Me.tbCotizacion.Location = New System.Drawing.Point(12, 38)
        Me.tbCotizacion.Name = "tbCotizacion"
        Me.tbCotizacion.SelectedIndex = 0
        Me.tbCotizacion.Size = New System.Drawing.Size(835, 178)
        Me.tbCotizacion.TabIndex = 103
        '
        'TPDatosGenerales
        '
        Me.TPDatosGenerales.Controls.Add(Me.gbxDatosGenerales)
        Me.TPDatosGenerales.Location = New System.Drawing.Point(4, 22)
        Me.TPDatosGenerales.Name = "TPDatosGenerales"
        Me.TPDatosGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDatosGenerales.Size = New System.Drawing.Size(827, 152)
        Me.TPDatosGenerales.TabIndex = 0
        Me.TPDatosGenerales.Text = "Datos Generales"
        Me.TPDatosGenerales.UseVisualStyleBackColor = True
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.txtComentariosAnulacion)
        Me.gbxDatosGenerales.Controls.Add(Me.lblComentariosAnulacion)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbVendedor)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdAgregarCliente)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdConsultarCliente)
        Me.gbxDatosGenerales.Controls.Add(Me.NumValido)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNumCliente)
        Me.gbxDatosGenerales.Controls.Add(Me.lblVendedor)
        Me.gbxDatosGenerales.Controls.Add(Me.txtAtencionA)
        Me.gbxDatosGenerales.Controls.Add(Me.lblAtencionA)
        Me.gbxDatosGenerales.Controls.Add(Me.lblValido)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTerminoPago)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTerminoPago)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTiempoEntrega)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbCliente)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbSucursal)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTiempoEntrega)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaCotizacion)
        Me.gbxDatosGenerales.Controls.Add(Me.lblCliente)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSucursal)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaCotizacion)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNumeroCotizacion)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoCotizacion)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(6, 6)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(818, 143)
        Me.gbxDatosGenerales.TabIndex = 74
        Me.gbxDatosGenerales.TabStop = False
        '
        'txtComentariosAnulacion
        '
        Me.txtComentariosAnulacion.AcceptsTab = True
        Me.txtComentariosAnulacion.Location = New System.Drawing.Point(69, 105)
        Me.txtComentariosAnulacion.MaxLength = 250
        Me.txtComentariosAnulacion.Multiline = True
        Me.txtComentariosAnulacion.Name = "txtComentariosAnulacion"
        Me.txtComentariosAnulacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentariosAnulacion.Size = New System.Drawing.Size(739, 31)
        Me.txtComentariosAnulacion.TabIndex = 122
        Me.txtComentariosAnulacion.Tag = ""
        '
        'lblComentariosAnulacion
        '
        Me.lblComentariosAnulacion.BackColor = System.Drawing.Color.Transparent
        Me.lblComentariosAnulacion.Location = New System.Drawing.Point(6, 110)
        Me.lblComentariosAnulacion.Name = "lblComentariosAnulacion"
        Me.lblComentariosAnulacion.Size = New System.Drawing.Size(68, 27)
        Me.lblComentariosAnulacion.TabIndex = 121
        Me.lblComentariosAnulacion.Tag = ""
        Me.lblComentariosAnulacion.Text = "Comentarios Anulación:"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbVendedor.Caption = ""
        Me.cmbVendedor.CaptionHeight = 17
        Me.cmbVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbVendedor.ColumnCaptionHeight = 17
        Me.cmbVendedor.ColumnFooterHeight = 17
        Me.cmbVendedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbVendedor.ContentHeight = 15
        Me.cmbVendedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbVendedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbVendedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbVendedor.EditorHeight = 15
        Me.cmbVendedor.Enabled = False
        Me.cmbVendedor.Images.Add(CType(resources.GetObject("cmbVendedor.Images"), System.Drawing.Image))
        Me.cmbVendedor.ItemHeight = 15
        Me.cmbVendedor.Location = New System.Drawing.Point(526, 79)
        Me.cmbVendedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbVendedor.MaxDropDownItems = CType(5, Short)
        Me.cmbVendedor.MaxLength = 32767
        Me.cmbVendedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbVendedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbVendedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbVendedor.Size = New System.Drawing.Size(282, 21)
        Me.cmbVendedor.TabIndex = 120
        Me.cmbVendedor.TabStop = False
        Me.cmbVendedor.Tag = "BLOQUEADO"
        Me.cmbVendedor.PropBag = resources.GetString("cmbVendedor.PropBag")
        '
        'cmdAgregarCliente
        '
        Me.cmdAgregarCliente.Location = New System.Drawing.Point(427, 48)
        Me.cmdAgregarCliente.Name = "cmdAgregarCliente"
        Me.cmdAgregarCliente.Size = New System.Drawing.Size(23, 23)
        Me.cmdAgregarCliente.TabIndex = 119
        Me.cmdAgregarCliente.Text = "..."
        Me.cmdAgregarCliente.UseVisualStyleBackColor = True
        '
        'cmdConsultarCliente
        '
        Me.cmdConsultarCliente.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdConsultarCliente.Location = New System.Drawing.Point(398, 48)
        Me.cmdConsultarCliente.Name = "cmdConsultarCliente"
        Me.cmdConsultarCliente.Size = New System.Drawing.Size(23, 23)
        Me.cmdConsultarCliente.TabIndex = 118
        Me.cmdConsultarCliente.UseVisualStyleBackColor = True
        '
        'NumValido
        '
        Me.NumValido.DisplayFormat.CustomFormat = "#0"
        Me.NumValido.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.NumValido.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumValido.EditFormat.CustomFormat = "#0"
        Me.NumValido.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.NumValido.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumValido.Location = New System.Drawing.Point(720, 16)
        Me.NumValido.Name = "NumValido"
        Me.NumValido.Size = New System.Drawing.Size(88, 20)
        Me.NumValido.TabIndex = 117
        Me.NumValido.Tag = Nothing
        Me.NumValido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumValido.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumValido.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNumCliente
        '
        Me.txtNumCliente.Location = New System.Drawing.Point(69, 49)
        Me.txtNumCliente.Name = "txtNumCliente"
        Me.txtNumCliente.Size = New System.Drawing.Size(113, 20)
        Me.txtNumCliente.TabIndex = 109
        Me.txtNumCliente.TabStop = False
        Me.txtNumCliente.Tag = ""
        '
        'lblVendedor
        '
        Me.lblVendedor.BackColor = System.Drawing.Color.Transparent
        Me.lblVendedor.Location = New System.Drawing.Point(460, 81)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(60, 18)
        Me.lblVendedor.TabIndex = 107
        Me.lblVendedor.Tag = ""
        Me.lblVendedor.Text = "Vendedor:"
        '
        'txtAtencionA
        '
        Me.txtAtencionA.Location = New System.Drawing.Point(69, 79)
        Me.txtAtencionA.Name = "txtAtencionA"
        Me.txtAtencionA.Size = New System.Drawing.Size(323, 20)
        Me.txtAtencionA.TabIndex = 105
        Me.txtAtencionA.TabStop = False
        Me.txtAtencionA.Tag = ""
        '
        'lblAtencionA
        '
        Me.lblAtencionA.BackColor = System.Drawing.Color.Transparent
        Me.lblAtencionA.Location = New System.Drawing.Point(6, 84)
        Me.lblAtencionA.Name = "lblAtencionA"
        Me.lblAtencionA.Size = New System.Drawing.Size(68, 18)
        Me.lblAtencionA.TabIndex = 104
        Me.lblAtencionA.Tag = ""
        Me.lblAtencionA.Text = "Atención A:"
        '
        'lblValido
        '
        Me.lblValido.AutoSize = True
        Me.lblValido.BackColor = System.Drawing.Color.Transparent
        Me.lblValido.Location = New System.Drawing.Point(651, 19)
        Me.lblValido.Name = "lblValido"
        Me.lblValido.Size = New System.Drawing.Size(69, 13)
        Me.lblValido.TabIndex = 98
        Me.lblValido.Tag = ""
        Me.lblValido.Text = "Válido (días):"
        '
        'cmbTerminoPago
        '
        Me.cmbTerminoPago.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTerminoPago.Caption = ""
        Me.cmbTerminoPago.CaptionHeight = 17
        Me.cmbTerminoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTerminoPago.ColumnCaptionHeight = 17
        Me.cmbTerminoPago.ColumnFooterHeight = 17
        Me.cmbTerminoPago.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTerminoPago.ContentHeight = 15
        Me.cmbTerminoPago.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTerminoPago.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTerminoPago.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTerminoPago.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTerminoPago.EditorHeight = 15
        Me.cmbTerminoPago.Images.Add(CType(resources.GetObject("cmbTerminoPago.Images"), System.Drawing.Image))
        Me.cmbTerminoPago.ItemHeight = 15
        Me.cmbTerminoPago.Location = New System.Drawing.Point(720, 50)
        Me.cmbTerminoPago.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTerminoPago.MaxDropDownItems = CType(5, Short)
        Me.cmbTerminoPago.MaxLength = 32767
        Me.cmbTerminoPago.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTerminoPago.Name = "cmbTerminoPago"
        Me.cmbTerminoPago.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTerminoPago.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTerminoPago.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTerminoPago.Size = New System.Drawing.Size(88, 21)
        Me.cmbTerminoPago.TabIndex = 97
        Me.cmbTerminoPago.PropBag = resources.GetString("cmbTerminoPago.PropBag")
        '
        'lblTerminoPago
        '
        Me.lblTerminoPago.AutoSize = True
        Me.lblTerminoPago.BackColor = System.Drawing.Color.Transparent
        Me.lblTerminoPago.Location = New System.Drawing.Point(651, 55)
        Me.lblTerminoPago.Name = "lblTerminoPago"
        Me.lblTerminoPago.Size = New System.Drawing.Size(47, 13)
        Me.lblTerminoPago.TabIndex = 96
        Me.lblTerminoPago.Tag = ""
        Me.lblTerminoPago.Text = "T/Pago:"
        '
        'cmbTiempoEntrega
        '
        Me.cmbTiempoEntrega.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTiempoEntrega.Caption = ""
        Me.cmbTiempoEntrega.CaptionHeight = 17
        Me.cmbTiempoEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTiempoEntrega.ColumnCaptionHeight = 17
        Me.cmbTiempoEntrega.ColumnFooterHeight = 17
        Me.cmbTiempoEntrega.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTiempoEntrega.ContentHeight = 15
        Me.cmbTiempoEntrega.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTiempoEntrega.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTiempoEntrega.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTiempoEntrega.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTiempoEntrega.EditorHeight = 15
        Me.cmbTiempoEntrega.Images.Add(CType(resources.GetObject("cmbTiempoEntrega.Images"), System.Drawing.Image))
        Me.cmbTiempoEntrega.ItemHeight = 15
        Me.cmbTiempoEntrega.Location = New System.Drawing.Point(526, 50)
        Me.cmbTiempoEntrega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTiempoEntrega.MaxDropDownItems = CType(5, Short)
        Me.cmbTiempoEntrega.MaxLength = 32767
        Me.cmbTiempoEntrega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTiempoEntrega.Name = "cmbTiempoEntrega"
        Me.cmbTiempoEntrega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTiempoEntrega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTiempoEntrega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTiempoEntrega.Size = New System.Drawing.Size(106, 21)
        Me.cmbTiempoEntrega.TabIndex = 95
        Me.cmbTiempoEntrega.PropBag = resources.GetString("cmbTiempoEntrega.PropBag")
        '
        'cmbCliente
        '
        Me.cmbCliente.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCliente.Caption = ""
        Me.cmbCliente.CaptionHeight = 17
        Me.cmbCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCliente.ColumnCaptionHeight = 17
        Me.cmbCliente.ColumnFooterHeight = 17
        Me.cmbCliente.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCliente.ContentHeight = 15
        Me.cmbCliente.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCliente.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCliente.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCliente.EditorHeight = 15
        Me.cmbCliente.Images.Add(CType(resources.GetObject("cmbCliente.Images"), System.Drawing.Image))
        Me.cmbCliente.ItemHeight = 15
        Me.cmbCliente.Location = New System.Drawing.Point(188, 48)
        Me.cmbCliente.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCliente.MaxDropDownItems = CType(5, Short)
        Me.cmbCliente.MaxLength = 32767
        Me.cmbCliente.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCliente.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCliente.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCliente.Size = New System.Drawing.Size(204, 21)
        Me.cmbCliente.TabIndex = 94
        Me.cmbCliente.TabStop = False
        Me.cmbCliente.Tag = ""
        Me.cmbCliente.PropBag = resources.GetString("cmbCliente.PropBag")
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
        Me.cmbSucursal.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursal.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursal.EditorHeight = 15
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.Images.Add(CType(resources.GetObject("cmbSucursal.Images"), System.Drawing.Image))
        Me.cmbSucursal.ItemHeight = 15
        Me.cmbSucursal.Location = New System.Drawing.Point(243, 16)
        Me.cmbSucursal.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursal.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursal.MaxLength = 32767
        Me.cmbSucursal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursal.Size = New System.Drawing.Size(149, 21)
        Me.cmbSucursal.TabIndex = 0
        Me.cmbSucursal.Tag = "BLOQUEADO"
        Me.cmbSucursal.PropBag = resources.GetString("cmbSucursal.PropBag")
        '
        'lblTiempoEntrega
        '
        Me.lblTiempoEntrega.AutoSize = True
        Me.lblTiempoEntrega.BackColor = System.Drawing.Color.Transparent
        Me.lblTiempoEntrega.Location = New System.Drawing.Point(460, 55)
        Me.lblTiempoEntrega.Name = "lblTiempoEntrega"
        Me.lblTiempoEntrega.Size = New System.Drawing.Size(60, 13)
        Me.lblTiempoEntrega.TabIndex = 92
        Me.lblTiempoEntrega.Tag = ""
        Me.lblTiempoEntrega.Text = "T. Entrega:"
        '
        'lblFechaCotizacion
        '
        Me.lblFechaCotizacion.AutoSize = True
        Me.lblFechaCotizacion.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaCotizacion.Location = New System.Drawing.Point(460, 21)
        Me.lblFechaCotizacion.Name = "lblFechaCotizacion"
        Me.lblFechaCotizacion.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaCotizacion.TabIndex = 88
        Me.lblFechaCotizacion.Tag = ""
        Me.lblFechaCotizacion.Text = "Fecha:"
        '
        'lblCliente
        '
        Me.lblCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblCliente.Location = New System.Drawing.Point(6, 53)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(83, 18)
        Me.lblCliente.TabIndex = 86
        Me.lblCliente.Tag = ""
        Me.lblCliente.Text = "Cliente:"
        '
        'lblSucursal
        '
        Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
        Me.lblSucursal.Location = New System.Drawing.Point(188, 19)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(59, 18)
        Me.lblSucursal.TabIndex = 86
        Me.lblSucursal.Tag = ""
        Me.lblSucursal.Text = "Sucursal:"
        '
        'dtpFechaCotizacion
        '
        Me.dtpFechaCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaCotizacion.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaCotizacion.EditMask = "##/##/####"
        Me.dtpFechaCotizacion.Enabled = False
        Me.dtpFechaCotizacion.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaCotizacion.Location = New System.Drawing.Point(526, 18)
        Me.dtpFechaCotizacion.Name = "dtpFechaCotizacion"
        Me.dtpFechaCotizacion.Size = New System.Drawing.Size(106, 18)
        Me.dtpFechaCotizacion.TabIndex = 0
        Me.dtpFechaCotizacion.Tag = "BLOQUEADO"
        Me.dtpFechaCotizacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtNumeroCotizacion
        '
        Me.txtNumeroCotizacion.Location = New System.Drawing.Point(69, 17)
        Me.txtNumeroCotizacion.Name = "txtNumeroCotizacion"
        Me.txtNumeroCotizacion.Size = New System.Drawing.Size(113, 20)
        Me.txtNumeroCotizacion.TabIndex = 0
        Me.txtNumeroCotizacion.TabStop = False
        Me.txtNumeroCotizacion.Tag = "BLOQUEADO"
        Me.txtNumeroCotizacion.Text = "(Automático)"
        '
        'lblNoCotizacion
        '
        Me.lblNoCotizacion.AutoSize = True
        Me.lblNoCotizacion.BackColor = System.Drawing.Color.Transparent
        Me.lblNoCotizacion.Location = New System.Drawing.Point(6, 23)
        Me.lblNoCotizacion.Name = "lblNoCotizacion"
        Me.lblNoCotizacion.Size = New System.Drawing.Size(47, 13)
        Me.lblNoCotizacion.TabIndex = 19
        Me.lblNoCotizacion.Tag = ""
        Me.lblNoCotizacion.Text = "Número:"
        '
        'TPDatosCliente
        '
        Me.TPDatosCliente.Controls.Add(Me.gbxDatosCliente)
        Me.TPDatosCliente.Location = New System.Drawing.Point(4, 22)
        Me.TPDatosCliente.Name = "TPDatosCliente"
        Me.TPDatosCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDatosCliente.Size = New System.Drawing.Size(827, 152)
        Me.TPDatosCliente.TabIndex = 1
        Me.TPDatosCliente.Text = "Datos del Cliente"
        Me.TPDatosCliente.UseVisualStyleBackColor = True
        '
        'gbxDatosCliente
        '
        Me.gbxDatosCliente.Controls.Add(Me.gbxDatosExpCxC)
        Me.gbxDatosCliente.Controls.Add(Me.chkExonerado)
        Me.gbxDatosCliente.Controls.Add(Me.txtDireccion)
        Me.gbxDatosCliente.Controls.Add(Me.lblDireccion)
        Me.gbxDatosCliente.Controls.Add(Me.txtEmails)
        Me.gbxDatosCliente.Controls.Add(Me.lblEmails)
        Me.gbxDatosCliente.Controls.Add(Me.txtTelefonos)
        Me.gbxDatosCliente.Controls.Add(Me.lblTelefonos)
        Me.gbxDatosCliente.Location = New System.Drawing.Point(4, 1)
        Me.gbxDatosCliente.Name = "gbxDatosCliente"
        Me.gbxDatosCliente.Size = New System.Drawing.Size(818, 118)
        Me.gbxDatosCliente.TabIndex = 75
        Me.gbxDatosCliente.TabStop = False
        '
        'gbxDatosExpCxC
        '
        Me.gbxDatosExpCxC.Controls.Add(Me.grdDatosExpediente)
        Me.gbxDatosExpCxC.Location = New System.Drawing.Point(470, 19)
        Me.gbxDatosExpCxC.Name = "gbxDatosExpCxC"
        Me.gbxDatosExpCxC.Size = New System.Drawing.Size(340, 93)
        Me.gbxDatosExpCxC.TabIndex = 96
        Me.gbxDatosExpCxC.TabStop = False
        Me.gbxDatosExpCxC.Text = "Datos Expediente CxC"
        '
        'grdDatosExpediente
        '
        Me.grdDatosExpediente.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDatosExpediente.Images.Add(CType(resources.GetObject("grdDatosExpediente.Images"), System.Drawing.Image))
        Me.grdDatosExpediente.Location = New System.Drawing.Point(6, 19)
        Me.grdDatosExpediente.Name = "grdDatosExpediente"
        Me.grdDatosExpediente.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDatosExpediente.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDatosExpediente.PreviewInfo.ZoomFactor = 75
        Me.grdDatosExpediente.PrintInfo.PageSettings = CType(resources.GetObject("grdDatosExpediente.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDatosExpediente.Size = New System.Drawing.Size(328, 68)
        Me.grdDatosExpediente.TabIndex = 0
        Me.grdDatosExpediente.Text = "C1TrueDBGrid1"
        Me.grdDatosExpediente.PropBag = resources.GetString("grdDatosExpediente.PropBag")
        '
        'chkExonerado
        '
        Me.chkExonerado.AutoSize = True
        Me.chkExonerado.Enabled = False
        Me.chkExonerado.Location = New System.Drawing.Point(359, 21)
        Me.chkExonerado.Name = "chkExonerado"
        Me.chkExonerado.Size = New System.Drawing.Size(77, 17)
        Me.chkExonerado.TabIndex = 95
        Me.chkExonerado.Tag = "BLOQUEADO"
        Me.chkExonerado.Text = "Exonerado"
        Me.chkExonerado.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.AcceptsTab = True
        Me.txtDireccion.Location = New System.Drawing.Point(76, 76)
        Me.txtDireccion.MaxLength = 250
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(364, 36)
        Me.txtDireccion.TabIndex = 94
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Location = New System.Drawing.Point(13, 84)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 22
        Me.lblDireccion.Tag = ""
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtEmails
        '
        Me.txtEmails.Location = New System.Drawing.Point(76, 50)
        Me.txtEmails.Name = "txtEmails"
        Me.txtEmails.Size = New System.Drawing.Size(212, 20)
        Me.txtEmails.TabIndex = 21
        Me.txtEmails.TabStop = False
        Me.txtEmails.Tag = "BLOQUEADO"
        '
        'lblEmails
        '
        Me.lblEmails.AutoSize = True
        Me.lblEmails.BackColor = System.Drawing.Color.Transparent
        Me.lblEmails.Location = New System.Drawing.Point(13, 53)
        Me.lblEmails.Name = "lblEmails"
        Me.lblEmails.Size = New System.Drawing.Size(35, 13)
        Me.lblEmails.TabIndex = 20
        Me.lblEmails.Tag = ""
        Me.lblEmails.Text = "Email:"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.Location = New System.Drawing.Point(76, 19)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(212, 20)
        Me.txtTelefonos.TabIndex = 0
        Me.txtTelefonos.TabStop = False
        Me.txtTelefonos.Tag = "BLOQUEADO"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefonos.Location = New System.Drawing.Point(13, 22)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(57, 13)
        Me.lblTelefonos.TabIndex = 19
        Me.lblTelefonos.Tag = ""
        Me.lblTelefonos.Text = "Teléfonos:"
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.BackColor = System.Drawing.SystemColors.Control
        Me.lblExistencia.Location = New System.Drawing.Point(14, 501)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(58, 13)
        Me.lblExistencia.TabIndex = 104
        Me.lblExistencia.Tag = ""
        Me.lblExistencia.Text = "Existencia:"
        '
        'lblTasaCambio
        '
        Me.lblTasaCambio.AutoSize = True
        Me.lblTasaCambio.BackColor = System.Drawing.SystemColors.Control
        Me.lblTasaCambio.Location = New System.Drawing.Point(215, 501)
        Me.lblTasaCambio.Name = "lblTasaCambio"
        Me.lblTasaCambio.Size = New System.Drawing.Size(29, 13)
        Me.lblTasaCambio.TabIndex = 106
        Me.lblTasaCambio.Tag = ""
        Me.lblTasaCambio.Text = "T/C:"
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescuento.Location = New System.Drawing.Point(674, 530)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(62, 13)
        Me.lblDescuento.TabIndex = 108
        Me.lblDescuento.Tag = ""
        Me.lblDescuento.Text = "Descuento:"
        '
        'NumDescuento
        '
        Me.NumDescuento.DisplayFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumDescuento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumDescuento.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumDescuento.EditFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumDescuento.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumDescuento.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumDescuento.Enabled = False
        Me.NumDescuento.Location = New System.Drawing.Point(736, 527)
        Me.NumDescuento.Name = "NumDescuento"
        Me.NumDescuento.Size = New System.Drawing.Size(107, 20)
        Me.NumDescuento.TabIndex = 109
        Me.NumDescuento.Tag = "BLOQUEADO"
        Me.NumDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumDescuento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumDescuento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.BackColor = System.Drawing.SystemColors.Control
        Me.lblIVA.Location = New System.Drawing.Point(673, 561)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(27, 13)
        Me.lblIVA.TabIndex = 110
        Me.lblIVA.Tag = ""
        Me.lblIVA.Text = "IVA:"
        '
        'NumIVA
        '
        Me.NumIVA.DisplayFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumIVA.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumIVA.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumIVA.EditFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumIVA.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumIVA.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumIVA.Enabled = False
        Me.NumIVA.Location = New System.Drawing.Point(736, 558)
        Me.NumIVA.Name = "NumIVA"
        Me.NumIVA.Size = New System.Drawing.Size(107, 20)
        Me.NumIVA.TabIndex = 111
        Me.NumIVA.Tag = "BLOQUEADO"
        Me.NumIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumIVA.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumIVA.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblTotalCordobas
        '
        Me.lblTotalCordobas.AutoSize = True
        Me.lblTotalCordobas.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalCordobas.Location = New System.Drawing.Point(673, 589)
        Me.lblTotalCordobas.Name = "lblTotalCordobas"
        Me.lblTotalCordobas.Size = New System.Drawing.Size(50, 13)
        Me.lblTotalCordobas.TabIndex = 112
        Me.lblTotalCordobas.Tag = ""
        Me.lblTotalCordobas.Text = "Total C$:"
        '
        'NumTotalCordobas
        '
        Me.NumTotalCordobas.DisplayFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumTotalCordobas.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumTotalCordobas.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumTotalCordobas.EditFormat.CustomFormat = "C$ #,##0.#0"
        Me.NumTotalCordobas.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumTotalCordobas.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumTotalCordobas.Enabled = False
        Me.NumTotalCordobas.Location = New System.Drawing.Point(736, 586)
        Me.NumTotalCordobas.Name = "NumTotalCordobas"
        Me.NumTotalCordobas.Size = New System.Drawing.Size(107, 20)
        Me.NumTotalCordobas.TabIndex = 113
        Me.NumTotalCordobas.Tag = "BLOQUEADO"
        Me.NumTotalCordobas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumTotalCordobas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumTotalCordobas.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblTotalDolares
        '
        Me.lblTotalDolares.AutoSize = True
        Me.lblTotalDolares.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalDolares.Location = New System.Drawing.Point(674, 619)
        Me.lblTotalDolares.Name = "lblTotalDolares"
        Me.lblTotalDolares.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalDolares.TabIndex = 114
        Me.lblTotalDolares.Tag = ""
        Me.lblTotalDolares.Text = "Total US$:"
        '
        'NumTotalDolares
        '
        Me.NumTotalDolares.DisplayFormat.CustomFormat = "$ #,##0.#0"
        Me.NumTotalDolares.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumTotalDolares.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumTotalDolares.EditFormat.CustomFormat = "$ #,##0.#0"
        Me.NumTotalDolares.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumTotalDolares.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumTotalDolares.Enabled = False
        Me.NumTotalDolares.Location = New System.Drawing.Point(736, 616)
        Me.NumTotalDolares.Name = "NumTotalDolares"
        Me.NumTotalDolares.Size = New System.Drawing.Size(107, 20)
        Me.NumTotalDolares.TabIndex = 115
        Me.NumTotalDolares.Tag = "BLOQUEADO"
        Me.NumTotalDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumTotalDolares.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumTotalDolares.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'NumExistencia
        '
        Me.NumExistencia.DisplayFormat.CustomFormat = "#0"
        Me.NumExistencia.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.NumExistencia.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumExistencia.EditFormat.CustomFormat = "#0"
        Me.NumExistencia.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.NumExistencia.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumExistencia.Enabled = False
        Me.NumExistencia.Location = New System.Drawing.Point(78, 498)
        Me.NumExistencia.Name = "NumExistencia"
        Me.NumExistencia.Size = New System.Drawing.Size(107, 20)
        Me.NumExistencia.TabIndex = 116
        Me.NumExistencia.Tag = "BLOQUEADO"
        Me.NumExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumExistencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumExistencia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'NumTasaCambio
        '
        Me.NumTasaCambio.DisplayFormat.CustomFormat = "#0.#0"
        Me.NumTasaCambio.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumTasaCambio.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumTasaCambio.EditFormat.CustomFormat = "#0.#0"
        Me.NumTasaCambio.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumTasaCambio.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumTasaCambio.Enabled = False
        Me.NumTasaCambio.Location = New System.Drawing.Point(250, 498)
        Me.NumTasaCambio.Name = "NumTasaCambio"
        Me.NumTasaCambio.Size = New System.Drawing.Size(107, 20)
        Me.NumTasaCambio.TabIndex = 117
        Me.NumTasaCambio.Tag = "BLOQUEADO"
        Me.NumTasaCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumTasaCambio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumTasaCambio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'frmSfaCotizacionAnular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 691)
        Me.Controls.Add(Me.NumTasaCambio)
        Me.Controls.Add(Me.NumExistencia)
        Me.Controls.Add(Me.NumTotalDolares)
        Me.Controls.Add(Me.lblTotalDolares)
        Me.Controls.Add(Me.NumTotalCordobas)
        Me.Controls.Add(Me.lblTotalCordobas)
        Me.Controls.Add(Me.NumIVA)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.NumDescuento)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblTasaCambio)
        Me.Controls.Add(Me.lblExistencia)
        Me.Controls.Add(Me.tbCotizacion)
        Me.Controls.Add(Me.NumSubTotal)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.lblComentarios)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaCotizacionAnular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anular/Consultar Cotización"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        CType(Me.grdDetalleCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCotizacion.ResumeLayout(False)
        Me.TPDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumValido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTerminoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTiempoEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDatosCliente.ResumeLayout(False)
        Me.gbxDatosCliente.ResumeLayout(False)
        Me.gbxDatosCliente.PerformLayout()
        Me.gbxDatosExpCxC.ResumeLayout(False)
        CType(Me.grdDatosExpediente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTotalCordobas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTotalDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTasaCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents lblComentarios As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalleCotizacion As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents NumSubTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents tbCotizacion As System.Windows.Forms.TabControl
    Friend WithEvents TPDatosGenerales As System.Windows.Forms.TabPage
    Friend WithEvents TPDatosCliente As System.Windows.Forms.TabPage
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTerminoPago As C1.Win.C1List.C1Combo
    Friend WithEvents lblTerminoPago As System.Windows.Forms.Label
    Friend WithEvents cmbTiempoEntrega As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCliente As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSucursal As C1.Win.C1List.C1Combo
    Friend WithEvents lblTiempoEntrega As System.Windows.Forms.Label
    Friend WithEvents lblFechaCotizacion As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCotizacion As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtNumeroCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents lblNoCotizacion As System.Windows.Forms.Label
    Friend WithEvents lblValido As System.Windows.Forms.Label
    Friend WithEvents txtAtencionA As System.Windows.Forms.TextBox
    Friend WithEvents lblAtencionA As System.Windows.Forms.Label
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents gbxDatosCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefonos As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonos As System.Windows.Forms.Label
    Friend WithEvents txtEmails As System.Windows.Forms.TextBox
    Friend WithEvents lblEmails As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents chkExonerado As System.Windows.Forms.CheckBox
    Friend WithEvents gbxDatosExpCxC As System.Windows.Forms.GroupBox
    Friend WithEvents grdDatosExpediente As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents lblTasaCambio As System.Windows.Forms.Label
    Friend WithEvents lblIVA As System.Windows.Forms.Label
    Friend WithEvents NumDescuento As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents NumIVA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents NumTotalCordobas As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblTotalCordobas As System.Windows.Forms.Label
    Friend WithEvents NumTotalDolares As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblTotalDolares As System.Windows.Forms.Label
    Friend WithEvents NumTasaCambio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents NumExistencia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNumCliente As System.Windows.Forms.TextBox
    Friend WithEvents NumValido As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmdConsultarCliente As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents cmbVendedor As C1.Win.C1List.C1Combo
    Friend WithEvents txtComentariosAnulacion As System.Windows.Forms.TextBox
    Friend WithEvents lblComentariosAnulacion As System.Windows.Forms.Label
End Class
