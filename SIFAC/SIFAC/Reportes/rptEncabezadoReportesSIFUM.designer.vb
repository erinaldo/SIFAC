<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEncabezadoReportesSIFUM
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
    Private WithEvents Detalle As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptEncabezadoReportesSIFUM))
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.EncabezadoReporte = New DataDynamics.ActiveReports.ReportHeader
        Me.lblEmpresa = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.lblDirEmpresa = New DataDynamics.ActiveReports.Label
        Me.lblTelefonosEmpresa = New DataDynamics.ActiveReports.Label
        Me.lblEmailEmpresa = New DataDynamics.ActiveReports.Label
        Me.lblFechaActual_Usuario = New DataDynamics.ActiveReports.Label
        Me.PieReporte = New DataDynamics.ActiveReports.ReportFooter
        CType(Me.lblEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDirEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTelefonosEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEmailEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFechaActual_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detalle
        '
        Me.Detalle.ColumnSpacing = 0.0!
        Me.Detalle.Height = 0.01041667!
        Me.Detalle.Name = "Detalle"
        '
        'EncabezadoReporte
        '
        Me.EncabezadoReporte.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblEmpresa, Me.Label1, Me.Label2, Me.Label3, Me.lblDirEmpresa, Me.lblTelefonosEmpresa, Me.lblEmailEmpresa, Me.lblFechaActual_Usuario})
        Me.EncabezadoReporte.Height = 1.2!
        Me.EncabezadoReporte.Name = "EncabezadoReporte"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Border.BottomColor = System.Drawing.Color.Black
        Me.lblEmpresa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmpresa.Border.LeftColor = System.Drawing.Color.Black
        Me.lblEmpresa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmpresa.Border.RightColor = System.Drawing.Color.Black
        Me.lblEmpresa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmpresa.Border.TopColor = System.Drawing.Color.Black
        Me.lblEmpresa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmpresa.Height = 0.25!
        Me.lblEmpresa.HyperLink = Nothing
        Me.lblEmpresa.Left = 0.125!
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Style = "ddo-char-set: 0; font-weight: bold; font-size: 14pt; "
        Me.lblEmpresa.Text = "EMPRESA"
        Me.lblEmpresa.Top = 0.0625!
        Me.lblEmpresa.Width = 6.9375!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.Label1.Text = "Dirección:"
        Me.Label1.Top = 0.375!
        Me.Label1.Width = 0.625!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.Label2.Text = "Teléfonos:"
        Me.Label2.Top = 0.625!
        Me.Label2.Width = 0.6875!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.Label3.Text = "E-mails:"
        Me.Label3.Top = 0.875!
        Me.Label3.Width = 0.6875!
        '
        'lblDirEmpresa
        '
        Me.lblDirEmpresa.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDirEmpresa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDirEmpresa.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDirEmpresa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDirEmpresa.Border.RightColor = System.Drawing.Color.Black
        Me.lblDirEmpresa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDirEmpresa.Border.TopColor = System.Drawing.Color.Black
        Me.lblDirEmpresa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDirEmpresa.DataField = "DireccionEmpresa"
        Me.lblDirEmpresa.Height = 0.1875!
        Me.lblDirEmpresa.HyperLink = Nothing
        Me.lblDirEmpresa.Left = 0.875!
        Me.lblDirEmpresa.Name = "lblDirEmpresa"
        Me.lblDirEmpresa.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; "
        Me.lblDirEmpresa.Text = "DireccionEmpresa"
        Me.lblDirEmpresa.Top = 0.375!
        Me.lblDirEmpresa.Width = 6.25!
        '
        'lblTelefonosEmpresa
        '
        Me.lblTelefonosEmpresa.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTelefonosEmpresa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefonosEmpresa.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTelefonosEmpresa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefonosEmpresa.Border.RightColor = System.Drawing.Color.Black
        Me.lblTelefonosEmpresa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefonosEmpresa.Border.TopColor = System.Drawing.Color.Black
        Me.lblTelefonosEmpresa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefonosEmpresa.DataField = "TelefonosEmpresa"
        Me.lblTelefonosEmpresa.Height = 0.1875!
        Me.lblTelefonosEmpresa.HyperLink = Nothing
        Me.lblTelefonosEmpresa.Left = 0.875!
        Me.lblTelefonosEmpresa.Name = "lblTelefonosEmpresa"
        Me.lblTelefonosEmpresa.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; "
        Me.lblTelefonosEmpresa.Text = "TelefonosEmpresa"
        Me.lblTelefonosEmpresa.Top = 0.625!
        Me.lblTelefonosEmpresa.Width = 6.25!
        '
        'lblEmailEmpresa
        '
        Me.lblEmailEmpresa.Border.BottomColor = System.Drawing.Color.Black
        Me.lblEmailEmpresa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmailEmpresa.Border.LeftColor = System.Drawing.Color.Black
        Me.lblEmailEmpresa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmailEmpresa.Border.RightColor = System.Drawing.Color.Black
        Me.lblEmailEmpresa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmailEmpresa.Border.TopColor = System.Drawing.Color.Black
        Me.lblEmailEmpresa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmailEmpresa.DataField = "EmailEmpresa"
        Me.lblEmailEmpresa.Height = 0.1875!
        Me.lblEmailEmpresa.HyperLink = Nothing
        Me.lblEmailEmpresa.Left = 0.875!
        Me.lblEmailEmpresa.Name = "lblEmailEmpresa"
        Me.lblEmailEmpresa.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; "
        Me.lblEmailEmpresa.Text = "EmailEmpresa"
        Me.lblEmailEmpresa.Top = 0.875!
        Me.lblEmailEmpresa.Width = 6.25!
        '
        'lblFechaActual_Usuario
        '
        Me.lblFechaActual_Usuario.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFechaActual_Usuario.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaActual_Usuario.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFechaActual_Usuario.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaActual_Usuario.Border.RightColor = System.Drawing.Color.Black
        Me.lblFechaActual_Usuario.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaActual_Usuario.Border.TopColor = System.Drawing.Color.Black
        Me.lblFechaActual_Usuario.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaActual_Usuario.Height = 0.25!
        Me.lblFechaActual_Usuario.HyperLink = Nothing
        Me.lblFechaActual_Usuario.Left = 5.3125!
        Me.lblFechaActual_Usuario.Name = "lblFechaActual_Usuario"
        Me.lblFechaActual_Usuario.Style = "color: DimGray; text-align: right; font-size: 9pt; "
        Me.lblFechaActual_Usuario.Text = "FechaActual+Usuario"
        Me.lblFechaActual_Usuario.Top = 0.0625!
        Me.lblFechaActual_Usuario.Width = 1.8125!
        '
        'PieReporte
        '
        Me.PieReporte.Height = 0.0!
        Me.PieReporte.Name = "PieReporte"
        '
        'rptEncabezadoReportesSIFUM
        '
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.4!
        Me.Sections.Add(Me.EncabezadoReporte)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.PieReporte)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.lblEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDirEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTelefonosEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEmailEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFechaActual_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents EncabezadoReporte As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents PieReporte As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents lblEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents lblDirEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTelefonosEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents lblEmailEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents lblFechaActual_Usuario As DataDynamics.ActiveReports.Label
End Class
