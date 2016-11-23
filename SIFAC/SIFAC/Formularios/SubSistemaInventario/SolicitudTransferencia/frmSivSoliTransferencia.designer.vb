<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivSoliTransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivSoliTransferencia))
        Me.toolSolicitudesTransferencia = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarSolicitud = New System.Windows.Forms.ToolStripButton()
        Me.cmdAnularSolicitud = New System.Windows.Forms.ToolStripButton()
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
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colObjEstadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSivProveedorID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObjTiendaDestinoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.toolSolicitudesTransferencia.SuspendLayout()
        CType(Me.grdTrasnferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTransferenciasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolSolicitudesTransferencia
        '
        Me.toolSolicitudesTransferencia.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolSolicitudesTransferencia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarSolicitud, Me.cmdAnularSolicitud, Me.cmdConsultarSolicitud, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolSolicitudesTransferencia.Location = New System.Drawing.Point(0, 0)
        Me.toolSolicitudesTransferencia.Name = "toolSolicitudesTransferencia"
        Me.toolSolicitudesTransferencia.Size = New System.Drawing.Size(975, 39)
        Me.toolSolicitudesTransferencia.TabIndex = 2
        '
        'cmdAgregarSolicitud
        '
        Me.cmdAgregarSolicitud.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarSolicitud.Image = CType(resources.GetObject("cmdAgregarSolicitud.Image"), System.Drawing.Image)
        Me.cmdAgregarSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarSolicitud.Name = "cmdAgregarSolicitud"
        Me.cmdAgregarSolicitud.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregarSolicitud.Text = "Agregar solicitud"
        '
        'cmdAnularSolicitud
        '
        Me.cmdAnularSolicitud.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnularSolicitud.Image = CType(resources.GetObject("cmdAnularSolicitud.Image"), System.Drawing.Image)
        Me.cmdAnularSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnularSolicitud.Name = "cmdAnularSolicitud"
        Me.cmdAnularSolicitud.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnularSolicitud.Text = "Anular solicitud"
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
        Me.cmdImprimirSeleccion.Size = New System.Drawing.Size(143, 22)
        Me.cmdImprimirSeleccion.Text = "Seleccionada"
        '
        'cmdImprimirFiltro
        '
        Me.cmdImprimirFiltro.Name = "cmdImprimirFiltro"
        Me.cmdImprimirFiltro.Size = New System.Drawing.Size(143, 22)
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
        Me.grdTrasnferencias.Size = New System.Drawing.Size(975, 513)
        Me.grdTrasnferencias.TabIndex = 8
        Me.grdTrasnferencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdTransferenciasTabla})
        '
        'grdTransferenciasTabla
        '
        Me.grdTransferenciasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSivTransferenciaID, Me.colSitioOrigen, Me.colSitioDestino, Me.colSolicitadoPor, Me.colFecha, Me.colObjEstadoID, Me.colEstado, Me.colSivProveedorID, Me.colObjTiendaDestinoID})
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
        Me.colSivTransferenciaID.Width = 109
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
        Me.colSitioOrigen.Width = 182
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
        Me.colSitioDestino.Width = 157
        '
        'colSolicitadoPor
        '
        Me.colSolicitadoPor.Caption = "Solicitado por"
        Me.colSolicitadoPor.FieldName = "SolicitadoPor"
        Me.colSolicitadoPor.Name = "colSolicitadoPor"
        Me.colSolicitadoPor.OptionsColumn.AllowEdit = False
        Me.colSolicitadoPor.OptionsColumn.ReadOnly = True
        Me.colSolicitadoPor.Visible = True
        Me.colSolicitadoPor.VisibleIndex = 3
        Me.colSolicitadoPor.Width = 208
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 4
        Me.colFecha.Width = 141
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
        Me.colEstado.VisibleIndex = 5
        Me.colEstado.Width = 155
        '
        'colSivProveedorID
        '
        Me.colSivProveedorID.Caption = "SivProveedorID"
        Me.colSivProveedorID.FieldName = "SivProveedorID"
        Me.colSivProveedorID.Name = "colSivProveedorID"
        Me.colSivProveedorID.OptionsColumn.AllowEdit = False
        Me.colSivProveedorID.OptionsColumn.ReadOnly = True
        Me.colSivProveedorID.Width = 51
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
        'frmSivSoliTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 552)
        Me.Controls.Add(Me.grdTrasnferencias)
        Me.Controls.Add(Me.toolSolicitudesTransferencia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivSoliTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Solicitudes de Transferencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolSolicitudesTransferencia.ResumeLayout(False)
        Me.toolSolicitudesTransferencia.PerformLayout()
        CType(Me.grdTrasnferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTransferenciasTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolSolicitudesTransferencia As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnularSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdImprimirSeleccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdImprimirFiltro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdTrasnferencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdTransferenciasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSivTransferenciaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSitioOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSitioDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSolicitadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colObjEstadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSivProveedorID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObjTiendaDestinoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
