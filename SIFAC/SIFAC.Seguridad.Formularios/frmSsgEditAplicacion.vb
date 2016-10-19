Imports DAL
Imports System.Data
Imports Seguridad.Datos
Imports Proyecto.configuracion
Imports System.Windows.Forms
Public Class frmSsgEditAplicacion

#Region "Declaracion de Variables locales a la Clase del formulario frmEditAplicacion"
    'Declaracion de Variables
    Dim mAplicacionID As Long
    Dim blnModifico As Boolean
    Dim mNombreAplicacion As String
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
    Public Property NombreAplicacion() As String
        Get
            Return mNombreAplicacion
        End Get
        Set(ByVal value As String)
            mNombreAplicacion = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"
    Private Sub frmSsgEditAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EstablecerPropiedades()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '---------------------------------------------------------------------------------
    '-- Implementado Por:           Juan Carlos Herrera Amador
    '-- Fecha de Implementacion:    7 de Septiembre del 2007
    '-- Descripcion:                Configura propiedades al form y ciertos controles
    '---------------------------------------------------------------------------------
    Private Sub EstablecerPropiedades()
        Try
            '--- Instanciar ---
            objAplicacion = New SsgAplicacion

            If mAplicacionID = 0 Then
                Me.Text = "Agregar aplicación"
            Else
                Me.Text = "Modificar aplicación"
                Me.txtCodInterno.Tag = "BLOQUEADO"
                Me.txtCodInterno.Enabled = False
                CargarDatosAplicacion()

            End If

            '--- Establecer tamaño máximo de los campos
            Me.txtCodInterno.MaxLength = SsgAplicacion.GetMaxLength("CodInterno")
            Me.txtNombre.MaxLength = SsgAplicacion.GetMaxLength("Nombre")
            Me.txtDescripcion.MaxLength = SsgAplicacion.GetMaxLength("Descripcion")

            blnModifico = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
   
#End Region

#Region "Eventos Botones Aceptar-Cancelar"


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            If blnModifico Then
                Select Case MsgBox("¿Desea guardar los cambios ?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)
                    Case MsgBoxResult.Yes
                        SalvarAplicacion()
                    Case MsgBoxResult.No
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Case MsgBoxResult.Cancel
                End Select
            else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            end if
        Catch ex As Exception
            clsError.CaptarError(ex)
            Exit Sub
        End Try
    End Sub
    

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If blnModifico Then
                SalvarAplicacion()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "Metodos Para la Edición de una Aplicación"
    '-----------------------------------------------------------------------
    '-- Nombre del Autor        : Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    : 7 de Septiembre del 2007
    '-- Descripcion             : Cargar los datos de la Aplicación seleccionada
    '-----------------------------------------------------------------------
    Private Sub CargarDatosAplicacion()
        Try
            objAplicacion.Retrieve(AplicacionID)

            '-- Validación para evitar valores Nulos del CodInterno
            If Not objAplicacion.CodInterno Is Nothing Then
                Me.txtCodInterno.Text = objAplicacion.CodInterno
            End If
            '-- Validación para evitar valores Nulos del Nombre
            If Not objAplicacion.Nombre Is Nothing Then
                Me.txtNombre.Text = objAplicacion.Nombre
            End If

            '-- Validación para evitar valores Nulos de la Descripcion
            If Not objAplicacion.Descripcion Is Nothing Then
                Me.txtDescripcion.Text = objAplicacion.Descripcion
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    :   7 de Septiembre del 2007
    '-- Descripcion             :   Salva los datos de la aplicacion según el modo:
    '                               AplicacionID = 0 ; Crear nuevo Registro
    '                               AplicacionID <> 0 ; Actualiza el registro 
    '----------------------------------------------------------------------------------
    Private Sub SalvarAplicacion()
        Try
            '-- Asignación de valores a las propiedades 
            objAplicacion.CodInterno = Me.txtCodInterno.Text.Trim
            objAplicacion.Nombre = Me.txtNombre.Text.Trim

            '--- Campos no obligatorios
            If Me.txtDescripcion.Text.Trim.Length > 0 Then
                objAplicacion.Descripcion = Me.txtDescripcion.Text.Trim
            End If

            '--- Verificar el modo segun el AplicacionID:
            '--- AplicacionID=0; Agregar
            '--- AplicacionID<>0 ; Modificar
            If AplicacionID = 0 Then
                objAplicacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAplicacion.FechaCreacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos(0) Then
                    objAplicacion.Insert()

                    '-- Asignación de la Orden Actual
                    AplicacionID = objAplicacion.SsgAplicacionID
                    MsgBox("Se agregó una nueva aplicación de forma satisfactoria.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                objAplicacion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objAplicacion.FechaModificacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos() Then
                    objAplicacion.Update()

                    '-- Asignación de la Orden Actual
                    AplicacionID = objAplicacion.SsgAplicacionID
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

            Select Case condicion
                Case 0
                    '--- CodInterno y Nombre no se dupliquen
                    If SsgAplicacion.RetrieveDT("CodInterno = '" & objAplicacion.CodInterno & "' And  Nombre = '" & objAplicacion.Nombre & "'").Rows.Count > 0 Then
                        MsgBox("Ya existe una aplicación con el Código - " & objAplicacion.CodInterno & _
                        " y el Nombre - " & objAplicacion.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        '--- CodInterno no se duplique
                    ElseIf SsgAplicacion.RetrieveDT("CodInterno = '" & objAplicacion.CodInterno & "'").Rows.Count > 0 Then
                        MsgBox("Ya existe una aplicación con el Código - " & objAplicacion.CodInterno, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                        '--- Nombre no se duplique
                    ElseIf SsgAplicacion.RetrieveDT("Nombre = '" & objAplicacion.Nombre & "'").Rows.Count > 0 Then
                        MsgBox("Ya existe una aplicación con el Nombre -  " & objAplicacion.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                    End If
                    Return True

                Case 1

                    If SsgAplicacion.RetrieveDT("Nombre = '" & objAplicacion.Nombre & "'" & "And SsgAplicacionID <> " & AplicacionID).Rows.Count > 0 Then
                        MsgBox("Ya existe una aplicación con el Nombre -  " & objAplicacion.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
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


    Private Sub CamposObligatorios_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating, txtCodInterno.Validating
        '--- Declaración ---
        Dim objtxt As TextBox
        Try
            objtxt = CType(sender, TextBox)
            If (String.IsNullOrEmpty(objtxt.Text)) Then
                Me.ErrorProvider1.SetError(objtxt, "Campo obligatorio")
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

    Private Sub CamposObligatorios(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, txtCodInterno.TextChanged
        '--- Declaración ---
        Dim objtxt As TextBox
        Try
            objtxt = CType(sender, TextBox)
            blnModifico = True
            If (String.IsNullOrEmpty(objtxt.Text)) Then
                Me.ErrorProvider1.SetError(objtxt, "Campo bligatorio")
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