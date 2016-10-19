<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbImpresion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbImpresion))
        Me.grpEstados = New System.Windows.Forms.GroupBox()
        Me.rbtAmbos = New System.Windows.Forms.RadioButton()
        Me.rbtInactivo = New System.Windows.Forms.RadioButton()
        Me.rbtActivo = New System.Windows.Forms.RadioButton()
        Me.lblCatalogos = New System.Windows.Forms.Label()
        Me.chkMostrar = New System.Windows.Forms.CheckBox()
        Me.cmbCatalogos = New C1.Win.C1List.C1Combo()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbimpresora = New System.Windows.Forms.RadioButton()
        Me.rbArchivo = New System.Windows.Forms.RadioButton()
        Me.rbPantalla = New System.Windows.Forms.RadioButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grpEstados.SuspendLayout()
        CType(Me.cmbCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEstados
        '
        Me.grpEstados.Controls.Add(Me.rbtAmbos)
        Me.grpEstados.Controls.Add(Me.rbtInactivo)
        Me.grpEstados.Controls.Add(Me.rbtActivo)
        Me.grpEstados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEstados.Location = New System.Drawing.Point(14, 12)
        Me.grpEstados.Name = "grpEstados"
        Me.grpEstados.Size = New System.Drawing.Size(304, 53)
        Me.grpEstados.TabIndex = 0
        Me.grpEstados.TabStop = False
        Me.grpEstados.Text = "Estados "
        '
        'rbtAmbos
        '
        Me.rbtAmbos.AutoSize = True
        Me.rbtAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAmbos.Location = New System.Drawing.Point(230, 22)
        Me.rbtAmbos.Name = "rbtAmbos"
        Me.rbtAmbos.Size = New System.Drawing.Size(62, 17)
        Me.rbtAmbos.TabIndex = 2
        Me.rbtAmbos.TabStop = True
        Me.rbtAmbos.Text = "Ambos"
        Me.rbtAmbos.UseVisualStyleBackColor = True
        '
        'rbtInactivo
        '
        Me.rbtInactivo.AutoSize = True
        Me.rbtInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtInactivo.Location = New System.Drawing.Point(116, 22)
        Me.rbtInactivo.Name = "rbtInactivo"
        Me.rbtInactivo.Size = New System.Drawing.Size(71, 17)
        Me.rbtInactivo.TabIndex = 1
        Me.rbtInactivo.TabStop = True
        Me.rbtInactivo.Text = "Inactivo"
        Me.rbtInactivo.UseVisualStyleBackColor = True
        '
        'rbtActivo
        '
        Me.rbtActivo.AutoSize = True
        Me.rbtActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtActivo.Location = New System.Drawing.Point(17, 22)
        Me.rbtActivo.Name = "rbtActivo"
        Me.rbtActivo.Size = New System.Drawing.Size(61, 17)
        Me.rbtActivo.TabIndex = 0
        Me.rbtActivo.TabStop = True
        Me.rbtActivo.Text = "Activo"
        Me.rbtActivo.UseVisualStyleBackColor = True
        '
        'lblCatalogos
        '
        Me.lblCatalogos.AutoSize = True
        Me.lblCatalogos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatalogos.Location = New System.Drawing.Point(28, 77)
        Me.lblCatalogos.Name = "lblCatalogos"
        Me.lblCatalogos.Size = New System.Drawing.Size(63, 13)
        Me.lblCatalogos.TabIndex = 2
        Me.lblCatalogos.Text = "Catálogos"
        '
        'chkMostrar
        '
        Me.chkMostrar.AutoSize = True
        Me.chkMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrar.Location = New System.Drawing.Point(21, 107)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(176, 17)
        Me.chkMostrar.TabIndex = 3
        Me.chkMostrar.Text = "Mostrar Valores Asociados"
        Me.chkMostrar.UseVisualStyleBackColor = True
        '
        'cmbCatalogos
        '
        Me.cmbCatalogos.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCatalogos.Caption = ""
        Me.cmbCatalogos.CaptionHeight = 17
        Me.cmbCatalogos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCatalogos.ColumnCaptionHeight = 17
        Me.cmbCatalogos.ColumnFooterHeight = 17
        Me.cmbCatalogos.ContentHeight = 15
        Me.cmbCatalogos.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCatalogos.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCatalogos.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCatalogos.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCatalogos.EditorHeight = 15
        Me.cmbCatalogos.Images.Add(CType(resources.GetObject("cmbCatalogos.Images"), System.Drawing.Image))
        Me.cmbCatalogos.ItemHeight = 15
        Me.cmbCatalogos.Location = New System.Drawing.Point(91, 73)
        Me.cmbCatalogos.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCatalogos.MaxDropDownItems = CType(5, Short)
        Me.cmbCatalogos.MaxLength = 32767
        Me.cmbCatalogos.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCatalogos.Name = "cmbCatalogos"
        Me.cmbCatalogos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCatalogos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCatalogos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCatalogos.Size = New System.Drawing.Size(220, 21)
        Me.cmbCatalogos.TabIndex = 6
        Me.cmbCatalogos.Text = "Todos"
        Me.cmbCatalogos.PropBag = resources.GetString("cmbCatalogos.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbimpresora)
        Me.GroupBox1.Controls.Add(Me.rbArchivo)
        Me.GroupBox1.Controls.Add(Me.rbPantalla)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 52)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destino de Impresión"
        '
        'rbimpresora
        '
        Me.rbimpresora.AutoSize = True
        Me.rbimpresora.Location = New System.Drawing.Point(115, 19)
        Me.rbimpresora.Name = "rbimpresora"
        Me.rbimpresora.Size = New System.Drawing.Size(80, 17)
        Me.rbimpresora.TabIndex = 3
        Me.rbimpresora.TabStop = True
        Me.rbimpresora.Text = "Impresora"
        Me.rbimpresora.UseVisualStyleBackColor = True
        '
        'rbArchivo
        '
        Me.rbArchivo.AutoSize = True
        Me.rbArchivo.Location = New System.Drawing.Point(229, 19)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(68, 17)
        Me.rbArchivo.TabIndex = 2
        Me.rbArchivo.TabStop = True
        Me.rbArchivo.Text = "Archivo"
        Me.rbArchivo.UseVisualStyleBackColor = True
        '
        'rbPantalla
        '
        Me.rbPantalla.AutoSize = True
        Me.rbPantalla.Location = New System.Drawing.Point(8, 19)
        Me.rbPantalla.Name = "rbPantalla"
        Me.rbPantalla.Size = New System.Drawing.Size(71, 17)
        Me.rbPantalla.TabIndex = 1
        Me.rbPantalla.TabStop = True
        Me.rbPantalla.Text = "Pantalla"
        Me.rbPantalla.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(238, 199)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 21
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(152, 199)
        Me.cmdAceptar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 28)
        Me.cmdAceptar.TabIndex = 20
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grpEstados)
        Me.PanelControl1.Controls.Add(Me.chkMostrar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.lblCatalogos)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(330, 235)
        Me.PanelControl1.TabIndex = 22
        '
        'frmStbImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 235)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmbCatalogos)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Impresión de Catálogos"
        Me.grpEstados.ResumeLayout(False)
        Me.grpEstados.PerformLayout()
        CType(Me.cmbCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEstados As System.Windows.Forms.GroupBox
    Friend WithEvents rbtAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtActivo As System.Windows.Forms.RadioButton
    Friend WithEvents lblCatalogos As System.Windows.Forms.Label
    Friend WithEvents chkMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCatalogos As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbimpresora As System.Windows.Forms.RadioButton
    Friend WithEvents rbArchivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
