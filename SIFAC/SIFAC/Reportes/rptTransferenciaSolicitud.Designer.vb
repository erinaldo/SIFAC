<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptTransferenciaSolicitud 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptTransferenciaSolicitud))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.shpFondo = New DataDynamics.ActiveReports.Shape
        Me.lblCodigo = New DataDynamics.ActiveReports.Label
        Me.lblCodigoProveedor = New DataDynamics.ActiveReports.Label
        Me.lblDescripcion = New DataDynamics.ActiveReports.Label
        Me.lblCantidadSolicitada = New DataDynamics.ActiveReports.Label
        Me.lblTipoRepuesto = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.lnLeft = New DataDynamics.ActiveReports.Line
        Me.lnRight = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.txtSivRepuestoID1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescripcionCorta1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCodigosProveedores1 = New DataDynamics.ActiveReports.TextBox
        Me.txtTipoRepuesto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidadSolicitada1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Encabezado_Reporte = New DataDynamics.ActiveReports.ReportHeader
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.srptEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.lblNoTransferencia = New DataDynamics.ActiveReports.Label
        Me.lblSitioOrigen = New DataDynamics.ActiveReports.Label
        Me.lblSitioDestino = New DataDynamics.ActiveReports.Label
        Me.lblSolicitadoPor = New DataDynamics.ActiveReports.Label
        Me.lblAnulada = New DataDynamics.ActiveReports.Label
        Me.chkAnulada = New DataDynamics.ActiveReports.CheckBox
        Me.lblFechaSolicitud = New DataDynamics.ActiveReports.Label
        Me.txtSivTransferenciaID1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSitioOrigen1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSitioDestino1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSolicitadoPor1 = New DataDynamics.ActiveReports.TextBox
        Me.txtFechasolicitud1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_Reporte = New DataDynamics.ActiveReports.ReportFooter
        Me.Encabezado_Grupo = New DataDynamics.ActiveReports.GroupHeader
        Me.Pie_Grupo = New DataDynamics.ActiveReports.GroupFooter
        Me.lnPieDetalle = New DataDynamics.ActiveReports.Line
        Me.lblObservaciones = New DataDynamics.ActiveReports.Label
        Me.shpObservaciones = New DataDynamics.ActiveReports.Shape
        Me.lnFirma = New DataDynamics.ActiveReports.Line
        Me.lblFirmSolicidadoPor = New DataDynamics.ActiveReports.Label
        Me.txtObservaciones1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSolicitadoPor2 = New DataDynamics.ActiveReports.TextBox
        Me.prmFechaDesde = New DataDynamics.ActiveReports.Parameter
        Me.prmFechaHasta = New DataDynamics.ActiveReports.Parameter
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidadSolicitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTipoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivRepuestoID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCorta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigosProveedores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoRepuesto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadSolicitada1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSitioDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSolicitadoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAnulada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAnulada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFechaSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivTransferenciaID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitioOrigen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitioDestino1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSolicitadoPor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechasolicitud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFirmSolicidadoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSolicitadoPor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Encabezado_Pagina
        '
        Me.Encabezado_Pagina.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.shpFondo, Me.lblCodigo, Me.lblCodigoProveedor, Me.lblDescripcion, Me.lblCantidadSolicitada, Me.lblTipoRepuesto, Me.Line1, Me.Line2, Me.Line3, Me.Line4})
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
        Me.lblCodigoProveedor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCodigoProveedor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoProveedor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCodigoProveedor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoProveedor.Border.RightColor = System.Drawing.Color.Black
        Me.lblCodigoProveedor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoProveedor.Border.TopColor = System.Drawing.Color.Black
        Me.lblCodigoProveedor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodigoProveedor.Height = 0.3125!
        Me.lblCodigoProveedor.HyperLink = ""
        Me.lblCodigoProveedor.Left = 1.125!
        Me.lblCodigoProveedor.Name = "lblCodigoProveedor"
        Me.lblCodigoProveedor.Style = "text-align: center; font-weight: bold; "
        Me.lblCodigoProveedor.Text = "Código Proveedor"
        Me.lblCodigoProveedor.Top = 0.0625!
        Me.lblCodigoProveedor.Width = 1.125!
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
        Me.lblCantidadSolicitada.Left = 6.385417!
        Me.lblCantidadSolicitada.Name = "lblCantidadSolicitada"
        Me.lblCantidadSolicitada.Style = "text-align: center; font-weight: bold; vertical-align: top; "
        Me.lblCantidadSolicitada.Text = "Cantidad Solicitada"
        Me.lblCantidadSolicitada.Top = 0.0625!
        Me.lblCantidadSolicitada.Width = 0.875!
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
        Me.lblTipoRepuesto.Left = 5.0625!
        Me.lblTipoRepuesto.Name = "lblTipoRepuesto"
        Me.lblTipoRepuesto.Style = "text-align: center; font-weight: bold; vertical-align: top; "
        Me.lblTipoRepuesto.Text = "Tipo Repuesto"
        Me.lblTipoRepuesto.Top = 0.0625!
        Me.lblTipoRepuesto.Width = 0.875!
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
        Me.Line3.Left = 4.875!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 4.875!
        Me.Line3.X2 = 4.875!
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
        Me.Line4.Left = 6.125!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 6.125!
        Me.Line4.X2 = 6.125!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.4375!
        '
        'Detalle
        '
        Me.Detalle.ColumnSpacing = 0.0!
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lnLeft, Me.lnRight, Me.Line6, Me.Line7, Me.Line8, Me.Line10, Me.txtSivRepuestoID1, Me.txtDescripcionCorta1, Me.txtCodigosProveedores1, Me.txtTipoRepuesto1, Me.txtCantidadSolicitada1})
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
        Me.lnRight.Left = 6.125!
        Me.lnRight.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnRight.LineWeight = 1.0!
        Me.lnRight.Name = "lnRight"
        Me.lnRight.Top = 0.0!
        Me.lnRight.Width = 0.0!
        Me.lnRight.X1 = 6.125!
        Me.lnRight.X2 = 6.125!
        Me.lnRight.Y1 = 0.0!
        Me.lnRight.Y2 = 0.1875!
        '
        'Line6
        '
        Me.Line6.AnchorBottom = True
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0.1875!
        Me.Line6.Left = 4.875!
        Me.Line6.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.0!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 4.875!
        Me.Line6.X2 = 4.875!
        Me.Line6.Y1 = 0.0!
        Me.Line6.Y2 = 0.1875!
        '
        'Line7
        '
        Me.Line7.AnchorBottom = True
        Me.Line7.Border.BottomColor = System.Drawing.Color.Black
        Me.Line7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.LeftColor = System.Drawing.Color.Black
        Me.Line7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.RightColor = System.Drawing.Color.Black
        Me.Line7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.TopColor = System.Drawing.Color.Black
        Me.Line7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Height = 0.1875!
        Me.Line7.Left = 2.125!
        Me.Line7.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.0!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 2.125!
        Me.Line7.X2 = 2.125!
        Me.Line7.Y1 = 0.0!
        Me.Line7.Y2 = 0.1875!
        '
        'Line8
        '
        Me.Line8.AnchorBottom = True
        Me.Line8.Border.BottomColor = System.Drawing.Color.Black
        Me.Line8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.LeftColor = System.Drawing.Color.Black
        Me.Line8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.RightColor = System.Drawing.Color.Black
        Me.Line8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.TopColor = System.Drawing.Color.Black
        Me.Line8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Height = 0.1875!
        Me.Line8.Left = 1.125!
        Me.Line8.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.0!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 1.125!
        Me.Line8.X2 = 1.125!
        Me.Line8.Y1 = 0.0!
        Me.Line8.Y2 = 0.1875!
        '
        'Line10
        '
        Me.Line10.AnchorBottom = True
        Me.Line10.Border.BottomColor = System.Drawing.Color.Black
        Me.Line10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.LeftColor = System.Drawing.Color.Black
        Me.Line10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.RightColor = System.Drawing.Color.Black
        Me.Line10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.TopColor = System.Drawing.Color.Black
        Me.Line10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Height = 0.1875!
        Me.Line10.Left = 7.375!
        Me.Line10.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.0!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 7.375!
        Me.Line10.X2 = 7.375!
        Me.Line10.Y1 = 0.0!
        Me.Line10.Y2 = 0.1875!
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
        Me.txtSivRepuestoID1.Left = 0.1875!
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
        Me.txtDescripcionCorta1.DataField = "DescripcionCorta"
        Me.txtDescripcionCorta1.Height = 0.1875!
        Me.txtDescripcionCorta1.Left = 2.1875!
        Me.txtDescripcionCorta1.Name = "txtDescripcionCorta1"
        Me.txtDescripcionCorta1.Style = ""
        Me.txtDescripcionCorta1.Text = "txtDescripcionCorta1"
        Me.txtDescripcionCorta1.Top = 0.0!
        Me.txtDescripcionCorta1.Width = 2.625!
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
        Me.txtCodigosProveedores1.Style = ""
        Me.txtCodigosProveedores1.Text = "txtCodigosProveedores1"
        Me.txtCodigosProveedores1.Top = 0.0!
        Me.txtCodigosProveedores1.Width = 0.875!
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
        Me.txtTipoRepuesto1.Left = 4.9375!
        Me.txtTipoRepuesto1.Name = "txtTipoRepuesto1"
        Me.txtTipoRepuesto1.Style = "text-align: center; "
        Me.txtTipoRepuesto1.Text = "txtTipoRepuesto1"
        Me.txtTipoRepuesto1.Top = 0.0!
        Me.txtTipoRepuesto1.Width = 1.125!
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
        Me.txtCantidadSolicitada1.Left = 6.1875!
        Me.txtCantidadSolicitada1.Name = "txtCantidadSolicitada1"
        Me.txtCantidadSolicitada1.Style = "text-align: right; "
        Me.txtCantidadSolicitada1.Text = "txtCantidadSolicitada1"
        Me.txtCantidadSolicitada1.Top = 0.0!
        Me.txtCantidadSolicitada1.Width = 1.0625!
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
        Me.ReportInfo1.Left = 5.375!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: DimGray; ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 2.0!
        '
        'Encabezado_Reporte
        '
        Me.Encabezado_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo, Me.srptEncabezado, Me.lblNoTransferencia, Me.lblSitioOrigen, Me.lblSitioDestino, Me.lblSolicitadoPor, Me.lblAnulada, Me.chkAnulada, Me.lblFechaSolicitud, Me.txtSivTransferenciaID1, Me.txtSitioOrigen1, Me.txtSitioDestino1, Me.txtSolicitadoPor1, Me.txtFechasolicitud1})
        Me.Encabezado_Reporte.Height = 2.364583!
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
        Me.lblTitulo.Left = 0.0!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "color: SteelBlue; ddo-char-set: 1; text-align: center; font-weight: bold; font-si" & _
            "ze: 14.25pt; font-family: Times New Roman; vertical-align: middle; "
        Me.lblTitulo.Text = "SOLICITUD DE TRASLADO"
        Me.lblTitulo.Top = 1.25!
        Me.lblTitulo.Width = 7.4375!
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
        Me.lblNoTransferencia.Left = 0.125!
        Me.lblNoTransferencia.Name = "lblNoTransferencia"
        Me.lblNoTransferencia.Style = ""
        Me.lblNoTransferencia.Text = "# Transferencia:"
        Me.lblNoTransferencia.Top = 1.5625!
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
        Me.lblSitioOrigen.Left = 0.125!
        Me.lblSitioOrigen.Name = "lblSitioOrigen"
        Me.lblSitioOrigen.Style = ""
        Me.lblSitioOrigen.Text = "Sitio Origen:"
        Me.lblSitioOrigen.Top = 1.8125!
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
        Me.lblSitioDestino.Left = 0.125!
        Me.lblSitioDestino.Name = "lblSitioDestino"
        Me.lblSitioDestino.Style = ""
        Me.lblSitioDestino.Text = "Sitio Destino:"
        Me.lblSitioDestino.Top = 2.0625!
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
        Me.lblSolicitadoPor.Left = 2.75!
        Me.lblSolicitadoPor.Name = "lblSolicitadoPor"
        Me.lblSolicitadoPor.Style = ""
        Me.lblSolicitadoPor.Text = "Solicitado Por:"
        Me.lblSolicitadoPor.Top = 2.0625!
        Me.lblSolicitadoPor.Width = 0.9375!
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
        Me.lblAnulada.Left = 5.8125!
        Me.lblAnulada.Name = "lblAnulada"
        Me.lblAnulada.Style = ""
        Me.lblAnulada.Text = "Anulada"
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
        Me.chkAnulada.Left = 6.375!
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
        Me.lblFechaSolicitud.Left = 4.9375!
        Me.lblFechaSolicitud.Name = "lblFechaSolicitud"
        Me.lblFechaSolicitud.Style = ""
        Me.lblFechaSolicitud.Text = "Fecha:"
        Me.lblFechaSolicitud.Top = 2.0625!
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
        Me.txtSivTransferenciaID1.Left = 1.1875!
        Me.txtSivTransferenciaID1.Name = "txtSivTransferenciaID1"
        Me.txtSivTransferenciaID1.Style = "color: DimGray; "
        Me.txtSivTransferenciaID1.Text = "txtSivTransferenciaID1"
        Me.txtSivTransferenciaID1.Top = 1.5625!
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
        Me.txtSitioOrigen1.Left = 1.1875!
        Me.txtSitioOrigen1.Name = "txtSitioOrigen1"
        Me.txtSitioOrigen1.Style = "color: DimGray; "
        Me.txtSitioOrigen1.Text = "txtSitioOrigen1"
        Me.txtSitioOrigen1.Top = 1.8125!
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
        Me.txtSitioDestino1.Left = 1.1875!
        Me.txtSitioDestino1.Name = "txtSitioDestino1"
        Me.txtSitioDestino1.Style = "color: DimGray; "
        Me.txtSitioDestino1.Text = "txtSitioDestino1"
        Me.txtSitioDestino1.Top = 2.0625!
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
        Me.txtSolicitadoPor1.Left = 3.6875!
        Me.txtSolicitadoPor1.Name = "txtSolicitadoPor1"
        Me.txtSolicitadoPor1.Style = "color: DimGray; "
        Me.txtSolicitadoPor1.Text = "txtSolicitadoPor1"
        Me.txtSolicitadoPor1.Top = 2.0625!
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
        Me.txtFechasolicitud1.Left = 5.4375!
        Me.txtFechasolicitud1.Name = "txtFechasolicitud1"
        Me.txtFechasolicitud1.OutputFormat = resources.GetString("txtFechasolicitud1.OutputFormat")
        Me.txtFechasolicitud1.Style = "color: DimGray; "
        Me.txtFechasolicitud1.Text = "txtFechasolicitud1"
        Me.txtFechasolicitud1.Top = 2.0625!
        Me.txtFechasolicitud1.Width = 1.0!
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
        'Pie_Grupo
        '
        Me.Pie_Grupo.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lnPieDetalle, Me.lblObservaciones, Me.shpObservaciones, Me.lnFirma, Me.lblFirmSolicidadoPor, Me.txtObservaciones1, Me.txtSolicitadoPor2})
        Me.Pie_Grupo.Height = 2.385417!
        Me.Pie_Grupo.Name = "Pie_Grupo"
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
        Me.lnPieDetalle.Left = 0.1354167!
        Me.lnPieDetalle.LineColor = System.Drawing.Color.Silver
        Me.lnPieDetalle.LineWeight = 1.0!
        Me.lnPieDetalle.Name = "lnPieDetalle"
        Me.lnPieDetalle.Top = 0.0!
        Me.lnPieDetalle.Width = 7.239583!
        Me.lnPieDetalle.X1 = 0.1354167!
        Me.lnPieDetalle.X2 = 7.375!
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
        Me.lblObservaciones.Left = 0.1458333!
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
        Me.shpObservaciones.Left = 0.1458333!
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
        Me.lnFirma.Left = 0.1770833!
        Me.lnFirma.LineWeight = 1.0!
        Me.lnFirma.Name = "lnFirma"
        Me.lnFirma.Top = 2.0!
        Me.lnFirma.Width = 1.375!
        Me.lnFirma.X1 = 0.1770833!
        Me.lnFirma.X2 = 1.552083!
        Me.lnFirma.Y1 = 2.0!
        Me.lnFirma.Y2 = 2.0!
        '
        'lblFirmSolicidadoPor
        '
        Me.lblFirmSolicidadoPor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFirmSolicidadoPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmSolicidadoPor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFirmSolicidadoPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmSolicidadoPor.Border.RightColor = System.Drawing.Color.Black
        Me.lblFirmSolicidadoPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmSolicidadoPor.Border.TopColor = System.Drawing.Color.Black
        Me.lblFirmSolicidadoPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFirmSolicidadoPor.Height = 0.1875!
        Me.lblFirmSolicidadoPor.HyperLink = ""
        Me.lblFirmSolicidadoPor.Left = 0.1770833!
        Me.lblFirmSolicidadoPor.Name = "lblFirmSolicidadoPor"
        Me.lblFirmSolicidadoPor.Style = ""
        Me.lblFirmSolicidadoPor.Text = "Solicitado por:"
        Me.lblFirmSolicidadoPor.Top = 2.0!
        Me.lblFirmSolicidadoPor.Width = 0.9375!
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
        Me.txtObservaciones1.Left = 0.2083333!
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
        Me.txtSolicitadoPor2.DataField = "SolicitadoPor"
        Me.txtSolicitadoPor2.Height = 0.1875!
        Me.txtSolicitadoPor2.Left = 0.1770833!
        Me.txtSolicitadoPor2.Name = "txtSolicitadoPor2"
        Me.txtSolicitadoPor2.Style = "color: DimGray; "
        Me.txtSolicitadoPor2.Text = "Solicitado Por:"
        Me.txtSolicitadoPor2.Top = 2.1875!
        Me.txtSolicitadoPor2.Width = 1.4375!
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
        'rptTransferenciaSolicitud
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Ca" & _
            "talog=SIFUM;Data Source=DESARROLLO1"
        OleDBDataSource1.SQL = "Select * from vwRptTransferenciaSolicitud"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.Parameters.Add(Me.prmFechaDesde)
        Me.Parameters.Add(Me.prmFechaHasta)
        Me.PrintWidth = 7.5!
        Me.Sections.Add(Me.Encabezado_Reporte)
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Encabezado_Grupo)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_Grupo)
        Me.Sections.Add(Me.Pie_Pagina)
        Me.Sections.Add(Me.Pie_Reporte)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCantidadSolicitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTipoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivRepuestoID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCorta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigosProveedores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoRepuesto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadSolicitada1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSitioDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSolicitadoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAnulada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAnulada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFechaSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivTransferenciaID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitioOrigen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitioDestino1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSolicitadoPor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechasolicitud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFirmSolicidadoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSolicitadoPor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Encabezado_Reporte As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Pie_Reporte As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Encabezado_Grupo As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Pie_Grupo As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents srptEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents lblNoTransferencia As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSitioOrigen As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSitioDestino As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSolicitadoPor As DataDynamics.ActiveReports.Label
    Friend WithEvents lblAnulada As DataDynamics.ActiveReports.Label
    Friend WithEvents chkAnulada As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents lblFechaSolicitud As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSivTransferenciaID1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSitioOrigen1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSitioDestino1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSolicitadoPor1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFechasolicitud1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents shpFondo As DataDynamics.ActiveReports.Shape
    Friend WithEvents lblCodigo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCodigoProveedor As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDescripcion As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCantidadSolicitada As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTipoRepuesto As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents lnLeft As DataDynamics.ActiveReports.Line
    Friend WithEvents lnRight As DataDynamics.ActiveReports.Line
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line7 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line8 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line10 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtSivRepuestoID1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescripcionCorta1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodigosProveedores1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lnPieDetalle As DataDynamics.ActiveReports.Line
    Friend WithEvents lblObservaciones As DataDynamics.ActiveReports.Label
    Friend WithEvents shpObservaciones As DataDynamics.ActiveReports.Shape
    Friend WithEvents lnFirma As DataDynamics.ActiveReports.Line
    Friend WithEvents lblFirmSolicidadoPor As DataDynamics.ActiveReports.Label
    Friend WithEvents txtObservaciones1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSolicitadoPor2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents txtTipoRepuesto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidadSolicitada1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents prmFechaDesde As DataDynamics.ActiveReports.Parameter
    Friend WithEvents prmFechaHasta As DataDynamics.ActiveReports.Parameter
End Class
