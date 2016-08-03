Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSfaBusquedaCotizacion

#Region "Variables del formulario"
    Public strSeleccion As String
    Public intOpcion As Integer
    Public DtCotizaciones As DataTable

    Private m_strFiltroCotizaciones As String
#End Region

#Region "Propiedades"

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

    Public Property StrFiltroCotizaciones() As String
        Get
            StrFiltroCotizaciones = Me.m_strFiltroCotizaciones
        End Get
        Set(ByVal value As String)
            Me.m_strFiltroCotizaciones = value
        End Set
    End Property

#End Region

    Private Sub CargarDatos()
        Dim strSQL As String

        If Not String.IsNullOrEmpty(Me.StrFiltroCotizaciones) Then
            Me.StrFiltroCotizaciones += " AND FechaVence>=GETDATE() "
        Else
            Me.StrFiltroCotizaciones += " FechaVence>=GETDATE() "
        End If

        strSQL = ObtenerConsultaGeneral("cast(0 as bit) as Seleccion, SfaCotizacionID, FormatoNumero, Fecha, Sucursal, Cliente, AtencionA, Vendedor, TotalDolares, Valido, Anulada, objClienteID, objVendedorID, CodigoTienda, FechaVence, objTiendaID", "vwSfaFacturaCotizacion", Me.StrFiltroCotizaciones)
        DtCotizaciones = DAL.SqlHelper.ExecuteQueryDT(strSQL)
        DtCotizaciones.DefaultView.Sort = "SfaCotizacionID"
        Me.grdCotizaciones.SetDataBinding(DtCotizaciones, "", True)
        Me.grdCotizaciones.Text = "Cotizaciones (" & DtCotizaciones.Rows.Count & ")"
        Me.grdCotizaciones.EmptyRows = False
        Me.grdCotizaciones.Refresh()
    End Sub

    Private Sub frmSfaBusquedaCotizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarDatos()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Function CantidadCheck() As Integer
        Dim Contador As Integer
        Try
            Contador = 0
            For Each dr As DataRow In DtCotizaciones.Rows
                If dr("Seleccion") = True Then
                    Contador += 1
                End If
            Next
            Return Contador
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Sub grdCotizaciones_AfterColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdCotizaciones.AfterColEdit
        Try
            If e.ColIndex = 0 Then
                If CantidadCheck() > 1 Then
                    DtCotizaciones.DefaultView(Me.grdCotizaciones.Row)(e.ColIndex) = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim objCotizacionID As New Object
        Dim Cantidad As New Object

        Cantidad = Me.DtCotizaciones.Compute("Count(Seleccion)", "Seleccion=1")
        If Cantidad = 0 Then
            Exit Sub
        End If
        objCotizacionID = Me.DtCotizaciones.Select("Seleccion = 1")(0)("SfaCotizacionID")
        If Not IsDBNull(objCotizacionID) Then
            Seleccion = objCotizacionID
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
    End Sub

End Class