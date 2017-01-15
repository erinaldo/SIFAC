Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos

Public Class frmReportePivotCuotasVencidas
    Dim dtConsolidado As New DataTable
    Dim Filtro As String

    Private Sub CargarPivot(bool As Boolean)
        Try
            Filtro = "1=1"
            dtConsolidado = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Ruta, Ciudad, Cobrador, Supervisor, NumeroCuenta, Cliente, Saldo, CuotasVencidas", "vwRptCuentasVencidas", Filtro))
            PivotConsolidado.DataSource = dtConsolidado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub frmReportePivot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarPivot(0)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        CargarPivot(0)
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub

    Private Sub ExportarExcel()
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.PivotConsolidado.ExportToXls(sfdRuta.FileName)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        ExportarExcel()

    End Sub
End Class