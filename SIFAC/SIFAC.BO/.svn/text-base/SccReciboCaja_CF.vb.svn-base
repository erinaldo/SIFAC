Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccReciboCaja		

#Region " Variables Miembro " 
	Protected m_SccReciboCajaID As Integer 
	Protected m_Numero As String = Nothing 
	Protected m_Fecha As Date 
	Protected m_TotalNC As Decimal 
	Protected m_TotalFacturas As Decimal 
	Protected m_TotalND As Decimal 
	Protected m_TotalEfectivo As Decimal 
	Protected m_TotalRecibo As Decimal 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_objTiendaID As Integer 
	Protected m_objSccCuentaID As String = Nothing 
	Protected m_objEstadoID As Integer 
	Protected m_EsPagoPrima As Boolean 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_SucursalPagoID As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property SccReciboCajaID() As Integer
        Get
            Return (m_SccReciboCajaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccReciboCajaID = Value
		End Set
    End Property
	
	Public Property Numero() As String
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 10 Then
					Throw New ArgumentOutOfRangeException("Numero", Value.ToString(), "Valor inv?lido para SccReciboCaja.Numero. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (10).")
				End If
			End If
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
	
	Public Property TotalNC() As Decimal
        Get
            Return (m_TotalNC)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalNC = Value
		End Set
    End Property
	
	Public Property TotalFacturas() As Decimal
        Get
            Return (m_TotalFacturas)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalFacturas = Value
		End Set
    End Property
	
	Public Property TotalND() As Decimal
        Get
            Return (m_TotalND)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalND = Value
		End Set
    End Property
	
	Public Property TotalEfectivo() As Decimal
        Get
            Return (m_TotalEfectivo)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalEfectivo = Value
		End Set
    End Property
	
	Public Property TotalRecibo() As Decimal
        Get
            Return (m_TotalRecibo)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalRecibo = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccReciboCaja.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccReciboCaja.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property objTiendaID() As Integer
        Get
            Return (m_objTiendaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTiendaID = Value
		End Set
    End Property
	
	Public Property objSccCuentaID() As String
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 15 Then
					Throw New ArgumentOutOfRangeException("objSccCuentaID", Value.ToString(), "Valor inv?lido para SccReciboCaja.objSccCuentaID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (15).")
				End If
			End If
			m_objSccCuentaID = Value
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
	
	Public Property EsPagoPrima() As Boolean
        Get
            Return (m_EsPagoPrima)
        End Get
		Set(ByVal Value As Boolean)					
			m_EsPagoPrima = Value
		End Set
    End Property
	
	Public Property objMonedaID() As Nullable(Of Integer)
        Get
            Return (m_objMonedaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objMonedaID = Value
		End Set
    End Property
	
	Public Property SucursalPagoID() As Nullable(Of Integer)
        Get
            Return (m_SucursalPagoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_SucursalPagoID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Numero"
				Return	10
			Case "TotalNC"
				Return	11
			Case "TotalFacturas"
				Return	11
			Case "TotalND"
				Return	11
			Case "TotalEfectivo"
				Return	11
			Case "TotalRecibo"
				Return	11
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "objSccCuentaID"
				Return	15
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "TotalNC"
				Return	2
			Case "TotalFacturas"
				Return	2
			Case "TotalND"
				Return	2
			Case "TotalEfectivo"
				Return	2
			Case "TotalRecibo"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccReciboCaja en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccReciboCaja </param>    
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
			cmdDelete.Parameters.Add("@SccReciboCajaID", SqlDbType.Int, 4, "SccReciboCajaID" )
			cmdDelete.CommandText = "DELETE FROM  SccReciboCaja WHERE SccReciboCajaID= @SccReciboCajaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Numero", SqlDbType.VarChar, 10, "Numero")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@TotalNC", SqlDbType.Decimal, 9, "TotalNC")
			cmdInsert.Parameters.Add("@TotalFacturas", SqlDbType.Decimal, 9, "TotalFacturas")
			cmdInsert.Parameters.Add("@TotalND", SqlDbType.Decimal, 9, "TotalND")
			cmdInsert.Parameters.Add("@TotalEfectivo", SqlDbType.Decimal, 9, "TotalEfectivo")
			cmdInsert.Parameters.Add("@TotalRecibo", SqlDbType.Decimal, 9, "TotalRecibo")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.VarChar, 15, "objSccCuentaID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@EsPagoPrima", SqlDbType.Bit, 1, "EsPagoPrima")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@SucursalPagoID", SqlDbType.Int, 4, "SucursalPagoID")
			cmdInsert.CommandText = "INSERT INTO SccReciboCaja ( Numero, Fecha, TotalNC, TotalFacturas, TotalND, TotalEfectivo, TotalRecibo, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, objTiendaID, objSccCuentaID, objEstadoID, EsPagoPrima, objMonedaID, SucursalPagoID) VALUES ( @Numero, @Fecha, @TotalNC, @TotalFacturas, @TotalND, @TotalEfectivo, @TotalRecibo, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @objTiendaID, @objSccCuentaID, @objEstadoID, @EsPagoPrima, @objMonedaID, @SucursalPagoID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.VarChar, 10, "Numero")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@TotalNC", SqlDbType.Decimal, 9, "TotalNC")
			cmdUpdate.Parameters.Add("@TotalFacturas", SqlDbType.Decimal, 9, "TotalFacturas")
			cmdUpdate.Parameters.Add("@TotalND", SqlDbType.Decimal, 9, "TotalND")
			cmdUpdate.Parameters.Add("@TotalEfectivo", SqlDbType.Decimal, 9, "TotalEfectivo")
			cmdUpdate.Parameters.Add("@TotalRecibo", SqlDbType.Decimal, 9, "TotalRecibo")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.VarChar, 15, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@EsPagoPrima", SqlDbType.Bit, 1, "EsPagoPrima")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@SucursalPagoID", SqlDbType.Int, 4, "SucursalPagoID")
			cmdUpdate.Parameters.Add("@wSccReciboCajaID", SqlDbType.Int, 4, "SccReciboCajaID")
			cmdUpdate.CommandText = "UPDATE SccReciboCaja SET Numero=@Numero, Fecha=@Fecha, TotalNC=@TotalNC, TotalFacturas=@TotalFacturas, TotalND=@TotalND, TotalEfectivo=@TotalEfectivo, TotalRecibo=@TotalRecibo, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, objTiendaID=@objTiendaID, objSccCuentaID=@objSccCuentaID, objEstadoID=@objEstadoID, EsPagoPrima=@EsPagoPrima, objMonedaID=@objMonedaID, SucursalPagoID=@SucursalPagoID WHERE SccReciboCajaID= @wSccReciboCajaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccReciboCaja")
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
    ''' Devuelve de la base de datos un objeto SccReciboCaja
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccReciboCajaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccReciboCaja where " & " SccReciboCajaID = " & p_SccReciboCajaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccReciboCajaID = dr("SccReciboCajaID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_TotalNC = IIf(IsDBNull(dr("TotalNC")), Nothing, dr("TotalNC"))					
				m_TotalFacturas = IIf(IsDBNull(dr("TotalFacturas")), Nothing, dr("TotalFacturas"))					
				m_TotalND = IIf(IsDBNull(dr("TotalND")), Nothing, dr("TotalND"))					
				m_TotalEfectivo = IIf(IsDBNull(dr("TotalEfectivo")), Nothing, dr("TotalEfectivo"))					
				m_TotalRecibo = IIf(IsDBNull(dr("TotalRecibo")), Nothing, dr("TotalRecibo"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_EsPagoPrima = IIf(IsDBNull(dr("EsPagoPrima")), Nothing, dr("EsPagoPrima"))					
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))					
				m_SucursalPagoID = IIf(IsDBNull(dr("SucursalPagoID")), Nothing, dr("SucursalPagoID"))					
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
    ''' Devuelve de la base de datos un objeto SccReciboCaja usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccReciboCaja where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccReciboCajaID = dr("SccReciboCajaID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_TotalNC = IIf(IsDBNull(dr("TotalNC")), Nothing, dr("TotalNC"))					
				m_TotalFacturas = IIf(IsDBNull(dr("TotalFacturas")), Nothing, dr("TotalFacturas"))					
				m_TotalND = IIf(IsDBNull(dr("TotalND")), Nothing, dr("TotalND"))					
				m_TotalEfectivo = IIf(IsDBNull(dr("TotalEfectivo")), Nothing, dr("TotalEfectivo"))					
				m_TotalRecibo = IIf(IsDBNull(dr("TotalRecibo")), Nothing, dr("TotalRecibo"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_EsPagoPrima = IIf(IsDBNull(dr("EsPagoPrima")), Nothing, dr("EsPagoPrima"))					
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))					
				m_SucursalPagoID = IIf(IsDBNull(dr("SucursalPagoID")), Nothing, dr("SucursalPagoID"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
			ds.Tables(0).TableName = "SccReciboCaja"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
			ds.Tables(0).TableName = "SccReciboCaja"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccReciboCaja.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccReciboCaja("
		sCommand &= "Numero,"
		sCommand &= "Fecha,"
		sCommand &= "TotalNC,"
		sCommand &= "TotalFacturas,"
		sCommand &= "TotalND,"
		sCommand &= "TotalEfectivo,"
		sCommand &= "TotalRecibo,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "objTiendaID,"
		sCommand &= "objSccCuentaID,"
		sCommand &= "objEstadoID,"
		sCommand &= "EsPagoPrima,"
		sCommand &= "objMonedaID,"
		sCommand &= "SucursalPagoID) values ("		
		sCommand &= "@Numero,"
		sCommand &= "@Fecha,"
		sCommand &= "@TotalNC,"
		sCommand &= "@TotalFacturas,"
		sCommand &= "@TotalND,"
		sCommand &= "@TotalEfectivo,"
		sCommand &= "@TotalRecibo,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@objTiendaID,"
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@EsPagoPrima,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@SucursalPagoID)"		
	
		sCommand &= " select "
		sCommand &= "@SccReciboCajaID = SccReciboCajaID from SccReciboCaja where "		
		sCommand &= "SccReciboCajaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SccReciboCajaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Numero", SqlDbType.VarChar)		
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
		arParams(3) = New SqlParameter("@TotalNC", SqlDbType.Decimal)		
		If IsDBNull(m_TotalNC) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_TotalNC
        End If
		arParams(4) = New SqlParameter("@TotalFacturas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalFacturas) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_TotalFacturas
        End If
		arParams(5) = New SqlParameter("@TotalND", SqlDbType.Decimal)		
		If IsDBNull(m_TotalND) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_TotalND
        End If
		arParams(6) = New SqlParameter("@TotalEfectivo", SqlDbType.Decimal)		
		If IsDBNull(m_TotalEfectivo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_TotalEfectivo
        End If
		arParams(7) = New SqlParameter("@TotalRecibo", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibo) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_TotalRecibo
        End If
		arParams(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioCreacion
        End If
		arParams(9) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCreacion
        End If
		arParams(10) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioModificacion
        End If
		arParams(11) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaModificacion
        End If
		arParams(12) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objTiendaID
        End If
		arParams(13) = New SqlParameter("@objSccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objSccCuentaID
        End If
		arParams(14) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_objEstadoID
        End If
		arParams(15) = New SqlParameter("@EsPagoPrima", SqlDbType.Bit)		
		If IsDBNull(m_EsPagoPrima) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_EsPagoPrima
        End If
		arParams(16) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objMonedaID
        End If
		arParams(17) = New SqlParameter("@SucursalPagoID", SqlDbType.Int)		
		If IsDBNull(m_SucursalPagoID) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_SucursalPagoID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccReciboCajaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccReciboCaja en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccReciboCaja set "		
		sCommand &= "Numero = @Numero,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "TotalNC = @TotalNC,"
		sCommand &= "TotalFacturas = @TotalFacturas,"
		sCommand &= "TotalND = @TotalND,"
		sCommand &= "TotalEfectivo = @TotalEfectivo,"
		sCommand &= "TotalRecibo = @TotalRecibo,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "objTiendaID = @objTiendaID,"
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "EsPagoPrima = @EsPagoPrima,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "SucursalPagoID = @SucursalPagoID"		
		sCommand &= " where "	
		sCommand &= "SccReciboCajaID = @SccReciboCajaID"					
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SccReciboCajaID", SqlDbType.Int)		
		If IsDBNull(m_SccReciboCajaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccReciboCajaID
        End If
		arParams(1) = New SqlParameter("@Numero", SqlDbType.VarChar)		
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
		arParams(3) = New SqlParameter("@TotalNC", SqlDbType.Decimal)		
		If IsDBNull(m_TotalNC) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_TotalNC
        End If
		arParams(4) = New SqlParameter("@TotalFacturas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalFacturas) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_TotalFacturas
        End If
		arParams(5) = New SqlParameter("@TotalND", SqlDbType.Decimal)		
		If IsDBNull(m_TotalND) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_TotalND
        End If
		arParams(6) = New SqlParameter("@TotalEfectivo", SqlDbType.Decimal)		
		If IsDBNull(m_TotalEfectivo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_TotalEfectivo
        End If
		arParams(7) = New SqlParameter("@TotalRecibo", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibo) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_TotalRecibo
        End If
		arParams(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioCreacion
        End If
		arParams(9) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCreacion
        End If
		arParams(10) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioModificacion
        End If
		arParams(11) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaModificacion
        End If
		arParams(12) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objTiendaID
        End If
		arParams(13) = New SqlParameter("@objSccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objSccCuentaID
        End If
		arParams(14) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_objEstadoID
        End If
		arParams(15) = New SqlParameter("@EsPagoPrima", SqlDbType.Bit)		
		If IsDBNull(m_EsPagoPrima) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_EsPagoPrima
        End If
		arParams(16) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objMonedaID
        End If
		arParams(17) = New SqlParameter("@SucursalPagoID", SqlDbType.Int)		
		If IsDBNull(m_SucursalPagoID) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_SucursalPagoID
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
    ''' Borra un objeto SccReciboCaja de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & " SccReciboCajaID = " & m_SccReciboCajaID
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
    ''' Borra un objeto SccReciboCaja de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccReciboCajaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & " SccReciboCajaID = " & p_SccReciboCajaID
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
    ''' Borra objetos SccReciboCaja de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & pWhere
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
