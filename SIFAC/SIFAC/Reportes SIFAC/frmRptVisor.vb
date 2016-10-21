Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas

Public Class frmRptVisor

    Dim m_IDReporte As String
    Dim m_strFiltro As String
    Dim dtReporte As DataTable

    Property IDReporte() As String
        Get
            IDReporte = Me.m_IDReporte
        End Get
        Set(ByVal value As String)
            Me.m_IDReporte = value
        End Set
    End Property

    Property strFiltro() As String
        Get
            strFiltro = Me.m_strFiltro
        End Get
        Set(ByVal value As String)
            Me.m_strFiltro = value
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

                Case "Proveedores"
                    Dim objjReporte As rptDescuentos = New rptDescuentos
                    dtReporte = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID, objPersonaID, Proveedor, RUCID, FechaIngreso, Activo, Direccion, Telefono, Email, Contacto, EmailContacto, CelularContacto, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProveedor", ))
                    objjReporte.DataSource = dtReporte
                    visor.DocumentSource = objjReporte

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class