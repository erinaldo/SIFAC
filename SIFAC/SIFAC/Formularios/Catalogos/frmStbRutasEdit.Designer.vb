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
        Me.cmbSupervisor = New System.Windows.Forms.ComboBox()
        Me.cbxCobrador = New System.Windows.Forms.ComboBox()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbDiaCrobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmbCiudad)
        Me.PanelControl1.Controls.Add(Me.cbxCobrador)
        Me.PanelControl1.Controls.Add(Me.cmbSupervisor)
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
        Me.PanelControl1.Size = New System.Drawing.Size(735, 250)
        Me.PanelControl1.TabIndex = 25
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
        Me.cmbDiaCrobro.Caption = ""
        Me.cmbDiaCrobro.CaptionHeight = 17
        Me.cmbDiaCrobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbDiaCrobro.ColumnCaptionHeight = 17
        Me.cmbDiaCrobro.ColumnFooterHeight = 17
        Me.cmbDiaCrobro.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
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
        Me.lblCilindraje.Size = New System.Drawing.Size(50, 13)
        Me.lblCilindraje.TabIndex = 19
        Me.lblCilindraje.Tag = "OBLIGATORIO"
        Me.lblCilindraje.Text = "Ciudad:"
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
        Me.Panel1.Size = New System.Drawing.Size(735, 21)
        Me.Panel1.TabIndex = 26
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'cmbSupervisor
        '
        Me.cmbSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupervisor.FormattingEnabled = True
        Me.cmbSupervisor.Location = New System.Drawing.Point(107, 181)
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.Size = New System.Drawing.Size(279, 21)
        Me.cmbSupervisor.TabIndex = 129
        '
        'cbxCobrador
        '
        Me.cbxCobrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCobrador.FormattingEnabled = True
        Me.cbxCobrador.Location = New System.Drawing.Point(107, 153)
        Me.cbxCobrador.Name = "cbxCobrador"
        Me.cbxCobrador.Size = New System.Drawing.Size(279, 21)
        Me.cbxCobrador.TabIndex = 130
        '
        'cmbCiudad
        '
        Me.cmbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(518, 26)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(172, 21)
        Me.cmbCiudad.TabIndex = 131
        '
        'frmStbRutasEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 250)
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
    Friend WithEvents cbxCobrador As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSupervisor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
End Class
