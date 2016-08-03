<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptTransferenciaDiferencias 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptTransferenciaDiferencias))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.txtSivRepuestoID = New DataDynamics.ActiveReports.TextBox
        Me.txtCodigosProveedores = New DataDynamics.ActiveReports.TextBox
        Me.txtDescripcionCorta = New DataDynamics.ActiveReports.TextBox
        Me.txtSivTransferenciaID = New DataDynamics.ActiveReports.TextBox
        Me.txtFechasolicitud = New DataDynamics.ActiveReports.TextBox
        Me.txtSitioOrigen = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidadSolicitada = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidadRecibida = New DataDynamics.ActiveReports.TextBox
        Me.txtObservaciones = New DataDynamics.ActiveReports.TextBox
        Me.txtDiferencia = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Encabezado_Reporte = New DataDynamics.ActiveReports.ReportHeader
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.srptEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.txtFechaHasta = New DataDynamics.ActiveReports.TextBox
        Me.lblDesde = New DataDynamics.ActiveReports.Label
        Me.lblHasta = New DataDynamics.ActiveReports.Label
        Me.txtfechaDesde = New DataDynamics.ActiveReports.TextBox
        Me.lblSubTitulo = New DataDynamics.ActiveReports.Label
        Me.Pie_Reporte = New DataDynamics.ActiveReports.ReportFooter
        Me.Encabezado_Grupo = New DataDynamics.ActiveReports.GroupHeader
        Me.lnGuionSitioOrigen = New DataDynamics.ActiveReports.Line
        Me.lblSitioOrigen = New DataDynamics.ActiveReports.Label
        Me.txtCodigoTiendaDestino1 = New DataDynamics.ActiveReports.TextBox
        Me.lblCodigoRepuesto = New DataDynamics.ActiveReports.Label
        Me.lblCodProveedores = New DataDynamics.ActiveReports.Label
        Me.lblDescripcion = New DataDynamics.ActiveReports.Label
        Me.lblNoTransferencia = New DataDynamics.ActiveReports.Label
        Me.lblFechaSolicitud = New DataDynamics.ActiveReports.Label
        Me.lblSolicitadoA = New DataDynamics.ActiveReports.Label
        Me.lblCantidadSolicitada = New DataDynamics.ActiveReports.Label
        Me.lblCantidadRecibida = New DataDynamics.ActiveReports.Label
        Me.lblDiferencia = New DataDynamics.ActiveReports.Label
        Me.lblObservaciones = New DataDynamics.ActiveReports.Label
        Me.txtSitioDestino1 = New DataDynamics.ActiveReports.TextBox
        Me.Pie_Grupo = New DataDynamics.ActiveReports.GroupFooter
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.prmFechaDesde = New DataDynamics.ActiveReports.Parameter
        Me.prmFechaHasta = New DataDynamics.ActiveReports.Parameter
        CType(Me.txtSivRepuestoID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigosProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCorta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivTransferenciaID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechasolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadSolicitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadRecibida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSubTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoTiendaDestino1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFechaSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSolicitadoA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidadSolicitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCantidadRecibida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDiferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitioDestino1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Encabezado_Pagina
        '
        Me.Encabezado_Pagina.Height = 0.0!
        Me.Encabezado_Pagina.Name = "Encabezado_Pagina"
        '
        'Detalle
        '
        Me.Detalle.ColumnDirection = DataDynamics.ActiveReports.ColumnDirection.AcrossDown
        Me.Detalle.ColumnSpacing = 0.0!
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSivRepuestoID, Me.txtCodigosProveedores, Me.txtDescripcionCorta, Me.txtSivTransferenciaID, Me.txtFechasolicitud, Me.txtSitioOrigen, Me.txtCantidadSolicitada, Me.txtCantidadRecibida, Me.txtObservaciones, Me.txtDiferencia, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line13})
        Me.Detalle.Height = 0.21875!
        Me.Detalle.KeepTogether = True
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
        Me.txtSivRepuestoID.Left = 0.15625!
        Me.txtSivRepuestoID.Name = "txtSivRepuestoID"
        Me.txtSivRepuestoID.Style = "text-align: center; "
        Me.txtSivRepuestoID.Text = "txtSivRepuestoID"
        Me.txtSivRepuestoID.Top = 0.0!
        Me.txtSivRepuestoID.Width = 0.625!
        '
        'txtCodigosProveedores
        '
        Me.txtCodigosProveedores.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigosProveedores.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigosProveedores.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigosProveedores.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigosProveedores.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigosProveedores.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigosProveedores.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigosProveedores.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigosProveedores.DataField = "CodigosProveedores"
        Me.txtCodigosProveedores.Height = 0.1875!
        Me.txtCodigosProveedores.Left = 0.84375!
        Me.txtCodigosProveedores.Name = "txtCodigosProveedores"
        Me.txtCodigosProveedores.Style = "text-align: center; "
        Me.txtCodigosProveedores.Text = "txtCodigosProveedores"
        Me.txtCodigosProveedores.Top = 0.0!
        Me.txtCodigosProveedores.Width = 0.9375!
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
        Me.txtDescripcionCorta.Left = 1.854167!
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Style = ""
        Me.txtDescripcionCorta.Text = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Top = 0.0!
        Me.txtDescripcionCorta.Width = 1.5625!
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
        Me.txtSivTransferenciaID.Left = 3.46875!
        Me.txtSivTransferenciaID.Name = "txtSivTransferenciaID"
        Me.txtSivTransferenciaID.Style = "text-align: center; "
        Me.txtSivTransferenciaID.Text = "txtSivTransferenciaID"
        Me.txtSivTransferenciaID.Top = 0.0!
        Me.txtSivTransferenciaID.Width = 0.6875!
        '
        'txtFechasolicitud
        '
        Me.txtFechasolicitud.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFechasolicitud.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechasolicitud.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFechasolicitud.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechasolicitud.Border.RightColor = System.Drawing.Color.Black
        Me.txtFechasolicitud.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechasolicitud.Border.TopColor = System.Drawing.Color.Black
        Me.txtFechasolicitud.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechasolicitud.DataField = "Fechasolicitud"
        Me.txtFechasolicitud.Height = 0.1875!
        Me.txtFechasolicitud.Left = 4.21875!
        Me.txtFechasolicitud.Name = "txtFechasolicitud"
        Me.txtFechasolicitud.OutputFormat = resources.GetString("txtFechasolicitud.OutputFormat")
        Me.txtFechasolicitud.Style = "text-align: center; "
        Me.txtFechasolicitud.Text = "txtFechasolicitud"
        Me.txtFechasolicitud.Top = 0.0!
        Me.txtFechasolicitud.Width = 0.6875!
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
        Me.txtSitioOrigen.Left = 4.96875!
        Me.txtSitioOrigen.Name = "txtSitioOrigen"
        Me.txtSitioOrigen.Style = "text-align: center; "
        Me.txtSitioOrigen.Text = "txtSitioOrigen"
        Me.txtSitioOrigen.Top = 0.0!
        Me.txtSitioOrigen.Width = 0.875!
        '
        'txtCantidadSolicitada
        '
        Me.txtCantidadSolicitada.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCantidadSolicitada.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadSolicitada.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCantidadSolicitada.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadSolicitada.Border.RightColor = System.Drawing.Color.Black
        Me.txtCantidadSolicitada.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadSolicitada.Border.TopColor = System.Drawing.Color.Black
        Me.txtCantidadSolicitada.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadSolicitada.DataField = "CantidadSolicitada"
        Me.txtCantidadSolicitada.Height = 0.1875!
        Me.txtCantidadSolicitada.Left = 5.9375!
        Me.txtCantidadSolicitada.Name = "txtCantidadSolicitada"
        Me.txtCantidadSolicitada.Style = "text-align: center; "
        Me.txtCantidadSolicitada.Text = "txtCantidadSolicitada"
        Me.txtCantidadSolicitada.Top = 0.0!
        Me.txtCantidadSolicitada.Width = 0.625!
        '
        'txtCantidadRecibida
        '
        Me.txtCantidadRecibida.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCantidadRecibida.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadRecibida.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCantidadRecibida.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadRecibida.Border.RightColor = System.Drawing.Color.Black
        Me.txtCantidadRecibida.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadRecibida.Border.TopColor = System.Drawing.Color.Black
        Me.txtCantidadRecibida.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidadRecibida.DataField = "CantidadRecibida"
        Me.txtCantidadRecibida.Height = 0.1875!
        Me.txtCantidadRecibida.Left = 6.65625!
        Me.txtCantidadRecibida.Name = "txtCantidadRecibida"
        Me.txtCantidadRecibida.Style = "text-align: center; "
        Me.txtCantidadRecibida.Text = "txtCantidadRecibida"
        Me.txtCantidadRecibida.Top = 0.0!
        Me.txtCantidadRecibida.Width = 0.6875!
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Border.BottomColor = System.Drawing.Color.Black
        Me.txtObservaciones.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtObservaciones.Border.LeftColor = System.Drawing.Color.Black
        Me.txtObservaciones.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtObservaciones.Border.RightColor = System.Drawing.Color.Black
        Me.txtObservaciones.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtObservaciones.Border.TopColor = System.Drawing.Color.Black
        Me.txtObservaciones.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtObservaciones.DataField = "Observaciones"
        Me.txtObservaciones.Height = 0.1875!
        Me.txtObservaciones.Left = 8.1875!
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Style = ""
        Me.txtObservaciones.Text = "txtObservaciones"
        Me.txtObservaciones.Top = 0.0!
        Me.txtObservaciones.Width = 2.125!
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDiferencia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDiferencia.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDiferencia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDiferencia.Border.RightColor = System.Drawing.Color.Black
        Me.txtDiferencia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDiferencia.Border.TopColor = System.Drawing.Color.Black
        Me.txtDiferencia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDiferencia.DataField = "Diferencia"
        Me.txtDiferencia.Height = 0.1875!
        Me.txtDiferencia.Left = 7.4375!
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Style = "text-align: center; "
        Me.txtDiferencia.Text = "txtDiferencia"
        Me.txtDiferencia.Top = 0.0!
        Me.txtDiferencia.Width = 0.625!
        '
        'Line2
        '
        Me.Line2.AnchorBottom = True
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.1875!
        Me.Line2.Left = 0.125!
        Me.Line2.LineColor = System.Drawing.Color.Silver
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 0.125!
        Me.Line2.X2 = 0.125!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.1875!
        '
        'Line3
        '
        Me.Line3.AnchorBottom = True
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.1875!
        Me.Line3.Left = 0.8125!
        Me.Line3.LineColor = System.Drawing.Color.Silver
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 0.8125!
        Me.Line3.X2 = 0.8125!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.1875!
        '
        'Line4
        '
        Me.Line4.AnchorBottom = True
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.1875!
        Me.Line4.Left = 1.8125!
        Me.Line4.LineColor = System.Drawing.Color.Silver
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 1.8125!
        Me.Line4.X2 = 1.8125!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.1875!
        '
        'Line5
        '
        Me.Line5.AnchorBottom = True
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.1875!
        Me.Line5.Left = 3.4375!
        Me.Line5.LineColor = System.Drawing.Color.Silver
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 3.4375!
        Me.Line5.X2 = 3.4375!
        Me.Line5.Y1 = 0.0!
        Me.Line5.Y2 = 0.1875!
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
        Me.Line6.Left = 4.1875!
        Me.Line6.LineColor = System.Drawing.Color.Silver
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.0!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 4.1875!
        Me.Line6.X2 = 4.1875!
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
        Me.Line7.Left = 4.9375!
        Me.Line7.LineColor = System.Drawing.Color.Silver
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.0!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 4.9375!
        Me.Line7.X2 = 4.9375!
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
        Me.Line8.Left = 5.875!
        Me.Line8.LineColor = System.Drawing.Color.Silver
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.0!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 5.875!
        Me.Line8.X2 = 5.875!
        Me.Line8.Y1 = 0.0!
        Me.Line8.Y2 = 0.1875!
        '
        'Line9
        '
        Me.Line9.AnchorBottom = True
        Me.Line9.Border.BottomColor = System.Drawing.Color.Black
        Me.Line9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.LeftColor = System.Drawing.Color.Black
        Me.Line9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.RightColor = System.Drawing.Color.Black
        Me.Line9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.TopColor = System.Drawing.Color.Black
        Me.Line9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Height = 0.1875!
        Me.Line9.Left = 6.625!
        Me.Line9.LineColor = System.Drawing.Color.Silver
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.0!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 6.625!
        Me.Line9.X2 = 6.625!
        Me.Line9.Y1 = 0.0!
        Me.Line9.Y2 = 0.1875!
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
        Me.Line10.Left = 8.125!
        Me.Line10.LineColor = System.Drawing.Color.Silver
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.0!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 8.125!
        Me.Line10.X2 = 8.125!
        Me.Line10.Y1 = 0.0!
        Me.Line10.Y2 = 0.1875!
        '
        'Line11
        '
        Me.Line11.AnchorBottom = True
        Me.Line11.Border.BottomColor = System.Drawing.Color.Black
        Me.Line11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.LeftColor = System.Drawing.Color.Black
        Me.Line11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.RightColor = System.Drawing.Color.Black
        Me.Line11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.TopColor = System.Drawing.Color.Black
        Me.Line11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Height = 0.1875!
        Me.Line11.Left = 10.3125!
        Me.Line11.LineColor = System.Drawing.Color.Silver
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.0!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 10.3125!
        Me.Line11.X2 = 10.3125!
        Me.Line11.Y1 = 0.0!
        Me.Line11.Y2 = 0.1875!
        '
        'Line12
        '
        Me.Line12.Border.BottomColor = System.Drawing.Color.Black
        Me.Line12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.LeftColor = System.Drawing.Color.Black
        Me.Line12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.RightColor = System.Drawing.Color.Black
        Me.Line12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.TopColor = System.Drawing.Color.Black
        Me.Line12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Height = 0.0!
        Me.Line12.Left = 0.125!
        Me.Line12.LineColor = System.Drawing.Color.Silver
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.0!
        Me.Line12.Width = 10.1875!
        Me.Line12.X1 = 0.125!
        Me.Line12.X2 = 10.3125!
        Me.Line12.Y1 = 0.0!
        Me.Line12.Y2 = 0.0!
        '
        'Line13
        '
        Me.Line13.AnchorBottom = True
        Me.Line13.Border.BottomColor = System.Drawing.Color.Black
        Me.Line13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.LeftColor = System.Drawing.Color.Black
        Me.Line13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.RightColor = System.Drawing.Color.Black
        Me.Line13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.TopColor = System.Drawing.Color.Black
        Me.Line13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Height = 0.1875!
        Me.Line13.Left = 7.375!
        Me.Line13.LineColor = System.Drawing.Color.Silver
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.0!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 7.375!
        Me.Line13.X2 = 7.375!
        Me.Line13.Y1 = 0.0!
        Me.Line13.Y2 = 0.1875!
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
        Me.ReportInfo1.Left = 8.208333!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: DimGray; ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 2.0!
        '
        'Encabezado_Reporte
        '
        Me.Encabezado_Reporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo, Me.srptEncabezado, Me.txtFechaHasta, Me.lblDesde, Me.lblHasta, Me.txtfechaDesde, Me.lblSubTitulo})
        Me.Encabezado_Reporte.Height = 2.229167!
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
        Me.lblTitulo.Left = 3.1875!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "color: SteelBlue; ddo-char-set: 1; text-align: center; font-weight: bold; font-si" & _
            "ze: 14.25pt; font-family: Times New Roman; vertical-align: middle; "
        Me.lblTitulo.Text = "REPORTE DE DIFERENCIAS"
        Me.lblTitulo.Top = 1.25!
        Me.lblTitulo.Width = 3.75!
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
        Me.srptEncabezado.Left = 0.125!
        Me.srptEncabezado.Name = "srptEncabezado"
        Me.srptEncabezado.Report = Nothing
        Me.srptEncabezado.ReportName = "Encabezado"
        Me.srptEncabezado.Top = 0.0!
        Me.srptEncabezado.Width = 10.3125!
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
        Me.txtFechaHasta.Left = 6.0!
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Style = ""
        Me.txtFechaHasta.Text = Nothing
        Me.txtFechaHasta.Top = 1.875!
        Me.txtFechaHasta.Width = 1.1875!
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
        Me.lblDesde.Left = 3.9375!
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Style = "font-weight: bold; "
        Me.lblDesde.Text = "Desde:"
        Me.lblDesde.Top = 1.875!
        Me.lblDesde.Width = 0.5!
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
        Me.lblHasta.Left = 5.5!
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Style = "font-weight: bold; "
        Me.lblHasta.Text = "Hasta:"
        Me.lblHasta.Top = 1.875!
        Me.lblHasta.Width = 0.5!
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
        Me.txtfechaDesde.Left = 4.4375!
        Me.txtfechaDesde.Name = "txtfechaDesde"
        Me.txtfechaDesde.Style = ""
        Me.txtfechaDesde.Text = Nothing
        Me.txtfechaDesde.Top = 1.875!
        Me.txtfechaDesde.Width = 1.0!
        '
        'lblSubTitulo
        '
        Me.lblSubTitulo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSubTitulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTitulo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSubTitulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTitulo.Border.RightColor = System.Drawing.Color.Black
        Me.lblSubTitulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTitulo.Border.TopColor = System.Drawing.Color.Black
        Me.lblSubTitulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSubTitulo.Height = 0.25!
        Me.lblSubTitulo.HyperLink = Nothing
        Me.lblSubTitulo.Left = 3.1875!
        Me.lblSubTitulo.Name = "lblSubTitulo"
        Me.lblSubTitulo.Style = "color: SteelBlue; ddo-char-set: 1; text-align: center; font-weight: bold; font-si" & _
            "ze: 12pt; font-family: Times New Roman; vertical-align: middle; "
        Me.lblSubTitulo.Text = "SOLICITADO vs RECEPCIONADO"
        Me.lblSubTitulo.Top = 1.5!
        Me.lblSubTitulo.Width = 3.75!
        '
        'Pie_Reporte
        '
        Me.Pie_Reporte.Height = 0.0!
        Me.Pie_Reporte.Name = "Pie_Reporte"
        '
        'Encabezado_Grupo
        '
        Me.Encabezado_Grupo.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lnGuionSitioOrigen, Me.lblSitioOrigen, Me.txtCodigoTiendaDestino1, Me.lblCodigoRepuesto, Me.lblCodProveedores, Me.lblDescripcion, Me.lblNoTransferencia, Me.lblFechaSolicitud, Me.lblSolicitadoA, Me.lblCantidadSolicitada, Me.lblCantidadRecibida, Me.lblDiferencia, Me.lblObservaciones, Me.txtSitioDestino1})
        Me.Encabezado_Grupo.DataField = "ObjTiendaDestinoID"
        Me.Encabezado_Grupo.Height = 0.7604167!
        Me.Encabezado_Grupo.Name = "Encabezado_Grupo"
        '
        'lnGuionSitioOrigen
        '
        Me.lnGuionSitioOrigen.Border.BottomColor = System.Drawing.Color.Black
        Me.lnGuionSitioOrigen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnGuionSitioOrigen.Border.LeftColor = System.Drawing.Color.Black
        Me.lnGuionSitioOrigen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnGuionSitioOrigen.Border.RightColor = System.Drawing.Color.Black
        Me.lnGuionSitioOrigen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnGuionSitioOrigen.Border.TopColor = System.Drawing.Color.Black
        Me.lnGuionSitioOrigen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lnGuionSitioOrigen.Height = 0.0!
        Me.lnGuionSitioOrigen.Left = 1.885417!
        Me.lnGuionSitioOrigen.LineWeight = 1.0!
        Me.lnGuionSitioOrigen.Name = "lnGuionSitioOrigen"
        Me.lnGuionSitioOrigen.Top = 0.09375!
        Me.lnGuionSitioOrigen.Width = 0.125!
        Me.lnGuionSitioOrigen.X1 = 1.885417!
        Me.lnGuionSitioOrigen.X2 = 2.010417!
        Me.lnGuionSitioOrigen.Y1 = 0.09375!
        Me.lnGuionSitioOrigen.Y2 = 0.09375!
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
        Me.lblSitioOrigen.Left = 0.25!
        Me.lblSitioOrigen.Name = "lblSitioOrigen"
        Me.lblSitioOrigen.Style = "text-decoration: underline; font-weight: bold; "
        Me.lblSitioOrigen.Text = "SITIO DESTINO:"
        Me.lblSitioOrigen.Top = 0.0!
        Me.lblSitioOrigen.Width = 1.375!
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
        Me.txtCodigoTiendaDestino1.Left = 1.375!
        Me.txtCodigoTiendaDestino1.Name = "txtCodigoTiendaDestino1"
        Me.txtCodigoTiendaDestino1.Style = "text-align: right; "
        Me.txtCodigoTiendaDestino1.Text = "txtCodigoTiendaDestino1"
        Me.txtCodigoTiendaDestino1.Top = 0.0!
        Me.txtCodigoTiendaDestino1.Width = 0.5!
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
        Me.lblCodigoRepuesto.Height = 0.4375!
        Me.lblCodigoRepuesto.HyperLink = Nothing
        Me.lblCodigoRepuesto.Left = 0.125!
        Me.lblCodigoRepuesto.Name = "lblCodigoRepuesto"
        Me.lblCodigoRepuesto.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblCodigoRepuesto.Text = "Código"
        Me.lblCodigoRepuesto.Top = 0.3125!
        Me.lblCodigoRepuesto.Width = 0.6875!
        '
        'lblCodProveedores
        '
        Me.lblCodProveedores.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCodProveedores.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodProveedores.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCodProveedores.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodProveedores.Border.RightColor = System.Drawing.Color.Black
        Me.lblCodProveedores.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodProveedores.Border.TopColor = System.Drawing.Color.Black
        Me.lblCodProveedores.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCodProveedores.Height = 0.4375!
        Me.lblCodProveedores.HyperLink = Nothing
        Me.lblCodProveedores.Left = 0.8125!
        Me.lblCodProveedores.Name = "lblCodProveedores"
        Me.lblCodProveedores.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblCodProveedores.Text = "Código Proveedor"
        Me.lblCodProveedores.Top = 0.3125!
        Me.lblCodProveedores.Width = 1.0!
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
        Me.lblDescripcion.Height = 0.4375!
        Me.lblDescripcion.HyperLink = Nothing
        Me.lblDescripcion.Left = 1.8125!
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.Top = 0.3125!
        Me.lblDescripcion.Width = 1.625!
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
        Me.lblNoTransferencia.Height = 0.4375!
        Me.lblNoTransferencia.HyperLink = Nothing
        Me.lblNoTransferencia.Left = 3.4375!
        Me.lblNoTransferencia.Name = "lblNoTransferencia"
        Me.lblNoTransferencia.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblNoTransferencia.Text = "# Transf"
        Me.lblNoTransferencia.Top = 0.3125!
        Me.lblNoTransferencia.Width = 0.75!
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
        Me.lblFechaSolicitud.Height = 0.4375!
        Me.lblFechaSolicitud.HyperLink = Nothing
        Me.lblFechaSolicitud.Left = 4.1875!
        Me.lblFechaSolicitud.Name = "lblFechaSolicitud"
        Me.lblFechaSolicitud.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblFechaSolicitud.Text = "Fecha Solicitud"
        Me.lblFechaSolicitud.Top = 0.3125!
        Me.lblFechaSolicitud.Width = 0.75!
        '
        'lblSolicitadoA
        '
        Me.lblSolicitadoA.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSolicitadoA.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSolicitadoA.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSolicitadoA.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSolicitadoA.Border.RightColor = System.Drawing.Color.Black
        Me.lblSolicitadoA.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSolicitadoA.Border.TopColor = System.Drawing.Color.Black
        Me.lblSolicitadoA.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSolicitadoA.Height = 0.4375!
        Me.lblSolicitadoA.HyperLink = Nothing
        Me.lblSolicitadoA.Left = 4.9375!
        Me.lblSolicitadoA.Name = "lblSolicitadoA"
        Me.lblSolicitadoA.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblSolicitadoA.Text = "Solicitado A:"
        Me.lblSolicitadoA.Top = 0.3125!
        Me.lblSolicitadoA.Width = 0.9375!
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
        Me.lblCantidadSolicitada.Height = 0.4375!
        Me.lblCantidadSolicitada.HyperLink = Nothing
        Me.lblCantidadSolicitada.Left = 5.875!
        Me.lblCantidadSolicitada.Name = "lblCantidadSolicitada"
        Me.lblCantidadSolicitada.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblCantidadSolicitada.Text = "Cantidad Solicitada"
        Me.lblCantidadSolicitada.Top = 0.3125!
        Me.lblCantidadSolicitada.Width = 0.75!
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
        Me.lblCantidadRecibida.Height = 0.4375!
        Me.lblCantidadRecibida.HyperLink = Nothing
        Me.lblCantidadRecibida.Left = 6.625!
        Me.lblCantidadRecibida.Name = "lblCantidadRecibida"
        Me.lblCantidadRecibida.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblCantidadRecibida.Text = "Cantidad Recibida"
        Me.lblCantidadRecibida.Top = 0.3125!
        Me.lblCantidadRecibida.Width = 0.75!
        '
        'lblDiferencia
        '
        Me.lblDiferencia.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDiferencia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDiferencia.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDiferencia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDiferencia.Border.RightColor = System.Drawing.Color.Black
        Me.lblDiferencia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDiferencia.Border.TopColor = System.Drawing.Color.Black
        Me.lblDiferencia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDiferencia.Height = 0.4375!
        Me.lblDiferencia.HyperLink = Nothing
        Me.lblDiferencia.Left = 7.375!
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblDiferencia.Text = "Diferencia"
        Me.lblDiferencia.Top = 0.3125!
        Me.lblDiferencia.Width = 0.75!
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
        Me.lblObservaciones.Height = 0.4375!
        Me.lblObservaciones.HyperLink = Nothing
        Me.lblObservaciones.Left = 8.125!
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Style = "text-align: center; font-weight: bold; vertical-align: middle; "
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.Top = 0.3125!
        Me.lblObservaciones.Width = 2.1875!
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
        Me.txtSitioDestino1.Left = 2.0625!
        Me.txtSitioDestino1.Name = "txtSitioDestino1"
        Me.txtSitioDestino1.Style = ""
        Me.txtSitioDestino1.Text = "txtSitioDestino1"
        Me.txtSitioDestino1.Top = 0.0!
        Me.txtSitioDestino1.Width = 1.0!
        '
        'Pie_Grupo
        '
        Me.Pie_Grupo.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line1})
        Me.Pie_Grupo.Height = 0.0!
        Me.Pie_Grupo.Name = "Pie_Grupo"
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
        Me.Line1.Left = 0.125!
        Me.Line1.LineColor = System.Drawing.Color.Silver
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 10.1875!
        Me.Line1.X1 = 0.125!
        Me.Line1.X2 = 10.3125!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
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
        'rptTransferenciaDiferencias
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=SA;Initial Ca" & _
            "talog=SIFUM;Data Source=DESARROLLO1"
        OleDBDataSource1.SQL = "Select * from dbo.vwRptTransferenciaDiferencias"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Left = 0.4!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.Parameters.Add(Me.prmFechaDesde)
        Me.Parameters.Add(Me.prmFechaHasta)
        Me.PrintWidth = 11.0!
        Me.Sections.Add(Me.Encabezado_Reporte)
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Encabezado_Grupo)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_Grupo)
        Me.Sections.Add(Me.Pie_Pagina)
        Me.Sections.Add(Me.Pie_Reporte)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtSivRepuestoID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigosProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCorta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivTransferenciaID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechasolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadSolicitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadRecibida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSubTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoTiendaDestino1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFechaSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSolicitadoA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCantidadSolicitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCantidadRecibida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDiferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitioDestino1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents Encabezado_Reporte As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Pie_Reporte As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents srptEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents txtFechaHasta As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblDesde As DataDynamics.ActiveReports.Label
    Friend WithEvents lblHasta As DataDynamics.ActiveReports.Label
    Friend WithEvents txtfechaDesde As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblSubTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents Encabezado_Grupo As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Pie_Grupo As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents lnGuionSitioOrigen As DataDynamics.ActiveReports.Line
    Friend WithEvents lblSitioOrigen As DataDynamics.ActiveReports.Label
    Friend WithEvents txtCodigoTiendaDestino1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSivRepuestoID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodigosProveedores As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescripcionCorta As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSivTransferenciaID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFechasolicitud As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSitioOrigen As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidadSolicitada As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidadRecibida As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtObservaciones As DataDynamics.ActiveReports.TextBox
    Friend WithEvents prmFechaDesde As DataDynamics.ActiveReports.Parameter
    Friend WithEvents prmFechaHasta As DataDynamics.ActiveReports.Parameter
    Friend WithEvents txtDiferencia As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblCodigoRepuesto As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCodProveedores As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDescripcion As DataDynamics.ActiveReports.Label
    Friend WithEvents lblNoTransferencia As DataDynamics.ActiveReports.Label
    Friend WithEvents lblFechaSolicitud As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSolicitadoA As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCantidadSolicitada As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCantidadRecibida As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDiferencia As DataDynamics.ActiveReports.Label
    Friend WithEvents lblObservaciones As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSitioDestino1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line7 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line8 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line9 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line10 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line11 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line12 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line13 As DataDynamics.ActiveReports.Line
End Class
