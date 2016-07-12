<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaPromocionesEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaPromocionesEdit))
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox
        Me.lblTipoPromoción = New System.Windows.Forms.Label
        Me.chkAplicanRestricciones = New System.Windows.Forms.CheckBox
        Me.gbxTipoPromocion = New System.Windows.Forms.GroupBox
        Me.rdbGlobalTipo = New System.Windows.Forms.RadioButton
        Me.rdbPorRepuesto = New System.Windows.Forms.RadioButton
        Me.dtpFechaFin = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaCreacion = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaInicio = New C1.Win.C1Input.C1DateEdit
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtUsuarioCreacion = New System.Windows.Forms.TextBox
        Me.txtSfaPromocionID = New System.Windows.Forms.TextBox
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.lblFechaCreacion = New System.Windows.Forms.Label
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblSfaPromocionID = New System.Windows.Forms.Label
        Me.gbxSucursales = New System.Windows.Forms.GroupBox
        Me.grdSucursales = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.chkTodas = New System.Windows.Forms.CheckBox
        Me.tcDetallePorTipo = New System.Windows.Forms.TabControl
        Me.tpGlobalTipo = New System.Windows.Forms.TabPage
        Me.cneDescuentoTipo = New C1.Win.C1Input.C1NumericEdit
        Me.cmbTiposRepuestos = New C1.Win.C1List.C1Combo
        Me.grdDetalleGlobalTipo = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lblNota = New System.Windows.Forms.Label
        Me.ErrErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tcDetallePorRepuesto = New System.Windows.Forms.TabControl
        Me.tpPorRepuesto = New System.Windows.Forms.TabPage
        Me.cneDescuento = New C1.Win.C1Input.C1NumericEdit
        Me.cmbDescripcionRepuestos = New C1.Win.C1List.C1Combo
        Me.grdDetallePorRepuesto = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.gbxDatosGenerales.SuspendLayout()
        Me.gbxTipoPromocion.SuspendLayout()
        CType(Me.dtpFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaCreacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSucursales.SuspendLayout()
        CType(Me.grdSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcDetallePorTipo.SuspendLayout()
        Me.tpGlobalTipo.SuspendLayout()
        CType(Me.cneDescuentoTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTiposRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleGlobalTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcDetallePorRepuesto.SuspendLayout()
        Me.tpPorRepuesto.SuspendLayout()
        CType(Me.cneDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDescripcionRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetallePorRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.lblTipoPromoción)
        Me.gbxDatosGenerales.Controls.Add(Me.chkAplicanRestricciones)
        Me.gbxDatosGenerales.Controls.Add(Me.gbxTipoPromocion)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaFin)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaCreacion)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFechaInicio)
        Me.gbxDatosGenerales.Controls.Add(Me.chkActivo)
        Me.gbxDatosGenerales.Controls.Add(Me.txtDescripcion)
        Me.gbxDatosGenerales.Controls.Add(Me.txtUsuarioCreacion)
        Me.gbxDatosGenerales.Controls.Add(Me.txtSfaPromocionID)
        Me.gbxDatosGenerales.Controls.Add(Me.lblUsuario)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaCreacion)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaFin)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaInicio)
        Me.gbxDatosGenerales.Controls.Add(Me.lblDescripcion)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(10, 33)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(475, 237)
        Me.gbxDatosGenerales.TabIndex = 0
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Datos Generales"
        '
        'lblTipoPromoción
        '
        Me.lblTipoPromoción.AutoSize = True
        Me.lblTipoPromoción.Location = New System.Drawing.Point(9, 198)
        Me.lblTipoPromoción.Name = "lblTipoPromoción"
        Me.lblTipoPromoción.Size = New System.Drawing.Size(84, 13)
        Me.lblTipoPromoción.TabIndex = 6
        Me.lblTipoPromoción.Text = "Tipo Promoción:"
        '
        'chkAplicanRestricciones
        '
        Me.chkAplicanRestricciones.AutoSize = True
        Me.chkAplicanRestricciones.Location = New System.Drawing.Point(334, 209)
        Me.chkAplicanRestricciones.Name = "chkAplicanRestricciones"
        Me.chkAplicanRestricciones.Size = New System.Drawing.Size(123, 17)
        Me.chkAplicanRestricciones.TabIndex = 5
        Me.chkAplicanRestricciones.Text = "Aplican restricciones"
        Me.chkAplicanRestricciones.UseVisualStyleBackColor = True
        '
        'gbxTipoPromocion
        '
        Me.gbxTipoPromocion.Controls.Add(Me.rdbGlobalTipo)
        Me.gbxTipoPromocion.Controls.Add(Me.rdbPorRepuesto)
        Me.gbxTipoPromocion.Location = New System.Drawing.Point(96, 182)
        Me.gbxTipoPromocion.Margin = New System.Windows.Forms.Padding(0)
        Me.gbxTipoPromocion.Name = "gbxTipoPromocion"
        Me.gbxTipoPromocion.Size = New System.Drawing.Size(228, 45)
        Me.gbxTipoPromocion.TabIndex = 4
        Me.gbxTipoPromocion.TabStop = False
        '
        'rdbGlobalTipo
        '
        Me.rdbGlobalTipo.AutoSize = True
        Me.rdbGlobalTipo.Location = New System.Drawing.Point(115, 16)
        Me.rdbGlobalTipo.Name = "rdbGlobalTipo"
        Me.rdbGlobalTipo.Size = New System.Drawing.Size(93, 17)
        Me.rdbGlobalTipo.TabIndex = 4
        Me.rdbGlobalTipo.Text = "Global por tipo"
        Me.rdbGlobalTipo.UseVisualStyleBackColor = True
        '
        'rdbPorRepuesto
        '
        Me.rdbPorRepuesto.AutoSize = True
        Me.rdbPorRepuesto.Checked = True
        Me.rdbPorRepuesto.Location = New System.Drawing.Point(6, 16)
        Me.rdbPorRepuesto.Name = "rdbPorRepuesto"
        Me.rdbPorRepuesto.Size = New System.Drawing.Size(90, 17)
        Me.rdbPorRepuesto.TabIndex = 3
        Me.rdbPorRepuesto.TabStop = True
        Me.rdbPorRepuesto.Text = "Por Repuesto"
        Me.rdbPorRepuesto.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaFin.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaFin.Location = New System.Drawing.Point(84, 157)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(129, 18)
        Me.dtpFechaFin.TabIndex = 2
        Me.dtpFechaFin.Tag = Nothing
        Me.dtpFechaFin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFechaCreacion
        '
        Me.dtpFechaCreacion.BackColor = System.Drawing.SystemColors.Info
        Me.dtpFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaCreacion.EditMask = "##/##/####"
        Me.dtpFechaCreacion.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaCreacion.Location = New System.Drawing.Point(328, 128)
        Me.dtpFechaCreacion.Name = "dtpFechaCreacion"
        Me.dtpFechaCreacion.Size = New System.Drawing.Size(129, 18)
        Me.dtpFechaCreacion.TabIndex = 3
        Me.dtpFechaCreacion.TabStop = False
        Me.dtpFechaCreacion.Tag = "BLOQUEADO"
        Me.dtpFechaCreacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaInicio.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaInicio.Location = New System.Drawing.Point(84, 128)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(129, 18)
        Me.dtpFechaInicio.TabIndex = 1
        Me.dtpFechaInicio.Tag = Nothing
        Me.dtpFechaInicio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(401, 27)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 2
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(82, 50)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(375, 65)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.Tag = ""
        '
        'txtUsuarioCreacion
        '
        Me.txtUsuarioCreacion.BackColor = System.Drawing.SystemColors.Info
        Me.txtUsuarioCreacion.Location = New System.Drawing.Point(328, 159)
        Me.txtUsuarioCreacion.Name = "txtUsuarioCreacion"
        Me.txtUsuarioCreacion.Size = New System.Drawing.Size(129, 20)
        Me.txtUsuarioCreacion.TabIndex = 1
        Me.txtUsuarioCreacion.TabStop = False
        Me.txtUsuarioCreacion.Tag = "BLOQUEADO"
        '
        'txtSfaPromocionID
        '
        Me.txtSfaPromocionID.Location = New System.Drawing.Point(82, 24)
        Me.txtSfaPromocionID.Name = "txtSfaPromocionID"
        Me.txtSfaPromocionID.Size = New System.Drawing.Size(131, 20)
        Me.txtSfaPromocionID.TabIndex = 1
        Me.txtSfaPromocionID.TabStop = False
        Me.txtSfaPromocionID.Tag = "BLOQUEADO"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(239, 159)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.Location = New System.Drawing.Point(239, 131)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaCreacion.TabIndex = 0
        Me.lblFechaCreacion.Text = "Fecha Creación:"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(10, 159)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaFin.TabIndex = 0
        Me.lblFechaFin.Tag = "OBLIGATORIO"
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(10, 131)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Tag = "OBLIGATORIO"
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(6, 52)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Tag = "OBLIGATORIO"
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(6, 27)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(70, 13)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "# Promoción:"
        '
        'gbxSucursales
        '
        Me.gbxSucursales.Controls.Add(Me.grdSucursales)
        Me.gbxSucursales.Controls.Add(Me.chkTodas)
        Me.gbxSucursales.Location = New System.Drawing.Point(498, 33)
        Me.gbxSucursales.Name = "gbxSucursales"
        Me.gbxSucursales.Size = New System.Drawing.Size(322, 237)
        Me.gbxSucursales.TabIndex = 0
        Me.gbxSucursales.TabStop = False
        Me.gbxSucursales.Text = "Activar para:"
        '
        'grdSucursales
        '
        Me.grdSucursales.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdSucursales.Images.Add(CType(resources.GetObject("grdSucursales.Images"), System.Drawing.Image))
        Me.grdSucursales.Location = New System.Drawing.Point(10, 21)
        Me.grdSucursales.Name = "grdSucursales"
        Me.grdSucursales.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdSucursales.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdSucursales.PreviewInfo.ZoomFactor = 75
        Me.grdSucursales.PrintInfo.PageSettings = CType(resources.GetObject("grdSucursales.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdSucursales.Size = New System.Drawing.Size(294, 182)
        Me.grdSucursales.TabIndex = 7
        Me.grdSucursales.PropBag = resources.GetString("grdSucursales.PropBag")
        '
        'chkTodas
        '
        Me.chkTodas.AutoSize = True
        Me.chkTodas.Location = New System.Drawing.Point(52, 209)
        Me.chkTodas.Name = "chkTodas"
        Me.chkTodas.Size = New System.Drawing.Size(115, 17)
        Me.chkTodas.TabIndex = 8
        Me.chkTodas.Text = "Seleccionar Todas"
        Me.chkTodas.UseVisualStyleBackColor = True
        '
        'tcDetallePorTipo
        '
        Me.tcDetallePorTipo.Controls.Add(Me.tpGlobalTipo)
        Me.tcDetallePorTipo.Location = New System.Drawing.Point(12, 552)
        Me.tcDetallePorTipo.Name = "tcDetallePorTipo"
        Me.tcDetallePorTipo.SelectedIndex = 0
        Me.tcDetallePorTipo.Size = New System.Drawing.Size(810, 257)
        Me.tcDetallePorTipo.TabIndex = 9
        '
        'tpGlobalTipo
        '
        Me.tpGlobalTipo.Controls.Add(Me.cneDescuentoTipo)
        Me.tpGlobalTipo.Controls.Add(Me.cmbTiposRepuestos)
        Me.tpGlobalTipo.Controls.Add(Me.grdDetalleGlobalTipo)
        Me.tpGlobalTipo.Location = New System.Drawing.Point(4, 22)
        Me.tpGlobalTipo.Name = "tpGlobalTipo"
        Me.tpGlobalTipo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGlobalTipo.Size = New System.Drawing.Size(802, 231)
        Me.tpGlobalTipo.TabIndex = 1
        Me.tpGlobalTipo.Text = "Global por Tipo"
        Me.tpGlobalTipo.UseVisualStyleBackColor = True
        '
        'cneDescuentoTipo
        '
        Me.cneDescuentoTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cneDescuentoTipo.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.cneDescuentoTipo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.cneDescuentoTipo.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.cneDescuentoTipo.Location = New System.Drawing.Point(317, 40)
        Me.cneDescuentoTipo.MaxLength = 4
        Me.cneDescuentoTipo.Name = "cneDescuentoTipo"
        Me.cneDescuentoTipo.Size = New System.Drawing.Size(124, 18)
        Me.cneDescuentoTipo.TabIndex = 96
        Me.cneDescuentoTipo.Tag = Nothing
        Me.cneDescuentoTipo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.cneDescuentoTipo.Visible = False
        Me.cneDescuentoTipo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmbTiposRepuestos
        '
        Me.cmbTiposRepuestos.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTiposRepuestos.AutoCompletion = True
        Me.cmbTiposRepuestos.AutoDropDown = True
        Me.cmbTiposRepuestos.AutoSelect = True
        Me.cmbTiposRepuestos.Caption = ""
        Me.cmbTiposRepuestos.CaptionHeight = 17
        Me.cmbTiposRepuestos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTiposRepuestos.ColumnCaptionHeight = 17
        Me.cmbTiposRepuestos.ColumnFooterHeight = 17
        Me.cmbTiposRepuestos.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTiposRepuestos.ContentHeight = 15
        Me.cmbTiposRepuestos.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTiposRepuestos.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTiposRepuestos.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTiposRepuestos.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTiposRepuestos.EditorHeight = 15
        Me.cmbTiposRepuestos.Images.Add(CType(resources.GetObject("cmbTiposRepuestos.Images"), System.Drawing.Image))
        Me.cmbTiposRepuestos.ItemHeight = 15
        Me.cmbTiposRepuestos.Location = New System.Drawing.Point(21, 37)
        Me.cmbTiposRepuestos.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTiposRepuestos.MaxDropDownItems = CType(10, Short)
        Me.cmbTiposRepuestos.MaxLength = 32767
        Me.cmbTiposRepuestos.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTiposRepuestos.Name = "cmbTiposRepuestos"
        Me.cmbTiposRepuestos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTiposRepuestos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTiposRepuestos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTiposRepuestos.Size = New System.Drawing.Size(290, 21)
        Me.cmbTiposRepuestos.TabIndex = 94
        Me.cmbTiposRepuestos.Visible = False
        Me.cmbTiposRepuestos.PropBag = resources.GetString("cmbTiposRepuestos.PropBag")
        '
        'grdDetalleGlobalTipo
        '
        Me.grdDetalleGlobalTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalleGlobalTipo.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleGlobalTipo.Images.Add(CType(resources.GetObject("grdDetalleGlobalTipo.Images"), System.Drawing.Image))
        Me.grdDetalleGlobalTipo.Images.Add(CType(resources.GetObject("grdDetalleGlobalTipo.Images1"), System.Drawing.Image))
        Me.grdDetalleGlobalTipo.Location = New System.Drawing.Point(3, 3)
        Me.grdDetalleGlobalTipo.Name = "grdDetalleGlobalTipo"
        Me.grdDetalleGlobalTipo.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleGlobalTipo.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleGlobalTipo.PreviewInfo.ZoomFactor = 75
        Me.grdDetalleGlobalTipo.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalleGlobalTipo.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalleGlobalTipo.RowHeight = 18
        Me.grdDetalleGlobalTipo.Size = New System.Drawing.Size(796, 225)
        Me.grdDetalleGlobalTipo.TabIndex = 0
        Me.grdDetalleGlobalTipo.PropBag = resources.GetString("grdDetalleGlobalTipo.PropBag")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(746, 544)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 91
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(666, 544)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 90
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Location = New System.Drawing.Point(11, 536)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(517, 13)
        Me.lblNota.TabIndex = 92
        Me.lblNota.Text = "Nota: De crearse promoción sobre un producto ya promocionado entrará en vigencia " & _
            "el de mayor descuento"
        '
        'ErrErrores
        '
        Me.ErrErrores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrErrores.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(835, 32)
        Me.Panel2.TabIndex = 93
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(770, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SCCUM.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 577)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 21)
        Me.Panel1.TabIndex = 94
        '
        'tcDetallePorRepuesto
        '
        Me.tcDetallePorRepuesto.Controls.Add(Me.tpPorRepuesto)
        Me.tcDetallePorRepuesto.Location = New System.Drawing.Point(10, 276)
        Me.tcDetallePorRepuesto.Name = "tcDetallePorRepuesto"
        Me.tcDetallePorRepuesto.SelectedIndex = 0
        Me.tcDetallePorRepuesto.Size = New System.Drawing.Size(811, 257)
        Me.tcDetallePorRepuesto.TabIndex = 6
        '
        'tpPorRepuesto
        '
        Me.tpPorRepuesto.Controls.Add(Me.cneDescuento)
        Me.tpPorRepuesto.Controls.Add(Me.cmbDescripcionRepuestos)
        Me.tpPorRepuesto.Controls.Add(Me.grdDetallePorRepuesto)
        Me.tpPorRepuesto.Location = New System.Drawing.Point(4, 22)
        Me.tpPorRepuesto.Name = "tpPorRepuesto"
        Me.tpPorRepuesto.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPorRepuesto.Size = New System.Drawing.Size(803, 231)
        Me.tpPorRepuesto.TabIndex = 0
        Me.tpPorRepuesto.Text = "Por Repuesto"
        Me.tpPorRepuesto.UseVisualStyleBackColor = True
        '
        'cneDescuento
        '
        Me.cneDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cneDescuento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.cneDescuento.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.cneDescuento.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.cneDescuento.Location = New System.Drawing.Point(524, 32)
        Me.cneDescuento.MaxLength = 4
        Me.cneDescuento.Name = "cneDescuento"
        Me.cneDescuento.Size = New System.Drawing.Size(74, 18)
        Me.cneDescuento.TabIndex = 97
        Me.cneDescuento.Tag = Nothing
        Me.cneDescuento.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.cneDescuento.Visible = False
        Me.cneDescuento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmbDescripcionRepuestos
        '
        Me.cmbDescripcionRepuestos.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbDescripcionRepuestos.AutoCompletion = True
        Me.cmbDescripcionRepuestos.AutoDropDown = True
        Me.cmbDescripcionRepuestos.AutoSelect = True
        Me.cmbDescripcionRepuestos.Caption = ""
        Me.cmbDescripcionRepuestos.CaptionHeight = 17
        Me.cmbDescripcionRepuestos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbDescripcionRepuestos.ColumnCaptionHeight = 17
        Me.cmbDescripcionRepuestos.ColumnFooterHeight = 17
        Me.cmbDescripcionRepuestos.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbDescripcionRepuestos.ContentHeight = 15
        Me.cmbDescripcionRepuestos.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbDescripcionRepuestos.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbDescripcionRepuestos.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDescripcionRepuestos.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDescripcionRepuestos.EditorHeight = 15
        Me.cmbDescripcionRepuestos.Images.Add(CType(resources.GetObject("cmbDescripcionRepuestos.Images"), System.Drawing.Image))
        Me.cmbDescripcionRepuestos.ItemHeight = 15
        Me.cmbDescripcionRepuestos.Location = New System.Drawing.Point(28, 31)
        Me.cmbDescripcionRepuestos.MatchEntryTimeout = CType(2000, Long)
        Me.cmbDescripcionRepuestos.MaxDropDownItems = CType(10, Short)
        Me.cmbDescripcionRepuestos.MaxLength = 32767
        Me.cmbDescripcionRepuestos.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbDescripcionRepuestos.Name = "cmbDescripcionRepuestos"
        Me.cmbDescripcionRepuestos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbDescripcionRepuestos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbDescripcionRepuestos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbDescripcionRepuestos.Size = New System.Drawing.Size(200, 21)
        Me.cmbDescripcionRepuestos.TabIndex = 96
        Me.cmbDescripcionRepuestos.Visible = False
        Me.cmbDescripcionRepuestos.PropBag = resources.GetString("cmbDescripcionRepuestos.PropBag")
        '
        'grdDetallePorRepuesto
        '
        Me.grdDetallePorRepuesto.AllowAddNew = True
        Me.grdDetallePorRepuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetallePorRepuesto.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetallePorRepuesto.Images.Add(CType(resources.GetObject("grdDetallePorRepuesto.Images"), System.Drawing.Image))
        Me.grdDetallePorRepuesto.Location = New System.Drawing.Point(3, 3)
        Me.grdDetallePorRepuesto.Name = "grdDetallePorRepuesto"
        Me.grdDetallePorRepuesto.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetallePorRepuesto.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetallePorRepuesto.PreviewInfo.ZoomFactor = 75
        Me.grdDetallePorRepuesto.PrintInfo.PageSettings = CType(resources.GetObject("grdDetallePorRepuesto.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetallePorRepuesto.RowHeight = 18
        Me.grdDetallePorRepuesto.Size = New System.Drawing.Size(797, 225)
        Me.grdDetallePorRepuesto.TabIndex = 1
        Me.grdDetallePorRepuesto.PropBag = resources.GetString("grdDetallePorRepuesto.PropBag")
        '
        'frmSfaPromocionesEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 598)
        Me.Controls.Add(Me.tcDetallePorRepuesto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.tcDetallePorTipo)
        Me.Controls.Add(Me.gbxSucursales)
        Me.Controls.Add(Me.gbxDatosGenerales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaPromocionesEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Promoción"
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        Me.gbxTipoPromocion.ResumeLayout(False)
        Me.gbxTipoPromocion.PerformLayout()
        CType(Me.dtpFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaCreacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSucursales.ResumeLayout(False)
        Me.gbxSucursales.PerformLayout()
        CType(Me.grdSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcDetallePorTipo.ResumeLayout(False)
        Me.tpGlobalTipo.ResumeLayout(False)
        CType(Me.cneDescuentoTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTiposRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleGlobalTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcDetallePorRepuesto.ResumeLayout(False)
        Me.tpPorRepuesto.ResumeLayout(False)
        CType(Me.cneDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDescripcionRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetallePorRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents gbxSucursales As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtSfaPromocionID As System.Windows.Forms.TextBox
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaInicio As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaCreacion As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblFechaCreacion As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents gbxTipoPromocion As System.Windows.Forms.GroupBox
    Friend WithEvents rdbGlobalTipo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPorRepuesto As System.Windows.Forms.RadioButton
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents tcDetallePorTipo As System.Windows.Forms.TabControl
    Friend WithEvents tpGlobalTipo As System.Windows.Forms.TabPage
    Friend WithEvents grdSucursales As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents chkTodas As System.Windows.Forms.CheckBox
    Friend WithEvents grdDetalleGlobalTipo As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Friend WithEvents ErrErrores As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbTiposRepuestos As C1.Win.C1List.C1Combo
    Friend WithEvents lblTipoPromoción As System.Windows.Forms.Label
    Friend WithEvents chkAplicanRestricciones As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cneDescuentoTipo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents tcDetallePorRepuesto As System.Windows.Forms.TabControl
    Friend WithEvents tpPorRepuesto As System.Windows.Forms.TabPage
    Friend WithEvents cneDescuento As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbDescripcionRepuestos As C1.Win.C1List.C1Combo
    Friend WithEvents grdDetallePorRepuesto As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
