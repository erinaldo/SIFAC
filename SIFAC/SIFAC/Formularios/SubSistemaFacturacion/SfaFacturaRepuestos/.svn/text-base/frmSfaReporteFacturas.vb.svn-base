'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Milagros Ruiz Oporta
''-- Fecha de Elaboración    : 20 de Julio 2010.
''-- Formulario para Imprimir reporte de Facturas
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

Public Class frmSfaReporteFacturas

#Region "Variables del formulario"
    Dim dtTienda, dtCliente, dtVendedor As DataTable
    Private m_strFiltro As String
    Public Parametro(5) As SqlParameter
    Private m_SucursalSessionID As Integer
    Private m_SucursalCentralID As Integer
    Private m_TipoReporte As String

#End Region

#Region "Propiedades"

    Property strFiltro() As String
        Get
            Return m_strFiltro
        End Get
        Set(ByVal value As String)
            m_strFiltro = value
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

    Property TipoReporte() As String
        Get
            TipoReporte = Me.m_TipoReporte
        End Get
        Set(ByVal value As String)
            Me.m_TipoReporte = value
        End Set
    End Property

#End Region

#Region "Configurar Identificadores de sucursales"
    Private Sub ConfigurarSucursalesID()
        Me.SucursalCentralID = ClsCatalogos.GetStbTiendaID("C")
        If clsProyecto.Sucursal.Trim.Length <> 0 Then
            Me.SucursalSessionID = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Else
            MsgBox("No se ha configurado la sucursal en el utilitario de configuración, consulte al administrador.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            Me.Close()
        End If
    End Sub
#End Region

#Region "Cargar Tiendas"

    Private Sub CargarTienda()
        Dim objTienda As New StbTienda

        dtTienda = StbTienda.RetrieveDT("Activo = 1  AND Codigo <> 'ME' AND ActivoRepuesto = 1 ", "Nombre", "StbTiendaID, Codigo, Nombre")
        If dtTienda.Rows.Count <> 0 Then
            With Me.cmbSucursal
                .DataSource = Me.dtTienda
                .ValueMember = "StbTiendaID"
                .DisplayMember = "Nombre"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 30
                .ExtendRightColumn = True
            End With
            Me.cmbSucursal.SelectedValue = Me.SucursalSessionID
        End If

        Me.dtTienda.Rows.Add("0", "-", "TODAS")
        'Habilitar combo sólo si es sucursal Central
        Me.cmbSucursal.Enabled = (Me.SucursalSessionID = Me.SucursalCentralID)
    End Sub

#End Region

#Region "Cargar Clientes"
    Private Sub CargarClientes()
        Dim strFiltro, strSQL As String

        strFiltro = " Descripcion = 'Cliente' ORDER BY NombreCompleto"
        strSQL = ObtenerConsultaGeneral("StbPersonaID, NombreCompleto", "vwSfaClienteFactura", strFiltro)
        dtCliente = DAL.SqlHelper.ExecuteQueryDT(strSQL)
        'dtCliente.DefaultView.Sort = "NombreCompleto"
        With Me.cmbCliente
            .DataSource = dtCliente
            .ValueMember = "StbPersonaID"
            .DisplayMember = "NombreCompleto"
            .Splits(0).DisplayColumns("StbPersonaID").Visible = False
            .ExtendRightColumn = True
        End With

        Me.dtCliente.Rows.Add("0", "TODOS")
        Me.cmbCliente.SelectedValue = "0"
    End Sub

#End Region

#Region "Cargar Vendedores"
    Private Sub CargarVendedor()
        dtVendedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SrhEmpleadoID, NombreVendedor ", "vwSfaVendedorFactura", "1=1"))
        With Me.cmbVendedor
            .DataSource = Me.dtVendedor
            .ValueMember = "SrhEmpleadoID"
            .DisplayMember = "NombreVendedor"
            .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
            .ExtendRightColumn = True
        End With
        Me.dtVendedor.Rows.Add("0", "TODOS")
        Me.cmbVendedor.SelectedValue = "0"

    End Sub
#End Region

#Region "Imprimir"

    Private Sub Imprimir()
        Dim visor As New frmVisorRS
        Dim sCampos, sSQL As String
        Dim dtDatos As DataTable

        If Me.TipoReporte.ToUpper.Equals("VENTAS") Then
            sCampos = "Fecha, objClienteID, Cliente, objVendedorID, Vendedor, serie, Numero, SerieNumero, OrdenCompra, NoFactura, Impuesto, Exonerada, TotalCordobas, TotalDolares, Descuento, Subtotal, objTerminoPagoID, Sucursal, CodigoSucursal, TeminoPago, objTiendaID"
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptVentasRepuestos", m_strFiltro & " ORDER BY NoFactura")
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL, Me.Parametro)

            If dtDatos.Rows.Count = 0 Then
                MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            With visor.VisorReportes
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = "SCCUM.rptVentasRepuestos.rdlc"
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtDatosRptVentasRepuestos_vwRptVentasRepuestos", dtDatos))
                Me.CargarEncabezadoReporte(.LocalReport)
                .RefreshReport()
            End With
            visor.ShowDialog()
        Else
            sCampos = "Cliente, Vendedor, objClienteID, objTiendaID, objTerminoPagoID, objVendedorID, Impuesto, NumeroSerie, serie, Exonerada, TotalCordobas, TotalDolares, Descuento, Subtotal, Fecha, Estado, Anulada, TerminoPago,CodigoSucursal,Sucursal"
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptSfaFacturas", m_strFiltro)
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL, Me.Parametro)

            If dtDatos.Rows.Count = 0 Then
                MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            With visor.VisorReportes
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = "SCCUM.rptSfaReporteFacturas.rdlc"
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtSfaFacturas_vwRptSfaFacturas", dtDatos))
                Me.CargarEncabezadoReporte(.LocalReport)
                .RefreshReport()
            End With
            visor.ShowDialog()
        End If

    End Sub

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

        'Agregación de rango de fechas al encabezado

        Dim strDesde, strHasta As String
        strDesde = Format(dtpDesde.Value, "dd/MM/yyyy")
        strHasta = Format(dtpHasta.Value, "dd/MM/yyyy")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFechaDesde", strDesde, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFechaHasta", strHasta, False))

        reporte.SetParameters(parametros)

    End Sub


#End Region

#Region "Obtener Filtro"
    Private Sub ObtenerFiltro()
        Dim strFechaDesde, strFechaHasta As String
        Try
            Try
                m_strFiltro = ""

                Parametro(0) = New SqlParameter
                Parametro(0).ParameterName = "@Sucursal"
                Parametro(0).SqlDbType = SqlDbType.Int
                Parametro(0).Size = 6

                Parametro(1) = New SqlParameter
                Parametro(1).ParameterName = "@Cliente"
                Parametro(1).SqlDbType = SqlDbType.Int
                Parametro(1).Size = 6

                Parametro(2) = New SqlParameter
                Parametro(2).ParameterName = "@Vendedor"
                Parametro(2).SqlDbType = SqlDbType.Int
                Parametro(2).Size = 6

                Parametro(3) = New SqlParameter
                Parametro(3).ParameterName = "@TerminoPago"
                Parametro(3).SqlDbType = SqlDbType.Int
                Parametro(3).Size = 15

                Parametro(4) = New SqlParameter
                Parametro(4).ParameterName = "@Exonerado"
                Parametro(4).SqlDbType = SqlDbType.Bit
                Parametro(4).Size = 15

                If Me.cmbSucursal.Text.Trim.Length <> 0 And (Me.cmbSucursal.SelectedValue <> "0") Then
                    Parametro(0).Value = Me.cmbSucursal.SelectedValue
                    If m_strFiltro.Trim.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND objTiendaID = @Sucursal"
                    Else
                        m_strFiltro = " objTiendaID = @Sucursal"
                    End If
                End If

                If (Me.cmbCliente.Text.Trim.Length <> 0) And (Me.cmbCliente.Text <> "TODOS") Then
                    Parametro(1).Value = Me.cmbCliente.SelectedValue
                    If m_strFiltro.Trim.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND objClienteID= @Cliente"
                    Else
                        m_strFiltro = " objClienteID= @Cliente"
                    End If
                End If

                If (Me.cmbVendedor.Text.Trim.Length <> 0) And (Me.cmbVendedor.Text <> "TODOS") Then

                    Parametro(2).Value = Me.cmbVendedor.SelectedValue

                    If m_strFiltro.Trim.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND  objVendedorID= @Vendedor"
                    Else
                        m_strFiltro = " objVendedorID= @Vendedor"
                    End If
                End If

                If Not (Me.rbTodasPago.Checked) Then

                    If Me.rbFacturaContado.Checked Then
                        Parametro(3).Value = ClsCatalogos.GetValorCatalogoID("TERMINOPAGO", "01")
                    Else
                        Parametro(3).Value = ClsCatalogos.GetValorCatalogoID("TERMINOPAGO", "02")
                    End If

                    If m_strFiltro.Trim.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND  objTerminoPagoID= @TerminoPago"
                    Else
                        m_strFiltro = " objTerminoPagoID= @TerminoPago"
                    End If
                End If

                If Not (Me.rbTodasIVA.Checked) Then

                    If Me.rbGravado.Checked Then
                        Parametro(4).Value = 0
                    Else
                        If Me.rbExonerado.Checked Then
                            Parametro(4).Value = 1
                        End If
                    End If

                    If m_strFiltro.Trim.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND  Exonerada= @Exonerado"
                    Else
                        m_strFiltro = " Exonerada= @Exonerado"
                    End If
                End If

                strFechaDesde = Format(Me.dtpDesde.Value, "yyyyMMdd")
                strFechaHasta = Format(Me.dtpHasta.Value, "yyyyMMdd")

                If m_strFiltro.Trim.Length = 0 Then
                    m_strFiltro = " CONVERT(VARCHAR, Fecha,112) >= '" & strFechaDesde & "' AND CONVERT(VARCHAR, Fecha,112) <= '" & strFechaHasta & "'"
                Else
                    m_strFiltro = m_strFiltro & " AND CONVERT(VARCHAR, Fecha,112) >= '" & strFechaDesde & "' AND CONVERT(VARCHAR, Fecha,112) <= '" & strFechaHasta & "'"
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally

        End Try
    End Sub
#End Region

#Region "Validar"
    Private Function Validar() As Boolean

        If Me.dtpDesde.Text.Trim.Length = 0 Then
            Me.ErrorImprimirFactura.SetError(Me.dtpDesde, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpHasta.Text.Trim.Length = 0 Then
            Me.ErrorImprimirFactura.SetError(Me.dtpHasta, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpDesde.Value > Me.dtpHasta.Value Then
            Me.ErrorImprimirFactura.SetError(Me.dtpDesde, "La Fecha Desde debe ser menor que la Fecha Hasta")
            Return False
            Exit Function
        End If
        Return True
    End Function
#End Region

#Region "Eventos"

    Private Sub frmSfaReporteFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.ConfigurarSucursalesID()
        Me.CargarTienda()
        Me.CargarClientes()
        Me.CargarVendedor()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.Validar Then
            Me.ObtenerFiltro()
            Me.Imprimir()
        End If
    End Sub
    Private Sub dtpDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.TextChanged
        Me.ErrorImprimirFactura.SetError(Me.dtpDesde, "")
        Me.ErrorImprimirFactura.SetError(Me.dtpHasta, "")
    End Sub

    Private Sub dtpHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.TextChanged
        Me.ErrorImprimirFactura.SetError(Me.dtpDesde, "")
        Me.ErrorImprimirFactura.SetError(Me.dtpHasta, "")
    End Sub

#End Region

End Class