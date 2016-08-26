Imports DAL
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports Seguridad.Formularios
Imports Proyecto.Catalogos.Formularios
Imports System.ComponentModel
'Imports System.Net.Sockets
Imports SIFAC.BO 'Uso de clsConsultas
Imports Proyecto.Catalogos

Public Class frmPrincipal

    Public Shared glbGerencia As Boolean = False
    Public Shared glbObjTiendaSessionId As Integer
    Public Shared glbEstadoFacturaRegistrada As Integer
    Public Shared glbVentanaSolicDescuentoAbierta As Boolean
    Public Shared glbVentanaSolicRepuestoAbierta As Boolean
    Public Shared glbObjTiendaCentralID As Integer

#Region "Declaracion de Variables Locales y Objetos"
    Dim BkColor As System.Drawing.Color
    Dim clsAppConfig As clsAppconfiguration
    Dim ImagenFondo As System.Drawing.Image = Nothing
#End Region

#Region "Eventos del Formulario"

    ''' <summary>
    ''' Cargar el Formulario Principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.outBitacora.PageVisible = False
            'Me.brCartera.PageVisible = False

            Me.brFacturacion.PageVisible = True
            Me.brFacturacionReportes.PageVisible = False

            Me.InicializarPropiedades()

            Me.VisualStyle(clsProyecto.TemaDefinido)
            Me.IniciarSesion()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Metodos de Configuración"
    ''' <summary>
    ''' Este metodo tiene como objetivo inicializar las propiedades con que 
    ''' se conecto el sistema
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InicializarPropiedades()
        Try
            Dim info As ConnectionInfo = SqlHelper.GetConnectionInfo()
            Me.clsAppConfig = New clsAppconfiguration
            Me.BkColor = New System.Drawing.Color

            clsProyecto.TemaDefinido = Me.clsAppConfig.Getkey("TemaDefinido")
            If clsProyecto.TemaDefinido.Trim.Length = 0 Then
                clsProyecto.TemaDefinido = "Office2007Silver"
            End If
            clsProyecto.SiglasSistema = Me.clsAppConfig.Getkey("NombreSistema")
            clsProyecto.Sucursal = Me.clsAppConfig.Getkey("Sucursal")
            clsProyecto.ImpresoraBarCode = Me.clsAppConfig.Getkey("ImpresoraBarcode")
            clsProyecto.ImpresoraFacturas = Me.clsAppConfig.Getkey("ImpresoraFacturas")

            clsProyecto.RESOURCE_PATH = Application.StartupPath
            clsProyecto.Conexion.BaseDeDatos = info.DatabaseName
            clsProyecto.Conexion.Servidor = info.ServerName
            clsProyecto.blnAplicarSeguridad = True
            Me.Text = clsProyecto.SiglasSistema
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Se configura el estatus bar con todos los valores de coneccion
    ''' que fueron alimentados con el metodo de inicializacion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CagarInformacionConeccion()
        Try
            Me.lblBaseDatos.Text = " Base de Datos : " & clsProyecto.Conexion.BaseDeDatos
            Me.lblServidor.Text = " Servidor : " & clsProyecto.Conexion.Servidor
            Me.lblUsuario.Text = " Usuario : " & clsProyecto.Conexion.Usuario
            Me.lblFecha.Text = " Fecha : " + clsProyecto.Conexion.FechaServidor.ToShortDateString()
            Me.lblHora.Text = " Hora : " + clsProyecto.Conexion.FechaServidor.ToShortTimeString

            Me.tmrPrincipal.Start()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub tmrPrincipal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPrincipal.Tick
        Try
            Me.lblHora.Text = " Hora : " + DateTime.Now.ToShortTimeString
            Me.ClearMemory()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Apariencia"

    Private Sub tsmOfficexp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOfficexp.Click
        Me.VisualStyle("Officexp")
    End Sub

    Private Sub tsmOffice2003Olive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOffice2003Olive.Click
        Me.VisualStyle("Office2003Olive")
    End Sub

    Private Sub tsmOffice2007Blue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOffice2007Blue.Click
        Me.VisualStyle("Office2007Blue")
    End Sub

    Private Sub tsmOffice2007Silver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOffice2007Silver.Click
        Me.VisualStyle("Office2007Silver")
    End Sub

    Private Sub tsmOffice2007Black_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOffice2007Black.Click
        Me.VisualStyle("Office2007Black")
    End Sub

    Private Sub VisualStyle(ByVal Tema As String)
        Try
            clsProyecto.TemaDefinido = Tema
            Select Case clsProyecto.TemaDefinido
                Case "Office2003Olive"
                    BkColor = System.Drawing.Color.FromArgb(206, 217, 174)
                    Me.MenuPrincipal.BackColor = BkColor
                    Me.stbPrincipal.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Silver
                    Me.OutBarPrincipal.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    Me.ToolBarCatalogos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    Me.ToolBarCartera.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    Me.ToolBReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    Me.ToolBarBitacora.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    Me.toolBarInventario.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    Me.ToolBarInventarioReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    Me.ToolBarFacturacionReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    Me.ToolBarFacturas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Olive
                    
                Case "Office2007Blue"
                    BkColor = System.Drawing.Color.FromArgb(191, 219, 255)
                    Me.MenuPrincipal.BackColor = BkColor
                    Me.stbPrincipal.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Blue
                    Me.OutBarPrincipal.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                    Me.ToolBarCatalogos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                    Me.ToolBarCartera.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                    Me.ToolBReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                    Me.ToolBarBitacora.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                    Me.toolBarInventario.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                    Me.ToolBarInventarioReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                    Me.ToolBarFacturacionReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                    Me.ToolBarFacturas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
                   
                Case "Office2007Silver"
                    BkColor = System.Drawing.Color.FromArgb(208, 212, 221)
                    Me.MenuPrincipal.BackColor = BkColor
                    Me.stbPrincipal.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Silver
                    Me.OutBarPrincipal.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Silver
                    Me.ToolBarCatalogos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Silver
                    Me.ToolBarCartera.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
                    Me.ToolBReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
                    Me.ToolBarBitacora.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
                    Me.toolBarInventario.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
                    Me.ToolBarInventarioReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
                    Me.ToolBarFacturacionReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
                    Me.ToolBarFacturas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Silver
                   
                Case "Office2007Black"
                    BkColor = System.Drawing.Color.FromArgb(208, 212, 221)
                    Me.MenuPrincipal.BackColor = BkColor
                    Me.stbPrincipal.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Black
                    Me.OutBarPrincipal.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                    Me.ToolBarCatalogos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                    Me.ToolBarCartera.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                    Me.ToolBReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                    Me.ToolBarBitacora.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                    Me.toolBarInventario.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                    Me.ToolBarInventarioReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                    Me.ToolBarFacturacionReportes.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                    Me.ToolBarFacturas.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Black
                   
                Case "Officexp"
                    BkColor = System.Drawing.Color.FromArgb(236, 233, 216)
                    Me.MenuPrincipal.BackColor = BkColor
                    Me.stbPrincipal.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Silver
                    Me.OutBarPrincipal.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                    Me.ToolBarCatalogos.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                    Me.ToolBarCartera.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                    Me.ToolBReportes.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                    Me.ToolBarBitacora.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                    Me.toolBarInventario.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                    Me.ToolBarInventarioReportes.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                    Me.ToolBarFacturacionReportes.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                    Me.ToolBarFacturas.VisualStyle = C1.Win.C1Command.VisualStyle.OfficeXP
                   
            End Select
            Me.ImagenFondo = My.Resources.Fondo
            Me.BackgroundImage = Me.ImagenFondo

            Me.ConfigMdiChild()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ConfigMdiChild()
        Try
            For Each ChildForm As Form In Me.MdiChildren
                clsProyecto.CargarTemaDefinido(ChildForm)
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Seguridad"

    Private Sub cmdSeguridad_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSeguridad.Click
        Dim objfrm As frmSsgPrincipalSeguridad
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSsgPrincipalSeguridad
            objfrm.Show()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdIniciarSesion_Click1(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.IniciarSesion()
    End Sub

    Private Sub cmdCerrarSesion_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCerrarSesion.Click
        Try
            If Me.MdiChildren.Length > 0 Then
                Select Case MsgBox("Todas las ventanas activas se cerrarán. ¿Desea cerrar sesión?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        '--- Cerrar todos los formulario hijos
                        For Each ChildForm As Form In Me.MdiChildren
                            ChildForm.Close()
                        Next
                        Me.DeshabilitarOpciones()
                        '-----
                        Me.lblUsuario.Text = ""
                        Me.cmdCerrarSesion.Enabled = False
                        Me.cmdIniciarSesion.Enabled = True
                        '-----
                    Case MsgBoxResult.No
                End Select
            Else
                Me.DeshabilitarOpciones()
                '-----
                clsProyecto.Conexion.Usuario = ""
                Me.lblUsuario.Text = ""
                Me.cmdCerrarSesion.Enabled = False
                Me.cmdIniciarSesion.Enabled = True
                '-----              
            End If
            'Deshabilitar el timer de verficiación de descuentos
            Me.tmrVerificarDescuento.Enabled = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

   Private Sub IniciarSesion()
        Dim objfrm As LoginForm
        Try
            objfrm = New LoginForm
            objfrm.BackColor = Me.BkColor
            If objfrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not objfrm.EstaVigente Then
                    MsgBox("Su cuenta ha expirado. Consulte con su administrador", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.Close()
                End If
                If Not objfrm.Activa Then
                    MsgBox("Su cuenta ha sido inactivada. Consulte con su administrador", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.Close()
                End If

                Me.CagarInformacionConeccion()
                Me.AplicarSeguridad()
                Me.cmdCerrarSesion.Enabled = True
                Me.cmdIniciarSesion.Enabled = False
                '-----
            Else
                Me.DeshabilitarOpciones()
                '-----
                Me.cmdCerrarSesion.Enabled = False
                Me.cmdIniciarSesion.Enabled = True
                '-----
            End If

            Try
                glbEstadoFacturaRegistrada = Proyecto.Catalogos.Datos.ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "REGISTRADA")
            Catch ex As Exception
                glbEstadoFacturaRegistrada = 0
            End Try

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AplicarSeguridad()
        Dim objSeg As SsgSeguridad
        Try
            objSeg = New SsgSeguridad
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmPrincipal"

            '----- Opcion Seguridad
            'Me.cmdSeguridad.Enabled = objSeg.TienePermiso("OpcionSeguridad")
            '----- Opcion Catalogos
            If objSeg.TienePermiso("MantCatalogos") Then
                Me.cmdCatalogoValor.Enabled = True
            Else
                Me.cmdCatalogoValor.Enabled = False
            End If

            'Catálogos
            Me.cmdClientes.Enabled = objSeg.TienePermiso("OpcionPersonas")
            Me.cmdTienda.Enabled = objSeg.TienePermiso("OpcionSucursales")
            Me.cmdProducto.Enabled = objSeg.TienePermiso("OpcionProducto")
            Me.cmdTasaCambio.Enabled = objSeg.TienePermiso("OpcionTasaCambio")
            Me.cmdEmpleados.Enabled = objSeg.TienePermiso("OpcionEmpleado")
            Me.cmdParametros.Enabled = objSeg.TienePermiso("OpcionParametros")
            Me.cmdProveedores.Enabled = objSeg.TienePermiso("OpcionProveedor")
            Me.cmdRepuestos.Enabled = objSeg.TienePermiso("OpcionRepuestos")
            Me.cmdMarcas.Enabled = objSeg.TienePermiso("OpcionMarcas")
            Me.cmdCategorias.Enabled = objSeg.TienePermiso("OpcionCategorias")
            Me.cmdRutas.Enabled = objSeg.TienePermiso("OpcionRutas")

            'Cartera y Cobro
            Me.cmdExpedientes.Enabled = objSeg.TienePermiso("OpcionExpediente")
            Me.cmdFactura.Enabled = objSeg.TienePermiso("OpcionFacturaExpediente")
            Me.cmdReciboCaja.Enabled = objSeg.TienePermiso("OpcionReciboCaja")
            Me.cmdNotasCredito.Enabled = objSeg.TienePermiso("OpcionNotaCredito")
            Me.cmdNotasDebito.Enabled = objSeg.TienePermiso("OpcionNotasDebito")
            Me.cmdDevoluciones.Enabled = objSeg.TienePermiso("OpcionDevoluciones")
            Me.cmdTramiteLegal.Enabled = objSeg.TienePermiso("OpcionTramiteLegal")
            Me.cmdDescuento.Enabled = objSeg.TienePermiso("OpcionDescuentos")

            'Reportes cartera
            Me.cmdRptVencCuotas.Enabled = objSeg.TienePermiso("OpcionReporteVencimientoCuotas")
            Me.cmdEstadoCuenta.Enabled = objSeg.TienePermiso("OpcionRptEstadoCuenta")
            Me.cmdEstadoCrediticio.Enabled = objSeg.TienePermiso("OpcionReporteEstadoCrediticio")
            Me.cmdRptDevoluciones.Enabled = objSeg.TienePermiso("OpcionRptDevoluciones")
            Me.cmdRptSeguimiento.Enabled = objSeg.TienePermiso("OpcionRptSeguimiento")
            Me.RptMorosidad.Enabled = objSeg.TienePermiso("OpcionRptMorosidad")
            Me.cmdPorcentajeMorosidad.Enabled = objSeg.TienePermiso("OpcionRptPorcentajeMorosidad")
            Me.cmdSaldoConsolidado.Enabled = objSeg.TienePermiso("OpcionRptSaldoConsolidado")
            Me.cmdRptCarteraRangos.Enabled = objSeg.TienePermiso("OpcionRptDetalleCarteraRango")
            Me.cmdRptHistorialClientes.Enabled = objSeg.TienePermiso("OpcionRptHistorialClientes")
            Me.cmdRptRecuperacionComparativo.Enabled = objSeg.TienePermiso("OpcionRptRecuperacionComparativo")

            'Cobranza
            Me.cmdBitacora.Enabled = objSeg.TienePermiso("OpcionBitacora")
            Me.cmdMinutas.Enabled = objSeg.TienePermiso("OpcionMinutaCobro")

            'Inventario
            Me.cmdSolicitudTransferencia.Enabled = objSeg.TienePermiso("OpcionSolicitudTransf") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdDespacharTransferencia.Enabled = objSeg.TienePermiso("OpcionDespacharTransf") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRecepcionarTransferencia.Enabled = objSeg.TienePermiso("OpcionRecibirTransf") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdSalidaBodega.Enabled = objSeg.TienePermiso("OpcionSalidaBodega") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdEntradaBodega.Enabled = objSeg.TienePermiso("OpcionEntradaBodega") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")

            'Inventario reportes
            Me.cmdRptEntrada.Enabled = objSeg.TienePermiso("OpcionRptEntradas") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptSalidas.Enabled = objSeg.TienePermiso("OpcionRptSalidas") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptSolicitudesTransf.Enabled = objSeg.TienePermiso("OpcionRptSolicitudesTrasalado") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptDespachoTransf.Enabled = objSeg.TienePermiso("OpcionRptDespachoTrasalado") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptRecepcionesTransf.Enabled = objSeg.TienePermiso("OpcionRptRecepcionTrasalado") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptDiferenciasTransf.Enabled = objSeg.TienePermiso("OpcionRptDiferenciasTraslado") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptInventario.Enabled = objSeg.TienePermiso("OpcionInventarioReporte") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptKardex.Enabled = objSeg.TienePermiso("OpcionInventarioReporte") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptPromociones.Enabled = objSeg.TienePermiso("OpcionRptPromociones") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")

            'Facturación
            Me.cmdCotizaciones.Enabled = objSeg.TienePermiso("OpcionCotizaciones") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdFacturasRepuestos.Enabled = objSeg.TienePermiso("OpcionFacturaRepuesto") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdPromociones.Enabled = objSeg.TienePermiso("OpcionPromociones") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdOrdenCompra.Enabled = objSeg.TienePermiso("OpcionOrdenCompra") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdSolicitudesDescuento.Enabled = objSeg.TienePermiso("AUTORIZACIONGERENTE")

            'Facturación reportes
            Me.cmdRptListadoPrecios.Enabled = objSeg.TienePermiso("OpcionReporteListadoPrecio") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptCotizaciones.Enabled = objSeg.TienePermiso("OpcionReporteCotizaciones") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptFacturacion.Enabled = objSeg.TienePermiso("OpcionReporteVentas") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptRepuestosFacturados.Enabled = objSeg.TienePermiso("OpcionReporteRepuestosFacturados") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptPromociones.Enabled = objSeg.TienePermiso("OpcionRptPromociones") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptUtilidades.Enabled = objSeg.TienePermiso("OpcionReporteUtilidades") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdRptComiciones.Enabled = objSeg.TienePermiso("OpcionReporteComisiones") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")

            'Taller
            Me.cmdServicioTaller.Enabled = objSeg.TienePermiso("OpcionServicioTaller") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdSolicitudesRepuestoGarantia.Enabled = objSeg.TienePermiso("AutorizacionJefeTaller") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")

            'Taller reportes
            Me.cmdRptEstadisticoServicios.Enabled = objSeg.TienePermiso("OpcionRptEstadisticoServicioTaller") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.cmdReporteBitacoraMoto.Enabled = objSeg.TienePermiso("OpcionRptBitacoraMoto") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")

            'Habilitar/Deshabilitar FacturaRepuesto - OrdenCompra
            'Me.cmdFacturasRepuestos.Visible = glbObjTiendaSessionId <> glbObjTiendaCentralID
            'Me.cmdOrdenCompra.Visible = glbObjTiendaSessionId = glbObjTiendaCentralID

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub DeshabilitarOpciones()
        Try
            'Me.cmdSeguridad.Enabled = False

            '-- Barra de Menus

            ''-- Barra Lateral
            '-- Catálogos
            Me.cmdCatalogoValor.Enabled = False
            Me.cmdClientes.Enabled = False
            Me.cmdTienda.Enabled = False
            Me.cmdProducto.Enabled = False
            Me.cmdTasaCambio.Enabled = False
            Me.cmdEmpleados.Enabled = False
            Me.cmdParametros.Enabled = False
            Me.cmdProveedores.Enabled = False
            Me.cmdRepuestos.Enabled = False

            '-- Cartera y Cobro
            Me.cmdExpedientes.Enabled = False
            Me.cmdFactura.Enabled = False
            Me.cmdReciboCaja.Enabled = False
            Me.cmdNotasCredito.Enabled = False
            Me.cmdNotasDebito.Enabled = False
            Me.cmdDevoluciones.Enabled = False
            Me.cmdTramiteLegal.Enabled = False

            '-- Reportes cartera
            Me.cmdRptVencCuotas.Enabled = False
            Me.cmdEstadoCuenta.Enabled = False
            Me.cmdEstadoCrediticio.Enabled = False
            Me.cmdRptDevoluciones.Enabled = False
            Me.cmdRptSeguimiento.Enabled = False
            Me.RptMorosidad.Enabled = False
            Me.cmdPorcentajeMorosidad.Enabled = False
            Me.cmdSaldoConsolidado.Enabled = False
            Me.cmdRptCarteraRangos.Enabled = False
            Me.cmdRptHistorialClientes.Enabled = False
            Me.cmdRptRecuperacionComparativo.Enabled = False

            'Cobranza
            Me.cmdBitacora.Enabled = False
            Me.cmdMinutas.Enabled = False

            'Inventario
            Me.cmdSolicitudTransferencia.Enabled = False
            Me.cmdDespacharTransferencia.Enabled = False
            Me.cmdRecepcionarTransferencia.Enabled = False
            Me.cmdSalidaBodega.Enabled = False
            Me.cmdEntradaBodega.Enabled = False

            'Inventario Reportes
            Me.cmdRptEntrada.Enabled = False
            Me.cmdRptSalidas.Enabled = False
            Me.cmdRptSolicitudesTransf.Enabled = False
            Me.cmdRptDespachoTransf.Enabled = False
            Me.cmdRptRecepcionesTransf.Enabled = False
            Me.cmdRptDiferenciasTransf.Enabled = False
            Me.cmdRptInventario.Enabled = False
            Me.cmdRptKardex.Enabled = False

            'Facturación
            Me.cmdRptListadoPrecios.Enabled = False
            Me.cmdPromociones.Enabled = False
            Me.cmdCotizaciones.Enabled = False
            Me.cmdFacturasRepuestos.Enabled = False
            Me.cmdOrdenCompra.Enabled = False
            Me.cmdSolicitudesDescuento.Enabled = False

            'Facturación reportes
            Me.cmdRptListadoPrecios.Enabled = False
            Me.cmdRptCotizaciones.Enabled = False
            Me.cmdRptFacturacion.Enabled = False
            Me.cmdRptRepuestosFacturados.Enabled = False
            Me.cmdRptPromociones.Enabled = False
            Me.cmdRptUtilidades.Enabled = False
            Me.cmdRptComiciones.Enabled = False

            'Taller
            Me.cmdServicioTaller.Enabled = False
            Me.cmdSolicitudesRepuestoGarantia.Enabled = False

            'Taller Reportes
            Me.cmdRptEstadisticoServicios.Enabled = False
            Me.cmdReporteBitacoraMoto.Enabled = False

            '
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Opciones del Menu Principal"

#Region "Catalogos Generales"

    Private Sub tsmCatálogoValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CargarCatalogoValor()
    End Sub

    Private Sub cmdMantCatalogos_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCatalogoValor.Click
        Me.CargarCatalogoValor()
    End Sub

    Private Sub tsmParámetros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CargarParametros()
    End Sub

    Private Sub cmdMarcas_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdMarcas.Click
        CargarMarcas()
    End Sub


    Private Sub cmdBodegas_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdBodegas.Click
        CargarBodegas()

    End Sub
    Private Sub cmdCategorias_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCategorias.Click
        CargarCategorias()
    End Sub
#End Region

#Region "Cargar Personas"
    Private Sub PersonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CargarClientes()
    End Sub
#End Region

#Region "Ventanas"

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

#End Region

#Region "Ayuda"
    Private Sub CargarAyuda()
        Dim EjecutarProceso As Process
        Try
            EjecutarProceso = New Process
            EjecutarProceso.StartInfo.FileName = My.Application.Info.DirectoryPath & "\prjSCCUMHELP_Help"
            EjecutarProceso.Start()

        Catch ex As Win32Exception
            Select Case ex.NativeErrorCode
                Case 2
                    MsgBox("El archivo prjSCCUMHELP_Help no existe.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Case 5
                    MsgBox("Acceso denegado al prjSCCUMHELP_Help.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            End Select
        End Try
    End Sub

    Private Sub tsmAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAyuda.Click
        Me.CargarAyuda()
    End Sub
#End Region

#Region "Salir"

    Private Sub tsmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSalir.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

#End Region

#End Region

#Region "Opciones de la Barra Lateral"

#Region "Rutas"
    Private Sub cmdRutas_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRutas.Click
        Me.CargarRutas()
    End Sub
#End Region

#Region "Descuentos"
    Private Sub cmdDescuento_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdDescuento.Click
        Me.CargarDescuentos()
    End Sub
#End Region

#Region "Clientes"
    Private Sub cmdPersonas_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdClientes.Click
        Me.CargarClientes()
    End Sub
#End Region

#Region "Tasa Camio"
    Private Sub cmdTasaCambio_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdTasaCambio.Click
        Call Me.CargarTasaCambio()
    End Sub
#End Region

#Region "Empleados"
    Private Sub cmdEmpleados_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdEmpleados.Click
        CargarEmpleados()
    End Sub
#End Region

#Region "parámetros"
    Private Sub cmdParametros_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdParametros.Click
        Call Me.CargarParametros()
    End Sub
#End Region

#Region "Tiendas"
    Private Sub cmdTienda_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdTienda.Click
        CargarTiendas()
    End Sub
#End Region

#Region "Productos"
    Private Sub cmdProducto_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdProducto.Click
        CargarProductos()
    End Sub
#End Region

#Region "Proveedores"
    Private Sub cmdProveedores_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdProveedores.Click
        Me.CargarProveedores()
    End Sub
#End Region

#Region "Repuestos"
    Private Sub cmdRepuestos_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRepuestos.Click
        Me.CargarRepuestos()
    End Sub

#End Region

#Region "Solicitud de transferencia"
    Private Sub cmdSolicitudTransferencia_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdSolicitudTransferencia.Click
        Me.CargarSolicitudTransferencia()
    End Sub
#End Region

#Region "Despacho de transferencia"
    Private Sub cmdDespacharTransferencia_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdDespacharTransferencia.Click
        Me.CargarDespachoTransferencia()
    End Sub
#End Region

#Region "Recepción de transferencia"
    Private Sub cmdRecepcionarTransferencia_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRecepcionarTransferencia.Click
        Me.CargarRecepcionTransferencia()
    End Sub
#End Region

#Region "Entrada Bodega"
    Private Sub cmdEntradaBodega_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdEntradaBodega.Click
        Me.CargarEntradaBodega()
    End Sub
#End Region

#Region "Salida Bodega"
    Private Sub cmdSalidaBodega_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdSalidaBodega.Click
        Me.CargarSalidaBodega()
    End Sub
#End Region

#Region "Promociones"
    Private Sub cmdPromociones_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdPromociones.Click
        'Me.CargarPromociones()
    End Sub
#End Region

#Region "Cotizaciones"
    Private Sub cmdCotizaciones_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCotizaciones.Click
        'Me.CargarCotizaciones()
    End Sub
#End Region

#Region "Facturas repuestos"
    Private Sub cmdFacturasRepuestos_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdFacturasRepuestos.Click
        Me.CargarFacturasRepuestos()
    End Sub
#End Region

#Region "Orden de Compra"
    Private Sub cmdOrdenCompra_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdOrdenCompra.Click
        'Me.CargarOrdenesCompra()
    End Sub
#End Region

#Region "Servicio taller"
    Private Sub cmdServicioTaller_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdServicioTaller.Click
        Me.CargarServicioTaller()
    End Sub
#End Region

#Region "Solicitudes de repuestos por Garantía"
    Private Sub cmdSolicitudesRepuestoGarantia_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdSolicitudesRepuestoGarantia.Click
        If Not glbVentanaSolicRepuestoAbierta Then
            If Not Me.CargarSolicitudesRepuestosGarantía() Then
                MsgBox("No hay solicitudes de repuesto por garantía pendientes de autorizar.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            End If
        Else
            Try
                Application.OpenForms.Item("frmAlertaSolicitudRepuesto").Focus()
            Catch ex As Exception
                'Si no encuentra el formulario que no haga nada.
            End Try
        End If
    End Sub
#End Region

#End Region

#Region "Cargar Formularios"

#Region "Cargar Catalogos Generales"

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Catalogos Valor
    '----------------------------------------------------------------------------------
    Private Sub CargarCatalogoValor()
        Dim objfrm As frmStbMantCatalogo
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbMantCatalogo", Me) Then
                objfrm = New frmStbMantCatalogo
                objfrm.Width = Me.Width - Me.OutBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Parametros
    '----------------------------------------------------------------------------------
    Private Sub CargarParametros()
        Dim objfrm As frmStbMantParametro
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbMantParametro", Me) Then
                objfrm = New frmStbMantParametro
                objfrm.Width = Me.Width - Me.OutBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Cargar Marcas"

    Private Sub CargarMarcas()
        Dim objfrm As frmSivMarcas
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSivMarcas", Me) Then
                objfrm = New frmSivMarcas
                objfrm.Width = Me.Width - Me.OutBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Bodegas"

    Private Sub CargarBodegas()
        Dim objfrm As frmStbBodegas
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbBodegas", Me) Then
                objfrm = New frmStbBodegas
                objfrm.Width = Me.Width - Me.OutBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Categorias"

    Private Sub CargarCategorias()
        Dim objfrm As frmSivCategorias
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSivCategorias", Me) Then
                objfrm = New frmSivCategorias
                objfrm.Width = Me.Width - Me.OutBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Rutas"

    Private Sub CargarRutas()
        Dim objfrm As frmStbRutas
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbRutas", Me) Then
                objfrm = New frmStbRutas
                objfrm.Width = Me.Width - Me.OutBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Catálogo de Clientes"
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de Clientes
    '----------------------------------------------------------------------------------
    Private Sub CargarClientes()
        Dim objClientes As frmSccClientes
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSccClientes", Me) Then
                objClientes = New frmSccClientes
                objClientes.Width = Me.Width - Me.OutBarPrincipal.Width
                objClientes.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objClientes.MdiParent = Me
                objClientes.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Catálogo de Tiendas"
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Sergio Ordoñez
    '-- Fecha de Elaboración    :   25 de Febrero de 2009
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de tiendas
    '----------------------------------------------------------------------------------
    Private Sub CargarTiendas()
        Dim objTiendas As frmStbTiendas
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbTiendas", Me) Then
                objTiendas = New frmStbTiendas
                objTiendas.Width = Me.Width - Me.OutBarPrincipal.Width
                objTiendas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objTiendas.MdiParent = Me
                objTiendas.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Catálogo de Productos"

    '-- Descripcion             :   Cargar la pantalla principal de catálogo de productos
    '----------------------------------------------------------------------------------
    Private Sub CargarProductos()
        Dim objProductos As frmSivProductos
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSivProductos", Me) Then
                objProductos = New frmSivProductos
                objProductos.Width = Me.Width - Me.OutBarPrincipal.Width
                objProductos.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objProductos.MdiParent = Me
                objProductos.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Catálogo de Proveedores"
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Gelmin Martínez
    '-- Fecha de Elaboración    :   12 de Mayo de 2010, 06:41 PM.
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de Proveedores
    '----------------------------------------------------------------------------------
    Private Sub CargarProveedores()
        Dim objProveedor As frmSivProveedor
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSivProveedor", Me) Then
                objProveedor = New frmSivProveedor
                With objProveedor
                    .Width = Me.Width - Me.OutBarPrincipal.Width
                    .Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    .MdiParent = Me
                    .Show()
                End With
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Catálogo de Repuestos"
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Gelmin Martínez
    '-- Fecha de Elaboración    :   24 de Junio de 2010, 12:13 PM.
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de Repuestos
    '----------------------------------------------------------------------------------
    Private Sub CargarRepuestos()
        Dim objForm As frmSivRepuestos
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario(frmSivRepuestos.Name, Me) Then
                objForm = New frmSivRepuestos
                With objForm
                    .Width = Me.Width - Me.OutBarPrincipal.Width
                    .Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    .MdiParent = Me
                    .Show()
                End With
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar de Tasas de Cambio"
    '---------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Pedro Pablo Tinoco Salgado
    '-- Fecha de Elaboración    :   13 de Marzo de 2009.
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de Tasas de Cambio.
    '---------------------------------------------------------------------------------------------
    Private Sub CargarTasaCambio()
        Dim objTasaCambio As frmStbMantTasaCambioOficial
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmStbMantTasaCambioOficial", Me) Then
                    objTasaCambio = New frmStbMantTasaCambioOficial
                    objTasaCambio.Width = Me.Width - Me.OutBarPrincipal.Width
                    objTasaCambio.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objTasaCambio.MdiParent = Me
                    objTasaCambio.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Cargar de empleados"
    '---------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Sergio Ordoñez
    '-- Fecha de Elaboración    :   14 de Marzo de 2009.
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de empleados.
    '---------------------------------------------------------------------------------------------
    Private Sub CargarEmpleados()
        Dim objEmpleados As frmSrhEmpleado
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSrhEmpleado", Me) Then
                    objEmpleados = New frmSrhEmpleado
                    objEmpleados.Width = Me.Width - Me.OutBarPrincipal.Width
                    objEmpleados.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objEmpleados.MdiParent = Me
                    objEmpleados.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Cargar Facturas"
    'Private Sub CargarFacturas()
    '    Dim objFactura As frmSfaFactura
    '    Try
    '        Try

    '            Me.Cursor = Cursors.WaitCursor
    '            If Not clsProyecto.MostrarFormulario("frmSfaFactura", Me) Then
    '                objFactura = New frmSfaFactura
    '                objFactura.Width = Me.Width - Me.OutBarPrincipal.Width
    '                objFactura.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
    '                objFactura.MdiParent = Me
    '                objFactura.Show()
    '            End If
    '        Catch ex As Exception
    '            clsError.CaptarError(ex)
    '        End Try
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub

    Private Sub cmdFactura_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdFactura.Click
        'Call CargarFacturas()
    End Sub
#End Region

#Region "Cargar Cuentas"
    Private Sub CargarCuentas()
        Dim objCuentas As frmSccCuentas
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccCuentas", Me) Then
                    objCuentas = New frmSccCuentas
                    objCuentas.Width = Me.Width - Me.OutBarPrincipal.Width
                    objCuentas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objCuentas.MdiParent = Me
                    objCuentas.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdExpedientes_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdExpedientes.Click
        Call Me.CargarCuentas()
    End Sub
#End Region

#Region "Cargar Configuracion de Descuentos"

    Private Sub CargarDescuentos()
        Dim objfrm As frmSccDescuento
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSccDescuento", Me) Then
                objfrm = New frmSccDescuento
                objfrm.Width = Me.Width - Me.OutBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Recibos de Caja"
    Private Sub CargarRecibosCaja()
        Dim objReciboCaja As frmSccReciboCaja
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccReciboCaja", Me) Then
                    objReciboCaja = New frmSccReciboCaja
                    objReciboCaja.Width = Me.Width - Me.OutBarPrincipal.Width
                    objReciboCaja.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objReciboCaja.MdiParent = Me
                    objReciboCaja.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdReciboCaja_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdReciboCaja.Click
        Call Me.CargarRecibosCaja()
    End Sub
#End Region

#Region "Cargar Tramite Legal"
    Private Sub CargarTramiteLegal()
        Dim objTramite As frmSccTramiteLegal
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccTramiteLegal", Me) Then
                    objTramite = New frmSccTramiteLegal
                    objTramite.Width = Me.Width - Me.OutBarPrincipal.Width
                    objTramite.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objTramite.MdiParent = Me
                    objTramite.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdTramiteLegal_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdTramiteLegal.Click
        Call CargarTramiteLegal()
    End Sub

#End Region

#Region "Cargar Solicitud de transferencia"
    Private Sub CargarSolicitudTransferencia()
        Dim objTrans As frmSivSoliTransferencia
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivSoliTransferencia.Name, Me) Then
                    objTrans = New frmSivSoliTransferencia
                    objTrans.Width = Me.Width - Me.OutBarPrincipal.Width
                    objTrans.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objTrans.MdiParent = Me
                    objTrans.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Despacho de transferencia"
    Private Sub CargarDespachoTransferencia()
        Dim objTrans As New frmSivDespTransferencia
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivDespTransferencia.Name, Me) Then
                    objTrans.Width = Me.Width - Me.OutBarPrincipal.Width
                    objTrans.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objTrans.MdiParent = Me
                    objTrans.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar recepcion de transferencia"
    Private Sub CargarRecepcionTransferencia()
        Dim objTrans As New frmSivRecepTransferencia
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivRecepTransferencia.Name, Me) Then
                    objTrans.Width = Me.Width - Me.OutBarPrincipal.Width
                    objTrans.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objTrans.MdiParent = Me
                    objTrans.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Promociones"
    'Private Sub CargarPromociones()
    '    Dim objPromociones As New frmSfaPromociones
    '    Try
    '        Try
    '            Me.Cursor = Cursors.WaitCursor
    '            If Not clsProyecto.MostrarFormulario(frmSfaPromociones.Name, Me) Then
    '                objPromociones.Width = Me.Width - Me.OutBarPrincipal.Width
    '                objPromociones.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
    '                objPromociones.MdiParent = Me
    '                objPromociones.Show()
    '            End If
    '        Catch ex As Exception
    '            clsError.CaptarError(ex)
    '        End Try
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub
#End Region

#Region "Cargar Salida Bodega"
    Private Sub CargarSalidaBodega()
        Dim objForm As New frmSivSalidaBodega
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivSalidaBodega.Name, Me) Then
                    objForm.Width = Me.Width - Me.OutBarPrincipal.Width
                    objForm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objForm.MdiParent = Me
                    objForm.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Entrada Bodega"
    Private Sub CargarEntradaBodega()
        Dim objForm As New frmSivEntradaBodega
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivEntradaBodega.Name, Me) Then
                    objForm.Width = Me.Width - Me.OutBarPrincipal.Width
                    objForm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objForm.MdiParent = Me
                    objForm.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Cotizaciones"
    'Private Sub CargarCotizaciones()
    '    Dim objForm As New frmSfaCotizacion
    '    Try
    '        Try
    '            Me.Cursor = Cursors.WaitCursor
    '            If Not clsProyecto.MostrarFormulario(frmSfaCotizacion.Name, Me) Then
    '                objForm.Width = Me.Width - Me.OutBarPrincipal.Width
    '                objForm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
    '                objForm.MdiParent = Me
    '                objForm.Show()
    '            End If
    '        Catch ex As Exception
    '            clsError.CaptarError(ex)
    '        End Try
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub
#End Region

#Region "Cargar Facturas Repuestos"
    Private Sub CargarFacturasRepuestos()
        Dim objForm As New frmSfaFacturaRepuestos
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSfaFacturaRepuestos.Name, Me) Then
                    objForm.Width = Me.Width - Me.OutBarPrincipal.Width
                    objForm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objForm.MdiParent = Me
                    objForm.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Ordenes de Compra"
    'Private Sub CargarOrdenesCompra()
    '    Dim objForm As New frmSfaOrdenesCompra
    '    Try
    '        Try
    '            Me.Cursor = Cursors.WaitCursor
    '            If Not clsProyecto.MostrarFormulario(frmSfaOrdenesCompra.Name, Me) Then
    '                objForm.Width = Me.Width - Me.OutBarPrincipal.Width
    '                objForm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
    '                objForm.MdiParent = Me
    '                objForm.Show()
    '            End If
    '        Catch ex As Exception
    '            clsError.CaptarError(ex)
    '        End Try
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub
#End Region

#Region "Cargar Servicio Taller"
    Private Sub CargarServicioTaller()
        Dim objForm As New frmStaServicioTaller
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmStaServicioTaller.Name, Me) Then
                    objForm.Width = Me.Width - Me.OutBarPrincipal.Width
                    objForm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objForm.MdiParent = Me
                    objForm.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Solicitudes Repuestos por Garantía"
    Private Function CargarSolicitudesRepuestosGarantía() As Boolean
        Dim strSQL, strFiltro As String
        Dim intContador As Integer
        Try
            strFiltro = " 1=1 "
            strSQL = clsConsultas.ObtenerConsultaGeneral("Count(SivSalidaBodegaID) as Contador", "vwStaServicioTallerAlertaSolicitudRepuesto", strFiltro)

            intContador = SqlHelper.ExecuteQueryDT(strSQL).DefaultView.Item(0)("Contador")
        Catch ex As Exception
            intContador = 0
        End Try

        If intContador <> 0 Then
            Dim frmAlerta As New frmAlertaSolicitudRepuesto
            Try
                '-- Instanciar
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmAlertaSolicitudDescuento.Name, Me) Then
                    frmAlerta.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#End Region

#Region "Procedimiento para Cargar REPORTES"
    ''' <summary>
    ''' Procedimiento encargado de Presentar la pantalla correspondiente de Reportes.
    ''' </summary>
    ''' <param name="Reporte"></param>
    ''' <remarks></remarks>
    Public Sub Reportes(ByVal Reporte As String)
        Dim objReportes As New frmStbVisor
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                objReportes.IDReporte = Reporte
                objReportes.Width = Me.Width - Me.OutBarPrincipal.Width
                objReportes.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objReportes.MdiParent = Me
                objReportes.Show()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default

        End Try

    End Sub
#End Region

#Region "Reportes"

    Private Sub cmdRptVencCuotas_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptVencCuotas.Click
        Call Me.Reportes("CuotasVencidas")
    End Sub

    Private Sub cmdEstadoCrediticio_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdEstadoCrediticio.Click
        Call Me.Reportes("EstadoCrediticio")
    End Sub

    Private Sub cmdRptDevoluciones_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptDevoluciones.Click
        Call Me.Reportes("Devoluciones")
    End Sub

    Private Sub cmdRptSeguimiento_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptSeguimiento.Click
        Call Me.Reportes("Seguimiento")
    End Sub

    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdEstadoCuenta.Click
        Call Me.Reportes("EstadoCuenta")
    End Sub

    Private Sub RptMorosidad_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles RptMorosidad.Click
        Call Me.Reportes("Morosidad")
    End Sub

    Private Sub cmdPorcentajeMorosidad_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdPorcentajeMorosidad.Click
        Call Me.Reportes("PorcentajeMorosidad")
    End Sub

    Private Sub cmdSaldoConsolidado_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdSaldoConsolidado.Click
        Call Me.Reportes("SaldoConsolidado")
    End Sub
    Private Sub cmdRptCarteraRangos_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptCarteraRangos.Click
        Me.Reportes("CarteraXRangos")
    End Sub

    Private Sub cmdRptHistorialClientes_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptHistorialClientes.Click
        Call Me.Reportes("HistorialClientes")
    End Sub

    Private Sub cmdRptRecuperacionComparativo_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptRecuperacionComparativo.Click
        Call Me.Reportes("RecuperacionComparativo")
    End Sub

#End Region

#Region "Reportes Inventario"
    'Entrada
    Private Sub cmdRptEntrada_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptEntrada.Click
        Dim objReporte As frmSivRptEntradas
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivRptEntradas.Name, Me) Then
                    objReporte = New frmSivRptEntradas
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
            objReporte = Nothing
        End Try
    End Sub

    'Salida
    Private Sub cmdRptSalidas_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptSalidas.Click
        Dim objReporte As frmSivRptSalida
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivRptSalida.Name, Me) Then
                    objReporte = New frmSivRptSalida
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
            objReporte = Nothing
        End Try
    End Sub

    'Solicitudes de transferencia
    Private Sub cmdRptSolicitudesTransf_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptSolicitudesTransf.Click
        'Procedimiento que imprime varias solicitudes de acuerdo al filtro seleccionado por el usuario
        Dim objParamReporte As New frmReportesTransferencias
        objParamReporte.FormLlamado = frmSivSoliTransferencia.Name
        objParamReporte.ShowDialog()
    End Sub

    'Despachos de transferencia
    Private Sub cmdRptDespachoTransf_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptDespachoTransf.Click
        'Procedimiento que imprime varios despachos de acuerdo al filtro seleccionado por el usuario
        Dim objParamReporte As New frmReportesTransferencias
        objParamReporte.FormLlamado = frmSivDespTransferencia.Name
        objParamReporte.ShowDialog()
    End Sub

    'Recepciones de transferencia
    Private Sub cmdRptRecepcionesTransf_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptRecepcionesTransf.Click
        'Procedimiento que imprime varias recepciones de acuerdo al filtro seleccionado por el usuario
        Dim objParamReporte As New frmReportesTransferencias
        objParamReporte.FormLlamado = frmSivRecepTransferencia.Name
        objParamReporte.ShowDialog()
    End Sub

    'Diferencias entre solicitudes y recepcciones.
    Private Sub cmdRptDiferenciasTransf_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptDiferenciasTransf.Click
        'Procedimiento que imprime varias recepciones de acuerdo al filtro seleccionado por el usuario
        Dim objParamReporte As New frmReportesTransferencias
        objParamReporte.FormLlamado = frmSivRecepTransferencia.Name + "1"
        objParamReporte.ShowDialog()
    End Sub

    'Inventario
    Private Sub cmdRptInventario_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptInventario.Click
        Dim objReporte As frmCriteriosInventarioReporte
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmCriteriosInventarioReporte", Me) Then
                    objReporte = New frmCriteriosInventarioReporte
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Kardex
    Private Sub cmdRptKardex_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptKardex.Click
        Dim objReporte As frmCriteriosReporteKardex
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmCriteriosReporteKardex.Name, Me) Then
                    objReporte = New frmCriteriosReporteKardex
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Reportes Facturación"
    'Listado de precios
    Private Sub cmdRptListadoPrecios_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptListadoPrecios.Click
        Dim objReporte As frmCriteriosReporteListadoPrecios
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmCriteriosReporteListadoPrecios", Me) Then
                    objReporte = New frmCriteriosReporteListadoPrecios
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Cotizaciones
    Private Sub cmdRptCotizaciones_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptCotizaciones.Click
        Dim objReporte As frmCriteriosReporteCotizaciones
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmCriteriosReporteCotizaciones.Name, Me) Then
                    objReporte = New frmCriteriosReporteCotizaciones
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Facturación
    Private Sub cmdRptFacturacion_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptFacturacion.Click
        Dim objReporte As frmSfaReporteFacturas
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSfaReporteFacturas.Name, Me) Then
                    objReporte = New frmSfaReporteFacturas
                    objReporte.Text = "Reporte de Ventas"
                    objReporte.TipoReporte = "VENTAS"
                    objReporte.rbCredito.Text = "Ventas Crédito"
                    objReporte.rbFacturaContado.Text = "Ventas Contado"
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Repuestos facturados
    Private Sub cmdRptRepuestosFacturados_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptRepuestosFacturados.Click
        Dim objReporte As frmSfaRptFacturaRepuestos
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSfaRptFacturaRepuestos.Name, Me) Then
                    objReporte = New frmSfaRptFacturaRepuestos
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Promociones
    Private Sub cmdRptPromociones_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptPromociones.Click
        'Dim frmCriteriosReporte As New frmReportesPromociones
        'frmCriteriosReporte.ShowDialog()
    End Sub

    'Utilidades
    Private Sub cmdRptUtilidades_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptUtilidades.Click
        Dim objReporte As frmCriteriosReporteUtilidades
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmCriteriosReporteUtilidades.Name, Me) Then
                    objReporte = New frmCriteriosReporteUtilidades
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Comiciones
    Private Sub cmdRptComiciones_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptComiciones.Click
        Dim objReporte As frmCriteriosReporteComisiones
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmCriteriosReporteComisiones.Name, Me) Then
                    objReporte = New frmCriteriosReporteComisiones
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Reportes de taller"
    'Estadístico de servicios de taller.
    Private Sub cmdRptEstadisticoServicios_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRptEstadisticoServicios.Click
        Dim objReporte As frmCriterioReporteEstadisticoServicios
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmCriterioReporteEstadisticoServicios.Name, Me) Then
                    objReporte = New frmCriterioReporteEstadisticoServicios
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Bitácora de Motocicleta
    Private Sub cmdReporteBitacoraMoto_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdReporteBitacoraMoto.Click
        Dim objReporte As frmCriteriosReporteBitacoraMoto
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmCriteriosReporteBitacoraMoto.Name, Me) Then
                    objReporte = New frmCriteriosReporteBitacoraMoto
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Eventos"
    Private Sub brCatalogos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brCatalogos.Click
        Me.OutBarPrincipal.Refresh()
        Me.OutBarPrincipal.PerformLayout()
    End Sub

    Private Sub brCartera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brCartera.Click
        Me.OutBarPrincipal.Refresh()
        Me.OutBarPrincipal.PerformLayout()
    End Sub

    Private Sub outReportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles outReportes.Click
        Me.OutBarPrincipal.Refresh()
        Me.OutBarPrincipal.PerformLayout()
    End Sub

    Private Sub outBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles outBitacora.Click
        Me.OutBarPrincipal.Refresh()
        Me.OutBarPrincipal.PerformLayout()
    End Sub

    Private Sub OutBarPrincipal_Layout(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles OutBarPrincipal.Layout
        Me.OutBarPrincipal.Refresh()
        Me.OutBarPrincipal.PerformLayout()
        Me.OutBarPrincipal.Update()
    End Sub

#End Region

#Region "Liberar Memoria"
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

    Public Sub ClearMemory()
        Try
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)
        Catch ex As Exception
            'Control de errores
        End Try
    End Sub
#End Region


   
   
 
 
End Class
