'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Michelle Valezka Reyes Tijerino.
''-- Fecha de Elaboración    : 03 de Enero del 2008.
''------------------------------------------------------------------------------------------------
''--    Formulario de Edición de Tasas de Cambios
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SCCUM.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmStbEditTasaCambioOficial

#Region "Declaracion de Variables Locales y Objetos"
    Dim objTasaCambio As StbTasaCambioOficial
    Dim dtTasaCambio As New DataTable
    Dim dtMoneda As DataTable
    Dim dtMes As DataTable
    Dim decMontoMax As Decimal
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Private m_EstadoRegistarda As Integer
    Private m_EstadoConfirmada As Integer
    Private intTasaCambioOficialID As Integer
    
#End Region

#Region "Propiedades"
    Public Property TipoEstadoRegistarda() As Integer
        Get
            Return m_EstadoRegistarda
        End Get
        Set(ByVal value As Integer)
            m_EstadoRegistarda = value
        End Set
    End Property

    Public Property TipoEstadoConfirmada() As Integer
        Get
            Return m_EstadoConfirmada
        End Get
        Set(ByVal value As Integer)
            m_EstadoConfirmada = value
        End Set
    End Property

    Public Property TasaCambioOficialID() As Integer
        Get
            Return intTasaCambioOficialID
        End Get
        Set(ByVal value As Integer)
            intTasaCambioOficialID = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Al Cargar el Formulario se carga el Tema, Grid 
    '-----------------------------------------------------------------------------------
    Private Sub frmEditTasaCambioOficial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            objTasaCambio = New StbTasaCambioOficial
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

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Propiedades del Formulario
    '-----------------------------------------------------------------------------------
    Private Sub PropiedadesFormulario()
        Dim P As Integer
        Dim S As Integer
        Try
            CargarComboMoneda()
            CargarComboMes()
            '-- Poner la fecha del Servidor
            Me.txtAnio.Text = Mid(Convert.ToString(clsProyecto.Conexion.FechaServidor), 7, 4)
            Me.txtAnio.MaxLength = 4

            '-- Obtener el Maximo valor para el monto de la Tasa de Cambio
            P = StbTasaCambioOficial.GetMaxLength("Monto")
            S = StbTasaCambioOficial.GetScale("Monto")
            Me.decMontoMax = ObtenerMaxValor(P, S)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            P = Nothing
            S = Nothing
        End Try
    End Sub

#End Region

#Region "Combos"

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Cargar el Combo con los Valores del Catalogo MONEDA
    '-----------------------------------------------------------------------------------
    Private Sub CargarComboMoneda()
        Try
            strCampos = " StbValorCatalogoID, Descripcion"
            strFiltro = " Nombre='Moneda' AND NOT Codigo='COR' "
            strOrden = " Descripcion "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro, strOrden)
            dtMoneda = SqlHelper.ExecuteQueryDT(strSQL)
            If dtMoneda.Rows.Count > 0 Then
                Me.cmbMoneda.DataSource = dtMoneda
                Me.cmbMoneda.ValueMember = "StbValorCatalogoID"
                Me.cmbMoneda.DisplayMember = "Descripcion"
                Me.cmbMoneda.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                Me.cmbMoneda.Splits(0).ExtendRightColumn = True
                If Me.dtMoneda.Rows.Count = 1 Then
                    Me.cmbMoneda.SelectedIndex = 0
                Else
                    Me.cmbMoneda.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbMoneda_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedValueChanged
        Me.ErrorProvider1.Clear()
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   03 de Enero del 2008
    '-- Descripcion         :   Cargar el Combo con los Meses del Año
    '-----------------------------------------------------------------------------------
    Private Sub CargarComboMes()
        Try
            '-- Obtener la Estructura del Datatable
            strCampos = " StbValorCatalogoID as MesID, Descripcion as Mes"
            strFiltro = " Nombre='Moneda' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro, strOrden)
            dtMes = SqlHelper.ExecuteQueryDT(strSQL)
            dtMes.Clear()

            '-- Agregar los Registros
            dtMes.Rows.Add(1, "Enero")
            dtMes.Rows.Add(2, "Febrero")
            dtMes.Rows.Add(3, "Marzo")
            dtMes.Rows.Add(4, "Abril")
            dtMes.Rows.Add(5, "Mayo")
            dtMes.Rows.Add(6, "Junio")
            dtMes.Rows.Add(7, "Julio")
            dtMes.Rows.Add(8, "Agosto")
            dtMes.Rows.Add(9, "Septiembre")
            dtMes.Rows.Add(10, "Octubre")
            dtMes.Rows.Add(11, "Noviembre")
            dtMes.Rows.Add(12, "Diciembre")

            '-- Mostrar los Registros
            If dtMes.Rows.Count > 0 Then
                Me.cmbMes.DataSource = dtMes
                Me.cmbMes.ValueMember = "MesID"
                Me.cmbMes.DisplayMember = "Mes"
                Me.cmbMes.Splits(0).DisplayColumns("MesID").Visible = False
                Me.cmbMes.Splits(0).ExtendRightColumn = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbMes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedValueChanged
        Me.ErrorProvider1.Clear()
    End Sub

#End Region


#Region "Evento Botones Aceptar - Cancelar"

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        GuardarTasasCambioOficial()
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   04 de Enero del 2008
    '-- Descripcion         :   Guardar las Tasas de Cambio
    '-----------------------------------------------------------------------------------
    Private Sub GuardarTasasCambioOficial()

        Dim blnAgregar As Boolean = False
        Try
            If ValidarDatos() Then

                '-----------------------------------------------------------
                '-- GUARDAR LAS TASAS DE CAMBIO
                '-----------------------------------------------------------

                '--Verificar que no exista una tasa de cambio para el mes y año seleccionado

                If Not objTasaCambio.RetrieveByFilter("Mes = " & cmbMes.SelectedValue & " AND Anio = " & txtAnio.Text & " AND objMonedaID = " & cmbMoneda.SelectedValue) Then
                    objTasaCambio.Mes = cmbMes.SelectedValue
                    objTasaCambio.Anio = CInt(txtAnio.Text)
                    objTasaCambio.Monto = Me.nmuMonto.Value
                    objTasaCambio.objMonedaID = Me.cmbMoneda.SelectedValue
                    objTasaCambio.objEstadoID = Me.TipoEstadoRegistarda
                    objTasaCambio.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objTasaCambio.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objTasaCambio.Insert()
                    Me.TasaCambioOficialID = DAL.SqlHelper.ExecuteQueryDT("SELECT MAX(StbTasaCambioOficialID) as ID FROM StbTasaCambioOficial").DefaultView.Item(0)("ID")
                    blnAgregar = True
                Else
                    MsgBox("Ya existe una Tasa de cambio registrada para este año y mes", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                '-----------------------------------------------------------
                '-- CONFIRMAR LAS TASAS DE CAMBIO
                '-----------------------------------------------------------
                '-- Verificar si se agregaron registros o si se actualizaron registros.
                If blnAgregar Then
                    Select Case MsgBox("¿Desea confirmar la tasa de cambio registrada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            objTasaCambio.objEstadoID = Proyecto.Catalogos.Datos.ClsCatalogos.ObtenerIDSTbCatalogo("EstadoTasaCambio", "CONFIRMADO")
                            objTasaCambio.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objTasaCambio.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objTasaCambio.Update()
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        Case MsgBoxResult.No
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                    End Select
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   04 de Enero del 2008
    '-- Descripcion         :   Cancelar la Operacion
    '-----------------------------------------------------------------------------------
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If Me.cmbMes.Text = "" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Select Case MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    GuardarTasasCambioOficial()
                Case MsgBoxResult.No
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Case MsgBoxResult.Cancel
            End Select
        End If
    End Sub

#End Region

#Region "Verificacion de las Entradas"

    '-------------------------------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   04 de Enero del 2008
    '-- Descripcion         :   Valida que los datos de entrada sean los correctos.
    '-------------------------------------------------------------------------------------------------------
    Private Function ValidarDatos() As Boolean
        Dim Contador As Integer = 0
        Try
            If Me.cmbMoneda.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cmbMoneda, "Campo obligatorio.")
                Me.cmbMoneda.Focus()
                Return False
            End If
            If Me.cmbMes.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cmbMes, "Campo obligatorio.")
                Me.cmbMes.Focus()
                Return False
            End If
            If Me.txtAnio.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtAnio, "Campo obligatorio.")
                Me.txtAnio.Focus()
                Return False
            ElseIf Convert.ToInt32(Me.txtAnio.Text) < 1000 Then
                Me.ErrorProvider1.SetError(Me.txtAnio, "El rango de los años debe de estar comprendido entre el año 1000 y 9999.")
                Me.txtAnio.Focus()
                Return False
            End If
            If Me.nmuMonto.Value = 0 Then
                Me.ErrorProvider1.SetError(Me.nmuMonto, "Campo obligatorio.")
                Me.txtAnio.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Validacion de las Entradas"
    Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.Handled = True
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
        Me.ErrorProvider1.SetError(txtAnio, "")
    End Sub

    Private Sub nmuMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmuMonto.ValueChanged
        Me.ErrorProvider1.Clear()
    End Sub
#End Region


    
    
End Class