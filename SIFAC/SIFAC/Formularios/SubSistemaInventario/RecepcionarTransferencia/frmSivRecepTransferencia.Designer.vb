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
        Me.toolRecepcionTransf = New System.Windows.Forms.ToolStrip()
        Me.cmdAprobar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultarSolicitud = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.cmdImprimirSeleccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdImprimirFiltro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.grdTrasnferencias = New DevExpress.XtraGrid.GridControl()
        Me.grdTransferenciasTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSivTransferenciaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSitioOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSitioDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSolicitadoPor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDespachadoPor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaDespacho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaSolicitud = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colObjEstadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObjTiendaDestinoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.toolRecepcionTransf.SuspendLayout()
        CType(Me.grdTrasnferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTransferenciasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolRecepcionTransf
        '
        Me.toolRecepcionTransf.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolRecepcionTransf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAprobar, Me.cmdConsultarSolicitud, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolRecepcionTransf.Location = New System.Drawing.Point(0, 0)
        Me.toolRecepcionTransf.Name = "toolRecepcionTransf"
        Me.toolRecepcionTransf.Size = New System.Drawing.Size(951, 39)
        Me.toolRecepcionTransf.TabIndex = 6
        '
        'cmdAprobar
        '
        Me.cmdAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAprobar.Image = CType(resources.GetObject("cmdAprobar.Image"), System.Drawing.Image)
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
        Me.cmdImprimirSeleccion.Size = New System.Drawing.Size(152, 22)
        Me.cmdImprimirSeleccion.Text = "Seleccionada"
        '
        'cmdImprimirFiltro
        '
        Me.cmdImprimirFiltro.Name = "cmdImprimirFiltro"
        Me.cmdImprimirFiltro.Size = New System.Drawing.Size(152, 22)
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
        'grdTrasnferencias
        '
        Me.grdTrasnferencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTrasnferencias.Location = New System.Drawing.Point(0, 39)
        Me.grdTrasnferencias.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdTrasnferencias.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdTrasnferencias.MainView = Me.grdTransferenciasTabla
        Me.grdTrasnferencias.Name = "grdTrasnferencias"
        Me.grdTrasnferencias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.grdTrasnferencias.Size = New System.Drawing.Size(951, 585)
        Me.grdTrasnferencias.TabIndex = 9
        Me.grdTrasnferencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdTransferenciasTabla})
        '
        'grdTransferenciasTabla
        '
        Me.grdTransferenciasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSivTransferenciaID, Me.colSitioOrigen, Me.colSitioDestino, Me.colSolicitadoPor, Me.colDespachadoPor, Me.colFechaDespacho, Me.colFechaSolicitud, Me.colObjEstadoID, Me.colEstado, Me.colObjTiendaDestinoID})
        Me.grdTransferenciasTabla.GridControl = Me.grdTrasnferencias
        Me.grdTransferenciasTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdTransferenciasTabla.Name = "grdTransferenciasTabla"
        Me.grdTransferenciasTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdTransferenciasTabla.Tag = ""
        '
        'colSivTransferenciaID
        '
        Me.colSivTransferenciaID.Caption = "Número Transferencia"
        Me.colSivTransferenciaID.FieldName = "SivTransferenciaID"
        Me.colSivTransferenciaID.Name = "colSivTransferenciaID"
        Me.colSivTransferenciaID.OptionsColumn.AllowEdit = False
        Me.colSivTransferenciaID.OptionsColumn.ReadOnly = True
        Me.colSivTransferenciaID.Visible = True
        Me.colSivTransferenciaID.VisibleIndex = 0
        Me.colSivTransferenciaID.Width = 132
        '
        'colSitioOrigen
        '
        Me.colSitioOrigen.Caption = "Bodega Origen"
        Me.colSitioOrigen.FieldName = "SitioOrigen"
        Me.colSitioOrigen.Name = "colSitioOrigen"
        Me.colSitioOrigen.OptionsColumn.AllowEdit = False
        Me.colSitioOrigen.OptionsColumn.ReadOnly = True
        Me.colSitioOrigen.Visible = True
        Me.colSitioOrigen.VisibleIndex = 1
        Me.colSitioOrigen.Width = 125
        '
        'colSitioDestino
        '
        Me.colSitioDestino.Caption = "Bodega Destino"
        Me.colSitioDestino.FieldName = "SitioDestino"
        Me.colSitioDestino.Name = "colSitioDestino"
        Me.colSitioDestino.OptionsColumn.AllowEdit = False
        Me.colSitioDestino.OptionsColumn.ReadOnly = True
        Me.colSitioDestino.Visible = True
        Me.colSitioDestino.VisibleIndex = 2
        Me.colSitioDestino.Width = 128
        '
        'colSolicitadoPor
        '
        Me.colSolicitadoPor.Caption = "Solicitado por"
        Me.colSolicitadoPor.FieldName = "SolicitadoPor"
        Me.colSolicitadoPor.Name = "colSolicitadoPor"
        Me.colSolicitadoPor.OptionsColumn.AllowEdit = False
        Me.colSolicitadoPor.OptionsColumn.ReadOnly = True
        Me.colSolicitadoPor.Visible = True
        Me.colSolicitadoPor.VisibleIndex = 4
        Me.colSolicitadoPor.Width = 149
        '
        'colDespachadoPor
        '
        Me.colDespachadoPor.Caption = "Despachado Por"
        Me.colDespachadoPor.FieldName = "DespachadoPor"
        Me.colDespachadoPor.Name = "colDespachadoPor"
        Me.colDespachadoPor.OptionsColumn.AllowEdit = False
        Me.colDespachadoPor.OptionsColumn.ReadOnly = True
        Me.colDespachadoPor.Visible = True
        Me.colDespachadoPor.VisibleIndex = 6
        Me.colDespachadoPor.Width = 99
        '
        'colFechaDespacho
        '
        Me.colFechaDespacho.Caption = "Fecha Despacho"
        Me.colFechaDespacho.FieldName = "Fechadespacho"
        Me.colFechaDespacho.Name = "colFechaDespacho"
        Me.colFechaDespacho.OptionsColumn.AllowEdit = False
        Me.colFechaDespacho.OptionsColumn.ReadOnly = True
        Me.colFechaDespacho.Visible = True
        Me.colFechaDespacho.VisibleIndex = 5
        Me.colFechaDespacho.Width = 101
        '
        'colFechaSolicitud
        '
        Me.colFechaSolicitud.Caption = "Fecha Solicitud"
        Me.colFechaSolicitud.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFechaSolicitud.FieldName = "Fechasolicitud"
        Me.colFechaSolicitud.Name = "colFechaSolicitud"
        Me.colFechaSolicitud.OptionsColumn.AllowEdit = False
        Me.colFechaSolicitud.OptionsColumn.ReadOnly = True
        Me.colFechaSolicitud.Visible = True
        Me.colFechaSolicitud.VisibleIndex = 3
        Me.colFechaSolicitud.Width = 115
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colObjEstadoID
        '
        Me.colObjEstadoID.Caption = "ObjEstadoID"
        Me.colObjEstadoID.FieldName = "ObjEstadoID"
        Me.colObjEstadoID.Name = "colObjEstadoID"
        Me.colObjEstadoID.OptionsColumn.AllowEdit = False
        Me.colObjEstadoID.OptionsColumn.ReadOnly = True
        Me.colObjEstadoID.Width = 51
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 7
        Me.colEstado.Width = 84
        '
        'colObjTiendaDestinoID
        '
        Me.colObjTiendaDestinoID.Caption = "ObjTiendaDestinoID"
        Me.colObjTiendaDestinoID.FieldName = "ObjBodegaDestinoID"
        Me.colObjTiendaDestinoID.Name = "colObjTiendaDestinoID"
        Me.colObjTiendaDestinoID.OptionsColumn.AllowEdit = False
        Me.colObjTiendaDestinoID.OptionsColumn.ReadOnly = True
        Me.colObjTiendaDestinoID.Width = 80
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSivRecepTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 624)
        Me.Controls.Add(Me.grdTrasnferencias)
        Me.Controls.Add(Me.toolRecepcionTransf)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivRecepTransferencia"
        Me.Text = "Recepción de transferencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolRecepcionTransf.ResumeLayout(False)
        Me.toolRecepcionTransf.PerformLayout()
        CType(Me.grdTrasnferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTransferenciasTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolRecepcionTransf As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdImprimirSeleccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdImprimirFiltro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdTrasnferencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdTransferenciasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSivTransferenciaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSitioOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSitioDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSolicitadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDespachadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaDespacho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaSolicitud As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colObjEstadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObjTiendaDestinoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
