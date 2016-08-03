'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 20 Mayo 2010. 09:27 AM.
''-- Formulario de Edición y Modificación de solicitud de transferencia de repuestos.
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles

Public Class frmSivSoliTransferenciaEdit
    'Tipo enumerado para controlar los indices de los campos del grid detalle.
#Region "Tipo Enumerado"
    Public Enum eCamposGrid
        codigo
        descripcion
        marca
        cantidadOrigen
        cantidadDestino
        cantidadSolicitada
        transferenciaID
        marcaId
        objTiendaDestinoID
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
    Private dtDetalleTransferencia As DataTable
    Private dtDatosCombosDetalle As DataTable 'Mantiene los datos que se desplegan en los combos del grid detalle
#End Region

#Region "Constantes"
    Private Const AGREGAR = 0
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

#End Region

#Region "Cargar formulario"
    Private Sub frmSivSoliTransferenciaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.txtObservaciones.MaxLength = SivTransferencia.GetMaxLength("Observaciones")
        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.IdEstadoSolicitada = ClsCatalogos.GetValorCatalogoID("ESTADOSTRANSFERENCIA", "01") '01=Solicitada

        Me.CargarComboSitioOrigen()
        Me.CargarComboSitioDestino()

        Select Case Me.TypeGui
            Case AGREGAR
                Me.Text = "Nueva solicitud de traslado"
                Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor

                'inicializar combo de sitio Origen con CENTRAL por defecto
                Me.cmbSitioOrigen.SelectedValue = Me.IdSucursalCentral
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

                Me.txtSolicitadpor.Text = clsProyecto.Conexion.Usuario
                Me.CargarDetalleTransferencia("1=0")
                Me.cmbSitioOrigen.Focus()

            Case CONSULTAR
                Me.Text = "Consulta solicitud de traslado"
                Me.CargaDatosSolicitudTransf()
                Me.BloquerarControles(True)
                Me.cmdGuardar.Enabled = False
                Me.cmdBuscarRepuesto.Enabled = False

        End Select

        Me.HuboCambioTransf = False 'variable para verificar si se hacen cambios en los datos
        Me.HuboCambioDetalle = False

    End Sub
#End Region

#Region "Procedimientos"

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
        Me.txtSolicitadpor.Text = dtDatosTransferencia.DefaultView(0)("SolicitadoPor")

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
            dtDatos = StbTienda.RetrieveDT("ActivoRepuesto=1", "Nombre", "StbTiendaID, Codigo, Nombre")
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
            '.ValueTranslate = True
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
            '.ValueTranslate = True
            .Refresh()
        End With

        sCampos = "objRepuestoID, DescripcionCorta, Marca, CantidadOrigen, CantidadDestino, CantidadSolicitada, objTransferenciaID, objMarcaID, objTiendaDestinoID"
        'sFiltro = " objTransferenciaID =" + Me.IdSivTransferencia.ToString
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferenciasDet", sFiltroTransferencia)

        Me.dtDetalleTransferencia = SqlHelper.ExecuteQueryDT(sSQL)
        Me.grdDetalleTransferencia.SetDataBinding(Me.dtDetalleTransferencia, "", True)

        If Me.TypeGui = AGREGAR Then
            Me.FormatearGridDetalleEdicion()
        Else
            Me.FormatearGridDetalleConsulta()
        End If

        Me.HuboCambioTransf = True
        Me.HuboCambioDetalle = True
    End Sub
#End Region

#Region "Guardar solicitud transferencia"
    Private Function GuardarSolicitudTransf() As Boolean
        Dim T As New TransactionManager
        Dim objTransf As New SivTransferencia
        Dim dtDetalleTransf As New DataTable
        Dim fila As DataRow
        Try
            Try
                T.BeginTran()
                dtDetalleTransf = SivTransferenciaDetalle.RetrieveDT("1=0")
                With objTransf
                    .ObjTiendaOrigenID = Me.cmbSitioOrigen.SelectedValue
                    .ObjTiendaDestinoID = Me.cmbSitioDestino.SelectedValue
                    .Fechasolicitud = Me.dtpFecha.Value
                    .SolicitadoPor = Me.txtSolicitadpor.Text.Trim
                    .Observaciones = Me.txtObservaciones.Text.Trim
                    .ObjEstadoID = Me.IdEstadoSolicitada
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .Insert(T)
                End With
                Me.IdSivTransferencia = objTransf.SivTransferenciaID

                'Isertar detalle de solicitud de transferencia                
                Me.dtDetalleTransferencia.AcceptChanges()
                For Each row As DataRow In Me.dtDetalleTransferencia.Rows
                    fila = dtDetalleTransf.NewRow
                    fila("objTransferenciaID") = Me.IdSivTransferencia
                    fila("objTiendaDestinoID") = Me.cmbSitioDestino.SelectedValue
                    fila("objRepuestoID") = row("objRepuestoID")
                    fila("CantidadSolicitada") = row("CantidadSolicitada")
                    fila("CantidadDespachada") = 0
                    fila("CantidadRecibida") = 0
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleTransf.Rows.Add(fila)
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
    Private Sub BloquerarControles(ByVal bValor As Boolean)
        Me.cmbSitioOrigen.Enabled = Not bValor
        Me.txtObservaciones.Enabled = Not bValor
    End Sub
#End Region

#Region "Validaciones de datos"
    Private Function Validaciones() As Boolean
        Try

            If Me.dtDetalleTransferencia.Rows.Count <= 0 Then
                'MsgBox("Debe ingresar al menos un repuesto en detalle de solicitud.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Debe ingresar al menos un repuesto en detalle de solicitud.")
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
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos un registro duplicado en detalle de solicitud.")
                Return False
                Exit Function
            End If

            If Me.ExistenCantidadesEnCero Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos una cantidad solicitada con valor CERO.")
                Return False
                Exit Function
            End If

            If Not Me.CantidadesSolicitadasValidas Then
                Me.ErrorProvider.SetError(Me.grdDetalleTransferencia, "Hay al menos una cantidad solicitada con valor Incorrecto")
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
            Return Me.dtDetalleTransferencia.Select("CantidadSolicitada = 0").Length <> 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    'Función para validar al escribir en el grid
    Private Function CantidadSolicitadaValida() As Boolean
        Dim iCantidadSolicitada, iCantidadOrigen As Integer
        Dim bCantidadValida As Boolean = True
        If Me.grdDetalleTransferencia.Columns("CantidadSolicitada").Value.ToString.Trim.Length <> 0 Then
            iCantidadSolicitada = Me.grdDetalleTransferencia.Columns("CantidadSolicitada").Value
            If Me.grdDetalleTransferencia.Columns("CantidadOrigen").Value.ToString.Trim.Length <> 0 Then
                iCantidadOrigen = Me.grdDetalleTransferencia.Columns("CantidadOrigen").Value
            Else
                iCantidadOrigen = 0
            End If

            If iCantidadSolicitada = 0 Then
                bCantidadValida = False
            ElseIf iCantidadSolicitada > iCantidadOrigen Then
                MsgBox("Cantidad solicitada debe ser menor o igual a la cantidad de bodega origen.(" + iCantidadOrigen.ToString + ")", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.grdDetalleTransferencia.Columns("CantidadSolicitada").Value = String.Empty
                bCantidadValida = False
            End If
        End If
        Return bCantidadValida
    End Function

    'Función para validar al dar clic en Aceptar
    Private Function CantidadesSolicitadasValidas() As Integer
        Dim iCantidadSolicitada, iCantidadOrigen As Integer
        Dim bCantidadValida As Boolean = True

        If Me.grdDetalleTransferencia.Splits(0).Rows.Count <> 0 Then
            For i As Integer = 0 To Me.grdDetalleTransferencia.Splits(0).Rows.Count - 1
                If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadSolicitada).ToString.Trim) And (Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.codigo).ToString.Trim)) Then
                    If Not String.IsNullOrEmpty(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadOrigen).ToString.Trim) Then
                        iCantidadOrigen = Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadOrigen).ToString.Trim
                    Else
                        iCantidadOrigen = 0
                    End If
                    iCantidadSolicitada = Integer.Parse(Me.grdDetalleTransferencia.Item(i, eCamposGrid.cantidadSolicitada).ToString.Trim)

                    If iCantidadSolicitada > iCantidadOrigen Then
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
            .Columns("CantidadSolicitada").Value = 0
            .Refresh()
        End With
    End Sub

#End Region

#Region "Formatear grid detalle Edición - Consulta"
    Private Sub FormatearGridDetalleEdicion()
        With Me.grdDetalleTransferencia
            .Columns("objRepuestoID").DropDown = Me.cmbDesplegableCodigo
            .Columns("objRepuestoID").ValueItems.Translate = True
            .Columns("objRepuestoID").DataWidth = 10

            .Columns("DescripcionCorta").DropDown = Me.cmbDescripcionRepuesto
            .Columns("DescripcionCorta").DataWidth = SivRepuestos.GetMaxLength("DescripcionCorta")
            .Columns("CantidadSolicitada").DataWidth = 10 'un entero tiene precisión 10, escala 0

            .Splits(0).DisplayColumns("CantidadOrigen").AllowSizing = False
            .Splits(0).DisplayColumns("objTransferenciaID").Visible = False
            .Splits(0).DisplayColumns("objMarcaID").Visible = False
            .Splits(0).DisplayColumns("objTiendaDestinoID").Visible = False
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
            .AllowAddNew = True
            .AllowUpdate = True
            '.AllowDelete = False
            .AllowColMove = False
            .FilterBar = False
            .AllowSort = False
            .AllowColMove = False
            .EmptyRows = False 'no mostrar más filas después de la última
            .Refresh()
        End With

    End Sub

    Private Sub FormatearGridDetalleConsulta()
        With Me.grdDetalleTransferencia
            .Splits(0).DisplayColumns("objRepuestoID").Locked = True
            .Splits(0).DisplayColumns("DescripcionCorta").Locked = True
            .Splits(0).DisplayColumns("DescripcionCorta").AllowFocus = False
            .Splits(0).DisplayColumns("CantidadSolicitada").Locked = True

            .Splits(0).DisplayColumns("objRepuestoID").Style.BackColor = .Splits(0).DisplayColumns("Marca").Style.BackColor
            .Splits(0).DisplayColumns("DescripcionCorta").Style.BackColor = .Splits(0).DisplayColumns("Marca").Style.BackColor
            .Splits(0).DisplayColumns("CantidadSolicitada").Style.BackColor = .Splits(0).DisplayColumns("Marca").Style.BackColor
            .Splits(0).DisplayColumns("CantidadOrigen").AllowSizing = False
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
    Private Sub frmSivSoliTransferenciaEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If Me.HuboCambioTransf And Me.TypeGui = 1 Then
        '    If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
        '        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        '    Else
        '        Me.DialogResult = Windows.Forms.DialogResult.None
        '    End If
        'End If
    End Sub

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
            Me.grdDetalleTransferencia.Focus()
            Me.grdDetalleTransferencia.Col = 0
            Me.grdDetalleTransferencia.Row = 0
        End If
    End Sub

    Private Sub cmbSitioOrigen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSitioOrigen.TextChanged
        Me.CargarDetalleTransferencia("1=0")
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmdBuscarRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarRepuesto.Click
        Dim objBuscar As New frmBusquedaRepuestos
        Dim objRepuestoId As String

        If Me.ExistenCantidadesEnCero() Then
            MsgBox("La cantidad solicitada no puede tener valor CERO.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Me.grdDetalleTransferencia.Focus()
            Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada
        Else
            If Me.grdDetalleTransferencia.Columns("Marca").Value.ToString.Trim.Length <> 0 Then
                If Not Me.CantidadSolicitadaValida() Then
                    Me.grdDetalleTransferencia.Focus()
                    Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada
                    Exit Sub
                End If
            End If

            'Mostrar formulario de búsqueda de repuesto
            If objBuscar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                objRepuestoId = objBuscar.objRepuestoIdSeleccionado.ToString

                'Verificar si ya se encuentra el repuesto en Detalle
                If DuplicadoEnDetalle(objRepuestoId, True) Then
                    MsgBox("El repuesto seleccionado ya se encuentra en detalle de solicitud.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.grdDetalleTransferencia.Focus()
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                    Exit Sub
                End If

                'Cargar los datos del repuesto en el grid de detalle de solicitud
                Me.CargarFilaDetalleTransferencia(objRepuestoId)
                Me.grdDetalleTransferencia.Focus()
                Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada
                Me.HuboCambioDetalle = True
                Me.HuboCambioTransf = True
            End If
        End If
    End Sub

    Private Sub txtObservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservaciones.TextChanged
        Me.HuboCambioTransf = True
    End Sub

    Private Sub grdDetalleTransferencia_BeforeColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdDetalleTransferencia.BeforeColEdit
        If Me.cmbSitioOrigen.SelectedValue = Me.cmbSitioDestino.SelectedValue Then
            Me.ErrorProvider.SetError(Me.cmbSitioOrigen, "El sitio origen debe ser diferente al sitio destino.")
            e.Cancel = True
            Me.cmbSitioDestino.Focus()
        End If
    End Sub

    Private Sub frmSivSoliTransferenciaEdit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            If Me.TypeGui = CONSULTAR Then
                Close()
            End If
        End If
    End Sub

    Private Sub frmSivSoliTransferenciaEdit_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If Me.TypeGui = AGREGAR Then
            Me.cmbSitioOrigen.Focus()
        ElseIf Me.TypeGui = CONSULTAR Then
            Me.cmdCancelar.Focus()
        End If
    End Sub

#End Region

#Region "Eventos de DropDownClose de los campos de combobox"

    Private Sub cmbDescripcionRepuesto_DropDownClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDescripcionRepuesto.DropDownClose
        Try
            If DuplicadoEnDetalle(Me.cmbDescripcionRepuesto.Columns("objRepuestoID").Value.ToString, True) Then
                MsgBox("El Repuesto (" + Me.cmbDescripcionRepuesto.Columns("DescripcionCorta").Value.ToString + _
                                          ") ya está en el detalle de transferencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.grdDetalleTransferencia.Columns("DescripcionCorta").Value = String.Empty
                Me.grdDetalleTransferencia.Col = eCamposGrid.descripcion
                SendKeys.Send("{LEFT}") 'Inicializar celda descripción izquierda luego derecha
                SendKeys.Send("{RIGHT}")
            Else
                If Me.CargarFilaDetalleTransferencia(Me.cmbDescripcionRepuesto.Columns("objRepuestoID").Value.ToString.Trim) Then
                    'Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada
                    SendKeys.Send("{ENTER}")
                Else
                    InicializarDatosFilaDetalle()
                    SendKeys.Send("{LEFT}") 'Inicializar celda descripción izquierda luego derecha
                    SendKeys.Send("{RIGHT}")
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbDesplegableCodigo_DropDownClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDesplegableCodigo.DropDownClose
        Try
            If Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.ToString.Trim.Length = 0 Then 'ha seleccionado del combo sin escribir nada en código
                If DuplicadoEnDetalle(Me.cmbDesplegableCodigo.Columns("objRepuestoID").Value.ToString, False) Then
                    MsgBox("El Repuesto (" + Me.cmbDesplegableCodigo.Columns("DescripcionCorta").Value.ToString + _
                                              ") ya está en el detalle de transferencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.grdDetalleTransferencia.Columns("objRepuestoID").Value = String.Empty
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                    SendKeys.Send("{ESC}")
                    SendKeys.Send("{DOWN}")
                Else
                    If Me.CargarFilaDetalleTransferencia(Me.cmbDesplegableCodigo.Columns("objRepuestoID").Value.ToString.Trim) Then
                        SendKeys.Send("{ENTER}")
                        'Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada
                    Else
                        Me.InicializarDatosFilaDetalle()
                        SendKeys.Send("{RIGHT}") 'Inicializar celda código moviendose a la derecha luego a izquierda
                        SendKeys.Send("{LEFT}")
                    End If
                    'Else
                    'MsgBox("El código repuesto ingresado (" + Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.Trim + _
                    '       ") no exite.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    'Me.grdDetalleTransferencia.Columns("objRepuestoID").Value = String.Empty
                    'Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                    'SendKeys.Send("{LEFT}")
                End If
            Else
                If Me.ExisteCodigoRepuesto(Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.Trim) Then
                    If Not Me.CargarFilaDetalleTransferencia(Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.Trim) Then
                        SendKeys.Send("{LEFT}") 'por si se había movido a celda descripción volver a código
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar fila detalle transferencia"
    Private Function CargarFilaDetalleTransferencia(ByVal sIdRepuesto As String) As Boolean
        Dim sCampos, sFiltro, sSQL As String
        Dim dtDatos As DataTable
        Dim iCantidadOrigen, iCantidadDestino As Integer
        Dim bResultado As Boolean = False
        Try
            If Not String.IsNullOrEmpty(sIdRepuesto) Then
                sCampos = "DescripcionCorta, objMarcaID, Marca, Cantidad, objTiendaID"
                sFiltro = " SivRepuestoID ='" + sIdRepuesto + "' AND (objTiendaID=" + Me.cmbSitioOrigen.SelectedValue.ToString + " OR objTiendaID=" + Me.cmbSitioDestino.SelectedValue.ToString + ")"
                sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSivSolicitudesTransferenciasCargarDet", sFiltro)

                dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

                If dtDatos.Rows.Count > 0 Then
                    'Obteniendo cantidad Origen
                    dtDatos.DefaultView.RowFilter = "objTiendaID=" + Me.cmbSitioOrigen.SelectedValue.ToString

                    If dtDatos.DefaultView.Count > 0 Then
                        iCantidadOrigen = Integer.Parse(dtDatos.DefaultView.Item(0)("Cantidad").ToString.Trim)
                    Else
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
                            .Columns("CantidadSolicitada").Value = 0
                            .Refresh()
                        End With
                        Me.grdDetalleTransferencia.UpdateData()
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

#Region "Eventos de KeyPress, KeyDown del Grid Detalle"
    'Bloquear para permitir solo números enteros.
    Private Sub grdDetalleTransferencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdDetalleTransferencia.KeyPress
        Try
            If Me.grdDetalleTransferencia.Col = eCamposGrid.codigo Or Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada Then
                If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
                    e.KeyChar = Chr(0)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grdDetalleTransferencia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleTransferencia.KeyDown
        Dim iCantidadSolicitada, iCantidadOrigen As Integer
        Dim bCantidadValida As Boolean = False

        If Me.TypeGui = CONSULTAR Then 'Modo consulta
            Exit Sub
        End If

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

            '=============  Validación de algunas columnas =====================================
            'Obteniendo valor de cantidad solicitada para validacion posterior
            If Me.grdDetalleTransferencia.Columns("CantidadSolicitada").Value.ToString.Trim.Length <> 0 Then
                iCantidadSolicitada = Me.grdDetalleTransferencia.Columns("CantidadSolicitada").Value
                If Me.grdDetalleTransferencia.Columns("CantidadOrigen").Value.ToString.Trim.Length <> 0 Then
                    iCantidadOrigen = Me.grdDetalleTransferencia.Columns("CantidadOrigen").Value
                Else
                    iCantidadOrigen = 0
                End If
                If iCantidadSolicitada = 0 Then
                    bCantidadValida = False
                Else
                    If (iCantidadSolicitada > iCantidadOrigen) Then
                        bCantidadValida = False
                    Else
                        bCantidadValida = True
                    End If
                End If
            Else
                iCantidadSolicitada = 0
                iCantidadOrigen = 0
            End If

            'Si se presiona Enter y estamos en la columna [cantidadSolicitada]
            If e.KeyCode = Keys.Enter And Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada Then
                If Me.grdDetalleTransferencia.RowCount <> 0 Then
                    'Validaciones en la Cantidas Solicitada  
                    If iCantidadSolicitada = 0 Then
                        MsgBox("Cantidad solicitada debe ser mayor que CERO.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    ElseIf Me.grdDetalleTransferencia.Columns("objRepuestoID").Value.ToString.Trim.Length = 0 Then
                        MsgBox("Debe escribir un código de Repuesto válido.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                        bCantidadValida = False
                    ElseIf iCantidadSolicitada > iCantidadOrigen Then
                        MsgBox("Cantidad solicitada debe ser menor o igual a la cantidad de bodega origen.(" + iCantidadOrigen.ToString + ")", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.grdDetalleTransferencia.Columns("CantidadSolicitada").Value = String.Empty
                        bCantidadValida = False
                    Else
                        Me.grdDetalleTransferencia.UpdateData()
                        Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                        Me.grdDetalleTransferencia.Row = Me.grdDetalleTransferencia.Row + 1
                        bCantidadValida = True
                    End If
                End If
                'Si presiona Enter y estamos en la columna [código]
            ElseIf (e.KeyCode = Keys.Enter) And Me.grdDetalleTransferencia.Col = eCamposGrid.codigo Then
                If Me.ExisteCodigoRepuesto(Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.Trim) Then
                    If DuplicadoEnDetalle(Me.grdDetalleTransferencia.Columns("objRepuestoID").Text.Trim, False) Then
                        MsgBox("El Repuesto escrito ya está en el detalle de transferencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.InicializarDatosFilaDetalle()
                        Me.grdDetalleTransferencia.Focus()
                        Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                        If e.KeyCode = Keys.Right Then
                            e.SuppressKeyPress = True
                        End If
                    Else
                        If Me.CargarFilaDetalleTransferencia(Me.grdDetalleTransferencia.Columns("objRepuestoID").Value.ToString.Trim) Then
                            Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada
                        Else
                            SendKeys.Send("{RIGHT}") 'Inicializar celda código moviendose a la derecha luego a izquierda
                            SendKeys.Send("{LEFT}")
                        End If
                    End If
                Else
                    MsgBox("Debe escribir un código de Repuesto válido.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    InicializarDatosFilaDetalle()
                    Me.grdDetalleTransferencia.Col = eCamposGrid.codigo
                    SendKeys.Send("{RIGHT}") 'Inicializar celda código moviendose a la derecha luego a izquierda
                    SendKeys.Send("{LEFT}")
                End If
            End If

            '============ Restringir movimientos ============================================================
            'Si presiona direccional hacia abajo o hacia arriba y no se ha escrito la cantidad solicitada o esta es cero entonces bloquear
            If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And Me.grdDetalleTransferencia.Columns("Marca").Value.ToString.Trim.Length <> 0 Then
                If Not bCantidadValida And Me.grdDetalleTransferencia.Row <> Me.grdDetalleTransferencia.RowCount Then
                    e.SuppressKeyPress = True
                End If
            ElseIf (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And (Me.grdDetalleTransferencia.Col = eCamposGrid.codigo Or Me.grdDetalleTransferencia.Col = eCamposGrid.descripcion Or Me.grdDetalleTransferencia.Col = eCamposGrid.cantidadSolicitada) Then
                If Me.grdDetalleTransferencia.Columns("objRepuestoID").Value.ToString.Trim.Length = 0 And Me.grdDetalleTransferencia.Row <> Me.grdDetalleTransferencia.RowCount Then
                    Try
                        'Me.dtDetalleTransferencia.DefaultView.Delete(Me.grdDetalleTransferencia.Row)
                        Me.grdDetalleTransferencia.Delete(Me.grdDetalleTransferencia.Row)
                    Catch 'si ocurre error al eliminar que no haga nada.
                    End Try
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

End Class