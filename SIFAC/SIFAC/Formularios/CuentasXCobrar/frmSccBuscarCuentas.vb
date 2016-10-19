
Imports DAL
Imports System.Data
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos

Public Class frmSccBuscarCuentas
    Dim m_Filtro As String
    Property Filtro() As String
        Get
            Filtro = Me.m_Filtro
        End Get
        Set(ByVal value As String)
            Me.m_Filtro = value
        End Set
    End Property

    Public Sub CargarEstados()
        Dim dtDatos As New DataTable
        Try
            dtDatos = ClsCatalogos.ObtenerValCat("ESTADOEXPEDIENTE")
            With Me.cmbEstado
                .DataSource = dtDatos
                .ValueMember = "StbValorCatalogID"
                .DisplayMember = "Descripcion"
                .ExtendRightColumn = True
                .ColumnHeaders = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSccBuscarCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.CargarEstados()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim strFiltro As String = ""
        Try
            If Trim(Me.txtNumExp.Text) <> "" Then
                strFiltro = "SccCuentaID= '" & Trim(Me.txtNumExp.Text) & "'"
                GoTo Final
            End If

            If Trim(Me.txtCedula.Text) <> "-      -" Then
                strFiltro = "Cedula = '" & Trim(Me.txtCedula.Text) & "'"
                GoTo Final
            End If

            If Me.cmbEstado.Text <> "" Then
                strFiltro = "Estado='" & Me.cmbEstado.Text & "'"
            End If

Final:
            If strFiltro = "" Then
                strFiltro = "1=1"
            End If
            Me.Filtro = strFiltro
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtNumExp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumExp.KeyPress
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub
End Class