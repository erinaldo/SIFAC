<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteProductos))
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboMarca = New C1.Win.C1List.C1Combo()
        Me.cboCategoria = New C1.Win.C1List.C1Combo()
        Me.rbTodos = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(254, 136)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(168, 136)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(356, 176)
        Me.PanelControl1.TabIndex = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboMarca)
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterios"
        '
        'cboMarca
        '
        Me.cboMarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboMarca.AutoCompletion = True
        Me.cboMarca.AutoDropDown = True
        Me.cboMarca.Caption = ""
        Me.cboMarca.CaptionHeight = 17
        Me.cboMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMarca.ColumnCaptionHeight = 17
        Me.cboMarca.ColumnFooterHeight = 17
        Me.cboMarca.ContentHeight = 15
        Me.cboMarca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboMarca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboMarca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMarca.EditorHeight = 15
        Me.cboMarca.Images.Add(CType(resources.GetObject("cboMarca.Images"), System.Drawing.Image))
        Me.cboMarca.ItemHeight = 15
        Me.cboMarca.Location = New System.Drawing.Point(106, 55)
        Me.cboMarca.MatchEntryTimeout = CType(2000, Long)
        Me.cboMarca.MaxDropDownItems = CType(5, Short)
        Me.cboMarca.MaxLength = 32767
        Me.cboMarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboMarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboMarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboMarca.Size = New System.Drawing.Size(206, 21)
        Me.cboMarca.TabIndex = 1
        Me.cboMarca.Tag = "OBLIGATORIO"
        Me.cboMarca.PropBag = resources.GetString("cboMarca.PropBag")
        '
        'cboCategoria
        '
        Me.cboCategoria.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboCategoria.AutoCompletion = True
        Me.cboCategoria.AutoDropDown = True
        Me.cboCategoria.Caption = ""
        Me.cboCategoria.CaptionHeight = 17
        Me.cboCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCategoria.ColumnCaptionHeight = 17
        Me.cboCategoria.ColumnFooterHeight = 17
        Me.cboCategoria.ContentHeight = 15
        Me.cboCategoria.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboCategoria.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboCategoria.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoria.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCategoria.EditorHeight = 15
        Me.cboCategoria.Images.Add(CType(resources.GetObject("cboCategoria.Images"), System.Drawing.Image))
        Me.cboCategoria.ItemHeight = 15
        Me.cboCategoria.Location = New System.Drawing.Point(106, 25)
        Me.cboCategoria.MatchEntryTimeout = CType(2000, Long)
        Me.cboCategoria.MaxDropDownItems = CType(5, Short)
        Me.cboCategoria.MaxLength = 32767
        Me.cboCategoria.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboCategoria.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboCategoria.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboCategoria.Size = New System.Drawing.Size(206, 21)
        Me.cboCategoria.TabIndex = 0
        Me.cboCategoria.Tag = "OBLIGATORIO"
        Me.cboCategoria.PropBag = resources.GetString("cboCategoria.PropBag")
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(106, 89)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(61, 17)
        Me.rbTodos.TabIndex = 2
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Categoria:"
        '
        'frmReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 176)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de productos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cboMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbTodos As System.Windows.Forms.CheckBox
    Friend WithEvents cboMarca As C1.Win.C1List.C1Combo
    Friend WithEvents cboCategoria As C1.Win.C1List.C1Combo
End Class
