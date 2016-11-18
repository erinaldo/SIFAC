Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports Proyecto.Catalogos.Datos

''' <summary>
''' Formulario principal de registro de facturas.
''' Autor : Pedro Pablo Tinoco Salgado.
''' Fecha de Creacion : 20 de Marzo de 2009.
''' </summary>
''' <remarks></remarks>
Public Class frmSfaFactura
    Dim dtDatosFact As New DataTable

    Private Sub CargarDatos()
        Dim strConsulta As String
        Dim FacturasRecientes As Integer
        Try
            FacturasRecientes = StbParametro.RetrieveDT("Nombre = 'DiasFacturasRecientes'", , "Valor").DefaultView.Item(0)("Valor")
            strConsulta = clsConsultas.ObtenerConsultaGeneral("*,ISNULL(MontoCredito,0) - ISNULL(MontoPrima,0) as Financiamiento", "vwFacturas", " Fecha BETWEEN GETDATE()-" & FacturasRecientes + 1 & " AND GETDATE()")
            dtDatosFact = SqlHelper.ExecuteQueryDT(strConsulta)
            Me.dtDatosFact.PrimaryKey = New DataColumn() {Me.dtDatosFact.Columns("SfaFacturaID")}
            Me.dtDatosFact.DefaultView.Sort = "SfaFacturaID"
            Me.grdFacturas.DataSource = dtDatosFact
          
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSfaFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.CargarDatos()
        Me.Seguridad()

    End Sub


    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Me.CargarFacturas(0)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Me.CargarDatos()
    End Sub

    ''' <summary>
    ''' Carga de Facturas correspondientes
    ''' en sus distintos Modos.
    ''' </summary>
    ''' <param name="IntOpcion"></param>
    ''' <remarks></remarks>
    Private Sub CargarFacturas(ByVal IntOpcion As Integer)
        Dim objFacturaEdit As New frmSfaFaturaEditar
        Dim objDetalleCuentas As New SccCuentaPorCobrarDetalle
        Dim IDEstadoReg As Integer
        Dim EstadoActual As Integer
        Dim FilaActual As Integer
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim selectedRow As Integer() = grdFacturasTabla.GetSelectedRows()
                FilaActual = Me.grdFacturasTabla.GetDataSourceRowIndex(selectedRow(0))

                objFacturaEdit.TypGui = 0
                If IntOpcion > 0 Then
                    If IntOpcion = 1 Then
                        IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
                        objDetalleCuentas.Retrieve(Me.dtDatosFact.DefaultView.Item(FilaActual)("SccCuentaPorCobrarDetalleID"))
                        EstadoActual = objDetalleCuentas.objEstadoID

                        If EstadoActual <> IDEstadoReg Then
                            MsgBox("Solamente Expedientes de Factura en Estado Registrada pueden ser Editadas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        End If
                    End If

                    objFacturaEdit.IDFactura = Me.dtDatosFact.DefaultView.Item(FilaActual)("SfaFacturaID")
                    objFacturaEdit.TypGui = IntOpcion
                End If
                If objFacturaEdit.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarDatos()
                    'Me.grdFacturas.Row = Me.dtDatosFact.DefaultView.Find(objFacturaEdit.IDFactura)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objDetalleCuentas = Nothing
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarFactura.Click
        If Me.dtDatosFact.Rows.Count > 0 Then
            Me.CargarFacturas(1)
        End If
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        If Me.dtDatosFact.Rows.Count > 0 Then
            Me.CargarFacturas(2)
        End If
    End Sub

#Region "Procesar Factura"
    'Private Sub ProcesarFactura(ByVal IDFactura As Integer)
    '    Dim objFact As New SfaFactura
    '    Dim T As New TransactionManager
    '    Try
    '        T.BeginTran()
    '        objFact.Retrieve(IDFactura)
    '        objFact.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOFACT", "PROCESADA")
    '        objFact.UsuarioModificacion = clsProyecto.Conexion.Usuario
    '        objFact.FechaModificacion = clsProyecto.Conexion.FechaServidor
    '        objFact.Update(T)
    '        T.CommitTran()
    '    Catch ex As Exception
    '        T.RollbackTran()
    '        clsError.CaptarError(ex)
    '    End Try
    'End Sub
#End Region

    Private Sub cmdProcesarExpedienteFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesarExpedienteFact.Click
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdFacturasTabla.FocusedRowHandle
            If Me.dtDatosFact.Rows.Count > 0 Then
                Me.ProcesarExpedienteFact(Me.dtDatosFact.DefaultView.Item(FilaActual)("SccCuentaPorCobrarDetalleID"))
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        
    End Sub

#Region "Procesar Factura"
    ''' <summary>
    ''' Procedimiento Encargado de Establecer el Detalle de Factura como Procesado.
    ''' </summary>
    ''' <param name="IDDetalleFact"></param>
    ''' <remarks></remarks>
    Private Sub ProcesarExpedienteFact(ByVal IDDetalleFact As Integer)
        Dim objDetalleFact As New SccCuentaPorCobrarDetalle
        Dim Credito As Decimal
        Dim IDEstadoReg As Integer      
        Dim IDCuenta As String
        Dim T As New TransactionManager
        Dim EstadoActual As Integer
        Dim IDFactura As Integer
        Dim objNotaCredito As New SccNotaCredito
        Dim BoolNC As Boolean = False
        Dim objSccCuentaCobrar As New SccCuentaPorCobrar
        Dim MontoPrima As Decimal
        Dim MontoTotal As Decimal

        Try
            Try
                T.BeginTran()
                IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
                objDetalleFact.Retrieve(IDDetalleFact, T)
                IDCuenta = objDetalleFact.objSccCuentaID
                EstadoActual = objDetalleFact.objEstadoID
                If IDEstadoReg <> EstadoActual Then
                    MsgBox("Solamente Expedientes de Facturas en Estado Registrada puede ser Procesadas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    T.RollbackTran()
                    Exit Sub
                End If

                'If objDetalleFact.MontoPrima.HasValue Then
                '    Credito = objDetalleFact.MontoTotal - objDetalleFact.MontoPrima
                'Else
                '    Credito = objDetalleFact.MontoTotal
                'End If

                objSccCuentaCobrar.Retrieve(IDCuenta, T)


                'MontoPrima = SccCuentaPorCobrarDetalle.RetrieveDT("SccCuentaPorCobrarDetalleID = '" & IDDetalleFact & "' AND objEstadoID <>" & IDEstadoReg.ToString, , "isnull(SUM(ISNULL(MontoPrima,0.0)),0.0) AS Monto", T).DefaultView.Item(0)("Monto")
                'MontoTotal = SccCuentaPorCobrarDetalle.RetrieveDT("SccCuentaPorCobrarDetalleID = '" & IDDetalleFact & "' AND objEstadoID <>" & IDEstadoReg.ToString, , "isnull(SUM(isnull(MontoTotal,0.0)),0.0) as Monto", T).DefaultView.Item(0)("Monto")

                'MontoTotal = MontoTotal - MontoPrima

                'If Credito > MontoTotal Then
                '    T.RollbackTran()
                '    MsgBox("La adici�n de este Monto al expediente excede el Limite de Cr�dito", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)

                '    Exit Sub
                'Else
                objDetalleFact.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objDetalleFact.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objDetalleFact.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")
                objDetalleFact.Update(T)

                IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "REGISTRADO")

                If objSccCuentaCobrar.objEstadoID.Value = IDEstadoReg Then
                    objSccCuentaCobrar.Saldo = objSccCuentaCobrar.Saldo + objDetalleFact.MontoTotal
                    objSccCuentaCobrar.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "VIGENTE")
                    objSccCuentaCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSccCuentaCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSccCuentaCobrar.Update(T)
                End If

                'End If   
                T.CommitTran()
                MsgBox("Factura procesada Exitosamente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                'If BoolNC Then
                '    MsgBox("Se ha generado una Nota de Cr�dito por D�bito Autom�tico.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                'End If
                Me.CargarDatos()
                'Me.grdFacturas.Row = Me.dtDatosFact.DefaultView.Find(IDFactura)
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Catch ex As Exception
            T = Nothing
            objDetalleFact = Nothing
            objNotaCredito = Nothing
            objSccCuentaCobrar = Nothing
        End Try
    End Sub
#End Region

#Region "Anular Expediente"
    ''' <summary>
    ''' Procedimiento Encargado de Anular un Expediente de Factura en Estado Registrado.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha Creacion : 30 de Marzo de 2009.
    ''' </summary>
    ''' <param name="IDDetalleCuentas"></param>
    ''' <remarks></remarks>
    Private Sub AnularExpediente(ByVal IDDetalleCuentas As Integer)
        Dim objDetalleCuentas As New SccCuentaPorCobrarDetalle
        Dim IDFactura As Integer
        Dim T As New TransactionManager
        Dim IDEstadoReg As Integer
        Dim EstadoActual As Integer
        Try
            Try
                T.BeginTran()
                IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
                objDetalleCuentas.Retrieve(IDDetalleCuentas)
                IDFactura = objDetalleCuentas.objSfaFacturaID
                EstadoActual = objDetalleCuentas.objEstadoID

                If EstadoActual <> IDEstadoReg Then
                    MsgBox("Solamente Expedientes de Factura en Estado Registrada pueden ser Anuladas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    T.RollbackTran()
                    Exit Sub
                End If
                SccCuentaPorCobrarDetalle.Delete(IDDetalleCuentas)
                SfaFacturasDetalle.DeleteByFilter(String.Format("objSfaFacturaID={0}", IDFactura))
                SfaFacturas.Delete(IDFactura)
                T.CommitTran()
                MsgBox("Anulaci�n de Expediente Exitosa", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.CargarDatos()
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            T = Nothing
            objDetalleCuentas = Nothing
        End Try
    End Sub
#End Region

    Private Sub cmdAnularFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnularFactura.Click
        Dim FilaActual As Integer
        Try
            If Me.dtDatosFact.Rows.Count > 0 Then
                FilaActual = Me.grdFacturasTabla.FocusedRowHandle
                Me.AnularExpediente((Me.dtDatosFact.DefaultView.Item(FilaActual)("SccCuentaPorCobrarDetalleID")))
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmdNuevaFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaFecha.Click
        Try
            If Me.dtDatosFact.Rows.Count > 0 Then
                Me.CargarFacturas(3)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        
    End Sub


    Private Sub Seguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "frmSfaFacturasXCuenta"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            Me.cmdAgregar.Enabled = objSeg.TienePermiso("AgregarFact")
            Me.cmdEditarFactura.Enabled = objSeg.TienePermiso("EditarFact")
            Me.cmdProcesarExpedienteFact.Enabled = objSeg.TienePermiso("ProcesarFact")
            Me.cmdNuevaFecha.Enabled = objSeg.TienePermiso("DesplazarFact")
            Me.cmdAnularFactura.Enabled = objSeg.TienePermiso("AnularFact")
            Me.cmdConsultar.Enabled = objSeg.TienePermiso("ConsultarFact")
            Me.cmdBuscar.Enabled = objSeg.TienePermiso("BuscarFact")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim objBusquedaFact As New frmSfaBuscarFacturaExp
        Dim strconsulta As String
        Try
            If objBusquedaFact.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dtDatosFact.Reset()
                strconsulta = clsConsultas.ObtenerConsultaGeneral("*,MontoCredito - ISNULL(MontoPrima,0) as Financiamiento", "vwFacturas", objBusquedaFact.strFiltro)
                dtDatosFact = SqlHelper.ExecuteQueryDT(strconsulta, objBusquedaFact.Parametros)
                'Me.dtDatosFact.PrimaryKey = New DataColumn() {Me.dtDatosFact.Columns("SfaFacturaID")}
                'Me.dtDatosFact.DefaultView.Sort = "SfaFacturaID"
                Me.grdFacturas.DataSource = dtDatosFact
                'Me.grdFacturas.Splits(0).DisplayColumns("SfaFacturaID").Visible = False
                If dtDatosFact.DefaultView.Count = 0 Then
                    MsgBox("Su B�squeda no tiene resultados a mostrar", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
                'Me.grdFacturas.Caption = "Facturas(" & Me.grdFacturas.RowCount.ToString & ")"
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

   
End Class