Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccSalidasEfectivoArqueo		

#Region " Variables Miembro " 
	Protected m_GastoID As Integer 
	Protected m_objArqueoID As Nullable(Of Integer) 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacio As Nullable(Of Date) 
	Protected m_Total As Nullable(Of Decimal) 
#End Region

#Region " Propiedades "
	Public Property GastoID() As Integer
        Get
            Return (m_GastoID)
        End Get
		Set(ByVal Value As Integer)					
			m_GastoID = Value
		End Set
    End Property
	
	Public Property objArqueoID() As Nullable(Of Integer)
        Get
            Return (m_objArqueoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objArqueoID = Value
		End Set
    End Property
	
	Public Property Fecha() As Nullable(Of Date)
        Get
            Return (m_Fecha)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_Fecha = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccSalidasEfectivoArqueo.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property UsuarioModificacio() As Nullable(Of Date)
        Get
            Return (m_UsuarioModificacio)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_UsuarioModificacio = Value
		End Set
    End Property
	
	Public Property Total() As Nullable(Of Decimal)
        Get
            Return (m_Total)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Total = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "UsuarioCreacion"
				Return	50
			Case "Total"
				Return	18
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Total"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccSalidasEfectivoArqueo en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccSalidasEfectivoArqueo </param>    
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
			cmdDelete.Parameters.Add("@GastoID", SqlDbType.Int, 4, "GastoID" )
			cmdDelete.CommandText = "DELETE FROM  SccSalidasEfectivoArqueo WHERE GastoID= @GastoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objArqueoID", SqlDbType.Int, 4, "objArqueoID")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacio", SqlDbType.DateTime, 8, "UsuarioModificacio")
			cmdInsert.Parameters.Add("@Total", SqlDbType.Decimal, 9, "Total")
			cmdInsert.CommandText = "INSERT INTO SccSalidasEfectivoArqueo ( objArqueoID, Fecha, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacio, Total) VALUES ( @objArqueoID, @Fecha, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacio, @Total)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objArqueoID", SqlDbType.Int, 4, "objArqueoID")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacio", SqlDbType.DateTime, 8, "UsuarioModificacio")
			cmdUpdate.Parameters.Add("@Total", SqlDbType.Decimal, 9, "Total")
			cmdUpdate.Parameters.Add("@wGastoID", SqlDbType.Int, 4, "GastoID")
			cmdUpdate.CommandText = "UPDATE SccSalidasEfectivoArqueo SET objArqueoID=@objArqueoID, Fecha=@Fecha, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacio=@UsuarioModificacio, Total=@Total WHERE GastoID= @wGastoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccSalidasEfectivoArqueo")
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
    ''' Devuelve de la base de datos un objeto SccSalidasEfectivoArqueo
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_GastoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccSalidasEfectivoArqueo where " & " GastoID = " & p_GastoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_GastoID = dr("GastoID")
				m_objArqueoID = IIf(IsDBNull(dr("objArqueoID")), Nothing, dr("objArqueoID"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacio = IIf(IsDBNull(dr("UsuarioModificacio")), Nothing, dr("UsuarioModificacio"))					
				m_Total = IIf(IsDBNull(dr("Total")), Nothing, dr("Total"))					
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
    ''' Devuelve de la base de datos un objeto SccSalidasEfectivoArqueo usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccSalidasEfectivoArqueo where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_GastoID = dr("GastoID")
				m_objArqueoID = IIf(IsDBNull(dr("objArqueoID")), Nothing, dr("objArqueoID"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacio = IIf(IsDBNull(dr("UsuarioModificacio")), Nothing, dr("UsuarioModificacio"))					
				m_Total = IIf(IsDBNull(dr("Total")), Nothing, dr("Total"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccSalidasEfectivoArqueo en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccSalidasEfectivoArqueo"

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
			ds.Tables(0).TableName = "SccSalidasEfectivoArqueo"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccSalidasEfectivoArqueo en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccSalidasEfectivoArqueo"

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
			ds.Tables(0).TableName = "SccSalidasEfectivoArqueo"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccSalidasEfectivoArqueo en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccSalidasEfectivoArqueo"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccSalidasEfectivoArqueo.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccSalidasEfectivoArqueo("
		sCommand &= "objArqueoID,"
		sCommand &= "Fecha,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacio,"
		sCommand &= "Total) values ("		
		sCommand &= "@objArqueoID,"
		sCommand &= "@Fecha,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacio,"
		sCommand &= "@Total)"		
	
		sCommand &= " select "
		sCommand &= "@GastoID = GastoID from SccSalidasEfectivoArqueo where "		
		sCommand &= "GastoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(7) As SqlParameter
		arParams(0) = New SqlParameter("@GastoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objArqueoID", SqlDbType.Int)		
		If IsDBNull(m_objArqueoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objArqueoID
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaCreacion
        End If
		arParams(4) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_UsuarioCreacion
        End If
		arParams(5) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaModificacion
        End If
		arParams(6) = New SqlParameter("@UsuarioModificacio", SqlDbType.DateTime)		
		If IsDBNull(m_UsuarioModificacio) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioModificacio
        End If
		arParams(7) = New SqlParameter("@Total", SqlDbType.Decimal)		
		If IsDBNull(m_Total) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Total
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_GastoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccSalidasEfectivoArqueo en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccSalidasEfectivoArqueo set "		
		sCommand &= "objArqueoID = @objArqueoID,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacio = @UsuarioModificacio,"
		sCommand &= "Total = @Total"		
		sCommand &= " where "	
		sCommand &= "GastoID = @GastoID"					
		
		Dim arParams(7) As SqlParameter
		arParams(0) = New SqlParameter("@GastoID", SqlDbType.Int)		
		If IsDBNull(m_GastoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_GastoID
        End If
		arParams(1) = New SqlParameter("@objArqueoID", SqlDbType.Int)		
		If IsDBNull(m_objArqueoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objArqueoID
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaCreacion
        End If
		arParams(4) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_UsuarioCreacion
        End If
		arParams(5) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaModificacion
        End If
		arParams(6) = New SqlParameter("@UsuarioModificacio", SqlDbType.DateTime)		
		If IsDBNull(m_UsuarioModificacio) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioModificacio
        End If
		arParams(7) = New SqlParameter("@Total", SqlDbType.Decimal)		
		If IsDBNull(m_Total) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Total
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
    ''' Borra un objeto SccSalidasEfectivoArqueo de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccSalidasEfectivoArqueo where " & " GastoID = " & m_GastoID
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
    ''' Borra un objeto SccSalidasEfectivoArqueo de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_GastoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccSalidasEfectivoArqueo where " & " GastoID = " & p_GastoID
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
    ''' Borra objetos SccSalidasEfectivoArqueo de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccSalidasEfectivoArqueo where " & pWhere
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
