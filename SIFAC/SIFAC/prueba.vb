Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Catalogos.Datos

Public Class prueba
    Public DtAbonos, DtAbonosDetalle As DataTable
    Public ds As DataSet

    Private Sub prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DtAbonos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionAbonos", "1=1"))
            'If Not DtAbonos Is Nothing Then
            '    'DtAbonos.PrimaryKey = New DataColumn() {Me.DtAbonos.Columns("AplCobroID")}
            '    DtAbonos.DefaultView.Sort = "FechaAbono"
            '    Me.GridControl1.DataSource = DtAbonos
            '    Me.GridControl1.Text = "Abonos (" & Me.DtAbonos.Rows.Count & ")"
            'End If

            DtAbonosDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwSfaExpedienteCliente", "1=1"))

            ds = New DataSet

            ds.Merge(DtAbonos)
            ds.Tables(0).TableName = "Abonos"

            ds.Merge(DtAbonosDetalle)
            ds.Tables(1).TableName = "DetalleAbono"

            ds.Relations.Add("Detalle", ds.Tables(0).Columns("objSccCuentaID"), ds.Tables(1).Columns("SccCuentaID"), False)
            Me.GridControl1.DataSource = ds.Tables(0)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class