<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogoAdd))
        Me.grpDatosCatalogo = New System.Windows.Forms.GroupBox()
        Me.cmdValor = New System.Windows.Forms.Button()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdDatosvalores = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.grpDatosCatalogo.SuspendLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDatosvalores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDatosCatalogo
        '
        Me.grpDatosCatalogo.Controls.Add(Me.cmdValor)
        Me.grpDatosCatalogo.Controls.Add(Me.chkActivo)
        Me.grpDatosCatalogo.Controls.Add(Me.txtNombre)
        Me.grpDatosCatalogo.Controls.Add(Me.txtDescripcion)
        Me.grpDatosCatalogo.Controls.Add(Me.Label3)
        Me.grpDatosCatalogo.Controls.Add(Me.lblDescripcion)
        Me.grpDatosCatalogo.Controls.Add(Me.lblCatalogo)
        Me.grpDatosCatalogo.Location = New System.Drawing.Point(12, 12)
        Me.grpDatosCatalogo.Name = "grpDatosCatalogo"
        Me.grpDatosCatalogo.Size = New System.Drawing.Size(383, 171)
        Me.grpDatosCatalogo.TabIndex = 0
        Me.grpDatosCatalogo.TabStop = False
        Me.grpDatosCatalogo.Text = "Datos Cat�logo :"
        '
        'cmdValor
        '
        Me.cmdValor.Location = New System.Drawing.Point(274, 132)
        Me.cmdValor.Name = "cmdValor"
        Me.cmdValor.Size = New System.Drawing.Size(96, 32)
        Me.cmdValor.TabIndex = 10
        Me.cmdValor.Tag = "ACEPTAR"
        Me.cmdValor.Text = "&AgregarValor"
        Me.cmdValor.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(162, 143)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(15, 14)
        Me.chkActivo.TabIndex = 6
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(119, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(243, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Tag = "OBLIGATORIO"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(119, 62)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(243, 64)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.Tag = "OBLIGATORIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Activo:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(15, 65)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripci�n:"
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        Me.lblCatalogo.Location = New System.Drawing.Point(15, 32)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(92, 13)
        Me.lblCatalogo.TabIndex = 0
        Me.lblCatalogo.Tag = "OBLIGATORIO"
        Me.lblCatalogo.Text = "Nombre Cat�logo:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'grdDatosvalores
        '
        Me.grdDatosvalores.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdDatosvalores.GroupByCaption = "Arrastre hacia ac� la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdDatosvalores.Images.Add(CType(resources.GetObject("grdDatosvalores.Images"), System.Drawing.Image))
        Me.grdDatosvalores.Location = New System.Drawing.Point(12, 189)
        Me.grdDatosvalores.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdDatosvalores.Name = "grdDatosvalores"
        Me.grdDatosvalores.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDatosvalores.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDatosvalores.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDatosvalores.PrintInfo.PageSettings = CType(resources.GetObject("grdDatosvalores.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDatosvalores.Size = New System.Drawing.Size(377, 126)
        Me.grdDatosvalores.TabIndex = 2
        Me.grdDatosvalores.Tag = ""
        Me.grdDatosvalores.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdDatosvalores.PropBag = resources.GetString("grdDatosvalores.PropBag")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(314, 325)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 34)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(233, 325)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 33)
        Me.cmdAceptar.TabIndex = 13
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'frmCatalogoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 371)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grdDatosvalores)
        Me.Controls.Add(Me.grpDatosCatalogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCatalogoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Agregar Cat�logo"
        Me.grpDatosCatalogo.ResumeLayout(False)
        Me.grpDatosCatalogo.PerformLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDatosvalores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatosCatalogo As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblCatalogo As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents cmdValor As System.Windows.Forms.Button
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents grdDatosvalores As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
End Class
