Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Catalogos.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmStbPersonasTipoPersonas

#Region "Declaracion de Variable propias del Formulario"
    Dim dtTipoPersona As DataTable
    Dim intfrmLlamado As Integer

    Public Property frmLlamado() As Integer
        Get
            Return intfrmLlamado
        End Get
        Set(ByVal value As Integer)
            intfrmLlamado = value
        End Set
    End Property
#End Region

#Region "Cargar Combo Tipo Persona"
    Private Sub CargarComboTipoPersona()
        Dim strFiltro As String = "1=1"
        Select Case frmLlamado
            Case 3
                strFiltro = "StbTipoPersonaID IN(1,4)"
            Case 4
                strFiltro = "StbTipoPersonaID IN(1,2,5)"
            Case 5
                strFiltro = "StbTipoPersonaID IN(1,2,4)"
        End Select
        Try
            Me.dtTipoPersona = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("StbTipoPersonaID,Descripcion", "StbTipoPersona", strFiltro))
            Me.cmbTipoPersona.DataSource = Me.dtTipoPersona
            Me.cmbTipoPersona.DisplayMember = "Descripcion"
            Me.cmbTipoPersona.ValueMember = "StbTipoPersonaID"
            Me.cmbTipoPersona.Splits(0).DisplayColumns("StbTipoPersonaID").Visible = False
            Me.cmbTipoPersona.ExtendRightColumn = True
            Me.cmbTipoPersona.SelectedIndex = 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Guardar Datos"
    Private Sub GuardarDatos()
        For Each dr As DataRow In frmStbPersonasEditar.dtPIM.Rows
            If dr("objTipoPersonaID") = Me.cmbTipoPersona.SelectedValue Then
                MsgBox("La clasificación seleccionada ya existe.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If
            If dr("TipoPersona") = "Nacional" Or dr("TipoPersona") = "Extranjero" Then
                frmStbPersonasEditar.dtPIM.Rows.Remove(dr)
                Exit For
            End If
        Next
        frmStbPersonasEditar.dtPIM.Rows.Add(1, Me.cmbTipoPersona.SelectedValue, Me.cmbTipoPersona.SelectedText, clsProyecto.Conexion.FechaServidor)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

#Region "Eventos del Formulario"
    Private Sub frmStbPersonasTipoPersonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CargarComboTipoPersona()
        Me.cmbTipoPersona.Focus()
    End Sub
#End Region

#Region "Eventos de los Botones"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Me.GuardarDatos()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "Eventos de los Controles"
    Private Sub cmbTipoPersona_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoPersona.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.GuardarDatos()
        End If
    End Sub
#End Region



End Class