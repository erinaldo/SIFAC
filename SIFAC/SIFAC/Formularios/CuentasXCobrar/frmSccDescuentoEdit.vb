Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Windows.Forms.Cursors

Public Class frmSccDescuentoEdit

#Region "Declaracion de Variables"
    Public DtMarca, DtCilindraje, DtSegmento As DataTable
    Public intTypeGui As Integer
    Public intDescuentoID As Integer
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

    Property DescuentoID() As Integer
        Get
            Return intDescuentoID
        End Get
        Set(ByVal value As Integer)
            intDescuentoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        spnPlazo.Focus()
        Try
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Configuracion de Descuento"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False
                Case 1
                    Me.Text = "Editar Configuracion de Descuento"
                    CargarDatosDescuentos()
                    chkActivo.Enabled = True
                Case 2
                    Me.Text = "Consultar Configuracion de Descuento"
                    CargarDatosDescuentos()
                    spnPlazo.Enabled = False
                    spnDescuentoMinimo.Enabled = False
                    spnDescuentoMaximo.Enabled = False
                    chkActivo.Enabled = False
                    cmdGuardar.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de la configuracion de descuento
    Public Sub CargarDatosDescuentos()
        Dim objDescuento As SccDescuentoPlazo
        Try
            objDescuento = New SccDescuentoPlazo
            objDescuento.Retrieve(DescuentoID)
            spnPlazo.Text = objDescuento.PlazoPago
            spnDescuentoMinimo.Text = objDescuento.DescuentoMinimo
            spnDescuentoMaximo.Text = objDescuento.DescuentoMaximo
            chkActivo.Checked = objDescuento.Activo
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objDescuento = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de descuentos permitidos
    Public Sub GuardarConfiguracionDescuento()
        Dim objDescuento As SccDescuentoPlazo
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objDescuento = New SccDescuentoPlazo
            objDescuento.PlazoPago = spnPlazo.Value
            objDescuento.DescuentoMaximo = spnDescuentoMaximo.Value
            objDescuento.DescuentoMinimo = spnDescuentoMinimo.Value
            objDescuento.Activo = chkActivo.Checked
            objDescuento.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objDescuento.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objDescuento.Insert(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objDescuento = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de editar la informacion de una configuracion de descuento
    Public Sub EditarDescuento()
        Dim objDescuento As SccDescuentoPlazo
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objDescuento = New SccDescuentoPlazo

            objDescuento.SccDescuentoID = DescuentoID
            objDescuento.PlazoPago = spnPlazo.Value
            objDescuento.DescuentoMinimo = spnDescuentoMinimo.Value
            objDescuento.DescuentoMaximo = spnDescuentoMaximo.Value
            objDescuento.Activo = chkActivo.Checked
            objDescuento.UsuarioCreacion = clsProyecto.Conexion.Servidor
            objDescuento.UsuarioModificacion = clsProyecto.Conexion.Servidor
            objDescuento.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objDescuento.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objDescuento.Update(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objDescuento = Nothing
        End Try
    End Sub

#End Region

#Region "Funciones"

    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
   
        If spnPlazo.Value = 0.0 Then
            ErrorProv.SetError(spnPlazo, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If spnDescuentoMinimo.Value = 0.0 Then
            ErrorProv.SetError(spnDescuentoMinimo, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If spnDescuentoMaximo.Value = 0.0 Then
            ErrorProv.SetError(spnDescuentoMaximo, My.Resources.MsgObligatorio)
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
                    GuardarConfiguracionDescuento()
                Case 1
                    EditarDescuento()
            End Select
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub frmSccDescuentoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()

        Me.boolEditado = False
    End Sub

    Private Sub frmSccDescuentoEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub spnPlazo_TextChanged(sender As Object, e As EventArgs) Handles spnPlazo.TextChanged
        ErrorProv.SetError(spnPlazo, "")
        boolEditado = True
    End Sub

    Private Sub spnDescuentoMinimo_TextChanged(sender As Object, e As EventArgs) Handles spnDescuentoMinimo.TextChanged
        ErrorProv.SetError(spnDescuentoMinimo, "")
        boolEditado = True
    End Sub

    Private Sub spnDescuentoMaximo_TextChanged(sender As Object, e As EventArgs) Handles spnDescuentoMaximo.TextChanged
        ErrorProv.SetError(spnDescuentoMaximo, "")
        boolEditado = True
    End Sub

    Private Sub spnPlazo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spnPlazo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.spnDescuentoMinimo.Focus()
        End If
    End Sub

    Private Sub spnDescuentoMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spnDescuentoMinimo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.spnDescuentoMaximo.Focus()
        End If
    End Sub

    Private Sub spnDescuentoMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spnDescuentoMaximo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.chkActivo.Focus()
        End If
    End Sub

    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
    End Sub
#End Region

End Class