<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptOrdenCompraActive 
    Inherits DataDynamics.ActiveReports.ActiveReport3 

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents Encabezado_Pagina As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detalle As DataDynamics.ActiveReports.Detail
    Private WithEvents Pie_Pagina As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptOrdenCompraActive))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.txtobjRepuestoID = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidad = New DataDynamics.ActiveReports.TextBox
        Me.txtPrecio = New DataDynamics.ActiveReports.TextBox
        Me.txtSubtotal = New DataDynamics.ActiveReports.TextBox
        Me.txtDescripcion = New DataDynamics.ActiveReports.TextBox
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        Me.Encabezado_Ticket = New DataDynamics.ActiveReports.ReportHeader
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.lblOrdenCompra = New DataDynamics.ActiveReports.Label
        Me.txtCliente = New DataDynamics.ActiveReports.TextBox
        Me.lblCliente = New DataDynamics.ActiveReports.Label
        Me.lblCodigo = New DataDynamics.ActiveReports.Label
        Me.lblCantidad = New DataDynamics.ActiveReports.Label
        Me.lblSubTotal = New DataDynamics.ActiveReports.Label
        Me.txtOrdenCompra = New DataDynamics.ActiveReports.TextBox
        Me.lblPrecio = New DataDynamics.ActiveReports.Label
        Me.txtRUC = New DataDynamics.ActiveReports.TextBox
        Me.txtDireccionEmpresa = New DataDynamics.ActiveReports.TextBox
        Me.txtTelEmpresa = New DataDynamics.ActiveReports.TextBox
        Me.lineaDetalle = New DataDynamics.ActiveReports.Label
        Me.lblRUC = New DataDynamics.ActiveReports.Label
        Me.lblNumeroCompra = New DataDynamics.ActiveReports.Label
        Me.Pie_Ticket = New DataDynamics.ActiveReports.ReportFooter
        Me.lblSubTotal2 = New DataDynamics.ActiveReports.Label
        Me.lblDescuento = New DataDynamics.ActiveReports.Label
        Me.lblIVA = New DataDynamics.ActiveReports.Label
        Me.lblTotalCS = New DataDynamics.ActiveReports.Label
        Me.lblTotalS = New DataDynamics.ActiveReports.Label
        Me.lblTotalItems = New DataDynamics.ActiveReports.Label
        Me.lblTasaCambio = New DataDynamics.ActiveReports.Label
        Me.txtTasaCambio = New DataDynamics.ActiveReports.TextBox
        Me.txtSubTotal2 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescuento = New DataDynamics.ActiveReports.TextBox
        Me.txtIVA = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalCS = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalS = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalItems = New DataDynamics.ActiveReports.TextBox
        Me.lineaFinal = New DataDynamics.ActiveReports.Label
        Me.lineaTotales = New DataDynamics.ActiveReports.Label
        Me.txtEslogan = New DataDynamics.ActiveReports.TextBox
        Me.txtFechaHora = New DataDynamics.ActiveReports.TextBox
        Me.prmTasaCambio = New DataDynamics.ActiveReports.Parameter
        Me.prmSubTotalMaestro = New DataDynamics.ActiveReports.Parameter
        Me.prmEslogan = New DataDynamics.ActiveReports.Parameter
        Me.prmDescuentoMaestro = New DataDynamics.ActiveReports.Parameter
        Me.prmIVAMaestro = New DataDynamics.ActiveReports.Parameter
        Me.prmTotalCordobas = New DataDynamics.ActiveReports.Parameter
        Me.prmTotalDolares = New DataDynamics.ActiveReports.Parameter
        Me.prmCantItems = New DataDynamics.ActiveReports.Parameter
        Me.prmDireccionEmpresa = New DataDynamics.ActiveReports.Parameter
        Me.prmTelEmpresa = New DataDynamics.ActiveReports.Parameter
        Me.prmRUC = New DataDynamics.ActiveReports.Parameter
        Me.prmUsuarioFechaHora = New DataDynamics.ActiveReports.Parameter
        CType(Me.txtobjRepuestoID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRUC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccionEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRUC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNumeroCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSubTotal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTasaCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasaCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineaTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEslogan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Encabezado_Pagina
        '
        Me.Encabezado_Pagina.Height = 0.01041667!
        Me.Encabezado_Pagina.Name = "Encabezado_Pagina"
        '
        'Detalle
        '
        Me.Detalle.ColumnSpacing = 0.0!
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtobjRepuestoID, Me.txtCantidad, Me.txtPrecio, Me.txtSubtotal, Me.txtDescripcion})
        Me.Detalle.Height = 0.4166667!
        Me.Detalle.Name = "Detalle"
        '
        'txtobjRepuestoID
        '
        Me.txtobjRepuestoID.Border.BottomColor = System.Drawing.Color.Black
        Me.txtobjRepuestoID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtobjRepuestoID.Border.LeftColor = System.Drawing.Color.Black
        Me.txtobjRepuestoID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtobjRepuestoID.Border.RightColor = System.Drawing.Color.Black
        Me.txtobjRepuestoID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtobjRepuestoID.Border.TopColor = System.Drawing.Color.Black
        Me.txtobjRepuestoID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtobjRepuestoID.DataField = "objRepuestoID"
        Me.txtobjRepuestoID.Height = 0.1875!
        Me.txtobjRepuestoID.Left = 0.05208333!
        Me.txtobjRepuestoID.Name = "txtobjRepuestoID"
        Me.txtobjRepuestoID.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtobjRepuestoID.Text = "00"
        Me.txtobjRepuestoID.Top = 0.0!
        Me.txtobjRepuestoID.Width = 0.5625!
        '
        'txtCantidad
        '
        Me.txtCantidad.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCantidad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidad.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCantidad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidad.Border.RightColor = System.Drawing.Color.Black
        Me.txtCantidad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidad.Border.TopColor = System.Drawing.Color.Black
        Me.txtCantidad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidad.DataField = "Cantidad"
        Me.txtCantidad.Height = 0.1875!
        Me.txtCantidad.Left = 0.6145833!
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtCantidad.Text = "0"
        Me.txtCantidad.Top = 0.0!
        Me.txtCantidad.Width = 0.4375!
        '
        'txtPrecio
        '
        Me.txtPrecio.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPrecio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecio.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPrecio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecio.Border.RightColor = System.Drawing.Color.Black
        Me.txtPrecio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecio.Border.TopColor = System.Drawing.Color.Black
        Me.txtPrecio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecio.DataField = "Precio"
        Me.txtPrecio.Height = 0.1875!
        Me.txtPrecio.Left = 1.0625!
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtPrecio.Text = "0.00"
        Me.txtPrecio.Top = 0.0!
        Me.txtPrecio.Width = 0.625!
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubtotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubtotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubtotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubtotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubtotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubtotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubtotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubtotal.DataField = "Subtotal"
        Me.txtSubtotal.Height = 0.1875!
        Me.txtSubtotal.Left = 1.6875!
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtSubtotal.Text = "0.00"
        Me.txtSubtotal.Top = 0.0!
        Me.txtSubtotal.Width = 0.9375!
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescripcion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcion.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescripcion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcion.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescripcion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcion.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescripcion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcion.DataField = "Descripcion"
        Me.txtDescripcion.Height = 0.1875!
        Me.txtDescripcion.Left = 0.0625!
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Courier New; vertical-align: middle" & _
            "; "
        Me.txtDescripcion.Text = "Descripcion"
        Me.txtDescripcion.Top = 0.1875!
        Me.txtDescripcion.Width = 2.625!
        '
        'Pie_Pagina
        '
        Me.Pie_Pagina.Height = 0.01041667!
        Me.Pie_Pagina.Name = "Pie_Pagina"
        '
        'Encabezado_Ticket
        '
        Me.Encabezado_Ticket.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo, Me.lblOrdenCompra, Me.txtCliente, Me.lblCliente, Me.lblCodigo, Me.lblCantidad, Me.lblSubTotal, Me.txtOrdenCompra, Me.lblPrecio, Me.txtRUC, Me.txtDireccionEmpresa, Me.txtTelEmpresa, Me.lineaDetalle, Me.lblRUC, Me.lblNumeroCompra})
        Me.Encabezado_Ticket.Height = 2.03125!
        Me.Encabezado_Ticket.Name = "Encabezado_Ticket"
        '
        'lblTitulo
        '
        Me.lblTitulo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTitulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTitulo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTitulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTitulo.Border.RightColor = System.Drawing.Color.Black
        Me.lblTitulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTitulo.Border.TopColor = System.Drawing.Color.Black
        Me.lblTitulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTitulo.Height = 0.1875!
        Me.lblTitulo.HyperLink = Nothing
        Me.lblTitulo.Left = 0.0625!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.lblTitulo.Text = "Distribuidora de motos UM"
        Me.lblTitulo.Top = 0.0625!
        Me.lblTitulo.Width = 2.5625!
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Border.BottomColor = System.Drawing.Color.Black
        Me.lblOrdenCompra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblOrdenCompra.Border.LeftColor = System.Drawing.Color.Black
        Me.lblOrdenCompra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblOrdenCompra.Border.RightColor = System.Drawing.Color.Black
        Me.lblOrdenCompra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblOrdenCompra.Border.TopColor = System.Drawing.Color.Black
        Me.lblOrdenCompra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblOrdenCompra.Height = 0.25!
        Me.lblOrdenCompra.HyperLink = Nothing
        Me.lblOrdenCompra.Left = 0.0625!
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.lblOrdenCompra.Text = "ORDEN FACTURACIÓN"
        Me.lblOrdenCompra.Top = 1.0625!
        Me.lblOrdenCompra.Width = 2.5625!
        '
        'txtCliente
        '
        Me.txtCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.RightColor = System.Drawing.Color.Black
        Me.txtCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.TopColor = System.Drawing.Color.Black
        Me.txtCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.DataField = "Cliente"
        Me.txtCliente.Height = 0.1875!
        Me.txtCliente.Left = 0.75!
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtCliente.Text = "Cliente"
        Me.txtCliente.Top = 1.5!
        Me.txtCliente.Width = 1.8125!
        '
        'lblCliente
        '
        Me.lblCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCliente.Border.RightColor = System.Drawing.Color.Black
        Me.lblCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCliente.Border.TopColor = System.Drawing.Color.Black
        Me.lblCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCliente.Height = 0.1875!
        Me.lblCliente.HyperLink = Nothing
        Me.lblCliente.Left = 0.05208333!
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Courier New; vertical-align: middle" & _
            "; "
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.Top = 1.5!
        Me.lblCliente.Width = 0.6875!
        '
        'lblCodigo
        '
        Me.lblCodigo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCodigo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCodigo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigo.Border.RightColor = System.Drawing.Color.Black
        Me.lblCodigo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigo.Border.TopColor = System.Drawing.Color.Black
        Me.lblCodigo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigo.Height = 0.1875!
        Me.lblCodigo.HyperLink = Nothing
        Me.lblCodigo.Left = 0.05208333!
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Courier New; vert" & _
            "ical-align: middle; "
        Me.lblCodigo.Text = "Codigo   "
        Me.lblCodigo.Top = 1.6875!
        Me.lblCodigo.Width = 0.5625!
        '
        'lblCantidad
        '
        Me.lblCantidad.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCantidad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidad.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCantidad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidad.Border.RightColor = System.Drawing.Color.Black
        Me.lblCantidad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidad.Border.TopColor = System.Drawing.Color.Black
        Me.lblCantidad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidad.Height = 0.1875!
        Me.lblCantidad.HyperLink = Nothing
        Me.lblCantidad.Left = 0.6145833!
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.lblCantidad.Text = "Cant   "
        Me.lblCantidad.Top = 1.6875!
        Me.lblCantidad.Width = 0.4375!
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSubTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSubTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTotal.Border.RightColor = System.Drawing.Color.Black
        Me.lblSubTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTotal.Border.TopColor = System.Drawing.Color.Black
        Me.lblSubTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTotal.Height = 0.1875!
        Me.lblSubTotal.HyperLink = Nothing
        Me.lblSubTotal.Left = 1.6875!
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.lblSubTotal.Text = "Sub Total"
        Me.lblSubTotal.Top = 1.6875!
        Me.lblSubTotal.Width = 0.9375!
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Border.BottomColor = System.Drawing.Color.Black
        Me.txtOrdenCompra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtOrdenCompra.Border.LeftColor = System.Drawing.Color.Black
        Me.txtOrdenCompra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtOrdenCompra.Border.RightColor = System.Drawing.Color.Black
        Me.txtOrdenCompra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtOrdenCompra.Border.TopColor = System.Drawing.Color.Black
        Me.txtOrdenCompra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtOrdenCompra.DataField = "OrdenCompra"
        Me.txtOrdenCompra.Height = 0.1875!
        Me.txtOrdenCompra.Left = 1.8125!
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Courier New; vert" & _
            "ical-align: middle; "
        Me.txtOrdenCompra.Text = "OrdenCompra"
        Me.txtOrdenCompra.Top = 1.3125!
        Me.txtOrdenCompra.Width = 0.875!
        '
        'lblPrecio
        '
        Me.lblPrecio.Border.BottomColor = System.Drawing.Color.Black
        Me.lblPrecio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPrecio.Border.LeftColor = System.Drawing.Color.Black
        Me.lblPrecio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPrecio.Border.RightColor = System.Drawing.Color.Black
        Me.lblPrecio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPrecio.Border.TopColor = System.Drawing.Color.Black
        Me.lblPrecio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPrecio.Height = 0.1875!
        Me.lblPrecio.HyperLink = Nothing
        Me.lblPrecio.Left = 1.0625!
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.lblPrecio.Text = "Precio"
        Me.lblPrecio.Top = 1.6875!
        Me.lblPrecio.Width = 0.625!
        '
        'txtRUC
        '
        Me.txtRUC.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRUC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRUC.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRUC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRUC.Border.RightColor = System.Drawing.Color.Black
        Me.txtRUC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRUC.Border.TopColor = System.Drawing.Color.Black
        Me.txtRUC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRUC.DataField = "param:prmRUC"
        Me.txtRUC.Height = 0.1875!
        Me.txtRUC.Left = 1.0625!
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Courier New; vert" & _
            "ical-align: middle; "
        Me.txtRUC.Text = "RUC"
        Me.txtRUC.Top = 0.25!
        Me.txtRUC.Width = 1.5625!
        '
        'txtDireccionEmpresa
        '
        Me.txtDireccionEmpresa.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDireccionEmpresa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDireccionEmpresa.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDireccionEmpresa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDireccionEmpresa.Border.RightColor = System.Drawing.Color.Black
        Me.txtDireccionEmpresa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDireccionEmpresa.Border.TopColor = System.Drawing.Color.Black
        Me.txtDireccionEmpresa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDireccionEmpresa.DataField = "param:prmDireccionEmpresa"
        Me.txtDireccionEmpresa.Height = 0.375!
        Me.txtDireccionEmpresa.Left = 0.0625!
        Me.txtDireccionEmpresa.Name = "txtDireccionEmpresa"
        Me.txtDireccionEmpresa.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtDireccionEmpresa.Text = "Dirección Empresa"
        Me.txtDireccionEmpresa.Top = 0.4375!
        Me.txtDireccionEmpresa.Width = 2.5625!
        '
        'txtTelEmpresa
        '
        Me.txtTelEmpresa.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTelEmpresa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTelEmpresa.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTelEmpresa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTelEmpresa.Border.RightColor = System.Drawing.Color.Black
        Me.txtTelEmpresa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTelEmpresa.Border.TopColor = System.Drawing.Color.Black
        Me.txtTelEmpresa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTelEmpresa.DataField = "param:prmTelEmpresa"
        Me.txtTelEmpresa.Height = 0.1875!
        Me.txtTelEmpresa.Left = 0.0625!
        Me.txtTelEmpresa.Name = "txtTelEmpresa"
        Me.txtTelEmpresa.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtTelEmpresa.Text = "Teléfono Empresa"
        Me.txtTelEmpresa.Top = 0.8125!
        Me.txtTelEmpresa.Width = 2.5625!
        '
        'lineaDetalle
        '
        Me.lineaDetalle.Border.BottomColor = System.Drawing.Color.Black
        Me.lineaDetalle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaDetalle.Border.LeftColor = System.Drawing.Color.Black
        Me.lineaDetalle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaDetalle.Border.RightColor = System.Drawing.Color.Black
        Me.lineaDetalle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaDetalle.Border.TopColor = System.Drawing.Color.Black
        Me.lineaDetalle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaDetalle.Height = 0.125!
        Me.lineaDetalle.HyperLink = Nothing
        Me.lineaDetalle.Left = 0.0625!
        Me.lineaDetalle.Name = "lineaDetalle"
        Me.lineaDetalle.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; "
        Me.lineaDetalle.Text = ".............................."
        Me.lineaDetalle.Top = 1.875!
        Me.lineaDetalle.Width = 2.625!
        '
        'lblRUC
        '
        Me.lblRUC.Border.BottomColor = System.Drawing.Color.Black
        Me.lblRUC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRUC.Border.LeftColor = System.Drawing.Color.Black
        Me.lblRUC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRUC.Border.RightColor = System.Drawing.Color.Black
        Me.lblRUC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRUC.Border.TopColor = System.Drawing.Color.Black
        Me.lblRUC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRUC.Height = 0.1875!
        Me.lblRUC.HyperLink = Nothing
        Me.lblRUC.Left = 0.6458333!
        Me.lblRUC.Name = "lblRUC"
        Me.lblRUC.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Courier New; "
        Me.lblRUC.Text = "RUC:"
        Me.lblRUC.Top = 0.25!
        Me.lblRUC.Width = 0.375!
        '
        'lblNumeroCompra
        '
        Me.lblNumeroCompra.Border.BottomColor = System.Drawing.Color.Black
        Me.lblNumeroCompra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNumeroCompra.Border.LeftColor = System.Drawing.Color.Black
        Me.lblNumeroCompra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNumeroCompra.Border.RightColor = System.Drawing.Color.Black
        Me.lblNumeroCompra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNumeroCompra.Border.TopColor = System.Drawing.Color.Black
        Me.lblNumeroCompra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNumeroCompra.Height = 0.1875!
        Me.lblNumeroCompra.HyperLink = Nothing
        Me.lblNumeroCompra.Left = 1.4375!
        Me.lblNumeroCompra.Name = "lblNumeroCompra"
        Me.lblNumeroCompra.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; "
        Me.lblNumeroCompra.Text = "No."
        Me.lblNumeroCompra.Top = 1.3125!
        Me.lblNumeroCompra.Width = 0.375!
        '
        'Pie_Ticket
        '
        Me.Pie_Ticket.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblSubTotal2, Me.lblDescuento, Me.lblIVA, Me.lblTotalCS, Me.lblTotalS, Me.lblTotalItems, Me.lblTasaCambio, Me.txtTasaCambio, Me.txtSubTotal2, Me.txtDescuento, Me.txtIVA, Me.txtTotalCS, Me.txtTotalS, Me.txtTotalItems, Me.lineaFinal, Me.lineaTotales, Me.txtEslogan, Me.txtFechaHora})
        Me.Pie_Ticket.Height = 2.479167!
        Me.Pie_Ticket.Name = "Pie_Ticket"
        '
        'lblSubTotal2
        '
        Me.lblSubTotal2.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSubTotal2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTotal2.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSubTotal2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTotal2.Border.RightColor = System.Drawing.Color.Black
        Me.lblSubTotal2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTotal2.Border.TopColor = System.Drawing.Color.Black
        Me.lblSubTotal2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTotal2.Height = 0.1875!
        Me.lblSubTotal2.HyperLink = Nothing
        Me.lblSubTotal2.Left = 0.625!
        Me.lblSubTotal2.Name = "lblSubTotal2"
        Me.lblSubTotal2.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; "
        Me.lblSubTotal2.Text = "SubTotal:"
        Me.lblSubTotal2.Top = 0.1875!
        Me.lblSubTotal2.Width = 0.875!
        '
        'lblDescuento
        '
        Me.lblDescuento.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDescuento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDescuento.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDescuento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDescuento.Border.RightColor = System.Drawing.Color.Black
        Me.lblDescuento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDescuento.Border.TopColor = System.Drawing.Color.Black
        Me.lblDescuento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDescuento.Height = 0.1875!
        Me.lblDescuento.HyperLink = Nothing
        Me.lblDescuento.Left = 0.625!
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; "
        Me.lblDescuento.Text = "Desc:"
        Me.lblDescuento.Top = 0.3958333!
        Me.lblDescuento.Width = 0.875!
        '
        'lblIVA
        '
        Me.lblIVA.Border.BottomColor = System.Drawing.Color.Black
        Me.lblIVA.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblIVA.Border.LeftColor = System.Drawing.Color.Black
        Me.lblIVA.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblIVA.Border.RightColor = System.Drawing.Color.Black
        Me.lblIVA.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblIVA.Border.TopColor = System.Drawing.Color.Black
        Me.lblIVA.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblIVA.Height = 0.1875!
        Me.lblIVA.HyperLink = Nothing
        Me.lblIVA.Left = 0.625!
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; "
        Me.lblIVA.Text = "IVA:"
        Me.lblIVA.Top = 0.6041667!
        Me.lblIVA.Width = 0.875!
        '
        'lblTotalCS
        '
        Me.lblTotalCS.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTotalCS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalCS.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTotalCS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalCS.Border.RightColor = System.Drawing.Color.Black
        Me.lblTotalCS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalCS.Border.TopColor = System.Drawing.Color.Black
        Me.lblTotalCS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalCS.Height = 0.1875!
        Me.lblTotalCS.HyperLink = Nothing
        Me.lblTotalCS.Left = 0.625!
        Me.lblTotalCS.Name = "lblTotalCS"
        Me.lblTotalCS.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; "
        Me.lblTotalCS.Text = "Total C$:"
        Me.lblTotalCS.Top = 0.8125!
        Me.lblTotalCS.Width = 0.875!
        '
        'lblTotalS
        '
        Me.lblTotalS.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTotalS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalS.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTotalS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalS.Border.RightColor = System.Drawing.Color.Black
        Me.lblTotalS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalS.Border.TopColor = System.Drawing.Color.Black
        Me.lblTotalS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalS.Height = 0.1875!
        Me.lblTotalS.HyperLink = Nothing
        Me.lblTotalS.Left = 0.625!
        Me.lblTotalS.Name = "lblTotalS"
        Me.lblTotalS.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; "
        Me.lblTotalS.Text = "Total $:"
        Me.lblTotalS.Top = 1.020833!
        Me.lblTotalS.Width = 0.875!
        '
        'lblTotalItems
        '
        Me.lblTotalItems.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTotalItems.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalItems.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTotalItems.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalItems.Border.RightColor = System.Drawing.Color.Black
        Me.lblTotalItems.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalItems.Border.TopColor = System.Drawing.Color.Black
        Me.lblTotalItems.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalItems.Height = 0.1875!
        Me.lblTotalItems.HyperLink = Nothing
        Me.lblTotalItems.Left = 0.0625!
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Courier New; "
        Me.lblTotalItems.Text = "Total Items:"
        Me.lblTotalItems.Top = 1.520833!
        Me.lblTotalItems.Width = 0.9375!
        '
        'lblTasaCambio
        '
        Me.lblTasaCambio.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTasaCambio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTasaCambio.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTasaCambio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTasaCambio.Border.RightColor = System.Drawing.Color.Black
        Me.lblTasaCambio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTasaCambio.Border.TopColor = System.Drawing.Color.Black
        Me.lblTasaCambio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTasaCambio.Height = 0.1875!
        Me.lblTasaCambio.HyperLink = Nothing
        Me.lblTasaCambio.Left = 0.07291666!
        Me.lblTasaCambio.Name = "lblTasaCambio"
        Me.lblTasaCambio.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Courier New; "
        Me.lblTasaCambio.Text = "TC:"
        Me.lblTasaCambio.Top = 1.270833!
        Me.lblTasaCambio.Width = 0.3125!
        '
        'txtTasaCambio
        '
        Me.txtTasaCambio.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTasaCambio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTasaCambio.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTasaCambio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTasaCambio.Border.RightColor = System.Drawing.Color.Black
        Me.txtTasaCambio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTasaCambio.Border.TopColor = System.Drawing.Color.Black
        Me.txtTasaCambio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTasaCambio.DataField = "param:prmTasaCambio"
        Me.txtTasaCambio.Height = 0.1875!
        Me.txtTasaCambio.Left = 0.40625!
        Me.txtTasaCambio.Name = "txtTasaCambio"
        Me.txtTasaCambio.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Courier New; "
        Me.txtTasaCambio.Text = Nothing
        Me.txtTasaCambio.Top = 1.270833!
        Me.txtTasaCambio.Width = 0.5625!
        '
        'txtSubTotal2
        '
        Me.txtSubTotal2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubTotal2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubTotal2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubTotal2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubTotal2.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubTotal2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubTotal2.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubTotal2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubTotal2.DataField = "param:prmSubTotalMaestro"
        Me.txtSubTotal2.Height = 0.1875!
        Me.txtSubTotal2.Left = 1.5625!
        Me.txtSubTotal2.Name = "txtSubTotal2"
        Me.txtSubTotal2.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; ver" & _
            "tical-align: middle; "
        Me.txtSubTotal2.Text = "0.00"
        Me.txtSubTotal2.Top = 0.1875!
        Me.txtSubTotal2.Width = 0.875!
        '
        'txtDescuento
        '
        Me.txtDescuento.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescuento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescuento.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescuento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescuento.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescuento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescuento.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescuento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescuento.DataField = "param:prmDescuentoMaestro"
        Me.txtDescuento.Height = 0.1875!
        Me.txtDescuento.Left = 1.5625!
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; ver" & _
            "tical-align: middle; "
        Me.txtDescuento.Text = "0.00"
        Me.txtDescuento.Top = 0.3958333!
        Me.txtDescuento.Width = 0.875!
        '
        'txtIVA
        '
        Me.txtIVA.Border.BottomColor = System.Drawing.Color.Black
        Me.txtIVA.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtIVA.Border.LeftColor = System.Drawing.Color.Black
        Me.txtIVA.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtIVA.Border.RightColor = System.Drawing.Color.Black
        Me.txtIVA.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtIVA.Border.TopColor = System.Drawing.Color.Black
        Me.txtIVA.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtIVA.DataField = "param:prmIVAMaestro"
        Me.txtIVA.Height = 0.1875!
        Me.txtIVA.Left = 1.5625!
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; ver" & _
            "tical-align: middle; "
        Me.txtIVA.Text = "0.00"
        Me.txtIVA.Top = 0.6041667!
        Me.txtIVA.Width = 0.875!
        '
        'txtTotalCS
        '
        Me.txtTotalCS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalCS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalCS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCS.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalCS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCS.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalCS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCS.DataField = "param:prmTotalCordobas"
        Me.txtTotalCS.Height = 0.1875!
        Me.txtTotalCS.Left = 1.5625!
        Me.txtTotalCS.Name = "txtTotalCS"
        Me.txtTotalCS.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; ver" & _
            "tical-align: middle; "
        Me.txtTotalCS.Text = "0.00"
        Me.txtTotalCS.Top = 0.8125!
        Me.txtTotalCS.Width = 0.875!
        '
        'txtTotalS
        '
        Me.txtTotalS.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalS.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalS.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalS.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalS.DataField = "param:prmTotalDolares"
        Me.txtTotalS.Height = 0.1875!
        Me.txtTotalS.Left = 1.5625!
        Me.txtTotalS.Name = "txtTotalS"
        Me.txtTotalS.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Courier New; ver" & _
            "tical-align: middle; "
        Me.txtTotalS.Text = "0.00"
        Me.txtTotalS.Top = 1.020833!
        Me.txtTotalS.Width = 0.875!
        '
        'txtTotalItems
        '
        Me.txtTotalItems.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalItems.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalItems.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalItems.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalItems.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalItems.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalItems.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalItems.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalItems.DataField = "param:prmCantItems"
        Me.txtTotalItems.Height = 0.1875!
        Me.txtTotalItems.Left = 1.03125!
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtTotalItems.Text = "0"
        Me.txtTotalItems.Top = 1.520833!
        Me.txtTotalItems.Width = 0.6875!
        '
        'lineaFinal
        '
        Me.lineaFinal.Border.BottomColor = System.Drawing.Color.Black
        Me.lineaFinal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaFinal.Border.LeftColor = System.Drawing.Color.Black
        Me.lineaFinal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaFinal.Border.RightColor = System.Drawing.Color.Black
        Me.lineaFinal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaFinal.Border.TopColor = System.Drawing.Color.Black
        Me.lineaFinal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaFinal.Height = 0.1875!
        Me.lineaFinal.HyperLink = Nothing
        Me.lineaFinal.Left = 0.0625!
        Me.lineaFinal.Name = "lineaFinal"
        Me.lineaFinal.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; "
        Me.lineaFinal.Text = ".............................."
        Me.lineaFinal.Top = 2.25!
        Me.lineaFinal.Width = 2.625!
        '
        'lineaTotales
        '
        Me.lineaTotales.Border.BottomColor = System.Drawing.Color.Black
        Me.lineaTotales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaTotales.Border.LeftColor = System.Drawing.Color.Black
        Me.lineaTotales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaTotales.Border.RightColor = System.Drawing.Color.Black
        Me.lineaTotales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaTotales.Border.TopColor = System.Drawing.Color.Black
        Me.lineaTotales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lineaTotales.Height = 0.125!
        Me.lineaTotales.HyperLink = Nothing
        Me.lineaTotales.Left = 0.0!
        Me.lineaTotales.Name = "lineaTotales"
        Me.lineaTotales.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; "
        Me.lineaTotales.Text = ".............................."
        Me.lineaTotales.Top = 0.0!
        Me.lineaTotales.Width = 2.6875!
        '
        'txtEslogan
        '
        Me.txtEslogan.Border.BottomColor = System.Drawing.Color.Black
        Me.txtEslogan.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEslogan.Border.LeftColor = System.Drawing.Color.Black
        Me.txtEslogan.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEslogan.Border.RightColor = System.Drawing.Color.Black
        Me.txtEslogan.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEslogan.Border.TopColor = System.Drawing.Color.Black
        Me.txtEslogan.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEslogan.DataField = "param:prmEslogan"
        Me.txtEslogan.Height = 0.1875!
        Me.txtEslogan.Left = 0.25!
        Me.txtEslogan.Name = "txtEslogan"
        Me.txtEslogan.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Courier New; ve" & _
            "rtical-align: middle; "
        Me.txtEslogan.Text = "ESLOGAN!!!"
        Me.txtEslogan.Top = 2.0625!
        Me.txtEslogan.Width = 2.25!
        '
        'txtFechaHora
        '
        Me.txtFechaHora.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFechaHora.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaHora.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFechaHora.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaHora.Border.RightColor = System.Drawing.Color.Black
        Me.txtFechaHora.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaHora.Border.TopColor = System.Drawing.Color.Black
        Me.txtFechaHora.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaHora.DataField = "param:prmUsuarioFechaHora"
        Me.txtFechaHora.Height = 0.1875!
        Me.txtFechaHora.Left = 0.09375!
        Me.txtFechaHora.Name = "txtFechaHora"
        Me.txtFechaHora.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Courier New; vert" & _
            "ical-align: middle; "
        Me.txtFechaHora.Text = "0"
        Me.txtFechaHora.Top = 1.75!
        Me.txtFechaHora.Width = 2.25!
        '
        'prmTasaCambio
        '
        Me.prmTasaCambio.DefaultValue = ""
        Me.prmTasaCambio.Key = "prmTasaCambio"
        Me.prmTasaCambio.Prompt = Nothing
        Me.prmTasaCambio.PromptUser = False
        Me.prmTasaCambio.QueryCreated = False
        Me.prmTasaCambio.Tag = Nothing
        Me.prmTasaCambio.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmSubTotalMaestro
        '
        Me.prmSubTotalMaestro.DefaultValue = ""
        Me.prmSubTotalMaestro.Key = "prmSubTotalMaestro"
        Me.prmSubTotalMaestro.Prompt = Nothing
        Me.prmSubTotalMaestro.PromptUser = False
        Me.prmSubTotalMaestro.QueryCreated = False
        Me.prmSubTotalMaestro.Tag = Nothing
        Me.prmSubTotalMaestro.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmEslogan
        '
        Me.prmEslogan.DefaultValue = ""
        Me.prmEslogan.Key = "prmEslogan"
        Me.prmEslogan.Prompt = Nothing
        Me.prmEslogan.PromptUser = False
        Me.prmEslogan.QueryCreated = False
        Me.prmEslogan.Tag = Nothing
        Me.prmEslogan.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmDescuentoMaestro
        '
        Me.prmDescuentoMaestro.DefaultValue = ""
        Me.prmDescuentoMaestro.Key = "prmDescuentoMaestro"
        Me.prmDescuentoMaestro.Prompt = Nothing
        Me.prmDescuentoMaestro.PromptUser = False
        Me.prmDescuentoMaestro.QueryCreated = False
        Me.prmDescuentoMaestro.Tag = Nothing
        Me.prmDescuentoMaestro.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmIVAMaestro
        '
        Me.prmIVAMaestro.DefaultValue = ""
        Me.prmIVAMaestro.Key = "prmIVAMaestro"
        Me.prmIVAMaestro.Prompt = Nothing
        Me.prmIVAMaestro.PromptUser = False
        Me.prmIVAMaestro.QueryCreated = False
        Me.prmIVAMaestro.Tag = Nothing
        Me.prmIVAMaestro.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmTotalCordobas
        '
        Me.prmTotalCordobas.DefaultValue = ""
        Me.prmTotalCordobas.Key = "prmTotalCordobas"
        Me.prmTotalCordobas.Prompt = Nothing
        Me.prmTotalCordobas.PromptUser = False
        Me.prmTotalCordobas.QueryCreated = False
        Me.prmTotalCordobas.Tag = Nothing
        Me.prmTotalCordobas.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmTotalDolares
        '
        Me.prmTotalDolares.DefaultValue = ""
        Me.prmTotalDolares.Key = "prmTotalDolares"
        Me.prmTotalDolares.Prompt = Nothing
        Me.prmTotalDolares.PromptUser = False
        Me.prmTotalDolares.QueryCreated = False
        Me.prmTotalDolares.Tag = Nothing
        Me.prmTotalDolares.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmCantItems
        '
        Me.prmCantItems.DefaultValue = ""
        Me.prmCantItems.Key = "prmCantItems"
        Me.prmCantItems.Prompt = Nothing
        Me.prmCantItems.PromptUser = False
        Me.prmCantItems.QueryCreated = False
        Me.prmCantItems.Tag = Nothing
        Me.prmCantItems.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmDireccionEmpresa
        '
        Me.prmDireccionEmpresa.DefaultValue = ""
        Me.prmDireccionEmpresa.Key = "prmDireccionEmpresa"
        Me.prmDireccionEmpresa.Prompt = Nothing
        Me.prmDireccionEmpresa.PromptUser = False
        Me.prmDireccionEmpresa.QueryCreated = False
        Me.prmDireccionEmpresa.Tag = Nothing
        Me.prmDireccionEmpresa.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmTelEmpresa
        '
        Me.prmTelEmpresa.DefaultValue = ""
        Me.prmTelEmpresa.Key = "prmTelEmpresa"
        Me.prmTelEmpresa.Prompt = Nothing
        Me.prmTelEmpresa.PromptUser = False
        Me.prmTelEmpresa.QueryCreated = False
        Me.prmTelEmpresa.Tag = Nothing
        Me.prmTelEmpresa.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmRUC
        '
        Me.prmRUC.DefaultValue = ""
        Me.prmRUC.Key = "prmRUC"
        Me.prmRUC.Prompt = Nothing
        Me.prmRUC.PromptUser = False
        Me.prmRUC.QueryCreated = False
        Me.prmRUC.Tag = Nothing
        Me.prmRUC.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'prmUsuarioFechaHora
        '
        Me.prmUsuarioFechaHora.DefaultValue = ""
        Me.prmUsuarioFechaHora.Key = "prmUsuarioFechaHora"
        Me.prmUsuarioFechaHora.Prompt = Nothing
        Me.prmUsuarioFechaHora.PromptUser = False
        Me.prmUsuarioFechaHora.QueryCreated = False
        Me.prmUsuarioFechaHora.Tag = Nothing
        Me.prmUsuarioFechaHora.Type = DataDynamics.ActiveReports.Parameter.DataType.[String]
        '
        'rptOrdenCompraActive
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Ca" & _
            "talog=SIFUM;Data Source=DESARROLLO11"
        OleDBDataSource1.SQL = "Select * from vwRptOrdenCompra"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.1!
        Me.PageSettings.Margins.Left = 0.2!
        Me.PageSettings.Margins.Right = 0.05!
        Me.PageSettings.Margins.Top = 0.1!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.Parameters.Add(Me.prmTasaCambio)
        Me.Parameters.Add(Me.prmSubTotalMaestro)
        Me.Parameters.Add(Me.prmEslogan)
        Me.Parameters.Add(Me.prmDescuentoMaestro)
        Me.Parameters.Add(Me.prmIVAMaestro)
        Me.Parameters.Add(Me.prmTotalCordobas)
        Me.Parameters.Add(Me.prmTotalDolares)
        Me.Parameters.Add(Me.prmCantItems)
        Me.Parameters.Add(Me.prmDireccionEmpresa)
        Me.Parameters.Add(Me.prmTelEmpresa)
        Me.Parameters.Add(Me.prmRUC)
        Me.Parameters.Add(Me.prmUsuarioFechaHora)
        Me.PrintWidth = 2.854166!
        Me.Sections.Add(Me.Encabezado_Ticket)
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_Pagina)
        Me.Sections.Add(Me.Pie_Ticket)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtobjRepuestoID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRUC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccionEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRUC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNumeroCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSubTotal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTasaCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasaCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineaTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEslogan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtobjRepuestoID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidad As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrecio As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSubtotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Encabezado_Ticket As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Pie_Ticket As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents lblSubTotal2 As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDescuento As DataDynamics.ActiveReports.Label
    Friend WithEvents lblIVA As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTotalCS As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTotalS As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTotalItems As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTasaCambio As DataDynamics.ActiveReports.Label
    Friend WithEvents txtDescripcion As DataDynamics.ActiveReports.TextBox
    Friend WithEvents prmTasaCambio As DataDynamics.ActiveReports.Parameter
    Friend WithEvents txtTasaCambio As DataDynamics.ActiveReports.TextBox
    Friend WithEvents prmSubTotalMaestro As DataDynamics.ActiveReports.Parameter
    Friend WithEvents prmEslogan As DataDynamics.ActiveReports.Parameter
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblOrdenCompra As DataDynamics.ActiveReports.Label
    Friend WithEvents txtCliente As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblCliente As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCodigo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCantidad As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSubTotal As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSubTotal2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescuento As DataDynamics.ActiveReports.TextBox
    Friend WithEvents prmDescuentoMaestro As DataDynamics.ActiveReports.Parameter
    Friend WithEvents txtIVA As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalCS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalS As DataDynamics.ActiveReports.TextBox
    Friend WithEvents prmIVAMaestro As DataDynamics.ActiveReports.Parameter
    Friend WithEvents prmTotalCordobas As DataDynamics.ActiveReports.Parameter
    Friend WithEvents prmTotalDolares As DataDynamics.ActiveReports.Parameter
    Friend WithEvents txtTotalItems As DataDynamics.ActiveReports.TextBox
    Friend WithEvents prmCantItems As DataDynamics.ActiveReports.Parameter
    Friend WithEvents txtOrdenCompra As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblPrecio As DataDynamics.ActiveReports.Label
    Friend WithEvents lineaFinal As DataDynamics.ActiveReports.Label
    Friend WithEvents prmDireccionEmpresa As DataDynamics.ActiveReports.Parameter
    Friend WithEvents prmTelEmpresa As DataDynamics.ActiveReports.Parameter
    Friend WithEvents prmRUC As DataDynamics.ActiveReports.Parameter
    Friend WithEvents txtRUC As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDireccionEmpresa As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTelEmpresa As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lineaDetalle As DataDynamics.ActiveReports.Label
    Friend WithEvents lblRUC As DataDynamics.ActiveReports.Label
    Friend WithEvents lineaTotales As DataDynamics.ActiveReports.Label
    Friend WithEvents lblNumeroCompra As DataDynamics.ActiveReports.Label
    Friend WithEvents txtEslogan As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFechaHora As DataDynamics.ActiveReports.TextBox
    Friend WithEvents prmUsuarioFechaHora As DataDynamics.ActiveReports.Parameter
End Class
