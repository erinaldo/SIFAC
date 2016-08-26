'Autor: Gelmin Martínez
'Fecha: 07 Julio 2010, 03:42 pm.
'Ventana de alerta para solicitudes de descuentos

Imports DAL
Imports SIFAC.BO 'Uso de clsConsultas
Imports Proyecto.Configuracion 'uso de clsProyecto
Imports Proyecto.Catalogos.Datos 'uso de clsCatalogos

Public Class frmAlertaSolicitudDescuento

    Private dtDatos As DataTable

#Region "Cargar Grid"
    Private Sub CargarGrid()
        Dim strCampos, strSQL, strFiltro As String

        strCampos = "SfaFacturaRepuestoID, Convert(varchar,Fecha,103) as Fecha, OrdenCompra,objTiendaID, Sucursal, objClienteID, Cliente, objVendedorID, Vendedor, TotalDolares, SolicitudDescuento, SolicAutorDescuento, AutorizaDescuento, FacturaMoto"
        strFiltro = "SolicAutorDescuento=1 AND AutorizaDescuento=0 AND FacturaMoto=0"

        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwAlertaSolicitudesDescuento", strFiltro + " ORDER BY Fecha DESC")
        Me.dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

        Me.grdSolicitudes.SetDataBinding(Me.dtDatos, "", True)
        Me.FormatearGrid()
    End Sub

    Private Sub FormatearGrid()
        With Me.grdSolicitudes
            .AllowDelete = False
            .AllowUpdate = False
            .Splits(0).DisplayColumns("SfaFacturaRepuestoID").Visible = False
            .Splits(0).DisplayColumns("OrdenCompra").Visible = False
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
            If Not IsDBNull(Me.grdSolicitudes.Columns("SfaFacturaRepuestoID").Value) AndAlso Me.grdSolicitudes.Columns("SfaFacturaRepuestoID").Value.ToString.Trim.Length <> 0 Then
                'Me.MostrarFactura(Me.grdSolicitudes.Columns("SfaFacturaRepuestoID").Value)
            End If
        End If
    End Sub

    Private Sub frmAlertaSolicitudDescuento_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        frmPrincipal.glbVentanaSolicDescuentoAbierta = True
    End Sub

    Private Sub frmAlertaSolicitudDescuento_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Deshabilitar variable global que verifica si la ventana de solicitud ya está abierta o no
        frmPrincipal.glbVentanaSolicDescuentoAbierta = False
    End Sub

    Private Sub frmAlertaSolicitudDescuento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Me.CargarGrid()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
#End Region

#Region "Mostrar Factura"
    'Private Sub MostrarFactura(ByVal sfaFacturaRepuestoID As Integer)
    '    Dim frmFactura As New frmSfaFacturaRepuestosEditar
    '    Dim frmOrden As New FrmSfaOrdenCompraEdit
    '    Try
    '        Try
    '            If (Me.grdSolicitudes.Columns("OrdenCompra").Value = 0) Then
    '                frmFactura.TypeGUI = 3
    '                frmFactura.SfaFacturaID = sfaFacturaRepuestoID
    '                If frmFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '                    Me.CargarGrid()
    '                End If
    '            Else
    '                frmOrden.TypeGUI = 3
    '                frmOrden.SfaFacturaID = sfaFacturaRepuestoID
    '                If frmOrden.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '                    Me.CargarGrid()
    '                End If
    '            End If

    '        Catch ex As Exception
    '            clsError.CaptarError(ex)
    '        End Try
    '    Finally
    '        frmFactura = Nothing
    '    End Try
    'End Sub
#End Region

End Class