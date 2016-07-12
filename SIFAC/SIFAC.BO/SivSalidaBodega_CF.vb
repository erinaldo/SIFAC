Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivSalidaBodega		

#Region " Variables Miembro " 
	Protected m_SivSalidaBodegaID As Integer 
	Protected m_objTiendaID As Integer 
	Protected m_objTipoSalidaID As Integer 
	Protected m_objTipoAjusteID As Nullable(Of Integer) 
	Protected m_objEstadoID As Integer 
	Protected m_FechaSalida As Date 
	Protected m_costototal As Decimal 
	Protected m_Comentarios As String = Nothing 
	Protected m_ComentariosAnular As String = Nothing 
	Protected m_objServicioTallerID As Nullable(Of Integer) 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SivSalidaBodegaID() As Integer
        Get
            Return (m_SivSalidaBodegaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivSalidaBodegaID = Value
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
	
	Public Property objTipoSalidaID() As Integer
        Get
            Return (m_objTipoSalidaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTipoSalidaID = Value
		End Set
    End Property
	
	Public Property objTipoAjusteID() As Nullable(Of Integer)
        Get
            Return (m_objTipoAjusteID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objTipoAjusteID = Value
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
	
	Public Property FechaSalida() As Date
        Get
            Return (m_FechaSalida)
        End Get
		Set(ByVal Value As Date)					
			m_FechaSalida = Value
		End Set
    End Property
	
	Public Property costototal() As Decimal
        Get
            Return (m_costototal)
        End Get
		Set(ByVal Value As Decimal)					
			m_costototal = Value
		End Set
    End Property
	
	Public Property Comentarios() As String
        Get
            Return (m_Comentarios)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 1000 Then
					Throw New ArgumentOutOfRangeException("Comentarios", Value.ToString(), "Valor inv?lido para SivSalidaBodega.Comentarios. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (1000).")
				End If
			End If
			m_Comentarios = Value
		End Set
    End Property
	
	Public Property ComentariosAnular() As String
        Get
            Return (m_ComentariosAnular)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 1000 Then
					Throw New ArgumentOutOfRangeException("ComentariosAnular", Value.ToString(), "Valor inv?lido para SivSalidaBodega.ComentariosAnular. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (1000).")
				End If
			End If
			m_ComentariosAnular = Value
		End Set
    End Property
	
	''' <summary>
	''' Identificador de Servicio de Taller al que pertenece esta salida a haber sido por Garant?a.
	''' </summary>
	Public Property objServicioTallerID() As Nullable(Of Integer)
        Get
            Return (m_objServicioTallerID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objServicioTallerID = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivSalidaBodega.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivSalidaBodega.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "costototal"
				Return	11
			Case "Comentarios"
				Return	1000
			Case "ComentariosAnular"
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
			Case "costototal"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivSalidaBodega en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivSalidaBodega </param>    
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
			cmdDelete.Parameters.Add("@SivSalidaBodegaID", SqlDbType.Int, 4, "SivSalidaBodegaID" )
			cmdDelete.CommandText = "DELETE FROM  SivSalidaBodega WHERE SivSalidaBodegaID= @SivSalidaBodegaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdInsert.Parameters.Add("@objTipoSalidaID", SqlDbType.Int, 4, "objTipoSalidaID")
			cmdInsert.Parameters.Add("@objTipoAjusteID", SqlDbType.Int, 4, "objTipoAjusteID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@FechaSalida", SqlDbType.DateTime, 8, "FechaSalida")
			cmdInsert.Parameters.Add("@costototal", SqlDbType.Decimal, 9, "costototal")
			cmdInsert.Parameters.Add("@Comentarios", SqlDbType.VarChar, 1000, "Comentarios")
			cmdInsert.Parameters.Add("@ComentariosAnular", SqlDbType.VarChar, 1000, "ComentariosAnular")
			cmdInsert.Parameters.Add("@objServicioTallerID", SqlDbType.Int, 4, "objServicioTallerID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SivSalidaBodega ( objTiendaID, objTipoSalidaID, objTipoAjusteID, objEstadoID, FechaSalida, costototal, Comentarios, ComentariosAnular, objServicioTallerID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objTiendaID, @objTipoSalidaID, @objTipoAjusteID, @objEstadoID, @FechaSalida, @costototal, @Comentarios, @ComentariosAnular, @objServicioTallerID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.Parameters.Add("@objTipoSalidaID", SqlDbType.Int, 4, "objTipoSalidaID")
			cmdUpdate.Parameters.Add("@objTipoAjusteID", SqlDbType.Int, 4, "objTipoAjusteID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@FechaSalida", SqlDbType.DateTime, 8, "FechaSalida")
			cmdUpdate.Parameters.Add("@costototal", SqlDbType.Decimal, 9, "costototal")
			cmdUpdate.Parameters.Add("@Comentarios", SqlDbType.VarChar, 1000, "Comentarios")
			cmdUpdate.Parameters.Add("@ComentariosAnular", SqlDbType.VarChar, 1000, "ComentariosAnular")
			cmdUpdate.Parameters.Add("@objServicioTallerID", SqlDbType.Int, 4, "objServicioTallerID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSivSalidaBodegaID", SqlDbType.Int, 4, "SivSalidaBodegaID")
			cmdUpdate.CommandText = "UPDATE SivSalidaBodega SET objTiendaID=@objTiendaID, objTipoSalidaID=@objTipoSalidaID, objTipoAjusteID=@objTipoAjusteID, objEstadoID=@objEstadoID, FechaSalida=@FechaSalida, costototal=@costototal, Comentarios=@Comentarios, ComentariosAnular=@ComentariosAnular, objServicioTallerID=@objServicioTallerID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SivSalidaBodegaID= @wSivSalidaBodegaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivSalidaBodega")
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
    ''' Devuelve de la base de datos un objeto SivSalidaBodega
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivSalidaBodegaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivSalidaBodega where " & " SivSalidaBodegaID = " & p_SivSalidaBodegaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivSalidaBodegaID = dr("SivSalidaBodegaID")
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_objTipoSalidaID = IIf(IsDBNull(dr("objTipoSalidaID")), Nothing, dr("objTipoSalidaID"))					
				m_objTipoAjusteID = IIf(IsDBNull(dr("objTipoAjusteID")), Nothing, dr("objTipoAjusteID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_FechaSalida = IIf(IsDBNull(dr("FechaSalida")), Nothing, dr("FechaSalida"))					
				m_costototal = IIf(IsDBNull(dr("costototal")), Nothing, dr("costototal"))					
				m_Comentarios = IIf(IsDBNull(dr("Comentarios")), Nothing, dr("Comentarios"))					
				m_ComentariosAnular = IIf(IsDBNull(dr("ComentariosAnular")), Nothing, dr("ComentariosAnular"))					
				m_objServicioTallerID = IIf(IsDBNull(dr("objServicioTallerID")), Nothing, dr("objServicioTallerID"))					
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
    ''' Devuelve de la base de datos un objeto SivSalidaBodega usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivSalidaBodega where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivSalidaBodegaID = dr("SivSalidaBodegaID")
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_objTipoSalidaID = IIf(IsDBNull(dr("objTipoSalidaID")), Nothing, dr("objTipoSalidaID"))					
				m_objTipoAjusteID = IIf(IsDBNull(dr("objTipoAjusteID")), Nothing, dr("objTipoAjusteID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_FechaSalida = IIf(IsDBNull(dr("FechaSalida")), Nothing, dr("FechaSalida"))					
				m_costototal = IIf(IsDBNull(dr("costototal")), Nothing, dr("costototal"))					
				m_Comentarios = IIf(IsDBNull(dr("Comentarios")), Nothing, dr("Comentarios"))					
				m_ComentariosAnular = IIf(IsDBNull(dr("ComentariosAnular")), Nothing, dr("ComentariosAnular"))					
				m_objServicioTallerID = IIf(IsDBNull(dr("objServicioTallerID")), Nothing, dr("objServicioTallerID"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivSalidaBodega en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivSalidaBodega"

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
			ds.Tables(0).TableName = "SivSalidaBodega"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivSalidaBodega en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivSalidaBodega"

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
			ds.Tables(0).TableName = "SivSalidaBodega"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivSalidaBodega en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivSalidaBodega"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivSalidaBodega.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivSalidaBodega("
		sCommand &= "objTiendaID,"
		sCommand &= "objTipoSalidaID,"
		sCommand &= "objTipoAjusteID,"
		sCommand &= "objEstadoID,"
		sCommand &= "FechaSalida,"
		sCommand &= "costototal,"
		sCommand &= "Comentarios,"
		sCommand &= "ComentariosAnular,"
		sCommand &= "objServicioTallerID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objTiendaID,"
		sCommand &= "@objTipoSalidaID,"
		sCommand &= "@objTipoAjusteID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@FechaSalida,"
		sCommand &= "@costototal,"
		sCommand &= "@Comentarios,"
		sCommand &= "@ComentariosAnular,"
		sCommand &= "@objServicioTallerID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SivSalidaBodegaID = SivSalidaBodegaID from SivSalidaBodega where "		
		sCommand &= "SivSalidaBodegaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@SivSalidaBodegaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTiendaID
        End If
		arParams(2) = New SqlParameter("@objTipoSalidaID", SqlDbType.Int)		
		If IsDBNull(m_objTipoSalidaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objTipoSalidaID
        End If
		arParams(3) = New SqlParameter("@objTipoAjusteID", SqlDbType.Int)		
		If IsDBNull(m_objTipoAjusteID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objTipoAjusteID
        End If
		arParams(4) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objEstadoID
        End If
		arParams(5) = New SqlParameter("@FechaSalida", SqlDbType.DateTime)		
		If IsDBNull(m_FechaSalida) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaSalida
        End If
		arParams(6) = New SqlParameter("@costototal", SqlDbType.Decimal)		
		If IsDBNull(m_costototal) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_costototal
        End If
		arParams(7) = New SqlParameter("@Comentarios", SqlDbType.VarChar)		
		If IsDBNull(m_Comentarios) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Comentarios
        End If
		arParams(8) = New SqlParameter("@ComentariosAnular", SqlDbType.VarChar)		
		If IsDBNull(m_ComentariosAnular) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_ComentariosAnular
        End If
		arParams(9) = New SqlParameter("@objServicioTallerID", SqlDbType.Int)		
		If IsDBNull(m_objServicioTallerID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objServicioTallerID
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
		arParams(11) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioCreacion
        End If
		arParams(12) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaModificacion
        End If
		arParams(13) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SivSalidaBodegaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivSalidaBodega en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivSalidaBodega set "		
		sCommand &= "objTiendaID = @objTiendaID,"
		sCommand &= "objTipoSalidaID = @objTipoSalidaID,"
		sCommand &= "objTipoAjusteID = @objTipoAjusteID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "FechaSalida = @FechaSalida,"
		sCommand &= "costototal = @costototal,"
		sCommand &= "Comentarios = @Comentarios,"
		sCommand &= "ComentariosAnular = @ComentariosAnular,"
		sCommand &= "objServicioTallerID = @objServicioTallerID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SivSalidaBodegaID = @SivSalidaBodegaID"					
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@SivSalidaBodegaID", SqlDbType.Int)		
		If IsDBNull(m_SivSalidaBodegaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivSalidaBodegaID
        End If
		arParams(1) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTiendaID
        End If
		arParams(2) = New SqlParameter("@objTipoSalidaID", SqlDbType.Int)		
		If IsDBNull(m_objTipoSalidaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objTipoSalidaID
        End If
		arParams(3) = New SqlParameter("@objTipoAjusteID", SqlDbType.Int)		
		If IsDBNull(m_objTipoAjusteID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objTipoAjusteID
        End If
		arParams(4) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objEstadoID
        End If
		arParams(5) = New SqlParameter("@FechaSalida", SqlDbType.DateTime)		
		If IsDBNull(m_FechaSalida) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaSalida
        End If
		arParams(6) = New SqlParameter("@costototal", SqlDbType.Decimal)		
		If IsDBNull(m_costototal) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_costototal
        End If
		arParams(7) = New SqlParameter("@Comentarios", SqlDbType.VarChar)		
		If IsDBNull(m_Comentarios) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Comentarios
        End If
		arParams(8) = New SqlParameter("@ComentariosAnular", SqlDbType.VarChar)		
		If IsDBNull(m_ComentariosAnular) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_ComentariosAnular
        End If
		arParams(9) = New SqlParameter("@objServicioTallerID", SqlDbType.Int)		
		If IsDBNull(m_objServicioTallerID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objServicioTallerID
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
		arParams(11) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioCreacion
        End If
		arParams(12) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaModificacion
        End If
		arParams(13) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SivSalidaBodega de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivSalidaBodega where " & " SivSalidaBodegaID = " & m_SivSalidaBodegaID
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
    ''' Borra un objeto SivSalidaBodega de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivSalidaBodegaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivSalidaBodega where " & " SivSalidaBodegaID = " & p_SivSalidaBodegaID
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
    ''' Borra objetos SivSalidaBodega de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivSalidaBodega where " & pWhere
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
