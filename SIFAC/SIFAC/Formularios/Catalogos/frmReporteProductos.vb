Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frmReporteProductos

#Region "Declaración de Variables propias del formulario"
    Public dtCategorias, dtMarcas As DataTable

#End Region

#Region "Inicializar GUI"

#Region "Cargar Combo Categorias"

    Private Sub CargarCategorias()
        Try
            dtCategorias = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CategoriaID, Nombre", "vwRptCategorias", "1=1"))
            cboCategoria.DataSource = Me.dtCategorias
            cboCategoria.DisplayMember = "Nombre"
            cboCategoria.ValueMember = "CategoriaID"
            cboCategoria.Splits(0).DisplayColumns("CategoriaID").Visible = False
            cboCategoria.ExtendRightColumn = True
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#Region "Cargar Combo Marcas"

    Private Sub CargarMarcas()
        Try
            dtMarcas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("MarcaID, Nombre", "vwRptMarcas", "1=1"))
            cboMarca.DataSource = Me.dtMarcas
            cboMarca.DisplayMember = "Nombre"
            cboMarca.ValueMember = "MarcaID"
            cboMarca.Splits(0).DisplayColumns("MarcaID").Visible = False
            cboMarca.ExtendRightColumn = True
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#End Region

#Region "Eventos"
    Private Sub frmReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMarcas()
        CargarCategorias()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim ds As DataSet
        Dim strFiltro As String = String.Empty
        Try
            Dim objjReporte As New rptProductos()

            If ((Not rbTodos.Checked) And (cboCategoria.SelectedValue = 0 Or cboCategoria.Text = "") And (cboMarca.SelectedValue = 0 Or cboMarca.Text = "")) Then
                MsgBox("Debe seleccionar un criterio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Else
                If rbTodos.Checked Then
                    strFiltro = "1=1"
                Else
                    If (cboCategoria.SelectedValue = 0 Or cboCategoria.Text = "") And (cboMarca.SelectedValue <> 0 And cboMarca.Text <> "") Then
                        strFiltro = "objMarcaID=" & cboMarca.SelectedValue
                    Else
                        If (cboCategoria.SelectedValue <> 0 And cboCategoria.Text <> "") And (cboMarca.SelectedValue = 0 Or cboMarca.Text = "") Then
                            strFiltro = "objCategoriaID=" & cboCategoria.SelectedValue
                        Else
                            If (cboCategoria.SelectedValue <> 0 And cboCategoria.Text <> "") And (cboMarca.SelectedValue <> 0 And cboMarca.Text <> "") Then
                                strFiltro = "objCategoriaID=" & cboCategoria.SelectedValue & " AND objMarcaID=" & cboMarca.SelectedValue
                            End If
                        End If
                    End If
                End If

                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Codigo, Producto, objMarcaID, objCategoriaID, Marca, Categoria, CostoPromedio, Precio_Credito, Precio_Contado, Margen_Utilidad_Contado, Margen_Utilidad_Credito, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProductos", strFiltro))
                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        Try
            If rbTodos.Checked Then
                cboCategoria.Text = String.Empty
                cboMarca.Text = String.Empty
            End If
           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

#End Region


   
   
End Class