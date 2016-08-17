'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 01 Junio 2010. 08:52 AM.
''-- Formulario de Edición y Modificación de despacho de transferencia de repuestos(2).
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles

Public Class frmSivDespTransferenciaDesp
    'Tipo enumerado para controlar los índices de los campos del grid detalle.
#Region "Tipo Enumerado"
    Public Enum eCamposGrid
        codigo
        descripcion
        marca
        cantidadOrigen
        cantidadDestino
        transferenciaID
        marcaId
        cantidadDespachada
        objTiendaDestinoID
        cantidadTransito
        cantidadSolicitada
        BD
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
    Private m_FormLlamada As String 'Identificar de donde se hace el llamado

    'Variables lógicas globales para evitar mostrar dos veces un mismo mensaje en las validaciones del grid
    Private bMostroAvisoDetalle As Boolean = False
    Private bDatosRepuestoCargado As Boolean = False

    Private dtDetalleTransferencia As DataTable 'Mantiene los datos que se guardarán en el detalle Transferencia
    Private dtDatosCombosDetalle As DataTable 'Mantiene los datos que se desplegan en los combos del grid detalle

#End Region

#Region "Constantes"
    Private Const AGREGAR = 0
    Private Const DESPACHAR = 1
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

    Property FormLlamada() As String
        Get
            FormLlamada = Me.m_FormLlamada
        End Get
        Set(ByVal value As String)
            Me.m_FormLlamada = value
        End Set
    End Property
#End Region

#Region "Procedimientos generales"

#Region "Cargar datos solicitud transferencia"
    Private Sub CargaDatosSolicitudTransf()
        Dim sSQL, sCampos, sFiltro As String
        Dim dtDatosTransferencia As DataTable
        sCampos = "SivTransferenciaID, ObjBodegaOrigenID, ObjBodegaDestinoID, Observaciones, Fechasolicitud, SolicitadoPor, Fechadespacho, DespachadoPor, fechaRecibido, RecibidoPor"
        sFiltro = "SivTransferenciaID=" + Me.IdSivTransferencia.ToString
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SivTransferencia", sFiltro)

        dtDatosTransferencia = SqlHelper.ExecuteQueryDT(sSQL)
        'Cargar datos del proveedor
        Me.txtNoTransferencia.Text = Me.IdSivTransferencia
        Me.cmbSitioOrigen.SelectedValue = dtDatosTransferencia.DefaultView(0)("ObjBodegaOrigenID")
        Me.cmbSitioDestino.SelectedValue = dtDatosTransferencia.DefaultView(0)("ObjBodegaDestinoID")
        Me.txtObservaciones.Text = dtDatosTransferencia.DefaultView(0)("Observaciones")
        If dtDatosTransferencia.DefaultView(0)("Fechasolicitud").ToString.Length <> 0 Then
            Me.dtpFechaSolicitud.Value = dtDatosTransferencia.DefaultView(0)("Fechasolicitud")
            Me.txtSolicitadoPor.Text = dtDatosTransferencia.DefaultView(0)("SolicitadoPor")
        End If

        If dtDatosTransferencia.DefaultView(0)("FechaDespacho").ToString.Length <> 0 Then
            Me.dtpFechaDespacho.Value = dtDatosTransferencia.DefaultView(0)("FechaDespacho").ToString
            Me.txtDespachadoPor.Text = dtDatosTransferencia.DefaultView(0)("DespachadoPor").ToString
        End If

        If Me.FormLlamada = "frmSivRecepTransferencia" Then
            If dtDatosTransferencia.DefaultView(0)("FechaRecibido").ToString.Length <> 0 Then
                Me.dtpFechaRecepcion.Value = dtDatosTransferencia.DefaultView(0)("FechaRecibido").ToString
                Me.txtRecibidoPor.Text = dtDatosTransferencia.DefaultView(0)("RecibidoPor").ToString
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
        sCampos = " SivProductoID as objSivProductoID, Nombre "
        sFiltro = " Activo=1 ORDER BY Nombre"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SivProductos", sFiltro)
        Try
            dtDatosCombosDetalle = SqlHelper.ExecuteQueryDT(sSQL)
            With Me.cmbDescripcionRepuesto
                .DataSource = dtDatosCombosDetalle
                .DisplayMember = "Nombre"
                .ValueMember = "Nombre"
                .DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Default
                '.ColumnHeaders = False
                '.DisplayColumns("objRepuestoID").Visible = False
                .DisplayColumns("objSivProductoID").Width = 50
                .Columns("objSivProductoID").Caption = "Código"
                .Columns("Nombre").Caption = "Descripción"
                .ExtendRightColumn = True
                '.DisplayColumns("DescripcionCorta").Width = Me.cmbDescripcionRepuesto.Width - 10 'Me.grdDetalleTransferencia.Splits(0).DisplayColumns("DescripcionCorta").Width
                .ValueTranslate = True
                .Refresh()
            End With

            If Me.cmbDescripcionRepuesto.RowCount = 0 Then
                MsgBox("No hay productos registrados...", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Close()
                Exit Sub
            End If

            ''Cargar desplegable para el código
            With Me.cmbDesplegableCodigo
                .DataSource = dtDatosCombosDetalle
                .DisplayMember = "objSivProductoID"
                .ValueMember = "objSivProductoID"
                .DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Default
                '.ColumnHeaders = False
                '.DisplayColumns("objRepuestoID").Visible = False
                .DisplayColumns("objSivProductoID").Width = 50
                .Columns("objSivProductoID").Caption = "Código"
                .Columns("Nombre").Caption = "Descripción"
                .ExtendRightColumn = True
                '.DisplayColumns("DescripcionCorta").Width = Me.cmbDescripcionRepuesto.Width - 10 'Me.grdDetalleTransferencia.Splits(0).DisplayColumns("DescripcionCorta").Width
                .ValueTranslate = True
                .Refresh()
            End With

            If Me.TypeGui = DESPACHAR Then
                sCampos = "objSivProductoID, Producto, Marca, CantidadOrigen, CantidadDestino, cast(0 as int) as CantidadDespachada,CantidadTransito, CantidadSolicitada, objTransferenciaID, objMarcaID, objBodegaDestinoID,CAST(1 AS BIT) as BD"
            Else
                sCampos = "objSivProductoID, Producto, Marca, CantidadOrigen, CantidadDestino, CantidadDespachada,CantidadTransito, CantidadSolicitada, objTransferenciaID, objMarcaID, objBodegaDestinoID, CAST(1 AS BIT) as BD"
            End If

            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferenciasDet", sFiltroTransferencia)

            Me.dtDetalleTransferencia = SqlHelper.ExecuteQueryDT(sSQL)
            Me.grdDetalleTransferencia.SetDataBinding(Me.dtDetalleTransferencia, "", True)

            If Me.TypeGui = DESPACHAR Then
                Me.FormatearGridDetalleParaEdicion()
            Else
                Me.FormatearGridDetalleParaConsulta()
            End If

            Me.HuboCambioTransf = True
            Me.HuboCambioDetalle = True
        Catch ex As Exception
            Me.FormatearGridDetalleParaConsulta()
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Guardar despacho transferencia"
    Private Function GuardarDespachoTransf() As Boolean
        Dim T As New TransactionManager
        Dim objTransf As New SivTransferencia
        Dim objSivBodegaProductos As New SivBodegaProductos
        Dim dtDetalleTransf As New DataTable
        Dim fila As DataRow
        Try
            Try
                T.BeginTran()
                dtDetalleTransf = SivTransferenciaDetalle.RetrieveDT("1=0")
                With objTransf
                    .ObjBodegaOrigenID = Me.cmbSitioOrigen.SelectedValue
                    .ObjBodegaDestinoID = Me.cmbSitioDestino.SelectedValue
                    .Fechadespacho = Me.dtpFechaDespacho.Value
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
                    fila("objBodegaDestinoID") = Me.cmbSitioDestino.SelectedValue
                    fila("objSivProductoID") = row("objSivProductoID")
                    fila("CantidadSolicitada") = 0
                    fila("CantidadDespachada") = row("CantidadDespachada")
                    fila("CantidadRecibida") = 0
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleTransf.Rows.Add(fila)
                    'Actualizar cantidad en tránsito en SivBodegaRepuesto por cada repuesto
                    With objSivBodegaProductos
                        .Retrieve(Convert.ToInt32(row("objSivProductoID")), Convert.ToInt32(fila("objBodegaDestinoID").ToString))
                        If .CantidadTransito.HasValue Then
                            .CantidadTransito = objSivBodegaProductos.CantidadTransito.Value + Convert.ToInt32(fila("CantidadDespachada").ToString)
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

#Region "Despachar transferencia"
    Private Function DespacharTransferencia() As Boolean
        Dim T As New TransactionManager
        Dim objTransf As New SivTransferencia
        Dim objSivBodegaProductos As New SivBodegaProductos
        Dim objSivTranDetalleUpdate As New SivTransferenciaDetalle
        Dim objSivTranDetalleInsert As New SivTransferenciaDetalle

        Dim dtDetalleTransfInsert As New DataTable

        Dim fila As DataRow
        Try
            Try
                T.BeginTran()
                dtDetalleTransfInsert = SivTransferenciaDetalle.RetrieveDT("1=0")

                With objTransf
                    .Retrieve(Me.IdSivTransferencia)
                    .Fechadespacho = Me.dtpFechaDespacho.Value
                    .DespachadoPor = Me.txtDespachadoPor.Text.Trim
                    .Observaciones = Me.txtObservaciones.Text.Trim
                    .ObjEstadoID = Me.IdEstadoDespachada
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .Update(T)
                End With

                'Actualizar detalle de despacho de transferencia                
                Me.grdDetalleTransferencia.UpdateData()
                Me.dtDetalleTransferencia.AcceptChanges()

                For Each row As DataRow In Me.dtDetalleTransferencia.Rows
                    fila = dtDetalleTransfInsert.NewRow
                    'Si fue cargado desde la BD, entonces actualizar sino insertar
                    If Convert.ToBoolean(row("BD")) Then    'ACTUALIZACION
                        With objSivTranDetalleUpdate
                            .RetrieveByFilter(String.Format("objTransferenciaID={0} and  objSivProductoID={1}", Me.IdSivTransferencia.ToString, row("objSivProductoID")), T)
                            .CantidadDespachada = row("CantidadDespachada")
                            .FechaModificacion = clsProyecto.Conexion.FechaServidor
                            .UsuarioModificacion = clsProyecto.Conexion.Usuario
                            .Update(T)
                        End With
                    Else                                   'INSERSION
                        objSivTranDetalleInsert = New SivTransferenciaDetalle
                        With objSivTranDetalleInsert
                            .objTransferenciaID = Me.IdSivTransferencia
                            .objBodegaDestinoID = Me.cmbSitioDestino.SelectedValue
                            .objSivProductoID = row("objSivProductoID")
                            .CantidadSolicitada = 0
                            .CantidadDespachada = row("CantidadDespachada")
                            .CantidadRecibida = 0
                            .UsuarioCreacion = clsProyecto.Conexion.Usuario
                            .FechaCreacion = clsProyecto.Conexion.FechaServidor
                            .Insert(T)
                        End With

                        'fila("objTransferenciaID") = Me.IdSivTransferencia
                        'fila("objTiendaDestinoID") = Me.cmbSitioDestino.SelectedValue
                        'fila("objRepuestoID") = row("objRepuestoID")
                        'fila("CantidadSolicitada") = 0
                        'fila("CantidadDespachada") = row("CantidadDespachada")
                        'fila("CantidadRecibida") = 0
                        'fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        'fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        'dtDetalleTransfInsert.Rows.Add(fila)
                    End If

                    'Actualizar cantidad en tránsito en SivBodegaRepuesto por cada repuesto
                    With objSivBodegaProductos
                        .Retrieve((row("objSivProductoID")), Convert.ToInt32(Me.cmbSitioOrigen.SelectedValue.ToString))
                        If .CantidadTransito.HasValue Then
                            .CantidadTransito = objSivBodegaProductos.CantidadTransito.Value + Convert.ToInt32(row("CantidadDespachada").ToString)
                        Else
                            .CantidadTransito = Convert.ToInt32(row("CantidadDespachada").ToString)
                        End If
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor 'Format(clsProyecto.Conexion.FechaServidor, "dd-MM-yyyy")
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .Update(T)
                    End With
                Next
                'dtDetalleTransfInsert.TableName = "SivTransferenciaDetalle"
                'dtDetalleTransfInsert.AcceptChanges()
                'SivTransferenciaDetalle.BatchUpdate(dtDetalleTransfInsert.DataSet, T)

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
            dtDetalleTransfInsert = Nothing
            T = Nothing
        End Try
    End Function
#End Region

#Region "Validaciones de datos"
    Private Function Validaciones() As Boolean
        Try

            If Me.dtDetalleTransferencia.Rows.Count <= 0 Then
                'MsgBox("Debe ingresar al menos un repuesto en detalle de solicitud.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Debe ingresar al menos un producto en detalle de transferencia.")
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
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos un código de producto ingresado que no existe en la base de datos.")
                Return False
                Exit Function
            End If

            If HayDuplicadosDetalle() Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos un registro duplicado en detalle de transferencia.")
                Return False
                Exit Function
            End If

            If Me.ExistenCantidadesEnCero Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos una cantidad a despachar NUEVA con valor CERO.")
                Return False
                Exit Function
            End If

            If Not Me.CantidadesDespachadasValidas Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos una cantidad a despachar con valor Incorrecto.")
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
                bResultado = Me.dtDatosCombosDetalle.Select("objSivProductoID = '" + sCodigo & "'").Length <> 0
            End If
            Return bResultado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Function ExistenCantidadesEnCero() As Boolean
        Try
            Return Me.dtDetalleTransferencia.Select("CantidadDespachada = 0 and BD=0").Length <> 0
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
                MsgBox("Cantidad a despachar debe ser menor o igual a la cantidad de bodega origen.(" + iCantidadOrigen.ToString + ") - Tránsito (" + iCantidadTransito.ToString + ")", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
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
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadOrigen).ToString.Trim) Then
                        iCantidadOrigen = Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadOrigen).ToString.Trim
                    Else
                        iCantidadOrigen = 0
                    End If
                    'Cantidad Despachada
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadDespachada).ToString.Trim) Then
                        iCantidadDespachada = Integer.Parse(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadDespachada).ToString.Trim)
                    Else
                        iCantidadDespachada = 0
                    End If
                    'Cantidad Tránsito
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadTransito).ToString.Trim) Then
                        iCantidadDespachada = Integer.Parse(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadTransito).ToString.Trim)
                    Else
                        iCantidadDespachada = 0
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

#Region "Formatear grid detalle Edición - Consulta"
    Private Sub FormatearGridDetalleParaEdicion()
        With Me.grdDetalleTransferencia
            .Columns("objSivProductoID").DropDown = Me.cmbDesplegableCodigo
            .Columns("objSivProductoID").ValueItems.Translate = True
            .Columns("objSivProductoID").DataWidth = 10
            .Columns("objSivProductoID").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None

            .Columns("Producto").DropDown = Me.cmbDescripcionRepuesto
            .Columns("Producto").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
            .Columns("Producto").DataWidth = SivProductos.GetMaxLength("Nombre")

            .Columns("CantidadDespachada").DataWidth = 10 'un entero tiene precisión 10, escala 0
            .Columns("CantidadOrigen").Caption = "Bodega" + vbCrLf + "Cantidad        ."
            .Columns("CantidadTransito").Caption = "Origen" + vbCrLf + "     En tránsito"
            .Columns("CantidadDestino").Caption = "Bodega Destino" + vbCrLf + "Cantidad"

            .Splits(0).DisplayColumns("CantidadOrigen").AllowSizing = False
            .Splits(0).DisplayColumns("CantidadTransito").AllowSizing = False

            .Splits(0).DisplayColumns("objTransferenciaID").Visible = False
            .Splits(0).DisplayColumns("objMarcaID").Visible = False
            .Splits(0).DisplayColumns("objBodegaDestinoID").Visible = False
            .Splits(0).DisplayColumns("BD").Visible = False
            .Splits(0).DisplayColumns("BD").AllowFocus = False
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
            .FilterBar = False
            .AllowSort = False
            .AllowColMove = False
            .EmptyRows = False 'no mostrar más filas después de la última
            .Refresh()
        End With
    End Sub

    Private Sub FormatearGridDetalleParaConsulta()
        With Me.grdDetalleTransferencia
            .Splits(0).DisplayColumns("objSivProductoID").Locked = True
            .Splits(0).DisplayColumns("Producto").Locked = True
            .Splits(0).DisplayColumns("CantidadDespachada").Locked = True

            .Splits(0).DisplayColumns("objSivProductoID").Style.BackColor = .Splits(0).DisplayColumns("Marca").Style.BackColor
            .Splits(0).DisplayColumns("Producto").Style.BackColor = .Splits(0).DisplayColumns("Marca").Style.BackColor
            .Splits(0).DisplayColumns("CantidadDespachada").Style.BackColor = .Splits(0).DisplayColumns("Marca").Style.BackColor

            '.Columns("DescripcionCorta").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None

            .Columns("CantidadOrigen").Caption = "Bodega" + vbCrLf + "Cantidad        ."
            .Columns("CantidadTransito").Caption = "Origen" + vbCrLf + "     En tránsito"
            .Columns("CantidadDestino").Caption = "Bodega Destino" + vbCrLf + "Cantidad"
            .Columns("CantidadDespachada").Caption = "Cantidad" + vbCrLf + "Despachada"
            .Splits(0).DisplayColumns("CantidadOrigen").AllowSizing = False
            .Splits(0).DisplayColumns("CantidadTransito").AllowSizing = False

            .Splits(0).DisplayColumns("objTransferenciaID").Visible = False
            .Splits(0).DisplayColumns("objMarcaID").Visible = False
            .Splits(0).DisplayColumns("objBodegaDestinoID").Visible = False
            .Splits(0).DisplayColumns("BD").Visible = False
            .Splits(0).DisplayColumns("BD").AllowFocus = False

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

#Region "Buscar Repuesto"
    Private Sub BuscarRepuesto()
        Dim objBuscar As New frmBusquedaRepuestos
        Dim objRepuestoId As String

        'Mostrar formulario de búsqueda de repuesto
        If objBuscar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            objRepuestoId = objBuscar.objRepuestoIdSeleccionado.ToString

            'Verificar si ya se encuentra el repuesto en Detalle
            If DuplicadoEnDetalle(objRepuestoId, True) Then
                MsgBox("El producto seleccionado ya se encuentra en detalle.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
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
    End Sub
#End Region

#End Region

#Region "Eventos controles"
    Private Sub frmSivDespTransferenciaEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Me.HuboCambioTransf And Me.TypeGui = DESPACHAR And Me.DialogResult <> Windows.Forms.DialogResult.OK) Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub frmSivDespTransferenciaDesp_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If Me.TypeGui = DESPACHAR Then
            Me.txtObservaciones.Focus()
        ElseIf Me.TypeGui = CONSULTAR Then
            Me.cmdCancelar.Focus()
        End If
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Select Case Me.TypeGui
            Case DESPACHAR
                If Me.Validaciones Then
                    If Me.DespacharTransferencia Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
        End Select
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
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

    Private Sub cmdBuscarRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarRepuesto.Click
        If Not Me.SitiosIguales Then
            If Not EsRegistroDesdeBD() Then
                Me.BuscarRepuesto()
            Else
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "No puede cambiar los datos del registro que ha seleccionado. Seleccione el último registro para agregar uno nuevo.")
                Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                Me.grdDetalleTransferencia.Focus()
            End If
        End If
    End Sub

    Private Sub txtObservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservaciones.TextChanged
        Me.HuboCambioTransf = True
    End Sub

    'Cerrar ventana al presionar Escape si está en modo consulta
    Private Sub frmSivDespTransferenciaDesp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.TypeGui = CONSULTAR Then 'Modo consulta
            If e.KeyValue = Keys.Escape Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
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
            Case DESPACHAR 'Despachar solicitud de transferencia
                Me.Text = "Despachar traslado"
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
                Me.cmbSitioOrigen.Enabled = False
                Me.txtObservaciones.Enabled = True

                Me.dtpFechaDespacho.Value = clsProyecto.Conexion.FechaServidor
                Me.txtDespachadoPor.Text = clsProyecto.Conexion.Usuario

            Case CONSULTAR 'Consultar solicitud de transferencia
                Me.Text = "Consultar traslado"
                If Me.FormLlamada = "frmSivRecepTransferencia" Then
                    Me.lblRecibidoPor.Visible = True
                    Me.txtRecibidoPor.Visible = True
                    Me.lblGuion3.Visible = True
                    Me.dtpFechaRecepcion.Visible = True
                Else
                    Me.lblRecibidoPor.Visible = False
                    Me.txtRecibidoPor.Visible = False
                    Me.lblGuion3.Visible = False
                    Me.dtpFechaRecepcion.Visible = False
                End If

                Me.CargaDatosSolicitudTransf()
                Me.cmbSitioOrigen.Enabled = False
                Me.txtObservaciones.Enabled = False
                Me.cmdGuardar.Enabled = False
                Me.cmdBuscarRepuesto.Enabled = False

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
                sCampos = "Producto, objMarcaID, Marca, Cantidad, objBodegaID, CantidadTransito"
                sFiltro = " SivProductoID =" + sIdRepuesto + " AND (objBodegaID=" + Me.cmbSitioOrigen.SelectedValue.ToString + " OR objBodegaID=" + Me.cmbSitioDestino.SelectedValue.ToString + ")"
                sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferenciasCargarDet", sFiltro)

                dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

                If dtDatos.Rows.Count > 0 Then
                    'Obteniendo cantidad Origen
                    dtDatos.DefaultView.RowFilter = "objBodegaID=" + Me.cmbSitioOrigen.SelectedValue.ToString

                    If dtDatos.DefaultView.Count > 0 Then
                        iCantidadOrigen = Integer.Parse(dtDatos.DefaultView.Item(0)("Cantidad").ToString.Trim)
                        iCantidadTransito = Integer.Parse(dtDatos.DefaultView.Item(0)("CantidadTransito").ToString.Trim)
                    Else
                        iCantidadTransito = 0
                        iCantidadOrigen = 0
                    End If
                    'Obteniendo cantidad destino
                    dtDatos.DefaultView.RowFilter = "objBodegaID=" + Me.cmbSitioDestino.SelectedValue.ToString
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
                            .Columns("objSivProductoID").Value = sIdRepuesto
                            .Columns("objBodegaDestinoID").Value = Me.cmbSitioDestino.SelectedValue.ToString
                            .Columns("Producto").Value = dtDatos.DefaultView.Item(0)("Producto").ToString.Trim
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
                    MsgBox("El producto (" + Me.cmbDescripcionRepuesto.Columns("Producto").Value.ToString + _
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
            .Columns("objSivProductoID").Value = String.Empty
            .Columns("Producto").Value = String.Empty
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
        Dim iValorTemp As Integer
        Dim bResultado As Boolean = False
        Try

            iValorTemp = Integer.Parse(sIdRepuesto)

            If Me.grdDetalleTransferencia.Splits(0).Rows.Count <> 0 Then
                For i As Integer = 0 To Me.grdDetalleTransferencia.Splits(0).Rows.Count - 1
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, 0).ToString) Then
                        If Int32.Parse(Me.grdDetalleTransferencia.Item(i, 0).ToString) = iValorTemp Then
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
                    If Me.grdDetalleTransferencia.Columns("objSivProductoID").Text.Trim.Length = 0 And iCont = 1 Then
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

        If Me.EsRegistroDesdeBD Then
            Exit Function
        End If

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
                    MsgBox("Código producto ingresado no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
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
                    MsgBox("El Producto (" + Me.cmbDescripcionRepuesto.Columns("Producto").Value.ToString + _
                                              ") ya está en el detalle de transferencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.grdDetalleTransferencia.Columns("Producto").Value = String.Empty
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

#Region "Es registro cargado desde la base de datos"
    Private Function EsRegistroDesdeBD() As Boolean
        Dim bResultado As Boolean = False
        'Verificar si el registro que se intenta modificar fue cargado desde la base de datos
        If Me.grdDetalleTransferencia.Col = eCamposGrid.codigo Or Me.grdDetalleTransferencia.Col = eCamposGrid.descripcion Or Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada Then
            Try
                bResultado = Me.dtDetalleTransferencia.Rows(Me.grdDetalleTransferencia.RowBookmark(Me.grdDetalleTransferencia.Row))("BD") = True
            Catch ex As Exception
            End Try
        ElseIf Me.grdDetalleTransferencia.Col <> eCamposGrid.cantidadDespachada Then
            Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
            bResultado = Me.dtDetalleTransferencia.Rows(Me.grdDetalleTransferencia.RowBookmark(Me.grdDetalleTransferencia.Row))("BD") = True
        End If
        Return bResultado
    End Function
#End Region

#Region "Restaurar Fila Detalle"
    Private Sub RestaurarFilaDetalle()
        With Me.grdDetalleTransferencia
            .Columns("objSivProductoID").Value = Me.grdDetalleTransferencia.Columns("objSivProductoID").Value.ToString.Trim
            .Columns("Producto").Value = Me.grdDetalleTransferencia.Columns("Producto").Value.ToString.Trim
            .Columns("CantidadDespachada").Value = Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value.ToString.Trim
            .UpdateData()
            .Refresh()
        End With
    End Sub
#End Region

#Region "Eventos de DropDownClose de los campos de combobox"
    Private Sub cmbDescripcionRepuesto_DropDownClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDescripcionRepuesto.DropDownClose
        Try
            If Me.EsRegistroDesdeBD And (Me.grdDetalleTransferencia.Columns("Marca").Value.ToString.Trim.Length <> 0) Then
                'Me.RestaurarFilaDetalle(Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.ToString.Trim)
                Me.RestaurarFilaDetalle()
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, My.Resources.MsgNoPuedeCambiarCodigo)
                Exit Sub
            End If

            Me.VerificarCargarRepuestoDesdeColumnaDescripcion(Me.cmbDescripcionRepuesto.Columns("objRepuestoID").Value.ToString().Trim)
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbDesplegableCodigo_DropDownClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDesplegableCodigo.DropDownClose
        Try
            If Me.EsRegistroDesdeBD And (Me.grdDetalleTransferencia.Columns("Marca").Value.ToString.Trim.Length <> 0) Then
                Me.RestaurarFilaDetalle()
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, My.Resources.MsgNoPuedeCambiarCodigo)
                Exit Sub
            End If

            If Me.grdDetalleTransferencia.Columns("objSivProductoID").Text.ToString.Trim.Length = 0 Then 'ha seleccionado del combo sin escribir nada en código
                VerificarCargarRepuestoDesdeColumnaCodigo(Me.cmbDesplegableCodigo.Columns("objSivProductoID").Value.ToString.Trim)
            Else 'en caso de que el usuario haya escrito parte del código
                If Not Me.ExisteCodigoRepuesto(Me.grdDetalleTransferencia.Columns("objSivProductoID").Text.ToString.Trim) Then
                    If Not bMostroAvisoDetalle Then
                        bMostroAvisoDetalle = True
                        MsgBox("Código producto ingresado no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If
                    Me.InicializarDatosFilaDetalle()
                    Me.grdDetalleTransferencia.Focus()
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                Else
                    VerificarCargarRepuestoDesdeColumnaCodigo(Me.grdDetalleTransferencia.Columns("objSivProductoID").Value.ToString.Trim)
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

        If Me.TypeGui = CONSULTAR Then 'Modo consulta
            Exit Sub
        End If

        Try
            '=============== Validar borrado de filas al presionar delete cuando el grid no esté en modo edición =============
            If e.KeyCode = Keys.Delete And (Not Me.grdDetalleTransferencia.EditActive) Then
                'Si el primer registro está cargado
                If Me.grdDetalleTransferencia.RowCount = 1 Then
                    If Me.grdDetalleTransferencia.Columns(eCamposGrid.marca).Value.ToString.Trim.Length <> 0 And e.KeyCode <> Keys.Escape Then
                        If Me.EsRegistroDesdeBD Then
                            e.SuppressKeyPress = True
                            Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, My.Resources.MsgNoPuedeCambiarCodigo)
                            Exit Sub
                        Else
                            If Not Me.grdDetalleTransferencia.RowCount = Me.grdDetalleTransferencia.Splits(0).Rows.Count - 1 Then
                                If Me.EliminarDetalleTransf() Then
                                    Me.dtDetalleTransferencia.DefaultView.AddNew()
                                    Exit Sub
                                End If
                            End If
                        End If
                    End If
                End If

                'Si el registro seleccionado está vacío eliminar sin preguntar
                If Me.grdDetalleTransferencia.RowCount > 1 Then
                    If Me.grdDetalleTransferencia.Columns("objSivProductoID").Text.ToString.Trim.Length = 0 Then
                        Try
                            'Me.dtDetalleTransferencia.DefaultView.Delete(Me.grdDetalleTransferencia.Row)
                            Me.grdDetalleTransferencia.Delete(Me.grdDetalleTransferencia.Row)
                        Catch 'si ocurre error al eliminar que no haga nada.
                        End Try
                    ElseIf e.KeyCode = Keys.Delete Then
                        If Me.EsRegistroDesdeBD Then
                            e.SuppressKeyPress = True
                            Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, My.Resources.MsgNoPuedeCambiarCodigo)
                        Else
                            Me.EliminarDetalleTransf()
                            Exit Sub
                        End If
                    End If
                End If
            End If 'if e.keycode = keys.Delete ...

            '=========== Validando columna [CantidadDespachada] ====================================================
            'Obteniendo valor de cantidad despachada para validación posterior
            If Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value.ToString.Trim.Length <> 0 Then
                'Cantidad despachada
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
                'Cantidad Transito
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
                    ElseIf Me.grdDetalleTransferencia.Columns("objSivProductoID").Value.ToString.Trim.Length = 0 Then
                        MsgBox("Debe escribir un código de producto válido.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                        bCantidadValida = False
                    ElseIf iCantidadDespachada > iCantidadOrigen Then
                        MsgBox("Cantidad a despachar debe ser menor o igual a la cantidad de bodega origen.(" + iCantidadOrigen.ToString + ") - Tránsito (" + iCantidadTransito.ToString() + ")", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.grdDetalleTransferencia.Columns("CantidadDespachada").Value = String.Empty
                        bCantidadValida = False
                    Else
                        Me.grdDetalleTransferencia.UpdateData()
                        e.Handled = True
                        Me.MoverFocoCelda(Me.grdDetalleTransferencia.Row + 1, eCamposGrid.codigo)
                        bCantidadValida = True
                        Me.ErrorProvider.Clear()
                    End If
                End If
            End If

            ''============ Al moverse con teclas direccionales ============================================================
            If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And (Me.grdDetalleTransferencia.Col = eCamposGrid.codigo Or Me.grdDetalleTransferencia.Col = eCamposGrid.descripcion Or Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadDespachada) Then
                If Me.grdDetalleTransferencia.Columns("objSivProductoID").Value.ToString.Trim.Length = 0 And Me.grdDetalleTransferencia.Row <> Me.grdDetalleTransferencia.RowCount Then
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
                If Me.grdDetalleTransferencia.Columns("objSivProductoID").Value.ToString().Trim.Length = 0 Then
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                End If
            Else
                If Me.EsRegistroDesdeBD And (Me.grdDetalleTransferencia.Columns("Marca").Value.ToString.Trim.Length <> 0) Then
                    e.Cancel = True
                    Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, My.Resources.MsgNoPuedeCambiarCodigo)
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