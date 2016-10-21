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
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar, boolDesactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla


    Private Sub CargarEncargos(ByVal strFiltro As String)
        Try

            dtPedidos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivPedidoID, Numero, Estado, TotalCosto, Fecha, Proveedor ", "vwSivPedidosMaster", strFiltro & " ORDER BY Fecha DESC"), Me.SqlParametros)
            dtDetallePedidos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivPedidoDetalleID, objPedidoID, objCategoriaID, Categoria, Numero, NombreProducto, CantidadOrdenada, TotalCosto", "vwPedidosDetalle", strFiltro), Me.SqlParametros)

            dsPedidos = New DataSet

            dsPedidos.Merge(dtPedidos)
            dsPedidos.Tables(0).TableName = "SivPedidos"

            dsPedidos.Merge(dtDetallePedidos)
            dsPedidos.Tables(1).TableName = "SivPedidoDetalle"

            dsPedidos.Relations.Add("SivPedidos_SivPedidoDetalle", dsPedidos.Tables(0).Columns("SivPedidoID"), dsPedidos.Tables(1).Columns("objPedidoID"), False)

            Me.grdEncargosMaster.DataSource = dsPedidos
            Me.grdEncargosMaster.DataMember = "SivPedidos"

            Me.grdEncargosDetalle.DataSource = dsPedidos
            Me.grdEncargosDetalle.DataMember = "SivPedidos.SivPedidos_SivPedidoDetalle"

            Me.grdEncargosMaster.Text = "Pedidos (" & Me.grdEncargosMasterTabla.RowCount & ")"



        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSivPedidos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarEncargo")
            boolConsultar = objseg.TienePermiso("ConsultarEncargo")
            boolEditar = objseg.TienePermiso("EditarEncargo")
            boolImprimir = objseg.TienePermiso("ImprimirEncargo")
            boolDesactivar = objseg.TienePermiso("InactivasEncargo")

            'cmdAgregar.Enabled = boolAgregar
            'cmdEditar.Enabled = boolEditar And dtEncargos.Rows.Count > 0
            'cmdConsultar.Enabled = boolConsultar And dtEncargos.Rows.Count > 0
            'cmdImprimir.Enabled = boolImprimir And dtEncargos.Rows.Count > 0
            'cmdDesactivar.Enabled = boolDesactivar And dtEncargos.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub


#End Region


End Class