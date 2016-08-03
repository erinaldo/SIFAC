
Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos

''' <summary>
''' Formulario de Edicion y Registro de Bitacoras de Seguimiento a los Clientes
''' Autor : Pedro Tinoco Salgado.
''' Fecha : 31 de Marzo de 2009.
''' </summary>
''' <remarks></remarks>
''' 


Public Class frmStbBitacoraClienteEdit
    Dim objBitacora As New StbBitacoraCliente
    Dim m_IdCuenta As String
    Dim m_IdTienda As Integer
    Dim m_IDBitacora As Integer
    Dim M_typGui As Integer
    Dim DtTipoSeg As New DataTable

    Property TypeGui() As Integer
        Get
            TypeGui = Me.M_typGui
        End Get
        Set(ByVal value As Integer)
            Me.M_typGui = value
        End Set
    End Property

    Property IdTienda() As Integer
        Get
            IdTienda = Me.m_IdTienda
        End Get
        Set(ByVal value As Integer)
            Me.m_IdTienda = value
        End Set
    End Property

    Property IDCuenta() As String
        Get
            IDCuenta = Me.m_IdCuenta
        End Get
        Set(ByVal value As String)
            Me.m_IdCuenta = value
        End Set
    End Property

    Property IdBitacora() As Integer
        Get
            IdBitacora = Me.m_IDBitacora
        End Get
        Set(ByVal value As Integer)
            Me.m_IDBitacora = value
        End Set
    End Property


    ''' <summary>
    ''' Procedimiento encargado de seleccionar la cuenta.
    ''' Autor : Pedro Pablo Tinoco
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SeleccionarCuenta()
        Try
            Dim objCuentasSeleccion As New frmSccSeleccionCuentas
            If objCuentasSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.txtCodTienda.Text = objCuentasSeleccion.CodigoTienda
                Me.txtNumCuenta.Text = objCuentasSeleccion.SccCuentaID
                Me.IdCuenta = objCuentasSeleccion.SccCuentaID
                Me.IDTienda = objCuentasSeleccion.IDTienda
                Me.txtCliente.Text = objCuentasSeleccion.Cliente
                Me.ErrorProv.Clear()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Consultar la Cuenta
    ''' Autor : Pedro Tinoco
    ''' Fecha : 13 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarConsultaCuenta()
        Dim objfrmCuentaEdit As frmSccCuentasEditar
        objfrmCuentaEdit = New frmSccCuentasEditar
        objfrmCuentaEdit.CuentaID = Me.IDCuenta
        objfrmCuentaEdit.TiendaID = Me.IdTienda
        objfrmCuentaEdit.TypeGUI = 2
        objfrmCuentaEdit.ShowDialog(Me)
    End Sub


    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        If Me.txtNumCuenta.Text <> "" Then
            CargarConsultaCuenta()
        End If
    End Sub

    Private Sub cmdExpediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpediente.Click
        Me.SeleccionarCuenta()
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            If Me.txtNumCuenta.Text = "" Then
                Me.ErrorProv.SetError(Me.txtNumCuenta, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Trim(Me.dtpFecha.Text) = "" Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Trim(Me.txtDescripcion.Text) = "" Then
                Me.ErrorProv.SetError(Me.txtDescripcion, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.cmbSeguimiento.Text = "" Then
                Me.ErrorProv.SetError(Me.cmbSeguimiento, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Trim(Me.txtObjetivo.Text) = "" Then
                Me.ErrorProv.SetError(Me.txtObjetivo, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function



    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProv.Clear()
    End Sub

    ''' <summary>
    ''' Funcion Encargado de Guardar los Datos de la Bitacora
    ''' Autor : Pedro Pablo Tinco
    ''' Fecha 31 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Function GuardarDatos() As Boolean
        Dim t As New TransactionManager
        Try
            t.BeginTran()
            Me.objBitacora.DescripcionBitacora = Trim(Me.txtDescripcion.Text)
            Me.dtpFecha.Update()
            Me.dtpFecha.UpdateValueWithCurrentText()
            Me.objBitacora.Fecha = Me.dtpFecha.Value
            Me.objBitacora.FechaCreacion = clsProyecto.Conexion.FechaServidor
            Me.objBitacora.UsuarioCreacion = clsProyecto.Conexion.Usuario
            Me.objBitacora.objSccCuentaID = Me.IDCuenta
            Me.objBitacora.objTiendaID = Me.IdTienda
            Me.objBitacora.ObjetivoBitacora = Trim(Me.txtObjetivo.Text)
            Me.objBitacora.objTipoSeguimientoID = Me.cmbSeguimiento.SelectedValue
            Me.objBitacora.Insert(t)
            Me.IdBitacora = Me.objBitacora.StbBitacoraClienteID
            t.CommitTran()
            Return True
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
            Return False
        End Try
    End Function

    Private Sub frmStbBitacoraClienteEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtObjetivo.MaxLength = StbBitacoraCliente.GetMaxLength("ObjetivoBitacora")
        Me.txtDescripcion.MaxLength = StbBitacoraCliente.GetMaxLength("DescripcionBitacora")
        Me.CargarTipoSeguimiento()
        Select Case Me.TypeGui
            Case 0
                Me.txtUsuario.Text = clsProyecto.Conexion.Usuario
            Case 1
                CargarDatosConsultas()
        End Select
        clsProyecto.CargarTemaDefinido(Me)

         End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.ValidarDatos Then
            If Me.GuardarDatos Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub CargarDatosConsultas()
        Dim DtDatos As New DataTable
        Try
            DtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*", "vwStbBitacoraCliente", "StbBitacoraClienteID=" & Me.IdBitacora))
            Me.txtCodTienda.Text = DtDatos.DefaultView.Item(0)("CodigoTienda")
            Me.txtNumCuenta.Text = DtDatos.DefaultView.Item(0)("objSccCuentaID")
            Me.txtCliente.Text = DtDatos.DefaultView.Item(0)("Cliente")
            Me.txtUsuario.Text = DtDatos.DefaultView.Item(0)("UsuarioCreacion")
            Me.txtDescripcion.Text = DtDatos.DefaultView.Item(0)("DescripcionBitacora")
            Me.dtpFecha.Value = DtDatos.DefaultView.Item(0)("Fecha")
            Me.cmbSeguimiento.SelectedValue = DtDatos.DefaultView.Item(0)("objTipoSeguimientoID")
            Me.txtObjetivo.Text = DtDatos.DefaultView.Item(0)("ObjetivoBitacora")
            Me.cmdExpediente.Enabled = False
            Me.dtpFecha.Enabled = False
            Me.txtDescripcion.Enabled = False
            Me.cmdGuardar.Enabled = False
            Me.txtObjetivo.Enabled = False
            Me.cmbSeguimiento.Enabled = False
            Me.IDCuenta = DtDatos.DefaultView.Item(0)("objSccCuentaID")
            Me.IdTienda = DtDatos.DefaultView.Item(0)("objTiendaID")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub CargarTipoSeguimiento()
        Try
            DtTipoSeg = ClsCatalogos.ObtenerValCat("TIPOSEGUIMIENTO")
            With Me.cmbSeguimiento
                .DataSource = Me.DtTipoSeg
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .ExtendRightColumn = True
                .ColumnHeaders = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbSeguimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSeguimiento.TextChanged
        Me.ErrorProv.Clear()
    End Sub
End Class