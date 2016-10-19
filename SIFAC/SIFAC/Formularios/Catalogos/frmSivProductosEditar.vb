Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSivProductosEditar

#Region "Declaracion de Variables"
    Public DtMarca, DtCilindraje, DtSegmento As DataTable
    Public intTypeGui As Integer
    Public intProductoID As Integer
    Public boolEditado As Boolean
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

    '' Descripción:        Procedimiento encargado de cargar los valores de Marca
    Public Sub CargarMarca()
        Try
            DtMarca = SivMarcas.RetrieveDT("Activa=1")
            With cbxMarca
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
                .ColumnHeaders = False
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            DtMarca = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar los valores de Categorias
    Public Sub CargarCategorias()
        Try
            DtCilindraje = SivCategorias.RetrieveDT("Activa=1")
            With cbxCategoria
                .DataSource = DtCilindraje
                .DisplayMember = "Nombre"
                .ValueMember = "CategoriaID"
                .Splits(0).DisplayColumns("CategoriaID").Visible = False
                .Splits(0).DisplayColumns("Descripcion").Visible = False
                .Splits(0).DisplayColumns("Activa").Visible = False
                .Splits(0).DisplayColumns("FechaCreacion").Visible = False
                .Splits(0).DisplayColumns("UsuarioCreacion").Visible = False
                .Splits(0).DisplayColumns("FechaModificacion").Visible = False
                .Splits(0).DisplayColumns("UsuarioModificacion").Visible = False
                .ColumnHeaders = False
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Producto"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False
                Case 1
                    CargarDatosProducto()
                    chkActivo.Enabled = True
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
                    cbxMarca.Enabled = False
                    cbxCategoria.Enabled = False
                    chkActivo.Enabled = False
                    cmdGuardar.Enabled = False
            End Select
            txtProducto.Focus()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '' Descripción:        Procedimiento encargado de cargar la informacion de un producto
    Public Sub CargarDatosProducto()
        Dim objProducto As SivProductos
        Try
            objProducto = New SivProductos
            objProducto.Retrieve(ProductoID)
            txtProducto.Text = objProducto.Codigo
            txtNombre.Text = objProducto.Nombre
            cbxCategoria.SelectedValue = objProducto.objCategoriaID
            cbxMarca.SelectedValue = objProducto.objMarcaID
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

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de producto
    Public Sub GuardarProducto()
        Dim objProducto As SivProductos
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objProducto = New SivProductos
            ProductoID = SivProductos.RetrieveDT(, , "ISNULL(MAX(SivProductoID),0)+1 AS ID").DefaultView.Item(0)("ID")
            objProducto.SivProductoID = ProductoID
            objProducto.Codigo = txtProducto.Text.Trim
            objProducto.Nombre = txtNombre.Text.Trim
            objProducto.objCategoriaID = cbxCategoria.SelectedValue
            objProducto.objMarcaID = cbxMarca.SelectedValue
            objProducto.Activo = chkActivo.Checked
            objProducto.Cantidad_Minima = spnCantidadMinima.Value
            objProducto.CostoPromedio = spnCostoPromedio.Value
            objProducto.Precio_Contado = spnPrecioContado.Value
            objProducto.Precio_Credito = spnPrecioCredito.Value
            objProducto.Margen_Utilidad_Credito = spnMargenCredito.Value
            objProducto.Margen_Utilidad_Contado = spnMargenContado.Value
            objProducto.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objProducto.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objProducto.Insert()
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

    '' Descripción:        Procedimiento encargado de editar la informacion de un producto
    Public Sub EditarProducto()
        Dim objProducto As SivProductos
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objProducto = New SivProductos
            objProducto.SivProductoID = ProductoID
            objProducto.Codigo = txtProducto.Text.Trim
            objProducto.Nombre = txtNombre.Text.Trim
            objProducto.objCategoriaID = cbxCategoria.SelectedValue
            objProducto.objMarcaID = cbxMarca.SelectedValue
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
            objProducto.Update()
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

#Region "Funciones"
    '' Descripción:        Funcion encargada de validar la entrada del usuario
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
            If cbxMarca.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cbxMarca, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
            If cbxCategoria.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cbxCategoria, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

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

    Private Sub cbxMarca_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMarca.Change
        ErrorProv.SetError(cbxMarca, "")
        boolEditado = True
    End Sub

    Private Sub cbxCilindraje_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCategoria.Change
        ErrorProv.SetError(cbxCategoria, "")
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
                Me.cbxCategoria.Focus()
            End If
        End If
    End Sub

    Private Sub cbxCilindraje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxCategoria.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cbxCategoria.Text.Trim.Length <> 0 Then
                Me.cbxMarca.Focus()
            End If
        End If
    End Sub

    Private Sub cbxMarca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxMarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cbxMarca.Text.Trim.Length <> 0 Then
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

#End Region

End Class