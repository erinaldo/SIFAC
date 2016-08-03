Imports Seguridad.Datos
Imports SIFAC.BO.clsConsultas
Imports Proyecto.Configuracion

Public Class frmSivMarcas

#Region "Variables del formulario"
    Dim dtMarcas As DataTable
    Dim objseg As SsgSeguridad
    Dim dsMarcas As DataSet
    Dim boolAgregar, boolEditar, boolAnular, boolImprimir, boolBuscar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        dtMarcas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("MarcaID,Nombre,Descripcion,Activa", "vwStbMarcas", ))
        dtMarcas.PrimaryKey = New DataColumn() {Me.dtMarcas.Columns("MarcaID")}
        dtMarcas.DefaultView.Sort = "MarcaID"
        Me.grdMarcas.DataSource = dtMarcas
        Me.grdMarcas.Text = "Marcas (" & Me.dtMarcas.Rows.Count & ")"
    End Sub


      Public Sub AplicarSeguridad()
        objSeg = New SsgSeguridad

        objseg.ServicioUsuario = "FRMSTBMARCA"
        objSeg.Usuario = clsProyecto.Conexion.Usuario
        boolAgregar = objseg.TienePermiso("AgregarMarca")
        boolEditar = objseg.TienePermiso("EditarMarca")
        boolImprimir = objseg.TienePermiso("ImprimirMarca")

        cmdAgregar.Enabled = boolAgregar
        cmdEditar.Enabled = boolEditar And dtMarcas.Rows.Count > 0
        cmdImprimir.Enabled = boolImprimir And dtMarcas.Rows.Count > 0

    End Sub

#End Region

    Private Sub frmSivMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub
End Class