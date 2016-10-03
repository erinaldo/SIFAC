Imports SIFAC.BO
Imports Proyecto.Configuracion

Public Class frmSivEncargosEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intEncargoID As Integer
    Public boolEditado As Boolean
    Public DtMarca, DtCategoria, DtNombreProducto As DataTable
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

    Property EncargoID() As Integer
        Get
            Return intEncargoID
        End Get
        Set(ByVal value As Integer)
            intEncargoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

    '' Descripción:        Procedimiento encargado de cargar los valores de Marca
    Public Sub CargarMarca()
        Try
            DtMarca = SivMarcas.RetrieveDT("Activa=1")
            Dim newMarcaRow As DataRow = DtMarca.NewRow()
            newMarcaRow("MarcaID") = "0"
            newMarcaRow("Nombre") = "Ninguna"

            DtMarca.Rows.Add(newMarcaRow)
            With cmbMarca
                .Properties.DataSource = DtMarca
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "MarcaID"
                .Properties.PopulateColumns()
                .Properties.Columns("MarcaID").Visible = False
                .Properties.Columns("Descripcion").Visible = False
                .Properties.Columns("Activa").Visible = False
                .Properties.Columns("FechaCreacion").Visible = False
                .Properties.Columns("UsuarioCreacion").Visible = False
                .Properties.Columns("FechaModificacion").Visible = False
                .Properties.Columns("UsuarioModificacion").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
                .EditValue = 0
              
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            DtMarca = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar los valores de Categorias
    Public Sub CargarCategorias()
        Try
            DtCategoria = SivCategorias.RetrieveDT("Activa=1", " Nombre", "CategoriaID, Nombre")
            Dim newCategoriaRow As DataRow = DtMarca.NewRow()
            newCategoriaRow("CategoriaID") = "0"
            newCategoriaRow("Nombre") = "Ninguna"
            With cmbCategoria
                .Properties.DataSource = DtCategoria
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "CategoriaID"
                .Properties.PopulateColumns()
                .Properties.Columns("CategoriaID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
                .EditValue = 0
            End With

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarProductos(CategoriaID As Integer, MarcaID As Integer)
        Try
            DtNombreProducto = SivProductos.RetrieveDT("Activo=1 AND objCategoriaID='" + CategoriaID.ToString() + "' AND objMarcaID='" + MarcaID.ToString() + "'", " Nombre", " (Codigo  + '-' +  Nombre) AS Nombre")
            Dim newProductosRow As DataRow = DtMarca.NewRow()
            newProductosRow("SivProductoID") = "0"
            newProductosRow("Nombre") = "Ninguna"

            With cmbNombreProducto
                .Properties.DataSource = DtNombreProducto
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "SivProductoID"
                .Properties.PopulateColumns()
                .Properties.Columns("SivProductoID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
                .EditValue = 0
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub ConfigurarGUI()
        Try
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Entrada"
                    CargarCategorias()
                    CargarMarca()
                    '    chkActivo.Checked = True
                    '    chkActivo.Enabled = False
                    'Case 1
                    '    CargarDatosProducto()
                    '    chkActivo.Enabled = True
                    'Case 2
                    '    CargarDatosProducto()
                    '    spnCantidadMinima.Enabled = False
                    '    spnCostoPromedio.Enabled = False
                    '    spnMargenContado.Enabled = False
                    '    spnMargenCredito.Enabled = False
                    '    spnPrecioContado.Enabled = False
                    '    spnPrecioCredito.Enabled = False
                    '    txtNombre.Enabled = False
                    '    txtProducto.Enabled = False
                    '    cbxMarca.Enabled = False
                    '    cbxCategoria.Enabled = False
                    '    chkActivo.Enabled = False
                    '    cmdGuardar.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos del Formulario"

    Private Sub frmSivEncargosEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub cmbCategoria_EditValueChanged(sender As Object, e As EventArgs) Handles cmbCategoria.EditValueChanged
        Try
            If cmbCategoria.Text <> "" And cmbMarca.Text <> "" Then
                CargarProductos(Convert.ToInt32(cmbCategoria.EditValue), Convert.ToInt32(cmbMarca.EditValue))
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbMarca_EditValueChanged(sender As Object, e As EventArgs) Handles cmbMarca.EditValueChanged
        Try
            If cmbCategoria.Text <> "" And cmbMarca.Text <> "" Then
                CargarProductos(Convert.ToInt32(cmbCategoria.EditValue), Convert.ToInt32(cmbMarca.EditValue))
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    
    
   
End Class