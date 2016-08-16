<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbPersonas))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdActualizar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.tbcPersonas = New System.Windows.Forms.TabControl()
        Me.pgCliente = New System.Windows.Forms.TabPage()
        Me.tdgCliente = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.objUbicacion = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.tbcPersonas.SuspendLayout()
        Me.pgCliente.SuspendLayout()
        CType(Me.tdgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.cmdBuscar, Me.ToolStripSeparator1, Me.cmdEliminar, Me.ToolStripSeparator2, Me.cmdActualizar, Me.cmdImprimir, Me.ToolStripSeparator3, Me.cmdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(756, 39)
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
        Me.cmdAgregar.Text = "Agregar nueva Persona"
        Me.cmdAgregar.ToolTipText = "Agregar"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar datos de persona"
        Me.cmdEditar.ToolTipText = "Editar"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar Persona"
        Me.cmdConsultar.ToolTipText = "Consultar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.Text = "Buscar Personas"
        Me.cmdBuscar.ToolTipText = "BUSCAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdEliminar
        '
        Me.cmdEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEliminar.Text = "Eliminar Personas"
        Me.cmdEliminar.ToolTipText = "Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdActualizar
        '
        Me.cmdActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(36, 36)
        Me.cmdActualizar.Text = "Refrescar Datos"
        Me.cmdActualizar.ToolTipText = "Refrescar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "ToolStripButton6"
        Me.cmdImprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.ToolTipText = "Cerrar"
        '
        'tbcPersonas
        '
        Me.tbcPersonas.Controls.Add(Me.pgCliente)
        Me.tbcPersonas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcPersonas.Location = New System.Drawing.Point(0, 39)
        Me.tbcPersonas.Name = "tbcPersonas"
        Me.tbcPersonas.SelectedIndex = 0
        Me.tbcPersonas.Size = New System.Drawing.Size(756, 495)
        Me.tbcPersonas.TabIndex = 1
        '
        'pgCliente
        '
        Me.pgCliente.Controls.Add(Me.tdgCliente)
        Me.pgCliente.Location = New System.Drawing.Point(4, 22)
        Me.pgCliente.Name = "pgCliente"
        Me.pgCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.pgCliente.Size = New System.Drawing.Size(748, 469)
        Me.pgCliente.TabIndex = 0
        Me.pgCliente.Text = "Clientes"
        Me.pgCliente.UseVisualStyleBackColor = True
        '
        'tdgCliente
        '
        Me.tdgCliente.AllowArrows = False
        Me.tdgCliente.AllowUpdate = False
        Me.tdgCliente.AllowUpdateOnBlur = False
        Me.tdgCliente.Caption = "Personas"
        Me.tdgCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdgCliente.EmptyRows = True
        Me.tdgCliente.ExtendRightColumn = True
        Me.tdgCliente.FilterBar = True
        Me.tdgCliente.GroupByCaption = "Arrastre hacia acá la columna por la cual desea agrupar"
        Me.tdgCliente.Images.Add(CType(resources.GetObject("tdgCliente.Images"), System.Drawing.Image))
        Me.tdgCliente.Location = New System.Drawing.Point(3, 3)
        Me.tdgCliente.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdgCliente.Name = "tdgCliente"
        Me.tdgCliente.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdgCliente.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdgCliente.PreviewInfo.ZoomFactor = 75.0R
        Me.tdgCliente.PrintInfo.PageSettings = CType(resources.GetObject("tdgCliente.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdgCliente.Size = New System.Drawing.Size(742, 463)
        Me.tdgCliente.TabIndex = 4
        Me.tdgCliente.Tag = "AGRUPAR"
        Me.tdgCliente.Text = "Personas"
        Me.tdgCliente.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.tdgCliente.PropBag = resources.GetString("tdgCliente.PropBag")
        '
        'objUbicacion
        '
        Me.objUbicacion.Filter = "Microsoft Excel | *.xls"
        '
        'frmStbPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 534)
        Me.Controls.Add(Me.tbcPersonas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStbPersonas"
        Me.Text = "Consulta de Personas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tbcPersonas.ResumeLayout(False)
        Me.pgCliente.ResumeLayout(False)
        CType(Me.tdgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbcPersonas As System.Windows.Forms.TabControl
    Friend WithEvents pgCliente As System.Windows.Forms.TabPage
    Friend WithEvents tdgCliente As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
End Class
