Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivEntradaBodegaPREIMP		

#Region " Variables Miembro " 
	Protected m_objentradabodegaPRE As Integer 
	Protected m_objentradabodegaIMP As Integer 
	Protected m_objrepuestoid As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property objentradabodegaPRE() As Integer
        Get
            Return (m_objentradabodegaPRE)
        End Get
		Set(ByVal Value As Integer)					
			m_objentradabodegaPRE = Value
		End Set
    End Property
	
	Public Property objentradabodegaIMP() As Integer
        Get
            Return (m_objentradabodegaIMP)
        End Get
		Set(ByVal Value As Integer)					
			m_objentradabodegaIMP = Value
		End Set
    End Property
	
	Public Property objrepuestoid() As String
        Get
            Return (m_objrepuestoid)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("objrepuestoid", Value.ToString(), "Valor inv?lido para SivEntradaBodegaPREIMP.objrepuestoid. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_objrepuestoid = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "objrepuestoid"
				Return	50
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivEntradaBodegaPREIMP en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivEntradaBodegaPREIMP </param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo BatchUpdate.</param>
    ''' <remarks>Usado para realizar actualizaciones en Batch.</remarks>
	public Shared Sub BatchUpdate( DS as Dataset, optional Byval pTransac as TransactionManager = Nothing )
	    Dim cmdInsert As SqlCommand = Nothing
        Dim cmdUpdate As SqlCommand = Nothing
        Dim cmdDelete As SqlCommand = Nothing
		
		Try
			cmdInsert = New SqlCommand
			cmdUpdate = New SqlCommand
			cmdDelete = New SqlCommand
			'CREACION DEL COMANDO DELETE
			cmdDelete.Parameters.Add("@objentradabodegaPRE", SqlDbType.Int, 4, "objentradabodegaPRE" )
			cmdDelete.Parameters.Add("@objentradabodegaIMP", SqlDbType.Int, 4, "objentradabodegaIMP" )
			cmdDelete.Parameters.Add("@objrepuestoid", SqlDbType.VarChar, 50, "objrepuestoid" )
			cmdDelete.CommandText = "DELETE FROM  SivEntradaBodegaPREIMP WHERE objentradabodegaPRE= @objentradabodegaPRE And objentradabodegaIMP= @objentradabodegaIMP And objrepuestoid= @objrepuestoid" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objentradabodegaPRE", SqlDbType.Int, 4, "objentradabodegaPRE")
			cmdInsert.Parameters.Add("@objentradabodegaIMP", SqlDbType.Int, 4, "objentradabodegaIMP")
			cmdInsert.Parameters.Add("@objrepuestoid", SqlDbType.VarChar, 50, "objrepuestoid")
			cmdInsert.CommandText = "INSERT INTO SivEntradaBodegaPREIMP ( objentradabodegaPRE, objentradabodegaIMP, objrepuestoid) VALUES ( @objentradabodegaPRE, @objentradabodegaIMP, @objrepuestoid)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objentradabodegaPRE", SqlDbType.Int, 4, "objentradabodegaPRE")
			cmdUpdate.Parameters.Add("@objentradabodegaIMP", SqlDbType.Int, 4, "objentradabodegaIMP")
			cmdUpdate.Parameters.Add("@objrepuestoid", SqlDbType.VarChar, 50, "objrepuestoid")
			cmdUpdate.Parameters.Add("@wobjentradabodegaPRE", SqlDbType.Int, 4, "objentradabodegaPRE")
			cmdUpdate.Parameters.Add("@wobjentradabodegaIMP", SqlDbType.Int, 4, "objentradabodegaIMP")
			cmdUpdate.Parameters.Add("@wobjrepuestoid", SqlDbType.VarChar, 50, "objrepuestoid")
			cmdUpdate.CommandText = "UPDATE SivEntradaBodegaPREIMP SET objentradabodegaPRE=@objentradabodegaPRE, objentradabodegaIMP=@objentradabodegaIMP, objrepuestoid=@objrepuestoid WHERE objentradabodegaPRE= @wobjentradabodegaPRE And objentradabodegaIMP= @wobjentradabodegaIMP And objrepuestoid= @wobjrepuestoid"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivEntradaBodegaPREIMP")
		Catch ex As Exception
            Throw
        Finally
            If Not cmdInsert Is Nothing Then
                cmdInsert.Dispose()
            End If
            If Not cmdUpdate Is Nothing Then
                cmdUpdate.Dispose()
            End If
            If Not cmdDelete Is Nothing Then
                cmdDelete.Dispose()
            End If
        End Try
	End Sub 
#End Region

#Region " Retrieve "
	''' <summary>
    ''' Devuelve de la base de datos un objeto SivEntradaBodegaPREIMP
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_objentradabodegaPRE as Integer, Byval p_objentradabodegaIMP as Integer, Byval p_objrepuestoid as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivEntradaBodegaPREIMP where " & " objentradabodegaPRE = " & p_objentradabodegaPRE & " and objentradabodegaIMP = " & p_objentradabodegaIMP & " and objrepuestoid = '" & p_objrepuestoid & "'" 		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_objentradabodegaPRE = IIf(IsDBNull(dr("objentradabodegaPRE")), Nothing, dr("objentradabodegaPRE"))					
				m_objentradabodegaIMP = IIf(IsDBNull(dr("objentradabodegaIMP")), Nothing, dr("objentradabodegaIMP"))					
				m_objrepuestoid = IIf(IsDBNull(dr("objrepuestoid")), Nothing, dr("objrepuestoid"))					
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
            Throw
        Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try			
    End Function

	''' <summary>
    ''' Devuelve de la base de datos un objeto SivEntradaBodegaPREIMP usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivEntradaBodegaPREIMP where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_objentradabodegaPRE = IIf(IsDBNull(dr("objentradabodegaPRE")), Nothing, dr("objentradabodegaPRE"))					
				m_objentradabodegaIMP = IIf(IsDBNull(dr("objentradabodegaIMP")), Nothing, dr("objentradabodegaIMP"))					
				m_objrepuestoid = IIf(IsDBNull(dr("objrepuestoid")), Nothing, dr("objrepuestoid"))					
				Return True
			Else
				Return False
			End If			
        Catch ex As Exception
            Throw
        Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try			
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEntradaBodegaPREIMP en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivEntradaBodegaPREIMP"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim ds As DataSet 
		Try
			If pTransac is nothing Then 
				ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
			Else
				ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			ds.Tables(0).TableName = "SivEntradaBodegaPREIMP"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEntradaBodegaPREIMP en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivEntradaBodegaPREIMP"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

		Dim ds As DataSet 
		Try
			If pTransac Is Nothing then
				ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
			Else
				ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			ds.Tables(0).TableName = "SivEntradaBodegaPREIMP"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEntradaBodegaPREIMP en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivEntradaBodegaPREIMP"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If
		
		Dim dr As SqlDataReader = Nothing
		Try
			If pTransac is nothing then
				dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
			Else
				dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			Return (dr)
		Catch ex As Exception
			Throw        
		Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try	
    End Function
#End Region

#Region " Insert "

	''' <summary>
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivEntradaBodegaPREIMP.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivEntradaBodegaPREIMP("
		sCommand &= "objentradabodegaPRE,"
		sCommand &= "objentradabodegaIMP,"
		sCommand &= "objrepuestoid) values ("		
		sCommand &= "@objentradabodegaPRE,"
		sCommand &= "@objentradabodegaIMP,"
		sCommand &= "@objrepuestoid)"		
		
		Dim arParams(2) As SqlParameter
		arParams(0) = New SqlParameter("@objentradabodegaPRE", SqlDbType.Int)		
		If IsDBNull(m_objentradabodegaPRE) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_objentradabodegaPRE
        End If
		arParams(1) = New SqlParameter("@objentradabodegaIMP", SqlDbType.Int)		
		If IsDBNull(m_objentradabodegaIMP) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objentradabodegaIMP
        End If
		arParams(2) = New SqlParameter("@objrepuestoid", SqlDbType.VarChar)		
		If IsDBNull(m_objrepuestoid) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objrepuestoid
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivEntradaBodegaPREIMP en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivEntradaBodegaPREIMP set "		
		sCommand &= "objentradabodegaPRE = @objentradabodegaPRE,"
		sCommand &= "objentradabodegaIMP = @objentradabodegaIMP,"
		sCommand &= "objrepuestoid = @objrepuestoid"		
		sCommand &= " where "	
		sCommand &= "objentradabodegaPRE = @objentradabodegaPRE and "
		sCommand &= "objentradabodegaIMP = @objentradabodegaIMP and "
		sCommand &= "objrepuestoid = @objrepuestoid"					
		
		Dim arParams(2) As SqlParameter
		arParams(0) = New SqlParameter("@objentradabodegaPRE", SqlDbType.Int)		
		If IsDBNull(m_objentradabodegaPRE) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_objentradabodegaPRE
        End If
		arParams(1) = New SqlParameter("@objentradabodegaIMP", SqlDbType.Int)		
		If IsDBNull(m_objentradabodegaIMP) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objentradabodegaIMP
        End If
		arParams(2) = New SqlParameter("@objrepuestoid", SqlDbType.VarChar)		
		If IsDBNull(m_objrepuestoid) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objrepuestoid
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
        Catch ex As Exception
            Throw        
        End Try
    End Sub
#End Region
	
#Region " Delete "

	''' <summary>
    ''' Borra un objeto SivEntradaBodegaPREIMP de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaBodegaPREIMP where " & " objentradabodegaPRE = " & m_objentradabodegaPRE & " and objentradabodegaIMP = " & m_objentradabodegaIMP & " and objrepuestoid = '" & m_objrepuestoid & "'" 
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub

    ''' <summary>
    ''' Borra un objeto SivEntradaBodegaPREIMP de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_objentradabodegaPRE as Integer, Byval p_objentradabodegaIMP as Integer, Byval p_objrepuestoid as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaBodegaPREIMP where " & " objentradabodegaPRE = " & p_objentradabodegaPRE & " and objentradabodegaIMP = " & p_objentradabodegaIMP & " and objrepuestoid = '" & p_objrepuestoid & "'" 
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub	

    ''' <summary>
    ''' Borra objetos SivEntradaBodegaPREIMP de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaBodegaPREIMP where " & pWhere
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub
#End Region

End Class
