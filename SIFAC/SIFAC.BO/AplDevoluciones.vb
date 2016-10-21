Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class AplDevoluciones		

#Region " Variables Miembro " 
	Protected m_AplDevolucionID As Integer 
	Protected m_objSccClienteID As Nullable(Of Integer) 
	Protected m_objSccCuentaID As Nullable(Of Integer) 
	Protected m_objStbRutaID As Nullable(Of Integer) 
	Protected m_objSivProductoID As Nullable(Of Integer) 
	Protected m_objSfaFacturaID As Nullable(Of Integer) 
	Protected m_objVendedorID As Nullable(Of Integer) 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_RazonDevolucion As String = Nothing 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_TotalDevolucion As Nullable(Of Decimal) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property AplDevolucionID() As Integer
        Get
            Return (m_AplDevolucionID)
        End Get
		Set(ByVal Value As Integer)					
			m_AplDevolucionID = Value
		End Set
    End Property
	
	Public Property objSccClienteID() As Nullable(Of Integer)
        Get
            Return (m_objSccClienteID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccClienteID = Value
		End Set
    End Property
	
	Public Property objSccCuentaID() As Nullable(Of Integer)
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccCuentaID = Value
		End Set
    End Property
	
	Public Property objStbRutaID() As Nullable(Of Integer)
        Get
            Return (m_objStbRutaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objStbRutaID = Value
		End Set
    End Property
	
	Public Property objSivProductoID() As Nullable(Of Integer)
        Get
            Return (m_objSivProductoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSivProductoID = Value
		End Set
    End Property
	
	Public Property objSfaFacturaID() As Nullable(Of Integer)
        Get
            Return (m_objSfaFacturaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSfaFacturaID = Value
		End Set
    End Property
	
	Public Property objVendedorID() As Nullable(Of Integer)
        Get
            Return (m_objVendedorID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objVendedorID = Value
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
	
	Public Property Activo() As Nullable(Of Boolean)
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Activo = Value
		End Set
    End Property
	
	Public Property RazonDevolucion() As String
        Get
            Return (m_RazonDevolucion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("RazonDevolucion", Value.ToString(), "Valor inv?lido para AplDevoluciones.RazonDevolucion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_RazonDevolucion = Value
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
	
	Public Property TotalDevolucion() As Nullable(Of Decimal)
        Get
            Return (m_TotalDevolucion)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TotalDevolucion = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para AplDevoluciones.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioCreacion = Value
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
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para AplDevoluciones.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
			Case "RazonDevolucion"
				Return	100
			Case "TotalDevolucion"
				Return	18
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
			Case "TotalDevolucion"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla AplDevoluciones en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla AplDevoluciones </param>    
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
			cmdDelete.Parameters.Add("@AplDevolucionID", SqlDbType.Int, 4, "AplDevolucionID" )
			cmdDelete.CommandText = "DELETE FROM  AplDevoluciones WHERE AplDevolucionID= @AplDevolucionID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSccClienteID", SqlDbType.Int, 4, "objSccClienteID")
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdInsert.Parameters.Add("@objStbRutaID", SqlDbType.Int, 4, "objStbRutaID")
			cmdInsert.Parameters.Add("@objSivProductoID", SqlDbType.Int, 4, "objSivProductoID")
			cmdInsert.Parameters.Add("@objSfaFacturaID", SqlDbType.Int, 4, "objSfaFacturaID")
			cmdInsert.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@RazonDevolucion", SqlDbType.VarChar, 100, "RazonDevolucion")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@TotalDevolucion", SqlDbType.Decimal, 9, "TotalDevolucion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO AplDevoluciones ( objSccClienteID, objSccCuentaID, objStbRutaID, objSivProductoID, objSfaFacturaID, objVendedorID, objEstadoID, Activo, RazonDevolucion, Fecha, TotalDevolucion, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objSccClienteID, @objSccCuentaID, @objStbRutaID, @objSivProductoID, @objSfaFacturaID, @objVendedorID, @objEstadoID, @Activo, @RazonDevolucion, @Fecha, @TotalDevolucion, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSccClienteID", SqlDbType.Int, 4, "objSccClienteID")
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@objStbRutaID", SqlDbType.Int, 4, "objStbRutaID")
			cmdUpdate.Parameters.Add("@objSivProductoID", SqlDbType.Int, 4, "objSivProductoID")
			cmdUpdate.Parameters.Add("@objSfaFacturaID", SqlDbType.Int, 4, "objSfaFacturaID")
			cmdUpdate.Parameters.Add("@objVendedorID", SqlDbType.Int, 4, "objVendedorID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@RazonDevolucion", SqlDbType.VarChar, 100, "RazonDevolucion")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@TotalDevolucion", SqlDbType.Decimal, 9, "TotalDevolucion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wAplDevolucionID", SqlDbType.Int, 4, "AplDevolucionID")
			cmdUpdate.CommandText = "UPDATE AplDevoluciones SET objSccClienteID=@objSccClienteID, objSccCuentaID=@objSccCuentaID, objStbRutaID=@objStbRutaID, objSivProductoID=@objSivProductoID, objSfaFacturaID=@objSfaFacturaID, objVendedorID=@objVendedorID, objEstadoID=@objEstadoID, Activo=@Activo, RazonDevolucion=@RazonDevolucion, Fecha=@Fecha, TotalDevolucion=@TotalDevolucion, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE AplDevolucionID= @wAplDevolucionID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "AplDevoluciones")
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
    ''' Devuelve de la base de datos un objeto AplDevoluciones
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_AplDevolucionID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from AplDevoluciones where " & " AplDevolucionID = " & p_AplDevolucionID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_AplDevolucionID = dr("AplDevolucionID")
				m_objSccClienteID = IIf(IsDBNull(dr("objSccClienteID")), Nothing, dr("objSccClienteID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objStbRutaID = IIf(IsDBNull(dr("objStbRutaID")), Nothing, dr("objStbRutaID"))					
				m_objSivProductoID = IIf(IsDBNull(dr("objSivProductoID")), Nothing, dr("objSivProductoID"))					
				m_objSfaFacturaID = IIf(IsDBNull(dr("objSfaFacturaID")), Nothing, dr("objSfaFacturaID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_RazonDevolucion = IIf(IsDBNull(dr("RazonDevolucion")), Nothing, dr("RazonDevolucion"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_TotalDevolucion = IIf(IsDBNull(dr("TotalDevolucion")), Nothing, dr("TotalDevolucion"))					
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
    ''' Devuelve de la base de datos un objeto AplDevoluciones usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from AplDevoluciones where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_AplDevolucionID = dr("AplDevolucionID")
				m_objSccClienteID = IIf(IsDBNull(dr("objSccClienteID")), Nothing, dr("objSccClienteID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objStbRutaID = IIf(IsDBNull(dr("objStbRutaID")), Nothing, dr("objStbRutaID"))					
				m_objSivProductoID = IIf(IsDBNull(dr("objSivProductoID")), Nothing, dr("objSivProductoID"))					
				m_objSfaFacturaID = IIf(IsDBNull(dr("objSfaFacturaID")), Nothing, dr("objSfaFacturaID"))					
				m_objVendedorID = IIf(IsDBNull(dr("objVendedorID")), Nothing, dr("objVendedorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_RazonDevolucion = IIf(IsDBNull(dr("RazonDevolucion")), Nothing, dr("RazonDevolucion"))					
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))					
				m_TotalDevolucion = IIf(IsDBNull(dr("TotalDevolucion")), Nothing, dr("TotalDevolucion"))					
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
    ''' Trae de la base de datos un conjunto de objetos AplDevoluciones en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from AplDevoluciones"

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
			ds.Tables(0).TableName = "AplDevoluciones"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos AplDevoluciones en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from AplDevoluciones"

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
			ds.Tables(0).TableName = "AplDevoluciones"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos AplDevoluciones en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from AplDevoluciones"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase AplDevoluciones.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into AplDevoluciones("
		sCommand &= "objSccClienteID,"
		sCommand &= "objSccCuentaID,"
		sCommand &= "objStbRutaID,"
		sCommand &= "objSivProductoID,"
		sCommand &= "objSfaFacturaID,"
		sCommand &= "objVendedorID,"
		sCommand &= "objEstadoID,"
		sCommand &= "Activo,"
		sCommand &= "RazonDevolucion,"
		sCommand &= "Fecha,"
		sCommand &= "TotalDevolucion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objSccClienteID,"
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@objStbRutaID,"
		sCommand &= "@objSivProductoID,"
		sCommand &= "@objSfaFacturaID,"
		sCommand &= "@objVendedorID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@Activo,"
		sCommand &= "@RazonDevolucion,"
		sCommand &= "@Fecha,"
		sCommand &= "@TotalDevolucion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@AplDevolucionID = AplDevolucionID from AplDevoluciones where "		
		sCommand &= "AplDevolucionID = SCOPE_IDENTITY()"
		
		
		Dim arParams(15) As SqlParameter
		arParams(0) = New SqlParameter("@AplDevolucionID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSccClienteID", SqlDbType.Int)		
		If IsDBNull(m_objSccClienteID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccClienteID
        End If
		arParams(2) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSccCuentaID
        End If
		arParams(3) = New SqlParameter("@objStbRutaID", SqlDbType.Int)		
		If IsDBNull(m_objStbRutaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objStbRutaID
        End If
		arParams(4) = New SqlParameter("@objSivProductoID", SqlDbType.Int)		
		If IsDBNull(m_objSivProductoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objSivProductoID
        End If
		arParams(5) = New SqlParameter("@objSfaFacturaID", SqlDbType.Int)		
		If IsDBNull(m_objSfaFacturaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objSfaFacturaID
        End If
		arParams(6) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objVendedorID
        End If
		arParams(7) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objEstadoID
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
		arParams(9) = New SqlParameter("@RazonDevolucion", SqlDbType.VarChar)		
		If IsDBNull(m_RazonDevolucion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_RazonDevolucion
        End If
		arParams(10) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Fecha
        End If
		arParams(11) = New SqlParameter("@TotalDevolucion", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDevolucion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_TotalDevolucion
        End If
		arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
		arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
		arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
		arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_AplDevolucionID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto AplDevoluciones en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update AplDevoluciones set "		
		sCommand &= "objSccClienteID = @objSccClienteID,"
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "objStbRutaID = @objStbRutaID,"
		sCommand &= "objSivProductoID = @objSivProductoID,"
		sCommand &= "objSfaFacturaID = @objSfaFacturaID,"
		sCommand &= "objVendedorID = @objVendedorID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "RazonDevolucion = @RazonDevolucion,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "TotalDevolucion = @TotalDevolucion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "AplDevolucionID = @AplDevolucionID"					
		
		Dim arParams(15) As SqlParameter
		arParams(0) = New SqlParameter("@AplDevolucionID", SqlDbType.Int)		
		If IsDBNull(m_AplDevolucionID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_AplDevolucionID
        End If
		arParams(1) = New SqlParameter("@objSccClienteID", SqlDbType.Int)		
		If IsDBNull(m_objSccClienteID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccClienteID
        End If
		arParams(2) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSccCuentaID
        End If
		arParams(3) = New SqlParameter("@objStbRutaID", SqlDbType.Int)		
		If IsDBNull(m_objStbRutaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objStbRutaID
        End If
		arParams(4) = New SqlParameter("@objSivProductoID", SqlDbType.Int)		
		If IsDBNull(m_objSivProductoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objSivProductoID
        End If
		arParams(5) = New SqlParameter("@objSfaFacturaID", SqlDbType.Int)		
		If IsDBNull(m_objSfaFacturaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objSfaFacturaID
        End If
		arParams(6) = New SqlParameter("@objVendedorID", SqlDbType.Int)		
		If IsDBNull(m_objVendedorID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objVendedorID
        End If
		arParams(7) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objEstadoID
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
		arParams(9) = New SqlParameter("@RazonDevolucion", SqlDbType.VarChar)		
		If IsDBNull(m_RazonDevolucion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_RazonDevolucion
        End If
		arParams(10) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Fecha
        End If
		arParams(11) = New SqlParameter("@TotalDevolucion", SqlDbType.Decimal)		
		If IsDBNull(m_TotalDevolucion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_TotalDevolucion
        End If
		arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
		arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
		arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
		arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
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
    ''' Borra un objeto AplDevoluciones de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplDevoluciones where " & " AplDevolucionID = " & m_AplDevolucionID
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
    ''' Borra un objeto AplDevoluciones de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_AplDevolucionID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplDevoluciones where " & " AplDevolucionID = " & p_AplDevolucionID
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
    ''' Borra objetos AplDevoluciones de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplDevoluciones where " & pWhere
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
