<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaBuscarFacturaExp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaBuscarFacturaExp))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmbEstado = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumExp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumfact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 39)
        Me.Panel2.TabIndex = 24
        Me.Panel2.Tag = "LAYOUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(884, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UM"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 248)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 26)
        Me.Panel1.TabIndex = 23
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(308, 207)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(99, 36)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(201, 207)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(99, 36)
        Me.cmdGuardar.TabIndex = 28
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEstado.Caption = ""
        Me.cmbEstado.CaptionHeight = 17
        Me.cmbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEstado.ColumnCaptionHeight = 17
        Me.cmbEstado.ColumnFooterHeight = 17
        Me.cmbEstado.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbEstado.ContentHeight = 18
        Me.cmbEstado.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEstado.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEstado.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstado.EditorHeight = 18
        Me.cmbEstado.Images.Add(CType(resources.GetObject("cmbEstado.Images"), System.Drawing.Image))
        Me.cmbEstado.ItemHeight = 15
        Me.cmbEstado.Location = New System.Drawing.Point(132, 127)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbEstado.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEstado.MaxDropDownItems = CType(5, Short)
        Me.cmbEstado.MaxLength = 32767
        Me.cmbEstado.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEstado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEstado.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEstado.Size = New System.Drawing.Size(280, 24)
        Me.cmbEstado.TabIndex = 33
        Me.cmbEstado.PropBag = resources.GetString("cmbEstado.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Estado:"
        '
        'txtNumExp
        '
        Me.txtNumExp.Location = New System.Drawing.Point(131, 54)
        Me.txtNumExp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumExp.Name = "txtNumExp"
        Me.txtNumExp.Size = New System.Drawing.Size(279, 22)
        Me.txtNumExp.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "No Expediente:"
        '
        'txtNumfact
        '
        Me.txtNumfact.Location = New System.Drawing.Point(131, 90)
        Me.txtNumfact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumfact.Name = "txtNumfact"
        Me.txtNumfact.Size = New System.Drawing.Size(279, 22)
        Me.txtNumfact.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "No. Factura:"
        '
        'frmSfaBuscarFacturaExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 274)
        Me.Controls.Add(Me.txtNumfact)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumExp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaBuscarFacturaExp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Expedientes-facturas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmbEstado As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumExp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumfact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
