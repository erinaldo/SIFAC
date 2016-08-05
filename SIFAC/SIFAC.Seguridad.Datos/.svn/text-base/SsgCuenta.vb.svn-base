Imports DAL
Imports System.Data.SqlClient

Partial Public Class SsgCuenta

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   11 de Septiembre del 2007
    '--- Descripción        :   Carga los roles que pueden ser Asignads a la cuenta
    '------------------------------------------------------------------------------------
    Public Shared Function ObtenerRoles(ByVal CuentaID As Long) As DataTable
        Dim RolesDt As DataTable
        Dim strSQL As String
        Try
            If CuentaID = 0 Then
                strSQL = " SELECT cast(0 as bit)as Marcado, * FROM vwRolesxAplicacion "
                RolesDt = SqlHelper.ExecuteQueryDT(strSQL)
                Return RolesDt
            Else
                strSQL = " SELECT cast(0 as bit) as Marcado ,* FROM vwRolesxAplicacion " & _
                         " WHERE SsgRolID not in (SELECT objRolID FROM vwCuentaRol WHERE objCuentaID = " & CuentaID & ")" & _
                         " UNION " & _
                         " SELECT cast(1 as bit) as Marcado ,* FROM vwRolesxAplicacion " & _
                         " WHERE SsgRolID in (SELECT objRolID FROM vwCuentaRol WHERE objCuentaID = " & CuentaID & ")" & _
                         " ORDER BY Marcado DESC"
                RolesDt = SqlHelper.ExecuteQueryDT(strSQL)
                Return RolesDt
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    '----------------------------------------------------------------------------------------------------
    'Procedimiento  : DesactivarCuenta
    'Autor          : Pedro Tinoco
    'Fecha Creacion : 27-10-2007
    'Descripcion    : Procedimiento encargado de desactivar la cuenta de un empleado en especifico.
    '----------------------------------------------------------------------------------------------------
    Public Shared Sub DesactivarCuenta(ByVal strFiltro As String, ByVal T As TransactionManager)
        Dim strSQL As String
        Try
            strSQL = " UPDATE SsgCuenta " & _
                     " SET Activo= False" & _
                     " WHERE ObjEmpleadoID= " & strFiltro
            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.Text, strSQL)
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
