Imports Proyecto.Catalogos.Datos
Imports DAL
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports System.Data.SqlClient

Public Class frmStbValAsociados
    Dim m_Idcat As Integer
    Dim dtValores As DataTable
    Public ValoresActivados As Boolean
#Region "Propiedades"
    Public Property IdCat() As Integer
        Get
            Return m_Idcat
        End Get
        Set(ByVal value As Integer)
            m_Idcat = value
        End Set
    End Property

#End Region

    Private Sub frmValAsociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarDatos()

    End Sub

    Private Sub CargarDatos()
        Try
            '--- Instanciar ----
            dtValores = StbValorCatalogo.RetrieveDT("objCatalogoID=" + Convert.ToString(Me.IdCat) + "", , "*")
            Me.grdDatosvalores.SetDataBinding(dtValores, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '--- Liberar Recursos

        End Try

    End Sub

    '---------------------------------------------------------------------------------------------------------
    ' Procedimiento  : ActivarInactivarValorCatalogo
    ' Autor          : Pedro Pablo Tinoco
    ' Fecha Creacion : 10-11-07
    ' Descripcion    : Procedimiento encargado de realizar modificar el estado de los valores de los catalogos.
    '---------------------------------------------------------------------------------------------------------

    Private Sub ActivarInactivarValorCatalogo(ByVal intValorCatalogo As Integer, ByVal boolopcion As Boolean)
        Dim objValorCatalogo As New StbValorCatalogo
        Dim T As New TransactionManager
        Try
            T.BeginTran()

            objValorCatalogo.Retrieve(intValorCatalogo)
            objValorCatalogo.Activo = boolopcion
            objValorCatalogo.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objValorCatalogo.StbValorCatalogoID = objValorCatalogo.StbValorCatalogoID
            objValorCatalogo.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objValorCatalogo.Update(T)

            T.CommitTran()

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try

    End Sub


    '---------------------------------------------------------------------------------------------------------
    ' Procedimiento  : ActivarValoresCatalogo
    ' Autor          : Pedro Pablo Tinoco
    ' Fecha Creacion : 20-10-07
    ' Descripcion    : Procedimiento encargado de realizar modificar el estado de los valores de los catalogos.
    '---------------------------------------------------------------------------------------------------------
    Private Function ActivarValoresCatalogo() As Integer
        Dim Contador As Integer
        Dim intValorId As Integer
        Dim T As New TransactionManager
        Try
            T.BeginTran()
            For Each drw As DataRow In dtValores.Rows
                If CBool(drw("Activo")) Then
                    intValorId = drw("StbValorCatalogoID")
                    ActivarInactivarValorCatalogo(intValorId, True)
                    Contador = Contador + 1
                End If
            Next
            T.CommitTran()
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return Contador
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If ActivarValoresCatalogo() > 0 Then
            ValoresActivados = True
            Me.Close()
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.ValoresActivados = False
        Me.Close()
    End Sub
End Class
