'-- Autor: Gelmin Martínez
'-- Fecha: 11 Agosto 2010, 09:05 am.
'-- Formulario para seleccionar parámetros de filtrado del reporte 
'-- estadístico de servicios de taller.

Imports DAL
Imports SCCUM.BO
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos

Public Class frmCriterioReporteEstadisticoServicios

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

            dtDatos.Rows.Add("0", "-", "TODAS")
            Me.cmbSucursales.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar Formulario"
    Private Sub frmCriteriosReporteUtilidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarComboSucursales()

        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.VerificarSucursalRepuesto()

        Me.cmbSucursales.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral
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

#Region "Eventos de Formulario"
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

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged, dtpFechaHasta.TextChanged
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
    ''' Fecha 20 de Julio de 2010, 09:56 am.
    ''' </summary>
    Private Function DevolverFiltro() As String
        Dim strFiltro As String = String.Empty

        'Verificar si seleccionó sucursal
        If Me.cmbSucursales.SelectedValue <> 0 Then
            strFiltro = " objTiendaID = @objTiendaID" + Me.cmbSucursales.SelectedValue.ToString
        End If

        'Asignar rango de fechas (112=Fecha en formato ISO, ejemplo: 20 Julio 2010 = 20100720)
        If Not IsDBNull(dtpFechaDesde.Value) And Not IsDBNull(dtpFechaHasta.Value) Then
            If strFiltro.Length = 0 Then
                'strFiltro = "(CONVERT(VARCHAR,SfaFacturaRepuesto.Fecha,112) >='''" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "''' AND CONVERT(VARCHAR,SfaFacturaRepuesto.Fecha,112) <='''" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "''')"
            Else                
                'strFiltro += " AND (CONVERT(VARCHAR,SfaFacturaRepuesto.Fecha,112) >='''" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "''' AND CONVERT(VARCHAR,SfaFacturaRepuesto.Fecha,112) <='''" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "''')"
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
        Dim dsDatos As DataSet
        Dim parametros(3) As SqlClient.SqlParameter
        Dim strNombreReporte As String = String.Empty

        Dim Visor As New frmVisorRS
        Try
      
            'Tienda
            parametros(0) = New SqlClient.SqlParameter
            parametros(0).ParameterName = "@objTiendaID"
            parametros(0).SqlDbType = SqlDbType.Int
            parametros(0).Direction = ParameterDirection.Input

            If Me.cmbSucursales.SelectedValue <> 0 Then
                parametros(0).Value = Me.cmbSucursales.SelectedValue
                strNombreReporte = "SCCUM.rptEstadisticoServicioTallerSUCURSAL.rdlc"
            Else
                parametros(0).Value = 0
                strNombreReporte = "SCCUM.rptEstadisticoServicioTallerSucursales.rdlc"
            End If

            'Fecha Desde
            parametros(1) = New SqlClient.SqlParameter
            parametros(1).ParameterName = "@Desde"
            parametros(1).SqlDbType = SqlDbType.DateTime
            parametros(1).Direction = ParameterDirection.Input
            parametros(1).Value = Me.dtpFechaDesde.Value

            'Fecha Hasta
            parametros(2) = New SqlClient.SqlParameter
            parametros(2).ParameterName = "@Hasta"
            parametros(2).SqlDbType = SqlDbType.DateTime
            parametros(2).Direction = ParameterDirection.Input
            parametros(2).Value = Me.dtpFechaHasta.Value

            dsDatos = SqlHelper.ExecuteDataset(CommandType.StoredProcedure, "dbo.usp_CantidadServiciosBySucursal", parametros)

            If dsDatos.Tables(0).Rows.Count <> 0 Then
                With Visor.VisorReportes
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .LocalReport.ReportEmbeddedResource = strNombreReporte
                    .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtDatosRptEstadisticoServicios_usp_CantidadServiciosBySucursal", dsDatos.Tables(0)))
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
            dsDatos = Nothing
            Visor = Nothing
        End Try
    End Sub

    'Procedimiento encargado de cargar los datos del encabezado de reportes.
    Private Sub CargarEncabezadoReporte(ByRef reporte As Microsoft.Reporting.WinForms.LocalReport)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim strNombreEmpresa As String

        strNombreEmpresa = ClsCatalogos.GetValorParametro("EMPRESA")
        'strDirEmpresa = ClsCatalogos.GetValorParametro("DireccionEmpresa")
        'strTelEmpresa = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
        'strEmailEmpresa = ClsCatalogos.GetValorParametro("EMAIL")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmNombreEmpresa", strNombreEmpresa, False))
        'parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDireccionEmpresa", strDirEmpresa, False))
        'parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmTelefonoEmpresa", strTelEmpresa, False))
        'parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmEmailEmpresa", strEmailEmpresa, False))
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