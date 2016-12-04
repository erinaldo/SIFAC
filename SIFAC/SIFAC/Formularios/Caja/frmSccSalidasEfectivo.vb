Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Data.SqlClient
Imports SIFAC.BO

Public Class frmSccSalidasEfectivo

#Region "Declaracion de Variables Locales y Objetos"

    Dim objSeg As SsgSeguridad
    Dim dtND As DataTable
    Dim IDND As Integer
    Dim EstadoND As Integer
    Dim CerosRellenoND As Integer
    Dim EstadoRegistrada As Integer
    Dim EstadoAutorizada As Integer
    Dim EstadoAnulada As Integer
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Dim blnModificarND As Boolean = False
    Dim blnAutorizarND As Boolean = False
    Dim blnAnularND As Boolean = False
    Dim blnConsultarND As Boolean = False

#End Region


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
            strFiltro = " Nombre= 'EstadoND' AND Codigo='REGISTRADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoRegistrada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito AUTORIZADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoND' AND Codigo='AUTORIZADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAutorizada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito ANULADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoND' AND Codigo='ANULADA' "
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
        Try
            If dtND.Rows.Count > 0 Then

                '-- Mostrar los datos en el Grid
                dtND.PrimaryKey = New DataColumn() {dtND.Columns("SccNotaDebitoID")}
                Me.dtND.DefaultView.Sort = "SccNotaDebitoID"

                Me.grdSalidas.DataSource = dtND
                Me.grdSalidas.Text = "Salida de Efectivo (" & dtND.Rows.Count & ")"


                If Me.grdSalidaTabla.RowCount > 0 Then

                    Dim selectedRow As Integer() = grdSalidaTabla.GetSelectedRows()
                    FilaActual = Me.grdSalidaTabla.GetDataSourceRowIndex(selectedRow(0))

                    IDND = Me.dtND.DefaultView.Item(FilaActual)("SccNotaDebitoID")
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
                    Me.cmdConsultar.Enabled = blnConsultarND
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim objfrm As frmSccEditNotaDebito
       
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditNotaDebito
            objfrm.TypeGui = 0
            objfrm.Tipo = "Salida"
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridNotaDebito()
                Me.dtND.DefaultView.Find(objfrm.IDNotaDebito)
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                'Me.IDND = objfrm.TipoNDID
                'strRecibo = objfrm.strRecibo
                'ReciboID = objfrm.ReciboID
            Else
                'strRecibo = objfrm.strRecibo
                'ReciboID = objfrm.ReciboID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            ''  LiberarRegistro("SccNotaDebito", Me.IDND)
            Me.Cursor = Cursors.Default
            ''-- Liberar Recibo
            'If Not strRecibo = "" And Not ReciboID = 0 Then
            '    If strRecibo = "Colector" Then
            '        LiberarRegistro("SccReciboColector", ReciboID)
            '    ElseIf strRecibo = "Caja" Then
            '        LiberarRegistro("SccReciboCaja", ReciboID)
            '    End If
            'End If
        End Try
    End Sub
End Class