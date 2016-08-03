
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO
Imports System.IO
Imports Proyecto.Catalogos.Datos

''' <summary>
''' Pantalla de Edicion de Catalogo de Repuestos.
''' Autor : Milagros Ruiz Oporta.
''' Fecha : 17 de Mayo de 2010.
''' </summary>
''' <remarks></remarks>
''' 
Public Class frmSivEditRepuestos

#Region "Declaracion de Variables"

    Dim dtProveedor As DataTable
    Dim dtProveedorCombo As DataTable
    Dim dtCausaInactivacion As DataTable
    Dim dtTipoRepuesto As DataTable
    Dim dtMarca As DataTable
    Dim dtCompatibilidad As DataTable
    Dim dtExistenciaBodega As DataTable
    Private m_CantidadMaximaDefecto As Integer
    Private m_CantidadMinimaDefecto As Integer

#End Region

#Region "Propiedades"

    Dim intTypeGui As Integer
    Dim intRepuestosID As String
    Dim boolImagen, m_boolModificado, m_RolGerente As Boolean
    Dim FileName As String

    Public Property RolGerente() As Boolean
        Get
            Return m_RolGerente
        End Get
        Set(ByVal value As Boolean)
            m_RolGerente = value
        End Set
    End Property

    Public Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Public Property RepuestosID() As String
        Get
            Return intRepuestosID
        End Get
        Set(ByVal value As String)
            intRepuestosID = value
        End Set
    End Property
    Public Property boolCambioImages() As Boolean
        Get
            Return boolImagen
        End Get
        Set(ByVal value As Boolean)
            boolImagen = value
        End Set
    End Property

    Property boolModificado() As Boolean
        Get
            boolModificado = m_boolModificado
        End Get
        Set(ByVal value As Boolean)
            m_boolModificado = value
        End Set
    End Property

    Property CantidaMaximaDefecto() As Integer
        Get
            CantidaMaximaDefecto = Me.m_CantidadMaximaDefecto
        End Get
        Set(ByVal value As Integer)
            Me.m_CantidadMaximaDefecto = value
        End Set
    End Property

    Property CantidaMinimaDefecto() As Integer
        Get
            CantidaMinimaDefecto = Me.m_CantidadMinimaDefecto
        End Get
        Set(ByVal value As Integer)
            Me.m_CantidadMinimaDefecto = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Guardar"
    Private Sub GuardarRepuesto(ByVal T As DAL.TransactionManager)
        Dim objRepuesto As SivRepuestos
        Try

            objRepuesto = New SivRepuestos
            objRepuesto.SivRepuestoID = Me.txtCodigo.Text.Trim
            objRepuesto.DescripcionCorta = Me.txtDescripcionCorta.Text.Trim
            objRepuesto.DescripcionEspanol = Me.txtDescripcionEspanol.Text.Trim
            objRepuesto.DescripcionIngles = Me.txtDescripcionIngles.Text.Trim
            objRepuesto.objMarca = Me.cmbMarca.SelectedValue
            objRepuesto.objTipoRepuesto = Me.cmbTipo.SelectedValue

            If Me.cmbCausa.Text.Trim.Length <> 0 Then
                objRepuesto.objCausaInactivacion = Me.cmbCausa.SelectedValue
            End If

            objRepuesto.plazoGarantia = Me.txtPlazo.Text.Trim
            objRepuesto.Precio = Me.numPrecio.Value
            objRepuesto.CostoProm = Me.numCosto.Value
            If Not Me.chkEtiquetarCB.Checked Then
                objRepuesto.CodigoBarras = Me.txtCodigoBarras.Text.Trim
            End If

            objRepuesto.Activo = Me.chkActivo.Checked
            objRepuesto.EtiquetarCB = Me.chkEtiquetarCB.Checked
            objRepuesto.FechaRegistro = Me.dtFecha.Value
            If Not String.IsNullOrEmpty(Me.ArchivoDialogo.FileName) Then
                Try
                    objRepuesto.Imagen = Me.Ficheros(Me.ArchivoDialogo.FileName)
                Catch ex As Exception
                End Try
            End If

            If Not IsDBNull(Me.numCantidadMaxima.Value) Then
                objRepuesto.CantidadMaxima = Me.numCantidadMaxima.Value
            End If
            If Not IsDBNull(Me.numCantidadMinima.Value) Then
                objRepuesto.CantidadMinima = Me.numCantidadMinima.Value
            End If

            objRepuesto.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objRepuesto.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objRepuesto.Insert(T)
            Me.RepuestosID = objRepuesto.SivRepuestoID

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarRepuestosProveedor(ByVal T As DAL.TransactionManager)
        Dim dtDetalleProveedor As New DataTable
        Dim fila As DataRow
        Try
            Try

                'Me.grdProveedor.Refresh()
                dtDetalleProveedor = SivRepuestosDetProv.RetrieveDT("1=0")

                'Me.dtProveedor.AcceptChanges()
                'For I As Integer = 0 To Me.grdProveedor.RowCount - 1 ' row As DataRow In Me.dtProveedor.Rows
                '    fila = dtDetalleProveedor.NewRow
                '    fila("objRepuestoID") = Me.RepuestosID
                '    fila("objProveedorID") = Me.grdProveedor.Item(I)("SivProveedorID") 'row("SivProveedorID")
                '    fila("CodigoRepuesto") = Me.grdProveedor.Item(I)("CodigoRepuesto") 'row("CodigoRepuesto")
                '    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                '    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                '    dtDetalleProveedor.Rows.Add(fila)
                'Next

                'objRepuestoID, CodigoRepuesto, SivProveedorID, NombreProveedor
                Me.dtProveedor.AcceptChanges()
                For Each row As DataRow In Me.dtProveedor.Rows ' row As DataRow In Me.dtProveedor.Rows
                    fila = dtDetalleProveedor.NewRow
                    fila("objRepuestoID") = Me.RepuestosID
                    fila("objProveedorID") = row("SivProveedorID") 'row("SivProveedorID")
                    fila("CodigoRepuesto") = row("CodigoRepuesto") 'row("CodigoRepuesto")
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleProveedor.Rows.Add(fila)
                Next

                dtDetalleProveedor.TableName = "SivRepuestosDetProv"
                SivRepuestosDetProv.BatchUpdate(dtDetalleProveedor.DataSet, T)

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDetalleProveedor = Nothing
        End Try

    End Sub

    Private Sub GuardarRespuestosCompat(ByVal T As DAL.TransactionManager)
        Dim objRepuestosCompat As New SivRepuestosDetCompat

        For Each drwCompat As DataRow In Me.dtCompatibilidad.Rows
            If drwCompat("Seleccion") Then
                objRepuestosCompat.objProductoID = drwCompat("SivProductoID")
                objRepuestosCompat.objRepuestoID = Me.RepuestosID
                objRepuestosCompat.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objRepuestosCompat.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objRepuestosCompat.Insert(T)
            End If
        Next
    End Sub

    Private Sub GuardarBodegaRepuestos(ByVal T As DAL.TransactionManager)
        Dim fila As DataRow
        Dim dtDetalleBodega As New DataTable

        dtDetalleBodega = SivBodegaRepuestos.RetrieveDT("1=0")

        Me.dtExistenciaBodega.AcceptChanges()
        For Each drBodega As DataRow In Me.dtExistenciaBodega.Rows
            fila = dtDetalleBodega.NewRow
            fila("objRepuestoID") = Me.RepuestosID
            fila("objTiendaID") = drBodega("StbTiendaID")
            fila("Ubicacion") = drBodega("Ubicacion")
            fila("Cantidad") = drBodega("Cantidad")
            fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
            fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
            dtDetalleBodega.Rows.Add(fila)
        Next
        dtDetalleBodega.TableName = "SivBodegaRepuestos"
        SivBodegaRepuestos.BatchUpdate(dtDetalleBodega.DataSet, T)

    End Sub

    Private Sub AgregarRepuesto()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            Me.GuardarRepuesto(T)
            Me.GuardarRepuestosProveedor(T)
            Me.GuardarRespuestosCompat(T)
            Me.GuardarBodegaRepuestos(T)
            T.CommitTran()
            Me.boolModificado = False
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Modificar"
    Private Sub EditarRepuesto()
        Dim T As New TransactionManager
        Dim objRepuesto As New SivRepuestos
        Dim dtProveedorExistente, dtProveedorCompatibilidad As New DataTable
        Dim dtDetalleProveedor, dtDetalleBodega As New DataTable
        Dim fila As DataRow
        Try
            Try

                T.BeginTran()

                '--Actualizar Repuestos
                objRepuesto.RetrieveByFilter("SivRepuestoID = '" & Me.RepuestosID & "'")
                objRepuesto.objTipoRepuesto = Me.cmbTipo.SelectedValue
                objRepuesto.objMarca = Me.cmbMarca.SelectedValue
                objRepuesto.DescripcionCorta = Me.txtDescripcionCorta.Text.Trim
                objRepuesto.DescripcionEspanol = Me.txtDescripcionEspanol.Text.Trim
                objRepuesto.DescripcionIngles = Me.txtDescripcionIngles.Text.Trim
                objRepuesto.CodigoBarras = Me.txtCodigoBarras.Text.Trim
                objRepuesto.Activo = Me.chkActivo.Checked
                objRepuesto.EtiquetarCB = Me.chkEtiquetarCB.Checked
                objRepuesto.FechaRegistro = Me.dtFecha.Value
                objRepuesto.plazoGarantia = Me.txtPlazo.Text
                objRepuesto.CostoProm = Me.numCosto.Value
                objRepuesto.Precio = Me.numPrecio.Value
                If Not Me.chkActivo.Checked Then
                    If Not IsDBNull(Me.cmbCausa.SelectedValue) AndAlso Me.cmbCausa.SelectedValue.ToString.Trim.Length <> 0 Then
                        objRepuesto.objCausaInactivacion = Me.cmbCausa.SelectedValue
                    End If
                End If
                If boolCambioImages Then
                    If Not String.IsNullOrEmpty(ArchivoDialogo.FileName) Then
                        objRepuesto.Imagen = Ficheros(ArchivoDialogo.FileName)
                    End If
                End If

                If Not String.IsNullOrEmpty(Me.ArchivoDialogo.FileName) Then
                    Try
                        objRepuesto.Imagen = Me.Ficheros(Me.ArchivoDialogo.FileName)
                    Catch ex As Exception
                    End Try
                End If

                If Not IsDBNull(Me.numCantidadMaxima.Value) Then
                    objRepuesto.CantidadMaxima = Integer.Parse(Me.numCantidadMaxima.Value)
                End If
                If Not IsDBNull(Me.numCantidadMinima.Value) Then
                    objRepuesto.CantidadMinima = Integer.Parse(Me.numCantidadMinima.Value)
                End If

                objRepuesto.Update(T)

                '--Actualizamos los proveedores
                dtDetalleProveedor = SivRepuestosDetProv.RetrieveDT("1=0")
                SivRepuestosDetProv.DeleteByFilter("objRepuestoID = '" & Me.RepuestosID & "'", T)

                Me.dtProveedor.AcceptChanges()
                For Each row As DataRow In Me.dtProveedor.Rows
                    fila = dtDetalleProveedor.NewRow
                    fila("objRepuestoID") = Me.RepuestosID
                    fila("objProveedorID") = row("SivProveedorID")
                    fila("CodigoRepuesto") = row("CodigoRepuesto")
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleProveedor.Rows.Add(fila)

                Next
                dtDetalleProveedor.TableName = "SivRepuestosDetProv"
                SivRepuestosDetProv.BatchUpdate(dtDetalleProveedor.DataSet, T)

                '---- Actualizar Compatibilidad
                Me.ActualizarDatosCompatibilidad(T)

                'Me.dtCompatibilidad.AcceptChanges()
                'dtProveedorCompatibilidad = SivRepuestosDetCompat.RetrieveDT("objRepuestoID = " & Me.RepuestosID, , "objProductoID")

                'For Each drCompatiblidad As DataRow In Me.dtCompatibilidad.Rows
                '    If Not drCompatiblidad("Seleccion") Then
                '        '--En el caso de que el producto fue quitado entonces eliminamos el registro
                '        dtProveedorCompatibilidad.DefaultView.RowFilter = "objProductoID = " & drCompatiblidad("SivProductoID")
                '        If dtProveedorCompatibilidad.DefaultView.Count > 0 Then
                '            SivRepuestosDetCompat.DeleteByFilter("objRepuestoID = " & Me.RepuestosID & " AND objProductoID = " & drCompatiblidad("SivProductoID"), T)
                '        End If
                '    End If
                'Next

                '--Actualizamos bodega
                dtDetalleBodega = SivBodegaRepuestos.RetrieveDT("1=0")
                SivBodegaRepuestos.DeleteByFilter("objRepuestoID = '" & Me.RepuestosID & "'")

                Me.dtExistenciaBodega.AcceptChanges()
                For Each drBodega As DataRow In Me.dtExistenciaBodega.Rows
                    fila = dtDetalleBodega.NewRow
                    fila("objRepuestoID") = Me.RepuestosID
                    fila("objTiendaID") = drBodega("StbTiendaID")
                    fila("Ubicacion") = drBodega("Ubicacion")
                    fila("Cantidad") = drBodega("Cantidad")
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleBodega.Rows.Add(fila)
                Next
                dtDetalleBodega.TableName = "SivBodegaRepuestos"
                SivBodegaRepuestos.BatchUpdate(dtDetalleBodega.DataSet, T)

                T.CommitTran()
                Me.boolModificado = False
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDetalleProveedor = Nothing
            objRepuesto = Nothing
            dtProveedorExistente = Nothing
            dtProveedorCompatibilidad = Nothing
            dtDetalleProveedor = Nothing
            dtDetalleBodega = Nothing
            T = Nothing
        End Try
    End Sub
#End Region

#Region "Actualizar Compatibilidad"
    Private Function ActualizarDatosCompatibilidad(ByVal T As TransactionManager) As Boolean
        Dim blnActualizada As Boolean = False
        Dim dtlocalCompatibilidad As DataTable
        Dim fila As DataRow
        Try
            'Obtener estructura de tabla 
            dtlocalCompatibilidad = SivRepuestosDetCompat.RetrieveDT("1=0", , "objRepuestoID, objProductoID, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion", T)
            SivRepuestosDetCompat.DeleteByFilter("objRepuestoID='" + Me.RepuestosID.ToString & "'", T)

            ' ------ Registrar modelos ------------------
            'Isertar los modelos con los que el repuesto es compatible
            Me.dtCompatibilidad.AcceptChanges()
            For Each row As DataRow In Me.dtCompatibilidad.Rows
                fila = dtlocalCompatibilidad.NewRow
                If Not IsDBNull(row("Seleccion")) Then
                    If Convert.ToBoolean(row("Seleccion")) Then
                        fila("objRepuestoID") = Me.RepuestosID
                        fila("objProductoID") = row("SivProductoID")
                        fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        fila("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                        fila("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                        dtlocalCompatibilidad.Rows.Add(fila)
                    End If
                End If
            Next
            If dtlocalCompatibilidad.Rows.Count <> 0 Then
                dtlocalCompatibilidad.TableName = "SivRepuestosDetCompat"
                SivRepuestosDetCompat.BatchUpdate(dtlocalCompatibilidad.DataSet, T)
            End If
            blnActualizada = True

        Catch ex As Exception
            clsError.CaptarError(ex)
            blnActualizada = False
        Finally
            dtlocalCompatibilidad = Nothing
            fila = Nothing
        End Try

        Return blnActualizada
    End Function
#End Region

#Region "Configurar Grid"
    Public Sub ConfigurarGUI()
        If Me.RolGerente Then
            Me.numPrecio.Enabled = True
            Me.numCosto.Enabled = True
        Else
            Me.numPrecio.Enabled = False
            Me.lblCostoPromedio.Visible = False
            Me.numCosto.Visible = False
        End If

        'Asignar cantidad mínima y máxima
        Try
            Dim Valor As Integer
            Valor = Integer.Parse(ClsCatalogos.GetValorParametro("CantidadMaximaDefecto"))
            Me.CantidaMaximaDefecto = Valor
        Catch
            Me.CantidaMaximaDefecto = Integer.MaxValue
        End Try
        Try
            Dim Valor As Integer
            Valor = Integer.Parse(ClsCatalogos.GetValorParametro("CantidadMinimaDefecto"))
            Me.CantidaMinimaDefecto = Valor
        Catch
            Me.CantidaMinimaDefecto = 0
        End Try

        Me.grdBodegas.Splits(0).DisplayColumns("StbTiendaID").Visible = False
        Me.grdBodegas.Splits(0).DisplayColumns("Cantidad").Locked = True

        Select Case Me.TypeGui
            Case 0
                Me.Text = "Nuevo Repuesto"
                Me.CargarProveedor("1=0")
                Me.CargarComboProveedor()
                Me.grdProveedor.Splits(0).DisplayColumns(2).Visible = False
                Me.grdProveedor.EmptyRows = False
                Me.grdProveedor.FilterBar = False
                Me.grdProveedor.Refresh()

                Me.CargarCompatibilidad()
                Me.grdCompatibilidad.EmptyRows = False
                Me.grdCompatibilidad.FilterBar = False
                Me.grdCompatibilidad.Splits(0).DisplayColumns(3).Visible = False
                Me.grdCompatibilidad.Refresh()

                Me.CargarExistencia()
                Me.grdBodegas.EmptyRows = False
                Me.grdBodegas.FilterBar = False
                Me.grdBodegas.Refresh()
                Me.dtFecha.Value = clsProyecto.Conexion.FechaServidor
                Me.cmbCausa.Text = ""
                Me.cmbMarca.Text = ""
                Me.cmbTipo.Text = ""
                Me.cmbCausa.Enabled = False
                Me.numCantidadMaxima.Value = Me.CantidaMaximaDefecto
                Me.numCantidadMinima.Value = Me.CantidaMinimaDefecto
                Me.txtCodigo.Focus()

            Case 1
                Me.Text = "Editar Repuesto"
                CargarRepuestos()
                Me.CargarProveedor("objRepuestoID = '" & Me.RepuestosID & "'")
                Me.CargarComboProveedor()
                Me.grdProveedor.Splits(0).DisplayColumns(2).Visible = False
                Me.grdProveedor.EmptyRows = False
                Me.grdProveedor.FilterBar = False
                Me.grdProveedor.Refresh()
                Me.CargarCompatibilidadEditar()
                Me.grdCompatibilidad.EmptyRows = False
                Me.grdCompatibilidad.FilterBar = False
                Me.grdCompatibilidad.Splits(0).DisplayColumns(3).Visible = False
                Me.grdCompatibilidad.Refresh()
                CargarExistenciaEditar()
                Me.grdBodegas.EmptyRows = False
                Me.grdBodegas.FilterBar = False
                Me.grdBodegas.Refresh()
                Me.cmbCausa.Enabled = True
                Me.dtFecha.Enabled = False
                Me.cmbCausa.Enabled = True
                Me.chkActivo.Enabled = True
                Me.txtCodigo.Enabled = False

                'Deshabilitar compatibilidad para los tres primeros repuestos
                Select Case Me.RepuestosID
                    Case 1, 2, 3
                        Me.DeshabilitarControles()
                        Me.FormatearGridConsulta()
                        If Me.RolGerente Then
                            Me.numPrecio.Enabled = True
                            Me.cmdAceptar.Enabled = True
                        End If
                End Select
            Case 2
                Me.Text = "Consultar Repuesto"
                Me.CargarRepuestos()
                Me.CargarProveedor("objRepuestoID = '" & Me.RepuestosID & "'")

                'Cargar datos de los grid
                Me.CargarComboProveedor()
                Me.CargarCompatibilidadEditar()
                Me.CargarExistenciaEditar()
                Me.DeshabilitarControles()
                'Formatea los grid para sólo consulta
                Me.FormatearGridConsulta()
        End Select
    End Sub

#End Region

    Private Sub DeshabilitarControles()
        Me.txtCodigoBarras.Enabled = False
        Me.txtDescripcionCorta.Enabled = False
        Me.txtDescripcionEspanol.Enabled = False
        Me.txtDescripcionIngles.Enabled = False
        Me.txtPlazo.Enabled = False
        Me.numPrecio.Enabled = False
        Me.numCosto.Enabled = False
        Me.cmbMarca.Enabled = False
        Me.cmbTipo.Enabled = False
        Me.cmbCausa.Enabled = False

        Me.cmdcambiarfotos.Enabled = False
        Me.cmdAceptar.Enabled = False
        Me.dtFecha.Enabled = False
        Me.chkEtiquetarCB.Enabled = False
        Me.numCantidadMaxima.Enabled = False
        Me.numCantidadMinima.Enabled = False
        Me.chkTodos.Enabled = False
        Me.chkActivo.Enabled = False
    End Sub

#Region "Formatear Grids para consulta"
    Private Sub FormatearGridConsulta()
        'Grid de proveedores
        With Me.grdProveedor
            .Splits(0).DisplayColumns("SivProveedorID").Visible = False
            .Splits(0).DisplayColumns("CodigoRepuesto").Locked = True
            .Splits(0).DisplayColumns("SivProveedorID").Button = False
            .Splits(0).DisplayColumns("SivProveedorID").AutoDropDown = False
            .Splits(0).DisplayColumns("NombreProveedor").Style.BackColor = Me.grdCompatibilidad.Splits(0).DisplayColumns("Modelo").Style.BackColor
            .Splits(0).DisplayColumns("CodigoRepuesto").Style.BackColor = Me.grdCompatibilidad.Splits(0).DisplayColumns("Modelo").Style.BackColor
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
            .EmptyRows = False
            .FilterBar = False
            .AllowDelete = False
            .AllowFilter = False
            .AllowSort = False
            .AllowUpdate = False
            .RecordSelectors = False
            .Refresh()
        End With
        
        'Grid compatibilidad
        With Me.grdCompatibilidad
            .Splits(0).DisplayColumns("SivProductoID").Visible = False
            .Splits(0).DisplayColumns("Seleccion").Locked = True
            .Splits(0).DisplayColumns("Seleccion").Style.BackColor = Me.grdCompatibilidad.Splits(0).DisplayColumns("Modelo").Style.BackColor
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
            .EmptyRows = False
            .FilterBar = False
            .AllowDelete = False
            .AllowFilter = False
            .AllowSort = False
            .AllowUpdate = False
            .RecordSelectors = False
            .Refresh()
        End With
        
        'Grid Bedegas
        With Me.grdBodegas
            .Splits(0).DisplayColumns("Ubicacion").Locked = True
            .Splits(0).DisplayColumns("Ubicacion").Style.BackColor = Me.grdCompatibilidad.Splits(0).DisplayColumns("Modelo").Style.BackColor
            .Splits(0).DisplayColumns("StbTiendaID").Visible = False
            .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
            .EmptyRows = False
            .FilterBar = False
            .AllowDelete = False
            .AllowFilter = False
            .AllowSort = False
            .AllowUpdate = False
            .RecordSelectors = False
            .Refresh()
        End With
    End Sub

#End Region

#Region "Cargar Datos a Editar"
    Private Sub CargarRepuestos()
        Dim objSivRepuestos As New SivRepuestos
        Try
            objSivRepuestos.RetrieveByFilter("SivRepuestoID = '" & Me.RepuestosID & "'")
            Me.txtCodigo.Text = objSivRepuestos.SivRepuestoID
            Me.cmbTipo.SelectedValue = objSivRepuestos.objTipoRepuesto
            Me.cmbMarca.SelectedValue = objSivRepuestos.objMarca
            Me.txtDescripcionCorta.Text = objSivRepuestos.DescripcionCorta

            If Not IsDBNull(objSivRepuestos.DescripcionEspanol) Then
                Me.txtDescripcionEspanol.Text = objSivRepuestos.DescripcionEspanol
            End If
            If Not IsDBNull(objSivRepuestos.DescripcionIngles) Then
                Me.txtDescripcionIngles.Text = objSivRepuestos.DescripcionIngles
            End If
            If Not IsDBNull(objSivRepuestos.CodigoBarras) Then
                Me.txtCodigoBarras.Text = objSivRepuestos.CodigoBarras
            End If

            Me.chkActivo.Checked = objSivRepuestos.Activo
            Me.chkEtiquetarCB.Checked = objSivRepuestos.EtiquetarCB
            Me.dtFecha.Value = objSivRepuestos.FechaRegistro
            Me.txtPlazo.Text = objSivRepuestos.plazoGarantia

            If objSivRepuestos.objCausaInactivacion.ToString <> "" Then
                Me.cmbCausa.SelectedValue = objSivRepuestos.objCausaInactivacion
            End If
           
            Me.numCosto.Value = objSivRepuestos.CostoProm
            Me.numPrecio.Value = objSivRepuestos.Precio

            If Not IsDBNull(objSivRepuestos.Imagen) Then
                Me.PicFoto.Image = BytesImagen(objSivRepuestos.Imagen)
            End If

            If objSivRepuestos.CantidadMinima.HasValue Then
                Me.numCantidadMinima.Value = objSivRepuestos.CantidadMinima
            Else
                Me.numCantidadMinima.Value = 0
            End If

            If objSivRepuestos.CantidadMaxima.HasValue Then
                Me.numCantidadMaxima.Value = objSivRepuestos.CantidadMaxima
            Else
                Me.numCantidadMaxima.Value = Me.CantidaMaximaDefecto
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarCompatibilidadEditar()
        dtCompatibilidad = New DataTable
        Dim sCampos, sSQL As String
        sCampos = "Habilitado as Seleccion, Modelo, SivProductoID, Cilindraje"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "fnGetModelosCompatiblesEstado('" + Me.RepuestosID.ToString + "')")
        Try
            'dtCompatibilidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccion, Modelo, SivProductoID, Cilindraje,objRepuestoID", "vwSivCompatibilidadRepuestos", "objRepuestoID=" & Me.RepuestosID))
            dtCompatibilidad = DAL.SqlHelper.ExecuteQueryDT(sSQL)

            Me.grdCompatibilidad.SetDataBinding(dtCompatibilidad, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarExistenciaEditar()
        dtExistenciaBodega = New DataTable
        Try
            dtExistenciaBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbTiendaID, Nombre, Ubicacion, Cantidad, objRepuestoID", "vwSivBodegaRepuesto", "objRepuestoID = '" & Me.RepuestosID & "'"))
            Me.grdBodegas.SetDataBinding(dtExistenciaBodega, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Manejar Imagen"

    Private Function Ficheros(ByVal SRuta As String) As Byte()
        Dim fs As System.IO.FileStream
        fs = New FileStream(SRuta, FileMode.Open, FileAccess.Read, FileShare.Read)
        Dim Datos(fs.Length) As Byte
        fs.Read(Datos, 0, Convert.ToInt32(fs.Length))
        Return Datos
    End Function

    Public Shared Function BytesImagen(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function
#End Region

#Region "Cargar Grids"

    Private Sub CargarProveedor(ByVal strFiltro As String)
        'dtProveedor = New DataTable
        Dim sSQL As String

        Try
            sSQL = ObtenerConsultaGeneral("objRepuestoID,CodigoRepuesto, SivProveedorID, NombreProveedor", "vwSivProveedorRepuestos", strFiltro)

            Me.dtProveedor = DAL.SqlHelper.ExecuteQueryDT(sSQL)
            Me.grdProveedor.SetDataBinding(Me.dtProveedor, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarComboProveedor()
        dtProveedorCombo = New DataTable
        Try
            dtProveedorCombo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProveedorID,NombreProveedor", "vwProveedor_Repuesto", "1=1"))
            With CtdbProveedor
                .DataSource = Me.dtProveedorCombo
                .DisplayMember = "NombreProveedor"
                .ValueMember = "SivProveedorID"
                .DisplayColumns("SivProveedorID").Visible = False
                .ValueTranslate = True
                .ExtendRightColumn = True
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub CargarCompatibilidad()
        dtCompatibilidad = New DataTable
        Try
            dtCompatibilidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccion, Modelo, SivProductoID, Descripcion as Cilindraje", "vwSivProductoRepuestos", "1=1"))
            Me.grdCompatibilidad.SetDataBinding(dtCompatibilidad, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarExistencia()
        dtExistenciaBodega = New DataTable
        Try
            dtExistenciaBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbTiendaID, Nombre, cast ('' as varchar(100)) as Ubicacion, cast ('' as integer) as Cantidad", "StbTienda", "ActivoRepuesto=1 "))
            Me.grdBodegas.SetDataBinding(dtExistenciaBodega, "", True)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Combos"
    Private Sub CargarMarca()
        dtMarca = New DataTable
        Try
            dtMarca = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MARCAREPUESTO') ORDER BY Descripcion"))
            Me.cmbMarca.DataSource = dtMarca
            Me.cmbMarca.DisplayMember = "Descripcion"
            Me.cmbMarca.ValueMember = "StbValorCatalogoID"
            Me.cmbMarca.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbMarca.ExtendRightColumn = True
            Me.cmbMarca.SelectedIndex = 0
            Me.cmbMarca.ColumnHeaders = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub CargarTipoRepuesto()
        dtTipoRepuesto = New DataTable
        Try
            dtTipoRepuesto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOREPUESTO') ORDER BY Descripcion"))
            Me.cmbTipo.DataSource = dtTipoRepuesto
            Me.cmbTipo.DisplayMember = "Descripcion"
            Me.cmbTipo.ValueMember = "StbValorCatalogoID"
            Me.cmbTipo.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipo.ExtendRightColumn = True
            Me.cmbTipo.ColumnHeaders = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub CargarCausaInactivacion()
        dtCausaInactivacion = New DataTable
        Try
            dtCausaInactivacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='CAUSAINACTIVACIONREPUESTO') ORDER BY Descripcion"))
            Me.cmbCausa.DataSource = dtCausaInactivacion
            Me.cmbCausa.DisplayMember = "Descripcion"
            Me.cmbCausa.ValueMember = "StbValorCatalogoID"
            Me.cmbCausa.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbCausa.ExtendRightColumn = True
            Me.cmbCausa.SelectedIndex = 0
            Me.cmbCausa.ColumnHeaders = False

            dtCausaInactivacion.Rows.Add("0", "")
            Me.cmbCausa.SelectedValue = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Establecer propiedades"

    Public Sub EstablecerPropiedades()
        Me.txtDescripcionCorta.MaxLength = SivRepuestos.GetMaxLength("DescripcionCorta")
        Me.txtDescripcionEspanol.MaxLength = SivRepuestos.GetMaxLength("DescripcionEspanol")
        Me.txtDescripcionIngles.MaxLength = SivRepuestos.GetMaxLength("DescripcionIngles")
        Me.txtPlazo.MaxLength = SivRepuestos.GetMaxLength("plazoGarantia")
        Me.txtCodigoBarras.MaxLength = SivRepuestos.GetMaxLength("CodigoBarras")
        Me.numCosto.MaxLength = SivRepuestos.GetMaxLength("CostoProm")
        Me.numPrecio.MaxLength = SivRepuestos.GetMaxLength("Precio")
        Me.txtCodigo.MaxLength = SivRepuestos.GetMaxLength("SivRepuestoID")
    End Sub

#End Region

#Region "Validaciones"

    Public Function ValidarSiExiste(ByVal strcodigo As String) As Boolean
        Dim dtIDRepuesto As New DataTable

        dtIDRepuesto = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SivRepuestoID", "SivRepuestos", "SivRepuestoID = '" & strcodigo & "'"))

        If dtIDRepuesto.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function ValidarEntrada() As Boolean

        If Me.txtCodigo.Text.Trim.Length = 0 Then
            Me.ErrorRepuesto.SetError(Me.txtCodigo, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.ValidarSiExiste(Me.txtCodigo.Text) Then
            Me.ErrorRepuesto.SetError(Me.txtCodigo, "El código no puede repetirse.")
            Return False
            Exit Function
        End If

        If txtDescripcionCorta.Text.Trim.Length = 0 Then
            Me.ErrorRepuesto.SetError(txtDescripcionCorta, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If Me.txtPlazo.Text.Trim.Length = 0 Then
            ErrorRepuesto.SetError(txtPlazo, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        If Me.numPrecio.Text.Trim.Length = 0 Then
            ErrorRepuesto.SetError(numPrecio, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.numCosto.Text.Trim.Length = 0 Then
            ErrorRepuesto.SetError(numCosto, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If
        'If Me.cmbCausa.Text.Trim = "" Then
        '    ErrorRepuesto.SetError(cmbCausa, My.Resources.MsgObligatorio)
        '    Return False
        '    Exit Function
        'End If

        If Me.cmbTipo.Text.Trim = "" Then
            ErrorRepuesto.SetError(cmbTipo, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.cmbMarca.Text.Trim = "" Then
            ErrorRepuesto.SetError(cmbMarca, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If String.IsNullOrEmpty(Me.numCantidadMaxima.Text.Trim) Then
            Me.numCantidadMaxima.Value = Me.CantidaMaximaDefecto
        Else
            If Me.numCantidadMaxima.Value = 0 Then
                ErrorRepuesto.SetError(Me.numCantidadMaxima, "Cantidad Máxima no pude contener un valor cero.")
                Return False
                Exit Function
            End If
        End If

        '  Me.dtProveedor.AcceptChanges()
        If Me.grdProveedor.RowCount = 0 Then
            MsgBox("Seleccione al menos un Proveedor", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Return False
            Exit Function
        End If

        'Verificar que no sea repuesto 1,2,3
        If String.IsNullOrEmpty(Me.RepuestosID) And (Not Me.chkActivo.Checked) Then
            Select Case RepuestosID
                Case "1", "2", "3"
                    MsgBox("Los Repuestos con códigos (1,2,3) no pueden desactivarse", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                Case Else
                    If String.IsNullOrEmpty(Me.cmbCausa.Text.Trim) Then
                        MsgBox("Al desactivar un repuesto, debe indicar Causa de inactivación.", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                        Me.cmbCausa.Focus()
                        Return False
                        Exit Function
                    End If
            End Select
        End If


        Return True
    End Function

    Private Function VerificarCodigoExiste(ByVal intCodigo As Integer) As Boolean
        Dim intContador As Integer = 0
        For I As Integer = 0 To Me.grdProveedor.RowCount - 1
            If Me.grdProveedor.Item(I)("SivProveedorID") = intCodigo Then
                intContador = intContador + 1
            End If
        Next
        If intContador > 1 Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub grdProveedor_AfterColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdProveedor.AfterColEdit
        'If IsDBNull(Me.grdProveedor.Columns("SivProveedorID").Value) Then
        '    Me.grdProveedor.Columns("SivProveedorID").Value = 0
        'ElseIf Me.grdProveedor.Columns("SivProveedorID").Value < 0 Then
        '    Me.grdProveedor.Columns("SivProveedorID").Value = 0
        '    Exit Sub
        'ElseIf Not Me.VerificarCodigoExiste(grdProveedor.Columns("SivProveedorID").Value) Then
        '    MsgBox("El proveedor ya existe.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
        '    Me.grdProveedor.Delete(Me.grdProveedor.Row)
        'End If
    End Sub
#End Region

#End Region

#Region "Eventos"

#Region "Formulario"

    Private Sub frmStbEditRepuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarMarca()
        Me.CargarTipoRepuesto()
        Me.CargarCausaInactivacion()
        Me.boolCambioImages = False
        Me.ConfigurarGUI()
        boolModificado = False
    End Sub

#End Region

#Region "Botones"
    Private Sub cmdcambiarfotos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcambiarfotos.Click
        Me.ArchivoDialogo.FileName = "FotoRepuesto"
        If Me.ArchivoDialogo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim FileName As String = ArchivoDialogo.FileName
            Dim Foto As Bitmap
            Try
                Foto = New Bitmap(FileName, True)
                Me.PicFoto.Image = Foto
                Me.boolCambioImages = True
                boolModificado = True
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.ValidarEntrada Then
            Select Case Me.TypeGui
                Case 0
                    Me.AgregarRepuesto()
                Case 1
                    Me.EditarRepuesto()
            End Select
        End If
    End Sub
#End Region

#Region "Grid"
    Private Sub grdCompatibilidad_AfterColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdCompatibilidad.AfterColEdit
        Select Case Me.grdCompatibilidad.Columns("Seleccion").Value
            Case True
                Me.dtCompatibilidad.DefaultView.Item(Me.grdCompatibilidad.Row)("Seleccion") = True
            Case False
                Me.dtCompatibilidad.DefaultView.Item(Me.grdCompatibilidad.Row)("Seleccion") = False
        End Select
        Me.dtCompatibilidad.AcceptChanges()
    End Sub
    Private Sub grdProveedor_Error(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ErrorEventArgs) Handles grdProveedor.Error
        e.Handled = True
        e.Continue = True
    End Sub

    Private Sub grdProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdProveedor.KeyDown
        If Me.TypeGui <> 2 Then
            If e.KeyValue = Keys.Delete And Not (Me.grdProveedor.EditActive) Then
                Me.grdProveedor.Delete(Me.grdProveedor.Row)
                Me.grdProveedor.UpdateData()
            End If
        End If
    End Sub
#End Region

#Region "Cajas de texto"

    Private Sub txtDescripcionCorta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionCorta.TextChanged
        ErrorRepuesto.SetError(txtDescripcionCorta, "")
        boolModificado = True
    End Sub

    Private Sub txtPlazo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlazo.TextChanged
        ErrorRepuesto.SetError(txtPlazo, "")
        Me.boolModificado = True
    End Sub

    Private Sub numCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCosto.TextChanged
        ErrorRepuesto.SetError(numCosto, "")
        Me.boolModificado = True

    End Sub

    Private Sub numPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numPrecio.TextChanged
        ErrorRepuesto.SetError(numPrecio, "")
        Me.boolModificado = True

    End Sub

    Private Sub cmbTipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.TextChanged
        ErrorRepuesto.SetError(cmbTipo, "")
        Me.boolModificado = True
    End Sub

    Private Sub cmbMarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.TextChanged
        ErrorRepuesto.SetError(cmbMarca, "")
        Me.boolModificado = True
    End Sub

    Private Sub cmbCausa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCausa.TextChanged
        ErrorRepuesto.SetError(cmbCausa, "")
        Me.boolModificado = True
    End Sub

    Private Sub cmbTipo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbTipo.Text.Trim.Length <> 0 Then
                Me.cmbMarca.Focus()
            End If
        End If
    End Sub

    Private Sub cmbMarca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.cmbMarca.Text.Trim.Length <> 0 Then
                Me.txtDescripcionCorta.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescripcionCorta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionCorta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtDescripcionCorta.Text.Trim.Length <> 0 Then
                Me.txtDescripcionEspanol.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescripcionEspanol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionEspanol.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtDescripcionEspanol.Text.Trim.Length <> 0 Then
                Me.txtDescripcionIngles.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescripcionIngles_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionIngles.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtDescripcionIngles.Text.Trim.Length <> 0 Then
                Me.numCantidadMinima.Focus()
            End If
        End If
    End Sub

    Private Sub txtCodigoBarras_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtCodigoBarras.Text.Trim.Length <> 0 Then
                Me.txtPlazo.Focus()
            End If
        End If
    End Sub

    Private Sub txtPlazo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlazo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtPlazo.Text.Trim.Length <> 0 Then
                Me.cmbCausa.Focus()
            End If
        End If
    End Sub

    Private Sub cmbCausa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCausa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.numCosto.Enabled Then
                If Me.cmbCausa.Text.Trim.Length <> 0 Then
                    Me.numCosto.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub numCosto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numCosto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.numPrecio.Enabled Then
                If Me.numCosto.Text.Trim.Length <> 0 Then
                    Me.numPrecio.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub frmSivEditRepuestos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.boolModificado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

   
    Private Sub grdProveedor_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdProveedor.Change
        Me.boolModificado = True
    End Sub

    Private Sub txtDescripcionEspanol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionEspanol.TextChanged
        boolModificado = True
    End Sub

    Private Sub txtDescripcionIngles_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionIngles.TextChanged
        boolModificado = True
    End Sub

    Private Sub txtCodigoBarras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoBarras.TextChanged
        boolModificado = True
    End Sub

    Private Sub grdProveedor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdProveedor.Leave
        Me.grdProveedor.UpdateData()
    End Sub

    Private Sub txtPlazo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlazo.Validating
        Try
            Integer.Parse(Me.txtPlazo.Value)
        Catch ex As Exception
            Me.txtPlazo.Value = 0
        End Try
    End Sub

    Private Sub numCantidadMinima_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            Integer.Parse(Me.numCantidadMinima.Value)
            If Me.numCantidadMinima.Value < 0 Then
                Me.numCantidadMinima.Value = 0
            End If
        Catch ex As Exception
            Me.numCantidadMinima.Value = 0
        End Try
    End Sub

    Private Sub numCantidadMaxima_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            Integer.Parse(Me.numCantidadMaxima.Value)
            If Me.numCantidadMaxima.Value < 0 Then
                Me.numCantidadMaxima.Value = 0
            End If
        Catch ex As Exception
            Me.numCantidadMaxima.Value = 0
        End Try
    End Sub

    Private Sub numCantidadMaxima_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorRepuesto.Clear()
    End Sub

    Private Sub numCantidadMinima_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Me.numCantidadMinima.Enabled Then
                If Me.numCantidadMinima.Text.Trim.Length <> 0 Then
                    Me.numCantidadMaxima.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub numCantidadMaxima_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Me.numCantidadMaxima.Text.Trim.Length <> 0 Then
                If Me.txtCodigoBarras.Enabled Then
                    Me.txtCodigoBarras.Focus()
                Else
                    Me.txtPlazo.Focus()
                End If
            End If
        End If
    End Sub

#End Region

#End Region

#Region "Seleccionar Todos los modelos"
    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        Me.SeleccionarTodosModelos(Me.chkTodos.Checked)
        Me.ErrorRepuesto.Clear()
    End Sub

    Private Sub SeleccionarTodosModelos(ByVal blnValor As Boolean)
        For Each fila As DataRow In Me.dtCompatibilidad.Rows
            fila("Seleccion") = blnValor
        Next
        Me.dtCompatibilidad.AcceptChanges()
    End Sub
#End Region

    Private Sub chkEtiquetarCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEtiquetarCB.CheckedChanged
        Me.txtCodigoBarras.Enabled = Not Me.chkEtiquetarCB.Checked

        If Not Me.txtCodigoBarras.Enabled Then
            'Me.txtCodigoBarras.Text = String.Empty
            Me.txtCodigoBarras.BackColor = Color.LightGoldenrodYellow
        Else
            Me.txtCodigoBarras.BackColor = Color.White
        End If
    End Sub

    Private Sub frmSivEditRepuestos_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.txtCodigo.Focus()
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        Me.ErrorRepuesto.SetError(Me.txtCodigo, "")
    End Sub
End Class