
Imports Proyecto.Catalogos.Datos
Imports DAL
Imports GUI
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports System.Data.SqlClient
Imports System

Public Class frmStbEditValorCatalogo
#Region "Declaracion de Variables"
    Dim m_tipoAccion As Integer
    Dim m_IdCat As Integer
    Dim ObjValor As StbValorCatalogo
    Public ValorGuardado As Boolean
    Dim m_IdValCat As Integer
    Public InactivarCatalogo As Boolean
    Dim boolcambiohecho As Boolean
    Dim m_boolNuevoValorCatalogo As Boolean
#End Region
    
#Region "Propiedades"
    Public Property boolNuevoValorCat()
        Get
            boolNuevoValorCat = m_boolNuevoValorCatalogo
        End Get
        Set(ByVal value)
            m_boolNuevoValorCatalogo = value
        End Set
    End Property

    Public Property TipoUGID() As Integer
        Get
            Return m_tipoAccion
        End Get
        Set(ByVal value As Integer)
            m_tipoAccion = value
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

    Public Property IdValCat() As Integer
        Get
            Return m_IdValCat
        End Get
        Set(ByVal value As Integer)
            m_IdValCat = value
        End Set
    End Property

#End Region

#Region "Manipulacion de Datos"
    '--------------------------------------------------------------------------------------------------------------
    'Procedimiento     : GuardarDatos.
    'Autor             : Pedro Pablo Tinoco
    'Descripcion       : Función encargado de almacenar los datos correspondientes a los catalogos.
    'Fecha de Creacion : Lunes 15 de Octubre de 2007.
    '--------------------------------------------------------------------------------------------------------------
    Private Function GuardarDatos() As Boolean
        Dim boolRst As Boolean
        Dim parametroCod(2) As SqlParameter
        Dim dtCatalogo As DataTable
        Try
            If Me.txtCodInterno.Text = "" Or Me.txtDescripcion.Text = "" Then
                Return False
            End If
            boolRst = False
            Select Case m_tipoAccion

                Case 0 'Nuevo Valor Catalogo

                    '------------------------------En caso de Nuevo valor catalogo------------------------------------------
                    parametroCod(0) = New SqlParameter("@Codigo", SqlDbType.VarChar, 25)
                    parametroCod(0).Value = Me.txtCodInterno.Text
                    parametroCod(1) = New SqlParameter("@objCatalogoId", SqlDbType.Int, 4)
                    parametroCod(1).Value = Me.IdCat
                    dtCatalogo = SqlHelper.ExecuteQueryDT(clsConsultas.SqlDatosValores, parametroCod)

                    If dtCatalogo.Rows.Count = 0 Then
                        ObjValor.Codigo = Trim(Me.txtCodInterno.Text)
                        ObjValor.Descripcion = Trim(txtDescripcion.Text)
                        ObjValor.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        ObjValor.FechaCreacion = Now
                        ObjValor.Activo = chkActivo.Checked
                        ObjValor.objCatalogoId = Me.IdCat
                        ObjValor.Reservado = False
                        ObjValor.Insert()
                        boolRst = True
                        ValorGuardado = True
                        Me.IdValCat = ObjValor.StbValorCatalogoID
                    Else
                        Me.ErrorProv.SetError(Me.txtCodInterno, "Código Interno ya existe")
                        Exit Function
                    End If

                    '--------------------------------------------En caso de que sea actualizacin en vez de edicion-----------------------------    
                Case 1 'Modificar Valor Catalogo
                    ObjValor.Descripcion = Trim(txtDescripcion.Text)
                    ObjValor.Activo = chkActivo.Checked
                    ObjValor.FechaModificacion = Now
                    ObjValor.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    ObjValor.Update()
                    boolRst = True
                    ValorGuardado = True
            End Select

        Catch SQLex As SqlClient.SqlException
            clsError.CaptarError(SQLex)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return boolRst
    End Function

    '--------------------------------------------------------------------------------------------------------------
    'Procedimiento     : Verificar Existencias
    'Autor             :  Pedro Pablo Tinoco
    'Descripcion       : Funcion encargada de verificar que el valor catalogo es el ultimo dentro del catalogo.
    'Fecha de Creacion : Lunes 15 de Octubre de 2007.
    '--------------------------------------------------------------------------------------------------------------

    Private Function VerificarExistencias() As Integer
        Dim dtCantCatalogo As DataTable
        Dim parametro As SqlParameter
        Dim Cant As Integer
        Try
            parametro = New SqlParameter("@objCatalogoID", SqlDbType.Int, 4)
            parametro.Value = Me.IdCat
            dtCantCatalogo = SqlHelper.ExecuteQueryDT(ClsConsultas.SqlExistencia, parametro)
            If (dtCantCatalogo.Rows.Count = 1) Then
                Cant = dtCantCatalogo.Rows.Count
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Cant
    End Function

#End Region

#Region "Carga de Datos"
    '-----------------------------------Cargamos el los Valores Correspondientes a ese Valor de Catalogo------------------
    Private Sub frmValorCatalogo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        boolcambiohecho = False
        ErrorProv.Clear()
        ObjValor = New StbValorCatalogo
        Me.chkActivo.Checked = True
        Me.chkActivo.Enabled = False
        PropiedadesFormulario()
        clsProyecto.CargarTemaDefinido(Me)

        'En caso de que sea editar un Valor de Catalogo especifico   
        If Me.IdValCat > 0 Then
            ObjValor.Retrieve(Me.IdValCat)
            Me.txtCodInterno.Text = ObjValor.Codigo
            Me.txtCodInterno.Enabled = False
            Me.txtDescripcion.Text = ObjValor.Descripcion
            Me.chkActivo.Checked = ObjValor.Activo
            Me.chkActivo.Enabled = True
            Me.txtCodInterno.BackColor = System.Drawing.Color.LightYellow
        End If

        '-----------------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub PropiedadesFormulario()
        If Me.TipoUGID = 0 Then
            Me.Text = "Agregar Valor Catálogo"
            Me.Icon = My.Resources.AgregarIco
        Else
            Me.Text = "Modificar Valor Catálogo"
            Me.Icon = My.Resources.EditICO
        End If
    End Sub

#End Region

#Region "Manejo de Eventos"

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        VerificarGuardado()
    End Sub

    '-----------------------------------------------------------------------------------------------------
    '--Autor         : Pedro Pablo Tinoco Salgado.
    '--Fecha Cracion : 15 de octubre de 2007.
    '--Descripcion   : Esta función se encarga  de verificar que todos los datos esten corre
    '-----------------------------------------------------------------------------------------------------


    Private Function VerificarGuardado() As Boolean
        Dim DtCatalogo As New DataTable
        Dim parametro As SqlParameter
        Select Case Me.TipoUGID

            Case 0
                If GuardarDatos() Then
                    ActivarInactivarCatalogo(Me.IdCat, True)
                    Me.ValorGuardado = True
                    Me.chkActivo.Checked = True
                    parametro = New SqlParameter("@objCatalogoID", SqlDbType.Int, 4)
                    parametro.Value = Me.IdCat
                    DtCatalogo = SqlHelper.ExecuteQueryDT(clsConsultas.sqlDatosCatalogo, parametro)
                    
                    If MsgBox(My.Resources.MsgActualizado + "." + Chr(10) + "¿Desea crear otro valor de Catálogo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                        Me.txtCodInterno.Text = ""
                        Me.txtDescripcion.Text = ""
                        Me.txtCodInterno.Focus()
                        Me.boolNuevoValorCat = False
                        Me.ErrorProv.Clear()
                        Exit Function
                    Else
                        boolNuevoValorCat = False
                        Me.Close()
                    End If

                    Return True
                Else
                    Me.ErrorProv.SetError(Me.txtCodInterno, "Datos Incompletos.")
                    Me.ErrorProv.SetError(Me.txtDescripcion, "Datos Incompletos.")
                    Return False
                End If
            Case 1
                If GuardarDatos() Then
                    Me.ValorGuardado = True
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.Close()
                Else
                    Me.ErrorProv.SetError(Me.txtCodInterno, "Datos Incompletos.")
                    Me.ErrorProv.SetError(Me.txtDescripcion, "Datos Incompletos.")
                    boolNuevoValorCat = False
                    Return False
                End If
        End Select

    End Function


    Private Sub chkActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkActivo.Click
        boolcambiohecho = True
        If Me.chkActivo.Checked = False Then
            If VerificarExistencias() = 1 Then
                If MsgBox("El Catálogo correspodiente a este valor sera inhabilitado," + Chr(10) + " porque este es el ultimo valor activo." + Chr(10) + "¿Esta seguro de desactivar este valor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Me.chkActivo.Checked = False
                    InactivarCatalogo = True
                    Exit Sub
                Else
                    Me.chkActivo.Checked = True
                    InactivarCatalogo = False
                    Exit Sub
                End If
            End If
            Me.chkActivo.Checked = False
            InactivarCatalogo = False
        End If

    End Sub

    '---------------------------------------------------------------------------------------------------------
    ' Procedimiento  : ActivarInactivarCatalogo
    ' Autor          : Pedro Pablo Tinoco
    ' Fecha Creacion : 10-11-07
    ' Descripcion    : Procedimiento encargado de realizar modificar el estado de los catalogos.
    '---------------------------------------------------------------------------------------------------------
    Private Sub ActivarInactivarCatalogo(ByVal intCatalogo As Integer, ByVal boolOpcion As Boolean)
        Dim ObjCatalogo As New StbCatalogo
        Dim T As New TransactionManager

        Try
            T.BeginTran()

            ObjCatalogo.Retrieve(intCatalogo)
            ObjCatalogo.Activo = boolOpcion
            ObjCatalogo.UsuarioModificacion = clsProyecto.Conexion.Usuario
            ObjCatalogo.FechaModificacion = clsProyecto.Conexion.FechaServidor
            ObjCatalogo.StbCatalogoID = ObjCatalogo.StbCatalogoID

            ObjCatalogo.Update(T)
            T.CommitTran()
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub
    '------------------------------------------------------------------------------------------------------------

#End Region

#Region "Eventos de Validacion de Engtrada de Datos"

    Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodInterno.KeyPress
        If Not clsProyecto.LetrasYNumerosSinEspacio(e.KeyChar) Then
            e.Handled = True
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub
    Private Sub txtCodInterno_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodInterno.TextChanged
        Try
            If String.IsNullOrEmpty(Me.txtCodInterno.Text) Then
                Me.ErrorProv.SetError(Me.txtCodInterno, "Verifique los datos ingresados.")
                Me.cmdAceptar.Enabled = False
            Else
                Me.ErrorProv.Clear()
                Me.cmdAceptar.Enabled = True
                If Me.TipoUGID = 1 Then
                    If Trim(Me.txtCodInterno.Text) <> Trim(Me.ObjValor.Codigo) Then
                        boolcambiohecho = True
                    End If
                Else
                    boolcambiohecho = True
                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Try
            If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
                Me.ErrorProv.SetError(Me.txtDescripcion, "Verifique los datos ingresados.")
                Me.cmdAceptar.Enabled = False
            Else
                Me.ErrorProv.Clear()
                Me.cmdAceptar.Enabled = True
                If Me.TipoUGID = 1 Then
                    If Trim(Me.txtDescripcion.Text) <> Trim(Me.ObjValor.Descripcion) Then
                        boolcambiohecho = True
                    End If
                Else
                    boolcambiohecho = True
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtCodInterno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodInterno.Validating
        Try
            If boolcambiohecho Then
                If String.IsNullOrEmpty(Me.txtCodInterno.Text) Then
                    Me.ErrorProv.SetError(Me.txtCodInterno, "Verifique los datos ingresados.")
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

    Private Sub txtDescripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
        Try
            If boolcambiohecho = True Then
                If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
                    Me.ErrorProv.SetError(Me.txtDescripcion, "Verifique los datos ingresados.")
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

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If boolcambiohecho Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                If VerificarGuardado() Then
                    Me.Close()
                End If
            Else
                Me.boolNuevoValorCat = False
                Me.Close()
            End If
        Else
            Me.boolNuevoValorCat = False
            Me.Close()
        End If
    End Sub

#End Region

#Region "Clase Integrada"
    Private Class ClsConsultas
        Public Const SqlDatosValores As String = " SELECT Codigo " & _
                                             " FROM vwStbCatValores " & _
                                             " WHERE Codigo = @codigo AND objCatalogoId = @objCatalogoID"

        Public Const SqlExistencia As String = " SELECT *  " & _
                                          " FROM  vwStbCatValores " & _
                                          " WHERE objCatalogoId=@objCatalogoId and Activo=1"

        Public Const sqlDatosCatalogo As String = " SELECT Codigo,Descripcion,Activo " & _
                                             " FROM vwStbCatValores" & _
                                             " WHERE objCatalogoID = @objCatalogoID"

    End Class
#End Region

End Class