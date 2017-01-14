Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIFAC.BO

Public Class frmSccArquo

#Region "Variables del formulario"
    Dim dtArqueos As DataTable
    Dim EsNotaDebito As Integer
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolAprobar, boolImprimir As Boolean
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtArqueos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("ArqueoID, Fecha, EntradaEfectivo, SalidaEfectivo, Faltante, AprobadoPor, Cajero", "vwSccArqueoCaja", "1=1"))
            dtArqueos.DefaultView.Sort = "Fecha"
            Me.grdArqueo.DataSource = dtArqueos
            Me.grdArqueo.Text = "Arqueos (" & Me.dtArqueos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSccArqueoCaja"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarCierre")
            boolConsultar = objseg.TienePermiso("ConsultarArqueo")
            boolAprobar = objseg.TienePermiso("AprobarArqueo")
            boolImprimir = objseg.TienePermiso("ImprimirArqueo")

            cmdAgregar.Enabled = boolAgregar
            cmdConsultar.Enabled = boolConsultar And dtArqueos.Rows.Count > 0
            cmdAprobar.Enabled = boolAprobar ''And dtArqueos.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtArqueos.Rows.Count > 0

            'If dtArqueos.Rows.Count > 0 Then

            '    Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
            '    FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))

            '    If Me.dtArqueos.DefaultView.Item(FilaActual)("Aprobado").ToString.Trim.Length <> 0 Then

            '        If Me.dtArqueos.DefaultView.Item(FilaActual)("Aprobado") Then
            '            Me.cmdAprobar.Enabled = False
            '        Else
            '            Me.cmdAprobar.Enabled = True
            '        End If

            '    End If

            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

   

    Private Sub Consultar()
        Dim Consultararqueo As New frmSccConsultarArqueo
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
                FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))
                Consultararqueo.ArqueoID = Me.dtArqueos.DefaultView.Item(FilaActual)("ArqueoID")
                Consultararqueo.TypeGui = 2

                If Consultararqueo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGrid()
                    AplicarSeguridad()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Consultararqueo = Nothing
        End Try
    End Sub

    Private Sub Abprobar()
        Dim aprobararqueo As New frmSccConsultarArqueo
        ''  Dim FilaActual As Integer
        Dim dtArqueoAprobado As New DataTable
        Try
            Try
                dtArqueoAprobado = SccArqueoCaja.RetrieveDT("convert(varchar(10),Fecha,112)='" & Date.Now.ToString("yyyyMMdd") & "'")
                If dtArqueoAprobado.Rows.Count > 0 Then
                    MsgBox("Ya se realizo el cierre de caja del dia en curso.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Else
                    aprobararqueo.TypeGui = 1
                    If aprobararqueo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                        AplicarSeguridad()
                    End If
                End If
               
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            aprobararqueo = Nothing
        End Try
    End Sub

    Private Sub Agregar()
        Dim aprobararqueo As New frmSccConsultarArqueo
       
        Try
            Try
                
                aprobararqueo.TypeGui = 0
                If aprobararqueo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGrid()
                    AplicarSeguridad()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            aprobararqueo = Nothing
        End Try
    End Sub

#End Region

    Private Sub frmSccArquo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Agregar()
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        Abprobar()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub grdArqueoabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdArqueoabla.FocusedRowChanged
        'Dim FilaActual As Integer
        'Try
        '    Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
        '    FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))

        '    If Me.dtArqueos.DefaultView.Item(FilaActual)("Aprobado").ToString.Trim.Length <> 0 Then

        '        If Me.dtArqueos.DefaultView.Item(FilaActual)("Aprobado") Then
        '            Me.cmdAprobar.Enabled = False
        '        Else
        '            Me.cmdAprobar.Enabled = True
        '        End If

        '    End If
        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Consultar()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As DataSet
        Dim FilaActual As Integer
        Dim ArqueoID As Integer
        Try
            Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
            FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))
            ArqueoID = Me.dtArqueos.DefaultView.Item(FilaActual)("ArqueoID")

            Dim objjReporte As New RptArqueoCaja()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("*", "vwRptArqueoCaja", "ArqueoID=" & ArqueoID))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.txtRangofechas.Visible = False
                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class