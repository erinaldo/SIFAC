<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivProveedorEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivProveedorEdit))
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style21 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style22 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style23 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style24 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Me.gbxDatosPersonales = New System.Windows.Forms.GroupBox
        Me.lblPlazoCredito = New System.Windows.Forms.Label
        Me.cmbTerminoPago = New C1.Win.C1List.C1Combo
        Me.lblTerminoPago = New System.Windows.Forms.Label
        Me.imgProveedor = New System.Windows.Forms.PictureBox
        Me.cmdBuscarProv = New System.Windows.Forms.Button
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdNuevoProv = New System.Windows.Forms.Button
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.lblNacionalidad = New System.Windows.Forms.Label
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.lblCedulaRUC = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.lblFechaIngreso = New System.Windows.Forms.Label
        Me.lblNombreCompleto = New System.Windows.Forms.Label
        Me.dtpFechaEgreso = New C1.Win.C1Input.C1DateEdit
        Me.lblFechaEgreso = New System.Windows.Forms.Label
        Me.dtpFechaIngreso = New C1.Win.C1Input.C1DateEdit
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtNacionalidad = New System.Windows.Forms.TextBox
        Me.txtCedulaRUC = New System.Windows.Forms.TextBox
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox
        Me.txtIdProveedor = New System.Windows.Forms.TextBox
        Me.lblIdProveedor = New System.Windows.Forms.Label
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblInfo = New System.Windows.Forms.Label
        Me.TabProveedor = New System.Windows.Forms.TabControl
        Me.tbpContacto = New System.Windows.Forms.TabPage
        Me.grdContactoPrincipal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpTipoProvision = New System.Windows.Forms.TabPage
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.cmbProveedorProvision = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.grdTipoProvision = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.mnuProvision = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEliminarProvision = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdBuscarContacto = New System.Windows.Forms.Button
        Me.cmdEditarContactoPrincipal = New System.Windows.Forms.Button
        Me.ttBotones = New System.Windows.Forms.ToolTip(Me.components)
        Me.numPlazoCredito = New DevExpress.XtraEditors.SpinEdit
        Me.gbxDatosPersonales.SuspendLayout()
        CType(Me.cmbTerminoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabProveedor.SuspendLayout()
        Me.tbpContacto.SuspendLayout()
        CType(Me.grdContactoPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpTipoProvision.SuspendLayout()
        CType(Me.cmbProveedorProvision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTipoProvision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuProvision.SuspendLayout()
        CType(Me.numPlazoCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDatosPersonales
        '
        Me.gbxDatosPersonales.Controls.Add(Me.numPlazoCredito)
        Me.gbxDatosPersonales.Controls.Add(Me.lblPlazoCredito)
        Me.gbxDatosPersonales.Controls.Add(Me.cmbTerminoPago)
        Me.gbxDatosPersonales.Controls.Add(Me.lblTerminoPago)
        Me.gbxDatosPersonales.Controls.Add(Me.imgProveedor)
        Me.gbxDatosPersonales.Controls.Add(Me.cmdBuscarProv)
        Me.gbxDatosPersonales.Controls.Add(Me.cmdNuevoProv)
        Me.gbxDatosPersonales.Controls.Add(Me.chkActivo)
        Me.gbxDatosPersonales.Controls.Add(Me.txtDireccion)
        Me.gbxDatosPersonales.Controls.Add(Me.lblNacionalidad)
        Me.gbxDatosPersonales.Controls.Add(Me.lblTelefono)
        Me.gbxDatosPersonales.Controls.Add(Me.lblCedulaRUC)
        Me.gbxDatosPersonales.Controls.Add(Me.lblDireccion)
        Me.gbxDatosPersonales.Controls.Add(Me.lblFechaIngreso)
        Me.gbxDatosPersonales.Controls.Add(Me.lblNombreCompleto)
        Me.gbxDatosPersonales.Controls.Add(Me.dtpFechaEgreso)
        Me.gbxDatosPersonales.Controls.Add(Me.dtpFechaIngreso)
        Me.gbxDatosPersonales.Controls.Add(Me.lblFechaEgreso)
        Me.gbxDatosPersonales.Controls.Add(Me.txtTelefono)
        Me.gbxDatosPersonales.Controls.Add(Me.txtNacionalidad)
        Me.gbxDatosPersonales.Controls.Add(Me.txtCedulaRUC)
        Me.gbxDatosPersonales.Controls.Add(Me.txtNombreCompleto)
        Me.gbxDatosPersonales.Controls.Add(Me.txtIdProveedor)
        Me.gbxDatosPersonales.Controls.Add(Me.lblIdProveedor)
        Me.gbxDatosPersonales.Location = New System.Drawing.Point(10, 38)
        Me.gbxDatosPersonales.Name = "gbxDatosPersonales"
        Me.gbxDatosPersonales.Size = New System.Drawing.Size(685, 257)
        Me.gbxDatosPersonales.TabIndex = 1
        Me.gbxDatosPersonales.TabStop = False
        Me.gbxDatosPersonales.Text = "Datos personales"
        '
        'lblPlazoCredito
        '
        Me.lblPlazoCredito.AutoSize = True
        Me.lblPlazoCredito.BackColor = System.Drawing.SystemColors.Control
        Me.lblPlazoCredito.Location = New System.Drawing.Point(299, 80)
        Me.lblPlazoCredito.Name = "lblPlazoCredito"
        Me.lblPlazoCredito.Size = New System.Drawing.Size(104, 13)
        Me.lblPlazoCredito.TabIndex = 101
        Me.lblPlazoCredito.Tag = ""
        Me.lblPlazoCredito.Text = "Plazo Crédito (Días):"
        '
        'cmbTerminoPago
        '
        Me.cmbTerminoPago.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTerminoPago.AllowColMove = False
        Me.cmbTerminoPago.AllowSort = False
        Me.cmbTerminoPago.Caption = ""
        Me.cmbTerminoPago.CaptionHeight = 17
        Me.cmbTerminoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTerminoPago.ColumnCaptionHeight = 17
        Me.cmbTerminoPago.ColumnFooterHeight = 17
        Me.cmbTerminoPago.ColumnHeaders = False
        Me.cmbTerminoPago.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTerminoPago.ContentHeight = 15
        Me.cmbTerminoPago.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTerminoPago.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTerminoPago.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTerminoPago.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTerminoPago.EditorHeight = 15
        Me.cmbTerminoPago.Images.Add(CType(resources.GetObject("cmbTerminoPago.Images"), System.Drawing.Image))
        Me.cmbTerminoPago.ItemHeight = 15
        Me.cmbTerminoPago.Location = New System.Drawing.Point(121, 80)
        Me.cmbTerminoPago.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTerminoPago.MaxDropDownItems = CType(5, Short)
        Me.cmbTerminoPago.MaxLength = 32767
        Me.cmbTerminoPago.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTerminoPago.Name = "cmbTerminoPago"
        Me.cmbTerminoPago.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTerminoPago.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTerminoPago.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTerminoPago.Size = New System.Drawing.Size(123, 21)
        Me.cmbTerminoPago.TabIndex = 100
        Me.cmbTerminoPago.PropBag = resources.GetString("cmbTerminoPago.PropBag")
        '
        'lblTerminoPago
        '
        Me.lblTerminoPago.AutoSize = True
        Me.lblTerminoPago.BackColor = System.Drawing.SystemColors.Control
        Me.lblTerminoPago.Location = New System.Drawing.Point(15, 80)
        Me.lblTerminoPago.Name = "lblTerminoPago"
        Me.lblTerminoPago.Size = New System.Drawing.Size(76, 13)
        Me.lblTerminoPago.TabIndex = 99
        Me.lblTerminoPago.Tag = ""
        Me.lblTerminoPago.Text = "Término Pago:"
        '
        'imgProveedor
        '
        Me.imgProveedor.BackgroundImage = Global.SIFAC.My.Resources.Resources.ProveedorEstilo1
        Me.imgProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgProveedor.Location = New System.Drawing.Point(545, 17)
        Me.imgProveedor.Name = "imgProveedor"
        Me.imgProveedor.Size = New System.Drawing.Size(133, 154)
        Me.imgProveedor.TabIndex = 98
        Me.imgProveedor.TabStop = False
        '
        'cmdBuscarProv
        '
        Me.cmdBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBuscarProv.ImageIndex = 1
        Me.cmdBuscarProv.ImageList = Me.imgIconos
        Me.cmdBuscarProv.Location = New System.Drawing.Point(290, 17)
        Me.cmdBuscarProv.Name = "cmdBuscarProv"
        Me.cmdBuscarProv.Size = New System.Drawing.Size(29, 25)
        Me.cmdBuscarProv.TabIndex = 3
        Me.cmdBuscarProv.UseVisualStyleBackColor = True
        '
        'imgIconos
        '
        Me.imgIconos.ImageStream = CType(resources.GetObject("imgIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIconos.Images.SetKeyName(0, "Usuario.gif")
        Me.imgIconos.Images.SetKeyName(1, "Buscar.png")
        '
        'cmdNuevoProv
        '
        Me.cmdNuevoProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNuevoProv.ImageIndex = 0
        Me.cmdNuevoProv.ImageList = Me.imgIconos
        Me.cmdNuevoProv.Location = New System.Drawing.Point(253, 17)
        Me.cmdNuevoProv.Name = "cmdNuevoProv"
        Me.cmdNuevoProv.Size = New System.Drawing.Size(30, 25)
        Me.cmdNuevoProv.TabIndex = 2
        Me.cmdNuevoProv.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(470, 23)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 96
        Me.chkActivo.Tag = "BLOQUEADO"
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.AcceptsTab = True
        Me.txtDireccion.Location = New System.Drawing.Point(121, 138)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(411, 55)
        Me.txtDireccion.TabIndex = 93
        Me.txtDireccion.TabStop = False
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(294, 208)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblNacionalidad.TabIndex = 92
        Me.lblNacionalidad.Tag = ""
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.SystemColors.Control
        Me.lblTelefono.Location = New System.Drawing.Point(15, 236)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 92
        Me.lblTelefono.Tag = ""
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblCedulaRUC
        '
        Me.lblCedulaRUC.AutoSize = True
        Me.lblCedulaRUC.BackColor = System.Drawing.SystemColors.Control
        Me.lblCedulaRUC.Location = New System.Drawing.Point(15, 207)
        Me.lblCedulaRUC.Name = "lblCedulaRUC"
        Me.lblCedulaRUC.Size = New System.Drawing.Size(77, 13)
        Me.lblCedulaRUC.TabIndex = 92
        Me.lblCedulaRUC.Tag = ""
        Me.lblCedulaRUC.Text = "Cédula / RUC:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.SystemColors.Control
        Me.lblDireccion.Location = New System.Drawing.Point(15, 146)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 92
        Me.lblDireccion.Tag = ""
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaIngreso.Location = New System.Drawing.Point(15, 52)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaIngreso.TabIndex = 88
        Me.lblFechaIngreso.Tag = ""
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombreCompleto.Location = New System.Drawing.Point(15, 108)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(102, 28)
        Me.lblNombreCompleto.TabIndex = 86
        Me.lblNombreCompleto.Tag = ""
        Me.lblNombreCompleto.Text = "Nombre completo / Razón Social:"
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaEgreso.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaEgreso.EditMask = "##/##/####"
        Me.dtpFechaEgreso.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEgreso.Label = Me.lblFechaEgreso
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(409, 52)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(123, 18)
        Me.dtpFechaEgreso.TabIndex = 1
        Me.dtpFechaEgreso.Tag = Nothing
        Me.dtpFechaEgreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaEgreso
        '
        Me.lblFechaEgreso.AutoSize = True
        Me.lblFechaEgreso.Location = New System.Drawing.Point(299, 52)
        Me.lblFechaEgreso.Name = "lblFechaEgreso"
        Me.lblFechaEgreso.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaEgreso.TabIndex = 42
        Me.lblFechaEgreso.Tag = "OBLIGATORIO"
        Me.lblFechaEgreso.Text = "Fecha Egreso:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaIngreso.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaIngreso.EditMask = "##/##/####"
        Me.dtpFechaIngreso.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(121, 52)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(123, 18)
        Me.dtpFechaIngreso.TabIndex = 0
        Me.dtpFechaIngreso.Tag = Nothing
        Me.dtpFechaIngreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(121, 231)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(157, 20)
        Me.txtTelefono.TabIndex = 0
        Me.txtTelefono.TabStop = False
        Me.txtTelefono.Tag = "BLOQUEADO"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(375, 202)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(157, 20)
        Me.txtNacionalidad.TabIndex = 0
        Me.txtNacionalidad.TabStop = False
        Me.txtNacionalidad.Tag = "BLOQUEADO"
        '
        'txtCedulaRUC
        '
        Me.txtCedulaRUC.Location = New System.Drawing.Point(121, 202)
        Me.txtCedulaRUC.Name = "txtCedulaRUC"
        Me.txtCedulaRUC.Size = New System.Drawing.Size(157, 20)
        Me.txtCedulaRUC.TabIndex = 0
        Me.txtCedulaRUC.TabStop = False
        Me.txtCedulaRUC.Tag = "BLOQUEADO"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Location = New System.Drawing.Point(121, 111)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(411, 20)
        Me.txtNombreCompleto.TabIndex = 0
        Me.txtNombreCompleto.TabStop = False
        Me.txtNombreCompleto.Tag = "BLOQUEADO"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Location = New System.Drawing.Point(121, 19)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(126, 20)
        Me.txtIdProveedor.TabIndex = 0
        Me.txtIdProveedor.TabStop = False
        Me.txtIdProveedor.Tag = "BLOQUEADO"
        Me.txtIdProveedor.Text = "(Automático)"
        '
        'lblIdProveedor
        '
        Me.lblIdProveedor.AutoSize = True
        Me.lblIdProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdProveedor.Location = New System.Drawing.Point(15, 24)
        Me.lblIdProveedor.Name = "lblIdProveedor"
        Me.lblIdProveedor.Size = New System.Drawing.Size(71, 13)
        Me.lblIdProveedor.TabIndex = 19
        Me.lblIdProveedor.Tag = ""
        Me.lblIdProveedor.Text = "Id Proveedor:"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(630, -1)
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
        Me.Panel2.Size = New System.Drawing.Size(701, 32)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Tag = "LAYOUT"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(579, 409)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(578, 369)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 479)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 22)
        Me.Panel1.TabIndex = 11
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(31, 123)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(212, 11)
        Me.lblInfo.TabIndex = 71
        Me.lblInfo.Tag = ""
        '
        'TabProveedor
        '
        Me.TabProveedor.Controls.Add(Me.tbpContacto)
        Me.TabProveedor.Controls.Add(Me.tbpTipoProvision)
        Me.TabProveedor.Location = New System.Drawing.Point(10, 310)
        Me.TabProveedor.Name = "TabProveedor"
        Me.TabProveedor.SelectedIndex = 0
        Me.TabProveedor.Size = New System.Drawing.Size(530, 163)
        Me.TabProveedor.TabIndex = 72
        '
        'tbpContacto
        '
        Me.tbpContacto.Controls.Add(Me.grdContactoPrincipal)
        Me.tbpContacto.Location = New System.Drawing.Point(4, 22)
        Me.tbpContacto.Name = "tbpContacto"
        Me.tbpContacto.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpContacto.Size = New System.Drawing.Size(522, 137)
        Me.tbpContacto.TabIndex = 0
        Me.tbpContacto.Text = "Contacto Principal"
        Me.tbpContacto.UseVisualStyleBackColor = True
        '
        'grdContactoPrincipal
        '
        Me.grdContactoPrincipal.AllowColMove = False
        Me.grdContactoPrincipal.AllowColSelect = False
        Me.grdContactoPrincipal.AllowRowSelect = False
        Me.grdContactoPrincipal.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.grdContactoPrincipal.AllowUpdate = False
        Me.grdContactoPrincipal.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.grdContactoPrincipal.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdContactoPrincipal.Images.Add(CType(resources.GetObject("grdContactoPrincipal.Images"), System.Drawing.Image))
        Me.grdContactoPrincipal.Location = New System.Drawing.Point(2, 7)
        Me.grdContactoPrincipal.Name = "grdContactoPrincipal"
        Me.grdContactoPrincipal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdContactoPrincipal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdContactoPrincipal.PreviewInfo.ZoomFactor = 75
        Me.grdContactoPrincipal.PrintInfo.PageSettings = CType(resources.GetObject("grdContactoPrincipal.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdContactoPrincipal.RecordSelectors = False
        Me.grdContactoPrincipal.Size = New System.Drawing.Size(510, 113)
        Me.grdContactoPrincipal.TabIndex = 0
        Me.grdContactoPrincipal.Text = "C1TrueDBGrid1"
        Me.grdContactoPrincipal.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdContactoPrincipal.PropBag = resources.GetString("grdContactoPrincipal.PropBag")
        '
        'tbpTipoProvision
        '
        Me.tbpTipoProvision.Controls.Add(Me.lblMensaje)
        Me.tbpTipoProvision.Controls.Add(Me.cmbProveedorProvision)
        Me.tbpTipoProvision.Controls.Add(Me.grdTipoProvision)
        Me.tbpTipoProvision.Controls.Add(Me.lblInfo)
        Me.tbpTipoProvision.Location = New System.Drawing.Point(4, 22)
        Me.tbpTipoProvision.Name = "tbpTipoProvision"
        Me.tbpTipoProvision.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTipoProvision.Size = New System.Drawing.Size(522, 137)
        Me.tbpTipoProvision.TabIndex = 1
        Me.tbpTipoProvision.Text = "Tipo Provisión"
        Me.tbpTipoProvision.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.ForeColor = System.Drawing.Color.Silver
        Me.lblMensaje.Location = New System.Drawing.Point(7, 121)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(183, 13)
        Me.lblMensaje.TabIndex = 3
        Me.lblMensaje.Text = "Para eliminar presione DEL o Suprimir"
        '
        'cmbProveedorProvision
        '
        Me.cmbProveedorProvision.AllowColMove = True
        Me.cmbProveedorProvision.AllowColSelect = True
        Me.cmbProveedorProvision.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cmbProveedorProvision.AlternatingRows = False
        Me.cmbProveedorProvision.CaptionStyle = Style17
        Me.cmbProveedorProvision.ColumnCaptionHeight = 17
        Me.cmbProveedorProvision.ColumnFooterHeight = 17
        Me.cmbProveedorProvision.EvenRowStyle = Style18
        Me.cmbProveedorProvision.FetchRowStyles = False
        Me.cmbProveedorProvision.FooterStyle = Style19
        Me.cmbProveedorProvision.HeadingStyle = Style20
        Me.cmbProveedorProvision.HighLightRowStyle = Style21
        Me.cmbProveedorProvision.Images.Add(CType(resources.GetObject("cmbProveedorProvision.Images"), System.Drawing.Image))
        Me.cmbProveedorProvision.Location = New System.Drawing.Point(6, 25)
        Me.cmbProveedorProvision.Name = "cmbProveedorProvision"
        Me.cmbProveedorProvision.OddRowStyle = Style22
        Me.cmbProveedorProvision.RecordSelectorStyle = Style23
        Me.cmbProveedorProvision.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedorProvision.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cmbProveedorProvision.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedorProvision.ScrollTips = False
        Me.cmbProveedorProvision.Size = New System.Drawing.Size(362, 76)
        Me.cmbProveedorProvision.Style = Style24
        Me.cmbProveedorProvision.TabIndex = 2
        Me.cmbProveedorProvision.TabStop = False
        Me.cmbProveedorProvision.Visible = False
        Me.cmbProveedorProvision.PropBag = resources.GetString("cmbProveedorProvision.PropBag")
        '
        'grdTipoProvision
        '
        Me.grdTipoProvision.AllowAddNew = True
        Me.grdTipoProvision.AllowDelete = True
        Me.grdTipoProvision.ContextMenuStrip = Me.mnuProvision
        Me.grdTipoProvision.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.grdTipoProvision.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdTipoProvision.Images.Add(CType(resources.GetObject("grdTipoProvision.Images"), System.Drawing.Image))
        Me.grdTipoProvision.Location = New System.Drawing.Point(6, 7)
        Me.grdTipoProvision.Name = "grdTipoProvision"
        Me.grdTipoProvision.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTipoProvision.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTipoProvision.PreviewInfo.ZoomFactor = 75
        Me.grdTipoProvision.PrintInfo.PageSettings = CType(resources.GetObject("grdTipoProvision.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTipoProvision.RecordSelectors = False
        Me.grdTipoProvision.Size = New System.Drawing.Size(495, 113)
        Me.grdTipoProvision.TabIndex = 1
        Me.grdTipoProvision.PropBag = resources.GetString("grdTipoProvision.PropBag")
        '
        'mnuProvision
        '
        Me.mnuProvision.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEliminarProvision})
        Me.mnuProvision.Name = "mnuProvision"
        Me.mnuProvision.Size = New System.Drawing.Size(142, 26)
        '
        'mnuEliminarProvision
        '
        Me.mnuEliminarProvision.Image = Global.SIFAC.My.Resources.Resources.Anular
        Me.mnuEliminarProvision.Name = "mnuEliminarProvision"
        Me.mnuEliminarProvision.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mnuEliminarProvision.Size = New System.Drawing.Size(141, 22)
        Me.mnuEliminarProvision.Text = "Elminar"
        '
        'cmdBuscarContacto
        '
        Me.cmdBuscarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBuscarContacto.ImageIndex = 1
        Me.cmdBuscarContacto.ImageList = Me.imgIconos
        Me.cmdBuscarContacto.Location = New System.Drawing.Point(508, 301)
        Me.cmdBuscarContacto.Name = "cmdBuscarContacto"
        Me.cmdBuscarContacto.Size = New System.Drawing.Size(29, 25)
        Me.cmdBuscarContacto.TabIndex = 4
        Me.cmdBuscarContacto.UseVisualStyleBackColor = True
        '
        'cmdEditarContactoPrincipal
        '
        Me.cmdEditarContactoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEditarContactoPrincipal.ImageIndex = 0
        Me.cmdEditarContactoPrincipal.ImageList = Me.imgIconos
        Me.cmdEditarContactoPrincipal.Location = New System.Drawing.Point(472, 300)
        Me.cmdEditarContactoPrincipal.Name = "cmdEditarContactoPrincipal"
        Me.cmdEditarContactoPrincipal.Size = New System.Drawing.Size(30, 25)
        Me.cmdEditarContactoPrincipal.TabIndex = 73
        Me.cmdEditarContactoPrincipal.UseVisualStyleBackColor = True
        '
        'numPlazoCredito
        '
        Me.numPlazoCredito.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numPlazoCredito.Location = New System.Drawing.Point(409, 80)
        Me.numPlazoCredito.Name = "numPlazoCredito"
        Me.numPlazoCredito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.numPlazoCredito.Properties.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numPlazoCredito.Properties.IsFloatValue = False
        Me.numPlazoCredito.Properties.Mask.EditMask = "N00"
        Me.numPlazoCredito.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numPlazoCredito.Properties.UseCtrlIncrement = False
        Me.numPlazoCredito.Size = New System.Drawing.Size(123, 20)
        Me.numPlazoCredito.TabIndex = 103
        '
        'frmSivProveedorEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 501)
        Me.Controls.Add(Me.cmdEditarContactoPrincipal)
        Me.Controls.Add(Me.cmdBuscarContacto)
        Me.Controls.Add(Me.TabProveedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.gbxDatosPersonales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivProveedorEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Proveedor"
        Me.gbxDatosPersonales.ResumeLayout(False)
        Me.gbxDatosPersonales.PerformLayout()
        CType(Me.cmbTerminoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEgreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabProveedor.ResumeLayout(False)
        Me.tbpContacto.ResumeLayout(False)
        CType(Me.grdContactoPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpTipoProvision.ResumeLayout(False)
        Me.tbpTipoProvision.PerformLayout()
        CType(Me.cmbProveedorProvision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTipoProvision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuProvision.ResumeLayout(False)
        CType(Me.numPlazoCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDatosPersonales As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaEgreso As System.Windows.Forms.Label
    Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblNombreCompleto As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIngreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents lblCedulaRUC As System.Windows.Forms.Label
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaRUC As System.Windows.Forms.TextBox
    Friend WithEvents cmdNuevoProv As System.Windows.Forms.Button
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TabProveedor As System.Windows.Forms.TabControl
    Friend WithEvents tbpContacto As System.Windows.Forms.TabPage
    Friend WithEvents tbpTipoProvision As System.Windows.Forms.TabPage
    Friend WithEvents cmdBuscarProv As System.Windows.Forms.Button
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents imgProveedor As System.Windows.Forms.PictureBox
    Friend WithEvents grdContactoPrincipal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdTipoProvision As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdBuscarContacto As System.Windows.Forms.Button
    Friend WithEvents cmbProveedorProvision As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dtpFechaEgreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents mnuProvision As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEliminarProvision As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditarContactoPrincipal As System.Windows.Forms.Button
    Friend WithEvents ttBotones As System.Windows.Forms.ToolTip
    Friend WithEvents lblTerminoPago As System.Windows.Forms.Label
    Friend WithEvents cmbTerminoPago As C1.Win.C1List.C1Combo
    Friend WithEvents lblPlazoCredito As System.Windows.Forms.Label
    Friend WithEvents numPlazoCredito As DevExpress.XtraEditors.SpinEdit
End Class
