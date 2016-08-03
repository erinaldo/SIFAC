'-- Autor: Gelmin Martínez
'-- Fecha: 11 Agosto 2010, 02:00 pm.
'-- Formulario para seleccionar parámetros de filtrado del reporte 
'-- de Bitácora de motocicleta.

Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmCriteriosReporteBitacoraMoto

#Region "Atributos"
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer
    Private dtDatosClientesGenericos As New DataTable
    Private dtDatosClientesCartera As New DataTable
    Private dtDatosMoto As New DataTable
    Private dtDatosExpedientes As New DataTable

#End Region

#Region "Propiedades"
    Property IdSucursalCentral() As Integer
        Get
            IdSucursalCentral = Me.m_IdSucursalCentral
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalCentral = value
        End Set
    End Property

    Property IdSucursalSession() As Integer
        Get
            IdSucursalSession = Me.m_IdSucursalSession
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalSession = value
        End Set
    End Property
#End Region

#Region "Cargar combos"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Sucursales
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Julio de 2010, 09:40 am.
    ''' </summary>
    Private Sub CargarComboSucursales()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("Activo=1 AND ActivoRepuesto=1", "Nombre", "StbTiendaID, Codigo, Nombre")
            With Me.cmbSucursales
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 40
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            'dtDatos.Rows.Add("0", "-", "TODAS")
            'Me.cmbSucursales.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Clientes Cartera"

#Region "Cargar combo Clientes Cartera"
    Private Sub CargarComboClientesCartera()
        Dim dtDatos As New DataTable
        Dim sSQL As String
        Try
            sSQL = clsConsultas.ObtenerConsultaGeneral("StbPersonaID, Cliente", "vwSfaClienteCotizacion", "1=1 ORDER BY Cliente")
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL)
            Me.cmbClientesCartera.Properties.DataSource = dtDatos

            If dtDatos.Rows.Count >= 7 Then
                Me.cmbClientesCartera.Properties.DropDownRows = 7
            Else
                Me.cmbClientesCartera.Properties.DropDownRows = dtDatos.Rows.Count
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar Expedientes de Clientes Cartera"
    Private Sub CargarExpedienteCartera(ByVal strClienteID As String)
        Dim strSQL, strCampos, strFiltro As String
        Try
            strCampos = "Numero, ISNULL(Moto,'') AS Moto"
            strFiltro = "objClienteID=" & "'" & strClienteID & "' ORDER BY Numero"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "vwSfaExpCxCCotizacion", strFiltro)

            Me.dtDatosExpedientes = DAL.SqlHelper.ExecuteQueryDT(strSQL)
            If dtDatosExpedientes.Rows.Count > 0 Then
                Me.CargarComboExpedientesCartera()
            Else
                Me.cmbExpedientes.Properties.DataSource = Me.dtDatosExpedientes
                Me.cmbExpedientes.EditValue = String.Empty
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar combo Expediente Cartera"
    Private Sub CargarComboExpedientesCartera()
        Dim dtDatos As New DataTable
        Dim fila As DataRow
        Try
            dtDatos.Reset()
            dtDatos.Columns.Add("Numero")
            dtDatos.Columns.Add("NumeroMostrar")
            dtDatos.Columns.Add("Moto")
            For Each row As DataRow In Me.dtDatosExpedientes.Rows
                fila = dtDatos.NewRow
                fila("Numero") = row("Numero")
                fila("NumeroMostrar") = row("Numero")
                fila("Moto") = row("Moto")
                dtDatos.Rows.Add(fila)
            Next

            'Agregar las columnas
            With Me.cmbExpedientes.Properties
                .DataSource = dtDatos
                .SearchMode = SearchMode.AutoFilter
                .Columns("Numero").Visible = False
                '.Columns("NumeroMostrar").Caption = "No. Cuenta"
                '.Columns("Moto").Caption = "Motocicleta"
                .AutoSearchColumnIndex = 0
                'Mostrar máximo 7 filas por defecto.
                If dtDatos.Rows.Count >= 7 Then
                    .DropDownRows = 7
                Else
                    If dtDatos.Rows.Count = 1 Then
                        .DropDownRows = 2
                    Else
                        .DropDownRows = dtDatos.Rows.Count
                    End If
                End If
                'Si sólo hay una fila seleccionarla automáticamente
                If dtDatos.Rows.Count >= 1 Then
                    cmbExpedientes.EditValue = dtDatos.DefaultView.Item(0)("Numero")
                End If
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#End Region

#Region "Otros Clientes"

#Region "Cargar combo Otro Cliente"
    Private Sub CargarComboOtrosClientes()
        'Dim dtDatos As New DataTable
        Dim sSQL As String
        Try
            sSQL = clsConsultas.ObtenerConsultaGeneral("DISTINCT objClienteID, Cliente", "dbo.vwStaServicioTallerBitacoraClientesGenericos", " 1=1 ORDER BY Cliente")
            dtDatosClientesGenericos = DAL.SqlHelper.ExecuteQueryDT(sSQL)

            'Agregar las columnas
            Dim columnas As LookUpColumnInfoCollection = Me.cmbOtrosClientes.Properties.Columns
            columnas.Add(New LookUpColumnInfo("objClienteID"))
            columnas.Add(New LookUpColumnInfo("Cliente"))
            With Me.cmbOtrosClientes.Properties
                .DataSource = dtDatosClientesGenericos
                .DisplayMember = "Cliente"
                .ValueMember = "objClienteID"
                .SearchMode = SearchMode.AutoFilter
                .AutoSearchColumnIndex = 1
                '.Columns("objClienteID").Visible = False
                If dtDatosClientesGenericos.Rows.Count >= 7 Then
                    .DropDownRows = 7
                Else
                    .DropDownRows = dtDatosClientesGenericos.Rows.Count
                End If
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar motos del cliente genérico"
    Private Sub CargarMotosDeCliente(ByVal strClienteID As String)
        Dim strSQL, strCampos, strFiltro As String

        Try
            If Not String.IsNullOrEmpty(strClienteID) Then
                strCampos = " DISTINCT objClienteID, NoMotorMoto, ModeloMoto, MarcaMoto, PlacaMoto, ColorMoto"
                strFiltro = "objClienteID='" & strClienteID & "'"
                strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwStaServicioTallerBitacoraClientesGenericos", strFiltro)

                dtDatosMoto = DAL.SqlHelper.ExecuteQueryDT(strSQL)

                If dtDatosMoto.Rows.Count > 0 Then
                    'Nota: En este combo las columnas se agregaron en tiempo de diseño porque los
                    'Datos se llenan dinámicamente dependiente del cliente que se seleccione
                    '
                    'Dim columnas As LookUpColumnInfoCollection = Me.cmbMotos.Properties.Columns
                    'columnas.Add(New LookUpColumnInfo("NoMotorMoto"))
                    'columnas.Add(New LookUpColumnInfo("ModeloMoto"))
                    'columnas.Add(New LookUpColumnInfo("MarcaMoto"))
                    'columnas.Add(New LookUpColumnInfo("PlacaMoto"))
                    'columnas.Add(New LookUpColumnInfo("ColorMoto"))

                    With Me.cmbMotos.Properties
                        .DataSource = dtDatosMoto
                        .DisplayMember = "NoMotorMoto"
                        .ValueMember = "NoMotorMoto"
                        .SearchMode = SearchMode.AutoFilter
                        .AutoSearchColumnIndex = 0
                        .Columns("NoMotorMoto").Caption = "No. Motor"
                        .Columns("NoMotorMoto").Width = 50
                        .Columns("ModeloMoto").Caption = "Modelo"
                        .Columns("MarcaMoto").Caption = "Marca"
                        .Columns("PlacaMoto").Caption = "Placa"
                        .Columns("ColorMoto").Caption = "Color"

                        '.Columns("objClienteID").Visible = False
                        If dtDatosMoto.Rows.Count >= 7 Then
                            .DropDownRows = 7
                        Else
                            If dtDatosMoto.Rows.Count = 1 Then
                                .DropDownRows = 2
                            Else
                                .DropDownRows = dtDatosMoto.Rows.Count
                            End If
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Cargar Formulario"
    Private Sub frmCriteriosReporteUtilidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.CargarComboSucursales()

        Me.VerificarSucursalRepuesto()

        'Me.CargarComboExpedientes()
        Me.CargarComboClientesCartera()
        Me.CargarComboOtrosClientes()

        'Me.cmbSucursales.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral
        Me.cmbSucursales.Enabled = False
    End Sub

#End Region

#Region "Verificar Sucursal Repuesto"
    Private Sub VerificarSucursalRepuesto()
        If String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            MsgBox("No ha configurado la sucursal en el utilitario de configuración del sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            If Me.cmbSucursales.FindStringExact(Me.IdSucursalSession.ToString, 0, 0) = -1 Then
                MsgBox("La sucursal configurada en la sesión del sistema, no es una sucursal de Repuestos", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.cmbSucursales.SelectedValue = Me.IdSucursalSession
            End If
        End If
    End Sub
#End Region

#Region "Eventos de Controles"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim strFiltro As String
        Dim blnCriterioCorrecto As Boolean
        blnCriterioCorrecto = Me.VerificarCriterios()
        If blnCriterioCorrecto Then
            strFiltro = Me.DevolverFiltro()
            Me.Imprimir_Reporte(strFiltro)
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrErrores.Clear()
    End Sub

    Private Sub cmbClientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOtrosClientes.EditValueChanged
        Try
            If Me.cmbOtrosClientes.EditValue <> Nothing AndAlso Me.cmbOtrosClientes.EditValue.ToString.Trim.Length <> 0 Then
                Me.CargarMotosDeCliente(Me.cmbOtrosClientes.EditValue.ToString.Trim)
                Me.chkOtrosClientes.Checked = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbClientesCartera_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClientesCartera.EditValueChanged
        Try
            If Me.cmbClientesCartera.EditValue <> Nothing AndAlso Me.cmbClientesCartera.EditValue.ToString.Trim.Length <> 0 Then
                Me.CargarExpedienteCartera(Me.cmbClientesCartera.EditValue.ToString.Trim)
                Me.chkClientesCartera.Checked = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkClientesCartera_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClientesCartera.CheckedChanged
        Me.chkOtrosClientes.Checked = Not Me.chkClientesCartera.Checked

        'Inicializar clientes cartera
        If Me.chkOtrosClientes.Checked Then
            Me.InicializarClientesCartera()
        End If
    End Sub

    Private Sub chkOtrosClientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOtrosClientes.CheckedChanged
        Me.chkClientesCartera.Checked = Not Me.chkOtrosClientes.Checked
        'inicializar otros clientes
        If Me.chkClientesCartera.Checked Then
            Me.InicializarOtrosClientes()
        End If
    End Sub

#End Region

#Region "Inicializar Datos de Combos al seleccionar"
    'Procedimiento que inicializa los datos de los criterios de Clientes cartera
    'cuando se selecciona Otros clientes
    Private Sub InicializarClientesCartera()
        Me.cmbClientesCartera.EditValue = String.Empty
        Me.cmbExpedientes.EditValue = String.Empty
        Me.dtDatosExpedientes.Rows.Clear()
        Me.cmbExpedientes.Properties.DataSource = Me.dtDatosExpedientes
    End Sub

    'Procedimiento que inicializa los datos de los criterios de Otros clientes cuando se selecciona clientes cartera.
    Private Sub InicializarOtrosClientes()
        Me.cmbOtrosClientes.EditValue = String.Empty
        Me.cmbMotos.EditValue = String.Empty
        Me.dtDatosMoto.Rows.Clear()
        Me.cmbMotos.Properties.DataSource = Me.dtDatosMoto
    End Sub
#End Region

#Region "Verificar Criterios"
    Private Function VerificarCriterios() As Boolean
        Dim blnValido As Boolean = True

        'Verificar si se seleccionó expediente.
        If Me.chkClientesCartera.Checked Then
            If Me.cmbExpedientes.EditValue = Nothing OrElse Me.cmbExpedientes.EditValue.ToString.Trim.Length = 0 Then
                MsgBox("No ha seleccionado un expediente.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                blnValido = False
                Exit Function
            End If
        End If

        If Me.chkOtrosClientes.Checked Then
            If Me.cmbMotos.EditValue = Nothing OrElse Me.cmbMotos.EditValue.ToString.Trim.Length = 0 Then
                MsgBox("No ha seleccionado una Moto.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                blnValido = False
                Exit Function
            End If
        End If

        Return blnValido

    End Function
#End Region

#Region "Devolver Filtro"
    ''' <summary>
    ''' Función encargada de construir y devolver el filtro que ocupará la consulta del reporte. 
    ''' este se construye en base a los criterios seleccionados por el usuario
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Julio de 2010, 09:56 am.
    ''' </summary>
    Private Function DevolverFiltro() As String
        Dim strFiltro As String = String.Empty

        'Si es un cliente de cartera
        If Me.chkClientesCartera.Checked Then
            If Me.cmbExpedientes.EditValue <> Nothing AndAlso Me.cmbExpedientes.EditValue.ToString.Trim.Length <> 0 Then
                strFiltro = " objSccCuentaID = '" + Me.cmbExpedientes.EditValue.ToString & "'"
            End If
        End If

        'Si es otro cliente
        If Me.chkOtrosClientes.Checked Then
            If Me.cmbMotos.EditValue <> Nothing AndAlso Me.cmbMotos.EditValue.ToString.Trim.Length <> 0 Then
                If String.IsNullOrEmpty(strFiltro) Then
                    strFiltro = " NoMotor = '" + Me.cmbMotos.EditValue.ToString & "'"
                Else
                    strFiltro = " AND NoMotor= '" + Me.cmbMotos.EditValue.ToString & "'"
                End If
            End If
        End If

        If String.IsNullOrEmpty(strFiltro) Then
            strFiltro = "1=0"
        End If

        Return strFiltro
    End Function
#End Region

#Region "Imprimir Reporte"
    Private Sub Imprimir_Reporte(ByVal strFiltro As String)
        Dim dtDatos As DataTable
        Dim strNombreReporte As String = String.Empty
        Dim strCampos, strSQL As String

        Dim Visor As New frmVisorRS
        Try
            strCampos = "StaServicioTallerID, NumeroServicio, Cliente, objServicioTiendaID, NombreTiendaServicio, CodigoTiendaServicio, objTipoServicioID, TipoServicio, EstadoServicio, convert(varchar,FechaRecibida,103) as FechaRecibida, convert(varchar,FechaEntrega,103) as FechaEntrega, objTecnicoAsignadoID, NombreTecnico, ModeloMoto, Chasis, NoMotor, MarcaMoto, TrabajosRealizados, objSccCuentaID, objSccCuentaTiendaID, NombreTiendaCuenta, CodigoTiendaCuenta"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwStaServicioTallerBitacoraMoto", strFiltro & " ORDER BY FechaRecibida")
            dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

            If dtDatos.Rows.Count <> 0 Then
                With Visor.VisorReportes
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .LocalReport.ReportEmbeddedResource = "SCCUM.rptServicioTallerBitacoraMoto.rdlc"
                    .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtDatosServicioTallerBitacoraMoto_vwStaServicioTallerBitacoraMoto", dtDatos))
                    Me.CargarEncabezadoReporte(.LocalReport)
                    .RefreshReport()
                End With
                Visor.ShowDialog()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
            Visor = Nothing
        End Try
    End Sub

    'Procedimiento encargado de cargar los datos del encabezado de reportes.
    Private Sub CargarEncabezadoReporte(ByRef reporte As Microsoft.Reporting.WinForms.LocalReport)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim strNombreEmpresa, strDirEmpresa, strTelEmpresa, strEmailEmpresa As String

        strNombreEmpresa = ClsCatalogos.GetValorParametro("EMPRESA")
        strDirEmpresa = ClsCatalogos.GetValorParametro("DireccionEmpresa")
        strTelEmpresa = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
        strEmailEmpresa = ClsCatalogos.GetValorParametro("EMAIL")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmNombreEmpresa", strNombreEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDireccionEmpresa", strDirEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmTelefonoEmpresa", strTelEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmEmailEmpresa", strEmailEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmUsuarioFecha", clsProyecto.Conexion.Usuario & " , " + Format(clsProyecto.Conexion.FechaServidor, "dd/MM/yyyy"), False))

        reporte.SetParameters(parametros)
    End Sub
#End Region

End Class