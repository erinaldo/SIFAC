''----------------------------------------------------------------------
''-- Autor : Gelmin Martínez
''-- Fecha : 08 de Junio 2010, 05:22 pm.
''----------------------------------------------------------------------
''--    Formulario de Encabezado General para Reportes de SIFUM
''----------------------------------------------------------------------
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Catalogos.Datos 'Uso de clsCatalogos
Imports Proyecto.Configuracion 'Uso de clsProyecto, clsError

Public Class rptEncabezadoReportesSIFUM

#Region "Iniciar Reporte"
    Private Sub rptEncabezadoReportes_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Try
            clsProyecto.MargenesRpt(Me)
            Me.CargarDatosEncabezado()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar datos encabazado"
    'Cargar datos de los parámetros de la base de datos 
    Private Sub CargarDatosEncabezado()
        Try
            Me.lblEmpresa.Text = ClsCatalogos.GetValorParametro("EMPRESA")
            Me.lblDirEmpresa.Text = ClsCatalogos.GetValorParametro("DireccionEmpresa")
            Me.lblTelefonosEmpresa.Text = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
            Me.lblEmailEmpresa.Text = ClsCatalogos.GetValorParametro("EMAIL")
            Me.lblFechaActual_Usuario.Text = clsProyecto.Conexion.FechaServidor.Date + " , " + clsProyecto.Conexion.Usuario
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

End Class
