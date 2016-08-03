
Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO

''' <summary>
''' Formulario Principal de Mantenimiento de Proveedores
''' Autor : Gelmin Martínez
''' Fecha : 12 de Mayo de 2010.
''' </summary>
''' <remarks></remarks>
Public Class frmSivProveedor
    Dim m_IDProveedor As Integer
    Dim DtProveedores As DataTable

    ' Variables para control de seguridad
    Dim blnAgregar As Boolean
    Dim blnAnular As Boolean
    Dim blnEditar As Boolean
    Dim blnConsultar As Boolean
    Dim blnImprimir As Boolean

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
    ''' <summary>
    ''' Procedimiento encargado de cargar los datos correspondientes a los proveedores.
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 12 de Mayo de 2010
    ''' </summary>
    ''' <remarks></remarks>
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
            Me.grdProveedores.SetDataBinding(Me.DtProveedores, "", True)
            Me.bloquearBotonesBarra(Me.DtProveedores.Rows.Count = 0)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 12 de Mayo de 2010.
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
    ''' <summary>
    ''' Procedimiento encargado de crear un nuevo Proveedor
    ''' Autor : Gelmin Martinez.
    ''' Fecha : 12 de Mayo de 2010.
    ''' </summary>
    ''' <remarks></remarks>
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
                    Me.grdProveedores.Row = iIndiceRegistro
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

        Try
            If Me.DtProveedores.Rows.Count > 0 Then
                objProveedorEditar = New frmSivProveedorEdit
                objProveedorEditar.TypeGui = 1
                If Not String.IsNullOrEmpty(Me.grdProveedores.Columns("SivProveedorID").Value.ToString) Then
                    objProveedorEditar.IDProveedor = Int32.Parse(Me.grdProveedores.Columns("SivProveedorID").Value.ToString)
                End If
                If objProveedorEditar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargaDatos()
                    If (Me.DtProveedores.Rows.Count <> 0) Then
                        iIndiceRegistro = Me.DtProveedores.DefaultView.Find(objProveedorEditar.IDProveedor)
                        Me.grdProveedores.Row = iIndiceRegistro
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Anular Proveedor"
    Private Function AnularProveedor() As Boolean
        'Dim T As New TransactionManager
        'Try
        '    Try

        '        T.BeginTran()
        '        SqlHelper.ExecuteCommand(sComando, T)
        '        T.CommitTran()

        '        Return True
        '    Catch ex As Exception
        '        T.RollbackTran()
        '        clsError.CaptarError(ex)
        '        Return False
        '    End Try
        'Finally
        '    T = Nothing
        'End Try

    End Function
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
        'If MsgBox("¿Seguro que desea anular el proveedor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
        '    Me.IDProveedor = Me.grdProveedores.Columns("SivProveedorID").Value
        '    If Me.AnularProveedor() Then
        '        MsgBox("Proveedor Anulado correctamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        '        Me.CargaDatos()
        '    End If
        'End If
    End Sub

    Private Sub cmdConsultarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarProveedor.Click
        If Me.grdProveedores.RowCount > 0 Then
            Me.IDProveedor = Me.grdProveedores.Columns("SivProveedorID").Value
            Me.Consultar_Proveedor()
        End If
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

    Private Sub grdProveedores_FilterChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdProveedores.FilterChange
        Me.grdProveedores.Caption = "Proveedores (" & Me.DtProveedores.Rows.Count & ")"
    End Sub

#End Region

End Class