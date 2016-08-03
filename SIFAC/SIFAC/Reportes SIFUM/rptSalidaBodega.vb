'-- Autor: Milagros Ruiz Oporta
'-- Fecha: Miercoles 16 Junio 2010
'-- Reporte para mostrar la hoja de Salida

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion
Imports DAL
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class rptSalidaBodega 

#Region "Atributos"
    Private objEncabezado As rptEncabezadoReportesSIFUM
    Private m_UsuarioCreacion As String
    Private m_UsuarioAutorizacion As String
#End Region

#Region "Propiedades"
    Public Property UsuarioCreacion() As String
        Get
            UsuarioCreacion = Me.m_UsuarioCreacion
        End Get
        Set(ByVal value As String)
            Me.m_UsuarioCreacion = value
        End Set
    End Property

    Public Property UsuarioAutorizacion() As String
        Get
            UsuarioAutorizacion = Me.m_UsuarioAutorizacion
        End Get
        Set(ByVal value As String)
            Me.m_UsuarioAutorizacion = value
        End Set
    End Property

#End Region

#Region "Cargar Encabezado"
    Private Sub CargarEncabezado()
        Try
            objEncabezado = New rptEncabezadoReportesSIFUM
            Me.srpEncabezado.Report = objEncabezado

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Usuario"
    Private Sub CargarUsuario()
        Dim dtUsuario As New DataTable
        Dim sSQL As String
        Dim strUsuarioCrea As String = String.Empty
        Dim strUsuarioAutoriza As String = String.Empty

        Try
            'Obteniendo el usuario que crea la salida
            If Not String.IsNullOrEmpty(Me.UsuarioCreacion) Then
                sSQL = clsConsultas.ObtenerConsultaGeneral("NombreEmpleado", "vwUsuarioEmpleado", "Login ='" & Me.UsuarioCreacion & "'")
                dtUsuario = DAL.SqlHelper.ExecuteQueryDT(sSQL)
                If dtUsuario.Rows.Count <> 0 Then
                    strUsuarioCrea = dtUsuario.DefaultView.Item(0)("NombreEmpleado").ToString
                End If
            End If

            'Obteniendo el usuario que autoriza la salida.
            If Not String.IsNullOrEmpty(Me.UsuarioAutorizacion) Then
                sSQL = clsConsultas.ObtenerConsultaGeneral("NombreEmpleado", "vwUsuarioEmpleado", "Login ='" & Me.UsuarioAutorizacion & "'")
                dtUsuario = DAL.SqlHelper.ExecuteQueryDT(sSQL)
                If dtUsuario.Rows.Count <> 0 Then
                    strUsuarioAutoriza = dtUsuario.DefaultView.Item(0)("NombreEmpleado").ToString
                End If
            End If

            If (dtUsuario.Rows.Count <> 0) Then
                Me.txtUsuario.Text = strUsuarioCrea
                Me.txtUsuario1.Text = strUsuarioAutoriza
            Else
                Me.txtUsuario1.Visible = False
                Me.txtUsuario.Visible = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region

    Private Sub rptSalidaBodega_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        clsProyecto.MargenesRpt(Me)
        Me.CargarEncabezado()
        Me.CargarUsuario()
    End Sub
 
End Class
