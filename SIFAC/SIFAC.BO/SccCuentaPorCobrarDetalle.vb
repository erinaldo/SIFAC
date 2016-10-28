Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccCuentaPorCobrarDetalle		

#Region " Variables Miembro " 
	Protected m_SccCuentaPorCobrarDetalleID As Integer 
	Protected m_objSccCuentaID As Integer 
	Protected m_objSfaFacturaID As Nullable(Of Integer) 
	Protected m_objTeminoPlazoID As Nullable(Of Integer) 
	Protected m_objModalidadPago As Nullable(Of Integer) 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_Saldo As Decimal 
	Protected m_MontoTotal As Decimal 
	Protected m_MontoPrima As Nullable(Of Decimal) 
	Protected m_MontoAbonado As Decimal 
	Protected m_MontoCuota As Decimal 
	Protected m_Descuento As Nullable(Of Decimal) 
	Protected m_FechaUltimoPago As Nullable(Of Date) 
	Protected m_FechaProximoPago As Nullable(Of Date) 
	Protected m_FechaVencimiento As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SccCuentaPorCobrarDetalleID() As Integer
        Get
            Return (m_SccCuentaPorCobrarDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccCuentaPorCobrarDetalleID = Value
		End Set
    End Property
	
	Public Property objSccCuentaID() As Integer
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objSccCuentaID = Value
		End Set
    End Property
	
	Public Property objSfaFacturaID() As Nullable(Of Integer)
        Get
            Return (m_objSfaFacturaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSfaFacturaID = Value
		End Set
    End Property
	
	Public Property objTeminoPlazoID() As Nullable(Of Integer)
        Get
            Return (m_objTeminoPlazoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objTeminoPlazoID = Value
		End Set
    End Property
	
	Public Property objModalidadPago() As Nullable(Of Integer)
        Get
            Return (m_objModalidadPago)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objModalidadPago = Value
		End Set
    End Property
	
	Public Property objEstadoID() As Nullable(Of Integer)
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEstadoID = Value
		End Set
    End Property
	
	Public Property Saldo() As Decimal
        Get
            Return (m_Saldo)
        End Get
		Set(ByVal Value As Decimal)					
			m_Saldo = Value
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
	
	Public Property MontoPrima() As Nullable(Of Decimal)
        Get
            Return (m_MontoPrima)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_MontoPrima = Value
		End Set
    End Property
	
	Public Property MontoAbonado() As Decimal
        Get
            Return (m_MontoAbonado)
        End Get
		Set(ByVal Value As Decimal)					
			m_MontoAbonado = Value
		End Set
    End Property
	
	Public Property MontoCuota() As Decimal
        Get
            Return (m_MontoCuota)
        End Get
		Set(ByVal Value As Decimal)					
			m_MontoCuota = Value
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
	
	Public Property FechaUltimoPago() As Nullable(Of Date)
        Get
            Return (m_FechaUltimoPago)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaUltimoPago = Value
		End Set
    End Property
	
	Public Property FechaProximoPago() As Nullable(Of Date)
        Get
            Return (m_FechaProximoPago)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaProximoPago = Value
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
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrarDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrarDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
			Case "Saldo"
				Return	11
			Case "MontoTotal"
				Return	11
			Case "MontoPrima"
				Return	11
			Case "MontoAbonado"
				Return	11
			Case "MontoCuota"
				Return	11
			Case "Descuento"
				Return	11
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Saldo"
				Return	2
			Case "MontoTotal"
				Return	2
			Case "MontoPrima"
				Return	2
			Case "MontoAbonado"
				Return	2
			Case "MontoCuota"
				Return	2
			Case "Descuento"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccCuentaPorCobrarDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccCuentaPorCobrarDetalle </param>    
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
			cmdDelete.Parameters.Add("@SccCuentaPorCobrarDetalleID", SqlDbType.Int, 4, "SccCuentaPorCobrarDetalleID" )
			cmdDelete.CommandText = "DELETE FROM  SccCuentaPorCobrarDetalle WHERE SccCuentaPorCobrarDetalleID= @SccCuentaPorCobrarDetalleID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdInsert.Parameters.Add("@objSfaFacturaID", SqlDbType.Int, 4, "objSfaFacturaID")
			cmdInsert.Parameters.Add("@objTeminoPlazoID", SqlDbType.Int, 4, "objTeminoPlazoID")
			cmdInsert.Parameters.Add("@objModalidadPago", SqlDbType.Int, 4, "objModalidadPago")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@MontoTotal", SqlDbType.Decimal, 9, "MontoTotal")
			cmdInsert.Parameters.Add("@MontoPrima", SqlDbType.Decimal, 9, "MontoPrima")
			cmdInsert.Parameters.Add("@MontoAbonado", SqlDbType.Decimal, 9, "MontoAbonado")
			cmdInsert.Parameters.Add("@MontoCuota", SqlDbType.Decimal, 9, "MontoCuota")
			cmdInsert.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdInsert.Parameters.Add("@FechaUltimoPago", SqlDbType.DateTime, 8, "FechaUltimoPago")
			cmdInsert.Parameters.Add("@FechaProximoPago", SqlDbType.DateTime, 8, "FechaProximoPago")
			cmdInsert.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime, 8, "FechaVencimiento")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SccCuentaPorCobrarDetalle ( objSccCuentaID, objSfaFacturaID, objTeminoPlazoID, objModalidadPago, objEstadoID, Saldo, MontoTotal, MontoPrima, MontoAbonado, MontoCuota, Descuento, FechaUltimoPago, FechaProximoPago, FechaVencimiento, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objSccCuentaID, @objSfaFacturaID, @objTeminoPlazoID, @objModalidadPago, @objEstadoID, @Saldo, @MontoTotal, @MontoPrima, @MontoAbonado, @MontoCuota, @Descuento, @FechaUltimoPago, @FechaProximoPago, @FechaVencimiento, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@objSfaFacturaID", SqlDbType.Int, 4, "objSfaFacturaID")
			cmdUpdate.Parameters.Add("@objTeminoPlazoID", SqlDbType.Int, 4, "objTeminoPlazoID")
			cmdUpdate.Parameters.Add("@objModalidadPago", SqlDbType.Int, 4, "objModalidadPago")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@MontoTotal", SqlDbType.Decimal, 9, "MontoTotal")
			cmdUpdate.Parameters.Add("@MontoPrima", SqlDbType.Decimal, 9, "MontoPrima")
			cmdUpdate.Parameters.Add("@MontoAbonado", SqlDbType.Decimal, 9, "MontoAbonado")
			cmdUpdate.Parameters.Add("@MontoCuota", SqlDbType.Decimal, 9, "MontoCuota")
			cmdUpdate.Parameters.Add("@Descuento", SqlDbType.Decimal, 9, "Descuento")
			cmdUpdate.Parameters.Add("@FechaUltimoPago", SqlDbType.DateTime, 8, "FechaUltimoPago")
			cmdUpdate.Parameters.Add("@FechaProximoPago", SqlDbType.DateTime, 8, "FechaProximoPago")
			cmdUpdate.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime, 8, "FechaVencimiento")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSccCuentaPorCobrarDetalleID", SqlDbType.Int, 4, "SccCuentaPorCobrarDetalleID")
			cmdUpdate.CommandText = "UPDATE SccCuentaPorCobrarDetalle SET objSccCuentaID=@objSccCuentaID, objSfaFacturaID=@objSfaFacturaID, objTeminoPlazoID=@objTeminoPlazoID, objModalidadPago=@objModalidadPago, objEstadoID=@objEstadoID, Saldo=@Saldo, MontoTotal=@MontoTotal, MontoPrima=@MontoPrima, MontoAbonado=@MontoAbonado, MontoCuota=@MontoCuota, Descuento=@Descuento, FechaUltimoPago=@FechaUltimoPago, FechaProximoPago=@FechaProximoPago, FechaVencimiento=@FechaVencimiento, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SccCuentaPorCobrarDetalleID= @wSccCuentaPorCobrarDetalleID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccCuentaPorCobrarDetalle")
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrarDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccCuentaPorCobrarDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrarDetalle where " & " SccCuentaPorCobrarDetalleID = " & p_SccCuentaPorCobrarDetalleID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccCuentaPorCobrarDetalleID = dr("SccCuentaPorCobrarDetalleID")
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objSfaFacturaID = IIf(IsDBNull(dr("objSfaFacturaID")), Nothing, dr("objSfaFacturaID"))					
				m_objTeminoPlazoID = IIf(IsDBNull(dr("objTeminoPlazoID")), Nothing, dr("objTeminoPlazoID"))					
				m_objModalidadPago = IIf(IsDBNull(dr("objModalidadPago")), Nothing, dr("objModalidadPago"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_MontoTotal = IIf(IsDBNull(dr("MontoTotal")), Nothing, dr("MontoTotal"))					
				m_MontoPrima = IIf(IsDBNull(dr("MontoPrima")), Nothing, dr("MontoPrima"))					
				m_MontoAbonado = IIf(IsDBNull(dr("MontoAbonado")), Nothing, dr("MontoAbonado"))					
				m_MontoCuota = IIf(IsDBNull(dr("MontoCuota")), Nothing, dr("MontoCuota"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_FechaUltimoPago = IIf(IsDBNull(dr("FechaUltimoPago")), Nothing, dr("FechaUltimoPago"))					
				m_FechaProximoPago = IIf(IsDBNull(dr("FechaProximoPago")), Nothing, dr("FechaProximoPago"))					
				m_FechaVencimiento = IIf(IsDBNull(dr("FechaVencimiento")), Nothing, dr("FechaVencimiento"))					
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrarDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrarDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccCuentaPorCobrarDetalleID = dr("SccCuentaPorCobrarDetalleID")
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objSfaFacturaID = IIf(IsDBNull(dr("objSfaFacturaID")), Nothing, dr("objSfaFacturaID"))					
				m_objTeminoPlazoID = IIf(IsDBNull(dr("objTeminoPlazoID")), Nothing, dr("objTeminoPlazoID"))					
				m_objModalidadPago = IIf(IsDBNull(dr("objModalidadPago")), Nothing, dr("objModalidadPago"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_MontoTotal = IIf(IsDBNull(dr("MontoTotal")), Nothing, dr("MontoTotal"))					
				m_MontoPrima = IIf(IsDBNull(dr("MontoPrima")), Nothing, dr("MontoPrima"))					
				m_MontoAbonado = IIf(IsDBNull(dr("MontoAbonado")), Nothing, dr("MontoAbonado"))					
				m_MontoCuota = IIf(IsDBNull(dr("MontoCuota")), Nothing, dr("MontoCuota"))					
				m_Descuento = IIf(IsDBNull(dr("Descuento")), Nothing, dr("Descuento"))					
				m_FechaUltimoPago = IIf(IsDBNull(dr("FechaUltimoPago")), Nothing, dr("FechaUltimoPago"))					
				m_FechaProximoPago = IIf(IsDBNull(dr("FechaProximoPago")), Nothing, dr("FechaProximoPago"))					
				m_FechaVencimiento = IIf(IsDBNull(dr("FechaVencimiento")), Nothing, dr("FechaVencimiento"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarDetalle"

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
			ds.Tables(0).TableName = "SccCuentaPorCobrarDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarDetalle"

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
			ds.Tables(0).TableName = "SccCuentaPorCobrarDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccCuentaPorCobrarDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccCuentaPorCobrarDetalle("
		sCommand &= "objSccCuentaID,"
		sCommand &= "objSfaFacturaID,"
		sCommand &= "objTeminoPlazoID,"
		sCommand &= "objModalidadPago,"
		sCommand &= "objEstadoID,"
		sCommand &= "Saldo,"
		sCommand &= "MontoTotal,"
		sCommand &= "MontoPrima,"
		sCommand &= "MontoAbonado,"
		sCommand &= "MontoCuota,"
		sCommand &= "Descuento,"
		sCommand &= "FechaUltimoPago,"
		sCommand &= "FechaProximoPago,"
		sCommand &= "FechaVencimiento,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@objSfaFacturaID,"
		sCommand &= "@objTeminoPlazoID,"
		sCommand &= "@objModalidadPago,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@Saldo,"
		sCommand &= "@MontoTotal,"
		sCommand &= "@MontoPrima,"
		sCommand &= "@MontoAbonado,"
		sCommand &= "@MontoCuota,"
		sCommand &= "@Descuento,"
		sCommand &= "@FechaUltimoPago,"
		sCommand &= "@FechaProximoPago,"
		sCommand &= "@FechaVencimiento,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SccCuentaPorCobrarDetalleID = SccCuentaPorCobrarDetalleID from SccCuentaPorCobrarDetalle where "		
		sCommand &= "SccCuentaPorCobrarDetalleID = SCOPE_IDENTITY()"
		
		
		Dim arParams(18) As SqlParameter
		arParams(0) = New SqlParameter("@SccCuentaPorCobrarDetalleID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccCuentaID
        End If
		arParams(2) = New SqlParameter("@objSfaFacturaID", SqlDbType.Int)		
		If IsDBNull(m_objSfaFacturaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSfaFacturaID
        End If
		arParams(3) = New SqlParameter("@objTeminoPlazoID", SqlDbType.Int)		
		If IsDBNull(m_objTeminoPlazoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objTeminoPlazoID
        End If
		arParams(4) = New SqlParameter("@objModalidadPago", SqlDbType.Int)		
		If IsDBNull(m_objModalidadPago) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objModalidadPago
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Saldo
        End If
		arParams(7) = New SqlParameter("@MontoTotal", SqlDbType.Decimal)		
		If IsDBNull(m_MontoTotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_MontoTotal
        End If
		arParams(8) = New SqlParameter("@MontoPrima", SqlDbType.Decimal)		
		If IsDBNull(m_MontoPrima) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_MontoPrima
        End If
		arParams(9) = New SqlParameter("@MontoAbonado", SqlDbType.Decimal)		
		If IsDBNull(m_MontoAbonado) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_MontoAbonado
        End If
		arParams(10) = New SqlParameter("@MontoCuota", SqlDbType.Decimal)		
		If IsDBNull(m_MontoCuota) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_MontoCuota
        End If
		arParams(11) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Descuento
        End If
		arParams(12) = New SqlParameter("@FechaUltimoPago", SqlDbType.DateTime)		
		If IsDBNull(m_FechaUltimoPago) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaUltimoPago
        End If
		arParams(13) = New SqlParameter("@FechaProximoPago", SqlDbType.DateTime)		
		If IsDBNull(m_FechaProximoPago) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaProximoPago
        End If
		arParams(14) = New SqlParameter("@FechaVencimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaVencimiento) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaVencimiento
        End If
		arParams(15) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioCreacion
        End If
		arParams(16) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaCreacion
        End If
		arParams(17) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioModificacion
        End If
		arParams(18) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccCuentaPorCobrarDetalleID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccCuentaPorCobrarDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccCuentaPorCobrarDetalle set "		
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "objSfaFacturaID = @objSfaFacturaID,"
		sCommand &= "objTeminoPlazoID = @objTeminoPlazoID,"
		sCommand &= "objModalidadPago = @objModalidadPago,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "MontoTotal = @MontoTotal,"
		sCommand &= "MontoPrima = @MontoPrima,"
		sCommand &= "MontoAbonado = @MontoAbonado,"
		sCommand &= "MontoCuota = @MontoCuota,"
		sCommand &= "Descuento = @Descuento,"
		sCommand &= "FechaUltimoPago = @FechaUltimoPago,"
		sCommand &= "FechaProximoPago = @FechaProximoPago,"
		sCommand &= "FechaVencimiento = @FechaVencimiento,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SccCuentaPorCobrarDetalleID = @SccCuentaPorCobrarDetalleID"					
		
		Dim arParams(18) As SqlParameter
		arParams(0) = New SqlParameter("@SccCuentaPorCobrarDetalleID", SqlDbType.Int)		
		If IsDBNull(m_SccCuentaPorCobrarDetalleID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccCuentaPorCobrarDetalleID
        End If
		arParams(1) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccCuentaID
        End If
		arParams(2) = New SqlParameter("@objSfaFacturaID", SqlDbType.Int)		
		If IsDBNull(m_objSfaFacturaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSfaFacturaID
        End If
		arParams(3) = New SqlParameter("@objTeminoPlazoID", SqlDbType.Int)		
		If IsDBNull(m_objTeminoPlazoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objTeminoPlazoID
        End If
		arParams(4) = New SqlParameter("@objModalidadPago", SqlDbType.Int)		
		If IsDBNull(m_objModalidadPago) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objModalidadPago
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Saldo
        End If
		arParams(7) = New SqlParameter("@MontoTotal", SqlDbType.Decimal)		
		If IsDBNull(m_MontoTotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_MontoTotal
        End If
		arParams(8) = New SqlParameter("@MontoPrima", SqlDbType.Decimal)		
		If IsDBNull(m_MontoPrima) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_MontoPrima
        End If
		arParams(9) = New SqlParameter("@MontoAbonado", SqlDbType.Decimal)		
		If IsDBNull(m_MontoAbonado) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_MontoAbonado
        End If
		arParams(10) = New SqlParameter("@MontoCuota", SqlDbType.Decimal)		
		If IsDBNull(m_MontoCuota) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_MontoCuota
        End If
		arParams(11) = New SqlParameter("@Descuento", SqlDbType.Decimal)		
		If IsDBNull(m_Descuento) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Descuento
        End If
		arParams(12) = New SqlParameter("@FechaUltimoPago", SqlDbType.DateTime)		
		If IsDBNull(m_FechaUltimoPago) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaUltimoPago
        End If
		arParams(13) = New SqlParameter("@FechaProximoPago", SqlDbType.DateTime)		
		If IsDBNull(m_FechaProximoPago) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaProximoPago
        End If
		arParams(14) = New SqlParameter("@FechaVencimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaVencimiento) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaVencimiento
        End If
		arParams(15) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioCreacion
        End If
		arParams(16) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaCreacion
        End If
		arParams(17) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioModificacion
        End If
		arParams(18) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaModificacion
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
    ''' Borra un objeto SccCuentaPorCobrarDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarDetalle where " & " SccCuentaPorCobrarDetalleID = " & m_SccCuentaPorCobrarDetalleID
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
    ''' Borra un objeto SccCuentaPorCobrarDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccCuentaPorCobrarDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarDetalle where " & " SccCuentaPorCobrarDetalleID = " & p_SccCuentaPorCobrarDetalleID
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
    ''' Borra objetos SccCuentaPorCobrarDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarDetalle where " & pWhere
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
