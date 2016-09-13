Imports DAL
Imports System.Xml  
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Public Class SivEntradaBodega		

#Region " Variables Miembro " 
	Protected m_SivEntradaBodegaID As Integer 
	Protected m_objTipoEntradaID As Integer 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_objStbBodegaID As Nullable(Of Integer) 
    Protected m_objProvededorID As Nullable(Of Integer)
    Protected m_FechaEntrada As Date
    Protected m_CostoTotal As Decimal
    Protected m_NumeroFactura As String = Nothing
    Protected m_FechaFactura As Nullable(Of Date)
    Protected m_Comentarios As String = Nothing
    Protected m_Anulada As Boolean
    Protected m_ComentarioAnular As String = Nothing
    Protected m_FechaCreacion As Date
    Protected m_UsuarioCreacion As String = Nothing
    Protected m_FechaModificacion As Nullable(Of Date)
    Protected m_UsuarioModificacion As String = Nothing
#End Region

#Region " Propiedades "
    Public Property SivEntradaBodegaID() As Integer
        Get
            Return (m_SivEntradaBodegaID)
        End Get
        Set(ByVal Value As Integer)
            m_SivEntradaBodegaID = Value
        End Set
    End Property

    Public Property objTipoEntradaID() As Integer
        Get
            Return (m_objTipoEntradaID)
        End Get
        Set(ByVal Value As Integer)
            m_objTipoEntradaID = Value
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

    Public Property objStbBodegaID() As Nullable(Of Integer)
        Get
            Return (m_objStbBodegaID)
        End Get
        Set(ByVal Value As Nullable(Of Integer))
            m_objStbBodegaID = Value
        End Set
    End Property

    Public Property objProvededorID() As Nullable(Of Integer)
        Get
            Return (m_objProvededorID)
        End Get
        Set(ByVal Value As Nullable(Of Integer))
            m_objProvededorID = Value
        End Set
    End Property

    Public Property FechaEntrada() As Date
        Get
            Return (m_FechaEntrada)
        End Get
        Set(ByVal Value As Date)
            m_FechaEntrada = Value
        End Set
    End Property

    Public Property CostoTotal() As Decimal
        Get
            Return (m_CostoTotal)
        End Get
        Set(ByVal Value As Decimal)
            m_CostoTotal = Value
        End Set
    End Property

    Public Property NumeroFactura() As String
        Get
            Return (m_NumeroFactura)
        End Get
        Set(ByVal Value As String)
            If Not Value Is Nothing Then
                If Value.Length > 40 Then
                    Throw New ArgumentOutOfRangeException("NumeroFactura", Value.ToString(), "Valor inv?lido para SivEntradaBodega.NumeroFactura. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (40).")
                End If
            End If
            m_NumeroFactura = Value
        End Set
    End Property

    Public Property FechaFactura() As Nullable(Of Date)
        Get
            Return (m_FechaFactura)
        End Get
        Set(ByVal Value As Nullable(Of Date))
            m_FechaFactura = Value
        End Set
    End Property

    Public Property Comentarios() As String
        Get
            Return (m_Comentarios)
        End Get
        Set(ByVal Value As String)
            If Not Value Is Nothing Then
                If Value.Length > 1000 Then
                    Throw New ArgumentOutOfRangeException("Comentarios", Value.ToString(), "Valor inv?lido para SivEntradaBodega.Comentarios. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (1000).")
                End If
            End If
            m_Comentarios = Value
        End Set
    End Property

    Public Property Anulada() As Boolean
        Get
            Return (m_Anulada)
        End Get
        Set(ByVal Value As Boolean)
            m_Anulada = Value
        End Set
    End Property

    Public Property ComentarioAnular() As String
        Get
            Return (m_ComentarioAnular)
        End Get
        Set(ByVal Value As String)
            If Not Value Is Nothing Then
                If Value.Length > 1000 Then
                    Throw New ArgumentOutOfRangeException("ComentarioAnular", Value.ToString(), "Valor inv?lido para SivEntradaBodega.ComentarioAnular. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (1000).")
                End If
            End If
            m_ComentarioAnular = Value
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
                    Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SivEntradaBodega.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
                    Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SivEntradaBodega.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
                End If
            End If
            m_UsuarioModificacion = Value
        End Set
    End Property


    Public Shared Function GetMaxLength(ProperyName As String) As Integer
        Select Case ProperyName
            Case "CostoTotal"
                Return 11
            Case "NumeroFactura"
                Return 40
            Case "Comentarios"
                Return 1000
            Case "ComentarioAnular"
                Return 1000
            Case "UsuarioCreacion"
                Return 30
            Case "UsuarioModificacion"
                Return 30
            Case Else
                Throw New Exception("Nombre de propiedad desconocida.")
        End Select
    End Function

    Public Shared Function GetScale(ProperyName As String) As Integer
        Select Case ProperyName
            Case "CostoTotal"
                Return 2
            Case Else
                Throw New Exception("Nombre de propiedad desconocida.")
        End Select
    End Function
#End Region

#Region " Batch Update "
    ''' <summary>
    ''' Salva un DataSet del tipo de la tabla SivEntradaBodega en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SivEntradaBodega </param>    
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo BatchUpdate.</param>
    ''' <remarks>Usado para realizar actualizaciones en Batch.</remarks>
    Public Shared Sub BatchUpdate(DS As DataSet, Optional ByVal pTransac As TransactionManager = Nothing)
        Dim cmdInsert As SqlCommand = Nothing
        Dim cmdUpdate As SqlCommand = Nothing
        Dim cmdDelete As SqlCommand = Nothing

        Try
            cmdInsert = New SqlCommand
            cmdUpdate = New SqlCommand
            cmdDelete = New SqlCommand
            'CREACION DEL COMANDO DELETE
            cmdDelete.Parameters.Add("@SivEntradaBodegaID", SqlDbType.Int, 4, "SivEntradaBodegaID")
            cmdDelete.CommandText = "DELETE FROM  SivEntradaBodega WHERE SivEntradaBodegaID= @SivEntradaBodegaID"

            'CREACION DEL COMANDO INSERT
            cmdInsert.Parameters.Add("@objTipoEntradaID", SqlDbType.Int, 4, "objTipoEntradaID")
            cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
            cmdInsert.Parameters.Add("@objStbBodegaID", SqlDbType.Int, 4, "objStbBodegaID")
            cmdInsert.Parameters.Add("@objProvededorID", SqlDbType.Int, 4, "objProvededorID")
            cmdInsert.Parameters.Add("@FechaEntrada", SqlDbType.DateTime, 8, "FechaEntrada")
            cmdInsert.Parameters.Add("@CostoTotal", SqlDbType.Decimal, 9, "CostoTotal")
            cmdInsert.Parameters.Add("@NumeroFactura", SqlDbType.VarChar, 40, "NumeroFactura")
            cmdInsert.Parameters.Add("@FechaFactura", SqlDbType.DateTime, 8, "FechaFactura")
            cmdInsert.Parameters.Add("@Comentarios", SqlDbType.VarChar, 1000, "Comentarios")
            cmdInsert.Parameters.Add("@Anulada", SqlDbType.Bit, 1, "Anulada")
            cmdInsert.Parameters.Add("@ComentarioAnular", SqlDbType.VarChar, 1000, "ComentarioAnular")
            cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
            cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
            cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
            cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
            cmdInsert.CommandText = "INSERT INTO SivEntradaBodega ( objTipoEntradaID, objEstadoID, objStbBodegaID, objProvededorID, FechaEntrada, CostoTotal, NumeroFactura, FechaFactura, Comentarios, Anulada, ComentarioAnular, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objTipoEntradaID, @objEstadoID, @objStbBodegaID, @objProvededorID, @FechaEntrada, @CostoTotal, @NumeroFactura, @FechaFactura, @Comentarios, @Anulada, @ComentarioAnular, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

            'CREACION DEL COMANDO UPDATE
            cmdUpdate.Parameters.Add("@objTipoEntradaID", SqlDbType.Int, 4, "objTipoEntradaID")
            cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
            cmdUpdate.Parameters.Add("@objStbBodegaID", SqlDbType.Int, 4, "objStbBodegaID")
            cmdUpdate.Parameters.Add("@objProvededorID", SqlDbType.Int, 4, "objProvededorID")
            cmdUpdate.Parameters.Add("@FechaEntrada", SqlDbType.DateTime, 8, "FechaEntrada")
            cmdUpdate.Parameters.Add("@CostoTotal", SqlDbType.Decimal, 9, "CostoTotal")
            cmdUpdate.Parameters.Add("@NumeroFactura", SqlDbType.VarChar, 40, "NumeroFactura")
            cmdUpdate.Parameters.Add("@FechaFactura", SqlDbType.DateTime, 8, "FechaFactura")
            cmdUpdate.Parameters.Add("@Comentarios", SqlDbType.VarChar, 1000, "Comentarios")
            cmdUpdate.Parameters.Add("@Anulada", SqlDbType.Bit, 1, "Anulada")
            cmdUpdate.Parameters.Add("@ComentarioAnular", SqlDbType.VarChar, 1000, "ComentarioAnular")
            cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
            cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
            cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
            cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
            cmdUpdate.Parameters.Add("@wSivEntradaBodegaID", SqlDbType.Int, 4, "SivEntradaBodegaID")
            cmdUpdate.CommandText = "UPDATE SivEntradaBodega SET objTipoEntradaID=@objTipoEntradaID, objEstadoID=@objEstadoID, objStbBodegaID=@objStbBodegaID, objProvededorID=@objProvededorID, FechaEntrada=@FechaEntrada, CostoTotal=@CostoTotal, NumeroFactura=@NumeroFactura, FechaFactura=@FechaFactura, Comentarios=@Comentarios, Anulada=@Anulada, ComentarioAnular=@ComentarioAnular, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SivEntradaBodegaID= @wSivEntradaBodegaID"
            If Not pTransac Is Nothing Then
                cmdDelete.Connection = pTransac.Transaction.Connection
                cmdDelete.Transaction = pTransac.Transaction

                cmdInsert.Connection = pTransac.Transaction.Connection
                cmdInsert.Transaction = pTransac.Transaction

                cmdUpdate.Connection = pTransac.Transaction.Connection
                cmdUpdate.Transaction = pTransac.Transaction
            End If

            sqlHelper.UpdateDataset(cmdInsert, cmdDelete, cmdUpdate, DS, "SivEntradaBodega")
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
    ''' Devuelve de la base de datos un objeto SivEntradaBodega
    ''' </summary>    
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(ByVal p_SivEntradaBodegaID As Integer, Optional ByVal pTransac As TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivEntradaBodega where " & " SivEntradaBodegaID = " & p_SivEntradaBodegaID
        Dim dr As SqlDataReader = Nothing

        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If

            If dr.Read() Then
                m_SivEntradaBodegaID = dr("SivEntradaBodegaID")
                m_objTipoEntradaID = IIf(IsDBNull(dr("objTipoEntradaID")), Nothing, dr("objTipoEntradaID"))
                m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
                m_objStbBodegaID = IIf(IsDBNull(dr("objStbBodegaID")), Nothing, dr("objStbBodegaID"))
                m_objProvededorID = IIf(IsDBNull(dr("objProvededorID")), Nothing, dr("objProvededorID"))
                m_FechaEntrada = IIf(IsDBNull(dr("FechaEntrada")), Nothing, dr("FechaEntrada"))
                m_CostoTotal = IIf(IsDBNull(dr("CostoTotal")), Nothing, dr("CostoTotal"))
                m_NumeroFactura = IIf(IsDBNull(dr("NumeroFactura")), Nothing, dr("NumeroFactura"))
                m_FechaFactura = IIf(IsDBNull(dr("FechaFactura")), Nothing, dr("FechaFactura"))
                m_Comentarios = IIf(IsDBNull(dr("Comentarios")), Nothing, dr("Comentarios"))
                m_Anulada = IIf(IsDBNull(dr("Anulada")), Nothing, dr("Anulada"))
                m_ComentarioAnular = IIf(IsDBNull(dr("ComentarioAnular")), Nothing, dr("ComentarioAnular"))
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
    ''' Devuelve de la base de datos un objeto SivEntradaBodega usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter As String, Optional ByVal pTransac As TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SivEntradaBodega where " & pFilter
        Dim dr As SqlDataReader = Nothing

        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If

            If dr.Read() Then
                m_SivEntradaBodegaID = dr("SivEntradaBodegaID")
                m_objTipoEntradaID = IIf(IsDBNull(dr("objTipoEntradaID")), Nothing, dr("objTipoEntradaID"))
                m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
                m_objStbBodegaID = IIf(IsDBNull(dr("objStbBodegaID")), Nothing, dr("objStbBodegaID"))
                m_objProvededorID = IIf(IsDBNull(dr("objProvededorID")), Nothing, dr("objProvededorID"))
                m_FechaEntrada = IIf(IsDBNull(dr("FechaEntrada")), Nothing, dr("FechaEntrada"))
                m_CostoTotal = IIf(IsDBNull(dr("CostoTotal")), Nothing, dr("CostoTotal"))
                m_NumeroFactura = IIf(IsDBNull(dr("NumeroFactura")), Nothing, dr("NumeroFactura"))
                m_FechaFactura = IIf(IsDBNull(dr("FechaFactura")), Nothing, dr("FechaFactura"))
                m_Comentarios = IIf(IsDBNull(dr("Comentarios")), Nothing, dr("Comentarios"))
                m_Anulada = IIf(IsDBNull(dr("Anulada")), Nothing, dr("Anulada"))
                m_ComentarioAnular = IIf(IsDBNull(dr("ComentarioAnular")), Nothing, dr("ComentarioAnular"))
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
    ''' Trae de la base de datos un conjunto de objetos SivEntradaBodega en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional ByVal pFields As String = "*", Optional ByVal pTransac As TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields & " from SivEntradaBodega"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim ds As DataSet
        Try
            If pTransac Is Nothing Then
                ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
            Else
                ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
            End If
            ds.Tables(0).TableName = "SivEntradaBodega"
            Return (ds.Tables(0))
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEntradaBodega en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional ByVal pFields As String = "*", Optional ByVal pTransac As TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields & " from SivEntradaBodega"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim ds As DataSet
        Try
            If pTransac Is Nothing Then
                ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
            Else
                ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
            End If
            ds.Tables(0).TableName = "SivEntradaBodega"
            Return (ds)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SivEntradaBodega en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional ByVal pFields As String = "*", Optional ByVal pTransac As TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields & " from SivEntradaBodega"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim dr As SqlDataReader = Nothing
        Try
            If pTransac Is Nothing Then
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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SivEntradaBodega.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
    Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
        Dim sCommand As String = "insert into SivEntradaBodega("
        sCommand &= "objTipoEntradaID,"
        sCommand &= "objEstadoID,"
        sCommand &= "objStbBodegaID,"
        sCommand &= "objProvededorID,"
        sCommand &= "FechaEntrada,"
        sCommand &= "CostoTotal,"
        sCommand &= "NumeroFactura,"
        sCommand &= "FechaFactura,"
        sCommand &= "Comentarios,"
        sCommand &= "Anulada,"
        sCommand &= "ComentarioAnular,"
        sCommand &= "FechaCreacion,"
        sCommand &= "UsuarioCreacion,"
        sCommand &= "FechaModificacion,"
        sCommand &= "UsuarioModificacion) values ("
        sCommand &= "@objTipoEntradaID,"
        sCommand &= "@objEstadoID,"
        sCommand &= "@objStbBodegaID,"
        sCommand &= "@objProvededorID,"
        sCommand &= "@FechaEntrada,"
        sCommand &= "@CostoTotal,"
        sCommand &= "@NumeroFactura,"
        sCommand &= "@FechaFactura,"
        sCommand &= "@Comentarios,"
        sCommand &= "@Anulada,"
        sCommand &= "@ComentarioAnular,"
        sCommand &= "@FechaCreacion,"
        sCommand &= "@UsuarioCreacion,"
        sCommand &= "@FechaModificacion,"
        sCommand &= "@UsuarioModificacion)"

        sCommand &= " select "
        sCommand &= "@SivEntradaBodegaID = SivEntradaBodegaID from SivEntradaBodega where "
        sCommand &= "SivEntradaBodegaID = SCOPE_IDENTITY()"


        Dim arParams(15) As SqlParameter
        arParams(0) = New SqlParameter("@SivEntradaBodegaID", SqlDbType.Int)
        arParams(0).Direction = ParameterDirection.Output
        arParams(1) = New SqlParameter("@objTipoEntradaID", SqlDbType.Int)
        If IsDBNull(m_objTipoEntradaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTipoEntradaID
        End If
        arParams(2) = New SqlParameter("@objEstadoID", SqlDbType.Int)
        If IsDBNull(m_objEstadoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEstadoID
        End If
        arParams(3) = New SqlParameter("@objStbBodegaID", SqlDbType.Int)
        If IsDBNull(m_objStbBodegaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objStbBodegaID
        End If
        arParams(4) = New SqlParameter("@objProvededorID", SqlDbType.Int)
        If IsDBNull(m_objProvededorID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objProvededorID
        End If
        arParams(5) = New SqlParameter("@FechaEntrada", SqlDbType.DateTime)
        If IsDBNull(m_FechaEntrada) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaEntrada
        End If
        arParams(6) = New SqlParameter("@CostoTotal", SqlDbType.Decimal)
        If IsDBNull(m_CostoTotal) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_CostoTotal
        End If
        arParams(7) = New SqlParameter("@NumeroFactura", SqlDbType.VarChar)
        If IsDBNull(m_NumeroFactura) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_NumeroFactura
        End If
        arParams(8) = New SqlParameter("@FechaFactura", SqlDbType.DateTime)
        If IsDBNull(m_FechaFactura) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaFactura
        End If
        arParams(9) = New SqlParameter("@Comentarios", SqlDbType.VarChar)
        If IsDBNull(m_Comentarios) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Comentarios
        End If
        arParams(10) = New SqlParameter("@Anulada", SqlDbType.Bit)
        If IsDBNull(m_Anulada) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Anulada
        End If
        arParams(11) = New SqlParameter("@ComentarioAnular", SqlDbType.VarChar)
        If IsDBNull(m_ComentarioAnular) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_ComentarioAnular
        End If
        arParams(12) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)
        If IsDBNull(m_FechaCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaCreacion
        End If
        arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)
        If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
        arParams(14) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)
        If IsDBNull(m_FechaModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaModificacion
        End If
        arParams(15) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)
        If IsDBNull(m_UsuarioModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioModificacion
        End If

        Try
            If pTransac Is Nothing Then
                SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)
            Else
                SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)
            End If

            m_SivEntradaBodegaID = arParams(0).Value
        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

#Region " Update "

    ''' <summary>
    ''' 	Actualiza el objeto SivEntradaBodega en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
    Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)
        Dim sCommand As String = "update SivEntradaBodega set "
        sCommand &= "objTipoEntradaID = @objTipoEntradaID,"
        sCommand &= "objEstadoID = @objEstadoID,"
        sCommand &= "objStbBodegaID = @objStbBodegaID,"
        sCommand &= "objProvededorID = @objProvededorID,"
        sCommand &= "FechaEntrada = @FechaEntrada,"
        sCommand &= "CostoTotal = @CostoTotal,"
        sCommand &= "NumeroFactura = @NumeroFactura,"
        sCommand &= "FechaFactura = @FechaFactura,"
        sCommand &= "Comentarios = @Comentarios,"
        sCommand &= "Anulada = @Anulada,"
        sCommand &= "ComentarioAnular = @ComentarioAnular,"
        sCommand &= "FechaCreacion = @FechaCreacion,"
        sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
        sCommand &= "FechaModificacion = @FechaModificacion,"
        sCommand &= "UsuarioModificacion = @UsuarioModificacion"
        sCommand &= " where "
        sCommand &= "SivEntradaBodegaID = @SivEntradaBodegaID"

        Dim arParams(15) As SqlParameter
        arParams(0) = New SqlParameter("@SivEntradaBodegaID", SqlDbType.Int)
        If IsDBNull(m_SivEntradaBodegaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SivEntradaBodegaID
        End If
        arParams(1) = New SqlParameter("@objTipoEntradaID", SqlDbType.Int)
        If IsDBNull(m_objTipoEntradaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objTipoEntradaID
        End If
        arParams(2) = New SqlParameter("@objEstadoID", SqlDbType.Int)
        If IsDBNull(m_objEstadoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEstadoID
        End If
        arParams(3) = New SqlParameter("@objStbBodegaID", SqlDbType.Int)
        If IsDBNull(m_objStbBodegaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objStbBodegaID
        End If
        arParams(4) = New SqlParameter("@objProvededorID", SqlDbType.Int)
        If IsDBNull(m_objProvededorID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objProvededorID
        End If
        arParams(5) = New SqlParameter("@FechaEntrada", SqlDbType.DateTime)
        If IsDBNull(m_FechaEntrada) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaEntrada
        End If
        arParams(6) = New SqlParameter("@CostoTotal", SqlDbType.Decimal)
        If IsDBNull(m_CostoTotal) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_CostoTotal
        End If
        arParams(7) = New SqlParameter("@NumeroFactura", SqlDbType.VarChar)
        If IsDBNull(m_NumeroFactura) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_NumeroFactura
        End If
        arParams(8) = New SqlParameter("@FechaFactura", SqlDbType.DateTime)
        If IsDBNull(m_FechaFactura) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaFactura
        End If
        arParams(9) = New SqlParameter("@Comentarios", SqlDbType.VarChar)
        If IsDBNull(m_Comentarios) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Comentarios
        End If
        arParams(10) = New SqlParameter("@Anulada", SqlDbType.Bit)
        If IsDBNull(m_Anulada) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Anulada
        End If
        arParams(11) = New SqlParameter("@ComentarioAnular", SqlDbType.VarChar)
        If IsDBNull(m_ComentarioAnular) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_ComentarioAnular
        End If
        arParams(12) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)
        If IsDBNull(m_FechaCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaCreacion
        End If
        arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)
        If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
        arParams(14) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)
        If IsDBNull(m_FechaModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaModificacion
        End If
        arParams(15) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)
        If IsDBNull(m_UsuarioModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SivEntradaBodega de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaBodega where " & " SivEntradaBodegaID = " & m_SivEntradaBodegaID
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
    ''' Borra un objeto SivEntradaBodega de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SivEntradaBodegaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaBodega where " & " SivEntradaBodegaID = " & p_SivEntradaBodegaID
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
    ''' Borra objetos SivEntradaBodega de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SivEntradaBodega where " & pWhere
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
