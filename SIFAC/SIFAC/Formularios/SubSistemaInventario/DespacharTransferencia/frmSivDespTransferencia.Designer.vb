<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivDespTransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivDespTransferencia))
        Me.toolDespachosTranf = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarSolicitud = New System.Windows.Forms.ToolStripButton()
        Me.cmdDespachar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAnularSolicitud = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultarSolicitud = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.cmdImprimirSeleccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdImprimirFiltro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.grdTrasnferencias = New DevExpress.XtraGrid.GridControl()
        Me.grdTransferenciasTablas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechasolicitud = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSivTransferenciaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSitioOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSitioDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSolicitadoPor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDespachadoPor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObjEstadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObjBodegaDestinoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObjBodegaOrigenID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolDespachosTranf.SuspendLayout()
        CType(Me.grdTrasnferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTransferenciasTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolDespachosTranf
        '
        Me.toolDespachosTranf.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolDespachosTranf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarSolicitud, Me.cmdDespachar, Me.cmdAnularSolicitud, Me.cmdConsultarSolicitud, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir})
        Me.toolDespachosTranf.Location = New System.Drawing.Point(0, 0)
        Me.toolDespachosTranf.Name = "toolDespachosTranf"
        Me.toolDespachosTranf.Size = New System.Drawing.Size(960, 39)
        Me.toolDespachosTranf.TabIndex = 4
        '
        'cmdAgregarSolicitud
        '
        Me.cmdAgregarSolicitud.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarSolicitud.Image = CType(resources.GetObject("cmdAgregarSolicitud.Image"), System.Drawing.Image)
        Me.cmdAgregarSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarSolicitud.Name = "cmdAgregarSolicitud"
        Me.cmdAgregarSolicitud.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregarSolicitud.Text = "Agregar "
        '
        'cmdDespachar
        '
        Me.cmdDespachar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDespachar.Image = Global.SIFAC.My.Resources.Resources.Autorizar_Pedido
        Me.cmdDespachar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDespachar.Name = "cmdDespachar"
        Me.cmdDespachar.Size = New System.Drawing.Size(36, 36)
        Me.cmdDespachar.Text = "Despachar solicitud"
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
        Me.grdTrasnferencias.MainView = Me.grdTransferenciasTablas
        Me.grdTrasnferencias.Name = "grdTrasnferencias"
        Me.grdTrasnferencias.Size = New System.Drawing.Size(960, 498)
        Me.grdTrasnferencias.TabIndex = 6
        Me.grdTrasnferencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdTransferenciasTablas})
        '
        'grdTransferenciasTablas
        '
        Me.grdTransferenciasTablas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha, Me.colFechasolicitud, Me.colSivTransferenciaID, Me.colSitioOrigen, Me.colSitioDestino, Me.colSolicitadoPor, Me.colDespachadoPor, Me.colEstado, Me.colObjEstadoID, Me.colObjBodegaDestinoID, Me.colObjBodegaOrigenID})
        Me.grdTransferenciasTablas.GridControl = Me.grdTrasnferencias
        Me.grdTransferenciasTablas.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdTransferenciasTablas.Name = "grdTransferenciasTablas"
        Me.grdTransferenciasTablas.OptionsView.ShowAutoFilterRow = True
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fechadespacho"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 0
        '
        'colFechasolicitud
        '
        Me.colFechasolicitud.Caption = "Fecha Solicitud"
        Me.colFechasolicitud.FieldName = "Fechasolicitud"
        Me.colFechasolicitud.Name = "colFechasolicitud"
        Me.colFechasolicitud.OptionsColumn.AllowEdit = False
        Me.colFechasolicitud.Visible = True
        Me.colFechasolicitud.VisibleIndex = 1
        '
        'colSivTransferenciaID
        '
        Me.colSivTransferenciaID.Caption = "Número Transferencia"
        Me.colSivTransferenciaID.FieldName = "SivTransferenciaID"
        Me.colSivTransferenciaID.Name = "colSivTransferenciaID"
        Me.colSivTransferenciaID.OptionsColumn.AllowEdit = False
        Me.colSivTransferenciaID.Visible = True
        Me.colSivTransferenciaID.VisibleIndex = 2
        '
        'colSitioOrigen
        '
        Me.colSitioOrigen.Caption = "Bodega Origen"
        Me.colSitioOrigen.FieldName = "SitioOrigen"
        Me.colSitioOrigen.Name = "colSitioOrigen"
        Me.colSitioOrigen.OptionsColumn.AllowEdit = False
        Me.colSitioOrigen.Visible = True
        Me.colSitioOrigen.VisibleIndex = 3
        '
        'colSitioDestino
        '
        Me.colSitioDestino.Caption = "Bodega Destino"
        Me.colSitioDestino.FieldName = "SitioDestino"
        Me.colSitioDestino.Name = "colSitioDestino"
        Me.colSitioDestino.OptionsColumn.AllowEdit = False
        Me.colSitioDestino.Visible = True
        Me.colSitioDestino.VisibleIndex = 4
        '
        'colSolicitadoPor
        '
        Me.colSolicitadoPor.Caption = "Solicitado Por"
        Me.colSolicitadoPor.FieldName = "SolicitadoPor"
        Me.colSolicitadoPor.Name = "colSolicitadoPor"
        Me.colSolicitadoPor.OptionsColumn.AllowEdit = False
        Me.colSolicitadoPor.Visible = True
        Me.colSolicitadoPor.VisibleIndex = 5
        '
        'colDespachadoPor
        '
        Me.colDespachadoPor.Caption = "Despachado por"
        Me.colDespachadoPor.FieldName = "DespachadoPor"
        Me.colDespachadoPor.Name = "colDespachadoPor"
        Me.colDespachadoPor.OptionsColumn.AllowEdit = False
        Me.colDespachadoPor.Visible = True
        Me.colDespachadoPor.VisibleIndex = 6
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 7
        '
        'colObjEstadoID
        '
        Me.colObjEstadoID.Caption = "ObjEstadoID"
        Me.colObjEstadoID.FieldName = "ObjEstadoID"
        Me.colObjEstadoID.Name = "colObjEstadoID"
        Me.colObjEstadoID.OptionsColumn.AllowEdit = False
        '
        'colObjBodegaDestinoID
        '
        Me.colObjBodegaDestinoID.Caption = "ObjBodegaDestinoID"
        Me.colObjBodegaDestinoID.FieldName = "ObjBodegaDestinoID"
        Me.colObjBodegaDestinoID.Name = "colObjBodegaDestinoID"
        Me.colObjBodegaDestinoID.OptionsColumn.AllowEdit = False
        '
        'colObjBodegaOrigenID
        '
        Me.colObjBodegaOrigenID.Caption = "ObjBodegaOrigenID"
        Me.colObjBodegaOrigenID.FieldName = "ObjBodegaOrigenID"
        Me.colObjBodegaOrigenID.Name = "colObjBodegaOrigenID"
        Me.colObjBodegaOrigenID.OptionsColumn.AllowEdit = False
        '
        'frmSivDespTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 537)
        Me.Controls.Add(Me.grdTrasnferencias)
        Me.Controls.Add(Me.toolDespachosTranf)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSivDespTransferencia"
        Me.Text = "Despacho de transferencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolDespachosTranf.ResumeLayout(False)
        Me.toolDespachosTranf.PerformLayout()
        CType(Me.grdTrasnferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTransferenciasTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolDespachosTranf As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnularSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultarSolicitud As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDespachar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdImprimirSeleccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdImprimirFiltro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdTrasnferencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdTransferenciasTablas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechasolicitud As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSivTransferenciaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSitioOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSitioDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSolicitadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDespachadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObjEstadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObjBodegaDestinoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObjBodegaOrigenID As DevExpress.XtraGrid.Columns.GridColumn
End Class
