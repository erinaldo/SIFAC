Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSrhEmpleado

#Region "Variables del formulario"
    Public DtEmpleados As DataTable
    Public boolAgregar, boolEditar, boolConsultar As Boolean
    Public objSeg As SsgSeguridad
#End Region

#Region "Procedimientos"

    '' Descripción:        Procedimiento encargado de cargar la informacion de los empleados existentes
    Public Sub CargarGrid()
        Try
            DtEmpleados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SrhEmpleadoID,objPersonaID,Nombre1,Nombre2,Apellido1,Apellido2,Genero,Cargo,Activo", "vwSrhEmpleado"))
            DtEmpleados.PrimaryKey = New DataColumn() {Me.DtEmpleados.Columns("SrhEmpleadoID")}
            DtEmpleados.DefaultView.Sort = "SrhEmpleadoID"
            Me.grdvwEmpleados.DataSource = DtEmpleados
            Me.grdvwEmpleados.Text = "Empleados (" & Me.DtEmpleados.Rows.Count & ")"
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '' Descripción:        Procedimiento encargado de aplicar la seguridad al formulario
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "frmSrhEmpleado"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AgregarEmpleado")
            boolEditar = objSeg.TienePermiso("ModificarEmpleado")
            boolConsultar = objSeg.TienePermiso("ConsultarEmpleado")
            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And DtEmpleados.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And DtEmpleados.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub frmSrhEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor
            clsProyecto.CargarTemaDefinido(Me)
            Me.CargarGrid()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try        
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.DtEmpleados = Nothing
        objSeg = Nothing
        boolAgregar = Nothing
        boolEditar = Nothing
        boolConsultar = Nothing
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Me.CargarGrid()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim editEmpleado As frmSrhEmpleadoEditar
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 0
           
            If editEmpleado.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim editEmpleado As frmSrhEmpleadoEditar
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            FilaActual = Me.grdvwEmpleadosTabla.FocusedRowHandle
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 1
            editEmpleado.EmpleadoID = Me.DtEmpleados.DefaultView.Item(FilaActual)("SrhEmpleadoID")
            editEmpleado.PersonaID = Me.DtEmpleados.DefaultView.Item(FilaActual)("objPersonaID")
            editEmpleado.Text = "Editar Empleado"
            If editEmpleado.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                'Me.grdEmpleados.Row = DtEmpleados.DefaultView.Find(editEmpleado.intEmpleadoID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim editEmpleado As frmSrhEmpleadoEditar
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            FilaActual = Me.grdvwEmpleadosTabla.FocusedRowHandle
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 2
            editEmpleado.EmpleadoID = Me.DtEmpleados.DefaultView.Item(FilaActual)("SrhEmpleadoID")
            editEmpleado.PersonaID = Me.DtEmpleados.DefaultView.Item(FilaActual)("objPersonaID")
            editEmpleado.Text = "Consultar Empleado"
            editEmpleado.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub grdEmpleados_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.grdEmpleados.Caption = "Empleados (" & DtEmpleados.Rows.Count & ")"
    End Sub
End Class