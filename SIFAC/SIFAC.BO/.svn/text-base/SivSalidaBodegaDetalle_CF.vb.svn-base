Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivSalidaBodegaDetalle		

#Region " Variables Miembro " 
	Protected m_SivSalidaBodegaDetID As Integer 
	Protected m_objSalidaBodegaID As Integer 
	Protected m_objRepuestoID As String = Nothing 
	Protected m_Cantidad As Decimal 
	Protected m_costo As Decimal 
	Protected m_subtotal As Nullable(Of Decimal) 
	Protected m_ExistenciaAnterior As Nullable(Of Integer) 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SivSalidaBodegaDetID() As Integer
        Get
            Return (m_SivSalidaBodegaDetID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivSalidaBodegaDetID = Value
		End Set
    End Property
	
	Public Property objSalidaBodegaID() As Integer
        Get
            Return (m_objSalidaBodegaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objSalidaBodegaID = Value
		End Set
    End Property
	
	Public Property objRepuestoID() As String
        Get
            Return (m_objRepuestoID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("objRepuestoID", Value.ToString(), "Valor inv?lido para SivSalidaBodegaDetalle.objRepuestoID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_objRepuestoID = Value
		End Set
    End Property
	
	Public Property Cantidad() As Decimal
        Get
            Return (m_Cantidad)
        End Get
		Set(ByVal Value As Decimal)					
			m_Cantidad = Value
		End Set
    End Property
	
	Public Property costo() As Decimal
        Get
            Return (m_costo)
        End Get
		Set(ByVal Value As Decimal)					
			m_costo = Value
		End Set
    End Property
	
	Public Property subtotal() As Nullable(Of Decimal)
        Get
            Return (m_subtotal)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_subtotal = Value
		End Set
    End Property
	
	Public Property ExistenciaAnterior() As Nullable(Of Integer)
        Get
            Return (m_ExistenciaAnterior)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_ExistenciaAnterior = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivSalidaBodegaDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivSalidaBodegaDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "objRepuestoID"
				Return	50
			Case "Cantidad"
				Return	11
			Case "costo"
				Return	11
			Case "subtotal"
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
			Case "Cantidad"
				Return	2
			Case "costo"
				Return	2
			Case "subtotal"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivSalidaBodegaDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivSalidaBodegaDetalle </param>    
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
			cmdDelete.Parameters.Add("@SivSalidaBodegaDetID", SqlDbType.Int, 4, "SivSalidaBodegaDetID" )
			cmdDelete.CommandText = "DELETE FROM  SivSalidaBodegaDetalle WHERE SivSalidaBodegaDetID= @SivSalidaBodegaDetID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSalidaBodegaID", SqlDbType.Int, 4, "objSalidaBodegaID")
			cmdInsert.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdInsert.Parameters.Add("@Cantidad", SqlDbType.Decimal, 9, "Cantidad")
			cmdInsert.Parameters.Add("@costo", SqlDbType.Decimal, 9, "costo")
			cmdInsert.Parameters.Add("@subtotal", SqlDbType.Decimal, 9, "subtotal")
			cmdInsert.Parameters.Add("@ExistenciaAnterior", SqlDbType.Int, 4, "ExistenciaAnterior")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SivSalidaBodegaDetalle ( objSalidaBodegaID, objRepuestoID, Cantidad, costo, subtotal, ExistenciaAnterior, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objSalidaBodegaID, @objRepuestoID, @Cantidad, @costo, @subtotal, @ExistenciaAnterior, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSalidaBodegaID", SqlDbType.Int, 4, "objSalidaBodegaID")
			cmdUpdate.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdUpdate.Parameters.Add("@Cantidad", SqlDbType.Decimal, 9, "Cantidad")
			cmdUpdate.Parameters.Add("@costo", SqlDbType.Decimal, 9, "costo")
			cmdUpdate.Parameters.Add("@subtotal", SqlDbType.Decimal, 9, "subtotal")
			cmdUpdate.Parameters.Add("@ExistenciaAnterior", SqlDbType.Int, 4, "ExistenciaAnterior")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSivSalidaBodegaDetID", SqlDbType.Int, 4, "SivSalidaBodegaDetID")
			cmdUpdate.CommandText = "UPDATE SivSalidaBodegaDetalle SET objSalidaBodegaID=@objSalidaBodegaID, objRepuestoID=@objRepuestoID, Cantidad=@Cantidad, costo=@costo, subtotal=@subtotal, ExistenciaAnterior=@ExistenciaAnterior, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SivSalidaBodegaDetID= @wSivSalidaBodegaDetID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivSalidaBodegaDetalle")
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
    ''' Devuelve de la base de datos un objeto SivSalidaBodegaDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivSalidaBodegaDetID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivSalidaBodegaDetalle where " & " SivSalidaBodegaDetID = " & p_SivSalidaBodegaDetID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivSalidaBodegaDetID = dr("SivSalidaBodegaDetID")
				m_objSalidaBodegaID = IIf(IsDBNull(dr("objSalidaBodegaID")), Nothing, dr("objSalidaBodegaID"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_costo = IIf(IsDBNull(dr("costo")), Nothing, dr("costo"))					
				m_subtotal = IIf(IsDBNull(dr("subtotal")), Nothing, dr("subtotal"))					
				m_ExistenciaAnterior = IIf(IsDBNull(dr("ExistenciaAnterior")), Nothing, dr("ExistenciaAnterior"))					
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
    ''' Devuelve de la base de datos un objeto SivSalidaBodegaDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivSalidaBodegaDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivSalidaBodegaDetID = dr("SivSalidaBodegaDetID")
				m_objSalidaBodegaID = IIf(IsDBNull(dr("objSalidaBodegaID")), Nothing, dr("objSalidaBodegaID"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_costo = IIf(IsDBNull(dr("costo")), Nothing, dr("costo"))					
				m_subtotal = IIf(IsDBNull(dr("subtotal")), Nothing, dr("subtotal"))					
				m_ExistenciaAnterior = IIf(IsDBNull(dr("ExistenciaAnterior")), Nothing, dr("ExistenciaAnterior"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivSalidaBodegaDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivSalidaBodegaDetalle"

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
			ds.Tables(0).TableName = "SivSalidaBodegaDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivSalidaBodegaDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivSalidaBodegaDetalle"

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
			ds.Tables(0).TableName = "SivSalidaBodegaDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivSalidaBodegaDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivSalidaBodegaDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivSalidaBodegaDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivSalidaBodegaDetalle("
		sCommand &= "objSalidaBodegaID,"
		sCommand &= "objRepuestoID,"
		sCommand &= "Cantidad,"
		sCommand &= "costo,"
		sCommand &= "subtotal,"
		sCommand &= "ExistenciaAnterior,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objSalidaBodegaID,"
		sCommand &= "@objRepuestoID,"
		sCommand &= "@Cantidad,"
		sCommand &= "@costo,"
		sCommand &= "@subtotal,"
		sCommand &= "@ExistenciaAnterior,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SivSalidaBodegaDetID = SivSalidaBodegaDetID from SivSalidaBodegaDetalle where "		
		sCommand &= "SivSalidaBodegaDetID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SivSalidaBodegaDetID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSalidaBodegaID", SqlDbType.Int)		
		If IsDBNull(m_objSalidaBodegaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSalidaBodegaID
        End If
		arParams(2) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objRepuestoID
        End If
		arParams(3) = New SqlParameter("@Cantidad", SqlDbType.Decimal)		
		If IsDBNull(m_Cantidad) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Cantidad
        End If
		arParams(4) = New SqlParameter("@costo", SqlDbType.Decimal)		
		If IsDBNull(m_costo) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_costo
        End If
		arParams(5) = New SqlParameter("@subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_subtotal) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_subtotal
        End If
		arParams(6) = New SqlParameter("@ExistenciaAnterior", SqlDbType.Int)		
		If IsDBNull(m_ExistenciaAnterior) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_ExistenciaAnterior
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioCreacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
		arParams(10) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SivSalidaBodegaDetID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivSalidaBodegaDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivSalidaBodegaDetalle set "		
		sCommand &= "objSalidaBodegaID = @objSalidaBodegaID,"
		sCommand &= "objRepuestoID = @objRepuestoID,"
		sCommand &= "Cantidad = @Cantidad,"
		sCommand &= "costo = @costo,"
		sCommand &= "subtotal = @subtotal,"
		sCommand &= "ExistenciaAnterior = @ExistenciaAnterior,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SivSalidaBodegaDetID = @SivSalidaBodegaDetID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SivSalidaBodegaDetID", SqlDbType.Int)		
		If IsDBNull(m_SivSalidaBodegaDetID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivSalidaBodegaDetID
        End If
		arParams(1) = New SqlParameter("@objSalidaBodegaID", SqlDbType.Int)		
		If IsDBNull(m_objSalidaBodegaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSalidaBodegaID
        End If
		arParams(2) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objRepuestoID
        End If
		arParams(3) = New SqlParameter("@Cantidad", SqlDbType.Decimal)		
		If IsDBNull(m_Cantidad) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Cantidad
        End If
		arParams(4) = New SqlParameter("@costo", SqlDbType.Decimal)		
		If IsDBNull(m_costo) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_costo
        End If
		arParams(5) = New SqlParameter("@subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_subtotal) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_subtotal
        End If
		arParams(6) = New SqlParameter("@ExistenciaAnterior", SqlDbType.Int)		
		If IsDBNull(m_ExistenciaAnterior) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_ExistenciaAnterior
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioCreacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
		arParams(10) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SivSalidaBodegaDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivSalidaBodegaDetalle where " & " SivSalidaBodegaDetID = " & m_SivSalidaBodegaDetID
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
    ''' Borra un objeto SivSalidaBodegaDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivSalidaBodegaDetID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivSalidaBodegaDetalle where " & " SivSalidaBodegaDetID = " & p_SivSalidaBodegaDetID
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
    ''' Borra objetos SivSalidaBodegaDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivSalidaBodegaDetalle where " & pWhere
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
