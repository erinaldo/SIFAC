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

    ''Usuario Creaci�n: Sergio Ordo�ez
    ''Fecha Creaci�n:   06/03/2009
    ''Descripci�n:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        DtProductos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProductoID,Modelo,Marca,Cilindraje,objSegmentoID,Segmento,Activo", "vwStbProductos", ))
        DtProductos.PrimaryKey = New DataColumn() {Me.DtProductos.Columns("SivProductoID")}
        DtProductos.DefaultView.Sort = "SivProductoID"
        Me.grdProductos.SetDataBinding(DtProductos, "", True)
        Me.grdProductos.Caption = "Productos (" & Me.DtProductos.Rows.Count & ")"
        Me.grdProductos.Refresh()
    End Sub

    ''Usuario Creaci�n: Sergio Ordo�ez
    ''Fecha Creaci�n:   06/03/2009
    ''Descripci�n:      Metodo encargado de aplicar la seguridad al formulario
    Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad

        objSeg.ServicioUsuario = "FRMSTBPRODUCTO"
        objSeg.Usuario = clsProyecto.Conexion.Usuario
        boolAgregar = objSeg.TienePermiso("AGREGARPRODUCTO")
        boolEditar = objSeg.TienePermiso("EDITARPRODUCTO")
        boolConsultar = objSeg.TienePermiso("CONSULTARPRODUCTO")
        boolDesactivar = objSeg.TienePermiso("DESACTIVARPRODUCTO")
        boolImprimir = objSeg.TienePermiso("IMPRIMIRPRODUCTO")

        cmdAgregar.Enabled = boolAgregar
        cmdEditar.Enabled = boolEditar And DtProductos.Rows.Count > 0
        cmdConsultar.Enabled = boolConsultar And DtProductos.Rows.Count > 0
        cmdDesactivar.Enabled = boolDesactivar And DtProductos.Rows.Count > 0
        cmdImprimir.Enabled = boolImprimir And DtProductos.Rows.Count > 0

    End Sub

#End Region

#Region "Eventos del formulario"

    Private Sub frmStbProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
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
                Me.grdProductos.Row = Me.DtProductos.DefaultView.Find(editProducto.intProductoID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim editProducto As frmSivProductosEditar
        Try
            If Me.grdProductos.RowCount = 0 Then
                Exit Sub
            End If
            Me.Cursor = WaitCursor
            editProducto = New frmSivProductosEditar
            editProducto.TypeGui = 1
            editProducto.Text = "Producto " + Me.grdProductos.Columns("Modelo").Value
            editProducto.ProductoID = Me.grdProductos.Columns("SivProductoID").Value
            If editProducto.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                Me.grdProductos.Row = Me.DtProductos.DefaultView.Find(editProducto.intProductoID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim editProducto As frmSivProductosEditar
        Try
            If Me.grdProductos.RowCount = 0 Then
                Exit Sub
            End If
            Me.Cursor = WaitCursor
            editProducto = New frmSivProductosEditar
            editProducto.TypeGui = 2
            editProducto.Text = "Producto " + Me.grdProductos.Columns("Modelo").Value
            editProducto.ProductoID = Me.grdProductos.Columns("SivProductoID").Value
            editProducto.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
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
    End Sub

#End Region
    
    
    Private Sub cmdDesactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDesactivar.Click
        Dim IDProducto As Integer
        Dim Producto As New SivProductos
        If Me.grdProductos.RowCount > 0 Then
            If Me.grdProductos.Columns("Activo").Value = False Then
                Exit Sub
            End If
            Select Case MsgBox("�Est� seguro de Inactivar Producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    IDProducto = Me.grdProductos.Columns("SivProductoID").Value
                    Producto.Retrieve(IDProducto)
                    Producto.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    Producto.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    Producto.Activo = False
                    Producto.Update()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        End If
    End Sub
End Class