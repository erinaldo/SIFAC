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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMarca = New C1.Win.C1List.C1Combo()
        Me.lblBodega = New System.Windows.Forms.Label()
        Me.cmbBodegas = New C1.Win.C1List.C1Combo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxCriterios.SuspendLayout()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCriterios
        '
        Me.gbxCriterios.Controls.Add(Me.Label2)
        Me.gbxCriterios.Controls.Add(Me.cmbMarca)
        Me.gbxCriterios.Controls.Add(Me.lblBodega)
        Me.gbxCriterios.Controls.Add(Me.cmbBodegas)
        Me.gbxCriterios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCriterios.Location = New System.Drawing.Point(15, 37)
        Me.gbxCriterios.Name = "gbxCriterios"
        Me.gbxCriterios.Size = New System.Drawing.Size(374, 80)
        Me.gbxCriterios.TabIndex = 9
        Me.gbxCriterios.TabStop = False
        Me.gbxCriterios.Text = "Criterios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Marca:"
        '
        'cmbMarca
        '
        Me.cmbMarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMarca.AutoCompletion = True
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
        Me.cmbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.Images.Add(CType(resources.GetObject("cmbMarca.Images"), System.Drawing.Image))
        Me.cmbMarca.ItemHeight = 15
        Me.cmbMarca.Location = New System.Drawing.Point(105, 46)
        Me.cmbMarca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMarca.MaxDropDownItems = CType(5, Short)
        Me.cmbMarca.MaxLength = 32767
        Me.cmbMarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMarca.Size = New System.Drawing.Size(205, 21)
        Me.cmbMarca.TabIndex = 6
        Me.cmbMarca.PropBag = resources.GetString("cmbMarca.PropBag")
        '
        'lblBodega
        '
        Me.lblBodega.AutoSize = True
        Me.lblBodega.Location = New System.Drawing.Point(29, 25)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(54, 13)
        Me.lblBodega.TabIndex = 5
        Me.lblBodega.Text = "Bodega:"
        '
        'cmbBodegas
        '
        Me.cmbBodegas.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodegas.AutoCompletion = True
        Me.cmbBodegas.Caption = ""
        Me.cmbBodegas.CaptionHeight = 17
        Me.cmbBodegas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodegas.ColumnCaptionHeight = 17
        Me.cmbBodegas.ColumnFooterHeight = 17
        Me.cmbBodegas.ContentHeight = 15
        Me.cmbBodegas.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBodegas.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBodegas.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodegas.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodegas.EditorHeight = 15
        Me.cmbBodegas.Enabled = False
        Me.cmbBodegas.Images.Add(CType(resources.GetObject("cmbBodegas.Images"), System.Drawing.Image))
        Me.cmbBodegas.ItemHeight = 15
        Me.cmbBodegas.Location = New System.Drawing.Point(105, 19)
        Me.cmbBodegas.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodegas.MaxDropDownItems = CType(5, Short)
        Me.cmbBodegas.MaxLength = 32767
        Me.cmbBodegas.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodegas.Name = "cmbBodegas"
        Me.cmbBodegas.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodegas.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodegas.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodegas.Size = New System.Drawing.Size(205, 21)
        Me.cmbBodegas.TabIndex = 3
        Me.cmbBodegas.PropBag = resources.GetString("cmbBodegas.PropBag")
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
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 21)
        Me.Panel1.TabIndex = 95
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.chkTodos)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.gbxCriterios)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(412, 195)
        Me.PanelControl1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(309, 130)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 82
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos.Location = New System.Drawing.Point(15, 123)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(141, 17)
        Me.chkTodos.TabIndex = 4
        Me.chkTodos.Text = "Todos los productos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(223, 130)
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
        Me.ClientSize = New System.Drawing.Size(412, 195)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCriteriosInventarioReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Reporte de Inventario"
        Me.gbxCriterios.ResumeLayout(False)
        Me.gbxCriterios.PerformLayout()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents cmbBodegas As C1.Win.C1List.C1Combo
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMarca As C1.Win.C1List.C1Combo
End Class
