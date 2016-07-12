'Autor: Gelmin Martínez
'Fecha: 11 Junio 2010, 02:21 pm.
'Ventana de criterios para el reporte de Listado de precios

Imports DAL
Imports SCCUM.BO 'Uso de clsConsultas
Imports Proyecto.Configuracion 'uso de clsProyecto
Imports Proyecto.Catalogos.Datos 'uso de clsCatalogos

Public Class frmCriteriosReporteListadoPrecios

#Region "Atributos"
    Private m_IdSucursalSession As Integer
    Private m_IdSucursalCentral As Integer
#End Region

#Region "Propiedades"
    Property IdSucursalSession() As Integer
        Get
            IdSucursalSession = Me.m_IdSucursalSession
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalSession = value
        End Set
    End Property

    Property IdSucursalCentral() As Integer
        Get
            IdSucursalCentral = Me.m_IdSucursalCentral
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalCentral = value
        End Set
    End Property
#End Region

#Region "Eventos de controles"
    Private Sub frmCriteriosReporteListadoPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarComboTienda()

        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C")
        Me.VerificarSucursalRepuesto()
        Me.cmbTiendas.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.rbtTodos.Checked Then
            Me.Imprimir_Reporte("objTiendaID = " + Me.cmbTiendas.SelectedValue.ToString)
        Else
            Me.Imprimir_Reporte("objTiendaID = " + Me.cmbTiendas.SelectedValue.ToString + " AND ExistenciaTotal > 0")
        End If
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
#End Region

#Region "Imprimir reporte"
    Public Sub Imprimir_Reporte(Optional ByVal sFiltro As String = "1=1")
        Dim objReporte As New rptFacturacionListadoPrecios
        Dim sSQL, sCampos As String
        Dim dtDatos As DataTable

        'Obtener datos para la generación del reporte
        sCampos = "SivRepuestoID, Descripcion, Marca, Precio, DescuentoPromocion, TipoRepuesto, objTiendaID, Tienda, ExistenciaTotal"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptFacturacionListadoPrecios", sFiltro + " ORDER BY Descripcion")
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        'Si hay resultados mostrar opciones para mostrar informe
        If dtDatos.Rows.Count <> 0 Then
            objReporte.DataSource = dtDatos
            Me.OpcionesImpresion(objReporte)
        Else
            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        End If
    End Sub
#End Region

#Region "Opciones de Impresión"
    Private Sub OpcionesImpresion(ByRef Reporte As DataDynamics.ActiveReports.ActiveReport3)
        Dim objImpresion As New frmOpcionesImpresion

        If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(Reporte)
                Case 2
                    clsProyecto.ImprimirEnImpresora(Reporte, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(Reporte, Me)
            End Select
        End If
    End Sub
#End Region

#Region "Cargar combo"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Tienda
    ''' Autor : Gelmin Martinez
    ''' Fecha 11 de Junio de 2010, 03:05 pm.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboTienda()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("Activo=1 AND ActivoRepuesto=1", "Nombre", "StbTiendaID, Codigo, Nombre")
            With Me.cmbTiendas
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 40
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Verificar Sucursal Repuesto"
    Private Sub VerificarSucursalRepuesto()
        If String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            MsgBox("No ha configurado la sucursal en el utilitario de configuración del sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            If Me.cmbTiendas.FindStringExact(Me.IdSucursalSession.ToString, 0, 0) = -1 Then
                MsgBox("La sucursal configurada en la sesión del sistema, no es una sucursal de Repuestos", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.cmbTiendas.SelectedValue = Me.IdSucursalSession
            End If
        End If
    End Sub
#End Region

End Class