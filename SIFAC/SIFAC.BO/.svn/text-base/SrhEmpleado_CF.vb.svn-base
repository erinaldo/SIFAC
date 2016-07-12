Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

''' <summary>
''' Maestro de Empleados
''' </summary>
Partial Public Class SrhEmpleado		

#Region " Variables Miembro " 
	Protected m_SrhEmpleadoID As Integer 
	Protected m_objPersonaID As String = Nothing 
	Protected m_objCargoID As Integer 
	Protected m_FechaIngreso As Nullable(Of Date) 
	Protected m_FechaEgreso As Nullable(Of Date) 
	Protected m_Activo As Boolean 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_PorcentajeComision As Nullable(Of Decimal) 
#End Region

#Region " Propiedades "
	''' <summary>
	''' ID ?nico del empleado
	''' </summary>
	Public Property SrhEmpleadoID() As Integer
        Get
            Return (m_SrhEmpleadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SrhEmpleadoID = Value
		End Set
    End Property
	
	''' <summary>
	''' ID de la persona.
	''' </summary>
	Public Property objPersonaID() As String
        Get
            Return (m_objPersonaID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 16 Then
					Throw New ArgumentOutOfRangeException("objPersonaID", Value.ToString(), "Valor inv?lido para SrhEmpleado.objPersonaID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (16).")
				End If
			End If
			m_objPersonaID = Value
		End Set
    End Property
	
	''' <summary>
	''' ID del cargo
	''' </summary>
	Public Property objCargoID() As Integer
        Get
            Return (m_objCargoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objCargoID = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de ingreso (alta)
	''' </summary>
	Public Property FechaIngreso() As Nullable(Of Date)
        Get
            Return (m_FechaIngreso)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaIngreso = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de egreso (baja)
	''' </summary>
	Public Property FechaEgreso() As Nullable(Of Date)
        Get
            Return (m_FechaEgreso)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaEgreso = Value
		End Set
    End Property
	
	''' <summary>
	''' Este registro se encuentra activo?
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
	''' Login del Usuario que cre? el registro. Varchar (30). No permite Null.
	''' </summary>
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SrhEmpleado.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha en que se crea la cuenta de usuario. Por defecto es la fecha del sistema. No permite Null.
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SrhEmpleado.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	
	Public Property PorcentajeComision() As Nullable(Of Decimal)
        Get
            Return (m_PorcentajeComision)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_PorcentajeComision = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "objPersonaID"
				Return	16
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case "PorcentajeComision"
				Return	11
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "PorcentajeComision"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SrhEmpleado en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SrhEmpleado </param>    
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
			cmdDelete.Parameters.Add("@SrhEmpleadoID", SqlDbType.Int, 4, "SrhEmpleadoID" )
			cmdDelete.CommandText = "DELETE FROM  SrhEmpleado WHERE SrhEmpleadoID= @SrhEmpleadoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objPersonaID", SqlDbType.VarChar, 16, "objPersonaID")
			cmdInsert.Parameters.Add("@objCargoID", SqlDbType.Int, 4, "objCargoID")
			cmdInsert.Parameters.Add("@FechaIngreso", SqlDbType.DateTime, 8, "FechaIngreso")
			cmdInsert.Parameters.Add("@FechaEgreso", SqlDbType.DateTime, 8, "FechaEgreso")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@PorcentajeComision", SqlDbType.Decimal, 9, "PorcentajeComision")
			cmdInsert.CommandText = "INSERT INTO SrhEmpleado ( objPersonaID, objCargoID, FechaIngreso, FechaEgreso, Activo, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, PorcentajeComision) VALUES ( @objPersonaID, @objCargoID, @FechaIngreso, @FechaEgreso, @Activo, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @PorcentajeComision)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objPersonaID", SqlDbType.VarChar, 16, "objPersonaID")
			cmdUpdate.Parameters.Add("@objCargoID", SqlDbType.Int, 4, "objCargoID")
			cmdUpdate.Parameters.Add("@FechaIngreso", SqlDbType.DateTime, 8, "FechaIngreso")
			cmdUpdate.Parameters.Add("@FechaEgreso", SqlDbType.DateTime, 8, "FechaEgreso")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@PorcentajeComision", SqlDbType.Decimal, 9, "PorcentajeComision")
			cmdUpdate.Parameters.Add("@wSrhEmpleadoID", SqlDbType.Int, 4, "SrhEmpleadoID")
			cmdUpdate.CommandText = "UPDATE SrhEmpleado SET objPersonaID=@objPersonaID, objCargoID=@objCargoID, FechaIngreso=@FechaIngreso, FechaEgreso=@FechaEgreso, Activo=@Activo, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, PorcentajeComision=@PorcentajeComision WHERE SrhEmpleadoID= @wSrhEmpleadoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SrhEmpleado")
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
    ''' Devuelve de la base de datos un objeto SrhEmpleado
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SrhEmpleadoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SrhEmpleado where " & " SrhEmpleadoID = " & p_SrhEmpleadoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SrhEmpleadoID = dr("SrhEmpleadoID")
				m_objPersonaID = IIf(IsDBNull(dr("objPersonaID")), Nothing, dr("objPersonaID"))					
				m_objCargoID = IIf(IsDBNull(dr("objCargoID")), Nothing, dr("objCargoID"))					
				m_FechaIngreso = IIf(IsDBNull(dr("FechaIngreso")), Nothing, dr("FechaIngreso"))					
				m_FechaEgreso = IIf(IsDBNull(dr("FechaEgreso")), Nothing, dr("FechaEgreso"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_PorcentajeComision = IIf(IsDBNull(dr("PorcentajeComision")), Nothing, dr("PorcentajeComision"))					
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
    ''' Devuelve de la base de datos un objeto SrhEmpleado usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SrhEmpleado where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SrhEmpleadoID = dr("SrhEmpleadoID")
				m_objPersonaID = IIf(IsDBNull(dr("objPersonaID")), Nothing, dr("objPersonaID"))					
				m_objCargoID = IIf(IsDBNull(dr("objCargoID")), Nothing, dr("objCargoID"))					
				m_FechaIngreso = IIf(IsDBNull(dr("FechaIngreso")), Nothing, dr("FechaIngreso"))					
				m_FechaEgreso = IIf(IsDBNull(dr("FechaEgreso")), Nothing, dr("FechaEgreso"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_PorcentajeComision = IIf(IsDBNull(dr("PorcentajeComision")), Nothing, dr("PorcentajeComision"))					
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
    ''' Trae de la base de datos un conjunto de objetos SrhEmpleado en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SrhEmpleado"

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
			ds.Tables(0).TableName = "SrhEmpleado"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SrhEmpleado en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SrhEmpleado"

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
			ds.Tables(0).TableName = "SrhEmpleado"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SrhEmpleado en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SrhEmpleado"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SrhEmpleado.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SrhEmpleado("
		sCommand &= "objPersonaID,"
		sCommand &= "objCargoID,"
		sCommand &= "FechaIngreso,"
		sCommand &= "FechaEgreso,"
		sCommand &= "Activo,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "PorcentajeComision) values ("		
		sCommand &= "@objPersonaID,"
		sCommand &= "@objCargoID,"
		sCommand &= "@FechaIngreso,"
		sCommand &= "@FechaEgreso,"
		sCommand &= "@Activo,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@PorcentajeComision)"		
	
		sCommand &= " select "
		sCommand &= "@SrhEmpleadoID = SrhEmpleadoID from SrhEmpleado where "		
		sCommand &= "SrhEmpleadoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SrhEmpleadoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objPersonaID", SqlDbType.VarChar)		
		If IsDBNull(m_objPersonaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPersonaID
        End If
		arParams(2) = New SqlParameter("@objCargoID", SqlDbType.Int)		
		If IsDBNull(m_objCargoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCargoID
        End If
		arParams(3) = New SqlParameter("@FechaIngreso", SqlDbType.DateTime)		
		If IsDBNull(m_FechaIngreso) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaIngreso
        End If
		arParams(4) = New SqlParameter("@FechaEgreso", SqlDbType.DateTime)		
		If IsDBNull(m_FechaEgreso) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaEgreso
        End If
		arParams(5) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Activo
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
		arParams(10) = New SqlParameter("@PorcentajeComision", SqlDbType.Decimal)		
		If IsDBNull(m_PorcentajeComision) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_PorcentajeComision
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SrhEmpleadoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SrhEmpleado en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SrhEmpleado set "		
		sCommand &= "objPersonaID = @objPersonaID,"
		sCommand &= "objCargoID = @objCargoID,"
		sCommand &= "FechaIngreso = @FechaIngreso,"
		sCommand &= "FechaEgreso = @FechaEgreso,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "PorcentajeComision = @PorcentajeComision"		
		sCommand &= " where "	
		sCommand &= "SrhEmpleadoID = @SrhEmpleadoID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SrhEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_SrhEmpleadoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SrhEmpleadoID
        End If
		arParams(1) = New SqlParameter("@objPersonaID", SqlDbType.VarChar)		
		If IsDBNull(m_objPersonaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPersonaID
        End If
		arParams(2) = New SqlParameter("@objCargoID", SqlDbType.Int)		
		If IsDBNull(m_objCargoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCargoID
        End If
		arParams(3) = New SqlParameter("@FechaIngreso", SqlDbType.DateTime)		
		If IsDBNull(m_FechaIngreso) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaIngreso
        End If
		arParams(4) = New SqlParameter("@FechaEgreso", SqlDbType.DateTime)		
		If IsDBNull(m_FechaEgreso) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaEgreso
        End If
		arParams(5) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Activo
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
		arParams(10) = New SqlParameter("@PorcentajeComision", SqlDbType.Decimal)		
		If IsDBNull(m_PorcentajeComision) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_PorcentajeComision
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
    ''' Borra un objeto SrhEmpleado de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SrhEmpleado where " & " SrhEmpleadoID = " & m_SrhEmpleadoID
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
    ''' Borra un objeto SrhEmpleado de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SrhEmpleadoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SrhEmpleado where " & " SrhEmpleadoID = " & p_SrhEmpleadoID
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
    ''' Borra objetos SrhEmpleado de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SrhEmpleado where " & pWhere
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
