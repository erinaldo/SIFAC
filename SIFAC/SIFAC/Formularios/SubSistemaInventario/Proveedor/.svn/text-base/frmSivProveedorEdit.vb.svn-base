'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 12 Mayo 2010. 04:45 AM.
''-- Formulario de Edición y Modificación de Proveedor.
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.Cursors
Imports SCCUM.BO.clsConsultas

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

#Region "Cargar Combo Término Pago"

    Private Sub CargarTerminoPago()
        Try
            dtTerminoPago = ClsCatalogos.GetValoresCatalogo("TERMINOPAGO", "StbValorCatalogoID, Descripcion", "Descripcion")
            With Me.cmbTerminoPago
                .DataSource = dtTerminoPago
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#Region "Cargar datos proveedor"
    Private Sub CargaDatosProveedor()
        Dim sSQL, sCampos, sFiltro As String
        sCampos = "SivProveedorID, objPersonaID, objContactoID, FechaIngreso, FechaEgreso, Activo, objTerminoPagoID, PlazoCredito"
        sFiltro = "SivProveedorID=" + Me.IDProveedor.ToString
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SivProveedor", sFiltro)

        Me.dtDatosSivProveedor = SqlHelper.ExecuteQueryDT(sSQL)
        'Cargar datos del proveedor
        Me.txtIdProveedor.Text = Me.IDProveedor
        Me.dtpFechaIngreso.Value = Me.dtDatosSivProveedor.DefaultView(0)("FechaIngreso")
        Me.chkActivo.Checked = Convert.ToBoolean(Me.dtDatosSivProveedor.DefaultView(0)("Activo"))
        If Not String.IsNullOrEmpty(Me.dtDatosSivProveedor.DefaultView(0)("FechaEgreso").ToString()) Then
            Me.dtpFechaEgreso.Value = Me.dtDatosSivProveedor.DefaultView(0)("FechaEgreso").ToString()
        End If
        Me.cmbTerminoPago.SelectedValue = Me.dtDatosSivProveedor.DefaultView(0)("objTerminoPagoID")
        Me.numPlazoCredito.Value = Me.dtDatosSivProveedor.DefaultView(0)("PlazoCredito")

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
        'Cargar el detalle de provisión.
        Me.CargarProveedorDetalleProvision()
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
                    .objTerminoPagoID = Me.cmbTerminoPago.SelectedValue
                    .PlazoCredito = Me.numPlazoCredito.Value
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

                        If Not Me.dtpFechaEgreso.ValueIsDbNull Then
                            .FechaEgreso = Me.dtpFechaEgreso.Value
                            .Activo = False
                        End If

                        .objTerminoPagoID = Me.cmbTerminoPago.SelectedValue
                        .PlazoCredito = Me.numPlazoCredito.Value

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

        strCampos = "NombreCompleto, Direccion, StbPersonaID, TelefonoParticular, Nacionalidad"
        strFiltro = "StbPersonaID='" + sIdPersona + "'"
        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwPersonaClasificacion", strFiltro)

        dtPersona = SqlHelper.ExecuteQueryDT(strSQL)

        Me.txtNombreCompleto.Text = dtPersona.DefaultView.Item(0)("NombreCompleto")
        Me.txtDireccion.Text = dtPersona.DefaultView.Item(0)("Direccion")
        Me.txtCedulaRUC.Text = dtPersona.DefaultView.Item(0)("StbPersonaID")
        Me.txtTelefono.Text = dtPersona.DefaultView.Item(0)("TelefonoParticular")
        Me.txtNacionalidad.Text = dtPersona.DefaultView.Item(0)("Nacionalidad")
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
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee 'no mostrar selección de fila
            '.AllowAddNew = False
            '.AllowArrows = False
            '.AllowColMove = False
            '.AllowColSelect = False
            '.AllowDelete = False
            '.AllowFilter = False
            '.AllowHorizontalSplit = False
            '.AllowRowSelect = False
            '.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
            '.AllowSort = False
            '.AllowUpdate = False
            '.AllowUpdateOnBlur = False
            '.AllowVerticalSplit = False
            '.AlternatingRows = False
            '.CurrentCellVisible = False
            '.EditActive = False
            '.FilterActive = False
            '.MaintainRowCurrency = False
            '.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
            '.RecordSelectors = False
            .Refresh()
        End With
    End Sub

    Private Sub FormatearGridProvision()
        With Me.grdTipoProvision
            .FilterBar = False
            .EmptyRows = False 'no mostrar más filas después de la última
            .Refresh()
        End With
    End Sub

#End Region

#Region "Bloquear controles"
    Private Sub BloquerarControles(ByVal bValor As Boolean)
        Me.txtIdProveedor.Enabled = Not bValor
        Me.dtpFechaEgreso.Enabled = Not bValor
        Me.dtpFechaIngreso.Enabled = Not bValor
        Me.grdTipoProvision.Enabled = Not bValor
        Me.cmdBuscarContacto.Enabled = Not bValor
        Me.cmdGuardar.Enabled = Not bValor
        Me.cmdBuscarProv.Enabled = Not bValor
        Me.cmdNuevoProv.Enabled = Not bValor
        Me.numPlazoCredito.Enabled = Not bValor
        Me.cmbTerminoPago.Enabled = Not bValor
    End Sub
#End Region

#Region "Cargar proveedor detalle provision"
    Private Sub CargarProveedorDetalleProvision()
        Dim sSQL, sCampos, sFiltro As String

        'configurar combobox para seleccionar tipo de provisión
        sCampos = " StbValorCatalogoID as objTipoProvisionID, Descripcion "
        sFiltro = " Nombre='TIPOPROVISION' and Activo=1 "
        sSQL = clsConsultas.ObtenerCatalogoValor(sCampos, sFiltro, "Descripcion")

        With Me.cmbProveedorProvision
            .DataSource = SqlHelper.ExecuteQueryDT(sSQL)
            .DisplayMember = "Descripcion"
            .ValueMember = "objTipoProvisionID"
            .DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Column
            .ColumnHeaders = False
            .DisplayColumns("objTipoProvisionID").Visible = False
            .DisplayColumns("Descripcion").Width = Me.grdTipoProvision.Width - 10
            .ValueTranslate = True
            .Refresh()
        End With

        sCampos = "objSivProveedorID, objTipoProvisionID, DescripcionProvision"
        sFiltro = " objSivProveedorID=" + Me.IDProveedor.ToString
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivProveedorDetalleProvision", sFiltro)

        Me.dtProveedorDetalleProvision = SqlHelper.ExecuteQueryDT(sSQL)
        With Me.grdTipoProvision
            .SetDataBinding(Me.dtProveedorDetalleProvision, "", True)
            'Enlazar las columnas que mostrarán el combo de la descripción y el id del Tipo de provisión   
            .Columns("objTipoProvisionID").ValueItems.Translate = True
            .Columns("objTipoProvisionID").DropDown = Me.cmbProveedorProvision
            .Columns("DescripcionProvision").ValueItems.Translate = True
            .Columns("DescripcionProvision").DropDown = Me.cmbProveedorProvision
        End With

        'Ejemplo de manipulación de lista de combo
        'Dim Vi As New C1.Win.C1TrueDBGrid.ValueItem
        'Vi.DisplayValue = "1- Llamadas" : Vi.Value = "1"
        'Me.grdTipoProvision.Columns(0).ValueItems.Values.Add(Vi)
        'Vi.DisplayValue = "2- Carta" : Vi.Value = "2"
        'Me.grdTipoProvision.Columns(0).ValueItems.Values.Add(Vi)
        'Vi.DisplayValue = "3- Fax" : Vi.Value = "3"
        'Me.grdTipoProvision.Columns(0).ValueItems.Values.Add(Vi)
        'Me.grdTipoProvision.Refresh()

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

            If Me.grdTipoProvision.Splits(0).Rows.Count = 1 And String.IsNullOrEmpty(Me.grdTipoProvision.Columns("objTipoProvisionID").Value.ToString) Then
                MsgBox("Debe seleccionar al menos un tipo de provisión para el proveedor.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Return False
                Exit Function
            End If

            If Not Me.dtpFechaEgreso.ValueIsDbNull Then
                If Convert.ToDateTime(Me.dtpFechaIngreso.Value).Date > Convert.ToDateTime(Me.dtpFechaEgreso.Value).Date Then
                    MsgBox("Fecha egreso debe ser mayor o igual que fecha ingreso.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                End If
            End If

            If fHayDuplicadosProvision() Then
                Me.ErrorProvider.SetError(Me.grdTipoProvision, "Hay valores duplicados en tipo de provisión.")
                Return False
                Exit Function
            End If

            If (Me.numPlazoCredito.Value = 0) And (Me.cmbTerminoPago.SelectedValue = intTerminoPagoCREDITO) Then
                Me.ErrorProvider.SetError(Me.numPlazoCredito, "El plazo de crédito deber ser mayor que cero.")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Buscar duplicados en tipo provisión"
    Function fHayDuplicadosProvision() As Boolean
        Dim iCont As Integer = 0
        Dim iValorTemp As Integer
        Dim bResultado As Boolean = False

        If Me.grdTipoProvision.Splits(0).Rows.Count Then
            For i As Integer = 0 To Me.grdTipoProvision.Splits(0).Rows.Count - 1
                If Not String.IsNullOrEmpty(Me.grdTipoProvision.Item(i, 0).ToString) Then
                    iValorTemp = Me.grdTipoProvision.Item(i, 0).ToString
                End If

                iCont = 0
                For j As Integer = 0 To Me.grdTipoProvision.Splits(0).Rows.Count - 1
                    If Not String.IsNullOrEmpty(Me.grdTipoProvision.Item(j, 0).ToString) Then
                        If Int32.Parse(Me.grdTipoProvision.Item(j, 0).ToString) = iValorTemp Then
                            iCont = iCont + 1
                        End If
                    End If
                Next
                If iCont >= 2 Then
                    bResultado = True
                    Exit For
                End If
            Next
        End If

        Return bResultado
    End Function


    'Función usada en el grid de tipo de provisión
    Private Function DuplicadoEnDetalleProvision(ByVal intTipoProvision As Integer) As Boolean
        Dim blnRetorno As Boolean = False

        Dim iCont As Integer = 0
        Dim bResultado As Boolean = False

        If Me.grdTipoProvision.Splits(0).Rows.Count Then
            For j As Integer = 0 To Me.grdTipoProvision.Splits(0).Rows.Count - 1
                If Not String.IsNullOrEmpty(Me.grdTipoProvision.Item(j, 0).ToString) Then
                    If Int32.Parse(Me.grdTipoProvision.Item(j, 0).ToString) = intTipoProvision Then
                        iCont = iCont + 1
                    End If
                End If
            Next
        End If

        If iCont >= 2 Then
            bResultado = True
        End If

        Return bResultado
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
        Dim objPers As frmStbPersonasEditar
        objPers = New frmStbPersonasEditar

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
        objPers.frmLlamado = 6 'Llamado desde proveedores
        If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.objPersonaId = objPers.idpersona
            If objPers.idpersona.Length <> 0 Then
                CargarDatosPersona(objPers.idpersona)
                Me.ModificoProveedor = True
            End If
        End If
    End Sub

    Private Sub cmdBuscarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarProv.Click
        'Si estamos en modo consulta entonces mostrar los datos de persona
        If Me.TypeGui = 2 Then
            Dim objPers As frmStbPersonasEditar
            objPers = New frmStbPersonasEditar
            objPers.TyGui = 3
            objPers.idpersona = Me.objPersonaId
            objPers.frmLlamado = 6 'Llamado desde proveedores
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
    End Sub

    Private Sub cmdBuscarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarContacto.Click
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
                Dim objPers As frmStbPersonasEditar
                objPers = New frmStbPersonasEditar
                objPers.TyGui = 3
                objPers.idpersona = Me.objContactoId
                objPers.frmLlamado = 7 'Llamado desde CONCTACTO de proveedor
                If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.objContactoId = objPers.idpersona
                    If objPers.idpersona.Length <> 0 Then
                        Me.CargarDatosContactoPrincipal(objPers.idpersona)
                        Me.ModificoProveedor = True
                    End If
                End If
        End Select
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
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
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIngreso.TextChanged, dtpFechaEgreso.TextChanged
        Me.ErrorProvider.Clear()
        If Me.dtpFechaEgreso.Text.Trim.Length <> 0 Then
            Me.ModificoProveedor = True
        End If
    End Sub

    Private Sub grdTipoProvision_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdTipoProvision.KeyDown
        If e.KeyValue = Keys.Delete Then
            EliminarTipoProvision()
        End If
    End Sub

    Private Sub grdTipoProvision_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdTipoProvision.Change
        Me.ErrorProvider.Clear()
        Me.ModificoDetProvision = True
        Me.ModificoProveedor = True
    End Sub

    Private Sub mnuEliminarProvision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminarProvision.Click
        EliminarTipoProvision()
    End Sub

    Private Sub grdTipoProvision_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdTipoProvision.AfterColUpdate
        If e.ColIndex = 2 Then
            If Me.grdTipoProvision.Columns("objTipoProvisionID").Value.ToString.Trim.Length <> 0 Then
                If Me.DuplicadoEnDetalleProvision(Me.grdTipoProvision.Columns("objTipoProvisionID").Value.ToString) Then
                    MsgBox("El tipo provisión ya se encuentra en la lista.", , clsProyecto.SiglasSistema)
                    'Me.grdTipoProvision.Splits(0).Rows.RemoveAt(Me.grdTipoProvision.Row)
                    Me.grdTipoProvision.Columns("objTipoProvisionID").Value = String.Empty
                    Me.grdTipoProvision.Columns("DescripcionProvision").Value = String.Empty
                    SendKeys.Send("{UP}")
                End If
            End If
        End If
    End Sub

#End Region

#Region "Eliminar tipo provisión"
    Private Sub EliminarTipoProvision()
        If (Not Me.grdTipoProvision.Splits(0).Rows.Count = 1) And (Not Me.grdTipoProvision.Row = Me.grdTipoProvision.Splits(0).Rows.Count - 1) Then
            If MsgBox("¿Confirma que desea eliminar el tipo de provisión?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.dtProveedorDetalleProvision.DefaultView.Item(Me.grdTipoProvision.Row).Delete()
                Me.ModificoProveedor = True
                Me.ModificoDetProvision = True
            End If
        End If
    End Sub
#End Region

#Region "Cargar formulario"
    Private Sub frmSivProveedorEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IdTipoPersonaProveedor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetIdTipoPersona('Proveedor') as ID").DefaultView.Item(0)("ID")
        CargarProveedorDetalleProvision()
        CargarTerminoPago()
        Me.intTerminoPagoCREDITO = ClsCatalogos.GetValorCatalogoID("TERMINOPAGO", "02")
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
                Me.dtpFechaEgreso.Enabled = True
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
        Me.FormatearGridProvision()
    End Sub
#End Region

    Private Sub TabProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabProveedor.SelectedIndexChanged
        Me.cmdBuscarContacto.Visible = TabProveedor.SelectedIndex = 0
        Me.cmdEditarContactoPrincipal.Visible = TabProveedor.SelectedIndex = 0
    End Sub

    Private Sub cmdEditarContactoPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarContactoPrincipal.Click
        Dim objPers As frmStbPersonasEditar
        objPers = New frmStbPersonasEditar

        Select Case Me.TypeGui
            Case 0, 1
                objPers.TyGui = 2
            Case 2
                objPers.TyGui = 3
        End Select
        objPers.idpersona = Me.objContactoId
        objPers.frmLlamado = 7 'Llamado desde CONCTACTO de proveedor
        If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.objContactoId = objPers.idpersona
            If objPers.idpersona.Length <> 0 Then
                Me.CargarDatosContactoPrincipal(objPers.idpersona)
                Me.ModificoProveedor = True
            End If
        End If
    End Sub

    Private Sub frmSivProveedorEdit_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ModificoProveedor = False
        Me.ModificoDetProvision = False 'variable para verificar si se hacen cambios al grid de Provisión
    End Sub

    Private Sub cmbTerminoPago_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTerminoPago.SelectedValueChanged
        If Me.cmbTerminoPago.SelectedValue = intTerminoPagoCREDITO Then
            Me.numPlazoCredito.Enabled = True
        Else
            Me.numPlazoCredito.Enabled = False
            Me.numPlazoCredito.Value = 0
        End If

        Me.ErrorProvider.Clear()
        If Me.cmbTerminoPago.Text.Trim.Length <> 0 Then
            Me.ModificoProveedor = True
        End If

    End Sub
    Private Sub numPlazoCredito_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numPlazoCredito.ValueChanged
        Me.ErrorProvider.SetError(Me.numPlazoCredito, "")
        Me.ModificoProveedor = True
    End Sub
End Class