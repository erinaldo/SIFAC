Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI

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
            dtCajas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccCajaID,Nombre,NombreCompleto,Ubicacion", "vwSccCajas", ))
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
        Dim EditarMarcas As New frmMarcasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdCajasTabla.GetSelectedRows()
                FilaActual = Me.grdCajasTabla.GetDataSourceRowIndex(selectedRow(0))

                EditarMarcas.TypeGui = 1
                EditarMarcas.MarcaID = Me.dtCajas.DefaultView.Item(FilaActual)("SccCajaID")
                EditarMarcas.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarMarcas = Nothing
        End Try
    End Sub


#End Region


    Private Sub frmSccConfiguracionCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class