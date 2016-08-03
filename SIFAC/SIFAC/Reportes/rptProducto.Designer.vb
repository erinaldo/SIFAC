<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptProducto 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptProducto))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.lblModelo = New DataDynamics.ActiveReports.Label
        Me.lblMarca = New DataDynamics.ActiveReports.Label
        Me.lblCilindraje = New DataDynamics.ActiveReports.Label
        Me.chkActivo = New DataDynamics.ActiveReports.CheckBox
        Me.txtModelo = New DataDynamics.ActiveReports.TextBox
        Me.txtMarca = New DataDynamics.ActiveReports.TextBox
        Me.txtCilindraje = New DataDynamics.ActiveReports.TextBox
        Me.lblActivo = New DataDynamics.ActiveReports.Label
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.lblID = New DataDynamics.ActiveReports.Label
        Me.txtSegmento = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.txtPage = New DataDynamics.ActiveReports.ReportInfo
        Me.Picture1 = New DataDynamics.ActiveReports.Picture
        Me.Line1 = New DataDynamics.ActiveReports.Line
        CType(Me.lblModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCilindraje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCilindraje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSegmento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblModelo, Me.lblMarca, Me.lblCilindraje, Me.chkActivo, Me.txtModelo, Me.txtMarca, Me.txtCilindraje, Me.lblActivo})
        Me.Detail1.Height = 0.9375!
        Me.Detail1.Name = "Detail1"
        '
        'lblModelo
        '
        Me.lblModelo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblModelo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblModelo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblModelo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblModelo.Border.RightColor = System.Drawing.Color.Black
        Me.lblModelo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblModelo.Border.TopColor = System.Drawing.Color.Black
        Me.lblModelo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblModelo.Height = 0.1875!
        Me.lblModelo.HyperLink = Nothing
        Me.lblModelo.Left = 0.125!
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblModelo.Text = "Modelo:"
        Me.lblModelo.Top = 0.02083333!
        Me.lblModelo.Width = 0.75!
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
        Me.lblMarca.Height = 0.1875!
        Me.lblMarca.HyperLink = Nothing
        Me.lblMarca.Left = 0.125!
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblMarca.Text = "Marca:"
        Me.lblMarca.Top = 0.25!
        Me.lblMarca.Width = 0.75!
        '
        'lblCilindraje
        '
        Me.lblCilindraje.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCilindraje.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCilindraje.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCilindraje.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCilindraje.Border.RightColor = System.Drawing.Color.Black
        Me.lblCilindraje.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCilindraje.Border.TopColor = System.Drawing.Color.Black
        Me.lblCilindraje.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCilindraje.Height = 0.1875!
        Me.lblCilindraje.HyperLink = Nothing
        Me.lblCilindraje.Left = 0.125!
        Me.lblCilindraje.Name = "lblCilindraje"
        Me.lblCilindraje.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblCilindraje.Text = "Cilindraje:"
        Me.lblCilindraje.Top = 0.4895833!
        Me.lblCilindraje.Width = 0.75!
        '
        'chkActivo
        '
        Me.chkActivo.Border.BottomColor = System.Drawing.Color.Black
        Me.chkActivo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkActivo.Border.LeftColor = System.Drawing.Color.Black
        Me.chkActivo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkActivo.Border.RightColor = System.Drawing.Color.Black
        Me.chkActivo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkActivo.Border.TopColor = System.Drawing.Color.Black
        Me.chkActivo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.chkActivo.DataField = "Activo"
        Me.chkActivo.Height = 0.1875!
        Me.chkActivo.Left = 0.9375!
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Style = ""
        Me.chkActivo.Text = ""
        Me.chkActivo.Top = 0.71875!
        Me.chkActivo.Width = 0.1875!
        '
        'txtModelo
        '
        Me.txtModelo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtModelo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtModelo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtModelo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtModelo.Border.RightColor = System.Drawing.Color.Black
        Me.txtModelo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtModelo.Border.TopColor = System.Drawing.Color.Black
        Me.txtModelo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtModelo.DataField = "Modelo"
        Me.txtModelo.Height = 0.1875!
        Me.txtModelo.Left = 0.9375!
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtModelo.Text = "Modelo"
        Me.txtModelo.Top = 0.02083333!
        Me.txtModelo.Width = 5.375!
        '
        'txtMarca
        '
        Me.txtMarca.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMarca.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMarca.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca.Border.RightColor = System.Drawing.Color.Black
        Me.txtMarca.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca.Border.TopColor = System.Drawing.Color.Black
        Me.txtMarca.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMarca.DataField = "Marca"
        Me.txtMarca.Height = 0.1875!
        Me.txtMarca.Left = 0.9375!
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtMarca.Text = "Marca"
        Me.txtMarca.Top = 0.25!
        Me.txtMarca.Width = 5.375!
        '
        'txtCilindraje
        '
        Me.txtCilindraje.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCilindraje.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCilindraje.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCilindraje.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCilindraje.Border.RightColor = System.Drawing.Color.Black
        Me.txtCilindraje.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCilindraje.Border.TopColor = System.Drawing.Color.Black
        Me.txtCilindraje.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCilindraje.DataField = "Cilindraje"
        Me.txtCilindraje.Height = 0.1875!
        Me.txtCilindraje.Left = 0.9375!
        Me.txtCilindraje.Name = "txtCilindraje"
        Me.txtCilindraje.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtCilindraje.Text = "Cilindraje"
        Me.txtCilindraje.Top = 0.4895833!
        Me.txtCilindraje.Width = 5.375!
        '
        'lblActivo
        '
        Me.lblActivo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblActivo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblActivo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblActivo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblActivo.Border.RightColor = System.Drawing.Color.Black
        Me.lblActivo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblActivo.Border.TopColor = System.Drawing.Color.Black
        Me.lblActivo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblActivo.Height = 0.1875!
        Me.lblActivo.HyperLink = Nothing
        Me.lblActivo.Left = 0.125!
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblActivo.Text = "Activo:"
        Me.lblActivo.Top = 0.71875!
        Me.lblActivo.Width = 0.75!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.lblID, Me.txtSegmento})
        Me.GroupHeader1.DataField = "objSegmentoID"
        Me.GroupHeader1.Height = 0.2708333!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.Gainsboro
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 0.25!
        Me.Shape1.Left = 0.08333334!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.0!
        Me.Shape1.Width = 6.3125!
        '
        'lblID
        '
        Me.lblID.Border.BottomColor = System.Drawing.Color.Black
        Me.lblID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblID.Border.LeftColor = System.Drawing.Color.Black
        Me.lblID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblID.Border.RightColor = System.Drawing.Color.Black
        Me.lblID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblID.Border.TopColor = System.Drawing.Color.Black
        Me.lblID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblID.Height = 0.1875!
        Me.lblID.HyperLink = ""
        Me.lblID.Left = 0.125!
        Me.lblID.Name = "lblID"
        Me.lblID.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblID.Text = "Segmento"
        Me.lblID.Top = 0.04166667!
        Me.lblID.Width = 0.75!
        '
        'txtSegmento
        '
        Me.txtSegmento.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSegmento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSegmento.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSegmento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSegmento.Border.RightColor = System.Drawing.Color.Black
        Me.txtSegmento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSegmento.Border.TopColor = System.Drawing.Color.Black
        Me.txtSegmento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSegmento.DataField = "Segmento"
        Me.txtSegmento.Height = 0.1875!
        Me.txtSegmento.Left = 0.9375!
        Me.txtSegmento.Name = "txtSegmento"
        Me.txtSegmento.Style = ""
        Me.txtSegmento.Text = "Segmento"
        Me.txtSegmento.Top = 0.04166667!
        Me.txtSegmento.Width = 5.375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo, Me.Picture1, Me.Line1})
        Me.PageHeader1.Height = 0.5520833!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.lblTitulo.Left = 1.875!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "color: SteelBlue; ddo-char-set: 0; font-weight: bold; font-size: 14.25pt; font-fa" & _
            "mily: Times New Roman; "
        Me.lblTitulo.Text = "LISTADO DE PRODUCTOS"
        Me.lblTitulo.Top = 0.1875!
        Me.lblTitulo.Width = 2.6875!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPage})
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'txtPage
        '
        Me.txtPage.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPage.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPage.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPage.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPage.Border.RightColor = System.Drawing.Color.Black
        Me.txtPage.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPage.Border.TopColor = System.Drawing.Color.Black
        Me.txtPage.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPage.FormatString = "Page {PageNumber} of {PageCount}"
        Me.txtPage.Height = 0.1875!
        Me.txtPage.Left = 5.3125!
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Style = ""
        Me.txtPage.Top = 0.0!
        Me.txtPage.Width = 1.0625!
        '
        'Picture1
        '
        Me.Picture1.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.RightColor = System.Drawing.Color.Black
        Me.Picture1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.TopColor = System.Drawing.Color.Black
        Me.Picture1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Height = 0.375!
        Me.Picture1.Image = Nothing
        Me.Picture1.ImageData = Nothing
        Me.Picture1.Left = 5.125!
        Me.Picture1.LineWeight = 0.0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture1.Top = 0.0625!
        Me.Picture1.Width = 1.0!
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
        Me.Line1.LineColor = System.Drawing.Color.SteelBlue
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.5!
        Me.Line1.Width = 6.0625!
        Me.Line1.X1 = 0.125!
        Me.Line1.X2 = 6.1875!
        Me.Line1.Y1 = 0.5!
        Me.Line1.Y2 = 0.5!
        '
        'rptProducto
        '
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.lblModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCilindraje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCilindraje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSegmento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents lblID As DataDynamics.ActiveReports.Label
    Friend WithEvents txtSegmento As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblModelo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblMarca As DataDynamics.ActiveReports.Label
    Friend WithEvents lblCilindraje As DataDynamics.ActiveReports.Label
    Friend WithEvents chkActivo As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents txtModelo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtMarca As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCilindraje As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblActivo As DataDynamics.ActiveReports.Label
    Friend WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    Friend WithEvents txtPage As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
End Class
