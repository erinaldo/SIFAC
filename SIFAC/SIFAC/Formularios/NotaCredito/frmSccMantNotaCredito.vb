''----------------------------------------------------------------------
''----------------------------------------------------------------------
''--    Formulario Principal Cátalgo Notas de Crédito
''----------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports SIFAC.BO

Public Class frmSccMantNotaCredito

#Region "Declaracion de Variables"
    Dim objNC As SccNotaCredito
    Dim objSeg As SsgSeguridad
    Dim dtNC As DataTable
    Dim CerosRellenoNC As Integer
    Dim EstadoRegistrada As Integer
    Dim EstadoAutorizada As Integer
    Dim EstadoAnulada As Integer
    Dim EstadoNC As Integer
    Dim ConceptoNC As Integer
    Dim ConceptoDevolucion As Integer
    Dim NCID As Integer
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Dim blnModificarNC As Boolean = False
    Dim blnAutorizarNC As Boolean = False
    Dim blnAnularNC As Boolean = False
    Dim blnBuscarNC As Boolean = False
    Dim blnConsultarNC As Boolean = False
    Dim blnImprimirNC As Boolean = False
    Dim blnBusqueda As Boolean = False
#End Region

#Region "Eventos del Formulario"

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Al Cargar el Formulario se carga el Tema, Grid y se
    '--                     :   aplica la seguridad.
    '-----------------------------------------------------------------------------------
    Private Sub frmSccMantNotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ''  Me.Icon = My.Resources.MdiChildIcon
            objNC = New SccNotaCredito
            AplicarSeguridad()
            PropiedadesFormulario()
            CargarGridNotaCredito()
            clsProyecto.CargarTemaDefinido(Me)

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
    '-- Fecha de Creación   :   04 de Diciembre del 2007
    '-- Descripcion         :   Aplica la Seguridad al Formulario
    '-----------------------------------------------------------------------------------
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "FRMSCCNOTACREDITO"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            If objSeg.TienePermiso("AgregarNC") Then
                Me.tsbAgregarNC.Enabled = True
            Else
                Me.tsbAgregarNC.Enabled = False
            End If
            If objSeg.TienePermiso("ModificarNC") Then
                blnModificarNC = True
            Else
                blnModificarNC = False
            End If
            If objSeg.TienePermiso("AutorizarNC") Then
                blnAutorizarNC = True
            Else
                blnAutorizarNC = False
            End If
            If objSeg.TienePermiso("AnularNC") Then
                blnAnularNC = True
            Else
                blnAnularNC = False
            End If
            If objSeg.TienePermiso("BuscarNC") Then
                Me.tsbBuscarNC.Enabled = True
                blnBuscarNC = True
            Else
                Me.tsbBuscarNC.Enabled = False
                blnBuscarNC = False
            End If
            If objSeg.TienePermiso("ConsultarNC") Then
                Me.tsbConsultarNC.Enabled = True
                blnConsultarNC = True
            Else
                Me.tsbConsultarNC.Enabled = False
                blnConsultarNC = False
            End If
            If objSeg.TienePermiso("ImprimirNC") Then
                blnImprimirNC = True
            Else
                blnImprimirNC = False
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Propiedades del Formulario"

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   04 de Diciembre del 2007
    '-- Descripcion         :   Valores de Parametros para el Formulario
    '-----------------------------------------------------------------------------------
    Private Sub PropiedadesFormulario()
        Dim dtTemp As DataTable
        Try
            '-- Obtener el Relleno de Ceros del Numero de Nota de Credito a Mostrar en el Grid
            'strCampos = " Nombre, Valor "
            'strFiltro = " Nombre= 'CerosRellenoNC' "
            'strSQL = clsConsultas.ObtenerValorParametro(strCampos, strFiltro)
            'dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            'If dtTemp.Rows.Count > 0 Then
            '    CerosRellenoNC = dtTemp.Rows(0).Item("Valor")
            'End If

            '-- Obtener ID del Estado de Nota de Credito REGISTRADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoNC' AND Codigo='REGISTRADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoRegistrada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Credito AUTORIZADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoNC' AND Codigo='AUTORIZADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAutorizada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Credito ANULADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoNC' AND Codigo='ANULADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAnulada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Concepto de Nota de Credito DEVOLUCION 
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'ConceptoNC' AND Codigo='DEVOLUCION' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                ConceptoDevolucion = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtTemp = Nothing
        End Try
    End Sub

#End Region

#Region "Grid"
    Private Sub CargarGridNotaCredito()
        Dim FilaActual As Integer
        Try
            If Not blnBusqueda Then
                strCampos = " * "
                strOrden = " Fecha DESC"
                strSQL = clsConsultas.ObtenerNotaCredito(strCampos, , strOrden)
                dtNC = SqlHelper.ExecuteQueryDT(strSQL)
            End If

            If dtNC.Rows.Count > 0 Then

                '-- Mostrar los datos en el Grid
                Me.grdNotaCredito.DataSource = dtNC
                Me.grdNotaCredito.Text = "Notas de Crédito (" & dtNC.Rows.Count & ")"
                dtNC.PrimaryKey = New DataColumn() {dtNC.Columns("SccNotaCreditoID")}
                Me.dtNC.DefaultView.Sort = "SccNotaCreditoID"
            End If

            If Me.grdNotaCreditoTabla.RowCount > 0 Then
                Dim selectedRow As Integer() = grdNotaCreditoTabla.GetSelectedRows()
                FilaActual = Me.grdNotaCreditoTabla.GetDataSourceRowIndex(selectedRow(0))

                Me.NCID = Me.dtNC.DefaultView.Item(FilaActual)("SccNotaCreditoID")
                Me.EstadoNC = Me.dtNC.DefaultView.Item(FilaActual)("objEstadoID")
                Me.ConceptoNC = Me.dtNC.DefaultView.Item(FilaActual)("objConceptoID")

                '-- Habilitar Opciones
                If blnModificarNC And EstadoNC = EstadoRegistrada And Not ConceptoNC = ConceptoDevolucion Then
                    Me.tsbModificarNC.Enabled = True
                Else
                    Me.tsbModificarNC.Enabled = False
                End If
                If blnAutorizarNC And EstadoNC = EstadoRegistrada Then
                    Me.tsbAutorizarNC.Enabled = True
                Else
                    Me.tsbAutorizarNC.Enabled = False
                End If
                If blnAnularNC And (EstadoNC = EstadoRegistrada Or EstadoNC = EstadoAutorizada) Then
                    Me.tsbAnularNC.Enabled = True
                Else
                    Me.tsbAnularNC.Enabled = False
                End If
                If blnImprimirNC And EstadoNC = EstadoAutorizada Then
                    Me.tsbImprimir.Enabled = True
                Else
                    Me.tsbImprimir.Enabled = False
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotaCredito_AfterFilter(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs)
        Try
            Me.grdNotaCredito.Text = "Notas de Crédito (" & dtNC.DefaultView.Count & ")"
            If dtNC.DefaultView.Count = 0 Then
                Me.tsbModificarNC.Enabled = False
                Me.tsbAutorizarNC.Enabled = False
                Me.tsbAnularNC.Enabled = False
                Me.tsbConsultarNC.Enabled = False
            Else
                Me.tsbModificarNC.Enabled = True
                Me.tsbAutorizarNC.Enabled = True
                Me.tsbAnularNC.Enabled = True
                Me.tsbConsultarNC.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotaCredito_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs)
        Dim FilaActual As Integer
        Try
            If Me.grdNotaCreditoTabla.RowCount > 0 Then
                Dim selectedRow As Integer() = grdNotaCreditoTabla.GetSelectedRows()
                FilaActual = Me.grdNotaCreditoTabla.GetDataSourceRowIndex(selectedRow(0))

                Me.NCID = Me.dtNC.DefaultView.Item(FilaActual)("SccNotaCreditoID")
                Me.EstadoNC = Me.dtNC.DefaultView.Item(FilaActual)("objEstadoID")
                Me.ConceptoNC = Me.dtNC.DefaultView.Item(FilaActual)("objConceptoID")

                If blnModificarNC And EstadoNC = EstadoRegistrada And Not ConceptoNC = ConceptoDevolucion Then
                    Me.tsbModificarNC.Enabled = True
                Else
                    Me.tsbModificarNC.Enabled = False
                End If
                If blnAutorizarNC And EstadoNC = EstadoRegistrada Then
                    Me.tsbAutorizarNC.Enabled = True
                Else
                    Me.tsbAutorizarNC.Enabled = False
                End If
                If blnAnularNC And (EstadoNC = EstadoRegistrada Or EstadoNC = EstadoAutorizada) Then
                    Me.tsbAnularNC.Enabled = True
                Else
                    Me.tsbAnularNC.Enabled = False
                End If
                If blnImprimirNC And EstadoNC = EstadoAutorizada Then
                    Me.tsbImprimir.Enabled = True
                Else
                    Me.tsbImprimir.Enabled = False
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos del Toolbar"

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Agregar una Nota de Credito
    '-----------------------------------------------------------------------------------
    Private Sub tsbAgregarNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarNC.Click
        Dim objfrm As frmSccEditNotaCredito
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditNotaCredito
            objfrm.TypeGui = 0
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridNotaCredito()
                Me.dtNC.DefaultView.Find(objfrm.IDNotaCredito)
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Modificar una Nota de Credito
    '--                     :   Solo para NC con estado REGISTRADA
    '-----------------------------------------------------------------------------------
    Private Sub tsbModificarNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificarNC.Click
        Try
            If dtNC.DefaultView.Count > 0 And blnModificarNC And EstadoNC = EstadoRegistrada Then
                'objNC.Retrieve(Me.NCID)
                'If Not objNC.Reservado Then
                ModificarNotaCredito()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Modificar una Nota de Credito
    '--                     :   Solo para NC con estado REGISTRADA
    '-----------------------------------------------------------------------------------
    Private Sub ModificarNotaCredito()
        Dim objfrm As frmSccEditNotaCredito
        Dim FilaActual As Integer
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditNotaCredito
            objfrm.TypeGui = 1
            Dim selectedRow As Integer() = grdNotaCreditoTabla.GetSelectedRows()
            FilaActual = Me.grdNotaCreditoTabla.GetDataSourceRowIndex(selectedRow(0))

            objfrm.IDNotaCredito = Me.dtNC.DefaultView.Item(FilaActual)("SccNotaCreditoID")
            '-- Reservar Registro
            ''ReservarRegistro("SccNotaCredito", Me.NCID)

            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridNotaCredito()
                Me.dtNC.DefaultView.Find(objfrm.IDNotaCredito)
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            ''LiberarRegistro("SccNotaCredito", Me.NCID)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Autorizar una Nota de Credito. 
    '--                     :   Solo para NC con estado REGISTRADA
    '-----------------------------------------------------------------------------------
    Private Sub tsbAutorizarNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAutorizarNC.Click
        Try
            If dtNC.DefaultView.Count > 0 And blnAutorizarNC And EstadoNC = EstadoRegistrada Then
                objNC.Retrieve(Me.NCID)
                '              If Not objNC.Reservado Then
                AutorizarNotaCredito()
                'Else
                '    MsgBox(My.Resources.MsgReservado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                'End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Autorizar una Nota de Credito. 
    '--                     :   Solo para NC con estado REGISTRADA
    '-----------------------------------------------------------------------------------
    Private Sub AutorizarNotaCredito()
        Dim T As New TransactionManager
        Dim IDTemp As Integer = 0
        Try
            Me.Cursor = Cursors.WaitCursor

            Select Case MsgBox("¿Seguro que desea autorizar la nota de crédito?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes

                    '-- Reservar Registro
                    '' ReservarRegistro("SccNotaCredito", Me.NCID)

                    T.BeginTran()
                    IDTemp = Me.NCID
                    objNC.Retrieve(Me.NCID)
                    objNC.objEstadoID = Me.EstadoAutorizada
                    objNC.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objNC.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objNC.Update(T)
                    T.CommitTran()
                    CargarGridNotaCredito()
                    Me.dtNC.DefaultView.Find(objNC.SccNotaCreditoID)
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End Select
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            ''LiberarRegistro("SccNotaCredito", Me.NCID)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Autorizar una Nota de Credito. 
    '--                     :   Solo para NC con estado REGISTRADA o AUTORIZADA
    '-----------------------------------------------------------------------------------
    Private Sub tsbAnularNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnularNC.Click
        Dim FilaActual As Integer
        Dim IDEstadoVig As Integer
        Try
            If dtNC.DefaultView.Count > 0 And blnAnularNC And (EstadoNC = EstadoRegistrada Or EstadoNC = EstadoAutorizada) Then
                objNC.Retrieve(Me.NCID)
                IDEstadoVig = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "REGISTRADA")

                Dim selectedRow As Integer() = grdNotaCreditoTabla.GetSelectedRows()
                FilaActual = Me.grdNotaCreditoTabla.GetDataSourceRowIndex(selectedRow(0))
                If Me.dtNC.DefaultView.Item(FilaActual)("objEstadoID") <> IDEstadoVig Then
                    MsgBox("Solamente Notas de Crédito en estado REGISTRADA pueden ser Anuladas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
                AnularNC()

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Autorizar una Nota de Credito. 
    '--                     :   Solo para NC con estado REGISTRADA o AUTORIZADA
    '-----------------------------------------------------------------------------------
    Private Sub AnularNC()
        Dim T As New TransactionManager
        Dim IDTemp As Integer = 0
        Try
            Me.Cursor = Cursors.WaitCursor
            Select Case MsgBox("¿Seguro que desea anular la nota de crédito?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Me.Cursor = Cursors.WaitCursor
                    T.BeginTran()
                    IDTemp = Me.NCID
                    objNC.Retrieve(Me.NCID)
                    objNC.objEstadoID = Me.EstadoAnulada
                    objNC.Update(T)
                    T.CommitTran()
                    CargarGridNotaCredito()
                   
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Buscar una Nota de Credito. 
    '-----------------------------------------------------------------------------------
    Private Sub tsbBuscarNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscarNC.Click
        'Dim objfrm As New frmSccParamBuscarNotaCredito
        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    If blnBuscarNC And dtNC.Rows.Count > 0 Then
        '        objfrm.TipoCerosRelleno = CerosRellenoNC
        '        If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '            blnBusqueda = True
        '            dtNC = objfrm.TipodtNCID.Copy
        '            CargarGridNotaCredito()
        '        End If
        '    End If
        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'Finally
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Consultar los datos de una Nota de Credito. 
    '-----------------------------------------------------------------------------------
    Private Sub tsbConsultarNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultarNC.Click
        Dim objfrm As New frmSccEditNotaCredito
        Dim FilaActual As Integer
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim selectedRow As Integer() = grdNotaCreditoTabla.GetSelectedRows()
            FilaActual = Me.grdNotaCreditoTabla.GetDataSourceRowIndex(selectedRow(0))

            If dtNC.DefaultView.Count > 0 Then
                ''And blnConsultarNC And dtNC.Rows.Count > 0 Then
                objfrm.IDNotaCredito = Me.dtNC.DefaultView.Item(FilaActual)("SccNotaCreditoID")
                objfrm.TypeGui = 2
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

    '---------------------------------------------------------------------------------------------
    '-- Descripcion         :   Imprimir Nota de Crédito. La NC asociada al registro seleccionado
    '----------------------------------------------------------------------------------------------
    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        'Dim objfrm As frmParamImpDestinoReporte
        'Dim dtRptNC As DataTable
        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    If blnImprimirNC And EstadoNC = EstadoAutorizada Then
        '        objfrm = New frmParamImpDestinoReporte
        '        strSQL = clsConsultas.ObtenerNotaCredito(" * ", "SccNotaCreditoID=" & Me.NCID)
        '        dtRptNC = SqlHelper.ExecuteQueryDT(strSQL)

        '        If dtRptNC.Rows.Count > 0 Then
        '            '-- Rellenar con Ceros el Numero de Nota de Credito
        '            dtRptNC.Rows(0).Item("Codigo") = RellenarConCeros(dtRptNC.Rows(0).Item("Numero"), Me.CerosRellenoNC)

        '            '-- Concatenar los Datos del Cliente
        '            If IsDBNull(dtRptNC.Rows(0).Item("RazonSocial")) Then
        '                dtRptNC.Rows(0).Item("DatosClienteRpt") = dtRptNC.Rows(0).Item("CodigoCliente") & " /   / " & dtRptNC.Rows(0).Item("Cliente")
        '            Else
        '                dtRptNC.Rows(0).Item("DatosClienteRpt") = dtRptNC.Rows(0).Item("CodigoCliente") & "  /  " & dtRptNC.Rows(0).Item("RazonSocial") & "  /  " & dtRptNC.Rows(0).Item("Cliente")
        '            End If

        '            '-- Concatenar los Datos de la Sucursal
        '            dtRptNC.Rows(0).Item("DatosSucursalRpt") = dtRptNC.Rows(0).Item("CodigoSucursal") & "  /  " & dtRptNC.Rows(0).Item("Sucursal")

        '            '-- Concatenar los Datos de la Direccion de la Sucursal
        '            dtRptNC.Rows(0).Item("DatosDireccionRpt") = dtRptNC.Rows(0).Item("Direccion") & "  /  " & dtRptNC.Rows(0).Item("Municipio") & "  /  " & dtRptNC.Rows(0).Item("Departamento")

        '            '-- Asignar el datatable al formulario de destino del reporte
        '            objfrm.dtRpt = dtRptNC.Copy

        '            '-- Pasar el nombre del formulario de reporte al formulario de destino del reporte
        '            objfrm.rptNombre = "rptSccNotaCredito"
        '            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '                '*******************
        '            End If
        '        Else
        '            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
        '        End If
        '    End If
        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'Finally
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Refrescar el Grid Principal 
    '-----------------------------------------------------------------------------------
    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Try
            blnBusqueda = False
            CargarGridNotaCredito()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion         :   Salir
    '-----------------------------------------------------------------------------------
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

#End Region

End Class