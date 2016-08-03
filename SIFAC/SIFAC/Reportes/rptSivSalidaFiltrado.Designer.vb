<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptSivSalidaFiltrado 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptSivSalidaFiltrado))
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCodigoRepuesto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtobjProveedorID1 = New DataDynamics.ActiveReports.TextBox
        Me.txtDescripcionCorta1 = New DataDynamics.ActiveReports.TextBox
        Me.txtCantidad1 = New DataDynamics.ActiveReports.TextBox
        Me.txtcosto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtsubtotal1 = New DataDynamics.ActiveReports.TextBox
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.CheckBox1 = New DataDynamics.ActiveReports.CheckBox
        Me.txtFechaSalida1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSivSalidaBodegaID1 = New DataDynamics.ActiveReports.TextBox
        Me.txtTipoSalida1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.txtFechaDesde = New DataDynamics.ActiveReports.TextBox
        Me.txtFechaHasta = New DataDynamics.ActiveReports.TextBox
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Group_Bodega = New DataDynamics.ActiveReports.GroupHeader
        Me.shpFondo = New DataDynamics.ActiveReports.Shape
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.Group_Salida = New DataDynamics.ActiveReports.GroupHeader
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.srpEncabezado = New DataDynamics.ActiveReports.SubReport
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        CType(Me.txtCodigoRepuesto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtobjProveedorID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCorta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcosto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubtotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaSalida1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSivSalidaBodegaID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoSalida1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 0.01041667!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodigoRepuesto1, Me.txtobjProveedorID1, Me.txtDescripcionCorta1, Me.txtCantidad1, Me.txtcosto1, Me.txtsubtotal1, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line1})
        Me.Detail1.Height = 0.3020833!
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
        Me.txtCodigoRepuesto1.DataField = "CodigoRepuesto"
        Me.txtCodigoRepuesto1.Height = 0.1875!
        Me.txtCodigoRepuesto1.Left = 0.0625!
        Me.txtCodigoRepuesto1.Name = "txtCodigoRepuesto1"
        Me.txtCodigoRepuesto1.Style = "text-align: center; "
        Me.txtCodigoRepuesto1.Text = "txtCodigoRepuesto1"
        Me.txtCodigoRepuesto1.Top = 0.0625!
        Me.txtCodigoRepuesto1.Width = 0.8125!
        '
        'txtobjProveedorID1
        '
        Me.txtobjProveedorID1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtobjProveedorID1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtobjProveedorID1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtobjProveedorID1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtobjProveedorID1.Border.RightColor = System.Drawing.Color.Black
        Me.txtobjProveedorID1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtobjProveedorID1.Border.TopColor = System.Drawing.Color.Black
        Me.txtobjProveedorID1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtobjProveedorID1.DataField = "objProveedorID"
        Me.txtobjProveedorID1.Height = 0.1875!
        Me.txtobjProveedorID1.Left = 1.0625!
        Me.txtobjProveedorID1.Name = "txtobjProveedorID1"
        Me.txtobjProveedorID1.Style = "text-align: center; "
        Me.txtobjProveedorID1.Text = "txtobjProveedorID1"
        Me.txtobjProveedorID1.Top = 0.0625!
        Me.txtobjProveedorID1.Width = 1.25!
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
        Me.txtDescripcionCorta1.Left = 2.5625!
        Me.txtDescripcionCorta1.Name = "txtDescripcionCorta1"
        Me.txtDescripcionCorta1.Style = ""
        Me.txtDescripcionCorta1.Text = "txtDescripcionCorta1"
        Me.txtDescripcionCorta1.Top = 0.0625!
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
        Me.txtCantidad1.Left = 4.3125!
        Me.txtCantidad1.Name = "txtCantidad1"
        Me.txtCantidad1.Style = "text-align: center; "
        Me.txtCantidad1.Text = "txtCantidad1"
        Me.txtCantidad1.Top = 0.0625!
        Me.txtCantidad1.Width = 0.625!
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
        Me.txtcosto1.Left = 5.125!
        Me.txtcosto1.Name = "txtcosto1"
        Me.txtcosto1.OutputFormat = resources.GetString("txtcosto1.OutputFormat")
        Me.txtcosto1.Style = "text-align: right; "
        Me.txtcosto1.Text = "txtcosto1"
        Me.txtcosto1.Top = 0.0625!
        Me.txtcosto1.Width = 0.8125!
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
        Me.txtsubtotal1.Left = 6.125!
        Me.txtsubtotal1.Name = "txtsubtotal1"
        Me.txtsubtotal1.OutputFormat = resources.GetString("txtsubtotal1.OutputFormat")
        Me.txtsubtotal1.Style = "text-align: right; "
        Me.txtsubtotal1.Text = "txtsubtotal1"
        Me.txtsubtotal1.Top = 0.0625!
        Me.txtsubtotal1.Width = 0.9375!
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Shape1.Height = 0.3125!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.375!
        Me.Shape1.Width = 7.13!
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
        Me.Label4.Left = 0.0625!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9pt; "
        Me.Label4.Text = "Código"
        Me.Label4.Top = 0.4375!
        Me.Label4.Width = 0.8125!
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
        Me.Label5.Left = 1.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label5.Text = "Código Proveedor"
        Me.Label5.Top = 0.4375!
        Me.Label5.Width = 1.375!
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
        Me.Label6.Left = 2.5625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label6.Text = "Descripción"
        Me.Label6.Top = 0.4375!
        Me.Label6.Width = 1.625!
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
        Me.Label7.Left = 4.3125!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label7.Text = "Cantidad"
        Me.Label7.Top = 0.4375!
        Me.Label7.Width = 0.625!
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
        Me.Label8.Left = 5.0625!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label8.Text = "Costo Unitario"
        Me.Label8.Top = 0.4375!
        Me.Label8.Width = 0.9375!
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
        Me.Label9.Left = 6.1875!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label9.Text = "SubTotal"
        Me.Label9.Top = 0.4375!
        Me.Label9.Width = 0.875!
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
        Me.Label10.Left = 0.125!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label10.Text = "Número:"
        Me.Label10.Top = 0.0625!
        Me.Label10.Width = 0.6875!
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
        Me.Label11.Left = 1.9375!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label11.Text = "Fecha:"
        Me.Label11.Top = 0.0625!
        Me.Label11.Width = 0.5!
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
        Me.Label12.Left = 3.6875!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label12.Text = "Tipo Salida:"
        Me.Label12.Top = 0.0625!
        Me.Label12.Width = 0.9375!
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
        Me.CheckBox1.Height = 0.1979167!
        Me.CheckBox1.Left = 6.125!
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.CheckBox1.Text = "Anulada"
        Me.CheckBox1.Top = 0.0625!
        Me.CheckBox1.Width = 1.0!
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
        Me.txtFechaSalida1.Left = 2.5!
        Me.txtFechaSalida1.Name = "txtFechaSalida1"
        Me.txtFechaSalida1.OutputFormat = resources.GetString("txtFechaSalida1.OutputFormat")
        Me.txtFechaSalida1.Style = ""
        Me.txtFechaSalida1.Text = "txtFechaSalida1"
        Me.txtFechaSalida1.Top = 0.0625!
        Me.txtFechaSalida1.Width = 1.0!
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
        Me.txtSivSalidaBodegaID1.Height = 0.2!
        Me.txtSivSalidaBodegaID1.Left = 0.8125!
        Me.txtSivSalidaBodegaID1.Name = "txtSivSalidaBodegaID1"
        Me.txtSivSalidaBodegaID1.Style = ""
        Me.txtSivSalidaBodegaID1.Text = "txtSivSalidaBodegaID1"
        Me.txtSivSalidaBodegaID1.Top = 0.0625!
        Me.txtSivSalidaBodegaID1.Width = 1.0!
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
        Me.txtTipoSalida1.Left = 4.6875!
        Me.txtTipoSalida1.Name = "txtTipoSalida1"
        Me.txtTipoSalida1.Style = ""
        Me.txtTipoSalida1.Text = "txtTipoSalida1"
        Me.txtTipoSalida1.Top = 0.0625!
        Me.txtTipoSalida1.Width = 1.3125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
        Me.PageFooter1.Height = 0.4270833!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo, Me.Label1, Me.Label2, Me.txtFechaDesde, Me.txtFechaHasta, Me.srpEncabezado})
        Me.ReportHeader1.Height = 2.125!
        Me.ReportHeader1.Name = "ReportHeader1"
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
        Me.lblTitulo.Style = "ddo-char-set: 0; color: SteelBlue; text-decoration: underline; text-align: center" & _
            "; font-weight: bold; font-size: 14.25pt; font-family: Times New Roman; vertical-" & _
            "align: middle; "
        Me.lblTitulo.Text = "REPORTE DE SALIDAS"
        Me.lblTitulo.Top = 1.25!
        Me.lblTitulo.Width = 7.125!
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
        Me.Label1.Left = 1.875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label1.Text = "Desde:"
        Me.Label1.Top = 1.6875!
        Me.Label1.Width = 0.5!
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
        Me.Label2.Left = 3.5625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label2.Text = "Hasta:"
        Me.Label2.Top = 1.6875!
        Me.Label2.Width = 0.5!
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFechaDesde.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaDesde.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFechaDesde.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaDesde.Border.RightColor = System.Drawing.Color.Black
        Me.txtFechaDesde.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaDesde.Border.TopColor = System.Drawing.Color.Black
        Me.txtFechaDesde.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaDesde.Height = 0.1979167!
        Me.txtFechaDesde.Left = 2.4375!
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.OutputFormat = resources.GetString("txtFechaDesde.OutputFormat")
        Me.txtFechaDesde.Style = "text-align: center; "
        Me.txtFechaDesde.Text = "TextBox1"
        Me.txtFechaDesde.Top = 1.6875!
        Me.txtFechaDesde.Width = 1.0!
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
        Me.txtFechaHasta.Height = 0.1979167!
        Me.txtFechaHasta.Left = 4.125!
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.OutputFormat = resources.GetString("txtFechaHasta.OutputFormat")
        Me.txtFechaHasta.Style = "text-align: center; "
        Me.txtFechaHasta.Text = "TextBox2"
        Me.txtFechaHasta.Top = 1.6875!
        Me.txtFechaHasta.Width = 1.0!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.25!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'Group_Bodega
        '
        Me.Group_Bodega.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.shpFondo, Me.Label3, Me.TextBox1})
        Me.Group_Bodega.DataField = "StbTiendaID"
        Me.Group_Bodega.Height = 0.3229167!
        Me.Group_Bodega.Name = "Group_Bodega"
        '
        'shpFondo
        '
        Me.shpFondo.BackColor = System.Drawing.Color.SteelBlue
        Me.shpFondo.Border.BottomColor = System.Drawing.Color.Black
        Me.shpFondo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondo.Border.LeftColor = System.Drawing.Color.Black
        Me.shpFondo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondo.Border.RightColor = System.Drawing.Color.Black
        Me.shpFondo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondo.Border.TopColor = System.Drawing.Color.Black
        Me.shpFondo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.shpFondo.Height = 0.3125!
        Me.shpFondo.Left = 0.0!
        Me.shpFondo.Name = "shpFondo"
        Me.shpFondo.RoundingRadius = 9.999999!
        Me.shpFondo.Top = 0.0!
        Me.shpFondo.Width = 7.125!
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
        Me.Label3.Left = 0.0625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: White; ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label3.Text = "BODEGA:"
        Me.Label3.Top = 0.0625!
        Me.Label3.Width = 0.75!
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
        Me.TextBox1.DataField = "BodegaCodigo"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.9375!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "color: White; ddo-char-set: 0; text-align: center; font-weight: bold; font-size: " & _
            "9.75pt; "
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.0625!
        Me.TextBox1.Width = 2.375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label14, Me.TextBox3})
        Me.GroupFooter1.Height = 0.3020833!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.Label14.Left = 4.75!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label14.Text = "Gran Total Salidas:"
        Me.Label14.Top = 0.0625!
        Me.Label14.Width = 1.375!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "subtotal"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 6.125!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "text-align: right; "
        Me.TextBox3.SummaryGroup = "Group_Salida"
        Me.TextBox3.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox3.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox3.Text = "TextBox2"
        Me.TextBox3.Top = 0.0625!
        Me.TextBox3.Width = 0.9375!
        '
        'Group_Salida
        '
        Me.Group_Salida.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.txtSivSalidaBodegaID1, Me.Label11, Me.Label12, Me.CheckBox1, Me.txtFechaSalida1, Me.Label10, Me.txtTipoSalida1, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line13})
        Me.Group_Salida.DataField = "SivSalidaBodegaID"
        Me.Group_Salida.Height = 0.6770833!
        Me.Group_Salida.Name = "Group_Salida"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label13, Me.TextBox2, Me.Line8})
        Me.GroupFooter2.Height = 0.3958333!
        Me.GroupFooter2.Name = "GroupFooter2"
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
        Me.Label13.Left = 5.4375!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.Label13.Text = "Total:"
        Me.Label13.Top = 0.0625!
        Me.Label13.Width = 0.625!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "subtotal"
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 6.125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "text-align: right; "
        Me.TextBox2.SummaryGroup = "Group_Salida"
        Me.TextBox2.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox2.Text = "TextBox2"
        Me.TextBox2.Top = 0.0625!
        Me.TextBox2.Width = 0.9375!
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
        Me.Line2.Height = 0.31!
        Me.Line2.Left = 0.9375!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 0.9375!
        Me.Line2.X2 = 0.9375!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.31!
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
        Me.Line3.Height = 0.31!
        Me.Line3.Left = 2.4375!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 0.002500057!
        Me.Line3.X1 = 2.4375!
        Me.Line3.X2 = 2.44!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.31!
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
        Me.Line4.Height = 0.31!
        Me.Line4.Left = 4.25!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 4.25!
        Me.Line4.X2 = 4.25!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.31!
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
        Me.Line5.Height = 0.31!
        Me.Line5.Left = 5.0!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 5.0!
        Me.Line5.X2 = 5.0!
        Me.Line5.Y1 = 0.0!
        Me.Line5.Y2 = 0.31!
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
        Me.Line6.Height = 0.3125!
        Me.Line6.Left = 6.0625!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.0!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 6.0625!
        Me.Line6.X2 = 6.0625!
        Me.Line6.Y1 = 0.0!
        Me.Line6.Y2 = 0.3125!
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
        Me.Line7.Height = 0.31!
        Me.Line7.Left = 0.0!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.0!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 0.0!
        Me.Line7.X2 = 0.0!
        Me.Line7.Y1 = 0.0!
        Me.Line7.Y2 = 0.31!
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
        Me.ReportInfo1.Style = "color: DimGray; ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.ReportInfo1.Top = 0.0625!
        Me.ReportInfo1.Width = 2.0!
        '
        'Line1
        '
        Me.Line1.AnchorBottom = True
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.3125!
        Me.Line1.Left = 7.125!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 7.125!
        Me.Line1.X2 = 7.125!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.3125!
        '
        'Line8
        '
        Me.Line8.Border.BottomColor = System.Drawing.Color.Black
        Me.Line8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.LeftColor = System.Drawing.Color.Black
        Me.Line8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.RightColor = System.Drawing.Color.Black
        Me.Line8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.TopColor = System.Drawing.Color.Black
        Me.Line8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Height = 0.0!
        Me.Line8.Left = 0.0!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.0!
        Me.Line8.Width = 7.13!
        Me.Line8.X1 = 0.0!
        Me.Line8.X2 = 7.13!
        Me.Line8.Y1 = 0.0!
        Me.Line8.Y2 = 0.0!
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
        Me.Line9.Height = 0.3125!
        Me.Line9.Left = 2.4375!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.375!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 2.4375!
        Me.Line9.X2 = 2.4375!
        Me.Line9.Y1 = 0.375!
        Me.Line9.Y2 = 0.6875!
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
        Me.Line10.Height = 0.3125!
        Me.Line10.Left = 0.9375!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.375!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 0.9375!
        Me.Line10.X2 = 0.9375!
        Me.Line10.Y1 = 0.375!
        Me.Line10.Y2 = 0.6875!
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
        Me.Line11.Height = 0.3125!
        Me.Line11.Left = 4.25!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.375!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 4.25!
        Me.Line11.X2 = 4.25!
        Me.Line11.Y1 = 0.375!
        Me.Line11.Y2 = 0.6875!
        '
        'Line12
        '
        Me.Line12.AnchorBottom = True
        Me.Line12.Border.BottomColor = System.Drawing.Color.Black
        Me.Line12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.LeftColor = System.Drawing.Color.Black
        Me.Line12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.RightColor = System.Drawing.Color.Black
        Me.Line12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.TopColor = System.Drawing.Color.Black
        Me.Line12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Height = 0.3125!
        Me.Line12.Left = 5.0!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.375!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 5.0!
        Me.Line12.X2 = 5.0!
        Me.Line12.Y1 = 0.375!
        Me.Line12.Y2 = 0.6875!
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
        Me.Line13.Height = 0.3125!
        Me.Line13.Left = 6.0625!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.375!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 6.0625!
        Me.Line13.X2 = 6.0625!
        Me.Line13.Y1 = 0.375!
        Me.Line13.Y2 = 0.6875!
        '
        'rptSivSalidaFiltrado
        '
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
            "Catalog=SIFUM2505;Data Source=DESARROLLO2"
        OleDBDataSource1.SQL = "Select * from vwRptSalidaBodega"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.34375!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Group_Bodega)
        Me.Sections.Add(Me.Group_Salida)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter2)
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
        CType(Me.txtobjProveedorID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCorta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcosto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubtotal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaSalida1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSivSalidaBodegaID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoSalida1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtFechaDesde As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFechaHasta As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Group_Bodega As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents shpFondo As DataDynamics.ActiveReports.Shape
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents CheckBox1 As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents txtFechaSalida1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSivSalidaBodegaID1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTipoSalida1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCodigoRepuesto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtobjProveedorID1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDescripcionCorta1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCantidad1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtcosto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtsubtotal1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Group_Salida As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srpEncabezado As DataDynamics.ActiveReports.SubReport
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
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
