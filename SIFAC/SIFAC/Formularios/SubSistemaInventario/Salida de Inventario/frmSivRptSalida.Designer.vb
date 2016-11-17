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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivRptSalida))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit()
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoSalida = New C1.Win.C1List.C1Combo()
        Me.cmbBodega = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorRptSalida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbTipoSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorRptSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(397, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaHasta.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaHasta.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaHasta.Calendar.ClearText = "&Clear"
        Me.dtpFechaHasta.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaHasta.Calendar.SelectedDate = New Date(2016, 8, 5, 0, 0, 0, 0)
        Me.dtpFechaHasta.Calendar.TodayText = "&Today"
        Me.dtpFechaHasta.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(95, 73)
        Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(251, 21)
        Me.dtpFechaHasta.TabIndex = 13
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpFechaDesde.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaDesde.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaDesde.Calendar.ClearText = "&Clear"
        Me.dtpFechaDesde.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaDesde.Calendar.SelectedDate = New Date(2016, 8, 5, 0, 0, 0, 0)
        Me.dtpFechaDesde.Calendar.TodayText = "&Today"
        Me.dtpFechaDesde.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(95, 38)
        Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(251, 21)
        Me.dtpFechaDesde.TabIndex = 12
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTipoSalida)
        Me.GroupBox2.Controls.Add(Me.cmbBodega)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 145)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(397, 116)
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
        Me.cmbTipoSalida.ContentHeight = 18
        Me.cmbTipoSalida.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoSalida.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoSalida.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoSalida.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoSalida.EditorHeight = 18
        Me.cmbTipoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoSalida.Images.Add(CType(resources.GetObject("cmbTipoSalida.Images"), System.Drawing.Image))
        Me.cmbTipoSalida.ItemHeight = 15
        Me.cmbTipoSalida.Location = New System.Drawing.Point(120, 60)
        Me.cmbTipoSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoSalida.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoSalida.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoSalida.MaxLength = 32767
        Me.cmbTipoSalida.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoSalida.Name = "cmbTipoSalida"
        Me.cmbTipoSalida.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoSalida.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoSalida.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoSalida.Size = New System.Drawing.Size(225, 24)
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
        Me.cmbBodega.ContentHeight = 18
        Me.cmbBodega.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBodega.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBodega.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodega.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodega.EditorHeight = 18
        Me.cmbBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodega.Images.Add(CType(resources.GetObject("cmbBodega.Images"), System.Drawing.Image))
        Me.cmbBodega.ItemHeight = 15
        Me.cmbBodega.Location = New System.Drawing.Point(120, 28)
        Me.cmbBodega.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(225, 24)
        Me.cmbBodega.TabIndex = 3
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo Salida:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bodega:"
        '
        'ErrorRptSalida
        '
        Me.ErrorRptSalida.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 320)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 26)
        Me.Panel1.TabIndex = 50
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(424, 346)
        Me.PanelControl1.TabIndex = 51
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(296, 272)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 34)
        Me.cmdCancelar.TabIndex = 80
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(181, 272)
        Me.cmdAceptar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(107, 34)
        Me.cmdAceptar.TabIndex = 79
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'frmSivRptSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 346)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbTipoSalida As C1.Win.C1List.C1Combo
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents ErrorRptSalida As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
End Class
