'-- Autor: Gelmin Martínez
'-- Fecha: Jueves 10 Junio 2010, 08:51 am.
'-- Reporte para mostrar los datos de UNA recepción de transferencia luego de ser registrada

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion 'uso de clsProyecto, clsError

Public Class rptTransferenciaRecepcion 

#Region "Atributos"
    Private m_EstadoAnulada As Boolean
    Private objEncabezado As rptEncabezadoReportesSIFUM
#End Region

#Region "Propiedades"
    Property EstadoAnulada() As Boolean
        Get
            EstadoAnulada = Me.m_EstadoAnulada
        End Get
        Set(ByVal value As Boolean)
            Me.m_EstadoAnulada = value
        End Set
    End Property
#End Region

#Region "Inicar Reporte"
    Private Sub rptTransferenciaDespacho_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.chkAnulada.Checked = Me.EstadoAnulada
        clsProyecto.MargenesRpt(Me)
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
