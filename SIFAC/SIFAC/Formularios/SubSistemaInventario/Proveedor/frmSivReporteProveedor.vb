Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.Data.SqlClient
Imports System.IO
Public Class frmSivReporteProveedor

#Region "Declaración de Variables propias del formulario"
    Public dtProveedor, dtRptProveedor As DataTable
    Dim objSeg As SsgSeguridad
#End Region

#Region "Inicializar GUI"

#Region "Aplicar Seguridad"

    Private Sub Seguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "FRMSIVREPORTEPROVEEDOR"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("VERREPORTE") Then
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
            cmbProveedor.ExtendRightColumn = True
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
        Dim objRptProveedores As rptProveedores
        Dim objImpresion As frmOpcionesImpresion
        objImpresion = New frmOpcionesImpresion
        If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            objRptProveedores = New rptProveedores
            If Me.rbProveedor.Checked Then
                dtRptProveedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID, objPersonaID, Proveedor, RUCID, FechaIngreso, Activo, Direccion, Telefono, Email, Contacto, EmailContacto, CelularContacto, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProveedor", "SivProveedorID=" & Me.cmbProveedor.SelectedValue))
            End If
            If Me.rbTodos.Checked Then
                dtRptProveedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID, objPersonaID, Proveedor, RUCID, FechaIngreso, Activo, Direccion, Telefono, Email, Contacto, EmailContacto, CelularContacto, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProveedor", "1=1"))
            End If
            If Me.rbActivos.Checked Then
                dtRptProveedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID, objPersonaID, Proveedor, RUCID, FechaIngreso, Activo, Direccion, Telefono, Email, Contacto, EmailContacto, CelularContacto, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProveedor", "Activo=1"))
            End If
            If Me.rbInactivos.Checked Then
                dtRptProveedor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID, objPersonaID, Proveedor, RUCID, FechaIngreso, Activo, Direccion, Telefono, Email, Contacto, EmailContacto, CelularContacto, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptProveedor", "Activo=0"))
            End If

            objRptProveedores.DataSource = Me.dtRptProveedor
            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(objRptProveedores)
                Case 2
                    clsProyecto.ImprimirEnImpresora(objRptProveedores, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(objRptProveedores, Me)
            End Select
        End If
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub frmSivReporteProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Seguridad()
        CargarProveedor()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.rbProveedor.Checked And Me.cmbProveedor.Text = "" Then
            MsgBox("Seleccione un proveedor", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.cmbProveedor.Focus()
            Exit Sub
        End If
        Imprimir()
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

    Private Sub cmbProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.Click
        Me.rbProveedor.Checked = True
    End Sub

    Private Sub cmbProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.TextChanged
        Me.rbProveedor.Checked = True
    End Sub

#End Region

End Class