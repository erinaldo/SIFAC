Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class txRC_ReciboDetNC_Step2		

#Region " Variables Miembro " 
	Protected m_SccReciboNotaCreditoID As Integer 
	Protected m_objReciboCajaID As Integer 
	Protected m_objNotaCreditoID As Integer 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
#End Region

#Region " Propiedades "
	Public Property SccReciboNotaCreditoID() As Integer
        Get
            Return (m_SccReciboNotaCreditoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccReciboNotaCreditoID = Value
		End Set
    End Property
	
	Public Property objReciboCajaID() As Integer
        Get
            Return (m_objReciboCajaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objReciboCajaID = Value
		End Set
    End Property
	
	Public Property objNotaCreditoID() As Integer
        Get
            Return (m_objNotaCreditoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objNotaCreditoID = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para txRC_ReciboDetNC_Step2.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	Public Property FechaCreacion() As Date
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Date)					
			m_FechaCreacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "UsuarioCreacion"
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
    ''' Salva un DataSet del tipo de la tabla txRC_ReciboDetNC_Step2 en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla txRC_ReciboDetNC_Step2 </param>    
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
			cmdDelete.Parameters.Add("@SccReciboNotaCreditoID", SqlDbType.Int, 4, "SccReciboNotaCreditoID" )
			cmdDelete.CommandText = "DELETE FROM  txRC_ReciboDetNC_Step2 WHERE SccReciboNotaCreditoID= @SccReciboNotaCreditoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objReciboCajaID", SqlDbType.Int, 4, "objReciboCajaID")
			cmdInsert.Parameters.Add("@objNotaCreditoID", SqlDbType.Int, 4, "objNotaCreditoID")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.CommandText = "INSERT INTO txRC_ReciboDetNC_Step2 ( objReciboCajaID, objNotaCreditoID, UsuarioCreacion, FechaCreacion) VALUES ( @objReciboCajaID, @objNotaCreditoID, @UsuarioCreacion, @FechaCreacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objReciboCajaID", SqlDbType.Int, 4, "objReciboCajaID")
			cmdUpdate.Parameters.Add("@objNotaCreditoID", SqlDbType.Int, 4, "objNotaCreditoID")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@wSccReciboNotaCreditoID", SqlDbType.Int, 4, "SccReciboNotaCreditoID")
			cmdUpdate.CommandText = "UPDATE txRC_ReciboDetNC_Step2 SET objReciboCajaID=@objReciboCajaID, objNotaCreditoID=@objNotaCreditoID, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion WHERE SccReciboNotaCreditoID= @wSccReciboNotaCreditoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "txRC_ReciboDetNC_Step2")
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
    ''' Devuelve de la base de datos un objeto txRC_ReciboDetNC_Step2
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccReciboNotaCreditoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from txRC_ReciboDetNC_Step2 where " & " SccReciboNotaCreditoID = " & p_SccReciboNotaCreditoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccReciboNotaCreditoID = dr("SccReciboNotaCreditoID")
				m_objReciboCajaID = IIf(IsDBNull(dr("objReciboCajaID")), Nothing, dr("objReciboCajaID"))					
				m_objNotaCreditoID = IIf(IsDBNull(dr("objNotaCreditoID")), Nothing, dr("objNotaCreditoID"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
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
    ''' Devuelve de la base de datos un objeto txRC_ReciboDetNC_Step2 usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from txRC_ReciboDetNC_Step2 where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccReciboNotaCreditoID = dr("SccReciboNotaCreditoID")
				m_objReciboCajaID = IIf(IsDBNull(dr("objReciboCajaID")), Nothing, dr("objReciboCajaID"))					
				m_objNotaCreditoID = IIf(IsDBNull(dr("objNotaCreditoID")), Nothing, dr("objNotaCreditoID"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
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
    ''' Trae de la base de datos un conjunto de objetos txRC_ReciboDetNC_Step2 en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from txRC_ReciboDetNC_Step2"

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
			ds.Tables(0).TableName = "txRC_ReciboDetNC_Step2"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos txRC_ReciboDetNC_Step2 en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from txRC_ReciboDetNC_Step2"

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
			ds.Tables(0).TableName = "txRC_ReciboDetNC_Step2"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos txRC_ReciboDetNC_Step2 en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from txRC_ReciboDetNC_Step2"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase txRC_ReciboDetNC_Step2.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into txRC_ReciboDetNC_Step2("
		sCommand &= "objReciboCajaID,"
		sCommand &= "objNotaCreditoID,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion) values ("		
		sCommand &= "@objReciboCajaID,"
		sCommand &= "@objNotaCreditoID,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion)"		
	
		sCommand &= " select "
		sCommand &= "@SccReciboNotaCreditoID = SccReciboNotaCreditoID from txRC_ReciboDetNC_Step2 where "		
		sCommand &= "SccReciboNotaCreditoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(4) As SqlParameter
		arParams(0) = New SqlParameter("@SccReciboNotaCreditoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objReciboCajaID", SqlDbType.Int)		
		If IsDBNull(m_objReciboCajaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objReciboCajaID
        End If
		arParams(2) = New SqlParameter("@objNotaCreditoID", SqlDbType.Int)		
		If IsDBNull(m_objNotaCreditoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objNotaCreditoID
        End If
		arParams(3) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_UsuarioCreacion
        End If
		arParams(4) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaCreacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccReciboNotaCreditoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto txRC_ReciboDetNC_Step2 en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update txRC_ReciboDetNC_Step2 set "		
		sCommand &= "objReciboCajaID = @objReciboCajaID,"
		sCommand &= "objNotaCreditoID = @objNotaCreditoID,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion"		
		sCommand &= " where "	
		sCommand &= "SccReciboNotaCreditoID = @SccReciboNotaCreditoID"					
		
		Dim arParams(4) As SqlParameter
		arParams(0) = New SqlParameter("@SccReciboNotaCreditoID", SqlDbType.Int)		
		If IsDBNull(m_SccReciboNotaCreditoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccReciboNotaCreditoID
        End If
		arParams(1) = New SqlParameter("@objReciboCajaID", SqlDbType.Int)		
		If IsDBNull(m_objReciboCajaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objReciboCajaID
        End If
		arParams(2) = New SqlParameter("@objNotaCreditoID", SqlDbType.Int)		
		If IsDBNull(m_objNotaCreditoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objNotaCreditoID
        End If
		arParams(3) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_UsuarioCreacion
        End If
		arParams(4) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaCreacion
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
    ''' Borra un objeto txRC_ReciboDetNC_Step2 de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from txRC_ReciboDetNC_Step2 where " & " SccReciboNotaCreditoID = " & m_SccReciboNotaCreditoID
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
    ''' Borra un objeto txRC_ReciboDetNC_Step2 de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccReciboNotaCreditoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from txRC_ReciboDetNC_Step2 where " & " SccReciboNotaCreditoID = " & p_SccReciboNotaCreditoID
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
    ''' Borra objetos txRC_ReciboDetNC_Step2 de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from txRC_ReciboDetNC_Step2 where " & pWhere
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
