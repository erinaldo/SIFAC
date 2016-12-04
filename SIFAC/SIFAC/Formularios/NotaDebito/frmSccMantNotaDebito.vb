''-------------------------------------------------------------------------------------------------
''----------------------------------------------------------------------
''--    Formulario Principal Cátalgo Notas de Débito
''----------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Data.SqlClient
Imports SIFAC.BO

Public Class frmSccMantNotaDebito

#Region "Declaracion de Variables Locales y Objetos"
    '' Dim objND As SccNotaDebito
    Dim objSeg As SsgSeguridad
    Dim dtND As DataTable
    Dim IDND As Integer
    Dim EstadoND As Integer
    Dim CerosRellenoND As Integer
    Dim EstadoRegistrada As Integer
    Dim EstadoAutorizada As Integer
    Dim EstadoAnulada As Integer
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Dim blnModificarND As Boolean = False
    Dim blnAutorizarND As Boolean = False
    Dim blnAnularND As Boolean = False
    Dim blnBuscarND As Boolean = False
    Dim blnConsultarND As Boolean = False
    Dim blnImprimirND As Boolean = False
    Dim blnBusqueda As Boolean = False
#End Region

#Region "Eventos del Formulario"
    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Al Cargar el Formulario se carga el Tema, Grid y se
    '--                     :   aplica la seguridad.
    '-----------------------------------------------------------------------------------
    Private Sub frmSccMantNotaDebito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
          
            AplicarSeguridad()
            PropiedadesFormulario()
            CargarGridNotaDebito()
         
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Seguridad"
    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Aplica la Seguridad al Formulario
    '-----------------------------------------------------------------------------------
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "FRMSCCNOTADEBITO"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            If objSeg.TienePermiso("AgregarND") Then
                Me.tsbAgregarND.Enabled = True
            Else
                Me.tsbAgregarND.Enabled = False
            End If
            If objSeg.TienePermiso("ModificarND") Then
                blnModificarND = True
            Else
                blnModificarND = False
            End If
            If objSeg.TienePermiso("AutorizarND") Then
                blnAutorizarND = True
            Else
                blnAutorizarND = False
            End If
            If objSeg.TienePermiso("AnularND") Then
                blnAnularND = True
            Else
                blnAnularND = False
            End If
            If objSeg.TienePermiso("BuscarND") Then
                Me.tsbBuscarND.Enabled = True
                blnBuscarND = True
            Else
                Me.tsbBuscarND.Enabled = False
                blnBuscarND = False
            End If
            If objSeg.TienePermiso("ConsultarND") Then
                Me.tsbConsultarND.Enabled = True
                blnConsultarND = True
            Else
                Me.tsbConsultarND.Enabled = False
                blnConsultarND = False
            End If
            If objSeg.TienePermiso("ImprimirND") Then
                blnImprimirND = True
            Else
                blnImprimirND = False
            End If
            Me.cmdDeshacerNota.Enabled = objSeg.TienePermiso("DeshacerNota")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Propiedades del Formulario"

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboración    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Valores de Parametros para el Formulario
    '-----------------------------------------------------------------------------------
    Private Sub PropiedadesFormulario()
        Dim dtTemp As DataTable
        Try

            '-- Obtener ID del Estado de Nota de Debito REGISTRADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoND' AND Codigo='REGISTRADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoRegistrada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito AUTORIZADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoND' AND Codigo='AUTORIZADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAutorizada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito ANULADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoND' AND Codigo='ANULADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAnulada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Grid"

    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Cargar el Grid Notas de Debito.
    '--                     :   Rellenar con Ceros el Numero Nota de Debito a Mostrar
    '-----------------------------------------------------------------------------------
    Private Sub CargarGridNotaDebito()
        Dim FilaActual As Integer
        Try
            If Not blnBusqueda Then
                strCampos = " * "
                strOrden = " Fecha DESC "
                dtND = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*", "vwSccNotaDebito", "1=1"))
            End If

            If dtND.Rows.Count > 0 Then

                '-- Mostrar los datos en el Grid
                dtND.PrimaryKey = New DataColumn() {dtND.Columns("SccNotaDebitoID")}
                Me.dtND.DefaultView.Sort = "SccNotaDebitoID"

                Me.grdND.DataSource = dtND
                Me.grdND.Text = "Notas de Débito (" & dtND.Rows.Count & ")"


                If Me.grdNDTabla.RowCount > 0 Then

                    Dim selectedRow As Integer() = grdNDTabla.GetSelectedRows()
                    FilaActual = Me.grdNDTabla.GetDataSourceRowIndex(selectedRow(0))

                    IDND = Me.dtND.DefaultView.Item(FilaActual)("SccNotaDebitoID")
                    EstadoND = Me.dtND.DefaultView.Item(FilaActual)("objEstadoID")

                    '-- Habilitar Opciones
                    If blnModificarND And EstadoND = EstadoRegistrada Then
                        Me.tsbModificarND.Enabled = True
                    Else
                        Me.tsbModificarND.Enabled = False
                    End If
                    If blnAutorizarND And EstadoND = EstadoRegistrada Then
                        Me.tsbAutorizarND.Enabled = True
                    Else
                        Me.tsbAutorizarND.Enabled = False
                    End If
                    If blnAnularND And EstadoND = EstadoRegistrada Then
                        Me.tsbAnularND.Enabled = True
                    Else
                        Me.tsbAnularND.Enabled = False
                    End If
                    If blnImprimirND And EstadoND = EstadoAutorizada Then
                        Me.tsbImprimirND.Enabled = True
                    Else
                        Me.tsbImprimirND.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region




#Region "Eventos del Toolbar"

    '-----------------------------------------------------------------------
   
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Agregar una Nota de Debito
    '-----------------------------------------------------------------------------------
    Private Sub tsbAgregarND_Click(ByVal stender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarND.Click
        Dim objfrm As frmSccEditNotaDebito
        '' Dim strRecibo As String = ""
        ''Dim ReciboID As Integer
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditNotaDebito
            objfrm.TypeGui = 0
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridNotaDebito()
                Me.dtND.DefaultView.Find(objfrm.IDNotaDebito)
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                'Me.IDND = objfrm.TipoNDID
                'strRecibo = objfrm.strRecibo
                'ReciboID = objfrm.ReciboID
            Else
                'strRecibo = objfrm.strRecibo
                'ReciboID = objfrm.ReciboID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            ''  LiberarRegistro("SccNotaDebito", Me.IDND)
            Me.Cursor = Cursors.Default
            ''-- Liberar Recibo
            'If Not strRecibo = "" And Not ReciboID = 0 Then
            '    If strRecibo = "Colector" Then
            '        LiberarRegistro("SccReciboColector", ReciboID)
            '    ElseIf strRecibo = "Caja" Then
            '        LiberarRegistro("SccReciboCaja", ReciboID)
            '    End If
            'End If
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboración    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Modificar una Nota de Debito
    '--                     :   Solo para ND con estado Debito
    '-----------------------------------------------------------------------------------
    Private Sub tsbModificarND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificarND.Click
        Try
            If dtND.DefaultView.Count > 0 And blnModificarND And EstadoND = EstadoRegistrada Then
                ''objND.Retrieve(Me.IDND)
                ''If Not objND.Reservado Then
                ModificarND()
                'Else
                '    MsgBox(My.Resources.MsgReservado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                'End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboración    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Modificar una Nota de Debito
    '--                     :   Solo para ND con estado Debito
    '-----------------------------------------------------------------------------------
    Private Sub ModificarND()
        Dim objfrm As frmSccEditNotaDebito
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditNotaDebito
            objfrm.IDNotaDebito = IDND
            objfrm.TypeGui = 1
            '-- Reservar Registro
            ''  ReservarRegistro("SccNotaDebito", Me.IDND)

            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridNotaDebito()
                Me.dtND.DefaultView.Find(objfrm.IDNotaDebito)

                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            ''   LiberarRegistro("SccNotaDebito", Me.IDND)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Autorizar una Nota de Debito 
    '--                     :   Solo para ND con estado REGISTRADA
    '-----------------------------------------------------------------------------------
    Private Sub tsbAutorizarND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAutorizarND.Click
        Try
            If dtND.DefaultView.Count > 0 And blnAutorizarND And EstadoND = EstadoRegistrada Then
                ''    objND.Retrieve(Me.IDND)
                ''   If Not objND.Reservado Then
                AutorizarND()
                'Else
                '    MsgBox(My.Resources.MsgReservado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                'End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Autorizar una Nota de Debito 
    '--                     :   Solo para ND con estado REGISTRADA
    '-----------------------------------------------------------------------------------
    Private Sub AutorizarND()
        Dim T As New TransactionManager
        Dim objND As New SccNotaDebito
        Dim objSccCuentaCobrar As New SccCuentaPorCobrar
        Dim objSccCuentaDetalle As New SccCuentaPorCobrarDetalle
        Try
            Select Case MsgBox("¿Seguro que desea autorizar la nota de débito?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Me.Cursor = Cursors.WaitCursor

                    '-- Reservar Registro
                    '   ReservarRegistro("SccNotaDebito", Me.IDND)

                    T.BeginTran()

                    '-- Actualizar el Estado de la Nota de Credito
                    objND.Retrieve(Me.IDND)
                    objND.objEstadoID = Me.EstadoAutorizada
                    objND.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objND.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objND.Update(T)

                    objSccCuentaDetalle.RetrieveByFilter("objSccCuentaID ='" & objND.objSccCuentaID & "'" & "  AND objFacturaID = " & objND.objFacturaID.Value.ToString, T)
                    objSccCuentaDetalle.Saldo = objSccCuentaDetalle.Saldo + objND.Monto

                    If (objSccCuentaDetalle.SaldoND.HasValue) Then
                        objSccCuentaDetalle.SaldoND = objSccCuentaDetalle.SaldoND + objND.Monto
                    Else
                        objSccCuentaDetalle.SaldoND = objND.Monto
                    End If

                    objSccCuentaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSccCuentaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSccCuentaDetalle.Update(T)

                    objSccCuentaCobrar.Retrieve(objND.objSccCuentaID, T)
                    objSccCuentaCobrar.Saldo = objSccCuentaCobrar.Saldo + objND.Monto
                    objSccCuentaCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSccCuentaCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSccCuentaCobrar.Update(T)

                    T.CommitTran()

                    '-- Seleccionar el Registro que se ha modificado
                    CargarGridNotaDebito()
                    Me.dtND.DefaultView.Find(objND.SccNotaDebitoID)

                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End Select
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            ''   LiberarRegistro("SccNotaDebito", Me.IDND)
            objSccCuentaCobrar = Nothing
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Autorizar una Nota de Debito. 
    '--                     :   Solo para ND con estado REGISTRADA 
    '-----------------------------------------------------------------------------------
    Private Sub tsbAnularND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnularND.Click
        Try
            If dtND.DefaultView.Count > 0 And blnAnularND And EstadoND = EstadoRegistrada Then
                ''   objND.Retrieve(Me.IDND)
                '    If Not objND.Reservado Then
                'AnularND()
                '    Else
                '        MsgBox(My.Resources.MsgReservado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                '    End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Autorizar una Nota de Debito. 
    '--                     :   Solo para ND con estado REGISTRADA 
    '-----------------------------------------------------------------------------------
    Private Sub AnularND()
        Dim T As New TransactionManager
        Dim IDTemp As Integer = 0
        Try
            Select Case MsgBox("¿Seguro que desea anular la nota de débito?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Me.Cursor = Cursors.WaitCursor

                    '-- Reservar Registro
                    ''  ReservarRegistro("SccNotaDebito", Me.IDND)

                    T.BeginTran()
                    IDTemp = Me.IDND
                    'objND.Retrieve(Me.IDND)
                    'objND.objEstadoID = Me.EstadoAnulada
                    'objND.Update(T)
                    'T.CommitTran()
                    CargarGridNotaDebito()
                    'For Each dr As DataRow In dtND.Rows
                    '    If dr("SccNotaDebitoID") = IDTemp Then
                    '        Me.grdND.Row = dtND.Rows.IndexOf(dr)
                    '        Exit For
                    '    End If
                    'Next
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            '' LiberarRegistro("SccNotaDebito", Me.IDND)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboración    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Buscar una Nota de Debito. 
    '-----------------------------------------------------------------------------------
    Private Sub tsbBuscarND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscarND.Click
        Dim objfrm As New frmSccParamBuscarNotaDebito
        Try
            Me.Cursor = Cursors.WaitCursor
            If blnBuscarND And dtND.Rows.Count > 0 Then
                objfrm.TipoCerosRelleno = CerosRellenoND
                If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    blnBusqueda = True
                    dtND = objfrm.TipodtND.Copy
                    CargarGridNotaDebito()
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Consultar una Nota de Debito. 
    '-----------------------------------------------------------------------------------
    Private Sub tsbConsultarND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultarND.Click
        Dim objfrm As New frmSccEditNotaDebito
        Try
            Me.Cursor = Cursors.WaitCursor
            If dtND.DefaultView.Count > 0 And blnConsultarND And dtND.Rows.Count > 0 Then
                objfrm.TypeGui = 2
                objfrm.IDNotaDebito = Me.IDND
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

    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Imprimir una Nota de Debito. 
    '--                     :   Solo para ND con Estado AUTORIZADA
    '-----------------------------------------------------------------------------------
    Private Sub tsbImprimirND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimirND.Click
        Dim objfrm As frmParamImpDestinoReporte
        Dim dtRpt As DataTable
        Try
            Me.Cursor = Cursors.WaitCursor
            If blnImprimirND And EstadoND = EstadoAutorizada Then
                objfrm = New frmParamImpDestinoReporte
                dtRpt = New DataTable
                ''   strSQL = clsConsultas.ObtenerNotaDebito(" * ", "SccNotaDebitoID=" & Me.IDND)
                dtRpt = SqlHelper.ExecuteQueryDT(strSQL)

                If dtRpt.Rows.Count > 0 Then
                    '-- Rellenar con Ceros el Codigo de la Nota de Debito a Mostrar
                    dtRpt.Rows(0).Item("Codigo") = RellenarConCeros(dtRpt.Rows(0).Item("Numero"), Me.CerosRellenoND)

                    '-- Concatenar los Datos del Cliente a mostrar
                    If IsDBNull(dtRpt.Rows(0).Item("RazonSocial")) Then
                        dtRpt.Rows(0).Item("DatosClienteRpt") = dtRpt.Rows(0).Item("CodigoCliente") & "  /    /  " & dtRpt.Rows(0).Item("Cliente")
                    Else
                        dtRpt.Rows(0).Item("DatosClienteRpt") = dtRpt.Rows(0).Item("CodigoCliente") & "  /  " & dtRpt.Rows(0).Item("RazonSocial") & "  /  " & dtRpt.Rows(0).Item("Cliente")
                    End If

                    '-- Concatenar los datos de la Sucursal a mostrar
                    dtRpt.Rows(0).Item("DatosSucursalRpt") = dtRpt.Rows(0).Item("CodigoSucursal") & "  /  " & dtRpt.Rows(0).Item("Sucursal")

                    '-- Concatenar los Datos de la Direccion de la Sucursal a mostrar
                    dtRpt.Rows(0).Item("DatosDireccionRpt") = dtRpt.Rows(0).Item("Direccion") & "  /  " & dtRpt.Rows(0).Item("Municipio") & "  /  " & dtRpt.Rows(0).Item("Departamento")

                    '-- Asignar el datatable al formulario de destino del reporte
                    objfrm.dtRpt = dtRpt.Copy

                    '-- Pasar el nombre del formulario de reporte al formulario de destino del reporte
                    objfrm.rptNombre = "rptSccNotaDebito"
                    If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        '*******************
                    End If
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboración    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Refrescar el grid
    '-----------------------------------------------------------------------------------
    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Try
            blnBusqueda = False
            CargarGridNotaDebito()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboración    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Salir Catalogo Nota de Debito.
    '-----------------------------------------------------------------------------------
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

#End Region

    Private Sub cmdDeshacerNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeshacerNota.Click
        Dim objCuentaPorCobrar As New SccCuentaPorCobrar
        Dim objCuentaDetalle As New SccCuentaPorCobrarDetalle
        Dim NotaDebito As New SccNotaDebito
        Dim T As New TransactionManager
        Dim FilaActual As Integer
        Try
            Try
                If Me.grdNDTabla.RowCount > 0 Then
                    Dim selectedRow As Integer() = grdNDTabla.GetSelectedRows()
                    FilaActual = Me.grdNDTabla.GetDataSourceRowIndex(selectedRow(0))

                    If Me.dtND.DefaultView.Item(FilaActual)("Estado") = "Autorizada" Then
                        T.BeginTran()
                        NotaDebito.Retrieve(Me.dtND.DefaultView.Item(FilaActual)("SccNotaDebitoID"))
                        objCuentaPorCobrar.Retrieve(NotaDebito.objSccCuentaID)

                        objCuentaDetalle.RetrieveByFilter("ObjSccCuentaID = '" & NotaDebito.objSccCuentaID & "'  AND objFacturaID =" & NotaDebito.objFacturaID.ToString)

                        objCuentaPorCobrar.Saldo = objCuentaPorCobrar.Saldo - Me.dtND.DefaultView.Item(FilaActual)("Monto")
                        objCuentaPorCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objCuentaPorCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuentaPorCobrar.Update(T)

                        objCuentaDetalle.Saldo = objCuentaDetalle.Saldo - Me.dtND.DefaultView.Item(FilaActual)("Monto")
                        objCuentaDetalle.SaldoND = objCuentaDetalle.SaldoND - Convert.ToDecimal(Me.dtND.DefaultView.Item(FilaActual)("Monto"))
                        objCuentaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objCuentaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuentaDetalle.Update(T)

                        SccNotaDebito.Delete(NotaDebito.SccNotaDebitoID, T)
                        T.CommitTran()
                        MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Me.CargarGridNotaDebito()
                    End If
                End If

            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objCuentaPorCobrar = Nothing
            objCuentaDetalle = Nothing
            NotaDebito = Nothing
        End Try

    End Sub

    Private Sub grdNDTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdNDTabla.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            If Me.grdNDTabla.RowCount > 0 Then

                Dim selectedRow As Integer() = grdNDTabla.GetSelectedRows()
                FilaActual = Me.grdNDTabla.GetDataSourceRowIndex(selectedRow(0))

                IDND = Me.dtND.DefaultView.Item(FilaActual)("SccNotaDebitoID")
                EstadoND = Me.dtND.DefaultView.Item(FilaActual)("objEstadoID")

                '-- Habilitar - Deshabilitar Opciones
                If blnModificarND And EstadoND = EstadoRegistrada Then
                    Me.tsbModificarND.Enabled = True
                Else
                    Me.tsbModificarND.Enabled = False
                End If
                If blnAutorizarND And EstadoND = EstadoRegistrada Then
                    Me.tsbAutorizarND.Enabled = True
                Else
                    Me.tsbAutorizarND.Enabled = False
                End If
                If blnAnularND And EstadoND = EstadoRegistrada Then
                    Me.tsbAnularND.Enabled = True
                Else
                    Me.tsbAnularND.Enabled = False
                End If
                If blnImprimirND And EstadoND = EstadoAutorizada Then
                    Me.tsbImprimirND.Enabled = True
                Else
                    Me.tsbImprimirND.Enabled = False
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class