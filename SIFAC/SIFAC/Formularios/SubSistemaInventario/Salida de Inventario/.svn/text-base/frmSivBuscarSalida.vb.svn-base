Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.Cursors
Imports SCCUM.BO
Imports SCCUM.BO.clsConsultas
Imports System.IO

Public Class frmSivBuscarSalida
    Dim mFiltro As String
    Dim dtBodega, dtTipoSalida As DataTable

    Property Filtro() As String
        Get
            Return mFiltro
        End Get
        Set(ByVal value As String)
            mFiltro = value
        End Set
    End Property

    'Modificado por: Gelmin Martínez 07 Agosto 2010 (Cambio de Formato de fechadesde y fechahasta)
    Private Sub ObtenerFiltro()
        Dim sFechaFormateadaDesde, sFechaFormateadaHasta As String
        'sFechaFormateadaDesde = Format(Convert.ToDateTime(Me.dtpFechaDesde.Value).Date, "yyyy-MM-dd")
        'sFechaFormateadaHasta = Format(Convert.ToDateTime(Me.dtpFechaHasta.Value).Date, "yyyy-MM-dd")
        sFechaFormateadaDesde = Format(Me.dtpFechaDesde.Value, "yyyyMMdd")
        sFechaFormateadaHasta = Format(Me.dtpFechaHasta.Value, "yyyyMMdd")

        mFiltro = " CONVERT(VARCHAR,FechaSalida,112) >= '" & sFechaFormateadaDesde & "' AND CONVERT(VARCHAR, FechaSalida,112) <= '" & sFechaFormateadaHasta & "'"

        If Me.txtNumeroSalida.Text.Trim.Length <> 0 Then
            mFiltro = mFiltro & " AND Numero = " & Me.txtNumeroSalida.Text
        End If

        If Me.cmbBodega.Text <> "NO APLICA" Then
            If Me.cmbBodega.Text.Trim.Length <> 0 Then
                mFiltro = mFiltro & " AND objTiendaID = " & Me.cmbBodega.SelectedValue
            End If
        End If

        If Me.cmbTipoSalida.Text <> "NO APLICA" Then
            If Me.cmbTipoSalida.Text.Trim.Length <> 0 Then
                mFiltro = mFiltro & " AND objTipoSalidaID = " & Me.cmbTipoSalida.SelectedValue
            End If
        End If
    End Sub

    Private Function Validar() As Boolean

        If Me.dtpFechaDesde.Text.Trim.Length = 0 Then
            Me.ErrorBuscar.SetError(Me.dtpFechaDesde, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpFechaHasta.Text.Trim.Length = 0 Then
            Me.ErrorBuscar.SetError(Me.dtpFechaHasta, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpFechaDesde.Value > Me.dtpFechaHasta.Value Then
            Me.ErrorBuscar.SetError(Me.dtpFechaDesde, "La Fecha Desde debe ser menor que la Fecha Hasta")
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub CargarBodega()
        dtBodega = New DataTable
        Try
            dtBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbTiendaID, Codigo, Nombre ", "StbTienda", "Activo = 1 AND ActivoRepuesto=1 order by Nombre"))

            Me.cmbBodega.DataSource = dtBodega
            Me.cmbBodega.DisplayMember = "Nombre"
            Me.cmbBodega.ValueMember = "StbTiendaID"
            Me.cmbBodega.Splits(0).DisplayColumns("StbTiendaID").Visible = False
            Me.cmbBodega.Splits(0).DisplayColumns("Codigo").Width = 40
            Me.cmbBodega.ExtendRightColumn = True
            Me.cmbBodega.SelectedIndex = 0
            Me.cmbBodega.ColumnHeaders = False

            Me.dtBodega.Rows.Add("0", "-", "NO APLICA")
            Me.cmbBodega.SelectedValue = "0"

            'Si Bodega sessión no es CENTRAL deshabilitar combo.
            If frmSivSalidaBodega.glb_SucursalSessionID <> frmSivSalidaBodega.glb_SucursalCentralID Then
                Me.cmbBodega.SelectedValue = frmSivSalidaBodega.glb_SucursalSessionID
                Me.cmbBodega.Enabled = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarTipoSalida()
        dtTipoSalida = New DataTable
        Try
            dtTipoSalida = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOSALIDA')"))
            Me.cmbTipoSalida.DataSource = dtTipoSalida
            Me.cmbTipoSalida.DisplayMember = "Descripcion"
            Me.cmbTipoSalida.ValueMember = "StbValorCatalogoID"
            Me.cmbTipoSalida.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipoSalida.ExtendRightColumn = True
            Me.cmbTipoSalida.SelectedIndex = 0
            Me.cmbTipoSalida.ColumnHeaders = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSivBuscarSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarBodega()
        Me.CargarTipoSalida()
        Me.cmbTipoSalida.Text = "NO APLICA"
        'Me.cmbBodega.Text = "NO APLICA"

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.Validar Then
            Me.ObtenerFiltro()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged, dtpFechaHasta.TextChanged
        Me.ErrorBuscar.Clear()
    End Sub

    Private Sub txtNumeroSalida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroSalida.TextChanged
        Try
            If Me.txtNumeroSalida.Value >= Integer.MaxValue Then
                Me.txtNumeroSalida.Value = 0
            End If
        Catch ex As Exception
            Me.txtNumeroSalida.Value = 0
        End Try        
    End Sub

End Class