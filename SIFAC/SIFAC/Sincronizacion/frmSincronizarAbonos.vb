Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Catalogos.Datos

Public Class frmSincronizarAbonos

#Region "Declaracion de Variables"
    Public DtEmpleados, DtRuta, DtAbonos, DtEstados, dtAplCobros As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAprobar, boolConsultar, boolExportar, boolDesactivar As Boolean
    Dim intEstadoAbonoRegistrado As Integer
    Dim objReciboCaja As SccReciboCaja
    Dim objReciboDetFactura As SccReciboDetFactura
#End Region

#Region "Procedimientos"

    Private Sub InicializarVariables()
        Try
            intEstadoAbonoRegistrado = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOAPLICACION", "01"))
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
                DtAbonos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionAbonos", "1=1"))
            End If

            If Not blnTodos And (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtAbonos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionAbonos", "ObjRutaID =" & intRutaID & " AND SrhEmpleadoID=" & intEmpleadoID & " AND objEstadoID=" & intEstadoID))
            End If

            If Not blnTodos And (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And Not (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtAbonos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionAbonos", " SrhEmpleadoID=" & intEmpleadoID & " AND objEstadoID=" & intEstadoID))
            End If

            If Not blnTodos And Not (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtAbonos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionAbonos", "ObjRutaID =" & intRutaID & "  AND objEstadoID=" & intEstadoID))
            End If

            If Not DtAbonos Is Nothing Then
                DtAbonos.PrimaryKey = New DataColumn() {Me.DtAbonos.Columns("AplCobroID")}
                DtAbonos.DefaultView.Sort = "FechaAbono"
                Me.grdVentas.DataSource = DtAbonos
                Me.grdVentas.Text = "Abonos (" & Me.DtAbonos.Rows.Count & ")"
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
            objseg.ServicioUsuario = "frmSincronizarAbonos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAprobar = objseg.TienePermiso("AprobarAbonos")
            boolConsultar = objseg.TienePermiso("ConsultarAbonos")
            boolExportar = objseg.TienePermiso("ExportarAbonos")
            boolDesactivar = objseg.TienePermiso("InactivarAbonos")

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

        intEstadoFila = CInt(DtAbonos.Rows(FilaActual)("objEstadoID"))

        If intEstadoFila = intEstadoAbonoRegistrado Then
            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked
            DtAbonos = objConsultas.actualizarColumnaDT(DtAbonos, "AplCobroID", CInt(DtAbonos.Rows(FilaActual)("AplCobroID")), "Seleccionar", blnSeleccionar)
        Else
            chkSeleccionado = CType(sender, DevExpress.XtraEditors.CheckEdit)
            chkSeleccionado.Checked = False
        End If

    End Sub

    Private Sub SincronizarAbonos()
        Dim DtDatosFactRecibo As DataTable
        DtDatosFactRecibo = New DataTable
        Dim sConsulta As String
        Dim intEstadoRegistrado As Integer
        Dim blnSeleccionado As Boolean
        Dim intAplCobroID, intobjSccCuentaID, intReciboCajaID As Integer
        Dim dtFechaAbono As Date
        Dim decTotalRecibo As Decimal
        Dim objAplCobros As New AplCobros

        Dim t As New TransactionManager

        Try
            t.BeginTran()

            For Each drFilaAbonos As DataRow In DtAbonos.Rows
                blnSeleccionado = CBool(drFilaAbonos("Seleccionar"))
                intEstadoRegistrado = CInt(drFilaAbonos("objEstadoID"))

                If blnSeleccionado And intEstadoRegistrado = intEstadoAbonoRegistrado Then
                    'Asignacion de valores a Variables
                    intAplCobroID = CInt(drFilaAbonos("AplCobroID"))
                    intobjSccCuentaID = CInt(drFilaAbonos("objSccCuentaID"))
                    dtFechaAbono = CDate(drFilaAbonos("FechaAbono"))
                    decTotalRecibo = CDec(drFilaAbonos("MontoAbonado"))

                    '0 Actualizar estado factura proforma
                    With objAplCobros
                        .Retrieve(intAplCobroID, t)
                        .objEstadoID = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOAPLICACION", "02"))
                        .Update(t)
                    End With

                    '--------------------------- Creamos el encabezado del recibo colector--------------------------
                    Me.objReciboCaja = New SccReciboCaja
                    Me.objReciboCaja.Numero = 0
                    Me.objReciboCaja.Fecha = dtFechaAbono
                    Me.objReciboCaja.TotalRecibo = decTotalRecibo
                    Me.objReciboCaja.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    Me.objReciboCaja.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    Me.objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "PAGADO")
                    Me.objReciboCaja.objSccCuentaID = intobjSccCuentaID
                    Me.objReciboCaja.EsPagoPrima = False
                    '-------------------------------------------------------------------- ---------------------------
                    Me.objReciboCaja.Insert(t)
                    intReciboCajaID = Me.objReciboCaja.SccReciboCajaID

                    'Cargar Facturas por cuentas
                    sConsulta = clsConsultas.ObtenerConsultaGeneral("*,Saldo as SaldoFactura,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetFactura", "objSccCuentaID='" & intobjSccCuentaID & "'")
                    DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)

                    '---------------------------------------------------------------------------------------------
                    '-----------------Creamos los detalles por cada factura procesada-----------------------------
                    objReciboDetFactura = New SccReciboDetFactura
                    For Each drwFactINC As DataRow In DtDatosFactRecibo.Rows
                        objReciboDetFactura.Monto = (Me.objReciboCaja.TotalRecibo / DtDatosFactRecibo.Rows.Count)
                        objReciboDetFactura.objSfaFacturaID = drwFactINC("SfaFacturaID")
                        objReciboDetFactura.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objReciboDetFactura.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objReciboDetFactura.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                        objReciboDetFactura.EsAbono = True
                        objReciboDetFactura.Insert(t)
                    Next

                    'Procesamos el Abono
                    Dim parametro(3) As SqlClient.SqlParameter
                    parametro(0) = New SqlClient.SqlParameter("@IntReciboCajaID", SqlDbType.Int, 4)
                    parametro(0).Value = Me.objReciboCaja.SccReciboCajaID

                    parametro(1) = New SqlClient.SqlParameter("@EsPrima", SqlDbType.Int, 4)
                    parametro(2) = New SqlClient.SqlParameter("@MontoPrima", SqlDbType.Decimal)
                    parametro(1).Value = 0
                    parametro(2).Value = 0

                    SqlHelper.ExecuteNonQuery(t.Transaction, CommandType.StoredProcedure, "Sp_SfaDimininuirCuentaPorCobrar", parametro)

                End If

            Next


            t.CommitTran()
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AnularAbonos()
        Dim intAplCobroID, intEstadoRegistrado As Integer
        Dim objAplCobros As New AplCobros
        Dim blnSeleccionado As Boolean = False

        Dim t As New TransactionManager

        Try
            t.BeginTran()

            objAplCobros = New AplCobros

            For Each drFilaVenta As DataRow In DtAbonos.Rows
                intAplCobroID = CBool(drFilaVenta("AplCobroID"))
                blnSeleccionado = CBool(drFilaVenta("Seleccionar"))
                intEstadoRegistrado = CInt(drFilaVenta("objEstadoID"))

                If blnSeleccionado And intEstadoRegistrado = intEstadoAbonoRegistrado Then
                    With objAplCobros
                        .Retrieve(intAplCobroID, t)
                        .objEstadoID = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOAPLICACION", "03"))
                        .Update(t)
                    End With

                End If
            Next

            t.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        SincronizarAbonos()
        CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.EditValue, cmbRuta.EditValue)
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        ExportarExcel()
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        AnularAbonos()
        CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.EditValue, cmbRuta.EditValue)
    End Sub
End Class