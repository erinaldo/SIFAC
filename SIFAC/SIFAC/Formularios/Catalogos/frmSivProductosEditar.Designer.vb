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
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivProductosEditar))
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.tbcMasDatos = New System.Windows.Forms.TabControl()
        Me.tabpageProveedor = New System.Windows.Forms.TabPage()
        Me.CtdbProveedor = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grdProveedor = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tabpageExistenciaBodega = New System.Windows.Forms.TabPage()
        Me.grdBodegas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
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
        Me.cmbMarca = New C1.Win.C1List.C1Combo()
        Me.cmbCategoria = New C1.Win.C1List.C1Combo()
        Me.cmdAgregarMarca = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarCategoria = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblCilindraje = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.tbcMasDatos.SuspendLayout()
        Me.tabpageProveedor.SuspendLayout()
        CType(Me.CtdbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageExistenciaBodega.SuspendLayout()
        CType(Me.grdBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 566)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 21)
        Me.Panel1.TabIndex = 23
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.tbcMasDatos)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(769, 587)
        Me.PanelControl1.TabIndex = 24
        '
        'tbcMasDatos
        '
        Me.tbcMasDatos.Controls.Add(Me.tabpageProveedor)
        Me.tbcMasDatos.Controls.Add(Me.tabpageExistenciaBodega)
        Me.tbcMasDatos.Location = New System.Drawing.Point(12, 228)
        Me.tbcMasDatos.Name = "tbcMasDatos"
        Me.tbcMasDatos.SelectedIndex = 0
        Me.tbcMasDatos.Size = New System.Drawing.Size(551, 312)
        Me.tbcMasDatos.TabIndex = 16
        '
        'tabpageProveedor
        '
        Me.tabpageProveedor.Controls.Add(Me.CtdbProveedor)
        Me.tabpageProveedor.Controls.Add(Me.grdProveedor)
        Me.tabpageProveedor.Location = New System.Drawing.Point(4, 22)
        Me.tabpageProveedor.Name = "tabpageProveedor"
        Me.tabpageProveedor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageProveedor.Size = New System.Drawing.Size(543, 286)
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
        Me.CtdbProveedor.CaptionStyle = Style1
        Me.CtdbProveedor.ColumnCaptionHeight = 17
        Me.CtdbProveedor.ColumnFooterHeight = 17
        Me.CtdbProveedor.ColumnHeaders = False
        Me.CtdbProveedor.EvenRowStyle = Style2
        Me.CtdbProveedor.FetchRowStyles = False
        Me.CtdbProveedor.FooterStyle = Style3
        Me.CtdbProveedor.HeadingStyle = Style4
        Me.CtdbProveedor.HighLightRowStyle = Style5
        Me.CtdbProveedor.Images.Add(CType(resources.GetObject("CtdbProveedor.Images"), System.Drawing.Image))
        Me.CtdbProveedor.Location = New System.Drawing.Point(39, 89)
        Me.CtdbProveedor.Name = "CtdbProveedor"
        Me.CtdbProveedor.OddRowStyle = Style6
        Me.CtdbProveedor.RecordSelectorStyle = Style7
        Me.CtdbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CtdbProveedor.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.CtdbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CtdbProveedor.ScrollTips = False
        Me.CtdbProveedor.Size = New System.Drawing.Size(223, 88)
        Me.CtdbProveedor.Style = Style8
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
        Me.grdProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProveedor.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdProveedor.Images.Add(CType(resources.GetObject("grdProveedor.Images"), System.Drawing.Image))
        Me.grdProveedor.Location = New System.Drawing.Point(3, 3)
        Me.grdProveedor.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
        Me.grdProveedor.Name = "grdProveedor"
        Me.grdProveedor.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdProveedor.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdProveedor.PreviewInfo.ZoomFactor = 75.0R
        Me.grdProveedor.PrintInfo.PageSettings = CType(resources.GetObject("grdProveedor.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdProveedor.Size = New System.Drawing.Size(537, 280)
        Me.grdProveedor.TabIndex = 0
        Me.grdProveedor.PropBag = resources.GetString("grdProveedor.PropBag")
        '
        'tabpageExistenciaBodega
        '
        Me.tabpageExistenciaBodega.Controls.Add(Me.grdBodegas)
        Me.tabpageExistenciaBodega.Location = New System.Drawing.Point(4, 22)
        Me.tabpageExistenciaBodega.Name = "tabpageExistenciaBodega"
        Me.tabpageExistenciaBodega.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageExistenciaBodega.Size = New System.Drawing.Size(543, 286)
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
        Me.grdBodegas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdBodegas.PrintInfo.PageSettings = CType(resources.GetObject("grdBodegas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdBodegas.Size = New System.Drawing.Size(537, 280)
        Me.grdBodegas.TabIndex = 0
        Me.grdBodegas.Text = "C1TrueDBGrid1"
        Me.grdBodegas.PropBag = resources.GetString("grdBodegas.PropBag")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(673, 508)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(587, 508)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 11
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
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
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
        Me.spnPrecioContado.Properties.DisplayFormat.FormatString = "n"
        Me.spnPrecioContado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnPrecioContado.Properties.Mask.EditMask = "n"
        Me.spnPrecioContado.Size = New System.Drawing.Size(91, 20)
        Me.spnPrecioContado.TabIndex = 7
        '
        'spnMargenCredito
        '
        Me.spnMargenCredito.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnMargenCredito.Location = New System.Drawing.Point(174, 110)
        Me.spnMargenCredito.Name = "spnMargenCredito"
        Me.spnMargenCredito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.spnMargenCredito.Properties.DisplayFormat.FormatString = "n"
        Me.spnMargenCredito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnMargenCredito.Properties.Mask.EditMask = "n"
        Me.spnMargenCredito.Size = New System.Drawing.Size(91, 20)
        Me.spnMargenCredito.TabIndex = 8
        '
        'spnPrecioCredito
        '
        Me.spnPrecioCredito.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnPrecioCredito.Location = New System.Drawing.Point(174, 57)
        Me.spnPrecioCredito.Name = "spnPrecioCredito"
        Me.spnPrecioCredito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.spnPrecioCredito.Properties.DisplayFormat.FormatString = "n"
        Me.spnPrecioCredito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnPrecioCredito.Properties.Mask.EditMask = "n"
        Me.spnPrecioCredito.Size = New System.Drawing.Size(91, 20)
        Me.spnPrecioCredito.TabIndex = 6
        '
        'spnMargenContado
        '
        Me.spnMargenContado.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnMargenContado.Location = New System.Drawing.Point(174, 136)
        Me.spnMargenContado.Name = "spnMargenContado"
        Me.spnMargenContado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.spnMargenContado.Properties.DisplayFormat.FormatString = "n"
        Me.spnMargenContado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnMargenContado.Properties.Mask.EditMask = "n"
        Me.spnMargenContado.Size = New System.Drawing.Size(91, 20)
        Me.spnMargenContado.TabIndex = 0
        '
        'spnCostoPromedio
        '
        Me.spnCostoPromedio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnCostoPromedio.Location = New System.Drawing.Point(174, 27)
        Me.spnCostoPromedio.Name = "spnCostoPromedio"
        Me.spnCostoPromedio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.spnCostoPromedio.Properties.DisplayFormat.FormatString = "n"
        Me.spnCostoPromedio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnCostoPromedio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnCostoPromedio.Size = New System.Drawing.Size(91, 20)
        Me.spnCostoPromedio.TabIndex = 5
        '
        'spnCantidadMinima
        '
        Me.spnCantidadMinima.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnCantidadMinima.Location = New System.Drawing.Point(174, 163)
        Me.spnCantidadMinima.Name = "spnCantidadMinima"
        Me.spnCantidadMinima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.spnCantidadMinima.Size = New System.Drawing.Size(91, 20)
        Me.spnCantidadMinima.TabIndex = 10
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
        Me.GroupControl1.Controls.Add(Me.cmbMarca)
        Me.GroupControl1.Controls.Add(Me.cmbCategoria)
        Me.GroupControl1.Controls.Add(Me.cmdAgregarMarca)
        Me.GroupControl1.Controls.Add(Me.cmdAgregarCategoria)
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.txtProducto)
        Me.GroupControl1.Controls.Add(Me.chkActivo)
        Me.GroupControl1.Controls.Add(Me.lblCilindraje)
        Me.GroupControl1.Controls.Add(Me.lblMarca)
        Me.GroupControl1.Controls.Add(Me.lblModelo)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 14)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(416, 201)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos del Producto"
        '
        'cmbMarca
        '
        Me.cmbMarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMarca.AutoCompletion = True
        Me.cmbMarca.AutoDropDown = True
        Me.cmbMarca.Caption = ""
        Me.cmbMarca.CaptionHeight = 17
        Me.cmbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMarca.ColumnCaptionHeight = 17
        Me.cmbMarca.ColumnFooterHeight = 17
        Me.cmbMarca.ContentHeight = 15
        Me.cmbMarca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMarca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMarca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMarca.EditorHeight = 15
        Me.cmbMarca.Images.Add(CType(resources.GetObject("cmbMarca.Images"), System.Drawing.Image))
        Me.cmbMarca.ItemHeight = 15
        Me.cmbMarca.Location = New System.Drawing.Point(92, 140)
        Me.cmbMarca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMarca.MaxDropDownItems = CType(5, Short)
        Me.cmbMarca.MaxLength = 32767
        Me.cmbMarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMarca.Size = New System.Drawing.Size(279, 21)
        Me.cmbMarca.TabIndex = 134
        Me.cmbMarca.Tag = "OBLIGATORIO"
        Me.cmbMarca.PropBag = resources.GetString("cmbMarca.PropBag")
        '
        'cmbCategoria
        '
        Me.cmbCategoria.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCategoria.AutoCompletion = True
        Me.cmbCategoria.AutoDropDown = True
        Me.cmbCategoria.Caption = ""
        Me.cmbCategoria.CaptionHeight = 17
        Me.cmbCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCategoria.ColumnCaptionHeight = 17
        Me.cmbCategoria.ColumnFooterHeight = 17
        Me.cmbCategoria.ContentHeight = 15
        Me.cmbCategoria.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCategoria.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCategoria.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoria.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCategoria.EditorHeight = 15
        Me.cmbCategoria.Images.Add(CType(resources.GetObject("cmbCategoria.Images"), System.Drawing.Image))
        Me.cmbCategoria.ItemHeight = 15
        Me.cmbCategoria.Location = New System.Drawing.Point(94, 109)
        Me.cmbCategoria.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCategoria.MaxDropDownItems = CType(5, Short)
        Me.cmbCategoria.MaxLength = 32767
        Me.cmbCategoria.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCategoria.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCategoria.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCategoria.Size = New System.Drawing.Size(279, 21)
        Me.cmbCategoria.TabIndex = 135
        Me.cmbCategoria.Tag = "OBLIGATORIO"
        Me.cmbCategoria.PropBag = resources.GetString("cmbCategoria.PropBag")
        '
        'cmdAgregarMarca
        '
        Me.cmdAgregarMarca.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarMarca.Appearance.Options.UseFont = True
        Me.cmdAgregarMarca.Image = CType(resources.GetObject("cmdAgregarMarca.Image"), System.Drawing.Image)
        Me.cmdAgregarMarca.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregarMarca.Location = New System.Drawing.Point(377, 136)
        Me.cmdAgregarMarca.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregarMarca.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregarMarca.Name = "cmdAgregarMarca"
        Me.cmdAgregarMarca.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarMarca.TabIndex = 117
        Me.cmdAgregarMarca.Tag = "AGREGAR MARCA"
        '
        'cmdAgregarCategoria
        '
        Me.cmdAgregarCategoria.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarCategoria.Appearance.Options.UseFont = True
        Me.cmdAgregarCategoria.Image = CType(resources.GetObject("cmdAgregarCategoria.Image"), System.Drawing.Image)
        Me.cmdAgregarCategoria.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregarCategoria.Location = New System.Drawing.Point(377, 105)
        Me.cmdAgregarCategoria.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregarCategoria.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregarCategoria.Name = "cmdAgregarCategoria"
        Me.cmdAgregarCategoria.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregarCategoria.TabIndex = 116
        Me.cmdAgregarCategoria.Tag = "AGREGAR CATEGORIA"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(92, 81)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(279, 20)
        Me.txtNombre.TabIndex = 1
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
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(92, 55)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(279, 20)
        Me.txtProducto.TabIndex = 0
        Me.txtProducto.Tag = "OBLIGATORIO"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(311, 171)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 4
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
        Me.lblModelo.Size = New System.Drawing.Size(52, 13)
        Me.lblModelo.TabIndex = 6
        Me.lblModelo.Tag = "OBLIGATORIO"
        Me.lblModelo.Text = "Modelo:"
        '
        'frmSivProductosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 587)
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
        Me.tbcMasDatos.ResumeLayout(False)
        Me.tabpageProveedor.ResumeLayout(False)
        CType(Me.CtdbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageExistenciaBodega.ResumeLayout(False)
        CType(Me.grdBodegas, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategoria, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbcMasDatos As System.Windows.Forms.TabControl
    Friend WithEvents tabpageProveedor As System.Windows.Forms.TabPage
    Friend WithEvents CtdbProveedor As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents tabpageExistenciaBodega As System.Windows.Forms.TabPage
    Friend WithEvents grdBodegas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAgregarMarca As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarCategoria As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdProveedor As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmbMarca As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCategoria As C1.Win.C1List.C1Combo
End Class
