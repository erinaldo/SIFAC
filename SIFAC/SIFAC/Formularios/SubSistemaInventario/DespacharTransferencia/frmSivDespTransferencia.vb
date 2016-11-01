
Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO

''' <summary>
''' Formulario Principal de Despacho de transferencia
''' Autor : Gelmin Martínez
''' Fecha : 26 de Mayo de 2010, 01:19 pm.
''' </summary>
''' <remarks></remarks>
Public Class frmSivDespTransferencia

#Region "Atributos"
    Private m_IdSivTransferencia As Integer
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer
    Private m_IdEstadoSolicitada As Integer
    Private m_IdEstadoAnulada As Integer
    Private m_IdEstadoDespachada As Integer
    Private m_DiasTransferenciaRecientes As Integer
    Private DtTransferencias As DataTable

    ' Variables para control de seguridad
    Private blnAgregar As Boolean
    Private blnAnular As Boolean
    Private blnDespachar As Boolean
    Private blnConsultar As Boolean
    Private blnImprimir As Boolean
#End Region

#Region "Constntes"
    Private Const AGREGAR = 0
    Private Const DESPACHAR = 1
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

    Private Property IdEstadoDespachada() As Integer
        Get
            IdEstadoDespachada = Me.m_IdEstadoDespachada
        End Get
        Set(ByVal value As Integer)
            Me.m_IdEstadoDespachada = value
        End Set
    End Property

#End Region

#Region "Cargar Formulario"
    Private Sub frmSivDespTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.IdEstadoSolicitada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "01")   '-- 01=SOLICITADA
        Me.IdEstadoAnulada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "04") '-- 04=Anulada
        Me.IdEstadoDespachada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "02") '-- 02=Despachada

        Me.AplicarSeguridad()
        Me.CargaDatos()
    End Sub
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
        Me.DiasTransferenciasRecientes = ClsCatalogos.GetValorParametro("diasTransfRecientes")

        Dim strFiltroSitio As String = " ObjBodegaOrigenID = " + Me.IdSucursalSession.ToString
        sCampos = "CONVERT(VARCHAR,Fechasolicitud,103) AS Fechasolicitud, CONVERT(VARCHAR,Fechadespacho,103) AS Fechadespacho, SivTransferenciaID, ObjBodegaDestinoID, ObjBodegaOrigenID, SitioOrigen, SitioDestino, SolicitadoPor, DespachadoPor, ObjEstadoID, Estado"
        sFiltro2 = " (DATEDIFF(DAY, Fechadespacho, GETDATE()) <= " + Me.DiasTransferenciasRecientes.ToString + ")"  'Filtra por antiguedad
        sFiltro1 = " (ObjEstadoID= " + Me.IdEstadoSolicitada.ToString + " OR ObjEstadoID = " + Me.IdEstadoDespachada.ToString + ")"

        'Si la sucursal en sesión no es la CENTRAL sólo mostrar los registros del sitio logueado
        If Not Me.IdSucursalSession = Me.IdSucursalCentral Then
            sFiltro1 += " AND " + strFiltroSitio
            sFiltro2 += " AND " + strFiltroSitio
        End If

        Try
            Me.DtTransferencias = New DataTable
            sSQL1 = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferencias", sFiltro1) 'Filtro1 = Filtra por estado y sitio
            sSQL2 = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferencias", sFiltro2) 'Filtro2 = filtra por días en el parámetro

            sSQL = "(" + sSQL1 + ") UNION (" + sSQL2 + ")"

            Me.DtTransferencias = SqlHelper.ExecuteQueryDT(sSQL)
            Me.DtTransferencias.PrimaryKey = New DataColumn() {Me.DtTransferencias.Columns("SivTransferenciaID")}
            Me.DtTransferencias.DefaultView.Sort = "SivTransferenciaID"
            Me.grdTrasnferencias.DataSource = Me.DtTransferencias
            'Me.FormatearGridPrincipal()
            
            Me.bloquearBotonesBarra(Me.DtTransferencias.Rows.Count = 0)
            Me.grdTrasnferencias.Text = "Solicitudes de transferencias (" + Me.grdTransferenciasTablas.RowCount.ToString + ")"


            'If Me.grdTransferenciasTablas.RowCount <> 0 Then
            '    If Not IsDBNull(Me.grdTrasnferencias.Columns("ObjEstadoID").Value) Then
            '        Me.cmdAnularSolicitud.Enabled = Me.blnAnular And Integer.Parse(Me.grdTransferencias.Columns("ObjEstadoID").Value) = Me.IdEstadoDespachada
            '    Else
            '        Me.cmdAnularSolicitud.Enabled = False
            '    End If

            '    Me.cmdConsultarSolicitud.Enabled = Me.blnConsultar
            '    Me.cmdDespachar.Enabled = Me.blnDespachar
            'Else
            '    Me.cmdAnularSolicitud.Enabled = False
            '    Me.cmdConsultarSolicitud.Enabled = False
            '    Me.cmdDespachar.Enabled = False
            'End If
            
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 26 de Mayo de 2010. 01:28 pm.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "frmSivDespTransferencia"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAgregar = objSeg.TienePermiso("AgregarDespTransf")
            Me.blnDespachar = objSeg.TienePermiso("DespacharTransf")
            Me.blnAnular = objSeg.TienePermiso("AnularDespTransf")
            Me.blnImprimir = objSeg.TienePermiso("ImprimirDespTransf")
            Me.blnConsultar = objSeg.TienePermiso("ConsultarDespTransf")

            'Aplicar permisos a los comandos
            Me.cmdAgregarSolicitud.Enabled = Me.blnAgregar
            Me.cmdDespachar.Enabled = Me.blnDespachar
            Me.cmdAnularSolicitud.Enabled = Me.blnAnular
            Me.cmdImprimir.Enabled = Me.blnImprimir
            Me.cmdConsultarSolicitud.Enabled = Me.blnConsultar

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    '#Region "Formatear Grid principal"
    '    Private Sub FormatearGridPrincipal()
    '        Me.grdTransferencias.Splits(0).DisplayColumns("ObjEstadoID").Visible = False
    '        Me.grdTransferencias.Splits(0).DisplayColumns("ObjBodegaDestinoID").Visible = False
    '        Me.grdTransferencias.Splits(0).DisplayColumns("ObjBodegaOrigenID").Visible = False
    '    End Sub
    '#End Region

#Region "Procedimientos"

#Region " Nuevo despacho transferencia"
    ''' <summary>
    ''' Procedimiento encargado de crear un nuevo despacho de transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Nuevo_DespachoTransf()
        Dim objTransfEditar As New frmSivDespTransferenciaEdit
        Dim iIndiceRegistro As Integer
        Dim blnAnulada As Boolean
        Dim FilaActual As Integer
        Try
            objTransfEditar.TypeGui = AGREGAR
            If objTransfEditar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargaDatos()
                If (Me.DtTransferencias.Rows.Count <> 0) Then
                    iIndiceRegistro = Me.DtTransferencias.DefaultView.Find(objTransfEditar.IdSivTransferencia)
                    Me.DtTransferencias.DefaultView.Find(iIndiceRegistro)
                    If MsgBox("¿Desea imprimir la despacho de transferencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                        FilaActual = Me.grdTransferenciasTablas.FocusedRowHandle
                        blnAnulada = Convert.ToInt32(Me.DtTransferencias.DefaultView.Item(FilaActual)("objEstadoID").ToString) = Me.IdEstadoAnulada
                        Imprimir_Despacho(objTransfEditar.IdSivTransferencia, blnAnulada)
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region " Despachar transferencia"
    ''' <summary>
    ''' Procedimiento encargado de despachar una solicitud transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DespacharTransferencia()
        Dim objTransfDesp As New frmSivDespTransferenciaDesp
        Dim iIndiceRegistro As Integer
        Dim blnAnulada As Boolean
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdTransferenciasTablas.FocusedRowHandle
            objTransfDesp.TypeGui = DESPACHAR
            objTransfDesp.IdSivTransferencia = Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID").ToString)
            If objTransfDesp.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargaDatos()
                If (Me.DtTransferencias.Rows.Count <> 0) Then
                    iIndiceRegistro = Me.DtTransferencias.DefaultView.Find(objTransfDesp.IdSivTransferencia)
                    Me.DtTransferencias.DefaultView.Find(iIndiceRegistro)
                    If MsgBox("¿Desea imprimir el despacho de transferencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                        blnAnulada = Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjEstadoID").ToString) = Me.IdEstadoAnulada
                        Imprimir_Despacho(objTransfDesp.IdSivTransferencia, blnAnulada)
                    End If
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
        Dim objSivBodegaProductos As New SivBodegaProductos
        Dim strFiltro As String
        Dim dtDetalleTransf As DataTable
        Dim objSitioOrigenID As Integer
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdTransferenciasTablas.FocusedRowHandle
                If MsgBox("¿Seguro que desea anular el despacho de transferencia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    T.BeginTran()
                    With objTransf
                        .Retrieve(SivTransferenciaID, T)
                        .ObjEstadoID = Me.IdEstadoAnulada
                        .costototal = 0
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor
                        .Update(T)
                    End With

                    strFiltro = "objTransferenciaID=" + SivTransferenciaID.ToString + " AND ObjBodegaDestinoID=" + ObjTiendaDestinoID.ToString
                    dtDetalleTransf = SivTransferenciaDetalle.RetrieveDT(strFiltro, , , T)

                    'Obtener sitio Origen
                    If Not IsDBNull((Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaOrigenID"))) And Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaOrigenID").ToString.Trim.Length <> 0 Then
                        objSitioOrigenID = Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaOrigenID").ToString)
                    Else
                        T.RollbackTran()
                        Exit Function
                    End If
                    'Disminuir la cantidad Tránsito que había sido afectada por este despacho de transferencia
                    For Each row As DataRow In dtDetalleTransf.Rows
                        If Not IsDBNull(row("objSivProductoID")) Then
                            objSivBodegaProductos.Retrieve(row("objSivProductoID"), objSitioOrigenID, T)
                            If Not IsDBNull(row("CantidadDespachada")) And row("CantidadDespachada").ToString.Trim.Length <> 0 Then
                                If objSivBodegaProductos.CantidadTransito.HasValue Then
                                    objSivBodegaProductos.CantidadTransito = objSivBodegaProductos.CantidadTransito.Value - Integer.Parse(row("CantidadDespachada"))
                                    objSivBodegaProductos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                    objSivBodegaProductos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                    objSivBodegaProductos.Update(T)
                                End If
                            End If
                        End If
                    Next

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
                    SivTransferenciaDetalle.BatchUpdate(dtDetalleTransf.DataSet, T)

                    T.CommitTran()
                    MsgBox("Despacho de transferencia anulada con éxito.", MsgBoxStyle.Information)

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

#Region "Consultar despachos transferencia"
    Private Sub Consultar_SolicitudTransf()
        Dim objFormSoliTransDesp As frmSivDespTransferenciaDesp
        Try
            objFormSoliTransDesp = New frmSivDespTransferenciaDesp
            With objFormSoliTransDesp
                .TypeGui = CONSULTAR
                .IdSivTransferencia = Me.IdSivTransferencia
                .ShowDialog(Me)
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Imprimir despachos de transferencia"
    'Procedimiento que imprime varios despachos de acuerdo al filtro seleccionado por el usuario
    Public Sub Imprimir_despachosTransferencias()
        Dim objParamReporte As New frmReportesTransferencias
        objParamReporte.FormLlamado = Me.Name
        objParamReporte.ShowDialog()
    End Sub

    'Procedimiento que imprime UN sólo despacho después que se ha registrado en el sistema.
    Private Sub Imprimir_Despacho(ByVal iIdTransferencia As Integer, ByVal EstadoAnulada As Boolean)
        Dim objRptSoliTransf As New rptTransferenciaDespacho
        Dim objImpresion As frmOpcionesImpresion
        Dim sSQL, sCampos, sFiltro As String

        objImpresion = New frmOpcionesImpresion
        If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sFiltro = "SivTransferenciaID=" + iIdTransferencia.ToString
            sCampos = "ClaveSitios, SivProductoID, Producto, CantidadSolicitada, ObjBodegaOrigenID, ObjBodegaDestinoID, SolicitadoPor, Fechasolicitud, ObjEstadoID, EstadoTransferencia, Observaciones, SivTransferenciaID, SitioDestino, SitioOrigen, Anulada, CodigoTiendaDestino, CodigoTiendaOrigen, Fechadespacho, DespachadoPor, CantidadDespachada"
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaDespacho", sFiltro)

            objRptSoliTransf.EstadoAnulada = EstadoAnulada
            objRptSoliTransf.DataSource = SqlHelper.ExecuteQueryDT(sSQL)
            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(objRptSoliTransf)
                Case 2
                    clsProyecto.ImprimirEnImpresora(objRptSoliTransf, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(objRptSoliTransf, Me)
            End Select
        End If
    End Sub
#End Region

#End Region

#Region "Bloquear botones barra"
    Private Sub bloquearBotonesBarra(ByVal bValor As Boolean)
        Me.cmdDespachar.Enabled = (Not bValor) And Me.blnDespachar
        Me.cmdAnularSolicitud.Enabled = (Not bValor) And Me.blnAnular
        Me.cmdConsultarSolicitud.Enabled = (Not bValor) And Me.blnConsultar
        Me.cmdImprimir.Enabled = (Not bValor) And Me.blnImprimir
    End Sub
#End Region

#Region "Eventos de controles"
    
    Private Sub cmdAgregarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarSolicitud.Click
        Me.Nuevo_DespachoTransf()
    End Sub

    Private Sub cmdAnularSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnularSolicitud.Click
        Dim iIndiceRegistro, SivTransferenciaID, objTiendaDestinoID As Integer
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdTransferenciasTablas.FocusedRowHandle
            If Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID").ToString.Trim.Length <> 0 And Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaDestinoID").ToString.Trim.Length <> 0 Then
                SivTransferenciaID = Convert.ToInt32(Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID").ToString)
                objTiendaDestinoID = Convert.ToInt32(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaDestinoID").ToString)

                Dim Trans As New SivTransferencia
                Trans.Retrieve(SivTransferenciaID)
                If Trans.ObjEstadoID = Me.IdEstadoAnulada Then
                    MsgBox("La trasferencia seleccionada ya ha sido anulada, favor refrescar datos.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Else
                    If Me.Anular_SolicitudTransf(SivTransferenciaID, Convert.ToInt32(Me.DtTransferencias.DefaultView.Item(FilaActual)("ObjBodegaDestinoID").ToString)) Then
                        Me.CargaDatos()
                        If (Me.DtTransferencias.Rows.Count <> 0) Then
                            iIndiceRegistro = Me.DtTransferencias.DefaultView.Find(SivTransferenciaID)
                            Me.DtTransferencias.DefaultView.Find(iIndiceRegistro)

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
            FilaActual = Me.grdTransferenciasTablas.FocusedRowHandle
            If Me.grdTransferenciasTablas.RowCount > 0 Then
                Try
                    Me.IdSivTransferencia = Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID").ToString)
                    Me.Consultar_SolicitudTransf()
                Catch ex As Exception
                    clsError.CaptarError(ex)
                End Try
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

    Private Sub cmdDespachar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDespachar.Click
        Me.DespacharTransferencia()
    End Sub

    Private Sub cmdImprimirSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirSeleccion.Click
        Dim blnAnulada As Boolean
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdTransferenciasTablas.FocusedRowHandle
            blnAnulada = Convert.ToInt32(Me.DtTransferencias.DefaultView.Item(FilaActual)("objEstadoID")) = Me.IdEstadoAnulada
            Imprimir_Despacho(Convert.ToInt32(Me.DtTransferencias.DefaultView.Item(FilaActual)("SivTransferenciaID")), blnAnulada)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
       
    End Sub

    Private Sub cmdImprimirFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirFiltro.Click
        Try
            Me.Imprimir_despachosTransferencias()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


    Private Sub grdTransferenciasTablas_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdTransferenciasTablas.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdTransferenciasTablas.FocusedRowHandle
            If Me.DtTransferencias.DefaultView.Item(FilaActual)("objEstadoID").ToString.Trim.Length <> 0 Then
                Me.cmdAnularSolicitud.Enabled = Me.blnAnular And Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("objEstadoID")) = Me.IdEstadoDespachada
                Me.cmdDespachar.Enabled = Me.blnDespachar And Integer.Parse(Me.DtTransferencias.DefaultView.Item(FilaActual)("objEstadoID")) = Me.IdEstadoSolicitada
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

End Class