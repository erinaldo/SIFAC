<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccModificarLimite
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccModificarLimite))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NumNuevolimite = New C1.Win.C1Input.C1NumericEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.numLimiteCredito = New C1.Win.C1Input.C1NumericEdit
        Me.lblLimiteCredito = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumNuevolimite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLimiteCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 20)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(269, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 30)
        Me.Panel2.TabIndex = 13
        Me.Panel2.Tag = "LAYOUT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumNuevolimite)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.numLimiteCredito)
        Me.GroupBox1.Controls.Add(Me.lblLimiteCredito)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 102)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Cambio"
        '
        'NumNuevolimite
        '
        Me.NumNuevolimite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NumNuevolimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumNuevolimite.DisplayFormat.EmptyAsNull = False
        Me.NumNuevolimite.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumNuevolimite.EditFormat.EmptyAsNull = False
        Me.NumNuevolimite.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.NumNuevolimite.EmptyAsNull = True
        Me.NumNuevolimite.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumNuevolimite.Location = New System.Drawing.Point(153, 48)
        Me.NumNuevolimite.MaskInfo.EmptyAsNull = False
        Me.NumNuevolimite.MaskInfo.Inherit = CType((C1.Win.C1Input.MaskInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.MaskInfoInheritFlags.ErrorMessage), C1.Win.C1Input.MaskInfoInheritFlags)
        Me.NumNuevolimite.Name = "NumNuevolimite"
        Me.NumNuevolimite.Size = New System.Drawing.Size(147, 18)
        Me.NumNuevolimite.TabIndex = 7
        Me.NumNuevolimite.Tag = Nothing
        Me.NumNuevolimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumNuevolimite.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumNuevolimite.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.NumNuevolimite.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nuevo Limite de Credito:"
        '
        'numLimiteCredito
        '
        Me.numLimiteCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numLimiteCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numLimiteCredito.DisplayFormat.EmptyAsNull = False
        Me.numLimiteCredito.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numLimiteCredito.EditFormat.EmptyAsNull = False
        Me.numLimiteCredito.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numLimiteCredito.EmptyAsNull = True
        Me.numLimiteCredito.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numLimiteCredito.Location = New System.Drawing.Point(153, 24)
        Me.numLimiteCredito.MaskInfo.EmptyAsNull = False
        Me.numLimiteCredito.MaskInfo.Inherit = CType((C1.Win.C1Input.MaskInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.MaskInfoInheritFlags.ErrorMessage), C1.Win.C1Input.MaskInfoInheritFlags)
        Me.numLimiteCredito.Name = "numLimiteCredito"
        Me.numLimiteCredito.Size = New System.Drawing.Size(147, 18)
        Me.numLimiteCredito.TabIndex = 5
        Me.numLimiteCredito.Tag = Nothing
        Me.numLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numLimiteCredito.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numLimiteCredito.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numLimiteCredito.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'lblLimiteCredito
        '
        Me.lblLimiteCredito.AutoSize = True
        Me.lblLimiteCredito.Location = New System.Drawing.Point(16, 26)
        Me.lblLimiteCredito.Name = "lblLimiteCredito"
        Me.lblLimiteCredito.Size = New System.Drawing.Size(121, 13)
        Me.lblLimiteCredito.TabIndex = 4
        Me.lblLimiteCredito.Text = "Limite de Credito Actual:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(247, 149)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 29)
        Me.cmdCancelar.TabIndex = 17
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(166, 149)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 29)
        Me.cmdAceptar.TabIndex = 16
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSccModificarLimite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 204)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccModificarLimite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificación de Limite de Crédito"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumNuevolimite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLimiteCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumNuevolimite As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numLimiteCredito As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblLimiteCredito As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
End Class
