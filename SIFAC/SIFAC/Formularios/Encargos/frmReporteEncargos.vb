Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos.ClsCatalogos
Imports DevExpress.XtraReports.UI

Public Class frmReporteEncargos

#Region "Declaracion de Variables"
    Public dtVendedor, dtEstados, dtRptProveedor As DataTable
#End Region

#Region "Cargar Estados"
    Public Sub CargarEstados()
        Try
            dtEstados = ObtenerValCat("ESTADOENCARGO")
            With cboEstado
                .DataSource = dtEstados
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Vendedores"
    Private Sub CargarVendedor()
        dtVendedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("NombreVendedor, SrhEmpleadoID ", "vwSfaVendedorFactura", "1=1"))
        With Me.cmbVendedor
            .DataSource = Me.dtVendedor
            .ValueMember = "SrhEmpleadoID"
            .DisplayMember = "NombreVendedor"
            .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
            .ExtendRightColumn = True
        End With

    End Sub
#End Region

#Region "Operaciones"

    Private Sub Imprimir()
        Dim ds As New DataSet
        Dim objjReporte As New rptEncargos()

        If Me.rbProveedor.Checked Then
            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Ruta, Empleado, Categoria, Producto, Cantidad, CostoPromedio, TotalCosto, Observaciones, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwEncargosExcel", "SrhEmpleadoID=" & cmbVendedor.SelectedValue))
        End If
        If Me.rbTodos.Checked Then
            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Ruta, Empleado, Categoria, Producto, Cantidad, CostoPromedio, TotalCosto, Observaciones, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwEncargosExcel", "1=1"))
        End If

        If ds.Tables(0).Rows.Count <> 0 Then
            objjReporte.DataSource = ds
            objjReporte.DataMember = ds.Tables(0).TableName
            Dim pt As New ReportPrintTool(objjReporte)
            pt.ShowPreview()
        Else
            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If

    End Sub

#End Region

#Region "Eventos"

    Private Sub frmReporteEncargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CargarVendedor()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click, cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            If Me.rbProveedor.Checked And Me.cmbVendedor.Text = "" Then
                MsgBox("Seleccione un vendedor", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.cmbVendedor.Focus()
                Exit Sub
            End If
            Imprimir()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

End Class