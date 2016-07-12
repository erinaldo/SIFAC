Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SfaFacturaRepuestoDetalle		

#Region " Variables Miembro " 
	Protected m_SfaFacturaRepuestoDetalleID As Integer 
	Protected m_objFacturaRepuestoID As Integer 
	Protected m_objRepuestoID As String = Nothing 
	Protected m_DescripcionMoto As String = Nothing 
	Protected m_Cantidad As Integer 
	Protected m_Precio As Decimal 
	Protected m_Subtotal As Decimal 
	Protected m_Descuento As Nullable(Of Decimal) 
	Protected m_Impuesto As Decimal 
	Protected m_Total As Decimal 
	Protected m_CostoDolares As Decimal 
	Protected m_objEntradaBodegaID As Nullable(Of Integer) 
	Protected m_ExistenciaAnterior As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SfaFacturaRepuestoDetalleID() As Integer
        Get
            Return (m_SfaFacturaRepuestoDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_SfaFacturaRepuestoDetalleID = Value
		End Set
    End Property
	
	Public Property objFacturaRepuestoID() As Integer
        Get
            Return (m_objFacturaRepuestoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objFacturaRepuestoID = Value
		End Set
    End Property
	
	Public Property objRepuestoID() As String
        Get
            Return (m_objRepuestoID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("objRepuestoID", Value.ToString(), "Valor inv?lido para SfaFacturaRepuestoDetalle.objRepuestoID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_objRepuestoID = Value
		End Set
    End Property
	
	Public Property DescripcionMoto() As String
        Get
            Return (m_DescripcionMoto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 500 Then
					Throw New ArgumentOutOfRangeException("DescripcionMoto", Value.ToString(), "Valor inv?lido para SfaFacturaRepuestoDetalle.DescripcionMoto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (500).")
				End If
			End If
			m_DescripcionMoto = Value
		End Set
    End Property
	
	Public Property Cantidad() As Integer
        Get
            Return (m_Cantidad)
        End Get
		Set(ByVal Value As Integer)					
			m_Cantidad = Value
		End Set
    End Property
	
	Public Property Precio() As Decimal
        Get
            Return (m_Precio)
        End Get
		Set(ByVal Value As Decimal)					
			m_Precio = Value
		End Set
    End Property
	
	Public Property Subtotal() As Decimal
        Get
            Return (m_Subtotal)
        End Get
		Set(ByVal Value As Decimal)					
			m_Subtotal = Value
		End Set
    End Property
	
	Public Property Descuento() As Nullable(Of Decimal)
        Get
            Return (m_Descuento)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Descuento = Value
		End Set
    End Property
	
	Public Property Impuesto() As Decimal
        Get
            Return (m_Impuesto)
        End Get
		Set(ByVal Value As Decimal)					
			m_Impuesto = Value
		End Set
    End Property
	
	Public Property Total() As Decimal
        Get
            Return (m_Total)
        End Get
		Set(ByVal Value As Decimal)					
			m_Total = Value
		End Set
    End Property
	
	Public Property CostoDolares() As Decimal
        Get
            Return (m_CostoDolares)
        End Get
		Set(ByVal Value As Decimal)					
			m_CostoDolares = Value
		End Set
    End Property
	
	Public Property objEntradaBodegaID() As Nullable(Of Integer)
        Get
            Return (m_objEntradaBodegaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEntradaBodegaID = Value
		End Set
    End Property
	
	Public Property ExistenciaAnterior() As Nullable(Of Integer)
        Get
            Return (m_ExistenciaAnterior)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_ExistenciaAnterior = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SfaFacturaRepuestoDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SfaFacturaRepuestoDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
			Case "objRepuestoID"
				Return	50
			Case "DescripcionMoto"
				Return	500
			Case "Precio"
				Return	11
			Case "Subtotal"
				Return	11
			Case "Descuento"
				Return	11
			Case "Impuesto"
				Return	11
			Case "Total"
				Return	11
			Case "CostoDolares"
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
			Case "Precio"
				Return	2
			Case "Subtotal"
				Return	2
			Case "Descuento"
				Return	2
			Case "Impuesto"
				Return	2
			Case "Total"
				Return	2
			Case "CostoDolares"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SfaFacturaRepuestoDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SfaFacturaRepuestoDetalle </param>    
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
			cmdDelete.Parameters.Add("@SfaFacturaRepuestoDetalleID", SqlDbType.Int, 4, "SfaFacturaRepuestoDetalleID" )
			cmdDelete.CommandText = "DELETE FROM  SfaFacturaRepuestoDetalle WHERE SfaFacturaRepuestoDetalleID= @SfaFacturaRepuestoDetalleID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objFacturaRepuestoID", SqlDbType.Int, 4, "objFacturaRepuestoID")
			cmdInsert.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdInsert.Parameters.Add("@DescripcionMoto", SqlDbType.VarChar, 500, "DescripcionMoto")
			cmdInsert.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdInsert.Parameters.Add("@Precio", SqlDbType.Decimal, 9, "Precio")
			cmdInsert.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdInsert.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdInsert.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdInsert.Parameters.Add("@Total", SqlDbType.Decimal, 9, "Total")
			cmdInsert.Parameters.Add("@CostoDolares", SqlDbType.Decimal, 9, "CostoDolares")
			cmdInsert.Parameters.Add("@objEntradaBodegaID", SqlDbType.Int, 4, "objEntradaBodegaID")
			cmdInsert.Parameters.Add("@ExistenciaAnterior", SqlDbType.Int, 4, "ExistenciaAnterior")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SfaFacturaRepuestoDetalle ( objFacturaRepuestoID, objRepuestoID, DescripcionMoto, Cantidad, Precio, Subtotal, Descuento, Impuesto, Total, CostoDolares, objEntradaBodegaID, ExistenciaAnterior, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objFacturaRepuestoID, @objRepuestoID, @DescripcionMoto, @Cantidad, @Precio, @Subtotal, @Descuento, @Impuesto, @Total, @CostoDolares, @objEntradaBodegaID, @ExistenciaAnterior, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objFacturaRepuestoID", SqlDbType.Int, 4, "objFacturaRepuestoID")
			cmdUpdate.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdUpdate.Parameters.Add("@DescripcionMoto", SqlDbType.VarChar, 500, "DescripcionMoto")
			cmdUpdate.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdUpdate.Parameters.Add("@Precio", SqlDbType.Decimal, 9, "Precio")
			cmdUpdate.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdUpdate.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdUpdate.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdUpdate.Parameters.Add("@Total", SqlDbType.Decimal, 9, "Total")
			cmdUpdate.Parameters.Add("@CostoDolares", SqlDbType.Decimal, 9, "CostoDolares")
			cmdUpdate.Parameters.Add("@objEntradaBodegaID", SqlDbType.Int, 4, "objEntradaBodegaID")
			cmdUpdate.Parameters.Add("@ExistenciaAnterior", SqlDbType.Int, 4, "ExistenciaAnterior")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSfaFacturaRepuestoDetalleID", SqlDbType.Int, 4, "SfaFacturaRepuestoDetalleID")
			cmdUpdate.CommandText = "UPDATE SfaFacturaRepuestoDetalle SET objFacturaRepuestoID=@objFacturaRepuestoID, objRepuestoID=@objRepuestoID, DescripcionMoto=@DescripcionMoto, Cantidad=@Cantidad, Precio=@Precio, Subtotal=@Subtotal, Descuento=@Descuento, Impuesto=@Impuesto, Total=@Total, CostoDolares=@CostoDolares, objEntradaBodegaID=@objEntradaBodegaID, ExistenciaAnterior=@ExistenciaAnterior, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SfaFacturaRepuestoDetalleID= @wSfaFacturaRepuestoDetalleID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SfaFacturaRepuestoDetalle")
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
    ''' Devuelve de la base de datos un objeto SfaFacturaRepuestoDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SfaFacturaRepuestoDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaFacturaRepuestoDetalle where " & " SfaFacturaRepuestoDetalleID = " & p_SfaFacturaRepuestoDetalleID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SfaFacturaRepuestoDetalleID = dr("SfaFacturaRepuestoDetalleID")
				m_objFacturaRepuestoID = IIf(IsDBNull(dr("objFacturaRepuestoID")), Nothing, dr("objFacturaRepuestoID"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_DescripcionMoto = IIf(IsDBNull(dr("DescripcionMoto")), Nothing, dr("DescripcionMoto"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_Precio = IIf(IsDBNull(dr("Precio")), Nothing, dr("Precio"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_Total = IIf(IsDBNull(dr("Total")), Nothing, dr("Total"))					
				m_CostoDolares = IIf(IsDBNull(dr("CostoDolares")), Nothing, dr("CostoDolares"))					
				m_objEntradaBodegaID = IIf(IsDBNull(dr("objEntradaBodegaID")), Nothing, dr("objEntradaBodegaID"))					
				m_ExistenciaAnterior = IIf(IsDBNull(dr("ExistenciaAnterior")), Nothing, dr("ExistenciaAnterior"))					
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
    ''' Devuelve de la base de datos un objeto SfaFacturaRepuestoDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaFacturaRepuestoDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SfaFacturaRepuestoDetalleID = dr("SfaFacturaRepuestoDetalleID")
				m_objFacturaRepuestoID = IIf(IsDBNull(dr("objFacturaRepuestoID")), Nothing, dr("objFacturaRepuestoID"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_DescripcionMoto = IIf(IsDBNull(dr("DescripcionMoto")), Nothing, dr("DescripcionMoto"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_Precio = IIf(IsDBNull(dr("Precio")), Nothing, dr("Precio"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_Total = IIf(IsDBNull(dr("Total")), Nothing, dr("Total"))					
				m_CostoDolares = IIf(IsDBNull(dr("CostoDolares")), Nothing, dr("CostoDolares"))					
				m_objEntradaBodegaID = IIf(IsDBNull(dr("objEntradaBodegaID")), Nothing, dr("objEntradaBodegaID"))					
				m_ExistenciaAnterior = IIf(IsDBNull(dr("ExistenciaAnterior")), Nothing, dr("ExistenciaAnterior"))					
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
    ''' Trae de la base de datos un conjunto de objetos SfaFacturaRepuestoDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SfaFacturaRepuestoDetalle"

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
			ds.Tables(0).TableName = "SfaFacturaRepuestoDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaFacturaRepuestoDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SfaFacturaRepuestoDetalle"

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
			ds.Tables(0).TableName = "SfaFacturaRepuestoDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaFacturaRepuestoDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SfaFacturaRepuestoDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SfaFacturaRepuestoDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SfaFacturaRepuestoDetalle("
		sCommand &= "objFacturaRepuestoID,"
		sCommand &= "objRepuestoID,"
		sCommand &= "DescripcionMoto,"
		sCommand &= "Cantidad,"
		sCommand &= "Precio,"
		sCommand &= "Subtotal,"
		sCommand &= "Descuento,"
		sCommand &= "Impuesto,"
		sCommand &= "Total,"
		sCommand &= "CostoDolares,"
		sCommand &= "objEntradaBodegaID,"
		sCommand &= "ExistenciaAnterior,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objFacturaRepuestoID,"
		sCommand &= "@objRepuestoID,"
		sCommand &= "@DescripcionMoto,"
		sCommand &= "@Cantidad,"
		sCommand &= "@Precio,"
		sCommand &= "@Subtotal,"
		sCommand &= "@Descuento,"
		sCommand &= "@Impuesto,"
		sCommand &= "@Total,"
		sCommand &= "@CostoDolares,"
		sCommand &= "@objEntradaBodegaID,"
		sCommand &= "@ExistenciaAnterior,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SfaFacturaRepuestoDetalleID = SfaFacturaRepuestoDetalleID from SfaFacturaRepuestoDetalle where "		
		sCommand &= "SfaFacturaRepuestoDetalleID = SCOPE_IDENTITY()"
		
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaRepuestoDetalleID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objFacturaRepuestoID", SqlDbType.Int)		
		If IsDBNull(m_objFacturaRepuestoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objFacturaRepuestoID
        End If
		arParams(2) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objRepuestoID
        End If
		arParams(3) = New SqlParameter("@DescripcionMoto", SqlDbType.VarChar)		
		If IsDBNull(m_DescripcionMoto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_DescripcionMoto
        End If
		arParams(4) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Cantidad
        End If
		arParams(5) = New SqlParameter("@Precio", SqlDbType.Decimal)		
		If IsDBNull(m_Precio) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Precio
        End If
		arParams(6) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Subtotal
        End If
		arParams(7) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Descuento
        End If
		arParams(8) = New SqlParameter("@Impuesto", SqlDbType.Decimal)		
		If IsDBNull(m_Impuesto) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Impuesto
        End If
		arParams(9) = New SqlParameter("@Total", SqlDbType.Decimal)		
		If IsDBNull(m_Total) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Total
        End If
		arParams(10) = New SqlParameter("@CostoDolares", SqlDbType.Decimal)		
		If IsDBNull(m_CostoDolares) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_CostoDolares
        End If
		arParams(11) = New SqlParameter("@objEntradaBodegaID", SqlDbType.Int)		
		If IsDBNull(m_objEntradaBodegaID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objEntradaBodegaID
        End If
		arParams(12) = New SqlParameter("@ExistenciaAnterior", SqlDbType.Int)		
		If IsDBNull(m_ExistenciaAnterior) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_ExistenciaAnterior
        End If
		arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
		arParams(14) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaCreacion
        End If
		arParams(15) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioModificacion
        End If
		arParams(16) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SfaFacturaRepuestoDetalleID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SfaFacturaRepuestoDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SfaFacturaRepuestoDetalle set "		
		sCommand &= "objFacturaRepuestoID = @objFacturaRepuestoID,"
		sCommand &= "objRepuestoID = @objRepuestoID,"
		sCommand &= "DescripcionMoto = @DescripcionMoto,"
		sCommand &= "Cantidad = @Cantidad,"
		sCommand &= "Precio = @Precio,"
		sCommand &= "Subtotal = @Subtotal,"
		sCommand &= "Descuento = @Descuento,"
		sCommand &= "Impuesto = @Impuesto,"
		sCommand &= "Total = @Total,"
		sCommand &= "CostoDolares = @CostoDolares,"
		sCommand &= "objEntradaBodegaID = @objEntradaBodegaID,"
		sCommand &= "ExistenciaAnterior = @ExistenciaAnterior,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SfaFacturaRepuestoDetalleID = @SfaFacturaRepuestoDetalleID"					
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaRepuestoDetalleID", SqlDbType.Int)		
		If IsDBNull(m_SfaFacturaRepuestoDetalleID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SfaFacturaRepuestoDetalleID
        End If
		arParams(1) = New SqlParameter("@objFacturaRepuestoID", SqlDbType.Int)		
		If IsDBNull(m_objFacturaRepuestoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objFacturaRepuestoID
        End If
		arParams(2) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objRepuestoID
        End If
		arParams(3) = New SqlParameter("@DescripcionMoto", SqlDbType.VarChar)		
		If IsDBNull(m_DescripcionMoto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_DescripcionMoto
        End If
		arParams(4) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Cantidad
        End If
		arParams(5) = New SqlParameter("@Precio", SqlDbType.Decimal)		
		If IsDBNull(m_Precio) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Precio
        End If
		arParams(6) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Subtotal
        End If
		arParams(7) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Descuento
        End If
		arParams(8) = New SqlParameter("@Impuesto", SqlDbType.Decimal)		
		If IsDBNull(m_Impuesto) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Impuesto
        End If
		arParams(9) = New SqlParameter("@Total", SqlDbType.Decimal)		
		If IsDBNull(m_Total) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Total
        End If
		arParams(10) = New SqlParameter("@CostoDolares", SqlDbType.Decimal)		
		If IsDBNull(m_CostoDolares) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_CostoDolares
        End If
		arParams(11) = New SqlParameter("@objEntradaBodegaID", SqlDbType.Int)		
		If IsDBNull(m_objEntradaBodegaID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objEntradaBodegaID
        End If
		arParams(12) = New SqlParameter("@ExistenciaAnterior", SqlDbType.Int)		
		If IsDBNull(m_ExistenciaAnterior) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_ExistenciaAnterior
        End If
		arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
		arParams(14) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaCreacion
        End If
		arParams(15) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioModificacion
        End If
		arParams(16) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaModificacion
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
    ''' Borra un objeto SfaFacturaRepuestoDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturaRepuestoDetalle where " & " SfaFacturaRepuestoDetalleID = " & m_SfaFacturaRepuestoDetalleID
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
    ''' Borra un objeto SfaFacturaRepuestoDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SfaFacturaRepuestoDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturaRepuestoDetalle where " & " SfaFacturaRepuestoDetalleID = " & p_SfaFacturaRepuestoDetalleID
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
    ''' Borra objetos SfaFacturaRepuestoDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturaRepuestoDetalle where " & pWhere
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
