<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriteriosReporteListadoPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCriteriosReporteListadoPrecios))
        Me.gbxCriterios = New System.Windows.Forms.GroupBox
        Me.lblBodega = New System.Windows.Forms.Label
        Me.cmbTiendas = New C1.Win.C1List.C1Combo
        Me.rbtTodos = New System.Windows.Forms.RadioButton
        Me.rbtRepuestosExistencia = New System.Windows.Forms.RadioButton
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gbxCriterios.SuspendLayout()
        CType(Me.cmbTiendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxCriterios
        '
        Me.gbxCriterios.Controls.Add(Me.lblBodega)
        Me.gbxCriterios.Controls.Add(Me.cmbTiendas)
        Me.gbxCriterios.Controls.Add(Me.rbtTodos)
        Me.gbxCriterios.Controls.Add(Me.rbtRepuestosExistencia)
        Me.gbxCriterios.Location = New System.Drawing.Point(5, 40)
        Me.gbxCriterios.Name = "gbxCriterios"
        Me.gbxCriterios.Size = New System.Drawing.Size(336, 130)
        Me.gbxCriterios.TabIndex = 0
        Me.gbxCriterios.TabStop = False
        Me.gbxCriterios.Text = "Criterios"
        '
        'lblBodega
        '
        Me.lblBodega.AutoSize = True
        Me.lblBodega.Location = New System.Drawing.Point(21, 23)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(47, 13)
        Me.lblBodega.TabIndex = 4
        Me.lblBodega.Text = "Bodega:"
        '
        'cmbTiendas
        '
        Me.cmbTiendas.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTiendas.Caption = ""
        Me.cmbTiendas.CaptionHeight = 17
        Me.cmbTiendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTiendas.ColumnCaptionHeight = 17
        Me.cmbTiendas.ColumnFooterHeight = 17
        Me.cmbTiendas.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTiendas.ContentHeight = 15
        Me.cmbTiendas.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTiendas.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTiendas.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTiendas.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTiendas.EditorHeight = 15
        Me.cmbTiendas.Images.Add(CType(resources.GetObject("cmbTiendas.Images"), System.Drawing.Image))
        Me.cmbTiendas.ItemHeight = 15
        Me.cmbTiendas.Location = New System.Drawing.Point(71, 19)
        Me.cmbTiendas.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTiendas.MaxDropDownItems = CType(5, Short)
        Me.cmbTiendas.MaxLength = 32767
        Me.cmbTiendas.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTiendas.Name = "cmbTiendas"
        Me.cmbTiendas.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTiendas.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTiendas.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTiendas.Size = New System.Drawing.Size(217, 21)
        Me.cmbTiendas.TabIndex = 3
        Me.cmbTiendas.PropBag = resources.GetString("cmbTiendas.PropBag")
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Checked = True
        Me.rbtTodos.Location = New System.Drawing.Point(24, 93)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodos.TabIndex = 0
        Me.rbtTodos.TabStop = True
        Me.rbtTodos.Text = "Todos"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'rbtRepuestosExistencia
        '
        Me.rbtRepuestosExistencia.AutoSize = True
        Me.rbtRepuestosExistencia.Location = New System.Drawing.Point(24, 56)
        Me.rbtRepuestosExistencia.Name = "rbtRepuestosExistencia"
        Me.rbtRepuestosExistencia.Size = New System.Drawing.Size(165, 17)
        Me.rbtRepuestosExistencia.TabIndex = 0
        Me.rbtRepuestosExistencia.TabStop = True
        Me.rbtRepuestosExistencia.Text = "Sólo Repuestos en existencia"
        Me.rbtRepuestosExistencia.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(267, 176)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(187, 176)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(353, 32)
        Me.Panel2.TabIndex = 94
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(288, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SCCUM.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 21)
        Me.Panel1.TabIndex = 95
        '
        'frmCriteriosReporteListadoPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gbxCriterios)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCriteriosReporteListadoPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imprimir listado de precios"
        Me.gbxCriterios.ResumeLayout(False)
        Me.gbxCriterios.PerformLayout()
        CType(Me.cmbTiendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtRepuestosExistencia As System.Windows.Forms.RadioButton
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents cmbTiendas As C1.Win.C1List.C1Combo
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
