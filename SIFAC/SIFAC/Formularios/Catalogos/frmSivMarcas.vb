﻿Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI

Public Class frmSivMarcas

#Region "Variables del formulario"
    Dim dtMarcas As DataTable
    Dim objseg As SsgSeguridad
    Dim dsMarcas As DataSet
    Dim boolAgregar, boolEditar, boolAnular, boolImprimir, boolBuscar, boolConsultar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtMarcas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("MarcaID,Nombre,Descripcion,Activa,FechaCreacion", "vwStbMarcas", ))
            dtMarcas.PrimaryKey = New DataColumn() {Me.dtMarcas.Columns("MarcaID")}
            dtMarcas.DefaultView.Sort = "MarcaID desc"
            Me.grdMarcas.DataSource = dtMarcas
            Me.grdMarcas.Text = "Marcas (" & Me.dtMarcas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmStbMarcas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarMarca")
            boolEditar = objseg.TienePermiso("EditarMarca")
            boolImprimir = objseg.TienePermiso("ImprimirMarca")
            boolConsultar = objseg.TienePermiso("ConsultarMarca")
            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtMarcas.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtMarcas.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtMarcas.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarMarcas As New frmMarcasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdMarcasTabla.GetSelectedRows()
                FilaActual = Me.grdMarcasTabla.GetDataSourceRowIndex(selectedRow(0))
                ConsultarMarcas.TypeGui = 2
                ConsultarMarcas.MarcaID = Me.dtMarcas.DefaultView.Item(FilaActual)("MarcaID")
                ConsultarMarcas.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarMarcas = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarMarcas As New frmMarcasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdMarcasTabla.GetSelectedRows()
                FilaActual = Me.grdMarcasTabla.GetDataSourceRowIndex(selectedRow(0))

                EditarMarcas.TypeGui = 1
                EditarMarcas.MarcaID = Me.dtMarcas.DefaultView.Item(FilaActual)("MarcaID")
                EditarMarcas.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarMarcas = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmSivMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editMarcas As frmMarcasEdit
        Try
            Me.Cursor = WaitCursor
            editMarcas = New frmMarcasEdit
            editMarcas.TypeGui = 0
            If editMarcas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                AplicarSeguridad()
                'Me.grdMarcasTabla.SelectRow = Me.dtMarcas.DefaultView.Find(editMarcas.intMarcaID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Try
            Me.Cursor = WaitCursor
            Editar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Try
            Me.Cursor = WaitCursor
            Consultar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim dtReporte As DataSet
        Try
            Dim objjReporte As New rptMarcas
            dtReporte = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("MarcaID, Nombre, Descripcion, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptMarcas", ))

            If dtReporte.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = dtReporte
                objjReporte.DataMember = dtReporte.Tables(0).TableName
                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region


End Class