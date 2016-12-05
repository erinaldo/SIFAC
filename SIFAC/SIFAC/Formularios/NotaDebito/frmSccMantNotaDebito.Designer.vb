<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccMantNotaDebito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccMantNotaDebito))
        Me.tstND = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarND = New System.Windows.Forms.ToolStripButton()
        Me.tsbModificarND = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAutorizarND = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnularND = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBuscarND = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsultarND = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeshacerNota = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbImprimirND = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdND = New DevExpress.XtraGrid.GridControl()
        Me.grdNDTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjConceptoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStbPersonaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroFact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tstND.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNDTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tstND
        '
        Me.tstND.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstND.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarND, Me.tsbModificarND, Me.ToolStripSeparator1, Me.tsbAutorizarND, Me.tsbAnularND, Me.ToolStripSeparator2, Me.tsbBuscarND, Me.tsbConsultarND, Me.cmdDeshacerNota, Me.ToolStripSeparator3, Me.tsbImprimirND, Me.tsbRefrescar, Me.ToolStripSeparator4, Me.tsbSalir})
        Me.tstND.Location = New System.Drawing.Point(0, 0)
        Me.tstND.Name = "tstND"
        Me.tstND.Size = New System.Drawing.Size(1133, 39)
        Me.tstND.TabIndex = 2
        Me.tstND.Text = "Nota de Débito"
        '
        'tsbAgregarND
        '
        Me.tsbAgregarND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAgregarND.Enabled = False
        Me.tsbAgregarND.Image = CType(resources.GetObject("tsbAgregarND.Image"), System.Drawing.Image)
        Me.tsbAgregarND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarND.Name = "tsbAgregarND"
        Me.tsbAgregarND.Size = New System.Drawing.Size(36, 36)
        Me.tsbAgregarND.Text = "Agregar Nota de Débito"
        '
        'tsbModificarND
        '
        Me.tsbModificarND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbModificarND.Enabled = False
        Me.tsbModificarND.Image = CType(resources.GetObject("tsbModificarND.Image"), System.Drawing.Image)
        Me.tsbModificarND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificarND.Name = "tsbModificarND"
        Me.tsbModificarND.Size = New System.Drawing.Size(36, 36)
        Me.tsbModificarND.Text = "Modificar Nota de Débito"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbAutorizarND
        '
        Me.tsbAutorizarND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAutorizarND.Enabled = False
        Me.tsbAutorizarND.Image = CType(resources.GetObject("tsbAutorizarND.Image"), System.Drawing.Image)
        Me.tsbAutorizarND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAutorizarND.Name = "tsbAutorizarND"
        Me.tsbAutorizarND.Size = New System.Drawing.Size(36, 36)
        Me.tsbAutorizarND.Text = "Autorizar Nota de Débito"
        '
        'tsbAnularND
        '
        Me.tsbAnularND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAnularND.Enabled = False
        Me.tsbAnularND.Image = CType(resources.GetObject("tsbAnularND.Image"), System.Drawing.Image)
        Me.tsbAnularND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnularND.Name = "tsbAnularND"
        Me.tsbAnularND.Size = New System.Drawing.Size(36, 36)
        Me.tsbAnularND.Text = "Anular Nota de Débito"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsbBuscarND
        '
        Me.tsbBuscarND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBuscarND.Enabled = False
        Me.tsbBuscarND.Image = CType(resources.GetObject("tsbBuscarND.Image"), System.Drawing.Image)
        Me.tsbBuscarND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscarND.Name = "tsbBuscarND"
        Me.tsbBuscarND.Size = New System.Drawing.Size(36, 36)
        Me.tsbBuscarND.Text = "Buscar Nota de Débito"
        Me.tsbBuscarND.Visible = False
        '
        'tsbConsultarND
        '
        Me.tsbConsultarND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbConsultarND.Enabled = False
        Me.tsbConsultarND.Image = CType(resources.GetObject("tsbConsultarND.Image"), System.Drawing.Image)
        Me.tsbConsultarND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultarND.Name = "tsbConsultarND"
        Me.tsbConsultarND.Size = New System.Drawing.Size(36, 36)
        Me.tsbConsultarND.Text = "Consultar Nota de Débito"
        '
        'cmdDeshacerNota
        '
        Me.cmdDeshacerNota.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDeshacerNota.Image = CType(resources.GetObject("cmdDeshacerNota.Image"), System.Drawing.Image)
        Me.cmdDeshacerNota.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeshacerNota.Name = "cmdDeshacerNota"
        Me.cmdDeshacerNota.Size = New System.Drawing.Size(36, 36)
        Me.cmdDeshacerNota.Text = "Deshacer Nota de débito"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbImprimirND
        '
        Me.tsbImprimirND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimirND.Enabled = False
        Me.tsbImprimirND.Image = CType(resources.GetObject("tsbImprimirND.Image"), System.Drawing.Image)
        Me.tsbImprimirND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimirND.Name = "tsbImprimirND"
        Me.tsbImprimirND.Size = New System.Drawing.Size(36, 36)
        Me.tsbImprimirND.Text = "Imprimir"
        Me.tsbImprimirND.Visible = False
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1133, 624)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grdND)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1125, 598)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Notas de Débito"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grdND
        '
        Me.grdND.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdND.Location = New System.Drawing.Point(3, 3)
        Me.grdND.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdND.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdND.MainView = Me.grdNDTabla
        Me.grdND.Name = "grdND"
        Me.grdND.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdND.Size = New System.Drawing.Size(1119, 592)
        Me.grdND.TabIndex = 9
        Me.grdND.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdNDTabla})
        '
        'grdNDTabla
        '
        Me.grdNDTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colMonto, Me.colobjConceptoID, Me.colNumCuenta, Me.colStbPersonaID, Me.colCliente, Me.colConcepto, Me.colEstado, Me.colNumeroND, Me.colNumeroFact})
        Me.grdNDTabla.GridControl = Me.grdND
        Me.grdNDTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdNDTabla.Name = "grdNDTabla"
        Me.grdNDTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdNDTabla.Tag = ""
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "SccNotaDebitoID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 111
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.OptionsColumn.AllowEdit = False
        Me.colMonto.OptionsColumn.ReadOnly = True
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 6
        Me.colMonto.Width = 138
        '
        'colobjConceptoID
        '
        Me.colobjConceptoID.Caption = "objConceptoID"
        Me.colobjConceptoID.FieldName = "objConceptoID"
        Me.colobjConceptoID.Name = "colobjConceptoID"
        Me.colobjConceptoID.OptionsColumn.AllowEdit = False
        Me.colobjConceptoID.OptionsColumn.ReadOnly = True
        Me.colobjConceptoID.Width = 158
        '
        'colNumCuenta
        '
        Me.colNumCuenta.Caption = "Expediente"
        Me.colNumCuenta.FieldName = "NumCuenta"
        Me.colNumCuenta.Name = "colNumCuenta"
        Me.colNumCuenta.OptionsColumn.AllowEdit = False
        Me.colNumCuenta.Visible = True
        Me.colNumCuenta.VisibleIndex = 2
        Me.colNumCuenta.Width = 124
        '
        'colStbPersonaID
        '
        Me.colStbPersonaID.Caption = "StbPersonaID"
        Me.colStbPersonaID.FieldName = "StbPersonaID"
        Me.colStbPersonaID.Name = "colStbPersonaID"
        Me.colStbPersonaID.OptionsColumn.AllowEdit = False
        Me.colStbPersonaID.Width = 139
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente/Empleado"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 205
        '
        'colConcepto
        '
        Me.colConcepto.Caption = "Concepto"
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.OptionsColumn.AllowEdit = False
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 5
        Me.colConcepto.Width = 186
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 7
        Me.colEstado.Width = 134
        '
        'colNumeroND
        '
        Me.colNumeroND.Caption = "Número"
        Me.colNumeroND.FieldName = "NumeroND"
        Me.colNumeroND.Name = "colNumeroND"
        Me.colNumeroND.OptionsColumn.AllowEdit = False
        Me.colNumeroND.Visible = True
        Me.colNumeroND.VisibleIndex = 0
        Me.colNumeroND.Width = 96
        '
        'colNumeroFact
        '
        Me.colNumeroFact.Caption = "No. Factura"
        Me.colNumeroFact.FieldName = "NumeroFact"
        Me.colNumeroFact.Name = "colNumeroFact"
        Me.colNumeroFact.OptionsColumn.AllowEdit = False
        Me.colNumeroFact.Visible = True
        Me.colNumeroFact.VisibleIndex = 3
        Me.colNumeroFact.Width = 107
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSccMantNotaDebito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 663)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tstND)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccMantNotaDebito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "CATALOGOS"
        Me.Text = "Nota de Débito"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tstND.ResumeLayout(False)
        Me.tstND.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grdND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNDTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tstND As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarND As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificarND As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAutorizarND As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnularND As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbBuscarND As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbConsultarND As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimirND As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDeshacerNota As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grdND As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdNDTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjConceptoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colNumCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStbPersonaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroFact As DevExpress.XtraGrid.Columns.GridColumn
End Class
