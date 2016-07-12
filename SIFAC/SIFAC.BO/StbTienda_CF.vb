Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class StbTienda		

#Region " Variables Miembro " 
	Protected m_StbTiendaID As Integer 
	Protected m_Nombre As String = Nothing 
	Protected m_Codigo As String = Nothing 
	Protected m_objCiudadID As Integer 
	Protected m_objJefeTiendaID As Integer 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_ActivoRepuesto As Nullable(Of Boolean) 
	Protected m_seriefactura As String = Nothing 
	Protected m_ProximaFactura As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	''' <summary>
	''' ID ?nico interno de la sucursal
	''' </summary>
	Public Property StbTiendaID() As Integer
        Get
            Return (m_StbTiendaID)
        End Get
		Set(ByVal Value As Integer)					
			m_StbTiendaID = Value
		End Set
    End Property
	
	''' <summary>
	''' Nombre de la sucursal
	''' </summary>
	Public Property Nombre() As String
        Get
            Return (m_Nombre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Nombre", Value.ToString(), "Valor inv?lido para StbTienda.Nombre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Nombre = Value
		End Set
    End Property
	
	Public Property Codigo() As String
        Get
            Return (m_Codigo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 4 Then
					Throw New ArgumentOutOfRangeException("Codigo", Value.ToString(), "Valor inv?lido para StbTienda.Codigo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (4).")
				End If
			End If
			m_Codigo = Value
		End Set
    End Property
	
	''' <summary>
	''' ID de la ciudad
	''' </summary>
	Public Property objCiudadID() As Integer
        Get
            Return (m_objCiudadID)
        End Get
		Set(ByVal Value As Integer)					
			m_objCiudadID = Value
		End Set
    End Property
	
	''' <summary>
	''' ID de persona: Empleado correspondiente al jefe de tienda.
	''' </summary>
	Public Property objJefeTiendaID() As Integer
        Get
            Return (m_objJefeTiendaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objJefeTiendaID = Value
		End Set
    End Property
	
	''' <summary>
	''' La tienda se encuentra activa?
	''' </summary>
	Public Property Activo() As Nullable(Of Boolean)
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para StbTienda.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para StbTienda.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property ActivoRepuesto() As Nullable(Of Boolean)
        Get
            Return (m_ActivoRepuesto)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_ActivoRepuesto = Value
		End Set
    End Property
	
	Public Property seriefactura() As String
        Get
            Return (m_seriefactura)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("seriefactura", Value.ToString(), "Valor inv?lido para StbTienda.seriefactura. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_seriefactura = Value
		End Set
    End Property
	
	Public Property ProximaFactura() As Nullable(Of Integer)
        Get
            Return (m_ProximaFactura)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_ProximaFactura = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Nombre"
				Return	50
			Case "Codigo"
				Return	4
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case "seriefactura"
				Return	2
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
    ''' Salva un DataSet del tipo de la tabla StbTienda en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla StbTienda </param>    
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
			cmdDelete.Parameters.Add("@StbTiendaID", SqlDbType.Int, 4, "StbTiendaID" )
			cmdDelete.CommandText = "DELETE FROM  StbTienda WHERE StbTiendaID= @StbTiendaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@StbTiendaID", SqlDbType.Int, 4, "StbTiendaID")
			cmdInsert.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdInsert.Parameters.Add("@Codigo", SqlDbType.VarChar, 4, "Codigo")
			cmdInsert.Parameters.Add("@objCiudadID", SqlDbType.Int, 4, "objCiudadID")
			cmdInsert.Parameters.Add("@objJefeTiendaID", SqlDbType.Int, 4, "objJefeTiendaID")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@ActivoRepuesto", SqlDbType.Bit, 1, "ActivoRepuesto")
			cmdInsert.Parameters.Add("@seriefactura", SqlDbType.VarChar, 2, "seriefactura")
			cmdInsert.Parameters.Add("@ProximaFactura", SqlDbType.Int, 4, "ProximaFactura")
			cmdInsert.CommandText = "INSERT INTO StbTienda ( StbTiendaID, Nombre, Codigo, objCiudadID, objJefeTiendaID, Activo, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, ActivoRepuesto, seriefactura, ProximaFactura) VALUES ( @StbTiendaID, @Nombre, @Codigo, @objCiudadID, @objJefeTiendaID, @Activo, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @ActivoRepuesto, @seriefactura, @ProximaFactura)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@StbTiendaID", SqlDbType.Int, 4, "StbTiendaID")
			cmdUpdate.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre")
			cmdUpdate.Parameters.Add("@Codigo", SqlDbType.VarChar, 4, "Codigo")
			cmdUpdate.Parameters.Add("@objCiudadID", SqlDbType.Int, 4, "objCiudadID")
			cmdUpdate.Parameters.Add("@objJefeTiendaID", SqlDbType.Int, 4, "objJefeTiendaID")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@ActivoRepuesto", SqlDbType.Bit, 1, "ActivoRepuesto")
			cmdUpdate.Parameters.Add("@seriefactura", SqlDbType.VarChar, 2, "seriefactura")
			cmdUpdate.Parameters.Add("@ProximaFactura", SqlDbType.Int, 4, "ProximaFactura")
			cmdUpdate.Parameters.Add("@wStbTiendaID", SqlDbType.Int, 4, "StbTiendaID")
			cmdUpdate.CommandText = "UPDATE StbTienda SET StbTiendaID=@StbTiendaID, Nombre=@Nombre, Codigo=@Codigo, objCiudadID=@objCiudadID, objJefeTiendaID=@objJefeTiendaID, Activo=@Activo, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, ActivoRepuesto=@ActivoRepuesto, seriefactura=@seriefactura, ProximaFactura=@ProximaFactura WHERE StbTiendaID= @wStbTiendaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "StbTienda")
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
    ''' Devuelve de la base de datos un objeto StbTienda
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_StbTiendaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbTienda where " & " StbTiendaID = " & p_StbTiendaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_StbTiendaID = IIf(IsDBNull(dr("StbTiendaID")), Nothing, dr("StbTiendaID"))					
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))					
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))					
				m_objCiudadID = IIf(IsDBNull(dr("objCiudadID")), Nothing, dr("objCiudadID"))					
				m_objJefeTiendaID = IIf(IsDBNull(dr("objJefeTiendaID")), Nothing, dr("objJefeTiendaID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_ActivoRepuesto = IIf(IsDBNull(dr("ActivoRepuesto")), Nothing, dr("ActivoRepuesto"))					
				m_seriefactura = IIf(IsDBNull(dr("seriefactura")), Nothing, dr("seriefactura"))					
				m_ProximaFactura = IIf(IsDBNull(dr("ProximaFactura")), Nothing, dr("ProximaFactura"))					
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
    ''' Devuelve de la base de datos un objeto StbTienda usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbTienda where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_StbTiendaID = IIf(IsDBNull(dr("StbTiendaID")), Nothing, dr("StbTiendaID"))					
				m_Nombre = IIf(IsDBNull(dr("Nombre")), Nothing, dr("Nombre"))					
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))					
				m_objCiudadID = IIf(IsDBNull(dr("objCiudadID")), Nothing, dr("objCiudadID"))					
				m_objJefeTiendaID = IIf(IsDBNull(dr("objJefeTiendaID")), Nothing, dr("objJefeTiendaID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_ActivoRepuesto = IIf(IsDBNull(dr("ActivoRepuesto")), Nothing, dr("ActivoRepuesto"))					
				m_seriefactura = IIf(IsDBNull(dr("seriefactura")), Nothing, dr("seriefactura"))					
				m_ProximaFactura = IIf(IsDBNull(dr("ProximaFactura")), Nothing, dr("ProximaFactura"))					
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
    ''' Trae de la base de datos un conjunto de objetos StbTienda en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from StbTienda"

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
			ds.Tables(0).TableName = "StbTienda"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbTienda en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from StbTienda"

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
			ds.Tables(0).TableName = "StbTienda"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbTienda en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from StbTienda"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase StbTienda.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into StbTienda("
		sCommand &= "StbTiendaID,"
		sCommand &= "Nombre,"
		sCommand &= "Codigo,"
		sCommand &= "objCiudadID,"
		sCommand &= "objJefeTiendaID,"
		sCommand &= "Activo,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "ActivoRepuesto,"
		sCommand &= "seriefactura,"
		sCommand &= "ProximaFactura) values ("		
		sCommand &= "@StbTiendaID,"
		sCommand &= "@Nombre,"
		sCommand &= "@Codigo,"
		sCommand &= "@objCiudadID,"
		sCommand &= "@objJefeTiendaID,"
		sCommand &= "@Activo,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@ActivoRepuesto,"
		sCommand &= "@seriefactura,"
		sCommand &= "@ProximaFactura)"		
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@StbTiendaID", SqlDbType.Int)		
		If IsDBNull(m_StbTiendaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_StbTiendaID
        End If
		arParams(1) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre
        End If
		arParams(2) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Codigo
        End If
		arParams(3) = New SqlParameter("@objCiudadID", SqlDbType.Int)		
		If IsDBNull(m_objCiudadID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCiudadID
        End If
		arParams(4) = New SqlParameter("@objJefeTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objJefeTiendaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objJefeTiendaID
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
		arParams(10) = New SqlParameter("@ActivoRepuesto", SqlDbType.Bit)		
		If IsDBNull(m_ActivoRepuesto) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_ActivoRepuesto
        End If
		arParams(11) = New SqlParameter("@seriefactura", SqlDbType.VarChar)		
		If IsDBNull(m_seriefactura) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_seriefactura
        End If
		arParams(12) = New SqlParameter("@ProximaFactura", SqlDbType.Int)		
		If IsDBNull(m_ProximaFactura) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_ProximaFactura
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
    ''' 	Actualiza el objeto StbTienda en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update StbTienda set "		
		sCommand &= "StbTiendaID = @StbTiendaID,"
		sCommand &= "Nombre = @Nombre,"
		sCommand &= "Codigo = @Codigo,"
		sCommand &= "objCiudadID = @objCiudadID,"
		sCommand &= "objJefeTiendaID = @objJefeTiendaID,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "ActivoRepuesto = @ActivoRepuesto,"
		sCommand &= "seriefactura = @seriefactura,"
		sCommand &= "ProximaFactura = @ProximaFactura"		
		sCommand &= " where "	
		sCommand &= "StbTiendaID = @StbTiendaID"					
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@StbTiendaID", SqlDbType.Int)		
		If IsDBNull(m_StbTiendaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_StbTiendaID
        End If
		arParams(1) = New SqlParameter("@Nombre", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre
        End If
		arParams(2) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Codigo
        End If
		arParams(3) = New SqlParameter("@objCiudadID", SqlDbType.Int)		
		If IsDBNull(m_objCiudadID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCiudadID
        End If
		arParams(4) = New SqlParameter("@objJefeTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objJefeTiendaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objJefeTiendaID
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
		arParams(10) = New SqlParameter("@ActivoRepuesto", SqlDbType.Bit)		
		If IsDBNull(m_ActivoRepuesto) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_ActivoRepuesto
        End If
		arParams(11) = New SqlParameter("@seriefactura", SqlDbType.VarChar)		
		If IsDBNull(m_seriefactura) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_seriefactura
        End If
		arParams(12) = New SqlParameter("@ProximaFactura", SqlDbType.Int)		
		If IsDBNull(m_ProximaFactura) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_ProximaFactura
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
    ''' Borra un objeto StbTienda de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbTienda where " & " StbTiendaID = " & m_StbTiendaID
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
    ''' Borra un objeto StbTienda de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_StbTiendaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbTienda where " & " StbTiendaID = " & p_StbTiendaID
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
    ''' Borra objetos StbTienda de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbTienda where " & pWhere
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
