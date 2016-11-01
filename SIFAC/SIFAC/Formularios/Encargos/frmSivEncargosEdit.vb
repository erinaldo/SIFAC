Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports Seguridad.Datos
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports Proyecto.Catalogos.Datos.ClsCatalogos

Public Class frmSivEncargosEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intEncargoID As Integer
    Public boolEditado, boolRegistrada, boolExisteErroresGrid As Boolean
    Public DtMarca, DtCategoria, DtNombreProducto, dtCliente, dtVendedor, dtExpediente, dtDetalleEncargo, dtRutas, dtEstados As DataTable
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

        'If cmbMarca.Text.Trim.Length = 0 Or cmbMarca.EditValue = "0" Then
        '    ErrorFactura.SetError(cmbMarca, My.Resources.MsgObligatorio)
        '    Return False
        '    Exit Function
        'End If

        If (chkNoExistente.Checked) Then
            If cmbCategoria.Text.Trim.Length = 0 Or cmbCategoria.SelectedValue = "0" Then
                ErrorFactura.SetError(cmbCategoria, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If txtNombreProducto.Text.Trim.Length = 0 Then
                ErrorFactura.SetError(txtNombreProducto, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
        Else
            If cmbNombreProducto.Text.Trim.Length = 0 Or cmbNombreProducto.SelectedValue = "0" Then
                ErrorFactura.SetError(cmbNombreProducto, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
        End If

        If spnCantidad.Text.Trim.Length = 0 Or spnCantidad.Value = "0" Then
            ErrorFactura.SetError(spnCantidad, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        'Buscar el pdoducto en la lista'
        If dtDetalleEncargo.Rows.Count > 0 Then
            Dim foundRows() As Data.DataRow
            foundRows = dtDetalleEncargo.Select("SivProductoID = " & cmbNombreProducto.SelectedValue)

            If foundRows.Length > 0 Then
                MsgBox("El producto seleccionado ya existe en la lista del pedido.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Return False
                Exit Function
            End If
        End If

        Return True
    End Function

    Public Function ValidarEntrada() As Boolean
        If cmbCliente.Text.Trim.Length = 0 Or cmbCliente.SelectedValue = "0" Then
            ErrorFactura.SetError(cmbCategoria, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If dtDetalleEncargo.Rows.Count = 0 Then
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
            If Me.dtDetalleEncargo.Rows.Count <> 0 Then
                Me.dtDetalleEncargo.Rows.RemoveAt(Me.grdDetalleEncargosTabla.FocusedRowHandle) 'Borra la fila del datatable directo
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Eliminar Fila"
    Private Sub EliminarFila()
        If MsgBox("¿Seguro que desea eliminar la fila seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes Then
            Try
                Me.dtDetalleEncargo.Rows.RemoveAt(Me.grdDetalleEncargosTabla.FocusedRowHandle) 'Borra la fila del datatable directo
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
            Valor = Me.grdDetalleEncargosTabla.Columns("Producto").View.GetRowCellValue(Me.grdDetalleEncargosTabla.FocusedRowHandle, "Producto")
            blnRetorno = Not Me.TieneValor(Valor)
        Catch ex As Exception
            blnRetorno = False
        End Try
        Return blnRetorno
    End Function
#End Region

#Region "Guardar Encargo"
    Private Sub Guardar()
        Dim objEncargoMaster As SivEncargos
        Dim objEncargoDetalle As SivEncargosDetalle
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objEncargoMaster = New SivEncargos
            objEncargoDetalle = New SivEncargosDetalle

            objEncargoMaster.objRutaID = cmbRuta.SelectedValue
            objEncargoMaster.objSccClienteID = cmbCliente.SelectedValue
            objEncargoMaster.objSrhEmpleadoID = cmbVendedor.SelectedValue
            objEncargoMaster.ObjEstadoID = cboEstado.SelectedValue
            objEncargoMaster.Activo = True
            objEncargoMaster.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objEncargoMaster.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objEncargoMaster.Insert(T)

            ''Guadar Detalle de Encargos
            For Each row As DataRow In dtDetalleEncargo.Rows
                objEncargoDetalle.objSivEncargoID = objEncargoMaster.SivEncargoID

                If row("objCategoriaID") <> 0 Then
                    objEncargoDetalle.objCategoriaID = row("objCategoriaID")
                End If

                If Not IsDBNull(row("SivProductoID")) Then
                    objEncargoDetalle.objProductoID = row("SivProductoID")
                End If

                objEncargoDetalle.Nombre_Producto = row("Producto")
                objEncargoDetalle.Cantidad = row("Cantidad")
                objEncargoDetalle.Observaciones = row("Observaciones")
                objEncargoDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEncargoDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEncargoDetalle.Insert(T)
            Next
            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objEncargoMaster = Nothing
            objEncargoDetalle = Nothing
        End Try

    End Sub

    Private Sub Actualizar()
        Dim objEncargoMaster As SivEncargos
        Dim objEncargoDetalle As SivEncargosDetalle
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objEncargoMaster = New SivEncargos
            objEncargoDetalle = New SivEncargosDetalle

            objEncargoMaster.Retrieve(EncargoID)

            objEncargoMaster.objRutaID = cmbRuta.SelectedValue
            objEncargoMaster.objSccClienteID = cmbCliente.SelectedValue
            objEncargoMaster.objSrhEmpleadoID = cmbVendedor.SelectedValue
            objEncargoMaster.ObjEstadoID = cboEstado.SelectedValue
            objEncargoMaster.Activo = True

            objEncargoMaster.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objEncargoMaster.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objEncargoMaster.Update(T)

            'Eliminar Detalle'
            SivEncargosDetalle.DeleteByFilter("objSivEncargoID=" & EncargoID, T)

            ''Guadar Detalle de Encargos
            For Each row As DataRow In dtDetalleEncargo.Rows
                objEncargoDetalle.objSivEncargoID = objEncargoMaster.SivEncargoID

                If row("objCategoriaID") <> 0 Then
                    objEncargoDetalle.objCategoriaID = row("objCategoriaID")
                End If

                If Not IsDBNull(row("SivProductoID")) Then
                    objEncargoDetalle.objProductoID = row("SivProductoID")
                End If

                objEncargoDetalle.Nombre_Producto = row("Producto")
                objEncargoDetalle.Cantidad = row("Cantidad")
                objEncargoDetalle.Observaciones = row("Observaciones")
                objEncargoDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEncargoDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEncargoDetalle.Insert(T)
            Next

            T.CommitTran()

            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objEncargoMaster = Nothing
            objEncargoDetalle = Nothing
        End Try
    End Sub
#End Region

#Region "Controles"
    Private Sub DeshabilitarControles()
        Try
            cmbCliente.Enabled = False
            cmdCliente.Enabled = False
            cmdAgregarCliente.Enabled = False
            cmbVendedor.Enabled = False
            cboEstado.Enabled = False
            cmdAgregar.Enabled = False
            chkNoExistente.Enabled = False
            cmbCategoria.Enabled = False
            cmbMarca.Enabled = False
            cmbNombreProducto.Enabled = False
            txtNombreProducto.Enabled = False
            spnCantidad.Enabled = False
            txtObservaciones.Enabled = False
            txtCodigoCliente.Enabled = False
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

#End Region

#Region "Cargar Categorias"

    '' Descripción:        Procedimiento encargado de cargar los valores de Categorias
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


#End Region

#Region "Cargar Productos"

    Public Sub CargarProductos(CategoriaID As Integer, MarcaID As Integer)
        Dim strfiltro As String
        Try
            If (cmbCategoria.Text.Trim.Length = 0 Or cmbCategoria.SelectedValue = "0") And (cmbMarca.Text.Trim.Length <> 0 And cmbMarca.SelectedValue <> "0") Then
                strfiltro = "Activo=1  AND objMarcaID=" & MarcaID.ToString()
            Else
                If (cmbCategoria.Text.Trim.Length <> 0 And cmbCategoria.SelectedValue <> "0") And (cmbMarca.Text.Trim.Length = 0 Or cmbMarca.SelectedValue = "0") Then
                    strfiltro = "Activo=1  AND objCategoriaID=" & CategoriaID.ToString()
                Else
                    If (cmbCategoria.Text.Trim.Length <> 0 And cmbCategoria.SelectedValue <> "0") And (cmbMarca.Text.Trim.Length <> 0 And cmbMarca.SelectedValue <> "0") Then
                        strfiltro = "Activo=1 AND objCategoriaID=" & CategoriaID.ToString() & " AND objMarcaID=" & MarcaID.ToString()
                    Else
                        strfiltro = "1=1"
                    End If
                End If
            End If
           
            cmbNombreProducto.ValueMember = "SivProductoID"
            cmbNombreProducto.DisplayMember = "Nombre"
            DtNombreProducto = SivProductos.RetrieveDT(strfiltro, " Nombre", " SivProductoID, (Codigo  + '-' +  Nombre) AS Nombre")

            cmbNombreProducto.DataSource = DtNombreProducto
            cmbNombreProducto.Text = ""
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Clientes"
    Private Sub CargarClientes()
        Try
            dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("ClienteID,NombreCompleto", "vwSfaClienteFactura", "Descripcion = 'Cliente'"))
            dtCliente.DefaultView.Sort = "NombreCompleto"
            With Me.cmbCliente
                .DataSource = dtCliente
                .ValueMember = "ClienteID"
                .DisplayMember = "NombreCompleto"
                .Splits(0).DisplayColumns("ClienteID").Visible = False
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Vendedores"
    Private Sub CargarVendedor()
        dtVendedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("NombreVendedor, SrhEmpleadoID ", "vwSfaVendedorFactura", "1=1"))
        With Me.cmbVendedor
            .DataSource = Me.dtVendedor
            .ValueMember = "SrhEmpleadoID"
            .DisplayMember = "NombreVendedor"
            .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
            .ExtendRightColumn = True
        End With

    End Sub
#End Region

#Region "Cargar Estados"
    Public Sub CargarEstados()
        Try
            dtEstados = ObtenerValCat("ESTADOENCARGO")
            With cboEstado
                .DataSource = dtEstados
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                 .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar rutas"
    Private Sub CargarRuta()
        Dim objRuta As StbRutas
        Try
            objRuta = New StbRutas
            'Rutas
            dtRutas = StbRutas.RetrieveDT("1=1", "", "StbRutaID,Nombre")
            Me.cmbRuta.DataSource = dtRutas
            Me.cmbRuta.DisplayMember = "Nombre"
            Me.cmbRuta.ValueMember = "StbRutaID"
            Me.cmbRuta.Splits(0).DisplayColumns("StbRutaID").Visible = False
            Me.cmbRuta.ExtendRightColumn = True
            Me.cmbRuta.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRuta = Nothing

        End Try
    End Sub

#End Region

#End Region

#Region "Cargar Datos"

#Region "Cargar Datos del Cliente"

    Private Sub CargarDatosCliente()
        Dim dtDatosCliente As New DataTable
        Try
            Try
                If Not String.IsNullOrEmpty(Me.cmbCliente.Text) Then
                    dtDatosCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,Cedula, NombreCompleto, Direccion, Email, TelefonoParticular,TelefonoTrabajo, Celular,StbRutaID", "vwSivClienteEncargos", "ClienteID = '" & Me.cmbCliente.SelectedValue & "'"))

                    If IsDBNull(dtDatosCliente.DefaultView.Item(0)("TelefonoParticular")) Then
                        If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("TelefonoTrabajo")) Then
                            Me.txtTelefono.Text = "Trab: " & dtDatosCliente.DefaultView.Item(0)("TelefonoTrabajo")
                        Else
                            Me.txtTelefono.Text = ""
                        End If
                    ElseIf Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("TelefonoTrabajo")) Then
                        Me.txtTelefono.Text = "Part: " & dtDatosCliente.DefaultView.Item(0)("TelefonoParticular") & " Trab: " & dtDatosCliente.DefaultView.Item(0)("TelefonoTrabajo")
                    Else
                        Me.txtTelefono.Text = "Part: " & dtDatosCliente.DefaultView.Item(0)("TelefonoParticular")
                    End If

                    If IsDBNull(dtDatosCliente.DefaultView.Item(0)("Direccion")) Then
                        Me.txtDireccion.Text = ""
                    Else
                        Me.txtDireccion.Text = dtDatosCliente.DefaultView.Item(0)("Direccion")
                    End If

                    If IsDBNull(dtDatosCliente.DefaultView.Item(0)("StbRutaID")) Then
                        Me.cmbRuta.Text = ""
                    Else
                        Me.cmbRuta.SelectedValue = dtDatosCliente.DefaultView.Item(0)("StbRutaID")
                    End If

                    If Me.cmbCliente.Text.Trim.Length <> 0 Then
                        Me.txtCodigoCliente.Text = dtDatosCliente.DefaultView.Item(0)("Cedula")
                    End If
                Else
                    Me.txtDireccion.Text = ""
                    Me.txtTelefono.Text = ""

                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatosCliente = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar Expedientes"

    Private Sub CargarExpedientes()
        dtExpediente = New DataTable
        Try
            Try
                If Not String.IsNullOrEmpty(Me.cmbCliente.Text) Then
                    dtExpediente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objClienteID, SccCuentaID, objSivProductoID, ModeloMarca, Saldo", "vwSfaExpedienteCliente", "objClienteID ='" & Me.cmbCliente.SelectedValue) & "'")
                Else
                    dtExpediente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objClienteID, SccCuentaID, objSivProductoID, ModeloMarca, Saldo", "vwSfaExpedienteCliente", "1=0"))
                End If

                Me.grdvwExpediente.DataSource = dtExpediente

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtExpediente = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar Datos Encargo"

    Private Sub CargarDatosEncargo()
        Dim objEncargoMaster As SivEncargos
        Dim objEncargoDetalle As SivEncargosDetalle
        Try
            objEncargoMaster = New SivEncargos
            objEncargoDetalle = New SivEncargosDetalle

            objEncargoMaster.Retrieve(EncargoID)
            cmbCliente.SelectedValue = objEncargoMaster.objSccClienteID
            cboEstado.SelectedValue = objEncargoMaster.ObjEstadoID
            cmbVendedor.SelectedValue = objEncargoMaster.objSrhEmpleadoID
            cmbRuta.SelectedValue = objEncargoMaster.objRutaID
            dtpFecha.Value = objEncargoMaster.FechaCreacion
            ''Cargar Detalle del encargo
            CargarDetalleEncargos("objSivEncargoID=" & EncargoID)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Consultar Clientes"

    Private Sub CargarConsultaCliente()
        Dim objPers As frmClientesEdit
        Try
            Try
                objPers = New frmClientesEdit
                If Me.cmbCliente.Text.Trim.Length <> 0 Then
                    objPers.TyGui = 3
                    objPers.idpersona = Me.cmbCliente.SelectedValue
                    objPers.ShowDialog(Me)
                Else
                    objPers.TyGui = 1
                    If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.CargarClientes()
                        Me.cmbCliente.SelectedValue = objPers.idpersona
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
            Me.CargarClientes()
            Me.CargarVendedor()
            CargarRuta()
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Encargo"
                    Me.cmbVendedor.SelectedValue = SsgCuenta.RetrieveDT("Login = '" & clsProyecto.Conexion.Usuario & "'", "", "objEmpleadoID").DefaultView.Item(0)("objEmpleadoID")
                    Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                    Me.CargarDetalleEncargos("1=0")
                    Me.txtObservaciones.Properties.MaxLength = SivEncargosDetalle.GetMaxLength("Observaciones")
                    Me.cboEstado.Text = "REGISTRADO"
                    Me.cboEstado.Enabled = False

                Case 1
                    Me.Text = "Editar Encargo"
                    Me.cboEstado.Enabled = True
                    CargarDatosEncargo()

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
    Private Sub CargarDetalleEncargos(ByVal strFiltro As String)
        dtDetalleEncargo = New DataTable
        Try
            dtDetalleEncargo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, Producto, Cantidad, Observaciones, CostoPromedio, objSivEncargoID,SivProductoID,objCategoriaID", "vwSivDetalleProductosEncargos", strFiltro))
            Me.grdDetalleEncargos.DataSource = dtDetalleEncargo
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AgregarProductos()
        Dim filas As DataRow
        Dim ProductoID As Integer
        Dim objSivProducto As SivProductos
        Try
            filas = dtDetalleEncargo.NewRow
            ProductoID = cmbNombreProducto.SelectedValue
            objSivProducto = New SivProductos

            objSivProducto.Retrieve(ProductoID)

            filas("Codigo") = objSivProducto.Codigo

            If chkNoExistente.Checked Then
                filas("Producto") = txtNombreProducto.Text
                filas("SivProductoID") = "0"
            Else
                filas("Producto") = cmbNombreProducto.Text
                filas("SivProductoID") = ProductoID
            End If

            filas("Cantidad") = spnCantidad.Value
            filas("Observaciones") = txtObservaciones.Text
            filas("CostoPromedio") = objSivProducto.CostoPromedio

            If cmbCategoria.Text = "" Then
                filas("objCategoriaID") = 0
            Else
                filas("objCategoriaID") = cmbCategoria.SelectedValue
            End If

            dtDetalleEncargo.Rows.Add(filas)

            ''Limpiar Controles
            cmbCategoria.Text = String.Empty
            cmbNombreProducto.Text = String.Empty
            txtNombreProducto.Text = String.Empty
            txtObservaciones.Text = String.Empty
            spnCantidad.Value = 0.0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region


#End Region

#Region "Eventos del Formulario"

    Private Sub frmSivEncargosEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub cmbCategoria_EditValueChanged(sender As Object, e As EventArgs)
        Try
            CargarProductos(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbCategoria_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedValueChanged
        Try
            CargarProductos(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue))

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub cmdCliente_Click(sender As Object, e As EventArgs) Handles cmdCliente.Click
        Dim objBusquedaCliente As New frmPersonaSelector
        Dim objClienteID As Integer
        Dim objPersonaID As Integer
        Dim objCliente As New SccClientes
        Try
            Try
                objBusquedaCliente.Filtro = "Descripcion = 'Cliente'" 'AND StbPersonaID NOT IN (SELECT objFiadorID FROM vwSccCuentaFiador WHERE Estado = 'VIGENTE') "
                If objBusquedaCliente.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    objPersonaID = objBusquedaCliente.Seleccion
                    objCliente.RetrieveByFilter("objPersonaID=" & objPersonaID)
                    objClienteID = objCliente.ClienteID
                    Me.CargarClientes()
                    Me.cmbCliente.SelectedValue = objClienteID
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objBusquedaCliente = Nothing
            objCliente = Nothing
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        If Me.boolRegistrada Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cmbCliente_TextChanged(sender As Object, e As EventArgs) Handles cmbCliente.TextChanged
        CargarDatosCliente()
        CargarExpedientes()
        Me.ErrorFactura.SetError(Me.cmbCliente, "")
    End Sub

    Private Sub cmdAgregarCliente_Click(sender As Object, e As EventArgs) Handles cmdAgregarCliente.Click
        Me.CargarConsultaCliente()
    End Sub

    Private Sub chkNoExistente_CheckedChanged(sender As Object, e As EventArgs)
        Try
            If chkNoExistente.Checked Then
                txtNombreProducto.Text = String.Empty
                txtNombreProducto.Visible = True
                cmbNombreProducto.Visible = False
                cmbNombreProducto.SelectedValue = "0"
            Else
                txtNombreProducto.Text = String.Empty
                txtNombreProducto.Visible = False
                cmbNombreProducto.Visible = True
                cmbNombreProducto.SelectedValue = "0"
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If ValidarEntradaDetalle() Then
            AgregarProductos()
        End If
    End Sub

    Private Sub grdDetalleEncargosTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles grdDetalleEncargosTabla.KeyDown
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

    Private Sub cmbCategoria_TextChanged(sender As Object, e As EventArgs)
        ErrorFactura.SetError(cmbCategoria, "")
        boolEditado = True
    End Sub

    Private Sub cmbMarca_TextChanged(sender As Object, e As EventArgs)
        ErrorFactura.SetError(cmbMarca, "")
        boolEditado = True
    End Sub

    Private Sub cmbNombreProducto_TextChanged(sender As Object, e As EventArgs)
        ErrorFactura.SetError(cmbNombreProducto, "")
        boolEditado = True
    End Sub

    Private Sub spnCantidad_TextChanged(sender As Object, e As EventArgs)
        ErrorFactura.SetError(spnCantidad, "")
        boolEditado = True
    End Sub

    Private Sub txtNombreProducto_TextChanged(sender As Object, e As EventArgs)
        ErrorFactura.SetError(txtNombreProducto, "")
        boolEditado = True
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

    Private Sub cmbNombreProducto_Enter(sender As Object, e As EventArgs) Handles cmbNombreProducto.Enter
        CargarProductos(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue))
    End Sub

    Private Sub cmbNombreProducto_TextChanged_2(sender As Object, e As EventArgs) Handles cmbNombreProducto.TextChanged
        ErrorFactura.SetError(cmbNombreProducto, "")
        boolEditado = True
    End Sub
#End Region




   
   
End Class