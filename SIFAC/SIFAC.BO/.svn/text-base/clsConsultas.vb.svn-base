Public Class clsConsultas

#Region "Catalogos Generales"

    '****************************************************************************************************
    '--                                 frmStbParametros                                             ---
    '****************************************************************************************************
    '----------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Elaboración    :   10 de Noviembre del 2007
    '-- Descripcion             :   Recupera datos de la Tabla Parámetro
    '----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Recupera datos de la Tabla Parámetro
    ''' </summary>
    ''' <param name="strCampos">Campos a mostrar</param>
    ''' <param name="strFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerValorParametro(ByVal strCampos As String, Optional ByVal strFiltro As String = "1=1", Optional ByVal OrderBy As String = "") As String
        Dim strSQL As String
        Try
            strSQL = " SELECT " & strCampos & _
                     " FROM StbParametro " & _
                     " WHERE " & strFiltro
            If OrderBy <> "" Then
                strSQL &= " ORDER BY " & OrderBy
            End If
            Return strSQL
        Catch ex As Exception
            Throw
        End Try
    End Function


    ''' <summary>
    ''' Obtiene los valores del catalogo especificado
    ''' </summary>
    ''' <param name="strCampos"></param>
    ''' <param name="strFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerCatalogoValor(ByVal strCampos As String, Optional ByVal strFiltro As String = "1=1", Optional ByVal OrderBy As String = "") As String
        Dim strSQL As String
        Try
            strSQL = " SELECT " & strCampos & _
                     " FROM vwStbCatValores " & _
                     " WHERE " & strFiltro

            If OrderBy <> "" Then
                strSQL &= " ORDER BY " & OrderBy
            End If

            Return strSQL
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Shared Function ObtenerTasaCambioOficial(ByVal strCampos As String, Optional ByVal strFiltro As String = "1=1", Optional ByVal OrderBy As String = "") As String
        Dim strSQL As String
        Try
            strSQL = " SELECT " & strCampos & _
                     " FROM vwStbTasaCambioOficial " & _
                     " WHERE " & strFiltro
            If OrderBy <> "" Then
                strSQL &= " ORDER BY " & OrderBy
            End If
            Return strSQL
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' </summary>
    ''' <param name="strCampos"></param>
    ''' <param name="strFiltro"></param>
    ''' <param name="OrderBy"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerNotaCredito(ByVal strCampos As String, Optional ByVal strFiltro As String = "1=1", Optional ByVal OrderBy As String = "") As String
        Dim strSQL As String
        Try
            strSQL = " SELECT " & strCampos & _
                     " FROM vwSccNotaCredito " & _
                     " WHERE " & strFiltro
            If OrderBy <> "" Then
                strSQL &= " ORDER BY " & OrderBy
            End If
            Return strSQL
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

#Region "Obtener Consulta General"

    Public Shared Function ObtenerConsultaGeneral(ByVal strCampos As String, ByVal strVista_Tabla As String, Optional ByVal strFiltro As String = "1=1") As String
        Dim Query As String
        Try
            Query = " SELECT " & strCampos & _
                     " FROM " & strVista_Tabla & _
                     " WHERE " & strFiltro
            Return Query
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Obtener Consulta Jefe Tienda"
    Public Shared Function ObtenerJefeTienda(ByVal strCampos As String, ByVal strVista As String, Optional ByVal strFiltro As String = "1=1") As String
        Dim query As String
        Try
            query = " SELECT  B.StbPersonaID, B.NombreCompleto" & _
                    " FROM (SELECT " & strCampos & _
                    " FROM " & strVista & _
                    " WHERE " & strFiltro & _
                    " UNION ALL " & _
                    " SELECT NULL AS StbPersonaID,'Seleccione un Jefe de Tienda' AS NombreCompleto) B" & _
                    " ORDER BY B.StbPersonaID"
            Return query
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

End Class
