<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSfaOrdenCompraEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSfaOrdenCompraEdit))
        Me.numTasa = New C1.Win.C1Input.C1NumericEdit
        Me.numExistencia = New C1.Win.C1Input.C1NumericEdit
        Me.chkSolicitudDescuento = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.grpDetalle = New System.Windows.Forms.GroupBox
        Me.grdDetalleFactura = New DevExpress.XtraGrid.GridControl
        Me.grdDetalleFacturaTabla = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBarCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdtxtBarCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodigoRepuesto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnCodigoRepuesto1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdcmbDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colPrecioUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdSpnPrecioUnitario = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colSubtotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnSubTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdSpnDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colPorcentajeDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnPorcentajeDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colImpuesto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdspnTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.numTotalDescuento = New C1.Win.C1Input.C1NumericEdit
        Me.numSubTotal = New C1.Win.C1Input.C1NumericEdit
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdProcesar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.numTotalC = New C1.Win.C1Input.C1NumericEdit
        Me.numIVA = New C1.Win.C1Input.C1NumericEdit
        Me.ErrorFactura = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.numTotalD = New C1.Win.C1Input.C1NumericEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TabDescuento = New System.Windows.Forms.TabControl
        Me.TabPageDescuento = New System.Windows.Forms.TabPage
        Me.NumDescuento = New DevExpress.XtraEditors.SpinEdit
        Me.chkAutorizar = New System.Windows.Forms.CheckBox
        Me.txtSolicitudDescuento = New System.Windows.Forms.TextBox
        Me.cmbTPago = New C1.Win.C1List.C1Combo
        Me.cmbBodega = New C1.Win.C1List.C1Combo
        Me.cmbVendedor = New C1.Win.C1List.C1Combo
        Me.cmbCliente = New C1.Win.C1List.C1Combo
        Me.txtAtencionA = New System.Windows.Forms.TextBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblMotivo = New System.Windows.Forms.Label
        Me.cmbMotivoAnular = New C1.Win.C1List.C1Combo
        Me.txtCodigoCliente = New System.Windows.Forms.MaskedTextBox
        Me.tabFacturas = New System.Windows.Forms.TabControl
        Me.TabPageGenerales = New System.Windows.Forms.TabPage
        Me.cmdAgregarCliente = New System.Windows.Forms.Button
        Me.cmdCliente = New System.Windows.Forms.Button
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPageCliente = New System.Windows.Forms.TabPage
        Me.chkExonerado = New System.Windows.Forms.CheckBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdExpedienteCliente = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblReciboCancelacion = New System.Windows.Forms.Label
        Me.txtNumeroReciboCancelacion = New System.Windows.Forms.TextBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.numTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetalle.SuspendLayout()
        CType(Me.grdDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleFacturaTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdtxtBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCodigoRepuesto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnPrecioUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnPorcentajeDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDescuento.SuspendLayout()
        Me.TabPageDescuento.SuspendLayout()
        CType(Me.NumDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMotivoAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFacturas.SuspendLayout()
        Me.TabPageGenerales.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdExpedienteCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numTasa
        '
        Me.numTasa.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numTasa.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTasa.Enabled = False
        Me.numTasa.Location = New System.Drawing.Point(238, 473)
        Me.numTasa.Name = "numTasa"
        Me.numTasa.Size = New System.Drawing.Size(107, 20)
        Me.numTasa.TabIndex = 51
        Me.numTasa.Tag = "BLOQUEADO"
        Me.numTasa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numExistencia
        '
        Me.numExistencia.Enabled = False
        Me.numExistencia.Location = New System.Drawing.Point(87, 473)
        Me.numExistencia.Name = "numExistencia"
        Me.numExistencia.Size = New System.Drawing.Size(100, 20)
        Me.numExistencia.TabIndex = 50
        Me.numExistencia.Tag = "BLOQUEADO"
        Me.numExistencia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkSolicitudDescuento
        '
        Me.chkSolicitudDescuento.AutoSize = True
        Me.chkSolicitudDescuento.Location = New System.Drawing.Point(26, 502)
        Me.chkSolicitudDescuento.Name = "chkSolicitudDescuento"
        Me.chkSolicitudDescuento.Size = New System.Drawing.Size(182, 17)
        Me.chkSolicitudDescuento.TabIndex = 49
        Me.chkSolicitudDescuento.Text = "Solicitud Autorización Descuento"
        Me.chkSolicitudDescuento.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(203, 476)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "T/C:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 476)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Existencia:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdBuscar.Location = New System.Drawing.Point(778, 205)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(40, 23)
        Me.cmdBuscar.TabIndex = 43
        Me.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'grpDetalle
        '
        Me.grpDetalle.Controls.Add(Me.grdDetalleFactura)
        Me.grpDetalle.Location = New System.Drawing.Point(8, 230)
        Me.grpDetalle.Name = "grpDetalle"
        Me.grpDetalle.Size = New System.Drawing.Size(813, 237)
        Me.grpDetalle.TabIndex = 39
        Me.grpDetalle.TabStop = False
        Me.grpDetalle.Text = "Detalle"
        '
        'grdDetalleFactura
        '
        Me.grdDetalleFactura.EmbeddedNavigator.Name = ""
        Me.grdDetalleFactura.Location = New System.Drawing.Point(6, 19)
        Me.grdDetalleFactura.LookAndFeel.SkinName = "Glass Oceans"
        Me.grdDetalleFactura.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.grdDetalleFactura.MainView = Me.grdDetalleFacturaTabla
        Me.grdDetalleFactura.Name = "grdDetalleFactura"
        Me.grdDetalleFactura.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grdtxtBarCode, Me.grdcmbDescripcion, Me.grdspnCantidad, Me.grdSpnPrecioUnitario, Me.grdspnSubTotal, Me.grdSpnDescuento, Me.grdspnPorcentajeDescuento, Me.grdspnTotal, Me.grdspnCodigoRepuesto1})
        Me.grdDetalleFactura.Size = New System.Drawing.Size(807, 212)
        Me.grdDetalleFactura.TabIndex = 69
        Me.grdDetalleFactura.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleFacturaTabla})
        '
        'grdDetalleFacturaTabla
        '
        Me.grdDetalleFacturaTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBarCode, Me.colCodigoRepuesto, Me.colDescripcion, Me.colCantidad, Me.colPrecioUnitario, Me.colSubtotal, Me.colDescuento, Me.colPorcentajeDescuento, Me.colImpuesto, Me.colTotal})
        Me.grdDetalleFacturaTabla.GridControl = Me.grdDetalleFactura
        Me.grdDetalleFacturaTabla.Name = "grdDetalleFacturaTabla"
        Me.grdDetalleFacturaTabla.OptionsView.ShowGroupPanel = False
        '
        'colBarCode
        '
        Me.colBarCode.Caption = "BarCode"
        Me.colBarCode.ColumnEdit = Me.grdtxtBarCode
        Me.colBarCode.FieldName = "CodigoBarras"
        Me.colBarCode.Name = "colBarCode"
        Me.colBarCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colBarCode.OptionsFilter.AllowAutoFilter = False
        Me.colBarCode.OptionsFilter.AllowFilter = False
        Me.colBarCode.Visible = True
        Me.colBarCode.VisibleIndex = 0
        Me.colBarCode.Width = 68
        '
        'grdtxtBarCode
        '
        Me.grdtxtBarCode.AutoHeight = False
        Me.grdtxtBarCode.Name = "grdtxtBarCode"
        '
        'colCodigoRepuesto
        '
        Me.colCodigoRepuesto.Caption = "Código"
        Me.colCodigoRepuesto.ColumnEdit = Me.grdspnCodigoRepuesto1
        Me.colCodigoRepuesto.FieldName = "Codigo"
        Me.colCodigoRepuesto.Name = "colCodigoRepuesto"
        Me.colCodigoRepuesto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigoRepuesto.OptionsFilter.AllowAutoFilter = False
        Me.colCodigoRepuesto.OptionsFilter.AllowFilter = False
        Me.colCodigoRepuesto.Visible = True
        Me.colCodigoRepuesto.VisibleIndex = 1
        Me.colCodigoRepuesto.Width = 66
        '
        'grdspnCodigoRepuesto1
        '
        Me.grdspnCodigoRepuesto1.AutoHeight = False
        Me.grdspnCodigoRepuesto1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.grdspnCodigoRepuesto1.Name = "grdspnCodigoRepuesto1"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.ColumnEdit = Me.grdcmbDescripcion
        Me.colDescripcion.FieldName = "Codigo"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescripcion.OptionsFilter.AllowAutoFilter = False
        Me.colDescripcion.OptionsFilter.AllowFilter = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 213
        '
        'grdcmbDescripcion
        '
        Me.grdcmbDescripcion.AutoHeight = False
        Me.grdcmbDescripcion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grdcmbDescripcion.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SivRepuestoID", "Código", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescripcionCorta", "Descripción", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.grdcmbDescripcion.DisplayMember = "DescripcionCorta"
        Me.grdcmbDescripcion.Name = "grdcmbDescripcion"
        Me.grdcmbDescripcion.NullText = ""
        Me.grdcmbDescripcion.ValueMember = "SivRepuestoID"
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.ColumnEdit = Me.grdspnCantidad
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidad.OptionsFilter.AllowAutoFilter = False
        Me.colCantidad.OptionsFilter.AllowFilter = False
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 76
        '
        'grdspnCantidad
        '
        Me.grdspnCantidad.AutoHeight = False
        Me.grdspnCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdspnCantidad.EditFormat.FormatString = "#"
        Me.grdspnCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdspnCantidad.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdspnCantidad.IsFloatValue = False
        Me.grdspnCantidad.Name = "grdspnCantidad"
        Me.grdspnCantidad.UseCtrlIncrement = True
        '
        'colPrecioUnitario
        '
        Me.colPrecioUnitario.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colPrecioUnitario.AppearanceCell.Options.UseBackColor = True
        Me.colPrecioUnitario.Caption = "Precio U."
        Me.colPrecioUnitario.ColumnEdit = Me.grdSpnPrecioUnitario
        Me.colPrecioUnitario.FieldName = "Precio"
        Me.colPrecioUnitario.Name = "colPrecioUnitario"
        Me.colPrecioUnitario.OptionsColumn.AllowFocus = False
        Me.colPrecioUnitario.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPrecioUnitario.OptionsColumn.ReadOnly = True
        Me.colPrecioUnitario.OptionsFilter.AllowAutoFilter = False
        Me.colPrecioUnitario.OptionsFilter.AllowFilter = False
        Me.colPrecioUnitario.Visible = True
        Me.colPrecioUnitario.VisibleIndex = 4
        Me.colPrecioUnitario.Width = 61
        '
        'grdSpnPrecioUnitario
        '
        Me.grdSpnPrecioUnitario.AutoHeight = False
        Me.grdSpnPrecioUnitario.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdSpnPrecioUnitario.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdSpnPrecioUnitario.Name = "grdSpnPrecioUnitario"
        Me.grdSpnPrecioUnitario.UseCtrlIncrement = True
        '
        'colSubtotal
        '
        Me.colSubtotal.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colSubtotal.AppearanceCell.Options.UseBackColor = True
        Me.colSubtotal.Caption = "Subtotal"
        Me.colSubtotal.ColumnEdit = Me.grdspnSubTotal
        Me.colSubtotal.FieldName = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.OptionsColumn.AllowFocus = False
        Me.colSubtotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSubtotal.OptionsColumn.ReadOnly = True
        Me.colSubtotal.OptionsFilter.AllowAutoFilter = False
        Me.colSubtotal.OptionsFilter.AllowFilter = False
        Me.colSubtotal.Visible = True
        Me.colSubtotal.VisibleIndex = 5
        Me.colSubtotal.Width = 61
        '
        'grdspnSubTotal
        '
        Me.grdspnSubTotal.AutoHeight = False
        Me.grdspnSubTotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnSubTotal.DisplayFormat.FormatString = "#0.#0"
        Me.grdspnSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnSubTotal.EditFormat.FormatString = "#0.#0"
        Me.grdspnSubTotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnSubTotal.Name = "grdspnSubTotal"
        Me.grdspnSubTotal.UseCtrlIncrement = True
        '
        'colDescuento
        '
        Me.colDescuento.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colDescuento.AppearanceCell.Options.UseBackColor = True
        Me.colDescuento.Caption = "Descuento"
        Me.colDescuento.ColumnEdit = Me.grdSpnDescuento
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.OptionsColumn.AllowFocus = False
        Me.colDescuento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescuento.OptionsColumn.ReadOnly = True
        Me.colDescuento.OptionsFilter.AllowAutoFilter = False
        Me.colDescuento.OptionsFilter.AllowFilter = False
        Me.colDescuento.Visible = True
        Me.colDescuento.VisibleIndex = 6
        Me.colDescuento.Width = 61
        '
        'grdSpnDescuento
        '
        Me.grdSpnDescuento.AutoHeight = False
        Me.grdSpnDescuento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdSpnDescuento.DisplayFormat.FormatString = "#0.#0"
        Me.grdSpnDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdSpnDescuento.EditFormat.FormatString = "#0.#0"
        Me.grdSpnDescuento.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdSpnDescuento.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdSpnDescuento.Name = "grdSpnDescuento"
        Me.grdSpnDescuento.UseCtrlIncrement = False
        '
        'colPorcentajeDescuento
        '
        Me.colPorcentajeDescuento.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colPorcentajeDescuento.AppearanceCell.Options.UseBackColor = True
        Me.colPorcentajeDescuento.Caption = "% Desc."
        Me.colPorcentajeDescuento.ColumnEdit = Me.grdspnPorcentajeDescuento
        Me.colPorcentajeDescuento.FieldName = "DescuentoPor"
        Me.colPorcentajeDescuento.Name = "colPorcentajeDescuento"
        Me.colPorcentajeDescuento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPorcentajeDescuento.OptionsColumn.ReadOnly = True
        Me.colPorcentajeDescuento.OptionsFilter.AllowAutoFilter = False
        Me.colPorcentajeDescuento.OptionsFilter.AllowFilter = False
        Me.colPorcentajeDescuento.Visible = True
        Me.colPorcentajeDescuento.VisibleIndex = 7
        Me.colPorcentajeDescuento.Width = 73
        '
        'grdspnPorcentajeDescuento
        '
        Me.grdspnPorcentajeDescuento.AutoHeight = False
        Me.grdspnPorcentajeDescuento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinRight, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing), New DevExpress.XtraEditors.Controls.EditorButton})
        Me.grdspnPorcentajeDescuento.DisplayFormat.FormatString = "#0.#0"
        Me.grdspnPorcentajeDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnPorcentajeDescuento.EditFormat.FormatString = "#0.#0"
        Me.grdspnPorcentajeDescuento.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnPorcentajeDescuento.Name = "grdspnPorcentajeDescuento"
        Me.grdspnPorcentajeDescuento.UseCtrlIncrement = True
        '
        'colImpuesto
        '
        Me.colImpuesto.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colImpuesto.AppearanceCell.Options.UseBackColor = True
        Me.colImpuesto.Caption = "IVA"
        Me.colImpuesto.ColumnEdit = Me.grdspnTotal
        Me.colImpuesto.FieldName = "Impuesto"
        Me.colImpuesto.Name = "colImpuesto"
        Me.colImpuesto.OptionsColumn.AllowFocus = False
        Me.colImpuesto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colImpuesto.OptionsColumn.ReadOnly = True
        Me.colImpuesto.OptionsFilter.AllowAutoFilter = False
        Me.colImpuesto.OptionsFilter.AllowFilter = False
        Me.colImpuesto.Visible = True
        Me.colImpuesto.VisibleIndex = 8
        Me.colImpuesto.Width = 46
        '
        'grdspnTotal
        '
        Me.grdspnTotal.AutoHeight = False
        Me.grdspnTotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.grdspnTotal.DisplayFormat.FormatString = "#0.#0"
        Me.grdspnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnTotal.EditFormat.FormatString = "#0.#0"
        Me.grdspnTotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdspnTotal.Name = "grdspnTotal"
        Me.grdspnTotal.UseCtrlIncrement = True
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
        Me.colTotal.Width = 68
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 653)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 22)
        Me.Panel1.TabIndex = 38
        '
        'numTotalDescuento
        '
        Me.numTotalDescuento.BackColor = System.Drawing.SystemColors.Info
        Me.numTotalDescuento.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numTotalDescuento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalDescuento.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotalDescuento.Enabled = False
        Me.numTotalDescuento.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalDescuento.Location = New System.Drawing.Point(734, 499)
        Me.numTotalDescuento.Name = "numTotalDescuento"
        Me.numTotalDescuento.Size = New System.Drawing.Size(83, 20)
        Me.numTotalDescuento.TabIndex = 64
        Me.numTotalDescuento.Tag = "BLOQUEADO"
        Me.numTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotalDescuento.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTotalDescuento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numSubTotal
        '
        Me.numSubTotal.BackColor = System.Drawing.SystemColors.Info
        Me.numSubTotal.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numSubTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSubTotal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numSubTotal.Enabled = False
        Me.numSubTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSubTotal.Location = New System.Drawing.Point(734, 473)
        Me.numSubTotal.Name = "numSubTotal"
        Me.numSubTotal.Size = New System.Drawing.Size(83, 20)
        Me.numSubTotal.TabIndex = 63
        Me.numSubTotal.Tag = "BLOQUEADO"
        Me.numSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSubTotal.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numSubTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(743, 614)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 62
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdProcesar
        '
        Me.cmdProcesar.BackgroundImage = Global.SIFAC.My.Resources.Resources.Aprobar
        Me.cmdProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdProcesar.Enabled = False
        Me.cmdProcesar.Location = New System.Drawing.Point(662, 614)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(75, 28)
        Me.cmdProcesar.TabIndex = 61
        Me.cmdProcesar.Text = "Procesar"
        Me.cmdProcesar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(581, 614)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 60
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(665, 577)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Total US$:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(667, 552)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Total C$:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(667, 528)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "IVA:"
        '
        'numTotalC
        '
        Me.numTotalC.BackColor = System.Drawing.SystemColors.Info
        Me.numTotalC.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numTotalC.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalC.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotalC.Enabled = False
        Me.numTotalC.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalC.Location = New System.Drawing.Point(734, 549)
        Me.numTotalC.Name = "numTotalC"
        Me.numTotalC.Size = New System.Drawing.Size(83, 20)
        Me.numTotalC.TabIndex = 66
        Me.numTotalC.Tag = "BLOQUEADO"
        Me.numTotalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotalC.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTotalC.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numIVA
        '
        Me.numIVA.BackColor = System.Drawing.SystemColors.Info
        Me.numIVA.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numIVA.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numIVA.Enabled = False
        Me.numIVA.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numIVA.Location = New System.Drawing.Point(734, 525)
        Me.numIVA.Name = "numIVA"
        Me.numIVA.Size = New System.Drawing.Size(83, 20)
        Me.numIVA.TabIndex = 65
        Me.numIVA.Tag = "BLOQUEADO"
        Me.numIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numIVA.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numIVA.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'ErrorFactura
        '
        Me.ErrorFactura.ContainerControl = Me
        '
        'numTotalD
        '
        Me.numTotalD.BackColor = System.Drawing.SystemColors.Info
        Me.numTotalD.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numTotalD.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalD.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numTotalD.Enabled = False
        Me.numTotalD.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotalD.Location = New System.Drawing.Point(734, 574)
        Me.numTotalD.Name = "numTotalD"
        Me.numTotalD.Size = New System.Drawing.Size(83, 20)
        Me.numTotalD.TabIndex = 67
        Me.numTotalD.Tag = "BLOQUEADO"
        Me.numTotalD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotalD.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTotalD.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(667, 502)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Descuento:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(667, 476)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Sub Total:"
        '
        'TabDescuento
        '
        Me.TabDescuento.Controls.Add(Me.TabPageDescuento)
        Me.TabDescuento.Location = New System.Drawing.Point(238, 528)
        Me.TabDescuento.Name = "TabDescuento"
        Me.TabDescuento.SelectedIndex = 0
        Me.TabDescuento.Size = New System.Drawing.Size(147, 86)
        Me.TabDescuento.TabIndex = 54
        '
        'TabPageDescuento
        '
        Me.TabPageDescuento.Controls.Add(Me.NumDescuento)
        Me.TabPageDescuento.Controls.Add(Me.chkAutorizar)
        Me.TabPageDescuento.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDescuento.Name = "TabPageDescuento"
        Me.TabPageDescuento.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDescuento.Size = New System.Drawing.Size(139, 60)
        Me.TabPageDescuento.TabIndex = 0
        Me.TabPageDescuento.Text = "Descuento"
        Me.TabPageDescuento.UseVisualStyleBackColor = True
        '
        'NumDescuento
        '
        Me.NumDescuento.AllowDrop = True
        Me.NumDescuento.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumDescuento.Location = New System.Drawing.Point(13, 15)
        Me.NumDescuento.Name = "NumDescuento"
        Me.NumDescuento.Properties.DisplayFormat.FormatString = "$#,##0.00"
        Me.NumDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.NumDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NumDescuento.Properties.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumDescuento.Properties.UseCtrlIncrement = False
        Me.NumDescuento.Size = New System.Drawing.Size(101, 20)
        Me.NumDescuento.TabIndex = 70
        '
        'chkAutorizar
        '
        Me.chkAutorizar.AutoSize = True
        Me.chkAutorizar.Enabled = False
        Me.chkAutorizar.Location = New System.Drawing.Point(15, 41)
        Me.chkAutorizar.Name = "chkAutorizar"
        Me.chkAutorizar.Size = New System.Drawing.Size(67, 17)
        Me.chkAutorizar.TabIndex = 21
        Me.chkAutorizar.Text = "Autorizar"
        Me.chkAutorizar.UseVisualStyleBackColor = True
        '
        'txtSolicitudDescuento
        '
        Me.txtSolicitudDescuento.Enabled = False
        Me.txtSolicitudDescuento.Location = New System.Drawing.Point(26, 525)
        Me.txtSolicitudDescuento.Multiline = True
        Me.txtSolicitudDescuento.Name = "txtSolicitudDescuento"
        Me.txtSolicitudDescuento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSolicitudDescuento.Size = New System.Drawing.Size(193, 42)
        Me.txtSolicitudDescuento.TabIndex = 53
        '
        'cmbTPago
        '
        Me.cmbTPago.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTPago.Caption = ""
        Me.cmbTPago.CaptionHeight = 17
        Me.cmbTPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTPago.ColumnCaptionHeight = 17
        Me.cmbTPago.ColumnFooterHeight = 17
        Me.cmbTPago.ColumnHeaders = False
        Me.cmbTPago.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTPago.ContentHeight = 15
        Me.cmbTPago.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTPago.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTPago.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTPago.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTPago.EditorHeight = 15
        Me.cmbTPago.Images.Add(CType(resources.GetObject("cmbTPago.Images"), System.Drawing.Image))
        Me.cmbTPago.ItemHeight = 15
        Me.cmbTPago.Location = New System.Drawing.Point(675, 12)
        Me.cmbTPago.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTPago.MaxDropDownItems = CType(5, Short)
        Me.cmbTPago.MaxLength = 32767
        Me.cmbTPago.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTPago.Name = "cmbTPago"
        Me.cmbTPago.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTPago.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTPago.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTPago.Size = New System.Drawing.Size(115, 21)
        Me.cmbTPago.TabIndex = 13
        Me.cmbTPago.PropBag = resources.GetString("cmbTPago.PropBag")
        '
        'cmbBodega
        '
        Me.cmbBodega.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodega.Caption = ""
        Me.cmbBodega.CaptionHeight = 17
        Me.cmbBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodega.ColumnCaptionHeight = 17
        Me.cmbBodega.ColumnFooterHeight = 17
        Me.cmbBodega.ColumnHeaders = False
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
        Me.cmbBodega.Location = New System.Drawing.Point(247, 13)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(130, 21)
        Me.cmbBodega.TabIndex = 12
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
        '
        'cmbVendedor
        '
        Me.cmbVendedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbVendedor.Caption = ""
        Me.cmbVendedor.CaptionHeight = 17
        Me.cmbVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbVendedor.ColumnCaptionHeight = 17
        Me.cmbVendedor.ColumnFooterHeight = 17
        Me.cmbVendedor.ColumnHeaders = False
        Me.cmbVendedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbVendedor.ContentHeight = 15
        Me.cmbVendedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbVendedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbVendedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbVendedor.EditorHeight = 15
        Me.cmbVendedor.Enabled = False
        Me.cmbVendedor.Images.Add(CType(resources.GetObject("cmbVendedor.Images"), System.Drawing.Image))
        Me.cmbVendedor.ItemHeight = 15
        Me.cmbVendedor.Location = New System.Drawing.Point(522, 46)
        Me.cmbVendedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbVendedor.MaxDropDownItems = CType(5, Short)
        Me.cmbVendedor.MaxLength = 32767
        Me.cmbVendedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbVendedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbVendedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbVendedor.Size = New System.Drawing.Size(172, 21)
        Me.cmbVendedor.TabIndex = 11
        Me.cmbVendedor.PropBag = resources.GetString("cmbVendedor.PropBag")
        '
        'cmbCliente
        '
        Me.cmbCliente.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCliente.Caption = ""
        Me.cmbCliente.CaptionHeight = 17
        Me.cmbCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCliente.ColumnCaptionHeight = 17
        Me.cmbCliente.ColumnFooterHeight = 17
        Me.cmbCliente.ColumnHeaders = False
        Me.cmbCliente.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCliente.ContentHeight = 15
        Me.cmbCliente.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCliente.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCliente.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCliente.EditorHeight = 15
        Me.cmbCliente.Images.Add(CType(resources.GetObject("cmbCliente.Images"), System.Drawing.Image))
        Me.cmbCliente.ItemHeight = 15
        Me.cmbCliente.Location = New System.Drawing.Point(186, 48)
        Me.cmbCliente.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCliente.MaxDropDownItems = CType(5, Short)
        Me.cmbCliente.MaxLength = 32767
        Me.cmbCliente.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCliente.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCliente.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCliente.Size = New System.Drawing.Size(191, 21)
        Me.cmbCliente.TabIndex = 10
        Me.cmbCliente.PropBag = resources.GetString("cmbCliente.PropBag")
        '
        'txtAtencionA
        '
        Me.txtAtencionA.Location = New System.Drawing.Point(77, 79)
        Me.txtAtencionA.Name = "txtAtencionA"
        Me.txtAtencionA.Size = New System.Drawing.Size(300, 20)
        Me.txtAtencionA.TabIndex = 9
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(77, 13)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(81, 20)
        Me.txtNumero.TabIndex = 7
        Me.txtNumero.Tag = "BLOQUEADO"
        Me.txtNumero.Text = "(Automático)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(622, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "T/Pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(438, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vendedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha:"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(438, 86)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(75, 13)
        Me.lblMotivo.TabIndex = 18
        Me.lblMotivo.Text = "Motivo Anular:"
        Me.lblMotivo.Visible = False
        '
        'cmbMotivoAnular
        '
        Me.cmbMotivoAnular.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMotivoAnular.Caption = ""
        Me.cmbMotivoAnular.CaptionHeight = 17
        Me.cmbMotivoAnular.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMotivoAnular.ColumnCaptionHeight = 17
        Me.cmbMotivoAnular.ColumnFooterHeight = 17
        Me.cmbMotivoAnular.ColumnHeaders = False
        Me.cmbMotivoAnular.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMotivoAnular.ContentHeight = 15
        Me.cmbMotivoAnular.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMotivoAnular.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMotivoAnular.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMotivoAnular.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMotivoAnular.EditorHeight = 15
        Me.cmbMotivoAnular.Enabled = False
        Me.cmbMotivoAnular.Images.Add(CType(resources.GetObject("cmbMotivoAnular.Images"), System.Drawing.Image))
        Me.cmbMotivoAnular.ItemHeight = 15
        Me.cmbMotivoAnular.Location = New System.Drawing.Point(522, 79)
        Me.cmbMotivoAnular.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMotivoAnular.MaxDropDownItems = CType(5, Short)
        Me.cmbMotivoAnular.MaxLength = 32767
        Me.cmbMotivoAnular.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMotivoAnular.Name = "cmbMotivoAnular"
        Me.cmbMotivoAnular.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMotivoAnular.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMotivoAnular.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMotivoAnular.Size = New System.Drawing.Size(172, 21)
        Me.cmbMotivoAnular.TabIndex = 19
        Me.cmbMotivoAnular.Visible = False
        Me.cmbMotivoAnular.PropBag = resources.GetString("cmbMotivoAnular.PropBag")
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(77, 48)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(102, 20)
        Me.txtCodigoCliente.TabIndex = 17
        '
        'tabFacturas
        '
        Me.tabFacturas.Controls.Add(Me.TabPageGenerales)
        Me.tabFacturas.Controls.Add(Me.TabPageCliente)
        Me.tabFacturas.Location = New System.Drawing.Point(4, 38)
        Me.tabFacturas.Name = "tabFacturas"
        Me.tabFacturas.SelectedIndex = 0
        Me.tabFacturas.Size = New System.Drawing.Size(817, 161)
        Me.tabFacturas.TabIndex = 36
        '
        'TabPageGenerales
        '
        Me.TabPageGenerales.Controls.Add(Me.cmbMotivoAnular)
        Me.TabPageGenerales.Controls.Add(Me.lblMotivo)
        Me.TabPageGenerales.Controls.Add(Me.txtCodigoCliente)
        Me.TabPageGenerales.Controls.Add(Me.cmdAgregarCliente)
        Me.TabPageGenerales.Controls.Add(Me.cmdCliente)
        Me.TabPageGenerales.Controls.Add(Me.dtpFecha)
        Me.TabPageGenerales.Controls.Add(Me.cmbTPago)
        Me.TabPageGenerales.Controls.Add(Me.cmbBodega)
        Me.TabPageGenerales.Controls.Add(Me.cmbVendedor)
        Me.TabPageGenerales.Controls.Add(Me.cmbCliente)
        Me.TabPageGenerales.Controls.Add(Me.txtAtencionA)
        Me.TabPageGenerales.Controls.Add(Me.txtNumero)
        Me.TabPageGenerales.Controls.Add(Me.Label7)
        Me.TabPageGenerales.Controls.Add(Me.Label6)
        Me.TabPageGenerales.Controls.Add(Me.Label5)
        Me.TabPageGenerales.Controls.Add(Me.Label4)
        Me.TabPageGenerales.Controls.Add(Me.Label3)
        Me.TabPageGenerales.Controls.Add(Me.Label2)
        Me.TabPageGenerales.Controls.Add(Me.Label1)
        Me.TabPageGenerales.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGenerales.Name = "TabPageGenerales"
        Me.TabPageGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGenerales.Size = New System.Drawing.Size(809, 135)
        Me.TabPageGenerales.TabIndex = 0
        Me.TabPageGenerales.Text = "Datos Generales"
        Me.TabPageGenerales.UseVisualStyleBackColor = True
        '
        'cmdAgregarCliente
        '
        Me.cmdAgregarCliente.Image = Global.SIFAC.My.Resources.Resources.Buscar
        Me.cmdAgregarCliente.Location = New System.Drawing.Point(406, 46)
        Me.cmdAgregarCliente.Name = "cmdAgregarCliente"
        Me.cmdAgregarCliente.Size = New System.Drawing.Size(24, 22)
        Me.cmdAgregarCliente.TabIndex = 16
        Me.cmdAgregarCliente.Text = "..."
        Me.ToolTip.SetToolTip(Me.cmdAgregarCliente, "Consultar datos Cliente/Nuevo")
        Me.cmdAgregarCliente.UseVisualStyleBackColor = True
        '
        'cmdCliente
        '
        Me.cmdCliente.Location = New System.Drawing.Point(381, 46)
        Me.cmdCliente.Name = "cmdCliente"
        Me.cmdCliente.Size = New System.Drawing.Size(24, 22)
        Me.cmdCliente.TabIndex = 15
        Me.cmdCliente.Text = "..."
        Me.ToolTip.SetToolTip(Me.cmdCliente, "Buscar Cliente")
        Me.cmdCliente.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(497, 13)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 14
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bodega:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Atención A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        '
        'TabPageCliente
        '
        Me.TabPageCliente.Controls.Add(Me.chkExonerado)
        Me.TabPageCliente.Controls.Add(Me.txtDireccion)
        Me.TabPageCliente.Controls.Add(Me.txtEmail)
        Me.TabPageCliente.Controls.Add(Me.txtTelefono)
        Me.TabPageCliente.Controls.Add(Me.GroupBox1)
        Me.TabPageCliente.Controls.Add(Me.Label10)
        Me.TabPageCliente.Controls.Add(Me.Label9)
        Me.TabPageCliente.Controls.Add(Me.Label8)
        Me.TabPageCliente.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCliente.Name = "TabPageCliente"
        Me.TabPageCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCliente.Size = New System.Drawing.Size(809, 135)
        Me.TabPageCliente.TabIndex = 1
        Me.TabPageCliente.Text = "Datos del Cliente"
        Me.TabPageCliente.UseVisualStyleBackColor = True
        '
        'chkExonerado
        '
        Me.chkExonerado.AutoSize = True
        Me.chkExonerado.Enabled = False
        Me.chkExonerado.Location = New System.Drawing.Point(340, 19)
        Me.chkExonerado.Name = "chkExonerado"
        Me.chkExonerado.Size = New System.Drawing.Size(77, 17)
        Me.chkExonerado.TabIndex = 7
        Me.chkExonerado.Text = "Exonerado"
        Me.chkExonerado.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(94, 70)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(283, 44)
        Me.txtDireccion.TabIndex = 6
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(94, 44)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(231, 20)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.Tag = "BLOQUEADO"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(94, 17)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(231, 20)
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.Tag = "BLOQUEADO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdExpedienteCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(429, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 123)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Expediente CxC"
        '
        'grdExpedienteCliente
        '
        Me.grdExpedienteCliente.AllowColMove = False
        Me.grdExpedienteCliente.AllowUpdate = False
        Me.grdExpedienteCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdExpedienteCliente.Enabled = False
        Me.grdExpedienteCliente.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdExpedienteCliente.Images.Add(CType(resources.GetObject("grdExpedienteCliente.Images"), System.Drawing.Image))
        Me.grdExpedienteCliente.Location = New System.Drawing.Point(3, 16)
        Me.grdExpedienteCliente.Name = "grdExpedienteCliente"
        Me.grdExpedienteCliente.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdExpedienteCliente.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdExpedienteCliente.PreviewInfo.ZoomFactor = 75
        Me.grdExpedienteCliente.PrintInfo.PageSettings = CType(resources.GetObject("grdExpedienteCliente.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdExpedienteCliente.Size = New System.Drawing.Size(363, 104)
        Me.grdExpedienteCliente.TabIndex = 0
        Me.grdExpedienteCliente.Text = "C1TrueDBGrid1"
        Me.grdExpedienteCliente.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdExpedienteCliente.PropBag = resources.GetString("grdExpedienteCliente.PropBag")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Teléfonos:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(829, 32)
        Me.Panel2.TabIndex = 37
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(758, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblReciboCancelacion
        '
        Me.lblReciboCancelacion.AutoSize = True
        Me.lblReciboCancelacion.Location = New System.Drawing.Point(23, 629)
        Me.lblReciboCancelacion.Name = "lblReciboCancelacion"
        Me.lblReciboCancelacion.Size = New System.Drawing.Size(146, 13)
        Me.lblReciboCancelacion.TabIndex = 47
        Me.lblReciboCancelacion.Text = "Número Recibo Cancelación:"
        '
        'txtNumeroReciboCancelacion
        '
        Me.txtNumeroReciboCancelacion.Location = New System.Drawing.Point(175, 626)
        Me.txtNumeroReciboCancelacion.Name = "txtNumeroReciboCancelacion"
        Me.txtNumeroReciboCancelacion.Size = New System.Drawing.Size(206, 20)
        Me.txtNumeroReciboCancelacion.TabIndex = 68
        '
        'FrmSfaOrdenCompraEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 675)
        Me.Controls.Add(Me.txtNumeroReciboCancelacion)
        Me.Controls.Add(Me.numTasa)
        Me.Controls.Add(Me.numExistencia)
        Me.Controls.Add(Me.chkSolicitudDescuento)
        Me.Controls.Add(Me.lblReciboCancelacion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.grpDetalle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.numTotalDescuento)
        Me.Controls.Add(Me.numSubTotal)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdProcesar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.numTotalC)
        Me.Controls.Add(Me.numIVA)
        Me.Controls.Add(Me.numTotalD)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TabDescuento)
        Me.Controls.Add(Me.txtSolicitudDescuento)
        Me.Controls.Add(Me.tabFacturas)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSfaOrdenCompraEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Orden de Facturación"
        CType(Me.numTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetalle.ResumeLayout(False)
        CType(Me.grdDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleFacturaTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdtxtBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCodigoRepuesto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnPrecioUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnPorcentajeDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdspnTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDescuento.ResumeLayout(False)
        Me.TabPageDescuento.ResumeLayout(False)
        Me.TabPageDescuento.PerformLayout()
        CType(Me.NumDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMotivoAnular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFacturas.ResumeLayout(False)
        Me.TabPageGenerales.ResumeLayout(False)
        Me.TabPageGenerales.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCliente.ResumeLayout(False)
        Me.TabPageCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdExpedienteCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numExistencia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkSolicitudDescuento As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents grpDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents numTotalDescuento As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numSubTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdProcesar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents numTotalC As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numIVA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ErrorFactura As System.Windows.Forms.ErrorProvider
    Friend WithEvents numTotalD As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabDescuento As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDescuento As System.Windows.Forms.TabPage
    Friend WithEvents chkAutorizar As System.Windows.Forms.CheckBox
    Friend WithEvents txtSolicitudDescuento As System.Windows.Forms.TextBox
    Friend WithEvents tabFacturas As System.Windows.Forms.TabControl
    Friend WithEvents TabPageGenerales As System.Windows.Forms.TabPage
    Friend WithEvents cmbMotivoAnular As C1.Win.C1List.C1Combo
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents cmdCliente As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbTPago As C1.Win.C1List.C1Combo
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents cmbVendedor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCliente As C1.Win.C1List.C1Combo
    Friend WithEvents txtAtencionA As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPageCliente As System.Windows.Forms.TabPage
    Friend WithEvents chkExonerado As System.Windows.Forms.CheckBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdExpedienteCliente As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblReciboCancelacion As System.Windows.Forms.Label
    Friend WithEvents txtNumeroReciboCancelacion As System.Windows.Forms.TextBox
    Friend WithEvents grdDetalleFactura As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleFacturaTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBarCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdtxtBarCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCodigoRepuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdcmbDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdspnCantidad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colPrecioUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdSpnPrecioUnitario As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colSubtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdspnSubTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdSpnDescuento As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colPorcentajeDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdspnPorcentajeDescuento As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colImpuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdspnTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NumDescuento As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents grdspnCodigoRepuesto1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
