
Imports DAL
Imports Proyecto.Configuracion
Imports SCCUM.BO
Imports Proyecto.Catalogos.Datos
Imports System.Data.SqlClient

''' <summary>
''' Formulario Principal de Carga y Guardado de Facturas.
''' Autor : Pedro Pablo Tinoco
''' Fecha : 21 de Marzo de 2009.
''' </summary>
''' <remarks></remarks>
''' 
Public Class frmSfaFaturaEditar
    Dim m_IDFactura As Integer
    Dim m_TypGui As Integer
    Dim DtDatosModelos, dtTerminoPlazo, dtEstado, dtClasificacion As DataTable
    Dim DtDatosMarcas As DataTable
    Dim DtDatosConcepto As DataTable
    Dim DtEmpleados As DataTable
    Dim DtTienda As New DataTable
    Dim objFact As SfaFactura
    Dim m_ConceptoMoto As Integer
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim DtDatosPlazos As DataTable
    Dim m_IdPlazo As Integer
    Dim m_IDClasificacion As Integer
    Dim m_IDEstado As Integer
    Dim m_IdDetalleFact As Integer
    Dim BoolOK As Boolean
    Dim m_BoolModificarChasis As Boolean

    'Usado en caso de Reestructurar la cuenta del cliente
    Public blnReestructurarCuenta As Boolean
    Dim m_cliente As String

    ''' <summary>
    ''' Propiedades del Formulario:
    ''' IDFactura.
    ''' Tipo de Gui : Nuevo, Edicion, Consulta.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Property BoolModificarChasis() As Boolean
        Get
            BoolModificarChasis = Me.m_BoolModificarChasis
        End Get
        Set(ByVal value As Boolean)
            Me.m_BoolModificarChasis = value
        End Set
    End Property

    Property IDClasificacion() As Integer
        Get
            IDClasificacion = Me.m_IDClasificacion
        End Get
        Set(ByVal value As Integer)
            Me.m_IDClasificacion = value
        End Set
    End Property

    Property IDEstado() As Integer
        Get
            IDEstado = Me.m_IDEstado
        End Get
        Set(ByVal value As Integer)
            Me.m_IDEstado = value
        End Set
    End Property

    Property IDFactura() As Integer
        Get
            IDFactura = m_IDFactura
        End Get
        Set(ByVal value As Integer)
            m_IDFactura = value
        End Set
    End Property

    Property TypGui() As Integer
        Get
            TypGui = m_TypGui
        End Get
        Set(ByVal value As Integer)
            m_TypGui = value
        End Set
    End Property

    Property ConceptoMoto() As Integer
        Get
            ConceptoMoto = m_ConceptoMoto
        End Get
        Set(ByVal value As Integer)
            m_ConceptoMoto = value
        End Set
    End Property

    Property IDTienda() As Integer
        Get
            IDTienda = m_IDTienda
        End Get
        Set(ByVal value As Integer)
            m_IDTienda = value
        End Set
    End Property

    Property IDCuenta() As String
        Get
            IDCuenta = m_IDCuenta
        End Get
        Set(ByVal value As String)
            m_IDCuenta = value
        End Set
    End Property

    Property IDPlazo() As Integer
        Get
            IDPlazo = Me.m_IdPlazo
        End Get
        Set(ByVal value As Integer)
            Me.m_IdPlazo = value
        End Set
    End Property

    Property IDDetalleFact() As Integer
        Get
            IDDetalleFact = Me.m_IdDetalleFact
        End Get
        Set(ByVal value As Integer)
            Me.m_IdDetalleFact = value
        End Set
    End Property

    Property Cliente() As String
        Get
            Cliente = m_cliente
        End Get
        Set(ByVal value As String)
            Me.m_cliente = value
        End Set
    End Property

    ''' <summary>
    ''' Evento de Llamado de Metodos para Cargar Datos.
    ''' Autor : Pedro Pablo Tinoco.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Try
            Call Me.SetearValoresInicio()
            Call Me.CargarConceptoFactura()
            Call Me.CargarEmpleados()
            Call Me.CargarModelos()
            Call Me.CargarPlazos()
            Call Me.MapearProp()
            Me.ConceptoMoto = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTOFACTURA", "01")
            Me.cmdExpediente.Focus()

            If Me.TypGui > 0 Then
                Call Me.CargarDatosEdicionConsulta()
            End If
            If Me.TypGui = 2 Or TypGui = 3 Then
                Me.txtFactura.Enabled = False
                Me.txtNumCuenta.Enabled = False
                Me.txtCodTienda.Enabled = False
                Me.cmdAceptar.Enabled = False
                Me.cmbConcepto.Enabled = False
                Me.cmbModelos.Enabled = False
                Me.NumMonto.Enabled = False
                Me.txtChasis.Enabled = False
                Me.txtNumMotor.Enabled = False
                Me.cmbEmpleado.Enabled = False
                Me.cmdExpediente.Enabled = False
                Me.chkDebito.Enabled = False
                Me.numDescuentoPorc.Enabled = False
                Me.dtpFechaCredito.Enabled = False
                Me.cmbPlazo.Enabled = False
                Me.cmdCambioFecha.Enabled = False
                Me.numPrima.Enabled = False

                If Me.TypGui = 2 Then
                    If Me.BoolModificarChasis Then
                        If Me.cmbModelos.Text <> "" Then
                            Me.ToolTip.Show("Puede Modificar el Chasis y No de Motor", Me.lblNoTarjeta)
                            Me.txtChasis.Enabled = True
                            Me.txtNumMotor.Enabled = True
                            Me.cmdAceptar.Enabled = True
                        End If
                    End If
                End If
            End If

            If TypGui = 3 Then
                Me.cmdCambioFecha.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Carga de Modelos de Motos Existentes.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarModelos()
        Try
            Me.DtDatosModelos = New DataTable
            Me.DtDatosModelos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SivProductoID,Modelo,Marca,Segmento", "vwStbProductos", "Activo=1"))
            With Me.cmbModelos
                .DataSource = Me.DtDatosModelos
                .ValueMember = "SivProductoID"
                .DisplayMember = "Modelo"
                .Splits(0).DisplayColumns("Marca").Visible = False
                .Splits(0).DisplayColumns("SivProductoID").Visible = False
                .Splits(0).DisplayColumns("Segmento").Visible = False
                .ExtendRightColumn = True
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Carga de Conceptos de Facturas.
    ''' Autor: Pedro Pablo Tinoco Salgado.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarConceptoFactura()
        Try
            Me.DtDatosConcepto = New DataTable
            Me.DtDatosConcepto = ClsCatalogos.ObtenerValCat("CONCEPTOFACTURA")
            With Me.cmbConcepto
                .DataSource = DtDatosConcepto
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Carga de Empleados.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEmpleados()
        Try
            Me.DtEmpleados = New DataTable
            Me.DtEmpleados = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto", "vwSrhEmpleado", "Activo =1"))
            With Me.cmbEmpleado
                .DataSource = DtEmpleados
                .ValueMember = "SrhEmpleadoID"
                .DisplayMember = "NombreCompleto"
                .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False               
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Mapear el Largo de las Propiedades
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MapearProp()
        Me.txtFactura.MaxLength = SfaFactura.GetMaxLength("Numero")
        Me.txtChasis.MaxLength = SfaFactura.GetMaxLength("Chasis")
        Me.txtNumMotor.MaxLength = SfaFactura.GetMaxLength("NoMotor")
    End Sub

#Region "Eventos"

    Private Sub cmbModelos_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbModelos.Change
        If Not Me.DtDatosModelos Is Nothing Then
            If Not IsDBNull(Me.cmbModelos.Columns("Marca").Value) Then
                Me.txtMarca.Text = Me.cmbModelos.Columns("Marca").Value
            End If
        End If
    End Sub

    Private Sub frmSfaFaturaEditar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.CargarDatos()
            Me.txtFactura.MaxLength = SfaFactura.GetMaxLength("Numero")
            Me.txtChasis.MaxLength = SfaFactura.GetMaxLength("Chasis")
            Me.txtNumMotor.MaxLength = SfaFactura.GetMaxLength("NoMotor")
            Me.txtNumCuenta.MaxLength = SccCuentaPorCobrar.GetMaxLength("SccCuentaID")
            Me.txtTarjeta.MaxLength = SccCuentaPorCobrarDetalle.GetMaxLength("NoTarjeta")

            Select Case Me.TypGui
                Case 0
                    Me.InhabilitarDatos(0, False)
                    Me.Text = "Registro Expediente-Factura"
                Case 1
                    Me.Text = "Edición de Expediente-Factura"
                Case 2
                    Me.Text = "Consulta de Expediente-Factura"
                Case 3
                    Me.Text = "Desplazamiento de Fechas de pago de Expediente-Factura"
            End Select
            clsProyecto.CargarTemaDefinido(Me)
            Me.Panel2.BackColor = Color.White

            'En caso de Reestructuración de Cuenta, cargar datos recibidos y bloquear controles
            If Me.blnReestructurarCuenta Then
                Me.Text = Me.Text + " - [REESTRUCTURACION CUENTA]"
                Me.txtCodTienda.Text = Me.IDTienda
                Me.txtNumCuenta.Text = Me.IDCuenta
                Me.txtNumCuenta.Size = New Size(163, 20)
                Me.txtCliente.Text = Me.Cliente

                Me.txtCodTienda.Enabled = False
                Me.txtNumCuenta.Enabled = False
                Me.txtCliente.Enabled = False
                Me.cmdExpediente.Visible = False
                Me.dtpFechaCredito.Enabled = True
                Me.dtpFechaCredito.BackColor = Color.White

                Me.cmbConcepto.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTOFACTURA", "05")
                Me.cmbConcepto.Enabled = False
                Dim strFiltro As String = " objSccCuentaID = '" + Me.IDCuenta + "' AND objTiendaId=" + Me.IDTienda.ToString
                Dim strSQL As String = clsConsultas.ObtenerConsultaGeneral("ISNULL(FacturaMotoID,0) AS FactMotoID", "dbo.txRC_Recibo_Step2", strFiltro)

                Me.IDFactura = Convert.ToInt32(SqlHelper.ExecuteQueryDT(strSQL).DefaultView.Item(0)("FactMotoID"))
                strSQL = clsConsultas.ObtenerConsultaGeneral("ISNULL(FacturaMotoNumero,0) AS FactMotoNumero", "dbo.txRC_Recibo_Step2", strFiltro)
                Dim strOldNumeroFactura As String = SqlHelper.ExecuteQueryDT(strSQL).DefaultView.Item(0)("FactMotoNumero")
                Dim strNewNumeroFactura As String = String.Empty
                If strOldNumeroFactura.StartsWith("RC") Then
                    If strOldNumeroFactura.StartsWith("RC-") Then
                        strNewNumeroFactura = "RC2-" + strOldNumeroFactura.Substring(3, strOldNumeroFactura.Length - 3)
                    Else
                        Dim iValor As Integer = strOldNumeroFactura.Substring(2, strOldNumeroFactura.IndexOf("-") - 2)
                        iValor = iValor + 1
                        strNewNumeroFactura = "RC" + iValor.ToString + strOldNumeroFactura.Substring(strOldNumeroFactura.IndexOf("-"), strOldNumeroFactura.Length - strOldNumeroFactura.IndexOf("-"))
                    End If
                Else
                    strNewNumeroFactura = "RC-" + strOldNumeroFactura
                End If

                Me.txtFactura.Text = strNewNumeroFactura

                Me.txtFactura.Enabled = False
                Me.numPrima.Value = 0.0
                Me.numPrima.Enabled = False

                Me.NumMonto.Value = (SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("ISNULL(NuevoLimiteCredito,0) AS NLimiteCredito", "dbo.txRC_Recibo_Step2", strFiltro)).DefaultView.Item(0)("NLimiteCredito").ToString())
                Me.numLimiteCredito.Value = Me.NumMonto.Value
                Me.chkDebito.Enabled = False
                Me.cmbEmpleado.Enabled = False
                Me.cmbPlazo.Enabled = True

                'Cargar demás datos de factura
                Me.objFact = New SfaFactura
                Me.objFact.Retrieve(Me.IDFactura)
                Me.txtNumMotor.Text = objFact.NoMotor
                Me.txtChasis.Text = objFact.Chasis
                Me.dtpFechaCredito.Value = clsProyecto.Conexion.FechaServidor

                Me.NUmCreditoUtilizado.Value = 0.0
                If objFact.objProductoID.HasValue Then
                    Me.cmbModelos.SelectedValue = objFact.objProductoID
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Me.dtpFecha.Text <> "" Then
        '    If Me.dtpFecha.Value > clsProyecto.Conexion.FechaServidor Then
        '        ErrorProvider.SetError(Me.dtpFecha, "Fecha debe ser menor o igual que fecha actual")
        '    Else
        '        ErrorProvider.Clear()
        '    End If

        'End If
    End Sub

    Private Sub cmbTienda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub txtNoCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub txtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.NumMonto.Focus()
            Exit Sub
        End If

        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub

    Private Sub txtFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFactura.TextChanged
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmbModelos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbModelos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtChasis.Focus()
        End If

    End Sub
    Private Sub cmbModelos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModelos.TextChanged
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmbConcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbConcepto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtFactura.Focus()
        End If
    End Sub

    Private Sub cmbConcepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConcepto.TextChanged
        Me.ErrorProvider.Clear()

        If Me.ConceptoMoto <> Me.cmbConcepto.SelectedValue Then
            Me.cmbModelos.SelectedValue = -1
            Me.cmbModelos.Enabled = False
            Me.txtNumMotor.Clear()
            Me.txtChasis.Clear()
            Me.txtMarca.Clear()
            Me.txtNumMotor.Enabled = False
            Me.txtChasis.Enabled = False
            Me.numPrima.Value = 0.0
            Me.numPrima.Enabled = False
        Else
            Me.numPrima.Value = 0.0
            Me.numPrima.Enabled = True
            Me.cmbModelos.Enabled = True
            Me.txtNumMotor.Enabled = True
            Me.txtChasis.Enabled = True
        End If
    End Sub

    Private Sub cmbEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbEmpleado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdAceptar.Focus()
        End If
    End Sub

    Private Sub cmbEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpleado.TextChanged
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub NumMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub txtChasis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub txtNumMotor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

#End Region

#Region "Validacion Guardado de Datos"
    ''' <summary>
    ''' Funcion encargada de realizar la validacion de existencias de numeros de facturas y cuentas.
    ''' </summary>
    ''' <param name="T"></param>
    ''' <returns></returns>s 
    ''' <remarks></remarks>
    Private Function Validacion(ByVal T As TransactionManager) As Boolean
        Dim Boolrst As Boolean
        Dim objSccCuenta As New SccCuentaPorCobrar
        Dim objFactura As New SfaFactura
        Dim MontoPrima As Decimal
        Dim MontoTotal As Decimal
        Dim IDEstadoReg As Integer

        Try
            Try
                Boolrst = True
                objSccCuenta.RetrieveByFilter("SccCuentaID='" & Me.IDCuenta & "' and objTiendaID=" & Me.IDTienda, T)
                If objSccCuenta.LimiteCredito < Me.numFinancimiento.Value Then
                    Me.ErrorProvider.SetError(Me.numFinancimiento, "Valor supera el limite de crédito actual del Expediente.")
                    Boolrst = False
                    GoTo Eti
                End If
                IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")

                MontoPrima = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID = '" & Me.IDCuenta & "' and objTiendaID=" & Me.IDTienda & " AND objEstadoID <>" & IDEstadoReg.ToString & " and objFacturaID IS NOT NULL", , "isnull(SUM(ISNULL(MontoPrima,0.0)),0.0) AS Monto", T).DefaultView.Item(0)("Monto")
                MontoTotal = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID = '" & Me.IDCuenta & "' and objTiendaID=" & Me.IDTienda & " AND objEstadoID <>" & IDEstadoReg.ToString & " and objFacturaID IS NOT NULL", , "isnull(SUM(isnull(MontoTotal,0.0)),0.0) as Monto", T).DefaultView.Item(0)("Monto")

                MontoTotal = MontoTotal - MontoPrima

                MontoTotal = objSccCuenta.LimiteCredito - MontoTotal

                If Me.numFinancimiento.Value > MontoTotal Then
                    Me.ErrorProvider.SetError(Me.NumMonto, "El limite de crédito del Expediente ha sido excedido.")
                    Boolrst = False
                End If
Eti:
                Return Boolrst
            Catch ex As Exception
                Throw ex
            End Try
        Finally
            objSccCuenta = Nothing
            objFactura = Nothing
        End Try
    End Function

    Private Sub CalculoDiferenciaCredito()
        Dim MontoPrima As Decimal
        Dim MontoTotal As Decimal
        Dim IDEstadoReg As Integer
        Try
            Try        
                IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
                MontoPrima = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID = '" & Me.IDCuenta & "' and objTiendaID=" & Me.IDTienda & " AND objEstadoID <>" & IDEstadoReg.ToString & " and objFacturaID IS NOT NULL", , "isnull(SUM(ISNULL(MontoPrima,0.0)),0.0) AS Monto").DefaultView.Item(0)("Monto")
                MontoTotal = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID = '" & Me.IDCuenta & "' and objTiendaID=" & Me.IDTienda & " AND objEstadoID <>" & IDEstadoReg.ToString & " and objFacturaID IS NOT NULL", , "isnull(SUM(isnull(MontoTotal,0.0)),0.0) as Monto").DefaultView.Item(0)("Monto")
                MontoTotal = MontoTotal - MontoPrima
                Me.NUmCreditoUtilizado.Value = MontoTotal
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally

        End Try
    End Sub

#End Region

#Region "Guardado de datos"
    ''' <summary>
    ''' Procedimiento encargado de realizar el guardado de las facturas de credito.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 23 de Marzo de 2009.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GuardarFactura() As Boolean
        Dim BoolRst As Boolean
        Dim T As New TransactionManager
        Dim objFactura As New SfaFactura
        Dim objCuentaCobrarDetalle As New SccCuentaPorCobrarDetalle
        Try
            BoolRst = True
            Try

                T.BeginTran()

                If Me.TypGui = 1 Then
                    objFactura.Retrieve(Me.IDFactura)
                    objCuentaCobrarDetalle.RetrieveByFilter("objSccCuentaID='" & Me.IDCuenta & "' AND objTiendaID=" & Me.IDTienda.ToString & " AND objFacturaID=" & Me.IDFactura)
                    'Else
                    '    If objFactura.RetrieveByFilter("Numero = '" & Trim(Me.txtFactura.Text) & "'" & "", T) Then
                    '        Me.ErrorProvider.SetError(Me.txtFactura, "Número de Factura ya existe en el Sistema")
                    '        BoolRst = False
                    '        T.RollbackTran()
                    '        Exit Function
                    '    End If
                End If

                If Not Me.Validacion(T) Then
                    BoolRst = False
                    T.RollbackTran()
                    Exit Function
                End If
                '' Creacion del Registro de Factura
                objFactura.Numero = Trim(Me.txtFactura.Text)
                objFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objFactura.objEmpleadoID = Me.cmbEmpleado.Columns("SrhEmpleadoID").Value
                objFactura.MontoTotal = Trim(Me.NumMonto.Value)
                objFactura.objConceptoFactura = Me.cmbConcepto.Columns("StbValorCatalogoID").Value

                If cmbModelos.Enabled = True Then
                    objFactura.objProductoID = Me.cmbModelos.Columns("SivProductoID").Value
                    If Trim(Me.txtChasis.Text) <> "" Then
                        objFactura.Chasis = Trim(Me.txtChasis.Text)
                    End If
                    If Trim(Me.txtNumMotor.Text) <> "" Then
                        objFactura.NoMotor = Trim(Me.txtNumMotor.Text)
                    End If
                End If
                objFactura.Fecha = Me.dtpFechaCredito.Value
                If Me.TypGui = 0 Then
                    objFactura.Insert(T)
                Else
                    objFactura.Update()
                End If

                '' Creacion del Registro de Detalle de Cuenta de la Factura
                objCuentaCobrarDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objCuentaCobrarDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objCuentaCobrarDetalle.objFacturaID = objFactura.SfaFacturaID
                objCuentaCobrarDetalle.MontoTotal = objFactura.MontoTotal
                objCuentaCobrarDetalle.objSccCuentaID = Me.IDCuenta
                objCuentaCobrarDetalle.objTiendaID = Me.IDTienda
                objCuentaCobrarDetalle.MontoAbonado = 0.0
                objCuentaCobrarDetalle.Saldo = objFactura.MontoTotal
                objCuentaCobrarDetalle.MontoCuota = Me.numMontoCuotas.Value
                objCuentaCobrarDetalle.objTeminoPlazoID = Me.cmbPlazo.SelectedValue
                objCuentaCobrarDetalle.Importado = 0
                If Me.chkDebito.Checked Then
                    objCuentaCobrarDetalle.EsDebitoAutomatico = 1
                Else
                    objCuentaCobrarDetalle.EsDebitoAutomatico = 0
                End If

                objCuentaCobrarDetalle.objCalificacionID = Me.IDClasificacion
                objCuentaCobrarDetalle.Descuento = Me.numDescuentoPorc.Value
                objCuentaCobrarDetalle.objEstadoID = Me.IDEstado
                objCuentaCobrarDetalle.FechaProximoPago = Me.dtpFechaProximoPago.Value
                objCuentaCobrarDetalle.FechaVencimiento = Me.dtpFechaVencimiento.Value
                objCuentaCobrarDetalle.MontoPrima = Me.numPrima.Value
                If Me.chkDebito.Checked Then
                    objCuentaCobrarDetalle.NoTarjeta = Trim(Me.txtTarjeta.Text)
                End If

                If Me.TypGui = 0 Then
                    objCuentaCobrarDetalle.Insert(T)
                Else
                    objCuentaCobrarDetalle.Update(T)
                End If
                Me.IDDetalleFact = objCuentaCobrarDetalle.SccCuentaPorCobrarDetalleID

                Me.InsertCalculo(Me.IDCuenta, Me.IDTienda, objFactura.SfaFacturaID, T)
                T.CommitTran()
                Me.IDFactura = objFactura.SfaFacturaID
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Return BoolRst

            Catch ex As Exception
                T.RollbackTran()
                BoolRst = False
                clsError.CaptarError(ex)
            End Try
        Finally
            objFactura = Nothing
            objCuentaCobrarDetalle = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Procedimiento encargado de realizar el guardado de las facturas de crédito, 
    ''' Temporalmente mientras se completa el proceso de REESTRUCTURACION DE CUENTA
    ''' Autor : Gelmin Martínez
    ''' Fecha : 09 de Abril de 2010, 01:54 pm
    ''' </summary>
    ''' <remarks></remarks>
    Private Function GuardarFactura_temp() As Boolean
        Dim BoolRst As Boolean
        Dim T As New TransactionManager
        Dim objFactura As New txRC_Factura_Step3
        Dim objFacturaDetalle As New txRC_FacturaDetalle_Step3
        Try
            BoolRst = True
            Try
                T.BeginTran()

                If Me.numLimiteCredito.Value < Me.numFinancimiento.Value Then
                    Me.ErrorProvider.SetError(Me.numFinancimiento, "Valor supera el limite de crédito actual del Expediente.")
                    T.RollbackTran()
                    Exit Function
                End If
                
                If Me.numFinancimiento.Value > Me.NumMonto.Value Then
                    Me.ErrorProvider.SetError(Me.NumMonto, "El limite de crédito del Expediente ha sido excedido.")
                    T.RollbackTran()
                    Exit Function
                End If

                'Limpiar la tabla operativa para esta factura
                txRC_Factura_Step3.DeleteByFilter("1=1")

                '' Creacion del Registro de Factura
                objFactura.Numero = Trim(Me.txtFactura.Text)
                objFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
                'objFactura.objEmpleadoID = Me.cmbEmpleado.Columns("SrhEmpleadoID").Value
                objFactura.MontoTotal = Trim(Me.NumMonto.Value)
                objFactura.objConceptoFactura = Me.cmbConcepto.Columns("StbValorCatalogoID").Value

                If cmbModelos.Enabled = True Then
                    objFactura.objProductoID = Me.cmbModelos.Columns("SivProductoID").Value
                    If Trim(Me.txtChasis.Text) <> "" Then
                        objFactura.Chasis = Trim(Me.txtChasis.Text)
                    End If
                    If Trim(Me.txtNumMotor.Text) <> "" Then
                        objFactura.NoMotor = Trim(Me.txtNumMotor.Text)
                    End If
                End If
                objFactura.Fecha = Me.dtpFechaCredito.Value
                If Me.TypGui = 0 Then
                    objFactura.Insert(T)
                Else
                    objFactura.Update()
                End If

                'Limpiar la tabla operativa para el detalle de factura
                txRC_FacturaDetalle_Step3.DeleteByFilter("1=1")

                '' Creacion del Registro de Detalle de Cuenta de la Factura
                With objFacturaDetalle
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .objFacturaID = objFactura.SfaFacturaID
                    .MontoTotal = objFactura.MontoTotal
                    .objSccCuentaID = Me.IDCuenta
                    .objTiendaID = Me.IDTienda
                    .MontoAbonado = 0.0
                    .Saldo = objFactura.MontoTotal
                    .MontoCuota = Me.numMontoCuotas.Value
                    .objTeminoPlazoID = Me.cmbPlazo.SelectedValue
                    'objCuentaCobrarDetalle.Importado = 0
                    'If Me.chkDebito.Checked Then
                    '    objCuentaCobrarDetalle.EsDebitoAutomatico = 1
                    'Else
                    '    objCuentaCobrarDetalle.EsDebitoAutomatico = 0
                    'End If

                    .objCalificacionID = Me.IDClasificacion
                    .Descuento = Me.numDescuentoPorc.Value
                    .objEstadoID = Me.IDEstado
                    .FechaProximoPago = Me.dtpFechaProximoPago.Value
                    .FechaVencimiento = Me.dtpFechaVencimiento.Value
                    .MontoPrima = Me.numPrima.Value
                    'If Me.chkDebito.Checked Then
                    '    objCuentaCobrarDetalle.NoTarjeta = Trim(Me.txtTarjeta.Text)
                    'End If

                    If Me.TypGui = 0 Then
                        .Insert(T)
                    Else
                        .Update(T)
                    End If
                End With

                Me.IDDetalleFact = objFacturaDetalle.SccCuentaPorCobrarDetalleID

                'El registro de cálculo para esta factura se  hace desde un procedimiento almacenado.
                'Me.InsertCalculo(Me.IDCuenta, Me.IDTienda, objFactura.SfaFacturaID, T)
                T.CommitTran()
                Me.IDFactura = objFactura.SfaFacturaID
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Return BoolRst

            Catch ex As Exception
                T.RollbackTran()
                BoolRst = False
                clsError.CaptarError(ex)
            End Try
        Finally
            objFactura = Nothing
            objFacturaDetalle = Nothing
        End Try
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ValidacionEntradas Then
            If Me.GuardarFactura Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            
        End If
    End Sub
#End Region
    ''' <summary>
    ''' Validaciones correspondientes a las entradas de datos.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
#Region "Validaciones"
    Private Sub NumMonto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SfaFactura.GetMaxLength("MontoTotal")
            s = SfaFactura.GetScale("MontoTotal")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.NumMonto.Value > ValorMaximo Then
                Me.ErrorProvider.SetError(Me.NumMonto, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.NumMonto.Value = 0
            Else
                Me.ErrorProvider.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProvider.SetError(Me.NumMonto, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.NumMonto.Value = 0
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Validar las Entradas Obligatorias.
    ''' Autor : Pedro Tinoco
    ''' Fecha : 25 de Marzo de 2009.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidacionEntradas() As Boolean

        If Trim(Me.txtNumCuenta.Text) = "" Then
            Me.ErrorProvider.SetError(Me.cmdExpediente, "Campo Obligatorio")
            Return False
            Exit Function
        End If

        If Me.cmbConcepto.Text = "" Then
            Me.ErrorProvider.SetError(Me.cmbConcepto, "Campo Obligatorio")
            Return False
            Exit Function
        End If

        If Me.ConceptoMoto = Me.cmbConcepto.SelectedValue Then
            If Me.cmbModelos.Text = "" Then
                Me.ErrorProvider.SetError(Me.cmbModelos, "Campo Obligatorio")
                Return False
                Exit Function
            End If
        End If

        If Me.cmbEmpleado.Text = "" And (Not Me.blnReestructurarCuenta) Then
            Me.ErrorProvider.SetError(Me.cmbEmpleado, "Campo Obligatorio")
            Return False
            Exit Function
        End If

        If Me.NumMonto.Value <= 0 Then
            Me.ErrorProvider.SetError(Me.NumMonto, "Valor debe ser mayor que cero.")
            Return False
            Exit Function
        End If

        If Me.numPrima.Value > Me.NumMonto.Value Then
            Me.ErrorProvider.SetError(Me.numPrima, "Prima no puede ser mayor que Monto Total")
            Return False
            Exit Function
        End If

        If Me.ConceptoMoto = Me.cmbConcepto.SelectedValue Then
            If Me.numPrima.Value < 0 Then
                Me.ErrorProvider.SetError(Me.numPrima, "Campo Obligatorio")
                Exit Function
            End If
        End If

        If Trim(Me.cmbPlazo.Text) = "" Then
            Me.ErrorProvider.SetError(Me.cmbPlazo, "Campo Obligatorio")
            Return False
            Exit Function
        End If

        If Me.chkDebito.Checked Then
            If Trim(Me.txtTarjeta.Text) = "" Then
                Me.ErrorProvider.SetError(Me.txtTarjeta, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.numDescuentoPorc.Value = 0 Then
                Me.ErrorProvider.SetError(Me.numDescuentoPorc, "Porcentaje de Descuento debe ser Mayor que cero.")
                Return False
                Exit Function
            End If

        End If

        If Me.txtFactura.Text.Trim.Length = 0 Then
            Me.ErrorProvider.SetError(Me.txtFactura, "Campo obligatorio.")
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

#Region "edicion y Consulta"
    Private Sub CargarDatosEdicionConsulta()
        Dim dtDatos As New DataTable
        Dim objCuentaDetalle As New SccCuentaPorCobrarDetalle
        Try
            Try
                objFact = New SfaFactura
                objFact.Retrieve(Me.IDFactura)
                '  Me.txtNoCuenta.Text = objFact.objSccCuentaID
                Me.txtFactura.Text = objFact.Numero
                Me.txtNumMotor.Text = objFact.NoMotor
                Me.txtChasis.Text = objFact.Chasis
                Me.NumMonto.Value = objFact.MontoTotal
                Me.dtpFechaCredito.Value = objFact.Fecha

                objCuentaDetalle.RetrieveByFilter("objFacturaID ='" + objFact.SfaFacturaID.ToString & "'")
                Me.IDDetalleFact = objCuentaDetalle.SccCuentaPorCobrarDetalleID
                Me.IDCuenta = objCuentaDetalle.objSccCuentaID
                Me.IDTienda = objCuentaDetalle.objTiendaID
                Me.numMontoCuotas.Value = objCuentaDetalle.MontoCuota

                If objCuentaDetalle.objTeminoPlazoID.HasValue Then
                    Me.cmbPlazo.SelectedValue = objCuentaDetalle.objTeminoPlazoID
                End If

                Me.numDescuentoPorc.Value = objCuentaDetalle.Descuento
                Me.numCuotas.Value = Me.cmbPlazo.Columns("Codigo").Value
                Me.numSaldo.Value = objCuentaDetalle.Saldo
                Me.numFinancimiento.Value = objCuentaDetalle.MontoTotal - objCuentaDetalle.MontoPrima

                If objCuentaDetalle.EsDebitoAutomatico.HasValue Then
                    Me.chkDebito.Checked = objCuentaDetalle.EsDebitoAutomatico
                End If

                If objCuentaDetalle.objCalificacionID.HasValue Then
                    Me.IDClasificacion = objCuentaDetalle.objCalificacionID
                End If
                If objCuentaDetalle.objEstadoID.HasValue Then
                    Me.IDEstado = objCuentaDetalle.objEstadoID
                End If
                Me.txtTarjeta.Text = objCuentaDetalle.NoTarjeta

                If objCuentaDetalle.FechaUltimoPago.HasValue Then
                    Me.dtpUltimoPago.Value = objCuentaDetalle.FechaUltimoPago
                End If
                If objCuentaDetalle.FechaProximoPago.HasValue Then
                    Me.dtpFechaProximoPago.Value = objCuentaDetalle.FechaProximoPago
                End If
                If objCuentaDetalle.FechaVencimiento.HasValue Then
                    Me.dtpFechaVencimiento.Value = objCuentaDetalle.FechaVencimiento
                End If

                Me.SetearValoresInicio()

                dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("CodigoTienda,SccCuentaID,Cliente,LimiteCredito", "vwSccCuentasSeleccion", "SccCuentaID='" & Me.IDCuenta.ToString & "' AND StbTiendaID =" & Me.IDTienda))
                Me.txtCodTienda.Text = dtDatos.DefaultView.Item(0)("CodigoTienda")
                Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("SccCuentaID")
                Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Cliente")
                Me.numLimiteCredito.Value = dtDatos.DefaultView.Item(0)("LimiteCredito")

                Me.cmbEmpleado.SelectedValue = objFact.objEmpleadoID
                If objFact.objProductoID.HasValue Then
                    Me.cmbModelos.SelectedValue = objFact.objProductoID
                End If
                Me.cmbConcepto.SelectedValue = objFact.objConceptoFactura
                Me.numPrima.Value = objCuentaDetalle.MontoPrima
                Me.CalculoDiferenciaCredito()
                If objCuentaDetalle.Importado Then
                    Me.numMontoCuotas.Value = objCuentaDetalle.MontoCuota
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try

        Finally
            dtDatos = Nothing
            objCuentaDetalle = Nothing
        End Try
    End Sub
#End Region

    Private Sub cmdExpediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpediente.Click
        Me.ErrorProvider.Clear()
        Call Me.SeleccionarCuenta()
    End Sub

    Private Sub SeleccionarCuenta()
        Dim objCuenta As SccCuentaPorCobrar
        Try
            Try
                Dim objCuentasSeleccion As New frmSccSeleccionCuentas
                If objCuentasSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.LimpiarDatos()
                    Me.txtCodTienda.Text = objCuentasSeleccion.CodigoTienda
                    Me.txtNumCuenta.Text = objCuentasSeleccion.SccCuentaID
                    Me.IDCuenta = objCuentasSeleccion.SccCuentaID
                    Me.IDTienda = objCuentasSeleccion.IDTienda
                    Me.txtCliente.Text = objCuentasSeleccion.Cliente
                    Me.numLimiteCredito.Value = objCuentasSeleccion.LimiteCredito
                    Me.InhabilitarDatos(0, True)
                    objCuenta = New SccCuentaPorCobrar
                    objCuenta.Retrieve(Me.IDCuenta, Me.IDTienda)
                    Me.dtpFechaCredito.Value = objCuenta.FechaCredito
                    Me.cmbConcepto.Focus()
                    Me.CalculoDiferenciaCredito()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objCuenta = Nothing
        End Try
    End Sub

#Region "Carga de Plazos de Pago"

    Private Sub CargarPlazos()
        Try
            Me.DtDatosPlazos = New DataTable
            Me.DtDatosPlazos = ClsCatalogos.ObtenerValCat("PLAZOS")
            With Me.cmbPlazo
                .DataSource = Me.DtDatosPlazos
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

    ''' <summary>
    ''' Procedimiento encargado de inhabilitar los datos correspondientes a la factura
    ''' Autor : Pedro Pablo Tinoco 
    ''' Fecha Creacion : 28 de Marzo de 2009.
    ''' </summary>
    ''' <param name="IntOpcion"></param>
    ''' <remarks></remarks>
    Private Sub InhabilitarDatos(ByVal IntOpcion As Integer, ByVal Opcion As Boolean)
        Try
            Select Case IntOpcion
                '' Inhabilitar Todos
                Case 0
                    Me.cmbPlazo.Enabled = Opcion
                    Me.cmdConsultar.Enabled = Opcion
                    Me.txtFactura.Enabled = Opcion
                    Me.txtNumMotor.Enabled = Opcion
                    Me.txtChasis.Enabled = Opcion
                    Me.cmbModelos.Enabled = Opcion
                    Me.cmbConcepto.Enabled = Opcion
                    Me.dtpFechaCredito.Enabled = False
                    ''      Me.dtpFecha.Enabled = Opcion
                Case 1
                Case 2
                Case 3
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#Region "Limpiar Datos"
    Private Sub LimpiarDatos()
        Try
            Me.txtFactura.Clear()
            Me.txtChasis.Clear()
            Me.txtCliente.Clear()
            Me.txtNumCuenta.Clear()
            Me.txtNumMotor.Clear()
            Me.cmbModelos.SelectedValue = 0
            Me.cmbPlazo.SelectedValue = 0
            Me.cmbConcepto.SelectedValue = 0
            Me.cmbEmpleado.SelectedValue = 0
            Me.NumMonto.Value = 0.0
            Me.txtFactura.Clear()
            Me.txtMarca.Clear()
            Me.numMontoCuotas.Value = 0.0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region


#Region "MANEJO DE EVENTOS KEYPRESS"

    Private Sub txtNumMotor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumMotor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmbPlazo.Focus()
        End If
    End Sub

    Private Sub txtChasis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChasis.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtNumMotor.Focus()
        End If
    End Sub

    Private Sub cmbPlazo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        If Me.txtNumCuenta.Text <> "" Then
            CargarConsultaCuenta()
        End If
    End Sub

    Private Sub CargarConsultaCuenta()
        Dim objfrmCuentaEdit As frmSccCuentasEditar
        objfrmCuentaEdit = New frmSccCuentasEditar
        objfrmCuentaEdit.CuentaID = Me.IDCuenta
        objfrmCuentaEdit.TiendaID = Me.IDTienda
        objfrmCuentaEdit.TypeGUI = 2
        objfrmCuentaEdit.ShowDialog(Me)
    End Sub

    Private Sub numDescuentoPorc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numDescuentoPorc.KeyPress
        If Me.numDescuentoPorc.Text.Trim.Length > 0 Then
            If Asc(e.KeyChar) = 13 Then
                numDescuentoPorc.UpdateValueWithCurrentText()
            End If
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.cmbEmpleado.Focus()
        End If
    End Sub

    Private Sub numDescuentoPorc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDescuentoPorc.ValueChanged
        If Not IsDBNull(numDescuentoPorc.Value) Then
            If Me.numDescuentoPorc.Value >= 0 Then
                If Me.numDescuentoPorc.Value > 100 Then
                    Me.numDescuentoPorc.Value = 100
                End If
            Else
                Me.numDescuentoPorc.Value = 0
                Me.numDescuentoPorc.UpdateValueWithCurrentText()
            End If
        End If
    End Sub

    Private Sub chkDebito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDebito.CheckedChanged
        If chkDebito.Checked Then
            Me.txtTarjeta.Enabled = True
            Me.numDescuentoPorc.Enabled = True
        Else
            Me.txtTarjeta.Enabled = False
            Me.txtTarjeta.Text = ""
            Me.numDescuentoPorc.Value = 0
            Me.numDescuentoPorc.Enabled = False
        End If
    End Sub

    Private Sub cmbPlazo_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlazo.Change
        If Me.dtpFechaCredito.Text.Trim.Length <> 0 Then
            Me.dtpFechaCredito.UpdateValueWithCurrentText()
            If Not dtpFechaCredito.ValueIsDbNull Then
                Me.dtpFechaProximoPago.Value = dtpFechaCredito.Value.AddMonths(1)
                Me.dtpFechaVencimiento.Value = dtpFechaCredito.Value.AddMonths(Me.cmbPlazo.Columns("Codigo").Value)
            End If
        End If

        If Me.NumMonto.Text.Trim.Length > 0 Then
            If Convert.ToDouble(NumMonto.Text) > 0 Then
                Me.CalcularInformacion()
            End If
        End If
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmbPlazo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPlazo.KeyPress
        If cmbPlazo.Text.Trim.Length > 0 Then
            If Me.dtpFechaCredito.Text.Trim.Length <> 0 Then
                If Asc(e.KeyChar) = 13 Then
                    Me.dtpFechaCredito.UpdateValueWithCurrentText()
                    If Not dtpFechaCredito.ValueIsDbNull Then
                        Me.dtpFechaProximoPago.Value = dtpFechaCredito.Value.AddMonths(1)
                        Me.dtpFechaVencimiento.Value = dtpFechaCredito.Value.AddMonths(Me.cmbPlazo.Columns("Codigo").Value)
                    End If
                End If
            End If
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.chkDebito.Focus()
        End If
    End Sub

    Private Sub NumMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbModelos.Enabled Then
                Me.numPrima.Focus()
            Else
                Me.cmbPlazo.Focus()
            End If
            If cmbPlazo.Text <> "" Then
                Me.CalcularInformacion()
            Else
                Me.numCuotas.Value = 0
                Me.numSaldo.Value = 0
                Me.numMontoCuotas.Value = 0
            End If
        End If
    End Sub

    Private Sub txtTarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTarjeta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.numDescuentoPorc.Focus()
        End If
    End Sub
#End Region

    Public Sub CargarPlazo()
        dtTerminoPlazo = Proyecto.Catalogos.Datos.ClsCatalogos.ObtenerValCat("PLAZOS")
        With cmbPlazo
            .DataSource = dtTerminoPlazo
            .ValueMember = "StbValorCatalogoID"
            .DisplayMember = "Descripcion"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .Splits(0).DisplayColumns("Codigo").Visible = False
            .Splits(0).DisplayColumns("Activo").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub

    Private Sub SetearValoresInicio()
        Try

            Select Case Me.TypGui
                Case 0
                    Me.IDEstado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
                    Me.IDClasificacion = ClsCatalogos.ObtenerIDSTbCatalogo("CLASIFICACIONCUENTA", "OK")
                    Me.txtEstado.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDEstado.ToString, "")).DefaultView.Item(0)("Descripcion")
                    Me.TxtClasificacion.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDClasificacion.ToString, "")).DefaultView.Item(0)("Descripcion")
                Case 1
                    If Me.IDEstado > 0 Then
                        Me.txtEstado.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDEstado.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If

                    If Me.IDClasificacion > 0 Then
                        Me.TxtClasificacion.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDClasificacion.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If
                Case 2
                    If Me.IDEstado > 0 Then
                        Me.txtEstado.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDEstado.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If

                    If Me.IDClasificacion > 0 Then
                        Me.TxtClasificacion.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDClasificacion.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If
                Case 3
                    If Me.IDEstado > 0 Then
                        Me.txtEstado.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDEstado.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If

                    If Me.IDClasificacion > 0 Then
                        Me.TxtClasificacion.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDClasificacion.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.TypGui = 2 Then
            If Me.BoolModificarChasis Then
                If Me.GuardarCambiosChasis Then
                    MsgBox("Los Datos de Chasis y Motor han sido modificados exitosamente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Exit Sub
                End If
            End If
        End If

        If Me.ValidacionEntradas Then
            If Not Me.blnReestructurarCuenta Then
                Me.BoolOK = Me.GuardarFactura                
            Else
                'En caso de Reestructuración de cuenta Guardar la factura Temporalmente mientras se completa el proceso.
                Me.BoolOK = Me.GuardarFactura_temp()
            End If

            If Me.BoolOK Then
                Me.Inhabilitar()
                Me.cmdProcesar.Enabled = True
                If Me.blnReestructurarCuenta Then
                    Me.ToolTip.Show("Para completar el proceso de REESTRUCTURACION de Click en PROCESAR.", Me.lblInfo, 15000)
                Else
                    Me.ToolTip.Show("Cancelar para Salir, ó puede Procesar la Factura desde esta pantalla.", Me.lblInfo, 15000)
                End If
            End If
        End If
    End Sub

    Public Sub InsertCalculo(ByVal Cuenta As String, ByVal Tienda As Integer, ByVal Factura As Integer, Optional ByRef pTransac As TransactionManager = Nothing)
        Dim sCommand As String = "insert into StbCalculos("
        sCommand &= "CuotasPendientes,"
        sCommand &= "CuotasPagadas,"
        sCommand &= "CuotasTranscurridas,"
        sCommand &= "CuotasVencidas,"
        sCommand &= "InteresMoratorio,"
        sCommand &= "SaldoCorriente,"
        sCommand &= "Mora30,"
        sCommand &= "Mora60,"
        sCommand &= "MoraOver60,"
        sCommand &= "DiasVencidos,"
        sCommand &= "SccCuentaID,"
        sCommand &= "SfaFacturaID,"
        sCommand &= "objTiendaID) values ("
        sCommand &= "@CuotasPendientes,"
        sCommand &= "@CuotasPagadas,"
        sCommand &= "@CuotasTranscurridas,"
        sCommand &= "@CuotasVencidas,"
        sCommand &= "@InteresMoratorio,"
        sCommand &= "@SaldoCorriente,"
        sCommand &= "@Mora30,"
        sCommand &= "@Mora60,"
        sCommand &= "@MoraOver60,"
        sCommand &= "@DiasVencidos,"
        sCommand &= "@SccCuentaID,"
        sCommand &= "@SfaFacturaID,"
        sCommand &= "@objTiendaID)"


        Dim arParams(13) As SqlParameter
        arParams(0) = New SqlParameter("@CuotasPendientes", SqlDbType.Decimal)
        arParams(0).Value = 0


        arParams(1) = New SqlParameter("@CuotasPagadas", SqlDbType.Decimal)
        arParams(1).Value = 0

        arParams(2) = New SqlParameter("@CuotasTranscurridas", SqlDbType.Int)
        arParams(2).Value = 0

        arParams(3) = New SqlParameter("@CuotasVencidas", SqlDbType.Int)
        arParams(3).Value = 0

        arParams(4) = New SqlParameter("@InteresMoratorio", SqlDbType.Decimal)
        arParams(4).Value = 0

        arParams(5) = New SqlParameter("@SaldoCorriente", SqlDbType.Decimal)
        arParams(5).Value = 0

        arParams(6) = New SqlParameter("@Mora30", SqlDbType.Decimal)
        arParams(6).Value = 0

        arParams(7) = New SqlParameter("@Mora60", SqlDbType.Decimal)
        arParams(7).Value = 0

        arParams(8) = New SqlParameter("@MoraOver60", SqlDbType.Decimal)
        arParams(8).Value = 0

        arParams(9) = New SqlParameter("@DiasVencidos", SqlDbType.Int)
        arParams(9).Value = 0

        arParams(10) = New SqlParameter("@SccCuentaID", SqlDbType.VarChar)
        arParams(10).Value = Cuenta

        arParams(11) = New SqlParameter("@SfaFacturaID", SqlDbType.Int)
        arParams(11).Value = Factura

        arParams(12) = New SqlParameter("@objTiendaID", SqlDbType.Int)
        arParams(12).Value = Tienda

        Try

            If pTransac Is Nothing Then
                SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)
            Else
                SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function GuardarCambiosChasis() As Boolean
        Dim ObjFact As New SfaFactura
        Dim T As New TransactionManager
        Dim BoolRst As Boolean
        Try
            BoolRst = False
            T.BeginTran()
            ObjFact.Retrieve(Me.IDFactura)
            If Me.txtNumMotor.Text <> "" Then
                ObjFact.NoMotor = Me.txtNumMotor.Text
            End If
            If Me.txtChasis.Text <> "" Then
                ObjFact.Chasis = Me.txtChasis.Text
            End If
            ObjFact.Update(T)
            T.CommitTran()
            BoolRst = True
            Return BoolRst

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Function

    Public Sub CalcularInformacion()
        Try
            Me.numCuotas.Value = Me.cmbPlazo.Columns("Codigo").Value
            Me.numFinancimiento.Value = Me.NumMonto.Value - Me.numPrima.Value
            Me.numMontoCuotas.Value = Me.numFinancimiento.Value / Me.cmbPlazo.Columns("Codigo").Value
            Me.numSaldo.Value = Me.NumMonto.Value
        Catch ex As Exception
            Me.numCuotas.Value = 0
            Me.NumMonto.Value = 0
            Me.numSaldo.Value = 0
            Me.numFinancimiento.Value = 0
        End Try
    End Sub

    Private Sub cmdCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If Me.BoolOK And (Not Me.blnReestructurarCuenta) Then
            Select Case MsgBox("¿Desea crear otro Expediente-Factura para el mismo Expediente de Cuenta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Me.LimpiarDatosNuevo()
                    Me.cmbConcepto.Focus()
                Case MsgBoxResult.No
                    Me.DialogResult = Windows.Forms.DialogResult.OK
            End Select
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Establecer el Detalle de Factura como Procesado.
    ''' </summary>
    ''' <param name="IDDetalleFact"></param>
    ''' <remarks></remarks>
    Private Sub ProcesarExpedienteFact(ByVal IDDetalleFact As Integer)
        Dim objDetalleFact As New SccCuentaPorCobrarDetalle
        Dim objNotaCredito As New SccNotaCredito
        Dim objSccCuentaCobrar As New SccCuentaPorCobrar
        Dim T As New TransactionManager
        Dim BoolNC As Boolean = False
        Try
            Try
                T.BeginTran()
                objDetalleFact.Retrieve(IDDetalleFact, T)

                If Not Me.Validacion(T) Then
                    MsgBox("La adición de este Monto al expediente excede el Límite de Crédito", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    T.RollbackTran()
                    Exit Sub
                Else
                    objDetalleFact.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objDetalleFact.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objDetalleFact.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")
                    objDetalleFact.Update(T)
                End If

                objSccCuentaCobrar.Retrieve(Me.IDCuenta, Me.IDTienda, T)
                objSccCuentaCobrar.Saldo = objSccCuentaCobrar.Saldo + objDetalleFact.MontoTotal
                objSccCuentaCobrar.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "VIGENTE")
                objSccCuentaCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSccCuentaCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSccCuentaCobrar.Update(T)

                If objDetalleFact.EsDebitoAutomatico Then
                    objNotaCredito.Fecha = clsProyecto.Conexion.FechaServidor
                    objNotaCredito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objNotaCredito.Descripcion = "Nota de Crédito generado por descuento aplicado a Expedientes con débito automático."
                    objNotaCredito.objConceptoID = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTONC", "05")
                    objNotaCredito.Numero = SccNotaCredito.RetrieveDT(, , "ISNULL(MAX(Numero),0) + 1 as Maximo", T).DefaultView.Item(0)("Maximo")
                    objNotaCredito.objTiendaID = Me.IDTienda
                    objNotaCredito.objSccCuentaID = Me.IDCuenta
                    objNotaCredito.Monto = objDetalleFact.MontoTotal * (objDetalleFact.Descuento.Value / 100)
                    objNotaCredito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objNotaCredito.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "AUTORIZADA")
                    objNotaCredito.Insert(T)
                    BoolNC = True
                End If

                T.CommitTran()
                MsgBox("Factura procesada Exitosamente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                If BoolNC Then
                    MsgBox("Se ha generado una Nota de Crédito para Expedientes-Facturas por Débito Automático.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                End If

                Select Case MsgBox("¿Desea crear otro Expediente-Factura para el mismo Expediente de Cuenta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        Me.TypGui = 0
                        Me.LimpiarDatosNuevo()
                        Me.cmbConcepto.Focus()
                    Case MsgBoxResult.No
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                End Select
                
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Catch ex As Exception
            T = Nothing
            objNotaCredito= NOthing 
            objDetalleFact = Nothing
            objSccCuentaCobrar = Nothing           
        End Try
    End Sub

#Region "Procesar Factura y Completar REESTRUCTURACION DE CUENTA."
    ''' <summary>
    ''' Procedimiento Encargado de procesar la nueva factura, y completar el proceso de REESTRUCTURACION DE CUENTA.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ProcesarFactura_ReestructurarCuenta()
        Dim objDetalleFact As New txRC_FacturaDetalle_Step3
        'Dim objSccCuentaCobrar As New SccCuentaPorCobrar
        Dim T As New TransactionManager
        Try
            Try
                T.BeginTran()
                objDetalleFact.Retrieve(Me.IDDetalleFact, T)

                If Me.numLimiteCredito.Value < Me.numFinancimiento.Value Then
                    Me.ErrorProvider.SetError(Me.numFinancimiento, "Valor supera el limite de crédito actual del Expediente.")
                    T.RollbackTran()
                    Exit Sub
                End If

                If Me.numFinancimiento.Value > Me.NumMonto.Value Then
                    Me.ErrorProvider.SetError(Me.NumMonto, "El limite de crédito del Expediente ha sido excedido.")
                    T.RollbackTran()
                    Exit Sub
                End If

                objDetalleFact.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01") '01=VIGENTE
                objDetalleFact.Update(T)

                'objSccCuentaCobrar.Retrieve(Me.IDCuenta, Me.IDTienda, T)
                'objSccCuentaCobrar.Saldo = objDetalleFact.MontoTotal 'objSccCuentaCobrar.Saldo + objDetalleFact.MontoTotal
                'objSccCuentaCobrar.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "VIGENTE")
                'objSccCuentaCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                'objSccCuentaCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                'objSccCuentaCobrar.Update(T)
                T.CommitTran()

                'INICIAR PROCESO DE REESTRUCTURACION DE CUENTA
                Dim Parametros(2) As SqlClient.SqlParameter

                Parametros(0) = New SqlClient.SqlParameter("@SccCuentaId", SqlDbType.VarChar, 15)
                Parametros(0).Value = Me.IDCuenta

                Parametros(1) = New SqlClient.SqlParameter("@objTiendaID", SqlDbType.Int, 4)
                Parametros(1).Value = Me.IDTienda

                T.BeginTran()
                SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "usp_ReestructuracionCuentaCliente", Parametros)
                T.CommitTran()

                'MsgBox("Factura procesada Exitosamente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
      
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Catch ex As Exception
            T = Nothing
            objDetalleFact = Nothing
            'objSccCuentaCobrar = Nothing
        End Try
    End Sub

#End Region

    Private Sub txtTarjeta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTarjeta.TextChanged
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub numDescuentoPorc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDescuentoPorc.TextChanged
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmdCambioFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCambioFecha.Click
        Dim objFrmFechas As New frmSfaCambiosPagos
        Try
            objFrmFechas.IdDetalleFact = Me.IDDetalleFact
            If objFrmFechas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.dtpFechaProximoPago.Value = objFrmFechas.dtpNuevoPago.Value
                Me.BoolOK = True
                Me.cmdCambioFecha.Enabled = False
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Inhabilitar()
        Me.txtFactura.Enabled = False
        Me.txtNumCuenta.Enabled = False
        Me.txtCodTienda.Enabled = False
        Me.cmdAceptar.Enabled = False
        Me.cmbConcepto.Enabled = False
        Me.cmbModelos.Enabled = False
        Me.NumMonto.Enabled = False
        Me.txtChasis.Enabled = False
        Me.txtNumMotor.Enabled = False
        Me.cmbEmpleado.Enabled = False
        Me.cmdExpediente.Enabled = False
        Me.chkDebito.Enabled = False
        Me.numDescuentoPorc.Enabled = False
        Me.dtpFechaCredito.Enabled = False
        Me.cmbPlazo.Enabled = False
        Me.cmdCambioFecha.Enabled = False
        Me.txtTarjeta.Enabled = False
    End Sub

    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        If Not Me.blnReestructurarCuenta Then
            Me.ProcesarExpedienteFact(Me.IDDetalleFact)
        Else
            ProcesarFactura_ReestructurarCuenta()
        End If

    End Sub

    Private Sub numPrima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numPrima.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmbModelos.Focus()
        End If
    End Sub

    Private Sub numPrima_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numPrima.Validating
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccCuentaPorCobrarDetalle.GetMaxLength("MontoPrima")
            s = SccCuentaPorCobrarDetalle.GetScale("MontoPrima")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.numPrima.Value > ValorMaximo Then
                Me.ErrorProvider.SetError(Me.numPrima, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.numPrima.Value = 0
            Else
                Me.ErrorProvider.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProvider.SetError(Me.numPrima, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.numPrima.Value = 0
        End Try
    End Sub

    Private Sub numPrima_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numPrima.ValueChanged
        If Me.NumMonto.Text.Trim.Length > 0 Then
            If Convert.ToDouble(NumMonto.Text) > 0 Then
                Me.CalcularInformacion()
            End If
        End If
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub NumMonto_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NumMonto.Validating
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccCuentaPorCobrarDetalle.GetMaxLength("MontoTotal")
            s = SccCuentaPorCobrarDetalle.GetScale("MontoTotal")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.NumMonto.Value > ValorMaximo Then
                Me.ErrorProvider.SetError(Me.NumMonto, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.NumMonto.Value = 0
            Else
                Me.ErrorProvider.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProvider.SetError(Me.NumMonto, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.numLimiteCredito.Value = 0
        End Try
    End Sub

    Private Sub dtpFechaCredito_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaCredito.ValueChanged
        If Not dtpFechaCredito.ValueIsDbNull Then
            If Me.dtpFechaCredito.Value > clsProyecto.Conexion.FechaServidor Then
                Me.dtpFechaCredito.Value = clsProyecto.Conexion.FechaServidor
            End If

            Me.dtpFechaProximoPago.Value = dtpFechaCredito.Value.AddMonths(1)
            Me.dtpFechaVencimiento.Value = dtpFechaCredito.Value.AddMonths(Me.cmbPlazo.Columns("Codigo").Value)
        End If
    End Sub

    Private Sub LimpiarDatosNuevo()
        Try

            Me.txtFactura.Enabled = True
            Me.txtNumCuenta.Enabled = False
            Me.txtCodTienda.Enabled = False
            Me.cmdAceptar.Enabled = True
            Me.cmbConcepto.Enabled = True
            Me.NumMonto.Enabled = True
            If Me.cmbConcepto.SelectedValue = Me.ConceptoMoto Then
                Me.txtChasis.Enabled = True
                Me.txtNumMotor.Enabled = True
                Me.cmbModelos.Enabled = True
            End If

            Me.cmbEmpleado.Enabled = True
            Me.chkDebito.Enabled = True
            Me.numDescuentoPorc.Enabled = True
            Me.cmbPlazo.Enabled = True
            Me.cmdCambioFecha.Enabled = False

            Me.txtChasis.Text = ""
            Me.txtFactura.Text = ""
            Me.txtNumMotor.Text = ""
            Me.numCuotas.Value = 0.0
            Me.NumMonto.Value = 0.0
            Me.numFinancimiento.Value = 0.0
            Me.numPrima.Value = 0.0
            Me.numSaldo.Value = 0.0
            Me.numMontoCuotas.Value = 0.0
            Me.cmbPlazo.SelectedValue = -1
            Me.chkDebito.Checked = False
            Me.txtTarjeta.Text = ""
            Me.numDescuentoPorc.Value = 0.0
            Me.cmbEmpleado.SelectedValue = 0.0
            Me.cmdProcesar.Enabled = False
            Me.cmdCambioFecha.Enabled = False
            Me.cmdAceptar.Enabled = True
            Me.CalculoDiferenciaCredito()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub NumMonto_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumMonto.ValueChanged
        If Me.NumMonto.Value <= 0 Then
            Me.NumMonto.Value = 0
            Exit Sub
        End If

        If Me.cmbPlazo.Text <> "" Then
            If Me.NumMonto.Value > 0 Then
                Me.numMontoCuotas.Value = Me.NumMonto.Value / Me.cmbPlazo.Columns("Codigo").Value
            End If
        End If

        If Me.NumMonto.Text.Trim.Length > 0 Then
            If Convert.ToDouble(NumMonto.Text) > 0 Then
                Me.CalcularInformacion()
            End If
        End If
    End Sub


    
End Class