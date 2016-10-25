
Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos
Imports System.Data.SqlClient

''' <summary>
''' Formulario Principal de Carga y Guardado de Facturas.
''' Autor : Enrique José Escobar Maradiaga
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
    Dim objFact As SfaFacturas
    Dim m_IDCuenta As String
    Dim DtDatosPlazos As DataTable
    Dim m_IdPlazo As Integer
    'Dim m_IDClasificacion As Integer
    Dim m_IDEstado As Integer
    Dim m_IdDetalleFact As Integer
    Dim BoolOK As Boolean

    'Usado en caso de Reestructurar la cuenta del cliente
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
    'Property IDClasificacion() As Integer
    '    Get
    '        IDClasificacion = Me.m_IDClasificacion
    '    End Get
    '    Set(ByVal value As Integer)
    '        Me.m_IDClasificacion = value
    '    End Set
    'End Property

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

    ''' <summary>
    ''' Evento de Llamado de Metodos para Cargar Datos.
    ''' Autor : Pedro Pablo Tinoco.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Try
            Call Me.SetearValoresInicio()
            Call Me.CargarPlazos()
            Me.cmdExpediente.Focus()

            If Me.TypGui > 0 Then
                Call Me.CargarDatosEdicionConsulta()
            End If
            If Me.TypGui = 2 Or TypGui = 3 Then
                Me.txtFactura.Enabled = False
                Me.txtNumCuenta.Enabled = False
                Me.cmdAceptar.Enabled = False
                Me.NumMonto.Enabled = False
                Me.cmdExpediente.Enabled = False
                Me.numDescuentoPorc.Enabled = False
                Me.dtpFechaCredito.Enabled = False
                Me.cmbPlazo.Enabled = False
                Me.numPrima.Enabled = False

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#Region "Eventos"

    Private Sub frmSfaFaturaEditar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.CargarDatos()

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

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
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

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub NumMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

#End Region

#Region "Validacion Guardado de Datos"

    Private Sub CalculoDiferenciaCredito()
        Dim MontoPrima As Decimal
        Dim MontoTotal As Decimal
        Dim IDEstadoReg As Integer
        Try
            Try        
                IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
                MontoPrima = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID = '" & Me.IDCuenta & "' AND objEstadoID <>" & IDEstadoReg.ToString & " and objSfaFacturaID IS NOT NULL", , "isnull(SUM(ISNULL(MontoPrima,0.0)),0.0) AS Monto").DefaultView.Item(0)("Monto")
                MontoTotal = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID = '" & Me.IDCuenta & "' AND objEstadoID <>" & IDEstadoReg.ToString & " and objSfaFacturaID IS NOT NULL", , "isnull(SUM(isnull(MontoTotal,0.0)),0.0) as Monto").DefaultView.Item(0)("Monto")
                MontoTotal = MontoTotal - MontoPrima
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
        Dim objFactura As New SfaFacturas
        Dim objCuentaCobrarDetalle As New SccCuentaPorCobrarDetalle
        Try
            BoolRst = True
            Try

                T.BeginTran()

                If Me.TypGui = 1 Then
                    objFactura.Retrieve(Me.IDFactura)
                    objCuentaCobrarDetalle.RetrieveByFilter("objSccCuentaID='" & Me.IDCuenta & "' AND objSfaFacturaID=" & Me.IDFactura)
                    'Else
                    '    If objFactura.RetrieveByFilter("Numero = '" & Trim(Me.txtFactura.Text) & "'" & "", T) Then
                    '        Me.ErrorProvider.SetError(Me.txtFactura, "Número de Factura ya existe en el Sistema")
                    '        BoolRst = False
                    '        T.RollbackTran()
                    '        Exit Function
                    '    End If
                End If

                ' '' Creacion del Registro de Factura
                'objFactura.Numero = Trim(Me.txtFactura.Text)
                'objFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                'objFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario

                'objFactura.Fecha = Me.dtpFechaCredito.Value
                'If Me.TypGui = 0 Then
                '    objFactura.Insert(T)
                'Else
                '    objFactura.Update()
                'End If

                '' Creacion del Registro de Detalle de Cuenta de la Factura
                objCuentaCobrarDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objCuentaCobrarDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objCuentaCobrarDetalle.objSfaFacturaID = Trim(Me.txtFactura.Text) 'objFactura.SfaFacturaID
                objCuentaCobrarDetalle.MontoTotal = NumMonto.Value 'objFactura.TotalCordobas
                objCuentaCobrarDetalle.objSccCuentaID = Me.IDCuenta
                objCuentaCobrarDetalle.MontoAbonado = 0.0
                objCuentaCobrarDetalle.Saldo = numSaldo.Value 'objFactura.TotalCordobas
                objCuentaCobrarDetalle.MontoCuota = Me.numMontoCuotas.Value
                objCuentaCobrarDetalle.objTeminoPlazoID = Me.cmbPlazo.SelectedValue

                objCuentaCobrarDetalle.Descuento = Me.numDescuentoPorc.Value
                objCuentaCobrarDetalle.objEstadoID = Me.IDEstado
                objCuentaCobrarDetalle.FechaProximoPago = Me.dtpFechaProximoPago.Value
                objCuentaCobrarDetalle.FechaVencimiento = Me.dtpFechaVencimiento.Value
                objCuentaCobrarDetalle.MontoPrima = Me.numPrima.Value
                If Me.TypGui = 0 Then
                    objCuentaCobrarDetalle.Insert(T)
                Else
                    objCuentaCobrarDetalle.Update(T)
                End If
                Me.IDDetalleFact = objCuentaCobrarDetalle.SccCuentaPorCobrarDetalleID

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

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
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
            p = SfaFacturas.GetMaxLength("MontoTotal")
            s = SfaFacturas.GetScale("MontoTotal")
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

        If Trim(Me.cmbPlazo.Text) = "" Then
            Me.ErrorProvider.SetError(Me.cmbPlazo, "Campo Obligatorio")
            Return False
            Exit Function
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
                objFact = New SfaFacturas
                objFact.Retrieve(Me.IDFactura)
                '  Me.txtNoCuenta.Text = objFact.objSccCuentaID
                Me.txtFactura.Text = objFact.Numero
                Me.NumMonto.Value = objFact.TotalCordobas
                Me.dtpFechaCredito.Value = objFact.Fecha

                objCuentaDetalle.RetrieveByFilter("objSfaFacturaID ='" + objFact.SfaFacturaID.ToString & "'")
                Me.IDDetalleFact = objCuentaDetalle.SccCuentaPorCobrarDetalleID
                Me.IDCuenta = objCuentaDetalle.objSccCuentaID
                Me.numMontoCuotas.Value = objCuentaDetalle.MontoCuota

                If objCuentaDetalle.objTeminoPlazoID.HasValue Then
                    Me.cmbPlazo.SelectedValue = objCuentaDetalle.objTeminoPlazoID
                End If

                Me.numDescuentoPorc.Value = objCuentaDetalle.Descuento
                Me.numCuotas.Value = Me.cmbPlazo.Columns("Codigo").Value
                Me.numSaldo.Value = objCuentaDetalle.Saldo
                Me.numFinancimiento.Value = objCuentaDetalle.MontoTotal - objCuentaDetalle.MontoPrima

                If objCuentaDetalle.objEstadoID.HasValue Then
                    Me.IDEstado = objCuentaDetalle.objEstadoID
                End If

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

                dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccCuentaID,Cliente", "vwSccCuentasSeleccion", "SccCuentaID='" & Me.IDCuenta.ToString & "'"))
                Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("SccCuentaID")
                Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Cliente")

                Me.numPrima.Value = objCuentaDetalle.MontoPrima
                Me.CalculoDiferenciaCredito()

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
                    Me.txtNumCuenta.Text = objCuentasSeleccion.SccCuentaID
                    Me.IDCuenta = objCuentasSeleccion.SccCuentaID
                    Me.txtCliente.Text = objCuentasSeleccion.Cliente
                    Me.InhabilitarDatos(0, True)
                    objCuenta = New SccCuentaPorCobrar
                    objCuenta.Retrieve(Me.IDCuenta)
                    Me.dtpFechaCredito.Value = objCuenta.FechaCredito
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
            Me.txtCliente.Clear()
            Me.txtNumCuenta.Clear()
            Me.cmbPlazo.SelectedValue = 0
            Me.NumMonto.Value = 0.0
            Me.txtFactura.Clear()
            Me.numMontoCuotas.Value = 0.0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region


#Region "MANEJO DE EVENTOS KEYPRESS"

    Private Sub txtNumMotor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.cmbPlazo.Focus()
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
        End If
    End Sub

    Private Sub NumMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmbPlazo.Focus()
        If cmbPlazo.Text <> "" Then
            Me.CalcularInformacion()
        Else
            Me.numCuotas.Value = 0
            Me.numSaldo.Value = 0
            Me.numMontoCuotas.Value = 0
        End If
        End If
    End Sub

    Private Sub txtTarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
                    'Me.IDClasificacion = ClsCatalogos.ObtenerIDSTbCatalogo("CLASIFICACIONCUENTA", "OK")
                    Me.txtEstado.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDEstado.ToString, "")).DefaultView.Item(0)("Descripcion")
                Case 1
                    If Me.IDEstado > 0 Then
                        Me.txtEstado.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDEstado.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If

                Case 2
                    If Me.IDEstado > 0 Then
                        Me.txtEstado.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDEstado.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If

                  
                Case 3
                    If Me.IDEstado > 0 Then
                        Me.txtEstado.Text = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerCatalogoValor("Descripcion", "StbValorCatalogoID=" & Me.IDEstado.ToString, "")).DefaultView.Item(0)("Descripcion")
                    End If

                   
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.ValidacionEntradas Then

            Me.BoolOK = Me.GuardarFactura

            If Me.BoolOK Then
                Me.Inhabilitar()
                Me.cmdProcesar.Enabled = True
                Me.ToolTip.Show("Cancelar para Salir, ó puede Procesar la Factura desde esta pantalla.", Me.lblInfo, 15000)
            End If
        End If
    End Sub

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

    Private Sub cmdCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.BoolOK Then
            Select Case MsgBox("¿Desea crear otro Expediente-Factura para el mismo Expediente de Cuenta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Me.LimpiarDatosNuevo()
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

                'If Not Me.Validacion(T) Then
                '    MsgBox("La adición de este Monto al expediente excede el Límite de Crédito", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                '    T.RollbackTran()
                '    Exit Sub
                'Else
                objDetalleFact.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objDetalleFact.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objDetalleFact.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")
                objDetalleFact.Update(T)
                'End If

                objSccCuentaCobrar.Retrieve(Me.IDCuenta, T)
                objSccCuentaCobrar.Saldo = objSccCuentaCobrar.Saldo + objDetalleFact.MontoTotal
                objSccCuentaCobrar.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "VIGENTE")
                objSccCuentaCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSccCuentaCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSccCuentaCobrar.Update(T)

                T.CommitTran()
                MsgBox("Factura procesada Exitosamente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                If BoolNC Then
                    MsgBox("Se ha generado una Nota de Crédito para Expedientes-Facturas por Débito Automático.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                End If

                Select Case MsgBox("¿Desea crear otro Expediente-Factura para el mismo Expediente de Cuenta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        Me.TypGui = 0
                        Me.LimpiarDatosNuevo()
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

    Private Sub txtTarjeta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub numDescuentoPorc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDescuentoPorc.TextChanged
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmdCambioFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objFrmFechas As New frmSfaCambiosPagos
        Try
            objFrmFechas.IdDetalleFact = Me.IDDetalleFact
            If objFrmFechas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.dtpFechaProximoPago.Value = objFrmFechas.dtpNuevoPago.Value
                Me.BoolOK = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Inhabilitar()
        Me.txtFactura.Enabled = False
        Me.txtNumCuenta.Enabled = False
        Me.cmdAceptar.Enabled = False
        Me.NumMonto.Enabled = False
        Me.cmdExpediente.Enabled = False
        Me.numDescuentoPorc.Enabled = False
        Me.dtpFechaCredito.Enabled = False
        Me.cmbPlazo.Enabled = False
    End Sub

    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ProcesarExpedienteFact(Me.IDDetalleFact)
    End Sub

    Private Sub numPrima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numPrima.KeyPress
        If Asc(e.KeyChar) = 13 Then
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
            Me.cmdAceptar.Enabled = True
            Me.NumMonto.Enabled = True
            Me.numDescuentoPorc.Enabled = True
            Me.cmbPlazo.Enabled = True
            Me.txtFactura.Text = ""
            Me.numCuotas.Value = 0.0
            Me.NumMonto.Value = 0.0
            Me.numFinancimiento.Value = 0.0
            Me.numPrima.Value = 0.0
            Me.numSaldo.Value = 0.0
            Me.numMontoCuotas.Value = 0.0
            Me.cmbPlazo.SelectedValue = -1
            Me.numDescuentoPorc.Value = 0.0
            Me.cmdProcesar.Enabled = False
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