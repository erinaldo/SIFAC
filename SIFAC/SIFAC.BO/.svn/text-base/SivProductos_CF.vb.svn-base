Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivProductos		

#Region " Variables Miembro " 
	Protected m_SivProductoID As Integer 
	Protected m_Modelo As String = Nothing 
	Protected m_objMarcaID As Integer 
	Protected m_objCilindrajeID As Integer 
	Protected m_objSegmentoID As Integer 
	Protected m_Activo As Boolean 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	''' <summary>
	''' ID interno del producto
	''' </summary>
	Public Property SivProductoID() As Integer
        Get
            Return (m_SivProductoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivProductoID = Value
		End Set
    End Property
	
	''' <summary>
	''' Nombre del Modelo
	''' </summary>
	Public Property Modelo() As String
        Get
            Return (m_Modelo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Modelo", Value.ToString(), "Valor inv?lido para SivProductos.Modelo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Modelo = Value
		End Set
    End Property
	
	''' <summary>
	''' ID de la Marca
	''' </summary>
	Public Property objMarcaID() As Integer
        Get
            Return (m_objMarcaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objMarcaID = Value
		End Set
    End Property
	
	''' <summary>
	''' ID del Cilindraje
	''' </summary>
	Public Property objCilindrajeID() As Integer
        Get
            Return (m_objCilindrajeID)
        End Get
		Set(ByVal Value As Integer)					
			m_objCilindrajeID = Value
		End Set
    End Property
	
	''' <summary>
	''' ID del segmento de ventas
	''' </summary>
	Public Property objSegmentoID() As Integer
        Get
            Return (m_objSegmentoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objSegmentoID = Value
		End Set
    End Property
	
	''' <summary>
	''' Activo actualmente? Participa en nuevas cuentas?
	''' </summary>
	Public Property Activo() As Boolean
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Boolean)					
			m_Activo = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de creaci?n del registro
	''' </summary>
	Public Property FechaCreacion() As Date
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Date)					
			m_FechaCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Login del usuario creador del registro
	''' </summary>
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivProductos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de modificaci?n del registro
	''' </summary>
	Public Property FechaModificacion() As Nullable(Of Date)
        Get
            Return (m_FechaModificacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaModificacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Login del usuario modificador del registro
	''' </summary>
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivProductos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Modelo"
				Return	50
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
    ''' Salva un DataSet del tipo de la tabla SivProductos en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivProductos </param>    
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
			cmdDelete.Parameters.Add("@SivProductoID", SqlDbType.Int, 4, "SivProductoID" )
			cmdDelete.CommandText = "DELETE FROM  SivProductos WHERE SivProductoID= @SivProductoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@SivProductoID", SqlDbType.Int, 4, "SivProductoID")
			cmdInsert.Parameters.Add("@Modelo", SqlDbType.VarChar, 50, "Modelo")
			cmdInsert.Parameters.Add("@objMarcaID", SqlDbType.Int, 4, "objMarcaID")
			cmdInsert.Parameters.Add("@objCilindrajeID", SqlDbType.Int, 4, "objCilindrajeID")
			cmdInsert.Parameters.Add("@objSegmentoID", SqlDbType.Int, 4, "objSegmentoID")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SivProductos ( SivProductoID, Modelo, objMarcaID, objCilindrajeID, objSegmentoID, Activo, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @SivProductoID, @Modelo, @objMarcaID, @objCilindrajeID, @objSegmentoID, @Activo, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@SivProductoID", SqlDbType.Int, 4, "SivProductoID")
			cmdUpdate.Parameters.Add("@Modelo", SqlDbType.VarChar, 50, "Modelo")
			cmdUpdate.Parameters.Add("@objMarcaID", SqlDbType.Int, 4, "objMarcaID")
			cmdUpdate.Parameters.Add("@objCilindrajeID", SqlDbType.Int, 4, "objCilindrajeID")
			cmdUpdate.Parameters.Add("@objSegmentoID", SqlDbType.Int, 4, "objSegmentoID")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSivProductoID", SqlDbType.Int, 4, "SivProductoID")
			cmdUpdate.CommandText = "UPDATE SivProductos SET SivProductoID=@SivProductoID, Modelo=@Modelo, objMarcaID=@objMarcaID, objCilindrajeID=@objCilindrajeID, objSegmentoID=@objSegmentoID, Activo=@Activo, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SivProductoID= @wSivProductoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivProductos")
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
    ''' Devuelve de la base de datos un objeto SivProductos
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivProductoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivProductos where " & " SivProductoID = " & p_SivProductoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivProductoID = IIf(IsDBNull(dr("SivProductoID")), Nothing, dr("SivProductoID"))					
				m_Modelo = IIf(IsDBNull(dr("Modelo")), Nothing, dr("Modelo"))					
				m_objMarcaID = IIf(IsDBNull(dr("objMarcaID")), Nothing, dr("objMarcaID"))					
				m_objCilindrajeID = IIf(IsDBNull(dr("objCilindrajeID")), Nothing, dr("objCilindrajeID"))					
				m_objSegmentoID = IIf(IsDBNull(dr("objSegmentoID")), Nothing, dr("objSegmentoID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
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
    ''' Devuelve de la base de datos un objeto SivProductos usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivProductos where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivProductoID = IIf(IsDBNull(dr("SivProductoID")), Nothing, dr("SivProductoID"))					
				m_Modelo = IIf(IsDBNull(dr("Modelo")), Nothing, dr("Modelo"))					
				m_objMarcaID = IIf(IsDBNull(dr("objMarcaID")), Nothing, dr("objMarcaID"))					
				m_objCilindrajeID = IIf(IsDBNull(dr("objCilindrajeID")), Nothing, dr("objCilindrajeID"))					
				m_objSegmentoID = IIf(IsDBNull(dr("objSegmentoID")), Nothing, dr("objSegmentoID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivProductos en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivProductos"

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
			ds.Tables(0).TableName = "SivProductos"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivProductos en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivProductos"

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
			ds.Tables(0).TableName = "SivProductos"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivProductos en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivProductos"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivProductos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivProductos("
		sCommand &= "SivProductoID,"
		sCommand &= "Modelo,"
		sCommand &= "objMarcaID,"
		sCommand &= "objCilindrajeID,"
		sCommand &= "objSegmentoID,"
		sCommand &= "Activo,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@SivProductoID,"
		sCommand &= "@Modelo,"
		sCommand &= "@objMarcaID,"
		sCommand &= "@objCilindrajeID,"
		sCommand &= "@objSegmentoID,"
		sCommand &= "@Activo,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SivProductoID", SqlDbType.Int)		
		If IsDBNull(m_SivProductoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivProductoID
        End If
		arParams(1) = New SqlParameter("@Modelo", SqlDbType.VarChar)		
		If IsDBNull(m_Modelo) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Modelo
        End If
		arParams(2) = New SqlParameter("@objMarcaID", SqlDbType.Int)		
		If IsDBNull(m_objMarcaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objMarcaID
        End If
		arParams(3) = New SqlParameter("@objCilindrajeID", SqlDbType.Int)		
		If IsDBNull(m_objCilindrajeID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCilindrajeID
        End If
		arParams(4) = New SqlParameter("@objSegmentoID", SqlDbType.Int)		
		If IsDBNull(m_objSegmentoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objSegmentoID
        End If
		arParams(5) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Activo
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
    ''' 	Actualiza el objeto SivProductos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivProductos set "		
		sCommand &= "SivProductoID = @SivProductoID,"
		sCommand &= "Modelo = @Modelo,"
		sCommand &= "objMarcaID = @objMarcaID,"
		sCommand &= "objCilindrajeID = @objCilindrajeID,"
		sCommand &= "objSegmentoID = @objSegmentoID,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SivProductoID = @SivProductoID"					
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SivProductoID", SqlDbType.Int)		
		If IsDBNull(m_SivProductoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivProductoID
        End If
		arParams(1) = New SqlParameter("@Modelo", SqlDbType.VarChar)		
		If IsDBNull(m_Modelo) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Modelo
        End If
		arParams(2) = New SqlParameter("@objMarcaID", SqlDbType.Int)		
		If IsDBNull(m_objMarcaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objMarcaID
        End If
		arParams(3) = New SqlParameter("@objCilindrajeID", SqlDbType.Int)		
		If IsDBNull(m_objCilindrajeID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCilindrajeID
        End If
		arParams(4) = New SqlParameter("@objSegmentoID", SqlDbType.Int)		
		If IsDBNull(m_objSegmentoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objSegmentoID
        End If
		arParams(5) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Activo
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
    ''' Borra un objeto SivProductos de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivProductos where " & " SivProductoID = " & m_SivProductoID
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
    ''' Borra un objeto SivProductos de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivProductoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivProductos where " & " SivProductoID = " & p_SivProductoID
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
    ''' Borra objetos SivProductos de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivProductos where " & pWhere
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
