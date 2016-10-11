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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivProveedorEdit))
        Me.gbxDatosJuridico = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCiudad = New C1.Win.C1List.C1Combo()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblCedulaRUC = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New C1.Win.C1Input.C1DateEdit()
        Me.txtCedulaRUC = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.cmdBuscarProv = New System.Windows.Forms.Button()
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.lblIdProveedor = New System.Windows.Forms.Label()
        Me.imgProveedor = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabProveedor = New System.Windows.Forms.TabControl()
        Me.tbpContacto = New System.Windows.Forms.TabPage()
        Me.grdContactoPrincipal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.mnuProvision = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEliminarProvision = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdBuscarContacto = New System.Windows.Forms.Button()
        Me.cmdEditarContactoPrincipal = New System.Windows.Forms.Button()
        Me.ttBotones = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.chkJuridico = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabAdicionales = New System.Windows.Forms.TabControl()
        Me.tabContactos = New System.Windows.Forms.TabPage()
        Me.tdbContactos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.barContactos = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarContacto = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminarContacto = New System.Windows.Forms.ToolStripButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.grbDatosNatural = New System.Windows.Forms.GroupBox()
        Me.dtpFechaNacimiento = New DevExpress.XtraEditors.DateEdit()
        Me.txtdireccionNatural = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCiudadNatural = New C1.Win.C1List.C1Combo()
        Me.cmbGenero = New C1.Win.C1List.C1Combo()
        Me.txtCedula = New System.Windows.Forms.MaskedTextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblNombre1 = New System.Windows.Forms.Label()
        Me.gbxDatosJuridico.SuspendLayout()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProveedor.SuspendLayout()
        Me.tbpContacto.SuspendLayout()
        CType(Me.grdContactoPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuProvision.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabAdicionales.SuspendLayout()
        Me.tabContactos.SuspendLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barContactos.SuspendLayout()
        Me.grbDatosNatural.SuspendLayout()
        CType(Me.dtpFechaNacimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCiudadNatural, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDatosJuridico
        '
        Me.gbxDatosJuridico.Controls.Add(Me.Label1)
        Me.gbxDatosJuridico.Controls.Add(Me.cmbCiudad)
        Me.gbxDatosJuridico.Controls.Add(Me.txtDireccion)
        Me.gbxDatosJuridico.Controls.Add(Me.lblCedulaRUC)
        Me.gbxDatosJuridico.Controls.Add(Me.lblDireccion)
        Me.gbxDatosJuridico.Controls.Add(Me.lblFechaIngreso)
        Me.gbxDatosJuridico.Controls.Add(Me.lblNombreCompleto)
        Me.gbxDatosJuridico.Controls.Add(Me.dtpFechaIngreso)
        Me.gbxDatosJuridico.Controls.Add(Me.txtCedulaRUC)
        Me.gbxDatosJuridico.Controls.Add(Me.txtRazonSocial)
        Me.gbxDatosJuridico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosJuridico.Location = New System.Drawing.Point(11, 59)
        Me.gbxDatosJuridico.Name = "gbxDatosJuridico"
        Me.gbxDatosJuridico.Size = New System.Drawing.Size(575, 200)
        Me.gbxDatosJuridico.TabIndex = 1
        Me.gbxDatosJuridico.TabStop = False
        Me.gbxDatosJuridico.Text = "Datos personales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Ciudad:"
        '
        'cmbCiudad
        '
        Me.cmbCiudad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCiudad.AllowColMove = False
        Me.cmbCiudad.AllowSort = False
        Me.cmbCiudad.Caption = ""
        Me.cmbCiudad.CaptionHeight = 17
        Me.cmbCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCiudad.ColumnCaptionHeight = 17
        Me.cmbCiudad.ColumnFooterHeight = 17
        Me.cmbCiudad.ColumnHeaders = False
        Me.cmbCiudad.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCiudad.ContentHeight = 15
        Me.cmbCiudad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCiudad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCiudad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiudad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCiudad.EditorHeight = 15
        Me.cmbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiudad.Images.Add(CType(resources.GetObject("cmbCiudad.Images"), System.Drawing.Image))
        Me.cmbCiudad.ItemHeight = 15
        Me.cmbCiudad.Location = New System.Drawing.Point(142, 109)
        Me.cmbCiudad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCiudad.MaxDropDownItems = CType(5, Short)
        Me.cmbCiudad.MaxLength = 32767
        Me.cmbCiudad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCiudad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCiudad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCiudad.Size = New System.Drawing.Size(186, 21)
        Me.cmbCiudad.TabIndex = 100
        Me.cmbCiudad.Tag = "OBLIGATORIO"
        Me.cmbCiudad.PropBag = resources.GetString("cmbCiudad.PropBag")
        '
        'txtDireccion
        '
        Me.txtDireccion.AcceptsTab = True
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(142, 138)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(411, 55)
        Me.txtDireccion.TabIndex = 93
        Me.txtDireccion.TabStop = False
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'lblCedulaRUC
        '
        Me.lblCedulaRUC.AutoSize = True
        Me.lblCedulaRUC.BackColor = System.Drawing.Color.Transparent
        Me.lblCedulaRUC.Location = New System.Drawing.Point(17, 87)
        Me.lblCedulaRUC.Name = "lblCedulaRUC"
        Me.lblCedulaRUC.Size = New System.Drawing.Size(37, 13)
        Me.lblCedulaRUC.TabIndex = 92
        Me.lblCedulaRUC.Tag = ""
        Me.lblCedulaRUC.Text = "RUC:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Location = New System.Drawing.Point(17, 142)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(65, 13)
        Me.lblDireccion.TabIndex = 92
        Me.lblDireccion.Tag = ""
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaIngreso.Location = New System.Drawing.Point(15, 29)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaIngreso.TabIndex = 88
        Me.lblFechaIngreso.Tag = ""
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCompleto.Location = New System.Drawing.Point(17, 58)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(117, 23)
        Me.lblNombreCompleto.TabIndex = 86
        Me.lblNombreCompleto.Tag = ""
        Me.lblNombreCompleto.Text = "Razón Social:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaIngreso.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaIngreso.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaIngreso.Calendar.ClearText = "&Clear"
        Me.dtpFechaIngreso.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaIngreso.Calendar.SelectedDate = New Date(2016, 8, 25, 0, 0, 0, 0)
        Me.dtpFechaIngreso.Calendar.TodayText = "&Today"
        Me.dtpFechaIngreso.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaIngreso.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaIngreso.EditMask = "##/##/####"
        Me.dtpFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIngreso.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(140, 29)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(123, 18)
        Me.dtpFechaIngreso.TabIndex = 0
        Me.dtpFechaIngreso.Tag = Nothing
        Me.dtpFechaIngreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtCedulaRUC
        '
        Me.txtCedulaRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaRUC.Location = New System.Drawing.Point(140, 84)
        Me.txtCedulaRUC.Name = "txtCedulaRUC"
        Me.txtCedulaRUC.Size = New System.Drawing.Size(157, 20)
        Me.txtCedulaRUC.TabIndex = 0
        Me.txtCedulaRUC.TabStop = False
        Me.txtCedulaRUC.Tag = "BLOQUEADO"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(140, 58)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(411, 20)
        Me.txtRazonSocial.TabIndex = 0
        Me.txtRazonSocial.TabStop = False
        Me.txtRazonSocial.Tag = "BLOQUEADO"
        '
        'cmdBuscarProv
        '
        Me.cmdBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBuscarProv.Image = CType(resources.GetObject("cmdBuscarProv.Image"), System.Drawing.Image)
        Me.cmdBuscarProv.Location = New System.Drawing.Point(285, 21)
        Me.cmdBuscarProv.Name = "cmdBuscarProv"
        Me.cmdBuscarProv.Size = New System.Drawing.Size(21, 21)
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
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(530, 26)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 96
        Me.chkActivo.Tag = "BLOQUEADO"
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Enabled = False
        Me.txtIdProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProveedor.Location = New System.Drawing.Point(153, 22)
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
        Me.lblIdProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblIdProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProveedor.Location = New System.Drawing.Point(28, 27)
        Me.lblIdProveedor.Name = "lblIdProveedor"
        Me.lblIdProveedor.Size = New System.Drawing.Size(84, 13)
        Me.lblIdProveedor.TabIndex = 19
        Me.lblIdProveedor.Tag = ""
        Me.lblIdProveedor.Text = "Id Proveedor:"
        '
        'imgProveedor
        '
        Me.imgProveedor.BackgroundImage = Global.SIFAC.My.Resources.Resources.ProveedorEstilo1
        Me.imgProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgProveedor.Location = New System.Drawing.Point(776, 264)
        Me.imgProveedor.Name = "imgProveedor"
        Me.imgProveedor.Size = New System.Drawing.Size(133, 154)
        Me.imgProveedor.TabIndex = 98
        Me.imgProveedor.TabStop = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 448)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1086, 22)
        Me.Panel1.TabIndex = 11
        '
        'TabProveedor
        '
        Me.TabProveedor.Controls.Add(Me.tbpContacto)
        Me.TabProveedor.Location = New System.Drawing.Point(12, 278)
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
        Me.grdContactoPrincipal.PreviewInfo.ZoomFactor = 75.0R
        Me.grdContactoPrincipal.PrintInfo.PageSettings = CType(resources.GetObject("grdContactoPrincipal.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdContactoPrincipal.RecordSelectors = False
        Me.grdContactoPrincipal.Size = New System.Drawing.Size(510, 113)
        Me.grdContactoPrincipal.TabIndex = 0
        Me.grdContactoPrincipal.Text = "C1TrueDBGrid1"
        Me.grdContactoPrincipal.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdContactoPrincipal.PropBag = resources.GetString("grdContactoPrincipal.PropBag")
        '
        'mnuProvision
        '
        Me.mnuProvision.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEliminarProvision})
        Me.mnuProvision.Name = "mnuProvision"
        Me.mnuProvision.Size = New System.Drawing.Size(139, 26)
        '
        'mnuEliminarProvision
        '
        Me.mnuEliminarProvision.Image = Global.SIFAC.My.Resources.Resources.Anular
        Me.mnuEliminarProvision.Name = "mnuEliminarProvision"
        Me.mnuEliminarProvision.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mnuEliminarProvision.Size = New System.Drawing.Size(138, 22)
        Me.mnuEliminarProvision.Text = "Elminar"
        '
        'cmdBuscarContacto
        '
        Me.cmdBuscarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBuscarContacto.Image = CType(resources.GetObject("cmdBuscarContacto.Image"), System.Drawing.Image)
        Me.cmdBuscarContacto.Location = New System.Drawing.Point(508, 265)
        Me.cmdBuscarContacto.Name = "cmdBuscarContacto"
        Me.cmdBuscarContacto.Size = New System.Drawing.Size(21, 21)
        Me.cmdBuscarContacto.TabIndex = 4
        Me.cmdBuscarContacto.UseVisualStyleBackColor = True
        '
        'cmdEditarContactoPrincipal
        '
        Me.cmdEditarContactoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEditarContactoPrincipal.Image = CType(resources.GetObject("cmdEditarContactoPrincipal.Image"), System.Drawing.Image)
        Me.cmdEditarContactoPrincipal.Location = New System.Drawing.Point(482, 264)
        Me.cmdEditarContactoPrincipal.Name = "cmdEditarContactoPrincipal"
        Me.cmdEditarContactoPrincipal.Size = New System.Drawing.Size(21, 21)
        Me.cmdEditarContactoPrincipal.TabIndex = 21
        Me.cmdEditarContactoPrincipal.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.chkJuridico)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.chkActivo)
        Me.PanelControl1.Controls.Add(Me.cmdBuscarProv)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.imgProveedor)
        Me.PanelControl1.Controls.Add(Me.TabProveedor)
        Me.PanelControl1.Controls.Add(Me.txtIdProveedor)
        Me.PanelControl1.Controls.Add(Me.lblIdProveedor)
        Me.PanelControl1.Controls.Add(Me.gbxDatosJuridico)
        Me.PanelControl1.Controls.Add(Me.grbDatosNatural)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1086, 470)
        Me.PanelControl1.TabIndex = 74
        '
        'chkJuridico
        '
        Me.chkJuridico.AutoSize = True
        Me.chkJuridico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkJuridico.Checked = True
        Me.chkJuridico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJuridico.Enabled = False
        Me.chkJuridico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJuridico.Location = New System.Drawing.Point(440, 26)
        Me.chkJuridico.Name = "chkJuridico"
        Me.chkJuridico.Size = New System.Drawing.Size(72, 17)
        Me.chkJuridico.TabIndex = 101
        Me.chkJuridico.Tag = "BLOQUEADO"
        Me.chkJuridico.Text = "Jurídico"
        Me.chkJuridico.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabAdicionales)
        Me.GroupBox1.Location = New System.Drawing.Point(661, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 212)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        '
        'tabAdicionales
        '
        Me.tabAdicionales.Controls.Add(Me.tabContactos)
        Me.tabAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdicionales.Location = New System.Drawing.Point(3, 16)
        Me.tabAdicionales.Name = "tabAdicionales"
        Me.tabAdicionales.SelectedIndex = 0
        Me.tabAdicionales.Size = New System.Drawing.Size(403, 193)
        Me.tabAdicionales.TabIndex = 1
        '
        'tabContactos
        '
        Me.tabContactos.Controls.Add(Me.tdbContactos)
        Me.tabContactos.Controls.Add(Me.barContactos)
        Me.tabContactos.Location = New System.Drawing.Point(4, 22)
        Me.tabContactos.Name = "tabContactos"
        Me.tabContactos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabContactos.Size = New System.Drawing.Size(395, 167)
        Me.tabContactos.TabIndex = 0
        Me.tabContactos.Text = "¿Cómo Contactar?"
        Me.tabContactos.UseVisualStyleBackColor = True
        '
        'tdbContactos
        '
        Me.tdbContactos.AllowArrows = False
        Me.tdbContactos.AllowColMove = False
        Me.tdbContactos.AllowColSelect = False
        Me.tdbContactos.AllowRowSelect = False
        Me.tdbContactos.AllowUpdate = False
        Me.tdbContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbContactos.ExtendRightColumn = True
        Me.tdbContactos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbContactos.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbContactos.Images.Add(CType(resources.GetObject("tdbContactos.Images"), System.Drawing.Image))
        Me.tdbContactos.Location = New System.Drawing.Point(3, 28)
        Me.tdbContactos.Name = "tdbContactos"
        Me.tdbContactos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbContactos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbContactos.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbContactos.PrintInfo.PageSettings = CType(resources.GetObject("tdbContactos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbContactos.Size = New System.Drawing.Size(389, 136)
        Me.tdbContactos.TabIndex = 1
        Me.tdbContactos.Text = "C1TrueDBGrid1"
        Me.tdbContactos.PropBag = resources.GetString("tdbContactos.PropBag")
        '
        'barContactos
        '
        Me.barContactos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarContacto, Me.cmdEliminarContacto})
        Me.barContactos.Location = New System.Drawing.Point(3, 3)
        Me.barContactos.Name = "barContactos"
        Me.barContactos.Size = New System.Drawing.Size(389, 25)
        Me.barContactos.TabIndex = 0
        Me.barContactos.Text = "ToolStrip1"
        '
        'cmdAgregarContacto
        '
        Me.cmdAgregarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarContacto.Image = CType(resources.GetObject("cmdAgregarContacto.Image"), System.Drawing.Image)
        Me.cmdAgregarContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarContacto.Name = "cmdAgregarContacto"
        Me.cmdAgregarContacto.Size = New System.Drawing.Size(23, 22)
        Me.cmdAgregarContacto.Text = "ToolStripButton1"
        Me.cmdAgregarContacto.ToolTipText = "Agregar Contacto"
        '
        'cmdEliminarContacto
        '
        Me.cmdEliminarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminarContacto.Image = CType(resources.GetObject("cmdEliminarContacto.Image"), System.Drawing.Image)
        Me.cmdEliminarContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminarContacto.Name = "cmdEliminarContacto"
        Me.cmdEliminarContacto.Size = New System.Drawing.Size(23, 22)
        Me.cmdEliminarContacto.Text = "ToolStripButton2"
        Me.cmdEliminarContacto.ToolTipText = "Eliminar Contacto"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(629, 353)
        Me.cmdCancelar.LookAndFeel.SkinName = "Caramel"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 74
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(629, 316)
        Me.cmdGuardar.LookAndFeel.SkinName = "Caramel"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 73
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'grbDatosNatural
        '
        Me.grbDatosNatural.Controls.Add(Me.dtpFechaNacimiento)
        Me.grbDatosNatural.Controls.Add(Me.txtdireccionNatural)
        Me.grbDatosNatural.Controls.Add(Me.Label4)
        Me.grbDatosNatural.Controls.Add(Me.Label5)
        Me.grbDatosNatural.Controls.Add(Me.cmbCiudadNatural)
        Me.grbDatosNatural.Controls.Add(Me.cmbGenero)
        Me.grbDatosNatural.Controls.Add(Me.txtCedula)
        Me.grbDatosNatural.Controls.Add(Me.lblFechaNacimiento)
        Me.grbDatosNatural.Controls.Add(Me.txtApellido2)
        Me.grbDatosNatural.Controls.Add(Me.txtApellido1)
        Me.grbDatosNatural.Controls.Add(Me.txtNombre2)
        Me.grbDatosNatural.Controls.Add(Me.txtNombre1)
        Me.grbDatosNatural.Controls.Add(Me.lblGenero)
        Me.grbDatosNatural.Controls.Add(Me.lblApellido2)
        Me.grbDatosNatural.Controls.Add(Me.lblApellido1)
        Me.grbDatosNatural.Controls.Add(Me.lblCedula)
        Me.grbDatosNatural.Controls.Add(Me.lblNombre2)
        Me.grbDatosNatural.Controls.Add(Me.lblNombre1)
        Me.grbDatosNatural.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDatosNatural.Location = New System.Drawing.Point(11, 52)
        Me.grbDatosNatural.Name = "grbDatosNatural"
        Me.grbDatosNatural.Size = New System.Drawing.Size(633, 207)
        Me.grbDatosNatural.TabIndex = 100
        Me.grbDatosNatural.TabStop = False
        Me.grbDatosNatural.Text = "Datos Generales"
        Me.grbDatosNatural.Visible = False
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.EditValue = Nothing
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(148, 107)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaNacimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(161, 20)
        Me.dtpFechaNacimiento.TabIndex = 31
        '
        'txtdireccionNatural
        '
        Me.txtdireccionNatural.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccionNatural.Location = New System.Drawing.Point(148, 133)
        Me.txtdireccionNatural.Multiline = True
        Me.txtdireccionNatural.Name = "txtdireccionNatural"
        Me.txtdireccionNatural.Size = New System.Drawing.Size(286, 57)
        Me.txtdireccionNatural.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Direccion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(341, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Ciudad:"
        '
        'cmbCiudadNatural
        '
        Me.cmbCiudadNatural.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCiudadNatural.AllowColMove = False
        Me.cmbCiudadNatural.AllowSort = False
        Me.cmbCiudadNatural.Caption = ""
        Me.cmbCiudadNatural.CaptionHeight = 17
        Me.cmbCiudadNatural.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCiudadNatural.ColumnCaptionHeight = 17
        Me.cmbCiudadNatural.ColumnFooterHeight = 17
        Me.cmbCiudadNatural.ColumnHeaders = False
        Me.cmbCiudadNatural.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCiudadNatural.ContentHeight = 15
        Me.cmbCiudadNatural.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCiudadNatural.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCiudadNatural.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiudadNatural.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCiudadNatural.EditorHeight = 15
        Me.cmbCiudadNatural.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiudadNatural.Images.Add(CType(resources.GetObject("cmbCiudadNatural.Images"), System.Drawing.Image))
        Me.cmbCiudadNatural.ItemHeight = 15
        Me.cmbCiudadNatural.Location = New System.Drawing.Point(449, 104)
        Me.cmbCiudadNatural.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCiudadNatural.MaxDropDownItems = CType(5, Short)
        Me.cmbCiudadNatural.MaxLength = 32767
        Me.cmbCiudadNatural.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCiudadNatural.Name = "cmbCiudadNatural"
        Me.cmbCiudadNatural.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCiudadNatural.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCiudadNatural.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCiudadNatural.Size = New System.Drawing.Size(170, 21)
        Me.cmbCiudadNatural.TabIndex = 28
        Me.cmbCiudadNatural.Tag = "OBLIGATORIO"
        Me.cmbCiudadNatural.PropBag = resources.GetString("cmbCiudadNatural.PropBag")
        '
        'cmbGenero
        '
        Me.cmbGenero.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGenero.AllowColMove = False
        Me.cmbGenero.AllowSort = False
        Me.cmbGenero.Caption = ""
        Me.cmbGenero.CaptionHeight = 17
        Me.cmbGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGenero.ColumnCaptionHeight = 17
        Me.cmbGenero.ColumnFooterHeight = 17
        Me.cmbGenero.ColumnHeaders = False
        Me.cmbGenero.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbGenero.ContentHeight = 15
        Me.cmbGenero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGenero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGenero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGenero.EditorHeight = 15
        Me.cmbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.Images.Add(CType(resources.GetObject("cmbGenero.Images"), System.Drawing.Image))
        Me.cmbGenero.ItemHeight = 15
        Me.cmbGenero.Location = New System.Drawing.Point(449, 77)
        Me.cmbGenero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGenero.MaxDropDownItems = CType(5, Short)
        Me.cmbGenero.MaxLength = 32767
        Me.cmbGenero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGenero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGenero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGenero.Size = New System.Drawing.Size(170, 21)
        Me.cmbGenero.TabIndex = 25
        Me.cmbGenero.Tag = "OBLIGATORIO"
        Me.cmbGenero.PropBag = resources.GetString("cmbGenero.PropBag")
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(148, 78)
        Me.txtCedula.Mask = "000-000000-0000L"
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(161, 20)
        Me.txtCedula.TabIndex = 24
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(8, 107)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(131, 13)
        Me.lblFechaNacimiento.TabIndex = 23
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'txtApellido2
        '
        Me.txtApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(449, 50)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(161, 20)
        Me.txtApellido2.TabIndex = 13
        Me.txtApellido2.Tag = "BLOQUEADO"
        '
        'txtApellido1
        '
        Me.txtApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1.Location = New System.Drawing.Point(449, 25)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(161, 20)
        Me.txtApellido1.TabIndex = 12
        Me.txtApellido1.Tag = "BLOQUEADO"
        '
        'txtNombre2
        '
        Me.txtNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2.Location = New System.Drawing.Point(148, 50)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(161, 20)
        Me.txtNombre2.TabIndex = 10
        Me.txtNombre2.Tag = "BLOQUEADO"
        '
        'txtNombre1
        '
        Me.txtNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre1.Location = New System.Drawing.Point(148, 25)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(161, 20)
        Me.txtNombre1.TabIndex = 9
        Me.txtNombre1.Tag = "BLOQUEADO"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(339, 81)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(52, 13)
        Me.lblGenero.TabIndex = 6
        Me.lblGenero.Text = "Género:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(339, 53)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(110, 13)
        Me.lblApellido2.TabIndex = 5
        Me.lblApellido2.Text = "Segundo Apellido:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(339, 28)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(95, 13)
        Me.lblApellido1.TabIndex = 4
        Me.lblApellido1.Text = "Primer Apellido:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(8, 78)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(50, 13)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Cédula:"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(8, 53)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(108, 13)
        Me.lblNombre2.TabIndex = 2
        Me.lblNombre2.Text = "Segundo Nombre:"
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre1.Location = New System.Drawing.Point(8, 28)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(93, 13)
        Me.lblNombre1.TabIndex = 1
        Me.lblNombre1.Text = "Primer Nombre:"
        '
        'frmSivProveedorEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 470)
        Me.Controls.Add(Me.cmdEditarContactoPrincipal)
        Me.Controls.Add(Me.cmdBuscarContacto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivProveedorEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Proveedor"
        Me.gbxDatosJuridico.ResumeLayout(False)
        Me.gbxDatosJuridico.PerformLayout()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProveedor.ResumeLayout(False)
        Me.tbpContacto.ResumeLayout(False)
        CType(Me.grdContactoPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuProvision.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.tabAdicionales.ResumeLayout(False)
        Me.tabContactos.ResumeLayout(False)
        Me.tabContactos.PerformLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barContactos.ResumeLayout(False)
        Me.barContactos.PerformLayout()
        Me.grbDatosNatural.ResumeLayout(False)
        Me.grbDatosNatural.PerformLayout()
        CType(Me.dtpFechaNacimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCiudadNatural, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents gbxDatosJuridico As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNombreCompleto As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIngreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblCedulaRUC As System.Windows.Forms.Label
    Friend WithEvents txtCedulaRUC As System.Windows.Forms.TextBox
    Friend WithEvents TabProveedor As System.Windows.Forms.TabControl
    Friend WithEvents tbpContacto As System.Windows.Forms.TabPage
    Friend WithEvents cmdBuscarProv As System.Windows.Forms.Button
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents imgProveedor As System.Windows.Forms.PictureBox
    Friend WithEvents grdContactoPrincipal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdBuscarContacto As System.Windows.Forms.Button
    Friend WithEvents mnuProvision As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEliminarProvision As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditarContactoPrincipal As System.Windows.Forms.Button
    Friend WithEvents ttBotones As System.Windows.Forms.ToolTip
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCiudad As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tabAdicionales As System.Windows.Forms.TabControl
    Friend WithEvents tabContactos As System.Windows.Forms.TabPage
    Friend WithEvents tdbContactos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents barContactos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents grbDatosNatural As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaNacimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtdireccionNatural As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCiudadNatural As C1.Win.C1List.C1Combo
    Friend WithEvents cmbGenero As C1.Win.C1List.C1Combo
    Friend WithEvents txtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre1 As System.Windows.Forms.TextBox
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblNombre2 As System.Windows.Forms.Label
    Friend WithEvents lblNombre1 As System.Windows.Forms.Label
    Friend WithEvents chkJuridico As System.Windows.Forms.CheckBox
End Class
