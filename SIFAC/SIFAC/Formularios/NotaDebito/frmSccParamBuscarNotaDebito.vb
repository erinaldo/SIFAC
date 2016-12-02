'-----------------------------------------------------------------------
''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
''-- Fecha de Elaboraci�n    : 20 de Febrero de 2009.
''----------------------------------------------------------------------
''--    Formulario de Par�metros de B�squeda de Notas de D�bito
''----------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports SIFAC.BO

Public Class frmSccParamBuscarNotaDebito

#Region "Declaracion de Variables Locales y Objetos"
    Dim dtCliente As DataTable
    Dim dtEstado As DataTable
    Dim dtSucursal As DataTable
    Dim ClienteID As Integer
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Private m_TipoND As DataTable
    Private m_TipoCerosRelleno As Integer
#End Region

#Region "Propiedades"
    Public Property TipodtND() As DataTable
        Get
            Return m_TipoND
        End Get
        Set(ByVal value As DataTable)
            m_TipoND = value
        End Set
    End Property

    Public Property TipoCerosRelleno() As Integer
        Get
            Return m_TipoCerosRelleno
        End Get
        Set(ByVal value As Integer)
            m_TipoCerosRelleno = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"
    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboraci�n    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Cargar el Formulario de Busqueda
    '-----------------------------------------------------------------------------------
    Private Sub frmSccParamBuscarNotaDebito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.txtNumero.Enabled = False
            Me.chkNumero.Checked = False
            PropiedadesFormulario()
            clsProyecto.CargarTemaDefinido(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Propiedades del Formulario"

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboraci�n    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Cargar el Combo Estado y la Estructura del dtCliente
    '-----------------------------------------------------------------------------------
    Private Sub PropiedadesFormulario()
        Try
            '-- Cargar el Combo Estado
            CargarEstado()

            ''-- Obtener la estructura del Datatable
            'strCampos = "  SccClienteID, Codigo, Nombre1 + ' ' + ISNULL(Nombre2,'') + ' ' + Apellido1 + ' ' + ISNULL(Apellido2, '') AS Nombre, objCategoriaID  "
            'strOrden = " Codigo, Nombre "
            'strSQL = clsConsultas.ObtenerEmpleadoCliente(strCampos, , strOrden)
            'dtCliente = SqlHelper.ExecuteQueryDT(strSQL)
            'dtCliente.Clear()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Check Box"

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboraci�n    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Habilitar o Deshabilitar Opciones en dependencia de 
    '--                     :   el parametro de Busqueda (Numero o Libre)
    '-----------------------------------------------------------------------------------
    Private Sub chkNumero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNumero.CheckedChanged
        ParametroBusqueda()
    End Sub

    Private Sub ParametroBusqueda()
        Try
            Select Case Me.chkNumero.Checked
                Case True
                    '-- Limpiar Opciones
                    Me.txtCliente.Clear()
                    Me.dtpFechaDesde.ClearUndo()
                    Me.dtpFechaHasta.ClearUndo()
                    Me.dtpFechaDesde.SelectedText = ""
                    Me.dtpFechaHasta.SelectedText = ""
                    Me.cmbEstado.ClearSelected()
                   
                    '-- Deshabilitar Opciones
                    Me.dtpFechaDesde.Enabled = False
                    Me.dtpFechaHasta.Enabled = False
                    Me.cmbEstado.Enabled = False
                    Me.cmdCliente.Enabled = False
                
                    '-- Habilitar Opciones
                    Me.txtNumero.Enabled = True

                Case False
                    '-- Deshabilitar Opciones
                    Me.txtNumero.Enabled = False

                    '-- Limpiar Campos
                    Me.txtNumero.Clear()

                    '-- Habilitar Opciones
                    Me.dtpFechaDesde.Enabled = True
                    Me.dtpFechaHasta.Enabled = True
                    Me.cmbEstado.Enabled = True
                    Me.cmdCliente.Enabled = True

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Combos"

    '-----------------------------------------------------------------------
    '----------------------------------------------------------------------
    '-- Descripcion         :   Cargar el Combo Estado con los valores del Catalogo EstadoND.
    '----------------------------------------------------------------------------------------------------------
    Private Sub CargarEstado()
        Try
            strCampos = " Descripcion, StbValorCatalogoID "
            strFiltro = " Nombre='EstadoND' "
            strOrden = " Descripcion "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro, strOrden)
            dtEstado = SqlHelper.ExecuteQueryDT(strSQL)
            Me.dtEstado.Rows.Add("TODOS", "0")
            If dtEstado.Rows.Count > 0 Then
                Me.cmbEstado.DataSource = dtEstado
                Me.cmbEstado.DisplayMember = "Descripcion"
                Me.cmbEstado.ValueMember = "StbValorCatalogoID"
                Me.cmbEstado.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                Me.cmbEstado.Splits(0).ExtendRightColumn = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



#End Region

#Region "Evento Boton Cliente"

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboraci�n    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Cargar los Datos del Cliente
    '-----------------------------------------------------------------------------------
    Private Sub cmdCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCliente.Click
        'Dim objfrm As frmSccEscogerCliente
        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    objfrm = New frmSccEscogerCliente
        '    objfrm.TipoFiltroCliente = " 1=1 "
        '    If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '        ClienteID = objfrm.TipoClienteID
        '        dtCliente = objfrm.TipoClienteDT.Copy

        '        '-- Habilitar Opciones
        '        Me.txtCliente.Text = objfrm.TipoNombreCliente

        '        '-- Cargar Combos a Partir del ID del CLiente
        '        CargarComboSucursal()

        '        '-- Seleccionar la sucursal del Grid Cliente
        '        Me.cmbSucursal.SelectedValue = objfrm.TipoSucursalID
        '    End If
        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'Finally
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub

#End Region

#Region "Evento Boton Aceptar - Cancelar"

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboraci�n    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Ejecutar la Consulta
    '-----------------------------------------------------------------------------------
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim TipoFiltro As String = "1=1"
        Dim strFechas As String = ""
        Dim strEstado As String = ""
        Dim strCliente As String = ""
        Dim strSucursal As String = ""
        Dim aParmFechas As New SqlParameter
        Dim ParmFechas(2) As SqlParameter
        Dim blnParametro As Boolean = False
        Try
            If ValidarDatos(0) Then
                Me.Cursor = Cursors.WaitCursor

                '-- Verificar el Parametro la Busqueda. Si es Libre o por Numero de Nota de Debito
                If Me.chkNumero.Checked Then
                    If Me.txtNumero.Text.Trim.Length > 0 Then
                        TipoFiltro = " Numero= " & Me.txtNumero.Text
                    Else
                        TipoFiltro = "1=1"
                    End If
                Else
                    '-- Parametro Rango de Fechas en que se realiz� la Nota de Debito
                    If IsDBNull(Me.dtpFechaHasta.Value) And Not IsDBNull(Me.dtpFechaDesde.Value) Then
                        aParmFechas = New SqlParameter("@FechaDesde", SqlDbType.DateTime, 8)
                        aParmFechas.Value = Me.dtpFechaDesde.Value
                        strFechas = " AND CAST(CAST(FECHA AS VARCHAR(11)) AS DATETIME) >= (@FechaDesde -1) "
                    End If
                    If IsDBNull(Me.dtpFechaDesde.Value) And Not IsDBNull(Me.dtpFechaHasta.Value) Then
                        aParmFechas = New SqlParameter("@FechaHasta", SqlDbType.DateTime, 8)
                        aParmFechas.Value = Me.dtpFechaHasta.Value
                        strFechas = " AND CAST(CAST(FECHA AS VARCHAR(11)) AS DATETIME)  <= @FechaHasta "
                    End If
                    If Not IsDBNull(Me.dtpFechaHasta.Value) And Not IsDBNull(Me.dtpFechaDesde.Value) Then
                        If Not Me.dtpFechaHasta.Value = Me.dtpFechaDesde.Value Then
                            blnParametro = True
                            ParmFechas(0) = New SqlParameter("@FechaDesde", SqlDbType.DateTime, 8)
                            ParmFechas(0).Value = Me.dtpFechaDesde.Value
                            ParmFechas(1) = New SqlParameter("@FechaHasta", SqlDbType.DateTime, 8)
                            ParmFechas(1).Value = Me.dtpFechaHasta.Value
                            strFechas = " AND CAST(CAST(FECHA AS VARCHAR(11)) AS DATETIME) >= (@FechaDesde -1) AND CAST(CAST(FECHA AS VARCHAR(11)) AS DATETIME) <=@FECHAHASTA "
                        Else
                            aParmFechas = New SqlParameter("@FechaDesde", SqlDbType.DateTime, 8)
                            aParmFechas.Value = Me.dtpFechaDesde.Value
                            strFechas = " AND CAST(CAST(FECHA AS VARCHAR(11)) AS DATETIME) = @FECHADESDE "
                        End If
                    End If

                    '-- Parametro Estado de la Nota de Debito
                    If Me.cmbEstado.Text.Trim.Length > 0 Then
                        If Not Me.cmbEstado.SelectedValue = 0 Then
                            strEstado = " AND objEstadoID= " & Me.cmbEstado.SelectedValue
                        End If
                    End If

                    '-- Parametro Cliente a quien pertenece la Nota de Debito
                    If Me.txtCliente.Text.Trim.Length > 0 Then
                        strCliente = " AND objClienteID= " & ClienteID
                    End If

                   
                    TipoFiltro = " 1=1 " & strFechas & strEstado & strCliente & strSucursal
                End If

                '--Verificar si hay datos para procesar la B�squeda
                strCampos = " * "
                strOrden = " Fecha "
                ''  strSQL = clsConsultas.ObtenerNotaDebito(strCampos, TipoFiltro, strOrden)

                '-- Obtener el Datatable con el Resultado de la Consulta
                If Me.chkNumero.Checked Then
                    Me.TipodtND = SqlHelper.ExecuteQueryDT(strSQL)
                Else
                    '-- Verificar que arreglo de parametros de fechas asignar a la consulta
                    If blnParametro Then
                        Me.TipodtND = SqlHelper.ExecuteQueryDT(strSQL, ParmFechas)
                    Else
                        Me.TipodtND = SqlHelper.ExecuteQueryDT(strSQL, aParmFechas)
                    End If
                End If

                If Me.TipodtND.Rows.Count = 0 Then
                    MsgBox(My.Resources.MsgBusqueda, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Else
                    '-- Si existen Datos, levantar la pantalla de Impresion de Resultados de la B�squeda
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '-----------------------------------------------------------------------
    ''-- Nombre del Autor        : Pedro Pablo Tinoco Salgado.
    ''-- Fecha de Elaboraci�n    : 20 de Febrero de 2009.
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Boton Cancelar
    '-----------------------------------------------------------------------------------
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "Verificacion de las Entradas"

    '-------------------------------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creaci�n   :   04 de Diciembre del 2007
    '-- Descripcion         :   Valida que los datos de entrada sean los correctos.
    '-------------------------------------------------------------------------------------------------------
    Private Function ValidarDatos(Optional ByRef condicion As Short = 1) As Boolean
        Try
            If Not IsDBNull(dtpFechaDesde) And Not IsDBNull(dtpFechaHasta) Then
                If Me.dtpFechaDesde.Text.Trim.Length > 0 And Me.dtpFechaHasta.Text.Trim.Length > 0 Then
                    If dtpFechaDesde.Value > clsProyecto.Conexion.FechaServidor.Date.AddDays(1) Then
                        dtpFechaDesde.Focus()
                        Me.ErrorProvider1.SetError(dtpFechaDesde, "El rango del per�odo de las fechas no puede exceder a la fecha actual.")
                        Return False
                    End If
                    If dtpFechaHasta.Value = clsProyecto.Conexion.FechaServidor.Date Then
                    ElseIf dtpFechaHasta.Value > clsProyecto.Conexion.FechaServidor.Date.AddDays(1) Then
                        dtpFechaHasta.Focus()
                        Me.ErrorProvider1.SetError(dtpFechaHasta, "El rango del per�odo de las fechas no puede exceder a la fecha actual.")
                        Return False
                    End If
                    If dtpFechaHasta.Value < dtpFechaDesde.Value Then
                        dtpFechaHasta.Focus()
                        Me.ErrorProvider1.SetError(dtpFechaHasta, "La Fecha de Inicio no puede ser mayor a la Fecha Fin.")
                        Return False
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Validacion de las Entradas"

    '-- Validacion de las Fechas
    Private Sub dtpFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged
        Try
            If Not IsDBNull(dtpFechaDesde) Then
                If Me.dtpFechaDesde.Text.Trim.Length > 0 Then
                    If dtpFechaDesde.Text > clsProyecto.Conexion.FechaServidor.Date Then
                        dtpFechaDesde.Focus()
                        Me.ErrorProvider1.SetError(dtpFechaDesde, "El rango del per�odo de las fechas no puede exceder a la fecha actual.")
                        Me.cmdGuardar.Enabled = False
                    Else
                        Me.ErrorProvider1.Clear()
                        Me.cmdGuardar.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub dtpFechaDesde_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaDesde.Validating
        Try
            If Not IsDBNull(dtpFechaDesde) Then
                If Me.dtpFechaDesde.Text.Trim.Length > 0 Then
                    If dtpFechaDesde.Text > clsProyecto.Conexion.FechaServidor.Date Then
                        dtpFechaDesde.Focus()
                        Me.ErrorProvider1.SetError(dtpFechaDesde, "El rango del per�odo de las fechas no puede exceder a la fecha actual.")
                        Me.cmdGuardar.Enabled = False
                    Else
                        Me.ErrorProvider1.Clear()
                        Me.cmdGuardar.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub dtpFechaHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.TextChanged
        Try
            If Not IsDBNull(dtpFechaHasta.Value) Then
                If dtpFechaHasta.Text.Trim.Length > 0 Then
                    If dtpFechaHasta.Text > clsProyecto.Conexion.FechaServidor.Date Then
                        dtpFechaHasta.Focus()
                        Me.ErrorProvider1.SetError(dtpFechaHasta, "El rango del per�odo de las fechas no puede exceder a la fecha actual.")
                        Me.cmdGuardar.Enabled = False
                    ElseIf Me.dtpFechaDesde.Text.Trim.Length > 0 Then
                        If dtpFechaHasta.Value < dtpFechaDesde.Value Then
                            dtpFechaHasta.Focus()
                            Me.ErrorProvider1.SetError(dtpFechaHasta, "La Fecha de Inicio no puede ser mayor a la Fecha Fin.")
                            Me.cmdGuardar.Enabled = False
                        Else
                            Me.ErrorProvider1.Clear()
                            Me.cmdGuardar.Enabled = True
                        End If
                    Else
                        Me.ErrorProvider1.Clear()
                        Me.cmdGuardar.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub dtpFechaHasta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaHasta.Validating
        Try
            If Not IsDBNull(dtpFechaHasta.Value) Then
                If dtpFechaHasta.Text.Trim.Length > 0 Then
                    If dtpFechaHasta.Text > clsProyecto.Conexion.FechaServidor.Date Then
                        dtpFechaHasta.Focus()
                        Me.ErrorProvider1.SetError(dtpFechaHasta, "El rango del per�odo de las fechas no puede exceder a la fecha actual.")
                        Me.cmdGuardar.Enabled = False
                    ElseIf Me.dtpFechaDesde.Text.Trim.Length > 0 Then
                        If dtpFechaHasta.Value < dtpFechaDesde.Value Then
                            dtpFechaHasta.Focus()
                            Me.ErrorProvider1.SetError(dtpFechaHasta, "La Fecha de Inicio no puede ser mayor a la Fecha Fin.")
                            Me.cmdGuardar.Enabled = False
                        Else
                            Me.ErrorProvider1.Clear()
                            Me.cmdGuardar.Enabled = True
                        End If
                    Else
                        Me.ErrorProvider1.Clear()
                        Me.cmdGuardar.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

End Class