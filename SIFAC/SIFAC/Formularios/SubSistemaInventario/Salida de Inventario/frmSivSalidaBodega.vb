Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursor
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraReports.UI

Public Class frmSivSalidaBodega

#Region "Variables del formulario"
    Dim dtSalidas, dtDetalleSalidas As DataTable
    Dim objSeg As SsgSeguridad
    Dim dsSalidas As DataSet
    Dim boolAgregar, boolAutorizar, boolAnular, boolConsultar, boolBuscar, boolImprimir As Boolean

    'Variables globales usadas en todas las interfaces de Salida
    Public Shared glb_SucursalSessionID As Integer
    Public Shared glb_SucursalCentralID As Integer
    Public Shared glb_EstadoRegistradaID As Integer
    Public Shared glb_EstadoAutorizadaID As Integer
    Public Shared glb_EstadoAnuladaID As Integer
    Private m_DiasSalidasRecientes As Integer

    Property DiasSalidasRecientes() As Integer
        Get
            DiasSalidasRecientes = Me.m_DiasSalidasRecientes
        End Get
        Set(ByVal value As Integer)
            Me.m_DiasSalidasRecientes = value
        End Set
    End Property
#End Region

#Region "Cargar Datos"

    Private Sub CargarSalidas(ByVal Filtro As String)
        Dim strSQL, strCampos As String
        Try
            Me.DiasSalidasRecientes = ClsCatalogos.GetValorParametro("DiasSalidasRecientes")

            'Si es central mostrar todas las salidas sino mostrar sólo las de la sucursal logueada
            If glb_SucursalCentralID <> glb_SucursalSessionID Then
                If Not String.IsNullOrEmpty(Filtro) Then
                    Filtro += " AND objStbBodegaID = " & glb_SucursalSessionID.ToString
                Else
                    Filtro = " objStbBodegaID = " & glb_SucursalSessionID.ToString
                End If
            End If

            Filtro = Filtro + " AND (DATEDIFF(DAY, FechaSalida, GETDATE()) <= " + Me.DiasSalidasRecientes.ToString + ")"
            strCampos = "Numero, dbo.fnRellenarCeros2(Numero, dbo.FnGetParametro('CantidadDigitosSalida')) as NumeroFormato, Estado, TipoSalida, FechaSalida, objTipoSalidaID, Total, Bodega, objEstadoID,objStbBodegaID"
            strSQL = ObtenerConsultaGeneral(strCampos, "vwSivSalidaBodega", Filtro & " Order by Numero desc")
            dtSalidas = DAL.SqlHelper.ExecuteQueryDT(strSQL)

            strCampos = "Codigo, Producto, Cantidad, costo, subtotal, objSalidaBodegaID, Numero, FechaSalida,objStbBodegaID,objTipoSalidaID"
            strSQL = ObtenerConsultaGeneral(strCampos, "vwSivSalidaDetalle", Filtro & " Order by objSalidaBodegaID desc")

            dtDetalleSalidas = DAL.SqlHelper.ExecuteQueryDT(strSQL)

            dsSalidas = New DataSet

            dsSalidas.Merge(dtSalidas)
            dsSalidas.Tables(0).TableName = "SivSalida"

            dsSalidas.Merge(dtDetalleSalidas)
            dsSalidas.Tables(1).TableName = "SivSalidaDetalle"

            dsSalidas.Relations.Add("SivSalida_SivSalidaDetalle", dsSalidas.Tables(0).Columns("Numero"), dsSalidas.Tables(1).Columns("Numero"))

            Me.grdSalidaMaster.DataSource = dsSalidas
            Me.grdSalidaMaster.DataMember = "SivSalida"

            Me.grdSalidaDetalle.DataSource = dsSalidas
            Me.grdSalidaDetalle.DataMember = "SivSalida.SivSalida_SivSalidaDetalle"

            Me.grdSalidaMaster.Text = "Productos (" & Me.grdSalidaDetalleTable.RowCount & ")"

            If Me.dtSalidas.Rows.Count = 0 Then
                Me.cmdAgregar.Enabled = boolAgregar
                Me.cmdAutorizar.Enabled = False
                Me.cmdConsultar.Enabled = False
                Me.cmdCancelar.Enabled = False
                'Me.cmdBuscar.Enabled = False
                Me.cmdImprimir.Enabled = False
            Else
                Me.cmdAgregar.Enabled = boolAgregar
                'Me.cmdAutorizar.Enabled = boolAutorizar 
                Me.cmdConsultar.Enabled = boolConsultar
                'Me.cmdCancelar.Enabled = boolAnular
                Me.cmdBuscar.Enabled = boolBuscar
                Me.cmdImprimir.Enabled = boolImprimir

                'Verificar estado de Salidas para habilitar/Deshabilitar botones
                Me.VerificarEstadoSalida()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad

            objSeg.ServicioUsuario = "FrmSivSalidaBodega"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AgregarSalida")
            boolBuscar = objSeg.TienePermiso("BuscarSalida")
            boolConsultar = objSeg.TienePermiso("ConsultarSalida")
            boolAnular = objSeg.TienePermiso("AnularSalida")
            boolAutorizar = objSeg.TienePermiso("AutorizarSalida")
            boolImprimir = objSeg.TienePermiso("ImprimirSalida")

            Me.cmdAgregar.Enabled = boolAgregar
            Me.cmdAutorizar.Enabled = boolAutorizar
            Me.cmdConsultar.Enabled = boolConsultar
            Me.cmdCancelar.Enabled = boolAnular
            Me.cmdBuscar.Enabled = boolConsultar
            Me.cmdImprimir.Enabled = boolImprimir

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Operaciones"
    Private Sub Autorizar()
        Dim AgregarSalida As frmSivAgregarSalida
        Try
            Dim selectedRow As Integer() = grdSalidaMasterTabla.GetSelectedRows()
            Dim FilaActual As Integer = Me.grdSalidaMasterTabla.GetDataSourceRowIndex(selectedRow(0))

            AgregarSalida = New frmSivAgregarSalida
            AgregarSalida.TypeGui = 1
            AgregarSalida.SalidaID = Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("Numero")
            If AgregarSalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarSalidas("1=1")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            AgregarSalida = Nothing
        End Try

    End Sub
    Private Sub Anular()
        Dim AgregarSalida As frmSivAgregarSalida

        Try
            Dim selectedRow As Integer() = grdSalidaMasterTabla.GetSelectedRows()
            Dim FilaActual As Integer = Me.grdSalidaMasterTabla.GetDataSourceRowIndex(selectedRow(0))

            AgregarSalida = New frmSivAgregarSalida
            AgregarSalida.TypeGui = 2
            AgregarSalida.SalidaID = Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("Numero")
            If AgregarSalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarSalidas("1=1")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            AgregarSalida = Nothing
        End Try
    End Sub

    Private Sub Consultar()
        Dim AgregarSalida As frmSivAgregarSalida

        Try
            Dim selectedRow As Integer() = grdSalidaMasterTabla.GetSelectedRows()
            Dim FilaActual As Integer = Me.grdSalidaMasterTabla.GetDataSourceRowIndex(selectedRow(0))

            AgregarSalida = New frmSivAgregarSalida
            AgregarSalida.TypeGui = 3
            AgregarSalida.SalidaID = Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("Numero")
            If AgregarSalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarSalidas("1=1")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            AgregarSalida = Nothing
        End Try
    End Sub

    Private Sub Buscar()
        Dim Buscarsalida As frmSivBuscarSalida
        Try
            Buscarsalida = New frmSivBuscarSalida
            If Buscarsalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarSalidas(Buscarsalida.Filtro)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Buscarsalida = Nothing
        End Try
    End Sub

    Private Sub Agregar()
        Dim AgregarSalida As frmSivAgregarSalida
        Try
            Try
                AgregarSalida = New frmSivAgregarSalida
                AgregarSalida.TypeGui = 0
                If AgregarSalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarSalidas("1=1")
                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            AgregarSalida = Nothing
        End Try
    End Sub

    Private Sub Imprimir()
        Dim objReporte As rptSalidaBodega
        Dim objImpresion As frmOpcionesImpresion
        Dim sSQL, sCampos As String
        Dim dtReporte As New DataTable

        objImpresion = New frmOpcionesImpresion
        objReporte = New rptSalidaBodega

        Dim selectedRow As Integer() = grdSalidaMasterTabla.GetSelectedRows()
        Dim FilaActual As Integer = Me.grdSalidaMasterTabla.GetDataSourceRowIndex(selectedRow(0))

        sCampos = "distinct dbo.fnRellenarCeros2(SivSalidaBodegaID,dbo.FnGetParametro('CantidadDigitosSalida')) as SivSalidaBodegaID, FechaSalida, TipoSalida, objEstadoID, objTipoSalidaID, Estado, Bodega, Codigo, Producto, Cantidad, costo, subtotal, Comentarios,Anulada,UsuarioCreacion,UsuarioModificacion"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptSalidaBodega", "SivSalidaBodegaID = " & Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("Numero"))
        dtReporte = SqlHelper.ExecuteQueryDT(sSQL)
        objReporte.DataSource = dtReporte

        If dtReporte.Rows.Count = 0 Then
            MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Exit Sub
        End If

        objReporte.UsuarioCreacion = dtReporte.DefaultView.Item(0)("UsuarioCreacion")
        If dtReporte.DefaultView.Item(0)("objEstadoID") = glb_EstadoAutorizadaID Then
            objReporte.UsuarioAutorizacion = dtReporte.DefaultView.Item(0)("UsuarioModificacion")
        End If

        If objImpresion.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(objReporte)
                Case 2
                    clsProyecto.ImprimirEnImpresora(objReporte, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(objReporte, Me)
            End Select
        End If
    End Sub

#End Region

#Region "Eventos"

#Region "Formularios"

    Private Sub frmSivSalidaBodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.ConfigurarSucursalSession()
            Me.CargarIdentificadoreEstados()
            Me.AplicarSeguridad()

            Me.CargarSalidas("1=1")

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdSalida_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs)
        '--Manejar estados
        Me.VerificarEstadoSalida()
        'If Me.dtSalidas.Rows.Count > 0 Then
        '    If Me.grdSalida.Columns("objEstadoID").Value = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "01") Or Me.grdSalida.Columns("objEstadoID").Value = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "02") Then
        '        Me.cmdCancelar.Enabled = True
        '    Else
        '        Me.cmdCancelar.Enabled = False
        '    End If

        '    If Me.grdSalida.Columns("objEstadoID").Value = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "02") Or Me.grdSalida.Columns("objEstadoID").Value = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "03") Then
        '        Me.cmdAutorizar.Enabled = False
        '    Else
        '        Me.cmdAutorizar.Enabled = True
        '    End If
        'End If
    End Sub
#End Region

#Region "Botones"

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Me.Agregar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdAutorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorizar.Click
        Me.Autorizar()
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Anular()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Me.Buscar()
    End Sub
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Me.Consultar()
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click

        Me.CargarSalidas("1=1")
    End Sub

    Private Sub cmdImprimirHojaSalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirHojaSalida.Click
        'Me.Imprimir()
        Dim dsReporte As DataSet
        Dim sCampos, sSQL As String
        Try
            Dim objjReporte As New rptHojaSalida()
            Dim selectedRow As Integer() = grdSalidaMasterTabla.GetSelectedRows()
            Dim FilaActual As Integer = Me.grdSalidaMasterTabla.GetDataSourceRowIndex(selectedRow(0))

            sCampos = "distinct dbo.fnRellenarCeros2(SivSalidaBodegaID,dbo.FnGetParametro('CantidadDigitosSalida')) as SivSalidaBodegaID, FechaSalida, TipoSalida, objEstadoID, objTipoSalidaID, Estado, Bodega, Codigo, Producto, Cantidad, costo, subtotal, Comentarios,Anulada,Empresa,DireccionEmpresa,UsuarioCreacion,UsuarioModificacion"
            sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptSalidaBodega", "SivSalidaBodegaID = " & Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("Numero"))
            dsReporte = SqlHelper.ExecuteQueryDS(sSQL)

            If dsReporte.Tables(0).Rows.Count = 0 Then
                MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objjReporte.DataSource = dsReporte
            objjReporte.DataMember = dsReporte.Tables(0).TableName
            Dim pt As New ReportPrintTool(objjReporte)
            pt.ShowPreview()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdListadoSalidaFiltrado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListadoSalidaFiltrado.Click
        Dim ImprimirSalida As frmSivRptSalida
        Try
            ImprimirSalida = New frmSivRptSalida
            ImprimirSalida.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            ImprimirSalida = Nothing
        End Try
    End Sub
#End Region

#Region "Configurar Sucursal Sessión"
    'Procedimiento para obtener datos de sucursales en Sessión y Central
    'Autor : Gelmin Martínez, 07 Agosto 2010, 09:13 am.
    Private Sub ConfigurarSucursalSession()
        'Seleccionar sucursal en sessión
        If Not String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            Try
                glb_SucursalSessionID = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
                glb_SucursalCentralID = ClsCatalogos.GetStbTiendaID("C")
            Catch ex As Exception
                MsgBox("La sucursal configurada no es una sucursal de repuestos", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.Close()
            End Try
        Else
            MsgBox("No se ha configurado la sucursal en el utilitario de configuración", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            Me.Close()
        End If
    End Sub
#End Region

#Region "Verificar estado Salida"
    Private Sub VerificarEstadoSalida()
        Try

            If Me.dtSalidas.Rows.Count > 0 Then
                Dim selectedRow As Integer() = grdSalidaMasterTabla.GetSelectedRows()
                Dim FilaActual As Integer = Me.grdSalidaMasterTabla.GetDataSourceRowIndex(selectedRow(0))
                If Not IsDBNull(Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("Numero")) AndAlso Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("objEstadoID").ToString.Trim.Length <> 0 Then
                    Me.cmdCancelar.Enabled = Me.boolAnular And (Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("objEstadoID") = glb_EstadoRegistradaID Or Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("objEstadoID") = glb_EstadoAutorizadaID)
                    Me.cmdAutorizar.Enabled = Me.boolAutorizar And (Me.dsSalidas.Tables("SivSalida").DefaultView.Item(FilaActual)("objEstadoID") = glb_EstadoRegistradaID)
                End If
            End If
        Catch ex As Exception
            Me.cmdCancelar.Enabled = False
            Me.cmdAutorizar.Enabled = False
        End Try
    End Sub
#End Region

#Region "Cargar Identifadores de Estados de salida"
    Private Sub CargarIdentificadoreEstados()
        Try
            glb_EstadoRegistradaID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "01") '01=REGISTRADA
            glb_EstadoAutorizadaID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "02") '=AUTORIZADA
            glb_EstadoAnuladaID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "03") '=ANULADA
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try        
    End Sub

#End Region

    Private Sub grdSalidaMasterTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdSalidaMasterTabla.FocusedRowChanged
        Me.VerificarEstadoSalida()
    End Sub

#End Region

   
End Class