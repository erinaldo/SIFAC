Imports Proyecto.Catalogos.Datos
Imports DAL
Imports GUI
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports System.Data.SqlClient

Public Class frmCatalogoAdd

#Region "Propiedades"
    Dim m_TipoAccion As Integer
    Dim m_IdCat As Integer
    Dim objCat As StbCatalogo
    Dim objVal As StbValorCatalogo
    Dim Nombre As String
    Dim dtvalores As DataTable
    Dim dtCatalogo As DataTable
    Dim parametro As SqlParameter
    Public Valorg As Boolean
    Dim boolCambiohecho As Boolean
    Dim m_boolNuevoCatalogo As Boolean
#End Region

#Region "Propiedades"

    Public Property BoolnuevoCatalogo()
        Get
            BoolnuevoCatalogo = m_boolNuevoCatalogo
        End Get
        Set(ByVal value)
            m_boolNuevoCatalogo = value
        End Set
    End Property

    Public Property TipoUGID() As Integer
        Get
            Return m_TipoAccion
        End Get
        Set(ByVal value As Integer)
            m_TipoAccion = value
        End Set
    End Property

    Public Property IdCat() As Integer
        Get
            Return m_IdCat
        End Get
        Set(ByVal value As Integer)
            m_IdCat = value
        End Set
    End Property

#End Region

#Region "Cargar de Datos"
    Private Sub frmCatalogoAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '---------------Seteamos propiedaes generales-------------------
        boolCambiohecho = False
        objCat = New StbCatalogo
        objVal = New StbValorCatalogo
        Me.chkActivo.Enabled = False
        Me.chkActivo.Checked = False
        Me.cmdValor.Enabled = False
        PropiedadesFormulario()
        clsProyecto.CargarTemaDefinido(Me)
        '----------------------------------------------------------------

        '--------------------En Caso de que entremos en Modo de Edicion---------------------
        If Me.IdCat > 0 Then
            objCat.Retrieve(Me.IdCat)
            Me.txtNombre.Text = objCat.Nombre
            Me.txtDescripcion.Text = objCat.Descripcion
            Me.chkActivo.Checked = objCat.Activo
            Me.cmdValor.Enabled = True
            Nombre = Trim(Me.txtNombre.Text)

            '--Validamos que el catalogo actual no tenga ningun valor asociado.-------------
            parametro = New SqlParameter("@objCatalogoID", SqlDbType.Int, 4)
            parametro.Value = Me.IdCat
            dtCatalogo = SqlHelper.ExecuteQueryDT(ClsConsultas.sqlDatosCatalogo, parametro)

            If dtCatalogo.Rows.Count = 0 Then
                Me.txtNombre.Enabled = True
            End If
            '------------------------------------------------------------------------------

            Me.grdDatosvalores.SetDataBinding(dtCatalogo, "", True)
            Me.cmdAceptar.Enabled = False
            Me.txtNombre.Enabled = False
            Me.txtNombre.Tag = "BLOQUEADO"
            Me.txtNombre.BackColor = System.Drawing.Color.LightYellow
            clsProyecto.CargarTemaDefinido(Me)
        End If
        '---------------------------------------------------------------------------------

    End Sub

    '-------------------------Seteamos las propiedades principales del Formulario----------------------------
    Private Sub PropiedadesFormulario()
        If Me.TipoUGID = 0 Then
            Me.Text = "Agregar Catálogo"
            Me.Icon = My.Resources.AgregarIco
        Else
            Me.Text = "Modificar Catálogo"
            Me.Icon = My.Resources.EditICO
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------
#End Region

#Region "Region de Almacenamiento de Datos"
    '--------------------------------------------------------------------------------------------------------------
    'Procedimiento     : GuardarDatos.
    'Autor             :  Pedro Pablo Tinoco
    'Descripcion       : Procedimiento encargado de almacenar los datos correspondientes a los catalogos.
    'Fecha de Creacion : Lunes 15 de Octubre de 2007.
    '--------------------------------------------------------------------------------------------------------------
    Private Function GuardarDatos() As Boolean
        Dim T As New TransactionManager
        Dim boolRst As Boolean
        Try
            boolRst = False
            T.BeginTran()
            Select Case m_TipoAccion
                '-----------En caso de ser un nuevo catalogo----------------------------------
                Case 0
                    If Not objCat.RetrieveByFilter("Nombre='" & Trim(txtNombre.Text) & "'") Then
                        objCat.Nombre = Trim(txtNombre.Text)
                        objCat.Descripcion = Trim(txtDescripcion.Text)
                        objCat.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objCat.FechaCreacion = Now
                        objCat.Activo = chkActivo.Checked
                        objCat.Insert()
                        boolRst = True
                        Me.IdCat = objCat.StbCatalogoID
                    Else
                        Me.ErrorProv.SetError(Me.txtNombre, "Nombre de Catálogo ya existe.")
                        Exit Function
                    End If
                    '------------En caso de ser un proceso de edición------------------------------
                Case 1
                    If txtNombre.Text <> Nombre Then
                        dtCatalogo = StbCatalogo.RetrieveDT("Nombre='" & Trim(txtNombre.Text) & "'")
                        If dtCatalogo.Rows.Count > 0 Then
                            MsgBox("Nombre de Catálogo ya existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                            Exit Function
                        End If
                    End If
                    objCat.Nombre = Trim(txtNombre.Text)
                    objCat.Descripcion = Trim(txtDescripcion.Text)
                    objCat.FechaModificacion = Now
                    objCat.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objCat.Activo = chkActivo.Checked
                    objCat.Update()
                    boolRst = True
            End Select
            T.CommitTran()

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return boolRst
    End Function
#End Region

#Region "Carga de Datos Externos"
    '---------------------------------------------------------------------------------------------------------------------
    '-- Autor          : Pedro Pablo Tinoco Salgado.
    '-- Fecha Creacion : 15 de Octubre de 2007.
    '-- Descripcion    : Esta funcio se encarga de realizar el proceso de mandar a llamar el formulario de nuevo valor catalogo
    '------------------: ya sea en modo de edicion porque se invoca desde la edicion de catalogos.
    '---------------------------------------------------------------------------------------------------------------------

    Private Sub CargarValorCatalogo()
        Dim objForm As frmStbEditValorCatalogo
        Try
            '-- Instanciar al formulario de agregar Catalogo.
            objForm = New frmStbEditValorCatalogo
            objForm.IdCat = Me.IdCat
            objForm.ShowDialog(Me)

            If objForm.ValorGuardado Then
                Me.chkActivo.Checked = True
                Me.Valorg = True
                dtCatalogo = SqlHelper.ExecuteQueryDT(ClsConsultas.sqlDatosCatalogo, parametro)
                Me.grdDatosvalores.SetDataBinding(dtCatalogo, "", True)
                Me.cmdAceptar.Enabled = True
                Me.boolCambiohecho = True

                If objForm.boolNuevoValorCat Then
                    objForm = Nothing
                    CargarValorCatalogo()
                End If

            End If



        Catch SQLex As SqlClient.SqlException
            clsError.CaptarError(SQLex)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

#End Region

#Region "Manipulacion de Eventos"

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not clsProyecto.LetrasYNumerosSinEspacio(e.KeyChar) Then
            e.Handled = True
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
            Me.cmdAceptar.Enabled = True
        End If
        boolCambiohecho = True
    End Sub

    Private Sub cmdValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdValor.Click
        CargarValorCatalogo()
    End Sub


#End Region

#Region " Cancelar y Aceptar"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.txtNombre.Text.Trim.Length = 0 Then
            ErrorProv.SetError(Me.txtNombre, "Campo obligatorio")
            Me.cmdAceptar.Enabled = False
            Exit Sub
        End If

        Select Case Me.TipoUGID
            Case 0
                If GuardarDatos() Then
                    If MsgBox(My.Resources.MsgAgregado + "." + "¿Desea crear otro Catálogo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                        Me.Valorg = True
                        Me.txtNombre.Text = ""
                        Me.txtDescripcion.Text = ""
                        Me.BoolnuevoCatalogo = True
                        Me.Close()
                    Else
                        Me.Valorg = True
                        Me.Close()
                    End If
                End If

            Case 1
                If GuardarDatos() Then
                    Me.Valorg = True
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If boolCambiohecho Then

            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then

                If Me.txtNombre.Text.Trim.Length = 0 Then
                    Me.ErrorProv.SetError(Me.txtNombre, "Campo obligatorio")
                    Me.cmdAceptar.Enabled = False
                    Exit Sub
                End If

                Select Case Me.TipoUGID
                    Case 0
                        If GuardarDatos() Then
                            If MsgBox(My.Resources.MsgAgregado + "." + "¿Desea crear otro Catálogo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ClsProyecto.SiglasSistema") = MsgBoxResult.Yes Then
                                Me.Valorg = True
                                Me.txtNombre.Text = ""
                                Me.txtDescripcion.Text = ""
                                Me.txtNombre.Focus()
                            Else
                                Me.Valorg = True
                                Me.Close()
                            End If
                        End If

                    Case 1
                        If GuardarDatos() Then
                            Me.Valorg = True
                            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                            Me.Close()
                        End If
                End Select
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region "Eventos de Validacion de textbox"
    Private Sub txtNombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        Try
            If String.IsNullOrEmpty(Me.txtNombre.Text) Then
                Me.ErrorProv.SetError(Me.txtNombre, "Campo Obligatorio")
                Me.cmdAceptar.Enabled = False
            Else
                Me.ErrorProv.Clear()
                Me.cmdAceptar.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        Try
            If boolCambiohecho Then
                If String.IsNullOrEmpty(Me.txtNombre.Text) Then
                    Me.ErrorProv.SetError(Me.txtNombre, "Campo Obligatorio")
                    Me.cmdAceptar.Enabled = False
                Else
                    Me.ErrorProv.Clear()
                    Me.cmdAceptar.Enabled = True
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try


    End Sub



    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Me.cmdAceptar.Enabled = True
        boolCambiohecho = True
    End Sub

    Private Sub grdDatosvalores_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs)
        boolCambiohecho = True
    End Sub





    Private Sub lblDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDescripcion.TextChanged
        boolCambiohecho = True
    End Sub

    Private Sub grdDatosvalores_AfterUpdate1(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDatosvalores.AfterUpdate
        boolCambiohecho = True
    End Sub

#End Region

#Region "Clase Privada"

    Private Class ClsConsultas
        Public Const sqlDatosCatalogo As String = " SELECT Codigo,Descripcion,Activo " & _
                                                    " FROM vwStbCatValores" & _
                                                    " WHERE objCatalogoID = @objCatalogoID"

    End Class
#End Region

End Class


