<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbTiendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbTiendas))
        Me.tbTiendas = New System.Windows.Forms.ToolStrip
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.grbTienda = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtMoviles = New System.Windows.Forms.TextBox
        Me.lblMoviles = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblDirecciones = New System.Windows.Forms.Label
        Me.txtDirecciones = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtFacsimiles = New System.Windows.Forms.TextBox
        Me.lblFacsimiles = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblTelefonos = New System.Windows.Forms.Label
        Me.txtTelefonos = New System.Windows.Forms.TextBox
        Me.grdTienda = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.mnuTiendas = New System.Windows.Forms.MenuStrip
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDesactivar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActualizar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
        Me.lblProximoNoFactura = New System.Windows.Forms.Label
        Me.txtProximoNumeroFact = New System.Windows.Forms.TextBox
        Me.lblSerie = New System.Windows.Forms.Label
        Me.txtSerieFactura = New System.Windows.Forms.TextBox
        Me.tbTiendas.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grbTienda.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.grdTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuTiendas.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTiendas
        '
        Me.tbTiendas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbTiendas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.ToolStripSeparator4, Me.cmdConsultar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdImprimir, Me.ToolStripSeparator3, Me.cmdSalir})
        Me.tbTiendas.Location = New System.Drawing.Point(0, 0)
        Me.tbTiendas.Name = "tbTiendas"
        Me.tbTiendas.Size = New System.Drawing.Size(716, 39)
        Me.tbTiendas.TabIndex = 0
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Nueva Sucursal"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Sucursal"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Sucursal"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
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
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.ToolTipText = "Imprimir Datos"
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
        Me.cmdSalir.ToolTipText = "Salir"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.92738!))
        Me.TableLayoutPanel1.Controls.Add(Me.grbTienda, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.grdTienda, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(716, 401)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'grbTienda
        '
        Me.grbTienda.Controls.Add(Me.TableLayoutPanel2)
        Me.grbTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbTienda.Location = New System.Drawing.Point(6, 213)
        Me.grbTienda.Name = "grbTienda"
        Me.grbTienda.Size = New System.Drawing.Size(704, 182)
        Me.grbTienda.TabIndex = 6
        Me.grbTienda.TabStop = False
        Me.grbTienda.Text = "Información de Contacto para la Sucursal"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.33523!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66477!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(698, 163)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtMoviles)
        Me.Panel1.Controls.Add(Me.lblMoviles)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(465, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(227, 45)
        Me.Panel1.TabIndex = 16
        '
        'txtMoviles
        '
        Me.txtMoviles.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMoviles.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtMoviles.Location = New System.Drawing.Point(3, 16)
        Me.txtMoviles.Multiline = True
        Me.txtMoviles.Name = "txtMoviles"
        Me.txtMoviles.ReadOnly = True
        Me.txtMoviles.Size = New System.Drawing.Size(221, 26)
        Me.txtMoviles.TabIndex = 15
        Me.txtMoviles.Tag = "BLOQUEADO"
        '
        'lblMoviles
        '
        Me.lblMoviles.AutoSize = True
        Me.lblMoviles.Location = New System.Drawing.Point(3, 3)
        Me.lblMoviles.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMoviles.Name = "lblMoviles"
        Me.lblMoviles.Size = New System.Drawing.Size(46, 13)
        Me.lblMoviles.TabIndex = 14
        Me.lblMoviles.Text = "Móviles:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtSerieFactura)
        Me.Panel2.Controls.Add(Me.txtProximoNumeroFact)
        Me.Panel2.Controls.Add(Me.lblSerie)
        Me.Panel2.Controls.Add(Me.lblProximoNoFactura)
        Me.Panel2.Controls.Add(Me.lblDirecciones)
        Me.Panel2.Controls.Add(Me.txtDirecciones)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel2.SetRowSpan(Me.Panel2, 3)
        Me.Panel2.Size = New System.Drawing.Size(453, 151)
        Me.Panel2.TabIndex = 17
        '
        'lblDirecciones
        '
        Me.lblDirecciones.AutoSize = True
        Me.lblDirecciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDirecciones.Location = New System.Drawing.Point(3, 3)
        Me.lblDirecciones.Name = "lblDirecciones"
        Me.lblDirecciones.Size = New System.Drawing.Size(66, 13)
        Me.lblDirecciones.TabIndex = 8
        Me.lblDirecciones.Text = "Direcciones:"
        '
        'txtDirecciones
        '
        Me.txtDirecciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDirecciones.Location = New System.Drawing.Point(3, 16)
        Me.txtDirecciones.Multiline = True
        Me.txtDirecciones.Name = "txtDirecciones"
        Me.txtDirecciones.ReadOnly = True
        Me.txtDirecciones.Size = New System.Drawing.Size(447, 96)
        Me.txtDirecciones.TabIndex = 9
        Me.txtDirecciones.Tag = "BLOQUEADO"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtFacsimiles)
        Me.Panel3.Controls.Add(Me.lblFacsimiles)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(465, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel3.Size = New System.Drawing.Size(227, 47)
        Me.Panel3.TabIndex = 18
        '
        'txtFacsimiles
        '
        Me.txtFacsimiles.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFacsimiles.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtFacsimiles.Location = New System.Drawing.Point(3, 18)
        Me.txtFacsimiles.Multiline = True
        Me.txtFacsimiles.Name = "txtFacsimiles"
        Me.txtFacsimiles.ReadOnly = True
        Me.txtFacsimiles.Size = New System.Drawing.Size(221, 26)
        Me.txtFacsimiles.TabIndex = 13
        Me.txtFacsimiles.Tag = "BLOQUEADO"
        '
        'lblFacsimiles
        '
        Me.lblFacsimiles.AutoSize = True
        Me.lblFacsimiles.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFacsimiles.Location = New System.Drawing.Point(3, 3)
        Me.lblFacsimiles.Name = "lblFacsimiles"
        Me.lblFacsimiles.Size = New System.Drawing.Size(58, 13)
        Me.lblFacsimiles.TabIndex = 12
        Me.lblFacsimiles.Text = "Facsimiles:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblTelefonos)
        Me.Panel4.Controls.Add(Me.txtTelefonos)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(465, 110)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel4.Size = New System.Drawing.Size(227, 47)
        Me.Panel4.TabIndex = 19
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTelefonos.Location = New System.Drawing.Point(3, 3)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(57, 13)
        Me.lblTelefonos.TabIndex = 10
        Me.lblTelefonos.Text = "Teléfonos:"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTelefonos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtTelefonos.Location = New System.Drawing.Point(3, 17)
        Me.txtTelefonos.Multiline = True
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.ReadOnly = True
        Me.txtTelefonos.Size = New System.Drawing.Size(221, 27)
        Me.txtTelefonos.TabIndex = 11
        Me.txtTelefonos.Tag = "BLOQUEADO"
        '
        'grdTienda
        '
        Me.grdTienda.AllowColMove = False
        Me.grdTienda.AllowColSelect = False
        Me.grdTienda.AllowUpdate = False
        Me.grdTienda.Caption = "Sucursales"
        Me.grdTienda.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTienda.ExtendRightColumn = True
        Me.grdTienda.FilterBar = True
        Me.grdTienda.GroupByCaption = "Arrastre hacia acá la columna por la cual desea agrupar"
        Me.grdTienda.Images.Add(CType(resources.GetObject("grdTienda.Images"), System.Drawing.Image))
        Me.grdTienda.LinesPerRow = 1
        Me.grdTienda.Location = New System.Drawing.Point(6, 6)
        Me.grdTienda.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdTienda.Name = "grdTienda"
        Me.grdTienda.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTienda.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTienda.PreviewInfo.ZoomFactor = 75
        Me.grdTienda.PrintInfo.PageSettings = CType(resources.GetObject("grdTienda.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTienda.Size = New System.Drawing.Size(704, 201)
        Me.grdTienda.TabIndex = 4
        Me.grdTienda.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdTienda.PropBag = resources.GetString("grdTienda.PropBag")
        '
        'mnuTiendas
        '
        Me.mnuTiendas.AllowMerge = False
        Me.mnuTiendas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuEditar, Me.mnuConsultar, Me.mnuDesactivar, Me.mnuActualizar, Me.mnuImprimir, Me.mnuSalir})
        Me.mnuTiendas.Location = New System.Drawing.Point(0, 0)
        Me.mnuTiendas.Name = "mnuTiendas"
        Me.mnuTiendas.Size = New System.Drawing.Size(716, 24)
        Me.mnuTiendas.TabIndex = 2
        Me.mnuTiendas.Visible = False
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
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConsultar.Size = New System.Drawing.Size(65, 20)
        Me.mnuConsultar.Text = "Consultar"
        '
        'mnuDesactivar
        '
        Me.mnuDesactivar.Name = "mnuDesactivar"
        Me.mnuDesactivar.Size = New System.Drawing.Size(70, 20)
        Me.mnuDesactivar.Text = "Desactivar"
        '
        'mnuActualizar
        '
        Me.mnuActualizar.Name = "mnuActualizar"
        Me.mnuActualizar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuActualizar.Size = New System.Drawing.Size(66, 20)
        Me.mnuActualizar.Text = "Refrescar"
        '
        'mnuImprimir
        '
        Me.mnuImprimir.Name = "mnuImprimir"
        Me.mnuImprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuImprimir.Size = New System.Drawing.Size(57, 20)
        Me.mnuImprimir.Text = "Imprimir"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuSalir.Size = New System.Drawing.Size(39, 20)
        Me.mnuSalir.Text = "Salir"
        '
        'lblProximoNoFactura
        '
        Me.lblProximoNoFactura.AutoSize = True
        Me.lblProximoNoFactura.Location = New System.Drawing.Point(6, 121)
        Me.lblProximoNoFactura.Name = "lblProximoNoFactura"
        Me.lblProximoNoFactura.Size = New System.Drawing.Size(96, 13)
        Me.lblProximoNoFactura.TabIndex = 10
        Me.lblProximoNoFactura.Text = "Próximo # Factura:"
        '
        'txtProximoNumeroFact
        '
        Me.txtProximoNumeroFact.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtProximoNumeroFact.Location = New System.Drawing.Point(108, 118)
        Me.txtProximoNumeroFact.Multiline = True
        Me.txtProximoNumeroFact.Name = "txtProximoNumeroFact"
        Me.txtProximoNumeroFact.ReadOnly = True
        Me.txtProximoNumeroFact.Size = New System.Drawing.Size(167, 26)
        Me.txtProximoNumeroFact.TabIndex = 16
        Me.txtProximoNumeroFact.Tag = "BLOQUEADO"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(300, 124)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(34, 13)
        Me.lblSerie.TabIndex = 10
        Me.lblSerie.Text = "Serie:"
        '
        'txtSerieFactura
        '
        Me.txtSerieFactura.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSerieFactura.Location = New System.Drawing.Point(340, 118)
        Me.txtSerieFactura.Multiline = True
        Me.txtSerieFactura.Name = "txtSerieFactura"
        Me.txtSerieFactura.ReadOnly = True
        Me.txtSerieFactura.Size = New System.Drawing.Size(108, 26)
        Me.txtSerieFactura.TabIndex = 16
        Me.txtSerieFactura.Tag = "BLOQUEADO"
        '
        'frmStbTiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 440)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tbTiendas)
        Me.Controls.Add(Me.mnuTiendas)
        Me.MainMenuStrip = Me.mnuTiendas
        Me.Name = "frmStbTiendas"
        Me.Text = "Catálogo de Sucursales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbTiendas.ResumeLayout(False)
        Me.tbTiendas.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grbTienda.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.grdTienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuTiendas.ResumeLayout(False)
        Me.mnuTiendas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTiendas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grbTienda As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtTelefonos As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonos As System.Windows.Forms.Label
    Friend WithEvents txtDirecciones As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMoviles As System.Windows.Forms.TextBox
    Friend WithEvents lblMoviles As System.Windows.Forms.Label
    Friend WithEvents lblDirecciones As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtFacsimiles As System.Windows.Forms.TextBox
    Friend WithEvents lblFacsimiles As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents grdTienda As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDesactivar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTiendas As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSerieFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtProximoNumeroFact As System.Windows.Forms.TextBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents lblProximoNoFactura As System.Windows.Forms.Label
End Class
