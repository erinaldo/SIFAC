Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos

Public Class frmSivEncargos

#Region "Variables del formulario"
    Dim dtEncargos, dtEncargosExcel, dtDetalleEncargos As DataTable
    Dim dsEncargos As DataSet
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar, boolDesactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla


    Private Sub CargarEncargos(ByVal strFiltro As String)

        Try
            dtEncargos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CAST(0 AS BIT) AS Seleccionar,  Numero, Ruta, Fecha, Vendedor, Cliente, Estado, Categoria, CodigoProducto, NombreProducto, Cantidad, CostoPromedio, TotalCosto", "VWEncargosConsolidado", strFiltro & " ORDER BY Fecha DESC"), Me.SqlParametros)

            Me.grdEncargosMaster.DataSource = dtEncargos
            Me.grdEncargosMaster.Text = "Encargos (" & Me.grdEncargosMasterTabla.RowCount & ")"

            dtEncargosExcel = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Ruta, Empleado, Categoria, Producto, Cantidad, CostoPromedio, TotalCosto, Observaciones", "vwEncargosExcel", strFiltro & " ORDER BY Empleado DESC"), Me.SqlParametros)
            Me.grdEncargosExcel.DataSource = dtEncargosExcel

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSivEncargos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarEncargo")
            boolConsultar = objseg.TienePermiso("ConsultarEncargo")
            boolEditar = objseg.TienePermiso("EditarEncargo")
            boolImprimir = objseg.TienePermiso("ImprimirEncargo")
            boolDesactivar = objseg.TienePermiso("InactivarEncargo")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtEncargos.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtEncargos.Rows.Count > 0
            cmdDesactivar.Enabled = boolDesactivar And dtEncargos.Rows.Count > 0
            cmbExportar.Enabled = boolImprimir And dtEncargos.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

    Private Sub ExportarExcel()
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.grdEncargosExcel.ExportToXls(sfdRuta.FileName)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarEncargos As New frmSivEncargosEdit
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
                ConsultarEncargos.TypeGui = 3
                ConsultarEncargos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
                ConsultarEncargos.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarEncargos = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarEncargo As New frmSivEncargosEdit
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
                EditarEncargo.TypeGui = 2
                EditarEncargo.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
                EditarEncargo.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarEncargo = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del formulario"

    Private Sub frmSivEncargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarEncargos("1=1")
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editEncargos As frmSivEncargosEdit
        Try
            Me.Cursor = WaitCursor
            editEncargos = New frmSivEncargosEdit
            editEncargos.TypeGui = 0
            If editEncargos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarEncargos("1=1")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Dim editEncargos As frmSivEncargosEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle

            Me.Cursor = WaitCursor
            editEncargos = New frmSivEncargosEdit
            editEncargos.TypeGui = 1
            editEncargos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
            If editEncargos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarEncargos("1=1")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim editEncargos As frmSivEncargosEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
            Me.Cursor = WaitCursor
            editEncargos = New frmSivEncargosEdit
            editEncargos.TypeGui = 2
            editEncargos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
            editEncargos.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        Dim IDEncargo As Integer
        Dim Encargos As New SivEncargos
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar el encargo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDEncargo = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
                    Encargos.Retrieve(IDEncargo)
                    Encargos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Encargos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Encargos.Activo = False
                    Encargos.Update()
                    CargarEncargos("1=1")
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
            CargarEncargos("1=1")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        ExportarExcel()
    End Sub

    Private Sub btnAutorizar_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        Dim IDEncargo As Integer
        Dim Encargos As New SivEncargos
        Dim Catalogos As New StbCatalogo
        Dim ValorCatalogo As New StbValorCatalogo
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de aprobar el encargo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDEncargo = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
                    Encargos.Retrieve(IDEncargo)
                    Catalogos.RetrieveByFilter("Nombre='ESTADOENCARGO'")
                    ValorCatalogo.RetrieveByFilter("objCatalogoID=" & Catalogos.StbCatalogoID & " AND Codigo='03'")
                    Encargos.ObjEstadoID = ValorCatalogo.StbValorCatalogoID
                    Encargos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Encargos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Encargos.Update()
                    CargarEncargos("1=1")
                    MsgBox("Encargo aprobado correctamente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Encargos = Nothing
            Catalogos = Nothing
            ValorCatalogo = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click
        Dim strEstado As String
        Dim Encargos As New SivEncargos
        Dim FilaActual As Integer
        Dim editPedidos As frmPedidosEdit
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
            strEstado = Me.dtEncargos.DefaultView.Item(FilaActual)("Estado").ToString

            If strEstado = "APROBADO" Then
                editPedidos = New frmPedidosEdit
                editPedidos.TypeGui = 3
                editPedidos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
                If editPedidos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarEncargos("1=1")
                End If
            Else
                MsgBox("El encargo debe estar aprobado para generar pedido?", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub


#End Region



End Class