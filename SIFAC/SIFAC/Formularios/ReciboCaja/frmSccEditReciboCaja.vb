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
    Dim DtDatosFactRecibo As DataTable
    Dim m_IDCuenta As String
    Dim m_TyGui As Integer
    Dim MontoPrima As Decimal
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

    Property TypGui() As Integer
        Get
            TypGui = m_TyGui
        End Get
        Set(ByVal value As Integer)
            m_TyGui = value
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

            Me.txtNumRecibo.MaxLength = SccReciboCaja.GetMaxLength("Numero")
            Select Case Me.TypGui
                Case 0
                    Me.Text = "Nuevo Recibo de Caja"
                    Me.txtEstado.Text = Me.CargarEstados(ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "REGISTRADO"))
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
            Me.grdFacturas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor

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

                For Each drw As DataRow In Me.DtDatosFactRecibo.Rows
                    If drw("MontoPrima") > 0 Then
                        Me.MontoPrima = drw("MontoPrima")
                        Exit For
                    End If
                Next

                If Not Me.MontoPrima = 0 Then
                    If objSccRecibo.RetrieveByFilter("EsPagoPrima=1 and objSccCuentaID='" & Me.IDCuenta & "'") Then
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
    ''' Procedimiento encargado de cargar las facturas correspondientes.
    ''' Autor : Pedro Tinoco Salgado.
    ''' Modificado por: Gelmin Martínez, 13 Abril 2010
    ''' Fecha : 3 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarFacturas()
        Dim Registrada As Integer
        Dim Cancelada As Integer
        Dim sConsulta As String
        Try
            Registrada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
            Cancelada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "02")

            Me.DtDatosFactRecibo = New DataTable
            If Me.TypGui = 2 Then
                sConsulta = clsConsultas.ObtenerConsultaGeneral("*,Saldo as SaldoFactura,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetFactura", "objSccCuentaID='" & Me.IDCuenta & "'")
                Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)
            Else
                sConsulta = clsConsultas.ObtenerConsultaGeneral("*,Saldo as SaldoFactura,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetFactura", "objSccCuentaID='" & Me.IDCuenta & "'")
                Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)
            End If
            Me.grdFacturas.SetDataBinding(Me.DtDatosFactRecibo, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#Region "EVENTOS DE CONTROLES"

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
            Else
                Me.DecTotalEfect = Me.NumMontoDolares.Value
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

    Private Sub chkPrima_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrima.CheckedChanged
        If chkPrima.Checked Then
            Me.InhabilitarDatos()
        Else
            Me.DecTotalRecibo = 0.0
            Me.txtTotalPagar.Value = 0.0
            Me.grdFacturas.Splits(0).Locked = False
        End If
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



            End If
            '-------------------------------------------------------------------------------------------------
            '------------------Calculamos el Total por todas las facturas incluidas-------
            Me.DecTotalFact = DecSumMontoFactura

          
            Me.DecTotalND = DecSumTotalND
            Me.DecTotalRecibo = Me.DecTotalFact + Me.DecTotalND

            If Me.chkPrima.Checked Then
                Me.DecTotalRecibo = Me.MontoPrima
            End If

            Me.txtTotalFact.Value = Decimal.Round(Me.DecTotalFact, 2)
            Me.txtTotalPagar.Value = Decimal.Round(Me.DecTotalRecibo, 2)
            'Me.numTotalPagarCor.Value = Me.DecTotalRecibo * Me.numTasaCambio.Value

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



#End Region

#Region "Guardado de Datos"
    '----------------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 14 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de realizar el proceso completo de guardado de los datos.
    '----------------------------------------------------------------------------------------------------------------------
    Private Function GuardarReciboCaja() As Boolean
        Dim Boolrst As Boolean
        Dim objReciboDetFactura As SccReciboDetFactura
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

            If Trim(Me.txtNumRecibo.Text) = "" Then
                Me.ErrorProv.SetError(Me.txtNumRecibo, "Campo Obligatorio.")
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
            Me.objReciboCaja.TotalRecibo = Me.DecTotalRecibo
            Me.objReciboCaja.UsuarioCreacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaCreacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "REGISTRADO")
            Me.objReciboCaja.objSccCuentaID = Me.IDCuenta
            Me.objReciboCaja.EsPagoPrima = Me.chkPrima.Checked
            '-------------------------------------------------------------------- ---------------------------
            Me.objReciboCaja.Insert(T)
            Me.ReciboCajaID = Me.objReciboCaja.SccReciboCajaID

            '---------------------------------------------------------------------------------------------
            '-----------------Creamos los detalles por cada factura procesada-----------------------------
            objReciboDetFactura = New SccReciboDetFactura
            For Each drwFactINC As DataRow In Me.DtDatosFactRecibo.Rows
                If drwFactINC("Seleccion") Then
                    objReciboDetFactura.Monto = drwFactINC("CantAbonar")
                    objReciboDetFactura.objSfaFacturaID = drwFactINC("SfaFacturaID")
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
            'Me.numMontoCordobas.Enabled = False
            Me.NumMontoDolares.Enabled = False
            Me.cmbMoneda.Enabled = False

            For intCantCol As Integer = 0 To Me.grdFacturas.Columns.Count - 1
                Me.grdFacturas.Columns(intCantCol).Tag = "BLOQUEADO"
            Next
            Me.cmbMoneda.Enabled = False
            'Me.numMontoCordobas.Enabled = False
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
        Try
            Me.DecTotalAbonado = 0.0

            DecMontoAbonado = Me.NumMontoDolares.Value

            'En caso de ser reestructuracion de cuenta, entonces solo sumar la Nota de crédito
            Me.DecTotalAbonado = DecMontoAbonado + DecMontoNotcred


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
                Me.GuardarReciboCaja()

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

            
            Me.CalcularTotales()
            Me.DecTotalRecibo = Me.MontoPrima
            Me.txtTotalPagar.Value = Decimal.Round(Me.DecTotalRecibo, 2)

            Me.grdFacturas.Splits(0).Locked = True

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

   
    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        Me.PROCESAR_RECIBO(Me.ReciboCajaID, 0)
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
        'Dim objTasaCambio As New StbTasaCambioOficial
        Dim dtDatos As New DataTable
        Try
            Try
                objSccRecibo.Retrieve(Me.ReciboCajaID)
                'objTasaCambio.RetrieveByFilter("Anio=" & objSccRecibo.Fecha.Year.ToString & " and Mes =" & objSccRecibo.Fecha.Month.ToString)
                'Me.numTasaCambio.Value = objTasaCambio.Monto
                Me.txtNumRecibo.Text = objSccRecibo.Numero
                Me.dtpFecha.Value = objSccRecibo.Fecha
                Me.txtEstado.Text = StbValorCatalogo.RetrieveDT("StbValorCatalogoID=" & objSccRecibo.objEstadoID.ToString, , "Descripcion").DefaultView.Item(0)("Descripcion")
                Me.chkPrima.Checked = objSccRecibo.EsPagoPrima
                Me.IDCuenta = objSccRecibo.objSccCuentaID
                Me.CargarFacturas()
                If objSccRecibo.EsPagoPrima Then
                    Me.MontoPrima = objSccRecibo.TotalRecibo
                End If

                Me.DecTotalRecibo = objSccRecibo.TotalRecibo
                dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccCuentaID,Cliente", "vwSccCuentasSeleccion", "SccCuentaID='" & Me.IDCuenta.ToString & "'"))
                Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("SccCuentaID")
                Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Cliente")
                Me.DetallesAgregados()
                Me.NumMontoDolares.Value = objSccRecibo.TotalRecibo

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objSccRecibo = Nothing
            'objTasaCambio = Nothing
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
            dtTablaProv = SccReciboDetFactura.RetrieveDT("objReciboCajaID = " & Me.ReciboCajaID, , "objSfaFacturaID,EsAbono,objReciboCajaID,Monto")
            If dtTablaProv.DefaultView.Count > 0 Then
                For Each drwDetAct As DataRow In Me.DtDatosFactRecibo.Rows
                    dtTablaProv.DefaultView.RowFilter = "objSfaFacturaID=" & drwDetAct("SfaFacturaID")
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
            Me.objReciboCaja.TotalRecibo = Me.DecTotalRecibo
            Me.objReciboCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.EsPagoPrima = Me.chkPrima.Checked
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
                        objReciboDetFactura.objSfaFacturaID = drwDetFact("SfaFacturaID")
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