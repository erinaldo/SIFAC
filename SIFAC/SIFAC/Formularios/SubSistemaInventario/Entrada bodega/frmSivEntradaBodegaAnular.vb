'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Enrique Escobar Maradiaga.
''-- Fecha de Elaboración    : 02 Junio 2010.
''-- Formulario de Anulación y Consultar de Entrada Bodega
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

Public Class frmSivEntradaBodegaAnular

#Region "Variables del formulario"
    Dim intTipoEntradaCompraLocal, intTipoEntradaDevolucion, intTipoEntradaImportacion As Integer
    Dim dtDetalleEntradaBodega, dtSivBodegaRepuestos As DataTable
    Dim dsDetalleEntradaBodega As DataSet
    Dim boolModificado As Boolean

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

    Private Property cmbProveedor As Object

    Private Sub InicializarGui()
        Dim objSivEntradaBodega As SivEntradaBodega

        Select Case Me.TypeGui
            Case 1
                Me.Text = "Anular Entrada"
                dtpFechaEntrada.Enabled = False
                cmbBodega.Enabled = False
                cmbTipoEntrada.Enabled = False
                txtNumeroFactura.Enabled = False
                dtpFechaFactura.Enabled = False
                txtComentarios.Enabled = False
                'Me.grdDetalleEntradasBodegas.Enabled = False ' REVISAR ESTO
                grdDetalleEntradasBodegas.Splits(0).DisplayColumns(1).Locked = True
                grdDetalleEntradasBodegas.Splits(0).DisplayColumns(2).Locked = True
                grdDetalleEntradasBodegas.Splits(0).DisplayColumns(3).Locked = True
                grdDetalleEntradasBodegas.Splits(0).DisplayColumns(4).Locked = True
                chkAnulado.Visible = False
                txtComentariosAnular.Focus()

            Case 2
                Me.Text = "Consultar Entrada"
                dtpFechaEntrada.Enabled = False
                cmbBodega.Enabled = False
                cmbTipoEntrada.Enabled = False
                txtNumeroFactura.Enabled = False
                dtpFechaFactura.Enabled = False
                txtComentarios.Enabled = False
                txtComentariosAnular.Enabled = False
                chkAnulado.Enabled = False
                'Me.grdDetalleEntradasBodegas.Enabled = False ' REVISAR ESTO
                grdDetalleEntradasBodegas.Splits(0).DisplayColumns(1).Locked = True
                grdDetalleEntradasBodegas.Splits(0).DisplayColumns(2).Locked = True
                grdDetalleEntradasBodegas.Splits(0).DisplayColumns(3).Locked = True
                grdDetalleEntradasBodegas.Splits(0).DisplayColumns(4).Locked = True
                Me.cmdGuardar.Enabled = False
        End Select

        Me.intTipoEntradaImportacion = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "01")
        Me.intTipoEntradaCompraLocal = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "02")
        Me.intTipoEntradaDevolucion = ClsCatalogos.GetValorCatalogoID("TIPOENTRADA", "04") 'REVISAR ESTE

        LongitudesMaximas()
        CargarBodegas()
        CargarTipoEntrada()
      
        Me.lblUsuario.Text = clsProyecto.Conexion.Usuario

        Select Case Me.TypeGui
            Case 1, 2
                objSivEntradaBodega = New SivEntradaBodega
                Try
                    objSivEntradaBodega.SivEntradaBodegaID = Me.SivEntradaBodegaID
                    objSivEntradaBodega.Retrieve(objSivEntradaBodega.SivEntradaBodegaID)
                    Me.txtNumeroEntrada.Text = objSivEntradaBodega.SivEntradaBodegaID
                    Me.cmbBodega.SelectedValue = objSivEntradaBodega.objStbBodegaID
                    Me.cmbTipoEntrada.SelectedValue = objSivEntradaBodega.objTipoEntradaID
                    Me.dtpFechaEntrada.Value = objSivEntradaBodega.FechaEntrada
                    Me.NumCostoTotal.Value = objSivEntradaBodega.CostoTotal
                    If Not IsDBNull(objSivEntradaBodega.NumeroFactura) Then
                        txtNumeroFactura.Text = objSivEntradaBodega.NumeroFactura
                    End If
                    If objSivEntradaBodega.FechaFactura.HasValue = True Then
                        dtpFechaFactura.Value = objSivEntradaBodega.FechaFactura
                    End If
                    If Not IsDBNull(objSivEntradaBodega.Comentarios) Then
                        txtComentarios.Text = objSivEntradaBodega.Comentarios
                    End If
                    Me.chkAnulado.Checked = objSivEntradaBodega.Anulada
                    If Not IsDBNull(objSivEntradaBodega.ComentarioAnular) Then
                        txtComentariosAnular.Text = objSivEntradaBodega.ComentarioAnular
                    End If
                Catch ex As Exception
                    clsError.CaptarError(ex)
                End Try
        End Select

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
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "(objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOENTRADA'))"))
            With cmbTipoEntrada
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

#End Region

#Region "Procedimientos"

#Region "Cargar Estructura del grid"

    Private Sub CargarDetalleEntradaBodega()
        Try
            dtDetalleEntradaBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProductoID,Producto,Cantidad,Costo,Total,SivEntradaBodegaID,SivEntradaBodegaDetID", "vwSivEntradaBodegaDetalle", "objEntradaBodegaID=" & SivEntradaBodegaID & " ORDER BY SivProductoID,SivEntradaBodegaDetID"))
            dsDetalleEntradaBodega = New DataSet
            dsDetalleEntradaBodega.Merge(dtDetalleEntradaBodega)
            dsDetalleEntradaBodega.Tables(0).TableName = "vwSivEntradaBodegaDetalle"
            Me.grdDetalleEntradasBodegas.SetDataBinding(dsDetalleEntradaBodega, "vwSivEntradaBodegaDetalle", True)
            FormatearGrid(grdDetalleEntradasBodegas, "Maestro")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Formatear Grid"

    Private Sub FormatearGrid(ByVal Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal Tipo As String)
        Grid.FilterBar = False
        Grid.VisualStyle = VisualStyle.Office2007Black
        Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Grid.EmptyRows = False

        If (Tipo = "Maestro") Then
            Grid.AllowAddNew = False
            Grid.AllowDelete = False

            Grid.Splits(0).DisplayColumns("Total").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Total").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("SivEntradaBodegaID").Visible = False
            Grid.Splits(0).DisplayColumns("SivEntradaBodegaDetID").Visible = False

        End If

    End Sub

#End Region

#Region "Validaciones de datos"

#Region "Entrada Datos"
    Private Function Validaciones() As Boolean
        Dim strBodegaID, strProductoID As String
        Try

            If Me.txtComentariosAnular.Text.Trim = "" Then
                Me.ErrorProvider.SetError(gbxDatosAnulacion, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            strBodegaID = ""
            strProductoID = ""

            'Verifica si la existencia es menor que la cantidad a anular
            For I As Integer = 0 To Me.grdDetalleEntradasBodegas.RowCount - 1
                strBodegaID = strBodegaID & Me.cmbBodega.SelectedValue & ","
                strProductoID = strProductoID & "'" & Me.grdDetalleEntradasBodegas.Item(I)("SivProductoID") & "',"
            Next
            strBodegaID = "(0," & strBodegaID & "0)"
            strProductoID = "('0'," & strProductoID & "'0')"

            dtSivBodegaRepuestos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "SivBodegaProductos", " objBodegaID IN " & strBodegaID & " AND objProductoID IN " & strProductoID & " ORDER BY objProductoID"))

            For J As Integer = 0 To dtSivBodegaRepuestos.DefaultView.Count - 1
                If dtSivBodegaRepuestos.DefaultView.Item(J)("Cantidad") < grdDetalleEntradasBodegas.Item(J)("Cantidad") Then
                    MsgBox("No se puede anular Entrada a Bodega, porque la existencia es menor que la cantidad a anular", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                End If
            Next

            'Verifica se la cantidad en bodega es mayor que la cantidad digitada
            If dtSivBodegaRepuestos.DefaultView.Count > 0 Then

                For J As Integer = 0 To dtSivBodegaRepuestos.DefaultView.Count - 1
                    If grdDetalleEntradasBodegas.Item(J)("Cantidad") > dtSivBodegaRepuestos.DefaultView.Item(J)("Cantidad") Then
                        MsgBox("No se puede Anular la Entrada, porque la cantidad en Existencia es menor a la cantidad Facturada", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        Exit Function
                    End If
                Next

            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#End Region

#Region "Guardar Entrada Bodega"

    Private Function GuardarEntradaBodega() As Boolean
        Dim T As New TransactionManager
        Try
            Try
                T.BeginTran()
                ActualizarEntradaBodega(T)
                ActualizarSivBodegaRepuesto(T)
                RecalcularCostoPromedio(T)
                ActualizarCantidadCostosEntrada(T)
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

    Private Sub ActualizarEntradaBodega(ByVal T As DAL.TransactionManager)
        Dim objSivEntradaBodega As SivEntradaBodega
        Try
            objSivEntradaBodega = New SivEntradaBodega
            objSivEntradaBodega.SivEntradaBodegaID = Me.SivEntradaBodegaID
            objSivEntradaBodega.Retrieve(objSivEntradaBodega.SivEntradaBodegaID, T)
            objSivEntradaBodega.Anulada = True
            objSivEntradaBodega.ComentarioAnular = Me.txtComentariosAnular.Text.Trim
            objSivEntradaBodega.CostoTotal = 0
            objSivEntradaBodega.Update(T)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub ActualizarSivBodegaRepuesto(ByVal T As DAL.TransactionManager)
        Dim objSivBodegaProductos As SivBodegaProductos
        Dim objSivRepuestos As SivRepuestos

        Try
            objSivBodegaProductos = New SivBodegaProductos
            objSivRepuestos = New SivRepuestos

            If dtSivBodegaRepuestos.DefaultView.Count > 0 Then
                For I As Integer = 0 To Me.grdDetalleEntradasBodegas.RowCount - 1
                    'Filtrar el repuesto a modificar de Bodega Repuesto
                    If objSivBodegaProductos.RetrieveByFilter("objProductoID='" & Me.grdDetalleEntradasBodegas.Item(I)("SivProductoID") & "' AND objBodegaID = " & Me.cmbBodega.SelectedValue, T) Then
                        objSivBodegaProductos.Cantidad = objSivBodegaProductos.Cantidad - Me.grdDetalleEntradasBodegas.Item(I)("Cantidad")
                        objSivBodegaProductos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objSivBodegaProductos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objSivBodegaProductos.Update(T)
                    End If
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub RecalcularCostoPromedio(ByVal T As DAL.TransactionManager)
        Dim dtDatosEntradaDetalle As DataTable
        Dim dbCostoPromedioDolares As Double
        Dim objSivProductos As SivProductos

        Try
            objSivProductos = New SivProductos
            If (cmbTipoEntrada.SelectedValue = intTipoEntradaCompraLocal) Or (cmbTipoEntrada.SelectedValue = intTipoEntradaImportacion) Then

                For Each row As DataRow In Me.dtDetalleEntradaBodega.Rows
                    dbCostoPromedioDolares = 0

                    dtDatosEntradaDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivEntradaBodegaDetID,Costo", "vwSivDatosRecalcularCostoPromedio", "objProductoID='" & row("SivProductoID") & "' ORDER BY SivEntradaBodegaDetID"), T)

                    For Each filaEntradaDetalle As DataRow In dtDatosEntradaDetalle.Rows
                        If dbCostoPromedioDolares = 0 Then
                            dbCostoPromedioDolares = filaEntradaDetalle("Costo")
                        Else
                            dbCostoPromedioDolares = ((dbCostoPromedioDolares + filaEntradaDetalle("Costo")) / 2)
                        End If
                    Next

                    'Filtrar el repuesto para modificar su Precio
                    objSivProductos.RetrieveByFilter("SivProductoID='" & row("SivProductoID") & "'")
                    objSivProductos.CostoPromedio = dbCostoPromedioDolares
                    objSivProductos.Update(T)
                Next

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ActualizarCantidadCostosEntrada(ByVal T As DAL.TransactionManager)
        Dim objSivEntradaBodegaDetalle As SivEntradaBodegaDetalle
        Try
            objSivEntradaBodegaDetalle = New SivEntradaBodegaDetalle

            For I As Integer = 0 To Me.grdDetalleEntradasBodegas.RowCount - 1
                'Filtrar el los detalle de entrada a modificar
                objSivEntradaBodegaDetalle.SivEntradaBodegaDetID = Me.grdDetalleEntradasBodegas.Item(I)("SivEntradaBodegaDetID")
                objSivEntradaBodegaDetalle.Retrieve(objSivEntradaBodegaDetalle.SivEntradaBodegaDetID, T)
                objSivEntradaBodegaDetalle.Cantidad = 0
                objSivEntradaBodegaDetalle.Costo = 0
                objSivEntradaBodegaDetalle.Update(T)
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Eventos del formulario"

#Region "Pantalla"

    Private Sub frmSivEntradaBodegaEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.InicializarGui()
        CargarDetalleEntradaBodega()

        Select Case Me.TypeGui
            Case 1
                txtComentariosAnular.Text = ""
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

#Region "TextBox"

    Private Sub txtComentariosAnular_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComentariosAnular.KeyPress
        ErrorProvider.SetError(gbxDatosAnulacion, "")
        boolModificado = True
    End Sub

#End Region

#Region "Botones"
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.Validaciones Then
            If Me.GuardarEntradaBodega Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

#End Region

#End Region

End Class