Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports SCCUM.BO.clsConsultas
Imports SCCUM.BO
Imports Proyecto.Catalogos.Datos

''' <summary>
''' Formulario Principal de Mantenimiento de Ordenes de compra
''' Autor : Gelmín Martínez
''' Fecha :09 de Julio de 2010, 10:24 am.
''' </summary>
Public Class frmSfaOrdenesCompra
    'Variables globales
    Public glb_EstadoFacturaRegistradaID As Integer
    Public glb_EstadoFacturaAnuladaID As Integer
    Public glb_EstadoFacturaProcesadaID As Integer
    Public Shared glb_SucursalSessionID As Integer
    Public Shared glb_SucursalCentralID As Integer

#Region "Atributos"
    Dim dtFactura, dtDetalleFactura As DataTable
    Dim objseg As SsgSeguridad
    Dim dsFactura As DataSet
    Dim dblTasaCambio As Double
    Dim boolAgregar, boolProcesar, boolConsultar, boolAnular, boolImprimir, boolBuscar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
    Dim m_strmarca, m_strmodelo, m_strcolor, m_strchasis, m_strano As String
    Dim m_strmotor, m_strcilindraje, m_strcilindros, m_strtipo As String
    Dim m_strcombustible, m_strvelocidades, m_strpasajeros, m_strpoliza As String
#End Region

#Region "Propiedades"
    Property strMarca() As String
        Get
            Return m_strmarca
        End Get
        Set(ByVal value As String)
            m_strmarca = value
        End Set
    End Property

    Property strModelo() As String
        Get
            Return m_strmodelo
        End Get
        Set(ByVal value As String)
            m_strmodelo = value
        End Set
    End Property

    Property strColor() As String
        Get
            Return m_strcolor
        End Get
        Set(ByVal value As String)
            m_strcolor = value
        End Set
    End Property

    Property strChasis() As String
        Get
            Return m_strchasis
        End Get
        Set(ByVal value As String)
            m_strchasis = value
        End Set
    End Property

    Property strAno() As String
        Get
            Return m_strano
        End Get
        Set(ByVal value As String)
            m_strano = value
        End Set
    End Property

    Property strMotor() As String
        Get
            Return m_strmotor
        End Get
        Set(ByVal value As String)
            m_strmotor = value
        End Set
    End Property

    Property strCilindraje() As String
        Get
            Return m_strcilindraje
        End Get
        Set(ByVal value As String)
            m_strcilindraje = value
        End Set
    End Property

    Property strCilindros() As String
        Get
            Return m_strcilindros
        End Get
        Set(ByVal value As String)
            m_strcilindros = value
        End Set
    End Property

    Property strTipo() As String
        Get
            Return m_strtipo
        End Get
        Set(ByVal value As String)
            m_strtipo = value
        End Set
    End Property

    Property strCombustible() As String
        Get
            Return m_strcombustible
        End Get
        Set(ByVal value As String)
            m_strcombustible = value
        End Set
    End Property

    Property strVelocidades() As String
        Get
            Return m_strvelocidades
        End Get
        Set(ByVal value As String)
            m_strvelocidades = value
        End Set
    End Property

    Property strPasajeros() As String
        Get
            Return m_strpasajeros
        End Get
        Set(ByVal value As String)
            m_strpasajeros = value
        End Set
    End Property

    Property strPoliza() As String
        Get
            Return m_strpoliza
        End Get
        Set(ByVal value As String)
            m_strpoliza = value
        End Set
    End Property
#End Region

#Region "Incializar GUI"

    Private Sub CargarFacturas(ByVal strFiltro As String)
        Try
            dtFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SfaFacturaRepuestoID, TotalDolares, SolicAutorDescuento, SolicitudDescuento, AutorizaDescuento, Fecha, Estado, Vendedor, Cliente, Anulada,  dbo.fnRellenarCeros2(OrdenCompra, dbo.FnGetParametro('CantidadCerosOrdenCompra')) as OrdenCompra, objEstadoID, objClienteID, objTiendaID", "dbo.vwSfaOrdenCompraMaster", strFiltro & " ORDER BY OrdenCompra DESC"), Me.SqlParametros)
            dtDetalleFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objFacturaRepuestoID, objRepuestoID, Cantidad, Precio, Subtotal, Descuento, Impuesto, Total, DescripcionMoto, DescripcionCorta, Fecha, objTiendaID, objClienteID, OrdenCompra", "vwSfaOrdenCompraDetalle", strFiltro & " ORDER BY objFacturaRepuestoID DESC"), Me.SqlParametros)

            dsFactura = New DataSet

            dsFactura.Merge(dtFactura)
            dsFactura.Tables(0).TableName = "SfaFactura"

            dsFactura.Merge(dtDetalleFactura)
            dsFactura.Tables(1).TableName = "SfaFacturaDetalle"

            dsFactura.Relations.Add("SfaFactura_SfaFacturaDetalle", dsFactura.Tables(0).Columns("SfaFacturaRepuestoID"), dsFactura.Tables(1).Columns("objFacturaRepuestoID"))
            Me.grdFacturaMaster.SetDataBinding(dsFactura, "SfaFactura", True)

            dsFactura.Tables("SfaFactura").PrimaryKey = New DataColumn() {dsFactura.Tables("SfaFactura").Columns("SfaFacturaRepuestoID")}
            dsFactura.Tables("SfaFactura").DefaultView.Sort = "SfaFacturaRepuestoID"

            Me.grdFacturaDetalle.SetDataBinding(dsFactura, "SfaFactura.SfaFactura_SfaFacturaDetalle", True)
            Me.grdFacturaMaster.Caption = "Factura (" & Me.grdFacturaMaster.RowCount & ")"
            Me.grdFacturaMaster.Splits(0).DisplayColumns(9).Visible = False
            Me.grdFacturaMaster.Splits(0).DisplayColumns(10).Visible = False

            If Me.dtFactura.Rows.Count = 0 Then
                Me.cmdProcesar.Enabled = False
                Me.cmdAnular.Enabled = False
                Me.cmdConsultar.Enabled = False
                Me.cmdImprimir.Enabled = False
            Else
                Me.cmdAgregar.Enabled = Me.boolAgregar
                Me.cmdConsultar.Enabled = Me.boolConsultar
                Me.cmdImprimir.Enabled = Me.boolImprimir
                'Verificar estado de orden de servicio para habilitar/Deshabilitar Servicio
                Me.VerificarEstadoOrdenCompra()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AplicarSeguridad()
        Try
            objseg = New SsgSeguridad

            objseg.ServicioUsuario = "FRMSFAORDENCOMPRA"
            objseg.Usuario = clsProyecto.Conexion.Usuario

            boolAgregar = objseg.TienePermiso("AGREGARORDENCOMPRA")
            boolBuscar = objseg.TienePermiso("BUSCARORDENCOMPRA")
            boolConsultar = objseg.TienePermiso("CONSULTARORDENCOMPRA")
            boolAnular = objseg.TienePermiso("ANULARORDENCOMPRA")
            boolProcesar = objseg.TienePermiso("PROCESARORDENCOMPRA")
            boolImprimir = objseg.TienePermiso("IMPRIMIRORDENCOMPRA")

            Me.cmdAgregar.Enabled = boolAgregar
            Me.cmdProcesar.Enabled = boolProcesar
            Me.cmdConsultar.Enabled = boolConsultar
            Me.cmdAnular.Enabled = boolAnular
            Me.cmdBuscar.Enabled = boolConsultar
            Me.cmdImprimir.Enabled = boolImprimir

            If Me.grdFacturaMaster.RowCount = 0 Then
                Me.cmdProcesar.Enabled = False
                Me.cmdConsultar.Enabled = False
                Me.cmdAnular.Enabled = False
                Me.cmdImprimir.Enabled = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Validar Datos"
    Private Function BoolConTasaCambio() As Boolean
        Dim objTasaCambio As New StbTasaCambioOficial
        Try
            Try
                If objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & " and Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString) Then
                    dblTasaCambio = objTasaCambio.Monto
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objTasaCambio = Nothing
        End Try
    End Function
#End Region

#Region "Operaciones"

#Region "Agregar"

    Private Sub Agregar()
        Dim AgregarFactura As FrmSfaOrdenCompraEdit
        Dim objTienda As New StbTienda
        Dim objseg As New SsgSeguridad
        Try
            Try
                objseg.Usuario = clsProyecto.Conexion.Usuario
                objseg.ServicioUsuario = "frmPrincipal"
                If BoolConTasaCambio() Then
                    If objTienda.RetrieveByFilter("StbTiendaID = " & ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal) & " AND Codigo = 'C'") Then
                        AgregarFactura = New FrmSfaOrdenCompraEdit
                        AgregarFactura.TypeGUI = 1

                        AgregarFactura.MontoTasaCambio = Me.dblTasaCambio
                        If AgregarFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                            Me.CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
                            dtFactura.DefaultView.Sort = "SfaFacturaRepuestoID"
                            Me.grdFacturaMaster.Row = Me.dtFactura.DefaultView.Find(AgregarFactura.SfaFacturaID)
                        End If
                    Else
                        MsgBox("Sucursales no puede realizar Orden de Compra, ir a Factura", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    End If
                Else
                    MsgBox("Debe ingresar la tasa de cambio del mes actual.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            AgregarFactura = Nothing
        End Try
    End Sub

    Private Sub AgregarCotizacion()
        Dim BuscarCotizacion As frmSfaBusquedaCotizacion
        Dim AgregarOC As FrmSfaOrdenCompraEdit
        Dim objTienda As New StbTienda
        Dim objseg As New SsgSeguridad
        Dim objCotizacionID As Integer
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                objseg.Usuario = clsProyecto.Conexion.Usuario
                objseg.ServicioUsuario = "frmPrincipal"

                If BoolConTasaCambio() Then
                    If glb_SucursalSessionID = glb_SucursalCentralID Then
                        BuscarCotizacion = New frmSfaBusquedaCotizacion
                        BuscarCotizacion.StrFiltroCotizaciones = "objTiendaID=" & glb_SucursalSessionID
                        If BuscarCotizacion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                            objCotizacionID = BuscarCotizacion.Seleccion
                            AgregarOC = New FrmSfaOrdenCompraEdit
                            AgregarOC.TypeGUI = 6
                            AgregarOC.SfaCotizacionID = objCotizacionID
                            If AgregarOC.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                                Me.CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
                                dtFactura.DefaultView.Sort = "SfaFacturaRepuestoID"
                                Me.grdFacturaMaster.Row = Me.dtFactura.DefaultView.Find(AgregarOC.SfaFacturaID)
                            End If
                        End If
                    Else
                        MsgBox("Sólo sucursal CENTRAL puede hacer Ordenes de compra.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    End If
                Else
                    MsgBox("Debe ingresar la tasa de cambio del mes actual.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            BuscarCotizacion = Nothing
            AgregarOC = Nothing
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Procesar"
    Private Sub Procesar()
        Dim ProcesarFactura As New FrmSfaOrdenCompraEdit
        Dim objseg As New SsgSeguridad
        Try
            Try
                objseg.Usuario = clsProyecto.Conexion.Usuario
                objseg.ServicioUsuario = "frmPrincipal"

                If objseg.TienePermiso("AUTORIZACIONGERENTE") Then
                    ProcesarFactura.TypeGUI = 3
                Else
                    ProcesarFactura.TypeGUI = 2
                End If

                ProcesarFactura.SfaFacturaID = Me.grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value
                If ProcesarFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
                    dtFactura.DefaultView.Sort = "SfaFacturaRepuestoID"
                    Me.grdFacturaMaster.Row = Me.dtFactura.DefaultView.Find(ProcesarFactura.SfaFacturaID)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ProcesarFactura = Nothing
        End Try
    End Sub
#End Region

#Region "Consultar"

    Private Sub Consultar()
        Dim FormConsultaOrden As New FrmSfaOrdenCompraEdit
        Try
            Try
                FormConsultaOrden.TypeGUI = 4
                FormConsultaOrden.SfaFacturaID = Me.grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value
                FormConsultaOrden.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            FormConsultaOrden = Nothing
        End Try
    End Sub

#End Region

#Region "Anular"

    Private Sub Anular()
        Dim AnularFactura As New FrmSfaOrdenCompraEdit
        Try
            Try
                AnularFactura.TypeGUI = 5
                AnularFactura.SfaFacturaID = Me.grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value
                AnularFactura.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            AnularFactura = Nothing
        End Try
    End Sub
#End Region

#Region "Eliminar"

    Private Sub Eliminar()
        Dim objSfaFactura As New SfaFacturaRepuesto
        Dim objSfaFacturaDetalle As New SfaFacturaRepuestoDetalle
        Dim T As New TransactionManager
        Try
            Try
                Select Case MsgBox("¿Seguro que desea eliminar la pre-factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        T.BeginTran()
                        SfaFacturaRepuestoDetalle.DeleteByFilter("objFacturaRepuestoID = " & Me.grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value)
                        SfaFacturaRepuesto.DeleteByFilter("SfaFacturaRepuestoID = " & Me.grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value)
                        T.CommitTran()
                        MsgBox("La pre-factura ha sido eliminada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                End Select

            Catch ex As Exception
                clsError.CaptarError(ex)
                T.RollbackTran()
            End Try
        Finally

        End Try
    End Sub
#End Region

#Region "Buscar"

    Private Sub Buscar()
        Dim BuscarOrdenCompra As New frmBuscarOrdenCompra
        Dim objseg As New SsgSeguridad
        Dim objTienda As New StbTienda
        Try
            Try
                If BuscarOrdenCompra.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.SqlParametros = BuscarOrdenCompra.Parametro
                    Me.CargarFacturas(BuscarOrdenCompra.strFiltro)
                End If                
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            BuscarOrdenCompra = Nothing
        End Try
    End Sub
#End Region

#Region "Procedimientos para Imprimir una Factura de Moto"

#Region "Separar la Descripcion de la moto"

    Private Sub SepararDescripcion(ByVal strDescripcion As String)
        Dim sCadena() As String = strDescripcion.Split(";")

        For Each item As String In sCadena
            Dim sPar() As String = item.Split("=")
            If sPar(0).Trim = "MA" Then
                Me.strMarca = sPar(1)
            End If

            If sPar(0).Trim = "MO" Then
                Me.strModelo = sPar(1)
            End If

            If sPar(0).Trim = "CO" Then
                Me.strColor = sPar(1)
            End If

            If sPar(0).Trim = "A" Then
                Me.strAno = sPar(1)
            End If

            If sPar(0).Trim = "MT" Then
                Me.strMotor = sPar(1)
            End If

            If sPar(0).Trim = "CH" Then
                Me.strChasis = sPar(1)
            End If

            If sPar(0).Trim = "CI" Then
                Me.strCilindraje = sPar(1)
            End If

            If sPar(0).Trim = "CL" Then
                Me.strCilindros = sPar(1)
            End If

            If sPar(0).Trim = "T" Then
                Me.strTipo = sPar(1)
            End If

            If sPar(0).Trim = "C" Then
                Me.strCombustible = sPar(1)
            End If

            If sPar(0).Trim = "V" Then
                Me.strVelocidades = sPar(1)
            End If

            If sPar(0).Trim = "P" Then
                Me.strPasajeros = sPar(1)
            End If

            If sPar(0).Trim = "PO" Then
                Me.strPoliza = sPar(1)
            End If
        Next

    End Sub
#End Region

#Region "Inicializar para Descripcion De Moto"

    Private Sub InicializarMarca(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "MARCA: " & Me.strMarca
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub
    Private Sub InicializarModelo(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "MODELO: " & Me.strModelo
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarColor(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "COLOR: " & Me.strColor
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarAno(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "AÑO :" & Me.strAno
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarMotor(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "MOTOR: " & Me.strMotor
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub
    Private Sub InicializarChasis(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "CHASIS: " & Me.strChasis
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarCilindraje(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "CILINDRAJE: " & Me.strCilindraje
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarCilindro(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "CILINDROS: " & Me.strCilindros
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarTipo(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "TIPO: " & Me.strTipo
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarCombustible(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "COMBUSTIBLE: " & Me.strCombustible
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarVelocidades(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "VELOCIDADES: " & Me.strVelocidades
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarPasajeros(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "PASAJEROS: " & Me.strPasajeros
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarPoliza(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "POLIZA No: " & Me.strPoliza
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

#End Region

#End Region

#Region "Imprimir"

    Private Sub Imprimir()
        Dim visor As New frmVisorRS
        Dim sFiltro, sCampos, sSQL As String
        Dim dtDatos As DataTable
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim dblSubTotal, dblTotalDolares, dblTotalCordobas, dblTasa, dblImpuesto, dblDescuento As Double
        Dim strEslogan As String = String.Empty
        Dim strDireccionEmpresa, strTelefonoEmpresa As String

        sFiltro = "SfaFacturaRepuestoID = " & Me.grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value
        sCampos = "Cliente, OrdenCompra, SfaFacturaRepuestoID, Fecha, Cantidad, Precio, DescuentoDetalle, objRepuestoID, Subtotal, Descripcion, SubTotalMaestro, DescuentoMaestro, ImpuestoMaestro, TotalDolares, TotalCordobas, TasaCambio, DGI, Eslogan, objEstadoID"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptOrdenCompra", sFiltro)
        dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL)

        'For i As Integer = 0 To 11 - dtDatos.Rows.Count
        '    Dim filaTemp As DataRow
        '    filaTemp = dtDatos.NewRow
        '    Me.InicializarFila(filaTemp)
        '    dtDatos.Rows.Add(filaTemp)
        'Next
        dblSubTotal = dtDatos.DefaultView.Item(0)("SubTotalMaestro")
        dblTotalDolares = dtDatos.DefaultView.Item(0)("TotalDolares")

        dblTotalCordobas = dtDatos.DefaultView.Item(0)("TotalCordobas")
        dblTasa = dtDatos.DefaultView.Item(0)("TasaCambio")
        dblImpuesto = dtDatos.DefaultView.Item(0)("ImpuestoMaestro")
        dblDescuento = dtDatos.DefaultView.Item(0)("DescuentoMaestro")

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Eslogan")) Then
            strEslogan = dtDatos.DefaultView.Item(0)("Eslogan")
        End If

        strDireccionEmpresa = ClsCatalogos.GetValorParametro("DireccionEmpresa")
        strTelefonoEmpresa = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDireccionEmpresa", strDireccionEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmTelefonoEmpresa", strTelefonoEmpresa, False))
        
        With visor.VisorReportes
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportEmbeddedResource = "SCCUM.rptOrdenCompra.rdlc"
            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtvwRptOrdenCompra_vwRptOrdenCompra", dtDatos))
            .LocalReport.SetParameters(parametros)
            .RefreshReport()
        End With

        visor.ShowDialog()
    End Sub

    Private Sub InicializarFila(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

#End Region

#End Region

#Region "Eventos"

#Region "Formulario"
    Private Sub frmSfaOrdenesCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            Me.CargarIdentificadoresEstadosFactura()

            'configurar sucursal en sessión
            glb_SucursalCentralID = ClsCatalogos.GetStbTiendaID("C")
            If Not String.IsNullOrEmpty(clsProyecto.Sucursal) Then
                glb_SucursalSessionID = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
            Else
                MsgBox("No se ha configurado la Sucursal en el utilitario de configuración.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.Close()
            End If

            Me.CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasOrdenesCompras"))
            Me.AplicarSeguridad()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdFacturaMaster_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdFacturaMaster.RowColChange
        Me.VerificarEstadoOrdenCompra()
        'If Me.dtFactura.Rows.Count <> 0 Then
        '    If (Me.grdFacturaMaster.Columns("objEstadoID").Value = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "PROCESADA")) Then
        '        Me.cmdProcesar.Enabled = False
        '        Me.cmdAnular.Enabled = True
        '        Me.cmdImprimir.Enabled = True
        '    ElseIf (Me.grdFacturaMaster.Columns("objEstadoID").Value = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "ANULADA")) Then
        '        Me.cmdProcesar.Enabled = False
        '        Me.cmdAnular.Enabled = False
        '        Me.cmdImprimir.Enabled = False
        '    Else
        '        Me.cmdProcesar.Enabled = True
        '        Me.cmdAnular.Enabled = True
        '        Me.cmdImprimir.Enabled = False
        '    End If
        'End If
    End Sub
#End Region

#Region "Botones"
    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        Me.Procesar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Consultar()
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If (Me.grdFacturaMaster.Columns("objEstadoID").Value = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "PROCESADA")) Then
            Me.Anular()
        ElseIf (Me.grdFacturaMaster.Columns("objEstadoID").Value = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "REGISTRADA")) Then

        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Me.Imprimir()
        Imprimir_Ticket(Me.grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value)
    End Sub

    Public Shared Sub Imprimir_Ticket(ByVal sIdFactura As String)
        Dim objRptOrdenCompra As rptOrdenCompraActive
        Dim sSQL, sCampos As String
        Dim dtDatos As DataTable
        Dim iCantidadItems As Integer
        sCampos = "*"

        'Obtener datos para la generación del reporte
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptOrdenCompra", "SfaFacturaRepuestoID=" + sIdFactura)
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)
        sSQL = clsConsultas.ObtenerConsultaGeneral("Count(SfaFacturaRepuestoID) as Contador", "dbo.vwRptOrdenCompra", "SfaFacturaRepuestoID=" + sIdFactura)
        'Muestra la cantidad de repuestos al final del ticket.
        iCantidadItems = SqlHelper.ExecuteQueryDT(sSQL).DefaultView.Item(0)("Contador")

        'Si hay resultados mostrar opciones para mostrar informe
        If dtDatos.Rows.Count <> 0 Then
            objRptOrdenCompra = New rptOrdenCompraActive
            With objRptOrdenCompra
                .DataSource = dtDatos
                .Parameters("prmTasaCambio").Value = dtDatos.DefaultView.Item(0)("TasaCambio")
                .Parameters("prmSubTotalMaestro").Value = dtDatos.DefaultView.Item(0)("SubTotalMaestro")
                .Parameters("prmEslogan").Value = dtDatos.DefaultView.Item(0)("Eslogan")
                .Parameters("prmDescuentoMaestro").Value = dtDatos.DefaultView.Item(0)("DescuentoMaestro")
                .Parameters("prmIVAMaestro").Value = dtDatos.DefaultView.Item(0)("ImpuestoMaestro")
                .Parameters("prmTotalCordobas").Value = dtDatos.DefaultView.Item(0)("TotalCordobas")
                .Parameters("prmTotalDolares").Value = dtDatos.DefaultView.Item(0)("TotalDolares")
                .Parameters("prmCantItems").Value = iCantidadItems
                .Parameters("prmDireccionEmpresa").Value = ClsCatalogos.GetValorParametro("DireccionEmpresa")
                .Parameters("prmTelEmpresa").Value = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
                .Parameters("prmRUC").Value = ClsCatalogos.GetValorParametro("RUC")
                .Parameters("prmUsuarioFechaHora").Value = clsProyecto.Conexion.FechaServidor.ToString
                '.Run()
            End With

            'If clsProyecto.ImpresoraFacturas.Trim.Length <> 0 Then
            '    Try
            '        If clsProyecto.EstaImpresoraInstalada(clsProyecto.ImpresoraFacturas) Then
            '            objRptOrdenCompra.Document.Printer.PrinterName = clsProyecto.ImpresoraFacturas
            '            'objRptOrdenCompra.Document.Print(False, False)
            '            clsProyecto.ImprimirEnImpresora(objRptOrdenCompra, True)
            '        Else
            '            If MsgBox("La impresora '" + clsProyecto.ImpresoraFacturas + "' configurada en el Utilitario, no se encuentra instalada en el Sistema Operativo o el nombre no se ha escrito correctamente, Se mostrará la orden en Vista Previa.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema) Then
            '                clsProyecto.ImprimirEnPantalla(objRptOrdenCompra)
            '            End If
            '        End If
            '    Catch ex As Exception
            '        clsError.CaptarError(ex)
            '    End Try
            'Else
            '    MsgBox("La impresora de Ordenes de Facturación no ha sido configurada, se mostrará la orden en vista previa para imprimir en otra impresora.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            '    clsProyecto.ImprimirEnPantalla(objRptOrdenCompra)
            'End If
        End If
    End Sub
#End Region

#End Region

    Private Sub cmdAgregarOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarOrdenCompra.Click
        Me.Agregar()
    End Sub

#Region "Verificar estado Orden Compra"
    Private Sub VerificarEstadoOrdenCompra()
        Try
            If Me.dtFactura.Rows.Count <> 0 Then
                If Not IsDBNull(Me.grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value) AndAlso grdFacturaMaster.Columns("SfaFacturaRepuestoID").Value.ToString.Trim.Length <> 0 Then
                    Me.cmdProcesar.Enabled = Me.boolProcesar And (grdFacturaMaster.Columns("objEstadoID").Value = glb_EstadoFacturaRegistradaID)
                    Me.cmdAnular.Enabled = Me.boolAnular And (grdFacturaMaster.Columns("objEstadoID").Value = glb_EstadoFacturaProcesadaID)
                End If
            End If
        Catch ex As Exception
            Me.cmdAnular.Enabled = False
            Me.cmdProcesar.Enabled = False
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Identificadores de estado Factura"
    Private Sub CargarIdentificadoresEstadosFactura()
        glb_EstadoFacturaAnuladaID = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "ANULADA")
        glb_EstadoFacturaProcesadaID = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "PROCESADA")
        glb_EstadoFacturaRegistradaID = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "REGISTRADA")
    End Sub
#End Region

    Private Sub cmdAgregarDesdeCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarDesdeCotizacion.Click
        Try
            Me.AgregarCotizacion()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

End Class