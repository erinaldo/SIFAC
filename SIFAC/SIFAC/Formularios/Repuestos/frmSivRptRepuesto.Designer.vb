<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivRptRepuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivRptRepuesto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbMarca = New C1.Win.C1List.C1Combo
        Me.cmbTipoRepuesto = New C1.Win.C1List.C1Combo
        Me.cmbProveedor = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbTodos = New System.Windows.Forms.RadioButton
        Me.rbInactivos = New System.Windows.Forms.RadioButton
        Me.rbActivos = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkImagen = New System.Windows.Forms.CheckBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMarca)
        Me.GroupBox1.Controls.Add(Me.cmbTipoRepuesto)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio"
        '
        'cmbMarca
        '
        Me.cmbMarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMarca.Caption = ""
        Me.cmbMarca.CaptionHeight = 17
        Me.cmbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMarca.ColumnCaptionHeight = 17
        Me.cmbMarca.ColumnFooterHeight = 17
        Me.cmbMarca.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMarca.ContentHeight = 15
        Me.cmbMarca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMarca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMarca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMarca.EditorHeight = 15
        Me.cmbMarca.Images.Add(CType(resources.GetObject("cmbMarca.Images"), System.Drawing.Image))
        Me.cmbMarca.ItemHeight = 15
        Me.cmbMarca.Location = New System.Drawing.Point(96, 74)
        Me.cmbMarca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMarca.MaxDropDownItems = CType(5, Short)
        Me.cmbMarca.MaxLength = 32767
        Me.cmbMarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMarca.Size = New System.Drawing.Size(181, 21)
        Me.cmbMarca.TabIndex = 5
        Me.cmbMarca.PropBag = resources.GetString("cmbMarca.PropBag")
        '
        'cmbTipoRepuesto
        '
        Me.cmbTipoRepuesto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoRepuesto.Caption = ""
        Me.cmbTipoRepuesto.CaptionHeight = 17
        Me.cmbTipoRepuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoRepuesto.ColumnCaptionHeight = 17
        Me.cmbTipoRepuesto.ColumnFooterHeight = 17
        Me.cmbTipoRepuesto.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoRepuesto.ContentHeight = 15
        Me.cmbTipoRepuesto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoRepuesto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoRepuesto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoRepuesto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoRepuesto.EditorHeight = 15
        Me.cmbTipoRepuesto.Images.Add(CType(resources.GetObject("cmbTipoRepuesto.Images"), System.Drawing.Image))
        Me.cmbTipoRepuesto.ItemHeight = 15
        Me.cmbTipoRepuesto.Location = New System.Drawing.Point(96, 48)
        Me.cmbTipoRepuesto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoRepuesto.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoRepuesto.MaxLength = 32767
        Me.cmbTipoRepuesto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoRepuesto.Name = "cmbTipoRepuesto"
        Me.cmbTipoRepuesto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoRepuesto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoRepuesto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoRepuesto.Size = New System.Drawing.Size(181, 21)
        Me.cmbTipoRepuesto.TabIndex = 4
        Me.cmbTipoRepuesto.PropBag = resources.GetString("cmbTipoRepuesto.PropBag")
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProveedor.Caption = ""
        Me.cmbProveedor.CaptionHeight = 17
        Me.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProveedor.ColumnCaptionHeight = 17
        Me.cmbProveedor.ColumnFooterHeight = 17
        Me.cmbProveedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbProveedor.ContentHeight = 15
        Me.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProveedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProveedor.EditorHeight = 15
        Me.cmbProveedor.Images.Add(CType(resources.GetObject("cmbProveedor.Images"), System.Drawing.Image))
        Me.cmbProveedor.ItemHeight = 15
        Me.cmbProveedor.Location = New System.Drawing.Point(96, 20)
        Me.cmbProveedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProveedor.MaxDropDownItems = CType(5, Short)
        Me.cmbProveedor.MaxLength = 32767
        Me.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedor.Size = New System.Drawing.Size(181, 21)
        Me.cmbProveedor.TabIndex = 3
        Me.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Marca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipo Repuesto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Proveedor:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbInactivos)
        Me.GroupBox2.Controls.Add(Me.rbActivos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 66)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(222, 28)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 2
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbInactivos
        '
        Me.rbInactivos.AutoSize = True
        Me.rbInactivos.Location = New System.Drawing.Point(121, 28)
        Me.rbInactivos.Name = "rbInactivos"
        Me.rbInactivos.Size = New System.Drawing.Size(68, 17)
        Me.rbInactivos.TabIndex = 1
        Me.rbInactivos.TabStop = True
        Me.rbInactivos.Text = "Inactivos"
        Me.rbInactivos.UseVisualStyleBackColor = True
        '
        'rbActivos
        '
        Me.rbActivos.AutoSize = True
        Me.rbActivos.Location = New System.Drawing.Point(26, 28)
        Me.rbActivos.Name = "rbActivos"
        Me.rbActivos.Size = New System.Drawing.Size(60, 17)
        Me.rbActivos.TabIndex = 0
        Me.rbActivos.TabStop = True
        Me.rbActivos.Text = "Activos"
        Me.rbActivos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione criterios para su reporte:"
        '
        'chkImagen
        '
        Me.chkImagen.AutoSize = True
        Me.chkImagen.Location = New System.Drawing.Point(12, 264)
        Me.chkImagen.Name = "chkImagen"
        Me.chkImagen.Size = New System.Drawing.Size(96, 17)
        Me.chkImagen.TabIndex = 3
        Me.chkImagen.Text = "Mostar Imagen"
        Me.chkImagen.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(161, 264)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(242, 264)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 29)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmSivRptRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 300)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.chkImagen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivRptRepuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Listado de Repuestos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbProveedor As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMarca As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoRepuesto As C1.Win.C1List.C1Combo
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbInactivos As System.Windows.Forms.RadioButton
    Friend WithEvents rbActivos As System.Windows.Forms.RadioButton
    Friend WithEvents chkImagen As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
