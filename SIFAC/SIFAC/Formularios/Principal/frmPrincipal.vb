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
            Me.InicializarPropiedades()
            Me.IniciarSesion()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Metodos de Configuraci�n"
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
                Select Case MsgBox("Todas las ventanas activas se cerrar�n. �Desea cerrar sesi�n?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
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
                Me.navBarCatalogos.Enabled = True
            Else
                Me.navBarCatalogos.Enabled = False
            End If

            'Cat�logos
            Me.NavBarClientes.Enabled = objSeg.TienePermiso("OpcionPersonas")
            Me.NavBarBodegas.Enabled = objSeg.TienePermiso("OpcionBodegas")
            Me.NavProductos.Enabled = objSeg.TienePermiso("OpcionProducto")
            Me.NavBarEmpleados.Enabled = objSeg.TienePermiso("OpcionEmpleado")
            Me.NavBarParametros.Enabled = objSeg.TienePermiso("OpcionParametros")
            Me.NavBarProveedor.Enabled = objSeg.TienePermiso("OpcionProveedor")
            Me.NavBarMarcas.Enabled = objSeg.TienePermiso("OpcionMarcas")
            Me.NavBarCategorias.Enabled = objSeg.TienePermiso("OpcionCategorias")
            Me.NavBarRutas.Enabled = objSeg.TienePermiso("OpcionRutas")

            'Cartera y Cobro
            Me.navBarFacturacion.Enabled = objSeg.TienePermiso("OpcionFacturaExpediente")
            Me.NavBarDescuentos.Enabled = objSeg.TienePermiso("OpcionDescuentos")
            Me.NavBarCuentas.Enabled = objSeg.TienePermiso("OpcionCuentaXCobrar")
            Me.NavBarFacturasXCuenta.Enabled = objSeg.TienePermiso("OpcionFacturasXCuentas")
            Me.NavBarReciboCaja.Enabled = objSeg.TienePermiso("OpcionReciboCaja")
            Me.NavBarDevoluciones.Enabled = objSeg.TienePermiso("OpcionDevoluciones")



            'Inventario
            Me.NavBarSolicitud.Enabled = objSeg.TienePermiso("OpcionSolicitudTransf") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.NavBarDespacho.Enabled = objSeg.TienePermiso("OpcionDespacharTransf") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.NavBarRecepcion.Enabled = objSeg.TienePermiso("OpcionRecibirTransf") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.NavBarSalidas.Enabled = objSeg.TienePermiso("OpcionSalidaBodega") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.NavBarEntrada.Enabled = objSeg.TienePermiso("OpcionEntradaBodega") Or objSeg.TienePermiso("AUTORIZACIONGERENTE")
            Me.NavBarOrdenCompra.Enabled = objSeg.TienePermiso("OpcionEncargos")

            'Facturaci�n
            Me.navBarFacturacion.Enabled = objSeg.TienePermiso("OpcionFacturas")

            ''Sincronizar
            Me.NavBarSincroVentas.Enabled = objSeg.TienePermiso("OpcionSincVentas")
            Me.NavBarSincroAbonos.Enabled = objSeg.TienePermiso("OpcionSincAbonos")
            Me.NavBarSincroDevoluciones.Enabled = objSeg.TienePermiso("OpcionSincDevoluciones")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub DeshabilitarOpciones()
        Try
            'Me.cmdSeguridad.Enabled = False

            '-- Barra de Menus

            ''-- Barra Lateral
            '-- Cat�logos
            Me.navBarCatalogos.Enabled = False
            Me.NavBarClientes.Enabled = False
            Me.NavBarBodegas.Enabled = False
            Me.NavProductos.Enabled = False
            Me.NavBarCategorias.Enabled = False
            Me.NavBarParametros.Enabled = False
            Me.NavBarMarcas.Enabled = False
            Me.NavBarEmpleados.Enabled = False

          
            'Inventario
            Me.NavBarSolicitud.Enabled = False
            Me.NavBarDespacho.Enabled = False
            Me.NavBarRecepcion.Enabled = False
            Me.NavBarSalidas.Enabled = False
            Me.NavBarEntrada.Enabled = False


            'Facturaci�n
            Me.navBarFacturacion.Enabled = False
            Me.NavBarDescuentos.Enabled = False

            'Cuentas  por cobrar
            Me.NavBarCuentas.Enabled = False
            Me.NavBarFacturasXCuenta.Enabled = False
            Me.NavBarReciboCaja.Enabled = False
            Me.NavBarDevoluciones.Enabled = False


            ''Sincronizar
            Me.NavBarSincroVentas.Enabled = False
            Me.NavBarSincroAbonos.Enabled = False
            Me.NavBarSincroDevoluciones.Enabled = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Opciones del Menu Principal"

#Region "Catalogos Generales"

    Private Sub navBarCatalogos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarCatalogos.LinkClicked
        Me.CargarCatalogoValor()
    End Sub


    Private Sub NavBarParametros_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarParametros.LinkClicked
        CargarParametros()
    End Sub

    Private Sub NavBarCategorias_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCategorias.LinkClicked
        CargarCategorias()
    End Sub

    Private Sub NavBarMarcas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarMarcas.LinkClicked
        CargarMarcas()
    End Sub

    Private Sub NavBarBodegas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarBodegas.LinkClicked
        CargarBodegas()
    End Sub

    Private Sub NavProductos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavProductos.LinkClicked
        CargarProductos()

    End Sub

    Private Sub NavBarRutas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarRutas.LinkClicked
        CargarRutas()
    End Sub

    Private Sub NavBarEmpleados_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEmpleados.LinkClicked
        CargarEmpleados()
    End Sub

    Private Sub NavBarClientes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarClientes.LinkClicked
        CargarClientes()
    End Sub


    Private Sub NavBarProveedor_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarProveedor.LinkClicked
        CargarProveedores()
    End Sub

    Private Sub NavBarDescuentos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarDescuentos.LinkClicked
        CargarDescuentos()
    End Sub

    Private Sub navBarFacturacion_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarFacturacion.LinkClicked
        CargarFacturasRepuestos()
    End Sub

    Private Sub NavBarCuentas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCuentas.LinkClicked
        CargarCuentas()
    End Sub
#End Region

#Region "Inventario"

    Private Sub NavBarOrdenCompra_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarOrdenCompra.LinkClicked
        CargarPedidos()
    End Sub

    Private Sub NavBarEntrada_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEntrada.LinkClicked
        CargarEntradaBodega()
    End Sub

    Private Sub NavBarSalidas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSalidas.LinkClicked
        CargarSalidaBodega()
    End Sub

    Private Sub NavBarSolicitud_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSolicitud.LinkClicked
        CargarSolicitudTransferencia()
    End Sub

    Private Sub NavBarDespacho_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarDespacho.LinkClicked
        CargarDespachoTransferencia()
    End Sub

    Private Sub NavBarRecepcion_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarRecepcion.LinkClicked
        CargarRecepcionTransferencia()
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
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
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
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
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
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
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
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
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
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
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
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Cat�logo de Clientes"
    '-- Descripcion             :   Cargar la pantalla principal de cat�logo de Clientes
    '----------------------------------------------------------------------------------
    Private Sub CargarClientes()
        Dim objClientes As frmSccClientes
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSccClientes", Me) Then
                objClientes = New frmSccClientes
                objClientes.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Cat�logo de Productos"

    '-- Descripcion             :   Cargar la pantalla principal de cat�logo de productos
    '----------------------------------------------------------------------------------
    Private Sub CargarProductos()
        Dim objProductos As frmSivProductos
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSivProductos", Me) Then
                objProductos = New frmSivProductos
                objProductos.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Cat�logo de Proveedores"
    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de cat�logo de Proveedores
    '----------------------------------------------------------------------------------
    Private Sub CargarProveedores()
        Dim objProveedor As frmSivProveedor
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSivProveedor", Me) Then
                objProveedor = New frmSivProveedor
                With objProveedor
                    .Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar de empleados"
    '---------------------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de cat�logo de empleados.
    '---------------------------------------------------------------------------------------------
    Private Sub CargarEmpleados()
        Dim objEmpleados As frmSrhEmpleado
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSrhEmpleado", Me) Then
                    objEmpleados = New frmSrhEmpleado
                    objEmpleados.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Cuentas"
    Private Sub CargarCuentas()
        Dim objCuentas As frmSccCuentas
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccCuentas", Me) Then
                    objCuentas = New frmSccCuentas
                    objCuentas.Width = Me.Width - Me.NavBarPrincipal.Width
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
#End Region

#Region "Cargar Facturas"
    Private Sub CargarFacturas()
        Dim objFactura As frmSfaFactura
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSfaFactura", Me) Then
                    objFactura = New frmSfaFactura
                    objFactura.Width = Me.Width - Me.NavBarPrincipal.Width
                    objFactura.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objFactura.MdiParent = Me
                    objFactura.Show()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

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
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
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
                    objReciboCaja.Width = Me.Width - Me.NavBarPrincipal.Width
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

#End Region

#Region "Carga Devoluciones"
    Private Sub CargarDevoluciones()
        Dim objDevolucion As New frmSccDevoluciones
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccDevoluciones", Me) Then
                    objDevolucion = New frmSccDevoluciones
                    objDevolucion.Width = Me.Width - Me.NavBarPrincipal.Width
                    objDevolucion.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objDevolucion.MdiParent = Me
                    objDevolucion.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
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
                    objTrans.Width = Me.Width - Me.NavBarPrincipal.Width
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
                    objTrans.Width = Me.Width - Me.NavBarPrincipal.Width
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
                    objTrans.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Salida Bodega"
    Private Sub CargarSalidaBodega()
        Dim objForm As New frmSivSalidaBodega
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivSalidaBodega.Name, Me) Then
                    objForm.Width = Me.Width - Me.NavBarPrincipal.Width
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
                    objForm.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Encargos"
    Private Sub CargarEncargos()
        Dim objForm As New frmSivEncargos
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSivEncargos.Name, Me) Then
                    objForm.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Pedidos"
    Private Sub CargarPedidos()
        Dim objForm As New frmPedidos
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmPedidos.Name, Me) Then
                    objForm.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Sincronizar Ventas"
    Private Sub CargarSincronizarVentas()
        Dim objForm As New frmSincronizarVentas
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSincronizarVentas.Name, Me) Then
                    objForm.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Sincronizar Ventas"
    Private Sub CargarSincronizarAbonos()
        Dim objForm As New frmSincronizarAbonos
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSincronizarAbonos.Name, Me) Then
                    objForm.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Cargar Sincronizar Devoluciones"
    Private Sub CargarSincronizarDevoluciones()
        Dim objForm As New frmSincronizarDevoluciones
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSincronizarDevoluciones.Name, Me) Then
                    objForm.Width = Me.Width - Me.NavBarPrincipal.Width
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


#Region "Cargar Facturas Repuestos"
    Private Sub CargarFacturasRepuestos()
        Dim objForm As New frmSfaFacturaRepuestos
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario(frmSfaFacturaRepuestos.Name, Me) Then
                    objForm.Width = Me.Width - Me.NavBarPrincipal.Width
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
                objReportes.Width = Me.Width - Me.NavBarPrincipal.Width
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

#Region "Eventos"


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


    Private Sub NavBarEncargos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEncargos.LinkClicked
        CargarEncargos()
    End Sub

    Private Sub NavBarSincroVentas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSincroVentas.LinkClicked
        CargarSincronizarVentas()
    End Sub

    Private Sub NavBarFacturasXCuenta_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarFacturasXCuenta.LinkClicked
        CargarFacturas()
    End Sub

    Private Sub NavBarReciboCaja_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarReciboCaja.LinkClicked
        CargarRecibosCaja()
    End Sub

    Private Sub NavBarDevoluciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarDevoluciones.LinkClicked
        CargarDevoluciones()
    End Sub

    Private Sub NavBarSincroAbonos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSincroAbonos.LinkClicked
        CargarSincronizarAbonos()
    End Sub

    Private Sub NavBarSincroDevoluciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSincroDevoluciones.LinkClicked
        CargarSincronizarDevoluciones()
    End Sub
End Class
