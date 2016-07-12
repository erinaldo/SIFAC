'-- Autor: Gelmin Martínez
'-- Fecha: 10 Junio 2010, 12:05 Pm.
'-- Reporte de Diferencias entre repuestos solicitados y repuestos recepcionados

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion 'uso de clsProyecto, clsError

Public Class rptTransferenciaDiferencias
    Private objEncabezado As rptEncabezadoReportesSIFUM

#Region "Iniciar Reporte"
    Private Sub rptTransferenciaDiferencias_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.CargarEncabezado()
        Me.txtfechaDesde.Text = Me.Parameters("prmFechaDesde").Value
        Me.txtFechaHasta.Text = Me.Parameters("prmFechaHasta").Value
        Me.FormatearEtiquetasDetalle()
        'Me.FormatearTextboxDetalle()
    End Sub
#End Region

#Region "Cargar encabezado"
    Private Sub CargarEncabezado()
        Dim punto As Point
        Dim tamanoPapel As Integer = 11 'Tamaño horizontal de papel carta. ()
        Dim Desplazamiento As Integer = 3
        Try
            objEncabezado = New rptEncabezadoReportesSIFUM

            punto.Y = objEncabezado.lblFechaActual_Usuario.Location.Y
            punto.X = objEncabezado.lblFechaActual_Usuario.Location.X + Desplazamiento

            objEncabezado.lblFechaActual_Usuario.Location = punto
            objEncabezado.PrintWidth = tamanoPapel
            Me.srptEncabezado.Report = objEncabezado
            Me.srptEncabezado.Width = tamanoPapel

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Formatear Etiquetas de Detalle"
    'Coloca borde a todas las etiquetas de detalle
    Private Sub FormatearEtiquetasDetalle()
        clsReportes.Enmarcar(Me.lblCodigoRepuesto)
        clsReportes.Enmarcar(Me.lblCodProveedores)
        clsReportes.Enmarcar(Me.lblDescripcion)
        clsReportes.Enmarcar(Me.lblNoTransferencia)
        clsReportes.Enmarcar(Me.lblFechaSolicitud)
        clsReportes.Enmarcar(Me.lblSolicitadoA)
        clsReportes.Enmarcar(Me.lblCantidadSolicitada)
        clsReportes.Enmarcar(Me.lblCantidadRecibida)
        clsReportes.Enmarcar(Me.lblDiferencia)
        clsReportes.Enmarcar(Me.lblObservaciones)
    End Sub
#End Region

#Region "Formatear Textbox Detalle"
    Private Sub FormatearTextboxDetalle()
        Dim colorTextbox As New System.Drawing.Color

        colorTextbox = Color.Silver  'color gris
        clsReportes.BordeSuperior(Me.txtSivRepuestoID, colorTextbox)
        clsReportes.BordeSuperior(Me.txtCodigosProveedores, colorTextbox)
        clsReportes.BordeSuperior(Me.txtDescripcionCorta, colorTextbox)
        clsReportes.BordeSuperior(Me.txtSivTransferenciaID, colorTextbox)
        clsReportes.BordeSuperior(Me.txtFechasolicitud, colorTextbox)
        clsReportes.BordeSuperior(Me.txtSitioOrigen, colorTextbox)
        clsReportes.BordeSuperior(Me.txtCantidadSolicitada, colorTextbox)
        clsReportes.BordeSuperior(Me.txtCantidadRecibida, colorTextbox)
        clsReportes.BordeSuperior(Me.txtDiferencia, colorTextbox)
        clsReportes.BordeSuperior(Me.txtObservaciones, colorTextbox)
    End Sub
#End Region

End Class