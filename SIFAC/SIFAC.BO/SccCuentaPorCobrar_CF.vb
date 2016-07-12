Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccCuentaPorCobrar		

#Region " Variables Miembro " 
	Protected m_SccCuentaID As String = Nothing 
	Protected m_objTiendaID As Integer 
	Protected m_LimiteCredito As Decimal 
	Protected m_Saldo As Decimal 
	Protected m_RutaHojaContrato As String = Nothing 
	Protected m_objClienteID As String = Nothing 
	Protected m_FechaCredito As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_SaldoInicial As Nullable(Of Decimal) 
#End Region

#Region " Propiedades "
	Public Property SccCuentaID() As String
        Get
            Return (m_SccCuentaID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 15 Then
					Throw New ArgumentOutOfRangeException("SccCuentaID", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrar.SccCuentaID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (15).")
				End If
			End If
			m_SccCuentaID = Value
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
	
	Public Property LimiteCredito() As Decimal
        Get
            Return (m_LimiteCredito)
        End Get
		Set(ByVal Value As Decimal)					
			m_LimiteCredito = Value
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
	
	Public Property RutaHojaContrato() As String
        Get
            Return (m_RutaHojaContrato)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("RutaHojaContrato", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrar.RutaHojaContrato. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_RutaHojaContrato = Value
		End Set
    End Property
	
	Public Property objClienteID() As String
        Get
            Return (m_objClienteID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 16 Then
					Throw New ArgumentOutOfRangeException("objClienteID", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrar.objClienteID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (16).")
				End If
			End If
			m_objClienteID = Value
		End Set
    End Property
	
	Public Property FechaCredito() As Date
        Get
            Return (m_FechaCredito)
        End Get
		Set(ByVal Value As Date)					
			m_FechaCredito = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrar.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrar.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property objEstadoID() As Nullable(Of Integer)
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEstadoID = Value
		End Set
    End Property
	
	Public Property SaldoInicial() As Nullable(Of Decimal)
        Get
            Return (m_SaldoInicial)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_SaldoInicial = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "SccCuentaID"
				Return	15
			Case "LimiteCredito"
				Return	11
			Case "Saldo"
				Return	11
			Case "RutaHojaContrato"
				Return	150
			Case "objClienteID"
				Return	16
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "SaldoInicial"
				Return	11
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "LimiteCredito"
				Return	2
			Case "Saldo"
				Return	2
			Case "SaldoInicial"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccCuentaPorCobrar en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccCuentaPorCobrar </param>    
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
			cmdDelete.Parameters.Add("@SccCuentaID", SqlDbType.VarChar, 15, "SccCuentaID" )
			cmdDelete.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID" )
			cmdDelete.CommandText = "DELETE FROM  SccCuentaPorCobrar WHERE SccCuentaID= @SccCuentaID And objTiendaID= @objTiendaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@SccCuentaID", SqlDbType.VarChar, 15, "SccCuentaID")
			cmdInsert.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdInsert.Parameters.Add("@LimiteCredito", SqlDbType.Decimal, 9, "LimiteCredito")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@RutaHojaContrato", SqlDbType.VarChar, 150, "RutaHojaContrato")
			cmdInsert.Parameters.Add("@objClienteID", SqlDbType.VarChar, 16, "objClienteID")
			cmdInsert.Parameters.Add("@FechaCredito", SqlDbType.DateTime, 8, "FechaCredito")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@SaldoInicial", SqlDbType.Decimal, 9, "SaldoInicial")
			cmdInsert.CommandText = "INSERT INTO SccCuentaPorCobrar ( SccCuentaID, objTiendaID, LimiteCredito, Saldo, RutaHojaContrato, objClienteID, FechaCredito, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, objEstadoID, SaldoInicial) VALUES ( @SccCuentaID, @objTiendaID, @LimiteCredito, @Saldo, @RutaHojaContrato, @objClienteID, @FechaCredito, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @objEstadoID, @SaldoInicial)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@SccCuentaID", SqlDbType.VarChar, 15, "SccCuentaID")
			cmdUpdate.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.Parameters.Add("@LimiteCredito", SqlDbType.Decimal, 9, "LimiteCredito")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@RutaHojaContrato", SqlDbType.VarChar, 150, "RutaHojaContrato")
			cmdUpdate.Parameters.Add("@objClienteID", SqlDbType.VarChar, 16, "objClienteID")
			cmdUpdate.Parameters.Add("@FechaCredito", SqlDbType.DateTime, 8, "FechaCredito")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@SaldoInicial", SqlDbType.Decimal, 9, "SaldoInicial")
			cmdUpdate.Parameters.Add("@wSccCuentaID", SqlDbType.VarChar, 15, "SccCuentaID")
			cmdUpdate.Parameters.Add("@wobjTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.CommandText = "UPDATE SccCuentaPorCobrar SET SccCuentaID=@SccCuentaID, objTiendaID=@objTiendaID, LimiteCredito=@LimiteCredito, Saldo=@Saldo, RutaHojaContrato=@RutaHojaContrato, objClienteID=@objClienteID, FechaCredito=@FechaCredito, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, objEstadoID=@objEstadoID, SaldoInicial=@SaldoInicial WHERE SccCuentaID= @wSccCuentaID And objTiendaID= @wobjTiendaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccCuentaPorCobrar")
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrar
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccCuentaID as String, Byval p_objTiendaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrar where " & " SccCuentaID = '" & p_SccCuentaID & "'"  & " and objTiendaID = " & p_objTiendaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccCuentaID = IIf(IsDBNull(dr("SccCuentaID")), Nothing, dr("SccCuentaID"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_LimiteCredito = IIf(IsDBNull(dr("LimiteCredito")), Nothing, dr("LimiteCredito"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_RutaHojaContrato = IIf(IsDBNull(dr("RutaHojaContrato")), Nothing, dr("RutaHojaContrato"))					
				m_objClienteID = IIf(IsDBNull(dr("objClienteID")), Nothing, dr("objClienteID"))					
				m_FechaCredito = IIf(IsDBNull(dr("FechaCredito")), Nothing, dr("FechaCredito"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_SaldoInicial = IIf(IsDBNull(dr("SaldoInicial")), Nothing, dr("SaldoInicial"))					
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrar usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrar where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccCuentaID = IIf(IsDBNull(dr("SccCuentaID")), Nothing, dr("SccCuentaID"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_LimiteCredito = IIf(IsDBNull(dr("LimiteCredito")), Nothing, dr("LimiteCredito"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_RutaHojaContrato = IIf(IsDBNull(dr("RutaHojaContrato")), Nothing, dr("RutaHojaContrato"))					
				m_objClienteID = IIf(IsDBNull(dr("objClienteID")), Nothing, dr("objClienteID"))					
				m_FechaCredito = IIf(IsDBNull(dr("FechaCredito")), Nothing, dr("FechaCredito"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_SaldoInicial = IIf(IsDBNull(dr("SaldoInicial")), Nothing, dr("SaldoInicial"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrar en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrar"

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
			ds.Tables(0).TableName = "SccCuentaPorCobrar"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrar en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrar"

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
			ds.Tables(0).TableName = "SccCuentaPorCobrar"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrar en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrar"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccCuentaPorCobrar.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccCuentaPorCobrar("
		sCommand &= "SccCuentaID,"
		sCommand &= "objTiendaID,"
		sCommand &= "LimiteCredito,"
		sCommand &= "Saldo,"
		sCommand &= "RutaHojaContrato,"
		sCommand &= "objClienteID,"
		sCommand &= "FechaCredito,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "objEstadoID,"
		sCommand &= "SaldoInicial) values ("		
		sCommand &= "@SccCuentaID,"
		sCommand &= "@objTiendaID,"
		sCommand &= "@LimiteCredito,"
		sCommand &= "@Saldo,"
		sCommand &= "@RutaHojaContrato,"
		sCommand &= "@objClienteID,"
		sCommand &= "@FechaCredito,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@SaldoInicial)"		
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_SccCuentaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccCuentaID
        End If
		arParams(1) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTiendaID
        End If
		arParams(2) = New SqlParameter("@LimiteCredito", SqlDbType.Decimal)		
		If IsDBNull(m_LimiteCredito) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_LimiteCredito
        End If
		arParams(3) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Saldo
        End If
		arParams(4) = New SqlParameter("@RutaHojaContrato", SqlDbType.VarChar)		
		If IsDBNull(m_RutaHojaContrato) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_RutaHojaContrato
        End If
		arParams(5) = New SqlParameter("@objClienteID", SqlDbType.VarChar)		
		If IsDBNull(m_objClienteID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objClienteID
        End If
		arParams(6) = New SqlParameter("@FechaCredito", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCredito) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCredito
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objEstadoID
        End If
		arParams(12) = New SqlParameter("@SaldoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoInicial) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_SaldoInicial
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
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccCuentaPorCobrar en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccCuentaPorCobrar set "		
		sCommand &= "SccCuentaID = @SccCuentaID,"
		sCommand &= "objTiendaID = @objTiendaID,"
		sCommand &= "LimiteCredito = @LimiteCredito,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "RutaHojaContrato = @RutaHojaContrato,"
		sCommand &= "objClienteID = @objClienteID,"
		sCommand &= "FechaCredito = @FechaCredito,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "SaldoInicial = @SaldoInicial"		
		sCommand &= " where "	
		sCommand &= "SccCuentaID = @SccCuentaID and "
		sCommand &= "objTiendaID = @objTiendaID"					
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_SccCuentaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccCuentaID
        End If
		arParams(1) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTiendaID
        End If
		arParams(2) = New SqlParameter("@LimiteCredito", SqlDbType.Decimal)		
		If IsDBNull(m_LimiteCredito) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_LimiteCredito
        End If
		arParams(3) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Saldo
        End If
		arParams(4) = New SqlParameter("@RutaHojaContrato", SqlDbType.VarChar)		
		If IsDBNull(m_RutaHojaContrato) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_RutaHojaContrato
        End If
		arParams(5) = New SqlParameter("@objClienteID", SqlDbType.VarChar)		
		If IsDBNull(m_objClienteID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objClienteID
        End If
		arParams(6) = New SqlParameter("@FechaCredito", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCredito) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCredito
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objEstadoID
        End If
		arParams(12) = New SqlParameter("@SaldoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoInicial) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_SaldoInicial
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
    ''' Borra un objeto SccCuentaPorCobrar de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrar where " & " SccCuentaID = '" & m_SccCuentaID & "'"  & " and objTiendaID = " & m_objTiendaID
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
    ''' Borra un objeto SccCuentaPorCobrar de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccCuentaID as String, Byval p_objTiendaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrar where " & " SccCuentaID = '" & p_SccCuentaID & "'"  & " and objTiendaID = " & p_objTiendaID
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
    ''' Borra objetos SccCuentaPorCobrar de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrar where " & pWhere
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
