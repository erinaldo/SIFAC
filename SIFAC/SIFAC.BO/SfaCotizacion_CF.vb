Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SfaCotizacion		

#Region " Variables Miembro " 
	Protected m_SfaCotizacionID As Integer 
	Protected m_Fecha As Date 
	Protected m_objClienteID As String = Nothing 
	Protected m_objTiendaID As Integer 
	Protected m_objVendedorID As Nullable(Of Integer) 
	Protected m_AtencionA As String = Nothing 
	Protected m_Valido As Integer 
	Protected m_Subtotal As Decimal 
	Protected m_Descuento As Decimal 
	Protected m_Impuesto As Decimal 
	Protected m_TotalDolares As Decimal 
	Protected m_TotalCordobas As Decimal 
	Protected m_objTiempoEntregaID As Integer 
	Protected m_objTerminoPagoID As Integer 
	Protected m_TasaCambio As Decimal 
	Protected m_Comentario As String = Nothing 
	Protected m_Anulada As Boolean 
	Protected m_ComentarioAnular As String = Nothing 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SfaCotizacionID() As Integer
        Get
            Return (m_SfaCotizacionID)
        End Get
		Set(ByVal Value As Integer)					
			m_SfaCotizacionID = Value
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
	
	Public Property objClienteID() As String
        Get
            Return (m_objClienteID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 16 Then
					Throw New ArgumentOutOfRangeException("objClienteID", Value.ToString(), "Valor inv?lido para SfaCotizacion.objClienteID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (16).")
				End If
			End If
			m_objClienteID = Value
		End Set
    End Property
	
	Public Property objTiendaID() As Integer
        Get
            Return (m_objTiendaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTiendaID = Value
		End Set
    End Property
	
	Public Property objVendedorID() As Nullable(Of Integer)
        Get
            Return (m_objVendedorID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objVendedorID = Value
		End Set
    End Property
	
	Public Property AtencionA() As String
        Get
            Return (m_AtencionA)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 120 Then
					Throw New ArgumentOutOfRangeException("AtencionA", Value.ToString(), "Valor inv?lido para SfaCotizacion.AtencionA. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (120).")
				End If
			End If
			m_AtencionA = Value
		End Set
    End Property
	
	Public Property Valido() As Integer
        Get
            Return (m_Valido)
        End Get
		Set(ByVal Value As Integer)					
			m_Valido = Value
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
	
	Public Property TotalDolares() As Decimal
        Get
            Return (m_TotalDolares)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalDolares = Value
		End Set
    End Property
	
	Public Property TotalCordobas() As Decimal
        Get
            Return (m_TotalCordobas)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalCordobas = Value
		End Set
    End Property
	
	Public Property objTiempoEntregaID() As Integer
        Get
            Return (m_objTiempoEntregaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTiempoEntregaID = Value
		End Set
    End Property
	
	Public Property objTerminoPagoID() As Integer
        Get
            Return (m_objTerminoPagoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTerminoPagoID = Value
		End Set
    End Property
	
	Public Property TasaCambio() As Decimal
        Get
            Return (m_TasaCambio)
        End Get
		Set(ByVal Value As Decimal)					
			m_TasaCambio = Value
		End Set
    End Property
	
	Public Property Comentario() As String
        Get
            Return (m_Comentario)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 1000 Then
					Throw New ArgumentOutOfRangeException("Comentario", Value.ToString(), "Valor inv?lido para SfaCotizacion.Comentario. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (1000).")
				End If
			End If
			m_Comentario = Value
		End Set
    End Property
	
	Public Property Anulada() As Boolean
        Get
            Return (m_Anulada)
        End Get
		Set(ByVal Value As Boolean)					
			m_Anulada = Value
		End Set
    End Property
	
	Public Property ComentarioAnular() As String
        Get
            Return (m_ComentarioAnular)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 1000 Then
					Throw New ArgumentOutOfRangeException("ComentarioAnular", Value.ToString(), "Valor inv?lido para SfaCotizacion.ComentarioAnular. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (1000).")
				End If
			End If
			m_ComentarioAnular = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SfaCotizacion.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SfaCotizacion.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
			Case "objClienteID"
				Return	16
			Case "AtencionA"
				Return	120
			Case "Subtotal"
				Return	11
			Case "Descuento"
				Return	11
			Case "Impuesto"
				Return	11
			Case "TotalDolares"
				Return	11
			Case "TotalCordobas"
				Return	11
			Case "TasaCambio"
				Return	11
			Case "Comentario"
				Return	1000
			Case "ComentarioAnular"
				Return	1000
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
			Case "Subtotal"
				Return	2
			Case "Descuento"
				Return	2
			Case "Impuesto"
				Return	2
			Case "TotalDolares"
				Return	2
			Case "TotalCordobas"
				Return	2
			Case "TasaCambio"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SfaCotizacion en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SfaCotizacion </param>    
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
			cmdDelete.Parameters.Add("@SfaCotizacionID", SqlDbType.Int, 4, "SfaCotizacionID" )
			cmdDelete.CommandText = "DELETE FROM  SfaCotizacion WHERE SfaCotizacionID= @SfaCotizacionID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@objClienteID", SqlDbType.VarChar, 16, "objClienteID")
			cmdInsert.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdInsert.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdInsert.Parameters.Add("@AtencionA", SqlDbType.VarChar, 120, "AtencionA")
			cmdInsert.Parameters.Add("@Valido", SqlDbType.Int, 4, "Valido")
			cmdInsert.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdInsert.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdInsert.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdInsert.Parameters.Add("@TotalDolares", SqlDbType.Decimal, 9, "TotalDolares")
			cmdInsert.Parameters.Add("@TotalCordobas", SqlDbType.Decimal, 9, "TotalCordobas")
			cmdInsert.Parameters.Add("@objTiempoEntregaID", SqlDbType.Int, 4, "objTiempoEntregaID")
			cmdInsert.Parameters.Add("@objTerminoPagoID", SqlDbType.Int, 4, "objTerminoPagoID")
			cmdInsert.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdInsert.Parameters.Add("@Comentario", SqlDbType.VarChar, 1000, "Comentario")
			cmdInsert.Parameters.Add("@Anulada", SqlDbType.Bit, 1, "Anulada")
			cmdInsert.Parameters.Add("@ComentarioAnular", SqlDbType.VarChar, 1000, "ComentarioAnular")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SfaCotizacion ( Fecha, objClienteID, objTiendaID, objVendedorID, AtencionA, Valido, Subtotal, Descuento, Impuesto, TotalDolares, TotalCordobas, objTiempoEntregaID, objTerminoPagoID, TasaCambio, Comentario, Anulada, ComentarioAnular, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @Fecha, @objClienteID, @objTiendaID, @objVendedorID, @AtencionA, @Valido, @Subtotal, @Descuento, @Impuesto, @TotalDolares, @TotalCordobas, @objTiempoEntregaID, @objTerminoPagoID, @TasaCambio, @Comentario, @Anulada, @ComentarioAnular, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@objClienteID", SqlDbType.VarChar, 16, "objClienteID")
			cmdUpdate.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdUpdate.Parameters.Add("@AtencionA", SqlDbType.VarChar, 120, "AtencionA")
			cmdUpdate.Parameters.Add("@Valido", SqlDbType.Int, 4, "Valido")
			cmdUpdate.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdUpdate.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdUpdate.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdUpdate.Parameters.Add("@TotalDolares", SqlDbType.Decimal, 9, "TotalDolares")
			cmdUpdate.Parameters.Add("@TotalCordobas", SqlDbType.Decimal, 9, "TotalCordobas")
			cmdUpdate.Parameters.Add("@objTiempoEntregaID", SqlDbType.Int, 4, "objTiempoEntregaID")
			cmdUpdate.Parameters.Add("@objTerminoPagoID", SqlDbType.Int, 4, "objTerminoPagoID")
			cmdUpdate.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdUpdate.Parameters.Add("@Comentario", SqlDbType.VarChar, 1000, "Comentario")
			cmdUpdate.Parameters.Add("@Anulada", SqlDbType.Bit, 1, "Anulada")
			cmdUpdate.Parameters.Add("@ComentarioAnular", SqlDbType.VarChar, 1000, "ComentarioAnular")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSfaCotizacionID", SqlDbType.Int, 4, "SfaCotizacionID")
			cmdUpdate.CommandText = "UPDATE SfaCotizacion SET Fecha=@Fecha, objClienteID=@objClienteID, objTiendaID=@objTiendaID, objVendedorID=@objVendedorID, AtencionA=@AtencionA, Valido=@Valido, Subtotal=@Subtotal, Descuento=@Descuento, Impuesto=@Impuesto, TotalDolares=@TotalDolares, TotalCordobas=@TotalCordobas, objTiempoEntregaID=@objTiempoEntregaID, objTerminoPagoID=@objTerminoPagoID, TasaCambio=@TasaCambio, Comentario=@Comentario, Anulada=@Anulada, ComentarioAnular=@ComentarioAnular, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SfaCotizacionID= @wSfaCotizacionID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SfaCotizacion")
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
    ''' Devuelve de la base de datos un objeto SfaCotizacion
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SfaCotizacionID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaCotizacion where " & " SfaCotizacionID = " & p_SfaCotizacionID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SfaCotizacionID = dr("SfaCotizacionID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_objClienteID = IIf(IsDBNull(dr("objClienteID")), Nothing, dr("objClienteID"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_AtencionA = IIf(IsDBNull(dr("AtencionA")), Nothing, dr("AtencionA"))					
				m_Valido = IIf(IsDBNull(dr("Valido")), Nothing, dr("Valido"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_TotalDolares = IIf(IsDBNull(dr("TotalDolares")), Nothing, dr("TotalDolares"))					
				m_TotalCordobas = IIf(IsDBNull(dr("TotalCordobas")), Nothing, dr("TotalCordobas"))					
				m_objTiempoEntregaID = IIf(IsDBNull(dr("objTiempoEntregaID")), Nothing, dr("objTiempoEntregaID"))					
				m_objTerminoPagoID = IIf(IsDBNull(dr("objTerminoPagoID")), Nothing, dr("objTerminoPagoID"))					
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))					
				m_Comentario = IIf(IsDBNull(dr("Comentario")), Nothing, dr("Comentario"))					
				m_Anulada = IIf(IsDBNull(dr("Anulada")), Nothing, dr("Anulada"))					
				m_ComentarioAnular = IIf(IsDBNull(dr("ComentarioAnular")), Nothing, dr("ComentarioAnular"))					
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
    ''' Devuelve de la base de datos un objeto SfaCotizacion usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaCotizacion where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SfaCotizacionID = dr("SfaCotizacionID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_objClienteID = IIf(IsDBNull(dr("objClienteID")), Nothing, dr("objClienteID"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_AtencionA = IIf(IsDBNull(dr("AtencionA")), Nothing, dr("AtencionA"))					
				m_Valido = IIf(IsDBNull(dr("Valido")), Nothing, dr("Valido"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_TotalDolares = IIf(IsDBNull(dr("TotalDolares")), Nothing, dr("TotalDolares"))					
				m_TotalCordobas = IIf(IsDBNull(dr("TotalCordobas")), Nothing, dr("TotalCordobas"))					
				m_objTiempoEntregaID = IIf(IsDBNull(dr("objTiempoEntregaID")), Nothing, dr("objTiempoEntregaID"))					
				m_objTerminoPagoID = IIf(IsDBNull(dr("objTerminoPagoID")), Nothing, dr("objTerminoPagoID"))					
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))					
				m_Comentario = IIf(IsDBNull(dr("Comentario")), Nothing, dr("Comentario"))					
				m_Anulada = IIf(IsDBNull(dr("Anulada")), Nothing, dr("Anulada"))					
				m_ComentarioAnular = IIf(IsDBNull(dr("ComentarioAnular")), Nothing, dr("ComentarioAnular"))					
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
    ''' Trae de la base de datos un conjunto de objetos SfaCotizacion en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SfaCotizacion"

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
			ds.Tables(0).TableName = "SfaCotizacion"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaCotizacion en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SfaCotizacion"

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
			ds.Tables(0).TableName = "SfaCotizacion"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaCotizacion en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SfaCotizacion"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SfaCotizacion.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SfaCotizacion("
		sCommand &= "Fecha,"
		sCommand &= "objClienteID,"
		sCommand &= "objTiendaID,"
		sCommand &= "objVendedorID,"
		sCommand &= "AtencionA,"
		sCommand &= "Valido,"
		sCommand &= "Subtotal,"
		sCommand &= "Descuento,"
		sCommand &= "Impuesto,"
		sCommand &= "TotalDolares,"
		sCommand &= "TotalCordobas,"
		sCommand &= "objTiempoEntregaID,"
		sCommand &= "objTerminoPagoID,"
		sCommand &= "TasaCambio,"
		sCommand &= "Comentario,"
		sCommand &= "Anulada,"
		sCommand &= "ComentarioAnular,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@Fecha,"
		sCommand &= "@objClienteID,"
		sCommand &= "@objTiendaID,"
		sCommand &= "@objVendedorID,"
		sCommand &= "@AtencionA,"
		sCommand &= "@Valido,"
		sCommand &= "@Subtotal,"
		sCommand &= "@Descuento,"
		sCommand &= "@Impuesto,"
		sCommand &= "@TotalDolares,"
		sCommand &= "@TotalCordobas,"
		sCommand &= "@objTiempoEntregaID,"
		sCommand &= "@objTerminoPagoID,"
		sCommand &= "@TasaCambio,"
		sCommand &= "@Comentario,"
		sCommand &= "@Anulada,"
		sCommand &= "@ComentarioAnular,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SfaCotizacionID = SfaCotizacionID from SfaCotizacion where "		
		sCommand &= "SfaCotizacionID = SCOPE_IDENTITY()"
		
		
		Dim arParams(21) As SqlParameter
		arParams(0) = New SqlParameter("@SfaCotizacionID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@objClienteID", SqlDbType.VarChar)		
		If IsDBNull(m_objClienteID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objClienteID
        End If
		arParams(3) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objTiendaID
        End If
		arParams(4) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objVendedorID
        End If
		arParams(5) = New SqlParameter("@AtencionA", SqlDbType.VarChar)		
		If IsDBNull(m_AtencionA) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_AtencionA
        End If
		arParams(6) = New SqlParameter("@Valido", SqlDbType.Int)		
		If IsDBNull(m_Valido) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Valido
        End If
		arParams(7) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Subtotal
        End If
		arParams(8) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Descuento
        End If
		arParams(9) = New SqlParameter("@Impuesto", SqlDbType.Decimal)		
		If IsDBNull(m_Impuesto) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Impuesto
        End If
		arParams(10) = New SqlParameter("@TotalDolares", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDolares) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_TotalDolares
        End If
		arParams(11) = New SqlParameter("@TotalCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalCordobas) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_TotalCordobas
        End If
		arParams(12) = New SqlParameter("@objTiempoEntregaID", SqlDbType.Int)		
		If IsDBNull(m_objTiempoEntregaID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objTiempoEntregaID
        End If
		arParams(13) = New SqlParameter("@objTerminoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTerminoPagoID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objTerminoPagoID
        End If
		arParams(14) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_TasaCambio
        End If
		arParams(15) = New SqlParameter("@Comentario", SqlDbType.VarChar)		
		If IsDBNull(m_Comentario) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Comentario
        End If
		arParams(16) = New SqlParameter("@Anulada", SqlDbType.Bit)		
		If IsDBNull(m_Anulada) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Anulada
        End If
		arParams(17) = New SqlParameter("@ComentarioAnular", SqlDbType.VarChar)		
		If IsDBNull(m_ComentarioAnular) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_ComentarioAnular
        End If
		arParams(18) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_UsuarioCreacion
        End If
		arParams(19) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_FechaCreacion
        End If
		arParams(20) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_UsuarioModificacion
        End If
		arParams(21) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SfaCotizacionID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SfaCotizacion en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SfaCotizacion set "		
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "objClienteID = @objClienteID,"
		sCommand &= "objTiendaID = @objTiendaID,"
		sCommand &= "objVendedorID = @objVendedorID,"
		sCommand &= "AtencionA = @AtencionA,"
		sCommand &= "Valido = @Valido,"
		sCommand &= "Subtotal = @Subtotal,"
		sCommand &= "Descuento = @Descuento,"
		sCommand &= "Impuesto = @Impuesto,"
		sCommand &= "TotalDolares = @TotalDolares,"
		sCommand &= "TotalCordobas = @TotalCordobas,"
		sCommand &= "objTiempoEntregaID = @objTiempoEntregaID,"
		sCommand &= "objTerminoPagoID = @objTerminoPagoID,"
		sCommand &= "TasaCambio = @TasaCambio,"
		sCommand &= "Comentario = @Comentario,"
		sCommand &= "Anulada = @Anulada,"
		sCommand &= "ComentarioAnular = @ComentarioAnular,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SfaCotizacionID = @SfaCotizacionID"					
		
		Dim arParams(21) As SqlParameter
		arParams(0) = New SqlParameter("@SfaCotizacionID", SqlDbType.Int)		
		If IsDBNull(m_SfaCotizacionID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SfaCotizacionID
        End If
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@objClienteID", SqlDbType.VarChar)		
		If IsDBNull(m_objClienteID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objClienteID
        End If
		arParams(3) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objTiendaID
        End If
		arParams(4) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objVendedorID
        End If
		arParams(5) = New SqlParameter("@AtencionA", SqlDbType.VarChar)		
		If IsDBNull(m_AtencionA) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_AtencionA
        End If
		arParams(6) = New SqlParameter("@Valido", SqlDbType.Int)		
		If IsDBNull(m_Valido) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Valido
        End If
		arParams(7) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Subtotal
        End If
		arParams(8) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Descuento
        End If
		arParams(9) = New SqlParameter("@Impuesto", SqlDbType.Decimal)		
		If IsDBNull(m_Impuesto) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Impuesto
        End If
		arParams(10) = New SqlParameter("@TotalDolares", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDolares) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_TotalDolares
        End If
		arParams(11) = New SqlParameter("@TotalCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalCordobas) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_TotalCordobas
        End If
		arParams(12) = New SqlParameter("@objTiempoEntregaID", SqlDbType.Int)		
		If IsDBNull(m_objTiempoEntregaID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objTiempoEntregaID
        End If
		arParams(13) = New SqlParameter("@objTerminoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTerminoPagoID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objTerminoPagoID
        End If
		arParams(14) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_TasaCambio
        End If
		arParams(15) = New SqlParameter("@Comentario", SqlDbType.VarChar)		
		If IsDBNull(m_Comentario) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Comentario
        End If
		arParams(16) = New SqlParameter("@Anulada", SqlDbType.Bit)		
		If IsDBNull(m_Anulada) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Anulada
        End If
		arParams(17) = New SqlParameter("@ComentarioAnular", SqlDbType.VarChar)		
		If IsDBNull(m_ComentarioAnular) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_ComentarioAnular
        End If
		arParams(18) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_UsuarioCreacion
        End If
		arParams(19) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_FechaCreacion
        End If
		arParams(20) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_UsuarioModificacion
        End If
		arParams(21) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_FechaModificacion
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
    ''' Borra un objeto SfaCotizacion de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaCotizacion where " & " SfaCotizacionID = " & m_SfaCotizacionID
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
    ''' Borra un objeto SfaCotizacion de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SfaCotizacionID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaCotizacion where " & " SfaCotizacionID = " & p_SfaCotizacionID
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
    ''' Borra objetos SfaCotizacion de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaCotizacion where " & pWhere
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
