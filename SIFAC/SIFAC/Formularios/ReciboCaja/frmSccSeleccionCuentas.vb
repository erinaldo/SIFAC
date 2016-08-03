Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO
Imports System.Data
Imports Proyecto.Catalogos.Datos

''' <summary>
''' Formulario de Selección de Cuentas para Generacion de Recibos de Cajas.
''' Autor : Pedro Pablo Tinoco Salgado.
''' Fecha : 24 de Marzo de 2009.
''' </summary>
''' <remarks></remarks>
Public Class frmSccSeleccionCuentas
    Dim DtDatosCuentas As New DataTable
    Dim m_SccCuentaID As String
    Dim m_Cliente As String
    Dim m_CodigoTienda As String
    Dim m_IDTienda As Integer
    Dim m_MontoPrima
    Dim m_TasaCambio As Decimal
    Dim m_LimiteCredito As Decimal
    
#Region "Propiedades"

    Property LimiteCredito() As Decimal
        Get
            LimiteCredito = Me.m_LimiteCredito
        End Get
        Set(ByVal value As Decimal)
            Me.m_LimiteCredito = value
        End Set
    End Property

    Property SccCuentaID() As String
        Get
            SccCuentaID = m_SccCuentaID
        End Get
        Set(ByVal value As String)
            m_SccCuentaID = value
        End Set
    End Property

    Property Cliente() As String
        Get
            Cliente = m_Cliente
        End Get
        Set(ByVal value As String)
            m_Cliente = value
        End Set
    End Property

    Property CodigoTienda() As String
        Get
            CodigoTienda = m_CodigoTienda
        End Get
        Set(ByVal value As String)
            m_CodigoTienda = value
        End Set
    End Property

    Property IDTienda() As Integer
        Get
            IDTienda = m_IDTienda
        End Get
        Set(ByVal value As Integer)
            m_IDTienda = value
        End Set
    End Property

    Property MontoPrima() As Decimal
        Get
            MontoPrima = m_MontoPrima
        End Get
        Set(ByVal value As Decimal)
            m_MontoPrima = value
        End Set
    End Property
    Property TasaCambio() As Decimal
        Get
            TasaCambio = m_TasaCambio
        End Get
        Set(ByVal value As Decimal)
            m_TasaCambio = value
        End Set
    End Property
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Procedimiento de Carga Total de las cuentas en Estado Diferente a Cancelada.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 24 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Dim strConsulta As String = ""
        Try
            strConsulta = clsConsultas.ObtenerConsultaGeneral("Cast(0 as Bit) as Seleccion,StbTiendaID,SccCuentaID,Tienda,Cliente,CodigoTienda,StbPersonaID,LimiteCredito", "vwSccCuentasSeleccion", "Codigo<> 'CANCELADO' AND Codigo <> 'DEVOLUCION'")
            Me.DtDatosCuentas = SqlHelper.ExecuteQueryDT(strConsulta)
            Me.grdSeleccion.SetDataBinding(Me.DtDatosCuentas, "", True)
            Me.grdSeleccion.Splits(0).DisplayColumns("CodigoTienda").Visible = False
            Me.grdSeleccion.Splits(0).DisplayColumns("StbTiendaID").Visible = False
            Me.grdSeleccion.Splits(0).DisplayColumns("LimiteCredito").Visible = False
            Me.grdSeleccion.ExtendRightColumn = True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmSccSeleccionCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarDatos()
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim objCant As New Object
        Dim DtDatos(1) As DataRow
        Try            
            objCant = Me.DtDatosCuentas.Compute("Count(Seleccion)", "Seleccion= 1")
            If objCant = 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.None
            Else
                DtDatos = Me.DtDatosCuentas.Select("Seleccion=1")
                ''  Me.DtDatosCuentas.DefaultView.RowFilter = "Seleccion = 1"
                Me.SccCuentaID = DtDatos(0)("SccCuentaID")
                Me.CodigoTienda = DtDatos(0)("CodigoTienda")
                Me.Cliente = DtDatos(0)("Cliente")
                Me.IDTienda = DtDatos(0)("StbTiendaID")
                Me.LimiteCredito = DtDatos(0)("LimiteCredito")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region



    Private Sub grdSeleccion_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdSeleccion.AfterColUpdate
        Dim obj As New Object
        Try
            If e.Column.Name = "Selección" Then
                obj = Me.DtDatosCuentas.Compute("Count(Seleccion)", "Seleccion=1")
                If obj > 0 Then
                    Me.DtDatosCuentas.DefaultView.Item(Me.grdSeleccion.RowBookmark(Me.grdSeleccion.Row))("Seleccion") = False
                    Me.DtDatosCuentas.AcceptChanges()
                End If
            End If
        Finally
            obj = Nothing
        End Try
    End Sub
End Class