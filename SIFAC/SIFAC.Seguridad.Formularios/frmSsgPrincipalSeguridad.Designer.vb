<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSsgPrincipalSeguridad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSsgPrincipalSeguridad))
        Me.tmrPrincipal = New System.Windows.Forms.Timer(Me.components)
        Me.ImageListSeguridad = New System.Windows.Forms.ImageList(Me.components)
        Me.stbSeguridad = New C1.Win.C1Ribbon.C1StatusBar
        Me.lblServidor = New C1.Win.C1Ribbon.RibbonLabel
        Me.RibbonSeparator1 = New C1.Win.C1Ribbon.RibbonSeparator
        Me.lblBaseDatos = New C1.Win.C1Ribbon.RibbonLabel
        Me.RibbonSeparator2 = New C1.Win.C1Ribbon.RibbonSeparator
        Me.lblUser = New C1.Win.C1Ribbon.RibbonLabel
        Me.lblFecha = New C1.Win.C1Ribbon.RibbonLabel
        Me.lblHora = New C1.Win.C1Ribbon.RibbonLabel
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer
        Me.grdSeguridad = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.treeSeguridad = New System.Windows.Forms.TreeView
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar
        Me.cmdAyuda = New C1.Win.C1Ribbon.RibbonButton
        Me.cmdSalir = New C1.Win.C1Ribbon.RibbonButton
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat
        Me.tlsEditarSeguridad = New System.Windows.Forms.ToolStrip
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        CType(Me.stbSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        CType(Me.grdSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsEditarSeguridad.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrPrincipal
        '
        '
        'ImageListSeguridad
        '
        Me.ImageListSeguridad.ImageStream = CType(resources.GetObject("ImageListSeguridad.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListSeguridad.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListSeguridad.Images.SetKeyName(0, "Usuarios.gif")
        Me.ImageListSeguridad.Images.SetKeyName(1, "Aplicaciones.gif")
        Me.ImageListSeguridad.Images.SetKeyName(2, "Usuario.gif")
        Me.ImageListSeguridad.Images.SetKeyName(3, "Aplicacion.png")
        Me.ImageListSeguridad.Images.SetKeyName(4, "Modulos.gif")
        Me.ImageListSeguridad.Images.SetKeyName(5, "Roles.gif")
        Me.ImageListSeguridad.Images.SetKeyName(6, "Modulo.png")
        Me.ImageListSeguridad.Images.SetKeyName(7, "ServicioUsuario.png")
        Me.ImageListSeguridad.Images.SetKeyName(8, "Acciones.gif")
        Me.ImageListSeguridad.Images.SetKeyName(9, "Accion.gif")
        Me.ImageListSeguridad.Images.SetKeyName(10, "AccionesAutorizadas.gif")
        Me.ImageListSeguridad.Images.SetKeyName(11, "UsuariosQueJueganUnRol.gif")
        Me.ImageListSeguridad.Images.SetKeyName(12, "Rol.jpg")
        Me.ImageListSeguridad.Images.SetKeyName(13, "Seguridad.gif")
        '
        'stbSeguridad
        '
        Me.stbSeguridad.LeftPaneItems.Add(Me.lblServidor)
        Me.stbSeguridad.LeftPaneItems.Add(Me.RibbonSeparator1)
        Me.stbSeguridad.LeftPaneItems.Add(Me.lblBaseDatos)
        Me.stbSeguridad.LeftPaneItems.Add(Me.RibbonSeparator2)
        Me.stbSeguridad.LeftPaneItems.Add(Me.lblUser)
        Me.stbSeguridad.Location = New System.Drawing.Point(0, 376)
        Me.stbSeguridad.Name = "stbSeguridad"
        Me.stbSeguridad.RightPaneItems.Add(Me.lblFecha)
        Me.stbSeguridad.RightPaneItems.Add(Me.lblHora)
        Me.stbSeguridad.RightPaneWidth = 200
        Me.stbSeguridad.Size = New System.Drawing.Size(495, 22)
        Me.stbSeguridad.TabIndex = 14
        Me.stbSeguridad.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Black
        '
        'lblServidor
        '
        Me.lblServidor.ID = "lblServidor"
        Me.lblServidor.SmallImage = CType(resources.GetObject("lblServidor.SmallImage"), System.Drawing.Image)
        Me.lblServidor.Text = "Servidor : "
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.ID = "RibbonSeparator1"
        '
        'lblBaseDatos
        '
        Me.lblBaseDatos.ID = "lblBaseDatos"
        Me.lblBaseDatos.SmallImage = CType(resources.GetObject("lblBaseDatos.SmallImage"), System.Drawing.Image)
        Me.lblBaseDatos.Text = "Base de Datos : "
        '
        'RibbonSeparator2
        '
        Me.RibbonSeparator2.ID = "RibbonSeparator2"
        '
        'lblUser
        '
        Me.lblUser.ID = "lblUser"
        Me.lblUser.SmallImage = CType(resources.GetObject("lblUser.SmallImage"), System.Drawing.Image)
        Me.lblUser.Text = "Usuario  : "
        '
        'lblFecha
        '
        Me.lblFecha.ID = "lblFecha"
        Me.lblFecha.SmallImage = CType(resources.GetObject("lblFecha.SmallImage"), System.Drawing.Image)
        Me.lblFecha.Text = "Fecha : "
        '
        'lblHora
        '
        Me.lblHora.ID = "lblHora"
        Me.lblHora.SmallImage = CType(resources.GetObject("lblHora.SmallImage"), System.Drawing.Image)
        Me.lblHora.Text = "Hora : "
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.grdSeguridad)
        Me.C1Sizer1.Controls.Add(Me.treeSeguridad)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "97.8723404255319:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "30.9090909090909:True:False;66.6666666666667:False:" & _
            "False;"
        Me.C1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 0)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(495, 376)
        Me.C1Sizer1.TabIndex = 19
        Me.C1Sizer1.TabStop = False
        '
        'grdSeguridad
        '
        Me.grdSeguridad.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.grdSeguridad.EmptyRows = True
        Me.grdSeguridad.ExtendRightColumn = True
        Me.grdSeguridad.FilterBar = True
        Me.grdSeguridad.GroupByCaption = ""
        Me.grdSeguridad.Images.Add(CType(resources.GetObject("grdSeguridad.Images"), System.Drawing.Image))
        Me.grdSeguridad.Location = New System.Drawing.Point(161, 4)
        Me.grdSeguridad.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor
        Me.grdSeguridad.Name = "grdSeguridad"
        Me.grdSeguridad.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdSeguridad.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdSeguridad.PreviewInfo.ZoomFactor = 75
        Me.grdSeguridad.PrintInfo.PageSettings = CType(resources.GetObject("grdSeguridad.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdSeguridad.Size = New System.Drawing.Size(330, 368)
        Me.grdSeguridad.TabIndex = 3
        Me.grdSeguridad.Text = "C1TrueDBGrid1"
        Me.grdSeguridad.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdSeguridad.PropBag = resources.GetString("grdSeguridad.PropBag")
        '
        'treeSeguridad
        '
        Me.treeSeguridad.FullRowSelect = True
        Me.treeSeguridad.ImageIndex = 0
        Me.treeSeguridad.ImageList = Me.ImageListSeguridad
        Me.treeSeguridad.Location = New System.Drawing.Point(4, 4)
        Me.treeSeguridad.Name = "treeSeguridad"
        Me.treeSeguridad.SelectedImageIndex = 0
        Me.treeSeguridad.Size = New System.Drawing.Size(153, 368)
        Me.treeSeguridad.TabIndex = 2
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(495, 51)
        Me.C1Ribbon1.TabIndex = 20
        Me.C1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Black
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Enabled = False
        Me.RibbonApplicationMenu1.ID = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.LargeImage = CType(resources.GetObject("RibbonApplicationMenu1.LargeImage"), System.Drawing.Image)
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.ID = "RibbonConfigToolBar1"
        Me.RibbonConfigToolBar1.Items.Add(Me.cmdAyuda)
        Me.RibbonConfigToolBar1.Items.Add(Me.cmdSalir)
        '
        'cmdAyuda
        '
        Me.cmdAyuda.ID = "cmdAyuda"
        Me.cmdAyuda.SmallImage = CType(resources.GetObject("cmdAyuda.SmallImage"), System.Drawing.Image)
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.ID = "cmdSalir"
        Me.cmdSalir.SmallImage = CType(resources.GetObject("cmdSalir.SmallImage"), System.Drawing.Image)
        Me.cmdSalir.Text = "Salir"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.ID = "RibbonQat1"
        '
        'tlsEditarSeguridad
        '
        Me.tlsEditarSeguridad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbEditar, Me.tsbEliminar})
        Me.tlsEditarSeguridad.Location = New System.Drawing.Point(0, 51)
        Me.tlsEditarSeguridad.Name = "tlsEditarSeguridad"
        Me.tlsEditarSeguridad.Size = New System.Drawing.Size(495, 25)
        Me.tlsEditarSeguridad.TabIndex = 21
        Me.tlsEditarSeguridad.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(23, 22)
        Me.tsbNuevo.Text = "ToolStripButton1"
        Me.tsbNuevo.ToolTipText = "Nuevo"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Editar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEliminar.Text = "ToolStripButton3"
        Me.tsbEliminar.ToolTipText = "Eliminar"
        '
        'frmSsgPrincipalSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 398)
        Me.Controls.Add(Me.tlsEditarSeguridad)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Controls.Add(Me.stbSeguridad)
        Me.Name = "frmSsgPrincipalSeguridad"
        Me.ShowIcon = False
        Me.Text = "SubSistema de Seguridad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.stbSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer1.ResumeLayout(False)
        CType(Me.grdSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsEditarSeguridad.ResumeLayout(False)
        Me.tlsEditarSeguridad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrPrincipal As System.Windows.Forms.Timer
    Friend WithEvents ImageListSeguridad As System.Windows.Forms.ImageList
    Friend WithEvents stbSeguridad As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents lblServidor As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonSeparator1 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents lblBaseDatos As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonSeparator2 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents lblUser As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents lblFecha As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents lblHora As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents C1Sizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents treeSeguridad As System.Windows.Forms.TreeView
    Friend WithEvents grdSeguridad As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents cmdAyuda As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents cmdSalir As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents tlsEditarSeguridad As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton

End Class
