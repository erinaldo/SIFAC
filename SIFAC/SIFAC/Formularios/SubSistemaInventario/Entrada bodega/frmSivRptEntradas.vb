'-- Autor: Gelmin Martínez
'-- Fecha: 03 Agosto 2010, 01:59 pm.
'-- Formulario para seleccionar parámetros de filtrado del reporte 
'-- de Entradas

Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursor
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos

Public Class frmSivRptEntradas
    Dim dtBodega As New DataTable
    Dim dtTipoEntrada As New DataTable

#Region "Cargar combos"
    Private Sub CargarBodega()
        Try
            dtBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbTiendaID, Codigo, Nombre", "StbTienda", "Activo=1 AND ActivoRepuesto=1 ORDER BY Nombre"))

            Me.cmbBodega.DataSource = dtBodega
            Me.cmbBodega.DisplayMember = "Nombre"
            Me.cmbBodega.ValueMember = "StbTiendaID"
            Me.cmbBodega.Splits(0).DisplayColumns("StbTiendaID").Visible = False
            Me.cmbBodega.Splits(0).DisplayColumns("Codigo").Width = 40
            Me.cmbBodega.SelectedValue = 0
            Me.cmbBodega.ExtendRightColumn = True
            Me.cmbBodega.ColumnHeaders = False
            'Me.dtBodega.DefaultView.Sort = "Nombre"

            dtBodega.Rows.Add("0", "-", "TODAS")
            Me.cmbBodega.SelectedValue = "0"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarTipoEntrada()
        dtTipoEntrada = New DataTable
        Try
            dtTipoEntrada = ClsCatalogos.GetValoresCatalogo("TIPOENTRADA", "StbValorCatalogoID, Descripcion", "Descripcion")
            'DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOENTRADA')"))

            Me.cmbTipoEntrada.DataSource = dtTipoEntrada
            Me.cmbTipoEntrada.DisplayMember = "Descripcion"
            Me.cmbTipoEntrada.ValueMember = "StbValorCatalogoID"
            Me.cmbTipoEntrada.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipoEntrada.ExtendRightColumn = True
            Me.cmbTipoEntrada.ColumnHeaders = False
            'Me.dtTipoSalida.DefaultView.Sort = "Descripcion"
            Me.dtTipoEntrada.Rows.Add("0", "TODOS")
            Me.cmbTipoEntrada.SelectedValue = "0"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Validar"
    Private Function Validar() As Boolean

        If Me.dtpFechaDesde.Text.Trim.Length = 0 Then
            Me.ErrorRptEntrada.SetError(Me.dtpFechaDesde, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpFechaHasta.Text.Trim.Length = 0 Then
            Me.ErrorRptEntrada.SetError(Me.dtpFechaHasta, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpFechaDesde.Value > Me.dtpFechaHasta.Value Then
            Me.ErrorRptEntrada.SetError(Me.dtpFechaDesde, "La Fecha Desde debe ser menor que la Fecha Hasta")
            Return False
            Exit Function
        End If
        Return True
    End Function

#End Region

#Region "Obtener filtro"
    Private Function ObtenerFiltro() As String
        Dim strFiltro As String
        Dim sFechaFormateadaDesde, sFechaFormateadaHasta As String

        sFechaFormateadaDesde = Format(Me.dtpFechaDesde.Value, "yyyyMMdd")
        sFechaFormateadaHasta = Format(Me.dtpFechaHasta.Value, "yyyyMMdd")
        strFiltro = " Convert(varchar,FechaEntrada,112) >= '" & sFechaFormateadaDesde & "' AND Convert(varchar,FechaEntrada,112) <= '" & sFechaFormateadaHasta & "'"

        If Me.cmbBodega.Text <> "TODAS" And Me.cmbBodega.Text.Trim.Length <> 0 Then
            If strFiltro.Trim.Length <> 0 Then
                strFiltro = strFiltro & " AND objTiendaID = " & Me.cmbBodega.SelectedValue
            Else
                strFiltro = " objTiendaID = " & Me.cmbBodega.SelectedValue
            End If
        End If

        If Me.cmbTipoEntrada.Text <> "TODOS" And Me.cmbTipoEntrada.Text.Trim.Length <> 0 Then
            If strFiltro.Trim.Length <> 0 Then
                strFiltro = strFiltro & " AND objTipoEntradaID = " & Me.cmbTipoEntrada.SelectedValue
            Else
                strFiltro = " objTipoEntradaID = " & Me.cmbTipoEntrada.SelectedValue
            End If
        End If

        Return strFiltro
    End Function
#End Region

#Region "Imprimir Reporte"
    Private Sub Imprimir_Reporte(ByVal strFiltro As String)
        Dim dtDatos As DataTable
        Dim strCampos, strSQL As String
        Dim parametros(1) As SqlClient.SqlParameter

        Me.Cursor = Cursors.WaitCursor
        Dim Visor As New frmVisorRS
        Try
            strCampos = " DISTINCT CONVERT(VARCHAR,FechaEntrada,103) AS FechaEntrada, SivEntradaBodegaID, NoEntrada, objTiendaID, Codigo, NombreSucursal, objRepuestoID, DescripcionCorta, Anulada, objTipoEntradaID, TipoEntrada, CantidadEntrada, Costo, CONVERT(VARCHAR,FechaFactura,103) AS FechaFactura, NumeroPoliza, objProveedorID, Proveedor, CodigosProveedorRepuesto, CantidadFacturada, NumeroFactura, SubTotal"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptEntradasBodega", strFiltro)
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(strSQL)

            If dtDatos.Rows.Count <> 0 Then
                With Visor.VisorReportes
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .LocalReport.ReportEmbeddedResource = "SCCUM.rptEntradas.rdlc"
                    .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtDatosRptEntradasBodega_vwRptEntradasBodega", dtDatos))
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
            Me.Cursor = Cursors.Default
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

        'Agregación de rango de fechas al encabezado
        Dim strDesde, strHasta As String
        strDesde = Format(dtpFechaDesde.Value, "dd/MM/yyyy")
        strHasta = Format(dtpFechaHasta.Value, "dd/MM/yyyy")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFechaDesde", strDesde, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFechaHasta", strHasta, False))

        reporte.SetParameters(parametros)
    End Sub
#End Region

#Region "Eventos del Formulario"
    Private Sub frmSivRptEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CargarBodega()
        Me.CargarTipoEntrada()
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged
        Me.ErrorRptEntrada.SetError(Me.dtpFechaDesde, "")
    End Sub

    Private Sub dtpFechaHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.TextChanged
        Me.ErrorRptEntrada.SetError(Me.dtpFechaDesde, "")
        Me.ErrorRptEntrada.SetError(Me.dtpFechaHasta, "")
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.Validar Then
            Me.Imprimir_Reporte(Me.ObtenerFiltro & " ORDER BY NombreSucursal, SivEntradaBodegaID")
        End If
    End Sub
#End Region

End Class