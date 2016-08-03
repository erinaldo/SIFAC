'-- Autor: Gelmin Martínez
'-- Fecha: 08 Junio 2010, 04:21 pm.
'-- Reporte de solicitudes de transferencia y detalle de repuestos solicitados agrupados por SitoOrigen - SitioDestino

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion 'uso de clsProyecto, clsError

Public Class rptTransferenciaSolicitudes
    Private objEncabezado As rptEncabezadoReportesSIFUM

#Region "Iniciar Reporte"
    Private Sub rptTransferenciaSolicitudes_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.CargarEncabezado()
        Me.txtfechaDesde.Text = Me.Parameters("prmFechaDesde").Value
        Me.txtFechaHasta.Text = Me.Parameters("prmFechaHasta").Value

        Me.FormatearEtiquetasDetalleRepuestos()
    End Sub
#End Region

#Region "Formatear Etiquetas Detalle de repuestos"
    Private Sub FormatearEtiquetasDetalleRepuestos()
        'Código repuesto
        Me.lblCodigoRepuesto.Border.RightStyle = BorderLineStyle.Solid
        Me.lblCodigoRepuesto.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblCodigoRepuesto.Border.TopStyle = BorderLineStyle.Solid
        Me.lblCodigoRepuesto.Border.BottomStyle = BorderLineStyle.Solid
        'Código proveedor
        Me.lblCodigoProveedor.Border.RightStyle = BorderLineStyle.Solid
        Me.lblCodigoProveedor.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblCodigoProveedor.Border.TopStyle = BorderLineStyle.Solid
        Me.lblCodigoProveedor.Border.BottomStyle = BorderLineStyle.Solid
        'Descripción
        Me.lblDescripcion.Border.RightStyle = BorderLineStyle.Solid
        Me.lblDescripcion.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblDescripcion.Border.TopStyle = BorderLineStyle.Solid
        Me.lblDescripcion.Border.BottomStyle = BorderLineStyle.Solid
        'Cantidad Solicitada
        Me.lblCantidadSolicitada.Border.RightStyle = BorderLineStyle.Solid
        Me.lblCantidadSolicitada.Border.LeftStyle = BorderLineStyle.Solid
        Me.lblCantidadSolicitada.Border.TopStyle = BorderLineStyle.Solid
        Me.lblCantidadSolicitada.Border.BottomStyle = BorderLineStyle.Solid
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
