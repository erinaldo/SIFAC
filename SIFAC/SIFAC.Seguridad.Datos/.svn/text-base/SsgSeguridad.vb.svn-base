
Imports DAL
Imports System.Data.SqlClient
''' <summary>
''' Esta clase contiene  todos  los métodos utilizados para la autenticación de usuario
''' </summary>
''' <remarks></remarks>
Public Class SsgSeguridad

#Region "Miembros"
    Private m_Usuario As String
    Private m_ServicioUsuario As String
    Private m_EstaVigente As Boolean
#End Region

#Region "Propiedades"

    Public Property Usuario() As String
        Get
            Return m_Usuario
        End Get
        Set(ByVal value As String)
            m_Usuario = value
        End Set
    End Property

    Public Property ServicioUsuario() As String
        Get
            Return m_ServicioUsuario
        End Get
        Set(ByVal value As String)
            m_ServicioUsuario = value
        End Set
    End Property

    Public Property EstaVigente() As Boolean
        Get
            Return m_EstaVigente
        End Get
        Set(ByVal value As Boolean)
            m_EstaVigente = value
        End Set
    End Property

#End Region

    '-----------------------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementación:    24 de Septiembre del 2007
    '-- Descripcion:                Valida que el login exista
    '-----------------------------------------------------------------------------------------
    ''' <summary>
    ''' Verifica que le login y la clave sean correctos
    ''' </summary>
    ''' <param name="login">Login del usuario </param>
    ''' <param name="clave">Clave del usuario</param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function Autenticar(ByVal login As String, ByVal clave As String) As Boolean
        Dim objcuenta As SsgCuenta
        Try
            objcuenta = New SsgCuenta
            '--- Verificar si existe una cuenta valida para el login introducido
            If objcuenta.RetrieveByFilter("upper(Login) = '" & UCase(login) & "'") Then
                '--- Verificar si la clave es valida 
                If DesencriptaOfHex(objcuenta.Clave) = clave Then
                    If objcuenta.FechaExpiracion.HasValue Then
                        '--- Veficar la fecha de expiración
                        If objcuenta.FechaExpiracion < SqlHelper.GetServerDate Then
                            EstaVigente = False
                        Else
                            EstaVigente = True
                        End If
                    Else
                        EstaVigente = True
                    End If
                    Return True
                Else
                    MsgBox("Clave Incorrecto", MsgBoxStyle.Critical, "Autenticación")
                    Return False
                End If
            Else
                MsgBox("Usuario Incorrecto", MsgBoxStyle.Critical, "Autenticación")
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    '-----------------------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementación:    24 de Septiembre del 2007
    '-- Descripción                 : Validar si un usuario tiene permiso sobre la acción solicitada
    '--
    '-----------------------------------------------------------------------------------------
    ''' <summary>
    ''' Valida si un usuario tiene permiso sobre la acción solicitada
    ''' </summary>
    ''' <param name="CodAccion">Código de la acción</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TienePermiso(ByVal CodAccion As String) As Boolean
        Dim Parametro As SqlParameter
        Dim arParametros(3) As SqlParameter
        Dim dtRoles As DataTable
        Dim strSQL As String
        'Dim intRolID As Integer
        Dim intResultado As Integer
        Dim blnTienePermiso As Boolean

        Try

            blnTienePermiso = False
            '-- 1 Determinar el rol(objRolID) al que pertenece el usuario conectado
            strSQL = " SELECT objRolID " & _
                     " FROM  vwCuentaRol " & _
                     " WHERE upper(login) = @Login"


            '--- Parametro de la consulta
            Parametro = New SqlParameter("@Login", SqlDbType.VarChar, 10)
            Parametro.Value = UCase(Usuario)

            '-----------
            dtRoles = DAL.SqlHelper.ExecuteQueryDT(strSQL, Parametro)
            '-----------

            '--- Por cada rol obtener las acciones
            '----------------
            strSQL = ""
            For Each dr As DataRow In dtRoles.Rows
                strSQL = " SELECT count(*) FROM vwRolAccionxServicioUsuario"
                strSQL &= " WHERE objRolID = " & dr("objRolID") & "And upper(CodAccion) = '" & UCase(CodAccion) & "'"
                strSQL &= " And upper(CodServUsr) = '" & UCase(ServicioUsuario) & "'"
                intResultado = Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text, strSQL, arParametros))
                strSQL = ""
                If intResultado > 0 Then
                    blnTienePermiso = True
                    Exit For
                End If
            Next
            '----------------
            Return blnTienePermiso

        Catch ex As Exception
            Throw
        End Try
    End Function

    '-----------------------------------------------------------------------------------------
    '-- Nombre del Autor            : Investigador.
    '-- Fecha de Elaboración        : 25 de Julio del 2006
    '-- Descripción                 : Lee una cadena con formato hexadecimal y la convierte a formato ASCII
    '-----------------------------------------------------------------------------------------
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="myHex"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DesencriptaOfHex(ByVal myHex As String) As String

        'Declaración de Variables 
        Dim i As Integer, j As Integer
        Dim Result As String

        Result = ""
        Try
            j = 1
            Randomize()
            For i = 1 To Int(Len(myHex) / 2.5)
                Result = Result & Chr(Val("&H" & Mid(myHex, j, 2)))
                j = j + IIf(i Mod 2 = 0, 2, 3)
            Next i

        Catch ex As Exception
            Throw
        End Try
        Return Result
    End Function

End Class
