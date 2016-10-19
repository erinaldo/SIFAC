<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfig))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdClaves = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ilstImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.ofdExaminador = New System.Windows.Forms.OpenFileDialog()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExaminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdClaves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdClaves)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Claves del App.Config"
        '
        'grdClaves
        '
        Me.grdClaves.AllowAddNew = True
        Me.grdClaves.AllowDelete = True
        Me.grdClaves.AlternatingRows = True
        Me.grdClaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdClaves.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdClaves.Images.Add(CType(resources.GetObject("grdClaves.Images"), System.Drawing.Image))
        Me.grdClaves.Location = New System.Drawing.Point(6, 19)
        Me.grdClaves.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.grdClaves.Name = "grdClaves"
        Me.grdClaves.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdClaves.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdClaves.PreviewInfo.ZoomFactor = 75.0R
        Me.grdClaves.PrintInfo.PageSettings = CType(resources.GetObject("grdClaves.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdClaves.Size = New System.Drawing.Size(490, 222)
        Me.grdClaves.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.grdClaves.TabIndex = 2
        Me.grdClaves.Text = "C1TrueDBGrid1"
        Me.grdClaves.PropBag = resources.GetString("grdClaves.PropBag")
        '
        'ilstImagenes
        '
        Me.ilstImagenes.ImageStream = CType(resources.GetObject("ilstImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilstImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ilstImagenes.Images.SetKeyName(0, "buscar.png")
        Me.ilstImagenes.Images.SetKeyName(1, "cancelar.png")
        Me.ilstImagenes.Images.SetKeyName(2, "Aceptar.png")
        Me.ilstImagenes.Images.SetKeyName(3, "eliminar.png")
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(15, 29)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(61, 13)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Dirección"
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtRuta.Location = New System.Drawing.Point(78, 27)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(390, 20)
        Me.txtRuta.TabIndex = 3
        Me.txtRuta.TabStop = False
        '
        'ofdExaminador
        '
        Me.ofdExaminador.FileName = "OpenFileDialog1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnExaminar)
        Me.PanelControl1.Controls.Add(Me.btnEliminar)
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnGuardar)
        Me.PanelControl1.Controls.Add(Me.lblDireccion)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(519, 348)
        Me.PanelControl1.TabIndex = 6
        '
        'btnExaminar
        '
        Me.btnExaminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.Appearance.Options.UseFont = True
        Me.btnExaminar.Image = CType(resources.GetObject("btnExaminar.Image"), System.Drawing.Image)
        Me.btnExaminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExaminar.Location = New System.Drawing.Point(474, 25)
        Me.btnExaminar.LookAndFeel.SkinName = "Caramel"
        Me.btnExaminar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(26, 28)
        Me.btnExaminar.TabIndex = 21
        Me.btnExaminar.Tag = ""
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(18, 312)
        Me.btnEliminar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.btnEliminar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(80, 28)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Tag = "ELIMINAR"
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(432, 312)
        Me.btnCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.btnCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 28)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Tag = "CANCELAR"
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(346, 312)
        Me.btnGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.btnGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 28)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Tag = "GUARDAR"
        Me.btnGuardar.Text = "&Guardar"
        '
        'FrmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 348)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilitario App.Config"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdClaves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdClaves As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents ilstImagenes As System.Windows.Forms.ImageList
    Friend WithEvents ofdExaminador As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExaminar As DevExpress.XtraEditors.SimpleButton

End Class
