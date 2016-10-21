Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivPedidosDetalle		

#Region " Variables Miembro " 
	Protected m_SivPedidoDetalleID As Integer 
	Protected m_objPedidoID As Integer 
	Protected m_objProductoID As Integer 
	Protected m_CantidadOrdenada As Double 
	Protected m_CostoUnitario As Decimal 
	Protected m_CostoSubtotal As Decimal 
	Protected m_CostoImpuesto As Decimal 
	Protected m_CostoTotal As Decimal 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SivPedidoDetalleID() As Integer
        Get
            Return (m_SivPedidoDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivPedidoDetalleID = Value
		End Set
    End Property
	
	Public Property objPedidoID() As Integer
        Get
            Return (m_objPedidoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objPedidoID = Value
		End Set
    End Property
	
	Public Property objProductoID() As Integer
        Get
            Return (m_objProductoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objProductoID = Value
		End Set
    End Property
	
	Public Property CantidadOrdenada() As Double
        Get
            Return (m_CantidadOrdenada)
        End Get
		Set(ByVal Value As Double)					
			m_CantidadOrdenada = Value
		End Set
    End Property
	
	Public Property CostoUnitario() As Decimal
        Get
            Return (m_CostoUnitario)
        End Get
		Set(ByVal Value As Decimal)					
			m_CostoUnitario = Value
		End Set
    End Property
	
	Public Property CostoSubtotal() As Decimal
        Get
            Return (m_CostoSubtotal)
        End Get
		Set(ByVal Value As Decimal)					
			m_CostoSubtotal = Value
		End Set
    End Property
	
	Public Property CostoImpuesto() As Decimal
        Get
            Return (m_CostoImpuesto)
        End Get
		Set(ByVal Value As Decimal)					
			m_CostoImpuesto = Value
		End Set
    End Property
	
	Public Property CostoTotal() As Decimal
        Get
            Return (m_CostoTotal)
        End Get
		Set(ByVal Value As Decimal)					
			m_CostoTotal = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivPedidosDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivPedidosDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "CostoUnitario"
				Return	11
			Case "CostoSubtotal"
				Return	11
			Case "CostoImpuesto"
				Return	11
			Case "CostoTotal"
				Return	11
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
			Case "CostoUnitario"
				Return	2
			Case "CostoSubtotal"
				Return	2
			Case "CostoImpuesto"
				Return	2
			Case "CostoTotal"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivPedidosDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivPedidosDetalle </param>    
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
			cmdDelete.Parameters.Add("@SivPedidoDetalleID", SqlDbType.Int, 4, "SivPedidoDetalleID" )
			cmdDelete.CommandText = "DELETE FROM  SivPedidosDetalle WHERE SivPedidoDetalleID= @SivPedidoDetalleID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objPedidoID", SqlDbType.Int, 4, "objPedidoID")
			cmdInsert.Parameters.Add("@objProductoID", SqlDbType.Int, 4, "objProductoID")
			cmdInsert.Parameters.Add("@CantidadOrdenada", SqlDbType.Float, 8, "CantidadOrdenada")
			cmdInsert.Parameters.Add("@CostoUnitario", SqlDbType.Decimal, 9, "CostoUnitario")
			cmdInsert.Parameters.Add("@CostoSubtotal", SqlDbType.Decimal, 9, "CostoSubtotal")
			cmdInsert.Parameters.Add("@CostoImpuesto", SqlDbType.Decimal, 9, "CostoImpuesto")
			cmdInsert.Parameters.Add("@CostoTotal", SqlDbType.Decimal, 9, "CostoTotal")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SivPedidosDetalle ( objPedidoID, objProductoID, CantidadOrdenada, CostoUnitario, CostoSubtotal, CostoImpuesto, CostoTotal, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objPedidoID, @objProductoID, @CantidadOrdenada, @CostoUnitario, @CostoSubtotal, @CostoImpuesto, @CostoTotal, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objPedidoID", SqlDbType.Int, 4, "objPedidoID")
			cmdUpdate.Parameters.Add("@objProductoID", SqlDbType.Int, 4, "objProductoID")
			cmdUpdate.Parameters.Add("@CantidadOrdenada", SqlDbType.Float, 8, "CantidadOrdenada")
			cmdUpdate.Parameters.Add("@CostoUnitario", SqlDbType.Decimal, 9, "CostoUnitario")
			cmdUpdate.Parameters.Add("@CostoSubtotal", SqlDbType.Decimal, 9, "CostoSubtotal")
			cmdUpdate.Parameters.Add("@CostoImpuesto", SqlDbType.Decimal, 9, "CostoImpuesto")
			cmdUpdate.Parameters.Add("@CostoTotal", SqlDbType.Decimal, 9, "CostoTotal")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSivPedidoDetalleID", SqlDbType.Int, 4, "SivPedidoDetalleID")
			cmdUpdate.CommandText = "UPDATE SivPedidosDetalle SET objPedidoID=@objPedidoID, objProductoID=@objProductoID, CantidadOrdenada=@CantidadOrdenada, CostoUnitario=@CostoUnitario, CostoSubtotal=@CostoSubtotal, CostoImpuesto=@CostoImpuesto, CostoTotal=@CostoTotal, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SivPedidoDetalleID= @wSivPedidoDetalleID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivPedidosDetalle")
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
    ''' Devuelve de la base de datos un objeto SivPedidosDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivPedidoDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivPedidosDetalle where " & " SivPedidoDetalleID = " & p_SivPedidoDetalleID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivPedidoDetalleID = dr("SivPedidoDetalleID")
				m_objPedidoID = IIf(IsDBNull(dr("objPedidoID")), Nothing, dr("objPedidoID"))					
				m_objProductoID = IIf(IsDBNull(dr("objProductoID")), Nothing, dr("objProductoID"))					
				m_CantidadOrdenada = IIf(IsDBNull(dr("CantidadOrdenada")), Nothing, dr("CantidadOrdenada"))					
				m_CostoUnitario = IIf(IsDBNull(dr("CostoUnitario")), Nothing, dr("CostoUnitario"))					
				m_CostoSubtotal = IIf(IsDBNull(dr("CostoSubtotal")), Nothing, dr("CostoSubtotal"))					
				m_CostoImpuesto = IIf(IsDBNull(dr("CostoImpuesto")), Nothing, dr("CostoImpuesto"))					
				m_CostoTotal = IIf(IsDBNull(dr("CostoTotal")), Nothing, dr("CostoTotal"))					
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
    ''' Devuelve de la base de datos un objeto SivPedidosDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivPedidosDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivPedidoDetalleID = dr("SivPedidoDetalleID")
				m_objPedidoID = IIf(IsDBNull(dr("objPedidoID")), Nothing, dr("objPedidoID"))					
				m_objProductoID = IIf(IsDBNull(dr("objProductoID")), Nothing, dr("objProductoID"))					
				m_CantidadOrdenada = IIf(IsDBNull(dr("CantidadOrdenada")), Nothing, dr("CantidadOrdenada"))					
				m_CostoUnitario = IIf(IsDBNull(dr("CostoUnitario")), Nothing, dr("CostoUnitario"))					
				m_CostoSubtotal = IIf(IsDBNull(dr("CostoSubtotal")), Nothing, dr("CostoSubtotal"))					
				m_CostoImpuesto = IIf(IsDBNull(dr("CostoImpuesto")), Nothing, dr("CostoImpuesto"))					
				m_CostoTotal = IIf(IsDBNull(dr("CostoTotal")), Nothing, dr("CostoTotal"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivPedidosDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivPedidosDetalle"

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
			ds.Tables(0).TableName = "SivPedidosDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivPedidosDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivPedidosDetalle"

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
			ds.Tables(0).TableName = "SivPedidosDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivPedidosDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivPedidosDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivPedidosDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivPedidosDetalle("
		sCommand &= "objPedidoID,"
		sCommand &= "objProductoID,"
		sCommand &= "CantidadOrdenada,"
		sCommand &= "CostoUnitario,"
		sCommand &= "CostoSubtotal,"
		sCommand &= "CostoImpuesto,"
		sCommand &= "CostoTotal,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objPedidoID,"
		sCommand &= "@objProductoID,"
		sCommand &= "@CantidadOrdenada,"
		sCommand &= "@CostoUnitario,"
		sCommand &= "@CostoSubtotal,"
		sCommand &= "@CostoImpuesto,"
		sCommand &= "@CostoTotal,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SivPedidoDetalleID = SivPedidoDetalleID from SivPedidosDetalle where "		
		sCommand &= "SivPedidoDetalleID = SCOPE_IDENTITY()"
		
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SivPedidoDetalleID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objPedidoID", SqlDbType.Int)		
		If IsDBNull(m_objPedidoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPedidoID
        End If
		arParams(2) = New SqlParameter("@objProductoID", SqlDbType.Int)		
		If IsDBNull(m_objProductoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objProductoID
        End If
		arParams(3) = New SqlParameter("@CantidadOrdenada", SqlDbType.Float)		
		If IsDBNull(m_CantidadOrdenada) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_CantidadOrdenada
        End If
		arParams(4) = New SqlParameter("@CostoUnitario", SqlDbType.Decimal)		
		If IsDBNull(m_CostoUnitario) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_CostoUnitario
        End If
		arParams(5) = New SqlParameter("@CostoSubtotal", SqlDbType.Decimal)		
		If IsDBNull(m_CostoSubtotal) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_CostoSubtotal
        End If
		arParams(6) = New SqlParameter("@CostoImpuesto", SqlDbType.Decimal)		
		If IsDBNull(m_CostoImpuesto) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_CostoImpuesto
        End If
		arParams(7) = New SqlParameter("@CostoTotal", SqlDbType.Decimal)		
		If IsDBNull(m_CostoTotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_CostoTotal
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioCreacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SivPedidoDetalleID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivPedidosDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivPedidosDetalle set "		
		sCommand &= "objPedidoID = @objPedidoID,"
		sCommand &= "objProductoID = @objProductoID,"
		sCommand &= "CantidadOrdenada = @CantidadOrdenada,"
		sCommand &= "CostoUnitario = @CostoUnitario,"
		sCommand &= "CostoSubtotal = @CostoSubtotal,"
		sCommand &= "CostoImpuesto = @CostoImpuesto,"
		sCommand &= "CostoTotal = @CostoTotal,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SivPedidoDetalleID = @SivPedidoDetalleID"					
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SivPedidoDetalleID", SqlDbType.Int)		
		If IsDBNull(m_SivPedidoDetalleID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivPedidoDetalleID
        End If
		arParams(1) = New SqlParameter("@objPedidoID", SqlDbType.Int)		
		If IsDBNull(m_objPedidoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPedidoID
        End If
		arParams(2) = New SqlParameter("@objProductoID", SqlDbType.Int)		
		If IsDBNull(m_objProductoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objProductoID
        End If
		arParams(3) = New SqlParameter("@CantidadOrdenada", SqlDbType.Float)		
		If IsDBNull(m_CantidadOrdenada) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_CantidadOrdenada
        End If
		arParams(4) = New SqlParameter("@CostoUnitario", SqlDbType.Decimal)		
		If IsDBNull(m_CostoUnitario) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_CostoUnitario
        End If
		arParams(5) = New SqlParameter("@CostoSubtotal", SqlDbType.Decimal)		
		If IsDBNull(m_CostoSubtotal) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_CostoSubtotal
        End If
		arParams(6) = New SqlParameter("@CostoImpuesto", SqlDbType.Decimal)		
		If IsDBNull(m_CostoImpuesto) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_CostoImpuesto
        End If
		arParams(7) = New SqlParameter("@CostoTotal", SqlDbType.Decimal)		
		If IsDBNull(m_CostoTotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_CostoTotal
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioCreacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SivPedidosDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivPedidosDetalle where " & " SivPedidoDetalleID = " & m_SivPedidoDetalleID
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
    ''' Borra un objeto SivPedidosDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivPedidoDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivPedidosDetalle where " & " SivPedidoDetalleID = " & p_SivPedidoDetalleID
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
    ''' Borra objetos SivPedidosDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivPedidosDetalle where " & pWhere
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
