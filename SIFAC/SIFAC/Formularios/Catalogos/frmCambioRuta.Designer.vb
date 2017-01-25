<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioRuta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioRuta))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbRutas = New C1.Win.C1List.C1Combo()
        Me.cmbDiaCrobro = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDiaCrobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmbRutas)
        Me.PanelControl1.Controls.Add(Me.cmbDiaCrobro)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(358, 147)
        Me.PanelControl1.TabIndex = 26
        '
        'cmbRutas
        '
        Me.cmbRutas.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbRutas.AutoCompletion = True
        Me.cmbRutas.AutoDropDown = True
        Me.cmbRutas.Caption = ""
        Me.cmbRutas.CaptionHeight = 17
        Me.cmbRutas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbRutas.ColumnCaptionHeight = 17
        Me.cmbRutas.ColumnFooterHeight = 17
        Me.cmbRutas.ContentHeight = 15
        Me.cmbRutas.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbRutas.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbRutas.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRutas.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRutas.EditorHeight = 15
        Me.cmbRutas.Images.Add(CType(resources.GetObject("cmbRutas.Images"), System.Drawing.Image))
        Me.cmbRutas.ItemHeight = 15
        Me.cmbRutas.Location = New System.Drawing.Point(107, 18)
        Me.cmbRutas.MatchEntryTimeout = CType(2000, Long)
        Me.cmbRutas.MaxDropDownItems = CType(5, Short)
        Me.cmbRutas.MaxLength = 32767
        Me.cmbRutas.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbRutas.Name = "cmbRutas"
        Me.cmbRutas.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbRutas.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbRutas.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbRutas.Size = New System.Drawing.Size(223, 21)
        Me.cmbRutas.TabIndex = 0
        Me.cmbRutas.Tag = "OBLIGATORIO"
        Me.cmbRutas.PropBag = resources.GetString("cmbRutas.PropBag")
        '
        'cmbDiaCrobro
        '
        Me.cmbDiaCrobro.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbDiaCrobro.AutoCompletion = True
        Me.cmbDiaCrobro.AutoDropDown = True
        Me.cmbDiaCrobro.Caption = ""
        Me.cmbDiaCrobro.CaptionHeight = 17
        Me.cmbDiaCrobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbDiaCrobro.ColumnCaptionHeight = 17
        Me.cmbDiaCrobro.ColumnFooterHeight = 17
        Me.cmbDiaCrobro.ContentHeight = 15
        Me.cmbDiaCrobro.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbDiaCrobro.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbDiaCrobro.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDiaCrobro.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDiaCrobro.EditorHeight = 15
        Me.cmbDiaCrobro.Enabled = False
        Me.cmbDiaCrobro.Images.Add(CType(resources.GetObject("cmbDiaCrobro.Images"), System.Drawing.Image))
        Me.cmbDiaCrobro.ItemHeight = 15
        Me.cmbDiaCrobro.Location = New System.Drawing.Point(107, 49)
        Me.cmbDiaCrobro.MatchEntryTimeout = CType(2000, Long)
        Me.cmbDiaCrobro.MaxDropDownItems = CType(5, Short)
        Me.cmbDiaCrobro.MaxLength = 32767
        Me.cmbDiaCrobro.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbDiaCrobro.Name = "cmbDiaCrobro"
        Me.cmbDiaCrobro.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbDiaCrobro.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbDiaCrobro.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbDiaCrobro.Size = New System.Drawing.Size(223, 21)
        Me.cmbDiaCrobro.TabIndex = 1
        Me.cmbDiaCrobro.Tag = "OBLIGATORIO"
        Me.cmbDiaCrobro.PropBag = resources.GetString("cmbDiaCrobro.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Tag = "OBLIGATORIO"
        Me.Label3.Text = "Dia de Cobro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Ruta:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(255, 82)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(169, 82)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(358, 21)
        Me.Panel1.TabIndex = 27
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'frmCambioRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 147)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambioRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambiar Ruta"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cmbRutas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDiaCrobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmbDiaCrobro As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbRutas As C1.Win.C1List.C1Combo
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
End Class
