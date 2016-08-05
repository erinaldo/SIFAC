Imports Seguridad.Datos
Imports System.Windows.Forms
Imports Proyecto.Configuracion
Public Class frmSsgEditAccion

#Region "Declaracion de Variables locales a la Clase del formulario frmSsgEditAccion"
    'Declaracion de Variables
    Dim mAccionID As Long
    Dim mServUsuarioID As Long
    Dim blnModifico As Boolean
    Dim mNombreAcccion As String
    Private objServicio As SsgServicioUsuario
    Private objAccion As SsgAccion

#End Region

#Region "Propiedades"

    Public Property ServUsuarioID() As Long
        Get
            ServUsuarioID = mServUsuarioID
        End Get
        Set(ByVal value As Long)
            mServUsuarioID = value
        End Set
    End Property
    
    Public Property AccionID() As Long
        Get
            AccionID = mAccionID
        End Get
        Set(ByVal value As Long)
            mAccionID = value
        End Set
    End Property

    Public Property NombreAccion() As String
        Get
            Return mNombreAcccion
        End Get
        Set(ByVal value As String)
            mNombreAcccion = value
        End Set
    End Property

#End Region

#Region "Eventos del Formulario"
    Private Sub frmSsgEditAccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EstablecerPropiedades()
            clsProyecto.CargarTemaDefinido(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '--------------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementacion:    10 de Septiembre del 2007
    '-- Descripcion:                Configura propiedades al form y ciertos controles
    '---------------------------------------------------------------------------------
    Private Sub EstablecerPropiedades()
        Try
            '--- Instanciar ---
            objServicio = New SsgServicioUsuario
            objAccion = New SsgAccion

            CargarDatosServUsuario()

            If AccionID = 0 Then
                Me.Text = "Agregar Acción"
            Else
                Me.Text = "Modificar Acción"
                Me.txtCodInterno.Tag = "BLOQUEADO"
                Me.txtCodInterno.Enabled = False
                CargarDatosAccion()
            End If

            '--- Establecer tamaño máximo de los campos
            Me.txtCodInterno.MaxLength = SsgServicioUsuario.GetMaxLength("CodInterno")
            Me.txtNombre.MaxLength = SsgServicioUsuario.GetMaxLength("Nombre")
            Me.txtDescripcion.MaxLength = SsgServicioUsuario.GetMaxLength("Descripcion")

            blnModifico = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region
    
#Region "Eventos Botones Aceptar-Cancelar"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If blnModifico Then
                SalvarAccion()
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
                        SalvarAccion()
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

#Region "Metodos Para la Edición de una Acción"

        '--------------------------------------------------------------------------
        '-- Implementado Por:           Juan Carlos Herrera Amador
        '-- Fecha de Implementación:    10 de Septiembre del 2007
        '-- Descripcion:                Carga los datos de la Acción a modificar
        '--------------------------------------------------------------------------
    Private Sub CargarDatosAccion()
        Try
            objAccion.Retrieve(AccionID)
            '-- Validación para evitar valores Nulos del CodInterno
            If Not objAccion.CodInterno Is Nothing Then
                Me.txtCodInterno.Text = objAccion.CodInterno
            End If
            '-- Validación para evitar valores Nulos del Nombre
            If Not objAccion.Nombre Is Nothing Then
                Me.txtNombre.Text = objAccion.Nombre
            End If

            '-- Validación para evitar valores Nulos de la Descripción
            If Not objAccion.Descripcion Is Nothing Then
                Me.txtDescripcion.Text = objAccion.Descripcion
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '--------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementación:    10 de Septiembre del 2007
    '-- Descripcion:                Cargar los datos del Servicio de Usuario al cual 
    '--                             pertenece la Acción a moficar o pertenecerá
    '--                             la nueva Acción en caso de la opción Agregar
    '--------------------------------------------------------------------------
    Private Sub CargarDatosServUsuario()
        Try
            objServicio.Retrieve(ServUsuarioID())

            '-- Validación para evitar valores Nulos del CodInterno
            If Not objServicio.CodInterno Is Nothing Then
                Me.txtCodInternoS.Text = objServicio.CodInterno
            End If
            '-- Validación para evitar valores Nulos del Nombre
            If Not objServicio.Nombre Is Nothing Then
                Me.txtNombreS.Text = objServicio.Nombre
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    :   10 de Septiembre del 2007
    '-- Descripcion             :   Salva los datos de la Acción según el modo:
    '                               ServicioID = 0 ; Crear nuevo Registro
    '                               ServicioID <> 0 ; Actualiza el registro 
    '----------------------------------------------------------------------------------
    Private Sub SalvarAccion()
        Try
            '-- Asignación de valores a las propiedades 
            objAccion.CodInterno = Me.txtCodInterno.Text.Trim
            objAccion.Nombre = Me.txtNombre.Text.Trim
            objAccion.objServicioUsuarioID = ServUsuarioID

            '--- Campos no obligatorios
            If Me.txtDescripcion.Text.Trim.Length > 0 Then
                objAccion.Descripcion = Me.txtDescripcion.Text.Trim
            End If

            '--- Verificar el modo segun el AccionID:
            '--- AccionID=0; Agregar
            '--- AccionID<>0 ; Modificar

            If AccionID = 0 Then
                objAccion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAccion.FechaCreacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos(0) Then
                    objAccion.Insert()
                    '-- Asignación de la  Acción Actual
                    AccionID = objAccion.SsgAccionID
                    MsgBox("Se agregó una nueva Acción de forma satisfactoria.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            Else
                objAccion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objAccion.FechaModificacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos() Then
                    objAccion.Update()

                    '-- Asignación de la Acción Actual
                    AccionID = objAccion.SsgAccionID
                    MsgBox("Se actualizaron los datos de forma satisfactoria.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        : Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    : 10 de Septiembre del 2007
    '-- Descripcion             : Verifica si ya existe un registro con los datos (CodInterno y Nombre)
    '--                         : para evitar que sean duplicados, también que no esten vacios
    '--------------------------------------------------------------------------------------------------
    Private Function ValidarDatos(Optional ByRef condicion As Short = 1) As Boolean
        Try
            '--- Campos Obligatorio ---
            If Me.txtNombre.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(Me.txtNombre, "Campo Obligatorio")
                Return False
            End If
            If Me.txtCodInterno.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(Me.txtCodInterno, "Campo Obligatorio")
                Return False
            End If

            '--- Condicion:
            '--- 0 : Nuevo Registro
            '--- 1 : Modificación de un Registro

            Select Case condicion
                Case 0
                    '--- CodInterno y Nombre no se dupliquen 
                    If SsgAccion.RetrieveDT("CodInterno = '" & objAccion.CodInterno & "' And  Nombre = '" & objAccion.Nombre & "' And objServicioUsuarioID = " & objAccion.objServicioUsuarioID).Rows.Count > 0 Then
                        MsgBox("Ya existe una con el Código - " & objAccion.CodInterno & _
                        " y el Nombre - " & objAccion.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        '--- CodInterno no se duplique
                    ElseIf SsgAccion.RetrieveDT("CodInterno = '" & objAccion.CodInterno & "' And objServicioUsuarioID = " & objAccion.objServicioUsuarioID).Rows.Count > 0 Then
                        MsgBox("Ya existe una Acción con el Código - " & objAccion.CodInterno, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        '--- Nombre no se duplique
                    ElseIf SsgAccion.RetrieveDT("Nombre = '" & objAccion.Nombre & "' And objServicioUsuarioID = " & objAccion.objServicioUsuarioID).Rows.Count > 0 Then
                        MsgBox("Ya existe una Acción con el Nombre -  " & objAccion.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                    End If
                    Return True

                Case 1
                    '--- Nombre no se duplique
                    If objAccion.RetrieveByFilter("Nombre = '" & objAccion.Nombre & "'" & "And SsgAccionID <> " & AccionID & " And objServicioUsuarioID = " & objAccion.objServicioUsuarioID) Then
                        MsgBox("Ya existe una Acción con el Nombre -  " & objAccion.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
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
    Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodInterno.KeyPress
        If e.KeyChar = " " Or e.KeyChar = "'" Then
            e.Handled = True
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
        blnModifico = True
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        blnModifico = True
    End Sub

    Private Sub CamposObligatorios(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating, txtCodInterno.Validating
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

    Private Sub CamposOblig(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, txtCodInterno.TextChanged
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