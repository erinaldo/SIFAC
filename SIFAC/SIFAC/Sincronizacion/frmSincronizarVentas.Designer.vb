﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSincronizarVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSincronizarVentas))
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmdAprobar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDesactivar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbEstado = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.cmdActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbRuta = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblModeloCompatible = New System.Windows.Forms.Label()
        Me.grdVentas = New DevExpress.XtraGrid.GridControl()
        Me.grdVentasTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colfecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colRuta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSincronizado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tbProductos.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cmbEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdVentasTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAprobar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdDesactivar, Me.ToolStripSeparator2, Me.cmbExportar, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(837, 39)
        Me.tbProductos.TabIndex = 10
        '
        'cmdAprobar
        '
        Me.cmdAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAprobar.Image = CType(resources.GetObject("cmdAprobar.Image"), System.Drawing.Image)
        Me.cmdAprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAprobar.Text = "Aprobar"
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
        'cmbExportar
        '
        Me.cmbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbExportar.Image = CType(resources.GetObject("cmbExportar.Image"), System.Drawing.Image)
        Me.cmbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExportar.Name = "cmbExportar"
        Me.cmbExportar.Size = New System.Drawing.Size(36, 36)
        Me.cmbExportar.Text = "Exportar"
        Me.cmbExportar.ToolTipText = "Exportar a excel"
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdVentas)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(837, 439)
        Me.PanelControl1.TabIndex = 11
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cmbEstado)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.chkTodos)
        Me.PanelControl2.Controls.Add(Me.cmdActualizar)
        Me.PanelControl2.Controls.Add(Me.cmbRuta)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.cmbEmpleado)
        Me.PanelControl2.Controls.Add(Me.lblModeloCompatible)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(833, 142)
        Me.PanelControl2.TabIndex = 0
        '
        'cmbEstado
        '
        Me.cmbEstado.Location = New System.Drawing.Point(127, 109)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEstado.Properties.NullText = ""
        Me.cmbEstado.Size = New System.Drawing.Size(166, 20)
        Me.cmbEstado.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Tag = ""
        Me.Label3.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(541, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 18)
        Me.Label2.TabIndex = 132
        Me.Label2.Tag = ""
        Me.Label2.Text = "Carga inicialmente las ventas sincronizadas el dia actual."
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos.Location = New System.Drawing.Point(321, 111)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(84, 17)
        Me.chkTodos.TabIndex = 131
        Me.chkTodos.Text = "Ver Todas"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdActualizar.Location = New System.Drawing.Point(321, 71)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(32, 23)
        Me.cmdActualizar.TabIndex = 130
        '
        'cmbRuta
        '
        Me.cmbRuta.Location = New System.Drawing.Point(127, 54)
        Me.cmbRuta.Name = "cmbRuta"
        Me.cmbRuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRuta.Properties.NullText = ""
        Me.cmbRuta.Size = New System.Drawing.Size(166, 20)
        Me.cmbRuta.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 128
        Me.Label1.Tag = ""
        Me.Label1.Text = "Ruta:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.Location = New System.Drawing.Point(127, 83)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEmpleado.Properties.NullText = ""
        Me.cmbEmpleado.Size = New System.Drawing.Size(166, 20)
        Me.cmbEmpleado.TabIndex = 126
        '
        'lblModeloCompatible
        '
        Me.lblModeloCompatible.BackColor = System.Drawing.Color.Transparent
        Me.lblModeloCompatible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloCompatible.Location = New System.Drawing.Point(6, 84)
        Me.lblModeloCompatible.Name = "lblModeloCompatible"
        Me.lblModeloCompatible.Size = New System.Drawing.Size(103, 18)
        Me.lblModeloCompatible.TabIndex = 125
        Me.lblModeloCompatible.Tag = ""
        Me.lblModeloCompatible.Text = "Empleado:"
        '
        'grdVentas
        '
        Me.grdVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdVentas.Location = New System.Drawing.Point(2, 144)
        Me.grdVentas.MainView = Me.grdVentasTable
        Me.grdVentas.Name = "grdVentas"
        Me.grdVentas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemDateEdit1})
        Me.grdVentas.Size = New System.Drawing.Size(833, 293)
        Me.grdVentas.TabIndex = 6
        Me.grdVentas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdVentasTable})
        '
        'grdVentasTable
        '
        Me.grdVentasTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeleccionar, Me.colfecha, Me.colRuta, Me.ColCliente, Me.colEmpleado, Me.colTotal, Me.colobservaciones, Me.colSincronizado})
        Me.grdVentasTable.GridControl = Me.grdVentas
        Me.grdVentasTable.Name = "grdVentasTable"
        '
        'colSeleccionar
        '
        Me.colSeleccionar.Caption = "Seleccionar"
        Me.colSeleccionar.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Visible = True
        Me.colSeleccionar.VisibleIndex = 0
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'colfecha
        '
        Me.colfecha.Caption = "Fecha"
        Me.colfecha.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colfecha.FieldName = "fecha"
        Me.colfecha.Name = "colfecha"
        Me.colfecha.OptionsColumn.AllowFocus = False
        Me.colfecha.OptionsColumn.ReadOnly = True
        Me.colfecha.Visible = True
        Me.colfecha.VisibleIndex = 1
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colRuta
        '
        Me.colRuta.Caption = "Ruta"
        Me.colRuta.FieldName = "Ruta"
        Me.colRuta.Name = "colRuta"
        Me.colRuta.OptionsColumn.AllowFocus = False
        Me.colRuta.OptionsColumn.ReadOnly = True
        Me.colRuta.Visible = True
        Me.colRuta.VisibleIndex = 3
        '
        'ColCliente
        '
        Me.ColCliente.Caption = "Cliente"
        Me.ColCliente.FieldName = "Cliente"
        Me.ColCliente.Name = "ColCliente"
        Me.ColCliente.Visible = True
        Me.ColCliente.VisibleIndex = 2
        '
        'colEmpleado
        '
        Me.colEmpleado.Caption = "Empleado"
        Me.colEmpleado.FieldName = "Empleado"
        Me.colEmpleado.Name = "colEmpleado"
        Me.colEmpleado.OptionsColumn.AllowFocus = False
        Me.colEmpleado.OptionsColumn.ReadOnly = True
        Me.colEmpleado.Visible = True
        Me.colEmpleado.VisibleIndex = 4
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 5
        '
        'colobservaciones
        '
        Me.colobservaciones.Caption = "Observaciones"
        Me.colobservaciones.FieldName = "observaciones"
        Me.colobservaciones.Name = "colobservaciones"
        Me.colobservaciones.OptionsColumn.AllowFocus = False
        Me.colobservaciones.OptionsColumn.ReadOnly = True
        Me.colobservaciones.Visible = True
        Me.colobservaciones.VisibleIndex = 6
        '
        'colSincronizado
        '
        Me.colSincronizado.Caption = "Sincronizado"
        Me.colSincronizado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSincronizado.FieldName = "Sincronizado"
        Me.colSincronizado.Name = "colSincronizado"
        Me.colSincronizado.Visible = True
        Me.colSincronizado.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSincronizarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 439)
        Me.Controls.Add(Me.tbProductos)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSincronizarVentas"
        Me.Text = "Sincronizar Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cmbEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdVentasTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDesactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmbEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblModeloCompatible As System.Windows.Forms.Label
    Friend WithEvents cmbRuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grdVentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdVentasTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colfecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colRuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSincronizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
