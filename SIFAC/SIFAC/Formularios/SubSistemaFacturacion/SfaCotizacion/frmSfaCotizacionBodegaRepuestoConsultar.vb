'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Enrique Escobar Maradiaga.
''-- Fecha de Elaboración    : 26 Junio 2010.
''-- Formulario de Consulta de Existencia
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SCCUM.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid
Imports System.Windows.Forms.Cursors

Public Class frmSfaCotizacionBodegaRepuestoConsultar

#Region "Variables del formulario"
    Private m_IDRepuesto As String
    Dim dtBodegaRepuesto As DataTable
    Dim dsBodegaRepuesto As DataSet
#End Region

#Region "Propiedades"
    Property IDProducto() As String
        Get
            IDProducto = Me.m_IDRepuesto
        End Get
        Set(ByVal value As String)
            Me.m_IDRepuesto = value
        End Set
    End Property

#End Region

#Region "Inicializar Pantalla"

#Region "Inicializar GUI"

#Region "Cargar Grid"

    Private Sub CargarGrid()
        Try
            dtBodegaRepuesto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Bodega, Ubicacion,Cantidad", "vwSfaCotizacionBodegaRepuesto", "objRepuestoID='" & Me.IDProducto & "'"))
            dsBodegaRepuesto = New DataSet
            dsBodegaRepuesto.Merge(dtBodegaRepuesto)
            dsBodegaRepuesto.Tables(0).TableName = "vwSfaCotizacionBodegaRepuesto"

            Me.grdBodegaRepuesto.SetDataBinding(dsBodegaRepuesto, "vwSfaCotizacionBodegaRepuesto", True)
            dsBodegaRepuesto.Tables("vwSfaCotizacionBodegaRepuesto").DefaultView.Sort = "Bodega"

            FormatearGrid(grdBodegaRepuesto, "Maestro")

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Formatear Grid"

    Private Sub FormatearGrid(ByVal Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal Tipo As String)
        Grid.FilterBar = False
        Grid.VisualStyle = VisualStyle.Office2007Black
        Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedRowBorder

        If (Tipo = "Maestro") Then
            Grid.Splits(0).DisplayColumns("Bodega").Locked = True
            Grid.Splits(0).DisplayColumns("Bodega").Style.BackColor = Color.LemonChiffon
            Grid.Splits(0).DisplayColumns("Ubicacion").Locked = True
            Grid.Splits(0).DisplayColumns("Ubicacion").Style.BackColor = Color.LemonChiffon
            Grid.Splits(0).DisplayColumns("Cantidad").Locked = True
            Grid.Splits(0).DisplayColumns("Cantidad").Style.BackColor = Color.LemonChiffon
            Grid.EmptyRows = False
        End If

    End Sub

#End Region

#End Region

#End Region

#Region "Eventos del formulario"

#Region "Pantalla"

    Private Sub frmSivEntradaBodegaEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarGrid()
    End Sub
#End Region

#Region "KeyDown"
    Private Sub frmSfaCotizacionBodegaRepuestoConsultar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

#End Region

   
End Class