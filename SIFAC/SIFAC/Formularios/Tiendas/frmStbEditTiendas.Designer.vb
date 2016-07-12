<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbEditTiendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbEditTiendas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NumProximoNoFactura = New C1.Win.C1Input.C1NumericEdit
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.cmdJefe = New System.Windows.Forms.Button
        Me.cmbJefe = New C1.Win.C1List.C1Combo
        Me.cmbCiudad = New C1.Win.C1List.C1Combo
        Me.txtSerieFactura = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.chkActivoRepuesto = New System.Windows.Forms.CheckBox
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.lblSerieFactura = New System.Windows.Forms.Label
        Me.lblJefe = New System.Windows.Forms.Label
        Me.lblProximoNumeroFact = New System.Windows.Forms.Label
        Me.lblCiudad = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grdContactos = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.cmdTienda = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumProximoNoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbJefe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumProximoNoFactura)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.cmdJefe)
        Me.GroupBox1.Controls.Add(Me.cmbJefe)
        Me.GroupBox1.Controls.Add(Me.cmbCiudad)
        Me.GroupBox1.Controls.Add(Me.txtSerieFactura)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.chkActivoRepuesto)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.lblSerieFactura)
        Me.GroupBox1.Controls.Add(Me.lblJefe)
        Me.GroupBox1.Controls.Add(Me.lblProximoNumeroFact)
        Me.GroupBox1.Controls.Add(Me.lblCiudad)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 184)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Sucursal"
        '
        'NumProximoNoFactura
        '
        Me.NumProximoNoFactura.CustomFormat = "#"
        Me.NumProximoNoFactura.DataType = GetType(Integer)
        Me.NumProximoNoFactura.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumProximoNoFactura.EditFormat.CustomFormat = "#"
        Me.NumProximoNoFactura.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumProximoNoFactura.FormatType = C1.Win.C1Input.FormatTypeEnum.[Integer]
        Me.NumProximoNoFactura.Increment = 0
        Me.NumProximoNoFactura.Location = New System.Drawing.Point(116, 127)
        Me.NumProximoNoFactura.MaxLength = 10
        Me.NumProximoNoFactura.Name = "NumProximoNoFactura"
        Me.NumProximoNoFactura.Size = New System.Drawing.Size(133, 20)
        Me.NumProximoNoFactura.TabIndex = 5
        Me.NumProximoNoFactura.Tag = Nothing
        Me.NumProximoNoFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumProximoNoFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(116, 47)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(268, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(17, 50)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.Tag = "OBLIGATORIO"
        Me.lblCodigo.Text = "Código:"
        '
        'cmdJefe
        '
        Me.cmdJefe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJefe.Location = New System.Drawing.Point(390, 100)
        Me.cmdJefe.Name = "cmdJefe"
        Me.cmdJefe.Size = New System.Drawing.Size(33, 21)
        Me.cmdJefe.TabIndex = 4
        Me.cmdJefe.Text = "···"
        Me.cmdJefe.UseVisualStyleBackColor = True
        '
        'cmbJefe
        '
        Me.cmbJefe.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbJefe.Caption = ""
        Me.cmbJefe.CaptionHeight = 17
        Me.cmbJefe.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbJefe.ColumnCaptionHeight = 17
        Me.cmbJefe.ColumnFooterHeight = 17
        Me.cmbJefe.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbJefe.ContentHeight = 15
        Me.cmbJefe.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbJefe.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbJefe.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJefe.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbJefe.EditorHeight = 15
        Me.cmbJefe.Images.Add(CType(resources.GetObject("cmbJefe.Images"), System.Drawing.Image))
        Me.cmbJefe.ItemHeight = 15
        Me.cmbJefe.Location = New System.Drawing.Point(116, 100)
        Me.cmbJefe.MatchEntryTimeout = CType(2000, Long)
        Me.cmbJefe.MaxDropDownItems = CType(5, Short)
        Me.cmbJefe.MaxLength = 32767
        Me.cmbJefe.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbJefe.Name = "cmbJefe"
        Me.cmbJefe.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbJefe.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbJefe.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbJefe.Size = New System.Drawing.Size(268, 21)
        Me.cmbJefe.TabIndex = 3
        Me.cmbJefe.Tag = "OBLIGATORIO"
        Me.cmbJefe.PropBag = resources.GetString("cmbJefe.PropBag")
        '
        'cmbCiudad
        '
        Me.cmbCiudad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCiudad.Caption = ""
        Me.cmbCiudad.CaptionHeight = 17
        Me.cmbCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCiudad.ColumnCaptionHeight = 17
        Me.cmbCiudad.ColumnFooterHeight = 17
        Me.cmbCiudad.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCiudad.ContentHeight = 15
        Me.cmbCiudad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCiudad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCiudad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiudad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCiudad.EditorHeight = 15
        Me.cmbCiudad.Images.Add(CType(resources.GetObject("cmbCiudad.Images"), System.Drawing.Image))
        Me.cmbCiudad.ItemHeight = 15
        Me.cmbCiudad.Location = New System.Drawing.Point(116, 73)
        Me.cmbCiudad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCiudad.MaxDropDownItems = CType(5, Short)
        Me.cmbCiudad.MaxLength = 32767
        Me.cmbCiudad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCiudad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCiudad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCiudad.Size = New System.Drawing.Size(268, 21)
        Me.cmbCiudad.TabIndex = 2
        Me.cmbCiudad.Tag = "OBLIGATORIO"
        Me.cmbCiudad.PropBag = resources.GetString("cmbCiudad.PropBag")
        '
        'txtSerieFactura
        '
        Me.txtSerieFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFactura.Location = New System.Drawing.Point(116, 153)
        Me.txtSerieFactura.Name = "txtSerieFactura"
        Me.txtSerieFactura.Size = New System.Drawing.Size(133, 20)
        Me.txtSerieFactura.TabIndex = 6
        Me.txtSerieFactura.Tag = ""
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(116, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Tag = "OBLIGATORIO"
        '
        'chkActivoRepuesto
        '
        Me.chkActivoRepuesto.AutoSize = True
        Me.chkActivoRepuesto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivoRepuesto.Location = New System.Drawing.Point(279, 157)
        Me.chkActivoRepuesto.Name = "chkActivoRepuesto"
        Me.chkActivoRepuesto.Size = New System.Drawing.Size(105, 17)
        Me.chkActivoRepuesto.TabIndex = 8
        Me.chkActivoRepuesto.Text = "Activo Repuesto"
        Me.chkActivoRepuesto.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Location = New System.Drawing.Point(328, 131)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 7
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblSerieFactura
        '
        Me.lblSerieFactura.AutoSize = True
        Me.lblSerieFactura.Location = New System.Drawing.Point(17, 157)
        Me.lblSerieFactura.Name = "lblSerieFactura"
        Me.lblSerieFactura.Size = New System.Drawing.Size(31, 13)
        Me.lblSerieFactura.TabIndex = 0
        Me.lblSerieFactura.Tag = ""
        Me.lblSerieFactura.Text = "Serie"
        '
        'lblJefe
        '
        Me.lblJefe.AutoSize = True
        Me.lblJefe.Location = New System.Drawing.Point(17, 104)
        Me.lblJefe.Name = "lblJefe"
        Me.lblJefe.Size = New System.Drawing.Size(89, 13)
        Me.lblJefe.TabIndex = 2
        Me.lblJefe.Tag = "OBLIGATORIO"
        Me.lblJefe.Text = "Jefe de Sucursal:"
        '
        'lblProximoNumeroFact
        '
        Me.lblProximoNumeroFact.AutoSize = True
        Me.lblProximoNumeroFact.Location = New System.Drawing.Point(17, 131)
        Me.lblProximoNumeroFact.Name = "lblProximoNumeroFact"
        Me.lblProximoNumeroFact.Size = New System.Drawing.Size(93, 13)
        Me.lblProximoNumeroFact.TabIndex = 0
        Me.lblProximoNumeroFact.Tag = ""
        Me.lblProximoNumeroFact.Text = "Próximo # Factura"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(17, 77)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(43, 13)
        Me.lblCiudad.TabIndex = 1
        Me.lblCiudad.Tag = "OBLIGATORIO"
        Me.lblCiudad.Text = "Ciudad:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 26)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Tag = "OBLIGATORIO"
        Me.lblNombre.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdContactos)
        Me.GroupBox2.Controls.Add(Me.cmdTienda)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 153)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de contacto de la Sucursal"
        '
        'grdContactos
        '
        Me.grdContactos.AllowEditing = False
        Me.grdContactos.AutoClipboard = True
        Me.grdContactos.ColumnInfo = "2,1,0,0,0,85,Columns:0{Width:116;Caption:""Forma de contacto"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:294;AllowS" & _
            "orting:False;AllowDragging:False;AllowResizing:False;AllowEditing:False;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.grdContactos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdContactos.Location = New System.Drawing.Point(3, 44)
        Me.grdContactos.Name = "grdContactos"
        Me.grdContactos.Rows.Count = 1
        Me.grdContactos.Rows.DefaultSize = 17
        Me.grdContactos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.grdContactos.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.grdContactos.Size = New System.Drawing.Size(430, 106)
        Me.grdContactos.TabIndex = 11
        '
        'cmdTienda
        '
        Me.cmdTienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTienda.Location = New System.Drawing.Point(3, 19)
        Me.cmdTienda.Name = "cmdTienda"
        Me.cmdTienda.Size = New System.Drawing.Size(30, 23)
        Me.cmdTienda.TabIndex = 10
        Me.cmdTienda.Text = "···"
        Me.cmdTienda.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(290, 385)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 29)
        Me.cmdAceptar.TabIndex = 12
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(371, 385)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 29)
        Me.cmdCancelar.TabIndex = 13
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
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 32)
        Me.Panel2.TabIndex = 24
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(380, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(663, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UM"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SCCUM.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 420)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 21)
        Me.Panel1.TabIndex = 23
        '
        'frmStbEditTiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 441)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbEditTiendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumProximoNoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbJefe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cmbJefe As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCiudad As C1.Win.C1List.C1Combo
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblJefe As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdJefe As System.Windows.Forms.Button
    Friend WithEvents cmdTienda As System.Windows.Forms.Button
    Friend WithEvents grdContactos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkActivoRepuesto As System.Windows.Forms.CheckBox
    Friend WithEvents lblProximoNumeroFact As System.Windows.Forms.Label
    Friend WithEvents txtSerieFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblSerieFactura As System.Windows.Forms.Label
    Friend WithEvents NumProximoNoFactura As C1.Win.C1Input.C1NumericEdit
End Class
