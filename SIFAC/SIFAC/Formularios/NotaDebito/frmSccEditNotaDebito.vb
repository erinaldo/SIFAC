'-----------------------------------------------------------------------
''----------------------------------------------------------------------
''-------------------------------------------------------------------------
''--    Formulario de Edici�n y Modificaci�n de C�talogo Nota de D�bito
''-------------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports SIFAC.BO

Public Class frmSccEditNotaDebito
    Dim DtEmpleado, dtCajas As DataTable
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim dtConcepto As DataTable
    Dim dtEstado As DataTable
    Dim m_TypeGui As Integer
    Dim m_IDNotaDebito As Integer
    Dim DtFacturas As New DataTable
    Dim intComisionID As Integer
    Dim StrTipo As String

    Property IDComisionID() As Integer
        Get
            IDComisionID = Me.intComisionID
        End Get
        Set(ByVal value As Integer)
            Me.intComisionID = value
        End Set
    End Property

    Property IDNotaDebito() As Integer
        Get
            IDNotaDebito = Me.m_IDNotaDebito
        End Get
        Set(ByVal value As Integer)
            Me.m_IDNotaDebito = value
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

    Property Tipo() As String
        Get
            Tipo = Me.StrTipo
        End Get
        Set(ByVal value As String)
            Me.StrTipo = value
        End Set
    End Property

#Region "Cargar Empleados"

    '' Descripci�n:        Procedimiento encargado de cargar el combo de jefe de tienda
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

    '' Descripci�n:        Procedimiento encargado de cargar el combo de jefe de tienda
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
                Me.CargarFacturas()
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
            Me.dtConcepto = ClsCatalogos.ObtenerValCat("CONCEPTOND")
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
        Dim obj As Object
        Try
            If Tipo <> "Comisiones" And Tipo <> "Salida" Then
                If Me.grdFacturas.RowCount = 0 Then
                    Return False
                    Exit Function
                End If


                If Not Me.DtFacturas Is Nothing Then
                    obj = Me.DtFacturas.Compute("COUNT(Seleccion)", "Seleccion=1")
                    If Not IsDBNull(obj) Then
                        If obj = 0 Then
                            MsgBox("Necesita Seleccionar una Factura", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                            Return False
                            Exit Function
                        End If
                    End If
                Else
                    MsgBox("No hay facturas cargadas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                End If
            End If

            If IsDBNull(Me.dtpFecha.Value) Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.dtpFecha.Value > clsProyecto.Conexion.FechaServidor Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Fecha de Nota de Cr�dito Incorrecta")
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
    Private Function GuardarND() As Boolean
        Dim T As New TransactionManager
        Dim objNC As New SccNotaDebito
        Dim BoolRst As Boolean
        Dim DtDatos(1) As DataRow
        Try
            Try

                BoolRst = False
                T.BeginTran()
                objNC.Descripcion = Me.txtDescripcion.Text
                objNC.Fecha = Me.dtpFecha.Value
                objNC.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objNC.Monto = Me.numMonto.Value
                objNC.objConceptoID = cmbConcepto.SelectedValue
                objNC.objEstadoID = Me.cmbEstado.SelectedValue

                objNC.Numero = SccNotaDebito.RetrieveDT(, , "(ISNULL(MAX(Numero),0) + 1) as Maximo", T).DefaultView.Item(0)("Maximo")
                objNC.UsuarioCreacion = clsProyecto.Conexion.Usuario

                If Tipo <> "Comisiones" And Tipo <> "Salida" Then
                    objNC.objSccCuentaID = Me.IdCuenta
                    DtDatos = Me.DtFacturas.Select("Seleccion = 1")
                    objNC.objFacturaID = DtDatos(0)("SfaFacturaID")
                End If
               
                objNC.objCajaID = cmbCajas.SelectedValue
                If IDComisionID <> 0 And IDComisionID.ToString.Trim.Length <> 0 Then
                    objNC.objEmpleadoID = cmbEmpleado.SelectedValue
                End If
                objNC.Insert(T)
                Me.IDNotaDebito = objNC.SccNotaDebitoID

                If Tipo = "Comisiones" Then
                    Dim objComision As New SccComisiones
                    objComision.Retrieve(IDComisionID)
                    objComision.objNotaDebitoID = IDNotaDebito
                    objComision.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objComision.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objComision.Update(T)
                End If

                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                BoolRst = True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            DtDatos = Nothing
            objNC = Nothing
            T = Nothing
        End Try

        Return BoolRst
    End Function
#End Region

    Private Sub frmSccEditNotaCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargaDatos()

    End Sub

    ''' <summary>
    ''' Procedimiento principal de Carga de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaDatos()
        Try
            Me.CargarConceptoNC()
            Me.CargarEstado()
            CargarEmpleado()
            CargarCajas()

            If Me.TypeGui > 0 Then
                Me.CargarDatosEdicion()
                If Me.TypeGui = 2 Then
                    Me.dtpFecha.Enabled = False
                    Me.txtDescripcion.Enabled = False
                    txtCliente.Enabled = False
                    txtNumCuenta.Enabled = False
                    Me.cmbConcepto.Enabled = False
                    Me.numMonto.Enabled = False
                    cmbCajas.Enabled = False
                    cmbEmpleado.Enabled = False
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
                Me.grdFacturas.Enabled = False
                Me.txtDescripcion.Text = "Pago de comision a " & cmbEmpleado.Text

                Me.cmbEstado.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOND", "PAGADA")
                Me.cmbConcepto.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTOND", "PAGOCOMISION")
                Me.numMonto.Value = objComision.Monto
                Me.cmbEmpleado.SelectedValue = objComision.objEmpleadoID
                Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
                Me.dtpFecha.Value = objComision.Fecha
            End If

            'If Tipo = "Comisiones" Then
            '    Me.cmbEmpleado.Visible = True
            'Else
            '    Me.cmbEmpleado.Visible = False
            'End If

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
                Me.grdFacturas.Enabled = False
                Me.cmbConcepto.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTOND", "SALIDAEFEC")
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar las estados posibles de las notas de credito
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEstado()
        Try
            dtEstado = New DataTable
            dtEstado = ClsCatalogos.ObtenerValCat("ESTADOND")
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
                Me.cmbEstado.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOND", "REGISTRADA")
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
        Dim objNotDeb As New SccNotaDebito
        Try
            Try

                dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*", "vwSccNotaDebito", "SccNotaDebitoID=" & Me.IDNotaDebito.ToString))
                Me.cmbEstado.SelectedValue = dtDatos.DefaultView.Item(0)("objEstadoID")
                Me.cmbConcepto.SelectedValue = dtDatos.DefaultView.Item(0)("objConceptoID")
                Me.txtNumero.Text = dtDatos.DefaultView.Item(0)("NumeroND")
                Me.txtDescripcion.Text = dtDatos.DefaultView.Item(0)("Descripcion")

                If Not IsDBNull(dtDatos.DefaultView.Item(0)("Cliente")) Then
                    Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Cliente")
                End If

                If Not IsDBNull(dtDatos.DefaultView.Item(0)("SccCuentaID")) Then
                    Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("SccCuentaID")
                End If

                If Not IsDBNull(dtDatos.DefaultView.Item(0)("SccCuentaID")) Then
                    Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("SccCuentaID")
                End If

                If Not IsDBNull(dtDatos.DefaultView.Item(0)("objCajaID")) Then
                    Me.cmbCajas.SelectedValue = dtDatos.DefaultView.Item(0)("objCajaID")
                End If

                If Not IsDBNull(dtDatos.DefaultView.Item(0)("objEmpleadoID")) Then
                    Me.cmbEmpleado.SelectedValue = dtDatos.DefaultView.Item(0)("objEmpleadoID")
                End If

                Me.numMonto.Value = dtDatos.DefaultView.Item(0)("Monto")
                Me.dtpFecha.Value = dtDatos.DefaultView.Item(0)("Fecha")
                objNotDeb.Retrieve(Me.IDNotaDebito)

                If Not objNotDeb.objSccCuentaID Then
                    Me.IdCuenta = objNotDeb.objSccCuentaID
                End If

                Me.CargarFacturas()
                For Each drw As DataRow In Me.DtFacturas.Rows
                    If drw("SfaFacturaID") = objNotDeb.objFacturaID.Value Then
                        drw("Seleccion") = True
                    End If
                Next
                Me.grdFacturas.Splits(0).Locked = True
                Me.cmdExpediente.Enabled = False
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            objNotDeb = Nothing
        End Try
    End Sub






    ''' <summary>
    ''' Procedimiento encargad de Actualizar Nota de Credito.
    ''' Autor : Pedro Tinoco Salgado.
    ''' Fecha : 26 de Marzo de 2009.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ActualizarND() As Boolean
        Dim T As New TransactionManager
        Dim objNotaDebito As New SccNotaDebito
        Dim boolrst As Boolean
        Try
            boolrst = False
            objNotaDebito.Retrieve(Me.IDNotaDebito)
            T.BeginTran()
            objNotaDebito.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objNotaDebito.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objNotaDebito.Fecha = Me.dtpFecha.Value
            objNotaDebito.objConceptoID = Me.cmbConcepto.SelectedValue
            objNotaDebito.Monto = Me.numMonto.Value
            objNotaDebito.SccNotaDebitoID = Me.IDNotaDebito
            objNotaDebito.Update(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
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


    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.ValidarDatos Then
            Select Case Me.TypeGui
                Case 0
                    If Me.GuardarND Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                Case 1
                    If Me.ActualizarND Then
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

    ''' <summary>
    ''' Procedimiento encargado de Cargar las facturas a seleccionar para la nota de Debito.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarFacturas()
        Dim IDEstadoVig As Integer
        Try

            If Me.TypeGui < 2 Then
                IDEstadoVig = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")
                DtFacturas = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SfaFacturaID,Numero,Cast(0 as BIT) as Seleccion", "vwFacturas", "objSccCuentaID ='" & Me.IdCuenta & "'" & "  AND objEstadoID =" & IDEstadoVig.ToString))
            Else
                IDEstadoVig = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
                DtFacturas = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SfaFacturaID,Numero,Cast(0 as BIT) as Seleccion", "vwFacturas", "objSccCuentaID ='" & Me.IdCuenta & "'" & "  AND objEstadoID <>" & IDEstadoVig.ToString))

            End If

            Me.grdFacturas.SetDataBinding(DtFacturas, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdFacturas_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdFacturas.AfterColUpdate
        Dim obj As New Object
        Try
            If e.Column.Name = "Selecci�n" Then
                obj = Me.DtFacturas.Compute("Count(Seleccion)", "Seleccion=1")
                If obj > 0 Then
                    Me.DtFacturas.DefaultView.Item(Me.grdFacturas.RowBookmark(Me.grdFacturas.Row))("Seleccion") = False
                    Me.DtFacturas.AcceptChanges()
                End If
            End If
        Finally
            obj = Nothing
        End Try
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
                Me.ErrorProv.SetError(Me.numMonto, "Valor fuera de rango. Valor M�ximo : " & ValorMaximo)
                Me.numMonto.Value = 0
            Else
                Me.ErrorProv.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProv.SetError(Me.numMonto, "Valor fuera de rango. Valor M�ximo : " & ValorMaximo)
            Me.numMonto.Value = 0
        End Try
    End Sub
End Class