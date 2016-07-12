Imports Proyecto.Catalogos.Datos
Imports Proyecto.Configuracion

Public Class ClsCatalogos

    '==============================================================================================================
    '--------------------------------------------------------------------------------------------------------------'
    ' Autor           : Pedro Tinoco Salgado.                                                                      '  
    ' Fecha Creacion  : 16 de diciembre de 2007.                                                                   ' 
    ' Descripcion     : Esta funcion se encarga de retornarme el ID de los valores catalogos segun el Catalogo     '
    '-----------------: al que pertenecen.                                                                         ' 
    '--------------------------------------------------------------------------------------------------------------'
    Public Shared Function ObtenerIDSTbCatalogo(ByVal strNombCatalogo As String, ByVal strEstado As String) As Integer
        Dim dtstbCatalogo As New DataTable
        Dim dtstbValorCatalogo As New DataTable
        Dim IntValorID As Integer

        Try
            dtstbCatalogo = StbCatalogo.RetrieveDT("Nombre= " + "'" + strNombCatalogo + "'" + "", , "StbCatalogoID")
            If dtstbCatalogo.DefaultView.Count > 0 Then
                dtstbValorCatalogo = StbValorCatalogo.RetrieveDT("objCatalogoID=" + Convert.ToString(dtstbCatalogo.DefaultView.Item(0)("StbCatalogoID")) + " AND " + "Codigo = " + "" + "'" + strEstado + "'" + "", , "StbValorCatalogoID")
                IntValorID = dtstbValorCatalogo.DefaultView.Item(0)("StbValorCatalogoID")
            End If
            Return IntValorID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
    '==============================================================================================================


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

End Class
