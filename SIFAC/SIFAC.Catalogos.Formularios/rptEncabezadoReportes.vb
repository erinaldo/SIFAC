''----------------------------------------------------------------------
''-- Nombre del Autor        : Michelle Valezka Reyes Tijerino.
''-- Fecha de Elaboración    : 07 de Noviembre del 2007.
''----------------------------------------------------------------------
''--    Formulario de Encabezado General para todos los Reportes
''----------------------------------------------------------------------
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports DAL

Public Class rptEncabezadoReportes

#Region "Reporte"

    ' ---------------------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Michelle Valezka Reyes Tijerino
    ' Fecha de Elaboración 		:	07 de Noviembre de 2007
    ' Descripción			    :	Al cargar el Reporte se establecen los margenes.
    ' ---------------------------------------------------------------------------------------------------
    Private Sub rptEncabezadoReportes_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Try
            clsProyecto.MargenesRpt(Me)
            CargarDatos()
            CargarImagen()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ' ---------------------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Michelle Valezka Reyes Tijerino
    ' Fecha de Elaboración 		:	10 de Noviembre de 2007
    ' Descripción			    :	Carga el Logo de la Empresa cuyo path se encuentra almacenada en la 
    '                           :   en la Tabla StbParametro con el Nombre de 'LogoEmpresa' y lo muestra
    '                           :   en la herramienta picLogo. Carga tambien el Nombre de la Empresa, 
    '                           :   almacenado en la misma tabla bajo el nombre 'NombreEmpresa' y se
    '                           :   manda a imprimir en pantalla en el lblNombreEmpresa.
    ' ---------------------------------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim dtParametro As DataTable
        Dim strCampos As String
        Dim strFiltro As String
        Dim strSQL As String
        Try
            '-- Cargar Nombre de la Empresa
            strCampos = " Nombre, Valor "
            strFiltro = " Nombre='NombreSistema' "
            strSQL = ClsCatalogos.ObtenerValorParametro(strCampos, strFiltro)
            dtParametro = SqlHelper.ExecuteQueryDT(strSQL)
            If dtParametro.Rows.Count > 0 Then
                Me.lblNombreEmpresa.Text = dtParametro.Rows(0).Item("Valor")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ' ---------------------------------------------------------------------------------------------------
    ' Nombre del Autor    		:	Michelle Valezka Reyes Tijerino
    ' Fecha de Elaboración 		:	10 de Noviembre de 2007
    ' Descripción			    :	Carga la Imagen. Si la ruta no es encontrada, captura el error y no 
    '                           :   se carga nada en el cuadro de imagen
    ' ---------------------------------------------------------------------------------------------------
    Private Sub CargarImagen()
        Dim dtParametro As DataTable
        Dim strCampos As String
        Dim strFiltro As String
        Dim strSQL As String
        Try
            '-- Cargar Imagen
            strCampos = " Nombre, Valor "
            strFiltro = " Nombre='Logo' "
            strSQL = ClsCatalogos.ObtenerValorParametro(strCampos, strFiltro)
            dtParametro = SqlHelper.ExecuteQueryDT(strSQL)
            If dtParametro.Rows.Count > 0 Then
                Me.picLogo.Image = System.Drawing.Image.FromFile(dtParametro.Rows(0).Item("Valor"))
            End If
        Catch ex As Exception
            If Not ex.Source = "System.Drawing" Then
                clsError.CaptarError(ex)
            End If
        End Try
    End Sub

#End Region

End Class
