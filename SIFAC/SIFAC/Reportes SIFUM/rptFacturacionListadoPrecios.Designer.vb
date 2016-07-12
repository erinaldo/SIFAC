<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptFacturacionListadoPrecios 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptFacturacionListadoPrecios))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.shpFondo = New DataDynamics.ActiveReports.Shape
        Me.lblCodigo = New DataDynamics.ActiveReports.Label
        Me.lblDescripcion = New DataDynamics.ActiveReports.Label
        Me.lblMarca = New DataDynamics.ActiveReports.Label
        Me.lblTipoRepuesto = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.lblPrecio = New DataDynamics.ActiveReports.Label
        Me.lblPorcPromocion = New DataDynamics.ActiveReports.Label
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.lblExistencia = New DataDynamics.ActiveReports.Label
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.txtSivRepuestoID1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescripcion1 = New DataDynamics.ActiveReports.TextBox
        Me.txtTipoRepuesto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtMarca1 = New DataDynamics.ActiveReports.TextBox
        Me.txtPrecio1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescuentoPromocion1 = New DataDynamics.ActiveReports.TextBox
        Me.txtExistenciaTotal1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Encabezado_Reporte = New DataDynamics.ActiveReports.ReportHeader
        Me.srptEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.Pie_Reporte = New DataDynamics.ActiveReports.ReportFooter
        Me.lnLeft = New DataDynamics.ActiveReports.Line
        Me.lnDetalle1 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle2 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle3 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle4 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle5 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle6 = New DataDynamics.ActiveReports.Line
        Me.lnRight = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.lblTienda = New DataDynamics.ActiveReports.Label
        Me.txtTienda1 = New DataDynamics.ActiveReports.TextBox
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTipoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPorcPromocion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivRepuestoID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoRepuesto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoPromocion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistenciaTotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTienda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Encabezado_Pagina
        '
        Me.Encabezado_Pagina.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.shpFondo, Me.lblCodigo, Me.lblDescripcion, Me.lblMarca, Me.lblTipoRepuesto, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line9, Me.lblPrecio, Me.lblPorcPromocion, Me.Line5, Me.lblExistencia})
        Me.Encabezado_Pagina.Height = 0.4479167!
        Me.Encabezado_Pagina.Name = "Encabezado_Pagina"
        '
        'shpFondo
        '
        Me.shpFondo.BackColor = System.Drawing.Color.Gainsboro
        Me.shpFondo.Border.BottomColor = System.Drawing.Color.Black
        Me.shpFondo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondo.Border.LeftColor = System.Drawing.Color.Black
        Me.shpFondo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondo.Border.RightColor = System.Drawing.Color.Black
        Me.shpFondo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondo.Border.TopColor = System.Drawing.Color.Black
        Me.shpFondo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondo.Height = 0.4375!
        Me.shpFondo.Left = 0.0625!
        Me.shpFondo.Name = "shpFondo"
        Me.shpFondo.RoundingRadius = 9.999999!
        Me.shpFondo.Top = 0.0!
        Me.shpFondo.Width = 7.125!
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
        Me.lblCodigo.Left = 0.125!
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Style = "text-align: center; font-weight: bold; "
        Me.lblCodigo.Text = "CODIGO"
        Me.lblCodigo.Top = 0.1041667!
        Me.lblCodigo.Width = 0.6875!
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
        Me.lblDescripcion.Height = 0.25!
        Me.lblDescripcion.HyperLink = ""
        Me.lblDescripcion.Left = 1.0625!
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Style = "text-align: center; font-weight: bold; vertical-align: top; "
        Me.lblDescripcion.Text = "DESCRIPCION"
        Me.lblDescripcion.Top = 0.125!
        Me.lblDescripcion.Width = 1.75!
        '
        'lblMarca
        '
        Me.lblMarca.Border.BottomColor = System.Drawing.Color.Black
        Me.lblMarca.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMarca.Border.LeftColor = System.Drawing.Color.Black
        Me.lblMarca.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMarca.Border.RightColor = System.Drawing.Color.Black
        Me.lblMarca.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMarca.Border.TopColor = System.Drawing.Color.Black
        Me.lblMarca.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblMarca.Height = 0.3125!
        Me.lblMarca.HyperLink = ""
        Me.lblMarca.Left = 3.791667!
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblMarca.Text = "MARCA"
        Me.lblMarca.Top = 0.05208333!
        Me.lblMarca.Width = 0.625!
        '
        'lblTipoRepuesto
        '
        Me.lblTipoRepuesto.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTipoRepuesto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTipoRepuesto.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTipoRepuesto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTipoRepuesto.Border.RightColor = System.Drawing.Color.Black
        Me.lblTipoRepuesto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTipoRepuesto.Border.TopColor = System.Drawing.Color.Black
        Me.lblTipoRepuesto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTipoRepuesto.Height = 0.3125!
        Me.lblTipoRepuesto.HyperLink = ""
        Me.lblTipoRepuesto.Left = 2.927083!
        Me.lblTipoRepuesto.Name = "lblTipoRepuesto"
        Me.lblTipoRepuesto.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblTipoRepuesto.Text = "TIPO"
        Me.lblTipoRepuesto.Top = 0.0625!
        Me.lblTipoRepuesto.Width = 0.75!
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
        Me.Line1.Height = 0.4375!
        Me.Line1.Left = 1.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 1.0!
        Me.Line1.X2 = 1.0!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.4375!
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
        Me.Line2.Height = 0.4375!
        Me.Line2.Left = 2.864583!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 2.864583!
        Me.Line2.X2 = 2.864583!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.4375!
        '
        'Line3
        '
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.4375!
        Me.Line3.Left = 3.75!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 3.75!
        Me.Line3.X2 = 3.75!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.4375!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.4375!
        Me.Line4.Left = 4.489583!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 4.489583!
        Me.Line4.X2 = 4.489583!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.4375!
        '
        'Line9
        '
        Me.Line9.Border.BottomColor = System.Drawing.Color.Black
        Me.Line9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.LeftColor = System.Drawing.Color.Black
        Me.Line9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.RightColor = System.Drawing.Color.Black
        Me.Line9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.TopColor = System.Drawing.Color.Black
        Me.Line9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Height = 0.4375!
        Me.Line9.Left = 5.1875!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.0!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 5.1875!
        Me.Line9.X2 = 5.1875!
        Me.Line9.Y1 = 0.0!
        Me.Line9.Y2 = 0.4375!
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
        Me.lblPrecio.Height = 0.3125!
        Me.lblPrecio.HyperLink = ""
        Me.lblPrecio.Left = 4.5625!
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblPrecio.Text = "PRECIO"
        Me.lblPrecio.Top = 0.0625!
        Me.lblPrecio.Width = 0.5625!
        '
        'lblPorcPromocion
        '
        Me.lblPorcPromocion.Border.BottomColor = System.Drawing.Color.Black
        Me.lblPorcPromocion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPorcPromocion.Border.LeftColor = System.Drawing.Color.Black
        Me.lblPorcPromocion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPorcPromocion.Border.RightColor = System.Drawing.Color.Black
        Me.lblPorcPromocion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPorcPromocion.Border.TopColor = System.Drawing.Color.Black
        Me.lblPorcPromocion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPorcPromocion.Height = 0.3125!
        Me.lblPorcPromocion.HyperLink = ""
        Me.lblPorcPromocion.Left = 5.25!
        Me.lblPorcPromocion.Name = "lblPorcPromocion"
        Me.lblPorcPromocion.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblPorcPromocion.Text = "% DESC PROMOCION"
        Me.lblPorcPromocion.Top = 0.0625!
        Me.lblPorcPromocion.Width = 0.9375!
        '
        'Line5
        '
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.4375!
        Me.Line5.Left = 6.177083!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 6.177083!
        Me.Line5.X2 = 6.177083!
        Me.Line5.Y1 = 0.0!
        Me.Line5.Y2 = 0.4375!
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
        Me.lblExistencia.Height = 0.3125!
        Me.lblExistencia.HyperLink = ""
        Me.lblExistencia.Left = 6.239583!
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblExistencia.Text = "EXISTENCIA TOTAL"
        Me.lblExistencia.Top = 0.0625!
        Me.lblExistencia.Width = 0.9375!
        '
        'Detalle
        '
        Me.Detalle.ColumnSpacing = 0.0!
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSivRepuestoID1, Me.txtDescripcion1, Me.txtTipoRepuesto1, Me.txtMarca1, Me.txtPrecio1, Me.txtDescuentoPromocion1, Me.txtExistenciaTotal1, Me.lnLeft, Me.lnDetalle1, Me.lnDetalle2, Me.lnDetalle3, Me.lnDetalle4, Me.lnDetalle5, Me.lnDetalle6, Me.lnRight})
        Me.Detalle.Height = 0.1875!
        Me.Detalle.Name = "Detalle"
        '
        'txtSivRepuestoID1
        '
        Me.txtSivRepuestoID1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSivRepuestoID1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivRepuestoID1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSivRepuestoID1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivRepuestoID1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSivRepuestoID1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivRepuestoID1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSivRepuestoID1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivRepuestoID1.DataField = "SivRepuestoID"
        Me.txtSivRepuestoID1.Height = 0.1875!
        Me.txtSivRepuestoID1.Left = 0.1145833!
        Me.txtSivRepuestoID1.Name = "txtSivRepuestoID1"
        Me.txtSivRepuestoID1.Style = "text-align: right; "
        Me.txtSivRepuestoID1.Text = "txtSivRepuestoID1"
        Me.txtSivRepuestoID1.Top = 0.0!
        Me.txtSivRepuestoID1.Width = 0.8125!
        '
        'txtDescripcion1
        '
        Me.txtDescripcion1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescripcion1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcion1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescripcion1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcion1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescripcion1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcion1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescripcion1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcion1.DataField = "Descripcion"
        Me.txtDescripcion1.Height = 0.1875!
        Me.txtDescripcion1.Left = 1.03125!
        Me.txtDescripcion1.Name = "txtDescripcion1"
        Me.txtDescripcion1.Style = ""
        Me.txtDescripcion1.Text = "txtDescripcion1"
        Me.txtDescripcion1.Top = 0.0!
        Me.txtDescripcion1.Width = 1.8125!
        '
        'txtTipoRepuesto1
        '
        Me.txtTipoRepuesto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTipoRepuesto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTipoRepuesto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTipoRepuesto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTipoRepuesto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtTipoRepuesto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTipoRepuesto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtTipoRepuesto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTipoRepuesto1.DataField = "TipoRepuesto"
        Me.txtTipoRepuesto1.Height = 0.1875!
        Me.txtTipoRepuesto1.Left = 2.875!
        Me.txtTipoRepuesto1.Name = "txtTipoRepuesto1"
        Me.txtTipoRepuesto1.Style = "text-align: center; "
        Me.txtTipoRepuesto1.Text = "txtTipoRepuesto1"
        Me.txtTipoRepuesto1.Top = 0.0!
        Me.txtTipoRepuesto1.Width = 0.8125!
        '
        'txtMarca1
        '
        Me.txtMarca1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMarca1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMarca1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca1.Border.RightColor = System.Drawing.Color.Black
        Me.txtMarca1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca1.Border.TopColor = System.Drawing.Color.Black
        Me.txtMarca1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca1.DataField = "Marca"
        Me.txtMarca1.Height = 0.1875!
        Me.txtMarca1.Left = 3.770833!
        Me.txtMarca1.Name = "txtMarca1"
        Me.txtMarca1.Style = "text-align: center; "
        Me.txtMarca1.Text = "txtMarca1"
        Me.txtMarca1.Top = 0.0!
        Me.txtMarca1.Width = 0.6875!
        '
        'txtPrecio1
        '
        Me.txtPrecio1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPrecio1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecio1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPrecio1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecio1.Border.RightColor = System.Drawing.Color.Black
        Me.txtPrecio1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecio1.Border.TopColor = System.Drawing.Color.Black
        Me.txtPrecio1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrecio1.DataField = "Precio"
        Me.txtPrecio1.Height = 0.1875!
        Me.txtPrecio1.Left = 4.5!
        Me.txtPrecio1.Name = "txtPrecio1"
        Me.txtPrecio1.OutputFormat = resources.GetString("txtPrecio1.OutputFormat")
        Me.txtPrecio1.Style = "text-align: right; "
        Me.txtPrecio1.Text = "txtPrecio1"
        Me.txtPrecio1.Top = 0.0!
        Me.txtPrecio1.Width = 0.625!
        '
        'txtDescuentoPromocion1
        '
        Me.txtDescuentoPromocion1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescuentoPromocion1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescuentoPromocion1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescuentoPromocion1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescuentoPromocion1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescuentoPromocion1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescuentoPromocion1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescuentoPromocion1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescuentoPromocion1.DataField = "DescuentoPromocion"
        Me.txtDescuentoPromocion1.Height = 0.1875!
        Me.txtDescuentoPromocion1.Left = 5.25!
        Me.txtDescuentoPromocion1.Name = "txtDescuentoPromocion1"
        Me.txtDescuentoPromocion1.OutputFormat = resources.GetString("txtDescuentoPromocion1.OutputFormat")
        Me.txtDescuentoPromocion1.Style = "text-align: right; "
        Me.txtDescuentoPromocion1.Text = "txtDescuentoPromocion1"
        Me.txtDescuentoPromocion1.Top = 0.0!
        Me.txtDescuentoPromocion1.Width = 0.875!
        '
        'txtExistenciaTotal1
        '
        Me.txtExistenciaTotal1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtExistenciaTotal1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExistenciaTotal1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtExistenciaTotal1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExistenciaTotal1.Border.RightColor = System.Drawing.Color.Black
        Me.txtExistenciaTotal1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExistenciaTotal1.Border.TopColor = System.Drawing.Color.Black
        Me.txtExistenciaTotal1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExistenciaTotal1.DataField = "ExistenciaTotal"
        Me.txtExistenciaTotal1.Height = 0.1875!
        Me.txtExistenciaTotal1.Left = 6.229167!
        Me.txtExistenciaTotal1.Name = "txtExistenciaTotal1"
        Me.txtExistenciaTotal1.Style = "text-align: right; "
        Me.txtExistenciaTotal1.Text = "txtExistenciaTotal1"
        Me.txtExistenciaTotal1.Top = 0.0!
        Me.txtExistenciaTotal1.Width = 0.875!
        '
        'Pie_Pagina
        '
        Me.Pie_Pagina.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
        Me.Pie_Pagina.Height = 0.1875!
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
        Me.ReportInfo1.Left = 5.1875!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: Gray; ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 2.0!
        '
        'Encabezado_Reporte
        '
        Me.Encabezado_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srptEncabezado, Me.lblTitulo, Me.lblTienda, Me.txtTienda1})
        Me.Encabezado_Reporte.Height = 1.802083!
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
        Me.srptEncabezado.Left = 0.0!
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
        Me.lblTitulo.Text = "LISTADO DE PRECIOS"
        Me.lblTitulo.Top = 1.25!
        Me.lblTitulo.Width = 7.125!
        '
        'Pie_Reporte
        '
        Me.Pie_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line6})
        Me.Pie_Reporte.Height = 0.0!
        Me.Pie_Reporte.Name = "Pie_Reporte"
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
        Me.lnLeft.Left = 0.0625!
        Me.lnLeft.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnLeft.LineWeight = 1.0!
        Me.lnLeft.Name = "lnLeft"
        Me.lnLeft.Top = 0.0!
        Me.lnLeft.Width = 0.0!
        Me.lnLeft.X1 = 0.0625!
        Me.lnLeft.X2 = 0.0625!
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
        Me.lnDetalle1.Left = 1.0!
        Me.lnDetalle1.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle1.LineWeight = 1.0!
        Me.lnDetalle1.Name = "lnDetalle1"
        Me.lnDetalle1.Top = 0.0!
        Me.lnDetalle1.Width = 0.0!
        Me.lnDetalle1.X1 = 1.0!
        Me.lnDetalle1.X2 = 1.0!
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
        Me.lnDetalle2.Left = 2.864583!
        Me.lnDetalle2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle2.LineWeight = 1.0!
        Me.lnDetalle2.Name = "lnDetalle2"
        Me.lnDetalle2.Top = 0.0!
        Me.lnDetalle2.Width = 0.0!
        Me.lnDetalle2.X1 = 2.864583!
        Me.lnDetalle2.X2 = 2.864583!
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
        Me.lnDetalle3.Left = 3.75!
        Me.lnDetalle3.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle3.LineWeight = 1.0!
        Me.lnDetalle3.Name = "lnDetalle3"
        Me.lnDetalle3.Top = 0.0!
        Me.lnDetalle3.Width = 0.0!
        Me.lnDetalle3.X1 = 3.75!
        Me.lnDetalle3.X2 = 3.75!
        Me.lnDetalle3.Y1 = 0.0!
        Me.lnDetalle3.Y2 = 0.1875!
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
        Me.lnDetalle4.Left = 4.5!
        Me.lnDetalle4.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle4.LineWeight = 1.0!
        Me.lnDetalle4.Name = "lnDetalle4"
        Me.lnDetalle4.Top = 0.0!
        Me.lnDetalle4.Width = 0.0!
        Me.lnDetalle4.X1 = 4.5!
        Me.lnDetalle4.X2 = 4.5!
        Me.lnDetalle4.Y1 = 0.0!
        Me.lnDetalle4.Y2 = 0.1875!
        '
        'lnDetalle5
        '
        Me.lnDetalle5.AnchorBottom = True
        Me.lnDetalle5.Border.BottomColor = System.Drawing.Color.Black
        Me.lnDetalle5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle5.Border.LeftColor = System.Drawing.Color.Black
        Me.lnDetalle5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle5.Border.RightColor = System.Drawing.Color.Black
        Me.lnDetalle5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle5.Border.TopColor = System.Drawing.Color.Black
        Me.lnDetalle5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle5.Height = 0.1875!
        Me.lnDetalle5.Left = 5.1875!
        Me.lnDetalle5.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle5.LineWeight = 1.0!
        Me.lnDetalle5.Name = "lnDetalle5"
        Me.lnDetalle5.Top = 0.0!
        Me.lnDetalle5.Width = 0.0!
        Me.lnDetalle5.X1 = 5.1875!
        Me.lnDetalle5.X2 = 5.1875!
        Me.lnDetalle5.Y1 = 0.0!
        Me.lnDetalle5.Y2 = 0.1875!
        '
        'lnDetalle6
        '
        Me.lnDetalle6.AnchorBottom = True
        Me.lnDetalle6.Border.BottomColor = System.Drawing.Color.Black
        Me.lnDetalle6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle6.Border.LeftColor = System.Drawing.Color.Black
        Me.lnDetalle6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle6.Border.RightColor = System.Drawing.Color.Black
        Me.lnDetalle6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle6.Border.TopColor = System.Drawing.Color.Black
        Me.lnDetalle6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnDetalle6.Height = 0.1875!
        Me.lnDetalle6.Left = 6.1875!
        Me.lnDetalle6.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle6.LineWeight = 1.0!
        Me.lnDetalle6.Name = "lnDetalle6"
        Me.lnDetalle6.Top = 0.0!
        Me.lnDetalle6.Width = 0.0!
        Me.lnDetalle6.X1 = 6.1875!
        Me.lnDetalle6.X2 = 6.1875!
        Me.lnDetalle6.Y1 = 0.0!
        Me.lnDetalle6.Y2 = 0.1875!
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
        Me.lnRight.Left = 7.1875!
        Me.lnRight.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnRight.LineWeight = 1.0!
        Me.lnRight.Name = "lnRight"
        Me.lnRight.Top = 0.0!
        Me.lnRight.Width = 0.0!
        Me.lnRight.X1 = 7.1875!
        Me.lnRight.X2 = 7.1875!
        Me.lnRight.Y1 = 0.0!
        Me.lnRight.Y2 = 0.1875!
        '
        'Line6
        '
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.0625!
        Me.Line6.LineColor = System.Drawing.Color.Silver
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.0!
        Me.Line6.Width = 7.125!
        Me.Line6.X1 = 0.0625!
        Me.Line6.X2 = 7.1875!
        Me.Line6.Y1 = 0.0!
        Me.Line6.Y2 = 0.0!
        '
        'lblTienda
        '
        Me.lblTienda.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTienda.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTienda.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTienda.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTienda.Border.RightColor = System.Drawing.Color.Black
        Me.lblTienda.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTienda.Border.TopColor = System.Drawing.Color.Black
        Me.lblTienda.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTienda.Height = 0.1875!
        Me.lblTienda.HyperLink = Nothing
        Me.lblTienda.Left = 1.9375!
        Me.lblTienda.Name = "lblTienda"
        Me.lblTienda.Style = "text-align: right; font-weight: bold; "
        Me.lblTienda.Text = "Bodega:"
        Me.lblTienda.Top = 1.5625!
        Me.lblTienda.Width = 1.375!
        '
        'txtTienda1
        '
        Me.txtTienda1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTienda1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTienda1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTienda1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTienda1.Border.RightColor = System.Drawing.Color.Black
        Me.txtTienda1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTienda1.Border.TopColor = System.Drawing.Color.Black
        Me.txtTienda1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTienda1.DataField = "Tienda"
        Me.txtTienda1.Height = 0.1875!
        Me.txtTienda1.Left = 3.375!
        Me.txtTienda1.Name = "txtTienda1"
        Me.txtTienda1.Style = "color: DimGray; "
        Me.txtTienda1.Text = "txtTienda1"
        Me.txtTienda1.Top = 1.5625!
        Me.txtTienda1.Width = 2.0625!
        '
        'rptFacturacionListadoPrecios
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Ca" & _
            "talog=SIFUM;Data Source=192.168.1.1"
        OleDBDataSource1.SQL = "Select * from vwRptFacturacionListadoPrecios"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.5!
        Me.Sections.Add(Me.Encabezado_Reporte)
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_Pagina)
        Me.Sections.Add(Me.Pie_Reporte)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTipoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPorcPromocion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivRepuestoID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoRepuesto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoPromocion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistenciaTotal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTienda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Encabezado_Reporte As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Pie_Reporte As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents srptEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents shpFondo As DataDynamics.ActiveReports.Shape
    Friend WithEvents lblCodigo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDescripcion As DataDynamics.ActiveReports.Label
    Friend WithEvents lblMarca As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTipoRepuesto As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line9 As DataDynamics.ActiveReports.Line
    Friend WithEvents lblPrecio As DataDynamics.ActiveReports.Label
    Friend WithEvents lblPorcPromocion As DataDynamics.ActiveReports.Label
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents lblExistencia As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSivRepuestoID1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescripcion1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTipoRepuesto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtMarca1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrecio1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescuentoPromocion1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtExistenciaTotal1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents lnLeft As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle1 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle2 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle3 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle4 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle5 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle6 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnRight As DataDynamics.ActiveReports.Line
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents lblTienda As DataDynamics.ActiveReports.Label
    Friend WithEvents txtTienda1 As DataDynamics.ActiveReports.TextBox
End Class 
