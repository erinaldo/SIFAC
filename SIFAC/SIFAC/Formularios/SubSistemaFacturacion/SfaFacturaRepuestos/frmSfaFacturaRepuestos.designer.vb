<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaFacturaRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaFacturaRepuestos))
        Me.barFacturaRepuesto = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregaDesdeCotizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdProcesar = New System.Windows.Forms.ToolStripButton
        Me.cmdAnular = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton
        Me.cmdActualizar = New System.Windows.Forms.ToolStripButton
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer
        Me.grdFacturaDetalle = New DevExpress.XtraGrid.GridControl
        Me.grdFacturaDetalleTable = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalDetalle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdFacturaMaster = New DevExpress.XtraGrid.GridControl
        Me.grdFacturaMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVendedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSolicitud = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescAutorizado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAnulada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.barFacturaRepuesto.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.grdFacturaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturaDetalleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturaMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturaMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barFacturaRepuesto
        '
        Me.barFacturaRepuesto.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.barFacturaRepuesto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdProcesar, Me.cmdAnular, Me.cmdConsultar, Me.cmdBuscar, Me.cmdImprimir, Me.cmdActualizar, Me.cmdSalir})
        Me.barFacturaRepuesto.Location = New System.Drawing.Point(0, 0)
        Me.barFacturaRepuesto.Name = "barFacturaRepuesto"
        Me.barFacturaRepuesto.Size = New System.Drawing.Size(943, 39)
        Me.barFacturaRepuesto.TabIndex = 0
        Me.barFacturaRepuesto.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AgregaDesdeCotizaciónToolStripMenuItem})
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(48, 36)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem1.Text = "Agregar"
        '
        'AgregaDesdeCotizaciónToolStripMenuItem
        '
        Me.AgregaDesdeCotizaciónToolStripMenuItem.Name = "AgregaDesdeCotizaciónToolStripMenuItem"
        Me.AgregaDesdeCotizaciónToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AgregaDesdeCotizaciónToolStripMenuItem.Text = "Agregar desde Cotización"
        '
        'cmdProcesar
        '
        Me.cmdProcesar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdProcesar.Image = CType(resources.GetObject("cmdProcesar.Image"), System.Drawing.Image)
        Me.cmdProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(36, 36)
        '
        'cmdAnular
        '
        Me.cmdAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnular.Image = CType(resources.GetObject("cmdAnular.Image"), System.Drawing.Image)
        Me.cmdAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(36, 36)
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        '
        'cmdActualizar
        '
        Me.cmdActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(36, 36)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.grdFacturaDetalle)
        Me.Contenedor.Controls.Add(Me.grdFacturaMaster)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "48.6284289276808:False:False;48.3790523690773:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.1516436903499:False" & _
            ":False;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(0, 39)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(943, 401)
        Me.Contenedor.TabIndex = 1
        Me.Contenedor.TabStop = False
        '
        'grdFacturaDetalle
        '
        '
        '
        '
        Me.grdFacturaDetalle.EmbeddedNavigator.Name = ""
        Me.grdFacturaDetalle.Location = New System.Drawing.Point(4, 203)
        Me.grdFacturaDetalle.MainView = Me.grdFacturaDetalleTable
        Me.grdFacturaDetalle.Name = "grdFacturaDetalle"
        Me.grdFacturaDetalle.Size = New System.Drawing.Size(935, 194)
        Me.grdFacturaDetalle.TabIndex = 3
        Me.grdFacturaDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdFacturaDetalleTable})
        '
        'grdFacturaDetalleTable
        '
        Me.grdFacturaDetalleTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colPrecio, Me.colSubTotal, Me.colDesc, Me.colIVA, Me.colTotalDetalle})
        Me.grdFacturaDetalleTable.GridControl = Me.grdFacturaDetalle
        Me.grdFacturaDetalleTable.Name = "grdFacturaDetalleTable"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "objRepuestoID"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowFocus = False
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "DescripcionCorta"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        '
        'colPrecio
        '
        Me.colPrecio.Caption = "Precio U"
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.AllowFocus = False
        Me.colPrecio.OptionsColumn.ReadOnly = True
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 3
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "Sub Total"
        Me.colSubTotal.FieldName = "Subtotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.OptionsColumn.AllowFocus = False
        Me.colSubTotal.OptionsColumn.ReadOnly = True
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 4
        '
        'colDesc
        '
        Me.colDesc.Caption = "Desc."
        Me.colDesc.FieldName = "Descuento"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.OptionsColumn.AllowFocus = False
        Me.colDesc.OptionsColumn.ReadOnly = True
        Me.colDesc.Visible = True
        Me.colDesc.VisibleIndex = 5
        '
        'colIVA
        '
        Me.colIVA.Caption = "IVA"
        Me.colIVA.FieldName = "Impuesto"
        Me.colIVA.Name = "colIVA"
        Me.colIVA.OptionsColumn.AllowFocus = False
        Me.colIVA.OptionsColumn.ReadOnly = True
        Me.colIVA.Visible = True
        Me.colIVA.VisibleIndex = 6
        '
        'colTotalDetalle
        '
        Me.colTotalDetalle.Caption = "Total"
        Me.colTotalDetalle.FieldName = "Total"
        Me.colTotalDetalle.Name = "colTotalDetalle"
        Me.colTotalDetalle.OptionsColumn.AllowFocus = False
        Me.colTotalDetalle.OptionsColumn.ReadOnly = True
        Me.colTotalDetalle.Visible = True
        Me.colTotalDetalle.VisibleIndex = 7
        '
        'grdFacturaMaster
        '
        '
        '
        '
        Me.grdFacturaMaster.EmbeddedNavigator.Name = ""
        Me.grdFacturaMaster.Location = New System.Drawing.Point(4, 4)
        Me.grdFacturaMaster.MainView = Me.grdFacturaMasterTabla
        Me.grdFacturaMaster.Name = "grdFacturaMaster"
        Me.grdFacturaMaster.Size = New System.Drawing.Size(935, 195)
        Me.grdFacturaMaster.TabIndex = 2
        Me.grdFacturaMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdFacturaMasterTabla})
        '
        'grdFacturaMasterTabla
        '
        Me.grdFacturaMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colCliente, Me.colVendedor, Me.colTotal, Me.colEstado, Me.colSolicitud, Me.colDescAutorizado, Me.colAnulada})
        Me.grdFacturaMasterTabla.GridControl = Me.grdFacturaMaster
        Me.grdFacturaMasterTabla.Name = "grdFacturaMasterTabla"
        Me.grdFacturaMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdFacturaMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdFacturaMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdFacturaMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdFacturaMasterTabla.OptionsDetail.SmartDetailExpandButton = False
        Me.grdFacturaMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
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
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
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
        Me.colCliente.VisibleIndex = 2
        Me.colCliente.Width = 218
        '
        'colVendedor
        '
        Me.colVendedor.Caption = "Vendedor"
        Me.colVendedor.FieldName = "Vendedor"
        Me.colVendedor.Name = "colVendedor"
        Me.colVendedor.OptionsColumn.AllowFocus = False
        Me.colVendedor.OptionsColumn.ReadOnly = True
        Me.colVendedor.Visible = True
        Me.colVendedor.VisibleIndex = 3
        Me.colVendedor.Width = 109
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total $"
        Me.colTotal.FieldName = "TotalDolares"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowFocus = False
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 4
        Me.colTotal.Width = 86
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
        'colSolicitud
        '
        Me.colSolicitud.Caption = "Solic Desc"
        Me.colSolicitud.FieldName = "SolicAutorDescuento"
        Me.colSolicitud.Name = "colSolicitud"
        Me.colSolicitud.OptionsColumn.AllowFocus = False
        Me.colSolicitud.OptionsColumn.ReadOnly = True
        Me.colSolicitud.Visible = True
        Me.colSolicitud.VisibleIndex = 6
        Me.colSolicitud.Width = 86
        '
        'colDescAutorizado
        '
        Me.colDescAutorizado.Caption = "Desc Autor"
        Me.colDescAutorizado.FieldName = "AutorizaDescuento"
        Me.colDescAutorizado.Name = "colDescAutorizado"
        Me.colDescAutorizado.OptionsColumn.AllowFocus = False
        Me.colDescAutorizado.OptionsColumn.ReadOnly = True
        Me.colDescAutorizado.Visible = True
        Me.colDescAutorizado.VisibleIndex = 7
        Me.colDescAutorizado.Width = 86
        '
        'colAnulada
        '
        Me.colAnulada.Caption = "Anulada"
        Me.colAnulada.FieldName = "Anulada"
        Me.colAnulada.Name = "colAnulada"
        Me.colAnulada.OptionsColumn.AllowFocus = False
        Me.colAnulada.OptionsColumn.ReadOnly = True
        Me.colAnulada.Visible = True
        Me.colAnulada.VisibleIndex = 8
        Me.colAnulada.Width = 86
        '
        'frmSfaFacturaRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 440)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.barFacturaRepuesto)
        Me.Name = "frmSfaFacturaRepuestos"
        Me.Text = "Consulta de Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.barFacturaRepuesto.ResumeLayout(False)
        Me.barFacturaRepuesto.PerformLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.grdFacturaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFacturaDetalleTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFacturaMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFacturaMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barFacturaRepuesto As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents cmdProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregaDesdeCotizaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdFacturaDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdFacturaDetalleTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdFacturaMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdFacturaMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSolicitud As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescAutorizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAnulada As DevExpress.XtraGrid.Columns.GridColumn
End Class
