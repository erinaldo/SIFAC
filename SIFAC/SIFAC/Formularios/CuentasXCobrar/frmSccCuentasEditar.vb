Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos


Public Class frmSccCuentasEditar

#Region "Variables del formulario"
    Public dtTienda As DataTable
    Public dtCliente, dtFiadores, dtFacturas, dtFiadoresTemporal As DataTable
    Public intTypeGUI, intTiendaID As Integer
    Public strCuentaID, FiltroCliente, FiltroFiador, strClienteID As String
    Dim m_IntFiadores As Integer
    Dim m_BoolAddFiador As Boolean

#End Region

#Region "Propiedades"

    Public Property BoolAddFiador() As Boolean
        Get
            BoolAddFiador = Me.m_BoolAddFiador
        End Get
        Set(ByVal value As Boolean)
            Me.m_BoolAddFiador = value
        End Set
    End Property

    Public Property IntFiadores() As Integer
        Get
            IntFiadores = Me.m_IntFiadores
        End Get
        Set(ByVal value As Integer)
            Me.m_IntFiadores = value
        End Set
    End Property

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

    Public Property TiendaID() As Integer
        Get
            Return intTiendaID
        End Get
        Set(ByVal value As Integer)
            intTiendaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    Public Sub CargarCliente()
        Select Case TypeGUI
            Case 0
                'FiltroCliente = "Descripcion = 'Cliente' AND StbPersonaID NOT IN (SELECT objFiadorID FROM vwSccCuentaFiador WHERE Estado = 'VIGENTE') ORDER BY Descripcion DESC"
                FiltroCliente = "Descripcion = 'Cliente' ORDER BY Descripcion DESC"
            Case 1
                FiltroCliente = "Descripcion = 'Cliente' AND StbPersonaID NOT IN (SELECT objFiadorID FROM vwSccCuentaFiador WHERE Estado = 'VIGENTE') ORDER BY Descripcion DESC"
            Case 2
                FiltroCliente = "Descripcion = 'Cliente' ORDER BY Descripcion DESC"
        End Select
        dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Direccion,Cedula,CedulaAnverso,CedulaReverso,Genero,Descripcion,PersonaJuridica,TipoPersona,Nacionalidad", "vwPersonaClasificacion", FiltroCliente))
        dtCliente.DefaultView.RowFilter = "1=0"
    End Sub

    Public Sub CargarFiadores()
        FiltroFiador = "Descripcion = 'Fiador' AND 1=0"
        dtFiadores = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Cedula,Genero,Descripcion,PersonaJuridica", "vwPersonaClasificacion", FiltroFiador))
        'dtFiadores.DefaultView.RowFilter = "1=0"
        Me.grdFiadores.SetDataBinding(dtFiadores, "", True)
    End Sub


    Public Sub VincularControles()
        Me.txtNombre.DataBindings.Clear()
        Me.txtDireccion.DataBindings.Clear()
        Me.txtCedula.DataBindings.Clear()
        Me.txtGenero.DataBindings.Clear()
        Me.txtNacionalidad.DataBindings.Clear()
        Me.txtTipoPersona.DataBindings.Clear()
        Me.txtNombre.DataBindings.Add("text", dtCliente, "NombreCompleto", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtDireccion.DataBindings.Add("text", dtCliente, "Direccion", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtCedula.DataBindings.Add("text", dtCliente, "Cedula", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtGenero.DataBindings.Add("text", dtCliente, "Genero", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtNacionalidad.DataBindings.Add("text", dtCliente, "Nacionalidad", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtTipoPersona.DataBindings.Add("text", dtCliente, "TipoPersona", True, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

#Region "Cargar Combos"
    Public Sub CargarTiendas()
        dtTienda = StbTienda.RetrieveDT("Activo=1", , "StbTiendaID,Codigo,Nombre")
        With cmbTienda
            .DataSource = Me.dtTienda
            .ValueMember = "StbTiendaID"
            .DisplayMember = "Nombre"
            .Splits(0).DisplayColumns("StbTiendaID").Visible = False
            .Splits(0).DisplayColumns("Codigo").Visible = False
            .ExtendRightColumn = True
        End With
    End Sub



#End Region

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
                Me.cmbTienda.Enabled = False
                Me.txtCuenta.Enabled = False
            Case 2
                Me.Text = "Consulta de Expediente."
                CargarDatosEdicion()
                Call Me.CargarFacturas()
                Me.cmbTienda.Enabled = False
                Me.txtCuenta.Enabled = False
                Me.cmdHojaContrato.Enabled = False
                Me.numLimiteCredito.Enabled = False

                Me.dtpFechaCredito.Enabled = False
                Me.cmdBuscarCliente.Enabled = False
                Me.cmdAgregarFiador.Enabled = False
                Me.cmdEliminar.Enabled = False
                Me.cmdAceptar.Enabled = False
                Me.cmdVisorCedula.Enabled = True
        End Select
        If Me.BoolAddFiador Then
            Me.cmdAgregarFiador.Enabled = True
            Me.BoolAddFiador = True
            Me.cmdEliminar.Enabled = True
            Me.TypeGUI = 1
            Me.cmdAceptar.Enabled = True
        End If
    End Sub

    Public Sub EstablecerPropiedades()
        Me.txtCuenta.MaxLength = SccCuentaPorCobrar.GetMaxLength("SccCuentaID")
    End Sub

#Region "Agregar Cuenta"
    Public Sub AgregarCuenta()
        Dim objSccCuenta As SccCuentaPorCobrar
        Dim tx As New DAL.TransactionManager
        objSccCuenta = New SccCuentaPorCobrar
        Dim objSccPersonas As New SccPersonasCuentas

        Try
            Try
                If Me.dtFiadores.DefaultView.Count > StbParametro.RetrieveDT("Nombre = 'CantidadFiadores'", , "Valor").DefaultView.Item(0)("Valor") Then
                    MsgBox("La cantidad de Fiadores excede el límite establecido ", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                tx.BeginTran()
                objSccCuenta.SccCuentaID = Me.txtCuenta.Text.Trim
                objSccCuenta.objTiendaID = Me.cmbTienda.SelectedValue
                objSccCuenta.LimiteCredito = Me.numLimiteCredito.Value
                objSccCuenta.Saldo = Me.numSaldo.Value
                If Me.txtHojaContrato.Text.Trim.Length <> 0 Then
                    objSccCuenta.RutaHojaContrato = Me.txtHojaContrato.Text
                End If

                objSccCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSccCuenta.SaldoInicial = 0.0
                objSccCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSccCuenta.objClienteID = ClienteID
                objSccCuenta.FechaCredito = Me.dtpFechaCredito.Value
                objSccCuenta.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "REGISTRADO")
                objSccCuenta.Insert(tx)
                objSccPersonas.objTiendaID = objSccCuenta.objTiendaID
                objSccPersonas.SccCuentaID = objSccCuenta.SccCuentaID
                objSccPersonas.IDPersona = objSccCuenta.objClienteID
                objSccPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSccPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSccPersonas.Tipo = "Cliente"
                objSccPersonas.Insert(tx)
                AgregarCuentaFiadores(tx)
                tx.CommitTran()
                Me.CuentaID = Me.txtCuenta.Text
                Me.TiendaID = objSccCuenta.objTiendaID
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
        Dim objSccPersonas = New SccPersonasCuentas
        Try
            Try
                If Me.dtFiadores.DefaultView.Count > StbParametro.RetrieveDT("Nombre = 'CantidadFiadores'", , "Valor").DefaultView.Item(0)("Valor") Then
                    MsgBox("La cantidad de Fiadores excede el límite establecido ", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                tx.BeginTran()
                objSccCuenta.Retrieve(Me.CuentaID, Me.TiendaID)
                objSccCuenta.SccCuentaID = Me.txtCuenta.Text.Trim
                objSccCuenta.objTiendaID = Me.cmbTienda.SelectedValue
                objSccCuenta.LimiteCredito = Me.numLimiteCredito.Value
                objSccCuenta.Saldo = Me.numSaldo.Value
                If Me.txtHojaContrato.Text.Trim.Length <> 0 Then
                    objSccCuenta.RutaHojaContrato = Me.txtHojaContrato.Text
                End If
                objSccCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSccCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSccCuenta.objClienteID = ClienteID
                objSccCuenta.FechaCredito = Me.dtpFechaCredito.Value
                objSccCuenta.Update(tx)
                SccCuentaFiador.DeleteByFilter("objSccCuentaID= '" & Me.CuentaID & "' AND objTiendaID=" & Me.TiendaID, tx)
                SccPersonasCuentas.DeleteByFilter("SccCuentaID= '" & Me.CuentaID & "' AND objTiendaID=" & Me.TiendaID, tx)
                objSccPersonas.objTiendaID = objSccCuenta.objTiendaID
                objSccPersonas.SccCuentaID = objSccCuenta.SccCuentaID
                objSccPersonas.IDPersona = objSccCuenta.objClienteID
                objSccPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSccPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSccPersonas.Tipo = "Cliente"
                objSccPersonas.Insert(tx)
                AgregarCuentaFiadores(tx)
                tx.CommitTran()
                Me.CuentaID = Me.txtCuenta.Text
                Me.TiendaID = objSccCuenta.objTiendaID
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

    Public Sub AgregarCuentaFiadores(ByVal tx As DAL.TransactionManager)
        Dim objSccCuentaFiador As SccCuentaFiador
        Dim DtFiador As New DataTable
        Dim Row As DataRow
        Dim RP As DataRow
        Dim dtPers As New DataTable
        Try
            Try
                objSccCuentaFiador = New SccCuentaFiador
                DtFiador = SccCuentaFiador.RetrieveDT("1=0")
                dtPers = SccPersonasCuentas.RetrieveDT("1=0")
                For i As Integer = 0 To Me.dtFiadores.DefaultView.Count - 1
                    Row = DtFiador.NewRow
                    Row("objSccCuentaID") = Trim(Me.txtCuenta.Text)
                    Row("objTiendaID") = Trim(Me.cmbTienda.SelectedValue)
                    Row("objFiadorID") = Me.dtFiadores.Rows(i).Item("StbPersonaID")
                    Row("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    Row("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    DtFiador.Rows.Add(Row)

                    RP = dtPers.NewRow
                    RP("IDPersona") = Me.dtFiadores.Rows(i).Item("StbPersonaID")
                    RP("SccCuentaID") = Trim(Me.txtCuenta.Text)
                    RP("objTiendaID") = Trim(Me.cmbTienda.SelectedValue)
                    RP("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    RP("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    RP("Tipo") = "Fiador"
                    dtPers.Rows.Add(RP)
                Next
                DtFiador.TableName = "SccCuentaFiador"
                SccCuentaFiador.BatchUpdate(DtFiador.DataSet, tx)
                dtPers.TableName = "SccPersonasCuentas"
                SccPersonasCuentas.BatchUpdate(dtPers.DataSet, tx)

                'For i As Integer = 0 To Me.dtFiadores.DefaultView.Count - 1
                '    objSccCuentaFiador.objSccCuentaID = Me.txtCuenta.Text.Trim
                '    objSccCuentaFiador.objTiendaID = Me.cmbTienda.Columns("StbTiendaID").Value
                '    objSccCuentaFiador.objFiadorID = Me.dtFiadores.Rows(i).Item("StbPersonaID")
                '    objSccCuentaFiador.UsuarioCreacion = clsProyecto.Conexion.Usuario
                '    objSccCuentaFiador.FechaCreacion = clsProyecto.Conexion.FechaServidor
                '    objSccCuentaFiador.Insert(tx)
                'Next
            Catch ex As Exception
                Throw ex
            End Try
        Finally
            objSccCuentaFiador = Nothing
        End Try
    End Sub
#End Region

    Public Sub CargarDatosEdicion()
        Dim objSccCuenta As SccCuentaPorCobrar
        Dim strFiadores As String = Nothing
        Dim DtDatosFiador As New DataTable
        objSccCuenta = New SccCuentaPorCobrar


        objSccCuenta.Retrieve(CuentaID, TiendaID)
        Me.cmbTienda.SelectedValue = objSccCuenta.objTiendaID
        Me.txtCuenta.Text = objSccCuenta.SccCuentaID
        Me.ClienteID = objSccCuenta.objClienteID
        If Not IsDBNull(objSccCuenta.RutaHojaContrato) Then
            txtHojaContrato.Text = objSccCuenta.RutaHojaContrato
        End If
        Me.numLimiteCredito.Value = objSccCuenta.LimiteCredito
        Me.numSaldo.Value = objSccCuenta.Saldo
        Me.dtpFechaCredito.Value = objSccCuenta.FechaCredito
        Me.txtEstado.Text = Me.CargarEstados(objSccCuenta.objEstadoID)
        Me.txtUsuario.Text = objSccCuenta.UsuarioCreacion

        ''    Call CalcularInformacion()
        Me.dtCliente.DefaultView.RowFilter = "StbPersonaID = '" & ClienteID & "'"
        Call VincularControles()
        DtDatosFiador = SccCuentaFiador.RetrieveDT("objSccCuentaID = '" & CuentaID & "' AND objTiendaID=" & TiendaID.ToString, , "objFiadorID")
        strFiadores = "'0'"
        If DtDatosFiador.DefaultView.Count > 0 Then
            For Each dr As DataRow In SccCuentaFiador.RetrieveDT("objSccCuentaID = '" & CuentaID & "' AND objTiendaID=" & TiendaID.ToString, , "objFiadorID").Rows
                strFiadores &= ",'" & dr("objFiadorID") & "'"
            Next
        End If
        'Agregado por Róger
        If strFiadores <> "" Then
            FiltroFiador = "Descripcion = 'Fiador' AND StbPersonaID IN (" & strFiadores & ")"
            dtFiadores = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Cedula,Genero,Descripcion,PersonaJuridica", "vwPersonaClasificacion", FiltroFiador))
            'dtFiadores.DefaultView.RowFilter = "1=0"
            Me.grdFiadores.SetDataBinding(dtFiadores, "", True)
        End If
        'Agregado por Róger
        If Me.TypeGUI = 2 Then
            If Me.dtFiadores.DefaultView.Count = 0 Then
                MsgBox("Esta persona no posee fiador asociado es necesario que agregue uno", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.TypeGUI = 1
                Me.cmdAgregarFiador.Enabled = True
                Me.BoolAddFiador = True
                Me.cmdEliminar.Enabled = True
            End If
        End If

    End Sub

#End Region

#Region "Funciones"
    Public Function ValidarEntrada() As Boolean
        Dim objTemp As New SccCuentaPorCobrar
        If cmbTienda.Text.Length = 0 Then
            Me.ErrorProv.SetError(cmbTienda, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If txtCuenta.Text.Length = 0 Then
            Me.ErrorProv.SetError(txtCuenta, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.TypeGUI = 0 Then
            If objTemp.RetrieveByFilter("SccCuentaID = '" & Me.txtCuenta.Text & "' AND objTiendaID = " & Me.cmbTienda.Columns("StbTiendaID").Value) Then
                Me.ErrorProv.SetError(txtCuenta, "Número de Expediente ya existe para la Sucursal seleccionada.")
                Return False
                Exit Function
            End If

        End If



        If Me.numLimiteCredito.Value <= 0 Then
            Me.ErrorProv.SetError(Me.numLimiteCredito, "Limite de credito debe ser mayor que cero")
            Return False
            Exit Function
        End If

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

        If dtFiadores.DefaultView.Count = 0 Then
            Me.tbcCuentas.SelectedIndex = 1
            Me.ErrorProv.SetError(Me.tbcCuentas, My.Resources.MsgObligatorio)
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
        Me.ToolTip.Show("Recuerda el límite de Crédito es la suma de los totales de las facturas sin prima en caso de las motos", Me.lblinfo, 18000)
        clsProyecto.CargarTemaDefinido(Me)
        Me.txtUsuario.Text = clsProyecto.Conexion.Usuario
        Me.IntFiadores = StbParametro.RetrieveDT("Nombre = 'CantidadFiadores'", , "Valor").DefaultView.Item(0)("Valor")
        CargarTiendas()
        CargarCliente()
        CargarFiadores()
        ConfigurarGUI()
        EstablecerPropiedades()
        Me.grdFiadores.Splits(0).DisplayColumns("StbPersonaID").Visible = False
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
                '-------- Agregado por: Gelmin Martínez 08 Julio 2010, 06:58 pm. -------
                'Verificar si esta persona no está en la lista de fiadores
                If dtFiadores.DefaultView.Count > 0 Then
                    For i As Integer = 0 To dtFiadores.DefaultView.Count - 1
                        If Me.dtFiadores.DefaultView.Item(i)("StbPersonaID") = objBuscarPersona.Seleccion Then
                            MsgBox("La persona seleccionada ya está en la lista de Fiadores.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                            Exit Sub
                        End If
                    Next
                End If
                '-----------------------------------------------------------------------

                ClienteID = objBuscarPersona.Seleccion
                Me.ErrorProv.Clear()
                dtCliente.DefaultView.RowFilter = "StbPersonaID = '" & ClienteID & "'"
                If dtCliente.DefaultView.Count = 0 Then
                    Me.CargarCliente()
                    dtCliente.DefaultView.RowFilter = "StbPersonaID = '" & ClienteID & "'"
                End If
                VincularControles()
                Me.cmdVisorCedula.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdVisorCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVisorCedula.Click
        Dim objVisorCedula As frmVisorCedula
        objVisorCedula = New frmVisorCedula
        objVisorCedula.CedulaAnverso = IIf(IsDBNull(dtCliente.Rows(0).Item("CedulaAnverso")), Nothing, dtCliente.Rows(0).Item("CedulaAnverso"))
        objVisorCedula.CedulaReverso = IIf(IsDBNull(dtCliente.Rows(0).Item("CedulaReverso")), Nothing, dtCliente.Rows(0).Item("CedulaReverso"))
        objVisorCedula.ShowDialog(Me)
    End Sub

    Private Sub cmbTienda_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTienda.Change
        If Not IsDBNull(Me.cmbTienda.Columns("Codigo").Value) Then
            Me.txtCodTienda.Text = Me.cmbTienda.Columns("Codigo").Value
        End If
        Me.ErrorProv.Clear()
    End Sub

    Private Sub numLimiteCredito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numLimiteCredito.KeyPress
        If Me.numLimiteCredito.Text.Trim.Length > 0 Then
            If Asc(e.KeyChar) = 13 Then
                numLimiteCredito.UpdateValueWithCurrentText()
                If numLimiteCredito.Value > 0 Then
                    Me.cmdHojaContrato.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub numLimiteCredito_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numLimiteCredito.Validating
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccCuentaPorCobrar.GetMaxLength("LimiteCredito")
            s = SccCuentaPorCobrar.GetScale("LimiteCredito")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.numLimiteCredito.Value > ValorMaximo Then
                Me.ErrorProv.SetError(Me.numLimiteCredito, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.numLimiteCredito.Value = 0
            Else
                Me.ErrorProv.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProv.SetError(Me.numLimiteCredito, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.numLimiteCredito.Value = 0
        End Try
    End Sub

    Private Sub numLimiteCredito_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numLimiteCredito.ValueChanged
        If Me.numLimiteCredito.Value > 0 Then
            Me.ErrorProv.Clear()
        Else
            Me.numLimiteCredito.Value = 0
        End If
    End Sub

    Private Sub cmbTienda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTienda.KeyPress
        If cmbTienda.Text.Trim.Length > 0 Then
            If Asc(e.KeyChar) = 13 Then
                Me.txtCuenta.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        If txtCuenta.Text.Trim.Length > 0 Then
            If Asc(e.KeyChar) = 13 Then
                Me.dtpFechaCredito.Focus()
            End If
        End If
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If grdFiadores.RowCount > 0 Then
            Me.dtFiadores.Rows.Remove(Me.dtFiadores.Select("StbPersonaID = '" & Me.grdFiadores.Columns("StbPersonaID").Value & "'")(0))
        End If
    End Sub

    Private Sub cmdAgregarFiador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarFiador.Click

        If Me.dtFiadores.DefaultView.Count = Me.IntFiadores Then
            MsgBox("El Limite de Fiadores es :" & Me.IntFiadores.ToString, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Exit Sub
        End If

        Dim objBuscarPersona As frmPersonaSelector
        objBuscarPersona = New frmPersonaSelector
        objBuscarPersona.Opcion = 5
        objBuscarPersona.Filtro = "Descripcion = 'Fiador'"
        Dim strFiadores As String = Nothing
        If objBuscarPersona.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'If dtFiadores.DefaultView.Count > 0 Then
            'For i As Integer = 0 To dtFiadores.DefaultView.Count - 1
            'strFiadores &= "'" & Me.dtFiadores.DefaultView.Item(i)("StbPersonaID") & "',"
            'Next
            'End If
            'strFiadores &= "'" & objBuscarPersona.Seleccion & "'"

            'Me.CargarFiadores()

            'Rellenar el DataTable con los datos del fiador seleccionado
            Me.dtFiadoresTemporal = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Cedula,Genero,Descripcion,PersonaJuridica", "vwPersonaClasificacion", "Descripcion = 'Fiador' AND StbPersonaID='" & objBuscarPersona.Seleccion & "'"))

            '-------- Agregado por: Gelmin Martínez 08 Julio 2010, 06:58 pm. -------
            'Validar que el fiador seleccionado no sea un cliente ya cargado
            If Not String.IsNullOrEmpty(Me.ClienteID) Then
                If objBuscarPersona.Seleccion.Trim.Equals(Me.ClienteID.Trim) Then
                    MsgBox("La persona seleccionada ya está como cliente.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
            End If
            '----------------------------------------------------------------------

            'Introducir un nuevo registro con el fiador seleccionado
            If dtFiadores.DefaultView.Count > 0 Then
                For i As Integer = 0 To dtFiadores.DefaultView.Count - 1
                    If Me.dtFiadores.DefaultView.Item(i)("StbPersonaID") = objBuscarPersona.Seleccion Then
                        Exit Sub
                    End If
                Next
            End If
            Me.dtFiadores.Rows.Add(Me.dtFiadoresTemporal.DefaultView.Item(0)("StbPersonaID"), Me.dtFiadoresTemporal.DefaultView.Item(0)("NombreCompleto"), Me.dtFiadoresTemporal.DefaultView.Item(0)("Cedula"), Me.dtFiadoresTemporal.DefaultView.Item(0)("Genero"), Me.dtFiadoresTemporal.DefaultView.Item(0)("Descripcion"), Me.dtFiadoresTemporal.DefaultView.Item(0)("PersonaJuridica"))
            Me.ErrorProv.Clear()
        End If
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

    Private Sub txtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.TextChanged
        Me.ErrorProv.Clear()
    End Sub
#End Region

#Region "Carga de Factura"
    Private Sub CargarFacturas()
        Dim IDEstadoReg As Integer
        Try
            IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
            dtFacturas = New DataTable
            dtFacturas = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Numero,Concepto,Fecha,FechaVencimiento,NoCuotas,Saldo,MontoAbonado,MontoCuota,Termino,MontoCredito", "vwFacturas", "objEstadoID<>" & IDEstadoReg.ToString & " AND objSccCuentaID='" & Me.CuentaID & "' AND objTiendaID=" & Me.TiendaID.ToString))
            Me.grdFacturas.SetDataBinding(dtFacturas, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region

    Private Sub numPrima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = 13 Then
            Me.cmdHojaContrato.Focus()
        End If
    End Sub


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


    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        If Me.grdFiadores.RowCount > 0 Then
            Me.Consultar(1, Me.grdFiadores.Columns("StbPersonaID").Value)
        End If
    End Sub

    Private Sub cmdConsultarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarCliente.Click
        If Trim(Me.txtNombre.Text) <> "" Then
            Me.Consultar(0, Me.dtCliente.DefaultView.Item(0)("StbPersonaID"))
        End If
    End Sub

    Private Sub cmdHojaContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHojaContrato.Click
        If Me.objUbicacionHojaContrato.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.txtHojaContrato.Text = Me.objUbicacionHojaContrato.FileName
        End If
    End Sub

    Private Sub dtpFechaCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaCredito.KeyPress
        If Me.dtpFechaCredito.Text.Trim.Length > 0 Then
            If Asc(e.KeyChar) = 13 Then
                Me.numLimiteCredito.Focus()
            End If
        End If
    End Sub


End Class