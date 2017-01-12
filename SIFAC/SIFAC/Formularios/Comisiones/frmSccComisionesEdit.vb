Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Public Class frmSccComisionesEdit

#Region "Declaracion de Variables"
    Public DtEmpleado, dtEstados, dtCajeros As DataTable
    Public dtDetallecomision As DataTable
    Public intTypeGui As Integer
    Public intComisionID As Integer
    Public boolEditado As Boolean
    Dim fechaServidor As Date
    Dim strTipo As String
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property ComisionID() As Integer
        Get
            Return intComisionID
        End Get
        Set(ByVal value As Integer)
            intComisionID = value
        End Set
    End Property


    Property Tipo() As String
        Get
            Return strTipo
        End Get
        Set(ByVal value As String)
            strTipo = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Cargar comision"

    '' Descripción:        Procedimiento encargado de mostrar los datos de una comision en modo de edición
    Public Sub CargarDatosComision()
        Dim objComision As SccComisiones
        Try
            objComision = New SccComisiones
            objComision.Retrieve(ComisionID)

            cmbEmpleado.SelectedValue = objComision.objEmpleadoID
            SpnPorcentaje.Value = objComision.Porcentaje
            SpnTotal.Value = objComision.Monto
            dtDesde.EditValue = objComision.Fecha
            SpnTotalRecuperado.Value = objComision.TotalRecuperado
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objComision = Nothing
        End Try
    End Sub
#End Region

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

#Region "Cargar Cajeros"
    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarCajeros()
        Try
            dtCajeros = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))

            cmbCajero.DataSource = dtCajeros
            cmbCajero.ValueMember = "SrhEmpleadoID"
            cmbCajero.DisplayMember = "NombreCompleto"

            cmbCajero.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Nuevo Empleado"
    Public Sub NuevoEmpleado()
        Dim editEmpleado As frmSrhEmpleadoEditar
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 0
            If editEmpleado.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarEmpleado()
                cmbEmpleado.SelectedValue = editEmpleado.intEmpleadoID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#Region "Consutar Empleado"
    Public Sub ConsultarEmpleado()
        Dim editEmpleado As frmSrhEmpleadoEditar
        Dim objEmpleado As New SrhEmpleado
        Try
            Me.Cursor = WaitCursor
            editEmpleado = New frmSrhEmpleadoEditar
            editEmpleado.TypeGUI = 2
            editEmpleado.EmpleadoID = Me.cmbEmpleado.SelectedValue
            objEmpleado.Retrieve(Me.cmbEmpleado.SelectedValue)
            editEmpleado.PersonaID = objEmpleado.objPersonaID
            editEmpleado.Text = "Consultar Empleado"
            editEmpleado.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region


#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarCajeros()
            CargarEmpleado()

            Select Case TypeGui
                Case 0
                    Me.Text = "Nueva Comision"
                    Me.dtDesde.EditValue = Date.Now
                    Me.dtHasta.EditValue = Date.Now
                    If Tipo = "Sincronizacion" Then
                        dtDesde.Enabled = False
                    Else
                        lblCaja.Text = "Caja: " & frmPrincipal.gblCaja
                    End If
                    Me.txtEstado.Enabled = False
                Case 1
                    Me.Text = "Editar Comision"
                    Me.dtDesde.Enabled = False
                    Me.txtEstado.Enabled = False
                    Me.CargarDatosComision()
                Case 2
                    Me.Text = "Consultar Comision"
                    Me.CargarDatosComision()
                    Me.cmbEmpleado.Enabled = False
                    Me.SpnTotalRecuperado.Enabled = False
                    Me.SpnPorcentaje.Enabled = False
                    Me.SpnTotal.Enabled = False
                    Me.dtDesde.Enabled = False
                    Me.txtEstado.Enabled = False
                    Me.cmdGuardar.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Calculos"

    Private Sub TotalRecaudado()
        Dim dtRecudado As New DataTable
        Try
            If dtDesde.Text <> String.Empty Then
                Dim fechaDesde As String = dtDesde.DateTime.ToString("yyyyMMdd")
                Dim fechaHasta As String = dtHasta.DateTime.ToString("yyyyMMdd")

                dtRecudado = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("TotalRecaudado", "vwRecuperacionVendedor", "objSrhEmpleado =" & cmbEmpleado.SelectedValue & " And convert(varchar(10),Fecha,112)>='" & fechaDesde & "' AND convert(varchar(10),Fecha,112)<='" & fechaHasta & "'"))
                dtDetallecomision = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*", "vwRecuperacionVendedorDetalle", "objSrhEmpleado =" & cmbEmpleado.SelectedValue & " And convert(varchar(10),Fecha,112)>='" & fechaDesde & "' AND convert(varchar(10),Fecha,112)<='" & fechaHasta & "'"))
              
                If dtRecudado.Rows.Count > 0 Then
                    SpnTotalRecuperado.Value = dtRecudado.Rows(0)("TotalRecaudado")
                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarTotalComision()
        Try
            If SpnPorcentaje.Value <> 0 Then
                SpnTotal.Value = ((SpnPorcentaje.Value / 100) * SpnTotalRecuperado.Value)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region


#Region "Guardar Comision"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub GuardarComisiones()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearComision(T)
            GuardarRecuperacion(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de guardar los datos de una tienda
    Public Sub CrearComision(ByVal T As DAL.TransactionManager)
        Dim objComision As SccComisiones
        Try
            objComision = New SccComisiones
            objComision.objEmpleadoID = cmbEmpleado.SelectedValue
            objComision.Porcentaje = SpnPorcentaje.Value
            objComision.Monto = SpnTotal.Value
            objComision.Fecha = dtDesde.EditValue
            objComision.Desde = dtDesde.EditValue
            objComision.Hasta = dtHasta.EditValue
            objComision.TotalRecuperado = SpnTotalRecuperado.Value
            objComision.Activa = True
            objComision.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objComision.FechaCreacion = fechaServidor
            objComision.Insert(T)
            ComisionID = objComision.SccComisionID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Public Sub GuardarRecuperacion(ByVal T As DAL.TransactionManager)
        Dim objRecuperacion As SccRecuperacion
        Try
            objRecuperacion = New SccRecuperacion

            For Each drw As DataRow In Me.dtDetallecomision.Rows
                objRecuperacion.objComisionID = ComisionID
                objRecuperacion.Fecha = dtFechaPago.EditValue
                objRecuperacion.objRutaID = drw("objRutaID")
                objRecuperacion.objCobradorID = cmbEmpleado.SelectedValue
                objRecuperacion.objSccCuentaID = drw("SccCuentaID")
                objRecuperacion.Monto = drw("TotalRecaudado")
                objRecuperacion.FecchaCreacion = clsProyecto.Conexion.FechaServidor
                objRecuperacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objRecuperacion.Insert(T)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Actualizar Comision"

    '' Descripción:        Procedimiento encargado de actualizar comision
    Public Sub ActualizarComision()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosComision(T)
            ModificarRecuperacion(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de modificar los datos de una tienda
    Public Sub ModificarDatosComision(ByVal T As DAL.TransactionManager)
        Dim objComision As SccComisiones
        Try
            objComision = New SccComisiones
            objComision.SccComisionID = ComisionID
            objComision.objEmpleadoID = cmbEmpleado.SelectedValue
            objComision.Porcentaje = SpnPorcentaje.Value
            objComision.Monto = SpnTotal.Value
            objComision.Fecha = dtFechaPago.EditValue
            objComision.Desde = dtDesde.EditValue
            objComision.Hasta = dtHasta.EditValue
            objComision.TotalRecuperado = SpnTotalRecuperado.Value
            objComision.Activa = True
            objComision.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objComision.FechaModificacion = fechaServidor
            objComision.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objComision = Nothing
        End Try
    End Sub

    Public Sub ModificarRecuperacion(ByVal T As DAL.TransactionManager)
        Dim objRecuperacion As SccRecuperacion
        Try
            objRecuperacion = New SccRecuperacion

            ''Eliminar recuperacion
            objRecuperacion.RetrieveByFilter("objComisionID=" & ComisionID, T)

            For Each drw As DataRow In Me.dtDetallecomision.Rows
                objRecuperacion.objComisionID = ComisionID
                objRecuperacion.Fecha = dtFechaPago.EditValue
                objRecuperacion.objRutaID = drw("objRutaID")
                objRecuperacion.objCobradorID = cmbEmpleado.SelectedValue
                objRecuperacion.objSccCuentaID = drw("SccCuentaID")
                objRecuperacion.Monto = drw("TotalRecaudado")
                objRecuperacion.FecchaCreacion = clsProyecto.Conexion.FechaServidor
                objRecuperacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objRecuperacion.Update(T)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#End Region


#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Dim dtVerificarFechaEmpleado As DataTable
        Try
            If cmbEmpleado.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbEmpleado, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If SpnTotalRecuperado.Text.Trim.Length = 0 Or SpnTotal.Value = 0 Then
                ErrorProv.SetError(SpnTotalRecuperado, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If SpnPorcentaje.Text.Trim.Length = 0 Or SpnPorcentaje.Value = 0 Then
                ErrorProv.SetError(SpnPorcentaje, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If SpnTotal.Text.Trim.Length = 0 Or SpnTotal.Value = 0 Then
                ErrorProv.SetError(SpnTotal, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            ''Validar que no existe una comision registara para este dia y para el mismo vendedor           

            Select Case TypeGui
                Case 0
                    dtVerificarFechaEmpleado = SccComisiones.RetrieveDT(" Activa =1 and convert(varchar(10),Fecha,112)='" & dtDesde.DateTime.ToString("yyyyMMdd") & "'", , "*")

                    If dtVerificarFechaEmpleado.Rows.Count > 0 Then
                        ErrorProv.SetError(dtDesde, "Existe una comision registrada para este dia.")
                        Return False
                    End If
                Case 1
                    dtVerificarFechaEmpleado = SccComisiones.RetrieveDT(" Activa =1 and convert(varchar(10),Fecha,112)='" & dtDesde.DateTime.ToString("yyyyMMdd") & "' and SccComisionID<>" & ComisionID, , "*")

                    If dtVerificarFechaEmpleado.Rows.Count > 0 Then
                        ErrorProv.SetError(dtDesde, "Existe una comision registrada para este dia.")
                        Return False
                    End If
            End Select


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#End Region

#Region "Eventos del Formulario"

    Private Sub frmSccComisionesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub cmdJefe_Click(sender As Object, e As EventArgs) Handles cmdJefe.Click
        Try
            If cmbEmpleado.SelectedIndex = -1 Then
                Me.NuevoEmpleado()
            Else
                Me.ConsultarEmpleado()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 0
                    GuardarComisiones()
                Case 1
                    ActualizarComision()
            End Select
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub


    Private Sub cmbEmpleado_TextChanged(sender As Object, e As EventArgs) Handles cmbEmpleado.TextChanged

        ErrorProv.Clear()
        boolEditado = True
    End Sub

    Private Sub dtFecha_TextChanged(sender As Object, e As EventArgs) Handles dtDesde.TextChanged
        ErrorProv.Clear()
        boolEditado = True
    End Sub


    Private Sub SpnTotal_TextChanged(sender As Object, e As EventArgs) Handles SpnTotal.TextChanged
        ErrorProv.Clear()
        boolEditado = True
    End Sub

    Private Sub SpnPorcentaje_TextChanged(sender As Object, e As EventArgs) Handles SpnPorcentaje.TextChanged
        ErrorProv.Clear()
        boolEditado = True
    End Sub
 


    Private Sub SpnPorcentaje_EditValueChanged(sender As Object, e As EventArgs) Handles SpnPorcentaje.EditValueChanged
        CargarTotalComision()
    End Sub

    Private Sub cmdVerDetalle_Click(sender As Object, e As EventArgs) Handles cmdVerDetalle.Click
        Try
            Dim objDetallecomision As New frmDetalleComision()

            objDetallecomision.dtDetallecomision = dtDetallecomision
            objDetallecomision.ShowDialog()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        TotalRecaudado()
    End Sub

#End Region

  
   
    
 
End Class