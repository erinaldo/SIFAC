<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSrhEmpleadoEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSrhEmpleadoEditar))
        Me.grbDatosGenerales = New System.Windows.Forms.GroupBox
        Me.cmdConsultar = New System.Windows.Forms.Button
        Me.txtGenero = New System.Windows.Forms.TextBox
        Me.txtApellido2 = New System.Windows.Forms.TextBox
        Me.txtApellido1 = New System.Windows.Forms.TextBox
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.txtNombre2 = New System.Windows.Forms.TextBox
        Me.txtNombre1 = New System.Windows.Forms.TextBox
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.txtPersonaID = New System.Windows.Forms.TextBox
        Me.lblGenero = New System.Windows.Forms.Label
        Me.lblApellido2 = New System.Windows.Forms.Label
        Me.lblApellido1 = New System.Windows.Forms.Label
        Me.lblCedula = New System.Windows.Forms.Label
        Me.lblNombre2 = New System.Windows.Forms.Label
        Me.lblNombre1 = New System.Windows.Forms.Label
        Me.lblPersonaID = New System.Windows.Forms.Label
        Me.grbRH = New System.Windows.Forms.GroupBox
        Me.spnComision = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFechaEgreso = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaIngreso = New C1.Win.C1Input.C1DateEdit
        Me.cmbCargo = New C1.Win.C1List.C1Combo
        Me.lblFechaEgreso = New System.Windows.Forms.Label
        Me.lblFechaIngreso = New System.Windows.Forms.Label
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.lblCargo = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdEditarInfo = New System.Windows.Forms.Button
        Me.grbDatosGenerales.SuspendLayout()
        Me.grbRH.SuspendLayout()
        CType(Me.spnComision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbDatosGenerales
        '
        Me.grbDatosGenerales.Controls.Add(Me.cmdConsultar)
        Me.grbDatosGenerales.Controls.Add(Me.txtGenero)
        Me.grbDatosGenerales.Controls.Add(Me.txtApellido2)
        Me.grbDatosGenerales.Controls.Add(Me.txtApellido1)
        Me.grbDatosGenerales.Controls.Add(Me.txtCedula)
        Me.grbDatosGenerales.Controls.Add(Me.txtNombre2)
        Me.grbDatosGenerales.Controls.Add(Me.txtNombre1)
        Me.grbDatosGenerales.Controls.Add(Me.cmdBuscar)
        Me.grbDatosGenerales.Controls.Add(Me.txtPersonaID)
        Me.grbDatosGenerales.Controls.Add(Me.lblGenero)
        Me.grbDatosGenerales.Controls.Add(Me.lblApellido2)
        Me.grbDatosGenerales.Controls.Add(Me.lblApellido1)
        Me.grbDatosGenerales.Controls.Add(Me.lblCedula)
        Me.grbDatosGenerales.Controls.Add(Me.lblNombre2)
        Me.grbDatosGenerales.Controls.Add(Me.lblNombre1)
        Me.grbDatosGenerales.Controls.Add(Me.lblPersonaID)
        Me.grbDatosGenerales.Location = New System.Drawing.Point(12, 38)
        Me.grbDatosGenerales.Name = "grbDatosGenerales"
        Me.grbDatosGenerales.Size = New System.Drawing.Size(571, 127)
        Me.grbDatosGenerales.TabIndex = 0
        Me.grbDatosGenerales.TabStop = False
        Me.grbDatosGenerales.Text = "Datos Generales"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdConsultar.Location = New System.Drawing.Point(544, 21)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(24, 23)
        Me.cmdConsultar.TabIndex = 15
        Me.cmdConsultar.Text = "..."
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(386, 97)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(161, 20)
        Me.txtGenero.TabIndex = 14
        Me.txtGenero.Tag = "BLOQUEADO"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(386, 72)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(161, 20)
        Me.txtApellido2.TabIndex = 13
        Me.txtApellido2.Tag = "BLOQUEADO"
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(386, 47)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(161, 20)
        Me.txtApellido1.TabIndex = 12
        Me.txtApellido1.Tag = "BLOQUEADO"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(115, 97)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(161, 20)
        Me.txtCedula.TabIndex = 11
        Me.txtCedula.Tag = "BLOQUEADO"
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(115, 72)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(161, 20)
        Me.txtNombre2.TabIndex = 10
        Me.txtNombre2.Tag = "BLOQUEADO"
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(115, 47)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(161, 20)
        Me.txtNombre1.TabIndex = 9
        Me.txtNombre1.Tag = "BLOQUEADO"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(519, 21)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(24, 23)
        Me.cmdBuscar.TabIndex = 8
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtPersonaID
        '
        Me.txtPersonaID.Location = New System.Drawing.Point(115, 23)
        Me.txtPersonaID.Name = "txtPersonaID"
        Me.txtPersonaID.Size = New System.Drawing.Size(402, 20)
        Me.txtPersonaID.TabIndex = 7
        Me.txtPersonaID.Tag = "BLOQUEADO"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(282, 100)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(45, 13)
        Me.lblGenero.TabIndex = 6
        Me.lblGenero.Text = "Género:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(282, 75)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(93, 13)
        Me.lblApellido2.TabIndex = 5
        Me.lblApellido2.Text = "Segundo Apellido:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(282, 50)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(79, 13)
        Me.lblApellido1.TabIndex = 4
        Me.lblApellido1.Text = "Primer Apellido:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(17, 100)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(43, 13)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Cédula:"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Location = New System.Drawing.Point(17, 75)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(93, 13)
        Me.lblNombre2.TabIndex = 2
        Me.lblNombre2.Text = "Segundo Nombre:"
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Location = New System.Drawing.Point(17, 50)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(79, 13)
        Me.lblNombre1.TabIndex = 1
        Me.lblNombre1.Text = "Primer Nombre:"
        '
        'lblPersonaID
        '
        Me.lblPersonaID.AutoSize = True
        Me.lblPersonaID.Location = New System.Drawing.Point(17, 26)
        Me.lblPersonaID.Name = "lblPersonaID"
        Me.lblPersonaID.Size = New System.Drawing.Size(71, 13)
        Me.lblPersonaID.TabIndex = 0
        Me.lblPersonaID.Text = "Empleado ID:"
        '
        'grbRH
        '
        Me.grbRH.Controls.Add(Me.spnComision)
        Me.grbRH.Controls.Add(Me.Label1)
        Me.grbRH.Controls.Add(Me.dtpFechaEgreso)
        Me.grbRH.Controls.Add(Me.dtpFechaIngreso)
        Me.grbRH.Controls.Add(Me.cmbCargo)
        Me.grbRH.Controls.Add(Me.lblFechaEgreso)
        Me.grbRH.Controls.Add(Me.lblFechaIngreso)
        Me.grbRH.Controls.Add(Me.chkActivo)
        Me.grbRH.Controls.Add(Me.lblCargo)
        Me.grbRH.Location = New System.Drawing.Point(12, 171)
        Me.grbRH.Name = "grbRH"
        Me.grbRH.Size = New System.Drawing.Size(571, 78)
        Me.grbRH.TabIndex = 1
        Me.grbRH.TabStop = False
        Me.grbRH.Text = "Recursos Humanos"
        '
        'spnComision
        '
        Me.spnComision.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnComision.Location = New System.Drawing.Point(175, 46)
        Me.spnComision.Name = "spnComision"
        Me.spnComision.Properties.DisplayFormat.FormatString = "$#,##0.00"
        Me.spnComision.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.spnComision.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnComision.Properties.MaxValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnComision.Properties.UseCtrlIncrement = False
        Me.spnComision.Size = New System.Drawing.Size(101, 20)
        Me.spnComision.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "% Comisión"
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.DisplayFormat.EmptyAsNull = False
        Me.dtpFechaEgreso.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEgreso.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaEgreso.EditFormat.EmptyAsNull = False
        Me.dtpFechaEgreso.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEgreso.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaEgreso.EmptyAsNull = True
        Me.dtpFechaEgreso.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(386, 44)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(161, 20)
        Me.dtpFechaEgreso.TabIndex = 8
        Me.dtpFechaEgreso.Tag = Nothing
        Me.dtpFechaEgreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaIngreso.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaIngreso.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(386, 20)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(161, 20)
        Me.dtpFechaIngreso.TabIndex = 7
        Me.dtpFechaIngreso.Tag = Nothing
        Me.dtpFechaIngreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cmbCargo
        '
        Me.cmbCargo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCargo.Caption = ""
        Me.cmbCargo.CaptionHeight = 17
        Me.cmbCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCargo.ColumnCaptionHeight = 17
        Me.cmbCargo.ColumnFooterHeight = 17
        Me.cmbCargo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCargo.ContentHeight = 15
        Me.cmbCargo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCargo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCargo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCargo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCargo.EditorHeight = 15
        Me.cmbCargo.Images.Add(CType(resources.GetObject("cmbCargo.Images"), System.Drawing.Image))
        Me.cmbCargo.ItemHeight = 15
        Me.cmbCargo.Location = New System.Drawing.Point(115, 19)
        Me.cmbCargo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCargo.MaxDropDownItems = CType(5, Short)
        Me.cmbCargo.MaxLength = 32767
        Me.cmbCargo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCargo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCargo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCargo.Size = New System.Drawing.Size(161, 21)
        Me.cmbCargo.TabIndex = 6
        Me.cmbCargo.PropBag = resources.GetString("cmbCargo.PropBag")
        '
        'lblFechaEgreso
        '
        Me.lblFechaEgreso.AutoSize = True
        Me.lblFechaEgreso.Location = New System.Drawing.Point(282, 46)
        Me.lblFechaEgreso.Name = "lblFechaEgreso"
        Me.lblFechaEgreso.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaEgreso.TabIndex = 3
        Me.lblFechaEgreso.Text = "Fecha Egreso:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(282, 23)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaIngreso.TabIndex = 2
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(10, 44)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 1
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(10, 23)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(38, 13)
        Me.lblCargo.TabIndex = 0
        Me.lblCargo.Text = "Cargo:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(426, 256)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(507, 256)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 32)
        Me.Panel2.TabIndex = 27
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(512, -1)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 290)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 16)
        Me.Panel1.TabIndex = 26
        '
        'cmdEditarInfo
        '
        Me.cmdEditarInfo.BackgroundImage = Global.SIFAC.My.Resources.Resources.IniciarSesion1
        Me.cmdEditarInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEditarInfo.Enabled = False
        Me.cmdEditarInfo.Location = New System.Drawing.Point(376, 256)
        Me.cmdEditarInfo.Name = "cmdEditarInfo"
        Me.cmdEditarInfo.Size = New System.Drawing.Size(44, 28)
        Me.cmdEditarInfo.TabIndex = 28
        Me.cmdEditarInfo.Tag = ""
        Me.cmdEditarInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEditarInfo.UseVisualStyleBackColor = True
        '
        'frmSrhEmpleadoEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 306)
        Me.Controls.Add(Me.cmdEditarInfo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grbRH)
        Me.Controls.Add(Me.grbDatosGenerales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSrhEmpleadoEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Empleado"
        Me.grbDatosGenerales.ResumeLayout(False)
        Me.grbDatosGenerales.PerformLayout()
        Me.grbRH.ResumeLayout(False)
        Me.grbRH.PerformLayout()
        CType(Me.spnComision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEgreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents grbRH As System.Windows.Forms.GroupBox
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtPersonaID As System.Windows.Forms.TextBox
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblNombre2 As System.Windows.Forms.Label
    Friend WithEvents lblNombre1 As System.Windows.Forms.Label
    Friend WithEvents lblPersonaID As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblFechaEgreso As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents cmbCargo As C1.Win.C1List.C1Combo
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents dtpFechaEgreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaIngreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents cmdEditarInfo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents spnComision As DevExpress.XtraEditors.SpinEdit
End Class
