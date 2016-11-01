Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports proyecto.Catalogos.Datos


Public Class frmSccCuentas

#Region "Variables del formulario"
    Dim dtCuentas, dtDetalleCuenta As DataTable
    Dim dsCuentas As DataSet
    Dim boolAgregar, boolEditar, boolEliminar, boolImprimir As Boolean

#End Region


#Region "Procedimientos del formulario"

    Public Sub CargarCuentas(Optional ByVal Filtro As String = "ESTADO <> 'CANCELADO'")
        Try

            'dtPedidos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivPedidoID, Numero, Estado, TotalCosto, Fecha, Proveedor ", "vwSivPedidosMaster", strFiltro & " ORDER BY Fecha DESC"), Me.SqlParametros)
            'dtDetallePedidos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivPedidoDetalleID, objPedidoID, objCategoriaID, Categoria, Numero, NombreProducto, CantidadOrdenada, TotalCosto", "vwPedidosDetalle", strFiltro), Me.SqlParametros)

            'dsPedidos = New DataSet

            'dsPedidos.Merge(dtPedidos)
            'dsPedidos.Tables(0).TableName = "SivPedidos"

            'dsPedidos.Merge(dtDetallePedidos)
            'dsPedidos.Tables(1).TableName = "SivPedidoDetalle"

            'dsPedidos.Relations.Add("SivPedidos_SivPedidoDetalle", dsPedidos.Tables(0).Columns("SivPedidoID"), dsPedidos.Tables(1).Columns("objPedidoID"), False)

            'Me.grdPedidosMaster.DataSource = dsPedidos
            'Me.grdPedidosMaster.DataMember = "SivPedidos"

            'Me.grdPedidosDetalle.DataSource = dsPedidos
            'Me.grdPedidosDetalle.DataMember = "SivPedidos.SivPedidos_SivPedidoDetalle"

            'Me.grdPedidosMaster.Text = "Pedidos (" & Me.grdPedidosMasterTabla.RowCount & ")"

            dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccCuentaID,SccCuentaID AS Llave,objClienteID,Cliente,Saldo,Cedula,FechaCredito,objEstadoID,Estado, Numero", "vwSccCuenta", Filtro))
            dtDetalleCuenta = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objSccCuentaID AS Llave,Numero,SfaFacturaID,Saldo, objEstadoID,EstadoFact,CodigoEstado,Fecha,MontoAbonado,MontoTotal,Plazo,MontoCuota,Estado,objSccCuentaID,objSccCuentaID as SccCuentaID", "vwSccCuentaDetalle", "CodigoEstado<> '00' AND " & Filtro))

            dsCuentas = New DataSet

            dsCuentas.Merge(dtCuentas)
            dsCuentas.Tables(0).TableName = "SccCuenta"

            dsCuentas.Merge(dtDetalleCuenta)
            dsCuentas.Tables(1).TableName = "SccCuentaDetalle"

            dsCuentas.Relations.Add("Cuenta_CuentaDetalle", dsCuentas.Tables(0).Columns("Llave"), dsCuentas.Tables(1).Columns("Llave"), False)

            Me.grdExpedienteMaster.DataSource = dsCuentas
            Me.grdExpedienteMaster.DataMember = "SccCuenta"

            Me.grdExpedienteDetalle.DataSource = dsCuentas
            Me.grdExpedienteDetalle.DataMember = "SccCuenta.Cuenta_CuentaDetalle"

            'dsCuentas.Tables("SccCuenta").PrimaryKey = New DataColumn() {dsCuentas.Tables("SccCuenta").Columns("Llave")}
            'dsCuentas.Tables("SccCuenta").DefaultView.Sort = "Llave"

            Me.grdExpedienteMaster.Text = "Expedientes (" & Me.grdExpedienteMasterTabla.RowCount & ")"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub frmSccCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Call CargarCuentas()
            'Me.grdCuentas.Splits(0).DisplayColumns("objEstadoID").Visible = False

            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


    Private Sub CargarEdicionCuentas()
        Dim iIndiceRegistro As Integer
        Dim objfrmCuentaEdit As frmSccCuentasEditar
        Try
            objfrmCuentaEdit = New frmSccCuentasEditar
            objfrmCuentaEdit.TypeGUI = 0
            If objfrmCuentaEdit.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarCuentas()
                If (Me.dtCuentas.Rows.Count <> 0) Then
                    iIndiceRegistro = Me.dtCuentas.DefaultView.Find(objfrmCuentaEdit.CuentaID)
                    Me.dtCuentas.DefaultView.Find(iIndiceRegistro)

                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub CargarConsultaCuenta()
        If Me.grdExpedienteMasterTabla.RowCount = 0 Then
            Exit Sub
        End If
        Dim FilaActual As Integer
        Dim objfrmCuentaEdit As frmSccCuentasEditar
        Try
            FilaActual = Me.grdExpedienteMasterTabla.FocusedRowHandle
            objfrmCuentaEdit = New frmSccCuentasEditar
            objfrmCuentaEdit.CuentaID = Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID"))
            objfrmCuentaEdit.TypeGUI = 2
            objfrmCuentaEdit.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub CargarEdicionExpediente()
        Dim objfrmCuentaEdit As frmSccCuentasEditar
        Dim intEstadoReg, iIndiceRegistro As Integer
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdExpedienteMasterTabla.FocusedRowHandle
            intEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "REGISTRADO")
            If Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("objEstadoID")) <> intEstadoReg Then
                MsgBox("Solamente Expedientes en Estado REGISTRADO pueden ser Editados")
                Exit Sub
            End If
            objfrmCuentaEdit = New frmSccCuentasEditar
            objfrmCuentaEdit.CuentaID = Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID"))
            objfrmCuentaEdit.TypeGUI = 1
            If objfrmCuentaEdit.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarCuentas()

                If (Me.dtCuentas.Rows.Count <> 0) Then
                    iIndiceRegistro = Me.dtCuentas.DefaultView.Find(objfrmCuentaEdit.CuentaID)
                    Me.dtCuentas.DefaultView.Find(iIndiceRegistro)

                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Call Me.CargarEdicionCuentas()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Call Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Call CargarCuentas()
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Call CargarConsultaCuenta()
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de aplicar la seguridad en la pantalla
   
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmSccCuentas"
            If objSeg.TienePermiso("AgregarCuentaXCobrar") Then
                Me.cmdAgregar.Enabled = True
            Else
                Me.cmdAgregar.Enabled = False
            End If
            Me.cmdEditar.Enabled = objSeg.TienePermiso("EditarCuentaXCobrar")
            Me.cmdConsultar.Enabled = objSeg.TienePermiso("ConsultarCuentaXCobrar")
            Me.cmdBuscarExpedientes.Enabled = objSeg.TienePermiso("BuscarCuentaXCobrar")

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If Me.grdExpedienteMasterTabla.RowCount > 0 Then
            Me.CargarEdicionExpediente()
        End If
    End Sub

    Private Sub cmdBuscarExpedientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarExpedientes.Click
        Dim objBuscarCuentas As New frmSccBuscarCuentas
        Try
            If objBuscarCuentas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarCuentas(objBuscarCuentas.Filtro)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    'Private Sub cmdModificarLimite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarLimite.Click

    '    If Me.grdCuentas.RowCount = 0 Then
    '        Exit Sub
    '    End If

    '    Dim objfrmCuentaEdit As frmSccModificarLimite
    '    Dim intEstadoVIG As Integer
    '    Try
    '        intEstadoVIG = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "VIGENTE")
    '        If Me.grdCuentas.Columns("objEstadoID").Value <> intEstadoVIG Then
    '            MsgBox("Esta opción es funcional para expedientes en estado VIGENTE")
    '            Exit Sub
    '        End If
    '        objfrmCuentaEdit = New frmSccModificarLimite
    '        objfrmCuentaEdit.IDCuenta = Me.grdCuentas.Columns("SccCuentaID").Value
    '        objfrmCuentaEdit.IDTienda = Me.grdCuentas.Columns("objTiendaID").Value
    '        If objfrmCuentaEdit.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '            Me.CargarCuentas()
    '            Me.grdCuentas.Row = Me.dsCuentas.Tables("SccCuenta").DefaultView.Find(objfrmCuentaEdit.IDCuenta + objfrmCuentaEdit.IDTienda.ToString)
    '        End If
    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    End Try
    'End Sub

#Region "REESTRUCTURAR CUENTA CLIENTE"

    Private Function Recibo_Step2()
        Dim iErrores As Integer = 0
        Dim iTasaCambioConfirmadaID As Integer = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOTASACAMBIO", "CONFIRMADO")
        'Dim iNCEstadoAutorizada As Integer = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "AUTORIZADA")
        'Dim sSQL, sFiltro As String
        Dim iContador As Integer = 0
        Try
            ''Verificar Tasa de cambio
            'Select Case HayTasaCambio(iTasaCambioConfirmadaID)
            '    Case "NoExiste"
            '        MsgBox("No ha definido Tasa de Cambio para el Mes y Año Actual, Click OK para Definirla.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            '        If Not CargarTasaCambio(iTasaCambioConfirmadaID) Then
            '            iErrores += 1
            '        End If
            '    Case "NoConfirmado"
            '        iErrores += 1
            'End Select

            ''Verificar si existen notas de Crédito Autorizadas sin Aplicar
            'Dim NC As New SccNotaCredito
            'sFiltro = " objEstadoID = " + iNCEstadoAutorizada.ToString + " AND objSccCuentaID='" + Me.grdCuentas.Columns("SccCuentaID").Value.ToString + "' AND objTiendaId=" + Me.grdCuentas.Columns("objTiendaID").Value.ToString
            'sSQL = clsConsultas.ObtenerConsultaGeneral("COUNT(*) as Contador", "dbo.SccNotaCredito", sFiltro)
            'iContador = SqlHelper.ExecuteScalar(CommandType.Text, sSQL)

            'If iContador <> 0 Then
            '    MsgBox("Hay notas de crédito que aún no han sido aplicadas, Favor apliquela y vuelva a intentarlo.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            '    iErrores += 1
            'End If

            'If iErrores = 0 Then
            '    'Abrir ventana de Recibos
            '    Dim objRecibo As frmSccEditReciboCaja
            '    objRecibo = New frmSccEditReciboCaja
            '    objRecibo.TypGui = 0

            '    objRecibo.Cliente = Me.grdCuentas.Columns("Cliente").Value
            '    objRecibo.IDCuenta = Me.grdCuentas.Columns("SccCuentaID").Value

            '    Return objRecibo.ShowDialog(Me) = Windows.Forms.DialogResult.OK
            'Else
            '    Return False
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
            Return False
        End Try
    End Function

    Private Function LimiteCredito_Step3() As Boolean
        'Dim objfrmCuentaEdit As frmSccModificarLimite
        'Try
        '    objfrmCuentaEdit = New frmSccModificarLimite
        '    objfrmCuentaEdit.IDCuenta = Me.grdCuentas.Columns("SccCuentaID").Value
        '    objfrmCuentaEdit.IDTienda = Me.grdCuentas.Columns("objTiendaID").Value
        '    objfrmCuentaEdit.blnReestructuracionCuenta = True
        '    Return objfrmCuentaEdit.ShowDialog(Me) = Windows.Forms.DialogResult.OK            
        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        '    Return False
        'End Try
    End Function

    ''' <summary>
    ''' Crea la factura nueva para concluir el proceso de reestructuración 
    ''' </summary>
    ''' <remarks></remarks>
    'Private Function CrearFactura_Step4() As Boolean
    '    Dim objFacturaEdit As New frmSfaFaturaEditar
    '    Try
    '        objFacturaEdit.TypGui = 0
    '        objFacturaEdit.blnReestructurarCuenta = True
    '        objFacturaEdit.IDCuenta = Me.grdCuentas.Columns("SccCuentaID").Value
    '        objFacturaEdit.IDTienda = Me.grdCuentas.Columns("objTiendaID").Value
    '        objFacturaEdit.Cliente = Me.grdCuentas.Columns("Cliente").Value

    '        Return objFacturaEdit.ShowDialog(Me) = Windows.Forms.DialogResult.OK

    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    End Try        
    'End Function

    Private Function HayTasaCambio(ByVal idConfirmada As Integer) As String
        Dim objTasaCambio As New StbTasaCambioOficial
        Dim sCaso As String = String.Empty
        Try
            Try
                If objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & _
                                                  " AND Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString) Then
                    If objTasaCambio.objEstadoID <> idConfirmada Then
                        If MsgBox("La tasa de cambio existente no ha sido confirmada aún, para continuar debe confirmarla. ¿Hacerlo Ahora?.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            objTasaCambio.objEstadoID = idConfirmada
                            objTasaCambio.Update()
                            sCaso = String.Empty
                        Else
                            sCaso = "NoConfirmado"
                        End If
                    Else
                        sCaso = String.Empty
                    End If
                Else
                    sCaso = "NoExiste"
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objTasaCambio = Nothing
        End Try
        Return sCaso
    End Function


#End Region

End Class