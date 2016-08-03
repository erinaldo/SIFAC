<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaFactura))
        Me.tbCuentas = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmdEditarFactura = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdNuevaFecha = New System.Windows.Forms.ToolStripButton
        Me.cmdProcesarExpedienteFact = New System.Windows.Forms.ToolStripButton
        Me.cmdAnularFactura = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbCuentas.SuspendLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCuentas
        '
        Me.tbCuentas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditarFactura, Me.ToolStripSeparator3, Me.cmdNuevaFecha, Me.cmdProcesarExpedienteFact, Me.cmdAnularFactura, Me.ToolStripSeparator4, Me.cmdBuscar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdRefrescar, Me.ToolStripSeparator2, Me.cmdSalir})
        Me.tbCuentas.Location = New System.Drawing.Point(0, 0)
        Me.tbCuentas.Name = "tbCuentas"
        Me.tbCuentas.Size = New System.Drawing.Size(784, 39)
        Me.tbCuentas.TabIndex = 1
        Me.tbCuentas.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Nueva Expediente-Factura"
        '
        'cmdEditarFactura
        '
        Me.cmdEditarFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditarFactura.Image = CType(resources.GetObject("cmdEditarFactura.Image"), System.Drawing.Image)
        Me.cmdEditarFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditarFactura.Name = "cmdEditarFactura"
        Me.cmdEditarFactura.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditarFactura.Text = "ToolStripButton1"
        Me.cmdEditarFactura.ToolTipText = "Editar Expediente-Factura"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdNuevaFecha
        '
        Me.cmdNuevaFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNuevaFecha.Image = CType(resources.GetObject("cmdNuevaFecha.Image"), System.Drawing.Image)
        Me.cmdNuevaFecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNuevaFecha.Name = "cmdNuevaFecha"
        Me.cmdNuevaFecha.Size = New System.Drawing.Size(36, 36)
        Me.cmdNuevaFecha.ToolTipText = "Realizar Desplazamiento de Fecha de Pago Próxima"
        '
        'cmdProcesarExpedienteFact
        '
        Me.cmdProcesarExpedienteFact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdProcesarExpedienteFact.Image = CType(resources.GetObject("cmdProcesarExpedienteFact.Image"), System.Drawing.Image)
        Me.cmdProcesarExpedienteFact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcesarExpedienteFact.Name = "cmdProcesarExpedienteFact"
        Me.cmdProcesarExpedienteFact.Size = New System.Drawing.Size(36, 36)
        Me.cmdProcesarExpedienteFact.Text = "Procesar Expediente-Factura"
        '
        'cmdAnularFactura
        '
        Me.cmdAnularFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnularFactura.Image = CType(resources.GetObject("cmdAnularFactura.Image"), System.Drawing.Image)
        Me.cmdAnularFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnularFactura.Name = "cmdAnularFactura"
        Me.cmdAnularFactura.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnularFactura.Text = "Anular Expediente-Factura"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.Text = "Buscar Expediente-Factura"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Expediente-Factura"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.Text = "ToolStripButton1"
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
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
        'grdFacturas
        '
        Me.grdFacturas.AllowUpdate = False
        Me.grdFacturas.Caption = "Facturas"
        Me.grdFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFacturas.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(0, 39)
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(784, 520)
        Me.grdFacturas.TabIndex = 4
        Me.grdFacturas.Tag = "AGRUPAR"
        Me.grdFacturas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'frmSfaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 559)
        Me.Controls.Add(Me.grdFacturas)
        Me.Controls.Add(Me.tbCuentas)
        Me.Name = "frmSfaFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expediente-Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbCuentas.ResumeLayout(False)
        Me.tbCuentas.PerformLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCuentas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdEditarFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnularFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdProcesarExpedienteFact As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNuevaFecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
End Class
