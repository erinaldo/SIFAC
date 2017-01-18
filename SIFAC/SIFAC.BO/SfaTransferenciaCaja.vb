Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SfaTransferenciaCaja		

#Region " Variables Miembro " 
	Protected m_SfaTranferenciaID As Integer 
	Protected m_objCajaOrigenID As Nullable(Of Integer) 
	Protected m_objCajeroOrigen As Nullable(Of Integer) 
	Protected m_objCajaDestinoID As Nullable(Of Integer) 
	Protected m_objCajeroDestino As Nullable(Of Integer) 
	Protected m_Monto As Nullable(Of Decimal) 
	Protected m_Comentarios As Byte() 
	Protected m_Aprobada As Nullable(Of Boolean) 
	Protected m_AutorizadoPor As String = Nothing 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_FechaAprobacion As Nullable(Of Date) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SfaTranferenciaID() As Integer
        Get
            Return (m_SfaTranferenciaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SfaTranferenciaID = Value
		End Set
    End Property
	
	Public Property objCajaOrigenID() As Nullable(Of Integer)
        Get
            Return (m_objCajaOrigenID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajaOrigenID = Value
		End Set
    End Property
	
	Public Property objCajeroOrigen() As Nullable(Of Integer)
        Get
            Return (m_objCajeroOrigen)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajeroOrigen = Value
		End Set
    End Property
	
	Public Property objCajaDestinoID() As Nullable(Of Integer)
        Get
            Return (m_objCajaDestinoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajaDestinoID = Value
		End Set
    End Property
	
	Public Property objCajeroDestino() As Nullable(Of Integer)
        Get
            Return (m_objCajeroDestino)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajeroDestino = Value
		End Set
    End Property
	
	Public Property Monto() As Nullable(Of Decimal)
        Get
            Return (m_Monto)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Monto = Value
		End Set
    End Property
	
	Public Property Comentarios() As Byte()
        Get
            Return (m_Comentarios)
        End Get
		Set(ByVal Value As Byte())					
			m_Comentarios = Value
		End Set
    End Property
	
	Public Property Aprobada() As Nullable(Of Boolean)
        Get
            Return (m_Aprobada)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Aprobada = Value
		End Set
    End Property
	
	Public Property AutorizadoPor() As String
        Get
            Return (m_AutorizadoPor)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("AutorizadoPor", Value.ToString(), "Valor inv?lido para SfaTransferenciaCaja.AutorizadoPor. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_AutorizadoPor = Value
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
	
	Public Property FechaAprobacion() As Nullable(Of Date)
        Get
            Return (m_FechaAprobacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaAprobacion = Value
		End Set
    End Property
	
	Public Property FechaCreacion() As Nullable(Of Date)
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaCreacion = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SfaTransferenciaCaja.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SfaTransferenciaCaja.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Monto"
				Return	18
			Case "AutorizadoPor"
				Return	50
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
			Case "Monto"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SfaTransferenciaCaja en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SfaTransferenciaCaja </param>    
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
			cmdDelete.Parameters.Add("@SfaTranferenciaID", SqlDbType.Int, 4, "SfaTranferenciaID" )
			cmdDelete.CommandText = "DELETE FROM  SfaTransferenciaCaja WHERE SfaTranferenciaID= @SfaTranferenciaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objCajaOrigenID", SqlDbType.Int, 4, "objCajaOrigenID")
			cmdInsert.Parameters.Add("@objCajeroOrigen", SqlDbType.Int, 4, "objCajeroOrigen")
			cmdInsert.Parameters.Add("@objCajaDestinoID", SqlDbType.Int, 4, "objCajaDestinoID")
			cmdInsert.Parameters.Add("@objCajeroDestino", SqlDbType.Int, 4, "objCajeroDestino")
			cmdInsert.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdInsert.Parameters.Add("@Comentarios", SqlDbType.Binary, -1, "Comentarios")
			cmdInsert.Parameters.Add("@Aprobada", SqlDbType.Bit, 1, "Aprobada")
			cmdInsert.Parameters.Add("@AutorizadoPor", SqlDbType.VarChar, 50, "AutorizadoPor")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@FechaAprobacion", SqlDbType.DateTime, 8, "FechaAprobacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SfaTransferenciaCaja ( objCajaOrigenID, objCajeroOrigen, objCajaDestinoID, objCajeroDestino, Monto, Comentarios, Aprobada, AutorizadoPor, Activa, FechaAprobacion, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objCajaOrigenID, @objCajeroOrigen, @objCajaDestinoID, @objCajeroDestino, @Monto, @Comentarios, @Aprobada, @AutorizadoPor, @Activa, @FechaAprobacion, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objCajaOrigenID", SqlDbType.Int, 4, "objCajaOrigenID")
			cmdUpdate.Parameters.Add("@objCajeroOrigen", SqlDbType.Int, 4, "objCajeroOrigen")
			cmdUpdate.Parameters.Add("@objCajaDestinoID", SqlDbType.Int, 4, "objCajaDestinoID")
			cmdUpdate.Parameters.Add("@objCajeroDestino", SqlDbType.Int, 4, "objCajeroDestino")
			cmdUpdate.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdUpdate.Parameters.Add("@Comentarios", SqlDbType.Binary, -1, "Comentarios")
			cmdUpdate.Parameters.Add("@Aprobada", SqlDbType.Bit, 1, "Aprobada")
			cmdUpdate.Parameters.Add("@AutorizadoPor", SqlDbType.VarChar, 50, "AutorizadoPor")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@FechaAprobacion", SqlDbType.DateTime, 8, "FechaAprobacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSfaTranferenciaID", SqlDbType.Int, 4, "SfaTranferenciaID")
			cmdUpdate.CommandText = "UPDATE SfaTransferenciaCaja SET objCajaOrigenID=@objCajaOrigenID, objCajeroOrigen=@objCajeroOrigen, objCajaDestinoID=@objCajaDestinoID, objCajeroDestino=@objCajeroDestino, Monto=@Monto, Comentarios=@Comentarios, Aprobada=@Aprobada, AutorizadoPor=@AutorizadoPor, Activa=@Activa, FechaAprobacion=@FechaAprobacion, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SfaTranferenciaID= @wSfaTranferenciaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SfaTransferenciaCaja")
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
    ''' Devuelve de la base de datos un objeto SfaTransferenciaCaja
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SfaTranferenciaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaTransferenciaCaja where " & " SfaTranferenciaID = " & p_SfaTranferenciaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SfaTranferenciaID = dr("SfaTranferenciaID")
				m_objCajaOrigenID = IIf(IsDBNull(dr("objCajaOrigenID")), Nothing, dr("objCajaOrigenID"))					
				m_objCajeroOrigen = IIf(IsDBNull(dr("objCajeroOrigen")), Nothing, dr("objCajeroOrigen"))					
				m_objCajaDestinoID = IIf(IsDBNull(dr("objCajaDestinoID")), Nothing, dr("objCajaDestinoID"))					
				m_objCajeroDestino = IIf(IsDBNull(dr("objCajeroDestino")), Nothing, dr("objCajeroDestino"))					
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))					
				m_Comentarios = IIf(IsDBNull(dr("Comentarios")), Nothing, dr("Comentarios"))					
				m_Aprobada = IIf(IsDBNull(dr("Aprobada")), Nothing, dr("Aprobada"))					
				m_AutorizadoPor = IIf(IsDBNull(dr("AutorizadoPor")), Nothing, dr("AutorizadoPor"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
				m_FechaAprobacion = IIf(IsDBNull(dr("FechaAprobacion")), Nothing, dr("FechaAprobacion"))					
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
    ''' Devuelve de la base de datos un objeto SfaTransferenciaCaja usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SfaTransferenciaCaja where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SfaTranferenciaID = dr("SfaTranferenciaID")
				m_objCajaOrigenID = IIf(IsDBNull(dr("objCajaOrigenID")), Nothing, dr("objCajaOrigenID"))					
				m_objCajeroOrigen = IIf(IsDBNull(dr("objCajeroOrigen")), Nothing, dr("objCajeroOrigen"))					
				m_objCajaDestinoID = IIf(IsDBNull(dr("objCajaDestinoID")), Nothing, dr("objCajaDestinoID"))					
				m_objCajeroDestino = IIf(IsDBNull(dr("objCajeroDestino")), Nothing, dr("objCajeroDestino"))					
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))					
				m_Comentarios = IIf(IsDBNull(dr("Comentarios")), Nothing, dr("Comentarios"))					
				m_Aprobada = IIf(IsDBNull(dr("Aprobada")), Nothing, dr("Aprobada"))					
				m_AutorizadoPor = IIf(IsDBNull(dr("AutorizadoPor")), Nothing, dr("AutorizadoPor"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
				m_FechaAprobacion = IIf(IsDBNull(dr("FechaAprobacion")), Nothing, dr("FechaAprobacion"))					
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
    ''' Trae de la base de datos un conjunto de objetos SfaTransferenciaCaja en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SfaTransferenciaCaja"

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
			ds.Tables(0).TableName = "SfaTransferenciaCaja"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaTransferenciaCaja en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SfaTransferenciaCaja"

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
			ds.Tables(0).TableName = "SfaTransferenciaCaja"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SfaTransferenciaCaja en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SfaTransferenciaCaja"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SfaTransferenciaCaja.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SfaTransferenciaCaja("
		sCommand &= "objCajaOrigenID,"
		sCommand &= "objCajeroOrigen,"
		sCommand &= "objCajaDestinoID,"
		sCommand &= "objCajeroDestino,"
		sCommand &= "Monto,"
		sCommand &= "Comentarios,"
		sCommand &= "Aprobada,"
		sCommand &= "AutorizadoPor,"
		sCommand &= "Activa,"
		sCommand &= "FechaAprobacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objCajaOrigenID,"
		sCommand &= "@objCajeroOrigen,"
		sCommand &= "@objCajaDestinoID,"
		sCommand &= "@objCajeroDestino,"
		sCommand &= "@Monto,"
		sCommand &= "@Comentarios,"
		sCommand &= "@Aprobada,"
		sCommand &= "@AutorizadoPor,"
		sCommand &= "@Activa,"
		sCommand &= "@FechaAprobacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SfaTranferenciaID = SfaTranferenciaID from SfaTransferenciaCaja where "		
		sCommand &= "SfaTranferenciaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@SfaTranferenciaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objCajaOrigenID", SqlDbType.Int)		
		If IsDBNull(m_objCajaOrigenID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCajaOrigenID
        End If
		arParams(2) = New SqlParameter("@objCajeroOrigen", SqlDbType.Int)		
		If IsDBNull(m_objCajeroOrigen) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCajeroOrigen
        End If
		arParams(3) = New SqlParameter("@objCajaDestinoID", SqlDbType.Int)		
		If IsDBNull(m_objCajaDestinoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCajaDestinoID
        End If
		arParams(4) = New SqlParameter("@objCajeroDestino", SqlDbType.Int)		
		If IsDBNull(m_objCajeroDestino) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCajeroDestino
        End If
		arParams(5) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Monto
        End If
		arParams(6) = New SqlParameter("@Comentarios", SqlDbType.Binary)		
		If IsDBNull(m_Comentarios) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Comentarios
        End If
		arParams(7) = New SqlParameter("@Aprobada", SqlDbType.Bit)		
		If IsDBNull(m_Aprobada) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Aprobada
        End If
		arParams(8) = New SqlParameter("@AutorizadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_AutorizadoPor) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_AutorizadoPor
        End If
		arParams(9) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Activa
        End If
		arParams(10) = New SqlParameter("@FechaAprobacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAprobacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaAprobacion
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
		arParams(13) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaModificacion
        End If
		arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SfaTranferenciaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SfaTransferenciaCaja en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SfaTransferenciaCaja set "		
		sCommand &= "objCajaOrigenID = @objCajaOrigenID,"
		sCommand &= "objCajeroOrigen = @objCajeroOrigen,"
		sCommand &= "objCajaDestinoID = @objCajaDestinoID,"
		sCommand &= "objCajeroDestino = @objCajeroDestino,"
		sCommand &= "Monto = @Monto,"
		sCommand &= "Comentarios = @Comentarios,"
		sCommand &= "Aprobada = @Aprobada,"
		sCommand &= "AutorizadoPor = @AutorizadoPor,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "FechaAprobacion = @FechaAprobacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SfaTranferenciaID = @SfaTranferenciaID"					
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@SfaTranferenciaID", SqlDbType.Int)		
		If IsDBNull(m_SfaTranferenciaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SfaTranferenciaID
        End If
		arParams(1) = New SqlParameter("@objCajaOrigenID", SqlDbType.Int)		
		If IsDBNull(m_objCajaOrigenID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCajaOrigenID
        End If
		arParams(2) = New SqlParameter("@objCajeroOrigen", SqlDbType.Int)		
		If IsDBNull(m_objCajeroOrigen) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCajeroOrigen
        End If
		arParams(3) = New SqlParameter("@objCajaDestinoID", SqlDbType.Int)		
		If IsDBNull(m_objCajaDestinoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCajaDestinoID
        End If
		arParams(4) = New SqlParameter("@objCajeroDestino", SqlDbType.Int)		
		If IsDBNull(m_objCajeroDestino) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCajeroDestino
        End If
		arParams(5) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Monto
        End If
		arParams(6) = New SqlParameter("@Comentarios", SqlDbType.Binary)		
		If IsDBNull(m_Comentarios) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Comentarios
        End If
		arParams(7) = New SqlParameter("@Aprobada", SqlDbType.Bit)		
		If IsDBNull(m_Aprobada) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Aprobada
        End If
		arParams(8) = New SqlParameter("@AutorizadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_AutorizadoPor) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_AutorizadoPor
        End If
		arParams(9) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Activa
        End If
		arParams(10) = New SqlParameter("@FechaAprobacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAprobacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaAprobacion
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
		arParams(13) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaModificacion
        End If
		arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SfaTransferenciaCaja de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaTransferenciaCaja where " & " SfaTranferenciaID = " & m_SfaTranferenciaID
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
    ''' Borra un objeto SfaTransferenciaCaja de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SfaTranferenciaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaTransferenciaCaja where " & " SfaTranferenciaID = " & p_SfaTranferenciaID
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
    ''' Borra objetos SfaTransferenciaCaja de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SfaTransferenciaCaja where " & pWhere
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
