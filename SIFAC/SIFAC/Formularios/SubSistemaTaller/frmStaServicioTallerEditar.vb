'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 04 Agosto 2010.
''-- Formulario de Modificación de datos de servicio de taller
''------------------------------------------------------------------------------------------------

Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SCCUM.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid
Imports System.Windows.Forms.Cursors

'Imports DevExpress.XtraGrid.Views.Grid
'Imports DevExpress.XtraGrid.Views.Base
'Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmStaServicioTallerEditar

#Region "Atributos"
    Private dtDatosCliente As DataTable
    Private dtExpedienteCxC As DataTable
    Private dtSalidasRepuestos As DataTable

    Private m_SucursalSessionID As Integer
    Private m_SucursalCentralID As Integer
    Private m_EstadoRecibida As Integer
    Private m_EstadoEntregada As Integer
    Private m_TypeGui As Integer
    Private m_StaServicioTallerID As Integer
    Private objSccCuentaTiendaID As Integer
    Private CantidadServiciosGarantia As Integer
    Private m_TipoKilometrosId As Integer

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

    Property SucursalSessionID() As Integer
        Get
            SucursalSessionID = Me.m_SucursalSessionID
        End Get
        Set(ByVal value As Integer)
            Me.m_SucursalSessionID = value
        End Set
    End Property

    Property SucursalCentralID() As Integer
        Get
            SucursalCentralID = Me.m_SucursalCentralID
        End Get
        Set(ByVal value As Integer)
            Me.m_SucursalCentralID = value
        End Set
    End Property

    Property EstadoRecibidaID() As Integer
        Get
            EstadoRecibidaID = Me.m_EstadoRecibida
        End Get
        Set(ByVal value As Integer)
            Me.m_EstadoRecibida = value
        End Set
    End Property

    Property EstadoEntregadaID() As Integer
        Get
            EstadoEntregadaID = Me.m_EstadoEntregada
        End Get
        Set(ByVal value As Integer)
            Me.m_EstadoEntregada = value
        End Set
    End Property

    Property StaServicioTallerID() As Integer
        Get
            StaServicioTallerID = Me.m_StaServicioTallerID
        End Get
        Set(ByVal value As Integer)
            Me.m_StaServicioTallerID = value
        End Set
    End Property

    Property TipoKilometrosID() As Integer
        Get
            TipoKilometrosID = Me.m_TipoKilometrosId
        End Get
        Set(ByVal value As Integer)
            Me.m_TipoKilometrosId = value
        End Set
    End Property

#End Region

#Region "Constantes"
    Const AGREGAR = 0
    Const FINALIZAR = 1
    Const CONSULTAR = 2
    Const SOLICITUDREPUESTO = 3
    Const MODIFICARENTREGA = 4
#End Region

#Region "Cargar Datos del Cliente"

    Private Sub CargarDatosCliente(ByVal strFiltroCliente As String)
        dtDatosCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("DISTINCT StbPersonaID, Telefonos, Emails, Direccion, Exonerado", "vwSfaClienteCotizacion", "StbPersonaID=" & "'" & strFiltroCliente & "'"))

        If dtDatosCliente.DefaultView.Count > 0 Then
            Me.txtNumCliente.Text = dtDatosCliente.DefaultView.Item(0)("StbPersonaID")
            Me.cmbClientes.EditValue = dtDatosCliente.DefaultView.Item(0)("StbPersonaID")
            If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("Telefonos")) Then
                Me.txtTelefonos.Text = dtDatosCliente.DefaultView.Item(0)("Telefonos")
            Else
                Me.txtTelefonos.Text = "No definido"
            End If
            If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("Direccion")) Then
                Me.txtDireccion.Text = dtDatosCliente.DefaultView.Item(0)("Direccion")
            Else
                Me.txtDireccion.Text = "No definido"
            End If
            Me.chkExonerado.Checked = dtDatosCliente.DefaultView.Item(0)("Exonerado")
            'Me.CargarComboExpedientes()
        Else
            Me.txtNumCliente.Text = ""
            Me.cmbClientes.EditValue = String.Empty
            Me.txtTelefonos.Text = ""
            Me.txtDireccion.Text = ""
            Me.chkExonerado.Checked = False
        End If
    End Sub

    Private Sub CargarExpedienteCxCCliente(ByVal strFiltroCliente As String)
        Dim strSQL, strCampos, strFiltro As String

        Try
            strCampos = "objTiendaID, Numero, ISNULL(Moto,'') AS Moto, Saldo, ISNULL(Modelo,'') as Modelo, ISNULL(Marca,'') as Marca, ISNULL(NoMotor,'') AS NoMotor, ISNULL(Chasis,'') AS Chasis, ISNULL(GarantiaAlDia,0) AS GarantiaAlDia"
            strFiltro = "objClienteID=" & "'" & strFiltroCliente & "' ORDER BY Numero"
            strSQL = ObtenerConsultaGeneral(strCampos, "vwSfaExpCxCCotizacion", strFiltro)

            dtExpedienteCxC = DAL.SqlHelper.ExecuteQueryDT(strSQL)
            Me.grdDatosExpediente.SetDataBinding(dtExpedienteCxC, "", True)
            If dtExpedienteCxC.Rows.Count > 0 Then
                Me.CargarComboExpedientes()
            Else
                Me.cmbExpedientes.Properties.DataSource = Me.dtExpedienteCxC
            End If

            If dtExpedienteCxC.Rows.Count = 0 Then
                Me.cmbExpedientes.EditValue = String.Empty
                Me.CargarDatosMotoClienteGenerico(strFiltroCliente)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar COMBOS"

#Region "Cargar combo Cliente"
    Private Sub CargarComboClientes()
        Dim dtDatos As New DataTable
        Dim sSQL As String
        Try
            sSQL = ObtenerConsultaGeneral("StbPersonaID, Cliente", "vwSfaClienteCotizacion", "1=1 ORDER BY Cliente")
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL)
            Me.cmbClientes.Properties.DataSource = dtDatos

            If dtDatos.Rows.Count >= 7 Then
                cmbClientes.Properties.DropDownRows = 7
            Else
                cmbClientes.Properties.DropDownRows = dtDatos.Rows.Count
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar combo Sucursales"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Sucursales
    ''' Autor : Gelmin Martinez
    ''' Fecha 05 de Agosto de 2010, 09:35 am.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboSucursales()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("Activo= 1 AND ActivoRepuesto=1", "Nombre", "StbTiendaID, Codigo, Nombre")
            With Me.cmbSucursal
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 40
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar combo tipo servicio"
    Private Sub CargarComboTipoServicio()
        Dim dtDatos As DataTable

        dtDatos = ClsCatalogos.GetValoresCatalogo("TIPOSERVICIOSTALLER")

        'Agregar las columnas
        Dim columnas As LookUpColumnInfoCollection = Me.cmbTipoServicio.Properties.Columns
        columnas.Add(New LookUpColumnInfo("StbValorCatalogoID"))
        columnas.Add(New LookUpColumnInfo("Descripcion"))
        With Me.cmbTipoServicio.Properties
            .DataSource = dtDatos
            .DisplayMember = "Descripcion"
            .ValueMember = "StbValorCatalogoID"
            .SearchMode = SearchMode.AutoFilter
            .AutoSearchColumnIndex = 1
            .Columns("StbValorCatalogoID").Visible = False
            If dtDatos.Rows.Count >= 7 Then
                .DropDownRows = 7
            Else
                .DropDownRows = dtDatos.Rows.Count
            End If
        End With
    End Sub

#End Region

#Region "Cargar combo Estado servicio"
    Private Sub CargarComboEstadoServicio()
        Dim dtDatos As DataTable

        dtDatos = ClsCatalogos.GetValoresCatalogo("ESTADOSERVICIOTALLER")
        If dtDatos.Rows.Count <> 0 Then
            'Agregar las columnas
            Dim columnas As LookUpColumnInfoCollection = Me.cmbEstadoServicio.Properties.Columns
            columnas.Add(New LookUpColumnInfo("StbValorCatalogoID"))
            columnas.Add(New LookUpColumnInfo("Descripcion"))
            With Me.cmbEstadoServicio.Properties
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .SearchMode = SearchMode.AutoFilter
                .AutoSearchColumnIndex = 1
                .Columns("StbValorCatalogoID").Visible = False
                If dtDatos.Rows.Count >= 7 Then
                    .DropDownRows = 7
                Else
                    .DropDownRows = dtDatos.Rows.Count
                End If
            End With
        End If
    End Sub

#End Region

#Region "Cargar combo Ténico"
    Private Sub CargarComboTecnicos()
        Dim dtDatos As New DataTable
        Dim strSQL As String
        Dim CargoTecnicoID As Integer
        Try
            CargoTecnicoID = ClsCatalogos.GetValorCatalogoID("CARGOS", "10") '10=Técnico
            strSQL = ObtenerConsultaGeneral("SrhEmpleadoID, NombreCompleto", "dbo.vwSrhEmpleado", "objCargoID=" & CargoTecnicoID.ToString)
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(strSQL)

            'Agregar las columnas
            Dim columnas As LookUpColumnInfoCollection = Me.cmbTecnicoAsignado.Properties.Columns
            columnas.Add(New LookUpColumnInfo("SrhEmpleadoID"))
            columnas.Add(New LookUpColumnInfo("NombreCompleto"))
            With Me.cmbTecnicoAsignado.Properties
                .DataSource = dtDatos
                .DisplayMember = "NombreCompleto"
                .ValueMember = "SrhEmpleadoID"
                .SearchMode = SearchMode.AutoFilter
                .AutoSearchColumnIndex = 1
                .Columns("SrhEmpleadoID").Visible = False
                If dtDatos.Rows.Count >= 7 Then
                    .DropDownRows = 7
                Else
                    .DropDownRows = dtDatos.Rows.Count
                End If
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar combo Expediente"
    Private Sub CargarComboExpedientes()
        Dim dtDatos As New DataTable
        Dim fila As DataRow
        Try
            dtDatos.Reset()
            Me.txtPlaca.Text = String.Empty
            Me.txtColor.Text = String.Empty

            dtDatos.Columns.Add("Numero")
            dtDatos.Columns.Add("NumeroMostrar")
            For Each row As DataRow In Me.dtExpedienteCxC.Rows
                fila = dtDatos.NewRow
                fila("Numero") = row("Numero")
                fila("NumeroMostrar") = row("Numero")
                dtDatos.Rows.Add(fila)
            Next

            'Agregar las columnas
            With Me.cmbExpedientes.Properties
                .DataSource = dtDatos
                .SearchMode = SearchMode.AutoFilter
                .AutoSearchColumnIndex = 1
                If dtDatos.Rows.Count >= 7 Then
                    .DropDownRows = 7
                Else
                    .DropDownRows = dtDatos.Rows.Count
                End If
                If dtExpedienteCxC.Rows.Count >= 1 Then
                    cmbExpedientes.EditValue = dtDatos.DefaultView.Item(0)("Numero")
                End If
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Datos Moto Cliente Genérico"
    Private Sub CargarDatosMotoClienteGenerico(ByVal strClienteID As String)
        Dim strCampos, strSQL, strFiltro1, strFiltro2 As String
        Dim strServicioTallerID As String = "0"
        Dim dtDatos As DataTable

        If String.IsNullOrEmpty(strClienteID) Then
            Exit Sub
        End If

        'Seleccionar el último servicio de este cliente para cargar los datos de la moto
        strFiltro1 = " objClienteID='" & strClienteID & "' "

        If String.IsNullOrEmpty(strFiltro1) Then
            strFiltro1 = " 1=1 "
        End If
        strCampos = "StaServicioTallerID"
        strFiltro2 = strFiltro1 & " AND FechaRecibida IN (SELECT MAX(FechaRecibida) FROM dbo.StaServicioTaller WHERE " & strFiltro1 & ")"
        strSQL = clsConsultas.ObtenerConsultaGeneral("StaServicioTallerID", "dbo.StaServicioTaller", strFiltro2)
        dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

        If dtDatos.Rows.Count > 0 Then
            If dtDatos.DefaultView.Item(0)("StaServicioTallerID").ToString.Trim.Length <> 0 Then
                strServicioTallerID = dtDatos.DefaultView.Item(0)("StaServicioTallerID")
            End If
        End If

        'Cargar datos de la moto del servicio encontrado
        If Not strServicioTallerID.Equals("0") Then
            strCampos = "ModeloMoto, MarcaMoto, NoMotorMoto, ChasisMoto, PlacaMoto, ColorMoto"
            'Si no es CENTRAL
            strFiltro2 = " StaServicioTallerID = " & strServicioTallerID
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.StaServicioTaller", strFiltro2)
            dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

            If dtDatos.Rows.Count <> 0 Then
                If dtDatos.DefaultView.Item(0)("ModeloMoto").ToString.Trim.Length <> 0 Then
                    Me.txtModelo.Text = dtDatos.DefaultView.Item(0)("ModeloMoto")
                End If
                If dtDatos.DefaultView.Item(0)("MarcaMoto").ToString.Trim.Length <> 0 Then
                    Me.txtMarca.Text = dtDatos.DefaultView.Item(0)("MarcaMoto")
                End If
                If dtDatos.DefaultView.Item(0)("NoMotorMoto").ToString.Trim.Length <> 0 Then
                    Me.txtNoMotor.Text = dtDatos.DefaultView.Item(0)("NoMotorMoto")
                End If
                If dtDatos.DefaultView.Item(0)("ChasisMoto").ToString.Trim.Length <> 0 Then
                    Me.txtNoChasis.Text = dtDatos.DefaultView.Item(0)("ChasisMoto")
                End If
                If dtDatos.DefaultView.Item(0)("PlacaMoto").ToString.Trim.Length <> 0 Then
                    Me.txtPlaca.Text = dtDatos.DefaultView.Item(0)("PlacaMoto")
                End If
                If dtDatos.DefaultView.Item(0)("ColorMoto").ToString.Trim.Length <> 0 Then
                    Me.txtColor.Text = dtDatos.DefaultView.Item(0)("ColorMoto")
                End If
                'Si el cliente no tiene expediente deshabilitar servicio por garantía
                Me.chkEsServicioGarantia.Enabled = False
                'Si el cliente ya tiene un servicio asociado cargar los datos de la moto.
            Else
                Me.InicializarDatosMotoClienteGenerico()
            End If
        Else
            Me.InicializarDatosMotoClienteGenerico()
        End If
    End Sub

    'Inicializa los datos de moto de un cliente que no tiene expediente y que no ha hecho ningún servicio de taller.
    Private Sub InicializarDatosMotoClienteGenerico()
        Me.txtModelo.Text = String.Empty
        Me.txtMarca.Text = String.Empty
        Me.txtNoMotor.Text = String.Empty
        Me.txtNoChasis.Text = String.Empty
        Me.txtPlaca.Text = String.Empty
        Me.txtColor.Text = String.Empty
        Me.chkEsServicioGarantia.Enabled = False
    End Sub

#End Region

#Region "Cargar combo Niveles combustible"
    Private Sub CargarComboNivelesCombustible()
        Dim dtDatos As DataTable

        dtDatos = ClsCatalogos.GetValoresCatalogo("NIVELESCOMBUSTIBLE")
        If dtDatos.Rows.Count <> 0 Then
            'Agregar las columnas
            Dim columnas As LookUpColumnInfoCollection = Me.cmbNivelesCombustible.Properties.Columns
            columnas.Add(New LookUpColumnInfo("StbValorCatalogoID"))
            columnas.Add(New LookUpColumnInfo("Descripcion"))
            With Me.cmbNivelesCombustible.Properties
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .SearchMode = SearchMode.AutoFilter
                .AutoSearchColumnIndex = 1
                .Columns("StbValorCatalogoID").Visible = False
                If dtDatos.Rows.Count >= 7 Then
                    .DropDownRows = 7
                Else
                    .DropDownRows = dtDatos.Rows.Count
                End If
            End With
        End If
    End Sub
#End Region

#Region "Cargar combo kilometraje"
    Private Sub CargarComboKilometraje()
        Dim dtDatos As DataTable

        dtDatos = ClsCatalogos.GetValoresCatalogo("TIPOKILOMETRAJE")
        If dtDatos.Rows.Count <> 0 Then
            'Agregar las columnas
            Dim columnas As LookUpColumnInfoCollection = Me.cmbKilometraje.Properties.Columns
            columnas.Add(New LookUpColumnInfo("StbValorCatalogoID"))
            columnas.Add(New LookUpColumnInfo("Descripcion"))
            With Me.cmbKilometraje.Properties
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .SearchMode = SearchMode.AutoFilter
                .AutoSearchColumnIndex = 1
                .Columns("StbValorCatalogoID").Visible = False
                If dtDatos.Rows.Count >= 7 Then
                    .DropDownRows = 7
                Else
                    .DropDownRows = dtDatos.Rows.Count
                End If
            End With
        End If
    End Sub

#End Region

#End Region

#Region "Cargar Formulario"
    Private Sub frmStaServicioTallerEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.AsignarLongitudesMaximas()
        Me.ConfigurarGUI()
    End Sub

#End Region

#Region "Configurar GUI"
    Private Sub ConfigurarGUI()
        'Cargar combos
        Me.CargarComboClientes()
        Me.CargarComboSucursales()
        Me.CargarComboEstadoServicio()
        Me.CargarComboTipoServicio()
        Me.CargarComboTecnicos()
        Me.CargarComboNivelesCombustible()
        Me.CargarComboKilometraje()

        'Seleccionar sucursal en sessión
        Me.SucursalCentralID = ClsCatalogos.GetStbTiendaID("C")
        If Not String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            Try
                Me.SucursalSessionID = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
                Me.cmbSucursal.SelectedValue = Me.SucursalSessionID
            Catch ex As Exception
                MsgBox("La sucursal configurada no es una sucursal de repuestos", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.Close()
            End Try
        Else
            MsgBox("No se ha configurado la sucursal en el utilitario de configuración", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            Me.Close()
        End If

        'Cargar estados
        Me.EstadoEntregadaID = ClsCatalogos.GetValorCatalogoID("ESTADOSERVICIOTALLER", "ENTREGADA")
        Me.EstadoRecibidaID = ClsCatalogos.GetValorCatalogoID("ESTADOSERVICIOTALLER", "RECIBIDA")
        Me.TipoKilometrosID = ClsCatalogos.GetValorCatalogoID("TIPOKILOMETRAJE", "KM")

        Select Case Me.TypeGui
            Case AGREGAR
                Me.Text = "Agregar una orden de servicio (Recepción Moto)"
                Me.cmbEstadoServicio.EditValue = Me.EstadoRecibidaID
                Me.dtpFechaHoraRecibida.Value = clsProyecto.Conexion.FechaServidor
                Me.BloquearControlesEntregaMoto(True)
                Try
                    Me.cmbKilometraje.EditValue = Me.TipoKilometrosID
                Catch ex As Exception
                End Try
                Me.chkEsServicioGarantia.Checked = False
                Me.cmdSolicitudRepuesto.Enabled = False

            Case FINALIZAR, MODIFICARENTREGA 'Modificar entrega de moto hace lo mismo que finalizar lo único que desde otro botón de comando
                If Me.StaServicioTallerID <> 0 Then
                    Me.CargarDatosServicioTaller(Me.StaServicioTallerID)
                    Me.CargarGridRepuestosSolicitados()
                End If
                Me.BloquearControles(True) 'Bloquear todos los controles
                Me.BloquearControlesEntregaMoto(False) 'Desbloquear los controles de entrega de moto.

                Me.dtpFechaHoraEntrega.Value = clsProyecto.Conexion.FechaServidor
                Me.cmdGuardar.Enabled = True
                Me.TbcDatosRecepcionEntrega.SelectedTab = Me.tpEntrega
                If Me.TypeGui = FINALIZAR Then
                    Me.Text = "Finalizar orden de servicio (Entregar Moto)"
                ElseIf Me.TypeGui = MODIFICARENTREGA Then
                    Me.Text = "Modificar datos de entrega de motocicleta"
                    Me.cmdSolicitudRepuesto.Enabled = True
                End If
            Case CONSULTAR
                Me.Text = "Consultando Orden de Servicio de taller"
                If Me.StaServicioTallerID <> 0 Then
                    Me.CargarDatosServicioTaller(Me.StaServicioTallerID)
                    Me.CargarGridRepuestosSolicitados()
                End If
                Me.BloquearControles(True)

            Case SOLICITUDREPUESTO
                Me.Text = "Solicitud de Repuesto para el servicio"
                If Me.StaServicioTallerID <> 0 Then
                    Me.CargarDatosServicioTaller(Me.StaServicioTallerID)
                End If
                Me.BloquearControles(True) 'Bloquear todos los controles
                'Me.BloquearControlesEntregaMoto(False) 'Desbloquear los controles de entrega de moto.
                Me.cmdGuardar.Enabled = True
                Me.cmdSolicitudRepuesto.Enabled = Me.chkEsServicioGarantia.Checked
                Me.TbcDatosRecepcionEntrega.SelectedTab = Me.tpSolicitudesRepuesto
                Me.CargarGridRepuestosSolicitados()
        End Select
    End Sub

#End Region

#Region "Consultar Datos Cliente"
    Private Sub ConsultarDatosCliente()
        Dim objPersonas As frmStbPersonasEditar
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbPersonasEditar
            objPersonas.TyGui = 3

            objPersonas.frmLlamado = 4
            objPersonas.idpersona = Me.cmbClientes.EditValue.ToString

            objPersonas.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Agregar Datos Cliente"
    Private Sub AgregarCliente()
        Dim objPersonas As frmStbPersonasEditar
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbPersonasEditar
            objPersonas.TyGui = 1
            objPersonas.frmLlamado = 4

            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarComboClientes()
                Me.cmbClientes.EditValue = objPersonas.idpersona
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#Region "Eventos de controles"
    Private Sub txtNumCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumCliente.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.CargarDatosCliente(txtNumCliente.Text)
            Me.CargarExpedienteCxCCliente(txtNumCliente.Text)
        End If
    End Sub

    Private Sub cmdConsultarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarCliente.Click
        If Me.cmbClientes.EditValue.Trim.Length > 0 Then
            Me.ConsultarDatosCliente()
        Else
            MsgBox("Seleccione un Cliente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If
    End Sub

    Private Sub cmdAgregarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarCliente.Click
        Me.AgregarCliente()
    End Sub

    Private Sub cmbClientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClientes.EditValueChanged
        Me.txtNumCliente.Text = Me.cmbClientes.EditValue
        Me.CargarDatosCliente(Me.cmbClientes.EditValue.ToString)
        Me.CargarExpedienteCxCCliente(Me.cmbClientes.EditValue.ToString)
        Me.ErrTaller.Clear()
    End Sub

    Private Sub cmbExpedientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExpedientes.EditValueChanged
        Dim strCuentaID As String
        Dim filas As DataRow()

        If Me.dtExpedienteCxC.Rows.Count <> 0 Then
            strCuentaID = Me.cmbExpedientes.EditValue
            filas = Me.dtExpedienteCxC.Select("Numero='" & strCuentaID + "'")
            If filas.Length <> 0 Then
                'Numero, Moto, Saldo, Modelo, Marca, NoMotor, Chasis, GarantiaAlDia
                Me.txtModelo.Text = filas(0)("Modelo")
                Me.txtMarca.Text = filas(0)("Marca")
                Me.txtNoMotor.Text = filas(0)("NoMotor")
                Me.txtNoChasis.Text = filas(0)("Chasis")
                If Not IsDBNull(filas(0)("GarantiaAlDia")) Then
                    Me.chkGarantiaExtendidaOK.Checked = filas(0)("GarantiaAlDia")
                End If
                objSccCuentaTiendaID = filas(0)("objTiendaID") 'Sucursal donde se adquirió la moto.
                Me.MarcarServiciosPorGarantia(strCuentaID)
            End If
        End If
        Me.ErrTaller.Clear()
    End Sub

    Private Sub cmbTipoServicio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoServicio.EditValueChanged, cmbTecnicoAsignado.EditValueChanged, cmbNivelesCombustible.EditValueChanged, cmbKilometraje.EditValueChanged, spnValorKilometraje.EditValueChanged
        Me.ErrTaller.Clear()
    End Sub

    Private Sub txtObservacionesJefeTallerRecibir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacionesJefeTallerRecibir.TextChanged, txtMotoRecibidaDE.TextChanged, txtFallasReportadasCliente.TextChanged
        Me.ErrTaller.Clear()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Select Case Me.TypeGui
            Case AGREGAR
                If Me.ValidarDatos() Then
                    If Not Me.chkGarantiaExtendidaOK.Checked Then 'Si no está al día con la garantía extendida
                        If MsgBox("Este expediente no tiene garantía extendida o el cliente no está al día con su garantía, ¿Desea Seguir con el registro del Servicio de Taller?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            If Me.GuardarServicioTaller() Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                            End If
                        End If
                    Else
                        If Me.chkEsServicioGarantia.Checked Then 'Si está al día y se ha marcado el servicio como garantía entonces continuar
                            If Me.GuardarServicioTaller() Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                            End If
                        Else     'si está al dia pero no se ha marcado este servicio como garantía enviar advertencia, antes de guardar el servicio
                            If MsgBox("Este expediente tiene su garantía extendida AL DIA pero no ha marcado este servicio como Garantía. ¿Desa continuar con el registro del servicio Sin Garantía?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                                If Me.GuardarServicioTaller() Then
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                End If
                            End If
                        End If
                    End If
                End If
            Case FINALIZAR, MODIFICARENTREGA
                If Me.ValidarDatos() Then
                    If Me.FinalizarServicioTaller() Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            Case SOLICITUDREPUESTO
                Me.DialogResult = Windows.Forms.DialogResult.OK
        End Select

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdSolicitudRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSolicitudRepuesto.Click
        Dim objformulario As New frmSivAgregarSalida
        Try
            If Me.chkEsServicioGarantia.Checked Then
                objformulario.TypeGui = 4 '4=Solicitud de salida de repuesto en garantía
                objformulario.StaServicioTallerID = Me.StaServicioTallerID 'Enviar el id de servicio que estará asociado con la salida.
                If objformulario.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarGridRepuestosSolicitados()
                End If
            Else
                MsgBox("No es posible solicitar repuestos en Servicios que no sean por garantía.")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objformulario = Nothing
        End Try
    End Sub

    Private Sub chkEsServicioGarantia_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEsServicioGarantia.CheckStateChanged
        'Me.cmdSolicitudRepuesto.Enabled = Me.chkEsServicioGarantia.Checked
    End Sub

#End Region

#Region "Asignar Longitudes maximas"
    Private Sub AsignarLongitudesMaximas()
        Me.txtNumCliente.MaxLength = StaServicioTaller.GetMaxLength("objClienteID")
        Me.txtPlaca.MaxLength = StaServicioTaller.GetMaxLength("PlacaMoto")
        Me.txtColor.MaxLength = StaServicioTaller.GetMaxLength("ColorMoto")
        Me.txtObservacionesJefeTallerRecibir.MaxLength = StaServicioTaller.GetMaxLength("ObservacionesJefeTaller")
        Me.txtMotoRecibidaDE.MaxLength = StaServicioTaller.GetMaxLength("MotoRecibidaDe")
        Me.txtFallasReportadasCliente.MaxLength = StaServicioTaller.GetMaxLength("FallasReportadasCliente")
        Me.txtOtros.MaxLength = StaServicioTaller.GetMaxLength("Otros")
        Me.txtDiagnosticoTaller.MaxLength = StaServicioTaller.GetMaxLength("DiagnosticoTaller")
        Me.txtSolucion.MaxLength = StaServicioTaller.GetMaxLength("Solucion")
        Me.txtMotoEntregadaA.MaxLength = StaServicioTaller.GetMaxLength("MotoEntregadaA")
    End Sub
#End Region

#Region "Contar Servicios por garantía"
    Private Function CantidadServiciosPorGarantia(ByVal strSccCuentaID As String) As Integer
        Dim strSQL, strCampos, strFiltro As String
        Dim iCantidad As Integer
        Dim dtDatos As DataTable
        Try
            strCampos = " Count(*) as Cantidad "
            strFiltro = " objSccCuentaID = '" & strSccCuentaID & "' AND ServicioGarantia=1"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.StaServicioTaller", strFiltro)

            dtDatos = SqlHelper.ExecuteQueryDT(strSQL)
            If dtDatos.Rows.Count <> 0 Then
                iCantidad = SqlHelper.ExecuteQueryDT(strSQL).DefaultView.Item(0)("Cantidad")
            End If
            Return iCantidad

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Marcar los servicios por garantía"
    'Marcar los servicios de cortesía por Cuenta
    Private Overloads Sub MarcarServiciosPorGarantia(ByVal strSccCuentaID As String)
        Me.CantidadServiciosGarantia = CantidadServiciosPorGarantia(strSccCuentaID)

        Select Case CantidadServiciosGarantia
            Case 0
                Me.chkGarantia1.Checked = False
                Me.chkGarantia2.Checked = False
                Me.chkGarantia3.Checked = False
            Case 1
                Me.chkGarantia1.Checked = True
            Case 2
                Me.chkGarantia1.Checked = True
                Me.chkGarantia2.Checked = True
            Case Is >= 3
                Me.chkGarantia1.Checked = True
                Me.chkGarantia2.Checked = True
                Me.chkGarantia3.Checked = True
        End Select

        'Si aún no han pasado los tres servicios de cortesía marcar por defecto que este servicio es un servicio por garantía
        If Me.chkGarantiaExtendidaOK.Checked Then
            If Not Me.chkGarantia3.Checked Then
                Me.chkEsServicioGarantia.Checked = True
            End If
        End If
    End Sub

    'Marcar los servicios de cortesía por Cantidad
    Private Overloads Sub MarcarServiciosPorGarantia(ByVal iCantidadServicioGarantia As Integer)
        Me.CantidadServiciosGarantia = iCantidadServicioGarantia
        Select Case Me.CantidadServiciosGarantia
            Case 0
                Me.chkGarantia1.Checked = False
                Me.chkGarantia2.Checked = False
                Me.chkGarantia3.Checked = False
            Case 1
                Me.chkGarantia1.Checked = True
            Case 2
                Me.chkGarantia1.Checked = True
                Me.chkGarantia2.Checked = True
            Case Is >= 3
                Me.chkGarantia1.Checked = True
                Me.chkGarantia2.Checked = True
                Me.chkGarantia3.Checked = True

                'Si aún no han pasado los tres servicios de cortesía marcar por defecto que este servicio es un servicio por garantía
                If Me.chkGarantiaExtendidaOK.Checked Then
                    If Not Me.chkGarantia3.Checked Then
                        Me.chkEsServicioGarantia.Checked = True
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "Bloqueos de Controles"
    Private Sub BloquearControlesEntregaMoto(ByVal bValor As Boolean)
        Me.chkCambioAceite.Enabled = Not bValor
        Me.chkLimpiezaCarburador.Enabled = Not bValor
        Me.chkAjustesFrenos.Enabled = Not bValor
        Me.chkAjusteCadenaSecundaria.Enabled = Not bValor
        Me.chkChequeoTiempoEncendido.Enabled = Not bValor
        Me.chkChequeoBateria.Enabled = Not bValor
        Me.chkRegulacionEmbrague.Enabled = Not bValor
        Me.chkCalibrarValvulas.Enabled = Not bValor
        Me.chkSuspencionTrasera.Enabled = Not bValor
        Me.chkEngraseTraseroDelantero.Enabled = Not bValor
        Me.chkCambioFricciones.Enabled = Not bValor
        Me.txtOtros.Enabled = Not bValor
        'Me.dtpFechaHoraEntrega.Enabled = Not bValor    -> Bloqueada desde diseño
        Me.txtDiagnosticoTaller.Enabled = Not bValor
        Me.txtSolucion.Enabled = Not bValor
        Me.txtMotoEntregadaA.Enabled = Not bValor
    End Sub

    Private Sub BloquearControles(ByVal bvalor As Boolean)
        Me.txtNumCliente.Enabled = Not bvalor
        Me.cmbClientes.Enabled = Not bvalor
        Me.cmbTipoServicio.Enabled = Not bvalor
        Me.cmbTecnicoAsignado.Enabled = Not bvalor
        Me.cmbEstadoServicio.Enabled = Not bvalor
        Me.cmdAgregarCliente.Visible = Not bvalor

        Me.cmbExpedientes.Enabled = Not bvalor
        Me.txtObservacionesJefeTallerRecibir.Enabled = Not bvalor
        Me.txtMotoRecibidaDE.Enabled = Not bvalor
        Me.cmbNivelesCombustible.Enabled = Not bvalor
        'Me.TbcDatosRecepcionEntrega.Enabled = Not bvalor
        Me.cmbKilometraje.Enabled = Not bvalor

        'Datos de moto
        Me.txtModelo.Enabled = Not bvalor
        Me.txtMarca.Enabled = Not bvalor
        Me.txtNoMotor.Enabled = Not bvalor
        Me.txtNoChasis.Enabled = Not bvalor
        Me.txtPlaca.Enabled = Not bvalor
        Me.txtColor.Enabled = Not bvalor

        Me.txtFallasReportadasCliente.Enabled = Not bvalor
        Me.spnValorKilometraje.Enabled = Not bvalor
        Me.chkEsServicioGarantia.Enabled = Not bvalor
        Me.BloquearControlesEntregaMoto(True)
        Me.cmdSolicitudRepuesto.Enabled = Not bvalor

        Me.cmdGuardar.Enabled = False
    End Sub
#End Region

#Region "Validaciones"
    Private Function ValidarDatos() As Boolean
        Try
            'Sólo verificar cuando se está en modo Agregación 
            If Me.TypeGui = AGREGAR Then
                If Me.cmbClientes.EditValue.ToString.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.cmbClientes, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If Me.cmbTipoServicio.EditValue.ToString.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.cmbTipoServicio, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If Me.cmbTecnicoAsignado.EditValue.ToString.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.cmbTecnicoAsignado, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                'If Me.txtObservacionesJefeTallerRecibir.Text.Trim.Length = 0 Then
                '    Me.ErrTaller.SetError(Me.txtObservacionesJefeTallerRecibir, My.Resources.MsgObligatorio)
                '    Return False
                '    Exit Function
                'End If

                If Me.txtMotoRecibidaDE.Text.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.txtMotoRecibidaDE, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If Me.cmbNivelesCombustible.EditValue.ToString.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.cmbNivelesCombustible, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If Me.cmbKilometraje.EditValue.ToString.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.cmbKilometraje, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If Me.spnValorKilometraje.Value <= 0 Then
                    Me.ErrTaller.SetError(Me.spnValorKilometraje, "El valor del kilometraje no puede ser cero o negativo.")
                    Return False
                    Exit Function
                End If

                If Me.txtFallasReportadasCliente.Text.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.txtFallasReportadasCliente, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If Me.chkEsServicioGarantia.Checked Then 'Si es un servicio por garantía
                    If Me.chkGarantia3.Checked Then 'Ya tiene sus Tres servicios de cortesía
                        If Not Me.chkGarantiaExtendidaOK.Checked Then 'La póliza de garantía extendida no está al dáa
                            MsgBox("La moto de este expediente ha alcanzado sus 3 Servicios de Cortesía y su garantía Extendida no está AL DIA, No es posible registrar este nuevo servicio por garantía.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                            Return False
                            Exit Function
                        End If
                    End If
                End If

                'Verificar si este expediente de moto no está en taller
                If Me.dtExpedienteCxC.Rows.Count > 0 AndAlso Me.cmbExpedientes.EditValue.ToString.Trim.Length <> 0 Then
                    If Me.EstaExpedienteEnServicio(Me.cmbExpedientes.EditValue.ToString) Then
                        MsgBox("El expediente seleccionado está actualmente en Servicio de taller, aún no ha sido entregado al cliente.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                        Return False
                        Exit Function
                    End If
                Else
                    If Me.txtNoMotor.Text.Trim.Length <> 0 Then
                        If Me.EstaMotoEnServicio(txtNoMotor.Text.Trim) Then
                            MsgBox("La moto con el Número Motor. " + Me.txtNoMotor.Text.Trim + " está actualmente en Servicio de taller, aún no ha sido entregado al cliente.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                            Return False
                            Exit Function
                        End If
                    End If
                End If

            End If

            'Si es modo de FINALIZACION o MODIFICARENTREGA 
            If Me.TypeGui = FINALIZAR OrElse Me.TypeGui = MODIFICARENTREGA Then
                If Me.txtDiagnosticoTaller.Text.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.txtDiagnosticoTaller, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If Me.txtSolucion.Text.Trim.Length = 0 Then
                    Me.ErrTaller.SetError(Me.txtSolucion, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                'Verificar si hay salidas repuestos pendientes
                If Me.ExistenSalidasPendientesAutorizar() Then
                    MsgBox("No es posible Finalizar esta Orden de servicio, Aún hay salidas de repuesto pendientes de autorizar.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Me.TbcDatosRecepcionEntrega.SelectedTab = Me.tpSolicitudesRepuesto
                    Return False
                    Exit Function
                End If

            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    'Verificar si la moto de este expediente está actualmente en servicio sin entregar
    Private Function EstaExpedienteEnServicio(ByVal strExpediente As String) As Boolean
        Dim dtDatos As DataTable
        Dim strCampos, strSQL, strFiltro As String
        Dim blnResultado As Boolean = False

        Try
            If Not String.IsNullOrEmpty(strExpediente) Then
                strCampos = "count(StaServicioTallerID) as Cantidad"
                strFiltro = " objSccCuentaID= '" & strExpediente & "' AND objEstadoServicioID = " & Me.EstadoRecibidaID.ToString

                strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.StaServicioTaller", strFiltro)
                dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

                If dtDatos.Rows.Count <> 0 Then
                    If dtDatos.DefaultView.Item(0)("Cantidad") > 0 Then
                        blnResultado = True
                    End If
                End If
            End If
            Return blnResultado

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try        
    End Function

    'Verificar si la moto está en servicio a través del Número de motor.
    Private Function EstaMotoEnServicio(ByVal strNoMotor As String) As Boolean
        Dim dtDatos As DataTable
        Dim strCampos, strSQL, strFiltro As String
        Dim blnResultado As Boolean = False

        Try
            If Not String.IsNullOrEmpty(strNoMotor) Then
                strCampos = "count(StaServicioTallerID) as Cantidad"
                strFiltro = " NoMotorMoto = '" & strNoMotor & "' AND objEstadoServicioID = " & Me.EstadoRecibidaID.ToString

                strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.StaServicioTaller", strFiltro)
                dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

                If dtDatos.Rows.Count <> 0 Then
                    If dtDatos.DefaultView.Item(0)("Cantidad") > 0 Then
                        blnResultado = True
                    End If
                End If
            End If
            Return blnResultado

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    'Verifica si hay salidas de repuestos pendientes de aprobar
    Private Function ExistenSalidasPendientesAutorizar() As Boolean
        Return Me.dtSalidasRepuestos.Select("EstadoSalida='REGISTRADA'").Length <> 0
    End Function

#End Region

#Region "Guardar Servicio Taller"
    Private Function GuardarServicioTaller() As Boolean
        Dim T As New TransactionManager
        Dim objService As New StaServicioTaller
        Dim blnActivar As Boolean = False

        Try
            Try
                T.BeginTran()
                With objService
                    'Si el cliente tiene expediente, registrar expediente.
                    If Me.dtExpedienteCxC.Rows.Count > 0 AndAlso Me.cmbExpedientes.EditValue.ToString.Trim.Length <> 0 Then
                        .objSccCuentaID = Me.cmbExpedientes.EditValue
                        .objSccCuentaTiendaID = objSccCuentaTiendaID
                    End If
                    .objServicioTiendaID = Me.cmbSucursal.SelectedValue
                    .objClienteID = Me.cmbClientes.EditValue
                    .objTipoServicioID = Me.cmbTipoServicio.EditValue
                    .objEstadoServicioID = Me.cmbEstadoServicio.EditValue
                    .objTecnicoAsignadoID = Me.cmbTecnicoAsignado.EditValue
                    .FechaRecibida = clsProyecto.Conexion.FechaServidor
                    .objNivelCombustibleID = Me.cmbNivelesCombustible.EditValue
                    .objTipoKilometrajeID = Me.cmbKilometraje.EditValue
                    .ValorKilometraje = Me.spnValorKilometraje.Value
                    .ModeloMoto = Me.txtModelo.Text.Trim
                    .MarcaMoto = Me.txtMarca.Text.Trim
                    .NoMotorMoto = Me.txtNoMotor.Text.Trim
                    .ChasisMoto = Me.txtNoChasis.Text.Trim
                    .PlacaMoto = Me.txtPlaca.Text.Trim
                    .ColorMoto = Me.txtColor.Text.Trim
                    .ServicioGarantia = Me.chkEsServicioGarantia.Checked
                    If Me.chkEsServicioGarantia.Checked Then
                        .CantidadServiciosGarantia = CantidadServiciosGarantia + 1
                    Else
                        .CantidadServiciosGarantia = CantidadServiciosGarantia
                    End If
                    .ObservacionesJefeTaller = Me.txtObservacionesJefeTallerRecibir.Text.Trim
                    .FallasReportadasCliente = Me.txtFallasReportadasCliente.Text.Trim
                    .MotoRecibidaDe = Me.txtMotoRecibidaDE.Text.Trim
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .Insert(T)
                End With
                Me.StaServicioTallerID = objService.StaServicioTallerID

                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)

                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            T = Nothing
        End Try
    End Function
#End Region

#Region "Finalizar Servicio Taller (Entregar Moto)"
    Private Function FinalizarServicioTaller() As Boolean
        Dim objServicioTaller As New StaServicioTaller
        Dim T As New TransactionManager
        Try
            T.BeginTran()
            objServicioTaller.Retrieve(Me.StaServicioTallerID, T)
            With objServicioTaller
                .objEstadoServicioID = Me.EstadoEntregadaID
                .CambioAceite = Me.chkCambioAceite.Checked
                .LimpiezaCarburador = Me.chkLimpiezaCarburador.Checked
                .AjusteFrenos = Me.chkAjustesFrenos.Checked
                .AjusteCadenaSecundaria = Me.chkAjusteCadenaSecundaria.Checked
                .ChequeoTiempoEncendido = Me.chkChequeoTiempoEncendido.Checked
                .ChequeoBateria = Me.chkChequeoBateria.Checked()
                .RegulacionEmbrague = Me.chkRegulacionEmbrague.Checked
                .CalibrarValvulas = Me.chkCalibrarValvulas.Checked
                .EngraseEjeSuspensionTrasera = Me.chkSuspencionTrasera.Checked
                .EngraseEjeDelanteroTrasero = Me.chkEngraseTraseroDelantero.Checked
                .CambioFricciones = Me.chkCambioFricciones.Checked
                .Otros = Me.txtOtros.Text.Trim
                .FechaEntrega = clsProyecto.Conexion.FechaServidor
                .DiagnosticoTaller = Me.txtDiagnosticoTaller.Text.Trim
                .Solucion = Me.txtSolucion.Text.Trim
                .MotoEntregadaA = Me.txtMotoEntregadaA.Text.Trim
                .FechaModificacion = clsProyecto.Conexion.FechaServidor
                .UsuarioModificacion = clsProyecto.Conexion.Usuario
                .Update(T)
            End With

            T.CommitTran()
            MsgBox("Servicio actualizado correctamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Return True
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
            Return False
        Finally
            T = Nothing
        End Try

    End Function
#End Region

#Region "Cargar Datos de Servicio Taller"
    Private Sub CargarDatosServicioTaller(ByVal StaServicioTallerID As Integer)
        Dim objServicioTaller As New StaServicioTaller
        Try
            objServicioTaller.Retrieve(StaServicioTallerID)

            With objServicioTaller
                Me.txtNumeroServicio.Text = StaServicioTallerID
                Me.cmbSucursal.SelectedValue = .objServicioTiendaID
                Me.cmbClientes.EditValue = .objClienteID
                Me.cmbTipoServicio.EditValue = .objTipoServicioID
                Me.cmbTecnicoAsignado.EditValue = .objTecnicoAsignadoID
                Me.cmbEstadoServicio.EditValue = .objEstadoServicioID
                If Not IsDBNull(.FechaRecibida) Then
                    Me.dtpFechaHoraRecibida.Value = .FechaRecibida
                End If
                If Not String.IsNullOrEmpty(.ObservacionesJefeTaller) Then
                    Me.txtObservacionesJefeTallerRecibir.Text = .ObservacionesJefeTaller
                End If
                Me.txtMotoRecibidaDE.Text = .MotoRecibidaDe
                Me.cmbNivelesCombustible.EditValue = .objNivelCombustibleID
                Me.cmbKilometraje.EditValue = .objTipoKilometrajeID
                Me.spnValorKilometraje.Value = .ValorKilometraje
                If Not String.IsNullOrEmpty(.PlacaMoto) Then
                    Me.txtPlaca.Text = .PlacaMoto
                End If
                If Not String.IsNullOrEmpty(.ColorMoto) Then
                    Me.txtColor.Text = .ColorMoto
                End If

                If .ServicioGarantia.HasValue Then
                    Me.chkEsServicioGarantia.Checked = .ServicioGarantia
                    If Me.chkEsServicioGarantia.Checked Then
                        'Marcar servicios de garantía
                        If .CantidadServiciosGarantia.HasValue Then
                            Me.MarcarServiciosPorGarantia(Integer.Parse(.CantidadServiciosGarantia.Value))
                        End If
                    End If
                End If

                If Not String.IsNullOrEmpty(.FallasReportadasCliente) Then
                    Me.txtFallasReportadasCliente.Text = .FallasReportadasCliente
                End If

                'Datos que se llenan al entregar la moto al cliente
                If .CambioAceite.HasValue Then
                    Me.chkCambioAceite.Checked = .CambioAceite
                End If
                If .LimpiezaCarburador.HasValue Then
                    Me.chkLimpiezaCarburador.Checked = .LimpiezaCarburador
                End If
                If .AjusteFrenos.HasValue Then
                    Me.chkAjustesFrenos.Checked = .AjusteFrenos
                End If
                If .AjusteCadenaSecundaria.HasValue Then
                    Me.chkAjusteCadenaSecundaria.Checked = .AjusteCadenaSecundaria
                End If
                If .ChequeoTiempoEncendido.HasValue Then
                    Me.chkChequeoTiempoEncendido.Checked = .ChequeoTiempoEncendido
                End If

                If .ChequeoBateria.HasValue Then
                    Me.chkChequeoBateria.Checked = .ChequeoBateria
                End If

                If .RegulacionEmbrague.HasValue Then
                    Me.chkRegulacionEmbrague.Checked = .RegulacionEmbrague
                End If

                If .CalibrarValvulas.HasValue Then
                    Me.chkCalibrarValvulas.Checked = .CalibrarValvulas
                End If

                If .EngraseEjeSuspensionTrasera.HasValue Then
                    Me.chkSuspencionTrasera.Checked = .EngraseEjeSuspensionTrasera
                End If

                If .EngraseEjeDelanteroTrasero.HasValue Then
                    Me.chkEngraseTraseroDelantero.Checked = .EngraseEjeDelanteroTrasero
                End If
                If .CambioFricciones.HasValue Then
                    Me.chkCambioFricciones.Checked = .CambioFricciones
                End If

                If Not String.IsNullOrEmpty(.Otros) Then
                    Me.txtOtros.Text = .Otros.Trim
                End If

                If .FechaEntrega.HasValue Then
                    Me.dtpFechaHoraEntrega.Value = .FechaEntrega
                End If

                If Not String.IsNullOrEmpty(.DiagnosticoTaller) Then
                    Me.txtDiagnosticoTaller.Text = .DiagnosticoTaller
                End If

                If Not String.IsNullOrEmpty(.Solucion) Then
                    Me.txtSolucion.Text = .Solucion
                End If

                If Not String.IsNullOrEmpty(.MotoEntregadaA) Then
                    Me.txtMotoEntregadaA.Text = .MotoEntregadaA
                End If
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Grid Repuestos Solicitados"
    Private Sub CargarGridRepuestosSolicitados()
        Dim strCampos, strSQL, strFiltro As String
        Try
            strCampos = "SivRepuestoID, DescripcionCorta, Cantidad, costo, convert(varchar,FechaSalida,103) as FechaSalida, objTiendaID, objTipoSalidaID, objServicioTallerID, objSalidaBodegaID, objEstadoID, EstadoSalida"
            strFiltro = " objServicioTallerID = " & Me.StaServicioTallerID.ToString
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwServicioTallerSalidasRepuesto", strFiltro)

            dtSalidasRepuestos = SqlHelper.ExecuteQueryDT(strSQL)

            If dtSalidasRepuestos.Rows.Count > 0 Then
                Me.grdRepuestosTaller.SetDataBinding(dtSalidasRepuestos, "", True)
                'Formatear grid de repuestos para consulta.
                With Me.grdRepuestosTaller
                    '.AllowAddNew = False
                    .AllowUpdate = False
                    .AllowDelete = False
                    .AllowColMove = False
                    .FilterBar = False
                    .AllowSort = False
                    .AllowColMove = False
                    .EmptyRows = False 'no mostrar más filas después de la última
                    .Refresh()
                End With
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

End Class