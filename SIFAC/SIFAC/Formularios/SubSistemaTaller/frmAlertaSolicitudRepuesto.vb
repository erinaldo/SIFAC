'Autor: Gelmin Martínez
'Fecha: 14 Agosto 2010, 09:56 am.
'Ventana de alerta para solicitudes de repuestos

Imports DAL
Imports SCCUM.BO 'Uso de clsConsultas
Imports Proyecto.Configuracion 'uso de clsProyecto
Imports Proyecto.Catalogos.Datos 'uso de clsCatalogos

Public Class frmAlertaSolicitudRepuesto

#Region "Atributos"
    Private dtDatos As DataTable
    Private m_IdSalidaSeleccionado As Integer
#End Region

#Region "Propiedades"
    Property IdSalidaSeleccionado() As Integer
        Get
            IdSalidaSeleccionado = Me.m_IdSalidaSeleccionado
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSalidaSeleccionado = value
        End Set
    End Property

#End Region

#Region "Cargar Grid"
    Private Sub CargarGrid()
        Dim strCampos, strSQL, strFiltro As String

        strCampos = " DISTINCT CAST(0 AS BIT) AS Seleccionar, SivSalidaBodegaID, NumeroSalida, CONVERT(VARCHAR, FechaSalida,103) AS FechaSalida, Cliente, objSccCuentaID, objSccCuentaTiendaID, costototal, PrecioTotal, GarantiaAldia"
        strFiltro = " 1=1 "

        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwStaServicioTallerAlertaSolicitudRepuesto", strFiltro + " ORDER BY FechaSalida DESC")
        Me.dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

        Me.grdSolicitudes.SetDataBinding(Me.dtDatos, "", True)
        Me.FormatearGrid()

        If Me.dtDatos.Rows.Count <= 0 Then
            Me.cmdAutorizar.Enabled = False
            Me.cmdConsultar.Enabled = False
            Me.cmdAnular.Enabled = False
        End If
    End Sub

    Private Sub FormatearGrid()
        With Me.grdSolicitudes
            .AllowDelete = False
            '.AllowUpdate = False 'permitir editar por la selección
            .Splits(0).DisplayColumns("SivSalidaBodegaID").Visible = False
        End With
    End Sub
#End Region

#Region "Cargar formulario"
    Private Sub frmAlertaSolicitudDescuento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarGrid()
    End Sub
#End Region

#Region "Eventos de controles"
    Private Sub grdSolicitudes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdSolicitudes.DoubleClick
        If Me.dtDatos.Rows.Count > 0 Then
            If Not IsDBNull(Me.grdSolicitudes.Columns("SivSalidaBodegaID").Value) AndAlso Me.grdSolicitudes.Columns("SivSalidaBodegaID").Value.ToString.Trim.Length <> 0 Then
                Me.OperacionSalida(Me.ObtenerIdSalidaSeleccionado(), 3)
            End If
        End If
    End Sub

    Private Sub cmdAutorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorizar.Click
        If Me.dtDatos.Rows.Count > 0 Then
            Me.OperacionSalida(Me.ObtenerIdSalidaSeleccionado(), 1) '1= Autorizar salida
        End If
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If Me.dtDatos.Rows.Count > 0 Then
            Me.OperacionSalida(Me.ObtenerIdSalidaSeleccionado(), 2) '=Anular Salida
        End If
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        If Me.dtDatos.Rows.Count > 0 Then
            Me.OperacionSalida(Me.ObtenerIdSalidaSeleccionado(), 3) '3=Consultar salida
        End If
    End Sub

    Private Sub grdSolicitudes_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdSolicitudes.AfterColUpdate
        Try
            If e.Column.Name = "Seleccionar" Then
                If dtDatos.Compute("COUNT(Seleccionar)", "Seleccionar=1") > 0 Then
                    Me.dtDatos.Rows(Me.grdSolicitudes.RowBookmark(Me.grdSolicitudes.Row))("Seleccionar") = False
                End If
            End If
        Finally
        End Try
    End Sub

    Private Sub frmAlertaSolicitudRepuesto_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        frmPrincipal.glbVentanaSolicRepuestoAbierta = True
    End Sub

    Private Sub frmAlertaSolicitudRepuesto_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Deshabilitar variable que verifica si la ventana de solicitud de repuestos está abierta o no.
        frmPrincipal.glbVentanaSolicRepuestoAbierta = False
    End Sub

    Private Sub frmAlertaSolicitudRepuesto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Me.CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Operación Salida"
    Private Sub OperacionSalida(ByVal SivSalidaBodegaID As Integer, ByVal intOpcion As Integer)
        Dim frmSalida As New frmSivAgregarSalida
        Try
            Try
                If SivSalidaBodegaID <> 0 Then
                    frmSalida.TypeGui = intOpcion
                    frmSalida.SalidaID = SivSalidaBodegaID
                    If frmSalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.CargarGrid()
                    End If
                Else
                    MsgBox("No ha seleccionado un registro de salida.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            frmSalida = Nothing
        End Try
    End Sub
#End Region

#Region "Obtener IdSalida Seleccionado"
    Private Function ObtenerIdSalidaSeleccionado() As Integer
        Dim objSalidaID As New Object
        Dim Cantidad As New Object

        Cantidad = Me.dtDatos.Compute("Count(Seleccionar)", "Seleccionar=1")
        If Cantidad = 0 Then
            Exit Function
        End If
        objSalidaID = Me.dtDatos.Select("Seleccionar = 1")(0)("SivSalidaBodegaID")
        If Not IsDBNull(objSalidaID) AndAlso objSalidaID <> Nothing Then
            Return objSalidaID
        Else
            Return 0
        End If
    End Function
#End Region

End Class