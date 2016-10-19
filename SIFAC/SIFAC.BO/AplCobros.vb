Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class AplCobros		

#Region " Variables Miembro " 
	Protected m_AplCobroID As Integer 
	Protected m_objSccClienteID As Nullable(Of Integer) 
	Protected m_objSccCuentaID As Nullable(Of Integer) 
	Protected m_objStbRutaID As Nullable(Of Integer) 
	Protected m_objCobradorID As Nullable(Of Integer) 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_Abono As Nullable(Of Boolean) 
	Protected m_Cancelo As Nullable(Of Boolean) 
	Protected m_MotivoNoAbono As String = Nothing 
	Protected m_MontoAbonado As Nullable(Of Decimal) 
	Protected m_Saldo As Nullable(Of Decimal) 
	Protected m_FechaAbono As Nullable(Of Date) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property AplCobroID() As Integer
        Get
            Return (m_AplCobroID)
        End Get
		Set(ByVal Value As Integer)					
			m_AplCobroID = Value
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
	
	Public Property objCobradorID() As Nullable(Of Integer)
        Get
            Return (m_objCobradorID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCobradorID = Value
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
	
	Public Property Abono() As Nullable(Of Boolean)
        Get
            Return (m_Abono)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Abono = Value
		End Set
    End Property
	
	Public Property Cancelo() As Nullable(Of Boolean)
        Get
            Return (m_Cancelo)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Cancelo = Value
		End Set
    End Property
	
	Public Property MotivoNoAbono() As String
        Get
            Return (m_MotivoNoAbono)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("MotivoNoAbono", Value.ToString(), "Valor inv?lido para AplCobros.MotivoNoAbono. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_MotivoNoAbono = Value
		End Set
    End Property
	
	Public Property MontoAbonado() As Nullable(Of Decimal)
        Get
            Return (m_MontoAbonado)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_MontoAbonado = Value
		End Set
    End Property
	
	Public Property Saldo() As Nullable(Of Decimal)
        Get
            Return (m_Saldo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Saldo = Value
		End Set
    End Property
	
	Public Property FechaAbono() As Nullable(Of Date)
        Get
            Return (m_FechaAbono)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaAbono = Value
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
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para AplCobros.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para AplCobros.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "MotivoNoAbono"
				Return	50
			Case "MontoAbonado"
				Return	18
			Case "Saldo"
				Return	18
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
			Case "MontoAbonado"
				Return	2
			Case "Saldo"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla AplCobros en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla AplCobros </param>    
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
			cmdDelete.Parameters.Add("@AplCobroID", SqlDbType.Int, 4, "AplCobroID" )
			cmdDelete.CommandText = "DELETE FROM  AplCobros WHERE AplCobroID= @AplCobroID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSccClienteID", SqlDbType.Int, 4, "objSccClienteID")
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdInsert.Parameters.Add("@objStbRutaID", SqlDbType.Int, 4, "objStbRutaID")
			cmdInsert.Parameters.Add("@objCobradorID", SqlDbType.Int, 4, "objCobradorID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@Abono", SqlDbType.Bit, 1, "Abono")
			cmdInsert.Parameters.Add("@Cancelo", SqlDbType.Bit, 1, "Cancelo")
			cmdInsert.Parameters.Add("@MotivoNoAbono", SqlDbType.VarChar, 50, "MotivoNoAbono")
			cmdInsert.Parameters.Add("@MontoAbonado", SqlDbType.Decimal, 9, "MontoAbonado")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@FechaAbono", SqlDbType.DateTime, 8, "FechaAbono")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO AplCobros ( objSccClienteID, objSccCuentaID, objStbRutaID, objCobradorID, objEstadoID, Activo, Abono, Cancelo, MotivoNoAbono, MontoAbonado, Saldo, FechaAbono, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objSccClienteID, @objSccCuentaID, @objStbRutaID, @objCobradorID, @objEstadoID, @Activo, @Abono, @Cancelo, @MotivoNoAbono, @MontoAbonado, @Saldo, @FechaAbono, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSccClienteID", SqlDbType.Int, 4, "objSccClienteID")
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@objStbRutaID", SqlDbType.Int, 4, "objStbRutaID")
			cmdUpdate.Parameters.Add("@objCobradorID", SqlDbType.Int, 4, "objCobradorID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@Abono", SqlDbType.Bit, 1, "Abono")
			cmdUpdate.Parameters.Add("@Cancelo", SqlDbType.Bit, 1, "Cancelo")
			cmdUpdate.Parameters.Add("@MotivoNoAbono", SqlDbType.VarChar, 50, "MotivoNoAbono")
			cmdUpdate.Parameters.Add("@MontoAbonado", SqlDbType.Decimal, 9, "MontoAbonado")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@FechaAbono", SqlDbType.DateTime, 8, "FechaAbono")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wAplCobroID", SqlDbType.Int, 4, "AplCobroID")
			cmdUpdate.CommandText = "UPDATE AplCobros SET objSccClienteID=@objSccClienteID, objSccCuentaID=@objSccCuentaID, objStbRutaID=@objStbRutaID, objCobradorID=@objCobradorID, objEstadoID=@objEstadoID, Activo=@Activo, Abono=@Abono, Cancelo=@Cancelo, MotivoNoAbono=@MotivoNoAbono, MontoAbonado=@MontoAbonado, Saldo=@Saldo, FechaAbono=@FechaAbono, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE AplCobroID= @wAplCobroID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "AplCobros")
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
    ''' Devuelve de la base de datos un objeto AplCobros
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_AplCobroID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from AplCobros where " & " AplCobroID = " & p_AplCobroID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_AplCobroID = dr("AplCobroID")
				m_objSccClienteID = IIf(IsDBNull(dr("objSccClienteID")), Nothing, dr("objSccClienteID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objStbRutaID = IIf(IsDBNull(dr("objStbRutaID")), Nothing, dr("objStbRutaID"))					
				m_objCobradorID = IIf(IsDBNull(dr("objCobradorID")), Nothing, dr("objCobradorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_Abono = IIf(IsDBNull(dr("Abono")), Nothing, dr("Abono"))					
				m_Cancelo = IIf(IsDBNull(dr("Cancelo")), Nothing, dr("Cancelo"))					
				m_MotivoNoAbono = IIf(IsDBNull(dr("MotivoNoAbono")), Nothing, dr("MotivoNoAbono"))					
				m_MontoAbonado = IIf(IsDBNull(dr("MontoAbonado")), Nothing, dr("MontoAbonado"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_FechaAbono = IIf(IsDBNull(dr("FechaAbono")), Nothing, dr("FechaAbono"))					
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
    ''' Devuelve de la base de datos un objeto AplCobros usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from AplCobros where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_AplCobroID = dr("AplCobroID")
				m_objSccClienteID = IIf(IsDBNull(dr("objSccClienteID")), Nothing, dr("objSccClienteID"))					
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))					
				m_objStbRutaID = IIf(IsDBNull(dr("objStbRutaID")), Nothing, dr("objStbRutaID"))					
				m_objCobradorID = IIf(IsDBNull(dr("objCobradorID")), Nothing, dr("objCobradorID"))					
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))					
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))					
				m_Abono = IIf(IsDBNull(dr("Abono")), Nothing, dr("Abono"))					
				m_Cancelo = IIf(IsDBNull(dr("Cancelo")), Nothing, dr("Cancelo"))					
				m_MotivoNoAbono = IIf(IsDBNull(dr("MotivoNoAbono")), Nothing, dr("MotivoNoAbono"))					
				m_MontoAbonado = IIf(IsDBNull(dr("MontoAbonado")), Nothing, dr("MontoAbonado"))					
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))					
				m_FechaAbono = IIf(IsDBNull(dr("FechaAbono")), Nothing, dr("FechaAbono"))					
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
    ''' Trae de la base de datos un conjunto de objetos AplCobros en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from AplCobros"

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
			ds.Tables(0).TableName = "AplCobros"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos AplCobros en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from AplCobros"

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
			ds.Tables(0).TableName = "AplCobros"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos AplCobros en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from AplCobros"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase AplCobros.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into AplCobros("
		sCommand &= "objSccClienteID,"
		sCommand &= "objSccCuentaID,"
		sCommand &= "objStbRutaID,"
		sCommand &= "objCobradorID,"
		sCommand &= "objEstadoID,"
		sCommand &= "Activo,"
		sCommand &= "Abono,"
		sCommand &= "Cancelo,"
		sCommand &= "MotivoNoAbono,"
		sCommand &= "MontoAbonado,"
		sCommand &= "Saldo,"
		sCommand &= "FechaAbono,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objSccClienteID,"
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@objStbRutaID,"
		sCommand &= "@objCobradorID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@Activo,"
		sCommand &= "@Abono,"
		sCommand &= "@Cancelo,"
		sCommand &= "@MotivoNoAbono,"
		sCommand &= "@MontoAbonado,"
		sCommand &= "@Saldo,"
		sCommand &= "@FechaAbono,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@AplCobroID = AplCobroID from AplCobros where "		
		sCommand &= "AplCobroID = SCOPE_IDENTITY()"
		
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@AplCobroID", SqlDbType.Int)		
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
		arParams(4) = New SqlParameter("@objCobradorID", SqlDbType.Int)		
		If IsDBNull(m_objCobradorID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCobradorID
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Activo
        End If
		arParams(7) = New SqlParameter("@Abono", SqlDbType.Bit)		
		If IsDBNull(m_Abono) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Abono
        End If
		arParams(8) = New SqlParameter("@Cancelo", SqlDbType.Bit)		
		If IsDBNull(m_Cancelo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Cancelo
        End If
		arParams(9) = New SqlParameter("@MotivoNoAbono", SqlDbType.VarChar)		
		If IsDBNull(m_MotivoNoAbono) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_MotivoNoAbono
        End If
		arParams(10) = New SqlParameter("@MontoAbonado", SqlDbType.Decimal)		
		If IsDBNull(m_MontoAbonado) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_MontoAbonado
        End If
		arParams(11) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Saldo
        End If
		arParams(12) = New SqlParameter("@FechaAbono", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAbono) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaAbono
        End If
		arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
		arParams(14) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioCreacion
        End If
		arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
        End If
		arParams(16) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_AplCobroID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto AplCobros en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update AplCobros set "		
		sCommand &= "objSccClienteID = @objSccClienteID,"
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "objStbRutaID = @objStbRutaID,"
		sCommand &= "objCobradorID = @objCobradorID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "Abono = @Abono,"
		sCommand &= "Cancelo = @Cancelo,"
		sCommand &= "MotivoNoAbono = @MotivoNoAbono,"
		sCommand &= "MontoAbonado = @MontoAbonado,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "FechaAbono = @FechaAbono,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "AplCobroID = @AplCobroID"					
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@AplCobroID", SqlDbType.Int)		
		If IsDBNull(m_AplCobroID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_AplCobroID
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
		arParams(4) = New SqlParameter("@objCobradorID", SqlDbType.Int)		
		If IsDBNull(m_objCobradorID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCobradorID
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Activo
        End If
		arParams(7) = New SqlParameter("@Abono", SqlDbType.Bit)		
		If IsDBNull(m_Abono) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Abono
        End If
		arParams(8) = New SqlParameter("@Cancelo", SqlDbType.Bit)		
		If IsDBNull(m_Cancelo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Cancelo
        End If
		arParams(9) = New SqlParameter("@MotivoNoAbono", SqlDbType.VarChar)		
		If IsDBNull(m_MotivoNoAbono) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_MotivoNoAbono
        End If
		arParams(10) = New SqlParameter("@MontoAbonado", SqlDbType.Decimal)		
		If IsDBNull(m_MontoAbonado) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_MontoAbonado
        End If
		arParams(11) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Saldo
        End If
		arParams(12) = New SqlParameter("@FechaAbono", SqlDbType.DateTime)		
		If IsDBNull(m_FechaAbono) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaAbono
        End If
		arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
		arParams(14) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioCreacion
        End If
		arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
        End If
		arParams(16) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_UsuarioModificacion
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
    ''' Borra un objeto AplCobros de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplCobros where " & " AplCobroID = " & m_AplCobroID
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
    ''' Borra un objeto AplCobros de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_AplCobroID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplCobros where " & " AplCobroID = " & p_AplCobroID
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
    ''' Borra objetos AplCobros de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from AplCobros where " & pWhere
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
