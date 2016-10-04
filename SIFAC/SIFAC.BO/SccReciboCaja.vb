Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccReciboCaja		

#Region " Variables Miembro " 
	Protected m_SccReciboCajaID As Integer 
	Protected m_objEstadoID As Integer 
	Protected m_objSccCuentaID As Integer 
	Protected m_objSrhEmpleado As Nullable(Of Integer) 
	Protected m_Numero As String = Nothing 
	Protected m_Fecha As Date 
	Protected m_TotalRecibo As Decimal 
	Protected m_EsPagoPrima As Boolean 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SccReciboCajaID() As Integer
        Get
            Return (m_SccReciboCajaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccReciboCajaID = Value
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
	
	Public Property objSccCuentaID() As Integer
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objSccCuentaID = Value
		End Set
    End Property
	
	Public Property objSrhEmpleado() As Nullable(Of Integer)
        Get
            Return (m_objSrhEmpleado)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSrhEmpleado = Value
		End Set
    End Property
	
	Public Property Numero() As String
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 10 Then
					Throw New ArgumentOutOfRangeException("Numero", Value.ToString(), "Valor inv?lido para SccReciboCaja.Numero. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (10).")
				End If
			End If
			m_Numero = Value
		End Set
    End Property
	
	Public Property Fecha() As Date
        Get
            Return (m_Fecha)
        End Get
		Set(ByVal Value As Date)					
			m_Fecha = Value
		End Set
    End Property
	
	Public Property TotalRecibo() As Decimal
        Get
            Return (m_TotalRecibo)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalRecibo = Value
		End Set
    End Property
	
	Public Property EsPagoPrima() As Boolean
        Get
            Return (m_EsPagoPrima)
        End Get
		Set(ByVal Value As Boolean)					
			m_EsPagoPrima = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccReciboCaja.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccReciboCaja.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
			Case "Numero"
				Return	10
			Case "TotalRecibo"
				Return	11
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "TotalRecibo"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccReciboCaja en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccReciboCaja </param>    
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
			cmdDelete.Parameters.Add("@SccReciboCajaID", SqlDbType.Int, 4, "SccReciboCajaID" )
			cmdDelete.CommandText = "DELETE FROM  SccReciboCaja WHERE SccReciboCajaID= @SccReciboCajaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdInsert.Parameters.Add("@objSrhEmpleado", SqlDbType.Int, 4, "objSrhEmpleado")
			cmdInsert.Parameters.Add("@Numero", SqlDbType.VarChar, 10, "Numero")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@TotalRecibo", SqlDbType.Decimal, 9, "TotalRecibo")
			cmdInsert.Parameters.Add("@EsPagoPrima", SqlDbType.Bit, 1, "EsPagoPrima")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SccReciboCaja ( objEstadoID, objSccCuentaID, objSrhEmpleado, Numero, Fecha, TotalRecibo, EsPagoPrima, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objEstadoID, @objSccCuentaID, @objSrhEmpleado, @Numero, @Fecha, @TotalRecibo, @EsPagoPrima, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@objSrhEmpleado", SqlDbType.Int, 4, "objSrhEmpleado")
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.VarChar, 10, "Numero")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@TotalRecibo", SqlDbType.Decimal, 9, "TotalRecibo")
			cmdUpdate.Parameters.Add("@EsPagoPrima", SqlDbType.Bit, 1, "EsPagoPrima")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSccReciboCajaID", SqlDbType.Int, 4, "SccReciboCajaID")
			cmdUpdate.CommandText = "UPDATE SccReciboCaja SET objEstadoID=@objEstadoID, objSccCuentaID=@objSccCuentaID, objSrhEmpleado=@objSrhEmpleado, Numero=@Numero, Fecha=@Fecha, TotalRecibo=@TotalRecibo, EsPagoPrima=@EsPagoPrima, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SccReciboCajaID= @wSccReciboCajaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccReciboCaja")
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
    ''' Devuelve de la base de datos un objeto SccReciboCaja
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccReciboCajaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccReciboCaja where " & " SccReciboCajaID = " & p_SccReciboCajaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccReciboCajaID = dr("SccReciboCajaID")
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objSrhEmpleado = IIf(IsDBNull(dr("objSrhEmpleado")), Nothing, dr("objSrhEmpleado"))					
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_TotalRecibo = IIf(IsDBNull(dr("TotalRecibo")), Nothing, dr("TotalRecibo"))					
				m_EsPagoPrima = IIf(IsDBNull(dr("EsPagoPrima")), Nothing, dr("EsPagoPrima"))					
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
    ''' Devuelve de la base de datos un objeto SccReciboCaja usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccReciboCaja where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccReciboCajaID = dr("SccReciboCajaID")
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objSrhEmpleado = IIf(IsDBNull(dr("objSrhEmpleado")), Nothing, dr("objSrhEmpleado"))					
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_TotalRecibo = IIf(IsDBNull(dr("TotalRecibo")), Nothing, dr("TotalRecibo"))					
				m_EsPagoPrima = IIf(IsDBNull(dr("EsPagoPrima")), Nothing, dr("EsPagoPrima"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
			ds.Tables(0).TableName = "SccReciboCaja"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
			ds.Tables(0).TableName = "SccReciboCaja"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccReciboCaja.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccReciboCaja("
		sCommand &= "objEstadoID,"
		sCommand &= "objSccCuentaID,"
		sCommand &= "objSrhEmpleado,"
		sCommand &= "Numero,"
		sCommand &= "Fecha,"
		sCommand &= "TotalRecibo,"
		sCommand &= "EsPagoPrima,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objEstadoID,"
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@objSrhEmpleado,"
		sCommand &= "@Numero,"
		sCommand &= "@Fecha,"
		sCommand &= "@TotalRecibo,"
		sCommand &= "@EsPagoPrima,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SccReciboCajaID = SccReciboCajaID from SccReciboCaja where "		
		sCommand &= "SccReciboCajaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SccReciboCajaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objEstadoID
        End If
		arParams(2) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSccCuentaID
        End If
		arParams(3) = New SqlParameter("@objSrhEmpleado", SqlDbType.Int)		
		If IsDBNull(m_objSrhEmpleado) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objSrhEmpleado
        End If
		arParams(4) = New SqlParameter("@Numero", SqlDbType.VarChar)		
		If IsDBNull(m_Numero) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Numero
        End If
		arParams(5) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Fecha
        End If
		arParams(6) = New SqlParameter("@TotalRecibo", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_TotalRecibo
        End If
		arParams(7) = New SqlParameter("@EsPagoPrima", SqlDbType.Bit)		
		If IsDBNull(m_EsPagoPrima) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_EsPagoPrima
        End If
		arParams(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioCreacion
        End If
		arParams(9) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCreacion
        End If
		arParams(10) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioModificacion
        End If
		arParams(11) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccReciboCajaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccReciboCaja en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccReciboCaja set "		
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "objSrhEmpleado = @objSrhEmpleado,"
		sCommand &= "Numero = @Numero,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "TotalRecibo = @TotalRecibo,"
		sCommand &= "EsPagoPrima = @EsPagoPrima,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SccReciboCajaID = @SccReciboCajaID"					
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SccReciboCajaID", SqlDbType.Int)		
		If IsDBNull(m_SccReciboCajaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccReciboCajaID
        End If
		arParams(1) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objEstadoID
        End If
		arParams(2) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSccCuentaID
        End If
		arParams(3) = New SqlParameter("@objSrhEmpleado", SqlDbType.Int)		
		If IsDBNull(m_objSrhEmpleado) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objSrhEmpleado
        End If
		arParams(4) = New SqlParameter("@Numero", SqlDbType.VarChar)		
		If IsDBNull(m_Numero) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Numero
        End If
		arParams(5) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Fecha
        End If
		arParams(6) = New SqlParameter("@TotalRecibo", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_TotalRecibo
        End If
		arParams(7) = New SqlParameter("@EsPagoPrima", SqlDbType.Bit)		
		If IsDBNull(m_EsPagoPrima) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_EsPagoPrima
        End If
		arParams(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioCreacion
        End If
		arParams(9) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCreacion
        End If
		arParams(10) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioModificacion
        End If
		arParams(11) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaModificacion
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
    ''' Borra un objeto SccReciboCaja de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & " SccReciboCajaID = " & m_SccReciboCajaID
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
    ''' Borra un objeto SccReciboCaja de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccReciboCajaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & " SccReciboCajaID = " & p_SccReciboCajaID
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
    ''' Borra objetos SccReciboCaja de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & pWhere
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
