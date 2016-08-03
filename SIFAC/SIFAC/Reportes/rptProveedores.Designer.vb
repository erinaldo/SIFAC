<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptProveedores 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptProveedores))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCodigo = New DataDynamics.ActiveReports.TextBox
        Me.txtProveedor = New DataDynamics.ActiveReports.TextBox
        Me.txtRUCID = New DataDynamics.ActiveReports.TextBox
        Me.txtFechaIngreso = New DataDynamics.ActiveReports.TextBox
        Me.chkActivo = New DataDynamics.ActiveReports.CheckBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.lblTotalProveedores = New DataDynamics.ActiveReports.Label
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.lblCodigo = New DataDynamics.ActiveReports.Label
        Me.lblProveedor = New DataDynamics.ActiveReports.Label
        Me.lblRUCID = New DataDynamics.ActiveReports.Label
        Me.lblFechaIngreso = New DataDynamics.ActiveReports.Label
        Me.lblActivo = New DataDynamics.ActiveReports.Label
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.txtTotalProveedores = New DataDynamics.ActiveReports.TextBox
        Me.lblTitulo = New DataDynamics.ActiveReports.Label
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Shape3 = New DataDynamics.ActiveReports.Shape
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.lblDireccion = New DataDynamics.ActiveReports.Label
        Me.txtDireccion = New DataDynamics.ActiveReports.TextBox
        Me.lblTelefono = New DataDynamics.ActiveReports.Label
        Me.txtTelefono = New DataDynamics.ActiveReports.TextBox
        Me.lblContactoPrinc = New DataDynamics.ActiveReports.Label
        Me.txtContacto = New DataDynamics.ActiveReports.TextBox
        Me.lblCelularContacto = New DataDynamics.ActiveReports.Label
        Me.txtCelularContacto = New DataDynamics.ActiveReports.TextBox
        Me.lblEmailContacto = New DataDynamics.ActiveReports.Label
        Me.txtEmailContacto = New DataDynamics.ActiveReports.TextBox
        Me.lblEmpresa = New DataDynamics.ActiveReports.Label
        Me.lblFecha = New DataDynamics.ActiveReports.Label
        Me.lbldirEmp = New DataDynamics.ActiveReports.Label
        Me.lblTelefonosEmpresa = New DataDynamics.ActiveReports.Label
        Me.lblEmailEmpresa = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRUCID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRUCID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblContactoPrinc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCelularContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelularContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEmailContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbldirEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTelefonosEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEmailEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo, Me.lblEmpresa, Me.lblFecha, Me.lbldirEmp, Me.lblTelefonosEmpresa, Me.lblEmailEmpresa, Me.Label1, Me.Label2, Me.Label3})
        Me.PageHeader1.Height = 1.78125!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.Shape3, Me.txtCodigo, Me.txtProveedor, Me.txtRUCID, Me.txtFechaIngreso, Me.chkActivo, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.lblDireccion, Me.txtDireccion, Me.lblTelefono, Me.txtTelefono, Me.lblContactoPrinc, Me.txtContacto, Me.lblCelularContacto, Me.txtCelularContacto, Me.lblEmailContacto, Me.txtEmailContacto})
        Me.Detail1.Height = 1.489583!
        Me.Detail1.Name = "Detail1"
        '
        'txtCodigo
        '
        Me.txtCodigo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigo.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigo.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigo.DataField = "SivProveedorID"
        Me.txtCodigo.Height = 0.1875!
        Me.txtCodigo.Left = 0.125!
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtCodigo.Text = "Codigo"
        Me.txtCodigo.Top = 0.03125!
        Me.txtCodigo.Width = 0.5625!
        '
        'txtProveedor
        '
        Me.txtProveedor.Border.BottomColor = System.Drawing.Color.Black
        Me.txtProveedor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtProveedor.Border.LeftColor = System.Drawing.Color.Black
        Me.txtProveedor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtProveedor.Border.RightColor = System.Drawing.Color.Black
        Me.txtProveedor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtProveedor.Border.TopColor = System.Drawing.Color.Black
        Me.txtProveedor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtProveedor.DataField = "Proveedor"
        Me.txtProveedor.Height = 0.1875!
        Me.txtProveedor.Left = 0.75!
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtProveedor.Text = "Proveedor"
        Me.txtProveedor.Top = 0.04166667!
        Me.txtProveedor.Width = 2.9375!
        '
        'txtRUCID
        '
        Me.txtRUCID.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRUCID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRUCID.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRUCID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRUCID.Border.RightColor = System.Drawing.Color.Black
        Me.txtRUCID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRUCID.Border.TopColor = System.Drawing.Color.Black
        Me.txtRUCID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRUCID.DataField = "RUCID"
        Me.txtRUCID.Height = 0.1875!
        Me.txtRUCID.Left = 3.8125!
        Me.txtRUCID.Name = "txtRUCID"
        Me.txtRUCID.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtRUCID.Text = "RUCID"
        Me.txtRUCID.Top = 0.04166667!
        Me.txtRUCID.Width = 0.8125!
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFechaIngreso.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaIngreso.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFechaIngreso.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaIngreso.Border.RightColor = System.Drawing.Color.Black
        Me.txtFechaIngreso.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaIngreso.Border.TopColor = System.Drawing.Color.Black
        Me.txtFechaIngreso.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFechaIngreso.DataField = "FechaIngreso"
        Me.txtFechaIngreso.Height = 0.1875!
        Me.txtFechaIngreso.Left = 4.75!
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtFechaIngreso.Text = "FechaIngreso"
        Me.txtFechaIngreso.Top = 0.04166667!
        Me.txtFechaIngreso.Width = 1.0625!
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
        Me.chkActivo.Left = 6.09375!
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Style = ""
        Me.chkActivo.Text = ""
        Me.chkActivo.Top = 0.03125!
        Me.chkActivo.Width = 0.1875!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTotalProveedores, Me.txtTotalProveedores})
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'lblTotalProveedores
        '
        Me.lblTotalProveedores.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTotalProveedores.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalProveedores.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTotalProveedores.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalProveedores.Border.RightColor = System.Drawing.Color.Black
        Me.lblTotalProveedores.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalProveedores.Border.TopColor = System.Drawing.Color.Black
        Me.lblTotalProveedores.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTotalProveedores.Height = 0.1875!
        Me.lblTotalProveedores.HyperLink = Nothing
        Me.lblTotalProveedores.Left = 4.260417!
        Me.lblTotalProveedores.Name = "lblTotalProveedores"
        Me.lblTotalProveedores.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblTotalProveedores.Text = "Total de Proveedores:"
        Me.lblTotalProveedores.Top = 0.0!
        Me.lblTotalProveedores.Width = 1.3125!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.lblCodigo, Me.lblProveedor, Me.lblRUCID, Me.lblFechaIngreso, Me.lblActivo, Me.Line1, Me.Line2, Me.Line3, Me.Line4})
        Me.GroupHeader1.DataField = "objPersonaID"
        Me.GroupHeader1.Height = 0.28125!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.lblCodigo.Height = 0.1875!
        Me.lblCodigo.HyperLink = Nothing
        Me.lblCodigo.Left = 0.125!
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblCodigo.Text = "Codigo"
        Me.lblCodigo.Top = 0.0625!
        Me.lblCodigo.Width = 0.5625!
        '
        'lblProveedor
        '
        Me.lblProveedor.Border.BottomColor = System.Drawing.Color.Black
        Me.lblProveedor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblProveedor.Border.LeftColor = System.Drawing.Color.Black
        Me.lblProveedor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblProveedor.Border.RightColor = System.Drawing.Color.Black
        Me.lblProveedor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblProveedor.Border.TopColor = System.Drawing.Color.Black
        Me.lblProveedor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblProveedor.Height = 0.1875!
        Me.lblProveedor.HyperLink = Nothing
        Me.lblProveedor.Left = 0.75!
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.Top = 0.0625!
        Me.lblProveedor.Width = 2.9375!
        '
        'lblRUCID
        '
        Me.lblRUCID.Border.BottomColor = System.Drawing.Color.Black
        Me.lblRUCID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRUCID.Border.LeftColor = System.Drawing.Color.Black
        Me.lblRUCID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRUCID.Border.RightColor = System.Drawing.Color.Black
        Me.lblRUCID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRUCID.Border.TopColor = System.Drawing.Color.Black
        Me.lblRUCID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRUCID.Height = 0.1875!
        Me.lblRUCID.HyperLink = Nothing
        Me.lblRUCID.Left = 3.8125!
        Me.lblRUCID.Name = "lblRUCID"
        Me.lblRUCID.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblRUCID.Text = "RUC/ID"
        Me.lblRUCID.Top = 0.0625!
        Me.lblRUCID.Width = 0.8125!
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFechaIngreso.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaIngreso.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFechaIngreso.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaIngreso.Border.RightColor = System.Drawing.Color.Black
        Me.lblFechaIngreso.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaIngreso.Border.TopColor = System.Drawing.Color.Black
        Me.lblFechaIngreso.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFechaIngreso.Height = 0.1875!
        Me.lblFechaIngreso.HyperLink = Nothing
        Me.lblFechaIngreso.Left = 4.75!
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblFechaIngreso.Text = "FechaIngreso"
        Me.lblFechaIngreso.Top = 0.0625!
        Me.lblFechaIngreso.Width = 1.0625!
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
        Me.lblActivo.Left = 5.947917!
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblActivo.Text = "Activo"
        Me.lblActivo.Top = 0.0625!
        Me.lblActivo.Width = 0.4375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.1979167!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtTotalProveedores
        '
        Me.txtTotalProveedores.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalProveedores.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalProveedores.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalProveedores.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalProveedores.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalProveedores.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalProveedores.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalProveedores.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalProveedores.DataField = "SivProveedorID"
        Me.txtTotalProveedores.DistinctField = "SivProveedorID"
        Me.txtTotalProveedores.Height = 0.1875!
        Me.txtTotalProveedores.Left = 5.614583!
        Me.txtTotalProveedores.Name = "txtTotalProveedores"
        Me.txtTotalProveedores.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtTotalProveedores.SummaryGroup = "GroupHeader1"
        Me.txtTotalProveedores.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtTotalProveedores.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtTotalProveedores.Top = 0.0!
        Me.txtTotalProveedores.Width = 0.75!
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
        Me.lblTitulo.Left = 2.125!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "color: SteelBlue; ddo-char-set: 0; font-weight: bold; font-size: 14.25pt; font-fa" & _
            "mily: Times New Roman; "
        Me.lblTitulo.Text = "Listado de Proveedores"
        Me.lblTitulo.Top = 1.4375!
        Me.lblTitulo.Width = 2.1875!
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 0.25!
        Me.Shape1.Left = 0.0625!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.04166667!
        Me.Shape1.Width = 6.375!
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
        Me.Line1.Height = 0.25!
        Me.Line1.Left = 0.7291667!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.04166667!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 0.7291667!
        Me.Line1.X2 = 0.7291667!
        Me.Line1.Y1 = 0.2916667!
        Me.Line1.Y2 = 0.04166667!
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
        Me.Line2.Height = 0.25!
        Me.Line2.Left = 3.729167!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.04166667!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 3.729167!
        Me.Line2.X2 = 3.729167!
        Me.Line2.Y1 = 0.2916667!
        Me.Line2.Y2 = 0.04166667!
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
        Me.Line3.Height = 0.25!
        Me.Line3.Left = 4.697917!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.04166667!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 4.697917!
        Me.Line3.X2 = 4.697917!
        Me.Line3.Y1 = 0.2916667!
        Me.Line3.Y2 = 0.04166667!
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
        Me.Line4.Height = 0.25!
        Me.Line4.Left = 5.895833!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.04166667!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 5.895833!
        Me.Line4.X2 = 5.895833!
        Me.Line4.Y1 = 0.2916667!
        Me.Line4.Y2 = 0.04166667!
        '
        'Shape2
        '
        Me.Shape2.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.RightColor = System.Drawing.Color.Black
        Me.Shape2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.TopColor = System.Drawing.Color.Black
        Me.Shape2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Height = 1.4375!
        Me.Shape2.Left = 0.0625!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 0.0!
        Me.Shape2.Width = 6.375!
        '
        'Shape3
        '
        Me.Shape3.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.RightColor = System.Drawing.Color.Black
        Me.Shape3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.TopColor = System.Drawing.Color.Black
        Me.Shape3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Height = 0.375!
        Me.Shape3.Left = 0.0625!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 0.0!
        Me.Shape3.Width = 6.375!
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
        Me.Line5.Height = 0.38!
        Me.Line5.Left = 0.7291667!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 0.7291667!
        Me.Line5.X2 = 0.7291667!
        Me.Line5.Y1 = 0.38!
        Me.Line5.Y2 = 0.0!
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
        Me.Line6.Height = 0.38!
        Me.Line6.Left = 3.73125!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.0!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 3.73125!
        Me.Line6.X2 = 3.73125!
        Me.Line6.Y1 = 0.38!
        Me.Line6.Y2 = 0.0!
        '
        'Line7
        '
        Me.Line7.Border.BottomColor = System.Drawing.Color.Black
        Me.Line7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.LeftColor = System.Drawing.Color.Black
        Me.Line7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.RightColor = System.Drawing.Color.Black
        Me.Line7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.TopColor = System.Drawing.Color.Black
        Me.Line7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Height = 0.38!
        Me.Line7.Left = 4.70125!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.0!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 4.70125!
        Me.Line7.X2 = 4.70125!
        Me.Line7.Y1 = 0.38!
        Me.Line7.Y2 = 0.0!
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
        Me.Line8.Height = 0.38!
        Me.Line8.Left = 5.895833!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.0!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 5.895833!
        Me.Line8.X2 = 5.895833!
        Me.Line8.Y1 = 0.38!
        Me.Line8.Y2 = 0.0!
        '
        'lblDireccion
        '
        Me.lblDireccion.Border.BottomColor = System.Drawing.Color.Black
        Me.lblDireccion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDireccion.Border.LeftColor = System.Drawing.Color.Black
        Me.lblDireccion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDireccion.Border.RightColor = System.Drawing.Color.Black
        Me.lblDireccion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDireccion.Border.TopColor = System.Drawing.Color.Black
        Me.lblDireccion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblDireccion.Height = 0.1875!
        Me.lblDireccion.HyperLink = Nothing
        Me.lblDireccion.Left = 0.125!
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblDireccion.Text = "Dirección:"
        Me.lblDireccion.Top = 0.4583333!
        Me.lblDireccion.Width = 0.625!
        '
        'txtDireccion
        '
        Me.txtDireccion.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDireccion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDireccion.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDireccion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDireccion.Border.RightColor = System.Drawing.Color.Black
        Me.txtDireccion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDireccion.Border.TopColor = System.Drawing.Color.Black
        Me.txtDireccion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDireccion.DataField = "Direccion"
        Me.txtDireccion.Height = 0.1875!
        Me.txtDireccion.Left = 0.8125!
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtDireccion.Text = "Direccion"
        Me.txtDireccion.Top = 0.4583333!
        Me.txtDireccion.Width = 5.375!
        '
        'lblTelefono
        '
        Me.lblTelefono.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTelefono.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefono.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTelefono.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefono.Border.RightColor = System.Drawing.Color.Black
        Me.lblTelefono.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefono.Border.TopColor = System.Drawing.Color.Black
        Me.lblTelefono.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefono.Height = 0.1875!
        Me.lblTelefono.HyperLink = Nothing
        Me.lblTelefono.Left = 0.125!
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblTelefono.Text = "Telefono:"
        Me.lblTelefono.Top = 0.6875!
        Me.lblTelefono.Width = 0.625!
        '
        'txtTelefono
        '
        Me.txtTelefono.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTelefono.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTelefono.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTelefono.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTelefono.Border.RightColor = System.Drawing.Color.Black
        Me.txtTelefono.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTelefono.Border.TopColor = System.Drawing.Color.Black
        Me.txtTelefono.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTelefono.DataField = "Telefono"
        Me.txtTelefono.Height = 0.1875!
        Me.txtTelefono.Left = 0.8125!
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtTelefono.Text = "Telefono"
        Me.txtTelefono.Top = 0.6875!
        Me.txtTelefono.Width = 5.375!
        '
        'lblContactoPrinc
        '
        Me.lblContactoPrinc.Border.BottomColor = System.Drawing.Color.Black
        Me.lblContactoPrinc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblContactoPrinc.Border.LeftColor = System.Drawing.Color.Black
        Me.lblContactoPrinc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblContactoPrinc.Border.RightColor = System.Drawing.Color.Black
        Me.lblContactoPrinc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblContactoPrinc.Border.TopColor = System.Drawing.Color.Black
        Me.lblContactoPrinc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblContactoPrinc.Height = 0.1875!
        Me.lblContactoPrinc.HyperLink = Nothing
        Me.lblContactoPrinc.Left = 0.125!
        Me.lblContactoPrinc.Name = "lblContactoPrinc"
        Me.lblContactoPrinc.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblContactoPrinc.Text = "Contacto Principal:"
        Me.lblContactoPrinc.Top = 0.9375!
        Me.lblContactoPrinc.Width = 1.125!
        '
        'txtContacto
        '
        Me.txtContacto.Border.BottomColor = System.Drawing.Color.Black
        Me.txtContacto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtContacto.Border.LeftColor = System.Drawing.Color.Black
        Me.txtContacto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtContacto.Border.RightColor = System.Drawing.Color.Black
        Me.txtContacto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtContacto.Border.TopColor = System.Drawing.Color.Black
        Me.txtContacto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtContacto.DataField = "Contacto"
        Me.txtContacto.Height = 0.1875!
        Me.txtContacto.Left = 1.25!
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtContacto.Text = "Contacto"
        Me.txtContacto.Top = 0.9375!
        Me.txtContacto.Width = 4.9375!
        '
        'lblCelularContacto
        '
        Me.lblCelularContacto.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCelularContacto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCelularContacto.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCelularContacto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCelularContacto.Border.RightColor = System.Drawing.Color.Black
        Me.lblCelularContacto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCelularContacto.Border.TopColor = System.Drawing.Color.Black
        Me.lblCelularContacto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCelularContacto.Height = 0.1875!
        Me.lblCelularContacto.HyperLink = Nothing
        Me.lblCelularContacto.Left = 0.125!
        Me.lblCelularContacto.Name = "lblCelularContacto"
        Me.lblCelularContacto.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblCelularContacto.Text = "Tel. Celular:"
        Me.lblCelularContacto.Top = 1.1875!
        Me.lblCelularContacto.Width = 0.75!
        '
        'txtCelularContacto
        '
        Me.txtCelularContacto.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCelularContacto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCelularContacto.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCelularContacto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCelularContacto.Border.RightColor = System.Drawing.Color.Black
        Me.txtCelularContacto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCelularContacto.Border.TopColor = System.Drawing.Color.Black
        Me.txtCelularContacto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCelularContacto.DataField = "CelularContacto"
        Me.txtCelularContacto.Height = 0.1875!
        Me.txtCelularContacto.Left = 0.875!
        Me.txtCelularContacto.Name = "txtCelularContacto"
        Me.txtCelularContacto.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtCelularContacto.Text = "CelularContacto"
        Me.txtCelularContacto.Top = 1.1875!
        Me.txtCelularContacto.Width = 1.375!
        '
        'lblEmailContacto
        '
        Me.lblEmailContacto.Border.BottomColor = System.Drawing.Color.Black
        Me.lblEmailContacto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmailContacto.Border.LeftColor = System.Drawing.Color.Black
        Me.lblEmailContacto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmailContacto.Border.RightColor = System.Drawing.Color.Black
        Me.lblEmailContacto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmailContacto.Border.TopColor = System.Drawing.Color.Black
        Me.lblEmailContacto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEmailContacto.Height = 0.1875!
        Me.lblEmailContacto.HyperLink = Nothing
        Me.lblEmailContacto.Left = 3.8125!
        Me.lblEmailContacto.Name = "lblEmailContacto"
        Me.lblEmailContacto.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblEmailContacto.Text = "Email Contacto:"
        Me.lblEmailContacto.Top = 1.1875!
        Me.lblEmailContacto.Width = 0.9375!
        '
        'txtEmailContacto
        '
        Me.txtEmailContacto.Border.BottomColor = System.Drawing.Color.Black
        Me.txtEmailContacto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEmailContacto.Border.LeftColor = System.Drawing.Color.Black
        Me.txtEmailContacto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEmailContacto.Border.RightColor = System.Drawing.Color.Black
        Me.txtEmailContacto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEmailContacto.Border.TopColor = System.Drawing.Color.Black
        Me.txtEmailContacto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEmailContacto.DataField = "EmailContacto"
        Me.txtEmailContacto.Height = 0.1875!
        Me.txtEmailContacto.Left = 4.8125!
        Me.txtEmailContacto.Name = "txtEmailContacto"
        Me.txtEmailContacto.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.txtEmailContacto.Text = "EmailContacto"
        Me.txtEmailContacto.Top = 1.1875!
        Me.txtEmailContacto.Width = 1.375!
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
        Me.lblEmpresa.DataField = "Empresa"
        Me.lblEmpresa.Height = 0.1875!
        Me.lblEmpresa.HyperLink = Nothing
        Me.lblEmpresa.Left = 0.125!
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.lblEmpresa.Text = "Empresa"
        Me.lblEmpresa.Top = 0.3020833!
        Me.lblEmpresa.Width = 6.125!
        '
        'lblFecha
        '
        Me.lblFecha.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFecha.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFecha.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFecha.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFecha.Border.RightColor = System.Drawing.Color.Black
        Me.lblFecha.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFecha.Border.TopColor = System.Drawing.Color.Black
        Me.lblFecha.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFecha.DataField = "Fecha"
        Me.lblFecha.Height = 0.1875!
        Me.lblFecha.HyperLink = Nothing
        Me.lblFecha.Left = 4.8125!
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; "
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.Top = 0.0625!
        Me.lblFecha.Width = 1.4375!
        '
        'lbldirEmp
        '
        Me.lbldirEmp.Border.BottomColor = System.Drawing.Color.Black
        Me.lbldirEmp.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbldirEmp.Border.LeftColor = System.Drawing.Color.Black
        Me.lbldirEmp.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbldirEmp.Border.RightColor = System.Drawing.Color.Black
        Me.lbldirEmp.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbldirEmp.Border.TopColor = System.Drawing.Color.Black
        Me.lbldirEmp.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbldirEmp.DataField = "DireccionEmpresa"
        Me.lbldirEmp.Height = 0.1875!
        Me.lbldirEmp.HyperLink = Nothing
        Me.lbldirEmp.Left = 0.875!
        Me.lbldirEmp.Name = "lbldirEmp"
        Me.lbldirEmp.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; "
        Me.lbldirEmp.Text = "DireccionEmpresa"
        Me.lbldirEmp.Top = 0.53125!
        Me.lbldirEmp.Width = 5.375!
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
        Me.lblTelefonosEmpresa.Top = 0.78125!
        Me.lblTelefonosEmpresa.Width = 5.375!
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
        Me.lblEmailEmpresa.Top = 1.03125!
        Me.lblEmailEmpresa.Width = 5.375!
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
        Me.Label1.Top = 0.53125!
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
        Me.Label2.Top = 0.78125!
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
        Me.Label3.Top = 1.03125!
        Me.Label3.Width = 0.6875!
        '
        'rptProveedores
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
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRUCID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRUCID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblContactoPrinc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCelularContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelularContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEmailContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailContacto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbldirEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTelefonosEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEmailEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents lblCodigo As DataDynamics.ActiveReports.Label
    Friend WithEvents lblProveedor As DataDynamics.ActiveReports.Label
    Friend WithEvents lblRUCID As DataDynamics.ActiveReports.Label
    Friend WithEvents txtCodigo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtProveedor As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRUCID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtFechaIngreso As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblFechaIngreso As DataDynamics.ActiveReports.Label
    Friend WithEvents lblActivo As DataDynamics.ActiveReports.Label
    Friend WithEvents chkActivo As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents lblTotalProveedores As DataDynamics.ActiveReports.Label
    Friend WithEvents txtTotalProveedores As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblTitulo As DataDynamics.ActiveReports.Label
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape3 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line7 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line8 As DataDynamics.ActiveReports.Line
    Friend WithEvents lblDireccion As DataDynamics.ActiveReports.Label
    Friend WithEvents txtDireccion As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblTelefono As DataDynamics.ActiveReports.Label
    Friend WithEvents txtTelefono As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblContactoPrinc As DataDynamics.ActiveReports.Label
    Friend WithEvents txtContacto As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblCelularContacto As DataDynamics.ActiveReports.Label
    Friend WithEvents txtCelularContacto As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblEmailContacto As DataDynamics.ActiveReports.Label
    Friend WithEvents txtEmailContacto As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents lblFecha As DataDynamics.ActiveReports.Label
    Friend WithEvents lbldirEmp As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTelefonosEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents lblEmailEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
End Class
