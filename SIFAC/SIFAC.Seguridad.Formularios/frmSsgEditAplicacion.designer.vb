<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSsgEditAplicacion
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
        Me.grpDatosAplicacion = New System.Windows.Forms.GroupBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblCodInterno = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtCodInterno = New System.Windows.Forms.TextBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.grpDatosAplicacion.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDatosAplicacion
        '
        Me.grpDatosAplicacion.Controls.Add(Me.lblDescripcion)
        Me.grpDatosAplicacion.Controls.Add(Me.lblNombre)
        Me.grpDatosAplicacion.Controls.Add(Me.lblCodInterno)
        Me.grpDatosAplicacion.Controls.Add(Me.txtDescripcion)
        Me.grpDatosAplicacion.Controls.Add(Me.txtNombre)
        Me.grpDatosAplicacion.Controls.Add(Me.txtCodInterno)
        Me.grpDatosAplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosAplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpDatosAplicacion.Location = New System.Drawing.Point(12, 12)
        Me.grpDatosAplicacion.Name = "grpDatosAplicacion"
        Me.grpDatosAplicacion.Size = New System.Drawing.Size(423, 171)
        Me.grpDatosAplicacion.TabIndex = 0
        Me.grpDatosAplicacion.TabStop = False
        Me.grpDatosAplicacion.Text = "Datos de la Aplicación"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescripcion.Location = New System.Drawing.Point(6, 74)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Text = "Descripción:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombre.Location = New System.Drawing.Point(6, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Tag = "OBLIGATORIO"
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCodInterno
        '
        Me.lblCodInterno.AutoSize = True
        Me.lblCodInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodInterno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCodInterno.Location = New System.Drawing.Point(6, 25)
        Me.lblCodInterno.Name = "lblCodInterno"
        Me.lblCodInterno.Size = New System.Drawing.Size(43, 13)
        Me.lblCodInterno.TabIndex = 3
        Me.lblCodInterno.Tag = "OBLIGATORIO"
        Me.lblCodInterno.Text = "Código:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(106, 74)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(304, 87)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(106, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(304, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtCodInterno
        '
        Me.txtCodInterno.Location = New System.Drawing.Point(106, 22)
        Me.txtCodInterno.Name = "txtCodInterno"
        Me.txtCodInterno.Size = New System.Drawing.Size(304, 20)
        Me.txtCodInterno.TabIndex = 0
        Me.txtCodInterno.Tag = ""
        '
        'cmdAceptar
        '
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(269, 189)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(78, 28)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmdCancelar
        '
        Me.cmdCancelar.CausesValidation = False
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(357, 189)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmSsgEditAplicacion
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(444, 221)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grpDatosAplicacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSsgEditAplicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Aplicacion"
        Me.grpDatosAplicacion.ResumeLayout(False)
        Me.grpDatosAplicacion.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatosAplicacion As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCodInterno As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodInterno As System.Windows.Forms.TextBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
