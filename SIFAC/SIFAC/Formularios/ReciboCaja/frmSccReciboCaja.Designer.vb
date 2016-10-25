<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccReciboCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccReciboCaja))
        Me.tbRecibosCajas = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAprobar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CMDBuscarReciboCaja = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.objUbicacion = New System.Windows.Forms.SaveFileDialog()
        Me.grdRecibosCaja = New DevExpress.XtraGrid.GridControl()
        Me.grdRecibosCajaTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSccReciboCajaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroRecibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSccCuentaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjEstadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tbRecibosCajas.SuspendLayout()
        CType(Me.grdRecibosCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRecibosCajaTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbRecibosCajas
        '
        Me.tbRecibosCajas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbRecibosCajas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.ToolStripSeparator1, Me.cmdAprobar, Me.ToolStripSeparator2, Me.CMDBuscarReciboCaja, Me.cmdConsultar, Me.cmdRefrescar, Me.cmdSalir})
        Me.tbRecibosCajas.Location = New System.Drawing.Point(0, 0)
        Me.tbRecibosCajas.Name = "tbRecibosCajas"
        Me.tbRecibosCajas.Size = New System.Drawing.Size(721, 39)
        Me.tbRecibosCajas.TabIndex = 1
        Me.tbRecibosCajas.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Agregar Recibo de Caja"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Recibo de Caja"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAprobar
        '
        Me.cmdAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAprobar.Image = CType(resources.GetObject("cmdAprobar.Image"), System.Drawing.Image)
        Me.cmdAprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAprobar.Text = "Autorizar Recibo de Caja"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'CMDBuscarReciboCaja
        '
        Me.CMDBuscarReciboCaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CMDBuscarReciboCaja.Image = CType(resources.GetObject("CMDBuscarReciboCaja.Image"), System.Drawing.Image)
        Me.CMDBuscarReciboCaja.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CMDBuscarReciboCaja.Name = "CMDBuscarReciboCaja"
        Me.CMDBuscarReciboCaja.Size = New System.Drawing.Size(36, 36)
        Me.CMDBuscarReciboCaja.Text = "Buscar Recibo de Caja"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "CONSULTAR"
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "REFRESCAR"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "SALIR"
        '
        'grdRecibosCaja
        '
        Me.grdRecibosCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecibosCaja.Location = New System.Drawing.Point(0, 39)
        Me.grdRecibosCaja.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdRecibosCaja.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdRecibosCaja.MainView = Me.grdRecibosCajaTabla
        Me.grdRecibosCaja.Name = "grdRecibosCaja"
        Me.grdRecibosCaja.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdRecibosCaja.Size = New System.Drawing.Size(721, 439)
        Me.grdRecibosCaja.TabIndex = 10
        Me.grdRecibosCaja.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdRecibosCajaTabla})
        '
        'grdRecibosCajaTabla
        '
        Me.grdRecibosCajaTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSccReciboCajaID, Me.colNumeroRecibo, Me.colSccCuentaID, Me.colMonto, Me.colFecha, Me.colCliente, Me.colEstado, Me.colobjEstadoID})
        Me.grdRecibosCajaTabla.GridControl = Me.grdRecibosCaja
        Me.grdRecibosCajaTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdRecibosCajaTabla.Name = "grdRecibosCajaTabla"
        Me.grdRecibosCajaTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdRecibosCajaTabla.Tag = ""
        '
        'colSccReciboCajaID
        '
        Me.colSccReciboCajaID.Caption = "SccReciboCajaID"
        Me.colSccReciboCajaID.FieldName = "SccReciboCajaID"
        Me.colSccReciboCajaID.Name = "colSccReciboCajaID"
        Me.colSccReciboCajaID.OptionsColumn.AllowEdit = False
        Me.colSccReciboCajaID.OptionsColumn.ReadOnly = True
        Me.colSccReciboCajaID.Width = 108
        '
        'colNumeroRecibo
        '
        Me.colNumeroRecibo.Caption = "Número"
        Me.colNumeroRecibo.FieldName = "NumeroRecibo"
        Me.colNumeroRecibo.Name = "colNumeroRecibo"
        Me.colNumeroRecibo.OptionsColumn.AllowEdit = False
        Me.colNumeroRecibo.Visible = True
        Me.colNumeroRecibo.VisibleIndex = 0
        Me.colNumeroRecibo.Width = 133
        '
        'colSccCuentaID
        '
        Me.colSccCuentaID.Caption = "No. Expediente"
        Me.colSccCuentaID.FieldName = "SccCuentaID"
        Me.colSccCuentaID.Name = "colSccCuentaID"
        Me.colSccCuentaID.OptionsColumn.AllowEdit = False
        Me.colSccCuentaID.OptionsColumn.ReadOnly = True
        Me.colSccCuentaID.Visible = True
        Me.colSccCuentaID.VisibleIndex = 1
        Me.colSccCuentaID.Width = 150
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.FieldName = "TotalRecibo"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.OptionsColumn.AllowEdit = False
        Me.colMonto.OptionsColumn.ReadOnly = True
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 2
        Me.colMonto.Width = 76
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 3
        Me.colFecha.Width = 128
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 80
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 5
        Me.colEstado.Width = 54
        '
        'colobjEstadoID
        '
        Me.colobjEstadoID.Caption = "objEstadoID"
        Me.colobjEstadoID.FieldName = "objEstadoId"
        Me.colobjEstadoID.Name = "colobjEstadoID"
        Me.colobjEstadoID.OptionsColumn.AllowEdit = False
        Me.colobjEstadoID.Width = 83
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSccReciboCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 478)
        Me.Controls.Add(Me.grdRecibosCaja)
        Me.Controls.Add(Me.tbRecibosCajas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccReciboCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "AGRUPAR"
        Me.Text = "Recibos de Caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbRecibosCajas.ResumeLayout(False)
        Me.tbRecibosCajas.PerformLayout()
        CType(Me.grdRecibosCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRecibosCajaTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbRecibosCajas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CMDBuscarReciboCaja As System.Windows.Forms.ToolStripButton
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents grdRecibosCaja As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdRecibosCajaTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSccReciboCajaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSccCuentaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjEstadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
