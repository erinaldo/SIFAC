Imports DAL
Imports System.Data.SqlClient

''' <summary>
''' Acciones disponibles dentro de un servicio espec?fico. Por ejemplo: Agregar, Editar, Eliminar, Consultar, Imprimir.
''' </summary>
Partial Public Class SsgAccion		

#Region " Variables Miembro " 
	Protected m_SsgAccionID As Integer	
	Protected m_CodInterno As String = Nothing	
	Protected m_Nombre As String = Nothing	
	Protected m_Descripcion As String = Nothing	
	Protected m_UsuarioCreacion As String = Nothing	
	Protected m_FechaCreacion As Date	
	Protected m_UsuarioModificacion As String = Nothing	
	Protected m_FechaModificacion As Nullable(Of Date)	
	Protected m_objServicioUsuarioID As Integer	
#End Region

#Region " Propiedades "
	''' <summary>
	''' Llave Principal de la Tabla SsgAccion
	''' </summary>
	Public Property SsgAccionID() As Integer
        Get
            Return (m_SsgAccionID)
        End Get
		Set(ByVal Value As Integer)					
			m_SsgAccionID = Value
		End Set
    End Property
	
	''' <summary>
	''' C?digo interno para identificar la acci?n. Varchar (50). No permite Null.
	''' </summary>
	Public Property CodInterno() As String
        Get
            Return (m_CodInterno)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("CodInterno", Value.ToString(), "Valor inv?lido para SsgAccion.CodInterno. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_CodInterno = Value
		End Set
    End Property
	
	''' <summary>
	''' Nombre de la acci?n. Varchar (100). No permite Null.
	''' </summary>
	Public Property Nombre() As String
        Get
            Return (m_Nombre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("Nombre", Value.ToString(), "Valor inv?lido para SsgAccion.Nombre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_Nombre = Value
		End Set
    End Property
	
	''' <summary>
	''' Descripci?n general de la acci?n. Varchar (255). Permite Null.
	''' </summary>
	Public Property Descripcion() As String
        Get
            Return (m_Descripcion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para SsgAccion.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Descripcion = Value
		End Set
    End Property
	
	''' <summary>
	''' Login del Usuario que cre? el registro. Varchar (30). No permite Null.
	''' </summary>
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SsgAccion.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha en que se cre? el registro. Corresponde a la fecha del servidor de base de datos. No permite Null.
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
	''' Login del ?ltimo usuario que modific? el registro. Varchar (30). Permite Null.
	''' </summary>
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SsgAccion.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	''' <summary>
	''' ?ltima fecha en que se modific? el registro. Corresponde a la fecha del servidor de base de datos. Permite Null, sin embargo al llenarse el dato UsuarioModificacion debe llenarse ?ste tambi?n.
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
	''' ID del Servicio de Usuario (formulario) al que pertenece la acci?n.
	''' </summary>
	Public Property objServicioUsuarioID() As Integer
        Get
            Return (m_objServicioUsuarioID)
        End Get
		Set(ByVal Value As Integer)					
			m_objServicioUsuarioID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "CodInterno"
				Return	50
			Case "Nombre"
				Return	100
			Case "Descripcion"
				Return	255
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SsgAccion en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SsgAccion </param>    
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
			cmdDelete.Parameters.Add("@SsgAccionID", SqlDbType.Int, 4, "SsgAccionID" )
			cmdDelete.CommandText = "DELETE FROM  SsgAccion WHERE SsgAccionID= @SsgAccionID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@CodInterno", SqlDbType.VarChar, 50, "CodInterno")
			cmdInsert.Parameters.Add("@Nombre", SqlDbType.VarChar, 100, "Nombre")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255, "Descripcion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@objServicioUsuarioID", SqlDbType.Int, 4, "objServicioUsuarioID")
			cmdInsert.CommandText = "INSERT INTO SsgAccion ( CodInterno, Nombre, Descripcion, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, objServicioUsuarioID) VALUES ( @CodInterno, @Nombre, @Descripcion, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @objServicioUsuarioID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@CodInterno", SqlDbType.VarChar, 50, "CodInterno")
			cmdUpdate.Parameters.Add("@Nombre", SqlDbType.VarChar, 100, "Nombre")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255, "Descripcion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@objServicioUsuarioID", SqlDbType.Int, 4, "objServicioUsuarioID")
			cmdUpdate.Parameters.Add("@wSsgAccionID", SqlDbType.Int, 4, "SsgAccionID")
			cmdUpdate.CommandText = "UPDATE SsgAccion SET CodInterno=@CodInterno, Nombre=@Nombre, Descripcion=@Descripcion, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, objServicioUsuarioID=@objServicioUsuarioID WHERE SsgAccionID= @wSsgAccionID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SsgAccion")
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
    ''' Devuelve de la base de datos un objeto SsgAccion
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SsgAccionID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SsgAccion where " & " SsgAccionID = " & p_SsgAccionID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SsgAccionID = dr("SsgAccionID")
				m_CodInterno = IIf(IsDBNull(dr("CodInterno")), Nothing, dr("CodInterno"))
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_objServicioUsuarioID = IIf(IsDBNull(dr("objServicioUsuarioID")), Nothing, dr("objServicioUsuarioID"))
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
    ''' Devuelve de la base de datos un objeto SsgAccion usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SsgAccion where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SsgAccionID = dr("SsgAccionID")
				m_CodInterno = IIf(IsDBNull(dr("CodInterno")), Nothing, dr("CodInterno"))
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_objServicioUsuarioID = IIf(IsDBNull(dr("objServicioUsuarioID")), Nothing, dr("objServicioUsuarioID"))
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
    ''' Trae de la base de datos un conjunto de objetos SsgAccion en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SsgAccion"

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
			ds.Tables(0).TableName = "SsgAccion"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SsgAccion en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SsgAccion"

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
			ds.Tables(0).TableName = "SsgAccion"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SsgAccion en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SsgAccion"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SsgAccion.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SsgAccion("
		sCommand &= "CodInterno,"
		sCommand &= "Nombre,"
		sCommand &= "Descripcion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "objServicioUsuarioID) values ("		
		sCommand &= "@CodInterno,"
		sCommand &= "@Nombre,"
		sCommand &= "@Descripcion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@objServicioUsuarioID)"		
	
		sCommand &= " select "
		sCommand &= "@SsgAccionID = SsgAccionID from SsgAccion where "		
		sCommand &= "SsgAccionID = SCOPE_IDENTITY()"
		
		
		Dim arParams(8) As SqlParameter
		arParams(0) = New SqlParameter("@SsgAccionID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@CodInterno", SqlDbType.VarChar)		
		If IsDBNull(m_CodInterno) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_CodInterno
        End If
		arParams(2) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre
        End If
		arParams(3) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Descripcion
        End If
		arParams(4) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_UsuarioCreacion
        End If
		arParams(5) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaCreacion
        End If
		arParams(6) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioModificacion
        End If
		arParams(7) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaModificacion
        End If
		arParams(8) = New SqlParameter("@objServicioUsuarioID", SqlDbType.Int)		
		If IsDBNull(m_objServicioUsuarioID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objServicioUsuarioID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SsgAccionID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SsgAccion en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SsgAccion set "		
		sCommand &= "CodInterno = @CodInterno,"
		sCommand &= "Nombre = @Nombre,"
		sCommand &= "Descripcion = @Descripcion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "objServicioUsuarioID = @objServicioUsuarioID"		
		sCommand &= " where "	
		sCommand &= "SsgAccionID = @SsgAccionID"					
		
		Dim arParams(8) As SqlParameter
		arParams(0) = New SqlParameter("@SsgAccionID", SqlDbType.Int)		
        '--arParams(0).Direction = ParameterDirection.Output
        arParams(0).Value = m_SsgAccionID

		arParams(1) = New SqlParameter("@CodInterno", SqlDbType.VarChar)		
		If IsDBNull(m_CodInterno) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_CodInterno
        End If
		arParams(2) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre
        End If
		arParams(3) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Descripcion
        End If
		arParams(4) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_UsuarioCreacion
        End If
		arParams(5) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaCreacion
        End If
		arParams(6) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioModificacion
        End If
		arParams(7) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaModificacion
        End If
		arParams(8) = New SqlParameter("@objServicioUsuarioID", SqlDbType.Int)		
		If IsDBNull(m_objServicioUsuarioID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objServicioUsuarioID
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
    ''' Borra un objeto SsgAccion de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SsgAccion where " & " SsgAccionID = " & m_SsgAccionID
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
    ''' Borra un objeto SsgAccion de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SsgAccionID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SsgAccion where " & " SsgAccionID = " & p_SsgAccionID
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
    ''' Borra objetos SsgAccion de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SsgAccion where " & pWhere
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
