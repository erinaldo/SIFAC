'-- Autor: Milagros Ruiz Oporta
'-- Fecha: Miercoles 16 Junio 2010
'-- Reporte para mostrar la hoja de Salida

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion
Imports DAL
Imports SCCUM.BO.clsConsultas
Imports SCCUM.BO

Public Class rptSalidaBodega 

#Region "Atributos"
    Private objEncabezado As rptEncabezadoReportesSIFUM
#End Region

#Region "Cargar Encabezado"
    Private Sub CargarEncabezado()
        Try
            objEncabezado = New rptEncabezadoReportesSIFUM
            Me.srpEncabezado.Report = objEncabezado

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Usuario"
    Private Sub CargarUsuario()
        Dim dtUsuario As New DataTable
        Dim sSQL As String

        Try
            sSQL = clsConsultas.ObtenerConsultaGeneral("NombreEmpleado", "vwUsuarioEmpleado", "Login ='" & clsProyecto.Conexion.Usuario & "'")
            dtUsuario = DAL.SqlHelper.ExecuteQueryDT(sSQL)

            If (dtUsuario.Rows.Count <> 0) Then
                Me.txtUsuario.Text = dtUsuario.DefaultView.Item(0)("NombreEmpleado").ToString
                Me.txtUsuario1.Text = dtUsuario.DefaultView.Item(0)("NombreEmpleado").ToString
            Else
                Me.txtUsuario1.Visible = False
                Me.txtUsuario.Visible = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region

    Private Sub rptSalidaBodega_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        clsProyecto.MargenesRpt(Me)
        Me.CargarEncabezado()
        Me.CargarUsuario()
    End Sub
 
End Class
