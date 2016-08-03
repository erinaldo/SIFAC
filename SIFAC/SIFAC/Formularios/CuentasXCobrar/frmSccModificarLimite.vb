Imports DAL
Imports SIFAC.BO
Imports proyecto.Configuracion


Public Class frmSccModificarLimite
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim objSccCuenta As New SccCuentaPorCobrar

    'Para uso en reestructuracion de Cuenta
    Public blnReestructuracionCuenta As Boolean = False

    Public Property IDCuenta() As String
        Get
            IDCuenta = Me.m_IDCuenta
        End Get
        Set(ByVal value As String)
            Me.m_IDCuenta = value
        End Set
    End Property

    Public Property IDTienda() As Integer
        Get
            IDTienda = Me.m_IDTienda
        End Get
        Set(ByVal value As Integer)
            Me.m_IDTienda = value
        End Set
    End Property

    Private Sub frmSccModificarLimite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.numLimiteCredito.Value = SccCuentaPorCobrar.RetrieveDT("SccCuentaID = '" & Me.IDCuenta & "' and objTiendaID=" & Me.IDTienda & "", , "LimiteCredito").DefaultView.Item(0)("LimiteCredito")
            Me.numLimiteCredito.Enabled = False
            clsProyecto.CargarTemaDefinido(Me)

            If Me.blnReestructuracionCuenta Then
                Me.Text = Me.Text + " - [RC]"
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarCambios()
        Dim t As New TransactionManager
        Try
            Try
                If Me.numLimiteCredito.Value > Me.NumNuevolimite.Value Then
                    MsgBox("El nuevo límite de crédito debe ser mayor que el actual", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
                t.BeginTran()
                objSccCuenta.Retrieve(Me.IDCuenta, Me.IDTienda)
                objSccCuenta.LimiteCredito = Me.NumNuevolimite.Value
                objSccCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSccCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSccCuenta.Update(t)
                t.CommitTran()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                t.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            t = Nothing
        End Try
    End Sub

    'Procedimiento usado en caso de modificar límite de crédito para Reestructuración de cuenta.
    Private Sub GuardarCambios_temp()
        Dim strFiltro, sSQL As String
        Try
            If Me.NumNuevolimite.Value <= 0.0 Then
                MsgBox("El nuevo límite de crédito debe ser mayor que CERO.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.NumNuevolimite.Focus()
                Me.NumNuevolimite.SelectAll()
                Exit Sub
            End If

            strFiltro = " objSccCuentaID='" + Me.IDCuenta + "' AND objTiendaID=" + Me.IDTienda.ToString
            sSQL = "UPDATE dbo.txRC_Recibo_Step2 SET NuevoLimiteCredito=" + Me.NumNuevolimite.Value.ToString + " WHERE " + strFiltro
            SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)

            'MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub NumNuevolimite_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NumNuevolimite.Validating
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccCuentaPorCobrar.GetMaxLength("LimiteCredito")
            s = SccCuentaPorCobrar.GetScale("LimiteCredito")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.NumNuevolimite.Value > ValorMaximo Then
                Me.ErrorProv.SetError(Me.NumNuevolimite, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.NumNuevolimite.Value = 0
            Else
                Me.ErrorProv.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProv.SetError(Me.NumNuevolimite, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.NumNuevolimite.Value = 0
        End Try
    End Sub

    Private Sub NumNuevolimite_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumNuevolimite.ValueChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not Me.blnReestructuracionCuenta Then
            Me.GuardarCambios()
        Else
            Me.GuardarCambios_temp()
        End If
    End Sub

End Class