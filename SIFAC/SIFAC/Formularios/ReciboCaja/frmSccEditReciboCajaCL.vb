Imports DAL
Imports Proyecto.Configuracion
Imports SISPAN.BO
Imports Seguridad.Datos

Public Class frmSccEditReciboCajaCL

#Region "Variables"

    Dim m_TipoGUID As Integer
    Dim m_ReciboCajaID As Integer
    Dim dtDetalleFact As DataTable
    Dim dtDetalleNotDebt As DataTable
    Dim dtClientes As New DataTable
    Dim dtSucursal As New DataTable
    Dim dtNotaCredito As DataTable
    Dim dtFormaPago As New DataTable
    Dim objSeg As SsgSeguridad

    Dim m_ClienteID As Integer
    Dim m_SucursalID As Integer
    Dim m_BoolCredtCent As Boolean
    Dim boolCambioHecho As Boolean
    Dim boolFalla As Boolean
    Dim m_boolConsulta As Boolean
    Dim m_FactDirecta As Boolean
    Dim m_IDFactura As Integer
    Dim boolInsercDirecta As Boolean
    
    '------------------Variables Propiedades sobre los parametros -----------------
    Dim m_IntCantMaxFactRecibo As Integer
    Dim m_IntCantMaxNotasDebitoEnRecibo As Integer
    Dim m_DecMontoMinimoAplicaRetencion As Decimal
    Dim m_DecPorRetencionFactura As Decimal
    Dim m_IntCantMaxNotasCreditoRecibo As Integer
    '-------------------------------------------------------------------------------

    '---------------------Variables Objetos de BD----------------------------------
    Dim objReciboCaja As SccReciboCaja
    Dim objReciboDetFactura As SccReciboDetFactura
    Dim objFormaPago As SccReciboDetFormaPago
    Dim objDetNotaDebito As SccReciboDetND
    Dim objDetNotaCredito As SccReciboDetNC
    Dim objNotCredito As SccNotaCredito

    '-------------------Variables de Totalizacion de Datos ------------------------
    Dim DecTotalFact As Decimal
    Dim DecTotalDesc As Decimal
    Dim DecTotalND As Decimal
    Dim DecTotalRetenido As Decimal
    Dim DecTotalRecibo As Decimal
    Dim DecTotalAbonado As Decimal
    Dim DecTotalEfect As Decimal
    Dim DecTotalNC As Decimal
    Dim DecTotalCK As Decimal
    Dim DecTotalOtros As Decimal
    Dim m_Ret As Decimal
    '------------------------------------------------------------------------------

    '--------------------Variables de Filas actuales------------------------------
    Dim rwCurrent As Integer
    Dim IDNumero As Integer
    '-----------------------------------------------------------------------------

    '---------------------Variables para consultar y filtrar datos--------------
    Dim strConsulta As String = ""
    Dim strfiltro As String = ""
    Dim strCampos As String = ""

#End Region

#Region "Propiedades"

    '------------------------Propiedades de Parametro-------------------------------------------------
    Public Property IntCantMaxFactRecibo()
        Get
            IntCantMaxFactRecibo = m_IntCantMaxFactRecibo
        End Get
        Set(ByVal value)
            m_IntCantMaxFactRecibo = value
        End Set
    End Property

    Public Property IntCantMaxNotasDebitoEnRecibo()
        Get
            IntCantMaxNotasDebitoEnRecibo = m_IntCantMaxNotasDebitoEnRecibo
        End Get
        Set(ByVal value)
            m_IntCantMaxNotasDebitoEnRecibo = value
        End Set
    End Property

    Public Property DecMontoMinimoAplicaRetencion()
        Get
            DecMontoMinimoAplicaRetencion = m_DecMontoMinimoAplicaRetencion
        End Get
        Set(ByVal value)
            m_DecMontoMinimoAplicaRetencion = value
        End Set
    End Property

    Public Property IntCantMaxNotasCreditoRecibo()
        Get
            IntCantMaxNotasCreditoRecibo = m_IntCantMaxNotasCreditoRecibo
        End Get
        Set(ByVal value)
            m_IntCantMaxNotasCreditoRecibo = value
        End Set
    End Property

    Public Property PorRetFactura()
        Get
            PorRetFactura = m_DecPorRetencionFactura
        End Get
        Set(ByVal value)
            m_DecPorRetencionFactura = value
        End Set
    End Property
    '--------------------------------------------------------------------------------------------------------
    Public Property ClienteID() As Integer
        Get
            ClienteID = m_ClienteID
        End Get
        Set(ByVal value As Integer)
            m_ClienteID = value
        End Set
    End Property

    Public Property TipoGUID() As Integer
        Get
            TipoGUID = m_TipoGUID
        End Get
        Set(ByVal value As Integer)
            m_TipoGUID = value
        End Set
    End Property

    Public Property ReciboCajaID() As Integer
        Get
            ReciboCajaID = m_ReciboCajaID
        End Get
        Set(ByVal value As Integer)
            m_ReciboCajaID = value

        End Set
    End Property

    Public Property SucursalID() As Integer
        Get
            SucursalID = m_SucursalID
        End Get
        Set(ByVal value As Integer)
            m_SucursalID = value
        End Set
    End Property

    Public Property BoolCredCent() As Boolean
        Get
            BoolCredCent = m_BoolCredtCent
        End Get
        Set(ByVal value As Boolean)
            m_BoolCredtCent = value
        End Set
    End Property

    Public Property boolConsulta() As Boolean
        Get
            boolConsulta = m_boolConsulta
        End Get
        Set(ByVal value As Boolean)
            m_boolConsulta = value
        End Set
    End Property

    Public Property BoolFactDict() As Boolean
        Get
            BoolFactDict = m_FactDirecta
        End Get
        Set(ByVal value As Boolean)
            m_FactDirecta = value
        End Set
    End Property

    Public Property IDFact() As Integer
        Get
            IDFact = m_IDFactura
        End Get
        Set(ByVal value As Integer)
            m_IDFactura = value
        End Set
    End Property

    Property Ret() As Decimal
        Get
            Ret = m_Ret
        End Get
        Set(ByVal value As Decimal)
            m_Ret = value
        End Set
    End Property

#End Region

#Region "Carga de Datos"

    '-----------------------------------------------------------------------------------------------------------
    ' Autor           : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion  : 15 de diciembre de 2007.
    ' Descripcion     : Esta funcion se encarga de hacer la inicializacion completa de todos los datos involucrados.
    '-----------------------------------------------------------------------------------------------------------
    Private Sub InicializacionDatos()
        Try
            Me.boolInsercDirecta = False
            objSeg = New SsgSeguridad
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmSccReciboCaja"

            If Not objSeg.TienePermiso("AutorizarDescEspecial") Then
                Me.grdFacturas.Columns("Desc. Ocasional").Tag = "BLOQUEADO"
            End If

            '------------------En caso de que se ingrese solamente en modo Consulta--------------------------
            PropiedadesForm()
            If boolConsulta Then
                Me.BloquearColumnasModoConsulta()
                Me.Text = "Consulta Recibo Caja."
            Else
                For intCantCol As Integer = 1 To Me.grdFacturas.Columns.Count - 1
                    If (intCantCol >= 1 And intCantCol <= 4) Or (intCantCol = 8) Or (intCantCol = 12) Then
                        Me.grdFacturas.Columns(intCantCol).Tag = "BLOQUEADO"
                    End If
                Next
            End If
            '------------------------------------------------------------------------------------------------

            clsProyecto.CargarTemaDefinido(Me)
            Me.tbControl.Enabled = False
            cmdAceptar.Enabled = False
            '-------Seteamos el grid de formas de Pago segun el tipo de edicion y la columnas a mostrar------
            Me.grdOtraFormaPago.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor
            Me.grdOtraFormaPago.Splits(0).DisplayColumns(4).Visible = False
            Me.grdOtraFormaPago.Splits(0).DisplayColumns(5).Visible = False
            Me.grdOtraFormaPago.Splits(0).DisplayColumns(6).Visible = False
            '------------------------------------------------------------------------------------------------

            '--------------------------Ponemos seleccionado el Nombre del Vendedor------------------------- 
            Me.txtNumero.Enabled = False
            Me.txtSucursal.Enabled = False
            Me.txtCliente.Enabled = False

            Me.grdFacturas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor
            Me.CargarFormasPago()
            CargarFormaPagosCOMBO()
            CargarEntidadBancarias()

            If Me.BoolFactDict Then
                CargarDatosFACTDIRECT()
                Me.cmdBuscarCliente.Enabled = False
                Me.tbControl.Enabled = True
                Me.dtDetalleNotDebt = New DataTable
            End If

            If Me.TipoGUID = 1 Then
                CargarClientes()
                CargarSucursales(Me.ClienteID)
                Me.cmdBuscarCliente.Enabled = False
                DetallesAgregados()
                CalcularTotales()
                Me.cmdAceptar.Enabled = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '----------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 11 de diciembre de 2007.
    ' Descripcion    : Este procedimiento se encarga de inicializar las variables parametro para el caso de uso
    '---------------------------------------------------------------------------------------------------------
    Private Sub InicializarValoresParametro()
        Try

            Me.IntCantMaxNotasCreditoRecibo = CargaValores("CantMaxNotasCreditoEnRecibo")
            Me.IntCantMaxFactRecibo = CargaValores("CantMaxFacturasEnRecibo")
            IntCantMaxNotasDebitoEnRecibo = CargaValores("CantMaxNotasDebitoEnRecibo")
            DecMontoMinimoAplicaRetencion = CargaValores("MontoMinAplicaRetencionFactura")
            Me.PorRetFactura = CargaValores("PorcRetencionFactura") / 100

        Catch ex As Exception
        End Try
    End Sub

    '----------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 11 de diciembre de 2007.
    ' Descripcion    : Este procedimiento se encarga de cargar los valores correspondientes a los valores 
    '----------------: de los parametros segun el nombre de entrada. 
    '---------------------------------------------------------------------------------------------------------
    Private Function CargaValores(ByVal strNombre As String) As Integer
        Dim DtDatosParametro As New DataTable
        Dim intValorRetornar As Integer
        Try
            intValorRetornar = 0
            DtDatosParametro = StbParametro.RetrieveDT("Nombre =" + "'" + strNombre + "'" + "", , "Valor")
            intValorRetornar = DtDatosParametro.DefaultView.Item(0)("Valor")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            DtDatosParametro = Nothing
        End Try

        Return intValorRetornar
    End Function

    Private Sub BloquearColumnasModoConsulta()
        Try
            Me.cmdEliminar.Enabled = False
            Me.cmdAceptar.Enabled = False
            Me.DtpFecha.Enabled = False
            Me.cmdBuscarCliente.Enabled = False

            For intCantCol As Integer = 0 To Me.grdFacturas.Columns.Count - 1
                Me.grdFacturas.Columns(intCantCol).Tag = "BLOQUEADO"
            Next

            For intCantCol As Integer = 0 To Me.grdNotaDebito.Columns.Count - 1
                Me.grdNotaDebito.Columns(intCantCol).Tag = "BLOQUEADO"
            Next

            For intCantCol As Integer = 0 To Me.grdNotasCredito.Columns.Count - 1
                Me.grdNotasCredito.Columns(intCantCol).Tag = "BLOQUEADO"
            Next

            For intCantCol As Integer = 0 To Me.grdOtraFormaPago.Columns.Count - 1
                Me.grdOtraFormaPago.Columns(intCantCol).Tag = "BLOQUEADO"
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSccEditReciboColector_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not Me.boolConsulta Then
            If Not Me.dtDetalleFact Is Nothing Then
                Me.ReservarFacturas(1)
            End If
            If Not Me.dtDetalleNotDebt Is Nothing Then
                Me.ReservarNotasDebito(1)
            End If
            If Not Me.dtNotaCredito Is Nothing Then
                Me.ReservarNotasCredito(1)
            End If
        End If
        LiberarRecursos()
    End Sub
    '-----------------------------------------------------------------------------------------------------------

    Private Sub frmSccEditReciboColector_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializacionDatos()

        '-- Asignar tamaño de letra a Botones del Grid para ocultar el Text que sirve como Shortcut
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 12 de diciembre de 2007.
    'Descripcion    : Procedimiento encargado de setear los propiedades de icono y titulo del formulario.
    '------------------------------------------------------------------------------------------
    Private Sub PropiedadesForm()
        Select Case Me.TipoGUID
            Case 0
                Me.Text = "Nuevo Recibo de Caja"
                Me.Icon = My.Resources.AgregarIco
                Me.DtpFecha.Value = clsProyecto.Conexion.FechaServidor.Date
            Case 1
                Me.Text = "Editar Recibo Caja"
                Me.Icon = My.Resources.EditarIco
            Case 2
                Me.Text = "Consulta Recibo Caja"
                Me.Icon = My.Resources.EditarIco
        End Select
    End Sub


    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 11 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de cargar los Clientes.
    '------------------------------------------------------------------------------------------
    Private Function CargarClientes() As Boolean

        Try
            strfiltro = "SccClienteID = " & Me.ClienteID
            strConsulta = clsConsultas.ClientesSucursal("Cliente,CreditoCentralizado,DescuentoEspecifico,SccClienteID", strfiltro)
            dtClientes = SqlHelper.ExecuteQueryDT(strConsulta)
            Me.txtCliente.Text = dtClientes.DefaultView.Item(0)("Cliente")
            Me.ClienteID = dtClientes.DefaultView.Item(0)("SccClienteID")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            strConsulta = ""
            strfiltro = ""
        End Try
    End Function

    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 11 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de realizar el proceso de carga de las sucursales.
    '------------------------------------------------------------------------------------------
    Private Sub CargarSucursales(ByVal intIdCliente As Integer)
        Try

            Me.dtSucursal = SccSucursal.RetrieveDT("SccSucursalID=" & Me.SucursalID, , "SccSucursalID,Nombre,DescuentoEspecifico")
            Me.SucursalID = Me.dtSucursal.DefaultView.Item(0)("SccSucursalID")
            Me.txtSucursal.Text = Me.dtSucursal.DefaultView.Item(0)("Nombre")
            Me.CargarDetalleFacturas(Me.ClienteID, Me.SucursalID)
            Me.CargarNotaDebito(Me.ClienteID, Me.SucursalID)
            Me.CargarNotasdeCredito(Me.ClienteID, Me.SucursalID)
            Me.tbControl.Enabled = True

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 11 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de cargar los detalles de las facturas.
    '------------------------------------------------------------------------------------------
    Private Sub CargarDetalleFacturas(ByVal IntIdCliente As Integer, ByVal IntIdSucursal As Integer)
        Dim strCampos As String
        Try
            Me.dtDetalleFact = Nothing
            If Not Me.boolConsulta Then
                Select Case Me.BoolCredCent
                    Case True
                        strfiltro = "(Estado <> 'ANULADA') AND (Estado <> 'PAGADA') And (Estado <> 'REGISTRADA')" & _
                                    "AND objClienteID = " & IntIdCliente & " AND Reservado = 'false'"

                    Case False
                        strfiltro = "(Estado <> 'ANULADA') AND (Estado <> 'PAGADA') And (Estado <> 'REGISTRADA')" & _
                                    " AND objClienteID = " & IntIdCliente & _
                                    " AND objSucursalID = " & IntIdSucursal & " AND Reservado = 'false'"
                End Select
                strConsulta = clsConsultas.ReciboColectorDetalleFacturas(, strfiltro, "ORDER BY Numero")

            Else
                strfiltro = "(Estado <> 'ANULADA') And (Estado <> 'REGISTRADA')" & _
                                        " AND objClienteID = " & IntIdCliente & _
                                        " AND objSucursalID = " & IntIdSucursal
                strCampos = ""
                strConsulta = clsConsultas.ReciboColectorDetalleFacturas("Numero,Fecha,FechaVencimiento,SfaFacturaID,objEstadoID,Total,Estado" & _
                ",objClienteID,SubTotal,objSucursalID,DescEspecifico,DescOcasional,Retencion,CantAbonar,CantPagar,MontoTotal as MontoFactura", strfiltro)
            End If
            Me.dtDetalleFact = New DataTable
            Me.dtDetalleFact = SqlHelper.ExecuteQueryDT(strConsulta)
            Me.grdFacturas.SetDataBinding(Me.dtDetalleFact, "", True)
            If Not Me.boolConsulta Then
                Me.ReservarFacturas(0)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            strConsulta = ""
            strfiltro = ""
        End Try
    End Sub

    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 12 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de cargar los detalles correspondientes a las notas de debito.
    '------------------------------------------------------------------------------------------
    Private Sub CargarNotaDebito(ByVal IntIdCliente As Integer, ByVal IntIdSucursal As Integer)

        Try
            strfiltro = ""
            dtDetalleNotDebt = Nothing
            If Not Me.boolConsulta Then
                Select Case Me.BoolCredCent
                    Case True
                        strfiltro = "(Estado = 'AUTORIZADA' )" & _
                                                "AND objClienteID = " & IntIdCliente & " AND Reservado = 'false'"
                    Case False
                        strfiltro = "(Estado = 'AUTORIZADA')" & _
                            "AND objClienteID = " & IntIdCliente & _
                            " AND objSucursalID = " & IntIdSucursal & " AND Reservado = 'false'"
                End Select

                strConsulta = clsConsultas.ReciboColectorDetalleNotaDebt(, strfiltro, "ORDER BY Numero")
            Else
                strfiltro = "(Estado = 'AUTORIZADA' or Estado = 'PAGADA')" & _
                                    "AND objClienteID = " & IntIdCliente & _
                                    " AND objSucursalID = " & IntIdSucursal
                strConsulta = clsConsultas.ReciboColectorDetalleNotaDebt(, strfiltro, "ORDER BY Numero")
            End If
            dtDetalleNotDebt = New DataTable
            dtDetalleNotDebt = SqlHelper.ExecuteQueryDT(strConsulta)
            '-----------------------------------------------------------------------------------------------
            Me.grdNotaDebito.SetDataBinding(Me.dtDetalleNotDebt, "", True)
            If Not Me.boolConsulta Then
                Me.ReservarNotasDebito(0)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            strConsulta = ""
            strfiltro = ""
        End Try
    End Sub

    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 12 de diciembre de 2007.
    'Descripcion    : Esta Funcion se encarga de devolverme el descuento especifico a aplicar.
    '------------------------------------------------------------------------------------------
    Private Function ObtenerDescEspecifico() As Decimal
        Dim DecValor As Decimal
        Dim objCliente As New SccCliente
        Dim objSucursal As New SccSucursal
        Try
            objCliente.Retrieve(Me.ClienteID)
            objSucursal.Retrieve(Me.SucursalID)
            Select Case Me.BoolCredCent
                Case True
                    DecValor = objCliente.DescuentoEspecifico
                Case False
                    DecValor = objSucursal.DescuentoEspecifico
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objCliente = Nothing
            objSucursal = Nothing
        End Try
        Return DecValor
    End Function

    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 12 de diciembre de 2007.
    'Descripcion    : Esta Funcion se encarga de devolverme el tipo de credito del Cliente.
    '------------------------------------------------------------------------------------------
    Private Function ObtenerTipoCredito(ByVal IdCliente As Integer) As Boolean
        Dim boolrst As Boolean
        Dim objCliente As New SccCliente
        Try
            objCliente.Retrieve(IdCliente)
            boolrst = objCliente.CreditoCentralizado
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objCliente = Nothing
        End Try
        Return boolrst
    End Function
    '--------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado.
    'Fecha Creacion : 13 de diciembre de 2007.
    'Descripcion    : Este Procedimiento se encarga de realizar la carga de las notas de credito.
    '--------------------------------------------------------------------------------------------
    Private Sub CargarNotasdeCredito(ByVal IntIdCliente As Integer, ByVal IntIdSucursal As Integer)

        Try
            dtNotaCredito = Nothing
            If Not Me.boolConsulta Then
                Select Case Me.BoolCredCent
                    Case True
                        strfiltro = "Estado = 'Autorizada' AND objClienteID = " & Me.ClienteID

                    Case False
                        strfiltro = "Estado = 'Autorizada' AND objClienteID = " & Me.ClienteID & _
                        " AND " + "objSucursalID =" & Me.SucursalID
                End Select
                strCampos = "Numero,Monto,Fecha,Estado,ActivoSel,SccNotaCreditoID,NumeroNC"
                strConsulta = clsConsultas.ObtenerNotaCredito(strCampos, strfiltro, "")
            Else
                strfiltro = "(Estado = 'Autorizada' or Estado = 'PAGADA') AND objClienteID = " & Me.ClienteID & _
                                " AND " + "objSucursalID =" & Me.SucursalID
                strCampos = "Numero,Monto,Fecha,Estado,ActivoSel,SccNotaCreditoID,NumeroNC"
                strConsulta = clsConsultas.ObtenerNotaCredito(strCampos, strfiltro, "")
            End If
            dtNotaCredito = New DataTable
            dtNotaCredito = SqlHelper.ExecuteQueryDT(strConsulta)
            Me.grdNotasCredito.SetDataBinding(Me.dtNotaCredito, "", True)
            Me.ReservarNotasCredito(0)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            strConsulta = ""
            strfiltro = ""
            strCampos = ""
        End Try

    End Sub
    '--------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado.
    'Fecha Creacion : 13 de diciembre de 2007.
    'Descripcion    : Este Procedimiento se encarga de realizar la carga de las formas de pago existentes
    '--------------------------------------------------------------------------------------------

    Private Sub CargarFormasPago()
        Try
            Select Case Me.TipoGUID
                Case 0
                    strfiltro = "1=0"
                    strConsulta = clsConsultas.FormasPago(, strfiltro)
                    Me.dtFormaPago = SqlHelper.ExecuteQueryDT(strConsulta)
                    Me.grdOtraFormaPago.SetDataBinding(Me.dtFormaPago, "", True)
                Case 1
                    strfiltro = "objReciboCajaID=" & Me.ReciboCajaID
                    strConsulta = clsConsultas.FormasPago(, strfiltro)
                    Me.dtFormaPago = SqlHelper.ExecuteQueryDT(strConsulta)
                    Me.grdOtraFormaPago.SetDataBinding(Me.dtFormaPago, "", True)
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            strConsulta = ""
            strfiltro = ""
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado.
    'Fecha Creacion : 13 de diciembre de 2007.
    'Descripcion    : Este Procedimiento se encarga de realizar la carga de las entidades bancarias.
    '--------------------------------------------------------------------------------------------

    Private Sub CargarEntidadBancarias()
        Dim dtCatalogo As New DataTable
        Dim dtValorCatalogo As New DataTable
        Try
            dtCatalogo = StbCatalogo.RetrieveDT("Nombre = 'EntidadBancaria'", , "StbCatalogoID")
            If dtCatalogo.DefaultView.Count > 0 Then
                dtValorCatalogo = StbValorCatalogo.RetrieveDT("objCatalogoID=" & dtCatalogo.DefaultView.Item(0)("StbCatalogoID"), , "StbValorCatalogoID,Codigo,Descripcion")

                If dtValorCatalogo.DefaultView.Count > 0 Then
                    Me.CTdbEntidadBanc.DataSource = dtValorCatalogo
                    Me.CTdbEntidadBanc.DisplayMember = "Descripcion"
                    Me.CTdbEntidadBanc.ValueMember = "StbValorCatalogoID"
                    Me.CTdbEntidadBanc.DisplayColumns("Codigo").Visible = False
                    Me.CTdbEntidadBanc.DisplayColumns("StbValorCatalogoID").Visible = False
                    Me.CTdbEntidadBanc.ValueTranslate = True
                    Me.CTdbEntidadBanc.ExtendRightColumn = True
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtCatalogo = Nothing
            dtValorCatalogo = Nothing
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado.
    'Fecha Creacion : 14 de diciembre de 2007.
    'Descripcion    : Este Procedimiento se encarga de realizar la carga de las formas de pago existentes
    '--------------------------------------------------------------------------------------------
    Private Sub CargarFormaPagosCOMBO()
        Dim dtCatalogo As New DataTable
        Dim DtValorCatalogo As New DataTable

        Try
            dtCatalogo = StbCatalogo.RetrieveDT("Nombre = 'FormaPago'", , "StbCatalogoID")
            If dtCatalogo.DefaultView.Count > 0 Then
                DtValorCatalogo = StbValorCatalogo.RetrieveDT("objCatalogoID=" & dtCatalogo.DefaultView.Item(0)("StbCatalogoID"), , "StbValorCatalogoID,Codigo as CodFormPago,Descripcion")

                If DtValorCatalogo.DefaultView.Count > 0 Then
                    Me.CTdbFormaPago.DataSource = DtValorCatalogo
                    Me.CTdbFormaPago.DisplayMember = "Descripcion"
                    Me.CTdbFormaPago.ValueMember = "StbValorCatalogoID"
                    Me.CTdbFormaPago.DisplayColumns("StbValorCatalogoID").Visible = False
                    Me.CTdbFormaPago.DisplayColumns("CodFormPago").Visible = False
                    Me.CTdbFormaPago.ValueTranslate = True
                    Me.CTdbFormaPago.ExtendRightColumn = True
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 18 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de recuperar el monto a abonar segun la opcion seleccionada al incluir una fact
    '------------------------------------------------------------------------------------------------------------------------
    Private Function CargarMonto(ByVal IntClienteID As Integer, ByVal IntSucursalID As Integer, ByVal IdFactura As Integer) As Decimal
        Dim DecMontoAbonar As Decimal
        Dim dtCuentaCobrar As New DataTable
        Dim dtCuentaCobrarDetalle As New DataTable
        Dim IntIdCuentaCobrar As Integer
        Dim dtFactura As SfaFactura
        Try

            Select Case Me.BoolCredCent

                Case False
                    strfiltro = "objClienteID=" & IntClienteID & " AND " & " objSucursalID =" & IntSucursalID & ""
                Case True
                    dtFactura = New SfaFactura
                    dtFactura.Retrieve(IdFactura)
                    IntSucursalID = dtFactura.objSucursalID
                    strfiltro = "objClienteID=" & IntClienteID & " AND " & " objSucursalID =" & IntSucursalID & ""
            End Select

            dtCuentaCobrar = SccCuentaPorCobrar.RetrieveDT(strfiltro, , "SccCuentaPorCobrarID")

            If dtCuentaCobrar.DefaultView.Count > 0 Then
                IntIdCuentaCobrar = dtCuentaCobrar.DefaultView.Item(0)("SccCuentaPorCobrarID")
            End If
            strfiltro = ""
            strfiltro = "objCuentaCobrarID =" & IntIdCuentaCobrar & " AND " & "objFacturaID =" & IdFactura & ""
            dtCuentaCobrarDetalle = SccCuentaCobrarDetalle.RetrieveDT(strfiltro, , "Saldo as Monto")
            DecMontoAbonar = dtCuentaCobrarDetalle.DefaultView.Item(0)("Monto")

            Return DecMontoAbonar
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtCuentaCobrar = Nothing
            dtCuentaCobrarDetalle = Nothing
        End Try
    End Function


    '-----------------------------------------------------------------------------------------------------------------------------    
    'Autor          : Pedro Pablo Tinoco Salgado.
    'Fecha Creacion : 28 de diciembre de 2007.
    'Descripcion    : Esta funcion se encarga de realizar el proceso de cargar los datos generales con respecto a una facturacion
    '---------------: Directa.
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub CargarDatosFACTDIRECT()
        Dim ObjCliente As New SccCliente
        Dim ObjSucursal As New SccSucursal

        Try
            InicializarValoresParametro()
            strfiltro = "SfaFacturaID = " & Me.IDFact
            strConsulta = clsConsultas.ReciboColectorDetalleFacturas("Numero,Fecha,FechaVencimiento,SfaFacturaID,objEstadoID,Total,Estado" & _
                 ",objClienteID,SubTotal,objSucursalID,DescEspecifico,DescOcasional,Retencion,CantAbonar,CantPagar,MontoTotal as MontoFactura", strfiltro)
            Me.dtDetalleFact = New DataTable
            Me.dtDetalleFact = SqlHelper.ExecuteQueryDT(strConsulta)
            Me.grdFacturas.SetDataBinding(Me.dtDetalleFact, "", True)
            Me.ClienteID = Me.dtDetalleFact.DefaultView.Item(0)("objClienteID")
            Me.SucursalID = Me.dtDetalleFact.DefaultView.Item(0)("objSucursalID")
            ObjCliente.Retrieve(Me.ClienteID)
            Me.BoolCredCent = ObjCliente.CreditoCentralizado
            Me.txtCliente.Text = ObjCliente.Nombre1 + " " + ObjCliente.Apellido1
            ObjSucursal.Retrieve(Me.SucursalID)
            Me.txtSucursal.Text = ObjSucursal.Nombre

            '----------------------------Seteamos los valores de las columnas de seleccion-------------------------
            Me.grdFacturas.Columns("Incluir").Value = True
            Me.grdFacturas.Columns("Cancelar").Value = True
            Me.grdFacturas.Columns("Desc. Especifico").Value = (Me.ObtenerDescEspecifico) / 100
            Me.grdFacturas.Columns("Monto Abonar").Value = Me.grdFacturas.Columns("Saldo").Value
            Me.grdFacturas.Splits(0).DisplayColumns("Incluir").Locked = True
            Me.grdFacturas.Splits(0).DisplayColumns("Abonar").Locked = True
            Me.grdFacturas.Splits(0).DisplayColumns("Cancelar").Locked = True
            Me.grdFacturas.Splits(0).DisplayColumns("Monto Abonar").Locked = True
            '------------------------------------------------------------------------------------------------------
            Me.CargarNotasdeCredito(Me.ClienteID, Me.SucursalID)
            Me.dtDetalleFact.AcceptChanges()
            Me.grdFacturas.Refresh()
            Me.ReservarFacturas(0)
            Me.ReservarNotasCredito(0)
            AplicCalcularDesc_ESPOCRET()
            CalcularTotales()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            ObjCliente = Nothing
            ObjSucursal = Nothing
        End Try
    End Sub


#End Region

#Region "Reservacion de Datos"

    '--------------------------------------------------------------------------------------------------------------
    '--- Autor          : Pedro Pablo Tinoco Salgado.
    '--- Fecha Creacion : 03 de enero de 2008.
    '--- Descripcion    : Esta funcion se encarga de realizar la reservacion y liberacion de los datos con respecto.
    '-------------------: a los datos de las facturas.
    '--------------------------------------------------------------------------------------------------------------
    Private Sub ReservarFacturas(ByVal IntOpcion As Integer)
        Dim T As New TransactionManager
        Try
            T.BeginTran()
            For Each drwFact As DataRow In Me.dtDetalleFact.Rows
                If IntOpcion = 0 Then
                    modSISPAN.ReservarRegistro("SfaFactura", drwFact("SfaFacturaID"), T)
                Else
                    modSISPAN.LiberarRegistro("SfaFactura", drwFact("SfaFacturaID"), T)
                End If
            Next
            T.CommitTran()
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            T = Nothing
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------------

    '--------------------------------------------------------------------------------------------------------------
    '--- Autor          : Pedro Pablo Tinoco Salgado.
    '--- Fecha Creacion : 03 de enero de 2008.
    '--- Descripcion    : Esta funcion se encarga de realizar la reservacion y liberacion de los datos con respecto a
    '-------------------: las notas de credito.
    '--------------------------------------------------------------------------------------------------------------
    Private Sub ReservarNotasCredito(ByVal IntOpcion As Integer)
        Dim T As New TransactionManager
        Try
            T.BeginTran()
            For Each drwFact As DataRow In Me.dtNotaCredito.Rows
                If IntOpcion = 0 Then
                    modSISPAN.ReservarRegistro("SccNotaCredito", drwFact("SccNotaCreditoID"), T)
                Else
                    modSISPAN.LiberarRegistro("SccNotaCredito", drwFact("SccNotaCreditoID"), T)
                End If
            Next
            T.CommitTran()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------
    '--- Autor          : Pedro Pablo Tinoco Salgado.
    '--- Fecha Creacion : 03 de enero de 2008.
    '--- Descripcion    : Esta funcion se encarga de realizar la reservacion y liberacion de los datos con respecto a
    '-------------------: los datos de las notas de debito.
    '--------------------------------------------------------------------------------------------------------------
    Private Sub ReservarNotasDebito(ByVal IntOpcion As Integer)
        Dim T As New TransactionManager
        Try
            T.BeginTran()
            For Each drwFact As DataRow In Me.dtDetalleNotDebt.Rows
                If IntOpcion = 0 Then
                    modSISPAN.ReservarRegistro("SccNotaDebito", drwFact("SccNotaDebitoID"), T)
                Else
                    modSISPAN.LiberarRegistro("SccNotaDebito", drwFact("SccNotaDebitoID"), T)
                End If
            Next
            T.CommitTran()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------------
#End Region

#Region "Calculo Datos"

    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 12 de diciembre de 2007.
    'Descripcion    : Esta Funcion se encarga de realizar el proceso de calcular todos los subtotales y totales
    '-------------------------------------------------------------------------------------------
    Private Sub CalcularTotales()
        Dim DecSumTotalFact As Decimal
        Dim DecSumTotalRet As Decimal
        Dim DecSumTotalND As Decimal
        Dim DecSumMontoFactura As Decimal
        Dim obj As New Object

        Try
            If Not Me.dtDetalleFact Is Nothing Then
                '---------------------Calculamos el monto original de cada factura--------------------------------
                If Me.dtDetalleFact.DefaultView.Count > 0 Then

                    'obj = dtDetalleFact.Compute("SUM(CantAbonar)", "")
                    obj = dtDetalleFact.Compute("SUM(CantAbonar)", "ActivoSel = 'true'")
                    If Not IsDBNull(obj) Then
                        DecSumMontoFactura = obj
                    End If

                    '------------------------Calculamos el total de las Facturas incluidas----------------------------
                    obj = dtDetalleFact.Compute("SUM(CantPagar)", "ActivoSel = 'true'")

                    If Not IsDBNull(obj) Then
                        DecSumTotalFact = obj
                    End If
                    '------------------------------------------------------------------------------------------------

                    '--------------------------Calculamos el Total retenido por todas las facturas incluidas----------
                    obj = dtDetalleFact.Compute("SUM(Retencion)", "ActivoSel = 'true'")
                    If Not IsDBNull(obj) Then
                        DecSumTotalRet = obj
                    End If
                End If

            End If


            If Not Me.dtNotaCredito Is Nothing Then
                If Me.dtNotaCredito.DefaultView.Count > 0 Then
                    obj = dtNotaCredito.Compute("SUM(Monto)", "ActivoSel= 'true'")
                    If Not IsDBNull(obj) Then
                        Me.DecTotalNC = obj
                    End If
                End If
            End If

            If Me.dtFormaPago.DefaultView.Count > 0 Then
                obj = Me.dtFormaPago.Compute("SUM(Monto)", "CodFormPago = 'EFEC'")
                If Not IsDBNull(obj) Then
                    Me.DecTotalEfect = obj
                End If

                obj = Me.dtFormaPago.Compute("SUM(Monto)", "CodFormPago = 'CK'")
                If Not IsDBNull(obj) Then
                    Me.DecTotalCK = obj
                End If

                obj = Me.dtFormaPago.Compute("SUM(Monto)", "CodFormPago = 'TC'")
                If Not IsDBNull(obj) Then
                    Me.DecTotalOtros = obj
                End If

            End If

            '-------------------------------------------------------------------------------------------------
            '------------------Calculamos el Total Descontado por todas las facturas incluidas----------------
            Me.DecTotalFact = DecSumTotalFact
            Me.DecTotalRetenido = DecSumTotalRet
            Me.DecTotalDesc = DecSumMontoFactura - (DecSumTotalRet + DecSumTotalFact)

            If Not Me.dtDetalleNotDebt Is Nothing Then
                If Me.dtDetalleNotDebt.DefaultView.Count > 0 Then
                    obj = dtDetalleNotDebt.Compute("SUM(Monto)", "ActivoSel = 'true'")
                    If Not IsDBNull(obj) Then
                        DecSumTotalND = obj
                    End If
                End If
            End If


            Me.DecTotalND = DecSumTotalND
            Me.DecTotalRecibo = Me.DecTotalFact + Me.DecTotalND

            Me.txtTotalFact.Value = Decimal.Round(Me.DecTotalFact, 2)
            Me.txtTotalDB.Value = Decimal.Round(Me.DecTotalND, 2)
            Me.txtTotalPagar.Value = Decimal.Round(Me.DecTotalRecibo, 2)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    '--------------------------------------------------------------------------------------------------------------------
    'Autor           : Pedro Pablo Tinoco
    'Fecha Creacion  : 14 de diciembre de 2007
    'Descripcion     : Funcion encargada de aplicar los descuentos especificos y realizar los calculos de retencion.
    '---------------------------------------------------------------------------------------------------------------------
    Private Sub AplicCalcularDesc_ESPOCRET()
        Dim DescOC As Decimal
        Dim DescEsp As Decimal
        Dim SubTotal As Decimal
        Dim Total As Decimal
        Dim Monto As Decimal

        Try
            Ret = 0
            DescOC = CalculoDescOcasional(Me.grdFacturas.Columns("Desc. Ocasional").Value)
            DescEsp = Me.grdFacturas.Columns("Desc. Especifico").Value

            Monto = Me.grdFacturas.Columns("Monto Abonar").Value
            SubTotal = Monto - ((Monto * DescOC) + (Monto * DescEsp))

            If SubTotal > Me.DecMontoMinimoAplicaRetencion Then
                Ret = SubTotal * Me.PorRetFactura
            End If

            Total = SubTotal

            If boolInsercDirecta Then

                If Me.grdFacturas.Columns("Retención").Value < Ret Then
                    Total = SubTotal - Me.grdFacturas.Columns("Retención").Value
                Else
                    Total = SubTotal
                    Me.grdFacturas.Columns("Retención").Value = 0
                End If
            End If


            Me.grdFacturas.Columns("Total").Value = Total

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub




    '------------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 18 de diciembre de 2007.
    ' Descripcion    : Esta procedimiento se encarga de realizar el proceso de calculo y actualizacion de los montos abonados 
    '----------------: en formas de pago incluidas.
    '------------------------------------------------------------------------------------------------------------------
    Public Sub CalculoMontoAbonado()
        Dim DecMontoAbonado As Decimal
        Dim DecMontoNotcred As Decimal
        DecMontoAbonado = 0.0
        Dim obj As Object
        Try
            If dtNotaCredito.DefaultView.Count > 0 Then
                obj = (dtNotaCredito.Compute("Sum(Monto)", "ActivoSel = 'true'"))
                If Not IsDBNull(obj) Then
                    DecMontoNotcred = obj
                End If
            End If

            If Me.dtFormaPago.DefaultView.Count > 0 Then
                For intCantVisible As Integer = 0 To Me.dtFormaPago.DefaultView.Count - 1
                    If Convert.ToString(Me.dtFormaPago.DefaultView.Item(intCantVisible)("Monto")) <> "" Then
                        DecMontoAbonado = DecMontoAbonado + Me.dtFormaPago.DefaultView.Item(intCantVisible)("Monto")
                    End If
                Next
            End If

            Me.DecTotalAbonado = DecMontoAbonado + DecMontoNotcred
            Me.txtMontAbonado.Value = Me.DecTotalAbonado
            Me.txtRestante.Value = Me.txtTotalPagar.Value - Me.txtMontAbonado.Value

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Verificacion y Validaciones"
    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 12 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de realizar el proceso de validacion de numero
    '---------------: numero maximo de facturas y notas de debitos incluidas en el recibo.
    '------------------------------------------------------------------------------------------
    Private Sub ValidarCantFactDebtSel(ByVal Intopcion As Integer)
        Try
            Select Case Intopcion
                Case 0
                    If CBool(Me.dtDetalleFact.Rows(Me.grdFacturas.Row)("ActivoSel")) Then
                        If VerificarCantSel(Intopcion) > Me.IntCantMaxFactRecibo Then
                            MsgBox("La cantidad de facturas seleccionadas, excede el máximo permitido.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                            Me.grdFacturas.Columns("Incluir").Value = False
                            Me.dtDetalleFact.AcceptChanges()
                            Me.grdFacturas.Refresh()
                            Exit Sub
                        End If
                    End If
                Case 1

                    If CBool(Me.dtDetalleNotDebt.Rows(Me.grdNotaDebito.Row)("ActivoSel")) Then
                        If VerificarCantSel(Intopcion) > Me.IntCantMaxNotasDebitoEnRecibo Then
                            MsgBox("La cantidad de facturas seleccionadas, excede el máximo permitido.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                            Me.grdNotaDebito.Columns("Incluir").Value = False
                            Me.dtDetalleNotDebt.AcceptChanges()
                            Me.grdNotaDebito.Refresh()
                            Exit Sub
                        End If
                    End If

                Case 2
                    If CBool(Me.dtNotaCredito.Rows(Me.grdNotasCredito.Row)("ActivoSel")) Then
                        If VerificarCantSel(Intopcion) > Me.IntCantMaxNotasCreditoRecibo Then
                            MsgBox("La cantidad de facturas seleccionadas, excede el máximo permitido.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                            Me.grdNotasCredito.Columns("Incluir").Value = False
                            Me.dtNotaCredito.AcceptChanges()
                            Me.grdNotasCredito.Refresh()
                            Exit Sub
                        End If
                    End If
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 12 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de realizar el proceso de conteo de facturas y 
    '---------------: notas de debitos incluidas en el recibo.
    '------------------------------------------------------------------------------------------
    Private Function VerificarCantSel(ByVal IntOpcion As Integer) As Integer

        Dim objCant As Object
        Try
            Select Case IntOpcion
                Case 0
                    objCant = Me.dtDetalleFact.Compute("Count(ActivoSel)", "ActivoSel='true'")
                    If Not IsDBNull(objCant) Then
                        Return objCant
                    Else
                        Return 0
                    End If


                Case 1
                    objCant = Me.dtDetalleNotDebt.Compute("Count(ActivoSel)", "ActivoSel='true'")
                    If Not IsDBNull(objCant) Then
                        Return objCant
                    Else
                        Return 0
                    End If


                Case 2
                    objCant = Me.dtNotaCredito.Compute("Count(ActivoSel)", "ActivoSel='true'")
                    If Not IsDBNull(objCant) Then
                        Return objCant
                    Else
                        Return 0
                    End If

            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
    '------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 12 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encargado de validar la seleccion de abonar cancelar y
    '---------------: de mandar a actualizar el descuento especifico segun la opcion checkeada.
    '------------------------------------------------------------------------------------------
    Private Sub ValidarAbonarCancelar()
        Dim boolInc As Boolean
        Dim boolAbonar As Boolean
        Dim boolCancelar As Boolean
        Dim IdFactura As Integer
        Dim intOpcionEnviar As Integer
        Dim dtFechaVenc As DateTime

        Try
            boolInc = Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("ActivoSel")
            boolAbonar = Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("Abonar")
            boolCancelar = Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("Cancelar")
            IdFactura = Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("SfaFacturaID")

            intOpcionEnviar = 0

            Select Case Me.grdFacturas.Col
                Case 0

                    Select Case boolInc
                        Case True
                            Me.boolInsercDirecta = False
                            Me.grdFacturas.Columns("Cancelar").Value = True
                            Me.grdFacturas.Columns("Retencion").Value = 0
                            Me.grdFacturas.Columns("Monto Abonar").Value = Me.CargarMonto(Me.ClienteID, Me.SucursalID, IdFactura)

                            dtFechaVenc = Me.grdFacturas.Columns("Fecha Vencimiento").Value
                            If dtFechaVenc.Date >= clsProyecto.Conexion.FechaServidor.Date Then
                                Me.grdFacturas.Columns("Desc. Especifico").Value = (Me.ObtenerDescEspecifico) / 100
                            End If


                        Case False
                            Me.boolInsercDirecta = False
                            Me.grdFacturas.Columns("Cancelar").Value = False
                            Me.grdFacturas.Columns("Abonar").Value = False
                            Me.grdFacturas.Columns("Monto Abonar").Value = 0.0
                            Me.grdFacturas.Columns("Desc. Especifico").Value = 0.0
                            Me.grdFacturas.Columns("Desc. Ocasional").Value = 0.0
                            Me.grdFacturas.Columns("Retención").Value = 0.0
                            Me.grdFacturas.Columns("Total").Value = 0.0

                    End Select

                Case 5
                    Me.boolInsercDirecta = False
                    Me.grdFacturas.Columns("Retencion").Value = 0
                    If (Me.grdFacturas.Columns("Incluir").Value = False) Then
                        Me.grdFacturas.Columns("Cancelar").Value = False
                        Me.grdFacturas.Columns("Abonar").Value = False
                        Exit Sub
                    End If
                    Select Case boolAbonar

                        Case True
                            Me.grdFacturas.Columns("Cancelar").Value = False
                            Me.grdFacturas.Columns("Monto Abonar").Value = 1
                            Me.grdFacturas.Columns("Desc. Especifico").Value = 0.0

                        Case False
                            Me.grdFacturas.Columns("Cancelar").Value = True
                            Me.grdFacturas.Columns("Monto Abonar").Value = Me.CargarMonto(Me.ClienteID, Me.SucursalID, IdFactura)
                            dtFechaVenc = Me.grdFacturas.Columns("Fecha Vencimiento").Value
                            If dtFechaVenc.Date >= clsProyecto.Conexion.FechaServidor.Date Then
                                Me.grdFacturas.Columns("Desc. Especifico").Value = (Me.ObtenerDescEspecifico) / 100
                            End If
                    End Select

                Case 6
                    Me.boolInsercDirecta = False
                    Me.grdFacturas.Columns("Retencion").Value = 0
                    If (Me.grdFacturas.Columns("Incluir").Value = False) Then
                        Me.grdFacturas.Columns("Cancelar").Value = False
                        Me.grdFacturas.Columns("Abonar").Value = False
                        Exit Sub
                    End If

                    Select Case boolCancelar

                        Case True
                            Me.grdFacturas.Columns("Monto Abonar").Value = Me.CargarMonto(Me.ClienteID, Me.SucursalID, IdFactura)
                            Me.grdFacturas.Columns("Abonar").Value = False
                            dtFechaVenc = Me.grdFacturas.Columns("Fecha Vencimiento").Value
                            If dtFechaVenc.Date >= clsProyecto.Conexion.FechaServidor.Date Then
                                Me.grdFacturas.Columns("Desc. Especifico").Value = (Me.ObtenerDescEspecifico) / 100
                            End If

                        Case False
                            Me.grdFacturas.Columns("Abonar").Value = True
                            Me.grdFacturas.Columns("Monto Abonar").Value = 1
                            Me.grdFacturas.Columns("Desc. Especifico").Value = 0.0
                    End Select
                Case 7
                    Me.boolInsercDirecta = True
                    If (Me.grdFacturas.Columns("Monto Abonar").Value > Me.grdFacturas.Columns("Saldo").Value) And boolAbonar = True Then
                        Me.grdFacturas.Columns("Monto Abonar").Value = 0.0
                    End If
                Case 9
                    Me.boolInsercDirecta = False
                Case 10
                    Me.boolInsercDirecta = True
            End Select
            AplicCalcularDesc_ESPOCRET()
            Me.dtDetalleFact.AcceptChanges()
            Me.grdFacturas.Refresh()
            CalcularTotales()


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 14 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de formatear el valor introducido en descuento ocasional
    '----------------: y retornar en valores decimales mayores que cero y menores que 1.
    '----------------------------------------------------------------------------------------------------------------------
    Private Function CalculoDescOcasional(ByVal ValorActual As Decimal) As Decimal
        Dim Valor As Decimal
        Try

            If ValorActual > 100 Then
                Valor = 0
                Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("DescOcasional") = Valor
            ElseIf ValorActual > 1 And ValorActual <= 100 Then
                Valor = ValorActual / 100
                Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("DescOcasional") = Valor

            ElseIf ValorActual >= 0 And ValorActual <= 1 Then
                Valor = ValorActual
                Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("DescOcasional") = Valor

            Else
                Valor = 0
                Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("DescOcasional") = Valor

            End If

            Return Valor
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    '----------------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 14 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de verificar que los montos asignados cumplan con los montos correspondientes
    '----------------: de acuerdo a las formas de pago.
    '----------------------------------------------------------------------------------------------------------------------
    Private Function ValidarMontosExactos() As Boolean
        Dim Boolrst As Boolean
        Dim DecMonto As Decimal = 0.0

        Try
            If Me.dtNotaCredito.DefaultView.Count > 0 Then
                For Each DrwNotDebt As DataRow In Me.dtDetalleNotDebt.Rows
                    If DrwNotDebt("ActivoSel") Then
                        DecMonto = DecMonto + DrwNotDebt("Monto")
                    End If
                Next
            End If

            For Each drwOtrForma As DataRow In Me.dtFormaPago.Rows
                If drwOtrForma.RowState <> DataRowState.Deleted Then
                    If Not IsDBNull(drwOtrForma("Monto")) Then
                        DecMonto = DecMonto + drwOtrForma("Monto")
                    End If
                End If
            Next

            If (Me.DecTotalRecibo - DecMonto) = 0 Then
                Boolrst = True
            Else
                Boolrst = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Boolrst
    End Function
    '-------------------------------------------------------------------------------------------------------------------
    Private Function ValidarDetalleFact() As Boolean
        Dim boolrst As Boolean
        Try
            boolrst = True
            For Each drw As DataRow In Me.dtDetalleFact.Rows
                If drw("ActivoSel") Then
                    If Not drw("Cancelar") And Not drw("Abonar") Then
                        boolrst = False
                        Exit For
                    End If
                End If
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return boolrst
    End Function

    '--------------------------------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado.
    'Fecha Creacion : 18 de Diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de realizar la verificacion de que los montos dentro de las formas de 
    '---------------: pago este correcto.
    '--------------------------------------------------------------------------------------------------------------------
    Private Function ProcesoVerificacionFormaPago() As Boolean
        Dim boolrst As Boolean
        Try
            boolrst = True
            If Not Me.dtFormaPago Is Nothing Then
                For Each drwFilas As DataRow In Me.dtFormaPago.Rows
                    If drwFilas.RowState <> DataRowState.Deleted Then
                        If drwFilas("CodFormPago") = "EFEC" Then
                            If drwFilas("Monto") = 0.0 Then
                                Me.ErrorProv.SetError(Me.lblError, "MontoIncorrecto")
                                boolrst = False
                                Exit For
                            End If
                        Else
                            If drwFilas("Monto") = 0.0 Or (drwFilas("Numero") = "Ninguno" Or drwFilas("Numero") = "") Or (drwFilas("IdEntidadN") = "Ninguna" Or drwFilas("IdEntidadN") = "") Then
                                Me.ErrorProv.SetError(Me.lblError, "Necesitas llenar todos los campos")
                                boolrst = False
                                Exit For
                            End If
                        End If
                        If drwFilas("CodFormPago") = "" Then
                            Exit For
                        End If
                    End If
                Next

            End If

            Return boolrst
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function


#End Region

#Region "Proceso de Guardado y modificado de recibo"

    '=========================================================================================================
    Private Function ObtenerZonaID(ByVal IntIDSucursal As Integer) As Integer
        Dim IntValor As Integer
        Dim objSucursal As New SccSucursal
        Try
            If objSucursal.Retrieve(IntIDSucursal) Then
                IntValor = (objSucursal.objZonaID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtSucursal = Nothing
        End Try
        Return IntValor
    End Function
    '=========================================================================================================

    '----------------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 14 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de realizar el proceso completo de guardado de los datos.
    '----------------------------------------------------------------------------------------------------------------------
    Private Function GuardarReciboCaja() As Boolean
        Dim Boolrst As Boolean
        Dim T As New TransactionManager
        Try
            Boolrst = False
            CalcularTotales()

            If (Me.DtpFecha.Value.Date > clsProyecto.Conexion.FechaServidor.Date) Then
                Me.ErrorProv.SetError(Me.DtpFecha, "Fecha Incorrecta")
                Exit Function
            End If

            If Not ProcesoVerificacionFormaPago() Then
                Exit Function
            End If

            If Not ValidarDetalleFact() Then
                Me.ErrorProv.SetError(Me.lblError, "Datos Imcompletos")
                Exit Function
            End If

            If (Decimal.Round(Me.DecTotalAbonado, 2) <> Decimal.Round(Me.DecTotalRecibo, 2)) Or (Me.txtTotalPagar.Value = 0) Then
                Me.ErrorProv.SetError(Me.lblError, "Montos no coinciden")
                Exit Function
            End If

            T.BeginTran()

            '--------------------------- Creamos el encabezado del recibo colector--------------------------
            Me.objReciboCaja = New SccReciboCaja
            Me.objReciboCaja.Numero = Convert.ToInt32(GeneraraNumero)
            Me.objReciboCaja.Fecha = Me.DtpFecha.Value.Date
            Me.objReciboCaja.objClienteID = Me.ClienteID
            Me.objReciboCaja.objSucursalID = Me.SucursalID
            Me.objReciboCaja.TotalFacturas = Me.DecTotalFact
            Me.objReciboCaja.TotalDescuento = Me.DecTotalDesc
            Me.objReciboCaja.TotalND = Me.DecTotalND
            Me.objReciboCaja.TotalRecibo = Me.DecTotalRecibo
            Me.objReciboCaja.TotalRetenido = Me.DecTotalRetenido
            Me.objReciboCaja.TotalEnEfectivo = Me.DecTotalEfect
            Me.objReciboCaja.TotalNC = Me.DecTotalNC
            Me.objReciboCaja.TotalCK = Me.DecTotalCK
            Me.objReciboCaja.TotalOtrosDocumentos = Me.DecTotalOtros
            Me.objReciboCaja.objZonaID = Me.ObtenerZonaID(Me.SucursalID)
            Me.objReciboCaja.UsuarioCreacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaCreacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.objEstadoID = ObtenerIDSTbCatalogo("EstadoROC", "REGISTRADO")
            '-----------------------------------------------------------------------------------------------
            Me.objReciboCaja.Insert(T)
            Me.ReciboCajaID = Me.objReciboCaja.SccReciboCajaID

            '-------------------Creamos los detalles por cada forma de pago registrada----------------------
            Me.objFormaPago = New SccReciboDetFormaPago
            For Each drwFormPagINC As DataRow In Me.dtFormaPago.Rows
                Me.objFormaPago.Monto = drwFormPagINC("Monto")
                If drwFormPagINC("CodFormPago") <> "EFEC" Then
                    Me.objFormaPago.Numero = drwFormPagINC("Numero")
                    Me.objFormaPago.objEntidadID = drwFormPagINC("IdEntidad")
                End If
                Me.objFormaPago.objFormaPagoID = drwFormPagINC("IdFormaPago")
                Me.objFormaPago.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                Me.objFormaPago.UsuarioCreacion = clsProyecto.Conexion.Usuario
                Me.objFormaPago.FechaCreacion = clsProyecto.Conexion.FechaServidor
                Me.objFormaPago.Insert(T)

            Next
            '---------------------------------------------------------------------------------------------

            '-----------------Creamos los detalles por cada factura procesada-----------------------------
            objReciboDetFactura = New SccReciboDetFactura
            For Each drwFactINC As DataRow In Me.dtDetalleFact.Rows
                If drwFactINC("ActivoSel") Then
                    objReciboDetFactura.Monto = drwFactINC("CantAbonar")
                    objReciboDetFactura.MontoDescEspecifico = drwFactINC("CantAbonar") * drwFactINC("DescEspecifico")
                    objReciboDetFactura.MontoDescOcasional = drwFactINC("CantAbonar") * drwFactINC("DescOcasional")
                    objReciboDetFactura.MontoRetencion = drwFactINC("Retencion")
                    objReciboDetFactura.MontoNeto = objReciboDetFactura.Monto - (objReciboDetFactura.MontoDescEspecifico + objReciboDetFactura.MontoDescOcasional + objReciboDetFactura.MontoRetencion)
                    objReciboDetFactura.objFacturaID = drwFactINC("SfaFacturaID")
                    objReciboDetFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objReciboDetFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objReciboDetFactura.DescEspecifico = drwFactINC("DescEspecifico")
                    objReciboDetFactura.DescOcasional = drwFactINC("DescOcasional")
                    If drwFactINC("Abonar") Then
                        objReciboDetFactura.EsAbono = True
                    Else
                        objReciboDetFactura.EsAbono = False
                    End If
                    Me.objReciboDetFactura.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                    objReciboDetFactura.Insert(T)

                End If
            Next
            '-------------------------------------------------------------------------------------------
            '---------------Creamos los detalles para las notas de debito-------------------------------

            Me.objDetNotaDebito = New SccReciboDetND
            For Each DrwNDINC As DataRow In Me.dtDetalleNotDebt.Rows
                If DrwNDINC("ActivoSel") Then
                    Me.objDetNotaDebito.objNotaDebitoID = DrwNDINC("SccNotaDebitoID")
                    Me.objDetNotaDebito.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                    Me.objDetNotaDebito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    Me.objDetNotaDebito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    Me.objDetNotaDebito.Insert(T)
                End If
            Next
            '-------------------------------------------------------------------------------------------
            '-----------------Creamos los detalles para las notas de credito----------------------------

            Me.objDetNotaCredito = New SccReciboDetNC
            For Each DrwNCINC As DataRow In Me.dtNotaCredito.Rows
                If DrwNCINC("ActivoSel") Then
                    Me.objDetNotaCredito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    Me.objDetNotaCredito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    Me.objDetNotaCredito.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                    Me.objDetNotaCredito.objNotaCreditoID = DrwNCINC("SccNotaCreditoID")
                    Me.objDetNotaCredito.Insert(T)
                End If
            Next
            '------------------------------------------------------------------------------
            T.CommitTran()


            '--------------En caso de ser una facturacion directa-----------------------------
            If Me.BoolFactDict Then
                Me.cmdProcesar.Enabled = False
                Me.PROCESAR_RECIBO(Me.objReciboCaja.SccReciboCajaID, 1)
            Else
                modSISPAN.ReservarRegistro("SccReciboCaja", Me.objReciboCaja.SccReciboCajaID)
                Me.cmdProcesar.Enabled = True
            End If
            '------------------------------------------------------------------------------

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            BloquearColumnasModoConsulta()
            clsProyecto.CargarTemaDefinido(Me)

            Me.cmdAceptar.Enabled = False
            Boolrst = True
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return Boolrst
    End Function

    '--------------------------------------------------------------------------------------------------------------------------
    ' Autor             : Pedro Pablo Tinoco
    ' Fecha Creacion    : 15 de diciembre de 2007
    ' Descripcion       : Esta funcion se encarga de realizar el proceso de modificacion de un recibo X.
    '--------------------------------------------------------------------------------------------------------------------------
    Private Function ModificarRecibo() As Boolean
        Dim boolRst As Boolean
        Dim dtFormaPagoTemp As New DataTable
        Dim dtDetalles As New DataTable
        Dim T As New TransactionManager

        If Not ProcesoVerificacionFormaPago() Then
            Exit Function
        End If

        If Not ValidarDetalleFact() Then
            Me.ErrorProv.SetError(Me.lblError, "Datos Incompletos.")
            Exit Function
        End If

        If (Decimal.Round(Me.DecTotalAbonado, 2) <> Decimal.Round(Me.DecTotalRecibo, 2)) Or (Me.txtTotalPagar.Value = 0) Then
            Me.ErrorProv.SetError(Me.lblError, "Montos no coinciden")
            Exit Function
        End If

        Try

            T.BeginTran()
            '---------------------------Actualizamos el recibo---------------------------------------
            Me.objReciboCaja = New SccReciboCaja
            Me.objReciboCaja.Retrieve(Me.ReciboCajaID)
            Me.objReciboCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.TotalFacturas = Me.DecTotalFact
            Me.objReciboCaja.TotalDescuento = Me.DecTotalDesc
            Me.objReciboCaja.TotalND = Me.DecTotalND
            Me.objReciboCaja.TotalRecibo = Me.DecTotalRecibo
            Me.objReciboCaja.TotalRetenido = Me.DecTotalRetenido
            Me.objReciboCaja.TotalEnEfectivo = Me.DecTotalEfect
            Me.objReciboCaja.TotalNC = Me.DecTotalNC
            Me.objReciboCaja.TotalCK = Me.DecTotalCK
            Me.objReciboCaja.TotalOtrosDocumentos = Me.DecTotalOtros
            Me.objReciboCaja.Update(T)

            '----------------------------Actualizamos las detalles de facturas-----------------------------------
            Me.objReciboDetFactura = New SccReciboDetFactura
            dtDetalles = SccReciboDetFactura.RetrieveDT("objReciboCajaID =" & Me.ReciboCajaID, , "objFacturaID")
            For Each drwDetFact As DataRow In Me.dtDetalleFact.Rows
                If drwDetFact("ActivoSel") Then
                    dtDetalles.DefaultView.RowFilter = "objFacturaID =" & drwDetFact("SfaFacturaID")

                    If dtDetalles.DefaultView.Count > 0 Then
                        '------------------Si la factura se encuentra entonces le aplicamos los cambios realizados------------------ 
                        'If drwDetFact.RowState = DataRowState.Modified Then
                        Me.objReciboDetFactura.RetrieveByFilter("objFacturaID=" & drwDetFact("SfaFacturaID") & " AND objReciboCajaID = " & Me.ReciboCajaID, T)
                        Me.objReciboDetFactura.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        Me.objReciboDetFactura.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        Me.objReciboDetFactura.Monto = drwDetFact("CantAbonar")
                        Me.objReciboDetFactura.MontoDescEspecifico = drwDetFact("CantAbonar") * drwDetFact("DescEspecifico")
                        Me.objReciboDetFactura.MontoDescOcasional = drwDetFact("CantAbonar") * drwDetFact("DescOcasional")
                        Me.objReciboDetFactura.MontoRetencion = drwDetFact("Retencion")
                        Me.objReciboDetFactura.MontoNeto = objReciboDetFactura.Monto - (objReciboDetFactura.MontoDescEspecifico + objReciboDetFactura.MontoDescOcasional + objReciboDetFactura.MontoRetencion)
                        Me.objReciboDetFactura.Update(T)
                        ' End If

                    Else
                        '-----------------Si la factura agregada es nueva entonces agregamos sus detalles------------------
                        objReciboDetFactura.Monto = drwDetFact("CantAbonar")
                        objReciboDetFactura.MontoDescEspecifico = drwDetFact("CantAbonar") * drwDetFact("DescEspecifico")
                        objReciboDetFactura.MontoDescOcasional = drwDetFact("CantAbonar") * drwDetFact("DescOcasional")
                        objReciboDetFactura.MontoRetencion = drwDetFact("Retencion")
                        objReciboDetFactura.MontoNeto = objReciboDetFactura.Monto - (objReciboDetFactura.MontoDescEspecifico + objReciboDetFactura.MontoDescOcasional + objReciboDetFactura.MontoRetencion)
                        objReciboDetFactura.objFacturaID = drwDetFact("SfaFacturaID")
                        objReciboDetFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objReciboDetFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        If drwDetFact("Abonar") Then
                            objReciboDetFactura.EsAbono = True
                        Else
                            objReciboDetFactura.EsAbono = False
                        End If
                        Me.objReciboDetFactura.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                        objReciboDetFactura.Insert(T)
                        '--------------------------------------------------------------------------------------------------
                    End If
                Else
                    '-------------En caso de que la factura fue quitada entonces la eliminamos su registro----------
                    dtDetalles.DefaultView.RowFilter = "objFacturaID =" & drwDetFact("SfaFacturaID")
                    If dtDetalles.DefaultView.Count > 0 Then
                        strfiltro = "objFacturaID =" + Convert.ToString(drwDetFact("SfaFacturaID")) + " AND objReciboCajaID = " + Convert.ToString(Me.ReciboCajaID)
                        SccReciboDetFactura.DeleteByFilter(strfiltro, T)
                    End If
                    '----------------------------------------------------------------------------------------------
                End If
            Next

            '----------------------Actualizamos los detalles de las notas de debitos-----------------------------------

            Me.objDetNotaDebito = New SccReciboDetND
            dtDetalles.Reset()
            dtDetalles = SccReciboDetND.RetrieveDT("objReciboCajaID=" & Me.ReciboCajaID, , "objNotaDebitoID")
            For Each drwDetND As DataRow In Me.dtDetalleNotDebt.Rows
                If drwDetND("ActivoSel") Then
                    dtDetalles.DefaultView.RowFilter = "objNotaDebitoID =" & drwDetND("SccNotaDebitoID")
                    If dtDetalles.DefaultView.Count > 0 Then
                        If drwDetND.RowState = DataRowState.Modified Then
                            strfiltro = "objReciboCajaID= " + Convert.ToString(Me.ReciboCajaID) + " AND " + "objNotaDebitoID =" + Convert.ToString(drwDetND("SccNotaDebitoID"))
                            Me.objDetNotaDebito.RetrieveByFilter(strfiltro, T)
                            Me.objDetNotaDebito.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            Me.objDetNotaDebito.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            Me.objDetNotaDebito.Update(T)
                        End If

                    Else
                        Me.objDetNotaDebito.objReciboCajaID = Me.ReciboCajaID
                        Me.objDetNotaDebito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        Me.objDetNotaDebito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        Me.objDetNotaDebito.objNotaDebitoID = drwDetND("SccNotaDebitoID")
                        Me.objDetNotaDebito.Insert(T)
                    End If
                Else
                    dtDetalles.DefaultView.RowFilter = "objNotaDebitoID =" & drwDetND("SccNotaDebitoID")
                    If dtDetalles.DefaultView.Count > 0 Then
                        strfiltro = "objNotaDebitoID =" + Convert.ToString(drwDetND("SccNotaDebitoID")) + " AND objReciboCajaID =" + Convert.ToString(Me.ReciboCajaID)
                        SccReciboDetND.DeleteByFilter(strfiltro, T)

                    End If
                End If
            Next
            '---------------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------

            '---------------------------------Actualimamos las notas de creditos--------------------------------------------
            dtDetalles.Reset()
            Me.objDetNotaCredito = New SccReciboDetNC
            dtDetalles = SccReciboDetNC.RetrieveDT("objReciboCajaID=" & Me.ReciboCajaID, , "objNotaCreditoID")
            For Each drwDetNC As DataRow In Me.dtNotaCredito.Rows
                If drwDetNC("ActivoSel") Then
                    dtDetalles.DefaultView.RowFilter = "objNotaCreditoID =" & drwDetNC("SccNotaCreditoID")
                    If dtDetalles.DefaultView.Count > 0 Then
                        If drwDetNC.RowState = DataRowState.Modified Then
                            strfiltro = "objReciboCajaID= " + Convert.ToString(Me.ReciboCajaID) + " AND " + "objNotaCreditoID =" + Convert.ToString(drwDetNC("SccNotaCreditoID"))
                            Me.objDetNotaCredito.RetrieveByFilter(strfiltro, T)
                            Me.objDetNotaCredito.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            Me.objDetNotaCredito.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            Me.objDetNotaCredito.Update(T)
                        End If
                    Else
                        Me.objDetNotaCredito.objReciboCajaID = Me.ReciboCajaID
                        Me.objDetNotaCredito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        Me.objDetNotaCredito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        Me.objDetNotaCredito.objNotaCreditoID = drwDetNC("SccNotaCreditoID")
                        Me.objDetNotaCredito.Insert(T)
                    End If
                Else
                    dtDetalles.DefaultView.RowFilter = "objNotaCreditoID =" & drwDetNC("SccNotaCreditoID")
                    If dtDetalles.DefaultView.Count > 0 Then
                        strfiltro = "objNotaCreditoID =" + Convert.ToString(drwDetNC("SccNotaCreditoID")) + " AND objReciboCajaID =" + Convert.ToString(Me.ReciboCajaID)
                        SccReciboDetNC.DeleteByFilter(strfiltro, T)
                    End If
                End If
            Next
            '---------------------------------------------------------------------------------------------------------------------

            '-----------------------------------Actualizamos las formas de pago---------------------------------------------------
            dtDetalles.Reset()
            dtFormaPagoTemp = Me.dtFormaPago.Copy
            Me.objFormaPago = New SccReciboDetFormaPago
            dtDetalles = SccReciboDetFormaPago.RetrieveDT("objReciboCajaID=" & Me.ReciboCajaID, , "objFormaPagoID")
            For Each drwDetFormPago As DataRow In dtFormaPagoTemp.Rows
                If drwDetFormPago.RowState <> DataRowState.Deleted Then
                    dtDetalles.DefaultView.RowFilter = "objFormaPagoID =" & drwDetFormPago("IdFormaPago")
                    If dtDetalles.DefaultView.Count > 0 Then

                        If drwDetFormPago.RowState = DataRowState.Modified Then
                            strfiltro = "objReciboCajaID = " + Convert.ToString(Me.ReciboCajaID) + " AND " + "objFormaPagoID =" + Convert.ToString(drwDetFormPago("IdFormaPago"))
                            Me.objFormaPago.RetrieveByFilter(strfiltro, T)
                            Me.objFormaPago.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            Me.objFormaPago.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            Me.objFormaPago.Monto = drwDetFormPago("Monto")
                            If drwDetFormPago("CodFormPago") <> "EFEC" Then
                                Me.objFormaPago.Numero = drwDetFormPago("Numero")
                                Me.objFormaPago.objEntidadID = drwDetFormPago("IdEntidad")
                            End If
                            Me.objFormaPago.Update(T)
                        End If
                    Else
                        Me.objFormaPago.objReciboCajaID = Me.ReciboCajaID
                        Me.objFormaPago.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        Me.objFormaPago.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        Me.objFormaPago.objFormaPagoID = drwDetFormPago("IdFormaPago")
                        Me.objFormaPago.Monto = drwDetFormPago("Monto")
                        If drwDetFormPago("CodFormPago") <> "EFEC" Then
                            Me.objFormaPago.Numero = drwDetFormPago("Numero")
                            Me.objFormaPago.objEntidadID = drwDetFormPago("IdEntidad")
                        End If
                        Me.objFormaPago.Insert(T)
                    End If
                End If
            Next
            '-----------------Realizamos el proceso de eliminacion de los registros que ya no estan agregados----------------------
            For Each drwElim As DataRow In dtDetalles.Rows
                dtFormaPago.DefaultView.RowFilter = "IdFormaPago= " & drwElim("objFormaPagoID")
                If Me.dtFormaPago.DefaultView.Count = 0 Then
                    strfiltro = "objReciboCajaID = " + Convert.ToString(Me.ReciboCajaID) + " AND " + "objFormaPagoID =" + Convert.ToString(drwElim("objFormaPagoID"))
                    SccReciboDetFormaPago.DeleteByFilter(strfiltro, T)
                End If
            Next
            dtFormaPagoTemp.DefaultView.RowFilter = "1=1"
            '----------------------------------------------------------------------------------------------------------
            T.CommitTran()

            Me.grdOtraFormaPago.SetDataBinding(dtFormaPagoTemp, "", True)
            BloquearColumnasModoConsulta()
            clsProyecto.CargarTemaDefinido(Me)
            Me.cmdProcesar.Enabled = True
            Me.cmdAceptar.Enabled = False
            boolRst = True
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            dtFormaPagoTemp = Nothing
            dtDetalles = Nothing
            T = Nothing
        End Try
        Return boolRst
    End Function
    '------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 14 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de realizar el procesamiento de los datos una vez que se haya guardado.
    '------------------------------------------------------------------------------------------------------------
    Private Sub PROCESAR_RECIBO(ByVal IntIDReciboCaja As Integer, ByVal IntOpcion As Integer)
        Dim parametro As SqlClient.SqlParameter
        Dim T As New TransactionManager
        Me.objNotCredito = New SccNotaCredito

        Try

            T.BeginTran()

            parametro = New SqlClient.SqlParameter("@IntReciboCajaID", SqlDbType.Int, 4)
            parametro.Value = IntIDReciboCaja
            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_SfaDimininuirCuentaPorCobrar", parametro)

            Me.objReciboCaja.Retrieve(IntIDReciboCaja, T)

            Me.objReciboCaja.objEstadoID = Me.ObtenerIDSTbCatalogo("EstadoROC", "PAGADO")
            Me.objReciboCaja.Update(T)

            For Each DRWNotCredt As DataRow In Me.dtNotaCredito.Rows
                If DRWNotCredt("ActivoSel") Then
                    Me.objNotCredito.Retrieve(DRWNotCredt("SccNotaCreditoID"), T)
                    Me.objNotCredito.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Me.objNotCredito.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Me.objNotCredito.objEstadoID = Me.ObtenerIDSTbCatalogo("EstadoNC", "PAGADA")
                    Me.objNotCredito.Update(T)
                End If
            Next

            T.CommitTran()
            Me.cmdAceptar.Enabled = False
            Me.cmdProcesar.Enabled = False
            If MsgBox("¿Desea imprimir reporte del recibo?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.ImprimirReporte(IntIDReciboCaja)
            End If
            Me.Close()

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing
            T = Nothing
            Me.objNotCredito = Nothing
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------
    ' Autor           : Pedro Tinoco Salgado.
    ' Fecha Creacion  : 16 de diciembre de 2007.
    ' Descripcion     : Esta funcion se encarga de retornarme el id de los estados y de otros catalogos.
    '--------------------------------------------------------------------------------------------------------------
    Private Function ObtenerIDSTbCatalogo(ByVal strNombCatalogo As String, ByVal strEstado As String) As Integer
        Dim dtstbCatalogo As New DataTable
        Dim dtstbValorCatalogo As New DataTable
        Dim IntValorID As Integer

        Try
            dtstbCatalogo = StbCatalogo.RetrieveDT("Nombre= " + "'" + strNombCatalogo + "'" + "", , "StbCatalogoID")
            If dtstbCatalogo.DefaultView.Count > 0 Then
                dtstbValorCatalogo = StbValorCatalogo.RetrieveDT("objCatalogoID=" + Convert.ToString(dtstbCatalogo.DefaultView.Item(0)("StbCatalogoID")) + " AND " + "Codigo = " + "" + "'" + strEstado + "'" + "", , "StbValorCatalogoID")
                IntValorID = dtstbValorCatalogo.DefaultView.Item(0)("StbValorCatalogoID")
            End If
            Return IntValorID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Eventos sobre Controles"
    Private Sub cmbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.CargarSucursales(Me.ClienteID)
    End Sub

    Private Sub grdFacturas_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdFacturas.AfterColEdit
        Dim IDFactura As Integer
        IDFactura = Me.dtDetalleFact.DefaultView.Item(Me.grdFacturas.Row)("SfaFacturaID")

        If IsDBNull(Me.grdFacturas.Columns("Desc. Ocasional").Value) Then
            Me.grdFacturas.Columns("Desc. Ocasional").Value = 0.0
        ElseIf ((Me.grdFacturas.Columns("Desc. Ocasional").Value) < 0) Then
            Me.grdFacturas.Columns("Desc. Ocasional").Value = 0.0
        End If

        If (Me.grdFacturas.Columns("Cancelar").Value = True) And (IsDBNull(Me.grdFacturas.Columns("Monto Abonar").Value)) Then
            Me.grdFacturas.Columns("Monto Abonar").Value = Me.CargarMonto(Me.ClienteID, Me.SucursalID, IDFactura)
        End If

        If IsDBNull(Me.grdFacturas.Columns("Monto Abonar").Value) And Me.grdFacturas.Columns("Incluir").Value = True Then
            Me.grdFacturas.Columns("Monto Abonar").Value = 1
        ElseIf IsDBNull(Me.grdFacturas.Columns("Monto Abonar").Value) And Me.grdFacturas.Columns("Incluir").Value = False Then
            Me.grdFacturas.Columns("Monto Abonar").Value = 0
        ElseIf Not IsDBNull(Me.grdFacturas.Columns("Monto Abonar").Value) And (Me.grdFacturas.Columns("Monto Abonar").Value) < 0 Then
            Me.grdFacturas.Columns("Monto Abonar").Value = 0.0
        End If

        If IsDBNull(Me.grdFacturas.Columns("Retención").Value) Then
            Me.grdFacturas.Columns("Retención").Value = 0.0
        ElseIf Me.grdFacturas.Columns("Retención").Value < 0 Then
            Me.grdFacturas.Columns("Retención").Value = 0.0
        End If
        Me.ValidarCantFactDebtSel(0)
        Me.ValidarAbonarCancelar()
        If Me.cmdAceptar.Enabled = False Then
            Me.cmdAceptar.Enabled = True
        End If
        boolCambioHecho = True
    End Sub


    Private Sub grdNotaDebito_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotaDebito.AfterColEdit
        Select Case Me.grdNotaDebito.Columns("Incluir").Value
            Case True
                Me.dtDetalleNotDebt.DefaultView.Item(Me.grdNotaDebito.Row)("ActivoSel") = True
            Case False
                Me.dtDetalleNotDebt.DefaultView.Item(Me.grdNotaDebito.Row)("ActivoSel") = False
        End Select
        Me.dtDetalleNotDebt.AcceptChanges()
        Me.ValidarCantFactDebtSel(1)
        CalcularTotales()
        boolCambioHecho = True
        If Me.cmdAceptar.Enabled = False Then
            Me.cmdAceptar.Enabled = True
        End If
    End Sub

    Private Sub grdFacturas_Error(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ErrorEventArgs) Handles grdFacturas.Error
        e.Handled = True
        e.Continue = True
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If boolCambioHecho And Me.cmdAceptar.Enabled = True Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.GuardarReciboCaja()
            Else

                Me.Close()
            End If
        Else

            Me.Close()
        End If
    End Sub

    '------------------------------Asignacion de Valores al Datatable OtraFormaPago-------------------------------

    Private Sub CTdbFormaPago_DropDownClose(ByVal sender As Object, ByVal e As System.EventArgs) Handles CTdbFormaPago.DropDownClose
        Try
            Me.grdOtraFormaPago.Columns("IdFormaPago").Value = Me.CTdbFormaPago.Columns("StbValorCatalogoID").Value
            Me.grdOtraFormaPago.Columns("CodFormaPago").Value = Me.CTdbFormaPago.Columns("CodFormPago").Value

            If Not IsDBNull(Me.grdOtraFormaPago.Columns("Forma de Pago").Value()) Then
                If (Me.grdOtraFormaPago.Columns("Forma de Pago").Value() = "0") Then
                    Me.grdOtraFormaPago.Columns("Forma de Pago").Value = Me.CTdbFormaPago.Columns("Descripcion").Value
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub CTdbEntidadBanc_DropDownClose(ByVal sender As Object, ByVal e As System.EventArgs) Handles CTdbEntidadBanc.DropDownClose
        Me.grdOtraFormaPago.Columns("IdEntidad").Value = Me.CTdbEntidadBanc.Columns("StbValorCatalogoID").Value
    End Sub

    Private Sub grdOtraFormaPago_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdOtraFormaPago.AfterColEdit

        If IsDBNull(Me.grdOtraFormaPago.Columns("Monto Ingresado").Value) Then
            Me.grdOtraFormaPago.Columns("Monto Ingresado").Value = 0
        ElseIf Me.grdOtraFormaPago.Columns("Monto Ingresado").Value < 0 Then
            Me.grdOtraFormaPago.Columns("Monto Ingresado").Value = 0
        End If

        boolCambioHecho = True
        If Me.cmdAceptar.Enabled = False Then
            Me.cmdAceptar.Enabled = True
        End If
        Me.CalcularTotales()

    End Sub

    '---------------------------------------------------------------------------------------------------------
    Private Sub grdOtraFormaPago_Error(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ErrorEventArgs) Handles grdOtraFormaPago.Error
        e.Handled = True
        e.Continue = True
    End Sub

    '-------------------------------------------------------------------------------------------------
    ' Descripcion    : En este procedimiento se realiza el control de ingreso de datos en el grid.
    ' Fecha Creacion : 13 de diciembre de 2007.
    '-------------------------------------------------------------------------------------------------
    Private Sub grdOtraFormaPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdOtraFormaPago.KeyPress

        Dim intCol As Integer
        Dim intRow As Integer

        intRow = Me.grdOtraFormaPago.Row
        intCol = Me.grdOtraFormaPago.Col

        Select Case intCol
            Case 0
                If Not Asc(e.KeyChar) = 13 Then
                    e.Handled = True
                    e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                    Exit Sub
                End If

            Case 2
                If Not Asc(e.KeyChar) = 13 Then
                    If IsDBNull(Me.grdOtraFormaPago.Columns("Forma de Pago").Value) Then
                        e.Handled = True
                        e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                        Exit Sub
                    End If
                    If Not IsDBNull(Me.grdOtraFormaPago.Columns("CodFormaPago").Value) Then
                        If Me.grdOtraFormaPago.Columns("CodFormaPago").Value = "EFEC" Then
                            e.Handled = True
                            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                            Exit Sub
                        End If
                    End If
                End If
            Case 1
                If Not Asc(e.KeyChar) = 13 Then
                    If IsDBNull(Me.grdOtraFormaPago.Columns("Forma de Pago").Value) Then
                        e.Handled = True
                        e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                        Exit Sub
                    End If
                End If
            Case 3
                If Asc(e.KeyChar) = 13 Then
                    Me.grdOtraFormaPago.Col = 0
                    Me.grdOtraFormaPago.Row = Me.grdOtraFormaPago.Row + 1
                Else
                    e.Handled = True
                    e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                    Exit Sub
                End If

        End Select
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.BoolFactDict Then
            Me.GuardarReciboCaja()
            Exit Sub
        End If

        Select Case Me.TipoGUID
            Case 0
                Me.GuardarReciboCaja()
            Case 1
                If Me.ModificarRecibo() Then
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
        End Select
    End Sub

    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        If MsgBox("¿Esta seguro de procesar el Recibo?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
            Me.PROCESAR_RECIBO(Me.objReciboCaja.SccReciboCajaID, 0)
        Else
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click

        If Me.grdOtraFormaPago.Row = Me.dtFormaPago.DefaultView.Count Then
            MsgBox("Imposible Eliminar. La fila esta vacía.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Exit Sub
        End If

        If Me.dtFormaPago.DefaultView.Count > 0 Then
            Me.dtFormaPago.Rows(Me.grdOtraFormaPago.Row).Delete()
        End If
    End Sub

    Private Sub grdOtraFormaPago_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdOtraFormaPago.RowColChange
        If boolFalla Then
            Me.grdOtraFormaPago.Col = Me.grdOtraFormaPago.Col
            Me.grdOtraFormaPago.MoveRelative(0, rwCurrent)
            Exit Sub
        End If
        CalculoMontoAbonado()
    End Sub

    Private Sub grdFacturas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdFacturas.GotFocus
        Me.ErrorProv.Clear()
    End Sub

    Private Sub grdNotaDebito_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdNotaDebito.GotFocus
        Me.ErrorProv.Clear()
    End Sub

    Private Sub grdNotasCredito_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotasCredito.AfterColEdit
        Select Case Me.grdNotasCredito.Columns("Incluir").Value
            Case True
                Me.dtNotaCredito.DefaultView.Item(Me.grdNotasCredito.Row)("ActivoSel") = True
            Case False
                Me.dtNotaCredito.DefaultView.Item(Me.grdNotasCredito.Row)("ActivoSel") = False
        End Select
        Me.dtNotaCredito.AcceptChanges()

        Me.ValidarCantFactDebtSel(2)
        CalculoMontoAbonado()
        boolCambioHecho = True
        If Me.cmdAceptar.Enabled = False Then
            Me.cmdAceptar.Enabled = True
        End If
        Me.CalcularTotales()
    End Sub

    Private Sub grdNotasCredito_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotasCredito.AfterColUpdate
    End Sub

    Private Sub grdNotasCredito_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdNotasCredito.AfterUpdate
        CalculoMontoAbonado()
    End Sub

    Private Sub grdNotasCredito_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdNotasCredito.GotFocus

        Me.ErrorProv.Clear()
    End Sub
    Private Sub grdOtraFormaPago_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdOtraFormaPago.GotFocus
        Me.ErrorProv.Clear()
    End Sub
    Private Sub grdFacturas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdFacturas.KeyPress
        Dim boolInc As Boolean
        Dim boolCancelar As Boolean
        Dim IntCol As Integer
        boolInc = Me.grdFacturas.Columns("Incluir").Value
        boolCancelar = Me.grdFacturas.Columns("Cancelar").Value
        IntCol = Me.grdFacturas.Col

        Select Case boolInc
            Case True
                Select Case IntCol
                    Case 7
                        If boolCancelar Then
                            e.Handled = True
                            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                            Exit Sub
                        End If

                    Case 9
                        If Not (Me.grdFacturas.Columns("Fecha Vencimiento").Value < clsProyecto.Conexion.FechaServidor) Then
                            e.Handled = True
                            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                            Exit Sub
                        End If

                    Case 10
                End Select

            Case False
                e.Handled = True
                e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                Exit Sub
        End Select
    End Sub

    Private Sub DtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFecha.ValueChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub CTdbFormaPago_RowChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles CTdbFormaPago.RowChange
        Me.grdOtraFormaPago.Columns("Número").Value = "Ninguno"
        Me.grdOtraFormaPago.Columns("Entidad").Value = "Ninguna"
    End Sub

    Private Sub CTdbEntidadBanc_DropDownOpen(ByVal sender As Object, ByVal e As System.EventArgs) Handles CTdbEntidadBanc.DropDownOpen
        If Me.grdOtraFormaPago.Columns("CodFormaPago").Value = "EFEC" Then
            Me.grdOtraFormaPago.Columns("Entidad").DropDown.Enabled = False
        Else
            Me.grdOtraFormaPago.Columns("Entidad").DropDown.Enabled = True
        End If
    End Sub

    Private Sub cmdBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarCliente.Click
        Me.BuscarCliente()
    End Sub

    Private Sub cmdBuscarSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BuscarSucursal()
    End Sub

#End Region

#Region "Datos Relacionados"
    '--------------------------------------------------------------------------------------------------------------
    ' Autor           : Pedro Tinoco.
    ' Fecha Creacion  : 15 de diciembre de 2007.
    ' Descripcion     : Esta funcion se encarga de realizar el proceso de actualizar y poner en estado seleccionado
    '-----------------: todos aquellos detalles que fueron incluidos cuando se creo el recibo.
    '--------------------------------------------------------------------------------------------------------------
    Private Sub DetallesAgregados()
        Dim dtTablaProv As New DataTable
        Try

            '-----------------------------Verificacion de las facturas --------------------------------------------
            dtTablaProv = SccReciboDetFactura.RetrieveDT("objReciboCajaID = " & Me.ReciboCajaID, , "objFacturaID,EsAbono,DescEspecifico,DescOcasional,MontoRetencion,objReciboCajaID,Monto,MontoNeto")
            If dtTablaProv.DefaultView.Count > 0 Then
                For Each drwDetAct As DataRow In Me.dtDetalleFact.Rows
                    dtTablaProv.DefaultView.RowFilter = "objFacturaID=" & drwDetAct("SfaFacturaID")
                    If dtTablaProv.DefaultView.Count <> 0 Then
                        If dtTablaProv.DefaultView.Item(0)("EsAbono") Then
                            drwDetAct("Abonar") = True
                        Else
                            drwDetAct("Cancelar") = True
                        End If
                        drwDetAct("CantAbonar") = dtTablaProv.DefaultView.Item(0)("Monto")
                        drwDetAct("Retencion") = dtTablaProv.DefaultView.Item(0)("MontoRetencion")
                        drwDetAct("CantPagar") = dtTablaProv.DefaultView.Item(0)("MontoNeto")
                        drwDetAct("DescEspecifico") = dtTablaProv.DefaultView.Item(0)("DescEspecifico")
                        drwDetAct("DescOcasional") = dtTablaProv.DefaultView.Item(0)("DescOcasional")
                        drwDetAct("ActivoSel") = True
                    End If
                Next
                '-----------------------------------------------------------------------------------------------------
            End If
            CalcularTotales()
            '----------------------------------Veficacion de las notas de debito--------------------------------
            dtTablaProv.Reset()
            dtTablaProv = SccReciboDetND.RetrieveDT("objReciboCajaID =" & Me.ReciboCajaID, , "objNotaDebitoID")
            If dtTablaProv.DefaultView.Count > 0 Then
                For Each drwDtND As DataRow In Me.dtDetalleNotDebt.Rows
                    dtTablaProv.DefaultView.RowFilter = "objNotaDebitoID = " & drwDtND("SccNotaDebitoID")
                    If dtTablaProv.DefaultView.Count > 0 Then
                        drwDtND("ActivoSel") = True
                    End If
                Next
            End If
            '---------------------------------------------------------------------------------------------------------

            dtTablaProv.Reset()

            '---------------------------------Verificacion de las notas de credito-------------------------------------

            dtTablaProv = SccReciboDetNC.RetrieveDT("objReciboCajaID =" & Me.ReciboCajaID, , "objNotaCreditoID")
            If dtTablaProv.DefaultView.Count > 0 Then
                For Each drwDtND As DataRow In Me.dtNotaCredito.Rows
                    dtTablaProv.DefaultView.RowFilter = "objNotaCreditoID =" & drwDtND("SccNotaCreditoID")
                    If dtTablaProv.DefaultView.Count > 0 Then
                        drwDtND("ActivoSel") = True
                    End If
                Next
            End If
            '---------------------------------------------------------------------------------------------------------

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtTablaProv = Nothing
        End Try

    End Sub

    '--------------------------------------------------------------------------------------------------------------
    ' Autor           : Pedro Tinoco Salgado.
    ' Fecha Creacion  : 15 de diciembre de 2007.
    ' Descripcion     : Esta funcion se encarga de ir a generar el numero del recibo creado.
    '--------------------------------------------------------------------------------------------------------------
    Private Function GeneraraNumero() As String
        Dim strNum As String
        Dim dtNum As New DataTable
        Dim dtValParam As New DataTable
        Dim intNCeros As Integer
        Dim intNumero As Integer
        strNum = ""
        Try
            dtValParam = StbParametro.RetrieveDT("Nombre = 'CerosRellenoReciboCaja'", , "Valor")
            If dtValParam.DefaultView.Count > 0 Then
                intNCeros = dtValParam.DefaultView.Item(0)("Valor")
            End If
            dtNum = SccReciboCaja.RetrieveDT(, , "COUNT(*) AS Cantidad,MAX(Numero) as NumeroMax")
            If dtNum.DefaultView.Item(0)("Cantidad") = 0 Then
                For Cant As Integer = 1 To intNCeros - 1
                    strNum = strNum + "0"
                Next
                strNum = strNum + "1"
            Else
                intNumero = dtNum.DefaultView.Item(0)("NumeroMax") + 1
                intNCeros = intNCeros - intNumero.ToString.Length
                For Cant As Integer = 1 To intNCeros
                    strNum = strNum + "0"
                Next
                strNum = strNum + intNumero.ToString
            End If
            Return strNum
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtNum = Nothing
            dtValParam = Nothing
        End Try
        Return strNum
    End Function


#End Region

#Region "Impresion Reportes"
    '--------------------------------------------------------------------------------------------------------------
    ' Autor           : Pedro Tinoco Salgado.
    ' Fecha Creacion  : 15 de diciembre de 2007.
    ' Descripcion     : Esta funcion se encarga de imprimir el reporte correspondiente al Recibo procesado.
    '--------------------------------------------------------------------------------------------------------------
    Private Sub ImprimirReporte(ByVal IntIdReciboCajaID)

        Dim RCaja As Integer
        Dim objfrm As frmParamImpDestinoReporte
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmParamImpDestinoReporte
            RCaja = IntIdReciboCajaID

            '-- Pasar el nombre del formulario de reporte al formulario de destino del reporte
            objfrm.rptNombre = "rptSccReciboCaja"
            objfrm.ReciboCajaID = RCaja
            objfrm.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Liberacion de Recursos"

    Private Sub LiberarRecursos()
        Try
            '----------------------Liberamos Datatables--------------------------
            dtDetalleFact = Nothing
            dtDetalleNotDebt = Nothing
            dtClientes = Nothing
            dtSucursal = Nothing
            dtNotaCredito = Nothing
            dtFormaPago = Nothing
            '--------------------------------------------------------------------

            '---------------------Liberamos los objetos de Clases de BD----------
            objReciboCaja = Nothing
            objReciboDetFactura = Nothing
            objFormaPago = Nothing
            objDetNotaDebito = Nothing
            objDetNotaCredito = Nothing
            objNotCredito = Nothing
            '--------------------------------------------------------------------


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Busqueda Datos"
    '--------------------------------------------------------------------------------------------------------------- 
    'Autor          : Pedro Pablo Tinoco Salgado.
    'Fecha Creacion : 19 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de realizar la busqueda de los clientes con respecto al empleado.
    '--------------------------------------------------------------------------------------------------------------- 
    Private Sub BuscarCliente()
        Dim dtEmpCargo As New DataTable
        Dim IntValID As Integer = 0
        Dim intValIDN As Integer = 0
        Dim frmClientes As frmSfaEscogerCliente
        Dim varClienteTemp As Integer

        Try
            strfiltro = "ActivoCliente = 'true' AND SucursalActivo ='True'"
            varClienteTemp = Me.ClienteID
            frmClientes = New frmSfaEscogerCliente
            frmClientes.TipoFiltroCliente = strfiltro
            frmClientes.ShowDialog(Me)

            If frmClientes.TipoClienteID <> 0 Then
                Me.ClienteID = frmClientes.TipoClienteID
                Me.txtCliente.Text = frmClientes.TipoNombreCliente
                Me.SucursalID = frmClientes.TipoSucursalID
                Me.txtSucursal.Text = frmClientes.TipoSucursalNomb

                Me.BoolCredCent = Me.ObtenerTipoCredito(Me.ClienteID)
                If (Not Me.dtDetalleFact Is Nothing) Then
                    Me.ReservarFacturas(1)
                    Me.dtDetalleFact.Reset()
                End If

                If Not Me.dtDetalleNotDebt Is Nothing Then
                    Me.ReservarNotasDebito(1)
                    Me.dtDetalleNotDebt.Reset()
                End If

                If Not Me.dtNotaCredito Is Nothing Then
                    Me.ReservarNotasCredito(1)
                    Me.dtNotaCredito.Reset()
                End If

                Me.CargarDetalleFacturas(Me.ClienteID, Me.SucursalID)
                Me.CargarNotaDebito(Me.ClienteID, Me.SucursalID)
                Me.CargarNotasdeCredito(Me.ClienteID, Me.SucursalID)
                Me.tbControl.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtEmpCargo = Nothing
            frmClientes = Nothing
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------- 
    'Autor          : Pedro Pablo Tinoco Salgado.
    'Fecha Creacion : 19 de diciembre de 2007.
    'Descripcion    : Este procedimiento se encarga de realizar la busqueda de las sucursales a partir del cliente seleccionado.
    '--------------------------------------------------------------------------------------------------------------- 
    Private Sub BuscarSucursal()
        Dim FrmBuscSucursal As frmSccObtenerSucursal
        Try
            FrmBuscSucursal = New frmSccObtenerSucursal
            FrmBuscSucursal.IdCliente = Me.ClienteID
            FrmBuscSucursal.ShowDialog(Me)

            If FrmBuscSucursal.boolCambioHecho = True Then
                If FrmBuscSucursal.IntSucursalID <> 0 Then
                    Me.txtSucursal.Text = FrmBuscSucursal.NombSucursal
                    Me.SucursalID = FrmBuscSucursal.IntSucursalID
                    If Not Me.dtDetalleFact Is Nothing Then
                        Me.ReservarFacturas(1)
                        Me.dtDetalleFact.Reset()
                    End If

                    If Not Me.dtDetalleNotDebt Is Nothing Then
                        Me.ReservarNotasDebito(1)
                        Me.dtDetalleNotDebt.Reset()
                    End If

                    If Not Me.dtNotaCredito Is Nothing Then
                        Me.ReservarNotasCredito(1)
                        Me.dtNotaCredito.Reset()
                    End If

                    Me.CargarDetalleFacturas(Me.ClienteID, Me.SucursalID)
                    Me.CargarNotaDebito(Me.ClienteID, Me.SucursalID)
                    Me.CargarNotasdeCredito(Me.ClienteID, Me.SucursalID)
                    Me.tbControl.Enabled = True
                    If Not boolConsulta Then
                        Me.cmdAceptar.Enabled = True
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            FrmBuscSucursal = Nothing
        End Try

    End Sub


#End Region

    Private Sub grdFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdFacturas.Click

    End Sub
End Class