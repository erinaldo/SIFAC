Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI

''' <summary>
''' Formulario Principal de Recepción de transferencia
''' Autor : Gelmin Martínez
''' Fecha : 01 de Junio de 2010, 04:57 pm.
''' </summary>
''' <remarks></remarks>
Public Class frmSivRecepTransferencia

#Region "Atributos"
    'Variables globales para mantener los distintos estados de las transferencias
    Public Shared gblEstadoRecibidaID As Integer
    Public Shared gblEstadoDespachadaID As Integer
    Public Shared gblEstadoAnuladaID As Integer

    'Variables de uso local
    Private m_IdSivTransferencia As Integer
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer
    Private m_DiasTransferenciaRecientes As Integer
    Private DtTransferencias As DataTable

    ' Variables para control de seguridad
    Private blnAprobar As Boolean
    Private blnConsultar As Boolean
    Private blnImprimir As Boolean

    'Constantes para el tyGui
    Private Const APROBACION = 0
    Private Const CONSULTA = 2

#End Region

#Region "Constantes"
    Private Const RECIBIR = 0
    Private Const CONSULTAR = 2
#End Region

#Region "Propiedades"

    Property IdSivTransferencia() As Integer
        Get
            IdSivTransferencia = Me.m_IdSivTransferencia
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSivTransferencia = value
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

    Property IdSucursalSession() As Integer
        Get
            IdSucursalSession = Me.m_IdSucursalSession
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalSession = value
        End Set
    End Property

    Property DiasTransferenciasRecientes() As Integer
        Get
            DiasTransferenciasRecientes = Me.m_DiasTransferenciaRecientes
        End Get
        Set(ByVal value As Integer)
            Me.m_DiasTransferenciaRecientes = value
        End Set
    End Property

#End Region

#Region "Cargar Datos"
    ''' <summary>
    ''' Procedimiento encargado de cargar los datos de las solicitudes de transferencias a despachar.
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 26 de Mayo de 2010, 01:21 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaDatos()
        Dim sSQL, sSQL1, sSQL2, sCampos, sFiltro1, sFiltro2 As String
        Me.DiasTransferenciasRecientes = ClsCatalogos.GetValorParametro("DiasTransfRecientes")

        Dim strFiltroSitio As String = " ObjBodegaDestinoID = " + Me.IdSucursalSession.ToString
        sCampos = "CONVERT(VARCHAR,Fechasolicitud,103) AS Fechasolicitud, CONVERT(VARCHAR,Fechadespacho,103) AS Fechadespacho, " + _
                  "CONVERT(VARCHAR,Fecharecibido,103) AS Fecharecibido, SivTransferenciaID, ObjBodegaDestinoID, ObjBodegaOrigenID, " + _
                  "SitioOrigen, SitioDestino, SolicitadoPor, DespachadoPor,RecibidoPor, ObjEstadoID, Estado"

        sFiltro2 = " (DATEDIFF(DAY, Fecharecibido, GETDATE()) <= " + Me.DiasTransferenciasRecientes.ToString + ")"  'Filtra por antiguedad
        sFiltro1 = " (ObjEstadoID = " + gblEstadoDespachadaID.ToString + " OR ObjEstadoID = " + gblEstadoRecibidaID.ToString + ")"

        'Si la sucursal en sesión no es la CENTRAL sólo mostrar los registros del sitio logueado
        If Not Me.IdSucursalSession = Me.IdSucursalCentral Then
            sFiltro1 += " AND " + strFiltroSitio
            sFiltro2 += " AND " + strFiltroSitio
        End If

        Try
            Me.DtTransferencias = New DataTable
            sSQL1 = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferencias", sFiltro1)
            sSQL2 = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferencias", sFiltro2)

            sSQL = "(" + sSQL1 + ") UNION (" + sSQL2 + ")"

            Me.DtTransferencias = SqlHelper.ExecuteQueryDT(sSQL)
            Me.DtTransferencias.PrimaryKey = New DataColumn() {Me.DtTransferencias.Columns("SivTransferenciaID")}
            Me.DtTransferencias.DefaultView.Sort = "SivTransferenciaID desc"
            Me.grdTrasnferencias.DataSource = DtTransferencias

            'Me.grdTransferencias.SetDataBinding(Me.DtTransferencias, "", True)
            'Me.grdTransferencias.Splits(0).DisplayColumns("ObjEstadoID").Visible = False
            'Me.grdTransferencias.Splits(0).DisplayColumns("ObjBodegaDestinoID").Visible = False
            'Me.bloquearBotonesBarra(Me.DtTransferencias.Rows.Count = 0)
            'Me.grdTransferencias.Caption = "Solicitudes de transferencias (" + Me.grdTransferencias.RowCount.ToString + ")"
            'Me.grdTransferencias.Refresh()

            Me.cmdAprobar.Enabled = Me.blnAprobar And Me.grdTransferenciasTabla.RowCount <> 0
            Me.cmdConsultarSolicitud.Enabled = Me.blnConsultar And Me.grdTransferenciasTabla.RowCount <> 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Formulario"
    Private Sub frmSivDespTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.AplicarSeguridad()

            gblEstadoRecibidaID = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "03") '-- 03=RECIBIDA
            gblEstadoDespachadaID = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "02") '-- 02=Despachada
            gblEstadoAnuladaID = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "04") '-- 04=Anulada

            Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
            Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)

            Me.CargaDatos()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 01 de Junio de 2010.05:26 pm.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FrmSivRecepTransferencia"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAprobar = objSeg.TienePermiso("AprobarRecepTransf")
            Me.blnImprimir = objSeg.TienePermiso("ImprimirRecepTransf")
            Me.blnConsultar = objSeg.TienePermiso("ConsultarRecepTransf")

            'Aplicar permisos a los comandos
            Me.cmdAprobar.Enabled = Me.blnAprobar
            Me.cmdImprimir.Enabled = Me.blnImprimir
            Me.cmdConsultarSolicitud.Enabled = Me.blnConsultar

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Procedimientos"

#Region "Aprobar recepción transferencia"
    ''' <summary>
    ''' Procedimiento encargado de recepcionar un despacho transferencia
    ''' Autor : Gelmin Martinez.
    ''' Fecha : 01 de Junio de 2010, 05:27 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RecepcionarTransferencia()
        Dim objTransfRecep As New frmSivRecepTransferenciaEdit
        Dim iIndiceRegistro As Integer
        Dim blnAnulada As Boolean

        Try
            Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
            Dim FilaActual As Integer = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))
            objTransfRecep.TypeGui = RECIBIR 'Modo RECEPCIÓN
            objTransfRecep.IdSivTransferencia = Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID"))
            If objTransfRecep.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargaDatos()

                    If (Me.DtTransferencias.Rows.Count <> 0) Then
                    iIndiceRegistro = Me.DtTransferencias.DefaultView.Find(objTransfRecep.IdSivTransferencia)
                    Dim view As ColumnView = grdTrasnferencias.FocusedView
                    Dim column As GridColumn = view.Columns("colSivTransferenciaID")

                    If Not IsDBNull(column) Then
                        Dim rhFound As Integer = view.LocateByDisplayText(view.FocusedRowHandle + 1, column, iIndiceRegistro)
                        If rhFound <> GridControl.InvalidRowHandle Then
                            view.FocusedRowHandle = rhFound
                            view.FocusedColumn = column
                        End If

                        If MsgBox("¿Desea imprimir la recepción de transferencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then

                            blnAnulada = Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID") = gblEstadoAnuladaID
                            Imprimir_Recepcion(objTransfRecep.IdSivTransferencia, blnAnulada)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Consultar recepción transferencia"
    Private Sub Consultar_SolicitudTransf()
        'Dim objFormSoliTransDesp As frmSivDespTransferenciaDesp
        'Try
        '    objFormSoliTransDesp = New frmSivDespTransferenciaDesp

        '    With objFormSoliTransDesp
        '        .TypeGui = CONSULTAR
        '        .FormLlamada = Me.Name
        '        .IdSivTransferencia = Me.IdSivTransferencia
        '        .ShowDialog(Me)
        '    End With

        Dim objForm As frmSivRecepTransferenciaEdit
        Try
            objForm = New frmSivRecepTransferenciaEdit

            With objForm
                .TypeGui = CONSULTAR
                .IdSivTransferencia = Me.IdSivTransferencia
                .ShowDialog(Me)
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Imprimir recepción de transferencia"
    'Procedimiento que imprime varias recepciones de acuerdo al filtro seleccionado por el usuario
    Public Sub Imprimir_recepcionTransferencias()
        Dim objParamReporte As New frmReportesTransferencias
        objParamReporte.FormLlamado = Me.Name
        objParamReporte.ShowDialog()
    End Sub

    'Procedimiento que imprime UNA sola recepción después que se ha registrado en el sistema.
    Private Sub Imprimir_Recepcion(ByVal iIdTransferencia As Integer, ByVal EstadoAnulada As Boolean)
        'Dim objRptSoliTransf As New rptTransferenciaRecepcion
        'Dim objImpresion As frmOpcionesImpresion
        'Dim sSQL, sCampos, sFiltro As String

        'objImpresion = New frmOpcionesImpresion
        'If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    sFiltro = "SivTransferenciaID=" + iIdTransferencia.ToString
        '    sCampos = "SivProductoID, Producto, CantidadSolicitada, ObjBodegaOrigenID, ObjBodegaDestinoID, SolicitadoPor, Fechasolicitud, ObjEstadoID, Observaciones, SivTransferenciaID, SitioDestino, SitioOrigen, Anulada, Fechadespacho, DespachadoPor, CantidadDespachada, Fecharecibido, RecibidoPor, CantidadRecibida"
        '    sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaRecepcion", sFiltro)

        '    objRptSoliTransf.EstadoAnulada = EstadoAnulada
        '    objRptSoliTransf.DataSource = SqlHelper.ExecuteQueryDT(sSQL)
        '    Select Case objImpresion.Seleccion
        '        Case 1
        '            clsProyecto.ImprimirEnPantalla(objRptSoliTransf)
        '        Case 2
        '            clsProyecto.ImprimirEnImpresora(objRptSoliTransf, True)
        '        Case 3
        '            clsProyecto.ImprimirEnArchivo(objRptSoliTransf, Me)
        '    End Select
        'End If

        Dim dsReporte As DataSet
        Dim sCampos, sSQL, sFiltro As String
        Try
            Dim objjReporte As New rptHojaTransfRecepcion()

            sFiltro = "SivTransferenciaID=" + iIdTransferencia.ToString
            sCampos = "SivProductoID, Producto, CantidadSolicitada, ObjBodegaOrigenID, ObjBodegaDestinoID, SolicitadoPor, Fechasolicitud, ObjEstadoID, Observaciones, SivTransferenciaID, SitioDestino, SitioOrigen, Anulada, Fechadespacho, DespachadoPor, CantidadDespachada, Fecharecibido, RecibidoPor, CantidadRecibida,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa"
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaRecepcion", sFiltro)
            dsReporte = SqlHelper.ExecuteQueryDS(sSQL)

            If dsReporte.Tables(0).Rows.Count = 0 Then
                MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objjReporte.DataSource = dsReporte
            objjReporte.DataMember = dsReporte.Tables(0).TableName
            Dim pt As New ReportPrintTool(objjReporte)
            pt.ShowPreview()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    'Procedmiento para imprimir diferencias entre lo solicitado y recepcionado
    Private Sub Imprimir_Diferencias(ByVal iIdTransferencia As Integer)
        Dim objParamReporte As New frmReportesTransferencias
        objParamReporte.FormLlamado = Me.Name + "1" '1=Enlace de Imprimir [Diferencias]
        objParamReporte.ShowDialog()
    End Sub

#End Region

#End Region

#Region "Bloquear botones barra"
    Private Sub bloquearBotonesBarra(ByVal bValor As Boolean)
        Me.cmdAprobar.Enabled = (Not bValor) And Me.blnAprobar
        Me.cmdConsultarSolicitud.Enabled = (Not bValor) And Me.blnConsultar
        Me.cmdImprimir.Enabled = (Not bValor) And Me.blnImprimir
    End Sub
#End Region

#Region "Eventos de controles"
    Private Sub cmdConsultarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarSolicitud.Click
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
            FilaActual = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))

            If Me.grdTransferenciasTabla.RowCount > 0 Then

                Me.IdSivTransferencia = Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID")
                Me.Consultar_SolicitudTransf()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Me.CargaDatos()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub grdTransferencias_FilterChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.grdTrasnferencias.Text = "Solicitudes transferencia (" & Me.grdTransferenciasTabla.RowCount & ")"
            If Me.grdTransferenciasTabla.RowCount = 0 Then
                Me.cmdAprobar.Enabled = False
                Me.cmdConsultarSolicitud.Enabled = False
            Else
                Me.cmdAprobar.Enabled = Me.blnAprobar
                Me.cmdConsultarSolicitud.Enabled = Me.blnConsultar
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdTransferencias_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs)
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
            FilaActual = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))

            If Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID").ToString.Trim.Length <> 0 Then
                Me.cmdAprobar.Enabled = Me.blnAprobar And Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID")) = gblEstadoDespachadaID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub cmdAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAprobar.Click
        Try
            Me.RecepcionarTransferencia()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdImprimirSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirSeleccion.Click
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
            FilaActual = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))

            Dim blnAnulada As Boolean
            blnAnulada = Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID") = gblEstadoAnuladaID
            Imprimir_Recepcion(Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID"), blnAnulada)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdImprimirFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirFiltro.Click
        Try
            Imprimir_recepcionTransferencias()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdImprimirDiferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
            FilaActual = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))

            Imprimir_Diferencias(Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID"))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub grdTransferenciasTabla_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grdTransferenciasTabla.RowStyle
        Dim estado As String = ""
        Dim vista As GridView = sender

        Try

            estado = vista.GetRowCellValue(e.RowHandle, vista.Columns("Estado")).ToString().Trim()
        Catch ex As Exception

        End Try

        Select Case estado
            Case "Solicitada"
                e.Appearance.BackColor = Color.LightSteelBlue
                e.Appearance.BackColor2 = Color.White

            Case "Despachada"
                e.Appearance.BackColor = Color.LimeGreen
                e.Appearance.BackColor2 = Color.White

            Case "Recibida"
                e.Appearance.BackColor = Color.Beige
                e.Appearance.BackColor2 = Color.White

            Case "Anulada"
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.White

        End Select
    End Sub

    Private Sub grdTransferenciasTabla_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles grdTransferenciasTabla.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
            FilaActual = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))

            If Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID").ToString.Trim.Length <> 0 Then
                Me.cmdAprobar.Enabled = Me.blnAprobar And Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID")) = gblEstadoDespachadaID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class