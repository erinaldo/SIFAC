Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class txRC_Factura_Step3		

#Region " Variables Miembro " 
	Protected m_SfaFacturaID As Integer 
	Protected m_Fecha As Date 
	Protected m_objProductoID As Nullable(Of Integer) 
	Protected m_objConceptoFactura As Integer 
	Protected m_Numero As String = Nothing 
	Protected m_Chasis As String = Nothing 
	Protected m_NoMotor As String = Nothing 
	Protected m_MontoTotal As Decimal 
	Protected m_objEmpleadoID As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
#End Region

#Region " Propiedades "
	Public Property SfaFacturaID() As Integer
        Get
            Return (m_SfaFacturaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SfaFacturaID = Value
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
	
	Public Property objProductoID() As Nullable(Of Integer)
        Get
            Return (m_objProductoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objProductoID = Value
		End Set
    End Property
	
	Public Property objConceptoFactura() As Integer
        Get
            Return (m_objConceptoFactura)
        End Get
		Set(ByVal Value As Integer)					
			m_objConceptoFactura = Value
		End Set
    End Property
	
	Public Property Numero() As String
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 10 Then
					Throw New ArgumentOutOfRangeException("Numero", Value.ToString(), "Valor inv?lido para txRC_Factura_Step3.Numero. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (10).")
				End If
			End If
			m_Numero = Value
		End Set
    End Property
	
	Public Property Chasis() As String
        Get
            Return (m_Chasis)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 20 Then
					Throw New ArgumentOutOfRangeException("Chasis", Value.ToString(), "Valor inv?lido para txRC_Factura_Step3.Chasis. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (20).")
				End If
			End If
			m_Chasis = Value
		End Set
    End Property
	
	Public Property NoMotor() As String
        Get
            Return (m_NoMotor)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 20 Then
					Throw New ArgumentOutOfRangeException("NoMotor", Value.ToString(), "Valor inv?lido para txRC_Factura_Step3.NoMotor. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (20).")
				End If
			End If
			m_NoMotor = Value
		End Set
    End Property
	
	Public Property MontoTotal() As Decimal
        Get
            Return (m_MontoTotal)
        End Get
		Set(ByVal Value As Decimal)					
			m_MontoTotal = Value
		End Set
    End Property
	
	Public Property objEmpleadoID() As Nullable(Of Integer)
        Get
            Return (m_objEmpleadoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEmpleadoID = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para txRC_Factura_Step3.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
			Case "Numero"
				Return	10
			Case "Chasis"
				Return	20
			Case "NoMotor"
				Return	20
			Case "MontoTotal"
				Return	11
			Case "UsuarioCreacion"
				Return	50
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "MontoTotal"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla txRC_Factura_Step3 en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla txRC_Factura_Step3 </param>    
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
			cmdDelete.Parameters.Add("@SfaFacturaID", SqlDbType.Int, 4, "SfaFacturaID" )
			cmdDelete.CommandText = "DELETE FROM  txRC_Factura_Step3 WHERE SfaFacturaID= @SfaFacturaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@objProductoID", SqlDbType.Int, 4, "objProductoID")
			cmdInsert.Parameters.Add("@objConceptoFactura", SqlDbType.Int, 4, "objConceptoFactura")
			cmdInsert.Parameters.Add("@Numero", SqlDbType.VarChar, 10, "Numero")
			cmdInsert.Parameters.Add("@Chasis", SqlDbType.VarChar, 20, "Chasis")
			cmdInsert.Parameters.Add("@NoMotor", SqlDbType.VarChar, 20, "NoMotor")
			cmdInsert.Parameters.Add("@MontoTotal", SqlDbType.Decimal, 9, "MontoTotal")
			cmdInsert.Parameters.Add("@objEmpleadoID", SqlDbType.Int, 4, "objEmpleadoID")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.CommandText = "INSERT INTO txRC_Factura_Step3 ( Fecha, objProductoID, objConceptoFactura, Numero, Chasis, NoMotor, MontoTotal, objEmpleadoID, UsuarioCreacion, FechaCreacion) VALUES ( @Fecha, @objProductoID, @objConceptoFactura, @Numero, @Chasis, @NoMotor, @MontoTotal, @objEmpleadoID, @UsuarioCreacion, @FechaCreacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@objProductoID", SqlDbType.Int, 4, "objProductoID")
			cmdUpdate.Parameters.Add("@objConceptoFactura", SqlDbType.Int, 4, "objConceptoFactura")
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.VarChar, 10, "Numero")
			cmdUpdate.Parameters.Add("@Chasis", SqlDbType.VarChar, 20, "Chasis")
			cmdUpdate.Parameters.Add("@NoMotor", SqlDbType.VarChar, 20, "NoMotor")
			cmdUpdate.Parameters.Add("@MontoTotal", SqlDbType.Decimal, 9, "MontoTotal")
			cmdUpdate.Parameters.Add("@objEmpleadoID", SqlDbType.Int, 4, "objEmpleadoID")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@wSfaFacturaID", SqlDbType.Int, 4, "SfaFacturaID")
			cmdUpdate.CommandText = "UPDATE txRC_Factura_Step3 SET Fecha=@Fecha, objProductoID=@objProductoID, objConceptoFactura=@objConceptoFactura, Numero=@Numero, Chasis=@Chasis, NoMotor=@NoMotor, MontoTotal=@MontoTotal, objEmpleadoID=@objEmpleadoID, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion WHERE SfaFacturaID= @wSfaFacturaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "txRC_Factura_Step3")
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
    ''' Devuelve de la base de datos un objeto txRC_Factura_Step3
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SfaFacturaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from txRC_Factura_Step3 where " & " SfaFacturaID = " & p_SfaFacturaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SfaFacturaID = dr("SfaFacturaID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_objProductoID = IIf(IsDBNull(dr("objProductoID")), Nothing, dr("objProductoID"))					
				m_objConceptoFactura = IIf(IsDBNull(dr("objConceptoFactura")), Nothing, dr("objConceptoFactura"))					
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Chasis = IIf(IsDBNull(dr("Chasis")), Nothing, dr("Chasis"))					
				m_NoMotor = IIf(IsDBNull(dr("NoMotor")), Nothing, dr("NoMotor"))					
				m_MontoTotal = IIf(IsDBNull(dr("MontoTotal")), Nothing, dr("MontoTotal"))					
				m_objEmpleadoID = IIf(IsDBNull(dr("objEmpleadoID")), Nothing, dr("objEmpleadoID"))					
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
    ''' Devuelve de la base de datos un objeto txRC_Factura_Step3 usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from txRC_Factura_Step3 where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SfaFacturaID = dr("SfaFacturaID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_objProductoID = IIf(IsDBNull(dr("objProductoID")), Nothing, dr("objProductoID"))					
				m_objConceptoFactura = IIf(IsDBNull(dr("objConceptoFactura")), Nothing, dr("objConceptoFactura"))					
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Chasis = IIf(IsDBNull(dr("Chasis")), Nothing, dr("Chasis"))					
				m_NoMotor = IIf(IsDBNull(dr("NoMotor")), Nothing, dr("NoMotor"))					
				m_MontoTotal = IIf(IsDBNull(dr("MontoTotal")), Nothing, dr("MontoTotal"))					
				m_objEmpleadoID = IIf(IsDBNull(dr("objEmpleadoID")), Nothing, dr("objEmpleadoID"))					
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
    ''' Trae de la base de datos un conjunto de objetos txRC_Factura_Step3 en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from txRC_Factura_Step3"

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
			ds.Tables(0).TableName = "txRC_Factura_Step3"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos txRC_Factura_Step3 en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from txRC_Factura_Step3"

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
			ds.Tables(0).TableName = "txRC_Factura_Step3"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos txRC_Factura_Step3 en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from txRC_Factura_Step3"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase txRC_Factura_Step3.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into txRC_Factura_Step3("
		sCommand &= "Fecha,"
		sCommand &= "objProductoID,"
		sCommand &= "objConceptoFactura,"
		sCommand &= "Numero,"
		sCommand &= "Chasis,"
		sCommand &= "NoMotor,"
		sCommand &= "MontoTotal,"
		sCommand &= "objEmpleadoID,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion) values ("		
		sCommand &= "@Fecha,"
		sCommand &= "@objProductoID,"
		sCommand &= "@objConceptoFactura,"
		sCommand &= "@Numero,"
		sCommand &= "@Chasis,"
		sCommand &= "@NoMotor,"
		sCommand &= "@MontoTotal,"
		sCommand &= "@objEmpleadoID,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion)"		
	
		sCommand &= " select "
		sCommand &= "@SfaFacturaID = SfaFacturaID from txRC_Factura_Step3 where "		
		sCommand &= "SfaFacturaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@objProductoID", SqlDbType.Int)		
		If IsDBNull(m_objProductoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objProductoID
        End If
		arParams(3) = New SqlParameter("@objConceptoFactura", SqlDbType.Int)		
		If IsDBNull(m_objConceptoFactura) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objConceptoFactura
        End If
		arParams(4) = New SqlParameter("@Numero", SqlDbType.VarChar)		
		If IsDBNull(m_Numero) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Numero
        End If
		arParams(5) = New SqlParameter("@Chasis", SqlDbType.VarChar)		
		If IsDBNull(m_Chasis) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Chasis
        End If
		arParams(6) = New SqlParameter("@NoMotor", SqlDbType.VarChar)		
		If IsDBNull(m_NoMotor) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_NoMotor
        End If
		arParams(7) = New SqlParameter("@MontoTotal", SqlDbType.Decimal)		
		If IsDBNull(m_MontoTotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_MontoTotal
        End If
		arParams(8) = New SqlParameter("@objEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objEmpleadoID
        End If
		arParams(9) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioCreacion
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SfaFacturaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto txRC_Factura_Step3 en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update txRC_Factura_Step3 set "		
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "objProductoID = @objProductoID,"
		sCommand &= "objConceptoFactura = @objConceptoFactura,"
		sCommand &= "Numero = @Numero,"
		sCommand &= "Chasis = @Chasis,"
		sCommand &= "NoMotor = @NoMotor,"
		sCommand &= "MontoTotal = @MontoTotal,"
		sCommand &= "objEmpleadoID = @objEmpleadoID,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion"		
		sCommand &= " where "	
		sCommand &= "SfaFacturaID = @SfaFacturaID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaID", SqlDbType.Int)		
		If IsDBNull(m_SfaFacturaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SfaFacturaID
        End If
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@objProductoID", SqlDbType.Int)		
		If IsDBNull(m_objProductoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objProductoID
        End If
		arParams(3) = New SqlParameter("@objConceptoFactura", SqlDbType.Int)		
		If IsDBNull(m_objConceptoFactura) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objConceptoFactura
        End If
		arParams(4) = New SqlParameter("@Numero", SqlDbType.VarChar)		
		If IsDBNull(m_Numero) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Numero
        End If
		arParams(5) = New SqlParameter("@Chasis", SqlDbType.VarChar)		
		If IsDBNull(m_Chasis) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Chasis
        End If
		arParams(6) = New SqlParameter("@NoMotor", SqlDbType.VarChar)		
		If IsDBNull(m_NoMotor) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_NoMotor
        End If
		arParams(7) = New SqlParameter("@MontoTotal", SqlDbType.Decimal)		
		If IsDBNull(m_MontoTotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_MontoTotal
        End If
		arParams(8) = New SqlParameter("@objEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objEmpleadoID
        End If
		arParams(9) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioCreacion
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
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
    ''' Borra un objeto txRC_Factura_Step3 de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from txRC_Factura_Step3 where " & " SfaFacturaID = " & m_SfaFacturaID
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
    ''' Borra un objeto txRC_Factura_Step3 de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SfaFacturaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from txRC_Factura_Step3 where " & " SfaFacturaID = " & p_SfaFacturaID
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
    ''' Borra objetos txRC_Factura_Step3 de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from txRC_Factura_Step3 where " & pWhere
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
