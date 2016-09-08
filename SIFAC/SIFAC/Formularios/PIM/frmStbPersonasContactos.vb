Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Catalogos.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmStbPersonasContactos

#Region "Declaración de variables propias del formulario"
    Dim dtTiposPersonas, dtTiposEntradas As DataTable
#End Region

#Region "propiedades"
    Dim intFrmLlamado As Integer
    Dim intTypeGui As Integer
    Dim strStbTiendaID As String
    Dim strSecuencialContacto As String
    Dim strobjTipoEntrada As String

    Property frmLLamado() As Integer
        Get
            Return intFrmLlamado
        End Get
        Set(ByVal value As Integer)
            intFrmLlamado = value
        End Set
    End Property

    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property StbTienda() As String
        Get
            Return strStbTiendaID
        End Get
        Set(ByVal value As String)
            strStbTiendaID = value
        End Set
    End Property

    Property SecuencialContacto() As String
        Get
            Return strSecuencialContacto
        End Get
        Set(ByVal value As String)
            strSecuencialContacto = value
        End Set
    End Property

    Property objTipoEntrada() As String
        Get
            Return strobjTipoEntrada
        End Get
        Set(ByVal value As String)
            strobjTipoEntrada = value
        End Set
    End Property

#End Region

#Region "Cargar Combo Tipos de Persona"
    Private Sub CargarComboTipoPersona()
        Try
            Me.dtTiposPersonas = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("StbTiposEntradaID,Descripcion", "StbTiposEntrada"))
            Select Case frmLLamado
                Case 0 ' en caso de que sea llamado desde PIM
                    Me.dtTiposPersonas.DefaultView.RowFilter = "1=1"
                Case 1 ' en caso de que sea llamado desde TiendasContactos
                    Me.dtTiposPersonas.DefaultView.RowFilter = "StbTiposEntradaID IN (1,2,3,4,5,14)"
            End Select

            Me.cmbTipoPersona.DataSource = Me.dtTiposPersonas
            Me.cmbTipoPersona.DisplayMember = "Descripcion"
            Me.cmbTipoPersona.ValueMember = "StbTiposEntradaID"
            Me.cmbTipoPersona.Splits(0).DisplayColumns("StbTiposEntradaID").Visible = False
            Me.cmbTipoPersona.ExtendRightColumn = True
            Me.cmbTipoPersona.SelectedIndex = 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Cargar DataTable que contiene máscaras"
    Private Sub CargarMascaras()
        Try
            Me.dtTiposEntradas = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("StbTiposEntradaID,Mascara", "StbTiposEntrada"))
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Definir máscara"
    Private Sub DefinirMascara()
        Try
            For Each dr As DataRow In Me.dtTiposEntradas.Rows
                If dr("StbTiposEntradaID") = Me.cmbTipoPersona.SelectedValue Then
                    Me.txtValor.Text = ""
                    If IsDBNull(dr("Mascara")) Then
                        Me.txtValor.Mask = ""
                    Else
                        Me.txtValor.Mask = dr("Mascara")
                    End If
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Guardar Datos"
    Private Sub GuardarDatos()
        If Me.txtValor.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtValor, "Campo Obligatorio")
            Me.txtValor.Focus()
            Exit Sub
        End If
        If (Me.txtValor.Text.Trim.Length = Me.txtValor.Mask.Length) Or (Me.txtValor.Mask = Nothing) Then
            For intCaracter As Integer = 0 To Me.txtValor.Mask.Length - 1
                If Me.txtValor.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                    Me.ErrPrv.SetError(Me.txtValor, "Datos Incompletos")
                    Exit Sub
                End If
            Next
            'Introducir datos al datatable respectivo
            Dim intSecuencialContacto As Integer = 1
            For Each dr As DataRow In frmClientesEdit.dtContactos.Rows
                intSecuencialContacto = dr("SecuencialContacto") + 1
            Next
            frmClientesEdit.dtContactos.Rows.Add(1, intSecuencialContacto, Me.cmbTipoPersona.SelectedValue, Me.cmbTipoPersona.SelectedText, Me.txtValor.Text)

            If MsgBox("¿Desea agregar más contactos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.txtValor.Text = ""
                Me.cmbTipoPersona.Focus()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            'Hasta aca
        Else
            Me.ErrPrv.SetError(Me.txtValor, "Verifique los datos")
        End If

    End Sub
#End Region

#Region "Guardar Datos en TiendaContactos"
    Public Sub GuardarTiendaContactos()

        If Me.txtValor.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtValor, "Campo Obligatorio")
            Me.txtValor.Focus()
            Exit Sub
        End If
        If (Me.txtValor.Text.Trim.Length = Me.txtValor.Mask.Length) Or (Me.txtValor.Mask = Nothing) Then
            For intCaracter As Integer = 0 To Me.txtValor.Mask.Length - 1
                If Me.txtValor.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                    Me.ErrPrv.SetError(Me.txtValor, "Datos Incompletos")
                    Exit Sub
                End If
            Next
            'Introducir datos al datatable respectivo
            'Dim intSecuencialContacto As Integer = 1
            'For Each dr As DataRow In frmStbEditTiendas.DtContactos.Rows
            '    intSecuencialContacto = dr("SecuencialContacto") + 1
            'Next
            'frmStbEditTiendas.DtContactos.Rows.Add(1, intSecuencialContacto, Me.cmbTipoPersona.SelectedValue, Me.cmbTipoPersona.SelectedText, Me.txtValor.Text)


            If MsgBox("¿Desea agregar más contactos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.txtValor.Text = ""
                Me.cmbTipoPersona.Focus()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            'Hasta aca
        Else
            Me.ErrPrv.SetError(Me.txtValor, "Verifique los datos")
        End If


    End Sub
#End Region

#Region "Editar Datos en TiendaContactos"
    Public Sub EditarTiendaContactos()

        If Me.txtValor.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtValor, "Campo Obligatorio")
            Me.txtValor.Focus()
            Exit Sub
        End If
        If (Me.txtValor.Text.Trim.Length = Me.txtValor.Mask.Length) Or (Me.txtValor.Mask = Nothing) Then
            For intCaracter As Integer = 0 To Me.txtValor.Mask.Length - 1
                If Me.txtValor.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                    Me.ErrPrv.SetError(Me.txtValor, "Datos Incompletos")
                    Exit Sub
                End If
            Next
            'Introducir datos al datatable respectivo
            'frmStbEditTiendas.DtContactos.Select("StbTiendaID = " + StbTienda + " AND SecuencialContacto = " + SecuencialContacto)(0)("Valor") = txtValor.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Hasta aca
        Else
            Me.ErrPrv.SetError(Me.txtValor, "Verifique los datos")
        End If


    End Sub
#End Region

#Region "Configurar GUI"
    Public Sub ConfigurarGui()
        Dim Data(1) As DataRow
        Select Case TypeGui
            Case 0
                cmbTipoPersona.Enabled = True
            Case 1
                Me.Text = "Editando Contacto"
                Data = dtTiposPersonas.Select("StbTiposEntradaID=" + objTipoEntrada)
                Me.cmbTipoPersona.SelectedValue = Data(0)("StbTiposEntradaID")
                Me.cmbTipoPersona.Enabled = False
                'txtValor.Text = frmStbEditTiendas.DtContactos.Select("StbTiendaID = " + StbTienda + " AND SecuencialContacto = " + SecuencialContacto)(0)("Valor")
        End Select
    End Sub
#End Region

#Region "Eventos del Formulario"
    Private Sub frmStbPersonasContactos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarMascaras()
        Me.CargarComboTipoPersona()
        If frmLLamado() = 1 Then
            ConfigurarGui()
        End If

        Me.cmbTipoPersona.Focus()
    End Sub
#End Region

#Region "Eventos de los Botones"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Select Case frmLLamado
            Case 0
                Me.GuardarDatos()
            Case 1
                If TypeGui = 0 Then
                    Me.GuardarTiendaContactos()
                Else
                    Me.EditarTiendaContactos()
                End If
        End Select

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

#Region "Eventos de los Controles"
    Private Sub cmbTipoPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoPersona.Click
        Me.ErrPrv.SetError(Me.cmbTipoPersona, "")
    End Sub

    Private Sub cmbTipoPersona_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoPersona.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtValor.Focus()
        End If
        Me.ErrPrv.SetError(Me.cmbTipoPersona, "")
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Select Case frmLLamado
                Case 0
                    Me.GuardarDatos()
                Case 1
                    If TypeGui = 0 Then
                        Me.GuardarTiendaContactos()
                    Else
                        Me.EditarTiendaContactos()
                    End If
            End Select

        End If
        Me.ErrPrv.SetError(Me.txtValor, "")
    End Sub

    Private Sub cmbTipoPersona_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoPersona.SelectedValueChanged
        Me.DefinirMascara()
        Me.ErrPrv.SetError(Me.cmbTipoPersona, "")
        Me.ErrPrv.SetError(Me.txtValor, "")
    End Sub

#End Region


End Class