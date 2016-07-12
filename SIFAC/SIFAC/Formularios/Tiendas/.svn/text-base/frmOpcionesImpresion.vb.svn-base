Imports Proyecto.Configuracion
Public Class frmOpcionesImpresion
    Public intSeleccion As Integer

    Public Property Seleccion() As Integer
        Get
            Return intSeleccion
        End Get
        Set(ByVal value As Integer)
            intSeleccion = value
        End Set
    End Property

    Private Sub frmOpcionesImpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.rbPantalla.Checked Then
            Seleccion = 1
        ElseIf Me.rbimpresora.Checked Then
            Seleccion = 2
        ElseIf Me.rbArchivo.Checked Then
            Seleccion = 3
        Else
            Seleccion = 0
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class