'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 12 Mayo 2010. 04:45 AM.
''-- Formulario de Edición y Modificación de Proveedor.
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas

Public Class frmSivProveedorEdit

#Region "Atributos"
    Private m_IdProveedor As Integer
    Private m_objPersonaId As String
    Private m_objContactoId As String
    Private m_objContactoIdTemp As String
    Private m_TypeGui As Integer
    Private m_IdTipoPersonaProveedor As Integer
    Private m_ModificoDetProvision As Boolean
    Private m_ModificoProveedor As Boolean
    Private dtDatosSivProveedor As DataTable
    Private dtContactoPrincipal As DataTable
    Private dtProveedorDetalleProvision As DataTable
    Private dtTerminoPago As DataTable
    Private intTerminoPagoCREDITO As Integer
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            TypeGui = Me.m_TypeGui
        End Get
        Set(ByVal value As Integer)
            Me.m_TypeGui = value
        End Set
    End Property

    Property IDProveedor() As Integer
        Get
            IDProveedor = Me.m_IdProveedor
        End Get
        Set(ByVal value As Integer)
            Me.m_IdProveedor = value
        End Set
    End Property

    Property objPersonaId() As String
        Get
            objPersonaId = Me.m_objPersonaId
        End Get
        Set(ByVal value As String)
            Me.m_objPersonaId = value
        End Set
    End Property

    Property objContactoId() As String
        Get
            objContactoId = Me.m_objContactoId
        End Get
        Set(ByVal value As String)
            Me.m_objContactoId = value
        End Set
    End Property

    Property IdTipoPersonaProveedor() As Integer
        Get
            IdTipoPersonaProveedor = Me.m_IdTipoPersonaProveedor
        End Get
        Set(ByVal value As Integer)
            Me.m_IdTipoPersonaProveedor = value
        End Set
    End Property

    Property ModificoDetProvision() As Boolean
        Get
            ModificoDetProvision = Me.m_ModificoDetProvision
        End Get
        Set(ByVal value As Boolean)
            Me.m_ModificoDetProvision = value
        End Set
    End Property

    Property ModificoProveedor() As Boolean
        Get
            ModificoProveedor = Me.m_ModificoProveedor
        End Get
        Set(ByVal value As Boolean)
            Me.m_ModificoProveedor = value
        End Set
    End Property

    Property objContactoIdTemp() As String
        Get
            objContactoIdTemp = Me.m_objContactoIdTemp
        End Get
        Set(ByVal value As String)
            Me.m_objContactoIdTemp = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Cargar datos proveedor"
    Private Sub CargaDatosProveedor()
        Dim sSQL, sCampos, sFiltro As String
        Try
            sCampos = "SivProveedorID, objPersonaID, objContactoID, FechaIngreso,  Activo"
            sFiltro = "SivProveedorID=" + Me.IDProveedor.ToString
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SivProveedor", sFiltro)

            Me.dtDatosSivProveedor = SqlHelper.ExecuteQueryDT(sSQL)
            'Cargar datos del proveedor
            Me.txtIdProveedor.Text = Me.IDProveedor
            Me.dtpFechaIngreso.Value = Me.dtDatosSivProveedor.DefaultView(0)("FechaIngreso")
            Me.chkActivo.Checked = Convert.ToBoolean(Me.dtDatosSivProveedor.DefaultView(0)("Activo"))

            'Cargar datos personales
            If Not String.IsNullOrEmpty(Me.dtDatosSivProveedor.DefaultView(0)("objPersonaID").ToString()) Then
                Me.objPersonaId = Me.dtDatosSivProveedor.DefaultView(0)("objPersonaID").ToString()
                Me.CargarDatosPersona(Me.objPersonaId)
            End If
            'Cargar Contacto principal
            If Not String.IsNullOrEmpty(Me.dtDatosSivProveedor.DefaultView(0)("objContactoID").ToString()) Then
                Me.objContactoId = Me.dtDatosSivProveedor.DefaultView(0)("objContactoID").ToString()
                Me.objContactoIdTemp = Me.objContactoId 'Mantener el id de contacto para verificar si el usuario lo actualiza
                Me.CargarDatosContactoPrincipal(Me.objContactoId)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

#End Region

#Region "Guardar proveedor"
    Private Function GuardarProveedor() As Boolean
        Dim T As New TransactionManager
        Dim objProveedor As New SivProveedor
        Dim dtDetalleProvision As New DataTable
        Dim fila As DataRow
        Try
            Try
                T.BeginTran()
                dtDetalleProvision = SivProveedorDetProvision.RetrieveDT("1=0")
                With objProveedor
                    .objPersonaID = Me.objPersonaId
                    If Not String.IsNullOrEmpty(Me.objContactoId) Then
                        .objContactoID = Me.objContactoId
                    End If
                    .FechaIngreso = Me.dtpFechaIngreso.Value
                    .Activo = Me.chkActivo.Checked
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .Insert(T)
                End With
                Me.IDProveedor = objProveedor.SivProveedorID

                'Isertar detalle de provisión                 
                Me.dtProveedorDetalleProvision.AcceptChanges()
                For Each row As DataRow In Me.dtProveedorDetalleProvision.Rows
                    fila = dtDetalleProvision.NewRow
                    If Not IsDBNull(row("objTipoProvisionID")) AndAlso row("objTipoProvisionID").ToString.Length <> 0 Then
                        fila("objTipoProvisionID") = row("objTipoProvisionID")
                        fila("objSivProveedorID") = Me.IDProveedor
                        fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        dtDetalleProvision.Rows.Add(fila)
                    End If
                Next

                dtDetalleProvision.TableName = "SivProveedorDetProvision"
                SivProveedorDetProvision.BatchUpdate(dtDetalleProvision.DataSet, T)

                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            objProveedor = Nothing
            dtDetalleProvision = Nothing
            T = Nothing
        End Try
    End Function
#End Region

#Region "Actualizar Proveedor"
    Private Function ActualizarProveedor() As Boolean
        Dim T As New TransactionManager
        Dim objProveedor As New SivProveedor
        Dim dtDetalleProvision As New DataTable
        Dim fila As DataRow
        Try
            Try
                If Me.ModificoProveedor Then 'verificar si hubo cambio en datos del proveedor
                    T.BeginTran()
                    With objProveedor

                        .Retrieve(Me.IDProveedor)
                        If Not Me.objContactoId Is Nothing AndAlso Not String.IsNullOrEmpty(Me.objContactoId.Trim) Then
                            If (Not Me.objContactoId.Equals(Me.objContactoIdTemp)) Then
                                .objContactoID = Me.objContactoId
                            End If
                        End If
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor
                        .Update(T)
                    End With

                    'Actualizar detalle de provisión   
                    dtDetalleProvision = SivProveedorDetProvision.RetrieveDT("1=0")
                    If Me.ModificoDetProvision Then
                        SivProveedorDetProvision.DeleteByFilter("objSivProveedorID=" + Me.IDProveedor.ToString, T)

                        Me.dtProveedorDetalleProvision.AcceptChanges()
                        For Each row As DataRow In Me.dtProveedorDetalleProvision.Rows
                            fila = dtDetalleProvision.NewRow
                            fila("objTipoProvisionID") = row("objTipoProvisionID")
                            fila("objSivProveedorID") = Me.IDProveedor
                            fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                            fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                            dtDetalleProvision.Rows.Add(fila)
                        Next

                        dtDetalleProvision.TableName = "SivProveedorDetProvision"
                        SivProveedorDetProvision.BatchUpdate(dtDetalleProvision.DataSet, T)
                    End If

                    T.CommitTran()
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            objProveedor = Nothing
            dtDetalleProvision = Nothing
            T = Nothing
        End Try
    End Function
#End Region

#Region "Cargar reporte"
    Private Sub CargarReporte(ByVal Reporte As String)
        'Dim objReportes As New frmStbVisor
        'Try
        '    Try
        '        Me.Cursor = Cursors.WaitCursor
        '        objReportes.IDReporte = Reporte
        '        objReportes.Width = frmPrincipal.Width - frmPrincipal.OutBarPrincipal.Width
        '        objReportes.Height = frmPrincipal.Height - frmPrincipal.MenuPrincipal.Height - frmPrincipal.stbPrincipal.Height
        '        objReportes.MdiParent = frmPrincipal
        '        objReportes.Show()
        '    Catch ex As Exception
        '        clsError.CaptarError(ex)
        '    End Try
        'Finally
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub
#End Region

#Region "Cargar datos persona"
    Private Sub CargarDatosPersona(ByVal sIdPersona As String)
        Dim dtPersona As DataTable
        Dim strCampos, strSQL, strFiltro As String

        Try

            strCampos = "NombreCompleto, Direccion, StbPersonaID, TelefonoParticular,objCiudadID"
            strFiltro = "StbPersonaID='" + sIdPersona + "'"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwPersonaClasificacion", strFiltro)

            dtPersona = SqlHelper.ExecuteQueryDT(strSQL)

            Me.txtNombreCompleto.Text = dtPersona.DefaultView.Item(0)("NombreCompleto")
            Me.txtDireccion.Text = dtPersona.DefaultView.Item(0)("Direccion")
            Me.txtCedulaRUC.Text = dtPersona.DefaultView.Item(0)("StbPersonaID")
            Me.txtTelefono.Text = dtPersona.DefaultView.Item(0)("TelefonoParticular")
            Me.txtDireccion.Text = dtPersona.DefaultView.Item(0)("Direccion")
            Me.cmbCiudad.SelectedValue = dtPersona.DefaultView.Item(0)("objCiudadID")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtPersona = Nothing
        End Try

    End Sub
#End Region

#Region "Cargar datos contacto principal"
    Private Sub CargarDatosContactoPrincipal(ByVal sIdPersona As String)
        Dim dtPersona As DataTable
        Dim strCampos, strSQL, strFiltro As String

        strCampos = "RTRIM(ISNULL(Nombre1,'')) + ' ' + RTRIM(ISNULL(Nombre2,'')) AS Nombres ,RTRIM(ISNULL(Apellido1,'')) + ' ' + RTRIM(ISNULL(Apellido2,'')) AS Apellidos, StbPersonaID, Celular, Email"
        strFiltro = "StbPersonaID='" + sIdPersona + "'"
        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwPersonaClasificacion", strFiltro)

        dtPersona = SqlHelper.ExecuteQueryDT(strSQL)
        If dtPersona.Rows.Count <> 0 Then
            'Mantener el Identificador del contacto principal deleccionado para el proveedor
            Me.objContactoId = dtPersona.DefaultView.Item(0)("StbPersonaID")

            Dim dtGrid As New DataTable
            'Agregar columnas
            dtGrid.Columns.Add("Etiqueta")
            dtGrid.Columns.Add("Valor")
            'Agregar filas
            dtGrid.Rows.Add("Nombres", dtPersona.DefaultView.Item(0)("Nombres"))
            dtGrid.Rows.Add("Apellidos", dtPersona.DefaultView.Item(0)("Apellidos"))
            dtGrid.Rows.Add("Móvil", dtPersona.DefaultView.Item(0)("Celular"))
            dtGrid.Rows.Add("Email", dtPersona.DefaultView.Item(0)("Email"))

            Me.grdContactoPrincipal.SetDataBinding(dtGrid, "", True)
            'Formatear Grid
            FormatearGridContactoPrincipal()
        End If
    End Sub
#End Region

#Region "Formatear grid"
    Private Sub FormatearGridContactoPrincipal()
        With Me.grdContactoPrincipal
            .FilterBar = False
            .ColumnHeaders = False
            .EmptyRows = False 'no mostrar más filas después de la última
            .Enabled = False 'bloquear el grid completo
           
            .Refresh()
        End With
    End Sub



#End Region

#Region "Bloquear controles"
    Private Sub BloquerarControles(ByVal bValor As Boolean)
        Me.txtIdProveedor.Enabled = Not bValor
        Me.dtpFechaIngreso.Enabled = Not bValor
        Me.cmdBuscarContacto.Enabled = Not bValor
        Me.cmdGuardar.Enabled = Not bValor
        Me.cmdBuscarProv.Enabled = Not bValor
        Me.cmdNuevoProv.Enabled = Not bValor
        Me.cmbCiudad.Enabled = Not bValor
        Me.txtDireccion.Enabled = Not bValor
       
    End Sub
#End Region


#End Region

#Region "Validaciones de datos"
    Private Function Validaciones() As Boolean
        Try
            If String.IsNullOrEmpty(Me.objPersonaId) Then
                MsgBox("Debe cargar los datos personales del Proveedor", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Eventos controles"
    Private Sub frmSivProveedorEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.ModificoProveedor And Me.TypeGui = 1 And Me.DialogResult <> Windows.Forms.DialogResult.OK Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub cmdNuevoProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevoProv.Click
        Dim objPers As frmClientesEdit
        objPers = New frmClientesEdit
        Try
            Select Case Me.TypeGui
                Case 0
                    objPers.TyGui = 1
                Case 1
                    objPers.TyGui = 2
                    objPers.idpersona = Me.objPersonaId
                Case 2
                    objPers.TyGui = 3
                    objPers.idpersona = Me.objPersonaId
            End Select
            If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.objPersonaId = objPers.idpersona
                If objPers.idpersona.Length <> 0 Then
                    CargarDatosPersona(objPers.idpersona)
                    Me.ModificoProveedor = True
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarProv.Click
        Try
            'Si estamos en modo consulta entonces mostrar los datos de persona
            If Me.TypeGui = 2 Then
                Dim objPers As frmClientesEdit
                objPers = New frmClientesEdit
                objPers.TyGui = 3
                objPers.idpersona = Me.objPersonaId
                If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.objPersonaId = objPers.idpersona
                    If objPers.idpersona.Length <> 0 Then
                        CargarDatosPersona(objPers.idpersona)
                        Me.ModificoProveedor = True
                    End If
                End If
            Else 'si no mostrar el selector de personas
                Dim frmSeleccionarPersona As New frmPersonaSelector
                frmSeleccionarPersona.strFiltro = "ObjTipoPersonaID=" + Me.IdTipoPersonaProveedor.ToString
                frmSeleccionarPersona.Opcion = 6 'Proveedores
                If frmSeleccionarPersona.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.objPersonaId = frmSeleccionarPersona.strSeleccion
                    CargarDatosPersona(frmSeleccionarPersona.strSeleccion)
                    Me.ModificoProveedor = True
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarContacto.Click
        Try
            Select Case Me.TypeGui
                Case 0, 1
                    Dim frmSeleccionarPersona As New frmPersonaSelector
                    If frmSeleccionarPersona.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        If Not String.IsNullOrEmpty(frmSeleccionarPersona.strSeleccion) Then
                            Me.objContactoId = frmSeleccionarPersona.strSeleccion
                            Me.CargarDatosContactoPrincipal(Me.objContactoId)
                            Me.ModificoProveedor = True
                            Me.cmdEditarContactoPrincipal.Enabled = True
                        End If
                    End If
                Case 2
                    Dim objPers As frmClientesEdit
                    objPers = New frmClientesEdit
                    objPers.TyGui = 3
                    objPers.idpersona = Me.objContactoId
                    If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.objContactoId = objPers.idpersona
                        If objPers.idpersona.Length <> 0 Then
                            Me.CargarDatosContactoPrincipal(objPers.idpersona)
                            Me.ModificoProveedor = True
                        End If
                    End If
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Select Case Me.TypeGui
                Case 0
                    If Me.Validaciones Then
                        If Me.GuardarProveedor Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    End If
                Case 1
                    If Me.Validaciones Then
                        If Me.ActualizarProveedor Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    End If
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIngreso.TextChanged
        Me.ErrorProvider.Clear()
      
    End Sub

    Private Sub grdTipoProvision_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
        Me.ModificoDetProvision = True
        Me.ModificoProveedor = True
    End Sub

#End Region

#Region "Cargar formulario"
    Private Sub frmSivProveedorEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            IdTipoPersonaProveedor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetIdTipoPersona('Proveedor') as ID").DefaultView.Item(0)("ID")

            clsProyecto.CargarTemaDefinido(Me)

            Select Case Me.TypeGui
                Case 0
                    Me.Text = "Nuevo Proveedor"
                    Me.dtpFechaIngreso.Value = clsProyecto.Conexion.FechaServidor
                    Me.cmdEditarContactoPrincipal.Enabled = False

                    Me.ttBotones.SetToolTip(Me.cmdNuevoProv, "Nuevo Proveedor")
                    Me.ttBotones.SetToolTip(Me.cmdBuscarProv, "Seleccionar Proveedor")
                    Me.ttBotones.SetToolTip(Me.cmdBuscarContacto, "Seleccionar Contacto principal")
                Case 1
                    Me.Text = "Editar Proveedor"
                    Me.CargaDatosProveedor()
                    Me.cmdNuevoProv.Enabled = True
                    Me.cmdBuscarProv.Enabled = True
                    Me.dtpFechaIngreso.Enabled = False
                    Me.cmdEditarContactoPrincipal.Enabled = True


                    Me.ttBotones.SetToolTip(Me.cmdNuevoProv, "Editar Proveedor")
                    Me.ttBotones.SetToolTip(Me.cmdBuscarProv, "Seleccionar Proveedor")
                    Me.ttBotones.SetToolTip(Me.cmdEditarContactoPrincipal, "Editar Contacto principal")
                    Me.ttBotones.SetToolTip(Me.cmdBuscarContacto, "Seleccionar Contacto")
                Case 2
                    Me.Text = "Consulta de Proveedor"
                    Me.CargaDatosProveedor()
                    Me.BloquerarControles(True)
                    Me.cmdBuscarProv.Enabled = True
                    Me.cmdEditarContactoPrincipal.Enabled = True

                    Me.ttBotones.SetToolTip(Me.cmdBuscarProv, "Consultar datos proveedor")
                    Me.ttBotones.SetToolTip(Me.cmdBuscarContacto, "Consultar datos contacto principal")
            End Select

            Me.FormatearGridContactoPrincipal()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

    Private Sub TabProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabProveedor.SelectedIndexChanged
        Me.cmdBuscarContacto.Visible = TabProveedor.SelectedIndex = 0
        Me.cmdEditarContactoPrincipal.Visible = TabProveedor.SelectedIndex = 0
    End Sub

    Private Sub cmdEditarContactoPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarContactoPrincipal.Click
        Dim objPers As frmClientesEdit
        objPers = New frmClientesEdit
        Try
            Select Case Me.TypeGui
                Case 0, 1
                    objPers.TyGui = 2
                Case 2
                    objPers.TyGui = 3
            End Select
            objPers.idpersona = Me.objContactoId
            If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.objContactoId = objPers.idpersona
                If objPers.idpersona.Length <> 0 Then
                    Me.CargarDatosContactoPrincipal(objPers.idpersona)
                    Me.ModificoProveedor = True
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSivProveedorEdit_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ModificoProveedor = False
        Me.ModificoDetProvision = False 'variable para verificar si se hacen cambios al grid de Provisión
    End Sub

 
End Class