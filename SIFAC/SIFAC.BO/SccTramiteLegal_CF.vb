Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccTramiteLegal		

#Region " Variables Miembro " 
	Protected m_SccTramiteLegalID As Integer 
	Protected m_objCuentaID As String = Nothing 
	Protected m_ObjTiendaID As Integer 
	Protected m_Fecha As Date 
	Protected m_Saldo_a_Fecha As Decimal 
	Protected m_objEmpleadoid As Integer 
	Protected m_Comentario As String = Nothing 
	Protected m_objCalificacionAnteriorId As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SccTramiteLegalID() As Integer
        Get
            Return (m_SccTramiteLegalID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccTramiteLegalID = Value
		End Set
    End Property
	
	Public Property objCuentaID() As String
        Get
            Return (m_objCuentaID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 15 Then
					Throw New ArgumentOutOfRangeException("objCuentaID", Value.ToString(), "Valor inv?lido para SccTramiteLegal.objCuentaID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (15).")
				End If
			End If
			m_objCuentaID = Value
		End Set
    End Property
	
	Public Property ObjTiendaID() As Integer
        Get
            Return (m_ObjTiendaID)
        End Get
		Set(ByVal Value As Integer)					
			m_ObjTiendaID = Value
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
	
	Public Property Saldo_a_Fecha() As Decimal
        Get
            Return (m_Saldo_a_Fecha)
        End Get
		Set(ByVal Value As Decimal)					
			m_Saldo_a_Fecha = Value
		End Set
    End Property
	
	Public Property objEmpleadoid() As Integer
        Get
            Return (m_objEmpleadoid)
        End Get
		Set(ByVal Value As Integer)					
			m_objEmpleadoid = Value
		End Set
    End Property
	
	Public Property Comentario() As String
        Get
            Return (m_Comentario)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 300 Then
					Throw New ArgumentOutOfRangeException("Comentario", Value.ToString(), "Valor inv?lido para SccTramiteLegal.Comentario. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (300).")
				End If
			End If
			m_Comentario = Value
		End Set
    End Property
	
	Public Property objCalificacionAnteriorId() As Nullable(Of Integer)
        Get
            Return (m_objCalificacionAnteriorId)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCalificacionAnteriorId = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccTramiteLegal.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccTramiteLegal.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
			Case "objCuentaID"
				Return	15
			Case "Saldo_a_Fecha"
				Return	11
			Case "Comentario"
				Return	300
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
			Case "Saldo_a_Fecha"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccTramiteLegal en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccTramiteLegal </param>    
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
			cmdDelete.Parameters.Add("@SccTramiteLegalID", SqlDbType.Int, 4, "SccTramiteLegalID" )
			cmdDelete.CommandText = "DELETE FROM  SccTramiteLegal WHERE SccTramiteLegalID= @SccTramiteLegalID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objCuentaID", SqlDbType.VarChar, 15, "objCuentaID")
			cmdInsert.Parameters.Add("@ObjTiendaID", SqlDbType.Int, 4, "ObjTiendaID")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@Saldo_a_Fecha", SqlDbType.Decimal, 9, "Saldo_a_Fecha")
			cmdInsert.Parameters.Add("@objEmpleadoid", SqlDbType.Int, 4, "objEmpleadoid")
			cmdInsert.Parameters.Add("@Comentario", SqlDbType.VarChar, 300, "Comentario")
			cmdInsert.Parameters.Add("@objCalificacionAnteriorId", SqlDbType.Int, 4, "objCalificacionAnteriorId")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SccTramiteLegal ( objCuentaID, ObjTiendaID, Fecha, Saldo_a_Fecha, objEmpleadoid, Comentario, objCalificacionAnteriorId, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objCuentaID, @ObjTiendaID, @Fecha, @Saldo_a_Fecha, @objEmpleadoid, @Comentario, @objCalificacionAnteriorId, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objCuentaID", SqlDbType.VarChar, 15, "objCuentaID")
			cmdUpdate.Parameters.Add("@ObjTiendaID", SqlDbType.Int, 4, "ObjTiendaID")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@Saldo_a_Fecha", SqlDbType.Decimal, 9, "Saldo_a_Fecha")
			cmdUpdate.Parameters.Add("@objEmpleadoid", SqlDbType.Int, 4, "objEmpleadoid")
			cmdUpdate.Parameters.Add("@Comentario", SqlDbType.VarChar, 300, "Comentario")
			cmdUpdate.Parameters.Add("@objCalificacionAnteriorId", SqlDbType.Int, 4, "objCalificacionAnteriorId")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSccTramiteLegalID", SqlDbType.Int, 4, "SccTramiteLegalID")
			cmdUpdate.CommandText = "UPDATE SccTramiteLegal SET objCuentaID=@objCuentaID, ObjTiendaID=@ObjTiendaID, Fecha=@Fecha, Saldo_a_Fecha=@Saldo_a_Fecha, objEmpleadoid=@objEmpleadoid, Comentario=@Comentario, objCalificacionAnteriorId=@objCalificacionAnteriorId, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SccTramiteLegalID= @wSccTramiteLegalID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccTramiteLegal")
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
    ''' Devuelve de la base de datos un objeto SccTramiteLegal
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccTramiteLegalID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccTramiteLegal where " & " SccTramiteLegalID = " & p_SccTramiteLegalID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccTramiteLegalID = dr("SccTramiteLegalID")
				m_objCuentaID = IIf(IsDBNull(dr("objCuentaID")), Nothing, dr("objCuentaID"))					
				m_ObjTiendaID = IIf(IsDBNull(dr("ObjTiendaID")), Nothing, dr("ObjTiendaID"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_Saldo_a_Fecha = IIf(IsDBNull(dr("Saldo_a_Fecha")), Nothing, dr("Saldo_a_Fecha"))					
				m_objEmpleadoid = IIf(IsDBNull(dr("objEmpleadoid")), Nothing, dr("objEmpleadoid"))					
				m_Comentario = IIf(IsDBNull(dr("Comentario")), Nothing, dr("Comentario"))					
				m_objCalificacionAnteriorId = IIf(IsDBNull(dr("objCalificacionAnteriorId")), Nothing, dr("objCalificacionAnteriorId"))					
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
    ''' Devuelve de la base de datos un objeto SccTramiteLegal usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccTramiteLegal where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccTramiteLegalID = dr("SccTramiteLegalID")
				m_objCuentaID = IIf(IsDBNull(dr("objCuentaID")), Nothing, dr("objCuentaID"))					
				m_ObjTiendaID = IIf(IsDBNull(dr("ObjTiendaID")), Nothing, dr("ObjTiendaID"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_Saldo_a_Fecha = IIf(IsDBNull(dr("Saldo_a_Fecha")), Nothing, dr("Saldo_a_Fecha"))					
				m_objEmpleadoid = IIf(IsDBNull(dr("objEmpleadoid")), Nothing, dr("objEmpleadoid"))					
				m_Comentario = IIf(IsDBNull(dr("Comentario")), Nothing, dr("Comentario"))					
				m_objCalificacionAnteriorId = IIf(IsDBNull(dr("objCalificacionAnteriorId")), Nothing, dr("objCalificacionAnteriorId"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccTramiteLegal en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccTramiteLegal"

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
			ds.Tables(0).TableName = "SccTramiteLegal"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccTramiteLegal en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccTramiteLegal"

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
			ds.Tables(0).TableName = "SccTramiteLegal"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccTramiteLegal en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccTramiteLegal"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccTramiteLegal.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccTramiteLegal("
		sCommand &= "objCuentaID,"
		sCommand &= "ObjTiendaID,"
		sCommand &= "Fecha,"
		sCommand &= "Saldo_a_Fecha,"
		sCommand &= "objEmpleadoid,"
		sCommand &= "Comentario,"
		sCommand &= "objCalificacionAnteriorId,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objCuentaID,"
		sCommand &= "@ObjTiendaID,"
		sCommand &= "@Fecha,"
		sCommand &= "@Saldo_a_Fecha,"
		sCommand &= "@objEmpleadoid,"
		sCommand &= "@Comentario,"
		sCommand &= "@objCalificacionAnteriorId,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SccTramiteLegalID = SccTramiteLegalID from SccTramiteLegal where "		
		sCommand &= "SccTramiteLegalID = SCOPE_IDENTITY()"
		
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SccTramiteLegalID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objCuentaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCuentaID
        End If
		arParams(2) = New SqlParameter("@ObjTiendaID", SqlDbType.Int)		
		If IsDBNull(m_ObjTiendaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_ObjTiendaID
        End If
		arParams(3) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Fecha
        End If
		arParams(4) = New SqlParameter("@Saldo_a_Fecha", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo_a_Fecha) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Saldo_a_Fecha
        End If
		arParams(5) = New SqlParameter("@objEmpleadoid", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoid) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEmpleadoid
        End If
		arParams(6) = New SqlParameter("@Comentario", SqlDbType.VarChar)		
		If IsDBNull(m_Comentario) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Comentario
        End If
		arParams(7) = New SqlParameter("@objCalificacionAnteriorId", SqlDbType.Int)		
		If IsDBNull(m_objCalificacionAnteriorId) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objCalificacionAnteriorId
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
			
			m_SccTramiteLegalID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccTramiteLegal en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccTramiteLegal set "		
		sCommand &= "objCuentaID = @objCuentaID,"
		sCommand &= "ObjTiendaID = @ObjTiendaID,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "Saldo_a_Fecha = @Saldo_a_Fecha,"
		sCommand &= "objEmpleadoid = @objEmpleadoid,"
		sCommand &= "Comentario = @Comentario,"
		sCommand &= "objCalificacionAnteriorId = @objCalificacionAnteriorId,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SccTramiteLegalID = @SccTramiteLegalID"					
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SccTramiteLegalID", SqlDbType.Int)		
		If IsDBNull(m_SccTramiteLegalID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccTramiteLegalID
        End If
		arParams(1) = New SqlParameter("@objCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objCuentaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCuentaID
        End If
		arParams(2) = New SqlParameter("@ObjTiendaID", SqlDbType.Int)		
		If IsDBNull(m_ObjTiendaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_ObjTiendaID
        End If
		arParams(3) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Fecha
        End If
		arParams(4) = New SqlParameter("@Saldo_a_Fecha", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo_a_Fecha) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Saldo_a_Fecha
        End If
		arParams(5) = New SqlParameter("@objEmpleadoid", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoid) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEmpleadoid
        End If
		arParams(6) = New SqlParameter("@Comentario", SqlDbType.VarChar)		
		If IsDBNull(m_Comentario) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Comentario
        End If
		arParams(7) = New SqlParameter("@objCalificacionAnteriorId", SqlDbType.Int)		
		If IsDBNull(m_objCalificacionAnteriorId) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objCalificacionAnteriorId
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
    ''' Borra un objeto SccTramiteLegal de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccTramiteLegal where " & " SccTramiteLegalID = " & m_SccTramiteLegalID
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
    ''' Borra un objeto SccTramiteLegal de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccTramiteLegalID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccTramiteLegal where " & " SccTramiteLegalID = " & p_SccTramiteLegalID
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
    ''' Borra objetos SccTramiteLegal de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccTramiteLegal where " & pWhere
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
