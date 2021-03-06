''-------------------------------------------------------------------------------------------------
''----------------------------------------------------------------------
''--    Formulario Principal Catálogo Parámetro
''----------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.Cursors

Public Class frmStbMantParametro

#Region "Declaracion de variables u objetos locales al Formulario"
    Dim dtParametro As DataTable
    Dim objseg As SsgSeguridad
    Dim blnModificar As Boolean
#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbMantParametro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor
            'Me.Icon = My.Resources.MdiChild
            CargarGrid()
            Seguridad()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarGrid()
        Try
            '-- Instanciar
            dtParametro = Proyecto.Catalogos.Datos.StbParametro.RetrieveDT(, "Nombre", "StbParametroID, Nombre, Descripcion, Valor")
            Me.grdParametros.DataSource = dtParametro
            Me.grdParametros.Text = "Parámetros (" & Me.dtParametro.Rows.Count & ")"
          
            If dtParametro.Rows.Count = 0 Then
                Me.tsbModificarParametro.Enabled = False
            Else
                If blnModificar Then
                    Me.tsbModificarParametro.Enabled = True
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Seguridad"

    Private Sub Seguridad()
        Try
            '-- Instanciar
            objseg = New SsgSeguridad
            objseg.ServicioUsuario = "frmStbMantParametro"
            objseg.Usuario = clsProyecto.Conexion.Usuario
           
            If dtParametro.Rows.Count > 0 Then
                If objseg.TienePermiso("ModificarParametro") Then
                    Me.tsbModificarParametro.Enabled = True
                    Me.blnModificar = True
                Else
                    Me.tsbModificarParametro.Enabled = False
                    Me.blnModificar = False
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos del Toolbar"

    Private Sub tsbAgregarParametro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarParametro.Click
        '-- Declaracion de Variables y Objetos
        Dim objfrm As frmStbEditParametro
        Try
            '-- Instanciar
            Me.Cursor = WaitCursor
            objfrm = New frmStbEditParametro
            objfrm.TipoParamID = 0
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                Seguridad()
                'For Each dr As DataRow In Me.dtParametro.Rows
                '    If dr("StbParametroID") = objfrm.TipoParamID Then
                '        Me.tdgParametro.Row = Me.dtParametro.Rows.IndexOf(dr)
                '        Exit For
                '    End If
                'Next
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub tsbModificarParametro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificarParametro.Click
        '-- Declaracion de Variables y Objetos
        Dim objfrm As frmStbEditParametro
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            If Me.dtParametro.DefaultView.Count > 0 Then
                If Me.blnModificar Then
                    objfrm = New frmStbEditParametro
                    Dim selectedRow As Integer() = grdParametrosTabla.GetSelectedRows()
                    FilaActual = Me.grdParametrosTabla.GetDataSourceRowIndex(selectedRow(0))

                    objfrm.TipoParamID = Me.dtParametro.DefaultView.Item(FilaActual)("StbParametroID")

                    If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                        'For Each dr As DataRow In Me.dtParametro.Rows
                        '    If dr("StbParametroID") = objfrm.TipoParamID Then
                        '        Me.tdgParametro.Row = Me.dtParametro.Rows.IndexOf(dr)
                        '        Exit For
                        '    End If
                        'Next
                        MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End If
                End If
            End If
            objfrm = New frmStbEditParametro
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

  

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click

        dtParametro = Nothing
        objseg = Nothing
        blnModificar = Nothing
        Me.Close()
    End Sub

    Private Sub grdParametrosTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdParametrosTabla.FocusedRowChanged

        Try

            If dtParametro.DefaultView.Count = 0 Then
                Me.tsbModificarParametro.Enabled = False
            Else
                If Me.blnModificar Then
                    Me.tsbModificarParametro.Enabled = True
                End If
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

   
End Class