Imports Proyecto.Catalogos.Datos
Imports DAL
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports System.Data.SqlClient
Imports GUI
Public Class frmStbImpresion

    Dim DtCat As DataTable
    Dim intopcionSel As Integer

#Region "Carga de Datos"

    '---------------------------------------------------------------------------------------------------------------------------
    'Procedimiento         :  CargarDatos
    'Autor                 :  Pedro Pablo Tinoco Salgado
    'Fecha de Creacion     :  16-10-07
    'Descripcion: Procedimiento de cargar los datos en el combo box.
    '-----------------------------------------------------------------------------------------------------------------------
    Private Sub CargarDatos(ByVal intOp As Integer)
        Try

            Select Case intOp
                Case 1
                    DtCat = StbCatalogo.RetrieveDT("Activo=1", , "StbCatalogoID,Nombre,Activo")
                    Me.cmbCatalogos.DataSource = DtCat
                    Me.cmbCatalogos.DataSource = DtCat
                    intopcionSel = 1 'Datos Activos

                Case 2
                    DtCat = StbCatalogo.RetrieveDT("Activo=0", , "StbCatalogoID,Nombre,Activo")
                    Me.cmbCatalogos.DataSource = DtCat
                    intopcionSel = 2 'Datos Inactivos


                Case 3
                    DtCat = StbCatalogo.RetrieveDT(, , "StbCatalogoID,Nombre,Activo")
                    Me.cmbCatalogos.DataSource = DtCat
                    intopcionSel = 3 'Datos Activos e inactivos

            End Select

            Me.cmbCatalogos.Text = "Todos"
            Me.cmbCatalogos.DisplayMember = "Nombre"
            Me.cmbCatalogos.ValueMember = "StbCatalogoID"

            Me.cmbCatalogos.Splits(0).DisplayColumns("StbCatalogoId").Visible = False
            Me.rbPantalla.Checked = True

        Catch ex As SqlClient.SqlException
            clsError.CaptarError(ex)
        Catch ex As Exception
            clsError.CaptarError(ex)

        End Try
    End Sub

    Private Sub frmImpresion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.chkMostrar.Checked = True
        Me.Icon = My.Resources.Imprimir
        CargarDatos(3)
        clsProyecto.CargarTemaDefinido(Me)
    End Sub

#End Region

#Region "Manejo de Eventos"

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            Me.Cursor = Windows.Forms.Cursors.WaitCursor
            ImprimirOpciones()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Windows.Forms.Cursors.Default
        End Try
    End Sub
    Private Sub rbtActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtActivo.CheckedChanged
        CargarDatos(1)
        Me.chkMostrar.Checked = True
        Me.chkMostrar.Enabled = True
    End Sub

    Private Sub rbtInactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtInactivo.CheckedChanged
        CargarDatos(2)
        Me.chkMostrar.Checked = True
        Me.chkMostrar.Enabled = True

    End Sub

    Private Sub rbtAmbos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAmbos.CheckedChanged
        CargarDatos(3)
        Me.chkMostrar.Checked = True
        Me.chkMostrar.Enabled = True

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbCatalogos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

#End Region

#Region "Manipulacion de Datos"
    '---------------------------------------------------------------------------------------------------------------------------
    'Procedimiento         :  Impresion de Catalogos
    'Autor                 :  Pedro Pablo Tinoco Salgado
    'Fecha de Creacion     :  16-10-07
    'Fecha de Modificacion :  17-10-07
    'Descripcion: Procedimiento encargado de mandar a imprimir y realizar las validaciones correspondientes de acuerdo a la opcion
    'de impresion seleccionada.
    '-----------------------------------------------------------------------------------------------------------------------
    Private Sub ImprimirOpciones()
        Dim DtCatalogo As New DataTable
        Dim frmrpt As frmVisorReporteActive
        Dim rptCatVal As rptStbCatalogosValores
        Dim strImpresion As String


        frmrpt = New frmVisorReporteActive
        rptCatVal = New rptStbCatalogosValores
        strImpresion = ""
        Try
            'En caso de haber elejido la accion todos
            If Me.cmbCatalogos.Text = "Todos" Then
                Select Case intopcionSel
                    Case 1
                        If Me.chkMostrar.Checked = True Then
                            DtCatalogo = SqlHelper.ExecuteQueryDT("Select * from vwrptStbCatalogos where Activo=1 order by Nombre")
                            strImpresion = "Catalogos Activos y sus Valores"
                        Else
                            DtCatalogo = StbCatalogo.RetrieveDT("Activo=1", , "Nombre,Descripcion,Activo")
                            strImpresion = "Catalogos Activos sin Valores"

                        End If
                    Case 2
                        If Me.chkMostrar.Checked = True Then
                            DtCatalogo = SqlHelper.ExecuteQueryDT("Select * from vwrptStbCatalogos where Activo=0 Order by Nombre")
                            strImpresion = "Catalogos Inactivos y sus Valores"

                        Else
                            DtCatalogo = StbCatalogo.RetrieveDT("Activo=0", , "Nombre,Descripcion,Activo")
                            strImpresion = "Catalogos Inactivos sin sus Valores"

                        End If

                    Case 3
                        If Me.chkMostrar.Checked = True Then
                            DtCatalogo = SqlHelper.ExecuteQueryDT("Select * from vwrptStbCatalogos Order by Nombre")
                            strImpresion = "Catalogos Activos e Inactivos con sus Valores"

                        Else
                            DtCatalogo = StbCatalogo.RetrieveDT("", , "Nombre,Descripcion,Activo")
                            strImpresion = "Catalogos Activos e Inactivos sin sus Valores"

                        End If

                End Select

                '----En caso de que sea un Catalogo Especifico-----------------------------------

            Else
                Dim parametro(2) As SqlParameter
                parametro(0) = New SqlParameter("@StbCatalogoId", SqlDbType.VarChar, 25)
                parametro(0).Value = Convert.ToInt32(Me.cmbCatalogos.SelectedValue)

                Select Case Me.chkMostrar.Checked
                    Case True
                        DtCatalogo = SqlHelper.ExecuteQueryDT(ClsConsultas.SqlReporteCatAct, parametro)
                        strImpresion = "Catalogo" + Me.cmbCatalogos.SelectedText + " y sus valores"

                    Case False
                        DtCatalogo = SqlHelper.ExecuteQueryDT(ClsConsultas.SqlReporteCatInact, parametro)
                        strImpresion = "Catalogo" + Me.cmbCatalogos.SelectedText + " sin sus valores"
                End Select

            End If


            If DtCatalogo.Rows.Count = 0 Then
                MsgBox("No existen datos para generar el reporte", MsgBoxStyle.Information, "Datos incompletos")
                Exit Sub
            End If

            rptCatVal.DataSource = DtCatalogo
            rptCatVal.lblParametro.Text = strImpresion

            If Me.rbPantalla.Checked = True Then
                clsProyecto.ImprimirEnPantalla(rptCatVal)

            ElseIf Me.rbArchivo.Checked = True Then
                clsProyecto.ImprimirEnArchivo(rptCatVal, Me)

            Else
                clsProyecto.ImprimirEnImpresora(rptCatVal)
            End If


        Catch ex As SqlClient.SqlException
            clsError.CaptarError(ex)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub cmbCatalogos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCatalogos.SelectedValueChanged
        If Me.chkMostrar.Text <> "Todos" Then
            Me.chkMostrar.Enabled = False
        End If
    End Sub

#Region "Clase privada"
    Private Class ClsConsultas

        Public Const SqlReporteCatAct As String = " SELECT Distinct Nombre,Descripcion,StbCatalogoId,Activo,Codigo,ValorDescripcion,ValorActivo" & _
                                                     " FROM vwrptStbCatalogos " & _
                                                     " WHERE (StbCatalogoId= @StbCatalogoId)"

        Public Const SqlReporteCatInact As String = " SELECT Nombre,Descripcion,StbCatalogoId,Activo " & _
                                                       " FROM vwrptStbCatalogos" & _
                                                       " WHERE stbCatalogoId=@StbCatalogoId group by StbCatalogoId,Nombre,Descripcion,Activo"


    End Class
#End Region

End Class