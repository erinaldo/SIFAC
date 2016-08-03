<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbBuscarBitacora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbBuscarBitacora))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.txtCedula = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNumExp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbUsuario = New C1.Win.C1List.C1Combo
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpFechFinSeg = New C1.Win.C1Input.C1DateEdit
        Me.dtpFecIniSeg = New C1.Win.C1Input.C1DateEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cmbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFechFinSeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecIniSeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(262, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
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
        Me.Panel2.Size = New System.Drawing.Size(337, 30)
        Me.Panel2.TabIndex = 10
        Me.Panel2.Tag = "LAYOUT"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 20)
        Me.Panel1.TabIndex = 13
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(249, 230)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 29)
        Me.cmdCancelar.TabIndex = 15
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(168, 230)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 29)
        Me.cmdAceptar.TabIndex = 14
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(108, 78)
        Me.txtCedula.Mask = "000-000000-0000L"
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(209, 20)
        Me.txtCedula.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Cédula Cliente:"
        '
        'txtNumExp
        '
        Me.txtNumExp.Location = New System.Drawing.Point(108, 48)
        Me.txtNumExp.Name = "txtNumExp"
        Me.txtNumExp.Size = New System.Drawing.Size(210, 20)
        Me.txtNumExp.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "No Expediente:"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUsuario.Caption = ""
        Me.cmbUsuario.CaptionHeight = 17
        Me.cmbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUsuario.ColumnCaptionHeight = 17
        Me.cmbUsuario.ColumnFooterHeight = 17
        Me.cmbUsuario.ContentHeight = 15
        Me.cmbUsuario.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUsuario.DropDownWidth = 250
        Me.cmbUsuario.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUsuario.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsuario.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUsuario.EditorHeight = 15
        Me.cmbUsuario.Images.Add(CType(resources.GetObject("cmbUsuario.Images"), System.Drawing.Image))
        Me.cmbUsuario.ItemHeight = 15
        Me.cmbUsuario.LimitToList = True
        Me.cmbUsuario.Location = New System.Drawing.Point(108, 109)
        Me.cmbUsuario.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUsuario.MaxDropDownItems = CType(5, Short)
        Me.cmbUsuario.MaxLength = 32767
        Me.cmbUsuario.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUsuario.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUsuario.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUsuario.Size = New System.Drawing.Size(209, 21)
        Me.cmbUsuario.TabIndex = 111
        Me.cmbUsuario.Tag = ""
        Me.cmbUsuario.PropBag = resources.GetString("cmbUsuario.PropBag")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(25, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 112
        Me.Label19.Tag = ""
        Me.Label19.Text = "Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechFinSeg)
        Me.GroupBox1.Controls.Add(Me.dtpFecIniSeg)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 79)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Períodos"
        '
        'dtpFechFinSeg
        '
        Me.dtpFechFinSeg.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechFinSeg.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechFinSeg.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechFinSeg.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechFinSeg.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechFinSeg.Location = New System.Drawing.Point(85, 43)
        Me.dtpFechFinSeg.Name = "dtpFechFinSeg"
        Me.dtpFechFinSeg.Size = New System.Drawing.Size(208, 20)
        Me.dtpFechFinSeg.TabIndex = 114
        Me.dtpFechFinSeg.Tag = "BLOQUEADO"
        Me.dtpFechFinSeg.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFecIniSeg
        '
        Me.dtpFecIniSeg.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecIniSeg.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecIniSeg.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecIniSeg.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecIniSeg.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecIniSeg.Location = New System.Drawing.Point(84, 17)
        Me.dtpFecIniSeg.Name = "dtpFecIniSeg"
        Me.dtpFecIniSeg.Size = New System.Drawing.Size(209, 20)
        Me.dtpFecIniSeg.TabIndex = 113
        Me.dtpFecIniSeg.Tag = Nothing
        Me.dtpFecIniSeg.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 112
        Me.Label16.Tag = ""
        Me.Label16.Text = "Fecha Fin:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 111
        Me.Label17.Tag = ""
        Me.Label17.Text = "Fecha Inicio:"
        '
        'frmStbBuscarBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 285)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumExp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbBuscarBitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda de Bitácoras de Seguimiento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.cmbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpFechFinSeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecIniSeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumExp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbUsuario As C1.Win.C1List.C1Combo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechFinSeg As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFecIniSeg As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
