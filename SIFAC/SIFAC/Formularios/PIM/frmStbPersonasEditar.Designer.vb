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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbPersonasEditar))
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.grpDatos = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tabAdicionales = New System.Windows.Forms.TabControl
        Me.tabContactos = New System.Windows.Forms.TabPage
        Me.tdbContactos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.barContactos = New System.Windows.Forms.ToolStrip
        Me.cmdAgregarContacto = New System.Windows.Forms.ToolStripButton
        Me.cmdEliminarContacto = New System.Windows.Forms.ToolStripButton
        Me.tabPIM = New System.Windows.Forms.TabPage
        Me.tdbPIM = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.barPIM = New System.Windows.Forms.ToolStrip
        Me.cmdAgregarPIM = New System.Windows.Forms.ToolStripButton
        Me.cmdEliminarPIM = New System.Windows.Forms.ToolStripButton
        Me.grpPersonaJuridica = New System.Windows.Forms.GroupBox
        Me.dtpFechaConstitucion = New C1.Win.C1Input.C1DateEdit
        Me.txtRUC = New System.Windows.Forms.MaskedTextBox
        Me.txtRazonSocial = New System.Windows.Forms.TextBox
        Me.txtSiglasEmpresa = New System.Windows.Forms.TextBox
        Me.lblRazonSocial = New System.Windows.Forms.Label
        Me.lblFechaConstitucion = New System.Windows.Forms.Label
        Me.lblNumeroRUC = New System.Windows.Forms.Label
        Me.lblSiglasEmpresa = New System.Windows.Forms.Label
        Me.grpPersonaNatural = New System.Windows.Forms.GroupBox
        Me.chkCedulaNacionalidad = New System.Windows.Forms.CheckBox
        Me.dtpFechaNacimiento = New C1.Win.C1Input.C1DateEdit
        Me.cmbGenero = New C1.Win.C1List.C1Combo
        Me.txtCedula = New System.Windows.Forms.MaskedTextBox
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox
        Me.txtPrefijoTrato = New System.Windows.Forms.TextBox
        Me.grpOtrosDatos = New System.Windows.Forms.GroupBox
        Me.chkExonerado = New System.Windows.Forms.CheckBox
        Me.cmdCedulaReverso = New System.Windows.Forms.Button
        Me.cmdCedulaAnverso = New System.Windows.Forms.Button
        Me.txtCedulaReverso = New System.Windows.Forms.TextBox
        Me.txtCedulaAnverso = New System.Windows.Forms.TextBox
        Me.cmbOcupacion = New System.Windows.Forms.ComboBox
        Me.lblOcupacion = New System.Windows.Forms.Label
        Me.lblCedulaReverso = New System.Windows.Forms.Label
        Me.lblCedulaAnverso = New System.Windows.Forms.Label
        Me.lblFechaNacimiento = New System.Windows.Forms.Label
        Me.lblSegundoApellido = New System.Windows.Forms.Label
        Me.lblGenero = New System.Windows.Forms.Label
        Me.lblPrimerApellido = New System.Windows.Forms.Label
        Me.lblPrimerNombre = New System.Windows.Forms.Label
        Me.lblSegundoNombre = New System.Windows.Forms.Label
        Me.lblPrefijoTrato = New System.Windows.Forms.Label
        Me.chkPersonaJuridica = New System.Windows.Forms.CheckBox
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog
        Me.cmdConsultarCedula = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabAdicionales.SuspendLayout()
        Me.tabContactos.SuspendLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barContactos.SuspendLayout()
        Me.tabPIM.SuspendLayout()
        CType(Me.tdbPIM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barPIM.SuspendLayout()
        Me.grpPersonaJuridica.SuspendLayout()
        CType(Me.dtpFechaConstitucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonaNatural.SuspendLayout()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOtrosDatos.SuspendLayout()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(619, 449)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 29)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(538, 449)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 29)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.GroupBox1)
        Me.grpDatos.Controls.Add(Me.grpPersonaJuridica)
        Me.grpDatos.Controls.Add(Me.grpPersonaNatural)
        Me.grpDatos.Controls.Add(Me.chkPersonaJuridica)
        Me.grpDatos.Location = New System.Drawing.Point(12, 39)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(682, 403)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabAdicionales)
        Me.GroupBox1.Location = New System.Drawing.Point(363, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 212)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empresa"
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
        Me.tabContactos.Text = "�C�mo Contactar?"
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
        Me.tdbContactos.PreviewInfo.ZoomFactor = 75
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
        Me.tdbPIM.PreviewInfo.ZoomFactor = 75
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
        Me.cmdAgregarPIM.ToolTipText = "Agregar Clasificaci�n PIM"
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
        Me.cmdEliminarPIM.ToolTipText = "Eliminar Clasificaci�n PIM"
        '
        'grpPersonaJuridica
        '
        Me.grpPersonaJuridica.Controls.Add(Me.dtpFechaConstitucion)
        Me.grpPersonaJuridica.Controls.Add(Me.txtRUC)
        Me.grpPersonaJuridica.Controls.Add(Me.txtRazonSocial)
        Me.grpPersonaJuridica.Controls.Add(Me.txtSiglasEmpresa)
        Me.grpPersonaJuridica.Controls.Add(Me.lblRazonSocial)
        Me.grpPersonaJuridica.Controls.Add(Me.lblFechaConstitucion)
        Me.grpPersonaJuridica.Controls.Add(Me.lblNumeroRUC)
        Me.grpPersonaJuridica.Controls.Add(Me.lblSiglasEmpresa)
        Me.grpPersonaJuridica.Location = New System.Drawing.Point(363, 42)
        Me.grpPersonaJuridica.Name = "grpPersonaJuridica"
        Me.grpPersonaJuridica.Size = New System.Drawing.Size(313, 125)
        Me.grpPersonaJuridica.TabIndex = 3
        Me.grpPersonaJuridica.TabStop = False
        Me.grpPersonaJuridica.Text = "Empresa"
        '
        'dtpFechaConstitucion
        '
        Me.dtpFechaConstitucion.AllowDrop = True
        Me.dtpFechaConstitucion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        '
        '
        '
        Me.dtpFechaConstitucion.Calendar.ShowTodayCircle = False
        'Me.dtpFechaConstitucion.Calendar.UIStrings.Content = New String() {"&Clear:&Limpiar", "&Today:&FechaActual"}
        Me.dtpFechaConstitucion.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaConstitucion.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaConstitucion.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtpFechaConstitucion.EmptyAsNull = True
        Me.dtpFechaConstitucion.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaConstitucion.Location = New System.Drawing.Point(126, 70)
        Me.dtpFechaConstitucion.Name = "dtpFechaConstitucion"
        Me.dtpFechaConstitucion.Size = New System.Drawing.Size(169, 20)
        Me.dtpFechaConstitucion.TabIndex = 17
        Me.dtpFechaConstitucion.Tag = Nothing
        Me.dtpFechaConstitucion.TrimStart = True
        Me.dtpFechaConstitucion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaConstitucion.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaConstitucion.WrapDateTimeFields = False
        '
        'txtRUC
        '
        Me.txtRUC.Location = New System.Drawing.Point(125, 95)
        Me.txtRUC.Mask = "000000-0000"
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(170, 20)
        Me.txtRUC.TabIndex = 4
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(125, 45)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(170, 20)
        Me.txtRazonSocial.TabIndex = 2
        Me.txtRazonSocial.Tag = "OBLIGATORIO"
        '
        'txtSiglasEmpresa
        '
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
        Me.lblRazonSocial.Size = New System.Drawing.Size(73, 13)
        Me.lblRazonSocial.TabIndex = 14
        Me.lblRazonSocial.Tag = "OBLIGATORIO"
        Me.lblRazonSocial.Text = "Raz�n Social:"
        '
        'lblFechaConstitucion
        '
        Me.lblFechaConstitucion.AutoSize = True
        Me.lblFechaConstitucion.Location = New System.Drawing.Point(10, 75)
        Me.lblFechaConstitucion.Name = "lblFechaConstitucion"
        Me.lblFechaConstitucion.Size = New System.Drawing.Size(116, 13)
        Me.lblFechaConstitucion.TabIndex = 13
        Me.lblFechaConstitucion.Text = "Fecha de Constituci�n:"
        '
        'lblNumeroRUC
        '
        Me.lblNumeroRUC.AutoSize = True
        Me.lblNumeroRUC.Location = New System.Drawing.Point(10, 100)
        Me.lblNumeroRUC.Name = "lblNumeroRUC"
        Me.lblNumeroRUC.Size = New System.Drawing.Size(73, 13)
        Me.lblNumeroRUC.TabIndex = 12
        Me.lblNumeroRUC.Tag = "OBLIGATORIO"
        Me.lblNumeroRUC.Text = "N�mero RUC:"
        '
        'lblSiglasEmpresa
        '
        Me.lblSiglasEmpresa.AutoSize = True
        Me.lblSiglasEmpresa.Location = New System.Drawing.Point(10, 25)
        Me.lblSiglasEmpresa.Name = "lblSiglasEmpresa"
        Me.lblSiglasEmpresa.Size = New System.Drawing.Size(82, 13)
        Me.lblSiglasEmpresa.TabIndex = 11
        Me.lblSiglasEmpresa.Tag = "OBLIGATORIO"
        Me.lblSiglasEmpresa.Text = "Siglas Empresa:"
        '
        'grpPersonaNatural
        '
        Me.grpPersonaNatural.Controls.Add(Me.chkCedulaNacionalidad)
        Me.grpPersonaNatural.Controls.Add(Me.dtpFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.cmbGenero)
        Me.grpPersonaNatural.Controls.Add(Me.txtCedula)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoNombre)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrefijoTrato)
        Me.grpPersonaNatural.Controls.Add(Me.grpOtrosDatos)
        Me.grpPersonaNatural.Controls.Add(Me.lblFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblGenero)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrefijoTrato)
        Me.grpPersonaNatural.Location = New System.Drawing.Point(16, 31)
        Me.grpPersonaNatural.Name = "grpPersonaNatural"
        Me.grpPersonaNatural.Size = New System.Drawing.Size(341, 366)
        Me.grpPersonaNatural.TabIndex = 2
        Me.grpPersonaNatural.TabStop = False
        Me.grpPersonaNatural.Text = "Persona"
        '
        'chkCedulaNacionalidad
        '
        Me.chkCedulaNacionalidad.AutoSize = True
        Me.chkCedulaNacionalidad.Checked = True
        Me.chkCedulaNacionalidad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCedulaNacionalidad.Location = New System.Drawing.Point(15, 203)
        Me.chkCedulaNacionalidad.Name = "chkCedulaNacionalidad"
        Me.chkCedulaNacionalidad.Size = New System.Drawing.Size(107, 17)
        Me.chkCedulaNacionalidad.TabIndex = 16
        Me.chkCedulaNacionalidad.Text = "C�dula Nacional:"
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
        Me.dtpFechaNacimiento.Calendar.ShowTodayCircle = False
        'Me.dtpFechaNacimiento.Calendar.UIStrings.Content = New String() {"&Clear:&Limpiar", "&Today:&FechaActual"}
        Me.dtpFechaNacimiento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaNacimiento.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtpFechaNacimiento.EmptyAsNull = True
        Me.dtpFechaNacimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(150, 172)
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
        Me.cmbGenero.Images.Add(CType(resources.GetObject("cmbGenero.Images"), System.Drawing.Image))
        Me.cmbGenero.ItemHeight = 15
        Me.cmbGenero.Location = New System.Drawing.Point(150, 145)
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
        Me.txtCedula.Location = New System.Drawing.Point(150, 202)
        Me.txtCedula.Mask = "000-000000-0000L"
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(170, 20)
        Me.txtCedula.TabIndex = 8
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(150, 120)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtSegundoApellido.TabIndex = 5
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(150, 95)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtPrimerApellido.TabIndex = 4
        Me.txtPrimerApellido.Tag = "OBLIGATORIO"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(150, 70)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtSegundoNombre.TabIndex = 3
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(150, 45)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtPrimerNombre.TabIndex = 2
        Me.txtPrimerNombre.Tag = "OBLIGATORIO"
        '
        'txtPrefijoTrato
        '
        Me.txtPrefijoTrato.Location = New System.Drawing.Point(150, 20)
        Me.txtPrefijoTrato.Name = "txtPrefijoTrato"
        Me.txtPrefijoTrato.Size = New System.Drawing.Size(170, 20)
        Me.txtPrefijoTrato.TabIndex = 1
        '
        'grpOtrosDatos
        '
        Me.grpOtrosDatos.Controls.Add(Me.chkExonerado)
        Me.grpOtrosDatos.Controls.Add(Me.cmdCedulaReverso)
        Me.grpOtrosDatos.Controls.Add(Me.cmdCedulaAnverso)
        Me.grpOtrosDatos.Controls.Add(Me.txtCedulaReverso)
        Me.grpOtrosDatos.Controls.Add(Me.txtCedulaAnverso)
        Me.grpOtrosDatos.Controls.Add(Me.cmbOcupacion)
        Me.grpOtrosDatos.Controls.Add(Me.lblOcupacion)
        Me.grpOtrosDatos.Controls.Add(Me.lblCedulaReverso)
        Me.grpOtrosDatos.Controls.Add(Me.lblCedulaAnverso)
        Me.grpOtrosDatos.Location = New System.Drawing.Point(13, 237)
        Me.grpOtrosDatos.Name = "grpOtrosDatos"
        Me.grpOtrosDatos.Size = New System.Drawing.Size(322, 123)
        Me.grpOtrosDatos.TabIndex = 15
        Me.grpOtrosDatos.TabStop = False
        Me.grpOtrosDatos.Text = "Otros Datos"
        '
        'chkExonerado
        '
        Me.chkExonerado.AutoSize = True
        Me.chkExonerado.Location = New System.Drawing.Point(137, 100)
        Me.chkExonerado.Name = "chkExonerado"
        Me.chkExonerado.Size = New System.Drawing.Size(77, 17)
        Me.chkExonerado.TabIndex = 17
        Me.chkExonerado.Tag = "7"
        Me.chkExonerado.Text = "Exonerado"
        Me.chkExonerado.UseVisualStyleBackColor = True
        '
        'cmdCedulaReverso
        '
        Me.cmdCedulaReverso.Location = New System.Drawing.Point(290, 69)
        Me.cmdCedulaReverso.Name = "cmdCedulaReverso"
        Me.cmdCedulaReverso.Size = New System.Drawing.Size(26, 23)
        Me.cmdCedulaReverso.TabIndex = 16
        Me.cmdCedulaReverso.Text = "..."
        Me.cmdCedulaReverso.UseVisualStyleBackColor = True
        '
        'cmdCedulaAnverso
        '
        Me.cmdCedulaAnverso.Location = New System.Drawing.Point(290, 43)
        Me.cmdCedulaAnverso.Name = "cmdCedulaAnverso"
        Me.cmdCedulaAnverso.Size = New System.Drawing.Size(26, 23)
        Me.cmdCedulaAnverso.TabIndex = 15
        Me.cmdCedulaAnverso.Text = "..."
        Me.cmdCedulaAnverso.UseVisualStyleBackColor = True
        '
        'txtCedulaReverso
        '
        Me.txtCedulaReverso.Location = New System.Drawing.Point(137, 71)
        Me.txtCedulaReverso.Name = "txtCedulaReverso"
        Me.txtCedulaReverso.Size = New System.Drawing.Size(147, 20)
        Me.txtCedulaReverso.TabIndex = 14
        Me.txtCedulaReverso.Tag = "BLOQUEADO"
        '
        'txtCedulaAnverso
        '
        Me.txtCedulaAnverso.Location = New System.Drawing.Point(137, 45)
        Me.txtCedulaAnverso.Name = "txtCedulaAnverso"
        Me.txtCedulaAnverso.Size = New System.Drawing.Size(147, 20)
        Me.txtCedulaAnverso.TabIndex = 13
        Me.txtCedulaAnverso.Tag = "BLOQUEADO"
        '
        'cmbOcupacion
        '
        Me.cmbOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOcupacion.FormattingEnabled = True
        Me.cmbOcupacion.Location = New System.Drawing.Point(137, 18)
        Me.cmbOcupacion.Name = "cmbOcupacion"
        Me.cmbOcupacion.Size = New System.Drawing.Size(170, 21)
        Me.cmbOcupacion.TabIndex = 2
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Location = New System.Drawing.Point(14, 27)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(62, 13)
        Me.lblOcupacion.TabIndex = 12
        Me.lblOcupacion.Text = "Ocupaci�n:"
        '
        'lblCedulaReverso
        '
        Me.lblCedulaReverso.AutoSize = True
        Me.lblCedulaReverso.Location = New System.Drawing.Point(14, 74)
        Me.lblCedulaReverso.Name = "lblCedulaReverso"
        Me.lblCedulaReverso.Size = New System.Drawing.Size(86, 13)
        Me.lblCedulaReverso.TabIndex = 11
        Me.lblCedulaReverso.Text = "C�dula Reverso:"
        '
        'lblCedulaAnverso
        '
        Me.lblCedulaAnverso.AutoSize = True
        Me.lblCedulaAnverso.Location = New System.Drawing.Point(14, 51)
        Me.lblCedulaAnverso.Name = "lblCedulaAnverso"
        Me.lblCedulaAnverso.Size = New System.Drawing.Size(85, 13)
        Me.lblCedulaAnverso.TabIndex = 10
        Me.lblCedulaAnverso.Text = "C�dula Anverso:"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(10, 175)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaNacimiento.TabIndex = 14
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Location = New System.Drawing.Point(10, 125)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(93, 13)
        Me.lblSegundoApellido.TabIndex = 12
        Me.lblSegundoApellido.Text = "Segundo Apellido:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(10, 150)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(45, 13)
        Me.lblGenero.TabIndex = 11
        Me.lblGenero.Tag = "OBLIGATORIO"
        Me.lblGenero.Text = "G�nero:"
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Location = New System.Drawing.Point(10, 100)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(79, 13)
        Me.lblPrimerApellido.TabIndex = 10
        Me.lblPrimerApellido.Tag = "OBLIGATORIO"
        Me.lblPrimerApellido.Text = "Primer Apellido:"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Location = New System.Drawing.Point(10, 50)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(79, 13)
        Me.lblPrimerNombre.TabIndex = 9
        Me.lblPrimerNombre.Tag = "OBLIGATORIO"
        Me.lblPrimerNombre.Text = "Primer Nombre:"
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Location = New System.Drawing.Point(10, 75)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(93, 13)
        Me.lblSegundoNombre.TabIndex = 8
        Me.lblSegundoNombre.Text = "Segundo Nombre:"
        '
        'lblPrefijoTrato
        '
        Me.lblPrefijoTrato.AutoSize = True
        Me.lblPrefijoTrato.Location = New System.Drawing.Point(10, 25)
        Me.lblPrefijoTrato.Name = "lblPrefijoTrato"
        Me.lblPrefijoTrato.Size = New System.Drawing.Size(67, 13)
        Me.lblPrefijoTrato.TabIndex = 7
        Me.lblPrefijoTrato.Text = "Prefijo Trato:"
        '
        'chkPersonaJuridica
        '
        Me.chkPersonaJuridica.AutoSize = True
        Me.chkPersonaJuridica.Location = New System.Drawing.Point(16, 15)
        Me.chkPersonaJuridica.Name = "chkPersonaJuridica"
        Me.chkPersonaJuridica.Size = New System.Drawing.Size(106, 17)
        Me.chkPersonaJuridica.TabIndex = 1
        Me.chkPersonaJuridica.Text = "Persona Jur�dica"
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
        'cmdConsultarCedula
        '
        Me.cmdConsultarCedula.Enabled = False
        Me.cmdConsultarCedula.Image = CType(resources.GetObject("cmdConsultarCedula.Image"), System.Drawing.Image)
        Me.cmdConsultarCedula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdConsultarCedula.Location = New System.Drawing.Point(451, 449)
        Me.cmdConsultarCedula.Name = "cmdConsultarCedula"
        Me.cmdConsultarCedula.Size = New System.Drawing.Size(81, 29)
        Me.cmdConsultarCedula.TabIndex = 3
        Me.cmdConsultarCedula.Text = "C&edula"
        Me.cmdConsultarCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdConsultarCedula.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 32)
        Me.Panel2.TabIndex = 27
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(627, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 485)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 16)
        Me.Panel1.TabIndex = 26
        '
        'frmStbPersonasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 501)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdConsultarCedula)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.grpDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbPersonasEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
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
        CType(Me.dtpFechaConstitucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonaNatural.ResumeLayout(False)
        Me.grpPersonaNatural.PerformLayout()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOtrosDatos.ResumeLayout(False)
        Me.grpOtrosDatos.PerformLayout()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents chkPersonaJuridica As System.Windows.Forms.CheckBox
    Friend WithEvents grpPersonaNatural As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpPersonaJuridica As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrimerNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoNombre As System.Windows.Forms.Label
    Friend WithEvents lblPrefijoTrato As System.Windows.Forms.Label
    Friend WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents grpOtrosDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblOcupacion As System.Windows.Forms.Label
    Friend WithEvents lblCedulaReverso As System.Windows.Forms.Label
    Friend WithEvents lblCedulaAnverso As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents lblFechaConstitucion As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRUC As System.Windows.Forms.Label
    Friend WithEvents lblSiglasEmpresa As System.Windows.Forms.Label
    Friend WithEvents tabAdicionales As System.Windows.Forms.TabControl
    Friend WithEvents tabContactos As System.Windows.Forms.TabPage
    Friend WithEvents txtPrefijoTrato As System.Windows.Forms.TextBox
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
    Friend WithEvents cmbOcupacion As System.Windows.Forms.ComboBox
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbGenero As C1.Win.C1List.C1Combo
    Friend WithEvents dtpFechaConstitucion As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtCedulaReverso As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaAnverso As System.Windows.Forms.TextBox
    Friend WithEvents ArchivoDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdCedulaReverso As System.Windows.Forms.Button
    Friend WithEvents cmdCedulaAnverso As System.Windows.Forms.Button
    Friend WithEvents cmdConsultarCedula As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents dtpFechaNacimiento As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkCedulaNacionalidad As System.Windows.Forms.CheckBox
    Friend WithEvents chkExonerado As System.Windows.Forms.CheckBox
End Class