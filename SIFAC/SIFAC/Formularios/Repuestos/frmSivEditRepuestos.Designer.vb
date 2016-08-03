<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivEditRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivEditRepuestos))
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style21 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style22 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style23 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style24 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.chkEtiquetarCB = New System.Windows.Forms.CheckBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.cmbTipo = New C1.Win.C1List.C1Combo
        Me.cmbMarca = New C1.Win.C1List.C1Combo
        Me.txtDescripcionCorta = New System.Windows.Forms.TextBox
        Me.txtDescripcionEspanol = New System.Windows.Forms.TextBox
        Me.txtDescripcionIngles = New System.Windows.Forms.TextBox
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblCostoPromedio = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtFecha = New C1.Win.C1Input.C1DateEdit
        Me.cmbCausa = New C1.Win.C1List.C1Combo
        Me.numCosto = New C1.Win.C1Input.C1NumericEdit
        Me.numPrecio = New C1.Win.C1Input.C1NumericEdit
        Me.PicFoto = New System.Windows.Forms.PictureBox
        Me.cmdcambiarfotos = New System.Windows.Forms.Button
        Me.tbcMasDatos = New System.Windows.Forms.TabControl
        Me.tabpageProveedor = New System.Windows.Forms.TabPage
        Me.CtdbProveedor = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.grdProveedor = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tabpageCompatibilidad = New System.Windows.Forms.TabPage
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.grdCompatibilidad = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tabpageExistenciaBodega = New System.Windows.Forms.TabPage
        Me.grdBodegas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog
        Me.txtPlazo = New C1.Win.C1Input.C1NumericEdit
        Me.ErrorRepuesto = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblCantidadMinima = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.numCantidadMinima = New DevExpress.XtraEditors.SpinEdit
        Me.numCantidadMaxima = New DevExpress.XtraEditors.SpinEdit
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCausa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcMasDatos.SuspendLayout()
        Me.tabpageProveedor.SuspendLayout()
        CType(Me.CtdbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageCompatibilidad.SuspendLayout()
        CType(Me.grdCompatibilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageExistenciaBodega.SuspendLayout()
        CType(Me.grdBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCantidadMinima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCantidadMaxima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(645, 32)
        Me.Panel2.TabIndex = 25
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(573, 0)
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
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Código: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Tag = "OBLIGATORIO"
        Me.Label3.Text = "Clasificación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Tag = "OBLIGATORIO"
        Me.Label4.Text = "Descripción Corta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Descripción Español:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Descripción Ingles:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Código de Barras:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(466, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Fecha de Registro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Tag = "OBLIGATORIO"
        Me.Label9.Text = "Marca/Modelo:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(350, 55)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 9
        Me.chkActivo.Tag = "OBLIGATORIO"
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'chkEtiquetarCB
        '
        Me.chkEtiquetarCB.AutoSize = True
        Me.chkEtiquetarCB.Location = New System.Drawing.Point(350, 82)
        Me.chkEtiquetarCB.Name = "chkEtiquetarCB"
        Me.chkEtiquetarCB.Size = New System.Drawing.Size(106, 17)
        Me.chkEtiquetarCB.TabIndex = 10
        Me.chkEtiquetarCB.Tag = "OBLIGATORIO"
        Me.chkEtiquetarCB.Text = "Etiquetar con CB"
        Me.chkEtiquetarCB.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(129, 52)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(181, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.Tag = ""
        '
        'cmbTipo
        '
        Me.cmbTipo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipo.Caption = ""
        Me.cmbTipo.CaptionHeight = 17
        Me.cmbTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipo.ColumnCaptionHeight = 17
        Me.cmbTipo.ColumnFooterHeight = 17
        Me.cmbTipo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipo.ContentHeight = 15
        Me.cmbTipo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipo.EditorHeight = 15
        Me.cmbTipo.Images.Add(CType(resources.GetObject("cmbTipo.Images"), System.Drawing.Image))
        Me.cmbTipo.ItemHeight = 15
        Me.cmbTipo.Location = New System.Drawing.Point(129, 78)
        Me.cmbTipo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipo.MaxDropDownItems = CType(5, Short)
        Me.cmbTipo.MaxLength = 32767
        Me.cmbTipo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipo.Size = New System.Drawing.Size(181, 21)
        Me.cmbTipo.TabIndex = 1
        Me.cmbTipo.PropBag = resources.GetString("cmbTipo.PropBag")
        '
        'cmbMarca
        '
        Me.cmbMarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMarca.Caption = ""
        Me.cmbMarca.CaptionHeight = 17
        Me.cmbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMarca.ColumnCaptionHeight = 17
        Me.cmbMarca.ColumnFooterHeight = 17
        Me.cmbMarca.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMarca.ContentHeight = 15
        Me.cmbMarca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMarca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMarca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMarca.EditorHeight = 15
        Me.cmbMarca.Images.Add(CType(resources.GetObject("cmbMarca.Images"), System.Drawing.Image))
        Me.cmbMarca.ItemHeight = 15
        Me.cmbMarca.Location = New System.Drawing.Point(129, 105)
        Me.cmbMarca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMarca.MaxDropDownItems = CType(5, Short)
        Me.cmbMarca.MaxLength = 32767
        Me.cmbMarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMarca.Size = New System.Drawing.Size(181, 21)
        Me.cmbMarca.TabIndex = 2
        Me.cmbMarca.PropBag = resources.GetString("cmbMarca.PropBag")
        '
        'txtDescripcionCorta
        '
        Me.txtDescripcionCorta.Location = New System.Drawing.Point(129, 132)
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Size = New System.Drawing.Size(296, 20)
        Me.txtDescripcionCorta.TabIndex = 3
        '
        'txtDescripcionEspanol
        '
        Me.txtDescripcionEspanol.Location = New System.Drawing.Point(129, 158)
        Me.txtDescripcionEspanol.Name = "txtDescripcionEspanol"
        Me.txtDescripcionEspanol.Size = New System.Drawing.Size(296, 20)
        Me.txtDescripcionEspanol.TabIndex = 4
        '
        'txtDescripcionIngles
        '
        Me.txtDescripcionIngles.Location = New System.Drawing.Point(129, 184)
        Me.txtDescripcionIngles.Name = "txtDescripcionIngles"
        Me.txtDescripcionIngles.Size = New System.Drawing.Size(296, 20)
        Me.txtDescripcionIngles.TabIndex = 5
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(129, 262)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(296, 20)
        Me.txtCodigoBarras.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(466, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Tag = "OBLIGATORIO"
        Me.Label10.Text = "Plazo de Garantía (Días)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(466, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Causa de Inactivación"
        '
        'lblCostoPromedio
        '
        Me.lblCostoPromedio.AutoSize = True
        Me.lblCostoPromedio.Location = New System.Drawing.Point(466, 218)
        Me.lblCostoPromedio.Name = "lblCostoPromedio"
        Me.lblCostoPromedio.Size = New System.Drawing.Size(64, 13)
        Me.lblCostoPromedio.TabIndex = 45
        Me.lblCostoPromedio.Text = "Costo Prom."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(466, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Tag = "OBLIGATORIO"
        Me.Label13.Text = "Precio"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 605)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 21)
        Me.Panel1.TabIndex = 47
        '
        'dtFecha
        '
        Me.dtFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtFecha.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtFecha.Location = New System.Drawing.Point(469, 76)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(152, 20)
        Me.dtFecha.TabIndex = 11
        Me.dtFecha.Tag = Nothing
        Me.dtFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cmbCausa
        '
        Me.cmbCausa.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCausa.Caption = ""
        Me.cmbCausa.CaptionHeight = 17
        Me.cmbCausa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCausa.ColumnCaptionHeight = 17
        Me.cmbCausa.ColumnFooterHeight = 17
        Me.cmbCausa.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCausa.ContentHeight = 15
        Me.cmbCausa.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCausa.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCausa.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCausa.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCausa.EditorHeight = 15
        Me.cmbCausa.Images.Add(CType(resources.GetObject("cmbCausa.Images"), System.Drawing.Image))
        Me.cmbCausa.ItemHeight = 15
        Me.cmbCausa.Location = New System.Drawing.Point(469, 179)
        Me.cmbCausa.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCausa.MaxDropDownItems = CType(5, Short)
        Me.cmbCausa.MaxLength = 32767
        Me.cmbCausa.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCausa.Name = "cmbCausa"
        Me.cmbCausa.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCausa.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCausa.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCausa.Size = New System.Drawing.Size(151, 21)
        Me.cmbCausa.TabIndex = 13
        Me.cmbCausa.Text = "cmbCausaInactivacion"
        Me.cmbCausa.PropBag = resources.GetString("cmbCausa.PropBag")
        '
        'numCosto
        '
        Me.numCosto.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numCosto.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numCosto.Enabled = False
        Me.numCosto.ErrorInfo.ShowErrorMessage = False
        Me.numCosto.Location = New System.Drawing.Point(530, 215)
        Me.numCosto.Name = "numCosto"
        Me.numCosto.Size = New System.Drawing.Size(91, 20)
        Me.numCosto.TabIndex = 14
        Me.numCosto.Tag = Nothing
        Me.numCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCosto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numCosto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numPrecio
        '
        Me.numPrecio.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numPrecio.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numPrecio.Enabled = False
        Me.numPrecio.ErrorInfo.ShowErrorMessage = False
        Me.numPrecio.Location = New System.Drawing.Point(530, 242)
        Me.numPrecio.Name = "numPrecio"
        Me.numPrecio.Size = New System.Drawing.Size(91, 20)
        Me.numPrecio.TabIndex = 15
        Me.numPrecio.Tag = Nothing
        Me.numPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPrecio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numPrecio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(464, 351)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(156, 140)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 53
        Me.PicFoto.TabStop = False
        '
        'cmdcambiarfotos
        '
        Me.cmdcambiarfotos.Image = CType(resources.GetObject("cmdcambiarfotos.Image"), System.Drawing.Image)
        Me.cmdcambiarfotos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdcambiarfotos.Location = New System.Drawing.Point(464, 309)
        Me.cmdcambiarfotos.Name = "cmdcambiarfotos"
        Me.cmdcambiarfotos.Size = New System.Drawing.Size(99, 27)
        Me.cmdcambiarfotos.TabIndex = 16
        Me.cmdcambiarfotos.Text = "Cambiar Foto"
        Me.cmdcambiarfotos.UseVisualStyleBackColor = True
        '
        'tbcMasDatos
        '
        Me.tbcMasDatos.Controls.Add(Me.tabpageProveedor)
        Me.tbcMasDatos.Controls.Add(Me.tabpageCompatibilidad)
        Me.tbcMasDatos.Controls.Add(Me.tabpageExistenciaBodega)
        Me.tbcMasDatos.Location = New System.Drawing.Point(12, 287)
        Me.tbcMasDatos.Name = "tbcMasDatos"
        Me.tbcMasDatos.SelectedIndex = 0
        Me.tbcMasDatos.Size = New System.Drawing.Size(444, 312)
        Me.tbcMasDatos.TabIndex = 15
        '
        'tabpageProveedor
        '
        Me.tabpageProveedor.Controls.Add(Me.CtdbProveedor)
        Me.tabpageProveedor.Controls.Add(Me.grdProveedor)
        Me.tabpageProveedor.Location = New System.Drawing.Point(4, 22)
        Me.tabpageProveedor.Name = "tabpageProveedor"
        Me.tabpageProveedor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageProveedor.Size = New System.Drawing.Size(436, 286)
        Me.tabpageProveedor.TabIndex = 0
        Me.tabpageProveedor.Text = "Proveedor"
        Me.tabpageProveedor.UseVisualStyleBackColor = True
        '
        'CtdbProveedor
        '
        Me.CtdbProveedor.AllowColMove = True
        Me.CtdbProveedor.AllowColSelect = True
        Me.CtdbProveedor.AllowDrop = True
        Me.CtdbProveedor.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.CtdbProveedor.AlternatingRows = False
        Me.CtdbProveedor.CaptionStyle = Style17
        Me.CtdbProveedor.ColumnCaptionHeight = 17
        Me.CtdbProveedor.ColumnFooterHeight = 17
        Me.CtdbProveedor.ColumnHeaders = False
        Me.CtdbProveedor.EvenRowStyle = Style18
        Me.CtdbProveedor.FetchRowStyles = False
        Me.CtdbProveedor.FooterStyle = Style19
        Me.CtdbProveedor.HeadingStyle = Style20
        Me.CtdbProveedor.HighLightRowStyle = Style21
        Me.CtdbProveedor.Images.Add(CType(resources.GetObject("CtdbProveedor.Images"), System.Drawing.Image))
        Me.CtdbProveedor.Location = New System.Drawing.Point(19, 25)
        Me.CtdbProveedor.Name = "CtdbProveedor"
        Me.CtdbProveedor.OddRowStyle = Style22
        Me.CtdbProveedor.RecordSelectorStyle = Style23
        Me.CtdbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CtdbProveedor.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.CtdbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CtdbProveedor.ScrollTips = False
        Me.CtdbProveedor.Size = New System.Drawing.Size(223, 88)
        Me.CtdbProveedor.Style = Style24
        Me.CtdbProveedor.TabIndex = 1
        Me.CtdbProveedor.TabStop = False
        Me.CtdbProveedor.Text = "C1TrueDBDropdown1"
        Me.CtdbProveedor.Visible = False
        Me.CtdbProveedor.PropBag = resources.GetString("CtdbProveedor.PropBag")
        '
        'grdProveedor
        '
        Me.grdProveedor.AllowAddNew = True
        Me.grdProveedor.AllowColMove = False
        Me.grdProveedor.AllowFilter = False
        Me.grdProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdProveedor.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdProveedor.Images.Add(CType(resources.GetObject("grdProveedor.Images"), System.Drawing.Image))
        Me.grdProveedor.Location = New System.Drawing.Point(3, 3)
        Me.grdProveedor.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
        Me.grdProveedor.Name = "grdProveedor"
        Me.grdProveedor.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdProveedor.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdProveedor.PreviewInfo.ZoomFactor = 75
        Me.grdProveedor.PrintInfo.PageSettings = CType(resources.GetObject("grdProveedor.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdProveedor.Size = New System.Drawing.Size(430, 277)
        Me.grdProveedor.TabIndex = 0
        Me.grdProveedor.PropBag = resources.GetString("grdProveedor.PropBag")
        '
        'tabpageCompatibilidad
        '
        Me.tabpageCompatibilidad.Controls.Add(Me.chkTodos)
        Me.tabpageCompatibilidad.Controls.Add(Me.grdCompatibilidad)
        Me.tabpageCompatibilidad.Location = New System.Drawing.Point(4, 22)
        Me.tabpageCompatibilidad.Name = "tabpageCompatibilidad"
        Me.tabpageCompatibilidad.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageCompatibilidad.Size = New System.Drawing.Size(436, 286)
        Me.tabpageCompatibilidad.TabIndex = 1
        Me.tabpageCompatibilidad.Text = "Compatibilidad"
        Me.tabpageCompatibilidad.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(57, 266)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(115, 17)
        Me.chkTodos.TabIndex = 9
        Me.chkTodos.Text = "Seleccionar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'grdCompatibilidad
        '
        Me.grdCompatibilidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdCompatibilidad.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdCompatibilidad.Images.Add(CType(resources.GetObject("grdCompatibilidad.Images"), System.Drawing.Image))
        Me.grdCompatibilidad.Location = New System.Drawing.Point(3, 3)
        Me.grdCompatibilidad.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
        Me.grdCompatibilidad.Name = "grdCompatibilidad"
        Me.grdCompatibilidad.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCompatibilidad.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCompatibilidad.PreviewInfo.ZoomFactor = 75
        Me.grdCompatibilidad.PrintInfo.PageSettings = CType(resources.GetObject("grdCompatibilidad.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCompatibilidad.Size = New System.Drawing.Size(422, 257)
        Me.grdCompatibilidad.TabIndex = 0
        Me.grdCompatibilidad.PropBag = resources.GetString("grdCompatibilidad.PropBag")
        '
        'tabpageExistenciaBodega
        '
        Me.tabpageExistenciaBodega.Controls.Add(Me.grdBodegas)
        Me.tabpageExistenciaBodega.Location = New System.Drawing.Point(4, 22)
        Me.tabpageExistenciaBodega.Name = "tabpageExistenciaBodega"
        Me.tabpageExistenciaBodega.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageExistenciaBodega.Size = New System.Drawing.Size(436, 286)
        Me.tabpageExistenciaBodega.TabIndex = 2
        Me.tabpageExistenciaBodega.Text = "Existencia en Bodegas"
        Me.tabpageExistenciaBodega.UseVisualStyleBackColor = True
        '
        'grdBodegas
        '
        Me.grdBodegas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdBodegas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdBodegas.Images.Add(CType(resources.GetObject("grdBodegas.Images"), System.Drawing.Image))
        Me.grdBodegas.Location = New System.Drawing.Point(3, 3)
        Me.grdBodegas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
        Me.grdBodegas.Name = "grdBodegas"
        Me.grdBodegas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdBodegas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdBodegas.PreviewInfo.ZoomFactor = 75
        Me.grdBodegas.PrintInfo.PageSettings = CType(resources.GetObject("grdBodegas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdBodegas.Size = New System.Drawing.Size(430, 280)
        Me.grdBodegas.TabIndex = 0
        Me.grdBodegas.Text = "C1TrueDBGrid1"
        Me.grdBodegas.PropBag = resources.GetString("grdBodegas.PropBag")
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(469, 569)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 30)
        Me.cmdAceptar.TabIndex = 17
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(558, 569)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 30)
        Me.cmdCancelar.TabIndex = 18
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'ArchivoDialogo
        '
        Me.ArchivoDialogo.FileName = "OpenFileDialog1"
        '
        'txtPlazo
        '
        Me.txtPlazo.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.[Integer]
        Me.txtPlazo.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtPlazo.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPlazo.Location = New System.Drawing.Point(469, 135)
        Me.txtPlazo.MaxLength = 10
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.NumericInputKeys = CType((C1.Win.C1Input.NumericInputKeyFlags.F9 Or C1.Win.C1Input.NumericInputKeyFlags.X), C1.Win.C1Input.NumericInputKeyFlags)
        Me.txtPlazo.Size = New System.Drawing.Size(152, 20)
        Me.txtPlazo.TabIndex = 12
        Me.txtPlazo.Tag = Nothing
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPlazo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'ErrorRepuesto
        '
        Me.ErrorRepuesto.ContainerControl = Me
        '
        'lblCantidadMinima
        '
        Me.lblCantidadMinima.AutoSize = True
        Me.lblCantidadMinima.Location = New System.Drawing.Point(13, 213)
        Me.lblCantidadMinima.Name = "lblCantidadMinima"
        Me.lblCantidadMinima.Size = New System.Drawing.Size(90, 13)
        Me.lblCantidadMinima.TabIndex = 30
        Me.lblCantidadMinima.Text = "Cantidad Mínima:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Cantidad Máxima:"
        '
        'numCantidadMinima
        '
        Me.numCantidadMinima.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numCantidadMinima.Location = New System.Drawing.Point(129, 211)
        Me.numCantidadMinima.Name = "numCantidadMinima"
        Me.numCantidadMinima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.numCantidadMinima.Properties.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numCantidadMinima.Properties.IsFloatValue = False
        Me.numCantidadMinima.Properties.Mask.EditMask = "N00"
        Me.numCantidadMinima.Properties.MaxValue = New Decimal(New Integer() {2000000, 0, 0, 0})
        Me.numCantidadMinima.Properties.UseCtrlIncrement = False
        Me.numCantidadMinima.Size = New System.Drawing.Size(152, 20)
        Me.numCantidadMinima.TabIndex = 6
        '
        'numCantidadMaxima
        '
        Me.numCantidadMaxima.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numCantidadMaxima.Location = New System.Drawing.Point(129, 239)
        Me.numCantidadMaxima.Name = "numCantidadMaxima"
        Me.numCantidadMaxima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.numCantidadMaxima.Properties.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numCantidadMaxima.Properties.IsFloatValue = False
        Me.numCantidadMaxima.Properties.Mask.EditMask = "N00"
        Me.numCantidadMaxima.Properties.MaxValue = New Decimal(New Integer() {2000000, 0, 0, 0})
        Me.numCantidadMaxima.Properties.UseCtrlIncrement = False
        Me.numCantidadMaxima.Size = New System.Drawing.Size(152, 20)
        Me.numCantidadMaxima.TabIndex = 7
        '
        'frmSivEditRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 626)
        Me.Controls.Add(Me.numCantidadMaxima)
        Me.Controls.Add(Me.numCantidadMinima)
        Me.Controls.Add(Me.txtPlazo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.tbcMasDatos)
        Me.Controls.Add(Me.cmdcambiarfotos)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.numPrecio)
        Me.Controls.Add(Me.numCosto)
        Me.Controls.Add(Me.cmbCausa)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblCostoPromedio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.txtDescripcionIngles)
        Me.Controls.Add(Me.txtDescripcionEspanol)
        Me.Controls.Add(Me.txtDescripcionCorta)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.chkEtiquetarCB)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCantidadMinima)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivEditRepuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Repuestos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCausa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcMasDatos.ResumeLayout(False)
        Me.tabpageProveedor.ResumeLayout(False)
        CType(Me.CtdbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageCompatibilidad.ResumeLayout(False)
        Me.tabpageCompatibilidad.PerformLayout()
        CType(Me.grdCompatibilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageExistenciaBodega.ResumeLayout(False)
        CType(Me.grdBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCantidadMinima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCantidadMaxima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkEtiquetarCB As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As C1.Win.C1List.C1Combo
    Friend WithEvents cmbMarca As C1.Win.C1List.C1Combo
    Friend WithEvents txtDescripcionCorta As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionEspanol As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionIngles As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblCostoPromedio As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbCausa As C1.Win.C1List.C1Combo
    Friend WithEvents numCosto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numPrecio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents cmdcambiarfotos As System.Windows.Forms.Button
    Friend WithEvents tbcMasDatos As System.Windows.Forms.TabControl
    Friend WithEvents tabpageProveedor As System.Windows.Forms.TabPage
    Friend WithEvents tabpageCompatibilidad As System.Windows.Forms.TabPage
    Friend WithEvents tabpageExistenciaBodega As System.Windows.Forms.TabPage
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents grdProveedor As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdCompatibilidad As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdBodegas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CtdbProveedor As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents ArchivoDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ErrorRepuesto As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblCantidadMinima As System.Windows.Forms.Label
    Friend WithEvents numCantidadMinima As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents numCantidadMaxima As DevExpress.XtraEditors.SpinEdit
End Class
