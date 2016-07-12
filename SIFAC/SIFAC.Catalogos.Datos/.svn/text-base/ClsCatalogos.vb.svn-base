
Imports Proyecto.Catalogos.Datos

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
            Throw
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


    '==============================================================================================================


    '****************************************************************************************************
    '--                                 Valor Catalogo                                                ---
    '****************************************************************************************************
    '----------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Sergio Ordoñez
    '-- Fecha de Elaboración    :   13 de Marzo del 2009
    '-- Descripcion             :   Recupera datos de los valores catalogo para un catalogo en especifico
    '----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Recupera datos de los valores catalogo para un catalogo en especifico
    ''' </summary>
    ''' <param name="strNombre">Nombre del catalogo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerValCat(ByVal strNombre) As DataTable
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cmd.CommandText = "SELECT StbValorCatalogoID,Codigo,Descripcion,Activo FROM vwStbCatValores WHERE Nombre = '" & strNombre & "' ORDER BY Descripcion"
            cmd.Connection = DAL.SqlHelper.GetConnection
            dta = New SqlClient.SqlDataAdapter(cmd)
            dta.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    '-------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        : Gelmin Martínez.
    '-- Fecha de Elaboración    : 19 de Mayo 2010, 04:24 pm.
    '--------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Devuelve el Identificador del Valor catálogo (StbValorCatalogoID) que corresponde con los parámetros recibidos
    ''' </summary>
    ''' <param name="sNombreCatalogo">Nombre del catálogo al que pertenece el valor</param>
    ''' <param name="sCodigoValorCatalogo">Campo Código del catálogo valor</param>
    ''' <returns>Número entero que corresponde al StbValorCatalogoID</returns>
    ''' <remarks></remarks>
    Public Shared Function GetValorCatalogoID(ByVal sNombreCatalogo As String, ByVal sCodigoValorCatalogo As String) As Integer
        Dim sSQL As String
        Dim iResultado As Integer
        sSQL = "SELECT dbo.FnValorCatalogoID ('" + sNombreCatalogo + "','" + sCodigoValorCatalogo + "') as ID"
        Try
            iResultado = DAL.SqlHelper.ExecuteScalar(CommandType.Text, sSQL)
        Catch ex As Exception
            iResultado = 0
        End Try
        Return iResultado
    End Function

    '-------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        : Gelmin Martínez.
    '-- Fecha de Elaboración    : 08 de Junio 2010, 10:12 am.
    '--------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Devuelve los [valores catálogos] activos de un [catálogo] específico recibido como argumento
    ''' </summary>
    ''' <param name="sNombreCatalogo">Nombre del catálogo a recuperar</param>
    ''' <param name="sCamposValorCatalogo">Campos que desea recuperar de ValorCatálogo, campos disponibles (StbValorCatalogoID, Codigo, Descripcion) </param>
    ''' <param name="sOrderBy">Campos por los que le gustaría ordenar los resultados. campos disponibles (ValorCatalogoID, Codigo, Descripcion) </param>
    ''' <returns>Un datatable con los valores del catálogo</returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function GetValoresCatalogo(ByVal sNombreCatalogo As String, ByVal sCamposValorCatalogo As String, Optional ByVal sOrderBy As String = "") As DataTable
        Dim dtDatos As New DataTable
        Dim cmdSelect As New SqlClient.SqlCommand
        Dim daDatos As SqlClient.SqlDataAdapter
        Try
            If String.IsNullOrEmpty(sOrderBy) Then
                cmdSelect.CommandText = "SELECT " + sCamposValorCatalogo + " FROM vwStbCatValores WHERE Nombre = '" & sNombreCatalogo & "'"
            Else
                cmdSelect.CommandText = "SELECT " + sCamposValorCatalogo + " FROM vwStbCatValores WHERE Nombre = '" & sNombreCatalogo & "' ORDER BY " + sOrderBy
            End If

            cmdSelect.Connection = DAL.SqlHelper.GetConnection
            daDatos = New SqlClient.SqlDataAdapter(cmdSelect)
            daDatos.Fill(dtDatos)
            Return dtDatos
        Catch ex As Exception
            Throw
        End Try
    End Function

    '-------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        : Gelmin Martínez.
    '-- Fecha de Elaboración    : 17 de Junio 2010, 04:38 pm.
    '--------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Sobrecarga de GetValoresCatalogo para devolver campos por defecto (StbValorCatalogoID, Descripcion)
    ''' </summary>
    ''' <param name="sNombreCatalogo">Nombre del catálogo a recuperar, se devolverá por defecto (StbValorCatalogoID, Descripcion) ordenado ascendentemente por campo Descripción</param>
    ''' <returns>Un datatable con los valores del catálogo</returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function GetValoresCatalogo(ByVal sNombreCatalogo As String) As DataTable
        Return GetValoresCatalogo(sNombreCatalogo, "StbValorCatalogoID, Descripcion", "Descripcion")
    End Function

    '----------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Gelmin Martínez
    '-- Fecha de Elaboración    :   19 de Mayo del 2010, 04:46 pm.
    '----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Recupera el valor de un Parámetro de la base de datos 
    ''' </summary>
    ''' <param name="sNombreParametro">Nombre del parámetro a buscar</param>
    ''' <returns>Valor del parámetro en string</returns>
    ''' <remarks></remarks>
    Public Shared Function GetValorParametro(ByVal sNombreParametro) As String
        Dim sSQL As String
        Dim sValor As String
        sSQL = "SELECT dbo.FnGetParametro ('" + sNombreParametro + "') AS valor"
        Try
            sValor = DAL.SqlHelper.ExecuteScalar(CommandType.Text, sSQL)
        Catch ex As Exception
            sValor = String.Empty
        End Try
        Return sValor
    End Function

    '----------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Gelmin Martínez
    '-- Fecha de Elaboración    :   19 de Mayo del 2010, 04:52 pm.
    '----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Devuelve el Identificador de la tienda  
    ''' </summary>
    ''' <param name="sNombreParametro">Código de la tienda a buscar</param>
    ''' <returns>Identificador de la tienda (StbTiendaID)</returns>
    ''' <remarks></remarks>
    Public Shared Function GetStbTiendaID(ByVal sCodigoTienda As String) As Integer
        Dim sSQL As String
        Dim iResultado As Integer
        sSQL = SCCUM.BO.clsConsultas.ObtenerConsultaGeneral("StbTiendaID", "dbo.StbTienda", "Codigo='" + sCodigoTienda + "'")
        Try
            iResultado = DAL.SqlHelper.ExecuteQueryDT(sSQL).DefaultView.Item(0)("StbTiendaID")
        Catch ex As Exception
            iResultado = 0
        End Try
        Return iResultado
    End Function

    '----------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Gelmin Martínez
    '-- Fecha de Elaboración    :   20 de Mayo del 2010, 01:24 pm.
    '----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Devuelve el nombre de la tienda  
    ''' </summary>
    ''' <param name="sStbTiendaId">Código de la tienda a buscar</param>
    ''' <returns>Nombre de la tienda</returns>
    ''' <remarks></remarks>
    Public Shared Function GetStbTiendaNombre(ByVal sCodigoTienda As String) As String
        Dim sSQL As String
        Dim sResultado As String = String.Empty
        sSQL = SCCUM.BO.clsConsultas.ObtenerConsultaGeneral("Nombre", "dbo.StbTienda", "Codigo='" + sCodigoTienda + "'")
        Try
            sResultado = DAL.SqlHelper.ExecuteQueryDT(sSQL).DefaultView.Item(0)("Nombre")
        Catch ex As Exception
        End Try
        Return sResultado
    End Function

    ''' <summary>
    ''' Busca el código de barras del repuesto y si lo encuentra devuelve el SivRepuestoID correspondiente 
    ''' </summary>
    ''' <param name="strBarCode">Código de barras de repuesto a buscar</param>
    ''' <returns>Código de repuesto correspondiente al código de barras.</returns>
    Public Shared Function GetCodigoRepuestoByCodigoBarras(ByVal strBarCode As String) As Integer
        Dim parametros(1) As SqlClient.SqlParameter
        Dim CodigoRepuesto As Integer
        Dim dtDatos As DataTable

        If Not String.IsNullOrEmpty(strBarCode) Then
            parametros(0) = New SqlClient.SqlParameter("@BarCode", SqlDbType.VarChar, 50, ParameterDirection.Input)
            parametros(0).Value = strBarCode

            dtDatos = DAL.SqlHelper.ExecuteQueryDT("SELECT ISNULL(SivRepuestoID,0) AS CodigoRepuesto FROM dbo.SivRepuestos WHERE QuoteName(CodigoBarras)=QuoteName(@BarCode)", parametros)
            If dtDatos.Rows.Count > 0 Then
                CodigoRepuesto = dtDatos.DefaultView.Item(0)("CodigoRepuesto")
            Else
                CodigoRepuesto = 0
            End If
        Else
            CodigoRepuesto = 0
        End If

        Return CodigoRepuesto

    End Function

End Class
