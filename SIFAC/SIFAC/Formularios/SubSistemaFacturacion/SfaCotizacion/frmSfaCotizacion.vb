Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SCCUM.BO.clsConsultas
Imports SCCUM.BO
Imports proyecto.Catalogos.Datos

Public Class frmSfaCotizacion

#Region "Variables del formulario"
    Dim dtCotizacion, dtCotizacionDetalle As DataTable
    Dim dsCotizacion As DataSet
    Dim blnAgregar, blnAnular, blnConsultar, blnImprimir As Boolean
#End Region

#Region "Inicializar Pantalla"

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Enrique Escobar Maradiaga.
    ''' Fecha : 02 de Junio de 2010.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSFACOTIZACION"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAgregar = objSeg.TienePermiso("AGREGARCOTIZACION")
            Me.blnAnular = objSeg.TienePermiso("ANULARCOTIZACION")
            Me.blnConsultar = objSeg.TienePermiso("CONSULTARCOTIZACION")
            Me.blnImprimir = objSeg.TienePermiso("IMPRIMIRCOTIZACION")

            'Aplicar permisos a los comandos
            Me.cmdAgregar.Enabled = Me.blnAgregar
            Me.cmdAnular.Enabled = Me.blnAnular
            Me.cmdConsultar.Enabled = Me.blnConsultar
            Me.cmdImprimir.Enabled = Me.blnImprimir

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Grid"
    Public Sub CargarCotizaciones(ByVal Filtro As String)
        Dim DiasCotizacionRecientes As Integer
        Dim CodigoSucursal As String
        Try
            DiasCotizacionRecientes = StbParametro.RetrieveDT("Nombre = 'DiasCotizacion'", , "Valor").DefaultView.Item(0)("Valor")
            CodigoSucursal = clsProyecto.Sucursal
            'solo la tienda central puede ver todas las cotizaciones
            If CodigoSucursal = "C" Then
                dtCotizacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SfaCotizacionID, FormatoNumero, CONVERT(VARCHAR,Fecha,103) AS Fecha,Sucursal, Cliente, Vendedor, TotalDolares, Valido, Anulada", "vwSfaCotizacion", Filtro & " AND CAST(CAST(Fecha AS VARCHAR(11)) AS DATETIME) BETWEEN GETDATE()-" & DiasCotizacionRecientes + 1 & " AND GETDATE()" & " ORDER BY SfaCotizacionID DESC"))
            Else
                dtCotizacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SfaCotizacionID, FormatoNumero, CONVERT(VARCHAR,Fecha,103) AS Fecha,Sucursal, Cliente, Vendedor, TotalDolares, Valido, Anulada", "vwSfaCotizacion", Filtro & " AND CAST(CAST(Fecha AS VARCHAR(11)) AS DATETIME) BETWEEN GETDATE()-" & DiasCotizacionRecientes + 1 & " AND GETDATE()" & " AND CodigoTienda= " & "'" & CodigoSucursal & "'" & " ORDER BY SfaCotizacionID DESC"))
            End If

            dtCotizacionDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objCotizacionID, CodigoRepuesto, DescripcionCorta, Cantidad, Precio, Subtotal, Descuento, Impuesto, Total", "vwSfaCotizacionDetalle", Filtro & " ORDER BY objCotizacionID DESC"))
            dsCotizacion = New DataSet
            dsCotizacion.Merge(dtCotizacion)
            dsCotizacion.Tables(0).TableName = "SivCotizacion"
            dsCotizacion.Merge(dtCotizacionDetalle)
            dsCotizacion.Tables(1).TableName = "SivCotizacionDetalle"

            dsCotizacion.Relations.Add("SivCotizacion_SivCotizacionDetalle", dsCotizacion.Tables(0).Columns("SfaCotizacionID"), dsCotizacion.Tables(1).Columns("objCotizacionID"), False)
            Me.grdCotizacion.SetDataBinding(dsCotizacion, "SivCotizacion", True)
            dsCotizacion.Tables("SivCotizacion").PrimaryKey = New DataColumn() {dsCotizacion.Tables("SivCotizacion").Columns("FormatoNumero")}
            dsCotizacion.Tables("SivCotizacion").DefaultView.Sort = "FormatoNumero"
            Me.grdDetalleCotizacion.SetDataBinding(dsCotizacion, "SivCotizacion.SivCotizacion_SivCotizacionDetalle", True)
            Me.grdCotizacion.Caption = "Cotizaciones(" & Me.grdCotizacion.RowCount & ")"
            Me.bloquearBotonesBarra(Me.dtCotizacion.Rows.Count = 0)

            Me.grdCotizacion.Splits(0).DisplayColumns("SfaCotizacionID").Visible = False

            If Me.dtCotizacion.Rows.Count = 0 Then
                Me.cmdAnular.Enabled = False
                Me.cmdConsultar.Enabled = False
                Me.cmdImprimir.Enabled = False
            Else
                Me.cmdAnular.Enabled = Me.blnAnular
                Me.cmdConsultar.Enabled = Me.blnConsultar
                Me.cmdImprimir.Enabled = Me.blnImprimir
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Operaciones"

#Region "Agregar"
    Private Sub Agregar()
        Dim objfrmSfaCotizacionEditar As frmSfaCotizacionEditar
        Try
            Try
                objfrmSfaCotizacionEditar = New frmSfaCotizacionEditar
                objfrmSfaCotizacionEditar.TypeGui = 0
                If objfrmSfaCotizacionEditar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarCotizaciones("1=1")
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objfrmSfaCotizacionEditar = Nothing
        End Try
    End Sub
#End Region

#Region "Anular"

    Private Sub Anular()
        Dim objfrmSfaCotizacionAnular As frmSfaCotizacionAnular
        Try
            Try
                objfrmSfaCotizacionAnular = New frmSfaCotizacionAnular
                objfrmSfaCotizacionAnular.TypeGui = 1
                If Not IsDBNull(Me.grdCotizacion.Columns("FormatoNumero").Value) Then
                    objfrmSfaCotizacionAnular.NumeroCotizacion = Me.grdCotizacion.Columns("FormatoNumero").Value
                End If
                If Not IsDBNull(Me.grdCotizacion.Columns("SfaCotizacionID").Value) Then
                    objfrmSfaCotizacionAnular.SfaCotizacionID = Me.grdCotizacion.Columns("SfaCotizacionID").Value
                End If
                If objfrmSfaCotizacionAnular.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarCotizaciones("1=1")
                    'Me.grdCotizacion.Row = Me.dsCotizacion.Tables("SfaCotizacionID").DefaultView.Find(objfrmSfaCotizacionAnular.SfaCotizacionID)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objfrmSfaCotizacionAnular = Nothing
        End Try
    End Sub

#End Region

#Region "Consultar"
    Private Sub Consultar()
        Dim objfrmSfaCotizacionAnular As frmSfaCotizacionAnular
        Try
            Try
                objfrmSfaCotizacionAnular = New frmSfaCotizacionAnular
                objfrmSfaCotizacionAnular.TypeGui = 2
                objfrmSfaCotizacionAnular.SfaCotizacionID = Me.grdCotizacion.Columns("FormatoNumero").Value
                objfrmSfaCotizacionAnular.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objfrmSfaCotizacionAnular = Nothing
        End Try
    End Sub
#End Region

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
        If Me.grdCotizacion.RowCount = 0 Then
            Exit Sub
        End If
        Dim strFiltro, strSQL, strCampos As String
        Dim dtDatos As DataTable
        Dim Visor As New frmVisorRS
        Try

            strFiltro = "NumeroFormateado=" & Me.grdCotizacion.Columns("FormatoNumero").Value.ToString
            strCampos = "Numero, NumeroFormateado, objTiendaID, Nombre, objClienteID, Cliente, AtencionA, TelefonosCliente, FaxsCliente, EmailsCliente, DireccionCliente, Fecha, FechaReal, objVendedorID, Vendedor, TelefonoVendedor, CelularVendedor, EmailVendedor, CodigoRepuesto, DescripcionCorta, Cantidad, Precio, Descuento, Impuesto, SubTotal, Total, SubtotalMaestro, DescuentoMaestro, ImpuestoMaestro, TotalDolares, TotalCordobas, objTiempoEntregaID, TiempoEntrega, TasaCambio, Valido, objTerminoPagoID, TerminoPago, Comentario, Anulada"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptSfaCotizacion", strFiltro + " ORDER BY Numero")
            dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

            With Visor.VisorReportes
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = "SCCUM.rptCotizacion.rdlc"
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DtRptCotizacion_vwRptSfaCotizacion", dtDatos))
                Me.CargarEncabezadoReporte(.LocalReport)
                .RefreshReport()
            End With
            Visor.ShowDialog()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
            Visor = Nothing
        End Try
    End Sub

#End Region

#End Region

#Region "Bloquear botones barra"
    Private Sub bloquearBotonesBarra(ByVal bValor As Boolean)
        Me.cmdAnular.Enabled = (Not bValor) And blnAnular
        Me.cmdConsultar.Enabled = (Not bValor) And blnConsultar
        Me.cmdImprimir.Enabled = (Not bValor) And blnImprimir
    End Sub
#End Region

#Region "Eventos del Formulario"

    Private Sub frmSccCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            Me.AplicarSeguridad()
            Call CargarCotizaciones("1=1")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdCuentas_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCotizacion.FilterChange
        Me.grdCotizacion.Caption = "Cotizaciones (" & Me.grdCotizacion.RowCount.ToString & ")"
        If grdCotizacion.RowCount <= 0 Then
            Me.cmdAnular.Enabled = False
            Me.cmdConsultar.Enabled = False
            Me.cmdImprimir.Enabled = False
        Else
            Me.cmdAnular.Enabled = True
            Me.cmdConsultar.Enabled = True
            Me.cmdImprimir.Enabled = True
        End If
    End Sub

    Private Sub grdEntradaBodega_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdCotizacion.RowColChange
        If Me.grdCotizacion.RowCount <> 0 Then
            If grdCotizacion.Columns("Anulada").Value.ToString = "True" Then
                Me.cmdAnular.Enabled = False
            Else
                Me.cmdAnular.Enabled = True
            End If
        End If
    End Sub

#End Region

#Region "Botones"
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Call Me.Agregar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Call CargarCotizaciones("1=1")
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If Me.grdCotizacion.RowCount > 0 Then
            Me.Anular()
        End If
    End Sub
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Call Consultar()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Call Imprimir()
    End Sub

#End Region

End Class