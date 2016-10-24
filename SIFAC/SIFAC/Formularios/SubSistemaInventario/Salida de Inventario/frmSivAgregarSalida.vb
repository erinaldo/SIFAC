Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.Cursors
Imports SIFAC.BO
Imports SIFAC.BO.clsConsultas
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmSivAgregarSalida

#Region "Declaracion de variables"
    Dim dtBodega, dtTipoSalida, dtTipoAjuste, dtDetalle, dtRepuestoCombo As DataTable
    Dim boolModificado As Boolean
    Dim intTypeGui, intSalidaID As Integer
    Dim m_boolModificado As Boolean
    Dim boolExisteErroresGrid As Boolean
    Private m_SucursalSessionID As Integer
    Private m_SucursalCentralID As Integer
    Private m_TipoSalidaGarantiaID As Integer
    Private m_StaServicioTallerID As Integer
    Private EstadoSalidaAutorizadaID As Integer
    Private EstadoSalidaRegistradaID As Integer
    Private EstadoSalidaAnuladaID As Integer

#End Region

#Region "Propiedades"
    
    Public Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Public Property SalidaID() As Integer
        Get
            Return intSalidaID
        End Get
        Set(ByVal value As Integer)
            intSalidaID = value
        End Set
    End Property

    Property SucursalSessionID() As Integer
        Get
            SucursalSessionID = Me.m_SucursalSessionID
        End Get
        Set(ByVal value As Integer)
            Me.m_SucursalSessionID = value
        End Set
    End Property

    Property SucursalCentralID() As Integer
        Get
            SucursalCentralID = Me.m_SucursalCentralID
        End Get
        Set(ByVal value As Integer)
            Me.m_SucursalCentralID = value
        End Set
    End Property

    Property TipoSalidaGarantiaID() As Integer
        Get
            TipoSalidaGarantiaID = Me.m_TipoSalidaGarantiaID
        End Get
        Set(ByVal value As Integer)
            Me.m_TipoSalidaGarantiaID = value
        End Set
    End Property

    Property StaServicioTallerID() As Integer
        Get
            StaServicioTallerID = Me.m_StaServicioTallerID
        End Get
        Set(ByVal value As Integer)
            Me.m_StaServicioTallerID = value
        End Set
    End Property

#End Region

#Region "Cargar combos"
    Private Sub CargarBodega()
        Try
            dtBodega = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbBodegaID, Codigo, Nombre", "StbBodegas", "Activo = 1 Order by Nombre"))
            Me.cmbBodega.DataSource = dtBodega
            Me.cmbBodega.DisplayMember = "Nombre"
            Me.cmbBodega.ValueMember = "StbBodegaID"
            Me.cmbBodega.Splits(0).DisplayColumns("StbBodegaID").Visible = False
            Me.cmbBodega.Splits(0).DisplayColumns("StbBodegaID").Width = 40
            Me.cmbBodega.ExtendRightColumn = True
            Me.cmbBodega.SelectedIndex = 0
            Me.cmbBodega.Text = ""
            Me.cmbBodega.ColumnHeaders = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarTipoSalida()
        dtTipoSalida = New DataTable
        Try
            dtTipoSalida = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOSALIDA')"))
            Me.cmbTipoSalida.DataSource = dtTipoSalida
            Me.cmbTipoSalida.DisplayMember = "Descripcion"
            Me.cmbTipoSalida.ValueMember = "StbValorCatalogoID"
            Me.cmbTipoSalida.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipoSalida.ExtendRightColumn = True
            Me.cmbTipoSalida.SelectedIndex = 0
            Me.cmbTipoSalida.Text = ""
            Me.cmbTipoSalida.ColumnHeaders = False

            'Cargar Identificador de tipo de servicio de garantía para las solicitudes de descuento en servicio taller.
            Me.TipoSalidaGarantiaID = ClsCatalogos.GetValorCatalogoID("TIPOSALIDA", "04") '04=GARANTÍA

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarTipoAjuste()
        dtTipoAjuste = New DataTable
        Try
            dtTipoAjuste = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID = (SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre = 'TIPOAJUSTE')"))
            Me.cmbAjuste.DataSource = dtTipoAjuste
            Me.cmbAjuste.DisplayMember = "Descripcion"
            Me.cmbAjuste.ValueMember = "StbValorCatalogoID"
            Me.cmbAjuste.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbAjuste.ExtendRightColumn = True
            Me.cmbAjuste.SelectedIndex = 0
            Me.cmbAjuste.Text = ""
            Me.cmbAjuste.ColumnHeaders = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Grid"

    Private Sub CargarDetalleRepuesto()
        dtDetalle = New DataTable
        Try
            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, Producto, cast(0 as integer) as Existencia, Cantidad, cast(0 as float) as CostoProm, subtotal", "dbo.vwSivSalidaDetalle", "1=0"))
            Me.grdSalidaDetalle.DataSource = dtDetalle
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargarComboDescripcion()
        Dim riLookComboDescripcion As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'dtRepuestoCombo = New DataTable
        Try
            dtRepuestoCombo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SivProductoID,Nombre", "dbo.SivProductos"))
            riLookComboDescripcion = Me.grdSalidaDetalle.RepositoryItems(1)
            riLookComboDescripcion.DataSource = dtRepuestoCombo

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtRepuestoCombo = Nothing
        End Try
    End Sub

    Private Sub CargarEmpleado()
        Dim dtEmpleado As New DataTable
        Try
            dtEmpleado = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("NombreEmpleado", "dbo.vwUsuarioEmpleado", "Login= '" & clsProyecto.Conexion.Usuario.ToString & "'"))

            If dtEmpleado.Rows.Count > 0 Then
                Me.lblNombreEmpleado.Text = dtEmpleado.DefaultView.Item(0)("NombreEmpleado")
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region


#Region "Cargar Datos Editar"

    Private Sub CargarDetalleEditar()
        dtDetalle = New DataTable
        Try
            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, Producto, Cantidad, costo as CostoProm, subtotal, Existencia", "dbo.vwSalidaDetalleEditar", "Numero= " & Me.SalidaID))
            Me.grdSalidaDetalle.DataSource = dtDetalle

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarDatos()
        Dim objSalida As New SivSalidaBodega
        Try
            objSalida.RetrieveByFilter("SivSalidaBodegaID = " & Me.SalidaID)
            Me.txtNumero.Text = objSalida.SivSalidaBodegaID
            Me.txtEstado.Text = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Descripcion", "dbo.StbValorCatalogo", "StbValorCatalogoID = " & objSalida.objEstadoID)).DefaultView.Item(0)("Descripcion")
            Me.cmbBodega.SelectedValue = objSalida.objStbBodegaID
            If Not IsDBNull(objSalida.objTipoSalidaID) Then
                Me.cmbTipoSalida.SelectedValue = objSalida.objTipoSalidaID
            End If
            If Not (objSalida.objTipoAjusteID.ToString = "") Then
                Me.cmbAjuste.SelectedValue = objSalida.objTipoAjusteID
            End If
            Me.dtpFecha.Value = objSalida.FechaSalida
            Me.numCostoTotal.Value = objSalida.costototal
            Me.txtcomentarios.Text = objSalida.Comentarios

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSalida = Nothing
        End Try
    End Sub
#End Region

#Region "Validaciones"

    Public Function ValidarEntrada() As Boolean

        If Me.cmbBodega.Text.Trim = "" Then
            ErrorSalida.SetError(cmbBodega, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpFecha.Text.Trim.Length = 0 Then
            ErrorSalida.SetError(dtpFecha, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.cmbTipoSalida.Text.Trim = "" Then
            ErrorSalida.SetError(cmbBodega, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtDetalle.Rows.Count <= 0 Then
            'If (Me.numCostoTotal.Value = 0.0) Or (Me.numCostoTotal.Text.Trim.Length = 0) Then
            MsgBox("Defina al menos un repuesto de salida", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Return False
            Exit Function
        End If

        Return True
    End Function

    
#End Region

#Region "Procedimientos"

#Region "Configurar GUI"

    Public Sub ConfigurarGUI()
        Dim punto As New Point
        Dim puntoBoton As New Point
        Dim puntoBotonCancelar As New Point

        punto.X = Me.grbDetalle.Location.X
        punto.Y = 180
        puntoBoton.X = Me.cmdGuardar.Location.X
        puntoBoton.Y = 680 '585
        puntoBotonCancelar.X = Me.cmdCancelar.Location.X
        puntoBotonCancelar.Y = 680 '585

        Me.CargarBodega()
        Me.CargarTipoSalida()
        Me.CargarTipoAjuste()
        Me.CargarEmpleado()

        'Seleccionar sucursal en sessión
        If Not String.IsNullOrEmpty(clsProyecto.Sucursal) Then
            Try
                Me.SucursalSessionID = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
                Me.SucursalCentralID = ClsCatalogos.GetStbTiendaID("C")
                Me.cmbBodega.SelectedValue = Me.SucursalSessionID
                Me.cmbBodega.Enabled = False 'Me.SucursalCentralID = Me.SucursalSessionID

            Catch ex As Exception
                MsgBox("La sucursal configurada no es una sucursal de repuestos", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
                Me.Close()
            End Try
        Else
            MsgBox("No se ha configurado la sucursal en el utilitario de configuración", MsgBoxStyle.Exclamation, clsProyecto.SiglasSistema)
            Me.Close()
        End If

        Select Case Me.TypeGui
            Case 0
                Me.Text = "Agregar Salida"

                Me.CargarDetalleRepuesto()
                Me.CargarComboDescripcion()
                Me.txtComentarioAnular.Visible = False
                Me.lblanular.Visible = False
                Me.lblanular.Visible = False
                Me.grbDetalle.Location = punto
                Me.cmdCancelar.Location = puntoBotonCancelar
                Me.cmdGuardar.Location = puntoBoton
                Me.Height = 800 '675
                Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor

            Case 1
                Me.Text = "Autorizar Salida"
                CargarDatos()
                CargarDetalleEditar()
                Me.CargarComboDescripcion()
                Me.txtComentarioAnular.Visible = False
                Me.lblanular.Visible = False
                Me.lblanular.Visible = False
                Me.grbDetalle.Location = punto
                Me.cmdCancelar.Location = puntoBotonCancelar
                Me.cmdGuardar.Location = puntoBoton
                Me.Height = 800 '675
                Me.cmbTipoSalida.Enabled = False
                Me.grdSalidaDetalle.Enabled = False

            Case 2
                Me.Text = "Anular Salida"
                CargarDatos()
                CargarDetalleEditar()
                Me.CargarComboDescripcion()
                Me.BloquerControles()
                Me.grdSalidaDetalle.Enabled = False
                'Me.grdDetalleProductos.Enabled = False
                Me.txtComentarioAnular.Enabled = True
                Me.cmdGuardar.Enabled = True

            Case 3
                Me.Text = "Consultar Salida"
                CargarDatos()
                CargarDetalleEditar()
                Me.CargarComboDescripcion()
                Me.txtComentarioAnular.Enabled = False
                Me.BloquerControles()
                'Me.grdDetalleProductos.Enabled = False
                Me.grdSalidaDetalle.Enabled = False
            Case 4
                Me.Text = "Solicitud de Salida Repuesto"
                Me.CargarDetalleRepuesto()
                Me.CargarComboDescripcion()
                Me.txtComentarioAnular.Visible = False
                Me.lblanular.Visible = False
                Me.lblanular.Visible = False
                Me.grbDetalle.Location = punto
                Me.cmdCancelar.Location = puntoBotonCancelar
                Me.cmdGuardar.Location = puntoBoton
                Me.Height = 800 '675
                Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                Me.cmbTipoSalida.Enabled = False
                Me.cmbTipoSalida.SelectedValue = Me.TipoSalidaGarantiaID
              
        End Select
    End Sub

    Private Sub BloquerControles()
        Me.cmbBodega.Tag = "BLOQUEADO"
        Me.cmbBodega.Enabled = False
        Me.cmbTipoSalida.Tag = "BLOQUEADO"
        Me.cmbTipoSalida.Enabled = False
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Tag = "BLOQUEADO"
        Me.txtComentarioAnular.Enabled = False
        Me.txtcomentarios.Enabled = False
        Me.txtcomentarios.Tag = "BLOQUEADO"
        Me.cmdGuardar.Enabled = False
    End Sub
#End Region

#Region "Guardar"
    Private Sub AgregarSalida()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            Me.GuardarSalida(T)
            Me.GuardarSalidaDetalle(T)
            T.CommitTran()
            Me.boolModificado = False
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.Imprimir()
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarSalida(ByVal T As DAL.TransactionManager)
        Dim objSalida As SivSalidaBodega
        Try
            objSalida = New SivSalidaBodega
            objSalida.objStbBodegaID = Me.cmbBodega.SelectedValue
            objSalida.objTipoAjusteID = Me.cmbAjuste.SelectedValue
            objSalida.objTipoSalidaID = Me.cmbTipoSalida.SelectedValue
            objSalida.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "01")
            objSalida.Comentarios = Me.txtcomentarios.Text
            If Not IsDBNull(Me.numCostoTotal.Value) AndAlso Me.numCostoTotal.Value.ToString.Trim.Length <> 0 Then
                objSalida.costototal = Me.numCostoTotal.Value
            Else
                objSalida.costototal = 0
            End If
            objSalida.FechaSalida = Me.dtpFecha.Value

            'If Me.TypeGui = 4 Then '4=El llamado al formulario de salida se hizo desde Servicios de taller
            '    If Me.StaServicioTallerID <> 0 Then
            '        objSalida.objServicioTallerID = Me.StaServicioTallerID
            '    End If
            'End If

            objSalida.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSalida.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSalida.Insert(T)
            Me.SalidaID = objSalida.SivSalidaBodegaID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarSalidaDetalle(ByVal T As DAL.TransactionManager)
        Dim objSalidaDetalle As SivSalidaBodegaDetalle
        Dim dtDetalleSalida As New DataTable
        Dim fila As DataRow
        Try
            objSalidaDetalle = New SivSalidaBodegaDetalle
            dtDetalleSalida = SivSalidaBodegaDetalle.RetrieveDT("1=0")

            'Isertar detalle de Factura              
            Me.dtDetalle.AcceptChanges()
            For Each row As DataRow In Me.dtDetalle.Rows
                If Not IsDBNull(row("Codigo")) Then
                    fila = dtDetalleSalida.NewRow
                    fila("objSalidaBodegaID") = Me.SalidaID
                    fila("objSivProductoID") = row("Codigo")
                    fila("Cantidad") = row("Cantidad")
                    fila("costo") = row("CostoProm")
                    fila("subtotal") = row("Subtotal")
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleSalida.Rows.Add(fila)
                End If
            Next
            dtDetalleSalida.TableName = "SivSalidaBodegaDetalle"
            SivSalidaBodegaDetalle.BatchUpdate(dtDetalleSalida.DataSet, T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Autorizar"
    Private Sub Autorizar()
        Dim objsalida As New SivSalidaBodega
        Dim objSivBodegaProductos As New SivBodegaProductos
        Dim objSivSalidaDetalle As New SivSalidaBodegaDetalle
        Dim T As New DAL.TransactionManager
        Dim dtDetalleSalida As New DataTable
        Dim fila As DataRow
        Try
            T.BeginTran()
            objsalida.RetrieveByFilter("SivSalidaBodegaID = " & Me.SalidaID)
            objsalida.objStbBodegaID = Me.cmbBodega.SelectedValue
            objsalida.objTipoAjusteID = Me.cmbAjuste.SelectedValue
            objsalida.objTipoSalidaID = Me.cmbTipoSalida.SelectedValue
            objsalida.FechaSalida = Me.dtpFecha.Value
            objsalida.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "02")
            objsalida.Comentarios = Me.txtcomentarios.Text
            objsalida.costototal = Me.numCostoTotal.Value
            objsalida.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objsalida.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objsalida.Update(T)

            '--Eliminar los detalles de la salida
            dtDetalleSalida = SivSalidaBodegaDetalle.RetrieveDT("1=0")
            SivSalidaBodegaDetalle.DeleteByFilter("objSalidaBodegaID = " & Me.SalidaID, T)
            dtDetalleSalida = SivSalidaBodegaDetalle.RetrieveDT("1=0")

            'Isertar detalle de salida          
            For Each row As DataRow In Me.dtDetalle.Rows
                fila = dtDetalleSalida.NewRow
                fila("objSalidaBodegaID") = Me.SalidaID
                fila("objSivProductoID") = row("Codigo")

                If objSivBodegaProductos.RetrieveByFilter("objProductoID = '" & row("Codigo") & "' AND objBodegaID=" & Me.cmbBodega.SelectedValue) Then
                    fila("ExistenciaAnterior") = objSivBodegaProductos.Cantidad
                End If

                fila("Cantidad") = row("Cantidad")
                fila("costo") = row("CostoProm")
                fila("Subtotal") = row("Subtotal")
                fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                dtDetalleSalida.Rows.Add(fila)
            Next
            dtDetalleSalida.TableName = "SivSalidaBodegaDetalle"
            SivSalidaBodegaDetalle.BatchUpdate(dtDetalleSalida.DataSet, T)

            '---- Actualizar el campo cantidad de la tabla SivBodegaRepuestos
            For Each row As DataRow In Me.dtDetalle.Rows

                objSivBodegaProductos.Cantidad = objSivBodegaProductos.Cantidad - row("Cantidad")
                objSivBodegaProductos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSivBodegaProductos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSivBodegaProductos.Update(T)
            Next
            T.CommitTran()
            Me.boolModificado = False
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objsalida = Nothing
            objSivBodegaProductos = Nothing
            dtDetalleSalida = Nothing
        End Try
    End Sub

#End Region

#Region "Anular"
    Private Sub Anular()
        Dim objSalida As New SivSalidaBodega
        Dim objSalidaDetalle As New SivSalidaBodegaDetalle
        Dim objSivBodegaProductos As New SivBodegaProductos
        Dim dtDetalleAnular As New DataTable
        Dim fila As DataRow
        Dim t As New TransactionManager
        Try
            '--Actualizar en SivBodegaSalida
            t.BeginTran()

            objSalida.RetrieveByFilter("SivSalidaBodegaID = " & Me.SalidaID)
            If objSalida.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "01") Then

                objSalida.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "03")
                objSalida.costototal = 0
                objSalida.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSalida.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSalida.Update()

                '---Actualizar el detalle de la factura
                SivSalidaBodegaDetalle.DeleteByFilter("objSalidaBodegaID = " & Me.SalidaID)
                dtDetalleAnular = SivSalidaBodegaDetalle.RetrieveDT("1=0")

                'Isertar detalle de salida          
                For Each row As DataRow In Me.dtDetalle.Rows
                    fila = dtDetalleAnular.NewRow
                    fila("objSalidaBodegaID") = Me.SalidaID
                    fila("objSivProductoID") = row("Codigo")
                    fila("Cantidad") = 0
                    fila("costo") = 0.0
                    fila("Subtotal") = 0.0
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleAnular.Rows.Add(fila)
                Next
                dtDetalleAnular.TableName = "SivSalidaBodegaDetalle"
                SivSalidaBodegaDetalle.BatchUpdate(dtDetalleAnular.DataSet, t)

            ElseIf objSalida.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "02") Then
                objSalida.objEstadoID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "03")
                objSalida.costototal = 0
                objSalida.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSalida.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSalida.Update()

                '---Actualizar el detalle de la factura
                SivSalidaBodegaDetalle.DeleteByFilter("objSalidaBodegaID = " & Me.SalidaID)
                dtDetalleAnular = SivSalidaBodegaDetalle.RetrieveDT("1=0")

                'Isertar detalle de salida           

                For Each row As DataRow In Me.dtDetalle.Rows
                    fila = dtDetalleAnular.NewRow
                    fila("objSalidaBodegaID") = Me.SalidaID
                    fila("objSivProductoID") = row("Codigo")
                    fila("Cantidad") = 0
                    fila("costo") = 0.0
                    fila("Subtotal") = 0.0
                    fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                    fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                    dtDetalleAnular.Rows.Add(fila)
                Next
                dtDetalleAnular.TableName = "SivSalidaBodegaDetalle"
                SivSalidaBodegaDetalle.BatchUpdate(dtDetalleAnular.DataSet, t)

                '-- Actualiza la cantidad de la tabla SivBodegarepuesto
                For Each row As DataRow In Me.dtDetalle.Rows
                    objSivBodegaProductos.RetrieveByFilter("objProductoID = '" & row("Codigo") & "' AND objBodegaID = " & Me.cmbBodega.SelectedValue)
                    objSivBodegaProductos.Cantidad = objSivBodegaProductos.Cantidad + row("Cantidad")
                    objSivBodegaProductos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objSivBodegaProductos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objSivBodegaProductos.Update()
                Next
            End If

            t.CommitTran()
            Me.boolModificado = False
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            'T.RollbackTran()
        Finally
            objSalida = Nothing
            objSalidaDetalle = Nothing
            objSivBodegaProductos = Nothing
        End Try
    End Sub

#End Region

#Region "Imprimir"

    Private Sub Imprimir()
        Dim objReporte As rptSalidaBodega
        Dim objImpresion As frmOpcionesImpresion
        Dim sSQL, sCampos As String
        Dim dtReporte As New DataTable

        objImpresion = New frmOpcionesImpresion
        objReporte = New rptSalidaBodega

        sCampos = "distinct SivSalidaBodegaID, FechaSalida, TipoSalida, objEstadoID, BodegaCodigo,objTipoSalidaID, Estado, Bodega, Producto, Cantidad, costo, subtotal, Comentarios,Anulada"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwRptSalidaBodega", "SivSalidaBodegaID = " & Me.SalidaID)
        dtReporte = SqlHelper.ExecuteQueryDT(sSQL)
        objReporte.DataSource = dtReporte

        If dtReporte.Rows.Count = 0 Then
            MsgBox("No hay datos para generar el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Exit Sub
        End If

        If dtReporte.DefaultView.Item(0)("objEstadoID") = Me.EstadoSalidaAutorizadaID Then
            objReporte.UsuarioAutorizacion = clsProyecto.Conexion.Usuario
        End If

        If objImpresion.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case objImpresion.Seleccion
                Case 1
                    clsProyecto.ImprimirEnPantalla(objReporte)
                Case 2
                    clsProyecto.ImprimirEnImpresora(objReporte, True)
                Case 3
                    clsProyecto.ImprimirEnArchivo(objReporte, Me)
            End Select
        End If
    End Sub

#End Region

#End Region

#Region "Procedimientos para el Grid"

#Region "Insertar una nueva fila en el grid"
    Private Sub InsertarNuevaFilaGrid()
        Try
            '   If Me.grdSalidaDetalleTable.RowCount < Me.MaxItemDetalle Then
            Me.dtDetalle.Rows.Add()
            Me.grdSalidaDetalleTable.MoveLast()
            Me.grdSalidaDetalleTable.FocusedColumn = Me.colCodigo
            ' End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Es fila vacía"
    Private Function EsFilaVacia() As Boolean
        Dim blnRetorno As Boolean = False
        Dim Valor As New Object
        Try
            Valor = Me.grdSalidaDetalleTable.Columns("Codigo").View.GetRowCellValue(Me.grdSalidaDetalleTable.FocusedRowHandle, "Codigo")
            blnRetorno = Not Me.TieneValor(Valor)
        Catch ex As Exception
            blnRetorno = False
        End Try
        Return blnRetorno
    End Function
#End Region

#Region "Tiene Valor"

    Private Function TieneValor(ByVal Valor As Object) As Boolean
        If Not Valor Is Nothing Then
            Return (Not IsDBNull(Valor)) AndAlso Valor.ToString.Trim.Length <> 0
        Else
            Return False
        End If
    End Function

#End Region

#Region "Eliminar sin Preguntar"
    Private Sub ElminarFilaSinPreguntar()
        Try
            If Me.dtDetalle.Rows.Count <> 0 Then
                Me.dtDetalle.Rows.RemoveAt(Me.grdSalidaDetalleTable.FocusedRowHandle) 'Borra la fila del datatable directo
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Eliminar Fila"
    Private Sub EliminarFila()
        If MsgBox("¿Seguro que desea eliminar la fila seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes Then
            Try
                Me.dtDetalle.Rows.RemoveAt(Me.grdSalidaDetalleTable.FocusedRowHandle) 'Borra la fila del datatable directo
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region

#Region "Existe en detalle"
    Private Function ExisteEnDetalle(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        Dim strValorCampo As String
        For Each row As DataRow In Me.dtDetalle.Rows
            If Me.TieneValor(valor) AndAlso Me.TieneValor(row(Campo)) Then
                strValorCampo = row(Campo)
                If valor.ToString.Trim = strValorCampo.Trim Then
                    blnValor = True
                End If
            End If
        Next
        Return blnValor
    End Function
#End Region

#Region "Número Válido"
    Private Function NumeroValido(ByVal valor As Object) As Boolean
        If Not valor Is Nothing Then
            If Me.TieneValor(valor) Then
                If valor <> 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "Está en última fila"
    Private Function EstaEnUltimaFila() As Boolean
        Return Me.grdSalidaDetalleTable.FocusedRowHandle = Me.grdSalidaDetalleTable.RowCount - 1
    End Function
#End Region

#Region "Buscar Duplicados en Grid"
    Private Function BuscarDuplicados(ByVal valor As Object, ByVal Campo As String) As Boolean
        Dim blnValor As Boolean = False
        Dim iContador As Integer = 0
        Dim strValorCampo As String
        If Me.dtDetalle.Rows.Count > 1 Then
            For Each row As DataRow In Me.dtDetalle.Rows
                row.EndEdit()
                If Me.TieneValor(valor) AndAlso Me.TieneValor(row(Campo)) Then
                    strValorCampo = row(Campo)
                    If valor.ToString.Trim.Equals(strValorCampo.Trim) Then
                        iContador += 1
                    End If
                End If
            Next
            If iContador > 1 Then
                blnValor = True
            Else
                blnValor = False
            End If
        End If
        Return blnValor
    End Function
#End Region

#Region "Existen Cantidades en CERO"
    Private Function ExistenCantidadesEnCero() As Boolean
        Return Me.dtDetalle.Select("Cantidad=0").Length > 0
    End Function
#End Region

#Region "Id Respuesto Seleccionado"
    Private Function IdRepuestoSeleccionado() As Integer
        Dim CodigoRepuesto As Object = Me.grdSalidaDetalleTable.Columns("Codigo").View.GetRowCellValue(Me.grdSalidaDetalleTable.FocusedRowHandle, "Codigo")
        If Not Me.NumeroValido(CodigoRepuesto) Then
            CodigoRepuesto = 0
        End If
        Return CodigoRepuesto
    End Function
#End Region

#Region "Calculos"
    Private Sub CalcularTotales()
        Dim DecSubTotal As Double

        Try
            DecSubTotal = 0.0

            If Not Me.dtDetalle Is Nothing Then
                If Me.dtDetalle.DefaultView.Count > 0 Then
                    DecSubTotal = Me.dtDetalle.Compute("SUM(Subtotal)", "1=1")
                End If
            End If

            Me.numCostoTotal.Value = DecSubTotal

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Eventos"

#Region "Formulario"
    Private Sub frmSivAgregarSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargar estados salida.
        EstadoSalidaRegistradaID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "01")
        EstadoSalidaAutorizadaID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "02")
        EstadoSalidaAnuladaID = ClsCatalogos.GetValorCatalogoID("ESTADOSALIDA", "03")

        Me.ConfigurarGUI()
        boolModificado = False

    End Sub

    Private Sub frmSivAgregarSalida_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.boolModificado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
            'Else
            '    Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

#End Region

#Region "Botones"
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        If Me.ValidarEntrada Then
            Select Case Me.TypeGui
                Case 0, 4
                    Me.AgregarSalida()
                Case 1
                    Me.Autorizar()
                Case 2
                    If Me.txtComentarioAnular.Text.Trim.Length = 0 Then
                        ErrorSalida.SetError(Me.txtComentarioAnular, My.Resources.MsgObligatorio)
                    Else
                        Me.Anular()
                    End If
            End Select
        End If
    End Sub
#End Region

#Region "Controles"
    Private Sub cmbTipoSalida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoSalida.TextChanged
        ErrorSalida.SetError(cmbTipoSalida, "")
        Me.boolModificado = True

        If Me.cmbTipoSalida.SelectedValue = ClsCatalogos.GetValorCatalogoID("TIPOSALIDA", "01") Then
            Me.cmbAjuste.SelectedValue = ClsCatalogos.GetValorCatalogoID("TIPOAJUSTE", "02")
        Else
            Me.cmbAjuste.Text = ""
        End If
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.TextChanged
        ErrorSalida.SetError(dtpFecha, "")
        Me.boolModificado = True
    End Sub

    Private Sub txtComentarioAnular_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComentarioAnular.TextChanged
        ErrorSalida.SetError(txtComentarioAnular, "")
        Me.boolModificado = True
    End Sub

    Private Sub txtcomentarios_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcomentarios.TextChanged
        ErrorSalida.SetError(txtcomentarios, "")
        Me.boolModificado = True
    End Sub

    Private Sub grdDetalleProductos_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.boolModificado = True
    End Sub
#End Region

#End Region

    Private Sub grdSalidaDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdSalidaDetalle.Enter
        Me.ErrorSalida.SetError(Me.grbDetalle, "")
        If Me.grdSalidaDetalleTable.RowCount = 0 Then
            Me.InsertarNuevaFilaGrid()
            Exit Sub
        End If
    End Sub

    Private Sub grdSalidaDetalle_EditorKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdSalidaDetalle.EditorKeyDown
        'Borra en modo de edición del grid, para ello se debe presionar la tecla control + delete
        If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
            Me.EliminarFila()
        End If
      
    End Sub

    Private Sub grdSalidaDetalleTable_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grdSalidaDetalleTable.ValidateRow
        Dim viewCodigoRepuesto As ColumnView = CType(sender, ColumnView)
        Dim viewDescripcion As ColumnView = CType(sender, ColumnView)
        Dim viewCantidad As ColumnView = CType(sender, ColumnView)
        Dim viewExistencia As ColumnView = CType(sender, ColumnView)
        Dim columnCodigoRepuesto As GridColumn = viewCodigoRepuesto.Columns("Codigo")
        Dim columnDescripcion As GridColumn = viewDescripcion.Columns("Codigo")
        Dim columnCantidad As GridColumn = viewCantidad.Columns("Cantidad")
        Dim columnExistencia As GridColumn = viewExistencia.Columns("Existencia")

        If IsDBNull(viewCodigoRepuesto.GetRowCellValue(e.RowHandle, columnCodigoRepuesto)) Then
            e.Valid = False
            viewCodigoRepuesto.SetColumnError(columnCodigoRepuesto, "El Código no puede ser nulo.")
            boolExisteErroresGrid = True
        Else
            'If viewCodigoRepuesto.GetRowCellValue(e.RowHandle, columnCodigoRepuesto) >= Int32.MaxValue Then
            '    e.Valid = False
            '    viewCodigoRepuesto.SetColumnError(columnCodigoRepuesto, "El Código ingresado no es soportado.")
            '    boolExisteErroresGrid = True
            'Else
            '    boolExisteErroresGrid = False
            'End If
        End If

        If IsDBNull(viewDescripcion.GetRowCellValue(e.RowHandle, columnDescripcion)) Then
            e.Valid = False
            viewDescripcion.SetColumnError(columnDescripcion, "La descripcion no puede ser nula.")
            boolExisteErroresGrid = True
        Else
            boolExisteErroresGrid = False
        End If

        If IsDBNull(viewCantidad.GetRowCellValue(e.RowHandle, columnCantidad)) OrElse viewCantidad.GetRowCellValue(e.RowHandle, columnCantidad) <= 0 Then
            e.Valid = False
            viewCantidad.SetColumnError(columnCantidad, "La Cantidad no puede contener un valor NULO, CERO o NEGATIVO.")
            boolExisteErroresGrid = True
        Else
            boolExisteErroresGrid = False
        End If
    End Sub

    Private Sub grdSalidaDetalleTable_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdSalidaDetalleTable.CellValueChanging
        'Limpiar los íconos de error en el momento de modificar las celdas
        Dim view As ColumnView = sender

        Select Case e.Column.Name
            Case Me.colCodigo.Name, Me.colDescripcion.Name, Me.colCantidad.Name
                view.ClearColumnErrors()
        End Select
    End Sub

    Private Sub grdSalidaDetalleTable_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grdSalidaDetalleTable.InvalidRowException
        'Evitar el popup de error de la celda
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub grdSalidaDetalleTable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdSalidaDetalleTable.KeyDown
        Dim blnEnfoque As Boolean

        '---- Delete
        If e.KeyCode = Keys.Delete Then
            Dim view As GridView = CType(sender, GridView)
            If view.RowCount <> 0 Then
                If Me.EsFilaVacia Then
                    Me.ElminarFilaSinPreguntar()
                Else
                    Me.EliminarFila()
                    Me.CalcularTotales()
                End If
            End If
        End If

        '---- Enter
        If e.KeyCode = Keys.Enter Then
            'Si no hay filas
            If Me.grdSalidaDetalleTable.RowCount = 0 Then
                Me.InsertarNuevaFilaGrid()
                Exit Sub
            End If

            ''Cantidad
            'If Me.grdSalidaDetalleTable.FocusedColumn.Equals(Me.colCantidad) Then '3=Servicio de instalación

            '    blnEnfoque = Me.grdSalidaDetalleTable.FocusedColumn.Equals(Me.colCantidad)
            '    If blnEnfoque Then
            '        If Me.grdSalidaDetalleTable.FocusedColumn.View.FocusedValue = 0 Then
            '            Exit Sub
            '        End If
            '    End If
            'End If

            'Cantidad
            If Me.grdSalidaDetalleTable.FocusedColumn.Equals(Me.colCantidad) Then
                'Me.grdSalidaDetalleTable.FocusedColumn = Me.colCodigo
                SendKeys.Send("{down}")
                Exit Sub
            End If

        End If

        '---- Direccional hacia abajo
        If (e.KeyCode = Keys.Down) And (boolExisteErroresGrid = False) Then
            If Me.grdSalidaDetalleTable.RowCount <> 0 Then
                Dim valor As Object = Me.grdSalidaDetalleTable.Columns("Cantidad").View.GetRowCellValue(Me.grdSalidaDetalleTable.FocusedRowHandle, "Cantidad")
                If Me.EstaEnUltimaFila And Me.NumeroValido(valor) And (Not Me.EsFilaVacia) Then
                    Me.InsertarNuevaFilaGrid()
                End If
            Else
                Me.InsertarNuevaFilaGrid()
            End If
        End If

        '----- Direccional hacia arriba
        If e.KeyCode = Keys.Up Then
            If Me.EsFilaVacia And Me.grdSalidaDetalleTable.RowCount <> 1 Then
                e.SuppressKeyPress = True
                Me.ElminarFilaSinPreguntar()
            End If
        End If

        '--- Direccional hacia derecha
        Try
            If e.KeyCode = Keys.Right AndAlso Me.grdSalidaDetalleTable.FocusedColumn.Equals(Me.colCantidad) And (boolExisteErroresGrid = False) Then
                Dim Cantidad As Object = Me.grdSalidaDetalleTable.Columns("Cantidad").View.GetRowCellValue(Me.grdSalidaDetalleTable.FocusedRowHandle, "Cantidad")
                If Cantidad <> Nothing Then
                    If Me.EstaEnUltimaFila AndAlso Me.NumeroValido(Cantidad) AndAlso (Not Me.EsFilaVacia) AndAlso (IdRepuestoSeleccionado() <> 3) Then
                        e.SuppressKeyPress = True
                        Me.InsertarNuevaFilaGrid()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

        'Si se preciona TAB estando en la última Celda editable
        If e.KeyCode = Keys.Tab AndAlso Me.grdSalidaDetalleTable.FocusedColumn.Equals(Me.colCantidad) Then
            Me.txtcomentarios.Focus()
        End If
    End Sub

#Region "RellenarDatosGrid"
    Private Sub RellenarDatosGrid(ByVal strFiltro As String, ByVal intFilaActual As Integer)
        Dim objSivProductos As SivProductos
        Dim objSivBodegaProductos As SivBodegaProductos
        objSivProductos = New SivProductos
        objSivBodegaProductos = New SivBodegaProductos

        objSivProductos.RetrieveByFilter("SivProductoID=" & "'" & strFiltro & "'" & " AND Activo=1") 'REVISAR ESTO POR REGLAS DE NEGOCIO
        objSivBodegaProductos.RetrieveByFilter("objProductoID=" & "'" & objSivProductos.SivProductoID & "' AND objBodegaID= " & Me.cmbBodega.SelectedValue)
        Me.dtDetalle.DefaultView.Item(intFilaActual)("Codigo") = objSivProductos.SivProductoID
        Me.dtDetalle.DefaultView.Item(intFilaActual)("Cantidad") = 0
        Me.dtDetalle.DefaultView.Item(intFilaActual)("subtotal") = 0
        Me.dtDetalle.DefaultView.Item(intFilaActual)("CostoProm") = objSivProductos.CostoPromedio
        Me.dtDetalle.DefaultView.Item(intFilaActual)("Existencia") = objSivBodegaProductos.Cantidad
        Me.numExistencia.Value = objSivBodegaProductos.Cantidad
        Me.grdSalidaDetalleTable.FocusedColumn = Me.colCantidad
    End Sub

#End Region


    Private Function ValidarSeleccionBodega() As Boolean
        If Me.cmbBodega.Text = "" Then
            MsgBox("Debe seleccionar la Bodega.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub grdSalidaDetalleTable_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdSalidaDetalleTable.CellValueChanged
        Dim FilaActual As Integer
        Dim strIndiceCombo As String
        Dim blnVerificaRepuestoAct, blnVerificaCodRepuesto, blnVerificarExistencia As Boolean
        Dim objSivProductos As SivProductos
        Dim objSivBodegaProductos As SivBodegaProductos

        FilaActual = Me.grdSalidaDetalleTable.FocusedRowHandle

        objSivProductos = New SivProductos
        objSivBodegaProductos = New SivBodegaProductos

        If Me.ValidarSeleccionBodega Then
            'CodigoRepuesto
            If e.Column.Equals(Me.colCodigo) Then
                If Me.dtDetalle.DefaultView.Count <> 0 Then

                    'Verifica si el código del repuesto existe
                    blnVerificaCodRepuesto = objSivProductos.RetrieveByFilter("SivProductoID='" & (Me.dtDetalle.DefaultView.Item(FilaActual)("Codigo")) & "'")
                    If (blnVerificaCodRepuesto = False) Then
                        MsgBox("El código de producto no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.ElminarFilaSinPreguntar()
                        Me.InsertarNuevaFilaGrid()
                        Exit Sub
                    End If

                    'Verifica si el Repuesto está activo (REVISAR ESTA VALIDACION POR REGLAS DE NEGOCIO)
                    blnVerificaRepuestoAct = objSivProductos.RetrieveByFilter("SivProductoID='" & objSivProductos.SivProductoID & "' AND Activo=0")
                    If (blnVerificaRepuestoAct = True) Then
                        MsgBox("El producto está inactivo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.ElminarFilaSinPreguntar()
                        Me.InsertarNuevaFilaGrid()
                        Exit Sub
                    End If

                    'Verifica que el repuesto este en existencia
                    blnVerificarExistencia = objSivBodegaProductos.RetrieveByFilter("objProductoID = " & "'" & objSivProductos.SivProductoID & "'" & " AND objBodegaID = " & Me.cmbBodega.SelectedValue & " AND Cantidad <> 0")
                    If Not blnVerificarExistencia Then
                        MsgBox("El producto no tiene existencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.ElminarFilaSinPreguntar()
                        Me.InsertarNuevaFilaGrid()
                        Me.grdSalidaDetalleTable.FocusedColumn = Me.colCodigo
                        Exit Sub
                    End If

                    If Me.BuscarDuplicados(Me.grdSalidaDetalleTable.EditingValue, Me.colCodigo.FieldName) Then
                        MsgBox("Este valor ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Sistema")
                        Me.ElminarFilaSinPreguntar()
                        Me.InsertarNuevaFilaGrid()
                        Me.grdSalidaDetalleTable.FocusedColumn = Me.colCodigo
                        Exit Sub
                    End If

                    'Si todo está bien se rellenan los datos
                    RellenarDatosGrid(Me.grdSalidaDetalleTable.EditingValue, FilaActual)
                End If
            End If

            'Descripción
            If e.Column.Equals(Me.colDescripcion) Then
                'Verifica que el repuesto este en existencia
                blnVerificarExistencia = objSivBodegaProductos.RetrieveByFilter("objProductoID = " & "'" & Me.grdSalidaDetalleTable.EditingValue & "'" & " AND objBodegaID = " & Me.cmbBodega.SelectedValue & " AND Cantidad <> 0")
                If Not blnVerificarExistencia Then
                    MsgBox("El producto no tiene existencia.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Me.grdSalidaDetalleTable.FocusedColumn = Me.colCodigo
                    Exit Sub
                End If

                strIndiceCombo = grdSalidaDetalleTable.ActiveEditor.EditValue.ToString
                RellenarDatosGrid(strIndiceCombo, FilaActual)
            End If

            'Validacion del repetido
            If e.Column.Equals(Me.colDescripcion) Then
                If Me.BuscarDuplicados(Me.grdSalidaDetalleTable.EditingValue, Me.colCodigo.FieldName) Then
                    MsgBox("Este valor ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Sistema")
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                End If
            End If

            'Cantidad
            If e.Column.Equals(Me.colCantidad) Then

                'Valida si primero se digitó la cantidad
                If (IsDBNull(dtDetalle.DefaultView.Item(FilaActual)("Codigo"))) Then
                    Me.ElminarFilaSinPreguntar()
                    Me.InsertarNuevaFilaGrid()
                    Exit Sub
                End If

                'Realizar cálculos en grid
                If Me.dtDetalle.Rows.Count <> 0 Then
                    If IsDBNull(Me.dtDetalle.DefaultView.Item(FilaActual)("CostoProm")) Then
                        Me.dtDetalle.DefaultView.Item(FilaActual)("CostoProm") = 0
                    End If
                    Me.dtDetalle.DefaultView.Item(FilaActual)("Subtotal") = (Me.dtDetalle.DefaultView.Item(FilaActual)("Cantidad")) * (Me.dtDetalle.DefaultView.Item(FilaActual)("CostoProm"))
                End If

                CalcularTotales()
            End If
            Me.boolModificado = True
        End If

    End Sub

    Private Sub grdSalidaDetalleTable_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdSalidaDetalleTable.ValidatingEditor
        Dim View As GridView = sender
        Dim Valor As Double
        Dim codigo As String
        Dim bValidarEntero As Boolean = False

        '[CodigoRepuesto]
        If View.FocusedColumn.FieldName = "Codigo" Then
            'Obtener el valor actualmente editado
            codigo = Convert.ToString(e.Value)
            bValidarEntero = True
        End If
        '[Cantidad]
        If View.FocusedColumn.FieldName = "Cantidad" Then
            'Obtener el valor actualmente editado
            Valor = Convert.ToDouble(e.Value)
            bValidarEntero = True
        End If

        If bValidarEntero Then
            'Si es negativo, asignar cero
            If Valor < 0 Then
                e.Valid = True
                e.Value = 0
                'e.ErrorText = "Debe ingresar un valor positivo"
            End If
            'Si es mayor que un entero, asignar cero.
            If Valor >= Integer.MaxValue Then
                e.Value = 0
                e.Valid = True
            End If
        End If

        If View.FocusedColumn.FieldName = "Cantidad" Then
            Valor = Convert.ToDouble(e.Value)
            'Debe ser menor o igual a la cantidad existente
            If Not IsDBNull(Me.numExistencia.Value) Then
                If Valor > Me.numExistencia.Value Then
                    MsgBox("La cantidad debe ser menor a la existente.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    e.Value = 0
                    e.Valid = True
                End If
            End If
        End If
       
        If bValidarEntero Then
            'Si es negativo, asignar cero
            If Valor < 0 Then
                e.Valid = True
                e.Value = 0
                'e.ErrorText = "Debe ingresar un valor positivo"
            End If
            'Si es mayor que un entero, asignar cero.
            If Valor >= Integer.MaxValue Then
                e.Value = 0
                e.Valid = True
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
End Class