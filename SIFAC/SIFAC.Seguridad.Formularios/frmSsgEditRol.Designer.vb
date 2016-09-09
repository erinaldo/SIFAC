<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSsgEditRol
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSsgEditRol))
        Me.TabAcciones = New System.Windows.Forms.TabControl()
        Me.TabRol = New System.Windows.Forms.TabPage()
        Me.grpDatosRol = New System.Windows.Forms.GroupBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.grpDatosAplicacion = New System.Windows.Forms.GroupBox()
        Me.txtCodInternoA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdAcciones = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.TabAcciones.SuspendLayout()
        Me.TabRol.SuspendLayout()
        Me.grpDatosRol.SuspendLayout()
        Me.grpDatosAplicacion.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grdAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabAcciones
        '
        Me.TabAcciones.Controls.Add(Me.TabRol)
        Me.TabAcciones.Controls.Add(Me.TabPage2)
        Me.TabAcciones.Location = New System.Drawing.Point(16, 15)
        Me.TabAcciones.Margin = New System.Windows.Forms.Padding(4)
        Me.TabAcciones.Name = "TabAcciones"
        Me.TabAcciones.SelectedIndex = 0
        Me.TabAcciones.Size = New System.Drawing.Size(904, 401)
        Me.TabAcciones.TabIndex = 0
        '
        'TabRol
        '
        Me.TabRol.Controls.Add(Me.grpDatosRol)
        Me.TabRol.Controls.Add(Me.grpDatosAplicacion)
        Me.TabRol.Location = New System.Drawing.Point(4, 25)
        Me.TabRol.Margin = New System.Windows.Forms.Padding(4)
        Me.TabRol.Name = "TabRol"
        Me.TabRol.Padding = New System.Windows.Forms.Padding(4)
        Me.TabRol.Size = New System.Drawing.Size(896, 372)
        Me.TabRol.TabIndex = 0
        Me.TabRol.Text = "Rol"
        Me.TabRol.UseVisualStyleBackColor = True
        '
        'grpDatosRol
        '
        Me.grpDatosRol.BackColor = System.Drawing.SystemColors.Control
        Me.grpDatosRol.Controls.Add(Me.lblDescripcion)
        Me.grpDatosRol.Controls.Add(Me.lblNombre)
        Me.grpDatosRol.Controls.Add(Me.txtDescripcion)
        Me.grpDatosRol.Controls.Add(Me.txtNombre)
        Me.grpDatosRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpDatosRol.Location = New System.Drawing.Point(17, 164)
        Me.grpDatosRol.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatosRol.Name = "grpDatosRol"
        Me.grpDatosRol.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatosRol.Size = New System.Drawing.Size(564, 175)
        Me.grpDatosRol.TabIndex = 0
        Me.grpDatosRol.TabStop = False
        Me.grpDatosRol.Text = "Datos del Rol"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescripcion.Location = New System.Drawing.Point(8, 55)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(98, 17)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Tag = "OBLIGATORIO"
        Me.lblDescripcion.Text = "Descripción:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombre.Location = New System.Drawing.Point(8, 27)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 17)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Tag = "OBLIGATORIO"
        Me.lblNombre.Text = "Nombre:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(141, 55)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(404, 106)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(141, 23)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(404, 23)
        Me.txtNombre.TabIndex = 0
        '
        'grpDatosAplicacion
        '
        Me.grpDatosAplicacion.BackColor = System.Drawing.SystemColors.Control
        Me.grpDatosAplicacion.Controls.Add(Me.txtCodInternoA)
        Me.grpDatosAplicacion.Controls.Add(Me.Label2)
        Me.grpDatosAplicacion.Controls.Add(Me.Label3)
        Me.grpDatosAplicacion.Controls.Add(Me.txtNombreA)
        Me.grpDatosAplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosAplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpDatosAplicacion.Location = New System.Drawing.Point(17, 34)
        Me.grpDatosAplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatosAplicacion.Name = "grpDatosAplicacion"
        Me.grpDatosAplicacion.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatosAplicacion.Size = New System.Drawing.Size(564, 96)
        Me.grpDatosAplicacion.TabIndex = 9
        Me.grpDatosAplicacion.TabStop = False
        Me.grpDatosAplicacion.Text = "Datos de la Aplicación"
        '
        'txtCodInternoA
        '
        Me.txtCodInternoA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCodInternoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodInternoA.Location = New System.Drawing.Point(141, 27)
        Me.txtCodInternoA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodInternoA.MaxLength = 10
        Me.txtCodInternoA.Name = "txtCodInternoA"
        Me.txtCodInternoA.Size = New System.Drawing.Size(403, 23)
        Me.txtCodInternoA.TabIndex = 20
        Me.txtCodInternoA.Tag = "BLOQUEADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Tag = "OBLIGATORIO"
        Me.Label3.Text = "Código:"
        '
        'txtNombreA
        '
        Me.txtNombreA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNombreA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreA.Location = New System.Drawing.Point(141, 59)
        Me.txtNombreA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreA.MaxLength = 100
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(404, 23)
        Me.txtNombreA.TabIndex = 1
        Me.txtNombreA.Tag = "BLOQUEADO"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdAcciones)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(896, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Acciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grdAcciones
        '
        Me.grdAcciones.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.grdAcciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAcciones.EmptyRows = True
        Me.grdAcciones.ExtendRightColumn = True
        Me.grdAcciones.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdAcciones.Images.Add(CType(resources.GetObject("grdAcciones.Images"), System.Drawing.Image))
        Me.grdAcciones.Location = New System.Drawing.Point(4, 4)
        Me.grdAcciones.Margin = New System.Windows.Forms.Padding(4)
        Me.grdAcciones.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor
        Me.grdAcciones.Name = "grdAcciones"
        Me.grdAcciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdAcciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdAcciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdAcciones.PrintInfo.PageSettings = CType(resources.GetObject("grdAcciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdAcciones.Size = New System.Drawing.Size(888, 364)
        Me.grdAcciones.TabIndex = 1
        Me.grdAcciones.Tag = "AGRUPAR"
        Me.grdAcciones.Text = "C1TrueDBGrid1"
        Me.grdAcciones.PropBag = resources.GetString("grdAcciones.PropBag")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(811, 432)
        Me.cmdCancelar.LookAndFeel.SkinName = "Caramel"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(696, 432)
        Me.cmdAceptar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(107, 34)
        Me.cmdAceptar.TabIndex = 24
        Me.cmdAceptar.Tag = "GUARDAR"
        Me.cmdAceptar.Text = "&Guardar"
        '
        'frmSsgEditRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 481)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.TabAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSsgEditRol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Rol"
        Me.TabAcciones.ResumeLayout(False)
        Me.TabRol.ResumeLayout(False)
        Me.grpDatosRol.ResumeLayout(False)
        Me.grpDatosRol.PerformLayout()
        Me.grpDatosAplicacion.ResumeLayout(False)
        Me.grpDatosAplicacion.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grdAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabAcciones As System.Windows.Forms.TabControl
    Friend WithEvents TabRol As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grpDatosRol As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents grpDatosAplicacion As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodInternoA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombreA As System.Windows.Forms.TextBox
    Friend WithEvents grdAcciones As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
End Class
