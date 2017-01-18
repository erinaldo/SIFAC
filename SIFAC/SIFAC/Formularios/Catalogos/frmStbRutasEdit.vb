Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos

Public Class frmStbRutasEdit

#Region "Declaracion de Variables"
    Public DtMarca, DtCiudad, DtSegmento As DataTable
    Public DtCobrador, DtSupervisor, DtDias As DataTable
    Public intTypeGui As Integer
    Public intRutaID As Integer
    Public boolEditado As Boolean
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

    Property RutaID() As Integer
        Get
            Return intRutaID
        End Get
        Set(ByVal value As Integer)
            intRutaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripción:        Procedimiento encargado de cargar el combo de Cobrador
    Public Sub CargarDias()
        Try
            DtDias = New DataTable("Dias")
            Dim FNameColumn As New DataColumn("NombreDia")
            Dim FNumeroColumn As New DataColumn("IDDia")

            FNameColumn.DataType = GetType(String)
            FNumeroColumn.DataType = GetType(Integer)

            DtDias.Columns.Add(FNameColumn)
            DtDias.Columns.Add(FNumeroColumn)

            Dim newDiasRow As DataRow

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "0"
            newDiasRow("NombreDia") = "Ninguno"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "1"
            newDiasRow("NombreDia") = "Domingo"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "2"
            newDiasRow("NombreDia") = "Lunes"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "3"
            newDiasRow("NombreDia") = "Martes"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "4"
            newDiasRow("NombreDia") = "Miercoles"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "5"
            newDiasRow("NombreDia") = "Jueves"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "6"
            newDiasRow("NombreDia") = "Viernes"
            DtDias.Rows.Add(newDiasRow)

            newDiasRow = DtDias.NewRow()
            newDiasRow("IDDia") = "7"
            newDiasRow("NombreDia") = "Sabado"
            DtDias.Rows.Add(newDiasRow)

            With cmbDiaCrobro
                .DataSource = DtDias
                .DisplayMember = "NombreDia"
                .ValueMember = "IDDia"
                .Splits(0).DisplayColumns("IDDia").Visible = False
                .ColumnHeaders = False
                .ExtendRightColumn = True
                .SelectedValue = -1
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar el combo de Cobrador
    Public Sub CargarCobrador()
        Try
            DtCobrador = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))
            cbxCobrador.ValueMember = "SrhEmpleadoID"
            cbxCobrador.DisplayMember = "NombreCompleto"
            cbxCobrador.DataSource = DtCobrador
            cbxCobrador.SelectedIndex = -1

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Public Sub CargarSupervisor()
        Try
            DtSupervisor = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SrhEmpleadoID,NombreCompleto,objPersonaID", "vwSrhEmpleado", "Activo =1"))

            cmbSupervisor.ValueMember = "SrhEmpleadoID"
            cmbSupervisor.DisplayMember = "NombreCompleto"
            cmbSupervisor.DataSource = DtSupervisor
            cmbSupervisor.SelectedIndex = -1
          
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            txtNombre.Focus()
            CargarSupervisor()
            CargarCobrador()
            CargarCiudad()
            CargarDias()
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Ruta"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False
                Case 1
                    Me.Text = "Editar Ruta"
                    CargarDatosRuta()
                    chkActivo.Enabled = True
                Case 2
                    Me.Text = "Consultar Ruta"
                    CargarDatosRuta()
                    txtNombre.Enabled = False
                    cmbCiudad.Enabled = False
                    txtDescripcion.Enabled = False
                    cmbDiaCrobro.Enabled = False
                    cmbSupervisor.Enabled = False
                    cbxCobrador.Enabled = False
                    chkActivo.Enabled = False
                    ckdCargaDiferenciada.Enabled = False
                    cmdGuardar.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una marca
    Public Sub CargarDatosRuta()
        Dim objRutas As StbRutas
        Try
            objRutas = New StbRutas
            objRutas.Retrieve(RutaID)
            txtCodigo.Text = objRutas.Codigo
            txtNombre.Text = objRutas.Nombre
            cbxCobrador.SelectedValue = objRutas.ojbCobradorID
            cmbSupervisor.SelectedValue = objRutas.objSupervisor
            cmbDiaCrobro.SelectedValue = objRutas.DiaCobro
            cmbCiudad.SelectedValue = objRutas.objCiudadID
            chkActivo.Checked = objRutas.Activa
            ckdCargaDiferenciada.Checked = objRutas.CargarDiferenciada
            txtDescripcion.Text = objRutas.Descripcion
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRutas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de marca
    Public Sub GuardarRuta()
        Dim objRutas As StbRutas
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objRutas = New StbRutas
            objRutas.Nombre = txtNombre.Text.Trim
            objRutas.Descripcion = txtDescripcion.Text.Trim
            objRutas.Activa = chkActivo.Checked
            objRutas.ojbCobradorID = cbxCobrador.SelectedValue

            If Not cmbSupervisor.Text = "Ninguno" Then
                objRutas.objSupervisor = cmbSupervisor.SelectedValue
            End If

            objRutas.objCiudadID = cmbCiudad.SelectedValue
            objRutas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
            objRutas.DiaCobro = cmbDiaCrobro.SelectedValue
            objRutas.CargarDiferenciada = ckdCargaDiferenciada.Checked
            objRutas.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objRutas.FechaCreacion = clsProyecto.Conexion.FechaServidor

            objRutas.Insert(T)
            objRutas.Codigo = cbxCobrador.Text.Trim + "-" + cmbDiaCrobro.Text + "-" + cmbCiudad.Text.Trim
            objRutas.Nombre = "RUT" + cmbCiudad.Text.Substring(0, 3) + objRutas.StbRutaID.ToString

            objRutas.Update(T)
            T.CommitTran()
            txtCodigo.Text = objRutas.Codigo
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objRutas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de editar la informacion de una marca
    Public Sub EditarRuta()
        Dim objRutas As StbRutas
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objRutas = New StbRutas
            objRutas.StbRutaID = RutaID
            objRutas.Nombre = cbxCobrador.Text.Trim + "-" + cmbDiaCrobro.Text + "-" + cmbCiudad.Text.Trim
            objRutas.Descripcion = txtDescripcion.Text.Trim
            objRutas.Activa = chkActivo.Checked
            objRutas.Codigo = cbxCobrador.Text.Trim + "-" + cmbDiaCrobro.Text + "-" + cmbCiudad.Text.Trim
            'objRutas.Codigo = txtCodigo.Text
            objRutas.ojbCobradorID = cbxCobrador.SelectedValue

            If Not cmbSupervisor.Text = "Ninguno" Then
                objRutas.objSupervisor = cmbSupervisor.SelectedValue
            End If

            objRutas.objCiudadID = cmbCiudad.SelectedValue
            objRutas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbCiudad.SelectedValue).DefaultView(0)("objPaisID")
            objRutas.DiaCobro = cmbDiaCrobro.SelectedValue
            objRutas.CargarDiferenciada = ckdCargaDiferenciada.Checked
            objRutas.UsuarioModificacion = clsProyecto.Conexion.Servidor
            objRutas.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objRutas.Update(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objRutas = Nothing
        End Try
    End Sub

    Private Sub CargarCiudad()
       
        Try
            DtCiudad = StbZona.RetrieveDT("1=1", "", "StbZonaID,Nombre")

            cmbCiudad.ValueMember = "StbZonaID"
            cmbCiudad.DisplayMember = "Nombre"
            cmbCiudad.DataSource = DtCiudad
            cmbCiudad.SelectedItem = -1

        Catch ex As Exception
            clsError.CaptarError(ex)
       

        End Try
    End Sub

#End Region

#Region "Funciones"


    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Dim objStbRuta, objPCompara As StbRutas
        Dim dtCompara As DataTable
        Try

            If txtNombre.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtNombre, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbDiaCrobro.Text.Trim.Length = 0 Or cmbDiaCrobro.Text = "Ninguno" Then
                ErrorProv.SetError(cmbDiaCrobro, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbCiudad.Text.Trim.Length = 0 Or cmbCiudad.Text = "Ninguna" Then
                ErrorProv.SetError(cmbCiudad, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cbxCobrador.Text.Trim.Length = 0 Or cbxCobrador.Text = "Ninguno" Then
                ErrorProv.SetError(cbxCobrador, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbSupervisor.Text.Trim.Length = 0 Or cbxCobrador.Text = "Ninguno" Then
                ErrorProv.SetError(cmbSupervisor, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            ''Validar que no existe otra ruta, mismo vendedor, en el mismo dia y ciudad
            objStbRuta = New StbRutas
            
            dtCompara = StbRutas.RetrieveDT("ojbCobradorID=" & Me.cbxCobrador.SelectedValue & "  AND DiaCobro=" & cmbDiaCrobro.SelectedValue & " AND objCiudadID=" & cmbCiudad.SelectedValue & " AND Activa=1")

            Select Case TypeGui
                Case 0
                    If dtCompara.Rows.Count > 0 Then
                        Me.ErrorProv.SetError(Me.cbxCobrador, "Ya existe una ruta con estas caracteristicas.")
                        Me.cbxCobrador.Focus()
                        Exit Function
                    End If
                Case 1
                    If dtCompara.Rows.Count > 1 Then
                        Me.ErrorProv.SetError(Me.cbxCobrador, "Ya existe una ruta con estas caracteristicas.")
                        Me.cbxCobrador.Focus()
                        Exit Function
                    End If
            End Select
            

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

        Return True
    End Function
#End Region

#Region "Eventos del Formulario"

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            If ValidarEntrada() Then
                Select Case TypeGui
                    Case 0
                        GuardarRuta()
                    Case 1
                        EditarRuta()
                End Select

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub frmStbRutasEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConfigurarGUI()
            Me.boolEditado = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmStbRutasEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ErrorProv.SetError(txtNombre, "")
        boolEditado = True
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        ErrorProv.SetError(txtDescripcion, "")
        boolEditado = True
    End Sub

    Private Sub cbxCobrador_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.SetError(cbxCobrador, "")
        boolEditado = True
    End Sub

    Private Sub cmbSupervisor_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.SetError(cmbSupervisor, "")
        boolEditado = True
    End Sub

    Private Sub cmbCiudad_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.SetError(cmbCiudad, "")
        boolEditado = True
    End Sub

    Private Sub cmbDiaCrobro_TextChanged(sender As Object, e As EventArgs) Handles cmbDiaCrobro.TextChanged
        ErrorProv.SetError(cmbDiaCrobro, "")
        boolEditado = True
    End Sub

    Private Sub cbxCobrador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxCobrador.SelectedValueChanged
        ErrorProv.SetError(cbxCobrador, "")
        boolEditado = True
    End Sub

    Private Sub cmbSupervisor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbSupervisor.SelectedValueChanged
        ErrorProv.SetError(cmbSupervisor, "")
        boolEditado = True
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtNombre.Focus()
        End If
    End Sub
  
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cbxCobrador.Focus()
        End If
    End Sub

    Private Sub cbxCobrador_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.cmbSupervisor.Focus()
        End If
    End Sub

    Private Sub cmbSupervisor_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.cmbCiudad.Focus()
        End If
    End Sub

    Private Sub cmbCiudad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.cmbDiaCrobro.Focus()
        End If
    End Sub

    Private Sub cmbDiaCrobro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDiaCrobro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.chkActivo.Focus()
        End If
    End Sub

    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.ckdCargaDiferenciada.Focus()
        End If
    End Sub

    Private Sub ckdCargaDiferenciada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ckdCargaDiferenciada.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
    End Sub

    Private Sub cmdAgregarCategoria_Click(sender As Object, e As EventArgs) Handles cmdAgregarCategoria.Click
        Dim addZona As frmZonaEdit
        Try

            addZona = New frmZonaEdit
            addZona.TypeGui = 0
            If addZona.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarCiudad()
                Me.cmbCiudad.SelectedValue = addZona.MarcaID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            addZona = Nothing
        End Try
    End Sub

#End Region

  
    
   
End Class