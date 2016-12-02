<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbRutas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbRutas))
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDesactivar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.grdRutas = New DevExpress.XtraGrid.GridControl()
        Me.grdRutasTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreSupervisor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreRuta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCargarDiferenciada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCobrador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCiudad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbProductos.SuspendLayout()
        CType(Me.grdRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRutasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdDesactivar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdImprimir, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(997, 39)
        Me.tbProductos.TabIndex = 1
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
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.ToolTipText = "Imprimir Datos de las rutas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
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
        Me.grdRutas.Size = New System.Drawing.Size(997, 383)
        Me.grdRutas.TabIndex = 8
        Me.grdRutas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdRutasTabla})
        '
        'grdRutasTabla
        '
        Me.grdRutasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colNombreSupervisor, Me.colNombreRuta, Me.colCargarDiferenciada, Me.colCodigo, Me.colDescripcion, Me.colCobrador, Me.colCiudad})
        Me.grdRutasTabla.GridControl = Me.grdRutas
        Me.grdRutasTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdRutasTabla.Name = "grdRutasTabla"
        Me.grdRutasTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdRutasTabla.Tag = ""
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "StbRutaID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        '
        'colNombreSupervisor
        '
        Me.colNombreSupervisor.Caption = "Supervisor"
        Me.colNombreSupervisor.FieldName = "Supervisor"
        Me.colNombreSupervisor.Name = "colNombreSupervisor"
        Me.colNombreSupervisor.OptionsColumn.AllowEdit = False
        Me.colNombreSupervisor.Visible = True
        Me.colNombreSupervisor.VisibleIndex = 0
        Me.colNombreSupervisor.Width = 145
        '
        'colNombreRuta
        '
        Me.colNombreRuta.Caption = "Ruta"
        Me.colNombreRuta.FieldName = "Nombre"
        Me.colNombreRuta.Name = "colNombreRuta"
        Me.colNombreRuta.OptionsColumn.AllowEdit = False
        Me.colNombreRuta.OptionsColumn.ReadOnly = True
        Me.colNombreRuta.Visible = True
        Me.colNombreRuta.VisibleIndex = 2
        Me.colNombreRuta.Width = 130
        '
        'colCargarDiferenciada
        '
        Me.colCargarDiferenciada.Caption = "Cargar diferenciada"
        Me.colCargarDiferenciada.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colCargarDiferenciada.FieldName = "CargarDiferenciada"
        Me.colCargarDiferenciada.Name = "colCargarDiferenciada"
        Me.colCargarDiferenciada.OptionsColumn.AllowEdit = False
        Me.colCargarDiferenciada.OptionsColumn.ReadOnly = True
        Me.colCargarDiferenciada.Visible = True
        Me.colCargarDiferenciada.VisibleIndex = 6
        Me.colCargarDiferenciada.Width = 158
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código Ruta"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 110
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 3
        Me.colDescripcion.Width = 198
        '
        'colCobrador
        '
        Me.colCobrador.Caption = "Cobrador"
        Me.colCobrador.FieldName = "Cobrador"
        Me.colCobrador.Name = "colCobrador"
        Me.colCobrador.OptionsColumn.AllowEdit = False
        Me.colCobrador.Visible = True
        Me.colCobrador.VisibleIndex = 4
        Me.colCobrador.Width = 139
        '
        'colCiudad
        '
        Me.colCiudad.Caption = "Ciudad"
        Me.colCiudad.FieldName = "Ciudad"
        Me.colCiudad.Name = "colCiudad"
        Me.colCiudad.OptionsColumn.AllowEdit = False
        Me.colCiudad.Visible = True
        Me.colCiudad.VisibleIndex = 5
        Me.colCiudad.Width = 99
        '
        'frmStbRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 422)
        Me.Controls.Add(Me.grdRutas)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStbRutas"
        Me.Text = "Rutas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdRutas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdRutasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreSupervisor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreRuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCargarDiferenciada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCobrador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiudad As DevExpress.XtraGrid.Columns.GridColumn
End Class
