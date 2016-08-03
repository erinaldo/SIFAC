<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesPromociones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesPromociones))
        Me.ErrProveedor = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmbSucursales = New C1.Win.C1List.C1Combo
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit
        Me.lblHasta = New System.Windows.Forms.Label
        Me.gbxCriterio = New System.Windows.Forms.GroupBox
        Me.rdbTodas = New System.Windows.Forms.RadioButton
        Me.rdbInactivas = New System.Windows.Forms.RadioButton
        Me.rdbActivas = New System.Windows.Forms.RadioButton
        Me.lblSucursales = New System.Windows.Forms.Label
        Me.gbxPeriodo = New System.Windows.Forms.GroupBox
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.ErrProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cmbSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCriterio.SuspendLayout()
        Me.gbxPeriodo.SuspendLayout()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrProveedor
        '
        Me.ErrProveedor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrProveedor.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(279, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 21)
        Me.Panel1.TabIndex = 101
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 32)
        Me.Panel2.TabIndex = 100
        Me.Panel2.Tag = "LAYOUT"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(262, 258)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 99
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(182, 258)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 98
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
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
        Me.cmbSucursales.Location = New System.Drawing.Point(94, 27)
        Me.cmbSucursales.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursales.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursales.MaxLength = 32767
        Me.cmbSucursales.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursales.Name = "cmbSucursales"
        Me.cmbSucursales.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursales.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursales.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursales.Size = New System.Drawing.Size(174, 21)
        Me.cmbSucursales.TabIndex = 2
        Me.cmbSucursales.PropBag = resources.GetString("cmbSucursales.PropBag")
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(94, 67)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(174, 18)
        Me.dtpFechaHasta.TabIndex = 1
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(26, 67)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 0
        Me.lblHasta.Text = "Hasta:"
        '
        'gbxCriterio
        '
        Me.gbxCriterio.Controls.Add(Me.rdbTodas)
        Me.gbxCriterio.Controls.Add(Me.rdbInactivas)
        Me.gbxCriterio.Controls.Add(Me.rdbActivas)
        Me.gbxCriterio.Controls.Add(Me.cmbSucursales)
        Me.gbxCriterio.Controls.Add(Me.lblSucursales)
        Me.gbxCriterio.Location = New System.Drawing.Point(8, 146)
        Me.gbxCriterio.Name = "gbxCriterio"
        Me.gbxCriterio.Size = New System.Drawing.Size(328, 106)
        Me.gbxCriterio.TabIndex = 96
        Me.gbxCriterio.TabStop = False
        Me.gbxCriterio.Text = "Criterio"
        '
        'rdbTodas
        '
        Me.rdbTodas.AutoSize = True
        Me.rdbTodas.Checked = True
        Me.rdbTodas.Location = New System.Drawing.Point(203, 68)
        Me.rdbTodas.Name = "rdbTodas"
        Me.rdbTodas.Size = New System.Drawing.Size(55, 17)
        Me.rdbTodas.TabIndex = 3
        Me.rdbTodas.TabStop = True
        Me.rdbTodas.Text = "Todas"
        Me.rdbTodas.UseVisualStyleBackColor = True
        '
        'rdbInactivas
        '
        Me.rdbInactivas.AutoSize = True
        Me.rdbInactivas.Location = New System.Drawing.Point(112, 68)
        Me.rdbInactivas.Name = "rdbInactivas"
        Me.rdbInactivas.Size = New System.Drawing.Size(68, 17)
        Me.rdbInactivas.TabIndex = 3
        Me.rdbInactivas.Text = "Inactivas"
        Me.rdbInactivas.UseVisualStyleBackColor = True
        '
        'rdbActivas
        '
        Me.rdbActivas.AutoSize = True
        Me.rdbActivas.Location = New System.Drawing.Point(29, 68)
        Me.rdbActivas.Name = "rdbActivas"
        Me.rdbActivas.Size = New System.Drawing.Size(60, 17)
        Me.rdbActivas.TabIndex = 3
        Me.rdbActivas.Text = "Activas"
        Me.rdbActivas.UseVisualStyleBackColor = True
        '
        'lblSucursales
        '
        Me.lblSucursales.AutoSize = True
        Me.lblSucursales.Location = New System.Drawing.Point(26, 31)
        Me.lblSucursales.Name = "lblSucursales"
        Me.lblSucursales.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursales.TabIndex = 0
        Me.lblSucursales.Text = "Sucursal:"
        '
        'gbxPeriodo
        '
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaHasta)
        Me.gbxPeriodo.Controls.Add(Me.lblHasta)
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaDesde)
        Me.gbxPeriodo.Controls.Add(Me.Label1)
        Me.gbxPeriodo.Location = New System.Drawing.Point(8, 33)
        Me.gbxPeriodo.Name = "gbxPeriodo"
        Me.gbxPeriodo.Size = New System.Drawing.Size(328, 107)
        Me.gbxPeriodo.TabIndex = 97
        Me.gbxPeriodo.TabStop = False
        Me.gbxPeriodo.Text = "Período de Inicio"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(94, 31)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(174, 18)
        Me.dtpFechaDesde.TabIndex = 0
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'frmReportesPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 317)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gbxCriterio)
        Me.Controls.Add(Me.gbxPeriodo)
        Me.Name = "frmReportesPromociones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de promociones"
        CType(Me.ErrProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.cmbSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCriterio.ResumeLayout(False)
        Me.gbxCriterio.PerformLayout()
        Me.gbxPeriodo.ResumeLayout(False)
        Me.gbxPeriodo.PerformLayout()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrProveedor As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents gbxCriterio As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSucursales As C1.Win.C1List.C1Combo
    Friend WithEvents lblSucursales As System.Windows.Forms.Label
    Friend WithEvents gbxPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbInactivas As System.Windows.Forms.RadioButton
    Friend WithEvents rdbActivas As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTodas As System.Windows.Forms.RadioButton
End Class
