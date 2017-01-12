Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmDetalleComision

#Region "Declaracion de Variables"
    Public dtDetallecomision As DataTable
   #End Region

#Region "Propiedades"

    Property Detallecomision() As DataTable
        Get
            Return dtDetallecomision
        End Get
        Set(ByVal value As DataTable)
            dtDetallecomision = value
        End Set
    End Property

#End Region

#Region "Eventos del formulario"
    Private Sub frmDetalleComision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            grdDetalle.DataSource = Detallecomision
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

#End Region
   
   
End Class