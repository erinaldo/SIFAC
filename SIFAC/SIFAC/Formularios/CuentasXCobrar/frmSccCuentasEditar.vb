Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos


Public Class frmSccCuentasEditar

#Region "Variables del formulario"
    Public dtCliente, dtFacturas As DataTable
    Public intTypeGUI As Integer
    Public strCuentaID, FiltroCliente, strClienteID As String
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

    Public Property ClienteID() As String
        Get
            Return strClienteID
        End Get
        Set(ByVal value As String)
            strClienteID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    Public Sub CargarCliente()
        Select Case TypeGUI
            Case 0
                FiltroCliente = "Descripcion = 'Cliente' ORDER BY Descripcion DESC"
            Case 1
                FiltroCliente = "Descripcion = 'Cliente' ORDER BY Descripcion DESC"
            Case 2
                FiltroCliente = "Descripcion = 'Cliente' ORDER BY Descripcion DESC"
        End Select
        dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Direccion,Cedula,Genero,Descripcion,TipoPersona,Nacionalidad,ClienteID", "vwPersonaClasificacion", FiltroCliente))
        dtCliente.DefaultView.RowFilter = "1=0"
    End Sub

    Public Sub VincularControles()
        Me.txtNombre.Text = String.Empty
        Me.txtDireccion.Text = String.Empty
        Me.txtCedula.Text = String.Empty
        Me.txtGenero.Text = String.Empty
        Me.txtNacionalidad.Text = String.Empty
        Me.txtTipoPersona.Text = String.Empty
        Me.txtNombre.Text = IIf(IsDBNull(foundRows(0)("NombreCompleto")), String.Empty, foundRows(0)("NombreCompleto"))
        Me.txtDireccion.Text = IIf(IsDBNull(foundRows(0)("Direccion")), String.Empty, foundRows(0)("Direccion"))
        Me.txtCedula.Text = IIf(IsDBNull(foundRows(0)("Cedula")), String.Empty, foundRows(0)("Cedula"))
        Me.txtGenero.Text = IIf(IsDBNull(foundRows(0)("Genero")), String.Empty, foundRows(0)("Genero"))
        Me.txtNacionalidad.Text = IIf(IsDBNull(foundRows(0)("Nacionalidad")), String.Empty, foundRows(0)("Nacionalidad"))
        Me.txtTipoPersona.Text = IIf(IsDBNull(foundRows(0)("TipoPersona")), String.Empty, foundRows(0)("TipoPersona"))
    End Sub

    Public Sub ConfigurarGUI()
        Select Case TypeGUI
            Case 0
                Me.Text = "Nuevo Expediente."
                ClienteID = Nothing
                Me.txtEstado.Text = Me.CargarEstados(ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "REGISTRADO"))
            Case 1
                Me.Text = "Edición de Expediente."
                CargarDatosEdicion()
                Call Me.CargarFacturas()
                Me.txtCuenta.Enabled = False
            Case 2
                Me.Text = "Consulta de Expediente."
                CargarDatosEdicion()
                Call Me.CargarFacturas()
                Me.txtCuenta.Enabled = False

                Me.dtpFechaCredito.Enabled = False
                Me.cmdBuscarCliente.Enabled = False
                Me.cmdAceptar.Enabled = False
        End Select

    End Sub

#Region "Agregar Cuenta"
    Public Sub AgregarCuenta()
        Dim objSccCuenta As SccCuentaPorCobrar
        Dim tx As New DAL.TransactionManager
        objSccCuenta = New SccCuentaPorCobrar
        Try
            Try
                tx.BeginTran()
                objSccCuenta.Saldo = Me.numSaldo.Value
                objSccCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSccCuenta.SaldoInicial = 0.0
                objSccCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSccCuenta.objClienteID = ClienteID
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
                objSccCuenta.objClienteID = ClienteID
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
        objSccCuenta = New SccCuentaPorCobrar


        objSccCuenta.Retrieve(CuentaID, )
        Me.txtCuenta.Text = objSccCuenta.SccCuentaID
        Me.ClienteID = objSccCuenta.objClienteID
        Me.numSaldo.Value = objSccCuenta.Saldo
        Me.dtpFechaCredito.Value = objSccCuenta.FechaCredito
        Me.txtEstado.Text = Me.CargarEstados(objSccCuenta.objEstadoID)
        Me.txtUsuario.Text = objSccCuenta.UsuarioCreacion

        foundRows = Me.dtCliente.Select("ClienteID = '" & ClienteID & "'")
        Call VincularControles()
        
    End Sub

#End Region

#Region "Funciones"
    Public Function ValidarEntrada() As Boolean
        Dim objTemp As New SccCuentaPorCobrar

        If dtpFechaCredito.Text.Length = 0 Then
            Me.ErrorProv.SetError(dtpFechaCredito, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If ClienteID Is Nothing Then
            Me.tbcCuentas.SelectedIndex = 0
            Me.ErrorProv.SetError(cmdBuscarCliente, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

#Region "Eventos del formulario"

    Private Sub frmSccCuentasEditar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.ToolTip.Hide(Me.lblinfo)
    End Sub
    Private Sub frmSccCuentasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.txtUsuario.Text = clsProyecto.Conexion.Usuario
        CargarCliente()
        ConfigurarGUI()
        Me.Panel2.BackColor = Color.White
        Me.grdFacturas.Splits(0).FilterBar = False
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
                ClienteID = objBuscarPersona.Seleccion
                Me.ErrorProv.Clear()
                foundRows = Me.dtCliente.Select("ClienteID = '" & ClienteID & "'")

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

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

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
            dtFacturas = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Numero,Fecha,FechaVencimiento,NoCuotas,Saldo,MontoAbonado,MontoCuota,Termino,MontoCredito", "vwFacturas", "objEstadoID<>" & IDEstadoReg.ToString & " AND objSccCuentaID='" & Me.CuentaID & "'"))
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

End Class