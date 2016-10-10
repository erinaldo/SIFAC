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
    Public Shared dtContactos As DataTable
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

#Region "Cargar combos"
    Private Sub CargarCiudad()
        Dim objparametro As StbParametro
        Dim objPais As StbPais
        Try
            objparametro = New StbParametro
            objPais = New StbPais

            'Ciudad
            objparametro.RetrieveByFilter("Nombre='Pais'")
            objPais.RetrieveByFilter("Nombre='" & objparametro.Valor & "'")

            frmClientesEdit.dtCiudad = StbCiudad.RetrieveDT("objPaisID=" & objPais.StbPaisID, "", "StbCiudadID,Nombre")
            Me.cmbCiudad.DataSource = frmClientesEdit.dtCiudad
            Me.cmbCiudad.DisplayMember = "Nombre"
            Me.cmbCiudad.ValueMember = "StbCiudadID"
            Me.cmbCiudad.Splits(0).DisplayColumns("StbCiudadID").Visible = False
            Me.cmbCiudad.ExtendRightColumn = True
            Me.cmbCiudad.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPais = Nothing
            objparametro = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Cargar datos proveedor"
    Private Sub CargaDatosProveedor()
        Dim sSQL, sCampos, sFiltro As String
        Dim objPersonas As StbPersona
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

            objPersonas = New StbPersona
            
            objPersonas.RetrieveByFilter("StbPersonaID=" + Me.objPersonaId)
            Me.txtRazonSocial.Text = objPersonas.RazonSocial
            Me.txtCedulaRUC.Text = objPersonas.RUC

            Me.cmbCiudad.SelectedValue = objPersonas.objCiudadID
            Me.txtDireccion.Text = objPersonas.Direccion

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

#End Region

#Region "Guardar proveedor"
    Private Function GuardarProveedor() As Boolean
        Dim objPersonas, objPCompara As StbPersona
        Dim T As New TransactionManager
        Dim objProveedor As New SivProveedor
        Try
            Try
                T.BeginTran()
                objPersonas = New StbPersona
                objPCompara = New StbPersona

                If Me.txtCedulaRUC.Text.Trim = "      -" Then
                    Me.ErrorProvider.SetError(Me.txtCedulaRUC, "Campo Obligatorio")
                    Exit Function
                End If

                If chkJuridico.Checked Then

                    '1.1 Validar que no exista una empresa con el mismo RUC
                    objPCompara.RetrieveByFilter("RUC='" + Me.txtCedulaRUC.Text + "'")
                    If objPCompara.RUC <> Nothing Then
                        Me.ErrorProvider.SetError(Me.txtCedulaRUC, "Ya existe una empresa con el mismo número RUC.")
                        Me.txtCedulaRUC.Focus()
                        Exit Function
                    End If
                    objPersonas.Nombre1 = ""
                    objPersonas.Apellido1 = ""
                    objPersonas.PersonaJuridica = 1
                    objPersonas.RazonSocial = Me.txtRazonSocial.Text.Trim
                    objPersonas.SiglasEmpresa = ""

                    If Me.txtCedulaRUC.Text.Trim = "-" Then
                        objPersonas.RUC = ""
                    Else
                        objPersonas.RUC = Me.txtCedulaRUC.Text.Trim
                    End If

                    objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
                    objPersonas.objCiudadID = cmbCiudad.SelectedValue
                    objPersonas.Direccion = txtDireccion.Text
                    objPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objPersonas.Insert(T)
                Else
                    '1.2 Validar que no exista  una persona con la misma cédula
                    objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedula.Text + "'")
                    If objPCompara.Cedula <> Nothing Then
                        Me.ErrorProvider.SetError(Me.txtCedula, "Ya existe una persona con la misma cédula.")
                        Me.txtCedula.Focus()
                        Exit Function
                    End If

                    'PROCEDER A INGRESAR
                    objPersonas.Nombre1 = txtNombre1.Text
                    objPersonas.Nombre2 = txtNombre2.Text
                    objPersonas.Apellido1 = txtApellido1.Text
                    objPersonas.Apellido2 = txtApellido2.Text
                    objPersonas.objGeneroID = cmbGenero.SelectedValue

                    If Me.txtCedula.Text.Trim <> "-      -" Then
                        objPersonas.Cedula = Me.txtCedula.Text
                    Else
                        objPersonas.Cedula = Nothing
                    End If
                    If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                        objPersonas.FechaNacimiento = Me.dtpFechaNacimiento.Text
                    Else
                        objPersonas.FechaNacimiento = Nothing
                    End If

                    objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
                    objPersonas.objCiudadID = cmbCiudadNatural.SelectedValue
                    objPersonas.Direccion = txtDireccion.Text
                    objPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objPersonas.Direccion = txtdireccionNatural.Text.Trim

                    objPersonas.Insert(T)

                End If


                Me.objPersonaId = objPersonas.StbPersonaID

                objProveedor.objPersonaID = Me.objPersonaId
                objProveedor.Activo = 1
                objProveedor.FechaIngreso = dtpFechaIngreso.Value
                objProveedor.objContactoID = objContactoId
                objProveedor.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objProveedor.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objProveedor.Insert(T)
                Me.InsertarDetalle(Me.objPersonaId)

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

            T = Nothing
        End Try
    End Function
#End Region

#Region "Modificar Detalle de Personas"
    Private Sub ModificarDetalle()

        Try
            StbPersonaClasificacion.DeleteByFilter("objTipoPersonaID = (SELECT StbTipoPersonaID FROM StbTipoPersona WHERE Descripcion='Cliente') AND objPersonaID=" + Me.objPersonaId)
            StbContactos.DeleteByFilter("objPersonaID='" + Me.objPersonaId + "'")

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Actualizar Proveedor"
    Private Function ActualizarProveedor() As Boolean
        Dim T As New TransactionManager
        Dim objProveedor As New SivProveedor
        Dim objPersonas As StbPersona
        Try
            Try
                objPersonas = New StbPersona
                objPersonas.Retrieve(Me.objPersonaId)

                If chkJuridico.Checked Then
                    If Me.ModificoProveedor Then 'verificar si hubo cambio en datos del proveedor
                        T.BeginTran()
                        With objPersonas
                            .RazonSocial = Me.txtRazonSocial.Text.Trim
                            .objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
                            .objCiudadID = cmbCiudad.SelectedValue
                            .Direccion = txtDireccion.Text
                            .Update(T)
                        End With
                    Else
                        objPersonas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objPersonas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objPersonas.Nombre1 = Me.txtNombre1.Text.Trim
                        objPersonas.Nombre2 = Me.txtNombre2.Text.Trim
                        objPersonas.Apellido1 = Me.txtApellido1.Text.Trim
                        objPersonas.Apellido2 = Me.txtApellido2.Text.Trim
                        objPersonas.objGeneroID = Me.cmbGenero.SelectedValue

                        If Me.txtCedula.Text.Trim <> "-      -" Then
                            objPersonas.Cedula = Me.txtCedula.Text
                        Else
                            objPersonas.Cedula = Nothing
                        End If
                        If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                            objPersonas.FechaNacimiento = Me.dtpFechaNacimiento.Text
                        Else
                            objPersonas.FechaNacimiento = Nothing
                        End If
                        objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
                        objPersonas.objCiudadID = cmbCiudadNatural.SelectedValue
                        objPersonas.Direccion = txtdireccionNatural.Text

                        objPersonas.Update(T)
                    End If

                    With objProveedor

                        .Retrieve(Me.IDProveedor)
                        If Not Me.objContactoId Is Nothing AndAlso Not String.IsNullOrEmpty(Me.objContactoId.Trim) Then
                            If (Not Me.objContactoId.Equals(Me.objContactoIdTemp)) Then
                                .objContactoID = Me.objContactoId
                            End If
                        End If
                        .Activo = 1
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor
                        .Update(T)
                    End With

                    Me.ModificarDetalle()
                    Me.InsertarDetalle(Me.objPersonaId)

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

            Me.txtRazonSocial.Text = dtPersona.DefaultView.Item(0)("NombreCompleto")
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
            'If String.IsNullOrEmpty(Me.objPersonaId) Then
            '    MsgBox("Debe cargar los datos personales del Proveedor", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            '    Return False
            '    Exit Function
            'End If

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
                    objPers.Text = "Nuevo Proveedor"
                Case 1
                    objPers.TyGui = 2
                    objPers.idpersona = Me.objPersonaId
                    objPers.Text = "Proveedor"
                Case 2
                    objPers.TyGui = 3
                    objPers.idpersona = Me.objPersonaId
                    objPers.Text = "Proveedor"
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
            CargarCiudad()
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

#Region "Eliminar Contactos"
    Private Sub EliminarContactos()
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                frmSivProveedorEdit.dtContactos.Rows.RemoveAt(Me.tdbContactos.Row)
            Else
                Exit Sub
            End If
            If frmSivProveedorEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            End If
            Me.tdbContactos.Caption = "Contactos (" & frmSivProveedorEdit.dtContactos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Guardar Contactos Temporalmente"
    Private Sub GuardarContactosTemp()
        Try
            Dim objContactos As frmStbPersonasContactos
            objContactos = New frmStbPersonasContactos
            objContactos.frmLLamado = 2
            objContactos.ShowDialog()
            If frmSivProveedorEdit.dtContactos.Rows.Count > 0 Then
                Me.cmdEliminarContacto.Enabled = True
            End If
            Me.tdbContactos.Caption = "Contactos (" & frmSivProveedorEdit.dtContactos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Insertar Detalle de Personas"

    Private Sub InsertarDetalle(ByVal IDGenerado As String)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            'Guardar Contactos
            For Each dr As DataRow In frmSivProveedorEdit.dtContactos.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objContactos.Insert()
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Cliente'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objClasifica.Insert()


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
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


    Private Sub cmdAgregarContacto_Click(sender As Object, e As EventArgs) Handles cmdAgregarContacto.Click
        Try
            Me.GuardarContactosTemp()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarContacto_Click(sender As Object, e As EventArgs) Handles cmdEliminarContacto.Click
        Try
            Me.EliminarContactos()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub LimpiarControlesNaturalJuridico(boolNatural As Boolean)
        Try
            Select Case boolNatural
                Case True
                    txtNombre1.Text = String.Empty
                    txtNombre2.Text = String.Empty
                    txtApellido1.Text = String.Empty
                    txtApellido2.Text = String.Empty
                    txtCedula.Text = String.Empty
                    cmbGenero.Text = String.Empty
                    cmbCiudadNatural.Text = String.Empty
                    dtpFechaNacimiento.Text = String.Empty
                    txtdireccionNatural.Text = String.Empty
                    gbxDatosJuridico.Visible = True
                    grbDatosNatural.Visible = False
                Case False
                    txtRazonSocial.Text = String.Empty
                    dtpFechaIngreso.Text = String.Empty
                    txtDireccion.Text = String.Empty
                    cmbCiudad.Text = String.Empty
                    gbxDatosJuridico.Visible = False
                    grbDatosNatural.Visible = True
            End Select


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkJuridico_CheckedChanged(sender As Object, e As EventArgs) Handles chkJuridico.CheckedChanged
        If chkJuridico.Checked Then
            LimpiarControlesNaturalJuridico(True)
        Else
            LimpiarControlesNaturalJuridico(False)
        End If
    End Sub
End Class