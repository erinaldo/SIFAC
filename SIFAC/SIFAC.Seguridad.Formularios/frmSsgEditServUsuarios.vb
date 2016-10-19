Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms

Public Class frmSsgEditServUsuarios

#Region "Declaracion de Variables locales a la Clase del formulario frmSsgEditModulo"
    Dim mServicioID As Long
    Dim mModuloID As Long
    Dim blnModifico As Boolean
    Dim mNombreServicio As String
    Private objModulo As SsgModulo
    Private objServicio As SsgServicioUsuario

#End Region

#Region "Propiedades"
    Public Property ServicioID() As Long
        Get
            ServicioID = mServicioID
        End Get
        Set(ByVal value As Long)
            mServicioID = value
        End Set
    End Property

    Public Property ModuloID() As Long
        Get
            ModuloID = mModuloID
        End Get
        Set(ByVal value As Long)
            mModuloID = value
        End Set
    End Property

    Public Property NombreServicio() As String
        Get
            Return mNombreServicio
        End Get
        Set(ByVal value As String)
            mNombreServicio = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"
    Private Sub frmSsgEditServUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EstablecerPropiedades()

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
            objModulo = New SsgModulo
            objServicio = New SsgServicioUsuario

            CargarDatosModulo()

            If ServicioID = 0 Then
                Me.Text = "Agregar Servicio Usuario"
            Else
                Me.Text = "Modificar Servicio Usuario"
                Me.txtCodInterno.Tag = "BLOQUEADO"
                Me.txtCodInterno.Enabled = False
                CargarDatosServicioUsuario()
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
                SalvarServicioUsuario()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
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
                        SalvarServicioUsuario()
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

#Region "Metodos Para la Edición de un Módulo"

    '------------------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementación:    10 de Septiembre del 2007
    '-- Descripcion:                Cargar los datos del Servicio de usuario a modificar
    '------------------------------------------------------------------------------------
    Private Sub CargarDatosServicioUsuario()
        Try
            objServicio.Retrieve(ServicioID)

            '-- Validación para evitar valores Nulos del CodInterno
            If Not objServicio.CodInterno Is Nothing Then
                Me.txtCodInterno.Text = objServicio.CodInterno
            End If

            '-- Validación para evitar valores Nulos del Nombre
            If Not objServicio.Nombre Is Nothing Then
                Me.txtNombre.Text = objServicio.Nombre
            End If

            '-- Validación para evitar valores Nulos del Nombre
            If Not objServicio.Descripcion Is Nothing Then
                Me.txtDescripcion.Text = objServicio.Descripcion
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementación:    10 de Septiembre del 2007
    '-- Descripcion:                Cargar los datos del Módulo al cual pertenece
    '--                             el Servicio de Usuario a moficar o pertenecerá
    '--                             el nuevo Servicio de Usuario en caso de la opción Agregar
    '------------------------------------------------------------------------------------------
    Public Sub CargarDatosModulo()
        Try
            objModulo.Retrieve(ModuloID)

            '-- Validación para evitar valores Nulos del CodInterno
            If Not objModulo.CodInterno Is Nothing Then
                Me.txtCodInternoM.Text = objModulo.CodInterno
            End If
            '-- Validación para evitar valores Nulos del Nombre
            If Not objModulo.Nombre Is Nothing Then
                Me.txtNombreM.Text = objModulo.Nombre
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    :   10 de Septiembre del 2007
    '-- Descripcion             :   Salva los datos del Servicio de Usuario según el modo:
    '                               ModuloID = 0 ; Crear nuevo Registro
    '                               ModuloID <> 0 ; Actualiza el registro 
    '----------------------------------------------------------------------------------
    Private Sub SalvarServicioUsuario()
        Try

            '-- Asignación de valores a las propiedades 
            objServicio.CodInterno = Me.txtCodInterno.Text.Trim
            objServicio.Nombre = Me.txtNombre.Text.Trim
            objServicio.objModuloID = ModuloID

            '--- Campos no obligatorios
            If Me.txtDescripcion.Text.Trim.Length > 0 Then
                objServicio.Descripcion = Me.txtDescripcion.Text.Trim
            End If

            '--- Verificar el modo segun el ModuloID:
            '--- AplicacionID=0; Agregar
            '--- AplicacionID<>0 ; Modificar

            If ServicioID = 0 Then
                objServicio.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objServicio.FechaCreacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos(0) Then
                    objServicio.Insert()

                    '-- Asignación del Servicio  Actual
                    ServicioID = objServicio.SsgServicioUsuarioID
                    MsgBox("Se agregó un nuevo Servicio de Usuario de forma satisfactoria.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            Else
                objServicio.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objServicio.FechaModificacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos() Then
                    objServicio.Update()

                    '-- Asignación del Servicio Actual
                    ServicioID = objServicio.SsgServicioUsuarioID
                    MsgBox("Se actualizaron los datos de forma satisfactoria.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

            'blnModifico = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        : Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    : 8 de Septiembre del 2007
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
                    If SsgServicioUsuario.RetrieveDT("CodInterno = '" & objServicio.CodInterno & "' And  Nombre = '" & objServicio.Nombre & "' And objModuloID = " & objServicio.objModuloID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Servicio de Usuario con el Código - " & objServicio.CodInterno & _
                        " y el Nombre - " & objServicio.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        '--- CodInterno no se duplique
                    ElseIf SsgServicioUsuario.RetrieveDT("CodInterno = '" & objServicio.CodInterno & "' And objModuloID = " & objServicio.objModuloID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Servicio de Usuario con el Código - " & objServicio.CodInterno, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        '--- Nombre no se duplique
                    ElseIf SsgServicioUsuario.RetrieveDT("Nombre = '" & objServicio.Nombre & "' And objModuloID = " & objServicio.objModuloID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Servicio de Usuario con el Nombre -  " & objServicio.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                    End If
                    Return True

                Case 1
                    '--- Nombre no se duplique
                    If SsgServicioUsuario.RetrieveDT("Nombre = '" & objServicio.Nombre & "'" & "And SsgServicioUsuarioID <> " & ServicioID & " And objModuloID = " & objServicio.objModuloID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Servicio de Usuario con el Nombre -  " & objServicio.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
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