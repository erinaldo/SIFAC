Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Globalization
Imports System.Windows.Forms

Public Class frmSsgPrincipalSeguridad

#Region "Declaracion de Variables locales a la Clase del formulario frmOrdenEdit"
    'Variable en la que se pasa el Id de la orden a editar o cero si es nueva    
    Private ObjCuentaDt As DataTable
    Private ObjAplicacionDt As DataTable
    Private objSeg As SsgSeguridad
    Private blnAplicarSeguridad As Boolean
#End Region

#Region "Eventos de las opciones contenidas en el Ribbon"
    Private Sub cmdSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Try
            Me.Close()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '------------------------------------------------------------------------------------
    'Nombre del Autor       :   Juan Carlos Herrera Amador
    'Fecha de Creación      :   04 de Septiembre del 2007    
    'Descripción            :   Llama al formulario que permite Administrar la seguridad
    '------------------------------------------------------------------------------------
    'Private Sub LlamarSeguridad()
    '    '--- Declaración ---

    '    Try
    '        '-- Poner el cursor en un estado de ocupado
    '        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

    '        If Not clsProyecto.MostrarFormulario("frmSsgSeguridad", Me) Then
    '            '-- Instancia del formulario de Ordenes (frmOrdenes)
    '            Dim ObjFrmSeguridad As New frmSsgSeguridad
    '            ObjFrmSeguridad.MdiParent = Me
    '            ObjFrmSeguridad.WindowState = FormWindowState.Maximized
    '            ObjFrmSeguridad.Show()
    '        End If
    '        '-- Poner el cursor en un estado de desocupado
    '        Me.Cursor = System.Windows.Forms.Cursors.Default

    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    End Try
    'End Sub
#End Region

#Region "Eventos del Formulario"
    Private Sub frmSsgPrincipalSeguridad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            clsProyecto.CargarTemaDefinido(Me)
            LlenaArbolSeguridad(Nothing)
            '-- Instanciar el objeto seguridad 
            objSeg = New SsgSeguridad
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmPrinSeguridad"

            InicializarForm()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region

#Region "Métodos de Configuración"
    ''' <summary>
    ''' Este metodo se encarga de inicializar el ambiente de Trabajo
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InicializarForm()
        Try
            'InicializarPropiedades()
            CagarInformacionConeccion()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '''' <summary>
    '''' Este metodo tiene como objetivo inicializar las propiedades con que 
    '''' se conecto el sistema
    '''' </summary>
    '''' <remarks></remarks>
    'Private Sub InicializarPropiedades()
    '    Try
    '        Dim info As ConnectionInfo = SqlHelper.GetConnectionInfo()
    '        clsProyecto.SiglasSistema = "SPM"
    '        clsProyecto.RESOURCE_PATH = Application.StartupPath
    '        clsProyecto.Conexion.BaseDeDatos = info.DatabaseName
    '        clsProyecto.Conexion.Servidor = info.ServerName

    '        '-- Reemplazar este valor por la fecha
    '        '-- y hora traida desde el servidor
    '        '-- Inicializar el Timer del formulario principal
    '        clsProyecto.Conexion.FechaServidor = Now
    '        Me.tmrPrincipal.Start()

    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    End Try
    'End Sub

    ''' <summary>
    ''' Se configura el estatus bar con todos los valores de coneccion
    ''' que fueron alimentados con el metodo de inicializacion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CagarInformacionConeccion()
        Try
            Me.Text = clsProyecto.SiglasSistema & " - SubSistema de Seguridad"
            Me.lblBaseDatos.Text = " Base de Datos : " & clsProyecto.Conexion.BaseDeDatos
            Me.lblServidor.Text = " Servidor : " + clsProyecto.Conexion.Servidor
            Me.lblUser.Text = " Usuario : " + clsProyecto.Conexion.Usuario
            Me.lblFecha.Text = " Fecha : " + Date.Now.ToShortDateString()
            Me.lblHora.Text = " Hora : " + DateTime.Now.ToShortTimeString
            Me.tmrPrincipal.Start()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Actualizar la hora cada tick del timer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tmrPrincipal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPrincipal.Tick
        Try
            Me.lblHora.Text = Now.ToShortTimeString()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Manejo de la Seguridad"

#Region "Llenar Arbol Seguridad "
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   04 de Septiembre del 2006
    '-- Descripcion         :   Llenar el arbol de Seguridad con el nodo raiz seguridad 
    '                           y sus nodos principales: Usuarios, Aplicaciones e invoca
    '                           la creación de los nodes hijos de sus nodos principales    
    '-----------------------------------------------------------------------------------

    Private Sub LlenaArbolSeguridad(Optional ByRef NodePadre As System.Windows.Forms.TreeNode = Nothing)
        '--- Declaración ---
        Dim NodeUsuarios As TreeNode
        Dim NodeAplicaciones As TreeNode

        Try
            'If NodePadre Is Nothing Then
            '--- Prepara la carga del árbol
            Me.treeSeguridad.BeginUpdate()
            Me.treeSeguridad.Nodes.Clear()
            Me.treeSeguridad.HideSelection = False

            '-- Crear el nodo raíz del árbol
            Me.treeSeguridad.Nodes.Add(New TreeNode("Seguridad"))
            Me.treeSeguridad.Nodes(0).Name = "Seguridad"
            Me.treeSeguridad.Nodes(0).ImageKey = "Seguridad.gif"
            Me.treeSeguridad.Nodes(0).SelectedImageKey = "Seguridad.gif"
            Me.treeSeguridad.Nodes(0).Tag = "NRAIZ"                'Nodo Raiz

            '-- Crear el nodo raíz de los usuarios
            NodeUsuarios = New TreeNode("Usuarios")
            NodeUsuarios.Name = "Usuarios"
            NodeUsuarios.ImageKey = "Usuarios.gif"
            NodeUsuarios.SelectedImageKey = "Usuarios.gif"
            NodeUsuarios.Tag = "NUSRS"      'Nodo Usuarios


            '-- Crear el nodo raíz de las Aplicaciones
            NodeAplicaciones = New TreeNode("Aplicaciones")
            NodeAplicaciones.Name = "Aplicaciones"
            NodeAplicaciones.ImageKey = "Aplicaciones.gif"
            NodeAplicaciones.SelectedImageKey = "Aplicaciones.gif"
            NodeAplicaciones.Tag = "NAPS"  'Nodo Aplicaciones

            '-- Agregar los Usuarios y Aplicaciones al nodo Seguridad
            Me.treeSeguridad.Nodes(0).Nodes.Add(NodeUsuarios)
            Me.treeSeguridad.Nodes(0).Nodes.Add(NodeAplicaciones)

            LlenaNodeUsuarios(NodeUsuarios)
            LlenaNodeAplicaciones(NodeAplicaciones)

            'End If

            Me.treeSeguridad.EndUpdate()
            Me.treeSeguridad.Nodes(0).Expand()
            Me.treeSeguridad.SelectedNode = Me.treeSeguridad.Nodes(0)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   05 de Septiembre del 2006
    '-- Descripcion         :   crea los nodos hijos(Usuario) del nodo Usuarios        
    '-----------------------------------------------------------------------------------

    Private Sub LlenaNodeUsuarios(ByRef NodeUrs As TreeNode)
        '--- Declaración ---
        Dim i As Integer
        Dim Node As TreeNode
        Try
            '--- Obtener todos los usuarios activos ---
            ObjCuentaDt = SsgCuenta.RetrieveDT(, "Login Asc", "SsgCuentaID,Login,Activo,FechaExpiracion, '' as Espacio")
            '--- Crear los nodos hijos del Nodo Usuarios ---
            For i = 0 To ObjCuentaDt.Rows.Count - 1
                Node = New TreeNode(ObjCuentaDt.Rows(i).Item("Login"))
                Node.Name = ObjCuentaDt.Rows(i).Item("SsgCuentaID")
                Node.ImageKey = "Usuario.gif"
                Node.SelectedImageKey = "Usuario.gif"
                NodeUrs.Nodes.Add(Node)
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   05 de Septiembre del 2006
    '-- Descripcion         :   crea los nodos hijos(Aplicaciones) del nodo Aplicaciones
    '-----------------------------------------------------------------------------------

    Private Sub LlenaNodeAplicaciones(ByRef NodeApls As TreeNode)
        '--- Declaración ---
        Dim ObjSubSistemaDt As DataTable
        Dim ObjRolDt As DataTable
        Dim ObjServicioUsuarioDt As DataTable
        Dim ObjAccion As DataTable
        Dim ObjAccionAutorizada As DataTable
        Dim ObjUsuarioRol As DataTable
        Dim NodeApl As TreeNode     '--Nodo Aplicación (Se lee de la tabla SsgAplicacion)
        Dim NodeMods As TreeNode    '--Contiene los subsistema de cada Aplicación (Se crea en duro)
        Dim NodeRoles As TreeNode   '--Contiene los Roles de cada Aplicacion (Se crea en duro)
        Dim NodeMod As TreeNode     '--Nodo modulo ó Subsistema (se lee de la tabla SsgModulo)
        Dim NodeRol As TreeNode     '--Nodo Rol (Se lee de la tabla SsgRol)
        Dim NodeSus As TreeNode     '--Nodo Servicio Usuario  (Se lee de la tabla SsgServicioUsuario)
        Dim NodeAccs As TreeNode    '--Nodo Acciones (Se crea en duro)
        Dim NodeAcc As TreeNode     '--Nodo Acción (Se lee de la tabla SsgAccion)
        Dim NodeAuts As TreeNode    '--Nodo Acciones Autorizadas (Se crea en duro)
        Dim NodeAut As TreeNode     '--Nodo Acción Autizada por rol 
        Dim NodeUrls As TreeNode    '--Nodo Usuarios que juegan un Rol (Se crea en duro)
        Dim NodeUrl As TreeNode     '--Nodo Usuario que juega un rol 

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim L As Integer
        Try
            '--- Obtener todas las Aplicaciones ---
            ObjAplicacionDt = SsgAplicacion.RetrieveDT(, , "SsgAplicacionID,CodInterno,Nombre,Descripcion")
            '--- Crear los nodos hijos del nodo Aplicaciones ---
            '--- Iteración 1 ----
            For i = 0 To ObjAplicacionDt.Rows.Count - 1
                NodeApl = New TreeNode(ObjAplicacionDt.Rows(i).Item("Nombre"))
                NodeApl.Name = ObjAplicacionDt.Rows(i).Item("SsgAplicacionID")
                NodeApl.ImageKey = "Aplicacion.png"
                NodeApl.SelectedImageKey = "Aplicacion.png"
                NodeApls.Nodes.Add(NodeApl)

                '--- Crear Nodes principales para cada Aplicación
                NodeMods = New TreeNode("Modulos")
                NodeMods.Name = "Modulos"
                NodeMods.ImageKey = "Modulos.gif"
                NodeMods.SelectedImageKey = "Modulos.gif"
                NodeMods.Tag = "NMODS"

                NodeRoles = New TreeNode("Roles")
                NodeRoles.Name = "Roles"
                NodeRoles.ImageKey = "Roles.gif"
                NodeRoles.SelectedImageKey = "Roles.gif"
                NodeRoles.Tag = "NROLS"


                NodeApl.Nodes.Add(NodeMods)
                NodeApl.Nodes.Add(NodeRoles)

                '-------------------------------------------------------------------
                '--- MODULOS :
                '--- Obtener los SubSistemas por Aplicación y
                '--- Crear los nodos hijos del nodo Modulos por Aplicación 
                '--- Iteracion 2 ---
                ObjSubSistemaDt = SsgModulo.RetrieveDT("objAplicacionID = " & ObjAplicacionDt.Rows(i).Item("SsgAplicacionID"))
                For j = 0 To ObjSubSistemaDt.Rows.Count - 1
                    NodeMod = New TreeNode(ObjSubSistemaDt.Rows(j).Item("Nombre"))
                    NodeMod.Name = ObjSubSistemaDt.Rows(j).Item("SsgModuloID")
                    NodeMod.ImageKey = "Modulo.png"
                    NodeMod.SelectedImageKey = "Modulo.png"
                    NodeMod.Tag = "NMOD"
                    NodeMods.Nodes.Add(NodeMod)

                    '--- Obtener los ServiciosUsuarios por Modulo(SubSistema) y
                    '--- Crear los nodos hijos del nodo Modulo(Subsistema)
                    '--- Iteracion 3 ---
                    ObjServicioUsuarioDt = SsgServicioUsuario.RetrieveDT("objModuloID = " & ObjSubSistemaDt.Rows(j).Item("SsgModuloID"))
                    For k = 0 To ObjServicioUsuarioDt.Rows.Count - 1
                        NodeSus = New TreeNode(ObjServicioUsuarioDt.Rows(k).Item("Nombre"))
                        NodeSus.Name = ObjServicioUsuarioDt.Rows(k).Item("SsgServicioUsuarioID")
                        NodeSus.ImageKey = "ServicioUsuario.png"
                        NodeSus.SelectedImageKey = "ServicioUsuario.png"
                        NodeMod.Nodes.Add(NodeSus)

                        '--- Crear Node principal(Acciones) por cada Servicio Usuario
                        NodeAccs = New TreeNode("Acciones")
                        NodeAccs.Name = "Acciones"
                        NodeAccs.ImageKey = "Acciones.gif"
                        NodeAccs.SelectedImageKey = "Acciones.gif"
                        NodeAccs.Tag = "NACCS"
                        NodeSus.Nodes.Add(NodeAccs)

                        '--- Obtener las Acciones por Servicio Usuario y 
                        '--- Crear los nodos hijos de nodo Acciones(Servicios Usuario)
                        '--- Iteracion 4 ---
                        ObjAccion = SsgAccion.RetrieveDT("objServicioUsuarioID = " & ObjServicioUsuarioDt.Rows(k).Item("SsgServicioUsuarioID"))
                        For L = 0 To ObjAccion.Rows.Count - 1
                            NodeAcc = New TreeNode(ObjAccion.Rows(L).Item("Nombre"))
                            NodeAcc.Name = ObjAccion.Rows(L).Item("SsgAccionID")
                            NodeAcc.ImageKey = "Accion.gif"
                            NodeAcc.SelectedImageKey = "Accion.gif"
                            NodeAccs.Nodes.Add(NodeAcc)
                        Next ' Fin Iteracion 4

                    Next ' Fin Iteración 3

                Next ' Fin Iteración 2

                '-------------------------------------------------------------------
                '--- ROLES:
                '--- Obtener los Roles por Aplicación y 
                '--- Crear los nodos hijos del nodo Roles
                '--- Iteracion 5 ---
                ObjRolDt = SsgRol.RetrieveDT("objAplicacionID = " & ObjAplicacionDt.Rows(i).Item("SsgAplicacionID"))
                For j = 0 To ObjRolDt.Rows.Count - 1
                    NodeRol = New TreeNode(ObjRolDt.Rows(j).Item("Nombre"))
                    NodeRol.Name = ObjRolDt.Rows(j).Item("SsgRolID")
                    NodeRol.ImageKey = "Rol.jpg"
                    NodeRol.SelectedImageKey = "Rol.jpg"
                    NodeRol.Tag = "NROL"
                    NodeRoles.Nodes.Add(NodeRol)

                    '--- Crear Nodes principales para cada Rol
                    NodeAuts = New TreeNode("Acciones Autorizadas")
                    NodeAuts.Name = "Acciones Autorizadas"
                    NodeAuts.ImageKey = "AccionesAutorizadas.gif"
                    NodeAuts.SelectedImageKey = "AccionesAutorizadas.gif"
                    NodeAuts.Tag = "NAUTS"

                    NodeUrls = New TreeNode("Usuarios que juegan el rol")
                    NodeUrls.Name = "Usuarios que juegan el rol"
                    NodeUrls.ImageKey = "UsuariosQueJueganUnRol.gif"
                    NodeUrls.SelectedImageKey = "UsuariosQueJueganUnRol.gif"
                    NodeUrls.Tag = "NURLS"

                    NodeRol.Nodes.Add(NodeAuts)
                    NodeRol.Nodes.Add(NodeUrls)

                    '--- Obtener las Acciones Autorizadas por Rol y
                    '--- Crear los nodos hijos del nodo Acciones Autorizadas
                    '--- Iteracion 6 ---
                    ObjAccionAutorizada = SqlHelper.ExecuteQueryDT("SELECT * FROM vwRolAccion WHERE objRolID = " & ObjRolDt.Rows(j).Item("SsgRolID"))
                    For k = 0 To ObjAccionAutorizada.Rows.Count - 1
                        NodeAut = New TreeNode(ObjAccionAutorizada.Rows(k).Item("NombreAccion"))
                        NodeAut.Name = ObjAccionAutorizada.Rows(k).Item("SsgRolAccionID")
                        NodeAut.ImageKey = "Accion.gif"
                        NodeAut.SelectedImageKey = "Accion.gif"
                        NodeAuts.Nodes.Add(NodeAut)
                    Next ' Fin Iteracion 6

                    '--- Obtener los Usuarios por Rol y
                    '--- Crear los nodos hijos del nodo Usuarios que juegan un Rol
                    '--- Iteracion 7 ---
                    ObjUsuarioRol = SqlHelper.ExecuteQueryDT("SELECT * FROM vwCuentaRol WHERE objRolID = " & ObjRolDt.Rows(j).Item("SsgRolID"))
                    For L = 0 To ObjUsuarioRol.Rows.Count - 1
                        NodeUrl = New TreeNode(ObjUsuarioRol.Rows(L).Item("Login"))
                        NodeUrl.Name = ObjUsuarioRol.Rows(L).Item("SsgCuentaRolID")
                        NodeUrl.ImageKey = "Usuario.gif"
                        NodeUrl.SelectedImageKey = "Usuario.gif"
                        NodeUrls.Nodes.Add(NodeUrl)
                    Next ' Fin Iteracion 7

                Next ' Fin Iteración 5

            Next ' Fin Iteración 1

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Evento del Arbol Seguridad"
    Private Sub treeSeguridad_AfterSelect_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeSeguridad.AfterSelect
        '--- Declaración ----
        Dim ID As Integer
        Try
            Select Case e.Node.Tag
                Case "NRAIZ"
                    '--- Deshabilitar las opciones del toolbar  
                    HabilitarDeshabilitar(False, False, False)
                Case "NUSRS"            '--- Nodo Usuarios                   
                    CargarUsuarios()
                    HabilitarDeshabilitar(True, False, False)
                    Me.tsbNuevo.ToolTipText = "Agregar Nuevo Usuario"

                Case "NAPS"             '--- Nodo Aplicaciones
                    CargarAplicaciones()
                    HabilitarDeshabilitar(True, False, False)
                    Me.tsbNuevo.ToolTipText = "Agregar Nueva Aplicación"

                Case "NMODS"            '--- Nodo Modulos
                    '--- ID de la Aplicación
                    ID = CInt(e.Node.Parent.Name)
                    CargarModulos(ID)
                    HabilitarDeshabilitar(True, False, False)
                    Me.tsbNuevo.ToolTipText = "Agregar Nuevo Módulo"

                Case "NMOD"             '--- Nodo Modulo
                    '--- ID Modulo
                    ID = CInt(e.Node.Name)
                    CargarServiciosUsuarios(ID)
                    HabilitarDeshabilitar(True, True, True)
                    Me.tsbNuevo.ToolTipText = "Agregar Servicio de Usuario"
                    Me.tsbEditar.ToolTipText = "Editar Módulo"
                    Me.tsbEliminar.ToolTipText = "Eliminar Módulo"

                Case "NACCS"            '--- Nodo Acciones
                    '--- ID del Servicio de Usuarios
                    ID = CInt(e.Node.Parent.Name)
                    CargarAcciones(ID)
                    HabilitarDeshabilitar(True, False, False)
                    Me.tsbNuevo.ToolTipText = "Agregar Nueva Acción"

                Case "NROLS"            '--- Nodo Roles
                    '--- ID de la Aplicaión
                    ID = CInt(e.Node.Parent.Name)
                    CargarRoles(ID)
                    HabilitarDeshabilitar(True, False, False)
                    Me.tsbNuevo.ToolTipText = "Agregar Nuevo Rol"

                Case "NAUTS"            '--- Nodo Acciones Autorizadas
                    '--- ID del Rol
                    ID = CInt(e.Node.Parent.Name)
                    CargarAccinesAutorizadas(ID)
                    HabilitarDeshabilitar(False, False, False)

                Case "NURLS"            '--- Nodo Usuarios que juegan el rol
                    '--- ID del Rol
                    ID = CInt(e.Node.Parent.Name)
                    CargarUsuariosJueganRol(ID)
                    HabilitarDeshabilitar(False, False, False)

                Case Else
                    Select Case e.Node.Parent.Tag
                        Case "NUSRS"
                            Me.tsbEditar.ToolTipText = "Editar Usuario"
                            Me.tsbEliminar.ToolTipText = "Eliminar Usuario"

                        Case "NAPS"
                            Me.tsbEditar.ToolTipText = "Editar Aplicación"
                            Me.tsbEliminar.ToolTipText = "Eliminar Aplicación"

                        Case "NMOD"
                            Me.tsbEditar.ToolTipText = "Editar Servicio de Usuario"
                            Me.tsbEliminar.ToolTipText = "Eliminar Serviciio de Usuario"

                        Case "NACCS"
                            Me.tsbEditar.ToolTipText = "Editar Acción"
                            Me.tsbEliminar.ToolTipText = "Eliminar Acción"

                        Case "NROLS"
                            Me.tsbEditar.ToolTipText = "Editar Rol"
                            Me.tsbEliminar.ToolTipText = "Eliminar Rol"

                        Case "NURLS"
                            Me.tsbEliminar.ToolTipText = "Eliminar Rol al Usuario"

                    End Select

                    If e.Node.Parent.Tag = "NURLS" Or e.Node.Parent.Tag = "NAUTS" Then
                        HabilitarDeshabilitar(False, False, True)
                    Else
                        HabilitarDeshabilitar(False, True, True)
                    End If

                    '--- Limpiar Grid
                    Me.grdSeguridad.DataSource = SqlHelper.ExecuteQueryDT("Select '' as Seguridad ")
                    Me.grdSeguridad.Columns("Seguridad").Caption = ""
                    Me.grdSeguridad.Caption = " "

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Métodos para cargar el grid"

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Carga los Usuarios el nodo Usuarios
    '-----------------------------------------------------------------------------------
    Private Sub CargarUsuarios()
        Try
            Me.grdSeguridad.DataSource = SsgCuenta.RetrieveDT(, , "*")
            Me.grdSeguridad.Caption = "(" & Me.grdSeguridad.Splits(0).Rows.Count & " Usuarios)"

            '--- Formatear Grid ----
            Me.grdSeguridad.Splits(0).DisplayColumns("SsgCuentaID").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("Clave").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("objEmpleadoID").Visible = False

            '--Alineación
            Me.grdSeguridad.Splits(0).DisplayColumns("Login").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignVertEnum.Bottom

            '--- No permitir la edición sobre cada columna
            Me.grdSeguridad.Splits(0).DisplayColumns("Login").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Activo").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("FechaExpiracion").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("UsuarioCreacion").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("FechaCreacion").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("UsuarioModificacion").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("FechaModificacion").Locked = True

            Me.grdSeguridad.Splits(0).DisplayColumns("UsuarioModificacion").Width = 150

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Carga los Aplicaciones del nodo Aplicaciones
    '-----------------------------------------------------------------------------------
    Private Sub CargarAplicaciones()
        Try
            Me.grdSeguridad.DataSource = SsgAplicacion.RetrieveDT(, , "SsgAplicacionID, CodInterno,Nombre,Descripcion")
            '--- Formatear Grid ---
            Me.grdSeguridad.Splits(0).DisplayColumns("SsgAplicacionID").Visible = False
            Me.grdSeguridad.Caption = "(" & ObjAplicacionDt.Rows.Count & " Aplicaciones)"

            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Width = 200

            '-- Caption
            Me.grdSeguridad.Columns("CodInterno").Caption = "Código"

            '--- No permitir la edición sobre cada columna
            Me.grdSeguridad.Splits(0).DisplayColumns("CodInterno").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Descripcion").Locked = True

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Carga los Modulos de un nodo Modulo 
    '-----------------------------------------------------------------------------------
    Private Sub CargarModulos(ByVal IdApl As Integer)
        Try
            Me.grdSeguridad.DataSource = SsgModulo.RetrieveDT("objAplicacionID = " & IdApl, , "SsgModuloID,CodInterno,Nombre,Descripcion")
            Me.grdSeguridad.Caption = "(" & Me.grdSeguridad.Splits(0).Rows.Count & " Modulos)"

            '--- Formatear Grid ---
            Me.grdSeguridad.Splits(0).DisplayColumns("SsgModuloID").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Width = 200

            '-- Caption
            Me.grdSeguridad.Columns("CodInterno").Caption = "Código"

            '--- No permitir la edición sobre cada columna
            Me.grdSeguridad.Splits(0).DisplayColumns("CodInterno").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Descripcion").Locked = True

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Carga los Servicios Usuarios de un nodo Modulo
    '-----------------------------------------------------------------------------------
    Private Sub CargarServiciosUsuarios(ByVal IdMod As Integer)
        Try
            Me.grdSeguridad.DataSource = SsgServicioUsuario.RetrieveDT("objModuloID = " & IdMod, , "SsgServicioUsuarioID,CodInterno,Nombre,Descripcion")
            Me.grdSeguridad.Caption = "(" & Me.grdSeguridad.Splits(0).Rows.Count & " Servicios de Usuarios)"

            '--- Formatear Grid ---
            Me.grdSeguridad.Splits(0).DisplayColumns("SsgServicioUsuarioID").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Width = 250

            '-- Caption
            Me.grdSeguridad.Columns("CodInterno").Caption = "Código"
            Me.grdSeguridad.Splits(0).DisplayColumns("Código").Width = 250

            '--- No permitir la edición sobre cada columna
            Me.grdSeguridad.Splits(0).DisplayColumns("CodInterno").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Descripcion").Locked = True


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Carga las acciones de un nodo de ServiciosUsuarios
    '-----------------------------------------------------------------------------------
    Private Sub CargarAcciones(ByVal IdSus As Integer)
        Try
            Me.grdSeguridad.DataSource = SsgAccion.RetrieveDT("objServicioUsuarioID = " & IdSus, , "SsgAccionID,CodInterno,Nombre,Descripcion")
            Me.grdSeguridad.Caption = "(" & Me.grdSeguridad.Splits(0).Rows.Count & " Acciones)"

            '--- Formatear Grid ---
            Me.grdSeguridad.Splits(0).DisplayColumns("SsgAccionID").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Width = 200
            Me.grdSeguridad.Splits(0).DisplayColumns("CodInterno").Width = 200

            '-- Caption
            Me.grdSeguridad.Columns("CodInterno").Caption = "Código"

            '--- No permitir la edición sobre cada columna
            Me.grdSeguridad.Splits(0).DisplayColumns("CodInterno").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Descripcion").Locked = True


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Carga los roles del nodo Roles
    '-----------------------------------------------------------------------------------
    Private Sub CargarRoles(ByVal IdApl As Integer)
        Try
            Me.grdSeguridad.DataSource = SsgRol.RetrieveDT("objAplicacionID = " & IdApl, , "SsgRolID,Nombre,Descripcion")
            Me.grdSeguridad.Caption = "(" & Me.grdSeguridad.Splits(0).Rows.Count & " Roles)"

            '--- Formatear Grid ---
            Me.grdSeguridad.Splits(0).DisplayColumns("SsgRolID").Visible = False

            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Width = 200

            '--- No permitir la edición sobre cada columna
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Descripcion").Locked = True

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Carga las Acciones Autorizadas del nodo Rol
    '-----------------------------------------------------------------------------------
    Private Sub CargarAccinesAutorizadas(ByVal IdRol As Integer)
        Try
            Me.grdSeguridad.DataSource = SqlHelper.ExecuteQueryDT("SELECT *, '' as Espacio FROM vwRolAccion WHERE objRolID = " & IdRol)
            Me.grdSeguridad.Caption = "(" & Me.grdSeguridad.Splits(0).Rows.Count & " Acciones Autorizadas)"

            '--- Formartear Grid
            Me.grdSeguridad.Splits(0).DisplayColumns("SsgRolAccionID").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("objAccionID").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("objRolID").Visible = False

            Me.grdSeguridad.Splits(0).DisplayColumns("NombreAccion").Width = 250
            Me.grdSeguridad.Splits(0).DisplayColumns("NombreRol").Width = 200

            '-- Caption
            Me.grdSeguridad.Columns("NombreAccion").Caption = "Acción"
            Me.grdSeguridad.Columns("NombreRol").Caption = "Rol"
            Me.grdSeguridad.Columns("Espacio").Caption = ""

            '--- No permitir la edición sobre cada columna
            Me.grdSeguridad.Splits(0).DisplayColumns("NombreAccion").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("NombreRol").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Espacio").Locked = True


        Catch ex As Exception

        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Carga los Usuarios que juegan el Rol
    '-----------------------------------------------------------------------------------
    Private Sub CargarUsuariosJueganRol(ByVal IdRol As Integer)
        Try
            Me.grdSeguridad.DataSource = SqlHelper.ExecuteQueryDT("SELECT *,'' as Espacio FROM vwCuentaRol WHERE objRolID = " & IdRol)
            Me.grdSeguridad.Caption = "(" & Me.grdSeguridad.Splits(0).Rows.Count & " Usuario(s) Asignado(s) al Rol)"

            '--- Formatear Grid
            Me.grdSeguridad.Splits(0).DisplayColumns("SsgCuentaRolID").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("objCuentaID").Visible = False
            Me.grdSeguridad.Splits(0).DisplayColumns("objRolID").Visible = False

            Me.grdSeguridad.Splits(0).DisplayColumns("Login").Width = 200
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Width = 200

            '-- Caption
            Me.grdSeguridad.Columns("Nombre").Caption = "Rol"
            Me.grdSeguridad.Columns("Espacio").Caption = ""

            '--- No permitir la edición sobre cada columna
            Me.grdSeguridad.Splits(0).DisplayColumns("Login").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Nombre").Locked = True
            Me.grdSeguridad.Splits(0).DisplayColumns("Espacio").Locked = True

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Habilita ó Deshabilita las opciones del toolbar segun el
    '                           nodo seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub HabilitarDeshabilitar(ByVal blnNuevo As Boolean, ByVal blnEditar As Boolean, ByVal blnEliminar As Boolean)
        Try
            Me.tsbNuevo.Enabled = blnNuevo
            Me.tsbEditar.Enabled = blnEditar
            Me.tsbEliminar.Enabled = blnEliminar
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos de los botones del toolbar"

    Private Sub tsbNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '--- Declaración ---
        Dim NodeSeleccionado As TreeNode
        Try
            Me.Cursor = Cursors.WaitCursor
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            NodeSeleccionado = Me.treeSeguridad.SelectedNode

            Select Case NodeSeleccionado.Tag

                Case "NUSRS"
                    If objSeg.TienePermiso("AgregarCuentaUsuario") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarCuenta(0)
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                              "para agregar un nuevo usuario.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NAPS"
                    If objSeg.TienePermiso("AgregarApp") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarAplicacion(0)
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                        "para agregar una nueva aplicación.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NMODS"
                    If objSeg.TienePermiso("AgregarModulo") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarModulo(0, CInt(NodeSeleccionado.Parent.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                               "para agregar un nuevo módulo.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NMOD"

                    If objSeg.TienePermiso("AgregarServUsuario") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarServicioUsuario(0, CInt(NodeSeleccionado.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                               "para agregar un nuevo Servicio de Usuario.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NACCS"
                    If objSeg.TienePermiso("AgregarAccion") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarAccion(0, CInt(NodeSeleccionado.Parent.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                               "para agregar una nueva Acción.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NROLS"
                    If objSeg.TienePermiso("AgregarRol") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarRol(0, CInt(NodeSeleccionado.Parent.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                              "para agregar un nuevo Rol.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If
                Case "NAUTS"
                Case "NURLS"
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub tsbEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '--- Declaración ---
        Dim NodeSeleccionado As TreeNode
        Try
            Me.Cursor = Cursors.WaitCursor
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            NodeSeleccionado = Me.treeSeguridad.SelectedNode

            '--- Verificar el padre del nodo para identificar
            '--- el elemento(Usuario,Aplicación,Modulo,ServicioUsuario, etc)
            '--- a(eliminación)

            Select Case NodeSeleccionado.Parent.Tag
                Case "NUSRS"
                    If objSeg.TienePermiso("EliminarCuentaUsuario") Or clsProyecto.blnAplicarSeguridad = False Then
                        If MsgBox("¿Está seguro de eliminar el Usuario seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            EliminarUsuario(NodeSeleccionado)
                        End If
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene " & Chr(10) & _
                              "permisos una cuenta de Usuario.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NAPS"
                    If objSeg.TienePermiso("EliminarApp") Or clsProyecto.blnAplicarSeguridad = False Then
                        If MsgBox("¿Está seguro de eliminar la Aplicación seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            EliminarAplicacion(NodeSeleccionado)
                        End If
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene " & Chr(10) & _
                               "permiso para eliminar una Aplicación.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NMODS"
                    If objSeg.TienePermiso("EliminarModulo") Or clsProyecto.blnAplicarSeguridad = False Then
                        If MsgBox("¿Está seguro de eliminar el Módulo seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            EliminarModulo(NodeSeleccionado)
                        End If
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene " & Chr(10) & _
                               "permisos para eliminar módulos.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NMOD"
                    If objSeg.TienePermiso("EliminarServUsuario") Or clsProyecto.blnAplicarSeguridad = False Then
                        If MsgBox("¿Está seguro de eliminar el Servicio de Usuario seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            EliminarServicioUsuario(NodeSeleccionado)
                        End If
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene " & Chr(10) & _
                               "permisos para eliminar servicios de Usuario.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If


                Case "NACCS"
                    If objSeg.TienePermiso("EliminarAccion") Or clsProyecto.blnAplicarSeguridad = False Then
                        If MsgBox("¿Está seguro de eliminar la Acción seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            EliminarAccion(NodeSeleccionado)
                        End If
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene" & Chr(10) & _
                               "permiso para eliminar acciones.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NROLS"
                    If objSeg.TienePermiso("EliminarRol") Or clsProyecto.blnAplicarSeguridad = False Then
                        If MsgBox("¿Está seguro de eliminar el Rol seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            EliminarRol(NodeSeleccionado)
                        End If
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene" & Chr(10) & _
                               "permisos para eliminar roles.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NAUTS"
                    If objSeg.TienePermiso("EliminarAccion") Or clsProyecto.blnAplicarSeguridad = False Then
                        If MsgBox("¿Está seguro de eliminar la Acción del Rol seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            ElimanarRolAccion(NodeSeleccionado)
                        End If
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene" & Chr(10) & _
                               "permisos para eliminar acciones.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NURLS"
                    If objSeg.TienePermiso("EliminarRol") Or clsProyecto.blnAplicarSeguridad = False Then
                        If MsgBox("¿Está seguro de quitar este Rol al usuario seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            EliminarCuentaRol(NodeSeleccionado)
                        End If
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene" & Chr(10) & _
                               "permisos para eliminar Roles.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub tsbEditar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '--- Declaración ---
        Dim NodeSeleccionado As TreeNode
        Try

            Me.Cursor = Cursors.WaitCursor
            'Verificar si hay un Nodo seleccionado
            If Me.treeSeguridad.SelectedNode Is Nothing Then
                Exit Sub
            End If

            objSeg.Usuario = clsProyecto.Conexion.Usuario
            NodeSeleccionado = Me.treeSeguridad.SelectedNode

            Select Case NodeSeleccionado.Parent.Tag
                Case "NUSRS"
                    If objSeg.TienePermiso("EditarCuentaUsuario") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarCuenta(CInt(NodeSeleccionado.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                                "para modificar los datos del Usuario seleccionado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NAPS"
                    If objSeg.TienePermiso("EditarApp") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarAplicacion(CInt(NodeSeleccionado.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                               "para modificar los datos de una aplicación.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NMODS"
                    If objSeg.TienePermiso("EditarModulo") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarModulo(CInt(NodeSeleccionado.Name), CInt(NodeSeleccionado.Parent.Parent.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso " & Chr(10) & _
                               "para modificar los datos del módulo seleccionado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NMOD"
                    If objSeg.TienePermiso("EditarServUsuario") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarServicioUsuario(CInt(NodeSeleccionado.Name), CInt(NodeSeleccionado.Parent.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permiso para " & Chr(10) & _
                               "modificar los datos del Servicio de Usuario seleccionado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NACCS"
                    If objSeg.TienePermiso("EditarAccion") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarAccion(CInt(NodeSeleccionado.Name), CInt(NodeSeleccionado.Parent.Parent.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permisos para " & Chr(10) & _
                               "modificar la acción del Servicio de Usuario seleccionado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NROLS"
                    If objSeg.TienePermiso("EditarRol") Or clsProyecto.blnAplicarSeguridad = False Then
                        EditarRol(CInt(NodeSeleccionado.Name), CInt(NodeSeleccionado.Parent.Parent.Name))
                    Else
                        MsgBox("El usuario " & UCase(clsProyecto.Conexion.Usuario) & " no tiene permisos " & Chr(10) & _
                               "para modificar el Rol seleccionado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If

                Case "NAUTS"
                Case "NURLS"
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Operaciones de Edición"

#Region "Eliminar"
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Elimina el usuario Seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub EliminarUsuario(ByRef Node As TreeNode)
        Try
            '--- Eliminar el usuario seleccionado
            SsgCuenta.Delete(CInt(Node.Name))
            ActualizarArbol(Node)

        Catch sqlEx As SqlClient.SqlException
            clsError.CaptarError(sqlEx)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Elimina un rol al usuario seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub EliminarCuentaRol(ByRef Node As TreeNode)
        Try
            '--- Quitar el Rol al usuario seleccionado
            SsgCuentaRol.Delete(CInt(Node.Name))
            ActualizarArbol(Node)

        Catch sqlEx As SqlClient.SqlException
            clsError.CaptarError(sqlEx)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Elimina la acción seleccionada de un servicio de usuario
    '-----------------------------------------------------------------------------------
    Private Sub EliminarAccion(ByRef Node As TreeNode)
        Try
            '--- Eliminar la acción seleccionada
            SsgAccion.Delete(CInt(Node.Name))
            ActualizarArbol(Node)

        Catch sqlEx As SqlClient.SqlException
            clsError.CaptarError(sqlEx)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Elimina el servicio de usuario seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub EliminarServicioUsuario(ByRef Node As TreeNode)
        Try
            '--- Eliminar la acción seleccionada
            SsgServicioUsuario.Delete(CInt(Node.Name))
            ActualizarArbol(Node)

        Catch sqlEx As SqlClient.SqlException
            clsError.CaptarError(sqlEx)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Elimina una acción al rol seleccionado
    '-----------------------------------------------------------------------------------

    Private Sub ElimanarRolAccion(ByRef Node As TreeNode)
        Try
            '--- Eliminar la acción seleccionada
            SsgRolAccion.Delete(CInt(Node.Name))
            ActualizarArbol(Node)

        Catch sqlEx As SqlClient.SqlException
            clsError.CaptarError(sqlEx)
        Catch ex As Exception
            clsError.CaptarError(ex)

        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Elimina el Modulo  seleccionado
    '-----------------------------------------------------------------------------------

    Private Sub EliminarModulo(ByRef Node As TreeNode)
        Try
            '--- Eliminar la acción seleccionada
            SsgModulo.Delete(CInt(Node.Name))
            ActualizarArbol(Node)

        Catch sqlEx As SqlClient.SqlException
            clsError.CaptarError(sqlEx)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Elimina el Rol seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub EliminarRol(ByRef Node As TreeNode)
        Try
            '--- Eliminar la acción seleccionada
            SsgRol.Delete(CInt(Node.Name))
            ActualizarArbol(Node)
        Catch sqlEx As SqlClient.SqlException
            clsError.CaptarError(sqlEx)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Elimina la Aplicacion seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub EliminarAplicacion(ByRef Node As TreeNode)
        Try
            '--- Eliminar la acción seleccionada
            SsgAplicacion.Delete(CInt(Node.Name))
            ActualizarArbol(Node)

        Catch sqlEx As SqlClient.SqlException
            clsError.CaptarError(sqlEx)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Parametros Entrada  :   
    '-- Descripcion         :   Actualiza el node seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub ActualizarArbol(ByRef Node As TreeNode)
        Try
            '--- Ubicarse en el nodo anterior
            If Node.Parent.Nodes.Count <= 1 Then
                Me.treeSeguridad.SelectedNode = Node.Parent

            ElseIf Not CompareInfo.Equals(Node.Parent.FirstNode, Node) Then
                Me.treeSeguridad.SelectedNode = Node.PrevNode
            End If
            '--- Remover el nodo seleccionado
            Node.Parent.Nodes.Remove(Node)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Editar"
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   12 de Septiembre del 2007
    '-- Descripcion         :   Llama al formulario que permite el registro de una nueva
    '--                         Cuenta
    '-----------------------------------------------------------------------------------
    Private Sub EditarCuenta(ByVal CuentaID As Integer)
        '--- Declaración ---
        Dim objfrm As frmSsgEditCuenta
        Try
            '--- Instanciar ---
            objfrm = New frmSsgEditCuenta
            objfrm.CuentaID = CuentaID

            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ActualizarCuenta(objfrm.CuentaID)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Llama el formulario que permite editar una nueva Aplicación
    '-----------------------------------------------------------------------------------
    Private Sub EditarAplicacion(ByVal AplicacionID As Integer)
        '--- Declarar variable y objetos ---
        Dim objfrm As frmSsgEditAplicacion
        Try
            '--- Instanciar ---
            objfrm = New frmSsgEditAplicacion
            objfrm.AplicacionID = AplicacionID

            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ActualizarNodoApl(objfrm.AplicacionID)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Llama el formulario que permite editar un modulo
    '-----------------------------------------------------------------------------------
    Private Sub EditarModulo(ByVal ModuloID As Integer, ByVal AplicacioID As Integer)
        '--- Declarar variables y objetos ---
        Dim objfrm As frmSsgEditModulo
        Try
            '--- Instanciar ---
            objfrm = New frmSsgEditModulo
            objfrm.ModuloID = ModuloID
            objfrm.AplicacionID = AplicacioID

            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ActualizarNodoMod(objfrm.ModuloID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Llama el formulario que permite registrar un nuevo servicio
    '--                         de usuario al modulo seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub EditarServicioUsuario(ByVal ServicioID As Integer, ByVal ModuloID As Integer)
        '--- Declaración ---
        Dim objfrm As frmSsgEditServUsuarios
        Try
            '--- Instanciar ---
            objfrm = New frmSsgEditServUsuarios
            objfrm.ServicioID = ServicioID
            objfrm.ModuloID = ModuloID

            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ActualizarNodeSus(objfrm.ServicioID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Llama el formulario que permite registrar una nueva acción
    '--                         al servicio de usuario seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub EditarAccion(ByVal AccionID As Integer, ByVal ServicioID As Integer)
        '--- Declaración ---
        Dim objfrm As frmSsgEditAccion
        Try
            '--- Instanciar ---
            objfrm = New frmSsgEditAccion
            objfrm.AccionID = AccionID
            objfrm.ServUsuarioID = ServicioID


            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ActualizarNodeAcc(objfrm.AccionID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   06 de Septiembre del 2007
    '-- Descripcion         :   Llama el formulario que permite registrar un nuevo rol 
    '--                         a la aplicación seleccionada
    '-----------------------------------------------------------------------------------
    Private Sub EditarRol(ByVal RolID As Integer, ByVal AplicacionID As Integer)
        '--- Declaracion ---
        Dim objfrm As frmSsgEditRol
        Try
            '--- Instanciar ---
            objfrm = New frmSsgEditRol
            objfrm.RolID = RolID
            objfrm.AplicacionID = AplicacionID

            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ActualizarNodeRol(objfrm.RolID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Metodos Para Actualizar un Nodo"
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   24 de Septiembre del 2007
    '-- Descripcion         :   Actualiza el Nodo seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub ActualizarCuenta(ByVal CuentaID As Integer)
        Dim ObjCuenta As SsgCuenta
        Dim NodeApls As TreeNode
        Dim strLogin As String
        Try
            ObjCuenta = New SsgCuenta
            ObjCuenta.Retrieve(CuentaID)

            If Me.treeSeguridad.SelectedNode.Tag = "NUSRS" Then
                NodeApls = Me.treeSeguridad.SelectedNode.NextNode
                NodeApls.Nodes.Clear()
                Me.treeSeguridad.SelectedNode.Nodes.Clear()
                LlenaNodeUsuarios(Me.treeSeguridad.SelectedNode)
                LlenaNodeAplicaciones(NodeApls)
                NodeApls.Expand()
            Else
                strLogin = Me.treeSeguridad.SelectedNode.Text
                Me.treeSeguridad.SelectedNode.Text = ObjCuenta.Login
                NodeApls = Me.treeSeguridad.SelectedNode.Parent.NextNode
                NodeApls.Nodes.Clear()
                LlenaNodeAplicaciones(NodeApls)
                NodeApls.Expand()

                '--- Verificar sí el cuenta sí el usuario conectado modificó
                '--- su propia cuenta
                If UCase(strLogin) = UCase(clsProyecto.Conexion.Usuario) Then
                    clsProyecto.Conexion.Usuario = ObjCuenta.Login
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   08 de Septiembre del 2007
    '-- Descripcion         :   Actualiza el Nodo seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub ActualizarNodoApl(ByVal AplicacionID As Integer)
        Dim NodeApl As TreeNode
        Dim NodeMods As TreeNode
        Dim objApl As SsgAplicacion
        Dim NodeRoles As TreeNode
        Try
            objApl = New SsgAplicacion
            objApl.Retrieve(AplicacionID)

            If Me.treeSeguridad.SelectedNode.Tag = "NAPS" Then
                NodeApl = New TreeNode(objApl.Nombre)
                NodeApl.Name = objApl.SsgAplicacionID
                NodeApl.ImageKey = "Aplicacion.png"
                NodeApl.SelectedImageKey = "Aplicacion.png"
                Me.treeSeguridad.SelectedNode.Nodes.Add(NodeApl)

                '--- Crear Nodes principales para la Aplicación
                NodeMods = New TreeNode("Modulos")
                NodeMods.Name = "Modulos"
                NodeMods.ImageKey = "Modulos.png"
                NodeMods.SelectedImageKey = "Modulos.png"
                NodeMods.Tag = "NMODS"

                NodeRoles = New TreeNode("Roles")
                NodeRoles.Name = "Roles"
                NodeRoles.ImageKey = "Roles.png"
                NodeRoles.SelectedImageKey = "Roles.png"
                NodeRoles.Tag = "NROLS"

                NodeApl.Nodes.Add(NodeMods)
                NodeApl.Nodes.Add(NodeRoles)

                Me.treeSeguridad.SelectedNode = NodeApl
            Else
                Me.treeSeguridad.SelectedNode.Text = objApl.Nombre
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   08 de Septiembre del 2007
    '-- Descripcion         :   Actualiza el nodo seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub ActualizarNodoMod(ByVal ModuloID As Integer)
        Dim objMod As SsgModulo
        Dim NodeMod As TreeNode
        Try
            objMod = New SsgModulo
            objMod.Retrieve(ModuloID)

            If Me.treeSeguridad.SelectedNode.Tag = "NMODS" Then
                NodeMod = New TreeNode(objMod.Nombre)
                NodeMod.Name = objMod.SsgModuloID
                NodeMod.ImageKey = "Modulo.png"
                NodeMod.SelectedImageKey = "Modulo.png"
                NodeMod.Tag = "NMOD"
                Me.treeSeguridad.SelectedNode.Nodes.Add(NodeMod)

                Me.treeSeguridad.SelectedNode = NodeMod
            Else
                Me.treeSeguridad.SelectedNode.Text = objMod.Nombre
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   10 de Septiembre del 2007
    '-- Descripcion         :   Actualiza el nodo seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub ActualizarNodeSus(ByVal ServicioID As Integer)
        '--- Declaración ---
        Dim objServicio As SsgServicioUsuario
        Dim NodeAccs As TreeNode
        Dim NodeSus As TreeNode
        Try
            objServicio = New SsgServicioUsuario()
            objServicio.Retrieve(ServicioID)

            If Me.treeSeguridad.SelectedNode.Tag = "NMOD" Then
                NodeSus = New TreeNode(objServicio.Nombre)
                NodeSus.Name = objServicio.SsgServicioUsuarioID
                NodeSus.ImageKey = "ServicioUsuario.png"
                NodeSus.SelectedImageKey = "ServicioUsuario.png"
                Me.treeSeguridad.SelectedNode.Nodes.Add(NodeSus)

                '--- Crear Node principal(Acciones) para el nuevo Servicio Usuario
                NodeAccs = New TreeNode("Acciones")
                NodeAccs.Name = "Acciones"
                NodeAccs.ImageKey = "Acciones.png"
                NodeAccs.SelectedImageKey = "Acciones.png"
                NodeAccs.Tag = "NACCS"
                NodeSus.Nodes.Add(NodeAccs)

                Me.treeSeguridad.SelectedNode = NodeSus

            Else
                Me.treeSeguridad.SelectedNode.Text = objServicio.Nombre
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   12 de Septiembre del 2007
    '-- Descripcion         :   Actualiza el nodo seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub ActualizarNodeAcc(ByVal AccionID As Integer)
        '---Declaración ---
        Dim objAccion As SsgAccion
        Dim NodeAcc As TreeNode
        Try
            '--- Instanciar ---
            objAccion = New SsgAccion
            objAccion.Retrieve(AccionID)

            If Me.treeSeguridad.SelectedNode.Tag = "NACCS" Then
                NodeAcc = New TreeNode(objAccion.Nombre)
                NodeAcc.Name = objAccion.SsgAccionID
                NodeAcc.ImageKey = "Accion.gif"
                NodeAcc.SelectedImageKey = "Accion.gif"
                Me.treeSeguridad.SelectedNode.Nodes.Add(NodeAcc)

                Me.treeSeguridad.SelectedNode = NodeAcc
            Else
                Me.treeSeguridad.SelectedNode.Text = objAccion.Nombre
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Juan Carlos Herrera Amador
    '-- Fecha de Creación   :   12 de Septiembre del 2007
    '-- Descripcion         :   Actualiza el nodo seleccionado
    '-----------------------------------------------------------------------------------
    Private Sub ActualizarNodeRol(ByVal RolID As Integer)
        Dim objRol As SsgRol
        Dim NodeRol As TreeNode
        Dim NodeAuts As TreeNode
        Dim NodeUrls As TreeNode
        Dim NodeAut As TreeNode
        Dim ObjAccionAutorizada As DataTable
        Dim k As Integer
        Try
            '--- Instanciar ---
            objRol = New SsgRol
            objRol.Retrieve(RolID)

            If Me.treeSeguridad.SelectedNode.Tag = "NROLS" Then
                NodeRol = New TreeNode(objRol.Nombre)
                NodeRol.Name = objRol.SsgRolID
                NodeRol.ImageKey = "Rol.jpg"
                NodeRol.SelectedImageKey = "Rol.jpg"
                NodeRol.Tag = "NROL"
                Me.treeSeguridad.SelectedNode.Nodes.Add(NodeRol)


                '--- Crear Nodes principales para el Rol
                NodeAuts = New TreeNode("Acciones Autorizadas")
                NodeAuts.Name = "Acciones Autorizadas"
                NodeAuts.ImageKey = "AccionesAutorizadas.gif"
                NodeAuts.SelectedImageKey = "AccionesAutorizadas.gif"
                NodeAuts.Tag = "NAUTS"

                NodeUrls = New TreeNode("Usuarios que juegan el rol")
                NodeUrls.Name = "Usuarios que juegan el rol"
                NodeUrls.ImageKey = "UsuariosQueJueganUnRol.png"
                NodeUrls.SelectedImageKey = "UsuariosQueJueganUnRol.png"
                NodeUrls.Tag = "NURLS"

                NodeRol.Nodes.Add(NodeAuts)
                NodeRol.Nodes.Add(NodeUrls)

                '--- Obtener las Acciones Autorizadas por Rol y             
                ObjAccionAutorizada = SqlHelper.ExecuteQueryDT("SELECT * FROM vwRolAccion WHERE objRolID = " & objRol.SsgRolID)
                For k = 0 To ObjAccionAutorizada.Rows.Count - 1
                    NodeAut = New TreeNode(ObjAccionAutorizada.Rows(k).Item("NombreAccion"))
                    NodeAut.Name = ObjAccionAutorizada.Rows(k).Item("SsgRolAccionID")
                    NodeAut.ImageKey = "Accion.gif"
                    NodeAut.SelectedImageKey = "Accion.gif"
                    NodeAuts.Nodes.Add(NodeAut)
                Next

                Me.treeSeguridad.SelectedNode = NodeRol
            Else
                Me.treeSeguridad.SelectedNode.Text = objRol.Nombre
                Me.treeSeguridad.SelectedNode.FirstNode.Nodes.Clear()

                '--- Obtener las Acciones Autorizadas por Rol y             
                ObjAccionAutorizada = SqlHelper.ExecuteQueryDT("SELECT * FROM vwRolAccion WHERE objRolID = " & objRol.SsgRolID)
                For k = 0 To ObjAccionAutorizada.Rows.Count - 1
                    NodeAut = New TreeNode(ObjAccionAutorizada.Rows(k).Item("NombreAccion"))
                    NodeAut.Name = ObjAccionAutorizada.Rows(k).Item("SsgRolAccionID")
                    NodeAut.ImageKey = "Accion.gif"
                    NodeAut.SelectedImageKey = "Accion.gif"
                    Me.treeSeguridad.SelectedNode.FirstNode.Nodes.Add(NodeAut)
                Next

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#End Region

#End Region

End Class
