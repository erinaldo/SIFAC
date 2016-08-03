'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez.
''-- Fecha de Elaboración    : 17 Junio 2010. 04:01 PM.
''-- Formulario de Edición y Modificación de Promociones
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos

Public Class frmSfaPromocionesEdit

    'Tipo enumerado para controlar los índices de los campos del grid detalle
#Region "Tipo Enumerado"
    Public Enum eGridRepuesto
        Codigo
        Descripcion
        ExistenciaT
        CostoProm
        PrecioActual
        UtilidadActual
        Descuento
        PrecioN
        UtilidadN
    End Enum

    Public Enum eGridTipo
        TipoRepuesto
        Descuento
        RepuestosActivos
        objTipoRepuestoID
    End Enum

#End Region

#Region "Atributos"
    Private m_TypeGui As Integer
    Private m_SfaPromocionID As Integer
    Private m_HuboCambioPromocion As Boolean
    Private m_HuboCambioSucursales As Boolean
    Private m_IdSitioSession As Integer

    'para mantener datos localmente en el formulario
    Private dtDetallePorRepuesto As DataTable
    Private dtDetalleGlobalTipo As DataTable
    Private dtSucursales As DataTable

    Private dtDatosComboTipoRepuestos As DataTable
    Private dtDatosComboDescripcionRepuestos As DataTable

#End Region

#Region "Constantes"
    Private Const AGREGACION = 0
    Private Const EDICION = 1
    Private Const CONSULTA = 2
#End Region

#Region "Propiedades"

    Property TypeGui() As Integer
        Get
            TypeGui = Me.m_TypeGui
        End Get
        Set(ByVal value As Integer)
            Me.m_TypeGui = value
        End Set
    End Property

    Property SfaPromocionID() As Integer
        Get
            SfaPromocionID = Me.m_SfaPromocionID
        End Get
        Set(ByVal value As Integer)
            Me.m_SfaPromocionID = value
        End Set
    End Property

    Property HuboCambioPromocion() As Boolean
        Get
            HuboCambioPromocion = Me.m_HuboCambioPromocion
        End Get
        Set(ByVal value As Boolean)
            Me.m_HuboCambioPromocion = value
        End Set
    End Property

    Property HuboCambioSucursales() As Boolean
        Get
            HuboCambioSucursales = Me.m_HuboCambioSucursales
        End Get
        Set(ByVal value As Boolean)
            Me.m_HuboCambioSucursales = value
        End Set
    End Property

    Property IdSitioSession()
        Get
            IdSitioSession = Me.m_IdSitioSession
        End Get
        Set(ByVal value)
            Me.m_IdSitioSession = value
        End Set
    End Property

#End Region

#Region "Cargar Formulario"
    Private Sub frmSfaPromocionesEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.txtDescripcion.MaxLength = SfaPromocion.GetMaxLength("Descripcion")
        Me.IdSitioSession = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)

        If Me.TypeGui <> CONSULTA Then
            Me.CargarComboDescripcionRepuestos()
            Me.CargarComboTipoRepuesto()
        End If

        Select Case Me.TypeGui
            Case AGREGACION
                Me.Text = "Agregar promoción"
                Me.tcDetallePorRepuesto.Visible = True
                Me.tcDetallePorTipo.Visible = False
                Me.dtpFechaCreacion.Value = clsProyecto.Conexion.FechaServidor
                Me.txtUsuarioCreacion.Text = clsProyecto.Conexion.Usuario
                Me.CargarGridSucursales(0) '0=promoción nueva
                Me.FormatearLosGridDetalleParaEdicion()
                'Cargar grid de detalle sin datos
                Me.CargarDetallePorRepuesto()
                Me.CargarDetalleGlobalTipo()

            Case EDICION
                Me.Text = "Editar promoción"
                Me.CargarGridSucursales(Me.SfaPromocionID)
                Me.FormatearGridGlobalTipo(CONSULTA)
                Me.FormatearGridPorRepuesto(CONSULTA)
                Me.FormatearGridSucursales(EDICION)
                'Cargar promoción con su correspondiente detalle de repuesto
                Me.CargaDatosPromocion()
                Me.InabilitarControles()
                Me.dtpFechaFin.Focus()

            Case CONSULTA
                Me.Text = "Consultar promoción"
                Me.CargaDatosPromocion()
                Me.CargarGridSucursales(Me.SfaPromocionID)
                Me.FormatearLosGridDetalleParaConsulta()
                Me.InabilitarControles()
                Me.cmdAceptar.Enabled = False
        End Select

        Me.dtpFechaCreacion.BackColor = Me.txtUsuarioCreacion.BackColor
        Me.dtpFechaCreacion.ReadOnly = True
        'Inicializar banderas para verificación de cambios
        Me.HuboCambioSucursales = False
        Me.HuboCambioPromocion = False        
    End Sub
#End Region

#Region "Procedimientos generales"

#Region "Cargar combos"
    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de descripción de repuesto
    ''' Autor : Gelmin Martínez
    ''' Fecha 17 de Junio de 2010, 04:21 pm.
    ''' </summary>
    Private Sub CargarComboDescripcionRepuestos()
        'Dim dtDatos As New DataTable
        Try
            'Los tres primeros registros de repuestos no tienen descuentos
            Me.dtDatosComboDescripcionRepuestos = SivRepuestos.RetrieveDT("Activo=1 AND SivRepuestoID NOT IN ('1','2','3')", "DescripcionCorta", "DescripcionCorta, SivRepuestoID as objRepuestoID")
            With Me.cmbDescripcionRepuestos
                .DataSource = Me.dtDatosComboDescripcionRepuestos
                .DisplayMember = "DescripcionCorta"
                .ValueMember = "objRepuestoID"

                '.Columns("SivRepuestoID").Caption = "Código"
                .Columns("DescripcionCorta").Caption = "Descripción"
                .Splits(0).DisplayColumns("objRepuestoID").Visible = False

                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Cargar desplegable de Tipos repuestos
    ''' Autor : Gelmin Martínez
    ''' Fecha 17 de Junio de 2010, 04:28 pm.
    ''' </summary>
    Private Sub CargarComboTipoRepuesto()
        'Dim dtDatos As New DataTable
        Try
            Me.dtDatosComboTipoRepuestos = ClsCatalogos.GetValoresCatalogo("TIPOREPUESTO")
            With Me.cmbTiposRepuestos
                .DataSource = Me.dtDatosComboTipoRepuestos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Columns("Descripcion").Caption = "Descripción"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Grid Tiendas"
    Private Sub CargarGridSucursales(ByVal SfaPromocionID As Integer)
        Dim sSQL, sCampos As String
        'configurar combobox para seleccionar repuesto
        sCampos = "Habilitado as Seleccion, StbTiendaID, Codigo, Nombre"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "fnGetSucursalesPromocionEstado(" + SfaPromocionID.ToString + ")")

        Try
            Me.dtSucursales = SqlHelper.ExecuteQueryDT(sSQL)
            Me.grdSucursales.SetDataBinding(Me.dtSucursales, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar datos promoción"
    Private Sub CargaDatosPromocion()
        Dim sSQL, sCampos, sFiltro As String
        Dim dtDatosPromociones As DataTable
        sCampos = "SfaPromocionID, Descripcion, fechainicio, fechafin, promocionglobal, AplicanRestricciones, Activo, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion"
        sFiltro = "SfaPromocionID=" + Me.SfaPromocionID.ToString
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.SfaPromocion", sFiltro)

        dtDatosPromociones = SqlHelper.ExecuteQueryDT(sSQL)

        Me.txtSfaPromocionID.Text = Me.SfaPromocionID
        If dtDatosPromociones.DefaultView(0)("Descripcion").ToString.Length <> 0 Then
            Me.txtDescripcion.Text = dtDatosPromociones.DefaultView(0)("Descripcion")
        End If
        If dtDatosPromociones.DefaultView(0)("Activo").ToString.Length <> 0 Then
            Me.chkActivo.Checked = Convert.ToBoolean(dtDatosPromociones.DefaultView(0)("Activo"))
        End If

        If dtDatosPromociones.DefaultView(0)("Activo").ToString.Length <> 0 Then
            Me.chkActivo.Checked = Convert.ToBoolean(dtDatosPromociones.DefaultView(0)("Activo"))
        End If
        If dtDatosPromociones.DefaultView(0)("AplicanRestricciones").ToString.Length <> 0 Then
            Me.chkAplicanRestricciones.Checked = Convert.ToBoolean(dtDatosPromociones.DefaultView(0)("AplicanRestricciones"))
        End If
        If dtDatosPromociones.DefaultView(0)("Fechainicio").ToString.Length <> 0 Then
            Me.dtpFechaInicio.Value = dtDatosPromociones.DefaultView(0)("Fechainicio")
        End If
        If dtDatosPromociones.DefaultView(0)("Fechafin").ToString.Length <> 0 Then
            Me.dtpFechaFin.Value = dtDatosPromociones.DefaultView(0)("Fechafin").ToString
        End If
        If dtDatosPromociones.DefaultView(0)("FechaCreacion").ToString.Length <> 0 Then
            Me.dtpFechaCreacion.Value = dtDatosPromociones.DefaultView(0)("FechaCreacion")
        End If
        If dtDatosPromociones.DefaultView(0)("UsuarioCreacion").ToString.Length <> 0 Then
            Me.txtUsuarioCreacion.Text = dtDatosPromociones.DefaultView(0)("UsuarioCreacion").ToString
        End If

        'Cargar el detalle de promociones
        sFiltro = "objPromocionID =" + Me.SfaPromocionID.ToString
        If dtDatosPromociones.DefaultView(0)("promocionglobal").ToString.Length <> 0 Then
            If Convert.ToBoolean(dtDatosPromociones.DefaultView(0)("promocionglobal")) Then
                Me.rdbGlobalTipo.Checked = True
                Me.CargarDetalleGlobalTipo(sFiltro)
            Else
                Me.rdbPorRepuesto.Checked = True
                Me.CargarDetallePorRepuesto(sFiltro)
            End If
        End If
    End Sub

#End Region

#Region "Cargar detalle promoción"
    'Cargar datos del Grid de POR REPUESTO
    Private Sub CargarDetallePorRepuesto(Optional ByVal strFiltro As String = "1=0")
        Dim sSQL, sCampos As String

        If Me.TypeGui = AGREGACION Then
            sCampos = " objPromocionID, objRepuestoID, DescripcionCorta, ExistenciaT, CostoProm, Precio, UtilidadActual, Descuento, 0 as PrecioN, 0 as UtilidadN"
        Else
            sCampos = " objPromocionID, objRepuestoID, DescripcionCorta, ExistenciaT, CostoProm, Precio, UtilidadActual, Descuento,(Precio - (Precio*Descuento)) as PrecioN, ((Precio - (Precio*Descuento))-CostoProm) as UtilidadN"
        End If
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "dbo.vwSfaPromocionesDetallePorRepuesto", strFiltro)

        Try
            Me.dtDetallePorRepuesto = SqlHelper.ExecuteQueryDT(sSQL)
            Me.grdDetallePorRepuesto.SetDataBinding(Me.dtDetallePorRepuesto, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    'Cargar de datos del grid GLOBAL POR TIPO
    Private Sub CargarDetalleGlobalTipo(Optional ByVal strFiltro As String = "1=0")
        Dim sSQL, sCampos As String
        sCampos = " objPromocionID, objTipoRepuestoID, TipoRepuesto, Descuento , cast(0 as bit) as RepuestosActivos"
        sSQL = clsConsultas.ObtenerConsultaGeneral(sCampos, "vwSfaPromocionesDetallePorTipo", strFiltro)

        Try
            Me.dtDetalleGlobalTipo = SqlHelper.ExecuteQueryDT(sSQL)
            Me.grdDetalleGlobalTipo.SetDataBinding(Me.dtDetalleGlobalTipo, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Guardar promoción"

#Region "Encabezado"
    Private Function GuardarPromocion() As Boolean
        Dim T As New TransactionManager
        Dim objPromo As New SfaPromocion
        Dim blnActivar As Boolean = False

        If Convert.ToDateTime(Me.dtpFechaInicio.Value).Date <= Convert.ToDateTime(clsProyecto.Conexion.FechaServidor).Date Then
            blnActivar = True
        End If

        Try
            Try
                T.BeginTran()
                With objPromo
                    .Descripcion = Me.txtDescripcion.Text
                    .fechainicio = Me.dtpFechaInicio.Value
                    .fechafin = Me.dtpFechaFin.Value
                    .Activo = blnActivar
                    .AplicanRestricciones = Me.chkAplicanRestricciones.Checked
                    .promocionglobal = Me.rdbGlobalTipo.Checked
                    .UsuarioCreacion = clsProyecto.Conexion.Usuario
                    .FechaCreacion = clsProyecto.Conexion.FechaServidor
                    .Insert(T)
                End With
                Me.SfaPromocionID = objPromo.SfaPromocionID

                If Me.GuardarDetallePromocion(T) Then
                    T.CommitTran()
                    MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Else
                    T.RollbackTran()
                End If

                Return True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            T = Nothing
        End Try
    End Function
#End Region

#Region "Detalle"
    Private Function GuardarDetallePromocion(ByVal T As TransactionManager) As Boolean
        Dim dtlocalDetallePorRepuesto As New DataTable
        Dim dtlocalDetallePorTipo As DataTable
        Dim dtlocalSucursales As DataTable
        Dim fila As DataRow

        Try
            Try
                'Obtener estructura de detalle de promoción
                dtlocalDetallePorRepuesto = SfaPromocionDetalle.RetrieveDT("1=0")
                dtlocalDetallePorTipo = SfaPromocionDetalle.RetrieveDT("1=0")
                dtlocalSucursales = SfaPromocionDetTienda.RetrieveDT("1=0")

                ' ------ Registrar repuestos ------------------
                If Me.rdbPorRepuesto.Checked Then
                    'Isertar detalle por repuesto 
                    Me.dtDetallePorRepuesto.AcceptChanges()
                    For Each row As DataRow In Me.dtDetallePorRepuesto.Rows
                        fila = dtlocalDetallePorRepuesto.NewRow
                        fila("objPromocionID") = Me.SfaPromocionID
                        fila("objRepuestoID") = row("objRepuestoID")
                        fila("Descuento") = row("Descuento")
                        fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        dtlocalDetallePorRepuesto.Rows.Add(fila)
                    Next
                    If dtlocalDetallePorRepuesto.Rows.Count <> 0 Then
                        dtlocalDetallePorRepuesto.TableName = "SfaPromocionDetalle"
                        SfaPromocionDetalle.BatchUpdate(dtlocalDetallePorRepuesto.DataSet, T)
                    End If
                Else
                    'Isertar detalle por Tipo 
                    Me.dtDetalleGlobalTipo.AcceptChanges()
                    For Each row As DataRow In Me.dtDetalleGlobalTipo.Rows
                        fila = dtlocalDetallePorTipo.NewRow
                        fila("objPromocionID") = Me.SfaPromocionID
                        fila("objTipoRepuesto") = row("objTipoRepuestoID")
                        fila("Descuento") = row("Descuento")
                        fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        dtlocalDetallePorTipo.Rows.Add(fila)
                    Next
                    If dtlocalDetallePorTipo.Rows.Count <> 0 Then
                        dtlocalDetallePorTipo.TableName = "SfaPromocionDetalle"
                        SfaPromocionDetalle.BatchUpdate(dtlocalDetallePorTipo.DataSet, T)
                    End If
                End If

                ' ------ Registrar sucursales ------------------
                'Isertar sucursales donde estará activa la promoción 
                Me.dtSucursales.AcceptChanges()
                For Each row As DataRow In Me.dtSucursales.Rows
                    fila = dtlocalSucursales.NewRow
                    If Not IsDBNull(row("Seleccion")) Then
                        If Convert.ToBoolean(row("Seleccion")) Then
                            fila("objPromocionID") = Me.SfaPromocionID
                            fila("objTiendaID") = row("StbTiendaID")
                            fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                            fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                            dtlocalSucursales.Rows.Add(fila)
                        End If
                    End If
                Next
                If dtlocalSucursales.Rows.Count <> 0 Then
                    dtlocalSucursales.TableName = "SfaPromocionDetTienda"
                    SfaPromocionDetTienda.BatchUpdate(dtlocalSucursales.DataSet, T)
                End If

                Return True
            Catch ex As Exception
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            dtlocalDetallePorRepuesto = Nothing
            dtlocalDetallePorTipo = Nothing
            dtlocalSucursales = Nothing
        End Try
    End Function

#End Region

#End Region

#Region "Editar Promoción"

#Region "Encabezado"
    Private Function EditarPromocion() As Boolean
        Dim T As New TransactionManager
        Dim objPromo As New SfaPromocion
        Dim blnActualizado As Boolean = False

        Try
            Try
                T.BeginTran()
                'Si se hizo algún cambio en datos de promoción
                If Me.HuboCambioPromocion Then
                    With objPromo
                        .Retrieve(Me.SfaPromocionID)
                        .fechafin = Me.dtpFechaFin.Value
                        .UsuarioModificacion = clsProyecto.Conexion.Usuario
                        .FechaModificacion = clsProyecto.Conexion.FechaServidor
                        .Update(T)
                    End With
                    blnActualizado = True
                End If

                'Si se hizo algún cambio en sucursales
                If Me.HuboCambioSucursales Then
                    blnActualizado = Me.ActualizarSucursales(T)
                End If

                If blnActualizado Then
                    T.CommitTran()
                    MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Else
                    T.RollbackTran()
                    blnActualizado = False
                End If

                Return blnActualizado
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
                Return False
            End Try
        Finally
            T = Nothing
        End Try
    End Function
#End Region

#Region "Actualizar Sucursales"
    Private Function ActualizarSucursales(ByVal T As TransactionManager) As Boolean
        Dim blnActualizada As Boolean = False
        Dim dtlocalSucursales As DataTable
        Dim fila As DataRow
        Try
            'Obtener estructura de tabla 
            dtlocalSucursales = SfaPromocionDetTienda.RetrieveDT("1=0", , "objPromocionID, objTiendaID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion", T)
            SfaPromocionDetTienda.DeleteByFilter("objPromocionID=" + Me.SfaPromocionID.ToString, T)

            ' ------ Registrar sucursales ------------------
            'Isertar sucursales donde estará activa la promoción 
            Me.dtSucursales.AcceptChanges()
            For Each row As DataRow In Me.dtSucursales.Rows
                fila = dtlocalSucursales.NewRow
                If Not IsDBNull(row("Seleccion")) Then
                    If Convert.ToBoolean(row("Seleccion")) Then
                        fila("objPromocionID") = Me.SfaPromocionID
                        fila("objTiendaID") = row("StbTiendaID")
                        fila("UsuarioCreacion") = clsProyecto.Conexion.Usuario
                        fila("FechaCreacion") = clsProyecto.Conexion.FechaServidor
                        dtlocalSucursales.Rows.Add(fila)
                    End If
                End If
            Next
            If dtlocalSucursales.Rows.Count <> 0 Then
                dtlocalSucursales.TableName = "SfaPromocionDetTienda"
                SfaPromocionDetTienda.BatchUpdate(dtlocalSucursales.DataSet, T)
            End If
            blnActualizada = True

        Catch ex As Exception
            clsError.CaptarError(ex)
            blnActualizada = False
        Finally
            dtlocalSucursales = Nothing
            fila = Nothing
        End Try

        Return blnActualizada
    End Function
#End Region

#End Region

#Region "Validaciones de datos"

#Region "Validaciones"
    Private Function Validaciones() As Boolean

        Try
            'Sólo verificar cuando se está en modo Agregación 
            If Me.TypeGui = AGREGACION Then
                If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
                    Me.ErrErrores.SetError(Me.txtDescripcion, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If

                If IsDBNull(Me.dtpFechaInicio.Value) Then
                    Me.ErrErrores.SetError(Me.dtpFechaInicio, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                ElseIf Convert.ToDateTime(Format(Me.dtpFechaInicio.Value, "yyyy-MM-dd")).Date < Convert.ToDateTime(Format(clsProyecto.Conexion.FechaServidor, "yyyy-MM-dd")).Date Then
                    Me.ErrErrores.SetError(Me.dtpFechaInicio, "La fecha de inicio debe ser Mayor o igual a la fecha actual.")
                    Return False
                    Exit Function
                End If
            End If

            'Si es modo de AGREGACION validar fecha fin con respecto a Fecha Inicio
            If Me.TypeGui = AGREGACION Then
                If IsDBNull(Me.dtpFechaFin.Value) Then
                    Me.ErrErrores.SetError(Me.dtpFechaFin, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                ElseIf (Convert.ToDateTime(Format(Me.dtpFechaFin.Value, "yyyy-MM-dd")).Date < Convert.ToDateTime(Format(Me.dtpFechaInicio.Value, "yyyy-MM-dd")).Date) Then
                    Me.ErrErrores.SetError(Me.dtpFechaFin, "La fecha de fin debe ser Mayor o igual a la fecha Inicio.")
                    Return False
                    Exit Function
                End If
            End If

            'Si es modo de EDICION validar fecha fin con Fecha Actual
            If Me.TypeGui = EDICION Then
                If IsDBNull(Me.dtpFechaFin.Value) Then
                    Me.ErrErrores.SetError(Me.dtpFechaFin, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                ElseIf (Convert.ToDateTime(Format(Me.dtpFechaFin.Value, "yyyy-MM-dd")).Date < Convert.ToDateTime(Format(clsProyecto.Conexion.FechaServidor, "yyyy-MM-dd")).Date) Then
                    Me.ErrErrores.SetError(Me.dtpFechaFin, "La fecha de fin debe ser Mayor o igual a la fecha Actual")
                    Return False
                    Exit Function
                End If
            End If

            'Sólo verificar cuando se está en modo Agregación
            If Me.TypeGui = AGREGACION Then
                If Me.dtDetallePorRepuesto.Rows.Count = 0 And Me.dtDetalleGlobalTipo.Rows.Count = 0 Then
                    If Me.rdbPorRepuesto.Checked Then
                        Me.ErrErrores.SetError(Me.tcDetallePorRepuesto, "Debe agregar al menos un descuento ya sea por repuesto o por tipo.")
                    Else
                        Me.ErrErrores.SetError(Me.tcDetallePorTipo, "Debe agregar al menos un descuento ya sea por repuesto o por tipo.")
                    End If
                    Return False
                    Exit Function
                End If

                If Me.ExistenDescuentosEnCero Then
                    If Me.rdbPorRepuesto.Checked Then
                        Me.ErrErrores.SetError(Me.tcDetallePorRepuesto, "Hay al menos un valor de descuento en CERO.")
                    Else
                        Me.ErrErrores.SetError(Me.tcDetallePorTipo, "Hay al menos un valor de descuento en CERO.")
                    End If
                    Return False
                    Exit Function
                End If

                If Me.rdbPorRepuesto.Checked Then
                    If Not CodigosRepuestosCorrectos() Then
                        Me.ErrErrores.SetError(Me.grdDetallePorRepuesto, "Hay al menos un código de repuesto ingresado que no existe en la base de datos.")
                        Return False
                        Exit Function
                    End If

                    If HayDuplicadosDetalle() Then
                        Me.ErrErrores.SetError(Me.grdDetallePorRepuesto, "Hay al menos un registro duplicado en detalle de promoción")
                        Return False
                        Exit Function
                    End If
                End If

                If Not Me.DescuentosPorRepuestoValidos Then
                    Me.ErrErrores.SetError(Me.grdDetallePorRepuesto, "Hay al menos un descuento que hace que la utilidad sea negativa, valor Incorrecto.")
                    Return False
                    Exit Function
                End If
            End If

            If Me.dtSucursales.Select("Seleccion=1").Length = 0 Then
                Me.ErrErrores.SetError(Me.grdSucursales, "Debe seleccionar al menos una sucursal.")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Funciones usadas en las Validaciones"

#Region "Existen Descuentos en Cero"
    Private Function ExistenDescuentosEnCero() As Boolean
        Try
            If Me.rdbPorRepuesto.Checked Then
                Return Me.dtDetallePorRepuesto.Select("Descuento = 0").Length <> 0
            Else
                Return Me.dtDetalleGlobalTipo.Select("Descuento = 0").Length <> 0
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Descuentos Válidos"
    'Función para validar al dar clic en Aceptar
    Private Function DescuentosPorRepuestoValidos() As Boolean
        Dim dUtilidadN As Decimal
        Dim bDescuentoValido As Boolean = True

        If Me.grdDetallePorRepuesto.Splits(0).Rows.Count <> 0 Then
            For i As Integer = 0 To Me.grdDetallePorRepuesto.Splits(0).Rows.Count - 1
                If Not String.IsNullOrEmpty(Me.grdDetallePorRepuesto.Item(i, eGridRepuesto.Descuento).ToString.Trim) And (Not String.IsNullOrEmpty(Me.grdDetallePorRepuesto.Item(i, eGridRepuesto.Codigo).ToString.Trim)) Then

                    If Not String.IsNullOrEmpty(Me.grdDetallePorRepuesto.Item(i, eGridRepuesto.UtilidadN).ToString.Trim) Then
                        dUtilidadN = Me.grdDetallePorRepuesto.Item(i, eGridRepuesto.UtilidadN).ToString.Trim
                    Else
                        dUtilidadN = 0
                    End If

                    If dUtilidadN < 0 Then
                        bDescuentoValido = False
                    End If
                End If
            Next
        End If
        Return bDescuentoValido
    End Function
#End Region

#Region "Codigos Repuestos Correctos"
    'Verifica si todos los códigos ingresados son correctos
    Private Function CodigosRepuestosCorrectos() As Integer
        Dim bExiste As Boolean = True

        If Me.grdDetallePorRepuesto.Splits(0).Rows.Count <> 0 Then
            For i As Integer = 0 To Me.grdDetallePorRepuesto.Splits(0).Rows.Count - 2
                If Not ExisteCodigoRepuesto(Me.grdDetallePorRepuesto.Item(i, eGridRepuesto.Codigo).ToString.Trim) Then
                    bExiste = False
                End If
            Next
        End If
        Return bExiste
    End Function
#End Region

#Region "Buscar duplicados en detalle por repuesto"
    Function HayDuplicadosDetalle() As Boolean
        Dim iCont As Integer = 0
        Dim iValorTemp As String
        Dim bResultado As Boolean = False

        If Me.grdDetallePorRepuesto.Splits(0).Rows.Count Then
            For i As Integer = 0 To Me.grdDetallePorRepuesto.Splits(0).Rows.Count - 1
                If Not String.IsNullOrEmpty(Me.grdDetallePorRepuesto.Item(i, 0).ToString) Then
                    iValorTemp = Me.grdDetallePorRepuesto.Item(i, 0).ToString
                End If

                iCont = 0
                For j As Integer = 0 To Me.grdDetallePorRepuesto.Splits(0).Rows.Count - 1
                    If Not String.IsNullOrEmpty(Me.grdDetallePorRepuesto.Item(j, 0).ToString) Then
                        If (Me.grdDetallePorRepuesto.Item(j, 0).ToString) = iValorTemp Then
                            iCont = iCont + 1
                        End If
                    End If
                Next
                If iCont >= 2 Then
                    bResultado = True
                    Exit For
                End If
            Next
        End If

        Return bResultado
    End Function
#End Region

#End Region

#End Region

#Region "Formateo de Grid Edición - Consulta"

#Region "Para edición"
    Private Sub FormatearLosGridDetalleParaEdicion()
        '-- ======== Grid por Repuesto ===================
        Me.FormatearGridPorRepuesto(EDICION)
        '-- ============= Grid Global por tipo ============   
        Me.FormatearGridGlobalTipo(EDICION)
        ''-- ============= Grid sucursales ============
        Me.FormatearGridSucursales(EDICION)
    End Sub

#End Region

#Region "Para Consulta"
    Private Sub FormatearLosGridDetalleParaConsulta()
        '-- ======== Grid por Repuesto ===================
        Me.FormatearGridPorRepuesto(CONSULTA)
        '-- ============= Grid Global por tipo ============   
        Me.FormatearGridGlobalTipo(CONSULTA)
        ''-- ============= Grid sucursales ============
        Me.FormatearGridSucursales(CONSULTA)
    End Sub
#End Region

#Region "Formateo de Grid Individuales"

    Private Sub FormatearGridPorRepuesto(ByVal TipoOperacion As Integer)
        Select Case TipoOperacion
            Case EDICION
                With Me.grdDetallePorRepuesto
                    .Columns("objRepuestoID").DataWidth = 10
                    .Columns("objRepuestoID").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None

                    .Columns("DescripcionCorta").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
                    .Columns("DescripcionCorta").DataWidth = SivRepuestos.GetMaxLength("DescripcionCorta")
                    .Columns("DescripcionCorta").Editor = Me.cmbDescripcionRepuestos

                    .Columns("Descuento").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
                    .Columns("Descuento").DataWidth = 3
                    .Columns("Descuento").Editor = Me.cneDescuento

                    .Splits(0).DisplayColumns("UtilidadN").AllowFocus = False
                    .Splits(0).DisplayColumns("PrecioN").AllowFocus = False

                    .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
                    .FilterBar = False
                    .AllowSort = False
                    .AllowColMove = False
                    .AllowUpdate = True
                    .AllowAddNew = True
                    .EmptyRows = False 'no mostrar más filas después de la última
                    .Refresh()
                End With
            Case CONSULTA
                With Me.grdDetallePorRepuesto
                    .Splits(0).DisplayColumns("objRepuestoID").Style.BackColor = .Splits(0).DisplayColumns("ExistenciaT").Style.BackColor
                    .Splits(0).DisplayColumns("objRepuestoID").Locked = True

                    .Splits(0).DisplayColumns("DescripcionCorta").Style.BackColor = .Splits(0).DisplayColumns("ExistenciaT").Style.BackColor
                    .Splits(0).DisplayColumns("DescripcionCorta").Locked = True
                    .Splits(0).DisplayColumns("Descuento").Style.BackColor = .Splits(0).DisplayColumns("ExistenciaT").Style.BackColor

                    .Columns("Descuento").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
                    .Columns("DescripcionCorta").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None

                    .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
                    .FilterBar = False
                    '.AllowAddNew = False
                    .AllowUpdate = False
                    .AllowDelete = False
                    .AllowColMove = False
                    '.AllowColSelect = False
                    .AllowSort = False
                    .AllowFilter = False
                    .RecordSelectors = False
                    .EmptyRows = False 'no mostrar más filas vacías después de la última
                    .Refresh()
                End With
        End Select

    End Sub

    Private Sub FormatearGridGlobalTipo(ByVal TipoOperacion As Integer)
        Select Case TipoOperacion
            Case EDICION
                With Me.grdDetalleGlobalTipo
                    .Splits(0).DisplayColumns("objTipoRepuestoID").Visible = False
                    .Columns("TipoRepuesto").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
                    .Columns("TipoRepuesto").Editor = Me.cmbTiposRepuestos

                    .Columns("Descuento").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
                    .Columns("Descuento").DataWidth = 3
                    .Columns("Descuento").Editor = Me.cneDescuentoTipo
                    .Splits(0).DisplayColumns("RepuestosActivos").Locked = True

                    .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
                    .FilterBar = False
                    .AllowSort = False
                    .AllowColMove = False
                    .AllowUpdate = True
                    .AllowAddNew = True
                    .EmptyRows = False 'no mostrar más filas después de la última
                    .Refresh()
                End With
            Case CONSULTA
                With Me.grdDetalleGlobalTipo
                    .Splits(0).DisplayColumns("objTipoRepuestoID").Visible = False
                    .Columns("TipoRepuesto").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
                    .Splits(0).DisplayColumns("TipoRepuesto").Style.BackColor = .Splits(0).DisplayColumns("RepuestosActivos").Style.BackColor

                    .Columns("Descuento").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
                    .Splits(0).DisplayColumns("Descuento").Style.BackColor = .Splits(0).DisplayColumns("RepuestosActivos").Style.BackColor
                    .Splits(0).DisplayColumns("Descuento").Locked = True
                    .Splits(0).DisplayColumns("RepuestosActivos").AllowFocus = False
                    .Splits(0).DisplayColumns("RepuestosActivos").Button = False

                    .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
                    .FilterBar = False
                    '.AllowAddNew = False
                    .AllowUpdate = False
                    .AllowDelete = False
                    .AllowColMove = False
                    '.AllowColSelect = False
                    .AllowSort = False
                    .AllowFilter = False
                    .RecordSelectors = False
                    .EmptyRows = False 'no mostrar más filas vacías después de la última
                    .Refresh()
                End With
        End Select
    End Sub

    Private Sub FormatearGridSucursales(ByVal TipoOperacion As Integer)
        Select Case TipoOperacion
            Case EDICION
                With Me.grdSucursales
                    .Columns("Codigo").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None
                    .Columns("Nombre").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.None

                    .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                    .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
                    .FilterBar = False
                    .AllowSort = False
                    .AllowColMove = False
                    .EmptyRows = False 'no mostrar más filas después de la última
                    .Refresh()
                End With
            Case CONSULTA
                With Me.grdSucursales
                    .Splits(0).DisplayColumns("StbTiendaID").Visible = False
                    .Splits(0).DisplayColumns("Seleccion").Style.BackColor = .Splits(0).DisplayColumns("Codigo").Style.BackColor
                    .Splits(0).DisplayColumns("Seleccion").Locked = True

                    .MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee
                    .FilterBar = False
                    .AllowSort = True
                    .AllowUpdate = False
                    .AllowDelete = False
                    .AllowColMove = False
                    .AllowFilter = False
                    .RecordSelectors = False
                    .EmptyRows = False 'no mostrar más filas después de la última
                    .Refresh()
                End With
        End Select

    End Sub

#End Region

#End Region

#Region "Seleccionar Todas Sucursales"
    Private Sub SeleccionarTodasSucursales(ByVal blnValor As Boolean)
        For Each fila As DataRow In Me.dtSucursales.Rows
            fila("Seleccion") = blnValor
        Next
        Me.dtSucursales.AcceptChanges()
    End Sub
#End Region

#Region "Seleccionar Sucursales por Barra Espaciadora"
    Private Sub grdSucursales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdSucursales.KeyDown
        'Si no es una tecla direccional
        Dim blnMarcado As Boolean
        If (e.KeyCode <> Keys.Left And e.KeyCode <> Keys.Right And e.KeyCode <> Keys.Up And e.KeyCode <> Keys.Down) Then
            If e.KeyCode = Keys.Space Then 'si es espacio entonces marcar o desmarcar
                blnMarcado = Me.dtSucursales.Rows(Me.grdSucursales.RowBookmark(Me.grdSucursales.Row))("Seleccion")
                Me.dtSucursales.Rows(Me.grdSucursales.RowBookmark(Me.grdSucursales.Row))("Seleccion") = Not blnMarcado
            End If
            e.SuppressKeyPress = True
        End If
    End Sub
#End Region

#End Region

#Region "Eventos de controles"

#Region "Formulario"
    Private Sub frmSfaPromocionesEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Me.HuboCambioPromocion Or Me.HuboCambioSucursales) And (Me.TypeGui = AGREGACION Or Me.TypeGui = EDICION) And (Me.DialogResult <> Windows.Forms.DialogResult.OK) Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub frmSfaPromocionesEdit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.TypeGui = CONSULTA Then
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmSfaPromocionesEdit_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If Me.TypeGui = AGREGACION Then
            Me.txtDescripcion.Focus()
        ElseIf Me.TypeGui = EDICION Then
            Me.dtpFechaFin.Focus()
        End If
    End Sub
#End Region

#Region "Botones"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Select Case Me.TypeGui
            Case AGREGACION
                If Me.Validaciones() Then
                    If Me.GuardarPromocion() Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            Case EDICION
                If (Me.HuboCambioPromocion Or Me.HuboCambioSucursales) Then
                    If Me.Validaciones() Then
                        If Me.EditarPromocion() Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    End If
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                End If
        End Select

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
#End Region

#Region "Controles de Edición de datos"
    Private Sub chkTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodas.CheckedChanged
        Me.SeleccionarTodasSucursales(Me.chkTodas.Checked)
        Me.ErrErrores.Clear()
        Me.HuboCambioSucursales = True
    End Sub
    Private Sub rdbPorRepuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPorRepuesto.CheckedChanged
        Me.tcDetallePorRepuesto.Visible = True
        Me.tcDetallePorTipo.Visible = False
        Me.CargarDetalleGlobalTipo()
        Me.ErrErrores.Clear()
    End Sub
    Private Sub rdbGlobalTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbGlobalTipo.CheckedChanged
        Me.CargarDetallePorRepuesto()
        Me.tcDetallePorTipo.Location = Me.tcDetallePorRepuesto.Location
        Me.tcDetallePorTipo.Visible = True
        Me.tcDetallePorRepuesto.Visible = False
        Me.ErrErrores.Clear()
    End Sub

    Private Sub dtpFechaFin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaFin.TextChanged
        Me.HuboCambioPromocion = True
        Me.ErrErrores.Clear()
    End Sub

    Private Sub grdSucursales_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdSucursales.Change
        Me.HuboCambioSucursales = True
        Me.ErrErrores.Clear()
    End Sub
#End Region

#End Region

#Region "Validaciones en GRID Por Repuesto"

#Region "Existe Código Repuesto"
    Private Function ExisteCodigoRepuesto(ByVal sCodigo As String) As Boolean
        Dim bResultado As Boolean = False
        Try
            If Not String.IsNullOrEmpty(sCodigo) Then
                If (Not sCodigo.Equals("1")) And (Not sCodigo.Equals("2")) And (Not sCodigo.Equals("3")) Then
                    bResultado = SivRepuestos.RetrieveDT("SivRepuestoID = '" + sCodigo & "'").Rows.Count <> 0
                End If
            End If
            Return bResultado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Buscar duplicados en detalle por Repuesto"
    Function DuplicadoEnDetalle(ByVal sIdRepuesto As String, ByVal blnDesdeDescripcion As Boolean) As Boolean
        Dim iCont As Integer = 0
        Dim iValorTemp As String
        Dim bResultado As Boolean = False
        Try

            iValorTemp = (sIdRepuesto)

            If Me.grdDetallePorRepuesto.Splits(0).Rows.Count <> 0 Then
                For i As Integer = 0 To Me.grdDetallePorRepuesto.Splits(0).Rows.Count - 1
                    If Not String.IsNullOrEmpty(Me.grdDetallePorRepuesto.Item(i, 0).ToString) Then
                        If (Me.grdDetallePorRepuesto.Item(i, 0).ToString) = iValorTemp Then
                            iCont = iCont + 1
                        End If
                    End If
                Next
            End If
            'Si el llamado viene desde la columna Descripción solo verificar si hay un registro de repuesto
            If Not blnDesdeDescripcion Then
                If iCont >= 2 Then
                    bResultado = True
                End If
            Else
                If iCont >= 1 Then
                    bResultado = True
                End If
            End If
            Return bResultado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Function
#End Region

#Region "Elminar Detalle Grid Por Repuesto"
    Private Function EliminarDetalleGridPorRepuesto() As Boolean
        Dim bResultado As Boolean = False
        If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
            Try
                'Me.dtDetalleTransferencia.DefaultView.Delete(Me.grdDetalleTransferencia.Row)
                Me.grdDetallePorRepuesto.Delete(Me.grdDetallePorRepuesto.Row)
                Me.grdDetallePorRepuesto.UpdateData()
                Me.HuboCambioPromocion = True
                bResultado = True
            Catch ex As Exception 'Si hay error al eliminar, que no haga nada.
            End Try
            Return bResultado
        End If
    End Function
#End Region

#Region "Inicializar datos fila detalle"
    Private Sub InicializarFilaDetallePorRepuesto()
        'Inicializar valores
        With Me.grdDetallePorRepuesto
            .Columns("objRepuestoID").Value = String.Empty
            .Columns("DescripcionCorta").Value = String.Empty
            .Columns("ExistenciaT").Value = 0
            .Columns("CostoProm").Value = 0
            .Columns("Precio").Value = 0
            .Columns("UtilidadActual").Value = 0
            .Columns("Descuento").Value = 0
            .Columns("PrecioN").Value = 0
            .Columns("UtilidadN").Value = 0
            .Refresh()
        End With
    End Sub

#End Region

#Region "Cargar Fila Detalle Por Repuesto"
    Private Function CargarFilaDetallePorRepuesto(ByVal sIdRepuesto As String) As Boolean
        Dim objSivBodega As New SivBodegaRepuestos
        Dim objSivRepuesto As New SivRepuestos
        Dim blnExisteEnBodega As Boolean
        Dim bResultado As Boolean = False

        Try
            If Not String.IsNullOrEmpty(sIdRepuesto) Then
                objSivRepuesto.Retrieve(sIdRepuesto)
                blnExisteEnBodega = objSivBodega.Retrieve(sIdRepuesto, Me.IdSitioSession)
                If blnExisteEnBodega Then
                    'Copiar datos en la fila del grid detalle seleccionada
                    If objSivRepuesto.Activo Then
                        Me.cmbDescripcionRepuestos.SelectedValue = sIdRepuesto
                        With Me.grdDetallePorRepuesto
                            .Columns("objRepuestoID").Value = sIdRepuesto
                            .Columns("DescripcionCorta").Value = Me.cmbDescripcionRepuestos.SelectedText
                            .Columns("ExistenciaT").Value = objSivBodega.Cantidad
                            .Columns("CostoProm").Value = objSivRepuesto.CostoProm
                            .Columns("Precio").Value = objSivRepuesto.Precio
                            .Columns("UtilidadActual").Value = objSivRepuesto.Precio - objSivRepuesto.CostoProm
                            .Columns("Descuento").Value = 0
                            .Columns("PrecioN").Value = (objSivRepuesto.Precio - (objSivRepuesto.Precio * .Columns("Descuento").Value))
                            .Columns("UtilidadN").Value = (.Columns("PrecioN").Value - objSivRepuesto.CostoProm)
                            .Refresh()
                        End With
                        'Me.grdDetalleTransferencia.UpdateData()
                        bResultado = True
                        Me.HuboCambioPromocion = True
                    Else
                        MsgBox("El repuesto ingresado no está activo.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.InicializarFilaDetallePorRepuesto()
                    End If
                Else
                    MsgBox("El repuesto (" + objSivRepuesto.DescripcionCorta + _
                           ") seleccionado aún no ha sido registrado en la Bodega en sesión.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.InicializarFilaDetallePorRepuesto()
                    If Me.grdDetallePorRepuesto.Col <> eGridRepuesto.Codigo Then
                        SendKeys.Send("{LEFT}") 'Mover celda hacia izquierda y luego a derecha para reinicializar columna [Descripción]
                        SendKeys.Send("{RIGHT}")
                    End If
                    'Me.grdDetalleTransferencia.EditActive = False
                End If
            End If
            Return bResultado

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Validación desde la columna [Código]"
    'Función que verifica el código de repuesto (si existe, si está repetido) y lo carga en el registro de detalle.
    'cuando se está trabajando desde la columna [Código]
    Private Function VerificarCargarRepuestoDesdeColumnaCodigo(ByVal sCodigoRepuesto As String) As Boolean
        Dim bCargado As Boolean = False

        If Not String.IsNullOrEmpty(sCodigoRepuesto) Then
            If Me.ExisteCodigoRepuesto(sCodigoRepuesto) Then
                If Me.DuplicadoEnDetalle(sCodigoRepuesto, False) Then
                    MsgBox("El Repuesto seleccionado ya está en la lista", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Me.InicializarFilaDetallePorRepuesto()
                    Me.grdDetallePorRepuesto.Focus()
                    Me.grdDetallePorRepuesto.Col = eGridRepuesto.Codigo
                    SendKeys.Send("{LEFT}")
                    SendKeys.Send("{LEFT}")
                    bCargado = False
                Else
                    'Verificar si ya está en promoción
                    If Not Me.RepuestoEnPromocion(sCodigoRepuesto) Then
                        If Me.CargarFilaDetallePorRepuesto(sCodigoRepuesto) Then
                            Me.grdDetallePorRepuesto.Col = eGridRepuesto.Descuento
                            SendKeys.Send("{RIGHT}")
                            bCargado = True
                        Else
                            bCargado = False
                        End If
                    Else
                        'Dim iSfaPromocionID As Integer = clsConsultas.ObtenerConsultaGeneral("TOP 1 objPromocionID", "dbo.vwSivRepuestosEnPromocion", "Activo=1 AND objRepuestoID=" + sCodigoRepuesto)
                        MsgBox("El repuesto seleccionado ya está en promoción", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.InicializarFilaDetallePorRepuesto()
                        Me.grdDetallePorRepuesto.Focus()
                        Me.grdDetallePorRepuesto.Col = eGridRepuesto.Codigo
                        SendKeys.Send("{LEFT}")
                        SendKeys.Send("{LEFT}")
                        bCargado = False
                    End If
                End If
            Else
                MsgBox("Código repuesto ingresado no existe", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Me.InicializarFilaDetallePorRepuesto()
                Me.grdDetallePorRepuesto.Focus()
                Me.grdDetallePorRepuesto.Col = eGridRepuesto.Codigo
                SendKeys.Send("{LEFT}")
                SendKeys.Send("{LEFT}")
                bCargado = False
            End If
        End If
        Return bCargado
    End Function
#End Region

#Region "Validar columna [descuento] del grid por repuesto"
    Private Function DescuentoValido() As Boolean
        Dim blnValido As Boolean = True
        If Not UltimaFilaGridRepuesto() Then
            If (IsDBNull(Me.grdDetallePorRepuesto.Columns("Descuento").Value)) And Me.grdDetallePorRepuesto.Columns("Descuento").Value.ToString.Trim.Length = 0 Then
                blnValido = False
                Exit Function
            End If

            If (Me.grdDetallePorRepuesto.Columns("Descuento").Value <= 0) Then
                Me.ErrErrores.SetError(Me.tcDetallePorRepuesto, "Debe escribir un valor de descuento mayor que cero.")
                blnValido = False
                Exit Function
            End If

            If (Not IsDBNull(Me.grdDetallePorRepuesto.Columns("UtilidadN").Value)) And Me.grdDetallePorRepuesto.Columns("UtilidadN").Value.ToString.Trim.Length <> 0 Then
                If (Me.grdDetallePorRepuesto.Columns("UtilidadN").Value < 0) Then
                    Me.ErrErrores.SetError(Me.tcDetallePorRepuesto, "No se permite dar descuentos que den como resultado un precio menor al costo.")
                    blnValido = False
                    Exit Function
                End If
            End If
        End If

        Return blnValido
    End Function
#End Region

#Region "Verificar Código de Repuesto en Promoción activa"
    Public Function RepuestoEnPromocion(ByVal sRepuestoID As String) As Boolean
        Dim blnEnPromo As Boolean = False
        Dim strSQL, strCampos, strFiltro As String
        Dim dtDatos As DataTable
        strCampos = "COUNT(SfaPromocionID) as CantidadPromociones"
        strFiltro = "Activo=1 and objRepuestoID='" + sRepuestoID + "'"
        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwSivRepuestosEnPromocion", strFiltro)

        dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

        If dtDatos.DefaultView.Item(0)("CantidadPromociones") <> 0 Then
            blnEnPromo = True
        End If

        Return blnEnPromo
    End Function
#End Region

#Region "Otras funciones usadas en el grid por repuesto"
    Private Function HayValorEn(ByVal NombreColumna As String)
        Return Not (IsDBNull(Me.grdDetallePorRepuesto.Columns(NombreColumna).Value) Or Me.grdDetallePorRepuesto.Columns(NombreColumna).Value.ToString.Trim.Length = 0)
    End Function

    Private Function UltimaFilaGridRepuesto() As Boolean
        Return Me.grdDetallePorRepuesto.Row = Me.grdDetallePorRepuesto.Splits(0).Rows.Count - 1
    End Function

    Private Function EstaEnColumnaEditable() As Boolean
        Return (Me.grdDetallePorRepuesto.Col = eGridRepuesto.Codigo Or Me.grdDetallePorRepuesto.Col = eGridRepuesto.Descripcion Or Me.grdDetallePorRepuesto.Col = eGridRepuesto.Descuento)
    End Function

    Private Sub EditarColumna(ByVal ColumnIndex As Integer)
        Select Case ColumnIndex
            Case eGridRepuesto.Descuento
                If Not Me.HayValorEn("Precio") Then
                    Me.grdDetallePorRepuesto.Columns("Precio").Value = 0
                End If
                If Not Me.HayValorEn("CostoProm") Then
                    Me.grdDetallePorRepuesto.Columns("CostoProm").Value = 0
                End If
                If Me.HayValorEn("Descuento") Then
                    If Me.grdDetallePorRepuesto.Columns("Descuento").Value > 100 Then
                        Me.grdDetallePorRepuesto.Columns("Descuento").Value = 0
                    End If
                    If Me.HayValorEn("Precio") Then
                        Me.grdDetallePorRepuesto.Columns("PrecioN").Value = (Me.grdDetallePorRepuesto.Columns("Precio").Value - (Me.grdDetallePorRepuesto.Columns("Precio").Value * Me.grdDetallePorRepuesto.Columns("Descuento").Value))
                        Me.grdDetallePorRepuesto.Columns("UtilidadN").Value = (Me.grdDetallePorRepuesto.Columns("PrecioN").Value - (Me.grdDetallePorRepuesto.Columns("CostoProm").Value))
                    End If
                Else
                    If Me.HayValorEn("Precio") Then
                        Me.grdDetallePorRepuesto.Columns("PrecioN").Value = Me.grdDetallePorRepuesto.Columns("Precio").Value
                        Me.grdDetallePorRepuesto.Columns("UtilidadN").Value = (Me.grdDetallePorRepuesto.Columns("PrecioN").Value - (Me.grdDetallePorRepuesto.Columns("CostoProm").Value))
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "Mover Foco Grid Tipo"
    Private Sub MoverFocoGridRepuesto(ByVal fila As Integer, ByVal columna As Integer)
        Me.grdDetallePorRepuesto.Focus()
        Me.grdDetallePorRepuesto.Row = fila
        Me.grdDetallePorRepuesto.Col = columna
    End Sub
#End Region

#Region "Eventos Grid por repuesto"

#Region "AfterColUpdate"
    Private Sub grdDetallePorRepuesto_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetallePorRepuesto.AfterColUpdate
        If e.Column.DataColumn.Value.ToString.Trim.Length <> 0 Then
            Select Case e.ColIndex
                Case eGridRepuesto.Codigo 'Validar columna [código] 
                    Me.VerificarCargarRepuestoDesdeColumnaCodigo(e.Column.DataColumn.Value.ToString.Trim)
                Case eGridRepuesto.Descripcion
                    If DuplicadoEnDetalle(Me.cmbDescripcionRepuestos.SelectedValue, False) Then
                        MsgBox("El Repuesto seleccionado ya está en la lista", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.InicializarFilaDetallePorRepuesto()
                    Else
                        Me.CargarFilaDetallePorRepuesto(Me.cmbDescripcionRepuestos.SelectedValue.ToString)
                    End If
                Case eGridRepuesto.Descuento 'Validar columna [Descuento]
                    Me.EditarColumna(eGridRepuesto.Descuento)
                    Me.DescuentoValido()
            End Select
        End If
    End Sub
#End Region

#Region "KeyPress"
    Private Sub grdDetallePorRepuesto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdDetallePorRepuesto.KeyPress
        'Try
        '    If Me.TypeGui = AGREGACION Then
        '        'No permitir letras en columna [código]
        '        If Me.grdDetallePorRepuesto.Col = eGridRepuesto.Codigo Then
        '            If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
        '                e.KeyChar = Chr(0)
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub
#End Region

#Region "KeyDown"
    Private Sub grdDetallePorRepuesto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetallePorRepuesto.KeyDown
        If Me.TypeGui <> AGREGACION Then
            e.SuppressKeyPress = True
            Exit Sub
        End If

        '========== Columna Código ====================================================
        If Me.grdDetallePorRepuesto.Col = eGridRepuesto.Codigo Then
            If e.KeyCode = Keys.Enter Then
                Me.grdDetallePorRepuesto.Col = eGridRepuesto.Descuento
            End If
        End If

        '======== Columna Descuento =================================================
        If Not UltimaFilaGridRepuesto() Then
            If Me.grdDetallePorRepuesto.Col = eGridRepuesto.Descuento Then
                Me.EditarColumna(eGridRepuesto.Descuento)
            End If
        End If

        '=============== Validar borrado de filas al presionar delete cuando el grid no esté en modo edición =============
        If e.KeyCode = Keys.Delete And (Not Me.grdDetallePorRepuesto.EditActive) Then
            'Si el primer registro está cargado
            If Me.grdDetallePorRepuesto.Row = 0 Then
                If Me.grdDetallePorRepuesto.Columns("objRepuestoID").Value.ToString.Trim.Length <> 0 And e.KeyCode <> Keys.Escape Then
                    If Not Me.UltimaFilaGridRepuesto Then
                        If Me.EliminarDetalleGridPorRepuesto Then
                            Me.dtDetallePorRepuesto.DefaultView.AddNew()
                        End If
                    End If
                End If
                Exit Sub
            End If
            'Si el registro seleccionado está vacío eliminar sin preguntar
            If Me.grdDetallePorRepuesto.RowCount > 1 Then
                If Me.grdDetallePorRepuesto.Columns("objRepuestoID").Text.ToString.Trim.Length = 0 Then
                    Try
                        Me.grdDetallePorRepuesto.Delete(Me.grdDetallePorRepuesto.Row)
                    Catch 'si ocurre error al eliminar que no haga nada.
                    End Try
                ElseIf e.KeyCode = Keys.Delete Then
                    Me.EliminarDetalleGridPorRepuesto()
                    Exit Sub
                End If
            End If
        End If '------------- if e.keycode = keys.Delete ... ------------------------------------

        ''============ Al moverse con teclas direccionales ============================================================
        'Si presiona direccional hacia abajo o hacia arriba y no se ha escrito la cantidad solicitada o está es cero entonces bloquear

        If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And Me.grdDetallePorRepuesto.Columns("objRepuestoID").Value.ToString.Trim.Length <> 0 Then
            If Not Me.DescuentoValido Then
                e.SuppressKeyPress = True
            End If
        ElseIf (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And EstaEnColumnaEditable() Then
            If Me.grdDetallePorRepuesto.Columns("objRepuestoID").Value.ToString.Trim.Length = 0 And Not UltimaFilaGridRepuesto() Then
                Try
                    If Me.grdDetallePorRepuesto.Splits(0).Rows.Count > 2 Then 'Si tiene más de dos filas
                        Me.grdDetallePorRepuesto.Delete(Me.grdDetallePorRepuesto.Row)
                    End If
                Catch 'si ocurre error al eliminar que no haga nada.
                End Try
            End If
        End If
    End Sub
#End Region

#Region "Enter"
    Private Sub grdDetallePorRepuesto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetallePorRepuesto.Enter
        MoverFocoGridRepuesto(0, 0)
    End Sub
#End Region

#Region "Controles de columnas del grid por repuesto"
    Private Sub cneDescuento_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cneDescuento.Validating
        Try
            If Not IsDBNull(Me.cneDescuento.Value) Then
                If Me.cneDescuento.Value > 100 Then
                    Me.cneDescuento.Value = 0.0
                End If
            End If
        Catch ex As Exception
            Me.cneDescuento.Value = 0.0
        End Try
    End Sub

    Private Sub cmbDescripcionRepuestos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDescripcionRepuestos.SelectedValueChanged
        If Not Me.cmbDescripcionRepuestos.Text.Trim.Length = 0 Then
            Me.grdDetallePorRepuesto.Columns("objRepuestoID").Value = Me.cmbDescripcionRepuestos.SelectedValue
        End If
    End Sub

#End Region

#End Region

#End Region

#Region "Validaciones en GRID TipoRepuesto"

#Region "Buscar duplicados en detalle por Tipo"
    Function DuplicadoEnDetallePorTipo(ByVal sObjTipoRepuesto As String) As Boolean
        Dim iCont As Integer = 0
        Dim iValorTemp As Integer
        Dim bResultado As Boolean = False
        Try

            iValorTemp = Integer.Parse(sObjTipoRepuesto)

            If Me.grdDetalleGlobalTipo.Splits(0).Rows.Count <> 0 Then
                For i As Integer = 0 To Me.grdDetalleGlobalTipo.Splits(0).Rows.Count - 1
                    If Not String.IsNullOrEmpty(Me.grdDetalleGlobalTipo.Item(i, eGridTipo.objTipoRepuestoID).ToString) Then
                        If Int32.Parse(Me.grdDetalleGlobalTipo.Item(i, eGridTipo.objTipoRepuestoID).ToString) = iValorTemp Then
                            iCont = iCont + 1
                        End If
                    End If
                Next
            End If

            If iCont >= 2 Then
                bResultado = True
            End If

            Return bResultado
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Elminar Detalle Grid Por Tipo"
    Private Function EliminarDetalleGridPorTipo() As Boolean
        Dim bResultado As Boolean = False
        If MsgBox("¿Confirma que desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
            Try
                Me.grdDetalleGlobalTipo.Delete(Me.grdDetalleGlobalTipo.Row)
                Me.grdDetalleGlobalTipo.UpdateData()
                Me.HuboCambioPromocion = True
                bResultado = True
            Catch ex As Exception 'Si hay error al eliminar, que no haga nada.
            End Try
            Return bResultado
        End If
    End Function

#End Region

#Region "Inicializar datos fila detalle Tipo"
    Private Sub InicializarFilaDetallePorTipo()
        'Inicializar valores
        With Me.grdDetalleGlobalTipo
            .Columns("objTipoRepuestoID").Value = 0
            .Columns("TipoRepuesto").Value = String.Empty
            .Columns("Descuento").Value = 0
            .Columns("RepuestosActivos").Value = False
            .Refresh()
        End With
    End Sub

#End Region

#Region "Cargar Datos de tipo repuesto"
    Private Function VerificarCargarFilaTipoRepuesto(ByVal sObjTipoRepuesto As String) As Boolean
        Dim bCargado As Boolean = False

        If Not String.IsNullOrEmpty(sObjTipoRepuesto) Then
            If Me.DuplicadoEnDetallePorTipo(sObjTipoRepuesto) Then
                MsgBox("El Tipo de Repuesto seleccionado ya está en la lista", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                InicializarFilaDetallePorTipo()
                Me.grdDetalleGlobalTipo.Focus()
                Me.grdDetalleGlobalTipo.Col = eGridTipo.TipoRepuesto
                SendKeys.Send("{LEFT}")
                bCargado = False
            Else
                'Verificar si ya está en promoción
                If Not Me.TipoRepuestoEnPromocion(sObjTipoRepuesto) Then
                    If Me.CargarFilaDetallePorTipo(sObjTipoRepuesto) Then
                        Me.grdDetalleGlobalTipo.Col = eGridTipo.Descuento
                        'SendKeys.Send("{RIGHT}")
                        bCargado = True
                    Else
                        bCargado = False
                    End If
                Else
                    'Dim iSfaPromocionID As Integer = clsConsultas.ObtenerConsultaGeneral("TOP 1 objPromocionID", "dbo.vwSivRepuestosEnPromocion", "Activo=1 AND objRepuestoID=" + sCodigoRepuesto)
                    MsgBox("El Tipo de repuesto seleccionado ya está en promoción", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    InicializarFilaDetallePorTipo()
                    Me.grdDetalleGlobalTipo.Focus()
                    Me.grdDetalleGlobalTipo.Col = eGridTipo.TipoRepuesto
                    SendKeys.Send("{LEFT}")
                    bCargado = False
                End If
            End If
        End If
        Return bCargado
    End Function
#End Region

#Region "Cargar Fila Detalle Por Tipo"
    Private Function CargarFilaDetallePorTipo(ByVal sObjTipoRepuesto As String) As Boolean
        Dim bResultado As Boolean = False
        Dim dtDatos As DataTable

        Try
            If Not String.IsNullOrEmpty(sObjTipoRepuesto) Then
                dtDatos = Me.ObtenerRepuestosEnPromocion(sObjTipoRepuesto)
                Me.grdDetalleGlobalTipo.Columns("RepuestosActivos").Value = dtDatos.Rows.Count <> 0
                Me.grdDetalleGlobalTipo.UpdateData()
                Me.grdDetalleGlobalTipo.Refresh()
                bResultado = True
                Me.HuboCambioPromocion = True
            End If

            Return bResultado

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
#End Region

#Region "Verificar tipo de Repuesto en Promoción activa"
    Public Function TipoRepuestoEnPromocion(ByVal sObjTipoRepuesto As String) As Boolean
        Dim blnEnPromo As Boolean = False
        Dim strSQL, strCampos, strFiltro As String
        Dim dtDatos As DataTable
        strCampos = "COUNT(SfaPromocionID) as CantidadPromociones"
        strFiltro = "Activo=1 and objTipoRepuestoID=" + sObjTipoRepuesto
        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "dbo.vwSivRepuestosEnPromocion", strFiltro)

        dtDatos = SqlHelper.ExecuteQueryDT(strSQL)

        If dtDatos.DefaultView.Item(0)("CantidadPromociones") <> 0 Then
            blnEnPromo = True
        End If

        Return blnEnPromo
    End Function
#End Region

#Region "Obtener Repuestos del tipo seleccionado en promoción"
    Private Function ObtenerRepuestosEnPromocion(ByVal sObjTipoRepuesto As String) As DataTable
        Dim strSQL, strCampos As String

        strCampos = "objRepuestoID, Descripcion, CONVERT(VARCHAR, FechaInicio,103) AS FechaInicio ,CONVERT(VARCHAR,FechaFin,103) AS FechaFin, Descuento"
        strSQL = clsConsultas.ObtenerConsultaGeneral(strCampos, "fnGetRepuestosEnPromocionByTipo(" + sObjTipoRepuesto + ")")

        Return SqlHelper.ExecuteQueryDT(strSQL)
    End Function

#End Region

#Region "Mostrar consulta descuentos"
    Private Sub MostrarConsultaDescuento()
        Dim objForm As New frmConsultaDescuentoPromociones
        objForm.Datos = Me.ObtenerRepuestosEnPromocion(Me.grdDetalleGlobalTipo.Columns("objTipoRepuestoID").Value)
        objForm.ShowDialog()
    End Sub
#End Region

#Region "Ultima Fila Grid Tipo"
    Private Function UltimaFilaGridTipo() As Boolean
        Return Me.grdDetalleGlobalTipo.Row = Me.grdDetalleGlobalTipo.Splits(0).Rows.Count - 1
    End Function
#End Region

#Region "Validar columna [descuento] del grid por repuesto"
    Private Function DescuentoValidoGridTipo() As Boolean
        Dim blnValido As Boolean = True
        If Not UltimaFilaGridTipo() Then
            If (IsDBNull(Me.grdDetalleGlobalTipo.Columns("Descuento").Value)) And Me.grdDetalleGlobalTipo.Columns("Descuento").Value.ToString.Trim.Length = 0 Then
                blnValido = False
                Exit Function
            End If

            If (Me.grdDetalleGlobalTipo.Columns("Descuento").Value <= 0) Then
                Me.ErrErrores.SetError(Me.tcDetallePorTipo, "Debe escribir un valor de descuento mayor que cero.")
                blnValido = False
                Exit Function
            End If
        End If

        Return blnValido
    End Function
#End Region

#Region "Mover Foco Grid Tipo"
    Private Sub MoverFocoGridTipo(ByVal fila As Integer, ByVal columna As Integer)
        Me.grdDetalleGlobalTipo.Focus()
        Me.grdDetalleGlobalTipo.Row = fila
        Me.grdDetalleGlobalTipo.Col = columna
    End Sub
#End Region

#Region "Eventos Grid por tipo"

#Region "KeyDown"
    Private Sub grdDetalleGlobalTipo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDetalleGlobalTipo.KeyDown
        If Me.TypeGui <> AGREGACION Then
            e.SuppressKeyPress = True
            Exit Sub
        End If

        '=============== Validar borrado de filas al presionar delete cuando el grid no esté en modo edición =============
        If e.KeyCode = Keys.Delete And (Not Me.grdDetalleGlobalTipo.EditActive) Then
            'Si el primer registro está cargado
            If Me.grdDetalleGlobalTipo.Row = 0 Then
                If Me.grdDetalleGlobalTipo.Columns("TipoRepuesto").Value.ToString.Trim.Length <> 0 And e.KeyCode <> Keys.Escape Then
                    If Not Me.UltimaFilaGridTipo Then
                        If Me.EliminarDetalleGridPorTipo Then
                            Me.dtDetalleGlobalTipo.DefaultView.AddNew()
                        End If
                    End If
                End If
                Exit Sub
            End If
            'Si el registro seleccionado está vacío eliminar sin preguntar
            If Me.grdDetalleGlobalTipo.RowCount > 1 Then
                If Me.grdDetalleGlobalTipo.Columns("TipoRepuesto").Text.ToString.Trim.Length = 0 Then
                    Try
                        Me.grdDetalleGlobalTipo.Delete(Me.grdDetalleGlobalTipo.Row)
                    Catch 'si ocurre error al eliminar que no haga nada.
                    End Try
                ElseIf e.KeyCode = Keys.Delete Then
                    Me.EliminarDetalleGridPorTipo()
                    Exit Sub
                End If
            End If
        End If '------------- if e.keycode = keys.Delete ... ------------------------------------

        If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) And Me.grdDetalleGlobalTipo.Columns("TipoRepuesto").Value.ToString.Trim.Length <> 0 Then
            If Not Me.DescuentoValidoGridTipo Then
                e.SuppressKeyPress = True
            End If
        ElseIf (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up) Then
            If Me.grdDetalleGlobalTipo.Columns("TipoRepuesto").Value.ToString.Trim.Length = 0 And Not UltimaFilaGridTipo() Then
                Try
                    If Me.grdDetalleGlobalTipo.Splits(0).Rows.Count > 2 Then 'Si el split tiene más de dos filas
                        Me.grdDetalleGlobalTipo.Delete(Me.grdDetalleGlobalTipo.Row)
                    End If
                Catch 'si ocurre error al eliminar que no haga nada.
                End Try
            End If
        End If

        'Si presiona ENTER y está en la columna de Ver repuestos en promoción
        If (e.KeyCode = Keys.Enter And Me.grdDetalleGlobalTipo.Col = eGridTipo.RepuestosActivos) Then
            Me.VerificarAndMostrarConsultaDescuento(Me.grdDetalleGlobalTipo.Col)
        End If

    End Sub
#End Region

#Region "Enter"
    Private Sub grdDetalleGlobalTipo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDetalleGlobalTipo.Enter
        Me.MoverFocoGridTipo(0, 0)
    End Sub
#End Region

#Region "AfterColUpdate"
    Private Sub grdDetalleGlobalTipo_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalleGlobalTipo.AfterColUpdate
        If e.Column.DataColumn.Value.ToString.Trim.Length <> 0 Then
            Select Case e.ColIndex
                Case eGridTipo.TipoRepuesto  'Validar columna [TipoRepuesto] 
                    Me.VerificarCargarFilaTipoRepuesto(Me.cmbTiposRepuestos.SelectedValue)

                Case eGridRepuesto.Descuento 'Validar columna [Descuento]

            End Select
        End If
    End Sub
#End Region

#Region "ButtonClick"
    Private Sub grdDetalleGlobalTipo_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalleGlobalTipo.ButtonClick
        Me.VerificarAndMostrarConsultaDescuento(e.ColIndex)
    End Sub

    Private Sub VerificarAndMostrarConsultaDescuento(ByVal ColIndex As Integer)
        If ColIndex = eGridTipo.RepuestosActivos Then
            If Not IsDBNull(Me.grdDetalleGlobalTipo.Columns("RepuestosActivos").Value) And (Me.grdDetalleGlobalTipo.Columns("RepuestosActivos").Value.ToString.Trim.Length <> 0) Then
                If Convert.ToBoolean(Me.grdDetalleGlobalTipo.Columns("RepuestosActivos").Value) Then
                    If Me.grdDetalleGlobalTipo.Row <> Me.grdDetalleGlobalTipo.Splits(0).Rows.Count - 1 Then
                        Me.MostrarConsultaDescuento()
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "Controles de columna"
    'Evento del combobox para tipo repuesto
    Private Sub cmbTiposRepuestos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTiposRepuestos.SelectedValueChanged
        If Not Me.cmbTiposRepuestos.Text.Trim.Length = 0 Then
            Me.grdDetalleGlobalTipo.Columns("objTipoRepuestoID").Value = Me.cmbTiposRepuestos.SelectedValue
            Me.grdDetalleGlobalTipo.Columns("Descuento").Value = 0.0
        End If
    End Sub

    'Evento del Numeric Edit para descuento
    Private Sub cneDescuentoTipo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cneDescuentoTipo.Validating
        Try
            If Not IsDBNull(Me.cneDescuentoTipo.Value) Then
                If Me.cneDescuentoTipo.Value > 100 Then
                    Me.cneDescuentoTipo.Value = 0.0
                End If
            End If
        Catch ex As Exception
            Me.cneDescuentoTipo.Value = 0.0
        End Try
    End Sub

#End Region

#End Region

#End Region

#Region "Limpieza de Error provider"
    'Este envento se usa en varios controles que requieren hacer la misma acción
    Private Sub LimpiarErrorProvider(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles txtDescripcion.TextChanged, dtpFechaInicio.TextChanged, _
             grdDetallePorRepuesto.Change, grdDetalleGlobalTipo.Change
        Me.ErrErrores.Clear()
    End Sub

#End Region

#Region "Inhabilitar Controles"
    Private Sub InabilitarControles()

        Me.txtDescripcion.BackColor = Me.txtSfaPromocionID.BackColor
        Me.dtpFechaInicio.BackColor = Me.txtSfaPromocionID.BackColor
        Me.dtpFechaInicio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None

        If Me.TypeGui = CONSULTA Then
            Me.dtpFechaFin.BackColor = Me.txtSfaPromocionID.BackColor
            Me.dtpFechaFin.ReadOnly = True
        End If

        Me.txtDescripcion.ReadOnly = True
        Me.dtpFechaInicio.ReadOnly = True

        Me.rdbGlobalTipo.Enabled = False
        Me.rdbPorRepuesto.Enabled = False
        Me.chkTodas.Enabled = False
        Me.chkAplicanRestricciones.Enabled = False

        'Si es edición entonces activar
        If Me.TypeGui = EDICION Then
            Me.dtpFechaFin.Enabled = True
            Me.chkTodas.Enabled = True
        End If
    End Sub
#End Region

End Class