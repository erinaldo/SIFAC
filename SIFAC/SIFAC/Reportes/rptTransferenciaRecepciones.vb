'-- Autor: Gelmin Mart�nez
'-- Fecha: 10 Junio 2010, 10:05 am.
'-- Reporte de recepciones de transferencia y detalle de repuestos recibidos agrupados por SitoOrigen - SitioDestino

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion 'uso de clsProyecto, clsError

Public Class rptTransferenciaRecepciones
    Private objEncabezado As rptEncabezadoReportesSIFUM

#Region "Iniciar Reporte"
    Private Sub rptTransferenciaRecepciones_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.CargarEncabezado()
        Me.txtfechaDesde.Text = Me.Parameters("prmFechaDesde").Value
        Me.txtFechaHasta.Text = Me.Parameters("prmFechaHasta").Value

        Me.FormatearEtiquetasDetalleRepuestos()
    End Sub
#End Region

#Region "Formatear Etiquetas Detalle de repuestos"
    Private Sub FormatearEtiquetasDetalleRepuestos()
        'C�digo repuesto
        Me.lblCodigoRepuesto.Border.RightStyle = BorderLineStyle.Solid
        Me.lblCodigoRepuesto.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblCodigoRepuesto.Border.TopStyle = BorderLineStyle.Solid
        Me.lblCodigoRepuesto.Border.BottomStyle = BorderLineStyle.Solid
        'C�digo proveedor
        Me.lblCodigoProveedor.Border.RightStyle = BorderLineStyle.Solid
        Me.lblCodigoProveedor.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblCodigoProveedor.Border.TopStyle = BorderLineStyle.Solid
        Me.lblCodigoProveedor.Border.BottomStyle = BorderLineStyle.Solid
        'Descripci�n
        Me.lblDescripcion.Border.RightStyle = BorderLineStyle.Solid
        Me.lblDescripcion.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblDescripcion.Border.TopStyle = BorderLineStyle.Solid
        Me.lblDescripcion.Border.BottomStyle = BorderLineStyle.Solid
        'Cantidad Solicitada
        Me.lblCantidadSolicitada.Border.RightStyle = BorderLineStyle.Solid
        Me.lblCantidadSolicitada.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblCantidadSolicitada.Border.TopStyle = BorderLineStyle.Solid
        Me.lblCantidadSolicitada.Border.BottomStyle = BorderLineStyle.Solid
        'Cantidad Despachada
        Me.lblCantidadDespachada.Border.RightStyle = BorderLineStyle.Solid
        Me.lblCantidadDespachada.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblCantidadDespachada.Border.TopStyle = BorderLineStyle.Solid
        Me.lblCantidadDespachada.Border.BottomStyle = BorderLineStyle.Solid
        'Cantidad Recibida
        Me.lblCantidadRecibida.Border.RightStyle = BorderLineStyle.Solid
        Me.lblCantidadRecibida.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblCantidadRecibida.Border.TopStyle = BorderLineStyle.Solid
        Me.lblCantidadRecibida.Border.BottomStyle = BorderLineStyle.Solid
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
