'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Enrique Escobar Maradiaga.
''-- Fecha de Elaboración    : 02 Junio 2010.
''-- Formulario de Anulacion y Consulta de Cotización
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SIFAC.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid
Imports System.Windows.Forms.Cursors

Public Class frmSfaCotizacionAnular

#Region "Variables del formulario"
    Dim dtDescripcionCotizacion, dtDetalleCotizacion As DataTable
    Dim dsDetalleCotizacion As DataSet
    Dim dtDatosCliente As DataTable
    Dim dtExpedienteCxC As DataTable
    Dim dsExpedienteCxC As DataSet
    Dim boolModificado As Boolean

    Private m_TypeGui As Integer
    Private m_SfaCotizacionID As Integer
    Private m_NumeroCotizacion As String

    Dim strCodigoSucursal As String

#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            TypeGui = Me.m_TypeGui
        End Get
        Set(ByVal value As Integer)
            Me.m_TypeGui = value
        End Set
    End Property

    Property SfaCotizacionID() As Integer
        Get
            SfaCotizacionID = Me.m_SfaCotizacionID
        End Get
        Set(ByVal value As Integer)
            Me.m_SfaCotizacionID = value
        End Set
    End Property

    Property NumeroCotizacion() As String
        Get
            NumeroCotizacion = Me.m_NumeroCotizacion
        End Get
        Set(ByVal value As String)
            Me.m_NumeroCotizacion = value
        End Set
    End Property

#End Region

#Region "Inicializar Pantalla"

#Region "Inicializar GUI"
    Private Sub InicializarGui()
        Dim objSfaCotizacion As SfaCotizacion

        Select Case Me.TypeGui
            Case 1
                Me.Text = "Anular Cotización"
                Me.dtpFechaCotizacion.Enabled = False
                Me.NumValido.Enabled = False
                Me.txtNumCliente.Enabled = False
                Me.cmbCliente.Enabled = False
                Me.cmdConsultarCliente.Enabled = False
                Me.cmdAgregarCliente.Enabled = False
                Me.cmbTiempoEntrega.Enabled = False
                Me.cmbTerminoPago.Enabled = False
                Me.txtAtencionA.Enabled = False
                Me.cmbVendedor.Enabled = False
                Me.txtComentarios.Enabled = False

                'Grid Detalle Cotizacion
                Me.grdDetalleCotizacion.Splits(0).DisplayColumns(1).Locked = True
                grdDetalleCotizacion.Splits(0).DisplayColumns(2).Locked = True
                grdDetalleCotizacion.Splits(0).DisplayColumns(3).Locked = True
                grdDetalleCotizacion.Splits(0).DisplayColumns(4).Locked = True
                grdDetalleCotizacion.Splits(0).DisplayColumns(5).Locked = True
                Me.txtComentariosAnulacion.Focus()

            Case 2
                Me.Text = "Consultar Cotización"
                Me.dtpFechaCotizacion.Enabled = False
                Me.NumValido.Enabled = False
                Me.txtNumCliente.Enabled = False
                Me.cmbCliente.Enabled = False
                Me.cmdConsultarCliente.Enabled = False
                Me.cmdAgregarCliente.Enabled = False
                Me.cmbTiempoEntrega.Enabled = False
                Me.cmbTerminoPago.Enabled = False
                Me.txtAtencionA.Enabled = False
                Me.cmbVendedor.Enabled = False
                Me.txtComentariosAnulacion.Enabled = False
                Me.txtComentarios.Enabled = False

                'Grid Detalle Cotizacion
                Me.grdDetalleCotizacion.Splits(0).DisplayColumns(1).Locked = True
                grdDetalleCotizacion.Splits(0).DisplayColumns(2).Locked = True
                grdDetalleCotizacion.Splits(0).DisplayColumns(3).Locked = True
                grdDetalleCotizacion.Splits(0).DisplayColumns(4).Locked = True
                grdDetalleCotizacion.Splits(0).DisplayColumns(5).Locked = True
                Me.cmdGuardar.Enabled = False
        End Select

        strCodigoSucursal = clsProyecto.Sucursal
        LongitudesMaximas()
        CargarSucursal()
        CargarVendedor()
        CargarCliente()
        CargarTiempoEntrega()
        CargarTerminoPago()

        Select Case Me.TypeGui
            Case 1, 2
                objSfaCotizacion = New SfaCotizacion
                Try
                    objSfaCotizacion.SfaCotizacionID = Me.SfaCotizacionID
                    objSfaCotizacion.Retrieve(objSfaCotizacion.SfaCotizacionID)
                    Me.txtNumeroCotizacion.Text = objSfaCotizacion.SfaCotizacionID
                    Me.cmbSucursal.SelectedValue = objSfaCotizacion.objTiendaID
                    Me.dtpFechaCotizacion.Value = objSfaCotizacion.Fecha
                    Me.NumValido.Value = objSfaCotizacion.Valido
                    If Not String.IsNullOrEmpty(objSfaCotizacion.objClienteID) Then
                        Me.cmbCliente.SelectedValue = objSfaCotizacion.objClienteID
                    End If
                    Me.cmbTiempoEntrega.SelectedValue = objSfaCotizacion.objTiempoEntregaID
                    Me.cmbTerminoPago.SelectedValue = objSfaCotizacion.objTerminoPagoID
                    If Not IsDBNull(objSfaCotizacion.AtencionA) Then
                        Me.txtAtencionA.Text = objSfaCotizacion.AtencionA
                    End If
                    If objSfaCotizacion.objVendedorID.HasValue = True Then
                        Me.cmbVendedor.SelectedValue = objSfaCotizacion.objVendedorID
                    End If
                    If Not IsDBNull(objSfaCotizacion.ComentarioAnular) Then
                        Me.txtComentariosAnulacion.Text = objSfaCotizacion.ComentarioAnular
                    End If
                    Me.NumTasaCambio.Value = objSfaCotizacion.TasaCambio
                    Me.NumSubTotal.Value = objSfaCotizacion.Subtotal
                    Me.NumDescuento.Value = objSfaCotizacion.Descuento
                    Me.NumIVA.Value = objSfaCotizacion.Impuesto
                    Me.NumTotalCordobas.Value = objSfaCotizacion.TotalCordobas
                    Me.NumTotalDolares.Value = objSfaCotizacion.TotalDolares
                    If Not IsDBNull(objSfaCotizacion.Comentario) Then
                        Me.txtComentarios.Text = objSfaCotizacion.Comentario
                    End If

                Catch ex As Exception
                    clsError.CaptarError(ex)
                End Try
        End Select
        boolModificado = False
    End Sub
#End Region

#Region "Longitudes Maximas"

    Private Sub LongitudesMaximas()
        Me.txtAtencionA.MaxLength = SfaCotizacion.GetMaxLength("AtencionA")
        Me.txtComentarios.MaxLength = SfaCotizacion.GetMaxLength("Comentario")
        Me.txtComentariosAnulacion.MaxLength = SfaCotizacion.GetMaxLength("ComentarioAnular")
    End Sub

#End Region

#Region "Cargar Combos"

#Region "Sucursal"
    Private Sub CargarSucursal()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("Codigo=" & "'" & strCodigoSucursal & "'" & " AND ActivoRepuesto=1", "Codigo", "StbTiendaID, Nombre")
            If dtDatos.Rows.Count <> 0 Then
                With Me.cmbSucursal
                    .DataSource = dtDatos
                    .DisplayMember = "Nombre"
                    .ValueMember = "StbTiendaID"
                    .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                    .ExtendRightColumn = True
                    .SelectedIndex = 0
                    .ColumnHeaders = False
                End With
            Else
                MsgBox("La sucursal en sesión no está habilitada para repuestos", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.Close()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub

#End Region

#Region "Cliente"
    Private Sub CargarCliente()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,Cliente", "vwSfaClienteCotizacion", "1=1 ORDER BY Cliente"))
            With Me.cmbCliente
                .DataSource = dtDatos
                .DisplayMember = "Cliente"
                .ValueMember = "StbPersonaID"
                .Splits(0).DisplayColumns("StbPersonaID").Visible = False
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

#Region "Tiempo Entrega"
    Private Sub CargarTiempoEntrega()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "(objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIEMPOENTREGA'))"))
            With cmbTiempoEntrega
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .SelectedIndex = 0
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Término de pago"
    Private Sub CargarTerminoPago()
        Dim dtDatos As New DataTable
        Try
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TERMINOPAGO')"))
            With Me.cmbTerminoPago
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                'Validacion de acuerdo a la sucursal
                .SelectedIndex = 0
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Vendedor"
    Private Sub CargarVendedor()
        Dim dtDatos As New DataTable
        Dim login As String
        Try
            login = clsProyecto.Conexion.Usuario
            dtDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SrhEmpleadoID,Login,NombreEmpleado", "vwSfaVendedorCotizacion", "Login=" & "'" & clsProyecto.Conexion.Usuario & "'"))
            If dtDatos.DefaultView.Count > 0 Then
                With Me.cmbVendedor
                    .DataSource = dtDatos
                    .DisplayMember = "NombreEmpleado"
                    .ValueMember = "SrhEmpleadoID"
                    .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
                    .ExtendRightColumn = True
                    .SelectedIndex = 0
                    .ColumnHeaders = False
                End With
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#End Region

#End Region

#Region "Procedimientos"

#Region "Cargar Estructura del grid"

    Private Sub CargarDetalleEntradaBodega()
        Dim strCampos, strSQL, strFiltro As String
        Try
            strCampos = "objRepuestoID, objTipoRepuesto,CodigoBarras, CodigoRepuesto, DescripcionCorta, Cantidad, Precio, Subtotal, PorcentajeDescuento,Descuento, Impuesto, Total, Existencia,CostoProm,SfaCotizacionDetalleID"
            strFiltro = "objCotizacionID=" & Me.SfaCotizacionID.ToString & " ORDER BY objRepuestoID"
            strSQL = ObtenerConsultaGeneral(strCampos, "vwSfaCotizacionDetalleEditar", strFiltro)
            dtDetalleCotizacion = DAL.SqlHelper.ExecuteQueryDT(strSQL)
            dsDetalleCotizacion = New DataSet
            dsDetalleCotizacion.Merge(dtDetalleCotizacion)
            dsDetalleCotizacion.Tables(0).TableName = "vwSfaCotizacionDetalle"

            Me.grdDetalleCotizacion.SetDataBinding(dsDetalleCotizacion, "vwSfaCotizacionDetalle", True)
            dsDetalleCotizacion.Tables("vwSfaCotizacionDetalle").PrimaryKey = New DataColumn() {dsDetalleCotizacion.Tables("vwSfaCotizacionDetalle").Columns("objRepuestoID")}
            dsDetalleCotizacion.Tables("vwSfaCotizacionDetalle").DefaultView.Sort = "objRepuestoID"

            FormatearGrid(grdDetalleCotizacion, "Maestro")
            FormatearGrid(grdDatosExpediente, "Expediente")

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Formatear Grid"

    Private Sub FormatearGrid(ByVal Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal Tipo As String)
        Grid.FilterBar = False
        Grid.VisualStyle = VisualStyle.Office2007Black
        Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Grid.EmptyRows = False

        If (Tipo = "Maestro") Then
            Grid.AllowAddNew = True
            Grid.AllowDelete = True
            Grid.Splits(0).DisplayColumns("objRepuestoID").Visible = False
            Grid.Splits(0).DisplayColumns("objTipoRepuesto").Visible = False
            Grid.Splits(0).DisplayColumns("Existencia").Visible = False
            Grid.Splits(0).DisplayColumns("CostoProm").Visible = False
            Grid.Splits(0).DisplayColumns("SfaCotizacionDetalleID").Visible = False

            Grid.Splits(0).DisplayColumns("Precio U.").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Precio U.").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Subtotal").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Subtotal").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Descuento").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Descuento").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("% Desc.").Locked = True
            Grid.Splits(0).DisplayColumns("% Desc.").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("IVA").AllowFocus = False
            Grid.Splits(0).DisplayColumns("IVA").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Total").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Total").Style.BackColor = Color.LemonChiffon

        Else
            Grid.Splits(0).DisplayColumns("Numero").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Numero").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Moto").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Moto").Style.BackColor = Color.LemonChiffon

            Grid.Splits(0).DisplayColumns("Saldo").AllowFocus = False
            Grid.Splits(0).DisplayColumns("Saldo").Style.BackColor = Color.LemonChiffon
            Grid.Splits(0).DisplayColumns("Saldo").Locked = True

        End If

    End Sub

#End Region

#Region "Cargar Datos del Cliente"

    Private Sub CargarDatosCliente(ByVal strFiltroCliente As String)
        dtDatosCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,Telefonos, Emails, Direccion,Exonerado", "vwSfaClienteCotizacion", "StbPersonaID=" & "'" & strFiltroCliente & "'"))

        If dtDatosCliente.DefaultView.Count > 0 Then
            Me.txtNumCliente.Text = dtDatosCliente.DefaultView.Item(0)("StbPersonaID")
            Me.cmbCliente.SelectedValue = dtDatosCliente.DefaultView.Item(0)("StbPersonaID")
            If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("Telefonos")) Then
                Me.txtTelefonos.Text = dtDatosCliente.DefaultView.Item(0)("Telefonos")
            Else
                Me.txtTelefonos.Text = "No definido"
            End If
            If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("Emails")) Then
                Me.txtEmails.Text = dtDatosCliente.DefaultView.Item(0)("Emails")
            Else
                Me.txtEmails.Text = "No definido"
            End If
            If Not IsDBNull(dtDatosCliente.DefaultView.Item(0)("Direccion")) Then
                Me.txtDireccion.Text = dtDatosCliente.DefaultView.Item(0)("Direccion")
            Else
                Me.txtDireccion.Text = "No definido"
            End If
            Me.chkExonerado.Checked = dtDatosCliente.DefaultView.Item(0)("Exonerado")
        Else
            Me.txtNumCliente.Text = ""
            Me.cmbCliente.SelectedIndex = -1
            Me.txtTelefonos.Text = ""
            Me.txtEmails.Text = ""
            Me.txtDireccion.Text = ""
            Me.chkExonerado.Checked = False
        End If
    End Sub

    Private Sub CargarExpedienteCxCCliente(ByVal strFiltroCliente As String)
        Try
            dtExpedienteCxC = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Numero, Moto, Saldo", "vwSfaExpCxCCotizacion", "objClienteID=" & "'" & strFiltroCliente & "'"))
            dsExpedienteCxC = New DataSet
            dsExpedienteCxC.Merge(dtExpedienteCxC)
            dsExpedienteCxC.Tables(0).TableName = "vwSfaExpCxCCotizacion"
            Me.grdDatosExpediente.SetDataBinding(dsExpedienteCxC, "vwSfaExpCxCCotizacion", True)
            dsExpedienteCxC.Tables("vwSfaExpCxCCotizacion").DefaultView.Sort = "Numero"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar Entrada"
    Private Function AgregarCotizacion() As Boolean
        Dim T As New TransactionManager
        Try
            Try
                T.BeginTran()

                Me.GuardarCotizacion(T)
                Me.GuardarCotizacionDetalle(T)

                boolModificado = False
                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            T = Nothing
        End Try
    End Function

    Private Sub GuardarCotizacion(ByVal T As DAL.TransactionManager)
        Dim objSfaCotizacion As SfaCotizacion
        Try
            objSfaCotizacion = New SfaCotizacion
            objSfaCotizacion.SfaCotizacionID = Me.SfaCotizacionID
            objSfaCotizacion.Retrieve(objSfaCotizacion.SfaCotizacionID, T)
            objSfaCotizacion.Anulada = True
            objSfaCotizacion.ComentarioAnular = Me.txtComentariosAnulacion.Text.Trim
            objSfaCotizacion.Subtotal = 0
            objSfaCotizacion.Descuento = 0
            objSfaCotizacion.Impuesto = 0
            objSfaCotizacion.TotalDolares = 0
            objSfaCotizacion.TotalCordobas = 0
            objSfaCotizacion.Update(T)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarCotizacionDetalle(ByVal T As DAL.TransactionManager)
        Dim objSfaCotizacionDetalle As SfaCotizacionDetalle
        Try
            objSfaCotizacionDetalle = New SfaCotizacionDetalle
            For I As Integer = 0 To Me.grdDetalleCotizacion.RowCount - 1
                objSfaCotizacionDetalle.SfaCotizacionDetalleID = Me.grdDetalleCotizacion.Item(I)("SfaCotizacionDetalleID")
                objSfaCotizacionDetalle.Retrieve(objSfaCotizacionDetalle.SfaCotizacionDetalleID, T)
                objSfaCotizacionDetalle.Cantidad = 0
                objSfaCotizacionDetalle.Subtotal = 0
                objSfaCotizacionDetalle.Descuento = 0
                objSfaCotizacionDetalle.Impuesto = 0
                objSfaCotizacionDetalle.Total = 0
                objSfaCotizacionDetalle.Update(T)
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Validaciones de datos"

#Region "Entrada Datos"
    Private Function Validaciones() As Boolean
        Try
            If Me.txtComentariosAnulacion.Text.Trim = "" Then
                Me.ErrorProvider.SetError(txtComentariosAnulacion, My.Resources.MsgObligatorio)
                Return False
                txtComentariosAnulacion.Focus()
                Exit Function
            End If
            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#End Region

#End Region

#Region "Eventos del formulario"

#Region "Pantalla"

    Private Sub frmSivEntradaBodegaEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarDetalleEntradaBodega()
        Me.InicializarGui()
        Select Case Me.TypeGui
            Case 1
                Me.txtComentariosAnulacion.Text = ""
        End Select

        
    End Sub

    Private Sub frmSivEntradaBodegaEditar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.boolModificado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

#End Region

#Region "Combo Box"
    Private Sub cmbCliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedValueChanged
        If Me.cmbCliente.SelectedIndex = -1 Then
            Exit Sub
        End If
        CargarDatosCliente(Me.cmbCliente.SelectedValue.ToString)
        CargarExpedienteCxCCliente(Me.cmbCliente.SelectedValue.ToString)
    End Sub
#End Region

#Region "Grid"
    Private Sub grdDetalleCotizacion_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdDetalleCotizacion.RowColChange
        Me.NumExistencia.Value = Me.grdDetalleCotizacion.Columns("Existencia").Value
    End Sub
#End Region

#Region "TextBox"
    Private Sub txtComentariosAnulacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComentariosAnulacion.KeyPress
        ErrorProvider.SetError(txtComentariosAnulacion, "")
        boolModificado = True
    End Sub
#End Region

#Region "Botones"
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.Validaciones Then
            If Me.AgregarCotizacion Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

#End Region

#End Region

End Class