Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIFAC.BO

Public Class frmSccComisiones

#Region "Variables del formulario"
    Dim dComisiones As DataTable
    Dim EsNotaDebito As Integer
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolAnular, boolPagar As Boolean
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Try
            dComisiones = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Numero, Fecha,Empleado,EsNotaDebito, Concepto, Monto, Estado", "vwComisiones", "Activa=1"))
            'dComisiones.PrimaryKey = New DataColumn() {Me.dComisiones.Columns("Numero")}
            dComisiones.DefaultView.Sort = "Numero"
            Me.grdComisiones.DataSource = dComisiones
            Me.grdComisiones.Text = "Comisiones (" & Me.dComisiones.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Dim FilaActual As Integer
        Try
            objseg.ServicioUsuario = "frmSccComisiones"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarComision")
            boolEditar = objseg.TienePermiso("EditarComision")
            boolPagar = objseg.TienePermiso("PagarComision")
            boolConsultar = objseg.TienePermiso("ConsultarComision")
            boolAnular = objseg.TienePermiso("AnularComision")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dComisiones.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dComisiones.Rows.Count > 0
            cmdPagar.Enabled = boolPagar And dComisiones.Rows.Count > 0
            cmdAnular.Enabled = boolAnular And dComisiones.Rows.Count > 0

            If dComisiones.Rows.Count > 0 Then
                Dim selectedRow As Integer() = grdComisionesTabla.GetSelectedRows()

                FilaActual = Me.grdComisionesTabla.GetDataSourceRowIndex(selectedRow(0))

                If Me.dComisiones.DefaultView.Item(FilaActual)("EsNotaDebito").ToString.Trim.Length <> 0 Then

                    If Me.dComisiones.DefaultView.Item(FilaActual)("EsNotaDebito") <> 0 Then
                        Me.cmdAnular.Enabled = False
                        Me.cmdEditar.Enabled = False
                        Me.cmdPagar.Enabled = False
                    Else
                        Me.cmdAnular.Enabled = True
                        Me.cmdEditar.Enabled = True
                        Me.cmdPagar.Enabled = True
                    End If
                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarComision As New frmSccComisionesEdit
        Dim EditarNotaDebito As New frmSccEditNotaDebito
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdComisionesTabla.GetSelectedRows()
                FilaActual = Me.grdComisionesTabla.GetDataSourceRowIndex(selectedRow(0))
                EsNotaDebito = Me.dComisiones.DefaultView.Item(FilaActual)("EsNotaDebito")

                If EsNotaDebito = 0 Then
                    EditarComision.TypeGui = 1
                    EditarComision.ComisionID = Convert.ToInt32(Me.dComisiones.DefaultView.Item(FilaActual)("Numero"))
                    EditarComision.ShowDialog(Me)
                Else
                    EditarNotaDebito.TypeGui = 1
                    EditarNotaDebito.IDNotaDebito = Convert.ToInt32(Me.dComisiones.DefaultView.Item(FilaActual)("Numero"))
                    EditarNotaDebito.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarComision = Nothing
            EditarNotaDebito = Nothing
        End Try
    End Sub

    Private Sub Consultar()
        Dim ConsultarComision As New frmSccComisionesEdit
        Dim ConsultarNotaDebito As New frmSccEditNotaCredito
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdComisionesTabla.GetSelectedRows()
                FilaActual = Me.grdComisionesTabla.GetDataSourceRowIndex(selectedRow(0))
                EsNotaDebito = Me.dComisiones.DefaultView.Item(FilaActual)("EsNotaDebito")

                If EsNotaDebito = 0 Then
                    ConsultarComision.TypeGui = 2
                    ConsultarComision.ComisionID = Me.dComisiones.DefaultView.Item(FilaActual)("Numero")
                    ConsultarComision.ShowDialog(Me)
                Else
                    ConsultarNotaDebito.TypeGui = 2
                    ConsultarNotaDebito.Tipo = "Comisiones"
                    ConsultarNotaDebito.IDNotaCredito = Me.dComisiones.DefaultView.Item(FilaActual)("Numero")
                    ConsultarNotaDebito.ShowDialog(Me)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarComision = Nothing
        End Try
    End Sub

    Private Sub Pagar()
        Dim ConsultarNotaDebito As New frmSccEditNotaCredito
        Dim FilaActual As Integer

        Try
            Try
                Dim selectedRow As Integer() = grdComisionesTabla.GetSelectedRows()
                FilaActual = Me.grdComisionesTabla.GetDataSourceRowIndex(selectedRow(0))
                ConsultarNotaDebito.TypeGui = 0
                ConsultarNotaDebito.Tipo = "Comisiones"
                ConsultarNotaDebito.IDComisionID = Me.dComisiones.DefaultView.Item(FilaActual)("Numero")
                ConsultarNotaDebito.ShowDialog(Me)

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarNotaDebito = Nothing
        End Try
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        CargarGrid()
    End Sub

    Private Sub frmSccComisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
       Try
            Me.Cursor = WaitCursor
            Editar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Try
            Me.Cursor = WaitCursor
            Consultar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editComision As frmSccComisionesEdit
        Try
            Me.Cursor = WaitCursor
            editComision = New frmSccComisionesEdit
            editComision.TypeGui = 0
            If editComision.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                AplicarSeguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdAnular_Click(sender As Object, e As EventArgs) Handles cmdAnular.Click
        Dim IDComision As Integer
        Dim Comisiones As New SccComisiones
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdComisionesTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de anular la comision?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDComision = Convert.ToInt32(Me.dComisiones.DefaultView.Item(FilaActual)("Numero"))
                    Comisiones.Retrieve(IDComision)
                    Comisiones.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Comisiones.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Comisiones.Activa = False
                    Comisiones.Update()
                    CargarGrid()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdPagar_Click(sender As Object, e As EventArgs) Handles cmdPagar.Click
        Pagar()
        CargarGrid()
        AplicarSeguridad()
    End Sub

    Private Sub grdComisionesTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdComisionesTabla.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdComisionesTabla.GetSelectedRows()
            FilaActual = Me.grdComisionesTabla.GetDataSourceRowIndex(selectedRow(0))

            If Me.dComisiones.DefaultView.Item(FilaActual)("EsNotaDebito").ToString.Trim.Length <> 0 Then

                If Me.dComisiones.DefaultView.Item(FilaActual)("EsNotaDebito") <> 0 Then
                    Me.cmdAnular.Enabled = False
                    Me.cmdEditar.Enabled = False
                    Me.cmdPagar.Enabled = False
                Else
                    Me.cmdAnular.Enabled = True
                    Me.cmdEditar.Enabled = True
                    Me.cmdPagar.Enabled = True
                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

   
End Class