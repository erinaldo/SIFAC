'-- Autor: Milagros Ruiz Oporta
'-- Fecha: Martes 15 Junio 2010
'-- Reporte para mostrar los datos de los Repuestos

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion

Public Class rptSivRepuestos 

#Region "Atributos"
    Private objEncabezado As rptEncabezadoReportesSIFUM
#End Region

#Region "Iniciar Reporte"
    Private Sub rptSivRepuestos_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        clsProyecto.MargenesRpt(Me)
        Me.CargarEncabezado()
    End Sub
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
   
   
    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format

    End Sub

    Private Sub Pie_Reporte_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pie_Reporte.Format

    End Sub
End Class
