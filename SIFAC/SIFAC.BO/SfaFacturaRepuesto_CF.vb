Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SfaFacturaRepuesto		

#Region " Variables Miembro " 
	Protected m_SfaFacturaRepuestoID As Integer 
	Protected m_serie As String = Nothing 
	Protected m_Numero As Nullable(Of Integer) 
	Protected m_OrdenCompra As Nullable(Of Integer) 
	Protected m_Fecha As Date 
	Protected m_objTiendaID As Integer 
	Protected m_objClienteID As String = Nothing 
	Protected m_objVendedorID As Nullable(Of Integer) 
	Protected m_objEstadoID As Integer 
	Protected m_objTerminoPagoID As Integer 
	Protected m_objMotivoAnularID As Nullable(Of Integer) 
	Protected m_AtencionA As String = Nothing 
	Protected m_Subtotal As Decimal 
	Protected m_Descuento As Decimal 
	Protected m_Impuesto As Decimal 
	Protected m_TotalCordobas As Decimal 
	Protected m_TotalDolares As Decimal 
	Protected m_TasaCambio As Decimal 
	Protected m_FacturaMoto As Boolean 
	Protected m_Prima As Nullable(Of Decimal) 
	Protected m_Saldo As Nullable(Of Decimal) 
	Protected m_observaciones As String = Nothing 
	Protected m_SolicAutorDescuento As Boolean 
	Protected m_SolicitudDescuento As String = Nothing 
	Protected m_DescuentoAutorizado As Decimal 
	Protected m_AutorizaDescuento As Boolean 
	Protected m_NumeroReciboCancelacion As String = Nothing 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SfaFacturaRepuestoID() As Integer
        Get
            Return (m_SfaFacturaRepuestoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SfaFacturaRepuestoID = Value
		End Set
    End Property
	
	Public Property serie() As String
        Get
            Return (m_serie)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("serie", Value.ToString(), "Valor inv?lido para SfaFacturaRepuesto.serie. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_serie = Value
		End Set
    End Property
	
	Public Property Numero() As Nullable(Of Integer)
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Numero = Value
		End Set
    End Property
	
	Public Property OrdenCompra() As Nullable(Of Integer)
        Get
            Return (m_OrdenCompra)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_OrdenCompra = Value
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
	
	Public Property objTiendaID() As Integer
        Get
            Return (m_objTiendaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTiendaID = Value
		End Set
    End Property
	
	Public Property objClienteID() As String
        Get
            Return (m_objClienteID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 16 Then
					Throw New ArgumentOutOfRangeException("objClienteID", Value.ToString(), "Valor inv?lido para SfaFacturaRepuesto.objClienteID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (16).")
				End If
			End If
			m_objClienteID = Value
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
	
	Public Property objEstadoID() As Integer
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEstadoID = Value
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
	
	Public Property objMotivoAnularID() As Nullable(Of Integer)
        Get
            Return (m_objMotivoAnularID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objMotivoAnularID = Value
		End Set
    End Property
	
	Public Property AtencionA() As String
        Get
            Return (m_AtencionA)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 120 Then
					Throw New ArgumentOutOfRangeException("AtencionA", Value.ToString(), "Valor inv?lido para SfaFacturaRepuesto.AtencionA. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (120).")
				End If
			End If
			m_AtencionA = Value
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
	
	Public Property TotalCordobas() As Decimal
        Get
            Return (m_TotalCordobas)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalCordobas = Value
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
	
	Public Property TasaCambio() As Decimal
        Get
            Return (m_TasaCambio)
        End Get
		Set(ByVal Value As Decimal)					
			m_TasaCambio = Value
		End Set
    End Property
	
	Public Property FacturaMoto() As Boolean
        Get
            Return (m_FacturaMoto)
        End Get
		Set(ByVal Value As Boolean)					
			m_FacturaMoto = Value
		End Set
    End Property
	
	Public Property Prima() As Nullable(Of Decimal)
        Get
            Return (m_Prima)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Prima = Value
		End Set
    End Property
	
	Public Property Saldo() As Nullable(Of Decimal)
        Get
            Return (m_Saldo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Saldo = Value
		End Set
    End Property
	
	Public Property observaciones() As String
        Get
            Return (m_observaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("observaciones", Value.ToString(), "Valor inv?lido para SfaFacturaRepuesto.observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_observaciones = Value
		End Set
    End Property
	
	Public Property SolicAutorDescuento() As Boolean
        Get
            Return (m_SolicAutorDescuento)
        End Get
		Set(ByVal Value As Boolean)					
			m_SolicAutorDescuento = Value
		End Set
    End Property
	
	Public Property SolicitudDescuento() As String
        Get
            Return (m_SolicitudDescuento)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("SolicitudDescuento", Value.ToString(), "Valor inv?lido para SfaFacturaRepuesto.SolicitudDescuento. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_SolicitudDescuento = Value
		End Set
    End Property
	
	Public Property DescuentoAutorizado() As Decimal
        Get
            Return (m_DescuentoAutorizado)
        End Get
		Set(ByVal Value As Decimal)					
			m_DescuentoAutorizado = Value
		End Set
    End Property
	
	Public Property AutorizaDescuento() As Boolean
        Get
            Return (m_AutorizaDescuento)
        End Get
		Set(ByVal Value As Boolean)					
			m_AutorizaDescuento = Value
		End Set
    End Property
	
	Public Property NumeroReciboCancelacion() As String
        Get
            Return (m_NumeroReciboCancelacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 15 Then
					Throw New ArgumentOutOfRangeException("NumeroReciboCancelacion", Value.ToString(), "Valor inv?lido para SfaFacturaRepuesto.NumeroReciboCancelacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (15).")
				End If
			End If
			m_NumeroReciboCancelacion = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SfaFacturaRepuesto.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SfaFacturaRepuesto.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
			Case "serie"
				Return	2
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
			Case "TotalCordobas"
				Return	11
			Case "TotalDolares"
				Return	11
			Case "TasaCambio"
				Return	11
			Case "Prima"
				Return	11
			Case "Saldo"
				Return	11
			Case "observaciones"
				Return	100
			Case "SolicitudDescuento"
				Return	100
			Case "DescuentoAutorizado"
				Return	11
			Case "NumeroReciboCancelacion"
				Return	15
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
			Case "TotalCordobas"
				Return	2
			Case "TotalDolares"
				Return	2
			Case "TasaCambio"
				Return	2
			Case "Prima"
				Return	2
			Case "Saldo"
				Return	2
			Case "DescuentoAutorizado"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SfaFacturaRepuesto en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SfaFacturaRepuesto </param>    
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
			cmdDelete.Parameters.Add("@SfaFacturaRepuestoID", SqlDbType.Int, 4, "SfaFacturaRepuestoID" )
			cmdDelete.CommandText = "DELETE FROM  SfaFacturaRepuesto WHERE SfaFacturaRepuestoID= @SfaFacturaRepuestoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@serie", SqlDbType.VarChar, 2, "serie")
			cmdInsert.Parameters.Add("@Numero", SqlDbType.Int, 4, "Numero")
			cmdInsert.Parameters.Add("@OrdenCompra", SqlDbType.Int, 4, "OrdenCompra")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdInsert.Parameters.Add("@objClienteID", SqlDbType.VarChar, 16, "objClienteID")
			cmdInsert.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objTerminoPagoID", SqlDbType.Int, 4, "objTerminoPagoID")
			cmdInsert.Parameters.Add("@objMotivoAnularID", SqlDbType.Int, 4, "objMotivoAnularID")
			cmdInsert.Parameters.Add("@AtencionA", SqlDbType.VarChar, 120, "AtencionA")
			cmdInsert.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdInsert.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdInsert.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdInsert.Parameters.Add("@TotalCordobas", SqlDbType.Decimal, 9, "TotalCordobas")
			cmdInsert.Parameters.Add("@TotalDolares", SqlDbType.Decimal, 9, "TotalDolares")
			cmdInsert.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdInsert.Parameters.Add("@FacturaMoto", SqlDbType.Bit, 1, "FacturaMoto")
			cmdInsert.Parameters.Add("@Prima", SqlDbType.Decimal, 9, "Prima")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@observaciones", SqlDbType.VarChar, 100, "observaciones")
			cmdInsert.Parameters.Add("@SolicAutorDescuento", SqlDbType.Bit, 1, "SolicAutorDescuento")
			cmdInsert.Parameters.Add("@SolicitudDescuento", SqlDbType.VarChar, 100, "SolicitudDescuento")
			cmdInsert.Parameters.Add("@DescuentoAutorizado", SqlDbType.Decimal, 9, "DescuentoAutorizado")
			cmdInsert.Parameters.Add("@AutorizaDescuento", SqlDbType.Bit, 1, "AutorizaDescuento")
			cmdInsert.Parameters.Add("@NumeroReciboCancelacion", SqlDbType.VarChar, 15, "NumeroReciboCancelacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SfaFacturaRepuesto ( serie, Numero, OrdenCompra, Fecha, objTiendaID, objClienteID, objVendedorID, objEstadoID, objTerminoPagoID, objMotivoAnularID, AtencionA, Subtotal, Descuento, Impuesto, TotalCordobas, TotalDolares, TasaCambio, FacturaMoto, Prima, Saldo, observaciones, SolicAutorDescuento, SolicitudDescuento, DescuentoAutorizado, AutorizaDescuento, NumeroReciboCancelacion, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @serie, @Numero, @OrdenCompra, @Fecha, @objTiendaID, @objClienteID, @objVendedorID, @objEstadoID, @objTerminoPagoID, @objMotivoAnularID, @AtencionA, @Subtotal, @Descuento, @Impuesto, @TotalCordobas, @TotalDolares, @TasaCambio, @FacturaMoto, @Prima, @Saldo, @observaciones, @SolicAutorDescuento, @SolicitudDescuento, @DescuentoAutorizado, @AutorizaDescuento, @NumeroReciboCancelacion, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@serie", SqlDbType.VarChar, 2, "serie")
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.Int, 4, "Numero")
			cmdUpdate.Parameters.Add("@OrdenCompra", SqlDbType.Int, 4, "OrdenCompra")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.Parameters.Add("@objClienteID", SqlDbType.VarChar, 16, "objClienteID")
			cmdUpdate.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objTerminoPagoID", SqlDbType.Int, 4, "objTerminoPagoID")
			cmdUpdate.Parameters.Add("@objMotivoAnularID", SqlDbType.Int, 4, "objMotivoAnularID")
			cmdUpdate.Parameters.Add("@AtencionA", SqlDbType.VarChar, 120, "AtencionA")
			cmdUpdate.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdUpdate.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdUpdate.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdUpdate.Parameters.Add("@TotalCordobas", SqlDbType.Decimal, 9, "TotalCordobas")
			cmdUpdate.Parameters.Add("@TotalDolares", SqlDbType.Decimal, 9, "TotalDolares")
			cmdUpdate.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdUpdate.Parameters.Add("@FacturaMoto", SqlDbType.Bit, 1, "FacturaMoto")
			cmdUpdate.Parameters.Add("@Prima", SqlDbType.Decimal, 9, "Prima")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@observaciones", SqlDbType.VarChar, 100, "observaciones")
			cmdUpdate.Parameters.Add("@SolicAutorDescuento", SqlDbType.Bit, 1, "SolicAutorDescuento")
			cmdUpdate.Parameters.Add("@SolicitudDescuento", SqlDbType.VarChar, 100, "SolicitudDescuento")
			cmdUpdate.Parameters.Add("@DescuentoAutorizado", SqlDbType.Decimal, 9, "DescuentoAutorizado")
			cmdUpdate.Parameters.Add("@AutorizaDescuento", SqlDbType.Bit, 1, "AutorizaDescuento")
			cmdUpdate.Parameters.Add("@NumeroReciboCancelacion", SqlDbType.VarChar, 15, "NumeroReciboCancelacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSfaFacturaRepuestoID", SqlDbType.Int, 4, "SfaFacturaRepuestoID")
			cmdUpdate.CommandText = "UPDATE SfaFacturaRepuesto SET serie=@serie, Numero=@Numero, OrdenCompra=@OrdenCompra, Fecha=@Fecha, objTiendaID=@objTiendaID, objClienteID=@objClienteID, objVendedorID=@objVendedorID, objEstadoID=@objEstadoID, objTerminoPagoID=@objTerminoPagoID, objMotivoAnularID=@objMotivoAnularID, AtencionA=@AtencionA, Subtotal=@Subtotal, Descuento=@Descuento, Impuesto=@Impuesto, TotalCordobas=@TotalCordobas, TotalDolares=@TotalDolares, TasaCambio=@TasaCambio, FacturaMoto=@FacturaMoto, Prima=@Prima, Saldo=@Saldo, observaciones=@observaciones, SolicAutorDescuento=@SolicAutorDescuento, SolicitudDescuento=@SolicitudDescuento, DescuentoAutorizado=@DescuentoAutorizado, AutorizaDescuento=@AutorizaDescuento, NumeroReciboCancelacion=@NumeroReciboCancelacion, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SfaFacturaRepuestoID= @wSfaFacturaRepuestoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SfaFacturaRepuesto")
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
    ''' Devuelve de la base de datos un objeto SfaFacturaRepuesto
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SfaFacturaRepuestoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaFacturaRepuesto where " & " SfaFacturaRepuestoID = " & p_SfaFacturaRepuestoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SfaFacturaRepuestoID = dr("SfaFacturaRepuestoID")
				m_serie = IIf(IsDBNull(dr("serie")), Nothing, dr("serie"))					
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_OrdenCompra = IIf(IsDBNull(dr("OrdenCompra")), Nothing, dr("OrdenCompra"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_objClienteID = IIf(IsDBNull(dr("objClienteID")), Nothing, dr("objClienteID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objTerminoPagoID = IIf(IsDBNull(dr("objTerminoPagoID")), Nothing, dr("objTerminoPagoID"))					
				m_objMotivoAnularID = IIf(IsDBNull(dr("objMotivoAnularID")), Nothing, dr("objMotivoAnularID"))					
				m_AtencionA = IIf(IsDBNull(dr("AtencionA")), Nothing, dr("AtencionA"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_TotalCordobas = IIf(IsDBNull(dr("TotalCordobas")), Nothing, dr("TotalCordobas"))					
				m_TotalDolares = IIf(IsDBNull(dr("TotalDolares")), Nothing, dr("TotalDolares"))					
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))					
				m_FacturaMoto = IIf(IsDBNull(dr("FacturaMoto")), Nothing, dr("FacturaMoto"))					
				m_Prima = IIf(IsDBNull(dr("Prima")), Nothing, dr("Prima"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_observaciones = IIf(IsDBNull(dr("observaciones")), Nothing, dr("observaciones"))					
				m_SolicAutorDescuento = IIf(IsDBNull(dr("SolicAutorDescuento")), Nothing, dr("SolicAutorDescuento"))					
				m_SolicitudDescuento = IIf(IsDBNull(dr("SolicitudDescuento")), Nothing, dr("SolicitudDescuento"))					
				m_DescuentoAutorizado = IIf(IsDBNull(dr("DescuentoAutorizado")), Nothing, dr("DescuentoAutorizado"))					
				m_AutorizaDescuento = IIf(IsDBNull(dr("AutorizaDescuento")), Nothing, dr("AutorizaDescuento"))					
				m_NumeroReciboCancelacion = IIf(IsDBNull(dr("NumeroReciboCancelacion")), Nothing, dr("NumeroReciboCancelacion"))					
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
    ''' Devuelve de la base de datos un objeto SfaFacturaRepuesto usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaFacturaRepuesto where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SfaFacturaRepuestoID = dr("SfaFacturaRepuestoID")
				m_serie = IIf(IsDBNull(dr("serie")), Nothing, dr("serie"))					
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_OrdenCompra = IIf(IsDBNull(dr("OrdenCompra")), Nothing, dr("OrdenCompra"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_objClienteID = IIf(IsDBNull(dr("objClienteID")), Nothing, dr("objClienteID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objTerminoPagoID = IIf(IsDBNull(dr("objTerminoPagoID")), Nothing, dr("objTerminoPagoID"))					
				m_objMotivoAnularID = IIf(IsDBNull(dr("objMotivoAnularID")), Nothing, dr("objMotivoAnularID"))					
				m_AtencionA = IIf(IsDBNull(dr("AtencionA")), Nothing, dr("AtencionA"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_TotalCordobas = IIf(IsDBNull(dr("TotalCordobas")), Nothing, dr("TotalCordobas"))					
				m_TotalDolares = IIf(IsDBNull(dr("TotalDolares")), Nothing, dr("TotalDolares"))					
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))					
				m_FacturaMoto = IIf(IsDBNull(dr("FacturaMoto")), Nothing, dr("FacturaMoto"))					
				m_Prima = IIf(IsDBNull(dr("Prima")), Nothing, dr("Prima"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_observaciones = IIf(IsDBNull(dr("observaciones")), Nothing, dr("observaciones"))					
				m_SolicAutorDescuento = IIf(IsDBNull(dr("SolicAutorDescuento")), Nothing, dr("SolicAutorDescuento"))					
				m_SolicitudDescuento = IIf(IsDBNull(dr("SolicitudDescuento")), Nothing, dr("SolicitudDescuento"))					
				m_DescuentoAutorizado = IIf(IsDBNull(dr("DescuentoAutorizado")), Nothing, dr("DescuentoAutorizado"))					
				m_AutorizaDescuento = IIf(IsDBNull(dr("AutorizaDescuento")), Nothing, dr("AutorizaDescuento"))					
				m_NumeroReciboCancelacion = IIf(IsDBNull(dr("NumeroReciboCancelacion")), Nothing, dr("NumeroReciboCancelacion"))					
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
    ''' Trae de la base de datos un conjunto de objetos SfaFacturaRepuesto en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SfaFacturaRepuesto"

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
			ds.Tables(0).TableName = "SfaFacturaRepuesto"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaFacturaRepuesto en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SfaFacturaRepuesto"

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
			ds.Tables(0).TableName = "SfaFacturaRepuesto"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaFacturaRepuesto en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SfaFacturaRepuesto"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SfaFacturaRepuesto.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SfaFacturaRepuesto("
		sCommand &= "serie,"
		sCommand &= "Numero,"
		sCommand &= "OrdenCompra,"
		sCommand &= "Fecha,"
		sCommand &= "objTiendaID,"
		sCommand &= "objClienteID,"
		sCommand &= "objVendedorID,"
		sCommand &= "objEstadoID,"
		sCommand &= "objTerminoPagoID,"
		sCommand &= "objMotivoAnularID,"
		sCommand &= "AtencionA,"
		sCommand &= "Subtotal,"
		sCommand &= "Descuento,"
		sCommand &= "Impuesto,"
		sCommand &= "TotalCordobas,"
		sCommand &= "TotalDolares,"
		sCommand &= "TasaCambio,"
		sCommand &= "FacturaMoto,"
		sCommand &= "Prima,"
		sCommand &= "Saldo,"
		sCommand &= "observaciones,"
		sCommand &= "SolicAutorDescuento,"
		sCommand &= "SolicitudDescuento,"
		sCommand &= "DescuentoAutorizado,"
		sCommand &= "AutorizaDescuento,"
		sCommand &= "NumeroReciboCancelacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@serie,"
		sCommand &= "@Numero,"
		sCommand &= "@OrdenCompra,"
		sCommand &= "@Fecha,"
		sCommand &= "@objTiendaID,"
		sCommand &= "@objClienteID,"
		sCommand &= "@objVendedorID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@objTerminoPagoID,"
		sCommand &= "@objMotivoAnularID,"
		sCommand &= "@AtencionA,"
		sCommand &= "@Subtotal,"
		sCommand &= "@Descuento,"
		sCommand &= "@Impuesto,"
		sCommand &= "@TotalCordobas,"
		sCommand &= "@TotalDolares,"
		sCommand &= "@TasaCambio,"
		sCommand &= "@FacturaMoto,"
		sCommand &= "@Prima,"
		sCommand &= "@Saldo,"
		sCommand &= "@observaciones,"
		sCommand &= "@SolicAutorDescuento,"
		sCommand &= "@SolicitudDescuento,"
		sCommand &= "@DescuentoAutorizado,"
		sCommand &= "@AutorizaDescuento,"
		sCommand &= "@NumeroReciboCancelacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SfaFacturaRepuestoID = SfaFacturaRepuestoID from SfaFacturaRepuesto where "		
		sCommand &= "SfaFacturaRepuestoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(30) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaRepuestoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@serie", SqlDbType.VarChar)		
		If IsDBNull(m_serie) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_serie
        End If
		arParams(2) = New SqlParameter("@Numero", SqlDbType.Int)		
		If IsDBNull(m_Numero) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Numero
        End If
		arParams(3) = New SqlParameter("@OrdenCompra", SqlDbType.Int)		
		If IsDBNull(m_OrdenCompra) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_OrdenCompra
        End If
		arParams(4) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Fecha
        End If
		arParams(5) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objTiendaID
        End If
		arParams(6) = New SqlParameter("@objClienteID", SqlDbType.VarChar)		
		If IsDBNull(m_objClienteID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objClienteID
        End If
		arParams(7) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objVendedorID
        End If
		arParams(8) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objEstadoID
        End If
		arParams(9) = New SqlParameter("@objTerminoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTerminoPagoID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objTerminoPagoID
        End If
		arParams(10) = New SqlParameter("@objMotivoAnularID", SqlDbType.Int)		
		If IsDBNull(m_objMotivoAnularID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objMotivoAnularID
        End If
		arParams(11) = New SqlParameter("@AtencionA", SqlDbType.VarChar)		
		If IsDBNull(m_AtencionA) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_AtencionA
        End If
		arParams(12) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Subtotal
        End If
		arParams(13) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Descuento
        End If
		arParams(14) = New SqlParameter("@Impuesto", SqlDbType.Decimal)		
		If IsDBNull(m_Impuesto) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Impuesto
        End If
		arParams(15) = New SqlParameter("@TotalCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalCordobas) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_TotalCordobas
        End If
		arParams(16) = New SqlParameter("@TotalDolares", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDolares) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_TotalDolares
        End If
		arParams(17) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_TasaCambio
        End If
		arParams(18) = New SqlParameter("@FacturaMoto", SqlDbType.Bit)		
		If IsDBNull(m_FacturaMoto) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FacturaMoto
        End If
		arParams(19) = New SqlParameter("@Prima", SqlDbType.Decimal)		
		If IsDBNull(m_Prima) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_Prima
        End If
		arParams(20) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_Saldo
        End If
		arParams(21) = New SqlParameter("@observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_observaciones) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_observaciones
        End If
		arParams(22) = New SqlParameter("@SolicAutorDescuento", SqlDbType.Bit)		
		If IsDBNull(m_SolicAutorDescuento) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_SolicAutorDescuento
        End If
		arParams(23) = New SqlParameter("@SolicitudDescuento", SqlDbType.VarChar)		
		If IsDBNull(m_SolicitudDescuento) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_SolicitudDescuento
        End If
		arParams(24) = New SqlParameter("@DescuentoAutorizado", SqlDbType.Decimal)		
		If IsDBNull(m_DescuentoAutorizado) Then
            arParams(24).Value = DBNull.Value
        Else
            arParams(24).Value = m_DescuentoAutorizado
        End If
		arParams(25) = New SqlParameter("@AutorizaDescuento", SqlDbType.Bit)		
		If IsDBNull(m_AutorizaDescuento) Then
            arParams(25).Value = DBNull.Value
        Else
            arParams(25).Value = m_AutorizaDescuento
        End If
		arParams(26) = New SqlParameter("@NumeroReciboCancelacion", SqlDbType.VarChar)		
		If IsDBNull(m_NumeroReciboCancelacion) Then
            arParams(26).Value = DBNull.Value
        Else
            arParams(26).Value = m_NumeroReciboCancelacion
        End If
		arParams(27) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(27).Value = DBNull.Value
        Else
            arParams(27).Value = m_UsuarioCreacion
        End If
		arParams(28) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(28).Value = DBNull.Value
        Else
            arParams(28).Value = m_FechaCreacion
        End If
		arParams(29) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(29).Value = DBNull.Value
        Else
            arParams(29).Value = m_UsuarioModificacion
        End If
		arParams(30) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(30).Value = DBNull.Value
        Else
            arParams(30).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SfaFacturaRepuestoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SfaFacturaRepuesto en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SfaFacturaRepuesto set "		
		sCommand &= "serie = @serie,"
		sCommand &= "Numero = @Numero,"
		sCommand &= "OrdenCompra = @OrdenCompra,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "objTiendaID = @objTiendaID,"
		sCommand &= "objClienteID = @objClienteID,"
		sCommand &= "objVendedorID = @objVendedorID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objTerminoPagoID = @objTerminoPagoID,"
		sCommand &= "objMotivoAnularID = @objMotivoAnularID,"
		sCommand &= "AtencionA = @AtencionA,"
		sCommand &= "Subtotal = @Subtotal,"
		sCommand &= "Descuento = @Descuento,"
		sCommand &= "Impuesto = @Impuesto,"
		sCommand &= "TotalCordobas = @TotalCordobas,"
		sCommand &= "TotalDolares = @TotalDolares,"
		sCommand &= "TasaCambio = @TasaCambio,"
		sCommand &= "FacturaMoto = @FacturaMoto,"
		sCommand &= "Prima = @Prima,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "observaciones = @observaciones,"
		sCommand &= "SolicAutorDescuento = @SolicAutorDescuento,"
		sCommand &= "SolicitudDescuento = @SolicitudDescuento,"
		sCommand &= "DescuentoAutorizado = @DescuentoAutorizado,"
		sCommand &= "AutorizaDescuento = @AutorizaDescuento,"
		sCommand &= "NumeroReciboCancelacion = @NumeroReciboCancelacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SfaFacturaRepuestoID = @SfaFacturaRepuestoID"					
		
		Dim arParams(30) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaRepuestoID", SqlDbType.Int)		
		If IsDBNull(m_SfaFacturaRepuestoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SfaFacturaRepuestoID
        End If
		arParams(1) = New SqlParameter("@serie", SqlDbType.VarChar)		
		If IsDBNull(m_serie) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_serie
        End If
		arParams(2) = New SqlParameter("@Numero", SqlDbType.Int)		
		If IsDBNull(m_Numero) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Numero
        End If
		arParams(3) = New SqlParameter("@OrdenCompra", SqlDbType.Int)		
		If IsDBNull(m_OrdenCompra) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_OrdenCompra
        End If
		arParams(4) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Fecha
        End If
		arParams(5) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objTiendaID
        End If
		arParams(6) = New SqlParameter("@objClienteID", SqlDbType.VarChar)		
		If IsDBNull(m_objClienteID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objClienteID
        End If
		arParams(7) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objVendedorID
        End If
		arParams(8) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objEstadoID
        End If
		arParams(9) = New SqlParameter("@objTerminoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTerminoPagoID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objTerminoPagoID
        End If
		arParams(10) = New SqlParameter("@objMotivoAnularID", SqlDbType.Int)		
		If IsDBNull(m_objMotivoAnularID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objMotivoAnularID
        End If
		arParams(11) = New SqlParameter("@AtencionA", SqlDbType.VarChar)		
		If IsDBNull(m_AtencionA) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_AtencionA
        End If
		arParams(12) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Subtotal
        End If
		arParams(13) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Descuento
        End If
		arParams(14) = New SqlParameter("@Impuesto", SqlDbType.Decimal)		
		If IsDBNull(m_Impuesto) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Impuesto
        End If
		arParams(15) = New SqlParameter("@TotalCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalCordobas) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_TotalCordobas
        End If
		arParams(16) = New SqlParameter("@TotalDolares", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDolares) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_TotalDolares
        End If
		arParams(17) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_TasaCambio
        End If
		arParams(18) = New SqlParameter("@FacturaMoto", SqlDbType.Bit)		
		If IsDBNull(m_FacturaMoto) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FacturaMoto
        End If
		arParams(19) = New SqlParameter("@Prima", SqlDbType.Decimal)		
		If IsDBNull(m_Prima) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_Prima
        End If
		arParams(20) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_Saldo
        End If
		arParams(21) = New SqlParameter("@observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_observaciones) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_observaciones
        End If
		arParams(22) = New SqlParameter("@SolicAutorDescuento", SqlDbType.Bit)		
		If IsDBNull(m_SolicAutorDescuento) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_SolicAutorDescuento
        End If
		arParams(23) = New SqlParameter("@SolicitudDescuento", SqlDbType.VarChar)		
		If IsDBNull(m_SolicitudDescuento) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_SolicitudDescuento
        End If
		arParams(24) = New SqlParameter("@DescuentoAutorizado", SqlDbType.Decimal)		
		If IsDBNull(m_DescuentoAutorizado) Then
            arParams(24).Value = DBNull.Value
        Else
            arParams(24).Value = m_DescuentoAutorizado
        End If
		arParams(25) = New SqlParameter("@AutorizaDescuento", SqlDbType.Bit)		
		If IsDBNull(m_AutorizaDescuento) Then
            arParams(25).Value = DBNull.Value
        Else
            arParams(25).Value = m_AutorizaDescuento
        End If
		arParams(26) = New SqlParameter("@NumeroReciboCancelacion", SqlDbType.VarChar)		
		If IsDBNull(m_NumeroReciboCancelacion) Then
            arParams(26).Value = DBNull.Value
        Else
            arParams(26).Value = m_NumeroReciboCancelacion
        End If
		arParams(27) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(27).Value = DBNull.Value
        Else
            arParams(27).Value = m_UsuarioCreacion
        End If
		arParams(28) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(28).Value = DBNull.Value
        Else
            arParams(28).Value = m_FechaCreacion
        End If
		arParams(29) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(29).Value = DBNull.Value
        Else
            arParams(29).Value = m_UsuarioModificacion
        End If
		arParams(30) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(30).Value = DBNull.Value
        Else
            arParams(30).Value = m_FechaModificacion
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
    ''' Borra un objeto SfaFacturaRepuesto de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturaRepuesto where " & " SfaFacturaRepuestoID = " & m_SfaFacturaRepuestoID
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
    ''' Borra un objeto SfaFacturaRepuesto de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SfaFacturaRepuestoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturaRepuesto where " & " SfaFacturaRepuestoID = " & p_SfaFacturaRepuestoID
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
    ''' Borra objetos SfaFacturaRepuesto de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturaRepuesto where " & pWhere
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
