Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SfaCotizacionDetalle		

#Region " Variables Miembro " 
	Protected m_SfaCotizacionDetalleID As Integer 
	Protected m_objCotizacionID As Integer 
	Protected m_objRepuestoID As String = Nothing 
	Protected m_Cantidad As Integer 
	Protected m_Precio As Decimal 
	Protected m_Subtotal As Decimal 
	Protected m_PorcentajeDescuento As Decimal 
	Protected m_Descuento As Decimal 
	Protected m_Impuesto As Decimal 
	Protected m_Total As Decimal 
	Protected m_CostoDolares As Decimal 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SfaCotizacionDetalleID() As Integer
        Get
            Return (m_SfaCotizacionDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_SfaCotizacionDetalleID = Value
		End Set
    End Property
	
	Public Property objCotizacionID() As Integer
        Get
            Return (m_objCotizacionID)
        End Get
		Set(ByVal Value As Integer)					
			m_objCotizacionID = Value
		End Set
    End Property
	
	Public Property objRepuestoID() As String
        Get
            Return (m_objRepuestoID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("objRepuestoID", Value.ToString(), "Valor inv?lido para SfaCotizacionDetalle.objRepuestoID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_objRepuestoID = Value
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
	
	Public Property PorcentajeDescuento() As Decimal
        Get
            Return (m_PorcentajeDescuento)
        End Get
		Set(ByVal Value As Decimal)					
			m_PorcentajeDescuento = Value
		End Set
    End Property
	
	Public Property Descuento() As Decimal
        Get
            Return (m_Descuento)
        End Get
		Set(ByVal Value As Decimal)					
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SfaCotizacionDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SfaCotizacionDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
			Case "Precio"
				Return	11
			Case "Subtotal"
				Return	11
			Case "PorcentajeDescuento"
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
			Case "PorcentajeDescuento"
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
    ''' Salva un DataSet del tipo de la tabla SfaCotizacionDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SfaCotizacionDetalle </param>    
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
			cmdDelete.Parameters.Add("@SfaCotizacionDetalleID", SqlDbType.Int, 4, "SfaCotizacionDetalleID" )
			cmdDelete.CommandText = "DELETE FROM  SfaCotizacionDetalle WHERE SfaCotizacionDetalleID= @SfaCotizacionDetalleID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objCotizacionID", SqlDbType.Int, 4, "objCotizacionID")
			cmdInsert.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdInsert.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdInsert.Parameters.Add("@Precio", SqlDbType.Decimal, 9, "Precio")
			cmdInsert.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdInsert.Parameters.Add("@PorcentajeDescuento", SqlDbType.Decimal, 9, "PorcentajeDescuento")
			cmdInsert.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdInsert.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdInsert.Parameters.Add("@Total", SqlDbType.Decimal, 9, "Total")
			cmdInsert.Parameters.Add("@CostoDolares", SqlDbType.Decimal, 9, "CostoDolares")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SfaCotizacionDetalle ( objCotizacionID, objRepuestoID, Cantidad, Precio, Subtotal, PorcentajeDescuento, Descuento, Impuesto, Total, CostoDolares, FechaCreacion, UsuarioCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objCotizacionID, @objRepuestoID, @Cantidad, @Precio, @Subtotal, @PorcentajeDescuento, @Descuento, @Impuesto, @Total, @CostoDolares, @FechaCreacion, @UsuarioCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objCotizacionID", SqlDbType.Int, 4, "objCotizacionID")
			cmdUpdate.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdUpdate.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdUpdate.Parameters.Add("@Precio", SqlDbType.Decimal, 9, "Precio")
			cmdUpdate.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdUpdate.Parameters.Add("@PorcentajeDescuento", SqlDbType.Decimal, 9, "PorcentajeDescuento")
			cmdUpdate.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdUpdate.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdUpdate.Parameters.Add("@Total", SqlDbType.Decimal, 9, "Total")
			cmdUpdate.Parameters.Add("@CostoDolares", SqlDbType.Decimal, 9, "CostoDolares")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSfaCotizacionDetalleID", SqlDbType.Int, 4, "SfaCotizacionDetalleID")
			cmdUpdate.CommandText = "UPDATE SfaCotizacionDetalle SET objCotizacionID=@objCotizacionID, objRepuestoID=@objRepuestoID, Cantidad=@Cantidad, Precio=@Precio, Subtotal=@Subtotal, PorcentajeDescuento=@PorcentajeDescuento, Descuento=@Descuento, Impuesto=@Impuesto, Total=@Total, CostoDolares=@CostoDolares, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SfaCotizacionDetalleID= @wSfaCotizacionDetalleID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SfaCotizacionDetalle")
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
    ''' Devuelve de la base de datos un objeto SfaCotizacionDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SfaCotizacionDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaCotizacionDetalle where " & " SfaCotizacionDetalleID = " & p_SfaCotizacionDetalleID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SfaCotizacionDetalleID = dr("SfaCotizacionDetalleID")
				m_objCotizacionID = IIf(IsDBNull(dr("objCotizacionID")), Nothing, dr("objCotizacionID"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_Precio = IIf(IsDBNull(dr("Precio")), Nothing, dr("Precio"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_PorcentajeDescuento = IIf(IsDBNull(dr("PorcentajeDescuento")), Nothing, dr("PorcentajeDescuento"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_Total = IIf(IsDBNull(dr("Total")), Nothing, dr("Total"))					
				m_CostoDolares = IIf(IsDBNull(dr("CostoDolares")), Nothing, dr("CostoDolares"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
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
    ''' Devuelve de la base de datos un objeto SfaCotizacionDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaCotizacionDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SfaCotizacionDetalleID = dr("SfaCotizacionDetalleID")
				m_objCotizacionID = IIf(IsDBNull(dr("objCotizacionID")), Nothing, dr("objCotizacionID"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_Precio = IIf(IsDBNull(dr("Precio")), Nothing, dr("Precio"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_PorcentajeDescuento = IIf(IsDBNull(dr("PorcentajeDescuento")), Nothing, dr("PorcentajeDescuento"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_Total = IIf(IsDBNull(dr("Total")), Nothing, dr("Total"))					
				m_CostoDolares = IIf(IsDBNull(dr("CostoDolares")), Nothing, dr("CostoDolares"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
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
    ''' Trae de la base de datos un conjunto de objetos SfaCotizacionDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SfaCotizacionDetalle"

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
			ds.Tables(0).TableName = "SfaCotizacionDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaCotizacionDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SfaCotizacionDetalle"

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
			ds.Tables(0).TableName = "SfaCotizacionDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaCotizacionDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SfaCotizacionDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SfaCotizacionDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SfaCotizacionDetalle("
		sCommand &= "objCotizacionID,"
		sCommand &= "objRepuestoID,"
		sCommand &= "Cantidad,"
		sCommand &= "Precio,"
		sCommand &= "Subtotal,"
		sCommand &= "PorcentajeDescuento,"
		sCommand &= "Descuento,"
		sCommand &= "Impuesto,"
		sCommand &= "Total,"
		sCommand &= "CostoDolares,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objCotizacionID,"
		sCommand &= "@objRepuestoID,"
		sCommand &= "@Cantidad,"
		sCommand &= "@Precio,"
		sCommand &= "@Subtotal,"
		sCommand &= "@PorcentajeDescuento,"
		sCommand &= "@Descuento,"
		sCommand &= "@Impuesto,"
		sCommand &= "@Total,"
		sCommand &= "@CostoDolares,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SfaCotizacionDetalleID = SfaCotizacionDetalleID from SfaCotizacionDetalle where "		
		sCommand &= "SfaCotizacionDetalleID = SCOPE_IDENTITY()"
		
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@SfaCotizacionDetalleID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objCotizacionID", SqlDbType.Int)		
		If IsDBNull(m_objCotizacionID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCotizacionID
        End If
		arParams(2) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objRepuestoID
        End If
		arParams(3) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Cantidad
        End If
		arParams(4) = New SqlParameter("@Precio", SqlDbType.Decimal)		
		If IsDBNull(m_Precio) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Precio
        End If
		arParams(5) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Subtotal
        End If
		arParams(6) = New SqlParameter("@PorcentajeDescuento", SqlDbType.Decimal)		
		If IsDBNull(m_PorcentajeDescuento) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_PorcentajeDescuento
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
		arParams(11) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaCreacion
        End If
		arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
		arParams(13) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioModificacion
        End If
		arParams(14) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SfaCotizacionDetalleID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SfaCotizacionDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SfaCotizacionDetalle set "		
		sCommand &= "objCotizacionID = @objCotizacionID,"
		sCommand &= "objRepuestoID = @objRepuestoID,"
		sCommand &= "Cantidad = @Cantidad,"
		sCommand &= "Precio = @Precio,"
		sCommand &= "Subtotal = @Subtotal,"
		sCommand &= "PorcentajeDescuento = @PorcentajeDescuento,"
		sCommand &= "Descuento = @Descuento,"
		sCommand &= "Impuesto = @Impuesto,"
		sCommand &= "Total = @Total,"
		sCommand &= "CostoDolares = @CostoDolares,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SfaCotizacionDetalleID = @SfaCotizacionDetalleID"					
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@SfaCotizacionDetalleID", SqlDbType.Int)		
		If IsDBNull(m_SfaCotizacionDetalleID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SfaCotizacionDetalleID
        End If
		arParams(1) = New SqlParameter("@objCotizacionID", SqlDbType.Int)		
		If IsDBNull(m_objCotizacionID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCotizacionID
        End If
		arParams(2) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objRepuestoID
        End If
		arParams(3) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Cantidad
        End If
		arParams(4) = New SqlParameter("@Precio", SqlDbType.Decimal)		
		If IsDBNull(m_Precio) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Precio
        End If
		arParams(5) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Subtotal
        End If
		arParams(6) = New SqlParameter("@PorcentajeDescuento", SqlDbType.Decimal)		
		If IsDBNull(m_PorcentajeDescuento) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_PorcentajeDescuento
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
		arParams(11) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaCreacion
        End If
		arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
		arParams(13) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioModificacion
        End If
		arParams(14) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaModificacion
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
    ''' Borra un objeto SfaCotizacionDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaCotizacionDetalle where " & " SfaCotizacionDetalleID = " & m_SfaCotizacionDetalleID
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
    ''' Borra un objeto SfaCotizacionDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SfaCotizacionDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaCotizacionDetalle where " & " SfaCotizacionDetalleID = " & p_SfaCotizacionDetalleID
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
    ''' Borra objetos SfaCotizacionDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaCotizacionDetalle where " & pWhere
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
