''-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
''-- Fecha de Elaboración    : 03 de Enero del 2008.
''----------------------------------------------------------------------
''--    Formulario Principal Cátalgo Notas de Débito
''----------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports SCCUM.BO
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos

Public Class frmStbMantTasaCambioOficial

#Region "Declaracion de Variables Locales y Objetos"
    Dim objSeg As SsgSeguridad
    Dim dtTCO As DataTable
    Dim dtTasaCambio As DataTable
    Dim TCOID As Integer
    Dim NumMes As Integer
    Dim MonedaID As Integer
    Dim Anio As Integer
    Dim EstadoTCO As Integer
    Dim EstadoRegistrada As Integer
    Dim EstadoConfirmado As Integer
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Dim blnRegistrarTCO As Boolean = False
    Dim blnConfirmarTCO As Boolean = False
    Dim blnImprimirTCO As Boolean = False
#End Region

#Region "Eventos del Formulario"

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Al Cargar el Formulario se carga el Tema, Grid y se
    '--                     :   aplica la seguridad.
    '-----------------------------------------------------------------------------------
    Private Sub frmStbMantTasaCambioOficial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            AplicarSeguridad()
            clsProyecto.CargarTemaDefinido(Me)
            PropiedadesFormulario()
            CargarGrid()
            Me.grdTCO.Splits(0).DisplayColumns("StbTasaCambioOficialID").Visible = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Seguridad"

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Aplica la Seguridad al Formulario
    '-----------------------------------------------------------------------------------
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "frmStbMantTasaCambioOficial"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            If objSeg.TienePermiso("RegistrarTasaCambioOficial") Then
                blnRegistrarTCO = True
                Me.tsbRegistrarTCO.Enabled = True
            Else
                blnRegistrarTCO = False
                Me.tsbRegistrarTCO.Enabled = False
            End If
            If objSeg.TienePermiso("ConfirmarTasaCambioOficial") Then
                blnConfirmarTCO = True
            Else
                blnConfirmarTCO = False
            End If
            If objSeg.TienePermiso("ImprimirTasaCambioOficial") Then
                blnImprimirTCO = True
            Else
                blnImprimirTCO = False
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Propiedades del Formulario"

    Private Sub PropiedadesFormulario()
        Dim dtTemp As DataTable
        Try
            '-- Obtener ID del Estado de la Tasa de Cambio REGISTRADO
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoTasaCambio' AND Codigo='REGISTRADO' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoRegistrada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de la Tasa de Cambio CONFIRMADO
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoTasaCambio' AND Codigo='CONFIRMADO' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoConfirmado = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Grid"

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Cargar Grid Principal. Lado Izquierdo
    '-----------------------------------------------------------------------------------
    Private Sub CargarGrid()
        Try
            strCampos = "StbTasaCambioOficialID, Mes, Anio, Moneda, Monto,Estado"
            strOrden = " Moneda, Anio DESC, Mes DESC "
            strSQL = clsConsultas.ObtenerTasaCambioOficial(strCampos, , strOrden)
            dtTCO = SqlHelper.ExecuteQueryDT(strSQL)
            dtTCO.PrimaryKey = New DataColumn() {Me.dtTCO.Columns("StbTasaCambioOficialID")}
            dtTCO.DefaultView.Sort = "StbTasaCambioOficialID"
            If dtTCO.Rows.Count > 0 Then
                Me.grdTCO.SetDataBinding(dtTCO, "", True)
                Me.grdTCO.Caption = " Tasa de Cambio (" & Me.dtTCO.Rows.Count & ")"
            End If
            HabilitarToolbar()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Evenvo del Cambio de Registros en Grid Principal
    '-----------------------------------------------------------------------------------
    Private Sub grdTCO_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs)
        Try
            If Me.grdTCO.RowCount > 0 Then
                HabilitarToolbar()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Evento de Filtrado de Registros en Grid Principal
    '-----------------------------------------------------------------------------------
    Private Sub grdTCO_AfterFilter(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs)
        Try
            Me.grdTCO.Caption = " Tasa de Cambio (" & Me.dtTCO.DefaultView.Count & ")"
            If Me.dtTCO.DefaultView.Count = 0 Then
                Me.tsbConfirmarTCO.Enabled = False
                Me.tsbImprimir.Enabled = False
            Else
                HabilitarToolbar()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Habilitar o Bloquear los Botones del toolbar
    '-----------------------------------------------------------------------------------
    Private Sub HabilitarToolbar()
        Try
            If Me.blnRegistrarTCO Then
                Me.tsbRegistrarTCO.Enabled = True
            Else
                Me.tsbRegistrarTCO.Enabled = False
            End If
            If Me.blnConfirmarTCO And Me.dtTCO.DefaultView.Count > 0 Then
                Me.tsbConfirmarTCO.Enabled = True
            Else
                Me.tsbConfirmarTCO.Enabled = False
            End If
            If Me.blnImprimirTCO And Me.dtTCO.DefaultView.Count > 0 Then
                Me.tsbImprimir.Enabled = True
            Else
                Me.tsbImprimir.Enabled = False
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos del Toolbar"

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Registrar Tasa de Cambio Oficial
    '-----------------------------------------------------------------------------------
    Private Sub tsbRegistrarTCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRegistrarTCO.Click
        Dim objfrm As frmStbEditTasaCambioOficial
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmStbEditTasaCambioOficial
            objfrm.TipoEstadoRegistarda = Me.EstadoRegistrada
            objfrm.TipoEstadoConfirmada = Me.EstadoConfirmado
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()           
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.grdTCO.Row = Me.dtTCO.DefaultView.Find(objfrm.TasaCambioOficialID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   04 de Enero del 2008
    '-- Descripcion         :   Confirmar las Tasas de Cambio Oficial
    '-----------------------------------------------------------------------------------
    Private Sub tsbConfirmarTCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConfirmarTCO.Click
        Dim objTasaCambio As New StbTasaCambioOficial
        Dim T As New TransactionManager
        Dim IndiceGrid As Integer
        Try
            If Me.blnConfirmarTCO And Me.dtTCO.Rows.Count > 0 Then
                IndiceGrid = Me.grdTCO.RowBookmark(Me.grdTCO.Row)

                '-- Obtener el Detalle de Tasas de Cambio para ese Mes/Año/Moneda
                

                '-- Verificar si hay registros que Confirmar
                objTasaCambio.RetrieveByFilter("StbTasaCambioOficialID = " & grdTCO.Columns("StbTasaCambioOficialID").Value)
                If objTasaCambio.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoTasaCambio", "REGISTRADO") Then
                    Select Case MsgBox("¿Desea confirmar las tasas de cambio registradas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            T.BeginTran()
                            objTasaCambio.objEstadoID = Me.EstadoConfirmado
                            objTasaCambio.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objTasaCambio.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objTasaCambio.Update(T)
                            T.CommitTran()
                            CargarGrid()
                            Me.grdTCO.Row = IndiceGrid
                            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End Select
                Else
                    MsgBox("Las tasas de cambio ya se encuentran en estado Confirmado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                End If
            End If
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        Dim objfrm As New frmParamImpDestinoReporte
        Dim dtRptTCO As DataTable
        Try
            If Me.blnImprimirTCO Then
                Me.Cursor = Cursors.WaitCursor
                strCampos = "Mes, Anio, Monto, Moneda, Estado, Confirmado "
                strOrden = " Mes"
                strSQL = clsConsultas.ObtenerTasaCambioOficial(strCampos, , strOrden)
                dtRptTCO = SqlHelper.ExecuteQueryDT(strSQL)
                For Each dr As DataRow In dtRptTCO.Rows
                    If dr("Estado") = "Confirmado" Then
                        dr("Confirmado") = True
                    Else
                        dr("Confirmado") = False
                    End If
                Next
                '-- Asignar el datatable al formulario de destino del reporte
                objfrm.dtRpt = dtRptTCO.Copy

                '-- Pasar el nombre del formulario de reporte al formulario de destino del reporte
                objfrm.rptNombre = "rptStbTasaCambioOficial"
                If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    '*******************
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   04 de Enero del 2008
    '-- Descripcion         :   Refrescar Grid
    '-----------------------------------------------------------------------------------
    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Salir
    '-----------------------------------------------------------------------------------
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

#End Region

End Class