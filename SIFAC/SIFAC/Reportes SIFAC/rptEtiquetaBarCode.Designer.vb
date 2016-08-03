<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEtiquetaBarCode 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptEtiquetaBarCode))
        Me.Encabezado_Pagina = New DataDynamics.ActiveReports.PageHeader
        Me.Detalle = New DataDynamics.ActiveReports.Detail
        Me.brCodigo = New DataDynamics.ActiveReports.Barcode
        Me.txtCodigoRepuesto = New DataDynamics.ActiveReports.TextBox
        Me.lblEmpresa = New DataDynamics.ActiveReports.Label
        Me.Pie_Pagina = New DataDynamics.ActiveReports.PageFooter
        CType(Me.txtCodigoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detalle.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.brCodigo, Me.txtCodigoRepuesto, Me.lblEmpresa})
        Me.Detalle.Height = 0.9270833!
        Me.Detalle.Name = "Detalle"
        '
        'brCodigo
        '
        Me.brCodigo.Border.BottomColor = System.Drawing.Color.Black
        Me.brCodigo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.brCodigo.Border.LeftColor = System.Drawing.Color.Black
        Me.brCodigo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.brCodigo.Border.RightColor = System.Drawing.Color.Black
        Me.brCodigo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.brCodigo.Border.TopColor = System.Drawing.Color.Black
        Me.brCodigo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.brCodigo.CheckSumEnabled = False
        Me.brCodigo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brCodigo.Height = 0.5!
        Me.brCodigo.Left = 0.0625!
        Me.brCodigo.Name = "brCodigo"
        Me.brCodigo.Style = DataDynamics.ActiveReports.BarCodeStyle.Code39
        Me.brCodigo.Text = "123"
        Me.brCodigo.Top = 0.1875!
        Me.brCodigo.Width = 1.625!
        '
        'txtCodigoRepuesto
        '
        Me.txtCodigoRepuesto.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoRepuesto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoRepuesto.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoRepuesto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoRepuesto.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoRepuesto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoRepuesto.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoRepuesto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoRepuesto.Height = 0.1875!
        Me.txtCodigoRepuesto.Left = 0.0625!
        Me.txtCodigoRepuesto.Name = "txtCodigoRepuesto"
        Me.txtCodigoRepuesto.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; "
        Me.txtCodigoRepuesto.Text = "SivRepuestoID"
        Me.txtCodigoRepuesto.Top = 0.6875!
        Me.txtCodigoRepuesto.Width = 1.625!
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
        Me.lblEmpresa.Height = 0.1875!
        Me.lblEmpresa.HyperLink = Nothing
        Me.lblEmpresa.Left = 0.0625!
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; "
        Me.lblEmpresa.Text = "United Motors"
        Me.lblEmpresa.Top = 0.0!
        Me.lblEmpresa.Width = 1.625!
        '
        'Pie_Pagina
        '
        Me.Pie_Pagina.Height = 0.0!
        Me.Pie_Pagina.Name = "Pie_Pagina"
        '
        'rptEtiquetaBarCode
        '
        Me.PageSettings.Margins.Left = 0.3!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 1.739583!
        Me.Sections.Add(Me.Encabezado_Pagina)
        Me.Sections.Add(Me.Detalle)
        Me.Sections.Add(Me.Pie_Pagina)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtCodigoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents brCodigo As DataDynamics.ActiveReports.Barcode
    Friend WithEvents txtCodigoRepuesto As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblEmpresa As DataDynamics.ActiveReports.Label
End Class
