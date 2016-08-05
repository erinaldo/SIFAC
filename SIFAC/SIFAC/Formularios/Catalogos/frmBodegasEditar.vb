Imports DAL
Imports Proyecto.Configuracion
Imports SIFAC.BO.clsConsultas
Imports SIFAC.BO

Public Class frmBodegasEditar

#Region "Declaracion de Variables"
    Public DtCiudad, DtJefe As DataTable
    Public intTypeGui As Integer
    Public intBodegaID As Integer
    Public boolEditado As Boolean
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property BodegaID() As Integer
        Get
            Return intBodegaID
        End Get
        Set(ByVal value As Integer)
            intBodegaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripción:        Procedimiento encargado de cargar los valores de ciudad
    Public Sub CargarCiudad()
        DtCiudad = StbCiudad.RetrieveDT("1=1")
        'With cbxMarca
        '    .DataSource = DtMarca
        '    .DisplayMember = "Descripcion"
        '    .ValueMember = "StbValorCatalogoID"
        '    .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
        '    .ExtendRightColumn = True
        'End With
    End Sub
#End Region


End Class