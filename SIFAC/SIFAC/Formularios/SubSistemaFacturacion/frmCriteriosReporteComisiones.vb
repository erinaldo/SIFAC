'-- Autor: Gelmin Martínez
'-- Fecha: 20 Julio 2010, 02:55 pm.
'-- Formulario para seleccionar parámetros de filtrado del reporte 
'-- de Comisiones

Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos

Public Class frmCriteriosReporteComisiones

#Region "Atributos"
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer
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
    ''' Fecha 20 de Julio de 2010, 02:56 pm.
    ''' </summary>
    Private Sub CargarComboSucursales()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("ActivoRepuesto=1", "Nombre", "StbTiendaID,Codigo, Nombre")
            With Me.cmbSucursales
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 30
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtDatos.Rows.Add("0", "-", "TODOS")
            Me.cmbSucursales.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Vendedores
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Julio de 2010, 09:47 am.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboVendedores()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID, Login, NombreCompleto", "dbo.vwSrhVendedores", "1=1 ORDER BY Login"))
            If dtDatos.DefaultView.Count > 0 Then
                With Me.cmbVendedores
                    .DataSource = dtDatos
                    .DisplayMember = "NombreCompleto"
                    .ValueMember = "SrhEmpleadoID"
                    .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
                    .Splits(0).DisplayColumns("Login").Width = 50
                    .ExtendRightColumn = True
                    .ColumnHeaders = False
                End With
                dtDatos.Rows.Add("0", "-", "TODOS")
                Me.cmbVendedores.SelectedValue = 0
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar Formulario"
    Private Sub frmCriteriosReporteComisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarComboSucursales()

        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.VerificarSucursalRepuesto()

        Me.cmbSucursales.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral
        Me.CargarComboVendedores()
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

#Region "Eventos Controles"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.VerificarCriterios() Then
            Me.Imprimir_Reporte(Me.DevolverFiltro())
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged
        Me.ErrErrores.Clear()
    End Sub

#End Region

#Region "Verificar Criterios"
    Private Function VerificarCriterios() As Boolean
        Dim blnValido As Boolean = True

        'Verificar período vacío
        If Me.dtpFechaDesde.Value.ToString.Trim.Length = 0 Or Me.dtpFechaHasta.Value.ToString.Trim.Length = 0 Then
            MsgBox("No ha seleccionado un período de tiempo correcto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            If Me.dtpFechaDesde.Value.ToString.Length = 0 Then
                Me.dtpFechaDesde.Focus()
            Else
                Me.dtpFechaHasta.Focus()
            End If
            blnValido = False
            Exit Function
        End If

        'Verificar período
        If Convert.ToDateTime(Me.dtpFechaDesde.Value).Date > Convert.ToDateTime(Me.dtpFechaHasta.Value).Date Then
            Me.ErrErrores.SetError(Me.dtpFechaDesde, "La fecha desde debe ser menor o igual a fecha hasta.")
            blnValido = False
            Exit Function
        End If

        Return blnValido

    End Function
#End Region

#Region "Devolver Filtro"
    ''' <summary>
    ''' Función encargada de construir y devolver el filtro que ocupará la consulta del reporte. 
    ''' este se construye en base a los criterios seleccionados por el usuario
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Julio de 2010, 03:00 pm.
    ''' </summary>
    Private Function DevolverFiltro() As String
        Dim strFiltro As String = String.Empty

        'Verificar si seleccionó sucursal
        If Me.cmbSucursales.SelectedValue <> 0 Then
            strFiltro = " objTiendaID = " + Me.cmbSucursales.SelectedValue.ToString
        End If

        If Me.cmbVendedores.SelectedValue <> 0 Then
            If strFiltro.Length = 0 Then
                strFiltro = " SrhEmpleadoID = " + Me.cmbVendedores.SelectedValue.ToString
            Else
                strFiltro += " AND SrhEmpleadoID = " + Me.cmbVendedores.SelectedValue.ToString
            End If
        End If

        'Asignar rango de fechas (112=Fecha en formato ISO, ejemplo: 20 Julio 2010 = 20100720)
        If Not IsDBNull(dtpFechaDesde.Value) And Not IsDBNull(dtpFechaHasta.Value) Then
            If strFiltro.Length = 0 Then
                strFiltro = "(CONVERT(VARCHAR,FechaFactura,112) >='" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "' AND CONVERT(VARCHAR,FechaFactura,112) <='" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "')"
            Else
                strFiltro += " AND (CONVERT(VARCHAR,FechaFactura,112) >='" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "' AND CONVERT(VARCHAR,FechaFactura,112) <='" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "')"
            End If
        End If

        If Not String.IsNullOrEmpty(strFiltro) Then
            strFiltro += " AND NombreVendedor IS NOT NULL"
        Else
            strFiltro = "1=0"
        End If

        Return strFiltro
    End Function
#End Region

#Region "Imprimir Reporte"
    Private Sub Imprimir_Reporte(ByVal strFiltro As String)
        Dim dtDatos As DataTable
        Dim strCampos, strSQL As String
        Dim Visor As New frmVisorRS
        Try
            strCampos = "objTiendaID, CodigoSucursal, Sucursal, SrhEmpleadoID, NoFactura, NombreVendedor, PorcentajeComision, SfaFacturaRepuestoID, CONVERT(VARCHAR,FechaFactura,103) AS FechaFactura, NombreCliente, SubTotal, Descuento, Impuesto, TotalDolares, Comison, objEstadoID, TasaCambio"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptComisiones", strFiltro)
            dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

            If dtDatos.Rows.Count <> 0 Then
                With Visor.VisorReportes
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .LocalReport.ReportEmbeddedResource = "SCCUM.rptComisiones.rdlc"
                    .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtDatosRptComisiones_vwRptComisiones", dtDatos))
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

        'Agregación de rango de fechas al encabezado
        Dim strDesde, strHasta As String
        strDesde = Format(dtpFechaDesde.Value, "dd/MM/yyyy")
        strHasta = Format(dtpFechaHasta.Value, "dd/MM/yyyy")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFechaDesde", strDesde, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFechaHasta", strHasta, False))

        reporte.SetParameters(parametros)
    End Sub
#End Region

End Class