
Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO

''' <summary>
''' Formulario Principal de Mantenimiento de Tr�mites legales.
''' Autor : Gelmin Mart�nez
''' Fecha : 25 de Marzo de 2010.
''' </summary>
''' <remarks></remarks>
Public Class frmSccTramiteLegal
    Dim m_IDTramite As Integer
    Dim m_IDCuenta As String
    Dim DtDatosTramites As DataTable

    ' Variables para control de seguridad
    Dim blnAgregarTramite As Boolean
    Dim blnAnularTramite As Boolean
    Dim blnConsultarTramite As Boolean
    Dim blnImprimirTramite As Boolean

#Region "Propiedades de Tramites"

    Property IDTramite() As Integer
        Get
            IDTramite = Me.m_IDTramite
        End Get
        Set(ByVal value As Integer)
            Me.m_IDTramite = value
        End Set
    End Property

    Property IDCuenta() As String
        Get
            IDCuenta = Me.m_IDCuenta
        End Get
        Set(ByVal value As String)
            Me.m_IDCuenta = value
        End Set
    End Property

#End Region

#Region "Cargar datos"
    ''' <summary>
    ''' Procedimiento encargado de cargar los datos correspondientes de los tr�mites legales.
    ''' Autor : Gelmin Mart�nez.
    ''' Fecha : 24 de Marzo de 2010
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaDatos()
        Dim sSQL As String
        Try
            Me.DtDatosTramites = New DataTable
            sSQL = clsConsultas.ObtenerConsultaGeneral("SccTramiteLegalID, objCuentaID, objClienteId, objTiendaId, NombreCliente, FechaTramite, Saldo_a_Fecha, NombreAbogado, CalificacionCuenta, objCalificacionAnteriorId", "vwSccTramitesLegales")
            Me.DtDatosTramites = SqlHelper.ExecuteQueryDT(sSQL)
            Me.DtDatosTramites.PrimaryKey = New DataColumn() {Me.DtDatosTramites.Columns("SccTramiteLegalID")}
            Me.DtDatosTramites.DefaultView.Sort = "SccTramiteLegalID"
            Me.grdTramitesLegales.SetDataBinding(Me.DtDatosTramites, "", True)
            Me.bloquearBotonesBarra(Me.DtDatosTramites.Rows.Count = 0)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region " Nuevo Tramite"

    ''' <summary>
    ''' Procedimiento encargado de crear un nuevo tr�mite
    ''' Autor : Gelmin Martinez.
    ''' Fecha : 24 de Marzo de 2010.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Nuevo_tramite()
        Dim objFormTramite As frmSccEditTramiteLegal
        Dim iIndiceRegistro As Integer

        Dim sCuentaId, sTiendaID, sAbogado, sComentarios As String
        Try
            objFormTramite = New frmSccEditTramiteLegal
            objFormTramite.TypeGui = 0
            If objFormTramite.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargaDatos()
                iIndiceRegistro = Me.DtDatosTramites.DefaultView.Find(objFormTramite.IDTramite)
                Me.grdTramitesLegales.Row = iIndiceRegistro

                'sClienteID = Me.DtDatosTramites.DefaultView.Item(iIndiceRegistro)("objClienteId")
                sCuentaId = Me.DtDatosTramites.DefaultView.Item(iIndiceRegistro)("objCuentaId")
                sTiendaID = Me.DtDatosTramites.DefaultView.Item(iIndiceRegistro)("objTiendaId")
                sAbogado = Me.DtDatosTramites.DefaultView.Item(iIndiceRegistro)("NombreAbogado")
                sComentarios = objFormTramite.txtComentario.Text

                Me.ImprimirTramiteLegal(sCuentaId, sTiendaID, sAbogado, sComentarios)

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregarTramite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTramite.Click
        Call Me.Nuevo_tramite()
    End Sub

#End Region

#Region "Bloquear botones Barra principal"
    Private Sub bloquearBotonesBarra(ByVal bValor As Boolean)
        Me.cmdAnularTramite.Enabled = (Not bValor) And blnAnularTramite
        Me.cmdConsultarTramite.Enabled = (Not bValor) And blnConsultarTramite
        Me.cmdImprimir.Enabled = (Not bValor) And blnImprimirTramite
    End Sub
#End Region

#Region "Eventos"

    Private Sub frmSccTramiteLegal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AplicarSeguridad()
        Me.CargaDatos()

        clsProyecto.CargarTemaDefinido(Me)
        'Me.grdTramitesLegales.Splits(0).DisplayColumns("SccTramiteLegalID").Visible = False
        clsProyecto.CargarTemaDefinido(Me)
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Me.CargaDatos()
    End Sub

#End Region

#Region "Consultar Tr�mite"
    Private Sub Consultar_tramite()
        Dim objFormTramite As frmSccEditTramiteLegal
        Try
            objFormTramite = New frmSccEditTramiteLegal
            objFormTramite.TypeGui = 2
            objFormTramite.IDTramite = Me.IDTramite
            objFormTramite.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdConsultarTramite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarTramite.Click
        If Me.grdTramitesLegales.RowCount > 0 Then
            Me.IDTramite = Me.grdTramitesLegales.Columns("SccTramiteLegalID").Value
            Me.Consultar_tramite()
        End If
    End Sub
#End Region

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Gelmin Mart�nez.
    ''' Fecha : 24 de Marzo de 2010.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSCCTRAMITELEGAL"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAgregarTramite = objSeg.TienePermiso("AGREGARTRAMITE")
            Me.blnAnularTramite = objSeg.TienePermiso("ANULARTRAMITE")
            Me.blnImprimirTramite = objSeg.TienePermiso("IMPRIMIRTRAMITE")
            Me.blnConsultarTramite = objSeg.TienePermiso("CONSULTARTRAMITE")

            'Aplicar permisos a los comandos
            Me.cmdAgregarTramite.Enabled = Me.blnAgregarTramite
            Me.cmdAnularTramite.Enabled = Me.blnAnularTramite
            Me.cmdImprimir.Enabled = Me.blnImprimirTramite
            Me.cmdConsultarTramite.Enabled = Me.blnConsultarTramite

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Anular Tr�mite"
    Private Sub cmdAnularTramite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnularTramite.Click
        If MsgBox("�Seguro que desea anular el tr�mite?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
            Me.IDTramite = Me.grdTramitesLegales.Columns("SccTramiteLegalID").Value
            If Me.AnularTramite() Then
                MsgBox("Tr�mite Anulado correctamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.CargaDatos()
            End If
        End If
    End Sub

    Private Function AnularTramite() As Boolean
        Dim sSQL, sTramiteID, sCuentaId, sTiendaId, sFacturaId, sCalificacionAnteriorID, sComando As String
        Dim T As New TransactionManager
        Dim iIndiceRegistro As Integer
        Try
            Try

                sTramiteID = Me.grdTramitesLegales.Columns("SccTramiteLegalID").Value
                iIndiceRegistro = Me.DtDatosTramites.DefaultView.Find(sTramiteID)

                Me.DtDatosTramites.DefaultView.Find(sTramiteID)

                sCuentaId = DtDatosTramites.DefaultView.Item(iIndiceRegistro)("objCuentaId")
                sTiendaId = DtDatosTramites.DefaultView.Item(iIndiceRegistro)("objTiendaID")
                sCalificacionAnteriorID = DtDatosTramites.DefaultView.Item(iIndiceRegistro)("objCalificacionAnteriorID")

                sSQL = clsConsultas.ObtenerConsultaGeneral("objFacturaId", "vwCalificacionCuentasMotos", "objSccCuentaID='" + sCuentaId + "' AND objTiendaId=" + sTiendaId.ToString)
                sFacturaId = SqlHelper.ExecuteQueryDT(sSQL).DefaultView.Item(0)("objFacturaID")
                sComando = "UPDATE dbo.SccCuentaPorCobrarDetalle SET objCalificacionID=" + sCalificacionAnteriorID + " WHERE objFacturaID=" + sFacturaId

                T.BeginTran()
                SqlHelper.ExecuteCommand(sComando, T)
                sComando = "DELETE FROM dbo.SccTramiteLegal WHERE SccTramiteLegalID=" + sTramiteID
                SqlHelper.ExecuteCommand(sComando, T)
                T.CommitTran()

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
#End Region

#Region "Imprimir Tr�mite"
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim sTramiteID, sCuentaId, sTiendaId, sAbogado, sComentarios As String
        Dim iIndiceRegistro As Integer

        sTramiteID = Me.grdTramitesLegales.Columns("SccTramiteLegalID").Value
        iIndiceRegistro = Me.DtDatosTramites.DefaultView.Find(sTramiteID)
        sCuentaId = DtDatosTramites.DefaultView.Item(iIndiceRegistro)("objCuentaId").ToString
        sTiendaId = DtDatosTramites.DefaultView.Item(iIndiceRegistro)("objTiendaID").ToString
        sAbogado = DtDatosTramites.DefaultView.Item(iIndiceRegistro)("NombreAbogado").ToString
        sComentarios = SqlHelper.ExecuteQueryDT("SELECT Comentario FROM dbo.SccTramiteLegal WHERE SccTramiteLegalID=" + sTramiteID).DefaultView.Item(0)("Comentario")

        Me.ImprimirTramiteLegal(sCuentaId, sTiendaId, sAbogado, sComentarios)
    End Sub

    Public Sub ImprimirTramiteLegal(ByVal sCuentaId As String, ByVal sTiendaId As String, ByVal sAbogado As String, ByVal sComentarios As String)
        Dim objReportes As New frmStbVisor
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                objReportes.Contenedor.Grid.Rows.Remove(1)
                objReportes.Width = frmPrincipal.Width - frmPrincipal.OutBarPrincipal.Width
                'objReportes.Height = frmPrincipal.Height - frmPrincipal.MenuPrincipal.Height - frmPrincipal.stbPrincipal.Height
                objReportes.MdiParent = frmPrincipal

                objReportes.ReporteEstadoCuentaTramiteLegal(sCuentaId, sTiendaId, sAbogado, sComentarios)
                objReportes.Text = "Estado de cuenta a Tr�mite Legal"
                objReportes.Show()

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

End Class