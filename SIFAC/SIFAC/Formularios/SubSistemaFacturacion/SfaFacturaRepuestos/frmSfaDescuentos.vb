'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Milagros Ruiz Oporta
''-- Fecha de Elaboración    : 24 Junio 2010.
''-- Formulario de Consulta de Descuentos de Repuestos
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SIFAC.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid

Public Class frmSfaDescuentos

#Region "Variables miembro"
    Dim dtDescuento As DataTable
    Dim m_intCodigo As Integer
    Dim m_dblDescuento As Double
#End Region

#Region "Propiedades"

    Property intCodigo() As Integer
        Get
            Return m_intCodigo
        End Get
        Set(ByVal value As Integer)
            m_intCodigo = value
        End Set
    End Property

    Property Descuento() As Double
        Get
            Return m_dblDescuento
        End Get
        Set(ByVal value As Double)
            m_dblDescuento = value
        End Set
    End Property

#End Region

#Region "Inicializar GUI"
    Private Sub CargarDescuentos()
        dtDescuento = New DataTable
        Try
            Try
                dtDescuento = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID, fechainicio, fechafin, promocionglobal, Descuento", "vwSfaDescuentosFactura", "objRepuestoID = " & Me.intCodigo & " AND fechafin >= GETDATE()"))
                Me.grdDescuentos.SetDataBinding(dtDescuento, "", True)
                Me.grdDescuentos.MarqueeStyle = MarqueeEnum.FloatingEditor
                Me.grdDescuentos.FilterBar = False
                Me.grdDescuentos.EmptyRows = False
                Me.grdDescuentos.Refresh()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDescuento = Nothing
        End Try
    End Sub
#End Region

    Private Sub frmSfaDescuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarDescuentos()
        Me.grdDescuentos.Splits(0).DisplayColumns(4).Visible = False
    End Sub

    Private Sub grdDescuentos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDescuentos.DoubleClick
        Me.intCodigo = Me.grdDescuentos.Columns("objRepuestoID").Value
        Me.m_dblDescuento = Me.grdDescuentos.Columns("Descuento").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmSfaDescuentos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class