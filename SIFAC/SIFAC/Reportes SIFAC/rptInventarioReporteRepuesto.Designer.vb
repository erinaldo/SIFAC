<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptInventarioReporteRepuesto 
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
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptInventarioReporteRepuesto))
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.txtNombreBodega1 = New DataDynamics.ActiveReports.TextBox
        Me.txtUbicacion1 = New DataDynamics.ActiveReports.TextBox
        Me.txtExistencia1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCodigoBodega1 = New DataDynamics.ActiveReports.TextBox
        Me.lnLeft = New DataDynamics.ActiveReports.Line
        Me.lnDetalle1 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle2 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle3 = New DataDynamics.ActiveReports.Line
        Me.lnRigth = New DataDynamics.ActiveReports.Line
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Encabezado_Reporte = New DataDynamics.ActiveReports.ReportHeader
        Me.srptEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.Pie_Reporte = New DataDynamics.ActiveReports.ReportFooter
        Me.Encabezado_GrupoRepuesto = New DataDynamics.ActiveReports.GroupHeader
        Me.shpFondoEncabezadoSitios = New DataDynamics.ActiveReports.Shape
        Me.lblCodigoRepuesto = New DataDynamics.ActiveReports.Label
        Me.txtCostoU = New DataDynamics.ActiveReports.TextBox
        Me.txtPrecioU = New DataDynamics.ActiveReports.TextBox
        Me.lblCodigoBodega = New DataDynamics.ActiveReports.Label
        Me.lblBodega = New DataDynamics.ActiveReports.Label
        Me.lblUbicacion = New DataDynamics.ActiveReports.Label
        Me.lblExistencia = New DataDynamics.ActiveReports.Label
        Me.txtCodigoDescripcion1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_GrupoRepuesto = New DataDynamics.ActiveReports.GroupFooter
        Me.lnPieDetalle = New DataDynamics.ActiveReports.Line
        CType(Me.txtNombreBodega1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBodega1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostoU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigoBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoDescripcion1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNombreBodega1, Me.txtUbicacion1, Me.txtExistencia1, Me.txtCodigoBodega1, Me.lnLeft, Me.lnDetalle1, Me.lnDetalle2, Me.lnDetalle3, Me.lnRigth})
        Me.Detalle.Height = 0.2083333!
        Me.Detalle.Name = "Detalle"
        '
        'txtNombreBodega1
        '
        Me.txtNombreBodega1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNombreBodega1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreBodega1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNombreBodega1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreBodega1.Border.RightColor = System.Drawing.Color.Black
        Me.txtNombreBodega1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreBodega1.Border.TopColor = System.Drawing.Color.Black
        Me.txtNombreBodega1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreBodega1.DataField = "NombreBodega"
        Me.txtNombreBodega1.Height = 0.1875!
        Me.txtNombreBodega1.Left = 1.71875!
        Me.txtNombreBodega1.Name = "txtNombreBodega1"
        Me.txtNombreBodega1.Style = ""
        Me.txtNombreBodega1.Text = "txtNombreBodega1"
        Me.txtNombreBodega1.Top = 0.0!
        Me.txtNombreBodega1.Width = 1.75!
        '
        'txtUbicacion1
        '
        Me.txtUbicacion1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtUbicacion1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUbicacion1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtUbicacion1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUbicacion1.Border.RightColor = System.Drawing.Color.Black
        Me.txtUbicacion1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUbicacion1.Border.TopColor = System.Drawing.Color.Black
        Me.txtUbicacion1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUbicacion1.DataField = "Ubicacion"
        Me.txtUbicacion1.Height = 0.1875!
        Me.txtUbicacion1.Left = 3.541667!
        Me.txtUbicacion1.Name = "txtUbicacion1"
        Me.txtUbicacion1.Style = "text-align: center; "
        Me.txtUbicacion1.Text = "txtUbicacion1"
        Me.txtUbicacion1.Top = 0.0!
        Me.txtUbicacion1.Width = 1.0!
        '
        'txtExistencia1
        '
        Me.txtExistencia1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtExistencia1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExistencia1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtExistencia1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExistencia1.Border.RightColor = System.Drawing.Color.Black
        Me.txtExistencia1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExistencia1.Border.TopColor = System.Drawing.Color.Black
        Me.txtExistencia1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExistencia1.DataField = "Existencia"
        Me.txtExistencia1.Height = 0.1875!
        Me.txtExistencia1.Left = 4.583333!
        Me.txtExistencia1.Name = "txtExistencia1"
        Me.txtExistencia1.Style = "text-align: right; "
        Me.txtExistencia1.Text = "txtExistencia1"
        Me.txtExistencia1.Top = 0.0!
        Me.txtExistencia1.Width = 1.0!
        '
        'txtCodigoBodega1
        '
        Me.txtCodigoBodega1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoBodega1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoBodega1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoBodega1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoBodega1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoBodega1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoBodega1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoBodega1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoBodega1.DataField = "CodigoBodega"
        Me.txtCodigoBodega1.Height = 0.1875!
        Me.txtCodigoBodega1.Left = 0.6875!
        Me.txtCodigoBodega1.Name = "txtCodigoBodega1"
        Me.txtCodigoBodega1.Style = "text-align: center; "
        Me.txtCodigoBodega1.Text = "txtCodigoBodega1"
        Me.txtCodigoBodega1.Top = 0.0!
        Me.txtCodigoBodega1.Width = 0.9375!
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
        Me.lnLeft.Left = 0.6875!
        Me.lnLeft.LineColor = System.Drawing.Color.Silver
        Me.lnLeft.LineWeight = 0.4!
        Me.lnLeft.Name = "lnLeft"
        Me.lnLeft.Top = 0.0!
        Me.lnLeft.Width = 0.0!
        Me.lnLeft.X1 = 0.6875!
        Me.lnLeft.X2 = 0.6875!
        Me.lnLeft.Y1 = 0.0!
        Me.lnLeft.Y2 = 0.1875!
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
        Me.lnDetalle1.Left = 1.6875!
        Me.lnDetalle1.LineColor = System.Drawing.Color.Silver
        Me.lnDetalle1.LineWeight = 0.4!
        Me.lnDetalle1.Name = "lnDetalle1"
        Me.lnDetalle1.Top = 0.0!
        Me.lnDetalle1.Width = 0.0!
        Me.lnDetalle1.X1 = 1.6875!
        Me.lnDetalle1.X2 = 1.6875!
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
        Me.lnDetalle2.Left = 3.5!
        Me.lnDetalle2.LineColor = System.Drawing.Color.Silver
        Me.lnDetalle2.LineWeight = 0.4!
        Me.lnDetalle2.Name = "lnDetalle2"
        Me.lnDetalle2.Top = 0.0!
        Me.lnDetalle2.Width = 0.0!
        Me.lnDetalle2.X1 = 3.5!
        Me.lnDetalle2.X2 = 3.5!
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
        Me.lnDetalle3.Left = 4.5625!
        Me.lnDetalle3.LineColor = System.Drawing.Color.Silver
        Me.lnDetalle3.LineWeight = 0.4!
        Me.lnDetalle3.Name = "lnDetalle3"
        Me.lnDetalle3.Top = 0.0!
        Me.lnDetalle3.Width = 0.0!
        Me.lnDetalle3.X1 = 4.5625!
        Me.lnDetalle3.X2 = 4.5625!
        Me.lnDetalle3.Y1 = 0.0!
        Me.lnDetalle3.Y2 = 0.1875!
        '
        'lnRigth
        '
        Me.lnRigth.AnchorBottom = True
        Me.lnRigth.Border.BottomColor = System.Drawing.Color.Black
        Me.lnRigth.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnRigth.Border.LeftColor = System.Drawing.Color.Black
        Me.lnRigth.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnRigth.Border.RightColor = System.Drawing.Color.Black
        Me.lnRigth.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnRigth.Border.TopColor = System.Drawing.Color.Black
        Me.lnRigth.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnRigth.Height = 0.1875!
        Me.lnRigth.Left = 5.625!
        Me.lnRigth.LineColor = System.Drawing.Color.Silver
        Me.lnRigth.LineWeight = 0.4!
        Me.lnRigth.Name = "lnRigth"
        Me.lnRigth.Top = 0.0!
        Me.lnRigth.Width = 0.0!
        Me.lnRigth.X1 = 5.625!
        Me.lnRigth.X2 = 5.625!
        Me.lnRigth.Y1 = 0.0!
        Me.lnRigth.Y2 = 0.1875!
        '
        'Pie_Pagina
        '
        Me.Pie_Pagina.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
        Me.Pie_Pagina.Height = 0.2083333!
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
        Me.ReportInfo1.Left = 5.3125!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: Gray; ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 2.0!
        '
        'Encabezado_Reporte
        '
        Me.Encabezado_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srptEncabezado, Me.lblTitulo})
        Me.Encabezado_Reporte.Height = 1.65625!
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
        Me.lblTitulo.Left = 0.0625!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "color: SteelBlue; ddo-char-set: 1; text-align: center; font-weight: bold; font-si" & _
            "ze: 14.25pt; font-family: Times New Roman; vertical-align: middle; "
        Me.lblTitulo.Text = "Reporte de Inventario"
        Me.lblTitulo.Top = 1.25!
        Me.lblTitulo.Width = 7.375!
        '
        'Pie_Reporte
        '
        Me.Pie_Reporte.Height = 0.0!
        Me.Pie_Reporte.Name = "Pie_Reporte"
        '
        'Encabezado_GrupoRepuesto
        '
        Me.Encabezado_GrupoRepuesto.ColumnGroupKeepTogether = True
        Me.Encabezado_GrupoRepuesto.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.shpFondoEncabezadoSitios, Me.lblCodigoRepuesto, Me.txtCostoU, Me.txtPrecioU, Me.lblCodigoBodega, Me.lblBodega, Me.lblUbicacion, Me.lblExistencia, Me.txtCodigoDescripcion1})
        Me.Encabezado_GrupoRepuesto.DataField = "SivRepuestoID"
        Me.Encabezado_GrupoRepuesto.Height = 0.5625!
        Me.Encabezado_GrupoRepuesto.Name = "Encabezado_GrupoRepuesto"
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
        Me.shpFondoEncabezadoSitios.Left = 0.03125!
        Me.shpFondoEncabezadoSitios.Name = "shpFondoEncabezadoSitios"
        Me.shpFondoEncabezadoSitios.RoundingRadius = 9.999999!
        Me.shpFondoEncabezadoSitios.Top = 0.02083333!
        Me.shpFondoEncabezadoSitios.Width = 7.375!
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
        Me.lblCodigoRepuesto.Left = 0.0625!
        Me.lblCodigoRepuesto.Name = "lblCodigoRepuesto"
        Me.lblCodigoRepuesto.Style = "font-weight: bold; "
        Me.lblCodigoRepuesto.Text = "Código:"
        Me.lblCodigoRepuesto.Top = 0.0625!
        Me.lblCodigoRepuesto.Width = 0.625!
        '
        'txtCostoU
        '
        Me.txtCostoU.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCostoU.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCostoU.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCostoU.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCostoU.Border.RightColor = System.Drawing.Color.Black
        Me.txtCostoU.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCostoU.Border.TopColor = System.Drawing.Color.Black
        Me.txtCostoU.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCostoU.DataField = "Costo"
        Me.txtCostoU.Height = 0.1875!
        Me.txtCostoU.Left = 4.1875!
        Me.txtCostoU.Name = "txtCostoU"
        Me.txtCostoU.Style = "text-align: right; "
        Me.txtCostoU.Text = "txtCostoU1"
        Me.txtCostoU.Top = 0.0625!
        Me.txtCostoU.Width = 1.5625!
        '
        'txtPrecioU
        '
        Me.txtPrecioU.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPrecioU.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecioU.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPrecioU.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecioU.Border.RightColor = System.Drawing.Color.Black
        Me.txtPrecioU.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecioU.Border.TopColor = System.Drawing.Color.Black
        Me.txtPrecioU.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecioU.DataField = "Precio"
        Me.txtPrecioU.Height = 0.1875!
        Me.txtPrecioU.Left = 5.8125!
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.Style = "text-align: right; "
        Me.txtPrecioU.Text = "txtPrecioU1"
        Me.txtPrecioU.Top = 0.0625!
        Me.txtPrecioU.Width = 1.56!
        '
        'lblCodigoBodega
        '
        Me.lblCodigoBodega.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCodigoBodega.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoBodega.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCodigoBodega.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoBodega.Border.RightColor = System.Drawing.Color.Black
        Me.lblCodigoBodega.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoBodega.Border.TopColor = System.Drawing.Color.Black
        Me.lblCodigoBodega.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoBodega.Height = 0.1875!
        Me.lblCodigoBodega.HyperLink = Nothing
        Me.lblCodigoBodega.Left = 0.6875!
        Me.lblCodigoBodega.Name = "lblCodigoBodega"
        Me.lblCodigoBodega.Style = "color: Black; text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblCodigoBodega.Text = "Código"
        Me.lblCodigoBodega.Top = 0.375!
        Me.lblCodigoBodega.Width = 1.0!
        '
        'lblBodega
        '
        Me.lblBodega.Border.BottomColor = System.Drawing.Color.Black
        Me.lblBodega.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblBodega.Border.LeftColor = System.Drawing.Color.Black
        Me.lblBodega.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblBodega.Border.RightColor = System.Drawing.Color.Black
        Me.lblBodega.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblBodega.Border.TopColor = System.Drawing.Color.Black
        Me.lblBodega.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblBodega.Height = 0.1875!
        Me.lblBodega.HyperLink = Nothing
        Me.lblBodega.Left = 1.6875!
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Style = "color: Black; text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblBodega.Text = "Bodega"
        Me.lblBodega.Top = 0.375!
        Me.lblBodega.Width = 1.8125!
        '
        'lblUbicacion
        '
        Me.lblUbicacion.Border.BottomColor = System.Drawing.Color.Black
        Me.lblUbicacion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblUbicacion.Border.LeftColor = System.Drawing.Color.Black
        Me.lblUbicacion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblUbicacion.Border.RightColor = System.Drawing.Color.Black
        Me.lblUbicacion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblUbicacion.Border.TopColor = System.Drawing.Color.Black
        Me.lblUbicacion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblUbicacion.Height = 0.1875!
        Me.lblUbicacion.HyperLink = Nothing
        Me.lblUbicacion.Left = 3.5!
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Style = "color: Black; text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblUbicacion.Text = "Ubicacion"
        Me.lblUbicacion.Top = 0.375!
        Me.lblUbicacion.Width = 1.0625!
        '
        'lblExistencia
        '
        Me.lblExistencia.Border.BottomColor = System.Drawing.Color.Black
        Me.lblExistencia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExistencia.Border.LeftColor = System.Drawing.Color.Black
        Me.lblExistencia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExistencia.Border.RightColor = System.Drawing.Color.Black
        Me.lblExistencia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExistencia.Border.TopColor = System.Drawing.Color.Black
        Me.lblExistencia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExistencia.Height = 0.1875!
        Me.lblExistencia.HyperLink = Nothing
        Me.lblExistencia.Left = 4.5625!
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Style = "color: Black; text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblExistencia.Text = "Existencia"
        Me.lblExistencia.Top = 0.375!
        Me.lblExistencia.Width = 1.0625!
        '
        'txtCodigoDescripcion1
        '
        Me.txtCodigoDescripcion1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoDescripcion1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoDescripcion1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoDescripcion1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoDescripcion1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoDescripcion1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoDescripcion1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoDescripcion1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoDescripcion1.DataField = "CodigoDescripcion"
        Me.txtCodigoDescripcion1.Height = 0.1875!
        Me.txtCodigoDescripcion1.Left = 0.75!
        Me.txtCodigoDescripcion1.Name = "txtCodigoDescripcion1"
        Me.txtCodigoDescripcion1.Style = ""
        Me.txtCodigoDescripcion1.Text = "txtCodigoDescripcion1"
        Me.txtCodigoDescripcion1.Top = 0.0625!
        Me.txtCodigoDescripcion1.Width = 3.375!
        '
        'Pie_GrupoRepuesto
        '
        Me.Pie_GrupoRepuesto.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lnPieDetalle})
        Me.Pie_GrupoRepuesto.Height = 0.125!
        Me.Pie_GrupoRepuesto.Name = "Pie_GrupoRepuesto"
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
        Me.lnPieDetalle.Left = 0.6979167!
        Me.lnPieDetalle.LineColor = System.Drawing.Color.Silver
        Me.lnPieDetalle.LineWeight = 1.0!
        Me.lnPieDetalle.Name = "lnPieDetalle"
        Me.lnPieDetalle.Top = 0.0!
        Me.lnPieDetalle.Width = 4.927083!
        Me.lnPieDetalle.X1 = 0.6979167!
        Me.lnPieDetalle.X2 = 5.625!
        Me.lnPieDetalle.Y1 = 0.0!
        Me.lnPieDetalle.Y2 = 0.0!
        '
        'rptInventarioReporteRepuesto
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Ca" & _
            "talog=SIFUM;Data Source=192.168.1.1"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.5!
        Me.Sections.Add(Me.Encabezado_Reporte)
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Encabezado_GrupoRepuesto)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_GrupoRepuesto)
        Me.Sections.Add(Me.Pie_Pagina)
        Me.Sections.Add(Me.Pie_Reporte)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtNombreBodega1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBodega1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostoU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigoBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoDescripcion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Encabezado_Reporte As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Pie_Reporte As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents srptEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents Encabezado_GrupoRepuesto As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Pie_GrupoRepuesto As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents lblCodigoRepuesto As DataDynamics.ActiveReports.Label
    Friend WithEvents txtCostoU As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrecioU As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNombreBodega1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUbicacion1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtExistencia1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblCodigoBodega As DataDynamics.ActiveReports.Label
    Friend WithEvents lblBodega As DataDynamics.ActiveReports.Label
    Friend WithEvents lblUbicacion As DataDynamics.ActiveReports.Label
    Friend WithEvents lblExistencia As DataDynamics.ActiveReports.Label
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents txtCodigoDescripcion1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents shpFondoEncabezadoSitios As DataDynamics.ActiveReports.Shape
    Friend WithEvents txtCodigoBodega1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lnPieDetalle As DataDynamics.ActiveReports.Line
    Friend WithEvents lnLeft As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle1 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle2 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle3 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnRigth As DataDynamics.ActiveReports.Line
End Class 
