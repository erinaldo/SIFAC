<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbMantParametro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbMantParametro))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarParametro = New System.Windows.Forms.ToolStripButton()
        Me.tsbModificarParametro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tdgParametro = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.tdgParametro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarParametro, Me.tsbModificarParametro, Me.ToolStripSeparator1, Me.tsbRefrescar, Me.ToolStripSeparator2, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(563, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbAgregarParametro
        '
        Me.tsbAgregarParametro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAgregarParametro.Enabled = False
        Me.tsbAgregarParametro.Image = CType(resources.GetObject("tsbAgregarParametro.Image"), System.Drawing.Image)
        Me.tsbAgregarParametro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarParametro.Name = "tsbAgregarParametro"
        Me.tsbAgregarParametro.Size = New System.Drawing.Size(36, 36)
        Me.tsbAgregarParametro.Text = "Agregar Par�metro"
        '
        'tsbModificarParametro
        '
        Me.tsbModificarParametro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbModificarParametro.Enabled = False
        Me.tsbModificarParametro.Image = CType(resources.GetObject("tsbModificarParametro.Image"), System.Drawing.Image)
        Me.tsbModificarParametro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificarParametro.Name = "tsbModificarParametro"
        Me.tsbModificarParametro.Size = New System.Drawing.Size(36, 36)
        Me.tsbModificarParametro.Text = "Modificar Par�metro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.tsbRefrescar.Text = "Refrescar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(36, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'tdgParametro
        '
        Me.tdgParametro.Caption = "Par�metros"
        Me.tdgParametro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdgParametro.EmptyRows = True
        Me.tdgParametro.ExtendRightColumn = True
        Me.tdgParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdgParametro.GroupByCaption = "Arrastre hacia ac� la etiqueta del campo por la cual desea agrupar los datos"
        Me.tdgParametro.Images.Add(CType(resources.GetObject("tdgParametro.Images"), System.Drawing.Image))
        Me.tdgParametro.Location = New System.Drawing.Point(0, 39)
        Me.tdgParametro.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdgParametro.Name = "tdgParametro"
        Me.tdgParametro.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdgParametro.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdgParametro.PreviewInfo.ZoomFactor = 75.0R
        Me.tdgParametro.PrintInfo.PageSettings = CType(resources.GetObject("tdgParametro.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdgParametro.Size = New System.Drawing.Size(563, 430)
        Me.tdgParametro.TabIndex = 2
        Me.tdgParametro.Tag = ""
        Me.tdgParametro.Text = "Par�metro"
        Me.tdgParametro.PropBag = resources.GetString("tdgParametro.PropBag")
        '
        'frmStbMantParametro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 469)
        Me.Controls.Add(Me.tdgParametro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStbMantParametro"
        Me.Tag = "CATALOGOS"
        Me.Text = "Par�metro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.tdgParametro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarParametro As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificarParametro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tdgParametro As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
