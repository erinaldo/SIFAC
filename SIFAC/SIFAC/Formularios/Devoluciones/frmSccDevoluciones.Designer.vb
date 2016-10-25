<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccDevoluciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccDevoluciones))
        Me.tstNotaCredito = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarDev = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditarDev = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAutorizarDev = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdConsultarDev = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscarDevolucion = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.grdDevolucion = New DevExpress.XtraGrid.GridControl()
        Me.grdDevolucionTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpediente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colobjEstadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSccDevolucionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tstNotaCredito.SuspendLayout()
        CType(Me.grdDevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDevolucionTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tstNotaCredito
        '
        Me.tstNotaCredito.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstNotaCredito.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarDev, Me.cmdEditarDev, Me.ToolStripSeparator3, Me.cmdAutorizarDev, Me.ToolStripSeparator1, Me.cmdConsultarDev, Me.cmdBuscarDevolucion, Me.tsbRefrescar, Me.ToolStripSeparator4, Me.tsbSalir})
        Me.tstNotaCredito.Location = New System.Drawing.Point(0, 0)
        Me.tstNotaCredito.Name = "tstNotaCredito"
        Me.tstNotaCredito.Size = New System.Drawing.Size(731, 39)
        Me.tstNotaCredito.TabIndex = 2
        Me.tstNotaCredito.Text = "ToolStrip1"
        '
        'cmdAgregarDev
        '
        Me.cmdAgregarDev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarDev.Image = CType(resources.GetObject("cmdAgregarDev.Image"), System.Drawing.Image)
        Me.cmdAgregarDev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarDev.Name = "cmdAgregarDev"
        Me.cmdAgregarDev.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregarDev.Text = "Agregar Devolución"
        '
        'cmdEditarDev
        '
        Me.cmdEditarDev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditarDev.Image = CType(resources.GetObject("cmdEditarDev.Image"), System.Drawing.Image)
        Me.cmdEditarDev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditarDev.Name = "cmdEditarDev"
        Me.cmdEditarDev.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditarDev.Text = "Editar Devolución"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAutorizarDev
        '
        Me.cmdAutorizarDev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAutorizarDev.Image = CType(resources.GetObject("cmdAutorizarDev.Image"), System.Drawing.Image)
        Me.cmdAutorizarDev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAutorizarDev.Name = "cmdAutorizarDev"
        Me.cmdAutorizarDev.Size = New System.Drawing.Size(36, 36)
        Me.cmdAutorizarDev.Text = "Autorizar Devolución"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdConsultarDev
        '
        Me.cmdConsultarDev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultarDev.Image = CType(resources.GetObject("cmdConsultarDev.Image"), System.Drawing.Image)
        Me.cmdConsultarDev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultarDev.Name = "cmdConsultarDev"
        Me.cmdConsultarDev.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultarDev.Text = "Consultar Devolucion"
        '
        'cmdBuscarDevolucion
        '
        Me.cmdBuscarDevolucion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscarDevolucion.Image = CType(resources.GetObject("cmdBuscarDevolucion.Image"), System.Drawing.Image)
        Me.cmdBuscarDevolucion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscarDevolucion.Name = "cmdBuscarDevolucion"
        Me.cmdBuscarDevolucion.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscarDevolucion.Text = "Buscar Devolución"
        Me.cmdBuscarDevolucion.Visible = False
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
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
        'grdDevolucion
        '
        Me.grdDevolucion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDevolucion.Location = New System.Drawing.Point(0, 39)
        Me.grdDevolucion.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdDevolucion.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdDevolucion.MainView = Me.grdDevolucionTabla
        Me.grdDevolucion.Name = "grdDevolucion"
        Me.grdDevolucion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdDevolucion.Size = New System.Drawing.Size(731, 513)
        Me.grdDevolucion.TabIndex = 8
        Me.grdDevolucion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDevolucionTabla})
        '
        'grdDevolucionTabla
        '
        Me.grdDevolucionTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colExpediente, Me.colFecha, Me.colCliente, Me.colobjEstadoID, Me.colSccDevolucionID})
        Me.grdDevolucionTabla.GridControl = Me.grdDevolucion
        Me.grdDevolucionTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdDevolucionTabla.Name = "grdDevolucionTabla"
        Me.grdDevolucionTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdDevolucionTabla.Tag = ""
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "NumeroDevolucion"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 0
        Me.colNumero.Width = 140
        '
        'colExpediente
        '
        Me.colExpediente.Caption = "Expediente"
        Me.colExpediente.FieldName = "SccCuentaID"
        Me.colExpediente.Name = "colExpediente"
        Me.colExpediente.OptionsColumn.AllowEdit = False
        Me.colExpediente.Visible = True
        Me.colExpediente.VisibleIndex = 1
        Me.colExpediente.Width = 112
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 2
        Me.colFecha.Width = 139
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 3
        Me.colCliente.Width = 322
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colobjEstadoID
        '
        Me.colobjEstadoID.Caption = "objEstadoID"
        Me.colobjEstadoID.FieldName = "objEstadoID"
        Me.colobjEstadoID.Name = "colobjEstadoID"
        '
        'colSccDevolucionID
        '
        Me.colSccDevolucionID.Caption = "SccDevolucionID"
        Me.colSccDevolucionID.FieldName = "SccDevolucionID"
        Me.colSccDevolucionID.Name = "colSccDevolucionID"
        '
        'frmSccDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 552)
        Me.Controls.Add(Me.grdDevolucion)
        Me.Controls.Add(Me.tstNotaCredito)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccDevoluciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Devoluciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tstNotaCredito.ResumeLayout(False)
        Me.tstNotaCredito.PerformLayout()
        CType(Me.grdDevolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDevolucionTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tstNotaCredito As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarDev As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarDev As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditarDev As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAutorizarDev As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBuscarDevolucion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grdDevolucion As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDevolucionTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpediente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colobjEstadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSccDevolucionID As DevExpress.XtraGrid.Columns.GridColumn
End Class
