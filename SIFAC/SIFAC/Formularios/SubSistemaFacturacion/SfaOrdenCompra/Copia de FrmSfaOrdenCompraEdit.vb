'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Milagros Ruiz Oporta
''-- Fecha de Elaboración    : 24 Junio 2010.
''-- Formulario de Agregación de Factura de Repuestos
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SCCUM.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid

Public Class FrmSfaOrdenCompraEdit

#Region "Variables del formulario"
    Dim dtDescripcionFactura, dtDescripcionMoto, dtMotivoAnular, dtDetalleFactura, dtDetalleFacturaMoto, dtExpediente, dtTienda, dtTipoPago, dtCliente, dtVendedor As DataTable
    Dim boolModificado, boolRegistrada As Boolean
    Private m_TypeGui As Integer
    Private m_MontoTasaCambio As Integer
    Private m_SfaFacturaID, m_SivRepuestosID As Integer
    Dim m_strmarca, m_strmodelo, m_strcolor, m_strchasis, m_strano As String
    Dim m_strmotor, m_strcilindraje, m_strcilindros, m_strtipo As String
    Dim m_strcombustible, m_strvelocidades, m_strpasajeros, m_strpoliza As String

    Private CantidadDigitosOrdenCompra As Integer
    Private m_SfaCotizacionID As Integer

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

#Region "Cargar Descripcion Grid"

    Private Sub CargarDescripcion(ByVal strFiltro As String)
        Dim strSQL, strCampos As String
        Try
            strCampos = "SivRepuestoID,DescripcionCorta"
            strSQL = ObtenerConsultaGeneral("SivRepuestoID,DescripcionCorta", "vwSivRepuestos", strFiltro & " AND SivRepuestoID NOT IN(1,2) " & " ORDER BY DescripcionCorta")
            dtDescripcionFactura = DAL.SqlHelper.ExecuteQueryDT(strSQL)
            With Me.cmbDescripcionFactura
                .DataSource = dtDescripcionFactura
                .DisplayMember = "DescripcionCorta"
                .ValueMember = "SivRepuestoID"
                .Splits(0).DisplayColumns("SivRepuestoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDescripcionFactura = Nothing
        End Try
    End Sub

#End Region

#End Region

#Region "Cargar Grid"

    Private Sub CargarDetalleFactura(ByVal strFiltro As String)
        dtDetalleFactura = New DataTable
        Try
            dtDetalleFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoBarras,objFacturaRepuestoID, Codigo, DescripcionCorta, Cantidad, CostoProm,Precio,cast(0 as float) as DescuentoPor, Descuento, Subtotal, Impuesto, Total", "vwSfaDetalleRepuestos", strFiltro))
            Me.grdDetalleFactura.SetDataBinding(dtDetalleFactura, "", True)
            Me.grdDetalleFactura.Columns("DescripcionCorta").Editor = Me.cmbDescripcionFactura
            Me.grdDetalleFactura.Columns("Cantidad").Editor = Me.numCantidadDetalle

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

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
        Dim objSfaFactura As New SfaFacturaRepuesto
        Dim objSfaFacturaDetalle As New SfaFacturaRepuestoDetalle
        Dim objseg As New SsgSeguridad
        Try
            Try
                objseg.Usuario = clsProyecto.Conexion.Usuario
                objseg.ServicioUsuario = "frmPrincipal"
                If objseg.TienePermiso("AUTORIZACIONGERENTE") Then
                    objSfaFactura.Retrieve(Me.SfaFacturaID)
                    objSfaFactura.AutorizaDescuento = Me.chkAutorizar.Checked
                    objSfaFactura.DescuentoAutorizado = Me.numDescuento.Value
                    objSfaFactura.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSfaFactura.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSfaFactura.Update()

                    '--Actualizar el detalle de la factura
                    SfaFacturaRepuestoDetalle.DeleteByFilter("objFacturaRepuestoID = " & Me.SfaFacturaID)

                    For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
                        objSfaFacturaDetalle.objFacturaRepuestoID = Me.SfaFacturaID
                        objSfaFacturaDetalle.objRepuestoID = Me.grdDetalleFactura.Item(I)("Codigo")
                        objSfaFacturaDetalle.Precio = Me.grdDetalleFactura.Item(I)("Precio")
                        objSfaFacturaDetalle.Cantidad = Me.grdDetalleFactura.Item(I)("Cantidad")
                        objSfaFacturaDetalle.Subtotal = Me.grdDetalleFactura.Item(I)("SubTotal")
                        objSfaFacturaDetalle.Descuento = Me.grdDetalleFactura.Item(I)("Descuento")
                        objSfaFacturaDetalle.Impuesto = Me.grdDetalleFactura.Item(I)("Impuesto")
                        objSfaFacturaDetalle.Total = Me.grdDetalleFactura.Item(I)("Total")
                        objSfaFacturaDetalle.CostoDolares = Me.grdDetalleFactura.Item(I)("CostoProm")
                        objSfaFacturaDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objSfaFacturaDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objSfaFacturaDetalle.Insert()
                    Next
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Catch ex As Exception
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
        Me.grdDetalleFactura.MarqueeStyle = MarqueeEnum.FloatingEditor
        Me.grdDetalleFactura.EmptyRows = False
        Me.grdDetalleFactura.Splits(0).DisplayColumns(10).Visible = False
        Me.grdDetalleFactura.FilterBar = False
        Me.grdDetalleFactura.Refresh()

        Me.numDescuento.Enabled = False
        Me.chkAutorizar.Enabled = False
    End Sub

    Private Sub ConfigurarGUI()
        Dim puntoBoton As New Point

        puntoBoton.X = 658
        puntoBoton.Y = 626

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
                Me.Text = "Procesar Orden de compra"
                Me.txtNumero.Text = Me.GenerarNumeroOrden
                CargarDatosConsulta()

                Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                Me.BloquearControles()
                Me.numDescuento.Enabled = True
                Me.chkAutorizar.Enabled = True
                Me.cmdAceptar.Enabled = True

            Case 4
                Me.Text = "Consultando Factura"
                CargarDatosConsulta()
                Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                Me.BloquearControles()

            Case 5
                Me.Text = "Anulando Factura"
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
                Me.Text = "Agregar Cotización"
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
        Dim objSfaFactura As New SfaFacturaRepuesto
        Try
            Try
                objSfaFactura.Retrieve(Me.SfaFacturaID)
                Me.cmbCliente.SelectedValue = objSfaFactura.objClienteID

                If (IsDBNull(objSfaFactura.serie)) And (IsDBNull(objSfaFactura.Numero)) Then
                    Me.txtNumero.Text = objSfaFactura.serie.Trim + objSfaFactura.Numero.ToString.Trim
                Else
                    If objSfaFactura.OrdenCompra.HasValue Then
                        RellenarConCeros(objSfaFactura.OrdenCompra.ToString, Me.CantidadDigitosOrdenCompra)
                    End If
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
                                Me.numDescuento.Value = objSfaFactura.DescuentoAutorizado
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
        Me.grdDetalleFactura.Enabled = False
        Me.chkSolicitudDescuento.Enabled = False
        Me.cmdAceptar.Enabled = False
        Me.cmdProcesar.Enabled = False
        Me.txtSolicitudDescuento.Enabled = False
        Me.numDescuento.Enabled = False
        Me.chkAutorizar.Enabled = False
        Me.txtNumeroReciboCancelacion.Enabled = False
    End Sub
#End Region

#Region "Datos desde la Cotización"
    Private Sub CargarDatosMaestroCotización()
        Dim objSfaCotizacion As New SfaCotizacion
        Try
            Try
                objSfaCotizacion.Retrieve(Me.SfaCotizacionID)
                Me.cmbCliente.SelectedValue = objSfaCotizacion.objClienteID

                If objSfaCotizacion.objClienteID.Trim.Length <> 0 Then
                    Me.txtCodigoCliente.Text = objSfaCotizacion.objClienteID
                End If

                If Not IsDBNull(objSfaCotizacion.AtencionA) Then
                    Me.txtAtencionA.Text = objSfaCotizacion.AtencionA
                End If

                Me.dtpFecha.Value = objSfaCotizacion.Fecha

                If objSfaCotizacion.objVendedorID.ToString.Trim.Length <> 0 Then
                    Me.cmbVendedor.SelectedValue = objSfaCotizacion.objVendedorID
                Else
                    Me.cmbVendedor.SelectedValue = SsgCuenta.RetrieveDT("Login = '" & clsProyecto.Conexion.Usuario & "'", "", "objEmpleadoID").DefaultView.Item(0)("objEmpleadoID")
                End If

                Me.cmbTPago.SelectedValue = objSfaCotizacion.objTerminoPagoID
                Me.numTasa.Value = objSfaCotizacion.TasaCambio

                Me.numSubTotal.Value = objSfaCotizacion.Subtotal
                Me.numTotalC.Value = objSfaCotizacion.TotalCordobas
                Me.numTotalD.Value = objSfaCotizacion.TotalDolares
                Me.numDescuento.Value = objSfaCotizacion.Descuento
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
            Me.grdDetalleFactura.SetDataBinding(dtDetalleFactura, "", True)
            Me.grdDetalleFactura.Columns("DescripcionCorta").Editor = Me.cmbDescripcionFactura
            Me.grdDetalleFactura.Columns("Cantidad").Editor = Me.numCantidadDetalle

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
        Try
            Try
                objConsulta = New frmSfaExistencia
                objConsulta.strCodigo = Me.grdDetalleFactura.Columns("Codigo").Value
                objConsulta.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objConsulta = Nothing
        End Try
    End Sub

    Private Sub CargarDescuentos()
        Dim objDescuento As frmSfaDescuentos
        Try
            Try
                objDescuento = New frmSfaDescuentos
                objDescuento.intCodigo = Me.grdDetalleFactura.Columns("Codigo").Value
                If objDescuento.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.grdDetalleFactura.Columns("DescuentoPor").Value = objDescuento.Descuento
                    Me.grdDetalleFactura.Columns("Descuento").Value = objDescuento.Descuento * Me.grdDetalleFactura.Columns("SubTotal").Value
                    Me.grdDetalleFactura.Columns("Impuesto").Value = Me.grdDetalleFactura.Columns("SubTotal").Value * 0.15
                    Me.grdDetalleFactura.Columns("Total").Value = Me.grdDetalleFactura.Columns("SubTotal").Value - Me.grdDetalleFactura.Columns("Descuento").Value + Me.grdDetalleFactura.Columns("Impuesto").Value
                    Me.CalcularTotales()
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
                objBuscarRepuestos.strFiltro = " SivRepuestoID NOT IN (1,2)"

                If objBuscarRepuestos.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.SivRepuestosID = objBuscarRepuestos.objRepuestoIdSeleccionado
                    'Me.grdDetalleFacturaMoto.Columns("Codigo").Value = Me.SivRepuestosID
                    'Me.CargarDatosGridCodigoMoto()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objBuscarRepuestos = Nothing
        End Try
    End Sub

    Private Sub CargarConsultaCliente()
        Dim objPers As frmStbPersonasEditar
        Try
            Try
                objPers = New frmStbPersonasEditar
                If Me.cmbCliente.Text.Trim.Length <> 0 Then
                    objPers.TyGui = 3
                    objPers.frmLlamado = 4
                    objPers.idpersona = Me.cmbCliente.SelectedValue
                    objPers.ShowDialog(Me)
                Else
                    objPers.TyGui = 1
                    objPers.frmLlamado = 4
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

#Region "Calculos"
    Private Sub CalculosTotalesGrid()

        If Me.grdDetalleFactura.Columns("Cantidad").Text.Trim.Length <> 0 Then
            If Me.grdDetalleFactura.Columns("Precio").Text.Trim.Length <> 0 Then
                Me.grdDetalleFactura.Columns("SubTotal").Value = Me.grdDetalleFactura.Columns("Cantidad").Value * Me.grdDetalleFactura.Columns("Precio").Value

                If Not Me.Autorizacion Then
                    Me.grdDetalleFactura.Columns("Descuento").Value = Me.grdDetalleFactura.Columns("DescuentoPor").Value * Me.grdDetalleFactura.Columns("SubTotal").Value
                Else
                    If Me.grdDetalleFactura.Columns("SubTotal").Value.ToString.Trim.Length <> 0 AndAlso Me.grdDetalleFactura.Columns("SubTotal").Value <> 0 Then
                        Me.grdDetalleFactura.Columns("DescuentoPor").Value = Me.grdDetalleFactura.Columns("Descuento").Value / Me.grdDetalleFactura.Columns("SubTotal").Value
                    End If
                End If
                    Me.grdDetalleFactura.Columns("Impuesto").Value = Me.grdDetalleFactura.Columns("SubTotal").Value * (ClsCatalogos.GetValorParametro("PORCENTAJEIMPUESTO") / 100)
                    Me.grdDetalleFactura.Columns("Total").Value = Me.grdDetalleFactura.Columns("SubTotal").Value - Me.grdDetalleFactura.Columns("Descuento").Value + Me.grdDetalleFactura.Columns("Impuesto").Value
            End If
        End If
    End Sub

    Private Sub CalcularTotales()
        Dim DesSubTotal, DesIVA, DesTotal, DesDescuento As Double
        Try
            DesSubTotal = 0.0
            DesTotal = 0.0
            DesIVA = 0.0
            DesDescuento = 0.0

            If Me.grdDetalleFactura.RowCount > 0 Then
                For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
                    If Me.grdDetalleFactura.Item(I)("Total").ToString.Trim.Length <> 0 Then
                        DesTotal = DesTotal + Me.grdDetalleFactura.Item(I)("Total")
                    End If

                    If Me.grdDetalleFactura.Item(I)("Subtotal").ToString.Trim.Length <> 0 Then
                        DesSubTotal = DesSubTotal + Me.grdDetalleFactura.Item(I)("Subtotal")
                    End If

                    If Me.grdDetalleFactura.Item(I)("Descuento").ToString.Trim.Length <> 0 Then
                        DesDescuento = DesDescuento + Me.grdDetalleFactura.Item(I)("Descuento")
                    End If
                    If Me.grdDetalleFactura.Item(I)("Impuesto").ToString.Trim.Length <> 0 Then
                        DesIVA = DesIVA + Me.grdDetalleFactura.Item(I)("Impuesto")
                    End If
                Next
            End If

            Me.numTotalD.Value = DesTotal
            Me.numTotalC.Value = Me.numTotalD.Value * Me.numTasa.Value
            Me.numTotalDescuento.Value = DesDescuento * Me.numTasa.Value
            Me.numIVA.Value = DesIVA * Me.numTasa.Value
            Me.numSubTotal.Value = DesSubTotal * Me.numTasa.Value

            If Me.Autorizacion Then
                Me.numDescuento.Value = Me.numTotalDescuento.Value / Me.numTasa.Value
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub RecalcularDescuento()
        Dim descuentofilas, descuento, precio, subtotal As Double
        Dim cantidad, filas As Integer

        ' Me.grdDetalleFactura.MoveFirst()

        For Each row As DataRow In Me.dtDetalleFactura.Rows
            If Me.numDescuento.Text.Trim.Length = 0 Then
                row("Descuento").Value = 0.0
            Else
                precio = row("Precio")
                subtotal = row("SubTotal")
                cantidad = row("Cantidad")
                filas = (Me.dtDetalleFactura.Rows.Count)
                descuentofilas = Me.numDescuento.Value
                row("Descuento") = (precio - ((subtotal - (descuentofilas) / filas) / cantidad)) * cantidad
                row("DescuentoPor") = row("Descuento") / subtotal
                descuento = row("Descuento")
                Me.dtDetalleFactura.AcceptChanges()
            End If
        Next

        If Me.grdDetalleFactura.Columns("Cantidad").Text.Trim.Length <> 0 Then
            If Me.grdDetalleFactura.Columns("Precio").Text.Trim.Length <> 0 Then
                Me.grdDetalleFactura.Columns("SubTotal").Value = Me.grdDetalleFactura.Columns("Cantidad").Value * Me.grdDetalleFactura.Columns("Precio").Value
                Me.grdDetalleFactura.Columns("Impuesto").Value = Me.grdDetalleFactura.Columns("SubTotal").Value * (ClsCatalogos.GetValorParametro("PORCENTAJEIMPUESTO") / 100)
                Me.grdDetalleFactura.Columns("Total").Value = Me.grdDetalleFactura.Columns("SubTotal").Value - Me.grdDetalleFactura.Columns("Descuento").Value + Me.grdDetalleFactura.Columns("Impuesto").Value
            End If
        End If
        Me.CalcularTotales()
    End Sub

#End Region

#Region "Cargar Datos en el Grid"
    Private Function CargarDatosGridCodigo() As Boolean
        Dim dtDatosDetalle As New DataTable
        Dim dtDescuentoDetalle As New DataTable
        Dim blnCargado As Boolean = False

        If Me.grdDetalleFactura.Columns("Codigo").Text.Trim.Length <> 0 Then
            dtDatosDetalle = SivRepuestos.RetrieveDT("SivRepuestoID =" & Me.grdDetalleFactura.Columns("Codigo").Value.ToString + " AND SivRepuestoID NOT IN(1,2)", "", "SivRepuestoID, DescripcionCorta,CodigoBarras, Precio, CostoProm")
            If dtDatosDetalle.Rows.Count > 0 Then
                Me.grdDetalleFactura.Columns("CodigoBarras").Value = dtDatosDetalle.DefaultView.Item(0)("CodigoBarras")
                Me.grdDetalleFactura.Columns("Precio").Value = dtDatosDetalle.DefaultView.Item(0)("Precio")
                Me.grdDetalleFactura.Columns("CostoProm").Value = dtDatosDetalle.DefaultView.Item(0)("CostoProm")
                Me.cmbDescripcionFactura.SelectedValue = dtDatosDetalle.DefaultView.Item(0)("SivRepuestoID")
                Me.grdDetalleFactura.Columns("DescripcionCorta").Value = Me.cmbDescripcionFactura.SelectedText
                dtDescuentoDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID, fechainicio, fechafin, Descuento", "vwSfaDescuentosFactura", "objRepuestoID = " & Me.grdDetalleFactura.Columns("Codigo").Value & " AND Descuento = (select MAx(Descuento) from vwSfaDescuentosFactura where objRepuestoID = " & Me.grdDetalleFactura.Columns("Codigo").Value & " ) AND fechainicio <= GETDATE() AND fechafin >= GETDATE()"))
                If dtDescuentoDetalle.Rows.Count > 0 Then
                    Me.grdDetalleFactura.Columns("DescuentoPor").Value = dtDescuentoDetalle.DefaultView.Item(0)("Descuento")
                Else
                    Me.grdDetalleFactura.Columns("DescuentoPor").Value = 0.0
                End If
                blnCargado = True
            End If
        End If
        Return blnCargado
    End Function

    Private Sub CargarDatosGrid()
        Dim dtDatosDetalle As New DataTable
        Dim dtDescuentoDetalle As New DataTable
        Try
            If Me.cmbDescripcionFactura.Text.Length <> 0 Then
                If Not IsDBNull(Me.cmbDescripcionFactura.SelectedValue) AndAlso Me.cmbDescripcionFactura.SelectedValue.ToString.Trim.Length <> 0 Then
                    dtDatosDetalle = SivRepuestos.RetrieveDT("SivRepuestoID =" & Me.cmbDescripcionFactura.SelectedValue, "", "SivRepuestoID, DescripcionCorta,CodigoBarras, Precio, CostoProm")
                    If dtDatosDetalle.Rows.Count > 0 Then
                        Me.grdDetalleFactura.Columns("CodigoBarras").Value = dtDatosDetalle.DefaultView.Item(0)("CodigoBarras")
                        Me.grdDetalleFactura.Columns("Precio").Value = dtDatosDetalle.DefaultView.Item(0)("Precio")
                        Me.grdDetalleFactura.Columns("CostoProm").Value = dtDatosDetalle.DefaultView.Item(0)("CostoProm")
                        Me.grdDetalleFactura.Columns("Codigo").Value = dtDatosDetalle.DefaultView.Item(0)("SivRepuestoID")
                        dtDescuentoDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID, fechainicio, fechafin, Descuento", "vwSfaDescuentosFactura", "objRepuestoID = " & Me.cmbDescripcionFactura.SelectedValue & " AND Descuento = (select MAx(Descuento) from vwSfaDescuentosFactura where objRepuestoID = " & Me.cmbDescripcionFactura.SelectedValue & ") AND fechainicio <= GETDATE() AND fechafin >= GETDATE()"))
                        If dtDescuentoDetalle.Rows.Count > 0 Then
                            Me.grdDetalleFactura.Columns("DescuentoPor").Value = dtDescuentoDetalle.DefaultView.Item(0)("Descuento")
                        Else
                            Me.grdDetalleFactura.Columns("DescuentoPor").Value = 0.0
                        End If
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Validaciones"
    Private Function VerificarCodigoExiste(ByVal intCodigo As Integer) As Boolean
        Dim intContador As Integer = 0
        For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
            If Me.grdDetalleFactura.Item(I)("Codigo") = intCodigo Then
                intContador = intContador + 1
            End If
        Next
        If intContador > 1 Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub ValidarDespuesEditarGrid()
        Dim dtDatosDetalleCodigo As New DataTable
        Try
            If IsDBNull(Me.grdDetalleFactura.Columns("Cantidad").Value) Then
                Me.grdDetalleFactura.Columns("Cantidad").Value = 0
                ' Exit Sub
            Else
                If Me.grdDetalleFactura.Columns("Cantidad").Value < 0 Then
                    Me.grdDetalleFactura.Columns("Cantidad").Value = 0
                End If
            End If

            If IsDBNull(Me.grdDetalleFactura.Columns("Descuento").Value) Then
                Me.grdDetalleFactura.Columns("Descuento").Value = 0
            Else
                If Me.grdDetalleFactura.Columns("Descuento").Value < 0 Then
                    Me.grdDetalleFactura.Columns("Descuento").Value = 0
                End If
            End If

            If IsDBNull(Me.grdDetalleFactura.Columns("Codigo").Value) Then
                Me.grdDetalleFactura.Columns("Codigo").Value = 0
            ElseIf Me.grdDetalleFactura.Columns("Codigo").Value < 0 Then
                Me.grdDetalleFactura.Columns("Codigo").Value = 0
                Exit Sub
            ElseIf Not Me.VerificarCodigoExiste(grdDetalleFactura.Columns("Codigo").Value) Then
                MsgBox("El código ya existe.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ReiniciarGrid()
            Else
                'If Me.cmbDescripcionFactura.Text.Trim.Length = 0 Then
                If Not Me.CargarDatosGridCodigo() Then
                    MsgBox("El código ingresado no existe.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
                'End If
            End If

            If grdDetalleFactura.Columns("Codigo").Text.Trim.Length <> 0 Then
                dtDatosDetalleCodigo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Cantidad, objRepuestoID", "dbo.vwSivBodegaRepuesto", "StbTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = " & Me.grdDetalleFactura.Columns("Codigo").Text))

                If dtDatosDetalleCodigo.Rows.Count > 0 Then
                    'If Me.grdDetalleFactura.Columns("Cantidad").Value = 0 Then
                    '    MsgBox("Este respuesto no esta disponible", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    '    Me.grdDetalleFactura.Delete(Me.grdDetalleFactura.Row)
                    'Else
                    If Me.grdDetalleFactura.Columns("Cantidad").Value > dtDatosDetalleCodigo.DefaultView.Item(0)("Cantidad") Then
                        MsgBox("La cantidad debe ser mayor o igual a la existente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Me.ReiniciarGrid()
                        ' Me.grdDetalleFactura.Columns("Cantidad").Value = 0
                        Exit Sub
                    End If
                End If
            End If
            Me.CalculosTotalesGrid()
            Me.CalcularTotales()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatosDetalleCodigo = Nothing
        End Try
    End Sub

    Private Sub ReiniciarGrid()

        Me.grdDetalleFactura.Columns("CodigoBarras").Value = ""
        Me.grdDetalleFactura.Columns("Codigo").Value = ""
        Me.grdDetalleFactura.Columns("DescripcionCorta").Value = ""
        Me.grdDetalleFactura.Columns("Cantidad").Value = 0
        Me.grdDetalleFactura.Columns("Precio").Value = 0.0
        Me.grdDetalleFactura.Columns("Subtotal").Value = 0.0
        Me.grdDetalleFactura.Columns("DescuentoPor").Value = 0
        Me.grdDetalleFactura.Columns("Descuento").Value = 0.0
        Me.grdDetalleFactura.Columns("Impuesto").Value = 0.0
        Me.grdDetalleFactura.Columns("Total").Value = 0.0

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

    'Private Function GenerarCodigo() As String
    '    Dim strNumero As String = ""
    '    Dim strSerie As String = ""
    '    Dim dtMaximoNumero As New DataTable
    '    Dim dtTiendaMaximo As New DataTable
    '    Try
    '        Try
    '            dtMaximoNumero = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("MAX(SfaFacturaRepuestoID) as NumeroMaximo", "SfaFacturaRepuesto", "objTiendaID = " & Me.cmbBodega.SelectedValue.ToString))
    '            If dtMaximoNumero.DefaultView.Item(0)("NumeroMaximo").ToString.Trim.Length = 0 Then
    '                dtTiendaMaximo = StbTienda.RetrieveDT("StbTiendaID =" & Me.cmbBodega.SelectedValue, "", "ProximaFactura,Seriefactura")
    '                strSerie = dtTiendaMaximo.DefaultView.Item(0)("Seriefactura")
    '                strNumero = RellenarConCeros(dtTiendaMaximo.DefaultView.Item(0)("ProximaFactura"), 4)
    '            Else
    '                strSerie = StbTienda.RetrieveDT("StbTiendaID = " & Me.cmbBodega.SelectedValue, "", "Seriefactura").DefaultView.Item(0)("Seriefactura")
    '                strNumero = RellenarConCeros(dtMaximoNumero.DefaultView.Item(0)("NumeroMaximo"), 4)
    '            End If

    '        Catch ex As Exception
    '            clsError.CaptarError(ex)
    '        End Try
    '    Finally
    '        dtMaximoNumero = Nothing
    '        dtTiendaMaximo = Nothing
    '    End Try

    '    Return strSerie.Trim + strNumero.Trim

    'End Function

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

        If Me.grdDetalleFactura.RowCount = 0 Then
            MsgBox("Debe especificar al menos un detalle en la factura.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Return False
            Exit Function
        End If

        If Me.ExistenCantidadesEnCero Then
            Me.ErrorFactura.SetError(Me.grpDetalle, "Hay al menos un valor de cantidad en CERO.")
            Exit Function
        End If

        Return True
    End Function

    Private Function ExistenCantidadesEnCero() As Boolean
        Try
            Return Me.dtDetalleFactura.Select("Cantidad = 0").Length <> 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Function UltimaFilaGridRepuesto() As Boolean
        Return Me.grdDetalleFactura.Row = Me.grdDetalleFactura.Splits(0).Rows.Count - 1
    End Function

    Private Function DescuentoValido() As Boolean
        Dim blnValido As Boolean = True
        If Not UltimaFilaGridRepuesto() Then
            If (IsDBNull(Me.grdDetalleFactura.Columns("Cantidad").Value)) And Me.grdDetalleFactura.Columns("Cantidad").Value.ToString.Trim.Length = 0 Then
                blnValido = False
                Exit Function
            End If
            If (Me.grdDetalleFactura.Columns("Cantidad").Value <= 0) Then
                Me.ErrorFactura.SetError(Me.grpDetalle, "Debe escribir un valor de la cantidad mayor que cero.")
                blnValido = False
                Exit Function
            End If
        End If
        Return blnValido
    End Function

    Private Function EstaEnColumnaEditable() As Boolean
        Return (Me.grdDetalleFactura.Col = 0 Or Me.grdDetalleFactura.Col = 1 Or Me.grdDetalleFactura.Col = 2 Or Me.grdDetalleFactura.Col = 3)
    End Function

    Private Sub grdDetalleFactura_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleFactura.KeyDown
        ''============ Al moverse con teclas direccionales ============================================================
        'Si presiona direccional hacia abajo o hacia arriba y no se ha escrito la cantidad solicitada o está es cero entonces bloquear

        If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And Me.grdDetalleFactura.Columns("Codigo").Value.ToString.Trim.Length <> 0 Then
            If Not Me.DescuentoValido Then
                e.SuppressKeyPress = True
            End If
        ElseIf (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And EstaEnColumnaEditable() Then
            If Me.grdDetalleFactura.Columns("Codigo").Value.ToString.Trim.Length = 0 And Not UltimaFilaGridRepuesto() Then
                Try
                    If Me.grdDetalleFactura.Splits(0).Rows.Count > 2 Then 'Si tiene más de dos filas
                        Me.grdDetalleFactura.Delete(Me.grdDetalleFactura.Row)
                    End If
                Catch 'si ocurre error al eliminar que no haga nada.
                End Try
            End If
        End If
    End Sub

    Private Sub grdDetalleFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleFactura.Click
        If Me.grdDetalleFactura.Columns("Codigo").Value.ToString.Trim.Length = 0 And Not UltimaFilaGridRepuesto() Then
            Try
                If Me.grdDetalleFactura.Splits(0).Rows.Count > 2 Then 'Si tiene más de dos filas
                    Me.grdDetalleFactura.Delete(Me.grdDetalleFactura.Row)
                End If
            Catch 'si ocurre error al eliminar que no haga nada.
            End Try
        End If
    End Sub
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
    Private Sub grdDetalleFactura_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalleFactura.ButtonClick
        If e.ColIndex = 1 Then
            If (Me.grdDetalleFactura.Columns("Codigo").Value.ToString.Trim.Length <> 0) Then
                Me.CargarConsultaExistencia()
            End If
        End If

        If e.ColIndex = 7 Then
            If (Me.grdDetalleFactura.Columns("Codigo").Value.ToString.Trim.Length <> 0) Then
                Me.CargarDescuentos()
            End If
        End If
    End Sub
    Private Sub cmbDescripcionFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDescripcionFactura.TextChanged
        CargarDatosGrid()
    End Sub

    Private Sub grdDetalleFactura_AfterColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalleFactura.AfterColEdit
        Me.ValidarDespuesEditarGrid()
    End Sub

    Private Sub grdDetalleFactura_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdDetalleFactura.RowColChange
        If Me.grdDetalleFactura.Columns("Codigo").Text.Trim.Length <> 0 Then
            Me.BuscarExistencia(Me.grdDetalleFactura.Columns("Codigo").Value)
        End If
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

    Private Sub grdDetalleFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdDetalleFactura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.grdDetalleFactura.RowCount > 0 Then
                Me.txtSolicitudDescuento.Focus()
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

    Private Sub grdDetalleFactura_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleFactura.Change
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
        Me.Procesar()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.ValidarEntradaDatos Then
            Select Case Me.TypeGUI
                Case 1, 6
                    Me.AgregarFactura()
                Case 3
                    Me.AutorizarDescuento()
                Case 5
                    Select Case MsgBox("¿Seguro que desea anular la Orden de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            Me.Anular()
                    End Select
            End Select
        End If
    End Sub

#End Region

#End Region

#Region "Guardar"
    Private Sub AgregarFactura()
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

    Private Sub GuardarFactura(ByVal t As TransactionManager)
        Dim objSfaFactura As SfaFacturaRepuesto
        Try
            objSfaFactura = New SfaFacturaRepuesto

            objSfaFactura.Fecha = Me.dtpFecha.Value
            objSfaFactura.objTiendaID = Me.cmbBodega.SelectedValue
            objSfaFactura.OrdenCompra = Me.GenerarNumeroOrden()

            If Me.cmbCliente.Text.Trim.Length <> 0 Then
                objSfaFactura.objClienteID = Me.cmbCliente.SelectedValue
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
                objSfaFactura.DescuentoAutorizado = Me.numDescuento.Value
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

    Private Sub GuardarDetallefactura(ByVal T As TransactionManager)
        Dim objSfaFacturaDetalle As SfaFacturaRepuestoDetalle

        Try
            objSfaFacturaDetalle = New SfaFacturaRepuestoDetalle

            For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
                objSfaFacturaDetalle.objFacturaRepuestoID = Me.SfaFacturaID
                objSfaFacturaDetalle.objRepuestoID = Me.grdDetalleFactura.Item(I)("Codigo")
                objSfaFacturaDetalle.Precio = Me.grdDetalleFactura.Item(I)("Precio")
                objSfaFacturaDetalle.Cantidad = Me.grdDetalleFactura.Item(I)("Cantidad")
                objSfaFacturaDetalle.Subtotal = Me.grdDetalleFactura.Item(I)("SubTotal")
                objSfaFacturaDetalle.Descuento = Me.grdDetalleFactura.Item(I)("Descuento")
                objSfaFacturaDetalle.Impuesto = Me.grdDetalleFactura.Item(I)("Impuesto")
                objSfaFacturaDetalle.Total = Me.grdDetalleFactura.Item(I)("Total")
                objSfaFacturaDetalle.CostoDolares = Me.grdDetalleFactura.Item(I)("CostoProm")
                objSfaFacturaDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSfaFacturaDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSfaFacturaDetalle.Insert(T)
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Procesar()
        Dim objSfaFactura As New SfaFacturaRepuesto
        Dim objSfaFacturaDetalle As New SfaFacturaRepuestoDetalle
        Dim objSivBodegaRpuestos As New SivBodegaRepuestos
        Try
            Try
                'Verificar recibo de cancelación
                If Me.txtNumeroReciboCancelacion.Text.Trim.Length = 0 Then
                    MsgBox("No ha ingresado el número de recibo de cancelación.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Me.txtNumeroReciboCancelacion.Focus()
                    Exit Sub
                End If

                '---Actualizar el maestro de la factura (OrdenCompra)
                objSfaFactura.Retrieve(Me.SfaFacturaID)
                'objSfaFactura.serie = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo", "StbTienda", "StbTiendaID = " & Me.cmbBodega.SelectedValue)).DefaultView.Item(0)("Codigo").ToString.Trim
                'objSfaFactura.OrdenCompra = Me.GenerarNumeroOrden()
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

                For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
                    objSfaFacturaDetalle.objFacturaRepuestoID = Me.SfaFacturaID
                    objSfaFacturaDetalle.objRepuestoID = Me.grdDetalleFactura.Item(I)("Codigo")
                    objSfaFacturaDetalle.Precio = Me.grdDetalleFactura.Item(I)("Precio")
                    objSfaFacturaDetalle.Cantidad = Me.grdDetalleFactura.Item(I)("Cantidad")
                    objSfaFacturaDetalle.Subtotal = Me.grdDetalleFactura.Item(I)("SubTotal")
                    objSfaFacturaDetalle.Descuento = Me.grdDetalleFactura.Item(I)("Descuento")
                    objSfaFacturaDetalle.Impuesto = Me.grdDetalleFactura.Item(I)("Impuesto")
                    objSfaFacturaDetalle.Total = Me.grdDetalleFactura.Item(I)("Total")
                    objSfaFacturaDetalle.CostoDolares = Me.grdDetalleFactura.Item(I)("CostoProm")
                    objSfaFacturaDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objSfaFacturaDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objSfaFacturaDetalle.Insert()
                Next

                '--Actualizar la cantidad en SivBodegaRepuestos
                For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
                    objSivBodegaRpuestos.RetrieveByFilter("objTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = " & Me.grdDetalleFactura.Item(I)("Codigo"))
                    objSivBodegaRpuestos.Cantidad = objSivBodegaRpuestos.Cantidad - Me.grdDetalleFactura.Item(I)("Cantidad")
                    objSivBodegaRpuestos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSivBodegaRpuestos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSivBodegaRpuestos.Update()
                Next

                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                'Me.Imprimir()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objSfaFactura = Nothing
            objSfaFacturaDetalle = Nothing
            objSivBodegaRpuestos = Nothing
        End Try
    End Sub

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

    Private Sub Anular()
        Dim objSfaFactura As New SfaFacturaRepuesto
        Dim objSfaFacturaDetalle As New SfaFacturaRepuestoDetalle
        Dim objSivBodegaRpuestos As New SivBodegaRepuestos
        Try
            Try
                If Me.cmbMotivoAnular.Text.Trim.Length <> 0 Then

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

                    '---Actualizar el detalle de la factura
                    For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
                        objSfaFacturaDetalle.RetrieveByFilter("objFacturaRepuestoID = " & SfaFacturaID & " AND objRepuestoID = " & Me.grdDetalleFactura.Item(I)("Codigo"))
                        objSfaFacturaDetalle.Cantidad = 0
                        objSfaFacturaDetalle.Subtotal = 0.0
                        objSfaFacturaDetalle.Descuento = 0.0
                        objSfaFacturaDetalle.Impuesto = 0.0
                        objSfaFacturaDetalle.Total = 0.0
                        objSfaFacturaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objSfaFacturaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objSfaFacturaDetalle.Update()
                    Next

                    '--Actualizar la cantidad en SivBodegaRepuestos
                    For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
                        objSivBodegaRpuestos.RetrieveByFilter("objTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = " & Me.grdDetalleFactura.Item(I)("Codigo"))
                        objSivBodegaRpuestos.Cantidad = objSivBodegaRpuestos.Cantidad + Me.grdDetalleFactura.Item(I)("Cantidad")
                        objSivBodegaRpuestos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objSivBodegaRpuestos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objSivBodegaRpuestos.Update()
                    Next

                    MsgBox(" Orden Compra Anulada satisfactoriamente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Me.ErrorFactura.SetError(Me.cmbMotivoAnular, My.Resources.MsgObligatorio)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objSfaFactura = Nothing
            objSfaFacturaDetalle = Nothing
            objSivBodegaRpuestos = Nothing
        End Try
    End Sub
#End Region

End Class