Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmStbRutas

#Region "Declaracion de Variables Globales"
    Public DtRutas As DataTable
    Public objSeg As SsgSeguridad
    Public boolAgregar, boolEditar, boolConsultar, boolDesactivar, boolImprimir As Boolean
#End Region

#Region "Procedimientos del formulario"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Try
            DtRutas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbRutaID,Nombre,Descripcion,Cobrador,CargarDiferenciada,Activa", "vwStbRutas", ))
            DtRutas.PrimaryKey = New DataColumn() {Me.DtRutas.Columns("StbRutaID")}
            DtRutas.DefaultView.Sort = "StbRutaID"
            Me.grdRutas.DataSource = DtRutas
            Me.grdRutas.Text = "Rutas (" & Me.DtRutas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    ''Descripción:      Metodo encargado de aplicar la seguridad al formulario
    Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSTBRUTAS"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AgregarRuta")
            boolEditar = objSeg.TienePermiso("EditarRuta")
            boolConsultar = objSeg.TienePermiso("ConsultarRuta")
            boolDesactivar = objSeg.TienePermiso("InactivasRuta")
            boolImprimir = objSeg.TienePermiso("ImprimirRuta")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And DtRutas.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And DtRutas.Rows.Count > 0
            cmdDesactivar.Enabled = boolDesactivar And DtRutas.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And DtRutas.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
        End Try

    End Sub

#End Region

#Region "Eventos del formulario"

    Private Sub frmStbRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            CargarGrid()
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editRutas As frmStbRutasEdit
        Try
            Me.Cursor = WaitCursor
            editRutas = New frmStbRutasEdit
            editRutas.TypeGui = 0
            If editRutas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Dim editRutas As frmStbRutasEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdRutasTabla.FocusedRowHandle

            Me.Cursor = WaitCursor
            editRutas = New frmStbRutasEdit
            editRutas.TypeGui = 1
            editRutas.RutaID = Me.DtRutas.DefaultView.Item(FilaActual)("StbRutaID")
            If editRutas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim editRutas As frmStbRutasEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdRutasTabla.FocusedRowHandle
            Me.Cursor = WaitCursor
            editRutas = New frmStbRutasEdit
            editRutas.TypeGui = 2
            editRutas.RutaID = Me.DtRutas.DefaultView.Item(FilaActual)("StbRutaID")
            editRutas.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        Dim IDRuta As Integer
        Dim Rutas As New StbRutas
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdRutasTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar la Ruta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDRuta = Me.DtRutas.DefaultView.Item(FilaActual)("StbRutaID")
                    Rutas.Retrieve(IDRuta)
                    Rutas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Rutas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Rutas.Activa = False
                    Rutas.Update()
                    CargarGrid()
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
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region
End Class
