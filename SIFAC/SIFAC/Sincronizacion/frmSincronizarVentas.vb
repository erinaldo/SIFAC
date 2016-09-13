Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Catalogos.Datos

Public Class frmSincronizarVentas

#Region "Declaracion de Variables"
    Public DtEmpleados, DtRuta, DtVentas, DtEstados As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAprobar, boolConsultar, boolExportar, boolDesactivar As Boolean
#End Region

#Region "Procedimientos"
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
                DtVentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("fecha, objEstadoID, SfaFacturaProformaID, ObjRutaID,Ruta, Cliente, SrhEmpleadoID, Empleado, Subtotal, Descuento, Total, Prima, Saldo, observaciones", "vwAplicacionVentas", "1=1"))
            End If

            If Not blnTodos And (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtVentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("fecha, objEstadoID,SfaFacturaProformaID, ObjRutaID,Ruta, Cliente, SrhEmpleadoID, Empleado, Subtotal, Descuento, Total, Prima, Saldo, observaciones", "vwAplicacionVentas", "ObjRutaID =" + intRutaID + " AND SrhEmpleadoID=" + intEmpleadoID + " AND objEstadoID=" + intEstadoID))
            End If

            If Not blnTodos And (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And Not (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtVentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("fecha,objEstadoID, SfaFacturaProformaID, ObjRutaID,Ruta, Cliente, SrhEmpleadoID, Empleado, Subtotal, Descuento, Total, Prima, Saldo, observaciones", "vwAplicacionVentas", " SrhEmpleadoID=" + intEmpleadoID + " AND objEstadoID=" + intEstadoID))
            End If


            If Not blnTodos And Not (intEmpleadoID <> 0 Or IsDBNull(intEmpleadoID)) And (intRutaID <> 0 Or IsDBNull(intRutaID)) Then
                DtVentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("fecha, objEstadoID,SfaFacturaProformaID, ObjRutaID,Ruta, Cliente, SrhEmpleadoID, Empleado, Subtotal, Descuento, Total, Prima, Saldo, observaciones", "vwAplicacionVentas", "ObjRutaID =" + intRutaID + "  AND objEstadoID=" + intEstadoID))
            End If

            DtVentas.PrimaryKey = New DataColumn() {Me.DtVentas.Columns("SfaFacturaProformaID")}
            DtVentas.DefaultView.Sort = "fecha"
            Me.grdVentas.DataSource = DtVentas
            Me.grdVentas.Text = "Ventas (" & Me.DtVentas.Rows.Count & ")"
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
            CargarRuta()
            CargarEmpleados()
            CargarEstados()
            Me.AplicarSeguridad()
            'CargarGrid(False, False, 0, 0)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.EditValue, cmbRuta.EditValue)
    End Sub
End Class