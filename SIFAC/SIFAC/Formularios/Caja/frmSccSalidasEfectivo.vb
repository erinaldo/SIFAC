Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Data.SqlClient
Imports SIFAC.BO
Imports Proyecto.Catalogos.Datos

Public Class frmSccSalidasEfectivo

#Region "Declaracion de Variables Locales y Objetos"

    Dim objSeg As SsgSeguridad
    Dim dtND As DataTable
    Dim IDND As Integer
    Dim EstadoND As Integer
    Dim CerosRellenoND As Integer
    Dim EstadoRegistrada As Integer
    Dim EstadoAutorizada As Integer
    Dim EstadoPagada As Integer
    Dim EstadoAnulada As Integer
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Dim blnModificarND As Boolean = False
    Dim blnAutorizarND As Boolean = False
    Dim blnAnularND As Boolean = False
    Dim blnConsultarND As Boolean = False

    Private m_DiasSalidasEfectivoRecientes As Integer

    Property DiasSalidasEfectivoRecientes() As Integer
        Get
            DiasSalidasEfectivoRecientes = Me.m_DiasSalidasEfectivoRecientes
        End Get
        Set(ByVal value As Integer)
            Me.m_DiasSalidasEfectivoRecientes = value
        End Set
    End Property


#End Region

#Region "Procedimientos"

    Private Sub ModificarND()
        Dim objfrm As frmSccEditNotaCredito
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditNotaCredito
            objfrm.IDNotaCredito = IDND
            objfrm.TypeGui = 1
            objfrm.Tipo = "Salida"
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridNotaDebito()
                Me.dtND.DefaultView.Find(objfrm.IDNotaCredito)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AutorizarND()
        Dim T As New TransactionManager
        Dim objND As New SccNotaCredito
        Try
            Select Case MsgBox("¿Seguro que desea autorizar la salida de efectivo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Me.Cursor = Cursors.WaitCursor

                    '-- Reservar Registro
                    '   ReservarRegistro("SccNotaDebito", Me.IDND)

                    T.BeginTran()

                    '-- Actualizar el Estado de la Nota de Credito
                    objND.Retrieve(Me.IDND)
                    objND.objEstadoID = Me.EstadoPagada
                    objND.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objND.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objND.Update(T)

                    T.CommitTran()

                    '-- Seleccionar el Registro que se ha modificado
                    CargarGridNotaDebito()
                    Me.dtND.DefaultView.Find(objND.SccNotaCreditoID)

                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End Select
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub frmSccSalidasEfectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            AplicarSeguridad()
            PropiedadesFormulario()
            CargarGridNotaDebito()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Seguridad"
    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Aplica la Seguridad al Formulario
    '-----------------------------------------------------------------------------------
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "frmSccSalidasEfectivo"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            If objSeg.TienePermiso("AgregarSalida") Then
                Me.cmdAgregar.Enabled = True
            Else
                Me.cmdAgregar.Enabled = False
            End If
            If objSeg.TienePermiso("ModificarSalidaEfectivo") Then
                blnModificarND = True
            Else
                blnModificarND = False
            End If
            If objSeg.TienePermiso("AutorizaSalidaEfectivo") Then
                blnAutorizarND = True
            Else
                blnAutorizarND = False
            End If
            If objSeg.TienePermiso("AnularSalidaEfectivo") Then
                blnAnularND = True
            Else
                blnAnularND = False
            End If

            If objSeg.TienePermiso("ConsultarSalidaEfectivo") Then
                Me.cmdConsultar.Enabled = True
                blnConsultarND = True
            Else
                Me.cmdConsultar.Enabled = False
                blnConsultarND = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Propiedades del Formulario"

    ''----------------------------------------------------------------------
    '-- Descripcion         :   Valores de Parametros para el Formulario
    '-----------------------------------------------------------------------------------
    Private Sub PropiedadesFormulario()
        Dim dtTemp As DataTable
        Try

            '-- Obtener ID del Estado de Nota de Debito REGISTRADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoNC' AND Codigo='REGISTRADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoRegistrada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito AUTORIZADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoNC' AND Codigo='AUTORIZADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAutorizada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito PAGADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoNC' AND Codigo='PAGADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoPagada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito ANULADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoNC' AND Codigo='ANULADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAnulada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Grid"

    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Cargar el Grid Notas de Debito.
    '--                     :   Rellenar con Ceros el Numero Nota de Debito a Mostrar
    '-----------------------------------------------------------------------------------
    Private Sub CargarGridNotaDebito()
        Dim FilaActual As Integer
        Dim striFiltroCargaInicial As String = String.Empty
        Try
            Me.DiasSalidasEfectivoRecientes = ClsCatalogos.GetValorParametro("DiasSalidasEfectivoRecientes")

            striFiltroCargaInicial = " (DATEDIFF(DAY, Fecha, GETDATE()) <= " + Me.DiasSalidasEfectivoRecientes.ToString + ")"

            strCampos = " * "
            strOrden = " Fecha DESC "
            dtND = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*", "vwSccSaldiasEfectivo", striFiltroCargaInicial))

            If dtND.Rows.Count > 0 Then

                '-- Mostrar los datos en el Grid
                dtND.PrimaryKey = New DataColumn() {dtND.Columns("SccNotaCreditoID")}
                Me.dtND.DefaultView.Sort = "SccNotaCreditoID"

                Me.grdSalidas.DataSource = dtND
                Me.grdSalidas.Text = "Salida de Efectivo (" & dtND.Rows.Count & ")"


                If Me.grdSalidaTabla.RowCount > 0 Then

                    Dim selectedRow As Integer() = grdSalidaTabla.GetSelectedRows()
                    FilaActual = Me.grdSalidaTabla.GetDataSourceRowIndex(selectedRow(0))

                    IDND = Me.dtND.DefaultView.Item(FilaActual)("SccNotaCreditoID")
                    EstadoND = Me.dtND.DefaultView.Item(FilaActual)("objEstadoID")

                    '-- Habilitar Opciones
                    If blnModificarND And EstadoND = EstadoRegistrada Then
                        Me.cmdEditar.Enabled = True
                    Else
                        Me.cmdEditar.Enabled = False
                    End If
                    If blnAutorizarND And EstadoND = EstadoRegistrada Then
                        Me.cmdAutotizar.Enabled = True
                    Else
                        Me.cmdAutotizar.Enabled = False
                    End If
                    If blnAnularND And EstadoND = EstadoRegistrada Then
                        Me.cmdAnular.Enabled = True
                    Else
                        Me.cmdAnular.Enabled = False
                    End If

                    cmdConsultar.Enabled = blnConsultarND And dtND.Rows.Count > 0

                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim objfrm As frmSccEditNotaCredito

        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditNotaCredito
            objfrm.TypeGui = 0
            objfrm.Tipo = "Salida"
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridNotaDebito()
                AplicarSeguridad()
                Me.dtND.DefaultView.Find(objfrm.IDNotaCredito)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub



    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Try
            If dtND.DefaultView.Count > 0 And blnModificarND And EstadoND = EstadoRegistrada Then
                ModificarND()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAutotizar_Click(sender As Object, e As EventArgs) Handles cmdAutotizar.Click
        Try
            If dtND.DefaultView.Count > 0 And blnAutorizarND And EstadoND = EstadoRegistrada Then
                AutorizarND()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Try
            CargarGridNotaDebito()
            AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim objfrm As New frmSccEditNotaCredito
        Try
            Me.Cursor = Cursors.WaitCursor
            If dtND.DefaultView.Count > 0 And blnConsultarND And dtND.Rows.Count > 0 Then
                objfrm.TypeGui = 2
                objfrm.Tipo = "Salida"
                objfrm.IDNotaCredito = Me.IDND
                If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    '*******************
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub grdSalidaTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdSalidaTabla.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            If Me.grdSalidaTabla.RowCount > 0 Then

                Dim selectedRow As Integer() = grdSalidaTabla.GetSelectedRows()
                FilaActual = Me.grdSalidaTabla.GetDataSourceRowIndex(selectedRow(0))

                IDND = Me.dtND.DefaultView.Item(FilaActual)("SccNotaCreditoID")
                EstadoND = Me.dtND.DefaultView.Item(FilaActual)("objEstadoID")

                '-- Habilitar - Deshabilitar Opciones
                If blnModificarND And EstadoND = EstadoRegistrada Then
                    Me.cmdEditar.Enabled = True
                Else
                    Me.cmdEditar.Enabled = False
                End If
                If blnAutorizarND And EstadoND = EstadoRegistrada Then
                    Me.cmdAutotizar.Enabled = True
                Else
                    Me.cmdAutotizar.Enabled = False
                End If
                If blnAnularND And EstadoND = EstadoRegistrada Then
                    Me.cmdAnular.Enabled = True
                Else
                    Me.cmdAnular.Enabled = False
                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



#End Region
End Class