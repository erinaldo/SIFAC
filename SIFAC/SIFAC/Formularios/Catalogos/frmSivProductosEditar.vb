Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSivProductosEditar

#Region "Declaracion de Variables"
    Public DtMarca, DtCategoria, DtSegmento As DataTable
    Public intTypeGui As Integer
    Public intProductoID As Integer
    Public boolEditado As Boolean
    Dim dtProveedor As DataTable
    Dim dtProveedorCombo As DataTable
    Dim dtExistenciaBodega As DataTable
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

    Property ProductoID() As Integer
        Get
            Return intProductoID
        End Get
        Set(ByVal value As Integer)
            intProductoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripci�n:        Procedimiento encargado de cargar los valores de Marca
    Public Sub CargarMarca()
        Try
            cmbMarca.ValueMember = "MarcaID"
            cmbMarca.DisplayMember = "Nombre"
            DtMarca = SivMarcas.RetrieveDT("Activa=1")
            cmbMarca.DataSource = DtMarca
            cmbMarca.Text = ""
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            DtMarca = Nothing
        End Try

    End Sub

    '' Descripci�n:        Procedimiento encargado de cargar los valores de Categorias
    Public Sub CargarCategorias()
        Try
            cmbCategoria.ValueMember = "CategoriaID"
            cmbCategoria.DisplayMember = "Nombre"
            DtCategoria = SivCategorias.RetrieveDT("Activa=1", " Nombre", "CategoriaID, Nombre")
            cmbCategoria.DataSource = DtCategoria
            cmbCategoria.Text = ""
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

       
    End Sub

    Private Sub CargarProveedor(ByVal strFiltro As String)
        'dtProveedor = New DataTable
        Dim sSQL As String

        Try
            sSQL = ObtenerConsultaGeneral("objProductosID, SivProveedorID, NombreProveedor", "vwSivProveedorProductos", strFiltro)

            Me.dtProveedor = DAL.SqlHelper.ExecuteQueryDT(sSQL)
            Me.grdProveedor.SetDataBinding(Me.dtProveedor, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarComboProveedor()
        dtProveedorCombo = New DataTable
        Try
            dtProveedorCombo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID,NombreProveedor", "vwProveedor_Producto", "1=1"))
            With CtdbProveedor
                .DataSource = Me.dtProveedorCombo
                .DisplayMember = "NombreProveedor"
                .ValueMember = "SivProveedorID"
                .DisplayColumns("SivProveedorID").Visible = False
                .ValueTranslate = True
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub CargarExistencia()
        dtExistenciaBodega = New DataTable
        Try
            dtExistenciaBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbBodegaID, Nombre, cast ('' as varchar(100)) as Ubicacion, cast ('' as integer) as Cantidad", "StbBodegas", "Activo=1 "))
            Me.grdBodegas.SetDataBinding(dtExistenciaBodega, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarExistenciaEditar()
        dtExistenciaBodega = New DataTable
        Try
            dtExistenciaBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbBodegaID, Nombre, Ubicacion, Cantidad, objProductoID", "vwExistenciaBodegas", "objProductoID = '" & Me.intProductoID & "'"))
            Me.grdBodegas.SetDataBinding(dtExistenciaBodega, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripci�n:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Producto"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False
                    Me.CargarProveedor("1=0")
                    Me.CargarComboProveedor()
                    Me.grdProveedor.Splits(0).DisplayColumns(2).Visible = False
                    Me.grdProveedor.EmptyRows = False
                    Me.grdProveedor.FilterBar = False
                    Me.grdProveedor.Refresh()

                    Me.CargarExistencia()
                    Me.grdBodegas.EmptyRows = False
                    Me.grdBodegas.FilterBar = False
                    Me.grdBodegas.Refresh()
                   
                Case 1
                    CargarDatosProducto()
                    chkActivo.Enabled = True
                    Me.CargarProveedor("objProductosID = '" & Me.intProductoID & "'")
                    Me.CargarComboProveedor()
                    Me.grdProveedor.Splits(0).DisplayColumns(1).Visible = False
                    Me.grdProveedor.EmptyRows = False
                    Me.grdProveedor.FilterBar = False
                    Me.grdProveedor.Refresh()
                  
                    CargarExistenciaEditar()
                    Me.grdBodegas.EmptyRows = False
                    Me.grdBodegas.FilterBar = False
                    Me.grdBodegas.Refresh()
                Case 2
                    CargarDatosProducto()
                    spnCantidadMinima.Enabled = False
                    spnCostoPromedio.Enabled = False
                    spnMargenContado.Enabled = False
                    spnMargenCredito.Enabled = False
                    spnPrecioContado.Enabled = False
                    spnPrecioCredito.Enabled = False
                    txtNombre.Enabled = False
                    txtProducto.Enabled = False
                    cmbMarca.Enabled = False
                    cmbCategoria.Enabled = False
                    chkActivo.Enabled = False
                    cmdGuardar.Enabled = False
                    Me.CargarComboProveedor()
                    Me.CargarExistenciaEditar()
                    'Formatea los grid para s�lo consulta
                    Me.FormatearGridConsulta()
            End Select
            txtProducto.Focus()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '' Descripci�n:        Procedimiento encargado de cargar la informacion de un producto
    Public Sub CargarDatosProducto()
        Dim objProducto As SivProductos
        Try
            objProducto = New SivProductos
            objProducto.Retrieve(ProductoID)
            txtProducto.Text = objProducto.Codigo
            txtNombre.Text = objProducto.Nombre
            cmbCategoria.SelectedValue = objProducto.objCategoriaID
            cmbMarca.SelectedValue = objProducto.objMarcaID
            chkActivo.Checked = objProducto.Activo
            spnCantidadMinima.Value = objProducto.Cantidad_Minima
            spnCostoPromedio.Value = IIf(IsDBNull(objProducto.CostoPromedio), 0.0, objProducto.CostoPromedio)
            spnMargenContado.Value = IIf(IsDBNull(objProducto.Margen_Utilidad_Contado), 0.0, objProducto.Margen_Utilidad_Contado)
            spnMargenCredito.Value = IIf(IsDBNull(objProducto.Margen_Utilidad_Credito), 0.0, objProducto.Margen_Utilidad_Credito)
            spnPrecioContado.Value = IIf(IsDBNull(objProducto.Precio_Contado), 0.0, objProducto.Precio_Contado)
            spnPrecioCredito.Value = IIf(IsDBNull(objProducto.Precio_Credito), 0.0, objProducto.Precio_Credito)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objProducto = Nothing
        End Try
    End Sub

    '' Descripci�n:        Procedimiento encargado de crear un nuevo registro de producto
    Public Sub GuardarProducto()
        Dim objProducto As SivProductos
        Dim objBodega As StbBodegas
        Dim objBodegaProductos As SivBodegaProductos
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objProducto = New SivProductos
            ProductoID = SivProductos.RetrieveDT(, , "ISNULL(MAX(SivProductoID),0)+1 AS ID").DefaultView.Item(0)("ID")
            objProducto.SivProductoID = ProductoID
            objProducto.Codigo = txtProducto.Text.Trim
            objProducto.Nombre = txtNombre.Text.Trim
            objProducto.objCategoriaID = cmbCategoria.SelectedValue
            objProducto.objMarcaID = cmbMarca.SelectedValue
            objProducto.Activo = chkActivo.Checked
            objProducto.Cantidad_Minima = spnCantidadMinima.Value
            objProducto.CostoPromedio = spnCostoPromedio.Value
            objProducto.Precio_Contado = spnPrecioContado.Value
            objProducto.Precio_Credito = spnPrecioCredito.Value
            objProducto.Margen_Utilidad_Credito = spnMargenCredito.Value
            objProducto.Margen_Utilidad_Contado = spnMargenContado.Value
            objProducto.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objProducto.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objProducto.Insert(T)

            If dtExistenciaBodega.Rows.Count > 0 Then
                Me.GuardarBodegaProductos(T)
            Else
                ''Insertar en Bodega Productos con cantidad 0
                objBodegaProductos = New SivBodegaProductos
                objBodega = New StbBodegas
                objBodega.RetrieveByFilter("Codigo='" & clsProyecto.Sucursal & "'")

            End If
          
            objBodegaProductos.objProductoID = ProductoID
            objBodegaProductos.objBodegaID = objBodega.StbBodegaID
            objBodegaProductos.Cantidad = 0
            objBodegaProductos.CantidadTransito = 0
            objBodegaProductos.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objBodegaProductos.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objBodegaProductos.Insert(T)

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objProducto = Nothing
        End Try
    End Sub

    '' Descripci�n:        Procedimiento encargado de editar la informacion de un producto
    Public Sub EditarProducto()
        Dim objProducto As SivProductos
        Dim dtDetalleProveedor, dtDetalleBodega As New DataTable
        Dim T As New DAL.TransactionManager
        Dim fila As DataRow
        Try
            T.BeginTran()
            objProducto = New SivProductos
            objProducto.SivProductoID = ProductoID
            objProducto.Codigo = txtProducto.Text.Trim
            objProducto.Nombre = txtNombre.Text.Trim
            objProducto.objCategoriaID = cmbCategoria.SelectedValue
            objProducto.objMarcaID = cmbMarca.SelectedValue
            objProducto.Activo = chkActivo.Checked
            objProducto.Cantidad_Minima = spnCantidadMinima.Value
            objProducto.CostoPromedio = spnCostoPromedio.Value
            objProducto.Precio_Contado = spnPrecioContado.Value
            objProducto.Precio_Credito = spnPrecioCredito.Value
            objProducto.Margen_Utilidad_Credito = spnMargenCredito.Value
            objProducto.Margen_Utilidad_Contado = spnMargenContado.Value
            objProducto.Activo = chkActivo.Checked
            objProducto.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objProducto.UsuarioModificacion = clsProyecto.Conexion.Servidor
            objProducto.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objProducto.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objProducto.Update(T)

            '--Actualizamos los proveedores
            dtDetalleProveedor = SivProductosDetProv.RetrieveDT("1=0")
            SivProductosDetProv.DeleteByFilter("objProductosID = '" & Me.intProductoID & "'", T)

            Me.dtProveedor.AcceptChanges()
            For Each row As DataRow In Me.dtProveedor.Rows
                fila = dtDetalleProveedor.NewRow
                fila("objProductosID") = Me.intProductoID
                fila("objProveedorID") = row("SivProveedorID")
                fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                dtDetalleProveedor.Rows.Add(fila)

            Next
            dtDetalleProveedor.TableName = "SivProductosDetProv"
            SivProductosDetProv.BatchUpdate(dtDetalleProveedor.DataSet, T)

            'dtDetalleBodega = SivBodegaRepuestos.RetrieveDT("1=0")
            'SivBodegaRepuestos.DeleteByFilter("objProductoID = '" & Me.intProductoID & "'")

            'Me.dtExistenciaBodega.AcceptChanges()
            'For Each drBodega As DataRow In Me.dtExistenciaBodega.Rows
            '    fila = dtDetalleBodega.NewRow
            '    fila("objProductoID") = Me.intProductoID
            '    fila("objBodegaID") = drBodega("StbBodegaID")
            '    fila("Ubicacion") = drBodega("Ubicacion")
            '    fila("Cantidad") = drBodega("Cantidad")
            '    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
            '    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
            '    dtDetalleBodega.Rows.Add(fila)
            'Next
            'dtDetalleBodega.TableName = "SivBodegaRepuestos"
            'SivBodegaRepuestos.BatchUpdate(dtDetalleBodega.DataSet, T)

            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objProducto = Nothing
        End Try
    End Sub

#End Region

#Region "Formatear Grids para consulta"
    Private Sub FormatearGridConsulta()
        'Grid de proveedores
        With Me.grdProveedor
            .Splits(0).DisplayColumns("SivProveedorID").Visible = False
            .Splits(0).DisplayColumns("CodigoRepuesto").Locked = True
            .Splits(0).DisplayColumns("SivProveedorID").Button = False
            .Splits(0).DisplayColumns("SivProveedorID").AutoDropDown = False
            '.Splits(0).DisplayColumns("NombreProveedor").Style.BackColor = Me.grdCompatibilidad.Splits(0).DisplayColumns("Modelo").Style.BackColor
            '.Splits(0).DisplayColumns("CodigoRepuesto").Style.BackColor = Me.grdCompatibilidad.Splits(0).DisplayColumns("Modelo").Style.BackColor
            '.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
            .EmptyRows = False
            .FilterBar = False
            .AllowDelete = False
            .AllowFilter = False
            .AllowSort = False
            .AllowUpdate = False
            .RecordSelectors = False
            .Refresh()
        End With

        'Grid Bedegas
        With Me.grdBodegas
            .Splits(0).DisplayColumns("Ubicacion").Locked = True
            '.Splits(0).DisplayColumns("Ubicacion").Style.BackColor = Me.grdCompatibilidad.Splits(0).DisplayColumns("Modelo").Style.BackColor
            .Splits(0).DisplayColumns("StbTiendaID").Visible = False
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
            .EmptyRows = False
            .FilterBar = False
            .AllowDelete = False
            .AllowFilter = False
            .AllowSort = False
            .AllowUpdate = False
            .RecordSelectors = False
            .Refresh()
        End With
    End Sub

    Private Sub GuardarBodegaProductos(ByVal T As DAL.TransactionManager)
        Dim fila As DataRow
        Dim dtDetalleBodega As New DataTable

        dtDetalleBodega = SivBodegaProductos.RetrieveDT("1=0")

        Me.dtExistenciaBodega.AcceptChanges()
        For Each drBodega As DataRow In Me.dtExistenciaBodega.Rows
            fila = dtDetalleBodega.NewRow
            fila("objProductoID") = Me.intProductoID
            fila("objBodegaID") = drBodega("StbBodegaID")
            fila("Ubicacion") = drBodega("Ubicacion")
            fila("Cantidad") = drBodega("Cantidad")
            fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
            fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
            dtDetalleBodega.Rows.Add(fila)
        Next
        dtDetalleBodega.TableName = "SivBodegaRepuestos"
        SivBodegaRepuestos.BatchUpdate(dtDetalleBodega.DataSet, T)

    End Sub

    Private Sub GuardarRepuestosProveedor(ByVal T As DAL.TransactionManager)
        Dim dtDetalleProveedor As New DataTable
        Dim fila As DataRow
        Try
            Try

                'Me.grdProveedor.Refresh()
                dtDetalleProveedor = SivProductosDetProv.RetrieveDT("1=0")

                
                Me.dtProveedor.AcceptChanges()
                For Each row As DataRow In Me.dtProveedor.Rows ' row As DataRow In Me.dtProveedor.Rows
                    fila = dtDetalleProveedor.NewRow
                    fila("objProductosID") = Me.intProductoID
                    fila("objProveedorID") = row("SivProveedorID") 'row("SivProveedorID")
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleProveedor.Rows.Add(fila)
                Next

                dtDetalleProveedor.TableName = "SivProductosDetProv"
                SivProductosDetProv.BatchUpdate(dtDetalleProveedor.DataSet, T)

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDetalleProveedor = Nothing
        End Try

    End Sub

#End Region

#Region "Funciones"
    '' Descripci�n:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Dim objProductosTemp As SivProductos
        Try
            objProductosTemp = New SivProductos
            If txtProducto.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtProducto, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
            If objProductosTemp.RetrieveByFilter("Codigo = '" & txtProducto.Text & "'") And TypeGui = 0 Then
                ErrorProv.SetError(txtProducto, "Codigo debe ser unico")
                Return False
                Exit Function
            End If
            If objProductosTemp.RetrieveByFilter("Codigo = '" & txtProducto.Text & "' AND SivProductoID <> " & Me.ProductoID) And TypeGui = 1 Then
                ErrorProv.SetError(txtProducto, "Codigo debe ser unico")
                Return False
                Exit Function
            End If
            'If cmbMarca.Text.Trim.Length = 0 Then
            '    ErrorProv.SetError(cmbMarca, My.Resources.MsgObligatorio)
            '    Return False
            '    Exit Function
            'End If
            'If cmbCategoria.Text.Trim.Length = 0 Then
            '    ErrorProv.SetError(cmbCategoria, My.Resources.MsgObligatorio)
            '    Return False
            '    Exit Function
            'End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objProductosTemp = Nothing
        End Try
    End Function
#End Region

#Region "Eventos del formulario"

    Private Sub frmSivProductosEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarMarca()
        CargarCategorias()
        ConfigurarGUI()

        Me.boolEditado = False
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 0
                    GuardarProducto()
                Case 1
                    EditarProducto()
            End Select
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub frmSivProductosEditar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub txtModelo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProducto.TextChanged
        ErrorProv.SetError(txtProducto, "")
        boolEditado = True
    End Sub

    Private Sub cbxMarca_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.SelectedIndexChanged, cmbMarca.TextChanged, cmbMarca.SelectedValueChanged
        ErrorProv.SetError(cmbMarca, "")
        boolEditado = True
    End Sub

    Private Sub cbxCilindraje_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategoria.TextChanged, cmbCategoria.SelectedValueChanged
        ErrorProv.SetError(cmbCategoria, "")
        boolEditado = True
    End Sub


    Private Sub txtModelo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProducto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtProducto.Text.Trim.Length <> 0 Then
                Me.txtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtNombre.Text.Trim.Length <> 0 Then
                Me.cmbCategoria.Focus()
            End If
        End If
    End Sub

    Private Sub cbxCilindraje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbCategoria.Text.Trim.Length <> 0 Then
                Me.cmbMarca.Focus()
            End If
        End If
    End Sub

    Private Sub cbxMarca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbMarca.Text.Trim.Length <> 0 Then
                Me.chkActivo.Focus()
            End If
        End If
    End Sub

    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.spnCostoPromedio.Focus()
        End If
    End Sub

    Private Sub spnCostoPromedio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spnCostoPromedio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.spnCostoPromedio.Text.Trim.Length <> 0 Then
                Me.spnPrecioCredito.Focus()
            End If
        End If
    End Sub

    Private Sub spnPrecioCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spnPrecioCredito.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.spnPrecioCredito.Text.Trim.Length <> 0 Then
                Me.spnPrecioContado.Focus()
            End If
        End If
    End Sub

    Private Sub spnPrecioContado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spnPrecioContado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.spnPrecioContado.Text.Trim.Length <> 0 Then
                Me.spnMargenCredito.Focus()
            End If
        End If
    End Sub

    Private Sub spnMargenCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spnMargenCredito.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.spnMargenCredito.Text.Trim.Length <> 0 Then
                Me.spnMargenContado.Focus()
            End If
        End If
    End Sub

    Private Sub spnMargenContado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spnMargenContado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.spnMargenContado.Text.Trim.Length <> 0 Then
                Me.spnCantidadMinima.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ErrorProv.SetError(txtNombre, "")
        boolEditado = True
    End Sub

    Private Sub grdProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles grdProveedor.KeyDown
        If Me.TypeGui <> 2 Then
            If e.KeyValue = Keys.Delete And Not (Me.grdProveedor.EditActive) Then
                Me.grdProveedor.Delete(Me.grdProveedor.Row)
                Me.grdProveedor.UpdateData()
            End If
        End If
    End Sub

    Private Sub grdProveedor_Leave(sender As Object, e As EventArgs) Handles grdProveedor.Leave
        Me.grdProveedor.UpdateData()
    End Sub

    Private Sub cmdAgregarCategoria_Click(sender As Object, e As EventArgs) Handles cmdAgregarCategoria.Click
        Dim addCategoria As frmSivCategoriasEditar
        Try

            addCategoria = New frmSivCategoriasEditar
            addCategoria.TypeGui = 0
            If addCategoria.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarCategorias()
                Me.cmbCategoria.SelectedValue = addCategoria.CategoriaID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            addCategoria = Nothing
        End Try
    End Sub

    Private Sub cmdAgregarMarca_Click(sender As Object, e As EventArgs) Handles cmdAgregarMarca.Click
        Dim editMarcas As frmMarcasEdit
        Try
            editMarcas = New frmMarcasEdit
            editMarcas.TypeGui = 0
            If editMarcas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarMarca()
                Me.cmbMarca.SelectedValue = editMarcas.MarcaID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            editMarcas = Nothing
        End Try
    End Sub

#End Region

End Class