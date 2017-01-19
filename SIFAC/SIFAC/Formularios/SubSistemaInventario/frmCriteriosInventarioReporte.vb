
Imports DAL
Imports SIFAC.BO 'Uso de clsConsultas
Imports Proyecto.Configuracion 'uso de clsProyecto
Imports Proyecto.Catalogos.Datos 'uso de clsCatalogos
Imports DevExpress.XtraReports.UI

Public Class frmCriteriosInventarioReporte

#Region "Atributos"
    Private m_IdSucursalSession As Integer
    Private DtMarca As DataTable
    Private m_TipoSeleccion As Integer
#End Region

#Region "Propiedades"
    Property IdSucursalSession() As Integer
        Get
            IdSucursalSession = Me.m_IdSucursalSession
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalSession = value
        End Set
    End Property
    Property TipoSeleccion() As Integer
        Get
            TipoSeleccion = Me.m_TipoSeleccion
        End Get
        Set(ByVal value As Integer)
            Me.m_TipoSeleccion = value
        End Set
    End Property

#End Region

#Region "Constantes"
    Private Const BODEGA = 1
    Private Const REPUESTO = 2
    Private Const TIPOREPUESTO = 3
    Private Const BODEGA_REPUESTO = 4
    Private Const BODEGA_TIPOREPUESTO = 5
    Private Const REPUESTO_TIPOREPUESTO = 6
    Private Const BODEGA_REPUESTO_TIPOREPUESTO = 7
#End Region

#Region "Cargar combo"

    Private Sub CargarComboBodegas()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbBodegas.RetrieveDT("Activo=1", "Nombre", "StbBodegaID, Codigo, Nombre")
            With Me.cmbBodegas
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbBodegaID"
                .Splits(0).DisplayColumns("StbBodegaID").Visible = False
                .Splits(0).DisplayColumns("Codigo").Width = 30
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            dtDatos.Rows.Add("0", "-", "TODAS")
            Me.cmbBodegas.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub


    Private Sub VerificarBodega()
        Try
            If String.IsNullOrEmpty(clsProyecto.Sucursal) Then
                MsgBox("No ha configurado la bodega en el utilitario de configuración del sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                If Me.cmbBodegas.FindStringExact(Me.IdSucursalSession.ToString, 0, 0) = -1 Then
                    MsgBox("La bodega configurada en la sesión del sistema, no esta registrada en el sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Else
                    Me.cmbBodegas.SelectedValue = Me.IdSucursalSession
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarMarca()
        Try
            cmbMarca.ValueMember = "MarcaID"
            cmbMarca.DisplayMember = "Nombre"
            DtMarca = SivMarcas.RetrieveDT("Activa=1")
            cmbMarca.DataSource = DtMarca
            cmbMarca.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            DtMarca = Nothing
        End Try

    End Sub

#End Region

#Region "Cargar Formulario"
    Private Sub frmCriteriosInventarioReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CargarComboBodegas()
            Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
            Me.VerificarBodega()

            Me.cmbBodegas.Enabled = Me.IdSucursalSession
            Me.CargarMarca()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Eventos de los controles"

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If Me.VerificarCriterios Then
                Imprimir_Reporte(ConstruirFiltro())
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub


    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Try
            If Me.chkTodos.Checked Then
                Me.cmbBodegas.SelectedValue = 0
                Me.cmbMarca.SelectedValue = 0
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Verificar Criterios"
    Private Function VerificarCriterios() As Boolean
        Dim blnValido As Boolean = False

        If Not chkTodos.Checked Then
            If (cmbBodegas.Text = String.Empty Or cmbBodegas.SelectedValue = 0) Then
                MsgBox("Debe seleccionar una bodega valida.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                blnValido = False
            Else
                blnValido = True
                Exit Function
            End If
        Else
            blnValido = True
        End If


        Return blnValido

    End Function
#End Region

#Region "Imprimir Reporte"
    Private Sub Imprimir_Reporte(Optional ByVal sFiltro As String = "1=1")
       
        Dim dsDatos As DataSet
        Dim strCampos, strSQL As String

        Me.Cursor = Cursors.WaitCursor
        Dim objjReporte As New rptInventario()
        Try
            strCampos = "SivProductoID,objBodegaID, objMarcaID, Modelo, Nombre, Marca, Precio_Credito, Existencia, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa"

            If chkTodos.Checked Then
                strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptExistenciaConsolidado", sFiltro)
            Else
                strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptExistenciaBodegas", sFiltro)
            End If

            dsDatos = SqlHelper.ExecuteQueryDS(strSQL)

            If dsDatos.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = dsDatos
                objjReporte.DataMember = dsDatos.Tables(0).TableName
                ''  objjReporte.txtRangofechas.Text = "Desde " & Format(dtpFechaDesde.Value, "dd/MM/yyyy") & " hasta " & Format(dtpFechaDesde.Value, "dd/MM/yyyy")
                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dsDatos = Nothing

            Me.Cursor = Cursors.Default
        End Try


    End Sub
#End Region

#Region "Construir Filtro"
    ''' <summary>
    ''' Función encargada de construir y devolver el filtro que ocupará la consulta del reporte. 
    ''' este se construye en base a los criterios seleccionados por el usuario
    ''' Autor : Gelmin Martinez
    ''' Fecha 14 de Junio de 2010, 09:15 pm.
    ''' </summary>
    Private Function ConstruirFiltro() As String
        Dim strFiltro As String = String.Empty
        Try
            If cmbBodegas.Text <> String.Empty And cmbBodegas.SelectedValue <> 0 Then
                If cmbMarca.Text <> String.Empty And cmbMarca.SelectedValue <> 0 Then
                    strFiltro = "objBodegaID= " & Me.cmbBodegas.SelectedValue.ToString & " AND objMarcaID=" & cmbMarca.SelectedValue.ToString
                Else
                    strFiltro = "objBodegaID= " & Me.cmbBodegas.SelectedValue.ToString
                End If
            Else
                strFiltro = "1=1= "
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return strFiltro
    End Function
#End Region



End Class