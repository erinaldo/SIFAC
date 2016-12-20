<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccMantNotaCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccMantNotaCredito))
        Me.tstNotaCredito = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarNC = New System.Windows.Forms.ToolStripButton()
        Me.tsbModificarNC = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAutorizarNC = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnularNC = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBuscarNC = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsultarNC = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.grdNotaCredito = New DevExpress.XtraGrid.GridControl()
        Me.grdNotaCreditoTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjConceptoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjEstadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroCN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjClienteID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tstNotaCredito.SuspendLayout()
        CType(Me.grdNotaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotaCreditoTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tstNotaCredito
        '
        Me.tstNotaCredito.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstNotaCredito.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarNC, Me.tsbModificarNC, Me.ToolStripSeparator1, Me.tsbAutorizarNC, Me.tsbAnularNC, Me.ToolStripSeparator2, Me.tsbBuscarNC, Me.tsbConsultarNC, Me.ToolStripSeparator3, Me.tsbImprimir, Me.tsbRefrescar, Me.ToolStripSeparator4, Me.tsbSalir})
        Me.tstNotaCredito.Location = New System.Drawing.Point(0, 0)
        Me.tstNotaCredito.Name = "tstNotaCredito"
        Me.tstNotaCredito.Size = New System.Drawing.Size(960, 39)
        Me.tstNotaCredito.TabIndex = 1
        Me.tstNotaCredito.Text = "ToolStrip1"
        '
        'tsbAgregarNC
        '
        Me.tsbAgregarNC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAgregarNC.Image = CType(resources.GetObject("tsbAgregarNC.Image"), System.Drawing.Image)
        Me.tsbAgregarNC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarNC.Name = "tsbAgregarNC"
        Me.tsbAgregarNC.Size = New System.Drawing.Size(36, 36)
        Me.tsbAgregarNC.Text = "Agregar Nota de Crédito"
        '
        'tsbModificarNC
        '
        Me.tsbModificarNC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbModificarNC.Enabled = False
        Me.tsbModificarNC.Image = CType(resources.GetObject("tsbModificarNC.Image"), System.Drawing.Image)
        Me.tsbModificarNC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificarNC.Name = "tsbModificarNC"
        Me.tsbModificarNC.Size = New System.Drawing.Size(36, 36)
        Me.tsbModificarNC.Text = "Modificar Nota de Crédito"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbAutorizarNC
        '
        Me.tsbAutorizarNC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAutorizarNC.Enabled = False
        Me.tsbAutorizarNC.Image = CType(resources.GetObject("tsbAutorizarNC.Image"), System.Drawing.Image)
        Me.tsbAutorizarNC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAutorizarNC.Name = "tsbAutorizarNC"
        Me.tsbAutorizarNC.Size = New System.Drawing.Size(36, 36)
        Me.tsbAutorizarNC.Text = "Autorizar Nota de Crédito"
        '
        'tsbAnularNC
        '
        Me.tsbAnularNC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAnularNC.Enabled = False
        Me.tsbAnularNC.Image = CType(resources.GetObject("tsbAnularNC.Image"), System.Drawing.Image)
        Me.tsbAnularNC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnularNC.Name = "tsbAnularNC"
        Me.tsbAnularNC.Size = New System.Drawing.Size(36, 36)
        Me.tsbAnularNC.Text = "Anular Nota de Crédito"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsbBuscarNC
        '
        Me.tsbBuscarNC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBuscarNC.Enabled = False
        Me.tsbBuscarNC.Image = CType(resources.GetObject("tsbBuscarNC.Image"), System.Drawing.Image)
        Me.tsbBuscarNC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscarNC.Name = "tsbBuscarNC"
        Me.tsbBuscarNC.Size = New System.Drawing.Size(36, 36)
        Me.tsbBuscarNC.Text = "Buscar Nota de Crédito"
        Me.tsbBuscarNC.Visible = False
        '
        'tsbConsultarNC
        '
        Me.tsbConsultarNC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbConsultarNC.Enabled = False
        Me.tsbConsultarNC.Image = CType(resources.GetObject("tsbConsultarNC.Image"), System.Drawing.Image)
        Me.tsbConsultarNC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultarNC.Name = "tsbConsultarNC"
        Me.tsbConsultarNC.Size = New System.Drawing.Size(36, 36)
        Me.tsbConsultarNC.Text = "Consultar Nota de Crédito"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbImprimir
        '
        Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir.Enabled = False
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(36, 36)
        Me.tsbImprimir.Text = "Imprimir"
        Me.tsbImprimir.Visible = False
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
        'grdNotaCredito
        '
        Me.grdNotaCredito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdNotaCredito.Location = New System.Drawing.Point(0, 39)
        Me.grdNotaCredito.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdNotaCredito.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdNotaCredito.MainView = Me.grdNotaCreditoTabla
        Me.grdNotaCredito.Name = "grdNotaCredito"
        Me.grdNotaCredito.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdNotaCredito.Size = New System.Drawing.Size(960, 624)
        Me.grdNotaCredito.TabIndex = 10
        Me.grdNotaCredito.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdNotaCreditoTabla})
        '
        'grdNotaCreditoTabla
        '
        Me.grdNotaCreditoTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colMonto, Me.colobjConceptoID, Me.colNumCuenta, Me.colobjEstadoID, Me.colCliente, Me.colConcepto, Me.colEstado, Me.colNumeroCN, Me.colobjClienteID})
        Me.grdNotaCreditoTabla.GridControl = Me.grdNotaCredito
        Me.grdNotaCreditoTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdNotaCreditoTabla.Name = "grdNotaCreditoTabla"
        Me.grdNotaCreditoTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdNotaCreditoTabla.Tag = ""
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "SccNotaCreditoID"
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
        Me.colMonto.VisibleIndex = 5
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
        Me.colNumCuenta.FieldName = "NumeroCuenta"
        Me.colNumCuenta.Name = "colNumCuenta"
        Me.colNumCuenta.OptionsColumn.AllowEdit = False
        Me.colNumCuenta.Visible = True
        Me.colNumCuenta.VisibleIndex = 2
        Me.colNumCuenta.Width = 124
        '
        'colobjEstadoID
        '
        Me.colobjEstadoID.Caption = "objEstadoID"
        Me.colobjEstadoID.FieldName = "objEstadoID"
        Me.colobjEstadoID.Name = "colobjEstadoID"
        Me.colobjEstadoID.OptionsColumn.AllowEdit = False
        Me.colobjEstadoID.Width = 139
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 3
        Me.colCliente.Width = 205
        '
        'colConcepto
        '
        Me.colConcepto.Caption = "Concepto"
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.OptionsColumn.AllowEdit = False
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 4
        Me.colConcepto.Width = 186
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "EstadoNC"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 6
        Me.colEstado.Width = 134
        '
        'colNumeroCN
        '
        Me.colNumeroCN.Caption = "Número"
        Me.colNumeroCN.FieldName = "NumeroNC"
        Me.colNumeroCN.Name = "colNumeroCN"
        Me.colNumeroCN.OptionsColumn.AllowEdit = False
        Me.colNumeroCN.Visible = True
        Me.colNumeroCN.VisibleIndex = 0
        Me.colNumeroCN.Width = 96
        '
        'colobjClienteID
        '
        Me.colobjClienteID.Caption = "objClienteID"
        Me.colobjClienteID.FieldName = "objClienteID"
        Me.colobjClienteID.Name = "colobjClienteID"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSccMantNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 663)
        Me.Controls.Add(Me.grdNotaCredito)
        Me.Controls.Add(Me.tstNotaCredito)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccMantNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "CATALOGOS"
        Me.Text = "Notas de Crédito"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tstNotaCredito.ResumeLayout(False)
        Me.tstNotaCredito.PerformLayout()
        CType(Me.grdNotaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotaCreditoTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tstNotaCredito As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarNC As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificarNC As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAutorizarNC As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnularNC As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbBuscarNC As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbConsultarNC As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdNotaCredito As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdNotaCreditoTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjConceptoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjEstadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroCN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colobjClienteID As DevExpress.XtraGrid.Columns.GridColumn
End Class
