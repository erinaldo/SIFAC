<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidosEdit
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidosEdit))
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtaFechaAutorizado = New C1.Win.C1Input.C1DateEdit()
        Me.lblFechaAutorizada = New System.Windows.Forms.Label()
        Me.dtaFechaaPedir = New C1.Win.C1Input.C1DateEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.txtCodigoProveedor = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.spnTotalCosto = New DevExpress.XtraEditors.SpinEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdDetallePedidos = New DevExpress.XtraGrid.GridControl()
        Me.grdDetallePedidosTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImpuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostoUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.spnImpuestoUnitario = New DevExpress.XtraEditors.SpinEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.spnCostoUnitario = New DevExpress.XtraEditors.SpinEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbNombreProducto = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbMarca = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.spnCantidad = New DevExpress.XtraEditors.SpinEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblModeloCompatible = New System.Windows.Forms.Label()
        Me.cmbEstado = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorFactura = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dtaFechaAutorizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtaFechaaPedir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.spnTotalCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdDetallePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetallePedidosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.spnImpuestoUnitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnCostoUnitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNombreProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.dtaFechaAutorizado)
        Me.PanelControl1.Controls.Add(Me.lblFechaAutorizada)
        Me.PanelControl1.Controls.Add(Me.dtaFechaaPedir)
        Me.PanelControl1.Controls.Add(Me.Label14)
        Me.PanelControl1.Controls.Add(Me.txtNombreProveedor)
        Me.PanelControl1.Controls.Add(Me.txtCodigoProveedor)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.cmbEstado)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdAgregarProveedor)
        Me.PanelControl1.Controls.Add(Me.Label9)
        Me.PanelControl1.Controls.Add(Me.txtObservaciones)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.cmdProveedor)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(856, 559)
        Me.PanelControl1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 535)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 22)
        Me.Panel1.TabIndex = 131
        '
        'dtaFechaAutorizado
        '
        '
        '
        '
        Me.dtaFechaAutorizado.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtaFechaAutorizado.Calendar.BoldedDates = New Date(-1) {}
        Me.dtaFechaAutorizado.Calendar.ClearText = "&Clear"
        Me.dtaFechaAutorizado.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtaFechaAutorizado.Calendar.SelectedDate = New Date(2016, 8, 18, 0, 0, 0, 0)
        Me.dtaFechaAutorizado.Calendar.TodayText = "&Today"
        Me.dtaFechaAutorizado.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtaFechaAutorizado.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtaFechaAutorizado.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtaFechaAutorizado.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtaFechaAutorizado.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtaFechaAutorizado.Enabled = False
        Me.dtaFechaAutorizado.Location = New System.Drawing.Point(143, 101)
        Me.dtaFechaAutorizado.Name = "dtaFechaAutorizado"
        Me.dtaFechaAutorizado.Size = New System.Drawing.Size(171, 20)
        Me.dtaFechaAutorizado.TabIndex = 130
        Me.dtaFechaAutorizado.Tag = Nothing
        Me.dtaFechaAutorizado.Visible = False
        Me.dtaFechaAutorizado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaAutorizada
        '
        Me.lblFechaAutorizada.AutoSize = True
        Me.lblFechaAutorizada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAutorizada.Location = New System.Drawing.Point(31, 104)
        Me.lblFechaAutorizada.Name = "lblFechaAutorizada"
        Me.lblFechaAutorizada.Size = New System.Drawing.Size(110, 13)
        Me.lblFechaAutorizada.TabIndex = 129
        Me.lblFechaAutorizada.Text = "Fecha Autorizado:"
        Me.lblFechaAutorizada.Visible = False
        '
        'dtaFechaaPedir
        '
        '
        '
        '
        Me.dtaFechaaPedir.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtaFechaaPedir.Calendar.BoldedDates = New Date(-1) {}
        Me.dtaFechaaPedir.Calendar.ClearText = "&Clear"
        Me.dtaFechaaPedir.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtaFechaaPedir.Calendar.SelectedDate = New Date(2016, 8, 18, 0, 0, 0, 0)
        Me.dtaFechaaPedir.Calendar.TodayText = "&Today"
        Me.dtaFechaaPedir.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtaFechaaPedir.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtaFechaaPedir.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtaFechaaPedir.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtaFechaaPedir.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtaFechaaPedir.Enabled = False
        Me.dtaFechaaPedir.Location = New System.Drawing.Point(143, 75)
        Me.dtaFechaaPedir.Name = "dtaFechaaPedir"
        Me.dtaFechaaPedir.Size = New System.Drawing.Size(171, 20)
        Me.dtaFechaaPedir.TabIndex = 128
        Me.dtaFechaaPedir.Tag = Nothing
        Me.dtaFechaaPedir.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 127
        Me.Label14.Text = "Fecha a pedir:"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Enabled = False
        Me.txtNombreProveedor.Location = New System.Drawing.Point(251, 23)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(200, 20)
        Me.txtNombreProveedor.TabIndex = 126
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.Enabled = False
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(143, 23)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(103, 20)
        Me.txtCodigoProveedor.TabIndex = 125
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.spnTotalCosto)
        Me.GroupControl1.Controls.Add(Me.Label13)
        Me.GroupControl1.Controls.Add(Me.PictureBox1)
        Me.GroupControl1.Controls.Add(Me.GroupBox3)
        Me.GroupControl1.Controls.Add(Me.GroupBox2)
        Me.GroupControl1.Location = New System.Drawing.Point(25, 146)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(809, 342)
        Me.GroupControl1.TabIndex = 116
        Me.GroupControl1.Text = "Detalle"
        '
        'spnTotalCosto
        '
        Me.spnTotalCosto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnTotalCosto.Location = New System.Drawing.Point(662, 309)
        Me.spnTotalCosto.Name = "spnTotalCosto"
        Me.spnTotalCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.spnTotalCosto.Size = New System.Drawing.Size(128, 20)
        Me.spnTotalCosto.TabIndex = 129
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(553, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 18)
        Me.Label13.TabIndex = 128
        Me.Label13.Tag = ""
        Me.Label13.Text = "Costo Total:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIFAC.My.Resources.Resources.pedidos
        Me.PictureBox1.Location = New System.Drawing.Point(648, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdDetallePedidos)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(774, 145)
        Me.GroupBox3.TabIndex = 119
        Me.GroupBox3.TabStop = False
        '
        'grdDetallePedidos
        '
        Me.grdDetallePedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetallePedidos.Location = New System.Drawing.Point(3, 16)
        Me.grdDetallePedidos.LookAndFeel.SkinName = "Glass Oceans"
        Me.grdDetallePedidos.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.grdDetallePedidos.MainView = Me.grdDetallePedidosTabla
        Me.grdDetallePedidos.Name = "grdDetallePedidos"
        Me.grdDetallePedidos.Size = New System.Drawing.Size(768, 126)
        Me.grdDetallePedidos.TabIndex = 2
        Me.grdDetallePedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetallePedidosTabla})
        '
        'grdDetallePedidosTabla
        '
        Me.grdDetallePedidosTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductoID, Me.colCodigo, Me.colCategoria, Me.colNombre, Me.colCantidad, Me.colImpuesto, Me.colCostoTotal, Me.colCostoUnitario})
        Me.grdDetallePedidosTabla.GridControl = Me.grdDetallePedidos
        Me.grdDetallePedidosTabla.Name = "grdDetallePedidosTabla"
        Me.grdDetallePedidosTabla.OptionsView.ShowGroupPanel = False
        '
        'colProductoID
        '
        Me.colProductoID.Caption = "ProductoID"
        Me.colProductoID.FieldName = "SivProductoID"
        Me.colProductoID.Name = "colProductoID"
        Me.colProductoID.Width = 76
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 81
        '
        'colCategoria
        '
        Me.colCategoria.Caption = "Categoria"
        Me.colCategoria.FieldName = "Categoria"
        Me.colCategoria.Name = "colCategoria"
        Me.colCategoria.Width = 132
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Producto"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNombre.OptionsFilter.AllowAutoFilter = False
        Me.colNombre.OptionsFilter.AllowFilter = False
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 183
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCantidad.AppearanceHeader.Options.UseFont = True
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidad.OptionsFilter.AllowAutoFilter = False
        Me.colCantidad.OptionsFilter.AllowFilter = False
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 71
        '
        'colImpuesto
        '
        Me.colImpuesto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colImpuesto.AppearanceHeader.Options.UseFont = True
        Me.colImpuesto.AppearanceHeader.Options.UseTextOptions = True
        Me.colImpuesto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImpuesto.Caption = "Impuesto"
        Me.colImpuesto.Name = "colImpuesto"
        Me.colImpuesto.Visible = True
        Me.colImpuesto.VisibleIndex = 4
        '
        'colCostoTotal
        '
        Me.colCostoTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCostoTotal.AppearanceHeader.Options.UseFont = True
        Me.colCostoTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoTotal.Caption = "Costo Total"
        Me.colCostoTotal.FieldName = "CostoTotal"
        Me.colCostoTotal.Name = "colCostoTotal"
        Me.colCostoTotal.OptionsColumn.AllowEdit = False
        Me.colCostoTotal.Visible = True
        Me.colCostoTotal.VisibleIndex = 5
        Me.colCostoTotal.Width = 116
        '
        'colCostoUnitario
        '
        Me.colCostoUnitario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCostoUnitario.AppearanceHeader.Options.UseFont = True
        Me.colCostoUnitario.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCostoUnitario.Caption = "Costo Unitario"
        Me.colCostoUnitario.FieldName = "CostoUnitario"
        Me.colCostoUnitario.Name = "colCostoUnitario"
        Me.colCostoUnitario.Visible = True
        Me.colCostoUnitario.VisibleIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.spnImpuestoUnitario)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.spnCostoUnitario)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbNombreProducto)
        Me.GroupBox2.Controls.Add(Me.cmbMarca)
        Me.GroupBox2.Controls.Add(Me.cmdAgregar)
        Me.GroupBox2.Controls.Add(Me.cmbCategoria)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.lblNombreProducto)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.spnCantidad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblMarca)
        Me.GroupBox2.Controls.Add(Me.lblModeloCompatible)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 123)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Producto"
        '
        'spnImpuestoUnitario
        '
        Me.spnImpuestoUnitario.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnImpuestoUnitario.Location = New System.Drawing.Point(457, 85)
        Me.spnImpuestoUnitario.Name = "spnImpuestoUnitario"
        Me.spnImpuestoUnitario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.spnImpuestoUnitario.Size = New System.Drawing.Size(80, 20)
        Me.spnImpuestoUnitario.TabIndex = 129
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(335, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 18)
        Me.Label12.TabIndex = 128
        Me.Label12.Tag = ""
        Me.Label12.Text = "Impuesto unitario:"
        '
        'spnCostoUnitario
        '
        Me.spnCostoUnitario.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnCostoUnitario.Location = New System.Drawing.Point(457, 59)
        Me.spnCostoUnitario.Name = "spnCostoUnitario"
        Me.spnCostoUnitario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.spnCostoUnitario.Size = New System.Drawing.Size(80, 20)
        Me.spnCostoUnitario.TabIndex = 127
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(335, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 18)
        Me.Label11.TabIndex = 126
        Me.Label11.Tag = ""
        Me.Label11.Text = "Costo unitario:"
        '
        'cmbNombreProducto
        '
        Me.cmbNombreProducto.Location = New System.Drawing.Point(129, 84)
        Me.cmbNombreProducto.Name = "cmbNombreProducto"
        Me.cmbNombreProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNombreProducto.Properties.NullText = ""
        Me.cmbNombreProducto.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbNombreProducto.Size = New System.Drawing.Size(166, 20)
        Me.cmbNombreProducto.TabIndex = 125
        '
        'cmbMarca
        '
        Me.cmbMarca.Location = New System.Drawing.Point(129, 58)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMarca.Properties.NullText = ""
        Me.cmbMarca.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbMarca.Size = New System.Drawing.Size(166, 20)
        Me.cmbMarca.TabIndex = 124
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(574, 81)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregar.TabIndex = 115
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.Location = New System.Drawing.Point(129, 32)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategoria.Properties.NullText = ""
        Me.cmbCategoria.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbCategoria.Size = New System.Drawing.Size(166, 20)
        Me.cmbCategoria.TabIndex = 123
        '
        'dtpFecha
        '
        '
        '
        '
        Me.dtpFecha.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.ClearText = "&Clear"
        Me.dtpFecha.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 8, 18, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(559, -29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 14
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProducto.Location = New System.Drawing.Point(8, 85)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(103, 18)
        Me.lblNombreProducto.TabIndex = 120
        Me.lblNombreProducto.Tag = ""
        Me.lblNombreProducto.Text = "Producto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(475, -26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha:"
        '
        'spnCantidad
        '
        Me.spnCantidad.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnCantidad.Location = New System.Drawing.Point(457, 31)
        Me.spnCantidad.Name = "spnCantidad"
        Me.spnCantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.spnCantidad.Size = New System.Drawing.Size(80, 20)
        Me.spnCantidad.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(335, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 116
        Me.Label4.Tag = ""
        Me.Label4.Text = "Cantidad:"
        '
        'lblMarca
        '
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(8, 34)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(82, 18)
        Me.lblMarca.TabIndex = 101
        Me.lblMarca.Tag = ""
        Me.lblMarca.Text = "Categoria:"
        '
        'lblModeloCompatible
        '
        Me.lblModeloCompatible.BackColor = System.Drawing.Color.Transparent
        Me.lblModeloCompatible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloCompatible.Location = New System.Drawing.Point(8, 59)
        Me.lblModeloCompatible.Name = "lblModeloCompatible"
        Me.lblModeloCompatible.Size = New System.Drawing.Size(103, 18)
        Me.lblModeloCompatible.TabIndex = 102
        Me.lblModeloCompatible.Tag = ""
        Me.lblModeloCompatible.Text = "Marca:"
        '
        'cmbEstado
        '
        Me.cmbEstado.Location = New System.Drawing.Point(142, 49)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEstado.Properties.NullText = ""
        Me.cmbEstado.Size = New System.Drawing.Size(172, 20)
        Me.cmbEstado.TabIndex = 124
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(759, 494)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAgregarProveedor
        '
        Me.cmdAgregarProveedor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarProveedor.Appearance.Options.UseFont = True
        Me.cmdAgregarProveedor.Image = CType(resources.GetObject("cmdAgregarProveedor.Image"), System.Drawing.Image)
        Me.cmdAgregarProveedor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregarProveedor.Location = New System.Drawing.Point(487, 20)
        Me.cmdAgregarProveedor.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregarProveedor.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregarProveedor.Name = "cmdAgregarProveedor"
        Me.cmdAgregarProveedor.Size = New System.Drawing.Size(25, 26)
        Me.cmdAgregarProveedor.TabIndex = 116
        Me.cmdAgregarProveedor.Tag = "AGREGAR"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 118
        Me.Label9.Tag = ""
        Me.Label9.Text = "Estado:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(538, 46)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(292, 61)
        Me.txtObservaciones.TabIndex = 119
        Me.txtObservaciones.UseOptimizedRendering = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(535, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 18)
        Me.Label7.TabIndex = 118
        Me.Label7.Tag = ""
        Me.Label7.Text = "Observaciones:"
        '
        'cmdProveedor
        '
        Me.cmdProveedor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProveedor.Appearance.Options.UseFont = True
        Me.cmdProveedor.Image = CType(resources.GetObject("cmdProveedor.Image"), System.Drawing.Image)
        Me.cmdProveedor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdProveedor.Location = New System.Drawing.Point(458, 20)
        Me.cmdProveedor.LookAndFeel.SkinName = "Caramel"
        Me.cmdProveedor.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdProveedor.Name = "cmdProveedor"
        Me.cmdProveedor.Size = New System.Drawing.Size(25, 26)
        Me.cmdProveedor.TabIndex = 117
        Me.cmdProveedor.Tag = "BUSCAR"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(673, 494)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Proveedor:"
        '
        'ErrorFactura
        '
        Me.ErrorFactura.ContainerControl = Me
        '
        'frmPedidosEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 559)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedidosEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registar Pedidos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dtaFechaAutorizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaFechaaPedir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.spnTotalCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdDetallePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetallePedidosTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.spnImpuestoUnitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnCostoUnitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNombreProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtaFechaAutorizado As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFechaAutorizada As System.Windows.Forms.Label
    Friend WithEvents dtaFechaaPedir As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents spnTotalCosto As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetallePedidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetallePedidosTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProductoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImpuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents spnImpuestoUnitario As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents spnCostoUnitario As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbNombreProducto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbMarca As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCategoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblNombreProducto As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents spnCantidad As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblModeloCompatible As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ErrorFactura As System.Windows.Forms.ErrorProvider
End Class
