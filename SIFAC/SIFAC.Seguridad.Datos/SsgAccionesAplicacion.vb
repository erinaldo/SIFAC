Imports DAL
Public Class SsgAccionesAplicacion

    Public Shared Function ObtenerAccs(ByVal RolID As Long, ByVal AplicacionID As Long) As DataTable
        Dim AccionesDt As DataTable
        Dim strSQL As String
        Try
            AccionesDt = New DataTable
            If RolID = 0 Then
                strSQL = " SELECT *, CAST(0 as bit) as Marcado FROM vwAccionesxAplicacion " & _
                         " WHERE objAplicacionID = " & AplicacionID
                AccionesDt = SqlHelper.ExecuteQueryDT(strSQL)
                'AccionesDt.PrimaryKey = New DataColumn() {AccionesDt.Columns("SsgAccionID")}
            Else
                strSQL = " SELECT * , Cast(1 as bit) as Marcado FROM vwAccionesxAplicacion " & _
                                         " WHERE SsgAccionID In (select objAccionID from SsgRolAccion where ObjRolID = " & RolID & " )" & _
                                         " And objAplicacionID = " & AplicacionID & _
                                         " UNION " & _
                                         " SELECT * , Cast(0 as bit) as Marcar FROM vwAccionesxAplicacion " & _
                                         " WHERE SsgAccionID Not In (select objAccionID from SsgRolAccion where ObjRolID = " & RolID & " )" & _
                                         " And objAplicacionID = " & AplicacionID
                AccionesDt = SqlHelper.ExecuteQueryDT(strSQL)
            End If
            Return AccionesDt
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
