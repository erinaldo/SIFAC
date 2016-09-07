Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class ScpOrdenCompraDetalle		

#Region " Variables Miembro " 
	Protected m_ScpOrdenCompraDetalle As Integer 
	Protected m_objOrdenCompraID As Integer 
	Protected m_objProductoID As Integer 
	Protected m_CantidadOrdenada As Double 
	Protected m_CantidadRecibida As Double 
	Protected m_CantidadDevuelta As Double 
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
	Public Property ScpOrdenCompraDetalle() As Integer
        Get
            Return (m_ScpOrdenCompraDetalle)
        End Get
		Set(ByVal Value As Integer)					
			m_ScpOrdenCompraDetalle = Value
		End Set
    End Property
	
	Public Property objOrdenCompraID() As Integer
        Get
            Return (m_objOrdenCompraID)
        End Get
		Set(ByVal Value As Integer)					
			m_objOrdenCompraID = Value
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
	
	Public Property CantidadRecibida() As Double
        Get
            Return (m_CantidadRecibida)
        End Get
		Set(ByVal Value As Double)					
			m_CantidadRecibida = Value
		End Set
    End Property
	
	Public Property CantidadDevuelta() As Double
        Get
            Return (m_CantidadDevuelta)
        End Get
		Set(ByVal Value As Double)					
			m_CantidadDevuelta = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para ScpOrdenCompraDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para ScpOrdenCompraDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
    ''' Salva un DataSet del tipo de la tabla ScpOrdenCompraDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla ScpOrdenCompraDetalle </param>    
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
			cmdDelete.Parameters.Add("@ScpOrdenCompraDetalle", SqlDbType.Int, 4, "ScpOrdenCompraDetalle" )
			cmdDelete.CommandText = "DELETE FROM  ScpOrdenCompraDetalle WHERE ScpOrdenCompraDetalle= @ScpOrdenCompraDetalle" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objOrdenCompraID", SqlDbType.Int, 4, "objOrdenCompraID")
			cmdInsert.Parameters.Add("@objProductoID", SqlDbType.Int, 4, "objProductoID")
			cmdInsert.Parameters.Add("@CantidadOrdenada", SqlDbType.Float, 8, "CantidadOrdenada")
			cmdInsert.Parameters.Add("@CantidadRecibida", SqlDbType.Float, 8, "CantidadRecibida")
			cmdInsert.Parameters.Add("@CantidadDevuelta", SqlDbType.Float, 8, "CantidadDevuelta")
			cmdInsert.Parameters.Add("@CostoUnitario", SqlDbType.Decimal, 9, "CostoUnitario")
			cmdInsert.Parameters.Add("@CostoSubtotal", SqlDbType.Decimal, 9, "CostoSubtotal")
			cmdInsert.Parameters.Add("@CostoImpuesto", SqlDbType.Decimal, 9, "CostoImpuesto")
			cmdInsert.Parameters.Add("@CostoTotal", SqlDbType.Decimal, 9, "CostoTotal")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO ScpOrdenCompraDetalle ( objOrdenCompraID, objProductoID, CantidadOrdenada, CantidadRecibida, CantidadDevuelta, CostoUnitario, CostoSubtotal, CostoImpuesto, CostoTotal, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objOrdenCompraID, @objProductoID, @CantidadOrdenada, @CantidadRecibida, @CantidadDevuelta, @CostoUnitario, @CostoSubtotal, @CostoImpuesto, @CostoTotal, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objOrdenCompraID", SqlDbType.Int, 4, "objOrdenCompraID")
			cmdUpdate.Parameters.Add("@objProductoID", SqlDbType.Int, 4, "objProductoID")
			cmdUpdate.Parameters.Add("@CantidadOrdenada", SqlDbType.Float, 8, "CantidadOrdenada")
			cmdUpdate.Parameters.Add("@CantidadRecibida", SqlDbType.Float, 8, "CantidadRecibida")
			cmdUpdate.Parameters.Add("@CantidadDevuelta", SqlDbType.Float, 8, "CantidadDevuelta")
			cmdUpdate.Parameters.Add("@CostoUnitario", SqlDbType.Decimal, 9, "CostoUnitario")
			cmdUpdate.Parameters.Add("@CostoSubtotal", SqlDbType.Decimal, 9, "CostoSubtotal")
			cmdUpdate.Parameters.Add("@CostoImpuesto", SqlDbType.Decimal, 9, "CostoImpuesto")
			cmdUpdate.Parameters.Add("@CostoTotal", SqlDbType.Decimal, 9, "CostoTotal")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wScpOrdenCompraDetalle", SqlDbType.Int, 4, "ScpOrdenCompraDetalle")
			cmdUpdate.CommandText = "UPDATE ScpOrdenCompraDetalle SET objOrdenCompraID=@objOrdenCompraID, objProductoID=@objProductoID, CantidadOrdenada=@CantidadOrdenada, CantidadRecibida=@CantidadRecibida, CantidadDevuelta=@CantidadDevuelta, CostoUnitario=@CostoUnitario, CostoSubtotal=@CostoSubtotal, CostoImpuesto=@CostoImpuesto, CostoTotal=@CostoTotal, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE ScpOrdenCompraDetalle= @wScpOrdenCompraDetalle"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "ScpOrdenCompraDetalle")
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
    ''' Devuelve de la base de datos un objeto ScpOrdenCompraDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ScpOrdenCompraDetalle as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScpOrdenCompraDetalle where " & " ScpOrdenCompraDetalle = " & p_ScpOrdenCompraDetalle		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_ScpOrdenCompraDetalle = dr("ScpOrdenCompraDetalle")
				m_objOrdenCompraID = IIf(IsDBNull(dr("objOrdenCompraID")), Nothing, dr("objOrdenCompraID"))					
				m_objProductoID = IIf(IsDBNull(dr("objProductoID")), Nothing, dr("objProductoID"))					
				m_CantidadOrdenada = IIf(IsDBNull(dr("CantidadOrdenada")), Nothing, dr("CantidadOrdenada"))					
				m_CantidadRecibida = IIf(IsDBNull(dr("CantidadRecibida")), Nothing, dr("CantidadRecibida"))					
				m_CantidadDevuelta = IIf(IsDBNull(dr("CantidadDevuelta")), Nothing, dr("CantidadDevuelta"))					
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
    ''' Devuelve de la base de datos un objeto ScpOrdenCompraDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScpOrdenCompraDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_ScpOrdenCompraDetalle = dr("ScpOrdenCompraDetalle")
				m_objOrdenCompraID = IIf(IsDBNull(dr("objOrdenCompraID")), Nothing, dr("objOrdenCompraID"))					
				m_objProductoID = IIf(IsDBNull(dr("objProductoID")), Nothing, dr("objProductoID"))					
				m_CantidadOrdenada = IIf(IsDBNull(dr("CantidadOrdenada")), Nothing, dr("CantidadOrdenada"))					
				m_CantidadRecibida = IIf(IsDBNull(dr("CantidadRecibida")), Nothing, dr("CantidadRecibida"))					
				m_CantidadDevuelta = IIf(IsDBNull(dr("CantidadDevuelta")), Nothing, dr("CantidadDevuelta"))					
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
    ''' Trae de la base de datos un conjunto de objetos ScpOrdenCompraDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from ScpOrdenCompraDetalle"

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
			ds.Tables(0).TableName = "ScpOrdenCompraDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScpOrdenCompraDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from ScpOrdenCompraDetalle"

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
			ds.Tables(0).TableName = "ScpOrdenCompraDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScpOrdenCompraDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from ScpOrdenCompraDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase ScpOrdenCompraDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into ScpOrdenCompraDetalle("
		sCommand &= "objOrdenCompraID,"
		sCommand &= "objProductoID,"
		sCommand &= "CantidadOrdenada,"
		sCommand &= "CantidadRecibida,"
		sCommand &= "CantidadDevuelta,"
		sCommand &= "CostoUnitario,"
		sCommand &= "CostoSubtotal,"
		sCommand &= "CostoImpuesto,"
		sCommand &= "CostoTotal,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objOrdenCompraID,"
		sCommand &= "@objProductoID,"
		sCommand &= "@CantidadOrdenada,"
		sCommand &= "@CantidadRecibida,"
		sCommand &= "@CantidadDevuelta,"
		sCommand &= "@CostoUnitario,"
		sCommand &= "@CostoSubtotal,"
		sCommand &= "@CostoImpuesto,"
		sCommand &= "@CostoTotal,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ScpOrdenCompraDetalle = ScpOrdenCompraDetalle from ScpOrdenCompraDetalle where "		
		sCommand &= "ScpOrdenCompraDetalle = SCOPE_IDENTITY()"
		
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@ScpOrdenCompraDetalle", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objOrdenCompraID", SqlDbType.Int)		
		If IsDBNull(m_objOrdenCompraID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objOrdenCompraID
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
		arParams(4) = New SqlParameter("@CantidadRecibida", SqlDbType.Float)		
		If IsDBNull(m_CantidadRecibida) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_CantidadRecibida
        End If
		arParams(5) = New SqlParameter("@CantidadDevuelta", SqlDbType.Float)		
		If IsDBNull(m_CantidadDevuelta) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_CantidadDevuelta
        End If
		arParams(6) = New SqlParameter("@CostoUnitario", SqlDbType.Decimal)		
		If IsDBNull(m_CostoUnitario) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_CostoUnitario
        End If
		arParams(7) = New SqlParameter("@CostoSubtotal", SqlDbType.Decimal)		
		If IsDBNull(m_CostoSubtotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_CostoSubtotal
        End If
		arParams(8) = New SqlParameter("@CostoImpuesto", SqlDbType.Decimal)		
		If IsDBNull(m_CostoImpuesto) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_CostoImpuesto
        End If
		arParams(9) = New SqlParameter("@CostoTotal", SqlDbType.Decimal)		
		If IsDBNull(m_CostoTotal) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_CostoTotal
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
		arParams(11) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioCreacion
        End If
		arParams(12) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaModificacion
        End If
		arParams(13) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ScpOrdenCompraDetalle = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto ScpOrdenCompraDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update ScpOrdenCompraDetalle set "		
		sCommand &= "objOrdenCompraID = @objOrdenCompraID,"
		sCommand &= "objProductoID = @objProductoID,"
		sCommand &= "CantidadOrdenada = @CantidadOrdenada,"
		sCommand &= "CantidadRecibida = @CantidadRecibida,"
		sCommand &= "CantidadDevuelta = @CantidadDevuelta,"
		sCommand &= "CostoUnitario = @CostoUnitario,"
		sCommand &= "CostoSubtotal = @CostoSubtotal,"
		sCommand &= "CostoImpuesto = @CostoImpuesto,"
		sCommand &= "CostoTotal = @CostoTotal,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "ScpOrdenCompraDetalle = @ScpOrdenCompraDetalle"					
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@ScpOrdenCompraDetalle", SqlDbType.Int)		
		If IsDBNull(m_ScpOrdenCompraDetalle) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ScpOrdenCompraDetalle
        End If
		arParams(1) = New SqlParameter("@objOrdenCompraID", SqlDbType.Int)		
		If IsDBNull(m_objOrdenCompraID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objOrdenCompraID
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
		arParams(4) = New SqlParameter("@CantidadRecibida", SqlDbType.Float)		
		If IsDBNull(m_CantidadRecibida) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_CantidadRecibida
        End If
		arParams(5) = New SqlParameter("@CantidadDevuelta", SqlDbType.Float)		
		If IsDBNull(m_CantidadDevuelta) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_CantidadDevuelta
        End If
		arParams(6) = New SqlParameter("@CostoUnitario", SqlDbType.Decimal)		
		If IsDBNull(m_CostoUnitario) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_CostoUnitario
        End If
		arParams(7) = New SqlParameter("@CostoSubtotal", SqlDbType.Decimal)		
		If IsDBNull(m_CostoSubtotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_CostoSubtotal
        End If
		arParams(8) = New SqlParameter("@CostoImpuesto", SqlDbType.Decimal)		
		If IsDBNull(m_CostoImpuesto) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_CostoImpuesto
        End If
		arParams(9) = New SqlParameter("@CostoTotal", SqlDbType.Decimal)		
		If IsDBNull(m_CostoTotal) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_CostoTotal
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
		arParams(11) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioCreacion
        End If
		arParams(12) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaModificacion
        End If
		arParams(13) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioModificacion
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
    ''' Borra un objeto ScpOrdenCompraDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScpOrdenCompraDetalle where " & " ScpOrdenCompraDetalle = " & m_ScpOrdenCompraDetalle
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
    ''' Borra un objeto ScpOrdenCompraDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ScpOrdenCompraDetalle as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScpOrdenCompraDetalle where " & " ScpOrdenCompraDetalle = " & p_ScpOrdenCompraDetalle
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
    ''' Borra objetos ScpOrdenCompraDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScpOrdenCompraDetalle where " & pWhere
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
