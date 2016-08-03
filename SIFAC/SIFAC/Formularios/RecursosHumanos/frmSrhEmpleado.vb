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

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de cargar la informacion de los empleados existentes
    Public Sub CargarGrid()
        Try
            DtEmpleados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SrhEmpleadoID,objPersonaID,Nombre1,Nombre2,Apellido1,Apellido2,Genero,Cargo,Activo", "vwSrhEmpleado"))
            DtEmpleados.PrimaryKey = New DataColumn() {Me.DtEmpleados.Columns("SrhEmpleadoID")}
            DtEmpleados.DefaultView.Sort = "SrhEmpleadoID"
            Me.grdEmpleados.SetDataBinding(DtEmpleados, "", True)
            Me.grdEmpleados.Caption = "Empleados (" & DtEmpleados.Rows.Count & ")"
            Me.grdEmpleados.Refresh()
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  13/03/2009
    '' Descripción:        Procedimiento encargado de aplicar la seguridad al formulario
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "FRMSRHEMPLEADO"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AGREGAREMPLEADO")
            boolEditar = objSeg.TienePermiso("EDITAREMPLEADO")
            boolConsultar = objSeg.TienePermiso("CONSULTAREMPLEADO")
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
        Me.grdEmpleados = Nothing
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
                Me.grdEmpleados.Row = DtEmpleados.DefaultView.Find(editEmpleado.intEmpleadoID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim editEmpleado As frmSrhEmpleadoEditar
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 1
            editEmpleado.EmpleadoID = Me.grdEmpleados.Columns("SrhEmpleadoID").Value
            editEmpleado.PersonaID = Me.grdEmpleados.Columns("objPersonaID").Value
            editEmpleado.Text = "Editar Empleado"
            If editEmpleado.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                Me.grdEmpleados.Row = DtEmpleados.DefaultView.Find(editEmpleado.intEmpleadoID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim editEmpleado As frmSrhEmpleadoEditar
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 2
            editEmpleado.EmpleadoID = Me.grdEmpleados.Columns("SrhEmpleadoID").Value
            editEmpleado.PersonaID = Me.grdEmpleados.Columns("objPersonaID").Value
            editEmpleado.Text = "Consultar Empleado"
            editEmpleado.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub grdEmpleados_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdEmpleados.FilterChange
        Me.grdEmpleados.Caption = "Empleados (" & DtEmpleados.Rows.Count & ")"
    End Sub
End Class