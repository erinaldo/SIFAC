Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frmRptArqueo
    Dim dtCajas As DataTable

#Region "Procedimientos"
    Public Sub CargarCajas()
        Try
            dtCajas = SccCajas.RetrieveDT("Activa=1", , "SccCajaID, Codigo + '-' + Nombre as Caja, objCajeroID, Ubicacion, Activa")

            cmbCajas.DataSource = dtCajas
            cmbCajas.ValueMember = "SccCajaID"
            cmbCajas.DisplayMember = "Caja"

            cmbCajas.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos del formulario"
    Private Sub frmRptArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCajas()
            Me.dtpFechaDesde.Value = clsProyecto.Conexion.FechaServidor
            Me.dtpFechaHasta.Value = clsProyecto.Conexion.FechaServidor

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub chkTodasCajas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodasCajas.CheckedChanged
        If chkTodasCajas.Checked Then
            Me.cmbCajas.Text = String.Empty
        End If
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim ds As DataSet
        Dim strFiltro As String = String.Empty
        Try
            Dim objjReporte As New RptArqueoCaja()

            If ((Not chkTodasCajas.Checked Or cmbCajas.SelectedValue = 0 Or IsNothing(cmbCajas.SelectedValue) Or dtpFechaDesde.Text = "") And (dtpFechaDesde.Text = "") And (dtpFechaHasta.Text = "")) Then
                MsgBox("Debe seleccionar un criterio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Else
                If chkTodasCajas.Checked Then
                    strFiltro = "Convert(varchar(10),Fecha,112)>='" & Format(Me.dtpFechaDesde.Value, "yyyyMMdd") & "' AND Convert(varchar(10),Fecha,112)<='" & Format(Me.dtpFechaDesde.Value, "yyyyMMdd") & "'"
                Else
                    strFiltro = "objCajaID= " & cmbCajas.SelectedValue & " AND Convert(varchar(10),Fecha,112)=>'" & Format(Me.dtpFechaDesde.Value, "yyyyMMdd") & "' AND Convert(varchar(10),Fecha,112)<='" & Format(Me.dtpFechaDesde.Value, "yyyyMMdd") & "'"

                End If

                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("*", "vwRptArqueoCaja", strFiltro))
                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    objjReporte.lblFecha.Visible = False
                    objjReporte.txtRangofechas.Text = "Desde " & Format(dtpFechaDesde.Value, "dd/MM/yyyy") & " hasta " & Format(dtpFechaDesde.Value, "dd/MM/yyyy")

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
#End Region

  
    
End Class