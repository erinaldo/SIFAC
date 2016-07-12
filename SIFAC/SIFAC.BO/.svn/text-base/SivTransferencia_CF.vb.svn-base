Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivTransferencia		

#Region " Variables Miembro " 
	Protected m_SivTransferenciaID As Integer 
	Protected m_ObjTiendaDestinoID As Integer 
	Protected m_ObjTiendaOrigenID As Integer 
	Protected m_Observaciones As String = Nothing 
	Protected m_Fechasolicitud As Nullable(Of Date) 
	Protected m_SolicitadoPor As String = Nothing 
	Protected m_Fechadespacho As Nullable(Of Date) 
	Protected m_DespachadoPor As String = Nothing 
	Protected m_Fecharecibido As Nullable(Of Date) 
	Protected m_RecibidoPor As String = Nothing 
	Protected m_costototal As Nullable(Of Decimal) 
	Protected m_ObjEstadoID As Integer 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SivTransferenciaID() As Integer
        Get
            Return (m_SivTransferenciaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivTransferenciaID = Value
		End Set
    End Property
	
	Public Property ObjTiendaDestinoID() As Integer
        Get
            Return (m_ObjTiendaDestinoID)
        End Get
		Set(ByVal Value As Integer)					
			m_ObjTiendaDestinoID = Value
		End Set
    End Property
	
	Public Property ObjTiendaOrigenID() As Integer
        Get
            Return (m_ObjTiendaOrigenID)
        End Get
		Set(ByVal Value As Integer)					
			m_ObjTiendaOrigenID = Value
		End Set
    End Property
	
	Public Property Observaciones() As String
        Get
            Return (m_Observaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 250 Then
					Throw New ArgumentOutOfRangeException("Observaciones", Value.ToString(), "Valor inv?lido para SivTransferencia.Observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (250).")
				End If
			End If
			m_Observaciones = Value
		End Set
    End Property
	
	Public Property Fechasolicitud() As Nullable(Of Date)
        Get
            Return (m_Fechasolicitud)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_Fechasolicitud = Value
		End Set
    End Property
	
	Public Property SolicitadoPor() As String
        Get
            Return (m_SolicitadoPor)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("SolicitadoPor", Value.ToString(), "Valor inv?lido para SivTransferencia.SolicitadoPor. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_SolicitadoPor = Value
		End Set
    End Property
	
	Public Property Fechadespacho() As Nullable(Of Date)
        Get
            Return (m_Fechadespacho)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_Fechadespacho = Value
		End Set
    End Property
	
	Public Property DespachadoPor() As String
        Get
            Return (m_DespachadoPor)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("DespachadoPor", Value.ToString(), "Valor inv?lido para SivTransferencia.DespachadoPor. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_DespachadoPor = Value
		End Set
    End Property
	
	Public Property Fecharecibido() As Nullable(Of Date)
        Get
            Return (m_Fecharecibido)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_Fecharecibido = Value
		End Set
    End Property
	
	Public Property RecibidoPor() As String
        Get
            Return (m_RecibidoPor)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("RecibidoPor", Value.ToString(), "Valor inv?lido para SivTransferencia.RecibidoPor. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_RecibidoPor = Value
		End Set
    End Property
	
	Public Property costototal() As Nullable(Of Decimal)
        Get
            Return (m_costototal)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_costototal = Value
		End Set
    End Property
	
	Public Property ObjEstadoID() As Integer
        Get
            Return (m_ObjEstadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_ObjEstadoID = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivTransferencia.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivTransferencia.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Observaciones"
				Return	250
			Case "SolicitadoPor"
				Return	30
			Case "DespachadoPor"
				Return	30
			Case "RecibidoPor"
				Return	30
			Case "costototal"
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
			Case "costototal"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivTransferencia en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivTransferencia </param>    
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
			cmdDelete.Parameters.Add("@SivTransferenciaID", SqlDbType.Int, 4, "SivTransferenciaID" )
			cmdDelete.Parameters.Add("@ObjTiendaDestinoID", SqlDbType.Int, 4, "ObjTiendaDestinoID" )
			cmdDelete.CommandText = "DELETE FROM  SivTransferencia WHERE SivTransferenciaID= @SivTransferenciaID And ObjTiendaDestinoID= @ObjTiendaDestinoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@ObjTiendaDestinoID", SqlDbType.Int, 4, "ObjTiendaDestinoID")
			cmdInsert.Parameters.Add("@ObjTiendaOrigenID", SqlDbType.Int, 4, "ObjTiendaOrigenID")
			cmdInsert.Parameters.Add("@Observaciones", SqlDbType.VarChar, 250, "Observaciones")
			cmdInsert.Parameters.Add("@Fechasolicitud", SqlDbType.DateTime, 8, "Fechasolicitud")
			cmdInsert.Parameters.Add("@SolicitadoPor", SqlDbType.VarChar, 30, "SolicitadoPor")
			cmdInsert.Parameters.Add("@Fechadespacho", SqlDbType.DateTime, 8, "Fechadespacho")
			cmdInsert.Parameters.Add("@DespachadoPor", SqlDbType.VarChar, 30, "DespachadoPor")
			cmdInsert.Parameters.Add("@Fecharecibido", SqlDbType.DateTime, 8, "Fecharecibido")
			cmdInsert.Parameters.Add("@RecibidoPor", SqlDbType.VarChar, 30, "RecibidoPor")
			cmdInsert.Parameters.Add("@costototal", SqlDbType.Decimal, 9, "costototal")
			cmdInsert.Parameters.Add("@ObjEstadoID", SqlDbType.Int, 4, "ObjEstadoID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SivTransferencia ( ObjTiendaDestinoID, ObjTiendaOrigenID, Observaciones, Fechasolicitud, SolicitadoPor, Fechadespacho, DespachadoPor, Fecharecibido, RecibidoPor, costototal, ObjEstadoID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @ObjTiendaDestinoID, @ObjTiendaOrigenID, @Observaciones, @Fechasolicitud, @SolicitadoPor, @Fechadespacho, @DespachadoPor, @Fecharecibido, @RecibidoPor, @costototal, @ObjEstadoID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@ObjTiendaDestinoID", SqlDbType.Int, 4, "ObjTiendaDestinoID")
			cmdUpdate.Parameters.Add("@ObjTiendaOrigenID", SqlDbType.Int, 4, "ObjTiendaOrigenID")
			cmdUpdate.Parameters.Add("@Observaciones", SqlDbType.VarChar, 250, "Observaciones")
			cmdUpdate.Parameters.Add("@Fechasolicitud", SqlDbType.DateTime, 8, "Fechasolicitud")
			cmdUpdate.Parameters.Add("@SolicitadoPor", SqlDbType.VarChar, 30, "SolicitadoPor")
			cmdUpdate.Parameters.Add("@Fechadespacho", SqlDbType.DateTime, 8, "Fechadespacho")
			cmdUpdate.Parameters.Add("@DespachadoPor", SqlDbType.VarChar, 30, "DespachadoPor")
			cmdUpdate.Parameters.Add("@Fecharecibido", SqlDbType.DateTime, 8, "Fecharecibido")
			cmdUpdate.Parameters.Add("@RecibidoPor", SqlDbType.VarChar, 30, "RecibidoPor")
			cmdUpdate.Parameters.Add("@costototal", SqlDbType.Decimal, 9, "costototal")
			cmdUpdate.Parameters.Add("@ObjEstadoID", SqlDbType.Int, 4, "ObjEstadoID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSivTransferenciaID", SqlDbType.Int, 4, "SivTransferenciaID")
			cmdUpdate.Parameters.Add("@wObjTiendaDestinoID", SqlDbType.Int, 4, "ObjTiendaDestinoID")
			cmdUpdate.CommandText = "UPDATE SivTransferencia SET ObjTiendaDestinoID=@ObjTiendaDestinoID, ObjTiendaOrigenID=@ObjTiendaOrigenID, Observaciones=@Observaciones, Fechasolicitud=@Fechasolicitud, SolicitadoPor=@SolicitadoPor, Fechadespacho=@Fechadespacho, DespachadoPor=@DespachadoPor, Fecharecibido=@Fecharecibido, RecibidoPor=@RecibidoPor, costototal=@costototal, ObjEstadoID=@ObjEstadoID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SivTransferenciaID= @wSivTransferenciaID And ObjTiendaDestinoID= @wObjTiendaDestinoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivTransferencia")
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
    ''' Devuelve de la base de datos un objeto SivTransferencia
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivTransferenciaID as Integer, Byval p_ObjTiendaDestinoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivTransferencia where " & " SivTransferenciaID = " & p_SivTransferenciaID & " and ObjTiendaDestinoID = " & p_ObjTiendaDestinoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivTransferenciaID = dr("SivTransferenciaID")
				m_ObjTiendaDestinoID = IIf(IsDBNull(dr("ObjTiendaDestinoID")), Nothing, dr("ObjTiendaDestinoID"))					
				m_ObjTiendaOrigenID = IIf(IsDBNull(dr("ObjTiendaOrigenID")), Nothing, dr("ObjTiendaOrigenID"))					
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))					
				m_Fechasolicitud = IIf(IsDBNull(dr("Fechasolicitud")), Nothing, dr("Fechasolicitud"))					
				m_SolicitadoPor = IIf(IsDBNull(dr("SolicitadoPor")), Nothing, dr("SolicitadoPor"))					
				m_Fechadespacho = IIf(IsDBNull(dr("Fechadespacho")), Nothing, dr("Fechadespacho"))					
				m_DespachadoPor = IIf(IsDBNull(dr("DespachadoPor")), Nothing, dr("DespachadoPor"))					
				m_Fecharecibido = IIf(IsDBNull(dr("Fecharecibido")), Nothing, dr("Fecharecibido"))					
				m_RecibidoPor = IIf(IsDBNull(dr("RecibidoPor")), Nothing, dr("RecibidoPor"))					
				m_costototal = IIf(IsDBNull(dr("costototal")), Nothing, dr("costototal"))					
				m_ObjEstadoID = IIf(IsDBNull(dr("ObjEstadoID")), Nothing, dr("ObjEstadoID"))					
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
    ''' Devuelve de la base de datos un objeto SivTransferencia usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivTransferencia where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivTransferenciaID = dr("SivTransferenciaID")
				m_ObjTiendaDestinoID = IIf(IsDBNull(dr("ObjTiendaDestinoID")), Nothing, dr("ObjTiendaDestinoID"))					
				m_ObjTiendaOrigenID = IIf(IsDBNull(dr("ObjTiendaOrigenID")), Nothing, dr("ObjTiendaOrigenID"))					
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))					
				m_Fechasolicitud = IIf(IsDBNull(dr("Fechasolicitud")), Nothing, dr("Fechasolicitud"))					
				m_SolicitadoPor = IIf(IsDBNull(dr("SolicitadoPor")), Nothing, dr("SolicitadoPor"))					
				m_Fechadespacho = IIf(IsDBNull(dr("Fechadespacho")), Nothing, dr("Fechadespacho"))					
				m_DespachadoPor = IIf(IsDBNull(dr("DespachadoPor")), Nothing, dr("DespachadoPor"))					
				m_Fecharecibido = IIf(IsDBNull(dr("Fecharecibido")), Nothing, dr("Fecharecibido"))					
				m_RecibidoPor = IIf(IsDBNull(dr("RecibidoPor")), Nothing, dr("RecibidoPor"))					
				m_costototal = IIf(IsDBNull(dr("costototal")), Nothing, dr("costototal"))					
				m_ObjEstadoID = IIf(IsDBNull(dr("ObjEstadoID")), Nothing, dr("ObjEstadoID"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivTransferencia en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivTransferencia"

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
			ds.Tables(0).TableName = "SivTransferencia"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivTransferencia en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivTransferencia"

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
			ds.Tables(0).TableName = "SivTransferencia"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivTransferencia en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivTransferencia"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivTransferencia.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivTransferencia("
		sCommand &= "ObjTiendaDestinoID,"
		sCommand &= "ObjTiendaOrigenID,"
		sCommand &= "Observaciones,"
		sCommand &= "Fechasolicitud,"
		sCommand &= "SolicitadoPor,"
		sCommand &= "Fechadespacho,"
		sCommand &= "DespachadoPor,"
		sCommand &= "Fecharecibido,"
		sCommand &= "RecibidoPor,"
		sCommand &= "costototal,"
		sCommand &= "ObjEstadoID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@ObjTiendaDestinoID,"
		sCommand &= "@ObjTiendaOrigenID,"
		sCommand &= "@Observaciones,"
		sCommand &= "@Fechasolicitud,"
		sCommand &= "@SolicitadoPor,"
		sCommand &= "@Fechadespacho,"
		sCommand &= "@DespachadoPor,"
		sCommand &= "@Fecharecibido,"
		sCommand &= "@RecibidoPor,"
		sCommand &= "@costototal,"
		sCommand &= "@ObjEstadoID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		

        'Modificado por: Gell
        'Se agregó SCOPE_IDENTITY() porque al generar la clase con CodeFast no lo agrega
        sCommand &= " select "
        sCommand &= "@SivTransferenciaID = SivTransferenciaID from SivTransferencia where "
        sCommand &= "SivTransferenciaID = SCOPE_IDENTITY() and "
        sCommand &= "ObjTiendaDestinoID = @ObjTiendaDestinoID"

		Dim arParams(15) As SqlParameter
		arParams(0) = New SqlParameter("@SivTransferenciaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@ObjTiendaDestinoID", SqlDbType.Int)		
		If IsDBNull(m_ObjTiendaDestinoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_ObjTiendaDestinoID
        End If
		arParams(2) = New SqlParameter("@ObjTiendaOrigenID", SqlDbType.Int)		
		If IsDBNull(m_ObjTiendaOrigenID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_ObjTiendaOrigenID
        End If
		arParams(3) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Observaciones
        End If
		arParams(4) = New SqlParameter("@Fechasolicitud", SqlDbType.DateTime)		
		If IsDBNull(m_Fechasolicitud) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Fechasolicitud
        End If
		arParams(5) = New SqlParameter("@SolicitadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_SolicitadoPor) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_SolicitadoPor
        End If
		arParams(6) = New SqlParameter("@Fechadespacho", SqlDbType.DateTime)		
		If IsDBNull(m_Fechadespacho) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Fechadespacho
        End If
		arParams(7) = New SqlParameter("@DespachadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_DespachadoPor) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_DespachadoPor
        End If
		arParams(8) = New SqlParameter("@Fecharecibido", SqlDbType.DateTime)		
		If IsDBNull(m_Fecharecibido) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Fecharecibido
        End If
		arParams(9) = New SqlParameter("@RecibidoPor", SqlDbType.VarChar)		
		If IsDBNull(m_RecibidoPor) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_RecibidoPor
        End If
		arParams(10) = New SqlParameter("@costototal", SqlDbType.Decimal)		
		If IsDBNull(m_costototal) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_costototal
        End If
		arParams(11) = New SqlParameter("@ObjEstadoID", SqlDbType.Int)		
		If IsDBNull(m_ObjEstadoID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_ObjEstadoID
        End If
		arParams(12) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaCreacion
        End If
		arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
		arParams(14) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaModificacion
        End If
		arParams(15) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SivTransferenciaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivTransferencia en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivTransferencia set "		
		sCommand &= "ObjTiendaDestinoID = @ObjTiendaDestinoID,"
		sCommand &= "ObjTiendaOrigenID = @ObjTiendaOrigenID,"
		sCommand &= "Observaciones = @Observaciones,"
		sCommand &= "Fechasolicitud = @Fechasolicitud,"
		sCommand &= "SolicitadoPor = @SolicitadoPor,"
		sCommand &= "Fechadespacho = @Fechadespacho,"
		sCommand &= "DespachadoPor = @DespachadoPor,"
		sCommand &= "Fecharecibido = @Fecharecibido,"
		sCommand &= "RecibidoPor = @RecibidoPor,"
		sCommand &= "costototal = @costototal,"
		sCommand &= "ObjEstadoID = @ObjEstadoID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SivTransferenciaID = @SivTransferenciaID and "
		sCommand &= "ObjTiendaDestinoID = @ObjTiendaDestinoID"					
		
		Dim arParams(15) As SqlParameter
		arParams(0) = New SqlParameter("@SivTransferenciaID", SqlDbType.Int)		
		If IsDBNull(m_SivTransferenciaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivTransferenciaID
        End If
		arParams(1) = New SqlParameter("@ObjTiendaDestinoID", SqlDbType.Int)		
		If IsDBNull(m_ObjTiendaDestinoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_ObjTiendaDestinoID
        End If
		arParams(2) = New SqlParameter("@ObjTiendaOrigenID", SqlDbType.Int)		
		If IsDBNull(m_ObjTiendaOrigenID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_ObjTiendaOrigenID
        End If
		arParams(3) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Observaciones
        End If
		arParams(4) = New SqlParameter("@Fechasolicitud", SqlDbType.DateTime)		
		If IsDBNull(m_Fechasolicitud) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Fechasolicitud
        End If
		arParams(5) = New SqlParameter("@SolicitadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_SolicitadoPor) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_SolicitadoPor
        End If
		arParams(6) = New SqlParameter("@Fechadespacho", SqlDbType.DateTime)		
		If IsDBNull(m_Fechadespacho) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Fechadespacho
        End If
		arParams(7) = New SqlParameter("@DespachadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_DespachadoPor) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_DespachadoPor
        End If
		arParams(8) = New SqlParameter("@Fecharecibido", SqlDbType.DateTime)		
		If IsDBNull(m_Fecharecibido) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Fecharecibido
        End If
		arParams(9) = New SqlParameter("@RecibidoPor", SqlDbType.VarChar)		
		If IsDBNull(m_RecibidoPor) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_RecibidoPor
        End If
		arParams(10) = New SqlParameter("@costototal", SqlDbType.Decimal)		
		If IsDBNull(m_costototal) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_costototal
        End If
		arParams(11) = New SqlParameter("@ObjEstadoID", SqlDbType.Int)		
		If IsDBNull(m_ObjEstadoID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_ObjEstadoID
        End If
		arParams(12) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaCreacion
        End If
		arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
		arParams(14) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaModificacion
        End If
		arParams(15) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SivTransferencia de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivTransferencia where " & " SivTransferenciaID = " & m_SivTransferenciaID & " and ObjTiendaDestinoID = " & m_ObjTiendaDestinoID
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
    ''' Borra un objeto SivTransferencia de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivTransferenciaID as Integer, Byval p_ObjTiendaDestinoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivTransferencia where " & " SivTransferenciaID = " & p_SivTransferenciaID & " and ObjTiendaDestinoID = " & p_ObjTiendaDestinoID
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
    ''' Borra objetos SivTransferencia de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivTransferencia where " & pWhere
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
