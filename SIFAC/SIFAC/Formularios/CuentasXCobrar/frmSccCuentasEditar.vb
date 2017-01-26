Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos


Public Class frmSccCuentasEditar

#Region "Variables del formulario"
    Public dtCliente, dtFacturas, dtRutas As DataTable
    Public intTypeGUI, intobjRutaID As Integer
    Public strCuentaID, FiltroCliente, strClienteID, strPersonaID As String
    Dim foundRows() As DataRow
#End Region

#Region "Propiedades"

    Public Property CuentaID() As String
        Get
            Return strCuentaID
        End Get
        Set(ByVal value As String)
            strCuentaID = value
        End Set
    End Property

    Public Property TypeGUI() As Integer
        Get
            Return intTypeGUI
        End Get
        Set(ByVal value As Integer)
            intTypeGUI = value
        End Set
    End Property

    Public Property PersonaID() As String
        Get
            Return strPersonaID
        End Get
        Set(ByVal value As String)
            strPersonaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"
    Private Sub CargarRuta()
        Dim objRuta As StbRutas
        Try
            objRuta = New StbRutas
            'Rutas
            dtRutas = StbRutas.RetrieveDT("1=1", "", "StbRutaID,Nombre")
            Me.cmbRuta.DataSource = dtRutas
            Me.cmbRuta.DisplayMember = "Nombre"
            Me.cmbRuta.ValueMember = "StbRutaID"
            Me.cmbRuta.Splits(0).DisplayColumns("StbRutaID").Visible = False
            Me.cmbRuta.ExtendRightColumn = True
            Me.cmbRuta.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRuta = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Public Sub CargarCliente()
        Try
            Select Case TypeGUI
                Case 0
                    FiltroCliente = "Descripcion = 'Cliente' "
                Case 1
                    FiltroCliente = "Descripcion = 'Cliente' "
                Case 2
                    FiltroCliente = "Descripcion = 'Cliente' "
            End Select
            dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Direccion,Cedula,Genero,Descripcion,TipoPersona,ClienteID,objRutaID", "vwPersonaClasificacion", FiltroCliente))
            dtCliente.DefaultView.RowFilter = "1=0"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub VincularControles()
        Try
            intobjRutaID = IIf(IsDBNull(foundRows(0)("objRutaID")), 0, foundRows(0)("objRutaID"))
            strClienteID = IIf(IsDBNull(foundRows(0)("ClienteID")), 0, foundRows(0)("ClienteID"))
            Me.txtNombre.Text = String.Empty
            Me.txtDireccion.Text = String.Empty
            Me.txtCedula.Text = String.Empty
            Me.txtGenero.Text = String.Empty
            Me.txtTipoPersona.Text = String.Empty
            Me.txtNombre.Text = IIf(IsDBNull(foundRows(0)("NombreCompleto")), String.Empty, foundRows(0)("NombreCompleto"))
            Me.txtDireccion.Text = IIf(IsDBNull(foundRows(0)("Direccion")), String.Empty, foundRows(0)("Direccion"))
            Me.txtCedula.Text = IIf(IsDBNull(foundRows(0)("Cedula")), String.Empty, foundRows(0)("Cedula"))
            Me.txtGenero.Text = IIf(IsDBNull(foundRows(0)("Genero")), String.Empty, foundRows(0)("Genero"))
            Me.txtTipoPersona.Text = IIf(IsDBNull(foundRows(0)("TipoPersona")), String.Empty, foundRows(0)("TipoPersona"))
            Me.cmbRuta.SelectedValue = intobjRutaID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
      
    End Sub

    Public Sub ConfigurarGUI()
        Select Case TypeGUI
            Case 0
                Me.Text = "Nuevo Expediente."
                PersonaID = Nothing
                Me.txtEstado.Text = Me.CargarEstados(ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "REGISTRADO"))

                ''poner invisible los controles de agregar
                'cmdBuscarFacturas.Visible = False
                'cmdProcesarFacturas.Visible = False
                'cmdConsultarFacturas.Visible = False

            Case 1
                Me.Text = "Edición de Expediente"
                CargarDatosEdicion()
                Call Me.CargarFacturas()
                'Me.txtCuenta.Enabled = False
            Case 2
                Me.Text = "Consulta de Expediente"
                CargarDatosEdicion()
                Call Me.CargarFacturas()
                'Me.txtCuenta.Enabled = False

                Me.dtpFechaCredito.Enabled = False
                Me.cmdBuscarCliente.Enabled = False
                Me.cmdGuardar.Enabled = False
                cmdBuscarFacturas.Enabled = False
                cmdProcesarFacturas.Enabled = False
                ''Deshabilitar controles
                txtNombre.Enabled = False
                txtDireccion.Enabled = False
                txtCedula.Enabled = False
                txtGenero.Enabled = False
                txtTipoPersona.Enabled = False
                cmdBuscarCliente.Enabled = False
        End Select

    End Sub

#Region "Agregar Cuenta"

    Public Sub RegistarCuenta()
        Dim objSccCuenta As SccCuentaPorCobrar
        objSccCuenta = New SccCuentaPorCobrar
        Dim T As New TransactionManager
        Try
            Try
                T.BeginTran()
                objSccCuenta.Numero = GenerarCodigo()
                objSccCuenta.Saldo = Me.numSaldo.Value
                objSccCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSccCuenta.SaldoInicial = 0.0
                objSccCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSccCuenta.objClienteID = strClienteID
                objSccCuenta.FechaCredito = Me.dtpFechaCredito.Value
                objSccCuenta.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "REGISTRADO")
                objSccCuenta.Insert(T)
                T.CommitTran()
                Me.CuentaID = objSccCuenta.SccCuentaID

            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objSccCuenta = Nothing
        End Try
    End Sub

    Public Sub AgregarCuenta()
        Dim objSccCuenta As SccCuentaPorCobrar
        Dim tx As New DAL.TransactionManager
        objSccCuenta = New SccCuentaPorCobrar
        Try
            Try
                tx.BeginTran()
                objSccCuenta.Numero = GenerarCodigo()
                objSccCuenta.Saldo = Me.numSaldo.Value
                objSccCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSccCuenta.SaldoInicial = 0.0
                objSccCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSccCuenta.objClienteID = strClienteID
                objSccCuenta.FechaCredito = Me.dtpFechaCredito.Value
                objSccCuenta.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "REGISTRADO")
                objSccCuenta.Insert(tx)
                tx.CommitTran()
                Me.CuentaID = objSccCuenta.SccCuentaID

                Me.DialogResult = Windows.Forms.DialogResult.OK
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Catch ex As Exception
                tx.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objSccCuenta = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Editar los Expedientes de Clientes
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 11 de abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EditarCuenta()
        Dim objSccCuenta As SccCuentaPorCobrar
        Dim tx As New DAL.TransactionManager
        objSccCuenta = New SccCuentaPorCobrar
        Try
            Try
                tx.BeginTran()
                objSccCuenta.Retrieve(Me.CuentaID)
                objSccCuenta.Saldo = Me.numSaldo.Value
                objSccCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSccCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSccCuenta.objClienteID = strClienteID
                objSccCuenta.FechaCredito = Me.dtpFechaCredito.Value
                objSccCuenta.Update(tx)
                tx.CommitTran()
                Me.CuentaID = objSccCuenta.SccCuentaID
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Catch ex As Exception
                tx.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objSccCuenta = Nothing
        End Try
    End Sub

#End Region

    Public Sub CargarDatosEdicion()
        Dim objSccCuenta As SccCuentaPorCobrar
        Try

            objSccCuenta = New SccCuentaPorCobrar

            objSccCuenta.Retrieve(CuentaID, )
            Me.txtCuenta.Text = objSccCuenta.Numero
            strClienteID = objSccCuenta.objClienteID
            Me.numSaldo.Value = objSccCuenta.Saldo
            Me.dtpFechaCredito.Value = objSccCuenta.FechaCredito
            Me.txtEstado.Text = Me.CargarEstados(objSccCuenta.objEstadoID)
            Me.txtUsuario.Text = objSccCuenta.UsuarioCreacion

            foundRows = Me.dtCliente.Select("ClienteID = '" & strClienteID & "'")
            PersonaID = IIf(IsDBNull(foundRows(0)("StbPersonaID")), String.Empty, foundRows(0)("StbPersonaID"))
            Call VincularControles()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Funciones"
    Public Function ValidarEntrada() As Boolean
        Dim objTemp As New SccCuentaPorCobrar
        Try
        If dtpFechaCredito.Text.Length = 0 Then
            Me.ErrorProv.SetError(dtpFechaCredito, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

            If PersonaID Is Nothing Then
                Me.tbcCuentas.SelectedIndex = 0
                Me.ErrorProv.SetError(cmdBuscarCliente, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#Region "Eventos del formulario"

    Private Sub frmSccCuentasEditar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.ToolTip.Hide(Me.lblinfo)
    End Sub
    Private Sub frmSccCuentasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txtUsuario.Text = clsProyecto.Conexion.Usuario
            CargarRuta()
            CargarCliente()
            ConfigurarGUI()

            Me.grdFacturas.Splits(0).FilterBar = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub dtpFechaCredito_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmdBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarCliente.Click
        Try
            Dim objBuscarPersona As frmPersonaSelector
            objBuscarPersona = New frmPersonaSelector
            objBuscarPersona.Opcion = 4
            objBuscarPersona.Filtro = FiltroCliente
            If objBuscarPersona.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                PersonaID = objBuscarPersona.Seleccion
                Me.ErrorProv.Clear()
                foundRows = Me.dtCliente.Select("StbPersonaID = '" & PersonaID & "'")

                'If foundRows = 0 Then
                '    Me.CargarCliente()
                '    dtCliente.DefaultView.RowFilter = "StbPersonaID = '" & ClienteID & "'"
                'End If
                VincularControles()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        Select Case Me.TypeGUI
            Case 0
                If ValidarEntrada() Then
                    Me.AgregarCuenta()
                End If
            Case 1
                If ValidarEntrada() Then
                    Me.EditarCuenta()
                End If
        End Select

    End Sub

#End Region

#Region "Carga de Factura"
    Private Sub CargarFacturas()
        Dim IDEstadoReg As Integer
        Try
            IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
            dtFacturas = New DataTable
            'dtFacturas = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Numero,Fecha,FechaVencimiento,NoCuotas,Saldo,MontoAbonado,MontoCuota,Termino,MontoCredito", "vwFacturas", "objEstadoID<>" & IDEstadoReg.ToString & " AND objSccCuentaID='" & Me.CuentaID & "'"))
            dtFacturas = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccCuentaPorCobrarDetalleID,SfaFacturaID,Numero,Fecha,FechaVencimiento,NoCuotas,Saldo,MontoAbonado,MontoCuota,Termino,MontoCredito", "vwFacturas", " objSccCuentaID='" & Me.CuentaID & "'"))
            Me.grdFacturas.SetDataBinding(dtFacturas, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region
    ''' <summary>
    ''' Procedimiento encargado de cargar los estados de un recibo de caja
    ''' Autor : Pedro Pablo Tinoco Salgado
    ''' Fecha Creacion : 24 de Marzo de 2009
    ''' </summary>
    ''' <param name="IdEstado"></param>
    ''' <remarks></remarks>

    Private Function CargarEstados(ByVal IdEstado As Integer) As String
        Dim Valor As String = ""
        Try
            Valor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetValorCatalogoID('ESTADOEXPEDIENTE'," + IdEstado.ToString + ",1) as Estado").DefaultView.Item(0)("Estado")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Valor
    End Function


#Region "Consultar Datos de"
    Private Sub Consultar(ByVal IntOpcion As Integer, ByVal IDPersona As String)
        Dim objPersonas As frmClientesEdit
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmClientesEdit
            objPersonas.TyGui = 3
            objPersonas.idpersona = IDPersona
            objPersonas.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region


    Private Function GenerarCodigo() As String
        Dim strNumero As String = ""
        Dim dtMaximoNumero As New DataTable
        Try
            Try
                dtMaximoNumero = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("COUNT(*)+ 1 as NumeroMaximo", "SccCuentaPorCobrar"))
                strNumero = String.Format("C{0}-{1}", intobjRutaID, dtMaximoNumero.DefaultView.Item(0)("NumeroMaximo"))
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtMaximoNumero = Nothing
        End Try
        Return strNumero.Trim
    End Function

    Private Sub cmdConsultarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarCliente.Click
        If Trim(Me.txtNombre.Text) <> "" Then
            Me.Consultar(0, foundRows(0)("StbPersonaID"))
        End If
    End Sub

    
    Private Sub dtpFechaCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaCredito.KeyPress
        If Me.dtpFechaCredito.Text.Trim.Length > 0 Then
            If Asc(e.KeyChar) = 13 Then
                cmdBuscarCliente.Focus()
            End If
        End If
    End Sub


    Private Sub cmdBuscarFacturas_Click(sender As Object, e As EventArgs) Handles cmdBuscarFacturas.Click
        Dim objfrm As frmSfaFaturaEditar
        objfrm = New frmSfaFaturaEditar
        Try
            Dim objCliente As New SccClientes
            objfrm.TypGui = 0 'TypeGUI
            objfrm.IDRuta = intobjRutaID
            If TypeGUI = 0 Then
                If ValidarEntrada() Then
                    Me.RegistarCuenta()
                End If
            End If
            objCliente.RetrieveByFilter("objPersonaID=" & PersonaID)
            objfrm.IDCliente = objCliente.ClienteID
            objfrm.IDCuenta = Me.CuentaID
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarFacturas()
                Me.TypeGUI = 1
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try


    End Sub

    Private Sub cmdConsultarFacturas_Click(sender As Object, e As EventArgs) Handles cmdConsultarFacturas.Click
        If Me.dtFacturas.Rows.Count > 0 Then
            Dim objfrm As frmSfaFaturaEditar
            objfrm = New frmSfaFaturaEditar
            'objfrm.Show()
            objfrm.TypGui = 2
            objfrm.IDRuta = intobjRutaID
            objfrm.IDFactura = Me.grdFacturas.Columns("SfaFacturaID").Value
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarFacturas()
                'Me.grdFacturas.Row = Me.dtDatosFact.DefaultView.Find(objFacturaEdit.IDFactura)
            End If
        End If
    End Sub


#Region "Procesar Factura"
    ''' <summary>
    ''' Procedimiento Encargado de Establecer el Detalle de Factura como Procesado.
    ''' </summary>
    ''' <param name="IDDetalleFact"></param>
    ''' <remarks></remarks>
    Private Sub ProcesarExpedienteFact(ByVal IDDetalleFact As Integer)
        Dim objDetalleFact As New SccCuentaPorCobrarDetalle
        Dim IDEstadoReg As Integer
        Dim IDCuenta As String
        Dim T As New TransactionManager
        Dim EstadoActual As Integer
        Dim objNotaCredito As New SccNotaCredito
        Dim BoolNC As Boolean = False
        Dim objSccCuentaCobrar As New SccCuentaPorCobrar

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

                objSccCuentaCobrar.Retrieve(IDCuenta, T)
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
                    numSaldoInicial.Value = objSccCuentaCobrar.Saldo
                    numSaldo.Value = objSccCuentaCobrar.Saldo
                End If
                T.CommitTran()
                MsgBox("Factura procesada Exitosamente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.CargarFacturas()
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

    Private Sub cmdProcesarFacturas_Click(sender As Object, e As EventArgs) Handles cmdProcesarFacturas.Click
        Try
            If Me.dtFacturas.Rows.Count > 0 Then
                Me.ProcesarExpedienteFact(Me.grdFacturas.Columns("SccCuentaPorCobrarDetalleID").Value)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class