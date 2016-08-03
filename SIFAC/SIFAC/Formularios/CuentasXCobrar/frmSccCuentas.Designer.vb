<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccCuentas))
        Me.tbCuentas = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdModificarLimite = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton
        Me.cmdBuscarExpedientes = New System.Windows.Forms.ToolStripButton
        Me.cmdReestructurarCuenta = New System.Windows.Forms.ToolStripButton
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer
        Me.grdDetalleExpedientes = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.grdCuentas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tbCuentas.SuspendLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        CType(Me.grdDetalleExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCuentas
        '
        Me.tbCuentas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.ToolStripSeparator1, Me.cmdModificarLimite, Me.cmdConsultar, Me.cmdBuscarExpedientes, Me.ToolStripSeparator2, Me.cmdReestructurarCuenta, Me.ToolStripSeparator3, Me.cmdRefrescar, Me.cmdSalir})
        Me.tbCuentas.Location = New System.Drawing.Point(0, 0)
        Me.tbCuentas.Name = "tbCuentas"
        Me.tbCuentas.Size = New System.Drawing.Size(863, 39)
        Me.tbCuentas.TabIndex = 0
        Me.tbCuentas.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Agregar Expediente"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Expediente de Cuenta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdModificarLimite
        '
        Me.cmdModificarLimite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdModificarLimite.Image = CType(resources.GetObject("cmdModificarLimite.Image"), System.Drawing.Image)
        Me.cmdModificarLimite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdModificarLimite.Name = "cmdModificarLimite"
        Me.cmdModificarLimite.Size = New System.Drawing.Size(36, 36)
        Me.cmdModificarLimite.ToolTipText = "Modificar Limite de Crédito"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Expediente"
        '
        'cmdBuscarExpedientes
        '
        Me.cmdBuscarExpedientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscarExpedientes.Image = CType(resources.GetObject("cmdBuscarExpedientes.Image"), System.Drawing.Image)
        Me.cmdBuscarExpedientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscarExpedientes.Name = "cmdBuscarExpedientes"
        Me.cmdBuscarExpedientes.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscarExpedientes.Text = "Buscar Expedientes"
        '
        'cmdReestructurarCuenta
        '
        Me.cmdReestructurarCuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdReestructurarCuenta.Image = CType(resources.GetObject("cmdReestructurarCuenta.Image"), System.Drawing.Image)
        Me.cmdReestructurarCuenta.ImageTransparentColor = System.Drawing.Color.Silver
        Me.cmdReestructurarCuenta.Name = "cmdReestructurarCuenta"
        Me.cmdReestructurarCuenta.Size = New System.Drawing.Size(36, 36)
        Me.cmdReestructurarCuenta.Text = "Reestructurar Cuenta"
        Me.cmdReestructurarCuenta.ToolTipText = "Reestructurar Cuenta"
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir de Formulario"
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.grdDetalleExpedientes)
        Me.C1Sizer1.Controls.Add(Me.grdCuentas)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "72.8155339805825:False:False;24.2718446601942:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0730011587486:False" & _
            ":False;"
        Me.C1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 39)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(863, 412)
        Me.C1Sizer1.TabIndex = 1
        Me.C1Sizer1.TabStop = False
        '
        'grdDetalleExpedientes
        '
        Me.grdDetalleExpedientes.Caption = "Expedientes-Facturas"
        Me.grdDetalleExpedientes.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDetalleExpedientes.Images.Add(CType(resources.GetObject("grdDetalleExpedientes.Images"), System.Drawing.Image))
        Me.grdDetalleExpedientes.Location = New System.Drawing.Point(4, 308)
        Me.grdDetalleExpedientes.Name = "grdDetalleExpedientes"
        Me.grdDetalleExpedientes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalleExpedientes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalleExpedientes.PreviewInfo.ZoomFactor = 75
        Me.grdDetalleExpedientes.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalleExpedientes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalleExpedientes.Size = New System.Drawing.Size(855, 100)
        Me.grdDetalleExpedientes.TabIndex = 10
        Me.grdDetalleExpedientes.Text = "Expedientes-Facturas"
        Me.grdDetalleExpedientes.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdDetalleExpedientes.PropBag = resources.GetString("grdDetalleExpedientes.PropBag")
        '
        'grdCuentas
        '
        Me.grdCuentas.AllowUpdate = False
        Me.grdCuentas.Caption = "Expedientes"
        Me.grdCuentas.ExtendRightColumn = True
        Me.grdCuentas.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdCuentas.Images.Add(CType(resources.GetObject("grdCuentas.Images"), System.Drawing.Image))
        Me.grdCuentas.Location = New System.Drawing.Point(4, 4)
        Me.grdCuentas.Name = "grdCuentas"
        Me.grdCuentas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCuentas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCuentas.PreviewInfo.ZoomFactor = 75
        Me.grdCuentas.PrintInfo.PageSettings = CType(resources.GetObject("grdCuentas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCuentas.Size = New System.Drawing.Size(855, 300)
        Me.grdCuentas.TabIndex = 9
        Me.grdCuentas.Tag = "AGRUPAR"
        Me.grdCuentas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdCuentas.PropBag = resources.GetString("grdCuentas.PropBag")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'frmSccCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 451)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Controls.Add(Me.tbCuentas)
        Me.Name = "frmSccCuentas"
        Me.Text = "Expedientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbCuentas.ResumeLayout(False)
        Me.tbCuentas.PerformLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer1.ResumeLayout(False)
        CType(Me.grdDetalleExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCuentas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBuscarExpedientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1Sizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdCuentas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents grdDetalleExpedientes As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdModificarLimite As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdReestructurarCuenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
