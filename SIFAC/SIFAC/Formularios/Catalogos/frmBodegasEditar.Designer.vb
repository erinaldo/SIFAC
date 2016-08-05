<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBodegasEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBodegasEditar))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtNombreMarca = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxCiudad = New C1.Win.C1List.C1Combo()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1Combo1 = New C1.Win.C1List.C1Combo()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cbxCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Money Twins"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(780, 355)
        Me.PanelControl1.TabIndex = 98
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = Global.SIFAC.My.Resources.Resources.Cancel16
        Me.cmdCancelar.Location = New System.Drawing.Point(427, 291)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = Global.SIFAC.My.Resources.Resources.Guardar16
        Me.cmdGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(341, 291)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.C1Combo1)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.TextBox1)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.cbxCiudad)
        Me.gbxDatosGenerales.Controls.Add(Me.chkActivo)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNombreMarca)
        Me.gbxDatosGenerales.Controls.Add(Me.lblDescripcion)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(23, 12)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(675, 243)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(587, 27)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 2
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtNombreMarca
        '
        Me.txtNombreMarca.Location = New System.Drawing.Point(181, 54)
        Me.txtNombreMarca.Name = "txtNombreMarca"
        Me.txtNombreMarca.Size = New System.Drawing.Size(279, 20)
        Me.txtNombreMarca.TabIndex = 0
        Me.txtNombreMarca.TabStop = False
        Me.txtNombreMarca.Tag = "BLOQUEADO"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(9, 127)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(100, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Tag = "OBLIGATORIO"
        Me.lblDescripcion.Text = "Jefe de Bodega:"
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(7, 54)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(54, 13)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 334)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 21)
        Me.Panel1.TabIndex = 99
        '
        'cbxCiudad
        '
        Me.cbxCiudad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cbxCiudad.Caption = ""
        Me.cbxCiudad.CaptionHeight = 17
        Me.cbxCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbxCiudad.ColumnCaptionHeight = 17
        Me.cbxCiudad.ColumnFooterHeight = 17
        Me.cbxCiudad.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cbxCiudad.ContentHeight = 15
        Me.cbxCiudad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cbxCiudad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cbxCiudad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCiudad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cbxCiudad.EditorHeight = 15
        Me.cbxCiudad.Images.Add(CType(resources.GetObject("cbxCiudad.Images"), System.Drawing.Image))
        Me.cbxCiudad.ItemHeight = 15
        Me.cbxCiudad.Location = New System.Drawing.Point(181, 84)
        Me.cbxCiudad.MatchEntryTimeout = CType(2000, Long)
        Me.cbxCiudad.MaxDropDownItems = CType(5, Short)
        Me.cbxCiudad.MaxLength = 32767
        Me.cbxCiudad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cbxCiudad.Name = "cbxCiudad"
        Me.cbxCiudad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cbxCiudad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cbxCiudad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cbxCiudad.Size = New System.Drawing.Size(279, 21)
        Me.cbxCiudad.TabIndex = 100
        Me.cbxCiudad.Tag = "OBLIGATORIO"
        Me.cbxCiudad.PropBag = resources.GetString("cbxCiudad.PropBag")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(181, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 20)
        Me.TextBox1.TabIndex = 101
        Me.TextBox1.TabStop = False
        Me.TextBox1.Tag = "BLOQUEADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Ciudad:"
        '
        'C1Combo1
        '
        Me.C1Combo1.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CaptionHeight = 17
        Me.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.C1Combo1.ContentHeight = 15
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo1.EditorHeight = 15
        Me.C1Combo1.Images.Add(CType(resources.GetObject("C1Combo1.Images"), System.Drawing.Image))
        Me.C1Combo1.ItemHeight = 15
        Me.C1Combo1.Location = New System.Drawing.Point(181, 119)
        Me.C1Combo1.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.Size = New System.Drawing.Size(279, 21)
        Me.C1Combo1.TabIndex = 104
        Me.C1Combo1.Tag = "OBLIGATORIO"
        Me.C1Combo1.PropBag = resources.GetString("C1Combo1.PropBag")
        '
        'frmBodegasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 355)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBodegasEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Bodegas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cbxCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombreMarca As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxCiudad As C1.Win.C1List.C1Combo
End Class
