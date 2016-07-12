''----------------------------------------------------------------------
''-- Nombre del Autor        : Michelle Valezka Reyes Tijerino.
''-- Fecha de Elaboración    : 06 de Noviembre del 2007.
''----------------------------------------------------------------------
''--    Formulario de Reporte de Empleado Cargo
''----------------------------------------------------------------------
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion

Public Class rptStbCatalogosValores

#Region "Declaracion de Variables y Objetos"
    Dim objEncabezado As rptEncabezadoReportes
#End Region

#Region "Reporte"

    ' ---------------------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Michelle Valezka Reyes Tijerino
    ' Fecha de Elaboración 		:	06 de Noviembre de 2007
    ' Descripción			    :	Al cargar el Reporte se establecen los margenes del reporte.
    ' ---------------------------------------------------------------------------------------------------
    Private Sub rptSrhEmpleadoCargo_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Try
            DatosReporte()
            clsProyecto.MargenesRpt(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



    ' ---------------------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Michelle Valezka Reyes Tijerino
    ' Fecha de Elaboración 		:	06 de Noviembre de 2007
    ' Descripción			    :	Establece la fecha y hora de creación del Reporte asi como se manda
    '                           :   a llamar el subreporte para el establecer eñl encabezado de todos los
    '                           :   reportes
    ' ---------------------------------------------------------------------------------------------------
    Private Sub DatosReporte()
        Try
            objEncabezado = New rptEncabezadoReportes
            Me.srptEncabezado.Report = objEncabezado
            Me.txtFecha.Text = Format(Now.Date, "dd/MM/yyyy")
            Me.txtHora.Text = Format(Now.Hour & ":" & Now.Minute & ":" & Now.Second)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

End Class
