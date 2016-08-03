<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriteriosReporteBitacoraMoto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCriteriosReporteBitacoraMoto))
        Me.ErrErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbSucursales = New C1.Win.C1List.C1Combo
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.gbxCriterios = New System.Windows.Forms.GroupBox
        Me.lblExpedientes = New System.Windows.Forms.Label
        Me.cmbClientesCartera = New DevExpress.XtraEditors.LookUpEdit
        Me.chkClientesCartera = New System.Windows.Forms.CheckBox
        Me.cmbExpedientes = New DevExpress.XtraEditors.LookUpEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.gbxOtrosClientes = New System.Windows.Forms.GroupBox
        Me.chkOtrosClientes = New System.Windows.Forms.CheckBox
        Me.cmbMotos = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbOtrosClientes = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCriterios.SuspendLayout()
        CType(Me.cmbClientesCartera.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbExpedientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gbxOtrosClientes.SuspendLayout()
        CType(Me.cmbMotos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOtrosClientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrErrores
        '
        Me.ErrErrores.ContainerControl = Me
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(355, 264)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 113
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 21)
        Me.Panel1.TabIndex = 115
        '
        'cmbSucursales
        '
        Me.cmbSucursales.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSucursales.Caption = ""
        Me.cmbSucursales.CaptionHeight = 17
        Me.cmbSucursales.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSucursales.ColumnCaptionHeight = 17
        Me.cmbSucursales.ColumnFooterHeight = 17
        Me.cmbSucursales.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSucursales.ContentHeight = 15
        Me.cmbSucursales.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSucursales.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSucursales.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursales.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSucursales.EditorHeight = 15
        Me.cmbSucursales.Images.Add(CType(resources.GetObject("cmbSucursales.Images"), System.Drawing.Image))
        Me.cmbSucursales.ItemHeight = 15
        Me.cmbSucursales.Location = New System.Drawing.Point(250, 38)
        Me.cmbSucursales.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursales.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursales.MaxLength = 32767
        Me.cmbSucursales.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursales.Name = "cmbSucursales"
        Me.cmbSucursales.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursales.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursales.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursales.Size = New System.Drawing.Size(179, 21)
        Me.cmbSucursales.TabIndex = 3
        Me.cmbSucursales.Visible = False
        Me.cmbSucursales.PropBag = resources.GetString("cmbSucursales.PropBag")
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(275, 264)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 112
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'gbxCriterios
        '
        Me.gbxCriterios.Controls.Add(Me.lblExpedientes)
        Me.gbxCriterios.Controls.Add(Me.cmbClientesCartera)
        Me.gbxCriterios.Controls.Add(Me.chkClientesCartera)
        Me.gbxCriterios.Controls.Add(Me.cmbExpedientes)
        Me.gbxCriterios.Location = New System.Drawing.Point(12, 61)
        Me.gbxCriterios.Name = "gbxCriterios"
        Me.gbxCriterios.Size = New System.Drawing.Size(417, 94)
        Me.gbxCriterios.TabIndex = 111
        Me.gbxCriterios.TabStop = False
        Me.gbxCriterios.Text = "Clientes de Cartera"
        '
        'lblExpedientes
        '
        Me.lblExpedientes.AutoSize = True
        Me.lblExpedientes.Location = New System.Drawing.Point(22, 61)
        Me.lblExpedientes.Name = "lblExpedientes"
        Me.lblExpedientes.Size = New System.Drawing.Size(68, 13)
        Me.lblExpedientes.TabIndex = 122
        Me.lblExpedientes.Text = "Expedientes:"
        '
        'cmbClientesCartera
        '
        Me.cmbClientesCartera.EditValue = ""
        Me.cmbClientesCartera.Location = New System.Drawing.Point(97, 27)
        Me.cmbClientesCartera.Name = "cmbClientesCartera"
        Me.cmbClientesCartera.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbClientesCartera.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("StbPersonaID", "Código Cliente", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cliente", "Nombre", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbClientesCartera.Properties.DisplayMember = "Cliente"
        Me.cmbClientesCartera.Properties.NullText = ""
        Me.cmbClientesCartera.Properties.ShowFooter = False
        Me.cmbClientesCartera.Properties.ValueMember = "StbPersonaID"
        Me.cmbClientesCartera.Size = New System.Drawing.Size(300, 20)
        Me.cmbClientesCartera.TabIndex = 121
        '
        'chkClientesCartera
        '
        Me.chkClientesCartera.AutoSize = True
        Me.chkClientesCartera.Checked = True
        Me.chkClientesCartera.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClientesCartera.Location = New System.Drawing.Point(25, 29)
        Me.chkClientesCartera.Name = "chkClientesCartera"
        Me.chkClientesCartera.Size = New System.Drawing.Size(66, 17)
        Me.chkClientesCartera.TabIndex = 120
        Me.chkClientesCartera.Text = "Clientes:"
        Me.chkClientesCartera.UseVisualStyleBackColor = True
        '
        'cmbExpedientes
        '
        Me.cmbExpedientes.EditValue = ""
        Me.cmbExpedientes.Location = New System.Drawing.Point(97, 58)
        Me.cmbExpedientes.Name = "cmbExpedientes"
        Me.cmbExpedientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbExpedientes.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Numero", "Numero", 10), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumeroMostrar", "No. Cuenta", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moto", "Motocicleta", 60)})
        Me.cmbExpedientes.Properties.DisplayMember = "NumeroMostrar"
        Me.cmbExpedientes.Properties.DropDownRows = 5
        Me.cmbExpedientes.Properties.NullText = ""
        Me.cmbExpedientes.Properties.ValueMember = "Numero"
        Me.cmbExpedientes.Size = New System.Drawing.Size(300, 20)
        Me.cmbExpedientes.TabIndex = 119
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(375, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Location = New System.Drawing.Point(12, 35)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(171, 13)
        Me.lblEncabezado.TabIndex = 116
        Me.lblEncabezado.Text = "Seleccione criterio para su reporte:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(437, 32)
        Me.Panel2.TabIndex = 114
        Me.Panel2.Tag = "LAYOUT"
        '
        'gbxOtrosClientes
        '
        Me.gbxOtrosClientes.Controls.Add(Me.chkOtrosClientes)
        Me.gbxOtrosClientes.Controls.Add(Me.cmbMotos)
        Me.gbxOtrosClientes.Controls.Add(Me.cmbOtrosClientes)
        Me.gbxOtrosClientes.Controls.Add(Me.Label3)
        Me.gbxOtrosClientes.Location = New System.Drawing.Point(12, 161)
        Me.gbxOtrosClientes.Name = "gbxOtrosClientes"
        Me.gbxOtrosClientes.Size = New System.Drawing.Size(417, 94)
        Me.gbxOtrosClientes.TabIndex = 111
        Me.gbxOtrosClientes.TabStop = False
        Me.gbxOtrosClientes.Text = "Otros clientes"
        '
        'chkOtrosClientes
        '
        Me.chkOtrosClientes.AutoSize = True
        Me.chkOtrosClientes.Location = New System.Drawing.Point(24, 26)
        Me.chkOtrosClientes.Name = "chkOtrosClientes"
        Me.chkOtrosClientes.Size = New System.Drawing.Size(66, 17)
        Me.chkOtrosClientes.TabIndex = 121
        Me.chkOtrosClientes.Text = "Clientes:"
        Me.chkOtrosClientes.UseVisualStyleBackColor = True
        '
        'cmbMotos
        '
        Me.cmbMotos.EditValue = ""
        Me.cmbMotos.Location = New System.Drawing.Point(97, 61)
        Me.cmbMotos.Name = "cmbMotos"
        Me.cmbMotos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMotos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoMotorMoto"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModeloMoto"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MarcaMoto"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PlacaMoto"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorMoto")})
        Me.cmbMotos.Properties.DisplayMember = "NumeroMostrar"
        Me.cmbMotos.Properties.DropDownRows = 5
        Me.cmbMotos.Properties.NullText = ""
        Me.cmbMotos.Properties.PopupWidth = 350
        Me.cmbMotos.Properties.ValueMember = "Numero"
        Me.cmbMotos.Size = New System.Drawing.Size(300, 20)
        Me.cmbMotos.TabIndex = 119
        '
        'cmbOtrosClientes
        '
        Me.cmbOtrosClientes.EditValue = ""
        Me.cmbOtrosClientes.Location = New System.Drawing.Point(97, 26)
        Me.cmbOtrosClientes.Name = "cmbOtrosClientes"
        Me.cmbOtrosClientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOtrosClientes.Properties.DisplayMember = "NumeroMostrar"
        Me.cmbOtrosClientes.Properties.DropDownRows = 5
        Me.cmbOtrosClientes.Properties.NullText = ""
        Me.cmbOtrosClientes.Properties.ShowFooter = False
        Me.cmbOtrosClientes.Properties.ShowHeader = False
        Me.cmbOtrosClientes.Properties.ValueMember = "Numero"
        Me.cmbOtrosClientes.Size = New System.Drawing.Size(300, 20)
        Me.cmbOtrosClientes.TabIndex = 119
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Motos:"
        '
        'frmCriteriosReporteBitacoraMoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 321)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gbxOtrosClientes)
        Me.Controls.Add(Me.cmbSucursales)
        Me.Controls.Add(Me.gbxCriterios)
        Me.Controls.Add(Me.lblEncabezado)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCriteriosReporteBitacoraMoto"
        Me.Text = "Reporte de Bitácora de moto."
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCriterios.ResumeLayout(False)
        Me.gbxCriterios.PerformLayout()
        CType(Me.cmbClientesCartera.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbExpedientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.gbxOtrosClientes.ResumeLayout(False)
        Me.gbxOtrosClientes.PerformLayout()
        CType(Me.cmbMotos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOtrosClientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrErrores As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents gbxCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSucursales As C1.Win.C1List.C1Combo
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbExpedientes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gbxOtrosClientes As System.Windows.Forms.GroupBox
    Friend WithEvents cmbOtrosClientes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbMotos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkClientesCartera As System.Windows.Forms.CheckBox
    Friend WithEvents cmbClientesCartera As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkOtrosClientes As System.Windows.Forms.CheckBox
    Friend WithEvents lblExpedientes As System.Windows.Forms.Label
End Class
