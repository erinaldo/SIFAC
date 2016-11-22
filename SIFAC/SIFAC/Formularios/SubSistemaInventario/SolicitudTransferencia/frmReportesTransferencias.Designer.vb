<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesTransferencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesTransferencias))
        Me.gbxPeriodo = New System.Windows.Forms.GroupBox()
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxCriterio = New System.Windows.Forms.GroupBox()
        Me.cmbEstados = New C1.Win.C1List.C1Combo()
        Me.cmbSitioDestino = New C1.Win.C1List.C1Combo()
        Me.cmbSitioOrigen = New C1.Win.C1List.C1Combo()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSitioOrigen = New System.Windows.Forms.Label()
        Me.ErrProveedor = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gbxPeriodo.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCriterio.SuspendLayout()
        CType(Me.cmbEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSitioDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSitioOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPeriodo
        '
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaHasta)
        Me.gbxPeriodo.Controls.Add(Me.lblHasta)
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaDesde)
        Me.gbxPeriodo.Controls.Add(Me.Label1)
        Me.gbxPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPeriodo.Location = New System.Drawing.Point(15, 15)
        Me.gbxPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxPeriodo.Name = "gbxPeriodo"
        Me.gbxPeriodo.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxPeriodo.Size = New System.Drawing.Size(437, 132)
        Me.gbxPeriodo.TabIndex = 0
        Me.gbxPeriodo.TabStop = False
        Me.gbxPeriodo.Text = "Período"
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
        Me.dtpFechaHasta.Calendar.SelectedDate = New Date(2016, 8, 8, 0, 0, 0, 0)
        Me.dtpFechaHasta.Calendar.TodayText = "&Today"
        Me.dtpFechaHasta.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(125, 82)
        Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(232, 21)
        Me.dtpFechaHasta.TabIndex = 1
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(35, 82)
        Me.lblHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(55, 17)
        Me.lblHasta.TabIndex = 0
        Me.lblHasta.Text = "Hasta:"
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
        Me.dtpFechaDesde.Calendar.SelectedDate = New Date(2016, 8, 8, 0, 0, 0, 0)
        Me.dtpFechaDesde.Calendar.TodayText = "&Today"
        Me.dtpFechaDesde.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(125, 38)
        Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(232, 21)
        Me.dtpFechaDesde.TabIndex = 0
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'gbxCriterio
        '
        Me.gbxCriterio.Controls.Add(Me.cmbEstados)
        Me.gbxCriterio.Controls.Add(Me.cmbSitioDestino)
        Me.gbxCriterio.Controls.Add(Me.cmbSitioOrigen)
        Me.gbxCriterio.Controls.Add(Me.lblEstado)
        Me.gbxCriterio.Controls.Add(Me.Label2)
        Me.gbxCriterio.Controls.Add(Me.lblSitioOrigen)
        Me.gbxCriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCriterio.Location = New System.Drawing.Point(8, 158)
        Me.gbxCriterio.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxCriterio.Name = "gbxCriterio"
        Me.gbxCriterio.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxCriterio.Size = New System.Drawing.Size(437, 167)
        Me.gbxCriterio.TabIndex = 0
        Me.gbxCriterio.TabStop = False
        Me.gbxCriterio.Text = "Criterio"
        '
        'cmbEstados
        '
        Me.cmbEstados.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEstados.Caption = ""
        Me.cmbEstados.CaptionHeight = 17
        Me.cmbEstados.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEstados.ColumnCaptionHeight = 17
        Me.cmbEstados.ColumnFooterHeight = 17
        Me.cmbEstados.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbEstados.ContentHeight = 18
        Me.cmbEstados.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEstados.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEstados.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstados.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstados.EditorHeight = 18
        Me.cmbEstados.Images.Add(CType(resources.GetObject("cmbEstados.Images"), System.Drawing.Image))
        Me.cmbEstados.ItemHeight = 15
        Me.cmbEstados.Location = New System.Drawing.Point(164, 124)
        Me.cmbEstados.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstados.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEstados.MaxDropDownItems = CType(5, Short)
        Me.cmbEstados.MaxLength = 32767
        Me.cmbEstados.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEstados.Name = "cmbEstados"
        Me.cmbEstados.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEstados.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEstados.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEstados.Size = New System.Drawing.Size(232, 24)
        Me.cmbEstados.TabIndex = 4
        Me.cmbEstados.PropBag = resources.GetString("cmbEstados.PropBag")
        '
        'cmbSitioDestino
        '
        Me.cmbSitioDestino.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSitioDestino.Caption = ""
        Me.cmbSitioDestino.CaptionHeight = 17
        Me.cmbSitioDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSitioDestino.ColumnCaptionHeight = 17
        Me.cmbSitioDestino.ColumnFooterHeight = 17
        Me.cmbSitioDestino.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSitioDestino.ContentHeight = 18
        Me.cmbSitioDestino.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSitioDestino.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSitioDestino.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSitioDestino.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSitioDestino.EditorHeight = 18
        Me.cmbSitioDestino.Images.Add(CType(resources.GetObject("cmbSitioDestino.Images"), System.Drawing.Image))
        Me.cmbSitioDestino.ItemHeight = 15
        Me.cmbSitioDestino.Location = New System.Drawing.Point(164, 78)
        Me.cmbSitioDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSitioDestino.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSitioDestino.MaxDropDownItems = CType(5, Short)
        Me.cmbSitioDestino.MaxLength = 32767
        Me.cmbSitioDestino.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSitioDestino.Name = "cmbSitioDestino"
        Me.cmbSitioDestino.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSitioDestino.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSitioDestino.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSitioDestino.Size = New System.Drawing.Size(232, 24)
        Me.cmbSitioDestino.TabIndex = 3
        Me.cmbSitioDestino.PropBag = resources.GetString("cmbSitioDestino.PropBag")
        '
        'cmbSitioOrigen
        '
        Me.cmbSitioOrigen.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSitioOrigen.Caption = ""
        Me.cmbSitioOrigen.CaptionHeight = 17
        Me.cmbSitioOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSitioOrigen.ColumnCaptionHeight = 17
        Me.cmbSitioOrigen.ColumnFooterHeight = 17
        Me.cmbSitioOrigen.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbSitioOrigen.ContentHeight = 18
        Me.cmbSitioOrigen.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSitioOrigen.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSitioOrigen.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSitioOrigen.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSitioOrigen.EditorHeight = 18
        Me.cmbSitioOrigen.Images.Add(CType(resources.GetObject("cmbSitioOrigen.Images"), System.Drawing.Image))
        Me.cmbSitioOrigen.ItemHeight = 15
        Me.cmbSitioOrigen.Location = New System.Drawing.Point(164, 33)
        Me.cmbSitioOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSitioOrigen.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSitioOrigen.MaxDropDownItems = CType(5, Short)
        Me.cmbSitioOrigen.MaxLength = 32767
        Me.cmbSitioOrigen.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSitioOrigen.Name = "cmbSitioOrigen"
        Me.cmbSitioOrigen.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSitioOrigen.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSitioOrigen.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSitioOrigen.Size = New System.Drawing.Size(232, 24)
        Me.cmbSitioOrigen.TabIndex = 2
        Me.cmbSitioOrigen.PropBag = resources.GetString("cmbSitioOrigen.PropBag")
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(35, 129)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(63, 17)
        Me.lblEstado.TabIndex = 0
        Me.lblEstado.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bodega Destino:"
        '
        'lblSitioOrigen
        '
        Me.lblSitioOrigen.AutoSize = True
        Me.lblSitioOrigen.Location = New System.Drawing.Point(35, 38)
        Me.lblSitioOrigen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSitioOrigen.Name = "lblSitioOrigen"
        Me.lblSitioOrigen.Size = New System.Drawing.Size(122, 17)
        Me.lblSitioOrigen.TabIndex = 0
        Me.lblSitioOrigen.Text = "Bodega Origen:"
        '
        'ErrProveedor
        '
        Me.ErrProveedor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrProveedor.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 388)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 26)
        Me.Panel1.TabIndex = 95
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(329, 340)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(113, 37)
        Me.cmdCancelar.TabIndex = 54
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(223, 340)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(99, 37)
        Me.cmdAceptar.TabIndex = 53
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gbxPeriodo)
        Me.PanelControl1.Controls.Add(Me.gbxCriterio)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(459, 414)
        Me.PanelControl1.TabIndex = 96
        '
        'frmReportesTransferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportesTransferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de solicitudes de traslados"
        Me.gbxPeriodo.ResumeLayout(False)
        Me.gbxPeriodo.PerformLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCriterio.ResumeLayout(False)
        Me.gbxCriterio.PerformLayout()
        CType(Me.cmbEstados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSitioDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSitioOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents gbxCriterio As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSitioOrigen As System.Windows.Forms.Label
    Friend WithEvents cmbEstados As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSitioDestino As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSitioOrigen As C1.Win.C1List.C1Combo
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents ErrProveedor As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
