<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriteriosInventarioReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCriteriosInventarioReporte))
        Me.gbxCriterios = New System.Windows.Forms.GroupBox()
        Me.cmbRepuestos = New C1.Win.C1List.C1Combo()
        Me.cmbBodegas = New C1.Win.C1List.C1Combo()
        Me.chkRepuesto = New System.Windows.Forms.CheckBox()
        Me.chkBodega = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxVer = New System.Windows.Forms.GroupBox()
        Me.chkPrecios = New System.Windows.Forms.CheckBox()
        Me.chkCostos = New System.Windows.Forms.CheckBox()
        Me.chkLevInventario = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxCriterios.SuspendLayout()
        CType(Me.cmbRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxVer.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCriterios
        '
        Me.gbxCriterios.Controls.Add(Me.cmbRepuestos)
        Me.gbxCriterios.Controls.Add(Me.cmbBodegas)
        Me.gbxCriterios.Controls.Add(Me.chkRepuesto)
        Me.gbxCriterios.Controls.Add(Me.chkBodega)
        Me.gbxCriterios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCriterios.Location = New System.Drawing.Point(15, 37)
        Me.gbxCriterios.Name = "gbxCriterios"
        Me.gbxCriterios.Size = New System.Drawing.Size(328, 80)
        Me.gbxCriterios.TabIndex = 9
        Me.gbxCriterios.TabStop = False
        Me.gbxCriterios.Text = "Criterios"
        '
        'cmbRepuestos
        '
        Me.cmbRepuestos.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbRepuestos.Caption = ""
        Me.cmbRepuestos.CaptionHeight = 17
        Me.cmbRepuestos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbRepuestos.ColumnCaptionHeight = 17
        Me.cmbRepuestos.ColumnFooterHeight = 17
        Me.cmbRepuestos.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbRepuestos.ContentHeight = 15
        Me.cmbRepuestos.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbRepuestos.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbRepuestos.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRepuestos.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRepuestos.EditorHeight = 15
        Me.cmbRepuestos.Enabled = False
        Me.cmbRepuestos.Images.Add(CType(resources.GetObject("cmbRepuestos.Images"), System.Drawing.Image))
        Me.cmbRepuestos.ItemHeight = 15
        Me.cmbRepuestos.Location = New System.Drawing.Point(147, 54)
        Me.cmbRepuestos.MatchEntryTimeout = CType(2000, Long)
        Me.cmbRepuestos.MaxDropDownItems = CType(5, Short)
        Me.cmbRepuestos.MaxLength = 32767
        Me.cmbRepuestos.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbRepuestos.Name = "cmbRepuestos"
        Me.cmbRepuestos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbRepuestos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbRepuestos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbRepuestos.Size = New System.Drawing.Size(161, 21)
        Me.cmbRepuestos.TabIndex = 3
        Me.cmbRepuestos.PropBag = resources.GetString("cmbRepuestos.PropBag")
        '
        'cmbBodegas
        '
        Me.cmbBodegas.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodegas.Caption = ""
        Me.cmbBodegas.CaptionHeight = 17
        Me.cmbBodegas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodegas.ColumnCaptionHeight = 17
        Me.cmbBodegas.ColumnFooterHeight = 17
        Me.cmbBodegas.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbBodegas.ContentHeight = 15
        Me.cmbBodegas.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBodegas.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBodegas.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodegas.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodegas.EditorHeight = 15
        Me.cmbBodegas.Enabled = False
        Me.cmbBodegas.Images.Add(CType(resources.GetObject("cmbBodegas.Images"), System.Drawing.Image))
        Me.cmbBodegas.ItemHeight = 15
        Me.cmbBodegas.Location = New System.Drawing.Point(147, 25)
        Me.cmbBodegas.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodegas.MaxDropDownItems = CType(5, Short)
        Me.cmbBodegas.MaxLength = 32767
        Me.cmbBodegas.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodegas.Name = "cmbBodegas"
        Me.cmbBodegas.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodegas.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodegas.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodegas.Size = New System.Drawing.Size(161, 21)
        Me.cmbBodegas.TabIndex = 3
        Me.cmbBodegas.PropBag = resources.GetString("cmbBodegas.PropBag")
        '
        'chkRepuesto
        '
        Me.chkRepuesto.AutoSize = True
        Me.chkRepuesto.Location = New System.Drawing.Point(24, 56)
        Me.chkRepuesto.Name = "chkRepuesto"
        Me.chkRepuesto.Size = New System.Drawing.Size(84, 17)
        Me.chkRepuesto.TabIndex = 0
        Me.chkRepuesto.Text = "Repuesto:"
        Me.chkRepuesto.UseVisualStyleBackColor = True
        '
        'chkBodega
        '
        Me.chkBodega.AutoSize = True
        Me.chkBodega.Location = New System.Drawing.Point(24, 27)
        Me.chkBodega.Name = "chkBodega"
        Me.chkBodega.Size = New System.Drawing.Size(73, 17)
        Me.chkBodega.TabIndex = 0
        Me.chkBodega.Text = "Bodega:"
        Me.chkBodega.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Seleccione criterios para su reporte:"
        '
        'gbxVer
        '
        Me.gbxVer.Controls.Add(Me.chkPrecios)
        Me.gbxVer.Controls.Add(Me.chkCostos)
        Me.gbxVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxVer.Location = New System.Drawing.Point(349, 37)
        Me.gbxVer.Name = "gbxVer"
        Me.gbxVer.Size = New System.Drawing.Size(95, 82)
        Me.gbxVer.TabIndex = 9
        Me.gbxVer.TabStop = False
        Me.gbxVer.Text = "Ver"
        '
        'chkPrecios
        '
        Me.chkPrecios.AutoSize = True
        Me.chkPrecios.Location = New System.Drawing.Point(16, 44)
        Me.chkPrecios.Name = "chkPrecios"
        Me.chkPrecios.Size = New System.Drawing.Size(68, 17)
        Me.chkPrecios.TabIndex = 0
        Me.chkPrecios.Text = "Precios"
        Me.chkPrecios.UseVisualStyleBackColor = True
        '
        'chkCostos
        '
        Me.chkCostos.AutoSize = True
        Me.chkCostos.Location = New System.Drawing.Point(16, 19)
        Me.chkCostos.Name = "chkCostos"
        Me.chkCostos.Size = New System.Drawing.Size(64, 17)
        Me.chkCostos.TabIndex = 0
        Me.chkCostos.Text = "Costos"
        Me.chkCostos.UseVisualStyleBackColor = True
        '
        'chkLevInventario
        '
        Me.chkLevInventario.AutoSize = True
        Me.chkLevInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLevInventario.Location = New System.Drawing.Point(15, 125)
        Me.chkLevInventario.Name = "chkLevInventario"
        Me.chkLevInventario.Size = New System.Drawing.Size(232, 17)
        Me.chkLevInventario.TabIndex = 0
        Me.chkLevInventario.Text = "Formato levantamiento de inventario"
        Me.chkLevInventario.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 21)
        Me.Panel1.TabIndex = 95
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.gbxCriterios)
        Me.PanelControl1.Controls.Add(Me.gbxVer)
        Me.PanelControl1.Controls.Add(Me.chkLevInventario)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(457, 195)
        Me.PanelControl1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(366, 135)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 82
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(280, 135)
        Me.cmdAceptar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 28)
        Me.cmdAceptar.TabIndex = 81
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'frmCriteriosInventarioReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 195)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCriteriosInventarioReporte"
        Me.Text = "Imprimir Reporte de Inventario"
        Me.gbxCriterios.ResumeLayout(False)
        Me.gbxCriterios.PerformLayout()
        CType(Me.cmbRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxVer.ResumeLayout(False)
        Me.gbxVer.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBodegas As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbxVer As System.Windows.Forms.GroupBox
    Friend WithEvents chkPrecios As System.Windows.Forms.CheckBox
    Friend WithEvents chkCostos As System.Windows.Forms.CheckBox
    Friend WithEvents cmbRepuestos As C1.Win.C1List.C1Combo
    Friend WithEvents chkRepuesto As System.Windows.Forms.CheckBox
    Friend WithEvents chkBodega As System.Windows.Forms.CheckBox
    Friend WithEvents chkLevInventario As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
End Class
