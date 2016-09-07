Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO

Public Class frmSivEncargos

#Region "Variables del formulario"
    Dim dtEncargos, dtDetalleEncargos As DataTable
    Dim dsEncargos As DataSet
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar, boolDesactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla


    Private Sub CargarEncargos(ByVal strFiltro As String)
        Try

            dtEncargos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivEncargoID, Numero, TotalCosto, Fecha, Vendedor, Cliente, Activo, objSccClienteID", "vwSivEncargosMaster", strFiltro & " ORDER BY Fecha DESC"), Me.SqlParametros)
            dtDetalleEncargos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivEncargoDetalleID, objSivEncargoID, objCategoriaID, Categoria, Numero, NombreProducto, Cantidad, CostoPromedio, TotalCosto", "vwSivaEncargosDetalle", strFiltro), Me.SqlParametros)

            dsEncargos = New DataSet

            dsEncargos.Merge(dtEncargos)
            dsEncargos.Tables(0).TableName = "SivEncargos"

            dsEncargos.Merge(dtDetalleEncargos)
            dsEncargos.Tables(1).TableName = "SivEncargosDetalle"

            dsEncargos.Relations.Add("SivEncargos_SivEncargosDetalle", dsEncargos.Tables(0).Columns("SivEncargoID"), dsEncargos.Tables(1).Columns("objSivEncargoID"), False)

            Me.grdEncargosMaster.DataSource = dsEncargos
            Me.grdEncargosMaster.DataMember = "SfaFactura"

            Me.grdEncargosDetalle.DataSource = dsEncargos
            Me.grdEncargosDetalle.DataMember = "SivEncargos.SivEncargos_SivEncargosDetalle"

            Me.grdEncargosMaster.Text = "Encargos (" & Me.grdEncargosMasterTabla.RowCount & ")"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "FRMSIVENCARGOS"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarEncargo")
            boolConsultar = objseg.TienePermiso("ConsultarEncargo")
            boolEditar = objseg.TienePermiso("EditarEncargo")
            boolImprimir = objseg.TienePermiso("ImprimirEncargo")
            boolDesactivar = objseg.TienePermiso("InactivasEncargo")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtEncargos.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtEncargos.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtEncargos.Rows.Count > 0
            cmdDesactivar.Enabled = boolDesactivar And dtEncargos.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarEncargos As New frmSivEncargosEdit
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
                ConsultarEncargos.TypeGui = 3
                ConsultarEncargos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
                ConsultarEncargos.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarEncargos = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarEncargo As New frmSivEncargosEdit
        Dim FilaActual As Integer
        Try
            Try
                FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
                EditarEncargo.TypeGui = 2
                EditarEncargo.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
                EditarEncargo.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarEncargo = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del formulario"

    Private Sub frmSivEncargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       Try
            clsProyecto.CargarTemaDefinido(Me)
            CargarEncargos("1=1")
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editEncargos As frmSivEncargosEdit
        Try
            Me.Cursor = WaitCursor
            editEncargos = New frmSivEncargosEdit
            editEncargos.TypeGui = 0
            If editEncargos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarEncargos("1=1")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Dim editEncargos As frmSivEncargosEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle

            Me.Cursor = WaitCursor
            editEncargos = New frmSivEncargosEdit
            editEncargos.TypeGui = 1
            editEncargos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
            If editEncargos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarEncargos("1=1")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim editEncargos As frmSivEncargosEdit
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
            Me.Cursor = WaitCursor
            editEncargos = New frmSivEncargosEdit
            editEncargos.TypeGui = 2
            editEncargos.EncargoID = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
            editEncargos.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdDesactivar.Click
        Dim IDEncargo As Integer
        Dim Encargos As New SivEncargos
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdEncargosMasterTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de In  activar el encargo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDEncargo = Me.dtEncargos.DefaultView.Item(FilaActual)("SivEncargoID")
                    Encargos.Retrieve(IDEncargo)
                    Encargos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Encargos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Encargos.Activo = False
                    Encargos.Update()
                    CargarEncargos("1=1")
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Try
            CargarEncargos("1=1")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub

#End Region

End Class