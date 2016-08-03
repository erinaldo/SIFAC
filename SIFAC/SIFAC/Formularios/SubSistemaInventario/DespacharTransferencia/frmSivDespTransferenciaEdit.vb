'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 26 Mayo 2010. 02:33 AM.
''-- Formulario de Edición y Modificación de despacho de transferencia de repuestos.
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles

Public Class frmSivDespTransferenciaEdit
    'Tipo enumerado para controlar los índices de los campos del grid detalle.
#Region "Tipo Enumerado"
    Public Enum eCamposGrid
        codigo
        descripcion
        marca
        cantidadOrigen
        cantidadTransito
        cantidadDestino
        cantidadDespachada
        marcaId
        objTiendaDestinoID
        transferenciaID
    End Enum
#End Region

#Region "Atributos"
    Private m_TypeGui As Integer
    Private m_HuboCambioDetalle As Boolean
    Private m_HuboCambioTransf As Boolean
    Private m_IdSivTransferencia As Integer
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer
    Private m_IdEstadoSolicitada As Integer
    Private m_IdEstadoDespachada As Integer

    'Variables lógicas globales para evitar mostrar dos veces un mismo mensaje en las validaciones del grid
    Private bMostroAvisoDetalle As Boolean = False
    Private bDatosRepuestoCargado As Boolean = False

    Private dtDetalleTransferencia As DataTable 'Mantiene los datos que se guardarán en el detalle Transferencia
    Private dtDatosCombosDetalle As DataTable 'Mantiene los datos que se desplegan en los combos del grid detalle

#End Region

#Region "Constantes"
    Private Const AGREGAR = 0
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

    Property HuboCambioTransf() As Boolean
        Get
            HuboCambioTransf = Me.m_HuboCambioTransf
        End Get
        Set(ByVal value As Boolean)
            Me.m_HuboCambioTransf = value
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

    Property IdEstadoSolicitada() As Integer
        Get
            IdEstadoSolicitada = Me.m_IdEstadoSolicitada
        End Get
        Set(ByVal value As Integer)
            Me.m_IdEstadoSolicitada = value
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

#End Region

#Region "Procedimientos generales"

#Region "Cargar datos solicitud transferencia"
    Private Sub CargaDatosSolicitudTransf()
        Dim sSQL, sCampos, sFiltro As String
        Dim dtDatosTransferencia As DataTable
        sCampos = "SivTransferenciaID, ObjTiendaOrigenID, ObjTiendaDestinoID, Observaciones, Fechasolicitud, SolicitadoPor"
        sFiltro = "SivTransferenciaID=" + Me.IdSivTransferencia.ToString
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SivTransferencia", sFiltro)

        dtDatosTransferencia = SqlHelper.ExecuteQueryDT(sSQL)
        'Cargar datos del proveedor
        Me.txtNoTransferencia.Text = Me.IdSivTransferencia
        Me.cmbSitioOrigen.SelectedValue = dtDatosTransferencia.DefaultView(0)("ObjTiendaOrigenID")
        Me.cmbSitioDestino.SelectedValue = dtDatosTransferencia.DefaultView(0)("ObjTiendaDestinoID")
        Me.txtObservaciones.Text = dtDatosTransferencia.DefaultView(0)("Observaciones")
        Me.dtpFecha.Value = dtDatosTransferencia.DefaultView(0)("Fechasolicitud")
        Me.txtDespachadoPor.Text = dtDatosTransferencia.DefaultView(0)("SolicitadoPor")

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
        Dim sSQL, sCampos, sFiltro As String
        'configurar combobox para seleccionar repuesto
        sCampos = " SivRepuestoID as objRepuestoID, DescripcionCorta "
        sFiltro = " Activo=1 AND SivRepuestoID NOT IN ('1','2','3') ORDER BY DescripcionCorta"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SivRepuestos", sFiltro)
        Try
            dtDatosCombosDetalle = SqlHelper.ExecuteQueryDT(sSQL)
            With Me.cmbDescripcionRepuesto
                .DataSource = dtDatosCombosDetalle
                .DisplayMember = "DescripcionCorta"
                .ValueMember = "DescripcionCorta"
                .DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Default
                '.ColumnHeaders = False
                '.DisplayColumns("objRepuestoID").Visible = False
                .DisplayColumns("objRepuestoID").Width = 50
                .Columns("objRepuestoID").Caption = "Código"
                .Columns("DescripcionCorta").Caption = "Descripción"
                .ExtendRightColumn = True
                '.DisplayColumns("DescripcionCorta").Width = Me.cmbDescripcionRepuesto.Width - 10 'Me.grdDetalleTransferencia.Splits(0).DisplayColumns("DescripcionCorta").Width
                .ValueTranslate = True
                .Refresh()
            End With

            If Me.cmbDescripcionRepuesto.RowCount = 0 Then
                MsgBox("No hay repuestos registrados...", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Close()
                Exit Sub
            End If

            ''Cargar desplegable para el código
            With Me.cmbDesplegableCodigo
                .DataSource = dtDatosCombosDetalle
                .DisplayMember = "objRepuestoID"
                .ValueMember = "objRepuestoID"
                .DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Default
                '.ColumnHeaders = False
                '.DisplayColumns("objRepuestoID").Visible = False
                .DisplayColumns("objRepuestoID").Width = 50
                .Columns("objRepuestoID").Caption = "Código"
                .Columns("DescripcionCorta").Caption = "Descripción"
                .ExtendRightColumn = True
                '.DisplayColumns("DescripcionCorta").Width = Me.cmbDescripcionRepuesto.Width - 10 'Me.grdDetalleTransferencia.Splits(0).DisplayColumns("DescripcionCorta").Width
                .ValueTranslate = True
                .Refresh()
            End With

            sCampos = "objRepuestoID, DescripcionCorta, Marca, CantidadOrigen, CantidadDestino, CantidadDespachada, ISNULL(CantidadTransito,1000) AS CantidadTransito, objTransferenciaID, objMarcaID, objTiendaDestinoID"
            'sFiltro = " objTransferenciaID =" + Me.IdSivTransferencia.ToString
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferenciasDet", sFiltroTransferencia)

            Me.dtDetalleTransferencia = SqlHelper.ExecuteQueryDT(sSQL)
            Me.grdDetalleTransferencia.SetDataBinding(Me.dtDetalleTransferencia, "", True)
            FormatearGridDetalle()
            Me.HuboCambioTransf = True
            Me.HuboCambioDetalle = True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Guardar despacho transferencia"
    Private Function GuardarSolicitudTransf() As Boolean
        Dim T As New TransactionManager
        Dim objTransf As New SivTransferencia
        Dim objSivBodegaRepuesto As New SivBodegaRepuestos
        Dim dtDetalleTransf As New DataTable
        Dim fila As DataRow
        'Dim sFiltroTransito, sComando As String
        Try
            Try
                T.BeginTran()
                dtDetalleTransf = SivTransferenciaDetalle.RetrieveDT("1=0")
                With objTransf
                    .ObjTiendaOrigenID = Me.cmbSitioOrigen.SelectedValue
                    .ObjTiendaDestinoID = Me.cmbSitioDestino.SelectedValue
                    .Fechadespacho = Me.dtpFecha.Value
                    .DespachadoPor = Me.txtDespachadoPor.Text.Trim
                    .Observaciones = Me.txtObservaciones.Text.Trim
                    .ObjEstadoID = Me.IdEstadoDespachada
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .Insert(T)
                End With
                Me.IdSivTransferencia = objTransf.SivTransferenciaID

                'Isertar detalle de despacho de transferencia                
                Me.dtDetalleTransferencia.AcceptChanges()
                For Each row As DataRow In Me.dtDetalleTransferencia.Rows
                    fila = dtDetalleTransf.NewRow
                    fila("objTransferenciaID") = Me.IdSivTransferencia
                    fila("objTiendaDestinoID") = Me.cmbSitioDestino.SelectedValue
                    fila("objRepuestoID") = row("objRepuestoID")
                    fila("CantidadSolicitada") = 0
                    fila("CantidadDespachada") = row("CantidadDespachada")
                    fila("CantidadRecibida") = 0
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleTransf.Rows.Add(fila)
                    'Actualizar cantidad en tránsito en SivBodegaRepuesto por cada repuesto
                    With objSivBodegaRepuesto
                        .Retrieve((row("objRepuestoID")), Integer.Parse(Me.cmbSitioOrigen.SelectedValue.ToString))
                        If .CantidadTransito.HasValue Then
                            .CantidadTransito = objSivBodegaRepuesto.CantidadTransito.Value + Convert.ToInt32(fila("CantidadDespachada").ToString)
                        Else
                            .CantidadTransito = Convert.ToInt32(fila("CantidadDespachada").ToString)
                        End If
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor 'Format(clsProyecto.Conexion.FechaServidor, "dd-MM-yyyy")
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .Update(T)
                    End With
                Next

                dtDetalleTransf.TableName = "SivTransferenciaDetalle"
                SivTransferenciaDetalle.BatchUpdate(dtDetalleTransf.DataSet, T)

                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)

                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            objTransf = Nothing
            dtDetalleTransf = Nothing
            T = Nothing
        End Try
    End Function
#End Region

#Region "Bloquear controles"
    Private Sub BloquearControles(ByVal bValor As Boolean)
        Me.cmbSitioOrigen.Enabled = Not bValor
        Me.txtObservaciones.Enabled = Not bValor

        With Me.grdDetalleTransferencia

            .Splits(0).DisplayColumns("objRepuestoID").Locked = True
            .Splits(0).DisplayColumns("DescripcionCorta").Locked = True
            .Splits(0).DisplayColumns("CantidadSolicitada").Locked = True
            .Splits(0).Rows.RemoveAt(.Splits(0).Rows.Count - 1)
            .Refresh()
        End With
        Me.grdDetalleTransferencia.Enabled = False
    End Sub
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

            If Not CodigosRepuestosCorrectos() Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos un código de repuesto ingresado que no existe en la base de datos.")
                Return False
                Exit Function
            End If

            If HayDuplicadosDetalle() Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos un registro duplicado en detalle de transferencia.")
                Return False
                Exit Function
            End If

            If Me.ExistenCantidadesEnCero Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos una cantidad despachada con valor CERO.")
                Return False
                Exit Function
            End If

            If Not Me.CantidadesDespachadasValidas Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos una cantidad despachada con valor Incorrecto")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Function ExisteCodigoRepuesto(ByVal sCodigo As String) As Boolean
        Dim bResultado As Boolean = False
        Try
            If Not String.IsNullOrEmpty(sCodigo) Then
                bResultado = Me.dtDatosCombosDetalle.Select("objRepuestoID = '" + sCodigo & "'").Length <> 0
            End If
            Return bResultado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Function ExistenCantidadesEnCero() As Boolean
        Try
            Return Me.dtDetalleTransferencia.Select("CantidadDespachada = 0").Length <> 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    'Función para validar al escribir en el grid
    Private Function CantidadDespachadaValida() As Boolean
        Dim iCantidadDespachada, iCantidadOrigen, iCantidadTransito As Integer
        Dim bCantidadValida As Boolean = True
        If Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value.ToString.Trim.Length <> 0 Then
            'Cantidad Despachada
            If Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value.ToString.Length <> 0 Then
                iCantidadDespachada = Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value
            Else
                iCantidadDespachada = 0
            End If
            'Cantidad Origen
            If Me.grdDetalleTransferencia.Columns("CantidadOrigen").Value.ToString.Trim.Length <> 0 Then
                iCantidadOrigen = Me.grdDetalleTransferencia.Columns("CantidadOrigen").Value
            Else
                iCantidadOrigen = 0
            End If
            'Cantidad Tránsito
            If Me.grdDetalleTransferencia.Columns("CantidadTransito").Value.ToString.Trim.Length <> 0 Then
                iCantidadTransito = Me.grdDetalleTransferencia.Columns("CantidadTransito").Value
            Else
                iCantidadTransito = 0
            End If

            If iCantidadDespachada = 0 Then
                bCantidadValida = False
            ElseIf iCantidadDespachada > (iCantidadOrigen - iCantidadTransito) Then
                MsgBox("Cantidad despachada debe ser menor o igual a la cantidad de bodega origen.(" + iCantidadOrigen.ToString + ") - Tránsito (" + iCantidadTransito.ToString + ")", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value = String.Empty
                bCantidadValida = False
            End If
        End If
        Return bCantidadValida
    End Function

    'Función para validar al dar clic en Aceptar
    Private Function CantidadesDespachadasValidas() As Integer
        Dim iCantidadDespachada, iCantidadOrigen, iCantidadTransito As Integer
        Dim bCantidadValida As Boolean = True

        If Me.grdDetalleTransferencia.Splits(0).Rows.Count <> 0 Then
            For i As Integer = 0 To Me.grdDetalleTransferencia.Splits(0).Rows.Count - 1
                If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadDespachada).ToString.Trim) And (Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.codigo).ToString.Trim)) Then
                    'Cantidad Origen
                    If TypeGui = AGREGAR Then
                        If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, 3).ToString.Trim) Then
                            iCantidadOrigen = Me.grdDetalleTransferencia.Item(i, 3).ToString.Trim
                        Else
                            iCantidadOrigen = 0
                        End If
                    Else
                        If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, 4).ToString.Trim) Then
                            MsgBox(Me.grdDetalleTransferencia.Item(i, 4).ToString.Trim)
                            iCantidadOrigen = Me.grdDetalleTransferencia.Item(i, 4).ToString.Trim
                        Else
                            iCantidadOrigen = 0
                        End If
                    End If
                    
                    'Cantidad Despachada
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, 5).ToString.Trim) Then
                        iCantidadDespachada = Integer.Parse(Me.grdDetalleTransferencia.Item(i, 5).ToString.Trim)
                    Else
                        iCantidadDespachada = 0
                    End If
                    'Cantidad Tránsito
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, 6).ToString.Trim) Then
                        iCantidadTransito = Integer.Parse(Me.grdDetalleTransferencia.Item(i, 6).ToString.Trim)
                    Else
                        iCantidadTransito = 0
                    End If

                    If iCantidadDespachada > (iCantidadOrigen - iCantidadTransito) Then
                        bCantidadValida = False
                    End If
                End If
            Next
        End If
        Return bCantidadValida
    End Function

    'Verifica si todos los códigos ingresados son correctos
    Private Function CodigosRepuestosCorrectos() As Integer
        Dim bExiste As Boolean = True

        If Me.grdDetalleTransferencia.Splits(0).Rows.Count <> 0 Then
            For i As Integer = 0 To Me.grdDetalleTransferencia.Splits(0).Rows.Count - 2
                If Not ExisteCodigoRepuesto(Me.grdDetalleTransferencia.Item(i, eCamposGrid.codigo).ToString.Trim) Then
                    bExiste = False
                End If
            Next
        End If
        Return bExiste
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

#Region "Formatear grid detalle"
    Private Sub FormatearGridDetalle()
        With Me.grdDetalleTransferencia
            .Columns("objRepuestoID").DropDown = Me.cmbDesplegableCodigo
            .Columns("objRepuestoID").ValueItems.Translate = True
            .Columns("objRepuestoID").DataWidth = 10
            .Columns("objRepuestoID").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None

            .Columns("DescripcionCorta").DropDown = Me.cmbDescripcionRepuesto
            .Columns("DescripcionCorta").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
            .Columns("DescripcionCorta").DataWidth = SivRepuestos.GetMaxLength("DescripcionCorta")

            .Columns("CantidadDespachada").DataWidth = 10 'un entero tiene precisión 10, escala 0
            .Columns("CantidadOrigen").Caption = "Bodega" + vbCrLf + "Cantidad        "
            .Columns("CantidadTransito").Caption = "Origen" + vbCrLf + "     En tránsito"
            .Columns("CantidadDestino").Caption = "Bodega Destino" + vbCrLf + "Cantidad     "
            .Splits(0).DisplayColumns("objTransferenciaID").Visible = False
            .Splits(0).DisplayColumns("objMarcaID").Visible = False
            .Splits(0).DisplayColumns("objTiendaDestinoID").Visible = False
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
            .FilterBar = False
            .EmptyRows = False 'no mostrar más filas después de la última
            .Refresh()
        End With
    End Sub

#End Region

#Region "Buscar Repuesto"
    Private Sub BuscarRepuesto()
        Dim objBuscar As New frmBusquedaRepuestos
        Dim objRepuestoId As String

        If Me.ExistenCantidadesEnCero() Then
            MsgBox("La cantidad a despachar no puede tener valor CERO.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Me.grdDetalleTransferencia.Focus()
            Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada
        Else
            If Me.grdDetalleTransferencia.Columns("Marca").Value.ToString.Trim.Length <> 0 Then
                If Not Me.CantidadDespachadaValida() Then
                    Me.grdDetalleTransferencia.Focus()
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                    Exit Sub
                End If
            End If

            'Mostrar formulario de búsqueda de repuesto
            If objBuscar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                objRepuestoId = objBuscar.objRepuestoIdSeleccionado.ToString

                'Verificar si ya se encuentra el repuesto en Detalle
                If DuplicadoEnDetalle(objRepuestoId, True) Then
                    MsgBox("El repuesto seleccionado ya se encuentra en detalle.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.grdDetalleTransferencia.Focus()
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                    Exit Sub
                End If

                'Cargar los datos del repuesto en el grid de detalle de solicitud
                Me.CargarFilaDetalleTransferencia(objRepuestoId)
                Me.grdDetalleTransferencia.Focus()
                Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada
                Me.HuboCambioDetalle = True
                Me.HuboCambioTransf = True
            End If
        End If
    End Sub
#End Region

#End Region

#Region "Eventos controles"

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Select Case Me.TypeGui
            Case AGREGAR
                If Me.Validaciones Then
                    If Me.GuardarSolicitudTransf Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
        End Select
    End Sub

    Private Sub frmSivDespTransferenciaEdit_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If Me.TypeGui = AGREGAR Then
            Me.cmbSitioDestino.Focus()
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.TextChanged
        Me.ErrorProvider.Clear()
        Me.HuboCambioTransf = True
    End Sub

    Private Sub grdDetalleTransferenica_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = Keys.Delete Then
            Me.EliminarDetalleTransf()
        End If
    End Sub

    Private Sub grdDetalleTransferenica_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
        Me.HuboCambioTransf = True
        Me.HuboCambioDetalle = True
    End Sub

    Private Sub txtObservaciones_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyDown
        If e.KeyValue = Keys.Tab Then
            e.SuppressKeyPress = True
            Me.MoverFocoCelda(0, 0)
        End If
    End Sub

    Private Sub cmbSitioDestino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSitioDestino.TextChanged
        Me.CargarDetalleTransferencia("1=0")
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmdBuscarRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarRepuesto.Click
        If Not Me.SitiosIguales Then
            Me.BuscarRepuesto()
        End If
    End Sub

    Private Sub txtObservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservaciones.TextChanged
        Me.HuboCambioTransf = True
    End Sub

#End Region

#Region "Cargar formulario"
    Private Sub frmSivDespTransferenciaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.txtObservaciones.MaxLength = SivTransferencia.GetMaxLength("Observaciones")
        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.IdEstadoSolicitada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "01") '01=Solicitada
        Me.IdEstadoDespachada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "02") '-- 02=Despachada

        Me.CargarComboSitioOrigen()
        Me.CargarComboSitioDestino()

        Select Case Me.TypeGui
            Case AGREGAR
                Me.Text = "Nuevo despacho de traslado"
                Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor

                'inicializar combo de sitio destino con CENTRAL por defecto
                Me.cmbSitioDestino.SelectedValue = Me.IdSucursalCentral
                'Verificar y asignar sucursal logueada en la sesión.
                If String.IsNullOrEmpty(clsProyecto.Sucursal) Then
                    MsgBox("No ha configurado la sucursal en el utilitario de configuración del sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Else
                    If Me.cmbSitioOrigen.FindStringExact(Me.IdSucursalSession.ToString, 0, 0) = -1 Then
                        MsgBox("La sucursal configurada en la sesión del sistema, no es una sucursal de Repuestos", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Else
                        Me.cmbSitioOrigen.SelectedValue = Me.IdSucursalSession
                    End If
                End If

                Me.txtDespachadoPor.Text = clsProyecto.Conexion.Usuario
                Me.CargarDetalleTransferencia("1=0")
        End Select

        Me.HuboCambioTransf = False 'variable para verificar si se hacen cambios en los datos
        Me.HuboCambioDetalle = False
    End Sub
#End Region

#Region "Cargar fila detalle transferencia"
    Private Function CargarFilaDetalleTransferencia(ByVal sIdRepuesto As String) As Boolean
        Dim sCampos, sFiltro, sSQL As String
        Dim dtDatos As DataTable
        Dim iCantidadOrigen, iCantidadDestino, iCantidadTransito As Integer
        Dim bResultado As Boolean = False
        Try
            If Not String.IsNullOrEmpty(sIdRepuesto) Then
                sCampos = "DescripcionCorta, objMarcaID, Marca, Cantidad, objTiendaID, CantidadTransito"
                sFiltro = " SivRepuestoID ='" + sIdRepuesto + "' AND (objTiendaID=" + Me.cmbSitioOrigen.SelectedValue.ToString + " OR objTiendaID=" + Me.cmbSitioDestino.SelectedValue.ToString + ")"
                sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferenciasCargarDet", sFiltro)

                dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

                If dtDatos.Rows.Count > 0 Then
                    'Obteniendo cantidad Origen
                    dtDatos.DefaultView.RowFilter = "objTiendaID=" + Me.cmbSitioOrigen.SelectedValue.ToString

                    If dtDatos.DefaultView.Count > 0 Then
                        iCantidadOrigen = Integer.Parse(dtDatos.DefaultView.Item(0)("Cantidad").ToString.Trim)
                        iCantidadTransito = Integer.Parse(dtDatos.DefaultView.Item(0)("CantidadTransito").ToString.Trim)
                    Else
                        iCantidadTransito = 0
                        iCantidadOrigen = 0
                    End If
                    'Obteniendo cantidad destino
                    dtDatos.DefaultView.RowFilter = "objTiendaID=" + Me.cmbSitioDestino.SelectedValue.ToString
                    If dtDatos.DefaultView.Count > 0 Then
                        iCantidadDestino = Integer.Parse(dtDatos.DefaultView.Item(0)("Cantidad").ToString.Trim)

                    Else
                        iCantidadDestino = 0
                    End If
                    'Copiar datos en la fila del grid detalle seleccionada
                    'objTransferenciaID, objRepuestoID, objTiendaDestinoID, DescripcionCorta, objMarcaId, Marca, CantidadOrigen, CantidadDestino, CantidadSolicitada"
                    dtDatos.DefaultView.RowFilter = String.Empty
                    If dtDatos.DefaultView.Count > 0 Then
                        With Me.grdDetalleTransferencia
                            .Columns("objTransferenciaID").Value = 0
                            .Columns("objRepuestoID").Value = sIdRepuesto
                            .Columns("objTiendaDestinoID").Value = Me.cmbSitioDestino.SelectedValue.ToString
                            .Columns("DescripcionCorta").Value = dtDatos.DefaultView.Item(0)("DescripcionCorta").ToString.Trim
                            .Columns("objMarcaID").Value = dtDatos.DefaultView.Item(0)("objMarcaID").ToString
                            .Columns("Marca").Value = dtDatos.DefaultView.Item(0)("Marca").ToString
                            .Columns("CantidadOrigen").Value = iCantidadOrigen.ToString
                            .Columns("CantidadDestino").Value = iCantidadDestino.ToString
                            .Columns("CantidadTransito").Value = iCantidadTransito.ToString
                            .Columns("CantidadDespachada").Value = 0
                            .Refresh()
                        End With
                        'Me.grdDetalleTransferencia.UpdateData()
                        bResultado = True
                        Me.HuboCambioDetalle = True
                        Me.HuboCambioTransf = True
                    End If
                Else
                    MsgBox("El repuesto (" + Me.cmbDescripcionRepuesto.Columns("DescripcionCorta").Value.ToString + _
                           ") seleccionado aún no ha sido registrado en alguna de las bodegas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    InicializarDatosFilaDetalle()
                    If Me.grdDetalleTransferencia.Col <> eCamposGrid.codigo Then
                        SendKeys.Send("{LEFT}") 'Mover celda hacia izquierda y luego a derecha para reinicializar columna [Descripción]
                        SendKeys.Send("{RIGHT}")
                    End If
                    'Me.grdDetalleTransferencia.EditActive = False
                End If
            End If
            Return bResultado

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Validaciones Grid Detalle"

#Region "MoverFocoCelda"
    Private Sub MoverFocoCelda(ByVal fila As Integer, ByVal columna As Integer)
        Me.grdDetalleTransferencia.Focus()
        Me.grdDetalleTransferencia.Row = fila
        Me.grdDetalleTransferencia.Col = columna
    End Sub
#End Region

#Region "Eliminar fila en detalle"
    Private Function EliminarDetalleTransf() As Boolean
        Dim bResultado As Boolean = False
        If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
            Try
                'Me.dtDetalleTransferencia.DefaultView.Delete(Me.grdDetalleTransferencia.Row)
                Me.grdDetalleTransferencia.Delete(Me.grdDetalleTransferencia.Row)
                Me.grdDetalleTransferencia.UpdateData()
                Me.HuboCambioTransf = True
                Me.HuboCambioDetalle = True
                bResultado = True
            Catch ex As Exception 'Si hay error al eliminar, que no haga nada.
            End Try
            Return bResultado
        End If
    End Function

    Private Sub InicializarDatosFilaDetalle()
        'Inicializar valores
        With Me.grdDetalleTransferencia
            .Columns("objRepuestoID").Value = String.Empty
            .Columns("DescripcionCorta").Value = String.Empty
            .Columns("Marca").Value = String.Empty
            .Columns("CantidadOrigen").Value = String.Empty
            .Columns("CantidadDestino").Value = String.Empty
            .Columns("CantidadTransito").Value = String.Empty
            .Columns("CantidadDespachada").Value = 0
            .Refresh()
        End With
        Me.bDatosRepuestoCargado = False
        Me.bMostroAvisoDetalle = False
    End Sub

#End Region

#Region "Buscar duplicados en detalle"
    Function HayDuplicadosDetalle() As Boolean
        Dim iCont As Integer = 0
        Dim iValorTemp As String
        Dim bResultado As Boolean = False

        If Me.grdDetalleTransferencia.Splits(0).Rows.Count Then
            For i As Integer = 0 To Me.grdDetalleTransferencia.Splits(0).Rows.Count - 1
                If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, 0).ToString) Then
                    iValorTemp = Me.grdDetalleTransferencia.Item(i, 0).ToString
                End If

                iCont = 0
                For j As Integer = 0 To Me.grdDetalleTransferencia.Splits(0).Rows.Count - 1
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(j, 0).ToString) Then
                        If (Me.grdDetalleTransferencia.Item(j, 0).ToString) = iValorTemp Then
                            iCont = iCont + 1
                        End If
                    End If
                Next
                If iCont >= 2 Then
                    bResultado = True
                    Exit For
                End If
            Next
        End If

        Return bResultado
    End Function

    Function DuplicadoEnDetalle(ByVal sIdRepuesto As String, ByVal bDesdeDescripcion As Boolean) As Boolean
        Dim iCont As Integer = 0
        Dim iValorTemp As String
        Dim bResultado As Boolean = False
        Try

            iValorTemp = (sIdRepuesto)

            If Me.grdDetalleTransferencia.Splits(0).Rows.Count <> 0 Then
                For i As Integer = 0 To Me.grdDetalleTransferencia.Splits(0).Rows.Count - 1
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, 0).ToString) Then
                        If (Me.grdDetalleTransferencia.Item(i, 0).ToString) = iValorTemp Then
                            iCont = iCont + 1
                        End If
                    End If
                Next
                'Si el llamado viene desde el campo [descripción] validar contador en 1
                If bDesdeDescripcion Then
                    If iCont >= 1 Then
                        bResultado = True
                    End If
                Else 'Si viene desde el campo [Código]
                    If Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.Trim.Length = 0 And iCont = 1 Then
                        bResultado = True
                    Else
                        If iCont >= 2 Then
                            bResultado = True
                        End If
                    End If
                End If
            End If

            Return bResultado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Function
#End Region

#Region "Validación desde la columna [Código]"
    'Función que verifica el código de repuesto (si existe,si esta repetido) y lo carga en el registro de detalle.
    'cuando se está trabajando desde la columna [Código]
    Private Function VerificarCargarRepuestoDesdeColumnaCodigo(ByVal sCodigoRepuesto As String) As Boolean
        Dim bCargado As Boolean = False
        If Not String.IsNullOrEmpty(sCodigoRepuesto) Then
            If Me.ExisteCodigoRepuesto(sCodigoRepuesto) Then
                If DuplicadoEnDetalle(sCodigoRepuesto, False) Then
                    If Not bMostroAvisoDetalle Then
                        bMostroAvisoDetalle = True
                        MsgBox("El Repuesto escrito ya está en el detalle de transferencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If
                    Me.InicializarDatosFilaDetalle()
                    Me.grdDetalleTransferencia.Focus()
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                    SendKeys.Send("{RIGHT}") 'Inicializar celda código moviendose a la derecha luego a izquierda
                    SendKeys.Send("{LEFT}")
                    SendKeys.Send("{ESC}")
                Else
                    If Not bDatosRepuestoCargado Then
                        If Me.CargarFilaDetalleTransferencia(sCodigoRepuesto) Then
                            Me.bMostroAvisoDetalle = False
                            Me.bDatosRepuestoCargado = True 'para no cargar los datos del repuesto dos veces.
                            Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada
                            bCargado = True
                            SendKeys.Send("{RIGHT}")
                        Else
                            Me.bMostroAvisoDetalle = True
                            SendKeys.Send("{RIGHT}") 'Inicializar celda código moviendose a la derecha luego a izquierda
                            SendKeys.Send("{LEFT}")
                            SendKeys.Send("{ESC}")
                        End If
                    End If
                End If
            Else
                If Not bMostroAvisoDetalle Then
                    bMostroAvisoDetalle = True
                    MsgBox("Código repuesto ingresado no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                End If

                Me.InicializarDatosFilaDetalle()
                Me.grdDetalleTransferencia.Focus()
                Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                bCargado = False
                SendKeys.Send("{LEFT}")
            End If
        End If
        Return bCargado
    End Function
#End Region

#Region "Validación desde la columna [Descripción]"
    Private Function VerificarCargarRepuestoDesdeColumnaDescripcion(ByVal sCodigoRepuesto As String) As Boolean
        Dim bCargado As Boolean = False
        Try
            If Not String.IsNullOrEmpty(sCodigoRepuesto) Then
                If DuplicadoEnDetalle(sCodigoRepuesto, True) Then 'el segundo parámetro 'true' es para notificar que se está validando desde columna [descripción]
                    MsgBox("El Repuesto (" + Me.cmbDescripcionRepuesto.Columns("DescripcionCorta").Value.ToString + _
                                              ") ya está en el detalle de transferencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.grdDetalleTransferencia.Columns("DescripcionCorta").Value = String.Empty
                    Me.grdDetalleTransferencia.Col = eCamposGrid.descripcion
                    SendKeys.Send("{LEFT}") 'Inicializar celda descripción izquierda luego derecha
                    SendKeys.Send("{RIGHT}")
                    SendKeys.Send("{ESC}")
                Else
                    If Me.CargarFilaDetalleTransferencia(sCodigoRepuesto) Then
                        'Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada
                        SendKeys.Send("{ENTER}")
                    Else
                        InicializarDatosFilaDetalle()
                        SendKeys.Send("{LEFT}") 'Inicializar celda descripción izquierda luego derecha
                        SendKeys.Send("{RIGHT}")
                        SendKeys.Send("{ESC}")
                        Me.bMostroAvisoDetalle = False
                    End If
                End If
            End If
            Return bCargado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Eventos de DropDownClose de los campos de combobox"
    Private Sub cmbDescripcionRepuesto_DropDownClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDescripcionRepuesto.DropDownClose
        Try
            'If Me.grdDetalleTransferencia.Columns("DescripcionCorta").Text.ToString.Trim.Length = 0 Then 'ha seleccionado del combo sin escribir nada en descripción
            Me.VerificarCargarRepuestoDesdeColumnaDescripcion(Me.cmbDescripcionRepuesto.Columns("objRepuestoID").Value.ToString().Trim)
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbDesplegableCodigo_DropDownClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDesplegableCodigo.DropDownClose
        Try
            If Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.ToString.Trim.Length = 0 Then 'ha seleccionado del combo sin escribir nada en código
                VerificarCargarRepuestoDesdeColumnaCodigo(Me.cmbDesplegableCodigo.Columns("objRepuestoID").Value.ToString.Trim)
            Else 'en caso de que el usuario haya escrito parte del código
                If Not Me.ExisteCodigoRepuesto(Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.ToString.Trim) Then
                    If Not bMostroAvisoDetalle Then
                        bMostroAvisoDetalle = True
                        MsgBox("Código repuesto ingresado no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If
                    Me.InicializarDatosFilaDetalle()
                    Me.grdDetalleTransferencia.Focus()
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                Else
                    VerificarCargarRepuestoDesdeColumnaCodigo(Me.grdDetalleTransferencia.Columns("objRepuestoID").Value.ToString.Trim)
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos de KeyPress, KeyDown del Grid Detalle"
    'Bloquear para permitir solo números enteros en columna [Código] y en columna [CantidadDespachada]
    Private Sub grdDetalleTransferencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdDetalleTransferencia.KeyPress
        Try
            If Me.grdDetalleTransferencia.Col = eCamposGrid.codigo Or Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada Then
                If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
                    e.KeyChar = Chr(0)
                Else
                    Me.bDatosRepuestoCargado = False 'Inicializar las variables que controlan si se ha cargado datos repuesto
                    Me.bMostroAvisoDetalle = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grdDetalleTransferencia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleTransferencia.KeyDown
        Dim iCantidadDespachada, iCantidadOrigen, iCantidadTransito As Integer
        Dim bCantidadValida As Boolean = False

        Me.HuboCambioTransf = True
        Me.HuboCambioDetalle = True
        Me.ErrorProvider.Clear()

        Try
            '=============== Validar borrado de filas al presionar delete cuando el grid no esté en modo edición =============
            If e.KeyCode = Keys.Delete And (Not Me.grdDetalleTransferencia.EditActive) Then
                'Si el primer registro está cargado
                If Me.grdDetalleTransferencia.RowCount = 1 Then
                    If Me.grdDetalleTransferencia.Columns(eCamposGrid.marca).Value.ToString.Trim.Length <> 0 And e.KeyCode <> Keys.Escape Then
                        If Me.EliminarDetalleTransf() Then
                            Me.dtDetalleTransferencia.DefaultView.AddNew()
                        End If
                    End If
                End If

                'Si el registro seleccionado está vacío eliminar sin preguntar
                If Me.grdDetalleTransferencia.RowCount > 1 Then
                    If Me.grdDetalleTransferencia.Columns("objRepuestoID").Value.ToString.Trim.Length = 0 Then
                        Try
                            'Me.dtDetalleTransferencia.DefaultView.Delete(Me.grdDetalleTransferencia.Row)
                            Me.grdDetalleTransferencia.Delete(Me.grdDetalleTransferencia.Row)
                        Catch 'si ocurre error al eliminar que no haga nada.
                        End Try
                    ElseIf e.KeyCode = Keys.Delete Then
                        Me.EliminarDetalleTransf()
                    End If
                End If
            End If 'if e.keycode = keys.Delete ...

            '=========== Validando columna [CantidadDespachada] ====================================================
            'Obteniendo valor de cantidad despachada para validación posterior
            If Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value.ToString.Trim.Length <> 0 Then
                'Cantidad Despachada
                Try
                    iCantidadDespachada = Integer.Parse(Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value.ToString)
                Catch ex As Exception
                    iCantidadDespachada = 0
                    e.SuppressKeyPress = True
                    Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value = 0
                End Try
                'Cantidad Origen
                If Me.grdDetalleTransferencia.Columns("CantidadOrigen").Value.ToString.Trim.Length <> 0 Then
                    iCantidadOrigen = Me.grdDetalleTransferencia.Columns("CantidadOrigen").Value
                Else
                    iCantidadOrigen = 0
                End If
                'Cantidad Tránsito
                If Me.grdDetalleTransferencia.Columns("CantidadTransito").Value.ToString.Trim.Length <> 0 Then
                    iCantidadTransito = Me.grdDetalleTransferencia.Columns("CantidadTransito").Value
                Else
                    iCantidadTransito = 0
                End If

                If iCantidadDespachada = 0 Then
                    bCantidadValida = False
                Else
                    If (iCantidadDespachada > (iCantidadOrigen - iCantidadTransito)) Then
                        bCantidadValida = False
                    Else
                        bCantidadValida = True
                    End If
                End If
            Else
                iCantidadDespachada = 0
                iCantidadOrigen = 0
            End If

            'Si se presiona Enter y estamos en la columna [cantidadDespachada]
            If e.KeyCode = Keys.Enter And Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada Then
                If Me.grdDetalleTransferencia.RowCount <> 0 Then
                    'Validaciones en la Cantidades despachadas  
                    If iCantidadDespachada = 0 Then
                        MsgBox("Cantidad a despachar debe ser mayor que CERO.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    ElseIf Me.grdDetalleTransferencia.Columns("objRepuestoID").Value.ToString.Trim.Length = 0 Then
                        MsgBox("Debe escribir un código de Repuesto válido.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                        bCantidadValida = False
                    ElseIf iCantidadDespachada > iCantidadOrigen Then
                        MsgBox("Cantidad a despachar debe ser menor o igual a la cantidad de bodega origen.(" + iCantidadOrigen.ToString + ") - Tránsito (" + iCantidadTransito.ToString + ")", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value = String.Empty
                        bCantidadValida = False
                    Else
                        Me.grdDetalleTransferencia.UpdateData()
                        e.Handled = True
                        Me.MoverFocoCelda(Me.grdDetalleTransferencia.Row + 1, eCamposGrid.codigo)
                        bCantidadValida = True
                        Me.ErrorProvider.Clear()
                        SendKeys.Send("{LEFT}")
                        SendKeys.Send("{LEFT}")
                        SendKeys.Send("{LEFT}")
                    End If
                End If
            End If

            ''============ Al moverse con teclas direccionales ============================================================
            'Si presiona direccional hacia abajo o hacia arriba y no se ha escrito la cantidad solicitada o está es cero entonces bloquear
            If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And Me.grdDetalleTransferencia.Columns("Marca").Value.ToString.Trim.Length <> 0 Then
                If Not bCantidadValida And Me.grdDetalleTransferencia.Row <> Me.grdDetalleTransferencia.RowCount Then
                    e.SuppressKeyPress = True
                    Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "La cantidad a despachar del registro seleccionado es incorrecta.")
                End If
            ElseIf (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And (Me.grdDetalleTransferencia.Col = eCamposGrid.codigo Or Me.grdDetalleTransferencia.Col = eCamposGrid.descripcion Or Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada) Then
                If Me.grdDetalleTransferencia.Columns("objRepuestoID").Value.ToString.Trim.Length = 0 And Me.grdDetalleTransferencia.Row <> Me.grdDetalleTransferencia.RowCount Then
                    Try
                        'Me.dtDetalleTransferencia.DefaultView.Delete(Me.grdDetalleTransferencia.Row)
                        Me.grdDetalleTransferencia.Delete(Me.grdDetalleTransferencia.Row)
                    Catch 'si ocurre error al eliminar que no haga nada.
                    End Try
                End If
            End If

            'Si presiona Enter y estamos en la columna [código]
            If (e.KeyCode = Keys.Enter) And Me.grdDetalleTransferencia.Col = eCamposGrid.codigo Then
                Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada
                SendKeys.Send("{RIGHT}")
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos BeforeColEdit, AfterColUpdate del Grid Detalle"
    Private Sub grdDetalleTransferencia_BeforeColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdDetalleTransferencia.BeforeColEdit
        If Me.SitiosIguales Then
            e.Cancel = True
        Else
            If e.ColIndex = eCamposGrid.cantidadDespachada Then
                If Me.grdDetalleTransferencia.Columns("objRepuestoID").Value.ToString().Trim.Length = 0 Then
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                End If
            End If
        End If
    End Sub

    Private Sub grdDetalleTransferencia_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalleTransferencia.AfterColUpdate
        If e.Column.DataColumn.Value.ToString.Trim.Length <> 0 Then
            Select Case e.ColIndex
                Case eCamposGrid.codigo 'Validar columna [código] 
                    VerificarCargarRepuestoDesdeColumnaCodigo(e.Column.DataColumn.Value.ToString.Trim)
                Case eCamposGrid.descripcion
                    'If Me.cmbDescripcionRepuesto.Columns("objRepuestoID").Value.ToString.Trim.Length <> 0 Then
                    '    VerificarCargarRepuestoDesdeColumnaDescripcion(Me.cmbDescripcionRepuesto.Columns("objRepuestoID").Value.ToString.Trim)
                    'End If
                Case eCamposGrid.cantidadDespachada 'Validar columna [CantidadDespachada]
                    If Not Me.CantidadDespachadaValida Then
                        MsgBox("La cantidad a despachar tiene un valor incorrecto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If
            End Select
        End If
    End Sub

#End Region

#End Region

End Class