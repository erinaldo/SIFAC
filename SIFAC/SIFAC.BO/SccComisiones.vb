Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccComisiones		

#Region " Variables Miembro " 
	Protected m_SccComisionID As Integer 
	Protected m_objCajaID As Nullable(Of Integer) 
	Protected m_objEmpleadoID As Nullable(Of Integer) 
	Protected m_Porcentaje As Nullable(Of Decimal) 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_Monto As Nullable(Of Decimal) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_objNotaCreditoID As Nullable(Of Integer) 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_TotalRecuperado As Nullable(Of Decimal) 
#End Region

#Region " Propiedades "
	Public Property SccComisionID() As Integer
        Get
            Return (m_SccComisionID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccComisionID = Value
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
	
	Public Property objEmpleadoID() As Nullable(Of Integer)
        Get
            Return (m_objEmpleadoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEmpleadoID = Value
		End Set
    End Property
	
	Public Property Porcentaje() As Nullable(Of Decimal)
        Get
            Return (m_Porcentaje)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Porcentaje = Value
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
	
	Public Property Monto() As Nullable(Of Decimal)
        Get
            Return (m_Monto)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Monto = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccComisiones.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccComisiones.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property objNotaCreditoID() As Nullable(Of Integer)
        Get
            Return (m_objNotaCreditoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objNotaCreditoID = Value
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
	
	Public Property TotalRecuperado() As Nullable(Of Decimal)
        Get
            Return (m_TotalRecuperado)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TotalRecuperado = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Porcentaje"
				Return	18
			Case "Monto"
				Return	18
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "TotalRecuperado"
				Return	18
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Porcentaje"
				Return	2
			Case "Monto"
				Return	2
			Case "TotalRecuperado"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccComisiones en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccComisiones </param>    
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
			cmdDelete.Parameters.Add("@SccComisionID", SqlDbType.Int, 4, "SccComisionID" )
			cmdDelete.CommandText = "DELETE FROM  SccComisiones WHERE SccComisionID= @SccComisionID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdInsert.Parameters.Add("@objEmpleadoID", SqlDbType.Int, 4, "objEmpleadoID")
			cmdInsert.Parameters.Add("@Porcentaje", SqlDbType.Decimal, 9, "Porcentaje")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@objNotaCreditoID", SqlDbType.Int, 4, "objNotaCreditoID")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@TotalRecuperado", SqlDbType.Decimal, 9, "TotalRecuperado")
			cmdInsert.CommandText = "INSERT INTO SccComisiones ( objCajaID, objEmpleadoID, Porcentaje, Fecha, Monto, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, objNotaCreditoID, Activa, TotalRecuperado) VALUES ( @objCajaID, @objEmpleadoID, @Porcentaje, @Fecha, @Monto, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @objNotaCreditoID, @Activa, @TotalRecuperado)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdUpdate.Parameters.Add("@objEmpleadoID", SqlDbType.Int, 4, "objEmpleadoID")
			cmdUpdate.Parameters.Add("@Porcentaje", SqlDbType.Decimal, 9, "Porcentaje")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@objNotaCreditoID", SqlDbType.Int, 4, "objNotaCreditoID")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@TotalRecuperado", SqlDbType.Decimal, 9, "TotalRecuperado")
			cmdUpdate.Parameters.Add("@wSccComisionID", SqlDbType.Int, 4, "SccComisionID")
			cmdUpdate.CommandText = "UPDATE SccComisiones SET objCajaID=@objCajaID, objEmpleadoID=@objEmpleadoID, Porcentaje=@Porcentaje, Fecha=@Fecha, Monto=@Monto, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, objNotaCreditoID=@objNotaCreditoID, Activa=@Activa, TotalRecuperado=@TotalRecuperado WHERE SccComisionID= @wSccComisionID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccComisiones")
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
    ''' Devuelve de la base de datos un objeto SccComisiones
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccComisionID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccComisiones where " & " SccComisionID = " & p_SccComisionID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccComisionID = dr("SccComisionID")
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))					
				m_objEmpleadoID = IIf(IsDBNull(dr("objEmpleadoID")), Nothing, dr("objEmpleadoID"))					
				m_Porcentaje = IIf(IsDBNull(dr("Porcentaje")), Nothing, dr("Porcentaje"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_objNotaCreditoID = IIf(IsDBNull(dr("objNotaCreditoID")), Nothing, dr("objNotaCreditoID"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
				m_TotalRecuperado = IIf(IsDBNull(dr("TotalRecuperado")), Nothing, dr("TotalRecuperado"))					
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
    ''' Devuelve de la base de datos un objeto SccComisiones usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccComisiones where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccComisionID = dr("SccComisionID")
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))					
				m_objEmpleadoID = IIf(IsDBNull(dr("objEmpleadoID")), Nothing, dr("objEmpleadoID"))					
				m_Porcentaje = IIf(IsDBNull(dr("Porcentaje")), Nothing, dr("Porcentaje"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_objNotaCreditoID = IIf(IsDBNull(dr("objNotaCreditoID")), Nothing, dr("objNotaCreditoID"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
				m_TotalRecuperado = IIf(IsDBNull(dr("TotalRecuperado")), Nothing, dr("TotalRecuperado"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccComisiones en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccComisiones"

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
			ds.Tables(0).TableName = "SccComisiones"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccComisiones en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccComisiones"

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
			ds.Tables(0).TableName = "SccComisiones"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccComisiones en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccComisiones"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccComisiones.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccComisiones("
		sCommand &= "objCajaID,"
		sCommand &= "objEmpleadoID,"
		sCommand &= "Porcentaje,"
		sCommand &= "Fecha,"
		sCommand &= "Monto,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "objNotaCreditoID,"
		sCommand &= "Activa,"
		sCommand &= "TotalRecuperado) values ("		
		sCommand &= "@objCajaID,"
		sCommand &= "@objEmpleadoID,"
		sCommand &= "@Porcentaje,"
		sCommand &= "@Fecha,"
		sCommand &= "@Monto,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@objNotaCreditoID,"
		sCommand &= "@Activa,"
		sCommand &= "@TotalRecuperado)"		
	
		sCommand &= " select "
		sCommand &= "@SccComisionID = SccComisionID from SccComisiones where "		
		sCommand &= "SccComisionID = SCOPE_IDENTITY()"
		
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SccComisionID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCajaID
        End If
		arParams(2) = New SqlParameter("@objEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEmpleadoID
        End If
		arParams(3) = New SqlParameter("@Porcentaje", SqlDbType.Decimal)		
		If IsDBNull(m_Porcentaje) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Porcentaje
        End If
		arParams(4) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Fecha
        End If
		arParams(5) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Monto
        End If
		arParams(6) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCreacion
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaModificacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@objNotaCreditoID", SqlDbType.Int)		
		If IsDBNull(m_objNotaCreditoID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objNotaCreditoID
        End If
		arParams(11) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Activa
        End If
		arParams(12) = New SqlParameter("@TotalRecuperado", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecuperado) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_TotalRecuperado
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccComisionID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccComisiones en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccComisiones set "		
		sCommand &= "objCajaID = @objCajaID,"
		sCommand &= "objEmpleadoID = @objEmpleadoID,"
		sCommand &= "Porcentaje = @Porcentaje,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "Monto = @Monto,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "objNotaCreditoID = @objNotaCreditoID,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "TotalRecuperado = @TotalRecuperado"		
		sCommand &= " where "	
		sCommand &= "SccComisionID = @SccComisionID"					
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SccComisionID", SqlDbType.Int)		
		If IsDBNull(m_SccComisionID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccComisionID
        End If
		arParams(1) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCajaID
        End If
		arParams(2) = New SqlParameter("@objEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEmpleadoID
        End If
		arParams(3) = New SqlParameter("@Porcentaje", SqlDbType.Decimal)		
		If IsDBNull(m_Porcentaje) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Porcentaje
        End If
		arParams(4) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Fecha
        End If
		arParams(5) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Monto
        End If
		arParams(6) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCreacion
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaModificacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@objNotaCreditoID", SqlDbType.Int)		
		If IsDBNull(m_objNotaCreditoID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objNotaCreditoID
        End If
		arParams(11) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Activa
        End If
		arParams(12) = New SqlParameter("@TotalRecuperado", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecuperado) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_TotalRecuperado
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
    ''' Borra un objeto SccComisiones de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccComisiones where " & " SccComisionID = " & m_SccComisionID
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
    ''' Borra un objeto SccComisiones de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccComisionID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccComisiones where " & " SccComisionID = " & p_SccComisionID
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
    ''' Borra objetos SccComisiones de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccComisiones where " & pWhere
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
