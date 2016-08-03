<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbPersonaBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbPersonaBuscar))
        Me.grbOpciones = New System.Windows.Forms.GroupBox
        Me.cmbGenero = New C1.Win.C1List.C1Combo
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTipoPersona = New C1.Win.C1List.C1Combo
        Me.lblTipoPersona = New System.Windows.Forms.Label
        Me.txtCedula = New System.Windows.Forms.MaskedTextBox
        Me.chkCedula = New System.Windows.Forms.CheckBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grbOpciones.SuspendLayout()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbOpciones
        '
        Me.grbOpciones.Controls.Add(Me.cmbGenero)
        Me.grbOpciones.Controls.Add(Me.Label1)
        Me.grbOpciones.Controls.Add(Me.cmbTipoPersona)
        Me.grbOpciones.Controls.Add(Me.lblTipoPersona)
        Me.grbOpciones.Controls.Add(Me.txtCedula)
        Me.grbOpciones.Controls.Add(Me.chkCedula)
        Me.grbOpciones.Location = New System.Drawing.Point(3, 38)
        Me.grbOpciones.Name = "grbOpciones"
        Me.grbOpciones.Size = New System.Drawing.Size(292, 108)
        Me.grbOpciones.TabIndex = 0
        Me.grbOpciones.TabStop = False
        Me.grbOpciones.Text = "Opciones de busqueda"
        '
        'cmbGenero
        '
        Me.cmbGenero.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGenero.Caption = ""
        Me.cmbGenero.CaptionHeight = 17
        Me.cmbGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGenero.ColumnCaptionHeight = 17
        Me.cmbGenero.ColumnFooterHeight = 17
        Me.cmbGenero.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbGenero.ContentHeight = 15
        Me.cmbGenero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGenero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGenero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGenero.EditorHeight = 15
        Me.cmbGenero.Enabled = False
        Me.cmbGenero.Images.Add(CType(resources.GetObject("cmbGenero.Images"), System.Drawing.Image))
        Me.cmbGenero.ItemHeight = 15
        Me.cmbGenero.Location = New System.Drawing.Point(80, 76)
        Me.cmbGenero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGenero.MaxDropDownItems = CType(5, Short)
        Me.cmbGenero.MaxLength = 32767
        Me.cmbGenero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGenero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGenero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGenero.Size = New System.Drawing.Size(191, 21)
        Me.cmbGenero.TabIndex = 5
        Me.cmbGenero.PropBag = resources.GetString("cmbGenero.PropBag")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Genero"
        '
        'cmbTipoPersona
        '
        Me.cmbTipoPersona.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoPersona.Caption = ""
        Me.cmbTipoPersona.CaptionHeight = 17
        Me.cmbTipoPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoPersona.ColumnCaptionHeight = 17
        Me.cmbTipoPersona.ColumnFooterHeight = 17
        Me.cmbTipoPersona.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoPersona.ContentHeight = 15
        Me.cmbTipoPersona.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoPersona.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoPersona.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPersona.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoPersona.EditorHeight = 15
        Me.cmbTipoPersona.Enabled = False
        Me.cmbTipoPersona.Images.Add(CType(resources.GetObject("cmbTipoPersona.Images"), System.Drawing.Image))
        Me.cmbTipoPersona.ItemHeight = 15
        Me.cmbTipoPersona.Location = New System.Drawing.Point(80, 47)
        Me.cmbTipoPersona.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoPersona.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoPersona.MaxLength = 32767
        Me.cmbTipoPersona.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoPersona.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.Size = New System.Drawing.Size(189, 21)
        Me.cmbTipoPersona.TabIndex = 3
        Me.cmbTipoPersona.PropBag = resources.GetString("cmbTipoPersona.PropBag")
        '
        'lblTipoPersona
        '
        Me.lblTipoPersona.AutoSize = True
        Me.lblTipoPersona.Location = New System.Drawing.Point(10, 50)
        Me.lblTipoPersona.Name = "lblTipoPersona"
        Me.lblTipoPersona.Size = New System.Drawing.Size(69, 13)
        Me.lblTipoPersona.TabIndex = 2
        Me.lblTipoPersona.Text = "Tipo persona"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(80, 18)
        Me.txtCedula.Mask = "000-000000-0000L"
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(191, 20)
        Me.txtCedula.TabIndex = 1
        '
        'chkCedula
        '
        Me.chkCedula.AutoSize = True
        Me.chkCedula.Checked = True
        Me.chkCedula.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCedula.Location = New System.Drawing.Point(13, 21)
        Me.chkCedula.Name = "chkCedula"
        Me.chkCedula.Size = New System.Drawing.Size(59, 17)
        Me.chkCedula.TabIndex = 0
        Me.chkCedula.Text = "Cedula"
        Me.chkCedula.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(139, 151)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 25)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(220, 151)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 25)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(305, 28)
        Me.Panel2.TabIndex = 27
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(233, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(663, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "UM"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 16)
        Me.Panel1.TabIndex = 26
        '
        'frmStbPersonaBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 199)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grbOpciones)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbPersonaBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Personas"
        Me.grbOpciones.ResumeLayout(False)
        Me.grbOpciones.PerformLayout()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents txtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chkCedula As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmbTipoPersona As C1.Win.C1List.C1Combo
    Friend WithEvents lblTipoPersona As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbGenero As C1.Win.C1List.C1Combo
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
