Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSccDescuento

#Region "Declaracion de Variables Globales"
    Public DtDescuento As DataTable
    Public objSeg As SsgSeguridad
    Public boolAgregar, boolEditar, boolConsultar, boolDesactivar, boolImprimir As Boolean
#End Region

#Region "Procedimientos del formulario"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Try
            DtDescuento = SccDescuentoPlazo.RetrieveDT("Activo=1", "SccDescuentoID, PlazoPago, DescuentoMaximo, DescuentoMinimo")
            DtDescuento.PrimaryKey = New DataColumn() {Me.DtDescuento.Columns("SccDescuentoID")}
            DtDescuento.DefaultView.Sort = "SccDescuentoID"
            Me.grdDescuento.DataSource = DtDescuento
            Me.grdDescuento.Text = "Rutas (" & Me.DtDescuento.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
        End Try

    End Sub

    ''Descripción:      Metodo encargado de aplicar la seguridad al formulario
    Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSCCDESCUENTOS"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AgregarDescuento")
            boolEditar = objSeg.TienePermiso("EditarDescuento")
            boolConsultar = objSeg.TienePermiso("ConsultarDescuento")
            boolDesactivar = objSeg.TienePermiso("InactivasDescuento")
            boolImprimir = objSeg.TienePermiso("ImprimirDescuento")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And DtDescuento.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And DtDescuento.Rows.Count > 0
            cmdDesactivar.Enabled = boolDesactivar And DtDescuento.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And DtDescuento.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
        End Try

    End Sub

#End Region

#Region "Eventos del formulario"

    Private Sub frmSccDescuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim editDescuento As frmSccDescuentoEdit
        Try
            Me.Cursor = WaitCursor
            editDescuento = New frmSccDescuentoEdit
            editDescuento.TypeGui = 0
            If editDescuento.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Dim editDescuento As frmSccDescuentoEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdDescuentoTabla.FocusedRowHandle

            Me.Cursor = WaitCursor
            editDescuento = New frmSccDescuentoEdit
            editDescuento.TypeGui = 1
            editDescuento.DescuentoID = Me.DtDescuento.DefaultView.Item(FilaActual)("SccDescuentoID")
            If editDescuento.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim editDescuento As frmSccDescuentoEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdDescuentoTabla.FocusedRowHandle
            Me.Cursor = WaitCursor
            editDescuento = New frmSccDescuentoEdit
            editDescuento.TypeGui = 2
            editDescuento.DescuentoID = Me.DtDescuento.DefaultView.Item(FilaActual)("SccDescuentoID")
            editDescuento.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        Dim IDDescuento As Integer
        Dim Descuento As New SccDescuentoPlazo
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdDescuentoTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar la Configuracion de Descuento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDDescuento = Me.DtDescuento.DefaultView.Item(FilaActual)("SccDescuentoID")
                    Descuento.Retrieve(IDDescuento)
                    Descuento.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Descuento.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Descuento.Activo = False
                    Descuento.Update()
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