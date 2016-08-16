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
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.C1Combo1 = New C1.Win.C1List.C1Combo()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.panelClientes = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C1Combo3 = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1Combo2 = New C1.Win.C1List.C1Combo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCedulaNacionalidad = New System.Windows.Forms.CheckBox()
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.tabAdicionales = New System.Windows.Forms.TabControl()
        Me.tabContactos = New System.Windows.Forms.TabPage()
        Me.tdbContactos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.barContactos = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarContacto = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminarContacto = New System.Windows.Forms.ToolStripButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelClientes.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.tabAdicionales.SuspendLayout()
        Me.tabContactos.SuspendLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barContactos.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 484)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 16)
        Me.Panel1.TabIndex = 26
        '
        'C1Combo1
        '
        Me.C1Combo1.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo1.AllowColMove = False
        Me.C1Combo1.AllowSort = False
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CaptionHeight = 17
        Me.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ColumnHeaders = False
        Me.C1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo1.ContentHeight = 15
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo1.EditorHeight = 15
        Me.C1Combo1.ItemHeight = 15
        Me.C1Combo1.Location = New System.Drawing.Point(137, 45)
        Me.C1Combo1.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.Size = New System.Drawing.Size(170, 21)
        Me.C1Combo1.TabIndex = 13
        Me.C1Combo1.Tag = "OBLIGATORIO"
        Me.C1Combo1.Text = "C1Combo1"
        Me.C1Combo1.PropBag = resources.GetString("C1Combo1.PropBag")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'panelClientes
        '
        Me.panelClientes.Controls.Add(Me.cmdCancelar)
        Me.panelClientes.Controls.Add(Me.cmdGuardar)
        Me.panelClientes.Controls.Add(Me.GroupControl2)
        Me.panelClientes.Controls.Add(Me.GroupControl1)
        Me.panelClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelClientes.Location = New System.Drawing.Point(0, 0)
        Me.panelClientes.LookAndFeel.SkinName = "Blue"
        Me.panelClientes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panelClientes.Name = "panelClientes"
        Me.panelClientes.Size = New System.Drawing.Size(828, 500)
        Me.panelClientes.TabIndex = 29
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.NumericUpDown1)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.C1Combo3)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TextBox1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.C1Combo2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.chkCedulaNacionalidad)
        Me.GroupControl1.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupControl1.Controls.Add(Me.cmbGenero)
        Me.GroupControl1.Controls.Add(Me.txtCedula)
        Me.GroupControl1.Controls.Add(Me.txtSegundoApellido)
        Me.GroupControl1.Controls.Add(Me.txtPrimerApellido)
        Me.GroupControl1.Controls.Add(Me.txtSegundoNombre)
        Me.GroupControl1.Controls.Add(Me.txtPrimerNombre)
        Me.GroupControl1.Controls.Add(Me.lblFechaNacimiento)
        Me.GroupControl1.Controls.Add(Me.lblSegundoApellido)
        Me.GroupControl1.Controls.Add(Me.lblGenero)
        Me.GroupControl1.Controls.Add(Me.lblPrimerApellido)
        Me.GroupControl1.Controls.Add(Me.lblPrimerNombre)
        Me.GroupControl1.Controls.Add(Me.lblSegundoNombre)
        Me.GroupControl1.Location = New System.Drawing.Point(15, 12)
        Me.GroupControl1.LookAndFeel.SkinName = "Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(801, 264)
        Me.GroupControl1.TabIndex = 43
        Me.GroupControl1.Text = "Datos Generales"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(144, 192)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Tag = "OBLIGATORIO"
        Me.Label4.Text = "Orden de Cobro:"
        '
        'C1Combo3
        '
        Me.C1Combo3.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo3.AllowColMove = False
        Me.C1Combo3.AllowSort = False
        Me.C1Combo3.Caption = ""
        Me.C1Combo3.CaptionHeight = 17
        Me.C1Combo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo3.ColumnCaptionHeight = 17
        Me.C1Combo3.ColumnFooterHeight = 17
        Me.C1Combo3.ColumnHeaders = False
        Me.C1Combo3.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo3.ContentHeight = 15
        Me.C1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo3.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo3.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo3.EditorHeight = 15
        Me.C1Combo3.Images.Add(CType(resources.GetObject("C1Combo3.Images"), System.Drawing.Image))
        Me.C1Combo3.ItemHeight = 15
        Me.C1Combo3.Location = New System.Drawing.Point(144, 160)
        Me.C1Combo3.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo3.MaxDropDownItems = CType(5, Short)
        Me.C1Combo3.MaxLength = 32767
        Me.C1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo3.Name = "C1Combo3"
        Me.C1Combo3.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo3.Size = New System.Drawing.Size(170, 21)
        Me.C1Combo3.TabIndex = 61
        Me.C1Combo3.Tag = "OBLIGATORIO"
        Me.C1Combo3.Text = "C1Combo1"
        Me.C1Combo3.PropBag = resources.GetString("C1Combo3.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Tag = "OBLIGATORIO"
        Me.Label3.Text = "Ruta:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(526, 135)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 110)
        Me.TextBox1.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Direccion:"
        '
        'C1Combo2
        '
        Me.C1Combo2.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo2.AllowColMove = False
        Me.C1Combo2.AllowSort = False
        Me.C1Combo2.Caption = ""
        Me.C1Combo2.CaptionHeight = 17
        Me.C1Combo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo2.ColumnCaptionHeight = 17
        Me.C1Combo2.ColumnFooterHeight = 17
        Me.C1Combo2.ColumnHeaders = False
        Me.C1Combo2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo2.ContentHeight = 15
        Me.C1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo2.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo2.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo2.EditorHeight = 15
        Me.C1Combo2.Images.Add(CType(resources.GetObject("C1Combo2.Images"), System.Drawing.Image))
        Me.C1Combo2.ItemHeight = 15
        Me.C1Combo2.Location = New System.Drawing.Point(526, 92)
        Me.C1Combo2.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo2.MaxDropDownItems = CType(5, Short)
        Me.C1Combo2.MaxLength = 32767
        Me.C1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo2.Name = "C1Combo2"
        Me.C1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo2.Size = New System.Drawing.Size(170, 21)
        Me.C1Combo2.TabIndex = 58
        Me.C1Combo2.Tag = "OBLIGATORIO"
        Me.C1Combo2.Text = "C1Combo1"
        Me.C1Combo2.PropBag = resources.GetString("C1Combo2.PropBag")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(386, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Ciudad:"
        '
        'chkCedulaNacionalidad
        '
        Me.chkCedulaNacionalidad.AutoSize = True
        Me.chkCedulaNacionalidad.Checked = True
        Me.chkCedulaNacionalidad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCedulaNacionalidad.Location = New System.Drawing.Point(389, 58)
        Me.chkCedulaNacionalidad.Name = "chkCedulaNacionalidad"
        Me.chkCedulaNacionalidad.Size = New System.Drawing.Size(107, 17)
        Me.chkCedulaNacionalidad.TabIndex = 57
        Me.chkCedulaNacionalidad.Text = "Cédula Nacional:"
        Me.chkCedulaNacionalidad.UseVisualStyleBackColor = True
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
        Me.dtpFechaNacimiento.Calendar.SelectedDate = New Date(2016, 8, 5, 0, 0, 0, 0)
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
        Me.dtpFechaNacimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(526, 33)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(170, 20)
        Me.dtpFechaNacimiento.TabIndex = 48
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
        Me.cmbGenero.Images.Add(CType(resources.GetObject("cmbGenero.Images"), System.Drawing.Image))
        Me.cmbGenero.ItemHeight = 15
        Me.cmbGenero.Location = New System.Drawing.Point(144, 133)
        Me.cmbGenero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGenero.MaxDropDownItems = CType(5, Short)
        Me.cmbGenero.MaxLength = 32767
        Me.cmbGenero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGenero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGenero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGenero.Size = New System.Drawing.Size(170, 21)
        Me.cmbGenero.TabIndex = 47
        Me.cmbGenero.Tag = "OBLIGATORIO"
        Me.cmbGenero.Text = "C1Combo1"
        Me.cmbGenero.PropBag = resources.GetString("cmbGenero.PropBag")
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(526, 63)
        Me.txtCedula.Mask = "000-000000-0000L"
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(170, 20)
        Me.txtCedula.TabIndex = 49
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(144, 108)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtSegundoApellido.TabIndex = 46
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(144, 83)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtPrimerApellido.TabIndex = 45
        Me.txtPrimerApellido.Tag = "OBLIGATORIO"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(144, 58)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtSegundoNombre.TabIndex = 44
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(144, 33)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtPrimerNombre.TabIndex = 43
        Me.txtPrimerNombre.Tag = "OBLIGATORIO"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(386, 33)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaNacimiento.TabIndex = 56
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Location = New System.Drawing.Point(4, 113)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(93, 13)
        Me.lblSegundoApellido.TabIndex = 54
        Me.lblSegundoApellido.Text = "Segundo Apellido:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(4, 138)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(45, 13)
        Me.lblGenero.TabIndex = 53
        Me.lblGenero.Tag = "OBLIGATORIO"
        Me.lblGenero.Text = "Género:"
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Location = New System.Drawing.Point(4, 88)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(79, 13)
        Me.lblPrimerApellido.TabIndex = 52
        Me.lblPrimerApellido.Tag = "OBLIGATORIO"
        Me.lblPrimerApellido.Text = "Primer Apellido:"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Location = New System.Drawing.Point(4, 38)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(79, 13)
        Me.lblPrimerNombre.TabIndex = 51
        Me.lblPrimerNombre.Tag = "OBLIGATORIO"
        Me.lblPrimerNombre.Text = "Primer Nombre:"
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Location = New System.Drawing.Point(4, 63)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(93, 13)
        Me.lblSegundoNombre.TabIndex = 50
        Me.lblSegundoNombre.Text = "Segundo Nombre:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.tabAdicionales)
        Me.GroupControl2.Location = New System.Drawing.Point(15, 282)
        Me.GroupControl2.LookAndFeel.SkinName = "Blue"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(508, 184)
        Me.GroupControl2.TabIndex = 44
        '
        'tabAdicionales
        '
        Me.tabAdicionales.Controls.Add(Me.tabContactos)
        Me.tabAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdicionales.Location = New System.Drawing.Point(2, 22)
        Me.tabAdicionales.Name = "tabAdicionales"
        Me.tabAdicionales.SelectedIndex = 0
        Me.tabAdicionales.Size = New System.Drawing.Size(504, 160)
        Me.tabAdicionales.TabIndex = 2
        '
        'tabContactos
        '
        Me.tabContactos.Controls.Add(Me.tdbContactos)
        Me.tabContactos.Controls.Add(Me.barContactos)
        Me.tabContactos.Location = New System.Drawing.Point(4, 22)
        Me.tabContactos.Name = "tabContactos"
        Me.tabContactos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabContactos.Size = New System.Drawing.Size(496, 134)
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
        Me.tdbContactos.Size = New System.Drawing.Size(490, 103)
        Me.tdbContactos.TabIndex = 1
        Me.tdbContactos.Text = "C1TrueDBGrid1"
        Me.tdbContactos.PropBag = resources.GetString("tdbContactos.PropBag")
        '
        'barContactos
        '
        Me.barContactos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarContacto, Me.cmdEliminarContacto})
        Me.barContactos.Location = New System.Drawing.Point(3, 3)
        Me.barContactos.Name = "barContactos"
        Me.barContactos.Size = New System.Drawing.Size(490, 25)
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
        Me.cmdCancelar.Image = Global.SIFAC.My.Resources.Resources.Cancel16
        Me.cmdCancelar.Location = New System.Drawing.Point(725, 363)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 46
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = Global.SIFAC.My.Resources.Resources.Guardar16
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(725, 329)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 45
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmStbPersonasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbPersonasEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Clientes"
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelClientes.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.tabAdicionales.ResumeLayout(False)
        Me.tabContactos.ResumeLayout(False)
        Me.tabContactos.PerformLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barContactos.ResumeLayout(False)
        Me.barContactos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ArchivoDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelClientes As DevExpress.XtraEditors.PanelControl
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tabAdicionales As System.Windows.Forms.TabControl
    Friend WithEvents tabContactos As System.Windows.Forms.TabPage
    Friend WithEvents tdbContactos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents barContactos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents C1Combo3 As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C1Combo2 As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkCedulaNacionalidad As System.Windows.Forms.CheckBox
    Public WithEvents dtpFechaNacimiento As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbGenero As C1.Win.C1List.C1Combo
    Friend WithEvents txtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lblPrimerNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoNombre As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
End Class
