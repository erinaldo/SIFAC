'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 25 Mayo 2010. 03:27 PM.
''-- Formulario para la búsqueda de repuestos 
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles

Public Class frmBusquedaRepuestos

#Region "Atributos"
    Private m_TypeGui As Integer
    Private m_objRepuestoId_Seleccionado As Integer
    Private m_strFiltro As String = "1=0"

    Private dtDatosResultado As DataTable
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            TypeGui = Me.m_TypeGui
        End Get
        Set(ByVal value As Integer)
            Me.m_TypeGui = value
        End Set
    End Property

    Property objRepuestoIdSeleccionado()
        Get
            objRepuestoIdSeleccionado = Me.m_objRepuestoId_Seleccionado
        End Get
        Set(ByVal value)
            Me.m_objRepuestoId_Seleccionado = value
        End Set
    End Property

    Property strFiltro() As String
        Get
            Return m_strFiltro
        End Get
        Set(ByVal value As String)
            m_strFiltro = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Cargar datos"
    Private Sub CargarDatos(ByVal sFiltro As String)
        Dim sSQL, sCampos As String

        If String.IsNullOrEmpty(sFiltro) Then
            sFiltro = "1=0"
        End If

        sCampos = "DISTINCT Cast(0 AS BIT) AS Seleccionar, SivRepuestoID, Descripcion, objMarcaID, Marca, objTipoRepuesto, TipoRepuesto, ModelosCompatibles"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivRepuestoBusqueda", sFiltro)

        Me.dtDatosResultado = SqlHelper.ExecuteQueryDT(sSQL)
        With Me.grdResultados
            .SetDataBinding(Me.dtDatosResultado, "", True)
            .Splits(0).DisplayColumns("objMarcaID").Visible = False
            .Splits(0).DisplayColumns("objTipoRepuesto").Visible = False
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
            '.FilterBar = False
            .EmptyRows = False
            .Text = " Repuestos (" + Me.dtDatosResultado.Rows.Count.ToString + ")"
            .Refresh()
        End With
    End Sub
#End Region

#Region "Contruir filtro"

    Private Function ConstruirFiltro() As String
        Dim sFiltro As String = String.Empty

        If Me.cmbProveedor.SelectedValue <> 0 Then
            sFiltro = " objProveedorID=" + Me.cmbProveedor.SelectedValue.ToString
        End If

        If Me.cmbTipo.SelectedValue <> 0 Then
            If Not String.IsNullOrEmpty(sFiltro) Then
                sFiltro = sFiltro + " AND objTipoRepuesto = " + Me.cmbTipo.SelectedValue.ToString
            Else
                sFiltro = " objTipoRepuesto = " + Me.cmbTipo.SelectedValue.ToString
            End If
        End If

        If Me.cmbMarca.SelectedValue <> 0 Then
            If Not String.IsNullOrEmpty(sFiltro) Then
                sFiltro = sFiltro + " AND objMarcaID = " + Me.cmbMarca.SelectedValue.ToString
            Else
                sFiltro = " objMarcaID = " + Me.cmbMarca.SelectedValue.ToString
            End If
        End If

        If Me.cmbModeloCompatible.SelectedValue <> 0 Then
            If Not String.IsNullOrEmpty(sFiltro) Then
                sFiltro = sFiltro + " AND SivRepuestoID IN (SELECT objRepuestoID FROM dbo.SivRepuestosDetCompat WHERE objProductoID=" + Me.cmbModeloCompatible.SelectedValue.ToString + ")"
            Else
                sFiltro = "SivRepuestoID IN (SELECT objRepuestoID FROM dbo.SivRepuestosDetCompat WHERE objProductoID=" + Me.cmbModeloCompatible.SelectedValue.ToString + ")"
            End If
        End If

        If String.IsNullOrEmpty(sFiltro) Then
            sFiltro = "1=1"
        End If

        If Not String.IsNullOrEmpty(m_strFiltro) Then
            sFiltro = sFiltro & " AND " & m_strFiltro
        End If
        Return sFiltro
    End Function
#End Region

#End Region

#Region "Eventos controles"
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Me.CargarRepuestoSeleccionado()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub grdResultados_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdResultados.AfterColUpdate
        Try
            If e.Column.Name = "Seleccionar" Then
                If Me.dtDatosResultado.Compute("COUNT(Seleccionar)", "Seleccionar=1") > 0 Then
                    Me.dtDatosResultado.Rows(Me.grdResultados.RowBookmark(Me.grdResultados.Row))("Seleccionar") = False
                    Me.grdResultados.UpdateData()
                End If
            End If
        Finally
        End Try
    End Sub

    Private Sub frmBusquedaRepuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarComboProveedores()
        Me.CargarComboMarcas()
        Me.CargarComboModelosCompatibles()
        Me.CargarComboTipos()
        Me.CargarDatos(Me.strFiltro)
    End Sub

    Private Sub cmdFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFiltrar.Click
        Me.CargarDatos(Me.ConstruirFiltro)
    End Sub

    Private Sub grdResultados_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdResultados.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.grdResultados.UpdateData()
            Me.CargarRepuestoSeleccionado()
        End If
    End Sub

    Private Sub grdResultados_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdResultados.Enter
        Me.SetFocusGridResultados()
    End Sub

    Private Sub frmBusquedaRepuestos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmBusquedaRepuestos_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.SetFocusGridResultados()
    End Sub

    Private Sub SetFocusGridResultados()
        Me.grdResultados.Focus()
        Me.grdResultados.Col = 0
        Me.grdResultados.Row = 0
    End Sub

#End Region

#Region "Cargar Combos"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Proveedores
    ''' Autor : Gelmin Martinez
    ''' Fecha 25 de Mayo de 2010, 03:56 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboProveedores()
        Dim dtDatos As New DataTable
        Dim sCampos, sFiltro, sSQL As String

        sFiltro = "Activo = 1 ORDER BY Nombre1 "
        sCampos = "SivProveedorID, (ISNULL(Nombre1,'')) + ' ' + (ISNULL(Nombre2,''))+' '+ (ISNULL(Apellido1,''))+' '+(ISNULL(Apellido2,'')) AS NombreProveedor"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivProveedores", sFiltro)
        Try
            dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

            With Me.cmbProveedor
                .DataSource = dtDatos
                .DisplayMember = "NombreProveedor"
                .ValueMember = "SivProveedorID"
                .Splits(0).DisplayColumns("SivProveedorID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
            dtDatos.Rows.Add("0", "TODOS")
            Me.cmbProveedor.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Tipos de repuesto.
    ''' Autor : Gelmin Martinez
    ''' Fecha 25 de Mayo de 2010, 04:36 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboTipos()
        Dim dtDatos As New DataTable
        Dim sCampos, sFiltro, sSQL As String
        sFiltro = " Nombre = 'TIPOREPUESTO' AND Activo = 1 ORDER BY Descripcion "

        sCampos = "StbValorCatalogoID, Descripcion"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwStbCatValores", sFiltro)
        Try
            dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

            With Me.cmbTipo
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
            dtDatos.Rows.Add("0", "TODOS")
            Me.cmbTipo.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Marcas de repuestos.
    ''' Autor : Gelmin Martinez
    ''' Fecha 25 de Mayo de 2010, 04:42 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboMarcas()
        Dim dtDatos As New DataTable
        Dim sCampos, sFiltro, sSQL As String
        sFiltro = " Nombre = 'MARCAREPUESTO' AND Activo = 1 ORDER BY Descripcion "

        sCampos = "StbValorCatalogoID, Descripcion"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwStbCatValores", sFiltro)
        Try
            dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

            With Me.cmbMarca
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
            dtDatos.Rows.Add("0", "TODOS")
            Me.cmbMarca.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Modelos compatibles.
    ''' Autor : Gelmin Martinez
    ''' Fecha 25 de Mayo de 2010, 04:43 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboModelosCompatibles()
        Dim dtDatos As New DataTable
        Dim sCampos, sFiltro, sSQL As String
        sFiltro = "Activo = 1 ORDER BY Modelo "

        sCampos = "SivProductoID, Modelo"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SivProductos", sFiltro)
        Try
            dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

            With Me.cmbModeloCompatible
                .DataSource = dtDatos
                .DisplayMember = "Modelo"
                .ValueMember = "SivProductoID"
                .Splits(0).DisplayColumns("SivProductoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
            dtDatos.Rows.Add("0", "TODOS")
            Me.cmbModeloCompatible.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar Repuesto Seleccionado"
    Private Sub CargarRepuestoSeleccionado()
        Dim objRepuestoID As New Object
        Dim Cantidad As New Object

        Cantidad = Me.dtDatosResultado.Compute("Count(Seleccionar)", "Seleccionar=1")
        If Cantidad = 0 Then
            Exit Sub
        End If
        objRepuestoID = Me.dtDatosResultado.Select("Seleccionar = 1")(0)("SivRepuestoID")
        If Not IsDBNull(objRepuestoID) Then
            Me.objRepuestoIdSeleccionado = objRepuestoID
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
    End Sub
#End Region

End Class