﻿Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports Seguridad.Datos
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports Proyecto.Catalogos.Datos.ClsCatalogos

Public Class frmPedidosEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intPedidoID, intProveedorID, intPersonaID As Integer
    Public boolEditado, boolRegistrad, boolExisteErroresGrid As Boolean
    Public DtMarca, DtCategoria, DtNombreProducto, dtProveedor, dtDetallePedido, dtEstados As DataTable
#End Region

#Region "Propiedades"
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

#End Region

#Region "Funciones"

    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntradaDetalle() As Boolean
       
        If cmbNombreProducto.Text.Trim.Length = 0 Or cmbNombreProducto.EditValue = "0" Then
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
                objPedidoDetalle.CostoSubtotal = row("CostoSubtotal")
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
                .Properties.DataSource = DtMarca
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "MarcaID"
                .Properties.PopulateColumns()
                .Properties.Columns("MarcaID").Visible = False
                .Properties.Columns("Descripcion").Visible = False
                .Properties.Columns("Activa").Visible = False
                .Properties.Columns("FechaCreacion").Visible = False
                .Properties.Columns("UsuarioCreacion").Visible = False
                .Properties.Columns("FechaModificacion").Visible = False
                .Properties.Columns("UsuarioModificacion").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False

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
                .Properties.DataSource = DtCategoria
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "CategoriaID"
                .Properties.PopulateColumns()
                .Properties.Columns("CategoriaID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar Productos"

    Public Sub CargarProductos(CategoriaID As Integer, MarcaID As Integer)
        Try
            DtNombreProducto = SivProductos.RetrieveDT("Activo=1 AND objCategoriaID=" & CategoriaID.ToString() & " AND objMarcaID=" & MarcaID.ToString(), " Nombre", " SivProductoID, (Codigo  + '-' +  Nombre) AS Nombre")
            Dim newProductosRow As DataRow
            newProductosRow = DtNombreProducto.NewRow()
            newProductosRow("SivProductoID") = "0"
            newProductosRow("Nombre") = "Ninguno"
            DtNombreProducto.Rows.Add(newProductosRow)


            With cmbNombreProducto
                .Properties.DataSource = DtNombreProducto
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "SivProductoID"
                .Properties.PopulateColumns()
                .Properties.Columns("SivProductoID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False

            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Estados"
    Public Sub CargarEstados()
        Try
            dtEstados = ObtenerValCat("ESTADOENCARGO")
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

    Private Sub CargarDatosEncargo()
        Dim objPedidoMaster As SivPedidos
        Dim objPedidoDetalle As SivPedidosDetalle
        Try
            objPedidoMaster = New SivPedidos
            objPedidoDetalle = New SivPedidosDetalle

            objPedidoMaster.Retrieve(PedidoID)
            intProveedorID = objPedidoMaster.objProveedorID
            dtaFechaaPedir.Value = objPedidoMaster.FechaPedido
            dtaFechaAutorizado.Value = objPedidoMaster.FechaAutorizacion
            cmbEstado.EditValue = objPedidoMaster.objEstadoID
            txtObservaciones.Text = objPedidoMaster.Observaciones

            ''Cargar Detalle del pedido
            CargarDetallePedidos("objPedidoID=" & PedidoID)

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
                    CargarDatosEncargo()
                    Me.cmbEstado.Enabled = True
                Case 2
                    Me.Text = "Consultar Encargo"
                    CargarDatosEncargo()
                    DeshabilitarControles()
                    cmdGuardar.Enabled = False
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

    Private Sub AgregarProductos()
        Dim filas As DataRow
        Dim ProductoID As Integer
        Dim objSivProducto As SivProductos
        Try
            filas = dtDetallePedido.NewRow
            ProductoID = cmbNombreProducto.EditValue
            objSivProducto = New SivProductos

            objSivProducto.Retrieve(ProductoID)

            filas("Codigo") = objSivProducto.Codigo
            filas("Producto") = cmbNombreProducto.Text
            filas("SivProductoID") = ProductoID
            filas("Cantidad") = spnCantidad.Value
            filas("CostoUnitario") = spnCostoUnitario.Value
            filas("CostoImpuesto") = spnImpuestoUnitario.Value
            filas("objCategoriaID") = cmbCategoria.EditValue
            filas("CostoTotal") = spnCantidad.Value * (spnCostoUnitario.Value - spnImpuestoUnitario.Value)

            dtDetallePedido.Rows.Add(filas)
            spnTotalCosto.Value = spnTotalCosto.Value + filas("CostoTotal")

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

    Private Sub cmbCategoria_EditValueChanged(sender As Object, e As EventArgs) Handles cmbCategoria.EditValueChanged
        Try
            If cmbCategoria.Text <> "" And cmbMarca.Text <> "" Then
                CargarProductos(Convert.ToInt32(cmbCategoria.EditValue), Convert.ToInt32(cmbMarca.EditValue))
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbMarca_EditValueChanged(sender As Object, e As EventArgs) Handles cmbMarca.EditValueChanged
        Try
            If cmbCategoria.Text <> "" And cmbMarca.Text <> "" Then
                CargarProductos(Convert.ToInt32(cmbCategoria.EditValue), Convert.ToInt32(cmbMarca.EditValue))
            End If

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

    Private Sub grdDetallePedidos_KeyDown(sender As Object, e As KeyEventArgs) Handles grdDetallePedidos.KeyDown
        '---- Delete
        If e.KeyCode = Keys.Delete Then
            Dim view As GridView = CType(sender, GridView)
            If view.RowCount <> 0 Then
                If Me.EsFilaVacia Then
                    Me.ElminarFilaSinPreguntar()
                Else
                    Me.EliminarFila()
                End If
            End If
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

    Private Sub txtCodigoProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoProveedor.TextChanged
        ErrorFactura.SetError(txtCodigoProveedor, "")
        boolEditado = True
    End Sub

    Private Sub cmbNombreProducto_TextChanged(sender As Object, e As EventArgs) Handles cmbNombreProducto.TextChanged
        ErrorFactura.SetError(cmbCategoria, "")
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

   
    
End Class