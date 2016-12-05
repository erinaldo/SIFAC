Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SfaFacturas		

#Region " Variables Miembro " 
	Protected m_SfaFacturaID As Integer 
	Protected m_Numero As Nullable(Of Integer) 
	Protected m_Fecha As Date 
	Protected m_objSccClienteID As Nullable(Of Integer) 
	Protected m_objVendedorID As Nullable(Of Integer) 
	Protected m_objEstadoID As Integer 
	Protected m_objTerminoPagoID As Integer 
	Protected m_objMotivoAnularID As Nullable(Of Integer) 
	Protected m_objDescuentoID As Nullable(Of Integer) 
	Protected m_AtencionA As String = Nothing 
	Protected m_Subtotal As Decimal 
	Protected m_Descuento As Decimal 
	Protected m_Impuesto As Decimal 
	Protected m_TotalCordobas As Decimal 
	Protected m_TotalDolares As Decimal 
	Protected m_TasaCambio As Decimal 
	Protected m_Prima As Nullable(Of Decimal) 
	Protected m_Saldo As Nullable(Of Decimal) 
	Protected m_observaciones As String = Nothing 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_objStbBodegaID As Nullable(Of Integer) 
	Protected m_objCajaID As Nullable(Of Integer) 
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
	
	Public Property Numero() As Nullable(Of Integer)
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
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
	
	Public Property objSccClienteID() As Nullable(Of Integer)
        Get
            Return (m_objSccClienteID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccClienteID = Value
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
	
	Public Property objDescuentoID() As Nullable(Of Integer)
        Get
            Return (m_objDescuentoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objDescuentoID = Value
		End Set
    End Property
	
	Public Property AtencionA() As String
        Get
            Return (m_AtencionA)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 120 Then
					Throw New ArgumentOutOfRangeException("AtencionA", Value.ToString(), "Valor inv?lido para SfaFacturas.AtencionA. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (120).")
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
					Throw New ArgumentOutOfRangeException("observaciones", Value.ToString(), "Valor inv?lido para SfaFacturas.observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_observaciones = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SfaFacturas.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SfaFacturas.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	
	Public Property objStbBodegaID() As Nullable(Of Integer)
        Get
            Return (m_objStbBodegaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objStbBodegaID = Value
		End Set
    End Property
	
	Public Property objCajaID() As Nullable(Of Integer)
        Get
            Return (m_objCajaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajaID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
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
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SfaFacturas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SfaFacturas </param>    
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
			cmdDelete.CommandText = "DELETE FROM  SfaFacturas WHERE SfaFacturaID= @SfaFacturaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Numero", SqlDbType.Int, 4, "Numero")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@objSccClienteID", SqlDbType.Int, 4, "objSccClienteID")
			cmdInsert.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objTerminoPagoID", SqlDbType.Int, 4, "objTerminoPagoID")
			cmdInsert.Parameters.Add("@objMotivoAnularID", SqlDbType.Int, 4, "objMotivoAnularID")
			cmdInsert.Parameters.Add("@objDescuentoID", SqlDbType.Int, 4, "objDescuentoID")
			cmdInsert.Parameters.Add("@AtencionA", SqlDbType.VarChar, 120, "AtencionA")
			cmdInsert.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdInsert.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdInsert.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdInsert.Parameters.Add("@TotalCordobas", SqlDbType.Decimal, 9, "TotalCordobas")
			cmdInsert.Parameters.Add("@TotalDolares", SqlDbType.Decimal, 9, "TotalDolares")
			cmdInsert.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdInsert.Parameters.Add("@Prima", SqlDbType.Decimal, 9, "Prima")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@observaciones", SqlDbType.VarChar, 100, "observaciones")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@objStbBodegaID", SqlDbType.Int, 4, "objStbBodegaID")
			cmdInsert.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdInsert.CommandText = "INSERT INTO SfaFacturas ( Numero, Fecha, objSccClienteID, objVendedorID, objEstadoID, objTerminoPagoID, objMotivoAnularID, objDescuentoID, AtencionA, Subtotal, Descuento, Impuesto, TotalCordobas, TotalDolares, TasaCambio, Prima, Saldo, observaciones, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, objStbBodegaID, objCajaID) VALUES ( @Numero, @Fecha, @objSccClienteID, @objVendedorID, @objEstadoID, @objTerminoPagoID, @objMotivoAnularID, @objDescuentoID, @AtencionA, @Subtotal, @Descuento, @Impuesto, @TotalCordobas, @TotalDolares, @TasaCambio, @Prima, @Saldo, @observaciones, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @objStbBodegaID, @objCajaID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.Int, 4, "Numero")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@objSccClienteID", SqlDbType.Int, 4, "objSccClienteID")
			cmdUpdate.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objTerminoPagoID", SqlDbType.Int, 4, "objTerminoPagoID")
			cmdUpdate.Parameters.Add("@objMotivoAnularID", SqlDbType.Int, 4, "objMotivoAnularID")
			cmdUpdate.Parameters.Add("@objDescuentoID", SqlDbType.Int, 4, "objDescuentoID")
			cmdUpdate.Parameters.Add("@AtencionA", SqlDbType.VarChar, 120, "AtencionA")
			cmdUpdate.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdUpdate.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdUpdate.Parameters.Add("@Impuesto", SqlDbType.Decimal, 9, "Impuesto")
			cmdUpdate.Parameters.Add("@TotalCordobas", SqlDbType.Decimal, 9, "TotalCordobas")
			cmdUpdate.Parameters.Add("@TotalDolares", SqlDbType.Decimal, 9, "TotalDolares")
			cmdUpdate.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdUpdate.Parameters.Add("@Prima", SqlDbType.Decimal, 9, "Prima")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@observaciones", SqlDbType.VarChar, 100, "observaciones")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@objStbBodegaID", SqlDbType.Int, 4, "objStbBodegaID")
			cmdUpdate.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdUpdate.Parameters.Add("@wSfaFacturaID", SqlDbType.Int, 4, "SfaFacturaID")
			cmdUpdate.CommandText = "UPDATE SfaFacturas SET Numero=@Numero, Fecha=@Fecha, objSccClienteID=@objSccClienteID, objVendedorID=@objVendedorID, objEstadoID=@objEstadoID, objTerminoPagoID=@objTerminoPagoID, objMotivoAnularID=@objMotivoAnularID, objDescuentoID=@objDescuentoID, AtencionA=@AtencionA, Subtotal=@Subtotal, Descuento=@Descuento, Impuesto=@Impuesto, TotalCordobas=@TotalCordobas, TotalDolares=@TotalDolares, TasaCambio=@TasaCambio, Prima=@Prima, Saldo=@Saldo, observaciones=@observaciones, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, objStbBodegaID=@objStbBodegaID, objCajaID=@objCajaID WHERE SfaFacturaID= @wSfaFacturaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SfaFacturas")
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
    ''' Devuelve de la base de datos un objeto SfaFacturas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SfaFacturaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaFacturas where " & " SfaFacturaID = " & p_SfaFacturaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SfaFacturaID = dr("SfaFacturaID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_objSccClienteID = IIf(IsDBNull(dr("objSccClienteID")), Nothing, dr("objSccClienteID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objTerminoPagoID = IIf(IsDBNull(dr("objTerminoPagoID")), Nothing, dr("objTerminoPagoID"))					
				m_objMotivoAnularID = IIf(IsDBNull(dr("objMotivoAnularID")), Nothing, dr("objMotivoAnularID"))					
				m_objDescuentoID = IIf(IsDBNull(dr("objDescuentoID")), Nothing, dr("objDescuentoID"))					
				m_AtencionA = IIf(IsDBNull(dr("AtencionA")), Nothing, dr("AtencionA"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_TotalCordobas = IIf(IsDBNull(dr("TotalCordobas")), Nothing, dr("TotalCordobas"))					
				m_TotalDolares = IIf(IsDBNull(dr("TotalDolares")), Nothing, dr("TotalDolares"))					
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))					
				m_Prima = IIf(IsDBNull(dr("Prima")), Nothing, dr("Prima"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_observaciones = IIf(IsDBNull(dr("observaciones")), Nothing, dr("observaciones"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objStbBodegaID = IIf(IsDBNull(dr("objStbBodegaID")), Nothing, dr("objStbBodegaID"))					
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))					
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
    ''' Devuelve de la base de datos un objeto SfaFacturas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaFacturas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SfaFacturaID = dr("SfaFacturaID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_objSccClienteID = IIf(IsDBNull(dr("objSccClienteID")), Nothing, dr("objSccClienteID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objTerminoPagoID = IIf(IsDBNull(dr("objTerminoPagoID")), Nothing, dr("objTerminoPagoID"))					
				m_objMotivoAnularID = IIf(IsDBNull(dr("objMotivoAnularID")), Nothing, dr("objMotivoAnularID"))					
				m_objDescuentoID = IIf(IsDBNull(dr("objDescuentoID")), Nothing, dr("objDescuentoID"))					
				m_AtencionA = IIf(IsDBNull(dr("AtencionA")), Nothing, dr("AtencionA"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Impuesto = IIf(IsDBNull(dr("Impuesto")), Nothing, dr("Impuesto"))					
				m_TotalCordobas = IIf(IsDBNull(dr("TotalCordobas")), Nothing, dr("TotalCordobas"))					
				m_TotalDolares = IIf(IsDBNull(dr("TotalDolares")), Nothing, dr("TotalDolares"))					
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))					
				m_Prima = IIf(IsDBNull(dr("Prima")), Nothing, dr("Prima"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_observaciones = IIf(IsDBNull(dr("observaciones")), Nothing, dr("observaciones"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objStbBodegaID = IIf(IsDBNull(dr("objStbBodegaID")), Nothing, dr("objStbBodegaID"))					
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))					
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
    ''' Trae de la base de datos un conjunto de objetos SfaFacturas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SfaFacturas"

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
			ds.Tables(0).TableName = "SfaFacturas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaFacturas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SfaFacturas"

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
			ds.Tables(0).TableName = "SfaFacturas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaFacturas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SfaFacturas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SfaFacturas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SfaFacturas("
		sCommand &= "Numero,"
		sCommand &= "Fecha,"
		sCommand &= "objSccClienteID,"
		sCommand &= "objVendedorID,"
		sCommand &= "objEstadoID,"
		sCommand &= "objTerminoPagoID,"
		sCommand &= "objMotivoAnularID,"
		sCommand &= "objDescuentoID,"
		sCommand &= "AtencionA,"
		sCommand &= "Subtotal,"
		sCommand &= "Descuento,"
		sCommand &= "Impuesto,"
		sCommand &= "TotalCordobas,"
		sCommand &= "TotalDolares,"
		sCommand &= "TasaCambio,"
		sCommand &= "Prima,"
		sCommand &= "Saldo,"
		sCommand &= "observaciones,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "objStbBodegaID,"
		sCommand &= "objCajaID) values ("		
		sCommand &= "@Numero,"
		sCommand &= "@Fecha,"
		sCommand &= "@objSccClienteID,"
		sCommand &= "@objVendedorID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@objTerminoPagoID,"
		sCommand &= "@objMotivoAnularID,"
		sCommand &= "@objDescuentoID,"
		sCommand &= "@AtencionA,"
		sCommand &= "@Subtotal,"
		sCommand &= "@Descuento,"
		sCommand &= "@Impuesto,"
		sCommand &= "@TotalCordobas,"
		sCommand &= "@TotalDolares,"
		sCommand &= "@TasaCambio,"
		sCommand &= "@Prima,"
		sCommand &= "@Saldo,"
		sCommand &= "@observaciones,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@objStbBodegaID,"
		sCommand &= "@objCajaID)"		
	
		sCommand &= " select "
		sCommand &= "@SfaFacturaID = SfaFacturaID from SfaFacturas where "		
		sCommand &= "SfaFacturaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(24) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaID", SqlDbType.Int)		
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
		arParams(3) = New SqlParameter("@objSccClienteID", SqlDbType.Int)		
		If IsDBNull(m_objSccClienteID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objSccClienteID
        End If
		arParams(4) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objVendedorID
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@objTerminoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTerminoPagoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objTerminoPagoID
        End If
		arParams(7) = New SqlParameter("@objMotivoAnularID", SqlDbType.Int)		
		If IsDBNull(m_objMotivoAnularID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objMotivoAnularID
        End If
		arParams(8) = New SqlParameter("@objDescuentoID", SqlDbType.Int)		
		If IsDBNull(m_objDescuentoID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objDescuentoID
        End If
		arParams(9) = New SqlParameter("@AtencionA", SqlDbType.VarChar)		
		If IsDBNull(m_AtencionA) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_AtencionA
        End If
		arParams(10) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Subtotal
        End If
		arParams(11) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Descuento
        End If
		arParams(12) = New SqlParameter("@Impuesto", SqlDbType.Decimal)		
		If IsDBNull(m_Impuesto) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Impuesto
        End If
		arParams(13) = New SqlParameter("@TotalCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalCordobas) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_TotalCordobas
        End If
		arParams(14) = New SqlParameter("@TotalDolares", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDolares) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_TotalDolares
        End If
		arParams(15) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_TasaCambio
        End If
		arParams(16) = New SqlParameter("@Prima", SqlDbType.Decimal)		
		If IsDBNull(m_Prima) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Prima
        End If
		arParams(17) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Saldo
        End If
		arParams(18) = New SqlParameter("@observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_observaciones) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_observaciones
        End If
		arParams(19) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioCreacion
        End If
		arParams(20) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaCreacion
        End If
		arParams(21) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_UsuarioModificacion
        End If
		arParams(22) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_FechaModificacion
        End If
		arParams(23) = New SqlParameter("@objStbBodegaID", SqlDbType.Int)		
		If IsDBNull(m_objStbBodegaID) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_objStbBodegaID
        End If
		arParams(24) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(24).Value = DBNull.Value
        Else
            arParams(24).Value = m_objCajaID
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
    ''' 	Actualiza el objeto SfaFacturas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SfaFacturas set "		
		sCommand &= "Numero = @Numero,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "objSccClienteID = @objSccClienteID,"
		sCommand &= "objVendedorID = @objVendedorID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objTerminoPagoID = @objTerminoPagoID,"
		sCommand &= "objMotivoAnularID = @objMotivoAnularID,"
		sCommand &= "objDescuentoID = @objDescuentoID,"
		sCommand &= "AtencionA = @AtencionA,"
		sCommand &= "Subtotal = @Subtotal,"
		sCommand &= "Descuento = @Descuento,"
		sCommand &= "Impuesto = @Impuesto,"
		sCommand &= "TotalCordobas = @TotalCordobas,"
		sCommand &= "TotalDolares = @TotalDolares,"
		sCommand &= "TasaCambio = @TasaCambio,"
		sCommand &= "Prima = @Prima,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "observaciones = @observaciones,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "objStbBodegaID = @objStbBodegaID,"
		sCommand &= "objCajaID = @objCajaID"		
		sCommand &= " where "	
		sCommand &= "SfaFacturaID = @SfaFacturaID"					
		
		Dim arParams(24) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaID", SqlDbType.Int)		
		If IsDBNull(m_SfaFacturaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SfaFacturaID
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
		arParams(3) = New SqlParameter("@objSccClienteID", SqlDbType.Int)		
		If IsDBNull(m_objSccClienteID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objSccClienteID
        End If
		arParams(4) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objVendedorID
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@objTerminoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTerminoPagoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objTerminoPagoID
        End If
		arParams(7) = New SqlParameter("@objMotivoAnularID", SqlDbType.Int)		
		If IsDBNull(m_objMotivoAnularID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objMotivoAnularID
        End If
		arParams(8) = New SqlParameter("@objDescuentoID", SqlDbType.Int)		
		If IsDBNull(m_objDescuentoID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objDescuentoID
        End If
		arParams(9) = New SqlParameter("@AtencionA", SqlDbType.VarChar)		
		If IsDBNull(m_AtencionA) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_AtencionA
        End If
		arParams(10) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Subtotal
        End If
		arParams(11) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Descuento
        End If
		arParams(12) = New SqlParameter("@Impuesto", SqlDbType.Decimal)		
		If IsDBNull(m_Impuesto) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Impuesto
        End If
		arParams(13) = New SqlParameter("@TotalCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalCordobas) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_TotalCordobas
        End If
		arParams(14) = New SqlParameter("@TotalDolares", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDolares) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_TotalDolares
        End If
		arParams(15) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_TasaCambio
        End If
		arParams(16) = New SqlParameter("@Prima", SqlDbType.Decimal)		
		If IsDBNull(m_Prima) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Prima
        End If
		arParams(17) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Saldo
        End If
		arParams(18) = New SqlParameter("@observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_observaciones) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_observaciones
        End If
		arParams(19) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioCreacion
        End If
		arParams(20) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaCreacion
        End If
		arParams(21) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_UsuarioModificacion
        End If
		arParams(22) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_FechaModificacion
        End If
		arParams(23) = New SqlParameter("@objStbBodegaID", SqlDbType.Int)		
		If IsDBNull(m_objStbBodegaID) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_objStbBodegaID
        End If
		arParams(24) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(24).Value = DBNull.Value
        Else
            arParams(24).Value = m_objCajaID
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
    ''' Borra un objeto SfaFacturas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturas where " & " SfaFacturaID = " & m_SfaFacturaID
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
    ''' Borra un objeto SfaFacturas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SfaFacturaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturas where " & " SfaFacturaID = " & p_SfaFacturaID
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
    ''' Borra objetos SfaFacturas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaFacturas where " & pWhere
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
