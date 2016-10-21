Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivPedidos		

#Region " Variables Miembro " 
	Protected m_SivPedidoID As Integer 
	Protected m_objEncargoID As Nullable(Of Integer) 
	Protected m_objEstadoID As Integer 
	Protected m_objProveedorID As Integer 
	Protected m_FechaPedido As Nullable(Of Date) 
	Protected m_FechaAutorizacion As Nullable(Of Date) 
	Protected m_Observaciones As String = Nothing 
	Protected m_UsuarioAutorizacion As String = Nothing 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SivPedidoID() As Integer
        Get
            Return (m_SivPedidoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivPedidoID = Value
		End Set
    End Property
	
	Public Property objEncargoID() As Nullable(Of Integer)
        Get
            Return (m_objEncargoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEncargoID = Value
		End Set
    End Property
	
	Public Property objEstadoID() As Integer
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEstadoID = Value
		End Set
    End Property
	
	Public Property objProveedorID() As Integer
        Get
            Return (m_objProveedorID)
        End Get
		Set(ByVal Value As Integer)					
			m_objProveedorID = Value
		End Set
    End Property
	
	Public Property FechaPedido() As Nullable(Of Date)
        Get
            Return (m_FechaPedido)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaPedido = Value
		End Set
    End Property
	
	Public Property FechaAutorizacion() As Nullable(Of Date)
        Get
            Return (m_FechaAutorizacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaAutorizacion = Value
		End Set
    End Property
	
	Public Property Observaciones() As String
        Get
            Return (m_Observaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 250 Then
					Throw New ArgumentOutOfRangeException("Observaciones", Value.ToString(), "Valor inv?lido para SivPedidos.Observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (250).")
				End If
			End If
			m_Observaciones = Value
		End Set
    End Property
	
	Public Property UsuarioAutorizacion() As String
        Get
            Return (m_UsuarioAutorizacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioAutorizacion", Value.ToString(), "Valor inv?lido para SivPedidos.UsuarioAutorizacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioAutorizacion = Value
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
	
	Public Property FechaCreacion() As Date
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Date)					
			m_FechaCreacion = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivPedidos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivPedidos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Observaciones"
				Return	250
			Case "UsuarioAutorizacion"
				Return	30
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
    ''' Salva un DataSet del tipo de la tabla SivPedidos en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivPedidos </param>    
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
			cmdDelete.Parameters.Add("@SivPedidoID", SqlDbType.Int, 4, "SivPedidoID" )
			cmdDelete.CommandText = "DELETE FROM  SivPedidos WHERE SivPedidoID= @SivPedidoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objEncargoID", SqlDbType.Int, 4, "objEncargoID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objProveedorID", SqlDbType.Int, 4, "objProveedorID")
			cmdInsert.Parameters.Add("@FechaPedido", SqlDbType.DateTime, 8, "FechaPedido")
			cmdInsert.Parameters.Add("@FechaAutorizacion", SqlDbType.DateTime, 8, "FechaAutorizacion")
			cmdInsert.Parameters.Add("@Observaciones", SqlDbType.VarChar, 250, "Observaciones")
			cmdInsert.Parameters.Add("@UsuarioAutorizacion", SqlDbType.VarChar, 30, "UsuarioAutorizacion")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SivPedidos ( objEncargoID, objEstadoID, objProveedorID, FechaPedido, FechaAutorizacion, Observaciones, UsuarioAutorizacion, Activo, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objEncargoID, @objEstadoID, @objProveedorID, @FechaPedido, @FechaAutorizacion, @Observaciones, @UsuarioAutorizacion, @Activo, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objEncargoID", SqlDbType.Int, 4, "objEncargoID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objProveedorID", SqlDbType.Int, 4, "objProveedorID")
			cmdUpdate.Parameters.Add("@FechaPedido", SqlDbType.DateTime, 8, "FechaPedido")
			cmdUpdate.Parameters.Add("@FechaAutorizacion", SqlDbType.DateTime, 8, "FechaAutorizacion")
			cmdUpdate.Parameters.Add("@Observaciones", SqlDbType.VarChar, 250, "Observaciones")
			cmdUpdate.Parameters.Add("@UsuarioAutorizacion", SqlDbType.VarChar, 30, "UsuarioAutorizacion")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSivPedidoID", SqlDbType.Int, 4, "SivPedidoID")
			cmdUpdate.CommandText = "UPDATE SivPedidos SET objEncargoID=@objEncargoID, objEstadoID=@objEstadoID, objProveedorID=@objProveedorID, FechaPedido=@FechaPedido, FechaAutorizacion=@FechaAutorizacion, Observaciones=@Observaciones, UsuarioAutorizacion=@UsuarioAutorizacion, Activo=@Activo, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SivPedidoID= @wSivPedidoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivPedidos")
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
    ''' Devuelve de la base de datos un objeto SivPedidos
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivPedidoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivPedidos where " & " SivPedidoID = " & p_SivPedidoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivPedidoID = dr("SivPedidoID")
				m_objEncargoID = IIf(IsDBNull(dr("objEncargoID")), Nothing, dr("objEncargoID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objProveedorID = IIf(IsDBNull(dr("objProveedorID")), Nothing, dr("objProveedorID"))					
				m_FechaPedido = IIf(IsDBNull(dr("FechaPedido")), Nothing, dr("FechaPedido"))					
				m_FechaAutorizacion = IIf(IsDBNull(dr("FechaAutorizacion")), Nothing, dr("FechaAutorizacion"))					
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))					
				m_UsuarioAutorizacion = IIf(IsDBNull(dr("UsuarioAutorizacion")), Nothing, dr("UsuarioAutorizacion"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
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
    ''' Devuelve de la base de datos un objeto SivPedidos usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivPedidos where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivPedidoID = dr("SivPedidoID")
				m_objEncargoID = IIf(IsDBNull(dr("objEncargoID")), Nothing, dr("objEncargoID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objProveedorID = IIf(IsDBNull(dr("objProveedorID")), Nothing, dr("objProveedorID"))					
				m_FechaPedido = IIf(IsDBNull(dr("FechaPedido")), Nothing, dr("FechaPedido"))					
				m_FechaAutorizacion = IIf(IsDBNull(dr("FechaAutorizacion")), Nothing, dr("FechaAutorizacion"))					
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))					
				m_UsuarioAutorizacion = IIf(IsDBNull(dr("UsuarioAutorizacion")), Nothing, dr("UsuarioAutorizacion"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivPedidos en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivPedidos"

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
			ds.Tables(0).TableName = "SivPedidos"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivPedidos en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivPedidos"

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
			ds.Tables(0).TableName = "SivPedidos"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivPedidos en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivPedidos"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivPedidos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivPedidos("
		sCommand &= "objEncargoID,"
		sCommand &= "objEstadoID,"
		sCommand &= "objProveedorID,"
		sCommand &= "FechaPedido,"
		sCommand &= "FechaAutorizacion,"
		sCommand &= "Observaciones,"
		sCommand &= "UsuarioAutorizacion,"
		sCommand &= "Activo,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objEncargoID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@objProveedorID,"
		sCommand &= "@FechaPedido,"
		sCommand &= "@FechaAutorizacion,"
		sCommand &= "@Observaciones,"
		sCommand &= "@UsuarioAutorizacion,"
		sCommand &= "@Activo,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SivPedidoID = SivPedidoID from SivPedidos where "		
		sCommand &= "SivPedidoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SivPedidoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objEncargoID", SqlDbType.Int)		
		If IsDBNull(m_objEncargoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objEncargoID
        End If
		arParams(2) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEstadoID
        End If
		arParams(3) = New SqlParameter("@objProveedorID", SqlDbType.Int)		
		If IsDBNull(m_objProveedorID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objProveedorID
        End If
		arParams(4) = New SqlParameter("@FechaPedido", SqlDbType.DateTime)		
		If IsDBNull(m_FechaPedido) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaPedido
        End If
		arParams(5) = New SqlParameter("@FechaAutorizacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAutorizacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaAutorizacion
        End If
		arParams(6) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Observaciones
        End If
		arParams(7) = New SqlParameter("@UsuarioAutorizacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioAutorizacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioAutorizacion
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
		arParams(9) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCreacion
        End If
		arParams(10) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioCreacion
        End If
		arParams(11) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaModificacion
        End If
		arParams(12) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SivPedidoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivPedidos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivPedidos set "		
		sCommand &= "objEncargoID = @objEncargoID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objProveedorID = @objProveedorID,"
		sCommand &= "FechaPedido = @FechaPedido,"
		sCommand &= "FechaAutorizacion = @FechaAutorizacion,"
		sCommand &= "Observaciones = @Observaciones,"
		sCommand &= "UsuarioAutorizacion = @UsuarioAutorizacion,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SivPedidoID = @SivPedidoID"					
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SivPedidoID", SqlDbType.Int)		
		If IsDBNull(m_SivPedidoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivPedidoID
        End If
		arParams(1) = New SqlParameter("@objEncargoID", SqlDbType.Int)		
		If IsDBNull(m_objEncargoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objEncargoID
        End If
		arParams(2) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEstadoID
        End If
		arParams(3) = New SqlParameter("@objProveedorID", SqlDbType.Int)		
		If IsDBNull(m_objProveedorID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objProveedorID
        End If
		arParams(4) = New SqlParameter("@FechaPedido", SqlDbType.DateTime)		
		If IsDBNull(m_FechaPedido) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaPedido
        End If
		arParams(5) = New SqlParameter("@FechaAutorizacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAutorizacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaAutorizacion
        End If
		arParams(6) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Observaciones
        End If
		arParams(7) = New SqlParameter("@UsuarioAutorizacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioAutorizacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioAutorizacion
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
		arParams(9) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCreacion
        End If
		arParams(10) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioCreacion
        End If
		arParams(11) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaModificacion
        End If
		arParams(12) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SivPedidos de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivPedidos where " & " SivPedidoID = " & m_SivPedidoID
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
    ''' Borra un objeto SivPedidos de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivPedidoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivPedidos where " & " SivPedidoID = " & p_SivPedidoID
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
    ''' Borra objetos SivPedidos de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivPedidos where " & pWhere
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
