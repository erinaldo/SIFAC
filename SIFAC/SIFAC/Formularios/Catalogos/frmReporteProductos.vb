Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO

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
        Dim objReporte As frmRptVisor
        Try
            objReporte = New frmRptVisor
            objReporte.IDReporte = "Productos"

            If rbTodos.Checked Then
                objReporte.strFiltro = "1=1"
            Else
                If (cboCategoria.SelectedValue = 0 Or cboCategoria.Text = "") And (cboMarca.SelectedValue <> 0 And cboMarca.Text <> "") Then
                    objReporte.strFiltro = "objMarcaID=" & cboMarca.SelectedValue
                Else
                    If (cboCategoria.SelectedValue <> 0 And cboCategoria.Text <> "") And (cboMarca.SelectedValue = 0 Or cboMarca.Text = "") Then
                        objReporte.strFiltro = "objCategoriaID=" & cboCategoria.SelectedValue
                    Else
                        If (cboCategoria.SelectedValue <> 0 And cboCategoria.Text <> "") And (cboMarca.SelectedValue <> 0 And cboMarca.Text <> "") Then
                            objReporte.strFiltro = "objCategoriaID=" & cboCategoria.SelectedValue & " AND objMarcaID=" & cboMarca.SelectedValue
                        End If
                    End If
                End If
            End If
            objReporte.Show()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    
End Class