Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO

Public Class frmVisorCedula

    Public bCedulaAnverso(), bCedulaReverso() As Byte


    Public Property CedulaAnverso() As Byte()
        Get
            Return bCedulaAnverso
        End Get
        Set(ByVal value() As Byte)
            bCedulaAnverso = value
        End Set
    End Property

    Public Property CedulaReverso() As Byte()
        Get
            Return bCedulaReverso
        End Get
        Set(ByVal value() As Byte)
            bCedulaReverso = value
        End Set
    End Property


    Public Shared Function BytesImagen(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

    Private Sub frmVisorCedula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.imgCedulaAnverso.Image = BytesImagen(CedulaAnverso)
        Me.imgCedulaReverso.Image = BytesImagen(CedulaReverso)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Close()
    End Sub
End Class