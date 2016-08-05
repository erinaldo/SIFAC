Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Public Class frmSsgEditModulo

#Region "Declaracion de Variables locales a la Clase del formulario frmSsgEditModulo"
    'Declaracion de Variables
    Dim mModuloID As Long
    Dim mNombreModulo As String
    Dim mAplicacionID As Long
    Dim blnModifico As Boolean
    Private objModulo As SsgModulo
    Private objAplicacion As SsgAplicacion
#End Region

#Region "Propiedades"
    Public Property AplicacionID() As Long
        Get
            AplicacionID = mAplicacionID
        End Get
        Set(ByVal value As Long)
            mAplicacionID = value
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

    Public Property ModuloNombre() As Long
        Get
            ModuloNombre = mNombreModulo
        End Get
        Set(ByVal value As Long)
            mNombreModulo = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"
    Private Sub frmSsgEditModulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EstablecerPropiedades()
            clsProyecto.CargarTemaDefinido(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    '--------------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementacion:    7 de Septiembre del 2007
    '-- Descripcion:                Configura propiedades al form y ciertos controles
    '---------------------------------------------------------------------------------
    Private Sub EstablecerPropiedades()
        Try
            '--- Instanciar ---
            objModulo = New SsgModulo
            objAplicacion = New SsgAplicacion

            CargarDatosAplicacion()

            If ModuloID = 0 Then
                Me.Text = "Agregar Módulo"
            Else
                Me.Text = "Modificar Módulo"
                Me.txtCodInterno.Tag = "BLOQUEADO"
                'Me.txtCodInternoA.Tag = "BLOQUEADO"
                'Me.txtNombreA.Tag = "BLOQUEADO"
                Me.txtCodInterno.Enabled = False
                CargarDatosModulo()
            End If

            '--- Establecer tamaño máximo de los campos
            Me.txtCodInterno.MaxLength = SsgModulo.GetMaxLength("CodInterno")
            Me.txtNombre.MaxLength = SsgModulo.GetMaxLength("Nombre")
            Me.txtDescripcion.MaxLength = SsgModulo.GetMaxLength("Descripcion")

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
                SalvarModulo()
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
                        SalvarModulo()
                    Case MsgBoxResult.No
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Case MsgBoxResult.Cancel
                End Select
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
            Exit Sub
        End Try
    End Sub

#End Region

#Region "Metodos Para la Edición de un Módulo"

    '--------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementación:    8 de Septiembre del 2007
    '-- Descripcion:                Cargar los datos del Módulo a modificar
    '--------------------------------------------------------------------------
    Private Sub CargarDatosModulo()
        Try
            objModulo.Retrieve(ModuloID)

            '-- Validación para evitar valores Nulos del CodInterno
            If Not objModulo.CodInterno Is Nothing Then
                Me.txtCodInterno.Text = objModulo.CodInterno
            End If

            '-- Validación para evitar valores Nulos del Nombre
            If Not objModulo.Nombre Is Nothing Then
                Me.txtNombre.Text = objModulo.Nombre
            End If

            '-- Validación para evitar valores Nulos de la Descripción
            If Not objModulo.Descripcion Is Nothing Then
                Me.txtDescripcion.Text = objModulo.Descripcion
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '--------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementación:    8 de Septiembre del 2007
    '-- Descripcion:                Cargar los datos de la Aplicación a la cual 
    '--                             pertenece el módulo a moficar o pertenecerá
    '--                             el nuevo modulo en caso de la opción Agregar
    '--------------------------------------------------------------------------
    Private Sub CargarDatosAplicacion()
        Try
            objAplicacion.Retrieve(AplicacionID)

            '-- Validación para evitar valores Nulos del CodInterno
            If Not objAplicacion.CodInterno Is Nothing Then
                Me.txtCodInternoA.Text = objAplicacion.CodInterno
            End If
            '-- Validación para evitar valores Nulos del Nombre
            If Not objAplicacion.Nombre Is Nothing Then
                Me.txtNombreA.Text = objAplicacion.Nombre
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    :   7 de Septiembre del 2007
    '-- Descripcion             :   Salva los datos de la aplicacion según el modo:
    '                               ModuloID = 0 ; Crear nuevo Registro
    '                               ModuloID <> 0 ; Actualiza el registro 
    '----------------------------------------------------------------------------------
    Private Sub SalvarModulo()
        Try
            '-- Asignación de valores a las propiedades 
            objModulo.CodInterno = Me.txtCodInterno.Text.Trim
            objModulo.Nombre = Me.txtNombre.Text.Trim
            objModulo.objAplicacionID = AplicacionID

            '--- Campos no obligatorios
            If Me.txtDescripcion.Text.Trim.Length > 0 Then
                objModulo.Descripcion = Me.txtDescripcion.Text.Trim
            End If

            '--- Verificar el modo segun el ModuloID:
            '--- ModuloID=0; Agregar
            '--- ModuloID<>0 ; Modificar

            If ModuloID = 0 Then
                objModulo.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objModulo.FechaCreacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos(0) Then
                    objModulo.Insert()

                    '-- Asignación del Módulo Actual
                    ModuloID = objModulo.SsgModuloID
                    MsgBox("Se agregó un nuevo módulo de forma satisfactoria.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            Else
                objModulo.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objModulo.FechaModificacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos() Then
                    objModulo.Update()

                    '-- Asignación del Módulo Actual
                    ModuloID = objModulo.SsgModuloID
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
                    If SsgModulo.RetrieveDT("CodInterno = '" & objModulo.CodInterno & "' And  Nombre = '" & objModulo.Nombre & "' And objAplicacionID = " & objModulo.objAplicacionID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Módulo con el Código - " & objModulo.CodInterno & _
                        " y el Nombre - " & objModulo.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        '--- CodInterno no se duplique
                    ElseIf SsgModulo.RetrieveDT("CodInterno = '" & objModulo.CodInterno & "' And objAplicacionID = " & objModulo.objAplicacionID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Módulo con el Código - " & objModulo.CodInterno, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        '--- Nombre no se duplique
                    ElseIf SsgModulo.RetrieveDT("Nombre = '" & objModulo.Nombre & "' And objAplicacionID = " & objModulo.objAplicacionID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Módulo con el Nombre -  " & objModulo.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                    End If
                    Return True

                Case 1
                    '--- Nombre no se duplique
                    If SsgModulo.RetrieveDT("Nombre = '" & objModulo.Nombre & "' And SsgModuloID <> " & ModuloID & " And objAplicacionID = " & objModulo.objAplicacionID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Módulo con el Nombre -  " & objModulo.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
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