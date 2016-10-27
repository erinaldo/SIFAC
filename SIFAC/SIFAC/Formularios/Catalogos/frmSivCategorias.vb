Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors

Public Class frmSivCategorias


#Region "Variables del formulario"
    Dim dtCategorias As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtCategorias = BO.SivCategorias.RetrieveDT("1=1")
            dtCategorias.PrimaryKey = New DataColumn() {Me.dtCategorias.Columns("CategoriaID")}
            dtCategorias.DefaultView.Sort = "CategoriaID"
            Me.grdCategorias.DataSource = dtCategorias
            Me.grdCategorias.Text = "Categorias (" & Me.dtCategorias.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSivCategorias"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarCategoria")
            boolConsultar = objseg.TienePermiso("ConsultarCategoria")
            boolEditar = objseg.TienePermiso("EditarCategoria")
            boolImprimir = objseg.TienePermiso("ImprimirCategoria")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtCategorias.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtCategorias.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtCategorias.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try

    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarCategoria As New frmSivCategoriasEditar
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdCategoriasTabla.FocusedRowHandle
                ConsultarCategoria.TypeGui = 2
                ConsultarCategoria.CategoriaID = Me.dtCategorias.DefaultView.Item(FilaActual)("CategoriaID")
                ConsultarCategoria.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarCategoria = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarCategoria As New frmSivCategoriasEditar
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdCategoriasTabla.FocusedRowHandle
                EditarCategoria.TypeGui = 1
                EditarCategoria.CategoriaID = Me.dtCategorias.DefaultView.Item(FilaActual)("CategoriaID")
                EditarCategoria.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarCategoria = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmSivCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub


    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editCategoria As frmSivCategoriasEditar
        Try
            Me.Cursor = WaitCursor
            editCategoria = New frmSivCategoriasEditar
            editCategoria.TypeGui = 0
            If editCategoria.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            editCategoria = Nothing
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

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim objReporte As frmRptVisor
        Try
            objReporte = New frmRptVisor
            objReporte.IDReporte = "Categorias"
            objReporte.Show()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    
End Class