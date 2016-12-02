Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccCajas		

#Region " Variables Miembro " 
	Protected m_SccCajaID As Integer 
	Protected m_Nombre As String = Nothing 
	Protected m_objCajeroID As Nullable(Of Integer) 
	Protected m_Ubicacion As String = Nothing 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_Codigo As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SccCajaID() As Integer
        Get
            Return (m_SccCajaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccCajaID = Value
		End Set
    End Property
	
	Public Property Nombre() As String
        Get
            Return (m_Nombre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Nombre", Value.ToString(), "Valor inv?lido para SccCajas.Nombre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Nombre = Value
		End Set
    End Property
	
	Public Property objCajeroID() As Nullable(Of Integer)
        Get
            Return (m_objCajeroID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajeroID = Value
		End Set
    End Property
	
	Public Property Ubicacion() As String
        Get
            Return (m_Ubicacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Ubicacion", Value.ToString(), "Valor inv?lido para SccCajas.Ubicacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Ubicacion = Value
		End Set
    End Property
	
	Public Property Activa() As Nullable(Of Boolean)
        Get
            Return (m_Activa)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Activa = Value
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
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccCajas.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioCreacion = Value
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
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccCajas.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property Codigo() As String
        Get
            Return (m_Codigo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Codigo", Value.ToString(), "Valor inv?lido para SccCajas.Codigo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Codigo = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Nombre"
				Return	50
			Case "Ubicacion"
				Return	50
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "Codigo"
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
    ''' Salva un DataSet del tipo de la tabla SccCajas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccCajas </param>    
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
			cmdDelete.Parameters.Add("@SccCajaID", SqlDbType.Int, 4, "SccCajaID" )
			cmdDelete.CommandText = "DELETE FROM  SccCajas WHERE SccCajaID= @SccCajaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdInsert.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdInsert.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50, "Ubicacion")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo")
			cmdInsert.CommandText = "INSERT INTO SccCajas ( Nombre, objCajeroID, Ubicacion, Activa, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Codigo) VALUES ( @Nombre, @objCajeroID, @Ubicacion, @Activa, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Codigo)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdUpdate.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdUpdate.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50, "Ubicacion")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo")
			cmdUpdate.Parameters.Add("@wSccCajaID", SqlDbType.Int, 4, "SccCajaID")
			cmdUpdate.CommandText = "UPDATE SccCajas SET Nombre=@Nombre, objCajeroID=@objCajeroID, Ubicacion=@Ubicacion, Activa=@Activa, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Codigo=@Codigo WHERE SccCajaID= @wSccCajaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccCajas")
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
    ''' Devuelve de la base de datos un objeto SccCajas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccCajaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCajas where " & " SccCajaID = " & p_SccCajaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccCajaID = dr("SccCajaID")
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))					
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))					
				m_Ubicacion = IIf(IsDBNull(dr("Ubicacion")), Nothing, dr("Ubicacion"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))					
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
    ''' Devuelve de la base de datos un objeto SccCajas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCajas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccCajaID = dr("SccCajaID")
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))					
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))					
				m_Ubicacion = IIf(IsDBNull(dr("Ubicacion")), Nothing, dr("Ubicacion"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccCajas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccCajas"

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
			ds.Tables(0).TableName = "SccCajas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCajas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccCajas"

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
			ds.Tables(0).TableName = "SccCajas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCajas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccCajas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccCajas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccCajas("
		sCommand &= "Nombre,"
		sCommand &= "objCajeroID,"
		sCommand &= "Ubicacion,"
		sCommand &= "Activa,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "Codigo) values ("		
		sCommand &= "@Nombre,"
		sCommand &= "@objCajeroID,"
		sCommand &= "@Ubicacion,"
		sCommand &= "@Activa,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@Codigo)"		
	
		sCommand &= " select "
		sCommand &= "@SccCajaID = SccCajaID from SccCajas where "		
		sCommand &= "SccCajaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SccCajaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre
        End If
		arParams(2) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCajeroID
        End If
		arParams(3) = New SqlParameter("@Ubicacion", SqlDbType.VarChar)		
		If IsDBNull(m_Ubicacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Ubicacion
        End If
		arParams(4) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Activa
        End If
		arParams(5) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaCreacion
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaModificacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Codigo
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccCajaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccCajas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccCajas set "		
		sCommand &= "Nombre = @Nombre,"
		sCommand &= "objCajeroID = @objCajeroID,"
		sCommand &= "Ubicacion = @Ubicacion,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "Codigo = @Codigo"		
		sCommand &= " where "	
		sCommand &= "SccCajaID = @SccCajaID"					
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SccCajaID", SqlDbType.Int)		
		If IsDBNull(m_SccCajaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccCajaID
        End If
		arParams(1) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre
        End If
		arParams(2) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCajeroID
        End If
		arParams(3) = New SqlParameter("@Ubicacion", SqlDbType.VarChar)		
		If IsDBNull(m_Ubicacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Ubicacion
        End If
		arParams(4) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Activa
        End If
		arParams(5) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaCreacion
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaModificacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Codigo
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
    ''' Borra un objeto SccCajas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCajas where " & " SccCajaID = " & m_SccCajaID
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
    ''' Borra un objeto SccCajas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccCajaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCajas where " & " SccCajaID = " & p_SccCajaID
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
    ''' Borra objetos SccCajas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCajas where " & pWhere
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
