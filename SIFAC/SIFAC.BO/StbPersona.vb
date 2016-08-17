Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

''' <summary>
''' Almacén principal de datos de personas
''' </summary>
Partial Public Class StbPersona		

#Region " Variables Miembro " 
	Protected m_StbPersonaID As Integer 
	Protected m_Nombre1 As String = Nothing 
	Protected m_Nombre2 As String = Nothing 
	Protected m_Apellido1 As String = Nothing 
	Protected m_Apellido2 As String = Nothing 
	Protected m_objGeneroID As Nullable(Of Integer) 
	Protected m_Cedula As String = Nothing 
	Protected m_objPaisID As Nullable(Of Integer) 
	Protected m_objCiudadID As Nullable(Of Integer) 
	Protected m_Direccion As String = Nothing 
	Protected m_FechaNacimiento As Nullable(Of Date) 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_PersonaJuridica As Boolean 
	Protected m_RazonSocial As String = Nothing 
	Protected m_SiglasEmpresa As String = Nothing 
	Protected m_RUC As String = Nothing 
#End Region

#Region " Propiedades "
	''' <summary>
	''' Llave primaria, identificador único de personas.
	''' </summary>
	Public Property StbPersonaID() As Integer
        Get
            Return (m_StbPersonaID)
        End Get
		Set(ByVal Value As Integer)					
			m_StbPersonaID = Value
		End Set
    End Property
	
	''' <summary>
	''' 1er Nombre de la Persona
	''' </summary>
	Public Property Nombre1() As String
        Get
            Return (m_Nombre1)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Nombre1", Value.ToString(), "Valor inv?lido para StbPersona.Nombre1. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Nombre1 = Value
		End Set
    End Property
	
	''' <summary>
	''' 2do Nombre de la Persona
	''' </summary>
	Public Property Nombre2() As String
        Get
            Return (m_Nombre2)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Nombre2", Value.ToString(), "Valor inv?lido para StbPersona.Nombre2. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Nombre2 = Value
		End Set
    End Property
	
	''' <summary>
	''' 1er Apellido de Persona
	''' </summary>
	Public Property Apellido1() As String
        Get
            Return (m_Apellido1)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Apellido1", Value.ToString(), "Valor inv?lido para StbPersona.Apellido1. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Apellido1 = Value
		End Set
    End Property
	
	''' <summary>
	''' 2do Apellido de Persona
	''' </summary>
	Public Property Apellido2() As String
        Get
            Return (m_Apellido2)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Apellido2", Value.ToString(), "Valor inv?lido para StbPersona.Apellido2. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Apellido2 = Value
		End Set
    End Property
	
	''' <summary>
	''' Id del género de la persona.
	''' </summary>
	Public Property objGeneroID() As Nullable(Of Integer)
        Get
            Return (m_objGeneroID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objGeneroID = Value
		End Set
    End Property
	
	''' <summary>
	''' Número de cédula
	''' </summary>
	Public Property Cedula() As String
        Get
            Return (m_Cedula)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 16 Then
					Throw New ArgumentOutOfRangeException("Cedula", Value.ToString(), "Valor inv?lido para StbPersona.Cedula. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (16).")
				End If
			End If
			m_Cedula = Value
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
	
	Public Property Direccion() As String
        Get
            Return (m_Direccion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("Direccion", Value.ToString(), "Valor inv?lido para StbPersona.Direccion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_Direccion = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de nacimiento
	''' </summary>
	Public Property FechaNacimiento() As Nullable(Of Date)
        Get
            Return (m_FechaNacimiento)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaNacimiento = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de creación del registro
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
	''' Usuario creador del registro
	''' </summary>
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 45 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para StbPersona.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (45).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de modificación del registro
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
	''' Usuario modificador del registro.
	''' </summary>
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para StbPersona.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property PersonaJuridica() As Boolean
        Get
            Return (m_PersonaJuridica)
        End Get
		Set(ByVal Value As Boolean)					
			m_PersonaJuridica = Value
		End Set
    End Property
	
	Public Property RazonSocial() As String
        Get
            Return (m_RazonSocial)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("RazonSocial", Value.ToString(), "Valor inv?lido para StbPersona.RazonSocial. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_RazonSocial = Value
		End Set
    End Property
	
	Public Property SiglasEmpresa() As String
        Get
            Return (m_SiglasEmpresa)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("SiglasEmpresa", Value.ToString(), "Valor inv?lido para StbPersona.SiglasEmpresa. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_SiglasEmpresa = Value
		End Set
    End Property
	
	Public Property RUC() As String
        Get
            Return (m_RUC)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 16 Then
					Throw New ArgumentOutOfRangeException("RUC", Value.ToString(), "Valor inv?lido para StbPersona.RUC. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (16).")
				End If
			End If
			m_RUC = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Nombre1"
				Return	255
			Case "Nombre2"
				Return	255
			Case "Apellido1"
				Return	255
			Case "Apellido2"
				Return	255
			Case "Cedula"
				Return	16
			Case "Direccion"
				Return	150
			Case "UsuarioCreacion"
				Return	45
			Case "UsuarioModificacion"
				Return	30
			Case "RazonSocial"
				Return	255
			Case "SiglasEmpresa"
				Return	255
			Case "RUC"
				Return	16
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
    ''' Salva un DataSet del tipo de la tabla StbPersona en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla StbPersona </param>    
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
			cmdDelete.Parameters.Add("@StbPersonaID", SqlDbType.Int, 4, "StbPersonaID" )
			cmdDelete.CommandText = "DELETE FROM  StbPersona WHERE StbPersonaID= @StbPersonaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Nombre1", SqlDbType.VarChar, 255, "Nombre1")
			cmdInsert.Parameters.Add("@Nombre2", SqlDbType.VarChar, 255, "Nombre2")
			cmdInsert.Parameters.Add("@Apellido1", SqlDbType.VarChar, 255, "Apellido1")
			cmdInsert.Parameters.Add("@Apellido2", SqlDbType.VarChar, 255, "Apellido2")
			cmdInsert.Parameters.Add("@objGeneroID", SqlDbType.Int, 4, "objGeneroID")
			cmdInsert.Parameters.Add("@Cedula", SqlDbType.VarChar, 16, "Cedula")
			cmdInsert.Parameters.Add("@objPaisID", SqlDbType.Int, 4, "objPaisID")
			cmdInsert.Parameters.Add("@objCiudadID", SqlDbType.Int, 4, "objCiudadID")
			cmdInsert.Parameters.Add("@Direccion", SqlDbType.VarChar, 150, "Direccion")
			cmdInsert.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime, 8, "FechaNacimiento")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 45, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@PersonaJuridica", SqlDbType.Bit, 1, "PersonaJuridica")
			cmdInsert.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 255, "RazonSocial")
			cmdInsert.Parameters.Add("@SiglasEmpresa", SqlDbType.VarChar, 255, "SiglasEmpresa")
			cmdInsert.Parameters.Add("@RUC", SqlDbType.VarChar, 16, "RUC")
			cmdInsert.CommandText = "INSERT INTO StbPersona ( Nombre1, Nombre2, Apellido1, Apellido2, objGeneroID, Cedula, objPaisID, objCiudadID, Direccion, FechaNacimiento, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, PersonaJuridica, RazonSocial, SiglasEmpresa, RUC) VALUES ( @Nombre1, @Nombre2, @Apellido1, @Apellido2, @objGeneroID, @Cedula, @objPaisID, @objCiudadID, @Direccion, @FechaNacimiento, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @PersonaJuridica, @RazonSocial, @SiglasEmpresa, @RUC)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Nombre1", SqlDbType.VarChar, 255, "Nombre1")
			cmdUpdate.Parameters.Add("@Nombre2", SqlDbType.VarChar, 255, "Nombre2")
			cmdUpdate.Parameters.Add("@Apellido1", SqlDbType.VarChar, 255, "Apellido1")
			cmdUpdate.Parameters.Add("@Apellido2", SqlDbType.VarChar, 255, "Apellido2")
			cmdUpdate.Parameters.Add("@objGeneroID", SqlDbType.Int, 4, "objGeneroID")
			cmdUpdate.Parameters.Add("@Cedula", SqlDbType.VarChar, 16, "Cedula")
			cmdUpdate.Parameters.Add("@objPaisID", SqlDbType.Int, 4, "objPaisID")
			cmdUpdate.Parameters.Add("@objCiudadID", SqlDbType.Int, 4, "objCiudadID")
			cmdUpdate.Parameters.Add("@Direccion", SqlDbType.VarChar, 150, "Direccion")
			cmdUpdate.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime, 8, "FechaNacimiento")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 45, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@PersonaJuridica", SqlDbType.Bit, 1, "PersonaJuridica")
			cmdUpdate.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 255, "RazonSocial")
			cmdUpdate.Parameters.Add("@SiglasEmpresa", SqlDbType.VarChar, 255, "SiglasEmpresa")
			cmdUpdate.Parameters.Add("@RUC", SqlDbType.VarChar, 16, "RUC")
			cmdUpdate.Parameters.Add("@wStbPersonaID", SqlDbType.Int, 4, "StbPersonaID")
			cmdUpdate.CommandText = "UPDATE StbPersona SET Nombre1=@Nombre1, Nombre2=@Nombre2, Apellido1=@Apellido1, Apellido2=@Apellido2, objGeneroID=@objGeneroID, Cedula=@Cedula, objPaisID=@objPaisID, objCiudadID=@objCiudadID, Direccion=@Direccion, FechaNacimiento=@FechaNacimiento, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, PersonaJuridica=@PersonaJuridica, RazonSocial=@RazonSocial, SiglasEmpresa=@SiglasEmpresa, RUC=@RUC WHERE StbPersonaID= @wStbPersonaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "StbPersona")
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
    ''' Devuelve de la base de datos un objeto StbPersona
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_StbPersonaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbPersona where " & " StbPersonaID = " & p_StbPersonaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_StbPersonaID = dr("StbPersonaID")
				m_Nombre1 = IIf(IsDBNull(dr("Nombre1")), Nothing, dr("Nombre1"))					
				m_Nombre2 = IIf(IsDBNull(dr("Nombre2")), Nothing, dr("Nombre2"))					
				m_Apellido1 = IIf(IsDBNull(dr("Apellido1")), Nothing, dr("Apellido1"))					
				m_Apellido2 = IIf(IsDBNull(dr("Apellido2")), Nothing, dr("Apellido2"))					
				m_objGeneroID = IIf(IsDBNull(dr("objGeneroID")), Nothing, dr("objGeneroID"))					
				m_Cedula = IIf(IsDBNull(dr("Cedula")), Nothing, dr("Cedula"))					
				m_objPaisID = IIf(IsDBNull(dr("objPaisID")), Nothing, dr("objPaisID"))					
				m_objCiudadID = IIf(IsDBNull(dr("objCiudadID")), Nothing, dr("objCiudadID"))					
				m_Direccion = IIf(IsDBNull(dr("Direccion")), Nothing, dr("Direccion"))					
				m_FechaNacimiento = IIf(IsDBNull(dr("FechaNacimiento")), Nothing, dr("FechaNacimiento"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_PersonaJuridica = IIf(IsDBNull(dr("PersonaJuridica")), Nothing, dr("PersonaJuridica"))					
				m_RazonSocial = IIf(IsDBNull(dr("RazonSocial")), Nothing, dr("RazonSocial"))					
				m_SiglasEmpresa = IIf(IsDBNull(dr("SiglasEmpresa")), Nothing, dr("SiglasEmpresa"))					
				m_RUC = IIf(IsDBNull(dr("RUC")), Nothing, dr("RUC"))					
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
    ''' Devuelve de la base de datos un objeto StbPersona usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbPersona where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_StbPersonaID = dr("StbPersonaID")
				m_Nombre1 = IIf(IsDBNull(dr("Nombre1")), Nothing, dr("Nombre1"))					
				m_Nombre2 = IIf(IsDBNull(dr("Nombre2")), Nothing, dr("Nombre2"))					
				m_Apellido1 = IIf(IsDBNull(dr("Apellido1")), Nothing, dr("Apellido1"))					
				m_Apellido2 = IIf(IsDBNull(dr("Apellido2")), Nothing, dr("Apellido2"))					
				m_objGeneroID = IIf(IsDBNull(dr("objGeneroID")), Nothing, dr("objGeneroID"))					
				m_Cedula = IIf(IsDBNull(dr("Cedula")), Nothing, dr("Cedula"))					
				m_objPaisID = IIf(IsDBNull(dr("objPaisID")), Nothing, dr("objPaisID"))					
				m_objCiudadID = IIf(IsDBNull(dr("objCiudadID")), Nothing, dr("objCiudadID"))					
				m_Direccion = IIf(IsDBNull(dr("Direccion")), Nothing, dr("Direccion"))					
				m_FechaNacimiento = IIf(IsDBNull(dr("FechaNacimiento")), Nothing, dr("FechaNacimiento"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_PersonaJuridica = IIf(IsDBNull(dr("PersonaJuridica")), Nothing, dr("PersonaJuridica"))					
				m_RazonSocial = IIf(IsDBNull(dr("RazonSocial")), Nothing, dr("RazonSocial"))					
				m_SiglasEmpresa = IIf(IsDBNull(dr("SiglasEmpresa")), Nothing, dr("SiglasEmpresa"))					
				m_RUC = IIf(IsDBNull(dr("RUC")), Nothing, dr("RUC"))					
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
    ''' Trae de la base de datos un conjunto de objetos StbPersona en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from StbPersona"

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
			ds.Tables(0).TableName = "StbPersona"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbPersona en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from StbPersona"

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
			ds.Tables(0).TableName = "StbPersona"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbPersona en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from StbPersona"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase StbPersona.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into StbPersona("
		sCommand &= "Nombre1,"
		sCommand &= "Nombre2,"
		sCommand &= "Apellido1,"
		sCommand &= "Apellido2,"
		sCommand &= "objGeneroID,"
		sCommand &= "Cedula,"
		sCommand &= "objPaisID,"
		sCommand &= "objCiudadID,"
		sCommand &= "Direccion,"
		sCommand &= "FechaNacimiento,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "PersonaJuridica,"
		sCommand &= "RazonSocial,"
		sCommand &= "SiglasEmpresa,"
		sCommand &= "RUC) values ("		
		sCommand &= "@Nombre1,"
		sCommand &= "@Nombre2,"
		sCommand &= "@Apellido1,"
		sCommand &= "@Apellido2,"
		sCommand &= "@objGeneroID,"
		sCommand &= "@Cedula,"
		sCommand &= "@objPaisID,"
		sCommand &= "@objCiudadID,"
		sCommand &= "@Direccion,"
		sCommand &= "@FechaNacimiento,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@PersonaJuridica,"
		sCommand &= "@RazonSocial,"
		sCommand &= "@SiglasEmpresa,"
		sCommand &= "@RUC)"		
	
		sCommand &= " select "
		sCommand &= "@StbPersonaID = StbPersonaID from StbPersona where "		
		sCommand &= "StbPersonaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(18) As SqlParameter
		arParams(0) = New SqlParameter("@StbPersonaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Nombre1", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre1) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre1
        End If
		arParams(2) = New SqlParameter("@Nombre2", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre2) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre2
        End If
		arParams(3) = New SqlParameter("@Apellido1", SqlDbType.VarChar)		
		If IsDBNull(m_Apellido1) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Apellido1
        End If
		arParams(4) = New SqlParameter("@Apellido2", SqlDbType.VarChar)		
		If IsDBNull(m_Apellido2) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Apellido2
        End If
		arParams(5) = New SqlParameter("@objGeneroID", SqlDbType.Int)		
		If IsDBNull(m_objGeneroID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objGeneroID
        End If
		arParams(6) = New SqlParameter("@Cedula", SqlDbType.VarChar)		
		If IsDBNull(m_Cedula) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Cedula
        End If
		arParams(7) = New SqlParameter("@objPaisID", SqlDbType.Int)		
		If IsDBNull(m_objPaisID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objPaisID
        End If
		arParams(8) = New SqlParameter("@objCiudadID", SqlDbType.Int)		
		If IsDBNull(m_objCiudadID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objCiudadID
        End If
		arParams(9) = New SqlParameter("@Direccion", SqlDbType.VarChar)		
		If IsDBNull(m_Direccion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Direccion
        End If
		arParams(10) = New SqlParameter("@FechaNacimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaNacimiento) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaNacimiento
        End If
		arParams(11) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaCreacion
        End If
		arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
		arParams(13) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaModificacion
        End If
		arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
		arParams(15) = New SqlParameter("@PersonaJuridica", SqlDbType.Bit)		
		If IsDBNull(m_PersonaJuridica) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_PersonaJuridica
        End If
		arParams(16) = New SqlParameter("@RazonSocial", SqlDbType.VarChar)		
		If IsDBNull(m_RazonSocial) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_RazonSocial
        End If
		arParams(17) = New SqlParameter("@SiglasEmpresa", SqlDbType.VarChar)		
		If IsDBNull(m_SiglasEmpresa) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_SiglasEmpresa
        End If
		arParams(18) = New SqlParameter("@RUC", SqlDbType.VarChar)		
		If IsDBNull(m_RUC) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_RUC
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_StbPersonaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto StbPersona en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update StbPersona set "		
		sCommand &= "Nombre1 = @Nombre1,"
		sCommand &= "Nombre2 = @Nombre2,"
		sCommand &= "Apellido1 = @Apellido1,"
		sCommand &= "Apellido2 = @Apellido2,"
		sCommand &= "objGeneroID = @objGeneroID,"
		sCommand &= "Cedula = @Cedula,"
		sCommand &= "objPaisID = @objPaisID,"
		sCommand &= "objCiudadID = @objCiudadID,"
		sCommand &= "Direccion = @Direccion,"
		sCommand &= "FechaNacimiento = @FechaNacimiento,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "PersonaJuridica = @PersonaJuridica,"
		sCommand &= "RazonSocial = @RazonSocial,"
		sCommand &= "SiglasEmpresa = @SiglasEmpresa,"
		sCommand &= "RUC = @RUC"		
		sCommand &= " where "	
		sCommand &= "StbPersonaID = @StbPersonaID"					
		
		Dim arParams(18) As SqlParameter
		arParams(0) = New SqlParameter("@StbPersonaID", SqlDbType.Int)		
		If IsDBNull(m_StbPersonaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_StbPersonaID
        End If
		arParams(1) = New SqlParameter("@Nombre1", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre1) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre1
        End If
		arParams(2) = New SqlParameter("@Nombre2", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre2) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre2
        End If
		arParams(3) = New SqlParameter("@Apellido1", SqlDbType.VarChar)		
		If IsDBNull(m_Apellido1) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Apellido1
        End If
		arParams(4) = New SqlParameter("@Apellido2", SqlDbType.VarChar)		
		If IsDBNull(m_Apellido2) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Apellido2
        End If
		arParams(5) = New SqlParameter("@objGeneroID", SqlDbType.Int)		
		If IsDBNull(m_objGeneroID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objGeneroID
        End If
		arParams(6) = New SqlParameter("@Cedula", SqlDbType.VarChar)		
		If IsDBNull(m_Cedula) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Cedula
        End If
		arParams(7) = New SqlParameter("@objPaisID", SqlDbType.Int)		
		If IsDBNull(m_objPaisID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objPaisID
        End If
		arParams(8) = New SqlParameter("@objCiudadID", SqlDbType.Int)		
		If IsDBNull(m_objCiudadID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objCiudadID
        End If
		arParams(9) = New SqlParameter("@Direccion", SqlDbType.VarChar)		
		If IsDBNull(m_Direccion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Direccion
        End If
		arParams(10) = New SqlParameter("@FechaNacimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaNacimiento) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaNacimiento
        End If
		arParams(11) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaCreacion
        End If
		arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
		arParams(13) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaModificacion
        End If
		arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
		arParams(15) = New SqlParameter("@PersonaJuridica", SqlDbType.Bit)		
		If IsDBNull(m_PersonaJuridica) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_PersonaJuridica
        End If
		arParams(16) = New SqlParameter("@RazonSocial", SqlDbType.VarChar)		
		If IsDBNull(m_RazonSocial) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_RazonSocial
        End If
		arParams(17) = New SqlParameter("@SiglasEmpresa", SqlDbType.VarChar)		
		If IsDBNull(m_SiglasEmpresa) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_SiglasEmpresa
        End If
		arParams(18) = New SqlParameter("@RUC", SqlDbType.VarChar)		
		If IsDBNull(m_RUC) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_RUC
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
    ''' Borra un objeto StbPersona de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbPersona where " & " StbPersonaID = " & m_StbPersonaID
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
    ''' Borra un objeto StbPersona de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_StbPersonaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbPersona where " & " StbPersonaID = " & p_StbPersonaID
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
    ''' Borra objetos StbPersona de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbPersona where " & pWhere
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
