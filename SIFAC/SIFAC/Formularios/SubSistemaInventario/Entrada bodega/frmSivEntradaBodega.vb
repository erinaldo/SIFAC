Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SCCUM.BO.clsConsultas
Imports SCCUM.BO
Imports proyecto.Catalogos.Datos
Imports Microsoft.Reporting.WinForms

Public Class frmSivEntradaBodega

#Region "Variables del formulario"
    Dim dtEntradaBodega, dtEntradaBodegaDetalle As DataTable
    Dim dsEntradaBodega As DataSet
    Dim blnAgregar, blnAnular, blnConsultar, blnImprimir As Boolean
#End Region

#Region "Inicializar Pantalla"

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Enrique Escobar Maradiaag.
    ''' Fecha : 02 de Junio de 2010.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSIVENTRADABODEGA"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAgregar = objSeg.TienePermiso("AGREGARENTRADABODEGA")
            Me.blnAnular = objSeg.TienePermiso("ANULARENTRADABODEGA")
            Me.blnConsultar = objSeg.TienePermiso("CONSULTARENTRADABODEGA")
            Me.blnImprimir = objSeg.TienePermiso("IMPRIMIRENTRADABODEGA")

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
    Public Sub CargarEntradas(ByVal Filtro As String)
        Dim DiasEntradasRecientes As Integer
        Try
            DiasEntradasRecientes = StbParametro.RetrieveDT("Nombre = 'DiasEntradas'", , "Valor").DefaultView.Item(0)("Valor")
            dtEntradaBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("NumeroEntrada, convert(varchar,Fecha,103) Fecha, TipoEntrada,objTipoEntradaID, NumeroFactura, FechaFactura, CostoTotal, Anulada", "vwSivEntradaBodega", Filtro & " AND Fecha BETWEEN GETDATE()-" & DiasEntradasRecientes + 1 & " AND GETDATE()" & " ORDER BY NumeroEntrada DESC"))
            dtEntradaBodegaDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objEntradaBodegaID, SivProductoID, Producto, Cantidad, Costo, Total", "vwSivEntradaBodegaDetalle", Filtro & " AND Fecha BETWEEN GETDATE()-366 AND GETDATE() ORDER BY objEntradaBodegaID DESC"))
            dsEntradaBodega = New DataSet
            dsEntradaBodega.Merge(dtEntradaBodega)
            dsEntradaBodega.Tables(0).TableName = "SivEntradabodega"
            dsEntradaBodega.Merge(dtEntradaBodegaDetalle)
            dsEntradaBodega.Tables(1).TableName = "SivEntradaBodegaDetalle"

            dsEntradaBodega.Relations.Add("SivEntradabodega_SivEntradabodegaDetalle", dsEntradaBodega.Tables(0).Columns("NumeroEntrada"), dsEntradaBodega.Tables(1).Columns("objEntradaBodegaID"))
            Me.grdEntradaBodega.SetDataBinding(dsEntradaBodega, "SivEntradabodega", True)
            dsEntradaBodega.Tables("SivEntradabodega").PrimaryKey = New DataColumn() {dsEntradaBodega.Tables("SivEntradabodega").Columns("NumeroEntrada")}
            dsEntradaBodega.Tables("SivEntradabodega").DefaultView.Sort = "NumeroEntrada"
            Me.grdDetalleEntradaBodega.SetDataBinding(dsEntradaBodega, "SivEntradabodega.SivEntradabodega_SivEntradabodegaDetalle", True)
            Me.grdEntradaBodega.Caption = "Entradas Bodegas(" & Me.grdEntradaBodega.RowCount & ")"
            Me.bloquearBotonesBarra(Me.dtEntradaBodega.Rows.Count = 0)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Operaciones"

#Region "Agregar"
    Private Sub Agregar()
        Dim objfrmSivEntradaBodegaEditar As frmSivEntradaBodegaEditar
        Try
            Try
                objfrmSivEntradaBodegaEditar = New frmSivEntradaBodegaEditar
                objfrmSivEntradaBodegaEditar.TypeGui = 0
                If objfrmSivEntradaBodegaEditar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarEntradas("1=1")
                    'Me.grdEntradaBodega.Row = Me.dsEntradaBodega.Tables("SivEntradabodega").DefaultView.Find(objfrmSivEntradaBodegaEditar.SivEntradaBodegaID.ToString)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objfrmSivEntradaBodegaEditar = Nothing
        End Try
    End Sub
#End Region

#Region "Anular"

    Private Sub Anular()
        If Me.grdEntradaBodega.RowCount = 0 Then
            Exit Sub
        End If
        Dim objfrmSivEntradaBodegaAnular As frmSivEntradaBodegaAnular
        Try
            Try
                objfrmSivEntradaBodegaAnular = New frmSivEntradaBodegaAnular
                objfrmSivEntradaBodegaAnular.TypeGui = 1
                objfrmSivEntradaBodegaAnular.SivEntradaBodegaID = Me.grdEntradaBodega.Columns("NumeroEntrada").Value
                If objfrmSivEntradaBodegaAnular.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarEntradas("1=1")
                    Me.grdEntradaBodega.Row = Me.dsEntradaBodega.Tables("SivEntradabodega").DefaultView.Find(frmSivEntradaBodegaAnular.SivEntradaBodegaID)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objfrmSivEntradaBodegaAnular = Nothing
        End Try
    End Sub

#End Region

#Region "Consultar"
    Private Sub Consultar()
        If Me.grdEntradaBodega.RowCount = 0 Then
            Exit Sub
        End If
        Dim objfrmSivEntradaBodegaAnular As frmSivEntradaBodegaAnular
        Try
            Try
                objfrmSivEntradaBodegaAnular = New frmSivEntradaBodegaAnular
                objfrmSivEntradaBodegaAnular.TypeGui = 2
                objfrmSivEntradaBodegaAnular.SivEntradaBodegaID = Me.grdEntradaBodega.Columns("NumeroEntrada").Value
                objfrmSivEntradaBodegaAnular.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objfrmSivEntradaBodegaAnular = Nothing
        End Try
    End Sub
#End Region

#Region "Buscar"

    Private Sub Buscar()
        Dim BuscarEntrada As frmSivBuscarEntrada
        Try
            BuscarEntrada = New frmSivBuscarEntrada
            If BuscarEntrada.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarEntradas(BuscarEntrada.Filtro)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            BuscarEntrada = Nothing
        End Try

    End Sub

#End Region

#Region "Cargar Encabezado Reporte"

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

#Region "Imprimir"
    Private Sub Imprimir()
        If Me.grdEntradaBodega.RowCount = 0 Then
            Exit Sub
        End If
        Dim strFiltro, strSQL, strCampos As String
        Dim dtDatos As DataTable
        Dim Visor As New frmVisorRS
        Try

            strFiltro = "NumeroEntrada=" & Me.grdEntradaBodega.Columns("NumeroEntrada").Value.ToString

            strCampos = "NumeroRelleno, NumeroEntrada, objStbBodegaID, Bodega, NumeroFactura, objTipoEntradaID, TipoEntrada, FechaEntrada, FechaFactura, Anulada, CodigoRepuesto, Descripcion, CantidadEntrante, CostoUnitario, SubTotal, Comentarios"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwrptSivEntradaBodega", strFiltro + " ORDER BY NumeroEntrada")
            dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

            With Visor.VisorReportes
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = "SCCUM.rptHojaEntrada.rdlc"
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DtRptEntrada_vwrptSfaEntradaBodega", dtDatos))
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
            Call CargarEntradas("1=1")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdCuentas_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdEntradaBodega.FilterChange
        Me.grdEntradaBodega.Caption = "Entradas Bodega(" & Me.grdEntradaBodega.RowCount.ToString & ")"
        If grdEntradaBodega.RowCount = 0 Then
            Me.cmdAnular.Enabled = False
            Me.cmdConsultar.Enabled = False
            Me.cmdImprimir.Enabled = False
        End If
        If grdEntradaBodega.RowCount > 0 Then
            Me.cmdAnular.Enabled = True
            Me.cmdConsultar.Enabled = True
            Me.cmdImprimir.Enabled = True
        End If
    End Sub

    Private Sub grdEntradaBodega_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdEntradaBodega.RowColChange
        If Me.dtEntradaBodega.Rows.Count > 0 Then
            If grdEntradaBodega.Columns("Anulada").Value.ToString = "True" Then
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
        Call CargarEntradas("1=1")
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If Me.grdEntradaBodega.RowCount > 0 Then
            Me.Anular()
        End If
    End Sub
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Call Consultar()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Call Me.Buscar()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Call Imprimir()
    End Sub

#End Region

End Class