
Imports DAL
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports SIFAC.BO

''' <summary>
''' Formulario Principal de Mantenimiento de Devoluciones.
''' Autor : Pedro Tinoco
''' Fecha : 4 de Abril de 2009.
''' </summary>
''' <remarks></remarks>
Public Class frmSccDevoluciones
    Dim m_IDDevolucion As Integer
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim DtDatosDevolucion As DataTable
    Dim m_IDEstadoRegistrado As Integer

#Region "Propiedades de Devoluciones"

    Property IDEstadoReg() As Integer
        Get
            IDEstadoReg = Me.m_IDEstadoRegistrado
        End Get
        Set(ByVal value As Integer)
            Me.m_IDEstadoRegistrado = value
        End Set
    End Property

    Property IDDevolucion() As Integer
        Get
            IDDevolucion = Me.m_IDDevolucion
        End Get
        Set(ByVal value As Integer)
            Me.m_IDDevolucion = value
        End Set
    End Property

    Property IDCuenta() As String
        Get
            IDCuenta = Me.m_IDCuenta
        End Get
        Set(ByVal value As String)
            Me.m_IDCuenta = value
        End Set
    End Property

    Property IDTienda() As Integer
        Get
            IDTienda = Me.m_IDTienda
        End Get
        Set(ByVal value As Integer)
            Me.m_IDTienda = value
        End Set
    End Property
#End Region

    ''' <summary>
    ''' Procedimiento encargado de cargar los datos correspondientes de las devoluciones.
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 6 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaDatos()
        Try
            Me.DtDatosDevolucion = New DataTable
            Me.DtDatosDevolucion = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*", "vwSccDevolucion"))
            Me.DtDatosDevolucion.PrimaryKey = New DataColumn() {Me.DtDatosDevolucion.Columns("SccDevolucionID")}
            Me.DtDatosDevolucion.DefaultView.Sort = "SccDevolucionID"
            Me.grdDevolucion.SetDataBinding(Me.DtDatosDevolucion, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#Region "Autorizar Devolucion"

    ''' <summary>
    ''' Procedimiento encargado de autorizar la devolución correspondiente
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 6 de Abril de 2009.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AutorizarDevolucion() As Boolean
        Dim objDevolucion As New SccDevolucion
        Dim objSccCuentaCobrar As New SccCuentaPorCobrar
        Dim objSccCuentaDetalle As New SccCuentaPorCobrarDetalle

        Dim DtDatosFactura As New DataTable
        Dim DtDatosND As New DataTable
        Dim DtDatosNC As New DataTable
        Dim IDEstadoN As Integer
        Dim IdClasificacion As Integer
        Dim T As New TransactionManager

        Try
            Try
                T.BeginTran()
                objDevolucion.Retrieve(Me.IDDevolucion, T)
                objDevolucion.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADODEVOLUCION", "AUTORIZADA")
                objDevolucion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objDevolucion.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objDevolucion.Update(T)

                DtDatosFactura = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaID='" & objDevolucion.objSccCuentaID & "' AND objTiendaID=" & objDevolucion.ObjSucursalID & " AND objFacturaID IS NOT NULL", , , T)
                IDEstadoN = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "03")
                IdClasificacion = ClsCatalogos.ObtenerIDSTbCatalogo("CLASIFICACIONCUENTA", "C")
                For Each drw As DataRow In DtDatosFactura.Rows
                    drw("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                    drw("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                    drw("objEstadoID") = IDEstadoN
                    drw("objCalificacionID") = IdClasificacion
                Next
                DtDatosFactura.TableName = "SccCuentaPorCobrarDetalle"
                SccCuentaPorCobrarDetalle.BatchUpdate(DtDatosFactura.DataSet, T)

                IDEstadoN = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOND", "PAGADA")
                DtDatosND = SccNotaDebito.RetrieveDT("objSccCuentaID='" & objDevolucion.objSccCuentaID & "' AND objTiendaID=" & objDevolucion.ObjSucursalID & " AND objEstadoID <> " & IDEstadoN.ToString, , "*", T)
                IDEstadoN = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOND", "ANULADA")

                For Each drw As DataRow In DtDatosND.Rows
                    drw("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                    drw("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                    drw("objEstadoID") = IDEstadoN

                Next
                DtDatosND.TableName = "SccNotaDebito"
                SccNotaDebito.BatchUpdate(DtDatosND.DataSet, T)

                IDEstadoN = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "PAGADA")
                DtDatosNC = SccNotaCredito.RetrieveDT("objSccCuentaID='" & objDevolucion.objSccCuentaID & "' AND objTiendaID=" & objDevolucion.ObjSucursalID & " AND objEstadoID <> " & IDEstadoN.ToString, , "*", T)
                IDEstadoN = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADONC", "ANULADA")

                For Each drw As DataRow In DtDatosNC.Rows
                    drw("UsuarioModificacion") = clsProyecto.Conexion.Usuario
                    drw("FechaModificacion") = clsProyecto.Conexion.FechaServidor
                    drw("objEstadoID") = IDEstadoN
                Next
                DtDatosNC.TableName = "SccNotaCredito"
                SccNotaCredito.BatchUpdate(DtDatosNC.DataSet, T)

                objSccCuentaCobrar.Retrieve(objDevolucion.objSccCuentaID, objDevolucion.ObjSucursalID, T)
                objSccCuentaCobrar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objSccCuentaCobrar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objSccCuentaCobrar.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOEXPEDIENTE", "DEVOLUCION")
                objSccCuentaCobrar.Update(T)

                T.CommitTran()
                MsgBox("Autorización de Devolución Exitosa", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.CargaDatos()
                Me.grdDevolucion.Row = Me.DtDatosDevolucion.DefaultView.Find(Me.IDDevolucion)

            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objDevolucion = Nothing
            objSccCuentaCobrar = Nothing
            objSccCuentaDetalle = Nothing
        End Try
    End Function

    Private Sub cmdAutorizarDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorizarDev.Click
        If Me.grdDevolucion.RowCount > 0 Then
            Me.IDDevolucion = Me.grdDevolucion.Columns("SccDevolucionID").Value
            If Me.grdDevolucion.Columns("objEstadoID").Value <> Me.IDEstadoReg Then
                MsgBox("Solamente Devoluciones en Estado Registrada pueden ser Autorizadas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If
            Select Case MsgBox("Esta seguro de utorizar Devolución", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Me.AutorizarDevolucion()

                Case MsgBoxResult.No
                    Exit Sub
            End Select

        End If
    End Sub
#End Region

#Region " Nueva Devolucion"

    ''' <summary>
    ''' Procedimiento encargado de crear una nueva devolucion
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 6 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub New_Devolucion()
        Dim objFormDev As frmSccEditDevolucion
        Try
            objFormDev = New frmSccEditDevolucion
            objFormDev.TypeGui = 0
            If objFormDev.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargaDatos()
                Me.grdDevolucion.Row = Me.DtDatosDevolucion.DefaultView.Find(objFormDev.IDDevolucion)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregarDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarDev.Click
        Call Me.New_Devolucion()
    End Sub



#End Region

#Region "Eventos"

    Private Sub frmSccDevoluciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargaDatos()
        Me.AplicarSeguridad()
        Me.IDEstadoReg = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADODEVOLUCION", "REGISTRADA")
        clsProyecto.CargarTemaDefinido(Me)
        Me.grdDevolucion.Splits(0).DisplayColumns("SccDevolucionID").Visible = False
        Me.grdDevolucion.Splits(0).DisplayColumns("objEstadoID").Visible = False
        clsProyecto.CargarTemaDefinido(Me)
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Me.CargaDatos()
    End Sub


#End Region

#Region "Editar Devolucion"
    Private Sub cmdEditarDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarDev.Click
        If Me.grdDevolucion.RowCount > 0 Then
            Me.IDDevolucion = Me.grdDevolucion.Columns("SccDevolucionID").Value
            If Me.grdDevolucion.Columns("objEstadoID").Value <> Me.IDEstadoReg Then
                MsgBox("Solamente Devoluciones en Estado Registrada pueden ser Editadas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If
            Me.Edit_Devolucion()
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de Editar las devoluciones 
    ''' Autor : Pedro Pablo Tinoco Salgado.
    ''' Fecha : 6 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Edit_Devolucion()
        Dim objFormDev As frmSccEditDevolucion
        Try
            objFormDev = New frmSccEditDevolucion
            objFormDev.TypeGui = 1
            objFormDev.IDDevolucion = Me.IDDevolucion
            If objFormDev.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.CargaDatos()
                Me.grdDevolucion.Row = Me.DtDatosDevolucion.DefaultView.Find(objFormDev.IDDevolucion)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Consultar Devolucion"
    Private Sub Quote_Devolucion()
        Dim objFormDev As frmSccEditDevolucion
        Try
            objFormDev = New frmSccEditDevolucion
            objFormDev.TypeGui = 2
            objFormDev.IDDevolucion = Me.IDDevolucion
            objFormDev.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdConsultarDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarDev.Click
        If Me.grdDevolucion.RowCount > 0 Then
            Me.IDDevolucion = Me.grdDevolucion.Columns("SccDevolucionID").Value
            Me.Quote_Devolucion()
        End If
    End Sub
#End Region

#Region "Seguridad"

    ''' <summary>
    ''' Autor : Pedro Pablo Tinoco S.
    ''' Fecha : 13 de Abril de 2009.
    ''' Procedimiento Encargado de Aplicar Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.ServicioUsuario = "FRMSCCDEVOLUCION"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            Me.cmdAgregarDev.Enabled = objSeg.TienePermiso("AGREGARDEV")
            Me.cmdEditarDev.Enabled = objSeg.TienePermiso("EDITARDEV")
            Me.cmdAutorizarDev.Enabled = objSeg.TienePermiso("AUTORIZARDEV")
            Me.cmdBuscarDevolucion.Enabled = objSeg.TienePermiso("BuscarDev")
            Me.cmdConsultarDev.Enabled = objSeg.TienePermiso("CONSULTARDEV")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region


End Class