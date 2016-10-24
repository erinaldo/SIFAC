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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCriteriosReporteKardex))
        Me.gbxPeriodo = New System.Windows.Forms.GroupBox()
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRepuestos = New C1.Win.C1List.C1Combo()
        Me.lblEncabezado = New System.Windows.Forms.Label()
        Me.ErrErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBodegas = New C1.Win.C1List.C1Combo()
        Me.lblBodega = New System.Windows.Forms.Label()
        Me.gbxCriterios = New System.Windows.Forms.GroupBox()
        Me.grbVer = New System.Windows.Forms.GroupBox()
        Me.rbtCantidadCosto = New System.Windows.Forms.RadioButton()
        Me.rbtSoloCantidades = New System.Windows.Forms.RadioButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxPeriodo.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCriterios.SuspendLayout()
        Me.grbVer.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPeriodo
        '
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaHasta)
        Me.gbxPeriodo.Controls.Add(Me.lblHasta)
        Me.gbxPeriodo.Controls.Add(Me.dtpFechaDesde)
        Me.gbxPeriodo.Controls.Add(Me.Label2)
        Me.gbxPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPeriodo.Location = New System.Drawing.Point(15, 141)
        Me.gbxPeriodo.Name = "gbxPeriodo"
        Me.gbxPeriodo.Size = New System.Drawing.Size(305, 101)
        Me.gbxPeriodo.TabIndex = 110
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
        Me.dtpFechaHasta.Calendar.SelectedDate = New Date(2016, 8, 25, 0, 0, 0, 0)
        Me.dtpFechaHasta.Calendar.TodayText = "&Today"
        Me.dtpFechaHasta.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblHasta.Size = New System.Drawing.Size(44, 13)
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
        Me.dtpFechaDesde.Calendar.SelectedDate = New Date(2016, 8, 25, 0, 0, 0, 0)
        Me.dtpFechaDesde.Calendar.TodayText = "&Today"
        Me.dtpFechaDesde.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label2.Size = New System.Drawing.Size(47, 13)
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
        Me.cmbRepuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRepuestos.Images.Add(CType(resources.GetObject("cmbRepuestos.Images"), System.Drawing.Image))
        Me.cmbRepuestos.ItemHeight = 15
        Me.cmbRepuestos.Location = New System.Drawing.Point(81, 63)
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
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.Location = New System.Drawing.Point(12, 18)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(207, 13)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Producto:"
        '
        'cmbBodegas
        '
        Me.cmbBodegas.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBodegas.Caption = ""
        Me.cmbBodegas.CaptionHeight = 17
        Me.cmbBodegas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBodegas.ColumnCaptionHeight = 17
        Me.cmbBodegas.ColumnFooterHeight = 17
        Me.cmbBodegas.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbBodegas.ContentHeight = 15
        Me.cmbBodegas.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBodegas.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBodegas.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodegas.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodegas.EditorHeight = 15
        Me.cmbBodegas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodegas.Images.Add(CType(resources.GetObject("cmbBodegas.Images"), System.Drawing.Image))
        Me.cmbBodegas.ItemHeight = 15
        Me.cmbBodegas.Location = New System.Drawing.Point(81, 27)
        Me.cmbBodegas.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodegas.MaxDropDownItems = CType(5, Short)
        Me.cmbBodegas.MaxLength = 32767
        Me.cmbBodegas.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodegas.Name = "cmbBodegas"
        Me.cmbBodegas.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodegas.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodegas.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodegas.Size = New System.Drawing.Size(217, 21)
        Me.cmbBodegas.TabIndex = 3
        Me.cmbBodegas.PropBag = resources.GetString("cmbBodegas.PropBag")
        '
        'lblBodega
        '
        Me.lblBodega.AutoSize = True
        Me.lblBodega.Location = New System.Drawing.Point(13, 31)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(54, 13)
        Me.lblBodega.TabIndex = 4
        Me.lblBodega.Text = "Bodega:"
        '
        'gbxCriterios
        '
        Me.gbxCriterios.Controls.Add(Me.Label1)
        Me.gbxCriterios.Controls.Add(Me.lblBodega)
        Me.gbxCriterios.Controls.Add(Me.cmbRepuestos)
        Me.gbxCriterios.Controls.Add(Me.cmbBodegas)
        Me.gbxCriterios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCriterios.Location = New System.Drawing.Point(5, 34)
        Me.gbxCriterios.Name = "gbxCriterios"
        Me.gbxCriterios.Size = New System.Drawing.Size(308, 101)
        Me.gbxCriterios.TabIndex = 103
        Me.gbxCriterios.TabStop = False
        '
        'grbVer
        '
        Me.grbVer.Controls.Add(Me.rbtCantidadCosto)
        Me.grbVer.Controls.Add(Me.rbtSoloCantidades)
        Me.grbVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVer.Location = New System.Drawing.Point(326, 34)
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
        Me.rbtCantidadCosto.Size = New System.Drawing.Size(121, 17)
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
        Me.rbtSoloCantidades.Size = New System.Drawing.Size(104, 17)
        Me.rbtSoloCantidades.TabIndex = 0
        Me.rbtSoloCantidades.TabStop = True
        Me.rbtSoloCantidades.Text = "Sólo Cantidad"
        Me.rbtSoloCantidades.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.gbxPeriodo)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.grbVer)
        Me.PanelControl1.Controls.Add(Me.lblEncabezado)
        Me.PanelControl1.Controls.Add(Me.gbxCriterios)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(504, 290)
        Me.PanelControl1.TabIndex = 111
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(412, 181)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 28)
        Me.cmdCancelar.TabIndex = 84
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(326, 181)
        Me.cmdAceptar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 28)
        Me.cmdAceptar.TabIndex = 83
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'frmCriteriosReporteKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 290)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCriteriosReporteKardex"
        Me.Text = "Imprimir Reporte kardex"
        Me.gbxPeriodo.ResumeLayout(False)
        Me.gbxPeriodo.PerformLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrErrores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCriterios.ResumeLayout(False)
        Me.gbxCriterios.PerformLayout()
        Me.grbVer.ResumeLayout(False)
        Me.grbVer.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents gbxCriterios As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents cmbBodegas As C1.Win.C1List.C1Combo
    Friend WithEvents grbVer As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCantidadCosto As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSoloCantidades As System.Windows.Forms.RadioButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
End Class
