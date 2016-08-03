Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports SIFAC.BO
Imports System.Data.SqlClient

Public Class frmSccBuscarRecibo
    Dim m_StrFiltro As String
    Dim intImportacion, intImportado As Integer
    Public Parametros(7) As SqlParameter

    Public Property StrFiltro() As String
        Get
            StrFiltro = Me.m_StrFiltro
        End Get
        Set(ByVal value As String)
            Me.m_StrFiltro = value
        End Set
    End Property

    Public Property EjecutarImportacion() As Integer
        Get
            EjecutarImportacion = Me.intImportacion
        End Get
        Set(ByVal value As Integer)
            Me.intImportacion = value
        End Set
    End Property

    ''' <summary>
    ''' Autor : Pedro Pablo Tinoco 
    ''' Fecha : 24 de Abril de 2009.
    ''' Descripcion : Procedimiento encargado de cargar los estados posibles de un recibo de caja.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEstadoRecibo()
        Dim dtDatos As New DataTable
        Try
            dtDatos = ClsCatalogos.ObtenerValCat("ESTADOROC")
            With Me.cmbEstado
                .DataSource = dtDatos
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .ColumnHeaders = False
                .ExtendRightColumn = True
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Autor : Pedro Pablo Tinoco
    ''' Fecha : 24 de Abril de 2009.
    ''' Decripcion : Procedimiento encargado de cargar las sucursales.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarSucursales()
        Dim dtDatos As New DataTable
        Try
            dtDatos = StbTienda.RetrieveDT(, , "Nombre,StbTiendaID")
            With Me.cmbSucursal
                .DataSource = dtDatos
                .DisplayMember = "Nombre"
                .ValueMember = "StbTiendaID"
                .ColumnHeaders = False
                .ExtendRightColumn = True
                .Splits(0).DisplayColumns("StbTiendaID").Visible = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub frmSccBuscarRecibo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            Me.CargarEstadoRecibo()
            Me.CargarSucursales()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtNUmerofactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtNumeroRecibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroRecibo.KeyPress
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de Realizar la Busqueda de los Seguimientos Realizados
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 15 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarSeguimientos()
        Dim strConsulta As String = ""
        Try
            Try
                ' Parametros Cliente
                Parametros(0) = New SqlParameter
                Parametros(0).ParameterName = "@Numero"
                Parametros(0).SqlDbType = SqlDbType.NVarChar
                Parametros(0).Size = 10


                Parametros(1) = New SqlParameter
                Parametros(1).ParameterName = "@EstadoID"
                Parametros(1).SqlDbType = SqlDbType.Int
                Parametros(1).Size = 6

                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@ExpedienteID"
                Parametros(2).SqlDbType = SqlDbType.VarChar
                Parametros(2).Size = 10


                Parametros(3) = New SqlParameter
                Parametros(3).ParameterName = "@ClienteID"
                Parametros(3).SqlDbType = SqlDbType.VarChar
                Parametros(3).Size = 16

                Parametros(4) = New SqlParameter
                Parametros(4).ParameterName = "@SucursalID"
                Parametros(4).SqlDbType = SqlDbType.Int
                Parametros(4).Size = 6

                Parametros(5) = New SqlParameter
                Parametros(5).ParameterName = "@FechaInicio"
                Parametros(5).SqlDbType = SqlDbType.DateTime
                Parametros(5).Size = 15

                Parametros(6) = New SqlParameter
                Parametros(6).ParameterName = "@FechaFin"
                Parametros(6).SqlDbType = SqlDbType.DateTime
                Parametros(6).Size = 15


                If Me.txtNumeroRecibo.Text.Trim.Length > 0 Then
                    StrFiltro = "vwSccReciboCaja.Numero = @Numero"
                    Parametros(0).Value = Me.txtNumeroRecibo.Text.Trim
                    GoTo ETiq
                End If

                If Me.cmbEstado.Text <> "" Then
                    Parametros(1).Value = Trim(Me.cmbEstado.SelectedValue)
                    If StrFiltro = "" Then
                        StrFiltro = "vwSccReciboCaja.objEstadoID = @EstadoID"
                    Else
                        StrFiltro = StrFiltro + " AND vwSccReciboCaja.objEstadoID = @EstadoID"
                    End If
                End If

                If Me.txtNumExp.Text.Trim <> "" Then
                    Parametros(2).Value = Trim(Me.txtNumExp.Text.Trim)
                    If StrFiltro = "" Then
                        StrFiltro = "vwSccReciboCaja.SccCuentaID = @ExpedienteID"
                    Else
                        StrFiltro = StrFiltro + " AND vwSccReciboCaja.SccCuentaID = @ExpedienteID"
                    End If
                End If


                If Trim(Me.txtCedula.Text) <> "-      -" Then
                    Parametros(3).Value = Trim(Me.txtCedula.Text)
                    If StrFiltro = "" Then
                        StrFiltro = "vwSccReciboCaja.StbPersonaID = @ClienteID"
                    Else
                        StrFiltro = StrFiltro + " AND vwSccReciboCaja.StbPersonaID = @ClienteID"
                    End If
                End If

                If Me.cmbSucursal.Text.Trim <> "" Then
                    Parametros(4).Value = Trim(Me.cmbSucursal.SelectedValue)
                    If StrFiltro = "" Then
                        StrFiltro = "vwSccReciboCaja.SucursalPagoID = @SucursalID"
                    Else
                        StrFiltro = StrFiltro + " AND vwSccReciboCaja.SucursalPagoID = @ClienteID"
                    End If
                End If

                If Trim(Me.dtpFecIniSeg.Text) <> "" And Trim(Me.dtpFechFinSeg.Text) = "" Then
                    Parametros(5).Value = Trim(Me.dtpFecIniSeg.Value)
                    If StrFiltro = "" Then
                        StrFiltro = "vwSccReciboCaja.Fecha = @FechaInicio"
                    Else
                        StrFiltro = StrFiltro + " AND vwSccReciboCaja.Fecha = @FechaInicio"
                    End If
                ElseIf Trim(Me.dtpFecIniSeg.Text) = "" And Trim(Me.dtpFechFinSeg.Text) <> "" Then
                    Parametros(6).Value = Trim(Me.dtpFechFinSeg.Value)
                    If StrFiltro = "" Then
                        StrFiltro = "vwSccReciboCaja.Fecha = @FechaFin"
                    Else
                        StrFiltro = StrFiltro + " AND vwSccReciboCaja.Fecha = @FechaFin"
                    End If
                ElseIf Trim(Me.dtpFecIniSeg.Text) <> "" And Trim(Me.dtpFechFinSeg.Text) <> "" Then
                    Parametros(5).Value = Trim(Me.dtpFecIniSeg.Value)
                    Parametros(6).Value = Trim(Me.dtpFechFinSeg.Value)
                    If StrFiltro = "" Then
                        StrFiltro = " vwSccReciboCaja.Fecha BETWEEN @FechaInicio AND @FechaFin"
                    Else
                        StrFiltro = StrFiltro + " AND vwSccReciboCaja.Fecha BETWEEN @FechaInicio and @FechaFin"
                    End If
                End If

                If StrFiltro = "" Then
                    StrFiltro = "1=1"
                End If

ETiq:

                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally

        End Try
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.BuscarSeguimientos()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        Me.EjecutarImportacion = 10
        Me.BuscarSeguimientos()
    End Sub
End Class