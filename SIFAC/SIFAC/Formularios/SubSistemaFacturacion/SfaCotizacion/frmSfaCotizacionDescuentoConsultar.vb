'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Enrique Escobar Maradiaga.
''-- Fecha de Elaboración    : 26 Junio 2010.
''-- Formulario de Consulta de Existencia
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
Imports System.Windows.Forms.Cursors

Public Class frmSfaCotizacionDescuentoConsultar

#Region "Variables del formulario"
    Private m_IDRepuesto As String
    Private m_TipoRepuesto As Integer
    Private m_Fecha As String
    Private m_Tienda As String
    Private m_DescuentoSeleccionado As Integer

    Dim dtDescuentoCotizacion As DataTable
    Dim dsDescuentoCotizacion As DataSet
#End Region

#Region "Propiedades"
    Property IDRepuesto() As String
        Get
            IDRepuesto = Me.m_IDRepuesto
        End Get
        Set(ByVal value As String)
            Me.m_IDRepuesto = value
        End Set
    End Property

    Property Fecha() As String
        Get
            Fecha = m_Fecha
        End Get
        Set(ByVal value As String)
            Me.m_Fecha = value
        End Set
    End Property

    Property Tienda() As String
        Get
            Tienda = m_Tienda
        End Get
        Set(ByVal value As String)
            m_Tienda = value
        End Set
    End Property

    Property DescuentoSeleccionado()
        Get
            DescuentoSeleccionado = Me.m_DescuentoSeleccionado
        End Get
        Set(ByVal value)
            Me.m_DescuentoSeleccionado = value
        End Set
    End Property

    Property TipoRepuesto() As Integer
        Get
            TipoRepuesto = Me.m_TipoRepuesto

        End Get
        Set(ByVal value As Integer)
            Me.m_TipoRepuesto = value
        End Set
    End Property

#End Region

#Region "Inicializar Pantalla"

#Region "Inicializar GUI"

#Region "Cargar Grid"

    Private Sub CargarGrid()
        Dim strSQL, strCampos, strFiltro As String
        Try
            strCampos = "Convert(varchar,fechainicio,103) as fechainicio, convert(varchar,fechafin,103) as fechafin, Descuento, PorTipo"
            strFiltro = "CAST(CAST(fechainicio AS VARCHAR(11)) AS DATETIME) <= '" & Fecha & "' AND CAST(CAST(fechafin AS VARCHAR(11)) AS DATETIME) >= '" & Fecha & _
            "' AND objTiendaID= " & Tienda & " AND (objRepuestoID='" & Me.IDRepuesto & "' OR objTipoRepuesto = " & Me.TipoRepuesto.ToString & ")"
            strSQL = ObtenerConsultaGeneral(strCampos, "vwSfaCotizacionDescuento", strFiltro)
            dtDescuentoCotizacion = DAL.SqlHelper.ExecuteQueryDT(strSQL)
            dsDescuentoCotizacion = New DataSet
            dsDescuentoCotizacion.Merge(dtDescuentoCotizacion)
            dsDescuentoCotizacion.Tables(0).TableName = "vwSfaCotizacionDescuento"
            Me.grdDescuentoCotizacion.SetDataBinding(dsDescuentoCotizacion, "vwSfaCotizacionDescuento", True)
            dsDescuentoCotizacion.Tables("vwSfaCotizacionDescuento").DefaultView.Sort = "fechainicio"
            FormatearGrid(grdDescuentoCotizacion, "Maestro")
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
            Grid.Splits(0).DisplayColumns("fechainicio").Locked = True
            Grid.Splits(0).DisplayColumns("fechainicio").Style.BackColor = Color.LemonChiffon
            Grid.Splits(0).DisplayColumns("fechafin").Locked = True
            Grid.Splits(0).DisplayColumns("fechafin").Style.BackColor = Color.LemonChiffon
            Grid.Splits(0).DisplayColumns("Descuento").Locked = True
            Grid.Splits(0).DisplayColumns("Descuento").Style.BackColor = Color.LemonChiffon
            Grid.Splits(0).DisplayColumns("PorTipo").Locked = True
            Grid.Splits(0).DisplayColumns("PorTipo").Style.BackColor = Color.LemonChiffon
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

#End Region

#Region "KeyDown"
    Private Sub frmSfaCotizacionDescuentoConsultar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

    Private Sub grdDescuentoCotizacion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDescuentoCotizacion.DoubleClick
        Me.SeleccionarDescuento()
    End Sub

    Private Sub grdDescuentoCotizacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDescuentoCotizacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SeleccionarDescuento()
        End If
    End Sub

    Private Sub SeleccionarDescuento()
        If Me.grdDescuentoCotizacion.RowCount <> 0 Then
            If Not IsDBNull(Me.grdDescuentoCotizacion.Columns("Descuento").Value) AndAlso Me.grdDescuentoCotizacion.Columns("Descuento").Value.ToString.Trim.Length <> 0 Then
                Me.DescuentoSeleccionado = Me.grdDescuentoCotizacion.Columns("Descuento").Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class