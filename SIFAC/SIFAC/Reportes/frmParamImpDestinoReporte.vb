''-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
''-- Fecha de Elaboración    : 07 de Diciembre del 2007.
''-------------------------------------------------------------------------------------------------
''--    Formulario Previo Impresión de Reportes
''-------------------------------------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms

Public Class frmParamImpDestinoReporte

#Region "Declaracion de Variables y Objetos Locales"

    Private m_dtRpt As New DataTable
    Private m_rptNombre As String
    Private m_ReciboColectorID As Integer
    Private m_ReciboCajaID As Integer
    Private M_DevolucionProdNoVencidoID As Integer
    Private m_OrdenDespachoID As Integer
    Private m_ComprobantePagoID As Integer
    Private m_InventarioFisicoID As Integer
    Private m_MMDonID As Integer

#End Region

#Region "Propiedades"

    Public Property dtRpt() As DataTable
        Get
            Return m_dtRpt
        End Get
        Set(ByVal value As DataTable)
            m_dtRpt = value
        End Set
    End Property

    Public Property rptNombre() As String
        Get
            Return m_rptNombre
        End Get
        Set(ByVal value As String)
            m_rptNombre = value
        End Set
    End Property

    Public Property ReciboColectorID() As Integer
        Get
            Return m_ReciboColectorID
        End Get
        Set(ByVal value As Integer)
            m_ReciboColectorID = value
        End Set
    End Property

    Public Property ReciboCajaID() As Integer
        Get
            Return m_ReciboCajaID
        End Get
        Set(ByVal value As Integer)
            m_ReciboCajaID = value
        End Set
    End Property

    Public Property DevolucionProdNoVencidoID() As Integer
        Get
            Return M_DevolucionProdNoVencidoID
        End Get
        Set(ByVal value As Integer)
            M_DevolucionProdNoVencidoID = value
        End Set
    End Property

    Public Property OrdenDespachoID() As Integer
        Get
            Return m_OrdenDespachoID
        End Get
        Set(ByVal value As Integer)
            m_OrdenDespachoID = value
        End Set
    End Property

    Public Property ComprobantePagoID() As Integer
        Get
            Return m_ComprobantePagoID
        End Get
        Set(ByVal value As Integer)
            m_ComprobantePagoID = value
        End Set
    End Property

    Public Property InventarioFisicoID() As Integer
        Get
            Return m_InventarioFisicoID
        End Get
        Set(ByVal value As Integer)
            m_InventarioFisicoID = value
        End Set
    End Property

    Public Property MMedDonID() As Integer
        Get
            Return m_MMDonID
        End Get
        Set(ByVal value As Integer)
            m_MMDonID = value
        End Set
    End Property

#End Region

#Region "Eventos del Formulario"

    '------------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   07 de Diciembre del 2007
    '-- Descripcion         :   Cargar el Formulario de Destino de Impresion de Reportes
    '-------------------------------------------------------------------------------------
    Private Sub frmParamImpDestinoReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            clsProyecto.CargarTemaDefinido(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Evento Boton Aceptar - Cancelar"

    '-----------------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   07 de Diciembre del 2007
    '-- Descripcion         :   Verificar el destino de la Impresion del Reporte: impresora,
    '--                     :   archivo o pantalla.
    '-----------------------------------------------------------------------------------------
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Select Case Me.rptNombre
                '    Case "rptSccNotaCredito"
                '        Dim objrpt As rptSccNotaCredito
                '        objrpt = New rptSccNotaCredito
                '        Me.DestinoReporte(objrpt)

                '    Case "rptSccNotaDebito"
                '        Dim objrpt As rptSccNotaDebito
                '        objrpt = New rptSccNotaDebito
                '        Me.DestinoReporte(objrpt)

                '    Case "rptSccReciboColector"
                '        Dim objrpt As rptSccReciboColector
                '        objrpt = New rptSccReciboColector
                '        objrpt.RCOLID = Me.ReciboColectorID
                '        Me.DestinoReporte(objrpt)

                '    Case "rptSccReciboCaja"
                '        Dim objrpt As rptSccReciboCaja
                '        objrpt = New rptSccReciboCaja
                '        objrpt.TipoSccReciboID = Me.ReciboCajaID
                '        Me.DestinoReporte(objrpt)

                '    Case "rptSccDevolucion"
                '        Dim objrpt As rptSccDevolucion
                '        objrpt = New rptSccDevolucion
                '        objrpt.TipoSccDevolucionID = Me.DevolucionProdNoVencidoID
                '        Me.DestinoReporte(objrpt)

                '    Case "rptSivMuestraMedica"
                '        Dim objrpt As rptSivImprimirOrdenDespacho
                '        objrpt = New rptSivImprimirOrdenDespacho
                '        objrpt.TipoSolicitud = "MuestraMedica"
                '        objrpt.OrdenDespachoID = Me.OrdenDespachoID
                '        Me.DestinoReporte(objrpt)

                '    Case "rptSivDonacion"
                '        Dim objrpt As rptSivImprimirOrdenDespacho
                '        objrpt = New rptSivImprimirOrdenDespacho
                '        objrpt.TipoSolicitud = "Donacion"
                '        objrpt.OrdenDespachoID = Me.OrdenDespachoID
                '        Me.DestinoReporte(objrpt)

                '    Case "rptSivDevolucion"
                '        Dim objrpt As rptSivImprimirOrdenDespacho
                '        objrpt = New rptSivImprimirOrdenDespacho
                '        objrpt.TipoSolicitud = "Devolucion"
                '        objrpt.OrdenDespachoID = Me.OrdenDespachoID
                '        Me.DestinoReporte(objrpt)

                Case "rptStbTasaCambioOficial"
                    Dim objrpt As rptStbTasaCambioOficial
                    objrpt = New rptStbTasaCambioOficial
                    Me.DestinoReporte(objrpt)

                    '    Case "rptSteComprobantePago"
                    '        Dim objrpt As rptSteComprobantePago
                    '        objrpt = New rptSteComprobantePago
                    '        objrpt.ComprobantePagoID = Me.ComprobantePagoID
                    '        Me.DestinoReporte(objrpt)

                    '    Case "rptSivInventarioFisicoComprobacion"
                    '        Dim objrpt As rptSivInventarioFisicoComprobacion
                    '        objrpt = New rptSivInventarioFisicoComprobacion
                    '        objrpt.TipoInventarioID = Me.InventarioFisicoID
                    '        Me.DestinoReporte(objrpt)

                    '    Case "rptSfaCotizacion"
                    '        Dim objrpt As rptSfaCotizacion
                    '        objrpt = New rptSfaCotizacion
                    '        Me.DestinoReporte(objrpt)

                    '    Case "rptSivComprobanteMM"
                    '        Dim objrpt As rptSivComprobanteSalida_MM_Donacion
                    '        objrpt = New rptSivComprobanteSalida_MM_Donacion
                    '        objrpt.TipoComprbante = rptSivComprobanteSalida_MM_Donacion.Comprobantes.MuestraMedica
                    '        objrpt.ComprabanteId = Me.MMedDonID
                    '        Me.DestinoReporte(objrpt)

                    '    Case "rptSivComprobanteDon"
                    '        Dim objrpt As rptSivComprobanteSalida_MM_Donacion
                    '        objrpt = New rptSivComprobanteSalida_MM_Donacion
                    '        objrpt.TipoComprbante = rptSivComprobanteSalida_MM_Donacion.Comprobantes.Donación
                    '        objrpt.ComprabanteId = Me.MMedDonID
                    '        Me.DestinoReporte(objrpt)
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DestinoReporte(ByRef objrpt As DataDynamics.ActiveReports.ActiveReport3)
        Try
            If Not Me.dtRpt Is Nothing Then
                objrpt.DataSource = Me.dtRpt
            End If

            If Me.rbtArchivo.Checked Then
                Proyecto.Configuracion.clsProyecto.ImprimirEnArchivo(objrpt, Me)
            End If
            If Me.rbtImpresora.Checked Then
                Proyecto.Configuracion.clsProyecto.ImprimirEnImpresora(objrpt)
            End If
            If Me.rbtPantalla.Checked Then
                Proyecto.Configuracion.clsProyecto.ImprimirEnPantalla(objrpt)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   07 de Diciembre del 2007
    '-- Descripcion         :   Cerrar el Formulario
    '-----------------------------------------------------------------------------------------
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region

End Class