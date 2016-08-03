Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO
Imports System.Data.SqlClient

Public Class frmStbBuscarBitacora
    Dim m_StrFiltro As String
    Public Parametros(6) As SqlParameter

    Public Property StrFiltro() As String
        Get
            StrFiltro = Me.m_StrFiltro
        End Get
        Set(ByVal value As String)
            Me.m_StrFiltro = value
        End Set
    End Property


    Private Sub frmStbBuscarBitacora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        Dim dtDatos As New DataTable
        Try
            dtDatos = SsgCuenta.RetrieveDT("Activo = 1", , "Login")
            With Me.cmbUsuario
                .DataSource = dtDatos
                .DisplayMember = "Login"
                .ValueMember = "Login"
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


    ''' <summary>
    ''' Procedimiento Encargado de Realizar la Busqueda de los Seguimientos Realizados
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 15 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarSeguimientos()
        Dim nombre(0) As String
        Dim strConsulta As String = ""
        Try
            Try
                ' Parametros Cliente
                Parametros(1) = New SqlParameter
                Parametros(1).ParameterName = "@ClienteID"
                Parametros(1).SqlDbType = SqlDbType.NVarChar
                Parametros(1).Size = 16

                Parametros(2) = New SqlParameter
                Parametros(2).ParameterName = "@FechaInicio"
                Parametros(2).SqlDbType = SqlDbType.DateTime
                Parametros(2).Size = 10

                Parametros(3) = New SqlParameter
                Parametros(3).ParameterName = "@FechaFin"
                Parametros(3).SqlDbType = SqlDbType.DateTime
                Parametros(3).Size = 10

                Parametros(4) = New SqlParameter
                Parametros(4).ParameterName = "@Usuario"
                Parametros(4).SqlDbType = SqlDbType.VarChar
                Parametros(4).Size = 50

                Parametros(5) = New SqlParameter
                Parametros(5).ParameterName = "@CuentaID"
                Parametros(5).SqlDbType = SqlDbType.VarChar
                Parametros(5).Size = 10


                If Trim(Me.txtCedula.Text) <> "-      -" Then
                    Parametros(1).Value = Trim(Me.txtCedula.Text)
                    If strFiltro = "" Then
                        strFiltro = "StbPersonaID = @ClienteID"
                    Else
                        strFiltro = strFiltro + " AND StbPersonaID = @ClienteID"
                    End If
                End If

                If Trim(Me.dtpFecIniSeg.Text) <> "" And Trim(Me.dtpFechFinSeg.Text) = "" Then

                    Parametros(2).Value = Me.dtpFecIniSeg.Value
                    If StrFiltro = "" Then
                        StrFiltro = " FechaComp= @FechaInicio"
                    Else
                        StrFiltro = StrFiltro + " AND FechaComp = @FechaInicio"
                    End If
                ElseIf Trim(Me.dtpFecIniSeg.Text) = "" And Trim(Me.dtpFechFinSeg.Text) <> "" Then
                    Parametros(3).Value = Trim(Me.dtpFechFinSeg.Value)
                    If StrFiltro = "" Then
                        StrFiltro = "FechaComp = @FechaFin"
                    Else
                        StrFiltro = StrFiltro + " AND FechaComp = @FechaFin"
                    End If
                ElseIf Trim(Me.dtpFecIniSeg.Text) <> "" And Trim(Me.dtpFechFinSeg.Text) <> "" Then
                    Parametros(2).Value = Trim(Me.dtpFecIniSeg.Value)
                    Parametros(3).Value = Trim(Me.dtpFechFinSeg.Value)
                    If StrFiltro = "" Then
                        StrFiltro = " FechaComp BETWEEN @FechaInicio AND @FechaFin"
                    Else
                        StrFiltro = StrFiltro + " AND FechaComp BETWEEN @FechaInicio and @FechaFin"
                    End If
                End If

                If Me.cmbUsuario.Text <> "" Then
                    Parametros(4).Value = Me.cmbUsuario.SelectedValue
                    If StrFiltro = "" Then
                        StrFiltro = "UsuarioCreacion = @Usuario"
                    Else
                        StrFiltro = StrFiltro + " AND UsuarioCreacion = @Usuario"
                    End If
                End If

                If Trim(Me.txtNumExp.Text) <> "" Then
                    Parametros(5).Value = Me.txtNumExp.Text.Trim
                    If StrFiltro = "" Then
                        StrFiltro = "objSccCuentaID= @CuentaID"
                    Else
                        StrFiltro = StrFiltro + " AND objSccCuentaID= @CuentaID"
                    End If
                End If

                If strFiltro = "" Then
                    strFiltro = "1=1"
                End If
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

    Private Sub txtNumExp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumExp.KeyPress
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub
End Class