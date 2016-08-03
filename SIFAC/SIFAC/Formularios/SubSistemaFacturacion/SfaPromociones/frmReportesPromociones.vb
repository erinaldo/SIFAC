'-- Autor: Gelmin Martínez
'-- Fecha: 05 Julio 2010, 04:05 pm.
'-- Formulario para seleccionar parámetros de filtrado del reporte de Promociones 
Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos

Public Class frmReportesPromociones

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

#Region "Cargar Combos"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Sucursales
    ''' Autor : Gelmin Martinez
    ''' Fecha 05 de Julio de 2010, 04:08 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboSucursales()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("ActivoRepuesto=1", "Nombre", "StbTiendaID, Codigo, Nombre")
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
#End Region

#Region "Cargar Formulario"
    Private Sub frmReportesPromociones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)

        Me.CargarComboSucursales()
        Me.VerificarSucursalRepuesto()

        Me.cmbSucursales.Enabled = (Me.IdSucursalSession = Me.IdSucursalCentral)

    End Sub
#End Region

#Region "Verificar Sucursal Repuesto"
    Private Sub VerificarSucursalRepuesto()
        If String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            MsgBox("No ha configurado la sucursal en el utilitario de configuración del sistema.", , clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            If Me.cmbSucursales.FindStringExact(Me.IdSucursalSession.ToString, 0, 0) = -1 Then
                MsgBox("La sucursal configurada en la sesión del sistema, no es una sucursal de Repuestos", , clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.cmbSucursales.SelectedValue = Me.IdSucursalSession
            End If
        End If
    End Sub
#End Region

#Region "Validaciones"
    Private Function ValidacionParametros() As Boolean
        Dim blnValido As Boolean = True

        'Verificar período vacío
        If Me.dtpFechaDesde.Value.ToString.Trim.Length = 0 Or Me.dtpFechaHasta.Value.ToString.Trim.Length = 0 Then
            MsgBox("No ha seleccionado un período de tiempo correcto.", , clsProyecto.SiglasSistema)

            If Me.dtpFechaDesde.Value.ToString.Length = 0 Then
                Me.dtpFechaDesde.Focus()
            Else
                Me.dtpFechaHasta.Focus()
            End If
            blnValido = False
            Exit Function
        End If

        'Verificar período
        If Convert.ToDateTime(Me.dtpFechaHasta.Value).Date > Convert.ToDateTime(Me.dtpFechaHasta.Value).Date Then
            Me.ErrProveedor.SetError(Me.dtpFechaHasta, "La fecha desde debe ser menor o igual a fecha hasta.")
            blnValido = False
            Exit Function
        End If

        Return blnValido
    End Function

#End Region

#Region "Eventos de controles"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Imprimir()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged, dtpFechaHasta.TextChanged
        Me.ErrProveedor.Clear()
    End Sub

#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim strFiltro, strSQL, strCampos As String
        Dim dtDatos As DataTable
        Dim Visor As New frmVisorRS
        Try
            If ValidacionParametros() Then

                'Construir el filtro para las solicitudes (112=Fecha en formato ISO, ejemplo: 09 Junio 2010 = 20100609)
                If Not IsDBNull(dtpFechaDesde.Value) And Not IsDBNull(dtpFechaHasta.Value) Then
                    strFiltro = "(CONVERT(VARCHAR,FechaInicio,112) >='" + Format(dtpFechaDesde.Value, "yyyyMMdd") + _
                                "' AND CONVERT(VARCHAR,FechaInicio,112) <='" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "')"

                    If Me.rdbActivas.Checked Then
                        strFiltro += " AND Activo=1"
                    ElseIf Me.rdbInactivas.Checked Then
                        strFiltro += " AND Activo=0"
                    End If

                    'Si ha seleccionado Sucursal
                    If Me.cmbSucursales.SelectedValue <> 0 Then
                        strFiltro += " AND SfaPromocionID IN (" + clsConsultas.ObtenerConsultaGeneral("objPromocionID", "dbo.SfaPromocionDetTienda", "objTiendaID=" + Me.cmbSucursales.SelectedValue.ToString) + ")"
                    End If
                Else
                    strFiltro = "1=0"
                End If

                strCampos = "SfaPromocionID, Descripcion, TiendasAplica, convert(varchar,fechainicio,103) as fechainicio, convert(varchar, fechafin, 103) as fechafin, " + _
                            " PromocionGlobal, AplicanRestricciones, Activo, objRepuestoID, objTipoRepuesto, DescripcionRepuestoTipoRepuesto, Precio, Descuento, PrecioPromocion"
                strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptSfaPromocion", strFiltro + " ORDER BY fechainicio")
                dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

                With Visor.VisorReportes
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .LocalReport.ReportEmbeddedResource = "SCCUM.rptPromociones.rdlc"
                    .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DtDatosRptSfaPromocion_vwRptSfaPromocion", dtDatos))
                    Me.CargarEncabezadoReporte(.LocalReport)
                    .RefreshReport()
                End With

                Visor.ShowDialog()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
            Visor = Nothing
        End Try
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

        reporte.SetParameters(parametros)
    End Sub

#End Region


End Class