Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO
Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos


Public Class frmStbVisor

    Dim m_IDReporte As String
    Dim m_strFiltro As String
    Dim DtDatosNo As New DataTable

    Property IDReporte() As String
        Get
            IDReporte = Me.m_IDReporte
        End Get
        Set(ByVal value As String)
            Me.m_IDReporte = value
        End Set
    End Property
    Property strFiltro() As String
        Get
            strFiltro = m_strFiltro
        End Get
        Set(ByVal value As String)
            m_strFiltro = value
        End Set
    End Property

    Private Sub frmStbVisor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtDatos As New DataSet("DatosReporte")
        Dim dtDatosMaestro As New DataSet("DatosReporteDetalle")
        Dim dtDatosDetalle As New DataSet("DatosReporteMaster")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport

        Try
            Try
                Select Case Me.IDReporte

                    Case "MinutaPago"
                        Me.Text = "Reporte de Minuta de pago"
                        Me.TabControl1.Visible = False
                        Me.tstNotaCredito.Visible = False
                        Me.VisorReporte.Dock = DockStyle.Fill
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptSccAviso.rdlc"
                        'LocalReporte.ReportPath = "C:\Documents and Settings\Programador2\Escritorio\SCCUM\Fuente\prjSCCUM\Reportes\Orders2.rdlc"
                        nombre(0) = "DatosReporte"
                        'LocalReporte.p()

                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT * FROM vwRptSccMinuta where " & strFiltro, dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtDetalleMinuta_vwRptMinutaDetalle")
                        DsReporte.Name = "DtDetalleMinuta_vwRptMinutaDetalle"
                        DsReporte.Value = dtDatos.Tables("DatosReporte")

                        LocalReporte.DataSources.Add(DsReporte)

                        Me.VisorReporte.RefreshReport()

                    Case "MinutaCliente"

                        Me.Text = "Reporte de Clientes"
                        Me.TabControl1.Visible = False
                        Me.tstNotaCredito.Visible = False
                        Me.VisorReporte.Dock = DockStyle.Fill
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptClientes.rdlc"
                        nombre(0) = "DatosReporte"

                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT * FROM vwSccMinutaCobro where " & strFiltro, dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("dtMinutaCliente_vwSccMinutaCobro")
                        DsReporte.Name = "dtMinutaCliente_vwSccMinutaCobro"
                        DsReporte.Value = dtDatos.Tables("DatosReporte")

                        LocalReporte.DataSources.Add(DsReporte)

                        Me.VisorReporte.RefreshReport()

                    Case "EstadoCrediticio"
                        Me.Text = "Reporte de Estado Créditicio"
                        Me.CargarClientes(Me.cmbClientesEstCredt)
                        Me.CargarTiendas(Me.cmbSucursalEstCredit)
                        Me.CargarConcepto(Me.cmbConcepto)
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptEstadoCrediticio.rdlc"
                        nombre(0) = "DatosReporte"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT * FROM vwRptCuotasVencidasCliente WHERE Estado <> 'REGISTRADO'", dtDatos, nombre)

                        Dim DsReporte As New ReportDataSource("DtDatosCuotas_DatosReporte")
                        DsReporte.Name = "DtDatosCuotas_DatosReporte"

                        DsReporte.Value = dtDatos.Tables("DatosReporte")
                        LocalReporte.DataSources.Add(DsReporte)
                        Me.VisorReporte.RefreshReport()
                        Me.pagCuotasVencidas.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.tagpCarteraRangos.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()

                    Case "CuotasVencidas"
                        Me.Text = "Reporte de Cuotas Vencidas"
                        Me.CargarClientes(Me.cmbClientesCuotasV)
                        Me.CargarTiendas(Me.cmbSucursalCuotasV)
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptCuotas.rdlc"
                        nombre(0) = "DatosReporte"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT * FROM vwRptCuotasVencidasCliente WHERE Estado <> 'REGISTRADO'", dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtDatosCuotas_DatosReporte")
                        DsReporte.Name = "DtDatosCuotas_DatosReporte"
                        DsReporte.Value = dtDatos.Tables("DatosReporte")
                        LocalReporte.DataSources.Add(DsReporte)
                        Me.VisorReporte.RefreshReport()
                        Me.tabSeguimiento.Dispose()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.tagpCarteraRangos.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()
                        ''  DtDatosCuotas_RptCuotas()

                    Case "Devoluciones"
                        Me.Text = "Reporte de Devoluciones"
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        Me.CargarTiendas(Me.cmbSucursalDev)
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptDevoluciones.rdlc"
                        nombre(0) = "DatosReporte"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT * FROM vwRptDevoluciones", dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtDatosDevolucion_DatosDevoluciones")
                        DsReporte.Name = "DtDatosDevolucion_DatosDevoluciones"
                        DsReporte.Value = dtDatos.Tables("DatosReporte")
                        LocalReporte.DataSources.Add(DsReporte)
                        Me.VisorReporte.RefreshReport()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.pagCuotasVencidas.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.tagpCarteraRangos.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()
                        ''  DtDatosCuotas_RptCuotas()

                    Case "Seguimiento"
                        Me.Text = "Reporte de Seguimiento a Clientes"
                        Me.CargarUsuario(Me.cmbUsuario)
                        Me.CargarClientes(Me.cmbClientesSeg)
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptSeguimiento.rdlc"
                        nombre(0) = "DatosReporte"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT * FROM vwRptSeguimiento ORDER BY Fecha ASC", dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtDatosSeguimiento_DatosSeguimiento")
                        DsReporte.Name = "DtDatosSeguimiento_DatosSeguimiento"
                        DsReporte.Value = dtDatos.Tables("DatosReporte")
                        LocalReporte.DataSources.Add(DsReporte)
                        Me.VisorReporte.RefreshReport()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.pagCuotasVencidas.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.tagpCarteraRangos.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()

                    Case "EstadoCuenta"
                        Me.Text = "Reporte de Estado de Cuentas"
                        Me.CargarTiendas(Me.cmbSucursalEstadoCuenta)
                        Me.pagEstadoCrediticio.Dispose()
                        Me.pagCuotasVencidas.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.tagpCarteraRangos.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()

                        Me.ToolTip.Show("Para mostrar el Reporte, seleccione la forma de búsqueda e introduzca la información.", Me.cmdBuscarEstadoCuenta, 15000)
                        Me.rbtOpcion1.Checked = True
                        Select Case Me.rbtOpcion1.Checked
                            Case True
                                Me.txtNoExpEstadoCuenta.Enabled = False
                                Me.cmbNoExpediente.Enabled = True
                                Me.txtNoExpedienteCedula.Enabled = True
                                Me.cmbSucursalEstadoCuenta.Enabled = False
                            Case False
                                Me.txtNoExpEstadoCuenta.Enabled = True
                                Me.cmbSucursalEstadoCuenta.Enabled = True
                                Me.cmbNoExpediente.Enabled = False
                                Me.txtNoExpedienteCedula.Enabled = False
                        End Select

                    Case "Morosidad"
                        Me.Text = "Reporte de Morosidad"
                        Me.CargarTiendas(Me.cmbSucursalMor)
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptMorosidad.rdlc"
                        nombre(0) = "DatosReporte"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT SccCuentaID,ObjTiendaID,Numero,Concepto,StbPersonaID,Tienda,Mora30,Mora60,MoraOver60,Cliente FROM vwRptCuotasVencidasCliente WHERE Mora30 >0 or Mora60 >0 or MoraOver60 >0", dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtDatosMorosidad_DatosReporte")
                        DsReporte.Name = "DtDatosMorosidad_DatosReporte"
                        DsReporte.Value = dtDatos.Tables("DatosReporte")
                        LocalReporte.DataSources.Add(DsReporte)
                        Me.VisorReporte.RefreshReport()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.pagCuotasVencidas.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.tagpCarteraRangos.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()

                    Case "PorcentajeMorosidad"
                        Me.Text = "Reporte Consolidado de Clientes en Mora"
                        Me.CargarTiendas(Me.cmbSucursal)
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.RptCateraConsolida.rdlc"
                        nombre(0) = "vwRptCuotasVencidas"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "select Tienda,objTiendaID, sum(Moras30) as Mora30, sum(Mora60) as Mora60,sum(MoraOver60) as MoraOver60 , sum(d) as solvencia from (select Tienda,objTiendaID, count(Mora30) as Moras30,0 as Mora60, 0 as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where Mora30<>0 group by Tienda,objTiendaID  union select Tienda,objTiendaID, 0 as Mora30 , count(Mora60) as Moras60,0 as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where Mora60<>0 group by Tienda, objTiendaID union select Tienda, objTiendaID, 0 as Mora30 ,0 as Mora60, count(MoraOver60) as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where MoraOver60<>0 group by Tienda,objTiendaID union select Tienda, objTiendaID,  0 as Mora30, 0 as Mora60, 0 as MoraOver60, count(*) as d from vwRptCuotasVencidasCliente where CuotasVencidas =0 group by Tienda,objTiendaID) as Moras group by Tienda, objTiendaID order by Tienda", dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtMorosidadS_vwRptCuotasVencidas")
                        DsReporte.Name = "DtMorosidadS_vwRptCuotasVencidas"
                        DsReporte.Value = dtDatos.Tables("vwRptCuotasVencidas")
                        LocalReporte.DataSources.Add(DsReporte)
                        Me.VisorReporte.RefreshReport()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.pagCuotasVencidas.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.tagpCarteraRangos.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()

                    Case "SaldoConsolidado"
                        Me.Text = "Reporte de Saldo Consolidado"
                        Me.CargarTiendas(Me.cmbSucursalSaldo)
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.RptSaldoConsolidada.rdlc"
                        nombre(0) = "vwCuentaRoles"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT vwRptCuotasVencidasCliente.objTiendaID,vwRptCuotasVencidasCliente.Tienda,sum(Mora30) as Mora30,sum(Mora60) as Mora60,sum(MoraOver60) as MoraOver60, sum(vwRptCuotasVencidasCliente.Saldo)as Saldo FROM vwRptCuotasVencidasCliente, SccCuentaPorCobrar WHERE SccCuentaPorCobrar.SccCuentaID = vwRptCuotasVencidasCliente.SccCuentaID group by vwRptCuotasVencidasCliente.objTiendaID,vwRptCuotasVencidasCliente.Tienda order by Tienda", dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtSaldoConsolidada_vwCuentaRoles")
                        DsReporte.Value = dtDatos.Tables("vwCuentaRoles")
                        LocalReporte.DataSources.Add(DsReporte)
                        Me.VisorReporte.RefreshReport()
                        Me.pagCuotasVencidas.Dispose()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.tagpCarteraRangos.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()

                    Case ("CarteraXRangos")
                        Me.Text = "Reporte de Cartera por Rangos"
                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptCarteraRangos.rdlc"
                        nombre(0) = "vwRptCarteraRangos"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT SfaFacturaID, SccCuentaID, objTiendaID, Tienda, Cliente, Moras30, Mora60, MoraOver60, MoraTramiteLegal, Solventes, SaldoMora30, SaldoMora60, SaldoMoraOver60, SaldoMoraTramitaLegal, Saldo FROM vwRptCarteraRangos where 1 = 1 order by Tienda,Cliente ", dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtCarteraRangos_vwRptCarteraRangos")
                        DsReporte.Value = dtDatos.Tables("vwRptCarteraRangos")
                        LocalReporte.DataSources.Add(DsReporte)
                        Me.CargarTiendas(Me.cmbTiendaCartera)

                        Me.VisorReporte.RefreshReport()
                        Me.pagCuotasVencidas.Dispose()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.TabHistorialClientes.Dispose()

                    Case "HistorialClientes"
                        'Remover demás pestañas y solo dejar la de historial de cliente
                        Me.pagCuotasVencidas.Dispose()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.TabRecuperacionComp.Dispose()
                        Me.tagpCarteraRangos.Dispose()

                        Me.Text = "Historial de Clientes"
                        Me.CargarTiendas(Me.cmbSucursalHistorial)
                        Me.CargarClientes(Me.cmbClientesHistorial)

                        Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        LocalReporte = Me.VisorReporte.LocalReport
                        LocalReporte.ReportEmbeddedResource = "SCCUM.rptHistorialClientes.rdlc"
                        nombre(0) = "vwRptHistorialClientes"
                        SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, _
                               "SELECT Expediente, objTiendaID, Sucursal, Cedula, stbPersonaID, NombreCliente, Departamento, Direccion, " & _
                                   "CentroLaboral, DireccionTrabajo, TelefonoOficina, TelefonoCasa, Celular, " & _
                                   "NombreFiador, DptoFiador, DireccionFiador, CentroLaboralFiador, " & _
                                   "DireccionTrabajoFiador, TelefonoOficinaFiador, TelefonoCasaFiador, " & _
                                   "CelularFiador, ModeloMoto, Chasis, NoMotor, GarantiaExtendida,EstadoCuenta, CalificacionCuenta," & _
                                   "FechaCredito, PlazoCantidadCuotas, FechaVencimiento, SaldoTotalInicial, Prima, " & _
                                   "CuotaMensualMoto, CuotaMensualGarantia, SaldoCorrienteMoto, SaldoCorrienteGarantia, " & _
                                   "SaldoCorrienteTotal, CuotasTranscurridas, CuotasPagadasMoto, CuotasPagadasGarantia, CuotasVencidasMoto, " & _
                                   "CuotasVencidasGarantia, SaldoVencidoMoto, SaldoVencidoGarantia, Cargos, TotalSaldosVencidos, " & _
                                   "FechaUltimoPago, MesesSinMovimiento, FechaUltimoSeguimiento, TipoGestion, DescripcionBitacora, Usuario FROM vwRptHistorialClientes", dtDatos, nombre)
                        Dim DsReporte As New ReportDataSource("DtDatosHistorialClientes_vwRptHistorialClientes")
                        DsReporte.Value = dtDatos.Tables("vwRptHistorialClientes")
                        LocalReporte.DataSources.Add(DsReporte)

                        Me.VisorReporte.RefreshReport()

                    Case "RecuperacionComparativo"
                        'Remover demás pestañas y solo dejar la de historial de cliente
                        Me.pagCuotasVencidas.Dispose()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.TabPorcentaje.Dispose()
                        Me.tabSeguimiento.Dispose()
                        Me.tabDevoluciones.Dispose()
                        Me.tbEstadoCuentas.Dispose()
                        Me.tbMorosidad.Dispose()
                        Me.pagEstadoCrediticio.Dispose()
                        Me.TabSaldo.Dispose()
                        Me.TabHistorialClientes.Dispose()
                        Me.tagpCarteraRangos.Dispose()

                        Me.Text = "Recuperación Comparativo"
                        Me.CargarTiendas(Me.cmbSucursalesRecuperacionCmp)

                        'Me.ReporteRecuperacionComparativo()

                End Select

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    Private Sub CargarReporteCuotasVencidas()
        Try

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Cargar las Tiendas 
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 6 de Abril dee 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarTiendas(ByVal Combo As C1.Win.C1List.C1Combo)
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("", "Nombre", "StbTiendaID,Nombre")
            With Combo
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    ''' <summary>
    ''' Procedimiento encargado de Cargar los Clientes
    ''' Autor : Pedro Pablo Tinoco 
    ''' Fecha 06 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarClientes(ByVal Combo As C1.Win.C1List.C1Combo)
        Dim dtDatos As New DataTable
        Try
            dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("NombreCompleto,StbPersonaID", "vwPersonaClasificacion", " Descripcion= 'Cliente' ORDER BY NombreCompleto"))
            With Combo
                .DataSource = dtDatos
                .DisplayMember = "NombreCompleto"
                .ValueMember = "StbPersonaID"
                .Splits(0).DisplayColumns("StbPersonaID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar los Clientes
    ''' Autor : Pedro Pablo Tinoco 
    ''' Fecha 06 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarConcepto(ByVal Combo As C1.Win.C1List.C1Combo)
        Dim dtDatos As New DataTable
        Try
            dtDatos = ClsCatalogos.ObtenerValCat("CONCEPTOFACTURA")
            With Combo
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub




#Region "Busqueda de Estado Crediticio"


    Private Sub cmdBuscarEstadoCredi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarEstadoCredi.Click
        Select Case Me.IDReporte
            Case "EstadoCrediticio"
                Me.BuscarEstadoCrediticio()
        End Select
            
    End Sub


    Private Sub BuscarEstadoCrediticio()
        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport


        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(5) As SqlParameter
        Try
            Try

            
            ' Parametro Tienda
            Parametros(0) = New SqlParameter
            Parametros(0).ParameterName = "@TiendaID"
            Parametros(0).SqlDbType = SqlDbType.Int

            ' Parametros Cliente
            Parametros(1) = New SqlParameter
            Parametros(1).ParameterName = "@ClienteID"
            Parametros(1).SqlDbType = SqlDbType.NVarChar
            Parametros(1).Size = 16

            Parametros(2) = New SqlParameter
            Parametros(2).ParameterName = "@ExpedienteID"
            Parametros(2).SqlDbType = SqlDbType.NVarChar
                Parametros(2).Size = 15

            Parametros(3) = New SqlParameter
            Parametros(3).ParameterName = "@FacturaID"
            Parametros(3).SqlDbType = SqlDbType.NVarChar
                Parametros(3).Size = 12

                Parametros(4) = New SqlParameter
                Parametros(4).ParameterName = "@Concepto"
                Parametros(4).SqlDbType = SqlDbType.Int


            If Me.cmbSucursalEstCredit.Text <> "" Then
                Parametros(0).Value = Me.cmbSucursalEstCredit.SelectedValue
                strFiltro = "objTiendaID = @TiendaID"
            End If

                If Me.cmbClientesEstCredt.Text <> "" Or Trim(Me.txtCedula.Text) <> "" Then
                    If Trim(Me.txtCedula.Text) <> "" Then
                        Parametros(1).Value = Trim(Me.txtCedula.Text)
                    Else
                        Parametros(1).Value = Me.cmbClientesEstCredt.SelectedValue
                    End If
                    If strFiltro = "" Then
                        strFiltro = "StbPersonaID = @ClienteID"
                    Else
                        strFiltro = strFiltro + " AND StbPersonaID = @ClienteID"
                    End If
                End If

            If Trim(Me.txtExpedienteEstCredt.Text) <> "" Then
                Parametros(2).Value = Trim(Me.txtExpedienteEstCredt.Text)
                If strFiltro = "" Then
                    strFiltro = "SccCuentaID = @ExpedienteID"
                Else
                    strFiltro = strFiltro + " AND SccCuentaID = @ExpedienteID"
                End If
            End If

            If Trim(Me.txtNoFactEstCredt.Text) <> "" Then
                Parametros(3).Value = Trim(Me.txtNoFactEstCredt.Text)
                If strFiltro = "" Then
                    strFiltro = "Numero = @FacturaID"
                Else
                    strFiltro = strFiltro + " AND Numero = @FacturaID"
                End If
                End If

                If Trim(Me.cmbConcepto.Text) <> "" Then
                    Parametros(4).Value = Trim(Me.cmbConcepto.SelectedValue)
                    If strFiltro = "" Then
                        strFiltro = " objConceptoFactura = @Concepto"
                    Else
                        strFiltro = strFiltro + " AND objConceptoFactura = @Concepto"
                    End If
                End If



            If strFiltro = "" Then
                    strFiltro = " Estado <> 'REGISTRADO'"
                Else
                    strFiltro = strFiltro + " AND Estado <> 'REGISTRADO'"
                End If

            Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptEstadoCrediticio.rdlc"
                nombre(0) = "DatosReporte"
                If Me.chkClienteFiador.Checked Then
                    strConsulta = clsConsultas.ObtenerConsultaGeneral("*", "vwRptCuotasVencidas", strFiltro)
                Else
                    strConsulta = clsConsultas.ObtenerConsultaGeneral("*", "vwRptCuotasVencidasCliente", strFiltro)
                End If

                SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre, Parametros)

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

            Dim DsReporte As New ReportDataSource("DtDatosCuotas_DatosReporte")
            DsReporte.Name = "DtDatosCuotas_DatosReporte"
                DsReporte.Value = dtDatos.Tables("DatosReporte")
                LocalReporte.DataSources.Clear()
            LocalReporte.DataSources.Add(DsReporte)
            Me.VisorReporte.RefreshReport()

        Catch ex As Exception
            clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            Parametros = Nothing
        End Try
    End Sub

#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBCuotasV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBCuotasV.Click
        Call Me.BuscarCuotasVencidas()
    End Sub

#Region "Cuotas Vencidas"
    Private Sub BuscarCuotasVencidas()
        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport


        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(4) As SqlParameter
        Try
            Try


                ' Parametro Tienda
                Parametros(0) = New SqlParameter
                Parametros(0).ParameterName = "@TiendaID"
                Parametros(0).SqlDbType = SqlDbType.Int

                ' Parametros Cliente
                Parametros(1) = New SqlParameter
                Parametros(1).ParameterName = "@ClienteID"
                Parametros(1).SqlDbType = SqlDbType.NVarChar
                Parametros(1).Size = 16

                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@ExpedienteID"
                Parametros(2).SqlDbType = SqlDbType.NVarChar
                Parametros(2).Size = 12

                Parametros(3) = New SqlParameter
                Parametros(3).ParameterName = "@CuotasVencidas"
                Parametros(3).SqlDbType = SqlDbType.NVarChar
                Parametros(3).Size = 12

                If Me.cmbSucursalCuotasV.Text <> "" Then
                    Parametros(0).Value = Me.cmbSucursalCuotasV.SelectedValue
                    strFiltro = "objTiendaID = @TiendaID"
                End If

                If Me.cmbClientesCuotasV.Text <> "" Or Trim(Me.txtCedCuotasV.Text) <> "" Then
                    If Trim(Me.txtCedCuotasV.Text) <> "" Then
                        Parametros(1).Value = Trim(Me.txtCedCuotasV.Text)
                    Else
                        Parametros(1).Value = Me.cmbClientesCuotasV.SelectedValue
                    End If
                    If strFiltro = "" Then
                        strFiltro = "StbPersonaID = @ClienteID"
                    Else
                        strFiltro = strFiltro + " AND StbPersonaID = @ClienteID"
                    End If
                End If

                If Trim(Me.txtExpCuotasVenc.Text) <> "" Then
                    Parametros(2).Value = Trim(Me.txtExpCuotasVenc.Text)
                    If strFiltro = "" Then
                        strFiltro = "SccCuentaID = @ExpedienteID"
                    Else
                        strFiltro = strFiltro + " AND SccCuentaID = @ExpedienteID"
                    End If
                End If

                If Trim(Me.txtCantVenc.Text) <> "" Then
                    Parametros(3).Value = Trim(Me.txtCantVenc.Text)
                    If strFiltro = "" Then
                        strFiltro = "CuotasVencidas = @CuotasVencidas"
                    Else
                        strFiltro = strFiltro + " AND CuotasVencidas = @CuotasVencidas"
                    End If
                End If

                If strFiltro = "" Then
                    strFiltro = "Tipo = 'Cliente' and Estado <> 'REGISTRADO'"
                Else
                    strFiltro = strFiltro + " And Tipo = 'Cliente' AND Estado <> 'REGISTRADO'"
                End If

                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptCuotas.rdlc"
                nombre(0) = "DatosReporte"
                strConsulta = clsConsultas.ObtenerConsultaGeneral("*", "vwRptCuotasVencidas", strFiltro)
                SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre, Parametros)

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim DsReporte As New ReportDataSource("DtDatosCuotas_DatosReporte")
                DsReporte.Name = "DtDatosCuotas_DatosReporte"
                DsReporte.Value = dtDatos.Tables("DatosReporte")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(DsReporte)
                Me.VisorReporte.RefreshReport()

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            Parametros = Nothing
        End Try
    End Sub
#End Region

#Region "Devolucion"

    Private Sub BuscarDevoluciones()
        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(4) As SqlParameter
        Try
            Try

                ' Parametro Tienda
                Parametros(0) = New SqlParameter
                Parametros(0).ParameterName = "@TiendaID"
                Parametros(0).SqlDbType = SqlDbType.Int

                ' Parametros Cliente
                Parametros(1) = New SqlParameter
                Parametros(1).ParameterName = "@NoDevolucion"
                Parametros(1).SqlDbType = SqlDbType.NVarChar
                Parametros(1).Size = 16

                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@FechaInicio"
                Parametros(2).SqlDbType = SqlDbType.DateTime
                Parametros(2).Size = 13

                Parametros(3) = New SqlParameter
                Parametros(3).ParameterName = "@FechaFin"
                Parametros(3).SqlDbType = SqlDbType.DateTime
                Parametros(3).Size = 13

                If Me.cmbSucursalDev.Text <> "" Then
                    Parametros(0).Value = Me.cmbSucursalDev.SelectedValue
                    strFiltro = "objTiendaID = @TiendaID"
                End If


                If Trim(Me.txtNoDevolucion.Text) <> "" Then
                    Parametros(1).Value = Trim(Me.txtNoDevolucion.Text)
                    If strFiltro = "" Then
                        strFiltro = " NumeroDev = @NoDevolucion"
                    Else
                        strFiltro = strFiltro + " AND NumeroDev = @NoDevolucion"
                    End If
                End If

                If Trim(Me.dtpFechaInicioDev.Text) <> "" And Trim(Me.dtpFechaFinDev.Text) = "" Then
                    Parametros(2).Value = Trim(Me.dtpFechaInicioDev.Value)
                    If strFiltro = "" Then
                        strFiltro = "FechaC = @FechaInicio"
                    Else
                        strFiltro = strFiltro + " AND FechaC = @FechaInicio"
                    End If
                ElseIf Trim(Me.dtpFechaInicioDev.Text) = "" And Trim(Me.dtpFechaFinDev.Text) <> "" Then
                    Parametros(3).Value = Trim(Me.dtpFechaFinDev.Value)
                    If strFiltro = "" Then
                        strFiltro = "FechaC = @FechaFin"
                    Else
                        strFiltro = strFiltro + " AND FechaC = @FechaFin"
                    End If
                ElseIf Trim(Me.dtpFechaInicioDev.Text) <> "" And Trim(Me.dtpFechaFinDev.Text) <> "" Then
                    Parametros(2).Value = Trim(Me.dtpFechaInicioDev.Value)
                    Parametros(3).Value = Trim(Me.dtpFechaFinDev.Value)
                    If strFiltro = "" Then
                        strFiltro = " FechaC BETWEEN @FechaInicio AND @FechaFin"
                    Else
                        strFiltro = strFiltro + " AND FechaC BETWEEN @FechaInicio and @FechaFin"
                    End If
                End If

                If strFiltro = "" Then
                    strFiltro = "1=1"
                End If

                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptDevoluciones.rdlc"
                nombre(0) = "DatosReporte"
                strConsulta = clsConsultas.ObtenerConsultaGeneral("*", "vwRptDevoluciones", strFiltro)
                SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre, Parametros)

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim DsReporte As New ReportDataSource("DtDatosDevolucion_DatosDevoluciones")
                DsReporte.Name = "DtDatosDevolucion_DatosDevoluciones"
                DsReporte.Value = dtDatos.Tables("DatosReporte")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(DsReporte)
                Me.VisorReporte.RefreshReport()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            Parametros = Nothing
        End Try
    End Sub

#End Region

#Region "Buscar Usuarios"

    ''' <summary>
    ''' Procedimiento Encargado de Realizar la Busqueda de los Seguimientos Realizados
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 15 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarSeguimientos()
        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(5) As SqlParameter
        Try
            Try
                ' Parametros Cliente
                Parametros(1) = New SqlParameter
                Parametros(1).ParameterName = "@ClienteID"
                Parametros(1).SqlDbType = SqlDbType.NVarChar
                Parametros(1).Size = 16

                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@FechaInicio"
                Parametros(2).SqlDbType = SqlDbType.DateTime
                Parametros(2).Size = 15

                Parametros(3) = New SqlParameter
                Parametros(3).ParameterName = "@FechaFin"
                Parametros(3).SqlDbType = SqlDbType.DateTime
                Parametros(3).Size = 15

                Parametros(4) = New SqlParameter
                Parametros(4).ParameterName = "@Usuario"
                Parametros(4).SqlDbType = SqlDbType.VarChar
                Parametros(4).Size = 50

                If Me.cmbClientesSeg.Text <> "" Or Trim(Me.txtCedClientes.Text) <> "" Then
                    If Trim(Me.txtCedClientes.Text) <> "" Then
                        Parametros(1).Value = Trim(Me.txtCedClientes.Text)
                    Else
                        Parametros(1).Value = Me.cmbClientesSeg.SelectedValue
                    End If

                    If strFiltro = "" Then
                        strFiltro = "StbPersonaID = @ClienteID"
                    Else
                        strFiltro = strFiltro + " AND StbPersonaID = @ClienteID"
                    End If
                End If

                If Trim(Me.dtpFecIniSeg.Text) <> "" And Trim(Me.dtpFechFinSeg.Text) = "" Then
                    Parametros(2).Value = Trim(Me.dtpFecIniSeg.Value)
                    If strFiltro = "" Then
                        strFiltro = "FechaComp = @FechaInicio"
                    Else
                        strFiltro = strFiltro + " AND FechaComp = @FechaInicio"
                    End If
                ElseIf Trim(Me.dtpFecIniSeg.Text) = "" And Trim(Me.dtpFechFinSeg.Text) <> "" Then
                    Parametros(3).Value = Trim(Me.dtpFechFinSeg.Value)
                    If strFiltro = "" Then
                        strFiltro = "FechaComp = @FechaFin"
                    Else
                        strFiltro = strFiltro + " AND FechaComp = @FechaFin"
                    End If
                ElseIf Trim(Me.dtpFecIniSeg.Text) <> "" And Trim(Me.dtpFechFinSeg.Text) <> "" Then
                    Parametros(2).Value = Trim(Me.dtpFecIniSeg.Value)
                    Parametros(3).Value = Trim(Me.dtpFechFinSeg.Value)
                    If strFiltro = "" Then
                        strFiltro = " FechaComp BETWEEN @FechaInicio AND @FechaFin"
                    Else
                        strFiltro = strFiltro + " AND FechaComp BETWEEN @FechaInicio and @FechaFin"
                    End If
                End If

                If Me.cmbUsuario.Text <> "" Then
                    Parametros(4).Value = Me.cmbUsuario.SelectedValue
                    If strFiltro = "" Then
                        strFiltro = " UsuarioCreacion = @Usuario"
                    Else
                        strFiltro = strFiltro + " AND UsuarioCreacion = @Usuario"
                    End If
                End If

                If strFiltro = "" Then
                    strFiltro = "1=1"
                End If

                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptSeguimiento.rdlc"
                nombre(0) = "DatosReporte"
                strConsulta = clsConsultas.ObtenerConsultaGeneral("*", "vwRptSeguimiento", strFiltro)
                strConsulta = strConsulta + " ORDER BY Fecha"
                SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre, Parametros)

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim DsReporte As New ReportDataSource("DtDatosSeguimiento_DatosSeguimiento")
                DsReporte.Name = "DtDatosSeguimiento_DatosSeguimiento"
                DsReporte.Value = dtDatos.Tables("DatosReporte")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(DsReporte)
                Me.VisorReporte.RefreshReport()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            Parametros = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar Usuarios"
    Private Sub CargarUsuario(ByVal Combo As C1.Win.C1List.C1Combo)
        Dim dtDatos As New DataTable
        Try
            dtDatos = SsgCuenta.RetrieveDT("Activo=1", , "Login")
            With Combo
                .DataSource = dtDatos
                .DisplayMember = "Login"
                .ValueMember = "Login"
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "EstadoCuenta"
    Private Sub ReporteEstadoCuenta()
        Dim dtDatosFact As New DataTable
        Dim dtDatosND As New DataTable
        Dim dtRecibos As New DataTable
        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(3) As SqlParameter
        Try
            Try
                ' Parametros Cliente
                Parametros(0) = New SqlParameter
                Parametros(0).ParameterName = "@ClienteID"
                Parametros(0).SqlDbType = SqlDbType.NVarChar
                Parametros(0).Size = 16

                Parametros(1) = New SqlParameter
                Parametros(1).ParameterName = "@CuentaID"
                Parametros(1).SqlDbType = SqlDbType.NVarChar
                Parametros(1).Size = 10

                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@SucursalID"
                Parametros(2).SqlDbType = SqlDbType.Int

                Select Case Me.rbtOpcion1.Checked
                    Case True
                        If Me.cmbNoExpediente.Text <> "" And Me.txtNoExpedienteCedula.Text <> "" Then
                            strFiltro = "objSccCuentaID = @CuentaID AND StbPersonaID = @ClienteID"
                            Parametros(1).Value = Trim(Me.cmbNoExpediente.Text)
                            Parametros(0).Value = Trim(Me.txtNoExpedienteCedula.Text)
                        Else
                            MsgBox("Ambos parámetros de búsqueda deben poseer Valor", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        End If

                    Case False
                        If Trim(Me.txtNoExpEstadoCuenta.Text) <> "" And Me.cmbSucursalEstadoCuenta.Text <> "" Then
                            strFiltro = "objSccCuentaID = @CuentaID AND objTiendaID = @SucursalID"
                            Parametros(1).Value = Trim(Me.txtNoExpEstadoCuenta.Text.Trim)
                            Parametros(2).Value = Me.cmbSucursalEstadoCuenta.SelectedValue
                        End If
                End Select
                
                If strFiltro = "" Then
                    MsgBox("Necesita Introducir un parámetro de Búsqueda", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                'strConsulta = clsConsultas.ObtenerConsultaGeneral("*, right(fecha,4)+ substring(fecha,4,2)+ left(fecha,2) AS FechaOrder  ", " vwRptEstadoCuentasFact", strFiltro)
                strConsulta = clsConsultas.ObtenerConsultaGeneral("*", " vwRptEstadoCuentasFact", strFiltro)
                'strConsulta = strConsulta + " ORDER BY FechaOrder "
                strConsulta = strConsulta + " ORDER BY Fecha ASC"
                dtDatosFact = SqlHelper.ExecuteQueryDT(strConsulta, Parametros)
                strConsulta = clsConsultas.ObtenerConsultaGeneral("*", " vwRptEstadoCuentasND ", strFiltro)
                strConsulta = strConsulta + " ORDER BY Fecha ASC"
                dtDatosND = SqlHelper.ExecuteQueryDT(strConsulta, Parametros)
                strConsulta = clsConsultas.ObtenerConsultaGeneral("*", " vwEstadoCuentasRec ", strFiltro)
                strConsulta = strConsulta + " ORDER BY Fecha ASC"
                dtRecibos = SqlHelper.ExecuteQueryDT(strConsulta, Parametros)
                strConsulta = clsConsultas.ObtenerConsultaGeneral("*", " vwRptEstadoCuentasFact", "1=0")
                strConsulta = strConsulta + " ORDER BY Fecha ASC"
                nombre(0) = "DatosReporte"
                SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre)
                dtDatos.Tables("DatosReporte").DefaultView.Sort = "Fecha ASC"

                Dim DtRw As DataRow
                Dim Empleado As String = "Desconocido"
                Dim Cargo As String = "Desconocido"
                ''=== Agregamos los Datos Correspondientes a la Factura 
                For Each rw As DataRow In dtDatosFact.Rows
                    DtRw = dtDatos.Tables("DatosReporte").NewRow
                    DtRw("Tipo") = rw("Tipo")
                    DtRw("Numero") = rw("Numero")
                    DtRw("MontoTotal") = rw("MontoTotal")
                    If rw("Concepto") = "Factura Motos" Then
                        rw("Concepto") = "Factura de Moto"
                    End If
                    DtRw("Concepto") = rw("Concepto")
                    DtRw("Debe") = rw("Debe")
                    DtRw("Haber") = rw("Haber")
                    DtRw("Cargos") = rw("Cargos")
                    DtRw("Abono") = rw("Abono")
                    DtRw("objSccCuentaID") = rw("ObjSccCuentaID")
                    DtRw("ObjTiendaID") = rw("ObjTiendaID")
                    DtRw("Cliente") = rw("Cliente")
                    DtRw("StbPersonaID") = rw("StbPersonaID")
                    DtRw("Fecha") = rw("Fecha")
                    DtRw("SaldoTotal") = rw("SaldoTotal")
                    DtRw("SaldoInicial") = rw("SaldoInicial")
                    DtRw("FechaActual") = rw("FechaActual")
                    DtRw("ResponsableCartera") = rw("ResponsableCartera")
                    DtRw("Cargo") = rw("Cargo")
                    Empleado = rw("ResponsableCartera")
                    Cargo = rw("Cargo")
                    DtRw("Saldo") = 0.0
                    'DtRw("FechaOrder") = rw("FechaOrder")

                    dtDatos.Tables("DatosReporte").Rows.Add(DtRw)

                Next
                ''=== Agregamos los Datos Correspondientes a la Nota de Debito
                For Each rw As DataRow In dtDatosND.Rows
                    DtRw = dtDatos.Tables("DatosReporte").NewRow
                    DtRw("Tipo") = rw("Tipo")
                    DtRw("Numero") = rw("Numero")
                    DtRw("MontoTotal") = rw("MontoTotal")                    
                    DtRw("Concepto") = rw("Concepto")
                    DtRw("Debe") = rw("Debe")
                    DtRw("Haber") = rw("Haber")
                    DtRw("Cargos") = rw("Cargos")
                    DtRw("Abono") = rw("Abono")
                    DtRw("objSccCuentaID") = rw("ObjSccCuentaID")
                    DtRw("ObjTiendaID") = rw("ObjTiendaID")
                    DtRw("Cliente") = rw("Cliente")
                    DtRw("StbPersonaID") = rw("StbPersonaID")
                    DtRw("Fecha") = rw("Fecha")
                    DtRw("SaldoTotal") = rw("SaldoTotal")
                    DtRw("SaldoInicial") = rw("SaldoInicial")
                    DtRw("FechaActual") = rw("FechaActual")
                    DtRw("Saldo") = 0.0
                    DtRw("ResponsableCartera") = Empleado
                    DtRw("Cargo") = Cargo
                    'DtRw("FechaOrder") = rw("FechaOrder")
                    dtDatos.Tables("DatosReporte").Rows.Add(DtRw)

                Next
                ''=== Agregamos los Datos Correspondientes al Recibo de Caja.
                For Each rw As DataRow In dtRecibos.Rows
                    DtRw = dtDatos.Tables("DatosReporte").NewRow
                    DtRw("Tipo") = rw("Tipo")
                    DtRw("Numero") = rw("Numero")
                    DtRw("MontoTotal") = rw("MontoTotal")

                    If (rw("TotalND") > 0) And (rw("TotalFacturas") > 0) Then
                        DtRw("Concepto") = "Abono de Cuotas y pago de Nota de Débito"
                    ElseIf (rw("TotalFacturas") > 0) And (rw("TotalND") = 0) Then
                        If IsDBNull(rw("Numero")) Then
                            DtRw("Concepto") = "Reestructuración de Cuenta"
                        Else
                            DtRw("Concepto") = "Abono de Cuotas"
                        End If
                    ElseIf (rw("TotalFacturas") = 0) And (rw("TotalND") > 0) Then
                        DtRw("Concepto") = "Pago de Nota de Débito"
                    Else
                        DtRw("Concepto") = "Pago de Prima"
                    End If
                    DtRw("Debe") = rw("Debe")
                    DtRw("Haber") = rw("Haber")
                    DtRw("Cargos") = rw("Cargos")
                    DtRw("Abono") = rw("Abono")
                    DtRw("objSccCuentaID") = rw("ObjSccCuentaID")
                    DtRw("ObjTiendaID") = rw("ObjTiendaID")
                    DtRw("Cliente") = rw("Cliente")
                    DtRw("StbPersonaID") = rw("StbPersonaID")
                    DtRw("Fecha") = rw("Fecha")
                    DtRw("SaldoTotal") = rw("SaldoTotal")
                    DtRw("SaldoInicial") = rw("SaldoInicial")
                    DtRw("FechaActual") = rw("FechaActual")
                    DtRw("Saldo") = 0.0
                    DtRw("ResponsableCartera") = Empleado
                    DtRw("Cargo") = Cargo
                    'DtRw("FechaOrder") = rw("FechaOrder")
                    dtDatos.Tables("DatosReporte").Rows.Add(DtRw)

                Next
                Dim data As New DataView
                dtDatos.Tables("DatosReporte").DefaultView.Sort = "Fecha asc"
                data = dtDatos.Tables("DatosReporte").DefaultView
                data.Sort = "Fecha asc "


                For I As Integer = 0 To data.Count - 1
                    If I = 0 Then
                        data.Item(I)("Saldo") = 0.0 + data.Item(I)("Cargos") - data.Item(I)("Abono")
                    Else
                        data.Item(I)("Saldo") = data.Item(I - 1)("Saldo") + data.Item(I)("Cargos") - data.Item(I)("Abono")
                    End If
                Next

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptEstadoCuenta.rdlc"
                'Me.grid.DataSource = dtDatos.Tables(0).DefaultView

                Dim DsReporte As New ReportDataSource("DtEstadoCuentas_DatosReporte")
                DsReporte.Name = "DtEstadoCuentas_DatosReporte"
                DsReporte.Value = data
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(DsReporte)
                Me.VisorReporte.RefreshReport()

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatosFact = Nothing
            dtDatosND = Nothing
            dtRecibos = Nothing
            dtDatos = Nothing
            Parametros = Nothing
        End Try
    End Sub
#End Region

#Region "Estado Cuenta a Trámite Legal"
    Public Sub ReporteEstadoCuentaTramiteLegal(ByVal sCuentaId As String, ByVal sTiendaId As String, ByVal sAbogado As String, ByVal sComentarios As String)
        Dim dtDatosFact As New DataTable
        Dim dtDatosND As New DataTable
        Dim dtRecibos As New DataTable
        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(2) As SqlParameter
        Try
            Try
                Parametros(0) = New SqlParameter
                Parametros(0).ParameterName = "@CuentaID"
                Parametros(0).SqlDbType = SqlDbType.NVarChar
                Parametros(0).Size = 10
                Parametros(0).Value = sCuentaId

                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@SucursalID"
                Parametros(2).SqlDbType = SqlDbType.Int
                Parametros(2).Value = Convert.ToInt32(sTiendaId)

                strFiltro = "objSccCuentaID = @CuentaID AND objTiendaID = @SucursalID"

                If strFiltro.Trim.Length <> 0 Then
                    'strConsulta = clsConsultas.ObtenerConsultaGeneral("*, right(fecha,4)+ substring(fecha,4,2)+ left(fecha,2) AS FechaOrder  ", " vwRptEstadoCuentasFact", strFiltro)
                    strConsulta = clsConsultas.ObtenerConsultaGeneral("*", " vwRptEstadoCuentasFact", strFiltro)
                    'strConsulta = strConsulta + " ORDER BY FechaOrder "
                    strConsulta = strConsulta + " ORDER BY Fecha ASC"
                    dtDatosFact = SqlHelper.ExecuteQueryDT(strConsulta, Parametros)
                    strConsulta = clsConsultas.ObtenerConsultaGeneral("*", " vwRptEstadoCuentasND ", strFiltro)
                    strConsulta = strConsulta + " ORDER BY Fecha ASC"
                    dtDatosND = SqlHelper.ExecuteQueryDT(strConsulta, Parametros)
                    strConsulta = clsConsultas.ObtenerConsultaGeneral("*", " vwEstadoCuentasRec ", strFiltro)
                    strConsulta = strConsulta + " ORDER BY Fecha ASC"
                    dtRecibos = SqlHelper.ExecuteQueryDT(strConsulta, Parametros)
                    strConsulta = clsConsultas.ObtenerConsultaGeneral("*", " vwRptEstadoCuentasFact", "1=0")
                    strConsulta = strConsulta + " ORDER BY Fecha ASC"
                    nombre(0) = "DatosReporte"
                    SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre)
                    dtDatos.Tables("DatosReporte").DefaultView.Sort = "Fecha ASC"

                    Dim DtRw As DataRow
                    Dim Empleado As String = "Desconocido"
                    Dim Cargo As String = "Desconocido"
                    ''=== Agregamos los Datos Correspondientes a la Factura 
                    For Each rw As DataRow In dtDatosFact.Rows
                        DtRw = dtDatos.Tables("DatosReporte").NewRow
                        DtRw("Tipo") = rw("Tipo")
                        DtRw("Numero") = rw("Numero")
                        DtRw("MontoTotal") = rw("MontoTotal")
                        If rw("Concepto") = "Factura Motos" Then
                            rw("Concepto") = "Factura de Moto"
                        End If
                        DtRw("Concepto") = rw("Concepto")
                        DtRw("Debe") = rw("Debe")
                        DtRw("Haber") = rw("Haber")
                        DtRw("Cargos") = rw("Cargos")
                        DtRw("Abono") = rw("Abono")
                        DtRw("objSccCuentaID") = rw("ObjSccCuentaID")
                        DtRw("ObjTiendaID") = rw("ObjTiendaID")
                        DtRw("Cliente") = rw("Cliente")
                        DtRw("StbPersonaID") = rw("StbPersonaID")
                        DtRw("Fecha") = rw("Fecha")
                        DtRw("SaldoTotal") = rw("SaldoTotal")
                        DtRw("SaldoInicial") = rw("SaldoInicial")
                        DtRw("FechaActual") = rw("FechaActual")
                        DtRw("ResponsableCartera") = rw("ResponsableCartera")
                        DtRw("Cargo") = rw("Cargo")
                        Empleado = rw("ResponsableCartera")
                        Cargo = rw("Cargo")
                        DtRw("Saldo") = 0.0
                        'DtRw("FechaOrder") = rw("FechaOrder")

                        dtDatos.Tables("DatosReporte").Rows.Add(DtRw)

                    Next
                    ''=== Agregamos los Datos Correspondientes a la Nota de Debito
                    For Each rw As DataRow In dtDatosND.Rows
                        DtRw = dtDatos.Tables("DatosReporte").NewRow
                        DtRw("Tipo") = rw("Tipo")
                        DtRw("Numero") = rw("Numero")
                        DtRw("MontoTotal") = rw("MontoTotal")
                        DtRw("Concepto") = rw("Concepto")
                        DtRw("Debe") = rw("Debe")
                        DtRw("Haber") = rw("Haber")
                        DtRw("Cargos") = rw("Cargos")
                        DtRw("Abono") = rw("Abono")
                        DtRw("objSccCuentaID") = rw("ObjSccCuentaID")
                        DtRw("ObjTiendaID") = rw("ObjTiendaID")
                        DtRw("Cliente") = rw("Cliente")
                        DtRw("StbPersonaID") = rw("StbPersonaID")
                        DtRw("Fecha") = rw("Fecha")
                        DtRw("SaldoTotal") = rw("SaldoTotal")
                        DtRw("SaldoInicial") = rw("SaldoInicial")
                        DtRw("FechaActual") = rw("FechaActual")
                        DtRw("Saldo") = 0.0
                        DtRw("ResponsableCartera") = Empleado
                        DtRw("Cargo") = Cargo
                        'DtRw("FechaOrder") = rw("FechaOrder")
                        dtDatos.Tables("DatosReporte").Rows.Add(DtRw)

                    Next
                    ''=== Agregamos los Datos Correspondientes al Recibo de Caja.
                    For Each rw As DataRow In dtRecibos.Rows
                        DtRw = dtDatos.Tables("DatosReporte").NewRow
                        DtRw("Tipo") = rw("Tipo")
                        DtRw("Numero") = rw("Numero")
                        DtRw("MontoTotal") = rw("MontoTotal")

                        If (rw("TotalND") > 0) And (rw("TotalFacturas") > 0) Then
                            DtRw("Concepto") = "Abono de Cuotas y pago de Nota de Débito"
                        ElseIf (rw("TotalFacturas") > 0) And (rw("TotalND") = 0) Then
                            If IsDBNull(rw("Numero")) Then
                                DtRw("Concepto") = "Reestructuración de Cuenta"
                            Else
                                DtRw("Concepto") = "Abono de Cuotas"
                            End If
                        ElseIf (rw("TotalFacturas") = 0) And (rw("TotalND") > 0) Then
                            DtRw("Concepto") = "Pago de Nota de Débito"
                        Else
                            DtRw("Concepto") = "Pago de Prima"
                        End If
                        DtRw("Debe") = rw("Debe")
                        DtRw("Haber") = rw("Haber")
                        DtRw("Cargos") = rw("Cargos")
                        DtRw("Abono") = rw("Abono")
                        DtRw("objSccCuentaID") = rw("ObjSccCuentaID")
                        DtRw("ObjTiendaID") = rw("ObjTiendaID")
                        DtRw("Cliente") = rw("Cliente")
                        DtRw("StbPersonaID") = rw("StbPersonaID")
                        DtRw("Fecha") = rw("Fecha")
                        DtRw("SaldoTotal") = rw("SaldoTotal")
                        DtRw("SaldoInicial") = rw("SaldoInicial")
                        DtRw("FechaActual") = rw("FechaActual")
                        DtRw("Saldo") = 0.0
                        DtRw("ResponsableCartera") = Empleado
                        DtRw("Cargo") = Cargo
                        'DtRw("FechaOrder") = rw("FechaOrder")
                        dtDatos.Tables("DatosReporte").Rows.Add(DtRw)

                    Next
                    Dim data As New DataView
                    dtDatos.Tables("DatosReporte").DefaultView.Sort = "Fecha asc"
                    data = dtDatos.Tables("DatosReporte").DefaultView
                    data.Sort = "Fecha asc "

                    For I As Integer = 0 To data.Count - 1
                        If I = 0 Then
                            data.Item(I)("Saldo") = 0.0 + data.Item(I)("Cargos") - data.Item(I)("Abono")
                        Else
                            data.Item(I)("Saldo") = data.Item(I - 1)("Saldo") + data.Item(I)("Cargos") - data.Item(I)("Abono")
                        End If
                    Next

                    If dtDatos.Tables(0).DefaultView.Count = 0 Then
                        MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If

                    Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    LocalReporte = Me.VisorReporte.LocalReport
                    LocalReporte.ReportEmbeddedResource = "SCCUM.rptEstadoCuentaTramiteLegal.rdlc"

                    '  Creo una colección de parámetros de tipo ReportParameter
                    Dim pParametros As New List(Of ReportParameter)

                    pParametros.Add(New ReportParameter("prmComentarios", sComentarios))
                    pParametros.Add(New ReportParameter("prmAbogado", sAbogado))
                    LocalReporte.SetParameters(pParametros)

                    Dim DsReporte As New ReportDataSource("DtEstadoCuentas_DatosReporte")
                    DsReporte.Name = "DtEstadoCuentas_DatosReporte"
                    DsReporte.Value = data
                    LocalReporte.DataSources.Clear()
                    LocalReporte.DataSources.Add(DsReporte)
                    Me.VisorReporte.RefreshReport()

                    'Ejemplo para objtener un parámetro desde el reporte (GELL)
                    'Dim MisParametros As ReportParameterInfoCollection = LocalReporte.GetParameters()
                    'MsgBox(MisParametros.Item("Comentarios").Values.Item(0))
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatosFact = Nothing
            dtDatosND = Nothing
            dtRecibos = Nothing
            dtDatos = Nothing
            Parametros = Nothing
        End Try

    End Sub
#End Region

#Region "Morosidad"
    Private Sub ReporteMorosidad()

        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(1) As SqlParameter
        Try
            Try
                ' Parametro Tienda
                Parametros(0) = New SqlParameter
                Parametros(0).ParameterName = "@TiendaID"
                Parametros(0).SqlDbType = SqlDbType.Int

                If Me.cmbSucursalMor.Text <> "" Then
                    Parametros(0).Value = Me.cmbSucursalMor.SelectedValue
                    strFiltro = "objTiendaID = @TiendaID"
                End If

                If strFiltro = "" Then
                    strFiltro = " Mora30 >0 or Mora60 >0 or MoraOver60 >0"
                Else
                    strFiltro = strFiltro + " and  (Mora30 >0 or Mora60 >0 or MoraOver60 >0)"
                End If

                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptMorosidad.rdlc"
                nombre(0) = "DatosReporte"
                strConsulta = clsConsultas.ObtenerConsultaGeneral("SccCuentaID,ObjTiendaID,Numero,Concepto,StbPersonaID,Tienda,Mora30,Mora60,MoraOver60,Cliente", "vwRptCuotasVencidasCliente", strFiltro)
                SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre, Parametros)

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim DsReporte As New ReportDataSource("DtDatosMorosidad_DatosReporte")
                DsReporte.Name = "DtDatosMorosidad_DatosReporte"
                DsReporte.Value = dtDatos.Tables("DatosReporte")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(DsReporte)
                Me.VisorReporte.RefreshReport()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            Parametros = Nothing
        End Try
    End Sub

    Private Sub ReportePorcentajeMorosidad()

        Dim dtDatos As New DataSet("vwRptCuotasVencidas")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(1) As SqlParameter
        Try
            Try
                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.RptCateraConsolida.rdlc"
                nombre(0) = "vwRptCuotasVencidas"

                If Me.cmbSucursal.Text <> "" Then

                    SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "select Tienda,objTiendaID, sum(Moras30) as Mora30, sum(Mora60) as Mora60,sum(MoraOver60) as MoraOver60 , sum(d) as solvencia from (select Tienda,objTiendaID, count(Mora30) as Moras30,0 as Mora60, 0 as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where Mora30<>0 group by Tienda,objTiendaID  union select Tienda,objTiendaID, 0 as Mora30 , count(Mora60) as Moras60,0 as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where Mora60<>0 group by Tienda, objTiendaID union select Tienda, objTiendaID, 0 as Mora30 ,0 as Mora60, count(MoraOver60) as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where MoraOver60<>0 group by Tienda,objTiendaID union select Tienda, objTiendaID,  0 as Mora30, 0 as Mora60, 0 as MoraOver60, count(*) as d from vwRptCuotasVencidasCliente where CuotasVencidas =0 group by Tienda,objTiendaID) as Moras where objTiendaID='" & Me.cmbSucursal.SelectedValue & "' group by Tienda, objTiendaID order by Tienda", dtDatos, nombre, Parametros)
                Else
                    SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "select Tienda,objTiendaID, sum(Moras30) as Mora30, sum(Mora60) as Mora60,sum(MoraOver60) as MoraOver60 , sum(d) as solvencia from (select Tienda,objTiendaID, count(Mora30) as Moras30,0 as Mora60, 0 as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where Mora30<>0 group by Tienda,objTiendaID  union select Tienda,objTiendaID, 0 as Mora30 , count(Mora60) as Moras60,0 as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where Mora60<>0 group by Tienda, objTiendaID union select Tienda, objTiendaID, 0 as Mora30 ,0 as Mora60, count(MoraOver60) as MoraOver60, 0 as d from vwRptCuotasVencidasCliente where MoraOver60<>0 group by Tienda,objTiendaID union select Tienda, objTiendaID,  0 as Mora30, 0 as Mora60, 0 as MoraOver60, count(*) as d from vwRptCuotasVencidasCliente where CuotasVencidas =0 group by Tienda,objTiendaID) as Moras group by Tienda, objTiendaID order by Tienda", dtDatos, nombre, Parametros)
                End If

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim DsReporte As New ReportDataSource("DtMorosidadS_vwRptCuotasVencidas")
                DsReporte.Name = "DtMorosidadS_vwRptCuotasVencidas"
                DsReporte.Value = dtDatos.Tables("vwRptCuotasVencidas")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(DsReporte)
                Me.VisorReporte.RefreshReport()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            Parametros = Nothing
        End Try
    End Sub

    Private Sub ReporteCarteraRangos()
        Dim dtDatos As New DataSet("vwRptCarteraRangos")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim parametros(1) As SqlParameter
        Try
            Try
                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptCarteraRangos.rdlc"
                nombre(0) = "vwRptCarteraRangos"

                If Me.cmbTiendaCartera.Text <> "" Then
                    SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT SfaFacturaID, SccCuentaID, objTiendaID, Tienda, Cliente, Moras30, Mora60, MoraOver60, MoraTramiteLegal, Solventes, SaldoMora30, SaldoMora60, SaldoMoraOver60, SaldoMoraTramitaLegal, Saldo FROM vwRptCarteraRangos where objTiendaID='" & Me.cmbTiendaCartera.SelectedValue & "'  order by Tienda", dtDatos, nombre, parametros)
                Else
                    SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT SfaFacturaID, SccCuentaID, objTiendaID, Tienda, Cliente, Moras30, Mora60, MoraOver60, MoraTramiteLegal, Solventes, SaldoMora30, SaldoMora60, SaldoMoraOver60, SaldoMoraTramitaLegal, Saldo FROM vwRptCarteraRangos where 1 = 1 order by Tienda", dtDatos, nombre, parametros)
                End If

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim dsReporte As New ReportDataSource("DtCarteraRangos_vwRptCarteraRangos")
                dsReporte.Name = "DtCarteraRangos_vwRptCarteraRangos"
                dsReporte.Value = dtDatos.Tables("vwRptCarteraRangos")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(dsReporte)
                Me.VisorReporte.RefreshReport()

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            parametros = Nothing
        End Try
    End Sub
    Private Sub ReporteSaldoConsolidado()
        Dim dtDatos As New DataSet("vwCuentaRoles")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim parametros(1) As SqlParameter
        Try
            Try
                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.RptSaldoConsolidada.rdlc"
                nombre(0) = "vwCuentaRoles"

                If Me.cmbSucursalSaldo.Text <> "" Then
                    SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT vwRptCuotasVencidasCliente.objTiendaID,vwRptCuotasVencidasCliente.Tienda,sum(Mora30) as Mora30,sum(Mora60) as Mora60,sum(MoraOver60) as MoraOver60, sum(vwRptCuotasVencidasCliente.Saldo)as Saldo FROM vwRptCuotasVencidasCliente, SccCuentaPorCobrar WHERE SccCuentaPorCobrar.SccCuentaID = vwRptCuotasVencidasCliente.SccCuentaID AND vwRptCuotasVencidasCliente.objTiendaID='" & Me.cmbSucursalSaldo.SelectedValue & "' group by vwRptCuotasVencidasCliente.objTiendaID, vwRptCuotasVencidasCliente.Tienda order by Tienda", dtDatos, nombre, parametros)
                Else
                    SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, "SELECT vwRptCuotasVencidasCliente.objTiendaID,vwRptCuotasVencidasCliente.Tienda,sum(Mora30) as Mora30,sum(Mora60) as Mora60,sum(MoraOver60) as MoraOver60, sum(vwRptCuotasVencidasCliente.Saldo)as Saldo FROM vwRptCuotasVencidasCliente, SccCuentaPorCobrar WHERE SccCuentaPorCobrar.SccCuentaID = vwRptCuotasVencidasCliente.SccCuentaID group by vwRptCuotasVencidasCliente.objTiendaID,vwRptCuotasVencidasCliente.Tienda order by Tienda", dtDatos, nombre, parametros)
                End If

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim dsReporte As New ReportDataSource("DtSaldoConsolidada_vwCuentaRoles")
                dsReporte.Name = "DtSaldoConsolidada_vwCuentaRoles"
                dsReporte.Value = dtDatos.Tables("vwCuentaRoles")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(dsReporte)
                Me.VisorReporte.RefreshReport()

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            parametros = Nothing
        End Try
    End Sub

#End Region

#Region "Historial de Clientes"
    Private Sub ReporteHistorialClientes()

        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(3) As SqlParameter
        Dim strCampos As String
        Try
            Try
                ' Parametro Tienda
                Parametros(0) = New SqlParameter
                Parametros(0).ParameterName = "@TiendaID"
                Parametros(0).SqlDbType = SqlDbType.Int
                ' Parametro NoExpediente
                Parametros(1) = New SqlParameter
                Parametros(1).ParameterName = "@CuentaId"
                Parametros(1).SqlDbType = SqlDbType.NVarChar
                ' Parametro NombreCliente
                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@ClienteId"
                Parametros(2).SqlDbType = SqlDbType.NVarChar

                If Me.cmbSucursalHistorial.Text.Length <> 0 Then
                    Parametros(0).Value = Me.cmbSucursalHistorial.SelectedValue
                    strFiltro = " objTiendaID = @TiendaID "
                End If

                If Me.txtExpedienteHistorial.Text.Length <> 0 Then
                    Parametros(1).Value = Me.txtExpedienteHistorial.Text
                    If String.IsNullOrEmpty(strFiltro) Then
                        strFiltro = " Expediente = @CuentaId "
                    Else
                        strFiltro = strFiltro + " AND Expediente = @CuentaId "
                    End If
                End If

                If Me.cmbClientesHistorial.Text.Length <> 0 Then
                    Parametros(2).Value = Me.cmbClientesHistorial.SelectedValue
                    If String.IsNullOrEmpty(strFiltro) Then
                        strFiltro = " stbPersonaId = @ClienteId "
                    Else
                        strFiltro = strFiltro + " AND stbPersonaId = @ClienteID "
                    End If
                End If

                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptHistorialClientes.rdlc"
                nombre(0) = "DatosReporte"
                strCampos = "Expediente, objTiendaID, Sucursal, Cedula, stbPersonaId, NombreCliente, Departamento, Direccion, " & _
                             "CentroLaboral, DireccionTrabajo, TelefonoOficina, TelefonoCasa, Celular, " & _
                             "NombreFiador, DptoFiador, DireccionFiador, CentroLaboralFiador, " & _
                             "DireccionTrabajoFiador, TelefonoOficinaFiador, TelefonoCasaFiador, " & _
                             "CelularFiador, ModeloMoto, Chasis, NoMotor, GarantiaExtendida, EstadoCuenta, CalificacionCuenta," & _
                             "FechaCredito, PlazoCantidadCuotas, FechaVencimiento, SaldoTotalInicial, Prima, " & _
                             "CuotaMensualMoto, CuotaMensualGarantia, SaldoCorrienteMoto, SaldoCorrienteGarantia, " & _
                             "SaldoCorrienteTotal, CuotasTranscurridas, CuotasPagadasMoto, CuotasPagadasGarantia, CuotasVencidasMoto, " & _
                             "CuotasVencidasGarantia, SaldoVencidoMoto, SaldoVencidoGarantia, Cargos, TotalSaldosVencidos, " & _
                             "FechaUltimoPago, MesesSinMovimiento, FechaUltimoSeguimiento, TipoGestion, DescripcionBitacora, Usuario"

                If String.IsNullOrEmpty(strFiltro) Then
                    strFiltro = "1=1"
                End If

                strConsulta = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptHistorialClientes", strFiltro)
                SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre, Parametros)

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim DsReporte As New ReportDataSource("DtDatosHistorialClientes_vwRptHistorialClientes")
                DsReporte.Name = "DtDatosHistorialClientes_vwRptHistorialClientes"
                DsReporte.Value = dtDatos.Tables("DatosReporte")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(DsReporte)
                Me.VisorReporte.RefreshReport()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            Parametros = Nothing
        End Try
    End Sub
#End Region

#Region "Reporte Recuperacion Comparativo"
    Private Sub ReporteRecuperacionComparativo()
        Dim dtDatos As New DataSet("DatosReporte")
        Dim nombre(0) As String
        Dim LocalReporte As LocalReport
        Dim strFiltro As String = ""
        Dim strConsulta As String = ""
        Dim Parametros(5) As SqlParameter
        Dim strCampos As String

        If Me.dtpFechaDesde1.Text.Trim.Length <> 0 And Me.dtpFechaHasta1.Text.Trim.Length <> 0 And Me.dtpFechaDesde2.Text.Trim.Length <> 0 And Me.dtpFechaHasta2.Text.Trim.Length <> 0 Then
            'Validar rangos de fecha
            'Rango X
            If Me.dtpFechaDesde1.Value > Me.dtpFechaHasta1.Value Then
                Me.ErrorProv.SetError(Me.dtpFechaHasta1, "Fecha Hasta de Rango X, debe ser Mayor o igual que Fecha Desde")
                Exit Sub
            End If

            'Rango Y
            If Me.dtpFechaDesde2.Value > Me.dtpFechaHasta2.Value Then
                Me.ErrorProv.SetError(Me.dtpFechaHasta2, "Fecha Hasta de Rango Y, debe ser Mayor o igual que Fecha Desde")
                Exit Sub
            End If
            'rango Y con respecto a Rango X
            If Me.dtpFechaDesde2.Value < Me.dtpFechaDesde1.Value Then
                Me.ErrorProv.SetError(Me.dtpFechaDesde1, "Fecha Desde Rango Y, debe ser Mayor o igual que Fecha Hasta Rango X")
                Exit Sub
            End If
        Else
            MsgBox("Alguno de los rangos de fecha no ha sido especificado.")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Try
            Try
                ' Parametro Fecha Desde Rango1
                Parametros(0) = New SqlParameter
                Parametros(0).ParameterName = "@Desde1"
                Parametros(0).SqlDbType = SqlDbType.DateTime
                Parametros(0).Value = Me.dtpFechaDesde1.Value

                ' Parametro Fecha Hasta Rango1
                Parametros(1) = New SqlParameter
                Parametros(1).ParameterName = "@Hasta1"
                Parametros(1).SqlDbType = SqlDbType.DateTime
                Parametros(1).Value = Me.dtpFechaHasta1.Value

                ' Parametro Fecha Desde Rango2
                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@Desde2"
                Parametros(2).SqlDbType = SqlDbType.DateTime
                Parametros(2).Value = Me.dtpFechaDesde2.Value

                ' Parametro Fecha Desde Rango2
                Parametros(3) = New SqlParameter
                Parametros(3).ParameterName = "@Hasta2"
                Parametros(3).SqlDbType = SqlDbType.DateTime
                Parametros(3).Value = Me.dtpFechaHasta2.Value

                ' Parametro Identificador de Tienda
                Parametros(4) = New SqlParameter
                Parametros(4).ParameterName = "@TiendaId"
                Parametros(4).SqlDbType = SqlDbType.Int

                If Me.cmbSucursalesRecuperacionCmp.Text.Length <> 0 Then
                    Parametros(4).Value = Me.cmbSucursalesRecuperacionCmp.SelectedValue
                    strFiltro = " objTiendaID = @TiendaID "
                End If

                Me.VisorReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                LocalReporte = Me.VisorReporte.LocalReport
                LocalReporte.ReportEmbeddedResource = "SCCUM.rptRecuperacionComparativo.rdlc"
                nombre(0) = "DatosReporte"
                strCampos = "objTiendaID, Sucursal, TotalRecibosX, TotalRecibosY, TotalPorcentaje"

                If strFiltro.Trim.Length = 0 Then
                    strConsulta = "SELECT " + strCampos + " FROM dbo.fnGetRangosRecibos(@Desde1, @Hasta1, @Desde2, @Hasta2)"
                Else
                    strConsulta = "SELECT " + strCampos + " FROM dbo.fnGetRangosRecibos(@Desde1, @Hasta1, @Desde2, @Hasta2) WHERE " + strFiltro
                End If

                SqlHelper.FillDataset(SqlHelper.GetConnection.ConnectionString, CommandType.Text, strConsulta, dtDatos, nombre, Parametros)

                If dtDatos.Tables(0).DefaultView.Count = 0 Then
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                '  Creo una colección de parámetros de tipo ReportParameter
                Dim pParametros As New List(Of ReportParameter)

                pParametros.Add(New ReportParameter("prmFecha", FormatDateTime(clsProyecto.Conexion.FechaServidor.Date, DateFormat.ShortDate)))
                pParametros.Add(New ReportParameter("prmUsuario", clsProyecto.Conexion.Usuario))
                pParametros.Add(New ReportParameter("prmDesde1", Me.dtpFechaDesde1.Text))
                pParametros.Add(New ReportParameter("prmHasta1", Me.dtpFechaHasta1.Text))
                pParametros.Add(New ReportParameter("prmDesde2", Me.dtpFechaDesde2.Text))
                pParametros.Add(New ReportParameter("prmHasta2", Me.dtpFechaHasta2.Text))

                LocalReporte.SetParameters(pParametros)

                Dim DsReporte As New ReportDataSource("dtRecuperacionComparativo_fnGetRangosRecibos")
                DsReporte.Name = "dtRecuperacionComparativo_fnGetRangosRecibos"
                DsReporte.Value = dtDatos.Tables("DatosReporte")
                LocalReporte.DataSources.Clear()
                LocalReporte.DataSources.Add(DsReporte)
                Me.VisorReporte.RefreshReport()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            LocalReporte = Nothing
            Parametros = Nothing
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

    Private Sub txtCantVenc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantVenc.KeyPress
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BuscarDevoluciones()
    End Sub

    Private Sub cmdBuscarSeguimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarSeguimientos.Click
        Me.BuscarSeguimientos()
    End Sub

    Private Sub cmdBuscarEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarEstadoCuenta.Click
        Me.ReporteEstadoCuenta()
    End Sub

    Private Sub cmdBuscarSucMor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarSucMor.Click
        Me.ReporteMorosidad()
    End Sub


    Private Sub CargarNoExpedientes()
        Dim strConsulta As String
        Dim strFiltro
        Try
            strFiltro = "objClienteID = '" & Me.txtNoExpedienteCedula.Text.Trim & "'" & " AND Estado <> 'REGISTRADO'"
            strConsulta = clsConsultas.ObtenerConsultaGeneral("SccCuentaID", "vwSccCuenta", strFiltro)
            Me.DtDatosNo = SqlHelper.ExecuteQueryDT(strConsulta)
            With Me.cmbNoExpediente
                .DataSource = Me.DtDatosNo
                .DisplayMember = "SccCuentaID"
                .ValueMember = "SccCuentaID"
                .ColumnHeaders = False
                .ExtendRightColumn = True
            End With
         Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtNoExpedienteCedula_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DtDatosNo.Clear()
    End Sub

    Private Sub rbtOpcion1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtOpcion1.CheckedChanged
        Me.txtNoExpEstadoCuenta.Clear()
        Me.txtNoExpedienteCedula.Clear()
        Me.DtDatosNo.Clear()
        Select Case Me.rbtOpcion1.Checked
            Case True
                Me.txtNoExpEstadoCuenta.Enabled = False
                Me.cmbSucursalEstadoCuenta.Enabled = False
                Me.cmbNoExpediente.Enabled = True
                Me.txtNoExpedienteCedula.Enabled = True

            Case False
                Me.txtNoExpEstadoCuenta.Enabled = True
                Me.cmbSucursalEstadoCuenta.Enabled = True
                Me.cmbNoExpediente.Enabled = False
                Me.txtNoExpedienteCedula.Enabled = False
        End Select
    End Sub

    Private Sub txtNoExpedienteCedula_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoExpedienteCedula.TextChanged
        If Me.txtNoExpedienteCedula.Text.Trim <> "-      -" Then
            Me.CargarNoExpedientes()
        End If
    End Sub

    Private Sub cmdReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReporte.Click
        Me.ReportePorcentajeMorosidad()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ReporteSaldoConsolidado()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ReporteCarteraRangos()
    End Sub

    Private Sub cmdCargarRptHistorialCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCargarRptHistorialCliente.Click
        ReporteHistorialClientes()
    End Sub

    Private Sub cmdCargaComparativoRecuperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCargaComparativoRecuperacion.Click
        ReporteRecuperacionComparativo()
    End Sub
End Class