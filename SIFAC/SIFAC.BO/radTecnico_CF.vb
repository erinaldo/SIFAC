Imports DAL
Imports System.Data.SqlClient

Partial Public Class radTecnico		

#Region " Variables Miembro " 
	Protected m_RadTecnicoID As Integer 
	Protected m_Codigo As String = Nothing 
	Protected m_Nombre As String = Nothing 
	Protected m_objTecnicoRevisorId As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property RadTecnicoID() As Integer
        Get
            Return (m_RadTecnicoID)
        End Get
		Set(ByVal Value As Integer)					
			m_RadTecnicoID = Value
		End Set
    End Property
	
	Public Property Codigo() As String
        Get
            Return (m_Codigo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Codigo", Value.ToString(), "Valor inv?lido para radTecnico.Codigo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Codigo = Value
		End Set
    End Property
	
	Public Property Nombre() As String
        Get
            Return (m_Nombre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Nombre", Value.ToString(), "Valor inv?lido para radTecnico.Nombre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Nombre = Value
		End Set
    End Property
	
	Public Property objTecnicoRevisorId() As Nullable(Of Integer)
        Get
            Return (m_objTecnicoRevisorId)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objTecnicoRevisorId = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Codigo"
				Return	50
			Case "Nombre"
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
    ''' Salva un DataSet del tipo de la tabla radTecnico en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla radTecnico </param>    
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
			cmdDelete.Parameters.Add("@RadTecnicoID", SqlDbType.Int, 4, "RadTecnicoID" )
			cmdDelete.CommandText = "DELETE FROM  radTecnico WHERE RadTecnicoID= @RadTecnicoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo")
			cmdInsert.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdInsert.Parameters.Add("@objTecnicoRevisorId", SqlDbType.Int, 4, "objTecnicoRevisorId")
			cmdInsert.CommandText = "INSERT INTO radTecnico ( Codigo, Nombre, objTecnicoRevisorId) VALUES ( @Codigo, @Nombre, @objTecnicoRevisorId)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo")
			cmdUpdate.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdUpdate.Parameters.Add("@objTecnicoRevisorId", SqlDbType.Int, 4, "objTecnicoRevisorId")
			cmdUpdate.Parameters.Add("@wRadTecnicoID", SqlDbType.Int, 4, "RadTecnicoID")
			cmdUpdate.CommandText = "UPDATE radTecnico SET Codigo=@Codigo, Nombre=@Nombre, objTecnicoRevisorId=@objTecnicoRevisorId WHERE RadTecnicoID= @wRadTecnicoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "radTecnico")
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
    ''' Devuelve de la base de datos un objeto radTecnico
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_RadTecnicoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from radTecnico where " & " RadTecnicoID = " & p_RadTecnicoID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_RadTecnicoID = dr("RadTecnicoID")
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))
				m_objTecnicoRevisorId = IIf(IsDBNull(dr("objTecnicoRevisorId")), Nothing, dr("objTecnicoRevisorId"))
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
    ''' Devuelve de la base de datos un objeto radTecnico usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from radTecnico where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_RadTecnicoID = dr("RadTecnicoID")
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))
				m_objTecnicoRevisorId = IIf(IsDBNull(dr("objTecnicoRevisorId")), Nothing, dr("objTecnicoRevisorId"))
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
    ''' Trae de la base de datos un conjunto de objetos radTecnico en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from radTecnico"

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
			ds.Tables(0).TableName = "radTecnico"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos radTecnico en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from radTecnico"

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
			ds.Tables(0).TableName = "radTecnico"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos radTecnico en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from radTecnico"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase radTecnico.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into radTecnico("
		sCommand &= "Codigo,"
		sCommand &= "Nombre,"
		sCommand &= "objTecnicoRevisorId) values ("		
		sCommand &= "@Codigo,"
		sCommand &= "@Nombre,"
		sCommand &= "@objTecnicoRevisorId)"		
	
		sCommand &= " select "
		sCommand &= "@RadTecnicoID = RadTecnicoID from radTecnico where "		
		sCommand &= "RadTecnicoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(3) As SqlParameter
		arParams(0) = New SqlParameter("@RadTecnicoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Codigo
        End If
		arParams(2) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre
        End If
		arParams(3) = New SqlParameter("@objTecnicoRevisorId", SqlDbType.Int)		
		If IsDBNull(m_objTecnicoRevisorId) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objTecnicoRevisorId
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_RadTecnicoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto radTecnico en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update radTecnico set "		
		sCommand &= "Codigo = @Codigo,"
		sCommand &= "Nombre = @Nombre,"
		sCommand &= "objTecnicoRevisorId = @objTecnicoRevisorId"		
		sCommand &= " where "	
		sCommand &= "RadTecnicoID = @RadTecnicoID"					
		
		Dim arParams(3) As SqlParameter
		arParams(0) = New SqlParameter("@RadTecnicoID", SqlDbType.Int)		
		If IsDBNull(m_RadTecnicoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_RadTecnicoID
        End If
		arParams(1) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Codigo
        End If
		arParams(2) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre
        End If
		arParams(3) = New SqlParameter("@objTecnicoRevisorId", SqlDbType.Int)		
		If IsDBNull(m_objTecnicoRevisorId) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objTecnicoRevisorId
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
    ''' Borra un objeto radTecnico de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from radTecnico where " & " RadTecnicoID = " & m_RadTecnicoID
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
    ''' Borra un objeto radTecnico de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_RadTecnicoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from radTecnico where " & " RadTecnicoID = " & p_RadTecnicoID
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
    ''' Borra objetos radTecnico de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from radTecnico where " & pWhere
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
