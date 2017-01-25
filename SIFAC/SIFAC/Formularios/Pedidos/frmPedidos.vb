Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO
Imports DevExpress.XtraReports.UI
Imports DAL
Imports Proyecto.Catalogos.Datos

Public Class frmPedidos

#Region "Variables del formulario"
    Dim dtPedidos, dtPedidosExcel, dtDetallePedidos As DataTable
    Dim gblEstadoAprobadaID As Integer
    Dim dsPedidos As DataSet
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar, boolDesactivar, boolAutorizar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter

    Private m_DiasPedidosRecientes As Integer

    Property DiasPedidosRecientes() As Integer
        Get
            DiasPedidosRecientes = Me.m_DiasPedidosRecientes
        End Get
        Set(ByVal value As Integer)
            Me.m_DiasPedidosRecientes = value
        End Set
    End Property
#End Region


#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla


    Private Sub CargarPedidos(ByVal strFiltro As String)
        Try
            Me.DiasPedidosRecientes = ClsCatalogos.GetValorParametro("DiasPedidosRecientes")

            dtPedidos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivPedidoID, Numero, Estado, TotalCosto, Fecha, Proveedor ,objEstadoID", "vwSivPedidosMaster", strFiltro & " AND (DATEDIFF(DAY, Fecha, GETDATE()) <= " + Me.DiasPedidosRecientes.ToString + ")  ORDER BY Fecha DESC"), Me.SqlParametros)
            dtDetallePedidos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivPedidoDetalleID, objPedidoID, objCategoriaID, Categoria, Numero, NombreProducto, CantidadOrdenada, TotalCosto", "vwPedidosDetalle", strFiltro), Me.SqlParametros)

            dsPedidos = New DataSet

            dsPedidos.Merge(dtPedidos)
            dsPedidos.Tables(0).TableName = "SivPedidos"

            dsPedidos.Merge(dtDetallePedidos)
            dsPedidos.Tables(1).TableName = "SivPedidoDetalle"

            dsPedidos.Relations.Add("SivPedidos_SivPedidoDetalle", dsPedidos.Tables(0).Columns("SivPedidoID"), dsPedidos.Tables(1).Columns("objPedidoID"), False)

            Me.grdPedidosMaster.DataSource = dsPedidos
            Me.grdPedidosMaster.DataMember = "SivPedidos"

            Me.grdPedidosDetalle.DataSource = dsPedidos
            Me.grdPedidosDetalle.DataMember = "SivPedidos.SivPedidos_SivPedidoDetalle"

            Me.grdPedidosMaster.Text = "Pedidos (" & Me.grdPedidosMasterTabla.RowCount & ")"

           

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSivPedidos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarPedido")
            boolConsultar = objseg.TienePermiso("ConsultarPedido")
            boolEditar = objseg.TienePermiso("EditarPedido")
            boolImprimir = objseg.TienePermiso("ImprimirPedido")
            boolDesactivar = objseg.TienePermiso("InactivarPedido")
            boolAutorizar = objseg.TienePermiso("AutorizarPedido")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtPedidos.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtPedidos.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtPedidos.Rows.Count > 0
            cmdDesactivar.Enabled = boolDesactivar And dtPedidos.Rows.Count > 0
            btnAutorizar.Enabled = boolBuscar And dtPedidos.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos"

    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gblEstadoAprobadaID = ClsCatalogos.GetValorCatalogoID("ESTADOPEDIDO", "02") '-- 02=Aprobada
            CargarPedidos("1=1")
            Me.AplicarSeguridad()

            Dim FilaActual As Integer

            If dtPedidos.Rows.Count > 0 Then
                Dim selectedRow As Integer() = grdPedidosMasterTabla.GetSelectedRows()
                FilaActual = Me.grdPedidosMasterTabla.GetDataSourceRowIndex(selectedRow(0))

                Me.btnAutorizar.Enabled = Not Integer.Parse(Me.dtPedidos.DefaultView.Item(FilaActual)("ObjEstadoID")) = gblEstadoAprobadaID
                Me.cmdEditar.Enabled = Not Integer.Parse(Me.dtPedidos.DefaultView.Item(FilaActual)("ObjEstadoID")) = gblEstadoAprobadaID
            End If
           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editPedidos As frmPedidosEdit
        Try
            Me.Cursor = WaitCursor
            editPedidos = New frmPedidosEdit
            editPedidos.TypeGui = 0
            If editPedidos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarPedidos("1=1")
                Me.AplicarSeguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Dim editPedidos As frmPedidosEdit
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdPedidosMasterTabla.GetSelectedRows()
            FilaActual = Me.grdPedidosMasterTabla.GetDataSourceRowIndex(selectedRow(0))

            Me.Cursor = WaitCursor
            editPedidos = New frmPedidosEdit
            editPedidos.TypeGui = 1
            editPedidos.PedidoID = Me.dtPedidos.DefaultView.Item(FilaActual)("SivPedidoID")
            If editPedidos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarPedidos("1=1")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim editPedidos As frmPedidosEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdPedidosMasterTabla.FocusedRowHandle
            Me.Cursor = WaitCursor
            editPedidos = New frmPedidosEdit
            editPedidos.TypeGui = 2
            editPedidos.PedidoID = Me.dtPedidos.DefaultView.Item(FilaActual)("SivPedidoID")
            editPedidos.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        Dim IDPedido As Integer
        Dim Pedidos As New SivPedidos
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdPedidosMasterTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar el pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDPedido = Me.dtPedidos.DefaultView.Item(FilaActual)("SivPedidoID")
                    Pedidos.Retrieve(IDPedido)
                    Pedidos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Pedidos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Pedidos.Activo = False
                    Pedidos.Update()
                    CargarPedidos("1=1")
                    'Me.dtPedidos.DefaultView.Find(Pedidos.SivPedidoID)
                    Me.AplicarSeguridad()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Try
            CargarPedidos("1=1")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub
#End Region



    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        'Me.Imprimir()
        Dim dsReporte As DataSet
        Dim sCampos, sSQL As String
        Try
            Dim objjReporte As New rptHojaPedido
            Dim selectedRow As Integer() = grdPedidosMasterTabla.GetSelectedRows()
            Dim FilaActual As Integer = Me.grdPedidosMasterTabla.GetDataSourceRowIndex(selectedRow(0))

            sCampos = "SivPedidoID, FechaPedido, FechaAutorizacion, Activo, Observaciones, CodProd, Producto, CantidadOrdenada, CostoUnitario, CostoSubtotal, CostoImpuesto, CostoTotal, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa"
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptPedidos", "SivPedidoID = " & Me.dsPedidos.Tables("SivPedidos").DefaultView.Item(FilaActual)("Numero"))
            dsReporte = SqlHelper.ExecuteQueryDS(sSQL)

            If dsReporte.Tables(0).Rows.Count = 0 Then
                MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objjReporte.DataSource = dsReporte
            objjReporte.DataMember = dsReporte.Tables(0).TableName
            Dim pt As New ReportPrintTool(objjReporte)
            pt.ShowPreview()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub btnAutorizar_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        Dim IDPedido As Integer
        Dim Pedidos As New SivPedidos
        Dim Catalogos As New StbCatalogo
        Dim ValorCatalogo As New StbValorCatalogo
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdPedidosMasterTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de aprobar el pedido seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDPedido = Me.dtPedidos.DefaultView.Item(FilaActual)("SivPedidoID")
                    Pedidos.Retrieve(IDPedido)
                    Catalogos.RetrieveByFilter("Nombre='ESTADOPEDIDO'")
                    ValorCatalogo.RetrieveByFilter("objCatalogoID=" & Catalogos.StbCatalogoID & " AND Codigo='02'")
                    Pedidos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Pedidos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Pedidos.ObjEstadoID = ValorCatalogo.StbValorCatalogoID
                    Pedidos.Update()
                    CargarPedidos("1=1")
                    Me.AplicarSeguridad()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

     
    End Sub

    Private Sub grdPedidosMasterTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdPedidosMasterTabla.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            If dtPedidos.Rows.Count > 0 Then
                If not IsNothing(grdPedidosMasterTabla.GetSelectedRows()) Then
                    Dim selectedRow As Integer() = grdPedidosMasterTabla.GetSelectedRows()
                    FilaActual = Me.grdPedidosMasterTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        If Me.dtPedidos.DefaultView.Item(FilaActual)("ObjEstadoID").ToString.Trim.Length <> 0 Then
                            Me.btnAutorizar.Enabled = Not Integer.Parse(Me.dtPedidos.DefaultView.Item(FilaActual)("ObjEstadoID")) = gblEstadoAprobadaID
                            Me.cmdEditar.Enabled = Not Integer.Parse(Me.dtPedidos.DefaultView.Item(FilaActual)("ObjEstadoID")) = gblEstadoAprobadaID
                        End If
                    End If

                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class

