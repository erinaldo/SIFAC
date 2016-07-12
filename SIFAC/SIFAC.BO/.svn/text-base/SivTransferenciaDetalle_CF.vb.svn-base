Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivTransferenciaDetalle		

#Region " Variables Miembro " 
	Protected m_objTransferenciaID As Integer 
	Protected m_objTiendaDestinoID As Integer 
	Protected m_objRepuestoID As String = Nothing 
	Protected m_CantidadSolicitada As Integer 
	Protected m_CantidadDespachada As Integer 
	Protected m_CantidadRecibida As Integer 
	Protected m_costo As Nullable(Of Decimal) 
	Protected m_subtotal As Nullable(Of Decimal) 
	Protected m_ExistenciaAnteriorEntrada As Nullable(Of Integer) 
	Protected m_ExistenciaAnteriorSalida As Nullable(Of Integer) 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property objTransferenciaID() As Integer
        Get
            Return (m_objTransferenciaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTransferenciaID = Value
		End Set
    End Property
	
	Public Property objTiendaDestinoID() As Integer
        Get
            Return (m_objTiendaDestinoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objTiendaDestinoID = Value
		End Set
    End Property
	
	Public Property objRepuestoID() As String
        Get
            Return (m_objRepuestoID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("objRepuestoID", Value.ToString(), "Valor inv?lido para SivTransferenciaDetalle.objRepuestoID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_objRepuestoID = Value
		End Set
    End Property
	
	Public Property CantidadSolicitada() As Integer
        Get
            Return (m_CantidadSolicitada)
        End Get
		Set(ByVal Value As Integer)					
			m_CantidadSolicitada = Value
		End Set
    End Property
	
	Public Property CantidadDespachada() As Integer
        Get
            Return (m_CantidadDespachada)
        End Get
		Set(ByVal Value As Integer)					
			m_CantidadDespachada = Value
		End Set
    End Property
	
	Public Property CantidadRecibida() As Integer
        Get
            Return (m_CantidadRecibida)
        End Get
		Set(ByVal Value As Integer)					
			m_CantidadRecibida = Value
		End Set
    End Property
	
	Public Property costo() As Nullable(Of Decimal)
        Get
            Return (m_costo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
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
	
	Public Property ExistenciaAnteriorEntrada() As Nullable(Of Integer)
        Get
            Return (m_ExistenciaAnteriorEntrada)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_ExistenciaAnteriorEntrada = Value
		End Set
    End Property
	
	Public Property ExistenciaAnteriorSalida() As Nullable(Of Integer)
        Get
            Return (m_ExistenciaAnteriorSalida)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_ExistenciaAnteriorSalida = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivTransferenciaDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivTransferenciaDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "objRepuestoID"
				Return	50
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
    ''' Salva un DataSet del tipo de la tabla SivTransferenciaDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivTransferenciaDetalle </param>    
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
			cmdDelete.Parameters.Add("@objTransferenciaID", SqlDbType.Int, 4, "objTransferenciaID" )
			cmdDelete.Parameters.Add("@objTiendaDestinoID", SqlDbType.Int, 4, "objTiendaDestinoID" )
			cmdDelete.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID" )
			cmdDelete.CommandText = "DELETE FROM  SivTransferenciaDetalle WHERE objTransferenciaID= @objTransferenciaID And objTiendaDestinoID= @objTiendaDestinoID And objRepuestoID= @objRepuestoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objTransferenciaID", SqlDbType.Int, 4, "objTransferenciaID")
			cmdInsert.Parameters.Add("@objTiendaDestinoID", SqlDbType.Int, 4, "objTiendaDestinoID")
			cmdInsert.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdInsert.Parameters.Add("@CantidadSolicitada", SqlDbType.Int, 4, "CantidadSolicitada")
			cmdInsert.Parameters.Add("@CantidadDespachada", SqlDbType.Int, 4, "CantidadDespachada")
			cmdInsert.Parameters.Add("@CantidadRecibida", SqlDbType.Int, 4, "CantidadRecibida")
			cmdInsert.Parameters.Add("@costo", SqlDbType.Decimal, 9, "costo")
			cmdInsert.Parameters.Add("@subtotal", SqlDbType.Decimal, 9, "subtotal")
			cmdInsert.Parameters.Add("@ExistenciaAnteriorEntrada", SqlDbType.Int, 4, "ExistenciaAnteriorEntrada")
			cmdInsert.Parameters.Add("@ExistenciaAnteriorSalida", SqlDbType.Int, 4, "ExistenciaAnteriorSalida")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SivTransferenciaDetalle ( objTransferenciaID, objTiendaDestinoID, objRepuestoID, CantidadSolicitada, CantidadDespachada, CantidadRecibida, costo, subtotal, ExistenciaAnteriorEntrada, ExistenciaAnteriorSalida, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objTransferenciaID, @objTiendaDestinoID, @objRepuestoID, @CantidadSolicitada, @CantidadDespachada, @CantidadRecibida, @costo, @subtotal, @ExistenciaAnteriorEntrada, @ExistenciaAnteriorSalida, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objTransferenciaID", SqlDbType.Int, 4, "objTransferenciaID")
			cmdUpdate.Parameters.Add("@objTiendaDestinoID", SqlDbType.Int, 4, "objTiendaDestinoID")
			cmdUpdate.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdUpdate.Parameters.Add("@CantidadSolicitada", SqlDbType.Int, 4, "CantidadSolicitada")
			cmdUpdate.Parameters.Add("@CantidadDespachada", SqlDbType.Int, 4, "CantidadDespachada")
			cmdUpdate.Parameters.Add("@CantidadRecibida", SqlDbType.Int, 4, "CantidadRecibida")
			cmdUpdate.Parameters.Add("@costo", SqlDbType.Decimal, 9, "costo")
			cmdUpdate.Parameters.Add("@subtotal", SqlDbType.Decimal, 9, "subtotal")
			cmdUpdate.Parameters.Add("@ExistenciaAnteriorEntrada", SqlDbType.Int, 4, "ExistenciaAnteriorEntrada")
			cmdUpdate.Parameters.Add("@ExistenciaAnteriorSalida", SqlDbType.Int, 4, "ExistenciaAnteriorSalida")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wobjTransferenciaID", SqlDbType.Int, 4, "objTransferenciaID")
			cmdUpdate.Parameters.Add("@wobjTiendaDestinoID", SqlDbType.Int, 4, "objTiendaDestinoID")
			cmdUpdate.Parameters.Add("@wobjRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdUpdate.CommandText = "UPDATE SivTransferenciaDetalle SET objTransferenciaID=@objTransferenciaID, objTiendaDestinoID=@objTiendaDestinoID, objRepuestoID=@objRepuestoID, CantidadSolicitada=@CantidadSolicitada, CantidadDespachada=@CantidadDespachada, CantidadRecibida=@CantidadRecibida, costo=@costo, subtotal=@subtotal, ExistenciaAnteriorEntrada=@ExistenciaAnteriorEntrada, ExistenciaAnteriorSalida=@ExistenciaAnteriorSalida, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE objTransferenciaID= @wobjTransferenciaID And objTiendaDestinoID= @wobjTiendaDestinoID And objRepuestoID= @wobjRepuestoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivTransferenciaDetalle")
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
    ''' Devuelve de la base de datos un objeto SivTransferenciaDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_objTransferenciaID as Integer, Byval p_objTiendaDestinoID as Integer, Byval p_objRepuestoID as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivTransferenciaDetalle where " & " objTransferenciaID = " & p_objTransferenciaID & " and objTiendaDestinoID = " & p_objTiendaDestinoID & " and objRepuestoID = '" & p_objRepuestoID & "'" 		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_objTransferenciaID = IIf(IsDBNull(dr("objTransferenciaID")), Nothing, dr("objTransferenciaID"))					
				m_objTiendaDestinoID = IIf(IsDBNull(dr("objTiendaDestinoID")), Nothing, dr("objTiendaDestinoID"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_CantidadSolicitada = IIf(IsDBNull(dr("CantidadSolicitada")), Nothing, dr("CantidadSolicitada"))					
				m_CantidadDespachada = IIf(IsDBNull(dr("CantidadDespachada")), Nothing, dr("CantidadDespachada"))					
				m_CantidadRecibida = IIf(IsDBNull(dr("CantidadRecibida")), Nothing, dr("CantidadRecibida"))					
				m_costo = IIf(IsDBNull(dr("costo")), Nothing, dr("costo"))					
				m_subtotal = IIf(IsDBNull(dr("subtotal")), Nothing, dr("subtotal"))					
				m_ExistenciaAnteriorEntrada = IIf(IsDBNull(dr("ExistenciaAnteriorEntrada")), Nothing, dr("ExistenciaAnteriorEntrada"))					
				m_ExistenciaAnteriorSalida = IIf(IsDBNull(dr("ExistenciaAnteriorSalida")), Nothing, dr("ExistenciaAnteriorSalida"))					
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
    ''' Devuelve de la base de datos un objeto SivTransferenciaDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivTransferenciaDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_objTransferenciaID = IIf(IsDBNull(dr("objTransferenciaID")), Nothing, dr("objTransferenciaID"))					
				m_objTiendaDestinoID = IIf(IsDBNull(dr("objTiendaDestinoID")), Nothing, dr("objTiendaDestinoID"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_CantidadSolicitada = IIf(IsDBNull(dr("CantidadSolicitada")), Nothing, dr("CantidadSolicitada"))					
				m_CantidadDespachada = IIf(IsDBNull(dr("CantidadDespachada")), Nothing, dr("CantidadDespachada"))					
				m_CantidadRecibida = IIf(IsDBNull(dr("CantidadRecibida")), Nothing, dr("CantidadRecibida"))					
				m_costo = IIf(IsDBNull(dr("costo")), Nothing, dr("costo"))					
				m_subtotal = IIf(IsDBNull(dr("subtotal")), Nothing, dr("subtotal"))					
				m_ExistenciaAnteriorEntrada = IIf(IsDBNull(dr("ExistenciaAnteriorEntrada")), Nothing, dr("ExistenciaAnteriorEntrada"))					
				m_ExistenciaAnteriorSalida = IIf(IsDBNull(dr("ExistenciaAnteriorSalida")), Nothing, dr("ExistenciaAnteriorSalida"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivTransferenciaDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivTransferenciaDetalle"

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
			ds.Tables(0).TableName = "SivTransferenciaDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivTransferenciaDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivTransferenciaDetalle"

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
			ds.Tables(0).TableName = "SivTransferenciaDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivTransferenciaDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivTransferenciaDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivTransferenciaDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivTransferenciaDetalle("
		sCommand &= "objTransferenciaID,"
		sCommand &= "objTiendaDestinoID,"
		sCommand &= "objRepuestoID,"
		sCommand &= "CantidadSolicitada,"
		sCommand &= "CantidadDespachada,"
		sCommand &= "CantidadRecibida,"
		sCommand &= "costo,"
		sCommand &= "subtotal,"
		sCommand &= "ExistenciaAnteriorEntrada,"
		sCommand &= "ExistenciaAnteriorSalida,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objTransferenciaID,"
		sCommand &= "@objTiendaDestinoID,"
		sCommand &= "@objRepuestoID,"
		sCommand &= "@CantidadSolicitada,"
		sCommand &= "@CantidadDespachada,"
		sCommand &= "@CantidadRecibida,"
		sCommand &= "@costo,"
		sCommand &= "@subtotal,"
		sCommand &= "@ExistenciaAnteriorEntrada,"
		sCommand &= "@ExistenciaAnteriorSalida,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@objTransferenciaID", SqlDbType.Int)		
		If IsDBNull(m_objTransferenciaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_objTransferenciaID
        End If
		arParams(1) = New SqlParameter("@objTiendaDestinoID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaDestinoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTiendaDestinoID
        End If
		arParams(2) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objRepuestoID
        End If
		arParams(3) = New SqlParameter("@CantidadSolicitada", SqlDbType.Int)		
		If IsDBNull(m_CantidadSolicitada) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_CantidadSolicitada
        End If
		arParams(4) = New SqlParameter("@CantidadDespachada", SqlDbType.Int)		
		If IsDBNull(m_CantidadDespachada) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_CantidadDespachada
        End If
		arParams(5) = New SqlParameter("@CantidadRecibida", SqlDbType.Int)		
		If IsDBNull(m_CantidadRecibida) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_CantidadRecibida
        End If
		arParams(6) = New SqlParameter("@costo", SqlDbType.Decimal)		
		If IsDBNull(m_costo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_costo
        End If
		arParams(7) = New SqlParameter("@subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_subtotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_subtotal
        End If
		arParams(8) = New SqlParameter("@ExistenciaAnteriorEntrada", SqlDbType.Int)		
		If IsDBNull(m_ExistenciaAnteriorEntrada) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_ExistenciaAnteriorEntrada
        End If
		arParams(9) = New SqlParameter("@ExistenciaAnteriorSalida", SqlDbType.Int)		
		If IsDBNull(m_ExistenciaAnteriorSalida) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_ExistenciaAnteriorSalida
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
    ''' 	Actualiza el objeto SivTransferenciaDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivTransferenciaDetalle set "		
		sCommand &= "objTransferenciaID = @objTransferenciaID,"
		sCommand &= "objTiendaDestinoID = @objTiendaDestinoID,"
		sCommand &= "objRepuestoID = @objRepuestoID,"
		sCommand &= "CantidadSolicitada = @CantidadSolicitada,"
		sCommand &= "CantidadDespachada = @CantidadDespachada,"
		sCommand &= "CantidadRecibida = @CantidadRecibida,"
		sCommand &= "costo = @costo,"
		sCommand &= "subtotal = @subtotal,"
		sCommand &= "ExistenciaAnteriorEntrada = @ExistenciaAnteriorEntrada,"
		sCommand &= "ExistenciaAnteriorSalida = @ExistenciaAnteriorSalida,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "objTransferenciaID = @objTransferenciaID and "
		sCommand &= "objTiendaDestinoID = @objTiendaDestinoID and "
		sCommand &= "objRepuestoID = @objRepuestoID"					
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@objTransferenciaID", SqlDbType.Int)		
		If IsDBNull(m_objTransferenciaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_objTransferenciaID
        End If
		arParams(1) = New SqlParameter("@objTiendaDestinoID", SqlDbType.Int)		
		If IsDBNull(m_objTiendaDestinoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTiendaDestinoID
        End If
		arParams(2) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objRepuestoID
        End If
		arParams(3) = New SqlParameter("@CantidadSolicitada", SqlDbType.Int)		
		If IsDBNull(m_CantidadSolicitada) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_CantidadSolicitada
        End If
		arParams(4) = New SqlParameter("@CantidadDespachada", SqlDbType.Int)		
		If IsDBNull(m_CantidadDespachada) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_CantidadDespachada
        End If
		arParams(5) = New SqlParameter("@CantidadRecibida", SqlDbType.Int)		
		If IsDBNull(m_CantidadRecibida) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_CantidadRecibida
        End If
		arParams(6) = New SqlParameter("@costo", SqlDbType.Decimal)		
		If IsDBNull(m_costo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_costo
        End If
		arParams(7) = New SqlParameter("@subtotal", SqlDbType.Decimal)		
		If IsDBNull(m_subtotal) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_subtotal
        End If
		arParams(8) = New SqlParameter("@ExistenciaAnteriorEntrada", SqlDbType.Int)		
		If IsDBNull(m_ExistenciaAnteriorEntrada) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_ExistenciaAnteriorEntrada
        End If
		arParams(9) = New SqlParameter("@ExistenciaAnteriorSalida", SqlDbType.Int)		
		If IsDBNull(m_ExistenciaAnteriorSalida) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_ExistenciaAnteriorSalida
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
    ''' Borra un objeto SivTransferenciaDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivTransferenciaDetalle where " & " objTransferenciaID = " & m_objTransferenciaID & " and objTiendaDestinoID = " & m_objTiendaDestinoID & " and objRepuestoID = '" & m_objRepuestoID & "'" 
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
    ''' Borra un objeto SivTransferenciaDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_objTransferenciaID as Integer, Byval p_objTiendaDestinoID as Integer, Byval p_objRepuestoID as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivTransferenciaDetalle where " & " objTransferenciaID = " & p_objTransferenciaID & " and objTiendaDestinoID = " & p_objTiendaDestinoID & " and objRepuestoID = '" & p_objRepuestoID & "'" 
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
    ''' Borra objetos SivTransferenciaDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivTransferenciaDetalle where " & pWhere
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
