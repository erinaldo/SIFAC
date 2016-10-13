<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbPersonasEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbPersonasEditar))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCiudad = New C1.Win.C1List.C1Combo()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabAdicionales = New System.Windows.Forms.TabControl()
        Me.tabContactos = New System.Windows.Forms.TabPage()
        Me.tdbContactos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.barContactos = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarContacto = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminarContacto = New System.Windows.Forms.ToolStripButton()
        Me.tabPIM = New System.Windows.Forms.TabPage()
        Me.tdbPIM = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.barPIM = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarPIM = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminarPIM = New System.Windows.Forms.ToolStripButton()
        Me.grpPersonaJuridica = New System.Windows.Forms.GroupBox()
        Me.txtRUC = New System.Windows.Forms.MaskedTextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtSiglasEmpresa = New System.Windows.Forms.TextBox()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblNumeroRUC = New System.Windows.Forms.Label()
        Me.lblSiglasEmpresa = New System.Windows.Forms.Label()
        Me.grpPersonaNatural = New System.Windows.Forms.GroupBox()
        Me.dtpFechaNacimiento = New C1.Win.C1Input.C1DateEdit()
        Me.cmbGenero = New C1.Win.C1List.C1Combo()
        Me.txtCedula = New System.Windows.Forms.MaskedTextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.chkPersonaJuridica = New System.Windows.Forms.CheckBox()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.grpDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tabAdicionales.SuspendLayout()
        Me.tabContactos.SuspendLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barContactos.SuspendLayout()
        Me.tabPIM.SuspendLayout()
        CType(Me.tdbPIM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barPIM.SuspendLayout()
        Me.grpPersonaJuridica.SuspendLayout()
        Me.grpPersonaNatural.SuspendLayout()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.GroupBox2)
        Me.grpDatos.Controls.Add(Me.GroupBox1)
        Me.grpDatos.Controls.Add(Me.grpPersonaJuridica)
        Me.grpDatos.Controls.Add(Me.grpPersonaNatural)
        Me.grpDatos.Controls.Add(Me.chkPersonaJuridica)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(8, 11)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(768, 393)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbCiudad)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 116)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicacion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(142, 43)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(255, 57)
        Me.txtDireccion.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Direccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 17
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
        Me.cmbCiudad.Location = New System.Drawing.Point(142, 16)
        Me.cmbCiudad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCiudad.MaxDropDownItems = CType(5, Short)
        Me.cmbCiudad.MaxLength = 32767
        Me.cmbCiudad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCiudad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCiudad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCiudad.Size = New System.Drawing.Size(186, 21)
        Me.cmbCiudad.TabIndex = 18
        Me.cmbCiudad.Tag = "OBLIGATORIO"
        Me.cmbCiudad.PropBag = resources.GetString("cmbCiudad.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabAdicionales)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(442, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 212)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tabAdicionales
        '
        Me.tabAdicionales.Controls.Add(Me.tabContactos)
        Me.tabAdicionales.Controls.Add(Me.tabPIM)
        Me.tabAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdicionales.Location = New System.Drawing.Point(3, 16)
        Me.tabAdicionales.Name = "tabAdicionales"
        Me.tabAdicionales.SelectedIndex = 0
        Me.tabAdicionales.Size = New System.Drawing.Size(307, 193)
        Me.tabAdicionales.TabIndex = 1
        '
        'tabContactos
        '
        Me.tabContactos.Controls.Add(Me.tdbContactos)
        Me.tabContactos.Controls.Add(Me.barContactos)
        Me.tabContactos.Location = New System.Drawing.Point(4, 22)
        Me.tabContactos.Name = "tabContactos"
        Me.tabContactos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabContactos.Size = New System.Drawing.Size(299, 167)
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
        Me.tdbContactos.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbContactos.Images.Add(CType(resources.GetObject("tdbContactos.Images"), System.Drawing.Image))
        Me.tdbContactos.Location = New System.Drawing.Point(3, 28)
        Me.tdbContactos.Name = "tdbContactos"
        Me.tdbContactos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbContactos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbContactos.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbContactos.PrintInfo.PageSettings = CType(resources.GetObject("tdbContactos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbContactos.Size = New System.Drawing.Size(293, 136)
        Me.tdbContactos.TabIndex = 1
        Me.tdbContactos.Text = "C1TrueDBGrid1"
        Me.tdbContactos.PropBag = resources.GetString("tdbContactos.PropBag")
        '
        'barContactos
        '
        Me.barContactos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarContacto, Me.cmdEliminarContacto})
        Me.barContactos.Location = New System.Drawing.Point(3, 3)
        Me.barContactos.Name = "barContactos"
        Me.barContactos.Size = New System.Drawing.Size(293, 25)
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
        'tabPIM
        '
        Me.tabPIM.Controls.Add(Me.tdbPIM)
        Me.tabPIM.Controls.Add(Me.barPIM)
        Me.tabPIM.Location = New System.Drawing.Point(4, 22)
        Me.tabPIM.Name = "tabPIM"
        Me.tabPIM.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPIM.Size = New System.Drawing.Size(299, 167)
        Me.tabPIM.TabIndex = 1
        Me.tabPIM.Text = "Clasificaciones PIM"
        Me.tabPIM.UseVisualStyleBackColor = True
        '
        'tdbPIM
        '
        Me.tdbPIM.AllowArrows = False
        Me.tdbPIM.AllowColMove = False
        Me.tdbPIM.AllowColSelect = False
        Me.tdbPIM.AllowRowSelect = False
        Me.tdbPIM.AllowUpdate = False
        Me.tdbPIM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbPIM.ExtendRightColumn = True
        Me.tdbPIM.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbPIM.Images.Add(CType(resources.GetObject("tdbPIM.Images"), System.Drawing.Image))
        Me.tdbPIM.Location = New System.Drawing.Point(3, 28)
        Me.tdbPIM.Name = "tdbPIM"
        Me.tdbPIM.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbPIM.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbPIM.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbPIM.PrintInfo.PageSettings = CType(resources.GetObject("tdbPIM.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbPIM.Size = New System.Drawing.Size(293, 136)
        Me.tdbPIM.TabIndex = 1
        Me.tdbPIM.Text = "C1TrueDBGrid2"
        Me.tdbPIM.PropBag = resources.GetString("tdbPIM.PropBag")
        '
        'barPIM
        '
        Me.barPIM.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.barPIM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarPIM, Me.cmdEliminarPIM})
        Me.barPIM.Location = New System.Drawing.Point(3, 3)
        Me.barPIM.Name = "barPIM"
        Me.barPIM.Size = New System.Drawing.Size(293, 25)
        Me.barPIM.TabIndex = 0
        Me.barPIM.Text = "ToolStrip2"
        '
        'cmdAgregarPIM
        '
        Me.cmdAgregarPIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarPIM.Image = CType(resources.GetObject("cmdAgregarPIM.Image"), System.Drawing.Image)
        Me.cmdAgregarPIM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAgregarPIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarPIM.Name = "cmdAgregarPIM"
        Me.cmdAgregarPIM.Size = New System.Drawing.Size(23, 22)
        Me.cmdAgregarPIM.Text = "ToolStripButton1"
        Me.cmdAgregarPIM.ToolTipText = "Agregar Clasificación PIM"
        '
        'cmdEliminarPIM
        '
        Me.cmdEliminarPIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminarPIM.Image = CType(resources.GetObject("cmdEliminarPIM.Image"), System.Drawing.Image)
        Me.cmdEliminarPIM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdEliminarPIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminarPIM.Name = "cmdEliminarPIM"
        Me.cmdEliminarPIM.Size = New System.Drawing.Size(23, 22)
        Me.cmdEliminarPIM.Text = "ToolStripButton2"
        Me.cmdEliminarPIM.ToolTipText = "Eliminar Clasificación PIM"
        '
        'grpPersonaJuridica
        '
        Me.grpPersonaJuridica.Controls.Add(Me.txtRUC)
        Me.grpPersonaJuridica.Controls.Add(Me.txtRazonSocial)
        Me.grpPersonaJuridica.Controls.Add(Me.txtSiglasEmpresa)
        Me.grpPersonaJuridica.Controls.Add(Me.lblRazonSocial)
        Me.grpPersonaJuridica.Controls.Add(Me.lblNumeroRUC)
        Me.grpPersonaJuridica.Controls.Add(Me.lblSiglasEmpresa)
        Me.grpPersonaJuridica.Location = New System.Drawing.Point(439, 37)
        Me.grpPersonaJuridica.Name = "grpPersonaJuridica"
        Me.grpPersonaJuridica.Size = New System.Drawing.Size(313, 125)
        Me.grpPersonaJuridica.TabIndex = 3
        Me.grpPersonaJuridica.TabStop = False
        Me.grpPersonaJuridica.Text = "Empresa"
        '
        'txtRUC
        '
        Me.txtRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.Location = New System.Drawing.Point(125, 95)
        Me.txtRUC.Mask = "000000-0000"
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(170, 20)
        Me.txtRUC.TabIndex = 4
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(125, 45)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(170, 20)
        Me.txtRazonSocial.TabIndex = 2
        Me.txtRazonSocial.Tag = "OBLIGATORIO"
        '
        'txtSiglasEmpresa
        '
        Me.txtSiglasEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSiglasEmpresa.Location = New System.Drawing.Point(125, 20)
        Me.txtSiglasEmpresa.Name = "txtSiglasEmpresa"
        Me.txtSiglasEmpresa.Size = New System.Drawing.Size(170, 20)
        Me.txtSiglasEmpresa.TabIndex = 1
        Me.txtSiglasEmpresa.Tag = "OBLIGATORIO"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(10, 50)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(86, 13)
        Me.lblRazonSocial.TabIndex = 14
        Me.lblRazonSocial.Tag = "OBLIGATORIO"
        Me.lblRazonSocial.Text = "Razón Social:"
        '
        'lblNumeroRUC
        '
        Me.lblNumeroRUC.AutoSize = True
        Me.lblNumeroRUC.Location = New System.Drawing.Point(10, 100)
        Me.lblNumeroRUC.Name = "lblNumeroRUC"
        Me.lblNumeroRUC.Size = New System.Drawing.Size(84, 13)
        Me.lblNumeroRUC.TabIndex = 12
        Me.lblNumeroRUC.Tag = "OBLIGATORIO"
        Me.lblNumeroRUC.Text = "Número RUC:"
        '
        'lblSiglasEmpresa
        '
        Me.lblSiglasEmpresa.AutoSize = True
        Me.lblSiglasEmpresa.Location = New System.Drawing.Point(10, 25)
        Me.lblSiglasEmpresa.Name = "lblSiglasEmpresa"
        Me.lblSiglasEmpresa.Size = New System.Drawing.Size(97, 13)
        Me.lblSiglasEmpresa.TabIndex = 11
        Me.lblSiglasEmpresa.Tag = "OBLIGATORIO"
        Me.lblSiglasEmpresa.Text = "Siglas Empresa:"
        '
        'grpPersonaNatural
        '
        Me.grpPersonaNatural.Controls.Add(Me.lblCedula)
        Me.grpPersonaNatural.Controls.Add(Me.dtpFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.cmbGenero)
        Me.grpPersonaNatural.Controls.Add(Me.txtCedula)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoNombre)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblGenero)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoNombre)
        Me.grpPersonaNatural.Location = New System.Drawing.Point(16, 34)
        Me.grpPersonaNatural.Name = "grpPersonaNatural"
        Me.grpPersonaNatural.Size = New System.Drawing.Size(397, 220)
        Me.grpPersonaNatural.TabIndex = 2
        Me.grpPersonaNatural.TabStop = False
        Me.grpPersonaNatural.Text = "Persona"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.AcceptsTab = True
        Me.dtpFechaNacimiento.AllowDrop = True
        Me.dtpFechaNacimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        '
        '
        '
        Me.dtpFechaNacimiento.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.ClearText = "&Clear"
        Me.dtpFechaNacimiento.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.SelectedDate = New Date(2016, 8, 25, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.Calendar.ShowTodayCircle = False
        Me.dtpFechaNacimiento.Calendar.TodayText = "&Today"
        Me.dtpFechaNacimiento.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaNacimiento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaNacimiento.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtpFechaNacimiento.EmptyAsNull = True
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(150, 152)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(170, 20)
        Me.dtpFechaNacimiento.TabIndex = 7
        Me.dtpFechaNacimiento.Tag = Nothing
        Me.dtpFechaNacimiento.TrimStart = True
        Me.dtpFechaNacimiento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaNacimiento.VisualStyle = C1.Win.C1Input.VisualStyle.System
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
        Me.cmbGenero.Location = New System.Drawing.Point(150, 125)
        Me.cmbGenero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGenero.MaxDropDownItems = CType(5, Short)
        Me.cmbGenero.MaxLength = 32767
        Me.cmbGenero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGenero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGenero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGenero.Size = New System.Drawing.Size(170, 21)
        Me.cmbGenero.TabIndex = 6
        Me.cmbGenero.Tag = "OBLIGATORIO"
        Me.cmbGenero.Text = "C1Combo1"
        Me.cmbGenero.PropBag = resources.GetString("cmbGenero.PropBag")
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(150, 182)
        Me.txtCedula.Mask = "000-000000-0000L"
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(170, 20)
        Me.txtCedula.TabIndex = 8
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(150, 100)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtSegundoApellido.TabIndex = 5
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(150, 75)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtPrimerApellido.TabIndex = 4
        Me.txtPrimerApellido.Tag = "OBLIGATORIO"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(150, 50)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtSegundoNombre.TabIndex = 3
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(150, 25)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtPrimerNombre.TabIndex = 2
        Me.txtPrimerNombre.Tag = "OBLIGATORIO"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(10, 155)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(131, 13)
        Me.lblFechaNacimiento.TabIndex = 14
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Location = New System.Drawing.Point(10, 105)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(110, 13)
        Me.lblSegundoApellido.TabIndex = 12
        Me.lblSegundoApellido.Text = "Segundo Apellido:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(10, 130)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(52, 13)
        Me.lblGenero.TabIndex = 11
        Me.lblGenero.Tag = "OBLIGATORIO"
        Me.lblGenero.Text = "Género:"
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Location = New System.Drawing.Point(10, 80)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(95, 13)
        Me.lblPrimerApellido.TabIndex = 10
        Me.lblPrimerApellido.Tag = "OBLIGATORIO"
        Me.lblPrimerApellido.Text = "Primer Apellido:"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Location = New System.Drawing.Point(10, 30)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(93, 13)
        Me.lblPrimerNombre.TabIndex = 9
        Me.lblPrimerNombre.Tag = "OBLIGATORIO"
        Me.lblPrimerNombre.Text = "Primer Nombre:"
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Location = New System.Drawing.Point(10, 55)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(108, 13)
        Me.lblSegundoNombre.TabIndex = 8
        Me.lblSegundoNombre.Text = "Segundo Nombre:"
        '
        'chkPersonaJuridica
        '
        Me.chkPersonaJuridica.AutoSize = True
        Me.chkPersonaJuridica.Location = New System.Drawing.Point(16, 15)
        Me.chkPersonaJuridica.Name = "chkPersonaJuridica"
        Me.chkPersonaJuridica.Size = New System.Drawing.Size(122, 17)
        Me.chkPersonaJuridica.TabIndex = 1
        Me.chkPersonaJuridica.Text = "Persona Jurídica"
        Me.chkPersonaJuridica.UseVisualStyleBackColor = True
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'ArchivoDialogo
        '
        Me.ArchivoDialogo.FileName = "OpenFileDialog1"
        Me.ArchivoDialogo.Filter = "JPEG Files | *.JPG"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 448)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 16)
        Me.Panel1.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.grpDatos)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(787, 464)
        Me.PanelControl1.TabIndex = 28
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(688, 411)
        Me.cmdCancelar.LookAndFeel.SkinName = "Caramel"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 32
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(602, 411)
        Me.cmdGuardar.LookAndFeel.SkinName = "Caramel"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 31
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(12, 182)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(50, 13)
        Me.lblCedula.TabIndex = 15
        Me.lblCedula.Text = "Cédula:"
        '
        'frmStbPersonasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 464)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbPersonasEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.tabAdicionales.ResumeLayout(False)
        Me.tabContactos.ResumeLayout(False)
        Me.tabContactos.PerformLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barContactos.ResumeLayout(False)
        Me.barContactos.PerformLayout()
        Me.tabPIM.ResumeLayout(False)
        Me.tabPIM.PerformLayout()
        CType(Me.tdbPIM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barPIM.ResumeLayout(False)
        Me.barPIM.PerformLayout()
        Me.grpPersonaJuridica.ResumeLayout(False)
        Me.grpPersonaJuridica.PerformLayout()
        Me.grpPersonaNatural.ResumeLayout(False)
        Me.grpPersonaNatural.PerformLayout()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents chkPersonaJuridica As System.Windows.Forms.CheckBox
    Friend WithEvents grpPersonaNatural As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpPersonaJuridica As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrimerNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRUC As System.Windows.Forms.Label
    Friend WithEvents lblSiglasEmpresa As System.Windows.Forms.Label
    Friend WithEvents tabAdicionales As System.Windows.Forms.TabControl
    Friend WithEvents tabContactos As System.Windows.Forms.TabPage
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents tabPIM As System.Windows.Forms.TabPage
    Friend WithEvents barContactos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents barPIM As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarPIM As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminarPIM As System.Windows.Forms.ToolStripButton
    Friend WithEvents tdbContactos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tdbPIM As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtSiglasEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtRUC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbGenero As C1.Win.C1List.C1Combo
    Friend WithEvents ArchivoDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents dtpFechaNacimiento As C1.Win.C1Input.C1DateEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCiudad As C1.Win.C1List.C1Combo
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCedula As System.Windows.Forms.Label
End Class
