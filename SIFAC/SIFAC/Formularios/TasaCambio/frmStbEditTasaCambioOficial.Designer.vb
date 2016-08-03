<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbEditTasaCambioOficial
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbEditTasaCambioOficial))
        Me.cmbMoneda = New C1.Win.C1List.C1Combo
        Me.cmbMes = New C1.Win.C1List.C1Combo
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblMes = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.nmuMonto = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nmuMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMoneda
        '
        Me.cmbMoneda.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMoneda.Caption = ""
        Me.cmbMoneda.CaptionHeight = 17
        Me.cmbMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMoneda.ColumnCaptionHeight = 17
        Me.cmbMoneda.ColumnFooterHeight = 17
        Me.cmbMoneda.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMoneda.ContentHeight = 15
        Me.cmbMoneda.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMoneda.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMoneda.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMoneda.EditorHeight = 15
        Me.cmbMoneda.Images.Add(CType(resources.GetObject("cmbMoneda.Images"), System.Drawing.Image))
        Me.cmbMoneda.ItemHeight = 15
        Me.cmbMoneda.LimitToList = True
        Me.cmbMoneda.Location = New System.Drawing.Point(96, 28)
        Me.cmbMoneda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoneda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoneda.MaxLength = 32767
        Me.cmbMoneda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoneda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoneda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoneda.Size = New System.Drawing.Size(244, 21)
        Me.cmbMoneda.TabIndex = 1
        Me.cmbMoneda.PropBag = resources.GetString("cmbMoneda.PropBag")
        '
        'cmbMes
        '
        Me.cmbMes.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMes.Caption = ""
        Me.cmbMes.CaptionHeight = 17
        Me.cmbMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMes.ColumnCaptionHeight = 17
        Me.cmbMes.ColumnFooterHeight = 17
        Me.cmbMes.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMes.ContentHeight = 15
        Me.cmbMes.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMes.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMes.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMes.EditorHeight = 15
        Me.cmbMes.Images.Add(CType(resources.GetObject("cmbMes.Images"), System.Drawing.Image))
        Me.cmbMes.ItemHeight = 15
        Me.cmbMes.LimitToList = True
        Me.cmbMes.Location = New System.Drawing.Point(96, 57)
        Me.cmbMes.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMes.MaxDropDownItems = CType(5, Short)
        Me.cmbMes.MaxLength = 32767
        Me.cmbMes.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMes.Size = New System.Drawing.Size(128, 21)
        Me.cmbMes.TabIndex = 2
        Me.cmbMes.PropBag = resources.GetString("cmbMes.PropBag")
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(269, 58)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(71, 20)
        Me.txtAnio.TabIndex = 4
        Me.txtAnio.Tag = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdGuardar)
        Me.Panel1.Location = New System.Drawing.Point(0, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 36)
        Me.Panel1.TabIndex = 6
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(308, 3)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(228, 3)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(74, 30)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(11, 61)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(79, 13)
        Me.lblMes.TabIndex = 7
        Me.lblMes.Text = "para el mes de:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nmuMonto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblMes)
        Me.GroupBox1.Controls.Add(Me.txtAnio)
        Me.GroupBox1.Controls.Add(Me.cmbMoneda)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 116)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tasa de Cambio del Córdoba"
        '
        'nmuMonto
        '
        Me.nmuMonto.Location = New System.Drawing.Point(96, 87)
        Me.nmuMonto.Name = "nmuMonto"
        Me.nmuMonto.Size = New System.Drawing.Size(128, 20)
        Me.nmuMonto.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Monto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Respecto al"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(242, 61)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(21, 13)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Tag = ""
        Me.lblFecha.Text = "del"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 32)
        Me.Panel2.TabIndex = 24
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(320, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(663, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UM"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 198)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 21)
        Me.Panel3.TabIndex = 23
        '
        'frmStbEditTasaCambioOficial
        '
        Me.AcceptButton = Me.cmdGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(391, 219)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbEditTasaCambioOficial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Registrar Tasa de Cambio Oficial"
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nmuMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbMoneda As C1.Win.C1List.C1Combo
    Friend WithEvents cmbMes As C1.Win.C1List.C1Combo
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents nmuMonto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
