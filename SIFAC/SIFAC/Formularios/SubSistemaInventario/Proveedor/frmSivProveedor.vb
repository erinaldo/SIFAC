
Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO


Public Class frmSivProveedor

#Region "Declaracion de Variables Globales"

    Dim m_IDProveedor As Integer
    Dim DtProveedores As DataTable

    ' Variables para control de seguridad
    Dim blnAgregar As Boolean
    Dim blnAnular As Boolean
    Dim blnEditar As Boolean
    Dim blnConsultar As Boolean
    Dim blnImprimir As Boolean

#End Region

#Region "Propiedades"
    Property IDProveedor() As Integer
        Get
            IDProveedor = Me.m_IDProveedor
        End Get
        Set(ByVal value As Integer)
            Me.m_IDProveedor = value
        End Set
    End Property
#End Region

#Region "Cargar Datos"

    Private Sub CargaDatos()
        Dim sSQL, sCampos, sFiltro As String

        sCampos = "SivProveedorID, StbPersonaID, Nombre1, Nombre2, Apellido1, Apellido2, Telefonos, Activo"
        sFiltro = "1=1 ORDER BY Nombre1"

        Try
            Me.DtProveedores = New DataTable
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivProveedores", sFiltro)
            Me.DtProveedores = SqlHelper.ExecuteQueryDT(sSQL)
            Me.DtProveedores.PrimaryKey = New DataColumn() {Me.DtProveedores.Columns("SivProveedorID")}
            Me.DtProveedores.DefaultView.Sort = "SivProveedorID"
            grdvwProveedores.DataSource = DtProveedores
            'Me.grdProveedores.SetDataBinding(Me.DtProveedores, "", True)
            Me.bloquearBotonesBarra(Me.DtProveedores.Rows.Count = 0)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Seguridad"

    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSIVPROVEEDOR"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAgregar = objSeg.TienePermiso("AGREGARSIVPROVEEDOR")
            Me.blnAnular = objSeg.TienePermiso("ANULARSIVPROVEEDOR")
            Me.blnEditar = objSeg.TienePermiso("EDITARSIVPROVEEDOR")
            Me.blnImprimir = objSeg.TienePermiso("IMPRIMIRSIVPROVEEDOR")
            Me.blnConsultar = objSeg.TienePermiso("CONSULTARSIVPROVEEDOR")

            'Aplicar permisos a los comandos
            Me.cmdAgregarProveedor.Enabled = Me.blnAgregar
            Me.cmdEditarProveedor.Enabled = Me.blnEditar
            Me.cmdAnularProveedor.Enabled = Me.blnAnular
            Me.cmdImprimir.Enabled = Me.blnImprimir
            Me.cmdConsultarProveedor.Enabled = Me.blnConsultar

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Procedimientos"

#Region " Nuevo Proveedor"
    Private Sub Nuevo_Proveedor()
        Dim objProveedorEditar As frmSivProveedorEdit
        Dim iIndiceRegistro As Integer

        Try
            objProveedorEditar = New frmSivProveedorEdit
            objProveedorEditar.TypeGui = 0
            If objProveedorEditar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargaDatos()
                If (Me.DtProveedores.Rows.Count <> 0) Then
                    iIndiceRegistro = Me.DtProveedores.DefaultView.Find(objProveedorEditar.IDProveedor)
                    'Me.grdProveedores.Row = iIndiceRegistro
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Editar Proveedor"
    Private Sub Editar_Proveedor()
        Dim objProveedorEditar As frmSivProveedorEdit
        Dim iIndiceRegistro As Integer
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdvwProveedoresTabla.FocusedRowHandle
            If Me.DtProveedores.Rows.Count > 0 Then
                objProveedorEditar = New frmSivProveedorEdit
                objProveedorEditar.TypeGui = 1
                If Not String.IsNullOrEmpty(Me.DtProveedores.DefaultView.Item(FilaActual)("SivProveedorID")) Then
                    objProveedorEditar.IDProveedor = Int32.Parse(Me.DtProveedores.DefaultView.Item(FilaActual)("SivProveedorID"))
                End If
                If objProveedorEditar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargaDatos()
                    If (Me.DtProveedores.Rows.Count <> 0) Then
                        iIndiceRegistro = Me.DtProveedores.DefaultView.Find(objProveedorEditar.IDProveedor)
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Consultar Proveedor"
    Private Sub Consultar_Proveedor()
        Dim objFormProveedorEdit As frmSivProveedorEdit
        Try
            objFormProveedorEdit = New frmSivProveedorEdit
            objFormProveedorEdit.TypeGui = 2
            objFormProveedorEdit.IDProveedor = Me.IDProveedor
            objFormProveedorEdit.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Imprimir Proveedores"
    Public Sub ImprimirProveedores()
        Dim objReporte As frmSivReporteProveedor
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSivReporteProveedor", Me) Then
                    objReporte = New frmSivReporteProveedor
                    objReporte.StartPosition = FormStartPosition.CenterScreen
                    'objReporte.MdiParent = Me
                    objReporte.ShowDialog()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#End Region

#Region "Bloquear botones barra"
    Private Sub bloquearBotonesBarra(ByVal bValor As Boolean)
        Me.cmdAnularProveedor.Enabled = (Not bValor) And blnAnular
        Me.cmdEditarProveedor.Enabled = (Not bValor) And blnEditar
        Me.cmdConsultarProveedor.Enabled = (Not bValor) And blnConsultar
        Me.cmdImprimir.Enabled = (Not bValor) And blnImprimir
    End Sub
#End Region

#Region "Eventos"

    Private Sub frmSivProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.AplicarSeguridad()
        Me.CargaDatos()
    End Sub

    Private Sub cmdAgregarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarProveedor.Click
        Call Me.Nuevo_Proveedor()
    End Sub

    Private Sub cmdEditarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarProveedor.Click
        Me.Editar_Proveedor()
    End Sub

    Private Sub cmdAnularProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnularProveedor.Click
        Dim IDProveedor As Integer
        Dim Proveedor As New SivProveedor
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdvwProveedoresTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar el Proveedor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Proveedor = Me.DtProveedores.DefaultView.Item(FilaActual)("SivProveedorID")
                    Proveedor.Retrieve(IDProveedor)
                    Proveedor.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Proveedor.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Proveedor.Activo = False
                    Proveedor.Update()
                    Me.CargaDatos()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Proveedor = Nothing
        End Try
    End Sub

    Private Sub cmdConsultarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarProveedor.Click
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdvwProveedoresTabla.FocusedRowHandle

            If Me.grdvwProveedoresTabla.RowCount > 0 Then
                Me.IDProveedor = Me.DtProveedores.DefaultView.Item(FilaActual)("SivProveedorID")
                Me.Consultar_Proveedor()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Me.ImprimirProveedores()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Me.CargaDatos()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub grdProveedores_FilterChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.grdvwProveedores.Text = "Proveedores (" & Me.DtProveedores.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

End Class