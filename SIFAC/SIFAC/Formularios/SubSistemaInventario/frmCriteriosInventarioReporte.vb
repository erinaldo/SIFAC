'Autor: Gelmin Martínez
'Fecha: 11 Junio 2010,03:54 pm.
'Ventana de criterios para el reporte de INVENTARIO

Imports DAL
Imports SIFAC.BO 'Uso de clsConsultas
Imports Proyecto.Configuracion 'uso de clsProyecto
Imports Proyecto.Catalogos.Datos 'uso de clsCatalogos

Public Class frmCriteriosInventarioReporte

#Region "Atributos"
    Private m_IdSucursalSession As Integer
    Private m_IdSucursalCentral As Integer
    Private m_TipoSeleccion As Integer
#End Region

#Region "Propiedades"
    Property IdSucursalSession() As Integer
        Get
            IdSucursalSession = Me.m_IdSucursalSession
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalSession = value
        End Set
    End Property

    Property IdSucursalCentral() As Integer
        Get
            IdSucursalCentral = Me.m_IdSucursalCentral
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalCentral = value
        End Set
    End Property

    Property TipoSeleccion() As Integer
        Get
            TipoSeleccion = Me.m_TipoSeleccion
        End Get
        Set(ByVal value As Integer)
            Me.m_TipoSeleccion = value
        End Set
    End Property

#End Region

#Region "Constantes"
    Private Const BODEGA = 1
    Private Const REPUESTO = 2
    Private Const TIPOREPUESTO = 3
    Private Const BODEGA_REPUESTO = 4
    Private Const BODEGA_TIPOREPUESTO = 5
    Private Const REPUESTO_TIPOREPUESTO = 6
    Private Const BODEGA_REPUESTO_TIPOREPUESTO = 7
#End Region

#Region "Cargar combo"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Bodegas
    ''' Autor : Gelmin Martinez
    ''' Fecha 11 de Junio de 2010, 03:55 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboBodegas()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("ActivoRepuesto=1", "Nombre", "StbTiendaID, Nombre")
            With Me.cmbBodegas
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("StbTiendaID").Width = 30
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtDatos.Rows.Add("0", "TODAS")
            Me.cmbBodegas.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Repuestos
    ''' Autor : Gelmin Martinez
    ''' Fecha 11 de Junio de 2010, 03:56 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboRepuestos()
        Dim dtDatos As New DataTable
        Try
            dtDatos = SivRepuestos.RetrieveDT("1=1", "DescripcionCorta", "SivRepuestoID, DescripcionCorta")
            With Me.cmbRepuestos
                .DataSource = dtDatos
                .DisplayMember = "DescripcionCorta"
                .ValueMember = "SivRepuestoID"
                '.Splits(0).DisplayColumns("SivRepuestoID").Visible = False
                .Splits(0).DisplayColumns("SivRepuestoID").Width = 40
                .Columns("DescripcionCorta").Caption = "Descripción"
                .Columns("SivRepuestoID").Caption = "Código"
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtDatos.Rows.Add("0", "TODOS")
            Me.cmbRepuestos.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Tipo repuestos
    ''' Autor : Gelmin Martinez
    ''' Fecha 11 de Junio de 2010, 03:56 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboTipoRepuestos()
        Dim dtDatos As New DataTable
        Try
            dtDatos = ClsCatalogos.GetValoresCatalogo("TIPOREPUESTO", "StbValorCatalogoID,Descripcion", "Descripcion")
            With Me.cmbTipoRepuestos
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtDatos.Rows.Add("0", "TODOS")
            Me.cmbTipoRepuestos.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar Formulario"
    Private Sub frmCriteriosInventarioReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarComboBodegas()
        Me.CargarComboRepuestos()
        Me.CargarComboTipoRepuestos()

    End Sub
#End Region

#Region "Eventos de los controles"
    Private Sub chkBodega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBodega.CheckedChanged
        Me.cmbBodegas.Enabled = Me.chkBodega.Checked
        If Not Me.chkBodega.Checked Then
            Me.cmbBodegas.SelectedValue = 0
        End If
    End Sub

    Private Sub chkRepuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRepuesto.CheckedChanged
        Me.cmbRepuestos.Enabled = Me.chkRepuesto.Checked
        If Not Me.chkRepuesto.Checked Then
            Me.cmbRepuestos.SelectedValue = 0
        End If
    End Sub

    Private Sub chkTipoRepuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTipoRepuesto.CheckedChanged
        Me.cmbTipoRepuestos.Enabled = Me.chkTipoRepuesto.Checked
        If Not Me.chkTipoRepuesto.Checked Then
            Me.cmbTipoRepuestos.SelectedValue = 0
        End If
    End Sub

    Private Sub chkLevInventario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLevInventario.CheckedChanged
        'Dim blnValor As Boolean = False

        If Me.chkLevInventario.Checked Then
            Me.chkRepuesto.Enabled = False
            Me.chkRepuesto.Checked = False

            Me.chkTipoRepuesto.Enabled = False
            Me.chkTipoRepuesto.Checked = False

            Me.chkCostos.Enabled = False
            Me.chkCostos.Checked = False

            Me.chkPrecios.Enabled = False
            Me.chkPrecios.Checked = False

            Me.cmbRepuestos.Enabled = False
            Me.cmbTipoRepuestos.Enabled = False
        Else
            Me.chkRepuesto.Enabled = True
            Me.chkTipoRepuesto.Enabled = True
            Me.chkCostos.Enabled = True
            Me.chkPrecios.Enabled = True
            'Me.cmbRepuestos.Enabled = True
            'Me.cmbTipoRepuestos.Enabled = True
        End If
        
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.VerificarCriterios Then
            If Not Me.chkLevInventario.Checked Then
                Imprimir_Reporte(ConstruirFiltro)
            Else
                Imprimir_ReporteLevantamientoInv()
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

#End Region

#Region "Verificar Criterios"
    Private Function VerificarCriterios() As Boolean
        Dim blnValido As Boolean = False

        If (Me.chkBodega.Checked Or Me.chkRepuesto.Checked Or Me.chkTipoRepuesto.Checked Or Me.chkLevInventario.Checked) Then
            blnValido = True
        Else
            MsgBox("No ha seleccionado un criterio para generar el reporte.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            blnValido = False
            Exit Function
        End If
        Return blnValido

    End Function
#End Region

#Region "Imprimir Reporte"
    Private Sub Imprimir_Reporte(Optional ByVal sFiltro As String = "1=1")
        Dim objRptInventario As rptInventarioReporte
        Dim objRptInventarioRepuesto As rptInventarioReporteRepuesto
        Dim objRptInventarioBodega As rptInventarioReporteBodegas
        Dim sSQL, sCampos As String
        Dim strReporteMostrar As String = String.Empty
        Dim dtDatos As DataTable
        sCampos = "*"

        'Campos cuando solamente se ha seleccionado [Bodega]
        If Me.TipoSeleccion = BODEGA Then
            sCampos = "SivRepuestoID, Descripcion, Marca, Ubicacion, Existencia, " + _
                      "CostoU, TotalCosto, PrecioU, TotalPrecio, NombreBodegaConCodigo, objTiendaID"
            If String.IsNullOrEmpty(sFiltro) Then
                sFiltro = "1=1"
            End If
            sFiltro += " ORDER BY NombreBodegaConCodigo, Descripcion"
            strReporteMostrar = "BODEGA"
        End If

        'campos para reporte si está seleccionado [TiposRepuestos] y cualquiera de los demás
        If Me.TipoSeleccion = TIPOREPUESTO Or Me.TipoSeleccion = BODEGA_TIPOREPUESTO Or Me.TipoSeleccion = REPUESTO_TIPOREPUESTO Or Me.TipoSeleccion = BODEGA_REPUESTO_TIPOREPUESTO Then
            sCampos = "SivRepuestoID, Descripcion, TipoRepuesto, Marca, Ubicacion, Existencia, " + _
                      "CostoU, TotalCosto, PrecioU, TotalPrecio, NombreBodegaConCodigo, objTiendaID, objTipoRepuesto"
            If String.IsNullOrEmpty(sFiltro) Then
                sFiltro = "1=1"
            End If
            sFiltro += " ORDER BY NombreBodegaConCodigo, TipoRepuesto, Descripcion"
            strReporteMostrar = "TIPOREPUESTO"
        End If

        'Campos para reporte si está seleccionado [Repuesto] pero no [TipoRepuesto]
        If Me.TipoSeleccion = REPUESTO Or Me.TipoSeleccion = BODEGA_REPUESTO Then
            sCampos = "(cast(SivRepuestoID as varchar) + ' - ' + Descripcion)as CodigoDescripcion, SivRepuestoID, Ubicacion, Existencia, " + _
                      "'Costo U: $' + CONVERT(VARCHAR,CostoU) as Costo, 'Precio U: $' + CONVERT(VARCHAR,PrecioU) as Precio, NombreBodega, CodigoBodega"
            If String.IsNullOrEmpty(sFiltro) Then
                sFiltro = "1=1"
            End If
            sFiltro += " ORDER BY Descripcion"
            strReporteMostrar = "REPUESTO"
        End If

        'Obtener datos para la generación del reporte
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptInventario", sFiltro)
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        'Si hay resultados mostrar opciones para mostrar informe
        If dtDatos.Rows.Count <> 0 Then
            'Si solo se seleccionó Bodega
            If strReporteMostrar.Equals("BODEGA") Then
                objRptInventarioBodega = New rptInventarioReporteBodegas
                With objRptInventarioBodega
                    .dtDatos = dtDatos
                    .VerCostoU = Me.chkCostos.Checked
                    .VerPrecioU = Me.chkPrecios.Checked
                    .VerTotales = Me.chkCostos.Checked Or Me.chkPrecios.Checked
                End With
                Me.OpcionesImpresion(objRptInventarioBodega)
            End If
            'Para el reporte de TipoRepuesto y Bodegas
            If strReporteMostrar.Equals("TIPOREPUESTO") Then
                objRptInventario = New rptInventarioReporte
                With objRptInventario
                    .dtDatos = dtDatos
                    .VerCostoU = Me.chkCostos.Checked
                    .VerPrecioU = Me.chkPrecios.Checked
                    .VerTotales = Me.chkCostos.Checked Or Me.chkPrecios.Checked
                End With
                Me.OpcionesImpresion(objRptInventario)
            End If
            'Para el Reporte de Repuesto
            If strReporteMostrar.Equals("REPUESTO") Then
                objRptInventarioRepuesto = New rptInventarioReporteRepuesto
                With objRptInventarioRepuesto
                    .dtDatos = dtDatos
                    .VerCostoU = Me.chkCostos.Checked
                    .VerPrecioU = Me.chkPrecios.Checked
                End With
                Me.OpcionesImpresion(objRptInventarioRepuesto)
            End If
        Else
            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If
    End Sub
#End Region

#Region "Imprimir Reporte Levantamiento Inventario"
    Private Sub Imprimir_ReporteLevantamientoInv()
        Dim objRptFormatoInv As rptInventarioReporteFormato
        Dim sSQL, sCampos, strFiltro As String
        Dim dtDatos As DataTable
        sCampos = "*"

        'Campos cuando solamente se ha seleccionado [Bodega]
        If Me.cmbBodegas.SelectedValue <> 0 Then
            strFiltro = " objTiendaID = " + Me.cmbBodegas.SelectedValue.ToString
        Else
            strFiltro = "1=1"
        End If

        sCampos = "SivRepuestoID, Descripcion, Marca, Ubicacion, Existencia, NombreBodegaConCodigo, objTiendaID"

        'Obtener datos para la generación del reporte
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptInventario", strFiltro + " ORDER BY NombreBodegaConCodigo, Descripcion")
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        'Si hay resultados mostrar opciones para mostrar informe
        If dtDatos.Rows.Count <> 0 Then
            'Si solo se seleccionó Bodega
            objRptFormatoInv = New rptInventarioReporteFormato
            objRptFormatoInv.DataSource = dtDatos
            Me.OpcionesImpresion(objRptFormatoInv)
        Else
            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If
    End Sub

#End Region

#Region "Opciones de Impresión"
    ''' <summary>
    ''' Procedimiento encargado de mostrar el cuadro de diálogo de las opciones de impresión
    ''' Autor : Gelmin Martinez
    ''' Fecha 14 de Junio de 2010, 09:14 pm.
    ''' </summary>
    Private Sub OpcionesImpresion(ByRef Reporte As DataDynamics.ActiveReports.ActiveReport3)
        Dim objImpresion As New frmOpcionesImpresion

        If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(Reporte)
                Case 2
                    clsProyecto.ImprimirEnImpresora(Reporte, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(Reporte, Me)
            End Select
        End If
    End Sub

#End Region

#Region "Construir Filtro"
    ''' <summary>
    ''' Función encargada de construir y devolver el filtro que ocupará la consulta del reporte. 
    ''' este se construye en base a los criterios seleccionados por el usuario
    ''' Autor : Gelmin Martinez
    ''' Fecha 14 de Junio de 2010, 09:15 pm.
    ''' </summary>
    Private Function ConstruirFiltro() As String
        Dim strFiltro As String = String.Empty

        Me.ConfigurarTipoSeleccionCriterios()

        Select Case Me.TipoSeleccion
            Case BODEGA  '-------------------------------------------------
                'Verificar si seleccionó bodega
                If Me.cmbBodegas.SelectedValue <> 0 Then
                    strFiltro = " objTiendaID = " + Me.cmbBodegas.SelectedValue.ToString
                End If

            Case REPUESTO  '----------------------------------------------
                If Me.cmbRepuestos.Text.Trim.Length <> 0 Then
                    strFiltro = " SivRepuestoID = '" + Me.cmbRepuestos.SelectedValue.ToString & "'"
                End If

            Case TIPOREPUESTO  '-------------------------------------------------
                If Me.cmbTipoRepuestos.SelectedValue <> 0 Then
                    strFiltro = " objTipoRepuesto='" + Me.cmbTipoRepuestos.SelectedValue.ToString & "'"
                End If

            Case BODEGA_REPUESTO '-------------------------------------------------
                If Me.cmbBodegas.SelectedValue <> 0 Then
                    strFiltro = " objTiendaID = " + Me.cmbBodegas.SelectedValue.ToString
                End If
                If Me.cmbRepuestos.Text.Trim.Length <> 0 Then
                    If Not String.IsNullOrEmpty(strFiltro) Then
                        strFiltro += " AND SivRepuestoID = '" + Me.cmbRepuestos.SelectedValue.ToString & "'"
                    Else
                        strFiltro = " SivRepuestoID = '" + Me.cmbRepuestos.SelectedValue.ToString & "'"
                    End If
                End If

            Case BODEGA_TIPOREPUESTO '-------------------------------------------------
                If Me.cmbBodegas.SelectedValue <> 0 Then
                    strFiltro = " objTiendaID = " + Me.cmbBodegas.SelectedValue.ToString
                End If
                If Me.cmbTipoRepuestos.SelectedValue <> 0 Then
                    If Not String.IsNullOrEmpty(strFiltro) Then
                        strFiltro += " AND objTipoRepuesto=" + Me.cmbTipoRepuestos.SelectedValue.ToString
                    Else
                        strFiltro = " objTipoRepuesto=" + Me.cmbTipoRepuestos.SelectedValue.ToString
                    End If
                End If

            Case REPUESTO_TIPOREPUESTO '-------------------------------------------------
                If Me.cmbRepuestos.Text.Trim.Length <> 0 Then
                    strFiltro = " SivRepuestoID = '" + Me.cmbRepuestos.SelectedValue.ToString & "'"
                End If

                If Me.cmbTipoRepuestos.SelectedValue <> 0 Then
                    If Not String.IsNullOrEmpty(strFiltro) Then
                        strFiltro += " AND objTipoRepuesto=" + Me.cmbTipoRepuestos.SelectedValue.ToString
                    Else
                        strFiltro = " objTipoRepuesto=" + Me.cmbTipoRepuestos.SelectedValue.ToString
                    End If
                End If

            Case BODEGA_REPUESTO_TIPOREPUESTO  '-------------------------------------------------
                If Me.cmbBodegas.SelectedValue <> 0 Then
                    strFiltro = " objTiendaID = " + Me.cmbBodegas.SelectedValue.ToString
                End If

                If Me.cmbRepuestos.Text.Trim.Length <> 0 Then
                    If Not String.IsNullOrEmpty(strFiltro) Then
                        strFiltro += " AND SivRepuestoID = '" + Me.cmbRepuestos.SelectedValue.ToString & "'"
                    Else
                        strFiltro = " SivRepuestoID = '" + Me.cmbRepuestos.SelectedValue.ToString & "'"
                    End If
                End If

                If Me.cmbTipoRepuestos.SelectedValue <> 0 Then
                    If Not String.IsNullOrEmpty(strFiltro) Then
                        strFiltro += " AND objTipoRepuesto=" + Me.cmbTipoRepuestos.SelectedValue.ToString
                    Else
                        strFiltro = " objTipoRepuesto=" + Me.cmbTipoRepuestos.SelectedValue.ToString
                    End If
                End If

        End Select

        ''Verificar si seleccionó Bodega 
        'If Me.chkBodega.Checked Then
        '    'Verificar si seleccionó bodega
        '    If Me.cmbBodegas.SelectedValue <> 0 Then
        '        strFiltro = " objTiendaID = " + Me.cmbBodegas.SelectedValue.ToString
        '    End If
        'End If

        ''Verificar si seleccionó Repuesto
        'If Me.chkRepuesto.Checked Then
        '    If Me.cmbRepuestos.SelectedValue <> 0 Then
        '        If String.IsNullOrEmpty(strFiltro) Then
        '            strFiltro = " SivRepuestoID = " + Me.cmbRepuestos.SelectedValue.ToString
        '        Else
        '            strFiltro += " AND SivRepuestoID = " + Me.cmbRepuestos.SelectedValue.ToString
        '        End If
        '    End If
        'End If
        ''Verificar si seleccionó Tipo Repuesto
        'If Me.chkTipoRepuesto.Checked Then
        '    If Me.cmbTipoRepuestos.SelectedValue <> 0 Then
        '        If String.IsNullOrEmpty(strFiltro) Then
        '            strFiltro = " objTipoRepuesto=" + Me.cmbTipoRepuestos.SelectedValue.ToString
        '        Else
        '            strFiltro += " AND objTipoRepuesto=" + Me.cmbTipoRepuestos.SelectedValue.ToString
        '        End If
        '    End If
        'End If

        Return strFiltro
    End Function
#End Region

#Region "Configurar Tipo Selección de Criterios"
    Private Sub ConfigurarTipoSeleccionCriterios()
        'Verificar si sólo seleccionó [Bodega]
        If Me.chkBodega.Checked And (Not Me.chkRepuesto.Checked And Not Me.chkTipoRepuesto.Checked) Then
            Me.TipoSeleccion = BODEGA
        End If
        'Verificar si sólo seleccionó [Repuesto]
        If Me.chkRepuesto.Checked And (Not Me.chkBodega.Checked And Not Me.chkTipoRepuesto.Checked) Then
            Me.TipoSeleccion = REPUESTO
        End If
        'Verificar si sólo seleccionó [TipoRepuesto]
        If Me.chkTipoRepuesto.Checked And (Not Me.chkBodega.Checked And Not Me.chkRepuesto.Checked) Then
            Me.TipoSeleccion = TIPOREPUESTO
        End If

        'Verificar si seleccionó [Bodega] y [Repuesto]
        If (Me.chkBodega.Checked And Me.chkRepuesto.Checked) And Not Me.chkTipoRepuesto.Checked Then
            Me.TipoSeleccion = BODEGA_REPUESTO
        End If

        'Verificar si seleccionó [Bodega] y [TipoRepuesto]
        If (Me.chkBodega.Checked And Me.chkTipoRepuesto.Checked) And Not Me.chkRepuesto.Checked Then
            Me.TipoSeleccion = BODEGA_TIPOREPUESTO
        End If

        'Verificar si seleccionó [Repuesto] y [TipoRepuesto]
        If (Me.chkRepuesto.Checked And Me.chkTipoRepuesto.Checked) And Not Me.chkBodega.Checked Then
            Me.TipoSeleccion = REPUESTO_TIPOREPUESTO
        End If

        'Verificar si se han seleccionado los tres campos [Bodega],[Repuesto],[TipoRepuesto]
        If Me.chkBodega.Checked And Me.chkRepuesto.Checked And Me.chkTipoRepuesto.Checked Then
            Me.TipoSeleccion = BODEGA_REPUESTO_TIPOREPUESTO
        End If
    End Sub

#End Region

End Class