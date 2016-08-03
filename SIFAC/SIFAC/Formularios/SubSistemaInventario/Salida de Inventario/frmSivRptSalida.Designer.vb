<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivRptSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivRptSalida))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbTipoSalida = New C1.Win.C1List.C1Combo
        Me.cmbBodega = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.ErrorRptSalida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbTipoSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorRptSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(71, 59)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(188, 18)
        Me.dtpFechaHasta.TabIndex = 13
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(71, 31)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(188, 18)
        Me.dtpFechaDesde.TabIndex = 12
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTipoSalida)
        Me.GroupBox2.Controls.Add(Me.cmbBodega)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterio"
        '
        'cmbTipoSalida
        '
        Me.cmbTipoSalida.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoSalida.Caption = ""
        Me.cmbTipoSalida.CaptionHeight = 17
        Me.cmbTipoSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoSalida.ColumnCaptionHeight = 17
        Me.cmbTipoSalida.ColumnFooterHeight = 17
        Me.cmbTipoSalida.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoSalida.ContentHeight = 15
        Me.cmbTipoSalida.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoSalida.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoSalida.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoSalida.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoSalida.EditorHeight = 15
        Me.cmbTipoSalida.Images.Add(CType(resources.GetObject("cmbTipoSalida.Images"), System.Drawing.Image))
        Me.cmbTipoSalida.ItemHeight = 15
        Me.cmbTipoSalida.Location = New System.Drawing.Point(90, 49)
        Me.cmbTipoSalida.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoSalida.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoSalida.MaxLength = 32767
        Me.cmbTipoSalida.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoSalida.Name = "cmbTipoSalida"
        Me.cmbTipoSalida.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoSalida.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoSalida.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoSalida.Size = New System.Drawing.Size(169, 21)
        Me.cmbTipoSalida.TabIndex = 4
        Me.cmbTipoSalida.PropBag = resources.GetString("cmbTipoSalida.PropBag")
        '
        'cmbBodega
        '
        Me.cmbBodega.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodega.Caption = ""
        Me.cmbBodega.CaptionHeight = 17
        Me.cmbBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodega.ColumnCaptionHeight = 17
        Me.cmbBodega.ColumnFooterHeight = 17
        Me.cmbBodega.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbBodega.ContentHeight = 15
        Me.cmbBodega.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBodega.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBodega.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodega.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodega.EditorHeight = 15
        Me.cmbBodega.Images.Add(CType(resources.GetObject("cmbBodega.Images"), System.Drawing.Image))
        Me.cmbBodega.ItemHeight = 15
        Me.cmbBodega.Location = New System.Drawing.Point(90, 23)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(169, 21)
        Me.cmbBodega.TabIndex = 3
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo Salida:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bodega:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(154, 250)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 31)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(235, 250)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 31)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'ErrorRptSalida
        '
        Me.ErrorRptSalida.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 290)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 21)
        Me.Panel1.TabIndex = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(247, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 32)
        Me.Panel2.TabIndex = 49
        Me.Panel2.Tag = "LAYOUT"
        '
        'frmSivRptSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 311)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivRptSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Salidas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbTipoSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorRptSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbTipoSalida As C1.Win.C1List.C1Combo
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents ErrorRptSalida As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
