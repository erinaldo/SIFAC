'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Milagros Ruiz Oporta
''-- Fecha de Elaboración    : 20 de Julio 2010.
''-- Formulario para Imprimir reporte de repuestos facturados
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SIFAC.BO.clsConsultas

Public Class frmSfaRptFacturaRepuestos

#Region "Variables del formulario"
    Dim dtTienda, dtTipoRepuesto, dtRepuesto As DataTable
    Private m_strFiltro As String
    Public Parametro(3) As SqlParameter
    Private m_SucursalSessionID As Integer
    Private m_SucursalCentralID As Integer
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
        With Me.cmbSucursal
            .DataSource = Me.dtTienda
            .ValueMember = "StbTiendaID"
            .DisplayMember = "Nombre"
            .Splits(0).DisplayColumns("StbTiendaID").Visible = False
            .Splits(0).DisplayColumns("Codigo").Width = 40
            .ExtendRightColumn = True
        End With

        Me.dtTienda.Rows.Add("0", "-", "TODAS")
        'Habilitar combo sólo si es sucursal Central
        Me.cmbSucursal.Enabled = (Me.SucursalSessionID = Me.SucursalCentralID)
        Me.cmbSucursal.SelectedValue = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)

    End Sub
#End Region

#Region "Cargar Repuestos"
    Private Sub CargarRepuestos()
        'dtRepuesto = SivRepuestos.RetrieveDT("1=1", "DescripcionCorta", "SivRepuestoID, DescripcionCorta, DescripcionCorta + '-' + cast(SivRepuestoID as varchar) as Descripcion")
        dtRepuesto = SivRepuestos.RetrieveDT("Activo=1 AND SivRepuestoID NOT IN (1,2,3)", "Descripcion", "SivRepuestoID, DescripcionCorta as Descripcion")
        'dtRepuesto.DefaultView.Sort = "DescripcionCorta"

        With Me.cmbRepuesto
            .DataSource = dtRepuesto
            .ValueMember = "SivRepuestoID"
            .DisplayMember = "Descripcion"
            .Splits(0).DisplayColumns("SivRepuestoID").Width = 50
            .Columns("Descripcion").Caption = "Descripción"
            .Columns("SivRepuestoID").Caption = "Código"
            .ExtendRightColumn = True
            .ColumnHeaders = True
        End With

        dtRepuesto.Rows.Add("0", "TODOS")
        Me.cmbRepuesto.SelectedValue = "0"

    End Sub
#End Region

#Region "Cargar Tipo de Repuestos"
    Private Sub CargarTipoRepuesto()

        dtTipoRepuesto = ClsCatalogos.GetValoresCatalogo("TIPOREPUESTO", "StbValorCatalogoID, Descripcion", "Descripcion")
        'dtTipoRepuesto.DefaultView.Sort = "Descripcion"
        With Me.cmbTipoRepuesto
            .DataSource = dtTipoRepuesto
            .ValueMember = "StbValorCatalogoID"
            .DisplayMember = "Descripcion"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .ExtendRightColumn = True
        End With
        dtTipoRepuesto.Rows.Add("0", "TODOS")
        Me.cmbTipoRepuesto.SelectedValue = "0"
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
                Parametro(1).ParameterName = "@Repuesto"
                Parametro(1).SqlDbType = SqlDbType.Int
                Parametro(1).Size = 6

                Parametro(2) = New SqlParameter
                Parametro(2).ParameterName = "@TipoRepuesto"
                Parametro(2).SqlDbType = SqlDbType.Int
                Parametro(2).Size = 6

                'Parametro(3) = New SqlParameter
                'Parametro(3).ParameterName = "@FechaDesde"
                'Parametro(3).SqlDbType = SqlDbType.DateTime
                'Parametro(3).Size = 15

                'Parametro(4) = New SqlParameter
                'Parametro(4).ParameterName = "@FechaHasta"
                'Parametro(4).SqlDbType = SqlDbType.DateTime
                'Parametro(4).Size = 15

                If Me.cmbSucursal.Text.Trim.Length <> 0 And Me.cmbSucursal.SelectedValue <> "0" Then
                    Parametro(0).Value = Me.cmbSucursal.SelectedValue
                    If m_strFiltro.Trim.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND objTiendaID = @Sucursal"
                    Else
                        m_strFiltro = " objTiendaID = @Sucursal"
                    End If
                End If

                If (Me.cmbRepuesto.Text.Trim.Length <> 0) And (Me.cmbRepuesto.Text <> "TODOS") Then

                    Parametro(1).Value = Me.cmbRepuesto.SelectedValue
                    If m_strFiltro.Trim.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND Codigo= @Repuesto"
                    Else
                        m_strFiltro = " Codigo= @Repuesto"
                    End If
                End If

                If (Me.cmbTipoRepuesto.Text.Trim.Length <> 0) And (Me.cmbTipoRepuesto.Text <> "TODOS") Then
                    Parametro(2).Value = Me.cmbTipoRepuesto.SelectedValue
                    If m_strFiltro.Trim.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND objTipoRepuesto = @TipoRepuesto"
                    Else
                        m_strFiltro = " objTipoRepuesto = @TipoRepuesto"
                    End If
                End If

                strFechaDesde = Format(Me.dtpDesde.Value, "yyyyMMdd")
                strFechaHasta = Format(Me.dtpHasta.Value, "yyyyMMdd")

                'Parametro(3).Value = Convert.ToDateTime(Trim(Me.dtpDesde.Value))
                'Parametro(4).Value = Convert.ToDateTime(Trim(Me.dtpHasta.Value))

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

#Region "Imprimir"

    Private Sub Imprimir()
        Dim visor As New frmVisorRS
        Dim sCampos, sSQL As String
        Dim dtDatos As DataTable
       
        sCampos = "(select sum(Total)as TotalSucursal from vwRptSfaRepuestosFactura as RepuestosFactura where RepuestosFactura.objTiendaID= vwRptSfaRepuestosFactura.objTiendaID AND " & m_strFiltro & " ) as TotalSucursal,Codigo, DescripcionCorta,Precio, Cantidad, Subtotal, Descuento, Impuesto, Total, TipoRepuestos, Sucursal, objTiendaID, SfaFacturaRepuestoID, Fecha, objTipoRepuesto,CodigoSucursal"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptSfaRepuestosFactura", m_strFiltro)
        dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL, Me.Parametro)

        If dtDatos.Rows.Count = 0 Then
            MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Exit Sub
        End If

        With visor.VisorReportes
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportEmbeddedResource = "SCCUM.rptSfaRepuestosFacturados.rdlc"
            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DtRptRepuestosFacturados_vwRptSfaRepuestosFactura", dtDatos))
            Me.CargarEncabezadoReporte(.LocalReport)
            .RefreshReport()
        End With
        visor.ShowDialog()

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

#Region "Eventos"

    Private Sub frmSfaRptFacturaRepuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CargarTienda()
        Me.CargarRepuestos()
        Me.CargarTipoRepuesto()
    End Sub

    Private Sub dtpDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.TextChanged
        Me.ErrorImprimirFactura.SetError(Me.dtpDesde, "")
        Me.ErrorImprimirFactura.SetError(Me.dtpHasta, "")
    End Sub

    Private Sub dtpHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.TextChanged
        Me.ErrorImprimirFactura.SetError(Me.dtpHasta, "")
        Me.ErrorImprimirFactura.SetError(Me.dtpDesde, "")
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.Validar Then
            Me.ObtenerFiltro()
            Imprimir()
            ' Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

#End Region

End Class