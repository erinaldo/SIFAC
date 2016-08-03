Imports DAL
Imports Proyecto
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Public Class frmStbTiendaContactos

#Region "Propiedades"
    Dim intTiendaID As Integer

    Public Property TiendaID() As Integer
        Get
            Return intTiendaID
        End Get
        Set(ByVal value As Integer)
            intTiendaID = value
        End Set
    End Property
#End Region

    Public Sub CargarContactos()
        Me.grdTiendaContactos.SetDataBinding(frmStbEditTiendas.DtContactos, "", True)
        Me.grdTiendaContactos.Caption = "Contactos (" & frmStbEditTiendas.DtContactos.Rows.Count & ")"
        Me.grdTiendaContactos.Refresh()
    End Sub

    Private Sub frmStbTiendaContactos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarContactos()
        If frmStbEditTiendas.DtContactos.Rows.Count > 0 Then
            Me.cmdEditar.Enabled = True
            Me.cmdEliminar.Enabled = True
        End If
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim objContactos As frmStbPersonasContactos
        objContactos = New frmStbPersonasContactos
        objContactos.frmLLamado = 1
        objContactos.TypeGui = 0
        objContactos.ShowDialog()
        If frmStbEditTiendas.DtContactos.Rows.Count > 0 Then
            Me.cmdEditar.Enabled = True
            Me.cmdEliminar.Enabled = True
        End If
        Me.grdTiendaContactos.Caption = "Contactos (" & frmStbEditTiendas.DtContactos.Rows.Count & ")"
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
            frmStbEditTiendas.DtContactos.Rows.RemoveAt(Me.grdTiendaContactos.Row)
        Else
            Exit Sub
        End If
        If frmStbEditTiendas.DtContactos.Rows.Count = 0 Then
            Me.cmdEditar.Enabled = False
            Me.cmdEliminar.Enabled = False
        End If
        Me.grdTiendaContactos.Caption = "Contactos (" & frmStbEditTiendas.DtContactos.Rows.Count & ")"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim objContactos As frmStbPersonasContactos
        objContactos = New frmStbPersonasContactos
        objContactos.frmLLamado = 1
        objContactos.TypeGui = 1
        objContactos.StbTienda = Me.grdTiendaContactos.Columns("StbTiendaID").Value
        objContactos.SecuencialContacto = Me.grdTiendaContactos.Columns("SecuencialContacto").Value
        objContactos.objTipoEntrada = Me.grdTiendaContactos.Columns("objTipoEntradaID").Value
        objContactos.ShowDialog()
        Me.grdTiendaContactos.Caption = "Contactos (" & frmStbEditTiendas.DtContactos.Rows.Count & ")"
    End Sub

    Private Sub mnuAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAgregar.Click
        Me.cmdAgregar_Click(sender, e)
    End Sub

    Private Sub mnuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar.Click
        Me.cmdEditar_Click(sender, e)
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Me.cmdEliminar_Click(sender, e)
    End Sub

    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
        Me.cmdSalir_Click(sender, e)
    End Sub
End Class