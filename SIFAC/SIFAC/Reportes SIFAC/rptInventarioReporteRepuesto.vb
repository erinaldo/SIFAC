'-- Autor: Gelmin Martínez
'-- Fecha: 15 Junio 2010, 10:09 am. 
'-- Reporte de Inventario 

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion 'uso de clsProyecto, clsError

Public Class rptInventarioReporteRepuesto

#Region "Atributos"
    Private objEncabezado As rptEncabezadoReportesSIFUM
    Private m_VerCostoU As Boolean
    Private m_VerPrecioU As Boolean
    Public dtDatos As DataTable
#End Region

#Region "Propiedades"
    Property VerCostoU() As Boolean
        Get
            VerCostoU = Me.m_VerCostoU
        End Get
        Set(ByVal value As Boolean)
            Me.m_VerCostoU = value
        End Set
    End Property

    Property VerPrecioU() As Boolean
        Get
            VerPrecioU = Me.m_VerPrecioU
        End Get
        Set(ByVal value As Boolean)
            Me.m_VerPrecioU = value
        End Set
    End Property

#End Region

#Region "Iniciar Reporte"
    Private Sub rptInventarioReporteRepuesto_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.CargarEncabezado()
        Me.FormatearEtiquetasDetalle()

        'Verificar si se muestran los costos
        Me.txtCostoU.Visible = Me.VerCostoU
        Me.txtPrecioU.Visible = Me.VerPrecioU
        Me.DataSource = Me.dtDatos
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

#Region "Formatear Etiquetas Detalle"
    Private Sub FormatearEtiquetasDetalle()
        clsReportes.Enmarcar(Me.lblCodigoBodega)
        clsReportes.Enmarcar(Me.lblBodega)
        clsReportes.Enmarcar(Me.lblUbicacion)
        clsReportes.Enmarcar(Me.lblExistencia)
    End Sub
#End Region

End Class