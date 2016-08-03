
Public Class frmConsultaDescuentoPromociones
    Public Datos As DataTable

    Private Sub frmConsultaDescuentoPromociones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gridDescuentos.SetDataBinding(Me.Datos, "", True)
    End Sub

    Private Sub frmConsultaDescuentoPromociones_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class