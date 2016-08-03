<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSivBuscarSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSivBuscarSalida))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNumeroSalida = New C1.Win.C1Input.C1NumericEdit
        Me.cmbTipoSalida = New C1.Win.C1List.C1Combo
        Me.cmbBodega = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpFechaHasta = New C1.Win.C1Input.C1DateEdit
        Me.dtpFechaDesde = New C1.Win.C1Input.C1DateEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.ErrorBuscar = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtNumeroSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumeroSalida)
        Me.GroupBox1.Controls.Add(Me.cmbTipoSalida)
        Me.GroupBox1.Controls.Add(Me.cmbBodega)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'txtNumeroSalida
        '
        Me.txtNumeroSalida.Location = New System.Drawing.Point(107, 22)
        Me.txtNumeroSalida.MaxLength = 10
        Me.txtNumeroSalida.Name = "txtNumeroSalida"
        Me.txtNumeroSalida.Size = New System.Drawing.Size(171, 20)
        Me.txtNumeroSalida.TabIndex = 6
        Me.txtNumeroSalida.Tag = Nothing
        Me.txtNumeroSalida.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.cmbTipoSalida.Location = New System.Drawing.Point(107, 80)
        Me.cmbTipoSalida.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoSalida.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoSalida.MaxLength = 32767
        Me.cmbTipoSalida.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoSalida.Name = "cmbTipoSalida"
        Me.cmbTipoSalida.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoSalida.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoSalida.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoSalida.Size = New System.Drawing.Size(171, 21)
        Me.cmbTipoSalida.TabIndex = 5
        Me.cmbTipoSalida.Text = "NO APLICA"
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
        Me.cmbBodega.Location = New System.Drawing.Point(107, 52)
        Me.cmbBodega.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBodega.MaxDropDownItems = CType(5, Short)
        Me.cmbBodega.MaxLength = 32767
        Me.cmbBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBodega.Size = New System.Drawing.Size(171, 21)
        Me.cmbBodega.TabIndex = 4
        Me.cmbBodega.Text = "NO APLICA"
        Me.cmbBodega.PropBag = resources.GetString("cmbBodega.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Salida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bodega:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de Salida:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox2.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo Entrada"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaHasta.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaHasta.EditMask = "##/##/####"
        Me.dtpFechaHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaHasta.Location = New System.Drawing.Point(105, 56)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(144, 18)
        Me.dtpFechaHasta.TabIndex = 3
        Me.dtpFechaHasta.Tag = Nothing
        Me.dtpFechaHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaDesde.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaDesde.EditMask = "##/##/####"
        Me.dtpFechaDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaDesde.Location = New System.Drawing.Point(105, 27)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(144, 18)
        Me.dtpFechaDesde.TabIndex = 2
        Me.dtpFechaDesde.Tag = Nothing
        Me.dtpFechaDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fecha Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Desde:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 32)
        Me.Panel2.TabIndex = 29
        Me.Panel2.Tag = "LAYOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(537, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIFAC.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 21)
        Me.Panel1.TabIndex = 48
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(511, 137)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCancelar.TabIndex = 50
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(431, 137)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(74, 30)
        Me.cmdAceptar.TabIndex = 49
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'ErrorBuscar
        '
        Me.ErrorBuscar.ContainerControl = Me
        '
        'frmSivBuscarSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 196)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSivBuscarSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Salida de Bodega"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtNumeroSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbTipoSalida As C1.Win.C1List.C1Combo
    Friend WithEvents cmbBodega As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As C1.Win.C1Input.C1DateEdit
    Friend WithEvents dtpFechaDesde As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents ErrorBuscar As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtNumeroSalida As C1.Win.C1Input.C1NumericEdit
End Class
