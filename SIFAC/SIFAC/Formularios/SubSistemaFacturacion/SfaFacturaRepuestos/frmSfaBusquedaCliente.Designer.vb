<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSfaBusquedaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSfaBusquedaCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdCliente = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdNuevaPersona = New System.Windows.Forms.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPedido = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grdCliente)
        Me.Panel1.Location = New System.Drawing.Point(12, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 245)
        Me.Panel1.TabIndex = 0
        '
        'grdCliente
        '
        Me.grdCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCliente.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdCliente.Images.Add(CType(resources.GetObject("grdCliente.Images"), System.Drawing.Image))
        Me.grdCliente.Location = New System.Drawing.Point(0, 0)
        Me.grdCliente.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCliente.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCliente.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCliente.PrintInfo.PageSettings = CType(resources.GetObject("grdCliente.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCliente.Size = New System.Drawing.Size(486, 245)
        Me.grdCliente.TabIndex = 0
        Me.grdCliente.PropBag = resources.GetString("grdCliente.PropBag")
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 334)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(511, 22)
        Me.Panel3.TabIndex = 7
        '
        'cmdNuevaPersona
        '
        Me.cmdNuevaPersona.Image = CType(resources.GetObject("cmdNuevaPersona.Image"), System.Drawing.Image)
        Me.cmdNuevaPersona.Location = New System.Drawing.Point(298, 297)
        Me.cmdNuevaPersona.Name = "cmdNuevaPersona"
        Me.cmdNuevaPersona.Size = New System.Drawing.Size(40, 35)
        Me.cmdNuevaPersona.TabIndex = 0
        Me.cmdNuevaPersona.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(511, 356)
        Me.PanelControl1.TabIndex = 34
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cmdCancelar)
        Me.PanelControl2.Controls.Add(Me.cmdAceptar)
        Me.PanelControl2.Controls.Add(Me.cmdPedido)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.cmdGuardar)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(507, 352)
        Me.PanelControl2.TabIndex = 29
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(421, 298)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 119
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(339, 298)
        Me.cmdAceptar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 28)
        Me.cmdAceptar.TabIndex = 118
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdPedido
        '
        Me.cmdPedido.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPedido.Appearance.Options.UseFont = True
        Me.cmdPedido.Image = CType(resources.GetObject("cmdPedido.Image"), System.Drawing.Image)
        Me.cmdPedido.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPedido.Location = New System.Drawing.Point(29, 575)
        Me.cmdPedido.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdPedido.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPedido.Name = "cmdPedido"
        Me.cmdPedido.Size = New System.Drawing.Size(121, 28)
        Me.cmdPedido.TabIndex = 117
        Me.cmdPedido.Tag = "PEDIDO"
        Me.cmdPedido.Text = "&Generar Pedido"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(759, 572)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(673, 572)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmSfaBusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 356)
        Me.Controls.Add(Me.cmdNuevaPersona)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSfaBusquedaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Cliente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdCliente As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdNuevaPersona As System.Windows.Forms.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdPedido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
End Class
