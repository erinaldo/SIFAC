Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivBodegaRepuestos		

#Region " Variables Miembro " 
	Protected m_objRepuestoID As String = Nothing 
	Protected m_objTiendaID As Integer 
	Protected m_Ubicacion As String = Nothing 
	Protected m_Cantidad As Integer 
	Protected m_CantidadTransito As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property objRepuestoID() As String
        Get
            Return (m_objRepuestoID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("objRepuestoID", Value.ToString(), "Valor inv?lido para SivBodegaRepuestos.objRepuestoID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_objRepuestoID = Value
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
	
	Public Property Ubicacion() As String
        Get
            Return (m_Ubicacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Ubicacion", Value.ToString(), "Valor inv?lido para SivBodegaRepuestos.Ubicacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Ubicacion = Value
		End Set
    End Property
	
	Public Property Cantidad() As Integer
        Get
            Return (m_Cantidad)
        End Get
		Set(ByVal Value As Integer)					
			m_Cantidad = Value
		End Set
    End Property
	
	Public Property CantidadTransito() As Nullable(Of Integer)
        Get
            Return (m_CantidadTransito)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_CantidadTransito = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivBodegaRepuestos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivBodegaRepuestos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
			Case "objRepuestoID"
				Return	50
			Case "Ubicacion"
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
    ''' Salva un DataSet del tipo de la tabla SivBodegaRepuestos en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivBodegaRepuestos </param>    
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
			cmdDelete.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID" )
			cmdDelete.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID" )
			cmdDelete.CommandText = "DELETE FROM  SivBodegaRepuestos WHERE objRepuestoID= @objRepuestoID And objTiendaID= @objTiendaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdInsert.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdInsert.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50, "Ubicacion")
			cmdInsert.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdInsert.Parameters.Add("@CantidadTransito", SqlDbType.Int, 4, "CantidadTransito")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SivBodegaRepuestos ( objRepuestoID, objTiendaID, Ubicacion, Cantidad, CantidadTransito, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objRepuestoID, @objTiendaID, @Ubicacion, @Cantidad, @CantidadTransito, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdUpdate.Parameters.Add("@objTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50, "Ubicacion")
			cmdUpdate.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdUpdate.Parameters.Add("@CantidadTransito", SqlDbType.Int, 4, "CantidadTransito")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wobjRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdUpdate.Parameters.Add("@wobjTiendaID", SqlDbType.Int, 4, "objTiendaID")
			cmdUpdate.CommandText = "UPDATE SivBodegaRepuestos SET objRepuestoID=@objRepuestoID, objTiendaID=@objTiendaID, Ubicacion=@Ubicacion, Cantidad=@Cantidad, CantidadTransito=@CantidadTransito, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE objRepuestoID= @wobjRepuestoID And objTiendaID= @wobjTiendaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivBodegaRepuestos")
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
    ''' Devuelve de la base de datos un objeto SivBodegaRepuestos
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_objRepuestoID as String, Byval p_objTiendaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivBodegaRepuestos where " & " objRepuestoID = '" & p_objRepuestoID & "'"  & " and objTiendaID = " & p_objTiendaID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_Ubicacion = IIf(IsDBNull(dr("Ubicacion")), Nothing, dr("Ubicacion"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_CantidadTransito = IIf(IsDBNull(dr("CantidadTransito")), Nothing, dr("CantidadTransito"))					
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
    ''' Devuelve de la base de datos un objeto SivBodegaRepuestos usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivBodegaRepuestos where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_objTiendaID = IIf(IsDBNull(dr("objTiendaID")), Nothing, dr("objTiendaID"))					
				m_Ubicacion = IIf(IsDBNull(dr("Ubicacion")), Nothing, dr("Ubicacion"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_CantidadTransito = IIf(IsDBNull(dr("CantidadTransito")), Nothing, dr("CantidadTransito"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivBodegaRepuestos en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivBodegaRepuestos"

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
			ds.Tables(0).TableName = "SivBodegaRepuestos"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivBodegaRepuestos en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivBodegaRepuestos"

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
			ds.Tables(0).TableName = "SivBodegaRepuestos"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivBodegaRepuestos en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivBodegaRepuestos"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivBodegaRepuestos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivBodegaRepuestos("
		sCommand &= "objRepuestoID,"
		sCommand &= "objTiendaID,"
		sCommand &= "Ubicacion,"
		sCommand &= "Cantidad,"
		sCommand &= "CantidadTransito,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objRepuestoID,"
		sCommand &= "@objTiendaID,"
		sCommand &= "@Ubicacion,"
		sCommand &= "@Cantidad,"
		sCommand &= "@CantidadTransito,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
		
		Dim arParams(8) As SqlParameter
		arParams(0) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_objRepuestoID
        End If
		arParams(1) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTiendaID
        End If
		arParams(2) = New SqlParameter("@Ubicacion", SqlDbType.VarChar)		
		If IsDBNull(m_Ubicacion) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Ubicacion
        End If
		arParams(3) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Cantidad
        End If
		arParams(4) = New SqlParameter("@CantidadTransito", SqlDbType.Int)		
		If IsDBNull(m_CantidadTransito) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_CantidadTransito
        End If
		arParams(5) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_UsuarioCreacion
        End If
		arParams(6) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCreacion
        End If
		arParams(7) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioModificacion
        End If
		arParams(8) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaModificacion
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
    ''' 	Actualiza el objeto SivBodegaRepuestos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivBodegaRepuestos set "		
		sCommand &= "objRepuestoID = @objRepuestoID,"
		sCommand &= "objTiendaID = @objTiendaID,"
		sCommand &= "Ubicacion = @Ubicacion,"
		sCommand &= "Cantidad = @Cantidad,"
		sCommand &= "CantidadTransito = @CantidadTransito,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "objRepuestoID = @objRepuestoID and "
		sCommand &= "objTiendaID = @objTiendaID"					
		
		Dim arParams(8) As SqlParameter
		arParams(0) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_objRepuestoID
        End If
		arParams(1) = New SqlParameter("@objTiendaID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTiendaID
        End If
		arParams(2) = New SqlParameter("@Ubicacion", SqlDbType.VarChar)		
		If IsDBNull(m_Ubicacion) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Ubicacion
        End If
		arParams(3) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Cantidad
        End If
		arParams(4) = New SqlParameter("@CantidadTransito", SqlDbType.Int)		
		If IsDBNull(m_CantidadTransito) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_CantidadTransito
        End If
		arParams(5) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_UsuarioCreacion
        End If
		arParams(6) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCreacion
        End If
		arParams(7) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioModificacion
        End If
		arParams(8) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaModificacion
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
    ''' Borra un objeto SivBodegaRepuestos de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivBodegaRepuestos where " & " objRepuestoID = '" & m_objRepuestoID & "'"  & " and objTiendaID = " & m_objTiendaID
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
    ''' Borra un objeto SivBodegaRepuestos de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_objRepuestoID as String, Byval p_objTiendaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivBodegaRepuestos where " & " objRepuestoID = '" & p_objRepuestoID & "'"  & " and objTiendaID = " & p_objTiendaID
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
    ''' Borra objetos SivBodegaRepuestos de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivBodegaRepuestos where " & pWhere
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
