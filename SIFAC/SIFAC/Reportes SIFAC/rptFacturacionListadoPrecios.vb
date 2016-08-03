'-- Autor: Gelmin Martínez
'-- Fecha: 11 Junio 2010, 02:08 pm. (MUNDIAL FUTBOL)
'-- Reporte de Listado de Precios

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion 'uso de clsProyecto, clsError

Public Class rptFacturacionListadoPrecios
    Private objEncabezado As rptEncabezadoReportesSIFUM

#Region "Iniciar Reporte"
    Private Sub rptFacturacionListadoPrecios_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.CargarEncabezado()
    End Sub
#End Region

#Region "Cargar encabezado"
    Private Sub CargarEncabezado()
        Try
            objEncabezado = New rptEncabezadoReportesSIFUM
            Me.srptEncabezado.Report = objEncabezado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

End Class
