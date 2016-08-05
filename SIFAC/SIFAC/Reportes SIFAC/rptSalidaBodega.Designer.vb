<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptSalidaBodega 
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
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSalidaBodega))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCodigoRepuesto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescripcionCorta1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidad1 = New DataDynamics.ActiveReports.TextBox
        Me.txtcosto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtsubtotal1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.txtUsuario = New DataDynamics.ActiveReports.TextBox
        Me.txtUsuario1 = New DataDynamics.ActiveReports.TextBox
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.srpEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.shpFondo = New DataDynamics.ActiveReports.Shape
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.CheckBox1 = New DataDynamics.ActiveReports.CheckBox
        Me.txtTipoSalida1 = New DataDynamics.ActiveReports.TextBox
        Me.txtFechaSalida1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSivSalidaBodegaID1 = New DataDynamics.ActiveReports.TextBox
        Me.txtBodega1 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.RichTextBox1 = New DataDynamics.ActiveReports.RichTextBox
        CType(Me.txtCodigoRepuesto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCorta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcosto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubtotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoSalida1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaSalida1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivSalidaBodegaID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBodega1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 0.1875!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodigoRepuesto1, Me.txtDescripcionCorta1, Me.txtCantidad1, Me.txtcosto1, Me.txtsubtotal1})
        Me.Detail1.Height = 0.2291667!
        Me.Detail1.Name = "Detail1"
        '
        'txtCodigoRepuesto1
        '
        Me.txtCodigoRepuesto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoRepuesto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoRepuesto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoRepuesto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoRepuesto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoRepuesto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoRepuesto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoRepuesto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoRepuesto1.DataField = "Codigo"
        Me.txtCodigoRepuesto1.Height = 0.1875!
        Me.txtCodigoRepuesto1.Left = 0.3645833!
        Me.txtCodigoRepuesto1.Name = "txtCodigoRepuesto1"
        Me.txtCodigoRepuesto1.Style = "text-align: center; "
        Me.txtCodigoRepuesto1.Text = "txtCodigoRepuesto1"
        Me.txtCodigoRepuesto1.Top = 0.0!
        Me.txtCodigoRepuesto1.Width = 0.75!
        '
        'txtobjProveedorID1
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
        Me.txtDescripcionCorta1.Left = 2.364583!
        Me.txtDescripcionCorta1.Name = "txtDescripcionCorta1"
        Me.txtDescripcionCorta1.Style = ""
        Me.txtDescripcionCorta1.Text = "txtDescripcionCorta1"
        Me.txtDescripcionCorta1.Top = 0.0!
        Me.txtDescripcionCorta1.Width = 1.625!
        '
        'txtCantidad1
        '
        Me.txtCantidad1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCantidad1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidad1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCantidad1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidad1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCantidad1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidad1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCantidad1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCantidad1.DataField = "Cantidad"
        Me.txtCantidad1.Height = 0.1875!
        Me.txtCantidad1.Left = 4.052083!
        Me.txtCantidad1.Name = "txtCantidad1"
        Me.txtCantidad1.Style = ""
        Me.txtCantidad1.Text = "txtCantidad1"
        Me.txtCantidad1.Top = 0.0!
        Me.txtCantidad1.Width = 0.75!
        '
        'txtcosto1
        '
        Me.txtcosto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtcosto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtcosto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtcosto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtcosto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtcosto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtcosto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtcosto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtcosto1.DataField = "costo"
        Me.txtcosto1.Height = 0.1875!
        Me.txtcosto1.Left = 4.864583!
        Me.txtcosto1.Name = "txtcosto1"
        Me.txtcosto1.OutputFormat = resources.GetString("txtcosto1.OutputFormat")
        Me.txtcosto1.Style = "text-align: right; "
        Me.txtcosto1.Text = "txtcosto1"
        Me.txtcosto1.Top = 0.0!
        Me.txtcosto1.Width = 0.875!
        '
        'txtsubtotal1
        '
        Me.txtsubtotal1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtsubtotal1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtsubtotal1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtsubtotal1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtsubtotal1.Border.RightColor = System.Drawing.Color.Black
        Me.txtsubtotal1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtsubtotal1.Border.TopColor = System.Drawing.Color.Black
        Me.txtsubtotal1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtsubtotal1.DataField = "subtotal"
        Me.txtsubtotal1.Height = 0.1875!
        Me.txtsubtotal1.Left = 5.802083!
        Me.txtsubtotal1.Name = "txtsubtotal1"
        Me.txtsubtotal1.OutputFormat = resources.GetString("txtsubtotal1.OutputFormat")
        Me.txtsubtotal1.Style = "text-align: right; "
        Me.txtsubtotal1.Text = "txtsubtotal1"
        Me.txtsubtotal1.Top = 0.0!
        Me.txtsubtotal1.Width = 1.0!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line1, Me.Label13, Me.Line2, Me.Label14, Me.txtUsuario, Me.txtUsuario1})
        Me.PageFooter1.Height = 1.072917!
        Me.PageFooter1.Name = "PageFooter1"
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
        Me.Line1.Left = 0.3125!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.375!
        Me.Line1.Width = 1.5625!
        Me.Line1.X1 = 0.3125!
        Me.Line1.X2 = 1.875!
        Me.Line1.Y1 = 0.375!
        Me.Line1.Y2 = 0.375!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.1875!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.4375!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label13.Text = "Elaborado por"
        Me.Label13.Top = 0.4375!
        Me.Label13.Width = 1.25!
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
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 4.75!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.375!
        Me.Line2.Width = 1.5625!
        Me.Line2.X1 = 4.75!
        Me.Line2.X2 = 6.3125!
        Me.Line2.Y1 = 0.375!
        Me.Line2.Y2 = 0.375!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 4.875!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label14.Text = "Autorizado por"
        Me.Label14.Top = 0.4375!
        Me.Label14.Width = 1.25!
        '
        'txtUsuario
        '
        Me.txtUsuario.Border.BottomColor = System.Drawing.Color.Black
        Me.txtUsuario.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUsuario.Border.LeftColor = System.Drawing.Color.Black
        Me.txtUsuario.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUsuario.Border.RightColor = System.Drawing.Color.Black
        Me.txtUsuario.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUsuario.Border.TopColor = System.Drawing.Color.Black
        Me.txtUsuario.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUsuario.Height = 0.1875!
        Me.txtUsuario.Left = 0.0!
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.txtUsuario.Text = "Usuario"
        Me.txtUsuario.Top = 0.6875!
        Me.txtUsuario.Width = 2.25!
        '
        'txtUsuario1
        '
        Me.txtUsuario1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtUsuario1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUsuario1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtUsuario1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUsuario1.Border.RightColor = System.Drawing.Color.Black
        Me.txtUsuario1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUsuario1.Border.TopColor = System.Drawing.Color.Black
        Me.txtUsuario1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUsuario1.Height = 0.1875!
        Me.txtUsuario1.Left = 4.375!
        Me.txtUsuario1.Name = "txtUsuario1"
        Me.txtUsuario1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.txtUsuario1.Text = "Usuario"
        Me.txtUsuario1.Top = 0.6875!
        Me.txtUsuario1.Width = 2.25!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srpEncabezado, Me.lblTitulo})
        Me.ReportHeader1.Height = 1.635417!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'srpEncabezado
        '
        Me.srpEncabezado.Border.BottomColor = System.Drawing.Color.Black
        Me.srpEncabezado.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srpEncabezado.Border.LeftColor = System.Drawing.Color.Black
        Me.srpEncabezado.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srpEncabezado.Border.RightColor = System.Drawing.Color.Black
        Me.srpEncabezado.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srpEncabezado.Border.TopColor = System.Drawing.Color.Black
        Me.srpEncabezado.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srpEncabezado.CloseBorder = False
        Me.srpEncabezado.Height = 1.125!
        Me.srpEncabezado.Left = 0.0!
        Me.srpEncabezado.Name = "srpEncabezado"
        Me.srpEncabezado.Report = Nothing
        Me.srpEncabezado.ReportName = "SubReport1"
        Me.srpEncabezado.Top = 0.0!
        Me.srpEncabezado.Width = 7.125!
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
        Me.lblTitulo.Text = "HOJA DE SALIDA"
        Me.lblTitulo.Top = 1.25!
        Me.lblTitulo.Width = 7.125!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.25!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.shpFondo, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.CheckBox1, Me.txtTipoSalida1, Me.txtFechaSalida1, Me.txtSivSalidaBodegaID1, Me.txtBodega1})
        Me.GroupHeader1.DataField = "SivSalidaBodegaID"
        Me.GroupHeader1.Height = 1.104167!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.shpFondo.Height = 0.3125!
        Me.shpFondo.Left = 0.34375!
        Me.shpFondo.Name = "shpFondo"
        Me.shpFondo.RoundingRadius = 9.999999!
        Me.shpFondo.Top = 0.7916667!
        Me.shpFondo.Width = 6.4375!
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
        Me.Label1.Left = 0.46875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; ddo-char-set: 0; font-weight: bold; font-size: 8pt; "
        Me.Label1.Text = "Código"
        Me.Label1.Top = 0.8541667!
        Me.Label1.Width = 0.625!
        '
        'Label2
        '
        
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
        Me.Label3.Left = 2.46875!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; ddo-char-set: 0; font-weight: bold; font-size: 8pt; "
        Me.Label3.Text = "Descripción"
        Me.Label3.Top = 0.8541667!
        Me.Label3.Width = 1.5!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.03125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: Black; ddo-char-set: 0; font-weight: bold; font-size: 8pt; "
        Me.Label4.Text = "Cantidad"
        Me.Label4.Top = 0.8541667!
        Me.Label4.Width = 0.625!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 4.78125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "color: Black; ddo-char-set: 0; font-weight: bold; font-size: 8pt; "
        Me.Label5.Text = "Costo Unit"
        Me.Label5.Top = 0.8541667!
        Me.Label5.Width = 0.875!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 5.84375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "color: Black; ddo-char-set: 0; font-weight: bold; font-size: 8pt; "
        Me.Label6.Text = "SubTotal"
        Me.Label6.Top = 0.8541667!
        Me.Label6.Width = 0.75!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.0625!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label7.Text = "Número:"
        Me.Label7.Top = 0.125!
        Me.Label7.Width = 0.6875!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.0625!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label8.Text = "Bodega:"
        Me.Label8.Top = 0.4375!
        Me.Label8.Width = 0.6875!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 2.875!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label9.Text = "Fecha:"
        Me.Label9.Top = 0.0625!
        Me.Label9.Width = 0.6875!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 2.875!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label10.Text = "Tipo Salida:"
        Me.Label10.Top = 0.375!
        Me.Label10.Width = 0.9375!
        '
        'CheckBox1
        '
        Me.CheckBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.CheckBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.CheckBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox1.Border.RightColor = System.Drawing.Color.Black
        Me.CheckBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox1.Border.TopColor = System.Drawing.Color.Black
        Me.CheckBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox1.DataField = "Anulada"
        Me.CheckBox1.Height = 0.1875!
        Me.CheckBox1.Left = 5.9375!
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.CheckBox1.Text = "Anulada"
        Me.CheckBox1.Top = 0.0625!
        Me.CheckBox1.Width = 1.0625!
        '
        'txtTipoSalida1
        '
        Me.txtTipoSalida1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTipoSalida1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTipoSalida1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTipoSalida1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTipoSalida1.Border.RightColor = System.Drawing.Color.Black
        Me.txtTipoSalida1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTipoSalida1.Border.TopColor = System.Drawing.Color.Black
        Me.txtTipoSalida1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTipoSalida1.DataField = "TipoSalida"
        Me.txtTipoSalida1.Height = 0.1875!
        Me.txtTipoSalida1.Left = 3.9375!
        Me.txtTipoSalida1.Name = "txtTipoSalida1"
        Me.txtTipoSalida1.Style = ""
        Me.txtTipoSalida1.Text = "txtTipoSalida1"
        Me.txtTipoSalida1.Top = 0.375!
        Me.txtTipoSalida1.Width = 1.5!
        '
        'txtFechaSalida1
        '
        Me.txtFechaSalida1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFechaSalida1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaSalida1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFechaSalida1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaSalida1.Border.RightColor = System.Drawing.Color.Black
        Me.txtFechaSalida1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaSalida1.Border.TopColor = System.Drawing.Color.Black
        Me.txtFechaSalida1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaSalida1.DataField = "FechaSalida"
        Me.txtFechaSalida1.Height = 0.1875!
        Me.txtFechaSalida1.Left = 3.9375!
        Me.txtFechaSalida1.Name = "txtFechaSalida1"
        Me.txtFechaSalida1.OutputFormat = resources.GetString("txtFechaSalida1.OutputFormat")
        Me.txtFechaSalida1.Style = ""
        Me.txtFechaSalida1.Text = "txtFechaSalida1"
        Me.txtFechaSalida1.Top = 0.0625!
        Me.txtFechaSalida1.Width = 1.5!
        '
        'txtSivSalidaBodegaID1
        '
        Me.txtSivSalidaBodegaID1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSivSalidaBodegaID1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivSalidaBodegaID1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSivSalidaBodegaID1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivSalidaBodegaID1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSivSalidaBodegaID1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivSalidaBodegaID1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSivSalidaBodegaID1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSivSalidaBodegaID1.DataField = "SivSalidaBodegaID"
        Me.txtSivSalidaBodegaID1.Height = 0.1875!
        Me.txtSivSalidaBodegaID1.Left = 0.875!
        Me.txtSivSalidaBodegaID1.Name = "txtSivSalidaBodegaID1"
        Me.txtSivSalidaBodegaID1.Style = ""
        Me.txtSivSalidaBodegaID1.Text = "txtSivSalidaBodegaID1"
        Me.txtSivSalidaBodegaID1.Top = 0.125!
        Me.txtSivSalidaBodegaID1.Width = 1.25!
        '
        'txtBodega1
        '
        Me.txtBodega1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBodega1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBodega1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBodega1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBodega1.Border.RightColor = System.Drawing.Color.Black
        Me.txtBodega1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBodega1.Border.TopColor = System.Drawing.Color.Black
        Me.txtBodega1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBodega1.DataField = "Bodega"
        Me.txtBodega1.Height = 0.1875!
        Me.txtBodega1.Left = 0.875!
        Me.txtBodega1.Name = "txtBodega1"
        Me.txtBodega1.Style = ""
        Me.txtBodega1.Text = "txtBodega1"
        Me.txtBodega1.Top = 0.4375!
        Me.txtBodega1.Width = 1.25!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label11, Me.TextBox1, Me.Label12, Me.RichTextBox1})
        Me.GroupFooter1.Height = 1.197917!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 4.8125!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label11.Text = "Total:"
        Me.Label11.Top = 0.125!
        Me.Label11.Width = 0.5!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "subtotal"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 5.8125!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "text-align: right; "
        Me.TextBox1.SummaryGroup = "GroupHeader1"
        Me.TextBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.125!
        Me.TextBox1.Width = 1.0!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0625!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label12.Text = "Comentarios:"
        Me.Label12.Top = 0.5!
        Me.Label12.Width = 0.9375!
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AutoReplaceFields = True
        Me.RichTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RichTextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.RichTextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RichTextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.RichTextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RichTextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.RichTextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RichTextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.RichTextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.RichTextBox1.DataField = "Comentarios"
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Height = 0.4375!
        Me.RichTextBox1.Left = 1.25!
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.RTF = resources.GetString("RichTextBox1.RTF")
        Me.RichTextBox1.Top = 0.5!
        Me.RichTextBox1.Width = 5.5625!
        '
        'rptSalidaBodega
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
            "Catalog=SIFUM2505;Data Source=Desarrollo2"
        OleDBDataSource1.SQL = "Select * from vwRptSalidaBodega"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.28125!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtCodigoRepuesto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCorta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcosto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubtotal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoSalida1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaSalida1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivSalidaBodegaID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBodega1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents srpEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents shpFondo As DataDynamics.ActiveReports.Shape
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents CheckBox1 As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents txtCodigoRepuesto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTipoSalida1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFechaSalida1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSivSalidaBodegaID1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBodega1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescripcionCorta1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidad1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtcosto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtsubtotal1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents RichTextBox1 As DataDynamics.ActiveReports.RichTextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtUsuario As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUsuario1 As DataDynamics.ActiveReports.TextBox
End Class
