Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmSivProductos

#Region "Declaracion de Variables Globales"
    Public DtProductos As DataTable
    Public objSeg As SsgSeguridad
    Public boolAgregar, boolEditar, boolConsultar, boolDesactivar, boolImprimir As Boolean
#End Region

#Region "Procedimientos del formulario"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Try
            DtProductos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProductoID,Codigo,Nombre,Marca,Categoria,Activo", "vwStbProductos", ))
            DtProductos.PrimaryKey = New DataColumn() {Me.DtProductos.Columns("SivProductoID")}
            DtProductos.DefaultView.Sort = "SivProductoID"
            Me.grdProductos.DataSource = DtProductos
            Me.grdProductos.Text = "Productos (" & Me.DtProductos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    ''Descripción:      Metodo encargado de aplicar la seguridad al formulario
    Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "frmStbProductos"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AgregarProducto")
            boolEditar = objSeg.TienePermiso("ModificarProducto")
            boolConsultar = objSeg.TienePermiso("ConsultarProducto")
            boolDesactivar = objSeg.TienePermiso("InactivarProducto")
            boolImprimir = objSeg.TienePermiso("ImprimirProducto")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And DtProductos.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And DtProductos.Rows.Count > 0
            cmdDesactivar.Enabled = boolDesactivar And DtProductos.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And DtProductos.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

#Region "Eventos del formulario"

    Private Sub frmStbProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        CargarGrid()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim editProducto As frmSivProductosEditar
        Try
            Me.Cursor = WaitCursor
            editProducto = New frmSivProductosEditar
            editProducto.TypeGui = 0
            If editProducto.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            editProducto = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim editProducto As frmSivProductosEditar
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdProductosTabla.FocusedRowHandle
           
            Me.Cursor = WaitCursor
            editProducto = New frmSivProductosEditar
            editProducto.TypeGui = 1
            editProducto.ProductoID = Me.DtProductos.DefaultView.Item(FilaActual)("SivProductoID")
            If editProducto.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            editProducto = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim editProducto As frmSivProductosEditar
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdProductosTabla.FocusedRowHandle
            Me.Cursor = WaitCursor
            editProducto = New frmSivProductosEditar
            editProducto.TypeGui = 2
            editProducto.ProductoID = Me.DtProductos.DefaultView.Item(FilaActual)("SivProductoID")
            editProducto.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            editProducto = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub mnuAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAgregar.Click
        Me.cmdAgregar_Click(sender, e)
    End Sub

    Private Sub mnuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar.Click
        Me.cmdEditar_Click(sender, e)
    End Sub

    Private Sub mnuConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultar.Click
        Me.cmdConsultar_Click(sender, e)
    End Sub

    Private Sub mnuRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefrescar.Click
        Me.cmdRefrescar_Click(sender, e)
    End Sub

    Private Sub mnuCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCerrar.Click
        Me.cmdCerrar_Click(sender, e)
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim objRptProducto As rptProducto
        Dim objImpresion As frmOpcionesImpresion
        objImpresion = New frmOpcionesImpresion
        Try
            If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                objRptProducto = New rptProducto
                objRptProducto.DataSource = Me.DtProductos
                Select Case objImpresion.Seleccion
                    Case 1
                        clsProyecto.ImprimirEnPantalla(objRptProducto)
                    Case 2
                        clsProyecto.ImprimirEnImpresora(objRptProducto, True)
                    Case 3
                        clsProyecto.ImprimirEnArchivo(objRptProducto, Me)
                End Select
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objRptProducto = Nothing
            objImpresion = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdDesactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDesactivar.Click
        Dim IDProducto As Integer
        Dim Producto As New SivProductos
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdProductosTabla.FocusedRowHandle
            Select Case MsgBox("¿Está seguro de Inactivar Producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDProducto = Me.DtProductos.DefaultView.Item(FilaActual)("SivProductoID")
                    Producto.Retrieve(IDProducto)
                    Producto.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Producto.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Producto.Activo = False
                    Producto.Update()
                    CargarGrid()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Producto = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region
    
    
   
End Class