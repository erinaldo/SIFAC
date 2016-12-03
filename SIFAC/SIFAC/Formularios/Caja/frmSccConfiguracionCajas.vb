Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIFAC.BO

Public Class frmSccConfiguracionCajas

#Region "Variables del formulario"
    Dim dtCajas As DataTable
    Dim objseg As SsgSeguridad
    Dim dsMarcas As DataSet
    Dim boolAgregar, boolEditar, boolAnular, boolImprimir, boolBuscar As Boolean
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtCajas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccCajaID,Nombre,NombreCompleto,Ubicacion,Codigo", "vwSccCajas", ))
            dtCajas.PrimaryKey = New DataColumn() {Me.dtCajas.Columns("SccCajaID")}
            dtCajas.DefaultView.Sort = "SccCajaID"
            Me.grdCajas.DataSource = dtCajas
            Me.grdCajas.Text = "Cajas (" & Me.dtCajas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSccConfiguracionCajas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarCaja")
            boolEditar = objseg.TienePermiso("EditarCaja")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtCajas.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarCaja As New frmSccConfiguracionCajasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdCajasTabla.GetSelectedRows()
                FilaActual = Me.grdCajasTabla.GetDataSourceRowIndex(selectedRow(0))
                ConsultarCaja.TypeGui = 2
                ConsultarCaja.CajaID = Me.dtCajas.DefaultView.Item(FilaActual)("SccCajaID")
                ConsultarCaja.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarCaja = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarCajas As New frmSccConfiguracionCajasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdCajasTabla.GetSelectedRows()
                FilaActual = Me.grdCajasTabla.GetDataSourceRowIndex(selectedRow(0))

                EditarCajas.TypeGui = 1
                EditarCajas.CajaID = Me.dtCajas.DefaultView.Item(FilaActual)("SccCajaID")
                EditarCajas.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarCajas = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmSccConfiguracionCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editConfiguracion As frmSccConfiguracionCajasEdit
        Try
            Me.Cursor = WaitCursor
            editConfiguracion = New frmSccConfiguracionCajasEdit
            editConfiguracion.TypeGui = 0
            If editConfiguracion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                AplicarSeguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            editConfiguracion = Nothing
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

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Dim IDCaja As Integer
        Dim Cajas As New SccCajas
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdCajasTabla.GetSelectedRows()
            FilaActual = Me.grdCajasTabla.GetDataSourceRowIndex(selectedRow(0))

            Select Case MsgBox("¿Está seguro de Inactivar la Caja?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDCaja = Me.dtCajas.DefaultView.Item(FilaActual)("SccCajaID")
                    Cajas.Retrieve(IDCaja)
                    Cajas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Cajas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Cajas.Activa = False
                    Cajas.Update()
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

#End Region


End Class