Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmStbEditTiendas

#Region "Declaración de Variables propias del formulario"
    Dim DtCiudad, DtJefe As DataTable ' DataTable usados para los combos
    Public Shared DtContactos As DataTable ' DataTable  que mantiene el registro de los contactos de la tienda
    Dim objSeg As SsgSeguridad
    Dim strDireccion, strTelefono, strFax, strMovil As String 'variables que me almacenan la concatenación de los tipos de contactos para una tienda
    Dim fechaServidor As Date
    Dim boolEditado As Boolean = False
#End Region

#Region "Propiedades"
    Dim intTypeGUI, intTiendaID As Integer


    Public Property TypeGUI() As Integer
        Get
            Return intTypeGUI
        End Get
        Set(ByVal value As Integer)
            intTypeGUI = value
        End Set
    End Property

    Public Property TiendaID() As Integer
        Get
            Return intTiendaID
        End Get
        Set(ByVal value As Integer)
            intTiendaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Carga de Datos"

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de cargar combo de ciudad de tienda
    Public Sub CargarCiudad()
        Try
            DtCiudad = StbCiudad.RetrieveDT("", "", "StbCiudadID,Nombre")
            With cmbCiudad
                .DataSource = DtCiudad
                .DisplayMember = "Nombre"
                .ValueMember = "StbCiudadID"
                .Splits(0).DisplayColumns("StbCiudadID").Visible = False
                .ColumnHeaders = False
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarJefe()
        Try
            DtJefe = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))
            With cmbJefe
                .DataSource = DtJefe
                .DisplayMember = "NombreCompleto"
                .ValueMember = "SrhEmpleadoID"
                .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
                .Splits(0).DisplayColumns("objPersonaID").Visible = False
                .ColumnHeaders = False
                .ExtendRightColumn = True
                .SelectedValue = -1               
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de cargar los contactos de la tienda
    Public Sub CargarContactos()
        Dim strFiltro As String = "1=1"
        Select Case Me.TypeGUI
            Case 1
                strFiltro = "1=0"
            Case 2, 3
                strFiltro = "StbTiendaID='" & Convert.ToString(TiendaID) & "'"
        End Select
        Try
            frmStbEditTiendas.DtContactos = SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbTiendaID,SecuencialContacto,objTipoEntradaID,Descripcion,Valor", "vwStbTiendaContactos", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de mostrar los datos de una tienda en modo de edición
    Public Sub CargarDatosTienda()
        Dim objTienda As StbTienda
        Try
            objTienda = New StbTienda
            objTienda.Retrieve(TiendaID)
            txtNombre.Text = objTienda.Nombre
            If Not String.IsNullOrEmpty(objTienda.Codigo) Then
                txtCodigo.Text = objTienda.Codigo
            End If
            cmbCiudad.SelectedValue = objTienda.objCiudadID
            cmbJefe.SelectedValue = objTienda.objJefeTiendaID

            If objTienda.Activo.HasValue Then
                chkActivo.Checked = objTienda.Activo
            End If
            If objTienda.ActivoRepuesto.HasValue Then
                chkActivoRepuesto.Checked = objTienda.ActivoRepuesto
            End If
            If objTienda.ProximaFactura.HasValue Then
                Me.NumProximoNoFactura.Value = objTienda.ProximaFactura
            End If
            If Not String.IsNullOrEmpty(objTienda.seriefactura) Then
                Me.txtSerieFactura.Text = objTienda.seriefactura
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objTienda = Nothing
        End Try
    End Sub

#End Region

#Region "Nuevo Jefe"
    Public Sub NuevoJefe()
        Dim editEmpleado As frmSrhEmpleadoEditar
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 0
            If editEmpleado.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarJefe()
                cmbJefe.SelectedValue = editEmpleado.intEmpleadoID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#Region "Consutar jefe"
    Public Sub ConsultarJefe()
        Dim editEmpleado As frmSrhEmpleadoEditar
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 2
            editEmpleado.EmpleadoID = Me.cmbJefe.Columns("SrhEmpleadoID").Value
            editEmpleado.PersonaID = Me.cmbJefe.Columns("objPersonaID").Value
            editEmpleado.Text = "Consultar Empleado"
            editEmpleado.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado para mostrar agrupado los tipos de contacto de una tienda
    Public Sub MostrarContactos()
        strDireccion = ""
        strTelefono = ""
        strFax = ""
        strMovil = ""

        For Each dr As DataRow In frmStbEditTiendas.DtContactos.Rows
            If dr("objTipoEntradaID") = 1 Or dr("objTipoEntradaID") = 2 Then
                strTelefono &= dr("Valor") & " / "
            End If
            If dr("objTipoEntradaID") = 3 Then
                strMovil &= dr("Valor") & " / "
            End If
            If dr("objTipoEntradaID") = 4 Or dr("objTipoEntradaID") = 5 Then
                strFax &= dr("Valor") & " / "
            End If

            If dr("objTipoEntradaID") = 14 Then
                strDireccion &= dr("Valor") & " / "
            End If
        Next
        If strTelefono.Length > 0 Then
            strTelefono = strTelefono.Substring(0, strTelefono.Length - 3)
        End If
        If strMovil.Length > 0 Then
            strMovil = strMovil.Substring(0, strMovil.Length - 3)
        End If
        If strFax.Length > 0 Then
            strFax = strFax.Substring(0, strFax.Length - 3)
        End If
        If strDireccion.Length > 0 Then
            strDireccion = strDireccion.Substring(0, strDireccion.Length - 3)
        End If
        Me.grdContactos.Rows.Count = 1
        Me.grdContactos.ExtendLastCol = True
        Me.grdContactos.Rows.Add()
        Me.grdContactos.Item(Me.grdContactos.Rows.Count - 1, 0) = "Dirección"
        Me.grdContactos.Item(Me.grdContactos.Rows.Count - 1, 1) = strDireccion
        Me.grdContactos.Rows.Add()
        Me.grdContactos.Item(Me.grdContactos.Rows.Count - 1, 0) = "Teléfonos"
        Me.grdContactos.Item(Me.grdContactos.Rows.Count - 1, 1) = strTelefono
        Me.grdContactos.Rows.Add()
        Me.grdContactos.Item(Me.grdContactos.Rows.Count - 1, 0) = "Faxes"
        Me.grdContactos.Item(Me.grdContactos.Rows.Count - 1, 1) = strFax
        Me.grdContactos.Rows.Add()
        Me.grdContactos.Item(Me.grdContactos.Rows.Count - 1, 0) = "Móviles"
        Me.grdContactos.Item(Me.grdContactos.Rows.Count - 1, 1) = strMovil
        Me.grdContactos.ScrollBars = ScrollBars.Horizontal
        Me.grdContactos.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.ErrorProv.SetError(Me.GroupBox2, "")
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Select Case TypeGUI
            Case 1
                Me.Text = "Nueva Sucursal"
                Me.chkActivo.Enabled = False
                Me.chkActivo.Checked = True
            Case 2
                Me.Text = "Editar Sucursal"
                Me.chkActivo.Enabled = True
                Me.CargarDatosTienda()
            Case 3
                Me.Text = "Consultar Sucursal"
                Me.CargarDatosTienda()
                Me.txtNombre.Enabled = False
                Me.txtCodigo.Enabled = False
                Me.cmbCiudad.Enabled = False
                Me.cmbJefe.Enabled = False
                Me.cmdJefe.Enabled = False
                Me.chkActivo.Enabled = False
                Me.chkActivoRepuesto.Enabled = False
                Me.NumProximoNoFactura.Enabled = False
                Me.txtSerieFactura.Enabled = False
                Me.cmdTienda.Enabled = False
                Me.cmdAceptar.Enabled = False
        End Select
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de configurar la longitud maxima de los controles de entrada de texto
    Public Sub EstablecerPropiedades()
        txtNombre.MaxLength = StbTienda.GetMaxLength("Nombre")
        txtCodigo.MaxLength = StbTienda.GetMaxLength("Codigo")
        Me.txtSerieFactura.MaxLength = StbTienda.GetMaxLength("seriefactura")
    End Sub


#Region "Guardar Tienda"

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub GuardarTienda()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearTienda(T)
            GuardarContactosTienda(T)
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
    '' Fecha de creación:  26/02/2009
    '' Modificado por: Gelmin Martínez, 29 Junio 2010, 05:01 pm: Se agregó campos "ActivoRepuesto", "ProximaFactura, Serie"
    '' Descripción:        Procedimiento encargado de guardar los datos de una tienda
    Public Sub CrearTienda(ByVal T As DAL.TransactionManager)
        Dim objTienda As StbTienda
        Try
            objTienda = New StbTienda
            TiendaID = StbTienda.RetrieveDT(, , "ISNULL(MAX(StbTiendaID),0)+1 AS ID").DefaultView.Item(0)("ID")
            objTienda.StbTiendaID = TiendaID
            objTienda.Nombre = txtNombre.Text.Trim
            objTienda.Codigo = txtCodigo.Text.Trim
            objTienda.objCiudadID = cmbCiudad.SelectedValue
            objTienda.objJefeTiendaID = cmbJefe.SelectedValue
            objTienda.Activo = chkActivo.Checked

            objTienda.ActivoRepuesto = Me.chkActivoRepuesto.Checked
            If Not IsDBNull(Me.NumProximoNoFactura.Value) AndAlso Me.NumProximoNoFactura.Value.ToString.Trim.Length <> 0 Then
                objTienda.ProximaFactura = Me.NumProximoNoFactura.Value
            End If
            If Not String.IsNullOrEmpty(Me.txtSerieFactura.Text) Then
                objTienda.seriefactura = Me.txtSerieFactura.Text.Trim
            End If
            objTienda.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objTienda.FechaCreacion = fechaServidor
            objTienda.Insert(T)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de guardar los contactos de una tienda
    Public Sub GuardarContactosTienda(ByVal T As DAL.TransactionManager)
        Dim objTiendaContactos As StbTiendaContactos
        Try
            For Each dr As DataRow In frmStbEditTiendas.DtContactos.Rows
                objTiendaContactos = New StbTiendaContactos
                objTiendaContactos.objTiendaID = TiendaID
                objTiendaContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objTiendaContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objTiendaContactos.Valor = dr("Valor").ToString
                objTiendaContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objTiendaContactos.FechaCreacion = fechaServidor
                objTiendaContactos.Insert(T)
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Tienda"

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de actualizar tienda
    Public Sub ActualizarTienda()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosTienda(T)
            ModificarContactosTienda(T)
            GuardarContactosTienda(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de modificar los datos de una tienda
    Public Sub ModificarDatosTienda(ByVal T As DAL.TransactionManager)
        Dim objTienda As StbTienda
        Try
            objTienda = New StbTienda
            objTienda.StbTiendaID = TiendaID
            objTienda.Nombre = txtNombre.Text.Trim
            objTienda.Codigo = txtCodigo.Text.Trim
            objTienda.objCiudadID = cmbCiudad.SelectedValue
            objTienda.objJefeTiendaID = cmbJefe.SelectedValue
            objTienda.Activo = chkActivo.Checked
            objTienda.ActivoRepuesto = Me.chkActivoRepuesto.Checked
            If Not IsDBNull(Me.NumProximoNoFactura.Value) AndAlso Me.NumProximoNoFactura.Value.ToString.Trim.Length <> 0 Then
                objTienda.ProximaFactura = Integer.Parse(Me.NumProximoNoFactura.Value)
            End If
            If Not String.IsNullOrEmpty(Me.txtSerieFactura.Text) Then
                objTienda.seriefactura = Me.txtSerieFactura.Text.Trim
            End If

            objTienda.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objTienda.FechaCreacion = fechaServidor
            objTienda.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objTienda.FechaModificacion = fechaServidor
            objTienda.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de modificar los datos de contacto de tienda
    Public Sub ModificarContactosTienda(ByVal T As DAL.TransactionManager)
        Try
            StbTiendaContactos.DeleteByFilter("objTiendaID = " & Convert.ToString(TiendaID), T)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        If txtNombre.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtNombre, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If txtCodigo.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtCodigo, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If cmbCiudad.Text.Trim.Length = 0 Then
            ErrorProv.SetError(cmbCiudad, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If cmbJefe.Text.Trim = "" Then
            ErrorProv.SetError(cmbJefe, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If Me.strDireccion.Trim.Length = 0 Or (strTelefono.Trim.Length = 0 And strMovil.Length = 0) Then
            ErrorProv.SetError(Me.GroupBox2, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        Return True
    End Function
#End Region

#End Region

#Region "Eventos del formulario"

    Private Sub frmStbEditTiendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.grdContactos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        CargarCiudad()
        CargarJefe()
        CargarContactos()
        MostrarContactos()
        EstablecerPropiedades()
        ConfigurarGUI()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdTienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTienda.Click
        Dim objTiendaContactos As frmStbTiendaContactos
        objTiendaContactos = New frmStbTiendaContactos
        objTiendaContactos.TiendaID = 0
        objTiendaContactos.ShowDialog(Me)
        If objTiendaContactos.Visible = False Then
            MostrarContactos()
            If strDireccion.Trim.Length <> 0 Or strTelefono.Trim.Length <> 0 Or strMovil.Trim.Length <> 0 Or strFax.Trim.Length <> 0 Then
                boolEditado = True
            End If
        End If

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If ValidarEntrada() Then
            Select Case TypeGUI
                Case 1
                    GuardarTienda()
                Case 2
                    ActualizarTienda()
            End Select
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, NumProximoNoFactura.TextChanged, txtSerieFactura.TextChanged, txtCodigo.TextChanged
        ErrorProv.Clear()
        boolEditado = True
    End Sub

    Private Sub cmdJefe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdJefe.Click
        Try
            If cmbJefe.SelectedText = "" Then
                Me.NuevoJefe()
            Else
                Me.ConsultarJefe()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmbCiudad_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCiudad.Change
        ErrorProv.SetError(cmbCiudad, "")
        boolEditado = True
    End Sub

    Private Sub cmbJefe_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJefe.Change
        ErrorProv.SetError(cmbJefe, "")
        boolEditado = True
    End Sub

    Private Sub frmStbEditTiendas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

#End Region

#Region "KeyPress controles"
    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtNombre.Text.Trim.Length <> 0 Then
                Me.txtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtCodigo.Text.Trim.Length <> 0 Then
                Me.cmbCiudad.Focus()
            End If
        End If
    End Sub

    Private Sub cmbCiudad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCiudad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbCiudad.Text.Trim.Length <> 0 Then
                Me.cmbJefe.Focus()
            End If
        End If
    End Sub

    Private Sub NumProximoNoFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumProximoNoFactura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.NumProximoNoFactura.Text.Trim.Length <> 0 Then
                Me.txtSerieFactura.Focus()
            End If
        End If
    End Sub

    Private Sub cmbJefe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbJefe.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbJefe.Text.Trim.Length <> 0 Then
                Me.NumProximoNoFactura.Focus()
            End If
        End If
    End Sub

    Private Sub txtSerieFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerieFactura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtSerieFactura.Text.Trim.Length <> 0 Then
                Me.chkActivo.Focus()
            End If
        End If
    End Sub
#End Region


End Class