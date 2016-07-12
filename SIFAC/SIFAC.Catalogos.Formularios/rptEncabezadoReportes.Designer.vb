<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEncabezadoReportes
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
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptEncabezadoReportes))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.picLogo = New DataDynamics.ActiveReports.Picture
        Me.lblNombreEmpresa = New DataDynamics.ActiveReports.Label
        Me.lblSiglas = New DataDynamics.ActiveReports.Label
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNombreEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSiglas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Height = 0.01041667!
        Me.Detail1.Name = "Detail1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.picLogo, Me.lblNombreEmpresa, Me.lblSiglas})
        Me.ReportHeader1.Height = 1.197917!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'picLogo
        '
        Me.picLogo.Border.BottomColor = System.Drawing.Color.Black
        Me.picLogo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.picLogo.Border.LeftColor = System.Drawing.Color.Black
        Me.picLogo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.picLogo.Border.RightColor = System.Drawing.Color.Black
        Me.picLogo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.picLogo.Border.TopColor = System.Drawing.Color.Black
        Me.picLogo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.picLogo.Height = 1.125!
        Me.picLogo.Image = Nothing
        Me.picLogo.ImageData = Nothing
        Me.picLogo.Left = 0.3125!
        Me.picLogo.LineWeight = 0.0!
        Me.picLogo.Name = "picLogo"
        Me.picLogo.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.picLogo.Top = 0.0!
        Me.picLogo.Width = 1.75!
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.Border.BottomColor = System.Drawing.Color.Black
        Me.lblNombreEmpresa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNombreEmpresa.Border.LeftColor = System.Drawing.Color.Black
        Me.lblNombreEmpresa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNombreEmpresa.Border.RightColor = System.Drawing.Color.Black
        Me.lblNombreEmpresa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNombreEmpresa.Border.TopColor = System.Drawing.Color.Black
        Me.lblNombreEmpresa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNombreEmpresa.Height = 0.25!
        Me.lblNombreEmpresa.HyperLink = Nothing
        Me.lblNombreEmpresa.Left = 0.0!
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Style = "ddo-char-set: 0; text-decoration: none; text-align: center; font-weight: bold; fo" & _
            "nt-size: 12.75pt; "
        Me.lblNombreEmpresa.Text = ""
        Me.lblNombreEmpresa.Top = 0.125!
        Me.lblNombreEmpresa.Width = 7.5!
        '
        'lblSiglas
        '
        Me.lblSiglas.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSiglas.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSiglas.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSiglas.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSiglas.Border.RightColor = System.Drawing.Color.Black
        Me.lblSiglas.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSiglas.Border.TopColor = System.Drawing.Color.Black
        Me.lblSiglas.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSiglas.Height = 0.1875!
        Me.lblSiglas.HyperLink = Nothing
        Me.lblSiglas.Left = 0.0!
        Me.lblSiglas.Name = "lblSiglas"
        Me.lblSiglas.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.lblSiglas.Text = ""
        Me.lblSiglas.Top = 0.5!
        Me.lblSiglas.Width = 7.5!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'rptEncabezadoReportes
        '
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.510417!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNombreEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSiglas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents picLogo As DataDynamics.ActiveReports.Picture
    Friend WithEvents lblNombreEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSiglas As DataDynamics.ActiveReports.Label
End Class
