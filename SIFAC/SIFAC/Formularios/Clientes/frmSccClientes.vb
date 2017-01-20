Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports C1.C1Excel

Public Class frmSccClientes
#Region "Declaración de Variables propias del formulario"
    Dim dtCliente, dtFiador As DataTable
    Dim objSeg As SsgSeguridad
    Dim bolEditar, bolConsultar, bolEliminar, bolImprimir As Boolean
#End Region

#Region "Cargar Grid Clietnes"
    Private Sub CargarGridClientes()

        Try
            Me.dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,Nombre1,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Ruta,OrdenCobro", "vwSccClientes"))
            'Me.dtCliente.PrimaryKey = New DataColumn() {Me.dtCliente.Columns("StbPersonaID")}
            Me.dtCliente.DefaultView.Sort = "StbPersonaID desc"
            Me.grdClientes.DataSource = dtCliente

            If Me.dtCliente.DefaultView.Count = 0 Then
                Me.cmdEditar.Enabled = False
                Me.cmdConsultar.Enabled = False
                Me.cmdInactivar.Enabled = False
                Me.cmdImprimir.Enabled = False
            Else
                If Me.bolEditar Then Me.cmdEditar.Enabled = True
                If Me.bolConsultar Then Me.cmdConsultar.Enabled = True
                If Me.bolEliminar Then Me.cmdInactivar.Enabled = True
                If Me.bolImprimir Then Me.cmdImprimir.Enabled = True
            End If
            
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Seguridad"
    Private Sub Seguridad()
        Try

            objSeg = New SsgSeguridad

            objSeg.ServicioUsuario = "frmStbClientes"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("AgregarCliente") Then
                Me.cmdAgregar.Enabled = False
            End If

            If Not objSeg.TienePermiso("ModificarCliente") Then
                Me.cmdEditar.Enabled = False
                bolEditar = False
            Else
                bolEditar = True
            End If

            If Not objSeg.TienePermiso("ConsultarCliente") Then
                Me.cmdConsultar.Enabled = False
                bolConsultar = False
            Else
                bolConsultar = True
            End If

            If Not objSeg.TienePermiso("DesactivarCliente") Then
                Me.cmdInactivar.Enabled = False
                bolEliminar = False
            Else
                bolEliminar = True
            End If

            If Not objSeg.TienePermiso("ImprimirCliente") Then
                Me.cmdImprimir.Enabled = False
                bolImprimir = False
            Else
                bolImprimir = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Agregar"
    Private Sub Agregar()
        Dim objPersonas As frmClientesEdit
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmClientesEdit
            objPersonas.TyGui = 1
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridClientes()
                Seguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Editar"
    Private Sub Editar()
        Dim objPersonas As frmClientesEdit
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))

            objPersonas = New frmClientesEdit
            objPersonas.TyGui = 2
            objPersonas.idpersona = Me.dtCliente.DefaultView(FilaActual).Item("StbPersonaID")
           
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridClientes()
                Seguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Consultar"
    Private Sub Consultar()
        Dim objPersonas As frmClientesEdit
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            FilaActual = Me.grdClientesTabla.FocusedRowHandle
            objPersonas = New frmClientesEdit
            objPersonas.TyGui = 3
            objPersonas.idpersona = Me.dtCliente.DefaultView(FilaActual).Item("StbPersonaID")
           
            objPersonas.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Eliminar"
    Private Sub Eliminar()
        Dim T As New TransactionManager
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.Cursor = WaitCursor
                    T.BeginTran()
                StbContactos.DeleteByFilter("objPersonaID='" & Me.dtCliente.DefaultView(0).Item("StbPersonaID") & "'")
                StbPersonaClasificacion.DeleteByFilter("objPersonaID='" & Me.dtCliente.DefaultView(0).Item("StbPersonaID") & "'")
                StbPersona.DeleteByFilter("StbPersonaID='" & Me.dtCliente.DefaultView(0).Item("StbPersonaID") & "'")
                    T.CommitTran()
                    MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As SqlClient.SqlException
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Imprimir"
    Private Sub Imprimir()

    End Sub

    Private Sub ImprimirListado(ByVal opcion As Integer)
        Dim dtTemp As DataTable
        Dim libroExcel As New C1.C1Excel.C1XLBook
        Dim hojaExcel As C1.C1Excel.XLSheet
        Dim i As Integer = 0
        Dim fechaReporte As String = Convert.ToString(clsProyecto.Conexion.FechaServidor)
        Dim strFiltro As String = Nothing
        Dim estilo As New C1.C1Excel.XLStyle(libroExcel)
        estilo.BackColor = Color.LightGreen
        Select Case opcion
            Case 1
                strFiltro = "Descripcion = 'Cliente'"
                objUbicacion.DefaultExt = "Reporte de Clientes"
            Case 2
                strFiltro = "Descripcion = 'Fiador'"
                objUbicacion.DefaultExt = "Reporte de Fiadores"
        End Select

        Try
            dtTemp = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Descripcion,Cedula,NombreCompleto,Apellido1,Apellido2,FechaNacimiento,Genero,Ocupacion,Direccion,Email,TelefonoTrabajo,Fax,TelefonoParticular,Celular,Nacionalidad,TipoExportacion,DireccionTrabajo,Apartado,NombreExportacion", "vwPersonaClasificacion", strFiltro))

            hojaExcel = libroExcel.Sheets(0)
            hojaExcel(0, 0).Value = "CONSECUTIVO"
            hojaExcel(0, 0).Style = estilo
            hojaExcel(0, 1).Value = "FECHA REPORTE"
            hojaExcel(0, 1).Style = estilo
            hojaExcel(0, 2).Value = "TIPO SUJETO"
            hojaExcel(0, 2).Style = estilo
            hojaExcel(0, 3).Value = "CEDULA"
            hojaExcel(0, 3).Style = estilo
            hojaExcel(0, 4).Value = "NOMBRE"
            hojaExcel(0, 4).Style = estilo
            hojaExcel(0, 5).Value = "APELLIDO1"
            hojaExcel(0, 5).Style = estilo
            hojaExcel(0, 6).Value = "APELLIDO2"
            hojaExcel(0, 6).Style = estilo
            hojaExcel(0, 7).Value = "FECHA NACIMIENTO"
            hojaExcel(0, 7).Style = estilo
            hojaExcel(0, 8).Value = "SEXO"
            hojaExcel(0, 8).Style = estilo
            hojaExcel(0, 9).Value = "OCUPACION"
            hojaExcel(0, 9).Style = estilo
            hojaExcel(0, 10).Value = "DIRECCION"
            hojaExcel(0, 10).Style = estilo
            hojaExcel(0, 11).Value = "DIR TRABAJO"
            hojaExcel(0, 11).Style = estilo
            hojaExcel(0, 12).Value = "APARTADO"
            hojaExcel(0, 12).Style = estilo
            hojaExcel(0, 13).Value = "CORREO"
            hojaExcel(0, 13).Style = estilo
            hojaExcel(0, 14).Value = "TELEFONO OFICINA"
            hojaExcel(0, 14).Style = estilo
            hojaExcel(0, 15).Value = "FAX"
            hojaExcel(0, 15).Style = estilo
            hojaExcel(0, 16).Value = "TELEFONO CASA"
            hojaExcel(0, 16).Style = estilo
            hojaExcel(0, 17).Value = "TELEFONO CELULAR"
            hojaExcel(0, 17).Style = estilo


            For Each dr As DataRow In dtTemp.Rows
                i = i + 1
                hojaExcel(i, 0).Value = i
                hojaExcel(i, 1).Value = fechaReporte
                If dr("Nacionalidad") = "Extranjero" Then
                    hojaExcel(i, 2).Value = "E"
                Else
                    hojaExcel(i, 2).Value = dr("TipoExportacion")
                End If
                hojaExcel(i, 3).Value = dr("Cedula")
                hojaExcel(i, 4).Value = dr("NombreExportacion")
                hojaExcel(i, 5).Value = dr("Apellido1")
                hojaExcel(i, 6).Value = dr("Apellido2")
                hojaExcel(i, 7).Value = dr("FechaNacimiento")
                If IsDBNull(dr("Genero")) Then
                    hojaExcel(i, 8).Value = "-"
                Else
                    If dr("Genero") = "Masculino" Then
                        hojaExcel(i, 8).Value = "M"
                    Else
                        hojaExcel(i, 8).Value = "F"
                    End If
                End If
                hojaExcel(i, 9).Value = dr("Ocupacion")
                hojaExcel(i, 10).Value = dr("Direccion")
                hojaExcel(i, 11).Value = dr("DireccionTrabajo")
                hojaExcel(i, 12).Value = dr("Apartado")
                hojaExcel(i, 13).Value = dr("Email")
                hojaExcel(i, 14).Value = dr("TelefonoTrabajo")
                hojaExcel(i, 15).Value = dr("Fax")
                hojaExcel(i, 16).Value = dr("TelefonoParticular")
                hojaExcel(i, 17).Value = dr("Celular")
            Next

            If objUbicacion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                libroExcel.Save(objUbicacion.FileName)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Evento LOAD del Form"

    Private Sub frmSccClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor
            Me.Seguridad()
            Me.CargarGridClientes()
          
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.dtCliente = Nothing
        Me.dtFiador = Nothing
        objSeg = Nothing
        bolEditar = Nothing
        bolConsultar = Nothing
        bolEliminar = Nothing
        bolImprimir = Nothing
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Me.CargarGridClientes()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Me.Eliminar()
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Me.Consultar()
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Me.Editar()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Me.Agregar()
    End Sub
End Class