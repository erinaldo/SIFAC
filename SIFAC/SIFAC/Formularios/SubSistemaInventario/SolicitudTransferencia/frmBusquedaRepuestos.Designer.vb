<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaRepuestos))
        Me.gbxResultados = New System.Windows.Forms.GroupBox()
        Me.grdResultados = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmbTipo = New C1.Win.C1List.C1Combo()
        Me.cmbProveedor = New C1.Win.C1List.C1Combo()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblModeloCompatible = New System.Windows.Forms.Label()
        Me.cmbMarca = New C1.Win.C1List.C1Combo()
        Me.cmbModeloCompatible = New C1.Win.C1List.C1Combo()
        Me.cmdFiltrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gbxResultados.SuspendLayout()
        CType(Me.grdResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbModeloCompatible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxResultados
        '
        Me.gbxResultados.Controls.Add(Me.grdResultados)
        Me.gbxResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxResultados.Location = New System.Drawing.Point(11, 199)
        Me.gbxResultados.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxResultados.Name = "gbxResultados"
        Me.gbxResultados.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxResultados.Size = New System.Drawing.Size(1011, 306)
        Me.gbxResultados.TabIndex = 5
        Me.gbxResultados.TabStop = False
        Me.gbxResultados.Text = "Resultado Filtros"
        '
        'grdResultados
        '
        Me.grdResultados.CaptionHeight = 19
        Me.grdResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdResultados.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdResultados.Images.Add(CType(resources.GetObject("grdResultados.Images"), System.Drawing.Image))
        Me.grdResultados.Location = New System.Drawing.Point(19, 30)
        Me.grdResultados.Margin = New System.Windows.Forms.Padding(4)
        Me.grdResultados.Name = "grdResultados"
        Me.grdResultados.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdResultados.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdResultados.PreviewInfo.ZoomFactor = 75.0R
        Me.grdResultados.PrintInfo.PageSettings = CType(resources.GetObject("grdResultados.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdResultados.RowHeight = 17
        Me.grdResultados.Size = New System.Drawing.Size(986, 275)
        Me.grdResultados.TabIndex = 0
        Me.grdResultados.Text = "Resultados"
        Me.grdResultados.PropBag = resources.GetString("grdResultados.PropBag")
        '
        'cmbTipo
        '
        Me.cmbTipo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipo.Caption = ""
        Me.cmbTipo.CaptionHeight = 17
        Me.cmbTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipo.ColumnCaptionHeight = 17
        Me.cmbTipo.ColumnFooterHeight = 17
        Me.cmbTipo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipo.ContentHeight = 18
        Me.cmbTipo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipo.EditorHeight = 18
        Me.cmbTipo.Images.Add(CType(resources.GetObject("cmbTipo.Images"), System.Drawing.Image))
        Me.cmbTipo.ItemHeight = 15
        Me.cmbTipo.Location = New System.Drawing.Point(188, 65)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipo.MaxDropDownItems = CType(5, Short)
        Me.cmbTipo.MaxLength = 32767
        Me.cmbTipo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipo.Size = New System.Drawing.Size(231, 24)
        Me.cmbTipo.TabIndex = 1
        Me.cmbTipo.Tag = ""
        Me.cmbTipo.PropBag = resources.GetString("cmbTipo.PropBag")
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProveedor.Caption = ""
        Me.cmbProveedor.CaptionHeight = 17
        Me.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProveedor.ColumnCaptionHeight = 17
        Me.cmbProveedor.ColumnFooterHeight = 17
        Me.cmbProveedor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbProveedor.ContentHeight = 18
        Me.cmbProveedor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProveedor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProveedor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProveedor.EditorHeight = 18
        Me.cmbProveedor.Images.Add(CType(resources.GetObject("cmbProveedor.Images"), System.Drawing.Image))
        Me.cmbProveedor.ItemHeight = 15
        Me.cmbProveedor.Location = New System.Drawing.Point(188, 27)
        Me.cmbProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProveedor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProveedor.MaxDropDownItems = CType(5, Short)
        Me.cmbProveedor.MaxLength = 32767
        Me.cmbProveedor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProveedor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProveedor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProveedor.Size = New System.Drawing.Size(231, 24)
        Me.cmbProveedor.TabIndex = 0
        Me.cmbProveedor.PropBag = resources.GetString("cmbProveedor.PropBag")
        '
        'lbltipo
        '
        Me.lbltipo.BackColor = System.Drawing.Color.Transparent
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(28, 68)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(109, 22)
        Me.lbltipo.TabIndex = 97
        Me.lbltipo.Tag = ""
        Me.lbltipo.Text = "Tipo:"
        '
        'lblProveedor
        '
        Me.lblProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(28, 28)
        Me.lblProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(109, 22)
        Me.lblProveedor.TabIndex = 96
        Me.lblProveedor.Tag = ""
        Me.lblProveedor.Text = "Proveedor:"
        '
        'lblMarca
        '
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(28, 108)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(109, 22)
        Me.lblMarca.TabIndex = 96
        Me.lblMarca.Tag = ""
        Me.lblMarca.Text = "Marca:"
        '
        'lblModeloCompatible
        '
        Me.lblModeloCompatible.BackColor = System.Drawing.Color.Transparent
        Me.lblModeloCompatible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloCompatible.Location = New System.Drawing.Point(28, 149)
        Me.lblModeloCompatible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModeloCompatible.Name = "lblModeloCompatible"
        Me.lblModeloCompatible.Size = New System.Drawing.Size(137, 22)
        Me.lblModeloCompatible.TabIndex = 97
        Me.lblModeloCompatible.Tag = ""
        Me.lblModeloCompatible.Text = "Modelo Compatible:"
        '
        'cmbMarca
        '
        Me.cmbMarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMarca.Caption = ""
        Me.cmbMarca.CaptionHeight = 17
        Me.cmbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMarca.ColumnCaptionHeight = 17
        Me.cmbMarca.ColumnFooterHeight = 17
        Me.cmbMarca.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMarca.ContentHeight = 18
        Me.cmbMarca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMarca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMarca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMarca.EditorHeight = 18
        Me.cmbMarca.Images.Add(CType(resources.GetObject("cmbMarca.Images"), System.Drawing.Image))
        Me.cmbMarca.ItemHeight = 15
        Me.cmbMarca.Location = New System.Drawing.Point(188, 107)
        Me.cmbMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMarca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMarca.MaxDropDownItems = CType(5, Short)
        Me.cmbMarca.MaxLength = 32767
        Me.cmbMarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMarca.Size = New System.Drawing.Size(231, 24)
        Me.cmbMarca.TabIndex = 2
        Me.cmbMarca.PropBag = resources.GetString("cmbMarca.PropBag")
        '
        'cmbModeloCompatible
        '
        Me.cmbModeloCompatible.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbModeloCompatible.Caption = ""
        Me.cmbModeloCompatible.CaptionHeight = 17
        Me.cmbModeloCompatible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbModeloCompatible.ColumnCaptionHeight = 17
        Me.cmbModeloCompatible.ColumnFooterHeight = 17
        Me.cmbModeloCompatible.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbModeloCompatible.ContentHeight = 18
        Me.cmbModeloCompatible.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbModeloCompatible.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbModeloCompatible.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModeloCompatible.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbModeloCompatible.EditorHeight = 18
        Me.cmbModeloCompatible.Images.Add(CType(resources.GetObject("cmbModeloCompatible.Images"), System.Drawing.Image))
        Me.cmbModeloCompatible.ItemHeight = 15
        Me.cmbModeloCompatible.Location = New System.Drawing.Point(188, 145)
        Me.cmbModeloCompatible.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbModeloCompatible.MatchEntryTimeout = CType(2000, Long)
        Me.cmbModeloCompatible.MaxDropDownItems = CType(5, Short)
        Me.cmbModeloCompatible.MaxLength = 32767
        Me.cmbModeloCompatible.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbModeloCompatible.Name = "cmbModeloCompatible"
        Me.cmbModeloCompatible.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbModeloCompatible.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbModeloCompatible.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbModeloCompatible.Size = New System.Drawing.Size(231, 24)
        Me.cmbModeloCompatible.TabIndex = 3
        Me.cmbModeloCompatible.Tag = ""
        Me.cmbModeloCompatible.PropBag = resources.GetString("cmbModeloCompatible.PropBag")
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltrar.Location = New System.Drawing.Point(455, 145)
        Me.cmdFiltrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(115, 32)
        Me.cmdFiltrar.TabIndex = 4
        Me.cmdFiltrar.Text = "Filtrar"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 575)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 26)
        Me.Panel1.TabIndex = 102
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(892, 529)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(113, 37)
        Me.cmdCancelar.TabIndex = 104
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
        Me.cmdAceptar.Location = New System.Drawing.Point(785, 529)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(99, 37)
        Me.cmdAceptar.TabIndex = 103
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmbProveedor)
        Me.PanelControl1.Controls.Add(Me.lblProveedor)
        Me.PanelControl1.Controls.Add(Me.lbltipo)
        Me.PanelControl1.Controls.Add(Me.gbxResultados)
        Me.PanelControl1.Controls.Add(Me.cmdFiltrar)
        Me.PanelControl1.Controls.Add(Me.lblMarca)
        Me.PanelControl1.Controls.Add(Me.cmbModeloCompatible)
        Me.PanelControl1.Controls.Add(Me.lblModeloCompatible)
        Me.PanelControl1.Controls.Add(Me.cmbMarca)
        Me.PanelControl1.Controls.Add(Me.cmbTipo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1021, 601)
        Me.PanelControl1.TabIndex = 105
        '
        'frmBusquedaRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusquedaRepuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda de Producto"
        Me.gbxResultados.ResumeLayout(False)
        CType(Me.grdResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbModeloCompatible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxResultados As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTipo As C1.Win.C1List.C1Combo
    Friend WithEvents cmbProveedor As C1.Win.C1List.C1Combo
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblModeloCompatible As System.Windows.Forms.Label
    Friend WithEvents cmbMarca As C1.Win.C1List.C1Combo
    Friend WithEvents cmbModeloCompatible As C1.Win.C1List.C1Combo
    Friend WithEvents cmdFiltrar As System.Windows.Forms.Button
    Friend WithEvents grdResultados As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
