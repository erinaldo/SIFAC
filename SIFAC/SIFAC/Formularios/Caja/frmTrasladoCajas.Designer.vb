<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrasladoCajas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrasladoCajas))
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDesactivar = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.grdRutas = New DevExpress.XtraGrid.GridControl()
        Me.grdRutasTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSfaTranferenciaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajaOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajaDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCajeroOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajeroDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAprobada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutorizadoPor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaAprobacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcomentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAprobar = New System.Windows.Forms.ToolStripButton()
        Me.tbProductos.SuspendLayout()
        CType(Me.grdRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRutasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdAprobar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdDesactivar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(998, 39)
        Me.tbProductos.TabIndex = 2
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Nueva Ruta"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Ruta"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Ruta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdDesactivar
        '
        Me.cmdDesactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDesactivar.Image = CType(resources.GetObject("cmdDesactivar.Image"), System.Drawing.Image)
        Me.cmdDesactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDesactivar.Name = "cmdDesactivar"
        Me.cmdDesactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdDesactivar.ToolTipText = "Inactivar Ruta"
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
        'cmdCerrar
        '
        Me.cmdCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(36, 36)
        Me.cmdCerrar.ToolTipText = "Salir de Catálogo de Rutas"
        '
        'grdRutas
        '
        Me.grdRutas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRutas.Location = New System.Drawing.Point(0, 39)
        Me.grdRutas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdRutas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdRutas.MainView = Me.grdRutasTabla
        Me.grdRutas.Name = "grdRutas"
        Me.grdRutas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdRutas.Size = New System.Drawing.Size(998, 398)
        Me.grdRutas.TabIndex = 9
        Me.grdRutas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdRutasTabla})
        '
        'grdRutasTabla
        '
        Me.grdRutasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSfaTranferenciaID, Me.colCajaOrigen, Me.colCajaDestino, Me.colCajeroOrigen, Me.colCajeroDestino, Me.colAprobada, Me.colFechaCreacion, Me.colMonto, Me.colAutorizadoPor, Me.colFechaAprobacion, Me.colcomentarios})
        Me.grdRutasTabla.GridControl = Me.grdRutas
        Me.grdRutasTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdRutasTabla.Name = "grdRutasTabla"
        Me.grdRutasTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdRutasTabla.Tag = ""
        '
        'colSfaTranferenciaID
        '
        Me.colSfaTranferenciaID.Caption = "Numero"
        Me.colSfaTranferenciaID.FieldName = "SfaTranferenciaID"
        Me.colSfaTranferenciaID.Name = "colSfaTranferenciaID"
        Me.colSfaTranferenciaID.OptionsColumn.AllowEdit = False
        Me.colSfaTranferenciaID.OptionsColumn.ReadOnly = True
        '
        'colCajaOrigen
        '
        Me.colCajaOrigen.Caption = "Desde "
        Me.colCajaOrigen.FieldName = "CajaOrigen"
        Me.colCajaOrigen.Name = "colCajaOrigen"
        Me.colCajaOrigen.OptionsColumn.AllowEdit = False
        Me.colCajaOrigen.Visible = True
        Me.colCajaOrigen.VisibleIndex = 0
        Me.colCajaOrigen.Width = 117
        '
        'colCajaDestino
        '
        Me.colCajaDestino.Caption = "Hacia"
        Me.colCajaDestino.FieldName = "CajaDestino"
        Me.colCajaDestino.Name = "colCajaDestino"
        Me.colCajaDestino.OptionsColumn.AllowEdit = False
        Me.colCajaDestino.OptionsColumn.ReadOnly = True
        Me.colCajaDestino.Visible = True
        Me.colCajaDestino.VisibleIndex = 1
        Me.colCajaDestino.Width = 122
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colCajeroOrigen
        '
        Me.colCajeroOrigen.Caption = "Cajero Origen"
        Me.colCajeroOrigen.FieldName = "CajeroOrigen"
        Me.colCajeroOrigen.Name = "colCajeroOrigen"
        Me.colCajeroOrigen.OptionsColumn.AllowEdit = False
        Me.colCajeroOrigen.Visible = True
        Me.colCajeroOrigen.VisibleIndex = 2
        Me.colCajeroOrigen.Width = 132
        '
        'colCajeroDestino
        '
        Me.colCajeroDestino.Caption = "Cajero Destino"
        Me.colCajeroDestino.FieldName = "CajeroDestino"
        Me.colCajeroDestino.Name = "colCajeroDestino"
        Me.colCajeroDestino.OptionsColumn.AllowEdit = False
        Me.colCajeroDestino.Visible = True
        Me.colCajeroDestino.VisibleIndex = 3
        Me.colCajeroDestino.Width = 129
        '
        'colAprobada
        '
        Me.colAprobada.Caption = "Aprobada"
        Me.colAprobada.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colAprobada.FieldName = "Aprobada"
        Me.colAprobada.Name = "colAprobada"
        Me.colAprobada.OptionsColumn.AllowEdit = False
        Me.colAprobada.Visible = True
        Me.colAprobada.VisibleIndex = 6
        Me.colAprobada.Width = 105
        '
        'colFechaCreacion
        '
        Me.colFechaCreacion.Caption = "Fecha registrada"
        Me.colFechaCreacion.FieldName = "FechaCreacion"
        Me.colFechaCreacion.Name = "colFechaCreacion"
        Me.colFechaCreacion.OptionsColumn.AllowEdit = False
        Me.colFechaCreacion.Visible = True
        Me.colFechaCreacion.VisibleIndex = 5
        Me.colFechaCreacion.Width = 89
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.OptionsColumn.AllowEdit = False
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 4
        Me.colMonto.Width = 100
        '
        'colAutorizadoPor
        '
        Me.colAutorizadoPor.Caption = "Autorizado Por"
        Me.colAutorizadoPor.FieldName = "AutorizadoPor"
        Me.colAutorizadoPor.Name = "colAutorizadoPor"
        Me.colAutorizadoPor.OptionsColumn.AllowEdit = False
        Me.colAutorizadoPor.Visible = True
        Me.colAutorizadoPor.VisibleIndex = 7
        Me.colAutorizadoPor.Width = 57
        '
        'colFechaAprobacion
        '
        Me.colFechaAprobacion.Caption = "FechaAprobacion"
        Me.colFechaAprobacion.FieldName = "FechaAprobacion"
        Me.colFechaAprobacion.Name = "colFechaAprobacion"
        Me.colFechaAprobacion.OptionsColumn.AllowEdit = False
        Me.colFechaAprobacion.Visible = True
        Me.colFechaAprobacion.VisibleIndex = 8
        Me.colFechaAprobacion.Width = 57
        '
        'colcomentarios
        '
        Me.colcomentarios.Caption = "Comentarios"
        Me.colcomentarios.FieldName = "comentarios"
        Me.colcomentarios.Name = "colcomentarios"
        Me.colcomentarios.OptionsColumn.AllowEdit = False
        Me.colcomentarios.Visible = True
        Me.colcomentarios.VisibleIndex = 9
        Me.colcomentarios.Width = 72
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAprobar
        '
        Me.cmdAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAprobar.Image = CType(resources.GetObject("cmdAprobar.Image"), System.Drawing.Image)
        Me.cmdAprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAprobar.Text = "Reubicar"
        '
        'frmTrasladoCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 437)
        Me.Controls.Add(Me.grdRutas)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrasladoCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado de efectivo entre cajas"
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.grdRutas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRutasTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDesactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdRutas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdRutasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSfaTranferenciaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajaOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajaDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajeroOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajeroDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAprobada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colFechaCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAutorizadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaAprobacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcomentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
