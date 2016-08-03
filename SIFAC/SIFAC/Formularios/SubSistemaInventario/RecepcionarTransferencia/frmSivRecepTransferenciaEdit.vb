'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 01 Junio 2010. 06:07 PM.
''-- Formulario de de recepción de transferencia de repuestos.
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles

Public Class frmSivRecepTransferenciaEdit
    'Tipo enumerado para controlar los índices de los campos del grid detalle.
#Region "Tipo Enumerado"
    Public Enum eCamposGrid
        codigo
        descripcion
        marca
        cantidadSolicitada
        cantidadDespachada
        transferenciaID
        marcaId
        objTiendaDestinoID
        cantidadRecibida
    End Enum
#End Region

#Region "Atributos"
    Private m_TypeGui As Integer
    Private m_HuboCambioDetalle As Boolean
    Private m_IdSivTransferencia As Integer
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer

    'Variables lógicas para evitar mostrar dos veces un mismo mensaje en las validaciones del grid
    Private bMostroAvisoDetalle As Boolean = False
    Private bDatosRepuestoCargado As Boolean = False

    Private dtDetalleTransferencia As DataTable 'Mantiene los datos que se guardarán en el detalle Transferencia
    Private dtDatosCombosDetalle As DataTable 'Mantiene los datos que se desplegan en los combos del grid detalle
#End Region

#Region "Constantes"
    'Constantes para el TypeGui
    Private Const RECIBIR = 0
    Private Const CONSULTAR = 2
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

    Property HuboCambioDetalle() As Boolean
        Get
            HuboCambioDetalle = Me.m_HuboCambioDetalle
        End Get
        Set(ByVal value As Boolean)
            Me.m_HuboCambioDetalle = value
        End Set
    End Property

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

#End Region

#Region "Procedimientos generales"

#Region "Cargar datos solicitud transferencia"
    Private Sub CargaDatosSolicitudTransf()
        Dim sSQL, sCampos, sFiltro As String
        Dim dtDatosTransferencia As DataTable
        sCampos = "SivTransferenciaID, ObjTiendaOrigenID, ObjTiendaDestinoID, Observaciones, Fechasolicitud, SolicitadoPor, Fechadespacho, DespachadoPor, Fecharecibido, RecibidoPor"
        sFiltro = "SivTransferenciaID=" + Me.IdSivTransferencia.ToString
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SivTransferencia", sFiltro)

        dtDatosTransferencia = SqlHelper.ExecuteQueryDT(sSQL)
        'Cargar datos del proveedor
        Me.txtNoTransferencia.Text = Me.IdSivTransferencia
        Me.cmbSitioOrigen.SelectedValue = dtDatosTransferencia.DefaultView(0)("ObjTiendaOrigenID")
        Me.cmbSitioDestino.SelectedValue = dtDatosTransferencia.DefaultView(0)("ObjTiendaDestinoID")
        Me.txtObservaciones.Text = dtDatosTransferencia.DefaultView(0)("Observaciones")

        If dtDatosTransferencia.DefaultView(0)("Fechasolicitud").ToString.Length <> 0 Then
            Me.dtpFechaSolicitud.Value = dtDatosTransferencia.DefaultView(0)("Fechasolicitud")
            Me.txtSolicitadoPor.Text = dtDatosTransferencia.DefaultView(0)("SolicitadoPor")
        End If

        If dtDatosTransferencia.DefaultView(0)("FechaDespacho").ToString.Length <> 0 Then
            Me.dtpFechaDespacho.Value = dtDatosTransferencia.DefaultView(0)("FechaDespacho").ToString
            Me.txtDespachadoPor.Text = dtDatosTransferencia.DefaultView(0)("DespachadoPor").ToString
        End If

        If Me.TypeGui = CONSULTAR Then
            If dtDatosTransferencia.DefaultView(0)("Fecharecibido").ToString.Length <> 0 Then
                Me.dtpFechaRecibido.Value = dtDatosTransferencia.DefaultView(0)("Fecharecibido")
                Me.txtRecibidoPor.Text = dtDatosTransferencia.DefaultView(0)("RecibidoPor")
            End If
        End If

        'Cargar el detalle de transferencia
        Me.CargarDetalleTransferencia("objTransferenciaID =" + Me.IdSivTransferencia.ToString)
    End Sub

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
            dtDatos = StbTienda.RetrieveDT("ActivoRepuesto=1", "Nombre", "StbTiendaID,Codigo, Nombre")
            With Me.cmbSitioOrigen
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 30
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

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
            dtDatos = StbTienda.RetrieveDT("ActivoRepuesto=1", "Nombre", "StbTiendaID,Codigo, Nombre")
            With Me.cmbSitioDestino
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 30
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

#Region "Cargar detalle solicitud transferencia"
    Private Sub CargarDetalleTransferencia(ByVal sFiltroTransferencia As String)
        Dim sSQL, sCampos As String

        Try
            If Me.TypeGui = RECIBIR Then 'Modo recepción
                sCampos = "objRepuestoID, DescripcionCorta, Marca, CantidadDespachada, CantidadSolicitada, cast(0 as int) as CantidadRecibida, objTransferenciaID, objMarcaID, objTiendaDestinoID"
            Else
                sCampos = "objRepuestoID, DescripcionCorta, Marca, CantidadDespachada, CantidadSolicitada, CantidadRecibida, objTransferenciaID, objMarcaID, objTiendaDestinoID"
            End If

            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferenciasDet", sFiltroTransferencia)

            Me.dtDetalleTransferencia = SqlHelper.ExecuteQueryDT(sSQL)
            Me.grdDetalleTransferencia.SetDataBinding(Me.dtDetalleTransferencia, "", True)

            If Me.TypeGui = RECIBIR Then 'Modo Recepción
                Me.FormatearGridDetalleParaEdicion()
            Else
                Me.FormatearGridDetalleParaConsulta()
            End If

            Me.HuboCambioDetalle = True
        Catch ex As Exception
            Me.FormatearGridDetalleParaConsulta()
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Recepccionar transferencia"
    Private Function RecibirTransferencia() As Boolean
        Dim T As New TransactionManager
        Dim objTransf As New SivTransferencia
        Dim objSivBodegaRepuesto As New SivBodegaRepuestos
        Dim objSivTranDetalleUpdate As New SivTransferenciaDetalle

        Try
            Try
                T.BeginTran()
                With objTransf
                    .Retrieve(Me.IdSivTransferencia, Integer.Parse(Me.cmbSitioDestino.SelectedValue.ToString), T)
                    .Fecharecibido = Me.dtpFechaRecibido.Value
                    .RecibidoPor = Me.txtRecibidoPor.Text.Trim
                    .ObjEstadoID = frmSivRecepTransferencia.gblEstadoRecibidaID
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .Update(T)
                End With

                'Actualizar detalle de recepción de transferencia                
                Me.grdDetalleTransferencia.UpdateData()
                Me.dtDetalleTransferencia.AcceptChanges()

                For Each row As DataRow In Me.dtDetalleTransferencia.Rows
                    'Actualizar Cantidad Recibida
                    With objSivTranDetalleUpdate
                        .Retrieve(Me.IdSivTransferencia.ToString, Me.cmbSitioDestino.SelectedValue.ToString, row("objRepuestoID"), T)
                        .CantidadRecibida = row("CantidadRecibida")
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .Update(T)
                    End With
                    'Actualizar cantidad en tránsito en SivBodegaRepuesto por cada repuesto
                    With objSivBodegaRepuesto
                        .Retrieve((row("objRepuestoID")), Convert.ToInt32(Me.cmbSitioOrigen.SelectedValue.ToString), T)
                        If .CantidadTransito.HasValue Then
                            .CantidadTransito = objSivBodegaRepuesto.CantidadTransito.Value - Convert.ToInt32(row("CantidadDespachada").ToString)
                        Else
                            .CantidadTransito = 0
                        End If
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor 'Format(clsProyecto.Conexion.FechaServidor, "dd-MM-yyyy")
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .Update(T)
                    End With
                    'Actualizar Cantidad de bodega destino
                    With objSivBodegaRepuesto
                        .Retrieve((row("objRepuestoID")), Convert.ToInt32(Me.cmbSitioDestino.SelectedValue.ToString), T)
                        .Cantidad = objSivBodegaRepuesto.Cantidad + Convert.ToInt32(row("CantidadRecibida").ToString)
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor 'Format(clsProyecto.Conexion.FechaServidor, "dd-MM-yyyy")
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .Update(T)
                    End With

                    'Actualizar Cantidad de bodega Origen
                    With objSivBodegaRepuesto
                        .Retrieve((row("objRepuestoID")), Convert.ToInt32(Me.cmbSitioOrigen.SelectedValue.ToString), T)
                        .Cantidad = objSivBodegaRepuesto.Cantidad - Convert.ToInt32(row("CantidadRecibida").ToString)
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor 'Format(clsProyecto.Conexion.FechaServidor, "dd-MM-yyyy")
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .Update(T)
                    End With
                Next
                
                T.CommitTran()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            objTransf = Nothing
            objSivBodegaRepuesto = Nothing
            objSivTranDetalleUpdate = Nothing
            T = Nothing
        End Try
    End Function
#End Region

#Region "Validaciones de datos"
    Private Function Validaciones() As Boolean
        Try

            If Me.dtDetalleTransferencia.Rows.Count <= 0 Then
                'MsgBox("Debe ingresar al menos un repuesto en detalle de solicitud.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Debe ingresar al menos un repuesto en detalle de transferencia.")
                Return False
                Exit Function
            End If

            If Me.cmbSitioOrigen.SelectedValue = Me.cmbSitioDestino.SelectedValue Then
                'MsgBox("El sitio origen debe ser diferente al sitio destino.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ErrorProvider.SetError(Me.cmbSitioOrigen, "El sitio origen debe ser diferente al sitio destino.")
                Return False
                Exit Function
            End If

            If Not Me.CantidadesRecibidasValidas Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos una cantidad recibida con valor Incorrecto.")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    'Función para validar al escribir en el grid
    Private Function CantidadRecibidaValida() As Boolean
        Dim iCantidadDespachada, iCantidadRecibida As Integer
        Dim bCantidadValida As Boolean = True
        If Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value.ToString.Trim.Length <> 0 Then
            'Cantidad Despachada
            If Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value.ToString.Length <> 0 Then
                iCantidadDespachada = Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value
            Else
                iCantidadDespachada = 0
            End If
            'Cantidad Recibida
            If Me.grdDetalleTransferencia.Columns("CantidadRecibida").Value.ToString.Trim.Length <> 0 Then
                iCantidadRecibida = Me.grdDetalleTransferencia.Columns("CantidadRecibida").Value
            Else
                iCantidadRecibida = 0
            End If

            If iCantidadRecibida > iCantidadDespachada Then
                bCantidadValida = False
            End If
        End If
        Return bCantidadValida
    End Function

    'Función para validar al dar clic en Aceptar
    Private Function CantidadesRecibidasValidas() As Integer
        Dim iCantidadDespachada, iCantidadRecibida As Integer
        Dim bCantidadValida As Boolean = True

        If Me.grdDetalleTransferencia.Splits(0).Rows.Count <> 0 Then
            For i As Integer = 0 To Me.grdDetalleTransferencia.Splits(0).Rows.Count - 1
                If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadDespachada).ToString.Trim) And (Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.codigo).ToString.Trim)) Then
                    'Cantidad Despachada
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadDespachada).ToString.Trim) Then
                        iCantidadDespachada = Integer.Parse(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadDespachada).ToString.Trim)
                    Else
                        iCantidadDespachada = 0
                    End If
                    'Cantidad Recibida
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadRecibida).ToString.Trim) Then
                        iCantidadRecibida = Integer.Parse(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadRecibida).ToString.Trim)
                    Else
                        iCantidadRecibida = 0
                    End If

                    If iCantidadRecibida > (iCantidadDespachada) Then
                        bCantidadValida = False
                    End If
                End If
            Next
        End If
        Return bCantidadValida
    End Function

#End Region

#Region "Validación de Sitios Iguales"
    Private Function SitiosIguales() As Boolean
        If Me.cmbSitioOrigen.SelectedValue = Me.cmbSitioDestino.SelectedValue Then
            Me.ErrorProvider.SetError(Me.cmbSitioDestino, "El sitio destino debe ser diferente al sitio origen.")
            Me.cmbSitioDestino.Focus()
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Formatear grid detalle Edición - Consulta"
    Private Sub FormatearGridDetalleParaEdicion()
        With Me.grdDetalleTransferencia
            .Columns("CantidadRecibida").DataWidth = 9 'un entero tiene precisión 10, escala 0
            .Splits(0).DisplayColumns("objTransferenciaID").Visible = False
            .Splits(0).DisplayColumns("objMarcaID").Visible = False
            .Splits(0).DisplayColumns("objTiendaDestinoID").Visible = False
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
            .DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
            .AllowUpdate = True

            .FilterBar = False
            .AllowSort = False
            .AllowColMove = False
            .AllowDelete = False
            .AllowAddNew = False
            .EmptyRows = False 'no mostrar más filas después de la última
            .Refresh()
        End With
    End Sub

    Private Sub FormatearGridDetalleParaConsulta()
        With Me.grdDetalleTransferencia
            .Splits(0).DisplayColumns("CantidadRecibida").Locked = True
            .Splits(0).DisplayColumns("CantidadRecibida").Style.BackColor = .Splits(0).DisplayColumns("Marca").Style.BackColor

            .Splits(0).DisplayColumns("objTransferenciaID").Visible = False
            .Splits(0).DisplayColumns("objMarcaID").Visible = False
            .Splits(0).DisplayColumns("objTiendaDestinoID").Visible = False

            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee 'no seleccionar registro
            .FilterBar = False 'no mostrar barra de filtro
            '.RecordSelectors = False 'no mostrar selector de registros
            '.AllowAddNew = False
            .AllowUpdate = False
            .AllowDelete = False
            .AllowColMove = False
            '.AllowColSelect = False
            .AllowSort = False
            .EmptyRows = False 'no mostrar más filas vacías después de la última
            .Refresh()
        End With

    End Sub

#End Region

#End Region

#Region "Eventos controles"
    Private Sub frmSivDespTransferenciaEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Me.HuboCambioDetalle And Me.TypeGui = RECIBIR And Me.DialogResult <> Windows.Forms.DialogResult.OK) Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Select Case Me.TypeGui
            Case RECIBIR
                If Me.Validaciones Then
                    If Me.RecibirTransferencia Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
        End Select
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub grdDetalleTransferenica_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
        Me.HuboCambioDetalle = True
    End Sub

    Private Sub txtObservaciones_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyDown

    End Sub

    'Cerrar ventana al presionar Escape si está en modo consulta
    Private Sub frmSivDespTransferenciaDesp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.TypeGui = CONSULTAR Then 'Modo consultar
            If e.KeyValue = Keys.Escape Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

#End Region

#Region "Cargar formulario"
    Private Sub frmSivDespTransferenciaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BloquearControlesPorDefecto()
        clsProyecto.CargarTemaDefinido(Me)
        'Me.txtObservaciones.MaxLength = BO.SivTransferencia.GetMaxLength("Observaciones")
        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.CargarComboSitioOrigen()
        Me.CargarComboSitioDestino()

        Select Case Me.TypeGui
            Case RECIBIR 'Recibir solicitud de transferencia
                Me.Text = "Recibir traslado"
                'Verificar y asignar sucursal logueada en la sesión.
                If String.IsNullOrEmpty(clsProyecto.Sucursal) Then
                    MsgBox("No ha configurado la sucursal en el utilitario de configuración del sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Else
                    If Me.cmbSitioDestino.FindStringExact(Me.IdSucursalSession.ToString, 0, 0) = -1 Then
                        MsgBox("La sucursal configurada en la sesión del sistema, no es una sucursal de Repuestos", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Else
                        Me.cmbSitioDestino.SelectedValue = Me.IdSucursalSession
                    End If
                End If
                Me.CargaDatosSolicitudTransf()
                Me.dtpFechaRecibido.Value = clsProyecto.Conexion.FechaServidor
                Me.txtRecibidoPor.Text = clsProyecto.Conexion.Usuario
                Me.MoverFocoCelda(0, eCamposGrid.cantidadRecibida)

            Case CONSULTAR 'Consultar solicitud de transferencia
                Me.Text = "Consultar traslado"
                Me.CargaDatosSolicitudTransf()
                Me.cmbSitioOrigen.Enabled = False
                Me.txtObservaciones.Enabled = False
                Me.cmdGuardar.Enabled = False

        End Select

        Me.HuboCambioDetalle = False
    End Sub
#End Region

#Region "Bloquear controles por defecto"
    Private Sub BloquearControlesPorDefecto()
        Me.txtNoTransferencia.Tag = "BLOQUEADO"
        Me.txtSolicitadoPor.Tag = "BLOQUEADO"
        Me.txtDespachadoPor.Tag = "BLOQUEADO"
        Me.txtRecibidoPor.Tag = "BLOQUEADO"
        Me.txtObservaciones.Tag = "BLOQUEADO"

        Me.dtpFechaSolicitud.Enabled = False
        Me.dtpFechaDespacho.Enabled = False
        Me.dtpFechaRecibido.Enabled = False
        Me.cmbSitioDestino.Enabled = False
        Me.cmbSitioOrigen.Enabled = False
    End Sub

#End Region

#Region "Validaciones Grid Detalle"

#Region "MoverFocoCelda"
    Private Sub MoverFocoCelda(ByVal fila As Integer, ByVal columna As Integer)
        Me.grdDetalleTransferencia.Focus()
        Me.grdDetalleTransferencia.Row = fila
        Me.grdDetalleTransferencia.Col = columna
    End Sub
#End Region

#Region "Eventos de KeyPress, KeyDown del Grid Detalle"
    'Bloquear para permitir solo números enteros en columna [CantidadRecibida]
    Private Sub grdDetalleTransferencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdDetalleTransferencia.KeyPress
        Try
            If Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadRecibida Then
                If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
                    e.KeyChar = Chr(0)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grdDetalleTransferencia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleTransferencia.KeyDown
        Me.HuboCambioDetalle = True
        Me.ErrorProvider.Clear()

        If Me.TypeGui = CONSULTAR Then 'Modo consultar
            Exit Sub
        End If

        Try
            'Si se presiona Enter y estamos en la columna [cantidadRecepcionada]
            If e.KeyCode = Keys.Enter And Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadRecibida Then
                If Me.grdDetalleTransferencia.RowCount <> 0 Then
                    'Validaciones en la Cantidades Recepcionadas  
                    If Not Me.CantidadRecibidaValida Then
                        Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Cantidad recibida debe ser menor o igual a la cantidad Despachada.")
                        Me.grdDetalleTransferencia.SelectionStart = 0
                        Me.grdDetalleTransferencia.SelectionLength = Me.grdDetalleTransferencia.Columns("CantidadRecibida").Text.Length
                    Else
                        Me.grdDetalleTransferencia.UpdateData()
                        If Me.grdDetalleTransferencia.Row = Me.grdDetalleTransferencia.RowCount - 1 Then
                            Me.grdDetalleTransferencia.MoveFirst()
                        Else
                            Me.grdDetalleTransferencia.MoveNext()
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos AfterColEdit, AfterColUpdate del Grid Detalle"

    Private Sub grdDetalleTransferencia_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalleTransferencia.AfterColUpdate
        'If e.Column.DataColumn.Value.ToString.Trim.Length <> 0 Then
        '    Select Case e.ColIndex
        '        Case eCamposGrid.cantidadRecibida  'Validar columna [CantidadRecibida]
        '            If Not Me.CantidadRecibidaValida Then
        '                MsgBox("La cantidad recepcionada tiene un valor incorrecto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '            End If
        '    End Select
        'End If
    End Sub

    Private Sub grdDetalleTransferencia_AfterColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalleTransferencia.AfterColEdit
        If e.ColIndex = eCamposGrid.cantidadRecibida Then
            If Me.grdDetalleTransferencia.Columns("CantidadRecibida").Text.Length = 0 Then
                Me.grdDetalleTransferencia.Columns("CantidadRecibida").Value = 0
            Else
                Try
                    If Not Me.CantidadRecibidaValida Then
                        Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Cantidad recibida debe ser menor o igual a la cantidad Despachada.")
                        Me.grdDetalleTransferencia.SelectionStart = 0
                        Me.grdDetalleTransferencia.SelectionLength = Me.grdDetalleTransferencia.Columns("CantidadRecibida").Text.Length
                    End If
                Catch ex As Exception
                    Me.grdDetalleTransferencia.Columns("CantidadRecibida").Value = 0
                End Try
            End If
        End If
    End Sub
#End Region

#End Region

End Class