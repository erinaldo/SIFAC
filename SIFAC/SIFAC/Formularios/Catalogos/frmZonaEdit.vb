Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmZonaEdit


#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intMarcaID As Integer
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

    Property MarcaID() As Integer
        Get
            Return intMarcaID
        End Get
        Set(ByVal value As Integer)
            intMarcaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try

            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Zona"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False

                Case 1
                    Me.Text = "Editar Zona"
                    CargarDatosMZona()
                    chkActivo.Enabled = True

                Case 2
                    Me.Text = "Consultar Zona"
                    CargarDatosMZona()
                    txtNombreMarca.Enabled = False
                    chkActivo.Enabled = False
                    cmdGuardar.Enabled = False

            End Select
            txtNombreMarca.Focus()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una marca
    Public Sub CargarDatosMZona()
        Dim objZona As StbZona
        Try
            objZona = New StbZona
            objZona.Retrieve(MarcaID)
            txtNombreMarca.Text = objZona.Nombre
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objZona = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de marca
    Public Sub GuardarZona()
        Dim objZona As StbZona
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objZona = New StbZona
            objZona.Nombre = txtNombreMarca.Text.Trim
            objZona.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objZona.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objZona.Insert()
            MarcaID = objZona.StbZonaID
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objZona = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de editar la informacion de una marca
    Public Sub EditarZona()
        Dim objZona As StbZona
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objZona = New StbZona
            objZona.StbZonaID = MarcaID
            objZona.Nombre = txtNombreMarca.Text.Trim
            objZona.UsuarioModificacion = clsProyecto.Conexion.Servidor
            objZona.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objZona.Update()
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objZona = Nothing
        End Try
    End Sub

#End Region

#Region "Funciones"

    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        If txtNombreMarca.Text.Trim.Length = 0 Then
            ErrorProv.SetError(txtNombreMarca, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
       

        Return True
    End Function
#End Region

#Region "Eventos del formulario"

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 0
                    GuardarZona()
                Case 1
                    EditarZona()
            End Select

        End If
    End Sub

    Private Sub frmZonaEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
        Me.boolEditado = False
    End Sub

    Private Sub txtNombreMarca_TextChanged(sender As Object, e As EventArgs) Handles txtNombreMarca.TextChanged
        ErrorProv.SetError(txtNombreMarca, "")
        boolEditado = True
    End Sub

    Private Sub txtNombreMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreMarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtNombreMarca.Text.Trim.Length <> 0 Then
                Me.cmdGuardar.Focus()
            End If

        End If
    End Sub


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
#End Region

End Class