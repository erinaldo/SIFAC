'-------------------------------------------------------------------------------------------------
''-- Nombre del Autor        : Gelmin Martínez
''-- Fecha de Elaboración    : 07 de Agosto 2010, 04:14 pm.
''-- Formulario de Busqueda de Ordenes de Compra
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

Public Class frmBuscarOrdenCompra

#Region "Atributos"
    Private dtTienda As DataTable
    Private dtCliente As DataTable
    Private m_strFiltro As String
    Public Parametro(4) As SqlParameter
#End Region

#Region "Propiedades"
    Property strFiltro() As String
        Get
            Return m_strFiltro
        End Get
        Set(ByVal value As String)
            m_strFiltro = value
        End Set
    End Property
#End Region

#Region "Cargar Clientes"
    Private Sub CargarClientes()
        dtCliente = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID, NombreCompleto", "vwSfaClienteFactura", "Descripcion = 'Cliente' order by NombreCompleto"))

        With Me.cmbCliente
            .DataSource = dtCliente
            .ValueMember = "StbPersonaID"
            .DisplayMember = "NombreCompleto"
            .Splits(0).DisplayColumns("StbPersonaID").Visible = False
            .ExtendRightColumn = True
        End With
        dtCliente.Rows.Add("0", "TODOS")
        Me.cmbCliente.SelectedValue = "0"

    End Sub
#End Region

    '#Region "Cargar Tiendas"

    '    Private Sub CargarTienda()
    '        dtTienda = StbTienda.RetrieveDT("Activo = 1 AND  AND Codigo <> 'ME' AND ActivoRepuesto = 1 ", , "StbTiendaID, Codigo,Nombre")
    '        With Me.cmbSucursal
    '            .DataSource = Me.dtTienda
    '            .ValueMember = "StbTiendaID"
    '            .DisplayMember = "Nombre"
    '            .Splits(0).DisplayColumns("StbTiendaID").Visible = False
    '            .Splits(0).DisplayColumns("Codigo").Visible = False
    '            .ExtendRightColumn = True
    '        End With
    '        Me.cmbSucursal.SelectedValue = ClsCatalogos.GetStbTiendaID(clsProyecto.Sucursal)
    '    End Sub
    '#End Region

#Region "Validar"

    Private Function Validar() As Boolean

        If Me.dtpDesde.Text.Trim.Length = 0 Then
            Me.ErrorBusquedaFactura.SetError(Me.dtpDesde, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpHasta.Text.Trim.Length = 0 Then
            Me.ErrorBusquedaFactura.SetError(Me.dtpHasta, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        If Me.dtpDesde.Value > Me.dtpHasta.Value Then
            Me.ErrorBusquedaFactura.SetError(Me.dtpDesde, "La Fecha Desde debe ser menor que la Fecha Hasta")
            Return False
            Exit Function
        End If
        Return True
    End Function
#End Region

#Region "Obtener Filtro"
    Private Sub ObtenerFiltro()
        Try
            Try
                m_strFiltro = ""

                Parametro(0) = New SqlParameter
                Parametro(0).ParameterName = "@Numero"
                Parametro(0).SqlDbType = SqlDbType.NVarChar
                Parametro(0).Size = 10

                Parametro(1) = New SqlParameter
                Parametro(1).ParameterName = "@Cliente"
                Parametro(1).SqlDbType = SqlDbType.NVarChar
                Parametro(1).Size = 16

                Parametro(2) = New SqlParameter
                Parametro(2).ParameterName = "@FechaDesde"
                Parametro(2).SqlDbType = SqlDbType.DateTime
                Parametro(2).Size = 15

                Parametro(3) = New SqlParameter
                Parametro(3).ParameterName = "@FechaHasta"
                Parametro(3).SqlDbType = SqlDbType.DateTime
                Parametro(3).Size = 15

                If (Me.txtNumeroFactura.Text.Trim.ToUpper <> "TODAS" And (Me.txtNumeroFactura.Text.Trim.Length <> 0)) Then
                    Parametro(0).Value = Trim(Me.txtNumeroFactura.Text)
                    If m_strFiltro.Length <> 0 Then
                        m_strFiltro = m_strFiltro & " AND CAST(OrdenCompra AS VARCHAR) = @Numero"
                    Else
                        m_strFiltro = " CAST(OrdenCompra AS VARCHAR) = @Numero"
                    End If

                End If

                'If Me.cmbSucursal.Text <> "" Then
                '    If Me.cmbSucursal.Text.Trim.Length <> 0 Then
                '        Parametro(1).Value = Me.cmbSucursal.SelectedValue
                '        If m_strFiltro.Trim.Length <> 0 Then
                '            m_strFiltro = m_strFiltro & " AND objtiendaID = @Sucursal"
                '        Else
                '            m_strFiltro = " objtiendaID = @Sucursal"
                '        End If
                '    End If
                'End If

                If Me.cmbCliente.Text <> "TODOS" Then
                    If Me.cmbCliente.Text.Trim.Length <> 0 Then
                        Parametro(1).Value = Me.cmbCliente.SelectedValue
                        If m_strFiltro.Length <> 0 Then
                            m_strFiltro = m_strFiltro & " AND objClienteID = @Cliente"
                        Else
                            m_strFiltro = " objClienteID = @Cliente"
                        End If
                    End If
                End If

                Parametro(2).Value = Convert.ToDateTime(Trim(Me.dtpDesde.Value))
                Parametro(3).Value = Convert.ToDateTime(Trim(Me.dtpHasta.Value))

                If m_strFiltro.Length = 0 Then
                    m_strFiltro = " convert(varchar,Fecha,112) >= convert(varchar,@FechaDesde,112) AND convert(varchar,Fecha,112) <= convert(varchar,@FechaHasta,112)"
                Else
                    m_strFiltro = strFiltro & " AND convert(varchar,Fecha,112) >= convert(varchar,@FechaDesde,112) AND convert(varchar,Fecha,112) <= convert(varchar,@FechaHasta,112)"
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally

        End Try

    End Sub
#End Region

#Region "Eventos"

    Private Sub frmSfaBuscarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsProyecto.CargarTemaDefinido(Me)
        Me.CargarClientes()
        'Me.CargarTienda() 'No se cargan sucursales por sólo en CENTRAL se hacen ordenes de compra.
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.Validar Then
            Me.ObtenerFiltro()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Private Sub dtpDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.TextChanged
        Me.ErrorBusquedaFactura.SetError(Me.dtpDesde, "")
    End Sub

    Private Sub dtpHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.TextChanged
        Me.ErrorBusquedaFactura.Clear()
    End Sub
#End Region

    Private Sub txtNumeroFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroFactura.KeyPress
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If
    End Sub

End Class


