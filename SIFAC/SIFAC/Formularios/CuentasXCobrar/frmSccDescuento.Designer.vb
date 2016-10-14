<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccDescuento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccDescuento))
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
        Me.grdDescuento = New DevExpress.XtraGrid.GridControl()
        Me.grdDescuentoTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSccDescuentoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlazoPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescuentoMaximo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescuentoMinimo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbProductos.SuspendLayout()
        CType(Me.grdDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDescuentoTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdDesactivar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdImprimir, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(623, 39)
        Me.tbProductos.TabIndex = 2
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Nuevo Producto"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Producto"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Producto"
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
        Me.cmdDesactivar.ToolTipText = "Inactivar Producto"
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
        Me.cmdImprimir.ToolTipText = "Imprimir Datos de Productos"
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
        Me.cmdCerrar.ToolTipText = "Salir de Catálogo de Productos"
        '
        'grdDescuento
        '
        Me.grdDescuento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDescuento.Location = New System.Drawing.Point(0, 39)
        Me.grdDescuento.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.grdDescuento.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdDescuento.MainView = Me.grdDescuentoTabla
        Me.grdDescuento.Name = "grdDescuento"
        Me.grdDescuento.Size = New System.Drawing.Size(623, 270)
        Me.grdDescuento.TabIndex = 3
        Me.grdDescuento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDescuentoTabla})
        '
        'grdDescuentoTabla
        '
        Me.grdDescuentoTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPlazoPago, Me.colSccDescuentoID, Me.colDescuentoMaximo, Me.colDescuentoMinimo})
        Me.grdDescuentoTabla.GridControl = Me.grdDescuento
        Me.grdDescuentoTabla.Name = "grdDescuentoTabla"
        '
        'colSccDescuentoID
        '
        Me.colSccDescuentoID.Caption = "SccDescuentoID"
        Me.colSccDescuentoID.FieldName = "SccDescuentoID"
        Me.colSccDescuentoID.Name = "colSccDescuentoID"
        '
        'colPlazoPago
        '
        Me.colPlazoPago.Caption = "Plazo de Pago"
        Me.colPlazoPago.FieldName = "PlazoPago"
        Me.colPlazoPago.Name = "colPlazoPago"
        Me.colPlazoPago.OptionsColumn.AllowEdit = False
        Me.colPlazoPago.Visible = True
        Me.colPlazoPago.VisibleIndex = 0
        '
        'colDescuentoMaximo
        '
        Me.colDescuentoMaximo.Caption = "Descuento Maximo"
        Me.colDescuentoMaximo.FieldName = "DescuentoMaximo"
        Me.colDescuentoMaximo.Name = "colDescuentoMaximo"
        Me.colDescuentoMaximo.OptionsColumn.AllowEdit = False
        Me.colDescuentoMaximo.Visible = True
        Me.colDescuentoMaximo.VisibleIndex = 1
        '
        'colDescuentoMinimo
        '
        Me.colDescuentoMinimo.Caption = "Descuento Minimo"
        Me.colDescuentoMinimo.FieldName = "DescuentoMinimo"
        Me.colDescuentoMinimo.Name = "colDescuentoMinimo"
        Me.colDescuentoMinimo.OptionsColumn.AllowEdit = False
        Me.colDescuentoMinimo.Visible = True
        Me.colDescuentoMinimo.VisibleIndex = 2
        '
        'frmSccDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 309)
        Me.Controls.Add(Me.grdDescuento)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccDescuento"
        Me.Text = "Descuento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.grdDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDescuentoTabla, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grdDescuento As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDescuentoTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPlazoPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSccDescuentoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuentoMaximo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuentoMinimo As DevExpress.XtraGrid.Columns.GridColumn
End Class
