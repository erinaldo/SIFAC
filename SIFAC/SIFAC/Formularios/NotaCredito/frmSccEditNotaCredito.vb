'--------------------------------------------------------------------------
''-------------------------------------------------------------------------
''--    Formulario de Edición y Modificación de Cátalogo Nota de Crédito
''-------------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports SIFAC.BO

Public Class frmSccEditNotaCredito
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim dtConcepto As DataTable
    Dim dtEstado As DataTable
    Dim m_TypeGui As Integer
    Dim m_IDNotaCredito As Integer
    Dim DtEmpleado, dtCajas As DataTable
    'para uso en reestructuración de cuenta
    Dim m_Cliente As String
    Dim m_SaldoCuenta As Decimal
    Dim intComisionID As Integer
    Dim StrTipo As String
    'variable utilizada en el caso que este formulario se llame desde la operación "ReestructurarCuenta" de interfaz Expedientes
    Public blnReestructurarCuenta As Boolean = False

    Property IDComisionID() As Integer
        Get
            IDComisionID = Me.intComisionID
        End Get
        Set(ByVal value As Integer)
            Me.intComisionID = value
        End Set
    End Property

    Property Tipo() As String
        Get
            Tipo = Me.StrTipo
        End Get
        Set(ByVal value As String)
            Me.StrTipo = value
        End Set
    End Property

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
            Cliente = Me.m_Cliente
        End Get
        Set(ByVal value)
            Me.m_Cliente = value
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
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SeleccionarCuenta()
        Try
            Dim objCuentasSeleccion As New frmSccSeleccionCuentas
            If objCuentasSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.txtNumCuenta.Text = objCuentasSeleccion.NumeroCuenta
                Me.IdCuenta = objCuentasSeleccion.SccCuentaID
                Me.txtCliente.Text = objCuentasSeleccion.Cliente
                Me.cmdGuardar.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar el concepto de la nota de credito. 
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

            objNC.Numero = SccNotaCredito.RetrieveDT(, , "(ISNULL(MAX(Numero),0) + 1) as Maximo", T).DefaultView.Item(0)("Maximo")
            objNC.UsuarioCreacion = clsProyecto.Conexion.Usuario

            If Tipo <> "Comisiones" And Tipo <> "Salida" Then
               objNC.objSccCuentaID = Me.IdCuenta
            End If

            objNC.objCajaID = cmbCajas.SelectedValue

            If IDComisionID <> 0 And IDComisionID.ToString.Trim.Length <> 0 Then
                objNC.objEmpleadoID = cmbEmpleado.SelectedValue
            End If

            objNC.Insert(T)
            Me.IDNotaCredito = objNC.SccNotaCreditoID

            If Tipo = "Comisiones" Then
                Dim objComision As New SccComisiones
                objComision.Retrieve(IDComisionID)
                objComision.objNotaCreditoID = IDNotaCredito
                objComision.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objComision.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objComision.Update(T)
            End If

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

        Me.CargaDatos()
        
        'En caso de Reestructuración de Cuenta, cargar datos recibidos y bloquear controles
        If Me.blnReestructurarCuenta Then
            Me.Text = Me.Text + " - [REESTRUCTURACION CUENTA]"
            Me.txtNumCuenta.Text = Me.IdCuenta
            Me.txtCliente.Text = Me.Cliente
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
 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaDatos()
        Try
            Me.CargarConceptoNC()
            Me.CargarEstado()
            CargarCajas()
            If Me.TypeGui > 0 Then
                Me.CargarDatosEdicion()
                If Me.TypeGui = 2 Then
                    Me.dtpFecha.Enabled = False
                    Me.txtDescripcion.Enabled = False
                    Me.cmbConcepto.Enabled = False
                    Me.numMonto.Enabled = False
                    Me.cmdGuardar.Enabled = False

                End If
            Else
                Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
            End If

            If IDComisionID <> 0 And IDComisionID.ToString.Trim.Length > 0 Then
                Dim objComision As New SccComisiones
                objComision.Retrieve(IDComisionID)
                Me.Text = "Pagos de comisiones"
                Me.txtCliente.Enabled = False
                Me.cmbEstado.Enabled = False
                Me.cmbConcepto.Enabled = False
                Me.txtNumCuenta.Enabled = False
                Me.cmdExpediente.Enabled = False
                Me.txtDescripcion.Text = "Pago de comision a " & cmbEmpleado.Text

                Me.lblCliente.Text = "Empleado: "
                Me.txtCliente.Visible = False

                Me.cmbEstado.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "PAGADA")
                Me.cmbConcepto.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTONC", "PAGOCOMISION")
                Me.numMonto.Value = objComision.Monto
                Me.cmbEmpleado.SelectedValue = objComision.objEmpleadoID
                Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
                Me.dtpFecha.Value = objComision.Fecha
            End If


            If Tipo = "Salida" Then
                Me.Text = "Salida de Efectivo"
                Me.cmbEmpleado.Enabled = False
                Me.cmbEstado.Enabled = False
                Me.cmbCajas.Enabled = False
                Me.txtCliente.Enabled = False
                Me.cmbEstado.Enabled = False
                Me.cmbConcepto.Enabled = False
                Me.txtNumCuenta.Enabled = False
                Me.cmdExpediente.Enabled = False
                Me.lblCliente.Text = "Empleado: "
                Me.txtCliente.Visible = False
                Me.cmbConcepto.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTONC", "SALIDAEFEC")
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#Region "Cargar Empleados"

    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarEmpleado()
        Try
            DtEmpleado = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))

            cmbEmpleado.DataSource = DtEmpleado
            cmbEmpleado.ValueMember = "SrhEmpleadoID"
            cmbEmpleado.DisplayMember = "NombreCompleto"

            cmbEmpleado.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Cajas"

    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarCajas()
        Try
            dtCajas = SccCajas.RetrieveDT("Activa=1", , "SccCajaID, Codigo + '-' + Nombre as Caja, objCajeroID, Ubicacion, Activa")

            cmbCajas.DataSource = dtCajas
            cmbCajas.ValueMember = "SccCajaID"
            cmbCajas.DisplayMember = "Caja"

            cmbCajas.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

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

            If Not IsDBNull(dtDatos.DefaultView.Item(0)("Cliente")) Then
                Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Cliente")
            End If

            If Not IsDBNull(dtDatos.DefaultView.Item(0)("NumeroCuenta")) Then
                Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("NumeroCuenta")
            End If

            Me.numMonto.Value = dtDatos.DefaultView.Item(0)("Monto")
            Me.dtpFecha.Value = dtDatos.DefaultView.Item(0)("Fecha")
            Me.cmdExpediente.Enabled = False

            If Not IsDBNull(dtDatos.DefaultView.Item(0)("SccCuentaID")) Then
                Me.IdCuenta = dtDatos.DefaultView.Item(0)("SccCuentaID")
            End If

            
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
        objfrmCuentaEdit.CuentaID = Me.IdCuenta
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