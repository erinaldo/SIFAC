'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Enrique Escobar Maradiaga.
''-- Fecha de Elaboración    : 02 Junio 2010.
''-- Formulario de Agregación de Entrada Bodega
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SCCUM.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmSivEntradaBodegaEditar

#Region "Variables del formulario"
    Dim intTipoAjusteSuma, intTipoAjusteResta, intTipoEntradaCompraLocal, intTipoAjuste, intTipoEntradaDevolucion, intTipoEntradaPreliquidacion, intTipoEntradaImportacion As Integer
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
        Me.intTipoEntradaPreliquidacion = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "05")

        Me.dtpFechaEntrada.Value = clsProyecto.Conexion.FechaServidor
        Me.dtpFechaEntrada.Focus()

        Me.txtNumeroEntrada.Text = Me.NuevoID
        LongitudesMaximas()
        CargarBodegas()
        CargarTipoEntrada()
        CargarProveedor()
        CargarTipoAjuste()
        CargarDescripcionDE("1=1")
        Me.lblUsuario.Text = clsProyecto.Conexion.Usuario

        boolModificado = False
    End Sub
#End Region

#Region "Longitudes Maximas"

    Private Sub LongitudesMaximas()
        Me.txtNumeroFactura.MaxLength = BO.SivEntradaBodega.GetMaxLength("NumeroFactura")
        Me.txtNumeroPoliza.MaxLength = BO.SivEntradaBodega.GetMaxLength("NumeroPoliza")
        Me.txtComentarios.MaxLength = BO.SivEntradaBodega.GetMaxLength("Comentarios")
    End Sub

#End Region

#Region "Cargar Combos"

#Region "Bodega"
    Private Sub CargarBodegas()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("Codigo='C'", "Codigo", "StbTiendaID, Nombre")
            With Me.cmbBodega
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
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

#Region "Tipo de Ajuste"
    Private Sub CargarTipoAjuste()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOAJUSTE')"))
            With Me.cmbTipoAjuste
                .DataSource = dtDatos
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

#End Region

#Region "Cargar Descripción grid DE"

    Private Sub CargarDescripcionDE(ByVal strFiltro As String)
        Dim riLookComboDescripcion As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Try
            dtDescripcionEntrada = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivRepuestoID,DescripcionCorta", "vwSivEntradaBodegaRepProv", strFiltro & " ORDER BY DescripcionCorta"))
            riLookComboDescripcion = Me.grdDetalleEntradasBodegasDE.RepositoryItems(1)
            riLookComboDescripcion.DataSource = dtDescripcionEntrada
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDescripcionEntrada = Nothing
        End Try
    End Sub

#End Region

#End Region

#Region "Procedimientos"

#Region "Cargar Estructura del Grid DE"

    Private Sub CargarDetalleEntradaBodegaDE()
        Try

            dtDetalleEntradaBodegaDE = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID,CodigoRepuesto,objProveedorID,DescripcionCorta,CantidadFactura,CantidadEnPreli,CantidaEntrada,CantidadFalta,Costo,Total,objEntradaBodegaID,Cantidad,SiEntradaReal,objTipoEntradaID,SivEntradaBodegaID,SivEntradaBodegaDetID,CodigoBarras,PrecioEstimado", "vwSivEntradaBodegaDetalle", "1=0 ORDER BY objRepuestoID,SivEntradaBodegaDetID"))
            dtDetEntBodegaDetDE = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID,SivEntradaBodegaID, CodigoRepuesto, CantidadFactura, CantidadEnPreli, CantidadEntrante, CantidadFalta, CantidadFalta as CantidadFaltaAnt, SiEntradaReal,SivEntradaBodegaDetID", "vwEntBodProdPrel", "1=1 ORDER BY objRepuestoID,SivEntradaBodegaDetID"))
            dsDetalleEntradaBodegaDE = New DataSet
            dsDetalleEntradaBodegaDE.Merge(dtDetalleEntradaBodegaDE)
            dsDetalleEntradaBodegaDE.Tables(0).TableName = "vwSivEntradaBodegaDetalle"
            dsDetalleEntradaBodegaDE.Merge(dtDetEntBodegaDetDE)
            dsDetalleEntradaBodegaDE.Tables(1).TableName = "vwSivEntradabodegaProdPreli"

            dsDetalleEntradaBodegaDE.Relations.Add("vwSivEntradaBodegaDetalle_vwSivEntradabodegaProdPreli", dsDetalleEntradaBodegaDE.Tables(0).Columns("objRepuestoID"), dsDetalleEntradaBodegaDE.Tables(1).Columns("objRepuestoID"), False)
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
            Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colBarCode
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
            Valor = Me.grdDetalleEntradasBodegasDETabla.Columns("objRepuestoID").View.GetRowCellValue(Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle, "objRepuestoID")
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
        Return Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Select("CantidadFactura=0").Length > 0
    End Function
#End Region

#Region "Existen Costos en Cero"
    Private Function ExistenCostosEnCero() As Boolean
        Return Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Select("Costo=0").Length > 0
    End Function
#End Region

#Region "Id Respuesto Seleccionado"
    Private Function IdRepuestoSeleccionado() As Integer
        Dim CodigoRepuesto As Object = Me.grdDetalleEntradasBodegasDETabla.Columns("CodigoRepuesto").View.GetRowCellValue(Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle, "CodigoRepuesto")
        If Not Me.NumeroValido(CodigoRepuesto) Then
            CodigoRepuesto = 0
        End If
        Return CodigoRepuesto
    End Function
#End Region

#End Region

#Region "Formatear Grid"

    Private Sub FormatearGrid(ByVal Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal Tipo As String)
        Grid.FilterBar = False
        Grid.VisualStyle = VisualStyle.Office2007Black
        Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Grid.Splits(0).DisplayColumns("Llave").Visible = False 'No mostrar los campos llave
        Grid.EmptyRows = False

        If (Tipo = "Maestro") Then
            Grid.AllowAddNew = True
            Grid.AllowDelete = True

            Grid.Splits(0).DisplayColumns("Cant. Prel.").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Cant. Prel.").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Cant. Ent.").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Cant. Ent.").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Código Proveedor").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Código Proveedor").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Cant. Falta").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Cant. Falta").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Total").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Total").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("objTipoEntradaID").Visible = False
            Grid.Splits(0).DisplayColumns("Cantidad").Visible = False
            Grid.Splits(0).DisplayColumns("SiEntradaReal").Visible = False

            Grid.Splits(0).DisplayColumns("SivEntradaBodegaID").Visible = False
            Grid.Splits(0).DisplayColumns("SivEntradaBodegaDetID").Visible = False

        Else
            Grid.AllowUpdate = False
            Grid.Splits(0).DisplayColumns("Código").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Código").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Cant. Fact.").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Cant. Fact.").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Cant. Prel.").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Cant. Prel.").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Cant. Ent.").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Cant. Ent.").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Cant. Falta").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Cant. Falta").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("SivEntradaBodegaDetID").Visible = False
            Grid.Splits(0).DisplayColumns("CantidadFaltaAnt").Visible = False
            Grid.Splits(0).DisplayColumns("SivEntradaBodegaID").Visible = False


        End If

    End Sub

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

#Region "PRELIQUIDACION"

#Region "Verificar Productos Preliquidados"

    Private Sub VerificarCantidadesPreliquidadas(ByVal intRepuestoID As String, ByVal FilaActual As Integer)
        'Declaracion de variables
        Dim dblCantidadFactura, dblCantidadEnPreli, dblCantidadFalta, dblSumatoriaCantidadFalta, Total, RestaTotal As Double

        'Inicialización de Variables
        Total = 0

        dtCantidadPreliquidada = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivEntradaBodegaDetID,SivEntradaBodegaID, objTipoEntradaID, objRepuestoID, CantidadFactura, CantidadEnPreli, CantidadFalta, SiEntradaReal", "vwEntBodProdPrel", "objRepuestoID='" & intRepuestoID & "'"))

        If dtCantidadPreliquidada.Rows.Count > 0 Then
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFalta") = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFactura")
        Else
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFalta") = 0
        End If

        ''-----------------------------------------------
        ''SOLAMENTE UN REGISTRO DEL PRODUCTO PRELIQUIDADO
        ''-----------------------------------------------

        If dtCantidadPreliquidada.Rows.Count = 1 Then
            dblCantidadFactura = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFactura")
            dblCantidadEnPreli = dtCantidadPreliquidada.DefaultView.Item(0)("CantidadFalta")
            dblCantidadFalta = dtCantidadPreliquidada.DefaultView.Item(0)("CantidadFalta")

            ''Cantidad Falta es mayor que cero
            If dblCantidadFalta > 0 Then
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadEnPreli") = dblCantidadEnPreli

                ''Caso1. Cuando la cantidad de factura es mayor o igual que la cantidad que falta
                If dblCantidadFactura >= dblCantidadFalta Then
                    ''Actualizar el grid Maestro
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad") = dblCantidadFactura - dblCantidadEnPreli
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFalta") = 0

                    ''Actualizar el grid Detalle
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = "objRepuestoID='" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objRepuestoID") & "'"
                    'For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").Rows
                    '    row("CantidadEntrante") = dblCantidadFactura - dblCantidadEnPreli
                    '    row("CantidadFalta") = 0
                    'Next

                    For I As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I)("CantidadEntrante") = dblCantidadFactura - dblCantidadEnPreli
                        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I)("CantidadFalta") = 0
                    Next


                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = String.Empty

                Else
                    ''Caso2. Cuando la cantida de factura es menor que la cantidad que falta
                    ''Actualizar el grid Maestro
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad") = 0
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFalta") = dblCantidadEnPreli - dblCantidadFactura

                    ''Actualizar el grid Detalle
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = "objRepuestoID=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objRepuestoID")
                    'For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").Rows
                    '    row("CantidadEntrante") = 0
                    '    row("CantidadFalta") = dblCantidadEnPreli - dblCantidadFactura
                    'Next

                    For I As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I)("CantidadEntrante") = 0
                        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I)("CantidadFalta") = dblCantidadEnPreli - dblCantidadFactura
                    Next

                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = String.Empty

                End If

                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidaEntrada") = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad")
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objTipoEntradaID") = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "05")
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("SivEntradaBodegaID") = dtCantidadPreliquidada.DefaultView.Item(0)("SivEntradaBodegaID")
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("SivEntradaBodegaDetID") = dtCantidadPreliquidada.DefaultView.Item(0)("SivEntradaBodegaDetID")

            End If
        End If


        ''-----------------------------------------------
        ''EXISTE MAS DE UN REGISTRO DEL PRODUCTO PRELIQUIDADO
        ''-----------------------------------------------
        If dtCantidadPreliquidada.Rows.Count > 1 Then

            ''Realizar la sumatoria de cantidad falta para los productos preliquidados
            dblSumatoriaCantidadFalta = 0.0

            For Each row As DataRow In Me.dtCantidadPreliquidada.Rows
                dblSumatoriaCantidadFalta = dblSumatoriaCantidadFalta + row("CantidadFalta")
            Next
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadEnPreli") = dblSumatoriaCantidadFalta

            dblCantidadFactura = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFactura")
            dblCantidadEnPreli = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadEnPreli")
            dblCantidadFalta = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadEnPreli")

            ''Caso1. Cuando la cantidad de factura es mayor o igual a la sumatoria de la Cantidad Falta
            If dblCantidadFactura >= dblCantidadFalta Then
                ''Actualizar el grid maestro
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad") = dblCantidadFactura - dblCantidadEnPreli
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFalta") = 0

                ''Actualizar el grid Detalle
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = "objRepuestoID=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objRepuestoID")

                'For Each row As DataRow In Me.dtDetEntBodegaDet.Rows
                '    Me.grdDetalleProdPreli.Columns("Cant. Falta").Value = 0
                'Next

                'For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").Rows
                '    row("CantidadFalta") = 0
                'Next

                For I As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I)("CantidadFalta") = 0
                Next
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = String.Empty

            Else
                ''Caso2. Cuando la cantidad de factura es menor que la Cantidad Falta
                ''Actualizar el grid maestro
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad") = 0
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFalta") = dblCantidadEnPreli - dblCantidadFactura

                ''Actualizar el grid Detalle
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = "objRepuestoID=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objRepuestoID")

                ''Recargar el grid nuevamente con los datos originales para que el usuario pueda digitar nuevamente.
                For I As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I).Row.RejectChanges()
                Next

                ''Actualizar Cantidad Faltante
                For I As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                    Total = Total + Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I)("CantidadFalta")
                    RestaTotal = Total - Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFactura")
                    If RestaTotal < 0 Then
                        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I)("CantidadFalta") = 0
                    Else
                        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(I)("CantidadFalta") = RestaTotal
                        Exit For
                    End If
                Next

                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = String.Empty
            End If

            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidaEntrada") = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad")
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objTipoEntradaID") = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "05")
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("SivEntradaBodegaID") = dtCantidadPreliquidada.DefaultView.Item(0)("SivEntradaBodegaID")
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("SivEntradaBodegaDetID") = dtCantidadPreliquidada.DefaultView.Item(0)("SivEntradaBodegaDetID")
        End If

    End Sub

#End Region

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

#Region "Cargar combos"

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de sitio Destino
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Mayo de 2010, 11:20 am.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboSitioDestino()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("ActivoRepuesto=1", "Codigo", "StbTiendaID, Nombre")
            With Me.cmbProveedor
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                '.Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("StbTiendaID").Width = 30
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

#Region "Guardar Entrada"
    Private Function AgregarEntradaBodega() As Boolean
        Dim T As New TransactionManager
        Try
            Try
                T.BeginTran()

                Me.GuardarEntradaBodega(T)
                Me.GuardarEntradaDetalle(T)
                Me.ActualizarSivBodegaRepuesto(T)
                If (cmbTipoEntrada.SelectedValue = intTipoEntradaCompraLocal) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaImportacion) Then
                    ActualizarEntradaBodegaCaso1(T)
                    ActualizarPrecioRepuesto(T)
                    GuardarEntBodegaPREIMP(T)
                    ActualizarCostoPreliquidacion(T)
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
        Dim ExistePreliquidacion As Boolean
        Try
            objSivEntradaBodega = New SivEntradaBodega
            objSivEntradaBodega.objTiendaID = Me.cmbBodega.SelectedValue

            For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows
                If row("CantidadEnPreli") > 0 Then
                    ExistePreliquidacion = True
                    Exit For
                End If
            Next

            If ExistePreliquidacion = True Then
                objSivEntradaBodega.objTipoEntradaID = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "06")
            Else
                objSivEntradaBodega.objTipoEntradaID = cmbTipoEntrada.SelectedValue
            End If

            If (cmbTipoAjuste.Text.Trim <> "") Then
                objSivEntradaBodega.objTipoAjusteID = cmbTipoAjuste.SelectedValue
            End If
            If dtpFechaEntrada.Text.Trim <> "" Then
                objSivEntradaBodega.FechaEntrada = dtpFechaEntrada.Value
            End If
            objSivEntradaBodega.CostoTotal = Me.NumCostoTotal.Value
            objSivEntradaBodega.NumeroFactura = txtNumeroFactura.Text.Trim
            If dtpFechaFactura.Text.Trim <> "" Then
                objSivEntradaBodega.FechaFactura = dtpFechaFactura.Value
            End If
            objSivEntradaBodega.NumeroPoliza = txtNumeroPoliza.Text.Trim
            objSivEntradaBodega.Comentarios = txtComentarios.Text.Trim
            objSivEntradaBodega.Anulada = 0
            objSivEntradaBodega.ComentarioAnular = "---"
            If Me.cmbProveedor.Text.Trim <> "" Then
                objSivEntradaBodega.objProveedorID = Me.cmbProveedor.SelectedValue
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
        Dim dtDetalleEntrada As New DataTable
        Dim fila As DataRow

        Try
            objSivEntradaBodegaDetalle = New SivEntradaBodegaDetalle
            dtDetalleEntrada = SivEntradaBodegaDetalle.RetrieveDT("1=0")

            'Isertar detalle de Entradas  
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").AcceptChanges()
            For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows
                fila = dtDetalleEntrada.NewRow
                fila("objEntradaBodegaID") = Me.SivEntradaBodegaID
                fila("objRepuestoID") = row("objRepuestoID")
                fila("Cantidad") = row("Cantidad")
                fila("Costo") = row("Costo")
                If (cmbTipoEntrada.SelectedValue = intTipoEntradaPreliquidacion) Then
                    fila("CantidadFactura") = 0
                Else
                    fila("CantidadFactura") = row("CantidaEntrada")
                End If
                fila("CantidadEnPreli") = row("CantidadEnPreli")
                fila("CantidadFalta") = row("CantidadFalta")
                fila("SiEntradaReal") = row("SiEntradaReal")
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
        Dim objSivBodegaRepuestos As SivBodegaRepuestos
        Dim objSivRepuestos As SivRepuestos

        Try
            objSivBodegaRepuestos = New SivBodegaRepuestos
            objSivRepuestos = New SivRepuestos

            For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows

                'Filtrar el repuesto a modificar de Bodega Repuesto
                If objSivBodegaRepuestos.RetrieveByFilter("objRepuestoID='" & row("objRepuestoID") & "' AND objTiendaID=" & Me.cmbBodega.SelectedValue) Then

                    'En caso  de que el tipo de entrada sea ajuste
                    If Me.cmbTipoEntrada.SelectedValue = intTipoAjuste Then
                        'En caso de que el tipo de ajuste sea Suma
                        If Me.cmbTipoAjuste.SelectedValue = intTipoAjusteResta Then
                            objSivBodegaRepuestos.Cantidad = objSivBodegaRepuestos.Cantidad - row("Cantidad")
                            objSivBodegaRepuestos.Update()
                        End If
                    Else
                        objSivBodegaRepuestos.Cantidad = objSivBodegaRepuestos.Cantidad + row("Cantidad")
                        objSivBodegaRepuestos.Update()
                    End If

                    ' En caso de que sea una preliquidacion no es necesario calcular los costos promedios
                    If Me.cmbTipoEntrada.SelectedValue <> intTipoEntradaPreliquidacion Then
                        'Filtrar el repuesto para modificar su costoPromedio
                        objSivRepuestos.RetrieveByFilter("SivRepuestoID='" & row("objRepuestoID") & "'")

                        'Si costo promedio del repuesto es CERO entonces es la primera entrada por lo tanto queda el costo de esa entrada
                        If objSivRepuestos.CostoProm = 0 Then
                            objSivRepuestos.CostoProm = row("Costo")
                        Else
                            objSivRepuestos.CostoProm = ((objSivRepuestos.CostoProm + row("Costo")) / 2)
                        End If
                        objSivRepuestos.Update()
                    Else
                        'Filtrar el repuesto para modificar su costoPromedio
                        objSivRepuestos.RetrieveByFilter("SivRepuestoID='" & row("objRepuestoID") & "'")
                        objSivRepuestos.CostoProm = objSivRepuestos.CostoProm
                        objSivRepuestos.Update()
                    End If
                    objSivBodegaRepuestos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSivBodegaRepuestos.FechaCreacion = clsProyecto.Conexion.FechaServidor

                Else

                    objSivBodegaRepuestos.objRepuestoID = row("objRepuestoID")
                    objSivBodegaRepuestos.objTiendaID = Me.cmbBodega.SelectedValue
                    objSivBodegaRepuestos.Cantidad = row("Cantidad")
                    If objSivRepuestos.RetrieveByFilter("SivRepuestoID='" & row("objRepuestoID") & "'") Then
                        objSivRepuestos.CostoProm = ((objSivRepuestos.CostoProm + row("Costo")) / 2)
                        objSivRepuestos.Update()
                    End If
                    objSivBodegaRepuestos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objSivBodegaRepuestos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objSivBodegaRepuestos.Insert(T)

                End If

            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub ActualizarEntradaBodegaCaso1(ByVal T As DAL.TransactionManager)
        Try
            ' Recorrer el grid de Entrada
            ' Posicionar el maestro en el primer registro
            Me.grdDetalleEntradasBodegasDETabla.MoveFirst()

            For FilaDetalleEntrada As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Count - 1
                ' Se filtran solamente las entradas de tipo preliquidación

                If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("objTipoEntradaID") = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "05") Then

                    'Filtro para contar cuantos productos están preliquidados en el subgrid REVISAR ESTO
                    Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.RowFilter = "objRepuestoID = " & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("objRepuestoID")

                    'Si solamente existe un registro del producto preliquidado
                    If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count = 1 Then

                        'Insercion de Registros en la tabla SivEntradaPreliquidacion

                        For FilaPreliquidacion As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                            InsertarSivEntradaPreliquidacion(FilaDetalleEntrada, FilaPreliquidacion, T)
                        Next

                        'Actualizacion de Entrada Bodega
                        ActualizarSivEntradaBodega1(FilaDetalleEntrada, Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(0)("SivEntradaBodegaDetID"), T)

                        'Actualización de Entrada Bodega Detalle
                        ActualizacionSivEntradaDetalle1(FilaDetalleEntrada, Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(0)("SivEntradaBodegaDetID"), Nothing, T)

                    End If

                    'Existe mas de un registro del producto preliquidado
                    If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count > 1 Then

                        'Insercion de Registros en la tabla SivEntradaPreliquidacion
                        For FilaPreliquidacion As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                            InsertarSivEntradaPreliquidacion(FilaDetalleEntrada, FilaPreliquidacion, T)
                        Next

                        'Actualizacion de Entrada Bodega
                        For FilaPreliquidacion As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                            ActualizarSivEntradaBodega1(FilaDetalleEntrada, Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaDetID"), T)
                        Next

                        'Actualización de Entrada Bodega Detalle
                        For FilaPreliquidacion As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                            ActualizacionSivEntradaDetalle1(FilaDetalleEntrada, Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaDetID"), Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("CantidadFalta"), T)
                        Next

                    End If
                End If
                grdDetalleEntradasBodegasDETabla.MoveNext()
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub InsertarSivEntradaPreliquidacion(ByVal FilaDetalleEntrada As Integer, ByVal FilaPreliquidacion As Integer, ByVal T As DAL.TransactionManager)
        Dim objSivEntradaPreliquidacion As SivEntradaPreliquidacion
        Try
            objSivEntradaPreliquidacion = New SivEntradaPreliquidacion

            objSivEntradaPreliquidacion.objEntradaBodegaID = Me.SivEntradaBodegaID
            objSivEntradaPreliquidacion.objEntradaBodegaDetalleID = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TOP (1) SivEntradaBodegaDetID", "SivEntradaBodegaDetalle", "objEntradaBodegaID=" & SivEntradaBodegaID), T).DefaultView.Item(0)("SivEntradaBodegaDetID")
            objSivEntradaPreliquidacion.objEntradaBodegaDetPreliID = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaDetID")
            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadFactura") >= Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadEnPreli") Then
                objSivEntradaPreliquidacion.SiEntradaReal = True
            Else
                objSivEntradaPreliquidacion.SiEntradaReal = False
            End If
            objSivEntradaPreliquidacion.objRepuestoID = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("objRepuestoID")
            objSivEntradaPreliquidacion.objProveedorID = Me.cmbProveedor.SelectedValue
            objSivEntradaPreliquidacion.NumeroFactura = Me.txtNumeroFactura.Text.Trim
            objSivEntradaPreliquidacion.FechaFactura = Me.dtpFechaFactura.Value
            objSivEntradaPreliquidacion.NumeroPoliza = Me.txtNumeroPoliza.Text.Trim
            objSivEntradaPreliquidacion.Costo = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("Costo")
            objSivEntradaPreliquidacion.CantidadFactura = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadFactura")
            objSivEntradaPreliquidacion.Cantidad = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("Cantidad")
            objSivEntradaPreliquidacion.CantidadEnPreli = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadEnPreli")
            objSivEntradaPreliquidacion.CantidadFalta = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadFalta")
            objSivEntradaPreliquidacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSivEntradaPreliquidacion.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSivEntradaPreliquidacion.Insert(T)

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
                    If Me.cmbProveedor.Text.Trim <> "" Then
                        objSivEntradaBodega.objProveedorID = Me.cmbProveedor.SelectedValue
                    End If
                    objSivEntradaBodega.NumeroFactura = Me.txtNumeroFactura.Text.Trim
                    If Me.dtpFechaFactura.Text.Trim <> "" Then
                        objSivEntradaBodega.FechaFactura = Me.dtpFechaFactura.Value
                    End If
                    objSivEntradaBodega.NumeroPoliza = Me.txtNumeroPoliza.Text.Trim
                    objSivEntradaBodega.FechaEntradaReal = clsProyecto.Conexion.FechaServidor
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
                    objSivEntradaBodega.FechaEntradaReal = clsProyecto.Conexion.FechaServidor
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

    Private Sub ActualizacionSivEntradaDetalle1(ByVal FilaDetalleEntrada As Integer, ByVal FiltroEntBodDet As Object, ByVal CantEntBodDet As Object, ByVal T As DAL.TransactionManager)
        Dim dtEntradaPreliquidacion As DataTable
        Dim objSivEntradaBodegaDetalle As SivEntradaBodegaDetalle
        Dim objSivEntradaBodega As SivEntradaBodega
        Dim dblSumCostoDolTotalMaestro As Double
        Try
            objSivEntradaBodegaDetalle = New SivEntradaBodegaDetalle
            objSivEntradaBodega = New SivEntradaBodega

            dtEntradaPreliquidacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivEntradaPreliquidacionID,objEntradaBodegaID,SiEntradaReal,NumeroEntradaReal,Costo", "SivEntradaPreliquidacion", "objEntradaBodegaDetPreliID=" & FiltroEntBodDet), T) ' REVISAR
            ' Caso 1.
            If (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadFactura")) >= (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadEnPreli")) Then
                If dtEntradaPreliquidacion.Rows.Count = 1 Then
                    objSivEntradaBodegaDetalle.SivEntradaBodegaDetID = FiltroEntBodDet 'Me.grdDetalleEntradasBodegas.Item(I)("SivEntradaBodegaID")
                    objSivEntradaBodegaDetalle.Retrieve(objSivEntradaBodegaDetalle.SivEntradaBodegaDetID, T)
                    objSivEntradaBodegaDetalle.SiEntradaReal = True
                    objSivEntradaBodegaDetalle.Costo = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("Costo")
                    objSivEntradaBodegaDetalle.CantidadFalta = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadFalta")
                    objSivEntradaBodegaDetalle.Update(T)
                End If

                If dtEntradaPreliquidacion.Rows.Count > 1 Then
                    objSivEntradaBodegaDetalle.SivEntradaBodegaDetID = FiltroEntBodDet 'Me.grdDetalleEntradasBodegas.Item(I)("SivEntradaBodegaDetID")
                    objSivEntradaBodegaDetalle.Retrieve(objSivEntradaBodegaDetalle.SivEntradaBodegaDetID, T)
                    objSivEntradaBodegaDetalle.SiEntradaReal = True
                    objSivEntradaBodegaDetalle.Costo = PromedioDolares
                    objSivEntradaBodegaDetalle.CantidadFalta = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadFalta")
                    'Actualizar la Entrada Bodega
                    dblSumCostoDolTotalMaestro = 0
                    dblSumCostoDolTotalMaestro = dblSumCostoDolTotalMaestro + ((objSivEntradaBodegaDetalle.Cantidad) * PromedioDolares)
                    objSivEntradaBodega.SivEntradaBodegaID = objSivEntradaBodegaDetalle.objEntradaBodegaID
                    objSivEntradaBodega.Retrieve(objSivEntradaBodega.SivEntradaBodegaID, T)
                    objSivEntradaBodega.CostoTotal = dblSumCostoDolTotalMaestro
                    objSivEntradaBodega.Update(T)
                    objSivEntradaBodegaDetalle.Update(T)
                End If
            Else
                ' Caso 2.
                'Actualización del Detalle
                objSivEntradaBodegaDetalle.SivEntradaBodegaDetID = FiltroEntBodDet 'Me.grdDetalleEntradasBodegas.Item(I)("SivEntradaBodegaDetID")
                objSivEntradaBodegaDetalle.Retrieve(objSivEntradaBodegaDetalle.SivEntradaBodegaDetID, T)
                If CantEntBodDet Is Nothing Then
                    objSivEntradaBodegaDetalle.CantidadFalta = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadFalta")
                Else
                    objSivEntradaBodegaDetalle.CantidadFalta = CantEntBodDet
                End If
                objSivEntradaBodegaDetalle.Update(T)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ActualizarPrecioRepuesto(ByVal T As DAL.TransactionManager)
        Dim objSivRepuesto As SivRepuestos
        Try
            objSivRepuesto = New SivRepuestos
            For Each row As DataRow In Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows
                'Filtrar el repuesto para modificar su Precio
                objSivRepuesto.RetrieveByFilter("SivRepuestoID='" & row("objRepuestoID") & "'")
                objSivRepuesto.Precio = row("PrecioEstimado")
                objSivRepuesto.Update(T)
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

    Private Sub ActualizarCostoPreliquidacion(ByVal T As DAL.TransactionManager)
        Dim dtProductosPreliquidados, dtEntradaBodegaCosto, dtFacturaDetale As DataTable
        Dim objSivEntradaBodegaDetalle As SivEntradaBodegaDetalle
        Dim objSivEntradaBodega As SivEntradaBodega
        Dim objSfaFacturaRepuestoDetalle As SfaFacturaRepuestoDetalle
        Dim dlbSumaCostoDol, dlbPromedioCostoDol, dblTotalCostoDol As Double

        Try
            dlbSumaCostoDol = 0
            dlbPromedioCostoDol = 0
            dblTotalCostoDol = 0

            objSivEntradaBodegaDetalle = New SivEntradaBodegaDetalle
            objSivEntradaBodega = New SivEntradaBodega
            objSfaFacturaRepuestoDetalle = New SfaFacturaRepuestoDetalle

            ' Posicionar el maestro en el primer registro del maestro
            Me.grdDetalleEntradasBodegasDETabla.MoveFirst()
            ' Recorrer el grid de Entrada
            For FilaDetalleEntrada As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Count - 1
                If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaDetalleEntrada)("CantidadEnPreli") > 0 Then
                    'Recorrer el grid de Entrada Detalle
                    For FilaPreliquidacion As Integer = 0 To Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Count - 1
                        If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("CantidadFalta") <> Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("CantidadFaltaAnt") Then
                            dtProductosPreliquidados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objentradabodegaPRE,objentradabodegaIMP,objrepuestoid", "SivEntradaBodegaPREIMP", "objentradabodegaPRE=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaID")), T)
                            For K As Integer = 0 To dtProductosPreliquidados.DefaultView.Count - 1
                                objSivEntradaBodegaDetalle.RetrieveByFilter("objEntradaBodegaID=" & dtProductosPreliquidados.DefaultView.Item(K)("objentradabodegaIMP") & " AND objrepuestoid=" & dtProductosPreliquidados.DefaultView.Item(K)("objrepuestoid"), T)
                                dlbSumaCostoDol = dlbSumaCostoDol + objSivEntradaBodegaDetalle.Costo
                            Next
                            dlbPromedioCostoDol = (dlbSumaCostoDol) / (dtProductosPreliquidados.Rows.Count)

                            For K As Integer = 0 To dtProductosPreliquidados.DefaultView.Count - 1 'REVISAR ESTO
                                objSivEntradaBodegaDetalle.RetrieveByFilter("objEntradaBodegaID=" & dtProductosPreliquidados.DefaultView.Item(K)("objentradabodegaPRE") & " AND objrepuestoid=" & dtProductosPreliquidados.DefaultView.Item(K)("objrepuestoid"), T)
                                objSivEntradaBodegaDetalle.Costo = dlbPromedioCostoDol
                                objSivEntradaBodegaDetalle.Update(T)
                            Next

                            'Actualizar el costo total relacionado a la entrada por preliquidación
                            dtEntradaBodegaCosto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Cantidad,Costo,objEntradaBodegaID,objrepuestoid", "SivEntradaBodegaDetalle", "objEntradaBodegaID=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaID")), T)
                            For L As Integer = 0 To dtEntradaBodegaCosto.DefaultView.Count - 1 'REVISAR ESTO
                                dblTotalCostoDol = dblTotalCostoDol + (dtEntradaBodegaCosto.DefaultView.Item(L)("Cantidad") * dtEntradaBodegaCosto.DefaultView.Item(L)("Costo"))
                            Next

                            objSivEntradaBodega.SivEntradaBodegaID = Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("SivEntradaBodegaID")
                            objSivEntradaBodega.Retrieve(objSivEntradaBodega.SivEntradaBodegaID, T)
                            objSivEntradaBodega.CostoTotal = dblTotalCostoDol
                            objSivEntradaBodega.Update(T)

                            'Actualizar el costo dolares de Fatura Detalle REVISAR ESTO 
                            dtFacturaDetale = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SfaFacturaRepuestoDetalleID,objEntradaBodegaID,objRepuestoID", "SfaFacturaRepuestoDetalle", "objEntradaBodegaID=" & dtProductosPreliquidados.DefaultView.Item(0)("objentradabodegaPRE") & " AND objRepuestoID=" & Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").DefaultView.Item(FilaPreliquidacion)("objRepuestoID")), T)

                            For M As Integer = 0 To dtFacturaDetale.DefaultView.Count - 1
                                objSfaFacturaRepuestoDetalle.SfaFacturaRepuestoDetalleID = dtEntradaBodegaCosto.DefaultView.Item(M)("SfaFacturaRepuestoDetalleID")
                                objSfaFacturaRepuestoDetalle.Retrieve(objSfaFacturaRepuestoDetalle.SfaFacturaRepuestoDetalleID, T)
                                If objSfaFacturaRepuestoDetalle.SfaFacturaRepuestoDetalleID <> 0 Then
                                    objSfaFacturaRepuestoDetalle.CostoDolares = dlbPromedioCostoDol
                                    objSfaFacturaRepuestoDetalle.Update(T)
                                End If
                            Next

                        End If

                        dlbSumaCostoDol = 0
                        dlbPromedioCostoDol = 0
                        dblTotalCostoDol = 0
                    Next
                End If
                ' Posicionarse en el siguiente registro del maestro
                Me.grdDetalleEntradasBodegasDETabla.MoveNext()
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


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

            If (Me.cmbTipoAjuste.Text.Trim = "") And (Me.cmbTipoEntrada.SelectedValue = intTipoAjuste) Then
                Me.ErrorProvider.SetError(cmbTipoAjuste, My.Resources.MsgObligatorio)
                Return False
                Me.cmbTipoAjuste.Focus()
                Exit Function
            End If

            If (Me.cmbTipoEntrada.SelectedValue <> intTipoAjuste) And (Me.cmbTipoEntrada.SelectedValue <> intTipoEntradaDevolucion) And (Me.cmbTipoEntrada.SelectedValue <> intTipoEntradaPreliquidacion) Then
                If (Me.cmbProveedor.Text.Trim = "") And (Me.cmbProveedor.Enabled = True) Then
                    Me.ErrorProvider.SetError(cmbProveedor, My.Resources.MsgObligatorio)
                    Return False
                    Me.cmbProveedor.Focus()
                    Exit Function
                End If

                If (Me.txtNumeroFactura.Text.Trim = "") And (Me.txtNumeroFactura.Enabled = True) Then
                    Me.ErrorProvider.SetError(txtNumeroFactura, My.Resources.MsgObligatorio)
                    Return False
                    Me.txtNumeroFactura.Focus()
                    Exit Function
                End If

                If (Me.cmbTipoEntrada.SelectedValue = intTipoEntradaImportacion) And (Me.txtNumeroPoliza.Text.Trim = "") Then
                    Me.ErrorProvider.SetError(txtNumeroPoliza, My.Resources.MsgObligatorio)
                    Return False
                    Me.txtNumeroPoliza.Focus()
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
        clsProyecto.CargarTemaDefinido(Me)
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
        If ((cmbTipoEntrada.SelectedValue <> intTipoAjuste) And (cmbTipoEntrada.SelectedValue <> intTipoEntradaDevolucion) And (cmbTipoEntrada.SelectedValue <> intTipoEntradaPreliquidacion)) And (cmbTipoEntrada.Text <> "") Then
            cmbTipoAjuste.SelectedIndex = -1
            cmbTipoAjuste.Enabled = False
            cmbProveedor.Enabled = True
            txtNumeroFactura.Enabled = True

            If (cmbTipoEntrada.SelectedValue = intTipoEntradaCompraLocal) Then
                txtNumeroPoliza.Text = "-"
                txtNumeroPoliza.Enabled = False
            Else
                txtNumeroPoliza.Text = ""
                txtNumeroPoliza.Enabled = True
            End If
            dtpFechaFactura.Enabled = True
            dtpFechaFactura.BackColor = Color.White
        Else
            If cmbTipoEntrada.SelectedValue = intTipoAjuste Then
                cmbTipoAjuste.SelectedValue = intTipoAjusteResta
            Else
                cmbTipoAjuste.SelectedIndex = -1
                cmbTipoAjuste.Enabled = False
            End If
            cmbProveedor.SelectedIndex = -1
            cmbProveedor.Enabled = False
            txtNumeroFactura.Text = ""
            txtNumeroFactura.Enabled = False
            txtNumeroPoliza.Text = ""
            txtNumeroPoliza.Enabled = False
            If dtpFechaFactura.Enabled = True Then
                dtpFechaFactura.Text = ""
            End If
            dtpFechaFactura.Enabled = False
        End If

        If (cmbTipoEntrada.SelectedValue = intTipoAjuste) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaDevolucion) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaPreliquidacion) Then
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").OptionsColumn.ReadOnly = True
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").OptionsColumn.AllowFocus = False
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").AppearanceCell.BackColor = Color.LemonChiffon
        Else
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").OptionsColumn.ReadOnly = False
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").OptionsColumn.AllowFocus = True
            Me.grdDetalleEntradasBodegasDETabla.Columns("Costo").AppearanceCell.BackColor = Color.White
        End If

        'PENDIENTE DE REVISAR
        'If (cmbTipoEntrada.SelectedValue = intTipoEntradaCompraLocal) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaImportacion) Then
        '    grdDetalleEntradasBodegas.ChildGrid = Me.grdDetalleProdPreli
        '    grdDetalleEntradasBodegas.Refresh()
        'Else
        '    grdDetalleEntradasBodegas.ChildGrid = Nothing
        '    grdDetalleEntradasBodegas.Refresh()
        'End If

        CargarDescripcionDE("1=1")
        ErrorProvider.SetError(cmbTipoEntrada, "")
        Me.boolModificado = True
    End Sub

    Private Sub cmbProveedor_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedValueChanged
        LimpiarGridDE()

        If (Me.cmbProveedor.SelectedIndex = -1) Or (Me.cmbProveedor.Text <> "") Then
            If Me.cmbProveedor.SelectedIndex <> -1 Then
                CargarDescripcionDE("objProveedorID=" & Me.cmbProveedor.SelectedValue)
            End If
            ErrorProvider.SetError(cmbProveedor, "")
            Me.boolModificado = True
        End If
    End Sub

    Private Sub cmbBodega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBodega.TextChanged
        ErrorProvider.SetError(cmbBodega, "")
        Me.boolModificado = True
    End Sub

    Private Sub cmbTipoAjuste_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoAjuste.TextChanged
        ErrorProvider.SetError(cmbTipoAjuste, "")
        Me.boolModificado = True
    End Sub

#End Region

#Region "TextBox"
    Private Sub txtNumeroFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroFactura.TextChanged
        ErrorProvider.SetError(txtNumeroFactura, "")
        Me.boolModificado = True
    End Sub

    Private Sub txtNumeroPoliza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroPoliza.TextChanged
        ErrorProvider.SetError(txtNumeroPoliza, "")
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

        If ((Me.cmbProveedor.SelectedIndex = -1) Or (Me.cmbProveedor.Text = "")) And (Me.cmbProveedor.Enabled = True) Then
            MsgBox("Por favor seleccione un proveedor", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            cmbProveedor.Focus()
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
            Case Me.colCodigoRepuesto.Name, Me.colDescripcion.Name, Me.colCantidadFacturada.Name, Me.colCostoDolares.Name
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
                If (cmbTipoEntrada.SelectedValue = intTipoAjuste) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaDevolucion) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaPreliquidacion) Then
                    Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colBarCode
                    SendKeys.Send("{down}")
                    Exit Sub
                Else
                    Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCostoDolares
                    Exit Sub
                End If
            End If

            'Costo Dólares
            If Me.grdDetalleEntradasBodegasDETabla.FocusedColumn.Equals(Me.colCostoDolares) Then
                Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colBarCode
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

        Dim columnCodigoRepuesto As GridColumn = viewCodigoRepuesto.Columns("objRepuestoID")
        Dim columnDescripcion As GridColumn = viewDescripcion.Columns("objRepuestoID")
        Dim columnCantidad As GridColumn = viewCantidad.Columns("CantidadFactura")
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
        If View.FocusedColumn.FieldName = "objRepuestoID" Then
            'Obtener el valor actualmente editado
            codigo = Convert.ToString(e.Value)
            bValidarEntero = True
        End If
        '[Cantidad]
        If View.FocusedColumn.FieldName = "CantidadFactura" Then
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
        Dim blnVerificaRepuestoAct, blnVerificaCodRepuesto, blnVerificaCodProveedor As Boolean
        Dim objRepuestos As SivRepuestos
        Dim objRepuestosDetProv As SivRepuestosDetProv
        Dim CodigoRepuesto As String

        objRepuestos = New SivRepuestos
        objRepuestosDetProv = New SivRepuestosDetProv

        FilaActual = Me.grdDetalleEntradasBodegasDETabla.FocusedRowHandle

        ''Codigo de Barras
        'If e.Column.Equals(Me.colBarCode) Then
        '    'Verifica si el código de barras existe (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
        '    blnVerificaBarCode = objRepuestos.RetrieveByFilter("CodigoBarras=" & "'" & (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CodigoBarras")) & "'")
        '    If (blnVerificaBarCode = False) AndAlso (Not IsDBNull(Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CodigoBarras"))) Then
        '        MsgBox("El código de barras no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '        Me.ElminarFilaSinPreguntar()
        '        Me.InsertarNuevaFilaGrid()
        '        Exit Sub
        '    End If

        '    'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
        '    blnVerificaRepuestoAct = objRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & objRepuestos.SivRepuestoID & "'" & " AND Activo=0")
        '    If (blnVerificaRepuestoAct = True) Then
        '        MsgBox("El repuesto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '        Me.ElminarFilaSinPreguntar()
        '        Me.InsertarNuevaFilaGrid()
        '        Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCodigoRepuesto
        '        Exit Sub
        '    End If

        '    'Si todo está bien se rellenan los datos
        '    blnVerificaBarCode = objRepuestos.RetrieveByFilter("CodigoBarras=" & "'" & (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CodigoBarras")) & "'")
        '    If (blnVerificaBarCode = True) Then
        '        RellenarDatosGrid(objRepuestos.SivRepuestoID.ToString, FilaActual)
        '    End If
        'End If

        'Codigo de Barras
        If e.Column.Equals(Me.colBarCode) Then
            'Verificando si el código de barras existe
            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CodigoBarras").ToString.Trim.Length > 0 Then
                CodigoRepuesto = ClsCatalogos.GetCodigoRepuestoByCodigoBarras(Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CodigoBarras").ToString.Trim)
                If CodigoRepuesto = 0 Then
                    MsgBox("El código de barras no existe", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                objRepuestos.Retrieve(CodigoRepuesto)
                'Verificar si el repuesto está activo
                If Not objRepuestos.Activo Then
                    If (blnVerificaRepuestoAct = True) Then
                        MsgBox("El repuesto está inactivo", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                        Me.ElminarFilaSinPreguntar()
                        Me.InsertarNuevaFilaGrid()
                        Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCodigoRepuesto
                        Exit Sub
                    End If
                End If

                'Si todo está bien se rellenan los datos
                If (CodigoRepuesto <> 0) Then
                    RellenarDatosGrid(objRepuestos.SivRepuestoID.ToString, FilaActual)
                End If
            End If
        End If

        'CodigoRepuesto
        If e.Column.Equals(Me.colCodigoRepuesto) Then
            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Count <> 0 Then
                'Verifica si el código del repuesto existe
                blnVerificaCodRepuesto = objRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objRepuestoID")) & "' AND SivRepuestoID NOT IN ('1','2','3')")
                If (blnVerificaCodRepuesto = False) Then
                    MsgBox("El código de repuesto no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
                blnVerificaRepuestoAct = objRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & objRepuestos.SivRepuestoID & "'" & " AND Activo=0")
                If (blnVerificaRepuestoAct = True) Then
                    MsgBox("El repuesto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Si todo está bien se rellenan los datos
                RellenarDatosGrid(Me.grdDetalleEntradasBodegasDETabla.EditingValue, FilaActual)
            End If
        End If

        'Código Proveedor
        If e.Column.Equals(Me.colCodigoProveedor) Then
            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Count <> 0 Then
                'Verifica si el código del proveedor existe
                Dim strsql As String
                strsql = "CodigoRepuesto=" & "'" & (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CodigoRepuesto")) & "' AND objRepuestoID NOT IN ('1','2','3') AND objProveedorID=" & "'" & Me.cmbProveedor.SelectedValue & "'"
                blnVerificaCodProveedor = objRepuestosDetProv.RetrieveByFilter("CodigoRepuesto=" & "'" & (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CodigoRepuesto")) & "' AND objRepuestoID NOT IN ('1','2','3') AND objProveedorID=" & "'" & Me.cmbProveedor.SelectedValue & "'")
                If (blnVerificaCodProveedor = False) Then
                    MsgBox("El código de Proveedor no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                ''Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
                'blnVerificaRepuestoAct = objRepuestosDetProv.RetrieveByFilter("objRepuestoID=" & "'" & objRepuestosDetProv.objRepuestoID & "'" & " AND Activo=0")
                'If (blnVerificaRepuestoAct = True) Then
                '    MsgBox("El repuesto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                '    Me.ElminarFilaSinPreguntar()
                '    Me.InsertarNuevaFilaGrid()
                '    Exit Sub
                'End If

                'Si todo está bien se rellenan los datos
                RellenarDatosGrid(objRepuestosDetProv.objRepuestoID, FilaActual)
            End If
        End If

        'Descripción
        If e.Column.Equals(Me.colDescripcion) Then
            strIndiceCombo = grdDetalleEntradasBodegasDETabla.ActiveEditor.EditValue.ToString
            RellenarDatosGrid(strIndiceCombo, FilaActual)
        End If

        'Validacion del repetido
        If e.Column.Equals(Me.colBarCode) Or e.Column.Equals(Me.colCodigoRepuesto) Or e.Column.Equals(Me.colCodigoProveedor) Or e.Column.Equals(Me.colDescripcion) Then
            If Me.BuscarDuplicados(Me.grdDetalleEntradasBodegasDETabla.EditingValue, Me.colCodigoRepuesto.FieldName) Or Me.BuscarDuplicados(Me.grdDetalleEntradasBodegasDETabla.EditingValue, Me.colCodigoProveedor.FieldName) Or Me.BuscarDuplicados(Me.grdDetalleEntradasBodegasDETabla.EditingValue, Me.colDescripcion.FieldName) Or Me.BuscarDuplicados(Me.grdDetalleEntradasBodegasDETabla.EditingValue, Me.colBarCode.FieldName) Then
                MsgBox("Este valor ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Sistema")
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
            End If
        End If

        'Cantidad
        If e.Column.Equals(Me.colCantidadFacturada) Or e.Column.Equals(Me.colCostoDolares) Then

            'Valida si primero se digitó la cantidad
            If (IsDBNull(Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objRepuestoID"))) Then
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
                Exit Sub
            End If

            'Realizar cálculos en grid
            If Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").Rows.Count <> 0 Then
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Total") = (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFactura")) * (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Costo"))
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("PrecioEstimado") = ((Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Costo")) * ((StbParametro.RetrieveDT("Nombre = 'PorcentajeUtilidad'", , "Valor").DefaultView.Item(0)("Valor")) / 100)) + (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Costo"))
            End If

            'Calcular los totales
            CalcularCostoDE()

            'Asignacion de cantidades al grid para calculos de preliquidacion
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("Cantidad") = (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFactura"))
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidaEntrada") = (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFactura"))
            If Me.cmbTipoEntrada.SelectedValue = intTipoEntradaPreliquidacion Then
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFalta") = (Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFactura"))
            Else
                Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("CantidadFalta") = 0
            End If

            'Carga en el subgrid las preliquidaciones del producto que se digitó
            If (Not IsDBNull(Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objRepuestoID"))) Then
                If (cmbTipoEntrada.SelectedValue = intTipoEntradaCompraLocal) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaImportacion) Then
                    'Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradabodegaProdPreli").RejectChanges()
                    VerificarCantidadesPreliquidadas(Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(FilaActual)("objRepuestoID"), FilaActual)
                End If
            End If

        End If

        Me.boolModificado = True
    End Sub

#Region "RellenarDatosGrid"
    Private Sub RellenarDatosGrid(ByVal strFiltro As String, ByVal intFilaActual As Integer)
        Dim objSivRepuestos As SivRepuestos
        Dim objSivBodegaRepuestos As SivBodegaRepuestos
        Dim objSivRepuestosDetProv As SivRepuestosDetProv
        Dim dtBodegaRepuesto As DataTable

        objSivRepuestos = New SivRepuestos
        objSivBodegaRepuestos = New SivBodegaRepuestos
        objSivRepuestosDetProv = New SivRepuestosDetProv

        'Cargar los datos del Repuesto, Detalle Repuesto Proveedor y Bodega Repuestos
        objSivRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & strFiltro & "'" & " AND Activo=1") 'REVISAR ESTO POR REGLAS DE NEGOCIO
        objSivBodegaRepuestos.RetrieveByFilter("objRepuestoID=" & "'" & objSivRepuestos.SivRepuestoID & "' AND objTiendaID= " & Me.cmbBodega.SelectedValue)
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("CodigoBarras") = objSivRepuestos.CodigoBarras
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("objRepuestoID") = objSivRepuestos.SivRepuestoID
        objSivRepuestosDetProv.RetrieveByFilter("objRepuestoID=" & "'" & objSivRepuestos.SivRepuestoID & "' AND objProveedorID=" & "'" & Me.cmbProveedor.SelectedValue & "'")
        If Not (objSivRepuestosDetProv.CodigoRepuesto) = Nothing Then
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("CodigoRepuesto") = objSivRepuestosDetProv.CodigoRepuesto
        End If

        'Asignación de valores por defecto al grid a las columnas visibles
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("DescripcionCorta") = objSivRepuestos.DescripcionCorta
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("CantidadFactura") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("CantidadEnPreli") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("CantidadEnPreli") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("CantidaEntrada") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("CantidadFalta") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Costo") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Total") = 0

        'Asignación de valores por defecto al grid a las columnas ocultas
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("SivEntradaBodegaID") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("SivEntradaBodegaDetID") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("objTipoEntradaID") = Me.cmbTipoEntrada.SelectedValue
        If Not (Me.cmbProveedor.SelectedText) = Nothing Then
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("objProveedorID") = Me.cmbProveedor.SelectedValue
        Else
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("objProveedorID") = 0
        End If
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Cantidad") = 0
        Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("SiEntradaReal") = 0

        'Verifica la existencia del repuesto en bodega siempre y cuando el tipo de entrada se
        ' por Ajuste, devolución, preiiquidación filtrado por la tienda y el repuesto
        ' y por ultimo asignamos el costo promedio del repuesto solamente si este está en bodega 
        If (Me.cmbTipoEntrada.SelectedValue = intTipoAjuste) Or (Me.cmbTipoEntrada.SelectedValue = intTipoEntradaDevolucion) Or (Me.cmbTipoEntrada.SelectedValue = intTipoEntradaPreliquidacion) And (Not IsDBNull(Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("objRepuestoID"))) Then
            dtBodegaRepuesto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Cantidad", "SivBodegaRepuestos", "objTiendaID=" & (Me.cmbBodega.SelectedValue) & " AND objRepuestoID='" & objSivRepuestos.SivRepuestoID & "'"))
            If dtBodegaRepuesto.Rows.Count = 0 Then
                MsgBox("El repuesto no existe en Bodega", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
                Exit Sub
            End If
            Me.dsDetalleEntradaBodegaDE.Tables("vwSivEntradaBodegaDetalle").DefaultView.Item(intFilaActual)("Costo") = objSivRepuestos.CostoProm
        End If

        'Mover el foco a columna Cantidad
        Me.grdDetalleEntradasBodegasDETabla.FocusedColumn = Me.colCantidadFacturada
    End Sub

#End Region

End Class