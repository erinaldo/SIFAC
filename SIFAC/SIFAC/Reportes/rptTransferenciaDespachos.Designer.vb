<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptTransferenciaDespachos 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptTransferenciaDespachos))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.txtSivRepuestoID = New DataDynamics.ActiveReports.TextBox
        Me.txtDescripcionCorta = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidadSolicitada1 = New DataDynamics.ActiveReports.TextBox
        Me.lnLeft = New DataDynamics.ActiveReports.Line
        Me.lnDetalle4 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle1 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle2 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle3 = New DataDynamics.ActiveReports.Line
        Me.lnRight = New DataDynamics.ActiveReports.Line
        Me.txtCantidadDespachada1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCodigosProveedores1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Encabezado_Reporte = New DataDynamics.ActiveReports.ReportHeader
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.lblDesde = New DataDynamics.ActiveReports.Label
        Me.txtfechaDesde = New DataDynamics.ActiveReports.TextBox
        Me.lblHasta = New DataDynamics.ActiveReports.Label
        Me.txtFechaHasta = New DataDynamics.ActiveReports.TextBox
        Me.srptEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.Pie_Reporte = New DataDynamics.ActiveReports.ReportFooter
        Me.Encabezado_GrupoSitios = New DataDynamics.ActiveReports.GroupHeader
        Me.shpFondoEncabezadoSitios = New DataDynamics.ActiveReports.Shape
        Me.lblSitioOrigen = New DataDynamics.ActiveReports.Label
        Me.LblDestino = New DataDynamics.ActiveReports.Label
        Me.txtSitioOrigen = New DataDynamics.ActiveReports.TextBox
        Me.txtSitioDestino = New DataDynamics.ActiveReports.TextBox
        Me.txtCodigoTiendaOrigen = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.txtCodigoTiendaDestino1 = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Pie_GrupoSitios = New DataDynamics.ActiveReports.GroupFooter
        Me.Encabezado_GrupoDespachos = New DataDynamics.ActiveReports.GroupHeader
        Me.lblNumeroSolicitud = New DataDynamics.ActiveReports.Label
        Me.lblFechaDespacho = New DataDynamics.ActiveReports.Label
        Me.lblDespachoPor = New DataDynamics.ActiveReports.Label
        Me.lblAnulada = New DataDynamics.ActiveReports.Label
        Me.chkAnulada = New DataDynamics.ActiveReports.CheckBox
        Me.lblCodigoRepuesto = New DataDynamics.ActiveReports.Label
        Me.lblCodigoProveedor = New DataDynamics.ActiveReports.Label
        Me.lblDescripcion = New DataDynamics.ActiveReports.Label
        Me.lblCantidadSolicitada = New DataDynamics.ActiveReports.Label
        Me.txtSivTransferenciaID = New DataDynamics.ActiveReports.TextBox
        Me.lblCantidadDespachada = New DataDynamics.ActiveReports.Label
        Me.txtFechadespacho1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDespachadoPor1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_GrupoDespachos = New DataDynamics.ActiveReports.GroupFooter
        Me.lnPieDetalle = New DataDynamics.ActiveReports.Line
        Me.prmFechaDesde = New DataDynamics.ActiveReports.Parameter
        Me.prmFechaHasta = New DataDynamics.ActiveReports.Parameter
        CType(Me.txtSivRepuestoID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCorta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadSolicitada1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadDespachada1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigosProveedores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitioDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoTiendaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoTiendaDestino1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNumeroSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFechaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDespachoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAnulada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAnulada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidadSolicitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivTransferenciaID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidadDespachada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechadespacho1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDespachadoPor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Encabezado_Pagina
        '
        Me.Encabezado_Pagina.Height = 0.0!
        Me.Encabezado_Pagina.Name = "Encabezado_Pagina"
        '
        'Detalle
        '
        Me.Detalle.ColumnSpacing = 0.0!
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSivRepuestoID, Me.txtDescripcionCorta, Me.txtCantidadSolicitada1, Me.lnLeft, Me.lnDetalle4, Me.lnDetalle1, Me.lnDetalle2, Me.lnDetalle3, Me.lnRight, Me.txtCantidadDespachada1, Me.txtCodigosProveedores1})
        Me.Detalle.Height = 0.1875!
        Me.Detalle.Name = "Detalle"
        '
        'txtSivRepuestoID
        '
        Me.txtSivRepuestoID.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSivRepuestoID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivRepuestoID.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSivRepuestoID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivRepuestoID.Border.RightColor = System.Drawing.Color.Black
        Me.txtSivRepuestoID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivRepuestoID.Border.TopColor = System.Drawing.Color.Black
        Me.txtSivRepuestoID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivRepuestoID.DataField = "SivRepuestoID"
        Me.txtSivRepuestoID.Height = 0.1875!
        Me.txtSivRepuestoID.Left = 0.375!
        Me.txtSivRepuestoID.Name = "txtSivRepuestoID"
        Me.txtSivRepuestoID.Style = "color: DimGray; text-align: right; "
        Me.txtSivRepuestoID.Text = "txtSivRepuestoID1"
        Me.txtSivRepuestoID.Top = 0.0!
        Me.txtSivRepuestoID.Width = 0.6875!
        '
        'txtDescripcionCorta
        '
        Me.txtDescripcionCorta.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescripcionCorta.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcionCorta.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescripcionCorta.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcionCorta.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescripcionCorta.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcionCorta.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescripcionCorta.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcionCorta.DataField = "DescripcionCorta"
        Me.txtDescripcionCorta.Height = 0.1875!
        Me.txtDescripcionCorta.Left = 2.125!
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Style = "color: DimGray; "
        Me.txtDescripcionCorta.Text = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Top = 0.0!
        Me.txtDescripcionCorta.Width = 2.3125!
        '
        'txtCantidadSolicitada1
        '
        Me.txtCantidadSolicitada1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCantidadSolicitada1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadSolicitada1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCantidadSolicitada1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadSolicitada1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCantidadSolicitada1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadSolicitada1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCantidadSolicitada1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadSolicitada1.DataField = "CantidadSolicitada"
        Me.txtCantidadSolicitada1.Height = 0.1875!
        Me.txtCantidadSolicitada1.Left = 4.5625!
        Me.txtCantidadSolicitada1.Name = "txtCantidadSolicitada1"
        Me.txtCantidadSolicitada1.Style = "color: DimGray; text-align: right; "
        Me.txtCantidadSolicitada1.Text = "txtCantidadSolicitada1"
        Me.txtCantidadSolicitada1.Top = 0.0!
        Me.txtCantidadSolicitada1.Width = 1.0625!
        '
        'lnLeft
        '
        Me.lnLeft.AnchorBottom = True
        Me.lnLeft.Border.BottomColor = System.Drawing.Color.Black
        Me.lnLeft.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnLeft.Border.LeftColor = System.Drawing.Color.Black
        Me.lnLeft.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnLeft.Border.RightColor = System.Drawing.Color.Black
        Me.lnLeft.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnLeft.Border.TopColor = System.Drawing.Color.Black
        Me.lnLeft.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnLeft.Height = 0.1875!
        Me.lnLeft.Left = 0.3125!
        Me.lnLeft.LineColor = System.Drawing.Color.Silver
        Me.lnLeft.LineWeight = 1.0!
        Me.lnLeft.Name = "lnLeft"
        Me.lnLeft.Top = 0.0!
        Me.lnLeft.Width = 0.0!
        Me.lnLeft.X1 = 0.3125!
        Me.lnLeft.X2 = 0.3125!
        Me.lnLeft.Y1 = 0.0!
        Me.lnLeft.Y2 = 0.1875!
        '
        'lnDetalle4
        '
        Me.lnDetalle4.AnchorBottom = True
        Me.lnDetalle4.Border.BottomColor = System.Drawing.Color.Black
        Me.lnDetalle4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle4.Border.LeftColor = System.Drawing.Color.Black
        Me.lnDetalle4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle4.Border.RightColor = System.Drawing.Color.Black
        Me.lnDetalle4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle4.Border.TopColor = System.Drawing.Color.Black
        Me.lnDetalle4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle4.Height = 0.1875!
        Me.lnDetalle4.Left = 5.6875!
        Me.lnDetalle4.LineColor = System.Drawing.Color.Silver
        Me.lnDetalle4.LineWeight = 1.0!
        Me.lnDetalle4.Name = "lnDetalle4"
        Me.lnDetalle4.Top = 0.0!
        Me.lnDetalle4.Width = 0.0!
        Me.lnDetalle4.X1 = 5.6875!
        Me.lnDetalle4.X2 = 5.6875!
        Me.lnDetalle4.Y1 = 0.0!
        Me.lnDetalle4.Y2 = 0.1875!
        '
        'lnDetalle1
        '
        Me.lnDetalle1.AnchorBottom = True
        Me.lnDetalle1.Border.BottomColor = System.Drawing.Color.Black
        Me.lnDetalle1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle1.Border.LeftColor = System.Drawing.Color.Black
        Me.lnDetalle1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle1.Border.RightColor = System.Drawing.Color.Black
        Me.lnDetalle1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle1.Border.TopColor = System.Drawing.Color.Black
        Me.lnDetalle1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle1.Height = 0.1875!
        Me.lnDetalle1.Left = 1.125!
        Me.lnDetalle1.LineColor = System.Drawing.Color.Silver
        Me.lnDetalle1.LineWeight = 1.0!
        Me.lnDetalle1.Name = "lnDetalle1"
        Me.lnDetalle1.Top = 0.0!
        Me.lnDetalle1.Width = 0.0!
        Me.lnDetalle1.X1 = 1.125!
        Me.lnDetalle1.X2 = 1.125!
        Me.lnDetalle1.Y1 = 0.0!
        Me.lnDetalle1.Y2 = 0.1875!
        '
        'lnDetalle2
        '
        Me.lnDetalle2.AnchorBottom = True
        Me.lnDetalle2.Border.BottomColor = System.Drawing.Color.Black
        Me.lnDetalle2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle2.Border.LeftColor = System.Drawing.Color.Black
        Me.lnDetalle2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle2.Border.RightColor = System.Drawing.Color.Black
        Me.lnDetalle2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle2.Border.TopColor = System.Drawing.Color.Black
        Me.lnDetalle2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle2.Height = 0.1875!
        Me.lnDetalle2.Left = 2.0625!
        Me.lnDetalle2.LineColor = System.Drawing.Color.Silver
        Me.lnDetalle2.LineWeight = 1.0!
        Me.lnDetalle2.Name = "lnDetalle2"
        Me.lnDetalle2.Top = 0.0!
        Me.lnDetalle2.Width = 0.0!
        Me.lnDetalle2.X1 = 2.0625!
        Me.lnDetalle2.X2 = 2.0625!
        Me.lnDetalle2.Y1 = 0.0!
        Me.lnDetalle2.Y2 = 0.1875!
        '
        'lnDetalle3
        '
        Me.lnDetalle3.AnchorBottom = True
        Me.lnDetalle3.Border.BottomColor = System.Drawing.Color.Black
        Me.lnDetalle3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle3.Border.LeftColor = System.Drawing.Color.Black
        Me.lnDetalle3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle3.Border.RightColor = System.Drawing.Color.Black
        Me.lnDetalle3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle3.Border.TopColor = System.Drawing.Color.Black
        Me.lnDetalle3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle3.Height = 0.1875!
        Me.lnDetalle3.Left = 4.5!
        Me.lnDetalle3.LineColor = System.Drawing.Color.Silver
        Me.lnDetalle3.LineWeight = 1.0!
        Me.lnDetalle3.Name = "lnDetalle3"
        Me.lnDetalle3.Top = 0.0!
        Me.lnDetalle3.Width = 0.0!
        Me.lnDetalle3.X1 = 4.5!
        Me.lnDetalle3.X2 = 4.5!
        Me.lnDetalle3.Y1 = 0.0!
        Me.lnDetalle3.Y2 = 0.1875!
        '
        'lnRight
        '
        Me.lnRight.AnchorBottom = True
        Me.lnRight.Border.BottomColor = System.Drawing.Color.Black
        Me.lnRight.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnRight.Border.LeftColor = System.Drawing.Color.Black
        Me.lnRight.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnRight.Border.RightColor = System.Drawing.Color.Black
        Me.lnRight.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnRight.Border.TopColor = System.Drawing.Color.Black
        Me.lnRight.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnRight.Height = 0.1875!
        Me.lnRight.Left = 7.0!
        Me.lnRight.LineColor = System.Drawing.Color.Silver
        Me.lnRight.LineWeight = 1.0!
        Me.lnRight.Name = "lnRight"
        Me.lnRight.Top = 0.0!
        Me.lnRight.Width = 0.0!
        Me.lnRight.X1 = 7.0!
        Me.lnRight.X2 = 7.0!
        Me.lnRight.Y1 = 0.0!
        Me.lnRight.Y2 = 0.1875!
        '
        'txtCantidadDespachada1
        '
        Me.txtCantidadDespachada1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCantidadDespachada1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadDespachada1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCantidadDespachada1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadDespachada1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCantidadDespachada1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadDespachada1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCantidadDespachada1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadDespachada1.DataField = "CantidadDespachada"
        Me.txtCantidadDespachada1.Height = 0.1875!
        Me.txtCantidadDespachada1.Left = 5.75!
        Me.txtCantidadDespachada1.Name = "txtCantidadDespachada1"
        Me.txtCantidadDespachada1.Style = "color: DimGray; text-align: right; "
        Me.txtCantidadDespachada1.Text = "txtCantidadDespachada1"
        Me.txtCantidadDespachada1.Top = 0.0!
        Me.txtCantidadDespachada1.Width = 1.1875!
        '
        'txtCodigosProveedores1
        '
        Me.txtCodigosProveedores1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigosProveedores1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigosProveedores1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigosProveedores1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigosProveedores1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigosProveedores1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigosProveedores1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigosProveedores1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigosProveedores1.DataField = "CodigosProveedores"
        Me.txtCodigosProveedores1.Height = 0.1875!
        Me.txtCodigosProveedores1.Left = 1.1875!
        Me.txtCodigosProveedores1.Name = "txtCodigosProveedores1"
        Me.txtCodigosProveedores1.Style = "color: DimGray; "
        Me.txtCodigosProveedores1.Text = "txtCodigosProveedores1"
        Me.txtCodigosProveedores1.Top = 0.0!
        Me.txtCodigosProveedores1.Width = 0.8125!
        '
        'Pie_Pagina
        '
        Me.Pie_Pagina.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
        Me.Pie_Pagina.Height = 0.1979167!
        Me.Pie_Pagina.Name = "Pie_Pagina"
        '
        'ReportInfo1
        '
        Me.ReportInfo1.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.FormatString = "Página {PageNumber} de {PageCount}"
        Me.ReportInfo1.Height = 0.1875!
        Me.ReportInfo1.Left = 5.0!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: Gray; ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 2.0!
        '
        'Encabezado_Reporte
        '
        Me.Encabezado_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo, Me.lblDesde, Me.txtfechaDesde, Me.lblHasta, Me.txtFechaHasta, Me.srptEncabezado})
        Me.Encabezado_Reporte.Height = 1.96875!
        Me.Encabezado_Reporte.Name = "Encabezado_Reporte"
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
        Me.lblTitulo.Height = 0.25!
        Me.lblTitulo.HyperLink = Nothing
        Me.lblTitulo.Left = 1.5625!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "color: SteelBlue; ddo-char-set: 1; text-align: center; font-weight: bold; font-si" & _
            "ze: 14.25pt; font-family: Times New Roman; vertical-align: middle; "
        Me.lblTitulo.Text = "DESPACHOS DE TRASLADOS"
        Me.lblTitulo.Top = 1.21875!
        Me.lblTitulo.Width = 3.75!
        '
        'lblDesde
        '
        Me.lblDesde.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDesde.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDesde.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDesde.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDesde.Border.RightColor = System.Drawing.Color.Black
        Me.lblDesde.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDesde.Border.TopColor = System.Drawing.Color.Black
        Me.lblDesde.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDesde.Height = 0.1875!
        Me.lblDesde.HyperLink = Nothing
        Me.lblDesde.Left = 2.177083!
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Style = "font-weight: bold; "
        Me.lblDesde.Text = "Desde:"
        Me.lblDesde.Top = 1.53125!
        Me.lblDesde.Width = 0.5!
        '
        'txtfechaDesde
        '
        Me.txtfechaDesde.Border.BottomColor = System.Drawing.Color.Black
        Me.txtfechaDesde.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtfechaDesde.Border.LeftColor = System.Drawing.Color.Black
        Me.txtfechaDesde.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtfechaDesde.Border.RightColor = System.Drawing.Color.Black
        Me.txtfechaDesde.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtfechaDesde.Border.TopColor = System.Drawing.Color.Black
        Me.txtfechaDesde.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtfechaDesde.Height = 0.1875!
        Me.txtfechaDesde.Left = 2.677083!
        Me.txtfechaDesde.Name = "txtfechaDesde"
        Me.txtfechaDesde.Style = ""
        Me.txtfechaDesde.Text = Nothing
        Me.txtfechaDesde.Top = 1.53125!
        Me.txtfechaDesde.Width = 1.0!
        '
        'lblHasta
        '
        Me.lblHasta.Border.BottomColor = System.Drawing.Color.Black
        Me.lblHasta.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHasta.Border.LeftColor = System.Drawing.Color.Black
        Me.lblHasta.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHasta.Border.RightColor = System.Drawing.Color.Black
        Me.lblHasta.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHasta.Border.TopColor = System.Drawing.Color.Black
        Me.lblHasta.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblHasta.Height = 0.1875!
        Me.lblHasta.HyperLink = Nothing
        Me.lblHasta.Left = 3.75!
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Style = "font-weight: bold; "
        Me.lblHasta.Text = "Hasta:"
        Me.lblHasta.Top = 1.53125!
        Me.lblHasta.Width = 0.5!
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFechaHasta.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaHasta.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFechaHasta.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaHasta.Border.RightColor = System.Drawing.Color.Black
        Me.txtFechaHasta.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaHasta.Border.TopColor = System.Drawing.Color.Black
        Me.txtFechaHasta.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaHasta.Height = 0.1875!
        Me.txtFechaHasta.Left = 4.25!
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Style = ""
        Me.txtFechaHasta.Text = Nothing
        Me.txtFechaHasta.Top = 1.53125!
        Me.txtFechaHasta.Width = 1.1875!
        '
        'srptEncabezado
        '
        Me.srptEncabezado.Border.BottomColor = System.Drawing.Color.Black
        Me.srptEncabezado.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptEncabezado.Border.LeftColor = System.Drawing.Color.Black
        Me.srptEncabezado.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptEncabezado.Border.RightColor = System.Drawing.Color.Black
        Me.srptEncabezado.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptEncabezado.Border.TopColor = System.Drawing.Color.Black
        Me.srptEncabezado.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptEncabezado.CloseBorder = False
        Me.srptEncabezado.Height = 1.125!
        Me.srptEncabezado.Left = 0.0!
        Me.srptEncabezado.Name = "srptEncabezado"
        Me.srptEncabezado.Report = Nothing
        Me.srptEncabezado.ReportName = "Encabezado"
        Me.srptEncabezado.Top = 0.0!
        Me.srptEncabezado.Width = 7.4!
        '
        'Pie_Reporte
        '
        Me.Pie_Reporte.Height = 0.0!
        Me.Pie_Reporte.Name = "Pie_Reporte"
        '
        'Encabezado_GrupoSitios
        '
        Me.Encabezado_GrupoSitios.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.shpFondoEncabezadoSitios, Me.lblSitioOrigen, Me.LblDestino, Me.txtSitioOrigen, Me.txtSitioDestino, Me.txtCodigoTiendaOrigen, Me.Line1, Me.txtCodigoTiendaDestino1, Me.Line2})
        Me.Encabezado_GrupoSitios.DataField = "ClaveSitios"
        Me.Encabezado_GrupoSitios.Height = 0.28125!
        Me.Encabezado_GrupoSitios.Name = "Encabezado_GrupoSitios"
        '
        'shpFondoEncabezadoSitios
        '
        Me.shpFondoEncabezadoSitios.BackColor = System.Drawing.Color.Gainsboro
        Me.shpFondoEncabezadoSitios.Border.BottomColor = System.Drawing.Color.Black
        Me.shpFondoEncabezadoSitios.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondoEncabezadoSitios.Border.LeftColor = System.Drawing.Color.Black
        Me.shpFondoEncabezadoSitios.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondoEncabezadoSitios.Border.RightColor = System.Drawing.Color.Black
        Me.shpFondoEncabezadoSitios.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondoEncabezadoSitios.Border.TopColor = System.Drawing.Color.Black
        Me.shpFondoEncabezadoSitios.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondoEncabezadoSitios.Height = 0.25!
        Me.shpFondoEncabezadoSitios.Left = 0.04166667!
        Me.shpFondoEncabezadoSitios.Name = "shpFondoEncabezadoSitios"
        Me.shpFondoEncabezadoSitios.RoundingRadius = 9.999999!
        Me.shpFondoEncabezadoSitios.Top = 0.0!
        Me.shpFondoEncabezadoSitios.Width = 7.0!
        '
        'lblSitioOrigen
        '
        Me.lblSitioOrigen.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSitioOrigen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSitioOrigen.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSitioOrigen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSitioOrigen.Border.RightColor = System.Drawing.Color.Black
        Me.lblSitioOrigen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSitioOrigen.Border.TopColor = System.Drawing.Color.Black
        Me.lblSitioOrigen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSitioOrigen.Height = 0.1875!
        Me.lblSitioOrigen.HyperLink = Nothing
        Me.lblSitioOrigen.Left = 0.1041667!
        Me.lblSitioOrigen.Name = "lblSitioOrigen"
        Me.lblSitioOrigen.Style = "text-decoration: underline; font-weight: bold; "
        Me.lblSitioOrigen.Text = "SITIO ORIGEN:"
        Me.lblSitioOrigen.Top = 0.03125!
        Me.lblSitioOrigen.Width = 1.0625!
        '
        'LblDestino
        '
        Me.LblDestino.Border.BottomColor = System.Drawing.Color.Black
        Me.LblDestino.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.LblDestino.Border.LeftColor = System.Drawing.Color.Black
        Me.LblDestino.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.LblDestino.Border.RightColor = System.Drawing.Color.Black
        Me.LblDestino.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.LblDestino.Border.TopColor = System.Drawing.Color.Black
        Me.LblDestino.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.LblDestino.Height = 0.1875!
        Me.LblDestino.HyperLink = Nothing
        Me.LblDestino.Left = 3.479167!
        Me.LblDestino.Name = "LblDestino"
        Me.LblDestino.Style = "text-decoration: underline; font-weight: bold; "
        Me.LblDestino.Text = "SITIO DESTINO:"
        Me.LblDestino.Top = 0.03125!
        Me.LblDestino.Width = 1.1875!
        '
        'txtSitioOrigen
        '
        Me.txtSitioOrigen.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSitioOrigen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioOrigen.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSitioOrigen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioOrigen.Border.RightColor = System.Drawing.Color.Black
        Me.txtSitioOrigen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioOrigen.Border.TopColor = System.Drawing.Color.Black
        Me.txtSitioOrigen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioOrigen.DataField = "SitioOrigen"
        Me.txtSitioOrigen.Height = 0.1875!
        Me.txtSitioOrigen.Left = 2.104167!
        Me.txtSitioOrigen.Name = "txtSitioOrigen"
        Me.txtSitioOrigen.Style = ""
        Me.txtSitioOrigen.Text = "txtSitioOrigen"
        Me.txtSitioOrigen.Top = 0.03125!
        Me.txtSitioOrigen.Width = 1.25!
        '
        'txtSitioDestino
        '
        Me.txtSitioDestino.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSitioDestino.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioDestino.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSitioDestino.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioDestino.Border.RightColor = System.Drawing.Color.Black
        Me.txtSitioDestino.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioDestino.Border.TopColor = System.Drawing.Color.Black
        Me.txtSitioDestino.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioDestino.DataField = "SitioDestino"
        Me.txtSitioDestino.Height = 0.1875!
        Me.txtSitioDestino.Left = 5.479167!
        Me.txtSitioDestino.Name = "txtSitioDestino"
        Me.txtSitioDestino.Style = ""
        Me.txtSitioDestino.Text = "txtSitioDestino"
        Me.txtSitioDestino.Top = 0.02083333!
        Me.txtSitioDestino.Width = 1.0625!
        '
        'txtCodigoTiendaOrigen
        '
        Me.txtCodigoTiendaOrigen.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoTiendaOrigen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTiendaOrigen.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoTiendaOrigen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTiendaOrigen.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoTiendaOrigen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTiendaOrigen.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoTiendaOrigen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTiendaOrigen.DataField = "CodigoTiendaOrigen"
        Me.txtCodigoTiendaOrigen.Height = 0.1875!
        Me.txtCodigoTiendaOrigen.Left = 1.104167!
        Me.txtCodigoTiendaOrigen.Name = "txtCodigoTiendaOrigen"
        Me.txtCodigoTiendaOrigen.Style = "text-align: right; vertical-align: middle; "
        Me.txtCodigoTiendaOrigen.Text = "txtCodigoTiendaOrigen"
        Me.txtCodigoTiendaOrigen.Top = 0.03125!
        Me.txtCodigoTiendaOrigen.Width = 0.6875!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 1.854167!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.125!
        Me.Line1.Width = 0.125!
        Me.Line1.X1 = 1.854167!
        Me.Line1.X2 = 1.979167!
        Me.Line1.Y1 = 0.125!
        Me.Line1.Y2 = 0.125!
        '
        'txtCodigoTiendaDestino1
        '
        Me.txtCodigoTiendaDestino1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoTiendaDestino1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTiendaDestino1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoTiendaDestino1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTiendaDestino1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoTiendaDestino1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTiendaDestino1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoTiendaDestino1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoTiendaDestino1.DataField = "CodigoTiendaDestino"
        Me.txtCodigoTiendaDestino1.Height = 0.1875!
        Me.txtCodigoTiendaDestino1.Left = 4.604167!
        Me.txtCodigoTiendaDestino1.Name = "txtCodigoTiendaDestino1"
        Me.txtCodigoTiendaDestino1.Style = "text-align: right; "
        Me.txtCodigoTiendaDestino1.Text = "txtCodigoTiendaDestino1"
        Me.txtCodigoTiendaDestino1.Top = 0.02083333!
        Me.txtCodigoTiendaDestino1.Width = 0.625!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 5.291667!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.125!
        Me.Line2.Width = 0.125!
        Me.Line2.X1 = 5.291667!
        Me.Line2.X2 = 5.416667!
        Me.Line2.Y1 = 0.125!
        Me.Line2.Y2 = 0.125!
        '
        'Pie_GrupoSitios
        '
        Me.Pie_GrupoSitios.Height = 0.0!
        Me.Pie_GrupoSitios.Name = "Pie_GrupoSitios"
        '
        'Encabezado_GrupoDespachos
        '
        Me.Encabezado_GrupoDespachos.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblNumeroSolicitud, Me.lblFechaDespacho, Me.lblDespachoPor, Me.lblAnulada, Me.chkAnulada, Me.lblCodigoRepuesto, Me.lblCodigoProveedor, Me.lblDescripcion, Me.lblCantidadSolicitada, Me.txtSivTransferenciaID, Me.lblCantidadDespachada, Me.txtFechadespacho1, Me.txtDespachadoPor1})
        Me.Encabezado_GrupoDespachos.DataField = "SivTransferenciaID"
        Me.Encabezado_GrupoDespachos.Height = 0.4479167!
        Me.Encabezado_GrupoDespachos.Name = "Encabezado_GrupoDespachos"
        '
        'lblNumeroSolicitud
        '
        Me.lblNumeroSolicitud.Border.BottomColor = System.Drawing.Color.Black
        Me.lblNumeroSolicitud.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNumeroSolicitud.Border.LeftColor = System.Drawing.Color.Black
        Me.lblNumeroSolicitud.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNumeroSolicitud.Border.RightColor = System.Drawing.Color.Black
        Me.lblNumeroSolicitud.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNumeroSolicitud.Border.TopColor = System.Drawing.Color.Black
        Me.lblNumeroSolicitud.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNumeroSolicitud.Height = 0.1875!
        Me.lblNumeroSolicitud.HyperLink = Nothing
        Me.lblNumeroSolicitud.Left = 0.25!
        Me.lblNumeroSolicitud.Name = "lblNumeroSolicitud"
        Me.lblNumeroSolicitud.Style = "font-weight: bold; "
        Me.lblNumeroSolicitud.Text = "Número:"
        Me.lblNumeroSolicitud.Top = 0.0!
        Me.lblNumeroSolicitud.Width = 0.6875!
        '
        'lblFechaDespacho
        '
        Me.lblFechaDespacho.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFechaDespacho.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaDespacho.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFechaDespacho.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaDespacho.Border.RightColor = System.Drawing.Color.Black
        Me.lblFechaDespacho.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaDespacho.Border.TopColor = System.Drawing.Color.Black
        Me.lblFechaDespacho.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaDespacho.Height = 0.1875!
        Me.lblFechaDespacho.HyperLink = Nothing
        Me.lblFechaDespacho.Left = 1.75!
        Me.lblFechaDespacho.Name = "lblFechaDespacho"
        Me.lblFechaDespacho.Style = ""
        Me.lblFechaDespacho.Text = "Fecha Desp:"
        Me.lblFechaDespacho.Top = 0.0!
        Me.lblFechaDespacho.Width = 0.875!
        '
        'lblDespachoPor
        '
        Me.lblDespachoPor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDespachoPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDespachoPor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDespachoPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDespachoPor.Border.RightColor = System.Drawing.Color.Black
        Me.lblDespachoPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDespachoPor.Border.TopColor = System.Drawing.Color.Black
        Me.lblDespachoPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDespachoPor.Height = 0.1875!
        Me.lblDespachoPor.HyperLink = Nothing
        Me.lblDespachoPor.Left = 3.625!
        Me.lblDespachoPor.Name = "lblDespachoPor"
        Me.lblDespachoPor.Style = ""
        Me.lblDespachoPor.Text = "Despachado por:"
        Me.lblDespachoPor.Top = 0.0!
        Me.lblDespachoPor.Width = 1.125!
        '
        'lblAnulada
        '
        Me.lblAnulada.Border.BottomColor = System.Drawing.Color.Black
        Me.lblAnulada.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnulada.Border.LeftColor = System.Drawing.Color.Black
        Me.lblAnulada.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnulada.Border.RightColor = System.Drawing.Color.Black
        Me.lblAnulada.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnulada.Border.TopColor = System.Drawing.Color.Black
        Me.lblAnulada.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblAnulada.Height = 0.1875!
        Me.lblAnulada.HyperLink = Nothing
        Me.lblAnulada.Left = 6.291667!
        Me.lblAnulada.Name = "lblAnulada"
        Me.lblAnulada.Style = ""
        Me.lblAnulada.Text = "Anulada"
        Me.lblAnulada.Top = 0.0!
        Me.lblAnulada.Width = 0.5625!
        '
        'chkAnulada
        '
        Me.chkAnulada.Border.BottomColor = System.Drawing.Color.Black
        Me.chkAnulada.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkAnulada.Border.LeftColor = System.Drawing.Color.Black
        Me.chkAnulada.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkAnulada.Border.RightColor = System.Drawing.Color.Black
        Me.chkAnulada.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkAnulada.Border.TopColor = System.Drawing.Color.Black
        Me.chkAnulada.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkAnulada.CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAnulada.DataField = "Anulada"
        Me.chkAnulada.Height = 0.1875!
        Me.chkAnulada.Left = 6.791667!
        Me.chkAnulada.Name = "chkAnulada"
        Me.chkAnulada.Style = ""
        Me.chkAnulada.Text = ""
        Me.chkAnulada.Top = 0.0!
        Me.chkAnulada.Width = 0.25!
        '
        'lblCodigoRepuesto
        '
        Me.lblCodigoRepuesto.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCodigoRepuesto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoRepuesto.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCodigoRepuesto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoRepuesto.Border.RightColor = System.Drawing.Color.Black
        Me.lblCodigoRepuesto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoRepuesto.Border.TopColor = System.Drawing.Color.Black
        Me.lblCodigoRepuesto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoRepuesto.Height = 0.1875!
        Me.lblCodigoRepuesto.HyperLink = Nothing
        Me.lblCodigoRepuesto.Left = 0.3125!
        Me.lblCodigoRepuesto.Name = "lblCodigoRepuesto"
        Me.lblCodigoRepuesto.Style = "text-align: center; font-size: 11pt; "
        Me.lblCodigoRepuesto.Text = "Código"
        Me.lblCodigoRepuesto.Top = 0.25!
        Me.lblCodigoRepuesto.Width = 0.8125!
        '
        'lblCodigoProveedor
        '
        Me.lblCodigoProveedor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCodigoProveedor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoProveedor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCodigoProveedor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoProveedor.Border.RightColor = System.Drawing.Color.Black
        Me.lblCodigoProveedor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoProveedor.Border.TopColor = System.Drawing.Color.Black
        Me.lblCodigoProveedor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoProveedor.Height = 0.1875!
        Me.lblCodigoProveedor.HyperLink = Nothing
        Me.lblCodigoProveedor.Left = 1.125!
        Me.lblCodigoProveedor.Name = "lblCodigoProveedor"
        Me.lblCodigoProveedor.Style = "text-align: center; font-size: 11pt; "
        Me.lblCodigoProveedor.Text = "Código Prov."
        Me.lblCodigoProveedor.Top = 0.25!
        Me.lblCodigoProveedor.Width = 0.9375!
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDescripcion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDescripcion.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDescripcion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDescripcion.Border.RightColor = System.Drawing.Color.Black
        Me.lblDescripcion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDescripcion.Border.TopColor = System.Drawing.Color.Black
        Me.lblDescripcion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDescripcion.Height = 0.1875!
        Me.lblDescripcion.HyperLink = Nothing
        Me.lblDescripcion.Left = 2.0625!
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Style = "text-align: center; font-size: 11pt; "
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.Top = 0.25!
        Me.lblDescripcion.Width = 2.4375!
        '
        'lblCantidadSolicitada
        '
        Me.lblCantidadSolicitada.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCantidadSolicitada.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadSolicitada.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCantidadSolicitada.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadSolicitada.Border.RightColor = System.Drawing.Color.Black
        Me.lblCantidadSolicitada.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadSolicitada.Border.TopColor = System.Drawing.Color.Black
        Me.lblCantidadSolicitada.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadSolicitada.Height = 0.1875!
        Me.lblCantidadSolicitada.HyperLink = Nothing
        Me.lblCantidadSolicitada.Left = 4.5!
        Me.lblCantidadSolicitada.Name = "lblCantidadSolicitada"
        Me.lblCantidadSolicitada.Style = "text-align: center; font-size: 11pt; "
        Me.lblCantidadSolicitada.Text = "Cant Solicitada"
        Me.lblCantidadSolicitada.Top = 0.25!
        Me.lblCantidadSolicitada.Width = 1.1875!
        '
        'txtSivTransferenciaID
        '
        Me.txtSivTransferenciaID.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSivTransferenciaID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivTransferenciaID.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSivTransferenciaID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivTransferenciaID.Border.RightColor = System.Drawing.Color.Black
        Me.txtSivTransferenciaID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivTransferenciaID.Border.TopColor = System.Drawing.Color.Black
        Me.txtSivTransferenciaID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivTransferenciaID.DataField = "SivTransferenciaID"
        Me.txtSivTransferenciaID.Height = 0.1875!
        Me.txtSivTransferenciaID.Left = 0.875!
        Me.txtSivTransferenciaID.Name = "txtSivTransferenciaID"
        Me.txtSivTransferenciaID.Style = "color: DimGray; "
        Me.txtSivTransferenciaID.Text = "txtSivTransferenciaID"
        Me.txtSivTransferenciaID.Top = 0.0!
        Me.txtSivTransferenciaID.Width = 0.8125!
        '
        'lblCantidadDespachada
        '
        Me.lblCantidadDespachada.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCantidadDespachada.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadDespachada.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCantidadDespachada.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadDespachada.Border.RightColor = System.Drawing.Color.Black
        Me.lblCantidadDespachada.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadDespachada.Border.TopColor = System.Drawing.Color.Black
        Me.lblCantidadDespachada.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadDespachada.Height = 0.1875!
        Me.lblCantidadDespachada.HyperLink = Nothing
        Me.lblCantidadDespachada.Left = 5.6875!
        Me.lblCantidadDespachada.Name = "lblCantidadDespachada"
        Me.lblCantidadDespachada.Style = "text-align: center; font-size: 11pt; "
        Me.lblCantidadDespachada.Text = "Cant Despachada"
        Me.lblCantidadDespachada.Top = 0.25!
        Me.lblCantidadDespachada.Width = 1.3125!
        '
        'txtFechadespacho1
        '
        Me.txtFechadespacho1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFechadespacho1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechadespacho1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFechadespacho1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechadespacho1.Border.RightColor = System.Drawing.Color.Black
        Me.txtFechadespacho1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechadespacho1.Border.TopColor = System.Drawing.Color.Black
        Me.txtFechadespacho1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechadespacho1.DataField = "Fechadespacho"
        Me.txtFechadespacho1.Height = 0.2!
        Me.txtFechadespacho1.Left = 2.5625!
        Me.txtFechadespacho1.Name = "txtFechadespacho1"
        Me.txtFechadespacho1.OutputFormat = resources.GetString("txtFechadespacho1.OutputFormat")
        Me.txtFechadespacho1.Style = "color: DimGray; "
        Me.txtFechadespacho1.Text = "txtFechadespacho1"
        Me.txtFechadespacho1.Top = 0.0!
        Me.txtFechadespacho1.Width = 1.0!
        '
        'txtDespachadoPor1
        '
        Me.txtDespachadoPor1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDespachadoPor1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDespachadoPor1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDespachadoPor1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDespachadoPor1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDespachadoPor1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDespachadoPor1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDespachadoPor1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDespachadoPor1.DataField = "DespachadoPor"
        Me.txtDespachadoPor1.Height = 0.2!
        Me.txtDespachadoPor1.Left = 4.71875!
        Me.txtDespachadoPor1.Name = "txtDespachadoPor1"
        Me.txtDespachadoPor1.Style = "color: DimGray; "
        Me.txtDespachadoPor1.Text = "txtDespachadoPor1"
        Me.txtDespachadoPor1.Top = 0.0!
        Me.txtDespachadoPor1.Width = 1.0!
        '
        'Pie_GrupoDespachos
        '
        Me.Pie_GrupoDespachos.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lnPieDetalle})
        Me.Pie_GrupoDespachos.Height = 0.0!
        Me.Pie_GrupoDespachos.Name = "Pie_GrupoDespachos"
        '
        'lnPieDetalle
        '
        Me.lnPieDetalle.Border.BottomColor = System.Drawing.Color.Black
        Me.lnPieDetalle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnPieDetalle.Border.LeftColor = System.Drawing.Color.Black
        Me.lnPieDetalle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnPieDetalle.Border.RightColor = System.Drawing.Color.Black
        Me.lnPieDetalle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnPieDetalle.Border.TopColor = System.Drawing.Color.Black
        Me.lnPieDetalle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnPieDetalle.Height = 0.0!
        Me.lnPieDetalle.Left = 0.3125!
        Me.lnPieDetalle.LineColor = System.Drawing.Color.Silver
        Me.lnPieDetalle.LineWeight = 1.0!
        Me.lnPieDetalle.Name = "lnPieDetalle"
        Me.lnPieDetalle.Top = 0.0!
        Me.lnPieDetalle.Width = 6.6875!
        Me.lnPieDetalle.X1 = 0.3125!
        Me.lnPieDetalle.X2 = 7.0!
        Me.lnPieDetalle.Y1 = 0.0!
        Me.lnPieDetalle.Y2 = 0.0!
        '
        'prmFechaDesde
        '
        Me.prmFechaDesde.DefaultValue = ""
        Me.prmFechaDesde.Key = "prmFechaDesde"
        Me.prmFechaDesde.Prompt = Nothing
        Me.prmFechaDesde.PromptUser = False
        Me.prmFechaDesde.QueryCreated = False
        Me.prmFechaDesde.Tag = Nothing
        Me.prmFechaDesde.Type = DataDynamics.ActiveReports.Parameter.DataType.[Date]
        '
        'prmFechaHasta
        '
        Me.prmFechaHasta.DefaultValue = ""
        Me.prmFechaHasta.Key = "prmFechaHasta"
        Me.prmFechaHasta.Prompt = Nothing
        Me.prmFechaHasta.PromptUser = False
        Me.prmFechaHasta.QueryCreated = False
        Me.prmFechaHasta.Tag = Nothing
        Me.prmFechaHasta.Type = DataDynamics.ActiveReports.Parameter.DataType.[Date]
        '
        'rptTransferenciaDespachos
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Ca" & _
            "talog=SIFUM;Data Source=DESARROLLO1"
        OleDBDataSource1.SQL = "Select * from vwRptTransferenciaDespacho"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.Parameters.Add(Me.prmFechaDesde)
        Me.Parameters.Add(Me.prmFechaHasta)
        Me.PrintWidth = 7.46875!
        Me.Sections.Add(Me.Encabezado_Reporte)
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Encabezado_GrupoSitios)
        Me.Sections.Add(Me.Encabezado_GrupoDespachos)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_GrupoDespachos)
        Me.Sections.Add(Me.Pie_GrupoSitios)
        Me.Sections.Add(Me.Pie_Pagina)
        Me.Sections.Add(Me.Pie_Reporte)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtSivRepuestoID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCorta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadSolicitada1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadDespachada1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigosProveedores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitioDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoTiendaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoTiendaDestino1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNumeroSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFechaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDespachoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAnulada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAnulada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCantidadSolicitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivTransferenciaID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCantidadDespachada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechadespacho1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDespachadoPor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Encabezado_Reporte As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Pie_Reporte As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDesde As DataDynamics.ActiveReports.Label
    Friend WithEvents txtfechaDesde As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblHasta As DataDynamics.ActiveReports.Label
    Friend WithEvents txtFechaHasta As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents Encabezado_GrupoSitios As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Pie_GrupoSitios As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents shpFondoEncabezadoSitios As DataDynamics.ActiveReports.Shape
    Friend WithEvents lblSitioOrigen As DataDynamics.ActiveReports.Label
    Friend WithEvents LblDestino As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSitioOrigen As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSitioDestino As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodigoTiendaOrigen As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtCodigoTiendaDestino1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Encabezado_GrupoDespachos As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lblNumeroSolicitud As DataDynamics.ActiveReports.Label
    Friend WithEvents lblFechaDespacho As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDespachoPor As DataDynamics.ActiveReports.Label
    Friend WithEvents lblAnulada As DataDynamics.ActiveReports.Label
    Friend WithEvents chkAnulada As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents lblCodigoRepuesto As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCodigoProveedor As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDescripcion As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCantidadSolicitada As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSivTransferenciaID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Pie_GrupoDespachos As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtSivRepuestoID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescripcionCorta As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidadSolicitada1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lnLeft As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle4 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle1 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle2 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle3 As DataDynamics.ActiveReports.Line
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents prmFechaDesde As DataDynamics.ActiveReports.Parameter
    Friend WithEvents prmFechaHasta As DataDynamics.ActiveReports.Parameter
    Friend WithEvents lblCantidadDespachada As DataDynamics.ActiveReports.Label
    Friend WithEvents lnRight As DataDynamics.ActiveReports.Line
    Friend WithEvents txtCantidadDespachada1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lnPieDetalle As DataDynamics.ActiveReports.Line
    Friend WithEvents txtFechadespacho1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDespachadoPor1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodigosProveedores1 As DataDynamics.ActiveReports.TextBox
End Class
