Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccDescuentoPlazo		

#Region " Variables Miembro " 
	Protected m_SccDescuentoID As Integer 
	Protected m_PlazoPago As Nullable(Of Integer) 
	Protected m_DescuentoMaximo As Nullable(Of Decimal) 
	Protected m_DescuentoMinimo As Nullable(Of Decimal) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_Activo As Nullable(Of Boolean) 
#End Region

#Region " Propiedades "
	Public Property SccDescuentoID() As Integer
        Get
            Return (m_SccDescuentoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccDescuentoID = Value
		End Set
    End Property
	
	Public Property PlazoPago() As Nullable(Of Integer)
        Get
            Return (m_PlazoPago)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_PlazoPago = Value
		End Set
    End Property
	
	Public Property DescuentoMaximo() As Nullable(Of Decimal)
        Get
            Return (m_DescuentoMaximo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_DescuentoMaximo = Value
		End Set
    End Property
	
	Public Property DescuentoMinimo() As Nullable(Of Decimal)
        Get
            Return (m_DescuentoMinimo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_DescuentoMinimo = Value
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
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccDescuentoPlazo.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccDescuentoPlazo.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
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
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "DescuentoMaximo"
				Return	11
			Case "DescuentoMinimo"
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
			Case "DescuentoMaximo"
				Return	2
			Case "DescuentoMinimo"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccDescuentoPlazo en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccDescuentoPlazo </param>    
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
			cmdDelete.Parameters.Add("@SccDescuentoID", SqlDbType.Int, 4, "SccDescuentoID" )
			cmdDelete.CommandText = "DELETE FROM  SccDescuentoPlazo WHERE SccDescuentoID= @SccDescuentoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@PlazoPago", SqlDbType.Int, 4, "PlazoPago")
			cmdInsert.Parameters.Add("@DescuentoMaximo", SqlDbType.Decimal, 9, "DescuentoMaximo")
			cmdInsert.Parameters.Add("@DescuentoMinimo", SqlDbType.Decimal, 9, "DescuentoMinimo")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.CommandText = "INSERT INTO SccDescuentoPlazo ( PlazoPago, DescuentoMaximo, DescuentoMinimo, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Activo) VALUES ( @PlazoPago, @DescuentoMaximo, @DescuentoMinimo, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Activo)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@PlazoPago", SqlDbType.Int, 4, "PlazoPago")
			cmdUpdate.Parameters.Add("@DescuentoMaximo", SqlDbType.Decimal, 9, "DescuentoMaximo")
			cmdUpdate.Parameters.Add("@DescuentoMinimo", SqlDbType.Decimal, 9, "DescuentoMinimo")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@wSccDescuentoID", SqlDbType.Int, 4, "SccDescuentoID")
			cmdUpdate.CommandText = "UPDATE SccDescuentoPlazo SET PlazoPago=@PlazoPago, DescuentoMaximo=@DescuentoMaximo, DescuentoMinimo=@DescuentoMinimo, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Activo=@Activo WHERE SccDescuentoID= @wSccDescuentoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccDescuentoPlazo")
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
    ''' Devuelve de la base de datos un objeto SccDescuentoPlazo
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccDescuentoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccDescuentoPlazo where " & " SccDescuentoID = " & p_SccDescuentoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccDescuentoID = dr("SccDescuentoID")
				m_PlazoPago = IIf(IsDBNull(dr("PlazoPago")), Nothing, dr("PlazoPago"))					
				m_DescuentoMaximo = IIf(IsDBNull(dr("DescuentoMaximo")), Nothing, dr("DescuentoMaximo"))					
				m_DescuentoMinimo = IIf(IsDBNull(dr("DescuentoMinimo")), Nothing, dr("DescuentoMinimo"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
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
    ''' Devuelve de la base de datos un objeto SccDescuentoPlazo usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccDescuentoPlazo where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccDescuentoID = dr("SccDescuentoID")
				m_PlazoPago = IIf(IsDBNull(dr("PlazoPago")), Nothing, dr("PlazoPago"))					
				m_DescuentoMaximo = IIf(IsDBNull(dr("DescuentoMaximo")), Nothing, dr("DescuentoMaximo"))					
				m_DescuentoMinimo = IIf(IsDBNull(dr("DescuentoMinimo")), Nothing, dr("DescuentoMinimo"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccDescuentoPlazo en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccDescuentoPlazo"

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
			ds.Tables(0).TableName = "SccDescuentoPlazo"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccDescuentoPlazo en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccDescuentoPlazo"

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
			ds.Tables(0).TableName = "SccDescuentoPlazo"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccDescuentoPlazo en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccDescuentoPlazo"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccDescuentoPlazo.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccDescuentoPlazo("
		sCommand &= "PlazoPago,"
		sCommand &= "DescuentoMaximo,"
		sCommand &= "DescuentoMinimo,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "Activo) values ("		
		sCommand &= "@PlazoPago,"
		sCommand &= "@DescuentoMaximo,"
		sCommand &= "@DescuentoMinimo,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@Activo)"		
	
		sCommand &= " select "
		sCommand &= "@SccDescuentoID = SccDescuentoID from SccDescuentoPlazo where "		
		sCommand &= "SccDescuentoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(8) As SqlParameter
		arParams(0) = New SqlParameter("@SccDescuentoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@PlazoPago", SqlDbType.Int)		
		If IsDBNull(m_PlazoPago) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_PlazoPago
        End If
		arParams(2) = New SqlParameter("@DescuentoMaximo", SqlDbType.Decimal)		
		If IsDBNull(m_DescuentoMaximo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_DescuentoMaximo
        End If
		arParams(3) = New SqlParameter("@DescuentoMinimo", SqlDbType.Decimal)		
		If IsDBNull(m_DescuentoMinimo) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_DescuentoMinimo
        End If
		arParams(4) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaCreacion
        End If
		arParams(5) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_UsuarioCreacion
        End If
		arParams(6) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaModificacion
        End If
		arParams(7) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioModificacion
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccDescuentoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccDescuentoPlazo en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccDescuentoPlazo set "		
		sCommand &= "PlazoPago = @PlazoPago,"
		sCommand &= "DescuentoMaximo = @DescuentoMaximo,"
		sCommand &= "DescuentoMinimo = @DescuentoMinimo,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "Activo = @Activo"		
		sCommand &= " where "	
		sCommand &= "SccDescuentoID = @SccDescuentoID"					
		
		Dim arParams(8) As SqlParameter
		arParams(0) = New SqlParameter("@SccDescuentoID", SqlDbType.Int)		
		If IsDBNull(m_SccDescuentoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccDescuentoID
        End If
		arParams(1) = New SqlParameter("@PlazoPago", SqlDbType.Int)		
		If IsDBNull(m_PlazoPago) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_PlazoPago
        End If
		arParams(2) = New SqlParameter("@DescuentoMaximo", SqlDbType.Decimal)		
		If IsDBNull(m_DescuentoMaximo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_DescuentoMaximo
        End If
		arParams(3) = New SqlParameter("@DescuentoMinimo", SqlDbType.Decimal)		
		If IsDBNull(m_DescuentoMinimo) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_DescuentoMinimo
        End If
		arParams(4) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaCreacion
        End If
		arParams(5) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_UsuarioCreacion
        End If
		arParams(6) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaModificacion
        End If
		arParams(7) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioModificacion
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
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
    ''' Borra un objeto SccDescuentoPlazo de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccDescuentoPlazo where " & " SccDescuentoID = " & m_SccDescuentoID
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
    ''' Borra un objeto SccDescuentoPlazo de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccDescuentoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccDescuentoPlazo where " & " SccDescuentoID = " & p_SccDescuentoID
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
    ''' Borra objetos SccDescuentoPlazo de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccDescuentoPlazo where " & pWhere
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
