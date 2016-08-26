'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Milagros Ruiz Oporta
''-- Fecha de Elaboración    : 24 Junio 2010.
''-- Formulario de Agregación de Factura de Repuestos
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
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class FrmSfaOrdenCompraEdit

#Region "Atributos"
    Private dtDescripcionFactura, dtDescripcionMoto, dtMotivoAnular, dtDetalleFactura, dtDetalleFacturaMoto, dtExpediente, dtTienda, dtTipoPago, dtCliente, dtVendedor As DataTable
    Private boolModificado, boolRegistrada As Boolean
    Private m_TypeGui As Integer
    Private m_MontoTasaCambio As Integer
    Private m_SfaFacturaID, m_SivRepuestosID As Integer
    Private m_strmarca, m_strmodelo, m_strcolor, m_strchasis, m_strano As String
    Private m_strmotor, m_strcilindraje, m_strcilindros, m_strtipo As String
    Private m_strcombustible, m_strvelocidades, m_strpasajeros, m_strpoliza As String
    Private m_MaxItemsDetalle As Integer
    Private CantidadDigitosOrdenCompra As Integer
    Private m_SfaCotizacionID As Integer
    Private boolExisteErroresGrid As Boolean

#End Region

#Region "Propiedades"

    Property SivRepuestosID() As Integer
        Get
            Return m_SivRepuestosID
        End Get
        Set(ByVal value As Integer)
            m_SivRepuestosID = value
        End Set
    End Property

    Property TypeGUI() As Integer
        Get
            Return m_TypeGui
        End Get
        Set(ByVal value As Integer)
            m_TypeGui = value
        End Set
    End Property

    Property SfaFacturaID() As Integer
        Get
            Return m_SfaFacturaID
        End Get
        Set(ByVal value As Integer)
            m_SfaFacturaID = value
        End Set
    End Property

    Property MontoTasaCambio() As Double
        Get
            Return m_MontoTasaCambio
        End Get
        Set(ByVal value As Double)
            m_MontoTasaCambio = value
        End Set
    End Property

    Public Property SfaCotizacionID() As Integer
        Get
            SfaCotizacionID = Me.m_SfaCotizacionID
        End Get
        Set(ByVal value As Integer)
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

#Region "Inicializar GUI"

#Region "Cargar Combos"

#Region "Cargar Tiendas"

    Private Sub CargarTienda()
        dtTienda = StbTienda.RetrieveDT("Activo = 1 AND Codigo = 'C' ", "Nombre", "StbTiendaID, Codigo,Nombre")
        With Me.cmbBodega
            .DataSource = Me.dtTienda
            .ValueMember = "StbTiendaID"
            .DisplayMember = "Nombre"
            .Splits(0).DisplayColumns("StbTiendaID").Visible = False
            .Splits(0).DisplayColumns("Codigo").Visible = False
            .ExtendRightColumn = True
        End With
        Me.cmbBodega.SelectedValue = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
    End Sub
#End Region

#Region "Cargar Vendedores"
    Private Sub CargarVendedor()
        dtVendedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("NombreVendedor, SrhEmpleadoID ", "vwSfaVendedorFactura", "1=1 ORDER BY NombreVendedor"))
        With Me.cmbVendedor
            .DataSource = Me.dtVendedor
            .ValueMember = "SrhEmpleadoID"
            .DisplayMember = "NombreVendedor"
            .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
            .ExtendRightColumn = True
        End With
        Me.cmbVendedor.SelectedValue = SsgCuenta.RetrieveDT("Login = '" & clsProyecto.Conexion.Usuario & "'", "", "objEmpleadoID").DefaultView.Item(0)("objEmpleadoID")
    End Sub
#End Region

#Region "Cargar Clientes"
    Private Sub CargarClientes()
        dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto", "vwSfaClienteFactura", "Descripcion = 'Cliente'"))
        dtCliente.DefaultView.Sort = "NombreCompleto"
        With Me.cmbCliente
            .DataSource = dtCliente
            .ValueMember = "StbPersonaID"
            .DisplayMember = "NombreCompleto"
            .Splits(0).DisplayColumns("StbPersonaID").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub
#End Region

#Region "Cargar Tipo Pago"
    Private Sub CargarTipoPago()
        dtTipoPago = ClsCatalogos.GetValoresCatalogo("TERMINOPAGO", "StbValorCatalogoID,Descripcion", "Descripcion")
        dtTipoPago.DefaultView.Sort = "Descripcion"
        With Me.cmbTPago
            .DataSource = dtTipoPago
            .ValueMember = "StbValorCatalogoID"
            .DisplayMember = "Descripcion"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .ExtendRightColumn = True
        End With

        Me.cmbTPago.SelectedValue = ClsCatalogos.GetValorCatalogoID("TERMINOPAGO", "01")
    End Sub
#End Region

#Region "Cargar Motivo Anular"
    Private Sub CargarMotivoAnular()
        dtMotivoAnular = ClsCatalogos.GetValoresCatalogo("MOTIVOANULARFACT", "StbValorCatalogoID,Descripcion", "Descripcion")
        dtMotivoAnular.DefaultView.Sort = "Descripcion"
        With Me.cmbMotivoAnular
            .DataSource = dtMotivoAnular
            .ValueMember = "StbValorCatalogoID"
            .DisplayMember = "Descripcion"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub
#End Region

#End Region

#Region "Autorizacion Gerencia"
    Private Sub AutorizacionGenerencia()
        Dim objseg As New SsgSeguridad

        objseg.Usuario = clsProyecto.Conexion.Usuario
        objseg.ServicioUsuario = "frmPrincipal"
        If objseg.TienePermiso("AUTORIZACIONGERENTE") Then
            Me.chkAutorizar.Enabled = True
            Me.numDescuento.Enabled = True
        End If

    End Sub

    Private Function Autorizacion() As Boolean
        Dim objseg As New SsgSeguridad

        objseg.Usuario = clsProyecto.Conexion.Usuario
        objseg.ServicioUsuario = "frmPrincipal"

        If objseg.TienePermiso("AUTORIZACIONGERENTE") Then
            Me.chkAutorizar.Enabled = True
            Me.numDescuento.Enabled = True
            Return True
            Exit Function
        End If

        Return False
    End Function

    Private Sub AutorizarDescuento()
        Dim objSfaFactura As New SfaFacturas
        Dim objSfaFacturaDetalle As New SfaFacturasDetalle
        Dim objseg As New SsgSeguridad
        Dim dtDetalleFact As New DataTable
        Dim t As New TransactionManager
        Dim fila As DataRow
        Try
            Try
                t.BeginTran()
                objseg.Usuario = clsProyecto.Conexion.Usuario
                objseg.ServicioUsuario = "frmPrincipal"
                If objseg.TienePermiso("AUTORIZACIONGERENTE") Then
                    objSfaFactura.Retrieve(Me.SfaFacturaID)
                    objSfaFactura.AutorizaDescuento = Me.chkAutorizar.Checked
                    objSfaFactura.DescuentoAutorizado = Me.NumDescuento.Value
                    objSfaFactura.DescuentoAutorizado = Me.NumDescuento.Value
                    objSfaFactura.Descuento = Me.numTotalDescuento.Value
                    objSfaFactura.TotalCordobas = Me.numTotalC.Value
                    objSfaFactura.TotalDolares = Me.numTotalD.Value
                    objSfaFactura.Impuesto = Me.numIVA.Value
                    objSfaFactura.Subtotal = Me.numSubTotal.Value
                    objSfaFactura.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSfaFactura.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSfaFactura.Update()

                    '--Actualizar el detalle de la factura
                    SfaFacturaRepuestoDetalle.DeleteByFilter("objFacturaRepuestoID = " & Me.SfaFacturaID)

                    dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

                    'Isertar detalle de Factura              
                    For Each row As DataRow In Me.dtDetalleFactura.Rows
                        fila = dtDetalleFact.NewRow
                        fila("objFacturaRepuestoID") = Me.SfaFacturaID
                        fila("objRepuestoID") = row("Codigo")
                        fila("Cantidad") = row("Cantidad")
                        fila("Precio") = row("Precio")
                        fila("Subtotal") = row("Subtotal")
                        fila("Descuento") = row("Descuento")
                        fila("Impuesto") = row("Impuesto")
                        fila("Total") = row("Total")
                        fila("CostoDolares") = row("CostoProm")
                        fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        dtDetalleFact.Rows.Add(fila)
                    Next
                    dtDetalleFact.TableName = "SfaFacturaRepuestoDetalle"
                    SfaFacturaRepuestoDetalle.BatchUpdate(dtDetalleFact.DataSet, t)

                    t.CommitTran()
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Catch ex As Exception
                t.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objSfaFactura = Nothing
            objseg = Nothing
        End Try
    End Sub
#End Region

#Region "Configurar GUI"

    Private Sub FormatearGrids()
        'Me.grdDetalleFacturaViejo.MarqueeStyle = MarqueeEnum.FloatingEditor
        'Me.grdDetalleFacturaViejo.EmptyRows = False
        'Me.grdDetalleFacturaViejo.Splits(0).DisplayColumns(10).Visible = False
        'Me.grdDetalleFacturaViejo.FilterBar = False
        'Me.grdDetalleFacturaViejo.Refresh()

        Me.numDescuento.Enabled = False
        Me.chkAutorizar.Enabled = False
    End Sub

    Private Sub ConfigurarGUI()
        Dim puntoBoton As New Point

        puntoBoton.X = 662
        puntoBoton.Y = 614

        clsProyecto.CargarTemaDefinido(Me)

        Me.CantidadDigitosOrdenCompra = ClsCatalogos.GetValorParametro("CantidadCerosOrdenCompra")

        Me.CargarTienda()
        Me.CargarClientes()
        Me.CargarVendedor()
        Me.CargarTipoPago()
        Me.FormatearGrids()
        Me.AutorizacionGenerencia()
        Me.CargarDescripcion("1=1")

        Select Case Me.TypeGUI
            Case 1
                Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                Me.CargarDetalleFactura("1=0")
                Me.numTasa.Value = Me.MontoTasaCambio
                Me.Text = "Agregar Orden de Compra"
                Me.txtNumeroReciboCancelacion.Enabled = False
                Me.MaxItemDetalle = ClsCatalogos.GetValorParametro("MaxItemsDetalleFactura")

            Case 2
                Me.Text = "Procesar Orden de Compra"
                Me.txtNumero.Text = Me.GenerarNumeroOrden
                Me.CargarDatosConsulta()
                Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                Me.BloquearControles()

                If (Me.chkSolicitudDescuento.Checked) And (Me.chkAutorizar.Checked) Then
                    Me.cmdProcesar.Enabled = True
                    Me.cmdAceptar.Enabled = False
                End If
                If Not Me.chkSolicitudDescuento.Checked Then
                    Me.cmdProcesar.Enabled = True
                End If
                Me.txtNumeroReciboCancelacion.Enabled = True

            Case 3  'Para la Autorización de Gerencia
                Me.Text = "Procesar Orden de Facturación"
                'Me.txtNumero.Text = Me.GenerarNumeroOrden
                Me.CargarDatosConsulta()

                Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                Me.BloquearControles()
                Me.FormatearGridParaAutorizacionGerencia()
                Me.numDescuento.Enabled = True
                Me.chkAutorizar.Enabled = True
                Me.cmdAceptar.Enabled = True

            Case 4
                Me.Text = "Consultando Orden de Facturación"
                CargarDatosConsulta()
                Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                Me.BloquearControles()                

            Case 5
                Me.Text = "Anulando Orden de Facturación"
                CargarDatosConsulta()
                Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)

                Me.BloquearControles()
                Me.lblMotivo.Visible = True
                Me.cmbMotivoAnular.Visible = True
                Me.CargarMotivoAnular()
                Me.cmdProcesar.Visible = False
                Me.cmdAceptar.Location = puntoBoton
                Me.cmbMotivoAnular.Enabled = True
                Me.cmdAceptar.Enabled = True

            Case 6
                Me.Text = "Agregar Orden de Facturación"
                Try
                    Me.CargarDatosMaestroCotización()
                    'Me.CargarDescripcion("1=1")
                    Me.CargarDatosDetalleCotizaccion("objCotizacionID = " & Me.SfaCotizacionID)
                    Me.BloquearControles()
                    Me.cmdAceptar.Enabled = True

                Catch ex As Exception
                    clsError.CaptarError(ex)
                End Try
        End Select
    End Sub
#End Region

#Region "Cargar Datos Consulta"
    Private Sub CargarDatosConsulta()
        Dim objSfaFactura As New SfaFacturas
        Try
            Try
                objSfaFactura.Retrieve(Me.SfaFacturaID)
                Me.cmbCliente.SelectedValue = objSfaFactura.objSccClienteID

                If (IsDBNull(objSfaFactura.serie)) And (IsDBNull(objSfaFactura.Numero)) Then
                    Me.txtNumero.Text = objSfaFactura.serie.Trim + objSfaFactura.Numero.ToString.Trim
                Else
                    If objSfaFactura.OrdenCompra.HasValue Then
                        Me.txtNumero.Text = RellenarConCeros(objSfaFactura.OrdenCompra.ToString, Me.CantidadDigitosOrdenCompra)
                    End If
                End If

                If objSfaFactura.objTiendaID <> 0 Then
                    Me.cmbBodega.SelectedValue = objSfaFactura.objTiendaID
                End If

                If objSfaFactura.objClienteID.Trim.Length <> 0 Then
                    Me.txtCodigoCliente.Text = objSfaFactura.objClienteID
                End If

                If Not IsDBNull(objSfaFactura.AtencionA) Then
                    Me.txtAtencionA.Text = objSfaFactura.AtencionA
                End If

                Me.dtpFecha.Value = objSfaFactura.Fecha

                If objSfaFactura.objVendedorID.ToString.Trim.Length <> 0 Then
                    Me.cmbVendedor.SelectedValue = objSfaFactura.objVendedorID
                End If

                Me.cmbTPago.SelectedValue = objSfaFactura.objTerminoPagoID
                Me.numTasa.Value = objSfaFactura.TasaCambio
                Me.chkSolicitudDescuento.Checked = objSfaFactura.SolicAutorDescuento

                If Not String.IsNullOrEmpty(objSfaFactura.SolicitudDescuento) Then
                    Me.txtSolicitudDescuento.Text = objSfaFactura.SolicitudDescuento
                End If

                Me.numSubTotal.Value = objSfaFactura.Subtotal

                Me.chkAutorizar.Checked = objSfaFactura.AutorizaDescuento

                Select Case Me.TypeGUI
                    Case 2, 3
                        If objSfaFactura.DescuentoAutorizado.ToString.Trim.Length Then
                            Me.NumDescuento.Value = objSfaFactura.DescuentoAutorizado
                            Me.numTotalDescuento.Value = objSfaFactura.DescuentoAutorizado * Me.numTasa.Value
                            Me.numTotalC.Value = objSfaFactura.Subtotal - Me.numTotalDescuento.Value
                            Me.numTotalD.Value = Me.numTotalC.Value / Me.numTasa.Value
                        Else
                            Me.numTotalC.Value = objSfaFactura.TotalCordobas
                            Me.numTotalDescuento.Value = objSfaFactura.Descuento
                            Me.numTotalD.Value = objSfaFactura.TotalDolares
                        End If
                    Case 4
                        Me.numTotalC.Value = objSfaFactura.TotalCordobas
                        Me.numTotalDescuento.Value = objSfaFactura.Descuento
                        Me.numTotalD.Value = objSfaFactura.TotalDolares
                End Select

                If (objSfaFactura.SolicAutorDescuento) And (objSfaFactura.AutorizaDescuento) Then
                    Me.cmdProcesar.Enabled = True
                    Me.cmdAceptar.Enabled = False
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objSfaFactura = Nothing
        End Try
    End Sub

    Private Sub BloquearControles()
        Me.cmbCliente.Enabled = False
        Me.txtCodigoCliente.Enabled = False
        Me.txtAtencionA.Enabled = False
        Me.cmbTPago.Enabled = False
        Me.cmdBuscar.Enabled = False
        Me.FormatearGridParaConsulta()
        Me.chkSolicitudDescuento.Enabled = False
        Me.cmdAceptar.Enabled = False
        Me.cmdProcesar.Enabled = False
        Me.txtSolicitudDescuento.Enabled = False
        Me.numDescuento.Enabled = False
        Me.chkAutorizar.Enabled = False
        Me.txtNumeroReciboCancelacion.Enabled = False
        Me.cmdCliente.Enabled = False
    End Sub
#End Region

#Region "Datos desde la Cotización"
    Private Sub CargarDatosMaestroCotización()
        Dim objSfaCotizacion As New SfaCotizacion
        Try
            Try
                objSfaCotizacion.Retrieve(Me.SfaCotizacionID)
                If Not String.IsNullOrEmpty(objSfaCotizacion.objClienteID) Then
                    Me.cmbCliente.SelectedValue = objSfaCotizacion.objClienteID
                    If objSfaCotizacion.objClienteID.Trim.Length <> 0 Then
                        Me.txtCodigoCliente.Text = objSfaCotizacion.objClienteID
                    End If
                End If

                If Not String.IsNullOrEmpty(objSfaCotizacion.AtencionA) Then
                    Me.txtAtencionA.Text = objSfaCotizacion.AtencionA
                End If

                Me.dtpFecha.Value = objSfaCotizacion.Fecha

                If objSfaCotizacion.objVendedorID.HasValue AndAlso objSfaCotizacion.objVendedorID.ToString.Trim.Length <> 0 Then
                    Me.cmbVendedor.SelectedValue = objSfaCotizacion.objVendedorID
                Else
                    Me.cmbVendedor.SelectedValue = SsgCuenta.RetrieveDT("Login = '" & clsProyecto.Conexion.Usuario & "'", "", "objEmpleadoID").DefaultView.Item(0)("objEmpleadoID")
                End If

                Me.cmbTPago.SelectedValue = objSfaCotizacion.objTerminoPagoID
                Me.numTasa.Value = objSfaCotizacion.TasaCambio

                Me.numSubTotal.Value = objSfaCotizacion.Subtotal
                Me.numTotalC.Value = objSfaCotizacion.TotalCordobas
                Me.numTotalD.Value = objSfaCotizacion.TotalDolares
                Me.NumDescuento.Value = objSfaCotizacion.Descuento
                Me.numIVA.Value = objSfaCotizacion.Impuesto

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objSfaCotizacion = Nothing
        End Try
    End Sub

    Private Sub CargarDatosDetalleCotizaccion(ByVal strFiltro As String)
        dtDetalleFactura = New DataTable
        Try
            dtDetalleFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoBarras,objCotizacionID, Codigo, DescripcionCorta, Cantidad, CostoProm,Precio,Descuento, Subtotal, Impuesto, Total", "vwSfaDetalleRepuestosCotizacion", strFiltro))
            Me.grdDetalleFactura.DataSource = dtDetalleFactura
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Cargar Datos del Cliente"

    Private Sub CargarDatosCliente()
        Dim dtDatosCliente As New DataTable
        Try
            Try
                dtDatosCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID, NombreCompleto, Direccion, Email, TelefonoParticular,TelefonoTrabajo, Celular, Exonerado", "vwSfaClienteFactura", "StbPersonaID = '" & Me.cmbCliente.SelectedValue & "'"))
                If dtDatosCliente.Rows.Count > 0 Then
                    If IsDBNull(dtDatosCliente.DefaultView.Item(0)("TelefonoParticular")) Then
                        If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("TelefonoTrabajo")) Then
                            Me.txtTelefono.Text = "Trab: " & dtDatosCliente.DefaultView.Item(0)("TelefonoTrabajo")
                        Else
                            Me.txtTelefono.Text = ""
                        End If
                    ElseIf Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("TelefonoTrabajo")) Then
                        Me.txtTelefono.Text = "Part: " & dtDatosCliente.DefaultView.Item(0)("TelefonoParticular") & " Trab: " & dtDatosCliente.DefaultView.Item(0)("TelefonoTrabajo")
                    Else
                        Me.txtTelefono.Text = "Part: " & dtDatosCliente.DefaultView.Item(0)("TelefonoParticular")
                    End If

                    If IsDBNull(dtDatosCliente.DefaultView.Item(0)("Direccion")) Then
                        Me.txtDireccion.Text = ""
                    Else
                        Me.txtDireccion.Text = dtDatosCliente.DefaultView.Item(0)("Direccion")
                    End If

                    If IsDBNull(dtDatosCliente.DefaultView.Item(0)("Email")) Then
                        Me.txtEmail.Text = ""
                    Else
                        Me.txtEmail.Text = dtDatosCliente.DefaultView.Item(0)("Email")
                    End If
                    Me.chkExonerado.Checked = dtDatosCliente.DefaultView.Item(0)("Exonerado")

                    If Me.cmbCliente.Text.Trim.Length <> 0 Then
                        Me.txtCodigoCliente.Text = Me.cmbCliente.SelectedValue
                    End If
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatosCliente = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar Expedientes"

    Private Sub CargarExpedientes()
        dtExpediente = New DataTable
        Try
            Try
                dtExpediente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objClienteID, SccCuentaID, objProductoID, ModeloMarca, Saldo", "vwSfaExpedienteCliente", "objClienteID ='" & Me.cmbCliente.SelectedValue) & "'")
                Me.grdExpedienteCliente.SetDataBinding(Me.dtExpediente, "", True)
                Me.grdExpedienteCliente.MarqueeStyle = MarqueeEnum.FloatingEditor
                Me.grdExpedienteCliente.FilterBar = False
                Me.grdExpedienteCliente.EmptyRows = False
                Me.grdExpedienteCliente.Refresh()

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtExpediente = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar Formularios de Consultas"

    Private Sub CargarConsultaExistencia()
        Dim objConsulta As frmSfaExistencia
        Dim filaActual As Integer
        Try
            Try
                filaActual = Me.grdDetalleFacturaTabla.FocusedRowHandle
                If Not IsDBNull(Me.dtDetalleFactura.DefaultView.Item(filaActual)("Codigo")) Then
                    objConsulta = New frmSfaExistencia
                    objConsulta.strCodigo = Me.dtDetalleFactura.DefaultView.Item(filaActual)("Codigo")
                    objConsulta.ShowDialog(Me)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objConsulta = Nothing
        End Try
    End Sub

    Private Sub CargarDescuentos()
        Dim objDescuento As frmSfaDescuentos
        Dim FilaActual As Integer
        FilaActual = Me.grdDetalleFacturaTabla.FocusedRowHandle
        Try
            Try
                objDescuento = New frmSfaDescuentos
                If Not IsDBNull(Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Codigo")) Then
                    objDescuento.intCodigo = Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Codigo")
                    If objDescuento.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                        If objDescuento.Descuento <> 0 Then
                            If Me.grdDetalleFacturaTabla.FocusedColumn.Equals(Me.colPorcentajeDescuento) Then
                                Me.grdDetalleFacturaTabla.EditingValue = objDescuento.Descuento * 100
                            End If
                        End If
                        Me.CalcularTotales()
                    End If
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objDescuento = Nothing
        End Try
    End Sub

    Private Sub CargarBuscarRepuesto()
        Dim objBuscarRepuestos As frmBusquedaRepuestos
        Try
            Try
                objBuscarRepuestos = New frmBusquedaRepuestos
                objBuscarRepuestos.strFiltro = " SivRepuestoID NOT IN ('1','2')"

                If objBuscarRepuestos.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.SivRepuestosID = objBuscarRepuestos.objRepuestoIdSeleccionado

                    'Verificar si ya se encuentra el repuesto en Detalle
                    If ExisteEnDetalle(SivRepuestosID, "Codigo") Then
                        MsgBox("El repuesto seleccionado ya se encuentra en detalle de Factura.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                        Me.grdDetalleFactura.Focus()
                        Exit Sub
                    End If

                    'Cargar los datos del repuesto en el grid de detalle de Orden compra.
                    Me.grdDetalleFactura.Focus()
                    If Not Me.EsFilaVacia Then
                        Me.InsertarNuevaFilaGrid()
                    End If
                    Me.RellenarDatosGrid(SivRepuestosID, Me.grdDetalleFacturaTabla.FocusedRowHandle)
                    Me.boolModificado = True
                    Me.grdDetalleFacturaTabla.RefreshData()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objBuscarRepuestos = Nothing
        End Try
    End Sub

    Private Sub CargarConsultaCliente()
        Dim objPers As frmClientesEdit
        Try
            Try
                objPers = New frmClientesEdit
                If Me.cmbCliente.Text.Trim.Length <> 0 Then
                    objPers.TyGui = 3
                    objPers.idpersona = Me.cmbCliente.SelectedValue
                    objPers.ShowDialog(Me)
                Else
                    objPers.TyGui = 1
                    If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.CargarClientes()
                        Me.cmbCliente.SelectedValue = objPers.idpersona
                    End If
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objPers = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos para el Grid DevExpress"

#Region "Cargar Grid DevExpress"
    Private Sub CargarDetalleFactura(ByVal strFiltro As String)
        Me.dtDetalleFactura = New DataTable
        Try
            dtDetalleFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoBarras,objFacturaRepuestoID, Codigo, DescripcionCorta, Cantidad, CostoProm, Precio, cast(0 as decimal(11,2)) as DescuentoPor, Descuento, Subtotal, Impuesto, Total", "vwSfaDetalleRepuestos", strFiltro))
            Me.grdDetalleFactura.DataSource = dtDetalleFactura
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Rellenar Datos Grid DevExpress"
    Private Sub RellenarDatosGrid(ByVal strFiltro As String, ByVal intFilaActual As Integer)
        Dim objSivRepuestos As SivRepuestos
        Dim objSivBodegaRepuestos As SivBodegaRepuestos
        Dim dtProductoDescuento As DataTable
        Dim strCampos, strFiltroFecha As String

        objSivRepuestos = New SivRepuestos
        objSivBodegaRepuestos = New SivBodegaRepuestos

        'Cargar los datos del Repuesto, Detalle Repuesto Proveedor y Bodega Repuestos
        objSivRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & strFiltro & "'" & " AND Activo=1") 'REVISAR ESTO POR REGLAS DE NEGOCIO
        objSivBodegaRepuestos.RetrieveByFilter("objRepuestoID=" & "'" & objSivRepuestos.SivRepuestoID & "' AND objTiendaID= " & Me.cmbBodega.SelectedValue)
        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("CodigoBarras") = objSivRepuestos.CodigoBarras
        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Codigo") = objSivRepuestos.SivRepuestoID
        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Codigo") = objSivRepuestos.SivRepuestoID

        If objSivRepuestos.SivRepuestoID = "3" Then 'Servicio de instalación" Then
            Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Cantidad") = 1
        Else
            Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Cantidad") = 0
        End If

        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Precio") = objSivRepuestos.Precio
        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Subtotal") = 0
        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Descuento") = 0

        Try
            strCampos = "ISNULL(MAX(Descuento),0) AS MaximoDescuento"
            strFiltroFecha = " fechafin >= GETDATE() AND objRepuestoID= " & objSivRepuestos.SivRepuestoID

            dtProductoDescuento = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(strCampos, "vwSfaDescuentosFactura", strFiltroFecha))
            If dtProductoDescuento.Rows.Count <> 0 Then
                Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("DescuentoPor") = dtProductoDescuento.DefaultView.Item(0)("MaximoDescuento") * 100
            End If
        Catch ex As Exception
            'Si hay error que no asigne descuento, dejando que el usuario lo seleccione
        End Try

        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Impuesto") = 0
        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Total") = 0
        'Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Existencia") = objSivBodegaRepuestos.Cantidad
        Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("CostoProm") = objSivRepuestos.CostoProm
        Me.numExistencia.Value = objSivBodegaRepuestos.Cantidad
        'Mover el foco a columna Cantidad
        Me.grdDetalleFacturaTabla.FocusedColumn = Me.colCantidad
        Me.boolExisteErroresGrid = False
    End Sub

#End Region

#Region "Cargar combo para Descripcion Grid"

    Private Sub CargarDescripcion(ByVal strFiltro As String)
        Dim riLookComboDescripcion As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Try
            dtDescripcionFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivRepuestoID,DescripcionCorta", "vwSivRepuestos", strFiltro & " AND SivRepuestoID NOT IN('1','2') " & " ORDER BY DescripcionCorta"))
            riLookComboDescripcion = Me.grdDetalleFactura.RepositoryItems(1)
            riLookComboDescripcion.DataSource = dtDescripcionFactura
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDescripcionFactura = Nothing
        End Try
    End Sub

#End Region

#Region "Insertar una nueva fila en el grid"
    Private Sub InsertarNuevaFilaGrid()
        Try
            If Me.grdDetalleFacturaTabla.RowCount < Me.MaxItemDetalle Then
                Me.dtDetalleFactura.Rows.Add()
                Me.grdDetalleFacturaTabla.MoveLast()
                Me.grdDetalleFacturaTabla.FocusedColumn = Me.colBarCode
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
            Valor = Me.grdDetalleFacturaTabla.Columns("Codigo").View.GetRowCellValue(Me.grdDetalleFacturaTabla.FocusedRowHandle, "Codigo")
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
            If Me.dtDetalleFactura.Rows.Count <> 0 Then
                Me.dtDetalleFactura.Rows.RemoveAt(Me.grdDetalleFacturaTabla.FocusedRowHandle) 'Borra la fila del datatable directo
                Me.boolExisteErroresGrid = False
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Eliminar Fila"
    Private Sub EliminarFila()
        If MsgBox("¿Seguro que desea eliminar la fila seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes Then
            Try
                Me.dtDetalleFactura.Rows.RemoveAt(Me.grdDetalleFacturaTabla.FocusedRowHandle) 'Borra la fila del datatable directo
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
        For Each row As DataRow In Me.dtDetalleFactura.Rows
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
        Return Me.grdDetalleFacturaTabla.FocusedRowHandle = Me.grdDetalleFacturaTabla.RowCount - 1
    End Function
#End Region

#Region "Buscar Duplicados en Grid"
    Private Function BuscarDuplicados(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        Dim iContador As Integer = 0
        Dim strValorCampo As String
        If Me.dtDetalleFactura.Rows.Count > 1 Then
            For Each row As DataRow In Me.dtDetalleFactura.Rows
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
        Return Me.dtDetalleFactura.Select("Cantidad=0").Length > 0
    End Function
#End Region

#Region "Habilitar Precio y Descuento"
    Private Sub HabilitarPrecioDescuento(ByVal Habilitar As Boolean)
        If Habilitar Then
            Me.grdDetalleFacturaTabla.Columns("DescuentoPor").OptionsColumn.AllowFocus = True
            Me.grdDetalleFacturaTabla.Columns("DescuentoPor").AppearanceCell.BackColor = Color.White
            Me.grdDetalleFacturaTabla.Columns("DescuentoPor").OptionsColumn.ReadOnly = False

            Me.grdDetalleFacturaTabla.Columns("Precio").OptionsColumn.AllowFocus = True
            Me.grdDetalleFacturaTabla.Columns("Precio").AppearanceCell.BackColor = Color.White
            Me.grdDetalleFacturaTabla.Columns("Precio").OptionsColumn.ReadOnly = False
        Else
            Me.grdDetalleFacturaTabla.Columns("DescuentoPor").OptionsColumn.AllowFocus = True
            Me.grdDetalleFacturaTabla.Columns("DescuentoPor").AppearanceCell.BackColor = Color.LemonChiffon
            Me.grdDetalleFacturaTabla.Columns("DescuentoPor").OptionsColumn.ReadOnly = True

            Me.grdDetalleFacturaTabla.Columns("Precio").OptionsColumn.AllowFocus = False
            Me.grdDetalleFacturaTabla.Columns("Precio").AppearanceCell.BackColor = Color.LemonChiffon
            Me.grdDetalleFacturaTabla.Columns("Precio").OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "Id Respuesto Seleccionado"
    Private Function IdRepuestoSeleccionado() As Integer
        Dim CodigoRepuesto As Object = Me.grdDetalleFacturaTabla.Columns("Codigo").View.GetRowCellValue(Me.grdDetalleFacturaTabla.FocusedRowHandle, "Codigo")
        If Not Me.NumeroValido(CodigoRepuesto) Then
            CodigoRepuesto = 0
        End If
        Return CodigoRepuesto
    End Function
#End Region

#Region "Calculos Grid"
    Private Sub CalcularTotales()
        Dim DecSubTotal, DecDescuento, DecIVA, DecTotalCord As Decimal

        Try
            DecSubTotal = 0.0
            DecDescuento = 0.0
            DecIVA = 0.0
            DecTotalCord = 0.0

            If Not Me.dtDetalleFactura Is Nothing Then
                If Me.dtDetalleFactura.DefaultView.Count > 0 Then
                    DecSubTotal = Me.dtDetalleFactura.Compute("SUM(Subtotal)", "1=1")
                    DecDescuento = Me.dtDetalleFactura.Compute("SUM(Descuento)", "1=1")
                    DecIVA = Me.dtDetalleFactura.Compute("SUM(Impuesto)", "1=1")
                    DecTotalCord = Me.dtDetalleFactura.Compute("SUM(Total)", "1=1")
                End If
            End If

            Me.numSubTotal.Value = Decimal.Round(DecSubTotal, 2) * Decimal.Round(numTasa.Value, 2)
            Me.numTotalDescuento.Value = Decimal.Round(DecDescuento, 2) * Decimal.Round(numTasa.Value, 2)
            Me.numIVA.Value = Decimal.Round(DecIVA, 2) * Decimal.Round(numTasa.Value, 2)
            Me.numTotalC.Value = Decimal.Round(DecTotalCord, 2) * Decimal.Round(numTasa.Value, 2)
            Me.numTotalD.Value = Decimal.Round(DecTotalCord, 2)

            'If Me.Autorizacion Then
            '    Me.numDescuento.Value = Me.numTotalDescuento.Value / Me.numTasa.Value
            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub RecalcularDescuentoAutorizado()
        Dim descuentofilas, descuento, precio, subtotal As Decimal
        Dim cantidad, filas As Integer

        If Not Me.dtDetalleFactura Is Nothing Then
            For Each row As DataRow In Me.dtDetalleFactura.Rows
                If Me.NumDescuento.EditValue.ToString.Trim.Length = 0 Then
                    row("Descuento").Value = 0.0
                Else
                    precio = row("Precio")
                    subtotal = row("SubTotal")
                    cantidad = row("Cantidad")
                    filas = (Me.dtDetalleFactura.Rows.Count)
                    descuentofilas = Me.NumDescuento.EditValue
                    row("Descuento") = (Decimal.Round(precio, 2) - ((Decimal.Round(subtotal, 2) - (descuentofilas) / filas) / cantidad)) * cantidad
                    row("DescuentoPor") = ((Decimal.Round(row("Descuento"), 2)) * 100) / Decimal.Round(subtotal, 2)
                    descuento = row("Descuento")
                    row("Subtotal") = (row("Cantidad")) * (Decimal.Round(row("Precio"), 2))

                    If Me.chkExonerado.Checked = True Then
                        row("Impuesto") = 0
                    Else
                        row("Impuesto") = (Decimal.Round(row("Subtotal"), 2) - Decimal.Round(row("Descuento"), 2)) * (ClsCatalogos.GetValorParametro("PORCENTAJEIMPUESTO") / 100)
                    End If
                    row("Total") = (Decimal.Round(row("Subtotal"), 2)) - (Decimal.Round(row("Descuento"), 2)) + (row("Impuesto"))

                End If
            Next

            Me.CalcularTotales()
        End If
    End Sub
#End Region

#Region "Botones del Grid"
    Private Sub grdspnCodigoRepuesto_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If e.Button.Index = 1 Then
            Me.CargarConsultaExistencia()
        End If
    End Sub

    Private Sub grdspnCodigoRepuesto1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles grdspnCodigoRepuesto1.ButtonClick
        Me.CargarConsultaExistencia()
    End Sub

    Private Sub grdspnPorcentajeDescuento_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles grdspnPorcentajeDescuento.ButtonClick
        If e.Button.Index = 1 Then
            Me.CargarDescuentos()
        End If
    End Sub
#End Region

#Region "Formatear Grid para Consulta"
    Private Sub FormatearGridParaConsulta()
        'Colocar las columnas del grid de detalle de orden de compra en Solo lectura.
        Me.colBarCode.OptionsColumn.ReadOnly = True
        Me.colBarCode.OptionsColumn.AllowFocus = False

        Me.colCodigoRepuesto.OptionsColumn.ReadOnly = True
        Me.colCodigoRepuesto.OptionsColumn.AllowFocus = False

        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.OptionsColumn.AllowFocus = False

        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.OptionsColumn.AllowFocus = False

        Me.colDescuento.OptionsColumn.ReadOnly = True
        Me.colDescuento.OptionsColumn.AllowFocus = False

        Me.colPorcentajeDescuento.OptionsColumn.ReadOnly = True
        Me.colPorcentajeDescuento.OptionsColumn.AllowFocus = False
    End Sub

    Private Sub FormatearGridParaAutorizacionGerencia()
        'Colocar las columnas del grid de detalle de orden de compra en Sólo lectura.
        Me.colBarCode.OptionsColumn.ReadOnly = True
        Me.colBarCode.OptionsColumn.AllowFocus = False

        Me.colCodigoRepuesto.OptionsColumn.ReadOnly = True
        Me.colCodigoRepuesto.OptionsColumn.AllowFocus = False

        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.OptionsColumn.AllowFocus = False

        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.OptionsColumn.AllowFocus = False

        Me.colDescuento.OptionsColumn.ReadOnly = False
        Me.colDescuento.OptionsColumn.AllowFocus = False

        Me.colPorcentajeDescuento.OptionsColumn.ReadOnly = True
        Me.colPorcentajeDescuento.OptionsColumn.AllowFocus = False
    End Sub

#End Region

#End Region

#Region "Eventos del Grid de Repuestos DevExpress"

#Region "Enter, KeyDown, Leave, EditorKeyDown, InvalidRowException"

    Private Sub grdDetalleFactura_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleFactura.Enter
        Me.ErrorFactura.SetError(Me.grpDetalle, "")
        If Me.grdDetalleFacturaTabla.RowCount = 0 Then
            Me.InsertarNuevaFilaGrid()
            Exit Sub
        End If

    End Sub

    Private Sub grdDetalleFacturaTabla_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleFacturaTabla.KeyDown
        Dim blnEnfoque As Boolean

        If Me.TypeGUI = 1 Then
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
                If Me.grdDetalleFacturaTabla.RowCount = 0 Then
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Cantidad
                If Me.grdDetalleFacturaTabla.FocusedColumn.Equals(Me.colCantidad) OrElse Me.grdDetalleFacturaTabla.FocusedColumn.Equals(Me.colPorcentajeDescuento) Then '3=Servicio de instalación

                    blnEnfoque = Me.grdDetalleFacturaTabla.FocusedColumn.Equals(Me.colCantidad)
                    If blnEnfoque Then
                        If Me.grdDetalleFacturaTabla.FocusedColumn.View.FocusedValue = 0 Then
                            Exit Sub
                        End If
                    End If

                    If IdRepuestoSeleccionado() = 3 Then
                        Me.HabilitarPrecioDescuento(True)
                        Me.grdDetalleFacturaTabla.FocusedColumn = Me.colPrecioUnitario
                    Else
                        Me.HabilitarPrecioDescuento(False)
                        If Me.TieneValor(Me.grdDetalleFacturaTabla.FocusedColumn.View.FocusedValue) Then
                            If Me.NumeroValido(Me.grdDetalleFacturaTabla.FocusedColumn.View.FocusedValue) Then
                                Me.grdDetalleFacturaTabla.FocusedColumn = Me.colBarCode
                                SendKeys.Send("{down}")
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If

            '---- Direccional hacia abajo
            If (e.KeyCode = Keys.Down) And (boolExisteErroresGrid = False) Then
                If Me.grdDetalleFacturaTabla.RowCount <> 0 Then
                    Dim valor As Object = Me.grdDetalleFacturaTabla.Columns("Cantidad").View.GetRowCellValue(Me.grdDetalleFacturaTabla.FocusedRowHandle, "Cantidad")
                    If Me.EstaEnUltimaFila And Me.NumeroValido(valor) And (Not Me.EsFilaVacia) Then
                        Me.InsertarNuevaFilaGrid()
                    End If
                Else
                    Me.InsertarNuevaFilaGrid()
                End If
            End If

            '----- Direccional hacia arriba
            If e.KeyCode = Keys.Up Then
                If Me.EsFilaVacia And Me.grdDetalleFacturaTabla.RowCount <> 1 Then
                    e.SuppressKeyPress = True
                    Me.ElminarFilaSinPreguntar()
                End If
            End If

            '--- Direccional hacia derecha
            Try
                If e.KeyCode = Keys.Right AndAlso Me.grdDetalleFacturaTabla.FocusedColumn.Equals(Me.colCantidad) And (boolExisteErroresGrid = False) Then
                    Dim Cantidad As Object = Me.grdDetalleFacturaTabla.Columns("Cantidad").View.GetRowCellValue(Me.grdDetalleFacturaTabla.FocusedRowHandle, "Cantidad")
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
                Me.CargarBuscarRepuesto()
            End If
        End If

    End Sub

    Private Sub grdDetalleFactura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleFactura.Leave
        grdDetalleFacturaTabla.MoveFirst()
        For I As Integer = 0 To Me.grdDetalleFacturaTabla.RowCount - 1
            If Me.EsFilaVacia Then
                Me.ElminarFilaSinPreguntar()
            End If
            grdDetalleFacturaTabla.MoveNext()
        Next
        Me.CalcularTotales()
    End Sub

    Private Sub grdDetalleFactura_EditorKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleFactura.EditorKeyDown
        'Borra en modo de edición del grid, para ello se debe presionar la tecla control + delete
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            If Me.TypeGUI = 1 Then 'Sólo si es al agregar una orden de compra
                Me.EliminarFila()
            End If
        End If

        If (e.KeyCode = Keys.Enter And e.Modifiers = Keys.Control) Then
            If Me.grdDetalleFacturaTabla.FocusedColumn.Equals(Me.colCodigoRepuesto) Then
                Me.CargarConsultaExistencia()
            End If
            If Me.grdDetalleFacturaTabla.FocusedColumn.Equals(Me.colPorcentajeDescuento) Then
                Me.CargarDescuentos()
            End If
        End If
    End Sub

    Private Sub grdDetalleFacturaTabla_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grdDetalleFacturaTabla.InvalidRowException
        'Evitar el popup de error de la celda
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "ValidateRow, ValidatingEditor"

    Private Sub grdDetalleFacturaTabla_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdDetalleFacturaTabla.ValidatingEditor
        Dim View As GridView = sender
        Dim Valor As Double
        Dim codigo As String
        Dim bValidarEntero As Boolean = False

        '[CodigoRepuesto]
        If View.FocusedColumn.FieldName = "Codigo" Then
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

        If View.FocusedColumn.FieldName = "Cantidad" Then
            Valor = Convert.ToDouble(e.Value)
            'Debe ser menor o igual a la cantidad existente
            If Not IsDBNull(Me.numExistencia.Value) Then
                If Valor > Me.numExistencia.Value Then
                    MsgBox("La cantidad debe ser menor a la existente.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    e.Value = 0
                    e.Valid = True
                End If
            End If
        End If
    End Sub

    Private Sub grdDetalleFacturaTabla_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdDetalleFacturaTabla.ValidateRow
        Dim viewCodigoRepuesto As ColumnView = CType(sender, ColumnView)
        Dim viewDescripcion As ColumnView = CType(sender, ColumnView)
        Dim viewCantidad As ColumnView = CType(sender, ColumnView)
        Dim columnCodigoRepuesto As GridColumn = viewCodigoRepuesto.Columns("Codigo")
        Dim columnDescripcion As GridColumn = viewDescripcion.Columns("Codigo")
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

#Region "CellValueChanging, CellValueChanged"

    Private Sub grdDetalleFacturaTabla_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetalleFacturaTabla.CellValueChanging
        'Limpiar los íconos de error en el momento de modificar las celdas
        Dim view As ColumnView = sender

        Select Case e.Column.Name
            Case Me.colCodigoRepuesto.Name, Me.colDescripcion.Name, Me.colCantidad.Name
                view.ClearColumnErrors()
        End Select
    End Sub

    Private Sub grdDetalleFacturaTabla_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetalleFacturaTabla.CellValueChanged
        Dim FilaActual As Integer
        Dim strIndiceCombo As String
        Dim blnVerificaRepuestoAct, blnVerificaCodRepuesto, blnVerificarExistencia As Boolean
        Dim objRepuestos As SivRepuestos
        Dim objBodegaRepuesto As SivBodegaRepuestos
        Dim CodigoRepuesto As String = "0"

        FilaActual = Me.grdDetalleFacturaTabla.FocusedRowHandle
        objRepuestos = New SivRepuestos
        objBodegaRepuesto = New SivBodegaRepuestos

        '============== Este código fué sustituido por error al colocar comillas sobre el código de barras. ==
        'Codigo de Barras
        'If e.Column.Equals(Me.colBarCode) Then
        '    'Verifica si el código de barras existe (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
        '    blnVerificaBarCode = objRepuestos.RetrieveByFilter("CodigoBarras=" & "'" & (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("CodigoBarras")) & "'")
        '    If (blnVerificaBarCode = False) AndAlso (Not IsDBNull(Me.dtDetalleFactura.DefaultView.Item(FilaActual)("CodigoBarras"))) Then
        '        MsgBox("El código de barras no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '        Me.ElminarFilaSinPreguntar()
        '        Me.InsertarNuevaFilaGrid()
        '        Exit Sub
        '    End If

        '    'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
        '    blnVerificaRepuestoAct = objRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & objRepuestos.SivRepuestoID & "'" & " AND Activo=0")
        '    If (blnVerificaRepuestoAct = True) Then
        '        MsgBox("El repuesto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '        Me.ElminarFilaSinPreguntar()
        '        Me.InsertarNuevaFilaGrid()
        '        Me.grdDetalleFacturaTabla.FocusedColumn = Me.colCodigoRepuesto
        '        Exit Sub
        '    End If

        '    'Verifica que el repuesto este en existencia
        '    blnVerificarExistencia = objBodegaRepuesto.RetrieveByFilter("objRepuestoID = " & "'" & objRepuestos.SivRepuestoID & "'" & " AND objTiendaID = " & Me.cmbBodega.SelectedValue & " AND Cantidad <> 0")
        '    If Not blnVerificarExistencia Then
        '        MsgBox("El repuesto no tiene existencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '        Me.ElminarFilaSinPreguntar()
        '        Me.InsertarNuevaFilaGrid()
        '        Me.grdDetalleFacturaTabla.FocusedColumn = Me.colCodigoRepuesto
        '        Exit Sub
        '    End If

        '    'Si todo está bien se rellenan los datos
        '    blnVerificaBarCode = objRepuestos.RetrieveByFilter("CodigoBarras=" & "'" & (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("CodigoBarras")) & "'")
        '    If (blnVerificaBarCode = True) Then
        '        RellenarDatosGrid(objRepuestos.SivRepuestoID.ToString, FilaActual)
        '    End If
        'End If
        '============================================================================

        'Codigo de Barras
        'If e.Column.Equals(Me.colBarCode) Then
        '    'Verificando si el código de barras existe
        '    If Me.dtDetalleFactura.DefaultView.Item(FilaActual)("CodigoBarras").ToString.Trim.Length > 0 Then
        '        CodigoRepuesto = ClsCatalogos.GetCodigoRepuestoByCodigoBarras(Me.dtDetalleFactura.DefaultView.Item(FilaActual)("CodigoBarras").ToString.Trim)
        '        If CodigoRepuesto = "0" Then
        '            MsgBox("El código de barras no existe", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
        '            Me.ElminarFilaSinPreguntar()
        '            Me.InsertarNuevaFilaGrid()
        '            Exit Sub
        '        End If

        '        objRepuestos.Retrieve(CodigoRepuesto)
        '        'Verificar si el repuesto está activo
        '        If Not objRepuestos.Activo Then
        '            If (blnVerificaRepuestoAct = True) Then
        '                MsgBox("El repuesto está inactivo", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
        '                Me.ElminarFilaSinPreguntar()
        '                Me.InsertarNuevaFilaGrid()
        '                Me.grdDetalleFacturaTabla.FocusedColumn = Me.colCodigoRepuesto
        '                Exit Sub
        '            End If
        '        End If

        '        'Si todo está bien se rellenan los datos
        '        If (CodigoRepuesto <> "0") Then
        '            RellenarDatosGrid(objRepuestos.SivRepuestoID.ToString, FilaActual)
        '        End If
        '    End If
        'End If

        'CodigoRepuesto
        If e.Column.Equals(Me.colCodigoRepuesto) Then
            If Me.dtDetalleFactura.DefaultView.Count <> 0 Then
                'Verifica si el código del repuesto existe
                blnVerificaCodRepuesto = objRepuestos.RetrieveByFilter("SivRepuestoID='" & (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Codigo")) & "' AND SivRepuestoID NOT IN ('1','2')")
                If (blnVerificaCodRepuesto = False) Then
                    MsgBox("El código de repuesto no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
                blnVerificaRepuestoAct = objRepuestos.RetrieveByFilter("SivRepuestoID='" & objRepuestos.SivRepuestoID & "' AND Activo=0")
                If (blnVerificaRepuestoAct = True) Then
                    MsgBox("El repuesto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Verifica que el repuesto este en existencia
                blnVerificarExistencia = objBodegaRepuesto.RetrieveByFilter("objRepuestoID = " & "'" & objRepuestos.SivRepuestoID & "'" & " AND objTiendaID = " & Me.cmbBodega.SelectedValue & " AND Cantidad <> 0")
                If Not blnVerificarExistencia Then
                    MsgBox("El repuesto no tiene existencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Me.grdDetalleFacturaTabla.FocusedColumn = Me.colCodigoRepuesto
                    Exit Sub
                End If

                'Si todo está bien se rellenan los datos
                RellenarDatosGrid(Me.grdDetalleFacturaTabla.EditingValue, FilaActual)
            End If
        End If

        'Descripción
        If e.Column.Equals(Me.colDescripcion) Then

            'Verifica que el repuesto este en existencia
            blnVerificarExistencia = objBodegaRepuesto.RetrieveByFilter("objRepuestoID = " & "'" & Me.grdDetalleFacturaTabla.EditingValue & "'" & " AND objTiendaID = " & Me.cmbBodega.SelectedValue & " AND Cantidad <> 0")
            If Not blnVerificarExistencia Then
                MsgBox("El repuesto no tiene existencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
                Me.grdDetalleFacturaTabla.FocusedColumn = Me.colCodigoRepuesto
                Exit Sub
            End If

            strIndiceCombo = grdDetalleFacturaTabla.ActiveEditor.EditValue.ToString
            RellenarDatosGrid(strIndiceCombo, FilaActual)
        End If

        'Validacion del repetido
        If e.Column.Equals(Me.colBarCode) Or e.Column.Equals(Me.colCodigoRepuesto) Or e.Column.Equals(Me.colDescripcion) Then
            If Me.BuscarDuplicados(Me.grdDetalleFacturaTabla.EditingValue, Me.colCodigoRepuesto.FieldName) Or Me.BuscarDuplicados(Me.grdDetalleFacturaTabla.EditingValue, Me.colBarCode.FieldName) Then
                MsgBox("Este valor ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Sistema")
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
            End If
        End If

        'Cantidad
        If e.Column.Equals(Me.colCantidad) Or e.Column.Equals(Me.colPorcentajeDescuento) Then

            'Valida si primero se digitó la cantidad
            If (IsDBNull(dtDetalleFactura.DefaultView.Item(FilaActual)("Codigo"))) Then
                Me.ElminarFilaSinPreguntar()
                Me.InsertarNuevaFilaGrid()
                Exit Sub
            End If

            'Realizar cálculos en grid
            If Me.dtDetalleFactura.Rows.Count <> 0 Then
                If IsDBNull(Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Precio")) Then
                    Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Precio") = 0
                End If

                Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Subtotal") = (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Cantidad")) * (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Precio"))

                If IsDBNull(Me.dtDetalleFactura.DefaultView.Item(FilaActual)("DescuentoPor")) Then
                    Me.dtDetalleFactura.DefaultView.Item(FilaActual)("DescuentoPor") = 0
                End If

                Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Descuento") = (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Subtotal")) * (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("DescuentoPor") / 100)

                If Me.chkExonerado.Checked = True Then
                    Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Impuesto") = 0
                Else
                    Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Impuesto") = ((Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Subtotal")) - (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Descuento"))) * (ClsCatalogos.GetValorParametro("PORCENTAJEIMPUESTO") / 100)
                End If
                Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Total") = (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Subtotal")) - (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Descuento")) + (Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Impuesto"))
            End If

            'Calcular los totales
            CalcularTotales()
        End If

        Me.boolModificado = True
    End Sub

#End Region

#End Region


#Region "Validaciones"
    Private Function VerificarCodigoExiste(ByVal intCodigo As Integer) As Boolean
        'Dim intContador As Integer = 0
        'For I As Integer = 0 To Me.grdDetalleFacturaViejo.RowCount - 1
        '    If Me.grdDetalleFacturaViejo.Item(I)("Codigo") = intCodigo Then
        '        intContador = intContador + 1
        '    End If
        'Next
        'If intContador > 1 Then
        '    Return False
        '    Exit Function
        'End If
        'Return True
    End Function

    Private Sub ValidarDespuesEditarGrid()
        'Dim dtDatosDetalleCodigo As New DataTable
        'Try
        '    If IsDBNull(Me.grdDetalleFacturaViejo.Columns("Cantidad").Value) Then
        '        Me.grdDetalleFacturaViejo.Columns("Cantidad").Value = 0
        '        ' Exit Sub
        '    Else
        '        If Me.grdDetalleFacturaViejo.Columns("Cantidad").Value < 0 Then
        '            Me.grdDetalleFacturaViejo.Columns("Cantidad").Value = 0
        '        End If
        '    End If

        '    If IsDBNull(Me.grdDetalleFacturaViejo.Columns("Descuento").Value) Then
        '        Me.grdDetalleFacturaViejo.Columns("Descuento").Value = 0
        '    Else
        '        If Me.grdDetalleFacturaViejo.Columns("Descuento").Value < 0 Then
        '            Me.grdDetalleFacturaViejo.Columns("Descuento").Value = 0
        '        End If
        '    End If

        '    If IsDBNull(Me.grdDetalleFacturaViejo.Columns("Codigo").Value) Then
        '        Me.grdDetalleFacturaViejo.Columns("Codigo").Value = 0
        '    ElseIf Me.grdDetalleFacturaViejo.Columns("Codigo").Value < 0 Then
        '        Me.grdDetalleFacturaViejo.Columns("Codigo").Value = 0
        '        Exit Sub
        '    ElseIf Not Me.VerificarCodigoExiste(grdDetalleFacturaViejo.Columns("Codigo").Value) Then
        '        MsgBox("El código ya existe.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '        Me.ReiniciarGrid()
        '    Else
        '        'If Me.cmbDescripcionFactura.Text.Trim.Length = 0 Then
        '        If Not Me.CargarDatosGridCodigo() Then
        '            MsgBox("El código ingresado no existe.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
        '            Exit Sub
        '        End If
        '        'End If
        '    End If

        '    If grdDetalleFacturaViejo.Columns("Codigo").Text.Trim.Length <> 0 Then
        '        dtDatosDetalleCodigo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Cantidad, objRepuestoID", "dbo.vwSivBodegaRepuesto", "StbTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = " & Me.grdDetalleFacturaViejo.Columns("Codigo").Text))

        '        If dtDatosDetalleCodigo.Rows.Count > 0 Then
        '            'If Me.grdDetalleFactura.Columns("Cantidad").Value = 0 Then
        '            '    MsgBox("Este respuesto no esta disponible", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
        '            '    Me.grdDetalleFactura.Delete(Me.grdDetalleFactura.Row)
        '            'Else
        '            If Me.grdDetalleFacturaViejo.Columns("Cantidad").Value > dtDatosDetalleCodigo.DefaultView.Item(0)("Cantidad") Then
        '                MsgBox("La cantidad debe ser mayor o igual a la existente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
        '                Me.ReiniciarGrid()
        '                ' Me.grdDetalleFactura.Columns("Cantidad").Value = 0
        '                Exit Sub
        '            End If
        '        End If
        '    End If
        '    Me.CalculosTotalesGrid()
        '    Me.CalcularTotales()

        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'Finally
        '    dtDatosDetalleCodigo = Nothing
        'End Try
    End Sub

    Private Sub ReiniciarGrid()

        'Me.grdDetalleFacturaViejo.Columns("CodigoBarras").Value = ""
        'Me.grdDetalleFacturaViejo.Columns("Codigo").Value = ""
        'Me.grdDetalleFacturaViejo.Columns("DescripcionCorta").Value = ""
        'Me.grdDetalleFacturaViejo.Columns("Cantidad").Value = 0
        'Me.grdDetalleFacturaViejo.Columns("Precio").Value = 0.0
        'Me.grdDetalleFacturaViejo.Columns("Subtotal").Value = 0.0
        'Me.grdDetalleFacturaViejo.Columns("DescuentoPor").Value = 0
        'Me.grdDetalleFacturaViejo.Columns("Descuento").Value = 0.0
        'Me.grdDetalleFacturaViejo.Columns("Impuesto").Value = 0.0
        'Me.grdDetalleFacturaViejo.Columns("Total").Value = 0.0

    End Sub

    Private Sub BuscarExistencia(ByVal intCodigo As Integer)
        Dim dtDetalleExistencia As New DataTable
        Try
            Try
                dtDetalleExistencia = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Cantidad, objRepuestoID", "dbo.vwSivBodegaRepuesto", "StbTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = " & intCodigo.ToString))
                If dtDetalleExistencia.Rows.Count > 0 Then
                    Me.numExistencia.Value = dtDetalleExistencia.DefaultView.Item(0)("Cantidad")
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Catch ex As Exception
            dtDetalleExistencia = Nothing
        End Try
    End Sub

    Private Function GenerarNumeroOrden() As String
        Dim strNumero As String = ""
        Dim dtMaximoNumero As New DataTable
        Dim strSQL As String
        Try
            Try
                strSQL = ObtenerConsultaGeneral("MAX(ISNULL(OrdenCompra,1)) as NumeroOrdenMax", "SfaFacturaRepuesto", "objTiendaID = " & Me.cmbBodega.SelectedValue.ToString)
                dtMaximoNumero = DAL.SqlHelper.ExecuteQueryDT(strSQL)
                If dtMaximoNumero.DefaultView.Item(0)("NumeroOrdenMax").ToString.Trim.Length <> 0 Then
                    strNumero = RellenarConCeros(dtMaximoNumero.DefaultView.Item(0)("NumeroOrdenMax") + 1, 4)
                Else
                    strNumero = 1
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtMaximoNumero = Nothing
        End Try

        Return strNumero.Trim
    End Function

    Private Function ValidarEntradaDatos() As Boolean
        If Me.cmbCliente.Text.Trim.Length = 0 And Me.txtAtencionA.Text.Trim.Length = 0 Then
            Me.ErrorFactura.SetError(Me.cmbCliente, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.cmbBodega.Text.Trim.Length = 0 Then
            Me.ErrorFactura.SetError(Me.cmbBodega, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.cmbTPago.Text.Trim.Length = 0 Then
            Me.ErrorFactura.SetError(Me.cmbTPago, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        'If Me.grdDetalleFacturaViejo.RowCount = 0 Then
        '    MsgBox("Debe especificar al menos un detalle en la factura.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '    Return False
        '    Exit Function
        'End If

        If Me.ExistenCantidadesEnCero Then
            Me.ErrorFactura.SetError(Me.grpDetalle, "Hay al menos un valor de cantidad en CERO.")
            Exit Function
        End If

        Return True
    End Function

    'Private Function ExistenCantidadesEnCero() As Boolean
    '    Try
    '        Return Me.dtDetalleFactura.Select("Cantidad = 0").Length <> 0
    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    End Try
    'End Function

    'Private Function UltimaFilaGridRepuesto() As Boolean
    '    Return Me.grdDetalleFacturaViejo.Row = Me.grdDetalleFacturaViejo.Splits(0).Rows.Count - 1
    'End Function

    'Private Function DescuentoValido() As Boolean
    '    Dim blnValido As Boolean = True
    '    If Not UltimaFilaGridRepuesto() Then
    '        If (IsDBNull(Me.grdDetalleFacturaViejo.Columns("Cantidad").Value)) And Me.grdDetalleFacturaViejo.Columns("Cantidad").Value.ToString.Trim.Length = 0 Then
    '            blnValido = False
    '            Exit Function
    '        End If
    '        If (Me.grdDetalleFacturaViejo.Columns("Cantidad").Value <= 0) Then
    '            Me.ErrorFactura.SetError(Me.grpDetalle, "Debe escribir un valor de la cantidad mayor que cero.")
    '            blnValido = False
    '            Exit Function
    '        End If
    '    End If
    '    Return blnValido
    'End Function

    'Private Function EstaEnColumnaEditable() As Boolean
    '    Return (Me.grdDetalleFacturaViejo.Col = 0 Or Me.grdDetalleFacturaViejo.Col = 1 Or Me.grdDetalleFacturaViejo.Col = 2 Or Me.grdDetalleFacturaViejo.Col = 3)
    'End Function

    'Private Sub grdDetalleFactura_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleFacturaViejo.KeyDown
    '    ''============ Al moverse con teclas direccionales ============================================================
    '    'Si presiona direccional hacia abajo o hacia arriba y no se ha escrito la cantidad solicitada o está es cero entonces bloquear

    '    If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And Me.grdDetalleFacturaViejo.Columns("Codigo").Value.ToString.Trim.Length <> 0 Then
    '        If Not Me.DescuentoValido Then
    '            e.SuppressKeyPress = True
    '        End If
    '    ElseIf (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And EstaEnColumnaEditable() Then
    '        If Me.grdDetalleFacturaViejo.Columns("Codigo").Value.ToString.Trim.Length = 0 And Not UltimaFilaGridRepuesto() Then
    '            Try
    '                If Me.grdDetalleFacturaViejo.Splits(0).Rows.Count > 2 Then 'Si tiene más de dos filas
    '                    Me.grdDetalleFacturaViejo.Delete(Me.grdDetalleFacturaViejo.Row)
    '                End If
    '            Catch 'si ocurre error al eliminar que no haga nada.
    '            End Try
    '        End If
    '    End If
    'End Sub

    'Private Sub grdDetalleFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleFacturaViejo.Click
    '    If Me.grdDetalleFacturaViejo.Columns("Codigo").Value.ToString.Trim.Length = 0 And Not UltimaFilaGridRepuesto() Then
    '        Try
    '            If Me.grdDetalleFacturaViejo.Splits(0).Rows.Count > 2 Then 'Si tiene más de dos filas
    '                Me.grdDetalleFacturaViejo.Delete(Me.grdDetalleFacturaViejo.Row)
    '            End If
    '        Catch 'si ocurre error al eliminar que no haga nada.
    '        End Try
    '    End If
    'End Sub
#End Region

#Region "Eventos del Formulario"

#Region "Formulario"
    Private Sub FrmOrdenCompraEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ConfigurarGUI()
    End Sub
#End Region

#Region "Controles"

    Private Sub cmbMotivoAnular_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMotivoAnular.TextChanged
        Me.ErrorFactura.SetError(Me.cmbMotivoAnular, "")
    End Sub

    Private Sub cmbCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.TextChanged
        CargarDatosCliente()
        CargarExpedientes()
        Me.ErrorFactura.SetError(Me.cmbCliente, "")
    End Sub

    Private Sub grdDetalleFactura_AfterColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs)
        Me.ValidarDespuesEditarGrid()
    End Sub

    Private Sub chkSolicitudDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSolicitudDescuento.CheckedChanged
        If Me.chkSolicitudDescuento.Checked Then
            Me.txtSolicitudDescuento.Enabled = True
        Else
            Me.txtSolicitudDescuento.Enabled = False
        End If
    End Sub

    Private Sub cmbCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbCliente.Text.Trim.Length <> 0 Then
                Me.txtAtencionA.Focus()
            End If
        End If
    End Sub

    Private Sub txtAtencionA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAtencionA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmbTPago.Focus()
        End If
    End Sub

    Private Sub cmbTPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTPago.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbTPago.Text.Trim.Length <> 0 Then
                Me.grdDetalleFactura.Focus()
            End If
        End If
    End Sub

    Private Sub txtObervaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.chkSolicitudDescuento.Focus()
        End If
    End Sub

    Private Sub chkSolicitudDescuento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkSolicitudDescuento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.chkSolicitudDescuento.Checked Then
                Me.txtSolicitudDescuento.Focus()
            Else
                Me.cmdAceptar.Focus()
            End If
        End If
    End Sub

    Private Sub cmbTPago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTPago.TextChanged
        Me.ErrorFactura.SetError(Me.cmbTPago, "")
    End Sub

    Private Sub txtAtencionA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAtencionA.TextChanged
        Me.ErrorFactura.SetError(Me.cmbCliente, "")
    End Sub

    Private Sub cmbBodega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBodega.TextChanged
        Me.ErrorFactura.SetError(Me.cmbBodega, "")
    End Sub

    Private Sub txtCodigoCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                Me.cmbCliente.SelectedValue = Me.txtCodigoCliente.Text
            Catch ex As Exception
                MsgBox("Cliente no encontrado.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            End Try
        End If
    End Sub

    Private Sub grdDetalleFactura_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorFactura.Clear()
    End Sub
#End Region

#Region "Botones"
    Private Sub cmdCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCliente.Click
        Dim objBusquedaCliente As New frmSfaBusquedaCliente
        Dim objPersonaID As String
        Try
            Try
                objBusquedaCliente.Filtro = "Descripcion = 'Cliente'"    '"Descripcion = 'Cliente' AND StbPersonaID NOT IN (SELECT objFiadorID FROM vwSccCuentaFiador WHERE Estado = 'VIGENTE') "
                If objBusquedaCliente.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarClientes()
                    objPersonaID = objBusquedaCliente.Seleccion
                    Me.cmbCliente.SelectedValue = objPersonaID
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objBusquedaCliente = Nothing
        End Try
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Me.CargarBuscarRepuesto()
    End Sub

    Private Sub cmdAgregarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarCliente.Click
        Me.CargarConsultaCliente()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If Me.boolRegistrada Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        Dim t As New TransactionManager
        Me.ProcesarOrdenCompra(t)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.ValidarEntradaDatos Then
            Select Case Me.TypeGUI
                Case 1, 6
                    Me.AgregarOrdenCompra()
                Case 3
                    Me.AutorizarDescuento()
                Case 5
                    Select Case MsgBox("¿Seguro que desea anular la Orden de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            Me.AnularOrdenCompra()
                    End Select
            End Select
        End If
    End Sub

#End Region

#End Region

#Region "Operaciones en ORDEN de COMPRA"

#Region "Guardar Orden Compra"
    Private Sub AgregarOrdenCompra()
        Dim t As New TransactionManager
        Try
            t.BeginTran()
            Me.GuardarFactura(t)
            Me.GuardarDetallefactura(t)
            t.CommitTran()
            boolRegistrada = True
            Me.boolModificado = False
            frmSfaOrdenesCompra.Imprimir_Ticket(Me.SfaFacturaID)
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            If Not Me.chkSolicitudDescuento.Checked Then
                Me.cmdProcesar.Enabled = True
                Me.txtNumeroReciboCancelacion.Enabled = True
                Me.cmdAceptar.Enabled = False
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    'Guarda el encabezado de la factura de Orden de compra
    Private Sub GuardarFactura(ByVal t As TransactionManager)
        Dim objSfaFactura As SfaFacturas
        Try
            objSfaFactura = New SfaFacturas

            objSfaFactura.Fecha = Me.dtpFecha.Value
            objSfaFactura.objStbBodegaID = Me.cmbBodega.SelectedValue

            If Me.cmbCliente.Text.Trim.Length <> 0 Then
                objSfaFactura.objSccClienteID = Me.cmbCliente.SelectedValue
            End If

            If Me.cmbVendedor.Text.Trim.Length <> 0 Then
                objSfaFactura.objVendedorID = Me.cmbVendedor.SelectedValue
            End If

            objSfaFactura.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "REGISTRADA")
            objSfaFactura.objTerminoPagoID = Me.cmbTPago.SelectedValue

            If Me.txtAtencionA.Text.Trim.Length <> 0 Then
                objSfaFactura.AtencionA = Me.txtAtencionA.Text
            End If

            objSfaFactura.Subtotal = Me.numSubTotal.Value
            objSfaFactura.Descuento = Me.numTotalDescuento.Value
            objSfaFactura.Impuesto = Me.numIVA.Value
            objSfaFactura.TotalCordobas = Me.numTotalC.Value
            objSfaFactura.TotalDolares = Me.numTotalD.Value
            objSfaFactura.TasaCambio = Me.numTasa.Value

            objSfaFactura.SolicAutorDescuento = Me.chkSolicitudDescuento.Checked

            If Me.txtSolicitudDescuento.Text.Trim.Length <> 0 Then
                objSfaFactura.SolicitudDescuento = Me.txtSolicitudDescuento.Text
            End If

            If Me.chkAutorizar.Checked Then
                objSfaFactura.DescuentoAutorizado = Me.NumDescuento.Value
            End If

            objSfaFactura.AutorizaDescuento = Me.chkAutorizar.Checked
            objSfaFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSfaFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSfaFactura.Insert(t)

            Me.SfaFacturaID = objSfaFactura.SfaFacturaRepuestoID

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    'Guarda el Detalle de la factura de orden de compra.
    Private Sub GuardarDetallefactura(ByVal T As TransactionManager)
        Dim objSfaFacturaDetalle As SfaFacturasDetalle
        Dim dtDetalleFact As New DataTable
        Dim fila As DataRow

        Try
            objSfaFacturaDetalle = New SfaFacturasDetalle
            dtDetalleFact = SfaFacturasDetalle.RetrieveDT("1=0")

            'Isertar detalle de Factura              
            Me.dtDetalleFactura.AcceptChanges()
            For Each row As DataRow In Me.dtDetalleFactura.Rows
                fila = dtDetalleFact.NewRow
                fila("objFacturaRepuestoID") = Me.SfaFacturaID
                fila("objRepuestoID") = row("Codigo")
                fila("Cantidad") = row("Cantidad")
                fila("Precio") = row("Precio")
                fila("Subtotal") = row("Subtotal")
                fila("Descuento") = row("Descuento")
                fila("Impuesto") = row("Impuesto")
                fila("Total") = row("Total")
                fila("CostoDolares") = row("CostoProm")
                fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                dtDetalleFact.Rows.Add(fila)
            Next

            dtDetalleFact.TableName = "SfaFacturaRepuestoDetalle"
            SfaFacturaRepuestoDetalle.BatchUpdate(dtDetalleFact.DataSet, T)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Procesar Orden Compra"
    Private Sub ProcesarOrdenCompra(ByVal T As TransactionManager)
        Dim objSfaFactura As New SfaFacturas
        Dim objSfaFacturaDetalle As New SfaFacturasDetalle
        Dim objSivBodegaRpuestos As New SivBodegaRepuestos
        Dim dtDetalleFact As New DataTable
        Dim fila As DataRow

        Try
            Try
                'Verificar recibo de cancelación
                If Me.txtNumeroReciboCancelacion.Text.Trim.Length = 0 Then
                    MsgBox("No ha ingresado el número de recibo de cancelación.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Me.txtNumeroReciboCancelacion.Focus()
                    Exit Sub
                End If

                T.BeginTran()
                objSfaFactura.Retrieve(Me.SfaFacturaID)
                objSfaFactura.NumeroReciboCancelacion = Me.txtNumeroReciboCancelacion.Text.Trim
                objSfaFactura.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "PROCESADA")
                objSfaFactura.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSfaFactura.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSfaFactura.Descuento = Me.numTotalDescuento.Value
                objSfaFactura.Subtotal = Me.numSubTotal.Value
                objSfaFactura.TotalCordobas = Me.numTotalC.Value
                objSfaFactura.TotalDolares = Me.numTotalD.Value
                objSfaFactura.Impuesto = Me.numIVA.Value
                objSfaFactura.Update()

                '---Actualizar el detalle de la factura
                SfaFacturaRepuestoDetalle.DeleteByFilter("objFacturaRepuestoID = " & Me.SfaFacturaID)
                dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

                'Isertar detalle de Factura              
                For Each row As DataRow In Me.dtDetalleFactura.Rows
                    fila = dtDetalleFact.NewRow
                    fila("objFacturaRepuestoID") = Me.SfaFacturaID
                    fila("objRepuestoID") = row("Codigo")
                    fila("Cantidad") = row("Cantidad")
                    fila("Precio") = row("Precio")
                    fila("Subtotal") = row("Subtotal")
                    fila("Descuento") = row("Descuento")
                    fila("Impuesto") = row("Impuesto")
                    fila("Total") = row("Total")
                    fila("CostoDolares") = row("CostoProm")
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleFact.Rows.Add(fila)
                Next
                dtDetalleFact.TableName = "SfaFacturaRepuestoDetalle"
                SfaFacturaRepuestoDetalle.BatchUpdate(dtDetalleFact.DataSet, T)

                '--Actualizar la cantidad en SivBodegaRepuestos
                For Each row As DataRow In Me.dtDetalleFactura.Rows
                    objSivBodegaRpuestos.RetrieveByFilter("objTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = '" & row("Codigo") & "'")
                    objSivBodegaRpuestos.Cantidad = objSivBodegaRpuestos.Cantidad - row("Cantidad")
                    objSivBodegaRpuestos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSivBodegaRpuestos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSivBodegaRpuestos.Update()
                Next

                T.CommitTran()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                clsError.CaptarError(ex)
                T.RollbackTran()
            End Try
        Finally
            objSfaFactura = Nothing
            objSfaFacturaDetalle = Nothing
            objSivBodegaRpuestos = Nothing
        End Try
    End Sub
#End Region

#Region "Imprimir Orden Compra"

    Private Sub Imprimir()
        Dim visor As New frmVisorRS
        Dim sFiltro, sCampos, sSQL As String
        Dim dtDatos As DataTable
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim dblSubTotal, dblTotalDolares, dblTotalCordobas, dblTasa, dblImpuesto, dblDescuento As Double
        Dim strEslogan As String
        Dim strDireccionEmpresa, strTelefonoEmpresa As String

        strEslogan = ""
        sFiltro = "SfaFacturaRepuestoID = " & Me.SfaFacturaID
        sCampos = "Cliente, OrdenCompra, SfaFacturaRepuestoID, Fecha, Cantidad, Precio, DescuentoDetalle, objRepuestoID, Subtotal, Descripcion, SubTotalMaestro, DescuentoMaestro, ImpuestoMaestro, TotalDolares, TotalCordobas, TasaCambio, DGI, Eslogan, SubTotalVentas, objEstadoID"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptOrdenCompra", sFiltro)
        dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL)

        dblSubTotal = dtDatos.DefaultView.Item(0)("SubTotalMaestro")
        dblTotalDolares = dtDatos.DefaultView.Item(0)("TotalDolares")

        dblTotalCordobas = dtDatos.DefaultView.Item(0)("TotalCordobas")
        dblTasa = dtDatos.DefaultView.Item(0)("TasaCambio")
        dblImpuesto = dtDatos.DefaultView.Item(0)("ImpuestoMaestro")
        dblDescuento = dtDatos.DefaultView.Item(0)("DescuentoMaestro")

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Eslogan")) Then
            strEslogan = dtDatos.DefaultView.Item(0)("Eslogan")
        End If

        strDireccionEmpresa = ClsCatalogos.GetValorParametro("DireccionEmpresa")
        strTelefonoEmpresa = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDireccionEmpresa", strDireccionEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmTelefonoEmpresa", strTelefonoEmpresa, False))

        With visor.VisorReportes
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportEmbeddedResource = "SCCUM.rptOrdenCompra.rdlc"
            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtvwRptOrdenCompra_vwRptOrdenCompra", dtDatos))
            .LocalReport.SetParameters(parametros)
            .RefreshReport()
        End With
        visor.ShowDialog()
    End Sub

#End Region

#Region "Anular Orden Compra"
    Private Sub AnularOrdenCompra()
        Dim objSfaFactura As New SfaFacturas
        Dim objSfaFacturaDetalle As New SfaFacturasDetalle
        Dim objSivBodegaRpuestos As New SivBodegaRepuestos
        Dim dtDetalleFact As New DataTable
        Dim fila As DataRow
        Dim t As New TransactionManager
        Try
            Try
                If Me.cmbMotivoAnular.Text.Trim.Length <> 0 Then
                    t.BeginTran()

                    '---Actualizar el maestro de la factura
                    objSfaFactura.Retrieve(Me.SfaFacturaID)
                    objSfaFactura.objMotivoAnularID = Me.cmbMotivoAnular.SelectedValue
                    objSfaFactura.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "ANULADA")
                    objSfaFactura.TotalCordobas = 0.0
                    objSfaFactura.TotalDolares = 0.0
                    objSfaFactura.Subtotal = 0.0
                    objSfaFactura.Descuento = 0.0
                    objSfaFactura.Impuesto = 0.0
                    objSfaFactura.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSfaFactura.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSfaFactura.Update()

                    '--- Borrar el detalle de la factura (Orden Compra)
                    SfaFacturaRepuestoDetalle.DeleteByFilter("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    '---Actualizar el detalle de la factura
                    dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

                    'Isertar detalle de Factura (Orden Compra)          
                    For Each row As DataRow In Me.dtDetalleFactura.Rows
                        fila = dtDetalleFact.NewRow
                        fila("objFacturaRepuestoID") = Me.SfaFacturaID
                        fila("objRepuestoID") = row("Codigo")
                        fila("Cantidad") = 0
                        fila("Precio") = row("Precio")
                        fila("Subtotal") = 0.0
                        fila("Descuento") = 0.0
                        fila("Impuesto") = 0.0
                        fila("Total") = 0.0
                        fila("CostoDolares") = 0.0
                        fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        dtDetalleFact.Rows.Add(fila)
                    Next
                    dtDetalleFact.TableName = "SfaFacturaRepuestoDetalle"
                    SfaFacturaRepuestoDetalle.BatchUpdate(dtDetalleFact.DataSet, t)

                    '--Actualizar la cantidad en SivBodegaRepuestos
                    For Each row As DataRow In Me.dtDetalleFactura.Rows
                        objSivBodegaRpuestos.RetrieveByFilter("objTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = '" & row("Codigo") & "'")
                        objSivBodegaRpuestos.Cantidad = objSivBodegaRpuestos.Cantidad + row("Cantidad")
                        objSivBodegaRpuestos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objSivBodegaRpuestos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objSivBodegaRpuestos.Update()
                    Next
                    t.CommitTran()
                    MsgBox(" Factura Anulada satisfactoriamente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Me.ErrorFactura.SetError(Me.cmbMotivoAnular, My.Resources.MsgObligatorio)
                End If

            Catch ex As Exception
                t.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objSfaFactura = Nothing
            objSfaFacturaDetalle = Nothing
            objSivBodegaRpuestos = Nothing
        End Try
    End Sub
#End Region

#End Region

#Region "Eventos del Descuento Autorizado"
    Private Sub numDescuento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumDescuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.chkAutorizar.Checked Then
                Me.CargarDescuentoAutorizadoEnGrid()
            End If
        End If
    End Sub

    Private Sub numDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumDescuento.ValueChanged
        If Me.chkAutorizar.Checked Then
            Me.CargarDescuentoAutorizadoEnGrid()
        End If
    End Sub

    Private Sub CargarDescuentoAutorizadoEnGrid()
        Dim tasa As Decimal
        Dim SubTotalDolares As Decimal

        tasa = Me.numTasa.Value
        If tasa = 0 Then 'Para evitar la división por cero.
            tasa = 1
        End If
        SubTotalDolares = (Me.numSubTotal.Value / tasa)
        If Me.NumDescuento.EditValue > 0D Then
            If NumDescuento.EditValue < SubTotalDolares Then
                Me.RecalcularDescuentoAutorizado()
            Else
                Me.NumDescuento.EditValue = 0
                MsgBox("No es posible superar el SubTotal de la Orden de compra. [$" + SubTotalDolares.ToString + "]", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Exit Sub
            End If
        Else
            Me.RecalcularDescuentoAutorizado()
        End If
    End Sub

    Private Sub chkAutorizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutorizar.CheckedChanged
        If Not Me.chkAutorizar.Checked Then
            Me.NumDescuento.Value = 0
            Me.CargarDescuentoAutorizadoEnGrid()
        Else
            If Me.NumDescuento.EditValue > 0 Then
                Me.CargarDescuentoAutorizadoEnGrid()
            End If
        End If
    End Sub
#End Region


    
End Class