<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptTransferenciaRecepcion 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptTransferenciaRecepcion))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.shpFondo = New DataDynamics.ActiveReports.Shape
        Me.lblCodigo = New DataDynamics.ActiveReports.Label
        Me.lblDescripcion = New DataDynamics.ActiveReports.Label
        Me.lblCantidadDespachada = New DataDynamics.ActiveReports.Label
        Me.lblCantidadSolicitada = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.lblCantidadRecibida = New DataDynamics.ActiveReports.Label
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.lnLeft = New DataDynamics.ActiveReports.Line
        Me.lnRight = New DataDynamics.ActiveReports.Line
        Me.lnDetalle4 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle3 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle2 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle1 = New DataDynamics.ActiveReports.Line
        Me.lnDetalle5 = New DataDynamics.ActiveReports.Line
        Me.txtSivRepuestoID1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescripcionCorta1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidadSolicitada1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidadDespachada1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidadRecibida1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Encabezado_Reporte = New DataDynamics.ActiveReports.ReportHeader
        Me.srptEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.lblNoTransferencia = New DataDynamics.ActiveReports.Label
        Me.lblSitioOrigen = New DataDynamics.ActiveReports.Label
        Me.lblSitioDestino = New DataDynamics.ActiveReports.Label
        Me.lblSolicitadoPor = New DataDynamics.ActiveReports.Label
        Me.lblFechaDespacho = New DataDynamics.ActiveReports.Label
        Me.lblAnulada = New DataDynamics.ActiveReports.Label
        Me.chkAnulada = New DataDynamics.ActiveReports.CheckBox
        Me.lblFechaSolicitud = New DataDynamics.ActiveReports.Label
        Me.txtSivTransferenciaID1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSitioOrigen1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSitioDestino1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSolicitadoPor1 = New DataDynamics.ActiveReports.TextBox
        Me.txtFechasolicitud1 = New DataDynamics.ActiveReports.TextBox
        Me.txtFechadespacho1 = New DataDynamics.ActiveReports.TextBox
        Me.lblDespachadaPor = New DataDynamics.ActiveReports.Label
        Me.txtDespachadoPor1 = New DataDynamics.ActiveReports.TextBox
        Me.lblRecepcionadoPor = New DataDynamics.ActiveReports.Label
        Me.lblFechaRepcion = New DataDynamics.ActiveReports.Label
        Me.txtRecibidoPor = New DataDynamics.ActiveReports.TextBox
        Me.txtFecharecibido1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_Reporte = New DataDynamics.ActiveReports.ReportFooter
        Me.Encabezado_Grupo = New DataDynamics.ActiveReports.GroupHeader
        Me.Pie_grupo = New DataDynamics.ActiveReports.GroupFooter
        Me.lnPieDetalle = New DataDynamics.ActiveReports.Line
        Me.lblObservaciones = New DataDynamics.ActiveReports.Label
        Me.shpObservaciones = New DataDynamics.ActiveReports.Shape
        Me.lnFirma = New DataDynamics.ActiveReports.Line
        Me.lblFirmRecibidoPor = New DataDynamics.ActiveReports.Label
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.lblFirmaEntregadoPor = New DataDynamics.ActiveReports.Label
        Me.txtObservaciones1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSolicitadoPor2 = New DataDynamics.ActiveReports.TextBox
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidadDespachada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidadSolicitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidadRecibida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivRepuestoID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCorta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadSolicitada1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadDespachada1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadRecibida1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSitioDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSolicitadoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFechaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAnulada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAnulada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFechaSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivTransferenciaID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitioOrigen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitioDestino1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSolicitadoPor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechasolicitud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechadespacho1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDespachadaPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDespachadoPor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecepcionadoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFechaRepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecibidoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecharecibido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFirmRecibidoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFirmaEntregadoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSolicitadoPor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Encabezado_Pagina
        '
        Me.Encabezado_Pagina.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.shpFondo, Me.lblCodigo, Me.lblDescripcion, Me.lblCantidadDespachada, Me.lblCantidadSolicitada, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line9, Me.lblCantidadRecibida})
        Me.Encabezado_Pagina.Height = 0.4375!
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
        Me.shpFondo.Left = 0.125!
        Me.shpFondo.Name = "shpFondo"
        Me.shpFondo.RoundingRadius = 9.999999!
        Me.shpFondo.Top = 0.0!
        Me.shpFondo.Width = 7.25!
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
        Me.lblCodigo.Left = 0.25!
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Style = "text-align: center; font-weight: bold; "
        Me.lblCodigo.Text = "Código"
        Me.lblCodigo.Top = 0.125!
        Me.lblCodigo.Width = 0.8125!
        '
        'lblCodigoProveedor
        '

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
        Me.lblDescripcion.Left = 2.3125!
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Style = "text-align: center; font-weight: bold; vertical-align: top; "
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.Top = 0.125!
        Me.lblDescripcion.Width = 2.0!
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
        Me.lblCantidadDespachada.Height = 0.375!
        Me.lblCantidadDespachada.HyperLink = ""
        Me.lblCantidadDespachada.Left = 5.46875!
        Me.lblCantidadDespachada.Name = "lblCantidadDespachada"
        Me.lblCantidadDespachada.Style = "text-align: center; font-weight: bold; vertical-align: top; "
        Me.lblCantidadDespachada.Text = "Cantidad Despachada"
        Me.lblCantidadDespachada.Top = 0.03125!
        Me.lblCantidadDespachada.Width = 0.875!
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
        Me.lblCantidadSolicitada.Height = 0.3125!
        Me.lblCantidadSolicitada.HyperLink = ""
        Me.lblCantidadSolicitada.Left = 4.5!
        Me.lblCantidadSolicitada.Name = "lblCantidadSolicitada"
        Me.lblCantidadSolicitada.Style = "text-align: center; font-weight: bold; vertical-align: top; "
        Me.lblCantidadSolicitada.Text = "Cantidad Solicitada"
        Me.lblCantidadSolicitada.Top = 0.04166667!
        Me.lblCantidadSolicitada.Width = 0.8125!
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
        Me.Line1.Left = 1.125!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 1.125!
        Me.Line1.X2 = 1.125!
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
        Me.Line2.Left = 2.125!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 2.125!
        Me.Line2.X2 = 2.125!
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
        Me.Line3.Left = 4.375!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 4.375!
        Me.Line3.X2 = 4.375!
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
        Me.Line4.Left = 5.375!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 5.375!
        Me.Line4.X2 = 5.375!
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
        Me.Line9.Left = 6.375!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.0!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 6.375!
        Me.Line9.X2 = 6.375!
        Me.Line9.Y1 = 0.0!
        Me.Line9.Y2 = 0.4375!
        '
        'lblCantidadRecibida
        '
        Me.lblCantidadRecibida.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCantidadRecibida.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadRecibida.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCantidadRecibida.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadRecibida.Border.RightColor = System.Drawing.Color.Black
        Me.lblCantidadRecibida.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadRecibida.Border.TopColor = System.Drawing.Color.Black
        Me.lblCantidadRecibida.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCantidadRecibida.Height = 0.375!
        Me.lblCantidadRecibida.HyperLink = ""
        Me.lblCantidadRecibida.Left = 6.4375!
        Me.lblCantidadRecibida.Name = "lblCantidadRecibida"
        Me.lblCantidadRecibida.Style = "text-align: center; font-weight: bold; vertical-align: top; "
        Me.lblCantidadRecibida.Text = "Cantidad Recibida"
        Me.lblCantidadRecibida.Top = 0.03125!
        Me.lblCantidadRecibida.Width = 0.875!
        '
        'Detalle
        '
        Me.Detalle.ColumnSpacing = 0.0!
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lnLeft, Me.lnRight, Me.lnDetalle4, Me.lnDetalle3, Me.lnDetalle2, Me.lnDetalle1, Me.lnDetalle5, Me.txtSivRepuestoID1, Me.txtDescripcionCorta1, Me.txtCantidadSolicitada1, Me.txtCantidadDespachada1, Me.txtCantidadRecibida1})
        Me.Detalle.Height = 0.1875!
        Me.Detalle.Name = "Detalle"
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
        Me.lnLeft.Left = 0.125!
        Me.lnLeft.LineColor = System.Drawing.Color.Silver
        Me.lnLeft.LineWeight = 1.0!
        Me.lnLeft.Name = "lnLeft"
        Me.lnLeft.Top = 0.0!
        Me.lnLeft.Width = 0.0!
        Me.lnLeft.X1 = 0.125!
        Me.lnLeft.X2 = 0.125!
        Me.lnLeft.Y1 = 0.0!
        Me.lnLeft.Y2 = 0.1875!
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
        Me.lnRight.Left = 7.375!
        Me.lnRight.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnRight.LineWeight = 1.0!
        Me.lnRight.Name = "lnRight"
        Me.lnRight.Top = 0.0!
        Me.lnRight.Width = 0.0!
        Me.lnRight.X1 = 7.375!
        Me.lnRight.X2 = 7.375!
        Me.lnRight.Y1 = 0.0!
        Me.lnRight.Y2 = 0.1875!
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
        Me.lnDetalle4.Left = 5.375!
        Me.lnDetalle4.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle4.LineWeight = 1.0!
        Me.lnDetalle4.Name = "lnDetalle4"
        Me.lnDetalle4.Top = 0.0!
        Me.lnDetalle4.Width = 0.0!
        Me.lnDetalle4.X1 = 5.375!
        Me.lnDetalle4.X2 = 5.375!
        Me.lnDetalle4.Y1 = 0.0!
        Me.lnDetalle4.Y2 = 0.1875!
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
        Me.lnDetalle3.Left = 4.375!
        Me.lnDetalle3.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle3.LineWeight = 1.0!
        Me.lnDetalle3.Name = "lnDetalle3"
        Me.lnDetalle3.Top = 0.0!
        Me.lnDetalle3.Width = 0.0!
        Me.lnDetalle3.X1 = 4.375!
        Me.lnDetalle3.X2 = 4.375!
        Me.lnDetalle3.Y1 = 0.0!
        Me.lnDetalle3.Y2 = 0.1875!
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
        Me.lnDetalle2.Left = 2.125!
        Me.lnDetalle2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle2.LineWeight = 1.0!
        Me.lnDetalle2.Name = "lnDetalle2"
        Me.lnDetalle2.Top = 0.0!
        Me.lnDetalle2.Width = 0.0!
        Me.lnDetalle2.X1 = 2.125!
        Me.lnDetalle2.X2 = 2.125!
        Me.lnDetalle2.Y1 = 0.0!
        Me.lnDetalle2.Y2 = 0.1875!
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
        Me.lnDetalle1.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle1.LineWeight = 1.0!
        Me.lnDetalle1.Name = "lnDetalle1"
        Me.lnDetalle1.Top = 0.0!
        Me.lnDetalle1.Width = 0.0!
        Me.lnDetalle1.X1 = 1.125!
        Me.lnDetalle1.X2 = 1.125!
        Me.lnDetalle1.Y1 = 0.0!
        Me.lnDetalle1.Y2 = 0.1875!
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
        Me.lnDetalle5.Left = 6.375!
        Me.lnDetalle5.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnDetalle5.LineWeight = 1.0!
        Me.lnDetalle5.Name = "lnDetalle5"
        Me.lnDetalle5.Top = 0.0!
        Me.lnDetalle5.Width = 0.0!
        Me.lnDetalle5.X1 = 6.375!
        Me.lnDetalle5.X2 = 6.375!
        Me.lnDetalle5.Y1 = 0.0!
        Me.lnDetalle5.Y2 = 0.1875!
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
        Me.txtSivRepuestoID1.DataField = "SivProductoID"
        Me.txtSivRepuestoID1.Height = 0.1875!
        Me.txtSivRepuestoID1.Left = 0.1770833!
        Me.txtSivRepuestoID1.Name = "txtSivRepuestoID1"
        Me.txtSivRepuestoID1.Style = "text-align: right; "
        Me.txtSivRepuestoID1.Text = "txtSivRepuestoID1"
        Me.txtSivRepuestoID1.Top = 0.0!
        Me.txtSivRepuestoID1.Width = 0.875!
        '
        'txtDescripcionCorta1
        '
        Me.txtDescripcionCorta1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescripcionCorta1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcionCorta1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescripcionCorta1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcionCorta1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescripcionCorta1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcionCorta1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescripcionCorta1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescripcionCorta1.DataField = "Producto"
        Me.txtDescripcionCorta1.Height = 0.1875!
        Me.txtDescripcionCorta1.Left = 2.177083!
        Me.txtDescripcionCorta1.Name = "txtDescripcionCorta1"
        Me.txtDescripcionCorta1.Style = ""
        Me.txtDescripcionCorta1.Text = "txtDescripcionCorta1"
        Me.txtDescripcionCorta1.Top = 0.0!
        Me.txtDescripcionCorta1.Width = 2.125!
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
        Me.txtCantidadSolicitada1.Left = 4.4375!
        Me.txtCantidadSolicitada1.Name = "txtCantidadSolicitada1"
        Me.txtCantidadSolicitada1.Style = "text-align: right; "
        Me.txtCantidadSolicitada1.Text = "txtCantidadSolicitada1"
        Me.txtCantidadSolicitada1.Top = 0.0!
        Me.txtCantidadSolicitada1.Width = 0.875!
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
        Me.txtCantidadDespachada1.Left = 5.427083!
        Me.txtCantidadDespachada1.Name = "txtCantidadDespachada1"
        Me.txtCantidadDespachada1.Style = "text-align: right; "
        Me.txtCantidadDespachada1.Text = "txtCantidadDespachada1"
        Me.txtCantidadDespachada1.Top = 0.0!
        Me.txtCantidadDespachada1.Width = 0.875!
        '
        'txtCantidadRecibida1
        '
        Me.txtCantidadRecibida1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCantidadRecibida1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadRecibida1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCantidadRecibida1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadRecibida1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCantidadRecibida1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadRecibida1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCantidadRecibida1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadRecibida1.DataField = "CantidadRecibida"
        Me.txtCantidadRecibida1.Height = 0.1875!
        Me.txtCantidadRecibida1.Left = 6.4375!
        Me.txtCantidadRecibida1.Name = "txtCantidadRecibida1"
        Me.txtCantidadRecibida1.Style = "text-align: right; "
        Me.txtCantidadRecibida1.Text = "txtCantidadRecibida1"
        Me.txtCantidadRecibida1.Top = 0.0!
        Me.txtCantidadRecibida1.Width = 0.875!
        '
        'txtCodigosProveedores1
        '
       
        '
        'Pie_Pagina
        '
        Me.Pie_Pagina.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
        Me.Pie_Pagina.Height = 0.1770833!
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
        Me.ReportInfo1.Left = 5.25!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: DimGray; ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 2.0!
        '
        'Encabezado_Reporte
        '
        Me.Encabezado_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srptEncabezado, Me.lblTitulo, Me.lblNoTransferencia, Me.lblSitioOrigen, Me.lblSitioDestino, Me.lblSolicitadoPor, Me.lblFechaDespacho, Me.lblAnulada, Me.chkAnulada, Me.lblFechaSolicitud, Me.txtSivTransferenciaID1, Me.txtSitioOrigen1, Me.txtSitioDestino1, Me.txtSolicitadoPor1, Me.txtFechasolicitud1, Me.txtFechadespacho1, Me.lblDespachadaPor, Me.txtDespachadoPor1, Me.lblRecepcionadoPor, Me.lblFechaRepcion, Me.txtRecibidoPor, Me.txtFecharecibido1})
        Me.Encabezado_Reporte.Height = 2.90625!
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
        Me.lblTitulo.Left = 0.1875!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "color: SteelBlue; ddo-char-set: 1; text-align: center; font-weight: bold; font-si" & _
            "ze: 14.25pt; font-family: Times New Roman; vertical-align: middle; "
        Me.lblTitulo.Text = "RECEPCION DE TRASLADO"
        Me.lblTitulo.Top = 1.25!
        Me.lblTitulo.Width = 7.25!
        '
        'lblNoTransferencia
        '
        Me.lblNoTransferencia.Border.BottomColor = System.Drawing.Color.Black
        Me.lblNoTransferencia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoTransferencia.Border.LeftColor = System.Drawing.Color.Black
        Me.lblNoTransferencia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoTransferencia.Border.RightColor = System.Drawing.Color.Black
        Me.lblNoTransferencia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoTransferencia.Border.TopColor = System.Drawing.Color.Black
        Me.lblNoTransferencia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNoTransferencia.Height = 0.1875!
        Me.lblNoTransferencia.HyperLink = Nothing
        Me.lblNoTransferencia.Left = 0.25!
        Me.lblNoTransferencia.Name = "lblNoTransferencia"
        Me.lblNoTransferencia.Style = ""
        Me.lblNoTransferencia.Text = "# Transferencia:"
        Me.lblNoTransferencia.Top = 2.0!
        Me.lblNoTransferencia.Width = 1.0625!
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
        Me.lblSitioOrigen.HyperLink = ""
        Me.lblSitioOrigen.Left = 0.25!
        Me.lblSitioOrigen.Name = "lblSitioOrigen"
        Me.lblSitioOrigen.Style = ""
        Me.lblSitioOrigen.Text = "Sitio Origen:"
        Me.lblSitioOrigen.Top = 2.25!
        Me.lblSitioOrigen.Width = 1.0625!
        '
        'lblSitioDestino
        '
        Me.lblSitioDestino.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSitioDestino.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSitioDestino.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSitioDestino.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSitioDestino.Border.RightColor = System.Drawing.Color.Black
        Me.lblSitioDestino.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSitioDestino.Border.TopColor = System.Drawing.Color.Black
        Me.lblSitioDestino.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSitioDestino.Height = 0.1875!
        Me.lblSitioDestino.HyperLink = ""
        Me.lblSitioDestino.Left = 0.25!
        Me.lblSitioDestino.Name = "lblSitioDestino"
        Me.lblSitioDestino.Style = ""
        Me.lblSitioDestino.Text = "Sitio Destino:"
        Me.lblSitioDestino.Top = 2.5!
        Me.lblSitioDestino.Width = 1.0625!
        '
        'lblSolicitadoPor
        '
        Me.lblSolicitadoPor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSolicitadoPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSolicitadoPor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSolicitadoPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSolicitadoPor.Border.RightColor = System.Drawing.Color.Black
        Me.lblSolicitadoPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSolicitadoPor.Border.TopColor = System.Drawing.Color.Black
        Me.lblSolicitadoPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSolicitadoPor.Height = 0.1875!
        Me.lblSolicitadoPor.HyperLink = ""
        Me.lblSolicitadoPor.Left = 2.770833!
        Me.lblSolicitadoPor.Name = "lblSolicitadoPor"
        Me.lblSolicitadoPor.Style = ""
        Me.lblSolicitadoPor.Text = "Solicitado Por:"
        Me.lblSolicitadoPor.Top = 2.270833!
        Me.lblSolicitadoPor.Width = 0.9375!
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
        Me.lblFechaDespacho.HyperLink = ""
        Me.lblFechaDespacho.Left = 5.375!
        Me.lblFechaDespacho.Name = "lblFechaDespacho"
        Me.lblFechaDespacho.Style = ""
        Me.lblFechaDespacho.Text = "Fecha Desp:"
        Me.lblFechaDespacho.Top = 1.9375!
        Me.lblFechaDespacho.Width = 0.9375!
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
        Me.lblAnulada.HyperLink = ""
        Me.lblAnulada.Left = 6.5!
        Me.lblAnulada.Name = "lblAnulada"
        Me.lblAnulada.Style = ""
        Me.lblAnulada.Text = "Anulado"
        Me.lblAnulada.Top = 1.625!
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
        Me.chkAnulada.Height = 0.1875!
        Me.chkAnulada.Left = 7.0!
        Me.chkAnulada.Name = "chkAnulada"
        Me.chkAnulada.Style = ""
        Me.chkAnulada.Text = ""
        Me.chkAnulada.Top = 1.625!
        Me.chkAnulada.Width = 0.25!
        '
        'lblFechaSolicitud
        '
        Me.lblFechaSolicitud.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFechaSolicitud.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaSolicitud.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFechaSolicitud.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaSolicitud.Border.RightColor = System.Drawing.Color.Black
        Me.lblFechaSolicitud.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaSolicitud.Border.TopColor = System.Drawing.Color.Black
        Me.lblFechaSolicitud.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaSolicitud.Height = 0.1875!
        Me.lblFechaSolicitud.HyperLink = ""
        Me.lblFechaSolicitud.Left = 5.375!
        Me.lblFechaSolicitud.Name = "lblFechaSolicitud"
        Me.lblFechaSolicitud.Style = ""
        Me.lblFechaSolicitud.Text = "Fecha Sol:"
        Me.lblFechaSolicitud.Top = 2.229167!
        Me.lblFechaSolicitud.Width = 0.9375!
        '
        'txtSivTransferenciaID1
        '
        Me.txtSivTransferenciaID1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSivTransferenciaID1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivTransferenciaID1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSivTransferenciaID1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivTransferenciaID1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSivTransferenciaID1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivTransferenciaID1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSivTransferenciaID1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivTransferenciaID1.DataField = "SivTransferenciaID"
        Me.txtSivTransferenciaID1.Height = 0.2!
        Me.txtSivTransferenciaID1.Left = 1.3125!
        Me.txtSivTransferenciaID1.Name = "txtSivTransferenciaID1"
        Me.txtSivTransferenciaID1.Style = "color: DimGray; "
        Me.txtSivTransferenciaID1.Text = "txtSivTransferenciaID1"
        Me.txtSivTransferenciaID1.Top = 2.0!
        Me.txtSivTransferenciaID1.Width = 1.0!
        '
        'txtSitioOrigen1
        '
        Me.txtSitioOrigen1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSitioOrigen1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioOrigen1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSitioOrigen1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioOrigen1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSitioOrigen1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioOrigen1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSitioOrigen1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioOrigen1.DataField = "SitioOrigen"
        Me.txtSitioOrigen1.Height = 0.2!
        Me.txtSitioOrigen1.Left = 1.3125!
        Me.txtSitioOrigen1.Name = "txtSitioOrigen1"
        Me.txtSitioOrigen1.Style = "color: DimGray; "
        Me.txtSitioOrigen1.Text = "txtSitioOrigen1"
        Me.txtSitioOrigen1.Top = 2.25!
        Me.txtSitioOrigen1.Width = 1.0!
        '
        'txtSitioDestino1
        '
        Me.txtSitioDestino1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSitioDestino1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioDestino1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSitioDestino1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioDestino1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSitioDestino1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioDestino1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSitioDestino1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSitioDestino1.DataField = "SitioDestino"
        Me.txtSitioDestino1.Height = 0.2!
        Me.txtSitioDestino1.Left = 1.3125!
        Me.txtSitioDestino1.Name = "txtSitioDestino1"
        Me.txtSitioDestino1.Style = "color: DimGray; "
        Me.txtSitioDestino1.Text = "txtSitioDestino1"
        Me.txtSitioDestino1.Top = 2.5!
        Me.txtSitioDestino1.Width = 1.0!
        '
        'txtSolicitadoPor1
        '
        Me.txtSolicitadoPor1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSolicitadoPor1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSolicitadoPor1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSolicitadoPor1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSolicitadoPor1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSolicitadoPor1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSolicitadoPor1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSolicitadoPor1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSolicitadoPor1.DataField = "SolicitadoPor"
        Me.txtSolicitadoPor1.Height = 0.2!
        Me.txtSolicitadoPor1.Left = 3.9375!
        Me.txtSolicitadoPor1.Name = "txtSolicitadoPor1"
        Me.txtSolicitadoPor1.Style = "color: DimGray; "
        Me.txtSolicitadoPor1.Text = "txtSolicitadoPor1"
        Me.txtSolicitadoPor1.Top = 2.270833!
        Me.txtSolicitadoPor1.Width = 1.0!
        '
        'txtFechasolicitud1
        '
        Me.txtFechasolicitud1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFechasolicitud1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechasolicitud1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFechasolicitud1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechasolicitud1.Border.RightColor = System.Drawing.Color.Black
        Me.txtFechasolicitud1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechasolicitud1.Border.TopColor = System.Drawing.Color.Black
        Me.txtFechasolicitud1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechasolicitud1.DataField = "Fechasolicitud"
        Me.txtFechasolicitud1.Height = 0.2!
        Me.txtFechasolicitud1.Left = 6.1875!
        Me.txtFechasolicitud1.Name = "txtFechasolicitud1"
        Me.txtFechasolicitud1.OutputFormat = resources.GetString("txtFechasolicitud1.OutputFormat")
        Me.txtFechasolicitud1.Style = "color: DimGray; "
        Me.txtFechasolicitud1.Text = "txtFechasolicitud1"
        Me.txtFechasolicitud1.Top = 2.229167!
        Me.txtFechasolicitud1.Width = 1.0!
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
        Me.txtFechadespacho1.Left = 6.1875!
        Me.txtFechadespacho1.Name = "txtFechadespacho1"
        Me.txtFechadespacho1.OutputFormat = resources.GetString("txtFechadespacho1.OutputFormat")
        Me.txtFechadespacho1.Style = "color: DimGray; "
        Me.txtFechadespacho1.Text = "txtFechadespacho1"
        Me.txtFechadespacho1.Top = 1.9375!
        Me.txtFechadespacho1.Width = 1.0!
        '
        'lblDespachadaPor
        '
        Me.lblDespachadaPor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDespachadaPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDespachadaPor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDespachadaPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDespachadaPor.Border.RightColor = System.Drawing.Color.Black
        Me.lblDespachadaPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDespachadaPor.Border.TopColor = System.Drawing.Color.Black
        Me.lblDespachadaPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDespachadaPor.Height = 0.1875!
        Me.lblDespachadaPor.HyperLink = ""
        Me.lblDespachadaPor.Left = 2.770833!
        Me.lblDespachadaPor.Name = "lblDespachadaPor"
        Me.lblDespachadaPor.Style = ""
        Me.lblDespachadaPor.Text = "Despachado Por:"
        Me.lblDespachadaPor.Top = 1.989583!
        Me.lblDespachadaPor.Width = 1.125!
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
        Me.txtDespachadoPor1.Left = 3.9375!
        Me.txtDespachadoPor1.Name = "txtDespachadoPor1"
        Me.txtDespachadoPor1.Style = "color: DimGray; "
        Me.txtDespachadoPor1.Text = "txtDespachadoPor1"
        Me.txtDespachadoPor1.Top = 1.989583!
        Me.txtDespachadoPor1.Width = 1.0!
        '
        'lblRecepcionadoPor
        '
        Me.lblRecepcionadoPor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblRecepcionadoPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRecepcionadoPor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblRecepcionadoPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRecepcionadoPor.Border.RightColor = System.Drawing.Color.Black
        Me.lblRecepcionadoPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRecepcionadoPor.Border.TopColor = System.Drawing.Color.Black
        Me.lblRecepcionadoPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRecepcionadoPor.Height = 0.1875!
        Me.lblRecepcionadoPor.HyperLink = ""
        Me.lblRecepcionadoPor.Left = 2.770833!
        Me.lblRecepcionadoPor.Name = "lblRecepcionadoPor"
        Me.lblRecepcionadoPor.Style = ""
        Me.lblRecepcionadoPor.Text = "Recepcionado Por:"
        Me.lblRecepcionadoPor.Top = 2.5625!
        Me.lblRecepcionadoPor.Width = 1.25!
        '
        'lblFechaRepcion
        '
        Me.lblFechaRepcion.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFechaRepcion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaRepcion.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFechaRepcion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaRepcion.Border.RightColor = System.Drawing.Color.Black
        Me.lblFechaRepcion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaRepcion.Border.TopColor = System.Drawing.Color.Black
        Me.lblFechaRepcion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaRepcion.Height = 0.1875!
        Me.lblFechaRepcion.HyperLink = ""
        Me.lblFechaRepcion.Left = 5.375!
        Me.lblFechaRepcion.Name = "lblFechaRepcion"
        Me.lblFechaRepcion.Style = ""
        Me.lblFechaRepcion.Text = "Fecha Rec:"
        Me.lblFechaRepcion.Top = 2.5!
        Me.lblFechaRepcion.Width = 0.9375!
        '
        'txtRecibidoPor
        '
        Me.txtRecibidoPor.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRecibidoPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRecibidoPor.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRecibidoPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRecibidoPor.Border.RightColor = System.Drawing.Color.Black
        Me.txtRecibidoPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRecibidoPor.Border.TopColor = System.Drawing.Color.Black
        Me.txtRecibidoPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRecibidoPor.DataField = "RecibidoPor"
        Me.txtRecibidoPor.Height = 0.2!
        Me.txtRecibidoPor.Left = 3.9375!
        Me.txtRecibidoPor.Name = "txtRecibidoPor"
        Me.txtRecibidoPor.Style = "color: DimGray; "
        Me.txtRecibidoPor.Text = "txtRecibidoPor1"
        Me.txtRecibidoPor.Top = 2.5625!
        Me.txtRecibidoPor.Width = 1.0!
        '
        'txtFecharecibido1
        '
        Me.txtFecharecibido1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFecharecibido1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFecharecibido1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFecharecibido1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFecharecibido1.Border.RightColor = System.Drawing.Color.Black
        Me.txtFecharecibido1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFecharecibido1.Border.TopColor = System.Drawing.Color.Black
        Me.txtFecharecibido1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFecharecibido1.DataField = "Fecharecibido"
        Me.txtFecharecibido1.Height = 0.2!
        Me.txtFecharecibido1.Left = 6.197917!
        Me.txtFecharecibido1.Name = "txtFecharecibido1"
        Me.txtFecharecibido1.OutputFormat = resources.GetString("txtFecharecibido1.OutputFormat")
        Me.txtFecharecibido1.Style = "color: DimGray; "
        Me.txtFecharecibido1.Text = "txtFecharecibido1"
        Me.txtFecharecibido1.Top = 2.5!
        Me.txtFecharecibido1.Width = 1.0!
        '
        'Pie_Reporte
        '
        Me.Pie_Reporte.Height = 0.0!
        Me.Pie_Reporte.Name = "Pie_Reporte"
        '
        'Encabezado_Grupo
        '
        Me.Encabezado_Grupo.Height = 0.0!
        Me.Encabezado_Grupo.Name = "Encabezado_Grupo"
        '
        'Pie_grupo
        '
        Me.Pie_grupo.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lnPieDetalle, Me.lblObservaciones, Me.shpObservaciones, Me.lnFirma, Me.lblFirmRecibidoPor, Me.Line11, Me.lblFirmaEntregadoPor, Me.txtObservaciones1, Me.txtSolicitadoPor2})
        Me.Pie_grupo.Height = 2.375!
        Me.Pie_grupo.Name = "Pie_grupo"
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
        Me.lnPieDetalle.Left = 0.125!
        Me.lnPieDetalle.LineColor = System.Drawing.Color.Silver
        Me.lnPieDetalle.LineWeight = 1.0!
        Me.lnPieDetalle.Name = "lnPieDetalle"
        Me.lnPieDetalle.Top = 0.0!
        Me.lnPieDetalle.Width = 7.239583!
        Me.lnPieDetalle.X1 = 0.125!
        Me.lnPieDetalle.X2 = 7.364583!
        Me.lnPieDetalle.Y1 = 0.0!
        Me.lnPieDetalle.Y2 = 0.0!
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Border.BottomColor = System.Drawing.Color.Black
        Me.lblObservaciones.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblObservaciones.Border.LeftColor = System.Drawing.Color.Black
        Me.lblObservaciones.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblObservaciones.Border.RightColor = System.Drawing.Color.Black
        Me.lblObservaciones.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblObservaciones.Border.TopColor = System.Drawing.Color.Black
        Me.lblObservaciones.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblObservaciones.Height = 0.1875!
        Me.lblObservaciones.HyperLink = ""
        Me.lblObservaciones.Left = 0.1875!
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Style = ""
        Me.lblObservaciones.Text = "Observaciones:"
        Me.lblObservaciones.Top = 0.1875!
        Me.lblObservaciones.Width = 1.0625!
        '
        'shpObservaciones
        '
        Me.shpObservaciones.Border.BottomColor = System.Drawing.Color.Black
        Me.shpObservaciones.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpObservaciones.Border.LeftColor = System.Drawing.Color.Black
        Me.shpObservaciones.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpObservaciones.Border.RightColor = System.Drawing.Color.Black
        Me.shpObservaciones.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpObservaciones.Border.TopColor = System.Drawing.Color.Black
        Me.shpObservaciones.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpObservaciones.Height = 1.0625!
        Me.shpObservaciones.Left = 0.1875!
        Me.shpObservaciones.LineColor = System.Drawing.Color.Gainsboro
        Me.shpObservaciones.Name = "shpObservaciones"
        Me.shpObservaciones.RoundingRadius = 9.999999!
        Me.shpObservaciones.Top = 0.375!
        Me.shpObservaciones.Width = 7.25!
        '
        'lnFirma
        '
        Me.lnFirma.Border.BottomColor = System.Drawing.Color.Black
        Me.lnFirma.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnFirma.Border.LeftColor = System.Drawing.Color.Black
        Me.lnFirma.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnFirma.Border.RightColor = System.Drawing.Color.Black
        Me.lnFirma.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnFirma.Border.TopColor = System.Drawing.Color.Black
        Me.lnFirma.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnFirma.Height = 0.0!
        Me.lnFirma.Left = 0.125!
        Me.lnFirma.LineWeight = 1.0!
        Me.lnFirma.Name = "lnFirma"
        Me.lnFirma.Top = 2.0!
        Me.lnFirma.Width = 1.375!
        Me.lnFirma.X1 = 0.125!
        Me.lnFirma.X2 = 1.5!
        Me.lnFirma.Y1 = 2.0!
        Me.lnFirma.Y2 = 2.0!
        '
        'lblFirmRecibidoPor
        '
        Me.lblFirmRecibidoPor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFirmRecibidoPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmRecibidoPor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFirmRecibidoPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmRecibidoPor.Border.RightColor = System.Drawing.Color.Black
        Me.lblFirmRecibidoPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmRecibidoPor.Border.TopColor = System.Drawing.Color.Black
        Me.lblFirmRecibidoPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmRecibidoPor.Height = 0.1875!
        Me.lblFirmRecibidoPor.HyperLink = ""
        Me.lblFirmRecibidoPor.Left = 0.125!
        Me.lblFirmRecibidoPor.Name = "lblFirmRecibidoPor"
        Me.lblFirmRecibidoPor.Style = ""
        Me.lblFirmRecibidoPor.Text = "Recibido por:"
        Me.lblFirmRecibidoPor.Top = 2.0!
        Me.lblFirmRecibidoPor.Width = 0.9375!
        '
        'Line11
        '
        Me.Line11.Border.BottomColor = System.Drawing.Color.Black
        Me.Line11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.LeftColor = System.Drawing.Color.Black
        Me.Line11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.RightColor = System.Drawing.Color.Black
        Me.Line11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.TopColor = System.Drawing.Color.Black
        Me.Line11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Height = 0.0!
        Me.Line11.Left = 2.0!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 2.0!
        Me.Line11.Width = 1.4375!
        Me.Line11.X1 = 2.0!
        Me.Line11.X2 = 3.4375!
        Me.Line11.Y1 = 2.0!
        Me.Line11.Y2 = 2.0!
        '
        'lblFirmaEntregadoPor
        '
        Me.lblFirmaEntregadoPor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFirmaEntregadoPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmaEntregadoPor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFirmaEntregadoPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmaEntregadoPor.Border.RightColor = System.Drawing.Color.Black
        Me.lblFirmaEntregadoPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmaEntregadoPor.Border.TopColor = System.Drawing.Color.Black
        Me.lblFirmaEntregadoPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmaEntregadoPor.Height = 0.1875!
        Me.lblFirmaEntregadoPor.HyperLink = ""
        Me.lblFirmaEntregadoPor.Left = 2.0!
        Me.lblFirmaEntregadoPor.Name = "lblFirmaEntregadoPor"
        Me.lblFirmaEntregadoPor.Style = ""
        Me.lblFirmaEntregadoPor.Text = "Entregado por:"
        Me.lblFirmaEntregadoPor.Top = 2.0!
        Me.lblFirmaEntregadoPor.Width = 1.4375!
        '
        'txtObservaciones1
        '
        Me.txtObservaciones1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtObservaciones1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtObservaciones1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtObservaciones1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtObservaciones1.Border.RightColor = System.Drawing.Color.Black
        Me.txtObservaciones1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtObservaciones1.Border.TopColor = System.Drawing.Color.Black
        Me.txtObservaciones1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtObservaciones1.DataField = "Observaciones"
        Me.txtObservaciones1.Height = 0.9375!
        Me.txtObservaciones1.Left = 0.25!
        Me.txtObservaciones1.Name = "txtObservaciones1"
        Me.txtObservaciones1.Style = "color: DimGray; "
        Me.txtObservaciones1.Text = "txtObservaciones1"
        Me.txtObservaciones1.Top = 0.4375!
        Me.txtObservaciones1.Width = 7.0625!
        '
        'txtSolicitadoPor2
        '
        Me.txtSolicitadoPor2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSolicitadoPor2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSolicitadoPor2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSolicitadoPor2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSolicitadoPor2.Border.RightColor = System.Drawing.Color.Black
        Me.txtSolicitadoPor2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSolicitadoPor2.Border.TopColor = System.Drawing.Color.Black
        Me.txtSolicitadoPor2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSolicitadoPor2.DataField = "RecibidoPor"
        Me.txtSolicitadoPor2.Height = 0.1875!
        Me.txtSolicitadoPor2.Left = 0.125!
        Me.txtSolicitadoPor2.Name = "txtSolicitadoPor2"
        Me.txtSolicitadoPor2.Style = "color: DimGray; "
        Me.txtSolicitadoPor2.Text = "RecibidoPor"
        Me.txtSolicitadoPor2.Top = 2.1875!
        Me.txtSolicitadoPor2.Width = 1.4375!
        '
        'rptTransferenciaRecepcion
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Ca" & _
            "talog=SIFUM;Data Source=DESARROLLO1"
        OleDBDataSource1.SQL = "Select * from dbo.vwRptTransferenciaRecepcion"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.48!
        Me.Sections.Add(Me.Encabezado_Reporte)
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Encabezado_Grupo)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_grupo)
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
        CType(Me.lblCantidadDespachada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCantidadSolicitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCantidadRecibida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivRepuestoID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCorta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadSolicitada1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadDespachada1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadRecibida1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSitioDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSolicitadoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFechaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAnulada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAnulada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFechaSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivTransferenciaID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitioOrigen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitioDestino1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSolicitadoPor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechasolicitud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechadespacho1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDespachadaPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDespachadoPor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecepcionadoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFechaRepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecibidoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecharecibido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFirmRecibidoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFirmaEntregadoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSolicitadoPor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Encabezado_Reporte As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Pie_Reporte As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents srptEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblNoTransferencia As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSitioOrigen As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSitioDestino As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSolicitadoPor As DataDynamics.ActiveReports.Label
    Friend WithEvents lblFechaDespacho As DataDynamics.ActiveReports.Label
    Friend WithEvents lblAnulada As DataDynamics.ActiveReports.Label
    Friend WithEvents chkAnulada As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents lblFechaSolicitud As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSivTransferenciaID1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSitioOrigen1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSitioDestino1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSolicitadoPor1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFechasolicitud1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFechadespacho1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblDespachadaPor As DataDynamics.ActiveReports.Label
    Friend WithEvents txtDespachadoPor1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Encabezado_Grupo As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Pie_grupo As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents lnPieDetalle As DataDynamics.ActiveReports.Line
    Friend WithEvents lblObservaciones As DataDynamics.ActiveReports.Label
    Friend WithEvents shpObservaciones As DataDynamics.ActiveReports.Shape
    Friend WithEvents lnFirma As DataDynamics.ActiveReports.Line
    Friend WithEvents lblFirmRecibidoPor As DataDynamics.ActiveReports.Label
    Friend WithEvents Line11 As DataDynamics.ActiveReports.Line
    Friend WithEvents lblFirmaEntregadoPor As DataDynamics.ActiveReports.Label
    Friend WithEvents txtObservaciones1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSolicitadoPor2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lnLeft As DataDynamics.ActiveReports.Line
    Friend WithEvents lnRight As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle4 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle3 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle2 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle1 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnDetalle5 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtSivRepuestoID1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescripcionCorta1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidadSolicitada1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidadDespachada1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents shpFondo As DataDynamics.ActiveReports.Shape
    Friend WithEvents lblCodigo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDescripcion As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCantidadDespachada As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCantidadSolicitada As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line9 As DataDynamics.ActiveReports.Line
    Friend WithEvents lblCantidadRecibida As DataDynamics.ActiveReports.Label
    Friend WithEvents lblRecepcionadoPor As DataDynamics.ActiveReports.Label
    Friend WithEvents lblFechaRepcion As DataDynamics.ActiveReports.Label
    Friend WithEvents txtRecibidoPor As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFecharecibido1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidadRecibida1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
End Class
