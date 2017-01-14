Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Windows.Forms.Cursors
Imports Proyecto.Catalogos.Datos

Public Class frmSccConsultarArqueo

#Region "Declaracion de Variables"

    Public intTypeGui As Integer
    Public intArqueoID As Integer
    Dim dtCajeros, dtDetalle As DataTable
    Dim dtDetalleAbonos, dtDetallaFacturas, dtDetalleComisiones, deDetalleSalidas As DataTable

#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property ArqueoID() As Integer
        Get
            Return intArqueoID
        End Get
        Set(ByVal value As Integer)
            intArqueoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    Public Sub CargarInformacionArqueoInicial()
        Dim dblEgreso, dblIngreso As Decimal
        Try
            dblEgreso = 0
            dblIngreso = 0
            dtDetallaFacturas = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SfaFacturaID, Fecha, TotalCordobas", "vwRptFacturaContadoArqueo", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))
            dtDetalleComisiones = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccNotaCreditoID, SccComisionID, Empleado, Fecha, objEmpleadoID, Monto", "vwComiscionesArqueo", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))
            dtDetalleAbonos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccRecuperacion, Fecha, Monto", "vwRecuperacionArqueo", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))
            deDetalleSalidas = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccNotaCreditoID, Fecha, Monto", "vwSalidasEfectivoArqueo", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))

            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Concepto, Entrada, Salida, Fecha", "vwArqueoConsolidado", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))

            grdDetalle.DataSource = dtDetalle

            For Each drw As DataRow In Me.dtDetalle.Rows
                dblEgreso = dblEgreso + drw("Salida")
                dblIngreso = dblIngreso + drw("Entrada")
            Next
            spnEgreso.Value = dblEgreso
            spnIngreso.Value = dblIngreso
            spnDisponible.Value = dblIngreso - dblEgreso

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarCajeros()
        Try
            dtCajeros = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))

            cmbCajero.DataSource = dtCajeros
            cmbCajero.ValueMember = "SrhEmpleadoID"
            cmbCajero.DisplayMember = "NombreCompleto"

            cmbCajero.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Dim objCajero As New SccCajas
        Try
            CargarCajeros()

            Select Case TypeGui
                Case 0
                    Me.dtFecha.DateTime = Date.Now
                    Me.Text = "Visualizar arqueo"
                    cmdAprobar.Visible = False
                    spnFaltante.Enabled = False
                    txtAprobadoPor.Enabled = False
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCaja

                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")
                    cmbCajero.SelectedValue = objCajero.objCajeroID

                    CargarInformacionArqueoInicial()
                    '' Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
                Case 1
                    Me.Text = "Aprobar arqueo"
                    Me.dtFecha.DateTime = Date.Now
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCaja
                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")
                    cmbCajero.SelectedValue = objCajero.objCajeroID

                    txtAprobadoPor.Enabled = True
                    spnFaltante.Enabled = True
                    CargarInformacionArqueoInicial()
                    '' Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
                Case 2
                    Me.Text = "Consultar Caja"
                    CargarDatosArqueo()
                    cmdAprobar.Visible = False
                    spnFaltante.Enabled = False
                    txtAprobadoPor.Enabled = False
                    cmbCajero.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una Caja
    Public Sub CargarDatosArqueo()
        Dim objArqueo As SccArqueoCaja
        Dim objcaja As SccCajas
        Dim objCajero As New SccCajas

        Try
            objArqueo = New SccArqueoCaja
            objcaja = New SccCajas

            objArqueo.Retrieve(ArqueoID)
            txtAprobadoPor.Text = objArqueo.AprobadoPor
            spnEgreso.Value = objArqueo.SalidaEfectivo
            spnIngreso.Value = objArqueo.EntradaEfectivo
            cmbCajero.SelectedValue = objArqueo.objCajeroID
            dtFecha.DateTime = objArqueo.Fecha
            spnFaltante.Value = objArqueo.Faltante
            spnDisponible.Value = spnIngreso.Value - spnEgreso.Value
            objcaja.Retrieve(objArqueo.objCajaID)

            lblCaja.Text = "Caja: " & objcaja.Codigo
            objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")
            cmbCajero.SelectedValue = objCajero.objCajeroID

            dtDetallaFacturas = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SfaFacturaID, Fecha, TotalCordobas", "vwRptFacturaContadoArqueo", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))
            dtDetalleComisiones = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccNotaCreditoID, SccComisionID, Empleado, Fecha, objEmpleadoID, Monto", "vwComiscionesArqueo", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))
            dtDetalleAbonos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccRecuperacion, Fecha, Monto", "vwRecuperacionArqueo", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))
            deDetalleSalidas = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccNotaCreditoID, Fecha, Monto", "vwSalidasEfectivoArqueo", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))

            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Concepto, Entrada, Salida, Fecha", "vwArqueoConsolidado", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))

            grdDetalle.DataSource = dtDetalle


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objArqueo = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo arqueo
    Public Sub GuardarArqueo()
        Dim objArqueo As SccArqueoCaja
        Dim objFacturas As SccFacturaContadoArqueo
        Dim objAbonos As SccAbonoArqueoDetalle
        Dim objComisiones As SccComisionesArqueo
        Dim objSalidas As SccSalidasEfectivoArqueo

        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objArqueo = New SccArqueoCaja
            objFacturas = New SccFacturaContadoArqueo
            objAbonos = New SccAbonoArqueoDetalle
            objSalidas = New SccSalidasEfectivoArqueo
            objComisiones = New SccComisionesArqueo

            objArqueo.Fecha = dtFecha.DateTime
            objArqueo.EntradaEfectivo = spnIngreso.Value
            objArqueo.SalidaEfectivo = spnEgreso.Value
            objArqueo.Faltante = spnFaltante.Value
            objArqueo.AprobadoPor = txtAprobadoPor.Text
            objArqueo.objCajaID = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
            objArqueo.objCajeroID = cmbCajero.SelectedValue
            objArqueo.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objArqueo.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objArqueo.Insert(T)
            ArqueoID = objArqueo.ArqueoID

            ''Guardar facturas
            For Each drw As DataRow In Me.dtDetallaFacturas.Rows
                objFacturas.objArqueoID = ArqueoID
                objFacturas.objSfaFacturaID = drw("SfaFacturaID")
                objFacturas.Total = drw("TotalCordobas")
                objFacturas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objFacturas.UsuarioCreacion = clsProyecto.Conexion.Servidor

                objFacturas.Insert(T)
            Next

            ''Guardar abonos
            For Each drw As DataRow In Me.dtDetalleAbonos.Rows
                objAbonos.objSccArqueoDetalleID = ArqueoID
                objAbonos.Monto = drw("Monto")
                objAbonos.objRecuparacionID = drw("SccRecuperacion")
                objAbonos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAbonos.UsuarioCreacion = clsProyecto.Conexion.Servidor

                objAbonos.Insert(T)
            Next

            ''Guardar comisiones
            For Each drw As DataRow In Me.dtDetalleComisiones.Rows
                objComisiones.objArqueoID = ArqueoID
                objComisiones.Total = drw("Monto")
                objComisiones.objComisionID = drw("SccComisionID")
                objComisiones.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objComisiones.UsuarioCreacion = clsProyecto.Conexion.Servidor

                objComisiones.Insert(T)
            Next

            ''Guardar salidas
            For Each drw As DataRow In Me.deDetalleSalidas.Rows
                objSalidas.objArqueoID = ArqueoID
                objSalidas.Total = drw("Monto")
                objSalidas.objSccNotaCreditoID = drw("SccNotaCreditoID")
                objSalidas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSalidas.UsuarioCreacion = clsProyecto.Conexion.Servidor
                objSalidas.Insert(T)
            Next


            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objArqueo = Nothing
        End Try
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            If Me.cmbCajero.Text = String.Empty Then
                Me.ErrorProv.SetError(Me.cmbCajero, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.txtAprobadoPor.Text = String.Empty Then
                Me.ErrorProv.SetError(Me.txtAprobadoPor, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

    Private Sub frmSccConsultarArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        If Me.ValidarDatos Then
            GuardarArqueo()
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub txtAprobadoPor_TextChanged(sender As Object, e As EventArgs) Handles txtAprobadoPor.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbCajero_TextChanged(sender As Object, e As EventArgs) Handles cmbCajero.TextChanged
        Me.ErrorProv.Clear()
    End Sub
End Class