Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports Seguridad.Datos
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmSivEncargosEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intEncargoID As Integer
    Public boolEditado, boolRegistrada, boolExisteErroresGrid As Boolean
    Public DtMarca, DtCategoria, DtNombreProducto, dtCliente, dtVendedor, dtExpediente, dtDetalleEncargo As DataTable
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
        If cmbCategoria.Text.Trim.Length = 0 Or cmbCategoria.EditValue = "0" Then
            ErrorFactura.SetError(cmbCategoria, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If cmbMarca.Text.Trim.Length = 0 Or cmbMarca.EditValue = "0" Then
            ErrorFactura.SetError(cmbMarca, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If (chkNoExistente.Checked) Then
            If txtNombreProducto.Text.Trim.Length = 0 Then
                ErrorFactura.SetError(txtNombreProducto, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
        Else
            If cmbNombreProducto.Text.Trim.Length = 0 Or cmbNombreProducto.EditValue = "0" Then
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
            DtNombreProducto = SivProductos.RetrieveDT("Activo=1 AND objCategoriaID='" + CategoriaID.ToString() + "' AND objMarcaID='" + MarcaID.ToString() + "'", " Nombre", " (Codigo  + '-' +  Nombre) AS Nombre")
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

#End Region

#Region "Cargar Datos"

#Region "Cargar Datos del Cliente"

    Private Sub CargarDatosCliente()
        Dim dtDatosCliente As New DataTable
        Try
            Try
                If Not String.IsNullOrEmpty(Me.cmbCliente.Text) Then
                    dtDatosCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID, NombreCompleto, Direccion, Email, TelefonoParticular,TelefonoTrabajo, Celular,Ruta", "vwSivClienteEncargos", "ClienteID = '" & Me.cmbCliente.SelectedValue & "'"))

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

                    If IsDBNull(dtDatosCliente.DefaultView.Item(0)("Ruta")) Then
                        Me.txtRuta.Text = ""
                    Else
                        Me.txtRuta.Text = dtDatosCliente.DefaultView.Item(0)("Ruta")
                    End If

                    If Me.cmbCliente.Text.Trim.Length <> 0 Then
                        Me.txtCodigoCliente.Text = Me.cmbCliente.SelectedValue
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
            Me.CargarClientes()
            Me.CargarVendedor()

            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Entrada"
                    Me.cmbVendedor.SelectedValue = SsgCuenta.RetrieveDT("Login = '" & clsProyecto.Conexion.Usuario & "'", "", "objEmpleadoID").DefaultView.Item(0)("objEmpleadoID")
                    Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                    Me.CargarDetalleEncargos("1=0")
                    Me.txtObservaciones.Properties.MaxLength = SivEncargosDetalle.GetMaxLength("observaciones")

                    '    chkActivo.Checked = True
                    '    chkActivo.Enabled = False
                    'Case 1
                    '    CargarDatosProducto()
                    '    chkActivo.Enabled = True
                    'Case 2
                    '    CargarDatosProducto()
                    '    spnCantidadMinima.Enabled = False
                    '    spnCostoPromedio.Enabled = False
                    '    spnMargenContado.Enabled = False
                    '    spnMargenCredito.Enabled = False
                    '    spnPrecioContado.Enabled = False
                    '    spnPrecioCredito.Enabled = False
                    '    txtNombre.Enabled = False
                    '    txtProducto.Enabled = False
                    '    cbxMarca.Enabled = False
                    '    cbxCategoria.Enabled = False
                    '    chkActivo.Enabled = False
                    '    cmdGuardar.Enabled = False
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
            dtDetalleEncargo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, Producto, Cantidad, Observaciones, CostoPromedio, objSivEncargoID,SivProductoID", "vwSivDetalleProductosEncargos", strFiltro))
            Me.grdDetalleEncargos.DataSource = dtDetalleEncargo
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub AgregarProductos()
        Dim filas As DataRow
        Dim ProductoID As Integer
        Try
            filas = dtDetalleEncargo.NewRow
            ProductoID = cmbNombreProducto.EditValue

            filas("Codigo") = SivProductos.RetrieveDT("SivProductoID=" + ProductoID).Rows(0)("CostoPromedio")

            If chkNoExistente.Checked Then
                filas("Producto") = txtNombreProducto.Text
                filas("SivProductoID") = "0"
            Else
                filas("Producto") = cmbNombreProducto.Text
                filas("SivProductoID") = ProductoID
            End If

            filas("Cantidad") = spnCantidad.Value
            filas("Observaciones") = txtObservaciones.Text
            filas("CostoPromedio") = SivProductos.RetrieveDT("SivProductoID=" + ProductoID).Rows(0)("Codigo")

            dtDetalleEncargo.Rows.Add(filas)
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

    Private Sub cmdCliente_Click(sender As Object, e As EventArgs) Handles cmdCliente.Click
        Dim objBusquedaCliente As New frmSfaBusquedaCliente
        Dim objPersonaID As String
        Try
            Try
                objBusquedaCliente.Filtro = "Descripcion = 'Cliente'" 'AND StbPersonaID NOT IN (SELECT objFiadorID FROM vwSccCuentaFiador WHERE Estado = 'VIGENTE') "
                If objBusquedaCliente.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    objPersonaID = objBusquedaCliente.Seleccion
                    Me.CargarClientes()
                    Me.cmbCliente.SelectedValue = objPersonaID
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objBusquedaCliente = Nothing
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

    Private Sub chkNoExistente_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoExistente.CheckedChanged
        Try
            If chkNoExistente.Checked Then
                txtNombreProducto.Text = String.Empty
                txtNombreProducto.Visible = True
                cmbNombreProducto.Visible = False
                cmbNombreProducto.EditValue = "0"
            Else
                txtNombreProducto.Text = String.Empty
                txtNombreProducto.Visible = False
                cmbNombreProducto.Visible = True
                cmbNombreProducto.EditValue = "0"
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

#End Region






  
End Class