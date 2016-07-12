Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SCCUM.BO
Imports SCCUM.BO.clsConsultas
Imports Proyecto.Catalogos.Datos.ClsCatalogos

Public Class frmSrhEmpleadoEditar

#Region "Variables del formualario"
    Public DtPersona, DtCargo As DataTable
    Public boolEditado As Boolean
    Public intEmpleadoID, intTypeGUI As Integer
    Public strPersonaID As String
#End Region

#Region "Propiedades"
    Public Property EmpleadoID() As Integer
        Get
            Return intEmpleadoID
        End Get
        Set(ByVal value As Integer)
            intEmpleadoID = value
        End Set
    End Property

    Public Property PersonaID() As String
        Get
            Return strPersonaID
        End Get
        Set(ByVal value As String)
            strPersonaID = value
        End Set
    End Property

    Public Property TypeGUI() As Integer
        Get
            Return intTypeGUI
        End Get
        Set(ByVal value As Integer)
            intTypeGUI = value
        End Set
    End Property

#End Region

#Region "Procedimientos"
    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de cargar la informacion de personas con clasificacion empleado que aun no han sido ingresadas en empleado
    Public Sub CargarPersona()
        Dim strFiltro As String = ""
        Select Case TypeGUI
            Case 0
                strFiltro = "Descripcion = 'Empleado' AND StbPersonaID NOT IN (SELECT objPersonaID FROM SrhEmpleado)"
            Case 1, 2
                strFiltro = "StbPersonaID = '" & PersonaID & "'"
        End Select
        DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero", "vwPersonaClasificacion", strFiltro))
    End Sub

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de cargar la informacion de los cargos disponibles
    Public Sub CargarCargo()
        DtCargo = ObtenerValCat("CARGOS")
        With cmbCargo
            .DataSource = DtCargo
            .DisplayMember = "Descripcion"
            .ValueMember = "StbValorCatalogoID"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .Splits(0).DisplayColumns("Codigo").Visible = False
            .Splits(0).DisplayColumns("Activo").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de vincular los controles al origen de datos
    Public Sub VincularControles()
        Try
            Me.txtPersonaID.DataBindings.Clear()
            Me.txtNombre1.DataBindings.Clear()
            Me.txtNombre2.DataBindings.Clear()
            Me.txtCedula.DataBindings.Clear()
            Me.txtApellido1.DataBindings.Clear()
            Me.txtApellido2.DataBindings.Clear()
            Me.txtGenero.DataBindings.Clear()

            Me.txtPersonaID.DataBindings.Add("text", DtPersona, "NombreCompleto", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtNombre1.DataBindings.Add("text", DtPersona, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtNombre2.DataBindings.Add("text", DtPersona, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtCedula.DataBindings.Add("text", DtPersona, "Cedula", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtApellido1.DataBindings.Add("text", DtPersona, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtApellido2.DataBindings.Add("text", DtPersona, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtGenero.DataBindings.Add("text", DtPersona, "Genero", False, DataSourceUpdateMode.OnPropertyChanged)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de configurar los controles segun el modo del formulario
    Public Sub ConfigurarGUI()
        Select Case TypeGUI
            Case 0
                Me.chkActivo.Checked = True
                Me.chkActivo.Enabled = False
                Me.dtpFechaEgreso.Enabled = False
                Me.DtPersona.DefaultView.RowFilter = "1=0"
            Case 1
                Me.chkActivo.Enabled = True
                Me.dtpFechaEgreso.Enabled = True
                Me.cmdBuscar.Enabled = False
                CargarDatosEdicion()
                Me.cmdEditarInfo.Enabled = True
            Case 2
                Me.chkActivo.Enabled = False
                Me.cmdBuscar.Enabled = False
                Me.cmbCargo.Enabled = False
                Me.dtpFechaIngreso.Enabled = False
                Me.dtpFechaEgreso.Enabled = False
                Me.cmdAceptar.Enabled = False
                CargarDatosEdicion()
        End Select
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de crear un empleado
    Public Sub AgregarEmpleado()
        Dim objEmpleado As SrhEmpleado
        objEmpleado = New SrhEmpleado
        Try
            Try
                objEmpleado.objPersonaID = PersonaID
                objEmpleado.objCargoID = cmbCargo.SelectedValue
                objEmpleado.FechaIngreso = dtpFechaIngreso.Value
                objEmpleado.Activo = chkActivo.Checked
                If Me.spnComision.EditValue.ToString.Trim.Length <> 0 Then
                    objEmpleado.PorcentajeComision = Me.spnComision.EditValue
                End If
                objEmpleado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEmpleado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEmpleado.Insert()
                EmpleadoID = objEmpleado.SrhEmpleadoID
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.boolEditado = False
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objEmpleado = Nothing
        End Try
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de editar la informacion de un empleado
    Public Sub EditarEmpleado()
        Dim objEmpleado As SrhEmpleado
        Dim objCuenta As New SsgCuenta
        objEmpleado = New SrhEmpleado
        Try
            Try
                objEmpleado.SrhEmpleadoID = EmpleadoID
                objEmpleado.objPersonaID = PersonaID
                objEmpleado.objCargoID = cmbCargo.SelectedValue

                If chkActivo.Checked = False Then
                    objEmpleado.FechaEgreso = dtpFechaEgreso.Value
                    If objCuenta.RetrieveByFilter("objEmpleadoID = " & EmpleadoID) Then
                        objCuenta.Activo = False
                        objCuenta.Update()
                    End If
                Else
                    chkActivo.Checked = True
                    objEmpleado.FechaEgreso = Nothing
                    If objCuenta.RetrieveByFilter("objEmpleadoID = " & EmpleadoID) Then
                        objCuenta.Activo = True
                        objCuenta.Update()
                    End If
                End If
                objEmpleado.FechaIngreso = dtpFechaIngreso.Value
                objEmpleado.Activo = chkActivo.Checked
                If Me.spnComision.EditValue.ToString.Trim.Length <> 0 Then
                    objEmpleado.PorcentajeComision = Me.spnComision.EditValue
                End If
                objEmpleado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEmpleado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEmpleado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objEmpleado.Update()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.boolEditado = False
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objEmpleado = Nothing
            objCuenta = Nothing
        End Try
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de cargar la informacion de un empleado existente
    Public Sub CargarDatosEdicion()
        Try
            Dim objEmpleado As SrhEmpleado
            objEmpleado = New SrhEmpleado
            objEmpleado.Retrieve(EmpleadoID)
            Me.cmbCargo.SelectedValue = objEmpleado.objCargoID
            Me.chkActivo.Checked = objEmpleado.Activo
            Me.dtpFechaIngreso.Value = objEmpleado.FechaIngreso
            Me.spnComision.EditValue = objEmpleado.PorcentajeComision
            If objEmpleado.FechaEgreso.HasValue Then
                Me.dtpFechaEgreso.Value = objEmpleado.FechaEgreso
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Funciones"

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Select Case TypeGUI
            Case 0
                If txtPersonaID.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(cmdBuscar, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
                If cmbCargo.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(cmbCargo, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
                If dtpFechaIngreso.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(dtpFechaIngreso, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
                If dtpFechaIngreso.Value > clsProyecto.Conexion.FechaServidor Then
                    ErrorProv.SetError(dtpFechaIngreso, "La fecha de ingreso no puede ser mayor que la fecha actual")
                    Return False
                    Exit Function
                End If

            Case 1
                If cmbCargo.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(cmbCargo, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If dtpFechaEgreso.Text.Trim.Length = 0 Then
                    Return True
                    Exit Function
                End If
                If dtpFechaEgreso.Value > clsProyecto.Conexion.FechaServidor Then
                    ErrorProv.SetError(dtpFechaEgreso, "La fecha de egreso no puede ser mayor que la fecha actual")
                    Return False
                    Exit Function
                End If
                If dtpFechaEgreso.Value < dtpFechaIngreso.Value Then
                    ErrorProv.SetError(dtpFechaEgreso, "La fecha de egreso debe ser mayor a la fecha de ingreso")
                    Return False
                    Exit Function
                End If
        End Select
        Return True
    End Function

#End Region

#Region "Eventos del formualario"


    Private Sub frmSrhEmpleadoEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarPersona()
        VincularControles()
        CargarCargo()
        ConfigurarGUI()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim objSeleccion As frmPersonaSelector
        objSeleccion = New frmPersonaSelector
        objSeleccion.Filtro = " Descripcion = 'Empleado' AND StbPersonaID NOT IN (SELECT objPersonaID FROM SrhEmpleado)"
        objSeleccion.Opcion = 3
        If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.PersonaID = objSeleccion.Seleccion
            CargarPersona()
            VincularControles()
            Me.DtPersona.DefaultView.RowFilter = "StbPersonaID = '" & PersonaID & "'"
            ErrorProv.SetError(cmdBuscar, "")
        End If
    End Sub

    Private Sub cmbCargo_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCargo.Change
        Me.boolEditado = True
        Me.ErrorProv.SetError(cmbCargo, "")
        Dim dtCargo As New DataTable
        dtCargo = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("StbValorCatalogoID", "Nombre = 'CARGOS' AND Codigo ='09'"))

        If Me.cmbCargo.SelectedValue = dtCargo.DefaultView.Item(0)("StbValorCatalogoID") Then
            Me.spnComision.Enabled = True
            Me.spnComision.EditValue = 0.0
        Else
            Me.spnComision.EditValue = 0.0
            Me.spnComision.Enabled = False
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If ValidarEntrada() Then
            Select Case TypeGUI
                Case 0
                    AgregarEmpleado()
                Case 1
                    EditarEmpleado()
            End Select
        End If
    End Sub

    Private Sub dtpFechaIngreso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIngreso.TextChanged
        Me.boolEditado = True
        Me.ErrorProv.SetError(dtpFechaIngreso, "")
    End Sub

    Private Sub dtpFechaEgreso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEgreso.TextChanged
        Me.boolEditado = True
        Me.ErrorProv.SetError(dtpFechaEgreso, "")
    End Sub

    Private Sub frmSrhEmpleadoEditar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado And Me.TypeGUI <> 2 Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

#End Region

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim objPersonas As frmStbPersonasEditar
        Try

        If Me.txtPersonaID.Text <> "" Then
                objPersonas = New frmStbPersonasEditar
                objPersonas.idpersona = Trim(Me.txtCedula.Text)
                objPersonas.frmLlamado = 3
                objPersonas.TyGui = 3
                objPersonas.ShowDialog(Me)
            End If
        Finally
            objPersonas = Nothing
        End Try
    End Sub

    Private Sub chkActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivo.CheckedChanged

        Select Case Me.chkActivo.Checked
            Case False
                If Me.TypeGUI = 1 Then
                    Me.dtpFechaEgreso.Value = Nothing
                    Me.dtpFechaEgreso.Enabled = True
                End If
            Case True
                If Me.TypeGUI = 1 Then
                    Me.dtpFechaEgreso.Value = Nothing
                    Me.dtpFechaEgreso.Enabled = False
                End If
        End Select
    End Sub

    Private Sub cmdEditarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarInfo.Click
        Dim objPersonas As frmStbPersonasEditar
        Try

            If Me.txtPersonaID.Text <> "" Then
                objPersonas = New frmStbPersonasEditar
                objPersonas.idpersona = Trim(Me.txtCedula.Text)
                objPersonas.frmLlamado = 3
                objPersonas.TyGui = 2
                If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarPersona()
                    Me.VincularControles()
                    Me.CargarDatosEdicion()
                End If
            End If
        Finally
            objPersonas = Nothing
        End Try

    End Sub

    Private Sub spnComision_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.boolEditado = True
        Me.ErrorProv.Clear()
    End Sub
End Class