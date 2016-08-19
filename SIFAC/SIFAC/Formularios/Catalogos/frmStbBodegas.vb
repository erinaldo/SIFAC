Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors


Public Class frmStbBodegas


#Region "Variables del formulario"
    Dim dtBodegas As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtBodegas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbBodegaID,Bodega,Codigo,Activo,Ciudad,Jefe", "vwBodegas", ))
            dtBodegas.PrimaryKey = New DataColumn() {Me.dtBodegas.Columns("StbBodegaID")}
            dtBodegas.DefaultView.Sort = "StbBodegaID"
            Me.grdBodegas.DataSource = dtBodegas
            Me.grdBodegas.Text = "Bodegas (" & Me.dtBodegas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "FRMSTBBODEGAS"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarBodega")
            boolConsultar = objseg.TienePermiso("ConsultarBodega")
            boolEditar = objseg.TienePermiso("EditarBodega")
            boolImprimir = objseg.TienePermiso("ImprimirBodegas")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtBodegas.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtBodegas.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtBodegas.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarBodegas As New frmBodegasEditar
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdBodegasTabla.FocusedRowHandle
                ConsultarBodegas.TypeGui = 3
                ConsultarBodegas.BodegaID = Me.dtBodegas.DefaultView.Item(FilaActual)("StbBodegaID")
                ConsultarBodegas.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarBodegas = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarBodega As New frmBodegasEditar
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdBodegasTabla.FocusedRowHandle
                EditarBodega.TypeGui = 2
                EditarBodega.BodegaID = Me.dtBodegas.DefaultView.Item(FilaActual)("StbBodegaID")
                EditarBodega.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarBodega = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editbodega As frmBodegasEditar
        Try
            Me.Cursor = WaitCursor
            editbodega = New frmBodegasEditar
            editbodega.TypeGui = 1
            If editbodega.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Try
            Me.Cursor = WaitCursor
            Editar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Try
            Me.Cursor = WaitCursor
            Consultar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub
#End Region


End Class