'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
''-- Fecha de Elaboración    : 4 de Abril de Mayo.
''------------------------------------------------------------------------------------------------
''--    Formulario de Edición y Modificación de Devolución.
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles

Public Class frmSccEditDevolucion
    Dim m_IDDevolucion As Integer
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim m_TypeGui As Integer
    Dim DtDatosFacturas As DataTable
    Dim DtSucursal As New DataTable
    Dim m_IDEstado As Integer
    Dim m_IDFactura As Integer
    Dim m_BoolGuardado As Boolean

    Property BoolGuardado() As Boolean
        Get
            BoolGuardado = Me.m_BoolGuardado
        End Get
        Set(ByVal value As Boolean)
            Me.m_BoolGuardado = value
        End Set
    End Property

    Property IDFactura() As Integer
        Get
            IDFactura = Me.m_IDFactura
        End Get
        Set(ByVal value As Integer)
            Me.m_IDFactura = value
        End Set
    End Property

    Property IDEstado() As Integer
        Get
            IDEstado = Me.m_IDEstado
        End Get
        Set(ByVal value As Integer)
            Me.m_IDEstado = value
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

    Property IDDevolucion() As Integer
        Get
            IDDevolucion = m_IDDevolucion
        End Get
        Set(ByVal value As Integer)
            m_IDDevolucion = value
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

    Property IDTienda() As Integer
        Get
            IDTienda = m_IDTienda
        End Get
        Set(ByVal value As Integer)
            Me.m_IDTienda = value
        End Set
    End Property



    ''' <summary>
    ''' Procedimiento ecnargado de Mandar a Seleccionar el Expediente del para el cual se va a realizar la devolución.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 04 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SeleccionarCuenta()
        Try
            Try
                Dim objCuentasSeleccion As New frmSccSeleccionCuentas
                If objCuentasSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.txtNumCuenta.Text = objCuentasSeleccion.SccCuentaID
                    Me.IDCuenta = objCuentasSeleccion.SccCuentaID
                    Me.txtCliente.Text = objCuentasSeleccion.Cliente
                    Me.CargarFacturas()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar las facturas correspondientes.
    ''' Autor : Pedro Tinoco Salgado.
    ''' Fecha : 3 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarFacturas()
        Dim Registrada As Integer
        Dim Cancelada As Integer
        Try
            Registrada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
            Cancelada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "02")
            Me.DtDatosFacturas = New DataTable

            If Me.TypeGui = 0 Then
                DtDatosFacturas = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Numero,Fecha,FechaVencimiento,NoCuotas,Saldo,MontoAbonado,MontoCuota,Termino,SfaFacturaID,MontoCredito", "vwFacturas", "objEstadoID<>" & Registrada.ToString & " AND objEstadoID <> " & Cancelada.ToString & " AND objSccCuentaID='" & Me.IDCuenta & "'"))
            Else
                DtDatosFacturas = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Numero,Fecha,FechaVencimiento,NoCuotas,Saldo,MontoAbonado,MontoCuota,Termino,SfaFacturaID,MontoCredito", "vwFacturas", "objEstadoID<>" & Registrada.ToString & " AND objSccCuentaID='" & Me.IDCuenta & "'"))
            End If
            Me.grdFacturas.SetDataBinding(Me.DtDatosFacturas, "", True)

            If DtDatosFacturas.DefaultView.Count > 0 Then
                Me.numTotal.Value = SccCuentaPorCobrar.RetrieveDT("SccCuentaID='" & Me.IDCuenta & "'", , "Saldo").DefaultView.Item(0)("Saldo")
                Me.IDFactura = Me.DtDatosFacturas.DefaultView.Item(0)("SfaFacturaID")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
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
            Valor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetValorCatalogoID('ESTADODEVOLUCION'," + IdEstado.ToString + ",1) as Estado").DefaultView.Item(0)("Estado")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Valor
    End Function

    Private Sub frmSccEditDevolucion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case Me.TypeGui
            Case 0
                Me.Text = "Nueva Devolución"
                Me.IDEstado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADODEVOLUCION", "REGISTRADA")
                Me.txtEstado.Text = Me.CargarEstados(Me.IDEstado)
            Case 1
                Me.Text = "Edición de Devolución"
                Me.CargarDatosEdicion()
                Me.cmdExpediente.Enabled = False
            Case 2
                Me.Text = "Consulta de Devolución"
                Me.CargarDatosEdicion()
                Me.dtpFecha.Enabled = False
                Me.cmdExpediente.Enabled = False
                Me.cmdAutorizar.Enabled = False
                Me.cmdGuardar.Enabled = False
        End Select


    End Sub

    Private Sub cmdExpediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpediente.Click
        Me.ErrorProvider.Clear()
        Me.SeleccionarCuenta()
    End Sub

#Region "Guardar Devolucion"

    Private Function GuardarDevolucion() As Boolean
        Dim T As New TransactionManager
        Dim SccDev As New SccDevolucion
        Try
            Try
                T.BeginTran()
                SccDev.Numero = SccDevolucion.RetrieveDT(, , "ISNULL(MAX(Numero),0) + 1 as Maximo", T).DefaultView.Item(0)("Maximo")
                
                SccDev.objSccCuentaID = Me.IDCuenta
                SccDev.objEstadoID = Me.IDEstado
                SccDev.TotalDevolucion = Me.numTotal.Value
                SccDev.UsuarioCreacion = clsProyecto.Conexion.Usuario
                SccDev.FechaCreacion = clsProyecto.Conexion.FechaServidor
                SccDev.Fecha = Me.dtpFecha.Value
                SccDev.objSfaFacturasID = Me.IDFactura
                SccDev.Insert(T)
                Me.IDDevolucion = SccDev.SccDevolucionID
                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.dtpFecha.Enabled = False
                Me.cmdExpediente.Enabled = False
                Me.cmdGuardar.Enabled = False
                Me.cmdAutorizar.Enabled = True
                Me.ToolTip.Show("Si Desea autorizar la Devolución" & _
                "Presione botón autorizar desde esta pantalla o la Principal", Me.lblInfo, 15000)
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


    ''' <summary>
    ''' Procedimiento encargado de Actualizar la Devolucion Actual.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 6 de Abril de 2009.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ActualizarDevolucion() As Boolean
        Dim objDevolucion As SccDevolucion
        Dim T As New TransactionManager
        Try
            Try

                T.BeginTran()
                objDevolucion = New SccDevolucion
                objDevolucion.Retrieve(Me.IDDevolucion)
                objDevolucion.Fecha = Me.dtpFecha.Value
                
                objDevolucion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objDevolucion.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objDevolucion.Update(T)
                T.CommitTran()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.dtpFecha.Enabled = False
                Me.cmdExpediente.Enabled = False
                Me.cmdGuardar.Enabled = False
                Me.cmdAutorizar.Enabled = True
                Me.ToolTip.Show("Si Desea autorizar la Devolución" & _
                "Presione botón autorizar desde esta pantalla o la Principal", Me.lblInfo, 15000)
                Return True

            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            T = Nothing
            objDevolucion = Nothing
        End Try
    End Function
#End Region


#Region "Autorizar Devolucion"

    ''' <summary>
    ''' Procedimiento encargado de autorizar la devolución correspondiente
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 6 de Abril de 2009.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AutorizarDevolucion() As Boolean
        Dim objDevolucion As New SccDevolucion
        Dim objSccCuentaCobrar As New SccCuentaPorCobrar
        Dim objSccCuentaDetalle As New SccCuentaPorCobrarDetalle

        Dim DtDatosFactura As New DataTable
        Dim IDEstadoN As Integer
        Dim T As New TransactionManager

        Try
            Try
                T.BeginTran()
                objDevolucion.Retrieve(Me.IDDevolucion, T)
                objDevolucion.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADODEVOLUCION", "AUTORIZADA")
                objDevolucion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objDevolucion.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objDevolucion.Update(T)

                DtDatosFactura = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID='" & objDevolucion.objSccCuentaID & "' AND objSfaFacturaID IS NOT NULL", , , T)
                IDEstadoN = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "03")
                For Each drw As DataRow In DtDatosFactura.Rows
                    drw("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                    drw("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                    drw("objEstadoID") = IDEstadoN
                Next
                DtDatosFactura.TableName = "SccCuentaPorCobrarDetalle"
                SccCuentaPorCobrarDetalle.BatchUpdate(DtDatosFactura.DataSet, T)

                objSccCuentaCobrar.Retrieve(objDevolucion.objSccCuentaID, T)
                objSccCuentaCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSccCuentaCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSccCuentaCobrar.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "DEVOLUCION")
                objSccCuentaCobrar.Update(T)

                T.CommitTran()
                MsgBox("Autorización de Devolución Exitosa", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objDevolucion = Nothing
            objSccCuentaCobrar = Nothing
            objSccCuentaDetalle = Nothing
        End Try
    End Function
#End Region


#Region "Validaciones de Datos"
    Private Function Validaciones() As Boolean
        Try
            If Trim(Me.dtpFecha.Text) = "" Then
                Me.ErrorProvider.SetError(Me.dtpFecha, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Trim(Me.txtNumCuenta.Text) = "" Then
                Me.ErrorProvider.SetError(Me.txtNumCuenta, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.grdFacturas.RowCount = 0 Then
                Me.ErrorProvider.SetError(Me.grdFacturas, "Facturas son Obligatorias")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region



    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Select Case Me.TypeGui
            Case 0
                If Me.Validaciones Then
                    Me.BoolGuardado = Me.GuardarDevolucion                    
                End If
            Case 1
                If Me.Validaciones Then
                    Me.BoolGuardado = Me.ActualizarDevolucion
                End If
        End Select
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.TextChanged
        Me.ErrorProvider.Clear()
    End Sub

#Region "Carga de Datos Edición"
    ''' <summary>
    ''' Procedimiento encargado de cargar los datos en modo edicion
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 6 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatosEdicion()
        Dim objSccDev As New SccDevolucion
        Dim DtDatosCuenta As New DataTable
        Try
            objSccDev.Retrieve(Me.IDDevolucion)
            Me.dtpFecha.Value = objSccDev.Fecha
            Me.IDCuenta = objSccDev.objSccCuentaID
            Me.txtEstado.Text = Me.CargarEstados(objSccDev.objEstadoID)

            DtDatosCuenta.Reset()
            DtDatosCuenta = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccCuentaID,Cliente,NumeroDevolucion", "vwSccDevolucion", "SccDevolucionID =" & Me.IDDevolucion))
            Me.txtNumCuenta.Text = DtDatosCuenta.DefaultView.Item(0)("SccCuentaID")
            Me.txtCliente.Text = DtDatosCuenta.DefaultView.Item(0)("Cliente")
            Me.txtNumero.Text = DtDatosCuenta.DefaultView.Item(0)("NumeroDevolucion")
            Me.CargarFacturas()
            If Me.TypeGui = 2 Then
                Me.numTotal.Value = objSccDev.TotalDevolucion
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

    Private Sub cmdAutorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorizar.Click
        Me.BoolGuardado = Me.AutorizarDevolucion()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.ToolTip.Hide(Me.lblInfo)
        If Me.BoolGuardado Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
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
        objfrmCuentaEdit.TypeGUI = 2
        objfrmCuentaEdit.ShowDialog(Me)
    End Sub
End Class