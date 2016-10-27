<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.tmrPrincipal = New System.Windows.Forms.Timer(Me.components)
        Me.navBarFacturacion = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBarCatalogos = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarParametros = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarCategorias = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarMarcas = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarBodegas = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavProductos = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarRutas = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarClientes = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarEmpleados = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarProveedor = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarDescuentos = New DevExpress.XtraNavBar.NavBarItem()
        Me.grpCatalogos = New DevExpress.XtraNavBar.NavBarGroup()
        Me.grpCartera = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarCuentas = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarReciboCaja = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarDevoluciones = New DevExpress.XtraNavBar.NavBarItem()
        Me.grpInventario = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarOrdenCompra = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarEncargos = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarEntrada = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSalidas = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSolicitud = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarDespacho = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarRecepcion = New DevExpress.XtraNavBar.NavBarItem()
        Me.grpFacturacion = New DevExpress.XtraNavBar.NavBarGroup()
        Me.grpSincronizacion = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarSincroAbonos = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSincroVentas = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarSincroDevoluciones = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarPrincipal = New DevExpress.XtraNavBar.NavBarControl()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEstiloVisual = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOfficexp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOffice2003Olive = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOffice2007Blue = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOffice2007Silver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOffice2007Black = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.lblHora = New C1.Win.C1Ribbon.RibbonLabel()
        Me.lblFecha = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator4 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.RibbonMenu1 = New C1.Win.C1Ribbon.RibbonMenu()
        Me.cmdSeguridad = New C1.Win.C1Ribbon.RibbonButton()
        Me.cmdIniciarSesion = New C1.Win.C1Ribbon.RibbonButton()
        Me.cmdCerrarSesion = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonSeparator3 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.lblUsuario = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator2 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.lblBaseDatos = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator1 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.lblServidor = New C1.Win.C1Ribbon.RibbonLabel()
        Me.stbPrincipal = New C1.Win.C1Ribbon.C1StatusBar()
        CType(Me.NavBarPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPrincipal.SuspendLayout()
        CType(Me.stbPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPrincipal
        '
        '
        'navBarFacturacion
        '
        Me.navBarFacturacion.Caption = "Facturacion"
        Me.navBarFacturacion.Name = "navBarFacturacion"
        Me.navBarFacturacion.SmallImage = CType(resources.GetObject("navBarFacturacion.SmallImage"), System.Drawing.Image)
        '
        'navBarCatalogos
        '
        Me.navBarCatalogos.Caption = "Catalogo-Valor"
        Me.navBarCatalogos.Name = "navBarCatalogos"
        Me.navBarCatalogos.SmallImage = CType(resources.GetObject("navBarCatalogos.SmallImage"), System.Drawing.Image)
        '
        'NavBarParametros
        '
        Me.NavBarParametros.Caption = "Parametros"
        Me.NavBarParametros.Name = "NavBarParametros"
        Me.NavBarParametros.SmallImage = CType(resources.GetObject("NavBarParametros.SmallImage"), System.Drawing.Image)
        '
        'NavBarCategorias
        '
        Me.NavBarCategorias.Caption = "Categorias"
        Me.NavBarCategorias.Name = "NavBarCategorias"
        Me.NavBarCategorias.SmallImage = CType(resources.GetObject("NavBarCategorias.SmallImage"), System.Drawing.Image)
        '
        'NavBarMarcas
        '
        Me.NavBarMarcas.Caption = "Marcas"
        Me.NavBarMarcas.Name = "NavBarMarcas"
        Me.NavBarMarcas.SmallImage = CType(resources.GetObject("NavBarMarcas.SmallImage"), System.Drawing.Image)
        '
        'NavBarBodegas
        '
        Me.NavBarBodegas.Caption = "Bodegas"
        Me.NavBarBodegas.Name = "NavBarBodegas"
        Me.NavBarBodegas.SmallImage = CType(resources.GetObject("NavBarBodegas.SmallImage"), System.Drawing.Image)
        '
        'NavProductos
        '
        Me.NavProductos.Caption = "Productos"
        Me.NavProductos.Name = "NavProductos"
        Me.NavProductos.SmallImage = CType(resources.GetObject("NavProductos.SmallImage"), System.Drawing.Image)
        '
        'NavBarRutas
        '
        Me.NavBarRutas.Caption = "Rutas"
        Me.NavBarRutas.Name = "NavBarRutas"
        Me.NavBarRutas.SmallImage = CType(resources.GetObject("NavBarRutas.SmallImage"), System.Drawing.Image)
        '
        'NavBarClientes
        '
        Me.NavBarClientes.Caption = "Clientes"
        Me.NavBarClientes.Name = "NavBarClientes"
        Me.NavBarClientes.SmallImage = CType(resources.GetObject("NavBarClientes.SmallImage"), System.Drawing.Image)
        '
        'NavBarEmpleados
        '
        Me.NavBarEmpleados.Caption = "Empleados"
        Me.NavBarEmpleados.Name = "NavBarEmpleados"
        Me.NavBarEmpleados.SmallImage = CType(resources.GetObject("NavBarEmpleados.SmallImage"), System.Drawing.Image)
        '
        'NavBarProveedor
        '
        Me.NavBarProveedor.Caption = "Proveedor"
        Me.NavBarProveedor.Name = "NavBarProveedor"
        Me.NavBarProveedor.SmallImage = CType(resources.GetObject("NavBarProveedor.SmallImage"), System.Drawing.Image)
        '
        'NavBarDescuentos
        '
        Me.NavBarDescuentos.Caption = "Rango de Descuentos"
        Me.NavBarDescuentos.Name = "NavBarDescuentos"
        Me.NavBarDescuentos.SmallImage = CType(resources.GetObject("NavBarDescuentos.SmallImage"), System.Drawing.Image)
        '
        'grpCatalogos
        '
        Me.grpCatalogos.Caption = "Catalogos"
        Me.grpCatalogos.Expanded = True
        Me.grpCatalogos.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarCatalogos), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarParametros), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarCategorias), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarMarcas), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarBodegas), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavProductos), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarRutas), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarEmpleados)})
        Me.grpCatalogos.Name = "grpCatalogos"
        '
        'grpCartera
        '
        Me.grpCartera.Caption = "Cartera y Cobro"
        Me.grpCartera.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarClientes), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarCuentas), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarReciboCaja), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarDevoluciones)})
        Me.grpCartera.Name = "grpCartera"
        '
        'NavBarCuentas
        '
        Me.NavBarCuentas.Caption = "Cuentas"
        Me.NavBarCuentas.Name = "NavBarCuentas"
        Me.NavBarCuentas.SmallImage = CType(resources.GetObject("NavBarCuentas.SmallImage"), System.Drawing.Image)
        '
        'NavBarReciboCaja
        '
        Me.NavBarReciboCaja.Caption = "Recibo de Caja"
        Me.NavBarReciboCaja.Name = "NavBarReciboCaja"
        Me.NavBarReciboCaja.SmallImage = CType(resources.GetObject("NavBarReciboCaja.SmallImage"), System.Drawing.Image)
        '
        'NavBarDevoluciones
        '
        Me.NavBarDevoluciones.Caption = "Devoluciones"
        Me.NavBarDevoluciones.Name = "NavBarDevoluciones"
        Me.NavBarDevoluciones.SmallImage = CType(resources.GetObject("NavBarDevoluciones.SmallImage"), System.Drawing.Image)
        '
        'grpInventario
        '
        Me.grpInventario.Caption = "Inventario"
        Me.grpInventario.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarOrdenCompra), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarEncargos), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarProveedor), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarEntrada), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSalidas), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSolicitud), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarDespacho), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarRecepcion)})
        Me.grpInventario.Name = "grpInventario"
        '
        'NavBarOrdenCompra
        '
        Me.NavBarOrdenCompra.Caption = "Pedidos"
        Me.NavBarOrdenCompra.Name = "NavBarOrdenCompra"
        Me.NavBarOrdenCompra.SmallImage = CType(resources.GetObject("NavBarOrdenCompra.SmallImage"), System.Drawing.Image)
        '
        'NavBarEncargos
        '
        Me.NavBarEncargos.Caption = "Encargos"
        Me.NavBarEncargos.Name = "NavBarEncargos"
        Me.NavBarEncargos.SmallImage = CType(resources.GetObject("NavBarEncargos.SmallImage"), System.Drawing.Image)
        '
        'NavBarEntrada
        '
        Me.NavBarEntrada.Caption = "Entradas"
        Me.NavBarEntrada.Name = "NavBarEntrada"
        Me.NavBarEntrada.SmallImage = CType(resources.GetObject("NavBarEntrada.SmallImage"), System.Drawing.Image)
        '
        'NavBarSalidas
        '
        Me.NavBarSalidas.Caption = "Salidas"
        Me.NavBarSalidas.Name = "NavBarSalidas"
        Me.NavBarSalidas.SmallImage = CType(resources.GetObject("NavBarSalidas.SmallImage"), System.Drawing.Image)
        '
        'NavBarSolicitud
        '
        Me.NavBarSolicitud.Caption = "Solicitud"
        Me.NavBarSolicitud.Name = "NavBarSolicitud"
        Me.NavBarSolicitud.SmallImage = CType(resources.GetObject("NavBarSolicitud.SmallImage"), System.Drawing.Image)
        '
        'NavBarDespacho
        '
        Me.NavBarDespacho.Caption = "Despacho"
        Me.NavBarDespacho.Name = "NavBarDespacho"
        Me.NavBarDespacho.SmallImage = CType(resources.GetObject("NavBarDespacho.SmallImage"), System.Drawing.Image)
        '
        'NavBarRecepcion
        '
        Me.NavBarRecepcion.Caption = "Recepcion"
        Me.NavBarRecepcion.Name = "NavBarRecepcion"
        Me.NavBarRecepcion.SmallImage = CType(resources.GetObject("NavBarRecepcion.SmallImage"), System.Drawing.Image)
        '
        'grpFacturacion
        '
        Me.grpFacturacion.Caption = "Facturacion"
        Me.grpFacturacion.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarDescuentos), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarFacturacion)})
        Me.grpFacturacion.Name = "grpFacturacion"
        '
        'grpSincronizacion
        '
        Me.grpSincronizacion.Caption = "Sincronizacion"
        Me.grpSincronizacion.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSincroAbonos), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSincroVentas), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarSincroDevoluciones)})
        Me.grpSincronizacion.Name = "grpSincronizacion"
        '
        'NavBarSincroAbonos
        '
        Me.NavBarSincroAbonos.Caption = "Abonos"
        Me.NavBarSincroAbonos.Name = "NavBarSincroAbonos"
        Me.NavBarSincroAbonos.SmallImage = CType(resources.GetObject("NavBarSincroAbonos.SmallImage"), System.Drawing.Image)
        '
        'NavBarSincroVentas
        '
        Me.NavBarSincroVentas.Caption = "Ventas"
        Me.NavBarSincroVentas.Name = "NavBarSincroVentas"
        Me.NavBarSincroVentas.SmallImage = CType(resources.GetObject("NavBarSincroVentas.SmallImage"), System.Drawing.Image)
        '
        'NavBarSincroDevoluciones
        '
        Me.NavBarSincroDevoluciones.Caption = "Devoluciones"
        Me.NavBarSincroDevoluciones.Name = "NavBarSincroDevoluciones"
        Me.NavBarSincroDevoluciones.SmallImage = CType(resources.GetObject("NavBarSincroDevoluciones.SmallImage"), System.Drawing.Image)
        '
        'NavBarPrincipal
        '
        Me.NavBarPrincipal.ActiveGroup = Me.grpCatalogos
        Me.NavBarPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarPrincipal.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.grpCatalogos, Me.grpCartera, Me.grpInventario, Me.grpFacturacion, Me.grpSincronizacion})
        Me.NavBarPrincipal.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarFacturacion, Me.navBarCatalogos, Me.NavBarParametros, Me.NavBarCategorias, Me.NavBarMarcas, Me.NavBarBodegas, Me.NavProductos, Me.NavBarRutas, Me.NavBarClientes, Me.NavBarEmpleados, Me.NavBarProveedor, Me.NavBarDescuentos, Me.NavBarEntrada, Me.NavBarSalidas, Me.NavBarSolicitud, Me.NavBarDespacho, Me.NavBarRecepcion, Me.NavBarEncargos, Me.NavBarOrdenCompra, Me.NavBarCuentas, Me.NavBarSincroAbonos, Me.NavBarSincroVentas, Me.NavBarSincroDevoluciones, Me.NavBarReciboCaja, Me.NavBarDevoluciones})
        Me.NavBarPrincipal.Location = New System.Drawing.Point(0, 24)
        Me.NavBarPrincipal.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.NavBarPrincipal.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBarPrincipal.Name = "NavBarPrincipal"
        Me.NavBarPrincipal.OptionsNavPane.ExpandedWidth = 175
        Me.NavBarPrincipal.Size = New System.Drawing.Size(175, 561)
        Me.NavBarPrincipal.TabIndex = 17
        Me.NavBarPrincipal.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2010 Silver")
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.tsmEstiloVisual})
        Me.WindowsMenu.ForeColor = System.Drawing.Color.Black
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(67, 20)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Titulo &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Titulo &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todas"
        '
        'tsmEstiloVisual
        '
        Me.tsmEstiloVisual.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOfficexp, Me.tsmOffice2003Olive, Me.tsmOffice2007Blue, Me.tsmOffice2007Silver, Me.tsmOffice2007Black})
        Me.tsmEstiloVisual.Name = "tsmEstiloVisual"
        Me.tsmEstiloVisual.Size = New System.Drawing.Size(163, 22)
        Me.tsmEstiloVisual.Text = "Estilo Visual"
        '
        'tsmOfficexp
        '
        Me.tsmOfficexp.Name = "tsmOfficexp"
        Me.tsmOfficexp.Size = New System.Drawing.Size(158, 22)
        Me.tsmOfficexp.Text = "Officexp"
        '
        'tsmOffice2003Olive
        '
        Me.tsmOffice2003Olive.Name = "tsmOffice2003Olive"
        Me.tsmOffice2003Olive.Size = New System.Drawing.Size(158, 22)
        Me.tsmOffice2003Olive.Text = "Office2003Olive"
        '
        'tsmOffice2007Blue
        '
        Me.tsmOffice2007Blue.Name = "tsmOffice2007Blue"
        Me.tsmOffice2007Blue.Size = New System.Drawing.Size(158, 22)
        Me.tsmOffice2007Blue.Text = "Office2007Blue"
        '
        'tsmOffice2007Silver
        '
        Me.tsmOffice2007Silver.Name = "tsmOffice2007Silver"
        Me.tsmOffice2007Silver.Size = New System.Drawing.Size(158, 22)
        Me.tsmOffice2007Silver.Text = "Office2007Silver"
        '
        'tsmOffice2007Black
        '
        Me.tsmOffice2007Black.Name = "tsmOffice2007Black"
        Me.tsmOffice2007Black.Size = New System.Drawing.Size(158, 22)
        Me.tsmOffice2007Black.Text = "Office2007Black"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAyuda})
        Me.HelpMenu.ForeColor = System.Drawing.Color.Black
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenu.Text = "&Ayuda"
        '
        'tsmAyuda
        '
        Me.tsmAyuda.Name = "tsmAyuda"
        Me.tsmAyuda.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.tsmAyuda.Size = New System.Drawing.Size(176, 22)
        Me.tsmAyuda.Text = "&Contenido"
        '
        'tsmSalir
        '
        Me.tsmSalir.ForeColor = System.Drawing.Color.Black
        Me.tsmSalir.Name = "tsmSalir"
        Me.tsmSalir.Size = New System.Drawing.Size(41, 20)
        Me.tsmSalir.Text = "&Salir"
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.MenuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsMenu, Me.HelpMenu, Me.tsmSalir})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.MdiWindowListItem = Me.WindowsMenu
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(795, 24)
        Me.MenuPrincipal.TabIndex = 6
        Me.MenuPrincipal.Text = "MenuStrip"
        '
        'lblHora
        '
        Me.lblHora.ID = "lblHora"
        Me.lblHora.SmallImage = CType(resources.GetObject("lblHora.SmallImage"), System.Drawing.Image)
        Me.lblHora.Text = "Hora :"
        '
        'lblFecha
        '
        Me.lblFecha.ID = "lblFecha"
        Me.lblFecha.SmallImage = CType(resources.GetObject("lblFecha.SmallImage"), System.Drawing.Image)
        Me.lblFecha.Text = "Fechar :"
        '
        'RibbonSeparator4
        '
        Me.RibbonSeparator4.ID = "RibbonSeparator4"
        '
        'RibbonMenu1
        '
        Me.RibbonMenu1.ID = "RibbonMenu1"
        Me.RibbonMenu1.Items.Add(Me.cmdSeguridad)
        Me.RibbonMenu1.Items.Add(Me.cmdIniciarSesion)
        Me.RibbonMenu1.Items.Add(Me.cmdCerrarSesion)
        Me.RibbonMenu1.SmallImage = CType(resources.GetObject("RibbonMenu1.SmallImage"), System.Drawing.Image)
        '
        'cmdSeguridad
        '
        Me.cmdSeguridad.ID = "cmdSeguridad"
        Me.cmdSeguridad.SmallImage = CType(resources.GetObject("cmdSeguridad.SmallImage"), System.Drawing.Image)
        Me.cmdSeguridad.Text = "       Seguridad                 "
        '
        'cmdIniciarSesion
        '
        Me.cmdIniciarSesion.ID = "cmdIniciarSesion"
        Me.cmdIniciarSesion.SmallImage = CType(resources.GetObject("cmdIniciarSesion.SmallImage"), System.Drawing.Image)
        Me.cmdIniciarSesion.Text = "  Iniciar Sesión"
        '
        'cmdCerrarSesion
        '
        Me.cmdCerrarSesion.ID = "cmdCerrarSesion"
        Me.cmdCerrarSesion.SmallImage = CType(resources.GetObject("cmdCerrarSesion.SmallImage"), System.Drawing.Image)
        Me.cmdCerrarSesion.Text = "  Cerrar Sesión"
        '
        'RibbonSeparator3
        '
        Me.RibbonSeparator3.ID = "RibbonSeparator3"
        '
        'lblUsuario
        '
        Me.lblUsuario.ID = "lblUsuario"
        Me.lblUsuario.SmallImage = CType(resources.GetObject("lblUsuario.SmallImage"), System.Drawing.Image)
        Me.lblUsuario.Text = "Usuario :"
        '
        'RibbonSeparator2
        '
        Me.RibbonSeparator2.ID = "RibbonSeparator2"
        '
        'lblBaseDatos
        '
        Me.lblBaseDatos.ID = "lblBaseDatos"
        Me.lblBaseDatos.SmallImage = CType(resources.GetObject("lblBaseDatos.SmallImage"), System.Drawing.Image)
        Me.lblBaseDatos.Text = "Base de Datos :"
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.ID = "RibbonSeparator1"
        '
        'lblServidor
        '
        Me.lblServidor.ID = "lblServidor"
        Me.lblServidor.SmallImage = CType(resources.GetObject("lblServidor.SmallImage"), System.Drawing.Image)
        Me.lblServidor.Text = "Servidor :"
        '
        'stbPrincipal
        '
        Me.stbPrincipal.LeftPaneItems.Add(Me.lblServidor)
        Me.stbPrincipal.LeftPaneItems.Add(Me.RibbonSeparator1)
        Me.stbPrincipal.LeftPaneItems.Add(Me.lblBaseDatos)
        Me.stbPrincipal.LeftPaneItems.Add(Me.RibbonSeparator2)
        Me.stbPrincipal.LeftPaneItems.Add(Me.lblUsuario)
        Me.stbPrincipal.LeftPaneItems.Add(Me.RibbonSeparator3)
        Me.stbPrincipal.LeftPaneItems.Add(Me.RibbonMenu1)
        Me.stbPrincipal.LeftPaneItems.Add(Me.RibbonSeparator4)
        Me.stbPrincipal.Location = New System.Drawing.Point(0, 585)
        Me.stbPrincipal.Name = "stbPrincipal"
        Me.stbPrincipal.RightPaneItems.Add(Me.lblFecha)
        Me.stbPrincipal.RightPaneItems.Add(Me.lblHora)
        Me.stbPrincipal.RightPaneWidth = 240
        Me.stbPrincipal.Size = New System.Drawing.Size(795, 22)
        Me.stbPrincipal.TabIndex = 14
        Me.stbPrincipal.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Silver
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SIFAC.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(795, 607)
        Me.Controls.Add(Me.NavBarPrincipal)
        Me.Controls.Add(Me.stbPrincipal)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema SIFAC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NavBarPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        CType(Me.stbPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   
    Private WithEvents tmrPrincipal As System.Windows.Forms.Timer
    Friend WithEvents NavBarPrincipal As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents grpCartera As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarClientes As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents grpCatalogos As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navBarCatalogos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarParametros As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarCategorias As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarMarcas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarBodegas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavProductos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarRutas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarEmpleados As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents grpInventario As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarProveedor As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents grpFacturacion As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarDescuentos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBarFacturacion As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents grpSincronizacion As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents stbPrincipal As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents lblServidor As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonSeparator1 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents lblBaseDatos As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonSeparator2 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents lblUsuario As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonSeparator3 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents RibbonMenu1 As C1.Win.C1Ribbon.RibbonMenu
    Friend WithEvents cmdSeguridad As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents cmdIniciarSesion As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents cmdCerrarSesion As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonSeparator4 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents lblFecha As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents lblHora As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEstiloVisual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmOfficexp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmOffice2003Olive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmOffice2007Blue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmOffice2007Silver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmOffice2007Black As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavBarEntrada As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSalidas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSolicitud As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarDespacho As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarRecepcion As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarOrdenCompra As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarEncargos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarCuentas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSincroAbonos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSincroVentas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarSincroDevoluciones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarReciboCaja As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarDevoluciones As DevExpress.XtraNavBar.NavBarItem
End Class
