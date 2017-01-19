
'-- Formulario para seleccionar par�metros de filtrado del reporte 
'-- de Kardex

Imports DAL
Imports SIFAC.BO
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraReports.UI

Public Class frmCriteriosReporteKardex

#Region "Atributos"
    Private m_IdSucursalCentral As Integer
    Private m_IdSucursalSession As Integer
    Private m_FechaKardex As DateTime
#End Region

#Region "Propiedades"
    Property IdSucursalCentral() As Integer
        Get
            IdSucursalCentral = Me.m_IdSucursalCentral
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalCentral = value
        End Set
    End Property

    Property IdSucursalSession() As Integer
        Get
            IdSucursalSession = Me.m_IdSucursalSession
        End Get
        Set(ByVal value As Integer)
            Me.m_IdSucursalSession = value
        End Set
    End Property

    Property FechaKardex() As DateTime
        Get
            FechaKardex = Me.m_FechaKardex
        End Get
        Set(ByVal value As DateTime)
            Me.m_FechaKardex = value
        End Set
    End Property
#End Region

#Region "Cargar combos"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Sucursales
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Julio de 2010, 09:40 am.
    ''' </summary>
    Private Sub CargarComboSucursales()
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

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Repuestos
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Julio de 2010, 09:47 am.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarComboRepuestos()
        Dim dtDatos As New DataTable
        Try
            dtDatos = SivProductos.RetrieveDT("Activo=1 ", "Nombre", "SivProductoID, Nombre")
            With Me.cmbRepuestos
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "SivProductoID"
                '.Splits(0).DisplayColumns("SivRepuestoID").Visible = False
                .Splits(0).DisplayColumns("SivProductoID").Width = 40
                .Columns("Nombre").Caption = "Descripci�n"
                .Columns("SivProductoID").Caption = "C�digo"
                .ExtendRightColumn = True
                .ColumnHeaders = True
            End With

            dtDatos.Rows.Add("0", "TODOS")
            Me.cmbRepuestos.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtDatos = Nothing
        End Try
    End Sub
#End Region

#Region "Cargar Formulario"
    Private Sub frmCriteriosReporteUtilidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

       
            Me.FechaKardex = Convert.ToDateTime(ClsCatalogos.GetValorParametro("FechaKardex"))
        Me.CargarComboSucursales()

        Me.IdSucursalCentral = ClsCatalogos.GetStbTiendaID("C") '-- C=Central
        Me.IdSucursalSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
        Me.VerificarSucursalRepuesto()

        Me.cmbBodegas.Enabled = Me.IdSucursalSession = Me.IdSucursalCentral
        Me.CargarComboRepuestos()

        Me.dtpFechaDesde.Value = Me.FechaKardex
            Me.dtpFechaHasta.Value = clsProyecto.Conexion.FechaServidor

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Verificar Sucursal Repuesto"
    Private Sub VerificarSucursalRepuesto()

        If String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            MsgBox("No ha configurado la bodega en el utilitario de configuraci�n del sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            If Me.cmbBodegas.FindStringExact(Me.IdSucursalSession.ToString, 0, 0) = -1 Then
                MsgBox("La bodega configurada en la sesi�n del sistema, no esta registrada en el sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.cmbBodegas.SelectedValue = Me.IdSucursalSession
            End If
        End If
    End Sub
#End Region

#Region "Eventos de Formulario"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim strFiltro As String
        Dim blnCriterioCorrecto As Boolean
        blnCriterioCorrecto = Me.VerificarCriterios()
        If blnCriterioCorrecto Then
            strFiltro = Me.DevolverFiltro()
            Me.Imprimir_Reporte(strFiltro)
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged, dtpFechaHasta.TextChanged
        Me.ErrErrores.Clear()
    End Sub

#End Region

#Region "Verificar Criterios"
    Private Function VerificarCriterios() As Boolean
        Dim blnValido As Boolean = True

        'Verificar per�odo vac�o
        If Me.dtpFechaDesde.Value.ToString.Trim.Length = 0 Or Me.dtpFechaHasta.Value.ToString.Trim.Length = 0 Then
            MsgBox("No ha seleccionado un per�odo de tiempo correcto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            If Me.dtpFechaDesde.Value.ToString.Length = 0 Then
                Me.dtpFechaDesde.Focus()
            Else
                Me.dtpFechaHasta.Focus()
            End If
            blnValido = False
            Exit Function
        End If

        'Verificar per�odo
        If Convert.ToDateTime(Me.dtpFechaDesde.Value).Date > Convert.ToDateTime(Me.dtpFechaHasta.Value).Date Then
            Me.ErrErrores.SetError(Me.dtpFechaDesde, "La fecha desde debe ser menor o igual a fecha hasta.")
            blnValido = False
            Exit Function
        End If

        Return blnValido

    End Function
#End Region

#Region "Devolver Filtro"
    ''' <summary>
    ''' Funci�n encargada de construir y devolver el filtro que ocupar� la consulta del reporte. 
    ''' este se construye en base a los criterios seleccionados por el usuario
    ''' Autor : Gelmin Martinez
    ''' Fecha 20 de Julio de 2010, 09:56 am.
    ''' </summary>
    Private Function DevolverFiltro() As String
        Dim strFiltro As String = String.Empty

        'Verificar si seleccion� sucursal
        If Me.cmbBodegas.SelectedValue <> 0 Then
            strFiltro = " objTiendaID = " + Me.cmbBodegas.SelectedValue.ToString
        End If

        If Me.cmbRepuestos.SelectedValue <> 0 Then
            If strFiltro.Length = 0 Then
                strFiltro = " objProductoID = '" + Me.cmbRepuestos.SelectedValue.ToString & "'"
            Else
                strFiltro += " AND objProductoID = '" + Me.cmbRepuestos.SelectedValue.ToString & "'"
            End If
        End If

        'Asignar rango de fechas (112=Fecha en formato ISO, ejemplo: 20 Julio 2010 = 20100720)
        If Not IsDBNull(dtpFechaDesde.Value) And Not IsDBNull(dtpFechaHasta.Value) Then
            If strFiltro.Length = 0 Then
                strFiltro = "(CONVERT(VARCHAR,Fecha,112) >='''" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "''' AND CONVERT(VARCHAR, Fecha,112) <='''" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "''')"
            Else
                strFiltro += " AND (CONVERT(VARCHAR,Fecha,112) >='''" + Format(dtpFechaDesde.Value, "yyyyMMdd") + "''' AND CONVERT(VARCHAR, Fecha,112) <='''" + Format(Me.dtpFechaHasta.Value, "yyyyMMdd") + "''')"
            End If
        End If

        If String.IsNullOrEmpty(strFiltro) Then
            strFiltro = "1=0"
        End If

        Return strFiltro
    End Function
#End Region

#Region "Imprimir Reporte"
    Private Sub Imprimir_Reporte(ByVal strFiltro As String)
        Dim dsDatos As DataSet
        Dim strCampos, strSQL As String

        Me.Cursor = Cursors.WaitCursor
        Dim objjReporte As New rptKardex()
        Try
            strCampos = "Convert(varchar,Fecha,103) as Fecha, Transaccion, Tipo, Proveedor_Cliente, objProductoID, Costo, objTiendaID, CodigoSucursal, NombreSucursal, Entrada, Salida, CostoProm, DescripcionRepuesto, CodigosProveedor, ExistenciaAnterior, Existencia, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa"
            strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwRptKardex", strFiltro + " ORDER BY Fecha") 'ORDER BY NombreSucursal, DescripcionRepuesto, Fecha
            dsDatos = SqlHelper.ExecuteQueryDS(strSQL)

            If dsDatos.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = dsDatos
                objjReporte.DataMember = dsDatos.Tables(0).TableName
                objjReporte.txtRangofechas.Text = "Desde " & Format(dtpFechaDesde.Value, "dd/MM/yyyy") & " hasta " & Format(dtpFechaDesde.Value, "dd/MM/yyyy")
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

    'Procedimiento encargado de cargar los datos del encabezado de reportes.
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
        'parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmVerCosto", Me.rbtCantidadCosto.Checked.ToString, False))

        'Agregaci�n de rango de fechas al encabezado
        Dim strDesde, strHasta As String
        strDesde = Format(dtpFechaDesde.Value, "dd/MM/yyyy")
        strHasta = Format(dtpFechaHasta.Value, "dd/MM/yyyy")

        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFechaDesde", strDesde, False))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFechaHasta", strHasta, False))

        reporte.SetParameters(parametros)
    End Sub
#End Region

End Class