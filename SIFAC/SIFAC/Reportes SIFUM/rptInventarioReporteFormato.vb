'-- Autor: Gelmin Martínez
'-- Fecha: 15 Junio 2010, 04:56 pm. 
'-- Reporte de Inventario en [Formato Levantamiento de Inventario] 

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion 'uso de clsProyecto, clsError

Public Class rptInventarioReporteFormato
    Private Const ALTO = 0.1875

#Region "Atributos"
    Private objEncabezado As rptEncabezadoReportesSIFUM
#End Region

#Region "Iniciar Reporte"
    Private Sub rptInventarioReporteFormato_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
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

