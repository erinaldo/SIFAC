Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient

Public Class frmStbPersonaBuscar
#Region "Variables del formulario"
    Dim dtTipoPersona, dtGenero As DataTable
    Dim strFiltro As String
#End Region

#Region "Propiedades"
    Public Property Filtro() As String
        Get
            Return strFiltro
        End Get
        Set(ByVal value As String)
            strFiltro = value
        End Set
    End Property
#End Region

#Region "Procedimientos"
    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  18/03/2009
    '' Descripción:        Procedimiento encargado de cargar la informacion de los tipos de personas
    Public Sub CargarTipoPersona()
        dtTipoPersona = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("StbTipoPersonaID,Descripcion", "StbTipoPersona", "StbTipoPersonaID IN (1,2)"))
        With cmbTipoPersona
            .DataSource = dtTipoPersona
            .DisplayMember = "Descripcion"
            .ValueMember = "StbTipoPersonaID"
            .Splits(0).DisplayColumns("StbTipoPersonaID").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  18/03/2009
    '' Descripción:        Procedimiento encargado de cargar la informacion de genero
    Public Sub CargarGenero()
        dtGenero = Proyecto.Catalogos.Datos.ClsCatalogos.ObtenerValCat("GENERO")
        With cmbGenero
            .DataSource = dtGenero
            .DisplayMember = "Descripcion"
            .ValueMember = "StbValorCatalogoID"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .Splits(0).DisplayColumns("Codigo").Visible = False
            .Splits(0).DisplayColumns("Activo").Visible = False
            .ExtendRightColumn = True
        End With

    End Sub
#End Region

#Region "Eventos del formulario"
    Private Sub frmStbPersonaBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarTipoPersona()
        CargarGenero()
    End Sub

    Private Sub chkCedula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCedula.CheckedChanged
        If chkCedula.Checked Then
            cmbGenero.Enabled = False
            cmbTipoPersona.Enabled = False
        Else
            cmbGenero.Enabled = True
            cmbTipoPersona.Enabled = True
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If chkCedula.Checked Then
            Filtro = ""
            Filtro = "Cedula = '" & txtCedula.Text & "'"
        Else
            Filtro = ""
            If cmbTipoPersona.Text.Trim.Length <> 0 Then
                If Filtro = "" Then
                    Filtro = "Nacionalidad = '" & cmbTipoPersona.SelectedText & "'"
                Else
                    Filtro = Filtro + " AND " & "Nacionalidad = '" & cmbTipoPersona.SelectedText & "'"
                End If

            End If
            If cmbGenero.Text.Trim.Length <> 0 Then
                If Filtro.Trim.Length <> 0 Then
                    Filtro &= " AND objGeneroID = " & cmbGenero.SelectedValue
                Else
                    Filtro = "objGeneroID = " & cmbGenero.SelectedValue
                End If
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region


End Class