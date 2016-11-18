'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Enrique Escobar Maradiaga.
''-- Fecha de Elaboración    : 02 Junio 2010.
''-- Formulario de Agregación de Entrada Bodega
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SIFAC.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmSivEntradaBodegaEditar

#Region "Variables del formulario"
    Dim intTipoAjusteSuma, intTipoAjusteResta, intTipoEntradaCompraLocal, intTipoAjuste, intTipoEntradaDevolucion, intTipoEntradaImportacion As Integer
    Dim dtDescripcionEntrada, dtDetalleEntradaBodega, dtDetEntBodegaDet, dtCantidadPreliquidada, dtDetalleEntradaBodegaDE, dtDetEntBodegaDetDE As DataTable
    Dim dsDetalleEntradaBodega, dsDetEntBodegaDet, dsDetalleEntradaBodegaDE, dsDetEntBodegaDetDE As DataSet
    Dim boolModificado As Boolean
    Dim dtEntradaPreliquidacion As DataTable
    Dim PromedioDolares As Double
    Dim boolExisteErroresGrid As Boolean

    Private m_TypeGui As Integer
    Private m_SivEntradaBodegaID As String
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            TypeGui = Me.m_TypeGui
        End Get
        Set(ByVal value As Integer)
            Me.m_TypeGui = value
        End Set
    End Property

    Property SivEntradaBodegaID() As String
        Get
            SivEntradaBodegaID = Me.m_SivEntradaBodegaID
        End Get
        Set(ByVal value As String)
            Me.m_SivEntradaBodegaID = value
        End Set
    End Property

#End Region

#Region "Inicializar Pantalla"

#Region "Inicializar GUI"
    Private Sub InicializarGui()
        Me.intTipoAjusteSuma = ClsCatalogos.GetValorCatalogoID("TIPOAJUSTE", "01")
        Me.intTipoAjusteResta = ClsCatalogos.GetValorCatalogoID("TIPOAJUSTE", "02")
        Me.intTipoEntradaImportacion = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "01")
        Me.intTipoEntradaCompraLocal = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "02")
        Me.intTipoAjuste = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "03")
        Me.intTipoEntradaDevolucion = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "04")

        Me.dtpFechaEntrada.Value = clsProyecto.Conexion.FechaServidor
        Me.dtpFechaEntrada.Focus()

        Me.txtNumeroEntrada.Text = Me.NuevoID
        LongitudesMaximas()
        CargarBodegas()
        CargarTipoEntrada()
        CargarProveedor()
        CargarDescripcionDE("1=1")
        Me.lblUsuario.Text = clsProyecto.Conexion.Usuario

        boolModificado = False
    End Sub
#End Region

#Region "Longitudes Maximas"

    Private Sub LongitudesMaximas()
        Me.txtNumeroFactura.MaxLength = BO.SivEntradaBodega.GetMaxLength("NumeroFactura")
        Me.txtComentarios.MaxLength = BO.SivEntradaBodega.GetMaxLength("Comentarios")
    End Sub

#End Region

#Region "Cargar Combos"

#Region "Bodega"
    Private Sub CargarBodegas()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbBodegas.RetrieveDT("Codigo='C'", "Codigo", "StbBodegaID, Nombre")
            With Me.cmbBodega
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbBodegaID"
                .Splits(0).DisplayColumns("StbBodegaID").Visible = False
                .ExtendRightColumn = True
                .SelectedIndex = 0
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Tipo de Entrada"
    Private Sub CargarTipoEntrada()
        Dim objStbValorCatalogo As StbValorCatalogo
        Dim dtDatos As New DataTable
        Dim dtDatosFormateados As DataTable
        Dim filas As DataRow
        Try
            objStbValorCatalogo = New StbValorCatalogo
            dtDatos = ClsCatalogos.GetValoresCatalogo("TIPOENTRADA", "StbValorCatalogoID,Codigo,Descripcion")
            dtDatosFormateados = StbValorCatalogo.RetrieveDT("1=0", , "StbValorCatalogoID,Descripcion")

            For Each row As DataRow In dtDatos.Rows
                If row("Codigo") <> "06" Then
                    filas = dtDatosFormateados.NewRow
                    filas("StbValorCatalogoID") = row("StbValorCatalogoID")
                    filas("Descripcion") = row("Descripcion")
                    dtDatosFormateados.Rows.Add(filas)
                End If
            Next

            'dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "(objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOENTRADA')) AND (Codigo IN (01,02,03,04,05))"))
            With cmbTipoEntrada
                .DataSource = dtDatosFormateados
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Proveedor"
    Private Sub CargarProveedor()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID,RazonSocial", "vwTipoProveedor", "1=1 ORDER BY RazonSocial"))
            With Me.cmbProveedor
                .DataSource = dtDatos
                .DisplayMember = "RazonSocial"
                .ValueMember = "SivProveedorID"
                .Splits(0).DisplayColumns("SivProveedorID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar Descripción grid DE"

    Private Sub CargarDescripcionDE(ByVal strFiltro As String)
        Dim riLookComboDescripcion As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Try
            dtDescripcionEntrada = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProductoID,Nombre", "SivProductos", strFiltro & " ORDER BY Nombre"))
            riLookComboDescripcion = Me.grdDetalleEntradasBodegasDE.RepositoryItems(0)
            riLookComboDescripcion.DataSource = dtDescripcionEntrada
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDescripcionEntrada = Nothing
        End Try
    End Sub

#End Region

#End Region

#End Region

#Region "Procedimientos"

#Region "Cargar Estructura del Grid DE"

    Private Sub CargarDetalleEntradaBodegaDE()
        Try

            dtDetalleEntradaBodegaDE = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProductoID,Producto,CantidaEntrada,Costo,Total,objEntradaBodegaID,Cantidad,objTipoEntradaID,SivEntradaBodegaID,SivEntradaBodegaDetID", "vwSivEntradaBodegaDetalle", "1=0 ORDER BY SivProductoID,SivEntradaBodegaDetID"))
            dsDetalleEntradaBodegaDE = New DataSet
            dsDetalleEntradaBodegaDE.Merge(dtDetalleEntradaBodegaDE)
            dsDetalleEntradaBodegaDE.Tables(0).TableName = "vwSivEntradaBodegaDetalle"
            Me.grdDetalleEntradasBodegasDE.DataSource = dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle")

            grdDetalleEntradasBodegasDE.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            'dtDetalleEntradaBodegaDE = Nothing
        End Try

    End Sub

#End Region

#Region "Procedimientos para el Grid"

#Region "Insertar una nueva fila en el grid"
    Private Sub InsertarNuevaFilaGrid()
        Try
            dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows.Add()
            Me.grdDetalleEntradasBodegasDETabla.MoveLast()
            Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCodigoProducto
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Es fila vacía"
    Private Function EsFilaVacia() As Boolean
        Dim blnRetorno As Boolean = False
        Dim Valor As New Object
        Try
            Valor = Me.grdDetalleEntradasBodegasDETabla.Columns("SivProductoID").View.GetRowCellValue(Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle, "SivProductoID")
            blnRetorno = Not Me.TieneValor(Valor)
        Catch ex As Exception
            blnRetorno = False
        End Try
        Return blnRetorno
    End Function
#End Region

#Region "Tiene Valor"

    Private Function TieneValor(ByVal Valor As Object) As Boolean
        If Not Valor Is Nothing Then
            Return (Not IsDBNull(Valor)) AndAlso Valor.ToString.Trim.Length <> 0
        Else
            Return False
        End If
    End Function

#End Region

#Region "Eliminar sin Preguntar"
    Private Sub ElminarFilaSinPreguntar()
        Try
            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows.Count <> 0 Then
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows.RemoveAt(Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle) 'Borra la fila del datatable directo
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Eliminar Fila"
    Private Sub EliminarFila()
        If MsgBox("¿Seguro que desea eliminar la fila seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes Then
            Try
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows.RemoveAt(Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle) 'Borra la fila del datatable directo
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region

#Region "Existe en detalle"
    Private Function ExisteEnDetalle(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        Dim strValorCampo As String
        For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows
            If Me.TieneValor(valor) AndAlso Me.TieneValor(row(Campo)) Then
                strValorCampo = row(Campo)
                If valor.ToString.Trim = strValorCampo.Trim Then
                    blnValor = True
                End If
            End If
        Next
        Return blnValor
    End Function
#End Region

#Region "Número Válido"
    Private Function NumeroValido(ByVal valor As Object) As Boolean
        If Not valor Is Nothing Then
            If Me.TieneValor(valor) Then
                If valor <> 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "Está en última fila"
    Private Function EstaEnUltimaFila() As Boolean
        Return Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle = Me.grdDetalleEntradasBodegasDETabla.RowCount - 1
    End Function
#End Region

#Region "Buscar Duplicados en Grid"
    Private Function BuscarDuplicados(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        Dim iContador As Integer = 0
        Dim strValorCampo As String
        If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows.Count > 1 Then
            For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows
                row.EndEdit()
                If Me.TieneValor(valor) AndAlso Me.TieneValor(row(Campo)) Then
                    strValorCampo = row(Campo)
                    If valor.ToString.Trim.Equals(strValorCampo.Trim) Then
                        iContador += 1
                    End If
                End If
            Next
            If iContador > 1 Then
                blnValor = True
            Else
                blnValor = False
            End If
        End If
        Return blnValor
    End Function
#End Region

#Region "Existen Cantidades en CERO"
    Private Function ExistenCantidadesEnCero() As Boolean
        Return Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Select("Cantidad=0").Length > 0
    End Function
#End Region

#Region "Existen Costos en Cero"
    Private Function ExistenCostosEnCero() As Boolean
        Return Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Select("Costo=0").Length > 0
    End Function
#End Region

#End Region

#Region "Calcular Costo Total DE"
    Private Sub CalcularCostoDE()
        Dim DecCosto As Double
        Try
            DecCosto = 0.0
            If Not Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle") Is Nothing Then
                If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Count > 0 Then
                    DecCosto = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Compute("SUM(Total)", "1=1")
                End If
            End If
            Me.NumCostoTotal.Value = DecCosto
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Generar Nuevo ID"
    Private Function NuevoID() As String
        Dim sSQL As String = "select ISNULL(MAX(CAST(SivEntradaBodegaID AS INT)),0)+1 AS NuevoID FROM SivEntradaBodega"
        Dim dr As SqlDataReader = Nothing
        Dim IntNuevoID As Integer
        Try
            Try
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
                If dr.Read() Then
                    IntNuevoID = dr("NuevoID")
                End If
                Return CStr(IntNuevoID)
            Catch ex As Exception
                Return False
            End Try
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

#Region "Limpiar Grid DE"
    Private Sub LimpiarGridDE()
        If Me.grdDetalleEntradasBodegasDETabla.RowCount > 0 Then
            MsgBox("Se borrará el detalle de Entrada.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Me.CargarDescripcionDE("1=1")
            Me.CargarDetalleEntradaBodegaDE()
        End If
        Me.boolModificado = True
    End Sub
#End Region


#Region "Guardar Entrada"
    Private Function AgregarEntradaBodega() As Boolean
        Dim T As New TransactionManager
        Try
            Try
                T.BeginTran()

                GuardarEntradaBodega(T)
                GuardarEntradaDetalle(T)
                ActualizarSivBodegaRepuesto(T)

                If (cmbTipoEntrada.SelectedValue = intTipoEntradaCompraLocal) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaImportacion) Then
                    ActualizarPrecioProducto(T)
                End If

                boolModificado = False
                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            T = Nothing
        End Try
    End Function

    Private Sub GuardarEntradaBodega(ByVal T As DAL.TransactionManager)
        Dim objSivEntradaBodega As SivEntradaBodega
        Try
            objSivEntradaBodega = New SivEntradaBodega
            objSivEntradaBodega.objStbBodegaID = Me.cmbBodega.SelectedValue

            objSivEntradaBodega.objTipoEntradaID = cmbTipoEntrada.SelectedValue

            If dtpFechaEntrada.Text.Trim <> "" Then
                objSivEntradaBodega.FechaEntrada = dtpFechaEntrada.Value
            End If
            objSivEntradaBodega.CostoTotal = Me.NumCostoTotal.Value
            objSivEntradaBodega.NumeroFactura = txtNumeroFactura.Text.Trim
            If dtpFechaFactura.Text.Trim <> "" Then
                objSivEntradaBodega.FechaFactura = dtpFechaFactura.Value
            End If
            objSivEntradaBodega.Comentarios = txtComentarios.Text.Trim
            objSivEntradaBodega.Anulada = 0
            objSivEntradaBodega.ComentarioAnular = "---"
            If Me.cmbProveedor.Text.Trim <> "" Then
                objSivEntradaBodega.objProvededorID = Me.cmbProveedor.SelectedValue
            End If

            objSivEntradaBodega.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSivEntradaBodega.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSivEntradaBodega.Insert(T)
            Me.SivEntradaBodegaID = objSivEntradaBodega.SivEntradaBodegaID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarEntradaDetalle(ByVal T As DAL.TransactionManager)
        Dim objSivEntradaBodegaDetalle As SivEntradaBodegaDetalle
        Dim objSivBodegaProductos As New SivBodegaProductos
        Dim dtDetalleEntrada As New DataTable
        Dim fila As DataRow

        Try
            objSivEntradaBodegaDetalle = New SivEntradaBodegaDetalle
            dtDetalleEntrada = SivEntradaBodegaDetalle.RetrieveDT("1=0")

            'Isertar detalle de Entradas  
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").AcceptChanges()
            For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows

                'Antes de filtrar actualizar la existencia anterior en el registro de entrada        
                fila = dtDetalleEntrada.NewRow
                fila("objEntradaBodegaID") = Me.SivEntradaBodegaID
                fila("objProductoID") = row("SivProductoID")

                If objSivBodegaProductos.RetrieveByFilter("objProductoID='" & row("SivProductoID") & "' AND objBodegaID=" & Me.cmbBodega.SelectedValue) Then
                    fila("ExistenciaAnterior") = objSivBodegaProductos.Cantidad
                End If
                fila("Cantidad") = row("Cantidad")
                fila("Costo") = row("Costo")
                fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                dtDetalleEntrada.Rows.Add(fila)
            Next

            dtDetalleEntrada.TableName = "SivEntradaBodegaDetalle"
            SivEntradaBodegaDetalle.BatchUpdate(dtDetalleEntrada.DataSet, T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ActualizarSivBodegaRepuesto(ByVal T As DAL.TransactionManager)
        Dim objSivBodegaProductos As SivBodegaProductos
        Dim objSivProductos As SivProductos
        Dim objSivEntradaDetalle As SivEntradaBodegaDetalle
        Dim objSivProductosProveedos As SivProductosDetProv

        Try
            objSivBodegaProductos = New SivBodegaProductos
            objSivProductos = New SivProductos
            objSivEntradaDetalle = New SivEntradaBodegaDetalle
            objSivProductosProveedos = New SivProductosDetProv


            For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows

                'Filtrar el repuesto a modificar de Bodega Repuesto
                If objSivBodegaProductos.RetrieveByFilter("objProductoID='" & row("SivProductoID") & "' AND objBodegaID=" & Me.cmbBodega.SelectedValue) Then

                    objSivBodegaProductos.Cantidad = objSivBodegaProductos.Cantidad + row("Cantidad")
                    objSivBodegaProductos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSivBodegaProductos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objSivBodegaProductos.Update(T)

                    'Filtrar el repuesto para modificar su costoPromedio
                    objSivProductos.RetrieveByFilter("SivProductoID='" & row("SivProductoID") & "'")

                    'Si costo promedio del repuesto es CERO entonces es la primera entrada por lo tanto queda el costo de esa entrada
                    objSivProductos.CostoPromedio = row("Costo")
                    'If objSivProductos.CostoPromedio = 0 Then
                    '    objSivProductos.CostoPromedio = row("Costo")
                    'Else
                    '    objSivProductos.CostoPromedio = ((objSivProductos.CostoPromedio + row("Costo")) / 2)
                    'End If
                    objSivProductos.Update(T)

                Else

                    objSivBodegaProductos.objProductoID = row("SivProductoID")
                    objSivBodegaProductos.objBodegaID = Me.cmbBodega.SelectedValue
                    objSivBodegaProductos.Cantidad = row("Cantidad")
                    objSivBodegaProductos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objSivBodegaProductos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objSivBodegaProductos.Insert(T)


                    If objSivProductos.RetrieveByFilter("SivProductoID='" & row("SivProductoID") & "'") Then
                        objSivProductos.CostoPromedio = CDec(row("Costo")) '((objSivProductos.CostoPromedio + row("Costo")) / 2)
                        objSivProductos.Update(T)
                    End If

                End If

                ''Buscar si el proveedor ya esta registrado para este producto

                If Not objSivProductosProveedos.RetrieveByFilter("objProductosID='" & row("SivProductoID") & "' AND objProveedorID=" & Me.cmbProveedor.SelectedValue, T) Then
                    objSivProductosProveedos.objProductosID = row("SivProductoID")
                    objSivProductosProveedos.objProveedorID = Me.cmbProveedor.SelectedValue
                    objSivProductosProveedos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objSivProductosProveedos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objSivProductosProveedos.Insert(T)
                End If

            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ActualizarSivEntradaBodega1(ByVal FilaDetalleEntrada As Integer, ByVal FiltroEntBodDet As Object, ByVal T As DAL.TransactionManager)
        Dim objSivEntradaBodega As SivEntradaBodega
        Dim dblSumatoriaCostoDolares As Double
        Dim objSivEntradaPreliquidacion As SivEntradaPreliquidacion
        Dim intNumeroEntradaReal As Integer

        Try
            'Caso 1. Solamente se actualiza el registro de Preliquidación en este caso
            objSivEntradaBodega = New SivEntradaBodega
            objSivEntradaPreliquidacion = New SivEntradaPreliquidacion

            If (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadFactura")) >= (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadEnPreli")) Then
                ' Cuenta los registros de preliquidación en la tabla SivEntradaPreliquidacion 
                dtEntradaPreliquidacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivEntradaPreliquidacionID,objEntradaBodegaID,SiEntradaReal,NumeroEntradaReal,Costo", "SivEntradaPreliquidacion", "objEntradaBodegaDetPreliID=" & FiltroEntBodDet), T) ' REVISAR

                ' si solamente ha habido una entrada tipo Compra Local, Importación para esa preliquidacion 
                If dtEntradaPreliquidacion.Rows.Count = 1 Then
                    objSivEntradaBodega.SivEntradaBodegaID = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("SivEntradaBodegaID")
                    objSivEntradaBodega.Retrieve(objSivEntradaBodega.SivEntradaBodegaID, T)

                    objSivEntradaBodega.NumeroFactura = Me.txtNumeroFactura.Text.Trim
                    If Me.dtpFechaFactura.Text.Trim <> "" Then
                        objSivEntradaBodega.FechaFactura = Me.dtpFechaFactura.Value
                    End If
                    objSivEntradaBodega.CostoTotal = Me.NumCostoTotal.Value
                    objSivEntradaBodega.Update(T)
                End If

                ' si han habido varias entrada tipo Compra Local, Importación para esa preliquidacion 
                If dtEntradaPreliquidacion.Rows.Count > 1 Then
                    'Realizar la sumatoria
                    dblSumatoriaCostoDolares = 0
                    PromedioDolares = 0
                    For K As Integer = 0 To dtEntradaPreliquidacion.DefaultView.Count - 1
                        dblSumatoriaCostoDolares = dblSumatoriaCostoDolares + dtEntradaPreliquidacion.DefaultView.Item(K)("Costo")
                    Next
                    PromedioDolares = (dblSumatoriaCostoDolares) / (dtEntradaPreliquidacion.Rows.Count)
                    objSivEntradaBodega.SivEntradaBodegaID = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("SivEntradaBodegaID")
                    objSivEntradaBodega.Retrieve(objSivEntradaBodega.SivEntradaBodegaID, T)
                    objSivEntradaBodega.Update(T)
                End If

                'Actualizar  el campo Numero Entrada SivEntradaPreliquidacion
                '1.Filtrar solamente cuando SiEntradaReal es igual a True
                dtEntradaPreliquidacion.DefaultView.RowFilter = "SiEntradaReal=1"
                intNumeroEntradaReal = dtEntradaPreliquidacion.DefaultView.Item(0)("objEntradaBodegaID")
                dtEntradaPreliquidacion.DefaultView.RowFilter = String.Empty

                '2. Filtrar solamente cuando SiEntradaReal es igual a False y Actualizar el campo NumeroEntradaReal
                dtEntradaPreliquidacion.DefaultView.RowFilter = "SiEntradaReal=0"
                For L As Integer = 0 To dtEntradaPreliquidacion.DefaultView.Count - 1
                    objSivEntradaPreliquidacion.SivEntradaPreliquidacionID = dtEntradaPreliquidacion.DefaultView.Item(L)("SivEntradaPreliquidacionID")
                    objSivEntradaPreliquidacion.Retrieve(objSivEntradaPreliquidacion.SivEntradaPreliquidacionID, T)
                    objSivEntradaPreliquidacion.NumeroEntradaReal = intNumeroEntradaReal
                    objSivEntradaPreliquidacion.Update(T)
                Next
                dtEntradaPreliquidacion.DefaultView.RowFilter = String.Empty

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ActualizarPrecioProducto(ByVal T As DAL.TransactionManager)
        Dim objSivProductos As SivProductos
        Try
            objSivProductos = New SivProductos
            For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows
                'Filtrar el repuesto para modificar su Precio
                objSivProductos.RetrieveByFilter("SivProductoID=" & row("SivProductoID"), T)
                objSivProductos.Precio_Contado = (CDec(row("Costo")) * CDec(((StbParametro.RetrieveDT("Nombre = 'PorcentajeUtilidadContado'", , "Valor").DefaultView.Item(0)("Valor")) / 100))) + CDec(row("Costo"))
                objSivProductos.Precio_Credito = (CDec(row("Costo")) * CDec(((StbParametro.RetrieveDT("Nombre = 'PorcentajeUtilidadCredito'", , "Valor").DefaultView.Item(0)("Valor")) / 100))) + CDec(row("Costo"))
                objSivProductos.Update(T)
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarEntBodegaPREIMP(ByVal T As DAL.TransactionManager)
        Dim objSivEntradaBodegaPREIMP As SivEntradaBodegaPREIMP
        Try
            objSivEntradaBodegaPREIMP = New SivEntradaBodegaPREIMP

            ' Posicionar el maestro en el primer registro del maestro
            Me.grdDetalleEntradasBodegasDETabla.MoveFirst()
            ' Recorrer el dataset de Entrada
            For FilaDetalleEntrada As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Count - 1
                'Recorrer el dataset de Entrada Detalle
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = "objRepuestoID = '" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("objRepuestoID") & "'"

                For FilaPreliquidacion As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                    If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("CantidadFalta") <> Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("CantidadFaltaAnt") Then
                        objSivEntradaBodegaPREIMP.objentradabodegaPRE = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaID")
                        objSivEntradaBodegaPREIMP.objentradabodegaIMP = SivEntradaBodegaID
                        objSivEntradaBodegaPREIMP.objrepuestoid = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("objRepuestoID")
                        objSivEntradaBodegaPREIMP.Insert(T)
                    End If
                Next
                ' Posicionarse en el siguiente registro del maestro
                Me.grdDetalleEntradasBodegasDETabla.MoveNext()
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    'Private Sub ActualizarCostoPreliquidacion(ByVal T As DAL.TransactionManager)
    '    Dim dtProductosPreliquidados, dtEntradaBodegaCosto, dtFacturaDetale As DataTable
    '    Dim objSivEntradaBodegaDetalle As SivEntradaBodegaDetalle
    '    Dim objSivEntradaBodega As SivEntradaBodega
    '    Dim objSfaFacturaRepuestoDetalle As SfaFacturasDetalle
    '    Dim dlbSumaCostoDol, dlbPromedioCostoDol, dblTotalCostoDol As Double

    '    Try
    '        dlbSumaCostoDol = 0
    '        dlbPromedioCostoDol = 0
    '        dblTotalCostoDol = 0

    '        objSivEntradaBodegaDetalle = New SivEntradaBodegaDetalle
    '        objSivEntradaBodega = New SivEntradaBodega
    '        objSfaFacturaRepuestoDetalle = New SfaFacturasDetalle

    '        ' Posicionar el maestro en el primer registro del maestro
    '        Me.grdDetalleEntradasBodegasDETabla.MoveFirst()
    '        ' Recorrer el grid de Entrada
    '        For FilaDetalleEntrada As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Count - 1
    '            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadEnPreli") > 0 Then
    '                'Recorrer el grid de Entrada Detalle
    '                For FilaPreliquidacion As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
    '                    If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("CantidadFalta") <> Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("CantidadFaltaAnt") Then
    '                        dtProductosPreliquidados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objentradabodegaPRE,objentradabodegaIMP,objrepuestoid", "SivEntradaBodegaPREIMP", "objentradabodegaPRE=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaID")), T)
    '                        For K As Integer = 0 To dtProductosPreliquidados.DefaultView.Count - 1
    '                            objSivEntradaBodegaDetalle.RetrieveByFilter("objEntradaBodegaID=" & dtProductosPreliquidados.DefaultView.Item(K)("objentradabodegaIMP") & " AND objrepuestoid=" & dtProductosPreliquidados.DefaultView.Item(K)("objrepuestoid"), T)
    '                            dlbSumaCostoDol = dlbSumaCostoDol + objSivEntradaBodegaDetalle.Costo
    '                        Next
    '                        dlbPromedioCostoDol = (dlbSumaCostoDol) / (dtProductosPreliquidados.Rows.Count)

    '                        For K As Integer = 0 To dtProductosPreliquidados.DefaultView.Count - 1 'REVISAR ESTO
    '                            objSivEntradaBodegaDetalle.RetrieveByFilter("objEntradaBodegaID=" & dtProductosPreliquidados.DefaultView.Item(K)("objentradabodegaPRE") & " AND objrepuestoid=" & dtProductosPreliquidados.DefaultView.Item(K)("objrepuestoid"), T)
    '                            objSivEntradaBodegaDetalle.Costo = dlbPromedioCostoDol
    '                            objSivEntradaBodegaDetalle.Update(T)
    '                        Next

    '                        'Actualizar el costo total relacionado a la entrada por preliquidación
    '                        dtEntradaBodegaCosto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Cantidad,Costo,objEntradaBodegaID,objrepuestoid", "SivEntradaBodegaDetalle", "objEntradaBodegaID=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaID")), T)
    '                        For L As Integer = 0 To dtEntradaBodegaCosto.DefaultView.Count - 1 'REVISAR ESTO
    '                            dblTotalCostoDol = dblTotalCostoDol + (dtEntradaBodegaCosto.DefaultView.Item(L)("Cantidad") * dtEntradaBodegaCosto.DefaultView.Item(L)("Costo"))
    '                        Next

    '                        objSivEntradaBodega.SivEntradaBodegaID = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaID")
    '                        objSivEntradaBodega.Retrieve(objSivEntradaBodega.SivEntradaBodegaID, T)
    '                        objSivEntradaBodega.CostoTotal = dblTotalCostoDol
    '                        objSivEntradaBodega.Update(T)

    '                        'Actualizar el costo dolares de Fatura Detalle REVISAR ESTO 
    '                        dtFacturaDetale = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SfaFacturaRepuestoDetalleID,objEntradaBodegaID,objRepuestoID", "SfaFacturaRepuestoDetalle", "objEntradaBodegaID=" & dtProductosPreliquidados.DefaultView.Item(0)("objentradabodegaPRE") & " AND objRepuestoID=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("objRepuestoID")), T)

    '                        For M As Integer = 0 To dtFacturaDetale.DefaultView.Count - 1
    '                            objSfaFacturaRepuestoDetalle.SfaFacturaRepuestoDetalleID = dtEntradaBodegaCosto.DefaultView.Item(M)("SfaFacturaRepuestoDetalleID")
    '                            objSfaFacturaRepuestoDetalle.Retrieve(objSfaFacturaRepuestoDetalle.SfaFacturaRepuestoDetalleID, T)
    '                            If objSfaFacturaRepuestoDetalle.SfaFacturaRepuestoDetalleID <> 0 Then
    '                                objSfaFacturaRepuestoDetalle.CostoDolares = dlbPromedioCostoDol
    '                                objSfaFacturaRepuestoDetalle.Update(T)
    '                            End If
    '                        Next

    '                    End If

    '                    dlbSumaCostoDol = 0
    '                    dlbPromedioCostoDol = 0
    '                    dblTotalCostoDol = 0
    '                Next
    '            End If
    '            ' Posicionarse en el siguiente registro del maestro
    '            Me.grdDetalleEntradasBodegasDETabla.MoveNext()
    '        Next

    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    End Try

    'End Sub


#End Region

#Region "Validaciones de datos"

#Region "Columnas del grid"

#Region "Código Repuesto"
    Private Function VerificarCodigoExiste(ByVal intCodigo As Integer) As Boolean
        'Dim intContador As Integer = 0
        'For I As Integer = 0 To Me.grdDetalleEntradasBodegas.RowCount - 1
        '    If Me.grdDetalleEntradasBodegas.Item(I)("CodigoRepuesto") = intCodigo Then
        '        intContador = intContador + 1
        '    End If
        'Next
        'If intContador > 1 Then
        '    Return False
        '    Exit Function
        'End If
        'Return True
    End Function
#End Region

#Region "Cantidad"
    Private Function ValidarColumnaCantidad() As Boolean
        'For I As Integer = 0 To Me.grdDetalleEntradasBodegas.RowCount - 1
        '    If (Me.grdDetalleEntradasBodegas.Item(I)("CantidadFactura") = 0) And (Not IsDBNull(Me.grdDetalleEntradasBodegas.Item(I)("objRepuestoID"))) Then
        '        MsgBox("La cantidad de factura debe ser mayor que cero", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        '        Return True
        '        Exit For
        '    End If
        'Next
        Return False
    End Function
#End Region

#Region "Costo"
    Private Function ValidarColumnaCosto() As Boolean
        'For I As Integer = 0 To Me.grdDetalleEntradasBodegas.RowCount - 1
        '    If (Me.grdDetalleEntradasBodegas.Item(I)("Costo") = 0) And (Not IsDBNull(Me.grdDetalleEntradasBodegas.Item(I)("objRepuestoID"))) Then
        '        MsgBox("El costo en dólares debe ser mayor que cero", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        '        Return True
        '        Exit For
        '    End If
        'Next
        'Return False
    End Function
#End Region

#End Region

#Region "Entrada Datos"
    Private Function Validaciones() As Boolean
        Try
            If Me.cmbBodega.Text.Trim = "" Then
                Me.ErrorProvider.SetError(cmbBodega, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If Me.cmbTipoEntrada.Text.Trim = "" Then
                Me.ErrorProvider.SetError(cmbTipoEntrada, My.Resources.MsgObligatorio)
                Return False
                Me.cmbTipoEntrada.Focus()
                Exit Function
            End If

            If (Me.cmbTipoEntrada.SelectedValue <> intTipoAjuste) And (Me.cmbTipoEntrada.SelectedValue <> intTipoEntradaDevolucion) Then

                If (Me.txtNumeroFactura.Text.Trim = "") And (Me.txtNumeroFactura.Enabled = True) Then
                    Me.ErrorProvider.SetError(txtNumeroFactura, My.Resources.MsgObligatorio)
                    Return False
                    Me.txtNumeroFactura.Focus()
                    Exit Function
                End If

                If (Me.dtpFechaFactura.Text.Trim = "") Then
                    Me.ErrorProvider.SetError(dtpFechaFactura, My.Resources.MsgObligatorio)
                    Return False
                    Me.dtpFechaFactura.Focus()
                    Exit Function
                End If
            End If


            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows.Count <= 0 Then
                Me.ErrorProvider.SetError(Me.gbxDetalle, "Debe registrar al menos un repuesto en detalle de Entrada.")
                Return False
                Exit Function
            End If

            If Me.ExistenCantidadesEnCero Then
                Me.ErrorProvider.SetError(Me.gbxDetalle, "Hay al menos una cantidad con valor CERO en detalle de cotización.")
                Return False
                Exit Function
            End If

            If Me.ExistenCostosEnCero Then
                Me.ErrorProvider.SetError(Me.gbxDetalle, "Hay al menos un costo con valor CERO en detalle de cotización.")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#End Region

#End Region

#Region "Eventos del formulario"

#Region "Pantalla"

    Private Sub frmSivEntradaBodegaEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Me.TypeGui
            Case 0
                CargarDetalleEntradaBodegaDE()
                Me.InicializarGui()
        End Select
    End Sub

    Private Sub frmSivEntradaBodegaEditar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.boolModificado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

#End Region

#Region "Combo Box"

    Private Sub cmbTipoEntrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoEntrada.TextChanged
        LimpiarGridDE()

        'Se habilitan los controles en caso de que el tipo de entrada sea diferente de AJUSTE y DEVOLUCION
        If ((cmbTipoEntrada.SelectedValue <> intTipoAjuste) And (cmbTipoEntrada.SelectedValue <> intTipoEntradaDevolucion)) And (cmbTipoEntrada.Text <> "") Then
            txtNumeroFactura.Enabled = True

            dtpFechaFactura.Enabled = True
            dtpFechaFactura.BackColor = Color.White
        Else
            txtNumeroFactura.Text = ""
            txtNumeroFactura.Enabled = False
            If dtpFechaFactura.Enabled = True Then
                dtpFechaFactura.Text = ""
            End If
            dtpFechaFactura.Enabled = False
        End If

        If (cmbTipoEntrada.SelectedValue = intTipoAjuste) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaDevolucion) Then
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").OptionsColumn.ReadOnly = True
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").OptionsColumn.AllowFocus = False
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").AppearanceCell.BackColor = Color.LemonChiffon
        Else
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").OptionsColumn.ReadOnly = False
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").OptionsColumn.AllowFocus = True
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").AppearanceCell.BackColor = Color.White
        End If

        CargarDescripcionDE("1=1")
        ErrorProvider.SetError(cmbTipoEntrada, "")
        Me.boolModificado = True
    End Sub

    Private Sub cmbBodega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBodega.TextChanged
        ErrorProvider.SetError(cmbBodega, "")
        Me.boolModificado = True
    End Sub


#End Region

#Region "TextBox"
    Private Sub txtNumeroFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroFactura.TextChanged
        ErrorProvider.SetError(txtNumeroFactura, "")
        Me.boolModificado = True
    End Sub

    Private Sub txtComentarios_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComentarios.TextChanged
        Me.boolModificado = True
    End Sub
#End Region

#Region "DatetimePicker"
    Private Sub dtpFechaEntrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEntrada.TextChanged
        ErrorProvider.SetError(dtpFechaEntrada, "")
        Me.boolModificado = True
    End Sub

    Private Sub dtpFechaFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaFactura.TextChanged
        ErrorProvider.SetError(dtpFechaFactura, "")
        Me.boolModificado = True
    End Sub
#End Region

#Region "Botones"
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.Validaciones Then
            If Me.AgregarEntradaBodega Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

#End Region

#End Region

    Private Sub grdDetalleEntradasBodegasDE_EditorKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleEntradasBodegasDE.EditorKeyDown
        'Borra en modo de edición del grid, para ello se debe presionar la tecla control + delete
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            Me.EliminarFila()
        End If

    End Sub

    Private Sub grdDetalleEntradasBodegasDE_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleEntradasBodegasDE.Enter
        Me.ErrorProvider.SetError(Me.gbxDetalle, "")

        If (Me.cmbTipoEntrada.SelectedIndex = -1) Or (Me.cmbTipoEntrada.Text = "") Then
            MsgBox("Por favor seleccione un tipo de entrada", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            cmbTipoEntrada.Focus()
        End If

        If Me.grdDetalleEntradasBodegasDETabla.RowCount = 0 Then
            Me.InsertarNuevaFilaGrid()
            Exit Sub
        End If
    End Sub

    Private Sub grdDetalleEntradasBodegasDE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleEntradasBodegasDE.Leave
        Me.grdDetalleEntradasBodegasDETabla.MoveFirst()
        For I As Integer = 0 To Me.grdDetalleEntradasBodegasDETabla.RowCount - 1
            If Me.EsFilaVacia Then
                Me.ElminarFilaSinPreguntar()
            End If
            grdDetalleEntradasBodegasDETabla.MoveNext()
        Next
        CalcularCostoDE()
    End Sub

    Private Sub grdDetalleEntradasBodegasDETabla_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetalleEntradasBodegasDETabla.CellValueChanging
        'Limpiar los íconos de error en el momento de modificar las celdas
        Dim view As ColumnView = sender

        Select Case e.Column.Name
            Case Me.colCodigoProducto.Name, Me.colDescripcion.Name, Me.colCantidadFacturada.Name, Me.colCostoDolares.Name
                view.ClearColumnErrors()
        End Select

    End Sub

    Private Sub grdDetalleEntradasBodegasDETabla_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grdDetalleEntradasBodegasDETabla.InvalidRowException
        'Evitar el popup de error de la celda
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub grdDetalleEntradasBodegasDETabla_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleEntradasBodegasDETabla.KeyDown
        '---- Delete
        If e.KeyCode = Keys.Delete Then
            Dim view As GridView = CType(sender, GridView)
            If view.RowCount <> 0 Then
                If Me.EsFilaVacia Then
                    Me.ElminarFilaSinPreguntar()
                Else
                    Me.EliminarFila()
                    Me.CalcularCostoDE()
                End If
            End If
        End If

        '---- Enter
        If e.KeyCode = Keys.Enter Then
            'Si no hay filas
            If Me.grdDetalleEntradasBodegasDETabla.RowCount = 0 Then
                Me.InsertarNuevaFilaGrid()
                Exit Sub
            End If

            'Cantidad
            If Me.grdDetalleEntradasBodegasDETabla.FocusedColumn.Equals(Me.colCantidadFacturada) Then
                If (cmbTipoEntrada.SelectedValue = intTipoAjuste) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaDevolucion) Then
                    Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCodigoProducto
                    SendKeys.Send("{down}")
                    Exit Sub
                Else
                    Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCostoDolares
                    Exit Sub
                End If
            End If

            'Costo Dólares
            If Me.grdDetalleEntradasBodegasDETabla.FocusedColumn.Equals(Me.colCostoDolares) Then
                Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCodigoProducto
                SendKeys.Send("{down}")
                Exit Sub
            End If

        End If

        '---- Direccional hacia abajo
        If (e.KeyCode = Keys.Down) And (boolExisteErroresGrid = False) Then
            If Me.grdDetalleEntradasBodegasDETabla.RowCount <> 0 Then
                Dim valor As Object = Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").View.GetRowCellValue(Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle, "Costo")
                If Me.EstaEnUltimaFila And Me.NumeroValido(valor) And (Not Me.EsFilaVacia) Then
                    Me.InsertarNuevaFilaGrid()
                End If
            Else
                Me.InsertarNuevaFilaGrid()
            End If
        End If

        '----- Direccional hacia arriba
        If e.KeyCode = Keys.Up Then
            If Me.EsFilaVacia And Me.grdDetalleEntradasBodegasDETabla.RowCount <> 1 Then
                e.SuppressKeyPress = True
                Me.ElminarFilaSinPreguntar()
            End If
        End If

        '--- Direccional hacia derecha
        Try
            If e.KeyCode = Keys.Right AndAlso Me.grdDetalleEntradasBodegasDETabla.FocusedColumn.Equals(Me.colCostoDolares) And (boolExisteErroresGrid = False) Then
                Dim Cantidad As Object = Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").View.GetRowCellValue(Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle, "Costo")
                If Cantidad <> Nothing Then
                    If Me.EstaEnUltimaFila AndAlso Me.NumeroValido(Cantidad) AndAlso (Not Me.EsFilaVacia) Then
                        e.SuppressKeyPress = True
                        Me.InsertarNuevaFilaGrid()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

        'Si se preciona TAB estando en la última Celda editable
        If e.KeyCode = Keys.Tab AndAlso Me.grdDetalleEntradasBodegasDETabla.FocusedColumn.Equals(Me.colCostoDolares) Then
            Me.txtComentarios.Focus()
        End If
    End Sub

    Private Sub grdDetalleEntradasBodegasDETabla_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdDetalleEntradasBodegasDETabla.ValidateRow
        Dim viewCodigoRepuesto As ColumnView = CType(sender, ColumnView)
        Dim viewDescripcion As ColumnView = CType(sender, ColumnView)
        Dim viewCantidad As ColumnView = CType(sender, ColumnView)
        Dim viewCostoDolares As ColumnView = CType(sender, ColumnView)

        Dim columnCodigoRepuesto As GridColumn = viewCodigoRepuesto.Columns("SivProductoID")
        Dim columnDescripcion As GridColumn = viewDescripcion.Columns("SivProductoID")
        Dim columnCantidad As GridColumn = viewCantidad.Columns("Cantidad")
        Dim columnCostoDolares As GridColumn = viewCostoDolares.Columns("Costo")

        If IsDBNull(viewCodigoRepuesto.GetRowCellValue(e.RowHandle, columnCodigoRepuesto)) Then
            e.Valid = False
            viewCodigoRepuesto.SetColumnError(columnCodigoRepuesto, "El Código no puede ser nulo.")
            boolExisteErroresGrid = True
        Else
            'If viewCodigoRepuesto.GetRowCellValue(e.RowHandle, columnCodigoRepuesto) >= Int32.MaxValue Then
            '    e.Valid = False
            '    viewCodigoRepuesto.SetColumnError(columnCodigoRepuesto, "El Código ingresado no es soportado.")
            '    boolExisteErroresGrid = True
            'Else
            '    boolExisteErroresGrid = False
            'End If
        End If

        If IsDBNull(viewDescripcion.GetRowCellValue(e.RowHandle, columnDescripcion)) Then
            e.Valid = False
            viewDescripcion.SetColumnError(columnDescripcion, "La descripcion no puede ser nula.")
            boolExisteErroresGrid = True
        Else
            boolExisteErroresGrid = False
        End If

        If IsDBNull(viewCantidad.GetRowCellValue(e.RowHandle, columnCantidad)) OrElse viewCantidad.GetRowCellValue(e.RowHandle, columnCantidad) <= 0 Then
            e.Valid = False
            viewCantidad.SetColumnError(columnCantidad, "La Cantidad no puede contener un valor NULO, CERO o NEGATIVO.")
            boolExisteErroresGrid = True
        Else
            boolExisteErroresGrid = False
        End If

        If IsDBNull(viewCostoDolares.GetRowCellValue(e.RowHandle, columnCostoDolares)) Then
            e.Valid = False
            viewCostoDolares.SetColumnError(columnCostoDolares, "El Costo Dolares no puede ser nulo.")
            boolExisteErroresGrid = True
        Else
            If viewCostoDolares.GetRowCellValue(e.RowHandle, columnCostoDolares) >= Double.MaxValue Then
                e.Valid = False
                viewCostoDolares.SetColumnError(columnCostoDolares, "El Costo Dolares ingresado no es soportado.")
                boolExisteErroresGrid = True
            Else
                boolExisteErroresGrid = False
            End If
        End If

    End Sub

    Private Sub grdDetalleEntradasBodegasDETabla_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdDetalleEntradasBodegasDETabla.ValidatingEditor
        Dim View As GridView = sender
        Dim Valor As Double
        Dim codigo As String
        Dim bValidarEntero As Boolean = False

        '[CodigoRepuesto]
        If View.FocusedColumn.FieldName = "SivProductoID" Then
            'Obtener el valor actualmente editado
            codigo = Convert.ToString(e.Value)
            bValidarEntero = True
        End If
        '[Cantidad]
        If View.FocusedColumn.FieldName = "Cantidad" Then
            'Obtener el valor actualmente editado
            Valor = Convert.ToDouble(e.Value)
            bValidarEntero = True
        End If

        If bValidarEntero Then
            'Si es negativo, asignar cero
            If Valor < 0 Then
                e.Valid = True
                e.Value = 0
                'e.ErrorText = "Debe ingresar un valor positivo"
            End If
            'Si es mayor que un entero, asignar cero.
            If Valor >= Integer.MaxValue Then
                e.Value = 0
                e.Valid = True
            End If
        End If

    End Sub

    Private Sub grdDetalleEntradasBodegasDETabla_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetalleEntradasBodegasDETabla.CellValueChanged
        Dim FilaActual As Integer
        Dim strIndiceCombo As String
        Dim blnVerificaRepuestoAct, blnVerificaCodRepuesto As Boolean
        Dim objSivProductos As SivProductos
        Dim objProductosDetProv As SivProductosDetProv

        objSivProductos = New SivProductos
        objProductosDetProv = New SivProductosDetProv

        FilaActual = Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle


        'CodigoRepuesto
        If e.Column.Equals(Me.colCodigoProducto) Then
            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Count <> 0 Then
                'Verifica si el código del repuesto existe
                blnVerificaCodRepuesto = objSivProductos.RetrieveByFilter("SivProductoID=" & "'" & (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("SivProductoID")) & "'")
                If (blnVerificaCodRepuesto = False) Then
                    MsgBox("El código de producto no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
                blnVerificaRepuestoAct = objSivProductos.RetrieveByFilter("SivProductoID=" & "'" & objSivProductos.SivProductoID & "'" & " AND Activo=0")
                If (blnVerificaRepuestoAct = True) Then
                    MsgBox("El producto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Si todo está bien se rellenan los datos
                RellenarDatosGrid(Me.grdDetalleEntradasBodegasDETabla.EditingValue, FilaActual)
            End If
        End If

        'Descripción
        If e.Column.Equals(Me.colDescripcion) Then
            strIndiceCombo = grdDetalleEntradasBodegasDETabla.ActiveEditor.EditValue.ToString
            RellenarDatosGrid(strIndiceCombo, FilaActual)
        End If

        'Validacion del repetido
        If e.Column.Equals(Me.colCodigoProducto) Or e.Column.Equals(Me.colDescripcion) Then
            If Me.BuscarDuplicados(Me.grdDetalleEntradasBodegasDETabla.EditingValue, Me.colCodigoProducto.FieldName) Or Me.BuscarDuplicados(Me.grdDetalleEntradasBodegasDETabla.EditingValue, Me.colDescripcion.FieldName) Or Me.BuscarDuplicados(Me.grdDetalleEntradasBodegasDETabla.EditingValue, Me.colCodigoProducto.FieldName) Then
                MsgBox("Este valor ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Sistema")
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
            End If
        End If

        'Cantidad
        If e.Column.Equals(Me.colCantidadFacturada) Or e.Column.Equals(Me.colCostoDolares) Then

            'Valida si primero se digitó la cantidad
            If (IsDBNull(Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("SivProductoID"))) Then
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
                Exit Sub
            End If

            'Realizar cálculos en grid
            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows.Count <> 0 Then
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Total") = (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad")) * (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Costo"))
            End If

            'Calcular los totales
            CalcularCostoDE()

            'Asignacion de cantidades al grid para calculos de preliquidacion
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad") = (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad"))
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidaEntrada") = (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad"))

        End If

        Me.boolModificado = True
    End Sub

#Region "RellenarDatosGrid"
    Private Sub RellenarDatosGrid(ByVal strFiltro As String, ByVal intFilaActual As Integer)
        Dim objSivProductos As SivProductos
        'Dim dtBodegaRepuesto As DataTable

        objSivProductos = New SivProductos


        'Cargar los datos del Repuesto, Detalle Repuesto Proveedor y Bodega Repuestos
        objSivProductos.RetrieveByFilter("SivProductoID=" & "'" & strFiltro & "'" & " AND Activo=1") 'REVISAR ESTO POR REGLAS DE NEGOCIO
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("SivProductoID") = objSivProductos.SivProductoID

        'Asignación de valores por defecto al grid a las columnas visibles
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Producto") = objSivProductos.Nombre
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("CantidaEntrada") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Costo") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Total") = 0

        'Asignación de valores por defecto al grid a las columnas ocultas
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("SivEntradaBodegaID") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("SivEntradaBodegaDetID") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("objTipoEntradaID") = Me.cmbTipoEntrada.SelectedValue

        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Cantidad") = 0

        ''Verifica la existencia del repuesto en bodega siempre y cuando el tipo de entrada se
        '' por Ajuste, devolución, preiiquidación filtrado por la tienda y el repuesto
        '' y por ultimo asignamos el costo promedio del repuesto solamente si este está en bodega 
        'If (Me.cmbTipoEntrada.SelectedValue = intTipoAjuste) Or (Me.cmbTipoEntrada.SelectedValue = intTipoEntradaDevolucion) And (Not IsDBNull(Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("objRepuestoID"))) Then
        '    dtBodegaRepuesto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Cantidad", "SivBodegaRepuestos", "objTiendaID=" & (Me.cmbBodega.SelectedValue) & " AND objRepuestoID='" & objSivRepuestos.SivRepuestoID & "'"))
        '    If dtBodegaRepuesto.Rows.Count = 0 Then
        '        MsgBox("El repuesto no existe en Bodega", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '        Me.ElminarFilaSinPreguntar()
        '        Me.InsertarNuevaFilaGrid()
        '        Exit Sub
        '    End If
        '    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Costo") = objSivRepuestos.CostoProm
        'End If

        'Mover el foco a columna Cantidad
        Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCantidadFacturada
    End Sub

#End Region

End Class