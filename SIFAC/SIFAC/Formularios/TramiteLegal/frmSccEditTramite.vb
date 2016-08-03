'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 26 Marzo 2010. 08:12 AM.
''--    Formulario de Edición y Modificación de Trámites legales.
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles

Public Class frmSccEditTramiteLegal
    Dim m_IDTramite As Integer
    Dim m_IDCuenta As String
    Dim m_TypeGui As Integer
    Dim DtDatosCuenta As DataTable
    Dim dtDatosTramiteLegal As DataTable
    Dim m_BoolGuardado As Boolean

#Region "Propiedades"
    Property BoolGuardado() As Boolean
        Get
            BoolGuardado = Me.m_BoolGuardado
        End Get
        Set(ByVal value As Boolean)
            Me.m_BoolGuardado = value
        End Set
    End Property

    Property TypeGui() As Integer
        Get
            TypeGui = m_TypeGui
        End Get
        Set(ByVal value As Integer)
            m_TypeGui = value
        End Set
    End Property

    Property IDTramite() As Integer
        Get
            IDTramite = m_IDTramite
        End Get
        Set(ByVal value As Integer)
            m_IDTramite = value
        End Set
    End Property

    Property IDCuenta() As String
        Get
            IDCuenta = m_IDCuenta
        End Get
        Set(ByVal value As String)
            m_IDCuenta = value
        End Set
    End Property

#End Region

#Region "Cargar Formulario"
    Private Sub frmSccEditTramite_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarExpedientes()
        Me.CargarClientes()
        Me.CargarEmpleadosAbogados()

        Me.dtpFecha.Value = Now
        Select Case Me.TypeGui
            Case 0
                Me.Text = "Nuevo Trámite Legal"
            Case 2
                Me.Text = "Consulta de Trámite Legal"
                Me.CargaDatosTramites()
                Me.dtpFecha.Enabled = False
                Me.cmdGuardar.Enabled = False

        End Select
        clsProyecto.CargarTemaDefinido(Me)
    End Sub
#End Region

#Region "Guardar Trámite"

    Private Function GuardarTramite() As Boolean
        Dim T As New TransactionManager
        Dim sSQL, sCommand, sFacturaId As String
        Dim dtDatos As New DataTable
        Dim IDCalificacionTramiteLegal, IdCalificacionAnteriorCuenta As Integer

        Dim objTramite As New SccTramiteLegal

        Try
            Try
                T.BeginTran()

                'Cambiar calificación de factura de moto a "Trámite Legal"
                sSQL = clsConsultas.ObtenerConsultaGeneral("objFacturaId, CalificacionCuentaID", "vwCalificacionCuentasMotos", "objSccCuentaID='" + Me.cmbExpedientes.SelectedValue.ToString + "' AND objTiendaId=" + Me.cmbExpedientes.Splits(0).DisplayColumns("objTiendaId").DataColumn.Value.ToString)
                dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

                sFacturaId = dtDatos.DefaultView.Item(0)("objFacturaID")
                IdCalificacionAnteriorCuenta = Convert.ToInt32(dtDatos.DefaultView.Item(0)("CalificacionCuentaID"))

                IDCalificacionTramiteLegal = ClsCatalogos.ObtenerIDSTbCatalogo("CLASIFICACIONCUENTA", "TL")
                sCommand = "UPDATE dbo.SccCuentaPorCobrarDetalle SET objCalificacionID=" + IDCalificacionTramiteLegal.ToString + " WHERE objFacturaID=" + sFacturaId.ToString
                SqlHelper.ExecuteCommand(sCommand, T)

                With objTramite
                    .objCuentaID = Me.cmbExpedientes.SelectedValue
                    .ObjTiendaID = Me.cmbExpedientes.Splits(0).DisplayColumns("objTiendaId").DataColumn.Value
                    .Fecha = Me.dtpFecha.Value
                    .Saldo_a_Fecha = Me.txtSaldoCuenta.Text
                    .objEmpleadoid = Me.cmbEmpleados.SelectedValue
                    .Comentario = Me.txtComentario.Text
                    .objCalificacionAnteriorId = IdCalificacionAnteriorCuenta
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .Insert(T)
                End With
                Me.IDTramite = objTramite.SccTramiteLegalID

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

#End Region

#Region "Validaciones de Datos"
    Private Function Validaciones() As Boolean
        Try
            If Trim(Me.cmbEmpleados.Text).Length = 0 Then
                Me.ErrorProvider.SetError(Me.cmbEmpleados, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If Trim(Me.cmbExpedientes.Text).Length = 0 Then
                Me.ErrorProvider.SetError(Me.cmbExpedientes, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If Me.cmbClientes.Text.Trim.Length = 0 Then
                Me.ErrorProvider.SetError(Me.cmbClientes, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            'Verificar si el expediente ya está en trámite legal
            If SqlHelper.ExecuteQueryDT("SELECT COUNT(*) AS Contador FROM dbo.SccTramiteLegal WHERE objCuentaID='" + Me.cmbExpedientes.Text.Trim + "'").DefaultView.Item(0)("Contador") <> 0 Then
                Me.ErrorProvider.SetError(Me.cmbExpedientes, "El expediente seleccionado ya está en Trámite Legal.")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Eventos de controles"
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Select Case Me.TypeGui
            Case 0
                If Me.Validaciones Then
                    If Me.GuardarTramite Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
        End Select
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.TextChanged
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.ToolTip.Hide(Me.lblInfo)
        If Me.BoolGuardado Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

#End Region

#Region "Cargar combos"
    ''' <summary>
    ''' Procedimiento encargado de Cargar los Clientes
    ''' Autor : Gelmin Martínez 
    ''' Fecha : 26 de Marzo de 2010.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarClientes()
        'Dim dtDatos As New DataTable
        Try
            'DtDatosCuenta = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("NombreCompleto,StbPersonaID", "vwPersonaClasificacion", " Descripcion= 'Cliente'"))
            With Me.cmbClientes
                .DataSource = DtDatosCuenta
                .DisplayMember = "Cliente"
                .ValueMember = "objClienteID"
                .Splits(0).DisplayColumns("objClienteID").Visible = False
                .Splits(0).DisplayColumns("SccCuentaID").Visible = False
                .Splits(0).DisplayColumns("Saldo").Visible = False
                .Splits(0).DisplayColumns("objTiendaId").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar los Expedientes
    ''' Autor : Gelmin Martinez
    ''' Fecha 24 de Marzo de 2010.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarExpedientes()
        'Dim dtDatos As New DataTable
        Dim strFiltro, strConsulta As String
        Dim iEstadoExpCANCELADO, iCalificacionCuentaALDIA As Integer
        iEstadoExpCANCELADO = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "CANCELADO")
        iCalificacionCuentaALDIA = ClsCatalogos.ObtenerIDSTbCatalogo("CLASIFICACIONCUENTA", "OK")

        'Se cargarán solamente aquellos expedientes que no estén en estado = CANCELADO ni en Calificación = ALDIA
        strConsulta = "SELECT dbo.vwSccCuenta.objClienteID, dbo.vwSccCuenta.SccCuentaID, dbo.vwSccCuenta.Saldo, dbo.vwSccCuenta.Cliente, dbo.vwSccCuenta.objTiendaID " & _
                      "  FROM dbo.vwSccCuenta INNER JOIN " & _
                      " dbo.SccCuentaPorCobrarDetalle ON dbo.vwSccCuenta.SccCuentaID = dbo.SccCuentaPorCobrarDetalle.objSccCuentaID AND " & _
                      " dbo.vwSccCuenta.objTiendaID = dbo.SccCuentaPorCobrarDetalle.objTiendaID "

        strFiltro = " WHERE dbo.vwSccCuenta.objEstadoID <> " + iEstadoExpCANCELADO.ToString + " AND dbo.SccCuentaPorCobrarDetalle.objCalificacionID <> " + iCalificacionCuentaALDIA.ToString
        Try
            DtDatosCuenta = SqlHelper.ExecuteQueryDT(strConsulta + strFiltro + " ORDER BY Cliente")
            With Me.cmbExpedientes
                .DataSource = DtDatosCuenta
                .DisplayMember = "sccCuentaID"                
                .ValueMember = "SccCuentaID"
                .Splits(0).DisplayColumns("objClienteID").Visible = False
                .Splits(0).DisplayColumns("Saldo").Visible = False
                .Splits(0).DisplayColumns("Cliente").Visible = False
                .Splits(0).DisplayColumns("objTiendaId").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
                .Splits(0).ExtendRightColumn = True

            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar Empleados con cargo Abogado
    ''' Autor : Gelmin Martinez
    ''' Fecha 24 de Marzo de 2010.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEmpleadosAbogados()
        Dim dtDatos As New DataTable
        Try
            dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID, UPPER(Nombre1 + ' ' + Nombre2 + ' ' +Apellido1 + ' ' + Apellido2) As NombreAbogado", "dbo.vwSrhEmpleado", "Cargo = 'Abogado' And Activo=1"))
            With Me.cmbEmpleados
                .DataSource = dtDatos
                .DisplayMember = "NombreAbogado"
                .ValueMember = "SrhEmpleadoID"
                .Splits(0).DisplayColumns("SrhEmpleadoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbExpedientes_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExpedientes.SelectedValueChanged
        Me.cmbClientes.SelectedValue = Me.cmbExpedientes.Splits(0).DisplayColumns(0).DataColumn.Value
        Me.txtSaldoCuenta.Text = Me.cmbExpedientes.Splits(0).DisplayColumns("Saldo").DataColumn.Value
        Me.ErrorProvider.Clear()
    End Sub

    Private Sub cmbClientes_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClientes.SelectedValueChanged
        Me.cmbExpedientes.SelectedValue = Me.cmbClientes.Splits(0).DisplayColumns("SccCuentaID").DataColumn.Value
        Me.txtSaldoCuenta.Text = Me.cmbClientes.Splits(0).DisplayColumns("Saldo").DataColumn.Value
        Me.ErrorProvider.Clear()
    End Sub
#End Region

#Region "Cargar datos Trámites"
    Private Sub CargaDatosTramites()
        Dim sSQL, sCampos, sFiltro As String
        sCampos = "ObjCuentaID, NombreCliente, FechaTramite, Saldo_a_fecha,NombreAbogado, Comentario"
        sFiltro = "SccTramiteLegalID=" + Me.IDTramite.ToString
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSccTramitesLegales", sFiltro)

        Me.dtDatosTramiteLegal = SqlHelper.ExecuteQueryDT(sSQL)
        'Asignar datos a controles
        Me.txtNumero.Text = Me.IDTramite
        Me.cmbExpedientes.Text = Me.dtDatosTramiteLegal.DefaultView.Item(0)("objCuentaID")
        Me.cmbClientes.Text = Me.dtDatosTramiteLegal.DefaultView.Item(0)("NombreCliente")
        Me.cmbEmpleados.Text = Me.dtDatosTramiteLegal.DefaultView.Item(0)("NombreAbogado")
        Me.dtpFecha.Value = Me.dtDatosTramiteLegal.DefaultView(0)("FechaTramite")
        Me.txtSaldoCuenta.Text = Me.dtDatosTramiteLegal.DefaultView(0)("Saldo_a_fecha")
        Me.txtComentario.Text = Me.dtDatosTramiteLegal.DefaultView.Item(0)("Comentario")
        'Bloquear controles
        Me.BloquerarControles(True)
    End Sub
#End Region

#Region "Bloquear controles"
    Private Sub BloquerarControles(ByVal bValor As Boolean)
        Me.txtNumero.Enabled = Not bValor
        Me.cmbExpedientes.Enabled = Not bValor
        Me.cmbClientes.Enabled = Not bValor
        Me.cmbEmpleados.Enabled = Not bValor
        Me.dtpFecha.Enabled = Not bValor
        Me.txtSaldoCuenta.Enabled = Not bValor
        Me.txtComentario.Enabled = Not bValor
    End Sub
#End Region

#Region "Cargar Reporte"
    Private Sub CargarReporte(ByVal Reporte As String)
        Dim objReportes As New frmStbVisor
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                objReportes.IDReporte = Reporte
                objReportes.Width = frmPrincipal.Width - frmPrincipal.OutBarPrincipal.Width
                'objReportes.Height = frmPrincipal.Height - frmPrincipal.MenuPrincipal.Height - frmPrincipal.stbPrincipal.Height
                objReportes.MdiParent = frmPrincipal
                objReportes.Show()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

End Class


