Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmStbRutas

#Region "Declaracion de Variables Globales"

    Public DtRutas As DataTable
    Public objSeg As SsgSeguridad
    Public boolAgregar, boolEditar, boolConsultar, boolDesactivar, boolImprimir, boolReubicar As Boolean
#End Region

#Region "Procedimientos del formulario"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        'Dim ds As DataSet
        Try
            DtRutas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbRutaID, Dia,Codigo, Nombre, Descripcion, Cobrador, Supervisor, CargarDiferenciada, Activa, Ciudad, FechaCreacion", "vwStbRutas", "Activa=1 "))
            DtRutas.PrimaryKey = New DataColumn() {Me.DtRutas.Columns("StbRutaID")}
            DtRutas.DefaultView.Sort = "StbRutaID desc"
            Me.grdRutas.DataSource = DtRutas
            Me.grdRutas.Text = "Rutas (" & Me.DtRutas.Rows.Count & ")"

            'If Not DtRutas Is Nothing Then

            '    DtRutasDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objSupervisorID, Codigo, StbRutaID, Nombre, Descripcion, Ciudad, Cobrador, CargarDiferenciada", "vwStbRutasDetalle", "Activa=1"))
            '    ds = New DataSet

            '    ds.Merge(DtRutas)
            '    ds.Tables(0).TableName = "Rutas"

            '    ds.Merge(DtRutasDetalle)
            '    ds.Tables(1).TableName = "RutasDetalle"

            '    Dim keyColumn As DataColumn = ds.Tables("Rutas").Columns("objSupervisor")
            '    Dim foreignKeyColumn As DataColumn = ds.Tables("RutasDetalle").Columns("objSupervisorID")
            '    ds.Relations.Add("RutasAsignadas", keyColumn, foreignKeyColumn)

            '    grdVentas.DataSource = ds.Tables("Rutas")
            '    grdVentas.ForceInitialize()

            '    GridViewDetalle = New GridView(grdVentas)
            '    grdVentas.LevelTree.Nodes.Add("RutasAsignadas", GridViewDetalle)
            '    GridViewDetalle.PopulateColumns(ds.Tables("RutasDetalle"))

            '    GridViewDetalle.Columns("objSupervisorID").Visible = False
            '    GridViewDetalle.Columns("StbRutaID").Visible = False

            '    GridViewDetalle.Columns("Codigo").OptionsColumn.AllowEdit = False
            '    GridViewDetalle.Columns("Nombre").OptionsColumn.AllowEdit = False
            '    GridViewDetalle.Columns("Descripcion").OptionsColumn.AllowEdit = False
            '    GridViewDetalle.Columns("Ciudad").OptionsColumn.AllowEdit = False
            '    GridViewDetalle.Columns("Cobrador").OptionsColumn.AllowEdit = False
            '    GridViewDetalle.Columns("CargarDiferenciada").OptionsColumn.AllowEdit = False

            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


    ''Descripción:      Metodo encargado de aplicar la seguridad al formulario
    Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "frmStbRutas"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AgregarRuta")
            boolEditar = objSeg.TienePermiso("EditarRuta")
            boolConsultar = objSeg.TienePermiso("ConsultarRuta")
            boolDesactivar = objSeg.TienePermiso("InactivasRuta")
            boolImprimir = objSeg.TienePermiso("ImprimirRuta")
            boolReubicar = objSeg.TienePermiso("ReubicarClientes")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And DtRutas.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And DtRutas.Rows.Count > 0
            cmdDesactivar.Enabled = boolDesactivar And DtRutas.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And DtRutas.Rows.Count > 0
            cmdReubicar.Enabled = boolReubicar And DtRutas.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
        End Try

    End Sub

#End Region

#Region "Eventos del formulario"

    Private Sub frmStbRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarGrid()
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editRutas As frmStbRutasEdit
        Try
            Me.Cursor = WaitCursor
            editRutas = New frmStbRutasEdit
            editRutas.TypeGui = 0
            If editRutas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                AplicarSeguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Dim editRutas As frmStbRutasEdit
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdRutasTabla.GetSelectedRows()
            FilaActual = Me.grdRutasTabla.GetDataSourceRowIndex(selectedRow(0))
            Me.Cursor = WaitCursor
            editRutas = New frmStbRutasEdit
            editRutas.TypeGui = 1
            editRutas.RutaID = Me.DtRutas.DefaultView.Item(FilaActual)("StbRutaID")
            If editRutas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim editRutas As frmStbRutasEdit
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdRutasTabla.GetSelectedRows()
            FilaActual = Me.grdRutasTabla.GetDataSourceRowIndex(selectedRow(0))
            Me.Cursor = WaitCursor
            editRutas = New frmStbRutasEdit
            editRutas.TypeGui = 2
            editRutas.RutaID = Me.DtRutas.DefaultView.Item(FilaActual)("StbRutaID")
            editRutas.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdReubicar_Click(sender As Object, e As EventArgs) Handles cmdReubicar.Click
        Dim objfrmReunicar As frmReubicarClientes
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdRutasTabla.GetSelectedRows()
            FilaActual = Me.grdRutasTabla.GetDataSourceRowIndex(selectedRow(0))
            Me.Cursor = WaitCursor
            objfrmReunicar = New frmReubicarClientes
            objfrmReunicar.NombreRuta = Me.DtRutas.DefaultView.Item(FilaActual)("Nombre")
            objfrmReunicar.RutaID = Me.DtRutas.DefaultView.Item(FilaActual)("StbRutaID")
            objfrmReunicar.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        Dim IDRuta As Integer
        Dim Rutas As New StbRutas
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdRutasTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar la Ruta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDRuta = Me.DtRutas.DefaultView.Item(FilaActual)("StbRutaID")
                    Rutas.Retrieve(IDRuta)
                    Rutas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Rutas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Rutas.Activa = False
                    Rutas.Update()
                    CargarGrid()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Try
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptRutasvb()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("StbRutaID, Codigo, Ruta, objSupervisor, Supervisor, Cobrador, Ciudad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptRutas", ))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
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
