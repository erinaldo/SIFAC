<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivRecepTransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivRecepTransferencia))
        Me.toolRecepcionTransf = New System.Windows.Forms.ToolStrip
        Me.cmdAprobar = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultarSolicitud = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdImprimirSeleccion = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdImprimirFiltro = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdImprimirDiferencias = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.grdTransferencias = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.toolRecepcionTransf.SuspendLayout()
        CType(Me.grdTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolRecepcionTransf
        '
        Me.toolRecepcionTransf.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolRecepcionTransf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAprobar, Me.cmdConsultarSolicitud, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolRecepcionTransf.Location = New System.Drawing.Point(0, 0)
        Me.toolRecepcionTransf.Name = "toolRecepcionTransf"
        Me.toolRecepcionTransf.Size = New System.Drawing.Size(851, 39)
        Me.toolRecepcionTransf.TabIndex = 6
        '
        'cmdAprobar
        '
        Me.cmdAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAprobar.Image = Global.SIFAC.My.Resources.Resources.Autorizar_Pedido
        Me.cmdAprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAprobar.Text = "Aprobar solicitud"
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
        Me.cmdImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdImprimirSeleccion, Me.cmdImprimirFiltro, Me.cmdImprimirDiferencias})
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
        'cmdImprimirDiferencias
        '
        Me.cmdImprimirDiferencias.Name = "cmdImprimirDiferencias"
        Me.cmdImprimirDiferencias.Size = New System.Drawing.Size(147, 22)
        Me.cmdImprimirDiferencias.Text = "Diferencias"
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
        Me.grdTransferencias.AllowUpdate = False
        Me.grdTransferencias.Caption = "Solicitudes Transferencias"
        Me.grdTransferencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTransferencias.ExtendRightColumn = True
        Me.grdTransferencias.FilterBar = True
        Me.grdTransferencias.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdTransferencias.Images.Add(CType(resources.GetObject("grdTransferencias.Images"), System.Drawing.Image))
        Me.grdTransferencias.Location = New System.Drawing.Point(0, 39)
        Me.grdTransferencias.Name = "grdTransferencias"
        Me.grdTransferencias.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTransferencias.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTransferencias.PreviewInfo.ZoomFactor = 75
        Me.grdTransferencias.PrintInfo.PageSettings = CType(resources.GetObject("grdTransferencias.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTransferencias.Size = New System.Drawing.Size(851, 585)
        Me.grdTransferencias.TabIndex = 8
        Me.grdTransferencias.Tag = "AGRUPAR"
        Me.grdTransferencias.Text = "Solicitudes de transferencias"
        Me.grdTransferencias.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdTransferencias.PropBag = resources.GetString("grdTransferencias.PropBag")
        '
        'frmSivRecepTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 624)
        Me.Controls.Add(Me.grdTransferencias)
        Me.Controls.Add(Me.toolRecepcionTransf)
        Me.Name = "frmSivRecepTransferencia"
        Me.Text = "Recepción de transferencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolRecepcionTransf.ResumeLayout(False)
        Me.toolRecepcionTransf.PerformLayout()
        CType(Me.grdTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolRecepcionTransf As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdTransferencias As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdImprimirSeleccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdImprimirFiltro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdImprimirDiferencias As System.Windows.Forms.ToolStripMenuItem
End Class
