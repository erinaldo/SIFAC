<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivRepuestos))
        Me.tbRepuestos = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton
        Me.cmdAnular = New System.Windows.Forms.ToolStripButton
        Me.cmdEtiquetar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdActualizar = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.grdRepuestos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbRepuestos.SuspendLayout()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbRepuestos
        '
        Me.tbRepuestos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbRepuestos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.cmdAnular, Me.cmdEtiquetar, Me.ToolStripSeparator1, Me.cmdActualizar, Me.cmdImprimir, Me.cmdSalir})
        Me.tbRepuestos.Location = New System.Drawing.Point(0, 0)
        Me.tbRepuestos.Name = "tbRepuestos"
        Me.tbRepuestos.Size = New System.Drawing.Size(879, 39)
        Me.tbRepuestos.TabIndex = 0
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Nuevo Repuesto"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Repuesto"
        '
        'cmdAnular
        '
        Me.cmdAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnular.Image = CType(resources.GetObject("cmdAnular.Image"), System.Drawing.Image)
        Me.cmdAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnular.ToolTipText = "Inactivar Repuesto"
        Me.cmdAnular.Visible = False
        '
        'cmdEtiquetar
        '
        Me.cmdEtiquetar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEtiquetar.Image = CType(resources.GetObject("cmdEtiquetar.Image"), System.Drawing.Image)
        Me.cmdEtiquetar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEtiquetar.Name = "cmdEtiquetar"
        Me.cmdEtiquetar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEtiquetar.ToolTipText = "Etiquetar Repuesto"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdActualizar
        '
        Me.cmdActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(36, 36)
        Me.cmdActualizar.ToolTipText = "Actualizar "
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.ToolTipText = "Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir"
        '
        'grdRepuestos
        '
        Me.grdRepuestos.AllowUpdate = False
        Me.grdRepuestos.Caption = "Repuestos"
        Me.grdRepuestos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRepuestos.ExtendRightColumn = True
        Me.grdRepuestos.FilterBar = True
        Me.grdRepuestos.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdRepuestos.Images.Add(CType(resources.GetObject("grdRepuestos.Images"), System.Drawing.Image))
        Me.grdRepuestos.Location = New System.Drawing.Point(0, 39)
        Me.grdRepuestos.Name = "grdRepuestos"
        Me.grdRepuestos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRepuestos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRepuestos.PreviewInfo.ZoomFactor = 75
        Me.grdRepuestos.PrintInfo.PageSettings = CType(resources.GetObject("grdRepuestos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRepuestos.Size = New System.Drawing.Size(879, 403)
        Me.grdRepuestos.TabIndex = 1
        Me.grdRepuestos.Tag = "AGRUPAR"
        Me.grdRepuestos.Text = "C1TrueDBGrid1"
        Me.grdRepuestos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdRepuestos.PropBag = resources.GetString("grdRepuestos.PropBag")
        '
        'frmSivRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 442)
        Me.Controls.Add(Me.grdRepuestos)
        Me.Controls.Add(Me.tbRepuestos)
        Me.Name = "frmSivRepuestos"
        Me.Text = "Catálogo de Repuestos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbRepuestos.ResumeLayout(False)
        Me.tbRepuestos.PerformLayout()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbRepuestos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEtiquetar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdRepuestos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
