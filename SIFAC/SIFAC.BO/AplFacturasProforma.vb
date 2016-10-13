Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class AplFacturasProforma		

#Region " Variables Miembro " 
	Protected m_SfaFacturaProformaID As Integer 
	Protected m_objSccClienteID As Nullable(Of Integer) 
	Protected m_objVendedorID As Nullable(Of Integer) 
	Protected m_objEstadoID As Integer 
	Protected m_objTerminoPagoID As Integer 
	Protected m_objModalidadPagoID As Integer 
	Protected m_objDescuentoID As Nullable(Of Integer) 
	Protected m_objRutaID As Nullable(Of Integer) 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_Fecha As Date 
	Protected m_FechaVencimiento As Nullable(Of Date) 
	Protected m_Subtotal As Decimal 
	Protected m_Descuento As Decimal 
	Protected m_Total As Decimal 
	Protected m_Prima As Nullable(Of Decimal) 
	Protected m_Saldo As Nullable(Of Decimal) 
	Protected m_observaciones As String = Nothing 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SfaFacturaProformaID() As Integer
        Get
            Return (m_SfaFacturaProformaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SfaFacturaProformaID = Value
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
	
	Public Property objModalidadPagoID() As Integer
        Get
            Return (m_objModalidadPagoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objModalidadPagoID = Value
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
	
	Public Property objRutaID() As Nullable(Of Integer)
        Get
            Return (m_objRutaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objRutaID = Value
		End Set
    End Property
	
	Public Property Activo() As Nullable(Of Boolean)
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Activo = Value
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
	
	Public Property FechaVencimiento() As Nullable(Of Date)
        Get
            Return (m_FechaVencimiento)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaVencimiento = Value
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
	
	Public Property Total() As Decimal
        Get
            Return (m_Total)
        End Get
		Set(ByVal Value As Decimal)					
			m_Total = Value
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
					Throw New ArgumentOutOfRangeException("observaciones", Value.ToString(), "Valor inv?lido para AplFacturasProforma.observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para AplFacturasProforma.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para AplFacturasProforma.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
			Case "Subtotal"
				Return	11
			Case "Descuento"
				Return	11
			Case "Total"
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
			Case "Total"
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
    ''' Salva un DataSet del tipo de la tabla AplFacturasProforma en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla AplFacturasProforma </param>    
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
			cmdDelete.Parameters.Add("@SfaFacturaProformaID", SqlDbType.Int, 4, "SfaFacturaProformaID" )
			cmdDelete.CommandText = "DELETE FROM  AplFacturasProforma WHERE SfaFacturaProformaID= @SfaFacturaProformaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSccClienteID", SqlDbType.Int, 4, "objSccClienteID")
			cmdInsert.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objTerminoPagoID", SqlDbType.Int, 4, "objTerminoPagoID")
			cmdInsert.Parameters.Add("@objModalidadPagoID", SqlDbType.Int, 4, "objModalidadPagoID")
			cmdInsert.Parameters.Add("@objDescuentoID", SqlDbType.Int, 4, "objDescuentoID")
			cmdInsert.Parameters.Add("@objRutaID", SqlDbType.Int, 4, "objRutaID")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime, 8, "FechaVencimiento")
			cmdInsert.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdInsert.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdInsert.Parameters.Add("@Total", SqlDbType.Decimal, 9, "Total")
			cmdInsert.Parameters.Add("@Prima", SqlDbType.Decimal, 9, "Prima")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@observaciones", SqlDbType.VarChar, 100, "observaciones")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO AplFacturasProforma ( objSccClienteID, objVendedorID, objEstadoID, objTerminoPagoID, objModalidadPagoID, objDescuentoID, objRutaID, Activo, Fecha, FechaVencimiento, Subtotal, Descuento, Total, Prima, Saldo, observaciones, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objSccClienteID, @objVendedorID, @objEstadoID, @objTerminoPagoID, @objModalidadPagoID, @objDescuentoID, @objRutaID, @Activo, @Fecha, @FechaVencimiento, @Subtotal, @Descuento, @Total, @Prima, @Saldo, @observaciones, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSccClienteID", SqlDbType.Int, 4, "objSccClienteID")
			cmdUpdate.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objTerminoPagoID", SqlDbType.Int, 4, "objTerminoPagoID")
			cmdUpdate.Parameters.Add("@objModalidadPagoID", SqlDbType.Int, 4, "objModalidadPagoID")
			cmdUpdate.Parameters.Add("@objDescuentoID", SqlDbType.Int, 4, "objDescuentoID")
			cmdUpdate.Parameters.Add("@objRutaID", SqlDbType.Int, 4, "objRutaID")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime, 8, "FechaVencimiento")
			cmdUpdate.Parameters.Add("@Subtotal", SqlDbType.Decimal, 9, "Subtotal")
			cmdUpdate.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdUpdate.Parameters.Add("@Total", SqlDbType.Decimal, 9, "Total")
			cmdUpdate.Parameters.Add("@Prima", SqlDbType.Decimal, 9, "Prima")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@observaciones", SqlDbType.VarChar, 100, "observaciones")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSfaFacturaProformaID", SqlDbType.Int, 4, "SfaFacturaProformaID")
			cmdUpdate.CommandText = "UPDATE AplFacturasProforma SET objSccClienteID=@objSccClienteID, objVendedorID=@objVendedorID, objEstadoID=@objEstadoID, objTerminoPagoID=@objTerminoPagoID, objModalidadPagoID=@objModalidadPagoID, objDescuentoID=@objDescuentoID, objRutaID=@objRutaID, Activo=@Activo, Fecha=@Fecha, FechaVencimiento=@FechaVencimiento, Subtotal=@Subtotal, Descuento=@Descuento, Total=@Total, Prima=@Prima, Saldo=@Saldo, observaciones=@observaciones, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SfaFacturaProformaID= @wSfaFacturaProformaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "AplFacturasProforma")
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
    ''' Devuelve de la base de datos un objeto AplFacturasProforma
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SfaFacturaProformaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from AplFacturasProforma where " & " SfaFacturaProformaID = " & p_SfaFacturaProformaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SfaFacturaProformaID = dr("SfaFacturaProformaID")
				m_objSccClienteID = IIf(IsDBNull(dr("objSccClienteID")), Nothing, dr("objSccClienteID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objTerminoPagoID = IIf(IsDBNull(dr("objTerminoPagoID")), Nothing, dr("objTerminoPagoID"))					
				m_objModalidadPagoID = IIf(IsDBNull(dr("objModalidadPagoID")), Nothing, dr("objModalidadPagoID"))					
				m_objDescuentoID = IIf(IsDBNull(dr("objDescuentoID")), Nothing, dr("objDescuentoID"))					
				m_objRutaID = IIf(IsDBNull(dr("objRutaID")), Nothing, dr("objRutaID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_FechaVencimiento = IIf(IsDBNull(dr("FechaVencimiento")), Nothing, dr("FechaVencimiento"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Total = IIf(IsDBNull(dr("Total")), Nothing, dr("Total"))					
				m_Prima = IIf(IsDBNull(dr("Prima")), Nothing, dr("Prima"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_observaciones = IIf(IsDBNull(dr("observaciones")), Nothing, dr("observaciones"))					
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
    ''' Devuelve de la base de datos un objeto AplFacturasProforma usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from AplFacturasProforma where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SfaFacturaProformaID = dr("SfaFacturaProformaID")
				m_objSccClienteID = IIf(IsDBNull(dr("objSccClienteID")), Nothing, dr("objSccClienteID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_objTerminoPagoID = IIf(IsDBNull(dr("objTerminoPagoID")), Nothing, dr("objTerminoPagoID"))					
				m_objModalidadPagoID = IIf(IsDBNull(dr("objModalidadPagoID")), Nothing, dr("objModalidadPagoID"))					
				m_objDescuentoID = IIf(IsDBNull(dr("objDescuentoID")), Nothing, dr("objDescuentoID"))					
				m_objRutaID = IIf(IsDBNull(dr("objRutaID")), Nothing, dr("objRutaID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_FechaVencimiento = IIf(IsDBNull(dr("FechaVencimiento")), Nothing, dr("FechaVencimiento"))					
				m_Subtotal = IIf(IsDBNull(dr("Subtotal")), Nothing, dr("Subtotal"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_Total = IIf(IsDBNull(dr("Total")), Nothing, dr("Total"))					
				m_Prima = IIf(IsDBNull(dr("Prima")), Nothing, dr("Prima"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_observaciones = IIf(IsDBNull(dr("observaciones")), Nothing, dr("observaciones"))					
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
    ''' Trae de la base de datos un conjunto de objetos AplFacturasProforma en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from AplFacturasProforma"

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
			ds.Tables(0).TableName = "AplFacturasProforma"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos AplFacturasProforma en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from AplFacturasProforma"

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
			ds.Tables(0).TableName = "AplFacturasProforma"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos AplFacturasProforma en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from AplFacturasProforma"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase AplFacturasProforma.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into AplFacturasProforma("
		sCommand &= "objSccClienteID,"
		sCommand &= "objVendedorID,"
		sCommand &= "objEstadoID,"
		sCommand &= "objTerminoPagoID,"
		sCommand &= "objModalidadPagoID,"
		sCommand &= "objDescuentoID,"
		sCommand &= "objRutaID,"
		sCommand &= "Activo,"
		sCommand &= "Fecha,"
		sCommand &= "FechaVencimiento,"
		sCommand &= "Subtotal,"
		sCommand &= "Descuento,"
		sCommand &= "Total,"
		sCommand &= "Prima,"
		sCommand &= "Saldo,"
		sCommand &= "observaciones,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objSccClienteID,"
		sCommand &= "@objVendedorID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@objTerminoPagoID,"
		sCommand &= "@objModalidadPagoID,"
		sCommand &= "@objDescuentoID,"
		sCommand &= "@objRutaID,"
		sCommand &= "@Activo,"
		sCommand &= "@Fecha,"
		sCommand &= "@FechaVencimiento,"
		sCommand &= "@Subtotal,"
		sCommand &= "@Descuento,"
		sCommand &= "@Total,"
		sCommand &= "@Prima,"
		sCommand &= "@Saldo,"
		sCommand &= "@observaciones,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SfaFacturaProformaID = SfaFacturaProformaID from AplFacturasProforma where "		
		sCommand &= "SfaFacturaProformaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(20) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaProformaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSccClienteID", SqlDbType.Int)		
		If IsDBNull(m_objSccClienteID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccClienteID
        End If
		arParams(2) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objVendedorID
        End If
		arParams(3) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objEstadoID
        End If
		arParams(4) = New SqlParameter("@objTerminoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTerminoPagoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objTerminoPagoID
        End If
		arParams(5) = New SqlParameter("@objModalidadPagoID", SqlDbType.Int)		
		If IsDBNull(m_objModalidadPagoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objModalidadPagoID
        End If
		arParams(6) = New SqlParameter("@objDescuentoID", SqlDbType.Int)		
		If IsDBNull(m_objDescuentoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objDescuentoID
        End If
		arParams(7) = New SqlParameter("@objRutaID", SqlDbType.Int)		
		If IsDBNull(m_objRutaID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objRutaID
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
		arParams(9) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Fecha
        End If
		arParams(10) = New SqlParameter("@FechaVencimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaVencimiento) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaVencimiento
        End If
		arParams(11) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Subtotal
        End If
		arParams(12) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Descuento
        End If
		arParams(13) = New SqlParameter("@Total", SqlDbType.Decimal)		
		If IsDBNull(m_Total) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Total
        End If
		arParams(14) = New SqlParameter("@Prima", SqlDbType.Decimal)		
		If IsDBNull(m_Prima) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Prima
        End If
		arParams(15) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Saldo
        End If
		arParams(16) = New SqlParameter("@observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_observaciones) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_observaciones
        End If
		arParams(17) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioCreacion
        End If
		arParams(18) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaCreacion
        End If
		arParams(19) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioModificacion
        End If
		arParams(20) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SfaFacturaProformaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto AplFacturasProforma en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update AplFacturasProforma set "		
		sCommand &= "objSccClienteID = @objSccClienteID,"
		sCommand &= "objVendedorID = @objVendedorID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objTerminoPagoID = @objTerminoPagoID,"
		sCommand &= "objModalidadPagoID = @objModalidadPagoID,"
		sCommand &= "objDescuentoID = @objDescuentoID,"
		sCommand &= "objRutaID = @objRutaID,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "FechaVencimiento = @FechaVencimiento,"
		sCommand &= "Subtotal = @Subtotal,"
		sCommand &= "Descuento = @Descuento,"
		sCommand &= "Total = @Total,"
		sCommand &= "Prima = @Prima,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "observaciones = @observaciones,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SfaFacturaProformaID = @SfaFacturaProformaID"					
		
		Dim arParams(20) As SqlParameter
		arParams(0) = New SqlParameter("@SfaFacturaProformaID", SqlDbType.Int)		
		If IsDBNull(m_SfaFacturaProformaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SfaFacturaProformaID
        End If
		arParams(1) = New SqlParameter("@objSccClienteID", SqlDbType.Int)		
		If IsDBNull(m_objSccClienteID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccClienteID
        End If
		arParams(2) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objVendedorID
        End If
		arParams(3) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objEstadoID
        End If
		arParams(4) = New SqlParameter("@objTerminoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTerminoPagoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objTerminoPagoID
        End If
		arParams(5) = New SqlParameter("@objModalidadPagoID", SqlDbType.Int)		
		If IsDBNull(m_objModalidadPagoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objModalidadPagoID
        End If
		arParams(6) = New SqlParameter("@objDescuentoID", SqlDbType.Int)		
		If IsDBNull(m_objDescuentoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objDescuentoID
        End If
		arParams(7) = New SqlParameter("@objRutaID", SqlDbType.Int)		
		If IsDBNull(m_objRutaID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objRutaID
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
		arParams(9) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Fecha
        End If
		arParams(10) = New SqlParameter("@FechaVencimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaVencimiento) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaVencimiento
        End If
		arParams(11) = New SqlParameter("@Subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_Subtotal) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Subtotal
        End If
		arParams(12) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Descuento
        End If
		arParams(13) = New SqlParameter("@Total", SqlDbType.Decimal)		
		If IsDBNull(m_Total) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Total
        End If
		arParams(14) = New SqlParameter("@Prima", SqlDbType.Decimal)		
		If IsDBNull(m_Prima) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Prima
        End If
		arParams(15) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Saldo
        End If
		arParams(16) = New SqlParameter("@observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_observaciones) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_observaciones
        End If
		arParams(17) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioCreacion
        End If
		arParams(18) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaCreacion
        End If
		arParams(19) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioModificacion
        End If
		arParams(20) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaModificacion
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
    ''' Borra un objeto AplFacturasProforma de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplFacturasProforma where " & " SfaFacturaProformaID = " & m_SfaFacturaProformaID
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
    ''' Borra un objeto AplFacturasProforma de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SfaFacturaProformaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplFacturasProforma where " & " SfaFacturaProformaID = " & p_SfaFacturaProformaID
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
    ''' Borra objetos AplFacturasProforma de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplFacturasProforma where " & pWhere
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
