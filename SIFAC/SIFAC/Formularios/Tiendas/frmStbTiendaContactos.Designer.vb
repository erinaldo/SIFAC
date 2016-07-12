<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbTiendaContactos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbTiendaContactos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton
        Me.cmdEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.grdTiendaContactos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.mnuContactosTienda = New System.Windows.Forms.MenuStrip
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdTiendaContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuContactosTienda.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdEliminar, Me.ToolStripSeparator1, Me.cmdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(341, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "AGREGAR"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Enabled = False
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "EDITAR"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEliminar.ToolTipText = "ELIMINAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "CERRAR"
        '
        'grdTiendaContactos
        '
        Me.grdTiendaContactos.AllowUpdate = False
        Me.grdTiendaContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTiendaContactos.FilterBar = True
        Me.grdTiendaContactos.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdTiendaContactos.Images.Add(CType(resources.GetObject("grdTiendaContactos.Images"), System.Drawing.Image))
        Me.grdTiendaContactos.Location = New System.Drawing.Point(0, 39)
        Me.grdTiendaContactos.Name = "grdTiendaContactos"
        Me.grdTiendaContactos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTiendaContactos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTiendaContactos.PreviewInfo.ZoomFactor = 75
        Me.grdTiendaContactos.PrintInfo.PageSettings = CType(resources.GetObject("grdTiendaContactos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTiendaContactos.Size = New System.Drawing.Size(341, 258)
        Me.grdTiendaContactos.TabIndex = 1
        Me.grdTiendaContactos.PropBag = resources.GetString("grdTiendaContactos.PropBag")
        '
        'mnuContactosTienda
        '
        Me.mnuContactosTienda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuEditar, Me.mnuEliminar, Me.mnuSalir})
        Me.mnuContactosTienda.Location = New System.Drawing.Point(0, 0)
        Me.mnuContactosTienda.Name = "mnuContactosTienda"
        Me.mnuContactosTienda.Size = New System.Drawing.Size(341, 24)
        Me.mnuContactosTienda.TabIndex = 2
        Me.mnuContactosTienda.Visible = False
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAgregar.Size = New System.Drawing.Size(58, 20)
        Me.mnuAgregar.Text = "Agregar"
        '
        'mnuEditar
        '
        Me.mnuEditar.Name = "mnuEditar"
        Me.mnuEditar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEditar.Size = New System.Drawing.Size(47, 20)
        Me.mnuEditar.Text = "Editar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuEliminar.Size = New System.Drawing.Size(55, 20)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(39, 20)
        Me.mnuSalir.Text = "Salir"
        '
        'frmStbTiendaContactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 297)
        Me.Controls.Add(Me.grdTiendaContactos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.mnuContactosTienda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuContactosTienda
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbTiendaContactos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contactos de la Sucursal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdTiendaContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuContactosTienda.ResumeLayout(False)
        Me.mnuContactosTienda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents grdTiendaContactos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuContactosTienda As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
End Class
