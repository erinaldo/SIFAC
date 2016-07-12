Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccNotaCredito		

#Region " Variables Miembro " 
	Protected m_SccNotaCreditoID As Integer 
	Protected m_Numero As Integer 
	Protected m_Fecha As Date 
	Protected m_Monto As Decimal 
	Protected m_objConceptoID As Integer 
	Protected m_Descripcion As String = Nothing 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_objDevolucionID As Nullable(Of Integer) 
	Protected m_objSccCuentaID As String = Nothing 
	Protected m_objTiendaID As Integer 
#End Region

#Region " Propiedades "
	Public Property SccNotaCreditoID() As Integer
        Get
            Return (m_SccNotaCreditoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccNotaCreditoID = Value
		End Set
    End Property
	
	Public Property Numero() As Integer
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As Integer)					
			m_Numero = Value
		End Set
    End Property
	
	Public Property Fecha() As Date
        Get
            Return (m_Fecha)
        End Get
		Set(ByVal Value As Date)					
			m_Fecha = Value
		End Set
    End Property
	
	Public Property Monto() As Decimal
        Get
            Return (m_Monto)
        End Get
		Set(ByVal Value As Decimal)					
			m_Monto = Value
		End Set
    End Property
	
	Public Property objConceptoID() As Integer
        Get
            Return (m_objConceptoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objConceptoID = Value
		End Set
    End Property
	
	Public Property Descripcion() As String
        Get
            Return (m_Descripcion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 300 Then
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para SccNotaCredito.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (300).")
				End If
			End If
			m_Descripcion = Value
		End Set
    End Property
	
	Public Property objEstadoID() As Nullable(Of Integer)
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEstadoID = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccNotaCredito.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccNotaCredito.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property objDevolucionID() As Nullable(Of Integer)
        Get
            Return (m_objDevolucionID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objDevolucionID = Value
		End Set
    End Property
	
	Public Property objSccCuentaID() As String
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 10 Then
					Throw New ArgumentOutOfRangeException("objSccCuentaID", Value.ToString(), "Valor inv?lido para SccNotaCredito.objSccCuentaID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (10).")
				End If
			End If
			m_objSccCuentaID = Value
		End Set
    End Property
	
	Public Property objTiendaID() As Integer
        Get
            Return (m_objTiendaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTiendaID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Monto"
				Return	11
			Case "Descripcion"
				Return	300
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "objSccCuentaID"
				Return	10
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Monto"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccNotaCredito en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccNotaCredito </param>    
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
			cmdDelete.Parameters.Add("@SccNotaCreditoID", SqlDbType.Int, 4, "SccNotaCreditoID" )
			cmdDelete.CommandText = "DELETE FROM  SccNotaCredito WHERE SccNotaCreditoID= @SccNotaCreditoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Numero", SqlDbType.Int, 4, "Numero")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdInsert.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, 300, "Descripcion")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@objDevolucionID", SqlDbType.Int, 4, "objDevolucionID")
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.VarChar, 10, "objSccCuentaID")
			cmdInsert.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdInsert.CommandText = "INSERT INTO SccNotaCredito ( Numero, Fecha, Monto, objConceptoID, Descripcion, objEstadoID, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, objDevolucionID, objSccCuentaID, objTiendaID) VALUES ( @Numero, @Fecha, @Monto, @objConceptoID, @Descripcion, @objEstadoID, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @objDevolucionID, @objSccCuentaID, @objTiendaID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.Int, 4, "Numero")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdUpdate.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, 300, "Descripcion")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@objDevolucionID", SqlDbType.Int, 4, "objDevolucionID")
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.VarChar, 10, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.Parameters.Add("@wSccNotaCreditoID", SqlDbType.Int, 4, "SccNotaCreditoID")
			cmdUpdate.CommandText = "UPDATE SccNotaCredito SET Numero=@Numero, Fecha=@Fecha, Monto=@Monto, objConceptoID=@objConceptoID, Descripcion=@Descripcion, objEstadoID=@objEstadoID, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, objDevolucionID=@objDevolucionID, objSccCuentaID=@objSccCuentaID, objTiendaID=@objTiendaID WHERE SccNotaCreditoID= @wSccNotaCreditoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccNotaCredito")
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
    ''' Devuelve de la base de datos un objeto SccNotaCredito
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccNotaCreditoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccNotaCredito where " & " SccNotaCreditoID = " & p_SccNotaCreditoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SccNotaCreditoID = dr("SccNotaCreditoID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))					
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))					
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objDevolucionID = IIf(IsDBNull(dr("objDevolucionID")), Nothing, dr("objDevolucionID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
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
    ''' Devuelve de la base de datos un objeto SccNotaCredito usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccNotaCredito where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SccNotaCreditoID = dr("SccNotaCreditoID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))					
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))					
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_objDevolucionID = IIf(IsDBNull(dr("objDevolucionID")), Nothing, dr("objDevolucionID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccNotaCredito en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccNotaCredito"

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
			ds.Tables(0).TableName = "SccNotaCredito"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccNotaCredito en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccNotaCredito"

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
			ds.Tables(0).TableName = "SccNotaCredito"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccNotaCredito en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccNotaCredito"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccNotaCredito.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccNotaCredito("
		sCommand &= "Numero,"
		sCommand &= "Fecha,"
		sCommand &= "Monto,"
		sCommand &= "objConceptoID,"
		sCommand &= "Descripcion,"
		sCommand &= "objEstadoID,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "objDevolucionID,"
		sCommand &= "objSccCuentaID,"
		sCommand &= "objTiendaID) values ("		
		sCommand &= "@Numero,"
		sCommand &= "@Fecha,"
		sCommand &= "@Monto,"
		sCommand &= "@objConceptoID,"
		sCommand &= "@Descripcion,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@objDevolucionID,"
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@objTiendaID)"		
	
		sCommand &= " select "
		sCommand &= "@SccNotaCreditoID = SccNotaCreditoID from SccNotaCredito where "		
		sCommand &= "SccNotaCreditoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@SccNotaCreditoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Numero", SqlDbType.Int)		
		If IsDBNull(m_Numero) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Numero
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Monto
        End If
		arParams(4) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objConceptoID
        End If
		arParams(5) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Descripcion
        End If
		arParams(6) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objEstadoID
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@objDevolucionID", SqlDbType.Int)		
		If IsDBNull(m_objDevolucionID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objDevolucionID
        End If
		arParams(12) = New SqlParameter("@objSccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objSccCuentaID
        End If
		arParams(13) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objTiendaID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccNotaCreditoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccNotaCredito en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccNotaCredito set "		
		sCommand &= "Numero = @Numero,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "Monto = @Monto,"
		sCommand &= "objConceptoID = @objConceptoID,"
		sCommand &= "Descripcion = @Descripcion,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "objDevolucionID = @objDevolucionID,"
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "objTiendaID = @objTiendaID"		
		sCommand &= " where "	
		sCommand &= "SccNotaCreditoID = @SccNotaCreditoID"					
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@SccNotaCreditoID", SqlDbType.Int)		
		If IsDBNull(m_SccNotaCreditoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccNotaCreditoID
        End If
		arParams(1) = New SqlParameter("@Numero", SqlDbType.Int)		
		If IsDBNull(m_Numero) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Numero
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Monto
        End If
		arParams(4) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objConceptoID
        End If
		arParams(5) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Descripcion
        End If
		arParams(6) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objEstadoID
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@objDevolucionID", SqlDbType.Int)		
		If IsDBNull(m_objDevolucionID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objDevolucionID
        End If
		arParams(12) = New SqlParameter("@objSccCuentaID", SqlDbType.VarChar)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objSccCuentaID
        End If
		arParams(13) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objTiendaID
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
    ''' Borra un objeto SccNotaCredito de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccNotaCredito where " & " SccNotaCreditoID = " & m_SccNotaCreditoID
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
    ''' Borra un objeto SccNotaCredito de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccNotaCreditoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccNotaCredito where " & " SccNotaCreditoID = " & p_SccNotaCreditoID
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
    ''' Borra objetos SccNotaCredito de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccNotaCredito where " & pWhere
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
