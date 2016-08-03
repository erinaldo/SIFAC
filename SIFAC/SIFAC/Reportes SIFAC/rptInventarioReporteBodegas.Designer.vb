<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptInventarioReporteBodegas 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptInventarioReporteBodegas))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.txtSivRepuestoID = New DataDynamics.ActiveReports.TextBox
        Me.lnLeft = New DataDynamics.ActiveReports.Line
        Me.lnRight = New DataDynamics.ActiveReports.Line
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Encabezado_Reporte = New DataDynamics.ActiveReports.ReportHeader
        Me.srptEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.Pie_Reporte = New DataDynamics.ActiveReports.ReportFooter
        Me.lblGranTotal = New DataDynamics.ActiveReports.Label
        Me.txtGranTotalCosto = New DataDynamics.ActiveReports.TextBox
        Me.txtGranTotalPrecio = New DataDynamics.ActiveReports.TextBox
        Me.Encabezado_GrupoBodegas = New DataDynamics.ActiveReports.GroupHeader
        Me.txtNombreBodega = New DataDynamics.ActiveReports.TextBox
        Me.lblCodigo = New DataDynamics.ActiveReports.Label
        Me.Pie_GrupoBodegas = New DataDynamics.ActiveReports.GroupFooter
        Me.lblTotalBodegas = New DataDynamics.ActiveReports.Label
        Me.txtTotalCostoBodegas = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalPrecioBodegas = New DataDynamics.ActiveReports.TextBox
        Me.lnPieDetalle = New DataDynamics.ActiveReports.Line
        CType(Me.txtSivRepuestoID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGranTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGranTotalCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGranTotalPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCostoBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPrecioBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSivRepuestoID, Me.lnLeft, Me.lnRight})
        Me.Detalle.Height = 0.2083333!
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
        Me.txtSivRepuestoID.Left = 0.0625!
        Me.txtSivRepuestoID.Name = "txtSivRepuestoID"
        Me.txtSivRepuestoID.Style = "text-align: right; "
        Me.txtSivRepuestoID.Text = "txtSivRepuestoID1"
        Me.txtSivRepuestoID.Top = 0.0!
        Me.txtSivRepuestoID.Width = 0.6875!
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
        Me.lnLeft.Height = 0.1770833!
        Me.lnLeft.Left = 0.0625!
        Me.lnLeft.LineColor = System.Drawing.Color.Silver
        Me.lnLeft.LineWeight = 1.0!
        Me.lnLeft.Name = "lnLeft"
        Me.lnLeft.Top = 0.0!
        Me.lnLeft.Width = 0.0!
        Me.lnLeft.X1 = 0.0625!
        Me.lnLeft.X2 = 0.0625!
        Me.lnLeft.Y1 = 0.0!
        Me.lnLeft.Y2 = 0.1770833!
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
        Me.lnRight.Left = 7.9375!
        Me.lnRight.LineColor = System.Drawing.Color.Silver
        Me.lnRight.LineWeight = 0.4!
        Me.lnRight.Name = "lnRight"
        Me.lnRight.Top = 0.0!
        Me.lnRight.Width = 0.0!
        Me.lnRight.X1 = 7.9375!
        Me.lnRight.X2 = 7.9375!
        Me.lnRight.Y1 = 0.0!
        Me.lnRight.Y2 = 0.1875!
        '
        'Pie_Pagina
        '
        Me.Pie_Pagina.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
        Me.Pie_Pagina.Height = 0.25!
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
        Me.ReportInfo1.Top = 0.01041667!
        Me.ReportInfo1.Width = 2.0!
        '
        'Encabezado_Reporte
        '
        Me.Encabezado_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srptEncabezado, Me.lblTitulo})
        Me.Encabezado_Reporte.Height = 1.447917!
        Me.Encabezado_Reporte.Name = "Encabezado_Reporte"
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
        Me.srptEncabezado.Left = 0.03125!
        Me.srptEncabezado.Name = "srptEncabezado"
        Me.srptEncabezado.Report = Nothing
        Me.srptEncabezado.ReportName = "Encabezado"
        Me.srptEncabezado.Top = 0.0!
        Me.srptEncabezado.Width = 7.4375!
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
        Me.lblTitulo.Left = 0.0!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "color: SteelBlue; ddo-char-set: 1; text-align: center; font-weight: bold; font-si" & _
            "ze: 14.25pt; font-family: Times New Roman; vertical-align: middle; "
        Me.lblTitulo.Text = "Reporte de Inventario"
        Me.lblTitulo.Top = 1.15625!
        Me.lblTitulo.Width = 7.4375!
        '
        'Pie_Reporte
        '
        Me.Pie_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblGranTotal, Me.txtGranTotalCosto, Me.txtGranTotalPrecio})
        Me.Pie_Reporte.Height = 0.25!
        Me.Pie_Reporte.Name = "Pie_Reporte"
        '
        'lblGranTotal
        '
        Me.lblGranTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.lblGranTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblGranTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.lblGranTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblGranTotal.Border.RightColor = System.Drawing.Color.Black
        Me.lblGranTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblGranTotal.Border.TopColor = System.Drawing.Color.Black
        Me.lblGranTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblGranTotal.Height = 0.1875!
        Me.lblGranTotal.HyperLink = Nothing
        Me.lblGranTotal.Left = 3.8125!
        Me.lblGranTotal.Name = "lblGranTotal"
        Me.lblGranTotal.Style = "text-align: right; font-weight: bold; "
        Me.lblGranTotal.Text = "Gran Total $:"
        Me.lblGranTotal.Top = 0.0!
        Me.lblGranTotal.Width = 1.5625!
        '
        'txtGranTotalCosto
        '
        Me.txtGranTotalCosto.Border.BottomColor = System.Drawing.Color.Black
        Me.txtGranTotalCosto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGranTotalCosto.Border.LeftColor = System.Drawing.Color.Black
        Me.txtGranTotalCosto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGranTotalCosto.Border.RightColor = System.Drawing.Color.Black
        Me.txtGranTotalCosto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGranTotalCosto.Border.TopColor = System.Drawing.Color.Black
        Me.txtGranTotalCosto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGranTotalCosto.DataField = "TotalCosto"
        Me.txtGranTotalCosto.Height = 0.1875!
        Me.txtGranTotalCosto.Left = 5.5625!
        Me.txtGranTotalCosto.Name = "txtGranTotalCosto"
        Me.txtGranTotalCosto.OutputFormat = resources.GetString("txtGranTotalCosto.OutputFormat")
        Me.txtGranTotalCosto.Style = "text-align: right; vertical-align: middle; "
        Me.txtGranTotalCosto.SummaryGroup = "Encabezado_GrupoBodegas"
        Me.txtGranTotalCosto.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtGranTotalCosto.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtGranTotalCosto.Text = "$ 0.00"
        Me.txtGranTotalCosto.Top = 0.0!
        Me.txtGranTotalCosto.Width = 1.0!
        '
        'txtGranTotalPrecio
        '
        Me.txtGranTotalPrecio.Border.BottomColor = System.Drawing.Color.Black
        Me.txtGranTotalPrecio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGranTotalPrecio.Border.LeftColor = System.Drawing.Color.Black
        Me.txtGranTotalPrecio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGranTotalPrecio.Border.RightColor = System.Drawing.Color.Black
        Me.txtGranTotalPrecio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGranTotalPrecio.Border.TopColor = System.Drawing.Color.Black
        Me.txtGranTotalPrecio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGranTotalPrecio.DataField = "TotalPrecio"
        Me.txtGranTotalPrecio.Height = 0.1875!
        Me.txtGranTotalPrecio.Left = 6.9375!
        Me.txtGranTotalPrecio.Name = "txtGranTotalPrecio"
        Me.txtGranTotalPrecio.OutputFormat = resources.GetString("txtGranTotalPrecio.OutputFormat")
        Me.txtGranTotalPrecio.Style = "text-align: right; vertical-align: middle; "
        Me.txtGranTotalPrecio.SummaryGroup = "Encabezado_GrupoBodegas"
        Me.txtGranTotalPrecio.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtGranTotalPrecio.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtGranTotalPrecio.Text = "$ 0.00"
        Me.txtGranTotalPrecio.Top = 0.0!
        Me.txtGranTotalPrecio.Width = 1.0!
        '
        'Encabezado_GrupoBodegas
        '
        Me.Encabezado_GrupoBodegas.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNombreBodega, Me.lblCodigo})
        Me.Encabezado_GrupoBodegas.DataField = "objTiendaID"
        Me.Encabezado_GrupoBodegas.Height = 0.6458333!
        Me.Encabezado_GrupoBodegas.Name = "Encabezado_GrupoBodegas"
        '
        'txtNombreBodega
        '
        Me.txtNombreBodega.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNombreBodega.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreBodega.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNombreBodega.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreBodega.Border.RightColor = System.Drawing.Color.Black
        Me.txtNombreBodega.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreBodega.Border.TopColor = System.Drawing.Color.Black
        Me.txtNombreBodega.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreBodega.DataField = "NombreBodegaConCodigo"
        Me.txtNombreBodega.Height = 0.1875!
        Me.txtNombreBodega.Left = 0.0625!
        Me.txtNombreBodega.Name = "txtNombreBodega"
        Me.txtNombreBodega.Style = "text-align: left; font-weight: bold; "
        Me.txtNombreBodega.Text = "txtNombreBodega"
        Me.txtNombreBodega.Top = 0.1458333!
        Me.txtNombreBodega.Width = 7.8125!
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
        Me.lblCodigo.Height = 0.25!
        Me.lblCodigo.HyperLink = ""
        Me.lblCodigo.Left = 0.0625!
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Style = "text-align: center; font-weight: bold; background-color: Gainsboro; font-size: 8p" & _
            "t; vertical-align: middle; "
        Me.lblCodigo.Text = "Código"
        Me.lblCodigo.Top = 0.3958333!
        Me.lblCodigo.Width = 0.6875!
        '
        'Pie_GrupoBodegas
        '
        Me.Pie_GrupoBodegas.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTotalBodegas, Me.txtTotalCostoBodegas, Me.txtTotalPrecioBodegas, Me.lnPieDetalle})
        Me.Pie_GrupoBodegas.Height = 0.25!
        Me.Pie_GrupoBodegas.Name = "Pie_GrupoBodegas"
        '
        'lblTotalBodegas
        '
        Me.lblTotalBodegas.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTotalBodegas.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalBodegas.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTotalBodegas.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalBodegas.Border.RightColor = System.Drawing.Color.Black
        Me.lblTotalBodegas.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalBodegas.Border.TopColor = System.Drawing.Color.Black
        Me.lblTotalBodegas.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalBodegas.Height = 0.1875!
        Me.lblTotalBodegas.HyperLink = Nothing
        Me.lblTotalBodegas.Left = 3.885417!
        Me.lblTotalBodegas.Name = "lblTotalBodegas"
        Me.lblTotalBodegas.Style = "text-align: right; font-weight: bold; "
        Me.lblTotalBodegas.Text = "Total Bodega $:"
        Me.lblTotalBodegas.Top = 0.02083333!
        Me.lblTotalBodegas.Width = 1.5625!
        '
        'txtTotalCostoBodegas
        '
        Me.txtTotalCostoBodegas.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalCostoBodegas.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCostoBodegas.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalCostoBodegas.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCostoBodegas.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalCostoBodegas.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCostoBodegas.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalCostoBodegas.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCostoBodegas.DataField = "TotalCosto"
        Me.txtTotalCostoBodegas.Height = 0.1875!
        Me.txtTotalCostoBodegas.Left = 5.5625!
        Me.txtTotalCostoBodegas.Name = "txtTotalCostoBodegas"
        Me.txtTotalCostoBodegas.OutputFormat = resources.GetString("txtTotalCostoBodegas.OutputFormat")
        Me.txtTotalCostoBodegas.Style = "text-align: right; vertical-align: middle; "
        Me.txtTotalCostoBodegas.SummaryGroup = "Encabezado_GrupoBodegas"
        Me.txtTotalCostoBodegas.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtTotalCostoBodegas.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtTotalCostoBodegas.Text = "$ 0.00"
        Me.txtTotalCostoBodegas.Top = 0.02083333!
        Me.txtTotalCostoBodegas.Width = 1.0!
        '
        'txtTotalPrecioBodegas
        '
        Me.txtTotalPrecioBodegas.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalPrecioBodegas.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalPrecioBodegas.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalPrecioBodegas.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalPrecioBodegas.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalPrecioBodegas.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalPrecioBodegas.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalPrecioBodegas.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalPrecioBodegas.DataField = "TotalPrecio"
        Me.txtTotalPrecioBodegas.Height = 0.1875!
        Me.txtTotalPrecioBodegas.Left = 6.9375!
        Me.txtTotalPrecioBodegas.Name = "txtTotalPrecioBodegas"
        Me.txtTotalPrecioBodegas.OutputFormat = resources.GetString("txtTotalPrecioBodegas.OutputFormat")
        Me.txtTotalPrecioBodegas.Style = "text-align: right; vertical-align: middle; "
        Me.txtTotalPrecioBodegas.SummaryGroup = "Encabezado_GrupoBodegas"
        Me.txtTotalPrecioBodegas.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtTotalPrecioBodegas.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtTotalPrecioBodegas.Text = "$ 0.00"
        Me.txtTotalPrecioBodegas.Top = 0.02083333!
        Me.txtTotalPrecioBodegas.Width = 1.0!
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
        Me.lnPieDetalle.Left = 0.07291666!
        Me.lnPieDetalle.LineColor = System.Drawing.Color.Silver
        Me.lnPieDetalle.LineWeight = 1.0!
        Me.lnPieDetalle.Name = "lnPieDetalle"
        Me.lnPieDetalle.Top = 0.0!
        Me.lnPieDetalle.Width = 7.864583!
        Me.lnPieDetalle.X1 = 0.07291666!
        Me.lnPieDetalle.X2 = 7.9375!
        Me.lnPieDetalle.Y1 = 0.0!
        Me.lnPieDetalle.Y2 = 0.0!
        '
        'rptInventarioReporteBodegas
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Ca" & _
            "talog=SIFUM;Data Source=192.168.1.1"
        OleDBDataSource1.SQL = "Select * from dbo.vwRptInventario"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Left = 0.3!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 8.039584!
        Me.Sections.Add(Me.Encabezado_Reporte)
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Encabezado_GrupoBodegas)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_GrupoBodegas)
        Me.Sections.Add(Me.Pie_Pagina)
        Me.Sections.Add(Me.Pie_Reporte)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtSivRepuestoID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGranTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGranTotalCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGranTotalPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCostoBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPrecioBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Encabezado_Reporte As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Pie_Reporte As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents srptEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents Encabezado_GrupoBodegas As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Pie_GrupoBodegas As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtNombreBodega As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblCodigo As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSivRepuestoID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lnLeft As DataDynamics.ActiveReports.Line
    Friend WithEvents lnRight As DataDynamics.ActiveReports.Line
    Friend WithEvents lblTotalBodegas As DataDynamics.ActiveReports.Label
    Friend WithEvents txtTotalCostoBodegas As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalPrecioBodegas As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents lblGranTotal As DataDynamics.ActiveReports.Label
    Friend WithEvents txtGranTotalCosto As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtGranTotalPrecio As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lnPieDetalle As DataDynamics.ActiveReports.Line
End Class 
