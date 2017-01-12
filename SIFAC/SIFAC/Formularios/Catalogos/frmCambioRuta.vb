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

    Private Sub GuardarCambioRutas()
        Dim dtClientesSeleccionados As DataTable
        Dim objClientes As New SccClientes
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
            GuardarCambioRutas()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
#End Region
  
End Class