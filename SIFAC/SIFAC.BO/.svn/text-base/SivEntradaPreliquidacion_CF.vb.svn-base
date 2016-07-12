Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivEntradaPreliquidacion		

#Region " Variables Miembro " 
	Protected m_SivEntradaPreliquidacionID As Integer 
	Protected m_objEntradaBodegaID As Integer 
	Protected m_objEntradaBodegaDetalleID As Integer 
	Protected m_objEntradaBodegaDetPreliID As Integer 
	Protected m_SiEntradaReal As Boolean 
	Protected m_NumeroEntradaReal As Nullable(Of Integer) 
	Protected m_objRepuestoID As String = Nothing 
	Protected m_objProveedorID As Integer 
	Protected m_NumeroFactura As String = Nothing 
	Protected m_FechaFactura As Date 
	Protected m_NumeroPoliza As String = Nothing 
	Protected m_Costo As Decimal 
	Protected m_CantidadFactura As Decimal 
	Protected m_Cantidad As Decimal 
	Protected m_CantidadEnPreli As Decimal 
	Protected m_CantidadFalta As Decimal 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SivEntradaPreliquidacionID() As Integer
        Get
            Return (m_SivEntradaPreliquidacionID)
        End Get
		Set(ByVal Value As Integer)					
			m_SivEntradaPreliquidacionID = Value
		End Set
    End Property
	
	Public Property objEntradaBodegaID() As Integer
        Get
            Return (m_objEntradaBodegaID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEntradaBodegaID = Value
		End Set
    End Property
	
	Public Property objEntradaBodegaDetalleID() As Integer
        Get
            Return (m_objEntradaBodegaDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEntradaBodegaDetalleID = Value
		End Set
    End Property
	
	Public Property objEntradaBodegaDetPreliID() As Integer
        Get
            Return (m_objEntradaBodegaDetPreliID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEntradaBodegaDetPreliID = Value
		End Set
    End Property
	
	Public Property SiEntradaReal() As Boolean
        Get
            Return (m_SiEntradaReal)
        End Get
		Set(ByVal Value As Boolean)					
			m_SiEntradaReal = Value
		End Set
    End Property
	
	Public Property NumeroEntradaReal() As Nullable(Of Integer)
        Get
            Return (m_NumeroEntradaReal)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_NumeroEntradaReal = Value
		End Set
    End Property
	
	Public Property objRepuestoID() As String
        Get
            Return (m_objRepuestoID)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("objRepuestoID", Value.ToString(), "Valor inv?lido para SivEntradaPreliquidacion.objRepuestoID. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_objRepuestoID = Value
		End Set
    End Property
	
	Public Property objProveedorID() As Integer
        Get
            Return (m_objProveedorID)
        End Get
		Set(ByVal Value As Integer)					
			m_objProveedorID = Value
		End Set
    End Property
	
	Public Property NumeroFactura() As String
        Get
            Return (m_NumeroFactura)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 40 Then
					Throw New ArgumentOutOfRangeException("NumeroFactura", Value.ToString(), "Valor inv?lido para SivEntradaPreliquidacion.NumeroFactura. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (40).")
				End If
			End If
			m_NumeroFactura = Value
		End Set
    End Property
	
	Public Property FechaFactura() As Date
        Get
            Return (m_FechaFactura)
        End Get
		Set(ByVal Value As Date)					
			m_FechaFactura = Value
		End Set
    End Property
	
	Public Property NumeroPoliza() As String
        Get
            Return (m_NumeroPoliza)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 15 Then
					Throw New ArgumentOutOfRangeException("NumeroPoliza", Value.ToString(), "Valor inv?lido para SivEntradaPreliquidacion.NumeroPoliza. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (15).")
				End If
			End If
			m_NumeroPoliza = Value
		End Set
    End Property
	
	Public Property Costo() As Decimal
        Get
            Return (m_Costo)
        End Get
		Set(ByVal Value As Decimal)					
			m_Costo = Value
		End Set
    End Property
	
	Public Property CantidadFactura() As Decimal
        Get
            Return (m_CantidadFactura)
        End Get
		Set(ByVal Value As Decimal)					
			m_CantidadFactura = Value
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
	
	Public Property CantidadEnPreli() As Decimal
        Get
            Return (m_CantidadEnPreli)
        End Get
		Set(ByVal Value As Decimal)					
			m_CantidadEnPreli = Value
		End Set
    End Property
	
	Public Property CantidadFalta() As Decimal
        Get
            Return (m_CantidadFalta)
        End Get
		Set(ByVal Value As Decimal)					
			m_CantidadFalta = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivEntradaPreliquidacion.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "objRepuestoID"
				Return	50
			Case "NumeroFactura"
				Return	40
			Case "NumeroPoliza"
				Return	15
			Case "Costo"
				Return	11
			Case "CantidadFactura"
				Return	11
			Case "Cantidad"
				Return	11
			Case "CantidadEnPreli"
				Return	11
			Case "CantidadFalta"
				Return	11
			Case "UsuarioCreacion"
				Return	30
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Costo"
				Return	2
			Case "CantidadFactura"
				Return	2
			Case "Cantidad"
				Return	2
			Case "CantidadEnPreli"
				Return	2
			Case "CantidadFalta"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivEntradaPreliquidacion en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivEntradaPreliquidacion </param>    
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
			cmdDelete.Parameters.Add("@SivEntradaPreliquidacionID", SqlDbType.Int, 4, "SivEntradaPreliquidacionID" )
			cmdDelete.CommandText = "DELETE FROM  SivEntradaPreliquidacion WHERE SivEntradaPreliquidacionID= @SivEntradaPreliquidacionID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objEntradaBodegaID", SqlDbType.Int, 4, "objEntradaBodegaID")
			cmdInsert.Parameters.Add("@objEntradaBodegaDetalleID", SqlDbType.Int, 4, "objEntradaBodegaDetalleID")
			cmdInsert.Parameters.Add("@objEntradaBodegaDetPreliID", SqlDbType.Int, 4, "objEntradaBodegaDetPreliID")
			cmdInsert.Parameters.Add("@SiEntradaReal", SqlDbType.Bit, 1, "SiEntradaReal")
			cmdInsert.Parameters.Add("@NumeroEntradaReal", SqlDbType.Int, 4, "NumeroEntradaReal")
			cmdInsert.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdInsert.Parameters.Add("@objProveedorID", SqlDbType.Int, 4, "objProveedorID")
			cmdInsert.Parameters.Add("@NumeroFactura", SqlDbType.VarChar, 40, "NumeroFactura")
			cmdInsert.Parameters.Add("@FechaFactura", SqlDbType.DateTime, 8, "FechaFactura")
			cmdInsert.Parameters.Add("@NumeroPoliza", SqlDbType.VarChar, 15, "NumeroPoliza")
			cmdInsert.Parameters.Add("@Costo", SqlDbType.Decimal, 9, "Costo")
			cmdInsert.Parameters.Add("@CantidadFactura", SqlDbType.Decimal, 9, "CantidadFactura")
			cmdInsert.Parameters.Add("@Cantidad", SqlDbType.Decimal, 9, "Cantidad")
			cmdInsert.Parameters.Add("@CantidadEnPreli", SqlDbType.Decimal, 9, "CantidadEnPreli")
			cmdInsert.Parameters.Add("@CantidadFalta", SqlDbType.Decimal, 9, "CantidadFalta")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.CommandText = "INSERT INTO SivEntradaPreliquidacion ( objEntradaBodegaID, objEntradaBodegaDetalleID, objEntradaBodegaDetPreliID, SiEntradaReal, NumeroEntradaReal, objRepuestoID, objProveedorID, NumeroFactura, FechaFactura, NumeroPoliza, Costo, CantidadFactura, Cantidad, CantidadEnPreli, CantidadFalta, FechaCreacion, UsuarioCreacion) VALUES ( @objEntradaBodegaID, @objEntradaBodegaDetalleID, @objEntradaBodegaDetPreliID, @SiEntradaReal, @NumeroEntradaReal, @objRepuestoID, @objProveedorID, @NumeroFactura, @FechaFactura, @NumeroPoliza, @Costo, @CantidadFactura, @Cantidad, @CantidadEnPreli, @CantidadFalta, @FechaCreacion, @UsuarioCreacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objEntradaBodegaID", SqlDbType.Int, 4, "objEntradaBodegaID")
			cmdUpdate.Parameters.Add("@objEntradaBodegaDetalleID", SqlDbType.Int, 4, "objEntradaBodegaDetalleID")
			cmdUpdate.Parameters.Add("@objEntradaBodegaDetPreliID", SqlDbType.Int, 4, "objEntradaBodegaDetPreliID")
			cmdUpdate.Parameters.Add("@SiEntradaReal", SqlDbType.Bit, 1, "SiEntradaReal")
			cmdUpdate.Parameters.Add("@NumeroEntradaReal", SqlDbType.Int, 4, "NumeroEntradaReal")
			cmdUpdate.Parameters.Add("@objRepuestoID", SqlDbType.VarChar, 50, "objRepuestoID")
			cmdUpdate.Parameters.Add("@objProveedorID", SqlDbType.Int, 4, "objProveedorID")
			cmdUpdate.Parameters.Add("@NumeroFactura", SqlDbType.VarChar, 40, "NumeroFactura")
			cmdUpdate.Parameters.Add("@FechaFactura", SqlDbType.DateTime, 8, "FechaFactura")
			cmdUpdate.Parameters.Add("@NumeroPoliza", SqlDbType.VarChar, 15, "NumeroPoliza")
			cmdUpdate.Parameters.Add("@Costo", SqlDbType.Decimal, 9, "Costo")
			cmdUpdate.Parameters.Add("@CantidadFactura", SqlDbType.Decimal, 9, "CantidadFactura")
			cmdUpdate.Parameters.Add("@Cantidad", SqlDbType.Decimal, 9, "Cantidad")
			cmdUpdate.Parameters.Add("@CantidadEnPreli", SqlDbType.Decimal, 9, "CantidadEnPreli")
			cmdUpdate.Parameters.Add("@CantidadFalta", SqlDbType.Decimal, 9, "CantidadFalta")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@wSivEntradaPreliquidacionID", SqlDbType.Int, 4, "SivEntradaPreliquidacionID")
			cmdUpdate.CommandText = "UPDATE SivEntradaPreliquidacion SET objEntradaBodegaID=@objEntradaBodegaID, objEntradaBodegaDetalleID=@objEntradaBodegaDetalleID, objEntradaBodegaDetPreliID=@objEntradaBodegaDetPreliID, SiEntradaReal=@SiEntradaReal, NumeroEntradaReal=@NumeroEntradaReal, objRepuestoID=@objRepuestoID, objProveedorID=@objProveedorID, NumeroFactura=@NumeroFactura, FechaFactura=@FechaFactura, NumeroPoliza=@NumeroPoliza, Costo=@Costo, CantidadFactura=@CantidadFactura, Cantidad=@Cantidad, CantidadEnPreli=@CantidadEnPreli, CantidadFalta=@CantidadFalta, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion WHERE SivEntradaPreliquidacionID= @wSivEntradaPreliquidacionID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SivEntradaPreliquidacion")
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
    ''' Devuelve de la base de datos un objeto SivEntradaPreliquidacion
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SivEntradaPreliquidacionID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivEntradaPreliquidacion where " & " SivEntradaPreliquidacionID = " & p_SivEntradaPreliquidacionID		
		Dim dr As SqlDataReader = Nothing	
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then		
				m_SivEntradaPreliquidacionID = dr("SivEntradaPreliquidacionID")
				m_objEntradaBodegaID = IIf(IsDBNull(dr("objEntradaBodegaID")), Nothing, dr("objEntradaBodegaID"))					
				m_objEntradaBodegaDetalleID = IIf(IsDBNull(dr("objEntradaBodegaDetalleID")), Nothing, dr("objEntradaBodegaDetalleID"))					
				m_objEntradaBodegaDetPreliID = IIf(IsDBNull(dr("objEntradaBodegaDetPreliID")), Nothing, dr("objEntradaBodegaDetPreliID"))					
				m_SiEntradaReal = IIf(IsDBNull(dr("SiEntradaReal")), Nothing, dr("SiEntradaReal"))					
				m_NumeroEntradaReal = IIf(IsDBNull(dr("NumeroEntradaReal")), Nothing, dr("NumeroEntradaReal"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_objProveedorID = IIf(IsDBNull(dr("objProveedorID")), Nothing, dr("objProveedorID"))					
				m_NumeroFactura = IIf(IsDBNull(dr("NumeroFactura")), Nothing, dr("NumeroFactura"))					
				m_FechaFactura = IIf(IsDBNull(dr("FechaFactura")), Nothing, dr("FechaFactura"))					
				m_NumeroPoliza = IIf(IsDBNull(dr("NumeroPoliza")), Nothing, dr("NumeroPoliza"))					
				m_Costo = IIf(IsDBNull(dr("Costo")), Nothing, dr("Costo"))					
				m_CantidadFactura = IIf(IsDBNull(dr("CantidadFactura")), Nothing, dr("CantidadFactura"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_CantidadEnPreli = IIf(IsDBNull(dr("CantidadEnPreli")), Nothing, dr("CantidadEnPreli"))					
				m_CantidadFalta = IIf(IsDBNull(dr("CantidadFalta")), Nothing, dr("CantidadFalta"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
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
    ''' Devuelve de la base de datos un objeto SivEntradaPreliquidacion usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivEntradaPreliquidacion where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then
				m_SivEntradaPreliquidacionID = dr("SivEntradaPreliquidacionID")
				m_objEntradaBodegaID = IIf(IsDBNull(dr("objEntradaBodegaID")), Nothing, dr("objEntradaBodegaID"))					
				m_objEntradaBodegaDetalleID = IIf(IsDBNull(dr("objEntradaBodegaDetalleID")), Nothing, dr("objEntradaBodegaDetalleID"))					
				m_objEntradaBodegaDetPreliID = IIf(IsDBNull(dr("objEntradaBodegaDetPreliID")), Nothing, dr("objEntradaBodegaDetPreliID"))					
				m_SiEntradaReal = IIf(IsDBNull(dr("SiEntradaReal")), Nothing, dr("SiEntradaReal"))					
				m_NumeroEntradaReal = IIf(IsDBNull(dr("NumeroEntradaReal")), Nothing, dr("NumeroEntradaReal"))					
				m_objRepuestoID = IIf(IsDBNull(dr("objRepuestoID")), Nothing, dr("objRepuestoID"))					
				m_objProveedorID = IIf(IsDBNull(dr("objProveedorID")), Nothing, dr("objProveedorID"))					
				m_NumeroFactura = IIf(IsDBNull(dr("NumeroFactura")), Nothing, dr("NumeroFactura"))					
				m_FechaFactura = IIf(IsDBNull(dr("FechaFactura")), Nothing, dr("FechaFactura"))					
				m_NumeroPoliza = IIf(IsDBNull(dr("NumeroPoliza")), Nothing, dr("NumeroPoliza"))					
				m_Costo = IIf(IsDBNull(dr("Costo")), Nothing, dr("Costo"))					
				m_CantidadFactura = IIf(IsDBNull(dr("CantidadFactura")), Nothing, dr("CantidadFactura"))					
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))					
				m_CantidadEnPreli = IIf(IsDBNull(dr("CantidadEnPreli")), Nothing, dr("CantidadEnPreli"))					
				m_CantidadFalta = IIf(IsDBNull(dr("CantidadFalta")), Nothing, dr("CantidadFalta"))					
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))					
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))					
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
    ''' Trae de la base de datos un conjunto de objetos SivEntradaPreliquidacion en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SivEntradaPreliquidacion"

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
			ds.Tables(0).TableName = "SivEntradaPreliquidacion"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEntradaPreliquidacion en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SivEntradaPreliquidacion"

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
			ds.Tables(0).TableName = "SivEntradaPreliquidacion"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEntradaPreliquidacion en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SivEntradaPreliquidacion"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivEntradaPreliquidacion.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SivEntradaPreliquidacion("
		sCommand &= "objEntradaBodegaID,"
		sCommand &= "objEntradaBodegaDetalleID,"
		sCommand &= "objEntradaBodegaDetPreliID,"
		sCommand &= "SiEntradaReal,"
		sCommand &= "NumeroEntradaReal,"
		sCommand &= "objRepuestoID,"
		sCommand &= "objProveedorID,"
		sCommand &= "NumeroFactura,"
		sCommand &= "FechaFactura,"
		sCommand &= "NumeroPoliza,"
		sCommand &= "Costo,"
		sCommand &= "CantidadFactura,"
		sCommand &= "Cantidad,"
		sCommand &= "CantidadEnPreli,"
		sCommand &= "CantidadFalta,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion) values ("		
		sCommand &= "@objEntradaBodegaID,"
		sCommand &= "@objEntradaBodegaDetalleID,"
		sCommand &= "@objEntradaBodegaDetPreliID,"
		sCommand &= "@SiEntradaReal,"
		sCommand &= "@NumeroEntradaReal,"
		sCommand &= "@objRepuestoID,"
		sCommand &= "@objProveedorID,"
		sCommand &= "@NumeroFactura,"
		sCommand &= "@FechaFactura,"
		sCommand &= "@NumeroPoliza,"
		sCommand &= "@Costo,"
		sCommand &= "@CantidadFactura,"
		sCommand &= "@Cantidad,"
		sCommand &= "@CantidadEnPreli,"
		sCommand &= "@CantidadFalta,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion)"		
	
		sCommand &= " select "
		sCommand &= "@SivEntradaPreliquidacionID = SivEntradaPreliquidacionID from SivEntradaPreliquidacion where "		
		sCommand &= "SivEntradaPreliquidacionID = SCOPE_IDENTITY()"
		
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SivEntradaPreliquidacionID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objEntradaBodegaID", SqlDbType.Int)		
		If IsDBNull(m_objEntradaBodegaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objEntradaBodegaID
        End If
		arParams(2) = New SqlParameter("@objEntradaBodegaDetalleID", SqlDbType.Int)		
		If IsDBNull(m_objEntradaBodegaDetalleID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEntradaBodegaDetalleID
        End If
		arParams(3) = New SqlParameter("@objEntradaBodegaDetPreliID", SqlDbType.Int)		
		If IsDBNull(m_objEntradaBodegaDetPreliID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objEntradaBodegaDetPreliID
        End If
		arParams(4) = New SqlParameter("@SiEntradaReal", SqlDbType.Bit)		
		If IsDBNull(m_SiEntradaReal) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_SiEntradaReal
        End If
		arParams(5) = New SqlParameter("@NumeroEntradaReal", SqlDbType.Int)		
		If IsDBNull(m_NumeroEntradaReal) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_NumeroEntradaReal
        End If
		arParams(6) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objRepuestoID
        End If
		arParams(7) = New SqlParameter("@objProveedorID", SqlDbType.Int)		
		If IsDBNull(m_objProveedorID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objProveedorID
        End If
		arParams(8) = New SqlParameter("@NumeroFactura", SqlDbType.VarChar)		
		If IsDBNull(m_NumeroFactura) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_NumeroFactura
        End If
		arParams(9) = New SqlParameter("@FechaFactura", SqlDbType.DateTime)		
		If IsDBNull(m_FechaFactura) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaFactura
        End If
		arParams(10) = New SqlParameter("@NumeroPoliza", SqlDbType.VarChar)		
		If IsDBNull(m_NumeroPoliza) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_NumeroPoliza
        End If
		arParams(11) = New SqlParameter("@Costo", SqlDbType.Decimal)		
		If IsDBNull(m_Costo) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Costo
        End If
		arParams(12) = New SqlParameter("@CantidadFactura", SqlDbType.Decimal)		
		If IsDBNull(m_CantidadFactura) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_CantidadFactura
        End If
		arParams(13) = New SqlParameter("@Cantidad", SqlDbType.Decimal)		
		If IsDBNull(m_Cantidad) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Cantidad
        End If
		arParams(14) = New SqlParameter("@CantidadEnPreli", SqlDbType.Decimal)		
		If IsDBNull(m_CantidadEnPreli) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_CantidadEnPreli
        End If
		arParams(15) = New SqlParameter("@CantidadFalta", SqlDbType.Decimal)		
		If IsDBNull(m_CantidadFalta) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_CantidadFalta
        End If
		arParams(16) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaCreacion
        End If
		arParams(17) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioCreacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SivEntradaPreliquidacionID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SivEntradaPreliquidacion en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SivEntradaPreliquidacion set "		
		sCommand &= "objEntradaBodegaID = @objEntradaBodegaID,"
		sCommand &= "objEntradaBodegaDetalleID = @objEntradaBodegaDetalleID,"
		sCommand &= "objEntradaBodegaDetPreliID = @objEntradaBodegaDetPreliID,"
		sCommand &= "SiEntradaReal = @SiEntradaReal,"
		sCommand &= "NumeroEntradaReal = @NumeroEntradaReal,"
		sCommand &= "objRepuestoID = @objRepuestoID,"
		sCommand &= "objProveedorID = @objProveedorID,"
		sCommand &= "NumeroFactura = @NumeroFactura,"
		sCommand &= "FechaFactura = @FechaFactura,"
		sCommand &= "NumeroPoliza = @NumeroPoliza,"
		sCommand &= "Costo = @Costo,"
		sCommand &= "CantidadFactura = @CantidadFactura,"
		sCommand &= "Cantidad = @Cantidad,"
		sCommand &= "CantidadEnPreli = @CantidadEnPreli,"
		sCommand &= "CantidadFalta = @CantidadFalta,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion"		
		sCommand &= " where "	
		sCommand &= "SivEntradaPreliquidacionID = @SivEntradaPreliquidacionID"					
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SivEntradaPreliquidacionID", SqlDbType.Int)		
		If IsDBNull(m_SivEntradaPreliquidacionID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivEntradaPreliquidacionID
        End If
		arParams(1) = New SqlParameter("@objEntradaBodegaID", SqlDbType.Int)		
		If IsDBNull(m_objEntradaBodegaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objEntradaBodegaID
        End If
		arParams(2) = New SqlParameter("@objEntradaBodegaDetalleID", SqlDbType.Int)		
		If IsDBNull(m_objEntradaBodegaDetalleID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEntradaBodegaDetalleID
        End If
		arParams(3) = New SqlParameter("@objEntradaBodegaDetPreliID", SqlDbType.Int)		
		If IsDBNull(m_objEntradaBodegaDetPreliID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objEntradaBodegaDetPreliID
        End If
		arParams(4) = New SqlParameter("@SiEntradaReal", SqlDbType.Bit)		
		If IsDBNull(m_SiEntradaReal) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_SiEntradaReal
        End If
		arParams(5) = New SqlParameter("@NumeroEntradaReal", SqlDbType.Int)		
		If IsDBNull(m_NumeroEntradaReal) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_NumeroEntradaReal
        End If
		arParams(6) = New SqlParameter("@objRepuestoID", SqlDbType.VarChar)		
		If IsDBNull(m_objRepuestoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objRepuestoID
        End If
		arParams(7) = New SqlParameter("@objProveedorID", SqlDbType.Int)		
		If IsDBNull(m_objProveedorID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objProveedorID
        End If
		arParams(8) = New SqlParameter("@NumeroFactura", SqlDbType.VarChar)		
		If IsDBNull(m_NumeroFactura) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_NumeroFactura
        End If
		arParams(9) = New SqlParameter("@FechaFactura", SqlDbType.DateTime)		
		If IsDBNull(m_FechaFactura) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaFactura
        End If
		arParams(10) = New SqlParameter("@NumeroPoliza", SqlDbType.VarChar)		
		If IsDBNull(m_NumeroPoliza) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_NumeroPoliza
        End If
		arParams(11) = New SqlParameter("@Costo", SqlDbType.Decimal)		
		If IsDBNull(m_Costo) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Costo
        End If
		arParams(12) = New SqlParameter("@CantidadFactura", SqlDbType.Decimal)		
		If IsDBNull(m_CantidadFactura) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_CantidadFactura
        End If
		arParams(13) = New SqlParameter("@Cantidad", SqlDbType.Decimal)		
		If IsDBNull(m_Cantidad) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Cantidad
        End If
		arParams(14) = New SqlParameter("@CantidadEnPreli", SqlDbType.Decimal)		
		If IsDBNull(m_CantidadEnPreli) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_CantidadEnPreli
        End If
		arParams(15) = New SqlParameter("@CantidadFalta", SqlDbType.Decimal)		
		If IsDBNull(m_CantidadFalta) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_CantidadFalta
        End If
		arParams(16) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaCreacion
        End If
		arParams(17) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioCreacion
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
    ''' Borra un objeto SivEntradaPreliquidacion de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaPreliquidacion where " & " SivEntradaPreliquidacionID = " & m_SivEntradaPreliquidacionID
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
    ''' Borra un objeto SivEntradaPreliquidacion de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivEntradaPreliquidacionID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaPreliquidacion where " & " SivEntradaPreliquidacionID = " & p_SivEntradaPreliquidacionID
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
    ''' Borra objetos SivEntradaPreliquidacion de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaPreliquidacion where " & pWhere
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
