
Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO

Public Class frmSfaCambiosPagos
    Dim m_IDDetalleFactura As Integer
    Dim objDetalleFact As New SccCuentaPorCobrarDetalle


    Public Property IdDetalleFact() As Integer
        Get
            IdDetalleFact = Me.m_IDDetalleFactura
        End Get
        Set(ByVal value As Integer)
            Me.m_IDDetalleFactura = value
        End Set
    End Property
    Private Sub frmSfaCambiosPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            objDetalleFact.Retrieve(Me.IdDetalleFact)
            Me.dtpNuevoPago.Value = objDetalleFact.FechaProximoPago.Value.AddDays(1)
            Me.dtpFechaProximoPago.Value = objDetalleFact.FechaProximoPago
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Me.txtusuario.Text = clsProyecto.Conexion.Usuario
    End Sub


    ''' <summary>
    ''' Procedimiento Encargado de realizar el cambio correspondiente de Fechas.
    ''' Autor : Pedro Pablo Tinoco
    ''' Fecha : 13 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarCambios()
        Dim T As New TransactionManager
        Dim Mov As New SccDetalleMovimientos
        Dim Fecha As DateTime
        Dim intDif As Integer
        Try
            If Me.dtpNuevoPago.Value < Me.dtpFechaProximoPago.Value Then
                MsgBox("La fecha de nuevo pago debe ser mayor que fecha de pago actual.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            Fecha = Me.dtpFechaProximoPago.Value
            Fecha = Fecha.AddMonths(1)

            If dtpFechaProximoPago.Value > Fecha Then
                MsgBox("El límite de desplazamiento de Fecha debe ser menor a un mes", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            T.BeginTran()
            intDif = DateDiff(DateInterval.Day, Me.dtpFechaProximoPago.Value, Me.dtpNuevoPago.Value)
            Mov.FechaPago = Me.dtpFechaProximoPago.Value
            Mov.FechaNuevoPago = Me.dtpNuevoPago.Value
            Mov.objSccCuentaPorCobrarDetalleID = Me.IdDetalleFact
            Mov.UsuarioCreacion = clsProyecto.Conexion.Usuario
            Mov.FechaCreacion = clsProyecto.Conexion.FechaServidor
            Mov.Insert(T)

            Me.objDetalleFact.FechaProximoPago = Me.dtpNuevoPago.Value
            Me.objDetalleFact.FechaVencimiento = Me.objDetalleFact.FechaVencimiento.Value.AddDays(intDif)
            Me.objDetalleFact.UsuarioModificacion = clsProyecto.Conexion.Usuario
            Me.objDetalleFact.FechaModificacion = clsProyecto.Conexion.FechaServidor
            Me.objDetalleFact.Update(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.AplicarCambios()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class