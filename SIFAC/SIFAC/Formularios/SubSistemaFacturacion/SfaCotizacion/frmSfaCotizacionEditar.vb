'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Enrique Escobar Maradiaga.
''-- Fecha de Elaboración    : 02 Junio 2010.
''-- Modificado por          : Gelmin Martínez, 29 Julio 2010, 06:27 pm.
''-- Formulario de Agregación de Cotización
''------------------------------------------------------------------------------------------------

Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SIFAC.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid
Imports System.Windows.Forms.Cursors

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmSfaCotizacionEditar

#Region "Variables del formulario"
    Dim dtDescripcionCotizacion, dtDetalleCotizacion, dtDetalleCotizacionDE As DataTable
    Dim dsDetalleCotizacion As DataSet
    Dim dtDatosCliente As DataTable
    Dim dtExpedienteCxC As DataTable
    Dim dsExpedienteCxC As DataSet
    Dim PorcentajeImpuesto As Integer
    Dim boolModificado As Boolean
    Dim boolExisteErroresGrid As Boolean

    Private m_TypeGui As Integer
    Private m_SfaCotizacionID As String

    Dim strCodigoSucursal As String
    Private m_MaxItemsDetalle As Integer

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

    Property SfaCotizacionID() As String
        Get
            SfaCotizacionID = Me.m_SfaCotizacionID
        End Get
        Set(ByVal value As String)
            Me.m_SfaCotizacionID = value
        End Set
    End Property

    Property MaxItemDetalle() As Integer
        Get
            MaxItemDetalle = Me.m_MaxItemsDetalle
        End Get
        Set(ByVal value As Integer)
            Me.m_MaxItemsDetalle = value
        End Set
    End Property

#End Region

#Region "Inicializar Pantalla"

#Region "Inicializar GUI"
    Private Sub InicializarGui()
        Me.dtpFechaCotizacion.Value = clsProyecto.Conexion.FechaServidor
        Me.dtpFechaCotizacion.Focus()

        CargarTasaCambio()
        PorcentajeImpuesto = StbParametro.RetrieveDT("Nombre = 'PORCENTAJEIMPUESTO'", , "Valor").DefaultView.Item(0)("Valor")
        Me.txtNumeroCotizacion.Text = Me.NuevoID
        LongitudesMaximas()
        CargarValidezCotizacion()
        strCodigoSucursal = clsProyecto.Sucursal
        CargarSucursal()
        CargarVendedor()
        CargarCliente()
        CargarTiempoEntrega()
        CargarTerminoPago()
        CargarDescripcionDE("1=1 AND SivRepuestoID NOT IN ('1','2')")

        boolModificado = False
    End Sub
#End Region

#Region "Longitudes Maximas"

    Private Sub LongitudesMaximas()
        Me.txtAtencionA.MaxLength = SfaCotizacion.GetMaxLength("AtencionA")
        Me.txtComentarios.MaxLength = SfaCotizacion.GetMaxLength("Comentario")
    End Sub

#End Region

#Region "Cargar Validez Cotizacion"
    Private Sub CargarValidezCotizacion()
        Dim intDiasValidez As Integer
        intDiasValidez = StbParametro.RetrieveDT("Nombre = 'VALIDEZCOTIZACION'", , "Valor").DefaultView.Item(0)("Valor")
        Me.NumValido.Value = intDiasValidez
    End Sub
#End Region

#Region "Cargar Combos"

#Region "Sucursal"
    Private Sub CargarSucursal()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("Codigo=" & "'" & strCodigoSucursal & "'" & " AND ActivoRepuesto=1", "Codigo", "StbTiendaID, Nombre")
            If dtDatos.Rows.Count <> 0 Then
                With Me.cmbSucursal
                    .DataSource = dtDatos
                    .DisplayMember = "Nombre"
                    .ValueMember = "StbTiendaID"
                    .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                    .ExtendRightColumn = True
                    .SelectedIndex = 0
                    .ColumnHeaders = False
                End With
            Else
                MsgBox("La sucursal en sesión no está habilitada para repuestos, Habilite (Activo Repuesto) para esta sucursal o inice sesión con otra tienda.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.Close()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Cliente"
    Private Sub CargarCliente()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID, Cliente", "vwSfaClienteCotizacion", "1=1 ORDER BY Cliente"))
            With Me.cmbCliente
                .DataSource = dtDatos
                .DisplayMember = "Cliente"
                .ValueMember = "StbPersonaID"
                .Splits(0).DisplayColumns("StbPersonaID").Visible = False
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

#Region "Tiempo Entrega"
    Private Sub CargarTiempoEntrega()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "(objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIEMPOENTREGA'))"))
            With cmbTiempoEntrega
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .SelectedIndex = 0
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Término de pago"
    Private Sub CargarTerminoPago()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TERMINOPAGO')"))
            With Me.cmbTerminoPago
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True

                'Validacion de acuerdo a la sucursal
                .SelectedIndex = 0
                If clsProyecto.Sucursal = "C" Then
                    .Enabled = True
                Else
                    .Enabled = False
                End If

                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Vendedor"
    Private Sub CargarVendedor()
        Dim dtDatos As New DataTable
        Dim login As String
        Try
            login = clsProyecto.Conexion.Usuario
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SrhEmpleadoID,Login,NombreEmpleado", "vwSfaVendedorCotizacion", "Login=" & "'" & clsProyecto.Conexion.Usuario & "'"))
            If dtDatos.DefaultView.Count > 0 Then
                With Me.cmbVendedor
                    .DataSource = dtDatos
                    .DisplayMember = "NombreEmpleado"
                    .ValueMember = "SrhEmpleadoID"
                    .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
                    .ExtendRightColumn = True
                    .SelectedIndex = 0
                    .ColumnHeaders = False
                End With
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#End Region

#Region "Cargar Descripción grid DE"

    Private Sub CargarDescripcionDE(ByVal strFiltro As String)
        Dim riLookComboDescripcion As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Try
            dtDescripcionCotizacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivRepuestoID,DescripcionCorta", "vwSfaCotizacionRepProv", strFiltro & " ORDER BY DescripcionCorta"))
            riLookComboDescripcion = Me.grdDetalleCotizacionDE.RepositoryItems(1)
            riLookComboDescripcion.DataSource = dtDescripcionCotizacion
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDescripcionCotizacion = Nothing
        End Try
    End Sub

#End Region

#End Region

#Region "Procedimientos"

#Region "Cargar Estructura del grid DE"

    Private Sub CargarDetalleCotizacionDE()
        Try
            dtDetalleCotizacionDE = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID, objTipoRepuesto,CodigoBarras, CodigoRepuesto, DescripcionCorta, Cantidad, Precio, Subtotal, PorcentajeDescuento,Descuento, Impuesto, Total, Existencia,CostoProm", "vwSfaCotizacionDetalleEditar", "1=0 ORDER BY objRepuestoID"))
            Me.grdDetalleCotizacionDE.DataSource = dtDetalleCotizacionDE

            FormatearGrid(Me.grdDatosExpediente, "DetalleExpediente")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDetalleCotizacion = Nothing
        End Try
    End Sub

#End Region

#Region "Formatear Grid"

    Private Sub FormatearGrid(ByVal Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal Tipo As String)
        Grid.FilterBar = False
        Grid.VisualStyle = VisualStyle.Office2007Black
        Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell

        If (Tipo = "DetalleExpediente") Then
            Grid.Splits(0).DisplayColumns("Numero").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Numero").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Moto").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Moto").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Saldo").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Saldo").Style.BackColor = Color.LemonChiffon
            Grid.Splits(0).DisplayColumns("Saldo").Locked = True

        End If

    End Sub

#End Region

#Region "Procedimientos para el Grid"

#Region "Insertar una nueva fila en el grid"
    Private Sub InsertarNuevaFilaGrid()
        Try
            If Me.grdDetalleCotizacionDETabla.RowCount < Me.MaxItemDetalle Then
                Me.dtDetalleCotizacionDE.Rows.Add()
                Me.grdDetalleCotizacionDETabla.MoveLast()
                Me.grdDetalleCotizacionDETabla.FocusedColumn = Me.colBarCode
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Es fila vacía"
    Private Function EsFilaVacia() As Boolean
        Dim blnRetorno As Boolean = False
        Dim Valor As New Object
        Try
            Valor = Me.grdDetalleCotizacionDETabla.Columns("CodigoRepuesto").View.GetRowCellValue(Me.grdDetalleCotizacionDETabla.FocusedRowHandle, "CodigoRepuesto")
            blnRetorno = Not Me.TieneValor(Valor)
        Catch ex As Exception
            blnRetorno = False
        End Try
        Return blnRetorno
    End Function
#End Region

#Region "Tiene Valor"

    Private Function TieneValor(ByVal Valor As Object) As Boolean
        If Not Valor Is Nothing Then
            Return (Not IsDBNull(Valor)) AndAlso Valor.ToString.Trim.Length <> 0
        Else
            Return False
        End If
    End Function

#End Region

#Region "Eliminar sin Preguntar"
    Private Sub ElminarFilaSinPreguntar()
        Try
            If Me.dtDetalleCotizacionDE.Rows.Count <> 0 Then
                Me.dtDetalleCotizacionDE.Rows.RemoveAt(Me.grdDetalleCotizacionDETabla.FocusedRowHandle) 'Borra la fila del datatable directo
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Eliminar Fila"
    Private Sub EliminarFila()
        If MsgBox("¿Seguro que desea eliminar la fila seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes Then
            Try
                Me.dtDetalleCotizacionDE.Rows.RemoveAt(Me.grdDetalleCotizacionDETabla.FocusedRowHandle) 'Borra la fila del datatable directo
                boolExisteErroresGrid = False
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region

#Region "Existe en detalle"
    Private Function ExisteEnDetalle(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        Dim strValorCampo As String
        For Each row As DataRow In Me.dtDetalleCotizacionDE.Rows
            If Me.TieneValor(valor) AndAlso Me.TieneValor(row(Campo)) Then
                strValorCampo = row(Campo)
                If valor.ToString.Trim = strValorCampo.Trim Then
                    blnValor = True
                End If
            End If
        Next
        Return blnValor
    End Function
#End Region

#Region "Número Válido"
    Private Function NumeroValidoString(ByVal valor As Object) As Boolean
        If Not valor Is Nothing Then
            If Me.TieneValor(valor) Then
                If valor.ToString.Trim.Length <> 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return False
        End If
    End Function

    Private Function NumeroValido(ByVal valor As Object) As Boolean
        If Not valor Is Nothing Then
            If Me.TieneValor(valor) Then
                If valor <> 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "Está en última fila"
    Private Function EstaEnUltimaFila() As Boolean
        Return Me.grdDetalleCotizacionDETabla.FocusedRowHandle = Me.grdDetalleCotizacionDETabla.RowCount - 1
    End Function
#End Region

#Region "Buscar Duplicados en Grid"
    Private Function BuscarDuplicados(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        Dim iContador As Integer = 0
        Dim strValorCampo As String
        If Me.dtDetalleCotizacionDE.Rows.Count > 1 Then
            For Each row As DataRow In Me.dtDetalleCotizacionDE.Rows
                row.EndEdit()
                If Me.TieneValor(valor) AndAlso Me.TieneValor(row(Campo)) Then
                    strValorCampo = row(Campo)
                    If valor.ToString.Trim.Equals(strValorCampo.Trim) Then
                        iContador += 1
                    End If
                End If
            Next
            If iContador > 1 Then
                blnValor = True
            Else
                blnValor = False
            End If
        End If
        Return blnValor
    End Function
#End Region

#Region "Existen Cantidades en CERO"
    Private Function ExistenCantidadesEnCero() As Boolean
        Return Me.dtDetalleCotizacionDE.Select("Cantidad=0").Length > 0
    End Function
#End Region

#Region "Habilitar Precio y Descuento"
    Private Sub HabilitarPrecioDescuento(ByVal Habilitar As Boolean)
        If Habilitar Then
            Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").OptionsColumn.AllowFocus = True
            Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").AppearanceCell.BackColor = Color.White
            Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").OptionsColumn.ReadOnly = False

            Me.grdDetalleCotizacionDETabla.Columns("Precio").OptionsColumn.AllowFocus = True
            Me.grdDetalleCotizacionDETabla.Columns("Precio").AppearanceCell.BackColor = Color.White
            Me.grdDetalleCotizacionDETabla.Columns("Precio").OptionsColumn.ReadOnly = False
        Else
            Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").OptionsColumn.AllowFocus = True
            Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").AppearanceCell.BackColor = Color.LemonChiffon
            Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").OptionsColumn.ReadOnly = True

            Me.grdDetalleCotizacionDETabla.Columns("Precio").OptionsColumn.AllowFocus = False
            Me.grdDetalleCotizacionDETabla.Columns("Precio").AppearanceCell.BackColor = Color.LemonChiffon
            Me.grdDetalleCotizacionDETabla.Columns("Precio").OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "Id Respuesto Seleccionado"
    Private Function IdRepuestoSeleccionado() As String
        Dim CodigoRepuesto As Object = Me.grdDetalleCotizacionDETabla.Columns("CodigoRepuesto").View.GetRowCellValue(Me.grdDetalleCotizacionDETabla.FocusedRowHandle, "CodigoRepuesto")
        If Not Me.NumeroValidoString(CodigoRepuesto) Then
            CodigoRepuesto = "0"
        End If
        Return CodigoRepuesto
    End Function
#End Region

#End Region

#Region "Cargar Tasa de Cambio del Mes"
    Private Sub CargarTasaCambio()
        Dim dtTasaCambio As DataTable
        Dim MesFormateado As Integer
        Dim AnioFormateado As Integer
        Dim strFiltro As String

        MesFormateado = Month(clsProyecto.Conexion.FechaServidor)
        AnioFormateado = Year(clsProyecto.Conexion.FechaServidor)

        strFiltro = "Mes=" & MesFormateado & " AND Anio=" & AnioFormateado & " AND objMonedaID=(SELECT StbValorCatalogoID FROM StbValorCatalogo WHERE objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MONEDA') AND Codigo='USD')"

        dtTasaCambio = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Monto", "StbTasaCambioOficial", strFiltro))

        If dtTasaCambio.DefaultView.Count = 0 Then
            MsgBox("Registre la Tasa de Cambio del mes Actual", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Me.Close()
            Exit Sub
        End If

        Me.NumTasaCambio.Value = dtTasaCambio.DefaultView.Item(0)("Monto")

    End Sub
#End Region

#Region "Cargar Datos del Cliente"

    Private Sub CargarDatosCliente(ByVal strFiltroCliente As String)
        dtDatosCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,Telefonos, Emails, Direccion,Exonerado", "vwSfaClienteCotizacion", "StbPersonaID=" & "'" & strFiltroCliente & "'"))

        If dtDatosCliente.DefaultView.Count > 0 Then
            Me.txtNumCliente.Text = dtDatosCliente.DefaultView.Item(0)("StbPersonaID")
            Me.cmbCliente.SelectedValue = dtDatosCliente.DefaultView.Item(0)("StbPersonaID")
            If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("Telefonos")) Then
                Me.txtTelefonos.Text = dtDatosCliente.DefaultView.Item(0)("Telefonos")
            Else
                Me.txtTelefonos.Text = "No definido"
            End If
            If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("Emails")) Then
                Me.txtEmails.Text = dtDatosCliente.DefaultView.Item(0)("Emails")
            Else
                Me.txtEmails.Text = "No definido"
            End If
            If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("Direccion")) Then
                Me.txtDireccion.Text = dtDatosCliente.DefaultView.Item(0)("Direccion")
            Else
                Me.txtDireccion.Text = "No definido"
            End If
            Me.chkExonerado.Checked = dtDatosCliente.DefaultView.Item(0)("Exonerado")
        Else
            Me.txtNumCliente.Text = ""
            Me.cmbCliente.SelectedIndex = -1
            Me.txtTelefonos.Text = ""
            Me.txtEmails.Text = ""
            Me.txtDireccion.Text = ""
            Me.chkExonerado.Checked = False
        End If
    End Sub

    Private Sub CargarExpedienteCxCCliente(ByVal strFiltroCliente As String)
        Try
            dtExpedienteCxC = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Numero, Moto, Saldo", "vwSfaExpCxCCotizacion", "objClienteID=" & "'" & strFiltroCliente & "'"))
            dsExpedienteCxC = New DataSet
            dsExpedienteCxC.Merge(dtExpedienteCxC)
            dsExpedienteCxC.Tables(0).TableName = "vwSfaExpCxCCotizacion"
            Me.grdDatosExpediente.SetDataBinding(dsExpedienteCxC, "vwSfaExpCxCCotizacion", True)
            dsExpedienteCxC.Tables("vwSfaExpCxCCotizacion").DefaultView.Sort = "Numero"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Consultar Datos Cliente"

    Private Sub ConsultarDatosCliente()
        Dim objPersonas As frmStbPersonasEditar
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbPersonasEditar
            objPersonas.TyGui = 3

            objPersonas.frmLlamado = 4
            objPersonas.idpersona = Me.cmbCliente.SelectedValue

            objPersonas.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub


#End Region

#Region "Agregar Datos Cliente"
    Private Sub AgregarCliente()
        Dim objPersonas As frmStbPersonasEditar
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbPersonasEditar
            objPersonas.TyGui = 1
            objPersonas.frmLlamado = 4

            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarCliente()
                Me.cmbCliente.SelectedValue = objPersonas.idpersona
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Busqueda de Repuestos"
    Private Sub BusquedaRepuestos()
        Dim objBuscar As New frmBusquedaRepuestos
        Dim objRepuestoId As String

        'Mostrar formulario de búsqueda de repuesto
        objBuscar.strFiltro = " ( SivRepuestoID NOT IN (1,2))"
        If objBuscar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            objRepuestoId = objBuscar.objRepuestoIdSeleccionado.ToString

            'Verificar si ya se encuentra el repuesto en Detalle
            If ExisteEnDetalle(objRepuestoId, "CodigoRepuesto") Then
                MsgBox("El repuesto seleccionado ya se encuentra en detalle de cotización.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.grdDetalleCotizacionDE.Focus()
                Exit Sub
            End If

            'Cargar los datos del repuesto en el grid de detalle de cotización
            Me.grdDetalleCotizacionDE.Focus()
            If Not Me.EsFilaVacia Then
                Me.InsertarNuevaFilaGrid()
            End If
            Me.RellenarDatosGrid(objRepuestoId, Me.grdDetalleCotizacionDETabla.FocusedRowHandle)
            Me.boolModificado = True
            Me.grdDetalleCotizacionDETabla.RefreshData()
        End If

    End Sub

#End Region

#Region "Calcular Totales"
    Private Sub CalcularTotales()
        Dim DecSubTotal, DecDescuento, DecIVA, DecTotalCord As Double

        Try
            DecSubTotal = 0.0
            DecDescuento = 0.0
            DecIVA = 0.0
            DecTotalCord = 0.0

            If Not Me.dtDetalleCotizacionDE Is Nothing Then
                If Me.dtDetalleCotizacionDE.DefaultView.Count > 0 Then
                    DecSubTotal = Me.dtDetalleCotizacionDE.Compute("SUM(Subtotal)", "1=1")
                    DecDescuento = Me.dtDetalleCotizacionDE.Compute("SUM(Descuento)", "1=1")
                    DecIVA = Me.dtDetalleCotizacionDE.Compute("SUM(Impuesto)", "1=1")
                    DecTotalCord = Me.dtDetalleCotizacionDE.Compute("SUM(Total)", "1=1")
                End If
            End If

            Me.NumSubTotal.Value = DecSubTotal * NumTasaCambio.Value
            Me.NumDescuento.Value = DecDescuento * NumTasaCambio.Value
            Me.NumIVA.Value = DecIVA * NumTasaCambio.Value
            Me.NumTotalCordobas.Value = DecTotalCord * NumTasaCambio.Value
            Me.NumTotalDolares.Value = DecTotalCord

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Generar Nuevo ID"
    Private Function NuevoID() As String
        Dim sSQL As String = "select ISNULL(MAX(CAST(SivEntradaBodegaID AS INT)),0)+1 AS NuevoID FROM SivEntradaBodega"
        Dim dr As SqlDataReader = Nothing
        Dim IntNuevoID As Integer
        Try
            Try
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
                If dr.Read() Then
                    IntNuevoID = dr("NuevoID")
                End If
                Return CStr(IntNuevoID)
            Catch ex As Exception
                Return False
            End Try
        Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try
    End Function

#End Region

#Region "Limpiar Grid"

    Private Sub LimpiarGrid()
        If Me.grdDetalleCotizacionDETabla.RowCount > 0 Then
            MsgBox("Al cambiar los Repuestos del Detalle de Entrada.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Me.CargarDetalleCotizacionDE()
        End If
        Me.boolModificado = True
    End Sub

#End Region

#Region "Cargar combos"

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de sitio Destino
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Mayo de 2010, 11:20 am.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboSitioDestino()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("ActivoRepuesto=1", "Codigo", "StbTiendaID, Nombre")
            With Me.cmbCliente
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                '.Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("StbTiendaID").Width = 30
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

#Region "Guardar Entrada"
    Private Function AgregarCotizacion() As Boolean
        Dim T As New TransactionManager
        Try
            Try
                T.BeginTran()

                Me.GuardarCotizacion(T)
                Me.GuardarCotizacionDetalle(T)

                boolModificado = False
                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.ImprimirCotizacion()
                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            T = Nothing
        End Try
    End Function

    Private Sub GuardarCotizacion(ByVal T As DAL.TransactionManager)
        Dim objSfaCotizacion As SfaCotizacion
        Try
            objSfaCotizacion = New SfaCotizacion
            objSfaCotizacion.Fecha = Me.dtpFechaCotizacion.Value
            If (Me.cmbCliente.Text.Trim <> "") Then
                objSfaCotizacion.objClienteID = cmbCliente.SelectedValue
            End If
            objSfaCotizacion.objTiendaID = Me.cmbSucursal.SelectedValue
            If (Me.cmbVendedor.Text.Trim <> "") Then
                objSfaCotizacion.objVendedorID = cmbVendedor.SelectedValue
            End If
            If (Me.txtAtencionA.Text.Trim <> "") Then
                objSfaCotizacion.AtencionA = txtAtencionA.Text.Trim
            End If
            objSfaCotizacion.Valido = Me.NumValido.Value
            objSfaCotizacion.Subtotal = Me.NumSubTotal.Value
            objSfaCotizacion.Descuento = Me.NumDescuento.Value
            objSfaCotizacion.Impuesto = Me.NumIVA.Value
            objSfaCotizacion.TotalDolares = Me.NumTotalDolares.Value
            objSfaCotizacion.TotalCordobas = Me.NumTotalCordobas.Value
            objSfaCotizacion.objTiempoEntregaID = Me.cmbTiempoEntrega.SelectedValue
            objSfaCotizacion.objTerminoPagoID = Me.cmbTerminoPago.SelectedValue
            objSfaCotizacion.TasaCambio = Me.NumTasaCambio.Value
            If (Me.txtComentarios.Text.Trim <> "") Then
                objSfaCotizacion.Comentario = txtComentarios.Text.Trim
            End If
            objSfaCotizacion.Anulada = 0
            objSfaCotizacion.ComentarioAnular = "---"
            objSfaCotizacion.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSfaCotizacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSfaCotizacion.Insert(T)
            Me.SfaCotizacionID = objSfaCotizacion.SfaCotizacionID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarCotizacionDetalle(ByVal T As DAL.TransactionManager)
        Dim objSfaCotizacionDetalle As SfaCotizacionDetalle
        Dim dtDetalleCot As New DataTable
        Dim fila As DataRow

        Try
            objSfaCotizacionDetalle = New SfaCotizacionDetalle
            dtDetalleCot = SfaCotizacionDetalle.RetrieveDT("1=0")

            'Isertar detalle de Cotizaciones              
            Me.dtDetalleCotizacionDE.AcceptChanges()
            For Each row As DataRow In Me.dtDetalleCotizacionDE.Rows
                fila = dtDetalleCot.NewRow
                fila("objCotizacionID") = Me.SfaCotizacionID
                fila("objRepuestoID") = row("CodigoRepuesto")
                fila("Cantidad") = row("Cantidad")
                fila("Precio") = row("Precio")
                fila("Subtotal") = row("Subtotal")
                fila("PorcentajeDescuento") = row("PorcentajeDescuento")
                fila("Descuento") = row("Descuento")
                fila("Impuesto") = row("Impuesto")
                fila("Total") = row("Total")
                fila("CostoDolares") = row("CostoProm")
                fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                dtDetalleCot.Rows.Add(fila)
            Next

            dtDetalleCot.TableName = "SfaCotizacionDetalle"
            SfaCotizacionDetalle.BatchUpdate(dtDetalleCot.DataSet, T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ImprimirCotizacion()
        Dim strFiltro, strSQL, strCampos As String
        Dim dtDatos As DataTable
        Dim Visor As New frmVisorRS
        Try

            Select Case MsgBox("¿Desea imprimir la Hoja de Cotizacion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    strFiltro = "Numero=" & SfaCotizacionID
                    strCampos = "Numero, NumeroFormateado, objTiendaID, Nombre, objClienteID, Cliente, AtencionA, TelefonosCliente, FaxsCliente, EmailsCliente, DireccionCliente, Fecha, FechaReal, objVendedorID, Vendedor, TelefonoVendedor, CelularVendedor, EmailVendedor, CodigoRepuesto, DescripcionCorta, Cantidad, Precio, Descuento, Impuesto, Total, SubtotalMaestro, DescuentoMaestro, ImpuestoMaestro, TotalDolares, TotalCordobas, objTiempoEntregaID, TiempoEntrega, TasaCambio, Valido, objTerminoPagoID, TerminoPago, Comentario, Anulada"
                    strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptSfaCotizacion", strFiltro + " ORDER BY Numero")
                    dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

                    With Visor.VisorReportes
                        .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                        .LocalReport.ReportEmbeddedResource = "SCCUM.rptCotizacion.rdlc"
                        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DtRptCotizacion_vwRptSfaCotizacion", dtDatos))
                        Me.CargarEncabezadoReporte(.LocalReport)
                        .RefreshReport()
                    End With
                    Visor.ShowDialog()
                Case MsgBoxResult.No
                    Me.DialogResult = Windows.Forms.DialogResult.OK
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
            Visor = Nothing
        End Try

    End Sub

    Private Sub CargarEncabezadoReporte(ByRef reporte As Microsoft.Reporting.WinForms.LocalReport)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim strNombreEmpresa, strDirEmpresa, strTelEmpresa, strEmailEmpresa, strRUC, strSlogan As String

        strNombreEmpresa = ClsCatalogos.GetValorParametro("EMPRESA")
        strDirEmpresa = ClsCatalogos.GetValorParametro("DireccionEmpresa")
        strTelEmpresa = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
        strEmailEmpresa = ClsCatalogos.GetValorParametro("EMAIL")
        strRUC = ClsCatalogos.GetValorParametro("AutorizacionDGI")
        strSlogan = ClsCatalogos.GetValorParametro("ESLOGAN")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmNombreEmpresa", strNombreEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDireccionEmpresa", strDirEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmTelefonoEmailEmpresa", "Teléfono: " & strTelEmpresa & " Email: " & strEmailEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmRUCEmpresa", "RUC: " & strRUC, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmSloganEmpresa", strSlogan, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmUsuarioLogeado", clsProyecto.Conexion.Usuario, False))

        reporte.SetParameters(parametros)
    End Sub

#End Region

#Region "Validaciones de datos"

#Region "Entrada Datos"
    Private Function Validaciones() As Boolean
        Try
            If Me.cmbSucursal.Text.Trim = "" Then
                Me.ErrorProvider.SetError(cmbSucursal, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If (Me.txtAtencionA.Text.Trim = "") Then
                Me.ErrorProvider.SetError(txtAtencionA, My.Resources.MsgObligatorio)
                Return False
                Me.txtAtencionA.Focus()
                Exit Function
            End If

            If Me.cmbTiempoEntrega.Text.Trim = "" Then
                Me.ErrorProvider.SetError(cmbTiempoEntrega, My.Resources.MsgObligatorio)
                Return False
                Me.cmbTiempoEntrega.Focus()
                Exit Function
            End If

            If Me.NumValido.Value = 0 Then
                Me.ErrorProvider.SetError(Me.NumValido, "Los días válidos tienen que ser mayor que cero.")
                Return False
                Me.NumValido.Focus()
                Exit Function
            End If

            If Me.cmbTerminoPago.Text.Trim = "" Then
                Me.ErrorProvider.SetError(cmbTerminoPago, My.Resources.MsgObligatorio)
                Return False
                Me.cmbTerminoPago.Focus()
                Exit Function
            End If

            If Me.dtDetalleCotizacionDE.Rows.Count <= 0 Then
                Me.ErrorProvider.SetError(Me.gbxDetalle, "Debe registrar al menos un repuesto en detalle de cotización.")
                Return False
                Exit Function
            End If

            If Me.ExistenCantidadesEnCero Then
                Me.ErrorProvider.SetError(Me.gbxDetalle, "Hay al menos una cantidad con valor CERO en detalle de cotización.")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#End Region

#End Region

#Region "Eventos formulario"

#Region "Pantalla"

    Private Sub frmSivEntradaBodegaEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Try
            Me.MaxItemDetalle = ClsCatalogos.GetValorParametro("MaxItemsDetalleFactura")
        Catch ex As Exception
            Me.MaxItemDetalle = 10
        End Try
        Me.lblCantidadMaxItems.Text = Me.lblCantidadMaxItems.Text + " " + Me.MaxItemDetalle.ToString
        Select Case Me.TypeGui
            Case 0
                CargarDetalleCotizacionDE()
                Me.InicializarGui()
        End Select
    End Sub

    Private Sub frmSivEntradaBodegaEditar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.boolModificado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

#End Region

#Region "Combo Box"

    Private Sub cmbCliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedValueChanged
        If Me.cmbCliente.SelectedIndex = -1 Then
            Exit Sub
        End If
        CargarDatosCliente(Me.cmbCliente.SelectedValue.ToString)
        CargarExpedienteCxCCliente(Me.cmbCliente.SelectedValue.ToString)
        Me.ErrorProvider.SetError(cmbCliente, "")
        'Me.boolModificado = True
    End Sub


    Private Sub cmbTiempoEntrega_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTiempoEntrega.SelectedValueChanged
        Me.ErrorProvider.SetError(Me.cmbTiempoEntrega, "")
        'Me.boolModificado = True
    End Sub

    Private Sub cmbTerminoPago_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTerminoPago.SelectedValueChanged
        Me.ErrorProvider.SetError(Me.cmbTerminoPago, "")
        'Me.boolModificado = True
    End Sub

#End Region

#Region "Numeric Edit"
    Private Sub NumValido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumValido.TextChanged
        Me.ErrorProvider.SetError(Me.NumValido, "")
        'Me.boolModificado = True
    End Sub
#End Region

#Region "TextBox"
    Private Sub txtNumCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumCliente.KeyPress
        If e.KeyChar = Chr(13) Then
            CargarDatosCliente(txtNumCliente.Text)
            CargarExpedienteCxCCliente(txtNumCliente.Text)
        End If
    End Sub

    Private Sub txtComentarios_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComentarios.TextChanged
        Me.boolModificado = True
    End Sub

    Private Sub txtAtencionA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAtencionA.TextChanged
        Me.ErrorProvider.SetError(Me.txtAtencionA, "")
        Me.boolModificado = True
    End Sub

#End Region

#Region "DatetimePicker"
    Private Sub dtpFechaEntrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ErrorProvider.SetError(dtpFechaCotizacion, "")
        Me.boolModificado = True
    End Sub

#End Region

#Region "Grid DevExpress"

#Region "Ventanas de consultas"
    'Procedimiento encargado de Mostrar las existencias del repuesto indicado en todas las bodegas
    Private Sub MostrarVentanaExistencias()
        Dim objfrmSfaCotizacionBodegaRepuestoConsultar As frmSfaCotizacionBodegaRepuestoConsultar
        Dim FilaActual As Integer
        FilaActual = Me.grdDetalleCotizacionDETabla.FocusedRowHandle
        Try
            Try
                If Me.dtDetalleCotizacionDE.Rows.Count <> 0 Then
                    If Not IsDBNull(Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("objRepuestoID")) Then
                        objfrmSfaCotizacionBodegaRepuestoConsultar = New frmSfaCotizacionBodegaRepuestoConsultar
                        objfrmSfaCotizacionBodegaRepuestoConsultar.IDProducto = Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("objRepuestoID")
                        objfrmSfaCotizacionBodegaRepuestoConsultar.ShowDialog(Me)
                    End If
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objfrmSfaCotizacionBodegaRepuestoConsultar = Nothing
        End Try
    End Sub

    'Procedimiento encargado de Mostrar si hay descuentos para el repuesto seleccionado
    Private Sub MostrarVentanaConsultaDescuentos()
        Dim objfrmSfaCotizacionDescuentoConsultar As frmSfaCotizacionDescuentoConsultar
        Dim strFechaFormateadaActual As String
        Dim FilaActual As Integer
        FilaActual = Me.grdDetalleCotizacionDETabla.FocusedRowHandle
        Try
            Try
                If Me.dtDetalleCotizacionDE.Rows.Count <> 0 Then
                    If Not IsDBNull(Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("objRepuestoID")) Then
                        strFechaFormateadaActual = Format(Convert.ToDateTime(Me.dtpFechaCotizacion.Value).Date, "yyyy-MM-dd")
                        objfrmSfaCotizacionDescuentoConsultar = New frmSfaCotizacionDescuentoConsultar
                        objfrmSfaCotizacionDescuentoConsultar.IDRepuesto = Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("objRepuestoID")
                        objfrmSfaCotizacionDescuentoConsultar.TipoRepuesto = Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("objTipoRepuesto")
                        objfrmSfaCotizacionDescuentoConsultar.Fecha = strFechaFormateadaActual
                        objfrmSfaCotizacionDescuentoConsultar.Tienda = Me.cmbSucursal.SelectedValue.ToString
                        objfrmSfaCotizacionDescuentoConsultar.ShowDialog(Me)

                        If objfrmSfaCotizacionDescuentoConsultar.DescuentoSeleccionado <> 0 Then
                            If Me.grdDetalleCotizacionDETabla.FocusedColumn.Equals(Me.colPorcentajeDescuento) Then
                                Me.grdDetalleCotizacionDETabla.EditingValue = objfrmSfaCotizacionDescuentoConsultar.DescuentoSeleccionado
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objfrmSfaCotizacionDescuentoConsultar = Nothing
        End Try
    End Sub
#End Region

#Region "Key_Down"
    Private Sub grdDetalleCotizacionDETabla_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleCotizacionDETabla.KeyDown
        '---- Delete
        If e.KeyCode = Keys.Delete Then
            Dim view As GridView = CType(sender, GridView)
            If view.RowCount <> 0 Then
                If Me.EsFilaVacia Then
                    Me.ElminarFilaSinPreguntar()
                Else
                    Me.EliminarFila()
                    Me.CalcularTotales()
                End If
            End If
        End If

        '---- Enter
        If e.KeyCode = Keys.Enter Then
            'Si no hay filas
            If Me.grdDetalleCotizacionDETabla.RowCount = 0 Then
                Me.InsertarNuevaFilaGrid()
                Exit Sub
            End If

            'Cantidad
            If Me.grdDetalleCotizacionDETabla.FocusedColumn.Equals(Me.colCantidad) OrElse Me.grdDetalleCotizacionDETabla.FocusedColumn.Equals(Me.colPorcentajeDescuento) Then '3=Servicio de instalación
                If IdRepuestoSeleccionado() = "3" Then
                    Me.HabilitarPrecioDescuento(True)
                    Me.grdDetalleCotizacionDETabla.FocusedColumn = Me.colPrecioUnitario
                Else
                    Me.HabilitarPrecioDescuento(False)
                    If Me.TieneValor(Me.grdDetalleCotizacionDETabla.FocusedColumn.View.FocusedValue) Then
                        If Me.NumeroValido(Me.grdDetalleCotizacionDETabla.FocusedColumn.View.FocusedValue) Then
                            Me.grdDetalleCotizacionDETabla.FocusedColumn = Me.colBarCode
                            SendKeys.Send("{down}")
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If

        '---- Direccional hacia abajo
        If (e.KeyCode = Keys.Down) And (boolExisteErroresGrid = False) Then
            If Me.grdDetalleCotizacionDETabla.RowCount <> 0 Then
                Dim valor As Object = Me.grdDetalleCotizacionDETabla.Columns("Cantidad").View.GetRowCellValue(Me.grdDetalleCotizacionDETabla.FocusedRowHandle, "Cantidad")
                If Me.EstaEnUltimaFila And Me.NumeroValido(valor) And (Not Me.EsFilaVacia) Then
                    Me.InsertarNuevaFilaGrid()
                End If
            Else
                Me.InsertarNuevaFilaGrid()
            End If
        End If

        '----- Direccional hacia arriba
        If e.KeyCode = Keys.Up Then
            If Me.EsFilaVacia And Me.grdDetalleCotizacionDETabla.RowCount <> 1 Then
                e.SuppressKeyPress = True
                Me.ElminarFilaSinPreguntar()
            End If
        End If

        '--- Direccional hacia derecha
        Try
            If e.KeyCode = Keys.Right AndAlso Me.grdDetalleCotizacionDETabla.FocusedColumn.Equals(Me.colCantidad) And (boolExisteErroresGrid = False) Then
                Dim Cantidad As Object = Me.grdDetalleCotizacionDETabla.Columns("Cantidad").View.GetRowCellValue(Me.grdDetalleCotizacionDETabla.FocusedRowHandle, "Cantidad")
                If Cantidad <> Nothing Then
                    If Me.EstaEnUltimaFila AndAlso Me.NumeroValido(Cantidad) AndAlso (Not Me.EsFilaVacia) AndAlso (IdRepuestoSeleccionado() <> 3) Then
                        e.SuppressKeyPress = True
                        Me.InsertarNuevaFilaGrid()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

        'Si presiona control + B abre buscar repuesto.
        If e.KeyCode = Keys.B And e.Modifiers = Keys.Control Then
            Me.BusquedaRepuestos()
        End If

        'Si se preciona TAB estando en la última Celda editable
        If e.KeyCode = Keys.Tab AndAlso Me.grdDetalleCotizacionDETabla.FocusedColumn.Equals(Me.colPorcentajeDescuento) Then
            Me.txtComentarios.Focus()
        End If
    End Sub

#End Region

#Region "EditorKeyDown"
    Private Sub grdDetalleCotizacionDE_EditorKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleCotizacionDE.EditorKeyDown
        'Borra en modo de edición del grid, para ello se debe presionar la tecla control + delete
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            Me.EliminarFila()
        End If

        If (e.KeyCode = Keys.Enter And e.Modifiers = Keys.Control) Then
            If Me.grdDetalleCotizacionDETabla.FocusedColumn.Equals(Me.colCodigoRepuesto) Then
                Me.MostrarVentanaExistencias()
            End If
            If Me.grdDetalleCotizacionDETabla.FocusedColumn.Equals(Me.colPorcentajeDescuento) Then
                Me.MostrarVentanaConsultaDescuentos()
            End If
        End If
    End Sub
#End Region

#Region "ValidateRow"
    Private Sub grdDetalleCotizacionDETabla_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdDetalleCotizacionDETabla.ValidateRow
        Dim viewCodigoRepuesto As ColumnView = CType(sender, ColumnView)
        Dim viewDescripcion As ColumnView = CType(sender, ColumnView)
        Dim viewCantidad As ColumnView = CType(sender, ColumnView)

        Dim columnCodigoRepuesto As GridColumn = viewCodigoRepuesto.Columns("CodigoRepuesto")
        Dim columnDescripcion As GridColumn = viewDescripcion.Columns("objRepuestoID")
        Dim columnCantidad As GridColumn = viewCantidad.Columns("Cantidad")

        If IsDBNull(viewCodigoRepuesto.GetRowCellValue(e.RowHandle, columnCodigoRepuesto)) Then
            e.Valid = False
            viewCodigoRepuesto.SetColumnError(columnCodigoRepuesto, "El Código no puede ser nulo.")
            boolExisteErroresGrid = True
        Else
            'If viewCodigoRepuesto.GetRowCellValue(e.RowHandle, columnCodigoRepuesto) >= Int32.MaxValue Then
            '    e.Valid = False
            '    viewCodigoRepuesto.SetColumnError(columnCodigoRepuesto, "El Código ingresado no es soportado.")
            '    boolExisteErroresGrid = True
            'Else
            '    boolExisteErroresGrid = False
            'End If
        End If

        If IsDBNull(viewDescripcion.GetRowCellValue(e.RowHandle, columnDescripcion)) Then
            e.Valid = False
            viewDescripcion.SetColumnError(columnDescripcion, "La descripcion no puede ser nula.")
            boolExisteErroresGrid = True
        Else
            boolExisteErroresGrid = False
        End If

        If IsDBNull(viewCantidad.GetRowCellValue(e.RowHandle, columnCantidad)) OrElse viewCantidad.GetRowCellValue(e.RowHandle, columnCantidad) <= 0 Then
            e.Valid = False
            viewCantidad.SetColumnError(columnCantidad, "La Cantidad no puede contener un valor NULO, CERO o NEGATIVO.")
            boolExisteErroresGrid = True
        Else
            boolExisteErroresGrid = False
        End If
    End Sub
#End Region

#Region "ValidatingEditor, InvalidRowException"
    Private Sub grdDetalleCotizacionDETabla_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdDetalleCotizacionDETabla.ValidatingEditor
        Dim View As GridView = sender
        Dim Valor As Double
        Dim codigo As String
        Dim bValidarEntero As Boolean = False

        '[CodigoRepuesto]
        If View.FocusedColumn.FieldName = "CodigoRepuesto" Then
            'Obtener el valor actualmente editado
            codigo = Convert.ToString(e.Value)
            bValidarEntero = True
        End If
        '[Cantidad]
        If View.FocusedColumn.FieldName = "Cantidad" Then
            'Obtener el valor actualmente editado
            Valor = Convert.ToDouble(e.Value)
            bValidarEntero = True
        End If

        If bValidarEntero Then
            'Si es negativo, asignar cero
            If Valor < 0 Then
                e.Valid = True
                e.Value = 0
                'e.ErrorText = "Debe ingresar un valor positivo"
            End If
            'Si es mayor que un entero, asignar cero.
            If Valor >= Integer.MaxValue Then
                e.Value = 0
                e.Valid = True
            End If
        End If
    End Sub

    Private Sub grdDetalleCotizacionDETabla_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grdDetalleCotizacionDETabla.InvalidRowException
        'Evitar el popup de error de la celda
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub


#End Region

#Region "CellValueChanging, CellValueChanged"

    Private Sub grdDetalleCotizacionDETabla_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetalleCotizacionDETabla.CellValueChanging
        'Limpiar los íconos de error en el momento de modificar las celdas
        Dim view As ColumnView = sender

        Select Case e.Column.Name
            Case Me.colCodigoRepuesto.Name, Me.colDescripcion.Name, Me.colCantidad.Name
                view.ClearColumnErrors()
        End Select
    End Sub

    Private Sub grdDetalleCotizacionDETabla_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetalleCotizacionDETabla.CellValueChanged
        Dim FilaActual As Integer
        Dim strIndiceCombo As String
        Dim blnVerificaRepuestoAct, blnVerificaCodRepuesto As Boolean
        Dim objRepuestos As SivRepuestos
        Dim CodigoRepuesto As String

        FilaActual = Me.grdDetalleCotizacionDETabla.FocusedRowHandle
        objRepuestos = New SivRepuestos

        'Codigo de Barras
        If e.Column.Equals(Me.colBarCode) Then
            'Verificando si el código de barras existe
            If Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("CodigoBarras").ToString.Trim.Length > 0 Then
                CodigoRepuesto = ClsCatalogos.GetCodigoRepuestoByCodigoBarras(Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("CodigoBarras").ToString.Trim)
                If CodigoRepuesto = "0" Then
                    MsgBox("El código de barras no existe", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                objRepuestos.Retrieve(CodigoRepuesto)
                'Verificar si el repuesto está activo
                If Not objRepuestos.Activo Then
                    If (blnVerificaRepuestoAct = True) Then
                        MsgBox("El repuesto está inactivo", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                        Me.ElminarFilaSinPreguntar()
                        Me.InsertarNuevaFilaGrid()
                        Me.grdDetalleCotizacionDETabla.FocusedColumn = Me.colCodigoRepuesto
                        Exit Sub
                    End If
                End If

                'Si todo está bien se rellenan los datos
                If (CodigoRepuesto <> "0") Then
                    RellenarDatosGrid(objRepuestos.SivRepuestoID.ToString, FilaActual)
                End If
            End If
        End If

        'CodigoRepuesto
        If e.Column.Equals(Me.colCodigoRepuesto) Then
            If Me.dtDetalleCotizacionDE.DefaultView.Count <> 0 Then
                'Verifica si el código del repuesto existe
                blnVerificaCodRepuesto = objRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("CodigoRepuesto")) & "' AND SivRepuestoID NOT IN ('1','2')")
                If (blnVerificaCodRepuesto = False) Then
                    MsgBox("El código de repuesto no existe", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
                blnVerificaRepuestoAct = objRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & objRepuestos.SivRepuestoID & "'" & " AND Activo=0")
                If (blnVerificaRepuestoAct = True) Then
                    MsgBox("El repuesto está inactivo", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Si todo está bien se rellenan los datos
                RellenarDatosGrid(Me.grdDetalleCotizacionDETabla.EditingValue, FilaActual)
            End If
        End If

        'Descripción
        If e.Column.Equals(Me.colDescripcion) Then
            strIndiceCombo = grdDetalleCotizacionDETabla.ActiveEditor.EditValue.ToString
            RellenarDatosGrid(strIndiceCombo, FilaActual)
        End If

        'Validacion del repetido
        If e.Column.Equals(Me.colBarCode) Or e.Column.Equals(Me.colCodigoRepuesto) Or e.Column.Equals(Me.colDescripcion) Then
            If Me.BuscarDuplicados(Me.grdDetalleCotizacionDETabla.EditingValue, Me.colCodigoRepuesto.FieldName) Or Me.BuscarDuplicados(Me.grdDetalleCotizacionDETabla.EditingValue, Me.colBarCode.FieldName) Then
                MsgBox("Este valor ya se encuentra en la lista", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
            End If
        End If

        'Cantidad
        If e.Column.Equals(Me.colCantidad) Or e.Column.Equals(Me.colPorcentajeDescuento) Then

            'Valida si primero se digitó la cantidad
            If (IsDBNull(dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("CodigoRepuesto"))) Then
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
                Exit Sub
            End If

            'Realizar cálculos en grid
            If Me.dtDetalleCotizacionDE.Rows.Count <> 0 Then
                If IsDBNull(Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Precio")) Then
                    Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Precio") = 0
                End If

                Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Subtotal") = (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Cantidad")) * (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Precio"))
                If IsDBNull(Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("PorcentajeDescuento")) Then
                    Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("PorcentajeDescuento") = 0
                End If

                Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Descuento") = (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Subtotal")) * (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("PorcentajeDescuento") / 100)

                If Me.chkExonerado.Checked = True Then
                    Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Impuesto") = 0
                Else
                    Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Impuesto") = ((Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Subtotal")) - (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Descuento"))) * (PorcentajeImpuesto / 100)
                End If
                Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Total") = (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Subtotal")) - (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Descuento")) + (Me.dtDetalleCotizacionDE.DefaultView.Item(FilaActual)("Impuesto"))
            End If

            'Calcular los totales
            CalcularTotales()
        End If

        Me.boolModificado = True
    End Sub
#End Region

#Region "RellenarDatosGrid"
    Private Sub RellenarDatosGrid(ByVal strFiltro As String, ByVal intFilaActual As Integer)
        Dim objSivRepuestos As SivRepuestos
        Dim objSivBodegaRepuestos As SivBodegaRepuestos
        Dim dtProductoDescuento As DataTable
        Dim sFechaFormateadaActual As String
        Dim strCampos, strFiltroFecha As String

        objSivRepuestos = New SivRepuestos
        objSivBodegaRepuestos = New SivBodegaRepuestos

        'Cargar los datos del Repuesto, Detalle Repuesto Proveedor y Bodega Repuestos
        objSivRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & strFiltro & "'" & " AND Activo=1") 'REVISAR ESTO POR REGLAS DE NEGOCIO
        objSivBodegaRepuestos.RetrieveByFilter("objRepuestoID=" & "'" & objSivRepuestos.SivRepuestoID & "' AND objTiendaID= " & Me.cmbSucursal.SelectedValue)
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("CodigoBarras") = objSivRepuestos.CodigoBarras
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("objRepuestoID") = objSivRepuestos.SivRepuestoID
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("CodigoRepuesto") = objSivRepuestos.SivRepuestoID
        If objSivRepuestos.SivRepuestoID = "3" Then ' Then 'Servicio de instalación" Then
            Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("Cantidad") = 1
        Else
            Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("Cantidad") = 0
        End If

        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("Precio") = objSivRepuestos.Precio
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("Subtotal") = 0
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("Descuento") = 0
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("objTipoRepuesto") = objSivRepuestos.objTipoRepuesto

        Try
            sFechaFormateadaActual = Format(clsProyecto.Conexion.FechaServidor, "yyyyMMdd")
            strCampos = "ISNULL(MAX(Descuento),0) AS MaximoDescuento"
            strFiltroFecha = "convert(fechainicio,112) <= '" & sFechaFormateadaActual & "' AND convert(fechafin,112)>= '" & sFechaFormateadaActual & _
                             "' AND objTiendaID= " & Me.cmbSucursal.SelectedValue & " AND objRepuestoID= '" & objSivRepuestos.SivRepuestoID & "' AND objTipoRepuesto= " & objSivRepuestos.objTipoRepuesto

            dtProductoDescuento = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(strCampos, "vwSfaDescuentoCotizacion", strFiltroFecha))
            If dtProductoDescuento.Rows.Count <> 0 Then
                Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("PorcentajeDescuento") = dtProductoDescuento.DefaultView.Item(0)("MaximoDescuento")
            End If
        Catch ex As Exception
            'Si hay error que no asigne descuento, dejando que el usuario lo seleccione
        End Try
        
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("Impuesto") = 0
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("Total") = 0
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("Existencia") = objSivBodegaRepuestos.Cantidad
        Me.dtDetalleCotizacionDE.DefaultView.Item(intFilaActual)("CostoProm") = objSivRepuestos.CostoProm
        Me.NumExistencia.Value = objSivBodegaRepuestos.Cantidad
        'Mover el foco a columna Cantidad
        Me.grdDetalleCotizacionDETabla.FocusedColumn = Me.colCantidad
    End Sub

#End Region

#Region "FocusedRowChanged"
    Private Sub grdDetalleCotizacionDETabla_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdDetalleCotizacionDETabla.FocusedRowChanged
        If Me.grdDetalleCotizacionDETabla.RowCount > 0 Then
            Me.NumExistencia.Value = Me.dtDetalleCotizacionDE.DefaultView.Item(Me.grdDetalleCotizacionDETabla.FocusedRowHandle)("Existencia")
        End If

        If (grdDetalleCotizacionDETabla.RowCount > 0) AndAlso (Not IsDBNull(Me.dtDetalleCotizacionDE.DefaultView.Item(Me.grdDetalleCotizacionDETabla.FocusedRowHandle)("CodigoRepuesto"))) Then
            If Me.dtDetalleCotizacionDE.DefaultView.Item(Me.grdDetalleCotizacionDETabla.FocusedRowHandle)("CodigoRepuesto") = "3" Then
                Me.HabilitarPrecioDescuento(True)
                'Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").OptionsColumn.AllowFocus = True
                'Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").AppearanceCell.BackColor = Color.White
                'Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").OptionsColumn.ReadOnly = False
                'Me.grdDetalleCotizacionDETabla.Columns("Precio").OptionsColumn.AllowFocus = True
                'Me.grdDetalleCotizacionDETabla.Columns("Precio").AppearanceCell.BackColor = Color.White
                'Me.grdDetalleCotizacionDETabla.Columns("Precio").OptionsColumn.ReadOnly = False
            Else
                Me.HabilitarPrecioDescuento(False)
                'Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").AppearanceCell.BackColor = Color.LemonChiffon
                'Me.grdDetalleCotizacionDETabla.Columns("PorcentajeDescuento").OptionsColumn.ReadOnly = True
                'Me.grdDetalleCotizacionDETabla.Columns("Precio").AppearanceCell.BackColor = Color.LemonChiffon
                'Me.grdDetalleCotizacionDETabla.Columns("Precio").OptionsColumn.ReadOnly = True
            End If
        End If
    End Sub
#End Region

#Region "ButtonClick"
    Private Sub grdspnCodigoRepuesto1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles grdspnCodigoRepuesto.ButtonClick
        ' If e.Button.Index = 1 Then
        Me.MostrarVentanaExistencias()
        '  End If
    End Sub
    
    Private Sub grdspnPorcentajeDescuento_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles grdspnPorcentajeDescuento.ButtonClick
        If e.Button.Index = 1 Then
            Me.MostrarVentanaConsultaDescuentos()
        End If
    End Sub

#End Region

#Region "Enter, Leave"
    Private Sub grdDetalleCotizacionDE_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleCotizacionDE.Enter
        Me.ErrorProvider.SetError(Me.gbxDetalle, "")
        If Me.grdDetalleCotizacionDETabla.RowCount = 0 Then
            Me.InsertarNuevaFilaGrid()
            Exit Sub
        End If
    End Sub

    Private Sub grdDetalleCotizacionDE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleCotizacionDE.Leave
        grdDetalleCotizacionDETabla.MoveFirst()
        For I As Integer = 0 To Me.grdDetalleCotizacionDETabla.RowCount - 1
            If Me.EsFilaVacia Then
                Me.ElminarFilaSinPreguntar()
            End If
            grdDetalleCotizacionDETabla.MoveNext()
        Next
        CalcularTotales()
    End Sub

#End Region

#End Region

#Region "Botones"
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.Validaciones Then
            If Me.AgregarCotizacion Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdConsultarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarCliente.Click
        If Me.cmbCliente.Text.Trim.Length > 0 Then
            Me.ConsultarDatosCliente()
        Else
            MsgBox("Seleccione un Cliente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If
    End Sub

    Private Sub cmdAgregarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarCliente.Click
        Me.AgregarCliente()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Me.BusquedaRepuestos()
    End Sub

    Private Sub frmSfaCotizacionEditar_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.cmbCliente.Focus()
    End Sub

    Private Sub cmbCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtAtencionA.Focus()
        End If
    End Sub
#End Region

#End Region

   
End Class