<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriteriosReporteKardex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCriteriosReporteKardex))
        Me.gbxPeriodo = New System.Windows.Forms.GroupBox
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit
        Me.lblHasta = New System.Windows.Forms.Label
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbRepuestos = New C1.Win.C1List.C1Combo
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.ErrErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSucursales = New C1.Win.C1List.C1Combo
        Me.lblBodega = New System.Windows.Forms.Label
        Me.gbxCriterios = New System.Windows.Forms.GroupBox
        Me.grbVer = New System.Windows.Forms.GroupBox
        Me.rbtCantidadCosto = New System.Windows.Forms.RadioButton
        Me.rbtSoloCantidades = New System.Windows.Forms.RadioButton
        Me.gbxPeriodo.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCriterios.SuspendLayout()
        Me.grbVer.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPeriodo
        '
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaHasta)
        Me.gbxPeriodo.Controls.Add(Me.lblHasta)
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaDesde)
        Me.gbxPeriodo.Controls.Add(Me.Label2)
        Me.gbxPeriodo.Location = New System.Drawing.Point(15, 158)
        Me.gbxPeriodo.Name = "gbxPeriodo"
        Me.gbxPeriodo.Size = New System.Drawing.Size(305, 101)
        Me.gbxPeriodo.TabIndex = 110
        Me.gbxPeriodo.TabStop = False
        Me.gbxPeriodo.Text = "Período"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(67, 64)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(131, 18)
        Me.dtpFechaHasta.TabIndex = 1
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(10, 64)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 0
        Me.lblHasta.Text = "Hasta:"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(67, 28)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(131, 18)
        Me.dtpFechaDesde.TabIndex = 0
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde:"
        '
        'cmbRepuestos
        '
        Me.cmbRepuestos.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbRepuestos.Caption = ""
        Me.cmbRepuestos.CaptionHeight = 17
        Me.cmbRepuestos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbRepuestos.ColumnCaptionHeight = 17
        Me.cmbRepuestos.ColumnFooterHeight = 17
        Me.cmbRepuestos.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbRepuestos.ContentHeight = 15
        Me.cmbRepuestos.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbRepuestos.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbRepuestos.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRepuestos.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRepuestos.EditorHeight = 15
        Me.cmbRepuestos.Images.Add(CType(resources.GetObject("cmbRepuestos.Images"), System.Drawing.Image))
        Me.cmbRepuestos.ItemHeight = 15
        Me.cmbRepuestos.Location = New System.Drawing.Point(70, 63)
        Me.cmbRepuestos.MatchEntryTimeout = CType(2000, Long)
        Me.cmbRepuestos.MaxDropDownItems = CType(5, Short)
        Me.cmbRepuestos.MaxLength = 32767
        Me.cmbRepuestos.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbRepuestos.Name = "cmbRepuestos"
        Me.cmbRepuestos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbRepuestos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbRepuestos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbRepuestos.Size = New System.Drawing.Size(217, 21)
        Me.cmbRepuestos.TabIndex = 3
        Me.cmbRepuestos.PropBag = resources.GetString("cmbRepuestos.PropBag")
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Location = New System.Drawing.Point(12, 35)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(171, 13)
        Me.lblEncabezado.TabIndex = 108
        Me.lblEncabezado.Text = "Seleccione criterio para su reporte:"
        '
        'ErrErrores
        '
        Me.ErrErrores.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 269)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 21)
        Me.Panel1.TabIndex = 107
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 32)
        Me.Panel2.TabIndex = 106
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(439, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(338, 229)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 104
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(418, 229)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 105
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Repuesto:"
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
        Me.cmbSucursales.Location = New System.Drawing.Point(70, 27)
        Me.cmbSucursales.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursales.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursales.MaxLength = 32767
        Me.cmbSucursales.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursales.Name = "cmbSucursales"
        Me.cmbSucursales.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursales.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursales.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursales.Size = New System.Drawing.Size(217, 21)
        Me.cmbSucursales.TabIndex = 3
        Me.cmbSucursales.PropBag = resources.GetString("cmbSucursales.PropBag")
        '
        'lblBodega
        '
        Me.lblBodega.AutoSize = True
        Me.lblBodega.Location = New System.Drawing.Point(13, 31)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(51, 13)
        Me.lblBodega.TabIndex = 4
        Me.lblBodega.Text = "Sucursal:"
        '
        'gbxCriterios
        '
        Me.gbxCriterios.Controls.Add(Me.Label1)
        Me.gbxCriterios.Controls.Add(Me.lblBodega)
        Me.gbxCriterios.Controls.Add(Me.cmbRepuestos)
        Me.gbxCriterios.Controls.Add(Me.cmbSucursales)
        Me.gbxCriterios.Location = New System.Drawing.Point(12, 51)
        Me.gbxCriterios.Name = "gbxCriterios"
        Me.gbxCriterios.Size = New System.Drawing.Size(308, 101)
        Me.gbxCriterios.TabIndex = 103
        Me.gbxCriterios.TabStop = False
        '
        'grbVer
        '
        Me.grbVer.Controls.Add(Me.rbtCantidadCosto)
        Me.grbVer.Controls.Add(Me.rbtSoloCantidades)
        Me.grbVer.Location = New System.Drawing.Point(326, 51)
        Me.grbVer.Name = "grbVer"
        Me.grbVer.Size = New System.Drawing.Size(166, 101)
        Me.grbVer.TabIndex = 110
        Me.grbVer.TabStop = False
        Me.grbVer.Text = "Ver"
        '
        'rbtCantidadCosto
        '
        Me.rbtCantidadCosto.AutoSize = True
        Me.rbtCantidadCosto.Checked = True
        Me.rbtCantidadCosto.Location = New System.Drawing.Point(28, 63)
        Me.rbtCantidadCosto.Name = "rbtCantidadCosto"
        Me.rbtCantidadCosto.Size = New System.Drawing.Size(105, 17)
        Me.rbtCantidadCosto.TabIndex = 0
        Me.rbtCantidadCosto.TabStop = True
        Me.rbtCantidadCosto.Text = "Cantidad y Costo"
        Me.rbtCantidadCosto.UseVisualStyleBackColor = True
        '
        'rbtSoloCantidades
        '
        Me.rbtSoloCantidades.AutoSize = True
        Me.rbtSoloCantidades.Location = New System.Drawing.Point(28, 29)
        Me.rbtSoloCantidades.Name = "rbtSoloCantidades"
        Me.rbtSoloCantidades.Size = New System.Drawing.Size(91, 17)
        Me.rbtSoloCantidades.TabIndex = 0
        Me.rbtSoloCantidades.TabStop = True
        Me.rbtSoloCantidades.Text = "Sólo Cantidad"
        Me.rbtSoloCantidades.UseVisualStyleBackColor = True
        '
        'frmCriteriosReporteKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 290)
        Me.Controls.Add(Me.grbVer)
        Me.Controls.Add(Me.gbxPeriodo)
        Me.Controls.Add(Me.lblEncabezado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.gbxCriterios)
        Me.Name = "frmCriteriosReporteKardex"
        Me.Text = "Imprimir Reporte kardex"
        Me.gbxPeriodo.ResumeLayout(False)
        Me.gbxPeriodo.PerformLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCriterios.ResumeLayout(False)
        Me.gbxCriterios.PerformLayout()
        Me.grbVer.ResumeLayout(False)
        Me.grbVer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRepuestos As C1.Win.C1List.C1Combo
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents ErrErrores As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents gbxCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents cmbSucursales As C1.Win.C1List.C1Combo
    Friend WithEvents grbVer As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCantidadCosto As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSoloCantidades As System.Windows.Forms.RadioButton
End Class
