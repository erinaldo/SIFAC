Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SccArqueoCaja		

#Region " Variables Miembro " 
	Protected m_ArqueoID As Integer 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_EntradaEfectivo As Nullable(Of Decimal) 
	Protected m_SalidaEfectivo As Nullable(Of Decimal) 
	Protected m_Faltante As Nullable(Of Decimal) 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_AprobadoPor As String = Nothing 
	Protected m_objCajaID As Nullable(Of Integer) 
	Protected m_objCajeroID As Nullable(Of Integer) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_objRutaID As Nullable(Of Integer) 
	Protected m_Aprobado As Nullable(Of Boolean) 
#End Region

#Region " Propiedades "
	Public Property ArqueoID() As Integer
        Get
            Return (m_ArqueoID)
        End Get
		Set(ByVal Value As Integer)					
			m_ArqueoID = Value
		End Set
    End Property
	
	Public Property Fecha() As Nullable(Of Date)
        Get
            Return (m_Fecha)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_Fecha = Value
		End Set
    End Property
	
	Public Property EntradaEfectivo() As Nullable(Of Decimal)
        Get
            Return (m_EntradaEfectivo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_EntradaEfectivo = Value
		End Set
    End Property
	
	Public Property SalidaEfectivo() As Nullable(Of Decimal)
        Get
            Return (m_SalidaEfectivo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_SalidaEfectivo = Value
		End Set
    End Property
	
	Public Property Faltante() As Nullable(Of Decimal)
        Get
            Return (m_Faltante)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Faltante = Value
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
	
	Public Property AprobadoPor() As String
        Get
            Return (m_AprobadoPor)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("AprobadoPor", Value.ToString(), "Valor inv?lido para SccArqueoCaja.AprobadoPor. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_AprobadoPor = Value
		End Set
    End Property
	
	Public Property objCajaID() As Nullable(Of Integer)
        Get
            Return (m_objCajaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajaID = Value
		End Set
    End Property
	
	Public Property objCajeroID() As Nullable(Of Integer)
        Get
            Return (m_objCajeroID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajeroID = Value
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccArqueoCaja.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccArqueoCaja.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property objRutaID() As Nullable(Of Integer)
        Get
            Return (m_objRutaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objRutaID = Value
		End Set
    End Property
	
	Public Property Aprobado() As Nullable(Of Boolean)
        Get
            Return (m_Aprobado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Aprobado = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "EntradaEfectivo"
				Return	18
			Case "SalidaEfectivo"
				Return	18
			Case "Faltante"
				Return	18
			Case "AprobadoPor"
				Return	50
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "EntradaEfectivo"
				Return	2
			Case "SalidaEfectivo"
				Return	2
			Case "Faltante"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccArqueoCaja en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccArqueoCaja </param>    
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
			cmdDelete.Parameters.Add("@ArqueoID", SqlDbType.Int, 4, "ArqueoID" )
			cmdDelete.CommandText = "DELETE FROM  SccArqueoCaja WHERE ArqueoID= @ArqueoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@EntradaEfectivo", SqlDbType.Decimal, 9, "EntradaEfectivo")
			cmdInsert.Parameters.Add("@SalidaEfectivo", SqlDbType.Decimal, 9, "SalidaEfectivo")
			cmdInsert.Parameters.Add("@Faltante", SqlDbType.Decimal, 9, "Faltante")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@AprobadoPor", SqlDbType.VarChar, 50, "AprobadoPor")
			cmdInsert.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdInsert.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@objRutaID", SqlDbType.Int, 4, "objRutaID")
			cmdInsert.Parameters.Add("@Aprobado", SqlDbType.Bit, 1, "Aprobado")
			cmdInsert.CommandText = "INSERT INTO SccArqueoCaja ( Fecha, EntradaEfectivo, SalidaEfectivo, Faltante, objEstadoID, AprobadoPor, objCajaID, objCajeroID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, objRutaID, Aprobado) VALUES ( @Fecha, @EntradaEfectivo, @SalidaEfectivo, @Faltante, @objEstadoID, @AprobadoPor, @objCajaID, @objCajeroID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @objRutaID, @Aprobado)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@EntradaEfectivo", SqlDbType.Decimal, 9, "EntradaEfectivo")
			cmdUpdate.Parameters.Add("@SalidaEfectivo", SqlDbType.Decimal, 9, "SalidaEfectivo")
			cmdUpdate.Parameters.Add("@Faltante", SqlDbType.Decimal, 9, "Faltante")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@AprobadoPor", SqlDbType.VarChar, 50, "AprobadoPor")
			cmdUpdate.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdUpdate.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@objRutaID", SqlDbType.Int, 4, "objRutaID")
			cmdUpdate.Parameters.Add("@Aprobado", SqlDbType.Bit, 1, "Aprobado")
			cmdUpdate.Parameters.Add("@wArqueoID", SqlDbType.Int, 4, "ArqueoID")
			cmdUpdate.CommandText = "UPDATE SccArqueoCaja SET Fecha=@Fecha, EntradaEfectivo=@EntradaEfectivo, SalidaEfectivo=@SalidaEfectivo, Faltante=@Faltante, objEstadoID=@objEstadoID, AprobadoPor=@AprobadoPor, objCajaID=@objCajaID, objCajeroID=@objCajeroID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, objRutaID=@objRutaID, Aprobado=@Aprobado WHERE ArqueoID= @wArqueoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccArqueoCaja")
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
    ''' Devuelve de la base de datos un objeto SccArqueoCaja
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ArqueoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccArqueoCaja where " & " ArqueoID = " & p_ArqueoID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_ArqueoID = dr("ArqueoID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_EntradaEfectivo = IIf(IsDBNull(dr("EntradaEfectivo")), Nothing, dr("EntradaEfectivo"))					
				m_SalidaEfectivo = IIf(IsDBNull(dr("SalidaEfectivo")), Nothing, dr("SalidaEfectivo"))					
				m_Faltante = IIf(IsDBNull(dr("Faltante")), Nothing, dr("Faltante"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_AprobadoPor = IIf(IsDBNull(dr("AprobadoPor")), Nothing, dr("AprobadoPor"))					
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))					
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_objRutaID = IIf(IsDBNull(dr("objRutaID")), Nothing, dr("objRutaID"))					
				m_Aprobado = IIf(IsDBNull(dr("Aprobado")), Nothing, dr("Aprobado"))					
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
    ''' Devuelve de la base de datos un objeto SccArqueoCaja usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccArqueoCaja where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_ArqueoID = dr("ArqueoID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_EntradaEfectivo = IIf(IsDBNull(dr("EntradaEfectivo")), Nothing, dr("EntradaEfectivo"))					
				m_SalidaEfectivo = IIf(IsDBNull(dr("SalidaEfectivo")), Nothing, dr("SalidaEfectivo"))					
				m_Faltante = IIf(IsDBNull(dr("Faltante")), Nothing, dr("Faltante"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_AprobadoPor = IIf(IsDBNull(dr("AprobadoPor")), Nothing, dr("AprobadoPor"))					
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))					
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))					
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))					
				m_objRutaID = IIf(IsDBNull(dr("objRutaID")), Nothing, dr("objRutaID"))					
				m_Aprobado = IIf(IsDBNull(dr("Aprobado")), Nothing, dr("Aprobado"))					
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
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCaja en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccArqueoCaja"

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
			ds.Tables(0).TableName = "SccArqueoCaja"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCaja en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccArqueoCaja"

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
			ds.Tables(0).TableName = "SccArqueoCaja"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCaja en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccArqueoCaja"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccArqueoCaja.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccArqueoCaja("
		sCommand &= "Fecha,"
		sCommand &= "EntradaEfectivo,"
		sCommand &= "SalidaEfectivo,"
		sCommand &= "Faltante,"
		sCommand &= "objEstadoID,"
		sCommand &= "AprobadoPor,"
		sCommand &= "objCajaID,"
		sCommand &= "objCajeroID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "objRutaID,"
		sCommand &= "Aprobado) values ("		
		sCommand &= "@Fecha,"
		sCommand &= "@EntradaEfectivo,"
		sCommand &= "@SalidaEfectivo,"
		sCommand &= "@Faltante,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@AprobadoPor,"
		sCommand &= "@objCajaID,"
		sCommand &= "@objCajeroID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@objRutaID,"
		sCommand &= "@Aprobado)"		
	
		sCommand &= " select "
		sCommand &= "@ArqueoID = ArqueoID from SccArqueoCaja where "		
		sCommand &= "ArqueoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@ArqueoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@EntradaEfectivo", SqlDbType.Decimal)		
		If IsDBNull(m_EntradaEfectivo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_EntradaEfectivo
        End If
		arParams(3) = New SqlParameter("@SalidaEfectivo", SqlDbType.Decimal)		
		If IsDBNull(m_SalidaEfectivo) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_SalidaEfectivo
        End If
		arParams(4) = New SqlParameter("@Faltante", SqlDbType.Decimal)		
		If IsDBNull(m_Faltante) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Faltante
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@AprobadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_AprobadoPor) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_AprobadoPor
        End If
		arParams(7) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objCajaID
        End If
		arParams(8) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objCajeroID
        End If
		arParams(9) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCreacion
        End If
		arParams(10) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioCreacion
        End If
		arParams(11) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaModificacion
        End If
		arParams(12) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioModificacion
        End If
		arParams(13) = New SqlParameter("@objRutaID", SqlDbType.Int)		
		If IsDBNull(m_objRutaID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objRutaID
        End If
		arParams(14) = New SqlParameter("@Aprobado", SqlDbType.Bit)		
		If IsDBNull(m_Aprobado) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Aprobado
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ArqueoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccArqueoCaja en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccArqueoCaja set "		
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "EntradaEfectivo = @EntradaEfectivo,"
		sCommand &= "SalidaEfectivo = @SalidaEfectivo,"
		sCommand &= "Faltante = @Faltante,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "AprobadoPor = @AprobadoPor,"
		sCommand &= "objCajaID = @objCajaID,"
		sCommand &= "objCajeroID = @objCajeroID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "objRutaID = @objRutaID,"
		sCommand &= "Aprobado = @Aprobado"		
		sCommand &= " where "	
		sCommand &= "ArqueoID = @ArqueoID"					
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@ArqueoID", SqlDbType.Int)		
		If IsDBNull(m_ArqueoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ArqueoID
        End If
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@EntradaEfectivo", SqlDbType.Decimal)		
		If IsDBNull(m_EntradaEfectivo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_EntradaEfectivo
        End If
		arParams(3) = New SqlParameter("@SalidaEfectivo", SqlDbType.Decimal)		
		If IsDBNull(m_SalidaEfectivo) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_SalidaEfectivo
        End If
		arParams(4) = New SqlParameter("@Faltante", SqlDbType.Decimal)		
		If IsDBNull(m_Faltante) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Faltante
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@AprobadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_AprobadoPor) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_AprobadoPor
        End If
		arParams(7) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objCajaID
        End If
		arParams(8) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objCajeroID
        End If
		arParams(9) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCreacion
        End If
		arParams(10) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioCreacion
        End If
		arParams(11) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaModificacion
        End If
		arParams(12) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioModificacion
        End If
		arParams(13) = New SqlParameter("@objRutaID", SqlDbType.Int)		
		If IsDBNull(m_objRutaID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objRutaID
        End If
		arParams(14) = New SqlParameter("@Aprobado", SqlDbType.Bit)		
		If IsDBNull(m_Aprobado) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Aprobado
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
    ''' Borra un objeto SccArqueoCaja de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCaja where " & " ArqueoID = " & m_ArqueoID
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
    ''' Borra un objeto SccArqueoCaja de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ArqueoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCaja where " & " ArqueoID = " & p_ArqueoID
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
    ''' Borra objetos SccArqueoCaja de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCaja where " & pWhere
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
