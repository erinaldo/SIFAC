Imports Proyecto.Catalogos.Datos
Imports Proyecto.Configuracion
Imports DAL

Public Class frmAlertaSolicitudDescuentoSucursal

#Region "Atributos"
    Private m_dtDatos As DataTable
    Private m_strSQL As String
    Private IdSucursalSession As Integer
    Private IdSucursalCentral As Integer
#End Region

#Region "Propiedades"

    Property dtDatos() As DataTable
        Get
            dtDatos = Me.m_dtDatos
        End Get
        Set(ByVal value As DataTable)
            Me.m_dtDatos = value
        End Set
    End Property

    Property strSQL() As String
        Get
            strSQL = Me.m_strSQL
        End Get
        Set(ByVal value As String)
            Me.m_strSQL = value
        End Set
    End Property
#End Region

#Region "Eventos de controles"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Close()
    End Sub

    Private Sub frmAlertaSolicitudDescuentoSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C")
        IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.CargarGrid()
    End Sub

    Private Sub grdDatos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDatos.DoubleClick
        If Me.dtDatos.Rows.Count > 0 Then
            If Not IsDBNull(Me.grdDatos.Columns("SfaFacturaRepuestoID").Value) AndAlso Me.grdDatos.Columns("SfaFacturaRepuestoID").Value.ToString.Trim.Length <> 0 Then
                'Me.MostrarFactura(Me.grdDatos.Columns("SfaFacturaRepuestoID").Value)
            End If
        End If
    End Sub
#End Region

#Region "Cargar Grid"
    Private Sub CargarGrid()
        Me.grdDatos.Splits(0).DisplayColumns("SfaFacturaRepuestoID").Visible = False
        Me.grdDatos.Splits(0).DisplayColumns("EsOrdenCompra").Visible = False
        Try
            If Not String.IsNullOrEmpty(Me.strSQL) Then
                Me.dtDatos = SqlHelper.ExecuteQueryDT(Me.strSQL)
                If Me.dtDatos.Rows.Count > 0 Then
                    Me.grdDatos.SetDataBinding(Me.dtDatos, "", True)

                    If IdSucursalCentral = IdSucursalSession Then
                        Me.grdDatos.Splits(0).DisplayColumns("NumeroFactura").Visible = False
                    Else
                        Me.grdDatos.Splits(0).DisplayColumns("OrdenCompra").Visible = False
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Mostrar Factura"
    'Private Sub MostrarFactura(ByVal sfaFacturaRepuestoID As Integer)
    '    Dim frmFactura As New frmSfaFacturaRepuestosEditar
    '    Dim frmOrden As New FrmSfaOrdenCompraEdit
    '    Dim blnEsOrdenCompra As Boolean
    '    Try
    '        Try
    '            If Not IsDBNull(Me.grdDatos.Columns("EsOrdenCompra").Value) Then
    '                Try
    '                    blnEsOrdenCompra = Me.grdDatos.Columns("EsOrdenCompra").Value
    '                Catch ex As Exception
    '                    blnEsOrdenCompra = False
    '                End Try

    '                If blnEsOrdenCompra Then
    '                    frmOrden.TypeGUI = 2 '2= Procesar Orden compra
    '                    frmOrden.SfaFacturaID = sfaFacturaRepuestoID
    '                    If frmOrden.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '                        Me.CargarGrid()
    '                    End If
    '                Else
    '                    frmFactura.TypeGUI = 2 '2= Procesar Factura
    '                    frmFactura.SfaFacturaID = sfaFacturaRepuestoID
    '                    If frmFactura.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '                        Me.CargarGrid()
    '                    End If
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