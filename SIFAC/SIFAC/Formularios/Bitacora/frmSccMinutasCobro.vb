Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SCCUM.BO
Imports System.Data.SqlClient

Public Class frmSccMinutasCobro
    Dim DtDatosMinuta As New DataTable
    Dim m_SccCuentaID As String
    Dim m_Cliente As String
    Dim m_CodigoTienda As String
    Dim m_IDTienda As Integer
    Dim m_TasaCambio As Decimal

   
    Private Sub frmSccMinutasCobro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarTiendas()

        If Me.cmbSucursal.SelectedValue = 0 Then
            CargarDatos("1=1")
        Else
            CargarDatos(" StbTiendaID = " & Me.cmbSucursal.SelectedValue.ToString)
        End If

    End Sub

    Private Function Validar() As Boolean
        Dim intCantidad As Integer = 0
        Dim rst As Boolean

        For Each drwMinuta As DataRow In Me.DtDatosMinuta.Rows
            If drwMinuta("Seleccion") Then
                intCantidad = intCantidad + 1
            End If
        Next
        If intCantidad = 0 Then
            MsgBox("Debe seleccionar al menos un cliente.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            rst = False
        Else
            rst = True
        End If

        Return rst
    End Function


#Region "Carga de Datos"
    ''' <summary>
    ''' Procedimiento de Carga Total de las cuentas con Clasificacion "Motos".
    ''' Autor : Milagros Ruiz Oporta.
    ''' Fecha : 25 de Marzo de 2010.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos(ByVal strFiltro As String)
        Dim strConsulta As String = ""
        Try
            strConsulta = clsConsultas.ObtenerConsultaGeneral("Cast(0 as Bit) as Seleccion,StbTiendaID,SccCuentaID,Tienda,Cliente,CodigoTienda,Clasificacion", "vwSccMinutaCobro", strFiltro)
            Me.DtDatosMinuta = SqlHelper.ExecuteQueryDT(strConsulta)
            Me.grdSeleccion.SetDataBinding(Me.DtDatosMinuta, "", True)
            Me.grdSeleccion.Splits(0).DisplayColumns("StbTiendaID").Visible = False
            Me.grdSeleccion.ExtendRightColumn = True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

    Private Sub CargarTiendas()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT("", "Nombre", "StbTiendaID,Nombre")
            With Me.cmbSucursal
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
            Me.cmbSucursal.SelectedValue = 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Public Function ObtenerFiltro() As String
        Dim strFiltro As String = ""
        Dim strCliente As String = ""
        Dim cantSeleccion As Integer = 0

        If Me.cmbSucursal.Text <> "" Then
            If strFiltro = "" Then
                strFiltro = "StbTiendaID = " & Me.cmbSucursal.SelectedValue
            Else
                strFiltro = strFiltro & " AND StbTiendaID = " & Me.cmbSucursal.SelectedValue
            End If
        End If

        For Each drwMinuta As DataRow In Me.DtDatosMinuta.Rows
            If drwMinuta("Seleccion") Then
                strCliente = strCliente & "'" & drwMinuta("SccCuentaID") & "'" & ","
                cantSeleccion = cantSeleccion + 1
            End If
        Next

        If cantSeleccion > 0 Then
            If strFiltro = "" Then
                strFiltro = " SccCuentaID IN (" & strCliente.Substring(0, strCliente.Length - 1) & ")"
            Else
                strFiltro = strFiltro & " AND SccCuentaID IN (" & strCliente.Substring(0, strCliente.Length - 1).ToString & ")"
            End If
        End If

        Return strFiltro
    End Function
    Private Sub SeleccionarTodos()

        For Each drwMinuta As DataRow In Me.DtDatosMinuta.Rows

            If Me.chkTodos.Checked Then
                drwMinuta("Seleccion") = True
            Else
                drwMinuta("Seleccion") = False
            End If
        Next
    End Sub

    Private Sub Reportes()
        Dim objReportes As New frmStbVisor
        Try
            Try
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Cursor = Cursors.WaitCursor
                objReportes.IDReporte = "MinutaPago"
                objReportes.Width = frmPrincipal.Width - frmPrincipal.OutBarPrincipal.Width
                'objReportes.Height = frmPrincipal.Height - frmPrincipal.MenuPrincipal.Height - frmPrincipal.stbPrincipal.Height
                objReportes.MdiParent = frmPrincipal
                objReportes.strFiltro = Me.ObtenerFiltro
                objReportes.Show()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default

        End Try

    End Sub
    Private Sub ReportesFiltro()
        Dim objReportes As New frmStbVisor
        Try
            Try
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Cursor = Cursors.WaitCursor
                objReportes.IDReporte = "MinutaCliente"
                objReportes.Width = frmPrincipal.Width - frmPrincipal.OutBarPrincipal.Width
                'objReportes.Height = frmPrincipal.Height - frmPrincipal.MenuPrincipal.Height - frmPrincipal.stbPrincipal.Height
                objReportes.MdiParent = frmPrincipal
                objReportes.strFiltro = Me.ObtenerFiltro
                objReportes.Show()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub cmbSucursal_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectedValueChanged
        CargarDatos("StbTiendaID = " & Me.cmbSucursal.SelectedValue.ToString)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.Validar Then
            Reportes()
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.Validar Then
            ReportesFiltro()
        End If
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        Me.SeleccionarTodos()

    End Sub
End Class