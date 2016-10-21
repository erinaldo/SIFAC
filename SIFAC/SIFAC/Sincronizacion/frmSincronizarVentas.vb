Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Catalogos.Datos

Public Class frmSincronizarVentas

#Region "Declaracion de Variables"
    Public DtEmpleados, DtRuta, DtVentas, DtEstados, dtAplFacturasProformaDetalle As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAprobar, boolConsultar, boolExportar, boolDesactivar As Boolean
    Dim intEstadoFactProfRegistrado As Integer
#End Region

#Region "Procedimientos"

    Private Sub InicializarVariables()
        Try
            intEstadoFactProfRegistrado = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOAPLICACION", "01"))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarEmpleados()
        Try
            DtEmpleados = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto", "vwSrhEmpleado", "Activo =1"))
            With cmbEmpleado
                .Properties.DataSource = DtEmpleados
                .Properties.DisplayMember = "NombreCompleto"
                .Properties.ValueMember = "SrhEmpleadoID"
                .Properties.PopulateColumns()
                .Properties.Columns("SrhEmpleadoID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarRuta()
        Dim objRuta As StbRutas
        Try
            objRuta = New StbRutas
            DtRuta = StbRutas.RetrieveDT("1=1", "", "StbRutaID,Nombre")
            With cmbRuta
                .Properties.DataSource = DtRuta
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "StbRutaID"
                .Properties.PopulateColumns()
                .Properties.Columns("StbRutaID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRuta = Nothing

        End Try
    End Sub


    Private Sub CargarEstados()
        DtEstados = ClsCatalogos.GetValoresCatalogo("ESTADOAPLICACION", "StbValorCatalogoID,Descripcion", "")
        DtEstados.DefaultView.Sort = "Descripcion"
        With cmbEstado
            .Properties.DataSource = DtEstados
            .Properties.DisplayMember = "Descripcion"
            .Properties.ValueMember = "StbValorCatalogoID"
            .Properties.PopulateColumns()
            .Properties.Columns("StbValorCatalogoID").Visible = False
            .Properties.AutoHeight = True
            .Properties.ShowHeader = False
        End With


    End Sub
#End Region

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla

    Public Sub CargarGrid(blnTodos As Boolean, intEstadoID As Integer, intEmpleadoID As Integer, intRutaID As Integer)
        Try

            If blnTodos Then
                DtVentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionVentas", "1=1"))
            End If

            If Not blnTodos And (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtVentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionVentas", "ObjRutaID =" & intRutaID & " AND SrhEmpleadoID=" & intEmpleadoID & " AND objEstadoID=" & intEstadoID))
            End If

            If Not blnTodos And (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And Not (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtVentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionVentas", " SrhEmpleadoID=" & intEmpleadoID & " AND objEstadoID=" & intEstadoID))
            End If

            If Not blnTodos And Not (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtVentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionVentas", "ObjRutaID =" & intRutaID & "  AND objEstadoID=" & intEstadoID))
            End If

            If Not DtVentas Is Nothing Then
                DtVentas.PrimaryKey = New DataColumn() {Me.DtVentas.Columns("SfaFacturaProformaID")}
                DtVentas.DefaultView.Sort = "fecha"
                Me.grdVentas.DataSource = DtVentas
                Me.grdVentas.Text = "Ventas (" & Me.DtVentas.Rows.Count & ")"
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub ExportarExcel()
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.grdVentas.ExportToXls(sfdRuta.FileName)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSincronizarVentas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAprobar = objseg.TienePermiso("AprobarVentas")
            boolConsultar = objseg.TienePermiso("ConsultarVentas")
            boolExportar = objseg.TienePermiso("ExportarVentas")
            boolDesactivar = objseg.TienePermiso("InactivarVenta")

            cmdAprobar.Enabled = boolAprobar
            cmdConsultar.Enabled = boolConsultar
            cmbExportar.Enabled = boolExportar
            cmdDesactivar.Enabled = boolDesactivar

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

    Private Sub frmSincronizarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            InicializarVariables()
            CargarRuta()
            CargarEmpleados()
            CargarEstados()
            Me.AplicarSeguridad()
            'CargarGrid(False, False, 0, 0)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.EditValue, cmbRuta.EditValue)
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        Dim FilaActual, intEstadoFila As Integer
        FilaActual = Me.grdVentasTable.FocusedRowHandle

        Dim objConsultas As clsConsultas
        objConsultas = New clsConsultas

        Dim blnSeleccionar As Boolean
        Dim chkSeleccionado As DevExpress.XtraEditors.CheckEdit

        intEstadoFila = CInt(DtVentas.Rows(FilaActual)("objEstadoID"))

        If intEstadoFila = intEstadoFactProfRegistrado Then
            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked
            DtVentas = objConsultas.actualizarColumnaDT(DtVentas, "SfaFacturaProformaID", CInt(DtVentas.Rows(FilaActual)("SfaFacturaProformaID")), "Seleccionar", blnSeleccionar)
        Else
            chkSeleccionado = CType(sender, DevExpress.XtraEditors.CheckEdit)
            chkSeleccionado.Checked = False
        End If

    End Sub

    Private Sub SincronizarVentas()
        Dim objSfaFactura As SfaFacturas
        Dim SfaFacturaID As Integer
        Dim dtFechaVencimiento As Date
        Dim SfaFacturaProformaID, objModalidadPagoID, objTerminoPagoID, intEstadoRegistrado As Integer

        Dim objSfaFacturaDetalle As SfaFacturasDetalle
        Dim objAplFacturasProforma As New AplFacturasProforma
        Dim objAplFacturasProformaDetalle As New AplFacturasProformaDetalle
        Dim dtDetalleFact, dtDetalleCuentasXCobrar As New DataTable
        Dim fila As DataRow

        Dim objSccCuenta As SccCuentaPorCobrar
        Dim objSccCuentaPorCobrarDetalle As SccCuentaPorCobrarDetalle

        Dim objStbValorCatalogo As StbValorCatalogo
        Dim intFactorTerminoPago, intFactorModalidadPago As Integer
        Dim blnSeleccionado As Boolean = False

        Dim t As New TransactionManager

        Try
            t.BeginTran()

            'carga de estructura detalle cuentas por cobrar y detalle de la factura
            dtDetalleCuentasXCobrar = SccCuentaPorCobrarDetalle.RetrieveDT("1=0", , , t)
            dtDetalleFact = SfaFacturasDetalle.RetrieveDT("1=0", , , t)

            objSfaFactura = New SfaFacturas
            objAplFacturasProforma = New AplFacturasProforma

            For Each drFilaVenta As DataRow In DtVentas.Rows

                blnSeleccionado = CBool(drFilaVenta("Seleccionar"))
                intEstadoRegistrado = CInt(drFilaVenta("objEstadoID"))

                If blnSeleccionado And intEstadoRegistrado = intEstadoFactProfRegistrado Then
                    'Asignacion de valores a Variables
                    SfaFacturaProformaID = CInt(drFilaVenta("SfaFacturaProformaID"))
                    dtFechaVencimiento = CDate(drFilaVenta("FechaVencimiento"))
                    objModalidadPagoID = CInt(drFilaVenta("objModalidadPagoID"))
                    objTerminoPagoID = CInt(drFilaVenta("objTerminoPagoID"))

                    '0 Actualizar estado factura proforma
                    With objAplFacturasProforma
                        .Retrieve(SfaFacturaProformaID, t)
                        .objEstadoID = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOAPLICACION", "02"))
                        .Update(t)
                    End With

                    '1. GUARDAR CABECERA DE FACTURA
                    With objSfaFactura
                        .Fecha = CDate(drFilaVenta("Fecha"))
                        .objSccClienteID = CInt(drFilaVenta("objSccClienteID"))
                        .objVendedorID = CInt(drFilaVenta("objVendedorID"))
                        .objEstadoID = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOFACT", "PROCESADA"))
                        .objTerminoPagoID = CInt(ClsCatalogos.GetValorCatalogoID("TERMINOPAGO", "02"))
                        .objDescuentoID = CInt(drFilaVenta("objDescuentoID"))
                        .Subtotal = CDec(drFilaVenta("Subtotal"))
                        .Descuento = CDec(drFilaVenta("Descuento"))
                        .Impuesto = 0
                        .TotalCordobas = CDec(drFilaVenta("Total"))
                        .TotalDolares = 0
                        .TasaCambio = 0
                        .Prima = CDec(drFilaVenta("Prima"))
                        .Saldo = CDec(drFilaVenta("Saldo"))
                        .objStbBodegaID = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
                        .UsuarioCreacion = clsProyecto.Conexion.Usuario
                        .FechaCreacion = clsProyecto.Conexion.FechaServidor
                        .Insert(t)
                        SfaFacturaID = .SfaFacturaID
                    End With

                    '2. GUARDAR DETALLE DE FACTURA

                    objSfaFacturaDetalle = New SfaFacturasDetalle
                    objAplFacturasProformaDetalle = New AplFacturasProformaDetalle

                    '2.1. Filtrar el detalle de Factura Proforma
                    dtAplFacturasProformaDetalle = objAplFacturasProformaDetalle.RetrieveDT(String.Format("objSfaFacturaProformaID={0}", SfaFacturaProformaID), , , t)

                    For Each row As DataRow In dtAplFacturasProformaDetalle.Rows
                        fila = dtDetalleFact.NewRow
                        fila("objSfaFacturaID") = SfaFacturaID
                        fila("objSivProductoID") = row("objSivProductoID")
                        fila("Cantidad") = row("Cantidad")
                        fila("Precio") = row("Precio")
                        fila("Subtotal") = row("Subtotal")
                        fila("Descuento") = row("Descuento")
                        fila("Impuesto") = 0 'row("Impuesto")
                        fila("Total") = row("Total")
                        fila("CostoDolares") = 0 'row("CostoPromedio")
                        fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        dtDetalleFact.Rows.Add(fila)
                    Next

                    dtDetalleFact.TableName = "SfaFacturasDetalle"
                    SfaFacturasDetalle.BatchUpdate(dtDetalleFact.DataSet, t)

                    '3. VERIFICAR SI EL CLIENTE TIENE CUENTA VIGENTE
                    objSccCuenta = New SccCuentaPorCobrar

                    Dim blnCuentaActiva As Boolean
                    blnCuentaActiva = objSccCuenta.RetrieveByFilter(String.Format("objClienteID={0} AND objEstadoID={1}", objSfaFactura.objSccClienteID, CInt(ClsCatalogos.GetValorCatalogoID("ESTADOEXPEDIENTE", "VIGENTE"))), t)

                    'Buscar Factor termino de pago y modalidad de pago
                    objStbValorCatalogo = New StbValorCatalogo

                    objStbValorCatalogo.Retrieve(objTerminoPagoID, t)
                    intFactorTerminoPago = CInt(objStbValorCatalogo.Codigo)

                    objStbValorCatalogo.Retrieve(objModalidadPagoID, t)
                    intFactorModalidadPago = CInt(objStbValorCatalogo.Codigo)

                    If blnCuentaActiva Then

                        'Actualizar Estado y saldo de la cuenta por cobrar
                        objSccCuenta.Saldo = objSccCuenta.Saldo + objSfaFactura.Saldo
                        objSccCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objSccCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objSccCuenta.Update(t)

                        '3.1 GUARDAR DETALLE CUENTA
                        GoTo lblGuardarDetalleCuenta


                    Else
                        '3.2 GUARDAR CUENTA
                        With objSccCuenta
                            .Saldo = objSfaFactura.Saldo
                            .UsuarioCreacion = clsProyecto.Conexion.Usuario
                            .SaldoInicial = 0.0
                            .FechaCreacion = clsProyecto.Conexion.FechaServidor
                            .objClienteID = objSfaFactura.objSccClienteID
                            .FechaCredito = objSfaFactura.Fecha
                            .objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "VIGENTE")
                            objSccCuenta.Insert(t)
                        End With

lblGuardarDetalleCuenta:

                        '3.2 GUARDAR DETALLE CUENTA
                        objSccCuentaPorCobrarDetalle = New SccCuentaPorCobrarDetalle

                        With objSccCuentaPorCobrarDetalle
                            .objSccCuentaID = objSccCuenta.SccCuentaID
                            .objSfaFacturaID = SfaFacturaID
                            .objTeminoPlazoID = objTerminoPagoID
                            .objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")
                            .Saldo = objSfaFactura.Saldo
                            .MontoTotal = objSfaFactura.Subtotal
                            .MontoPrima = objSfaFactura.Prima
                            .MontoAbonado = 0
                            .MontoCuota = (objSfaFactura.Saldo / intFactorTerminoPago)
                            .Descuento = objSfaFactura.Descuento
                            .FechaProximoPago = DateTime.Parse(objSfaFactura.Fecha).AddDays(intFactorModalidadPago)
                            .FechaVencimiento = dtFechaVencimiento
                            .UsuarioCreacion = clsProyecto.Conexion.Usuario
                            .FechaCreacion = clsProyecto.Conexion.FechaServidor
                            .Insert(t)
                        End With
                    End If

                    MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                End If
            Next

            t.CommitTran()
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AnularVentas()
        Dim intSfaFacturaProformaID, intEstadoRegistrado As Integer
        Dim objAplFacturasProforma As New AplFacturasProforma
        Dim blnSeleccionado As Boolean = False

        Dim t As New TransactionManager

        Try
            t.BeginTran()

            objAplFacturasProforma = New AplFacturasProforma

            For Each drFilaVenta As DataRow In DtVentas.Rows
                intSfaFacturaProformaID = CInt(drFilaVenta("SfaFacturaProformaID"))
                blnSeleccionado = CBool(drFilaVenta("Seleccionar"))
                intEstadoRegistrado = CInt(drFilaVenta("objEstadoID"))

                If blnSeleccionado And intEstadoRegistrado = intEstadoFactProfRegistrado Then
                    With objAplFacturasProforma
                        .Retrieve(intSfaFacturaProformaID, t)
                        .objEstadoID = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOAPLICACION", "03"))
                        .Update(t)
                    End With
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                End If
            Next

            t.CommitTran()
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        SincronizarVentas()
        CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.EditValue, cmbRuta.EditValue)
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        ExportarExcel()
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        AnularVentas()
        CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.EditValue, cmbRuta.EditValue)
    End Sub
End Class