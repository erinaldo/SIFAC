<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSrhEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSrhEmpleado))
        Me.tbEmpleados = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.grdvwEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.grdvwEmpleadosTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSrhEmpleadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjPersonaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApellido1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApellido2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCargo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tbEmpleados.SuspendLayout()
        CType(Me.grdvwEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwEmpleadosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbEmpleados
        '
        Me.tbEmpleados.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbEmpleados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdRefrescar, Me.ToolStripSeparator2, Me.cmdSalir})
        Me.tbEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.tbEmpleados.Name = "tbEmpleados"
        Me.tbEmpleados.Size = New System.Drawing.Size(726, 39)
        Me.tbEmpleados.TabIndex = 0
        Me.tbEmpleados.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Agregar Empleado"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar Empleado"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Empleado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir de Mantenimiento de Empleados"
        '
        'grdvwEmpleados
        '
        Me.grdvwEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdvwEmpleados.Location = New System.Drawing.Point(0, 39)
        Me.grdvwEmpleados.MainView = Me.grdvwEmpleadosTabla
        Me.grdvwEmpleados.Name = "grdvwEmpleados"
        Me.grdvwEmpleados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdvwEmpleados.Size = New System.Drawing.Size(726, 344)
        Me.grdvwEmpleados.TabIndex = 2
        Me.grdvwEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwEmpleadosTabla})
        '
        'grdvwEmpleadosTabla
        '
        Me.grdvwEmpleadosTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSrhEmpleadoID, Me.colobjPersonaID, Me.colNombre1, Me.colNombre2, Me.colApellido1, Me.colApellido2, Me.colGenero, Me.colCargo, Me.colActivo})
        Me.grdvwEmpleadosTabla.GridControl = Me.grdvwEmpleados
        Me.grdvwEmpleadosTabla.Name = "grdvwEmpleadosTabla"
        Me.grdvwEmpleadosTabla.OptionsBehavior.Editable = False
        Me.grdvwEmpleadosTabla.OptionsView.ShowFooter = True
        '
        'colSrhEmpleadoID
        '
        Me.colSrhEmpleadoID.Caption = "SrhEmpleadoID"
        Me.colSrhEmpleadoID.FieldName = "SrhEmpleadoID"
        Me.colSrhEmpleadoID.Name = "colSrhEmpleadoID"
        '
        'colobjPersonaID
        '
        Me.colobjPersonaID.Caption = "objPersonaID"
        Me.colobjPersonaID.FieldName = "objPersonaID"
        Me.colobjPersonaID.Name = "colobjPersonaID"
        '
        'colNombre1
        '
        Me.colNombre1.Caption = "Primer Nombre"
        Me.colNombre1.FieldName = "Nombre1"
        Me.colNombre1.Name = "colNombre1"
        Me.colNombre1.Visible = True
        Me.colNombre1.VisibleIndex = 0
        '
        'colNombre2
        '
        Me.colNombre2.Caption = "Segundo Nombre"
        Me.colNombre2.FieldName = "Nombre2"
        Me.colNombre2.Name = "colNombre2"
        Me.colNombre2.Visible = True
        Me.colNombre2.VisibleIndex = 1
        '
        'colApellido1
        '
        Me.colApellido1.Caption = "Primer Apellido"
        Me.colApellido1.FieldName = "Apellido1"
        Me.colApellido1.Name = "colApellido1"
        Me.colApellido1.Visible = True
        Me.colApellido1.VisibleIndex = 2
        '
        'colApellido2
        '
        Me.colApellido2.Caption = "Segundo Apellido"
        Me.colApellido2.FieldName = "Apellido2"
        Me.colApellido2.Name = "colApellido2"
        Me.colApellido2.Visible = True
        Me.colApellido2.VisibleIndex = 3
        '
        'colGenero
        '
        Me.colGenero.Caption = "Género"
        Me.colGenero.FieldName = "Genero"
        Me.colGenero.Name = "colGenero"
        Me.colGenero.Visible = True
        Me.colGenero.VisibleIndex = 4
        '
        'colCargo
        '
        Me.colCargo.Caption = "Cargo"
        Me.colCargo.FieldName = "Cargo"
        Me.colCargo.Name = "colCargo"
        Me.colCargo.Visible = True
        Me.colCargo.VisibleIndex = 5
        '
        'colActivo
        '
        Me.colActivo.Caption = "Activo"
        Me.colActivo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActivo.FieldName = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 6
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSrhEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 383)
        Me.Controls.Add(Me.grdvwEmpleados)
        Me.Controls.Add(Me.tbEmpleados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSrhEmpleado"
        Me.Text = "Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbEmpleados.ResumeLayout(False)
        Me.tbEmpleados.PerformLayout()
        CType(Me.grdvwEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwEmpleadosTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbEmpleados As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdvwEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwEmpleadosTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSrhEmpleadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjPersonaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApellido1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApellido2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
