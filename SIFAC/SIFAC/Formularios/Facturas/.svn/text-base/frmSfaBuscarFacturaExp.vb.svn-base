Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Data.SqlClient

Public Class frmSfaBuscarFacturaExp
    Public strFiltro As String
    Public Parametros(4) As SqlClient.SqlParameter

    Private Sub frmSfaBuscarFacturaExp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarConcepto()
        Me.CargarEstados()
    End Sub

    Private Sub CargarEstados()
        Dim dtDatos As New DataTable
        Try
            dtDatos = ClsCatalogos.ObtenerValCat("ESTADOCUENTA")
            With Me.cmbEstado
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub CargarConcepto()
        Dim dtDatos As New DataTable
        Try
            dtDatos = ClsCatalogos.ObtenerValCat("CONCEPTOFACTURA")
            With Me.cmbConcepto
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub AplicarFiltro()
        Try
            Parametros(0) = New SqlParameter
            Parametros(0).ParameterName = "@IdExpediente"
            Parametros(0).DbType = DbType.String

            Parametros(1) = New SqlParameter
            Parametros(1).ParameterName = "@NumeroFactura"
            Parametros(1).DbType = DbType.String

            Parametros(2) = New SqlParameter
            Parametros(2).ParameterName = "@IdEstado"
            Parametros(2).DbType = DbType.Int32

            Parametros(3) = New SqlParameter
            Parametros(3).ParameterName = "@IdConcepto"
            Parametros(3).DbType = DbType.Int32


            If Me.txtNumExp.Text <> "" Then
                Parametros(0).Value = Trim(Me.txtNumExp.Text)
                Me.strFiltro = "objSccCuentaID = @IdExpediente"
            End If

            If Me.txtNumfact.Text <> "" Then
                Parametros(1).Value = Trim(Me.txtNumfact.Text)
                If Me.strFiltro = "" Then
                    Me.strFiltro = "Numero = @NumeroFactura"
                Else
                    Me.strFiltro = strFiltro + " AND Numero = @NumeroFactura"
                End If
            End If

            If Me.cmbEstado.Text <> "" Then
                Parametros(2).Value = Me.cmbEstado.SelectedValue
                If strFiltro = "" Then
                    strFiltro = " objEstadoID = @IdEstado "
                Else
                    strFiltro = strFiltro + " AND objEstadoID = @IdEstado"
                End If
            End If

            If Me.cmbConcepto.Text <> "" Then
                Parametros(3).Value = Me.cmbConcepto.SelectedValue
                If strFiltro = "" Then
                    strFiltro = " ObjConceptoFactura = @IdConcepto"
                Else
                    strFiltro = strFiltro + " and ObjConceptoFactura =@IdConcepto"
                End If
            End If

            If strFiltro = "" Then
                strFiltro = "1=1"
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Me.AplicarFiltro()
    End Sub

    Private Sub txtNumExp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumExp.KeyPress
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub

    Private Sub txtNumfact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumfact.KeyPress
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub
End Class