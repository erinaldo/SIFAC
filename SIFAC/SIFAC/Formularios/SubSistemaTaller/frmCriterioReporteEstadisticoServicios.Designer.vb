<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriterioReporteEstadisticoServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCriterioReporteEstadisticoServicios))
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit
        Me.lblHasta = New System.Windows.Forms.Label
        Me.gbxPeriodo = New System.Windows.Forms.GroupBox
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ErrErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.lblBodega = New System.Windows.Forms.Label
        Me.gbxCriterios = New System.Windows.Forms.GroupBox
        Me.cmbSucursales = New C1.Win.C1List.C1Combo
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPeriodo.SuspendLayout()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCriterios.SuspendLayout()
        CType(Me.cmbSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(53, 67)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(131, 18)
        Me.dtpFechaHasta.TabIndex = 1
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(6, 67)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 0
        Me.lblHasta.Text = "Hasta:"
        '
        'gbxPeriodo
        '
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaHasta)
        Me.gbxPeriodo.Controls.Add(Me.lblHasta)
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaDesde)
        Me.gbxPeriodo.Controls.Add(Me.Label2)
        Me.gbxPeriodo.Location = New System.Drawing.Point(388, 51)
        Me.gbxPeriodo.Name = "gbxPeriodo"
        Me.gbxPeriodo.Size = New System.Drawing.Size(198, 112)
        Me.gbxPeriodo.TabIndex = 110
        Me.gbxPeriodo.TabStop = False
        Me.gbxPeriodo.Text = "Per�odo"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(53, 31)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(131, 18)
        Me.dtpFechaDesde.TabIndex = 0
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde:"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 32)
        Me.Panel2.TabIndex = 106
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(529, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(512, 175)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 105
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 21)
        Me.Panel1.TabIndex = 107
        '
        'ErrErrores
        '
        Me.ErrErrores.ContainerControl = Me
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(432, 175)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 104
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'lblBodega
        '
        Me.lblBodega.AutoSize = True
        Me.lblBodega.Location = New System.Drawing.Point(14, 35)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(51, 13)
        Me.lblBodega.TabIndex = 4
        Me.lblBodega.Text = "Sucursal:"
        '
        'gbxCriterios
        '
        Me.gbxCriterios.Controls.Add(Me.lblBodega)
        Me.gbxCriterios.Controls.Add(Me.cmbSucursales)
        Me.gbxCriterios.Location = New System.Drawing.Point(12, 51)
        Me.gbxCriterios.Name = "gbxCriterios"
        Me.gbxCriterios.Size = New System.Drawing.Size(370, 112)
        Me.gbxCriterios.TabIndex = 103
        Me.gbxCriterios.TabStop = False
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
        Me.cmbSucursales.Location = New System.Drawing.Point(71, 31)
        Me.cmbSucursales.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSucursales.MaxDropDownItems = CType(5, Short)
        Me.cmbSucursales.MaxLength = 32767
        Me.cmbSucursales.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSucursales.Name = "cmbSucursales"
        Me.cmbSucursales.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSucursales.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSucursales.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSucursales.Size = New System.Drawing.Size(244, 21)
        Me.cmbSucursales.TabIndex = 3
        Me.cmbSucursales.PropBag = resources.GetString("cmbSucursales.PropBag")
        '
        'frmCriterioReporteEstadisticoServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 236)
        Me.Controls.Add(Me.gbxPeriodo)
        Me.Controls.Add(Me.lblEncabezado)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.gbxCriterios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCriterioReporteEstadisticoServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Estad�stico de servicios de taller"
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPeriodo.ResumeLayout(False)
        Me.gbxPeriodo.PerformLayout()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCriterios.ResumeLayout(False)
        Me.gbxCriterios.PerformLayout()
        CType(Me.cmbSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents gbxPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrErrores As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents gbxCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents cmbSucursales As C1.Win.C1List.C1Combo
End Class
