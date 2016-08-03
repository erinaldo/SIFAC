'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Milagros Ruiz Oporta
''-- Fecha de Elaboración    : 05 Julio 2010.
''-- Formulario de Agregación de Descripcion a ala factura
''------------------------------------------------------------------------------------------------
Imports DAL
Imports SIFAC.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms.VisualStyles
Imports SIFAC.BO.clsConsultas
Imports C1.Win.C1TrueDBGrid

Public Class frmSfaAgregarDescripcion


#Region "Variables del formulario"
    Dim m_strmarca, m_strmodelo, m_strcolor, m_strchasis, m_strano As String
    Dim m_strmotor, m_strcilindraje, m_strcilindros, m_strtipo As String
    Dim m_strcombustible, m_strvelocidades, m_strpasajeros, m_strpoliza As String
#End Region

#Region "Propiedades"
    Property strMarca() As String
        Get
            Return m_strmarca
        End Get
        Set(ByVal value As String)
            m_strmarca = value
        End Set
    End Property

    Property strModelo() As String
        Get
            Return m_strmodelo
        End Get
        Set(ByVal value As String)
            m_strmodelo = value
        End Set
    End Property

    Property strColor() As String
        Get
            Return m_strcolor
        End Get
        Set(ByVal value As String)
            m_strcolor = value
        End Set
    End Property

    Property strChasis() As String
        Get
            Return m_strchasis
        End Get
        Set(ByVal value As String)
            m_strchasis = value
        End Set
    End Property

    Property strAno() As String
        Get
            Return m_strano
        End Get
        Set(ByVal value As String)
            m_strano = value
        End Set
    End Property

    Property strMotor() As String
        Get
            Return m_strmotor
        End Get
        Set(ByVal value As String)
            m_strmotor = value
        End Set
    End Property

    Property strCilindraje() As String
        Get
            Return m_strcilindraje
        End Get
        Set(ByVal value As String)
            m_strcilindraje = value
        End Set
    End Property

    Property strCilindros() As String
        Get
            Return m_strcilindros
        End Get
        Set(ByVal value As String)
            m_strcilindros = value
        End Set
    End Property

    Property strTipo() As String
        Get
            Return m_strtipo
        End Get
        Set(ByVal value As String)
            m_strtipo = value
        End Set
    End Property

    Property strCombustible() As String
        Get
            Return m_strcombustible
        End Get
        Set(ByVal value As String)
            m_strcombustible = value
        End Set
    End Property

    Property strVelocidades() As String
        Get
            Return m_strvelocidades
        End Get
        Set(ByVal value As String)
            m_strvelocidades = value
        End Set
    End Property

    Property strPasajeros() As String
        Get
            Return m_strpasajeros
        End Get
        Set(ByVal value As String)
            m_strpasajeros = value
        End Set
    End Property

    Property strPoliza() As String
        Get
            Return m_strpoliza
        End Get
        Set(ByVal value As String)
            m_strpoliza = value
        End Set
    End Property
#End Region

#Region "Inicializar GUI"
    Private Sub ConfigurarGrid()

        Me.grdDescripcion.Rows.Count = 0
        Me.grdDescripcion.ExtendLastCol = True

        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "MARCA"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "MODELO"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "COLOR"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "AÑO"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "MOTOR"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "CHASIS"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "CILINDRAJE"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "CILINDROS"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "TIPO"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "COMBUSTIBLE"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "VELOCIDADES"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "PASAJEROS"
        Me.grdDescripcion.Rows.Add()
        Me.grdDescripcion.Item(Me.grdDescripcion.Rows.Count - 1, 0) = "POLIZA NO."
        Me.grdDescripcion.Cols.Item(1).AllowEditing = True

    End Sub
    Private Sub CargarDatos()
        Try
            If Not String.IsNullOrEmpty(strMarca) Then
                Me.grdDescripcion.Item(0, 1) = Me.strMarca
            End If

            If Not String.IsNullOrEmpty(strModelo) Then
                Me.grdDescripcion.Item(1, 1) = Me.strModelo
            End If

            If Not String.IsNullOrEmpty(strColor) Then
                Me.grdDescripcion.Item(2, 1) = Me.strColor
            End If

            If Not String.IsNullOrEmpty(strAno) Then
                Me.grdDescripcion.Item(3, 1) = Me.strAno
            End If

            If Not String.IsNullOrEmpty(strMotor) Then
                Me.grdDescripcion.Item(4, 1) = Me.strMotor
            End If

            If Not String.IsNullOrEmpty(strChasis) Then
                Me.grdDescripcion.Item(5, 1) = Me.strChasis
            End If

            If Not String.IsNullOrEmpty(strCilindraje) Then
                Me.grdDescripcion.Item(6, 1) = Me.strCilindraje
            End If

            If Not String.IsNullOrEmpty(strCilindros) Then
                Me.grdDescripcion.Item(7, 1) = Me.strCilindros
            End If

            If Not String.IsNullOrEmpty(strTipo) Then
                Me.grdDescripcion.Item(8, 1) = Me.strTipo
            End If

            If Not String.IsNullOrEmpty(strCombustible) Then
                Me.grdDescripcion.Item(9, 1) = Me.strCombustible
            End If

            If Not String.IsNullOrEmpty(strVelocidades) Then
                Me.grdDescripcion.Item(10, 1) = Me.strVelocidades
            End If

            If Not String.IsNullOrEmpty(Me.strPasajeros) Then
                Me.grdDescripcion.Item(11, 1) = Me.strPasajeros
            End If

            If Not String.IsNullOrEmpty(Me.strPoliza) Then
                Me.grdDescripcion.Item(12, 1) = Me.strPoliza
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmSfaAgregarDescripcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        ConfigurarGrid()
        CargarDatos()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(0, 1)) Then
            Me.m_strmarca = Me.grdDescripcion.Item(0, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(1, 1)) Then
            Me.m_strmodelo = Me.grdDescripcion.Item(1, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(2, 1)) Then
            Me.m_strcolor = Me.grdDescripcion.Item(2, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(3, 1)) Then
            Me.m_strano = Me.grdDescripcion.Item(3, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(4, 1)) Then
            Me.m_strmotor = Me.grdDescripcion.Item(4, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(5, 1)) Then
            Me.m_strchasis = Me.grdDescripcion.Item(5, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(6, 1)) Then
            Me.m_strcilindraje = Me.grdDescripcion.Item(6, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(7, 1)) Then
            Me.m_strcilindros = Me.grdDescripcion.Item(7, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(8, 1)) Then
            Me.m_strtipo = Me.grdDescripcion.Item(8, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(9, 1)) Then
            Me.m_strcombustible = Me.grdDescripcion.Item(9, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(10, 1)) Then
            Me.m_strvelocidades = Me.grdDescripcion.Item(10, 1).ToString
        End If

        If Not String.IsNullOrEmpty(Me.grdDescripcion.Item(11, 1)) Then
            Me.m_strpasajeros = Me.grdDescripcion.Item(11, 1).ToString
        End If

        If Not String.IsNullOrEmpty(grdDescripcion.Item(12, 1)) Then
            Me.m_strpoliza = Me.grdDescripcion.Item(12, 1).ToString
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

End Class