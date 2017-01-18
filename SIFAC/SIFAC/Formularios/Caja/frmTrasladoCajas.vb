Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmTrasladoCajas

#Region "Declaracion de Variables Globales"

    Public DtTraslados As DataTable
    Public objSeg As SsgSeguridad
    Public boolAgregar, boolEditar, boolConsultar, boolDesactivar, boolAprobar As Boolean
#End Region

#Region "Procedimientos del formulario"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        'Dim ds As DataSet
        Try
            DtTraslados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SfaTranferenciaID, objCajaOrigenID, objCajeroOrigen, objCajaDestinoID, objCajeroDestino, Monto, Comentarios, Aprobada, AutorizadoPor, FechaAprobacion, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion", "vwTransferenciasCajas", "1=1"))
            DtTraslados.PrimaryKey = New DataColumn() {Me.DtTraslados.Columns("SfaTranferenciaID")}
            DtTraslados.DefaultView.Sort = "SfaTranferenciaID"
            Me.grdRutas.DataSource = DtTraslados
            Me.grdRutas.Text = "Traslados de efectivo (" & Me.DtTraslados.Rows.Count & ")"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


    ''Descripción:      Metodo encargado de aplicar la seguridad al formulario
    Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "frmTrasladoCajas"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AgregarTrasladoEfectivo")
            boolEditar = objSeg.TienePermiso("EditarTrasladoEfectivo")
            boolConsultar = objSeg.TienePermiso("ConsultarTrasladoEfectivo")
            boolDesactivar = objSeg.TienePermiso("InactivasTrasladoEfectivo")
            boolAprobar = objSeg.TienePermiso("AprobarTrasladoEfectivo")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And DtTraslados.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And DtTraslados.Rows.Count > 0
            cmdDesactivar.Enabled = boolDesactivar And DtTraslados.Rows.Count > 0
            cmdAprobar.Enabled = boolAprobar And DtTraslados.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
        End Try

    End Sub

#End Region

#Region "Eventos del formulario"
    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Try
            CargarGrid()
            AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        Dim IDTraslado As Integer
        Dim Traslado As New SfaTransferenciaCaja
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdRutasTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar el traslado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDTraslado = Me.DtTraslados.DefaultView.Item(FilaActual)("SfaTranferenciaID")
                    Traslado.Retrieve(IDTraslado)
                    Traslado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Traslado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Traslado.Activa = False
                    Traslado.Update()
                    CargarGrid()
                    AplicarSeguridad()
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