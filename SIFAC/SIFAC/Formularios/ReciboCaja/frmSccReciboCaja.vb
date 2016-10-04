Imports DAL
Imports Proyecto.Catalogos.Datos
Imports Proyecto.Configuracion
Imports SIFAC.BO
Imports Seguridad.Datos
Imports C1.C1Excel

''' <summary>
''' Formulario principal de Recibos de Caja.
''' Autor : Pedro Pablo Tinoco Salgado.
''' Fecha : 24 de Marzo de 2009.
''' </summary>
''' <remarks></remarks>
Public Class frmSccReciboCaja
    Dim DtRecibosCajas As New DataTable
    Dim m_IDReciboCaja, m_Exportar, IdExportar As Integer
    Dim SqlParametros(7) As SqlClient.SqlParameter
    Dim m_blnAprobar As Boolean

    Property IDReciboCaja() As Integer
        Get
            IDReciboCaja = m_IDReciboCaja
        End Get
        Set(ByVal value As Integer)
            m_IDReciboCaja = value
        End Set
    End Property

    Property Exportar() As Integer
        Get
            Exportar = m_Exportar
        End Get
        Set(ByVal value As Integer)
            m_Exportar = value
        End Set
    End Property

    Property blnAprobar()
        Get
            blnAprobar = Me.m_blnAprobar
        End Get
        Set(ByVal value)
            Me.m_blnAprobar = value
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento encargado de cargar los datos correspondientes a los recibos de cajas.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 24 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        'Dim strConsulta As String = ""
        Dim DiasRecibosRecientes As Integer
        Try
            DiasRecibosRecientes = StbParametro.RetrieveDT("Nombre = 'CantidadRecibosRecientes'", , "Valor").DefaultView.Item(0)("Valor")
            'strConsulta = clsConsultas.ObtenerConsultaGeneral("*", "vwSccRecibodetFactura,vwSccReciboCaja", "vwSccReciboDetFactura.objSccCuentaID = vwSccReciboCaja.SccCuentaID AND vwSccReciboCaja.Fecha BETWEEN GETDATE()-" & DiasRecibosRecientes + 1 & " AND GETDATE()")
            Me.DtRecibosCajas = SqlHelper.ExecuteQueryDT("SELECT Fecha, Numero, SccReciboCajaID, TotalRecibo,objEstadoId, EsPagoPrima, SccCuentaID,objClienteId, Cliente, Estado, NumeroRecibo, StbPersonaID FROM vwSccReciboCaja WHERE Fecha BETWEEN GETDATE()-366 AND GETDATE()")
            'Me.DtRecibosCajas = SqlHelper.ExecuteQueryDT(strConsulta)
            'Me.DtRecibosCajas.PrimaryKey = New DataColumn() {DtRecibosCajas.Columns("SccReciboCajaID")}
            Me.DtRecibosCajas.DefaultView.Sort = "SccReciboCajaID"
            Me.grdRecibosCaja.SetDataBinding(Me.DtRecibosCajas, "", True)
            Me.grdRecibosCaja.Splits(0).DisplayColumns("SccReciboCajaID").Visible = False
            Me.grdRecibosCaja.Splits(0).DisplayColumns("objEstadoID").Visible = False
            Me.grdRecibosCaja.Caption = "Recibos de Caja(" & Me.grdRecibosCaja.RowCount.ToString & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#Region "Eventos"
    Private Sub frmSccReciboCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarDatos()
        clsProyecto.CargarTemaDefinido(Me)
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim objRecibo As frmSccEditReciboCaja
        objRecibo = New frmSccEditReciboCaja
        objRecibo.TypGui = 0
        If objRecibo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.CargarDatos()
            Me.grdRecibosCaja.Row = Me.DtRecibosCajas.DefaultView.Find(objRecibo.ReciboCajaID)
        End If
    End Sub
#End Region


#Region "Metodos"

    ''' <summary>
    ''' Procedimiento Encargado de aplicar la Seguridad.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' FechaCreacion : 24 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmSccReciboCaja"
            Me.cmdAgregar.Enabled = objSeg.TienePermiso("AgregarRoc")
            Me.cmdEditar.Enabled = objSeg.TienePermiso("EditarRoc")
            Me.cmdConsultar.Enabled = objSeg.TienePermiso("ConsultarRoc")
            Me.blnAprobar = objSeg.TienePermiso("ProcesarRoc")
            Me.cmdAprobar.Enabled = Me.blnAprobar
            Me.CMDBuscarReciboCaja.Enabled = objSeg.TienePermiso("BuscarRoc")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


#End Region

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Me.CargarDatos()
        Me.grdRecibosCaja.Caption = "Recibos de Caja(" & Me.grdRecibosCaja.RowCount.ToString & ")"
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Try

            If Me.grdRecibosCaja.RowCount > 0 Then
                Dim IDEstadoPagado As Integer
                IDEstadoPagado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "PAGADO")

                If Me.grdRecibosCaja.Columns("objEstadoID").Value.ToString.Trim.Length <> 0 Then
                    If Me.grdRecibosCaja.Columns("objEstadoID").Value = IDEstadoPagado Then
                        MsgBox("Solamente Recibos de caja en estado REGISTRADO pueden ser Editados", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                Else
                    MsgBox("No ha sido posible cargar el Identificador de estado (objEstadoID) del Recibo.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                Dim objRecibo As frmSccEditReciboCaja
                objRecibo = New frmSccEditReciboCaja
                objRecibo.TypGui = 1
                objRecibo.ReciboCajaID = Me.grdRecibosCaja.Columns("SccReciboCajaID").Value
                If objRecibo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarDatos()
                    Me.DtRecibosCajas.DefaultView.Find(objRecibo.ReciboCajaID)
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub



    Private Sub cmdAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAprobar.Click
        Try
        
            If Me.grdRecibosCaja.RowCount > 0 Then
                Dim IDEstadoPagado As Integer
                IDEstadoPagado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "PAGADO")

                If Me.grdRecibosCaja.Columns("objEstadoID").Value = IDEstadoPagado Then
                    MsgBox("Solamente Recibos de caja en estado REGISTRADO pueden ser Procesados", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
                Select Case MsgBox("¿Esta seguro de Procesar el Recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        If Me.grdRecibosCaja.Columns("objEstadoID").Value = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "REGISTRADO") Then
                            Me.PROCESAR_RECIBO(0, 0)
                        Else
                            MsgBox("El Recibo ha sido procesado exitosamente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        End If
                    Case MsgBoxResult.No
                        Exit Sub
                End Select

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

#Region "Procesamiento de Recibos"
    '------------------------------------------------------------------------------------------------------------
    ' Autor          : Pedro Pablo Tinoco Salgado.
    ' Fecha Creacion : 14 de diciembre de 2007.
    ' Descripcion    : Esta funcion se encarga de realizar el procesamiento de los datos una vez que se haya guardado.
    '------------------------------------------------------------------------------------------------------------
    Private Sub PROCESAR_RECIBO(ByVal IntIDReciboCaja As Integer, ByVal IntOpcion As Integer)
        Dim parametro(3) As SqlClient.SqlParameter
        Dim T As New TransactionManager
        Dim objNotCredito As SccNotaCredito
        Dim objReciboCaja As New SccReciboCaja
        Dim EsPrima As Boolean
        Dim IDReciboCaja As Integer

        Try

            objNotCredito = New SccNotaCredito
            T.BeginTran()
            IDReciboCaja = Me.grdRecibosCaja.Columns("SccReciboCajaID").Value
            parametro(0) = New SqlClient.SqlParameter("@IntReciboCajaID", SqlDbType.Int, 4)
            parametro(0).Value = IDReciboCaja

            parametro(1) = New SqlClient.SqlParameter("@EsPrima", SqlDbType.Int, 4)
            parametro(2) = New SqlClient.SqlParameter("@MontoPrima", SqlDbType.Decimal)
            EsPrima = SccReciboCaja.RetrieveDT("SccReciboCajaID=" & parametro(0).Value.ToString, , "EsPagoPrima").DefaultView.Item(0)("EsPagoPrima")

            objReciboCaja.Retrieve(IDReciboCaja, T)

            objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "PAGADO")
            objReciboCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objReciboCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objReciboCaja.Update(T)

            If EsPrima Then
                parametro(1).Value = 1
                parametro(2).Value = objReciboCaja.TotalRecibo
            Else
                parametro(1).Value = 0
            End If
            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_SfaDimininuirCuentaPorCobrar", parametro)

            T.CommitTran()
            MsgBox("El Recibo ha sido Procesado Exitosamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Me.CargarDatos()
            Me.DtRecibosCajas.DefaultView.Find(IDReciboCaja)
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing
            T = Nothing
            objNotCredito = Nothing
        End Try
    End Sub

#End Region

#Region "Consulta de Recibo de Cajas"
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        If Me.grdRecibosCaja.RowCount > 0 Then
            Dim objRecibo As frmSccEditReciboCaja
            objRecibo = New frmSccEditReciboCaja
            objRecibo.TypGui = 2
            objRecibo.ReciboCajaID = Me.grdRecibosCaja.Columns("SccReciboCajaID").Value
            If objRecibo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarDatos()
                Me.DtRecibosCajas.DefaultView.Find(objRecibo.ReciboCajaID)
            End If
        End If
    End Sub
#End Region

    Private Sub grdRecibosCaja_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdRecibosCaja.FilterChange
        Me.grdRecibosCaja.Caption = "Recibos de Caja(" & Me.grdRecibosCaja.RowCount.ToString & ")"
        Me.ConfigurarBotonAutorizar()
    End Sub

    Private Sub BuscarReciboCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBuscarReciboCaja.Click
        Me.BucarRecibos()
    End Sub

    Private Sub BucarRecibos()
        Dim objRecibo As New frmSccBuscarRecibo
        Try
            If objRecibo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.SqlParametros = objRecibo.Parametros
                Me.Exportar = objRecibo.EjecutarImportacion
                Me.CargarDatosFiltro(objRecibo.StrFiltro)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarDatosFiltro(ByVal Filtro As String)
        Dim strConsulta As String
        Dim Filtro2 As String
        Try
            Filtro2 = "vwSccReciboDetFactura.objSccCuentaID = vwSccReciboCaja.SccCuentaID AND " & Filtro
            strConsulta = clsConsultas.ObtenerConsultaGeneral("distinct vwSccReciboCaja.Fecha, vwSccReciboCaja.Numero, vwSccReciboCaja.SccReciboCajaID, vwSccReciboCaja.TotalRecibo,vwSccReciboCaja.objEstadoId, vwSccReciboCaja.esPagoPrima, vwSccReciboCaja.SccCuentaID, vwSccReciboCaja.objClienteId, vwSccReciboCaja.Cliente, vwSccReciboCaja.Estado, vwSccReciboCaja.NumeroRecibo, vwSccReciboCaja.StbPersonaID", "vwSccRecibodetFactura, vwSccReciboCaja", Filtro2)
            Me.DtRecibosCajas = SqlHelper.ExecuteQueryDT(strConsulta, Me.SqlParametros)
            Me.DtRecibosCajas.DefaultView.Sort = "SccReciboCajaID"
            Me.grdRecibosCaja.SetDataBinding(Me.DtRecibosCajas, "", True)
            Me.grdRecibosCaja.Splits(0).DisplayColumns("SccReciboCajaID").Visible = False
            Me.grdRecibosCaja.Splits(0).DisplayColumns("objEstadoID").Visible = False
            Me.grdRecibosCaja.Caption = "Recibos de Caja(" & Me.grdRecibosCaja.RowCount.ToString & ")"
            If Me.Exportar = 10 Then
                Me.ExportacionExcel()
            End If
            If Me.DtRecibosCajas.DefaultView.Count = 0 Then
                MsgBox(My.Resources.MsgBusqueda, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#Region "Exportar Recibos de Caja a Excel"
    Private Sub ExportacionExcel()

        Dim libroExcel As New C1.C1Excel.C1XLBook
        Dim hojaExcel As C1.C1Excel.XLSheet
        Dim i As Integer = 0
        Dim fechaReporte As String = Convert.ToString(clsProyecto.Conexion.FechaServidor)        
        Dim estilo As New C1.C1Excel.XLStyle(libroExcel)
        estilo.BackColor = Color.LightGreen
        Try            

            hojaExcel = libroExcel.Sheets(0)
            hojaExcel(0, 0).Value = "SccReciboCajaID"
            hojaExcel(0, 0).Style = estilo
            hojaExcel(0, 1).Value = "Número"
            hojaExcel(0, 1).Style = estilo
            hojaExcel(0, 2).Value = "No. Expediente"
            hojaExcel(0, 2).Style = estilo
            hojaExcel(0, 3).Value = "Monto"
            hojaExcel(0, 3).Style = estilo
            hojaExcel(0, 4).Value = "Fecha"
            hojaExcel(0, 4).Style = estilo
            hojaExcel(0, 5).Value = "Cliente"
            hojaExcel(0, 5).Style = estilo
            hojaExcel(0, 6).Value = "Estado"
            hojaExcel(0, 6).Style = estilo

            For Each dr As DataRow In DtRecibosCajas.Rows
                i = i + 1
                hojaExcel(i, 0).Value = dr("SccReciboCajaID")
                hojaExcel(i, 1).Value = dr("Numero")
                hojaExcel(i, 2).Value = dr("SccCuentaID")
                hojaExcel(i, 3).Value = dr("TotalRecibo")
                hojaExcel(i, 4).Value = Convert.ToString(dr("Fecha"))
                hojaExcel(i, 5).Value = dr("Cliente")
                hojaExcel(i, 6).Value = dr("Estado")
            Next

            If objUbicacion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                libroExcel.Save(objUbicacion.FileName + ".xls")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region

    Private Sub grdRecibosCaja_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdRecibosCaja.RowColChange
        Me.ConfigurarBotonAutorizar()
    End Sub

    Private Sub ConfigurarBotonAutorizar()
        If Not Me.grdRecibosCaja.Columns("Estado").Value = "Pagado" Then
            Me.cmdAprobar.Enabled = Me.blnAprobar
        Else
            Me.cmdAprobar.Enabled = False
        End If
    End Sub

End Class