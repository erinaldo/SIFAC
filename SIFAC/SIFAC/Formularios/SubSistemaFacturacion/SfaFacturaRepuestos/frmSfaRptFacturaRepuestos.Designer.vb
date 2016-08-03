<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaRptFacturaRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaRptFacturaRepuestos))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbTipoRepuesto = New C1.Win.C1List.C1Combo
        Me.cmbRepuesto = New C1.Win.C1List.C1Combo
        Me.cmbSucursal = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpHasta = New C1.Win.C1Input.C1DateEdit
        Me.dtpDesde = New C1.Win.C1Input.C1DateEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ErrorImprimirFactura = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbTipoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorImprimirFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione criterios para su reporte:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTipoRepuesto)
        Me.GroupBox1.Controls.Add(Me.cmbRepuesto)
        Me.GroupBox1.Controls.Add(Me.cmbSucursal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 129)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmbTipoRepuesto
        '
        Me.cmbTipoRepuesto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoRepuesto.Caption = ""
        Me.cmbTipoRepuesto.CaptionHeight = 17
        Me.cmbTipoRepuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoRepuesto.ColumnCaptionHeight = 17
        Me.cmbTipoRepuesto.ColumnFooterHeight = 17
        Me.cmbTipoRepuesto.ColumnHeaders = False
        Me.cmbTipoRepuesto.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoRepuesto.ContentHeight = 15
        Me.cmbTipoRepuesto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoRepuesto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoRepuesto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoRepuesto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoRepuesto.EditorHeight = 15
        Me.cmbTipoRepuesto.Images.Add(CType(resources.GetObject("cmbTipoRepuesto.Images"), System.Drawing.Image))
        Me.cmbTipoRepuesto.ItemHeight = 15
        Me.cmbTipoRepuesto.Location = New System.Drawing.Point(104, 98)
        Me.cmbTipoRepuesto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoRepuesto.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoRepuesto.MaxLength = 32767
        Me.cmbTipoRepuesto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoRepuesto.Name = "cmbTipoRepuesto"
        Me.cmbTipoRepuesto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoRepuesto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoRepuesto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoRepuesto.Size = New System.Drawing.Size(293, 21)
        Me.cmbTipoRepuesto.TabIndex = 5
        Me.cmbTipoRepuesto.PropBag = resources.GetString("cmbTipoRepuesto.PropBag")
        '
        'cmbRepuesto
        '
        Me.cmbRepuesto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbRepuesto.Caption = ""
        Me.cmbRepuesto.CaptionHeight = 17
        Me.cmbRepuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbRepuesto.ColumnCaptionHeight = 17
        Me.cmbRepuesto.ColumnFooterHeight = 17
        Me.cmbRepuesto.ColumnHeaders = False
        Me.cmbRepuesto.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbRepuesto.ContentHeight = 15
        Me.cmbRepuesto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbRepuesto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbRepuesto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRepuesto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRepuesto.EditorHeight = 15
        Me.cmbRepuesto.Images.Add(CType(resources.GetObject("cmbRepuesto.Images"), System.Drawing.Image))
        Me.cmbRepuesto.ItemHeight = 15
        Me.cmbRepuesto.Location = New System.Drawing.Point(104, 61)
        Me.cmbRepuesto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbRepuesto.MaxDropDownItems = CType(5, Short)
        Me.cmbRepuesto.MaxLength = 32767
        Me.cmbRepuesto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbRepuesto.Name = "cmbRepuesto"
        Me.cmbRepuesto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbRepuesto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbRepuesto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbRepuesto.Size = New System.Drawing.Size(293, 21)
        Me.cmbRepuesto.TabIndex = 4
        Me.cmbRepuesto.PropBag = resources.GetString("cmbRepuesto.PropBag")
        '
        'cmbSucursal
        '
        Me.cmbSucursal.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursal.Caption = ""
        Me.cmbSucursal.CaptionHeight = 17
        Me.cmbSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursal.ColumnCaptionHeight = 17
        Me.cmbSucursal.ColumnFooterHeight = 17
        Me.cmbSucursal.ColumnHeaders = False
        Me.cmbSucursal.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSucursal.ContentHeight = 15
        Me.cmbSucursal.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursal.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursal.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursal.EditorHeight = 15
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.Images.Add(CType(resources.GetObject("cmbSucursal.Images"), System.Drawing.Image))
        Me.cmbSucursal.ItemHeight = 15
        Me.cmbSucursal.Location = New System.Drawing.Point(104, 26)
        Me.cmbSucursal.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursal.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursal.MaxLength = 32767
        Me.cmbSucursal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursal.Size = New System.Drawing.Size(201, 21)
        Me.cmbSucursal.TabIndex = 3
        Me.cmbSucursal.PropBag = resources.GetString("cmbSucursal.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo de Repuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Repuesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sucursal:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpHasta)
        Me.GroupBox2.Controls.Add(Me.dtpDesde)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(434, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 128)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Período"
        '
        'dtpHasta
        '
        Me.dtpHasta.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpHasta.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpHasta.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpHasta.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpHasta.Location = New System.Drawing.Point(54, 65)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(157, 20)
        Me.dtpHasta.TabIndex = 3
        Me.dtpHasta.Tag = Nothing
        Me.dtpHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpDesde
        '
        Me.dtpDesde.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpDesde.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpDesde.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpDesde.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpDesde.Location = New System.Drawing.Point(54, 25)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(157, 20)
        Me.dtpDesde.TabIndex = 2
        Me.dtpDesde.Tag = Nothing
        Me.dtpDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Hasta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Desde:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(507, 194)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(587, 194)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(596, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
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
        Me.Panel2.Size = New System.Drawing.Size(667, 32)
        Me.Panel2.TabIndex = 31
        Me.Panel2.Tag = "LAYOUT"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 21)
        Me.Panel1.TabIndex = 50
        '
        'ErrorImprimirFactura
        '
        Me.ErrorImprimirFactura.ContainerControl = Me
        '
        'frmSfaRptFacturaRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 251)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaRptFacturaRepuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir reporte de Repuestos facturados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbTipoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorImprimirFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRepuesto As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSucursal As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoRepuesto As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorImprimirFactura As System.Windows.Forms.ErrorProvider
End Class
