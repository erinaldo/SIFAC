Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos

Public Class frmCambioRuta

#Region "Declaracion de Variables"
    Private dtRutas, DtDias As DataTable
    Private dtClientes As DataTable
#End Region

#Region "Propiedades"

    Property DatadtClientes() As DataTable
        Get
            Return dtClientes
        End Get
        Set(ByVal value As DataTable)
            dtClientes = value
        End Set
    End Property

#End Region

#Region "Procedimientos"
    Private Sub CargarRuta()
        Dim objRuta As StbRutas
        Try
            objRuta = New StbRutas
            'Rutas
            dtRutas = StbRutas.RetrieveDT("1=1", "", "StbRutaID,Nombre")
            Me.cmbRutas.DataSource = dtRutas
            Me.cmbRutas.DisplayMember = "Nombre"
            Me.cmbRutas.ValueMember = "StbRutaID"
            Me.cmbRutas.Splits(0).DisplayColumns("StbRutaID").Visible = False
            Me.cmbRutas.ExtendRightColumn = True
            Me.cmbRutas.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRuta = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar el combo de Cobrador
    Public Sub CargarDias()
        Try
            DtDias = New DataTable("Dias")
            Dim FNameColumn As New DataColumn("NombreDia")
            Dim FNumeroColumn As New DataColumn("IDDia")

            FNameColumn.DataType = GetType(String)
            FNumeroColumn.DataType = GetType(Integer)

            DtDias.Columns.Add(FNameColumn)
            DtDias.Columns.Add(FNumeroColumn)

            Dim newDiasRow As DataRow

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "0"
            newDiasRow("NombreDia") = "Ninguno"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "1"
            newDiasRow("NombreDia") = "Domingo"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "2"
            newDiasRow("NombreDia") = "Lunes"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "3"
            newDiasRow("NombreDia") = "Martes"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "4"
            newDiasRow("NombreDia") = "Miercoles"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "5"
            newDiasRow("NombreDia") = "Jueves"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "6"
            newDiasRow("NombreDia") = "Viernes"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "7"
            newDiasRow("NombreDia") = "Sabado"
            DtDias.Rows.Add(newDiasRow)

            With cmbDiaCrobro
                .DataSource = DtDias
                .DisplayMember = "NombreDia"
                .ValueMember = "IDDia"
                .Splits(0).DisplayColumns("IDDia").Visible = False
                .ColumnHeaders = False
                .ExtendRightColumn = True
                .SelectedValue = -1
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarDatosIniciales()
        Try
            CargarRuta()
            CargarDias()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Function ValidarEntrada() As Boolean
        If cmbRutas.Text.Trim.Length = 0 Then
            ErrorProv.SetError(cmbRutas, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If cmbDiaCrobro.Text.Trim.Length = 0 Then
            ErrorProv.SetError(cmbDiaCrobro, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub GuardarCambioRutas()
        Dim dtClientesSeleccionados, dtCuentas, dtCuentasDetalle As DataTable
        Dim objClientes As New SccClientes
        Dim dia, diaanterior As Integer

        Dim t As New TransactionManager
        Try
            ''Clonar estructura del DataTable
            dtClientesSeleccionados = dtClientes.Clone()
            Dim copyRows() As DataRow = dtClientes.Select("Seleccionar = 1")

            ''Copiar la informacion
            For Each copyRow As DataRow In copyRows
                dtClientesSeleccionados.ImportRow(copyRow)
            Next

            t.BeginTran()
            For Each drFilaClientes As DataRow In dtClientesSeleccionados.Rows
                ''Modificar clientes en la nueva ruta y dia
                objClientes.Retrieve(CInt(drFilaClientes("ClienteID")))
                objClientes.objRutaID = cmbRutas.SelectedValue
                objClientes.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objClientes.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objClientes.Update(t)

                ''Buscar las cuentas de este cliente
                Dim objCuentas As New SccCuentaPorCobrar
                dtCuentas = SccCuentaPorCobrar.RetrieveDT("objClienteID=" & CInt(drFilaClientes("ClienteID")) & " AND objEstadoID=" & ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "VIGENTE"))

                If dtCuentas.Rows.Count > 0 Then

                    For Each drFilaCuentas As DataRow In dtCuentas.Rows
                        dtCuentasDetalle = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID=" & CInt(drFilaCuentas("SccCuentaID")) & " AND objEstadoID= " & ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "VIGENTE"))

                        If dtCuentasDetalle.Rows.Count > 0 Then
                            For Each drFilaCuentasDetalle As DataRow In dtCuentasDetalle.Rows
                                Dim objDetalleCuenta As New SccCuentaPorCobrarDetalle

                                objDetalleCuenta.Retrieve(CInt(drFilaCuentasDetalle("SccCuentaPorCobrarDetalleID")))

                                diaanterior = objDetalleCuenta.FechaProximoPago.Value.DayOfWeek
                                dia = cmbDiaCrobro.SelectedValue

                                objDetalleCuenta.FechaProximoPago = objDetalleCuenta.FechaProximoPago.Value.AddDays(Math.Abs(diaanterior - dia))
                               objDetalleCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objDetalleCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objDetalleCuenta.Update(t)
                            Next
                        End If
                    Next
                End If
            Next
            t.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            dtClientesSeleccionados = Nothing
            objClientes = Nothing
        End Try
    End Sub
#End Region

#Region "Eventos del Formulario"
    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            If ValidarEntrada() Then
                GuardarCambioRutas()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
  
    Private Sub frmCambioRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
           CargarDatosIniciales
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbRutas_TextChanged(sender As Object, e As EventArgs) Handles cmbRutas.TextChanged
        Dim objRuta As New StbRutas
        Try
            ErrorProv.SetError(cmbRutas, "")

            ''Buscar dia de la ruta seleccionada
            objRuta.Retrieve(cmbRutas.SelectedValue)
            cmbDiaCrobro.SelectedValue = objRuta.DiaCobro

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRuta = Nothing
        End Try



    End Sub

#End Region
End Class