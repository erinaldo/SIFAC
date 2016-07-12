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
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
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
        Me.OutBarPrincipal = New C1.Win.C1Command.C1OutBar()
        Me.brCatalogos = New C1.Win.C1Command.C1OutPage()
        Me.ToolBarCatalogos = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdCatalogoValor = New C1.Win.C1Command.C1Command()
        Me.cmdPersonas = New C1.Win.C1Command.C1Command()
        Me.cmdTienda = New C1.Win.C1Command.C1Command()
        Me.cmdProducto = New C1.Win.C1Command.C1Command()
        Me.cmdTasaCambio = New C1.Win.C1Command.C1Command()
        Me.cmdEmpleados = New C1.Win.C1Command.C1Command()
        Me.cmdExpedientes = New C1.Win.C1Command.C1Command()
        Me.cmdNotasCredito = New C1.Win.C1Command.C1Command()
        Me.cmdNotasDebito = New C1.Win.C1Command.C1Command()
        Me.cmdDevoluciones = New C1.Win.C1Command.C1Command()
        Me.CmdReestructurar = New C1.Win.C1Command.C1Command()
        Me.cmdRptVencCuotas = New C1.Win.C1Command.C1Command()
        Me.cmdEstadoCuenta = New C1.Win.C1Command.C1Command()
        Me.cmdEstadoCrediticio = New C1.Win.C1Command.C1Command()
        Me.cmdRptDevoluciones = New C1.Win.C1Command.C1Command()
        Me.cmdRptSeguimiento = New C1.Win.C1Command.C1Command()
        Me.cmdReciboCaja = New C1.Win.C1Command.C1Command()
        Me.cmdProductos = New C1.Win.C1Command.C1Command()
        Me.cmdFactura = New C1.Win.C1Command.C1Command()
        Me.cmdBitacora = New C1.Win.C1Command.C1Command()
        Me.cmdParametros = New C1.Win.C1Command.C1Command()
        Me.cmdRptEstadoCuenta = New C1.Win.C1Command.C1Command()
        Me.RptMorosidad = New C1.Win.C1Command.C1Command()
        Me.cmdPorcentajeMorosidad = New C1.Win.C1Command.C1Command()
        Me.cmdSaldoConsolidado = New C1.Win.C1Command.C1Command()
        Me.cmdMinutas = New C1.Win.C1Command.C1Command()
        Me.cmdRptCarteraRangos = New C1.Win.C1Command.C1Command()
        Me.cmdRptHistorialClientes = New C1.Win.C1Command.C1Command()
        Me.cmdRptRecuperacionComparativo = New C1.Win.C1Command.C1Command()
        Me.cmdTramiteLegal = New C1.Win.C1Command.C1Command()
        Me.cmdProveedores = New C1.Win.C1Command.C1Command()
        Me.cmdSolicitudTransferencia = New C1.Win.C1Command.C1Command()
        Me.cmdDespacharTransferencia = New C1.Win.C1Command.C1Command()
        Me.cmdRecepcionarTransferencia = New C1.Win.C1Command.C1Command()
        Me.cmdRptInventario = New C1.Win.C1Command.C1Command()
        Me.cmdRptListadoPrecios = New C1.Win.C1Command.C1Command()
        Me.cmdPromociones = New C1.Win.C1Command.C1Command()
        Me.cmdSalidaBodega = New C1.Win.C1Command.C1Command()
        Me.cmdEntradaBodega = New C1.Win.C1Command.C1Command()
        Me.cmdRepuestos = New C1.Win.C1Command.C1Command()
        Me.cmdCotizaciones = New C1.Win.C1Command.C1Command()
        Me.cmdFacturasRepuestos = New C1.Win.C1Command.C1Command()
        Me.cmdRptEntrada = New C1.Win.C1Command.C1Command()
        Me.cmdRptSalidas = New C1.Win.C1Command.C1Command()
        Me.cmdRptSolicitudesTransf = New C1.Win.C1Command.C1Command()
        Me.cmdRptDespachoTransf = New C1.Win.C1Command.C1Command()
        Me.cmdRptRecepcionesTransf = New C1.Win.C1Command.C1Command()
        Me.cmdRptDiferenciasTransf = New C1.Win.C1Command.C1Command()
        Me.cmdRptKardex = New C1.Win.C1Command.C1Command()
        Me.cmdRptCotizaciones = New C1.Win.C1Command.C1Command()
        Me.cmdRptFacturacion = New C1.Win.C1Command.C1Command()
        Me.cmdRptRepuestosFacturados = New C1.Win.C1Command.C1Command()
        Me.cmdRptPromociones = New C1.Win.C1Command.C1Command()
        Me.cmdRptUtilidades = New C1.Win.C1Command.C1Command()
        Me.cmdRptComiciones = New C1.Win.C1Command.C1Command()
        Me.cmdOrdenCompra = New C1.Win.C1Command.C1Command()
        Me.cmdServicioTaller = New C1.Win.C1Command.C1Command()
        Me.cmdReporteBitacoraMoto = New C1.Win.C1Command.C1Command()
        Me.cmdRptEstadisticoServicios = New C1.Win.C1Command.C1Command()
        Me.cmdSolicitudesRepuestoGarantia = New C1.Win.C1Command.C1Command()
        Me.cmdSolicitudesDescuento = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink11 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdLinkMuestrasMedicas = New C1.Win.C1Command.C1CommandLink()
        Me.cmdLinkDevolucionDeVencidos = New C1.Win.C1Command.C1CommandLink()
        Me.cmdLinkDevolucionDeNoVencidos = New C1.Win.C1Command.C1CommandLink()
        Me.cmdRecepcionDeVencidos = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink13 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink24 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink34 = New C1.Win.C1Command.C1CommandLink()
        Me.brCartera = New C1.Win.C1Command.C1OutPage()
        Me.ToolBarCartera = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink23 = New C1.Win.C1Command.C1CommandLink()
        Me.outReportes = New C1.Win.C1Command.C1OutPage()
        Me.ToolBReportes = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink9 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink10 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink17 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink19 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink15 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink14 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink16 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink20 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink21 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink22 = New C1.Win.C1Command.C1CommandLink()
        Me.outBitacora = New C1.Win.C1Command.C1OutPage()
        Me.ToolBarBitacora = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink12 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink18 = New C1.Win.C1Command.C1CommandLink()
        Me.brInventario = New C1.Win.C1Command.C1OutPage()
        Me.toolBarInventario = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink33 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink32 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink26 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink27 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink28 = New C1.Win.C1Command.C1CommandLink()
        Me.brInventarioReportes = New C1.Win.C1Command.C1OutPage()
        Me.ToolBarInventarioReportes = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink36 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink37 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink38 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink39 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink40 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink41 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink29 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink42 = New C1.Win.C1Command.C1CommandLink()
        Me.brFacturacion = New C1.Win.C1Command.C1OutPage()
        Me.ToolBarFacturas = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink25 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink35 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink31 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink49 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink54 = New C1.Win.C1Command.C1CommandLink()
        Me.brFacturacionReportes = New C1.Win.C1Command.C1OutPage()
        Me.ToolBarFacturacionReportes = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink30 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink43 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink44 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink45 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink46 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink47 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink48 = New C1.Win.C1Command.C1CommandLink()
        Me.brTaller = New C1.Win.C1Command.C1OutPage()
        Me.ToolBarTaller = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink50 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink53 = New C1.Win.C1Command.C1CommandLink()
        Me.brTallerReportes = New C1.Win.C1Command.C1OutPage()
        Me.ToolBarTallerReportes = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink51 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink52 = New C1.Win.C1Command.C1CommandLink()
        Me.tmrVerificarDescuento = New System.Windows.Forms.Timer(Me.components)
        Me.stbPrincipal = New C1.Win.C1Ribbon.C1StatusBar()
        Me.lblServidor = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator1 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.lblBaseDatos = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator2 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.lblUsuario = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator3 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.RibbonMenu1 = New C1.Win.C1Ribbon.RibbonMenu()
        Me.cmdSeguridad = New C1.Win.C1Ribbon.RibbonButton()
        Me.cmdIniciarSesion = New C1.Win.C1Ribbon.RibbonButton()
        Me.cmdCerrarSesion = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonSeparator4 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.lblSucursal = New C1.Win.C1Ribbon.RibbonLabel()
        Me.lblFecha = New C1.Win.C1Ribbon.RibbonLabel()
        Me.lblHora = New C1.Win.C1Ribbon.RibbonLabel()
        Me.MenuPrincipal.SuspendLayout()
        CType(Me.OutBarPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OutBarPrincipal.SuspendLayout()
        Me.brCatalogos.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.brCartera.SuspendLayout()
        Me.outReportes.SuspendLayout()
        Me.outBitacora.SuspendLayout()
        Me.brInventario.SuspendLayout()
        Me.brInventarioReportes.SuspendLayout()
        Me.brFacturacion.SuspendLayout()
        Me.brFacturacionReportes.SuspendLayout()
        Me.brTaller.SuspendLayout()
        Me.brTallerReportes.SuspendLayout()
        CType(Me.stbPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPrincipal
        '
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsMenu, Me.HelpMenu, Me.tsmSalir})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.MdiWindowListItem = Me.WindowsMenu
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(795, 24)
        Me.MenuPrincipal.TabIndex = 6
        Me.MenuPrincipal.Text = "MenuStrip"
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
        'OutBarPrincipal
        '
        Me.OutBarPrincipal.Controls.Add(Me.brCatalogos)
        Me.OutBarPrincipal.Controls.Add(Me.brCartera)
        Me.OutBarPrincipal.Controls.Add(Me.outReportes)
        Me.OutBarPrincipal.Controls.Add(Me.outBitacora)
        Me.OutBarPrincipal.Controls.Add(Me.brInventario)
        Me.OutBarPrincipal.Controls.Add(Me.brInventarioReportes)
        Me.OutBarPrincipal.Controls.Add(Me.brFacturacion)
        Me.OutBarPrincipal.Controls.Add(Me.brFacturacionReportes)
        Me.OutBarPrincipal.Controls.Add(Me.brTaller)
        Me.OutBarPrincipal.Controls.Add(Me.brTallerReportes)
        Me.OutBarPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.OutBarPrincipal.Location = New System.Drawing.Point(0, 24)
        Me.OutBarPrincipal.Name = "OutBarPrincipal"
        Me.OutBarPrincipal.PageLayout = C1.Win.C1Command.ButtonLayoutEnum.TextOnLeft
        Me.OutBarPrincipal.SelectedIndex = 1
        Me.OutBarPrincipal.Size = New System.Drawing.Size(188, 583)
        Me.OutBarPrincipal.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'brCatalogos
        '
        Me.brCatalogos.Controls.Add(Me.ToolBarCatalogos)
        Me.brCatalogos.Name = "brCatalogos"
        Me.brCatalogos.Size = New System.Drawing.Size(188, 403)
        Me.brCatalogos.Text = "Catálogos"
        '
        'ToolBarCatalogos
        '
        Me.ToolBarCatalogos.AccessibleName = "Tool Bar"
        Me.ToolBarCatalogos.AutoSize = False
        Me.ToolBarCatalogos.Border.Style = C1.Win.C1Command.BorderStyleEnum.Ridge
        Me.ToolBarCatalogos.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBarCatalogos.CommandHolder = Me.C1CommandHolder1
        Me.ToolBarCatalogos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink7, Me.C1CommandLink11, Me.cmdLinkMuestrasMedicas, Me.cmdLinkDevolucionDeVencidos, Me.cmdLinkDevolucionDeNoVencidos, Me.cmdRecepcionDeVencidos, Me.C1CommandLink13, Me.C1CommandLink24, Me.C1CommandLink34})
        Me.ToolBarCatalogos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBarCatalogos.Horizontal = False
        Me.ToolBarCatalogos.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarCatalogos.Movable = False
        Me.ToolBarCatalogos.Name = "ToolBarCatalogos"
        Me.ToolBarCatalogos.Size = New System.Drawing.Size(188, 403)
        Me.ToolBarCatalogos.Text = "Toolbar Categoria 1"
        Me.ToolBarCatalogos.VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP
        Me.ToolBarCatalogos.VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdCatalogoValor)
        Me.C1CommandHolder1.Commands.Add(Me.cmdPersonas)
        Me.C1CommandHolder1.Commands.Add(Me.cmdTienda)
        Me.C1CommandHolder1.Commands.Add(Me.cmdProducto)
        Me.C1CommandHolder1.Commands.Add(Me.cmdTasaCambio)
        Me.C1CommandHolder1.Commands.Add(Me.cmdEmpleados)
        Me.C1CommandHolder1.Commands.Add(Me.cmdExpedientes)
        Me.C1CommandHolder1.Commands.Add(Me.cmdNotasCredito)
        Me.C1CommandHolder1.Commands.Add(Me.cmdNotasDebito)
        Me.C1CommandHolder1.Commands.Add(Me.cmdDevoluciones)
        Me.C1CommandHolder1.Commands.Add(Me.CmdReestructurar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptVencCuotas)
        Me.C1CommandHolder1.Commands.Add(Me.cmdEstadoCuenta)
        Me.C1CommandHolder1.Commands.Add(Me.cmdEstadoCrediticio)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptDevoluciones)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptSeguimiento)
        Me.C1CommandHolder1.Commands.Add(Me.cmdReciboCaja)
        Me.C1CommandHolder1.Commands.Add(Me.cmdProductos)
        Me.C1CommandHolder1.Commands.Add(Me.cmdFactura)
        Me.C1CommandHolder1.Commands.Add(Me.cmdBitacora)
        Me.C1CommandHolder1.Commands.Add(Me.cmdParametros)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptEstadoCuenta)
        Me.C1CommandHolder1.Commands.Add(Me.RptMorosidad)
        Me.C1CommandHolder1.Commands.Add(Me.cmdPorcentajeMorosidad)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSaldoConsolidado)
        Me.C1CommandHolder1.Commands.Add(Me.cmdMinutas)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptCarteraRangos)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptHistorialClientes)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptRecuperacionComparativo)
        Me.C1CommandHolder1.Commands.Add(Me.cmdTramiteLegal)
        Me.C1CommandHolder1.Commands.Add(Me.cmdProveedores)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSolicitudTransferencia)
        Me.C1CommandHolder1.Commands.Add(Me.cmdDespacharTransferencia)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRecepcionarTransferencia)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptInventario)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptListadoPrecios)
        Me.C1CommandHolder1.Commands.Add(Me.cmdPromociones)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSalidaBodega)
        Me.C1CommandHolder1.Commands.Add(Me.cmdEntradaBodega)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRepuestos)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCotizaciones)
        Me.C1CommandHolder1.Commands.Add(Me.cmdFacturasRepuestos)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptEntrada)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptSalidas)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptSolicitudesTransf)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptDespachoTransf)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptRecepcionesTransf)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptDiferenciasTransf)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptKardex)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptCotizaciones)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptFacturacion)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptRepuestosFacturados)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptPromociones)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptUtilidades)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptComiciones)
        Me.C1CommandHolder1.Commands.Add(Me.cmdOrdenCompra)
        Me.C1CommandHolder1.Commands.Add(Me.cmdServicioTaller)
        Me.C1CommandHolder1.Commands.Add(Me.cmdReporteBitacoraMoto)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRptEstadisticoServicios)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSolicitudesRepuestoGarantia)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSolicitudesDescuento)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdCatalogoValor
        '
        Me.cmdCatalogoValor.Icon = CType(resources.GetObject("cmdCatalogoValor.Icon"), System.Drawing.Icon)
        Me.cmdCatalogoValor.Name = "cmdCatalogoValor"
        Me.cmdCatalogoValor.Text = "Catalogo-Valor"
        '
        'cmdPersonas
        '
        Me.cmdPersonas.Icon = CType(resources.GetObject("cmdPersonas.Icon"), System.Drawing.Icon)
        Me.cmdPersonas.Name = "cmdPersonas"
        Me.cmdPersonas.Text = "Personas"
        '
        'cmdTienda
        '
        Me.cmdTienda.Icon = CType(resources.GetObject("cmdTienda.Icon"), System.Drawing.Icon)
        Me.cmdTienda.Name = "cmdTienda"
        Me.cmdTienda.Text = "Sucursales"
        '
        'cmdProducto
        '
        Me.cmdProducto.Icon = CType(resources.GetObject("cmdProducto.Icon"), System.Drawing.Icon)
        Me.cmdProducto.Name = "cmdProducto"
        Me.cmdProducto.Text = "Productos"
        '
        'cmdTasaCambio
        '
        Me.cmdTasaCambio.Image = CType(resources.GetObject("cmdTasaCambio.Image"), System.Drawing.Image)
        Me.cmdTasaCambio.Name = "cmdTasaCambio"
        Me.cmdTasaCambio.Text = "&Tasa de Cambio"
        '
        'cmdEmpleados
        '
        Me.cmdEmpleados.Icon = CType(resources.GetObject("cmdEmpleados.Icon"), System.Drawing.Icon)
        Me.cmdEmpleados.Name = "cmdEmpleados"
        Me.cmdEmpleados.Text = "&Empleados"
        '
        'cmdExpedientes
        '
        Me.cmdExpedientes.Image = CType(resources.GetObject("cmdExpedientes.Image"), System.Drawing.Image)
        Me.cmdExpedientes.Name = "cmdExpedientes"
        Me.cmdExpedientes.Text = "Expediente de Cuenta"
        '
        'cmdNotasCredito
        '
        Me.cmdNotasCredito.Image = CType(resources.GetObject("cmdNotasCredito.Image"), System.Drawing.Image)
        Me.cmdNotasCredito.Name = "cmdNotasCredito"
        Me.cmdNotasCredito.Text = "Notas de Crédito"
        '
        'cmdNotasDebito
        '
        Me.cmdNotasDebito.Image = CType(resources.GetObject("cmdNotasDebito.Image"), System.Drawing.Image)
        Me.cmdNotasDebito.Name = "cmdNotasDebito"
        Me.cmdNotasDebito.Text = "Notas de Débito"
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.Image = CType(resources.GetObject("cmdDevoluciones.Image"), System.Drawing.Image)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Text = "Devoluciones"
        '
        'CmdReestructurar
        '
        Me.CmdReestructurar.Name = "CmdReestructurar"
        Me.CmdReestructurar.Text = "Restructuración de Cuenta"
        '
        'cmdRptVencCuotas
        '
        Me.cmdRptVencCuotas.Image = CType(resources.GetObject("cmdRptVencCuotas.Image"), System.Drawing.Image)
        Me.cmdRptVencCuotas.Name = "cmdRptVencCuotas"
        Me.cmdRptVencCuotas.Text = "Vencimiento de Cuotas"
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.Image = CType(resources.GetObject("cmdEstadoCuenta.Image"), System.Drawing.Image)
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        Me.cmdEstadoCuenta.Text = "Estado de Cuenta"
        '
        'cmdEstadoCrediticio
        '
        Me.cmdEstadoCrediticio.Image = CType(resources.GetObject("cmdEstadoCrediticio.Image"), System.Drawing.Image)
        Me.cmdEstadoCrediticio.Name = "cmdEstadoCrediticio"
        Me.cmdEstadoCrediticio.Text = "Estado Crediticio"
        '
        'cmdRptDevoluciones
        '
        Me.cmdRptDevoluciones.Image = CType(resources.GetObject("cmdRptDevoluciones.Image"), System.Drawing.Image)
        Me.cmdRptDevoluciones.Name = "cmdRptDevoluciones"
        Me.cmdRptDevoluciones.Text = "Devoluciones"
        '
        'cmdRptSeguimiento
        '
        Me.cmdRptSeguimiento.Image = CType(resources.GetObject("cmdRptSeguimiento.Image"), System.Drawing.Image)
        Me.cmdRptSeguimiento.Name = "cmdRptSeguimiento"
        Me.cmdRptSeguimiento.Text = "Seguimiento a Clientes"
        '
        'cmdReciboCaja
        '
        Me.cmdReciboCaja.Image = CType(resources.GetObject("cmdReciboCaja.Image"), System.Drawing.Image)
        Me.cmdReciboCaja.Name = "cmdReciboCaja"
        Me.cmdReciboCaja.Text = "Recibo de Caja"
        '
        'cmdProductos
        '
        Me.cmdProductos.Name = "cmdProductos"
        Me.cmdProductos.Text = "Productos"
        '
        'cmdFactura
        '
        Me.cmdFactura.Image = CType(resources.GetObject("cmdFactura.Image"), System.Drawing.Image)
        Me.cmdFactura.Name = "cmdFactura"
        Me.cmdFactura.Text = "Facturas-Expediente"
        '
        'cmdBitacora
        '
        Me.cmdBitacora.Image = CType(resources.GetObject("cmdBitacora.Image"), System.Drawing.Image)
        Me.cmdBitacora.Name = "cmdBitacora"
        Me.cmdBitacora.Text = "Bitacora de Seguimiento"
        Me.cmdBitacora.ToolTipText = "Bitacora de Seguimientos a los Clientes"
        '
        'cmdParametros
        '
        Me.cmdParametros.Icon = CType(resources.GetObject("cmdParametros.Icon"), System.Drawing.Icon)
        Me.cmdParametros.Name = "cmdParametros"
        Me.cmdParametros.Text = "Parámetros"
        '
        'cmdRptEstadoCuenta
        '
        Me.cmdRptEstadoCuenta.Name = "cmdRptEstadoCuenta"
        Me.cmdRptEstadoCuenta.Text = "Estado de Cuenta"
        '
        'RptMorosidad
        '
        Me.RptMorosidad.Icon = CType(resources.GetObject("RptMorosidad.Icon"), System.Drawing.Icon)
        Me.RptMorosidad.Name = "RptMorosidad"
        Me.RptMorosidad.Text = "Morosidad de Clientes"
        '
        'cmdPorcentajeMorosidad
        '
        Me.cmdPorcentajeMorosidad.Icon = CType(resources.GetObject("cmdPorcentajeMorosidad.Icon"), System.Drawing.Icon)
        Me.cmdPorcentajeMorosidad.Name = "cmdPorcentajeMorosidad"
        Me.cmdPorcentajeMorosidad.Text = "Consolidado de Facturas en Mora"
        '
        'cmdSaldoConsolidado
        '
        Me.cmdSaldoConsolidado.Icon = CType(resources.GetObject("cmdSaldoConsolidado.Icon"), System.Drawing.Icon)
        Me.cmdSaldoConsolidado.Name = "cmdSaldoConsolidado"
        Me.cmdSaldoConsolidado.Text = "Saldo Consolidado"
        '
        'cmdMinutas
        '
        Me.cmdMinutas.Image = Global.SCCUM.My.Resources.Resources.Autorizar_Pedido
        Me.cmdMinutas.Name = "cmdMinutas"
        Me.cmdMinutas.Text = "Minutas de cobro"
        '
        'cmdRptCarteraRangos
        '
        Me.cmdRptCarteraRangos.Icon = CType(resources.GetObject("cmdRptCarteraRangos.Icon"), System.Drawing.Icon)
        Me.cmdRptCarteraRangos.Name = "cmdRptCarteraRangos"
        Me.cmdRptCarteraRangos.Text = "Detalle de Cartera por Rangos"
        '
        'cmdRptHistorialClientes
        '
        Me.cmdRptHistorialClientes.Icon = CType(resources.GetObject("cmdRptHistorialClientes.Icon"), System.Drawing.Icon)
        Me.cmdRptHistorialClientes.Name = "cmdRptHistorialClientes"
        Me.cmdRptHistorialClientes.Text = "Historial Clientes"
        '
        'cmdRptRecuperacionComparativo
        '
        Me.cmdRptRecuperacionComparativo.Icon = CType(resources.GetObject("cmdRptRecuperacionComparativo.Icon"), System.Drawing.Icon)
        Me.cmdRptRecuperacionComparativo.Name = "cmdRptRecuperacionComparativo"
        Me.cmdRptRecuperacionComparativo.Text = "Recuperación Comparativo"
        '
        'cmdTramiteLegal
        '
        Me.cmdTramiteLegal.Image = Global.SCCUM.My.Resources.Resources.balanza
        Me.cmdTramiteLegal.Name = "cmdTramiteLegal"
        Me.cmdTramiteLegal.Text = "Trámite Legal"
        '
        'cmdProveedores
        '
        Me.cmdProveedores.Image = CType(resources.GetObject("cmdProveedores.Image"), System.Drawing.Image)
        Me.cmdProveedores.Name = "cmdProveedores"
        Me.cmdProveedores.Text = "Proveedores"
        '
        'cmdSolicitudTransferencia
        '
        Me.cmdSolicitudTransferencia.Image = CType(resources.GetObject("cmdSolicitudTransferencia.Image"), System.Drawing.Image)
        Me.cmdSolicitudTransferencia.Name = "cmdSolicitudTransferencia"
        Me.cmdSolicitudTransferencia.Text = "Solicitar Traslado"
        '
        'cmdDespacharTransferencia
        '
        Me.cmdDespacharTransferencia.Image = CType(resources.GetObject("cmdDespacharTransferencia.Image"), System.Drawing.Image)
        Me.cmdDespacharTransferencia.Name = "cmdDespacharTransferencia"
        Me.cmdDespacharTransferencia.Text = "Despachar Traslado"
        '
        'cmdRecepcionarTransferencia
        '
        Me.cmdRecepcionarTransferencia.Image = CType(resources.GetObject("cmdRecepcionarTransferencia.Image"), System.Drawing.Image)
        Me.cmdRecepcionarTransferencia.Name = "cmdRecepcionarTransferencia"
        Me.cmdRecepcionarTransferencia.Text = "Recibir traslado"
        '
        'cmdRptInventario
        '
        Me.cmdRptInventario.Image = CType(resources.GetObject("cmdRptInventario.Image"), System.Drawing.Image)
        Me.cmdRptInventario.Name = "cmdRptInventario"
        Me.cmdRptInventario.Text = "Inventario"
        '
        'cmdRptListadoPrecios
        '
        Me.cmdRptListadoPrecios.Image = CType(resources.GetObject("cmdRptListadoPrecios.Image"), System.Drawing.Image)
        Me.cmdRptListadoPrecios.Name = "cmdRptListadoPrecios"
        Me.cmdRptListadoPrecios.Text = "Listado Precios"
        '
        'cmdPromociones
        '
        Me.cmdPromociones.Image = CType(resources.GetObject("cmdPromociones.Image"), System.Drawing.Image)
        Me.cmdPromociones.Name = "cmdPromociones"
        Me.cmdPromociones.Text = "Promociones"
        '
        'cmdSalidaBodega
        '
        Me.cmdSalidaBodega.Image = CType(resources.GetObject("cmdSalidaBodega.Image"), System.Drawing.Image)
        Me.cmdSalidaBodega.Name = "cmdSalidaBodega"
        Me.cmdSalidaBodega.Text = "Salida Bodega"
        '
        'cmdEntradaBodega
        '
        Me.cmdEntradaBodega.Image = CType(resources.GetObject("cmdEntradaBodega.Image"), System.Drawing.Image)
        Me.cmdEntradaBodega.Name = "cmdEntradaBodega"
        Me.cmdEntradaBodega.Text = "Entrada Bodega"
        '
        'cmdRepuestos
        '
        Me.cmdRepuestos.Image = CType(resources.GetObject("cmdRepuestos.Image"), System.Drawing.Image)
        Me.cmdRepuestos.Name = "cmdRepuestos"
        Me.cmdRepuestos.Text = "Repuestos"
        '
        'cmdCotizaciones
        '
        Me.cmdCotizaciones.Image = CType(resources.GetObject("cmdCotizaciones.Image"), System.Drawing.Image)
        Me.cmdCotizaciones.Name = "cmdCotizaciones"
        Me.cmdCotizaciones.Text = "Cotizaciones"
        '
        'cmdFacturasRepuestos
        '
        Me.cmdFacturasRepuestos.Image = CType(resources.GetObject("cmdFacturasRepuestos.Image"), System.Drawing.Image)
        Me.cmdFacturasRepuestos.Name = "cmdFacturasRepuestos"
        Me.cmdFacturasRepuestos.Text = "Facturas Repuestos"
        '
        'cmdRptEntrada
        '
        Me.cmdRptEntrada.Image = CType(resources.GetObject("cmdRptEntrada.Image"), System.Drawing.Image)
        Me.cmdRptEntrada.Name = "cmdRptEntrada"
        Me.cmdRptEntrada.Text = "Entradas"
        '
        'cmdRptSalidas
        '
        Me.cmdRptSalidas.Image = CType(resources.GetObject("cmdRptSalidas.Image"), System.Drawing.Image)
        Me.cmdRptSalidas.Name = "cmdRptSalidas"
        Me.cmdRptSalidas.Text = "Salidas"
        '
        'cmdRptSolicitudesTransf
        '
        Me.cmdRptSolicitudesTransf.Image = CType(resources.GetObject("cmdRptSolicitudesTransf.Image"), System.Drawing.Image)
        Me.cmdRptSolicitudesTransf.Name = "cmdRptSolicitudesTransf"
        Me.cmdRptSolicitudesTransf.Text = "Solicitudes Transferencia"
        '
        'cmdRptDespachoTransf
        '
        Me.cmdRptDespachoTransf.Image = CType(resources.GetObject("cmdRptDespachoTransf.Image"), System.Drawing.Image)
        Me.cmdRptDespachoTransf.Name = "cmdRptDespachoTransf"
        Me.cmdRptDespachoTransf.Text = "Despachos Transferencia"
        '
        'cmdRptRecepcionesTransf
        '
        Me.cmdRptRecepcionesTransf.Image = CType(resources.GetObject("cmdRptRecepcionesTransf.Image"), System.Drawing.Image)
        Me.cmdRptRecepcionesTransf.Name = "cmdRptRecepcionesTransf"
        Me.cmdRptRecepcionesTransf.Text = "Recepciones Transferencias"
        '
        'cmdRptDiferenciasTransf
        '
        Me.cmdRptDiferenciasTransf.Image = CType(resources.GetObject("cmdRptDiferenciasTransf.Image"), System.Drawing.Image)
        Me.cmdRptDiferenciasTransf.Name = "cmdRptDiferenciasTransf"
        Me.cmdRptDiferenciasTransf.Text = "Diferencias Solicitudes vs Recepción"
        '
        'cmdRptKardex
        '
        Me.cmdRptKardex.Image = CType(resources.GetObject("cmdRptKardex.Image"), System.Drawing.Image)
        Me.cmdRptKardex.Name = "cmdRptKardex"
        Me.cmdRptKardex.Text = "Kardex"
        '
        'cmdRptCotizaciones
        '
        Me.cmdRptCotizaciones.Image = CType(resources.GetObject("cmdRptCotizaciones.Image"), System.Drawing.Image)
        Me.cmdRptCotizaciones.Name = "cmdRptCotizaciones"
        Me.cmdRptCotizaciones.Text = "Cotizaciones (Pendiente)"
        '
        'cmdRptFacturacion
        '
        Me.cmdRptFacturacion.Image = CType(resources.GetObject("cmdRptFacturacion.Image"), System.Drawing.Image)
        Me.cmdRptFacturacion.Name = "cmdRptFacturacion"
        Me.cmdRptFacturacion.Text = "Facturación / Ventas"
        '
        'cmdRptRepuestosFacturados
        '
        Me.cmdRptRepuestosFacturados.Image = CType(resources.GetObject("cmdRptRepuestosFacturados.Image"), System.Drawing.Image)
        Me.cmdRptRepuestosFacturados.Name = "cmdRptRepuestosFacturados"
        Me.cmdRptRepuestosFacturados.Text = "Repuestos Facturados"
        '
        'cmdRptPromociones
        '
        Me.cmdRptPromociones.Image = CType(resources.GetObject("cmdRptPromociones.Image"), System.Drawing.Image)
        Me.cmdRptPromociones.Name = "cmdRptPromociones"
        Me.cmdRptPromociones.Text = "Promociones"
        '
        'cmdRptUtilidades
        '
        Me.cmdRptUtilidades.Image = CType(resources.GetObject("cmdRptUtilidades.Image"), System.Drawing.Image)
        Me.cmdRptUtilidades.Name = "cmdRptUtilidades"
        Me.cmdRptUtilidades.Text = "Utilidades (Pendiente)"
        '
        'cmdRptComiciones
        '
        Me.cmdRptComiciones.Image = CType(resources.GetObject("cmdRptComiciones.Image"), System.Drawing.Image)
        Me.cmdRptComiciones.Name = "cmdRptComiciones"
        Me.cmdRptComiciones.Text = "Comiciones"
        '
        'cmdOrdenCompra
        '
        Me.cmdOrdenCompra.Image = CType(resources.GetObject("cmdOrdenCompra.Image"), System.Drawing.Image)
        Me.cmdOrdenCompra.Name = "cmdOrdenCompra"
        Me.cmdOrdenCompra.Text = "Orden Compra"
        '
        'cmdServicioTaller
        '
        Me.cmdServicioTaller.Image = CType(resources.GetObject("cmdServicioTaller.Image"), System.Drawing.Image)
        Me.cmdServicioTaller.Name = "cmdServicioTaller"
        Me.cmdServicioTaller.Text = "Servicio Taller"
        '
        'cmdReporteBitacoraMoto
        '
        Me.cmdReporteBitacoraMoto.Image = CType(resources.GetObject("cmdReporteBitacoraMoto.Image"), System.Drawing.Image)
        Me.cmdReporteBitacoraMoto.Name = "cmdReporteBitacoraMoto"
        Me.cmdReporteBitacoraMoto.Text = "Bitácora Moto"
        '
        'cmdRptEstadisticoServicios
        '
        Me.cmdRptEstadisticoServicios.Image = CType(resources.GetObject("cmdRptEstadisticoServicios.Image"), System.Drawing.Image)
        Me.cmdRptEstadisticoServicios.Name = "cmdRptEstadisticoServicios"
        Me.cmdRptEstadisticoServicios.Text = "Estadistico de Servicios"
        '
        'cmdSolicitudesRepuestoGarantia
        '
        Me.cmdSolicitudesRepuestoGarantia.Image = CType(resources.GetObject("cmdSolicitudesRepuestoGarantia.Image"), System.Drawing.Image)
        Me.cmdSolicitudesRepuestoGarantia.Name = "cmdSolicitudesRepuestoGarantia"
        Me.cmdSolicitudesRepuestoGarantia.Text = "Solicitudes Repuesto Garantías"
        '
        'cmdSolicitudesDescuento
        '
        Me.cmdSolicitudesDescuento.Image = CType(resources.GetObject("cmdSolicitudesDescuento.Image"), System.Drawing.Image)
        Me.cmdSolicitudesDescuento.Name = "cmdSolicitudesDescuento"
        Me.cmdSolicitudesDescuento.Text = "Solicitudes de Descuentos"
        '
        'C1CommandLink7
        '
        Me.C1CommandLink7.Command = Me.cmdCatalogoValor
        Me.C1CommandLink7.ToolTipText = "Catalogo Valor"
        '
        'C1CommandLink11
        '
        Me.C1CommandLink11.Command = Me.cmdPersonas
        Me.C1CommandLink11.SortOrder = 1
        Me.C1CommandLink11.ToolTipText = "Personas"
        '
        'cmdLinkMuestrasMedicas
        '
        Me.cmdLinkMuestrasMedicas.Command = Me.cmdTienda
        Me.cmdLinkMuestrasMedicas.SortOrder = 2
        Me.cmdLinkMuestrasMedicas.ToolTipText = "Sucursales"
        '
        'cmdLinkDevolucionDeVencidos
        '
        Me.cmdLinkDevolucionDeVencidos.Command = Me.cmdProducto
        Me.cmdLinkDevolucionDeVencidos.SortOrder = 3
        Me.cmdLinkDevolucionDeVencidos.ToolTipText = "Productos"
        '
        'cmdLinkDevolucionDeNoVencidos
        '
        Me.cmdLinkDevolucionDeNoVencidos.Command = Me.cmdTasaCambio
        Me.cmdLinkDevolucionDeNoVencidos.SortOrder = 4
        Me.cmdLinkDevolucionDeNoVencidos.ToolTipText = "Tasa de Cambio"
        '
        'cmdRecepcionDeVencidos
        '
        Me.cmdRecepcionDeVencidos.Command = Me.cmdEmpleados
        Me.cmdRecepcionDeVencidos.SortOrder = 5
        Me.cmdRecepcionDeVencidos.ToolTipText = "Empleados"
        '
        'C1CommandLink13
        '
        Me.C1CommandLink13.Command = Me.cmdParametros
        Me.C1CommandLink13.SortOrder = 6
        '
        'C1CommandLink24
        '
        Me.C1CommandLink24.Command = Me.cmdProveedores
        Me.C1CommandLink24.SortOrder = 7
        '
        'C1CommandLink34
        '
        Me.C1CommandLink34.Command = Me.cmdRepuestos
        Me.C1CommandLink34.SortOrder = 8
        '
        'brCartera
        '
        Me.brCartera.Controls.Add(Me.ToolBarCartera)
        Me.brCartera.Name = "brCartera"
        Me.brCartera.Size = New System.Drawing.Size(188, 403)
        Me.brCartera.Text = "Cartera y Cobro"
        '
        'ToolBarCartera
        '
        Me.ToolBarCartera.AccessibleName = "Tool Bar"
        Me.ToolBarCartera.AutoSize = False
        Me.ToolBarCartera.Border.Style = C1.Win.C1Command.BorderStyleEnum.Ridge
        Me.ToolBarCartera.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBarCartera.CommandHolder = Me.C1CommandHolder1
        Me.ToolBarCartera.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink6, Me.C1CommandLink23})
        Me.ToolBarCartera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBarCartera.Horizontal = False
        Me.ToolBarCartera.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarCartera.Movable = False
        Me.ToolBarCartera.Name = "ToolBarCartera"
        Me.ToolBarCartera.Size = New System.Drawing.Size(188, 403)
        Me.ToolBarCartera.Text = "Toolbar Categoria 1"
        Me.ToolBarCartera.VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP
        Me.ToolBarCartera.VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.cmdExpedientes
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.cmdFactura
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Command = Me.cmdReciboCaja
        Me.C1CommandLink3.SortOrder = 2
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.Command = Me.cmdDevoluciones
        Me.C1CommandLink6.SortOrder = 3
        '
        'C1CommandLink23
        '
        Me.C1CommandLink23.Command = Me.cmdTramiteLegal
        Me.C1CommandLink23.SortOrder = 4
        '
        'outReportes
        '
        Me.outReportes.Controls.Add(Me.ToolBReportes)
        Me.outReportes.Name = "outReportes"
        Me.outReportes.Size = New System.Drawing.Size(188, 403)
        Me.outReportes.Text = "Cartera y Cobro - Reportes "
        '
        'ToolBReportes
        '
        Me.ToolBReportes.AccessibleName = "Tool Bar"
        Me.ToolBReportes.AutoSize = False
        Me.ToolBReportes.Border.Style = C1.Win.C1Command.BorderStyleEnum.Ridge
        Me.ToolBReportes.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBReportes.CommandHolder = Me.C1CommandHolder1
        Me.ToolBReportes.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink8, Me.C1CommandLink9, Me.C1CommandLink10, Me.C1CommandLink17, Me.C1CommandLink19, Me.C1CommandLink15, Me.C1CommandLink14, Me.C1CommandLink16, Me.C1CommandLink20, Me.C1CommandLink21, Me.C1CommandLink22})
        Me.ToolBReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBReportes.Horizontal = False
        Me.ToolBReportes.Location = New System.Drawing.Point(0, 0)
        Me.ToolBReportes.Movable = False
        Me.ToolBReportes.Name = "ToolBReportes"
        Me.ToolBReportes.Size = New System.Drawing.Size(188, 403)
        Me.ToolBReportes.Text = "Toolbar Categoria 1"
        Me.ToolBReportes.VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP
        Me.ToolBReportes.VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP
        '
        'C1CommandLink8
        '
        Me.C1CommandLink8.Command = Me.cmdRptVencCuotas
        '
        'C1CommandLink9
        '
        Me.C1CommandLink9.Command = Me.cmdEstadoCuenta
        Me.C1CommandLink9.SortOrder = 1
        '
        'C1CommandLink10
        '
        Me.C1CommandLink10.Command = Me.cmdEstadoCrediticio
        Me.C1CommandLink10.SortOrder = 2
        '
        'C1CommandLink17
        '
        Me.C1CommandLink17.Command = Me.cmdRptDevoluciones
        Me.C1CommandLink17.SortOrder = 3
        '
        'C1CommandLink19
        '
        Me.C1CommandLink19.Command = Me.cmdRptSeguimiento
        Me.C1CommandLink19.SortOrder = 4
        '
        'C1CommandLink15
        '
        Me.C1CommandLink15.Command = Me.RptMorosidad
        Me.C1CommandLink15.SortOrder = 5
        '
        'C1CommandLink14
        '
        Me.C1CommandLink14.Command = Me.cmdPorcentajeMorosidad
        Me.C1CommandLink14.SortOrder = 6
        '
        'C1CommandLink16
        '
        Me.C1CommandLink16.Command = Me.cmdSaldoConsolidado
        Me.C1CommandLink16.SortOrder = 7
        '
        'C1CommandLink20
        '
        Me.C1CommandLink20.Command = Me.cmdRptCarteraRangos
        Me.C1CommandLink20.SortOrder = 8
        '
        'C1CommandLink21
        '
        Me.C1CommandLink21.Command = Me.cmdRptHistorialClientes
        Me.C1CommandLink21.SortOrder = 9
        '
        'C1CommandLink22
        '
        Me.C1CommandLink22.Command = Me.cmdRptRecuperacionComparativo
        Me.C1CommandLink22.SortOrder = 10
        '
        'outBitacora
        '
        Me.outBitacora.Controls.Add(Me.ToolBarBitacora)
        Me.outBitacora.Name = "outBitacora"
        Me.outBitacora.Size = New System.Drawing.Size(188, 403)
        Me.outBitacora.Text = "Cobranza"
        '
        'ToolBarBitacora
        '
        Me.ToolBarBitacora.AccessibleName = "Tool Bar"
        Me.ToolBarBitacora.AutoSize = False
        Me.ToolBarBitacora.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBarBitacora.CommandHolder = Me.C1CommandHolder1
        Me.ToolBarBitacora.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink12, Me.C1CommandLink18})
        Me.ToolBarBitacora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBarBitacora.Horizontal = False
        Me.ToolBarBitacora.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarBitacora.Movable = False
        Me.ToolBarBitacora.Name = "ToolBarBitacora"
        Me.ToolBarBitacora.Size = New System.Drawing.Size(188, 403)
        Me.ToolBarBitacora.Text = "Page1"
        Me.ToolBarBitacora.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink12
        '
        Me.C1CommandLink12.Command = Me.cmdBitacora
        Me.C1CommandLink12.Text = "Bitácora de Seguimiento"
        Me.C1CommandLink12.ToolTipText = "Bitácora de Seguimientos a los Clientes"
        '
        'C1CommandLink18
        '
        Me.C1CommandLink18.Command = Me.cmdMinutas
        Me.C1CommandLink18.SortOrder = 1
        '
        'brInventario
        '
        Me.brInventario.Controls.Add(Me.toolBarInventario)
        Me.brInventario.Name = "brInventario"
        Me.brInventario.Size = New System.Drawing.Size(188, 403)
        Me.brInventario.Text = "Inventario"
        '
        'toolBarInventario
        '
        Me.toolBarInventario.AccessibleName = "Tool Bar"
        Me.toolBarInventario.AutoSize = False
        Me.toolBarInventario.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.toolBarInventario.CommandHolder = Me.C1CommandHolder1
        Me.toolBarInventario.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink33, Me.C1CommandLink32, Me.C1CommandLink26, Me.C1CommandLink27, Me.C1CommandLink28})
        Me.toolBarInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolBarInventario.Horizontal = False
        Me.toolBarInventario.Location = New System.Drawing.Point(0, 0)
        Me.toolBarInventario.Movable = False
        Me.toolBarInventario.Name = "toolBarInventario"
        Me.toolBarInventario.Size = New System.Drawing.Size(188, 403)
        Me.toolBarInventario.Text = "Page1"
        Me.toolBarInventario.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink33
        '
        Me.C1CommandLink33.Command = Me.cmdEntradaBodega
        Me.C1CommandLink33.Text = "Entrada"
        '
        'C1CommandLink32
        '
        Me.C1CommandLink32.Command = Me.cmdSalidaBodega
        Me.C1CommandLink32.SortOrder = 1
        Me.C1CommandLink32.Text = "Salida"
        '
        'C1CommandLink26
        '
        Me.C1CommandLink26.Command = Me.cmdSolicitudTransferencia
        Me.C1CommandLink26.SortOrder = 2
        Me.C1CommandLink26.Text = "Solicitud"
        '
        'C1CommandLink27
        '
        Me.C1CommandLink27.Command = Me.cmdDespacharTransferencia
        Me.C1CommandLink27.SortOrder = 3
        Me.C1CommandLink27.Text = "Despacho"
        '
        'C1CommandLink28
        '
        Me.C1CommandLink28.Command = Me.cmdRecepcionarTransferencia
        Me.C1CommandLink28.SortOrder = 4
        Me.C1CommandLink28.Text = "Recepción"
        '
        'brInventarioReportes
        '
        Me.brInventarioReportes.Controls.Add(Me.ToolBarInventarioReportes)
        Me.brInventarioReportes.Name = "brInventarioReportes"
        Me.brInventarioReportes.Size = New System.Drawing.Size(188, 403)
        Me.brInventarioReportes.Text = "Inventario - Reportes"
        '
        'ToolBarInventarioReportes
        '
        Me.ToolBarInventarioReportes.AccessibleName = "Tool Bar"
        Me.ToolBarInventarioReportes.AutoSize = False
        Me.ToolBarInventarioReportes.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBarInventarioReportes.CommandHolder = Me.C1CommandHolder1
        Me.ToolBarInventarioReportes.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink36, Me.C1CommandLink37, Me.C1CommandLink38, Me.C1CommandLink39, Me.C1CommandLink40, Me.C1CommandLink41, Me.C1CommandLink29, Me.C1CommandLink42})
        Me.ToolBarInventarioReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBarInventarioReportes.Horizontal = False
        Me.ToolBarInventarioReportes.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarInventarioReportes.Movable = False
        Me.ToolBarInventarioReportes.Name = "ToolBarInventarioReportes"
        Me.ToolBarInventarioReportes.Size = New System.Drawing.Size(188, 403)
        Me.ToolBarInventarioReportes.Text = "Page1"
        Me.ToolBarInventarioReportes.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink36
        '
        Me.C1CommandLink36.Command = Me.cmdRptEntrada
        '
        'C1CommandLink37
        '
        Me.C1CommandLink37.Command = Me.cmdRptSalidas
        Me.C1CommandLink37.SortOrder = 1
        '
        'C1CommandLink38
        '
        Me.C1CommandLink38.Command = Me.cmdRptSolicitudesTransf
        Me.C1CommandLink38.SortOrder = 2
        Me.C1CommandLink38.Text = "Solicitudes Traslados"
        '
        'C1CommandLink39
        '
        Me.C1CommandLink39.Command = Me.cmdRptDespachoTransf
        Me.C1CommandLink39.SortOrder = 3
        Me.C1CommandLink39.Text = "Despachos Traslados"
        '
        'C1CommandLink40
        '
        Me.C1CommandLink40.Command = Me.cmdRptRecepcionesTransf
        Me.C1CommandLink40.SortOrder = 4
        Me.C1CommandLink40.Text = "Recepciones Traslados"
        '
        'C1CommandLink41
        '
        Me.C1CommandLink41.Command = Me.cmdRptDiferenciasTransf
        Me.C1CommandLink41.SortOrder = 5
        '
        'C1CommandLink29
        '
        Me.C1CommandLink29.Command = Me.cmdRptInventario
        Me.C1CommandLink29.SortOrder = 6
        '
        'C1CommandLink42
        '
        Me.C1CommandLink42.Command = Me.cmdRptKardex
        Me.C1CommandLink42.SortOrder = 7
        '
        'brFacturacion
        '
        Me.brFacturacion.Controls.Add(Me.ToolBarFacturas)
        Me.brFacturacion.Name = "brFacturacion"
        Me.brFacturacion.Size = New System.Drawing.Size(188, 403)
        Me.brFacturacion.Text = "Facturación"
        '
        'ToolBarFacturas
        '
        Me.ToolBarFacturas.AccessibleName = "Tool Bar"
        Me.ToolBarFacturas.AutoSize = False
        Me.ToolBarFacturas.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBarFacturas.CommandHolder = Me.C1CommandHolder1
        Me.ToolBarFacturas.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink25, Me.C1CommandLink35, Me.C1CommandLink31, Me.C1CommandLink49, Me.C1CommandLink54})
        Me.ToolBarFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBarFacturas.Horizontal = False
        Me.ToolBarFacturas.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarFacturas.Movable = False
        Me.ToolBarFacturas.Name = "ToolBarFacturas"
        Me.ToolBarFacturas.Size = New System.Drawing.Size(188, 403)
        Me.ToolBarFacturas.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink25
        '
        Me.C1CommandLink25.Command = Me.cmdCotizaciones
        '
        'C1CommandLink35
        '
        Me.C1CommandLink35.Command = Me.cmdFacturasRepuestos
        Me.C1CommandLink35.SortOrder = 1
        Me.C1CommandLink35.Text = "Facturas"
        '
        'C1CommandLink31
        '
        Me.C1CommandLink31.Command = Me.cmdPromociones
        Me.C1CommandLink31.SortOrder = 2
        '
        'C1CommandLink49
        '
        Me.C1CommandLink49.Command = Me.cmdOrdenCompra
        Me.C1CommandLink49.SortOrder = 3
        '
        'C1CommandLink54
        '
        Me.C1CommandLink54.Command = Me.cmdSolicitudesDescuento
        Me.C1CommandLink54.SortOrder = 4
        '
        'brFacturacionReportes
        '
        Me.brFacturacionReportes.Controls.Add(Me.ToolBarFacturacionReportes)
        Me.brFacturacionReportes.Name = "brFacturacionReportes"
        Me.brFacturacionReportes.Size = New System.Drawing.Size(188, 403)
        Me.brFacturacionReportes.Text = "Facturación - Reportes"
        '
        'ToolBarFacturacionReportes
        '
        Me.ToolBarFacturacionReportes.AccessibleName = "Tool Bar"
        Me.ToolBarFacturacionReportes.AutoSize = False
        Me.ToolBarFacturacionReportes.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBarFacturacionReportes.CommandHolder = Me.C1CommandHolder1
        Me.ToolBarFacturacionReportes.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink30, Me.C1CommandLink43, Me.C1CommandLink44, Me.C1CommandLink45, Me.C1CommandLink46, Me.C1CommandLink47, Me.C1CommandLink48})
        Me.ToolBarFacturacionReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBarFacturacionReportes.Horizontal = False
        Me.ToolBarFacturacionReportes.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarFacturacionReportes.Movable = False
        Me.ToolBarFacturacionReportes.Name = "ToolBarFacturacionReportes"
        Me.ToolBarFacturacionReportes.Size = New System.Drawing.Size(188, 403)
        Me.ToolBarFacturacionReportes.Text = "Page1"
        Me.ToolBarFacturacionReportes.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink30
        '
        Me.C1CommandLink30.Command = Me.cmdRptListadoPrecios
        '
        'C1CommandLink43
        '
        Me.C1CommandLink43.Command = Me.cmdRptCotizaciones
        Me.C1CommandLink43.SortOrder = 1
        Me.C1CommandLink43.Text = "Cotizaciones"
        '
        'C1CommandLink44
        '
        Me.C1CommandLink44.Command = Me.cmdRptFacturacion
        Me.C1CommandLink44.SortOrder = 2
        '
        'C1CommandLink45
        '
        Me.C1CommandLink45.Command = Me.cmdRptRepuestosFacturados
        Me.C1CommandLink45.SortOrder = 3
        '
        'C1CommandLink46
        '
        Me.C1CommandLink46.Command = Me.cmdRptPromociones
        Me.C1CommandLink46.SortOrder = 4
        '
        'C1CommandLink47
        '
        Me.C1CommandLink47.Command = Me.cmdRptUtilidades
        Me.C1CommandLink47.SortOrder = 5
        Me.C1CommandLink47.Text = "Utilidades"
        '
        'C1CommandLink48
        '
        Me.C1CommandLink48.Command = Me.cmdRptComiciones
        Me.C1CommandLink48.SortOrder = 6
        Me.C1CommandLink48.Text = "Comiciones"
        '
        'brTaller
        '
        Me.brTaller.Controls.Add(Me.ToolBarTaller)
        Me.brTaller.Name = "brTaller"
        Me.brTaller.Size = New System.Drawing.Size(188, 403)
        Me.brTaller.Text = "Taller"
        '
        'ToolBarTaller
        '
        Me.ToolBarTaller.AccessibleName = "Tool Bar"
        Me.ToolBarTaller.AutoSize = False
        Me.ToolBarTaller.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBarTaller.CommandHolder = Me.C1CommandHolder1
        Me.ToolBarTaller.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink50, Me.C1CommandLink53})
        Me.ToolBarTaller.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBarTaller.Horizontal = False
        Me.ToolBarTaller.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarTaller.Movable = False
        Me.ToolBarTaller.Name = "ToolBarTaller"
        Me.ToolBarTaller.Size = New System.Drawing.Size(188, 403)
        Me.ToolBarTaller.Text = "Page1"
        Me.ToolBarTaller.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink50
        '
        Me.C1CommandLink50.Command = Me.cmdServicioTaller
        '
        'C1CommandLink53
        '
        Me.C1CommandLink53.Command = Me.cmdSolicitudesRepuestoGarantia
        Me.C1CommandLink53.SortOrder = 1
        '
        'brTallerReportes
        '
        Me.brTallerReportes.Controls.Add(Me.ToolBarTallerReportes)
        Me.brTallerReportes.Name = "brTallerReportes"
        Me.brTallerReportes.Size = New System.Drawing.Size(188, 385)
        Me.brTallerReportes.Text = "Taller - Reportes"
        '
        'ToolBarTallerReportes
        '
        Me.ToolBarTallerReportes.AccessibleName = "Tool Bar"
        Me.ToolBarTallerReportes.AutoSize = False
        Me.ToolBarTallerReportes.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ToolBarTallerReportes.CommandHolder = Me.C1CommandHolder1
        Me.ToolBarTallerReportes.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink51, Me.C1CommandLink52})
        Me.ToolBarTallerReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolBarTallerReportes.Horizontal = False
        Me.ToolBarTallerReportes.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarTallerReportes.Movable = False
        Me.ToolBarTallerReportes.Name = "ToolBarTallerReportes"
        Me.ToolBarTallerReportes.Size = New System.Drawing.Size(188, 385)
        Me.ToolBarTallerReportes.Text = "Page1"
        Me.ToolBarTallerReportes.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandLink51
        '
        Me.C1CommandLink51.Command = Me.cmdReporteBitacoraMoto
        '
        'C1CommandLink52
        '
        Me.C1CommandLink52.Command = Me.cmdRptEstadisticoServicios
        Me.C1CommandLink52.SortOrder = 1
        Me.C1CommandLink52.Text = "Estadístico de Servicios"
        '
        'tmrVerificarDescuento
        '
        Me.tmrVerificarDescuento.Interval = 5000
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
        Me.stbPrincipal.LeftPaneItems.Add(Me.lblSucursal)
        Me.stbPrincipal.Location = New System.Drawing.Point(188, 585)
        Me.stbPrincipal.Name = "stbPrincipal"
        Me.stbPrincipal.RightPaneItems.Add(Me.lblFecha)
        Me.stbPrincipal.RightPaneItems.Add(Me.lblHora)
        Me.stbPrincipal.RightPaneWidth = 240
        Me.stbPrincipal.Size = New System.Drawing.Size(607, 22)
        Me.stbPrincipal.TabIndex = 14
        Me.stbPrincipal.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Silver
        '
        'lblServidor
        '
        Me.lblServidor.ID = "lblServidor"
        Me.lblServidor.SmallImage = CType(resources.GetObject("lblServidor.SmallImage"), System.Drawing.Image)
        Me.lblServidor.Text = "Servidor :"
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.ID = "RibbonSeparator1"
        '
        'lblBaseDatos
        '
        Me.lblBaseDatos.ID = "lblBaseDatos"
        Me.lblBaseDatos.SmallImage = CType(resources.GetObject("lblBaseDatos.SmallImage"), System.Drawing.Image)
        Me.lblBaseDatos.Text = "Base de Datos :"
        '
        'RibbonSeparator2
        '
        Me.RibbonSeparator2.ID = "RibbonSeparator2"
        '
        'lblUsuario
        '
        Me.lblUsuario.ID = "lblUsuario"
        Me.lblUsuario.SmallImage = CType(resources.GetObject("lblUsuario.SmallImage"), System.Drawing.Image)
        Me.lblUsuario.Text = "Usuario :"
        '
        'RibbonSeparator3
        '
        Me.RibbonSeparator3.ID = "RibbonSeparator3"
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
        'RibbonSeparator4
        '
        Me.RibbonSeparator4.ID = "RibbonSeparator4"
        '
        'lblSucursal
        '
        Me.lblSucursal.ID = "lblSucursal"
        Me.lblSucursal.SmallImage = CType(resources.GetObject("lblSucursal.SmallImage"), System.Drawing.Image)
        Me.lblSucursal.Text = " Sucursal: "
        '
        'lblFecha
        '
        Me.lblFecha.ID = "lblFecha"
        Me.lblFecha.SmallImage = CType(resources.GetObject("lblFecha.SmallImage"), System.Drawing.Image)
        Me.lblFecha.Text = "Fechar :"
        '
        'lblHora
        '
        Me.lblHora.ID = "lblHora"
        Me.lblHora.SmallImage = CType(resources.GetObject("lblHora.SmallImage"), System.Drawing.Image)
        Me.lblHora.Text = "Hora :"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SCCUM.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(795, 607)
        Me.Controls.Add(Me.stbPrincipal)
        Me.Controls.Add(Me.OutBarPrincipal)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema SIFAC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        CType(Me.OutBarPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OutBarPrincipal.ResumeLayout(False)
        Me.brCatalogos.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.brCartera.ResumeLayout(False)
        Me.outReportes.ResumeLayout(False)
        Me.outBitacora.ResumeLayout(False)
        Me.brInventario.ResumeLayout(False)
        Me.brInventarioReportes.ResumeLayout(False)
        Me.brFacturacion.ResumeLayout(False)
        Me.brFacturacionReportes.ResumeLayout(False)
        Me.brTaller.ResumeLayout(False)
        Me.brTallerReportes.ResumeLayout(False)
        CType(Me.stbPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents OutBarPrincipal As C1.Win.C1Command.C1OutBar
    Friend WithEvents cmdCatalogoValor As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdPersonas As C1.Win.C1Command.C1Command
    Friend WithEvents cmdTienda As C1.Win.C1Command.C1Command
    Friend WithEvents cmdProducto As C1.Win.C1Command.C1Command
    Friend WithEvents cmdTasaCambio As C1.Win.C1Command.C1Command
    Friend WithEvents cmdEmpleados As C1.Win.C1Command.C1Command
    Friend WithEvents cmdExpedientes As C1.Win.C1Command.C1Command
    Friend WithEvents cmdNotasCredito As C1.Win.C1Command.C1Command
    Friend WithEvents cmdNotasDebito As C1.Win.C1Command.C1Command
    Friend WithEvents cmdDevoluciones As C1.Win.C1Command.C1Command
    Friend WithEvents CmdReestructurar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptVencCuotas As C1.Win.C1Command.C1Command
    Friend WithEvents cmdEstadoCuenta As C1.Win.C1Command.C1Command
    Friend WithEvents cmdEstadoCrediticio As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptDevoluciones As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptSeguimiento As C1.Win.C1Command.C1Command
    Friend WithEvents cmdReciboCaja As C1.Win.C1Command.C1Command
    Friend WithEvents brCatalogos As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBarCatalogos As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink11 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdLinkMuestrasMedicas As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdLinkDevolucionDeVencidos As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdLinkDevolucionDeNoVencidos As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRecepcionDeVencidos As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdProductos As C1.Win.C1Command.C1Command
    Friend WithEvents brCartera As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBarCartera As C1.Win.C1Command.C1ToolBar
    Friend WithEvents cmdFactura As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents outReportes As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBReportes As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink9 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink10 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink17 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink19 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdBitacora As C1.Win.C1Command.C1Command
    Friend WithEvents outBitacora As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBarBitacora As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink12 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdParametros As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink13 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRptEstadoCuenta As C1.Win.C1Command.C1Command
    Friend WithEvents RptMorosidad As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink15 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdPorcentajeMorosidad As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink14 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdSaldoConsolidado As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink16 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdMinutas As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink18 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRptCarteraRangos As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink20 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRptHistorialClientes As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink21 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRptRecuperacionComparativo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink22 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdTramiteLegal As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink23 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdProveedores As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink24 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents brInventario As C1.Win.C1Command.C1OutPage
    Friend WithEvents toolBarInventario As C1.Win.C1Command.C1ToolBar
    Friend WithEvents cmdSolicitudTransferencia As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink26 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdDespacharTransferencia As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink27 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRecepcionarTransferencia As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink28 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents brInventarioReportes As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBarInventarioReportes As C1.Win.C1Command.C1ToolBar
    Friend WithEvents cmdRptInventario As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink29 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents brFacturacionReportes As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBarFacturacionReportes As C1.Win.C1Command.C1ToolBar
    Friend WithEvents cmdRptListadoPrecios As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink30 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents brFacturacion As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBarFacturas As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink31 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdPromociones As C1.Win.C1Command.C1Command
    Friend WithEvents cmdSalidaBodega As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink32 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdEntradaBodega As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink33 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRepuestos As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink34 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCotizaciones As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink25 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdFacturasRepuestos As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink35 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents brTaller As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBarTaller As C1.Win.C1Command.C1ToolBar
    Friend WithEvents brTallerReportes As C1.Win.C1Command.C1OutPage
    Friend WithEvents ToolBarTallerReportes As C1.Win.C1Command.C1ToolBar
    Friend WithEvents cmdRptEntrada As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptSalidas As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptSolicitudesTransf As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptDespachoTransf As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptRecepcionesTransf As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptDiferenciasTransf As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink36 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink37 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink38 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink39 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink40 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink41 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRptKardex As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink42 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRptCotizaciones As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptFacturacion As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptRepuestosFacturados As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptPromociones As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptUtilidades As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptComiciones As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink43 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink44 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink45 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink46 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink47 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink48 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdOrdenCompra As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink49 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tmrVerificarDescuento As System.Windows.Forms.Timer
    Friend WithEvents cmdServicioTaller As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink50 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdReporteBitacoraMoto As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRptEstadisticoServicios As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink51 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink52 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdSolicitudesRepuestoGarantia As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink53 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdSolicitudesDescuento As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink54 As C1.Win.C1Command.C1CommandLink
    Private WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmEstiloVisual As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmOfficexp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmOffice2003Olive As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmOffice2007Blue As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmOffice2007Silver As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmOffice2007Black As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmAyuda As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents lblSucursal As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents lblFecha As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents lblHora As C1.Win.C1Ribbon.RibbonLabel
    Private WithEvents tmrPrincipal As System.Windows.Forms.Timer
End Class
