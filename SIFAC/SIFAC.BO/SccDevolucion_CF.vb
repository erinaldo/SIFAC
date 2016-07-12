Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccDevolucion		

#Region " Variables Miembro " 
	Protected m_SccDevolucionID As Integer 
	Protected m_Numero As Integer 
	Protected m_Fecha As Date 
	Protected m_TotalDevolucion As Nullable(Of Decimal) 
	Protected m_objSccCuentaID As String = Nothing 
	Protected m_ObjSucursalID As Integer 
	Protected m_SucursalDevolucionID As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_objEstadoID As Integer 
	Protected m_objFacturaID As Integer 
#End Region

#Region " Propiedades "
	Public Property SccDevolucionID() As Integer
        Get
            Return (m_SccDevolucionID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccDevolucionID = Value
		End Set
    End Property
	
	Public Property Numero() As Integer
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As Integer)					
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
	
	Public Property TotalDevolucion() As Nullable(Of Decimal)
        Get
            Return (m_TotalDevolucion)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TotalDevolucion = Value
		End Set
    End Property
	
	Public Property objSccCuentaID() As String
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 15 Then
					Throw New ArgumentOutOfRangeException("objSccCuentaID", Value.ToString(), "Valor inv?lido para SccDevolucion.objSccCuentaID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (15).")
				End If
			End If
			m_objSccCuentaID = Value
		End Set
    End Property
	
	Public Property ObjSucursalID() As Integer
        Get
            Return (m_ObjSucursalID)
        End Get
		Set(ByVal Value As Integer)					
			m_ObjSucursalID = Value
		End Set
    End Property
	
	Public Property SucursalDevolucionID() As Nullable(Of Integer)
        Get
            Return (m_SucursalDevolucionID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_SucursalDevolucionID = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccDevolucion.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccDevolucion.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property objEstadoID() As Integer
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEstadoID = Value
		End Set
    End Property
	
	Public Property objFacturaID() As Integer
        Get
            Return (m_objFacturaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objFacturaID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "TotalDevolucion"
				Return	11
			Case "objSccCuentaID"
				Return	15
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
			Case "TotalDevolucion"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccDevolucion en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccDevolucion </param>    
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
			cmdDelete.Parameters.Add("@SccDevolucionID", SqlDbType.Int, 4, "SccDevolucionID" )
			cmdDelete.CommandText = "DELETE FROM  SccDevolucion WHERE SccDevolucionID= @SccDevolucionID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Numero", SqlDbType.Int, 4, "Numero")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@TotalDevolucion", SqlDbType.Decimal, 9, "TotalDevolucion")
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.VarChar, 15, "objSccCuentaID")
			cmdInsert.Parameters.Add("@ObjSucursalID", SqlDbType.Int, 4, "ObjSucursalID")
			cmdInsert.Parameters.Add("@SucursalDevolucionID", SqlDbType.Int, 4, "SucursalDevolucionID")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objFacturaID", SqlDbType.Int, 4, "objFacturaID")
			cmdInsert.CommandText = "INSERT INTO SccDevolucion ( Numero, Fecha, TotalDevolucion, objSccCuentaID, ObjSucursalID, SucursalDevolucionID, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, objEstadoID, objFacturaID) VALUES ( @Numero, @Fecha, @TotalDevolucion, @objSccCuentaID, @ObjSucursalID, @SucursalDevolucionID, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @objEstadoID, @objFacturaID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.Int, 4, "Numero")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@TotalDevolucion", SqlDbType.Decimal, 9, "TotalDevolucion")
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.VarChar, 15, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@ObjSucursalID", SqlDbType.Int, 4, "ObjSucursalID")
			cmdUpdate.Parameters.Add("@SucursalDevolucionID", SqlDbType.Int, 4, "SucursalDevolucionID")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objFacturaID", SqlDbType.Int, 4, "objFacturaID")
			cmdUpdate.Parameters.Add("@wSccDevolucionID", SqlDbType.Int, 4, "SccDevolucionID")
			cmdUpdate.CommandText = "UPDATE SccDevolucion SET Numero=@Numero, Fecha=@Fecha, TotalDevolucion=@TotalDevolucion, objSccCuentaID=@objSccCuentaID, ObjSucursalID=@ObjSucursalID, SucursalDevolucionID=@SucursalDevolucionID, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, objEstadoID=@objEstadoID, objFacturaID=@objFacturaID WHERE SccDevolucionID= @wSccDevolucionID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccDevolucion")
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
    ''' Devuelve de la base de datos un objeto SccDevolucion
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccDevolucionID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccDevolucion where " & " SccDevolucionID = " & p_SccDevolucionID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccDevolucionID = dr("SccDevolucionID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_TotalDevolucion = IIf(IsDBNull(dr("TotalDevolucion")), Nothing, dr("TotalDevolucion"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_ObjSucursalID = IIf(IsDBNull(dr("ObjSucursalID")), Nothing, dr("ObjSucursalID"))					
				m_SucursalDevolucionID = IIf(IsDBNull(dr("SucursalDevolucionID")), Nothing, dr("SucursalDevolucionID"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objFacturaID = IIf(IsDBNull(dr("objFacturaID")), Nothing, dr("objFacturaID"))					
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
    ''' Devuelve de la base de datos un objeto SccDevolucion usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccDevolucion where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccDevolucionID = dr("SccDevolucionID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_TotalDevolucion = IIf(IsDBNull(dr("TotalDevolucion")), Nothing, dr("TotalDevolucion"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_ObjSucursalID = IIf(IsDBNull(dr("ObjSucursalID")), Nothing, dr("ObjSucursalID"))					
				m_SucursalDevolucionID = IIf(IsDBNull(dr("SucursalDevolucionID")), Nothing, dr("SucursalDevolucionID"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objFacturaID = IIf(IsDBNull(dr("objFacturaID")), Nothing, dr("objFacturaID"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccDevolucion en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccDevolucion"

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
			ds.Tables(0).TableName = "SccDevolucion"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccDevolucion en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccDevolucion"

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
			ds.Tables(0).TableName = "SccDevolucion"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccDevolucion en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccDevolucion"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccDevolucion.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccDevolucion("
		sCommand &= "Numero,"
		sCommand &= "Fecha,"
		sCommand &= "TotalDevolucion,"
		sCommand &= "objSccCuentaID,"
		sCommand &= "ObjSucursalID,"
		sCommand &= "SucursalDevolucionID,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "objEstadoID,"
		sCommand &= "objFacturaID) values ("		
		sCommand &= "@Numero,"
		sCommand &= "@Fecha,"
		sCommand &= "@TotalDevolucion,"
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@ObjSucursalID,"
		sCommand &= "@SucursalDevolucionID,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@objFacturaID)"		
	
		sCommand &= " select "
		sCommand &= "@SccDevolucionID = SccDevolucionID from SccDevolucion where "		
		sCommand &= "SccDevolucionID = SCOPE_IDENTITY()"
		
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SccDevolucionID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Numero", SqlDbType.Int)		
		If IsDBNull(m_Numero) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Numero
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@TotalDevolucion", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDevolucion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_TotalDevolucion
        End If
		arParams(4) = New SqlParameter("@objSccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objSccCuentaID
        End If
		arParams(5) = New SqlParameter("@ObjSucursalID", SqlDbType.Int)		
		If IsDBNull(m_ObjSucursalID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_ObjSucursalID
        End If
		arParams(6) = New SqlParameter("@SucursalDevolucionID", SqlDbType.Int)		
		If IsDBNull(m_SucursalDevolucionID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_SucursalDevolucionID
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objEstadoID
        End If
		arParams(12) = New SqlParameter("@objFacturaID", SqlDbType.Int)		
		If IsDBNull(m_objFacturaID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objFacturaID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccDevolucionID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccDevolucion en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccDevolucion set "		
		sCommand &= "Numero = @Numero,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "TotalDevolucion = @TotalDevolucion,"
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "ObjSucursalID = @ObjSucursalID,"
		sCommand &= "SucursalDevolucionID = @SucursalDevolucionID,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objFacturaID = @objFacturaID"		
		sCommand &= " where "	
		sCommand &= "SccDevolucionID = @SccDevolucionID"					
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SccDevolucionID", SqlDbType.Int)		
		If IsDBNull(m_SccDevolucionID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccDevolucionID
        End If
		arParams(1) = New SqlParameter("@Numero", SqlDbType.Int)		
		If IsDBNull(m_Numero) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Numero
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@TotalDevolucion", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDevolucion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_TotalDevolucion
        End If
		arParams(4) = New SqlParameter("@objSccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objSccCuentaID
        End If
		arParams(5) = New SqlParameter("@ObjSucursalID", SqlDbType.Int)		
		If IsDBNull(m_ObjSucursalID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_ObjSucursalID
        End If
		arParams(6) = New SqlParameter("@SucursalDevolucionID", SqlDbType.Int)		
		If IsDBNull(m_SucursalDevolucionID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_SucursalDevolucionID
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objEstadoID
        End If
		arParams(12) = New SqlParameter("@objFacturaID", SqlDbType.Int)		
		If IsDBNull(m_objFacturaID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objFacturaID
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
    ''' Borra un objeto SccDevolucion de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccDevolucion where " & " SccDevolucionID = " & m_SccDevolucionID
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
    ''' Borra un objeto SccDevolucion de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccDevolucionID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccDevolucion where " & " SccDevolucionID = " & p_SccDevolucionID
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
    ''' Borra objetos SccDevolucion de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccDevolucion where " & pWhere
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
