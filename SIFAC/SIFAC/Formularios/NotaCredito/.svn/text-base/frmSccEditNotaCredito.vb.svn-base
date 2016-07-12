'--------------------------------------------------------------------------
''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
''-- Fecha de Elaboración    : 20 de Marzo de 2009.
''-------------------------------------------------------------------------
''--    Formulario de Edición y Modificación de Cátalogo Nota de Crédito
''-------------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos

Public Class frmSccEditNotaCredito
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim dtConcepto As DataTable
    Dim dtEstado As DataTable
    Dim m_TypeGui As Integer
    Dim m_IDNotaCredito As Integer

    'para uso en reestructuración de cuenta
    Dim m_Cliente As String
    Dim m_SaldoCuenta As Decimal

    'variable utilizada en el caso que este formulario se llame desde la operación "ReestructurarCuenta" de interfaz Expedientes
    Public blnReestructurarCuenta As Boolean = False

    Property IDNotaCredito() As Integer
        Get
            IDNotaCredito = Me.m_IDNotaCredito
        End Get
        Set(ByVal value As Integer)
            Me.m_IDNotaCredito = value
        End Set
    End Property

    Property TypeGui() As Integer
        Get
            TypeGui = Me.m_TypeGui
        End Get
        Set(ByVal value As Integer)
            Me.m_TypeGui = value
        End Set
    End Property


    Property IdCuenta() As String
        Get
            IdCuenta = Me.m_IDCuenta
        End Get
        Set(ByVal value As String)
            Me.m_IDCuenta = value
        End Set
    End Property

    Property IDTienda() As Integer
        Get
            IDTienda = Me.m_IDTienda
        End Get
        Set(ByVal value As Integer)
            Me.m_IDTienda = value
        End Set
    End Property

    Property Cliente()
        Get
            Cliente = Me.m_cliente
        End Get
        Set(ByVal value)
            Me.m_cliente = value
        End Set
    End Property

    Property SaldoCuenta()
        Get
            SaldoCuenta = Me.m_SaldoCuenta
        End Get
        Set(ByVal value)
            Me.m_SaldoCuenta = value
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
                Me.cmdGuardar.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar el concepto de la nota de credito.
    ''' Autor : Pedro Tinoco
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarConceptoNC()
        Try
            Me.dtConcepto = New DataTable
            Me.dtConcepto = ClsCatalogos.ObtenerValCat("CONCEPTONC")
            With cmbConcepto
                .DataSource = Me.dtConcepto
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            If IsDBNull(Me.dtpFecha.Value) Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.dtpFecha.Value > clsProyecto.Conexion.FechaServidor Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Fecha de Nota de Crédito Incorrecta")
                Return False
                Exit Function
            End If

            If Me.cmbConcepto.Text = "" Then
                Me.ErrorProv.SetError(Me.cmbConcepto, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.numMonto.Value <= 0 Then
                Me.ErrorProv.SetError(Me.numMonto, "Monto debe ser mayor que cero")
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Sub cmdExpediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpediente.Click
        Call Me.SeleccionarCuenta()
    End Sub

#Region "Guardado de Datos"
    Private Function GuardarNC() As Boolean
        Dim T As New TransactionManager
        Dim objNC As New SccNotaCredito
        Dim BoolRst As Boolean
        Try
            BoolRst = False
            T.BeginTran()
            objNC.Descripcion = Me.txtDescripcion.Text
            objNC.Fecha = Me.dtpFecha.Value
            objNC.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objNC.Monto = Me.numMonto.Value
            objNC.objConceptoID = cmbConcepto.SelectedValue
            objNC.objEstadoID = Me.cmbEstado.SelectedValue
            objNC.objSccCuentaID = Me.IdCuenta
            objNC.objTiendaID = Me.IDTienda
            objNC.Numero = SccNotaCredito.RetrieveDT(, , "(ISNULL(MAX(Numero),0) + 1) as Maximo", T).DefaultView.Item(0)("Maximo")
            objNC.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objNC.Insert(T)
            Me.IDNotaCredito = objNC.SccNotaCreditoID
            T.CommitTran()
            BoolRst = True
             Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return BoolRst
    End Function

    'Procedimiento que guarda la Nota de Crédito en una Tabla, Temporalmente mientras se procesa 
    'Toda la transacción de "Reestructuracion de Cuenta"
    'Autor: Gelmin Martínez, 08 Abril 2010, 06:27 PM.

    Private Function GuardarNC_temp() As Boolean
        Dim T As New TransactionManager
        Dim objNC As New txRC_NotaCredito_Step1
        Dim BoolRst As Boolean
        Try
            BoolRst = False
            T.BeginTran()
            'Eliminar datos que pueda contener la tabla del paso1
            txRC_NotaCredito_Step1.DeleteByFilter("1=1", T)

            objNC.Descripcion = Me.txtDescripcion.Text
            objNC.Fecha = Me.dtpFecha.Value
            objNC.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objNC.Monto = Me.numMonto.Value
            objNC.objConceptoID = cmbConcepto.SelectedValue
            objNC.objEstadoID = Me.cmbEstado.SelectedValue
            objNC.objSccCuentaID = Me.IdCuenta
            objNC.objTiendaID = Me.IDTienda
            objNC.Numero = 0 'SccNotaCredito.RetrieveDT(, , "(ISNULL(MAX(Numero),0) + 1) as Maximo", T).DefaultView.Item(0)("Maximo")
            objNC.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objNC.Insert(T)
            Me.IDNotaCredito = objNC.SccNotaCreditoID

            T.CommitTran()
            BoolRst = True
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return BoolRst
    End Function

#End Region

    Private Sub frmSccEditNotaCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargaDatos()
        Me.Panel2.BackColor = Color.White

        'En caso de Reestructuración de Cuenta, cargar datos recibidos y bloquear controles
        If Me.blnReestructurarCuenta Then
            Me.Text = Me.Text + " - [REESTRUCTURACION CUENTA]"
            Me.txtCodTienda.Text = Me.IDTienda
            Me.txtNumCuenta.Text = Me.IdCuenta
            Me.txtCliente.Text = Me.Cliente

            Me.txtCodTienda.Enabled = False
            Me.txtNumCuenta.Enabled = False
            Me.txtCliente.Enabled = False
            'Colocar combo de Concepto de NC en "Reestructuración de cuenta" codigo=10
            Me.cmbConcepto.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTONC", "10")
            Me.cmbConcepto.Enabled = False
            Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
            Me.dtpFecha.Enabled = False
            Me.numMonto.Value = Me.SaldoCuenta
            Me.numMonto.Enabled = False
            Me.cmdGuardar.Text = "&Autorizar"
            Me.cmbEstado.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "AUTORIZADA")
            Me.cmbEstado.Enabled = False
            Me.cmdExpediente.Visible = False
            Me.cmdConsultar.Left = 335
            Me.txtDescripcion.Focus()
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento principal de Carga de Datos
    ''' Autor : Pedro Pablo Tinoco Salgado
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaDatos()
        Try
            Me.CargarConceptoNC()
            Me.CargarEstado()
            If Me.TypeGui > 0 Then
                Me.CargarDatosEdicion()
                If Me.TypeGui = 2 Then
                    Me.dtpFecha.Enabled = False
                    Me.txtDescripcion.Enabled = False
                    Me.cmbConcepto.Enabled = False
                    Me.numMonto.Enabled = False
                    Me.cmdGuardar.Enabled = False
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar las estados posibles de las notas de credito
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEstado()
        Try
            dtEstado = New DataTable
            dtEstado = ClsCatalogos.ObtenerValCat("ESTADONC")
            With Me.cmbEstado
                .DataSource = Me.dtEstado
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            If Me.TypeGui = 0 Then
                Me.cmbEstado.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "REGISTRADA")
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar las notas de credito en Modo edicion y Consulta
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub CargarDatosEdicion()
        Dim dtDatos As New DataTable
        Try
            dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*", "vwSccNotaCredito", "SccNotaCreditoID=" & Me.IDNotaCredito.ToString))
            Me.cmbEstado.SelectedValue = dtDatos.DefaultView.Item(0)("objEstadoID")
            Me.cmbConcepto.SelectedValue = dtDatos.DefaultView.Item(0)("objConceptoID")
            Me.txtNumero.Text = dtDatos.DefaultView.Item(0)("NumeroNC")
            Me.txtDescripcion.Text = dtDatos.DefaultView.Item(0)("Descripcion")
            Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Cliente")
            Me.txtCodTienda.Text = dtDatos.DefaultView.Item(0)("CodigoTienda")
            Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("SccCuentaID")
            Me.numMonto.Value = dtDatos.DefaultView.Item(0)("Monto")
            Me.dtpFecha.Value = dtDatos.DefaultView.Item(0)("Fecha")
            Me.cmdExpediente.Enabled = False
            Me.IdCuenta = dtDatos.DefaultView.Item(0)("SccCuentaID")
            Me.IDTienda = dtDatos.DefaultView.Item(0)("StbTiendaID")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento encargad de Actualizar Nota de Credito.
    ''' Autor : Pedro Tinoco Salgado.
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ActualizarNC() As Boolean
        Dim T As New TransactionManager
        Dim objNotaCredito As New SccNotaCredito
        Dim boolrst As Boolean
        Try
            boolrst = False
            objNotaCredito.Retrieve(Me.IDNotaCredito)
            T.BeginTran()
            objNotaCredito.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objNotaCredito.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objNotaCredito.Fecha = Me.dtpFecha.Value
            objNotaCredito.objConceptoID = Me.cmbConcepto.SelectedValue
            objNotaCredito.Monto = Me.numMonto.Value
            objNotaCredito.SccNotaCreditoID = Me.IDNotaCredito
            objNotaCredito.Update(T)
            T.CommitTran()
            boolrst = True
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return boolrst
    End Function

    Private Sub numMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numMonto.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbConcepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConcepto.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        If Me.txtNumCuenta.Text <> "" Then
            CargarConsultaCuenta()
        End If
    End Sub

    Private Sub CargarConsultaCuenta()
        Dim objfrmCuentaEdit As frmSccCuentasEditar
        objfrmCuentaEdit = New frmSccCuentasEditar
        objfrmCuentaEdit.CuentaID = Me.IDCuenta
        objfrmCuentaEdit.TiendaID = Me.IDTienda
        objfrmCuentaEdit.TypeGUI = 2
        objfrmCuentaEdit.ShowDialog(Me)
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.ValidarDatos Then
            Select Case Me.TypeGui
                Case 0
                    'En caso de que se haya hecho el llamado a este formulario desde operación "ReestructurarCuenta" de Interfaz Expedientes
                    If Me.blnReestructurarCuenta Then
                        If Me.GuardarNC_temp Then 'Guardar NC en Tabla operativa "txRC_NotaCredito_Step1"
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    Else
                        If Me.GuardarNC Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    End If
                Case 1
                    If Me.ActualizarNC Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
            End Select
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub numMonto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numMonto.Validating
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccCuentaPorCobrarDetalle.GetMaxLength("MontoTotal")
            s = SccCuentaPorCobrarDetalle.GetScale("MontoTotal")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.numMonto.Value > ValorMaximo Then
                Me.ErrorProv.SetError(Me.numMonto, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.numMonto.Value = 0
            Else
                Me.ErrorProv.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProv.SetError(Me.numMonto, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.numMonto.Value = 0
        End Try
    End Sub
End Class