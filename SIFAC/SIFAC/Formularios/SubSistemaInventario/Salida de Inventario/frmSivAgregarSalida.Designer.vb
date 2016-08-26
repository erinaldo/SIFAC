<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivAgregarSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivAgregarSalida))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.cmbAjuste = New C1.Win.C1List.C1Combo()
        Me.cmbTipoSalida = New C1.Win.C1List.C1Combo()
        Me.cmbBodega = New C1.Win.C1List.C1Combo()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbDetalle = New System.Windows.Forms.GroupBox()
        Me.numExistencia = New C1.Win.C1Input.C1NumericEdit()
        Me.grdSalidaDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdSalidaDetalleTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grptxtCodigo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdcmbDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColExistencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdSpnExistencia = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdSpnCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdSpnCosto = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdSpnSubTotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.txtcomentarios = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numCostoTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.ErrorSalida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblanular = New System.Windows.Forms.Label()
        Me.txtComentarioAnular = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDetalle.SuspendLayout()
        CType(Me.numExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSalidaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSalidaDetalleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grptxtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSpnSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCostoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.cmbAjuste)
        Me.GroupBox1.Controls.Add(Me.cmbTipoSalida)
        Me.GroupBox1.Controls.Add(Me.cmbBodega)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 137)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dartos Generales"
        '
        'dtpFecha
        '
        Me.dtpFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFecha.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.ClearText = "&Clear"
        Me.dtpFecha.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 8, 4, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(461, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(169, 18)
        Me.dtpFecha.TabIndex = 11
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'cmbAjuste
        '
        Me.cmbAjuste.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbAjuste.Caption = ""
        Me.cmbAjuste.CaptionHeight = 17
        Me.cmbAjuste.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbAjuste.ColumnCaptionHeight = 17
        Me.cmbAjuste.ColumnFooterHeight = 17
        Me.cmbAjuste.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbAjuste.ContentHeight = 15
        Me.cmbAjuste.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbAjuste.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbAjuste.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAjuste.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAjuste.EditorHeight = 15
        Me.cmbAjuste.Enabled = False
        Me.cmbAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAjuste.Images.Add(CType(resources.GetObject("cmbAjuste.Images"), System.Drawing.Image))
        Me.cmbAjuste.ItemHeight = 15
        Me.cmbAjuste.Location = New System.Drawing.Point(461, 82)
        Me.cmbAjuste.MatchEntryTimeout = CType(2000, Long)
        Me.cmbAjuste.MaxDropDownItems = CType(5, Short)
        Me.cmbAjuste.MaxLength = 32767
        Me.cmbAjuste.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbAjuste.Name = "cmbAjuste"
        Me.cmbAjuste.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbAjuste.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbAjuste.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbAjuste.Size = New System.Drawing.Size(169, 21)
        Me.cmbAjuste.TabIndex = 10
        Me.cmbAjuste.Tag = "BLOQUEADO"
        Me.cmbAjuste.PropBag = resources.GetString("cmbAjuste.PropBag")
        '
        'cmbTipoSalida
        '
        Me.cmbTipoSalida.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoSalida.Caption = ""
        Me.cmbTipoSalida.CaptionHeight = 17
        Me.cmbTipoSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoSalida.ColumnCaptionHeight = 17
        Me.cmbTipoSalida.ColumnFooterHeight = 17
        Me.cmbTipoSalida.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoSalida.ContentHeight = 15
        Me.cmbTipoSalida.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoSalida.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoSalida.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoSalida.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoSalida.EditorHeight = 15
        Me.cmbTipoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoSalida.Images.Add(CType(resources.GetObject("cmbTipoSalida.Images"), System.Drawing.Image))
        Me.cmbTipoSalida.ItemHeight = 15
        Me.cmbTipoSalida.Location = New System.Drawing.Point(131, 82)
        Me.cmbTipoSalida.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoSalida.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoSalida.MaxLength = 32767
        Me.cmbTipoSalida.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoSalida.Name = "cmbTipoSalida"
        Me.cmbTipoSalida.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoSalida.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoSalida.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoSalida.Size = New System.Drawing.Size(193, 21)
        Me.cmbTipoSalida.TabIndex = 9
        Me.cmbTipoSalida.PropBag = resources.GetString("cmbTipoSalida.PropBag")
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
        Me.cmbBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodega.Images.Add(CType(resources.GetObject("cmbBodega.Images"), System.Drawing.Image))
        Me.cmbBodega.ItemHeight = 15
        Me.cmbBodega.Location = New System.Drawing.Point(131, 51)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(193, 21)
        Me.cmbBodega.TabIndex = 8
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.SystemColors.Window
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(461, 52)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(169, 20)
        Me.txtEstado.TabIndex = 7
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(131, 22)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 6
        Me.txtNumero.Tag = "BLOQUEADO"
        Me.txtNumero.Text = "(Automático)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(366, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo de Ajuste"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo de Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bodega:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número Salida:"
        '
        'grbDetalle
        '
        Me.grbDetalle.Controls.Add(Me.numExistencia)
        Me.grbDetalle.Controls.Add(Me.grdSalidaDetalle)
        Me.grbDetalle.Controls.Add(Me.txtcomentarios)
        Me.grbDetalle.Controls.Add(Me.Label8)
        Me.grbDetalle.Controls.Add(Me.Label7)
        Me.grbDetalle.Controls.Add(Me.numCostoTotal)
        Me.grbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDetalle.Location = New System.Drawing.Point(12, 235)
        Me.grbDetalle.Name = "grbDetalle"
        Me.grbDetalle.Size = New System.Drawing.Size(657, 397)
        Me.grbDetalle.TabIndex = 30
        Me.grbDetalle.TabStop = False
        Me.grbDetalle.Text = "Detalle"
        '
        'numExistencia
        '
        Me.numExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numExistencia.Location = New System.Drawing.Point(13, 272)
        Me.numExistencia.Name = "numExistencia"
        Me.numExistencia.Size = New System.Drawing.Size(124, 20)
        Me.numExistencia.TabIndex = 36
        Me.numExistencia.Tag = Nothing
        Me.numExistencia.Visible = False
        '
        'grdSalidaDetalle
        '
        Me.grdSalidaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSalidaDetalle.Location = New System.Drawing.Point(13, 19)
        Me.grdSalidaDetalle.LookAndFeel.SkinName = "Caramel"
        Me.grdSalidaDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdSalidaDetalle.MainView = Me.grdSalidaDetalleTable
        Me.grdSalidaDetalle.Name = "grdSalidaDetalle"
        Me.grdSalidaDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.grptxtCodigo, Me.grdcmbDescripcion, Me.grdSpnExistencia, Me.grdSpnCantidad, Me.grdSpnCosto, Me.grdSpnSubTotal})
        Me.grdSalidaDetalle.Size = New System.Drawing.Size(634, 241)
        Me.grdSalidaDetalle.TabIndex = 35
        Me.grdSalidaDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdSalidaDetalleTable})
        '
        'grdSalidaDetalleTable
        '
        Me.grdSalidaDetalleTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.ColExistencia, Me.colCantidad, Me.colCosto, Me.colSubTotal})
        Me.grdSalidaDetalleTable.GridControl = Me.grdSalidaDetalle
        Me.grdSalidaDetalleTable.Name = "grdSalidaDetalleTable"
        Me.grdSalidaDetalleTable.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.grptxtCodigo
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCodigo.OptionsFilter.AllowAutoFilter = False
        Me.colCodigo.OptionsFilter.AllowFilter = False
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 64
        '
        'grptxtCodigo
        '
        Me.grptxtCodigo.AutoHeight = False
        Me.grptxtCodigo.Name = "grptxtCodigo"
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
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 245
        '
        'grdcmbDescripcion
        '
        Me.grdcmbDescripcion.AutoHeight = False
        Me.grdcmbDescripcion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.grdcmbDescripcion.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SivProductoID", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Descripción")})
        Me.grdcmbDescripcion.DisplayMember = "Nombre"
        Me.grdcmbDescripcion.Name = "grdcmbDescripcion"
        Me.grdcmbDescripcion.NullText = ""
        Me.grdcmbDescripcion.ValueMember = "SivProductoID"
        '
        'ColExistencia
        '
        Me.ColExistencia.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.ColExistencia.AppearanceCell.Options.UseBackColor = True
        Me.ColExistencia.Caption = "Existencia"
        Me.ColExistencia.ColumnEdit = Me.grdSpnExistencia
        Me.ColExistencia.FieldName = "Existencia"
        Me.ColExistencia.Name = "ColExistencia"
        Me.ColExistencia.OptionsColumn.AllowFocus = False
        Me.ColExistencia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ColExistencia.OptionsColumn.ReadOnly = True
        Me.ColExistencia.OptionsFilter.AllowAutoFilter = False
        Me.ColExistencia.OptionsFilter.AllowFilter = False
        Me.ColExistencia.Visible = True
        Me.ColExistencia.VisibleIndex = 2
        Me.ColExistencia.Width = 84
        '
        'grdSpnExistencia
        '
        Me.grdSpnExistencia.AutoHeight = False
        Me.grdSpnExistencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.grdSpnExistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdSpnExistencia.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdSpnExistencia.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdSpnExistencia.Name = "grdSpnExistencia"
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.ColumnEdit = Me.grdSpnCantidad
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCantidad.OptionsFilter.AllowAutoFilter = False
        Me.colCantidad.OptionsFilter.AllowFilter = False
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 84
        '
        'grdSpnCantidad
        '
        Me.grdSpnCantidad.AutoHeight = False
        Me.grdSpnCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdSpnCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdSpnCantidad.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdSpnCantidad.Name = "grdSpnCantidad"
        '
        'colCosto
        '
        Me.colCosto.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colCosto.AppearanceCell.Options.UseBackColor = True
        Me.colCosto.Caption = "Costo"
        Me.colCosto.ColumnEdit = Me.grdSpnCosto
        Me.colCosto.FieldName = "CostoProm"
        Me.colCosto.Name = "colCosto"
        Me.colCosto.OptionsColumn.AllowFocus = False
        Me.colCosto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCosto.OptionsColumn.ReadOnly = True
        Me.colCosto.OptionsFilter.AllowAutoFilter = False
        Me.colCosto.OptionsFilter.AllowFilter = False
        Me.colCosto.Visible = True
        Me.colCosto.VisibleIndex = 4
        Me.colCosto.Width = 73
        '
        'grdSpnCosto
        '
        Me.grdSpnCosto.AutoHeight = False
        Me.grdSpnCosto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.grdSpnCosto.DisplayFormat.FormatString = "#0.#0"
        Me.grdSpnCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdSpnCosto.EditFormat.FormatString = "#0.#0"
        Me.grdSpnCosto.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdSpnCosto.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.grdSpnCosto.Name = "grdSpnCosto"
        '
        'colSubTotal
        '
        Me.colSubTotal.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.colSubTotal.AppearanceCell.Options.UseBackColor = True
        Me.colSubTotal.Caption = "Sub Total"
        Me.colSubTotal.ColumnEdit = Me.grdSpnSubTotal
        Me.colSubTotal.FieldName = "subtotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.OptionsColumn.AllowFocus = False
        Me.colSubTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSubTotal.OptionsColumn.ReadOnly = True
        Me.colSubTotal.OptionsFilter.AllowAutoFilter = False
        Me.colSubTotal.OptionsFilter.AllowFilter = False
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 5
        Me.colSubTotal.Width = 70
        '
        'grdSpnSubTotal
        '
        Me.grdSpnSubTotal.AutoHeight = False
        Me.grdSpnSubTotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.grdSpnSubTotal.DisplayFormat.FormatString = "#0.#0"
        Me.grdSpnSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdSpnSubTotal.EditFormat.FormatString = "#0.#0"
        Me.grdSpnSubTotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.grdSpnSubTotal.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.grdSpnSubTotal.Name = "grdSpnSubTotal"
        '
        'txtcomentarios
        '
        Me.txtcomentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomentarios.Location = New System.Drawing.Point(13, 323)
        Me.txtcomentarios.Multiline = True
        Me.txtcomentarios.Name = "txtcomentarios"
        Me.txtcomentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentarios.Size = New System.Drawing.Size(627, 53)
        Me.txtcomentarios.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Comentarios:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Costo Total:"
        '
        'numCostoTotal
        '
        Me.numCostoTotal.DisplayFormat.CustomFormat = "#,##0.00"
        Me.numCostoTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.numCostoTotal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numCostoTotal.EditFormat.CustomFormat = "$#,##0.00"
        Me.numCostoTotal.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.numCostoTotal.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numCostoTotal.Enabled = False
        Me.numCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCostoTotal.Location = New System.Drawing.Point(528, 283)
        Me.numCostoTotal.Name = "numCostoTotal"
        Me.numCostoTotal.Size = New System.Drawing.Size(112, 20)
        Me.numCostoTotal.TabIndex = 1
        Me.numCostoTotal.Tag = "BLOQUEADO"
        Me.numCostoTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'ErrorSalida
        '
        Me.ErrorSalida.ContainerControl = Me
        '
        'lblanular
        '
        Me.lblanular.AutoSize = True
        Me.lblanular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanular.Location = New System.Drawing.Point(17, 175)
        Me.lblanular.Name = "lblanular"
        Me.lblanular.Size = New System.Drawing.Size(120, 13)
        Me.lblanular.TabIndex = 33
        Me.lblanular.Text = "Comentarios Anular:"
        '
        'txtComentarioAnular
        '
        Me.txtComentarioAnular.Location = New System.Drawing.Point(143, 172)
        Me.txtComentarioAnular.Multiline = True
        Me.txtComentarioAnular.Name = "txtComentarioAnular"
        Me.txtComentarioAnular.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarioAnular.Size = New System.Drawing.Size(512, 53)
        Me.txtComentarioAnular.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 678)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 21)
        Me.Panel1.TabIndex = 48
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(15, 648)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreEmpleado.TabIndex = 49
        Me.lblNombreEmpleado.Tag = ""
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.grbDetalle)
        Me.PanelControl1.Controls.Add(Me.lblanular)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(679, 699)
        Me.PanelControl1.TabIndex = 50
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(580, 642)
        Me.cmdCancelar.LookAndFeel.SkinName = "Caramel"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 87
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(489, 642)
        Me.cmdGuardar.LookAndFeel.SkinName = "Caramel"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 86
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmSivAgregarSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 699)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtComentarioAnular)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivAgregarSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Salida de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDetalle.ResumeLayout(False)
        Me.grbDetalle.PerformLayout()
        CType(Me.numExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSalidaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSalidaDetalleTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grptxtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdcmbDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSpnSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCostoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAjuste As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoSalida As C1.Win.C1List.C1Combo
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents numCostoTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcomentarios As System.Windows.Forms.TextBox
    Friend WithEvents ErrorSalida As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtComentarioAnular As System.Windows.Forms.TextBox
    Friend WithEvents lblanular As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents grdSalidaDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdSalidaDetalleTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExistencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grptxtCodigo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grdcmbDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grdSpnExistencia As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdSpnCantidad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdSpnCosto As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grdSpnSubTotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents numExistencia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
End Class
