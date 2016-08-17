Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccClientes		

#Region " Variables Miembro " 
	Protected m_ClienteID As Integer 
	Protected m_objPersonaID As Nullable(Of Integer) 
	Protected m_OrdenCobro As Nullable(Of Integer) 
	Protected m_objRutaID As Nullable(Of Integer) 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property ClienteID() As Integer
        Get
            Return (m_ClienteID)
        End Get
		Set(ByVal Value As Integer)					
			m_ClienteID = Value
		End Set
    End Property
	
	Public Property objPersonaID() As Nullable(Of Integer)
        Get
            Return (m_objPersonaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objPersonaID = Value
		End Set
    End Property
	
	Public Property OrdenCobro() As Nullable(Of Integer)
        Get
            Return (m_OrdenCobro)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_OrdenCobro = Value
		End Set
    End Property
	
	Public Property objRutaID() As Nullable(Of Integer)
        Get
            Return (m_objRutaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objRutaID = Value
		End Set
    End Property
	
	Public Property Activo() As Nullable(Of Boolean)
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Activo = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccClientes.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	Public Property FechaCreacion() As Nullable(Of Date)
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaCreacion = Value
		End Set
    End Property
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccClientes.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property FechaModificacion() As Nullable(Of Date)
        Get
            Return (m_FechaModificacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
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
    ''' Salva un DataSet del tipo de la tabla SccClientes en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccClientes </param>    
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
			cmdDelete.Parameters.Add("@ClienteID", SqlDbType.Int, 4, "ClienteID" )
			cmdDelete.CommandText = "DELETE FROM  SccClientes WHERE ClienteID= @ClienteID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objPersonaID", SqlDbType.Int, 4, "objPersonaID")
			cmdInsert.Parameters.Add("@OrdenCobro", SqlDbType.Int, 4, "OrdenCobro")
			cmdInsert.Parameters.Add("@objRutaID", SqlDbType.Int, 4, "objRutaID")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SccClientes ( objPersonaID, OrdenCobro, objRutaID, Activo, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objPersonaID, @OrdenCobro, @objRutaID, @Activo, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objPersonaID", SqlDbType.Int, 4, "objPersonaID")
			cmdUpdate.Parameters.Add("@OrdenCobro", SqlDbType.Int, 4, "OrdenCobro")
			cmdUpdate.Parameters.Add("@objRutaID", SqlDbType.Int, 4, "objRutaID")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wClienteID", SqlDbType.Int, 4, "ClienteID")
			cmdUpdate.CommandText = "UPDATE SccClientes SET objPersonaID=@objPersonaID, OrdenCobro=@OrdenCobro, objRutaID=@objRutaID, Activo=@Activo, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE ClienteID= @wClienteID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccClientes")
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
    ''' Devuelve de la base de datos un objeto SccClientes
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ClienteID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccClientes where " & " ClienteID = " & p_ClienteID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_ClienteID = dr("ClienteID")
				m_objPersonaID = IIf(IsDBNull(dr("objPersonaID")), Nothing, dr("objPersonaID"))					
				m_OrdenCobro = IIf(IsDBNull(dr("OrdenCobro")), Nothing, dr("OrdenCobro"))					
				m_objRutaID = IIf(IsDBNull(dr("objRutaID")), Nothing, dr("objRutaID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
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
    ''' Devuelve de la base de datos un objeto SccClientes usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccClientes where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_ClienteID = dr("ClienteID")
				m_objPersonaID = IIf(IsDBNull(dr("objPersonaID")), Nothing, dr("objPersonaID"))					
				m_OrdenCobro = IIf(IsDBNull(dr("OrdenCobro")), Nothing, dr("OrdenCobro"))					
				m_objRutaID = IIf(IsDBNull(dr("objRutaID")), Nothing, dr("objRutaID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccClientes en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccClientes"

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
			ds.Tables(0).TableName = "SccClientes"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccClientes en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccClientes"

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
			ds.Tables(0).TableName = "SccClientes"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccClientes en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccClientes"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccClientes.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccClientes("
		sCommand &= "objPersonaID,"
		sCommand &= "OrdenCobro,"
		sCommand &= "objRutaID,"
		sCommand &= "Activo,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objPersonaID,"
		sCommand &= "@OrdenCobro,"
		sCommand &= "@objRutaID,"
		sCommand &= "@Activo,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ClienteID = ClienteID from SccClientes where "		
		sCommand &= "ClienteID = SCOPE_IDENTITY()"
		
		
		Dim arParams(8) As SqlParameter
		arParams(0) = New SqlParameter("@ClienteID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objPersonaID", SqlDbType.Int)		
		If IsDBNull(m_objPersonaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPersonaID
        End If
		arParams(2) = New SqlParameter("@OrdenCobro", SqlDbType.Int)		
		If IsDBNull(m_OrdenCobro) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_OrdenCobro
        End If
		arParams(3) = New SqlParameter("@objRutaID", SqlDbType.Int)		
		If IsDBNull(m_objRutaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objRutaID
        End If
		arParams(4) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Activo
        End If
		arParams(5) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_UsuarioCreacion
        End If
		arParams(6) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCreacion
        End If
		arParams(7) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioModificacion
        End If
		arParams(8) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ClienteID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccClientes en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccClientes set "		
		sCommand &= "objPersonaID = @objPersonaID,"
		sCommand &= "OrdenCobro = @OrdenCobro,"
		sCommand &= "objRutaID = @objRutaID,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "ClienteID = @ClienteID"					
		
		Dim arParams(8) As SqlParameter
		arParams(0) = New SqlParameter("@ClienteID", SqlDbType.Int)		
		If IsDBNull(m_ClienteID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ClienteID
        End If
		arParams(1) = New SqlParameter("@objPersonaID", SqlDbType.Int)		
		If IsDBNull(m_objPersonaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPersonaID
        End If
		arParams(2) = New SqlParameter("@OrdenCobro", SqlDbType.Int)		
		If IsDBNull(m_OrdenCobro) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_OrdenCobro
        End If
		arParams(3) = New SqlParameter("@objRutaID", SqlDbType.Int)		
		If IsDBNull(m_objRutaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objRutaID
        End If
		arParams(4) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Activo
        End If
		arParams(5) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_UsuarioCreacion
        End If
		arParams(6) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCreacion
        End If
		arParams(7) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioModificacion
        End If
		arParams(8) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaModificacion
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
    ''' Borra un objeto SccClientes de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccClientes where " & " ClienteID = " & m_ClienteID
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
    ''' Borra un objeto SccClientes de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ClienteID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccClientes where " & " ClienteID = " & p_ClienteID
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
    ''' Borra objetos SccClientes de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccClientes where " & pWhere
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
