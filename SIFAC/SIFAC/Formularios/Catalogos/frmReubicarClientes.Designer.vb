<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReubicarClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReubicarClientes))
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmdReubicar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdClientes = New DevExpress.XtraGrid.GridControl()
        Me.grdClientesTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCedula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.grdDetalleVentas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbProductos.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClientesTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdReubicar, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(788, 39)
        Me.tbProductos.TabIndex = 11
        '
        'cmdReubicar
        '
        Me.cmdReubicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdReubicar.Image = CType(resources.GetObject("cmdReubicar.Image"), System.Drawing.Image)
        Me.cmdReubicar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdReubicar.Name = "cmdReubicar"
        Me.cmdReubicar.Size = New System.Drawing.Size(36, 36)
        Me.cmdReubicar.Tag = "Cambiar Ruta"
        Me.cmdReubicar.Text = "Cambiar Ruta"
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
        Me.cmdCerrar.ToolTipText = "Salir de reubicar clientes"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtRuta)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 39)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(788, 62)
        Me.PanelControl2.TabIndex = 12
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Location = New System.Drawing.Point(75, 17)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(279, 20)
        Me.txtRuta.TabIndex = 138
        Me.txtRuta.TabStop = False
        Me.txtRuta.Tag = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 128
        Me.Label1.Tag = ""
        Me.Label1.Text = "Ruta:"
        '
        'grdClientes
        '
        Me.grdClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClientes.Location = New System.Drawing.Point(0, 101)
        Me.grdClientes.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdClientes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdClientes.MainView = Me.grdClientesTable
        Me.grdClientes.Name = "grdClientes"
        Me.grdClientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1})
        Me.grdClientes.Size = New System.Drawing.Size(788, 305)
        Me.grdClientes.TabIndex = 13
        Me.grdClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdClientesTable, Me.grdDetalleVentas})
        '
        'grdClientesTable
        '
        Me.grdClientesTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeleccionar, Me.colCedula, Me.ColCliente})
        Me.grdClientesTable.GridControl = Me.grdClientes
        Me.grdClientesTable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdClientesTable.Name = "grdClientesTable"
        Me.grdClientesTable.OptionsView.ShowAutoFilterRow = True
        '
        'colSeleccionar
        '
        Me.colSeleccionar.Caption = "Seleccionar"
        Me.colSeleccionar.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSeleccionar.FieldName = "Seleccionar"
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Visible = True
        Me.colSeleccionar.VisibleIndex = 0
        Me.colSeleccionar.Width = 151
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colCedula
        '
        Me.colCedula.Caption = "No. Cédula"
        Me.colCedula.FieldName = "Cedula"
        Me.colCedula.Name = "colCedula"
        Me.colCedula.OptionsColumn.AllowFocus = False
        Me.colCedula.OptionsColumn.ReadOnly = True
        Me.colCedula.Visible = True
        Me.colCedula.VisibleIndex = 1
        Me.colCedula.Width = 247
        '
        'ColCliente
        '
        Me.ColCliente.Caption = "Cliente"
        Me.ColCliente.FieldName = "Cliente"
        Me.ColCliente.Name = "ColCliente"
        Me.ColCliente.Visible = True
        Me.ColCliente.VisibleIndex = 2
        Me.ColCliente.Width = 372
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'grdDetalleVentas
        '
        Me.grdDetalleVentas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoria, Me.colMarca, Me.colCodigo, Me.colProducto, Me.colCantidad, Me.colPrecio, Me.colSubtotal, Me.colDescuento, Me.colTotalDetalle})
        Me.grdDetalleVentas.GridControl = Me.grdClientes
        Me.grdDetalleVentas.Name = "grdDetalleVentas"
        Me.grdDetalleVentas.OptionsView.ShowGroupPanel = False
        '
        'colCategoria
        '
        Me.colCategoria.Caption = "Categoria"
        Me.colCategoria.FieldName = "Categoria"
        Me.colCategoria.Name = "colCategoria"
        Me.colCategoria.OptionsColumn.AllowEdit = False
        Me.colCategoria.Visible = True
        Me.colCategoria.VisibleIndex = 0
        '
        'colMarca
        '
        Me.colMarca.Caption = "Marca"
        Me.colMarca.FieldName = "Marca"
        Me.colMarca.Name = "colMarca"
        Me.colMarca.OptionsColumn.AllowEdit = False
        Me.colMarca.Visible = True
        Me.colMarca.VisibleIndex = 1
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 2
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.OptionsColumn.AllowEdit = False
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 3
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 4
        '
        'colPrecio
        '
        Me.colPrecio.Caption = "Precio"
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.AllowEdit = False
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 5
        '
        'colSubtotal
        '
        Me.colSubtotal.Caption = "Subtotal"
        Me.colSubtotal.FieldName = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.OptionsColumn.AllowEdit = False
        Me.colSubtotal.Visible = True
        Me.colSubtotal.VisibleIndex = 6
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "Descuento"
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.OptionsColumn.AllowEdit = False
        Me.colDescuento.Visible = True
        Me.colDescuento.VisibleIndex = 7
        '
        'colTotalDetalle
        '
        Me.colTotalDetalle.Caption = "Total"
        Me.colTotalDetalle.FieldName = "Total"
        Me.colTotalDetalle.Name = "colTotalDetalle"
        Me.colTotalDetalle.OptionsColumn.AllowEdit = False
        Me.colTotalDetalle.Visible = True
        Me.colTotalDetalle.VisibleIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 390)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 16)
        Me.Panel1.TabIndex = 27
        '
        'frmReubicarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 406)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdClientes)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.tbProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReubicarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reubicar clientes"
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClientesTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdReubicar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdClientesTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCedula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ColCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdDetalleVentas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
