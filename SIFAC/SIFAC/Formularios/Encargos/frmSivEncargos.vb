Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos
Imports DAL
Imports DevExpress.XtraGrid.Views.Grid

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
            dtEncargos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CAST(0 AS BIT) AS Seleccionar,Numero, NumeroDetalle, Ruta, Fecha, Vendedor, Cliente, Estado, Categoria, CodigoProducto, NombreProducto, Cantidad, CostoPromedio, TotalCosto", "VWEncargosConsolidado", strFiltro & " ORDER BY Fecha DESC"), Me.SqlParametros)

            If Not dtEncargos Is Nothing Then
                'dtEncargos.PrimaryKey = New DataColumn() {Me.dtEncargos.Columns("NumeroDetalle")}
                dtEncargos.DefaultView.Sort = "Fecha"
                Me.grdEncargosMaster.DataSource = dtEncargos
                Me.grdEncargosMaster.Text = "Encargos (" & Me.dtEncargos.Rows.Count & ")"
            End If

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
        Dim intCantiadSeleccioanda As Integer = 0
        Dim foundRowsSeleccionadas() As Data.DataRow
        Try
            'Validar que solo este seleccionado un registro'

            foundRowsSeleccionadas = dtEncargos.Select("Seleccionar = 1")
            If foundRowsSeleccionadas.Length > 1 Then
                MsgBox("Se consulta un registro a la vez, seleccione unicamente 1", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Else
                FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle

                Me.Cursor = WaitCursor
                editEncargos = New frmSivEncargosEdit
                editEncargos.TypeGui = 1
                editEncargos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("Numero")
                If editEncargos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarEncargos("1=1")
                End If
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
        Dim foundRowsSeleccionadas() As Data.DataRow
        Try
            'Validar que solo este seleccionado un registro'
            foundRowsSeleccionadas = dtEncargos.Select("Seleccionar = 1")
            If foundRowsSeleccionadas.Length > 1 Then
                MsgBox("Se consulta un registro a la vez, seleccione unicamente 1", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Else
                FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
                Me.Cursor = WaitCursor
                editEncargos = New frmSivEncargosEdit
                editEncargos.TypeGui = 2
                editEncargos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("Numero")
                editEncargos.ShowDialog(Me)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        Dim IDEncargo As Integer
        Dim Encargos As New SivEncargosDetalle
        'Dim FilaActual As Integer
        Dim foundRowsSeleccionadas() As Data.DataRow
        Dim t As New TransactionManager
        Try

            'FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar los encargos seleccionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    t.BeginTran()
                    foundRowsSeleccionadas = dtEncargos.Select("Seleccionar = 1")
                    For Each row As DataRow In foundRowsSeleccionadas
                        IDEncargo = row("NumeroDetalle")
                        Encargos.Retrieve(IDEncargo)
                        Encargos.Delete()
                    Next
                    t.CommitTran()
                    MsgBox("Encargos anulados correctamente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    CargarEncargos("1=1")
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            t.RollbackTran()
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
        Dim foundRowsSeleccionadas() As Data.DataRow
        Dim t As New TransactionManager
        Try

            Select Case MsgBox("¿Está seguro de aprobar los encargos seleccionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    t.BeginTran()
                    foundRowsSeleccionadas = dtEncargos.Select("Seleccionar = 1")
                    For Each row As DataRow In foundRowsSeleccionadas
                        IDEncargo = row("Numero")
                        Encargos.Retrieve(IDEncargo)
                        Catalogos.RetrieveByFilter("Nombre='ESTADOENCARGO'")
                        ValorCatalogo.RetrieveByFilter("objCatalogoID=" & Catalogos.StbCatalogoID & " AND Codigo='03'")
                        Encargos.ObjEstadoID = ValorCatalogo.StbValorCatalogoID
                        Encargos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        Encargos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        Encargos.Update(t)
                    Next
                    t.CommitTran()
                    CargarEncargos("1=1")
                    MsgBox("Encargos aprobado correctamente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
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
        Dim strFiltro As String
        Dim Encargos As New SivEncargos
        Dim editPedidos As frmPedidosEdit
        Dim foundRowsSeleccionadas() As Data.DataRow
        Try
            strFiltro = String.Empty
            foundRowsSeleccionadas = dtEncargos.Select("Seleccionar = 1")
            For Each row As DataRow In foundRowsSeleccionadas
                strEstado = row("Estado").ToString

                If strEstado <> "APROBADO" Then
                    MsgBox("Los encargos seleccionados deben estar aprobados para generar pedido", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                Else
                    If strFiltro.Length = 0 Then
                        strFiltro = row("NumeroDetalle").ToString
                    Else
                        strFiltro = strFiltro & "," & row("NumeroDetalle").ToString
                    End If
                End If

            Next

            editPedidos = New frmPedidosEdit
            editPedidos.TypeGui = 3
            editPedidos.strFiltroEncargos = strFiltro
            If editPedidos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarEncargos("1=1")
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub


    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        Dim FilaActual As Integer
        Dim blnSeleccionar As Boolean
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked
            dtEncargos.DefaultView.Item(FilaActual)("Seleccionar") = blnSeleccionar
            dtEncargos.AcceptChanges()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region


    Private Sub grdEncargosMasterTabla_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grdEncargosMasterTabla.RowStyle
        Dim estado As String = ""
        Dim vista As GridView = sender

        Try
            estado = vista.GetRowCellValue(e.RowHandle, vista.Columns("Estado")).ToString().Trim()
        Catch ex As Exception

        End Try

        Select Case estado
            Case "REGISTRADO"
                e.Appearance.BackColor = Color.LightSteelBlue
                e.Appearance.BackColor2 = Color.White

            Case "APROBADO"
                e.Appearance.BackColor = Color.LimeGreen
                e.Appearance.BackColor2 = Color.White

            Case "ANULADO"
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.White

        End Select


    End Sub
End Class