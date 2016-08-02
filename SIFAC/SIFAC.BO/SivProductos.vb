Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivProductos		

#Region " Variables Miembro " 
	Protected m_SivProductoID As Integer 
	Protected m_Nombre As String = Nothing 
	Protected m_Descripcion As String = Nothing 
	Protected m_objCategoriaID As Integer 
	Protected m_objMarcaID As Integer 
	Protected m_CostoPromedio As Nullable(Of Decimal) 
	Protected m_Precio_Credito As Nullable(Of Decimal) 
	Protected m_Precio_Contado As Nullable(Of Decimal) 
	Protected m_Margen_Utilidad_Credito As Nullable(Of Integer) 
	Protected m_Margen_Utilidad_Contado As Nullable(Of Integer) 
	Protected m_Cantidad_Minima As Nullable(Of Integer) 
	Protected m_Activo As Boolean 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SivProductoID() As Integer
        Get
            Return (m_SivProductoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivProductoID = Value
		End Set
    End Property
	
	Public Property Nombre() As String
        Get
            Return (m_Nombre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Nombre", Value.ToString(), "Valor inv?lido para SivProductos.Nombre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Nombre = Value
		End Set
    End Property
	
	Public Property Descripcion() As String
        Get
            Return (m_Descripcion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para SivProductos.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_Descripcion = Value
		End Set
    End Property
	
	Public Property objCategoriaID() As Integer
        Get
            Return (m_objCategoriaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objCategoriaID = Value
		End Set
    End Property
	
	Public Property objMarcaID() As Integer
        Get
            Return (m_objMarcaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objMarcaID = Value
		End Set
    End Property
	
	Public Property CostoPromedio() As Nullable(Of Decimal)
        Get
            Return (m_CostoPromedio)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_CostoPromedio = Value
		End Set
    End Property
	
	Public Property Precio_Credito() As Nullable(Of Decimal)
        Get
            Return (m_Precio_Credito)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Precio_Credito = Value
		End Set
    End Property
	
	Public Property Precio_Contado() As Nullable(Of Decimal)
        Get
            Return (m_Precio_Contado)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Precio_Contado = Value
		End Set
    End Property
	
	Public Property Margen_Utilidad_Credito() As Nullable(Of Integer)
        Get
            Return (m_Margen_Utilidad_Credito)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Margen_Utilidad_Credito = Value
		End Set
    End Property
	
	Public Property Margen_Utilidad_Contado() As Nullable(Of Integer)
        Get
            Return (m_Margen_Utilidad_Contado)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Margen_Utilidad_Contado = Value
		End Set
    End Property
	
	Public Property Cantidad_Minima() As Nullable(Of Integer)
        Get
            Return (m_Cantidad_Minima)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Cantidad_Minima = Value
		End Set
    End Property
	
	Public Property Activo() As Boolean
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Boolean)					
			m_Activo = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivProductos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivProductos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Nombre"
				Return	50
			Case "Descripcion"
				Return	100
			Case "CostoPromedio"
				Return	11
			Case "Precio_Credito"
				Return	11
			Case "Precio_Contado"
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
			Case "CostoPromedio"
				Return	2
			Case "Precio_Credito"
				Return	2
			Case "Precio_Contado"
				Return	2
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
			cmdInsert.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100, "Descripcion")
			cmdInsert.Parameters.Add("@objCategoriaID", SqlDbType.Int, 4, "objCategoriaID")
			cmdInsert.Parameters.Add("@objMarcaID", SqlDbType.Int, 4, "objMarcaID")
			cmdInsert.Parameters.Add("@CostoPromedio", SqlDbType.Decimal, 9, "CostoPromedio")
			cmdInsert.Parameters.Add("@Precio_Credito", SqlDbType.Decimal, 9, "Precio_Credito")
			cmdInsert.Parameters.Add("@Precio_Contado", SqlDbType.Decimal, 9, "Precio_Contado")
			cmdInsert.Parameters.Add("@Margen_Utilidad_Credito", SqlDbType.Int, 4, "Margen_Utilidad_Credito")
			cmdInsert.Parameters.Add("@Margen_Utilidad_Contado", SqlDbType.Int, 4, "Margen_Utilidad_Contado")
			cmdInsert.Parameters.Add("@Cantidad_Minima", SqlDbType.Int, 4, "Cantidad_Minima")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SivProductos ( SivProductoID, Nombre, Descripcion, objCategoriaID, objMarcaID, CostoPromedio, Precio_Credito, Precio_Contado, Margen_Utilidad_Credito, Margen_Utilidad_Contado, Cantidad_Minima, Activo, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @SivProductoID, @Nombre, @Descripcion, @objCategoriaID, @objMarcaID, @CostoPromedio, @Precio_Credito, @Precio_Contado, @Margen_Utilidad_Credito, @Margen_Utilidad_Contado, @Cantidad_Minima, @Activo, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@SivProductoID", SqlDbType.Int, 4, "SivProductoID")
			cmdUpdate.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100, "Descripcion")
			cmdUpdate.Parameters.Add("@objCategoriaID", SqlDbType.Int, 4, "objCategoriaID")
			cmdUpdate.Parameters.Add("@objMarcaID", SqlDbType.Int, 4, "objMarcaID")
			cmdUpdate.Parameters.Add("@CostoPromedio", SqlDbType.Decimal, 9, "CostoPromedio")
			cmdUpdate.Parameters.Add("@Precio_Credito", SqlDbType.Decimal, 9, "Precio_Credito")
			cmdUpdate.Parameters.Add("@Precio_Contado", SqlDbType.Decimal, 9, "Precio_Contado")
			cmdUpdate.Parameters.Add("@Margen_Utilidad_Credito", SqlDbType.Int, 4, "Margen_Utilidad_Credito")
			cmdUpdate.Parameters.Add("@Margen_Utilidad_Contado", SqlDbType.Int, 4, "Margen_Utilidad_Contado")
			cmdUpdate.Parameters.Add("@Cantidad_Minima", SqlDbType.Int, 4, "Cantidad_Minima")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSivProductoID", SqlDbType.Int, 4, "SivProductoID")
			cmdUpdate.CommandText = "UPDATE SivProductos SET SivProductoID=@SivProductoID, Nombre=@Nombre, Descripcion=@Descripcion, objCategoriaID=@objCategoriaID, objMarcaID=@objMarcaID, CostoPromedio=@CostoPromedio, Precio_Credito=@Precio_Credito, Precio_Contado=@Precio_Contado, Margen_Utilidad_Credito=@Margen_Utilidad_Credito, Margen_Utilidad_Contado=@Margen_Utilidad_Contado, Cantidad_Minima=@Cantidad_Minima, Activo=@Activo, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SivProductoID= @wSivProductoID"
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
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))					
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))					
				m_objCategoriaID = IIf(IsDBNull(dr("objCategoriaID")), Nothing, dr("objCategoriaID"))					
				m_objMarcaID = IIf(IsDBNull(dr("objMarcaID")), Nothing, dr("objMarcaID"))					
				m_CostoPromedio = IIf(IsDBNull(dr("CostoPromedio")), Nothing, dr("CostoPromedio"))					
				m_Precio_Credito = IIf(IsDBNull(dr("Precio_Credito")), Nothing, dr("Precio_Credito"))					
				m_Precio_Contado = IIf(IsDBNull(dr("Precio_Contado")), Nothing, dr("Precio_Contado"))					
				m_Margen_Utilidad_Credito = IIf(IsDBNull(dr("Margen_Utilidad_Credito")), Nothing, dr("Margen_Utilidad_Credito"))					
				m_Margen_Utilidad_Contado = IIf(IsDBNull(dr("Margen_Utilidad_Contado")), Nothing, dr("Margen_Utilidad_Contado"))					
				m_Cantidad_Minima = IIf(IsDBNull(dr("Cantidad_Minima")), Nothing, dr("Cantidad_Minima"))					
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
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))					
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))					
				m_objCategoriaID = IIf(IsDBNull(dr("objCategoriaID")), Nothing, dr("objCategoriaID"))					
				m_objMarcaID = IIf(IsDBNull(dr("objMarcaID")), Nothing, dr("objMarcaID"))					
				m_CostoPromedio = IIf(IsDBNull(dr("CostoPromedio")), Nothing, dr("CostoPromedio"))					
				m_Precio_Credito = IIf(IsDBNull(dr("Precio_Credito")), Nothing, dr("Precio_Credito"))					
				m_Precio_Contado = IIf(IsDBNull(dr("Precio_Contado")), Nothing, dr("Precio_Contado"))					
				m_Margen_Utilidad_Credito = IIf(IsDBNull(dr("Margen_Utilidad_Credito")), Nothing, dr("Margen_Utilidad_Credito"))					
				m_Margen_Utilidad_Contado = IIf(IsDBNull(dr("Margen_Utilidad_Contado")), Nothing, dr("Margen_Utilidad_Contado"))					
				m_Cantidad_Minima = IIf(IsDBNull(dr("Cantidad_Minima")), Nothing, dr("Cantidad_Minima"))					
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
		sCommand &= "Nombre,"
		sCommand &= "Descripcion,"
		sCommand &= "objCategoriaID,"
		sCommand &= "objMarcaID,"
		sCommand &= "CostoPromedio,"
		sCommand &= "Precio_Credito,"
		sCommand &= "Precio_Contado,"
		sCommand &= "Margen_Utilidad_Credito,"
		sCommand &= "Margen_Utilidad_Contado,"
		sCommand &= "Cantidad_Minima,"
		sCommand &= "Activo,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@SivProductoID,"
		sCommand &= "@Nombre,"
		sCommand &= "@Descripcion,"
		sCommand &= "@objCategoriaID,"
		sCommand &= "@objMarcaID,"
		sCommand &= "@CostoPromedio,"
		sCommand &= "@Precio_Credito,"
		sCommand &= "@Precio_Contado,"
		sCommand &= "@Margen_Utilidad_Credito,"
		sCommand &= "@Margen_Utilidad_Contado,"
		sCommand &= "@Cantidad_Minima,"
		sCommand &= "@Activo,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
		
		Dim arParams(15) As SqlParameter
		arParams(0) = New SqlParameter("@SivProductoID", SqlDbType.Int)		
		If IsDBNull(m_SivProductoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivProductoID
        End If
		arParams(1) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre
        End If
		arParams(2) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Descripcion
        End If
		arParams(3) = New SqlParameter("@objCategoriaID", SqlDbType.Int)		
		If IsDBNull(m_objCategoriaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCategoriaID
        End If
		arParams(4) = New SqlParameter("@objMarcaID", SqlDbType.Int)		
		If IsDBNull(m_objMarcaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objMarcaID
        End If
		arParams(5) = New SqlParameter("@CostoPromedio", SqlDbType.Decimal)		
		If IsDBNull(m_CostoPromedio) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_CostoPromedio
        End If
		arParams(6) = New SqlParameter("@Precio_Credito", SqlDbType.Decimal)		
		If IsDBNull(m_Precio_Credito) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Precio_Credito
        End If
		arParams(7) = New SqlParameter("@Precio_Contado", SqlDbType.Decimal)		
		If IsDBNull(m_Precio_Contado) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Precio_Contado
        End If
		arParams(8) = New SqlParameter("@Margen_Utilidad_Credito", SqlDbType.Int)		
		If IsDBNull(m_Margen_Utilidad_Credito) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Margen_Utilidad_Credito
        End If
		arParams(9) = New SqlParameter("@Margen_Utilidad_Contado", SqlDbType.Int)		
		If IsDBNull(m_Margen_Utilidad_Contado) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Margen_Utilidad_Contado
        End If
		arParams(10) = New SqlParameter("@Cantidad_Minima", SqlDbType.Int)		
		If IsDBNull(m_Cantidad_Minima) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Cantidad_Minima
        End If
		arParams(11) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Activo
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
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivProductos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivProductos set "		
		sCommand &= "SivProductoID = @SivProductoID,"
		sCommand &= "Nombre = @Nombre,"
		sCommand &= "Descripcion = @Descripcion,"
		sCommand &= "objCategoriaID = @objCategoriaID,"
		sCommand &= "objMarcaID = @objMarcaID,"
		sCommand &= "CostoPromedio = @CostoPromedio,"
		sCommand &= "Precio_Credito = @Precio_Credito,"
		sCommand &= "Precio_Contado = @Precio_Contado,"
		sCommand &= "Margen_Utilidad_Credito = @Margen_Utilidad_Credito,"
		sCommand &= "Margen_Utilidad_Contado = @Margen_Utilidad_Contado,"
		sCommand &= "Cantidad_Minima = @Cantidad_Minima,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SivProductoID = @SivProductoID"					
		
		Dim arParams(15) As SqlParameter
		arParams(0) = New SqlParameter("@SivProductoID", SqlDbType.Int)		
		If IsDBNull(m_SivProductoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivProductoID
        End If
		arParams(1) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre
        End If
		arParams(2) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Descripcion
        End If
		arParams(3) = New SqlParameter("@objCategoriaID", SqlDbType.Int)		
		If IsDBNull(m_objCategoriaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCategoriaID
        End If
		arParams(4) = New SqlParameter("@objMarcaID", SqlDbType.Int)		
		If IsDBNull(m_objMarcaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objMarcaID
        End If
		arParams(5) = New SqlParameter("@CostoPromedio", SqlDbType.Decimal)		
		If IsDBNull(m_CostoPromedio) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_CostoPromedio
        End If
		arParams(6) = New SqlParameter("@Precio_Credito", SqlDbType.Decimal)		
		If IsDBNull(m_Precio_Credito) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Precio_Credito
        End If
		arParams(7) = New SqlParameter("@Precio_Contado", SqlDbType.Decimal)		
		If IsDBNull(m_Precio_Contado) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Precio_Contado
        End If
		arParams(8) = New SqlParameter("@Margen_Utilidad_Credito", SqlDbType.Int)		
		If IsDBNull(m_Margen_Utilidad_Credito) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Margen_Utilidad_Credito
        End If
		arParams(9) = New SqlParameter("@Margen_Utilidad_Contado", SqlDbType.Int)		
		If IsDBNull(m_Margen_Utilidad_Contado) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Margen_Utilidad_Contado
        End If
		arParams(10) = New SqlParameter("@Cantidad_Minima", SqlDbType.Int)		
		If IsDBNull(m_Cantidad_Minima) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Cantidad_Minima
        End If
		arParams(11) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Activo
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
