Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class ScpOrdenCompra		

#Region " Variables Miembro " 
	Protected m_ScpOrdenCompraID As Integer 
	Protected m_FechaAutorizacion As Nullable(Of Date) 
	Protected m_FechaEntregada As Nullable(Of Date) 
	Protected m_FechaRecibida As Nullable(Of Date) 
	Protected m_FechaAnulada As Nullable(Of Date) 
	Protected m_CostoSubtotal As Decimal 
	Protected m_CostoImpuesto As Decimal 
	Protected m_CostoTotal As Decimal 
	Protected m_PrecioSubTotal As Decimal 
	Protected m_PrecioDescuento As Decimal 
	Protected m_PrecioImpuesto As Decimal 
	Protected m_PrecioTotal As Decimal 
	Protected m_TipoCambio As Decimal 
	Protected m_Observaciones As String = Nothing 
	Protected m_objEstadoID As Integer 
	Protected m_objProveedorID As Integer 
	Protected m_UsuarioAutorizacion As String = Nothing 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ScpOrdenCompraID() As Integer
        Get
            Return (m_ScpOrdenCompraID)
        End Get
		Set(ByVal Value As Integer)					
			m_ScpOrdenCompraID = Value
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
	
	Public Property FechaEntregada() As Nullable(Of Date)
        Get
            Return (m_FechaEntregada)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaEntregada = Value
		End Set
    End Property
	
	Public Property FechaRecibida() As Nullable(Of Date)
        Get
            Return (m_FechaRecibida)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaRecibida = Value
		End Set
    End Property
	
	Public Property FechaAnulada() As Nullable(Of Date)
        Get
            Return (m_FechaAnulada)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaAnulada = Value
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
	
	Public Property PrecioSubTotal() As Decimal
        Get
            Return (m_PrecioSubTotal)
        End Get
		Set(ByVal Value As Decimal)					
			m_PrecioSubTotal = Value
		End Set
    End Property
	
	Public Property PrecioDescuento() As Decimal
        Get
            Return (m_PrecioDescuento)
        End Get
		Set(ByVal Value As Decimal)					
			m_PrecioDescuento = Value
		End Set
    End Property
	
	Public Property PrecioImpuesto() As Decimal
        Get
            Return (m_PrecioImpuesto)
        End Get
		Set(ByVal Value As Decimal)					
			m_PrecioImpuesto = Value
		End Set
    End Property
	
	Public Property PrecioTotal() As Decimal
        Get
            Return (m_PrecioTotal)
        End Get
		Set(ByVal Value As Decimal)					
			m_PrecioTotal = Value
		End Set
    End Property
	
	Public Property TipoCambio() As Decimal
        Get
            Return (m_TipoCambio)
        End Get
		Set(ByVal Value As Decimal)					
			m_TipoCambio = Value
		End Set
    End Property
	
	Public Property Observaciones() As String
        Get
            Return (m_Observaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 250 Then
					Throw New ArgumentOutOfRangeException("Observaciones", Value.ToString(), "Valor inv?lido para ScpOrdenCompra.Observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (250).")
				End If
			End If
			m_Observaciones = Value
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
	
	Public Property UsuarioAutorizacion() As String
        Get
            Return (m_UsuarioAutorizacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioAutorizacion", Value.ToString(), "Valor inv?lido para ScpOrdenCompra.UsuarioAutorizacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioAutorizacion = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para ScpOrdenCompra.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para ScpOrdenCompra.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "CostoSubtotal"
				Return	11
			Case "CostoImpuesto"
				Return	11
			Case "CostoTotal"
				Return	11
			Case "PrecioSubTotal"
				Return	11
			Case "PrecioDescuento"
				Return	11
			Case "PrecioImpuesto"
				Return	11
			Case "PrecioTotal"
				Return	11
			Case "TipoCambio"
				Return	11
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
			Case "CostoSubtotal"
				Return	2
			Case "CostoImpuesto"
				Return	2
			Case "CostoTotal"
				Return	2
			Case "PrecioSubTotal"
				Return	2
			Case "PrecioDescuento"
				Return	2
			Case "PrecioImpuesto"
				Return	2
			Case "PrecioTotal"
				Return	2
			Case "TipoCambio"
				Return	4
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla ScpOrdenCompra en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla ScpOrdenCompra </param>    
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
			cmdDelete.Parameters.Add("@ScpOrdenCompraID", SqlDbType.Int, 4, "ScpOrdenCompraID" )
			cmdDelete.CommandText = "DELETE FROM  ScpOrdenCompra WHERE ScpOrdenCompraID= @ScpOrdenCompraID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@FechaAutorizacion", SqlDbType.DateTime, 8, "FechaAutorizacion")
			cmdInsert.Parameters.Add("@FechaEntregada", SqlDbType.DateTime, 8, "FechaEntregada")
			cmdInsert.Parameters.Add("@FechaRecibida", SqlDbType.DateTime, 8, "FechaRecibida")
			cmdInsert.Parameters.Add("@FechaAnulada", SqlDbType.DateTime, 8, "FechaAnulada")
			cmdInsert.Parameters.Add("@CostoSubtotal", SqlDbType.Decimal, 9, "CostoSubtotal")
			cmdInsert.Parameters.Add("@CostoImpuesto", SqlDbType.Decimal, 9, "CostoImpuesto")
			cmdInsert.Parameters.Add("@CostoTotal", SqlDbType.Decimal, 9, "CostoTotal")
			cmdInsert.Parameters.Add("@PrecioSubTotal", SqlDbType.Decimal, 9, "PrecioSubTotal")
			cmdInsert.Parameters.Add("@PrecioDescuento", SqlDbType.Decimal, 9, "PrecioDescuento")
			cmdInsert.Parameters.Add("@PrecioImpuesto", SqlDbType.Decimal, 9, "PrecioImpuesto")
			cmdInsert.Parameters.Add("@PrecioTotal", SqlDbType.Decimal, 9, "PrecioTotal")
			cmdInsert.Parameters.Add("@TipoCambio", SqlDbType.Decimal, 9, "TipoCambio")
			cmdInsert.Parameters.Add("@Observaciones", SqlDbType.VarChar, 250, "Observaciones")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objProveedorID", SqlDbType.Int, 4, "objProveedorID")
			cmdInsert.Parameters.Add("@UsuarioAutorizacion", SqlDbType.VarChar, 30, "UsuarioAutorizacion")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO ScpOrdenCompra ( FechaAutorizacion, FechaEntregada, FechaRecibida, FechaAnulada, CostoSubtotal, CostoImpuesto, CostoTotal, PrecioSubTotal, PrecioDescuento, PrecioImpuesto, PrecioTotal, TipoCambio, Observaciones, objEstadoID, objProveedorID, UsuarioAutorizacion, Activa, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @FechaAutorizacion, @FechaEntregada, @FechaRecibida, @FechaAnulada, @CostoSubtotal, @CostoImpuesto, @CostoTotal, @PrecioSubTotal, @PrecioDescuento, @PrecioImpuesto, @PrecioTotal, @TipoCambio, @Observaciones, @objEstadoID, @objProveedorID, @UsuarioAutorizacion, @Activa, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@FechaAutorizacion", SqlDbType.DateTime, 8, "FechaAutorizacion")
			cmdUpdate.Parameters.Add("@FechaEntregada", SqlDbType.DateTime, 8, "FechaEntregada")
			cmdUpdate.Parameters.Add("@FechaRecibida", SqlDbType.DateTime, 8, "FechaRecibida")
			cmdUpdate.Parameters.Add("@FechaAnulada", SqlDbType.DateTime, 8, "FechaAnulada")
			cmdUpdate.Parameters.Add("@CostoSubtotal", SqlDbType.Decimal, 9, "CostoSubtotal")
			cmdUpdate.Parameters.Add("@CostoImpuesto", SqlDbType.Decimal, 9, "CostoImpuesto")
			cmdUpdate.Parameters.Add("@CostoTotal", SqlDbType.Decimal, 9, "CostoTotal")
			cmdUpdate.Parameters.Add("@PrecioSubTotal", SqlDbType.Decimal, 9, "PrecioSubTotal")
			cmdUpdate.Parameters.Add("@PrecioDescuento", SqlDbType.Decimal, 9, "PrecioDescuento")
			cmdUpdate.Parameters.Add("@PrecioImpuesto", SqlDbType.Decimal, 9, "PrecioImpuesto")
			cmdUpdate.Parameters.Add("@PrecioTotal", SqlDbType.Decimal, 9, "PrecioTotal")
			cmdUpdate.Parameters.Add("@TipoCambio", SqlDbType.Decimal, 9, "TipoCambio")
			cmdUpdate.Parameters.Add("@Observaciones", SqlDbType.VarChar, 250, "Observaciones")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objProveedorID", SqlDbType.Int, 4, "objProveedorID")
			cmdUpdate.Parameters.Add("@UsuarioAutorizacion", SqlDbType.VarChar, 30, "UsuarioAutorizacion")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wScpOrdenCompraID", SqlDbType.Int, 4, "ScpOrdenCompraID")
			cmdUpdate.CommandText = "UPDATE ScpOrdenCompra SET FechaAutorizacion=@FechaAutorizacion, FechaEntregada=@FechaEntregada, FechaRecibida=@FechaRecibida, FechaAnulada=@FechaAnulada, CostoSubtotal=@CostoSubtotal, CostoImpuesto=@CostoImpuesto, CostoTotal=@CostoTotal, PrecioSubTotal=@PrecioSubTotal, PrecioDescuento=@PrecioDescuento, PrecioImpuesto=@PrecioImpuesto, PrecioTotal=@PrecioTotal, TipoCambio=@TipoCambio, Observaciones=@Observaciones, objEstadoID=@objEstadoID, objProveedorID=@objProveedorID, UsuarioAutorizacion=@UsuarioAutorizacion, Activa=@Activa, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE ScpOrdenCompraID= @wScpOrdenCompraID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "ScpOrdenCompra")
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
    ''' Devuelve de la base de datos un objeto ScpOrdenCompra
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ScpOrdenCompraID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScpOrdenCompra where " & " ScpOrdenCompraID = " & p_ScpOrdenCompraID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_ScpOrdenCompraID = dr("ScpOrdenCompraID")
				m_FechaAutorizacion = IIf(IsDBNull(dr("FechaAutorizacion")), Nothing, dr("FechaAutorizacion"))					
				m_FechaEntregada = IIf(IsDBNull(dr("FechaEntregada")), Nothing, dr("FechaEntregada"))					
				m_FechaRecibida = IIf(IsDBNull(dr("FechaRecibida")), Nothing, dr("FechaRecibida"))					
				m_FechaAnulada = IIf(IsDBNull(dr("FechaAnulada")), Nothing, dr("FechaAnulada"))					
				m_CostoSubtotal = IIf(IsDBNull(dr("CostoSubtotal")), Nothing, dr("CostoSubtotal"))					
				m_CostoImpuesto = IIf(IsDBNull(dr("CostoImpuesto")), Nothing, dr("CostoImpuesto"))					
				m_CostoTotal = IIf(IsDBNull(dr("CostoTotal")), Nothing, dr("CostoTotal"))					
				m_PrecioSubTotal = IIf(IsDBNull(dr("PrecioSubTotal")), Nothing, dr("PrecioSubTotal"))					
				m_PrecioDescuento = IIf(IsDBNull(dr("PrecioDescuento")), Nothing, dr("PrecioDescuento"))					
				m_PrecioImpuesto = IIf(IsDBNull(dr("PrecioImpuesto")), Nothing, dr("PrecioImpuesto"))					
				m_PrecioTotal = IIf(IsDBNull(dr("PrecioTotal")), Nothing, dr("PrecioTotal"))					
				m_TipoCambio = IIf(IsDBNull(dr("TipoCambio")), Nothing, dr("TipoCambio"))					
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objProveedorID = IIf(IsDBNull(dr("objProveedorID")), Nothing, dr("objProveedorID"))					
				m_UsuarioAutorizacion = IIf(IsDBNull(dr("UsuarioAutorizacion")), Nothing, dr("UsuarioAutorizacion"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
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
    ''' Devuelve de la base de datos un objeto ScpOrdenCompra usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScpOrdenCompra where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_ScpOrdenCompraID = dr("ScpOrdenCompraID")
				m_FechaAutorizacion = IIf(IsDBNull(dr("FechaAutorizacion")), Nothing, dr("FechaAutorizacion"))					
				m_FechaEntregada = IIf(IsDBNull(dr("FechaEntregada")), Nothing, dr("FechaEntregada"))					
				m_FechaRecibida = IIf(IsDBNull(dr("FechaRecibida")), Nothing, dr("FechaRecibida"))					
				m_FechaAnulada = IIf(IsDBNull(dr("FechaAnulada")), Nothing, dr("FechaAnulada"))					
				m_CostoSubtotal = IIf(IsDBNull(dr("CostoSubtotal")), Nothing, dr("CostoSubtotal"))					
				m_CostoImpuesto = IIf(IsDBNull(dr("CostoImpuesto")), Nothing, dr("CostoImpuesto"))					
				m_CostoTotal = IIf(IsDBNull(dr("CostoTotal")), Nothing, dr("CostoTotal"))					
				m_PrecioSubTotal = IIf(IsDBNull(dr("PrecioSubTotal")), Nothing, dr("PrecioSubTotal"))					
				m_PrecioDescuento = IIf(IsDBNull(dr("PrecioDescuento")), Nothing, dr("PrecioDescuento"))					
				m_PrecioImpuesto = IIf(IsDBNull(dr("PrecioImpuesto")), Nothing, dr("PrecioImpuesto"))					
				m_PrecioTotal = IIf(IsDBNull(dr("PrecioTotal")), Nothing, dr("PrecioTotal"))					
				m_TipoCambio = IIf(IsDBNull(dr("TipoCambio")), Nothing, dr("TipoCambio"))					
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objProveedorID = IIf(IsDBNull(dr("objProveedorID")), Nothing, dr("objProveedorID"))					
				m_UsuarioAutorizacion = IIf(IsDBNull(dr("UsuarioAutorizacion")), Nothing, dr("UsuarioAutorizacion"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
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
    ''' Trae de la base de datos un conjunto de objetos ScpOrdenCompra en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from ScpOrdenCompra"

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
			ds.Tables(0).TableName = "ScpOrdenCompra"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScpOrdenCompra en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from ScpOrdenCompra"

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
			ds.Tables(0).TableName = "ScpOrdenCompra"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScpOrdenCompra en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from ScpOrdenCompra"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase ScpOrdenCompra.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into ScpOrdenCompra("
		sCommand &= "FechaAutorizacion,"
		sCommand &= "FechaEntregada,"
		sCommand &= "FechaRecibida,"
		sCommand &= "FechaAnulada,"
		sCommand &= "CostoSubtotal,"
		sCommand &= "CostoImpuesto,"
		sCommand &= "CostoTotal,"
		sCommand &= "PrecioSubTotal,"
		sCommand &= "PrecioDescuento,"
		sCommand &= "PrecioImpuesto,"
		sCommand &= "PrecioTotal,"
		sCommand &= "TipoCambio,"
		sCommand &= "Observaciones,"
		sCommand &= "objEstadoID,"
		sCommand &= "objProveedorID,"
		sCommand &= "UsuarioAutorizacion,"
		sCommand &= "Activa,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@FechaAutorizacion,"
		sCommand &= "@FechaEntregada,"
		sCommand &= "@FechaRecibida,"
		sCommand &= "@FechaAnulada,"
		sCommand &= "@CostoSubtotal,"
		sCommand &= "@CostoImpuesto,"
		sCommand &= "@CostoTotal,"
		sCommand &= "@PrecioSubTotal,"
		sCommand &= "@PrecioDescuento,"
		sCommand &= "@PrecioImpuesto,"
		sCommand &= "@PrecioTotal,"
		sCommand &= "@TipoCambio,"
		sCommand &= "@Observaciones,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@objProveedorID,"
		sCommand &= "@UsuarioAutorizacion,"
		sCommand &= "@Activa,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ScpOrdenCompraID = ScpOrdenCompraID from ScpOrdenCompra where "		
		sCommand &= "ScpOrdenCompraID = SCOPE_IDENTITY()"
		
		
		Dim arParams(21) As SqlParameter
		arParams(0) = New SqlParameter("@ScpOrdenCompraID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@FechaAutorizacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAutorizacion) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_FechaAutorizacion
        End If
		arParams(2) = New SqlParameter("@FechaEntregada", SqlDbType.DateTime)		
		If IsDBNull(m_FechaEntregada) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_FechaEntregada
        End If
		arParams(3) = New SqlParameter("@FechaRecibida", SqlDbType.DateTime)		
		If IsDBNull(m_FechaRecibida) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaRecibida
        End If
		arParams(4) = New SqlParameter("@FechaAnulada", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAnulada) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaAnulada
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
		arParams(8) = New SqlParameter("@PrecioSubTotal", SqlDbType.Decimal)		
		If IsDBNull(m_PrecioSubTotal) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_PrecioSubTotal
        End If
		arParams(9) = New SqlParameter("@PrecioDescuento", SqlDbType.Decimal)		
		If IsDBNull(m_PrecioDescuento) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_PrecioDescuento
        End If
		arParams(10) = New SqlParameter("@PrecioImpuesto", SqlDbType.Decimal)		
		If IsDBNull(m_PrecioImpuesto) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_PrecioImpuesto
        End If
		arParams(11) = New SqlParameter("@PrecioTotal", SqlDbType.Decimal)		
		If IsDBNull(m_PrecioTotal) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_PrecioTotal
        End If
		arParams(12) = New SqlParameter("@TipoCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TipoCambio) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_TipoCambio
        End If
		arParams(13) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Observaciones
        End If
		arParams(14) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_objEstadoID
        End If
		arParams(15) = New SqlParameter("@objProveedorID", SqlDbType.Int)		
		If IsDBNull(m_objProveedorID) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_objProveedorID
        End If
		arParams(16) = New SqlParameter("@UsuarioAutorizacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioAutorizacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_UsuarioAutorizacion
        End If
		arParams(17) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Activa
        End If
		arParams(18) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaCreacion
        End If
		arParams(19) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioCreacion
        End If
		arParams(20) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaModificacion
        End If
		arParams(21) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ScpOrdenCompraID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto ScpOrdenCompra en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update ScpOrdenCompra set "		
		sCommand &= "FechaAutorizacion = @FechaAutorizacion,"
		sCommand &= "FechaEntregada = @FechaEntregada,"
		sCommand &= "FechaRecibida = @FechaRecibida,"
		sCommand &= "FechaAnulada = @FechaAnulada,"
		sCommand &= "CostoSubtotal = @CostoSubtotal,"
		sCommand &= "CostoImpuesto = @CostoImpuesto,"
		sCommand &= "CostoTotal = @CostoTotal,"
		sCommand &= "PrecioSubTotal = @PrecioSubTotal,"
		sCommand &= "PrecioDescuento = @PrecioDescuento,"
		sCommand &= "PrecioImpuesto = @PrecioImpuesto,"
		sCommand &= "PrecioTotal = @PrecioTotal,"
		sCommand &= "TipoCambio = @TipoCambio,"
		sCommand &= "Observaciones = @Observaciones,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objProveedorID = @objProveedorID,"
		sCommand &= "UsuarioAutorizacion = @UsuarioAutorizacion,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "ScpOrdenCompraID = @ScpOrdenCompraID"					
		
		Dim arParams(21) As SqlParameter
		arParams(0) = New SqlParameter("@ScpOrdenCompraID", SqlDbType.Int)		
		If IsDBNull(m_ScpOrdenCompraID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ScpOrdenCompraID
        End If
		arParams(1) = New SqlParameter("@FechaAutorizacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAutorizacion) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_FechaAutorizacion
        End If
		arParams(2) = New SqlParameter("@FechaEntregada", SqlDbType.DateTime)		
		If IsDBNull(m_FechaEntregada) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_FechaEntregada
        End If
		arParams(3) = New SqlParameter("@FechaRecibida", SqlDbType.DateTime)		
		If IsDBNull(m_FechaRecibida) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaRecibida
        End If
		arParams(4) = New SqlParameter("@FechaAnulada", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAnulada) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaAnulada
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
		arParams(8) = New SqlParameter("@PrecioSubTotal", SqlDbType.Decimal)		
		If IsDBNull(m_PrecioSubTotal) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_PrecioSubTotal
        End If
		arParams(9) = New SqlParameter("@PrecioDescuento", SqlDbType.Decimal)		
		If IsDBNull(m_PrecioDescuento) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_PrecioDescuento
        End If
		arParams(10) = New SqlParameter("@PrecioImpuesto", SqlDbType.Decimal)		
		If IsDBNull(m_PrecioImpuesto) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_PrecioImpuesto
        End If
		arParams(11) = New SqlParameter("@PrecioTotal", SqlDbType.Decimal)		
		If IsDBNull(m_PrecioTotal) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_PrecioTotal
        End If
		arParams(12) = New SqlParameter("@TipoCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TipoCambio) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_TipoCambio
        End If
		arParams(13) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Observaciones
        End If
		arParams(14) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_objEstadoID
        End If
		arParams(15) = New SqlParameter("@objProveedorID", SqlDbType.Int)		
		If IsDBNull(m_objProveedorID) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_objProveedorID
        End If
		arParams(16) = New SqlParameter("@UsuarioAutorizacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioAutorizacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_UsuarioAutorizacion
        End If
		arParams(17) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Activa
        End If
		arParams(18) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaCreacion
        End If
		arParams(19) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioCreacion
        End If
		arParams(20) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaModificacion
        End If
		arParams(21) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_UsuarioModificacion
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
    ''' Borra un objeto ScpOrdenCompra de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScpOrdenCompra where " & " ScpOrdenCompraID = " & m_ScpOrdenCompraID
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
    ''' Borra un objeto ScpOrdenCompra de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ScpOrdenCompraID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScpOrdenCompra where " & " ScpOrdenCompraID = " & p_ScpOrdenCompraID
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
    ''' Borra objetos ScpOrdenCompra de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScpOrdenCompra where " & pWhere
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
