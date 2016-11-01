Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Catalogos.Datos

Public Class frmSincronizarDevoluciones

#Region "Declaracion de Variables"
    Public DtEmpleados, DtRuta, DtDevoluciones, DtEstados As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAprobar, boolConsultar, boolExportar, boolDesactivar As Boolean
    Dim intEstadoDevolucionRegistrado As Integer
    Dim objReciboCaja As SccReciboCaja
    Dim objReciboDetFactura As SccReciboDetFactura

#End Region

#Region "Procedimientos"

    Private Sub InicializarVariables()
        Try
            intEstadoDevolucionRegistrado = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOAPLICACION", "01"))
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
                DtDevoluciones = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionDevoluciones", "1=1"))
            End If

            If Not blnTodos And (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtDevoluciones = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionDevoluciones", "ObjRutaID =" & intRutaID & " AND SrhEmpleadoID=" & intEmpleadoID & " AND objEstadoID=" & intEstadoID))
            End If

            If Not blnTodos And (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And Not (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtDevoluciones = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionDevoluciones", " SrhEmpleadoID=" & intEmpleadoID & " AND objEstadoID=" & intEstadoID))
            End If

            If Not blnTodos And Not (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtDevoluciones = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwAplicacionDevoluciones", "ObjRutaID =" & intRutaID & "  AND objEstadoID=" & intEstadoID))
            End If

            If Not DtDevoluciones Is Nothing Then
                DtDevoluciones.PrimaryKey = New DataColumn() {Me.DtDevoluciones.Columns("AplDevolucionID")}
                DtDevoluciones.DefaultView.Sort = "Fecha"
                Me.grdVentas.DataSource = DtDevoluciones
                Me.grdVentas.Text = "Devoluciones (" & Me.DtDevoluciones.Rows.Count & ")"
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
            objseg.ServicioUsuario = "frmSincronizarDevoluciones"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAprobar = objseg.TienePermiso("AprobarDevoluciones")
            boolConsultar = objseg.TienePermiso("ConsultarDevoluciones")
            boolExportar = objseg.TienePermiso("ExportarDevoluciones")
            boolDesactivar = objseg.TienePermiso("InactivarDevoluciones")

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

        intEstadoFila = CInt(DtDevoluciones.Rows(FilaActual)("objEstadoID"))

        If intEstadoFila = intEstadoDevolucionRegistrado Then
            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked
            DtDevoluciones = objConsultas.actualizarColumnaDT(DtDevoluciones, "AplDevolucionID", CInt(DtDevoluciones.Rows(FilaActual)("AplDevolucionID")), "Seleccionar", blnSeleccionar)
        Else
            chkSeleccionado = CType(sender, DevExpress.XtraEditors.CheckEdit)
            chkSeleccionado.Checked = False
        End If

    End Sub

    Private Sub SincronizarDevoluciones()
        Dim intEstadoRegistrado As Integer
        Dim blnSeleccionado As Boolean
        Dim intAplDevolucionID, intobjSccCuentaID, intobjSfaFacturaID As Integer
        Dim dtFecha As Date
        Dim decTotalDevolucion As Decimal
        Dim objAplDevoluciones As New AplDevoluciones
        Dim SccDev As New SccDevolucion

        Dim t As New TransactionManager
        Dim DtDatosFactura As New DataTable
        Dim objSccCuentaCobrar As New SccCuentaPorCobrar

        Try
            t.BeginTran()

            For Each drFilaDevoluciones As DataRow In DtDevoluciones.Rows
                blnSeleccionado = CBool(drFilaDevoluciones("Seleccionar"))
                intEstadoRegistrado = CInt(drFilaDevoluciones("objEstadoID"))

                If blnSeleccionado And intEstadoRegistrado = intEstadoDevolucionRegistrado Then
                    'Asignacion de valores a Variables
                    intAplDevolucionID = CInt(drFilaDevoluciones("AplDevolucionID"))
                    intobjSccCuentaID = CInt(drFilaDevoluciones("objSccCuentaID"))
                    dtFecha = CDate(drFilaDevoluciones("Fecha"))
                    decTotalDevolucion = CDec(drFilaDevoluciones("TotalDevolucion"))
                    intobjSfaFacturaID = CDec(drFilaDevoluciones("objSfaFacturaID"))

                    '0 Actualizar estado factura proforma
                    With objAplDevoluciones
                        .Retrieve(intAplDevolucionID, t)
                        .objEstadoID = CInt(ClsCatalogos.GetValorCatalogoID("ESTADOAPLICACION", "02"))
                        .Update(t)
                    End With

                    '1 Crear Registro Devoluciones
                    SccDev.Numero = SccDevolucion.RetrieveDT(, , "ISNULL(MAX(Numero),0) + 1 as Maximo", t).DefaultView.Item(0)("Maximo")

                    SccDev.objSccCuentaID = intobjSccCuentaID
                    SccDev.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADODEVOLUCION", "AUTORIZADA")
                    SccDev.TotalDevolucion = decTotalDevolucion
                    SccDev.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    SccDev.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    SccDev.Fecha = dtFecha
                    SccDev.objSfaFacturasID = intobjSfaFacturaID
                    SccDev.Insert(t)

                    '2. actualizar el detalle de las cuentas por cobrar al estado devolucion
                    DtDatosFactura = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID='" & intobjSccCuentaID & "' AND objSfaFacturaID IS NOT NULL", , , t)
                    For Each drw As DataRow In DtDatosFactura.Rows
                        drw("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                        drw("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                        drw("objEstadoID") = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "03")
                    Next
                    DtDatosFactura.TableName = "SccCuentaPorCobrarDetalle"
                    SccCuentaPorCobrarDetalle.BatchUpdate(DtDatosFactura.DataSet, t)

                    '3.Actualizar el estado de las cuentas por cobrar a Devolución
                    objSccCuentaCobrar.Retrieve(intobjSccCuentaID, t)
                    objSccCuentaCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSccCuentaCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSccCuentaCobrar.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "DEVOLUCION")
                    objSccCuentaCobrar.Update(t)

                End If
            Next

            t.CommitTran()
            MsgBox("Devoluciones aplicadas correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AnularDevoluciones()
        Dim intAplDevolucionID, intEstadoRegistrado As Integer
        Dim objAplDevoluciones As New AplDevoluciones
        Dim blnSeleccionado As Boolean = False

        Dim t As New TransactionManager

        Try
            t.BeginTran()

            objAplDevoluciones = New AplDevoluciones

            For Each drFilaDevoluciones As DataRow In DtDevoluciones.Rows
                intAplDevolucionID = CInt(drFilaDevoluciones("AplDevolucionID"))
                blnSeleccionado = CBool(drFilaDevoluciones("Seleccionar"))
                intEstadoRegistrado = CInt(drFilaDevoluciones("objEstadoID"))

                If blnSeleccionado And intEstadoRegistrado = intEstadoDevolucionRegistrado Then
                    With objAplDevoluciones
                        .Retrieve(intAplDevolucionID, t)
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
        Try
            SincronizarDevoluciones()
            CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.EditValue, cmbRuta.EditValue)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
   

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        AnularDevoluciones()
        CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.EditValue, cmbRuta.EditValue)
    End Sub

    Private Sub cmbExportar_Click_1(sender As Object, e As EventArgs) Handles cmbExportar.Click
        ExportarExcel()
    End Sub
End Class