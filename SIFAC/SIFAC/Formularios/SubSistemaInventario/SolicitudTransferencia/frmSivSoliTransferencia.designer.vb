<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivSoliTransferencia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivSoliTransferencia))
        Me.toolSolicitudesTransferencia = New System.Windows.Forms.ToolStrip
        Me.cmdAgregarSolicitud = New System.Windows.Forms.ToolStripButton
        Me.cmdAnularSolicitud = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultarSolicitud = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdImprimirSeleccion = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdImprimirFiltro = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.grdTransferencias = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.toolSolicitudesTransferencia.SuspendLayout()
        CType(Me.grdTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolSolicitudesTransferencia
        '
        Me.toolSolicitudesTransferencia.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolSolicitudesTransferencia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarSolicitud, Me.cmdAnularSolicitud, Me.cmdConsultarSolicitud, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolSolicitudesTransferencia.Location = New System.Drawing.Point(0, 0)
        Me.toolSolicitudesTransferencia.Name = "toolSolicitudesTransferencia"
        Me.toolSolicitudesTransferencia.Size = New System.Drawing.Size(731, 39)
        Me.toolSolicitudesTransferencia.TabIndex = 2
        '
        'cmdAgregarSolicitud
        '
        Me.cmdAgregarSolicitud.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarSolicitud.Image = CType(resources.GetObject("cmdAgregarSolicitud.Image"), System.Drawing.Image)
        Me.cmdAgregarSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarSolicitud.Name = "cmdAgregarSolicitud"
        Me.cmdAgregarSolicitud.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregarSolicitud.Text = "Agregar solicitud"
        '
        'cmdAnularSolicitud
        '
        Me.cmdAnularSolicitud.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnularSolicitud.Image = CType(resources.GetObject("cmdAnularSolicitud.Image"), System.Drawing.Image)
        Me.cmdAnularSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnularSolicitud.Name = "cmdAnularSolicitud"
        Me.cmdAnularSolicitud.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnularSolicitud.Text = "Anular solicitud"
        '
        'cmdConsultarSolicitud
        '
        Me.cmdConsultarSolicitud.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultarSolicitud.Image = CType(resources.GetObject("cmdConsultarSolicitud.Image"), System.Drawing.Image)
        Me.cmdConsultarSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultarSolicitud.Name = "cmdConsultarSolicitud"
        Me.cmdConsultarSolicitud.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultarSolicitud.Text = "Consultar solicitud"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdImprimirSeleccion, Me.cmdImprimirFiltro})
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(45, 36)
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdImprimirSeleccion
        '
        Me.cmdImprimirSeleccion.Name = "cmdImprimirSeleccion"
        Me.cmdImprimirSeleccion.Size = New System.Drawing.Size(147, 22)
        Me.cmdImprimirSeleccion.Text = "Seleccionada"
        '
        'cmdImprimirFiltro
        '
        Me.cmdImprimirFiltro.Name = "cmdImprimirFiltro"
        Me.cmdImprimirFiltro.Size = New System.Drawing.Size(147, 22)
        Me.cmdImprimirFiltro.Text = "Por Filtro"
        '
        'ToolSeparador1
        '
        Me.ToolSeparador1.Name = "ToolSeparador1"
        Me.ToolSeparador1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.tsbRefrescar.Text = "Refrescar Datos"
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
        'grdTransferencias
        '
        Me.grdTransferencias.Caption = "Solicitudes de transferencias"
        Me.grdTransferencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTransferencias.EmptyRows = True
        Me.grdTransferencias.ExtendRightColumn = True
        Me.grdTransferencias.GroupByCaption = "Arrastre hacia ac� la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdTransferencias.Images.Add(CType(resources.GetObject("grdTransferencias.Images"), System.Drawing.Image))
        Me.grdTransferencias.Location = New System.Drawing.Point(0, 39)
        Me.grdTransferencias.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdTransferencias.Name = "grdTransferencias"
        Me.grdTransferencias.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTransferencias.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTransferencias.PreviewInfo.ZoomFactor = 75
        Me.grdTransferencias.PrintInfo.PageSettings = CType(resources.GetObject("grdTransferencias.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTransferencias.Size = New System.Drawing.Size(731, 513)
        Me.grdTransferencias.TabIndex = 3
        Me.grdTransferencias.Tag = "AGRUPAR"
        Me.grdTransferencias.Text = "Transferencias"
        Me.grdTransferencias.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdTransferencias.PropBag = resources.GetString("grdTransferencias.PropBag")
        '
        'frmSivSoliTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 552)
        Me.Controls.Add(Me.grdTransferencias)
        Me.Controls.Add(Me.toolSolicitudesTransferencia)
        Me.Name = "frmSivSoliTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Solicitudes de Transferencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolSolicitudesTransferencia.ResumeLayout(False)
        Me.toolSolicitudesTransferencia.PerformLayout()
        CType(Me.grdTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolSolicitudesTransferencia As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdTransferencias As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAnularSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdImprimirSeleccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdImprimirFiltro As System.Windows.Forms.ToolStripMenuItem
End Class
