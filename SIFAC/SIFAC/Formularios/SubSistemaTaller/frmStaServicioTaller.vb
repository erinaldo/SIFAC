Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO

''' <summary>
''' Formulario Principal de Mantenimiento de Servicios de taller
''' Autor : Gelmin Martínez
''' Fecha :04 de Agosto de 2010, 04:30 pm.
''' </summary>
Public Class frmStaServicioTaller

#Region "Atributos"

    Private dtServiciosTaller As DataTable
    Public Shared glb_IdEstadoRecibida As Integer
    Public Shared glb_IdEstadoEntregada As Integer
    Private SucursalSessionID As Integer
    Private SucursalCentralID As Integer

    ' Variables para control de seguridad
    Private blnAgregar As Boolean
    Private blnFinalizar As Boolean
    Private blnSolicitaRepuesto As Boolean
    Private blnConsultar As Boolean
    Private blnImprimir As Boolean
    Private blnModificarEntrega As Boolean
#End Region

#Region "Constantes"
    Public Const AGREGACION = 0
    Public Const FINALIZACION = 1 '(Entrega de la moto)
    Public Const CONSULTA = 2
    Public Const SOLICITUDREPUESTO = 3
    Public Const MODIFICARENTREGA = 4
#End Region

#Region "Cargar Datos"
    Private Sub CargarDatos()
        Dim strCampos, strSQL, strFiltro As String

        'Cargar ordenes de servicio
        strCampos = "StaServicioTallerID, NumeroServicio, objClienteID, Cliente, Tecnico, TipoServicio, " + _
                    "objTipoServicioID, CONVERT(VARCHAR,FechaRecibida,103) AS FechaRecibida, " + _
                    "objEstadoServicioID, EstadoServicio, objTecnicoAsignadoID, ModeloChasisMoto," + _
                    "objServicioTiendaID, NombreServicioTienda"

        'Sólo CENTRAL ve todos los servicios
        If Me.SucursalSessionID <> Me.SucursalCentralID Then
            strFiltro = " objServicioTiendaID = " & Me.SucursalSessionID
        Else
            strFiltro = "1=1"
        End If

        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "vwStaServiciosTaller", strFiltro)
        Me.dtServiciosTaller = SqlHelper.ExecuteQueryDT(strSQL)
        Me.grdServiciosTaller.SetDataBinding(Me.dtServiciosTaller, "", True)
        Me.grdServiciosTaller.Caption = " Servicios de taller (" + Me.grdServiciosTaller.RowCount.ToString + ")"

        'Formatear los grid principal
        Me.FormatearGridPrincipal()

        If Me.dtServiciosTaller.Rows.Count = 0 Then
            Me.cmdFinalizar.Enabled = False
            Me.cmdConsultar.Enabled = False
            Me.cmdImprimir.Enabled = False
            Me.cmdSolicitarRepuesto.Enabled = False
            Me.cmdModificarEntrega.Enabled = False
        Else
            Me.cmdAgregar.Enabled = Me.blnAgregar
            Me.cmdConsultar.Enabled = Me.blnConsultar
            Me.cmdImprimir.Enabled = Me.blnImprimir
            'Verificar estado de orden de servicio para habilitar/Deshabilitar Servicio
            Me.VerificarEstadoServicio()
        End If

    End Sub

#End Region

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 04 de Agosto de 2010. 05:34 pm.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSTASERVICIOTALLER"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAgregar = objSeg.TienePermiso("AGREGARSERVICIOTALLER")
            Me.blnFinalizar = objSeg.TienePermiso("FINALIZARSERVICIOTALLER")
            Me.blnConsultar = objSeg.TienePermiso("CONSULTARSERVICIOTALLER")
            Me.blnImprimir = objSeg.TienePermiso("IMPRIMIRSERVICIOTALLER")
            Me.blnSolicitaRepuesto = objSeg.TienePermiso("SOLICITARREPUESTOSERVICIOTALLER")
            Me.blnModificarEntrega = objSeg.TienePermiso("MODIFICARENTREGASERVICIOTALLER")

            'Aplicar permisos a los comandos
            Me.cmdAgregar.Enabled = Me.blnAgregar
            Me.cmdFinalizar.Enabled = Me.blnFinalizar
            Me.cmdConsultar.Enabled = Me.blnConsultar
            Me.cmdImprimir.Enabled = Me.blnImprimir
            Me.cmdModificarEntrega.Enabled = Me.blnModificarEntrega

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Formulario"
    Private Sub frmStaServicioTaller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        glb_IdEstadoRecibida = ClsCatalogos.GetValorCatalogoID("ESTADOSERVICIOTALLER", "RECIBIDA")
        glb_IdEstadoEntregada = ClsCatalogos.GetValorCatalogoID("ESTADOSERVICIOTALLER", "ENTREGADA")

        'Seleccionar sucursal en sessión
        If Not String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            Try
                Me.SucursalSessionID = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
                Me.SucursalCentralID = ClsCatalogos.GetStbTiendaID("C")
            Catch ex As Exception
                MsgBox("La sucursal configurada no es una sucursal de repuestos", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.Close()
            End Try
        Else
            MsgBox("No se ha configurado la sucursal en el utilitario de configuración", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            Me.Close()
        End If

        Me.AplicarSeguridad()
        Me.CargarDatos()
    End Sub
#End Region

#Region "Procedimientos"

#Region "Agregar Servicio de taller"
    ''' <summary>
    ''' Procedimiento encargado de agregar una orden de servicio de taller
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 04 de Agosto de 2010, 05:48 pm.
    ''' </summary>
    Private Sub AgregarServicioTaller()
        Dim objForm As New frmStaServicioTallerEditar
        Dim iIndiceRegistro As Integer

        Try
            objForm.TypeGui = AGREGACION
            If objForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarDatos()
                If (Me.dtServiciosTaller.Rows.Count <> 0) Then
                    Me.dtServiciosTaller.DefaultView.Sort = "StaServicioTallerID"
                    iIndiceRegistro = Me.dtServiciosTaller.DefaultView.Find(objForm.StaServicioTallerID)
                    Me.grdServiciosTaller.Row = iIndiceRegistro
                    If MsgBox("¿Desea imprimir la Hoja de Recepción de moto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                        Me.ImprimirOrdenServicioSeleccionado(objForm.StaServicioTallerID, "RECEPCION")
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Finalizar servicio taller"
    ''' <summary>
    ''' Procedimiento encargado de finalizar (Entregar la moto) una orden de servico
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 04 de Agosto de 2010, 05:51 pm.
    ''' </summary>
    Private Sub FinalizarServicioTaller(ByVal intOpcion As Integer)
        Dim objForm As New frmStaServicioTallerEditar
        Dim iIndiceRegistro As Integer
        Dim IdSucursalServicio, IdServicio As Integer

        If Not IsDBNull(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value) AndAlso Me.grdServiciosTaller.Columns("StaServicioTallerID").Value.ToString.Trim.Length <> 0 Then
            IdServicio = Integer.Parse(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value)
            If Not IsDBNull(Me.grdServiciosTaller.Columns("objServicioTiendaID").Value) AndAlso Me.grdServiciosTaller.Columns("objServicioTiendaID").Value.ToString.Trim.Length <> 0 Then
                IdSucursalServicio = Integer.Parse(Me.grdServiciosTaller.Columns("objServicioTiendaID").Value)
            End If
            If Me.SucursalSessionID = IdSucursalServicio Then

                Try
                    If intOpcion = 1 Then 'Si la opción es 1 entonces finalizar entrega de moto.
                        objForm.TypeGui = FINALIZACION
                        objForm.StaServicioTallerID = IdServicio
                        If objForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                            Me.CargarDatos()
                            If (Me.dtServiciosTaller.Rows.Count <> 0) Then
                                Me.dtServiciosTaller.DefaultView.Sort = "StaServicioTallerID"
                                iIndiceRegistro = Me.dtServiciosTaller.DefaultView.Find(objForm.StaServicioTallerID)
                                Me.grdServiciosTaller.Row = iIndiceRegistro
                                If MsgBox("¿Desea imprimir los datos de la HOJA de ENTREGA?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                                    Me.ImprimirOrdenServicioSeleccionado(objForm.StaServicioTallerID, "ENTREGA")
                                End If
                            End If
                        End If
                    ElseIf intOpcion = 2 Then 'Si intOpcion = 2 entonces es modificar Entrega moto.
                        objForm.TypeGui = MODIFICARENTREGA
                        objForm.StaServicioTallerID = IdServicio
                        objForm.ShowDialog()
                    End If
                Catch ex As Exception
                    clsError.CaptarError(ex)
                End Try
            Else
                MsgBox("No es posible Modificar Entrega de moto desde otra sucursal que no sea la que ha dado el servicio de taller.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            End If
        End If ' If Not IsDBNull ...
    End Sub
#End Region

#Region "Solicitar Repuesto"
    ''' <summary>
    ''' Procedimiento encargado solicitar un repuesto para un servicio 
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 11 de Agosto de 2010, 01:38 pm.
    ''' </summary>
    Private Sub SolicitarRepuesto()
        Dim objForm As New frmStaServicioTallerEditar
        Dim strSQL As String
        Dim strNumeroServicio As String
        Dim IdServicio, IdSucursalServicio As Integer
        If Not IsDBNull(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value) AndAlso Me.grdServiciosTaller.Columns("StaServicioTallerID").Value.ToString.Trim.Length <> 0 Then
            IdServicio = Integer.Parse(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value)
            strNumeroServicio = Me.grdServiciosTaller.Columns("NumeroServicio").Value.ToString
            If Not IsDBNull(Me.grdServiciosTaller.Columns("objServicioTiendaID").Value) AndAlso Me.grdServiciosTaller.Columns("objServicioTiendaID").Value.ToString.Trim.Length <> 0 Then
                IdSucursalServicio = Integer.Parse(Me.grdServiciosTaller.Columns("objServicioTiendaID").Value)
            End If

            If Me.SucursalSessionID = IdSucursalServicio Then
                Try
                    'Verificar si el servicio seleccionado es un servicio en Garantía
                    strSQL = clsConsultas.ObtenerConsultaGeneral(" COUNT(StaServicioTallerID) as Cantidad", "StaServicioTaller", " StaServicioTallerID=" & IdServicio.ToString & " AND ServicioGarantia=1 ")
                    If SqlHelper.ExecuteQueryDT(strSQL).DefaultView.Item(0)("Cantidad") > 0 Then
                        objForm.TypeGui = SOLICITUDREPUESTO
                        objForm.StaServicioTallerID = IdServicio
                        objForm.ShowDialog(Me)
                    Else
                        'RellenarConCeros(IdServicio.ToString, ClsCatalogos.GetValorParametro("CantidadDigitosServicioTaller"))
                        MsgBox("El servicio No. " & strNumeroServicio & " No es un servicio por Garantía.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    End If
                Catch ex As Exception
                    clsError.CaptarError(ex)
                End Try
            Else
                MsgBox("El servicio No. " & strNumeroServicio & " No pertenece a la sucursal en sesión.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            End If
        End If
    End Sub
#End Region

#Region "Consultar servicio taller"
    ''' <summary>
    ''' Procedimiento encargado de Consultar una orden de servicio de taller
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 04 de Agosto de 2010, 05:56 pm.
    ''' </summary>
    Private Sub ConsultarServicioTaller()
        Dim objForm As New frmStaServicioTallerEditar
        If Not IsDBNull(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value) AndAlso Me.grdServiciosTaller.Columns("StaServicioTallerID").Value.ToString.Trim.Length <> 0 Then
            Dim IdServicio As Integer = Integer.Parse(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value)

            Try
                objForm.TypeGui = CONSULTA
                objForm.StaServicioTallerID = IdServicio
                objForm.ShowDialog()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        End If
    End Sub
#End Region

#Region "Imprimir Servicio de taller"
    ''' <summary>
    ''' Procedimiento encargado de Imprimir hoja entrega
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 04 de Agosto de 2010, 06:02 pm.
    ''' </summary>
    Private Sub ImprimirOrdenServicioSeleccionado(ByVal StaServicioTallerID As Integer, ByVal TipoHoja As String)
        Dim Visor As New frmVisorRS
        Dim sFiltro, sCampos, sSQL As String
        Dim strNombreReporte As String = String.Empty
        Dim dtDatos As DataTable
        Dim dtDatosRepuestos As DataTable

        If TipoHoja.ToUpper.Equals("RECEPCION") Then
            strNombreReporte = "SCCUM.rptTallerHojaRecepcionMoto.rdlc"
        ElseIf TipoHoja.ToUpper.Equals("ENTREGA") Then
            strNombreReporte = "SCCUM.rptTallerHojaEntregaMoto.rdlc"
        End If

        sFiltro = "StaServicioTallerID=" + StaServicioTallerID.ToString
        sCampos = "StaServicioTallerID, NumeroServicio, objClienteID, Cliente, TelefonosCliente, " + _
                  "Tecnico, TipoServicio, objTipoServicioID, FechaRecibida, objEstadoServicioID, " + _
                  "EstadoServicio, objTecnicoAsignadoID, objServicioTiendaID, objSccCuentaID, " + _
                  "objNivelCombustibleID, NivelCombustible, objTipoKilometrajeID, TipoKilometraje, " + _
                  "ValorKilometraje, PlacaMoto, ColorMoto, ServicioGarantia, CantidadServiciosGarantia, " + _
                  "ObservacionesJefeTaller, FallasReportadasCliente, MotoRecibidaDe, CambioAceite, " + _
                  "LimpiezaCarburador, AjusteFrenos, AjusteCadenaSecundaria, ChequeoTiempoEncendido, ChequeoBateria, " + _
                  "RegulacionEmbrague, CalibrarValvulas, EngraseEjeSuspensionTrasera, EngraseEjeDelanteroTrasero, " + _
                  "CambioFricciones, Otros, FechaEntrega, DiagnosticoTaller, Solucion, MotoEntregadaA, CodigoSucursal, " + _
                  "NombreSucursal, ModeloMoto, Chasis, NoMotor, MarcaMoto"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwStaServicioTallerRptHojaRecepcion", sFiltro)
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        With Visor.VisorReportes
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportEmbeddedResource = strNombreReporte
            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtDatosRptHojaRecepcionMoto_vwStaServicioTallerRptHojaRecepcion", dtDatos))
            'Si el reporte es de entrega de moto entonces obtener los repuestos usados en el servicio
            If TipoHoja.ToUpper.Equals("ENTREGA") Then
                dtDatosRepuestos = Me.DevolverRepuestosUtilizados(StaServicioTallerID)
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtDatosRptHojaRecepcionMoto_vwServicioTallerSalidasRepuesto", dtDatosRepuestos))
            End If
            .RefreshReport()
        End With
        Visor.ShowDialog()

    End Sub

    'Función que devuelve los repuestos utilizados en el servicio de taller.
    Private Function DevolverRepuestosUtilizados(ByVal StaServicioTallerID As Integer) As DataTable
        Dim dtDatosRepuestos As New DataTable
        Dim sFiltro, sCampos, sSQL As String

        Try
            sFiltro = "objServicioTallerID=" + StaServicioTallerID.ToString
            sCampos = "SivRepuestoID, DescripcionCorta, Cantidad, costo, SubTotal, FechaSalida, objTiendaID, objTipoSalidaID, objServicioTallerID, objSalidaBodegaID, objEstadoID, EstadoSalida, Precio"
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwServicioTallerSalidasRepuesto", sFiltro)
            dtDatosRepuestos = SqlHelper.ExecuteQueryDT(sSQL)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

        Return dtDatosRepuestos
    End Function

#End Region

#End Region

#Region "Eventos de controles"
    Private Sub grdServiciosTaller_FilterChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdServiciosTaller.FilterChange
        Me.grdServiciosTaller.Caption = " Servicios de taller (" & Me.grdServiciosTaller.RowCount & ")"
        If Me.grdServiciosTaller.RowCount = 0 Then
            Me.cmdFinalizar.Enabled = False
            Me.cmdConsultar.Enabled = False
            Me.cmdImprimir.Enabled = False
        Else
            Me.cmdAgregar.Enabled = Me.blnAgregar
            'Verificar estado de orden de servicio
            If Not IsDBNull(grdServiciosTaller.Columns("objEstadoServicioID").Value) AndAlso grdServiciosTaller.Columns("objEstadoServicioID").Value.ToString.Trim.Length <> 0 Then
                Me.cmdFinalizar.Enabled = Me.blnFinalizar And (grdServiciosTaller.Columns("objEstadoServicioID").Value = glb_IdEstadoRecibida)
            End If
            Me.cmdConsultar.Enabled = Me.blnConsultar
            Me.cmdImprimir.Enabled = Me.blnImprimir
        End If
    End Sub

    Private Sub grdServiciosTaller_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdServiciosTaller.RowColChange
        Me.VerificarEstadoServicio()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Me.AgregarServicioTaller()
    End Sub

    Private Sub cmdFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinalizar.Click
        Me.FinalizarServicioTaller(1) '1=Finalizar orden servicio
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Me.ConsultarServicioTaller()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Me.CargarDatos()
    End Sub

    Private Sub cmdImprimirRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirRecepcion.Click
        If Not IsDBNull(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value) AndAlso Me.grdServiciosTaller.Columns("StaServicioTallerID").Value.ToString.Trim.Length <> 0 Then
            Try
                Dim IdServicio As Integer = Integer.Parse(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value)
                Me.ImprimirOrdenServicioSeleccionado(IdServicio, "RECEPCION")
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        End If
    End Sub

    Private Sub cmdImprimirEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirEntrega.Click
        If Not IsDBNull(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value) AndAlso Me.grdServiciosTaller.Columns("StaServicioTallerID").Value.ToString.Trim.Length <> 0 Then
            Try
                Dim IdServicio As Integer = Integer.Parse(Me.grdServiciosTaller.Columns("StaServicioTallerID").Value)
                Me.ImprimirOrdenServicioSeleccionado(IdServicio, "ENTREGA")
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        End If
    End Sub

    Private Sub cmdSolicitarRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSolicitarRepuesto.Click
        Me.SolicitarRepuesto()
    End Sub

    Private Sub cmdModificarEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarEntrega.Click
        'Modificar entrada hace lo mismo que Finalizar servicio de taller pero desde botón diferente
        'por motivos de permisos de modificación.
        Me.FinalizarServicioTaller(2) '2=Modificar datos de entrada
    End Sub

#End Region

#Region "Formatear grid"
    Private Sub FormatearGridPrincipal()
        'Grid de Servicios
        With Me.grdServiciosTaller

            'StaServicioTallerID, objClienteID, Cliente, Tecnico, TipoServicio, objTipoServicioID, FechaRecibida, objEstadoServicioID, EstadoServicio, objTecnicoAsignadoID, ModeloChasisMoto, objServicioTiendaID
            .Splits(0).DisplayColumns("objClienteID").Visible = False
            .Splits(0).DisplayColumns("objTipoServicioID").Visible = False
            .Splits(0).DisplayColumns("objEstadoServicioID").Visible = False
            .Splits(0).DisplayColumns("objTecnicoAsignadoID").Visible = False
            .Splits(0).DisplayColumns("StaServicioTallerID").Visible = False
            .Splits(0).DisplayColumns("objServicioTiendaID").Visible = False

            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .AllowSort = True
            .AllowColMove = True
            .ExtendRightColumn = True
            .FilterActive = True
            .FilterBar = True
        End With
    End Sub
#End Region

#Region "Verificar estado servicio"
    Private Sub VerificarEstadoServicio()
        Try
            If Me.dtServiciosTaller.Rows.Count <> 0 Then
                If Not IsDBNull(grdServiciosTaller.Columns("objEstadoServicioID").Value) AndAlso grdServiciosTaller.Columns("objEstadoServicioID").Value.ToString.Trim.Length <> 0 Then
                    Me.cmdFinalizar.Enabled = Me.blnFinalizar AndAlso (grdServiciosTaller.Columns("objEstadoServicioID").Value = glb_IdEstadoRecibida)
                    Me.cmdSolicitarRepuesto.Enabled = Me.blnSolicitaRepuesto AndAlso (grdServiciosTaller.Columns("objEstadoServicioID").Value = glb_IdEstadoRecibida)
                    Me.cmdModificarEntrega.Enabled = Me.blnModificarEntrega AndAlso (grdServiciosTaller.Columns("objEstadoServicioID").Value = glb_IdEstadoEntregada)
                    Me.cmdImprimirRecepcion.Enabled = Me.blnImprimir And Me.cmdFinalizar.Enabled
                    Me.cmdImprimirEntrega.Enabled = Me.blnImprimir AndAlso (grdServiciosTaller.Columns("objEstadoServicioID").Value = glb_IdEstadoEntregada)
                End If
            End If
        Catch ex As Exception
            Me.cmdFinalizar.Enabled = False
        End Try
    End Sub
#End Region

End Class