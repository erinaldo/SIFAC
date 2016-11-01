<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccCuentas))
        Me.tbCuentas = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdModificarLimite = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscarExpedientes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdReestructurarCuenta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer()
        Me.grdExpedienteDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdExpedienteDetalleTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumeroFact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaldoD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlazo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoAbonado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdExpedienteMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdExpedienteMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCedula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbCuentas.SuspendLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        CType(Me.grdExpedienteDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdExpedienteDetalleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdExpedienteMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdExpedienteMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCuentas
        '
        Me.tbCuentas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.ToolStripSeparator1, Me.cmdModificarLimite, Me.cmdConsultar, Me.cmdBuscarExpedientes, Me.ToolStripSeparator2, Me.cmdReestructurarCuenta, Me.ToolStripSeparator3, Me.cmdRefrescar, Me.cmdSalir})
        Me.tbCuentas.Location = New System.Drawing.Point(0, 0)
        Me.tbCuentas.Name = "tbCuentas"
        Me.tbCuentas.Size = New System.Drawing.Size(863, 39)
        Me.tbCuentas.TabIndex = 0
        Me.tbCuentas.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Agregar Expediente"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Expediente de Cuenta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdModificarLimite
        '
        Me.cmdModificarLimite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdModificarLimite.Image = CType(resources.GetObject("cmdModificarLimite.Image"), System.Drawing.Image)
        Me.cmdModificarLimite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdModificarLimite.Name = "cmdModificarLimite"
        Me.cmdModificarLimite.Size = New System.Drawing.Size(36, 36)
        Me.cmdModificarLimite.ToolTipText = "Modificar Limite de Crédito"
        Me.cmdModificarLimite.Visible = False
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Expediente"
        '
        'cmdBuscarExpedientes
        '
        Me.cmdBuscarExpedientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscarExpedientes.Image = CType(resources.GetObject("cmdBuscarExpedientes.Image"), System.Drawing.Image)
        Me.cmdBuscarExpedientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscarExpedientes.Name = "cmdBuscarExpedientes"
        Me.cmdBuscarExpedientes.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscarExpedientes.Text = "Buscar Expedientes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdReestructurarCuenta
        '
        Me.cmdReestructurarCuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdReestructurarCuenta.Image = CType(resources.GetObject("cmdReestructurarCuenta.Image"), System.Drawing.Image)
        Me.cmdReestructurarCuenta.ImageTransparentColor = System.Drawing.Color.Silver
        Me.cmdReestructurarCuenta.Name = "cmdReestructurarCuenta"
        Me.cmdReestructurarCuenta.Size = New System.Drawing.Size(36, 36)
        Me.cmdReestructurarCuenta.Text = "Reestructurar Cuenta"
        Me.cmdReestructurarCuenta.ToolTipText = "Reestructurar Cuenta"
        Me.cmdReestructurarCuenta.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir de Formulario"
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.grdExpedienteMaster)
        Me.C1Sizer1.Controls.Add(Me.grdExpedienteDetalle)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "60.7287449392713:False:False;36.8421052631579:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0730011587486:False" & _
    ":False;"
        Me.C1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 39)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(863, 494)
        Me.C1Sizer1.TabIndex = 1
        Me.C1Sizer1.TabStop = False
        '
        'grdExpedienteDetalle
        '
        Me.grdExpedienteDetalle.Location = New System.Drawing.Point(4, 308)
        Me.grdExpedienteDetalle.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdExpedienteDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdExpedienteDetalle.MainView = Me.grdExpedienteDetalleTable
        Me.grdExpedienteDetalle.Name = "grdExpedienteDetalle"
        Me.grdExpedienteDetalle.Size = New System.Drawing.Size(855, 182)
        Me.grdExpedienteDetalle.TabIndex = 12
        Me.grdExpedienteDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdExpedienteDetalleTable})
        '
        'grdExpedienteDetalleTable
        '
        Me.grdExpedienteDetalleTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumeroFact, Me.colMontoTotal, Me.SaldoD, Me.colPlazo, Me.colMontoCuota, Me.colMontoAbonado, Me.colEstadoF})
        Me.grdExpedienteDetalleTable.GridControl = Me.grdExpedienteDetalle
        Me.grdExpedienteDetalleTable.Name = "grdExpedienteDetalleTable"
        Me.grdExpedienteDetalleTable.OptionsView.ShowAutoFilterRow = True
        Me.grdExpedienteDetalleTable.OptionsView.ShowGroupPanel = False
        '
        'colNumeroFact
        '
        Me.colNumeroFact.Caption = "No Factura"
        Me.colNumeroFact.FieldName = "Numero"
        Me.colNumeroFact.Name = "colNumeroFact"
        Me.colNumeroFact.OptionsColumn.AllowEdit = False
        Me.colNumeroFact.Visible = True
        Me.colNumeroFact.VisibleIndex = 0
        '
        'colMontoTotal
        '
        Me.colMontoTotal.Caption = "Monto Total"
        Me.colMontoTotal.FieldName = "MontoTotal"
        Me.colMontoTotal.Name = "colMontoTotal"
        Me.colMontoTotal.OptionsColumn.AllowEdit = False
        Me.colMontoTotal.Visible = True
        Me.colMontoTotal.VisibleIndex = 1
        '
        'SaldoD
        '
        Me.SaldoD.Caption = "Saldo"
        Me.SaldoD.FieldName = "Saldo"
        Me.SaldoD.Name = "SaldoD"
        Me.SaldoD.OptionsColumn.AllowEdit = False
        Me.SaldoD.Visible = True
        Me.SaldoD.VisibleIndex = 2
        '
        'colPlazo
        '
        Me.colPlazo.Caption = "Plazo"
        Me.colPlazo.FieldName = "Plazo"
        Me.colPlazo.Name = "colPlazo"
        Me.colPlazo.OptionsColumn.AllowEdit = False
        Me.colPlazo.Visible = True
        Me.colPlazo.VisibleIndex = 4
        '
        'colMontoCuota
        '
        Me.colMontoCuota.Caption = "Monto Cuota"
        Me.colMontoCuota.FieldName = "MontoCuota"
        Me.colMontoCuota.Name = "colMontoCuota"
        Me.colMontoCuota.OptionsColumn.AllowEdit = False
        Me.colMontoCuota.Visible = True
        Me.colMontoCuota.VisibleIndex = 3
        '
        'colMontoAbonado
        '
        Me.colMontoAbonado.Caption = "Monto Abonado"
        Me.colMontoAbonado.FieldName = "MontoAbonado"
        Me.colMontoAbonado.Name = "colMontoAbonado"
        Me.colMontoAbonado.OptionsColumn.AllowEdit = False
        Me.colMontoAbonado.Visible = True
        Me.colMontoAbonado.VisibleIndex = 5
        '
        'colEstadoF
        '
        Me.colEstadoF.Caption = "Estado"
        Me.colEstadoF.FieldName = "EstadoFact"
        Me.colEstadoF.Name = "colEstadoF"
        Me.colEstadoF.OptionsColumn.AllowEdit = False
        Me.colEstadoF.Visible = True
        Me.colEstadoF.VisibleIndex = 6
        '
        'grdExpedienteMaster
        '
        Me.grdExpedienteMaster.Location = New System.Drawing.Point(4, 4)
        Me.grdExpedienteMaster.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdExpedienteMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdExpedienteMaster.MainView = Me.grdExpedienteMasterTabla
        Me.grdExpedienteMaster.Name = "grdExpedienteMaster"
        Me.grdExpedienteMaster.Size = New System.Drawing.Size(855, 300)
        Me.grdExpedienteMaster.TabIndex = 13
        Me.grdExpedienteMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdExpedienteMasterTabla})
        '
        'grdExpedienteMasterTabla
        '
        Me.grdExpedienteMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colCliente, Me.colSaldo, Me.colEstado, Me.colCedula})
        Me.grdExpedienteMasterTabla.GridControl = Me.grdExpedienteMaster
        Me.grdExpedienteMasterTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdExpedienteMasterTabla.Name = "grdExpedienteMasterTabla"
        Me.grdExpedienteMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdExpedienteMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdExpedienteMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdExpedienteMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdExpedienteMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdExpedienteMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "No Expediente" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 0
        Me.colNumero.Width = 76
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha Credito"
        Me.colFecha.FieldName = "FechaCredito"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 3
        Me.colFecha.Width = 78
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowFocus = False
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 1
        Me.colCliente.Width = 218
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.OptionsColumn.AllowFocus = False
        Me.colSaldo.OptionsColumn.ReadOnly = True
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 4
        Me.colSaldo.Width = 109
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowFocus = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 5
        Me.colEstado.Width = 86
        '
        'colCedula
        '
        Me.colCedula.Caption = "Cédula"
        Me.colCedula.FieldName = "Cedula"
        Me.colCedula.Name = "colCedula"
        Me.colCedula.OptionsColumn.AllowFocus = False
        Me.colCedula.OptionsColumn.ReadOnly = True
        Me.colCedula.Visible = True
        Me.colCedula.VisibleIndex = 2
        Me.colCedula.Width = 86
        '
        'frmSccCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 533)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Controls.Add(Me.tbCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccCuentas"
        Me.Text = "Expedientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbCuentas.ResumeLayout(False)
        Me.tbCuentas.PerformLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer1.ResumeLayout(False)
        CType(Me.grdExpedienteDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdExpedienteDetalleTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdExpedienteMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdExpedienteMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCuentas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBuscarExpedientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1Sizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdModificarLimite As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdReestructurarCuenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grdExpedienteDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdExpedienteDetalleTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumeroFact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaldoD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlazo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoAbonado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstadoF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdExpedienteMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdExpedienteMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCedula As DevExpress.XtraGrid.Columns.GridColumn
End Class
