Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frmSivReporteProveedor

#Region "Declaraci�n de Variables propias del formulario"
    Public dtProveedor, dtRptProveedor As DataTable
    Dim objSeg As SsgSeguridad
#End Region

#Region "Inicializar GUI"

#Region "Aplicar Seguridad"

    Private Sub Seguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "frmSivReporteProveedor"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("VerReporte") Then
                Me.Close()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar Combo Proveedor"

    Private Sub CargarProveedor()
        Try
            dtProveedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID,Proveedor", "vwRptProveedor", "1=1"))
            cmbProveedor.DataSource = Me.dtProveedor
            cmbProveedor.DisplayMember = "Proveedor"
            cmbProveedor.ValueMember = "SivProveedorID"
            cmbProveedor.Splits(0).DisplayColumns("SivProveedorID").Visible = False
            Me.cmbProveedor.ExtendRightColumn = True
            Me.cmbProveedor.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#End Region

#Region "Operaciones"

    Private Sub Imprimir()

        Dim ds As DataSet
        Dim strFiltro As String = String.Empty
        Try
            Dim objjReporte As New rptProveedores()

            If Me.rbProveedor.Checked Then
                strFiltro = "SivProveedorID=" & Me.cmbProveedor.SelectedValue
            End If
            If Me.rbTodos.Checked Then
                strFiltro = "1=1"
            End If
            If Me.rbActivos.Checked Then
                strFiltro = "Activo=1"
            End If
            If Me.rbInactivos.Checked Then
                strFiltro = "Activo=0"
            End If

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SivProveedorID, objPersonaID, Proveedor, RUCID, FechaIngreso, Activo, Direccion, Telefono, Email, Contacto, EmailContacto, CelularContacto, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProveedor", strFiltro))
            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
            
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub frmSivReporteProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Seguridad()
        CargarProveedor()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            If Me.rbProveedor.Checked And (Me.cmbProveedor.Text = "" Or IsNothing(cmbProveedor.SelectedValue)) Then
                MsgBox("Seleccione un proveedor", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.cmbProveedor.Focus()
                Exit Sub
            End If
            Imprimir()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTodos.CheckedChanged
        Me.cmbProveedor.SelectedIndex = -1
    End Sub

    Private Sub rbActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbActivos.CheckedChanged
        Me.cmbProveedor.SelectedIndex = -1
    End Sub

    Private Sub rbInactivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInactivos.CheckedChanged
        Me.cmbProveedor.SelectedIndex = -1
    End Sub

    Private Sub cmbProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.rbProveedor.Checked = True
    End Sub

    Private Sub cmbProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.rbProveedor.Checked = True
    End Sub

#End Region

End Class