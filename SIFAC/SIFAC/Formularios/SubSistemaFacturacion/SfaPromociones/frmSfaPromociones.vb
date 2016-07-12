Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SCCUM.BO

''' <summary>
''' Formulario Principal de Mantenimiento de promociones
''' Autor : Gelmín Martínez
''' Fecha :17 de Junio de 2010, 01:47 pm.
''' </summary>
Public Class frmSfaPromociones

#Region "Atributos"
    Private dsPromociones As DataSet
    Private dtPromociones As DataTable
    Private dtPromocionesDetalle As DataTable

    ' Variables para control de seguridad
    Private blnAgregar As Boolean
    Private blnEditar As Boolean
    Private blnInactivar As Boolean
    Private blnConsultar As Boolean
    Private blnImprimir As Boolean
#End Region

#Region "Constantes"
    Public Const AGREGACION = 0
    Public Const EDICION = 1
    Public Const CONSULTA = 2
#End Region

#Region "Cargar Datos"
    Private Sub CargarDatos()
        Dim strCampos, strSQL As String

        'Cargando promociones en el grid Maestro
        strCampos = "SfaPromocionID, Descripcion, CONVERT(VARCHAR,fechainicio,103) FechaInicio, CONVERT(VARCHAR, fechafin,103) AS FechaFin, dbo.FnGetTiendasPromocion(dbo.SfaPromocion.SfaPromocionID) AS TiendasPromocion, Activo"
        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.SfaPromocion")
        Me.dtPromociones = SqlHelper.ExecuteQueryDT(strSQL)

        'Cargando detalle de promociones en grid detalle
        strCampos = "objPromocionID, DescripcionRepuesto, SivRepuestoID, Descuento"
        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwSfaPromocionesDetalle")
        Me.dtPromocionesDetalle = SqlHelper.ExecuteQueryDT(strSQL)

        'Integrando tabla maestra y tabla detalle en un solo dataset
        Me.dsPromociones = New DataSet
        With Me.dsPromociones
            .Merge(Me.dtPromociones)
            .Tables(0).TableName = "SfaPromociones"
            .Merge(Me.dtPromocionesDetalle)
            .Tables(1).TableName = "SfaPromocionesDetalle"
            .Relations.Add("SfaPromociones_PromocionesDetalle", .Tables(0).Columns("SfaPromocionID"), .Tables(1).Columns("objPromocionID"))
            .Tables("SfaPromociones").PrimaryKey = New DataColumn() {Me.dsPromociones.Tables("SfaPromociones").Columns("SfaPromocionID")}
            .Tables("SfaPromociones").DefaultView.Sort = "SfaPromocionID"
        End With

        'Enlazando los grid Maestro - Detalle
        Me.grdPromociones.SetDataBinding(Me.dsPromociones, "SfaPromociones", True)
        Me.grdPromocionesDetalle.SetDataBinding(Me.dsPromociones, "SfaPromociones.SfaPromociones_PromocionesDetalle", True)

        Me.grdPromociones.Caption = " Promociones (" + Me.grdPromociones.RowCount.ToString + ")"
        'Formatear los grid de maestro y detalle
        Me.FormatearGrid_MD()

        If Me.dtPromociones.Rows.Count = 0 Then
            Me.cmdEditar.Enabled = False
            Me.cmdConsultar.Enabled = False
            Me.cmdImprimir.Enabled = False
            Me.cmdInactivar.Enabled = False
        Else
            Me.cmdEditar.Enabled = Me.blnEditar
            Me.cmdConsultar.Enabled = Me.blnConsultar
            Me.cmdImprimir.Enabled = Me.blnImprimir
            Me.cmdInactivar.Enabled = Me.blnInactivar

            Me.VerificarEstadoPromocion()
        End If

    End Sub

#End Region

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 17 de Junio de 2010. 02:31 pm.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSFAPROMOCIONES"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            'Obtener permisos en variables de control
            Me.blnAgregar = objSeg.TienePermiso("AGREGARSFAPROMOCION")
            Me.blnEditar = objSeg.TienePermiso("EDITARSFAPROMOCION")
            Me.blnInactivar = objSeg.TienePermiso("INACTIVARSFAPROMOCION")
            Me.blnConsultar = objSeg.TienePermiso("CONSULTARSFAPROMOCION")
            Me.blnImprimir = objSeg.TienePermiso("IMPRIMIRSFAPROMOCION")

            'Aplicar permisos a los comandos
            Me.cmdAgregar.Enabled = Me.blnAgregar
            Me.cmdEditar.Enabled = Me.blnEditar
            Me.cmdInactivar.Enabled = Me.blnInactivar
            Me.cmdConsultar.Enabled = Me.blnConsultar
            Me.cmdImprimir.Enabled = Me.blnImprimir

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar Formulario"
    Private Sub frmSfaPromociones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.AplicarSeguridad()
        Me.CargarDatos()
    End Sub
#End Region

#Region "Procedimientos"

#Region "Agregar promoción"
    ''' <summary>
    ''' Procedimiento encargado de agregar una promoción
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 18 de Junio de 2010, 04:35 pm.
    ''' </summary>
    Private Sub AgregarPromocion()
        Dim objForm As New frmSfaPromocionesEdit
        Dim iIndiceRegistro As Integer

        Try
            objForm.TypeGui = AGREGACION
            If objForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargarDatos()
                If (Me.dtPromociones.Rows.Count <> 0) Then
                    Me.dtPromociones.DefaultView.Sort = "SfaPromocionID"
                    iIndiceRegistro = Me.dtPromociones.DefaultView.Find(objForm.SfaPromocionID)
                    Me.grdPromociones.Row = iIndiceRegistro
                    If MsgBox("¿Desea imprimir los datos de la promoción?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                        ImprimirPromocionSeleccionada(objForm.SfaPromocionID)
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Editar promoción"
    ''' <summary>
    ''' Procedimiento encargado de editar una promoción
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 23 de Junio de 2010, 11:51 pm.
    ''' </summary>
    Private Sub EditarPromocion()
        Dim objForm As New frmSfaPromocionesEdit
        Dim iIndiceRegistro As Integer
        If Not IsDBNull(Me.grdPromociones.Columns("sfaPromocionID").Value) Then
            Dim IdPromo As Integer = Integer.Parse(Me.grdPromociones.Columns("sfaPromocionID").Value)

            Try
                objForm.TypeGui = EDICION
                objForm.SfaPromocionID = IdPromo
                If objForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.CargarDatos()
                    If (Me.dtPromociones.Rows.Count <> 0) Then
                        Me.dtPromociones.DefaultView.Sort = "SfaPromocionID"
                        iIndiceRegistro = Me.dtPromociones.DefaultView.Find(objForm.SfaPromocionID)
                        Me.grdPromociones.Row = iIndiceRegistro
                        If MsgBox("¿Desea imprimir los datos de la promoción?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            'Imprimir_Promociones(objForm.SfaPromocionID)
                        End If
                    End If
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        End If
    End Sub
#End Region

#Region "Inactivar Promoción"
    ''' <summary>
    ''' Procedimiento encargado de inactivar una promoción
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 23 de Junio de 2010, 06:08 pm.
    ''' </summary>
    Private Sub InactivarPromocion()
        Dim T As New TransactionManager
        Dim objSfaPromo As New SfaPromocion
        Dim IdPromo As Integer

        If Not IsDBNull(Me.grdPromociones.Columns("sfaPromocionID").Value) Then
            Try
                IdPromo = Integer.Parse(Me.grdPromociones.Columns("sfaPromocionID").Value)
                If MsgBox("¿Seguro que desea Inactivar la promoción seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    T.BeginTran()
                    With objSfaPromo
                        .Retrieve(IdPromo, T)
                        .Activo = False
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor
                        .Update(T)
                    End With
                    T.CommitTran()
                    Me.grdPromociones.Columns("Activo").Value = False
                    Me.cmdInactivar.Enabled = False
                    MsgBox("Promoción desactivada con exito.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            Finally
                T = Nothing
                objSfaPromo = Nothing
            End Try
        End If
    End Sub
#End Region

#Region "Consultar Promoción"
    ''' <summary>
    ''' Procedimiento encargado de Consultar una promoción
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 23 de Junio de 2010, 05:56 pm.
    ''' </summary>
    Private Sub ConsultarPromocion()
        Dim objForm As New frmSfaPromocionesEdit
        If Not IsDBNull(Me.grdPromociones.Columns("sfaPromocionID").Value) Then
            Dim IdPromo As Integer = Integer.Parse(Me.grdPromociones.Columns("sfaPromocionID").Value)

            Try
                objForm.TypeGui = CONSULTA
                objForm.SfaPromocionID = IdPromo
                objForm.ShowDialog()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        End If
    End Sub
#End Region

#Region "Imprimir Promoción"
    ''' <summary>
    ''' Procedimiento encargado de Imprimir la promoción que esté seleccionada
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 17 de Junio de 2010, 02:41 pm.
    ''' </summary>
    Private Sub ImprimirPromocionSeleccionada(ByVal SfaPromocionID As Integer)
        Dim Visor As New frmVisorRS
        Dim sFiltro, sCampos, sSQL As String
        Dim dtDatos As DataTable
        sFiltro = "SfaPromocionID=" + SfaPromocionID.ToString
        sCampos = "SfaPromocionID, Descripcion, TiendasAplica, Convert(varchar,fechainicio,103) as FechaInicio , Convert(varchar,fechafin,103) as FechaFin, PromocionGlobal, AplicanRestricciones, Activo, objRepuestoID, objTipoRepuesto, DescripcionRepuestoTipoRepuesto, Precio, Descuento, PrecioPromocion"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwRptSfaPromocion", sFiltro)
        dtDatos = SqlHelper.ExecuteQueryDT(sSQL)

        With Visor.VisorReportes
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportEmbeddedResource = "SCCUM.rptPromocion.rdlc"
            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DtDatosRptSfaPromocion_vwRptSfaPromocion", dtDatos))
            Me.CargarEncabezadoReporte(.LocalReport)
            .RefreshReport()
        End With

        Visor.ShowDialog()
    End Sub

    Private Sub CargarEncabezadoReporte(ByRef reporte As Microsoft.Reporting.WinForms.LocalReport)
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim strNombreEmpresa, strDirEmpresa, strTelEmpresa, strEmailEmpresa As String

        strNombreEmpresa = ClsCatalogos.GetValorParametro("EMPRESA")
        strDirEmpresa = ClsCatalogos.GetValorParametro("DireccionEmpresa")
        strTelEmpresa = ClsCatalogos.GetValorParametro("TelefonoEmpresa")
        strEmailEmpresa = ClsCatalogos.GetValorParametro("EMAIL")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmNombreEmpresa", strNombreEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDireccionEmpresa", strDirEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmTelefonoEmpresa", strTelEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmEmailEmpresa", strEmailEmpresa, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmUsuarioFecha", clsProyecto.Conexion.Usuario & " , " + Format(clsProyecto.Conexion.FechaServidor, "dd/MM/yyyy"), False))

        reporte.SetParameters(parametros)
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Imprimir un reporte de promociones por filtro
    ''' Autor : Gelmin Martínez.
    ''' Fecha : 17 de Junio de 2010, 02:41 pm.
    ''' </summary>
    Private Sub ImprimirPromocionByFiltro()
        Dim frmCriteriosReporte As New frmReportesPromociones
        frmCriteriosReporte.ShowDialog()
    End Sub

#End Region

#End Region

#Region "Eventos de controles"
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Me.AgregarPromocion()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Me.EditarPromocion()
    End Sub

    Private Sub cmdInactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInactivar.Click
        Me.InactivarPromocion()
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Me.ConsultarPromocion()
    End Sub

    Private Sub cmdImprimirSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirSeleccion.Click
        If Not IsDBNull(Me.grdPromociones.Columns("SfaPromocionID").Value) AndAlso Me.grdPromociones.Columns("SfaPromocionID").Value.ToString.Trim.Length <> 0 Then
            Me.ImprimirPromocionSeleccionada(Me.grdPromociones.Columns("SfaPromocionID").Value)
        End If
    End Sub

    Private Sub cmdImprimirFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirFiltro.Click
        Me.ImprimirPromocionByFiltro()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Me.CargarDatos()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub grdPromociones_FilterChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdPromociones.FilterChange
        Me.grdPromociones.Caption = " Promociones (" & Me.grdPromociones.RowCount & ")"
        If Me.grdPromociones.RowCount = 0 Then
            Me.cmdInactivar.Enabled = False
            Me.cmdEditar.Enabled = False
            Me.cmdConsultar.Enabled = False
        Else
            Me.cmdAgregar.Enabled = Me.blnAgregar
            Me.cmdInactivar.Enabled = Me.blnInactivar
            Me.cmdConsultar.Enabled = Me.blnConsultar
        End If
    End Sub

    Private Sub grdPromociones_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdPromociones.RowColChange
        VerificarEstadoPromocion()
    End Sub

    Private Sub VerificarEstadoPromocion()
        Try
            If Not IsDBNull(Me.grdPromociones.Columns("Activo").Value) Then
                If Me.grdPromociones.Columns("Activo").Value.ToString.Trim.Length <> 0 Then
                    Me.cmdEditar.Enabled = Me.blnEditar And Convert.ToBoolean(Me.grdPromociones.Columns("Activo").Value)
                    Me.cmdInactivar.Enabled = Me.blnInactivar And Convert.ToBoolean(Me.grdPromociones.Columns("Activo").Value)
                End If
            End If
        Catch ex As Exception
            Me.cmdEditar.Enabled = False
        End Try
    End Sub

#End Region

#Region "Formatear Grid Maestro y Detalle"
    Private Sub FormatearGrid_MD()
        'Grid de promociones
        With Me.grdPromociones
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .AllowSort = True
            .AllowColMove = True
            .ExtendRightColumn = True
            .FilterActive = True
            .FilterBar = True
        End With

        'Grid de detalle de promociones
        With Me.grdPromocionesDetalle
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .AllowSort = True
            .AllowColMove = True
            .ExtendRightColumn = True
            .FilterActive = True
            .FilterBar = True
            .Splits(0).DisplayColumns("objPromocionID").Visible = False
        End With

    End Sub
#End Region

End Class