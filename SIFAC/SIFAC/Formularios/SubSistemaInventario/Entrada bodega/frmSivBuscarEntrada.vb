Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO
Imports SIFAC.BO.clsConsultas
Imports System.IO

Public Class frmSivBuscarEntrada
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

    Private Sub ObtenerFiltro()
        Dim sFechaFormateadaDesde, sFechaFormateadaHasta, sFechaFormateadaFactura As String
        sFechaFormateadaDesde = Format(Convert.ToDateTime(Me.dtpFechaDesde.Value).Date, "yyyy-MM-dd")
        sFechaFormateadaHasta = Format(Convert.ToDateTime(Me.dtpFechaHasta.Value).Date, "yyyy-MM-dd")
        mFiltro = " CAST(CAST(Fecha AS VARCHAR(11)) AS DATETIME) >= '" & sFechaFormateadaDesde & "' AND CAST(CAST(Fecha AS VARCHAR(11)) AS DATETIME) <= '" & sFechaFormateadaHasta & "'"

        If Me.txtNumeroEntrada.Text.Trim.Length <> 0 Then
            mFiltro = mFiltro & " AND NumeroEntrada = " & Me.txtNumeroEntrada.Text
        End If

        If Me.cmbTipoEntrada.Text <> "NO APLICA" Then
            If Me.cmbTipoEntrada.Text.Trim.Length <> 0 Then
                mFiltro = mFiltro & " AND objTipoEntradaID = " & Me.cmbTipoEntrada.SelectedValue
            End If
        End If

        If Me.txtNumeroFactura.Text.Trim.Length <> 0 Then
            mFiltro = mFiltro & " AND NumeroFactura = " & Me.txtNumeroFactura.Text
        End If

        If Me.dtpFechaFactura.Text.Trim.Length <> 0 Then
            sFechaFormateadaFactura = Format(Convert.ToDateTime(Me.dtpFechaFactura.Value).Date, "yyyy-MM-dd")
            mFiltro = mFiltro & " AND CAST(CAST(FechaFactura AS VARCHAR(11)) AS DATETIME) = '" & sFechaFormateadaFactura & "'"
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

    Private Sub CargarTipoEntrada()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "(objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOENTRADA')) AND Activo=1"))
            With cmbTipoEntrada
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    Private Sub frmSivBuscarSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CargarTipoEntrada()
        Me.cmbTipoEntrada.Text = "NO APLICA"

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

    Private Sub dtpFechaDesde_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaDesde.TextChanged
        Me.ErrorBuscar.SetError(dtpFechaDesde, "")
    End Sub

    Private Sub dtpFechaHasta_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaHasta.TextChanged
        Me.ErrorBuscar.SetError(dtpFechaHasta, "")
    End Sub
End Class