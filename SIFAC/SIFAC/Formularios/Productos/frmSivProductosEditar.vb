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

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  07/03/2009
    '' Descripción:        Procedimiento encargado de cargar los valores de Marca
    Public Sub CargarMarca()
        DtMarca = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "vwStbMarcas", " Activo = 1"))
        With cbxMarca
            .DataSource = DtMarca
            .DisplayMember = "Descripcion"
            .ValueMember = "StbValorCatalogoID"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  07/03/2009
    '' Descripción:        Procedimiento encargado de cargar los valores de cilindraje
    Public Sub CargarCilindraje()
        DtCilindraje = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "vwStbCilindrajes", " Activo = 1"))
        With cbxCilindraje
            .DataSource = DtCilindraje
            .DisplayMember = "Descripcion"
            .ValueMember = "StbValorCatalogoID"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  07/03/2009
    '' Descripción:        Procedimiento encargado de guardar los datos de una tienda
    Public Sub CargarSegmento()
        DtSegmento = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "vwStbSegmentos", " Activo = 1"))
        With cbxSegmento
            .DataSource = DtSegmento
            .DisplayMember = "Descripcion"
            .ValueMember = "StbValorCatalogoID"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  07/03/2009
    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
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
                txtModelo.Enabled = False
                cbxMarca.Enabled = False
                cbxCilindraje.Enabled = False
                cbxSegmento.Enabled = False
                chkActivo.Enabled = False
                cmdAceptar.Enabled = False
        End Select
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  09/03/2009
    '' Descripción:        Procedimiento encargado de cargar la informacion de un producto
    Public Sub CargarDatosProducto()
        Dim objProducto As SivProductos
        objProducto = New SivProductos
        objProducto.Retrieve(ProductoID)
        'txtModelo.Text = objProducto.Modelo
        'cbxMarca.SelectedValue = objProducto.objMarcaID
        'cbxCilindraje.SelectedValue = objProducto.objCilindrajeID
        'cbxSegmento.SelectedValue = objProducto.objSegmentoID
        chkActivo.Checked = objProducto.Activo
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  07/03/2009
    '' Descripción:        Procedimiento encargado de crear un nuevo registro de producto
    Public Sub GuardarProducto()
        Dim objProducto As SivProductos
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objProducto = New SivProductos
            ProductoID = SivProductos.RetrieveDT(, , "ISNULL(MAX(SivProductoID),0)+1 AS ID").DefaultView.Item(0)("ID")
            objProducto.SivProductoID = ProductoID
            'objProducto.Modelo = txtModelo.Text.Trim
            objProducto.objMarcaID = cbxMarca.SelectedValue
            'objProducto.objCilindrajeID = cbxCilindraje.SelectedValue
            'objProducto.objSegmentoID = cbxSegmento.SelectedValue
            objProducto.Activo = chkActivo.Checked
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
        End Try
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  09/03/2009
    '' Descripción:        Procedimiento encargado de editar la informacion de un producto
    Public Sub EditarProducto()
        Dim objProducto As SivProductos
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objProducto = New SivProductos
            objProducto.SivProductoID = ProductoID
            'objProducto.Modelo = txtModelo.Text.Trim
            objProducto.objMarcaID = cbxMarca.SelectedValue
            'objProducto.objCilindrajeID = cbxCilindraje.SelectedValue
            'objProducto.objSegmentoID = cbxSegmento.SelectedValue
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
        End Try
    End Sub

#End Region

#Region "Funciones"

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  09/03/2009
    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Dim objProductosTemp As SivProductos
        objProductosTemp = New SivProductos
        If txtModelo.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtModelo, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If objProductosTemp.RetrieveByFilter("Modelo = '" & txtModelo.Text & "'") And TypeGui = 0 Then
            ErrorProv.SetError(txtModelo, "Modelo debe ser unico")
            Return False
            Exit Function
        End If
        If objProductosTemp.RetrieveByFilter("Modelo = '" & txtModelo.Text & "' AND SivProductoID <> " & Me.ProductoID) And TypeGui = 1 Then
            ErrorProv.SetError(txtModelo, "Modelo debe ser unico")
            Return False
            Exit Function
        End If
        If cbxMarca.Text.Trim.Length = 0 Then
            ErrorProv.SetError(cbxMarca, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If cbxCilindraje.Text.Trim.Length = 0 Then
            ErrorProv.SetError(cbxCilindraje, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If cbxSegmento.Text.Trim.Length = 0 Then
            ErrorProv.SetError(cbxSegmento, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        Return True
    End Function
#End Region

#Region "Eventos del formulario"
    Private Sub frmSivProductosEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarMarca()
        CargarCilindraje()
        CargarSegmento()
        ConfigurarGUI()
        Me.boolEditado = False
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
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

    Private Sub txtModelo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModelo.TextChanged
        ErrorProv.SetError(txtModelo, "")
        boolEditado = True
    End Sub

    Private Sub cbxMarca_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMarca.Change
        ErrorProv.SetError(cbxMarca, "")
        boolEditado = True
    End Sub

    Private Sub cbxCilindraje_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCilindraje.Change
        ErrorProv.SetError(cbxCilindraje, "")
        boolEditado = True
    End Sub

    Private Sub cbxSegmento_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxSegmento.Change
        ErrorProv.SetError(cbxSegmento, "")
        boolEditado = True
    End Sub

#End Region
  
    Private Sub txtModelo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModelo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtModelo.Text.Trim.Length <> 0 Then
                Me.cbxMarca.Focus()
            End If
        End If
    End Sub

    Private Sub cbxMarca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxMarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cbxMarca.Text.Trim.Length <> 0 Then
                Me.cbxCilindraje.Focus()
            End If
        End If
    End Sub

    Private Sub cbxCilindraje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxCilindraje.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cbxCilindraje.Text.Trim.Length <> 0 Then
                Me.cbxSegmento.Focus()
            End If
        End If
    End Sub

    Private Sub cbxSegmento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxSegmento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbxSegmento.Text.Trim.Length <> 0 Then
                Me.cmdAceptar_Click(sender, e)
            End If
        End If
    End Sub
End Class