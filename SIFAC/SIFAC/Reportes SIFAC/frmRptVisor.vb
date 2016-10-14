Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas

Public Class frmRptVisor

    Dim m_IDReporte As String
    Dim dtReporte As DataTable

    Property IDReporte() As String
        Get
            IDReporte = Me.m_IDReporte
        End Get
        Set(ByVal value As String)
            Me.m_IDReporte = value
        End Set
    End Property

    Private Sub frmRptVisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtReporte = New DataTable()
            Select Case Me.IDReporte
                Case "Descuentos"
                    Dim objjReporte As rptDescuentos = New rptDescuentos
                    dtReporte = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwRptDescuentosPlazos", ))
                    objjReporte.DataSource = dtReporte
                    visor.DocumentSource = objjReporte

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class