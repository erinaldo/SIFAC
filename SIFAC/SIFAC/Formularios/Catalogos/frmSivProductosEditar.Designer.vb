<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivProductosEditar
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivProductosEditar))
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.spnPrecioContado = New DevExpress.XtraEditors.SpinEdit()
        Me.spnMargenCredito = New DevExpress.XtraEditors.SpinEdit()
        Me.spnPrecioCredito = New DevExpress.XtraEditors.SpinEdit()
        Me.spnMargenContado = New DevExpress.XtraEditors.SpinEdit()
        Me.spnCostoPromedio = New DevExpress.XtraEditors.SpinEdit()
        Me.spnCantidadMinima = New DevExpress.XtraEditors.SpinEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCategoria = New C1.Win.C1List.C1Combo()
        Me.cbxMarca = New C1.Win.C1List.C1Combo()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblCilindraje = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.spnPrecioContado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnMargenCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnPrecioCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnMargenContado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnCostoPromedio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnCantidadMinima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbxCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 269)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 21)
        Me.Panel1.TabIndex = 23
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(777, 290)
        Me.PanelControl1.TabIndex = 24
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = Global.SIFAC.My.Resources.Resources.Cancel16
        Me.cmdCancelar.Location = New System.Drawing.Point(633, 228)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = Global.SIFAC.My.Resources.Resources.Guardar16
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(547, 228)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 7
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.spnPrecioContado)
        Me.GroupControl2.Controls.Add(Me.spnMargenCredito)
        Me.GroupControl2.Controls.Add(Me.spnPrecioCredito)
        Me.GroupControl2.Controls.Add(Me.spnMargenContado)
        Me.GroupControl2.Controls.Add(Me.spnCostoPromedio)
        Me.GroupControl2.Controls.Add(Me.spnCantidadMinima)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Location = New System.Drawing.Point(443, 14)
        Me.GroupControl2.LookAndFeel.SkinName = "Blue"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(310, 201)
        Me.GroupControl2.TabIndex = 6
        '
        'spnPrecioContado
        '
        Me.spnPrecioContado.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnPrecioContado.Location = New System.Drawing.Point(174, 83)
        Me.spnPrecioContado.Name = "spnPrecioContado"
        Me.spnPrecioContado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.spnPrecioContado.Size = New System.Drawing.Size(91, 20)
        Me.spnPrecioContado.TabIndex = 20
        '
        'spnMargenCredito
        '
        Me.spnMargenCredito.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnMargenCredito.Location = New System.Drawing.Point(174, 110)
        Me.spnMargenCredito.Name = "spnMargenCredito"
        Me.spnMargenCredito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.spnMargenCredito.Size = New System.Drawing.Size(91, 20)
        Me.spnMargenCredito.TabIndex = 20
        '
        'spnPrecioCredito
        '
        Me.spnPrecioCredito.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnPrecioCredito.Location = New System.Drawing.Point(174, 57)
        Me.spnPrecioCredito.Name = "spnPrecioCredito"
        Me.spnPrecioCredito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.spnPrecioCredito.Size = New System.Drawing.Size(91, 20)
        Me.spnPrecioCredito.TabIndex = 19
        '
        'spnMargenContado
        '
        Me.spnMargenContado.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnMargenContado.Location = New System.Drawing.Point(174, 136)
        Me.spnMargenContado.Name = "spnMargenContado"
        Me.spnMargenContado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.spnMargenContado.Size = New System.Drawing.Size(91, 20)
        Me.spnMargenContado.TabIndex = 21
        '
        'spnCostoPromedio
        '
        Me.spnCostoPromedio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnCostoPromedio.Location = New System.Drawing.Point(174, 27)
        Me.spnCostoPromedio.Name = "spnCostoPromedio"
        Me.spnCostoPromedio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.spnCostoPromedio.Size = New System.Drawing.Size(91, 20)
        Me.spnCostoPromedio.TabIndex = 9
        '
        'spnCantidadMinima
        '
        Me.spnCantidadMinima.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnCantidadMinima.Location = New System.Drawing.Point(174, 163)
        Me.spnCantidadMinima.Name = "spnCantidadMinima"
        Me.spnCantidadMinima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.spnCantidadMinima.Size = New System.Drawing.Size(91, 20)
        Me.spnCantidadMinima.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Tag = "OBLIGATORIO"
        Me.Label7.Text = "Cantidad Minima:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Tag = "OBLIGATORIO"
        Me.Label6.Text = "Margen Utilidad Contado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Tag = "OBLIGATORIO"
        Me.Label5.Text = "Margen Utilidad Credito:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Tag = "OBLIGATORIO"
        Me.Label4.Text = "Precio Contado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Tag = "OBLIGATORIO"
        Me.Label3.Text = "Precio Credito:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Costo Promedio:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.cbxCategoria)
        Me.GroupControl1.Controls.Add(Me.cbxMarca)
        Me.GroupControl1.Controls.Add(Me.txtProducto)
        Me.GroupControl1.Controls.Add(Me.chkActivo)
        Me.GroupControl1.Controls.Add(Me.lblCilindraje)
        Me.GroupControl1.Controls.Add(Me.lblMarca)
        Me.GroupControl1.Controls.Add(Me.lblModelo)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 14)
        Me.GroupControl1.LookAndFeel.SkinName = "Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(416, 201)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos del Producto"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(92, 81)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(279, 20)
        Me.txtNombre.TabIndex = 15
        Me.txtNombre.Tag = "OBLIGATORIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Nombre:"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cbxCategoria.Caption = ""
        Me.cbxCategoria.CaptionHeight = 17
        Me.cbxCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbxCategoria.ColumnCaptionHeight = 17
        Me.cbxCategoria.ColumnFooterHeight = 17
        Me.cbxCategoria.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cbxCategoria.ContentHeight = 15
        Me.cbxCategoria.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cbxCategoria.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cbxCategoria.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategoria.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cbxCategoria.EditorHeight = 15
        Me.cbxCategoria.Images.Add(CType(resources.GetObject("cbxCategoria.Images"), System.Drawing.Image))
        Me.cbxCategoria.ItemHeight = 15
        Me.cbxCategoria.Location = New System.Drawing.Point(92, 108)
        Me.cbxCategoria.MatchEntryTimeout = CType(2000, Long)
        Me.cbxCategoria.MaxDropDownItems = CType(5, Short)
        Me.cbxCategoria.MaxLength = 32767
        Me.cbxCategoria.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cbxCategoria.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cbxCategoria.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cbxCategoria.Size = New System.Drawing.Size(279, 21)
        Me.cbxCategoria.TabIndex = 9
        Me.cbxCategoria.Tag = "OBLIGATORIO"
        Me.cbxCategoria.PropBag = resources.GetString("cbxCategoria.PropBag")
        '
        'cbxMarca
        '
        Me.cbxMarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cbxMarca.Caption = ""
        Me.cbxMarca.CaptionHeight = 17
        Me.cbxMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbxMarca.ColumnCaptionHeight = 17
        Me.cbxMarca.ColumnFooterHeight = 17
        Me.cbxMarca.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cbxMarca.ContentHeight = 15
        Me.cbxMarca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cbxMarca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cbxMarca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMarca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cbxMarca.EditorHeight = 15
        Me.cbxMarca.Images.Add(CType(resources.GetObject("cbxMarca.Images"), System.Drawing.Image))
        Me.cbxMarca.ItemHeight = 15
        Me.cbxMarca.Location = New System.Drawing.Point(92, 135)
        Me.cbxMarca.MatchEntryTimeout = CType(2000, Long)
        Me.cbxMarca.MaxDropDownItems = CType(5, Short)
        Me.cbxMarca.MaxLength = 32767
        Me.cbxMarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cbxMarca.Name = "cbxMarca"
        Me.cbxMarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cbxMarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cbxMarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cbxMarca.Size = New System.Drawing.Size(279, 21)
        Me.cbxMarca.TabIndex = 7
        Me.cbxMarca.Tag = "OBLIGATORIO"
        Me.cbxMarca.PropBag = resources.GetString("cbxMarca.PropBag")
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(92, 55)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(279, 20)
        Me.txtProducto.TabIndex = 5
        Me.txtProducto.Tag = "OBLIGATORIO"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(311, 171)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 13
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblCilindraje
        '
        Me.lblCilindraje.AutoSize = True
        Me.lblCilindraje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCilindraje.Location = New System.Drawing.Point(19, 112)
        Me.lblCilindraje.Name = "lblCilindraje"
        Me.lblCilindraje.Size = New System.Drawing.Size(65, 13)
        Me.lblCilindraje.TabIndex = 10
        Me.lblCilindraje.Tag = "OBLIGATORIO"
        Me.lblCilindraje.Text = "Categoria:"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(19, 139)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(46, 13)
        Me.lblMarca.TabIndex = 8
        Me.lblMarca.Tag = "OBLIGATORIO"
        Me.lblMarca.Text = "Marca:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(19, 59)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(50, 13)
        Me.lblModelo.TabIndex = 6
        Me.lblModelo.Tag = "OBLIGATORIO"
        Me.lblModelo.Text = "Codigo:"
        '
        'frmSivProductosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 290)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivProductosEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Producto"
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.spnPrecioContado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnMargenCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnPrecioCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnMargenContado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnCostoPromedio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnCantidadMinima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbxCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxCategoria As C1.Win.C1List.C1Combo
    Friend WithEvents cbxMarca As C1.Win.C1List.C1Combo
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblCilindraje As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spnPrecioContado As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnMargenCredito As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnPrecioCredito As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnMargenContado As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnCostoPromedio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnCantidadMinima As DevExpress.XtraEditors.SpinEdit
End Class
