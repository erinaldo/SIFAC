<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccArquo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccArquo))
        Me.grdArqueo = New DevExpress.XtraGrid.GridControl()
        Me.grdArqueoabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEntradaEfectivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalidaEfectivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFaltante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAprobadoPor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tstND = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAprobar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        CType(Me.grdArqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArqueoabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstND.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdArqueo
        '
        Me.grdArqueo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArqueo.Location = New System.Drawing.Point(0, 39)
        Me.grdArqueo.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdArqueo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdArqueo.MainView = Me.grdArqueoabla
        Me.grdArqueo.Name = "grdArqueo"
        Me.grdArqueo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemCheckEdit2})
        Me.grdArqueo.Size = New System.Drawing.Size(895, 392)
        Me.grdArqueo.TabIndex = 12
        Me.grdArqueo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdArqueoabla})
        '
        'grdArqueoabla
        '
        Me.grdArqueoabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colEntradaEfectivo, Me.colCajero, Me.colSalidaEfectivo, Me.colFaltante, Me.colAprobadoPor})
        Me.grdArqueoabla.GridControl = Me.grdArqueo
        Me.grdArqueoabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdArqueoabla.Name = "grdArqueoabla"
        Me.grdArqueoabla.OptionsView.ShowAutoFilterRow = True
        Me.grdArqueoabla.Tag = ""
        '
        'colNumero
        '
        Me.colNumero.Caption = "ArqueoID"
        Me.colNumero.FieldName = "ArqueoID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 94
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colEntradaEfectivo
        '
        Me.colEntradaEfectivo.Caption = "Ingreso"
        Me.colEntradaEfectivo.FieldName = "EntradaEfectivo"
        Me.colEntradaEfectivo.Name = "colEntradaEfectivo"
        Me.colEntradaEfectivo.OptionsColumn.AllowEdit = False
        Me.colEntradaEfectivo.OptionsColumn.ReadOnly = True
        Me.colEntradaEfectivo.Visible = True
        Me.colEntradaEfectivo.VisibleIndex = 2
        Me.colEntradaEfectivo.Width = 130
        '
        'colCajero
        '
        Me.colCajero.Caption = "Cajero"
        Me.colCajero.FieldName = "Cajero"
        Me.colCajero.Name = "colCajero"
        Me.colCajero.OptionsColumn.AllowEdit = False
        Me.colCajero.Visible = True
        Me.colCajero.VisibleIndex = 1
        Me.colCajero.Width = 194
        '
        'colSalidaEfectivo
        '
        Me.colSalidaEfectivo.Caption = "Egreso"
        Me.colSalidaEfectivo.FieldName = "SalidaEfectivo"
        Me.colSalidaEfectivo.Name = "colSalidaEfectivo"
        Me.colSalidaEfectivo.OptionsColumn.AllowEdit = False
        Me.colSalidaEfectivo.Visible = True
        Me.colSalidaEfectivo.VisibleIndex = 3
        Me.colSalidaEfectivo.Width = 92
        '
        'colFaltante
        '
        Me.colFaltante.Caption = "Faltante"
        Me.colFaltante.FieldName = "Faltante"
        Me.colFaltante.Name = "colFaltante"
        Me.colFaltante.OptionsColumn.AllowEdit = False
        Me.colFaltante.Visible = True
        Me.colFaltante.VisibleIndex = 4
        Me.colFaltante.Width = 115
        '
        'colAprobadoPor
        '
        Me.colAprobadoPor.Caption = "Aprobado Por"
        Me.colAprobadoPor.FieldName = "AprobadoPor"
        Me.colAprobadoPor.Name = "colAprobadoPor"
        Me.colAprobadoPor.OptionsColumn.AllowEdit = False
        Me.colAprobadoPor.Visible = True
        Me.colAprobadoPor.VisibleIndex = 5
        Me.colAprobadoPor.Width = 98
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'tstND
        '
        Me.tstND.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstND.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdAprobar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdImprimir, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.ToolStripSeparator4, Me.cmdSalir})
        Me.tstND.Location = New System.Drawing.Point(0, 0)
        Me.tstND.Name = "tstND"
        Me.tstND.Size = New System.Drawing.Size(895, 39)
        Me.tstND.TabIndex = 11
        Me.tstND.Text = "Nota de Débito"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Enabled = False
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.Text = "Agregar Comision"
        Me.cmdAgregar.ToolTipText = "Agregar Arqueo"
        '
        'cmdAprobar
        '
        Me.cmdAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAprobar.Image = CType(resources.GetObject("cmdAprobar.Image"), System.Drawing.Image)
        Me.cmdAprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAprobar.Text = "Aprobar arqueo"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Enabled = False
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar Comision"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir"
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
        Me.cmdRefrescar.Text = "Refrescar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.Text = "Salir"
        '
        'frmSccArquo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 431)
        Me.Controls.Add(Me.grdArqueo)
        Me.Controls.Add(Me.tstND)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccArquo"
        Me.Text = "Arqueo de caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdArqueo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArqueoabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstND.ResumeLayout(False)
        Me.tstND.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdArqueo As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdArqueoabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colEntradaEfectivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFaltante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents tstND As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents colAprobadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalidaEfectivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
