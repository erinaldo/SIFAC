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
        Me.gbxDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCiudad = New C1.Win.C1List.C1Combo()
        Me.imgProveedor = New System.Windows.Forms.PictureBox()
        Me.cmdBuscarProv = New System.Windows.Forms.Button()
        Me.cmdNuevoProv = New System.Windows.Forms.Button()
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCedulaRUC = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New C1.Win.C1Input.C1DateEdit()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCedulaRUC = New System.Windows.Forms.TextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.lblIdProveedor = New System.Windows.Forms.Label()
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
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosPersonales.SuspendLayout()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProveedor.SuspendLayout()
        Me.tbpContacto.SuspendLayout()
        CType(Me.grdContactoPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuProvision.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDatosPersonales
        '
        Me.gbxDatosPersonales.Controls.Add(Me.Label1)
        Me.gbxDatosPersonales.Controls.Add(Me.cmbCiudad)
        Me.gbxDatosPersonales.Controls.Add(Me.imgProveedor)
        Me.gbxDatosPersonales.Controls.Add(Me.cmdBuscarProv)
        Me.gbxDatosPersonales.Controls.Add(Me.cmdNuevoProv)
        Me.gbxDatosPersonales.Controls.Add(Me.chkActivo)
        Me.gbxDatosPersonales.Controls.Add(Me.txtDireccion)
        Me.gbxDatosPersonales.Controls.Add(Me.lblTelefono)
        Me.gbxDatosPersonales.Controls.Add(Me.lblCedulaRUC)
        Me.gbxDatosPersonales.Controls.Add(Me.lblDireccion)
        Me.gbxDatosPersonales.Controls.Add(Me.lblFechaIngreso)
        Me.gbxDatosPersonales.Controls.Add(Me.lblNombreCompleto)
        Me.gbxDatosPersonales.Controls.Add(Me.dtpFechaIngreso)
        Me.gbxDatosPersonales.Controls.Add(Me.txtTelefono)
        Me.gbxDatosPersonales.Controls.Add(Me.txtCedulaRUC)
        Me.gbxDatosPersonales.Controls.Add(Me.txtNombreCompleto)
        Me.gbxDatosPersonales.Controls.Add(Me.txtIdProveedor)
        Me.gbxDatosPersonales.Controls.Add(Me.lblIdProveedor)
        Me.gbxDatosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosPersonales.Location = New System.Drawing.Point(11, 14)
        Me.gbxDatosPersonales.Name = "gbxDatosPersonales"
        Me.gbxDatosPersonales.Size = New System.Drawing.Size(750, 244)
        Me.gbxDatosPersonales.TabIndex = 1
        Me.gbxDatosPersonales.TabStop = False
        Me.gbxDatosPersonales.Text = "Datos personales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 117)
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
        Me.cmbCiudad.Location = New System.Drawing.Point(121, 110)
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
        'imgProveedor
        '
        Me.imgProveedor.BackgroundImage = Global.SIFAC.My.Resources.Resources.ProveedorEstilo1
        Me.imgProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgProveedor.Location = New System.Drawing.Point(590, 24)
        Me.imgProveedor.Name = "imgProveedor"
        Me.imgProveedor.Size = New System.Drawing.Size(133, 154)
        Me.imgProveedor.TabIndex = 98
        Me.imgProveedor.TabStop = False
        '
        'cmdBuscarProv
        '
        Me.cmdBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBuscarProv.Image = CType(resources.GetObject("cmdBuscarProv.Image"), System.Drawing.Image)
        Me.cmdBuscarProv.Location = New System.Drawing.Point(290, 17)
        Me.cmdBuscarProv.Name = "cmdBuscarProv"
        Me.cmdBuscarProv.Size = New System.Drawing.Size(29, 25)
        Me.cmdBuscarProv.TabIndex = 3
        Me.cmdBuscarProv.UseVisualStyleBackColor = True
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
        Me.chkActivo.Location = New System.Drawing.Point(470, 23)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 96
        Me.chkActivo.Tag = "BLOQUEADO"
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.AcceptsTab = True
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(121, 140)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(411, 55)
        Me.txtDireccion.TabIndex = 93
        Me.txtDireccion.TabStop = False
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Location = New System.Drawing.Point(301, 212)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 13)
        Me.lblTelefono.TabIndex = 92
        Me.lblTelefono.Tag = ""
        Me.lblTelefono.Text = "Tel�fono:"
        '
        'lblCedulaRUC
        '
        Me.lblCedulaRUC.AutoSize = True
        Me.lblCedulaRUC.BackColor = System.Drawing.Color.Transparent
        Me.lblCedulaRUC.Location = New System.Drawing.Point(14, 212)
        Me.lblCedulaRUC.Name = "lblCedulaRUC"
        Me.lblCedulaRUC.Size = New System.Drawing.Size(90, 13)
        Me.lblCedulaRUC.TabIndex = 92
        Me.lblCedulaRUC.Tag = ""
        Me.lblCedulaRUC.Text = "C�dula / RUC:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Location = New System.Drawing.Point(15, 148)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(65, 13)
        Me.lblDireccion.TabIndex = 92
        Me.lblDireccion.Tag = ""
        Me.lblDireccion.Text = "Direcci�n:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaIngreso.Location = New System.Drawing.Point(15, 52)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaIngreso.TabIndex = 88
        Me.lblFechaIngreso.Tag = ""
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCompleto.Location = New System.Drawing.Point(15, 78)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(102, 28)
        Me.lblNombreCompleto.TabIndex = 86
        Me.lblNombreCompleto.Tag = ""
        Me.lblNombreCompleto.Text = "Nombre completo / Raz�n Social:"
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
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(121, 52)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(123, 18)
        Me.dtpFechaIngreso.TabIndex = 0
        Me.dtpFechaIngreso.Tag = Nothing
        Me.dtpFechaIngreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(375, 208)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(157, 20)
        Me.txtTelefono.TabIndex = 0
        Me.txtTelefono.TabStop = False
        Me.txtTelefono.Tag = "BLOQUEADO"
        '
        'txtCedulaRUC
        '
        Me.txtCedulaRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaRUC.Location = New System.Drawing.Point(119, 208)
        Me.txtCedulaRUC.Name = "txtCedulaRUC"
        Me.txtCedulaRUC.Size = New System.Drawing.Size(157, 20)
        Me.txtCedulaRUC.TabIndex = 0
        Me.txtCedulaRUC.TabStop = False
        Me.txtCedulaRUC.Tag = "BLOQUEADO"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(121, 81)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(411, 20)
        Me.txtNombreCompleto.TabIndex = 0
        Me.txtNombreCompleto.TabStop = False
        Me.txtNombreCompleto.Tag = "BLOQUEADO"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProveedor.Location = New System.Drawing.Point(121, 19)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(126, 20)
        Me.txtIdProveedor.TabIndex = 0
        Me.txtIdProveedor.TabStop = False
        Me.txtIdProveedor.Tag = "BLOQUEADO"
        Me.txtIdProveedor.Text = "(Autom�tico)"
        '
        'lblIdProveedor
        '
        Me.lblIdProveedor.AutoSize = True
        Me.lblIdProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblIdProveedor.Location = New System.Drawing.Point(15, 24)
        Me.lblIdProveedor.Name = "lblIdProveedor"
        Me.lblIdProveedor.Size = New System.Drawing.Size(84, 13)
        Me.lblIdProveedor.TabIndex = 19
        Me.lblIdProveedor.Tag = ""
        Me.lblIdProveedor.Text = "Id Proveedor:"
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
        Me.Panel1.Size = New System.Drawing.Size(779, 22)
        Me.Panel1.TabIndex = 11
        '
        'TabProveedor
        '
        Me.TabProveedor.Controls.Add(Me.tbpContacto)
        Me.TabProveedor.Location = New System.Drawing.Point(12, 276)
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
        Me.cmdBuscarContacto.Size = New System.Drawing.Size(29, 25)
        Me.cmdBuscarContacto.TabIndex = 4
        Me.cmdBuscarContacto.UseVisualStyleBackColor = True
        '
        'cmdEditarContactoPrincipal
        '
        Me.cmdEditarContactoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEditarContactoPrincipal.ImageIndex = 0
        Me.cmdEditarContactoPrincipal.ImageList = Me.imgIconos
        Me.cmdEditarContactoPrincipal.Location = New System.Drawing.Point(472, 264)
        Me.cmdEditarContactoPrincipal.Name = "cmdEditarContactoPrincipal"
        Me.cmdEditarContactoPrincipal.Size = New System.Drawing.Size(30, 25)
        Me.cmdEditarContactoPrincipal.TabIndex = 73
        Me.cmdEditarContactoPrincipal.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosPersonales)
        Me.PanelControl1.Controls.Add(Me.TabProveedor)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(779, 470)
        Me.PanelControl1.TabIndex = 74
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
        'frmSivProveedorEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 470)
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
        Me.gbxDatosPersonales.ResumeLayout(False)
        Me.gbxDatosPersonales.PerformLayout()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProveedor.ResumeLayout(False)
        Me.tbpContacto.ResumeLayout(False)
        CType(Me.grdContactoPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuProvision.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDatosPersonales As System.Windows.Forms.GroupBox
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
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents lblCedulaRUC As System.Windows.Forms.Label
    Friend WithEvents txtCedulaRUC As System.Windows.Forms.TextBox
    Friend WithEvents cmdNuevoProv As System.Windows.Forms.Button
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
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
End Class
