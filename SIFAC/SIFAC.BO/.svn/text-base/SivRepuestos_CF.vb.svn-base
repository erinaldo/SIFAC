Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivRepuestos		

#Region " Variables Miembro " 
	Protected m_SivRepuestoID As String = Nothing 
	Protected m_objTipoRepuesto As Integer 
	Protected m_objMarca As Integer 
	Protected m_objCausaInactivacion As Nullable(Of Integer) 
	Protected m_DescripcionCorta As String = Nothing 
	Protected m_DescripcionEspanol As String = Nothing 
	Protected m_DescripcionIngles As String = Nothing 
	Protected m_CodigoBarras As String = Nothing 
	Protected m_EtiquetarCB As Boolean 
	Protected m_FechaRegistro As Date 
	Protected m_plazoGarantia As Integer 
	Protected m_Precio As Decimal 
	Protected m_CostoProm As Decimal 
	Protected m_Activo As Boolean 
	Protected m_Imagen As Byte() 
	Protected m_CantidadMinima As Nullable(Of Integer) 
	Protected m_CantidadMaxima As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SivRepuestoID() As String
        Get
            Return (m_SivRepuestoID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 25 Then
					Throw New ArgumentOutOfRangeException("SivRepuestoID", Value.ToString(), "Valor inv?lido para SivRepuestos.SivRepuestoID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (25).")
				End If
			End If
			m_SivRepuestoID = Value
		End Set
    End Property
	
	Public Property objTipoRepuesto() As Integer
        Get
            Return (m_objTipoRepuesto)
        End Get
		Set(ByVal Value As Integer)					
			m_objTipoRepuesto = Value
		End Set
    End Property
	
	Public Property objMarca() As Integer
        Get
            Return (m_objMarca)
        End Get
		Set(ByVal Value As Integer)					
			m_objMarca = Value
		End Set
    End Property
	
	Public Property objCausaInactivacion() As Nullable(Of Integer)
        Get
            Return (m_objCausaInactivacion)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCausaInactivacion = Value
		End Set
    End Property
	
	Public Property DescripcionCorta() As String
        Get
            Return (m_DescripcionCorta)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 40 Then
					Throw New ArgumentOutOfRangeException("DescripcionCorta", Value.ToString(), "Valor inv?lido para SivRepuestos.DescripcionCorta. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (40).")
				End If
			End If
			m_DescripcionCorta = Value
		End Set
    End Property
	
	Public Property DescripcionEspanol() As String
        Get
            Return (m_DescripcionEspanol)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("DescripcionEspanol", Value.ToString(), "Valor inv?lido para SivRepuestos.DescripcionEspanol. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_DescripcionEspanol = Value
		End Set
    End Property
	
	Public Property DescripcionIngles() As String
        Get
            Return (m_DescripcionIngles)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("DescripcionIngles", Value.ToString(), "Valor inv?lido para SivRepuestos.DescripcionIngles. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_DescripcionIngles = Value
		End Set
    End Property
	
	Public Property CodigoBarras() As String
        Get
            Return (m_CodigoBarras)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 500 Then
					Throw New ArgumentOutOfRangeException("CodigoBarras", Value.ToString(), "Valor inv?lido para SivRepuestos.CodigoBarras. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (500).")
				End If
			End If
			m_CodigoBarras = Value
		End Set
    End Property
	
	Public Property EtiquetarCB() As Boolean
        Get
            Return (m_EtiquetarCB)
        End Get
		Set(ByVal Value As Boolean)					
			m_EtiquetarCB = Value
		End Set
    End Property
	
	Public Property FechaRegistro() As Date
        Get
            Return (m_FechaRegistro)
        End Get
		Set(ByVal Value As Date)					
			m_FechaRegistro = Value
		End Set
    End Property
	
	Public Property plazoGarantia() As Integer
        Get
            Return (m_plazoGarantia)
        End Get
		Set(ByVal Value As Integer)					
			m_plazoGarantia = Value
		End Set
    End Property
	
	Public Property Precio() As Decimal
        Get
            Return (m_Precio)
        End Get
		Set(ByVal Value As Decimal)					
			m_Precio = Value
		End Set
    End Property
	
	Public Property CostoProm() As Decimal
        Get
            Return (m_CostoProm)
        End Get
		Set(ByVal Value As Decimal)					
			m_CostoProm = Value
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
	
	Public Property Imagen() As Byte()
        Get
            Return (m_Imagen)
        End Get
		Set(ByVal Value As Byte())					
			m_Imagen = Value
		End Set
    End Property
	
	Public Property CantidadMinima() As Nullable(Of Integer)
        Get
            Return (m_CantidadMinima)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_CantidadMinima = Value
		End Set
    End Property
	
	Public Property CantidadMaxima() As Nullable(Of Integer)
        Get
            Return (m_CantidadMaxima)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_CantidadMaxima = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivRepuestos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
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
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivRepuestos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "SivRepuestoID"
				Return	25
			Case "DescripcionCorta"
				Return	40
			Case "DescripcionEspanol"
				Return	100
			Case "DescripcionIngles"
				Return	100
			Case "CodigoBarras"
				Return	500
			Case "Precio"
				Return	11
			Case "CostoProm"
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
			Case "Precio"
				Return	2
			Case "CostoProm"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivRepuestos en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivRepuestos </param>    
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
			cmdDelete.Parameters.Add("@SivRepuestoID", SqlDbType.VarChar, 25, "SivRepuestoID" )
			cmdDelete.CommandText = "DELETE FROM  SivRepuestos WHERE SivRepuestoID= @SivRepuestoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@SivRepuestoID", SqlDbType.VarChar, 25, "SivRepuestoID")
			cmdInsert.Parameters.Add("@objTipoRepuesto", SqlDbType.Int, 4, "objTipoRepuesto")
			cmdInsert.Parameters.Add("@objMarca", SqlDbType.Int, 4, "objMarca")
			cmdInsert.Parameters.Add("@objCausaInactivacion", SqlDbType.Int, 4, "objCausaInactivacion")
			cmdInsert.Parameters.Add("@DescripcionCorta", SqlDbType.VarChar, 40, "DescripcionCorta")
			cmdInsert.Parameters.Add("@DescripcionEspanol", SqlDbType.VarChar, 100, "DescripcionEspanol")
			cmdInsert.Parameters.Add("@DescripcionIngles", SqlDbType.VarChar, 100, "DescripcionIngles")
			cmdInsert.Parameters.Add("@CodigoBarras", SqlDbType.VarChar, 500, "CodigoBarras")
			cmdInsert.Parameters.Add("@EtiquetarCB", SqlDbType.Bit, 1, "EtiquetarCB")
			cmdInsert.Parameters.Add("@FechaRegistro", SqlDbType.DateTime, 8, "FechaRegistro")
			cmdInsert.Parameters.Add("@plazoGarantia", SqlDbType.Int, 4, "plazoGarantia")
			cmdInsert.Parameters.Add("@Precio", SqlDbType.Decimal, 9, "Precio")
			cmdInsert.Parameters.Add("@CostoProm", SqlDbType.Decimal, 9, "CostoProm")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@Imagen", SqlDbType.Binary, 16, "Imagen")
			cmdInsert.Parameters.Add("@CantidadMinima", SqlDbType.Int, 4, "CantidadMinima")
			cmdInsert.Parameters.Add("@CantidadMaxima", SqlDbType.Int, 4, "CantidadMaxima")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SivRepuestos ( SivRepuestoID, objTipoRepuesto, objMarca, objCausaInactivacion, DescripcionCorta, DescripcionEspanol, DescripcionIngles, CodigoBarras, EtiquetarCB, FechaRegistro, plazoGarantia, Precio, CostoProm, Activo, Imagen, CantidadMinima, CantidadMaxima, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @SivRepuestoID, @objTipoRepuesto, @objMarca, @objCausaInactivacion, @DescripcionCorta, @DescripcionEspanol, @DescripcionIngles, @CodigoBarras, @EtiquetarCB, @FechaRegistro, @plazoGarantia, @Precio, @CostoProm, @Activo, @Imagen, @CantidadMinima, @CantidadMaxima, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@SivRepuestoID", SqlDbType.VarChar, 25, "SivRepuestoID")
			cmdUpdate.Parameters.Add("@objTipoRepuesto", SqlDbType.Int, 4, "objTipoRepuesto")
			cmdUpdate.Parameters.Add("@objMarca", SqlDbType.Int, 4, "objMarca")
			cmdUpdate.Parameters.Add("@objCausaInactivacion", SqlDbType.Int, 4, "objCausaInactivacion")
			cmdUpdate.Parameters.Add("@DescripcionCorta", SqlDbType.VarChar, 40, "DescripcionCorta")
			cmdUpdate.Parameters.Add("@DescripcionEspanol", SqlDbType.VarChar, 100, "DescripcionEspanol")
			cmdUpdate.Parameters.Add("@DescripcionIngles", SqlDbType.VarChar, 100, "DescripcionIngles")
			cmdUpdate.Parameters.Add("@CodigoBarras", SqlDbType.VarChar, 500, "CodigoBarras")
			cmdUpdate.Parameters.Add("@EtiquetarCB", SqlDbType.Bit, 1, "EtiquetarCB")
			cmdUpdate.Parameters.Add("@FechaRegistro", SqlDbType.DateTime, 8, "FechaRegistro")
			cmdUpdate.Parameters.Add("@plazoGarantia", SqlDbType.Int, 4, "plazoGarantia")
			cmdUpdate.Parameters.Add("@Precio", SqlDbType.Decimal, 9, "Precio")
			cmdUpdate.Parameters.Add("@CostoProm", SqlDbType.Decimal, 9, "CostoProm")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@Imagen", SqlDbType.Binary, 16, "Imagen")
			cmdUpdate.Parameters.Add("@CantidadMinima", SqlDbType.Int, 4, "CantidadMinima")
			cmdUpdate.Parameters.Add("@CantidadMaxima", SqlDbType.Int, 4, "CantidadMaxima")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSivRepuestoID", SqlDbType.VarChar, 25, "SivRepuestoID")
			cmdUpdate.CommandText = "UPDATE SivRepuestos SET SivRepuestoID=@SivRepuestoID, objTipoRepuesto=@objTipoRepuesto, objMarca=@objMarca, objCausaInactivacion=@objCausaInactivacion, DescripcionCorta=@DescripcionCorta, DescripcionEspanol=@DescripcionEspanol, DescripcionIngles=@DescripcionIngles, CodigoBarras=@CodigoBarras, EtiquetarCB=@EtiquetarCB, FechaRegistro=@FechaRegistro, plazoGarantia=@plazoGarantia, Precio=@Precio, CostoProm=@CostoProm, Activo=@Activo, Imagen=@Imagen, CantidadMinima=@CantidadMinima, CantidadMaxima=@CantidadMaxima, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SivRepuestoID= @wSivRepuestoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivRepuestos")
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
    ''' Devuelve de la base de datos un objeto SivRepuestos
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivRepuestoID as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivRepuestos where " & " SivRepuestoID = '" & p_SivRepuestoID & "'" 		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivRepuestoID = IIf(IsDBNull(dr("SivRepuestoID")), Nothing, dr("SivRepuestoID"))					
				m_objTipoRepuesto = IIf(IsDBNull(dr("objTipoRepuesto")), Nothing, dr("objTipoRepuesto"))					
				m_objMarca = IIf(IsDBNull(dr("objMarca")), Nothing, dr("objMarca"))					
				m_objCausaInactivacion = IIf(IsDBNull(dr("objCausaInactivacion")), Nothing, dr("objCausaInactivacion"))					
				m_DescripcionCorta = IIf(IsDBNull(dr("DescripcionCorta")), Nothing, dr("DescripcionCorta"))					
				m_DescripcionEspanol = IIf(IsDBNull(dr("DescripcionEspanol")), Nothing, dr("DescripcionEspanol"))					
				m_DescripcionIngles = IIf(IsDBNull(dr("DescripcionIngles")), Nothing, dr("DescripcionIngles"))					
				m_CodigoBarras = IIf(IsDBNull(dr("CodigoBarras")), Nothing, dr("CodigoBarras"))					
				m_EtiquetarCB = IIf(IsDBNull(dr("EtiquetarCB")), Nothing, dr("EtiquetarCB"))					
				m_FechaRegistro = IIf(IsDBNull(dr("FechaRegistro")), Nothing, dr("FechaRegistro"))					
				m_plazoGarantia = IIf(IsDBNull(dr("plazoGarantia")), Nothing, dr("plazoGarantia"))					
				m_Precio = IIf(IsDBNull(dr("Precio")), Nothing, dr("Precio"))					
				m_CostoProm = IIf(IsDBNull(dr("CostoProm")), Nothing, dr("CostoProm"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_Imagen = IIf(IsDBNull(dr("Imagen")), Nothing, dr("Imagen"))					
				m_CantidadMinima = IIf(IsDBNull(dr("CantidadMinima")), Nothing, dr("CantidadMinima"))					
				m_CantidadMaxima = IIf(IsDBNull(dr("CantidadMaxima")), Nothing, dr("CantidadMaxima"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
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
    ''' Devuelve de la base de datos un objeto SivRepuestos usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivRepuestos where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivRepuestoID = IIf(IsDBNull(dr("SivRepuestoID")), Nothing, dr("SivRepuestoID"))					
				m_objTipoRepuesto = IIf(IsDBNull(dr("objTipoRepuesto")), Nothing, dr("objTipoRepuesto"))					
				m_objMarca = IIf(IsDBNull(dr("objMarca")), Nothing, dr("objMarca"))					
				m_objCausaInactivacion = IIf(IsDBNull(dr("objCausaInactivacion")), Nothing, dr("objCausaInactivacion"))					
				m_DescripcionCorta = IIf(IsDBNull(dr("DescripcionCorta")), Nothing, dr("DescripcionCorta"))					
				m_DescripcionEspanol = IIf(IsDBNull(dr("DescripcionEspanol")), Nothing, dr("DescripcionEspanol"))					
				m_DescripcionIngles = IIf(IsDBNull(dr("DescripcionIngles")), Nothing, dr("DescripcionIngles"))					
				m_CodigoBarras = IIf(IsDBNull(dr("CodigoBarras")), Nothing, dr("CodigoBarras"))					
				m_EtiquetarCB = IIf(IsDBNull(dr("EtiquetarCB")), Nothing, dr("EtiquetarCB"))					
				m_FechaRegistro = IIf(IsDBNull(dr("FechaRegistro")), Nothing, dr("FechaRegistro"))					
				m_plazoGarantia = IIf(IsDBNull(dr("plazoGarantia")), Nothing, dr("plazoGarantia"))					
				m_Precio = IIf(IsDBNull(dr("Precio")), Nothing, dr("Precio"))					
				m_CostoProm = IIf(IsDBNull(dr("CostoProm")), Nothing, dr("CostoProm"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_Imagen = IIf(IsDBNull(dr("Imagen")), Nothing, dr("Imagen"))					
				m_CantidadMinima = IIf(IsDBNull(dr("CantidadMinima")), Nothing, dr("CantidadMinima"))					
				m_CantidadMaxima = IIf(IsDBNull(dr("CantidadMaxima")), Nothing, dr("CantidadMaxima"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivRepuestos en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivRepuestos"

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
			ds.Tables(0).TableName = "SivRepuestos"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivRepuestos en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivRepuestos"

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
			ds.Tables(0).TableName = "SivRepuestos"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivRepuestos en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivRepuestos"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivRepuestos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivRepuestos("
		sCommand &= "SivRepuestoID,"
		sCommand &= "objTipoRepuesto,"
		sCommand &= "objMarca,"
		sCommand &= "objCausaInactivacion,"
		sCommand &= "DescripcionCorta,"
		sCommand &= "DescripcionEspanol,"
		sCommand &= "DescripcionIngles,"
		sCommand &= "CodigoBarras,"
		sCommand &= "EtiquetarCB,"
		sCommand &= "FechaRegistro,"
		sCommand &= "plazoGarantia,"
		sCommand &= "Precio,"
		sCommand &= "CostoProm,"
		sCommand &= "Activo,"
		sCommand &= "Imagen,"
		sCommand &= "CantidadMinima,"
		sCommand &= "CantidadMaxima,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@SivRepuestoID,"
		sCommand &= "@objTipoRepuesto,"
		sCommand &= "@objMarca,"
		sCommand &= "@objCausaInactivacion,"
		sCommand &= "@DescripcionCorta,"
		sCommand &= "@DescripcionEspanol,"
		sCommand &= "@DescripcionIngles,"
		sCommand &= "@CodigoBarras,"
		sCommand &= "@EtiquetarCB,"
		sCommand &= "@FechaRegistro,"
		sCommand &= "@plazoGarantia,"
		sCommand &= "@Precio,"
		sCommand &= "@CostoProm,"
		sCommand &= "@Activo,"
		sCommand &= "@Imagen,"
		sCommand &= "@CantidadMinima,"
		sCommand &= "@CantidadMaxima,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
		
		Dim arParams(20) As SqlParameter
		arParams(0) = New SqlParameter("@SivRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_SivRepuestoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivRepuestoID
        End If
		arParams(1) = New SqlParameter("@objTipoRepuesto", SqlDbType.Int)		
		If IsDBNull(m_objTipoRepuesto) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTipoRepuesto
        End If
		arParams(2) = New SqlParameter("@objMarca", SqlDbType.Int)		
		If IsDBNull(m_objMarca) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objMarca
        End If
		arParams(3) = New SqlParameter("@objCausaInactivacion", SqlDbType.Int)		
		If IsDBNull(m_objCausaInactivacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCausaInactivacion
        End If
		arParams(4) = New SqlParameter("@DescripcionCorta", SqlDbType.VarChar)		
		If IsDBNull(m_DescripcionCorta) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_DescripcionCorta
        End If
		arParams(5) = New SqlParameter("@DescripcionEspanol", SqlDbType.VarChar)		
		If IsDBNull(m_DescripcionEspanol) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_DescripcionEspanol
        End If
		arParams(6) = New SqlParameter("@DescripcionIngles", SqlDbType.VarChar)		
		If IsDBNull(m_DescripcionIngles) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_DescripcionIngles
        End If
		arParams(7) = New SqlParameter("@CodigoBarras", SqlDbType.VarChar)		
		If IsDBNull(m_CodigoBarras) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_CodigoBarras
        End If
		arParams(8) = New SqlParameter("@EtiquetarCB", SqlDbType.Bit)		
		If IsDBNull(m_EtiquetarCB) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_EtiquetarCB
        End If
		arParams(9) = New SqlParameter("@FechaRegistro", SqlDbType.DateTime)		
		If IsDBNull(m_FechaRegistro) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaRegistro
        End If
		arParams(10) = New SqlParameter("@plazoGarantia", SqlDbType.Int)		
		If IsDBNull(m_plazoGarantia) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_plazoGarantia
        End If
		arParams(11) = New SqlParameter("@Precio", SqlDbType.Decimal)		
		If IsDBNull(m_Precio) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Precio
        End If
		arParams(12) = New SqlParameter("@CostoProm", SqlDbType.Decimal)		
		If IsDBNull(m_CostoProm) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_CostoProm
        End If
		arParams(13) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Activo
        End If
		arParams(14) = New SqlParameter("@Imagen", SqlDbType.Binary)		
		If IsDBNull(m_Imagen) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Imagen
        End If
		arParams(15) = New SqlParameter("@CantidadMinima", SqlDbType.Int)		
		If IsDBNull(m_CantidadMinima) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_CantidadMinima
        End If
		arParams(16) = New SqlParameter("@CantidadMaxima", SqlDbType.Int)		
		If IsDBNull(m_CantidadMaxima) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_CantidadMaxima
        End If
		arParams(17) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioCreacion
        End If
		arParams(18) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaCreacion
        End If
		arParams(19) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioModificacion
        End If
		arParams(20) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaModificacion
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
    ''' 	Actualiza el objeto SivRepuestos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivRepuestos set "		
		sCommand &= "SivRepuestoID = @SivRepuestoID,"
		sCommand &= "objTipoRepuesto = @objTipoRepuesto,"
		sCommand &= "objMarca = @objMarca,"
		sCommand &= "objCausaInactivacion = @objCausaInactivacion,"
		sCommand &= "DescripcionCorta = @DescripcionCorta,"
		sCommand &= "DescripcionEspanol = @DescripcionEspanol,"
		sCommand &= "DescripcionIngles = @DescripcionIngles,"
		sCommand &= "CodigoBarras = @CodigoBarras,"
		sCommand &= "EtiquetarCB = @EtiquetarCB,"
		sCommand &= "FechaRegistro = @FechaRegistro,"
		sCommand &= "plazoGarantia = @plazoGarantia,"
		sCommand &= "Precio = @Precio,"
		sCommand &= "CostoProm = @CostoProm,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "Imagen = @Imagen,"
		sCommand &= "CantidadMinima = @CantidadMinima,"
		sCommand &= "CantidadMaxima = @CantidadMaxima,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SivRepuestoID = @SivRepuestoID"					
		
		Dim arParams(20) As SqlParameter
		arParams(0) = New SqlParameter("@SivRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_SivRepuestoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivRepuestoID
        End If
		arParams(1) = New SqlParameter("@objTipoRepuesto", SqlDbType.Int)		
		If IsDBNull(m_objTipoRepuesto) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTipoRepuesto
        End If
		arParams(2) = New SqlParameter("@objMarca", SqlDbType.Int)		
		If IsDBNull(m_objMarca) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objMarca
        End If
		arParams(3) = New SqlParameter("@objCausaInactivacion", SqlDbType.Int)		
		If IsDBNull(m_objCausaInactivacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCausaInactivacion
        End If
		arParams(4) = New SqlParameter("@DescripcionCorta", SqlDbType.VarChar)		
		If IsDBNull(m_DescripcionCorta) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_DescripcionCorta
        End If
		arParams(5) = New SqlParameter("@DescripcionEspanol", SqlDbType.VarChar)		
		If IsDBNull(m_DescripcionEspanol) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_DescripcionEspanol
        End If
		arParams(6) = New SqlParameter("@DescripcionIngles", SqlDbType.VarChar)		
		If IsDBNull(m_DescripcionIngles) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_DescripcionIngles
        End If
		arParams(7) = New SqlParameter("@CodigoBarras", SqlDbType.VarChar)		
		If IsDBNull(m_CodigoBarras) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_CodigoBarras
        End If
		arParams(8) = New SqlParameter("@EtiquetarCB", SqlDbType.Bit)		
		If IsDBNull(m_EtiquetarCB) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_EtiquetarCB
        End If
		arParams(9) = New SqlParameter("@FechaRegistro", SqlDbType.DateTime)		
		If IsDBNull(m_FechaRegistro) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaRegistro
        End If
		arParams(10) = New SqlParameter("@plazoGarantia", SqlDbType.Int)		
		If IsDBNull(m_plazoGarantia) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_plazoGarantia
        End If
		arParams(11) = New SqlParameter("@Precio", SqlDbType.Decimal)		
		If IsDBNull(m_Precio) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Precio
        End If
		arParams(12) = New SqlParameter("@CostoProm", SqlDbType.Decimal)		
		If IsDBNull(m_CostoProm) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_CostoProm
        End If
		arParams(13) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Activo
        End If
		arParams(14) = New SqlParameter("@Imagen", SqlDbType.Binary)		
		If IsDBNull(m_Imagen) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Imagen
        End If
		arParams(15) = New SqlParameter("@CantidadMinima", SqlDbType.Int)		
		If IsDBNull(m_CantidadMinima) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_CantidadMinima
        End If
		arParams(16) = New SqlParameter("@CantidadMaxima", SqlDbType.Int)		
		If IsDBNull(m_CantidadMaxima) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_CantidadMaxima
        End If
		arParams(17) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioCreacion
        End If
		arParams(18) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaCreacion
        End If
		arParams(19) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioModificacion
        End If
		arParams(20) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaModificacion
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
    ''' Borra un objeto SivRepuestos de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivRepuestos where " & " SivRepuestoID = '" & m_SivRepuestoID & "'" 
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
    ''' Borra un objeto SivRepuestos de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivRepuestoID as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivRepuestos where " & " SivRepuestoID = '" & p_SivRepuestoID & "'" 
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
    ''' Borra objetos SivRepuestos de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivRepuestos where " & pWhere
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
