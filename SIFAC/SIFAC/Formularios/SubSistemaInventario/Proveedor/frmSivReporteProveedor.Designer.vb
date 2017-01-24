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
        Me.gbCriterios = New System.Windows.Forms.GroupBox()
        Me.cmbProveedor = New C1.Win.C1List.C1Combo()
        Me.rbInactivos = New System.Windows.Forms.RadioButton()
        Me.rbActivos = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbCriterios.SuspendLayout()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCriterios
        '
        Me.gbCriterios.Controls.Add(Me.cmbProveedor)
        Me.gbCriterios.Controls.Add(Me.rbInactivos)
        Me.gbCriterios.Controls.Add(Me.rbActivos)
        Me.gbCriterios.Controls.Add(Me.rbTodos)
        Me.gbCriterios.Controls.Add(Me.rbProveedor)
        Me.gbCriterios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCriterios.Location = New System.Drawing.Point(12, 11)
        Me.gbCriterios.Name = "gbCriterios"
        Me.gbCriterios.Size = New System.Drawing.Size(328, 121)
        Me.gbCriterios.TabIndex = 0
        Me.gbCriterios.TabStop = False
        Me.gbCriterios.Text = "Criterios"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProveedor.AutoCompletion = True
        Me.cmbProveedor.AutoDropDown = True
        Me.cmbProveedor.Caption = ""
        Me.cmbProveedor.CaptionHeight = 17
        Me.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProveedor.ColumnCaptionHeight = 17
        Me.cmbProveedor.ColumnFooterHeight = 17
        Me.cmbProveedor.ContentHeight = 15
        Me.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProveedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProveedor.EditorHeight = 15
        Me.cmbProveedor.Images.Add(CType(resources.GetObject("cmbProveedor.Images"), System.Drawing.Image))
        Me.cmbProveedor.ItemHeight = 15
        Me.cmbProveedor.Location = New System.Drawing.Point(115, 28)
        Me.cmbProveedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProveedor.MaxDropDownItems = CType(5, Short)
        Me.cmbProveedor.MaxLength = 32767
        Me.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedor.Size = New System.Drawing.Size(192, 21)
        Me.cmbProveedor.TabIndex = 138
        Me.cmbProveedor.Tag = "OBLIGATORIO"
        Me.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag")
        '
        'rbInactivos
        '
        Me.rbInactivos.AutoSize = True
        Me.rbInactivos.Location = New System.Drawing.Point(16, 97)
        Me.rbInactivos.Name = "rbInactivos"
        Me.rbInactivos.Size = New System.Drawing.Size(77, 17)
        Me.rbInactivos.TabIndex = 3
        Me.rbInactivos.Text = "Inactivos"
        Me.rbInactivos.UseVisualStyleBackColor = True
        '
        'rbActivos
        '
        Me.rbActivos.AutoSize = True
        Me.rbActivos.Location = New System.Drawing.Point(16, 74)
        Me.rbActivos.Name = "rbActivos"
        Me.rbActivos.Size = New System.Drawing.Size(67, 17)
        Me.rbActivos.TabIndex = 2
        Me.rbActivos.Text = "Activos"
        Me.rbActivos.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(16, 51)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(60, 17)
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
        Me.rbProveedor.Size = New System.Drawing.Size(83, 17)
        Me.rbProveedor.TabIndex = 0
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbCriterios)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(354, 180)
        Me.PanelControl1.TabIndex = 3
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(254, 144)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 76
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(168, 144)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 75
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'frmSivReporteProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 180)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivReporteProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Reporte de Proveedores"
        Me.gbCriterios.ResumeLayout(False)
        Me.gbCriterios.PerformLayout()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbInactivos As System.Windows.Forms.RadioButton
    Friend WithEvents rbActivos As System.Windows.Forms.RadioButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbProveedor As C1.Win.C1List.C1Combo
End Class
