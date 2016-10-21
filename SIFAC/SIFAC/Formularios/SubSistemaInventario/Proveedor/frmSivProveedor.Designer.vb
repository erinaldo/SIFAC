<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivProveedor))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarProveedor = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditarProveedor = New System.Windows.Forms.ToolStripButton()
        Me.cmdAnularProveedor = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultarProveedor = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.grdvwProveedores = New DevExpress.XtraGrid.GridControl()
        Me.grdvwProveedoresTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRUC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCiudad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefonos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colSivProveedorID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdvwProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwProveedoresTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarProveedor, Me.cmdEditarProveedor, Me.cmdAnularProveedor, Me.cmdConsultarProveedor, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(731, 39)
        Me.toolTramitesLegales.TabIndex = 2
        Me.toolTramitesLegales.Text = "ToolStrip1"
        '
        'cmdAgregarProveedor
        '
        Me.cmdAgregarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarProveedor.Image = CType(resources.GetObject("cmdAgregarProveedor.Image"), System.Drawing.Image)
        Me.cmdAgregarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarProveedor.Name = "cmdAgregarProveedor"
        Me.cmdAgregarProveedor.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregarProveedor.Text = "Agregar Proveedor"
        '
        'cmdEditarProveedor
        '
        Me.cmdEditarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditarProveedor.Image = CType(resources.GetObject("cmdEditarProveedor.Image"), System.Drawing.Image)
        Me.cmdEditarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditarProveedor.Name = "cmdEditarProveedor"
        Me.cmdEditarProveedor.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditarProveedor.Text = "Editar Proveedor"
        '
        'cmdAnularProveedor
        '
        Me.cmdAnularProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnularProveedor.Image = CType(resources.GetObject("cmdAnularProveedor.Image"), System.Drawing.Image)
        Me.cmdAnularProveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnularProveedor.Name = "cmdAnularProveedor"
        Me.cmdAnularProveedor.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnularProveedor.Text = "Anular Proveedor"
        Me.cmdAnularProveedor.Visible = False
        '
        'cmdConsultarProveedor
        '
        Me.cmdConsultarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultarProveedor.Image = CType(resources.GetObject("cmdConsultarProveedor.Image"), System.Drawing.Image)
        Me.cmdConsultarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultarProveedor.Name = "cmdConsultarProveedor"
        Me.cmdConsultarProveedor.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultarProveedor.Text = "Consultar Proveedor"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir Proveedor"
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
        'grdvwProveedores
        '
        Me.grdvwProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdvwProveedores.Location = New System.Drawing.Point(0, 39)
        Me.grdvwProveedores.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.grdvwProveedores.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdvwProveedores.MainView = Me.grdvwProveedoresTabla
        Me.grdvwProveedores.Name = "grdvwProveedores"
        Me.grdvwProveedores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdvwProveedores.Size = New System.Drawing.Size(731, 513)
        Me.grdvwProveedores.TabIndex = 4
        Me.grdvwProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwProveedoresTabla})
        '
        'grdvwProveedoresTabla
        '
        Me.grdvwProveedoresTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre, Me.colRUC, Me.colCiudad, Me.colTelefonos, Me.colActivo, Me.colSivProveedorID})
        Me.grdvwProveedoresTabla.GridControl = Me.grdvwProveedores
        Me.grdvwProveedoresTabla.Name = "grdvwProveedoresTabla"
        Me.grdvwProveedoresTabla.OptionsBehavior.Editable = False
        Me.grdvwProveedoresTabla.OptionsView.ShowAutoFilterRow = True
        '
        'colNombre
        '
        Me.colNombre.Caption = "Razón Social/Nombre"
        Me.colNombre.FieldName = "NombreProveedor"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        '
        'colRUC
        '
        Me.colRUC.Caption = "RUC/Cedula"
        Me.colRUC.FieldName = "Identificacion"
        Me.colRUC.Name = "colRUC"
        Me.colRUC.Visible = True
        Me.colRUC.VisibleIndex = 1
        '
        'colCiudad
        '
        Me.colCiudad.Caption = "Ciudad"
        Me.colCiudad.FieldName = "Ciudad"
        Me.colCiudad.Name = "colCiudad"
        Me.colCiudad.Visible = True
        Me.colCiudad.VisibleIndex = 2
        '
        'colTelefonos
        '
        Me.colTelefonos.Caption = "Teléfono(s)"
        Me.colTelefonos.FieldName = "Telefonos"
        Me.colTelefonos.Name = "colTelefonos"
        Me.colTelefonos.Visible = True
        Me.colTelefonos.VisibleIndex = 3
        '
        'colActivo
        '
        Me.colActivo.Caption = "Activo"
        Me.colActivo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActivo.FieldName = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 4
        Me.colActivo.Width = 86
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colSivProveedorID
        '
        Me.colSivProveedorID.Caption = "SivProveedorID"
        Me.colSivProveedorID.FieldName = "SivProveedorID"
        Me.colSivProveedorID.Name = "colSivProveedorID"
        '
        'frmSivProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 552)
        Me.Controls.Add(Me.grdvwProveedores)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdvwProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwProveedoresTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarProveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarProveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnularProveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditarProveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdvwProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwProveedoresTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRUC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefonos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSivProveedorID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
