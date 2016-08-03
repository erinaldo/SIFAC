Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursor
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSivRepuestos

#Region "Declaracion de variables globales"
    Dim DtRepuestos As DataTable
    Dim objSeg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolAnular, boolEtiquetar, boolImprimir As Boolean
#End Region

#Region "Procedimientos"
    Private Sub CargarGrid()
        Try
            Me.DtRepuestos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivRepuestoID, DescripcionCorta, TipoRepuesto, Precio, Garantia, Activo,EtiquetarCB ", "vwSivRepuestos", "1=1 Order by SivRepuestoID desc "))
            Me.DtRepuestos.PrimaryKey = New DataColumn() {Me.DtRepuestos.Columns("SivRepuestoID")}
            Me.DtRepuestos.DefaultView.Sort = "SivRepuestoID"
            Me.grdRepuestos.SetDataBinding(Me.DtRepuestos, "", True)
            Me.grdRepuestos.Splits(0).DisplayColumns("EtiquetarCB").Visible = False
            Me.grdRepuestos.Caption = "Repuestos (" & Me.DtRepuestos.Rows.Count & ")"
            Me.grdRepuestos.Refresh()
            Me.AplicarSeguridad()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad

            objSeg.ServicioUsuario = "FRMSIVREPUESTOS"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AGREGARREPUESTOS")
            boolEditar = objSeg.TienePermiso("EDITARREPUESTOS")
            boolConsultar = objSeg.TienePermiso("CONSULTARREPUESTOS")
            boolAnular = objSeg.TienePermiso("ANULARREPUESTO")
            boolEtiquetar = objSeg.TienePermiso("ETIQUETARREPUESTO")
            boolImprimir = objSeg.TienePermiso("IMPRIMIRREPUESTO")

            Me.cmdAgregar.Enabled = boolAgregar
            Me.cmdEditar.Enabled = boolEditar
            Me.cmdConsultar.Enabled = boolConsultar
            Me.cmdAnular.Enabled = boolAnular
            Me.cmdEtiquetar.Enabled = boolEtiquetar
            Me.cmdImprimir.Enabled = boolImprimir

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Function InactivarRepuesto(ByVal SivRepuestoID As String) As Boolean
        Dim Repuesto As New SivRepuestos
        Dim blnResultado As Boolean
        Try
            Repuesto.Retrieve(SivRepuestoID)
            Repuesto.Activo = False
            Repuesto.Update()
            blnResultado = True
        Catch ex As Exception
            blnResultado = False
            clsError.CaptarError(ex)
        End Try
        Return blnResultado
    End Function
#End Region

#Region "Eventos"

#Region "Formulario"
    Private Sub frmStbRepuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarGrid()
    End Sub
#End Region

#Region "Controles"
    Private Sub grdRepuestos_FilterChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdRepuestos.FilterChange
        Me.grdRepuestos.Caption = "Repuestos (" & Me.DtRepuestos.Rows.Count & ")"
    End Sub
#End Region

#Region "Botones"
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim editRepuestos As frmSivEditRepuestos
        Dim dtRol As New DataTable
        Try
            Try
                '' Me.Cursor = Cursors.WaitCursor
                editRepuestos = New frmSivEditRepuestos

                objSeg.ServicioUsuario = "frmPrincipal"
                objSeg.Usuario = clsProyecto.Conexion.Usuario
                editRepuestos.RolGerente = objSeg.TienePermiso("AUTORIZACIONGERENTE")
                'dtRol = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Nombre, Login", "vwCuentaRol", "Nombre= 'Gerente' AND Login = '" & clsProyecto.Conexion.Usuario & "'"))
                'If dtRol.Rows.Count > 0 Then
                '    editRepuestos.RolGerente = True
                'Else
                '    editRepuestos.RolGerente = False
                'End If

                editRepuestos.TypeGui = 0
                If editRepuestos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarGrid()
                    Me.grdRepuestos.Row = Me.DtRepuestos.DefaultView.Find(editRepuestos.RepuestosID)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtRol = Nothing
            editRepuestos = Nothing
        End Try

    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim editRepuestos As frmSivEditRepuestos
        Dim dtRol As New DataTable
        Try
            Try
                '' Me.Cursor = Cursors.WaitCursor
                editRepuestos = New frmSivEditRepuestos

                objSeg.ServicioUsuario = "frmPrincipal"
                objSeg.Usuario = clsProyecto.Conexion.Usuario
                editRepuestos.RolGerente = objSeg.TienePermiso("AUTORIZACIONGERENTE")

                'dtRol = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Nombre", "vwCuentaRol", "Nombre= 'Gerente' AND Login = '" & clsProyecto.Conexion.Usuario & "'"))
                'If dtRol.Rows.Count > 0 Then
                '    editRepuestos.RolGerente = True
                'Else
                '    editRepuestos.RolGerente = False
                'End If
                editRepuestos.TypeGui = 1
                editRepuestos.RepuestosID = Me.grdRepuestos.Columns("SivRepuestoID").Value
                If editRepuestos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarGrid()
                    Me.grdRepuestos.Row = Me.DtRepuestos.DefaultView.Find(editRepuestos.RepuestosID)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtRol = Nothing
            editRepuestos = Nothing
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim editRepuestos As frmSivEditRepuestos
        Try
            Try
                editRepuestos = New frmSivEditRepuestos
                editRepuestos.TypeGui = 2
                editRepuestos.RepuestosID = Me.grdRepuestos.Columns("SivRepuestoID").Value
                If editRepuestos.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarGrid()
                    Me.grdRepuestos.Row = Me.DtRepuestos.DefaultView.Find(editRepuestos.RepuestosID)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            editRepuestos = Nothing
        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Me.CargarGrid()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim objreporte As New frmSivRptRepuesto
        objreporte.Show()
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        Dim IdRepuesto As Integer
        If Not IsDBNull(Me.grdRepuestos.Columns("SivRepuestoID").Value) AndAlso Me.grdRepuestos.Columns("SivRepuestoID").Value.ToString.Trim.Length <> 0 Then
            'Verificar que no sea repuesto 1,2,3
            Try
                IdRepuesto = Me.grdRepuestos.Columns("SivRepuestoID").Value
            Catch ex As Exception
                IdRepuesto = 0
            End Try

            If IdRepuesto <> 0 Then
                Select Case IdRepuesto
                    Case 1, 2, 3
                        MsgBox("Los tres primeros repuestos no pueden desactivarse", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Exit Sub
                End Select

                If MsgBox("¿Está seguro que desea DESACTIVAR el repuesto seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    If Me.InactivarRepuesto("'" & Me.grdRepuestos.Columns("SivRepuestoID").Value & "'") Then
                        MsgBox("Repuesto desactivado con éxito.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        Me.CargarGrid()
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#End Region

    Private Sub cmdEtiquetar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEtiquetar.Click
        Dim objFormulario As New frmEtiquetarCB
        If Not IsDBNull(Me.grdRepuestos.Columns("SivRepuestoID").Value) AndAlso Me.grdRepuestos.Columns("SivRepuestoID").Value.ToString.Trim.Length <> 0 Then
            If Not IsDBNull(Me.grdRepuestos.Columns("EtiquetarCB").Value) AndAlso Me.grdRepuestos.Columns("EtiquetarCB").Value.ToString.Trim.Length <> 0 Then
                If Convert.ToBoolean(Me.grdRepuestos.Columns("EtiquetarCB").Value) Then
                    objFormulario.SivRepuestoID = Me.grdRepuestos.Columns("SivRepuestoID").Value
                    objFormulario.ShowDialog()
                Else
                    MsgBox("El repuesto no ha sido marcado para Etiquetar con código de barras.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            End If
        End If
    End Sub
End Class