<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbRutasEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbRutasEdit))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbCiudad = New C1.Win.C1List.C1Combo()
        Me.cmbSupervisor = New C1.Win.C1List.C1Combo()
        Me.cbxCobrador = New C1.Win.C1List.C1Combo()
        Me.cmdAgregarCategoria = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ckdCargaDiferenciada = New System.Windows.Forms.CheckBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.cmbDiaCrobro = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCilindraje = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupervisor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCobrador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDiaCrobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmbCiudad)
        Me.PanelControl1.Controls.Add(Me.cmbSupervisor)
        Me.PanelControl1.Controls.Add(Me.cbxCobrador)
        Me.PanelControl1.Controls.Add(Me.cmdAgregarCategoria)
        Me.PanelControl1.Controls.Add(Me.txtDescripcion)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.txtCodigo)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.ckdCargaDiferenciada)
        Me.PanelControl1.Controls.Add(Me.chkActivo)
        Me.PanelControl1.Controls.Add(Me.cmbDiaCrobro)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.txtNombre)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.lblCilindraje)
        Me.PanelControl1.Controls.Add(Me.lblMarca)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(746, 250)
        Me.PanelControl1.TabIndex = 25
        '
        'cmbCiudad
        '
        Me.cmbCiudad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCiudad.AutoCompletion = True
        Me.cmbCiudad.AutoDropDown = True
        Me.cmbCiudad.Caption = ""
        Me.cmbCiudad.CaptionHeight = 17
        Me.cmbCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCiudad.ColumnCaptionHeight = 17
        Me.cmbCiudad.ColumnFooterHeight = 17
        Me.cmbCiudad.ContentHeight = 15
        Me.cmbCiudad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCiudad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCiudad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiudad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCiudad.EditorHeight = 15
        Me.cmbCiudad.Images.Add(CType(resources.GetObject("cmbCiudad.Images"), System.Drawing.Image))
        Me.cmbCiudad.ItemHeight = 15
        Me.cmbCiudad.Location = New System.Drawing.Point(518, 28)
        Me.cmbCiudad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCiudad.MaxDropDownItems = CType(5, Short)
        Me.cmbCiudad.MaxLength = 32767
        Me.cmbCiudad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCiudad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCiudad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCiudad.Size = New System.Drawing.Size(172, 21)
        Me.cmbCiudad.TabIndex = 135
        Me.cmbCiudad.Tag = "OBLIGATORIO"
        Me.cmbCiudad.PropBag = resources.GetString("cmbCiudad.PropBag")
        '
        'cmbSupervisor
        '
        Me.cmbSupervisor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSupervisor.AutoCompletion = True
        Me.cmbSupervisor.AutoDropDown = True
        Me.cmbSupervisor.Caption = ""
        Me.cmbSupervisor.CaptionHeight = 17
        Me.cmbSupervisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSupervisor.ColumnCaptionHeight = 17
        Me.cmbSupervisor.ColumnFooterHeight = 17
        Me.cmbSupervisor.ContentHeight = 15
        Me.cmbSupervisor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSupervisor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSupervisor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupervisor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSupervisor.EditorHeight = 15
        Me.cmbSupervisor.Images.Add(CType(resources.GetObject("cmbSupervisor.Images"), System.Drawing.Image))
        Me.cmbSupervisor.ItemHeight = 15
        Me.cmbSupervisor.Location = New System.Drawing.Point(107, 176)
        Me.cmbSupervisor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSupervisor.MaxDropDownItems = CType(5, Short)
        Me.cmbSupervisor.MaxLength = 32767
        Me.cmbSupervisor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSupervisor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSupervisor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSupervisor.Size = New System.Drawing.Size(279, 21)
        Me.cmbSupervisor.TabIndex = 134
        Me.cmbSupervisor.Tag = "OBLIGATORIO"
        Me.cmbSupervisor.PropBag = resources.GetString("cmbSupervisor.PropBag")
        '
        'cbxCobrador
        '
        Me.cbxCobrador.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cbxCobrador.AutoCompletion = True
        Me.cbxCobrador.AutoDropDown = True
        Me.cbxCobrador.Caption = ""
        Me.cbxCobrador.CaptionHeight = 17
        Me.cbxCobrador.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbxCobrador.ColumnCaptionHeight = 17
        Me.cbxCobrador.ColumnFooterHeight = 17
        Me.cbxCobrador.ContentHeight = 15
        Me.cbxCobrador.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cbxCobrador.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cbxCobrador.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCobrador.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cbxCobrador.EditorHeight = 15
        Me.cbxCobrador.Images.Add(CType(resources.GetObject("cbxCobrador.Images"), System.Drawing.Image))
        Me.cbxCobrador.ItemHeight = 15
        Me.cbxCobrador.Location = New System.Drawing.Point(107, 149)
        Me.cbxCobrador.MatchEntryTimeout = CType(2000, Long)
        Me.cbxCobrador.MaxDropDownItems = CType(5, Short)
        Me.cbxCobrador.MaxLength = 32767
        Me.cbxCobrador.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cbxCobrador.Name = "cbxCobrador"
        Me.cbxCobrador.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cbxCobrador.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cbxCobrador.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cbxCobrador.Size = New System.Drawing.Size(279, 21)
        Me.cbxCobrador.TabIndex = 133
        Me.cbxCobrador.Tag = "OBLIGATORIO"
        Me.cbxCobrador.PropBag = resources.GetString("cbxCobrador.PropBag")
        '
        'cmdAgregarCategoria
        '
        Me.cmdAgregarCategoria.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarCategoria.Appearance.Options.UseFont = True
        Me.cmdAgregarCategoria.Image = CType(resources.GetObject("cmdAgregarCategoria.Image"), System.Drawing.Image)
        Me.cmdAgregarCategoria.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregarCategoria.Location = New System.Drawing.Point(696, 25)
        Me.cmdAgregarCategoria.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregarCategoria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregarCategoria.Name = "cmdAgregarCategoria"
        Me.cmdAgregarCategoria.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarCategoria.TabIndex = 132
        Me.cmdAgregarCategoria.Tag = "AGREGAR CATEGORIA"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(107, 88)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(279, 48)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.Tag = "OBLIGATORIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Tag = ""
        Me.Label5.Text = "Descripcion:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(107, 29)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(170, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Tag = "OBLIGATORIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Tag = "OBLIGATORIO"
        Me.Label4.Text = "Codigo:"
        '
        'ckdCargaDiferenciada
        '
        Me.ckdCargaDiferenciada.AutoSize = True
        Me.ckdCargaDiferenciada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckdCargaDiferenciada.Location = New System.Drawing.Point(430, 119)
        Me.ckdCargaDiferenciada.Name = "ckdCargaDiferenciada"
        Me.ckdCargaDiferenciada.Size = New System.Drawing.Size(135, 17)
        Me.ckdCargaDiferenciada.TabIndex = 8
        Me.ckdCargaDiferenciada.Text = "Cobro Diferenciado"
        Me.ckdCargaDiferenciada.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(430, 91)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 7
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'cmbDiaCrobro
        '
        Me.cmbDiaCrobro.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbDiaCrobro.AutoCompletion = True
        Me.cmbDiaCrobro.AutoDropDown = True
        Me.cmbDiaCrobro.Caption = ""
        Me.cmbDiaCrobro.CaptionHeight = 17
        Me.cmbDiaCrobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbDiaCrobro.ColumnCaptionHeight = 17
        Me.cmbDiaCrobro.ColumnFooterHeight = 17
        Me.cmbDiaCrobro.ContentHeight = 15
        Me.cmbDiaCrobro.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbDiaCrobro.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbDiaCrobro.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDiaCrobro.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDiaCrobro.EditorHeight = 15
        Me.cmbDiaCrobro.Images.Add(CType(resources.GetObject("cmbDiaCrobro.Images"), System.Drawing.Image))
        Me.cmbDiaCrobro.ItemHeight = 15
        Me.cmbDiaCrobro.Location = New System.Drawing.Point(518, 57)
        Me.cmbDiaCrobro.MatchEntryTimeout = CType(2000, Long)
        Me.cmbDiaCrobro.MaxDropDownItems = CType(5, Short)
        Me.cmbDiaCrobro.MaxLength = 32767
        Me.cmbDiaCrobro.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbDiaCrobro.Name = "cmbDiaCrobro"
        Me.cmbDiaCrobro.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbDiaCrobro.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbDiaCrobro.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbDiaCrobro.Size = New System.Drawing.Size(172, 21)
        Me.cmbDiaCrobro.TabIndex = 6
        Me.cmbDiaCrobro.Tag = "OBLIGATORIO"
        Me.cmbDiaCrobro.PropBag = resources.GetString("cmbDiaCrobro.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(427, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Tag = "OBLIGATORIO"
        Me.Label3.Text = "Dia de Cobro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Supervisor:"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(107, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(279, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Tag = "OBLIGATORIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Nombre:"
        '
        'lblCilindraje
        '
        Me.lblCilindraje.AutoSize = True
        Me.lblCilindraje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCilindraje.Location = New System.Drawing.Point(427, 29)
        Me.lblCilindraje.Name = "lblCilindraje"
        Me.lblCilindraje.Size = New System.Drawing.Size(40, 13)
        Me.lblCilindraje.TabIndex = 19
        Me.lblCilindraje.Tag = "OBLIGATORIO"
        Me.lblCilindraje.Text = "Zona:"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(16, 157)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(62, 13)
        Me.lblMarca.TabIndex = 17
        Me.lblMarca.Tag = "OBLIGATORIO"
        Me.lblMarca.Text = "Cobrador:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(636, 184)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(550, 184)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 229)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 21)
        Me.Panel1.TabIndex = 26
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'frmStbRutasEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 250)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbRutasEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registar Rutas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupervisor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCobrador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDiaCrobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCilindraje As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents cmbDiaCrobro As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckdCargaDiferenciada As System.Windows.Forms.CheckBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmdAgregarCategoria As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCiudad As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSupervisor As C1.Win.C1List.C1Combo
    Friend WithEvents cbxCobrador As C1.Win.C1List.C1Combo
End Class
