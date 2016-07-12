Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SCCUM.BO

Public Class frmSivRptRepuesto
    Dim dtProveedor, dtTipoRepuesto, dtMarca As DataTable

#Region "Cargar Combos"

    Private Sub CargarProveedor()
        dtProveedor = New DataTable
        Dim sSQL As String
        Try
            sSQL = clsConsultas.ObtenerConsultaGeneral("NombreProveedor, SivProveedorID", "vwRptSivProveedores", "1=1 ORDER BY NombreProveedor")
            dtProveedor = DAL.SqlHelper.ExecuteQueryDT(sSQL)

            Me.cmbProveedor.DataSource = dtProveedor
            Me.cmbProveedor.DisplayMember = "NombreProveedor"
            Me.cmbProveedor.ValueMember = "SivProveedorID"
            Me.cmbProveedor.Splits(0).DisplayColumns("SivProveedorID").Visible = False
            Me.cmbProveedor.ExtendRightColumn = True
            Me.cmbProveedor.ColumnHeaders = False
            'Me.dtProveedor.DefaultView.Sort = "NombreProveedor"
            Me.dtProveedor.Rows.Add("TODOS", "0")
            Me.cmbProveedor.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarTipoRepuestos()
        dtTipoRepuesto = New DataTable
        Try
            dtTipoRepuesto = ClsCatalogos.GetValoresCatalogo("TIPOREPUESTO", "StbValorCatalogoID, Descripcion", "Descripcion")
            Me.cmbTipoRepuesto.DataSource = dtTipoRepuesto
            Me.cmbTipoRepuesto.DisplayMember = "Descripcion"
            Me.cmbTipoRepuesto.ValueMember = "StbValorCatalogoID"
            Me.cmbTipoRepuesto.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipoRepuesto.ExtendRightColumn = True
            Me.cmbTipoRepuesto.ColumnHeaders = False
            'Me.dtTipoRepuesto.DefaultView.Sort = "Descripcion"
            Me.dtTipoRepuesto.Rows.Add("0", "TODOS")
            Me.cmbTipoRepuesto.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarMarca()
        dtMarca = New DataTable
        Try
            dtMarca = ClsCatalogos.GetValoresCatalogo("MARCAREPUESTO", "StbValorCatalogoID,Descripcion", "Descripcion")
            Me.cmbMarca.DataSource = dtMarca
            Me.cmbMarca.DisplayMember = "Descripcion"
            Me.cmbMarca.ValueMember = "StbValorCatalogoID"
            Me.cmbMarca.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbMarca.ExtendRightColumn = True
            Me.cmbMarca.ColumnHeaders = False
            'Me.dtMarca.DefaultView.Sort = "Descripcion"
            Me.dtMarca.Rows.Add("0", "TODOS")
            Me.cmbMarca.SelectedValue = 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos de formulario"

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Imprimir()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmSivRptRepuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarMarca()
        Me.CargarProveedor()
        Me.CargarTipoRepuestos()
        Me.rbActivos.Checked = True
    End Sub

#End Region

#Region "Imprimir"

    Private Function ObtenerFiltro() As String
        Dim strFiltro As String = ""
        If Me.cmbProveedor.Text.Trim.Length <> 0 And Me.cmbProveedor.SelectedValue <> 0 Then
            strFiltro = "SivProveedorID= " & Me.cmbProveedor.SelectedValue.ToString
        End If
        If Me.cmbMarca.Text.Trim.Length <> 0 And Me.cmbMarca.SelectedValue <> 0 Then
            If strFiltro.Trim.Length <> 0 Then
                strFiltro = strFiltro & "  AND objMarca= " & Me.cmbMarca.SelectedValue.ToString
            Else
                strFiltro = " objMarca = " & Me.cmbMarca.SelectedValue.ToString
            End If
        End If

        If Me.cmbTipoRepuesto.Text.Trim.Length <> 0 And Me.cmbTipoRepuesto.SelectedValue <> 0 Then
            If strFiltro.Trim.Length <> 0 Then
                strFiltro = strFiltro & " AND objTipoRepuesto= " & Me.cmbTipoRepuesto.SelectedValue.ToString
            Else
                strFiltro = " objTipoRepuesto = " & Me.cmbTipoRepuesto.SelectedValue.ToString
            End If
        End If
        If Me.rbActivos.Checked Then
            If strFiltro.Trim.Length <> 0 Then
                strFiltro = strFiltro & " AND Activo = 1 "
            Else
                strFiltro = " Activo = 1"
            End If
        End If

        If Me.rbInactivos.Checked Then
            If strFiltro.Trim.Length <> 0 Then
                strFiltro = strFiltro & " AND Activo = 0"
            Else
                strFiltro = " Activo = 0"
            End If
        End If

        If Me.rbTodos.Checked Then
            If strFiltro.Trim.Length = 0 Then
                strFiltro = " 1=1 "
            End If
        End If

        Return strFiltro

    End Function

    Private Sub Imprimir()
        Dim objReporteRepuestos As rptSivRepuestos
        Dim objImpresion As frmOpcionesImpresion
        Dim sSQL, SCampos As String

        objImpresion = New frmOpcionesImpresion
        objReporteRepuestos = New rptSivRepuestos

        objReporteRepuestos.txtContador.Text = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Codigo, DescripcionCorta, TipoRepuesto, Marca, plazoGarantia, Precio, Activo, Imagen, Proveedor, objMarca, objTipoRepuesto, SivProveedorID, Compatibilidad", "vwRptRepuestos", Me.ObtenerFiltro)).Rows.Count.ToString
        If objReporteRepuestos.txtContador.Text = 0 Then
            MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Exit Sub
        End If

        If objImpresion.ShowDialog = Windows.Forms.DialogResult.OK Then
            SCampos = "Codigo, DescripcionCorta, TipoRepuesto, Marca, plazoGarantia, Precio, Activo, ActivoLetras, Imagen, Proveedor, objMarca, objTipoRepuesto, SivProveedorID, Compatibilidad"
            sSQL = clsConsultas.ObtenerConsultaGeneral(SCampos, "vwRptRepuestos", Me.ObtenerFiltro & " ORDER BY DescripcionCorta")
            objReporteRepuestos.DataSource = SqlHelper.ExecuteQueryDT(sSQL)

            If Not Me.chkImagen.Checked Then
                objReporteRepuestos.picImagen.Visible = False
                objReporteRepuestos.lblImagen.Visible = False
                objReporteRepuestos.shpFondo.Width = 9.5
            End If

            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(objReporteRepuestos)
                Case 2
                    clsProyecto.ImprimirEnImpresora(objReporteRepuestos, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(objReporteRepuestos, Me)
            End Select
        End If
    End Sub
#End Region


End Class