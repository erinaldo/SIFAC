'-- Autor: Gelmin Martínez
'-- Fecha: 08 Junio 2010, 04:52 pm.
'-- Formulario para seleccionar parámetros de filtrado del reporte de Solicitudes, despachos, recepción 
'-- de transferencias de repuestos.

Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos

Public Class frmReportesTransferencias

#Region "Atributos"
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer
    Private m_IdEstadoSolicitada As Integer
    Private m_IdEstadoDespachada As Integer
    Private m_IdEstadoRecibida As Integer
    Private m_FormLlamado As String
#End Region

#Region "Propiedades"

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
            IdEstadoSolicitada = Me.m_IdestadoSolicitada
        End Get
        Set(ByVal value As Integer)
            Me.m_IdestadoSolicitada = value
        End Set
    End Property

    Property FormLlamado() As String
        Get
            FormLlamado = Me.m_FormLlamado
        End Get
        Set(ByVal value As String)
            Me.m_FormLlamado = value
        End Set
    End Property

    Property IdEstadoDespachada() As Integer
        Get
            IdEstadoDespachada = Me.m_IdEstadoDespachada
        End Get
        Set(ByVal value As Integer)
            Me.m_IdEstadoDespachada = value
        End Set
    End Property

    Property IdEstadoRecibida() As Int16
        Get
            IdEstadoRecibida = Me.m_IdEstadoRecibida
        End Get
        Set(ByVal value As Int16)
            Me.m_IdEstadoRecibida = value
        End Set
    End Property

#End Region

#Region "Cargar combos"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de sitio Origen
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Mayo de 2010, 11:20 am.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboSitioOrigen()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbBodegas.RetrieveDT("1=1", "Nombre", "StbBodegaID,Codigo, Nombre")
            With Me.cmbSitioOrigen
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbBodegaID"
                .Splits(0).DisplayColumns("StbBodegaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 30
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtDatos.Rows.Add("0", "-", "TODOS")
            Me.cmbSitioOrigen.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de sitio Destino
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Mayo de 2010, 11:20 am.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboSitioDestino()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbBodegas.RetrieveDT("1=1", "Nombre", "StbBodegaID,Codigo, Nombre")
            With Me.cmbSitioDestino
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbBodegaID"
                .Splits(0).DisplayColumns("StbBodegaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 30
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtDatos.Rows.Add("0", "-", "TODOS")
            Me.cmbSitioDestino.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de estado de solicitud de transferencia
    ''' Autor : Gelmin Martinez
    ''' Fecha 07 de junio de 2010, 06:22 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboEstados()
        Dim dtDatos As New DataTable
        Try
            dtDatos = ClsCatalogos.GetValoresCatalogo("ESTADOSTRANSFERENCIA", "StbValorCatalogoID, Descripcion", "Descripcion")

            With Me.cmbEstados
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Width = 30
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar Formulario"
    Private Sub frmReporteSolicitudesTransf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.IdEstadoSolicitada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "01") '01=Solicitada
        Me.IdEstadoDespachada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "02") '02=Despachada
        Me.IdEstadoRecibida = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "03") '03=Recibida

        Me.CargarComboSitioDestino()
        Me.CargarComboSitioOrigen()
        Me.CargarComboEstados()
        Me.VerificarSucursalRepuesto()

        Me.cmbEstados.Enabled = False

        If Me.FormLlamado.Equals(frmSivSoliTransferencia.Name) Then
            Me.Text = "Reporte de solicitudes de traslados"
            Me.cmbEstados.SelectedValue = Me.IdEstadoSolicitada
            Me.cmbSitioDestino.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral

        ElseIf Me.FormLlamado.Equals(frmSivDespTransferencia.Name) Then
            Me.cmbEstados.SelectedValue = Me.IdEstadoDespachada
            Me.Text = "Reporte de despacho de traslados"
            Me.cmbSitioOrigen.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral

        ElseIf Me.FormLlamado.Equals(frmSivRecepTransferencia.Name) Then
            Me.Text = "Reporte de recepción de traslados"
            Me.cmbEstados.SelectedValue = Me.IdEstadoRecibida
            Me.cmbSitioDestino.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral
        ElseIf Me.FormLlamado.Equals(frmSivRecepTransferencia.Name + "1") Then
            Dim punto As New Point
            Dim tamano As New Size
            Me.Text = "Reporte de Diferencias en la Recepción"
            Me.cmbEstados.Visible = False
            Me.lblEstado.Visible = False
            Me.cmbSitioDestino.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral
            'no mostrar combobox estado
            tamano.Height = 107
            tamano.Width = Me.gbxCriterio.Size.Width
            punto.X = 182
            punto.Y = 310 '274
            'Reducir tamaño groupbox
            Me.gbxCriterio.Size = tamano
            'Mover botones un poco hacia arriba
            Me.cmdAceptar.Location = punto
            punto.X = 310 '262
            Me.cmdCancelar.Location = punto
            'Redimencionar formulario
            tamano.Height = 430 '366
            tamano.Width = Me.Width
            Me.Size = tamano
        End If
    End Sub

#End Region

#Region "Eventos controles"
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Imprimir()
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged, dtpFechaHasta.TabIndexChanged
        Me.ErrProveedor.Clear()
    End Sub
#End Region

#Region "Validaciones"
    Private Function ValidacionParametros() As Boolean
        Dim blnValido As Boolean = True

        'Verificar período vacío
        If Me.dtpFechaDesde.Value.ToString.Trim.Length = 0 Or Me.dtpFechaHasta.Value.ToString.Trim.Length = 0 Then
            MsgBox("No ha seleccionado un período de tiempo correcto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            If Me.dtpFechaDesde.Value.ToString.Length = 0 Then
                Me.dtpFechaDesde.Focus()
            Else
                Me.dtpFechaHasta.Focus()
            End If
            blnValido = False
            Exit Function
        End If

        'Verificar período
        If Convert.ToDateTime(Me.dtpFechaDesde.Value).Date > Convert.ToDateTime(Me.dtpFechaHasta.Value).Date Then
            Me.ErrProveedor.SetError(Me.dtpFechaDesde, "La fecha desde debe ser menor o igual a fecha hasta.")
            blnValido = False
            Exit Function
        End If

        Return blnValido
    End Function

#End Region

#Region "Verificar Sucursal Repuesto"
    Private Sub VerificarSucursalRepuesto()
        If String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            MsgBox("No ha configurado la sucursal en el utilitario de configuración del sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            If Me.cmbSitioDestino.FindStringExact(Me.IdSucursalSession.ToString, 0, 0) = -1 Then
                MsgBox("La sucursal configurada en la sesión del sistema, no es una sucursal de Productos", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                If Me.FormLlamado.Equals(frmSivSoliTransferencia.Name) Or Me.FormLlamado.Equals(frmSivRecepTransferencia.Name) Or Me.FormLlamado.Equals(frmSivRecepTransferencia.Name + "1") Then
                    Me.cmbSitioDestino.SelectedValue = Me.IdSucursalSession
                ElseIf Me.FormLlamado.Equals(frmSivDespTransferencia.Name) Then
                    Me.cmbSitioOrigen.SelectedValue = Me.IdSucursalSession
                End If
            End If
        End If
    End Sub
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        'Verificar si se han ingresado los datos de parámetros correctamente
        If ValidacionParametros() Then
            If Me.FormLlamado.Equals(frmSivSoliTransferencia.Name) Then
                Me.Imprimir_solicitudesTransf()
            ElseIf Me.FormLlamado.Equals(frmSivDespTransferencia.Name) Then
                Me.Imprimir_DespachosTransf()
            ElseIf Me.FormLlamado.Equals(frmSivRecepTransferencia.Name) Then
                Me.Imprimir_RecepcionesTransf()
            ElseIf Me.FormLlamado.Equals(frmSivRecepTransferencia.Name + "1") Then
                Me.Imprimir_Diferencias()
            End If
        End If
    End Sub

#End Region

#Region "Imprimir Solicitudes"
    'Procedimiento para la impresión de solicitudes de transferencia
    Public Sub Imprimir_solicitudesTransf()
        Dim objRptSolicitudes As New rptTransferenciaSolicitudes
        Dim sSQL, sCampos, sFiltro As String
        Dim dtDatos As DataTable

        'Construir el filtro para las solicitudes (112=Fecha en formato ISO, ejemplo: 09 Junio 2010 = 20100609)
        If Not IsDBNull(dtpFechaDesde.Value) And Not IsDBNull(dtpFechaHasta.Value) Then
            sFiltro = "(CONVERT(VARCHAR,Fechasolicitud,112) >='" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "' AND CONVERT(VARCHAR,Fechasolicitud,112) <='" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "') AND ObjEstadoID=" + Me.cmbEstados.SelectedValue.ToString
            'Si ha seleccionado Tienda Origen
            If Me.cmbSitioOrigen.SelectedValue <> 0 Then
                sFiltro += " AND ObjBodegaOrigenID=" + Me.cmbSitioOrigen.SelectedValue.ToString
            End If
            'Si ha seleccionado tienda Destino
            If Me.cmbSitioDestino.SelectedValue <> 0 Then
                sFiltro += " AND ObjBodegaDestinoID=" + Me.cmbSitioDestino.SelectedValue.ToString
            End If
        Else
            sFiltro = "1=0"
        End If

        'Obtener datos para la generación del reporte
        sCampos = "ClaveSitios, CodigoTiendaOrigen, CodigoTiendaDestino, SivProductoID, " + _
                  "Producto, CantidadSolicitada, " + _
                  "ObjBodegaOrigenID, ObjBodegaDestinoID, SolicitadoPor, Fechasolicitud, ObjEstadoID," + _
                  "EstadoTransferencia, Observaciones, SivTransferenciaID, SitioDestino, SitioOrigen, Anulada"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaSolicitud", sFiltro + " ORDER BY SitioOrigen, SivTransferenciaID, SivProductoID")
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        'Si hay resultados mostrar opciones para mostrar informe
        'If dtDatos.Rows.Count <> 0 Then
        objRptSolicitudes.DataSource = dtDatos
        Me.OpcionesImpresion(objRptSolicitudes)
        'Else
        'MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        'End If
    End Sub

#End Region

#Region "Imprimir Despachos"
    'Procedimiento para la impresión de despachos de transferencia
    Public Sub Imprimir_DespachosTransf()
        Dim objRptTransf As New rptTransferenciaDespachos
        Dim sSQL, sCampos, sFiltro As String
        Dim dtDatos As DataTable

        'Construir el filtro para los despachos (112=Fecha en formato ISO, ejemplo: 09 Junio 2010 = 20100609)
        If Not IsDBNull(dtpFechaDesde.Value) And Not IsDBNull(dtpFechaHasta.Value) Then
            sFiltro = "(CONVERT(VARCHAR,Fechadespacho,112) >='" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "' AND CONVERT(VARCHAR,Fechadespacho,112) <='" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "') AND ObjEstadoID=" + Me.cmbEstados.SelectedValue.ToString

            'Si ha seleccionado Tienda Origen
            If Me.cmbSitioOrigen.SelectedValue <> 0 Then
                sFiltro += " AND ObjBodegaOrigenID=" + Me.cmbSitioOrigen.SelectedValue.ToString
            End If
            'Si ha seleccionado tienda Destino
            If Me.cmbSitioDestino.SelectedValue <> 0 Then
                sFiltro += " AND ObjBodegaDestinoID=" + Me.cmbSitioDestino.SelectedValue.ToString
            End If

        Else
            sFiltro = "1=0"
        End If

            'Obtener datos para la generación del reporte
        sCampos = "ClaveSitios, SivProductoID, Producto, " + _
                  "CantidadSolicitada, ObjBodegaOrigenID, ObjBodegaDestinoID, SolicitadoPor, " + _
                  "Fechasolicitud, ObjEstadoID, EstadoTransferencia, Observaciones, SivTransferenciaID, " + _
                  "SitioDestino, SitioOrigen, Anulada, CodigoTiendaDestino, CodigoTiendaOrigen, " + _
                  "Fechadespacho, DespachadoPor, CantidadDespachada"

        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaDespacho", sFiltro + " ORDER BY SitioDestino, SivTransferenciaID, SivProductoID")
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        If dtDatos.Rows.Count <> 0 Then
            objRptTransf.DataSource = dtDatos
            Me.OpcionesImpresion(objRptTransf)
        Else
            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If
    End Sub

#End Region

#Region "Imprimir Recepciones"
    'Procedimiento para la impresión de recepciones de transferencia
    Public Sub Imprimir_RecepcionesTransf()
        Dim objRptTransf As New rptTransferenciaRecepciones
        Dim sSQL, sCampos, sFiltro As String
        Dim dtDatos As DataTable

        'Construir el filtro para las recepciones (112=Fecha en formato ISO, ejemplo: 09 Junio 2010 = 20100609)
        If Not IsDBNull(dtpFechaDesde.Value) And Not IsDBNull(dtpFechaHasta.Value) Then
            sFiltro = "(CONVERT(VARCHAR,Fecharecibido,112) >='" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "' AND CONVERT(VARCHAR,Fecharecibido,112) <='" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "') AND ObjEstadoID=" + Me.cmbEstados.SelectedValue.ToString
           
            'Si ha seleccionado Tienda Origen
            If Me.cmbSitioOrigen.SelectedValue <> 0 Then
                sFiltro += " AND ObjBodegaOrigenID=" + Me.cmbSitioOrigen.SelectedValue.ToString
            End If
            'Si ha seleccionado tienda Destino
            If Me.cmbSitioDestino.SelectedValue <> 0 Then
                sFiltro += " AND ObjBodegaDestinoID=" + Me.cmbSitioDestino.SelectedValue.ToString
            End If
        Else
            sFiltro = "1=0"
        End If

        'Obtener datos para la generación del reporte
        sCampos = "ClaveSitios, SivProductoID, Producto, " + _
                  "CantidadSolicitada, ObjBodegaOrigenID, ObjBodegaDestinoID, SolicitadoPor, " + _
                  "Fechasolicitud, ObjEstadoID, EstadoTransferencia, Observaciones, SivTransferenciaID, " + _
                  "SitioDestino, SitioOrigen, Anulada, CodigoTiendaDestino, CodigoTiendaOrigen, " + _
                  " Fechadespacho, DespachadoPor, CantidadDespachada, Fecharecibido, RecibidoPor, CantidadRecibida"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaRecepcion", sFiltro + " ORDER BY SitioOrigen, SivTransferenciaID, SivProductoID")
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        If dtDatos.Rows.Count <> 0 Then
            objRptTransf.DataSource = dtDatos
            Me.OpcionesImpresion(objRptTransf)
        Else
            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If
    End Sub
#End Region

#Region "Imprimir Diferencias"
    Public Sub Imprimir_Diferencias()
        Dim objRptTransf As New rptTransferenciaDiferencias
        Dim sSQL, sCampos, sFiltro As String
        Dim dtDatos As DataTable

        'Construir el filtro para las recepciones (112=Fecha en formato ISO, ejemplo: 09 Junio 2010 = 20100609)
        If Not IsDBNull(dtpFechaDesde.Value) And Not IsDBNull(dtpFechaHasta.Value) Then
            sFiltro = "(CONVERT(VARCHAR,Fecharecibido,112) >='" + Format(dtpFechaDesde.Value, "yyyyMMdd") + _
                      "' AND CONVERT(VARCHAR,Fecharecibido,112) <='" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + _
                      "') AND ObjEstadoID=" + Me.IdEstadoRecibida.ToString + _
                      " AND Diferencia > 0 AND Anulada=0"

            'Si ha seleccionado Tienda Origen
            If Me.cmbSitioOrigen.SelectedValue <> 0 Then
                sFiltro += " AND ObjBodegaOrigenID=" + Me.cmbSitioOrigen.SelectedValue.ToString
            End If
            'Si ha seleccionado tienda Destino
            If Me.cmbSitioDestino.SelectedValue <> 0 Then
                sFiltro += " AND ObjBodegaDestinoID=" + Me.cmbSitioDestino.SelectedValue.ToString
            End If
        Else
            sFiltro = "1=0"
        End If

        'Obtener datos para la generación del reporte
        sCampos = "SivProductoID, Producto, CantidadSolicitada, ObjBodegaOrigenID, ObjBodegaDestinoID, Fechasolicitud, ObjEstadoID, Observaciones, SivTransferenciaID, SitioDestino, SitioOrigen, CodigoTiendaDestino, Anulada, CantidadDespachada, CantidadRecibida, Diferencia, Fecharecibido"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptTransferenciaDiferencias", sFiltro + " ORDER BY SivProductoID, Fechasolicitud, SivTransferenciaID")
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        If dtDatos.Rows.Count <> 0 Then
            objRptTransf.DataSource = dtDatos
            Me.OpcionesImpresion(objRptTransf)
        Else
            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If

    End Sub

#End Region

#Region "Opciones de Impresión"
    Private Sub OpcionesImpresion(ByRef Reporte As DataDynamics.ActiveReports.ActiveReport3)
        Dim objImpresion As New frmOpcionesImpresion

        If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With Reporte
                .Parameters("prmFechaDesde").Value = Convert.ToDateTime(Me.dtpFechaDesde.Value).Date
                .Parameters("prmFechaHasta").Value = Convert.ToDateTime(Me.dtpFechaHasta.Value).Date
            End With

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

End Class