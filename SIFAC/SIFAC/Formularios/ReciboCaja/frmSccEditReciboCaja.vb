Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Data

''' <summary>
''' Pantalla de Guardado y Edicion de Recibos de Caja.
''' Autor : Pedro Pablo Tinoco Salgado.
''' Fecha : 24 de Marzo de 2009.
''' </summary>
''' <remarks></remarks>
Public Class frmSccEditReciboCaja

    Dim DtDatosReciboCaja As New DataTable
    Dim DtDatosNotasCredito As DataTable
    Dim DtdatosNotasDebito As DataTable
    Dim DtDatosFactRecibo As DataTable
    Dim DtDatosMonedaPago As DataTable
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim m_TyGui As Integer
    Dim MontoPrima As Decimal
    Dim m_IDFactVig As Integer
    Dim m_ReciboCajaID As Integer
    Dim m_BoolResult As Boolean

    '-------------------Variables de Totalizacion de Datos ------------------------
    Dim DecTotalFact As Decimal
    Dim DecTotalND As Decimal
    Dim DecTotalRecibo As Decimal
    Dim DecTotalAbonado As Decimal
    Dim DecTotalEfect As Decimal
    Dim DecTotalNC As Decimal
    Dim DecTotalOtros As Decimal
    Dim objReciboCaja As SccReciboCaja
    Dim objSeg As SsgSeguridad
    Dim m_Cliente As String

    'Variables para tratamiento de "Reestructuración de Cuenta"
    Public blnReestructurarCuenta As Boolean = False

    Property ReciboCajaID() As Integer
        Get
            ReciboCajaID = Me.m_ReciboCajaID
        End Get
        Set(ByVal value As Integer)
            Me.m_ReciboCajaID = value
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

    Property IDTienda() As Integer
        Get
            IDTienda = m_IDTienda
        End Get
        Set(ByVal value As Integer)
            m_IDTienda = value
        End Set
    End Property

    Property TypGui() As Integer
        Get
            TypGui = m_TyGui
        End Get
        Set(ByVal value As Integer)
            m_TyGui = value
        End Set
    End Property

    Property IDFactVig() As Integer
        Get
            IDFactVig = Me.m_IDFactVig
        End Get
        Set(ByVal value As Integer)
            Me.m_IDFactVig = value
        End Set
    End Property

    Property BoolResult() As Boolean
        Get
            BoolResult = Me.m_BoolResult
        End Get
        Set(ByVal value As Boolean)
            Me.m_BoolResult = value
        End Set
    End Property

    Property Cliente()
        Get
            Cliente = Me.m_Cliente
        End Get
        Set(ByVal value)
            Me.m_Cliente = value
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento encargado de Cargar los datos principales del Recibo en Nuevo,Edicion y Consulta.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 24 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InicializacionDatos()
        Try
            objSeg = New SsgSeguridad
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmSccReciboCaja"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSccEditReciboCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            clsProyecto.CargarTemaDefinido(Me)
            Call Me.CargarMonedaPago()
            Me.txtNumRecibo.MaxLength = SccReciboCaja.GetMaxLength("Numero")
            Select Case Me.TypGui
                Case 0
                    Me.Text = "Nuevo Recibo de Caja"
                    Me.txtEstado.Text = Me.CargarEstados(ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "REGISTRADO"))
                    Me.IDFactVig = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOFACTURA", "VIGENTE")
                    Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                Case 1
                    Me.Text = "Edicion de Recibo de Caja"
                    Me.CargarDatosEdicion()
                    Me.cmdExpediente.Enabled = False
                Case 2
                    Me.Text = "Consultar Recibo de Caja"
                    Me.CargarDatosEdicion()
                    Me.BloquearColumnasModoConsulta()
                    Me.cmdExpediente.Enabled = False
                    Me.cmdAceptar.Enabled = False
                    Me.cmdProcesar.Enabled = False
                    Me.txtNumRecibo.Enabled = False
                    clsProyecto.CargarTemaDefinido(Me)
            End Select
            Me.Panel2.BackColor = Color.White
            Me.grdFacturas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor

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
                Me.txtNumRecibo.Enabled = False
                Me.cmdExpediente.Visible = False

                'Facturas
                Me.CargarFacturas()
                For I As Integer = 0 To Me.DtDatosFactRecibo.DefaultView.Count - 1
                    Me.DtDatosFactRecibo.DefaultView.Item(I)("Seleccion") = True
                    Me.DtDatosFactRecibo.DefaultView.Item(I)("Abonar") = False
                    Me.DtDatosFactRecibo.DefaultView.Item(I)("Cancelar") = True
                    Me.DtDatosFactRecibo.DefaultView.Item(I)("CantAbonar") = Me.DtDatosFactRecibo.DefaultView.Item(I)("SaldoFactura")
                Next
                Me.DtDatosFactRecibo.AcceptChanges()
                Me.grdFacturas.Splits(0).Locked = True
                Me.grdFacturas.Splits(0).FilterBar = False

                'Notas de Débito
                Me.CargarNotasDebito()
                For I As Integer = 0 To Me.DtdatosNotasDebito.DefaultView.Count - 1
                    Me.DtdatosNotasDebito.DefaultView.Item(I)("Seleccion") = True                    
                Next
                Me.DtdatosNotasDebito.AcceptChanges()
                Me.grdNotaDebito.Splits(0).Locked = True
                Me.grdNotaDebito.Splits(0).FilterBar = False

                'Notas de Crédito
                Me.CargarNotasCredito()
                For I As Integer = 0 To Me.DtDatosNotasCredito.DefaultView.Count - 1
                    Me.DtDatosNotasCredito.DefaultView.Item(I)("Seleccion") = True
                Next
                Me.DtDatosNotasCredito.AcceptChanges()

                Me.grdNotasCredito.Splits(0).Locked = True
                Me.grdNotasCredito.Splits(0).FilterBar = False
                Me.grdFacturas.Refresh()
                Me.grdNotaDebito.Refresh()
                Me.grdNotasCredito.Refresh()

                'Cargar moneda y deshabilitar
                Me.cmbMoneda.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "USD")
                Me.cmbMoneda.Enabled = False
                Me.NumMontoDolares.Enabled = False
                Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                Me.dtpFecha.Enabled = False
                Me.chkPrima.Enabled = False
                'Me.cmbSucursal.Enabled = False
                Me.NumMontoDolares.Value = Me.DtDatosNotasCredito.DefaultView.Item(0)("Monto")

                Me.CalcularTotales()
                Me.CalculoMontoAbonado()

                'Calcular Total facturas
                'Me.grid.DataSource = Me.DtDatosFactRecibo
                'If Not Me.DtDatosFactRecibo Is Nothing Then
                '    If Me.DtDatosFactRecibo.DefaultView.Count > 0 Then
                '        Dim obj As Object = Me.DtDatosFactRecibo.Compute("SUM(Saldo)", "Seleccion = 1")
                '        If Me.DtDatosFactRecibo.DefaultView.Item(0)("Seleccion") Then
                '            MsgBox(obj.ToString)
                '        End If

                '        If Not IsDBNull(obj) Then
                '            Me.DecTotalFact = obj
                '        End If
                '    End If
                'End If

                ''Calcular total Notas de débito
                'If Not Me.DtdatosNotasDebito Is Nothing Then
                '    If Me.DtdatosNotasDebito.DefaultView.Count > 0 Then
                '        Dim obj As Object = Me.DtdatosNotasDebito.Compute("SUM(Monto)", " Seleccion = 'TRUE'")
                '        If Not IsDBNull(obj) Then
                '            Me.DecTotalND = obj
                '        End If
                '    End If
                'End If

                ''Total Nota de Crédito con la que se pagará el recibo.
                'Me.DecTotalNC = Me.DtDatosNotasCredito.DefaultView.Item(0)("Monto").ToString
                'Me.NumMontoDolares.Value = Me.DecTotalNC
                'Me.numMontoCordobas.Value = Me.DecTotalNC * Me.numTasaCambio.Value
                'Me.txtTotalDB.Value = Me.DecTotalNC

                'Me.txtTotalFact.Value = Me.DecTotalFact

                'Me.DecTotalRecibo = Me.DecTotalFact + Me.DecTotalND
                'Me.txtTotalPagar.Value = Me.DecTotalRecibo
                'Me.lblMontAbon.Text = Me.txtTotalPagar.Value
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdExpediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpediente.Click
        Call Me.SeleccionarCuenta()
    End Sub


    ''' <summary>
    ''' Procedimiento encargado de llamar la pantalla para seleccion de cuentas.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha de Creacion : 24 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SeleccionarCuenta()
        Dim objSccRecibo As New SccReciboCaja
        Try
            Me.chkPrima.Checked = False
            Me.chkPrima.Enabled = True
            Dim objCuentasSeleccion As New frmSccSeleccionCuentas
            If objCuentasSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.txtNumCuenta.Text = objCuentasSeleccion.SccCuentaID
                Me.IDCuenta = objCuentasSeleccion.SccCuentaID
                Me.txtCliente.Text = objCuentasSeleccion.Cliente
                Me.CargarInfoCuenta(Me.IDCuenta)
                Me.CargarFacturas()
                Me.CargarNotasCredito()
                Me.CargarNotasDebito()

                For Each drw As DataRow In Me.DtDatosFactRecibo.Rows
                    If drw("MontoPrima") > 0 And drw("Concepto") = "Motos" Then
                        Me.MontoPrima = drw("MontoPrima")
                        Exit For
                    End If
                Next

                If Not Me.MontoPrima = 0 Then
                    If objSccRecibo.RetrieveByFilter("EsPagoPrima=1 and objSccCuentaID='" & Me.IDCuenta & "' and objtiendaID=" & Me.IDTienda) Then
                        Me.chkPrima.Enabled = False
                    Else
                        Me.chkPrima.Checked = True
                        Me.chkPrima.Enabled = False
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Procedimiento encargado de cargar los estados de un recibo de caja
    ''' Autor : Pedro Pablo Tinoco Salgado
    ''' Fecha Creacion : 24 de Marzo de 2009
    ''' </summary>
    ''' <param name="IdEstado"></param>
    ''' <remarks></remarks>

    Private Function CargarEstados(ByVal IdEstado As Integer) As String
        Dim Valor As String = ""
        Try
            Valor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetValorCatalogoID('ESTADOROC'," + IdEstado.ToString + ",1) as Estado").DefaultView.Item(0)("Estado")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Valor
    End Function

    ''' <summary>
    ''' Procedimiento Encargado de Cargar la Informacion de la Cuenta.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 25 de Marzo de 2009.
    ''' </summary>
    ''' <param name="IDCuenta"></param>
    ''' <remarks></remarks>
    Private Sub CargarInfoCuenta(ByVal IDCuenta As String)
        Dim DtDatos As New DataTable
        Try
            DtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*", "vwSccCuenta", "SccCuentaID='" & IDCuenta & "'"))
            
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Cargar las notas de debito relacionadas a la cuenta.
    ''' Autor : Pedro Tinoco.
    ''' Fecha : 25 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarNotasDebito()
        Dim Autorizada As Integer
        Try
            Autorizada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOND", "AUTORIZADA")
            Me.DtdatosNotasDebito = New DataTable
            DtdatosNotasDebito = New DataTable
            If Me.TypGui = 2 Then
                DtdatosNotasDebito = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion", "vwReciboNotaDB", "SccCuentaID='" + Me.IDCuenta.ToString + "' and objTiendaID= " + Me.IDTienda.ToString))
            Else
                DtdatosNotasDebito = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion", "vwReciboNotaDB", "SccCuentaID='" + Me.IDCuenta.ToString + "' and objTiendaID= " + Me.IDTienda.ToString & " AND objEstadoID= " & Autorizada.ToString))
            End If
            Me.grdNotaDebito.SetDataBinding(DtdatosNotasDebito, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Cargar las notas de credito relacionadas a la cuenta.
    ''' Autor : Pedro Tinoco.
    ''' Fecha : 25 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarNotasCredito()
        Dim sSQL As String
        Dim Autorizada As Integer
        Try
            Autorizada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "AUTORIZADA")
            DtDatosNotasCredito = New DataTable
            If Me.TypGui = 2 Then
                DtDatosNotasCredito = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion", "vwReciboDetNC", "SccCuentaID='" + Me.IDCuenta.ToString + "' and objTiendaID= " + Me.IDTienda.ToString))
            Else
                'En caso de reestructuración de cuenta los datos de las notas de crédito se obtienen de la tabla operativa temporal "txRC_NotaCredito_Step1"
                If Not Me.blnReestructurarCuenta Then
                    sSQL = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion", "vwReciboDetNC", "SccCuentaID='" + Me.IDCuenta.ToString + "' and objTiendaID= " + Me.IDTienda.ToString & " AND objEstadoID=" & Autorizada.ToString)
                Else
                    Dim sConsulta As String = "SELECT CAST(0 AS BIT) AS Seleccion, Fecha, Monto, SccNotaCreditoID, dbo.FnGetValorCatalogoId('CONCEPTONC', objConceptoID, 1) AS Concepto, objEstadoID, objConceptoID, " & _
                                              " dbo.fnRellenarCeros(Numero) AS Numero, objSccCuentaID AS SccCuentaId, objTiendaID " & _
                                              " FROM dbo.txRC_NotaCredito_Step1 "
                    Dim sFiltro = " WHERE objSccCuentaID='" + Me.IDCuenta.ToString + "' and objTiendaID= " + Me.IDTienda.ToString & " AND objEstadoID=" & Autorizada.ToString

                    sSQL = sConsulta + sFiltro + " GROUP BY Fecha, Monto, SccNotaCreditoID, dbo.FnGetValorCatalogoId('CONCEPTONC', objConceptoID, 1), objEstadoID, objConceptoID, dbo.fnRellenarCeros(Numero), objSccCuentaID, objTiendaID"
                End If
                DtDatosNotasCredito = SqlHelper.ExecuteQueryDT(sSQL)
                End If
                Me.grdNotasCredito.SetDataBinding(DtDatosNotasCredito, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar las facturas correspondientes.
    ''' Autor : Pedro Tinoco Salgado.
    ''' Modificado por: Gelmin Martínez, 13 Abril 2010
    ''' Fecha : 3 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarFacturas()
        Dim Registrada As Integer
        Dim Cancelada As Integer
        Dim ConceptoReestructuracion As Integer
        Dim sConsulta As String
        Try
            Registrada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
            Cancelada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "02")
            ConceptoReestructuracion = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTOFACTURA", "05")

            Me.DtDatosFactRecibo = New DataTable
            If Me.TypGui = 2 Then
                sConsulta = clsConsultas.ObtenerConsultaGeneral("*,Saldo-SaldoND as SaldoFactura,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetFactura", "objSccCuentaID='" & Me.IDCuenta & "' and objTiendaID=" & Me.IDTienda & " AND objConceptoFactura <> " + ConceptoReestructuracion.ToString)
                Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)
            Else
                sConsulta = clsConsultas.ObtenerConsultaGeneral("*,Saldo-SaldoND as SaldoFactura,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetFactura", "objSccCuentaID='" & Me.IDCuenta & "' and objTiendaID=" & Me.IDTienda & " and objEstadoID <>" & Registrada & " AND objEstadoID<>" & Cancelada)
                Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)
            End If
            Me.grdFacturas.SetDataBinding(Me.DtDatosFactRecibo, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

   
    ''' <summary>
    ''' Procedimiento Encargado de Cargar Monedas de Pago
    ''' Autor : Pedro Pablo Tinoco.
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarMonedaPago()
        Dim objTasaCambio As New StbTasaCambioOficial
        Try
            Try

            Me.DtDatosMonedaPago = ClsCatalogos.ObtenerValCat("MONEDA")
                With Me.cmbMoneda
                    .DataSource = Me.DtDatosMonedaPago
                    .ValueMember = "StbValorCatalogoID"
                    .DisplayMember = "Descripcion"
                    .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                    .Splits(0).DisplayColumns("Codigo").Visible = False
                    .Splits(0).DisplayColumns("Activo").Visible = False
                    .ExtendRightColumn = True
                End With
                If Me.TypGui = 0 Then
                    objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & " and Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString)
                    Me.numTasaCambio.Value = objTasaCambio.Monto                
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objTasaCambio = Nothing
        End Try
    End Sub

#Region "EVENTOS DE CONTROLES"

    Private Sub cmbMoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMoneda.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Select Case Me.cmbMoneda.Columns("Codigo").Value.ToString
                Case "COR"
                    Me.numMontoCordobas.Focus()
                Case "USD"
                    Me.NumMontoDolares.Focus()
            End Select
        End If
    End Sub
    Private Sub cmbMoneda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.TextChanged
        Me.ErrorProv.Clear()
        If Not Me.DtDatosMonedaPago Is Nothing Then
            Select Case Me.cmbMoneda.Columns("Codigo").Value.ToString
                Case "COR"
                    Me.NumMontoDolares.Enabled = False
                    Me.numMontoCordobas.Enabled = True
                Case "USD"
                    Me.numMontoCordobas.Enabled = False
                    Me.NumMontoDolares.Enabled = True                    
            End Select
            Me.NumMontoDolares.Value = 0.0
            Me.numMontoCordobas.Value = 0.0
        End If
    End Sub

    Private Sub numMontoCordobas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numMontoCordobas.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Me.cmdAceptar.Focus()
        End If
    End Sub

    Private Sub numMontoCordobas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numMontoCordobas.Validating
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccReciboCaja.GetMaxLength("TotalRecibo")
            s = SccReciboCaja.GetScale("TotalRecibo")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.numMontoCordobas.Value > ValorMaximo Then
                Me.ErrorProv.SetError(Me.numMontoCordobas, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.numMontoCordobas.Value = 0
            Else
                Me.ErrorProv.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProv.SetError(Me.numMontoCordobas, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.numMontoCordobas.Value = 0
        End Try
    End Sub

    Private Sub numMontoCordobas_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numMontoCordobas.ValueChanged
        Me.ErrorProv.Clear()
        If Not IsDBNull(Me.numMontoCordobas.Value) Then
            If Me.numMontoCordobas.Value < 0 Then
                Me.numMontoCordobas.Value = 0.0
                Me.NumMontoDolares.Value = 0.0
            Else
                If Not IsDBNull(Me.numTasaCambio.Value) Then
                    If Me.numTasaCambio.Value <> 0.0 Then 'si la tasaCambio no es cero.
                        Me.NumMontoDolares.Value = (Me.numMontoCordobas.Value / Me.numTasaCambio.Value)
                    End If
                    Me.DecTotalEfect = Me.NumMontoDolares.Value
                End If
                End If
        End If
    End Sub

    Private Sub NumMontoDolares_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumMontoDolares.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Me.cmdAceptar.Focus()
        End If
    End Sub

    Private Sub NumMontoDolares_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NumMontoDolares.Validating
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccReciboCaja.GetMaxLength("TotalRecibo")
            s = SccReciboCaja.GetScale("TotalRecibo")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.NumMontoDolares.Value > ValorMaximo Then
                Me.ErrorProv.SetError(Me.NumMontoDolares, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.NumMontoDolares.Value = 0
            Else
                Me.ErrorProv.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProv.SetError(Me.NumMontoDolares, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.NumMontoDolares.Value = 0
        End Try
    End Sub

    Private Sub NumMontoDolares_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumMontoDolares.ValueChanged
        Me.ErrorProv.Clear()
        If Not IsDBNull(Me.NumMontoDolares.Value) Then
            If Me.NumMontoDolares.Value < 0 Then
                Me.NumMontoDolares.Value = 0.0
                Me.numMontoCordobas.Value = 0.0
            Else
                Me.DecTotalEfect = Me.NumMontoDolares.Value
                If Not IsDBNull(Me.numTasaCambio.Value) Then
                    Me.numMontoCordobas.Value = (Me.NumMontoDolares.Value * Me.numTasaCambio.Value)
                End If
            End If
            CalculoMontoAbonado()
        End If
    End Sub

    Private Sub grdFacturas_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdFacturas.AfterColEdit
        Dim IDFactura As Integer
        IDFactura = Me.DtDatosFactRecibo.DefaultView.Item(Me.grdFacturas.Row)("SfaFacturaID")

        If (Me.grdFacturas.Columns("Cancelar").Value = True) And (IsDBNull(Me.grdFacturas.Columns("Monto Abonar").Value)) Then
            Me.grdFacturas.Columns("Monto Abonar").Value = Me.grdFacturas.Columns("Saldo Factura").Value
        End If

        If IsDBNull(Me.grdFacturas.Columns("Monto Abonar").Value) And Me.grdFacturas.Columns("Incluir").Value = True Then
            Me.grdFacturas.Columns("Monto Abonar").Value = 1
        ElseIf IsDBNull(Me.grdFacturas.Columns("Monto Abonar").Value) And Me.grdFacturas.Columns("Incluir").Value = False Then
            Me.grdFacturas.Columns("Monto Abonar").Value = 0
        ElseIf Not IsDBNull(Me.grdFacturas.Columns("Monto Abonar").Value) And (Me.grdFacturas.Columns("Monto Abonar").Value) < 0 Then
            Me.grdFacturas.Columns("Monto Abonar").Value = 0.0
        End If

        If Me.grdFacturas.Columns("Monto Abonar").Value > Me.grdFacturas.Columns("Saldo Factura").Value Then
            Me.grdFacturas.Columns("Monto Abonar").Value = Me.grdFacturas.Columns("Saldo Factura").Value
        End If

        Me.ValidarAbonarCancelar()
        ''  boolCambioHecho = True
    End Sub

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

        Try
            boolInc = Me.DtDatosFactRecibo.DefaultView.Item(Me.grdFacturas.Row)("Seleccion")
            boolAbonar = Me.DtDatosFactRecibo.DefaultView.Item(Me.grdFacturas.Row)("Abonar")
            boolCancelar = Me.DtDatosFactRecibo.DefaultView.Item(Me.grdFacturas.Row)("Cancelar")
            IdFactura = Me.DtDatosFactRecibo.DefaultView.Item(Me.grdFacturas.Row)("SfaFacturaID")

            intOpcionEnviar = 0

            Select Case Me.grdFacturas.Col
                Case 0

                    Select Case boolInc
                        Case True
                            Me.grdFacturas.Columns("Cancelar").Value = True
                            Me.grdFacturas.Columns("Monto Abonar").Value = Me.grdFacturas.Columns("Saldo Factura").Value

                        Case False
                            Me.grdFacturas.Columns("Cancelar").Value = False
                            Me.grdFacturas.Columns("Abonar").Value = False
                            Me.grdFacturas.Columns("Monto Abonar").Value = 0.0
                    End Select

                Case 4
                    If (Me.grdFacturas.Columns("Incluir").Value = False) Then
                        Me.grdFacturas.Columns("Cancelar").Value = False
                        Me.grdFacturas.Columns("Abonar").Value = False
                        Exit Sub
                    End If
                    Select Case boolAbonar
                        Case True
                            Me.grdFacturas.Columns("Cancelar").Value = False
                            Me.grdFacturas.Columns("Monto Abonar").Value = Me.grdFacturas.Columns("Monto Cuota").Value

                        Case False
                            Me.grdFacturas.Columns("Cancelar").Value = True
                            Me.grdFacturas.Columns("Monto Abonar").Value = Me.grdFacturas.Columns("Saldo Factura").Value
                    End Select

                Case 5
                    If (Me.grdFacturas.Columns("Incluir").Value = False) Then
                        Me.grdFacturas.Columns("Cancelar").Value = False
                        Me.grdFacturas.Columns("Abonar").Value = False
                        Exit Sub
                    End If

                    Select Case boolCancelar
                        Case True
                            Me.grdFacturas.Columns("Monto Abonar").Value = Me.grdFacturas.Columns("Saldo Factura").Value
                            Me.grdFacturas.Columns("Abonar").Value = False
                        Case False
                            Me.grdFacturas.Columns("Abonar").Value = True
                            Me.grdFacturas.Columns("Monto Abonar").Value = Me.grdFacturas.Columns("Monto Cuota").Value

                    End Select
                Case 6
                    If (Me.grdFacturas.Columns("Monto Abonar").Value > Me.grdFacturas.Columns("Saldo Factura").Value) And boolAbonar = True Then
                        Me.grdFacturas.Columns("Monto Abonar").Value = 0.0
                    End If
            End Select
            Me.DtDatosFactRecibo.AcceptChanges()
            Me.grdFacturas.Refresh()
            Me.CalcularTotales()
            Me.CalculoMontoAbonado()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub grdNotasCredito_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotasCredito.AfterColEdit
        Select Case Me.grdNotasCredito.Columns("Incluir").Value
            Case True
                Me.DtDatosNotasCredito.DefaultView.Item(Me.grdNotasCredito.Row)("Seleccion") = True
            Case False
                Me.DtDatosNotasCredito.DefaultView.Item(Me.grdNotasCredito.Row)("Seleccion") = False
        End Select
        Me.DtDatosNotasCredito.AcceptChanges()
        Me.CalcularTotales()
        CalculoMontoAbonado()

        'boolCambioHecho = True
        'If Me.cmdAceptar.Enabled = False Then
        '    Me.cmdAceptar.Enabled = True
        'End If
        'Me.CalcularTotales()

    End Sub

    Private Sub chkPrima_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrima.CheckedChanged
        If chkPrima.Checked Then
            Me.InhabilitarDatos()
        Else
            Me.DecTotalRecibo = 0.0
            Me.txtTotalPagar.Value = 0.0
            Me.grdFacturas.Splits(0).Locked = False
            Me.grdNotaDebito.Splits(0).Locked = False
            Me.grdNotasCredito.Splits(0).Locked = False
        End If
    End Sub


    Private Sub grdNotaDebito_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotaDebito.AfterColEdit
        Select Case Me.grdNotaDebito.Columns("Incluir").Value
            Case True
                Me.DtdatosNotasDebito.DefaultView.Item(Me.grdNotaDebito.Row)("Seleccion") = True
            Case False
                Me.DtdatosNotasDebito.DefaultView.Item(Me.grdNotaDebito.Row)("Seleccion") = False
        End Select
        Me.DtdatosNotasDebito.AcceptChanges()
        Me.CalcularTotales()
        CalculoMontoAbonado()
        'CalcularTotales()
        'boolCambioHecho = True
        'If Me.cmdAceptar.Enabled = False Then
        '    Me.cmdAceptar.Enabled = True
        'End If
    End Sub

    Private Sub grdNotaDebito_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotaDebito.AfterColUpdate
        CalculoMontoAbonado()
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
                    Case 6
                        If boolCancelar Then
                            e.Handled = True
                            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                            Exit Sub
                        End If
                End Select
            Case False
                e.Handled = True
                e.KeyChar = Microsoft.VisualBasic.ChrW(0)
                Exit Sub
        End Select
    End Sub

    Private Sub grdNotaDebito_Error(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ErrorEventArgs)
        e.Handled = True
        e.Continue = True
    End Sub

  

#End Region

#Region "Calculo de Totales"
    ''' <summary>
    ''' Procedimiento Encargado de Llevar a Cabo el Calculo de Total a Pagar del Recibo.
    ''' Autor : Pedro Tinoco Salgado.
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalcularTotales()
        Dim DecSumTotalND As Decimal
        Dim DecSumMontoFactura As Decimal
        Dim obj As New Object

        Try
            If Not Me.DtDatosFactRecibo Is Nothing Then
                '---------------------Calculamos el monto original de cada factura--------------------------------
                If Me.DtDatosFactRecibo.DefaultView.Count > 0 Then
                    obj = Me.DtDatosFactRecibo.Compute("SUM(CantAbonar)", "Seleccion = 'TRUE'")
                    If Not IsDBNull(obj) Then
                        DecSumMontoFactura = obj
                    End If
                End If


                If Not Me.DtDatosNotasCredito Is Nothing Then
                    If Me.DtDatosNotasCredito.DefaultView.Count > 0 Then
                        obj = Me.DtDatosNotasCredito.Compute("SUM(Monto)", "Seleccion= 'TRUE'")
                        If Not IsDBNull(obj) Then
                            Me.DecTotalNC = obj
                        End If
                    End If
                End If

            End If
            '-------------------------------------------------------------------------------------------------
            '------------------Calculamos el Total por todas las facturas incluidas-------
            Me.DecTotalFact = DecSumMontoFactura

            If Not Me.DtdatosNotasDebito Is Nothing Then
                If Me.DtdatosNotasDebito.DefaultView.Count > 0 Then
                    obj = Me.DtdatosNotasDebito.Compute("SUM(Monto)", " Seleccion = 'TRUE'")
                    If Not IsDBNull(obj) Then
                        DecSumTotalND = obj
                    End If
                End If
            End If

            Me.DecTotalND = DecSumTotalND
            Me.DecTotalRecibo = Me.DecTotalFact + Me.DecTotalND

            If Me.chkPrima.Checked Then
                Me.DecTotalRecibo = Me.MontoPrima
            End If

            Me.txtTotalFact.Value = Decimal.Round(Me.DecTotalFact, 2)
            Me.txtTotalDB.Value = Decimal.Round(Me.DecTotalND, 2)
            Me.txtTotalPagar.Value = Decimal.Round(Me.DecTotalRecibo, 2)
            Me.numTotalPagarCor.Value = Me.DecTotalRecibo * Me.numTasaCambio.Value

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



#End Region

#Region "Guardado de Datos"
    'Private Sub ActualizarSaldoNotaDebito()
    '    Dim objSccCuentaDetalle As New SccCuentaPorCobrarDetalle
    '    Dim objDetNotaDebito As SccReciboDetND
    '    objDetNotaDebito = New SccReciboDetND
    '    Dim T As New TransactionManager
    '    Try
    '        T.BeginTran()
    '        For Each DrwNDINC As DataRow In Me.DtdatosNotasDebito.Rows
    '            If DrwNDINC("Seleccion") Then
    '                objSccCuentaDetalle.RetrieveByFilter("objSccCuentaID ='" & Me.IDCuenta & "'" & " AND objTiendaID = " & Me.IDTienda.ToString & " AND objFacturaID = " & DrwNDINC("SfaFacturaID"), T)
    '                objSccCuentaDetalle.SaldoND = objSccCuentaDetalle.SaldoND - Convert.ToDecimal(DrwNDINC("Monto"))
    '                objSccCuentaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
    '                objSccCuentaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
    '                objSccCuentaDetalle.Update(T)
    '            End If
    '        Next
    '        T.CommitTran()
    '    Catch ex As Exception
    '        T.RollbackTran()
    '        clsError.CaptarError(ex)
    '    End Try

    'End Sub
    '----------------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 14 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de realizar el proceso completo de guardado de los datos.
    '----------------------------------------------------------------------------------------------------------------------
    Private Function GuardarReciboCaja() As Boolean
        Dim Boolrst As Boolean
        Dim objReciboDetFactura As SccReciboDetFactura
        Dim objDetNotaDebito As SccReciboDetND
        Dim objDetNotaCredito As SccReciboDetNC
        Dim T As New TransactionManager

        Try
            Boolrst = False
            CalcularTotales()

            If (Me.dtpFecha.Value.Date > clsProyecto.Conexion.FechaServidor.Date) Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Fecha Incorrecta")
                Exit Function
            End If

            If Not ValidarDetalleFact() Then
                Me.ErrorProv.SetError(Me.lblError, "Datos Imcompletos")
                Exit Function
            End If

            If Trim(Me.txtNumRecibo.Text) = "" And (Not Me.blnReestructurarCuenta) Then
                Me.ErrorProv.SetError(Me.txtNumRecibo, "Campo Obligatorio.")
                Exit Function
            End If

            If Me.cmbMoneda.Text = "" Then
                Me.ErrorProv.SetError(Me.cmbMoneda, "Campo Obligatorio.")
                Exit Function
            End If

            If (Decimal.Round(Me.DecTotalAbonado, 2) <> Decimal.Round(Me.DecTotalRecibo, 2)) Or (Me.txtTotalPagar.Value = 0) Then
                Me.ErrorProv.SetError(Me.lblError, "Montos no coinciden")
                Exit Function
            End If            

            T.BeginTran()
            Me.objReciboCaja = New SccReciboCaja
            If objReciboCaja.RetrieveByFilter("Numero='" & Trim(Me.txtNumRecibo.Text) & "'") Then
                Me.ErrorProv.SetError(Me.txtNumRecibo, "Ya existe un Recibo con este número.")
                T.RollbackTran()
                Exit Function
            Else
                objReciboCaja = Nothing
            End If

            '--------------------------- Creamos el encabezado del recibo colector--------------------------
            Me.objReciboCaja = New SccReciboCaja
            Me.objReciboCaja.Numero = Trim(Me.txtNumRecibo.Text)
            Me.objReciboCaja.Fecha = Me.dtpFecha.Value.Date
            Me.objReciboCaja.TotalFacturas = Me.DecTotalFact
            Me.objReciboCaja.TotalND = Me.DecTotalND
            Me.objReciboCaja.TotalRecibo = Me.DecTotalRecibo
            Me.objReciboCaja.TotalEfectivo = Me.DecTotalEfect
            Me.objReciboCaja.TotalNC = Me.DecTotalNC
            Me.objReciboCaja.UsuarioCreacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaCreacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "REGISTRADO")
            Me.objReciboCaja.objSccCuentaID = Me.IDCuenta
            Me.objReciboCaja.objTiendaID = Me.IDTienda
            Me.objReciboCaja.EsPagoPrima = Me.chkPrima.Checked
            Me.objReciboCaja.objMonedaID = Me.cmbMoneda.SelectedValue
            '-------------------------------------------------------------------- ---------------------------
            Me.objReciboCaja.Insert(T)
            Me.ReciboCajaID = Me.objReciboCaja.SccReciboCajaID

            '---------------------------------------------------------------------------------------------
            '-----------------Creamos los detalles por cada factura procesada-----------------------------
            objReciboDetFactura = New SccReciboDetFactura
            For Each drwFactINC As DataRow In Me.DtDatosFactRecibo.Rows
                If drwFactINC("Seleccion") Then
                    objReciboDetFactura.Monto = drwFactINC("CantAbonar")
                    objReciboDetFactura.objFacturaID = drwFactINC("SfaFacturaID")
                    objReciboDetFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objReciboDetFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objReciboDetFactura.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                    If drwFactINC("Abonar") Then
                        objReciboDetFactura.EsAbono = True
                    Else
                        objReciboDetFactura.EsAbono = False
                    End If
                    objReciboDetFactura.Insert(T)
                End If
            Next
            '-------------------------------------------------------------------------------------------
            '---------------Creamos los detalles para las notas de debito-------------------------------

            objDetNotaDebito = New SccReciboDetND
            For Each DrwNDINC As DataRow In Me.DtdatosNotasDebito.Rows
                If DrwNDINC("Seleccion") Then
                    objDetNotaDebito.objNotatDebitoID = DrwNDINC("SccNotaDebitoID")
                    objDetNotaDebito.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                    objDetNotaDebito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objDetNotaDebito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objDetNotaDebito.Insert(T)
                End If
            Next
            '-------------------------------------------------------------------------------------------
            '-----------------Creamos los detalles para las notas de credito----------------------------

            objDetNotaCredito = New SccReciboDetNC
            For Each DrwNCINC As DataRow In Me.DtDatosNotasCredito.Rows
                If DrwNCINC("Seleccion") Then
                    objDetNotaCredito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objDetNotaCredito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objDetNotaCredito.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                    objDetNotaCredito.objNotaCreditoID = DrwNCINC("SccNotaCreditoID")
                    objDetNotaCredito.Insert(T)
                End If
            Next
            '------------------------------------------------------------------------------
            T.CommitTran()
            Me.BoolResult = True
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            BloquearColumnasModoConsulta()
            clsProyecto.CargarTemaDefinido(Me)
            Me.cmdAceptar.Enabled = False
            Me.cmdProcesar.Enabled = True
            Boolrst = True
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return Boolrst
    End Function

    '----------------------------------------------------------------------------------------------------------------------
    ' Autor          : Gelmin Martínez
    ' Fecha Creacion : 08 de Abril de 2010, 08:57 AM.
    ' Descripcion    : Hace las mismas operaciones que "GuardarReciboCaja", pero de forma temporal 
    '                  para el procesamiento de "Reestructuración de Cuenta"
    '----------------------------------------------------------------------------------------------------------------------
    Private Function GuardarReciboCaja_Temp() As Boolean
        Dim Boolrst As Boolean
        Dim objReciboCajaLocal As txRC_Recibo_Step2
        Dim objReciboDetFactura As txRC_ReciboDetFactura_Step2
        Dim objDetNotaDebito As txRC_ReciboDetND_Step2
        Dim objDetNotaC As txRC_ReciboDetNC_Step2
        Dim iConceptoFactReestructuracion As Integer = Integer.Parse(ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTOFACTURA", "05"))

        Dim FacturaMotoID As Integer = 0
        Dim FacturaMotoNumero As String = String.Empty

        Dim T As New TransactionManager
        Try
            Try
                Boolrst = False
                CalcularTotales()

                T.BeginTran()

                'Eliminar datos que se encuentren en las tablas para los datos temporales
                txRC_Recibo_Step2.DeleteByFilter("1=1")
                txRC_ReciboDetFactura_Step2.DeleteByFilter("1=1")
                txRC_ReciboDetND_Step2.DeleteByFilter("1=1")
                txRC_ReciboDetNC_Step2.DeleteByFilter("1=1")
                objReciboCajaLocal = New txRC_Recibo_Step2
          
                '--------------------------- Creamos el encabezado del recibo colector--------------------------
                objReciboCajaLocal = New txRC_Recibo_Step2
                With objReciboCajaLocal
                    'Me.objReciboCaja.Numero = Trim(Me.txtNumRecibo.Text) EN ESTE CASO SERA NULO
                    .Fecha = Me.dtpFecha.Value
                    .TotalFacturas = Me.DecTotalFact
                    .TotalND = Me.DecTotalND
                    .TotalRecibo = Me.DecTotalRecibo
                    .TotalEfectivo = Me.DecTotalEfect
                    .TotalNC = Me.DecTotalNC
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "REGISTRADO")
                    .objSccCuentaID = Me.IDCuenta
                    .objTiendaID = Me.IDTienda
                    .EsPagoPrima = False 'Me.chkPrima.Checked
                    .objMonedaID = Me.cmbMoneda.SelectedValue
                    '-------------------------------------------------------------------- ---------------------------
                    .Insert(T)
                End With

                Me.ReciboCajaID = objReciboCajaLocal.SccReciboCajaID

                '---------------------------------------------------------------------------------------------
                '-----------------Creamos los detalles por cada factura procesada-----------------------------
                objReciboDetFactura = New txRC_ReciboDetFactura_Step2
                For Each drwFactINC As DataRow In Me.DtDatosFactRecibo.Rows
                    If drwFactINC("Seleccion") Then
                        objReciboDetFactura.Monto = drwFactINC("CantAbonar")
                        objReciboDetFactura.objFacturaID = drwFactINC("SfaFacturaID")
                        objReciboDetFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objReciboDetFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objReciboDetFactura.objReciboCajaID = objReciboCajaLocal.SccReciboCajaID
                        If drwFactINC("Abonar") Then
                            objReciboDetFactura.EsAbono = True
                        Else
                            objReciboDetFactura.EsAbono = False
                        End If
                        objReciboDetFactura.Insert(T)

                        'Para reestructuracion de cuenta se necesita la factura de la moto
                        If drwFactINC("Concepto").ToString.Equals("Motos") OrElse drwFactINC("objConceptoFactura") = iConceptoFactReestructuracion Then
                            FacturaMotoID = drwFactINC("SfaFacturaID")
                            FacturaMotoNumero = drwFactINC("Numero")
                        End If
                    End If
                Next
                '-------------------------------------------------------------------------------------------
                '---------------Creamos los detalles para las notas de debito-------------------------------

                objDetNotaDebito = New txRC_ReciboDetND_Step2
                For Each DrwNDINC As DataRow In Me.DtdatosNotasDebito.Rows
                    If DrwNDINC("Seleccion") Then
                        objDetNotaDebito.objNotatDebitoID = DrwNDINC("SccNotaDebitoID")
                        objDetNotaDebito.objReciboCajaID = objReciboCajaLocal.SccReciboCajaID
                        objDetNotaDebito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objDetNotaDebito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objDetNotaDebito.Insert(T)
                    End If
                Next
                '-------------------------------------------------------------------------------------------
                '-----------------Creamos los detalles para las notas de crÉdito----------------------------

                objDetNotaC = New txRC_ReciboDetNC_Step2
                For Each DrwNCINC As DataRow In Me.DtDatosNotasCredito.Rows
                    If DrwNCINC("Seleccion") Then
                        objDetNotaC.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objDetNotaC.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objDetNotaC.objReciboCajaID = objReciboCajaLocal.SccReciboCajaID
                        objDetNotaC.objNotaCreditoID = DrwNCINC("SccNotaCreditoID")
                        objDetNotaC.Insert(T)
                    End If
                Next

                '------------------------------------------------------------------------------
                T.CommitTran()

                'Recuperar la Factura de la moto porque se necesita mas adelante en la Factura de Reestructuracion de cuenta
                T.BeginTran()
                objReciboCajaLocal.FacturaMotoID = FacturaMotoID
                objReciboCajaLocal.FacturaMotoNumero = FacturaMotoNumero ' para crear el numero de factura reestructurada
                objReciboCajaLocal.Update()
                T.CommitTran()

                Me.BoolResult = True
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                BloquearColumnasModoConsulta()
                clsProyecto.CargarTemaDefinido(Me)
                Me.cmdAceptar.Enabled = False
                Me.cmdProcesar.Enabled = True
                Boolrst = True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objReciboCajaLocal = Nothing
            objReciboDetFactura = Nothing
            objDetNotaDebito = Nothing
        End Try

        Return Boolrst
    End Function

    Private Function ValidarDetalleFact() As Boolean
        Dim boolrst As Boolean
        Try
            boolrst = True
            If Not Me.DtDatosFactRecibo Is Nothing Then
                For Each drw As DataRow In Me.DtDatosFactRecibo.Rows
                    If drw("Seleccion") Then
                        If Not drw("Cancelar") And Not drw("Abonar") Then
                            boolrst = False
                            Exit For
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return boolrst
    End Function

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

#Region "Bloqueo de Columnas"
    Private Sub BloquearColumnasModoConsulta()
        Try
            Me.cmdEliminar.Enabled = False
            Me.cmdAceptar.Enabled = False
            Me.dtpFecha.Enabled = False
            Me.cmdExpediente.Enabled = False
            Me.txtNumRecibo.Enabled = False
            Me.chkPrima.Enabled = False
            Me.numMontoCordobas.Enabled = False
            Me.NumMontoDolares.Enabled = False
            Me.cmbMoneda.Enabled = False

            For intCantCol As Integer = 0 To Me.grdFacturas.Columns.Count - 1
                Me.grdFacturas.Columns(intCantCol).Tag = "BLOQUEADO"
            Next

            For intCantCol As Integer = 0 To Me.grdNotaDebito.Columns.Count - 1
                Me.grdNotaDebito.Columns(intCantCol).Tag = "BLOQUEADO"
            Next

            For intCantCol As Integer = 0 To Me.grdNotasCredito.Columns.Count - 1
                Me.grdNotasCredito.Columns(intCantCol).Tag = "BLOQUEADO"
            Next
            Me.cmbMoneda.Enabled = False
            Me.numMontoCordobas.Enabled = False
            Me.NumMontoDolares.Enabled = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Procesamiento de Recibos"
    '------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 14 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de realizar el procesamiento de los datos una vez que se haya guardado.
    '------------------------------------------------------------------------------------------------------------
    Private Sub PROCESAR_RECIBO(ByVal IntIDReciboCaja As Integer, ByVal IntOpcion As Integer)
        Dim parametro(3) As SqlClient.SqlParameter
        Dim T As New TransactionManager
        Dim objNotCredito As SccNotaCredito

        Try
            objNotCredito = New SccNotaCredito
            T.BeginTran()

            parametro(0) = New SqlClient.SqlParameter("@IntReciboCajaID", SqlDbType.Int, 4)
            parametro(0).Value = IntIDReciboCaja
          
            parametro(1) = New SqlClient.SqlParameter("@EsPrima", SqlDbType.Int, 4)
            parametro(2) = New SqlClient.SqlParameter("@MontoPrima", SqlDbType.Decimal)

          
            If Me.chkPrima.Checked Then
                parametro(1).Value = 1
                parametro(2).Value = Me.txtTotalPagar.Value
            Else
                parametro(1).Value = 0
            End If

            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_SfaDimininuirCuentaPorCobrar", parametro)

            Me.objReciboCaja.Retrieve(IntIDReciboCaja, T)
            Me.objReciboCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "PAGADO")
            Me.objReciboCaja.Update(T)

            For Each DRWNotCredt As DataRow In Me.DtDatosNotasCredito.Rows
                If DRWNotCredt("Seleccion") Then
                    objNotCredito.Retrieve(DRWNotCredt("SccNotaCreditoID"), T)
                    objNotCredito.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objNotCredito.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objNotCredito.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoNC", "PAGADA")
                    objNotCredito.Update(T)
                End If
            Next
            T.CommitTran()
            Me.cmdAceptar.Enabled = False
            Me.cmdProcesar.Enabled = False

            MsgBox("El Recibo ha sido Procesado Exitosamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)         
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing
            T = Nothing
            objNotCredito = Nothing
        End Try
    End Sub

#End Region

#Region "Calculo de Montos Abonado en un Pago"
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
            Me.DecTotalAbonado = 0.0
            'If Not DtdatosNotasDebito Is Nothing Then
            If Not DtDatosNotasCredito Is Nothing Then
                If Me.DtDatosNotasCredito.DefaultView.Count > 0 Then
                    obj = (Me.DtDatosNotasCredito.Compute("Sum(Monto)", "Seleccion = 'true'"))
                    If Not IsDBNull(obj) Then
                        DecMontoNotcred = obj
                    End If
                End If
            End If

            DecMontoAbonado = Me.NumMontoDolares.Value

            'En caso de ser reestructuracion de cuenta, entonces solo sumar la Nota de crédito
            If Not Me.blnReestructurarCuenta Then
                Me.DecTotalAbonado = DecMontoAbonado + DecMontoNotcred
            Else
                Me.DecTotalAbonado = DecMontoNotcred
            End If

            Me.lblMontAbon.Text = Decimal.Round(Me.DecTotalAbonado, 2).ToString
            Me.lblMontRest.Text = Decimal.Round((Me.DecTotalRecibo - Me.DecTotalAbonado), 2).ToString
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Select Case Me.TypGui
            Case 0
                'En caso de Reestructuración de cuenta, se guarda el recibo temporalmente mientras concluye todo el proceso.
                If Me.blnReestructurarCuenta Then
                    Me.GuardarReciboCaja_Temp()
                Else
                    Me.GuardarReciboCaja()
                End If

            Case 1
                Me.ModificarRecibo()
        End Select        
    End Sub

#Region "Pago Recibo de Prima"
    Private Sub InhabilitarDatos()
        Try
            If Not Me.DtDatosFactRecibo Is Nothing Then
                For Each Rw As DataRow In Me.DtDatosFactRecibo.Rows
                    Rw("Seleccion") = False
                    Rw("CantAbonar") = 0
                    Rw("Abonar") = False
                    Rw("Cancelar") = False
                Next
            End If

            If Not Me.DtDatosNotasCredito Is Nothing Then
                For Each Rw As DataRow In Me.DtDatosNotasCredito.Rows
                    Rw("Seleccion") = False
                Next
            End If

            If Not Me.DtdatosNotasDebito Is Nothing Then
                For Each Rw As DataRow In Me.DtdatosNotasDebito.Rows
                    Rw("Seleccion") = False
                Next
            End If
            Me.CalcularTotales()
            Me.DecTotalRecibo = Me.MontoPrima
            Me.txtTotalPagar.Value = Decimal.Round(Me.DecTotalRecibo, 2)

            Me.grdFacturas.Splits(0).Locked = True
            Me.grdNotaDebito.Splits(0).Locked = True
            Me.grdNotasCredito.Splits(0).Locked = True

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

   
    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        If Not Me.blnReestructurarCuenta Then
            Me.PROCESAR_RECIBO(Me.ReciboCajaID, 0)
        Else
            MsgBox("El recibo será PROCESADO al concluir la REESTRUCTURACION DE LA CUENTA, Continue...", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        ' Me.ActualizarSaldoNotaDebito()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If Me.BoolResult Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub txtNumRecibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumRecibo.KeyPress
        'If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
        'e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        'End If
    End Sub

    Private Sub txtNumRecibo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumRecibo.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub CargarDatosEdicion()
        Dim objSccRecibo As New SccReciboCaja
        Dim objTasaCambio As New StbTasaCambioOficial
        Dim dtDatos As New DataTable
        Try
            Try
                objSccRecibo.Retrieve(Me.ReciboCajaID)
                objTasaCambio.RetrieveByFilter("Anio=" & objSccRecibo.Fecha.Year.ToString & " and Mes =" & objSccRecibo.Fecha.Month.ToString)
                Me.numTasaCambio.Value = objTasaCambio.Monto
                Me.txtNumRecibo.Text = objSccRecibo.Numero
                Me.dtpFecha.Value = objSccRecibo.Fecha
                Me.txtEstado.Text = StbValorCatalogo.RetrieveDT("StbValorCatalogoID=" & objSccRecibo.objEstadoID.ToString, , "Descripcion").DefaultView.Item(0)("Descripcion")
                Me.chkPrima.Checked = objSccRecibo.EsPagoPrima
                Me.cmbMoneda.SelectedValue = objSccRecibo.objMonedaID.Value
                 Me.IDCuenta = objSccRecibo.objSccCuentaID
                Me.IDTienda = objSccRecibo.objTiendaID
                Me.CargarFacturas()
                Me.CargarNotasCredito()
                Me.CargarNotasDebito()
                 If objSccRecibo.EsPagoPrima Then
                    Me.MontoPrima = objSccRecibo.TotalRecibo
                End If

                Me.DecTotalFact = objSccRecibo.TotalFacturas
                Me.DecTotalRecibo = objSccRecibo.TotalRecibo
                dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("CodigoTienda,SccCuentaID,Cliente", "vwSccCuentasSeleccion", "SccCuentaID='" & Me.IDCuenta.ToString & "' AND StbTiendaID =" & Me.IDTienda))
                Me.txtCodTienda.Text = dtDatos.DefaultView.Item(0)("CodigoTienda")
                Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("SccCuentaID")
                Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Cliente")
                Me.DetallesAgregados()
                Me.NumMontoDolares.Value = objSccRecibo.TotalEfectivo

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objSccRecibo = Nothing
            objTasaCambio = Nothing
        End Try
    End Sub


#Region " Detalles de Edicion"

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
            dtTablaProv = SccReciboDetFactura.RetrieveDT("objReciboCajaID = " & Me.ReciboCajaID, , "objFacturaID,EsAbono,objReciboCajaID,Monto")
            If dtTablaProv.DefaultView.Count > 0 Then
                For Each drwDetAct As DataRow In Me.DtDatosFactRecibo.Rows
                    dtTablaProv.DefaultView.RowFilter = "objFacturaID=" & drwDetAct("SfaFacturaID")
                    If dtTablaProv.DefaultView.Count <> 0 Then
                        If dtTablaProv.DefaultView.Item(0)("EsAbono") Then
                            drwDetAct("Abonar") = True
                        Else
                            drwDetAct("Cancelar") = True
                        End If
                        drwDetAct("CantAbonar") = dtTablaProv.DefaultView.Item(0)("Monto")
                        drwDetAct("Seleccion") = True
                    End If
                Next
                '-----------------------------------------------------------------------------------------------------
            End If

            '----------------------------------Veficacion de las notas de debito--------------------------------
            dtTablaProv.Reset()
            dtTablaProv = SccReciboDetND.RetrieveDT("objReciboCajaID =" & Me.ReciboCajaID, , "objNotatDebitoID")
            If dtTablaProv.DefaultView.Count > 0 Then
                For Each drwDtND As DataRow In Me.DtdatosNotasDebito.Rows
                    dtTablaProv.DefaultView.RowFilter = "objNotatDebitoID = " & drwDtND("SccNotaDebitoID")
                    If dtTablaProv.DefaultView.Count > 0 Then
                        drwDtND("Seleccion") = True
                    End If
                Next
            End If
            '---------------------------------------------------------------------------------------------------------

            dtTablaProv.Reset()

            '---------------------------------Verificacion de las notas de credito-------------------------------------
            dtTablaProv = SccReciboDetNC.RetrieveDT("objReciboCajaID =" & Me.ReciboCajaID, , "objNotaCreditoID")
            If dtTablaProv.DefaultView.Count > 0 Then
                For Each drwDtND As DataRow In Me.DtDatosNotasCredito.Rows
                    dtTablaProv.DefaultView.RowFilter = "objNotaCreditoID =" & drwDtND("SccNotaCreditoID")
                    If dtTablaProv.DefaultView.Count > 0 Then
                        drwDtND("Seleccion") = True
                    End If
                Next
            End If
            '---------------------------------------------------------------------------------------------------------
            CalcularTotales()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtTablaProv = Nothing
        End Try
    End Sub

#End Region

#Region "Modificacion de Recibo"
    '--------------------------------------------------------------------------------------------------------------------------
    ' Autor             : Pedro Pablo Tinoco
    ' Fecha Creacion    : 15 de diciembre de 2007
    ' Descripcion       : Esta funcion se encarga de realizar el proceso de modificacion de un recibo X.
    '--------------------------------------------------------------------------------------------------------------------------
    Private Function ModificarRecibo() As Boolean
        Dim boolRst As Boolean
        Dim dtDetalles As New DataTable
        Dim objReciboDetFactura As SccReciboDetFactura
        Dim objDetNotaDebito As SccReciboDetND
        Dim objDetNotaCredito As SccReciboDetNC
        Dim T As New TransactionManager
        Dim strfiltro As String
        Try

            T.BeginTran()

            If Not ValidarDetalleFact() Then
                Me.ErrorProv.SetError(Me.lblError, "Datos Imcompletos")
                Exit Function
            End If

            If Trim(Me.txtNumRecibo.Text) = "" Then
                Me.ErrorProv.SetError(Me.txtNumRecibo, "Campo Obligatorio.")
                Exit Function
            End If

            If (Decimal.Round(Me.DecTotalAbonado, 2) <> Decimal.Round(Me.DecTotalRecibo, 2)) Or (Me.txtTotalPagar.Value = 0) Then
                Me.ErrorProv.SetError(Me.lblError, "Montos no coinciden")
                Exit Function
            End If
            '---------------------------Actualizamos el recibo---------------------------------------
            Me.objReciboCaja = New SccReciboCaja
            Me.objReciboCaja.Retrieve(Me.ReciboCajaID)
            Me.objReciboCaja.Numero = Trim(Me.txtNumRecibo.Text)
            Me.objReciboCaja.Fecha = Me.dtpFecha.Value.Date
            Me.objReciboCaja.TotalFacturas = Me.DecTotalFact
            Me.objReciboCaja.TotalND = Me.DecTotalND
            Me.objReciboCaja.TotalRecibo = Me.DecTotalRecibo
            Me.objReciboCaja.TotalEfectivo = Me.DecTotalEfect
            Me.objReciboCaja.TotalNC = Me.DecTotalNC
            Me.objReciboCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.EsPagoPrima = Me.chkPrima.Checked
            Me.objReciboCaja.objMonedaID = Me.cmbMoneda.SelectedValue
            Me.objReciboCaja.Update(T)

            '----------------------------Actualizamos las detalles de facturas-----------------------------------
            objReciboDetFactura = New SccReciboDetFactura
            dtDetalles = SccReciboDetFactura.RetrieveDT("objReciboCajaID =" & Me.ReciboCajaID, , "objFacturaID")
            For Each drwDetFact As DataRow In Me.DtDatosFactRecibo.Rows
                If drwDetFact("Seleccion") Then
                    dtDetalles.DefaultView.RowFilter = "objFacturaID =" & drwDetFact("SfaFacturaID")

                    If dtDetalles.DefaultView.Count > 0 Then
                        '------------------Si la factura se encuentra entonces le aplicamos los cambios realizados------------------ 
                        'If drwDetFact.RowState = DataRowState.Modified Then
                        objReciboDetFactura.RetrieveByFilter("objFacturaID=" & drwDetFact("SfaFacturaID") & " AND objReciboCajaID = " & Me.ReciboCajaID, T)
                        objReciboDetFactura.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objReciboDetFactura.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objReciboDetFactura.Monto = drwDetFact("CantAbonar")
                        objReciboDetFactura.Update(T)
                        ' End If

                    Else
                        '-----------------Si la factura agregada es nueva entonces agregamos sus detalles------------------
                        objReciboDetFactura.Monto = drwDetFact("CantAbonar")
                        objReciboDetFactura.objFacturaID = drwDetFact("SfaFacturaID")
                        objReciboDetFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objReciboDetFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        If drwDetFact("Abonar") Then
                            objReciboDetFactura.EsAbono = True
                        Else
                            objReciboDetFactura.EsAbono = False
                        End If
                        objReciboDetFactura.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
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
            objDetNotaDebito = New SccReciboDetND
            dtDetalles.Reset()
            dtDetalles = SccReciboDetND.RetrieveDT("objReciboCajaID=" & Me.ReciboCajaID, , "objNotatDebitoID")
            For Each drwDetND As DataRow In Me.DtdatosNotasDebito.Rows
                If drwDetND("Seleccion") Then
                    dtDetalles.DefaultView.RowFilter = "objNotatDebitoID =" & drwDetND("SccNotaDebitoID")
                    If dtDetalles.DefaultView.Count > 0 Then
                        If drwDetND.RowState = DataRowState.Modified Then
                            strfiltro = "objReciboCajaID= " + Convert.ToString(Me.ReciboCajaID) + " AND " + "objNotatDebitoID =" + Convert.ToString(drwDetND("SccNotaDebitoID"))
                            objDetNotaDebito.RetrieveByFilter(strfiltro, T)
                            objDetNotaDebito.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objDetNotaDebito.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objDetNotaDebito.Update(T)
                        End If

                    Else
                        objDetNotaDebito.objReciboCajaID = Me.ReciboCajaID
                        objDetNotaDebito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objDetNotaDebito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objDetNotaDebito.objNotatDebitoID = drwDetND("SccNotaDebitoID")
                        objDetNotaDebito.Insert(T)
                    End If
                Else
                    dtDetalles.DefaultView.RowFilter = "objNotatDebitoID =" & drwDetND("SccNotaDebitoID")
                    If dtDetalles.DefaultView.Count > 0 Then
                        strfiltro = "objNotatDebitoID =" + Convert.ToString(drwDetND("SccNotaDebitoID")) + " AND objReciboCajaID =" + Convert.ToString(Me.ReciboCajaID)
                        SccReciboDetND.DeleteByFilter(strfiltro, T)

                    End If
                End If
            Next
            '---------------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------
            '---------------------------------Actualimamos las notas de creditos--------------------------------------------
            dtDetalles.Reset()
            objDetNotaCredito = New SccReciboDetNC
            dtDetalles = SccReciboDetNC.RetrieveDT("objReciboCajaID=" & Me.ReciboCajaID, , "objNotaCreditoID")
            For Each drwDetNC As DataRow In Me.DtDatosNotasCredito.Rows
                If drwDetNC("Seleccion") Then
                    dtDetalles.DefaultView.RowFilter = "objNotaCreditoID =" & drwDetNC("SccNotaCreditoID")
                    If dtDetalles.DefaultView.Count > 0 Then
                        If drwDetNC.RowState = DataRowState.Modified Then
                            strfiltro = "objReciboCajaID= " + Convert.ToString(Me.ReciboCajaID) + " AND " + "objNotaCreditoID =" + Convert.ToString(drwDetNC("SccNotaCreditoID"))
                            objDetNotaCredito.RetrieveByFilter(strfiltro, T)
                            objDetNotaCredito.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objDetNotaCredito.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objDetNotaCredito.Update(T)
                        End If
                    Else
                        objDetNotaCredito.objReciboCajaID = Me.ReciboCajaID
                        objDetNotaCredito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objDetNotaCredito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objDetNotaCredito.objNotaCreditoID = drwDetNC("SccNotaCreditoID")
                        objDetNotaCredito.Insert(T)
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
            '----------------------------------------------------------------------------------------------------------
            T.CommitTran()
            Me.BoolResult = True
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            BloquearColumnasModoConsulta()
            clsProyecto.CargarTemaDefinido(Me)
            Me.cmdProcesar.Enabled = True
            Me.cmdAceptar.Enabled = False
            boolRst = True
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            dtDetalles = Nothing
            T = Nothing
        End Try
        Return boolRst
    End Function

#End Region


    Private Sub cmbSucursal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.ErrorProv.Clear()
    End Sub

End Class