'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Milagros Ruiz Oporta
''-- Fecha de Elaboración    : 24 Junio 2010.
''-- Formulario de Consulta de Existencia de Repuestos
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

Public Class frmSfaExistencia

#Region "Variables miembro"
    Dim dtExistencia As DataTable
    Dim m_strCodigo As String
    Dim m_AgregarMoto As Boolean
#End Region

#Region "Propiedades"

    Property strCodigo() As String
        Get
            Return m_strCodigo
        End Get
        Set(ByVal value As String)
            m_strCodigo = value
        End Set
    End Property

    Property bolAgregarMoto() As Boolean
        Get
            Return m_AgregarMoto
        End Get
        Set(ByVal value As Boolean)
            m_AgregarMoto = value
        End Set
    End Property

#End Region

#Region "Incializar GUI"
    Private Sub CargarExistencia()
        Try
            Try
                dtExistencia = New DataTable
                If Not Me.bolAgregarMoto Then
                    dtExistencia = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Nombre as Bodega, Ubicacion, Cantidad, objProductoID, DescripcionCorta", "vwExistenciaBodegas", " objProductoID = '" & Me.strCodigo & "'"))
                Else
                    dtExistencia = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Nombre as Bodega, Ubicacion, Cantidad, objProductoID, DescripcionCorta", "vwExistenciaBodegas", " objProductoID = '" & Me.strCodigo & "'"))
                End If
                Me.grdExistencia.SetDataBinding(dtExistencia, "", True)
                Me.grdExistencia.MarqueeStyle = MarqueeEnum.FloatingEditor
                Me.grdExistencia.EmptyRows = False
                Me.grdExistencia.FilterBar = False
                Me.grdExistencia.Refresh()

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally

        End Try
    End Sub
#End Region

    Private Sub frmSfaExistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarExistencia()
    End Sub

    Private Sub frmSfaExistencia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class