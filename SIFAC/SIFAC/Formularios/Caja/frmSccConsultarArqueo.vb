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
        Try
            CargarCajeros()

            Select Case TypeGui
                Case 0
                    Me.Text = "Visualizar arqueo"
                    cmdAprobar.Visible = False
                    spnFaltante.Enabled = False
                    txtAprobadoPor.Enabled = False
                Case 1
                    Me.Text = "Aprobar arqueo"
                    CargarDatosArqueo()
                Case 2
                    Me.Text = "Consultar Caja"
                    CargarDatosArqueo()
                    cmdAprobar.Visible = False
                    spnFaltante.Enabled = False
                    txtAprobadoPor.Enabled = False

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una Caja
    Public Sub CargarDatosArqueo()
        Dim objArqueo As SccArqueoCaja
        Dim objcaja As SccCajas
        Try
            objArqueo = New SccArqueoCaja
            objcaja = New SccCajas

            objArqueo.Retrieve(ArqueoID)
            txtAprobadoPor.Text = objArqueo.AprobadoPor
            spnEgreso.Value = objArqueo.SalidaEfectivo
            spnIngreso.Value = objArqueo.EntradaEfectivo
            cmbCajero.SelectedValue = objArqueo.objCajeroID
            spnFaltante.Value = objArqueo.Faltante

            objcaja.Retrieve(objArqueo.objCajaID)

            lblCaja.Text = "Caja: " & objcaja.Codigo

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objArqueo = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo arqueo
    Public Sub GuardarArqueo()
        Dim objArqueo As SccArqueoCaja
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objArqueo = New SccArqueoCaja

            objArqueo.Fecha = dtFecha.DateTime
            objArqueo.EntradaEfectivo = spnIngreso.Value
            objArqueo.SalidaEfectivo = spnEgreso.Value
            objArqueo.Faltante = spnFaltante.Value
            objArqueo.AprobadoPor = txtAprobadoPor.Text
            objArqueo.objCajaID = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
            objArqueo.objCajeroID = cmbCajero.SelectedValue
            objArqueo.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objArqueo.UsuarioCreacion = clsProyecto.Conexion.Servidor
            ArqueoID = objArqueo.ArqueoID



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


#End Region

    Private Sub frmSccConsultarArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class