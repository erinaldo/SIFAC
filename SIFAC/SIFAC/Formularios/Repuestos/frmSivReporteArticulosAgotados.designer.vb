<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivReporteArticulosAgotados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivReporteArticulosAgotados))
        Me.gbCriterios = New System.Windows.Forms.GroupBox
        Me.cmbTienda = New C1.Win.C1List.C1Combo
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.lblTipoRepuesto = New System.Windows.Forms.Label
        Me.cmbTipoRepuesto = New C1.Win.C1List.C1Combo
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.gbCriterios.SuspendLayout()
        CType(Me.cmbTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCriterios
        '
        Me.gbCriterios.Controls.Add(Me.cmbTienda)
        Me.gbCriterios.Controls.Add(Me.lblSucursal)
        Me.gbCriterios.Controls.Add(Me.lblTipoRepuesto)
        Me.gbCriterios.Controls.Add(Me.cmbTipoRepuesto)
        Me.gbCriterios.Location = New System.Drawing.Point(12, 12)
        Me.gbCriterios.Name = "gbCriterios"
        Me.gbCriterios.Size = New System.Drawing.Size(328, 83)
        Me.gbCriterios.TabIndex = 0
        Me.gbCriterios.TabStop = False
        Me.gbCriterios.Text = "Criterios"
        '
        'cmbTienda
        '
        Me.cmbTienda.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTienda.AllowColMove = False
        Me.cmbTienda.AllowSort = False
        Me.cmbTienda.Caption = ""
        Me.cmbTienda.CaptionHeight = 17
        Me.cmbTienda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTienda.ColumnCaptionHeight = 17
        Me.cmbTienda.ColumnFooterHeight = 17
        Me.cmbTienda.ColumnHeaders = False
        Me.cmbTienda.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTienda.ContentHeight = 15
        Me.cmbTienda.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTienda.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTienda.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTienda.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTienda.EditorHeight = 15
        Me.cmbTienda.Images.Add(CType(resources.GetObject("cmbTienda.Images"), System.Drawing.Image))
        Me.cmbTienda.ItemHeight = 15
        Me.cmbTienda.Location = New System.Drawing.Point(88, 24)
        Me.cmbTienda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTienda.MaxDropDownItems = CType(5, Short)
        Me.cmbTienda.MaxLength = 32767
        Me.cmbTienda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTienda.Name = "cmbTienda"
        Me.cmbTienda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTienda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTienda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTienda.Size = New System.Drawing.Size(234, 21)
        Me.cmbTienda.TabIndex = 7
        Me.cmbTienda.PropBag = resources.GetString("cmbTienda.PropBag")
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(6, 24)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 6
        Me.lblSucursal.Text = "Sucursal:"
        '
        'lblTipoRepuesto
        '
        Me.lblTipoRepuesto.AutoSize = True
        Me.lblTipoRepuesto.Location = New System.Drawing.Point(5, 51)
        Me.lblTipoRepuesto.Name = "lblTipoRepuesto"
        Me.lblTipoRepuesto.Size = New System.Drawing.Size(80, 13)
        Me.lblTipoRepuesto.TabIndex = 5
        Me.lblTipoRepuesto.Text = "Tipo Repuesto:"
        '
        'cmbTipoRepuesto
        '
        Me.cmbTipoRepuesto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoRepuesto.AllowColMove = False
        Me.cmbTipoRepuesto.AllowSort = False
        Me.cmbTipoRepuesto.Caption = ""
        Me.cmbTipoRepuesto.CaptionHeight = 17
        Me.cmbTipoRepuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoRepuesto.ColumnCaptionHeight = 17
        Me.cmbTipoRepuesto.ColumnFooterHeight = 17
        Me.cmbTipoRepuesto.ColumnHeaders = False
        Me.cmbTipoRepuesto.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoRepuesto.ContentHeight = 15
        Me.cmbTipoRepuesto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoRepuesto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoRepuesto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoRepuesto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoRepuesto.EditorHeight = 15
        Me.cmbTipoRepuesto.Images.Add(CType(resources.GetObject("cmbTipoRepuesto.Images"), System.Drawing.Image))
        Me.cmbTipoRepuesto.ItemHeight = 15
        Me.cmbTipoRepuesto.Location = New System.Drawing.Point(88, 51)
        Me.cmbTipoRepuesto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoRepuesto.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoRepuesto.MaxLength = 32767
        Me.cmbTipoRepuesto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoRepuesto.Name = "cmbTipoRepuesto"
        Me.cmbTipoRepuesto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoRepuesto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoRepuesto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoRepuesto.Size = New System.Drawing.Size(234, 21)
        Me.cmbTipoRepuesto.TabIndex = 4
        Me.cmbTipoRepuesto.PropBag = resources.GetString("cmbTipoRepuesto.PropBag")
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(184, 101)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(265, 101)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmSivReporteArticulosAgotados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 138)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gbCriterios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivReporteArticulosAgotados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Artículos Agotados"
        Me.gbCriterios.ResumeLayout(False)
        Me.gbCriterios.PerformLayout()
        CType(Me.cmbTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTipoRepuesto As C1.Win.C1List.C1Combo
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblTipoRepuesto As System.Windows.Forms.Label
    Friend WithEvents cmbTienda As C1.Win.C1List.C1Combo
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
End Class
