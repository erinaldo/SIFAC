Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

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

            
            'visor.DocumentSource = objjReportes

            'visor.Refresh()

            '' Create a report instance, assigned to a Print Tool.
            'Dim pt As New ReportPrintTool(New rptDescuentos())

            '' Get the Print Tool's printing system.
            'Dim ps As PrintingSystemBase = pt.PrintingSystem

            '' Show the report's Print Preview.
            'pt.ShowPreview()

            '' Zoom the print preview, so that it fits the entire page.
            'ps.ExecCommand(PrintingSystemCommand.ViewWholePage)

            '' Invoke the Hand tool.
            'ps.ExecCommand(PrintingSystemCommand.HandTool, New Object() {True})

            '' Hide the Hand tool.
            'ps.ExecCommand(PrintingSystemCommand.HandTool, New Object() {False})

            'dtReporte = New DataTable()
            Select Case Me.IDReporte
                Case "Descuentos"
                    Dim objjReporte As rptDescuentos = New rptDescuentos
                    dtReporte = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwRptDescuentosPlazos", ))
                    objjReporte.DataSource = dtReporte
                    visor.DocumentSource = objjReporte
                    visor.Refresh()

                Case "Proveedores"
                    Dim objjReporte As rptDescuentos = New rptDescuentos
                    dtReporte = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID, objPersonaID, Proveedor, RUCID, FechaIngreso, Activo, Direccion, Telefono, Email, Contacto, EmailContacto, CelularContacto, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProveedor", ))
                    objjReporte.DataSource = dtReporte
                    visor.DocumentSource = objjReporte

                Case "Marcas"
                    Dim objjReporte As rptMarcas = New rptMarcas
                    dtReporte = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("MarcaID, Nombre, Descripcion, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptMarcas", ))
                    objjReporte.DataSource = dtReporte
                    visor.DocumentSource = objjReporte

                Case "Categorias"
                    Dim objjReporte As rptCategorias = New rptCategorias
                    dtReporte = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CategoriaID, Nombre, Descripcion, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptCategorias", ))
                    objjReporte.DataSource = dtReporte
                    visor.DocumentSource = objjReporte

                Case "Productos"
                    Dim objjReporte As rptProductos = New rptProductos
                    dtReporte = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, Producto, objMarcaID, objCategoriaID, Marca, Categoria, CostoPromedio, Precio_Credito, Precio_Contado, Margen_Utilidad_Contado, Margen_Utilidad_Credito, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProductos", strFiltro))
                    objjReporte.DataSource = dtReporte
                    visor.DocumentSource = objjReporte

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class