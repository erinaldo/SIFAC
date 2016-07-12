Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursor
Imports SCCUM.BO.clsConsultas
Imports SCCUM.BO
Imports Proyecto.Catalogos.Datos

Public Class frmSivRptSalida
    Dim dtBodega As New DataTable
    Dim dtTipoSalida As New DataTable

#Region "Cargar combos"
    Private Sub CargarBodega()
        Dim SucursalSessionID As Integer
        Try
            dtBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbTiendaID, Codigo, Nombre", "StbTienda", "Activo = 1 AND ActivoRepuesto=1 Order by Nombre"))

            Me.cmbBodega.DataSource = dtBodega
            Me.cmbBodega.DisplayMember = "Nombre"
            Me.cmbBodega.ValueMember = "StbTiendaID"
            Me.cmbBodega.Splits(0).DisplayColumns("StbTiendaID").Visible = False
            Me.cmbBodega.Splits(0).DisplayColumns("Codigo").Width = 40
            Me.cmbBodega.ExtendRightColumn = True
            Me.cmbBodega.ColumnHeaders = False
            'Me.dtBodega.DefaultView.Sort = "Nombre"

            dtBodega.Rows.Add("0", "-", "TODAS")
            Me.cmbBodega.SelectedValue = "0"

            'Si Bodega sessión no es CENTRAL deshabilitar combo. 
            'Nota: (Debido a que este formulario se llama desde el principal se debe obtener la bodega en sessión en vez de usar frmSalidaBodega.glb_SucursalSessionID)
            SucursalSessionID = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
            If SucursalSessionID <> ClsCatalogos.GetStbTiendaID("C") Then
                Me.cmbBodega.SelectedValue = SucursalSessionID
                Me.cmbBodega.Enabled = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarTipoSalida()
        dtTipoSalida = New DataTable
        Try
            dtTipoSalida = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID, Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOSALIDA') ORDER BY Descripcion"))

            Me.cmbTipoSalida.DataSource = dtTipoSalida
            Me.cmbTipoSalida.DisplayMember = "Descripcion"
            Me.cmbTipoSalida.ValueMember = "StbValorCatalogoID"
            Me.cmbTipoSalida.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipoSalida.ExtendRightColumn = True
            '            Me.cmbTipoSalida.SelectedValue = 0
            Me.cmbTipoSalida.ColumnHeaders = False
            'Me.dtTipoSalida.DefaultView.Sort = "Descripcion"

            Me.dtTipoSalida.Rows.Add("0", "TODOS")
            Me.cmbTipoSalida.SelectedValue = "0"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Validar"
    Private Function Validar() As Boolean

        If Me.dtpFechaDesde.Text.Trim.Length = 0 Then
            Me.ErrorRptSalida.SetError(Me.dtpFechaDesde, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpFechaHasta.Text.Trim.Length = 0 Then
            Me.ErrorRptSalida.SetError(Me.dtpFechaHasta, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpFechaDesde.Value > Me.dtpFechaHasta.Value Then
            Me.ErrorRptSalida.SetError(Me.dtpFechaDesde, "La Fecha Desde debe ser menor que la Fecha Hasta")
            Return False
            Exit Function
        End If
        Return True
    End Function

#End Region

#Region "Imprimir"

    Private Function ObtenerFiltro() As String
        Dim strFiltro As String
        Dim sFechaFormateadaDesde, sFechaFormateadaHasta As String

        'sFechaFormateadaDesde = Format(Convert.ToDateTime(Me.dtpFechaDesde.Value).Date, "yyyy-MM-dd")
        'sFechaFormateadaHasta = Format(Convert.ToDateTime(Me.dtpFechaHasta.Value).Date, "yyyy-MM-dd")
        sFechaFormateadaDesde = Format(Me.dtpFechaDesde.Value, "yyyyMMdd")
        sFechaFormateadaHasta = Format(Me.dtpFechaHasta.Value, "yyyyMMdd")
        strFiltro = " CONVERT(VARCHAR,FechaSalida,112) >= '" & sFechaFormateadaDesde & "' AND CONVERT(VARCHAR, FechaSalida, 112) <= '" & sFechaFormateadaHasta & "'"

        If Me.cmbBodega.Text <> "TODAS" And Me.cmbBodega.Text.Trim.Length <> 0 Then
            If strFiltro.Trim.Length <> 0 Then
                strFiltro = strFiltro & " AND StbTiendaID = " & Me.cmbBodega.SelectedValue
            Else
                strFiltro = " StbTiendaID = " & Me.cmbBodega.SelectedValue
            End If
        End If

        If Me.cmbTipoSalida.Text <> "TODOS" And Me.cmbTipoSalida.Text.Trim.Length <> 0 Then
            If strFiltro.Trim.Length <> 0 Then
                strFiltro = strFiltro & " AND objTipoSalidaID = " & Me.cmbTipoSalida.SelectedValue
            Else
                strFiltro = " objTipoSalidaID = " & Me.cmbTipoSalida.SelectedValue
            End If
        End If

        Return strFiltro
    End Function

    Private Sub Imprimir()
        Dim objReporte As rptSivSalidaFiltrado
        Dim objImpresion As frmOpcionesImpresion
        Dim sSQL, sCampos As String
        Dim dtReporte As New DataTable

        objImpresion = New frmOpcionesImpresion
        objReporte = New rptSivSalidaFiltrado

        sCampos = "distinct dbo.fnRellenarCeros2(SivSalidaBodegaID,dbo.FnGetParametro('CantidadDigitosSalida')) as SivSalidaBodegaID, FechaSalida, StbTiendaID, TipoSalida, objEstadoID, objTipoSalidaID,BodegaCodigo, Estado, Bodega, CodigoRepuesto, objProveedorID, DescripcionCorta, Cantidad, costo, subtotal, Comentarios,Anulada"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptSalidaBodega", Me.ObtenerFiltro & " ORDER BY Bodega,SivSalidaBodegaID")
        dtReporte = DAL.SqlHelper.ExecuteQueryDT(sSQL)
        objReporte.DataSource = dtReporte

        objReporte.txtFechaDesde.Text = Me.dtpFechaDesde.Text
        objReporte.txtFechaHasta.Text = Me.dtpFechaHasta.Text

        If dtReporte.Rows.Count = 0 Then
            MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Exit Sub
        End If

        If objImpresion.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(objReporte)
                Case 2
                    clsProyecto.ImprimirEnImpresora(objReporte, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(objReporte, Me)
            End Select
        End If
    End Sub
#End Region

#Region "Eventos del Formulario"

    Private Sub frmSivRptSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarBodega()
        Me.CargarTipoSalida()
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged
        Me.ErrorRptSalida.SetError(Me.dtpFechaDesde, "")
    End Sub

    Private Sub dtpFechaHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.TextChanged
        Me.ErrorRptSalida.SetError(Me.dtpFechaDesde, "")
        Me.ErrorRptSalida.SetError(Me.dtpFechaHasta, "")
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.Validar Then
            Me.Imprimir()
        End If
    End Sub
#End Region
   
End Class