Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSfaBusquedaCliente
#Region "Variables del formulario"
    Public strFiltro, strSeleccion As String
    Public intOpcion As Integer
    Public DtPersonas As DataTable
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

    Public Property Seleccion() As String
        Get
            Return strSeleccion
        End Get
        Set(ByVal value As String)
            strSeleccion = value
        End Set
    End Property

    Public Property Opcion() As Integer
        Get
            Return intOpcion
        End Get
        Set(ByVal value As Integer)
            intOpcion = value
        End Set
    End Property
#End Region

    Private Sub CargarDatos()
        Dim strSQL As String

        If String.IsNullOrEmpty(Me.Filtro) Then
            strSQL = ObtenerConsultaGeneral("Distinct Cast(0 as bit) as Seleccion, Cedula,Exonerado, StbPersonaID, NombreCompleto", "vwSfaClienteFactura")
        Else
            strSQL = ObtenerConsultaGeneral("Distinct Cast(0 as bit) as Seleccion, StbPersonaID,Cedula,Exonerado, NombreCompleto", "vwSfaClienteFactura", Filtro)
        End If
        DtPersonas = DAL.SqlHelper.ExecuteQueryDT(strSQL)
        DtPersonas.DefaultView.Sort = "NombreCompleto"
        Me.grdCliente.SetDataBinding(DtPersonas, "", True)
        Me.grdCliente.Text = "Cliente (" & DtPersonas.Rows.Count & ")"

        Me.grdCliente.Refresh()
    End Sub
    Private Sub frmSfaBusquedaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarDatos()
    End Sub
    Private Function CantidadCheck() As Integer
        Dim Contador As Integer
        Try
            Contador = 0
            For Each dr As DataRow In DtPersonas.Rows
                If dr("Seleccion") = True Then
                    Contador += 1
                End If
            Next
            Return Contador
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Sub grdCliente_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdCliente.AfterColUpdate
        Try
            If e.ColIndex = 0 Then
                If CantidadCheck() > 1 Then
                    DtPersonas.DefaultView(Me.grdCliente.Row)(e.ColIndex) = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdNuevaPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaPersona.Click
        Dim objPers As frmStbPersonasEditar
        objPers = New frmStbPersonasEditar
        objPers.TyGui = 1
        objPers.frmLlamado = Opcion
        If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.Seleccion = objPers.idpersona
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim objPersonaID As New Object
        Dim Cantidad As New Object

        Cantidad = Me.DtPersonas.Compute("Count(Seleccion)", "Seleccion=1")
        If Cantidad = 0 Then
            Exit Sub
        End If
        objPersonaID = Me.DtPersonas.Select("Seleccion = 1")(0)("StbPersonaID")
        If Not IsDBNull(objPersonaID) Then
            Seleccion = objPersonaID
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
    End Sub
End Class