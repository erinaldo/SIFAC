Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos

Public Class frmSfaFacturaRepuestos

#Region "Variables del formulario"
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

            dtFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SfaFacturaID, Numero,objSccClienteID,TotalDolares, Fecha, Estado, Vendedor, Cliente, Anulada,objEstadoID", "vwSfaFacturaMaster", strFiltro & " ORDER BY Numero DESC"), Me.SqlParametros)
            dtDetalleFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objSfaFacturaID,objSivProductoID, Cantidad, Precio, Subtotal, Descuento, Impuesto, Total, Producto,Fecha", "vwSafaFacturaDetalle", strFiltro), Me.SqlParametros)

            dsFactura = New DataSet

            dsFactura.Merge(dtFactura)
            dsFactura.Tables(0).TableName = "SfaFactura"

            dsFactura.Merge(dtDetalleFactura)
            dsFactura.Tables(1).TableName = "SfaFacturaDetalle"

            dsFactura.Relations.Add("SfaFactura_SfaFacturaDetalle", dsFactura.Tables(0).Columns("SfaFacturaID"), dsFactura.Tables(1).Columns("objSfaFacturaID"), False)

            Me.grdFacturaMaster.DataSource = dsFactura
            Me.grdFacturaMaster.DataMember = "SfaFactura"

            Me.grdFacturaDetalle.DataSource = dsFactura
            Me.grdFacturaDetalle.DataMember = "SfaFactura.SfaFactura_SfaFacturaDetalle"

            Me.grdFacturaMaster.Text = "Factura (" & Me.grdFacturaMasterTabla.RowCount & ")"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AplicarSeguridad()
        Dim FilaActual As Integer
        Try
            objseg = New SsgSeguridad

            objseg.ServicioUsuario = "frmSfaFacturas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarFactura")
            boolBuscar = objseg.TienePermiso("BuscarFactura")
            boolConsultar = objseg.TienePermiso("ConsultarFactura")
            boolAnular = objseg.TienePermiso("AnularFactura")
            boolProcesar = objseg.TienePermiso("ProcesarFactura")
            boolImprimir = objseg.TienePermiso("ImprimirFactura")

            Me.cmdAgregar.Enabled = boolAgregar
            Me.cmdProcesar.Enabled = boolProcesar
            Me.cmdConsultar.Enabled = boolConsultar
            Me.cmdAnular.Enabled = boolAnular
            Me.cmdBuscar.Enabled = boolConsultar
            Me.cmdImprimir.Enabled = boolImprimir

            If Me.grdFacturaMasterTabla.RowCount = 0 Then
                Me.cmdProcesar.Enabled = False
                Me.cmdConsultar.Enabled = False
                Me.cmdAnular.Enabled = False
                Me.cmdImprimir.Enabled = False
            End If

            FilaActual = Me.grdFacturaMasterTabla.FocusedRowHandle

            If Me.dtFactura.Rows.Count <> 0 Then
                If Not String.IsNullOrEmpty(Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("objEstadoID").ToString) Then
                    If (Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("objEstadoID") = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "PROCESADA")) Then
                        Me.cmdProcesar.Enabled = False
                        Me.cmdAnular.Enabled = True
                        Me.cmdImprimir.Enabled = True
                    ElseIf Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("objEstadoID") = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "ANULADA") Then
                        Me.cmdProcesar.Enabled = False
                        Me.cmdAnular.Enabled = False
                        Me.cmdImprimir.Enabled = False
                    Else
                        Me.cmdProcesar.Enabled = True
                        Me.cmdAnular.Enabled = False
                        Me.cmdImprimir.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

    '#Region "Validar Datos"
    '    Private Function BoolConTasaCambio() As Boolean
    '        Dim dtTasaCambio As DataTable
    '        Dim MesFormateado As Integer
    '        Dim AnioFormateado As Integer
    '        Dim strFiltro As String

    '        MesFormateado = Month(clsProyecto.Conexion.FechaServidor)
    '        AnioFormateado = Year(clsProyecto.Conexion.FechaServidor)
    '        Try
    '            Try
    '                strFiltro = "Mes=" & MesFormateado & " AND Anio=" & AnioFormateado & " AND objMonedaID=(SELECT StbValorCatalogoID FROM StbValorCatalogo WHERE objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MONEDA') AND Codigo='USD')"
    '                dtTasaCambio = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Monto", "StbTasaCambioOficial", strFiltro))

    '                If dtTasaCambio.DefaultView.Count > 0 Then
    '                    dblTasaCambio = dtTasaCambio.DefaultView.Item(0)("Monto")
    '                    Return True
    '                Else
    '                    Return False
    '                End If

    '            Catch ex As Exception
    '                clsError.CaptarError(ex)
    '            End Try
    '        Finally
    '            dtTasaCambio = Nothing
    '        End Try
    '    End Function
    '#End Region

#Region "Operaciones"

#Region "Agregar"

    Private Sub Agregar()
        Dim AgregarFactura As frmSfaFacturaRepuestosEditar
        'Dim objTienda As New StbTienda
        Dim objseg As New SsgSeguridad
        Try
            Try
                objseg.Usuario = clsProyecto.Conexion.Usuario
                objseg.ServicioUsuario = "frmPrincipal"
                'If BoolConTasaCambio() Then
                'If Not objTienda.RetrieveByFilter("StbTiendaID = " & ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal) & " AND Codigo = 'C'") Then
                AgregarFactura = New frmSfaFacturaRepuestosEditar
                AgregarFactura.TypeGUI = 1

                AgregarFactura.MontoTasaCambio = Me.dblTasaCambio
                If AgregarFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
                    dtFactura.DefaultView.Sort = "SfaFacturaID"
                    Me.dtFactura.DefaultView.Find(AgregarFactura.SfaFacturaID)
                End If
                'Else
                'MsgBox("Central no puede realizar facturación, ir a Orden de Compra", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                'End If
                'Else
                '    MsgBox("Debe ingresar la tasa de cambio del mes actual.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                'End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            AgregarFactura = Nothing
        End Try
    End Sub

    'Private Sub AgregarCotizacion()
    '    Dim BuscarCotizacion As frmSfaBusquedaCotizacion
    '    Dim AgregarFactura As frmSfaFacturaRepuestosEditar
    '    Dim objTienda As New StbTienda
    '    Dim objseg As New SsgSeguridad
    '    Dim objCotizacionID As Integer
    '    Try
    '        Try
    '            objseg.Usuario = clsProyecto.Conexion.Usuario
    '            objseg.ServicioUsuario = "frmPrincipal"

    '            'If BoolConTasaCambio() Then
    '            'If Not objTienda.RetrieveByFilter("StbTiendaID = " & ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal) & " AND Codigo = 'C'") Then

    '            BuscarCotizacion = New frmSfaBusquedaCotizacion
    '            If Not String.IsNullOrEmpty(clsProyecto.Sucursal) Then
    '                BuscarCotizacion.StrFiltroCotizaciones = " objTiendaID = " & ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
    '            Else
    '                MsgBox("No se ha configurado la sucursal", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
    '                Exit Sub
    '            End If
    '            If BuscarCotizacion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '                objCotizacionID = BuscarCotizacion.Seleccion
    '                AgregarFactura = New frmSfaFacturaRepuestosEditar
    '                AgregarFactura.TypeGUI = 6
    '                AgregarFactura.SfaCotizacionID = objCotizacionID

    '                If AgregarFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '                    Me.CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
    '                    dtFactura.DefaultView.Sort = "SfaFacturaID"
    '                    Me.dtFactura.DefaultView.Find(AgregarFactura.SfaFacturaID)
    '                End If
    '            End If

    '            'Else
    '            '    MsgBox("Central no puede realizar facturación, ir a Orden de Compra", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
    '            'End If
    '            'Else
    '            '    MsgBox("Debe ingresar la tasa de cambio del mes actual.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
    '            'End If
    '        Catch ex As Exception
    '            clsError.CaptarError(ex)
    '        End Try
    '    Finally
    '        AgregarFactura = Nothing
    '    End Try
    'End Sub
#End Region

#Region "Procesar"
    Private Sub Procesar()
        Dim ProcesarFactura As New frmSfaFacturaRepuestosEditar
        Dim objseg As New SsgSeguridad
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdFacturaMasterTabla.FocusedRowHandle
                objseg.Usuario = clsProyecto.Conexion.Usuario
                objseg.ServicioUsuario = "frmPrincipal"

                If objseg.TienePermiso("AUTORIZACIONGERENTE") Then
                    ProcesarFactura.TypeGUI = 3
                Else
                    ProcesarFactura.TypeGUI = 2
                End If

                ProcesarFactura.SfaFacturaID = Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("SfaFacturaID")
                If ProcesarFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
                    dtFactura.DefaultView.Sort = "SfaFacturaID"
                    Me.dtFactura.DefaultView.Find(ProcesarFactura.SfaFacturaID)
                    Me.AplicarSeguridad()
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
        Dim ConsultarFactura As New frmSfaFacturaRepuestosEditar
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdFacturaMasterTabla.FocusedRowHandle
                ConsultarFactura.TypeGUI = 4
                ConsultarFactura.SfaFacturaID = Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("SfaFacturaID")
                ConsultarFactura.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarFactura = Nothing
        End Try
    End Sub

#End Region

#Region "Anular"

    Private Sub Anular()
        Dim AnularFactura As New frmSfaFacturaRepuestosEditar
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdFacturaMasterTabla.FocusedRowHandle
                AnularFactura.TypeGUI = 5
                AnularFactura.SfaFacturaID = Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("SfaFacturaID")
                If AnularFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
                    dtFactura.DefaultView.Sort = "SfaFacturaID"
                    Me.dtFactura.DefaultView.Find(AnularFactura.SfaFacturaID)
                    Me.AplicarSeguridad()
                End If
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
        Dim FilaActual As Integer
        Dim objSfaFactura As New SfaFacturas
        Dim objSfaFacturaDetalle As New SfaFacturasDetalle
        Dim T As New TransactionManager
        Try
            Try
                FilaActual = Me.grdFacturaMasterTabla.FocusedRowHandle
                Select Case MsgBox("¿Seguro que desea eliminar la pre-factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        T.BeginTran()
                        SfaFacturasDetalle.DeleteByFilter("objSfaFacturaID = " & Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("SfaFacturaID"))
                        SfaFacturas.DeleteByFilter("SfaFacturaID = " & Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("SfaFacturaID"))
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
        Dim BuscarFactura As New frmSfaBuscarFactura
        Dim objseg As New SsgSeguridad
        'Dim objStbBodegas As New StbBodegas
        Try
            Try
                'If Not objStbBodegas.RetrieveByFilter("StbBodegaID = " & ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal) & " AND Codigo = 'C'") Then
                If BuscarFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.SqlParametros = BuscarFactura.Parametro
                    Me.CargarFacturas(BuscarFactura.strFiltro)
                End If
                'Else
                '    MsgBox("Central no puede realizar facturación, ir a Orden de Compra", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                'End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            BuscarFactura = Nothing
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
        fila("SfaFacturaID") = 0
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
        Dim FilaActual As Integer
        Dim sFiltro, sCampos, sSQL As String
        Dim dtDatos As DataTable
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim dblSubTotal, dblSubTotalVentas, dblTotalDolares, dblPrima, dblSaldo, dblTotalCordobas, dblTasa, dblImpuesto, dblDescuento As Double
        Dim strObservaciones, strEslogan, strCedula As String

        strObservaciones = ""
        strCedula = ""
        strEslogan = ""

        FilaActual = Me.grdFacturaMasterTabla.FocusedRowHandle

        sFiltro = "SfaFacturaID = " & Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("SfaFacturaID")
        sCampos = "Vendedor, Cliente, Estado, SfaFacturaID, Numero, SubTotalVentas,Fecha, Contado, Credito, Precio, Cantidad, objSivProductoID, Subtotal, Descripcion, SubTotalMaestro, DescuentoMaestro, ImpuestoMaestro, TotalDolares, TotalCordobas, TasaCambio, Prima, Saldo, observaciones, objEstadoID, DGI, objSfaFacturaID, Dia, Mes, Ano,Eslogan, Cedula, Direccion"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptSfaFacturaRepuesto", sFiltro)
        dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL)

        'For i As Integer = 0 To 11 - dtDatos.Rows.Count
        '    Dim filaTemp As DataRow
        '    filaTemp = dtDatos.NewRow
        '    Me.InicializarFila(filaTemp)
        '    dtDatos.Rows.Add(filaTemp)
        'Next
        dblSubTotal = dtDatos.DefaultView.Item(0)("SubTotalMaestro")
        dblTotalDolares = dtDatos.DefaultView.Item(0)("TotalDolares")

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Prima")) Then
            dblPrima = dtDatos.DefaultView.Item(0)("Prima")
        End If

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Saldo")) Then
            dblSaldo = dtDatos.DefaultView.Item(0)("Saldo")
        End If

        dblTotalCordobas = dtDatos.DefaultView.Item(0)("TotalCordobas")
        dblTasa = dtDatos.DefaultView.Item(0)("TasaCambio")
        dblImpuesto = dtDatos.DefaultView.Item(0)("ImpuestoMaestro")
        dblDescuento = dtDatos.DefaultView.Item(0)("DescuentoMaestro")

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("observaciones")) Then
            strObservaciones = dtDatos.DefaultView.Item(0)("observaciones")
        End If

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Eslogan")) Then
            strEslogan = dtDatos.DefaultView.Item(0)("Eslogan")
        End If

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Cedula")) Then
            strCedula = dtDatos.DefaultView.Item(0)("Cedula")
        End If

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("SubTotalVentas")) Then
            dblSubTotalVentas = dtDatos.DefaultView.Item(0)("SubTotalVentas")
        End If

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TotalVenta", dblSubTotal, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TotalDolares", dblTotalDolares, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Prima", dblPrima, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Saldo", dblSaldo, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TotalCordobas", dblTotalCordobas, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TasaCambio", dblTasa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Impuesto", dblImpuesto, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Descuento", dblDescuento, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Observaciones", strObservaciones, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Eslogan", strEslogan, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Cedula", strCedula, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("SubTotalVenta", dblSubTotalVentas, False))


        With visor.VisorReportes
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportEmbeddedResource = "SIFAC.rptSfaFacturaRepuesto.rdlc"
            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtRptFacturaRepuestos_vwRptSfaFacturaRepuesto", dtDatos))
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
    Private Sub frmSfaFacturaRepuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            CargarFacturas("datediff(DAY,GETDATE(),Fecha)<= " & ClsCatalogos.GetValorParametro("DiasFacturas"))
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdFacturaMasterTabla_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdFacturaMasterTabla.FocusedRowChanged
        Dim FilaActual As Integer
        FilaActual = Me.grdFacturaMasterTabla.FocusedRowHandle

        If Me.dtFactura.Rows.Count <> 0 Then

            If Not String.IsNullOrEmpty(Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("objEstadoID").ToString) Then
                If (Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("objEstadoID") = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "PROCESADA")) Then
                    Me.cmdProcesar.Enabled = False
                    Me.cmdAnular.Enabled = True
                    Me.cmdImprimir.Enabled = True
                ElseIf Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("objEstadoID") = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "ANULADA") Then
                    Me.cmdProcesar.Enabled = False
                    Me.cmdAnular.Enabled = False
                    Me.cmdImprimir.Enabled = False
                Else
                    Me.cmdProcesar.Enabled = True
                    Me.cmdAnular.Enabled = False
                    Me.cmdImprimir.Enabled = False
                End If
            End If
        End If
    End Sub
#End Region

#Region "Botones"
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Agregar()
    End Sub

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
        Dim FilaActual As Integer

        FilaActual = Me.grdFacturaMasterTabla.FocusedRowHandle

        If (Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("objEstadoID") = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "PROCESADA")) Then
            Me.Anular()
        ElseIf (Me.dsFactura.Tables("SfaFactura").DefaultView.Item(FilaActual)("objEstadoID") = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "REGISTRADA")) Then

        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Me.Imprimir()
    End Sub
    Private Sub AgregaDesdeCotizaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'AgregarCotizacion()
    End Sub
#End Region

#End Region
    
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Agregar()
    End Sub
End Class