Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmStbTiendas

#Region "Declaración de Variables propias del formulario"
    Dim DtTienda As DataTable
    Dim objSeg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolDesactivar, boolImprimir As Boolean
#End Region

#Region "Cargar Grid Principal"

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de cargar los datos de tienda
    Private Sub CargarGrid()
        Try
            Me.DtTienda = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbTiendaID,Nombre,Codigo,Ciudad,objJefeTiendaID,Jefe,Activo,ActivoRepuesto, Telefonos,Moviles,Fax,Direccion,seriefactura, ProximaFactura", "vwStbTienda"))
            Me.DtTienda.PrimaryKey = New DataColumn() {Me.DtTienda.Columns("StbTiendaID")}
            Me.DtTienda.DefaultView.Sort = "StbTiendaID"
            Me.grdTienda.SetDataBinding(Me.DtTienda, "", True)
            Me.grdTienda.Caption = "Sucursales (" & Me.DtTienda.Rows.Count & ")"
            Me.grdTienda.Refresh()
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de Vincular los textbox de informacion de contacto
    Public Sub VincularControles()
        Me.txtDirecciones.DataBindings.Clear()
        Me.txtTelefonos.DataBindings.Clear()
        Me.txtMoviles.DataBindings.Clear()
        Me.txtFacsimiles.DataBindings.Clear()
        Me.txtProximoNumeroFact.DataBindings.Clear()
        Me.txtSerieFactura.DataBindings.Clear()

        Me.txtDirecciones.DataBindings.Add("text", DtTienda, "Direccion", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtTelefonos.DataBindings.Add("text", DtTienda, "Telefonos", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtMoviles.DataBindings.Add("text", DtTienda, "Moviles", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtFacsimiles.DataBindings.Add("text", DtTienda, "Fax", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtProximoNumeroFact.DataBindings.Add("text", DtTienda, "ProximaFactura", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.txtSerieFactura.DataBindings.Add("text", DtTienda, "seriefactura", True, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

#Region "Seguridad"

    '' Autor:              Sergio Ordoñez
    '' Fecha de creación:  26/02/2009
    '' Descripción:        Procedimiento encargado de aplicar la seguridad al formulario
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad

            objSeg.ServicioUsuario = "FRMSTBSUCURSAL"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objSeg.TienePermiso("AGREGARSUCURSAL")
            boolEditar = objSeg.TienePermiso("EDITARSUCURSAL")
            boolConsultar = objSeg.TienePermiso("CONSULTARSUCURSAL")
            boolDesactivar = objSeg.TienePermiso("DESACTIVARSUCURSAL")
            boolImprimir = objSeg.TienePermiso("IMPRIMIRSUCURSAL")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And DtTienda.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And DtTienda.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And DtTienda.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos del formulario"
    Private Sub frmStbTiendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor
            clsProyecto.CargarTemaDefinido(Me)
            Me.CargarGrid()
            Me.VincularControles()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.grdTienda = Nothing
        Me.DtTienda = Nothing
        objSeg = Nothing
        boolAgregar = Nothing
        boolEditar = Nothing
        boolConsultar = Nothing
        boolDesactivar = Nothing
        boolImprimir = Nothing
        Me.Close()
    End Sub

    Private Sub grdTienda_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTienda.FilterChange
        Me.grdTienda.Caption = "Sucursales (" & Me.DtTienda.Rows.Count & ")"
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim editTiendas As frmStbEditTiendas
        Try
            Me.Cursor = WaitCursor
            editTiendas = New frmStbEditTiendas
            editTiendas.TypeGUI = 1
            If editTiendas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                VincularControles()
                Me.grdTienda.Row = Me.DtTienda.DefaultView.Find(editTiendas.TiendaID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim editTiendas As frmStbEditTiendas
        Try
            Me.Cursor = WaitCursor
            editTiendas = New frmStbEditTiendas
            editTiendas.TypeGUI = 2
            editTiendas.TiendaID = Me.grdTienda.Columns("StbTiendaID").Value
            If editTiendas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                VincularControles()
                Me.grdTienda.Row = Me.DtTienda.DefaultView.Find(editTiendas.TiendaID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim editTiendas As frmStbEditTiendas
        Try
            Me.Cursor = WaitCursor
            editTiendas = New frmStbEditTiendas
            editTiendas.TypeGUI = 3
            editTiendas.TiendaID = Me.grdTienda.Columns("StbTiendaID").Value
            editTiendas.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        CargarGrid()
        VincularControles()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim objRptSucursales As rptSucursales
        Dim objImpresion As frmOpcionesImpresion
        objImpresion = New frmOpcionesImpresion
        If objImpresion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            objRptSucursales = New rptSucursales
            objRptSucursales.DataSource = Me.DtTienda
            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(objRptSucursales)
                Case 2
                    clsProyecto.ImprimirEnImpresora(objRptSucursales, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(objRptSucursales, Me)
            End Select
        End If
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

    Private Sub mnuDesactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDesactivar.Click

    End Sub

    Private Sub mnuActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActualizar.Click
        Me.cmdRefrescar_Click(sender, e)
    End Sub

    Private Sub mnuImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImprimir.Click
        Me.cmdImprimir_Click(sender, e)
    End Sub

    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
        Me.cmdSalir_Click(sender, e)
    End Sub

#End Region

End Class