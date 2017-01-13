﻿Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmReubicarClientes

#Region "Declaración de Variables propias del formulario"
    Private dtCliente As DataTable
    Private intRutaID As Integer
    Private StrRuta As String
#End Region

#Region "Propiedades"

    Property NombreRuta() As String
        Get
            Return StrRuta
        End Get
        Set(ByVal value As String)
            StrRuta = value
        End Set
    End Property

    Property RutaID() As Integer
        Get
            Return intRutaID
        End Get
        Set(ByVal value As Integer)
            intRutaID = value
        End Set
    End Property
#End Region

#Region "Cargar Grid Clietnes"
    Private Sub CargarGridClientes()

        Try
            Me.dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar, Cliente, Cedula,  cast(ClienteID as int) as ClienteID, Ruta, StbRutaID", "vwSccClientesRutas", "StbRutaID=" & RutaID))
            If Not dtCliente Is Nothing Then
                dtCliente.PrimaryKey = New DataColumn() {Me.dtCliente.Columns("ClienteID")}
                Me.dtCliente.DefaultView.Sort = "ClienteID"
                Me.grdClientes.DataSource = dtCliente
            End If

            Me.txtRuta.Text = NombreRuta
            If Me.dtCliente.DefaultView.Count = 0 Then
                Me.cmdReubicar.Enabled = False
            Else
                cmdReubicar.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Eventos del formulario"
    Private Sub frmReubicarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor
            Me.CargarGridClientes()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub

    Private Sub cmdReubicar_Click(sender As Object, e As EventArgs) Handles cmdReubicar.Click
        Dim objfrmCambiarRuta As frmCambioRuta
        Try
            objfrmCambiarRuta = New frmCambioRuta
            objfrmCambiarRuta.DatadtClientes = dtCliente.Copy()

            If objfrmCambiarRuta.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.CargarGridClientes()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objfrmCambiarRuta = Nothing
        End Try
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        Dim FilaActual As Integer
        FilaActual = Me.grdClientesTable.FocusedRowHandle

        Dim objConsultas As clsConsultas
        objConsultas = New clsConsultas

        Dim blnSeleccionar As Boolean
      
        blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked
        dtCliente = objConsultas.actualizarColumnaDT(dtCliente, "ClienteID", CInt(dtCliente.Rows(FilaActual)("ClienteID")), "Seleccionar", blnSeleccionar)

    End Sub
#End Region
    
   
   
   
End Class