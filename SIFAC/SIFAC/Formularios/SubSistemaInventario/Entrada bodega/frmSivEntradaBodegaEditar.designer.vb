<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivEntradaBodegaEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivEntradaBodegaEditar))
        Me.grdPreliquidaciones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colgrdPrelCantidadFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdDetalleEntradasBodegasDE = New DevExpress.XtraGrid.GridControl
        Me.grdDetalleEntradasBodegasDETabla = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoRepuesto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnCodigoRepuesto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodigoProveedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdtxtCodigoProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdcmbDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCantidadFacturada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colCantidadPreliquidada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnCantidadPreliquidada = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colCantidadEntrada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnCantidadEntrada = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colCantidadFalta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnCantidadFalta = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colCostoDolares = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnCostoDolares = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colBarCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdtxtBarCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPrecioEstimado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnPrecioEstimado = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.grdDetalleEntradasBodegasDENivel1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.ColCodigoPrel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCantidadFacturadaPrel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCantidadPreliquidadaPrel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCantidadEntradaPrel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCantidadFaltaPrel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCantidadFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox
        Me.cmbTipoAjuste = New C1.Win.C1List.C1Combo
        Me.lblTipoAjuste = New System.Windows.Forms.Label
        Me.cmbTipoEntrada = New C1.Win.C1List.C1Combo
        Me.cmbProveedor = New C1.Win.C1List.C1Combo
        Me.cmbBodega = New C1.Win.C1List.C1Combo
        Me.lblTipoEntrada = New System.Windows.Forms.Label
        Me.lblFechaEntrada = New System.Windows.Forms.Label
        Me.lblProveedor = New System.Windows.Forms.Label
        Me.lblBodega = New System.Windows.Forms.Label
        Me.dtpFechaEntrada = New C1.Win.C1Input.C1DateEdit
        Me.txtNumeroEntrada = New System.Windows.Forms.TextBox
        Me.lblNoEntrada = New System.Windows.Forms.Label
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbxOtrosDatos = New System.Windows.Forms.GroupBox
        Me.dtpFechaFactura = New C1.Win.C1Input.C1DateEdit
        Me.lblFechaFactura = New System.Windows.Forms.Label
        Me.txtNumeroPoliza = New System.Windows.Forms.TextBox
        Me.lblNumeroPoliza = New System.Windows.Forms.Label
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox
        Me.lblNumeroFactura = New System.Windows.Forms.Label
        Me.txtComentarios = New System.Windows.Forms.TextBox
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.lblCostoTotal = New System.Windows.Forms.Label
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.NumCostoTotal = New C1.Win.C1Input.C1NumericEdit
        Me.gbxDetalle = New System.Windows.Forms.GroupBox
        CType(Me.grdPreliquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleEntradasBodegasDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleEntradasBodegasDETabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdtxtCodigoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidadPreliquidada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidadEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidadFalta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCostoDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdtxtBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnPrecioEstimado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleEntradasBodegasDENivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbTipoAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOtrosDatos.SuspendLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdPreliquidaciones
        '
        Me.grdPreliquidaciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colgrdPrelCantidadFactura})
        Me.grdPreliquidaciones.GridControl = Me.grdDetalleEntradasBodegasDE
        Me.grdPreliquidaciones.Name = "grdPreliquidaciones"
        '
        'colgrdPrelCantidadFactura
        '
        Me.colgrdPrelCantidadFactura.Caption = "CantidadFactura"
        Me.colgrdPrelCantidadFactura.FieldName = "CantidadFactura"
        Me.colgrdPrelCantidadFactura.Name = "colgrdPrelCantidadFactura"
        '
        'grdDetalleEntradasBodegasDE
        '
        Me.grdDetalleEntradasBodegasDE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalleEntradasBodegasDE.EmbeddedNavigator.Name = ""
        Me.grdDetalleEntradasBodegasDE.Location = New System.Drawing.Point(3, 16)
        Me.grdDetalleEntradasBodegasDE.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.grdDetalleEntradasBodegasDE.MainView = Me.grdDetalleEntradasBodegasDETabla
        Me.grdDetalleEntradasBodegasDE.Name = "grdDetalleEntradasBodegasDE"
        Me.grdDetalleEntradasBodegasDE.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grdtxtCodigoProveedor, Me.grdcmbDescripcion, Me.grdspnCantidad, Me.grdspnCantidadPreliquidada, Me.grdspnCantidadEntrada, Me.grdspnCantidadFalta, Me.grdspnCostoDolares, Me.grdspnTotal, Me.grdtxtBarCode, Me.grdspnPrecioEstimado, Me.grdspnCodigoRepuesto})
        Me.grdDetalleEntradasBodegasDE.Size = New System.Drawing.Size(812, 217)
        Me.grdDetalleEntradasBodegasDE.TabIndex = 0
        Me.grdDetalleEntradasBodegasDE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleEntradasBodegasDETabla, Me.grdDetalleEntradasBodegasDENivel1, Me.GridView1, Me.grdPreliquidaciones})
        '
        'grdDetalleEntradasBodegasDETabla
        '
        Me.grdDetalleEntradasBodegasDETabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoRepuesto, Me.colCodigoProveedor, Me.colDescripcion, Me.colCantidadFacturada, Me.colCantidadPreliquidada, Me.colCantidadEntrada, Me.colCantidadFalta, Me.colCostoDolares, Me.colTotal, Me.colBarCode, Me.colPrecioEstimado})
        Me.grdDetalleEntradasBodegasDETabla.GridControl = Me.grdDetalleEntradasBodegasDE
        Me.grdDetalleEntradasBodegasDETabla.Name = "grdDetalleEntradasBodegasDETabla"
        Me.grdDetalleEntradasBodegasDETabla.OptionsView.ShowGroupPanel = False
        '
        'colCodigoRepuesto
        '
        Me.colCodigoRepuesto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoRepuesto.AppearanceHeader.Options.UseFont = True
        Me.colCodigoRepuesto.Caption = "C�digo"
        Me.colCodigoRepuesto.ColumnEdit = Me.grdspnCodigoRepuesto
        Me.colCodigoRepuesto.FieldName = "objRepuestoID"
        Me.colCodigoRepuesto.Name = "colCodigoRepuesto"
        Me.colCodigoRepuesto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoRepuesto.OptionsFilter.AllowAutoFilter = False
        Me.colCodigoRepuesto.OptionsFilter.AllowFilter = False
        Me.colCodigoRepuesto.Visible = True
        Me.colCodigoRepuesto.VisibleIndex = 1
        Me.colCodigoRepuesto.Width = 96
        '
        'grdspnCodigoRepuesto
        '
        Me.grdspnCodigoRepuesto.AutoHeight = False
        Me.grdspnCodigoRepuesto.Name = "grdspnCodigoRepuesto"
        '
        'colCodigoProveedor
        '
        Me.colCodigoProveedor.Caption = "C�digo Proveedor"
        Me.colCodigoProveedor.ColumnEdit = Me.grdtxtCodigoProveedor
        Me.colCodigoProveedor.FieldName = "CodigoRepuesto"
        Me.colCodigoProveedor.Name = "colCodigoProveedor"
        Me.colCodigoProveedor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoProveedor.OptionsFilter.AllowAutoFilter = False
        Me.colCodigoProveedor.OptionsFilter.AllowFilter = False
        Me.colCodigoProveedor.Visible = True
        Me.colCodigoProveedor.VisibleIndex = 2
        Me.colCodigoProveedor.Width = 95
        '
        'grdtxtCodigoProveedor
        '
        Me.grdtxtCodigoProveedor.AutoHeight = False
        Me.grdtxtCodigoProveedor.Name = "grdtxtCodigoProveedor"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripci�n Corta"
        Me.colDescripcion.ColumnEdit = Me.grdcmbDescripcion
        Me.colDescripcion.FieldName = "objRepuestoID"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescripcion.OptionsFilter.AllowAutoFilter = False
        Me.colDescripcion.OptionsFilter.AllowFilter = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 3
        Me.colDescripcion.Width = 140
        '
        'grdcmbDescripcion
        '
        Me.grdcmbDescripcion.AutoHeight = False
        Me.grdcmbDescripcion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grdcmbDescripcion.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SivRepuestoID", "C�digo", 10, DevExpress.Utils.FormatType.Custom, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionCorta", "Descripci�n", 30, DevExpress.Utils.FormatType.Custom, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.grdcmbDescripcion.DisplayMember = "DescripcionCorta"
        Me.grdcmbDescripcion.Name = "grdcmbDescripcion"
        Me.grdcmbDescripcion.NullText = ""
        Me.grdcmbDescripcion.ValueMember = "SivRepuestoID"
        '
        'colCantidadFacturada
        '
        Me.colCantidadFacturada.Caption = "Cant. Fact."
        Me.colCantidadFacturada.ColumnEdit = Me.grdspnCantidad
        Me.colCantidadFacturada.FieldName = "CantidadFactura"
        Me.colCantidadFacturada.Name = "colCantidadFacturada"
        Me.colCantidadFacturada.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidadFacturada.OptionsFilter.AllowAutoFilter = False
        Me.colCantidadFacturada.OptionsFilter.AllowFilter = False
        Me.colCantidadFacturada.Visible = True
        Me.colCantidadFacturada.VisibleIndex = 4
        Me.colCantidadFacturada.Width = 64
        '
        'grdspnCantidad
        '
        Me.grdspnCantidad.AutoHeight = False
        Me.grdspnCantidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnCantidad.EditFormat.FormatString = "#"
        Me.grdspnCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdspnCantidad.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCantidad.Name = "grdspnCantidad"
        Me.grdspnCantidad.UseCtrlIncrement = False
        '
        'colCantidadPreliquidada
        '
        Me.colCantidadPreliquidada.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colCantidadPreliquidada.AppearanceCell.Options.UseBackColor = True
        Me.colCantidadPreliquidada.Caption = "Cant. Prel."
        Me.colCantidadPreliquidada.ColumnEdit = Me.grdspnCantidadPreliquidada
        Me.colCantidadPreliquidada.FieldName = "CantidadEnPreli"
        Me.colCantidadPreliquidada.Name = "colCantidadPreliquidada"
        Me.colCantidadPreliquidada.OptionsColumn.AllowFocus = False
        Me.colCantidadPreliquidada.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidadPreliquidada.OptionsColumn.ReadOnly = True
        Me.colCantidadPreliquidada.OptionsFilter.AllowAutoFilter = False
        Me.colCantidadPreliquidada.OptionsFilter.AllowFilter = False
        Me.colCantidadPreliquidada.Visible = True
        Me.colCantidadPreliquidada.VisibleIndex = 5
        Me.colCantidadPreliquidada.Width = 62
        '
        'grdspnCantidadPreliquidada
        '
        Me.grdspnCantidadPreliquidada.AutoHeight = False
        Me.grdspnCantidadPreliquidada.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnCantidadPreliquidada.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCantidadPreliquidada.Name = "grdspnCantidadPreliquidada"
        Me.grdspnCantidadPreliquidada.UseCtrlIncrement = True
        '
        'colCantidadEntrada
        '
        Me.colCantidadEntrada.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colCantidadEntrada.AppearanceCell.Options.UseBackColor = True
        Me.colCantidadEntrada.Caption = "Cant. Ent."
        Me.colCantidadEntrada.ColumnEdit = Me.grdspnCantidadEntrada
        Me.colCantidadEntrada.FieldName = "CantidaEntrada"
        Me.colCantidadEntrada.Name = "colCantidadEntrada"
        Me.colCantidadEntrada.OptionsColumn.AllowFocus = False
        Me.colCantidadEntrada.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidadEntrada.OptionsColumn.ReadOnly = True
        Me.colCantidadEntrada.OptionsFilter.AllowAutoFilter = False
        Me.colCantidadEntrada.OptionsFilter.AllowFilter = False
        Me.colCantidadEntrada.Visible = True
        Me.colCantidadEntrada.VisibleIndex = 6
        Me.colCantidadEntrada.Width = 60
        '
        'grdspnCantidadEntrada
        '
        Me.grdspnCantidadEntrada.AutoHeight = False
        Me.grdspnCantidadEntrada.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnCantidadEntrada.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCantidadEntrada.Name = "grdspnCantidadEntrada"
        Me.grdspnCantidadEntrada.UseCtrlIncrement = False
        '
        'colCantidadFalta
        '
        Me.colCantidadFalta.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colCantidadFalta.AppearanceCell.Options.UseBackColor = True
        Me.colCantidadFalta.Caption = "Cant. Falta"
        Me.colCantidadFalta.ColumnEdit = Me.grdspnCantidadFalta
        Me.colCantidadFalta.FieldName = "CantidadFalta"
        Me.colCantidadFalta.Name = "colCantidadFalta"
        Me.colCantidadFalta.OptionsColumn.AllowFocus = False
        Me.colCantidadFalta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidadFalta.OptionsColumn.ReadOnly = True
        Me.colCantidadFalta.OptionsFilter.AllowAutoFilter = False
        Me.colCantidadFalta.OptionsFilter.AllowFilter = False
        Me.colCantidadFalta.Visible = True
        Me.colCantidadFalta.VisibleIndex = 7
        Me.colCantidadFalta.Width = 64
        '
        'grdspnCantidadFalta
        '
        Me.grdspnCantidadFalta.AutoHeight = False
        Me.grdspnCantidadFalta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnCantidadFalta.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCantidadFalta.Name = "grdspnCantidadFalta"
        Me.grdspnCantidadFalta.UseCtrlIncrement = False
        '
        'colCostoDolares
        '
        Me.colCostoDolares.Caption = "Costo U$"
        Me.colCostoDolares.ColumnEdit = Me.grdspnCostoDolares
        Me.colCostoDolares.FieldName = "Costo"
        Me.colCostoDolares.Name = "colCostoDolares"
        Me.colCostoDolares.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCostoDolares.OptionsFilter.AllowAutoFilter = False
        Me.colCostoDolares.OptionsFilter.AllowFilter = False
        Me.colCostoDolares.Visible = True
        Me.colCostoDolares.VisibleIndex = 8
        Me.colCostoDolares.Width = 54
        '
        'grdspnCostoDolares
        '
        Me.grdspnCostoDolares.AutoHeight = False
        Me.grdspnCostoDolares.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnCostoDolares.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCostoDolares.Name = "grdspnCostoDolares"
        Me.grdspnCostoDolares.UseCtrlIncrement = False
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colTotal.AppearanceCell.Options.UseBackColor = True
        Me.colTotal.Caption = "Total"
        Me.colTotal.ColumnEdit = Me.grdspnTotal
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowFocus = False
        Me.colTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.OptionsFilter.AllowAutoFilter = False
        Me.colTotal.OptionsFilter.AllowFilter = False
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 9
        Me.colTotal.Width = 39
        '
        'grdspnTotal
        '
        Me.grdspnTotal.AutoHeight = False
        Me.grdspnTotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnTotal.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnTotal.Name = "grdspnTotal"
        Me.grdspnTotal.UseCtrlIncrement = False
        '
        'colBarCode
        '
        Me.colBarCode.Caption = "Bar Code"
        Me.colBarCode.ColumnEdit = Me.grdtxtBarCode
        Me.colBarCode.FieldName = "CodigoBarras"
        Me.colBarCode.Name = "colBarCode"
        Me.colBarCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colBarCode.OptionsFilter.AllowAutoFilter = False
        Me.colBarCode.OptionsFilter.AllowFilter = False
        Me.colBarCode.Visible = True
        Me.colBarCode.VisibleIndex = 0
        Me.colBarCode.Width = 63
        '
        'grdtxtBarCode
        '
        Me.grdtxtBarCode.AutoHeight = False
        Me.grdtxtBarCode.Name = "grdtxtBarCode"
        '
        'colPrecioEstimado
        '
        Me.colPrecioEstimado.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colPrecioEstimado.AppearanceCell.Options.UseBackColor = True
        Me.colPrecioEstimado.Caption = "Precio Est."
        Me.colPrecioEstimado.ColumnEdit = Me.grdspnPrecioEstimado
        Me.colPrecioEstimado.FieldName = "PrecioEstimado"
        Me.colPrecioEstimado.Name = "colPrecioEstimado"
        Me.colPrecioEstimado.OptionsColumn.AllowFocus = False
        Me.colPrecioEstimado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPrecioEstimado.OptionsColumn.ReadOnly = True
        Me.colPrecioEstimado.OptionsFilter.AllowAutoFilter = False
        Me.colPrecioEstimado.OptionsFilter.AllowFilter = False
        Me.colPrecioEstimado.Visible = True
        Me.colPrecioEstimado.VisibleIndex = 10
        Me.colPrecioEstimado.Width = 61
        '
        'grdspnPrecioEstimado
        '
        Me.grdspnPrecioEstimado.AutoHeight = False
        Me.grdspnPrecioEstimado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnPrecioEstimado.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnPrecioEstimado.Name = "grdspnPrecioEstimado"
        Me.grdspnPrecioEstimado.UseCtrlIncrement = False
        '
        'grdDetalleEntradasBodegasDENivel1
        '
        Me.grdDetalleEntradasBodegasDENivel1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.grdDetalleEntradasBodegasDENivel1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.ColCodigoPrel, Me.colCantidadFacturadaPrel, Me.colCantidadPreliquidadaPrel, Me.colCantidadEntradaPrel, Me.colCantidadFaltaPrel})
        Me.grdDetalleEntradasBodegasDENivel1.GridControl = Me.grdDetalleEntradasBodegasDE
        Me.grdDetalleEntradasBodegasDENivel1.Name = "grdDetalleEntradasBodegasDENivel1"
        Me.grdDetalleEntradasBodegasDENivel1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        '
        'ColCodigoPrel
        '
        Me.ColCodigoPrel.Caption = "C�digo"
        Me.ColCodigoPrel.FieldName = "CodigoRepuesto"
        Me.ColCodigoPrel.Name = "ColCodigoPrel"
        Me.ColCodigoPrel.Visible = True
        '
        'colCantidadFacturadaPrel
        '
        Me.colCantidadFacturadaPrel.Caption = "Cant. Fact."
        Me.colCantidadFacturadaPrel.FieldName = "CantidadFactura"
        Me.colCantidadFacturadaPrel.Name = "colCantidadFacturadaPrel"
        Me.colCantidadFacturadaPrel.Visible = True
        '
        'colCantidadPreliquidadaPrel
        '
        Me.colCantidadPreliquidadaPrel.Caption = "Cant. Prel."
        Me.colCantidadPreliquidadaPrel.FieldName = "CantidadEnPreli"
        Me.colCantidadPreliquidadaPrel.Name = "colCantidadPreliquidadaPrel"
        Me.colCantidadPreliquidadaPrel.Visible = True
        '
        'colCantidadEntradaPrel
        '
        Me.colCantidadEntradaPrel.Caption = "Cant. Ent."
        Me.colCantidadEntradaPrel.FieldName = "CantidadEntrante"
        Me.colCantidadEntradaPrel.Name = "colCantidadEntradaPrel"
        Me.colCantidadEntradaPrel.Visible = True
        '
        'colCantidadFaltaPrel
        '
        Me.colCantidadFaltaPrel.Caption = "Cant. Falta"
        Me.colCantidadFaltaPrel.FieldName = "CantidadFalta"
        Me.colCantidadFaltaPrel.Name = "colCantidadFaltaPrel"
        Me.colCantidadFaltaPrel.Visible = True
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCantidadFactura})
        Me.GridView1.GridControl = Me.grdDetalleEntradasBodegasDE
        Me.GridView1.Name = "GridView1"
        '
        'colCantidadFactura
        '
        Me.colCantidadFactura.Caption = "CantidadFactura"
        Me.colCantidadFactura.FieldName = "CantidadFactura"
        Me.colCantidadFactura.Name = "colCantidadFactura"
        Me.colCantidadFactura.Visible = True
        Me.colCantidadFactura.VisibleIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(762, 564)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(682, 564)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(74, 30)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(852, 32)
        Me.Panel2.TabIndex = 75
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(787, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTipoAjuste)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTipoAjuste)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbProveedor)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.lblTipoEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblProveedor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblBodega)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNumeroEntrada)
        Me.gbxDatosGenerales.Controls.Add(Me.lblNoEntrada)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(17, 39)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(818, 118)
        Me.gbxDatosGenerales.TabIndex = 73
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
        '
        'cmbTipoAjuste
        '
        Me.cmbTipoAjuste.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoAjuste.Caption = ""
        Me.cmbTipoAjuste.CaptionHeight = 17
        Me.cmbTipoAjuste.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoAjuste.ColumnCaptionHeight = 17
        Me.cmbTipoAjuste.ColumnFooterHeight = 17
        Me.cmbTipoAjuste.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoAjuste.ContentHeight = 15
        Me.cmbTipoAjuste.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoAjuste.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoAjuste.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoAjuste.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoAjuste.EditorHeight = 15
        Me.cmbTipoAjuste.Enabled = False
        Me.cmbTipoAjuste.Images.Add(CType(resources.GetObject("cmbTipoAjuste.Images"), System.Drawing.Image))
        Me.cmbTipoAjuste.ItemHeight = 15
        Me.cmbTipoAjuste.Location = New System.Drawing.Point(632, 84)
        Me.cmbTipoAjuste.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoAjuste.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoAjuste.MaxLength = 32767
        Me.cmbTipoAjuste.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoAjuste.Name = "cmbTipoAjuste"
        Me.cmbTipoAjuste.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoAjuste.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoAjuste.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoAjuste.Size = New System.Drawing.Size(174, 21)
        Me.cmbTipoAjuste.TabIndex = 97
        Me.cmbTipoAjuste.PropBag = resources.GetString("cmbTipoAjuste.PropBag")
        '
        'lblTipoAjuste
        '
        Me.lblTipoAjuste.AutoSize = True
        Me.lblTipoAjuste.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoAjuste.Location = New System.Drawing.Point(541, 90)
        Me.lblTipoAjuste.Name = "lblTipoAjuste"
        Me.lblTipoAjuste.Size = New System.Drawing.Size(63, 13)
        Me.lblTipoAjuste.TabIndex = 96
        Me.lblTipoAjuste.Tag = ""
        Me.lblTipoAjuste.Text = "Tipo Ajuste:"
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoEntrada.Caption = ""
        Me.cmbTipoEntrada.CaptionHeight = 17
        Me.cmbTipoEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoEntrada.ColumnCaptionHeight = 17
        Me.cmbTipoEntrada.ColumnFooterHeight = 17
        Me.cmbTipoEntrada.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoEntrada.ContentHeight = 15
        Me.cmbTipoEntrada.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoEntrada.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoEntrada.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoEntrada.EditorHeight = 15
        Me.cmbTipoEntrada.Images.Add(CType(resources.GetObject("cmbTipoEntrada.Images"), System.Drawing.Image))
        Me.cmbTipoEntrada.ItemHeight = 15
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(632, 53)
        Me.cmbTipoEntrada.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoEntrada.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoEntrada.MaxLength = 32767
        Me.cmbTipoEntrada.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoEntrada.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoEntrada.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(174, 21)
        Me.cmbTipoEntrada.TabIndex = 95
        Me.cmbTipoEntrada.PropBag = resources.GetString("cmbTipoEntrada.PropBag")
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProveedor.Caption = ""
        Me.cmbProveedor.CaptionHeight = 17
        Me.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProveedor.ColumnCaptionHeight = 17
        Me.cmbProveedor.ColumnFooterHeight = 17
        Me.cmbProveedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbProveedor.ContentHeight = 15
        Me.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProveedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProveedor.EditorHeight = 15
        Me.cmbProveedor.Enabled = False
        Me.cmbProveedor.Images.Add(CType(resources.GetObject("cmbProveedor.Images"), System.Drawing.Image))
        Me.cmbProveedor.ItemHeight = 15
        Me.cmbProveedor.Location = New System.Drawing.Point(133, 84)
        Me.cmbProveedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProveedor.MaxDropDownItems = CType(5, Short)
        Me.cmbProveedor.MaxLength = 32767
        Me.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedor.Size = New System.Drawing.Size(174, 21)
        Me.cmbProveedor.TabIndex = 94
        Me.cmbProveedor.TabStop = False
        Me.cmbProveedor.Tag = ""
        Me.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag")
        '
        'cmbBodega
        '
        Me.cmbBodega.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodega.Caption = ""
        Me.cmbBodega.CaptionHeight = 17
        Me.cmbBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodega.ColumnCaptionHeight = 17
        Me.cmbBodega.ColumnFooterHeight = 17
        Me.cmbBodega.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbBodega.ContentHeight = 15
        Me.cmbBodega.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBodega.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBodega.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodega.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodega.EditorHeight = 15
        Me.cmbBodega.Enabled = False
        Me.cmbBodega.Images.Add(CType(resources.GetObject("cmbBodega.Images"), System.Drawing.Image))
        Me.cmbBodega.ItemHeight = 15
        Me.cmbBodega.Location = New System.Drawing.Point(133, 53)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(174, 21)
        Me.cmbBodega.TabIndex = 0
        Me.cmbBodega.Tag = "BLOQUEADO"
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
        '
        'lblTipoEntrada
        '
        Me.lblTipoEntrada.AutoSize = True
        Me.lblTipoEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipoEntrada.Location = New System.Drawing.Point(541, 58)
        Me.lblTipoEntrada.Name = "lblTipoEntrada"
        Me.lblTipoEntrada.Size = New System.Drawing.Size(71, 13)
        Me.lblTipoEntrada.TabIndex = 92
        Me.lblTipoEntrada.Tag = ""
        Me.lblTipoEntrada.Text = "Tipo Entrada:"
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaEntrada.Location = New System.Drawing.Point(541, 24)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaEntrada.TabIndex = 88
        Me.lblFechaEntrada.Tag = ""
        Me.lblFechaEntrada.Text = "Fecha:"
        '
        'lblProveedor
        '
        Me.lblProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lblProveedor.Location = New System.Drawing.Point(28, 85)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(83, 18)
        Me.lblProveedor.TabIndex = 86
        Me.lblProveedor.Tag = ""
        Me.lblProveedor.Text = "Proveedor:"
        '
        'lblBodega
        '
        Me.lblBodega.BackColor = System.Drawing.SystemColors.Control
        Me.lblBodega.Location = New System.Drawing.Point(28, 53)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(83, 18)
        Me.lblBodega.TabIndex = 86
        Me.lblBodega.Tag = ""
        Me.lblBodega.Text = "Bodega:"
        '
        'dtpFechaEntrada
        '
        Me.dtpFechaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaEntrada.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaEntrada.EditMask = "##/##/####"
        Me.dtpFechaEntrada.Enabled = False
        Me.dtpFechaEntrada.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEntrada.Location = New System.Drawing.Point(632, 24)
        Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
        Me.dtpFechaEntrada.Size = New System.Drawing.Size(174, 18)
        Me.dtpFechaEntrada.TabIndex = 0
        Me.dtpFechaEntrada.Tag = Nothing
        Me.dtpFechaEntrada.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtNumeroEntrada
        '
        Me.txtNumeroEntrada.Location = New System.Drawing.Point(133, 20)
        Me.txtNumeroEntrada.Name = "txtNumeroEntrada"
        Me.txtNumeroEntrada.Size = New System.Drawing.Size(174, 20)
        Me.txtNumeroEntrada.TabIndex = 0
        Me.txtNumeroEntrada.TabStop = False
        Me.txtNumeroEntrada.Tag = "BLOQUEADO"
        Me.txtNumeroEntrada.Text = "(Autom�tico)"
        '
        'lblNoEntrada
        '
        Me.lblNoEntrada.AutoSize = True
        Me.lblNoEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoEntrada.Location = New System.Drawing.Point(28, 24)
        Me.lblNoEntrada.Name = "lblNoEntrada"
        Me.lblNoEntrada.Size = New System.Drawing.Size(87, 13)
        Me.lblNoEntrada.TabIndex = 19
        Me.lblNoEntrada.Tag = ""
        Me.lblNoEntrada.Text = "N�mero Entrada:"
        '
        'imgIconos
        '
        Me.imgIconos.ImageStream = CType(resources.GetObject("imgIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIconos.Images.SetKeyName(0, "Usuario.gif")
        Me.imgIconos.Images.SetKeyName(1, "Buscar.png")
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'gbxOtrosDatos
        '
        Me.gbxOtrosDatos.Controls.Add(Me.dtpFechaFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.lblFechaFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.txtNumeroPoliza)
        Me.gbxOtrosDatos.Controls.Add(Me.lblNumeroPoliza)
        Me.gbxOtrosDatos.Controls.Add(Me.txtNumeroFactura)
        Me.gbxOtrosDatos.Controls.Add(Me.lblNumeroFactura)
        Me.gbxOtrosDatos.Location = New System.Drawing.Point(17, 163)
        Me.gbxOtrosDatos.Name = "gbxOtrosDatos"
        Me.gbxOtrosDatos.Size = New System.Drawing.Size(818, 60)
        Me.gbxOtrosDatos.TabIndex = 82
        Me.gbxOtrosDatos.TabStop = False
        Me.gbxOtrosDatos.Text = "Otros Datos"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaFactura.EditMask = "##/##/####"
        Me.dtpFechaFactura.Enabled = False
        Me.dtpFechaFactura.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFactura.Location = New System.Drawing.Point(674, 21)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaFactura.TabIndex = 24
        Me.dtpFechaFactura.Tag = Nothing
        Me.dtpFechaFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.AutoSize = True
        Me.lblFechaFactura.BackColor = System.Drawing.SystemColors.Control
        Me.lblFechaFactura.Location = New System.Drawing.Point(586, 24)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(79, 13)
        Me.lblFechaFactura.TabIndex = 23
        Me.lblFechaFactura.Tag = ""
        Me.lblFechaFactura.Text = "Fecha Factura:"
        '
        'txtNumeroPoliza
        '
        Me.txtNumeroPoliza.Location = New System.Drawing.Point(416, 20)
        Me.txtNumeroPoliza.Name = "txtNumeroPoliza"
        Me.txtNumeroPoliza.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroPoliza.TabIndex = 20
        Me.txtNumeroPoliza.TabStop = False
        Me.txtNumeroPoliza.Tag = ""
        '
        'lblNumeroPoliza
        '
        Me.lblNumeroPoliza.AutoSize = True
        Me.lblNumeroPoliza.BackColor = System.Drawing.SystemColors.Control
        Me.lblNumeroPoliza.Location = New System.Drawing.Point(313, 23)
        Me.lblNumeroPoliza.Name = "lblNumeroPoliza"
        Me.lblNumeroPoliza.Size = New System.Drawing.Size(78, 13)
        Me.lblNumeroPoliza.TabIndex = 21
        Me.lblNumeroPoliza.Tag = ""
        Me.lblNumeroPoliza.Text = "N�mero Poliza:"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(131, 21)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroFactura.TabIndex = 0
        Me.txtNumeroFactura.TabStop = False
        Me.txtNumeroFactura.Tag = ""
        '
        'lblNumeroFactura
        '
        Me.lblNumeroFactura.AutoSize = True
        Me.lblNumeroFactura.BackColor = System.Drawing.SystemColors.Control
        Me.lblNumeroFactura.Location = New System.Drawing.Point(28, 24)
        Me.lblNumeroFactura.Name = "lblNumeroFactura"
        Me.lblNumeroFactura.Size = New System.Drawing.Size(86, 13)
        Me.lblNumeroFactura.TabIndex = 19
        Me.lblNumeroFactura.Tag = ""
        Me.lblNumeroFactura.Text = "N�mero Factura:"
        '
        'txtComentarios
        '
        Me.txtComentarios.AcceptsTab = True
        Me.txtComentarios.Location = New System.Drawing.Point(18, 503)
        Me.txtComentarios.MaxLength = 250
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarios.Size = New System.Drawing.Size(819, 55)
        Me.txtComentarios.TabIndex = 93
        Me.txtComentarios.Tag = ""
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.SystemColors.Control
        Me.lblObservaciones.Location = New System.Drawing.Point(15, 474)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 94
        Me.lblObservaciones.Tag = ""
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblCostoTotal.Location = New System.Drawing.Point(647, 474)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(81, 13)
        Me.lblCostoTotal.TabIndex = 96
        Me.lblCostoTotal.Tag = ""
        Me.lblCostoTotal.Text = "Costo Total U$:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.lblUsuario.Location = New System.Drawing.Point(15, 581)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 97
        Me.lblUsuario.Tag = ""
        Me.lblUsuario.Text = "Usuario"
        '
        'NumCostoTotal
        '
        Me.NumCostoTotal.DisplayFormat.CustomFormat = "$ #,##0.#0"
        Me.NumCostoTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumCostoTotal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumCostoTotal.EditFormat.CustomFormat = "$ #,##0.#0"
        Me.NumCostoTotal.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.NumCostoTotal.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumCostoTotal.Enabled = False
        Me.NumCostoTotal.Location = New System.Drawing.Point(729, 470)
        Me.NumCostoTotal.Name = "NumCostoTotal"
        Me.NumCostoTotal.Size = New System.Drawing.Size(107, 20)
        Me.NumCostoTotal.TabIndex = 102
        Me.NumCostoTotal.Tag = "BLOQUEADO"
        Me.NumCostoTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.grdDetalleEntradasBodegasDE)
        Me.gbxDetalle.Location = New System.Drawing.Point(18, 229)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(818, 236)
        Me.gbxDetalle.TabIndex = 103
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Detalle de Entrada"
        '
        'frmSivEntradaBodegaEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 601)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.NumCostoTotal)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblCostoTotal)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.gbxOtrosDatos)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbxDatosGenerales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivEntradaBodegaEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Entrada de Productos"
        CType(Me.grdPreliquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleEntradasBodegasDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleEntradasBodegasDETabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCodigoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdtxtCodigoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidadPreliquidada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidadEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidadFalta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCostoDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdtxtBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnPrecioEstimado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleEntradasBodegasDENivel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbTipoAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOtrosDatos.ResumeLayout(False)
        Me.gbxOtrosDatos.PerformLayout()
        CType(Me.dtpFechaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCostoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoEntrada As System.Windows.Forms.Label
    Friend WithEvents lblFechaEntrada As System.Windows.Forms.Label
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEntrada As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtNumeroEntrada As System.Windows.Forms.TextBox
    Friend WithEvents lblNoEntrada As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbProveedor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoEntrada As C1.Win.C1List.C1Combo
    Friend WithEvents lblTipoAjuste As System.Windows.Forms.Label
    Friend WithEvents cmbTipoAjuste As C1.Win.C1List.C1Combo
    Friend WithEvents gbxOtrosDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroFactura As System.Windows.Forms.Label
    Friend WithEvents lblFechaFactura As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPoliza As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroPoliza As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFactura As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblCostoTotal As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents NumCostoTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalleEntradasBodegasDE As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleEntradasBodegasDETabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoRepuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadFacturada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadPreliquidada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadFalta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoDolares As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdDetalleEntradasBodegasDENivel1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents ColCodigoPrel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidadFacturadaPrel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidadPreliquidadaPrel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidadEntradaPrel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidadFaltaPrel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCantidadFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdPreliquidaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colgrdPrelCantidadFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdtxtCodigoProveedor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grdcmbDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grdspnCantidad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnCantidadPreliquidada As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnCantidadEntrada As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnCantidadFalta As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnCostoDolares As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colBarCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdtxtBarCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colPrecioEstimado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdspnPrecioEstimado As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdspnCodigoRepuesto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
