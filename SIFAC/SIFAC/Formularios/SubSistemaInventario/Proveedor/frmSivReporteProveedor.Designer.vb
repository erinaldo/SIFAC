<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivReporteProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivReporteProveedor))
        Me.gbCriterios = New System.Windows.Forms.GroupBox
        Me.cmbProveedor = New C1.Win.C1List.C1Combo
        Me.rbInactivos = New System.Windows.Forms.RadioButton
        Me.rbActivos = New System.Windows.Forms.RadioButton
        Me.rbTodos = New System.Windows.Forms.RadioButton
        Me.rbProveedor = New System.Windows.Forms.RadioButton
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.gbCriterios.SuspendLayout()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCriterios
        '
        Me.gbCriterios.Controls.Add(Me.cmbProveedor)
        Me.gbCriterios.Controls.Add(Me.rbInactivos)
        Me.gbCriterios.Controls.Add(Me.rbActivos)
        Me.gbCriterios.Controls.Add(Me.rbTodos)
        Me.gbCriterios.Controls.Add(Me.rbProveedor)
        Me.gbCriterios.Location = New System.Drawing.Point(12, 12)
        Me.gbCriterios.Name = "gbCriterios"
        Me.gbCriterios.Size = New System.Drawing.Size(328, 129)
        Me.gbCriterios.TabIndex = 0
        Me.gbCriterios.TabStop = False
        Me.gbCriterios.Text = "Criterios"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProveedor.AllowColMove = False
        Me.cmbProveedor.AllowSort = False
        Me.cmbProveedor.Caption = ""
        Me.cmbProveedor.CaptionHeight = 17
        Me.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProveedor.ColumnCaptionHeight = 17
        Me.cmbProveedor.ColumnFooterHeight = 17
        Me.cmbProveedor.ColumnHeaders = False
        Me.cmbProveedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbProveedor.ContentHeight = 15
        Me.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProveedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProveedor.EditorHeight = 15
        Me.cmbProveedor.Images.Add(CType(resources.GetObject("cmbProveedor.Images"), System.Drawing.Image))
        Me.cmbProveedor.ItemHeight = 15
        Me.cmbProveedor.Location = New System.Drawing.Point(106, 28)
        Me.cmbProveedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProveedor.MaxDropDownItems = CType(5, Short)
        Me.cmbProveedor.MaxLength = 32767
        Me.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedor.Size = New System.Drawing.Size(206, 21)
        Me.cmbProveedor.TabIndex = 4
        Me.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag")
        '
        'rbInactivos
        '
        Me.rbInactivos.AutoSize = True
        Me.rbInactivos.Location = New System.Drawing.Point(16, 97)
        Me.rbInactivos.Name = "rbInactivos"
        Me.rbInactivos.Size = New System.Drawing.Size(68, 17)
        Me.rbInactivos.TabIndex = 3
        Me.rbInactivos.Text = "Inactivos"
        Me.rbInactivos.UseVisualStyleBackColor = True
        '
        'rbActivos
        '
        Me.rbActivos.AutoSize = True
        Me.rbActivos.Location = New System.Drawing.Point(16, 74)
        Me.rbActivos.Name = "rbActivos"
        Me.rbActivos.Size = New System.Drawing.Size(60, 17)
        Me.rbActivos.TabIndex = 2
        Me.rbActivos.Text = "Activos"
        Me.rbActivos.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(16, 51)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 1
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Checked = True
        Me.rbProveedor.Location = New System.Drawing.Point(16, 28)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(74, 17)
        Me.rbProveedor.TabIndex = 0
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(184, 147)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(265, 147)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmSivReporteProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 180)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gbCriterios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivReporteProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Reporte de Proveedores"
        Me.gbCriterios.ResumeLayout(False)
        Me.gbCriterios.PerformLayout()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbInactivos As System.Windows.Forms.RadioButton
    Friend WithEvents rbActivos As System.Windows.Forms.RadioButton
    Friend WithEvents cmbProveedor As C1.Win.C1List.C1Combo
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
