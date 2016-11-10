<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaFactura))
        Me.tbCuentas = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditarFactura = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNuevaFecha = New System.Windows.Forms.ToolStripButton()
        Me.cmdProcesarExpedienteFact = New System.Windows.Forms.ToolStripButton()
        Me.cmdAnularFactura = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.grdFacturas = New DevExpress.XtraGrid.GridControl()
        Me.grdFacturasTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNoExpediente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpedienteFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoExpedienteFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoPrima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinanciamiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSfaFacturaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSccCuentaPorCobrarDetalleID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tbCuentas.SuspendLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCuentas
        '
        Me.tbCuentas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditarFactura, Me.ToolStripSeparator3, Me.cmdNuevaFecha, Me.cmdProcesarExpedienteFact, Me.cmdAnularFactura, Me.ToolStripSeparator4, Me.cmdBuscar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdRefrescar, Me.ToolStripSeparator2, Me.cmdSalir})
        Me.tbCuentas.Location = New System.Drawing.Point(0, 0)
        Me.tbCuentas.Name = "tbCuentas"
        Me.tbCuentas.Size = New System.Drawing.Size(1201, 39)
        Me.tbCuentas.TabIndex = 1
        Me.tbCuentas.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Nueva Expediente-Factura"
        '
        'cmdEditarFactura
        '
        Me.cmdEditarFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditarFactura.Image = CType(resources.GetObject("cmdEditarFactura.Image"), System.Drawing.Image)
        Me.cmdEditarFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditarFactura.Name = "cmdEditarFactura"
        Me.cmdEditarFactura.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditarFactura.Text = "ToolStripButton1"
        Me.cmdEditarFactura.ToolTipText = "Editar Expediente-Factura"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdNuevaFecha
        '
        Me.cmdNuevaFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNuevaFecha.Image = CType(resources.GetObject("cmdNuevaFecha.Image"), System.Drawing.Image)
        Me.cmdNuevaFecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNuevaFecha.Name = "cmdNuevaFecha"
        Me.cmdNuevaFecha.Size = New System.Drawing.Size(36, 36)
        Me.cmdNuevaFecha.ToolTipText = "Realizar Desplazamiento de Fecha de Pago Próxima"
        '
        'cmdProcesarExpedienteFact
        '
        Me.cmdProcesarExpedienteFact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdProcesarExpedienteFact.Image = CType(resources.GetObject("cmdProcesarExpedienteFact.Image"), System.Drawing.Image)
        Me.cmdProcesarExpedienteFact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcesarExpedienteFact.Name = "cmdProcesarExpedienteFact"
        Me.cmdProcesarExpedienteFact.Size = New System.Drawing.Size(36, 36)
        Me.cmdProcesarExpedienteFact.Text = "Procesar Expediente-Factura"
        '
        'cmdAnularFactura
        '
        Me.cmdAnularFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnularFactura.Image = CType(resources.GetObject("cmdAnularFactura.Image"), System.Drawing.Image)
        Me.cmdAnularFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnularFactura.Name = "cmdAnularFactura"
        Me.cmdAnularFactura.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnularFactura.Text = "Anular Expediente-Factura"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.Text = "Buscar Expediente-Factura"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Expediente-Factura"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.Text = "ToolStripButton1"
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir"
        '
        'grdFacturas
        '
        Me.grdFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFacturas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdFacturas.Location = New System.Drawing.Point(0, 39)
        Me.grdFacturas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdFacturas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdFacturas.MainView = Me.grdFacturasTabla
        Me.grdFacturas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdFacturas.Size = New System.Drawing.Size(1201, 649)
        Me.grdFacturas.TabIndex = 9
        Me.grdFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdFacturasTabla})
        '
        'grdFacturasTabla
        '
        Me.grdFacturasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoExpediente, Me.colExpedienteFactura, Me.colEstadoExpedienteFactura, Me.colFecha, Me.colCliente, Me.colMontoTotal, Me.colMontoPrima, Me.colFinanciamiento, Me.colSaldo, Me.colSfaFacturaID, Me.colSccCuentaPorCobrarDetalleID})
        Me.grdFacturasTabla.GridControl = Me.grdFacturas
        Me.grdFacturasTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdFacturasTabla.Name = "grdFacturasTabla"
        Me.grdFacturasTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdFacturasTabla.Tag = ""
        '
        'colNoExpediente
        '
        Me.colNoExpediente.Caption = "No Expediente"
        Me.colNoExpediente.FieldName = "objSccCuentaID"
        Me.colNoExpediente.Name = "colNoExpediente"
        Me.colNoExpediente.OptionsColumn.AllowEdit = False
        Me.colNoExpediente.OptionsColumn.ReadOnly = True
        Me.colNoExpediente.Visible = True
        Me.colNoExpediente.VisibleIndex = 0
        Me.colNoExpediente.Width = 108
        '
        'colExpedienteFactura
        '
        Me.colExpedienteFactura.Caption = "No Expediente-Factura"
        Me.colExpedienteFactura.FieldName = "Numero"
        Me.colExpedienteFactura.Name = "colExpedienteFactura"
        Me.colExpedienteFactura.OptionsColumn.AllowEdit = False
        Me.colExpedienteFactura.Visible = True
        Me.colExpedienteFactura.VisibleIndex = 1
        Me.colExpedienteFactura.Width = 133
        '
        'colEstadoExpedienteFactura
        '
        Me.colEstadoExpedienteFactura.Caption = "Estado Expediente -Factura"
        Me.colEstadoExpedienteFactura.FieldName = "Estado"
        Me.colEstadoExpedienteFactura.Name = "colEstadoExpedienteFactura"
        Me.colEstadoExpedienteFactura.OptionsColumn.AllowEdit = False
        Me.colEstadoExpedienteFactura.OptionsColumn.ReadOnly = True
        Me.colEstadoExpedienteFactura.Visible = True
        Me.colEstadoExpedienteFactura.VisibleIndex = 2
        Me.colEstadoExpedienteFactura.Width = 150
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 3
        Me.colFecha.Width = 76
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 128
        '
        'colMontoTotal
        '
        Me.colMontoTotal.Caption = "Monto Total"
        Me.colMontoTotal.FieldName = "MontoCredito"
        Me.colMontoTotal.Name = "colMontoTotal"
        Me.colMontoTotal.OptionsColumn.AllowEdit = False
        Me.colMontoTotal.Visible = True
        Me.colMontoTotal.VisibleIndex = 5
        Me.colMontoTotal.Width = 80
        '
        'colMontoPrima
        '
        Me.colMontoPrima.Caption = "Monto Prima"
        Me.colMontoPrima.FieldName = "MontoPrima"
        Me.colMontoPrima.Name = "colMontoPrima"
        Me.colMontoPrima.OptionsColumn.AllowEdit = False
        Me.colMontoPrima.Visible = True
        Me.colMontoPrima.VisibleIndex = 6
        Me.colMontoPrima.Width = 54
        '
        'colFinanciamiento
        '
        Me.colFinanciamiento.Caption = "Financiamiento"
        Me.colFinanciamiento.FieldName = "Financiamiento"
        Me.colFinanciamiento.Name = "colFinanciamiento"
        Me.colFinanciamiento.OptionsColumn.AllowEdit = False
        Me.colFinanciamiento.Visible = True
        Me.colFinanciamiento.VisibleIndex = 7
        Me.colFinanciamiento.Width = 83
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.OptionsColumn.AllowEdit = False
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 8
        Me.colSaldo.Width = 71
        '
        'colSfaFacturaID
        '
        Me.colSfaFacturaID.Caption = "SfaFacturaID"
        Me.colSfaFacturaID.FieldName = "SfaFacturaID"
        Me.colSfaFacturaID.Name = "colSfaFacturaID"
        Me.colSfaFacturaID.OptionsColumn.AllowEdit = False
        '
        'colSccCuentaPorCobrarDetalleID
        '
        Me.colSccCuentaPorCobrarDetalleID.Caption = "SccCuentaPorCobrarDetalleID"
        Me.colSccCuentaPorCobrarDetalleID.FieldName = "SccCuentaPorCobrarDetalleID"
        Me.colSccCuentaPorCobrarDetalleID.Name = "colSccCuentaPorCobrarDetalleID"
        Me.colSccCuentaPorCobrarDetalleID.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSfaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 688)
        Me.Controls.Add(Me.grdFacturas)
        Me.Controls.Add(Me.tbCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSfaFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expediente-Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbCuentas.ResumeLayout(False)
        Me.tbCuentas.PerformLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFacturasTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCuentas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdEditarFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnularFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdProcesarExpedienteFact As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNuevaFecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdFacturasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNoExpediente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpedienteFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstadoExpedienteFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinanciamiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSfaFacturaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSccCuentaPorCobrarDetalleID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
