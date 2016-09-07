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
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdDatosvalores = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdValor = New DevExpress.XtraEditors.SimpleButton()
        Me.grpDatosCatalogo.SuspendLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDatosvalores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
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
        Me.grpDatosCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosCatalogo.Location = New System.Drawing.Point(12, 10)
        Me.grpDatosCatalogo.Name = "grpDatosCatalogo"
        Me.grpDatosCatalogo.Size = New System.Drawing.Size(383, 171)
        Me.grpDatosCatalogo.TabIndex = 0
        Me.grpDatosCatalogo.TabStop = False
        Me.grpDatosCatalogo.Text = "Datos Catálogo :"
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
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(119, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(243, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Tag = "OBLIGATORIO"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Activo:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(7, 65)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(78, 13)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        Me.lblCatalogo.Location = New System.Drawing.Point(7, 32)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(108, 13)
        Me.lblCatalogo.TabIndex = 0
        Me.lblCatalogo.Tag = "OBLIGATORIO"
        Me.lblCatalogo.Text = "Nombre Catálogo:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'grdDatosvalores
        '
        Me.grdDatosvalores.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdDatosvalores.GroupByCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        Me.grdDatosvalores.Images.Add(CType(resources.GetObject("grdDatosvalores.Images"), System.Drawing.Image))
        Me.grdDatosvalores.Location = New System.Drawing.Point(12, 187)
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.grpDatosCatalogo)
        Me.PanelControl1.Controls.Add(Me.grdDatosvalores)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(401, 365)
        Me.PanelControl1.TabIndex = 14
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(314, 325)
        Me.cmdCancelar.LookAndFeel.SkinName = "Caramel"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 17
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(228, 325)
        Me.cmdAceptar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 28)
        Me.cmdAceptar.TabIndex = 16
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdValor
        '
        Me.cmdValor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdValor.Appearance.Options.UseFont = True
        Me.cmdValor.Image = CType(resources.GetObject("cmdValor.Image"), System.Drawing.Image)
        Me.cmdValor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdValor.Location = New System.Drawing.Point(255, 141)
        Me.cmdValor.LookAndFeel.SkinName = "Caramel"
        Me.cmdValor.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdValor.Name = "cmdValor"
        Me.cmdValor.Size = New System.Drawing.Size(107, 28)
        Me.cmdValor.TabIndex = 17
        Me.cmdValor.Tag = "ACEPTAR"
        Me.cmdValor.Text = "&AgregarValor"
        '
        'frmCatalogoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 365)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCatalogoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Agregar Catálogo"
        Me.grpDatosCatalogo.ResumeLayout(False)
        Me.grpDatosCatalogo.PerformLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDatosvalores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatosCatalogo As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblCatalogo As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents grdDatosvalores As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdValor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
End Class
