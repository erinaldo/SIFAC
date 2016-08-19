Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class StbRutas		

#Region " Variables Miembro " 
	Protected m_StbRutaID As Integer 
	Protected m_Codigo As String = Nothing 
	Protected m_Nombre As String = Nothing 
	Protected m_objCobradorID As Nullable(Of Integer) 
	Protected m_objSupervisor As Nullable(Of Integer) 
	Protected m_DiaCobro As String = Nothing 
	Protected m_objPaisID As Nullable(Of Integer) 
	Protected m_objCiudadID As Nullable(Of Integer) 
	Protected m_CargarDiferenciada As Nullable(Of Boolean) 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_Descripcion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property StbRutaID() As Integer
        Get
            Return (m_StbRutaID)
        End Get
		Set(ByVal Value As Integer)					
			m_StbRutaID = Value
		End Set
    End Property
	
	Public Property Codigo() As String
        Get
            Return (m_Codigo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Codigo", Value.ToString(), "Valor inv?lido para StbRutas.Codigo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Codigo = Value
		End Set
    End Property
	
	Public Property Nombre() As String
        Get
            Return (m_Nombre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Nombre", Value.ToString(), "Valor inv?lido para StbRutas.Nombre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Nombre = Value
		End Set
    End Property
	
	Public Property objCobradorID() As Nullable(Of Integer)
        Get
            Return (m_objCobradorID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCobradorID = Value
		End Set
    End Property
	
	Public Property objSupervisor() As Nullable(Of Integer)
        Get
            Return (m_objSupervisor)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSupervisor = Value
		End Set
    End Property
	
	Public Property DiaCobro() As String
        Get
            Return (m_DiaCobro)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 20 Then
					Throw New ArgumentOutOfRangeException("DiaCobro", Value.ToString(), "Valor inv?lido para StbRutas.DiaCobro. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (20).")
				End If
			End If
			m_DiaCobro = Value
		End Set
    End Property
	
	Public Property objPaisID() As Nullable(Of Integer)
        Get
            Return (m_objPaisID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objPaisID = Value
		End Set
    End Property
	
	Public Property objCiudadID() As Nullable(Of Integer)
        Get
            Return (m_objCiudadID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCiudadID = Value
		End Set
    End Property
	
	Public Property CargarDiferenciada() As Nullable(Of Boolean)
        Get
            Return (m_CargarDiferenciada)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_CargarDiferenciada = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para StbRutas.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para StbRutas.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property Descripcion() As String
        Get
            Return (m_Descripcion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para StbRutas.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_Descripcion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Codigo"
				Return	50
			Case "Nombre"
				Return	50
			Case "DiaCobro"
				Return	20
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case "Descripcion"
				Return	100
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
    ''' Salva un DataSet del tipo de la tabla StbRutas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla StbRutas </param>    
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
			cmdDelete.Parameters.Add("@StbRutaID", SqlDbType.Int, 4, "StbRutaID" )
			cmdDelete.CommandText = "DELETE FROM  StbRutas WHERE StbRutaID= @StbRutaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo")
			cmdInsert.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdInsert.Parameters.Add("@objCobradorID", SqlDbType.Int, 4, "objCobradorID")
			cmdInsert.Parameters.Add("@objSupervisor", SqlDbType.Int, 4, "objSupervisor")
			cmdInsert.Parameters.Add("@DiaCobro", SqlDbType.VarChar, 20, "DiaCobro")
			cmdInsert.Parameters.Add("@objPaisID", SqlDbType.Int, 4, "objPaisID")
			cmdInsert.Parameters.Add("@objCiudadID", SqlDbType.Int, 4, "objCiudadID")
			cmdInsert.Parameters.Add("@CargarDiferenciada", SqlDbType.Bit, 1, "CargarDiferenciada")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100, "Descripcion")
			cmdInsert.CommandText = "INSERT INTO StbRutas ( Codigo, Nombre, objCobradorID, objSupervisor, DiaCobro, objPaisID, objCiudadID, CargarDiferenciada, Activa, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Descripcion) VALUES ( @Codigo, @Nombre, @objCobradorID, @objSupervisor, @DiaCobro, @objPaisID, @objCiudadID, @CargarDiferenciada, @Activa, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Descripcion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo")
			cmdUpdate.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdUpdate.Parameters.Add("@objCobradorID", SqlDbType.Int, 4, "objCobradorID")
			cmdUpdate.Parameters.Add("@objSupervisor", SqlDbType.Int, 4, "objSupervisor")
			cmdUpdate.Parameters.Add("@DiaCobro", SqlDbType.VarChar, 20, "DiaCobro")
			cmdUpdate.Parameters.Add("@objPaisID", SqlDbType.Int, 4, "objPaisID")
			cmdUpdate.Parameters.Add("@objCiudadID", SqlDbType.Int, 4, "objCiudadID")
			cmdUpdate.Parameters.Add("@CargarDiferenciada", SqlDbType.Bit, 1, "CargarDiferenciada")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100, "Descripcion")
			cmdUpdate.Parameters.Add("@wStbRutaID", SqlDbType.Int, 4, "StbRutaID")
			cmdUpdate.CommandText = "UPDATE StbRutas SET Codigo=@Codigo, Nombre=@Nombre, objCobradorID=@objCobradorID, objSupervisor=@objSupervisor, DiaCobro=@DiaCobro, objPaisID=@objPaisID, objCiudadID=@objCiudadID, CargarDiferenciada=@CargarDiferenciada, Activa=@Activa, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Descripcion=@Descripcion WHERE StbRutaID= @wStbRutaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "StbRutas")
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
    ''' Devuelve de la base de datos un objeto StbRutas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_StbRutaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbRutas where " & " StbRutaID = " & p_StbRutaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_StbRutaID = dr("StbRutaID")
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))					
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))					
				m_objCobradorID = IIf(IsDBNull(dr("objCobradorID")), Nothing, dr("objCobradorID"))					
				m_objSupervisor = IIf(IsDBNull(dr("objSupervisor")), Nothing, dr("objSupervisor"))					
				m_DiaCobro = IIf(IsDBNull(dr("DiaCobro")), Nothing, dr("DiaCobro"))					
				m_objPaisID = IIf(IsDBNull(dr("objPaisID")), Nothing, dr("objPaisID"))					
				m_objCiudadID = IIf(IsDBNull(dr("objCiudadID")), Nothing, dr("objCiudadID"))					
				m_CargarDiferenciada = IIf(IsDBNull(dr("CargarDiferenciada")), Nothing, dr("CargarDiferenciada"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))					
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
    ''' Devuelve de la base de datos un objeto StbRutas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbRutas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_StbRutaID = dr("StbRutaID")
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))					
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))					
				m_objCobradorID = IIf(IsDBNull(dr("objCobradorID")), Nothing, dr("objCobradorID"))					
				m_objSupervisor = IIf(IsDBNull(dr("objSupervisor")), Nothing, dr("objSupervisor"))					
				m_DiaCobro = IIf(IsDBNull(dr("DiaCobro")), Nothing, dr("DiaCobro"))					
				m_objPaisID = IIf(IsDBNull(dr("objPaisID")), Nothing, dr("objPaisID"))					
				m_objCiudadID = IIf(IsDBNull(dr("objCiudadID")), Nothing, dr("objCiudadID"))					
				m_CargarDiferenciada = IIf(IsDBNull(dr("CargarDiferenciada")), Nothing, dr("CargarDiferenciada"))					
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))					
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
    ''' Trae de la base de datos un conjunto de objetos StbRutas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from StbRutas"

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
			ds.Tables(0).TableName = "StbRutas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbRutas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from StbRutas"

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
			ds.Tables(0).TableName = "StbRutas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbRutas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from StbRutas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase StbRutas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into StbRutas("
		sCommand &= "Codigo,"
		sCommand &= "Nombre,"
		sCommand &= "objCobradorID,"
		sCommand &= "objSupervisor,"
		sCommand &= "DiaCobro,"
		sCommand &= "objPaisID,"
		sCommand &= "objCiudadID,"
		sCommand &= "CargarDiferenciada,"
		sCommand &= "Activa,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "Descripcion) values ("		
		sCommand &= "@Codigo,"
		sCommand &= "@Nombre,"
		sCommand &= "@objCobradorID,"
		sCommand &= "@objSupervisor,"
		sCommand &= "@DiaCobro,"
		sCommand &= "@objPaisID,"
		sCommand &= "@objCiudadID,"
		sCommand &= "@CargarDiferenciada,"
		sCommand &= "@Activa,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@Descripcion)"		
	
		sCommand &= " select "
		sCommand &= "@StbRutaID = StbRutaID from StbRutas where "		
		sCommand &= "StbRutaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@StbRutaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Codigo
        End If
		arParams(2) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre
        End If
		arParams(3) = New SqlParameter("@objCobradorID", SqlDbType.Int)		
		If IsDBNull(m_objCobradorID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCobradorID
        End If
		arParams(4) = New SqlParameter("@objSupervisor", SqlDbType.Int)		
		If IsDBNull(m_objSupervisor) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objSupervisor
        End If
		arParams(5) = New SqlParameter("@DiaCobro", SqlDbType.VarChar)		
		If IsDBNull(m_DiaCobro) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_DiaCobro
        End If
		arParams(6) = New SqlParameter("@objPaisID", SqlDbType.Int)		
		If IsDBNull(m_objPaisID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objPaisID
        End If
		arParams(7) = New SqlParameter("@objCiudadID", SqlDbType.Int)		
		If IsDBNull(m_objCiudadID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objCiudadID
        End If
		arParams(8) = New SqlParameter("@CargarDiferenciada", SqlDbType.Bit)		
		If IsDBNull(m_CargarDiferenciada) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_CargarDiferenciada
        End If
		arParams(9) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Activa
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
		arParams(14) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Descripcion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_StbRutaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto StbRutas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update StbRutas set "		
		sCommand &= "Codigo = @Codigo,"
		sCommand &= "Nombre = @Nombre,"
		sCommand &= "objCobradorID = @objCobradorID,"
		sCommand &= "objSupervisor = @objSupervisor,"
		sCommand &= "DiaCobro = @DiaCobro,"
		sCommand &= "objPaisID = @objPaisID,"
		sCommand &= "objCiudadID = @objCiudadID,"
		sCommand &= "CargarDiferenciada = @CargarDiferenciada,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "Descripcion = @Descripcion"		
		sCommand &= " where "	
		sCommand &= "StbRutaID = @StbRutaID"					
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@StbRutaID", SqlDbType.Int)		
		If IsDBNull(m_StbRutaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_StbRutaID
        End If
		arParams(1) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Codigo
        End If
		arParams(2) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre
        End If
		arParams(3) = New SqlParameter("@objCobradorID", SqlDbType.Int)		
		If IsDBNull(m_objCobradorID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCobradorID
        End If
		arParams(4) = New SqlParameter("@objSupervisor", SqlDbType.Int)		
		If IsDBNull(m_objSupervisor) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objSupervisor
        End If
		arParams(5) = New SqlParameter("@DiaCobro", SqlDbType.VarChar)		
		If IsDBNull(m_DiaCobro) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_DiaCobro
        End If
		arParams(6) = New SqlParameter("@objPaisID", SqlDbType.Int)		
		If IsDBNull(m_objPaisID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objPaisID
        End If
		arParams(7) = New SqlParameter("@objCiudadID", SqlDbType.Int)		
		If IsDBNull(m_objCiudadID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objCiudadID
        End If
		arParams(8) = New SqlParameter("@CargarDiferenciada", SqlDbType.Bit)		
		If IsDBNull(m_CargarDiferenciada) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_CargarDiferenciada
        End If
		arParams(9) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Activa
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
		arParams(14) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Descripcion
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
    ''' Borra un objeto StbRutas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbRutas where " & " StbRutaID = " & m_StbRutaID
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
    ''' Borra un objeto StbRutas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_StbRutaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbRutas where " & " StbRutaID = " & p_StbRutaID
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
    ''' Borra objetos StbRutas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbRutas where " & pWhere
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
