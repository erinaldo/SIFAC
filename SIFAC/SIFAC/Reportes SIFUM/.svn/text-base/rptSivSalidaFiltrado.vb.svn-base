Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion

Public Class rptSivSalidaFiltrado

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
   
    Private Sub rptSivSalidaFiltrado_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        clsProyecto.MargenesRpt(Me)
        Me.CargarEncabezado()
    End Sub

  
End Class
