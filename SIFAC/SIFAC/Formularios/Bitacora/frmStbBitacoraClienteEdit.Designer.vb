<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbBitacoraClienteEdit
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbBitacoraClienteEdit))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GrpExpediente = New System.Windows.Forms.GroupBox
        Me.cmdConsultar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdExpediente = New System.Windows.Forms.Button
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNumCuenta = New System.Windows.Forms.TextBox
        Me.txtCodTienda = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.grpSeguimiento = New System.Windows.Forms.GroupBox
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit
        Me.cmbSeguimiento = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtObjetivo = New System.Windows.Forms.RichTextBox
        Me.lblDecricpcion = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GrpExpediente.SuspendLayout()
        Me.grpSeguimiento.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(611, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
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
        Me.Panel2.Size = New System.Drawing.Size(683, 32)
        Me.Panel2.TabIndex = 23
        Me.Panel2.Tag = "LAYOUT"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(588, 275)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 27
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(508, 275)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(74, 30)
        Me.cmdGuardar.TabIndex = 26
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 311)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 21)
        Me.Panel1.TabIndex = 25
        '
        'GrpExpediente
        '
        Me.GrpExpediente.Controls.Add(Me.cmdConsultar)
        Me.GrpExpediente.Controls.Add(Me.Label10)
        Me.GrpExpediente.Controls.Add(Me.cmdExpediente)
        Me.GrpExpediente.Controls.Add(Me.txtCliente)
        Me.GrpExpediente.Controls.Add(Me.Label11)
        Me.GrpExpediente.Controls.Add(Me.txtNumCuenta)
        Me.GrpExpediente.Controls.Add(Me.txtCodTienda)
        Me.GrpExpediente.Controls.Add(Me.Label12)
        Me.GrpExpediente.Location = New System.Drawing.Point(293, 37)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Size = New System.Drawing.Size(380, 75)
        Me.GrpExpediente.TabIndex = 28
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos Expediente"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdConsultar.Location = New System.Drawing.Point(355, 14)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(24, 23)
        Me.cmdConsultar.TabIndex = 19
        Me.cmdConsultar.Text = "..."
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(153, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "--"
        '
        'cmdExpediente
        '
        Me.cmdExpediente.Location = New System.Drawing.Point(330, 14)
        Me.cmdExpediente.Name = "cmdExpediente"
        Me.cmdExpediente.Size = New System.Drawing.Size(24, 23)
        Me.cmdExpediente.TabIndex = 6
        Me.cmdExpediente.Text = "..."
        Me.cmdExpediente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(86, 44)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(275, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Tag = "OBLIGATORIO"
        Me.Label11.Text = "Cliente:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Location = New System.Drawing.Point(168, 17)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(158, 20)
        Me.txtNumCuenta.TabIndex = 3
        Me.txtNumCuenta.Tag = "BLOQUEADO"
        '
        'txtCodTienda
        '
        Me.txtCodTienda.Location = New System.Drawing.Point(86, 17)
        Me.txtCodTienda.Name = "txtCodTienda"
        Me.txtCodTienda.Size = New System.Drawing.Size(63, 20)
        Me.txtCodTienda.TabIndex = 2
        Me.txtCodTienda.Tag = "BLOQUEADO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Tag = "OBLIGATORIO"
        Me.Label12.Text = "No. Exp:"
        '
        'grpSeguimiento
        '
        Me.grpSeguimiento.Controls.Add(Me.dtpFecha)
        Me.grpSeguimiento.Controls.Add(Me.cmbSeguimiento)
        Me.grpSeguimiento.Controls.Add(Me.Label3)
        Me.grpSeguimiento.Controls.Add(Me.Label1)
        Me.grpSeguimiento.Controls.Add(Me.txtUsuario)
        Me.grpSeguimiento.Controls.Add(Me.Label2)
        Me.grpSeguimiento.Location = New System.Drawing.Point(12, 35)
        Me.grpSeguimiento.Name = "grpSeguimiento"
        Me.grpSeguimiento.Size = New System.Drawing.Size(275, 95)
        Me.grpSeguimiento.TabIndex = 29
        Me.grpSeguimiento.TabStop = False
        Me.grpSeguimiento.Text = "Datos de Seguimiento"
        '
        'dtpFecha
        '
        Me.dtpFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDateShortTime
        Me.dtpFecha.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDateShortTime
        Me.dtpFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDateShortTime
        Me.dtpFecha.Location = New System.Drawing.Point(83, 43)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(179, 20)
        Me.dtpFecha.TabIndex = 0
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cmbSeguimiento
        '
        Me.cmbSeguimiento.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSeguimiento.Caption = ""
        Me.cmbSeguimiento.CaptionHeight = 17
        Me.cmbSeguimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSeguimiento.ColumnCaptionHeight = 17
        Me.cmbSeguimiento.ColumnFooterHeight = 17
        Me.cmbSeguimiento.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSeguimiento.ContentHeight = 15
        Me.cmbSeguimiento.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSeguimiento.DropDownWidth = 250
        Me.cmbSeguimiento.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSeguimiento.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeguimiento.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSeguimiento.EditorHeight = 15
        Me.cmbSeguimiento.Images.Add(CType(resources.GetObject("cmbSeguimiento.Images"), System.Drawing.Image))
        Me.cmbSeguimiento.ItemHeight = 15
        Me.cmbSeguimiento.LimitToList = True
        Me.cmbSeguimiento.Location = New System.Drawing.Point(83, 69)
        Me.cmbSeguimiento.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSeguimiento.MaxDropDownItems = CType(5, Short)
        Me.cmbSeguimiento.MaxLength = 32767
        Me.cmbSeguimiento.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSeguimiento.Name = "cmbSeguimiento"
        Me.cmbSeguimiento.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSeguimiento.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSeguimiento.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSeguimiento.Size = New System.Drawing.Size(179, 21)
        Me.cmbSeguimiento.TabIndex = 2
        Me.cmbSeguimiento.Tag = ""
        Me.cmbSeguimiento.PropBag = resources.GetString("cmbSeguimiento.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Tag = "OBLIGATORIO"
        Me.Label3.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Tipo:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(83, 18)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(179, 20)
        Me.txtUsuario.TabIndex = 7
        Me.txtUsuario.Tag = "BLOQUEADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Usuario:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtObjetivo)
        Me.GroupBox1.Controls.Add(Me.lblDecricpcion)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 120)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info de Resultados de Seguimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Tag = "OBLIGATORIO"
        Me.Label5.Text = "Objetivo:"
        '
        'txtObjetivo
        '
        Me.txtObjetivo.Location = New System.Drawing.Point(96, 17)
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtObjetivo.Size = New System.Drawing.Size(546, 32)
        Me.txtObjetivo.TabIndex = 3
        Me.txtObjetivo.Text = ""
        '
        'lblDecricpcion
        '
        Me.lblDecricpcion.AutoSize = True
        Me.lblDecricpcion.Location = New System.Drawing.Point(13, 75)
        Me.lblDecricpcion.Name = "lblDecricpcion"
        Me.lblDecricpcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDecricpcion.TabIndex = 33
        Me.lblDecricpcion.Tag = "OBLIGATORIO"
        Me.lblDecricpcion.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 56)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtDescripcion.Size = New System.Drawing.Size(546, 58)
        Me.txtDescripcion.TabIndex = 4
        Me.txtDescripcion.Text = ""
        '
        'frmStbBitacoraClienteEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpSeguimiento)
        Me.Controls.Add(Me.GrpExpediente)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbBitacoraClienteEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "CATALOGOS"
        Me.Text = "Seguimiento de Clientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        Me.grpSeguimiento.ResumeLayout(False)
        Me.grpSeguimiento.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrpExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdExpediente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNumCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTienda As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpSeguimiento As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbSeguimiento As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDecricpcion As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtObjetivo As System.Windows.Forms.RichTextBox
End Class
