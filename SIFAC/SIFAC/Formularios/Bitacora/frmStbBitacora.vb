
Imports DAL
Imports Proyecto.Catalogos.Datos
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Seguridad.Datos

''' <summary>
''' Formulario Principal de Bitacora de Clientes
''' Autor : Pedro Tinoco 
''' Fecha : 31 de Marzo de 2009.
''' </summary>
''' <remarks></remarks>
Public Class frmStbBitacora
    Dim DtDatosBitacora As New DataTable
    Public ObjParametros(6) As SqlClient.SqlParameter
    Private Sub CargarDatos()
        Dim seguimientosRecientes As Integer
        Dim strConsulta As String
        Try
            seguimientosRecientes = StbParametro.RetrieveDT("Nombre = 'DiasSeguimientoReciente'", , "Valor").DefaultView.Item(0)("Valor")
            strConsulta = clsConsultas.ObtenerConsultaGeneral("*", "vwStbBitacoraCliente", " Fecha BETWEEN GETDATE()-" & seguimientosRecientes + 1 & " AND GETDATE()")
            strConsulta = strConsulta + "ORDER BY Fecha ASC"
            DtDatosBitacora = SqlHelper.ExecuteQueryDT(strConsulta)
            DtDatosBitacora.PrimaryKey = New DataColumn() {DtDatosBitacora.Columns("StbBitacoraClienteID")}
            DtDatosBitacora.DefaultView.Sort = "StbBitacoraClienteID"
            Me.grBitacora.SetDataBinding(DtDatosBitacora, "", True)
            Me.grBitacora.Splits(0).DisplayColumns("StbBitacoraClienteID").Visible = False
            Me.grBitacora.Caption = "Bitácoras(" & Me.grBitacora.RowCount.ToString + ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmStbBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarDatos()
        Me.AplicarSeguridad()
        clsProyecto.CargarTemaDefinido(Me)
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        CargarBitacora(0, 0)
    End Sub

    Private Sub CargarBitacora(ByVal Caso As Integer, ByVal IdBitacora As Integer)
        Dim objBitacora As New frmStbBitacoraClienteEdit
        Try
            objBitacora.TypeGui = Caso
            objBitacora.IdBitacora = IdBitacora
            If objBitacora.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarDatos()
                Me.grBitacora.Row = Me.DtDatosBitacora.DefaultView.Find(IdBitacora)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        If Me.grBitacora.RowCount > 0 Then
            Me.CargarBitacora(1, Me.grBitacora.Columns("StbBitacoraClienteID").Value)
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Me.CargarDatos()
    End Sub

    ''' <summary>
    ''' Autor : Pedro Tinoco S.
    ''' Fecha : 13 de Abril.
    ''' Procedimiento Encargado de Aplicar la Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSTBBITACORA"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            Me.cmdAgregar.Enabled = objSeg.TienePermiso("AgregarBitacora")
            Me.cmdConsultar.Enabled = objSeg.TienePermiso("ConsultarBitacora")
            Me.cmdBuscarSeguimiento.Enabled = objSeg.TienePermiso("BUSCARBITACORA")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscarSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarSeguimiento.Click
        Dim objBuscar As frmStbBuscarBitacora
        Try
            objBuscar = New frmStbBuscarBitacora
            If objBuscar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.ObjParametros = objBuscar.Parametros
                Me.CargarDatosFiltro(objBuscar.StrFiltro)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub CargarDatosFiltro(ByVal Filtro As String)
        Dim strConsulta As String
        Try
            strConsulta = clsConsultas.ObtenerConsultaGeneral("*", "vwStbBitacoraCliente", Filtro)
            DtDatosBitacora = SqlHelper.ExecuteQueryDT(strConsulta, Me.ObjParametros)
            If DtDatosBitacora.DefaultView.Count = 0 Then
                MsgBox(My.Resources.MsgBusqueda, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
            DtDatosBitacora.PrimaryKey = New DataColumn() {DtDatosBitacora.Columns("StbBitacoraClienteID")}
            DtDatosBitacora.DefaultView.Sort = "StbBitacoraClienteID"
            Me.grBitacora.SetDataBinding(DtDatosBitacora, "", True)
            Me.grBitacora.Splits(0).DisplayColumns("StbBitacoraClienteID").Visible = False
            Me.grBitacora.Caption = "Bitácoras(" & Me.grBitacora.RowCount.ToString + ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grBitacora_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles grBitacora.FilterChange
        Me.grBitacora.Caption = "Bitácoras(" & Me.grBitacora.RowCount.ToString + ")"
    End Sub
End Class