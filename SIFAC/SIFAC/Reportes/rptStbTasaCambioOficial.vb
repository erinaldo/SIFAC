''----------------------------------------------------------------------
''-- Nombre del Autor        : Michelle Valezka Reyes Tijerino.
''-- Fecha de Elaboraci�n    : 04 de Diciembre de 2008.
''----------------------------------------------------------------------
''--    Formulario de Reporte de Tasas de Cambio Oficial
''----------------------------------------------------------------------

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports DAL

Public Class rptStbTasaCambioOficial

#Region "Declaracion de Variables y Objetos"
    Dim objEncabezado As rptEncabezadoReportes
#End Region

#Region "Reporte"

    ' ---------------------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Michelle Valezka Reyes Tijerino
    ' Fecha de Elaboraci�n 		:	04 de Diciembre 2008
    ' Descripci�n			    :	Al cargar el Reporte se establecen los margenes del reporte.
    ' ---------------------------------------------------------------------------------------------------
    Private Sub rptStbTasaCambioOficial_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Try
            DatosReporte()
            Proyecto.Configuracion.clsProyecto.MargenesRpt(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ' ---------------------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Michelle Valezka Reyes Tijerino
    ' Fecha de Elaboraci�n 		:	04 de Diciembre 2008
    ' Descripci�n			    :	Establece la fecha y hora de creaci�n del Reporte asi como se manda
    '                           :   a llamar el subreporte para el establecer el encabezado de todos los
    '                           :   reportes
    ' ---------------------------------------------------------------------------------------------------
    Private Sub DatosReporte()
        Try
            objEncabezado = New rptEncabezadoReportes
            Me.srptEncabezado.Report = objEncabezado
            Me.txtFechaRep.Text = Format(clsProyecto.Conexion.FechaServidor.Date, "dd/MM/yyyy")
            Me.txtHora.Text = Format(clsProyecto.Conexion.FechaServidor.Hour & ":" & clsProyecto.Conexion.FechaServidor.Minute & ":" & clsProyecto.Conexion.FechaServidor.Second)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ' ---------------------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Michelle Valezka Reyes Tijerino
    ' Fecha de Elaboraci�n 		:	04 de Diciembre 2008
    ' Descripci�n			    :	Cargar los Datos del Nombre del Reporte
    ' ---------------------------------------------------------------------------------------------------
    Private Sub rptStbTasaCambioOficial_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData
        Try
            If Not Me.txtMonedaInvisible.Text = "" And Not Me.txtMesInvisible.Text = "" And Not Me.txtAnioInvisible.Text = "" Then
                Me.lblReporte.Text = "Tipos de cambio oficial del c�rdoba con respecto al " & Me.txtMonedaInvisible.Text
                Me.lblPeriodo.Text = "Per�odo  " & Me.txtMesInvisible.Text & " / " & Me.txtAnioInvisible.Text
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region
End Class
