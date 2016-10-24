Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO

Public Class frmPedidos

#Region "Variables del formulario"
    Dim dtPedidos, dtPedidosExcel, dtDetallePedidos As DataTable
    Dim dsPedidos As DataSet
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar, boolDesactivar, boolAutorizar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla


    Private Sub CargarPedidos(ByVal strFiltro As String)
        Try

            dtPedidos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivPedidoID, Numero, Estado, TotalCosto, Fecha, Proveedor ", "vwSivPedidosMaster", strFiltro & " ORDER BY Fecha DESC"), Me.SqlParametros)
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
            CargarPedidos("1=1")
            Me.AplicarSeguridad()
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
            FilaActual = Me.grdPedidosMasterTabla.FocusedRowHandle

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

    
    
End Class

