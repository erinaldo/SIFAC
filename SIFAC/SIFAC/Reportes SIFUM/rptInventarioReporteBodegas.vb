'-- Autor: Gelmin Martínez
'-- Fecha: 11 Junio 2010,04:51 pm. 
'-- Reporte de Inventario

Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports Proyecto.Configuracion 'uso de clsProyecto, clsError

Public Class rptInventarioReporteBodegas

#Region "Atributos"
    Private objEncabezado As rptEncabezadoReportesSIFUM
    Private m_VerCostoU As Boolean
    Private m_VerPrecioU As Boolean
    Private m_VerTotales As Boolean
    Public dtDatos As DataTable
#End Region

#Region "Propiedades"
    Property VerCostoU() As Boolean
        Get
            VerCostoU = Me.m_VerCostoU
        End Get
        Set(ByVal value As Boolean)
            Me.m_VerCostoU = value
        End Set
    End Property

    Property VerPrecioU() As Boolean
        Get
            VerPrecioU = Me.m_VerPrecioU
        End Get
        Set(ByVal value As Boolean)
            Me.m_VerPrecioU = value
        End Set
    End Property

    Property VerTotales() As Boolean
        Get
            VerTotales = Me.m_VerTotales
        End Get
        Set(ByVal value As Boolean)
            Me.m_VerTotales = value
        End Set
    End Property

#End Region

#Region "Constantes"
    Private Const ANCHO_DESC = 2.13
    Private Const ANCHO_MARCA = 0.75
    Private Const ANCHO_UBICACION = 0.75
    Private Const ANCHO_EXISTENCIA = 0.7
    Private Const ANCHO_COSTOU = 0.7
    Private Const ANCHO_TOTALCOSTO = 0.7
    Private Const ANCHO_PRECIOU = 0.7
    Private Const ANCHO_TOTALPRECIOU = 0.7
    Private Const ALTO_ENCABEZADO_DETALLE = 0.25
    Private Const DESPLAZAMIENTO = 0.2

#End Region

#Region "Iniciar Reporte"
    Private Sub rptInventarioReporteBodegas_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.CargarEncabezado()
        Me.ConfigurarReporte()
    End Sub
#End Region

#Region "Cargar encabezado"
    Private Sub CargarEncabezado()
        Try
            objEncabezado = New rptEncabezadoReportesSIFUM
            Me.srptEncabezado.Report = objEncabezado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Configurar columnas de costo, precio y totales"
    Private Sub ConfigColumnasCostoPrecio()
        Me.MostrarTotales(Me.VerTotales)

        'Si no se verán los totales
        If (Not Me.VerTotales) Then
            'clsProyecto.MargenesRpt(Me)
            Me.PageSettings.Margins.Left = 0.8
        End If

        'Si solo se mostrará uno de las columnas de precio o costo entonces usar margenes standard.
        If ((Me.VerCostoU) And (Not Me.VerPrecioU)) Or ((Me.VerPrecioU) And (Not Me.VerCostoU)) Then
            clsProyecto.MargenesRpt(Me)
        End If

        If (Me.VerCostoU And Me.VerPrecioU) Then
            Me.PageSettings.Margins.Top = 0.4
            Me.PageSettings.Margins.Bottom = 1
            Me.PageSettings.Margins.Left = 0.2
            Me.PageSettings.Margins.Right = 0.2
        End If

    End Sub

    Private Sub MostrarTotales(ByVal blnMostrar As Boolean)
        'No mostrar toda la banda de pie de grupo bodegas
        If Not blnMostrar Then
            Me.Pie_GrupoBodegas.Height = 0.2
            Me.lblTotalBodegas.Visible = blnMostrar
        End If

        Me.txtTotalPrecioBodegas.Visible = Me.VerPrecioU
        Me.txtTotalCostoBodegas.Visible = Me.VerCostoU        

        'No mostrar controles de GrantTotal al pie del informe
        Me.lblGranTotal.Visible = blnMostrar
        Me.txtGranTotalCosto.Visible = Me.VerCostoU
        Me.txtGranTotalPrecio.Visible = Me.VerPrecioU

        'Enmarcar totales
        If blnMostrar Then
            clsReportes.Enmarcar(Me.txtTotalCostoBodegas, Color.Silver)
            clsReportes.Enmarcar(Me.txtGranTotalCosto, Color.Silver)
            clsReportes.Enmarcar(Me.txtTotalPrecioBodegas, Color.Silver)
            clsReportes.Enmarcar(Me.txtGranTotalPrecio, Color.Silver)
        End If
    End Sub

#End Region

#Region "Crear Etiquetas de encabezado de detalle"
    Private Sub CrearEtiquetasEncabezadoDetalle()
        Dim objPunto As New PointF
        Dim objFuente As Font
        Dim Ancho As Single
        Dim Alto As Single

        objPunto = New System.Drawing.PointF
        objPunto.X = Me.lblCodigo.Location.X + Me.lblCodigo.Width  'lblCodigo es la etiqueta de arranque
        objPunto.Y = Me.lblCodigo.Location.Y
        objFuente = New System.Drawing.Font("Arial", 8.0, FontStyle.Bold, GraphicsUnit.Point)
        Ancho = Me.lblCodigo.Width
        Alto = ALTO_ENCABEZADO_DETALLE

        clsReportes.Enmarcar(Me.lblCodigo)
        'Crear etiquetas del encabezado de detalle
        If (Not Me.VerTotales) Then
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Descripción", objFuente, objPunto, ANCHO_DESC + DESPLAZAMIENTO + 0.3, Alto)
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Marca", objFuente, objPunto, ANCHO_MARCA + DESPLAZAMIENTO, Alto)
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Ubicación", objFuente, objPunto, ANCHO_UBICACION + DESPLAZAMIENTO, Alto)
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Existencia", objFuente, objPunto, ANCHO_EXISTENCIA + DESPLAZAMIENTO, Alto)
        Else
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Descripción", objFuente, objPunto, ANCHO_DESC, Alto)
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Marca", objFuente, objPunto, ANCHO_MARCA, Alto)
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Ubicación", objFuente, objPunto, ANCHO_UBICACION, Alto)
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Existencia", objFuente, objPunto, ANCHO_EXISTENCIA, Alto)
        End If

        If Me.VerCostoU Then
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Costo U", objFuente, objPunto, ANCHO_COSTOU, Alto)
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Total Costo", objFuente, objPunto, ANCHO_TOTALCOSTO, Alto)
        End If
        If Me.VerPrecioU Then
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Precio U", objFuente, objPunto, ANCHO_PRECIOU, Alto)
            Me.CrearEtiquetas(Me.Encabezado_GrupoBodegas, "Total Precio", objFuente, objPunto, ANCHO_TOTALPRECIOU, Alto)
        End If
    End Sub

#End Region

#Region "Desplazar controles horizontalmente"
    Private Sub DesplazarControlesHorizontalmente(ByVal sglValor As Single)
        Me.txtNombreBodega.Location = New PointF(sglValor, Me.txtNombreBodega.Location.Y)

        'Mover etiquetas de encabezado de detalle
        For Each etiqueta As ARControl In Me.Encabezado_GrupoBodegas.Controls
            etiqueta.Location = New PointF(etiqueta.Location.X + sglValor, etiqueta.Location.Y)
        Next

        'Mover textbox de detalle
        For Each textbox As ARControl In Me.Detalle.Controls
            textbox.Location = New PointF(textbox.Location.X + sglValor, textbox.Location.Y)
        Next
    End Sub

#End Region

#Region "Crear Etiqueta"
    ''' <summary>
    ''' Procedimiento que crea una etiqueta formateada para encabezado de columnas 
    ''' Autor : Gelmin Martinez
    ''' Fecha 14 de Junio de 2010, 02:41 pm.
    ''' <param name="rptSeccion">Sección del reporte en la que se creará la etiqueta</param>
    ''' <param name="Titulo">Título o captión</param>
    ''' <param name="objFuente">Tipo de fuente de letra</param>
    ''' <param name="objPunto">Punto del reporte donde se dibujará</param>
    ''' </summary>
    Private Sub CrearEtiquetas(ByRef rptSeccion As DataDynamics.ActiveReports.Section, ByRef Titulo As String, ByRef objFuente As System.Drawing.Font, ByRef objPunto As System.Drawing.PointF, ByVal Ancho As Single, ByRef Alto As Single)
        Dim objEtiqueta As DataDynamics.ActiveReports.Label
        Try
            objEtiqueta = New DataDynamics.ActiveReports.Label
            With objEtiqueta
                .Text = Titulo
                .Font = objFuente
                .Location = objPunto
                .Alignment = TextAlignment.Center
                .VerticalAlignment = VerticalTextAlignment.Middle
                .Width = Ancho
                .Height = Alto
                .BackColor = Color.Gainsboro
            End With
            clsReportes.Enmarcar(objEtiqueta)
            rptSeccion.Controls.Add(objEtiqueta)
            'Desplazar el punto a la siguiente etiqueta
            objPunto.X = objEtiqueta.Location.X + objEtiqueta.Width
            objPunto.Y = objEtiqueta.Location.Y

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Crear textbox de detalle"
    ''' <summary>
    ''' Procedimiento que crea un textbox para datos de detalle 
    ''' Autor : Gelmin Martinez
    ''' Fecha 14 de Junio de 2010, 02:41 pm.
    ''' <param name="rptSeccion">Sección del reporte en la que se creará el textbox</param>
    ''' </summary>

    Private Sub CrearCamposTextoDetalle(ByRef rptSeccion As DataDynamics.ActiveReports.Section)
        Dim objPunto As PointF
        Dim objFuente As Font
        Dim Ancho As Single
        Dim Alto As Single
        Dim objtext As DataDynamics.ActiveReports.TextBox
        Dim ColumnasDetalle As New ArrayList

        ColumnasDetalle = ColumnasMostrarDetalle()

        objPunto = New System.Drawing.PointF
        objFuente = New System.Drawing.Font("Arial", 10.0, FontStyle.Regular, GraphicsUnit.Point)

        objPunto.X = Me.txtSivRepuestoID.Location.X + Me.txtSivRepuestoID.Width 'txtSivRepuestoID es el textbox de arranque
        objPunto.Y = Me.txtSivRepuestoID.Location.Y

        Ancho = Me.txtSivRepuestoID.Width
        Alto = Me.txtSivRepuestoID.Height

        Try
            ' Crear los textbox para el detalle
            For Each col As DataColumn In ColumnasDetalle
                objtext = New DataDynamics.ActiveReports.TextBox
                'clsReportes.Enmarcar(objtext, Color.Red)
                With objtext
                    .Text = col.Caption
                    .Font = objFuente
                    .Width = Ancho
                    .Location = objPunto
                    .Height = Alto
                    .DataField = col.Caption
                    Select Case (UCase(.Text))
                        Case "DESCRIPCION"
                            If (Not Me.VerTotales) Then
                                .Width = ANCHO_DESC + DESPLAZAMIENTO + 0.3 'Aumentar tamaño de Descripción
                            Else
                                .Width = ANCHO_DESC
                            End If
                        Case "MARCA"
                            If (Not Me.VerTotales) Then
                                .Width = ANCHO_MARCA + DESPLAZAMIENTO 'Aumentar tamaño de Marca
                            Else
                                .Width = ANCHO_MARCA
                            End If
                            .Alignment = TextAlignment.Center
                        Case "UBICACION"
                            If (Not Me.VerTotales) Then
                                .Width = ANCHO_UBICACION + DESPLAZAMIENTO 'Aumentar tamaño de Ubicación
                            Else
                                .Width = ANCHO_UBICACION
                            End If
                            .Alignment = TextAlignment.Center
                        Case "EXISTENCIA"
                            If (Not Me.VerTotales) Then
                                .Width = ANCHO_EXISTENCIA + DESPLAZAMIENTO 'Aumentar tamaño de Existencia
                            Else
                                .Width = ANCHO_EXISTENCIA
                            End If
                            .Alignment = TextAlignment.Right
                        Case "COSTOU", "TOTALCOSTO", "PRECIOU", "TOTALPRECIO"
                            .OutputFormat = "$#,#00.00"
                            .Alignment = TextAlignment.Right
                            .Width = ANCHO_COSTOU
                            'Ubicar controles de totales debajo de totalCosto y TotalPrecio
                            If UCase(.Text) = "TOTALCOSTO" Then
                                Me.txtTotalCostoBodegas.Location = New PointF(objPunto.X - (Me.txtTotalCostoBodegas.Width - ANCHO_COSTOU), objPunto.Y)
                                Me.txtGranTotalCosto.Location = New PointF(objPunto.X - (Me.txtGranTotalCosto.Width - ANCHO_COSTOU), objPunto.Y)
                            End If

                            If UCase(.Text) = "TOTALPRECIO" Then
                                Me.txtTotalPrecioBodegas.Location = New PointF(objPunto.X - (Me.txtTotalPrecioBodegas.Width - ANCHO_PRECIOU), objPunto.Y)
                                Me.txtGranTotalPrecio.Location = New PointF(objPunto.X - (Me.txtGranTotalPrecio.Width - ANCHO_PRECIOU), objPunto.Y)
                            End If
                    End Select
                End With
                rptSeccion.Controls.Add(objtext)
                'Agregar línea de división vertical por cada columna
                Dim linea As DataDynamics.ActiveReports.Line
                linea = Me.CrearLineaDivisionVertical
                rptSeccion.Controls.Add(linea)
                linea.Location = objPunto

                objPunto.X = objtext.Location.X + objtext.Width
                objPunto.Y = objtext.Location.Y

            Next

            'colocar línea de límite a la derecha de detalle
            Me.lnRight.Location = objPunto
            Me.lnPieDetalle.X2 = objPunto.X

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Configurar Reporte"
    Private Sub ConfigurarReporte()
        Me.CrearEtiquetasEncabezadoDetalle()
        Me.ConfigColumnasCostoPrecio()
        Me.CrearCamposTextoDetalle(Me.Detalle)
        Me.DataSource = Me.dtDatos
    End Sub
#End Region

#Region "Columnas Mostrar Detalle"
    ''' <summary>
    ''' Procedimiento encargado de seleccionar solamente aquellas columnas que serán dibujadas en el Detalle
    ''' Autor : Gelmin Martinez
    ''' Fecha 15 de Junio de 2010, 09:16 am.
    ''' <return>Devuelve un arreglo de objetos de tipo DataColumn</return >
    ''' </summary>
    Private Function ColumnasMostrarDetalle() As ArrayList
        Dim cols As New ArrayList
        For Each columna As DataColumn In Me.dtDatos.Columns
            If Not columna.Caption.ToString.Trim = "SivRepuestoID" _
              And Not columna.Caption.ToString.Trim = "NombreBodegaConCodigo" _
                        And Not columna.Caption = "objTiendaID" And Not columna.Caption = "objTipoRepuesto" And Not columna.Caption = "TipoRepuesto" Then

                'Verificar si se verán las columnas de costo y preccio
                If (Not Me.VerCostoU) And (UCase(columna.Caption) = "COSTOU" Or UCase(columna.Caption) = "TOTALCOSTO") Then
                    Continue For
                End If
                If (Not Me.VerPrecioU) And (UCase(columna.Caption) = "PRECIOU" Or UCase(columna.Caption) = "TOTALPRECIO") Then
                    Continue For
                End If
                cols.Add(columna)
            End If
        Next

        Return cols
    End Function
#End Region

#Region "Crear Línea de división vertical"
    Private Function CrearLineaDivisionVertical() As DataDynamics.ActiveReports.Line
        Dim Linea As New DataDynamics.ActiveReports.Line
        With Linea
            .AnchorBottom = Me.lnRight.AnchorBottom
            .LineStyle = Me.lnRight.LineStyle
            .LineWeight = Me.lnRight.LineWeight
            .LineColor = Me.lnRight.LineColor
            .Height = Me.lnRight.Height
            .Width = Me.lnRight.Width
            .X1 = Me.lnRight.X1
            .X2 = Me.lnRight.X2
            .Y1 = Me.lnRight.Y1
            .Y2 = Me.lnRight.Y2
        End With
        Return Linea
    End Function

#End Region

End Class

