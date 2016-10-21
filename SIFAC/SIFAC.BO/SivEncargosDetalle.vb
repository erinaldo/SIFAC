Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivEncargosDetalle		

#Region " Variables Miembro " 
	Protected m_SivEncargoDetalleID As Integer 
	Protected m_objSivEncargoID As Nullable(Of Integer) 
	Protected m_objCategoriaID As Nullable(Of Integer) 
	Protected m_objProductoID As Nullable(Of Integer) 
	Protected m_Nombre_Producto As String = Nothing 
	Protected m_Observaciones As String = Nothing 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_Cantidad As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property SivEncargoDetalleID() As Integer
        Get
            Return (m_SivEncargoDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivEncargoDetalleID = Value
		End Set
    End Property
	
	Public Property objSivEncargoID() As Nullable(Of Integer)
        Get
            Return (m_objSivEncargoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSivEncargoID = Value
		End Set
    End Property
	
	Public Property objCategoriaID() As Nullable(Of Integer)
        Get
            Return (m_objCategoriaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCategoriaID = Value
		End Set
    End Property
	
	Public Property objProductoID() As Nullable(Of Integer)
        Get
            Return (m_objProductoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objProductoID = Value
		End Set
    End Property
	
	Public Property Nombre_Producto() As String
        Get
            Return (m_Nombre_Producto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Nombre_Producto", Value.ToString(), "Valor inv?lido para SivEncargosDetalle.Nombre_Producto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Nombre_Producto = Value
		End Set
    End Property
	
	Public Property Observaciones() As String
        Get
            Return (m_Observaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("Observaciones", Value.ToString(), "Valor inv?lido para SivEncargosDetalle.Observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_Observaciones = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivEncargosDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
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
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivEncargosDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	
	Public Property Cantidad() As Nullable(Of Integer)
        Get
            Return (m_Cantidad)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Cantidad = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Nombre_Producto"
				Return	50
			Case "Observaciones"
				Return	150
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
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivEncargosDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivEncargosDetalle </param>    
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
			cmdDelete.Parameters.Add("@SivEncargoDetalleID", SqlDbType.Int, 4, "SivEncargoDetalleID" )
			cmdDelete.CommandText = "DELETE FROM  SivEncargosDetalle WHERE SivEncargoDetalleID= @SivEncargoDetalleID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSivEncargoID", SqlDbType.Int, 4, "objSivEncargoID")
			cmdInsert.Parameters.Add("@objCategoriaID", SqlDbType.Int, 4, "objCategoriaID")
			cmdInsert.Parameters.Add("@objProductoID", SqlDbType.Int, 4, "objProductoID")
			cmdInsert.Parameters.Add("@Nombre_Producto", SqlDbType.VarChar, 50, "Nombre_Producto")
			cmdInsert.Parameters.Add("@Observaciones", SqlDbType.VarChar, 150, "Observaciones")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdInsert.CommandText = "INSERT INTO SivEncargosDetalle ( objSivEncargoID, objCategoriaID, objProductoID, Nombre_Producto, Observaciones, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, Cantidad) VALUES ( @objSivEncargoID, @objCategoriaID, @objProductoID, @Nombre_Producto, @Observaciones, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @Cantidad)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSivEncargoID", SqlDbType.Int, 4, "objSivEncargoID")
			cmdUpdate.Parameters.Add("@objCategoriaID", SqlDbType.Int, 4, "objCategoriaID")
			cmdUpdate.Parameters.Add("@objProductoID", SqlDbType.Int, 4, "objProductoID")
			cmdUpdate.Parameters.Add("@Nombre_Producto", SqlDbType.VarChar, 50, "Nombre_Producto")
			cmdUpdate.Parameters.Add("@Observaciones", SqlDbType.VarChar, 150, "Observaciones")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdUpdate.Parameters.Add("@wSivEncargoDetalleID", SqlDbType.Int, 4, "SivEncargoDetalleID")
			cmdUpdate.CommandText = "UPDATE SivEncargosDetalle SET objSivEncargoID=@objSivEncargoID, objCategoriaID=@objCategoriaID, objProductoID=@objProductoID, Nombre_Producto=@Nombre_Producto, Observaciones=@Observaciones, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, Cantidad=@Cantidad WHERE SivEncargoDetalleID= @wSivEncargoDetalleID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivEncargosDetalle")
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
    ''' Devuelve de la base de datos un objeto SivEncargosDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivEncargoDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivEncargosDetalle where " & " SivEncargoDetalleID = " & p_SivEncargoDetalleID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivEncargoDetalleID = dr("SivEncargoDetalleID")
				m_objSivEncargoID = IIf(IsDBNull(dr("objSivEncargoID")), Nothing, dr("objSivEncargoID"))					
				m_objCategoriaID = IIf(IsDBNull(dr("objCategoriaID")), Nothing, dr("objCategoriaID"))					
				m_objProductoID = IIf(IsDBNull(dr("objProductoID")), Nothing, dr("objProductoID"))					
				m_Nombre_Producto = IIf(IsDBNull(dr("Nombre_Producto")), Nothing, dr("Nombre_Producto"))					
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
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
    ''' Devuelve de la base de datos un objeto SivEncargosDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivEncargosDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivEncargoDetalleID = dr("SivEncargoDetalleID")
				m_objSivEncargoID = IIf(IsDBNull(dr("objSivEncargoID")), Nothing, dr("objSivEncargoID"))					
				m_objCategoriaID = IIf(IsDBNull(dr("objCategoriaID")), Nothing, dr("objCategoriaID"))					
				m_objProductoID = IIf(IsDBNull(dr("objProductoID")), Nothing, dr("objProductoID"))					
				m_Nombre_Producto = IIf(IsDBNull(dr("Nombre_Producto")), Nothing, dr("Nombre_Producto"))					
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivEncargosDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivEncargosDetalle"

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
			ds.Tables(0).TableName = "SivEncargosDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEncargosDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivEncargosDetalle"

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
			ds.Tables(0).TableName = "SivEncargosDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEncargosDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivEncargosDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivEncargosDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivEncargosDetalle("
		sCommand &= "objSivEncargoID,"
		sCommand &= "objCategoriaID,"
		sCommand &= "objProductoID,"
		sCommand &= "Nombre_Producto,"
		sCommand &= "Observaciones,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "Cantidad) values ("		
		sCommand &= "@objSivEncargoID,"
		sCommand &= "@objCategoriaID,"
		sCommand &= "@objProductoID,"
		sCommand &= "@Nombre_Producto,"
		sCommand &= "@Observaciones,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@Cantidad)"		
	
		sCommand &= " select "
		sCommand &= "@SivEncargoDetalleID = SivEncargoDetalleID from SivEncargosDetalle where "		
		sCommand &= "SivEncargoDetalleID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SivEncargoDetalleID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSivEncargoID", SqlDbType.Int)		
		If IsDBNull(m_objSivEncargoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSivEncargoID
        End If
		arParams(2) = New SqlParameter("@objCategoriaID", SqlDbType.Int)		
		If IsDBNull(m_objCategoriaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCategoriaID
        End If
		arParams(3) = New SqlParameter("@objProductoID", SqlDbType.Int)		
		If IsDBNull(m_objProductoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objProductoID
        End If
		arParams(4) = New SqlParameter("@Nombre_Producto", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre_Producto) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Nombre_Producto
        End If
		arParams(5) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Observaciones
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
		arParams(10) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Cantidad
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SivEncargoDetalleID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivEncargosDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivEncargosDetalle set "		
		sCommand &= "objSivEncargoID = @objSivEncargoID,"
		sCommand &= "objCategoriaID = @objCategoriaID,"
		sCommand &= "objProductoID = @objProductoID,"
		sCommand &= "Nombre_Producto = @Nombre_Producto,"
		sCommand &= "Observaciones = @Observaciones,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "Cantidad = @Cantidad"		
		sCommand &= " where "	
		sCommand &= "SivEncargoDetalleID = @SivEncargoDetalleID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SivEncargoDetalleID", SqlDbType.Int)		
		If IsDBNull(m_SivEncargoDetalleID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivEncargoDetalleID
        End If
		arParams(1) = New SqlParameter("@objSivEncargoID", SqlDbType.Int)		
		If IsDBNull(m_objSivEncargoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSivEncargoID
        End If
		arParams(2) = New SqlParameter("@objCategoriaID", SqlDbType.Int)		
		If IsDBNull(m_objCategoriaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCategoriaID
        End If
		arParams(3) = New SqlParameter("@objProductoID", SqlDbType.Int)		
		If IsDBNull(m_objProductoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objProductoID
        End If
		arParams(4) = New SqlParameter("@Nombre_Producto", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre_Producto) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Nombre_Producto
        End If
		arParams(5) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Observaciones
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
		arParams(10) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Cantidad
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
    ''' Borra un objeto SivEncargosDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEncargosDetalle where " & " SivEncargoDetalleID = " & m_SivEncargoDetalleID
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
    ''' Borra un objeto SivEncargosDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivEncargoDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEncargosDetalle where " & " SivEncargoDetalleID = " & p_SivEncargoDetalleID
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
    ''' Borra objetos SivEncargosDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEncargosDetalle where " & pWhere
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
