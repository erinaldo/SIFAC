Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports Seguridad.Datos
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports Proyecto.Catalogos.Datos.ClsCatalogos
Imports DevExpress.XtraGrid.Columns

Public Class frmPedidosEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intPedidoID, intProveedorID, intPersonaID, intEncargoID As Integer
    Public boolEditado, boolRegistrad, boolExisteErroresGrid As Boolean
    Public DtMarca, DtCategoria, DtNombreProducto, dtProveedor, dtDetallePedido, dtEstados As DataTable
    Public dtEncargosAprobados As DataTable
    Public FiltroEncargos As String
#End Region

#Region "Propiedades"
    Property strFiltroEncargos() As String
        Get
            Return FiltroEncargos
        End Get
        Set(ByVal value As String)
            FiltroEncargos = value
        End Set
    End Property

    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property PedidoID() As Integer
        Get
            Return intPedidoID
        End Get
        Set(ByVal value As Integer)
            intPedidoID = value
        End Set
    End Property

    Property EncargoID() As Integer
        Get
            Return intEncargoID
        End Get
        Set(ByVal value As Integer)
            intEncargoID = value
        End Set
    End Property

#End Region

#Region "Funciones"

    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntradaDetalle() As Boolean

        If cmbNombreProducto.Text.Trim.Length = 0 Or cmbNombreProducto.SelectedValue = "0" Or IsNothing(cmbNombreProducto.SelectedValue) Then
            ErrorFactura.SetError(cmbNombreProducto, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If spnCantidad.Text.Trim.Length = 0 Or spnCantidad.Value = "0" Then
            ErrorFactura.SetError(spnCantidad, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If spnCostoUnitario.Text.Trim.Length = 0 Or spnCantidad.Value = "0" Then
            ErrorFactura.SetError(spnCostoUnitario, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        'Buscar el pdoducto en la lista'
        If dtDetallePedido.Rows.Count > 0 Then
            Dim foundRows() As Data.DataRow
            foundRows = dtDetallePedido.Select("SivProductoID = " & cmbNombreProducto.SelectedValue)

            If foundRows.Length > 0 Then
                MsgBox("El producto seleccionado ya existe en la lista del pedido.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Return False
                Exit Function
            End If
        End If


        Return True
    End Function

    Public Function ValidarEntrada() As Boolean
        If txtNombreProveedor.Text.Trim.Length = 0 Then
            ErrorFactura.SetError(txtNombreProveedor, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If dtDetallePedido.Rows.Count = 0 Then
            MsgBox("Debe indicar al menos un producto en el encargo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

#Region "Procedimientos"

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
            If Me.dtDetallePedido.Rows.Count <> 0 Then
                Me.dtDetallePedido.Rows.RemoveAt(Me.grdDetallePedidosTabla.FocusedRowHandle) 'Borra la fila del datatable directo
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Eliminar Fila"
    Private Sub EliminarFila()
        If MsgBox("¿Seguro que desea eliminar la fila seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes Then
            Try
                Me.dtDetallePedido.Rows.RemoveAt(Me.grdDetallePedidosTabla.FocusedRowHandle) 'Borra la fila del datatable directo
                boolExisteErroresGrid = False
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region

#Region "Es fila vacía"
    Private Function EsFilaVacia() As Boolean
        Dim blnRetorno As Boolean = False
        Dim Valor As New Object
        Try
            Valor = Me.grdDetallePedidosTabla.Columns("Producto").View.GetRowCellValue(Me.grdDetallePedidosTabla.FocusedRowHandle, "Producto")
            blnRetorno = Not Me.TieneValor(Valor)
        Catch ex As Exception
            blnRetorno = False
        End Try
        Return blnRetorno
    End Function
#End Region

#Region "Guardar Encargo"
    Private Sub Guardar()
        Dim objPedidoMaster As SivPedidos
        Dim objPedidoDetalle As SivPedidosDetalle
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objPedidoMaster = New SivPedidos
            objPedidoDetalle = New SivPedidosDetalle

            objPedidoMaster.objEstadoID = cmbEstado.EditValue
            objPedidoMaster.objProveedorID = intProveedorID
            objPedidoMaster.FechaPedido = dtaFechaaPedir.Value
            objPedidoMaster.Observaciones = txtObservaciones.Text
            objPedidoMaster.Activo = True
            objPedidoMaster.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objPedidoMaster.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objPedidoMaster.Insert(T)

            ''Guadar Detalle de Pedidos
            For Each row As DataRow In dtDetallePedido.Rows
                objPedidoDetalle.objPedidoID = objPedidoMaster.SivPedidoID
                objPedidoDetalle.objProductoID = row("SivProductoID")
                objPedidoDetalle.CantidadOrdenada = row("Cantidad")
                objPedidoDetalle.CostoUnitario = row("CostoUnitario")
                objPedidoDetalle.CostoSubtotal = row("Cantidad") * row("CostoUnitario")
                objPedidoDetalle.CostoImpuesto = row("CostoImpuesto")
                objPedidoDetalle.CostoTotal = row("CostoTotal")
                objPedidoDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objPedidoDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objPedidoDetalle.Insert(T)
            Next
            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPedidoMaster = Nothing
            objPedidoDetalle = Nothing
        End Try

    End Sub

    Private Sub Actualizar()
        Dim objPedidoMaster As SivPedidos
        Dim objPedidoDetalle As SivPedidosDetalle
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objPedidoMaster = New SivPedidos
            objPedidoDetalle = New SivPedidosDetalle

            objPedidoMaster.Retrieve(PedidoID)

            objPedidoMaster.objEstadoID = cmbEstado.EditValue
            objPedidoMaster.objProveedorID = intProveedorID
            objPedidoMaster.FechaPedido = dtaFechaaPedir.Value
            objPedidoMaster.Observaciones = txtObservaciones.Text
            objPedidoMaster.Activo = True
            objPedidoMaster.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPedidoMaster.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objPedidoMaster.Update(T)

            'Eliminar Detalle'
            SivPedidosDetalle.DeleteByFilter("objPedidoID=" & PedidoID, T)

            ''Guadar Detalle de Encargos
            For Each row As DataRow In dtDetallePedido.Rows
                objPedidoDetalle.objPedidoID = objPedidoMaster.SivPedidoID
                objPedidoDetalle.objProductoID = row("SivProductoID")
                objPedidoDetalle.CantidadOrdenada = row("Cantidad")
                objPedidoDetalle.CostoUnitario = row("CostoUnitario")
                objPedidoDetalle.CostoSubtotal = row("Cantidad") * row("CostoUnitario")
                objPedidoDetalle.CostoImpuesto = row("CostoImpuesto")
                objPedidoDetalle.CostoTotal = row("CostoTotal")
                objPedidoDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objPedidoDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objPedidoDetalle.Insert(T)
            Next

            T.CommitTran()

            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPedidoMaster = Nothing
            objPedidoDetalle = Nothing
        End Try
    End Sub
#End Region

#Region "Controles"
    Private Sub DeshabilitarControles()
        Try
            cmdProveedor.Enabled = False
            cmdAgregarProveedor.Enabled = False
            cmbEstado.Enabled = False
            cmdAgregar.Enabled = False
            dtpFecha.Enabled = False
            cmbCategoria.Enabled = False
            cmbMarca.Enabled = False
            cmbNombreProducto.Enabled = False
            spnCantidad.Enabled = False
            txtObservaciones.Enabled = False
            spnCostoUnitario.Enabled = False
            spnImpuestoUnitario.Enabled = False
            dtaFechaaPedir.Enabled = False
            dtaFechaAutorizado.Enabled = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#End Region

#Region "Cargar Combos"

#Region "Cargar Marcas"

    '' Descripción:        Procedimiento encargado de cargar los valores de Marca
    Public Sub CargarMarca()
        Try
            DtMarca = SivMarcas.RetrieveDT("Activa=1")

            Dim newMarcasRow As DataRow
            newMarcasRow = DtMarca.NewRow()
            newMarcasRow("MarcaID") = "0"
            newMarcasRow("Nombre") = "Ninguna"
            DtMarca.Rows.Add(newMarcasRow)

            With cmbMarca
                .DataSource = DtMarca
                .DisplayMember = "Nombre"
                .ValueMember = "MarcaID"
                .Splits(0).DisplayColumns("MarcaID").Visible = False
                .Splits(0).DisplayColumns("Descripcion").Visible = False
                .Splits(0).DisplayColumns("Activa").Visible = False
                .Splits(0).DisplayColumns("FechaCreacion").Visible = False
                .Splits(0).DisplayColumns("UsuarioCreacion").Visible = False
                .Splits(0).DisplayColumns("FechaModificacion").Visible = False
                .Splits(0).DisplayColumns("UsuarioModificacion").Visible = False
                .ExtendRightColumn = True
                .SelectedValue = -1
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            DtMarca = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar Categorias"

    '' Descripción:        Procedimiento encargado de cargar los valores de Categorias
    Public Sub CargarCategorias()
        Try
            DtCategoria = SivCategorias.RetrieveDT("Activa=1", " Nombre", "CategoriaID, Nombre")

            Dim newCategoriaRow As DataRow
            newCategoriaRow = DtCategoria.NewRow()
            newCategoriaRow("CategoriaID") = "0"
            newCategoriaRow("Nombre") = "Ninguna"
            DtCategoria.Rows.Add(newCategoriaRow)

            With cmbCategoria
                .DataSource = DtCategoria
                .DisplayMember = "Nombre"
                .ValueMember = "CategoriaID"
                .Splits(0).DisplayColumns("CategoriaID").Visible = False
                .ExtendRightColumn = True
                .SelectedValue = -1

            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar Productos"

    Public Sub CargarProductos(CategoriaID As Integer, MarcaID As Integer)
        Dim strfiltro As String
        Try
            If (cmbCategoria.Text.Trim.Length = 0 Or cmbCategoria.SelectedValue = "0" Or IsNothing(cmbCategoria.SelectedValue)) And (cmbMarca.Text.Trim.Length <> 0 And cmbMarca.SelectedValue <> "0" And IsNothing(cmbMarca.SelectedValue)) Then
                strfiltro = "Activo=1  AND objMarcaID=" & MarcaID.ToString()
            Else
                If (cmbCategoria.Text.Trim.Length <> 0 And cmbCategoria.SelectedValue <> "0" And Not (IsNothing(cmbCategoria.SelectedValue)) And (cmbMarca.Text.Trim.Length = 0 Or cmbMarca.SelectedValue = "0" Or IsNothing(cmbMarca.SelectedValue))) Then
                    strfiltro = "Activo=1  AND objCategoriaID=" & CategoriaID.ToString()
                Else
                    If (cmbCategoria.Text.Trim.Length <> 0 And cmbCategoria.SelectedValue <> "0" And Not (IsNothing(cmbCategoria.SelectedValue)) And (cmbMarca.Text.Trim.Length <> 0 And cmbMarca.SelectedValue <> "0" Or IsNothing(cmbMarca.SelectedValue))) Then
                        strfiltro = "Activo=1 AND objCategoriaID=" & CategoriaID.ToString() & " AND objMarcaID=" & MarcaID.ToString()
                    Else
                        strfiltro = "1=1 "
                    End If
                End If
            End If

            strfiltro = strfiltro & " AND SivProductoID not in (select p.SivProductoID from  SivProductos p where UsuarioCreacion='Migracion' and Activo=0)"

            DtNombreProducto = SivProductos.RetrieveDT(strfiltro, " Nombre", " SivProductoID, Nombre")

            Dim newProductosRow As DataRow
            newProductosRow = DtNombreProducto.NewRow()
            newProductosRow("SivProductoID") = "0"
            newProductosRow("Nombre") = "Ninguno"
            DtNombreProducto.Rows.Add(newProductosRow)


            With cmbNombreProducto
                .DataSource = DtNombreProducto
                .DisplayMember = "Nombre"
                .ValueMember = "SivProductoID"
                .Splits(0).DisplayColumns("SivProductoID").Visible = False
                .ExtendRightColumn = True
                .SelectedValue = -1
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Estados"
    Public Sub CargarEstados()
        Try
            dtEstados = ObtenerValCat("ESTADOPEDIDO")
            With cmbEstado
                .Properties.DataSource = dtEstados
                .Properties.DisplayMember = "Descripcion"
                .Properties.ValueMember = "StbValorCatalogoID"
                .Properties.PopulateColumns()
                .Properties.Columns("StbValorCatalogoID").Visible = False
                .Properties.Columns("Codigo").Visible = False
                .Properties.Columns("Activo").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#End Region

#Region "Cargar Datos"

#Region "Cargar Datos del Proveedor"

    Private Sub CargarDatosProveedor()
        Dim dtDatosProveedor As New DataTable
        Try
            Try
                If Not String.IsNullOrEmpty(Me.intProveedorID) Then
                    dtDatosProveedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,SivProveedorID,Identificacion, NombreProveedor", "vwSivProveedores", "StbPersonaID = " & Me.intPersonaID))

                    If dtDatosProveedor.Rows.Count > 0 Then

                        Me.intProveedorID = dtDatosProveedor.DefaultView.Item(0)("SivProveedorID")

                        If Not IsDBNull(dtDatosProveedor.DefaultView.Item(0)("Identificacion")) Then
                            Me.txtCodigoProveedor.Text = dtDatosProveedor.DefaultView.Item(0)("Identificacion")
                        Else
                            Me.txtCodigoProveedor.Text = ""
                        End If

                        If Not IsDBNull(dtDatosProveedor.DefaultView.Item(0)("NombreProveedor")) Then
                            Me.txtNombreProveedor.Text = dtDatosProveedor.DefaultView.Item(0)("NombreProveedor")
                        Else
                            Me.txtNombreProveedor.Text = ""
                        End If
                    End If

                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatosProveedor = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar Datos Pedido"

    Private Sub CargarDatosPedido()
        Dim objPedidoMaster As SivPedidos
        Dim objPedidoDetalle As SivPedidosDetalle
        Dim objProveedor As SivProveedor
        Try
            objPedidoMaster = New SivPedidos
            objPedidoDetalle = New SivPedidosDetalle
            objProveedor = New SivProveedor

            objPedidoMaster.Retrieve(PedidoID)
            intProveedorID = objPedidoMaster.objProveedorID
            objProveedor.Retrieve(intProveedorID)
            intPersonaID = objProveedor.objPersonaID
            dtaFechaaPedir.Value = objPedidoMaster.FechaPedido
            dtaFechaAutorizado.Value = objPedidoMaster.FechaAutorizacion
            cmbEstado.EditValue = objPedidoMaster.objEstadoID
            txtObservaciones.Text = objPedidoMaster.Observaciones

            CargarDatosProveedor()

            ''Cargar Detalle del pedido
            CargarDetallePedidos("objPedidoID=" & PedidoID)

            CalcularTotal()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarDatosEncargo()
        Try
            dtDetallePedido = New DataTable
            dtDetallePedido = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProductoID, Codigo, objCategoriaID, Producto, Cantidad, 0 AS CostoImpuesto, CostoUnitario,Cantidad* CostoUnitario CostoTotal ", "vwSivEncargosPedidosDetalle", " SivEncargoDetalleID IN (" & strFiltroEncargos & ")"))
            Me.grdDetallePedidos.DataSource = dtDetallePedido
            CalcularTotal()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Consultar Proveedor"

    Private Sub CargarConsultaProveedor()
        Dim objPers As frmSivProveedorEdit
        Try
            Try
                objPers = New frmSivProveedorEdit
                If Me.intProveedorID.ToString.Trim.Length <> 0 Then
                    objPers.TypeGui = 2
                    objPers.IDProveedor = intProveedorID
                    objPers.ShowDialog(Me)
                Else
                    objPers.TypeGui = 0
                    If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.intProveedorID = objPers.IDProveedor
                        Me.CargarDatosProveedor()
                    End If
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objPers = Nothing
        End Try
    End Sub

#End Region

#Region "Inicializar GUI"

    Public Sub ConfigurarGUI()
        Try
            CargarCategorias()
            CargarMarca()
            CargarEstados()

            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Pedido"
                    Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                    Me.CargarDetallePedidos("1=0")
                    Me.txtObservaciones.Properties.MaxLength = SivEncargosDetalle.GetMaxLength("Observaciones")
                    Me.cmbEstado.Text = "REGISTRADO"
                    Me.cmbEstado.Enabled = False
                    Me.dtaFechaaPedir.Value = clsProyecto.Conexion.FechaServidor
                Case 1
                    Me.Text = "Editar Pedido"
                    CargarDatosPedido()
                    Me.cmbEstado.Enabled = True
                Case 2
                    Me.Text = "Consultar Pedido"
                    CargarDatosPedido()
                    DeshabilitarControles()
                    cmdGuardar.Enabled = False
                Case 3
                    Me.Text = "Agregar Pedido"
                    Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                    Me.CargarDetallePedidos("1=0")
                    Me.txtObservaciones.Properties.MaxLength = SivEncargosDetalle.GetMaxLength("Observaciones")
                    Me.cmbEstado.Text = "REGISTRADO"
                    Me.cmbEstado.Enabled = False
                    Me.dtaFechaaPedir.Value = clsProyecto.Conexion.FechaServidor
                    CargarDatosEncargo()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Grid"
    Private Sub CargarDetallePedidos(ByVal strFiltro As String)
        dtDetallePedido = New DataTable
        Try
            dtDetallePedido = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProductoID, Codigo, objCategoriaID, Categoria, Producto, Cantidad,CostoImpuesto, CostoUnitario, CostoTotal, objPedidoID", "vwSivDetalleProductosPedidos", strFiltro))
            Me.grdDetallePedidos.DataSource = dtDetallePedido
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CalcularTotal()
        Try
            spnTotalCosto.Value = 0.0
            For Each row As DataRow In dtDetallePedido.Rows
                If Not IsDBNull(row("CostoTotal")) Then
                    spnTotalCosto.Value = spnTotalCosto.Value + row("CostoTotal")
                Else
                    spnTotalCosto.Value = 0.0
                End If
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub AgregarProductos()
        Dim filas As DataRow
        Dim ProductoID As Integer
        Dim objSivProducto As SivProductos
        Try
            filas = dtDetallePedido.NewRow
            ProductoID = cmbNombreProducto.SelectedValue
            objSivProducto = New SivProductos

            objSivProducto.Retrieve(ProductoID)

            filas("Codigo") = objSivProducto.Codigo
            filas("Producto") = cmbNombreProducto.Text
            filas("SivProductoID") = ProductoID
            filas("Cantidad") = spnCantidad.Value
            filas("CostoUnitario") = spnCostoUnitario.Value
            filas("CostoImpuesto") = spnImpuestoUnitario.Value

            If Not IsNothing(objSivProducto.objCategoriaID) Then
                filas("objCategoriaID") = objSivProducto.objCategoriaID
            End If

            filas("CostoTotal") = spnCantidad.Value * (spnCostoUnitario.Value - spnImpuestoUnitario.Value)

            dtDetallePedido.Rows.Add(filas)

            CalcularTotal()

            ''Limpiar controles
            Me.cmbMarca.SelectedValue = -1
            Me.cmbCategoria.SelectedValue = -1
            Me.cmbNombreProducto.SelectedValue = -1

            Me.spnCantidad.Value = 0
            Me.spnCostoUnitario.Value = 0
            Me.spnImpuestoUnitario.Value = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region


#End Region

#Region "Eventos"
    Private Sub frmPedidosEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub cmbCategoria_EditValueChanged(sender As Object, e As EventArgs)
        Try
            CargarProductos(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue))

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbMarca_EditValueChanged(sender As Object, e As EventArgs)
        Try
            CargarProductos(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()

    End Sub

    Private Sub cmdAgregarProveedor_Click(sender As Object, e As EventArgs) Handles cmdAgregarProveedor.Click
        Me.CargarConsultaProveedor()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If ValidarEntradaDetalle() Then
            AgregarProductos()
        End If
    End Sub

    

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            If ValidarEntrada() Then
                Select Case Me.TypeGui
                    Case 0
                        Me.Guardar()
                    Case 1
                        Me.Actualizar()
                    Case 3
                        Guardar()
                End Select
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdProveedor_Click(sender As Object, e As EventArgs) Handles cmdProveedor.Click
        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Filtro = " Descripcion = 'Proveedor' "
            objSeleccion.Opcion = 1
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.intPersonaID = objSeleccion.Seleccion
                CargarDatosProveedor()
                ErrorFactura.SetError(txtNombreProveedor, "")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbNombreProducto_Enter(sender As Object, e As EventArgs) Handles cmbNombreProducto.Enter
        Try
            CargarProductos(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtCodigoProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoProveedor.TextChanged
        ErrorFactura.SetError(txtCodigoProveedor, "")
        boolEditado = True
    End Sub

    Private Sub cmbNombreProducto_TextChanged(sender As Object, e As EventArgs)
        ErrorFactura.SetError(cmbNombreProducto, "")
        boolEditado = True
    End Sub

    Private Sub spnCantidad_TextChanged(sender As Object, e As EventArgs) Handles spnCantidad.TextChanged
        ErrorFactura.SetError(spnCantidad, "")
        boolEditado = True
    End Sub

    Private Sub spnCostoUnitario_TextChanged(sender As Object, e As EventArgs) Handles spnCostoUnitario.TextChanged
        ErrorFactura.SetError(spnCostoUnitario, "")
        boolEditado = True
    End Sub

#End Region


    Private Sub grdDetallePedidosTabla_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles grdDetallePedidosTabla.ValidateRow
        Dim viewCosto As ColumnView = CType(sender, ColumnView)
        Dim columnCostoDolares As GridColumn = viewCosto.Columns("CostoUnitario")
        Try
        If IsDBNull(viewCosto.GetRowCellValue(e.RowHandle, columnCostoDolares)) Then
            e.Valid = False
            viewCosto.SetColumnError(columnCostoDolares, "El Costo no puede ser nulo.")
            boolExisteErroresGrid = True
        Else
            If viewCosto.GetRowCellValue(e.RowHandle, columnCostoDolares) >= Double.MaxValue Then
                e.Valid = False
                viewCosto.SetColumnError(columnCostoDolares, "El Costo ingresado no es soportado.")
                boolExisteErroresGrid = True
            Else
                boolExisteErroresGrid = False
            End If
        End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub grdDetallePedidosTabla_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetallePedidosTabla.CellValueChanged
        Dim objSivProductos As SivProductos
        Dim objProductosDetProv As SivProductosDetProv
        Dim FilaActual As Integer
        Try

        objSivProductos = New SivProductos
            objProductosDetProv = New SivProductosDetProv

        FilaActual = Me.grdDetallePedidosTabla.FocusedRowHandle

        'Cantidad
        If e.Column.Equals(Me.colCostoUnitario) Or e.Column.Equals(Me.colCantidad) Then

            'Realizar cálculos en grid
            If Me.dtDetallePedido.Rows.Count <> 0 Then
                    Me.dtDetallePedido.DefaultView.Item(FilaActual)("CostoTotal") = (Me.dtDetallePedido.DefaultView.Item(FilaActual)("Cantidad")) * (Me.dtDetallePedido.DefaultView.Item(FilaActual)("CostoUnitario"))
            End If

            'Calcular los totales
            CalcularTotal()
        End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdDetallePedidosTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles grdDetallePedidosTabla.KeyDown
        '---- Delete
        If e.KeyCode = Keys.Delete Then
            Dim view As GridView = CType(sender, GridView)
            If view.RowCount <> 0 Then
                If Me.EsFilaVacia Then
                    Me.ElminarFilaSinPreguntar()
                Else
                    Me.EliminarFila()
                    Me.CalcularTotal()
                End If
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            'Costo Dólares
            If Me.grdDetallePedidosTabla.FocusedColumn.Equals(Me.colCostoUnitario) Then
                Me.grdDetallePedidosTabla.FocusedColumn = Me.colCostoUnitario

                SendKeys.Send("{down}")
                Exit Sub
            End If

        End If

        'Si se preciona TAB estando en la última Celda editable
        If e.KeyCode = Keys.Tab AndAlso Me.grdDetallePedidosTabla.FocusedColumn.Equals(Me.colCostoUnitario) Then
            Me.cmdGuardar.Focus()
        End If

    End Sub
End Class