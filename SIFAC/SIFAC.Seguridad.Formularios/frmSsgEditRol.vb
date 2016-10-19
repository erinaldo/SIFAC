Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Data.SqlClient

Public Class frmSsgEditRol

#Region "Declaracion de Variables locales a la Clase del formulario frmSsgEditAccion"
    Dim mRolID As Long
    Dim mAplicacionID As Long
    Dim mAccionID As Long
    Dim blnModifico As Boolean
    Dim mNombreRol As String
    Dim objRol As SsgRol
    Dim objAplicacion As SsgAplicacion
    'Dim objRolAccion As SsgRolAccion
    Dim AccionesDt As DataTable
    Dim RolAccionDt As DataTable
#End Region

#Region "Propiedades"
    Public Property RolID() As Long
        Get
            RolID = mRolID
        End Get
        Set(ByVal value As Long)
            mRolID = value
        End Set
    End Property

    Public Property AplicacionID() As Long
        Get
            AplicacionID = mAplicacionID
        End Get
        Set(ByVal value As Long)
            mAplicacionID = value
        End Set
    End Property

    Public Property NombreRol() As String
        Get
            Return mNombreRol
        End Get
        Set(ByVal value As String)
            mNombreRol = value
        End Set
    End Property

#End Region

#Region "Eventos del Formulario"
    Private Sub FormEditRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            EstablecerPropiedades()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '--------------------------------------------------------------------------------
    '-- Implementado Por        :   Juan Carlos Herrera Amador
    '-- Fecha de Implementacion :   10 de Septiembre del 2007
    '-- Descripcion             :   Configura propiedades al form y ciertos controles
    '---------------------------------------------------------------------------------
    Private Sub EstablecerPropiedades()
        Try
            '--- Instanciar ---
            objRol = New SsgRol
            objAplicacion = New SsgAplicacion
            CargarDatosAplicacion()
            CargarAcciones()

            If RolID = 0 Then
                Me.Text = "Agregar Rol"
            Else
                Me.Text = "Modificar Rol"
                CargarDatosRol()
            End If

            '--- Establecer tamaño máximo de los campos
            Me.txtNombre.MaxLength = SsgRol.GetMaxLength("Nombre")
            Me.txtDescripcion.MaxLength = SsgRol.GetMaxLength("Descripcion")

            '--- Obtener la Estructura de la tabla SsgRolAccion
            'RolAccionDt = SsgRolAccion.RetrieveDT("objRolID = " & RolID)
            'RolAccionDt.PrimaryKey = New DataColumn() {RolAccionDt.Columns("objAccionID")}
            RolAccionDt = SsgRolAccion.RetrieveDT("1=2")

            blnModifico = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos de los Botones Acepar-Cancelar"
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            If blnModifico Then
                Select Case MsgBox("¿Desea guardar los cambios ?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)
                    Case MsgBoxResult.Yes
                        SalvarRol()
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

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            SalvarRol()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Metodos Para la Edición de un Rol"
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   11 de Septiembre del 2007
    '-- Descripcion         :   Cargar los datos de la Aplicación a la cual 
    '--                         pertenece el Rol a moficar o pertenecerá
    '--                         el nuevo Rol en caso de la opción Agregar
    '--------------------------------------------------------------------------
    Private Sub CargarDatosAplicacion()
        Try
            objAplicacion.Retrieve(AplicacionID())

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
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   11 de Septiembre del 2007
    '-- Descripcion         :   Cargar los datos del Rol seleccionado.
    '--                         En el caso que se esté editando un dato.
    '----------------------------------------------------------------------------
    Private Sub CargarDatosRol()
        Try
            objRol.Retrieve(RolID)

            '-- Validación para evitar valores Nulos del Nombre
            If Not objRol.Nombre Is Nothing Then
                Me.txtNombre.Text = objRol.Nombre
            End If

            '-- Validación para evitar valores Nulos de la Descripción
            If Not objRol.Descripcion Is Nothing Then
                Me.txtDescripcion.Text = objRol.Descripcion
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   11 de Septiembre del 2007
    '--- Descripción        :   Cargar la lista de Acciones asociadas a los servicios de 
    '---                        de Usuario de los Módulos de la Aplicación seleccionada.
    '------------------------------------------------------------------------------------
    Private Sub CargarAcciones()
        Try

            If RolID = 0 Then
                AccionesDt = SsgAccionesAplicacion.ObtenerAccs(RolID, AplicacionID)
                Me.grdAcciones.SetDataBinding(AccionesDt, "", True)
            Else
                AccionesDt = SsgAccionesAplicacion.ObtenerAccs(RolID, AplicacionID)
                Me.grdAcciones.SetDataBinding(AccionesDt, "", True)
            End If

            '--- Configurar Grid --- 
            Me.grdAcciones.Columns(1).Tag = "BLOQUEADO"
            Me.grdAcciones.Columns(2).Tag = "BLOQUEADO"
            Me.grdAcciones.Columns(3).Tag = "BLOQUEADO"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   11 de Septiembre del 2007
    '-- Descripcion         :   Salva los datos del Rol según el modo:
    '                           RolID = 0 ; Crear nuevo Registro
    '                           RolID <> 0 ; Actualiza el registro 
    '-----------------------------------------------------------------------
    Private Sub SalvarRol()
        '--- Declaracion ---
        Dim T As New TransactionManager
        Dim drw As DataRow
        Try

            '-- Definición de valores a las propiedades de la Clase Rol
            objRol.Nombre = Me.txtNombre.Text.Trim
            objRol.objAplicacionID = AplicacionID

            '--- Campos no obligatorios
            If Me.txtDescripcion.Text.Trim.Length > 0 Then
                objRol.Descripcion = Me.txtDescripcion.Text.Trim
            End If

            '-- Inicio de la Transacción
            T.BeginTran()

            '--- Salvando el Rol
            If RolID = 0 Then
                objRol.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objRol.FechaCreacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos(0) Then
                    objRol.Insert(T)
                    '-- Asignación del Rol Actual
                    RolID = objRol.SsgRolID
                Else
                    Exit Sub
                End If

            Else
                objRol.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objRol.FechaModificacion = clsProyecto.Conexion.FechaServidor

                If ValidarDatos() Then
                    objRol.Update(T)
                    '-- Asignación del Rol Actual
                    RolID = objRol.SsgRolID
                Else
                    Exit Sub
                End If
            End If

            SsgRolAccion.DeleteByFilter("objRolID = " & RolID, T)
            '--- Salvando RolAccion
            For Each drwAcc As DataRow In AccionesDt.Rows
                If CBool(drwAcc("Marcado")) Then
                    drw = RolAccionDt.NewRow
                    drw("objAccionID") = drwAcc("SsgAccionID")
                    drw("objRolID") = RolID
                    drw("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    drw("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    drw("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                    drw("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                    RolAccionDt.Rows.Add(drw)
                End If
            Next

            'For Each drwAcc As DataRow In AccionesDt.Rows
            '    If CBool(drwAcc("Marcado")) And Not RolAccionDt.Rows.Contains(drwAcc("SsgAccionID")) Then
            '        drw = RolAccionDt.NewRow
            '        drw("objAccionID") = drwAcc("SsgAccionID")
            '        drw("objRolID") = RolID
            '        drw("UsuarioCreacion") = clsProyecto.Conexion.Usuario
            '        drw("FechaCreacion") = clsProyecto.Conexion.FechaServidor
            '        drw("UsuarioModificacion") = clsProyecto.Conexion.Usuario
            '        drw("FechaModificacion") = clsProyecto.Conexion.FechaServidor
            '        RolAccionDt.Rows.Add(drw)

            '    ElseIf RolAccionDt.Rows.Contains(drwAcc("SsgAccionID")) Then
            '        'Dim dr As DataRow
            '        'dr = RolAccionDt.Rows.Find(drwAcc("SsgAccionID"))
            '        'RolAccionDt.Rows.Remove(dr)
            '        End If
            'Next

            '-- Realiza la actualizacion por lote de los Detalle(SsgRolAccion) del Rol 
            SsgRolAccion.BatchUpdate(RolAccionDt.DataSet, T)

            '-- Confirmando la transacción
            T.CommitTran()
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


    '-------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        : Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    : 10 de Septiembre del 2007
    '-- Descripcion             : Verifica si ya existe un registro con los datos (Nombre)
    '--                         : para evitar que sean duplicados.
    '--------------------------------------------------------------------------------------------------
    Private Function ValidarDatos(Optional ByVal condicion As Short = 1) As Boolean
        Dim blnTieneAcciones As Boolean
        Try
            '--- Condicion:
            '--- 0 : Nuevo Registro
            '--- 1 : Modificación de un Registro

            '--- Campos Obligatorio ---

            If Me.txtNombre.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(Me.txtNombre, "Campo Obligatorio")
                Return False
            End If

            '--- Debe Asociarse al menos una acción
            For Each drw As DataRow In AccionesDt.Rows
                If CBool(drw("Marcado")) Then
                    blnTieneAcciones = True
                    Exit For
                End If
            Next

            If Not blnTieneAcciones Then
                MsgBox("Debe asociar al menos una acción al Rol.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ErrorProvider1.SetError(Me.grdAcciones, "Debe asociar al menos una acción al Rol.")
                Me.grdAcciones.Focus()
                Return False
            End If

            Select Case condicion
                Case 0
                    '--- Nombre no se duplique
                    If SsgRol.RetrieveDT("Nombre = '" & objRol.Nombre & "' And objAplicacionID = " & objRol.objAplicacionID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Rol con el Nombre -  " & objRol.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Return False
                    Else
                        Return True
                    End If
                Case 1
                    '--- Nombre no se duplique
                    If SsgRol.RetrieveDT("Nombre = '" & objRol.Nombre & "'" & "And SsgRolID <> " & RolID & " And objAplicacionID = " & objRol.objAplicacionID).Rows.Count > 0 Then
                        MsgBox("Ya existe un Rol con el Nombre -  " & objRol.Nombre, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
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

    Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        Try
            If (String.IsNullOrEmpty(txtNombre.Text.Trim)) Then
                Me.ErrorProvider1.SetError(txtNombre, "Campo Obligatorio")
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

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        Try
            blnModifico = True
            If (String.IsNullOrEmpty(txtNombre.Text.Trim)) Then
                Me.ErrorProvider1.SetError(txtNombre, "Campo Obligatorio")
                Me.cmdAceptar.Enabled = False
            Else
                Me.ErrorProvider1.Clear()
                Me.cmdAceptar.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Try
            blnModifico = True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos del Grid"
    Private Sub grdAcciones_Filter(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs)
        Try
            'XdsAcciones.FilterLocal(e.Condition)
            Me.grdAcciones.Caption = " Listado de Acciones (" + Me.grdAcciones.RowCount.ToString + " registros)"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

End Class