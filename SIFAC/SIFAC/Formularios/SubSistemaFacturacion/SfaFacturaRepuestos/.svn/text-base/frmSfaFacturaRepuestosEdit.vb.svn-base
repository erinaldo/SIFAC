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
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmSfaFacturaRepuestosEditar

#Region "Variables del formulario"
    Dim dtDescripcionFactura, dtDescripcionMoto, dtMotivoAnular, dtDetalleFactura, dtDetalleFacturaMoto, dtExpediente, dtTienda, dtTipoPago, dtCliente, dtVendedor As DataTable
    Dim boolModificado, boolRegistrada As Boolean
    Dim boolExisteErroresGrid As Boolean
    Private m_TypeGui As Integer
    Private m_MontoTasaCambio As Double
    Private m_SfaFacturaID, m_SivRepuestosID As Integer
    Private m_MaxItemsDetalle As Integer
    Dim m_strmarca, m_strmodelo, m_strcolor, m_strchasis, m_strano As String
    Dim m_strmotor, m_strcilindraje, m_strcilindros, m_strtipo As String
    Dim m_strcombustible, m_strvelocidades, m_strpasajeros, m_strpoliza As String
    Dim m_SfaCotizacionID As Integer

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

    Property SfaCotizacionID() As Integer
        Get
            Return m_SfaCotizacionID
        End Get
        Set(ByVal value As Integer)
            m_SfaCotizacionID = value
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
        dtTienda = StbTienda.RetrieveDT("Activo = 1 AND Codigo <> 'C' AND Codigo <> 'ME' ", , "StbTiendaID, Codigo,Nombre")
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
        dtVendedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("NombreVendedor, SrhEmpleadoID ", "vwSfaVendedorFactura", "1=1"))
        With Me.cmbVendedor
            .DataSource = Me.dtVendedor
            .ValueMember = "SrhEmpleadoID"
            .DisplayMember = "NombreVendedor"
            .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
            .ExtendRightColumn = True
        End With

    End Sub
#End Region

#Region "Cargar Clientes"
    Private Sub CargarClientes()
        dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto", "vwSfaClienteFactura", "Descripcion = 'Cliente' AND StbPersonaID NOT IN (SELECT objFiadorID FROM vwSccCuentaFiador WHERE Estado = 'VIGENTE')"))
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
        dtTipoPago = ClsCatalogos.GetValoresCatalogo("TERMINOPAGO", "StbValorCatalogoID,Descripcion", "")
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
        dtMotivoAnular = ClsCatalogos.GetValoresCatalogo("MOTIVOANULARFACT", "StbValorCatalogoID,Descripcion", "")
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

#End Region

#Region "Cargar Grid"
    Private Sub CargarDetalleFactura(ByVal strFiltro As String)
        dtDetalleFactura = New DataTable
        Try
            dtDetalleFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoBarras,objFacturaRepuestoID, Codigo, DescripcionCorta, Cantidad, CostoProm,Precio,cast(0 as float) as DescuentoPor, Descuento, Subtotal, Impuesto, Total", "vwSfaDetalleRepuestos", strFiltro))
            Me.grdDetalleFactura.DataSource = dtDetalleFactura
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

                    If Me.chkAgregarMoto.Checked Then
                        dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

                        'Isertar detalle de Factura              

                        For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
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

                    Else
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
                    End If

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

        Me.numPrima.Enabled = False
        Me.numSaldo.Enabled = False
        Me.numDescuento.Enabled = False
        Me.chkAutorizar.Enabled = False
    End Sub

    Private Sub ConfigurarGUI()
        Dim puntoBoton As New Point

        puntoBoton.X = 658
        puntoBoton.Y = 626

        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarTienda()
        Me.CargarClientes()
        Me.CargarVendedor()
        Me.CargarTipoPago()
        Me.FormatearGrids()
        AutorizacionGenerencia()

        Select Case Me.TypeGUI
            Case 1
                Me.cmbVendedor.SelectedValue = SsgCuenta.RetrieveDT("Login = '" & clsProyecto.Conexion.Usuario & "'", "", "objEmpleadoID").DefaultView.Item(0)("objEmpleadoID")
                Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                Me.CargarDetalleFactura("1=0")
                CargarDetalleFacturaMoto("1=0")
                Me.CargarDescripcion("1=1")
                Me.CargarDescripcionMoto("1=1")
                Me.numTasa.Value = Me.MontoTasaCambio
                Me.MaxItemDetalle = ClsCatalogos.GetValorParametro("MaxItemsDetalleFactura")
                Me.lblCantidadMaxItems.Text = Me.lblCantidadMaxItems.Text + " " + Me.MaxItemDetalle.ToString

                Me.Text = "Agregar Factura"
                Me.txtNumero.Text = Me.GenerarCodigo
                Me.txtObervaciones.MaxLength = SfaFacturaRepuesto.GetMaxLength("observaciones")

            Case 2
                Me.Text = "Procesar Factura"
                Me.txtNumero.Text = Me.GenerarCodigo
                CargarDatosConsulta()

                If Me.chkAgregarMoto.Checked Then
                    Me.CargarDetalleFacturaMoto("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    Me.CargarDescripcionMoto("1=1")
                Else
                    Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    Me.CargarDescripcion("1=1")
                End If
                Me.BloquearControles()

                If (Me.chkSolicitudDescuento.Checked) And (Me.chkAutorizar.Checked) Then
                    Me.cmdProcesar.Enabled = True
                    Me.cmdAceptar.Enabled = False
                End If
                Me.grdDetalleFactura.Enabled = False
                Me.grdDetalleMoto.Enabled = False

                Me.MaxItemDetalle = ClsCatalogos.GetValorParametro("MaxItemsDetalleFactura")
                Me.lblCantidadMaxItems.Text = Me.lblCantidadMaxItems.Text + " " + Me.MaxItemDetalle.ToString

            Case 3
                Me.Text = "Procesar Factura"
                Me.txtNumero.Text = Me.GenerarCodigo
                CargarDatosConsulta()

                If Me.chkAgregarMoto.Checked Then
                    Me.CargarDetalleFacturaMoto("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    Me.CargarDescripcionMoto("1=1")
                Else
                    Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    Me.CargarDescripcion("1=1")
                End If
                Me.BloquearControles()

                If (Me.chkSolicitudDescuento.Checked) And (Me.chkAutorizar.Checked) Then
                    Me.cmdProcesar.Enabled = True
                    Me.cmdAceptar.Enabled = False

                ElseIf Not Me.chkSolicitudDescuento.Checked Then
                    Me.cmdProcesar.Enabled = True
                    Me.cmdAceptar.Enabled = False
                Else
                    Me.cmdProcesar.Enabled = False
                    Me.cmdAceptar.Enabled = True
                End If

                Me.grdDetalleFactura.Enabled = False
                Me.grdDetalleMoto.Enabled = False

                Me.numDescuento.Enabled = True
                Me.chkAutorizar.Enabled = True
                Me.grdDetalleFactura.Enabled = False
                Me.grdDetalleMoto.Enabled = False
                Me.numPrima.Enabled = True
                Me.numSaldo.Enabled = True

                Me.MaxItemDetalle = ClsCatalogos.GetValorParametro("MaxItemsDetalleFactura")
                Me.lblCantidadMaxItems.Text = Me.lblCantidadMaxItems.Text + " " + Me.MaxItemDetalle.ToString
               
            Case 4
                Me.Text = "Consultando Factura"
                CargarDatosConsulta()
                If Me.chkAgregarMoto.Checked Then
                    Me.CargarDetalleFacturaMoto("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    Me.CargarDescripcionMoto("1=1")
                Else
                    Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    Me.CargarDescripcion("1=1")
                End If
                Me.BloquearControles()
                Me.grdDetalleFactura.Enabled = False
                Me.grdDetalleMoto.Enabled = False

            Case 5
                Me.Text = "Anulando Factura"
                CargarDatosConsulta()

                If Me.chkAgregarMoto.Checked Then
                    Me.CargarDetalleFacturaMoto("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    Me.CargarDescripcionMoto("1=1")
                Else
                    Me.CargarDetalleFactura("objFacturaRepuestoID = " & Me.SfaFacturaID)
                    Me.CargarDescripcion("1=1")
                End If

                Me.BloquearControles()
                Me.lblMotivo.Visible = True
                Me.cmbMotivoAnular.Visible = True
                Me.CargarMotivoAnular()
                Me.cmdProcesar.Visible = False
                Me.cmdAceptar.Location = puntoBoton
                Me.cmbMotivoAnular.Enabled = True
                Me.cmdAceptar.Enabled = True
                Me.grdDetalleFactura.Enabled = False
                Me.grdDetalleMoto.Enabled = False

            Case 6
                Me.Text = "Agregar Factura"
                Me.txtNumero.Text = Me.GenerarCodigo
                Me.CargarDatosMaestroCotización()
                Me.CargarDescripcion("1=1")
                CargarDatosDetalleCotizaccion("objCotizacionID = " & Me.SfaCotizacionID)
                Me.MaxItemDetalle = ClsCatalogos.GetValorParametro("MaxItemsDetalleFactura")
                Me.lblCantidadMaxItems.Text = Me.lblCantidadMaxItems.Text + " " + Me.MaxItemDetalle.ToString
                Me.grdDetalleFactura.Enabled = False
                Me.grdDetalleMoto.Enabled = False
                Me.BloquearControles()
                Me.cmdAceptar.Enabled = True
                Me.cmdProcesar.Enabled = True
        End Select
    End Sub
#End Region

#Region "Cargar Datos Consulta"

    Private Sub CargarDatosConsulta()
        Dim objSfaFactura As New SfaFacturaRepuesto
        Try
            Try
                objSfaFactura.Retrieve(Me.SfaFacturaID)

                Me.cmbBodega.SelectedValue = objSfaFactura.objTiendaID

                If Not String.IsNullOrEmpty(objSfaFactura.objClienteID) Then
                    Me.cmbCliente.SelectedValue = objSfaFactura.objClienteID
                End If

                If (IsDBNull(objSfaFactura.serie)) And (IsDBNull(objSfaFactura.Numero)) Then
                    Me.txtNumero.Text = objSfaFactura.serie.Trim + objSfaFactura.Numero.ToString.Trim
                End If

                If Not String.IsNullOrEmpty(objSfaFactura.objClienteID) Then
                    Me.txtCodigoCliente.Text = objSfaFactura.objClienteID
                End If

                If Not IsDBNull(objSfaFactura.AtencionA) Then
                    Me.txtAtencionA.Text = objSfaFactura.AtencionA
                End If

                Me.dtpFecha.Value = objSfaFactura.Fecha

                If (objSfaFactura.objVendedorID.HasValue) Then
                    Me.cmbVendedor.SelectedValue = objSfaFactura.objVendedorID
                End If

                Me.cmbTPago.SelectedValue = objSfaFactura.objTerminoPagoID
                Me.numTasa.Value = objSfaFactura.TasaCambio
                Me.chkSolicitudDescuento.Checked = objSfaFactura.SolicAutorDescuento

                If Not String.IsNullOrEmpty(objSfaFactura.SolicitudDescuento) Then
                    Me.txtSolicitudDescuento.Text = objSfaFactura.SolicitudDescuento
                End If

                If Not String.IsNullOrEmpty(objSfaFactura.observaciones) Then
                    Me.txtObervaciones.Text = objSfaFactura.observaciones
                End If
                Me.numSubTotal.Value = objSfaFactura.Subtotal

                Me.chkAutorizar.Checked = objSfaFactura.AutorizaDescuento

                Select Case Me.TypeGUI
                    Case 2, 3

                        'Me.numTotalC.Value = objSfaFactura.TotalCordobas
                        'Me.numTotalDescuento.Value = objSfaFactura.Descuento
                        'Me.numTotalD.Value = objSfaFactura.TotalDolares

                        'If objSfaFactura.DescuentoAutorizado.ToString.Trim.Length > 0 Then
                        '    Me.numDescuento.Value = objSfaFactura.DescuentoAutorizado
                        '    Me.numTotalDescuento.Value = objSfaFactura.DescuentoAutorizado * Me.numTasa.Value
                        '    Me.numTotalC.Value = objSfaFactura.Subtotal - Me.numTotalDescuento.Value
                        '    Me.numTotalD.Value = Me.numTotalC.Value / Me.numTasa.Value
                        'Else

                        If Not String.IsNullOrEmpty(objSfaFactura.DescuentoAutorizado.ToString) Then
                            Me.NumDescuento.Value = objSfaFactura.DescuentoAutorizado
                        End If

                        Me.numTotalC.Value = objSfaFactura.TotalCordobas
                        Me.numTotalDescuento.Value = objSfaFactura.Descuento
                        Me.numTotalD.Value = objSfaFactura.TotalDolares
                        Me.numIVA.Value = objSfaFactura.Impuesto
                        'End If
                    Case 4, 5
                        Me.numTotalC.Value = objSfaFactura.TotalCordobas
                        Me.numTotalDescuento.Value = objSfaFactura.Descuento
                        Me.numTotalD.Value = objSfaFactura.TotalDolares
                        Me.numIVA.Value = objSfaFactura.Impuesto
                End Select

                Me.chkAgregarMoto.Checked = objSfaFactura.FacturaMoto
                If objSfaFactura.FacturaMoto Then
                    Me.numPrima.Value = objSfaFactura.Prima
                    Me.numSaldo.Value = objSfaFactura.Saldo
                End If

                If (objSfaFactura.SolicAutorDescuento) And (objSfaFactura.AutorizaDescuento) Then
                    Me.cmdProcesar.Enabled = True
                    Me.cmdAceptar.Enabled = False
                End If

                If Not String.IsNullOrEmpty(objSfaFactura.DescuentoAutorizado.ToString) Then
                    Me.numDescuento.Value = objSfaFactura.DescuentoAutorizado
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
        Me.chkAgregarMoto.Enabled = False
        Me.cmdBuscar.Enabled = False
        Me.chkSolicitudDescuento.Enabled = False
        Me.txtObervaciones.Enabled = False
        Me.cmdAceptar.Enabled = False
        Me.cmdProcesar.Enabled = False
        Me.txtSolicitudDescuento.Enabled = False
        Me.numDescuento.Enabled = False
        Me.chkAutorizar.Enabled = False
        Me.cmdCliente.Enabled = False
        Me.cmdAgregarCliente.Enabled = False
    End Sub
#End Region

#End Region

#Region "Procedimiento para Grid de Moto"

#Region "Cargar Descripcion Grid"

    Private Sub CargarDescripcionMoto(ByVal strFiltro As String)
        Dim riLookComboDescripcion As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Try
            dtDescripcionMoto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivRepuestoID,DescripcionCorta", "vwSivRepuestos", strFiltro & " AND SivRepuestoID IN('1','2') " & " ORDER BY DescripcionCorta"))
            riLookComboDescripcion = Me.grdDetalleMoto.RepositoryItems(1)
            riLookComboDescripcion.DataSource = dtDescripcionMoto

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDescripcionMoto = Nothing
        End Try
    End Sub

#End Region

#Region "Calculos"
    Private Sub CalcularTotalesMoto()
        Dim DecSubTotal, DecDescuento, DecIVA, DecTotalCord As Double

        Try
            DecSubTotal = 0.0
            DecDescuento = 0.0
            DecIVA = 0.0
            DecTotalCord = 0.0

            If Not Me.dtDetalleFacturaMoto Is Nothing Then
                If Me.dtDetalleFacturaMoto.DefaultView.Count > 0 Then
                    DecSubTotal = Me.dtDetalleFacturaMoto.Compute("SUM(Subtotal)", "1=1")
                    DecDescuento = Me.dtDetalleFacturaMoto.Compute("SUM(Descuento)", "1=1")
                    DecIVA = Me.dtDetalleFacturaMoto.Compute("SUM(Impuesto)", "1=1")
                    DecTotalCord = Me.dtDetalleFacturaMoto.Compute("SUM(Total)", "1=1")
                End If
            End If

            Me.numSubTotal.Value = DecSubTotal * numTasa.Value
            Me.numTotalDescuento.Value = DecDescuento * numTasa.Value
            Me.numIVA.Value = DecIVA * numTasa.Value
            Me.numTotalC.Value = DecTotalCord * numTasa.Value
            Me.numTotalD.Value = DecTotalCord

            'If Me.Autorizacion Then
            '    Me.numDescuento.Value = Me.numTotalDescuento.Value / Me.numTasa.Value
            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub RecalcularDescuentoMoto()
        Dim descuentofilas, descuento, precio, subtotal As Double
        Dim cantidad, filas As Integer

        For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
            If Me.numDescuento.Text.Trim.Length = 0 Then
                row("Descuento").Value = 0.0
            Else
                precio = row("Precio")
                subtotal = row("SubTotal")
                cantidad = row("Cantidad")
                filas = (Me.dtDetalleFactura.Rows.Count)
                descuentofilas = Me.numDescuento.Value
                row("Descuento") = (precio - ((subtotal - (descuentofilas) / filas) / cantidad)) * cantidad
                row("DescuentoPor") = ((row("Descuento")) * 100) / subtotal
                descuento = row("Descuento")
                row("Subtotal") = (row("Cantidad")) * (row("Precio"))

                If Me.chkExonerado.Checked = True Then
                    row("Impuesto") = 0
                Else
                    row("Impuesto") = (row("Subtotal") - row("Descuento")) * (ClsCatalogos.GetValorParametro("PORCENTAJEIMPUESTO") / 100)
                End If
                row("Total") = (row("Subtotal")) - (row("Descuento")) + (row("Impuesto"))

            End If
        Next

        Me.CalcularTotalesMoto()
    End Sub

#End Region

#Region "RellenarDatosGrid"
    Private Sub RellenarDatosGridMoto(ByVal strFiltro As String, ByVal intFilaActual As Integer)
        Dim objSivRepuestos As SivRepuestos
        Dim objSivBodegaRepuestos As SivBodegaRepuestos
        Dim dtProductoDescuento As DataTable
        Dim strCampos, strFiltroFecha As String

        objSivRepuestos = New SivRepuestos
        objSivBodegaRepuestos = New SivBodegaRepuestos

        'Cargar los datos del Repuesto, Detalle Repuesto Proveedor y Bodega Repuestos
        objSivRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & strFiltro & "'" & " AND Activo=1") 'REVISAR ESTO POR REGLAS DE NEGOCIO
        objSivBodegaRepuestos.RetrieveByFilter("objRepuestoID=" & "'" & objSivRepuestos.SivRepuestoID & "' AND objTiendaID= " & Me.cmbBodega.SelectedValue)
        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("CodigoBarras") = objSivRepuestos.CodigoBarras
        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Codigo") = objSivRepuestos.SivRepuestoID
        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Codigo") = objSivRepuestos.SivRepuestoID

        If objSivRepuestos.SivRepuestoID = "3" Then 'Servicio de instalación
            Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Cantidad") = 1
        Else
            Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Cantidad") = 0
        End If

        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Precio") = objSivRepuestos.Precio
        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Subtotal") = 0
        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Descuento") = 0

        Try
            strCampos = "ISNULL(MAX(Descuento),0) AS MaximoDescuento"
            strFiltroFecha = " fechafin >= GETDATE() AND objRepuestoID= " & objSivRepuestos.SivRepuestoID

            dtProductoDescuento = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(strCampos, "vwSfaDescuentosFactura", strFiltroFecha))
            If dtProductoDescuento.Rows.Count <> 0 Then
                Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("DescuentoPor") = dtProductoDescuento.DefaultView.Item(0)("MaximoDescuento") * 100
            End If
        Catch ex As Exception
            'Si hay error que no asigne descuento, dejando que el usuario lo seleccione
        End Try

        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Impuesto") = 0
        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("Total") = 0
        'Me.dtDetalleFactura.DefaultView.Item(intFilaActual)("Existencia") = objSivBodegaRepuestos.Cantidad
        Me.dtDetalleFacturaMoto.DefaultView.Item(intFilaActual)("CostoProm") = objSivRepuestos.CostoProm
        Me.numExistencia.Value = objSivBodegaRepuestos.Cantidad
        'Mover el foco a columna Cantidad
        Me.grdDetalleMototabla.FocusedColumn = Me.ColCantidadMoto
    End Sub

#End Region

#Region "KeyDown"

    Private Sub grdDetalleMototabla_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleMototabla.KeyDown
        Dim blnEnfoque As Boolean

        '---- Delete
        If e.KeyCode = Keys.Delete Then
            Dim view As GridView = CType(sender, GridView)
            If view.RowCount <> 0 Then
                If Me.EsFilaVaciaMoto Then
                    Me.ElminarFilaSinPreguntarMoto()
                Else
                    Me.EliminarFilaMoto()
                    Me.CalcularTotalesMoto()
                End If
            End If
        End If

        '---- Enter
        If e.KeyCode = Keys.Enter Then
            'Si no hay filas
            If Me.grdDetalleMototabla.RowCount = 0 Then
                Me.InsertarNuevaFilaGridMoto()
                Exit Sub
            End If

            'Cantidad
            If Me.grdDetalleMototabla.FocusedColumn.Equals(Me.ColCantidadMoto) OrElse Me.grdDetalleMototabla.FocusedColumn.Equals(Me.colPorcentajeMoto) Then '3=Servicio de instalación

                blnEnfoque = Me.grdDetalleMototabla.FocusedColumn.Equals(Me.colCantidad)
                If blnEnfoque Then
                    If Me.grdDetalleMototabla.FocusedColumn.View.FocusedValue = 0 Then
                        Exit Sub
                    End If
                End If
            End If
        End If

        '---- Direccional hacia abajo
        If (e.KeyCode = Keys.Down) And (boolExisteErroresGrid = False) Then
            If Me.grdDetalleMototabla.RowCount <> 0 Then
                Dim valor As Object = Me.grdDetalleMototabla.Columns("Cantidad").View.GetRowCellValue(Me.grdDetalleMototabla.FocusedRowHandle, "Cantidad")
                If Me.EstaEnUltimaFilaMoto And Me.NumeroValido(valor) And (Not Me.EsFilaVaciaMoto) Then
                    Me.InsertarNuevaFilaGridMoto()
                End If
            Else
                Me.InsertarNuevaFilaGridMoto()
            End If
        End If

        '----- Direccional hacia arriba
        If e.KeyCode = Keys.Up Then
            If Me.EsFilaVaciaMoto And Me.grdDetalleMototabla.RowCount <> 1 Then
                e.SuppressKeyPress = True
                Me.ElminarFilaSinPreguntarMoto()
            End If
        End If

        '--- Direccional hacia derecha
        Try
            If e.KeyCode = Keys.Right AndAlso Me.grdDetalleMototabla.FocusedColumn.Equals(Me.ColCantidadMoto) And (boolExisteErroresGrid = False) Then
                Dim Cantidad As Object = Me.grdDetalleMototabla.Columns("Cantidad").View.GetRowCellValue(Me.grdDetalleMototabla.FocusedRowHandle, "Cantidad")
                If Cantidad <> Nothing Then
                    If Me.EstaEnUltimaFilaMoto AndAlso Me.NumeroValido(Cantidad) AndAlso (Not Me.EsFilaVacia) AndAlso (IdRepuestoSeleccionado() <> 3) Then
                        e.SuppressKeyPress = True
                        Me.InsertarNuevaFilaGridMoto()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

        'Si presiona control + B abre buscar repuesto.
        If e.KeyCode = Keys.B And e.Modifiers = Keys.Control Then
            Me.CargarBuscarRepuesto()
        End If

        'Si se preciona TAB estando en la última Celda editable
        If e.KeyCode = Keys.Tab AndAlso Me.grdDetalleMototabla.FocusedColumn.Equals(Me.colPorcentajeMoto) Then
            Me.txtObervaciones.Focus()
        End If
    End Sub


#End Region

#Region "Eliminar Fila"
    Private Sub EliminarFilaMoto()
        If MsgBox("¿Seguro que desea eliminar la fila seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes Then
            Try
                Me.dtDetalleFacturaMoto.Rows.RemoveAt(Me.grdDetalleMototabla.FocusedRowHandle) 'Borra la fila del datatable directo
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region

#Region "Eliminar sin Preguntar"
    Private Sub ElminarFilaSinPreguntarMoto()
        Try
            If Me.dtDetalleFacturaMoto.Rows.Count <> 0 Then
                Me.dtDetalleFacturaMoto.Rows.RemoveAt(Me.grdDetalleMototabla.FocusedRowHandle) 'Borra la fila del datatable directo
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Insertar Nueva Fila"
    Private Sub InsertarNuevaFilaGridMoto()
        Try
            If Me.grdDetalleMototabla.RowCount = 0 Then
                Me.dtDetalleFacturaMoto.Rows.Add()
                Me.grdDetalleMototabla.MoveLast()
                Me.grdDetalleMototabla.FocusedColumn = Me.colBarCode
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Es fila vacía"
    Private Function EsFilaVaciaMoto() As Boolean
        Dim blnRetorno As Boolean = False
        Dim Valor As New Object
        Try
            Valor = Me.grdDetalleMototabla.Columns("Codigo").View.GetRowCellValue(Me.grdDetalleMototabla.FocusedRowHandle, "Codigo")
            blnRetorno = Not Me.TieneValor(Valor)
        Catch ex As Exception
            blnRetorno = False
        End Try
        Return blnRetorno
    End Function
#End Region

#Region "Existe en detalle"
    Private Function ExisteEnDetalleMoto(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
            If Me.TieneValor(valor) AndAlso Me.TieneValor(row(Campo)) Then
                If valor = row(Campo) Then
                    blnValor = True
                End If
            End If
        Next
        Return blnValor
    End Function
#End Region

#Region "Está en última fila"
    Private Function EstaEnUltimaFilaMoto() As Boolean
        Return Me.grdDetalleMototabla.FocusedRowHandle = Me.grdDetalleMototabla.RowCount - 1
    End Function
#End Region

#Region "Buscar Duplicados en Grid"
    Private Function BuscarDuplicadosMoto(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        Dim iContador As Integer = 0
        If Me.dtDetalleFacturaMoto.Rows.Count > 1 Then
            For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
                row.EndEdit()
                If Me.TieneValor(valor) AndAlso Me.TieneValor(row(Campo)) Then
                    If valor = row(Campo) Then
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

#Region "Habilitar Precio y Descuento"
    Private Sub HabilitarPrecioDescuentoMoto(ByVal Habilitar As Boolean)
        If Habilitar Then
            Me.grdDetalleMototabla.Columns("DescuentoPor").OptionsColumn.AllowFocus = True
            Me.grdDetalleMototabla.Columns("DescuentoPor").AppearanceCell.BackColor = Color.White
            Me.grdDetalleMototabla.Columns("DescuentoPor").OptionsColumn.ReadOnly = False

            Me.grdDetalleMototabla.Columns("Precio").OptionsColumn.AllowFocus = True
            Me.grdDetalleMototabla.Columns("Precio").AppearanceCell.BackColor = Color.White
            Me.grdDetalleMototabla.Columns("Precio").OptionsColumn.ReadOnly = False
        Else
            Me.grdDetalleMototabla.Columns("DescuentoPor").OptionsColumn.AllowFocus = True
            Me.grdDetalleMototabla.Columns("DescuentoPor").AppearanceCell.BackColor = Color.LemonChiffon
            Me.grdDetalleMototabla.Columns("DescuentoPor").OptionsColumn.ReadOnly = True

            Me.grdDetalleMototabla.Columns("Precio").OptionsColumn.AllowFocus = False
            Me.grdDetalleMototabla.Columns("Precio").AppearanceCell.BackColor = Color.LemonChiffon
            Me.grdDetalleMototabla.Columns("Precio").OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "Id Respuesto Seleccionado"
    Private Function IdRepuestoSeleccionadoMoto() As Integer
        Dim CodigoRepuesto As Object = Me.grdDetalleMototabla.Columns("Codigo").View.GetRowCellValue(Me.grdDetalleMototabla.FocusedRowHandle, "Codigo")
        If Not Me.NumeroValido(CodigoRepuesto) Then
            CodigoRepuesto = 0
        End If
        Return CodigoRepuesto
    End Function
#End Region


#End Region

#Region "Procedimientos para el Grid"

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
    Private Function NumeroValidoCodigo(ByVal valor As Object) As Boolean
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
    Private Function IdRepuestoSeleccionado() As String
        Dim CodigoRepuesto As Object = Me.grdDetalleFacturaTabla.Columns("Codigo").View.GetRowCellValue(Me.grdDetalleFacturaTabla.FocusedRowHandle, "Codigo")
        If Not Me.NumeroValidoCodigo(CodigoRepuesto) Then
            CodigoRepuesto = "0"
        End If
        Return CodigoRepuesto
    End Function
#End Region

#Region "Calculos"
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

            'Me.numSubTotal.Value = DecSubTotal * numTasa.Value
            'Me.numTotalDescuento.Value = DecDescuento * numTasa.Value
            'Me.numIVA.Value = DecIVA * numTasa.Value
            'Me.numTotalC.Value = DecTotalCord * numTasa.Value
            'Me.numTotalD.Value = DecTotalCord

            'Se realizarán los cálculos usando un redondeo de dos decimales
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

    Private Sub RecalcularDescuento()
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

    Private Sub grdspnPorcentajeDescuento_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles grdspnPorcentajeDescuento.ButtonClick
        If e.Button.Index = 1 Then
            Me.CargarDescuentos()
        End If
    End Sub
#End Region

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
                Me.grdDetalleFactura.Focus()
                Exit Sub
            End If

            'Cargar los datos del repuesto en el grid de detalle de cotización
            Me.grdDetalleFactura.Focus()
            If Not Me.EsFilaVacia Then
                Me.InsertarNuevaFilaGrid()
            End If
            'Me.RellenarDatosGrid(objRepuestoId, Me.grdDetalleFacturaTabla.FocusedRowHandle)
            Me.boolModificado = True
            Me.grdDetalleFacturaTabla.RefreshData()
        End If

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

                Me.txtNumero.Text = Me.GenerarCodigo
                Me.txtObervaciones.MaxLength = SfaFacturaRepuesto.GetMaxLength("observaciones")

                Me.cmbTPago.SelectedValue = objSfaCotizacion.objTerminoPagoID
                Me.numTasa.Value = objSfaCotizacion.TasaCambio

                Me.numSubTotal.Value = objSfaCotizacion.Subtotal
                Me.numTotalC.Value = objSfaCotizacion.TotalCordobas
                Me.numTotalD.Value = objSfaCotizacion.TotalDolares
                Me.NumDescuento.Value = objSfaCotizacion.Descuento
                Me.numIVA.Value = objSfaCotizacion.Impuesto

                Me.chkAgregarMoto.Enabled = False

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objSfaCotizacion = Nothing
        End Try
    End Sub

    Private Sub CargarDatosDetalleCotizaccion(ByVal strFiltro As String)
        dtDetalleFactura = New DataTable
        dtDetalleFacturaMoto = New DataTable
        Try
            If Me.chkAgregarMoto.Checked Then
                dtDetalleFacturaMoto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoBarras,objCotizacionID, Codigo, DescripcionCorta, Cantidad, CostoProm,Precio,Descuento, Subtotal, Impuesto, Total", "vwSfaDetalleRepuestosCotizacion", strFiltro))
                Me.grdDetalleMoto.DataSource = dtDetalleFacturaMoto
            Else
                dtDetalleFactura = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoBarras,objCotizacionID, Codigo, DescripcionCorta, Cantidad, CostoProm,Precio,Descuento, Subtotal, Impuesto, Total", "vwSfaDetalleRepuestosCotizacion", strFiltro))
                Me.grdDetalleFactura.DataSource = dtDetalleFactura
            End If
           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

#End Region

#Region "Cargar Datos del Cliente"

    Private Sub CargarDatosCliente()
        Dim dtDatosCliente As New DataTable
        Try
            Try
                If Not String.IsNullOrEmpty(Me.cmbCliente.Text) Then
                    dtDatosCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID, NombreCompleto, Direccion, Email, TelefonoParticular,TelefonoTrabajo, Celular, Exonerado", "vwSfaClienteFactura", "StbPersonaID = '" & Me.cmbCliente.SelectedValue & "'"))

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
                Else
                    Me.txtDireccion.Text = ""
                    Me.txtEmail.Text = ""
                    Me.txtTelefono.Text = ""
                    Me.chkExonerado.Checked = False
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
                If Not String.IsNullOrEmpty(Me.cmbCliente.Text) Then
                    dtExpediente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objClienteID, SccCuentaID, objProductoID, ModeloMarca, Saldo", "vwSfaExpedienteCliente", "objClienteID ='" & Me.cmbCliente.SelectedValue) & "'")
                Else
                    dtExpediente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objClienteID, SccCuentaID, objProductoID, ModeloMarca, Saldo", "vwSfaExpedienteCliente", "1 =0"))
                End If

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

#Region "Factura de Repuestos"

    Private Sub CargarConsultaExistencia()
        Dim objConsulta As frmSfaExistencia
        Dim FilaActual As Integer

        Try
            Try
                If Not Me.chkAgregarMoto.Checked Then
                    FilaActual = Me.grdDetalleFacturaTabla.FocusedRowHandle
                    If Not IsDBNull(Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Codigo")) Then
                        objConsulta = New frmSfaExistencia
                        objConsulta.strCodigo = Me.dtDetalleFactura.DefaultView.Item(FilaActual)("Codigo")
                        objConsulta.bolAgregarMoto = False
                        objConsulta.ShowDialog(Me)
                    End If
                Else
                    FilaActual = Me.grdDetalleMototabla.FocusedRowHandle
                    If Not IsDBNull(Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Codigo")) Then
                        objConsulta = New frmSfaExistencia
                        objConsulta.strCodigo = Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Codigo")
                        objConsulta.bolAgregarMoto = True
                        objConsulta.ShowDialog(Me)
                    End If
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
                        'Me.grdDetalleFactura.Columns("DescuentoPor").Value = objDescuento.Descuento
                        'Me.grdDetalleFactura.Columns("Descuento").Value = objDescuento.Descuento * Me.grdDetalleFactura.Columns("SubTotal").Value
                        'Me.grdDetalleFactura.Columns("Impuesto").Value = Me.grdDetalleFactura.Columns("SubTotal").Value * 0.15
                        'Me.grdDetalleFactura.Columns("Total").Value = Me.grdDetalleFactura.Columns("SubTotal").Value - Me.grdDetalleFactura.Columns("Descuento").Value + Me.grdDetalleFactura.Columns("Impuesto").Value
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
                If Me.chkAgregarMoto.Checked Then
                    objBuscarRepuestos.strFiltro = " SivRepuestoID IN (1,2)"

                Else
                    objBuscarRepuestos.strFiltro = " SivRepuestoID NOT IN (1,2)"
                End If

                If objBuscarRepuestos.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.SivRepuestosID = objBuscarRepuestos.objRepuestoIdSeleccionado

                    If Me.chkAgregarMoto.Checked Then
                        'Verificar si ya se encuentra el repuesto en Detalle
                        If ExisteEnDetalleMoto(SivRepuestosID, "Codigo") Then
                            MsgBox("El repuesto seleccionado ya se encuentra en detalle de Factura.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                            Me.grdDetalleMoto.Focus()
                            Exit Sub
                        End If

                        'Cargar los datos del repuesto en el grid de detalle de cotización
                        Me.grdDetalleMoto.Focus()
                        If Not Me.EsFilaVaciaMoto Then
                            Me.InsertarNuevaFilaGridMoto()
                        End If
                        Me.RellenarDatosGridMoto(SivRepuestosID, Me.grdDetalleMototabla.FocusedRowHandle)
                        Me.boolModificado = True
                        Me.grdDetalleMototabla.RefreshData()

                    Else
                        'Verificar si ya se encuentra el repuesto en Detalle
                        If ExisteEnDetalle(SivRepuestosID, "Codigo") Then
                            MsgBox("El repuesto seleccionado ya se encuentra en detalle de Factura.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                            Me.grdDetalleFactura.Focus()
                            Exit Sub
                        End If

                        'Cargar los datos del repuesto en el grid de detalle de cotización
                        Me.grdDetalleFactura.Focus()
                        If Not Me.EsFilaVacia Then
                            Me.InsertarNuevaFilaGrid()
                        End If
                        Me.RellenarDatosGrid(SivRepuestosID, Me.grdDetalleFacturaTabla.FocusedRowHandle)
                        Me.boolModificado = True
                        Me.grdDetalleFacturaTabla.RefreshData()
                    End If


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

#Region "Factura de Motos"

    Private Sub CargarConsultaExistenciaMoto()
        Dim objConsulta As frmSfaExistencia
        Try
            Try
                objConsulta = New frmSfaExistencia
                'objConsulta.strCodigo = Me.grdDetalleFacturaMoto.Columns("Codigo").Value
                objConsulta.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objConsulta = Nothing
        End Try
    End Sub
    Private Sub CargarDescripcionExtendida()
        Dim objDescripcion As frmSfaAgregarDescripcion
        Try
            Try
                objDescripcion = New frmSfaAgregarDescripcion

                If Not String.IsNullOrEmpty(strMarca) Then
                    objDescripcion.strMarca = Me.strMarca
                End If

                If Not String.IsNullOrEmpty(strModelo) Then
                    objDescripcion.strModelo = Me.strModelo
                End If

                If Not String.IsNullOrEmpty(strMotor) Then
                    objDescripcion.strMotor = Me.strMotor
                End If

                If Not String.IsNullOrEmpty(strColor) Then
                    objDescripcion.strColor = Me.strColor
                End If

                If Not String.IsNullOrEmpty(strAno) Then
                    objDescripcion.strAno = Me.strAno
                End If

                If Not String.IsNullOrEmpty(strChasis) Then
                    objDescripcion.strChasis = Me.strChasis
                End If

                If Not String.IsNullOrEmpty(strCilindraje) Then
                    objDescripcion.strCilindraje = Me.strCilindraje
                End If

                If Not String.IsNullOrEmpty(strCilindros) Then
                    objDescripcion.strCilindros = Me.strCilindros
                End If

                If Not String.IsNullOrEmpty(strTipo) Then
                    objDescripcion.strTipo = Me.strTipo
                End If

                If Not String.IsNullOrEmpty(strCombustible) Then
                    objDescripcion.strCombustible = Me.strCombustible
                End If

                If Not String.IsNullOrEmpty(strVelocidades) Then
                    objDescripcion.strVelocidades = Me.strVelocidades
                End If

                If Not String.IsNullOrEmpty(strPasajeros) Then
                    objDescripcion.strPasajeros = Me.strPasajeros
                End If

                If Not String.IsNullOrEmpty(strPoliza) Then
                    objDescripcion.strPoliza = Me.strPoliza
                End If

                If objDescripcion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.strMarca = objDescripcion.strMarca
                    Me.strModelo = objDescripcion.strModelo
                    Me.strColor = objDescripcion.strColor
                    Me.strAno = objDescripcion.strAno
                    Me.strMotor = objDescripcion.strMotor
                    Me.strChasis = objDescripcion.strChasis
                    Me.strCilindraje = objDescripcion.strCilindraje
                    Me.strCilindros = objDescripcion.strCilindros
                    Me.strTipo = objDescripcion.strTipo
                    Me.strCombustible = objDescripcion.strCombustible
                    Me.strVelocidades = objDescripcion.strVelocidades
                    Me.strPasajeros = objDescripcion.strPasajeros
                    Me.strPoliza = objDescripcion.strPoliza
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objDescripcion = Nothing
        End Try
    End Sub
#End Region

#End Region

#Region "Cargar Datos en el Grid"
    Private Sub CargarDatosGridCodigo()
        Dim dtDatosDetalle As New DataTable
        Dim dtDescuentoDetalle As New DataTable

        'If Me.grdDetalleFactura.Columns("Codigo").Text.Trim.Length <> 0 Then
        '    dtDatosDetalle = SivRepuestos.RetrieveDT("SivRepuestoID =" & Me.grdDetalleFactura.Columns("Codigo").Value, "", "SivRepuestoID, DescripcionCorta,CodigoBarras, Precio, CostoProm")
        '    If dtDatosDetalle.Rows.Count > 0 Then
        '        Me.grdDetalleFactura.Columns("CodigoBarras").Value = dtDatosDetalle.DefaultView.Item(0)("CodigoBarras")
        '        Me.grdDetalleFactura.Columns("Precio").Value = dtDatosDetalle.DefaultView.Item(0)("Precio")
        '        Me.grdDetalleFactura.Columns("CostoProm").Value = dtDatosDetalle.DefaultView.Item(0)("CostoProm")
        '        Me.cmbDescripcionFactura.SelectedValue = dtDatosDetalle.DefaultView.Item(0)("SivRepuestoID")
        '        Me.grdDetalleFactura.Columns("DescripcionCorta").Value = Me.cmbDescripcionFactura.SelectedText
        '        dtDescuentoDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID, fechainicio, fechafin, Descuento", "vwSfaDescuentosFactura", "objRepuestoID = " & Me.grdDetalleFactura.Columns("Codigo").Value & " AND Descuento = (select MAx(Descuento) from vwSfaDescuentosFactura where objRepuestoID = " & Me.grdDetalleFactura.Columns("Codigo").Value & " ) AND fechainicio <= GETDATE() AND fechafin >= GETDATE()"))
        '        If dtDescuentoDetalle.Rows.Count > 0 Then
        '            Me.grdDetalleFactura.Columns("DescuentoPor").Value = dtDescuentoDetalle.DefaultView.Item(0)("Descuento")
        '        Else
        '            Me.grdDetalleFactura.Columns("DescuentoPor").Value = 0.0
        '        End If
        '        Exit Sub
        '    End If
        'End If
    End Sub
    Private Sub CargarDatosGrid()
        Dim dtDatosDetalle As New DataTable
        Dim dtDescuentoDetalle As New DataTable
        Try
            'If (Not String.IsNullOrEmpty(Me.cmbDescripcionFactura.Text)) And (Not (Me.cmbDescripcionFactura.SelectedValue Is Nothing)) Then
            '    dtDatosDetalle = SivRepuestos.RetrieveDT("SivRepuestoID =" & Me.cmbDescripcionFactura.SelectedValue, "", "SivRepuestoID, DescripcionCorta,CodigoBarras, Precio, CostoProm")
            '    If dtDatosDetalle.Rows.Count > 0 Then
            '        Me.grdDetalleFactura.Columns("CodigoBarras").Value = dtDatosDetalle.DefaultView.Item(0)("CodigoBarras")
            '        Me.grdDetalleFactura.Columns("Precio").Value = dtDatosDetalle.DefaultView.Item(0)("Precio")
            '        Me.grdDetalleFactura.Columns("CostoProm").Value = dtDatosDetalle.DefaultView.Item(0)("CostoProm")
            '        Me.grdDetalleFactura.Columns("Codigo").Value = dtDatosDetalle.DefaultView.Item(0)("SivRepuestoID")
            '        dtDescuentoDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID, fechainicio, fechafin, Descuento", "vwSfaDescuentosFactura", "objRepuestoID = " & Me.cmbDescripcionFactura.SelectedValue & " AND Descuento = (select MAx(Descuento) from vwSfaDescuentosFactura where objRepuestoID = " & Me.cmbDescripcionFactura.SelectedValue & ") AND fechainicio <= GETDATE() AND fechafin >= GETDATE()"))
            '        If dtDescuentoDetalle.Rows.Count > 0 Then
            '            Me.grdDetalleFactura.Columns("DescuentoPor").Value = dtDescuentoDetalle.DefaultView.Item(0)("Descuento")
            '        Else
            '            Me.grdDetalleFactura.Columns("DescuentoPor").Value = 0.0
            '        End If
            '        Exit Sub
            '    End If
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Validaciones"
    Private Function VerificarCodigoExiste(ByVal intCodigo As Integer) As Boolean
        Dim intContador As Integer = 0
        'For I As Integer = 0 To Me.grdDetalleFactura.RowCount - 1
        '    'If Me.grdDetalleFactura.Item(I)("Codigo") = intCodigo Then
        '    '    intContador = intContador + 1
        '    'End If
        'Next
        If intContador > 1 Then
            Return False
            Exit Function
        End If
        Return True
    End Function

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

    Private Function GenerarCodigo() As String
        Dim strNumero As String = ""
        Dim strSerie As String = ""
        Dim dtMaximoNumero As New DataTable
        Dim dtTiendaMaximo As New DataTable
        Try
            Try
                dtMaximoNumero = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("MAX(Numero)+ 1 as NumeroMaximo", "SfaFacturaRepuesto", "objTiendaID = " & Me.cmbBodega.SelectedValue.ToString))
                If dtMaximoNumero.DefaultView.Item(0)("NumeroMaximo").ToString.Trim.Length = 0 Then
                    dtTiendaMaximo = StbTienda.RetrieveDT("StbTiendaID =" & Me.cmbBodega.SelectedValue, "", "ProximaFactura,Seriefactura")
                    strSerie = dtTiendaMaximo.DefaultView.Item(0)("Seriefactura")
                    strNumero = RellenarConCeros(dtTiendaMaximo.DefaultView.Item(0)("ProximaFactura"), 4)
                Else
                    strSerie = StbTienda.RetrieveDT("StbTiendaID = " & Me.cmbBodega.SelectedValue, "", "Seriefactura").DefaultView.Item(0)("Seriefactura")
                    strNumero = RellenarConCeros(dtMaximoNumero.DefaultView.Item(0)("NumeroMaximo"), 4)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtMaximoNumero = Nothing
            dtTiendaMaximo = Nothing
        End Try

        Return strSerie.Trim + strNumero.Trim

    End Function
    Private Function GenerarNumero() As String
        Dim strNumero As String = ""
        Dim dtMaximoNumero As New DataTable
        Dim dtTiendaMaximo As New DataTable
        Try
            Try
                dtMaximoNumero = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("MAX(Numero) + 1 as NumeroMaximo", "SfaFacturaRepuesto", "objTiendaID = " & Me.cmbBodega.SelectedValue.ToString))
                If dtMaximoNumero.DefaultView.Item(0)("NumeroMaximo").ToString.Trim.Length = 0 Then
                    dtTiendaMaximo = StbTienda.RetrieveDT("StbTiendaID =" & Me.cmbBodega.SelectedValue, "", "ProximaFactura,Seriefactura")
                    strNumero = RellenarConCeros(dtTiendaMaximo.DefaultView.Item(0)("ProximaFactura"), 4)
                Else
                    strNumero = RellenarConCeros(dtMaximoNumero.DefaultView.Item(0)("NumeroMaximo"), 4)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtMaximoNumero = Nothing
            dtTiendaMaximo = Nothing
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

        If Not Me.chkAgregarMoto.Checked Then
            'If Me.grdDetalleFactura.RowCount = 0 Then
            '    MsgBox("Debe especificar al menos un detalle en la factura.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            '    Return False
            '    Exit Function
            'End If
        Else
            'If Me.grdDetalleFacturaMoto.RowCount = 0 Then
            '    MsgBox("Debe especificar al menos un detalle en la factura.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            '    Return False
            '    Exit Function
            'End If
        End If

        If Not Me.chkAgregarMoto.Checked Then
            If Me.ExistenCantidadesEnCero Then
                Me.ErrorFactura.SetError(Me.grpDetalle, "Hay al menos un valor de cantidad en CERO.")
                Exit Function
            End If

        Else
            If Me.ExistenCantidadesEnCeroMoto Then
                Me.ErrorFactura.SetError(Me.grpDetalle, "Hay al menos un valor de cantidad en CERO.")
                Return False
                Exit Function
            End If
        End If
        Return True
    End Function


    Private Function UltimaFilaGridRepuesto() As Boolean
        'Return Me.grdDetalleFactura.Row = Me.grdDetalleFactura.Splits(0).Rows.Count - 1
    End Function

    Private Function DescuentoValido() As Boolean
        Dim blnValido As Boolean = True
        If Not UltimaFilaGridRepuesto() Then
            'If (IsDBNull(Me.grdDetalleFactura.Columns("Cantidad").Value)) And Me.grdDetalleFactura.Columns("Cantidad").Value.ToString.Trim.Length = 0 Then
            '    blnValido = False
            '    Exit Function
            'End If
            'If (Me.grdDetalleFactura.Columns("Cantidad").Value <= 0) Then
            '    Me.ErrorFactura.SetError(Me.grpDetalle, "Debe escribir un valor de la cantidad mayor que cero.")
            '    blnValido = False
            '    Exit Function
            'End If
        End If
        Return blnValido
    End Function


#End Region

#Region "Eventos del Formulario"

#Region "Formulario"
    Private Sub frmSfaFacturaRepuestosEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cmbDescripcionFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarDatosGrid()
    End Sub

    Private Sub chkAgregarMoto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgregarMoto.CheckedChanged

        If Me.chkAgregarMoto.Checked Then
            Me.numPrima.Enabled = True
            Me.numSaldo.Enabled = True
            Me.chkSolicitudDescuento.Checked = False
            Me.chkSolicitudDescuento.Enabled = False
            Me.grdDetalleFactura.Visible = False
            Me.grdDetalleMoto.Visible = True
            Me.grdDetalleMoto.Dock = DockStyle.Fill

            If Not (Me.dtDetalleFactura Is Nothing) Then
                Me.dtDetalleFactura.Rows.Clear()
            End If

            If Me.TypeGUI = 1 Then
                Me.CalcularTotalesMoto()
            End If

        Else
            Me.numPrima.Enabled = False
            Me.numSaldo.Enabled = False
            Me.chkSolicitudDescuento.Enabled = True
            Me.grdDetalleFactura.Visible = True
            Me.grdDetalleMoto.Visible = False

            If Not (Me.dtDetalleFacturaMoto Is Nothing) Then
                Me.dtDetalleFacturaMoto.Rows.Clear()
            End If

            If Me.TypeGUI = 1 Then
                Me.CalcularTotales()
            End If

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

    Private Sub txtObervaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObervaciones.KeyPress
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
                objBusquedaCliente.Filtro = "Descripcion = 'Cliente'" 'AND StbPersonaID NOT IN (SELECT objFiadorID FROM vwSccCuentaFiador WHERE Estado = 'VIGENTE') "
                If objBusquedaCliente.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    objPersonaID = objBusquedaCliente.Seleccion
                    Me.CargarClientes()
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
        Me.Procesar(t)

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.ValidarEntradaDatos Then
            Select Case Me.TypeGUI
                Case 1, 6
                    Me.AgregarFactura()
                Case 3
                    Me.AutorizarDescuento()
                Case 5
                    Select Case MsgBox("¿Seguro que desea anular la factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            Me.Anular()
                    End Select
            End Select
        End If
    End Sub

#End Region

#End Region

#Region "Guardar"

#Region "Agregar Factura"

    Private Sub AgregarFactura()
        Dim t As New TransactionManager
        Try
            t.BeginTran()
            Me.GuardarFactura(t)
            Me.GuardarDetallefactura(t)
            t.CommitTran()
            boolRegistrada = True
            Me.boolModificado = False
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            If Not Me.chkSolicitudDescuento.Checked Then
                Me.cmdProcesar.Enabled = True
                Me.cmdAceptar.Enabled = False
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar Factura"

    Private Sub GuardarFactura(ByVal t As TransactionManager)
        Dim objSfaFactura As SfaFacturaRepuesto
        Try
            objSfaFactura = New SfaFacturaRepuesto

            objSfaFactura.Fecha = Me.dtpFecha.Value
            objSfaFactura.objTiendaID = Me.cmbBodega.SelectedValue

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
            objSfaFactura.FacturaMoto = Me.chkAgregarMoto.Checked

            If Me.chkAgregarMoto.Checked Then
                objSfaFactura.Prima = Me.numPrima.Value
                objSfaFactura.Saldo = Me.numSaldo.Value
            End If

            If Me.txtObervaciones.Text.Trim.Length <> 0 Then
                objSfaFactura.observaciones = Me.txtObervaciones.Text
            End If

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
#End Region

#Region "ObtenerDescripcionMoto"

    Private Function ObtenerDescripcionMoto() As String
        Dim strDescripcionMoto As String = ""

        If Not String.IsNullOrEmpty(Me.strMarca) Then
            strDescripcionMoto = strDescripcionMoto & "MA = " & Me.strMarca & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strModelo) Then
            strDescripcionMoto = strDescripcionMoto & "MO = " & Me.strModelo & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strColor) Then
            strDescripcionMoto = strDescripcionMoto & "CO = " & Me.strColor & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strAno) Then
            strDescripcionMoto = strDescripcionMoto & "A = " & Me.strAno & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strMotor) Then
            strDescripcionMoto = strDescripcionMoto & "MT = " & Me.strMotor & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strChasis) Then
            strDescripcionMoto = strDescripcionMoto & "CH = " & Me.strChasis & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strCilindraje) Then
            strDescripcionMoto = strDescripcionMoto & "CI = " & Me.strCilindraje & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strCilindros) Then
            strDescripcionMoto = strDescripcionMoto & "CL = " & Me.strCilindros & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strTipo) Then
            strDescripcionMoto = strDescripcionMoto & "T = " & Me.strTipo & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strCombustible) Then
            strDescripcionMoto = strDescripcionMoto & "C = " & Me.strCombustible & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strVelocidades) Then
            strDescripcionMoto = strDescripcionMoto & "V = " & Me.strVelocidades & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strPasajeros) Then
            strDescripcionMoto = strDescripcionMoto & "P = " & Me.strPasajeros & ";"
        End If

        If Not String.IsNullOrEmpty(Me.strPoliza) Then
            strDescripcionMoto = strDescripcionMoto & "PO = " & Me.strPoliza & ""
        End If
        Return strDescripcionMoto

    End Function

#End Region

#Region "GuardarDetallefactura"

    Private Sub GuardarDetallefactura(ByVal T As TransactionManager)
        Dim objSfaFacturaDetalle As SfaFacturaRepuestoDetalle
        Dim dtDetalleFact As New DataTable
        Dim fila As DataRow

        Try
            objSfaFacturaDetalle = New SfaFacturaRepuestoDetalle

            If Me.chkAgregarMoto.Checked Then
                dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

                'Isertar detalle de Factura              
                Me.dtDetalleFacturaMoto.AcceptChanges()
                For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
                    fila = dtDetalleFact.NewRow
                    fila("objFacturaRepuestoID") = Me.SfaFacturaID
                    fila("objRepuestoID") = row("Codigo")
                    fila("DescripcionMoto") = Me.ObtenerDescripcionMoto
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

            Else
                dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

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
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Procesar"

    Private Sub Procesar(ByVal T As TransactionManager)
        Dim objSfaFactura As New SfaFacturaRepuesto
        Dim objSfaFacturaDetalle As New SfaFacturaRepuestoDetalle
        Dim objSivBodegaRpuestos As New SivBodegaRepuestos
        Dim dtDetalleFact As New DataTable
        Dim fila As DataRow
        Try
            Try
                T.BeginTran()
                '---Actualizar el maestro de la factura
                objSfaFactura.Retrieve(Me.SfaFacturaID)
                objSfaFactura.serie = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo", "StbTienda", "StbTiendaID = " & Me.cmbBodega.SelectedValue)).DefaultView.Item(0)("Codigo").ToString.Trim
                objSfaFactura.Numero = Me.GenerarNumero
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

                If Me.chkAgregarMoto.Checked Then
                    dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

                    'Isertar detalle de Factura              

                    For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
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
                    For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
                        objSivBodegaRpuestos.RetrieveByFilter("objTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = " & row("Codigo"))
                        objSivBodegaRpuestos.Cantidad = objSivBodegaRpuestos.Cantidad - row("Cantidad")
                        objSivBodegaRpuestos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objSivBodegaRpuestos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objSivBodegaRpuestos.Update()
                    Next
                Else
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
                End If

                T.CommitTran()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Me.Imprimir()
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

#Region "Inicializar para Descripcion De Moto"

    Private Sub InicializarMarca(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "MARCA: " & Me.strMarca
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub
    Private Sub InicializarModelo(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "MODELO: " & Me.strModelo
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarColor(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "COLOR: " & Me.strColor
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarAno(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "AÑO :" & Me.strAno
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarMotor(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "MOTOR: " & Me.strMotor
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub
    Private Sub InicializarChasis(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "CHASIS: " & Me.strChasis
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarCilindraje(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "CILINDRAJE: " & Me.strCilindraje
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarCilindro(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "CILINDROS: " & Me.strCilindros
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarTipo(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "TIPO: " & Me.strTipo
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarCombustible(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "COMBUSTIBLE: " & Me.strCombustible
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarVelocidades(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "VELOCIDADES: " & Me.strVelocidades
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarPasajeros(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "PASAJEROS: " & Me.strPasajeros
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

    Private Sub InicializarPoliza(ByRef fila As DataRow)

        fila("Vendedor") = String.Empty
        fila("Cliente") = String.Empty
        fila("Estado") = String.Empty
        fila("SfaFacturaRepuestoID") = 0
        fila("Numero") = 0
        fila("Fecha") = clsProyecto.Conexion.FechaServidor
        fila("Contado") = 0
        fila("Credito") = 0
        fila("Precio") = 0
        fila("Cantidad") = 0
        fila("objRepuestoID") = 0
        fila("Subtotal") = 0
        fila("Descripcion") = String.Empty
        fila("DescripcionMoto") = "POLIZA No: " & Me.strPoliza
        fila("SubTotalMaestro") = 0
        fila("DescuentoMaestro") = 0
        fila("ImpuestoMaestro") = 0
        fila("TotalDolares") = 0
        fila("TotalCordobas") = 0
        fila("TasaCambio") = 0
        fila("Subtotal") = 0
        fila("Prima") = 0
        fila("Saldo") = 0
        fila("observaciones") = String.Empty
        fila("objEstadoID") = 0
        fila("SerieNumero") = String.Empty
        fila("DGI") = String.Empty
        fila("objFacturaRepuestoID") = 0
        fila("Dia") = 0
        fila("Mes") = 0
        fila("Ano") = 0
    End Sub

#End Region

#Region "Imprimir Factura"

    Private Sub Imprimir()
        Dim visor As New frmVisorRS
        Dim sFiltro, sCampos, sSQL As String
        Dim dtDatos As DataTable
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim dblSubTotal, dblSubTotalVentas, dblTotalDolares, dblPrima, dblSaldo, dblTotalCordobas, dblTasa, dblImpuesto, dblDescuento As Double
        Dim strObservaciones, strEslogan, strCedula As String
        Dim FilaModelo, filaMarca, FilaColor, FilaAno, FilaMotor, FilaChasis As DataRow
        Dim FilaCilindraje, FilaCilindro, FilaTipo, FilaCombustible, FilaVelocidades As DataRow
        Dim FilaPasajeros, FilaPoliza, FilaCasco As DataRow

        strObservaciones = ""
        strCedula = ""
        strEslogan = ""
        sFiltro = "SfaFacturaRepuestoID = " & Me.SfaFacturaID
        sCampos = "Vendedor, Cliente, Estado,CAST('' AS VARCHAR(50)) AS DescripcionMoto, SfaFacturaRepuestoID, Numero,SubTotalVentas, Fecha, Contado, Credito, Precio, Cantidad, objRepuestoID, Subtotal, Descripcion, SubTotalMaestro, DescuentoMaestro, ImpuestoMaestro, TotalDolares, TotalCordobas, TasaCambio, Prima, Saldo, observaciones, objEstadoID, SerieNumero, DGI, objFacturaRepuestoID, Dia, Mes, Ano,Eslogan, Cedula, Direccion"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptSfaFacturaRepuesto", sFiltro)
        dtDatos = DAL.SqlHelper.ExecuteQueryDT(sSQL)

        dblSubTotal = dtDatos.DefaultView.Item(0)("SubTotalMaestro")
        dblTotalDolares = dtDatos.DefaultView.Item(0)("TotalDolares")

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Prima")) Then
            dblPrima = dtDatos.DefaultView.Item(0)("Prima")
        End If

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Saldo")) Then
            dblSaldo = dtDatos.DefaultView.Item(0)("Saldo")
        End If

        dblTotalCordobas = dtDatos.DefaultView.Item(0)("TotalCordobas")
        dblTasa = dtDatos.DefaultView.Item(0)("TasaCambio")
        dblImpuesto = dtDatos.DefaultView.Item(0)("ImpuestoMaestro")
        dblDescuento = dtDatos.DefaultView.Item(0)("DescuentoMaestro")

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("observaciones")) Then
            strObservaciones = dtDatos.DefaultView.Item(0)("observaciones")
        End If

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Eslogan")) Then
            strEslogan = dtDatos.DefaultView.Item(0)("Eslogan")
        End If

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("Cedula")) Then
            strCedula = dtDatos.DefaultView.Item(0)("Cedula")
        End If

        If Not IsDBNull(dtDatos.DefaultView.Item(0)("SubTotalVentas")) Then
            dblSubTotalVentas = dtDatos.DefaultView.Item(0)("SubTotalVentas")
        End If

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TotalVenta", dblSubTotal, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TotalDolares", dblTotalDolares, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Prima", dblPrima, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Saldo", dblSaldo, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TotalCordobas", dblTotalCordobas, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TasaCambio", dblTasa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Impuesto", dblImpuesto, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Descuento", dblDescuento, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Observaciones", strObservaciones, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Eslogan", strEslogan, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("Cedula", strCedula, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("SubTotalVenta", dblSubTotalVentas, False))

        If Me.chkAgregarMoto.Checked Then

            FilaModelo = dtDatos.NewRow
            filaMarca = dtDatos.NewRow
            FilaColor = dtDatos.NewRow
            FilaAno = dtDatos.NewRow
            FilaMotor = dtDatos.NewRow
            FilaChasis = dtDatos.NewRow
            FilaCilindraje = dtDatos.NewRow
            FilaCilindro = dtDatos.NewRow
            FilaTipo = dtDatos.NewRow
            FilaCombustible = dtDatos.NewRow
            FilaVelocidades = dtDatos.NewRow
            FilaPasajeros = dtDatos.NewRow
            FilaPoliza = dtDatos.NewRow
            FilaCasco = dtDatos.NewRow

            Me.InicializarModelo(FilaModelo)
            dtDatos.Rows.Add(FilaModelo)

            Me.InicializarMarca(filaMarca)
            dtDatos.Rows.Add(filaMarca)

            Me.InicializarColor(FilaColor)
            dtDatos.Rows.Add(FilaColor)

            Me.InicializarAno(FilaAno)
            dtDatos.Rows.Add(FilaAno)

            Me.InicializarMotor(FilaMotor)
            dtDatos.Rows.Add(FilaMotor)

            Me.InicializarChasis(FilaChasis)
            dtDatos.Rows.Add(FilaChasis)

            Me.InicializarCilindraje(FilaCilindraje)
            dtDatos.Rows.Add(FilaCilindraje)

            Me.InicializarCilindro(FilaCilindro)
            dtDatos.Rows.Add(FilaCilindro)

            Me.InicializarTipo(FilaTipo)
            dtDatos.Rows.Add(FilaTipo)

            Me.InicializarCombustible(FilaCombustible)
            dtDatos.Rows.Add(FilaCombustible)

            Me.InicializarVelocidades(FilaVelocidades)
            dtDatos.Rows.Add(FilaVelocidades)

            Me.InicializarPasajeros(FilaPasajeros)
            dtDatos.Rows.Add(FilaPasajeros)

            Me.InicializarPoliza(FilaPoliza)
            dtDatos.Rows.Add(FilaPoliza)

            With visor.VisorReportes
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = "SCCUM.rptSfaFacturaMoto.rdlc"
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtRptFacturaRepuestos_vwRptSfaFacturaRepuesto", dtDatos))
                .LocalReport.SetParameters(parametros)
                .RefreshReport()
            End With
        Else
            With visor.VisorReportes
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportEmbeddedResource = "SCCUM.rptSfaFacturaRepuesto.rdlc"
                .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dtRptFacturaRepuestos_vwRptSfaFacturaRepuesto", dtDatos))
                .LocalReport.SetParameters(parametros)
                .RefreshReport()
            End With
        End If
        visor.ShowDialog()
    End Sub

#End Region

#Region "Anular"

    Private Sub Anular()
        Dim objSfaFactura As New SfaFacturaRepuesto
        Dim objSfaFacturaDetalle As New SfaFacturaRepuestoDetalle
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

                    '---Actualizar el detalle de la factura
                    SfaFacturaRepuestoDetalle.DeleteByFilter("objFacturaRepuestoID = " & Me.SfaFacturaID)

                    If Not Me.chkAgregarMoto.Checked Then

                        '---Actualizar el detalle de la factura
                        dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

                        'Isertar detalle de Factura            

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
                            objSivBodegaRpuestos.RetrieveByFilter("objTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = " & row("Codigo"))
                            objSivBodegaRpuestos.Cantidad = objSivBodegaRpuestos.Cantidad + row("Cantidad")
                            objSivBodegaRpuestos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objSivBodegaRpuestos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objSivBodegaRpuestos.Update()
                        Next
                    Else
                        '---Actualizar el detalle de la factura
                        dtDetalleFact = SfaFacturaRepuestoDetalle.RetrieveDT("1=0")

                        'Isertar detalle de Factura           

                        For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
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
                        For Each row As DataRow In Me.dtDetalleFacturaMoto.Rows
                            objSivBodegaRpuestos.RetrieveByFilter("objTiendaID = " & Me.cmbBodega.SelectedValue & " AND objRepuestoID = '" & row("Codigo") & "'")
                            objSivBodegaRpuestos.Cantidad = objSivBodegaRpuestos.Cantidad + row("Cantidad")
                            objSivBodegaRpuestos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objSivBodegaRpuestos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objSivBodegaRpuestos.Update()
                        Next
                    End If
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

#Region "Procedimientos para grid cuando es una factura de Moto o garantia"

#Region "Propiedades"
    Property strMarca() As String
        Get
            Return m_strmarca
        End Get
        Set(ByVal value As String)
            m_strmarca = value
        End Set
    End Property

    Property strModelo() As String
        Get
            Return m_strmodelo
        End Get
        Set(ByVal value As String)
            m_strmodelo = value
        End Set
    End Property

    Property strColor() As String
        Get
            Return m_strcolor
        End Get
        Set(ByVal value As String)
            m_strcolor = value
        End Set
    End Property

    Property strChasis() As String
        Get
            Return m_strchasis
        End Get
        Set(ByVal value As String)
            m_strchasis = value
        End Set
    End Property

    Property strAno() As String
        Get
            Return m_strano
        End Get
        Set(ByVal value As String)
            m_strano = value
        End Set
    End Property

    Property strMotor() As String
        Get
            Return m_strmotor
        End Get
        Set(ByVal value As String)
            m_strmotor = value
        End Set
    End Property

    Property strCilindraje() As String
        Get
            Return m_strcilindraje
        End Get
        Set(ByVal value As String)
            m_strcilindraje = value
        End Set
    End Property

    Property strCilindros() As String
        Get
            Return m_strcilindros
        End Get
        Set(ByVal value As String)
            m_strcilindros = value
        End Set
    End Property

    Property strTipo() As String
        Get
            Return m_strtipo
        End Get
        Set(ByVal value As String)
            m_strtipo = value
        End Set
    End Property

    Property strCombustible() As String
        Get
            Return m_strcombustible
        End Get
        Set(ByVal value As String)
            m_strcombustible = value
        End Set
    End Property

    Property strVelocidades() As String
        Get
            Return m_strvelocidades
        End Get
        Set(ByVal value As String)
            m_strvelocidades = value
        End Set
    End Property

    Property strPasajeros() As String
        Get
            Return m_strpasajeros
        End Get
        Set(ByVal value As String)
            m_strpasajeros = value
        End Set
    End Property

    Property strPoliza() As String
        Get
            Return m_strpoliza
        End Get
        Set(ByVal value As String)
            m_strpoliza = value
        End Set
    End Property
#End Region

#Region "Cargar Grid"

    Private Sub CargarDetalleFacturaMoto(ByVal strFiltro As String)
        dtDetalleFacturaMoto = New DataTable
        Try
            dtDetalleFacturaMoto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoBarras,objFacturaRepuestoID, Codigo, DescripcionCorta, Cantidad, CostoProm,Precio,cast(0 as float) as DescuentoPor, Descuento, Subtotal, Impuesto, Total", "vwSfaDetalleRepuestos", strFiltro))
            Me.grdDetalleMoto.DataSource = dtDetalleFacturaMoto
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Datos en el Grid"
    Private Sub CargarDatosGridCodigoMoto()
        Dim dtDatosDetalle As New DataTable
        Dim dtDescuentoDetalle As New DataTable

        'If Me.grdDetalleFacturaMoto.Columns("Codigo").Text.Trim.Length <> 0 Then
        '    dtDatosDetalle = SivRepuestos.RetrieveDT("SivRepuestoID =" & Me.grdDetalleFacturaMoto.Columns("Codigo").Value, "", "SivRepuestoID, DescripcionCorta,CodigoBarras, Precio, CostoProm")
        '    If dtDatosDetalle.Rows.Count > 0 Then
        '        Me.grdDetalleFacturaMoto.Columns("CodigoBarras").Value = dtDatosDetalle.DefaultView.Item(0)("CodigoBarras")
        '        Me.grdDetalleFacturaMoto.Columns("Precio").Value = dtDatosDetalle.DefaultView.Item(0)("Precio")
        '        Me.grdDetalleFacturaMoto.Columns("CostoProm").Value = dtDatosDetalle.DefaultView.Item(0)("CostoProm")
        '        Me.cmbDescripcionMoto.SelectedValue = dtDatosDetalle.DefaultView.Item(0)("SivRepuestoID")
        '        Me.grdDetalleFacturaMoto.Columns("DescripcionCorta").Value = Me.cmbDescripcionMoto.SelectedText
        '        dtDescuentoDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID, fechainicio, fechafin, Descuento", "vwSfaDescuentosFactura", "objRepuestoID = " & Me.grdDetalleFacturaMoto.Columns("Codigo").Value & " AND Descuento = (select MAx(Descuento) from vwSfaDescuentosFactura where objRepuestoID = " & Me.grdDetalleFacturaMoto.Columns("Codigo").Value & " ) AND fechainicio <= GETDATE() AND fechafin >= GETDATE()"))
        '        If dtDescuentoDetalle.Rows.Count > 0 Then
        '            Me.grdDetalleFacturaMoto.Columns("DescuentoPor").Value = dtDescuentoDetalle.DefaultView.Item(0)("Descuento")
        '        Else
        '            Me.grdDetalleFacturaMoto.Columns("DescuentoPor").Value = 0.0
        '        End If
        '        Exit Sub
        '    End If
        'End If
    End Sub
    Private Sub CargarDatosGridMoto()
        Dim dtDatosDetalle As New DataTable
        Dim dtDescuentoDetalle As New DataTable
        Try
            'If Me.cmbDescripcionMoto.Text.Length <> 0 Then
            '    dtDatosDetalle = SivRepuestos.RetrieveDT("SivRepuestoID =" & Me.cmbDescripcionMoto.SelectedValue, "", "SivRepuestoID, DescripcionCorta,CodigoBarras, Precio, CostoProm")
            '    If dtDatosDetalle.Rows.Count > 0 Then
            '        Me.grdDetalleFacturaMoto.Columns("CodigoBarras").Value = dtDatosDetalle.DefaultView.Item(0)("CodigoBarras")
            '        Me.grdDetalleFacturaMoto.Columns("Precio").Value = dtDatosDetalle.DefaultView.Item(0)("Precio")
            '        Me.grdDetalleFacturaMoto.Columns("CostoProm").Value = dtDatosDetalle.DefaultView.Item(0)("CostoProm")
            '        Me.grdDetalleFacturaMoto.Columns("Codigo").Value = dtDatosDetalle.DefaultView.Item(0)("SivRepuestoID")
            '        dtDescuentoDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objRepuestoID, fechainicio, fechafin, Descuento", "vwSfaDescuentosFactura", "objRepuestoID = " & Me.cmbDescripcionMoto.SelectedValue & " AND Descuento = (select MAx(Descuento) from vwSfaDescuentosFactura where objRepuestoID = " & Me.cmbDescripcionMoto.SelectedValue & ") AND fechainicio <= GETDATE() AND fechafin >= GETDATE()"))
            '        If dtDescuentoDetalle.Rows.Count > 0 Then
            '            Me.grdDetalleFacturaMoto.Columns("DescuentoPor").Value = dtDescuentoDetalle.DefaultView.Item(0)("Descuento")
            '        Else
            '            Me.grdDetalleFacturaMoto.Columns("DescuentoPor").Value = 0.0
            '        End If
            '        Exit Sub
            '    End If
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Borrar Propiedades"
    Private Sub BorrarPropiedades()

        Me.m_strmarca = ""
        Me.m_strmodelo = ""
        Me.m_strcolor = ""
        Me.m_strano = ""
        Me.m_strmotor = ""
        Me.m_strchasis = ""
        Me.m_strcilindraje = ""
        Me.m_strcilindros = ""
        Me.m_strtipo = ""
        Me.m_strcombustible = ""
        Me.m_strvelocidades = ""
        Me.m_strpasajeros = ""
        Me.m_strpoliza = ""

    End Sub
#End Region

#Region "Eventos"

    Private Function ExistenCantidadesEnCeroMoto() As Boolean
        Try
            Return Me.dtDetalleFacturaMoto.Select("Cantidad = 0").Length <> 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Sub numPrima_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numPrima.TextChanged
        Me.ErrorFactura.SetError(Me.numPrima, "")
    End Sub

    Private Sub numSaldo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numSaldo.TextChanged
        Me.ErrorFactura.SetError(Me.numSaldo, "")
    End Sub

    'Private Sub numDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDescuento.ValueChanged

    '    If Not Me.chkAutorizar.Checked Then
    '        If Me.numDescuento.Value <> 0.0 Then
    '            If numDescuento.Value < Me.numSubTotal.Value Then
    '                If Me.chkAgregarMoto.Checked Then
    '                    Me.RecalcularDescuentoMoto()
    '                Else
    '                    RecalcularDescuento()
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub numDescuento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    '    If Asc(e.KeyChar) = 13 Then
    '        Me.chkAutorizar.Focus()
    '    End If
    'End Sub

#End Region

#End Region

#Region "RellenarDatosGrid"
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

        If objSivRepuestos.SivRepuestoID = "3" Then 'Servicio de instalación
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
    End Sub

#End Region

#Region "Eventos del Grid de Repuestos"

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

                If IdRepuestoSeleccionado() = "3" Then
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

        'Si se preciona TAB estando en la última Celda editable
        If e.KeyCode = Keys.Tab AndAlso Me.grdDetalleFacturaTabla.FocusedColumn.Equals(Me.colPorcentajeDescuento) Then
            Me.txtObervaciones.Focus()
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
        CalcularTotales()
    End Sub

    Private Sub grdDetalleFactura_EditorKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleFactura.EditorKeyDown
        'Borra en modo de edición del grid, para ello se debe presionar la tecla control + delete
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            Me.EliminarFila()
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
        If e.Column.Equals(Me.colBarCode) Then
            'Verificando si el código de barras existe
            If Me.dtDetalleFactura.DefaultView.Item(FilaActual)("CodigoBarras").ToString.Trim.Length > 0 Then
                CodigoRepuesto = ClsCatalogos.GetCodigoRepuestoByCodigoBarras(Me.dtDetalleFactura.DefaultView.Item(FilaActual)("CodigoBarras").ToString.Trim)
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
                        Me.grdDetalleFacturaTabla.FocusedColumn = Me.colCodigoRepuesto
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
                blnVerificaRepuestoAct = objRepuestos.RetrieveByFilter("SivRepuestoID='" & objRepuestos.SivRepuestoID & " 'AND Activo=0")
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

#Region "Eventos del Grid de Motos"

#Region "Botones en el grid"

    Private Sub grdMotoSpnDescripcion_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles grdMotoSpnDescripcion.ButtonClick
        If e.Button.Index = 1 Then
            Me.CargarDescripcionExtendida()
        End If
    End Sub
#End Region

#Region "CellValueChanged, CellValueChanging"

    Private Sub grdDetalleMototabla_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetalleMototabla.CellValueChanged
        Dim FilaActual As Integer
        Dim strIndiceCombo As String
        Dim blnVerificaBarCode, blnVerificaRepuestoAct, blnVerificaCodRepuesto, blnVerificarExistencia As Boolean
        Dim objRepuestos As SivRepuestos
        Dim objBodegaRepuesto As SivBodegaRepuestos

        FilaActual = Me.grdDetalleMototabla.FocusedRowHandle
        objRepuestos = New SivRepuestos
        objBodegaRepuesto = New SivBodegaRepuestos

        'Codigo de Barras
        If e.Column.Equals(Me.colCodigoBar) Then
            'Verifica si el código de barras existe (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
            blnVerificaBarCode = objRepuestos.RetrieveByFilter("CodigoBarras=" & "'" & (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("CodigoBarras")) & "'")
            If (blnVerificaBarCode = False) AndAlso (Not IsDBNull(Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("CodigoBarras"))) Then
                MsgBox("El código de barras no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ElminarFilaSinPreguntarMoto()
                Me.InsertarNuevaFilaGridMoto()
                Exit Sub
            End If

            'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
            blnVerificaRepuestoAct = objRepuestos.RetrieveByFilter("SivRepuestoID=" & "'" & objRepuestos.SivRepuestoID & "'" & " AND Activo=0")
            If (blnVerificaRepuestoAct = True) Then
                MsgBox("El repuesto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ElminarFilaSinPreguntarMoto()
                Me.InsertarNuevaFilaGridMoto()
                Me.grdDetalleMototabla.FocusedColumn = Me.colCodigo
                Exit Sub
            End If

            'Verifica que el repuesto este en existencia
            blnVerificarExistencia = objBodegaRepuesto.RetrieveByFilter("objRepuestoID = " & "'" & objRepuestos.SivRepuestoID & "'" & " AND objTiendaID = " & Me.cmbBodega.SelectedValue & " AND Cantidad <> 0")
            If Not blnVerificarExistencia Then
                MsgBox("El repuesto no tiene existencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ElminarFilaSinPreguntarMoto()
                Me.InsertarNuevaFilaGridMoto()
                Me.grdDetalleMototabla.FocusedColumn = Me.colCodigo
                Exit Sub
            End If

            'Si todo está bien se rellenan los datos
            blnVerificaBarCode = objRepuestos.RetrieveByFilter("CodigoBarras=" & "'" & (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("CodigoBarras")) & "'")
            If (blnVerificaBarCode = True) Then
                RellenarDatosGridMoto(objRepuestos.SivRepuestoID.ToString, FilaActual)
            End If
        End If

        'CodigoRepuesto
        If e.Column.Equals(Me.colCodigo) Then
            If Me.dtDetalleFacturaMoto.DefaultView.Count <> 0 Then
                'Verifica si el código del repuesto existe
                blnVerificaCodRepuesto = objRepuestos.RetrieveByFilter("SivRepuestoID='" & (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Codigo")) & "' AND SivRepuestoID IN ('1','2')")
                If (blnVerificaCodRepuesto = False) Then
                    MsgBox("El código de repuesto no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntarMoto()
                    Me.InsertarNuevaFilaGridMoto()
                    Exit Sub
                End If

                'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
                blnVerificaRepuestoAct = objRepuestos.RetrieveByFilter("SivRepuestoID='" & objRepuestos.SivRepuestoID & "' AND Activo=0")
                If (blnVerificaRepuestoAct = True) Then
                    MsgBox("El repuesto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntarMoto()
                    Me.InsertarNuevaFilaGridMoto()
                    Exit Sub
                End If

                'Verifica que el repuesto este en existencia
                blnVerificarExistencia = objBodegaRepuesto.RetrieveByFilter("objRepuestoID = " & "'" & objRepuestos.SivRepuestoID & "'" & " AND objTiendaID = " & Me.cmbBodega.SelectedValue & " AND Cantidad <> 0")
                If Not blnVerificarExistencia Then
                    MsgBox("El repuesto no tiene existencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntarMoto()
                    Me.InsertarNuevaFilaGridMoto()
                    Me.grdDetalleMototabla.FocusedColumn = Me.colCodigo
                    Exit Sub
                End If

                'Si todo está bien se rellenan los datos
                RellenarDatosGridMoto(Me.grdDetalleMototabla.EditingValue, FilaActual)
            End If
        End If

        'Descripción
        If e.Column.Equals(Me.colDescripcionMoto) Then

            'Verifica que el repuesto este en existencia
            blnVerificarExistencia = objBodegaRepuesto.RetrieveByFilter("objRepuestoID = " & "'" & Me.grdDetalleMototabla.EditingValue & "'" & " AND objTiendaID = " & Me.cmbBodega.SelectedValue & " AND Cantidad <> 0")
            If Not blnVerificarExistencia Then
                MsgBox("El repuesto no tiene existencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.ElminarFilaSinPreguntarMoto()
                Me.InsertarNuevaFilaGridMoto()
                Me.grdDetalleMototabla.FocusedColumn = Me.colCodigo
                Exit Sub
            End If

            strIndiceCombo = grdDetalleMototabla.ActiveEditor.EditValue.ToString
            RellenarDatosGridMoto(strIndiceCombo, FilaActual)
        End If

        'Validacion del repetido
        If e.Column.Equals(Me.colCodigoBar) Or e.Column.Equals(Me.colCodigo) Or e.Column.Equals(Me.colDescripcionMoto) Then
            If Me.BuscarDuplicados(Me.grdDetalleFacturaTabla.EditingValue, Me.colCodigoRepuesto.FieldName) Or Me.BuscarDuplicados(Me.grdDetalleMototabla.EditingValue, Me.colCodigoBar.FieldName) Then
                MsgBox("Este valor ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Sistema")
                Me.ElminarFilaSinPreguntarMoto()
                Me.InsertarNuevaFilaGridMoto()
            End If
        End If

        'Cantidad
        If e.Column.Equals(Me.ColCantidadMoto) Or e.Column.Equals(Me.colPorcentajeMoto) Then

            'Valida si primero se digitó la cantidad
            If (IsDBNull(dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Codigo"))) Then
                Me.ElminarFilaSinPreguntarMoto()
                Me.InsertarNuevaFilaGridMoto()
                Exit Sub
            End If

            'Realizar cálculos en grid
            If Me.dtDetalleFacturaMoto.Rows.Count <> 0 Then
                If IsDBNull(Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Precio")) Then
                    Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Precio") = 0
                End If

                Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Subtotal") = (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Cantidad")) * (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Precio"))

                If IsDBNull(Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("DescuentoPor")) Then
                    Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("DescuentoPor") = 0
                End If

                Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Descuento") = (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Subtotal")) * (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("DescuentoPor") / 100)

                If Me.chkExonerado.Checked = True Then
                    Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Impuesto") = 0
                Else
                    Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Impuesto") = ((Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Subtotal")) - (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Descuento"))) * (ClsCatalogos.GetValorParametro("PORCENTAJEIMPUESTO") / 100)
                End If
                Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Total") = (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Subtotal")) - (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Descuento")) + (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Impuesto"))
            End If

            'Calcular los totales
            CalcularTotalesMoto()
        End If

        'Precio
        If e.Column.Equals(Me.colPrecioMoto) Or e.Column.Equals(Me.colPorcentajeMoto) Then

            'Valida si primero se digitó la cantidad
            If (IsDBNull(dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Codigo"))) Then
                Me.ElminarFilaSinPreguntarMoto()
                Me.InsertarNuevaFilaGridMoto()
                Exit Sub
            End If

            'Realizar cálculos en grid
            If Me.dtDetalleFacturaMoto.Rows.Count <> 0 Then
                If IsDBNull(Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Precio")) Then
                    Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Precio") = 0
                End If

                Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Subtotal") = (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Cantidad")) * (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Precio"))

                If IsDBNull(Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("DescuentoPor")) Then
                    Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("DescuentoPor") = 0
                End If

                Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Descuento") = (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Subtotal")) * (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("DescuentoPor") / 100)

                If Me.chkExonerado.Checked = True Then
                    Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Impuesto") = 0
                Else
                    Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Impuesto") = ((Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Subtotal")) - (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Descuento"))) * (ClsCatalogos.GetValorParametro("PORCENTAJEIMPUESTO") / 100)
                End If
                Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Total") = (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Subtotal")) - (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Descuento")) + (Me.dtDetalleFacturaMoto.DefaultView.Item(FilaActual)("Impuesto"))
            End If

            'Calcular los totales
            CalcularTotalesMoto()
        End If


        Me.boolModificado = True
    End Sub

    Private Sub grdDetalleMototabla_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdDetalleMototabla.CellValueChanging
        'Limpiar los íconos de error en el momento de modificar las celdas
        Dim view As ColumnView = sender

        Select Case e.Column.Name
            Case Me.colCodigo.Name, Me.colDescripcionMoto.Name, Me.ColCantidadMoto.Name
                view.ClearColumnErrors()
        End Select
    End Sub
#End Region

#Region "EditorKeyDown, Enter, InvalidRowException"

    Private Sub grdDetalleMoto_EditorKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleMoto.EditorKeyDown
        'Borra en modo de edición del grid, para ello se debe presionar la tecla control + delete
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            Me.EliminarFilaMoto()
        End If
    End Sub

    Private Sub grdDetalleMoto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleMoto.Enter
        Me.ErrorFactura.SetError(Me.grpDetalle, "")
        If Me.grdDetalleMototabla.RowCount = 0 Then
            Me.InsertarNuevaFilaGridMoto()
            Exit Sub
        End If
    End Sub

    Private Sub grdDetalleMototabla_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grdDetalleMototabla.InvalidRowException
        'Evitar el popup de error de la celda
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "ValidateRow,ValidatingEditor"

    Private Sub grdDetalleMototabla_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdDetalleMototabla.ValidateRow
        Dim viewCodigoRepuesto As ColumnView = CType(sender, ColumnView)
        Dim viewDescripcion As ColumnView = CType(sender, ColumnView)
        Dim viewCantidad As ColumnView = CType(sender, ColumnView)
        Dim viewPrecio As ColumnView = CType(sender, ColumnView)
        Dim columnCodigoRepuesto As GridColumn = viewCodigoRepuesto.Columns("Codigo")
        Dim columnDescripcion As GridColumn = viewDescripcion.Columns("Codigo")
        Dim columnCantidad As GridColumn = viewCantidad.Columns("Cantidad")
        Dim columnPrecio As GridColumn = viewPrecio.Columns("Precio")

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

        If IsDBNull(viewPrecio.GetRowCellValue(e.RowHandle, columnPrecio)) OrElse viewPrecio.GetRowCellValue(e.RowHandle, columnPrecio) <= 0 Then
            e.Valid = False
            viewPrecio.SetColumnError(columnCantidad, "El precio no puede contener un valor NULO, CERO o NEGATIVO.")
            boolExisteErroresGrid = True
        Else
            boolExisteErroresGrid = False
        End If
    End Sub

    Private Sub grdDetalleMototabla_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdDetalleMototabla.ValidatingEditor
        Dim View As GridView = sender
        Dim Valor As Double
        Dim bValidarEntero As Boolean = False
        Dim codigo As String

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

        '[Precio]
        If View.FocusedColumn.FieldName = "Precio" Then
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

#End Region

#End Region

    Private Sub txtCodigoCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Not (String.IsNullOrEmpty(Me.txtCodigoCliente.Text)) Then
                Me.cmbCliente.SelectedValue = Me.txtCodigoCliente.Text
            Else
                Me.cmbCliente.Text = ""
            End If
        End If
    End Sub

    Private Sub grdMotoSpnCodigo_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If e.Button.Index = 1 Then
            Me.CargarConsultaExistencia()
        End If
    End Sub
    Private Sub grdMotoSpnCodigo_ButtonClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles grdMotoSpnCodigo.ButtonClick
        Me.CargarConsultaExistencia()
    End Sub


#Region "Eventos del Descuento Autorizado"
    Private Sub numDescuento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Me.chkAutorizar.Checked Then
                Me.CargarDescuentoAutorizadoEnGrid()
            End If
        End If
    End Sub

    Private Sub numDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                Me.RecalcularDescuento()
            Else
                Me.NumDescuento.EditValue = 0
                MsgBox("No es posible superar el SubTotal de la Factura. [$" + SubTotalDolares.ToString + "]", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Exit Sub
            End If
        Else
            Me.RecalcularDescuento()
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

    Private Sub grdspnCodigoRepuesto_ButtonClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles grdspnCodigoRepuesto.ButtonClick
        Me.CargarConsultaExistencia()
    End Sub

    
End Class