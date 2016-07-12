Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SCCUM.BO.clsConsultas
Imports SCCUM.BO
Imports System.Data.SqlClient
Imports System.IO
Imports proyecto.Catalogos.Datos
Public Class frmSivReporteArticulosAgotados

#Region "Declaración de Variables propias del formulario"
    Public dtTienda, dtTipoRepuesto, dtRptArticulosAgotados As DataTable
    Dim objSeg As SsgSeguridad
    Dim strCodigoTienda, strFiltroTienda As String
#End Region

#Region "Inicializar GUI"

#Region "Aplicar Seguridad"

    Private Sub Seguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "FRMSIVREPORTEPROVEEDOR"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("VERREPORTE") Then
                Me.Close()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Configurar GUI"
    Private Sub ConfigurarGUI()
        Me.CargarSucursales()
        Me.CargarTipoRepuesto()

        strCodigoTienda = clsProyecto.Sucursal
        strFiltroTienda = StbTienda.RetrieveDT("Codigo=" & "'" & strCodigoTienda & "'", , "StbTiendaID").DefaultView.Item(0)("StbTiendaID").ToString
        Me.cmbTienda.SelectedValue = strFiltroTienda

        If strCodigoTienda = "C" Then
            Me.cmbTienda.Enabled = True
        Else
            Me.cmbTienda.Enabled = False
        End If

    End Sub
#End Region

#Region "Cargar Sucursales"
    Private Sub CargarSucursales()
        Try
            dtTienda = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbTiendaID,Nombre", "StbTienda", "1=1 ORDER BY StbTiendaID"))
            With Me.cmbTienda
                .DataSource = dtTienda
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtTienda.Rows.Add("0", "TODAS")
            Me.cmbTienda.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Cargar Combo Tipo Repuesto"

    Private Sub CargarTipoRepuesto()
        Try
            dtTipoRepuesto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOREPUESTO') ORDER BY Descripcion"))
            With Me.cmbTipoRepuesto
                .DataSource = dtTipoRepuesto
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtTipoRepuesto.Rows.Add("0", "TODOS")
            Me.cmbTipoRepuesto.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#End Region

#Region "Operaciones"

#Region "Cargar Encabezado Reporte"

    Private Sub CargarEncabezadoReporte(ByRef reporte As Microsoft.Reporting.WinForms.LocalReport)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim strNombreEmpresa, strDirEmpresa, strTelEmpresa, strEmailEmpresa, strRUC, strSlogan As String

        strNombreEmpresa = ClsCatalogos.GetValorParametro("EMPRESA")
        strDirEmpresa = ClsCatalogos.GetValorParametro("DireccionEmpresa")
        strTelEmpresa = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
        strEmailEmpresa = ClsCatalogos.GetValorParametro("EMAIL")
        strRUC = ClsCatalogos.GetValorParametro("AutorizacionDGI")
        strSlogan = ClsCatalogos.GetValorParametro("ESLOGAN")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmNombreEmpresa", strNombreEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDireccionEmpresa", strDirEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmTelefonoEmailEmpresa", "Teléfono: " & strTelEmpresa & " Email: " & strEmailEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmRUCEmpresa", "RUC: " & strRUC, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmSloganEmpresa", strSlogan, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmUsuarioLogeado", clsProyecto.Conexion.Usuario, False))

        reporte.SetParameters(parametros)
    End Sub

#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim strFiltro, strSQL, strCampos As String
        Dim dtDatos As DataTable
        Dim Visor As New frmVisorRS
        Try
            strCodigoTienda = clsProyecto.Sucursal
            If Me.cmbTienda.SelectedValue = 6 Then
                If Me.cmbTipoRepuesto.SelectedValue = 0 Then
                    strFiltro = "1=1"
                Else
                    strFiltro = "objTipoRepuesto=" & Me.cmbTipoRepuesto.SelectedValue
                End If
                strCampos = "SivRepuestoID, objTipoRepuesto, objTiendaID, DescripcionCorta, TipoRepuesto, Marca, CantidadMinima, CantidadMaxima, Existencia, CostoProm, Proveedor, CodigoProductoProveedor, FechaUltimaEntrada, NumeroUltimaEntrada, CostoUltimaEntrada"
                strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "vwSivRptRepuestosAgotadosBodCentral", strFiltro + " ORDER BY SivRepuestoID")
                dtDatos = SqlHelper.ExecuteQueryDT(strSQL)
                If dtDatos.Rows.Count <> 0 Then
                    With Visor.VisorReportes
                        .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        .LocalReport.ReportEmbeddedResource = "SCCUM.rptArticulosAgotados.rdlc"
                        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtRptArticulosAgotados_vwSivRptRepuestosAgotados", dtDatos))
                        Me.CargarEncabezadoReporte(.LocalReport)
                        .RefreshReport()
                    End With
                    Visor.ShowDialog()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            Else
                If (Me.cmbTienda.SelectedValue = 0) And (Me.cmbTipoRepuesto.SelectedValue <> 0) Then
                    strFiltro = "objTipoRepuesto=" & Me.cmbTipoRepuesto.SelectedValue
                End If

                If (Me.cmbTienda.SelectedValue <> 0) And (Me.cmbTipoRepuesto.SelectedValue = 0) Then
                    strFiltro = "objTiendaID=" & Me.cmbTienda.SelectedValue
                End If

                If (Me.cmbTienda.SelectedValue = 0) And (Me.cmbTipoRepuesto.SelectedValue = 0) Then
                    strFiltro = "1=1"
                End If

                If (Me.cmbTienda.SelectedValue <> 0) And (Me.cmbTipoRepuesto.SelectedValue <> 0) Then
                    strFiltro = "objTiendaID=" & Me.cmbTienda.SelectedValue & " AND objTipoRepuesto=" & Me.cmbTipoRepuesto.SelectedValue
                End If

                strCampos = "SivRepuestoID, objTipoRepuesto, objTiendaID, Tienda, DescripcionCorta, TipoRepuesto, Marca, CantidadMinima, CantidadMaxima, Existencia, CostoProm, Agotado"
                strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "vwSivRptRepuestosAgotadosBodegas", strFiltro + " ORDER BY SivRepuestoID")
                dtDatos = SqlHelper.ExecuteQueryDT(strSQL)
                If dtDatos.Rows.Count <> 0 Then
                    With Visor.VisorReportes
                        .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        .LocalReport.ReportEmbeddedResource = "SCCUM.rptArticulosAgotadosTiendas.rdlc"
                        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtRptArticulosAgotadosBodegas_vwSivRptRepuestosAgotadosBodegas", dtDatos))
                        Me.CargarEncabezadoReporte(.LocalReport)
                        .RefreshReport()
                    End With
                    Visor.ShowDialog()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            End If
            'Visor.ShowDialog()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
            Visor = Nothing
        End Try
    End Sub
#End Region

#End Region

#Region "Eventos del Formulario"

    Private Sub frmSivReporteProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Seguridad()
        ConfigurarGUI()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.cmbTipoRepuesto.Text = "" Then
            MsgBox("Seleccione un tipo de repuesto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.cmbTipoRepuesto.Focus()
            Exit Sub
        End If
        Imprimir()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region

End Class