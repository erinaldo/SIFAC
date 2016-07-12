
#Region "Importacion de Librerias"
Imports Proyecto.Catalogos.Datos
Imports DAL
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports System.Data.SqlClient
Imports System.Drawing.Color
Imports System.Windows.Forms
#End Region

Public Class frmStbMantCatalogo

#Region "Declaracion de Variables"
    '--------------------Variables------------------------
    Dim stbCatalogos As StbCatalogo
    Dim stbValores As StbValorCatalogo
    Dim dtCatalogos As New DataTable
    Dim dtValores As New DataTable
    Dim intOpcionHabilitar As Integer
    Dim objSeg As SsgSeguridad
    Dim m_IdCat As Integer
    Dim m_ValCat As Integer
    '-----------------------------------------------------
#End Region

#Region "Propiedades"
    Public Property IntCatalogo()
        Get
            IntCatalogo = m_IdCat
        End Get
        Set(ByVal value)
            m_IdCat = value
        End Set
    End Property

    Public Property IntValorCatalogo()
        Get
            IntValorCatalogo = m_ValCat
        End Get
        Set(ByVal value)
            m_ValCat = value
        End Set
    End Property
#End Region

#Region "Activacion Inactivacion Catalogos"
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

    '---------------------------------------------------------------------------------------------------------
    ' Procedimiento  : ActivarInactivarCatalogo
    ' Autor          : Pedro Pablo Tinoco
    ' Fecha Creacion : 10-11-07
    ' Descripcion    : Procedimiento encargado de realizar modificar el estado de los catalogos.
    '---------------------------------------------------------------------------------------------------------
    Private Sub ActivarInactivarCatalogo(ByVal intCatalogo As Integer, ByVal boolOpcion As Boolean, Optional ByVal T As TransactionManager = Nothing)
        Dim ObjCatalogo As New StbCatalogo
        Try
            ObjCatalogo.Retrieve(intCatalogo, T)
            ObjCatalogo.Activo = boolOpcion
            ObjCatalogo.UsuarioModificacion = clsProyecto.Conexion.Usuario

            ObjCatalogo.FechaModificacion = clsProyecto.Conexion.FechaServidor
            ObjCatalogo.StbCatalogoID = ObjCatalogo.StbCatalogoID

            ObjCatalogo.Update(T)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '=========================================================================================================
#End Region

#Region "Carga de Datos"

    '--------------------------------------------------------------------------------------------------
    '-----------------------HACEMOS EL LLAMADO DE LAS FUNCIONES DE CARGA DE DATOS----------------------
    '--------------------------------------------------------------------------------------------------
    Private Sub frmMantCatalogos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            'Me.Icon = My.Resources.MdiChild
            stbCatalogos = New StbCatalogo
            stbValores = New StbValorCatalogo
            Me.grdDatosCatalogos.Splits(0).DisplayColumns("IDCat").Visible = False
            Me.grdDatosvalores.Splits(0).DisplayColumns("StbValCatID").Visible = False
            CargarCatalValores(0)
            intOpcionHabilitar = 1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '---------------------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Fecha Creacion : 24-10-2007
    'Descripcion    : Funcion encargada de realizar el control de la habilitacion de accesos.
    '---------------------------------------------------------------------------------------------------------
    Private Sub RealizarHab()
        Inhabilitar()
        HabilitarOpciones(intOpcionHabilitar, "N")

        If Me.dtCatalogos.DefaultView.Count > 0 Then
            HabilitarOpciones(intOpcionHabilitar, "ED")
            HabilitarOpciones(intOpcionHabilitar, "EL")
            HabilitarOpciones(intOpcionHabilitar, "IP")
            HabilitarOpciones(intOpcionHabilitar, "AC")
        End If
    End Sub
    '----------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Descripcion    : Procedimiento que se encarga de cargar los datos correspondientes a en las grillas de catalogos y valores
    'Parametros     : Ninguno.
    'Fecha Creacion : Lunes 15 de Octubre de 2007.
    '-----------------------------------------------------------------------------------------------------------------
    Private Sub CargarCatalValores(ByVal OpcionCase As Integer)
        Try
            dtCatalogos = StbCatalogo.RetrieveDT(, , "StbCatalogoID,Nombre,Activo")
            Me.grdDatosCatalogos.SetDataBinding(dtCatalogos, "", True)
            If OpcionCase = 1 Then
                MoverDatosCatalogos(Me.IntCatalogo)
            End If

            If dtCatalogos.Rows.Count > 0 Then
                Me.grdDatosCatalogos.Caption = "Catálogos" + "(" + Convert.ToString(Me.grdDatosCatalogos.RowCount) + ")" + ""
                IntCatalogo = Me.grdDatosCatalogos.Columns("IDCat").Value
                dtValores = StbValorCatalogo.RetrieveDT("objCatalogoId='" & Convert.ToString(IntCatalogo) & "'", , "StbValorCatalogoID,Codigo,Descripcion,Activo")
                Me.grdDatosvalores.Refresh()
                Me.grdDatosvalores.SetDataBinding(dtValores, "", True)
                If dtValores.DefaultView.Count > 0 Then
                    Me.grdDatosvalores.Caption = "Valores" + "(" + Convert.ToString(Me.grdDatosvalores.RowCount) + ")" + ""
                    IntValorCatalogo = Me.grdDatosvalores.Columns("StbValCatID").Value
                End If
            End If
            Me.grdDatosCatalogos.Caption = "Catálogos(" + Convert.ToString(Me.grdDatosCatalogos.RowCount) + ")"

            '-----Llamamos al manejo de los tooltip------------
            Manejotooltip(1)
            '--------------------------------------------------

            RealizarHab()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '========================================================================================================================
    '--------------------------------------------------------------------------------------------------------------------------
    '-- Autor       : Pedro Pablo Tinoco Salgado.
    '-- Descripcion : Este procedimiento se encarga de actualizar el estado de la posicion en el grid con respecto a los datos 
    '-------------- : agregados y editados.
    '--------------------------------------------------------------------------------------------------------------------------
    Private Sub MoverDatosCatalogos(ByVal intCatalogoID As Integer)
        For Each drw As DataRow In dtCatalogos.Rows
            If drw("StbCatalogoId") = intCatalogoID Then
                Me.grdDatosCatalogos.Row = dtCatalogos.Rows.IndexOf(drw)
                Exit For
            End If
        Next
    End Sub

    Private Sub MoverDatosValoresCat(ByVal IntValorCatalogoID As Integer)
        For Each drw As DataRow In Me.dtValores.Rows
            If drw("StbValorCatalogoID") = IntValorCatalogoID Then
                Me.grdDatosvalores.Row = Me.dtValores.Rows.IndexOf(drw)
                Exit For
            End If
        Next
    End Sub
    '========================================================================================================================
#End Region

#Region " Manipulacion de Datos"

    '------------------------------------------------------------------------------------------------------------------------
    'Nombre            : Editar
    'Autor             : Pedro Pablo Tinoco Salgado.
    'Descripcion       : Esta funcion se encarga de cargar los formularios en modo de edicion.
    'Fecha de Creacio  : 15-10-2007
    '------------------------------------------------------------------------------------------------------------------------
    Private Sub Editar(ByVal intopcion As Integer)
            Try

            Select Case intopcion
                Case 1  '--------------En caso de que se trate de Agregar un Nuevo Catalogo.------------------
                    Dim objfrm As frmCatalogoAdd
                    Me.Cursor = Cursors.WaitCursor
                    '-- Instanciar al formulario de agregar Catalogo.
                    objfrm = New frmCatalogoAdd
                    objfrm.TipoUGID = 1
                    objfrm.IdCat = IntCatalogo
                    objfrm.ShowDialog(Me)

                    If objfrm.Valorg = True Then
                        CargarCatalValores(1)
                    End If
                    Me.MoverDatosCatalogos(objfrm.IdCat)

                    '----------------------------------------------------------------------------------------------------
                Case 2  '----------------En caso de que se trate de Editar un Nuevo Valor--------------------
                    If Me.VerificarReservado Then
                        MsgBox("Imposible modificar. El registro está reservado para el sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If

                    Dim objfrm As frmStbEditValorCatalogo
                    objfrm = New frmStbEditValorCatalogo
                    objfrm.TipoUGID = 1
                    objfrm.IdValCat = IntValorCatalogo
                    objfrm.IdCat = IntCatalogo
                    objfrm.ShowDialog(Me)
                    If objfrm.ValorGuardado Then
                        If objfrm.InactivarCatalogo Then
                            ActivarInactivarCatalogo(IntCatalogo, False, Nothing)
                        End If
                        CargarCatalValores(1)
                    End If
                    MoverDatosValoresCat(objfrm.IdValCat)
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    '------------------------------------------------------------------------------------------------------------------------
    'Nombre            : Eliminar
    'Autor             : Pedro Pablo Tinoco Salgado.
    'Descripcion       : Esta funcion se encarga de Eliminar los datos.
    'Fecha de Creacio  : 15-10-2007
    '------------------------------------------------------------------------------------------------------------------------
    Private Sub Eliminar(ByVal intOpEliminar As Integer)
        Dim T As New TransactionManager
        Try
            T.BeginTran()
            Me.Cursor = Cursors.WaitCursor
            Select Case intOpEliminar
                Case 1 'En caso de que se trate de Eliminar un Catalogo

                    '-- Instanciar al formulario de agregar Catalogo.
                    If Me.dtCatalogos.DefaultView.Count > 0 Then
                        If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            StbValorCatalogo.DeleteByFilter("objCatalogoID=" & IntCatalogo, T)
                            stbCatalogos.StbCatalogoID = IntCatalogo
                            stbCatalogos.Delete(T)
                        Else
                            Exit Sub
                        End If
                        T.CommitTran()
                        MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        CargarCatalValores(0)
                    End If

                Case 2  'En caso de que se trate de eliminar un Nuevo Valor. 
                    If Me.dtValores.DefaultView.Count > 0 Then
                        If Me.VerificarReservado Then
                            MsgBox("Imposible eliminar.El registro esta reservado para el sistema.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                            Exit Sub
                        End If

                        If MsgBox("¿Esta seguro de eliminar este Registro?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            If VerificarExistenciaUltima(0) = 1 And Me.grdDatosvalores.Columns("Activo").CellValue(Me.grdDatosvalores.RowBookmark(Me.grdDatosvalores.Row) = True) Then
                                If MsgBox("La eliminación de este registro inactivará el Catálogo" + Chr(10) + "¿Desea continuar?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                                    stbValores.StbValorCatalogoID = IntValorCatalogo
                                    stbValores.Delete(T)
                                    MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                                    ActivarInactivarCatalogo(IntCatalogo, False, T)
                                End If
                            Else
                                stbValores.StbValorCatalogoID = IntValorCatalogo
                                stbValores.Delete(T)
                                MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)

                            End If
                        Else
                            Exit Sub
                        End If
                        T.CommitTran()
                        CargarCatalValores(1)
                    End If
            End Select
        Catch ex As SqlException
            T.RollbackTran()
            clsError.CaptarError(ex)
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
            T = Nothing
        End Try
    End Sub

    '------------------------------------------------------------------------------------------------------------------------
    'Nombre            : Cargar
    'Autor             : Pedro Pablo Tinoco Salgado.
    'Descripcion       : Esta funcion se encarga de cargar los formularios en modo de edicion.
    'Fecha de Creacio  : 15-10-2007
    '------------------------------------------------------------------------------------------------------------------------

    Private Sub Cargar(ByVal intopCargar As Integer)
        Try
            Select Case intopCargar
                Case 1  'En caso de que se trate de Agregar un Nuevo Catalogo.
                    Dim objfrm As frmCatalogoAdd
                    Me.Cursor = Cursors.WaitCursor
                    '-- Instanciar al formulario de agregar Catalogo.
                    objfrm = New frmCatalogoAdd
                    objfrm.TipoUGID = 0
                    objfrm.ShowDialog(Me)
                    If objfrm.Valorg = True Then
                        CargarCatalValores(0)
                        Me.MoverDatosCatalogos(objfrm.IdCat)
                        If objfrm.BoolnuevoCatalogo Then
                            objfrm = Nothing
                            Cargar(1)
                        End If
                    End If
                    '==================================================================

                Case 2  'En caso de que se trate de Agregar un Nuevo Valor. 
                    Dim objfrm As frmStbEditValorCatalogo
                    objfrm = New frmStbEditValorCatalogo
                    objfrm.TipoUGID = 0
                    objfrm.IdCat = IntCatalogo
                    objfrm.IdValCat = 0
                    objfrm.ShowDialog(Me)

                    '--------------Actualizamos el valor del Estado del catalogo-------------------------------
                    If objfrm.ValorGuardado = True Then
                        If CBool(dtCatalogos.Rows(Me.grdDatosCatalogos.Row)("Activo")) = False Then
                            ActivarInactivarCatalogo(Me.IntCatalogo, True)
                        End If
                        CargarCatalValores(1)
                        Me.MoverDatosValoresCat(objfrm.IdValCat)
                        If objfrm.boolNuevoValorCat Then
                            objfrm = Nothing
                            Cargar(2)
                        End If
                    End If
                    '==================================================================
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    '------------------------------------------------------------------------------------------------------------------------
    'Nombre            : InactivarValores
    'Autor             : Pedro Pablo Tinoco Salgado.
    'Descripcion       : Esta funcion se encarga de Inactivar todos aquellos valores y catalogos seleccionados.
    'Fecha de Creacio  : 16-10-2007
    '------------------------------------------------------------------------------------------------------------------------
    Private Sub InactivarValores(ByVal boolOpcion As Boolean)
        Dim T As New TransactionManager
        Dim dtTablaAct As New DataTable
        Dim objValCat As New StbValorCatalogo
        Try
            '--- Instanciar ----
            T.BeginTran()
            dtTablaAct = StbValorCatalogo.RetrieveDT("ObjCatalogoID= " + Convert.ToString(IntCatalogo) + "", , "*")
            For Each drwDt As DataRow In dtTablaAct.Rows
                objValCat.Retrieve(drwDt("StbValorCatalogoID"))
                objValCat.Activo = boolOpcion
                objValCat.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objValCat.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objValCat.Update(T)
            Next
            T.CommitTran()
        Catch ex As SqlClient.SqlException
            T.RollbackTran()
            clsError.CaptarError(ex)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            T = Nothing
            dtTablaAct = Nothing
            objValCat = Nothing
        End Try
    End Sub
    '------------------------------------------------------------------------------------------------------------------------


    'Autor: Pedro Tinoco Salgado.
    'Descripcion : Funcion encargada de verificar la existencia de valores existenes
    'Fecha de Creacion : 16-10-2007
    '-------------------------------------Funcion encargada de verificar la existencia de valores para un catalogo---------------
    Private Function VerificarExistencias() As Boolean
        Dim dtCantCatalogo As DataTable
        Dim parametro As SqlParameter
        Dim boolrst As Boolean
        Try
            boolrst = False
            parametro = New SqlParameter("@objCatalogoID", SqlDbType.Int, 4)
            parametro.Value = IntCatalogo
            dtCantCatalogo = SqlHelper.ExecuteQueryDT(ClsConsultasCatalogos.sqlDatosCatalogo, parametro)
            If (dtCantCatalogo.Rows.Count > 0) Then
                boolrst = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing
            dtCantCatalogo = Nothing
        End Try
        Return boolrst
    End Function

    '--------------------------------------------------------------------------------------------------------------------
    'Funcion CargarValoresCatalogo
    'Autor : Pedro Pablo Tinoco Salgado
    'Fecha de Creacion: 16-10-07
    'Funcion Encargada de cargar los valores relacionado con los catalogos que se va a habilitar o deshabilitar
    '--------------------------------------------------------------------------------------------------------------------
    Private Sub CargarValoresCatalogo()
        Dim objfrm As frmStbValAsociados
        Dim T As New TransactionManager
        Try
            objfrm = New frmStbValAsociados
            objfrm.IdCat = IntCatalogo
            objfrm.ShowDialog(Me)

            T.BeginTran()
            If objfrm.ValoresActivados Then
                '---------Mandamos a actualizar el estado del catalogo en caso de haber habido activacion de valores-------------
                ActivarInactivarCatalogo(IntCatalogo, True)
                dtCatalogos = StbCatalogo.RetrieveDT(, , "StbCatalogoID,Nombre,Activo")

                dtValores = StbValorCatalogo.RetrieveDT(, , "StbValorCatalogoID,Codigo,Descripcion,Activo,objCatalogoId")
                dtValores.DefaultView.RowFilter = "objCatalogoId = " + IntCatalogo.ToString + " "

                Me.grdDatosCatalogos.SetDataBinding(dtCatalogos, "", True)
                Me.grdDatosvalores.SetDataBinding(dtValores, "", True)
            End If
            T.CommitTran()
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------------
    'Autor: Pedro Pablo Tinoco Salgado.
    'Descripcion: Funcion que refresca los datos del grid.
    '--------------------------------------------------------------------------------------------------------------------
    Private Sub RefrescarDatos(ByVal intCatalogo As Integer)
        Try
            If grdDatosCatalogos.RowCount > 0 Then
                dtValores = StbValorCatalogo.RetrieveDT("objCatalogoID= " + Convert.ToString(intCatalogo) + "", , "*")
                Me.grdDatosvalores.SetDataBinding(dtValores, "", True)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Descripcion    : Funcion encargada de verificar si el valor del catalogo es el ultimo para un catalogo en especifico.
    'Parametros     : Ninguno.
    'Fecha Creacion : jueves 18 de Octubre de 2007.
    '-----------------------------------------------------------------------------------------------------------------
    Private Function VerificarExistenciaUltima(ByVal opcion As Integer) As Integer
        Dim dtCantCatalogo As DataTable
        Dim parametro As SqlParameter
        Dim Cant As Integer
        Try
            parametro = New SqlParameter("@objCatalogoID", SqlDbType.Int, 4)
            parametro.Value = IntCatalogo
            If opcion = 0 Then
                dtCantCatalogo = SqlHelper.ExecuteQueryDT(ClsConsultasCatalogos.SqlExistencia, parametro)
            Else
                dtCantCatalogo = SqlHelper.ExecuteQueryDT(ClsConsultasCatalogos.sqlDatosCatalogo, parametro)
            End If
            '------------------Verificamos si realmente es el ultimo----------------------------
            If (dtCantCatalogo.Rows.Count = 1) Then
                Cant = dtCantCatalogo.Rows.Count
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Cant
    End Function
    '==================================================================================================================

    '----------------------------------------------------------------------------------------------
    Private Sub Manejotooltip(ByVal intOpcionMostrar As Integer)
        Select Case intOpcionMostrar
            Case 1
                Me.cmdAgregar.ToolTipText = "Agregar Nuevo Catálogo"
                Me.cmdEditar.ToolTipText = "Editar Catálogo"
                Me.cmdEliminar.ToolTipText = "Eliminar Catálogo"
                Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
                Me.cmdimprimir.ToolTipText = "Imprimir"
            Case 2
                Me.cmdAgregar.ToolTipText = "Agregar Nuevo Valor de Catálogo"
                Me.cmdEditar.ToolTipText = "Editar Valor de Catálogo"
                Me.cmdEliminar.ToolTipText = "Eliminar Valor de Catálogo"
                Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
                Me.cmdimprimir.ToolTipText = "Imprimir"

        End Select
        '----------------------------------------------------------------------------------------------

    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Descripcion    : Funcion encargada de verificar si un valor de catalogo es reservado.
    'Parametros     : Ninguno.
    'Fecha Creacion : Noviembre 2007.
    '-----------------------------------------------------------------------------------------------------------------
    Private Function VerificarReservado() As Boolean
        Dim dtTableValorCatalogo As New DataTable
        Try
            dtTableValorCatalogo = StbValorCatalogo.RetrieveDT("StbValorCatalogoID =" + Convert.ToString(Me.IntValorCatalogo), , "*")
            If dtTableValorCatalogo.Rows.Count > 0 Then
                If dtTableValorCatalogo.DefaultView.Item(0)("Reservado") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
    '==================================================================================================================
    '-- Autor  : Pedro Pablo Tinoco
    '-- Descripcion : Esta funcion se encarga de realizar la validacion de seguridad tanto para el grid de catalogos
    '---------------: como para el grid de valor catalogo.
    '==================================================================================================================
    Private Sub ValidacionSeguridadClick(ByVal intOpcion As Integer)
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "frmSrhMantCatalogo"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            Select Case intOpcion
                Case 0
                    If objSeg.TienePermiso("ModificarCatalogo") Then
                        If Me.grdDatosCatalogos.RowCount > 0 Then
                            Editar(intOpcionHabilitar)
                        End If
                    End If
                    objSeg = Nothing

                Case 1
                    If objSeg.TienePermiso("ModificarValor") Then

                        If dtValores.DefaultView.Count > 0 Then
                            Me.grdDatosvalores.Enabled = True
                            Editar(intOpcionHabilitar)
                        Else
                            Me.grdDatosvalores.Enabled = False
                        End If
                    End If
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
        End Try
    End Sub
#End Region

#Region "Eventos Sobre Controles"
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Cargar(intOpcionHabilitar)
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Editar(intOpcionHabilitar)
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Eliminar(intOpcionHabilitar)
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        CargarCatalValores(0)
    End Sub

    Private Sub cmdimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimprimir.Click
        Try
            Dim objFrm As frmStbImpresion
            objFrm = New frmStbImpresion
            objFrm.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub grdDatosCatalogos_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdDatosCatalogos.BeforeColEdit
        EdicionDatosCatalogos()
    End Sub

    Private Sub grdDatosCatalogos_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDatosCatalogos.Change
        CargarCatalValores(1)
    End Sub

    Private Sub grdDatosCatalogos_AfterSort(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles grdDatosCatalogos.AfterSort
        CargarCatalValores(1)
    End Sub

    Private Sub grdDatosCatalogos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDatosCatalogos.Click
        intOpcionHabilitar = 1
        Manejotooltip(intOpcionHabilitar)
        RealizarHab()
    End Sub

    Private Sub grdDatosCatalogos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDatosCatalogos.DoubleClick
        Me.ValidacionSeguridadClick(0)
    End Sub

    Private Sub grdDatosCatalogos_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdDatosCatalogos.RowColChange
        Try
            ' --- Instanciar ----
            If grdDatosCatalogos.RowCount > 0 Then
                IntCatalogo = Me.grdDatosCatalogos.Columns("IDCat").CellValue(Me.grdDatosCatalogos.RowBookmark(Me.grdDatosCatalogos.Row))
                dtValores = StbValorCatalogo.RetrieveDT("ObjCatalogoId=" + Convert.ToString(IntCatalogo) + "", , "*")
                Me.grdDatosvalores.SetDataBinding(dtValores, "", True)
                If dtValores.DefaultView.Count > 0 Then
                    Me.grdDatosvalores.Caption = "Valores" + "(" + Convert.ToString(Me.grdDatosvalores.RowCount) + ")" + ""
                    IntValorCatalogo = Me.dtValores.DefaultView.Item(Me.grdDatosvalores.RowBookmark(Me.grdDatosvalores.Row))("StbValorCatalogoID")
                Else
                    Me.grdDatosvalores.Caption = "Valores (0)"
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdDatosvalores_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDatosvalores.Change
        CargarCatalValores(1)
    End Sub

    Private Sub grdDatosvalores_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDatosvalores.Click
        intOpcionHabilitar = 2
        RealizarHab()
        '-------------------------------------Si hay datos-------------------------------------------------------------- 
        If dtValores.DefaultView.Count > 0 Then
            Manejotooltip(intOpcionHabilitar)
        End If
    End Sub

    Private Sub grdDatosvalores_ColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDatosvalores.ColEdit
        EdicionValCatalogo()
    End Sub

    Private Sub grdDatosvalores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDatosvalores.DoubleClick
        Me.ValidacionSeguridadClick(1)
    End Sub

    Private Sub grdDatosvalores_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdDatosvalores.RowColChange
        Try
            If dtValores.DefaultView.Count > 0 Then
                IntValorCatalogo = Me.grdDatosvalores.Columns("StbValCatID").Value
                Me.grdDatosvalores.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Edicion en grid"

    '==================================================================================================================
    '-- Autor  : Pedro Pablo Tinoco
    '-- Descripcion : Esta funcion se encarga de realizar las validaciones de edicion directa en el grid de valorcatalogo.
    '==================================================================================================================
    Private Sub EdicionValCatalogo()
        Try
            If CBool(dtValores.Rows(Me.grdDatosvalores.Row)("Activo")) Then
                If VerificarExistenciaUltima(0) = 1 Then 'En caso de que sea el ultimo catalogo activo para cierto catalogo se pregunta si se se quiere inhabilitar
                    If MsgBox("Al inactivar este registro se inactivará el catálogo correspondiente." + Chr(10) + "¿Esta seguro de desactivar este valor?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then

                        ActivarInactivarValorCatalogo(Me.IntValorCatalogo, False)
                        ActivarInactivarCatalogo(Me.IntCatalogo, False)
                    End If
                Else 'Si no es el ultimo entonces solamente se inhabilita el valor actual.
                    If MsgBox("La inactivación de este valor de catálogo" + Chr(10) + "puede provocar incosistencias en la aplicación", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                        ActivarInactivarValorCatalogo(Me.IntValorCatalogo, False)
                    End If

                End If
            Else
                '------------Si esta desabilitado entonces se habilita y se habilita el catalogo correspodiente-------------------
                ActivarInactivarValorCatalogo(Me.IntValorCatalogo, True)
                If CBool(dtCatalogos.Rows(Me.grdDatosCatalogos.Row)("Activo")) = False Then
                    ActivarInactivarCatalogo(Me.IntCatalogo, True)
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '==================================================================================================================
    '-- Autor  : Pedro Pablo Tinoco
    '-- Descripcion : Esta funcion se encarga de realizar las validaciones de edicion directa en el grid.
    '==================================================================================================================
    Private Sub EdicionDatosCatalogos()
        Try
            If CBool(dtCatalogos.Rows(Me.grdDatosCatalogos.Row)("Activo")) Then
                If MsgBox("¿Está seguro de cambiar el estado de este catálogo?," + Chr(10) + "El cambio de estado puede afectar funcionamiento dentro del sistema.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    ActivarInactivarCatalogo(Me.IntCatalogo, False)
                    InactivarValores(False)
                End If
            Else
                If VerificarExistencias() Then '--------Verificamos que el catalogo tenga registros asociados.
                    If MsgBox("Es necesario reactivar algunos de los valores asociados" + Chr(10) + " de este catálogo para su activación.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                        CargarValoresCatalogo()
                    End If
                Else
                    MsgBox("No se puede modificar el estado del catálogo " + Chr(10) + "porque no tiene valores asociados.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

#End Region

#Region "Seguridad"
    '-------------------------------------------------------------------------------------------------------------------
    'Autor          : Pedro Pablo Tinoco Salgado
    'Descripcion    : Procedimiento encargado de hacer las correspondientes validaciones de seguridad.
    'Fecha Creacion : jueves 18 de Octubre de 2007.
    '-----------------------------------------------------------------------------------------------------------------
    Private Sub HabilitarOpciones(ByVal Opcion As Integer, ByVal btn As String)
        Try
            '-- Instanciar----
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "frmSrhMantCatalogo"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            Select Case Opcion
                Case 1

                    Select Case btn
                        Case "N"
                            If objSeg.TienePermiso("AgregarCatalogo") Then
                                Me.cmdAgregar.Enabled = True
                            End If

                        Case "ED"
                            If objSeg.TienePermiso("ModificarCatalogo") Then
                                Me.cmdEditar.Enabled = True
                            End If

                        Case "EL"
                            If objSeg.TienePermiso("EliminarCatalogo") Then
                                Me.cmdEliminar.Enabled = True
                            End If

                        Case "IP"
                            If objSeg.TienePermiso("ImprimirCatalogo") Then
                                Me.cmdimprimir.Enabled = True
                            End If
                        Case "AC"
                            If objSeg.TienePermiso("InactivarCatalogo") Then
                                Me.grdDatosCatalogos.AllowUpdate = True
                            End If
                    End Select

                Case 2
                    Select Case btn
                        Case "N"
                            If objSeg.TienePermiso("AgregarValor") Then
                                Me.cmdAgregar.Enabled = True
                            End If

                        Case "ED"
                            If objSeg.TienePermiso("ModificarValor") Then
                                Me.cmdEditar.Enabled = True
                            End If

                        Case "EL"
                            If objSeg.TienePermiso("EliminarValor") Then
                                Me.cmdEliminar.Enabled = True
                            End If

                        Case "IP"
                            If objSeg.TienePermiso("InactivarValor") Then
                                Me.grdDatosvalores.AllowUpdate = True
                            End If

                        Case "AC"
                            If objSeg.TienePermiso("EliminarValor") Then
                                Me.cmdEliminar.Enabled = True
                            End If
                    End Select
            End Select
        Catch ex As SqlClient.SqlException
            clsError.CaptarError(ex)
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSeg = Nothing
        End Try
    End Sub
    '----------------------------------------------------------------------------------------------------------------------

    Private Sub Inhabilitar()
        Me.cmdEliminar.Enabled = False
        Me.cmdEditar.Enabled = False
        Me.cmdAgregar.Enabled = False
        Me.grdDatosCatalogos.AllowUpdate = False
        Me.grdDatosvalores.AllowUpdate = False
    End Sub

#End Region

#Region "Clase Integrada"

    Private Class ClsConsultasCatalogos
        '----------------------------Datos del Catalogo------------------------------------
        Public Const sqlDatosCatalogo As String = " SELECT Codigo,Descripcion,Activo " & _
                                             " FROM vwStbCatValores" & _
                                             " WHERE objCatalogoID = @objCatalogoID"
        '----------------------------------------------------------------------------------

        '---------------------------Existencia de un catalogo------------------------------
        Public Const SqlExistencia As String = " SELECT *  " & _
                                           " FROM  vwStbCatValores " & _
                                           " WHERE objCatalogoId=@objCatalogoId and Activo=1"
        '----------------------------------------------------------------------------------
    End Class


#End Region

End Class



