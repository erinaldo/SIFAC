''-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Michelle Valezka Reyes Tijerino.
''-- Fecha de Elaboración    : 30 de Enero de 2008.
''----------------------------------------------------------------------
''--    Formulario de Edición y Modificación de Parámetros
''----------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports System.Windows.Forms
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos

Public Class frmStbEditParametro

#Region "Declaracion de Variables locales"
    Dim objParam As StbParametro
    Dim blnCambio As New Boolean
    Private m_TipoParamID As Integer
    Dim dtUbicacion As DataTable
#End Region

#Region "Propiedades"
    Public Property TipoParamID() As Integer
        Get
            Return m_TipoParamID
        End Get
        Set(ByVal value As Integer)
            m_TipoparamID = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbEditParametro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-- Insntanciar
            Me.Cursor = Cursors.WaitCursor
            objParam = New StbParametro
            If Not TipoParamID = 0 Then
                objParam.Retrieve(TipoParamID)
                Me.txtNombParam.Text = objParam.Nombre
                Me.txtValorParam.Text = objParam.Valor
                Me.txtDescripParam.Text = objParam.Descripcion
            End If
            PropiedadesFormulario()
            clsProyecto.CargarTemaDefinido(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub PropiedadesFormulario()
        Try
            '-- Instanciar
            Me.txtDescripParam.MaxLength = StbParametro.GetMaxLength("Descripcion")
            Me.txtNombParam.MaxLength = StbParametro.GetMaxLength("Nombre")
            Me.txtValorParam.MaxLength = StbParametro.GetMaxLength("Valor")
            blnCambio = False
            If TipoParamID = 0 Then
                Me.Text = "Agregar Parámetro"
                Me.Icon = My.Resources.AgregarIco
            Else
                Me.Text = "Modificar Parámetro"
                Me.txtNombParam.Tag = "BLOQUEADO"
                Me.txtNombParam.Enabled = False
                Me.Icon = My.Resources.EditICO
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos Botones Aceptar - Cancelar"

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        GuardarRegistros()
    End Sub

    Private Sub GuardarRegistros()
        Dim T As New TransactionManager
        Try
            If TipoParamID = 0 Then
                If ValidarDatos(0) Then
                    T.BeginTran()
                    objParam.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objParam.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objParam.Insert(T)
                    TipoParamID = objParam.StbParametroID
                    T.CommitTran()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                If ValidarDatos() Then
                    T.BeginTran()
                    objParam.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objParam.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objParam.Update(T)
                    T.CommitTran()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Dim blnMensaje As Boolean = False
        Try
            If TipoParamID = 0 Then
                If Not Me.txtNombParam.Text.Trim.Length = 0 Or Not Me.txtValorParam.Text.Trim.Length = 0 Or Not Me.txtDescripParam.Text.Trim.Length = 0 Then
                    blnMensaje = True
                End If
            Else
                blnMensaje = blnCambio
            End If
            If blnMensaje Then
                Select Case MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        GuardarRegistros()
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

#Region "Verificación de las Entradas"

    Private Function ValidarDatos(Optional ByRef condicion As Short = 1) As Boolean
        Try
            '-- Asignar el valor de los txt a Objeto para validar datos antes de Almacenarlos
            objParam.Nombre = Me.txtNombParam.Text
            objParam.Valor = Me.txtValorParam.Text.Trim
            objParam.Descripcion = Me.txtDescripParam.Text.Trim

            '-- Verificar que no se dejen vacios ningun Campo obligatorio.
            If Me.txtNombParam.Text.Trim.Length = 0 Then
                Me.txtNombParam.Focus()
                Me.ErrorProvider1.SetError(Me.txtNombParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
                Return False
            End If
            If Me.txtValorParam.Text.Trim.Length = 0 Then
                Me.txtValorParam.Focus()
                Me.ErrorProvider1.SetError(Me.txtValorParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
                Return False
            End If
            If Me.txtDescripParam.Text.Trim.Length = 0 Then
                Me.txtDescripParam.Focus()
                Me.ErrorProvider1.SetError(Me.txtDescripParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
                Return False
            End If

            '-- Si es un registro nuevo
            If TipoParamID = 0 Then
                '-- Verificar que los Datos no se Dupliquen en la Base de Datos
                If StbParametro.RetrieveDT("Nombre='" & objParam.Nombre & "'").Rows.Count > 0 Then
                    MsgBox("Ya existe un registro con el mismo nombre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.txtNombParam.Clear()
                    Me.txtNombParam.Focus()
                    Return False
                End If
                '-- Si los campos son correctos se pueden Almacenar
                Return True

                '-- Si es Modificar un Registro
            Else
                '-- Verificar que los Datos no se Dupliquen en la Base de Datos
                If StbParametro.RetrieveDT("Nombre='" & objParam.Nombre & "'And StbParametroID <>" & TipoParamID).Rows.Count > 0 Then
                    MsgBox("Ya existe un registro con el mismo nombre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.txtNombParam.Clear()
                    Me.txtNombParam.Focus()
                    Return False
                End If
                '-- Si los campos son correctos se pueden Almacenar
                Return True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Validacion de las Entradas"

    '-- Validar que no existan Entradas en Blanco ni de Otros Caracteres
    Private Sub txtNombParam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombParam.KeyPress
        If Not clsProyecto.LetrasSinEspacio(e.KeyChar) Then
            e.Handled = True
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub

    Private Sub txtDescripParam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripParam.KeyPress
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) And Not clsProyecto.CEspecComayPunto(e.KeyChar) And Not clsProyecto.CEspecParentesis(e.KeyChar) Then
            e.Handled = True
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub

    '-- ERROR PROVIDER
    Private Sub txtDescripParam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripParam.TextChanged
        Try
            If String.IsNullOrEmpty(txtDescripParam.Text) Or txtDescripParam.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(txtDescripParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdGuardar.Enabled = True
                blnCambio = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtDescripParam_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescripParam.Validating
        Try
            If String.IsNullOrEmpty(txtDescripParam.Text) Or txtDescripParam.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(txtDescripParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdGuardar.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtValorParam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorParam.TextChanged
        Try
            If String.IsNullOrEmpty(txtValorParam.Text) Then
                Me.ErrorProvider1.SetError(txtValorParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdGuardar.Enabled = True
                blnCambio = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtValorParam_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtValorParam.Validating
        Try
            If String.IsNullOrEmpty(txtValorParam.Text) Then
                Me.ErrorProvider1.SetError(txtValorParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdGuardar.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtNombParam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombParam.TextChanged
        Try
            If String.IsNullOrEmpty(txtNombParam.Text) Then
                Me.ErrorProvider1.SetError(txtNombParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdGuardar.Enabled = True
                blnCambio = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtNombParam_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombParam.Validating
        Try
            If String.IsNullOrEmpty(txtNombParam.Text) Then
                Me.ErrorProvider1.SetError(txtNombParam, "Campo obligatorio.")
                Me.cmdGuardar.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdGuardar.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

End Class

