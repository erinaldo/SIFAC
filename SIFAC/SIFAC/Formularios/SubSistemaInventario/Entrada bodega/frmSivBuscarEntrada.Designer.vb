<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivBuscarEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivBuscarEntrada))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFactura = New C1.Win.C1Input.C1DateEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumeroPoliza = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumeroFactura = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumeroEntrada = New C1.Win.C1Input.C1NumericEdit()
        Me.cmbProveedor = New C1.Win.C1List.C1Combo()
        Me.cmbTipoEntrada = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit()
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.ErrorBuscar = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFactura)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNumeroPoliza)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNumeroFactura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNumeroEntrada)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.cmbTipoEntrada)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaFactura.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaFactura.EditMask = "##/##/####"
        Me.dtpFechaFactura.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFactura.Location = New System.Drawing.Point(107, 161)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(144, 18)
        Me.dtpFechaFactura.TabIndex = 12
        Me.dtpFechaFactura.Tag = Nothing
        Me.dtpFechaFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Fecha Factura:"
        '
        'txtNumeroPoliza
        '
        Me.txtNumeroPoliza.Location = New System.Drawing.Point(107, 135)
        Me.txtNumeroPoliza.Name = "txtNumeroPoliza"
        Me.txtNumeroPoliza.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroPoliza.TabIndex = 10
        Me.txtNumeroPoliza.Tag = Nothing
        Me.txtNumeroPoliza.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "N�mero P�liza:"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(107, 109)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroFactura.TabIndex = 8
        Me.txtNumeroFactura.Tag = Nothing
        Me.txtNumeroFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "N�mero Factura:"
        '
        'txtNumeroEntrada
        '
        Me.txtNumeroEntrada.Location = New System.Drawing.Point(107, 28)
        Me.txtNumeroEntrada.Name = "txtNumeroEntrada"
        Me.txtNumeroEntrada.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroEntrada.TabIndex = 6
        Me.txtNumeroEntrada.Tag = Nothing
        Me.txtNumeroEntrada.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProveedor.Caption = ""
        Me.cmbProveedor.CaptionHeight = 17
        Me.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProveedor.ColumnCaptionHeight = 17
        Me.cmbProveedor.ColumnFooterHeight = 17
        Me.cmbProveedor.ContentHeight = 15
        Me.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProveedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProveedor.EditorHeight = 15
        Me.cmbProveedor.Images.Add(CType(resources.GetObject("cmbProveedor.Images"), System.Drawing.Image))
        Me.cmbProveedor.ItemHeight = 15
        Me.cmbProveedor.Location = New System.Drawing.Point(107, 80)
        Me.cmbProveedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProveedor.MaxDropDownItems = CType(5, Short)
        Me.cmbProveedor.MaxLength = 32767
        Me.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedor.Size = New System.Drawing.Size(171, 21)
        Me.cmbProveedor.TabIndex = 5
        Me.cmbProveedor.Text = "NO APLICA"
        Me.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag")
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoEntrada.Caption = ""
        Me.cmbTipoEntrada.CaptionHeight = 17
        Me.cmbTipoEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoEntrada.ColumnCaptionHeight = 17
        Me.cmbTipoEntrada.ColumnFooterHeight = 17
        Me.cmbTipoEntrada.ContentHeight = 15
        Me.cmbTipoEntrada.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoEntrada.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoEntrada.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoEntrada.EditorHeight = 15
        Me.cmbTipoEntrada.Images.Add(CType(resources.GetObject("cmbTipoEntrada.Images"), System.Drawing.Image))
        Me.cmbTipoEntrada.ItemHeight = 15
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(107, 52)
        Me.cmbTipoEntrada.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoEntrada.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoEntrada.MaxLength = 32767
        Me.cmbTipoEntrada.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoEntrada.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoEntrada.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(171, 21)
        Me.cmbTipoEntrada.TabIndex = 4
        Me.cmbTipoEntrada.Text = "NO APLICA"
        Me.cmbTipoEntrada.PropBag = resources.GetString("cmbTipoEntrada.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo Entrada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N�mero Entrada:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox2.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo Entrada"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(105, 56)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(144, 18)
        Me.dtpFechaHasta.TabIndex = 3
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(105, 27)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(144, 18)
        Me.dtpFechaDesde.TabIndex = 2
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fecha Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Desde:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 32)
        Me.Panel2.TabIndex = 29
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(537, -1)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 21)
        Me.Panel1.TabIndex = 48
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(511, 137)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 50
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(431, 137)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 49
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'ErrorBuscar
        '
        Me.ErrorBuscar.ContainerControl = Me
        '
        'frmSivBuscarEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 254)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivBuscarEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Entrada a Bodega"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbProveedor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoEntrada As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents ErrorBuscar As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtNumeroEntrada As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNumeroFactura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFactura As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPoliza As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
