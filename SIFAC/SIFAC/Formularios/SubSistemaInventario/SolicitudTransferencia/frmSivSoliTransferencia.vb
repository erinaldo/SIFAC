
Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

''' <summary>
''' Formulario Principal de Solicitudes de transferencia
''' Autor : Gelmin Martínez
''' Fecha : 19 de Mayo de 2010, 03:33 pm.
''' </summary>
''' <remarks></remarks>
Public Class frmSivSoliTransferencia

#Region "Atributos"
    Private m_IdSivTransferencia As Integer
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer
    Private m_IdEstadoSolicitada As Integer
    Private m_IdEstadoAnulada As Integer
    Private m_DiasTransferenciaRecientes As Integer
    Private DtTransferencias As DataTable

    ' Variables para control de seguridad
    Private blnAgregar As Boolean
    Private blnAnular As Boolean
    Private blnEditar As Boolean
    Private blnConsultar As Boolean
    Private blnImprimir As Boolean
#End Region

#Region "Constantes"
    Private Const AGREGAR = 0
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

    Property IdEstadoSolicitada() As Integer
        Get
            IdEstadoSolicitada = Me.m_IdEstadoSolicitada
        End Get
        Set(ByVal value As Integer)
            Me.m_IdEstadoSolicitada = value
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

    Property IdEstadoAnulada() As Integer
        Get
            IdEstadoAnulada = Me.m_IdEstadoAnulada
        End Get
        Set(ByVal value As Integer)
            Me.m_IdEstadoAnulada = value
        End Set
    End Property

#End Region

#Region "Cargar Datos"
    ''' <summary>
    ''' Procedimiento encargado de cargar los datos de las solicitudes de transferencias.
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 19 de Mayo de 2010, 03:42 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaDatos()
        Dim sSQL, sSQL1, sSQL2, sCampos, sFiltro1, sFiltro2 As String
        Me.DiasTransferenciasRecientes = ClsCatalogos.GetValorParametro("DiasTransfRecientes")

        Dim strFiltroSitio As String = " (ObjBodegaOrigenID = " + Me.IdSucursalSession.ToString + " OR ObjBodegaDestinoID = " + Me.IdSucursalSession.ToString + ")"
        sCampos = "CONVERT(VARCHAR,Fechasolicitud,103) AS Fechasolicitud, SivTransferenciaID, ObjBodegaDestinoID, ObjBodegaOrigenID, SitioOrigen, SitioDestino, SolicitadoPor, ObjEstadoID, Estado"
        sFiltro2 = " (DATEDIFF(DAY, Fechasolicitud, GETDATE()) <= " + Me.DiasTransferenciasRecientes.ToString + ")" 'Filtra por antiguedad
        sFiltro1 = " ObjEstadoID= " + Me.IdEstadoSolicitada.ToString

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
            Me.bloquearBotonesBarra(Me.DtTransferencias.Rows.Count = 0)
            'Me.grdTransferencias.Caption = "Solicitudes de transferencias (" + Me.grdTransferencias.RowCount.ToString + ")"
            'Me.grdTransferencias.Refresh()            
           
            If Me.grdTransferenciasTabla.RowCount <> 0 Then
                Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
                Dim FilaActual As Integer = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))

                If Not IsDBNull(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID")) Then
                    Me.cmdAnularSolicitud.Enabled = Me.blnAnular And Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID") = Me.IdEstadoSolicitada
                Else
                    Me.cmdConsultarSolicitud.Enabled = False
                End If
                Me.cmdConsultarSolicitud.Enabled = Me.blnConsultar
            Else
                Me.cmdAnularSolicitud.Enabled = False
                Me.cmdConsultarSolicitud.Enabled = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 12 de Mayo de 2010.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FrmSivSolTransferencia"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAgregar = objSeg.TienePermiso("AgregarSolTransf")
            Me.blnAnular = objSeg.TienePermiso("AnularSolTransf")
            Me.blnEditar = objSeg.TienePermiso("EDITARSOLTRANSF")
            Me.blnImprimir = objSeg.TienePermiso("ImprimirSolTransf")
            Me.blnConsultar = objSeg.TienePermiso("ConsultarSolTransf")

            'Aplicar permisos a los comandos
            Me.cmdAgregarSolicitud.Enabled = Me.blnAgregar
            Me.cmdAnularSolicitud.Enabled = Me.blnAnular
            Me.cmdImprimir.Enabled = Me.blnImprimir
            Me.cmdConsultarSolicitud.Enabled = Me.blnConsultar

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Procedimientos"

#Region " Nueva solicitud transferencia"
    ''' <summary>
    ''' Procedimiento encargado de crear un nueva solicitud de transferencia
    ''' Autor : Gelmin Martinez.
    ''' Fecha : 19 de Mayo de 2010, 06:00 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Nueva_SolicitudTransf()
        Dim objTransfEditar As frmSivSoliTransferenciaEdit
        Dim iIndiceRegistro As Integer
        Dim blnAnulada As Boolean

        Try
            objTransfEditar = New frmSivSoliTransferenciaEdit
            objTransfEditar.TypeGui = AGREGAR
            If objTransfEditar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargaDatos()
                If (Me.DtTransferencias.Rows.Count <> 0) Then
                    iIndiceRegistro = Me.DtTransferencias.DefaultView.Find(objTransfEditar.IdSivTransferencia)

                    'Dim searchID As String = Me.DtTransferencias.DefaultView.Find(SivTransferenciaID).ToString
                    Dim view As ColumnView = grdTrasnferencias.FocusedView
                    Dim column As GridColumn = view.Columns("colSivTransferenciaID")

                    If Not IsDBNull(column) Then
                        Dim rhFound As Integer = view.LocateByDisplayText(view.FocusedRowHandle + 1, column, iIndiceRegistro)
                        If rhFound <> GridControl.InvalidRowHandle Then
                            view.FocusedRowHandle = rhFound
                            view.FocusedColumn = column
                        End If

                        If MsgBox("¿Desea imprimir la solicitud de transferencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
                            Dim FilaActual As Integer = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))

                            blnAnulada = Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID") = Me.IdEstadoAnulada
                            Imprimir_Solicitud(objTransfEditar.IdSivTransferencia, blnAnulada)
                        End If


                        'If (Me.DtTransferencias.Rows.Count <> 0) Then
                        '    iIndiceRegistro = Me.DtTransferencias.DefaultView.Find(SivTransferenciaID)
                        '    Me.grdTransferencias.Row = iIndiceRegistro
                        'End If
                    End If

                    'Me.grdTransferencias.Row = iIndiceRegistro
                    'If MsgBox("¿Desea imprimir la solicitud de transferencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    '    blnAnulada = Me.grdTransferencias.Columns("ObjEstadoID").Value = Me.IdEstadoAnulada
                    '    Imprimir_Solicitud(objTransfEditar.IdSivTransferencia, blnAnulada)
                    'End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Anular solicitud transferencia"
    Private Function Anular_SolicitudTransf(ByVal SivTransferenciaID As Integer, ByVal ObjTiendaDestinoID As Integer) As Boolean
        Dim T As New TransactionManager
        Dim objTransf As New SivTransferencia
        Dim dtDetalleTransf As DataTable
        Dim strFiltro As String = String.Empty

        Try
            Try
                If MsgBox("¿Seguro que desea anular la solicitud de transferencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    T.BeginTran()
                    With objTransf
                        .Retrieve(SivTransferenciaID.ToString, T)
                        .ObjEstadoID = Me.IdEstadoAnulada
                        .costototal = 0
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor
                        .Update(T)
                    End With

                    strFiltro = "objTransferenciaID=" + SivTransferenciaID.ToString + " AND ObjBodegaDestinoID=" + ObjTiendaDestinoID.ToString
                    dtDetalleTransf = SivTransferenciaDetalle.RetrieveDT(strFiltro, , , T)

                    'Volver cantidades de detalle a CERO
                    For Each row As DataRow In dtDetalleTransf.Rows
                        row("CantidadSolicitada") = 0
                        row("CantidadDespachada") = 0
                        row("CantidadRecibida") = 0
                        row("Costo") = 0
                        row("subtotal") = 0
                        row("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                        row("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                    Next

                    dtDetalleTransf.TableName = "SivTransferenciaDetalle"
                    'dtDetalleTransf.AcceptChanges()
                    SivTransferenciaDetalle.BatchUpdate(dtDetalleTransf.DataSet, T)

                    T.CommitTran()
                    MsgBox("Solicitud de transferencia anulada con éxito.", MsgBoxStyle.Information)
                    Return True
                End If
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            T = Nothing
            objTransf = Nothing
        End Try

    End Function
#End Region

#Region "Consultar solicitud transferencia"
    Private Sub Consultar_SolicitudTransf()
        Dim objFormSoliTransEdit As frmSivSoliTransferenciaEdit
        Try
            objFormSoliTransEdit = New frmSivSoliTransferenciaEdit
            objFormSoliTransEdit.TypeGui = CONSULTAR
            objFormSoliTransEdit.IdSivTransferencia = Me.IdSivTransferencia
            objFormSoliTransEdit.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Imprimir solicitudes transferencia"
    'Procedimiento que imprime varias solicitudes de acuerdo al filtro seleccionado por el usuario
    Public Sub Imprimir_solicitudesTransf()
        Try
            Dim objParamReporte As New frmReportesTransferencias
            objParamReporte.FormLlamado = Me.Name
            objParamReporte.ShowDialog()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    'Procedimiento que imprime UNA sola solicitud después que se ha registrado en el sistema.
    Private Sub Imprimir_Solicitud(ByVal iIdTransferencia As Integer, ByVal EstadoAnulada As Boolean)
        'Dim objRptSoliTransf As rptTransferenciaSolicitud
        'Dim objImpresion As frmOpcionesImpresion
        'Dim sSQL, sCampos, sFiltro As String

        'objImpresion = New frmOpcionesImpresion
        'If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    objRptSoliTransf = New rptTransferenciaSolicitud
        '    sFiltro = "SivTransferenciaID=" + iIdTransferencia.ToString
        '    sCampos = "SivTransferenciaID, SivProductoID, Producto, CantidadSolicitada, ObjBodegaOrigenID, SitioDestino,SitioOrigen, ObjBodegaDestinoID, SolicitadoPor, Fechasolicitud, ObjEstadoID, EstadoTransferencia, Observaciones"
        '    sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaSolicitud", sFiltro)
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
            Dim objjReporte As New rptHojaSolicitudTransferencia()

            sFiltro = "SivTransferenciaID=" + iIdTransferencia.ToString
            sCampos = "ClaveSitios, SivProductoID, Producto, CantidadSolicitada, ObjBodegaOrigenID, ObjBodegaDestinoID, SolicitadoPor, Fechasolicitud, ObjEstadoID, EstadoTransferencia, Observaciones, SivTransferenciaID, SitioDestino, SitioOrigen, Anulada, CodigoTiendaDestino, CodigoTiendaOrigen, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa"
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaSolicitud", sFiltro)
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

#End Region

#End Region

#Region "Bloquear botones barra"
    Private Sub bloquearBotonesBarra(ByVal bValor As Boolean)
        Try
            Me.cmdAnularSolicitud.Enabled = (Not bValor) And blnAnular
            Me.cmdConsultarSolicitud.Enabled = (Not bValor) And blnConsultar
            Me.cmdImprimir.Enabled = (Not bValor) And blnImprimir
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos de controles"
    Private Sub frmSivSoliTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            'SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("StbTiendaID", "dbo.StbTienda", "Codigo='C'")).DefaultView.Item(0)("StbTiendaID")
            Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
            Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
            Me.IdEstadoSolicitada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "01")   '-- 01=SOLICITADA
            Me.IdEstadoAnulada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "04") '-- 04=Anulada

            Me.AplicarSeguridad()
            Me.CargaDatos()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarSolicitud.Click
        Me.Nueva_SolicitudTransf()
    End Sub

    Private Sub cmdAnularSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnularSolicitud.Click
        Dim iIndiceRegistro, SivTransferenciaID, objTiendaDestinoID As Integer
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdTransferenciasTabla.GetSelectedRows()
            FilaActual = Me.grdTransferenciasTabla.GetDataSourceRowIndex(selectedRow(0))

            If Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID").ToString.Trim.Length <> 0 And Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaDestinoID").ToString.Trim.Length <> 0 Then
                SivTransferenciaID = Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID")

                objTiendaDestinoID = Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaDestinoID")
                Dim Trans As New SivTransferencia
                Trans.Retrieve(SivTransferenciaID)
                If Trans.ObjEstadoID = Me.IdEstadoAnulada Then
                    MsgBox("La trasferencia seleccionada ya ha sido anulada, favor refrescar datos.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Else
                    If Me.Anular_SolicitudTransf(SivTransferenciaID, Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaDestinoID")) Then
                        Me.CargaDatos()

                        iIndiceRegistro = Me.DtTransferencias.DefaultView.Find(SivTransferenciaID)
                        Dim view As ColumnView = grdTrasnferencias.FocusedView
                        Dim column As GridColumn = view.Columns("ObjBodegaDestinoID")

                        If Not IsDBNull(column) Then
                            Dim rhFound As Integer = view.LocateByDisplayText(view.FocusedRowHandle + 1, column, iIndiceRegistro)
                            If rhFound <> GridControl.InvalidRowHandle Then
                                view.FocusedRowHandle = rhFound
                                view.FocusedColumn = column
                            End If

                            'If (Me.DtTransferencias.Rows.Count <> 0) Then
                            '    iIndiceRegistro = Me.DtTransferencias.DefaultView.Find(SivTransferenciaID)
                            '    Me.grdTransferencias.Row = iIndiceRegistro
                            'End If
                        End If
                    End If
                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

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
        Try
            Me.CargaDatos()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub grdTransferencias_FilterChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.grdTrasnferencias.Text = "Solicitudes transferencia (" & Me.grdTransferenciasTabla.RowCount & ")"
            If grdTransferenciasTabla.RowCount = 0 Then
                Me.cmdAnularSolicitud.Enabled = False
                Me.cmdConsultarSolicitud.Enabled = False
            Else
                Me.cmdAnularSolicitud.Enabled = Me.blnAnular
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
                Me.cmdAnularSolicitud.Enabled = Me.blnAnular And Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID")) = Me.IdEstadoSolicitada
            End If
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
            blnAnulada = Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID") = Me.IdEstadoAnulada
            Imprimir_Solicitud(Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID"), blnAnulada)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdImprimirFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirFiltro.Click
        Try
            Me.Imprimir_solicitudesTransf()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



    Private Sub grdTransferenciasTabla_RowStyle(sender As Object, e As Views.Grid.RowStyleEventArgs) Handles grdTransferenciasTabla.RowStyle
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
                Me.cmdAnularSolicitud.Enabled = Me.blnAnular And Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID")) = Me.IdEstadoSolicitada
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region
End Class