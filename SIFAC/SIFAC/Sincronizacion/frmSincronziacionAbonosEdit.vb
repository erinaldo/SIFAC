Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos.ClsCatalogos

Public Class frmSincronziacionAbonosEdit

#Region "Declaracion de Variables"
    Public intCobroID As Integer
    Public DtCobrador, dtCliente, dtEstados, dtRutas As DataTable
#End Region

#Region "Propiedades"

    Property CobroID() As Integer
        Get
            Return intCobroID
        End Get
        Set(ByVal value As Integer)
            intCobroID = value
        End Set
    End Property

#End Region

#Region "Funciones"

    '' Descripción:        Funcion encargada de validar la entrada del usuario

    Public Function ValidarEntrada() As Boolean
        If txtMonto.Text.Trim.Length = 0 Or txtMonto.EditValue = 0 Then
            ErrorProv.SetError(txtMonto, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

#Region "Procedimientos"

    '' Descripción:        Procedimiento encargado de cargar el combo de Cobrador
    Public Sub CargarInformacion()
        Try
            DtCobrador = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))
            dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("ClienteID,NombreCompleto", "vwSfaClienteFactura", "Descripcion = 'Cliente'"))
            dtEstados = ObtenerValCat("ESTADOAPLICACION")
            dtRutas = StbRutas.RetrieveDT("1=1", "", "StbRutaID,Nombre")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


    '' Descripción:        Procedimiento encargado de cargar la informacion de una marca
    Public Sub CargarDatos()
        Dim objaplCobros As AplCobros
        Try
            objaplCobros = New AplCobros
            objaplCobros.Retrieve(CobroID)

            dtFechaAbono.Value = objaplCobros.FechaAbono

            txtRuta.Text = dtRutas.Select("StbRutaID=" & objaplCobros.objStbRutaID)(0)("Nombre").ToString
            txtCobrador.Text = DtCobrador.Select("SrhEmpleadoID=" & objaplCobros.objCobradorID)(0)("NombreCompleto").ToString
            txtCliente.Text = dtCliente.Select("ClienteID=" & objaplCobros.objSccClienteID)(0)("NombreCompleto").ToString()
            txtEstado.Text = dtEstados.Select("StbValorCatalogoID=" & objaplCobros.objEstadoID)(0)("Descripcion")
            txtMonto.EditValue = objaplCobros.MontoAbonado
            txtSaldo.EditValue = objaplCobros.Saldo
            txtCuenta.Text = SccCuentaPorCobrar.RetrieveDT("SccCuentaID=" & objaplCobros.objSccCuentaID).Rows(0)("Numero").ToString()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objaplCobros = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de marca
    Public Sub Guardar()
        Dim objaplCobros As AplCobros
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objaplCobros = New AplCobros
            objaplCobros.MontoAbonado = txtMonto.EditValue
            objaplCobros.Saldo = objaplCobros.Saldo - txtMonto.EditValue
            objaplCobros.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objaplCobros.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objaplCobros.Insert()

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objaplCobros = Nothing
        End Try
    End Sub
#End Region

#Region "Eventos del Formulario"

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Guardar()
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        ErrorProv.SetError(txtMonto, "")
    End Sub

#End Region

    Private Sub frmSincronziacionAbonosEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInformacion()
        CargarDatos()
    End Sub
End Class