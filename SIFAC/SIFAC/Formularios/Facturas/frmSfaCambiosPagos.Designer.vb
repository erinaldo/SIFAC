<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaCambiosPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaCambiosPagos))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtusuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpNuevoPago = New C1.Win.C1Input.C1DateEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpFechaProximoPago = New C1.Win.C1Input.C1DateEdit
        Me.lblFechaPago = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpNuevoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaProximoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 22)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 32)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(246, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpNuevoPago)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpFechaProximoPago)
        Me.GroupBox1.Controls.Add(Me.lblFechaPago)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 124)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Cambio"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(112, 77)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(160, 20)
        Me.txtusuario.TabIndex = 21
        Me.txtusuario.Tag = "BLOQUEADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Usuario:"
        '
        'dtpNuevoPago
        '
        Me.dtpNuevoPago.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpNuevoPago.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpNuevoPago.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpNuevoPago.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpNuevoPago.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpNuevoPago.Location = New System.Drawing.Point(112, 50)
        Me.dtpNuevoPago.Name = "dtpNuevoPago"
        Me.dtpNuevoPago.Size = New System.Drawing.Size(160, 20)
        Me.dtpNuevoPago.TabIndex = 19
        Me.dtpNuevoPago.Tag = "BLOQUEADO"
        Me.dtpNuevoPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nueva Fecha:"
        '
        'dtpFechaProximoPago
        '
        Me.dtpFechaProximoPago.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaProximoPago.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaProximoPago.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaProximoPago.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaProximoPago.Enabled = False
        Me.dtpFechaProximoPago.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaProximoPago.Location = New System.Drawing.Point(112, 24)
        Me.dtpFechaProximoPago.Name = "dtpFechaProximoPago"
        Me.dtpFechaProximoPago.Size = New System.Drawing.Size(160, 20)
        Me.dtpFechaProximoPago.TabIndex = 17
        Me.dtpFechaProximoPago.Tag = "BLOQUEADO"
        Me.dtpFechaProximoPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFechaPago
        '
        Me.lblFechaPago.AutoSize = True
        Me.lblFechaPago.Location = New System.Drawing.Point(17, 27)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFechaPago.TabIndex = 16
        Me.lblFechaPago.Text = "Próximo Pago:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(230, 174)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 26
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(149, 174)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 25
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'frmSfaCambiosPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 232)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaCambiosPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Fecha de Pago próxima."
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpNuevoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaProximoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpNuevoPago As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaProximoPago As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
End Class
