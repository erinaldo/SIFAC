Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports SIFAC.BO

Public Class frmSsgEditCuenta

#Region "Declaracion de Variables locales a la Clase del formulario frmSsgEditAccion"
    'Declaracion de Variables 
    Dim mCuentaID As Long
    Dim blnModifico As Boolean
    Dim mNombreCuenta As String
    Dim objCuenta As SsgCuenta
    Dim CuentaDt As DataTable
    Dim RolesAplicacionDt As DataTable
    Dim dtEmpleados As DataTable
#End Region

#Region "Propiedades"
    Public Property CuentaID() As Long
        Get
            CuentaID = mCuentaID
        End Get
        Set(ByVal value As Long)
            mCuentaID = value
        End Set
    End Property

    Public Property NombreCuenta() As String
        Get
            Return mNombreCuenta
        End Get
        Set(ByVal value As String)
            mNombreCuenta = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"

    Private Sub frmSsgEditCuenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.cdeFechaExpiracion.Dispose()
    End Sub

    Private Sub frmSsgEditCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EstablecerPropiedades()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '--------------------------------------------------------------------------------
    '-- Descripcion             :   Configura propiedades al form y ciertos controles
    '---------------------------------------------------------------------------------
    Private Sub EstablecerPropiedades()
        Try
            '--- Instanciar ---
            objCuenta = New SsgCuenta

            Me.lblNombreEmp.Text = ""
            Me.lblCedula.Text = ""
            Me.lblFechaInicioEmp.Text = ""
            Me.lblFechaFinEmp.Text = ""

            CargarEmpleados()
            CargarRolesxAplicacion()

            If CuentaID = 0 Then
                Me.Text = "Agregar Cuenta"
                Me.cdeFechaCreacion.Value = Today
            Else
                Me.Text = "Modificar Cuenta"
                Me.chkActivo.Enabled = True
                CargarDatosUsuario()
            End If
            '--- Establecer tamaño máximo de los campos
            Me.txtLogin.MaxLength = 10
            Me.txtPassword.MaxLength = SsgCuenta.GetMaxLength("Clave")
            Me.txtConfirmacion.MaxLength = SsgCuenta.GetMaxLength("Clave")

            '--- Obtener la Estructura de la tabla SsgCuenta
            CuentaDt = SsgCuentaRol.RetrieveDT("1=2")
            blnModifico = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos de los Botones Acepar-Cancelar"

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If blnModifico Then
                SalvarCuentaUsuario()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            If blnModifico Then
                Select Case MsgBox("¿Desea guardar los cambios ?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)
                    Case MsgBoxResult.Yes
                        SalvarCuentaUsuario()
                    Case MsgBoxResult.No
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Case MsgBoxResult.Cancel
                End Select
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Metodos Para la Edición de una Cuenta"

    Private Sub CargarEmpleados()
        Try
            dtEmpleados = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto as Nombre ,objPersonaID", "vwSrhEmpleado", "Activo =1"))

            'dtEmpleados = SrhEmpleado.RetrieveDT(, "Nombre", "SrhEmpleadoID,  NombreCompleto as Nombre")
            dtEmpleados.PrimaryKey = New DataColumn() {Me.dtEmpleados.Columns("SrhEmpleadoID")}
            dtEmpleados.DefaultView.Sort = "SrhEmpleadoID"
            Me.cboEmpleado.DataSource = dtEmpleados
            Me.cboEmpleado.DisplayMember = "Nombre"
            Me.cboEmpleado.ValueMember = "SrhEmpleadoID"
            Me.dtEmpleados.DefaultView.Sort = "Nombre"

            '--- Formatear combo
            '-----------------
            Me.cboEmpleado.Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
            'Me.cboEmpleado.Splits(0).DisplayColumns("Activo").Visible = False
            'Me.cboEmpleado.Splits(0).DisplayColumns("FechaIngreso").Visible = False
            'Me.cboEmpleado.Splits(0).DisplayColumns("FechaEgreso").Visible = False
            '-----------------
            Me.cboEmpleado.Splits(0).DisplayColumns("Nombre").Width = Me.cboEmpleado.Width - 10
            '-----------------
        Catch ex As Exception
            Throw
        End Try
    End Sub

    '-------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   12 de Septiembre del 2007
    '-- Descripcion         :   Cargar los datos del Usuario seleccionado.
    '------------------------------------------------------------------------------
    Private Sub CargarDatosUsuario()
        Try
            objCuenta.Retrieve(CuentaID)

            If Not objCuenta.Login Is Nothing Then
                Me.txtLogin.Text = objCuenta.Login
            End If

            If Not objCuenta.Clave Is Nothing Then
                Me.txtPassword.Text = clsProyecto.DesencriptaOfHex(objCuenta.Clave)
                Me.txtConfirmacion.Text = clsProyecto.DesencriptaOfHex(objCuenta.Clave)
            End If

            If Not IsDBNull(objCuenta.FechaCreacion) Then
                Me.cdeFechaCreacion.Value = Format(objCuenta.FechaCreacion, "dd-MM-yyyy")
            End If

            '-- Validación para evitar valores Nulos de la Fecha de Expiración
            If objCuenta.FechaExpiracion.HasValue Then
                Me.cdeFechaExpiracion.Value = Format(objCuenta.FechaExpiracion, "dd-MM-yyyy")
            Else
                Me.cdeFechaExpiracion.ValueIsDbNull = True
            End If

            If objCuenta.Activo = True Then
                Me.chkActivo.Checked = True
            Else
                Me.chkActivo.Checked = False
            End If

            '--- Sí la cuenta está asociada a un empleado, Cargar datos empleado
            If objCuenta.objEmpleadoID.HasValue Then
                Me.cboEmpleado.SelectedValue = objCuenta.objEmpleadoID
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   12 de Septiembre del 2007
    '-- Descripcion         :   Cargar la lista de Roles x Aplicación
    '------------------------------------------------------------------------
    Private Sub CargarRolesxAplicacion()
        Try
            If CuentaID = 0 Then
                RolesAplicacionDt = SsgCuenta.ObtenerRoles(CuentaID)
                Me.grdRoles.DataSource = RolesAplicacionDt
            Else
                RolesAplicacionDt = SsgCuenta.ObtenerRoles(CuentaID)
                Me.grdRoles.DataSource = RolesAplicacionDt
            End If

            '--- Formatear el Grid
            Me.grdRoles.Splits(0).DisplayColumns("SsgRolID").Visible = False
            Me.grdRoles.Splits(0).DisplayColumns("SsgAplicacionID").Visible = False
            Me.grdRoles.Splits(0).DisplayColumns("Marcado").Width = 50
            Me.grdRoles.Columns("Marcado").Caption = ""

            Me.grdRoles.Columns("NombreRol").Tag = "BLOQUEADO"
            Me.grdRoles.Columns("NombreAplicacion").Tag = "BLOQUEADO"

            Me.grdRoles.Columns("NombreRol").Caption = "Rol"
            Me.grdRoles.Columns("NombreAplicacion").Caption = "Aplicacion"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '-------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   12 de Septiembre del 2007
    '--- Descripcion        :   Salvar los datos registrados de la cuenta de Usuario
    '                           CuentaID = 0 ; Crear nuevo Registro
    '                           CuentaID <> 0 ; Actualiza el registro 
    '------------------------------------------------------------------------------------------
    Private Sub SalvarCuentaUsuario()
        '--- Declaracion ---
        Dim T As New TransactionManager
        Dim drw As DataRow
        Dim blnNueva As Boolean
        Try
            '-- Definición de valores a las propiedades de la Clase Cuenta
            objCuenta.Login = UCase(Me.txtLogin.Text.Trim)

            '-- Campos no Obligatorio
            If Me.cdeFechaExpiracion.Text.Trim.Length > 0 Then
                objCuenta.FechaExpiracion = Me.cdeFechaExpiracion.Value
            End If

            '-- Asociarla la cuenta a un empleado
            If Me.cboEmpleado.Text.Trim.Length > 0 Then
                objCuenta.objEmpleadoID = Me.cboEmpleado.SelectedValue
            Else
                objCuenta.objEmpleadoID = Nothing
            End If

            '-- Inicio de la Transacción
            T.BeginTran()

            '--- Salvando la Cuenta
            If CuentaID = 0 Then
                objCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objCuenta.Activo = True

                If ValidarDatos(0) Then
                    objCuenta.Clave = clsProyecto.EncriptaToHex(Me.txtPassword.Text.Trim)

                    objCuenta.Insert(T)
                    '-- Asignación de la Cuenta Actual
                    CuentaID = objCuenta.SsgCuentaID
                    blnNueva = True
                Else
                    Exit Sub
                End If
            Else
                objCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor

                If Me.chkActivo.Checked Then
                    objCuenta.Activo = True
                Else
                    objCuenta.Activo = False
                End If

                If ValidarDatos() Then
                    objCuenta.Clave = clsProyecto.EncriptaToHex(Me.txtPassword.Text.Trim)
                    objCuenta.Update(T)
                    '-- Asignación de la Cuenta Actual
                    CuentaID = objCuenta.SsgCuentaID
                    blnNueva = False
                Else
                    Exit Sub
                End If
            End If

            SsgCuentaRol.DeleteByFilter("objCuentaID = " & CuentaID, T)
            '--- Salvando CuentaRol ---

            For Each drwRol As DataRow In RolesAplicacionDt.Rows
                If CBool(drwRol("Marcado")) Then
                    drw = CuentaDt.NewRow
                    drw("objCuentaID") = CuentaID
                    drw("objRolID") = drwRol("SsgRolID")
                    drw("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    drw("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    drw("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                    drw("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                    CuentaDt.Rows.Add(drw)
                End If
            Next

            SsgCuentaRol.BatchUpdate(CuentaDt.DataSet, T)
            '-- Confirmando la transacción
            T.CommitTran()

            If blnNueva Then
                MsgBox("La Cuenta de usuario fue guardada de forma satisfactoria", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Else
                MsgBox("La Cuenta de usuario fue modificada de forma satisfactoria", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As SqlClient.SqlException
            T.RollbackTran()
            clsError.CaptarError(ex)

        Catch ex As System.Data.DBConcurrencyException
            T.RollbackTran()
            clsError.CaptarError(ex)

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '------------------------------------------------------------------------------------------
    '--- Implementado Por:          Juan Carlos Herrera Amador
    '--- Fecha de Implementacion:   24 de Julio del 2006
    '--- Descripcion:               Validar los parámetros de entrada de la cuenta de Usuario.
    '---                            1. El login no puede repetirse dentro del catálogo de Cuenta.
    '---                            2. El password es un valor requerido.
    '---                            3. El password con la confirmación deben coincidir.
    '---                            4. La fecha de expiración debe ser mayor o igual a la fecha de creación.
    '---                            5. Debe asociarse al menos un Rol.
    '-------------------------------------------------------------------------------------------
    Private Function ValidarDatos(Optional ByVal Condicion As Short = 1) As Boolean
        Dim blnTieneRoles As Boolean
        Try
            '--- Condicion:
            '--- 0 : Nuevo Registro
            '--- 1 : Modificación de un Registro

            '--- Campos Obligatorio ---
            If Me.txtLogin.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(Me.txtLogin, "Campo Obligatorio")
                Me.txtLogin.Focus()
                Return False
            End If

            If Me.txtPassword.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(Me.txtPassword, "Campo Obligatorio")
                Me.txtPassword.Focus()
                Return False
            End If

            If Me.txtConfirmacion.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(Me.txtConfirmacion, "Campo Obligatorio")
                Me.txtConfirmacion.Focus()
                Return False
            End If

            '--- Validar que la clave no exceda la longitud máxima
            If clsProyecto.EncriptaToHex(Me.txtPassword.Text.Trim).Length > SsgCuenta.GetMaxLength("Clave") Then
                Me.ErrorProvider1.SetError(Me.txtPassword, "La clave excede el valor máximo permitido.")
                Me.txtPassword.Focus()
                Return False
            End If
            '----------

            '--- El password con la confirmación deben coincidir.
            If Me.txtPassword.Text.Trim <> Me.txtConfirmacion.Text.Trim Then
                MsgBox(" El valor del Password debe coincidir con la Confirmación.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ErrorProvider1.SetError(Me.txtPassword, " El valor del Password debe coincidir con la Confirmación.")
                Me.txtPassword.Focus()
                Return False
            End If

            '---. La fecha de Expiración debe ser mayor a la Actual
            If Me.cdeFechaExpiracion.ValueIsDbNull = False Then
                If Me.cdeFechaExpiracion.Value < Me.cdeFechaCreacion.Value Then
                    MsgBox("La fecha de expiración: " & Me.cdeFechaExpiracion.Text & " debe ser " & Chr(10) & _
                           "mayor a la fecha de creación: " & Me.cdeFechaCreacion.Text, MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ErrorProvider1.SetError(Me.cdeFechaExpiracion, "La fecha de expiración: " & Me.cdeFechaExpiracion.Text & " debe ser mayor a la fecha de creación: " & Me.cdeFechaCreacion.Text)
                    Me.cdeFechaExpiracion.Focus()
                    Return False
                End If
            End If

            '--- Debe Asociarse al menos un rol
            For Each drw As DataRow In RolesAplicacionDt.Rows
                If CBool(drw("Marcado")) Then
                    blnTieneRoles = True
                    Exit For
                End If
            Next

            If Not blnTieneRoles Then
                MsgBox("Debe asociar al menos un Rol a la cuenta de Usuario.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ErrorProvider1.SetError(Me.grdRoles, "Debe asociar al menos un Rol a la cuenta de Usuario.")
                Me.grdRoles.Focus()
                Return False
            End If

            '--- El login no puede repetirse dentro del catálogo de Cuenta.
            Select Case Condicion
                Case 0
                    '--- Login no se duplique 
                    If SsgCuenta.RetrieveDT("Login = '" & objCuenta.Login & "'").Rows.Count > 0 Then
                        MsgBox("Ya existe una Cuenta de Usuario con el Login - " & objCuenta.Login, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                    Else
                        Return True
                    End If
                Case 1
                    '--- Nombre no se duplique
                    If SsgCuenta.RetrieveDT("Login = '" & objCuenta.Login & "'" & "And SsgCuentaID <> " & CuentaID).Rows.Count > 0 Then
                        MsgBox("Ya existe una Cuenta con el Login -  " & objCuenta.Login, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                    Else
                        Return True
                    End If
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Eventos de los controles de captura de datos"


    Private Sub cdeFechaCreacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdeFechaCreacion.TextChanged
        blnModifico = True
    End Sub
    Private Sub cdeFechaExpiracion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdeFechaExpiracion.TextChanged
        blnModifico = True
    End Sub
    Private Sub chkActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivo.CheckedChanged
        blnModifico = True
    End Sub
    Private Sub grdRoles_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdRoles.AfterColEdit
        blnModifico = True
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If clsProyecto.EncriptaToHex(Me.txtPassword.Text.Trim).Length > SsgCuenta.GetMaxLength("Clave") Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
                e.KeyChar = Microsoft.VisualBasic.ChrW(0)
            End If
        End If
    End Sub

    Private Sub cboEmpleado_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEmpleado.SelectedValueChanged
        Dim dr As DataRow
        Try
            blnModifico = True
            '----Mostrar información del empleado
            If Not Me.cboEmpleado.SelectedValue Is Nothing Then
                dr = Me.dtEmpleados.Rows.Find(Me.cboEmpleado.SelectedValue)

                If Not IsDBNull(dr("Nombre")) Then
                    Me.lblNombreEmp.Text = dr("Nombre")
                End If
                'If Not IsDBNull(dr("NumCedula")) Then
                '    Me.lblCedula.Text = dr("NumCedula")
                'End If
                'If Not IsDBNull(dr("FechaIngreso")) Then
                '    Me.lblFechaInicioEmp.Text = Format(dr("FechaIngreso"), "Long Date")
                'End If
                'If Not IsDBNull(dr("FechaEgreso")) Then
                '    Me.lblFechaFinEmp.Text = dr("FechaEgreso")
                'End If
                'If Not IsDBNull(dr("Activo")) Then
                '    Me.chkActivoEmpleado.Checked = CBool(dr("Activo"))
                'End If
            Else
                Me.lblNombreEmp.Text = ""
                Me.lblCedula.Text = ""
                Me.lblFechaInicioEmp.Text = ""
                Me.lblFechaFinEmp.Text = ""
                Me.chkActivoEmpleado.Checked = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CamposObligatorios(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating, txtLogin.Validating, txtConfirmacion.Validating
        '--- Declaración ---
        Dim objtxt As TextBox
        Try
            objtxt = CType(sender, TextBox)
            If (String.IsNullOrEmpty(objtxt.Text.Trim)) Then
                Me.ErrorProvider1.SetError(objtxt, "Campo Obligatorio")
                e.Cancel = True
                Me.cmdAceptar.Enabled = False
            Else
                e.Cancel = False
                Me.ErrorProvider1.Clear()
                Me.cmdAceptar.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CamposOblig(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged, txtLogin.TextChanged, txtConfirmacion.TextChanged
        '--- Declaracion ---
        Dim objtxt As TextBox
        Try
            objtxt = CType(sender, TextBox)
            blnModifico = True
            If (String.IsNullOrEmpty(objtxt.Text.Trim)) Then
                Me.ErrorProvider1.SetError(objtxt, "Campo obligatorio")
                Me.cmdAceptar.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdAceptar.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

End Class